Imports Newtonsoft.Json

Namespace Models.Faction
    Public Class Chains
        Inherits TornResource

        <JsonProperty("chains")>
        Public Property Chains As Dictionary(Of String, ChainInfo)
    End Class

    Public Class ChainInfo
        <JsonProperty("chain")>
        Public Property ChainChain As Long
        <JsonProperty("respect")>
        Public Property Respect As String
        <JsonProperty("start")>
        Public Property Start As Long
        <JsonProperty("end")>
        Public Property Finish As Long
    End Class
End Namespace
