Imports Newtonsoft.Json

Namespace Models.Faction
    Public Class ArmoryNewsFull
        Inherits TornResource

        <JsonProperty("armorynews")>
        Public Property ArmoryNews As Dictionary(Of String, Common.News)
    End Class
End Namespace