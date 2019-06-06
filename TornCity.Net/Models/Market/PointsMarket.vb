Imports Newtonsoft.Json

Namespace Models.Market
    Public Class PointsMarket
        Inherits TornResource

        <JsonProperty("pointsmarket")>
        Public Property PointsMarket As Dictionary(Of String, PointValue)
    End Class

    Public Class PointValue
        <JsonProperty("cost")>
        Public Property Cost As Long
        <JsonProperty("quantity")>
        Public Property Quantity As Long
        <JsonProperty("total_cost")>
        Public Property TotalCost As Long
    End Class
End Namespace
