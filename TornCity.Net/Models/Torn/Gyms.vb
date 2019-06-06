Imports Newtonsoft.Json

Namespace Models.Torn
    Public Class Gyms
        Inherits TornResource

        <JsonProperty("gyms")>
        Public Property Gyms As Dictionary(Of String, Gym)
    End Class

    Public Class Gym
        <JsonProperty("name")>
        Public Property Name As String
        <JsonProperty("stage")>
        Public Property Stage As Long
        <JsonProperty("cost")>
        Public Property Cost As Long
        <JsonProperty("energy")>
        Public Property Energy As Long
        <JsonProperty("strength")>
        Public Property Strength As Double
        <JsonProperty("speed")>
        Public Property Speed As Long
        <JsonProperty("defense")>
        Public Property Defense As Double
        <JsonProperty("dexterity")>
        Public Property Dexterity As Double
        <JsonProperty("note")>
        Public Property Note As String
    End Class
End Namespace
