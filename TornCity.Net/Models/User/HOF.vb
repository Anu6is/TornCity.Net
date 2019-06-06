Imports Newtonsoft.Json

Namespace Models.User
    Public Class Hof
        Inherits TornResource

        <JsonProperty("halloffame")>
        Public Property Halloffame As Dictionary(Of String, Category)
    End Class

    Public Class Category
        <JsonProperty("value")>
        Public Property Value As Long
        <JsonProperty("rank")>
        Public Property Rank As Long
    End Class
End Namespace
