Imports Newtonsoft.Json

Namespace Models.Faction
    Public Class Weapons
        Inherits TornResource

        <JsonProperty("weapons")>
        Public Property Weapons As List(Of ArmoryItem)
    End Class
End Namespace
