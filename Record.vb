Public Class Record

    Public Property ID As Integer
    Public Property User As Integer = 2 ' 2 is for developer

    Private _StartTimeStamp As DateTime
    Private _EndTimeStamp As DateTime

    Private _Duration As Integer
    Public Property StartTimeStamp As DateTime
        Get
            Return _StartTimeStamp
        End Get
        Set(value As DateTime)
            _StartTimeStamp = value
        End Set
    End Property
    Public Property EndTimeStamp As DateTime
        Get
            Return _EndTimeStamp
        End Get
        Set(value As DateTime)
            _EndTimeStamp = value
        End Set
    End Property
    Public ReadOnly Property Duration As Integer
        Get
            _Duration = (_EndTimeStamp - _StartTimeStamp).TotalMinutes
            Return _Duration
        End Get
    End Property
End Class