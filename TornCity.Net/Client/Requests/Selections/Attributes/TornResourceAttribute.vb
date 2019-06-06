Option Strict On
Option Infer On

Friend Class TornResourceAttribute
    Inherits Attribute

    Friend ReadOnly Property Type As Type

    Public Sub New(ByVal type As Type)
        Me.Type = type
    End Sub
End Class
