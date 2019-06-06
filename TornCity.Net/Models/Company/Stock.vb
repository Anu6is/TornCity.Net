Imports Newtonsoft.Json

Namespace Models.Company
    Public Class Stock
        Inherits TornResource

        <JsonProperty("company_stock")>
        Public Property Stocks As Dictionary(Of String, StockInfo)
    End Class

    Public Class StockInfo
        <JsonProperty("cost")>
        Public Property Cost As Long
        <JsonProperty("rrp")>
        Public Property Rrp As Long
        <JsonProperty("price")>
        Public Property Price As Long
        <JsonProperty("in_stock")>
        Public Property InStock As Long
        <JsonProperty("on_order")>
        Public Property OnOrder As Long
        <JsonProperty("sold_amount")>
        Public Property SoldAmount As Long
        <JsonProperty("sold_worth")>
        Public Property SoldWorth As Long
    End Class
End Namespace
