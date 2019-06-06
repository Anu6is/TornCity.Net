Imports Newtonsoft.Json

Namespace Models.Property

    Public Class [Property]
        Inherits TornResource

        <JsonProperty("property")>
        Public Property PropertyInfo As PropertyInfo
    End Class

    Public Class PropertyInfo
        <JsonProperty("owner_id")>
        Public Property OwnerId As Long
        <JsonProperty("property_type")>
        Public Property PropertyType As Long
        <JsonProperty("happy")>
        Public Property Happy As Long
        <JsonProperty("upkeep")>
        Public Property Upkeep As Long
        <JsonProperty("upgrades")>
        Public Property Upgrades As List(Of String)
        <JsonProperty("staff")>
        Public Property Staff As List(Of String)
        <JsonProperty("rented")>
        Public Property Rented As Rented
        <JsonProperty("users_living")>
        Public Property UsersLiving As String
    End Class

    Public Class Rented
        <JsonProperty("user_id")>
        Public Property UserId As String
        <JsonProperty("days_left")>
        Public Property DaysLeft As String
        <JsonProperty("total_cost")>
        Public Property TotalCost As String
        <JsonProperty("cost_per_day")>
        Public Property CostPerDay As String
    End Class
End Namespace
