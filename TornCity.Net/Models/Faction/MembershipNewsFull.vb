Imports Newtonsoft.Json

Namespace Models.Faction
    Public Class MembershipNewsFull
        Inherits TornResource

        <JsonProperty("membershipnews")>
        Public Property MembershipNews As Dictionary(Of String, Common.News)
    End Class
End Namespace