Imports Newtonsoft.Json

Namespace Models.User
    Public Class Icons
        Inherits TornResource

        <JsonProperty("icons")>
        Public Property Icons As Dictionary(Of String, String)
    End Class
End Namespace
