Imports Newtonsoft.Json

Namespace Models.Faction
    Public Class Upgrades
        Inherits TornResource

        <JsonProperty("upgrades")>
        Public Property Upgrades As Dictionary(Of String, Upgrade)
    End Class

    Public Class Upgrade
        <JsonProperty("branch")>
        Public Property Branch As String
        <JsonProperty("branchorder")>
        Public Property Branchorder As Long
        <JsonProperty("branchmultiplier")>
        Public Property Branchmultiplier As Long
        <JsonProperty("name")>
        Public Property Name As String
        <JsonProperty("level")>
        Public Property Level As Long
        <JsonProperty("basecost")>
        Public Property Basecost As Long
        <JsonProperty("ability")>
        Public Property Ability As String
        <JsonProperty("unlocked")>
        Public Property Unlocked As DateTimeOffset
    End Class
End Namespace

