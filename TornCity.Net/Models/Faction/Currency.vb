Imports Newtonsoft.Json

Namespace Models.Faction
    Public Class Currency
        Inherits TornResource

        <JsonProperty("faction_id")>
        Public Property FactionId As Long
        <JsonProperty("points")>
        Public Property Points As Long
        <JsonProperty("money")>
        Public Property Money As Long
    End Class
End Namespace
