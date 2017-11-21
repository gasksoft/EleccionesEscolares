Imports System.ComponentModel
Imports System.Runtime.CompilerServices

Public Class DashBoardItemUc
    Implements INotifyPropertyChanged

    Private _valor As Double
    Private _formato As String

    <Bindable(True)>
    Public Property Titulo As String
        Get
            Return lblTitle.Text
        End Get
        Set
            SetProperty(lblTitle.Text, Value)
        End Set
    End Property

    <Bindable(True)>
    Public Property Valor As Double
        Get
            Return _valor
        End Get
        Set(value As Double)
            If SetProperty(_valor, value) Then
                UpdateValue()
            End If
        End Set
    End Property

    <Bindable(True), DefaultValue("")>
    Public Property Formato As String
        Get
            Return _formato
        End Get
        Set(value As String)
            SetProperty(_formato, value)
            UpdateValue()
        End Set
    End Property

    Private Sub UpdateValue()
        lblValue.Text = Strings.Format(_valor, Formato)
    End Sub

#Region "INotifyPropertyChanged"
    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
    Protected Sub OnPropertyChanged(<CallerMemberName> Optional propertyName As String = Nothing)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
    End Sub
    Protected Function SetProperty(Of T)(ByRef storage As T, value As T, <CallerMemberName> Optional propertyName As String = Nothing) As Boolean
        If Equals(storage, value) Then
            Return False
        End If
        storage = value
        OnPropertyChanged(propertyName)
        Return True
    End Function
#End Region
End Class
