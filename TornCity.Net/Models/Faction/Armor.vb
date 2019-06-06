Imports Newtonsoft.Json

Namespace Models.Faction
    Public Class Armor
        Inherits TornResource

        <JsonProperty("armor")>
        Public Property Armors As List(Of ArmoryItem)
    End Class
End Namespace
