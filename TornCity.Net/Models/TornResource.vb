Imports TornCity.Net.Models.Common

Public MustInherit Class TornResource
    Inherits Timestamp
    Public Property ErrorMessage As String
    Public ReadOnly Property IsSpecified As Boolean
        Get
            Return String.IsNullOrEmpty(ErrorMessage)
        End Get
    End Property
End Class
