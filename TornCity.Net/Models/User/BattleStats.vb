Imports Newtonsoft.Json

Namespace Models.User
    Public Class BattleStats
        Inherits TornResource

        <JsonProperty("strength")>
        Public Property Strength As String
        <JsonProperty("speed")>
        Public Property Speed As String
        <JsonProperty("dexterity")>
        Public Property Dexterity As String
        <JsonProperty("defense")>
        Public Property Defense As String
        <JsonProperty("total")>
        Public Property Total As String
        <JsonProperty("strength_modifier")>
        Public Property StrengthModifier As Long
        <JsonProperty("defense_modifier")>
        Public Property DefenseModifier As Long
        <JsonProperty("speed_modifier")>
        Public Property SpeedModifier As Long
        <JsonProperty("dexterity_modifier")>
        Public Property DexterityModifier As Long
        <JsonProperty("strength_info")>
        Public Property StrengthInfo As List(Of String)
        <JsonProperty("defense_info")>
        Public Property DefenseInfo As List(Of String)
        <JsonProperty("speed_info")>
        Public Property SpeedInfo As List(Of String)
        <JsonProperty("dexterity_info")>
        Public Property DexterityInfo As List(Of String)
    End Class
End Namespace
