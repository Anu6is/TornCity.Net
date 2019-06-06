Option Strict On
Option Infer On

Imports System.Collections.Immutable

Public Interface ISelector
    ReadOnly Property ApiEndpoint As String
    ReadOnly Property Fields As ImmutableArray(Of Type)
    Function Resolve() As String
End Interface
