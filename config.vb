Imports System.Data.SQLite

Public Class C


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
