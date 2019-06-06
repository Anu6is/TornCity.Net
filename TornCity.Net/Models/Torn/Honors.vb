Imports Newtonsoft.Json

Namespace Models.Torn
    Public Class Honors
        Inherits TornResource

        <JsonProperty("honors")>
        Public Property Honors As Dictionary(Of String, Honor)
    End Class

    Public Class Honor
        <JsonProperty("name")>
        Public Property Name As String
        <JsonProperty("description")>
        Public Property Description As String
        <JsonProperty("type")>
        Public Property Type As Long
        <JsonProperty("circulation")>
        Public Property Circulation As Long
        <JsonProperty("rarity")>
        Public Property Rarity As String
    End Class
End Namespace
