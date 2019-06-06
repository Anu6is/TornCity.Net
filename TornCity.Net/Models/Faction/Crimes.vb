Imports Newtonsoft.Json

Namespace Models.Faction
    Public Class Crimes
        Inherits TornResource

        <JsonProperty("crimes")>
        Public Property CrimesCrimes As Dictionary(Of String, Crime)
    End Class

    Public Class Crime
        <JsonProperty("crime_id")>
        Public Property CrimeId As Long
        <JsonProperty("crime_name")>
        Public Property CrimeName As String
        <JsonProperty("participants")>
        Public Property Participants As Dictionary(Of String, List(Of String))
        <JsonProperty("time_started")>
        Public Property TimeStarted As Long
        <JsonProperty("time_ready")>
        Public Property TimeReady As Long
        <JsonProperty("time_left")>
        Public Property TimeLeft As Long
        <JsonProperty("time_completed")>
        Public Property TimeCompleted As Long
        <JsonProperty("initiated")>
        Public Property Initiated As Long
        <JsonProperty("success")>
        Public Property Success As Long
        <JsonProperty("money_gain")>
        Public Property MoneyGain As Long
        <JsonProperty("respect_gain")>
        Public Property RespectGain As Long
    End Class
End Namespace
