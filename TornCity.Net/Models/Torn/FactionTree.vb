Imports Newtonsoft.Json

Namespace Models.Torn
    Public Class FactionTree
        Inherits TornResource

        <JsonProperty("factiontree")>
        Public Property Factiontree As Dictionary(Of String, Dictionary(Of String, Tree))
    End Class

    Public Class Tree
        <JsonProperty("branch")>
        Public Property Branch As String
        <JsonProperty("name")>
        Public Property Name As String
        <JsonProperty("ability")>
        Public Property Ability As String
        <JsonProperty("challenge")>
        Public Property Challenge As String
        <JsonProperty("base_cost")>
        Public Property BaseCost As Long
    End Class
End Namespace
