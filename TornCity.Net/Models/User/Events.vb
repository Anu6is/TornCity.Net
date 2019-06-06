Imports Newtonsoft.Json

Namespace Models.User
    Public Class Events
        Inherits TornResource

        <JsonProperty("events")>
        Public Property Events As Dictionary(Of String, EventData)
    End Class

    Public Class EventData
        <JsonProperty("timestamp")>
        Public Property Timestamp As Long
        <JsonProperty("event")>
        Public Property [Event] As String
        <JsonProperty("seen")>
        Public Property Seen As Long
    End Class
End Namespace
