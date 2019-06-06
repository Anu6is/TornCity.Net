Imports Newtonsoft.Json

Namespace Models.User
    Public Class Messages
        Inherits TornResource

        <JsonProperty("messages")>
        Public Property Messages As Dictionary(Of String, Message)
    End Class

    Public Class Message
        <JsonProperty("timestamp")>
        Public Property Timestamp As Long
        <JsonProperty("ID")>
        Public Property Id As Long
        <JsonProperty("name")>
        Public Property Name As String
        <JsonProperty("type")>
        Public Property Type As String
        <JsonProperty("title")>
        Public Property Title As String
        <JsonProperty("seen")>
        Public Property Seen As Long
        <JsonProperty("read")>
        Public Property Read As Long
    End Class
End Namespace
