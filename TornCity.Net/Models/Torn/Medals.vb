Imports Newtonsoft.Json

Namespace Models.Torn
    Public Class Medals
        Inherits TornResource

        <JsonProperty("medals")>
        Public Property Medals As Dictionary(Of String, Medal)
    End Class

    Public Class Medal
        <JsonProperty("name")>
        Public Property Name As String
        <JsonProperty("description")>
        Public Property Description As String
        <JsonProperty("type")>
        Public Property Type As String
    End Class
End Namespace
