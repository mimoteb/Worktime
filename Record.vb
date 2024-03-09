﻿Public Class Record

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
'Public Class C
'    Private _timeStamp As DateTime
'    Public Property Year As Integer
'    Public Property Month As Integer
'    Public Property Day As Integer
'    Public Property DayOfWeek As Integer
'    Public Property HourStart As Integer
'    Public Property HourEnd As Integer
'    Public Property MinuteStart As Integer
'    Public Property MinuteEnd As Integer

'    Public Property TimeStamp As DateTime
'        Get
'            Return _timeStamp
'        End Get
'        Set(value As DateTime)
'            _timeStamp = value
'            UpdatePropertiesFromTimeStamp()
'        End Set
'    End Property

'    Private Sub UpdatePropertiesFromTimeStamp()
'        ' Update other properties based on TimeStamp
'        Year = _timeStamp.Year
'        Month = _timeStamp.Month
'        Day = _timeStamp.Day
'        DayOfWeek = CType(_timeStamp.DayOfWeek, Integer)
'        HourStart = _timeStamp.Hour
'        MinuteStart = _timeStamp.Minute

'        ' You might want to set HourEnd and MinuteEnd based on your specific logic
'        ' For now, let's set them to HourStart + 1 and MinuteStart + 30
'        HourEnd = (_timeStamp.Hour + 1) Mod 24
'        MinuteEnd = (_timeStamp.Minute + 30) Mod 60
'    End Sub
'End Class
