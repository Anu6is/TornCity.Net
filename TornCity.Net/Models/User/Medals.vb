Imports Newtonsoft.Json

Namespace Models.User
    Public Class Medals
        Inherits TornResource

        <JsonProperty("medals_awarded")>
        Public Property MedalsAwarded As List(Of Long)
        <JsonProperty("medals_time")>
        Public Property MedalsTime As List(Of Long)
    End Class
End Namespace
