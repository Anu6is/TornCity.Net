Imports Newtonsoft.Json

Namespace Models.User
    Public Class Honors
        Inherits TornResource

        <JsonProperty("honors_awarded")>
        Public Property HonorsAwarded As List(Of Long)
        <JsonProperty("honors_time")>
        Public Property HonorsTime As List(Of Long)
    End Class
End Namespace
