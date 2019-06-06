Imports Newtonsoft.Json

Namespace Models.Common
    Public Class RevivesFull
        Inherits TornResource

        <JsonProperty("revives")>
        Public Property Revives As Dictionary(Of String, ReviveSummary)
    End Class

    Public Class ReviveSummary
        <JsonProperty("timestamp")>
        Public Property Timestamp As Long
        <JsonProperty("reviver_id")>
        Public Property ReviverId As Long
        <JsonProperty("reviver_faction")>
        Public Property ReviverFaction As Long
        <JsonProperty("target_id")>
        Public Property TargetId As Long
        <JsonProperty("target_faction")>
        Public Property TargetFaction As Long
    End Class
End Namespace
