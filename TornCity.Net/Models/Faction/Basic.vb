Imports Newtonsoft.Json

Namespace Models.Faction
    Public Class Basic
        Inherits TornResource

        <JsonProperty("ID")>
        Public Property Id As Long
        <JsonProperty("name")>
        Public Property Name As String
        <JsonProperty("leader")>
        Public Property Leader As Long
        <JsonProperty("co-leader")>
        Public Property CoLeader As Long
        <JsonProperty("respect")>
        Public Property Respect As Long
        <JsonProperty("age")>
        Public Property Age As Long
        <JsonProperty("best_chain")>
        Public Property BestChain As Long
        <JsonProperty("wars")>
        Public Property Wars As Dictionary(Of String, Long)
        <JsonProperty("members")>
        Public Property Members As Dictionary(Of String, Member)
        <JsonProperty("peace")>
        Public Property Peace As Dictionary(Of String, Long)
    End Class

    Public Class Member
        <JsonProperty("name")>
        Public Property Name As String
        <JsonProperty("days_in_faction")>
        Public Property DaysInFaction As Long
        <JsonProperty("last_action")>
        Public Property LastAction As String
        <JsonProperty("status")>
        Public Property Status As List(Of String)
    End Class
End Namespace
