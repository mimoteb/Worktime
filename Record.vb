Imports System.Globalization

Public Class Record

    Public Property ID As Integer
    Public Property User As Integer = 2 ' 2 is for developer

    Private _Starts As DateTime
    Private _Ends As DateTime
    Private _Started As String
    Private _Ended As String
    Private _WorkDate As String
    Public Property Starts As DateTime
        Get
            Return _Starts
        End Get
        Set(value As DateTime)
            _Starts = value
            _Started = value.ToString(TimeFormat)
            _WorkDate = value.ToString(DateFormat)
        End Set
    End Property
    Public Property Ends As DateTime
        Get
            Return _Ends
        End Get
        Set(value As DateTime)
            _Ends = value
            _Ended = value.ToString(TimeFormat)
        End Set
    End Property

    Public Property Started As String
        Get
            Return _Started
        End Get
        Set(value As String)
            'If Not String.IsNullOrEmpty(value) Then
            '    Dim tm As DateTime = DateTime.ParseExact(value, TimeFormat, CultureInfo.InvariantCulture)
            '    _Started = tm.ToString(TimeFormat)
            '    Starts = New DateTime(Starts.Year, Starts.Month, Starts.Day, tm.Hour, tm.Minute, 0)
            'End If
        End Set
    End Property
    Public Property Ended As String
        Get
            Return _Ended
        End Get
        Set(value As String)
            'If Not String.IsNullOrEmpty(value) Then
            '    Dim tm As DateTime = DateTime.ParseExact(value, TimeFormat, CultureInfo.InvariantCulture)
            '    _Started = tm.ToString(TimeFormat)
            '    Ends = New DateTime(Ends.Year, Ends.Month, Ends.Day, tm.Hour, tm.Minute, 0)
            'End If
        End Set
    End Property
    Public ReadOnly Property WorkDate As String
        Get
            Return _WorkDate
        End Get
    End Property
End Class