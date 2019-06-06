Imports Newtonsoft.Json

Namespace Models.Common
    Public NotInheritable Class Attacks
        Inherits TornResource

        <JsonProperty("attacks")>
        Public Property Attacks As Dictionary(Of String, Attack)
    End Class

    Public NotInheritable Class Attack
        <JsonProperty("timestamp_started")>
        Public Property TimestampStarted As Long
        <JsonProperty("timestamp_ended")>
        Public Property TimestampEnded As Long
        <JsonProperty("attacker_id")>
        Public Property AttackerId As String
        <JsonProperty("attacker_name")>
        Public Property AttackerName As String
        <JsonProperty("attacker_faction")>
        Public Property AttackerFaction As String
        <JsonProperty("attacker_factionname")>
        Public Property AttackerFactionname As String
        <JsonProperty("defender_id")>
        Public Property DefenderId As Long
        <JsonProperty("defender_name")>
        Public Property DefenderName As String
        <JsonProperty("defender_faction")>
        Public Property DefenderFaction As Long
        <JsonProperty("defender_factionname")>
        Public Property DefenderFactionname As String
        <JsonProperty("result")>
        Public Property Result As String
        <JsonProperty("stealthed")>
        Public Property Stealthed As Long
        <JsonProperty("respect_gain")>
        Public Property RespectGain As String
        <JsonProperty("chain")>
        Public Property Chain As Long
        <JsonProperty("modifiers")>
        Public Property Modifiers As Modifiers
    End Class

    Public NotInheritable Class Modifiers
        <JsonProperty("fairFight")>
        Public Property FairFight As Decimal
        <JsonProperty("war")>
        Public Property War As Long
        <JsonProperty("retaliation")>
        Public Property Retaliation As Long
        <JsonProperty("groupAttack")>
        Public Property GroupAttack As String
        <JsonProperty("overseas")>
        Public Property Overseas As String
        <JsonProperty("chainBonus")>
        Public Property ChainBonus As String
    End Class
End Namespace
