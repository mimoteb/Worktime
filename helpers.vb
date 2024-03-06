Imports System.Data.SQLite
Imports System.IO
Imports System.Globalization

Module helpers
    Public DateFormat As String = "yyyy.MM.dd"
    Public TimeFormat As String = "HH:MM:00"
    Public DatabaseFormat As String = "yyyy-MM-dd HH:MM:00"
    'Dim DatabaseFileName As String = "C:\Users\sas822\OneDrive - Hanebutt IT-Consult GmbH\databases\worktime.db"

    Dim connectionString As String = $"Data Source={My.Settings.db};Version=3;"

    Dim connection As New SQLiteConnection(connectionString)

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
        Dim timestamp As Date, duration As Integer, user As Integer
        Try
            OpenConnection()

            Dim query As String = "INSERT INTO record (timestamp, duration, user) VALUES (@timestamp, @Duration, @User)"
            Dim command As New SQLiteCommand(query, connection)



            ' Use parameters to avoid SQL injection
            command.Parameters.AddWithValue("@timestamp", timestamp.ToString("yyyy-MM-dd HH:mm:ss")) ' Format the DateTime parameter to match SQLite DATETIME format
            command.Parameters.AddWithValue("@Duration", duration)
            command.Parameters.AddWithValue("@User", user)

            command.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            CloseConnection()
        End Try
    End Sub

    ' Update the record in the database
    Sub UpdateRecord(record As Record)

        ' ID As Integer, timestamp As String, duration As Integer, user As Integer
        Try
            OpenConnection()

            Dim query As String = "UPDATE record SET Timestamp = @Timestamp, duration = @Duration, user = @User WHERE id = @ID"
            Dim command As New SQLiteCommand(query, connection)

            ' Use parameters to avoid SQL injection
            command.Parameters.AddWithValue("@ID", record.ID)
            command.Parameters.AddWithValue("@Timestamp", record.Timestamp)
            command.Parameters.AddWithValue("@Duration", record.Duration)
            command.Parameters.AddWithValue("@User", record.User)

            Debug.WriteLine(command.CommandText)
            command.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            CloseConnection()
        End Try
    End Sub

    ' Delete a record by ID
    Sub DeleteRecord(id As Integer)
        Try
            OpenConnection()

            Dim query As String = "DELETE FROM record WHERE id = @ID"
            Dim command As New SQLiteCommand(query, connection)

            ' Use parameters to avoid SQL injection
            command.Parameters.AddWithValue("@ID", id)

            command.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            CloseConnection()
        End Try
    End Sub

    ' Retrieve all records
    Function GetAllRecords() As List(Of Record)
        Dim records As New List(Of Record)

        Try
            OpenConnection()

            Dim query As String = "SELECT * FROM record"
            Dim command As New SQLiteCommand(query, connection)
            Dim reader As SQLiteDataReader = command.ExecuteReader()

            If reader.HasRows Then
                While reader.Read()
                    Dim record As New Record()
                    record.ID = reader.GetInt32(reader.GetOrdinal("id"))
                    record.Timestamp = reader.GetString(reader.GetOrdinal("timestamp"))
                    record.Duration = reader.GetInt32(reader.GetOrdinal("duration"))
                    record.User = reader.GetInt32(reader.GetOrdinal("user"))
                    records.Add(record)
                End While
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            CloseConnection()
        End Try

        Return records
    End Function

    Function GetRecordsByDate(targetDate As DateTime) As List(Of Record)
        Dim records As New List(Of Record)
        Debug.WriteLine(targetDate)
        Try
            OpenConnection()

            ' Convert targetDate to SQLite3 date format
            Dim sqliteDateFormat As String = targetDate.ToString("yyyy-MM-dd HH:mm:ss")

            ' Use a parameterized query to filter records by date
            Dim query As String = "SELECT * FROM record WHERE CAST(timestamp AS DATE) = @TargetDate"
            Dim command As New SQLiteCommand(query, connection)

            ' Use parameters to avoid SQL injection
            command.Parameters.AddWithValue("@TargetDate", sqliteDateFormat)

            Dim reader As SQLiteDataReader = command.ExecuteReader()

            If reader.HasRows Then
                While reader.Read()
                    Dim record As New Record()
                    record.ID = reader.GetInt32(reader.GetOrdinal("id"))
                    record.Timestamp = reader.GetString(reader.GetOrdinal("timestamp"))
                    record.Duration = reader.GetInt32(reader.GetOrdinal("duration"))
                    record.User = reader.GetInt32(reader.GetOrdinal("user"))
                    records.Add(record)
                End While
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            CloseConnection()
        End Try

        Return records
    End Function

End Module


