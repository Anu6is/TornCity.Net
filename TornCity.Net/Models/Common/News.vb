
Imports Newtonsoft.Json

Namespace Models.Common
    Public Class News
        Inherits TornResource

        <JsonProperty("timestamp")>
        Public Shadows Property Timestamp As Long
        <JsonProperty("news")>
        Public Property News As String
    End Class
End Namespace

