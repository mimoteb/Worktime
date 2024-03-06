Imports System.Data.SQLite

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
        Try
            OpenConnection()

            Dim query As String = "INSERT INTO record (user, timestamp, duration) VALUES (@user, @timestamp, @duration)"
            Dim command As New SQLiteCommand(query, connection)

            ' Use parameters to avoid SQL injection
            command.Parameters.AddWithValue("@user", r.User)
            command.Parameters.AddWithValue("@timestamp", r.Timestamp) ' Format the DateTime parameter to match SQLite DATETIME format
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

            Dim query As String = "UPDATE record SET timestamp = @timestamp, duration = @duration, user = @user WHERE id = @id"
            Dim command As New SQLiteCommand(query, connection)

            ' Use parameters to avoid SQL injection
            command.Parameters.AddWithValue("@id", r.ID)
            command.Parameters.AddWithValue("@timestamp", r.Timestamp)
            command.Parameters.AddWithValue("@duration", r.Duration)
            command.Parameters.AddWithValue("@user", r.User)

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

            Dim query As String = "DELETE FROM record WHERE id = @id and user=@user"
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
        Try
            OpenConnection()


            ' Use a parameterized query to filter records by date
            Dim query As String = "SELECT * FROM record WHERE timestamp like '%@TargetDate%'"
            Dim command As New SQLiteCommand(query, connection)

            ' Use parameters to avoid SQL injection
            command.Parameters.AddWithValue("@TargetDate", DatabaseFormat)
            Debug.WriteLine($"[GetRecordsByDate] targetDate:{targetDate}")
            Debug.WriteLine($"[GetRecordsByDate] Query: {command.CommandText}")
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
            Else
                Debug.WriteLine($"[GetRecordsByDate] reader.HasRows: {reader.HasRows}")
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            CloseConnection()
        End Try

        Return records
    End Function

End Module


