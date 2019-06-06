Imports Newtonsoft.Json

Namespace Models.User

    Partial Public Class Notifications
        Inherits TornResource

        <JsonProperty("notifications")>
        Public Property Notifications As Notification
    End Class

    Public Class Notification
        <JsonProperty("messages")>
        Public Property Messages As Long
        <JsonProperty("events")>
        Public Property Events As Long
        <JsonProperty("awards")>
        Public Property Awards As Long
        <JsonProperty("competition")>
        Public Property Competition As Long
    End Class
End Namespace
