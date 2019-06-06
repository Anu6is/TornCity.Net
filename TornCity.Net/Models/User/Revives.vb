Imports Newtonsoft.Json
'TODO - review structure  | Test user with revives needed
Namespace Models.User
    Public Class Revives
        Inherits TornResource

        <JsonProperty("revives")>
        Public Property Revives As List(Of Common.Revive)
    End Class
End Namespace
