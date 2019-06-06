Imports Newtonsoft.Json
'TODO - review structure  | Test user with revives needed
Namespace Models.User
    Public Class RevivesFull
        Inherits TornResource

        <JsonProperty("revives")>
        Public Property Revives As List(Of Common.ReviveSummary)
    End Class
End Namespace