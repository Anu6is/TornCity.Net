Imports Newtonsoft.Json

Namespace Models.User
    Public Class Inventory
        Inherits TornResource

        <JsonProperty("inventory")>
        Public Property Inventory As List(Of InventoryItem)
    End Class

    Public Class InventoryItem
        <JsonProperty("ID")>
        Public Property Id As Long
        <JsonProperty("name")>
        Public Property Name As String
        <JsonProperty("type")>
        Public Property Type As String
        <JsonProperty("quantity")>
        Public Property Quantity As Long
        <JsonProperty("equipped")>
        Public Property Equipped As Long
        <JsonProperty("market_price")>
        Public Property MarketPrice As Long
    End Class
End Namespace
