Imports Newtonsoft.Json

Namespace Models.Faction
    Partial Public Class Chain
        Inherits TornResource
        <JsonProperty("chain")>
        Public Property Chain As ChainDetails
    End Class

    Public Class ChainDetails
        <JsonProperty("current")>
        Public Property Current As Long
        <JsonProperty("max")>
        Public Property Max As Long
        <JsonProperty("timeout")>
        Public Property Timeout As Long
        <JsonProperty("modifier")>
        Public Property Modifier As Long
        <JsonProperty("cooldown")>
        Public Property Cooldown As Long
        <JsonProperty("start")>
        Public Property Start As Long
    End Class
End Namespace
