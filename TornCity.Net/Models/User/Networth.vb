Imports Newtonsoft.Json

Namespace Models.User
    Public Class Networth
        Inherits TornResource

        <JsonProperty("networth")>
        Public Property Networth As Dictionary(Of String, Double?)
    End Class
End Namespace
