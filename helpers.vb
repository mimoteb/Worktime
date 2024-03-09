Imports System.Data.SQLite
Imports System.Diagnostics.Eventing
Imports System.Globalization
Imports System.Security.Cryptography

Module helpers
    Public ViewingMonth As String = Nothing
    Public TimeFormat As String = "HH:MM"
    Public dbFormat As String = "yyyy-MM-dd HH:mm:00"
    Public DateFormat As String = "yyyy-MM-dd"

    Public connectionString As String = $"Data Source={My.Settings.ConnectionString};Version=3;"
    Public conn As New SQLiteConnection(connectionString)
    Public UID As Integer
#Region "Variables and Place Holders"

    ' public Variables
#End Region

#Region "SQL Functions"
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
    ' Insert a new record
    Sub InsertRecord(r As Record)
        Try
            Connection()
            Dim query As String = "INSERT INTO record (User,StartTimeStamp,EndTimeStamp) VALUES (@User, @StartTimeStamp, @EndTimeStamp)"
            Dim cmd As New SQLiteCommand(query, conn)
            With cmd.Parameters
                .AddWithValue("@User", r.User)
                .AddWithValue("@StartTimeStamp", r.StartTimeStamp)
                .AddWithValue("@EndTimeStamp", r.EndTimeStamp)
            End With
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            Connection(False)
        End Try
    End Sub

    ' Update a record in the database
    Sub UpdateRecord(r As Record)
        Try
            Connection()

            Dim query As String = "Update record set StartTimeStamp=@StartTimeStamp, EndTimeStamp=@EndTimeStamp where ID=@id and User=@user"
            Dim cmd As New SQLiteCommand(query, conn)
            '
            With cmd.Parameters
                .AddWithValue("@ID", r.ID)
                .AddWithValue("@User", r.User)
                .AddWithValue("@StartTimeStamp", r.StartTimeStamp)
                .AddWithValue("@EndTimeStamp", r.EndTimeStamp)
            End With
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            Connection(False)
        End Try
    End Sub

    ' Delete a record
    Sub DeleteRecord(r As Record)
        Try
            Connection()
            Dim query As String = "DELETE FROM record WHERE ID=@ID and User=@User"
            Dim cmd As New SQLiteCommand(query, conn)
            With cmd.Parameters
                .AddWithValue("@ID", r.ID)
                .AddWithValue("@User", r.User)
            End With
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            Connection(False)
        End Try
    End Sub

    ' Retrieve all records
    Function GetAllRecords() As List(Of Record)
        Dim Rows As New List(Of Record)
        Try
            Connection()

            Dim query As String = "SELECT * FROM record"
            Dim command As New SQLiteCommand(query, conn)
            Dim r As SQLiteDataReader = command.ExecuteReader()
            ' User,DayDate,StartTime,EndTime,Duration
            If r.HasRows Then
                While r.Read()
                    Dim rec As New Record()
                    With rec
                        .ID = r.GetInt32(r.GetOrdinal("id"))
                        .User = r.GetInt32(r.GetOrdinal("User"))
                        .StartTimeStamp = r.GetDateTime(r.GetOrdinal("StartTimeStamp"))
                        .EndTimeStamp = r.GetDateTime(r.GetOrdinal("EndTimeStamp"))
                    End With
                    Rows.Add(rec)
                End While
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            Connection(False)
        End Try

        Return Rows
    End Function

    Function GetDayRecord(curDate As DateTime) As List(Of Record)
        Dim Rows As New List(Of Record)
        Try
            Connection()
            Dim query As String = "SELECT * FROM record WHERE StartTimeStamp LIKE @curDate"

            Dim cmd As New SQLiteCommand(query, conn)
            cmd.Parameters.AddWithValue("@curDate", "%" & curDate.ToString(DateFormat) & "%")
            Dim Reader As SQLiteDataReader = cmd.ExecuteReader()
            If Reader.HasRows Then
                While Reader.Read()
                    Dim rec As New Record()
                    With Reader
                        rec.ID = .GetInt32(.GetOrdinal("ID"))
                        rec.User = .GetInt32(.GetOrdinal("User"))
                        rec.StartTimeStamp = .GetDateTime(.GetOrdinal("StartTimeStamp"))
                        rec.EndTimeStamp = .GetDateTime(.GetOrdinal("EndTimeStamp"))
                    End With

                    Rows.Add(rec)
                End While
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            Connection(False)
        End Try

        Return Rows
    End Function
    Function GetMonth_Records(TargetDate As String) As List(Of Record)
        Dim Rows As New List(Of Record)
        TargetDate = DateTime.ParseExact(TargetDate, DateFormat, CultureInfo.InvariantCulture).ToString("yyyy.MM")

        Try
            Connection()

            Dim query As String = "SELECT * FROM record WHERE strftime('%Y.%m', DayDate) like '%@TargetDate%'"

            Dim command As New SQLiteCommand(query, conn)
            command.Parameters.AddWithValue("@TargetDate", TargetDate)
            Dim r As SQLiteDataReader = command.ExecuteReader()
            ' User,DayDate,StartTime,EndTime,Duration
            If r.HasRows Then
                While r.Read()
                    Dim rec As New Record()
                    With rec
                        .ID = r.GetInt32(r.GetOrdinal("id"))
                        .User = r.GetInt32(r.GetOrdinal("User"))
                    End With
                    Rows.Add(rec)
                End While
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            Connection(False)
        End Try

        Return Rows
    End Function

#End Region



#Region "general Functions"

    Public Function FormatTimeDifference(totalMinutes As Integer) As String
        Dim formattedDifference As String = ""

        If totalMinutes >= 60 Then
            Dim hours As Integer = totalMinutes \ 60
            formattedDifference += $"{hours} Hour "
            totalMinutes -= hours * 60
        End If

        If totalMinutes > 0 Then
            formattedDifference += $"{totalMinutes} Minute"
        End If

        If formattedDifference = "" Then
            formattedDifference = "0 Minutes"
        End If

        Return formattedDifference
    End Function
    Function ConvertMinutesToHHMM(TotalMinutes As Decimal) As String
        ' Calculate hours and minutes
        Dim HH As Integer = CInt(Math.Floor(TotalMinutes / 60))
        Dim MM As Integer = CInt(TotalMinutes Mod 60)

        ' Format the result
        Return $"{HH:D2}:{MM:D2}"
    End Function
#End Region

End Module


