Imports Newtonsoft.Json

Namespace Models.Faction
    Public Class Donations
        Inherits TornResource

        <JsonProperty("donations")>
        Public Property Donations As Dictionary(Of String, Donation)
    End Class

    Public Class Donation
        <JsonProperty("name")>
        Public Property Name As String
        <JsonProperty("money_balance")>
        Public Property MoneyBalance As Long
        <JsonProperty("points_balance")>
        Public Property PointsBalance As Long
    End Class
End Namespace
