Imports Newtonsoft.Json

Namespace Models.Torn
    Public Class OrganisedCrimes
        Inherits TornResource

        <JsonProperty("organisedcrimes")>
        Public Property Organisedcrimes As Dictionary(Of String, Organisedcrime)
    End Class

    Public Class Organisedcrime
        <JsonProperty("name")>
        Public Property Name As String
        <JsonProperty("members")>
        Public Property Members As Long
        <JsonProperty("time")>
        Public Property Time As Long
        <JsonProperty("min_cash")>
        Public Property MinCash As Long
        <JsonProperty("max_cash")>
        Public Property MaxCash As Long
        <JsonProperty("min_respect")>
        Public Property MinRespect As Long
        <JsonProperty("max_respect")>
        Public Property MaxRespect As Long
    End Class
End Namespace
