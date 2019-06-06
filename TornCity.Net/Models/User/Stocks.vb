Imports Newtonsoft.Json

Namespace Models.User
    Public Class Stocks
        Inherits TornResource

        <JsonProperty("stocks")>
        Public Property Stocks As Dictionary(Of String, Stock)
    End Class

    Public Class Stock
        <JsonProperty("stock_id")>
        Public Property StockId As Long
        <JsonProperty("shares")>
        Public Property Shares As Long
        <JsonProperty("bought_price")>
        Public Property BoughtPrice As String
        <JsonProperty("time_bought")>
        Public Property TimeBought As Long
        <JsonProperty("time_listed")>
        Public Property TimeListed As Long
    End Class
End Namespace
