Imports Elecciones.Data.Contexto

Public Class ContextLocator
    Private Shared _instance As Lazy(Of ContextLocator)
    Private Shared ReadOnly _locker As New Object
    Public Shared ReadOnly Property Instance As ContextLocator
        Get
            SyncLock _locker
                If _instance Is Nothing Then
                    _instance = New Lazy(Of ContextLocator)(Function() New ContextLocator(), System.Threading.LazyThreadSafetyMode.ExecutionAndPublication)
                End If
                Return _instance.Value
            End SyncLock
        End Get
    End Property
    Private Sub New()
        Contexto = New EleccionesContext
    End Sub

    Public Property Contexto As EleccionesContext
End Class