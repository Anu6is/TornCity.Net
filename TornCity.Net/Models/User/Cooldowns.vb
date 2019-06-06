Imports Newtonsoft.Json

Namespace Models.User
    Partial Public Class Cooldowns
        Inherits TornResource

        <JsonProperty("cooldowns")>
        Public Property Cooldowns As CooldownElements
    End Class

    Public Class CooldownElements
        <JsonProperty("drug")>
        Public Property Drug As Long
        <JsonProperty("medical")>
        Public Property Medical As Long
        <JsonProperty("booster")>
        Public Property Booster As Long
    End Class
End Namespace
