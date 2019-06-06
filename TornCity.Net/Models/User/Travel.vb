Imports Newtonsoft.Json

Namespace Models.User
    Partial Public Class Travel
        Inherits TornResource

        <JsonProperty("travel")>
        Public Property Travel As TravelInfo
    End Class

    Public Class TravelInfo
        <JsonProperty("destination")>
        Public Property Destination As String
        <JsonProperty("timestamp")>
        Public Property Timestamp As Long
        <JsonProperty("departed")>
        Public Property Departed As Long?
        <JsonProperty("time_left")>
        Public Property TimeLeft As Long
    End Class
End Namespace
