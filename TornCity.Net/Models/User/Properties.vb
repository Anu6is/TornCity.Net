Imports Newtonsoft.Json

Namespace Models.User
    Public Class Properties
        Inherits TornResource

        <JsonProperty("properties")>
        Public Property Properties As Dictionary(Of String, [Property])
    End Class

    Public Class [Property]
        <JsonProperty("owner_id")>
        Public Property OwnerId As Long
        <JsonProperty("property_type")>
        Public Property PropertyType As Long
        <JsonProperty("property")>
        Public Property [Property] As String
        <JsonProperty("status")>
        Public Property Status As String
        <JsonProperty("happy")>
        Public Property Happy As Long
        <JsonProperty("upkeep")>
        Public Property Upkeep As Long
        <JsonProperty("staff_cost")>
        Public Property StaffCost As Long
        <JsonProperty("cost")>
        Public Property Cost As Long
        <JsonProperty("marketprice")>
        Public Property Marketprice As Long
        <JsonProperty("modifications")>
        Public Property Modifications As Modifications
        <JsonProperty("staff")>
        Public Property Staff As Staff
    End Class

    Public Class Modifications
        <JsonProperty("interior")>
        Public Property Interior As Long
        <JsonProperty("hot_tub")>
        Public Property HotTub As Long
        <JsonProperty("sauna")>
        Public Property Sauna As Long
        <JsonProperty("pool")>
        Public Property Pool As Long
        <JsonProperty("open_bar")>
        Public Property OpenBar As Long
        <JsonProperty("shooting_range")>
        Public Property ShootingRange As Long
        <JsonProperty("vault")>
        Public Property Vault As Long
        <JsonProperty("medical_facility")>
        Public Property MedicalFacility As Long
        <JsonProperty("airstrip")>
        Public Property Airstrip As Long
        <JsonProperty("yacht")>
        Public Property Yacht As Long
    End Class

    Public Class Staff
        <JsonProperty("maid")>
        Public Property Maid As Long
        <JsonProperty("guard")>
        Public Property Guard As Long
        <JsonProperty("pilot")>
        Public Property Pilot As Long
        <JsonProperty("butler")>
        Public Property Butler As Long
        <JsonProperty("doctor")>
        Public Property Doctor As Long
    End Class
End Namespace
