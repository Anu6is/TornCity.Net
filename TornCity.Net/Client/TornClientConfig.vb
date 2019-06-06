Option Strict On
Option Infer On

Imports System.Net.Http

Public Class TornClientConfig
    Public Property ApiKey As String
    Public ReadOnly Property ApiBaseUrl As Uri
        Get
            Return New Uri("https://api.torn.com/")
        End Get
    End Property

    Private ReadOnly MinCacheExpiration As Integer = 30
    Private _duration As Integer = MinCacheExpiration
    Public Property CacheDurationSeconds As Integer
        Get
            Return _duration
        End Get
        Set(value As Integer)
            If value < MinCacheExpiration Then Return
            _duration = value
        End Set
    End Property

    Public Property HttpMessageHandler As HttpMessageHandler
End Class
