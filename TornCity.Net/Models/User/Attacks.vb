Imports Newtonsoft.Json

Namespace Models.User
    Public Class Attacks
        Inherits TornResource

        <JsonProperty("attacks")>
        Public Property Attacks As Dictionary(Of String, Common.Attack)
    End Class
End Namespace
