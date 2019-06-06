Imports Newtonsoft.Json

Namespace Models.Faction
    Public Class MainNews
        Inherits TornResource

        <JsonProperty("mainnews")>
        Public Property MainNews As Dictionary(Of String, Common.News)
    End Class
End Namespace
