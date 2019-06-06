Imports Newtonsoft.Json

Namespace Models.Torn
    Public Class Education
        Inherits TornResource

        <JsonProperty("education")>
        Public Property Education As Dictionary(Of String, EducationDetails)
    End Class

    Public Class EducationDetails
        <JsonProperty("name")>
        Public Property Name As String
        <JsonProperty("description")>
        Public Property Description As String
        <JsonProperty("money_cost")>
        Public Property MoneyCost As Long
        <JsonProperty("tier")>
        Public Property Tier As Long
        <JsonProperty("duration")>
        Public Property Duration As Long
        <JsonProperty("results")>
        Public Property Results As Results
        <JsonProperty("prerequisites")>
        Public Property Prerequisites As List(Of Long)
    End Class

    Public Class Results
        <JsonProperty("intelligence")>
        Public Property Intelligence As List(Of Long)
        <JsonProperty("endurance")>
        Public Property Endurance As List(Of Long)
        <JsonProperty("perk", NullValueHandling:=NullValueHandling.Ignore)>
        Public Property Perk As List(Of String)
        <JsonProperty("manual_labor", NullValueHandling:=NullValueHandling.Ignore)>
        Public Property ManualLabor As List(Of Long)
    End Class
End Namespace
