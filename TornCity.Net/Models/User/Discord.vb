Imports Newtonsoft.Json

Namespace Models.User
    Partial Public Class Discord
        Inherits TornResource

        <JsonProperty("discord")>
        Public Property Discord As DiscordData
    End Class
    Public Class DiscordData
        <JsonProperty("userID")>
        Public Property UserId As Long
        <JsonProperty("discordID")>
        Public Property DiscordId As ULong?
    End Class
End Namespace
