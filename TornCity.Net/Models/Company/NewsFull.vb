Imports Newtonsoft.Json

Namespace Models.Company
    Public Class NewsFull
        Inherits TornResource

        <JsonProperty("news")>
        Public Property CompanyNews As Dictionary(Of String, Common.News)
    End Class
End Namespace

