Imports Newtonsoft.Json

Namespace Models.Market
    Public Class Bazaar
        Inherits TornResource

        <JsonProperty("bazaar")>
        Public Property Bazaar As Dictionary(Of String, Listing)
    End Class

    Public Class Listing
        <JsonProperty("cost")>
        Public Property Cost As Long
        <JsonProperty("quantity")>
        Public Property Quantity As Long
    End Class
End Namespace
