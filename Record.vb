Public Class Record

    Public Property ID As Integer
    Public Property User As Integer = 2 ' 2 is for developer

    Private _Starts As DateTime
    Private _Ends As DateTime
    Public Property Starts As DateTime
        Get
            Return _Starts
        End Get
        Set(value As DateTime)
            _Starts = value
        End Set
    End Property
    Public Property Ends As DateTime
        Get
            Return _Ends
        End Get
        Set(value As DateTime)
            _Ends = value
        End Set
    End Property
End Class