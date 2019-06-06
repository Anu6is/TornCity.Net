Imports Newtonsoft.Json

Namespace Models.Common
    Public Class AttacksFull
        Inherits TornResource

        <JsonProperty("attacks")>
        Public Property Attacks As Dictionary(Of String, AttackSummary)
    End Class

    Public Class AttackSummary
        <JsonProperty("timestamp_started")>
        Public Property TimestampStarted As Long
        <JsonProperty("timestamp_ended")>
        Public Property TimestampEnded As Long
        <JsonProperty("attacker_id")>
        Public Property AttackerId As String
        <JsonProperty("attacker_faction")>
        Public Property AttackerFaction As String
        <JsonProperty("defender_id")>
        Public Property DefenderId As Long
        <JsonProperty("defender_faction")>
        Public Property DefenderFaction As Long
        <JsonProperty("result")>
        Public Property Result As String
        <JsonProperty("stealthed")>
        Public Property Stealthed As Long
        <JsonProperty("respect_gain")>
        Public Property RespectGain As String
    End Class
End Namespace
