Imports Newtonsoft.Json

Namespace Models.Torn
    Public Class Companies
        Inherits TornResource

        <JsonProperty("companies")>
        Public Property Companies As Dictionary(Of String, Company)
    End Class

    Public Class Company
        <JsonProperty("name")>
        Public Property Name As String
        <JsonProperty("cost")>
        Public Property Cost As Long
        <JsonProperty("default_employees")>
        Public Property DefaultEmployees As Long
        <JsonProperty("positions")>
        Public Property Positions As Dictionary(Of String, Position)
        <JsonProperty("stock")>
        Public Property Stock As Dictionary(Of String, Service)
        <JsonProperty("specials")>
        Public Property Specials As Dictionary(Of String, Special)
    End Class

    Public Class Position
        <JsonProperty("man_required")>
        Public Property ManRequired As Long
        <JsonProperty("int_required")>
        Public Property IntRequired As Long
        <JsonProperty("end_required")>
        Public Property EndRequired As Long
        <JsonProperty("man_gain")>
        Public Property ManGain As Long
        <JsonProperty("int_gain")>
        Public Property IntGain As Long
        <JsonProperty("end_gain")>
        Public Property EndGain As Long
        <JsonProperty("special_ability")>
        Public Property SpecialAbility As String
        <JsonProperty("description")>
        Public Property Description As String
    End Class

    Public Class Special
        <JsonProperty("effect")>
        Public Property Effect As String
        <JsonProperty("cost")>
        Public Property Cost As Long
        <JsonProperty("rating_required")>
        Public Property RatingRequired As Long
    End Class

    Public Class Service
        <JsonProperty("cost")>
        Public Property Cost As String
        <JsonProperty("rrp")>
        Public Property Rrp As String
    End Class
End Namespace
