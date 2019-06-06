Imports Newtonsoft.Json

Namespace Models.User
    Public Class PersonalStats
        Inherits TornResource

        <JsonProperty("personalstats")>
        Public Property PersonalStats As Dictionary(Of String, Long)
    End Class
End Namespace
