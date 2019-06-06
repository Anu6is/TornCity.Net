Imports Newtonsoft.Json

Namespace Models.User
    Public Class Money
        Inherits TornResource

        <JsonProperty("points")>
        Public Property Points As Long
        <JsonProperty("cayman_bank")>
        Public Property CaymanBank As Long?
        <JsonProperty("vault_amount")>
        Public Property VaultAmount As Long
        <JsonProperty("networth")>
        Public Property Networth As Long
        <JsonProperty("money_onhand")>
        Public Property MoneyOnhand As Long
        <JsonProperty("city_bank")>
        Public Property CityBank As CityBank
    End Class

    Public Class CityBank
        <JsonProperty("amount")>
        Public Property Amount As Long
        <JsonProperty("time_left")>
        Public Property TimeLeft As Long
    End Class
End Namespace
