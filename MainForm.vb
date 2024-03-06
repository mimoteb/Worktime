Public Class MainForm
    Public c As New C
    Private originalValue As Object
    Private edited_ID As Integer
    Private var_year As Integer = 2024
    Private var_month As Integer = 4
    ' Declare DateTimePicker1 with WithEvents
    ' Hello from VS
    Private Sub dgvRecords_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles dgvCalendar.CellBeginEdit
        originalValue = dgvCalendar.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
        edited_ID = CInt(dgvCalendar.Rows(e.RowIndex).Cells("ID").Value)
        Debug.WriteLine($"[{edited_ID}] Original Cell Value: {originalValue.ToString()}")
    End Sub

    Private Sub dgvRecords_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCalendar.CellEndEdit
        Dim editedValue = dgvCalendar.Rows(e.RowIndex).Cells(e.ColumnIndex).Value

        If Not Object.Equals(originalValue, editedValue) Then
            Dim record As Record = dgvCalendar.Rows(e.RowIndex).DataBoundItem
            UpdateRecord(record)
        End If
    End Sub

    Private Sub btnOpenDatabase_Click(sender As Object, e As EventArgs) Handles btnOpenDatabase.Click
        PopulateData(btnOpenDatabase)
        ofd.Multiselect = False
        ofd.ShowDialog()

        If IO.File.Exists(ofd.FileName) Then
            My.Settings.db = ofd.FileName
            lbl_status.Text = $"Database: {My.Settings.db}"
            ofd.FileName = My.Settings.db

            My.Settings.db = ofd.FileName
        Else
            MsgBox("Error wrong file", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Data Bindings (Settings)
        HourStart.DataBindings.Add("Value", My.Settings, "HourStart", False, DataSourceUpdateMode.OnPropertyChanged)
        'HourEnd.DataBindings.Add("Value", My.Settings, "HourEnd", False, DataSourceUpdateMode.OnPropertyChanged)
        'MinuteStart.DataBindings.Add("Value", My.Settings, "MinuteStart", DataSourceUpdateMode.OnPropertyChanged)
        'MinuteEnd.DataBindings.Add("Value", My.Settings, "MinuteEnd", DataSourceUpdateMode.OnPropertyChanged)

        ofd.FileName = My.Settings.db
        dtp.Format = DateTimePickerFormat.Custom
        dtp.CustomFormat = DateFormat
        ' Set the DateTimePicker to today's date and time
        dtp.Value = DateTime.Now

        lbl_status.Text = $"Database: {My.Settings.db}"
    End Sub
    Private Sub PopulateData(sender As Control)

        dgvCalendar.Rows.Clear()
        Dim Month As Integer = dtp.Value.Month
        Dim Year As Integer = dtp.Value.Year
        Debug.WriteLine($"[PopulateData] - Year: {Year} Month: {Month} Selected dgvCalendar rows count: {dgvCalendar.SelectedRows.Count}")
        Dim firstDayOfMonth As New DateTime(Year, Month, 1)
        Dim lastDayOfMonth As New DateTime(Year, Month, DateTime.DaysInMonth(Year, Month))
        Dim currentDate As DateTime = firstDayOfMonth

        While currentDate <= lastDayOfMonth
            dgvCalendar.Rows.Add(currentDate.ToString("dd.MM.yyyy"), currentDate.DayOfWeek.ToString)
            Dim DayofWeek As String = currentDate.DayOfWeek.ToString
            If DayofWeek = Day.Saturday.ToString Or DayofWeek = Day.Sunday.ToString Then
                Dim lastRow As Integer = dgvCalendar.Rows.Count - 1
                dgvCalendar.Rows(lastRow).DefaultCellStyle.BackColor = Color.Red
            End If
            currentDate = currentDate.AddDays(1)
        End While
        For Each row As DataGridViewRow In dgvCalendar.Rows
            Dim RowDate As DateTime = row.Cells("clnDate").Value
            ' check if weekends
            If RowDate.DayOfWeek = DayOfWeek.Saturday Or RowDate.DayOfWeek = DayOfWeek.Sunday Then
                row.DefaultCellStyle.BackColor = Color.Red
            End If
        Next
        If dgvCalendar.Rows.Count > 0 Then
            If dgvCalendar.SelectedRows.Count = 0 Then
                dgvCalendar.Rows(0).Selected = True
            End If
        End If
        If dgvCalendar.SelectedRows.Count = 1 Then
            'Dim records As List(Of Record) = getmo(dtp.Value)

            'dgvRecords.Rows.Clear()
            'dgvRecords.DataSource = records

            'dgvRecords.Columns("startdatetime").HeaderText = "Start Time"
            'dgvRecords.Columns("Duration").HeaderText = "Duration (minutes)"
            'dgvRecords.Columns("User").HeaderText = "User ID"

            'dgvRecords.Columns("startdatetime").DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss"
            'dgvRecords.Columns("startdatetime").Width = 150
            'dgvRecords.Columns("Duration").Width = 100
            'dgvRecords.Columns("User").Width = 80

            'dgvRecords.Columns("startdatetime").SortMode = DataGridViewColumnSortMode.Automatic
            'dgvRecords.Columns("Duration").SortMode = DataGridViewColumnSortMode.Automatic
            'dgvRecords.Columns("User").SortMode = DataGridViewColumnSortMode.Automatic
        End If

    End Sub

    Private Sub dgvCalendar_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCalendar.CellClick
        If dgvCalendar.Rows.Count > 0 Then
            Dim row As DataGridViewRow = dgvCalendar.SelectedRows(0)
            Dim strDate = Convert.ToDateTime(row.Cells("clnDate").Value).ToString("dddd, dd MMMM yyyy")

            lblSelectedDay.Text = $"Add Records to: {strDate}"
            lblSelectedDay.BackColor = row.DefaultCellStyle.BackColor
        End If

    End Sub

    Private Sub dtp_ValueChanged(sender As Object, e As EventArgs) Handles dtp.ValueChanged
        PopulateData(dtp)
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
            .Duration = CalculateDuration()
            '.Timestamp = dgv
        End With
    End Sub

    Private Sub dgvCalendar_CellContentClick(sender As Object, e As EventArgs) Handles dgvCalendar.SelectionChanged, dgvCalendar.KeyUp
        If dgvCalendar.SelectedRows.Count > 0 Then
            Dim records As List(Of Record) = GetDayRecord(dtp.Value.ToString(DateFormat))
            dgvRecords.DataSource = records
            dgvRecords.Columns("ID").Visible = False
            dgvRecords.Columns("User").Visible = False
        End If
    End Sub


End Class
