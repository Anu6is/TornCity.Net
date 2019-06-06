Imports Newtonsoft.Json

Namespace Models.Faction
    Public Class RevivesFull
        Inherits TornResource

        <JsonProperty("revives")>
        Public Property Revives As Dictionary(Of String, Common.ReviveSummary)
    End Class
End Namespace
