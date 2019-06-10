Imports Newtonsoft.Json

Namespace Models.Torn
    Public Class Items
        Inherits TornResource

        <JsonProperty("items")>
        Public Property Items As Dictionary(Of String, Item)
    End Class

    Public Class Item
        <JsonProperty("name")>
        Public Property Name As String
        <JsonProperty("description")>
        Public Property Description As String
        <JsonProperty("effect")>
        Public Property Effect As String
        <JsonProperty("requirement")>
        Public Property Requirement As String
        <JsonProperty("type")>
        Public Property Type As String
        <JsonProperty("buy_price")>
        Public Property BuyPrice As Long
        <JsonProperty("sell_price")>
        Public Property SellPrice As Long
        <JsonProperty("market_value")>
        Public Property MarketValue As Long
        <JsonProperty("circulation")>
        Public Property Circulation As Long
        <JsonProperty("image")>
        Public Property Image As Uri
    End Class
End Namespace
