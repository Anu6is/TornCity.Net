Imports Newtonsoft.Json

Namespace Models.Faction
    Public Class FundsNews
        Inherits TornResource

        <JsonProperty("fundsnews")>
        Public Property FundsNews As Dictionary(Of String, Common.News)
    End Class
End Namespace
