Imports Newtonsoft.Json

Namespace Models.User
    Public Class Basic
        Inherits TornResource

        <JsonProperty("level")>
        Public Property Level As Long
        <JsonProperty("gender")>
        Public Property Gender As String
        <JsonProperty("player_id")>
        Public Property PlayerId As Long
        <JsonProperty("name")>
        Public Property Name As String
        <JsonProperty("status")>
        Public Property Status As List(Of String)
    End Class
End Namespace
