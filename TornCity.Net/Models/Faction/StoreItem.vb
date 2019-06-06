Imports Newtonsoft.Json

Namespace Models.Faction
    Public Class StoreItem
        Inherits TornResource

        <JsonProperty("ID")>
        Public Property Id As Long
        <JsonProperty("name")>
        Public Property Name As String
        <JsonProperty("type")>
        Public Property Type As String
        <JsonProperty("quantity")>
        Public Property Quantity As Long
    End Class
End Namespace

