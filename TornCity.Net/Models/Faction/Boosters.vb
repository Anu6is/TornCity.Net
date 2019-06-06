Imports Newtonsoft.Json

Namespace Models.Faction
    Public Class Boosters
        Inherits TornResource

        <JsonProperty("boosters")>
        Public Property Boosters As List(Of StoreItem)
    End Class
End Namespace

