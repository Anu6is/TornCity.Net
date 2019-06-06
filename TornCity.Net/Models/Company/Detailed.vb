Imports Newtonsoft.Json

Namespace Models.Company

    Public Class Detailed
        Inherits TornResource

        <JsonProperty("company_detailed")>
        Public Property CompanyDetailed As Details
    End Class

    Public Class Details
        <JsonProperty("ID")>
        Public Property Id As Long
        <JsonProperty("company_bank")>
        Public Property CompanyBank As Long
        <JsonProperty("popularity")>
        Public Property Popularity As Long
        <JsonProperty("efficiency")>
        Public Property Efficiency As Long
        <JsonProperty("environment")>
        Public Property Environment As Long
        <JsonProperty("trains_available")>
        Public Property TrainsAvailable As Long
        <JsonProperty("advertising_budget")>
        Public Property AdvertisingBudget As Long
        <JsonProperty("upgrades")>
        Public Property Upgrades As Upgrades
    End Class

    Public Class Upgrades
        <JsonProperty("company_size")>
        Public Property CompanySize As Long
        <JsonProperty("staffroom_size")>
        Public Property StaffroomSize As String
        <JsonProperty("storage_size")>
        Public Property StorageSize As String
        <JsonProperty("storage_space")>
        Public Property StorageSpace As Long
    End Class
End Namespace
