Imports System.Data.SQLite
Imports System.Globalization
Imports System.Net.Mail

Public Class MainForm
    Private originalValue As Object
    Private edited_ID As Integer

#Region "Interface"
    Private Sub mnuCalc_Click(sender As Object, e As EventArgs) Handles mnuCalc.Click
        CalcForm.ShowDialog()
    End Sub

    Private Sub mnuAbout_Click(sender As Object, e As EventArgs) Handles mnuAbout.Click
        AboutForm.ShowDialog()
    End Sub

    Private Sub mnuDisplaySaturdays_Click(sender As ToolStripMenuItem, e As EventArgs, Optional _UpdateCalendar As Boolean = True) Handles mnuDisplaySaturdays.Click, mnuDisplaySundays.Click
        sender.Checked = Not sender.Checked
        If _UpdateCalendar Then UpdateCalendar()
    End Sub

    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        My.Settings.mnuDisplaySaturdays = mnuDisplaySaturdays.Checked
        My.Settings.mnuDisplaySundays = mnuDisplaySundays.Checked
        My.Settings.Save()
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Application.Exit()
    End Sub
#End Region
    Private Sub dgvRecords_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles dgCal.CellBeginEdit
        originalValue = dgCal.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
        edited_ID = CInt(dgCal.Rows(e.RowIndex).Cells("ID").Value)
        Debug.WriteLine($"[{edited_ID}] Original Cell Value: {originalValue.ToString()}")
    End Sub

    Private Sub dgvRecords_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgCal.CellEndEdit
        Dim editedValue = dgCal.Rows(e.RowIndex).Cells(e.ColumnIndex).Value

        If Not Object.Equals(originalValue, editedValue) Then
            Dim record As Record = dgCal.Rows(e.RowIndex).DataBoundItem
            UpdateRecord(record)
        End If
    End Sub


    Private Sub MainForm_Load(sender As Object, e As EventArgs, c As C) Handles MyBase.Load
        ' Load settings
        My.Settings.Reload()
        mnuDisplaySaturdays.Checked = My.Settings.mnuDisplaySaturdays
        mnuDisplaySundays.Checked = My.Settings.mnuDisplaySundays
        HourStart.DataBindings.Add("Value", My.Settings, "HourStart", False, DataSourceUpdateMode.OnPropertyChanged)
        HourEnd.DataBindings.Add("Value", My.Settings, "HourEnd", False, DataSourceUpdateMode.OnPropertyChanged)
        MinuteStart.DataBindings.Add("Value", My.Settings, "MinuteStart", DataSourceUpdateMode.OnPropertyChanged)
        MinuteEnd.DataBindings.Add("Value", My.Settings, "MinuteEnd", DataSourceUpdateMode.OnPropertyChanged)
        dtp.DataBindings.Add("Value", My.Settings, "dtpValue", DataSourceUpdateMode.OnPropertyChanged)
        ' Check for updates
        Try
            dtp.Value = My.Settings.dtpValue
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            Try
                dtp.Value = Now
            Catch exChange As Exception

            End Try
        End Try

        dtp.Format = DateTimePickerFormat.Custom
        dtp.CustomFormat = c.DateFormat
        ' Set the DateTimePicker to today's date and time

        lbl_status.Text = $"Database: {My.Settings.ConnectionString}"
    End Sub
    Private Sub UpdateCalendar()
        Debug.WriteLine($"UpdateCalendar, displaySAT: {mnuDisplaySaturdays.Checked}, Sun: {mnuDisplaySundays.Checked}")
        ' store the selected item so it will selected again after cleraning the rows
        dgCal.Rows.Clear()
        Dim sDate As String = dtp.Value.ToString(C.DateFormat)
        Dim Month As Integer = dtp.Value.Month
        Dim Year As Integer = dtp.Value.Year
        Dim FirstDay As New DateTime(Year, Month, 1)
        Dim LastDay As New DateTime(Year, Month, DateTime.DaysInMonth(Year, Month))
        Dim curDate As DateTime = FirstDay
        While curDate <= LastDay
            Dim WillAddRow As Boolean = True
            If curDate.DayOfWeek = DayOfWeek.Saturday AndAlso Not mnuDisplaySaturdays.Checked Then WillAddRow = False
            If curDate.DayOfWeek = DayOfWeek.Sunday AndAlso Not mnuDisplaySundays.Checked Then WillAddRow = False
            If WillAddRow Then dgCal.Rows.Add(curDate.ToString(DateFormat), curDate.DayOfWeek.ToString)
            curDate = curDate.AddDays(1)
        End While
        c.ViewingMonth = dtp.Value.ToString("yyyy.MM")
    End Sub
    Private Sub PopulateData()
        dgCal.Rows.Clear()
        For Each row As DataGridViewRow In dgCal.Rows
            Dim RowDate As DateTime = row.Cells("clnDate").Value
            ' check if weekends
            If RowDate.DayOfWeek = DayOfWeek.Saturday Then

            End If
            If RowDate.DayOfWeek = DayOfWeek.Saturday Or RowDate.DayOfWeek = DayOfWeek.Sunday Then
                row.DefaultCellStyle.BackColor = Color.Red
            End If
        Next
        If dgCal.Rows.Count > 0 Then
            If dgCal.SelectedRows.Count = 0 Then
                dgCal.Rows(0).Selected = True
            End If
        End If
    End Sub

    Private Sub dgvCalendar_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgCal.CellClick
        If dgCal.Rows.Count > 0 Then
            Dim row As DataGridViewRow = dgCal.SelectedRows(0)
            Dim strDate = Convert.ToDateTime(row.Cells("clnDate").Value).ToString("dddd, dd MMMM yyyy")

            lblSelectedDay.Text = $"Add Records to: {strDate}"
            lblSelectedDay.BackColor = row.DefaultCellStyle.BackColor
        End If

    End Sub

    Private Sub dtp_ValueChanged(sender As Object, e As EventArgs) Handles dtp.ValueChanged
        If dtp.Value.ToString("yyyy.MM") <> c.ViewingMonth Then UpdateCalendar()
    End Sub

    Private Sub Insert_Controls(sender As NumericUpDown, e As EventArgs) Handles HourStart.ValueChanged,
        HourEnd.ValueChanged, MinuteStart.ValueChanged, MinuteEnd.ValueChanged,
        HourStart.KeyUp, HourEnd.KeyUp, MinuteStart.KeyUp, MinuteEnd.KeyUp
        Dim duration As Integer = CalculateDuration()

        'Start: 08:00 End: 09:30 duration 1 Hour 30 Minutes
        InsertConfirmLabel.Text = $"Start: {HourStart.Value}:{MinuteStart.Value} End: {HourEnd.Value}:{MinuteEnd.Value} Duration {FormatTimeDifference(duration)}"
    End Sub

    Private Function CalculateDuration() As Integer
        Dim timespan As New TimeSpan()
        ' Create DateTime objects for start and end times
        Dim startTime As New DateTime(1, 1, 1, HourStart.Value, MinuteStart.Value, 0)
        Dim endTime As New DateTime(1, 1, 1, HourEnd.Value, MinuteEnd.Value, 0)
        ' Calculate the time difference
        Dim timeDifference As TimeSpan = endTime - startTime
        Dim TotalMinutes As Integer = timeDifference.TotalMinutes
        Debug.WriteLine($"[startTime]: {startTime} [endTime]: {endTime} [timeDifference]: {timeDifference}")
        Dim strTimeDifference As String = FormatTimeDifference(TotalMinutes)

        Return TotalMinutes
    End Function

    Private Sub AddRecordbtn_Click(sender As Object, e As EventArgs) Handles AddRecordbtn.Click
        Dim r As New Record()
        With r
            .User = 2
            .tsStart = Nothing
            .tsEnd = Nothing
            .Duration = CalculateDuration()
            '.Timestamp = dgv
        End With
    End Sub

    Private Sub dgvCalendar_CellContentClick(sender As Object, e As EventArgs) Handles dgCal.SelectionChanged, dgCal.KeyUp
        If dgCal.SelectedRows.Count > 0 Then
            Dim Rows As List(Of Record) = GetDayRecord(dgCal.SelectedRows(0).Cells("clnDate").Value)
            dgRec.DataSource = Rows
            dgRec.Columns("ID").Visible = False
            dgRec.Columns("User").Visible = False
            Debug.WriteLine($"dgvCalendar_CellContentClick: {dgCal.SelectedRows.Count} - Rows returned from GetDayRecord: {Rows.Count}")
        End If
    End Sub


    Private Sub OpenDatabaeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenDatabaeToolStripMenuItem.Click
        PopulateData()
        ofd.Multiselect = False
        ofd.ShowDialog()

        If IO.File.Exists(ofd.FileName) Then
            My.Settings.ConnectionString = ofd.FileName
            lbl_status.Text = $"Database: {My.Settings.ConnectionString}"
            ofd.FileName = My.Settings.ConnectionString

            My.Settings.ConnectionString = ofd.FileName
        Else
            MsgBox("Error wrong file", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub TestToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TestToolStripMenuItem.Click
        Dim TargetDate As String = "2024.03.10"
        Dim Rows As New List(Of Record)
        TargetDate = DateTime.ParseExact(TargetDate, DateFormat, CultureInfo.InvariantCulture).ToString(DateFormat)
        Debug.WriteLine($"GetDayRecord - TargetDate: {TargetDate}")
        Try
            C.Connection(True)

            Dim query As String = "SELECT * FROM record WHERE DayDate LIKE @TargetDate"

            Dim command As New SQLiteCommand(query, C.connection)
            command.Parameters.AddWithValue("@TargetDate", TargetDate)
            Dim r As SQLiteDataReader = command.ExecuteReader()
            Debug.WriteLine($"GetDayRecord - Query: {query}")
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
                Debug.WriteLine($"GetDayRecord: r.HasRows: {r.HasRows}")
            End If

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            C.Connection(False)
        End Try
    End Sub
End Class
