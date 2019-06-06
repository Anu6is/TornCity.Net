Imports Newtonsoft.Json

Namespace Models.Faction
    Public Class Drugs
        Inherits TornResource

        <JsonProperty("drugs")>
        Public Property Drugs As List(Of StoreItem)
    End Class
End Namespace

