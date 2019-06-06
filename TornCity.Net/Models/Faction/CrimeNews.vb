Imports Newtonsoft.Json

Namespace Models.Faction
    Public Class CrimeNews
        Inherits TornResource

        <JsonProperty("crimenews")>
        Public Property CrimeNews As Dictionary(Of String, Common.News)
    End Class
End Namespace