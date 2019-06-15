Option Strict On
Option Infer On

Imports System.Collections.Immutable
Imports TornCity.Net

Public Class UserSelector
    Implements ISelector, IRange

    Public ReadOnly Property Fields As ImmutableArray(Of Type) Implements ISelector.Fields

    Public ReadOnly Property ApiEndpoint As String Implements ISelector.ApiEndpoint
        Get
            Return "user"
        End Get
    End Property

    Public Property UnixTimeFrom As Long Implements IRange.UnixTimeFrom
    Public Property UnixTimeTo As Long Implements IRange.UnixTimeTo


    Public Sub New(ParamArray selections() As UserSelection)
        Dim unique = selections.Distinct.ToImmutableArray
        Fields = unique.Select(Function(u) u.ToTornResource()).ToImmutableArray
    End Sub

    ''' <summary>
    ''' Set the time period in which data should be retrieved from
    ''' Currently only available on the attacks field selection (API limitation)
    ''' </summary>
    ''' <param name="timeFrom">The earliest point in time to retrieve results from</param>
    ''' <param name="timeTo">The latest point in time to retrieve results to</param>
    Public Function WithRange(timeFrom As DateTimeOffset, Optional timeTo? As DateTimeOffset = Nothing) As UserSelector
        UnixTimeFrom = timeFrom.ToUnixTimeSeconds
        UnixTimeTo = If(timeTo.HasValue, timeTo.Value.ToUnixTimeSeconds, 0)
        Return Me
    End Function

    ''' <summary>
    ''' Creates a formatted query string for the API request
    ''' </summary>
    ''' <returns>Formatted API request string</returns>
    Public Function Resolve() As String Implements ISelector.Resolve
        Dim timeFrom = If(UnixTimeFrom = 0, "", $"&from={UnixTimeFrom}")
        Dim timeTo = If(UnixTimeTo = 0, "", $"&to={UnixTimeTo}")
        Return $"{String.Join(",", Fields.Select(Function(type) type.Name.ToLower))}{timeFrom}{timeTo}"
    End Function
End Class
