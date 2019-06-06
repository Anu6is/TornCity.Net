Imports Newtonsoft.Json

Namespace Models.Torn
    Public Class Properties
        Inherits TornResource

        <JsonProperty("properties")>
        Public Property Properties As Dictionary(Of String, [Property])
    End Class

    Public Class [Property]
        <JsonProperty("name")>
        Public Property Name As String
        <JsonProperty("cost")>
        Public Property Cost As String
        <JsonProperty("happy")>
        Public Property Happy As Long
        <JsonProperty("upkeep")>
        Public Property Upkeep As Long
        <JsonProperty("upgrades_available")>
        Public Property UpgradesAvailable As List(Of String)
        <JsonProperty("staff_available")>
        Public Property StaffAvailable As List(Of String)
    End Class
End Namespace
