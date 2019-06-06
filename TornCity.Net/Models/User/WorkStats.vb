Imports Newtonsoft.Json

Namespace Models.User
    Public Class WorkStats
        Inherits TornResource

        <JsonProperty("manual_labor")>
        Public Property ManualLabor As Long
        <JsonProperty("intelligence")>
        Public Property Intelligence As Long
        <JsonProperty("endurance")>
        Public Property Endurance As Long
    End Class
End Namespace
