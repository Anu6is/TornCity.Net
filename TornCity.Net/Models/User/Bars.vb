Imports Newtonsoft.Json

Namespace Models.User
    Public Class Bars
        Inherits TornResource

        <JsonProperty("server_time")>
        Public Property ServerTime As Long
        <JsonProperty("happy")>
        Public Property Happy As Bar
        <JsonProperty("life")>
        Public Property Life As Bar
        <JsonProperty("energy")>
        Public Property Energy As Bar
        <JsonProperty("nerve")>
        Public Property Nerve As Bar
        <JsonProperty("chain")>
        Public Property Chain As Chain
    End Class

    Public Class Bar
        ''' <summary>
        ''' Current level of the bar
        ''' </summary>
        <JsonProperty("current")>
        Public Property Current As Long

        ''' <summary>
        ''' Maximum level of the bar
        ''' </summary>
        <JsonProperty("maximum")>
        Public Property Maximum As Long

        ''' <summary>
        ''' Amount bar is increased by per interval
        ''' </summary>
        <JsonProperty("increment")>
        Public Property Increment As Long

        ''' <summary>
        ''' The period of time required for the bar to be incrased
        ''' Increases by <see cref="Increment"/> once interval has elapsed
        ''' </summary>
        <JsonProperty("interval")>
        Public Property Interval As Long

        ''' <summary>
        ''' Countdown to <see cref="Interval"/> expiration (time until 00:00) 
        ''' </summary>
        <JsonProperty("ticktime")>
        Public Property Ticktime As Long

        ''' <summary>
        ''' Time until bar is full
        ''' </summary>
        <JsonProperty("fulltime")>
        Public Property Fulltime As Long
    End Class

    Public Class Chain
        <JsonProperty("current")>
        Public Property Current As Long
        <JsonProperty("maximum")>
        Public Property Maximum As Long
        <JsonProperty("timeout")>
        Public Property Timeout As Long
        <JsonProperty("modifier")>
        Public Property Modifier As Long
        <JsonProperty("cooldown")>
        Public Property Cooldown As Long
    End Class
End Namespace
