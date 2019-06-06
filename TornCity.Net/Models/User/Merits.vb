Imports Newtonsoft.Json

Namespace Models.User
    Public Class Merits
        Inherits TornResource

        <JsonProperty("merits")>
        Public Property Merits As Dictionary(Of String, Long)
    End Class
End Namespace
