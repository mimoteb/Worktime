Imports System.Data.Entity.Core
Imports System.Data.SQLite
Imports System.Globalization

Module helpers
#Region "Variables and Place Holders"
    Public DateFormat As String = "yyyy.MM.dd"
    Public TimeFormat As String = "HH:MM"
    Public dbFormat As String = "yyyy.MM.dd HH:MM:00"
    Public connectionString As String = $"Data Source={My.Settings.ConnectionString};Version=3;"

    Public connection As New SQLiteConnection(connectionString)
    ' public Variables
#End Region

#Region "SQL Functions"
    Sub OpenConnection()
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If
    End Sub

    Sub CloseConnection()
        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If
    End Sub
    ' Insert a new record
    Sub InsertRecord(r As Record)
        Try
            OpenConnection()

            Dim query As String = "INSERT INTO record (User,DayDate,StartTime,EndTime,Duration) " &
                "VALUES (@User,strftime('%Y.%d.%m', @YourDate),@StartTime,@EndTime,Duration)"
            Dim command As New SQLiteCommand(query, connection)

            ' Use parameters to avoid SQL injection
            command.Parameters.AddWithValue("@user", r.User)
            command.Parameters.AddWithValue("@DayDate", r.DayDate)
            command.Parameters.AddWithValue("@StartTime", r.StartTime)
            command.Parameters.AddWithValue("@EndTime", r.EndTime)
            command.Parameters.AddWithValue("@duration", r.Duration)
            command.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            CloseConnection()
        End Try
    End Sub

    ' Update a record in the database
    Sub UpdateRecord(r As Record)
        Try
            OpenConnection()

            Dim query As String = "Update record set DayDate=@daydate, StartTime=@starttime, EndTime=@endtime, Duration=@duration where ID=@id and User=@user"
            Dim command As New SQLiteCommand(query, connection)
            '
            ' Use parameters to avoid SQL injection
            command.Parameters.AddWithValue("@id", r.ID)
            command.Parameters.AddWithValue("@user", r.User)
            command.Parameters.AddWithValue("@daydate", r.DayDate)
            command.Parameters.AddWithValue("@starttime", r.StartTime)
            command.Parameters.AddWithValue("@endtime", r.EndTime)
            command.Parameters.AddWithValue("@duration", r.Duration)
            command.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            CloseConnection()
        End Try
    End Sub

    ' Delete a record
    Sub DeleteRecord(r As Record)
        Try
            OpenConnection()

            Dim query As String = "DELETE FROM record WHERE ID=@id and User=@user"
            Dim command As New SQLiteCommand(query, connection)

            ' Use parameters to avoid SQL injection
            command.Parameters.AddWithValue("@id", r.ID)
            command.Parameters.AddWithValue("@user", r.User)

            command.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            CloseConnection()
        End Try
    End Sub

    ' Retrieve all records
    Function GetAllRecords() As List(Of Record)
        Dim Rows As New List(Of Record)

        Try
            OpenConnection()

            Dim query As String = "SELECT * FROM record"
            Dim command As New SQLiteCommand(query, connection)
            Dim r As SQLiteDataReader = command.ExecuteReader()
            ' User,DayDate,StartTime,EndTime,Duration
            If r.HasRows Then
                While r.Read()
                    Dim rec As New Record()
                    With rec
                        .ID = r.GetInt32(r.GetOrdinal("id"))
                        .User = r.GetInt32(r.GetOrdinal("User"))
                        .DayDate = r.GetString(r.GetOrdinal("DayDate"))
                        .StartTime = r.GetString(r.GetOrdinal("StartHour"))
                        .EndTime = r.GetString(r.GetOrdinal("EndTime"))
                        .Duration = r.GetInt32(r.GetOrdinal("Duration"))
                    End With
                    Rows.Add(rec)
                End While
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            CloseConnection()
        End Try

        Return Rows
    End Function

    Function GetDayRecord(TargetDate As String) As List(Of Record)
        Dim Rows As New List(Of Record)
        TargetDate = DateTime.ParseExact(TargetDate, DateFormat, CultureInfo.InvariantCulture).ToString(DateFormat)

        Try
            OpenConnection()

            Dim query As String = "SELECT * FROM record WHERE DayDate LIKE @TargetDate"

            Dim command As New SQLiteCommand(query, connection)
            command.Parameters.AddWithValue("@TargetDate", TargetDate)
            Dim r As SQLiteDataReader = command.ExecuteReader()
            If r.HasRows Then
                While r.Read()
                    Dim rec As New Record()
                    With rec
                        .ID = r.GetInt32(r.GetOrdinal("id"))
                        .User = r.GetInt32(r.GetOrdinal("User"))
                        .DayDate = r.GetString(r.GetOrdinal("DayDate"))
                        .StartTime = r.GetString(r.GetOrdinal("StartTime"))
                        .EndTime = r.GetString(r.GetOrdinal("EndTime"))
                        .Duration = r.GetInt32(r.GetOrdinal("Duration"))
                    End With
                    Rows.Add(rec)
                End While
                Debug.WriteLine($"GetDayRecord - TargetDate: {TargetDate} Query: {query} r.HasRows: {r.HasRows}")
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            CloseConnection()
        End Try

        Return Rows
    End Function
    Function GetMonth_Records(TargetDate As String) As List(Of Record)
        Dim Rows As New List(Of Record)
        TargetDate = DateTime.ParseExact(TargetDate, DateFormat, CultureInfo.InvariantCulture).ToString("yyyy.MM")

        Try
            OpenConnection()

            Dim query As String = "SELECT * FROM record WHERE strftime('%Y.%m', DayDate) like '%@TargetDate%'"

            Dim command As New SQLiteCommand(query, connection)
            command.Parameters.AddWithValue("@TargetDate", TargetDate)
            Dim r As SQLiteDataReader = command.ExecuteReader()
            ' User,DayDate,StartTime,EndTime,Duration
            If r.HasRows Then
                While r.Read()
                    Dim rec As New Record()
                    With rec
                        .ID = r.GetInt32(r.GetOrdinal("id"))
                        .User = r.GetInt32(r.GetOrdinal("User"))
                        .DayDate = r.GetString(r.GetOrdinal("DayDate"))
                        .StartTime = r.GetString(r.GetOrdinal("StartHour"))
                        .EndTime = r.GetString(r.GetOrdinal("EndTime"))
                        .Duration = r.GetInt32(r.GetOrdinal("Duration"))
                    End With
                    Rows.Add(rec)
                End While
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            CloseConnection()
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


