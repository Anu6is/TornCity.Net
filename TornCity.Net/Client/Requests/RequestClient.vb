Option Strict On
Option Infer On

Imports System.IO
Imports System.Net.Http
Imports System.Net.Http.Headers
Imports LazyCache
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports TornCity.Net.Models.Common

Friend Class RequestClient
    Implements IDisposable

    Private ReadOnly _config As TornClientConfig
    Private ReadOnly _httpClient As HttpClient
    Private ReadOnly _serializer As JsonSerializer
    Private ReadOnly _cache As IAppCache = New CachingService

    ''' <summary>
    ''' Request client constructor
    ''' </summary>
    Friend Sub New(config As TornClientConfig)
        _config = config
        _serializer = New JsonSerializer

        If _config.HttpMessageHandler Is Nothing Then
            _httpClient = New HttpClient With {.BaseAddress = _config.ApiBaseUrl}
        Else
            _httpClient = New HttpClient(_config.HttpMessageHandler) With {.BaseAddress = _config.ApiBaseUrl}
        End If

        _httpClient.DefaultRequestHeaders.Accept.Add(New MediaTypeWithQualityHeaderValue("application/json"))
    End Sub

    ''' <summary>
    ''' Send a request to the Torn API or retrieve previously cached results 
    ''' Results are cached (indexed) based on the request uri. Cache expires after <see cref="TornClientConfig.CacheDurationSeconds"/> 
    ''' </summary>
    ''' <typeparam name="T">The type of Torn resource being requested (example: <see cref="Models.User.Profile"/></typeparam>
    ''' <param name="requestUri">The endpoint and query parameters for the Torn API request</param>
    ''' <returns>An instance of the specified resource type</returns>
    Friend Async Function SendAsync(Of T As {TornResource, New})(requestUri As String) As Task(Of T)
        Using request = New HttpRequestMessage(HttpMethod.Get, $"{_config.ApiBaseUrl}{requestUri}")
            Return Await _cache.GetOrAddAsync(requestUri,
                                              Async Function() Await SendAsync(Of T)(request),
                                              DateTimeOffset.Now.AddSeconds(_config.CacheDurationSeconds))
        End Using
    End Function

    ''' <summary>
    ''' Send a request to the Torn API or retrieve previously cached results
    ''' Results are cached (indexed) based on the request uri. Cache expires after <see cref="TornClientConfig.CacheDurationSeconds"/>
    ''' </summary>
    ''' <param name="requestUri">The endpoint and query parameters for the Torn API request</param>
    ''' <param name="selections">The desired fields for the given API endpoint</param>
    ''' <returns>A Dictionary containing all specified resource selections</returns>
    Friend Async Function SendAsync(requestUri As String, selections As ISelector) As Task(Of Dictionary(Of String, TornResource))
        Using request = New HttpRequestMessage(HttpMethod.Get, $"{_config.ApiBaseUrl}{requestUri}")
            Return Await _cache.GetOrAddAsync(requestUri,
                                              Async Function() Await SendAsync(request, selections),
                                              DateTimeOffset.Now.AddSeconds(_config.CacheDurationSeconds))
        End Using
    End Function

    ''' <summary>
    ''' Send a request to the Torn API
    ''' </summary>
    ''' <typeparam name="T">The type of Torn resource being requested (example: <see cref="Models.User.Profile"/></typeparam>
    ''' <param name="request">The Http request message to be sent</param>
    ''' <returns>An instance of the specified resource type</returns>
    Private Async Function SendAsync(Of T As {TornResource, New})(request As HttpRequestMessage) As Task(Of T)
        Try
            Using responseMsg = Await _httpClient.SendAsync(request)
                Dim stream = Await responseMsg.Content.ReadAsStreamAsync()
                Return DeserializeStream(Of T)(stream)
            End Using
        Catch ex As Exception
            Console.WriteLine($"{vbNewLine}Error [TORN]: {ex.Message}: {ex.ToString}")
            Return New T With {.ErrorMessage = ex.Message}
        End Try
    End Function

    ''' <summary>
    ''' Send a request to the Torn API
    ''' </summary>
    ''' <param name="request">The Http request message to be sent</param>
    ''' <param name="selections">The desired fields for the given API endpoint</param>
    ''' <returns>A Dictionary containing all specified resource selections</returns>
    Private Async Function SendAsync(request As HttpRequestMessage, selections As ISelector) As Task(Of Dictionary(Of String, TornResource))
        Try
            Using responseMsg = Await _httpClient.SendAsync(request)
                Dim stream = Await responseMsg.Content.ReadAsStreamAsync()
                Return DeserializeStream(stream, selections)
            End Using
        Catch ex As Exception
            Console.WriteLine($"{vbNewLine}Error [TORN]: {ex.Message}: {ex.ToString}")
            Return New Dictionary(Of String, TornResource) From {{"error", New [Error] With {.ErrorMessage = ex.Message}}}
        End Try
    End Function


    ''' <summary>
    ''' Deserialize the provided stream
    ''' </summary>
    ''' <typeparam name="T">The type of Torn resource to deserialize to</typeparam>
    ''' <param name="stream">The stream to be deserialized</param>
    ''' <param name="selections">Additional types to be deserialized</param>
    ''' <returns>An instance of the specified resource type</returns>
    Private Function DeserializeStream(Of T As {TornResource, New})(stream As Stream) As T
        If stream Is Nothing OrElse Not stream.CanRead Then Return Nothing

        Using reader = New StreamReader(stream)
            Using textReader = New JsonTextReader(reader)
                Dim token = JObject.Load(textReader)

                If token.First.Path.Equals("error") Then
                    Dim requestError = _serializer.Deserialize(Of [Error])(token.CreateReader)

                    Console.WriteLine($"{vbNewLine}Error [TORN]: {requestError.ApiError.Code} - {requestError.ApiError.Message}")

                    Return New T With {.ErrorMessage = $"Status Code[{requestError.ApiError.Code}]: {requestError.ApiError.Message}"}
                Else
                    Return _serializer.Deserialize(Of T)(token.CreateReader)
                End If
            End Using
        End Using
    End Function

    ''' <summary>
    ''' Deserialize the provided stream into multiple <see cref="TornResource"/> types
    ''' </summary>
    ''' <param name="stream">The stream to be deserialized</param>
    ''' <param name="selections">The selected API resource types</param>
    ''' <returns>A Dictionary containing all specified resource selections</returns>
    Private Function DeserializeStream(stream As Stream, selections As ISelector) As Dictionary(Of String, TornResource)
        If stream Is Nothing OrElse Not stream.CanRead Then Return Nothing

        Using reader = New StreamReader(stream)
            Using textReader = New JsonTextReader(reader)
                Dim token = JObject.Load(textReader)

                If token.First.Path.Equals("error") Then
                    Dim requestError = _serializer.Deserialize(Of [Error])(token.CreateReader)
                    requestError.ErrorMessage = $"Status Code[{requestError.ApiError.Code}]: {requestError.ApiError.Message}"

                    Console.WriteLine($"{vbNewLine}Error [TORN]: {requestError.ErrorMessage}")

                    Return New Dictionary(Of String, TornResource) From {{"error", requestError}}
                Else
                    Dim responses As New Dictionary(Of String, TornResource)

                    For Each selector In selections.Fields
                        responses.Add(selector.Name.ToLower, DirectCast(_serializer.Deserialize(token.CreateReader, selector), TornResource))
                    Next

                    Return responses
                End If
            End Using
        End Using
    End Function

    Private disposedValue As Boolean
    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not disposedValue Then
            If disposing Then
                _httpClient.Dispose()
            End If
        End If
        disposedValue = True
    End Sub
    Public Sub Dispose() Implements IDisposable.Dispose
        Dispose(True)
    End Sub
End Class
