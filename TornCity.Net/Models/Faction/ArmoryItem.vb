Imports Newtonsoft.Json

Namespace Models.Faction
    Public Class ArmoryItem
        Inherits TornResource

        <JsonProperty("ID")>
        Public Property Id As Long
        <JsonProperty("name")>
        Public Property Name As String
        <JsonProperty("type")>
        Public Property Type As String
        <JsonProperty("quantity")>
        Public Property Quantity As Long
        <JsonProperty("available")>
        Public Property Available As Long
        <JsonProperty("loaned")>
        Public Property Loaned As Long
        <JsonProperty("loaned_to")>
        Public Property LoanedTo As String
    End Class
End Namespace

