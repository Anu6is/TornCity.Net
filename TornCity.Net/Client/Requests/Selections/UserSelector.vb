Option Strict On
Option Infer On

Imports System.Collections.Immutable
Imports TornCity.Net

Public Class UserSelector
    Implements ISelector

    Public ReadOnly Property Fields As ImmutableArray(Of Type) Implements ISelector.Fields

    Public ReadOnly Property ApiEndpoint As String Implements ISelector.ApiEndpoint
        Get
            Return "user"
        End Get
    End Property

    Public Sub New(ParamArray selections() As UserSelection)
        Dim unique = selections.Distinct.ToImmutableArray
        Fields = unique.Select(Function(u) u.ToTornResource()).ToImmutableArray
    End Sub

    Public Function Resolve() As String Implements ISelector.Resolve
        Return String.Join(",", Fields.Select(Function(type) type.Name.ToLower))
    End Function
End Class
