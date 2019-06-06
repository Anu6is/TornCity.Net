Imports Newtonsoft.Json

Namespace Models.User
    Public Class JobPoints
        Inherits TornResource

        <JsonProperty("jobpoints")>
        Public Property Jobpoints As Points
    End Class

    Public Class Points
        <JsonProperty("jobs")>
        Public Property Jobs As Jobs
        <JsonProperty("companies")>
        Public Property Companies As Dictionary(Of String, Company)
    End Class

    Public Class Company
        <JsonProperty("name")>
        Public Property Name As String
        <JsonProperty("jobpoints")>
        Public Property Jobpoints As Long
    End Class

    Public Class Jobs
        <JsonProperty("education")>
        Public Property Education As Long
        <JsonProperty("medical")>
        Public Property Medical As Long
        <JsonProperty("casino")>
        Public Property Casino As Long
        <JsonProperty("grocer")>
        Public Property Grocer As Long
        <JsonProperty("army")>
        Public Property Army As Long
        <JsonProperty("law")>
        Public Property Law As Long
    End Class
End Namespace
