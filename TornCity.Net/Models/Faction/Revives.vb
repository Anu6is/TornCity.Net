Imports Newtonsoft.Json

Namespace Models.Faction
    Public Class Revives
        Inherits TornResource

        <JsonProperty("revives")>
        Public Property Revives As Dictionary(Of String, Common.Revive)
    End Class
End Namespace
