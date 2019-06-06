Imports Newtonsoft.Json

Namespace Models.Faction
    Public Class AttackNewsFull
        Inherits TornResource

        <JsonProperty("attacknews")>
        Public Property AttackNews As Dictionary(Of String, Common.News)
    End Class
End Namespace