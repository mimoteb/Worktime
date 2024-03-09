Public Class Record
    Private Property _endTime As String
    Private _tsEnd As DateTime
    Private _tsStar As DateTime
    Public Property ID As Integer
    Public Property User As Integer
    Public Property DayDate As String
    Public Property StartTime As String
    Public Property Duration As Integer
    Public Property tsStart As DateTime
        Get
            Return tsStart
        End Get
        Set(value As DateTime)

        End Set
    End Property

    Public Property tsEnd As DateTime
        Get
            Return _tsEnd
        End Get
        Set(value As DateTime)

        End Set
    End Property

    Public Property EndTime As String
        Get
            Return _endTime
        End Get
        Set(value As String)
            _endTime = value
            If value.Contains(":") Then
                'update self duration variable's value
                Dim HourStart As Integer = CInt(StartTime.Split(":")(0))
                Dim MinuteStart As Integer = CInt(StartTime.Split(":")(1))
                Dim HourEnd As Integer = CInt(value.Split(":")(0))
                Dim MinuteEnd As Integer = CInt(value.Split(":")(1))
                Dim tstart As New DateTime(1, 1, 1, HourStart, MinuteStart, 0)
                Dim tend As New DateTime(1, 1, 1, HourEnd, MinuteEnd, 0)
                Duration = (tend - tstart).TotalMinutes
            End If

        End Set
    End Property
End Class
Public Class C
    Private _timeStamp As DateTime
    Public Property Year As Integer
    Public Property Month As Integer
    Public Property Day As Integer
    Public Property DayOfWeek As Integer
    Public Property HourStart As Integer
    Public Property HourEnd As Integer
    Public Property MinuteStart As Integer
    Public Property MinuteEnd As Integer

    Public Property TimeStamp As DateTime
        Get
            Return _timeStamp
        End Get
        Set(value As DateTime)
            _timeStamp = value
            UpdatePropertiesFromTimeStamp()
        End Set
    End Property

    Private Sub UpdatePropertiesFromTimeStamp()
        ' Update other properties based on TimeStamp
        Year = _timeStamp.Year
        Month = _timeStamp.Month
        Day = _timeStamp.Day
        DayOfWeek = CType(_timeStamp.DayOfWeek, Integer)
        HourStart = _timeStamp.Hour
        MinuteStart = _timeStamp.Minute

        ' You might want to set HourEnd and MinuteEnd based on your specific logic
        ' For now, let's set them to HourStart + 1 and MinuteStart + 30
        HourEnd = (_timeStamp.Hour + 1) Mod 24
        MinuteEnd = (_timeStamp.Minute + 30) Mod 60
    End Sub
End Class
