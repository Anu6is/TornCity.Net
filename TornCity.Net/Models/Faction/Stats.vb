Imports Newtonsoft.Json

Namespace Models.Faction
    Public Class Stats
        Inherits TornResource

        <JsonProperty("stats")>
        Public Property Stats As Dictionary(Of String, Long)
    End Class
End Namespace
