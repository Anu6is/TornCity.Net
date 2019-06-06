Imports Newtonsoft.Json

Namespace Models.User
    Public Class Bazaar
        Inherits TornResource

        <JsonProperty("bazaar")>
        Public Property Bazaar As List(Of BazaarItem)
    End Class

    Public Class BazaarItem
        <JsonProperty("ID")>
        Public Property Id As Long
        <JsonProperty("name")>
        Public Property Name As String
        <JsonProperty("type")>
        Public Property Type As String
        <JsonProperty("quantity")>
        Public Property Quantity As Long
        <JsonProperty("price")>
        Public Property Price As Long
        <JsonProperty("market_price")>
        Public Property MarketPrice As Long
    End Class
End Namespace
