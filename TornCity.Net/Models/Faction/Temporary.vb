Imports Newtonsoft.Json

Namespace Models.Faction
    Public Class Temporary
        Inherits TornResource

        <JsonProperty("temporary")>
        Public Property Temporaries As List(Of ArmoryItem)
    End Class
End Namespace

