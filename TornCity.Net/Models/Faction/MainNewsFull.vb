Imports Newtonsoft.Json

Namespace Models.Faction
    Public Class MainNewsFull
        Inherits TornResource

        <JsonProperty("mainnews")>
        Public Property MainNews As Dictionary(Of String, Common.News)
    End Class
End Namespace

