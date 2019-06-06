Imports Newtonsoft.Json

Namespace Models.Faction
    Public Class AttacksFull
        Inherits TornResource

        <JsonProperty("attacks")>
        Public Property Attacks As Dictionary(Of String, Common.AttackSummary)
    End Class
End Namespace