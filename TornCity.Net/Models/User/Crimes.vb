Imports Newtonsoft.Json

Namespace Models.User
    Public Class Crimes
        Inherits TornResource

        <JsonProperty("criminalrecord")>
        Public Property Criminalrecord As Criminalrecord
    End Class

    Public Class Criminalrecord
        <JsonProperty("selling_illegal_products")>
        Public Property SellingIllegalProducts As Long
        <JsonProperty("theft")>
        Public Property Theft As Long
        <JsonProperty("auto_theft")>
        Public Property AutoTheft As Long
        <JsonProperty("drug_deals")>
        Public Property DrugDeals As Long
        <JsonProperty("computer_crimes")>
        Public Property ComputerCrimes As Long
        <JsonProperty("murder")>
        Public Property Murder As Long
        <JsonProperty("fraud_crimes")>
        Public Property FraudCrimes As Long
        <JsonProperty("other")>
        Public Property Other As Long
        <JsonProperty("total")>
        Public Property Total As Long
    End Class
End Namespace
