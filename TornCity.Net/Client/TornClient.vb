Option Strict On
Option Infer On

Public NotInheritable Class TornClient
    Private ReadOnly _apiKey As String
    Private ReadOnly _requestClient As RequestClient

    ''' <summary>
    ''' Constructor for Torn API wrapper client
    ''' </summary>
    ''' <param name="apiKey">The default API key to be used for making API requests</param>
    Public Sub New(apiKey As String)
        MyClass.New(New TornClientConfig With {.ApiKey = apiKey})
    End Sub

    Public Sub New(config As TornClientConfig)
        If String.IsNullOrWhiteSpace(config.ApiKey) Then Throw New ArgumentNullException("API key cannot be null or empty")

        _apiKey = config.ApiKey
        _requestClient = New RequestClient(config)
    End Sub

    ''' <summary>
    ''' Send a request to the Torn API for a specified resource type
    ''' </summary>
    ''' <typeparam name="T">The type of resource to retrieve</typeparam>
    ''' <param name="resourceId">Optional id for the given resouce type (example: user id for a User Profile)</param>
    ''' <param name="apiKey">Optional api key for requesting restricted data not related to the default api key</param>
    ''' <returns>An instance of the specified resource type</returns>
    Public Async Function SendRequestAsync(Of T As {TornResource, New})(Optional resourceId As ULong? = Nothing,
                                                                        Optional apiKey As String = Nothing) As Task(Of T)
        Dim requestKey = If(apiKey, _apiKey)

        If String.IsNullOrWhiteSpace(requestKey) Then Throw New ArgumentNullException("API key cannot be null or empty")

        Dim resourceType = GetType(T)
        Dim endpoint = resourceType.Namespace.Split("."c).Last.ToLower
        Dim selection = resourceType.Name.ToLower
        Dim request = $"{endpoint}/{resourceId}?selections={selection}&key={requestKey}"

        Return Await _requestClient.SendAsync(Of T)(request)
    End Function

    ''' <summary>
    ''' Send a request to the Torn API for a specified resource type
    ''' </summary>
    ''' <param name="selection">Additinal API fields to be retrieved with this request</param>
    ''' <param name="resourceId">Optional id for the given resource type (example: user id for a User Profile)</param>
    ''' <param name="apiKey">Optional api key for requesting restricted data not related to the default api key</param>
    ''' <returns>A dictionary of selected resource types</returns>
    Public Async Function SendRequestAsync(selections As ISelector,
                                           Optional resourceId As ULong? = Nothing,
                                           Optional apiKey As String = Nothing) As Task(Of Dictionary(Of String, TornResource))
        Dim requestKey = If(apiKey, _apiKey)

        If String.IsNullOrWhiteSpace(requestKey) Then Throw New ArgumentNullException("API key cannot be null or empty")

        Dim request = $"{selections.ApiEndpoint}/{resourceId}?selections={selections.Resolve}&key={_apiKey}"

        Return Await _requestClient.SendAsync(request, selections)
    End Function
End Class
