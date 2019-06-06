Imports Newtonsoft.Json

Namespace Models.Common
    Public Class Revives
        Inherits TornResource

        <JsonProperty("revives")>
        Public Property Revives As Dictionary(Of String, Revive)
    End Class

    Public Class Revive
        <JsonProperty("timestamp")>
        Public Property Timestamp As Long
        <JsonProperty("reviver_id")>
        Public Property ReviverId As Long
        <JsonProperty("reviver_name")>
        Public Property ReviverName As String
        <JsonProperty("reviver_faction")>
        Public Property ReviverFaction As Long
        <JsonProperty("reviver_factionname")>
        Public Property ReviverFactionname As String
        <JsonProperty("target_id")>
        Public Property TargetId As Long
        <JsonProperty("target_name")>
        Public Property TargetName As String
        <JsonProperty("target_faction")>
        Public Property TargetFaction As Long
        <JsonProperty("target_factionname")>
        Public Property TargetFactionname As String
    End Class
End Namespace
