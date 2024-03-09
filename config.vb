Imports System.Data.SQLite

Public Class C
    Public conn As New SQLiteConnection(connectionString)
    Public connectionString As String = $"Data Source={My.Settings.ConnectionString};Version=3;"

    Private _DateFormat As String = "yyyy-MM-dd"
    Private _ViewingMonth As String = Nothing
    Private _TimeFormat As String = "HH:MM"
    Private _dbFormat As String = "yyyy-MM-dd HH:mm:00"


    Public ReadOnly Property TimeFormat As String
        Get 
            Return _TimeFormat
        End Get
    End Property
    Public ReadOnly Property DateFormat As String
        Get
            Return _DateFormat
        End Get
    End Property




    Public Property ViewingMonth As String
        Get
            Return _ViewingMonth
        End Get
        Set(value As String)
            _ViewingMonth = value
        End Set
    End Property
    Public Sub Connection(Optional ByVal WillConnect = True)
        If WillConnect Then
            Try
                conn.Open()
            Catch ex As Exception

            End Try
        Else
            conn.Close()
        End If
    End Sub

End Class
