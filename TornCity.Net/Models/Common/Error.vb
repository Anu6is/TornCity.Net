Imports Newtonsoft.Json

Namespace Models.Common
    Public Class [Error]
        Inherits TornResource

        <JsonProperty("error")>
        Public Property ApiError As ErrorDetails
    End Class

    Public Class ErrorDetails
        <JsonProperty("code")>
        Public Property Code As Long
        <JsonProperty("error")>
        Public Property Message As String
    End Class
End Namespace
