Imports Newtonsoft.Json

Namespace Models.Torn
    Public Class Stocks
        Inherits TornResource

        <JsonProperty("stocks")>
        Public Property Stocks As Dictionary(Of String, Stock)
    End Class

    Public Class Stock
        <JsonProperty("name")>
        Public Property Name As String
        <JsonProperty("acronym")>
        Public Property Acronym As String
        <JsonProperty("director")>
        Public Property Director As String
        <JsonProperty("current_price")>
        Public Property CurrentPrice As String
        <JsonProperty("market_cap")>
        Public Property MarketCap As Long
        <JsonProperty("total_shares")>
        Public Property TotalShares As Long
        <JsonProperty("available_shares")>
        Public Property AvailableShares As Long
        <JsonProperty("forecast")>
        Public Property Forecast As String
        <JsonProperty("demand")>
        Public Property Demand As String
        <JsonProperty("benefit", NullValueHandling:=NullValueHandling.Ignore)>
        Public Property Benefit As Benefit
    End Class

    Public Class Benefit
        <JsonProperty("requirement")>
        Public Property Requirement As Long
        <JsonProperty("description")>
        Public Property Description As String
    End Class
End Namespace
