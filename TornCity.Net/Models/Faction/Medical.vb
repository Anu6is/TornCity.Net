Imports Newtonsoft.Json

Namespace Models.Faction
    Public Class Medical
        Inherits TornResource

        <JsonProperty("medical")>
        Public Property Medical As List(Of StoreItem)
    End Class
End Namespace
