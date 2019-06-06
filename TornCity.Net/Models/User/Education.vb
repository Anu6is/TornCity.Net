Imports Newtonsoft.Json

Namespace Models.User
    Public Class Education
        Inherits TornResource

        <JsonProperty("education_current")>
        Public Property EducationCurrent As Long
        <JsonProperty("education_timeleft")>
        Public Property EducationTimeleft As Long
        <JsonProperty("education_completed")>
        Public Property EducationCompleted As List(Of Long)
    End Class
End Namespace
