Imports Newtonsoft.Json

Namespace Models.User
    Public Class Profile
        Inherits TornResource

        <JsonProperty("rank")>
        Public Property Rank As String
        <JsonProperty("level")>
        Public Property Level As Long
        <JsonProperty("gender")>
        Public Property Gender As String
        <JsonProperty("property")>
        Public Property [Property] As String
        <JsonProperty("signup")>
        Public Property Signup As DateTimeOffset
        <JsonProperty("awards")>
        Public Property Awards As Long
        <JsonProperty("friends")>
        Public Property Friends As Long
        <JsonProperty("enemies")>
        Public Property Enemies As Long
        <JsonProperty("forum_posts")>
        Public Property ForumPosts As Long
        <JsonProperty("karma")>
        Public Property Karma As Long
        <JsonProperty("age")>
        Public Property Age As Long
        <JsonProperty("role")>
        Public Property Role As String
        <JsonProperty("donator")>
        Public Property Donator As Long
        <JsonProperty("player_id")>
        Public Property PlayerId As Long
        <JsonProperty("name")>
        Public Property Name As String
        <JsonProperty("property_id")>
        Public Property PropertyId As Long
        <JsonProperty("life")>
        Public Property Life As Life
        <JsonProperty("status")>
        Public Property Status As List(Of String)
        <JsonProperty("job")>
        Public Property Job As Job
        <JsonProperty("faction")>
        Public Property Faction As Faction
        <JsonProperty("married")>
        Public Property Married As Married
        <JsonProperty("basicicons")>
        Public Property BasicIcons As Dictionary(Of String, String)
        <JsonProperty("states")>
        Public Property States As States
        <JsonProperty("last_action")>
        Public Property LastAction As LastAction
    End Class

    Public Class Faction
        <JsonProperty("position")>
        Public Property Position As String
        <JsonProperty("faction_id")>
        Public Property FactionId As Long
        <JsonProperty("days_in_faction")>
        Public Property DaysInFaction As Long
        <JsonProperty("faction_name")>
        Public Property FactionName As String
    End Class

    Public Class Job
        <JsonProperty("position")>
        Public Property Position As String
        <JsonProperty("company_id")>
        Public Property CompanyId As Long
        <JsonProperty("company_name")>
        Public Property CompanyName As String
    End Class

    Public Class LastAction
        <JsonProperty("timestamp")>
        Public Property Timestamp As Long
        <JsonProperty("relative")>
        Public Property Relative As String
    End Class

    Public Class Life
        <JsonProperty("current")>
        Public Property Current As Long
        <JsonProperty("maximum")>
        Public Property Maximum As Long
        <JsonProperty("increment")>
        Public Property Increment As Long
        <JsonProperty("interval")>
        Public Property Interval As Long
        <JsonProperty("ticktime")>
        Public Property Ticktime As Long
        <JsonProperty("fulltime")>
        Public Property Fulltime As Long
    End Class

    Public Class Married
        <JsonProperty("spouse_id")>
        Public Property SpouseId As Long
        <JsonProperty("spouse_name")>
        Public Property SpouseName As String
        <JsonProperty("duration")>
        Public Property Duration As Long
    End Class

    Public Class States
        <JsonProperty("hospital_timestamp")>
        Public Property HospitalTimestamp As Long
        <JsonProperty("jail_timestamp")>
        Public Property JailTimestamp As Long
    End Class
End Namespace
