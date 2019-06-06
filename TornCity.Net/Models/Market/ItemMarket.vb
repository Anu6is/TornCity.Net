Imports Newtonsoft.Json

Namespace Models.Market
    Public Class ItemMarket
        Inherits TornResource

        <JsonProperty("itemmarket")>
        Public Property Itemmarket As Dictionary(Of String, MarketListing)
    End Class

    Public Class MarketListing
        <JsonProperty("cost")>
        Public Property Cost As Long
        <JsonProperty("quantity")>
        Public Property Quantity As Long
    End Class
End Namespace
