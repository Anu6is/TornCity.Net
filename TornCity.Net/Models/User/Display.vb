Imports Newtonsoft.Json

Namespace Models.User
    Public Class Display
        Inherits TornResource

        <JsonProperty("display")>
        Public Property Display As List(Of DisplayItem)
    End Class

    Public Class DisplayItem
        <JsonProperty("ID")>
        Public Property Id As Long
        <JsonProperty("name")>
        Public Property Name As String
        <JsonProperty("type")>
        Public Property Type As String
        <JsonProperty("quantity")>
        Public Property Quantity As Long
        <JsonProperty("circulation")>
        Public Property Circulation As Long
        <JsonProperty("market_price")>
        Public Property MarketPrice As Long
    End Class
End Namespace
