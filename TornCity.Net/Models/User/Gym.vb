Imports Newtonsoft.Json

Namespace Models.User
    Public Class Gym
        Inherits TornResource

        <JsonProperty("active_gym")>
        Public Property ActiveGym As Long
    End Class
End Namespace
