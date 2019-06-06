Imports Newtonsoft.Json

Namespace Models.User
    Public Class Refills
        Inherits TornResource
        <JsonProperty("refills")>
        Public Property Refills As Refill
    End Class

    Public Class Refill
        <JsonProperty("energy_refill_used")>
        Public Property EnergyRefillUsed As Boolean
        <JsonProperty("nerve_refill_used")>
        Public Property NerveRefillUsed As Boolean
        <JsonProperty("token_refill_used")>
        Public Property TokenRefillUsed As Boolean
        <JsonProperty("special_refills_available")>
        Public Property SpecialRefillsAvailable As Long
    End Class
End Namespace
