Imports Newtonsoft.Json

Namespace Models.Faction
    Public Class ArmoryNews
        Inherits TornResource

        <JsonProperty("armorynews")>
        Public Property ArmoryNews As Dictionary(Of String, Common.News)
    End Class
End Namespace
