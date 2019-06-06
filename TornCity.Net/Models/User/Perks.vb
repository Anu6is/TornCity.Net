Imports Newtonsoft.Json

Namespace Models.User
    Public Class Perks
        Inherits TornResource

        <JsonProperty("job_perks")>
        Public Property JobPerks As List(Of String)
        <JsonProperty("property_perks")>
        Public Property PropertyPerks As List(Of String)
        <JsonProperty("stock_perks")>
        Public Property StockPerks As List(Of String)
        <JsonProperty("merit_perks")>
        Public Property MeritPerks As List(Of String)
        <JsonProperty("education_perks")>
        Public Property EducationPerks As List(Of String)
        <JsonProperty("enhancer_perks")>
        Public Property EnhancerPerks As List(Of Object)
        <JsonProperty("company_perks")>
        Public Property CompanyPerks As List(Of String)
        <JsonProperty("faction_perks")>
        Public Property FactionPerks As List(Of String)
    End Class
End Namespace
