Imports Newtonsoft.Json

Namespace Models.Company
    Public Class Profile
        Inherits TornResource

        <JsonProperty("company")>
        Public Property Company As Company
    End Class

    Public Class Company
        <JsonProperty("ID")>
        Public Property Id As Long
        <JsonProperty("company_type")>
        Public Property CompanyType As Long
        <JsonProperty("rating")>
        Public Property Rating As Long
        <JsonProperty("name")>
        Public Property Name As String
        <JsonProperty("director")>
        Public Property Director As Long
        <JsonProperty("daily_profit")>
        Public Property DailyProfit As Long
        <JsonProperty("weekly_profit")>
        Public Property WeeklyProfit As Long
        <JsonProperty("daily_customers")>
        Public Property DailyCustomers As Long
        <JsonProperty("weekly_customers")>
        Public Property WeeklyCustomers As Long
        <JsonProperty("days_old")>
        Public Property DaysOld As Long
        <JsonProperty("employees")>
        Public Property Employees As Dictionary(Of String, Employee)
    End Class

    Public Class Employee
        <JsonProperty("name")>
        Public Property Name As String
        <JsonProperty("position")>
        Public Property Position As String
        <JsonProperty("days_in_company")>
        Public Property DaysInCompany As Long
    End Class
End Namespace
