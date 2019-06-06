Imports Newtonsoft.Json

Namespace Models.Company
    Public Class Employees
        Inherits TornResource

        <JsonProperty("company_employees")>
        Public Property CompanyEmployees As Dictionary(Of String, CompanyEmployee)
    End Class

    Public Class CompanyEmployee
        <JsonProperty("position")>
        Public Property Position As String
        <JsonProperty("days_employed")>
        Public Property DaysEmployed As Long
        <JsonProperty("wage")>
        Public Property Wage As Long
        <JsonProperty("effectiveness")>
        Public Property Effectiveness As Long
        <JsonProperty("manual_labor")>
        Public Property ManualLabor As Long
        <JsonProperty("intelligence")>
        Public Property Intelligence As Long
        <JsonProperty("endurance")>
        Public Property Endurance As Long
    End Class
End Namespace
