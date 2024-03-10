Imports System.Data.SQLite
Imports System.Globalization
Imports System.Reflection

Public Class MainForm
    Private EditedOriginalValue As Object
    Private EditedID As Integer
    Dim ModRec As New Record

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




    Private Sub MakeBindings()

        My.Settings.Reload()
        mnuDisplaySaturdays.Checked = My.Settings.mnuDisplaySaturdays
        mnuDisplaySundays.Checked = My.Settings.mnuDisplaySundays
        HourStart.DataBindings.Add("Value", My.Settings, "HourStart", False, DataSourceUpdateMode.OnPropertyChanged)
        HourEnd.DataBindings.Add("Value", My.Settings, "HourEnd", False, DataSourceUpdateMode.OnPropertyChanged)
        MinuteStart.DataBindings.Add("Value", My.Settings, "MinuteStart", DataSourceUpdateMode.OnPropertyChanged)
        MinuteEnd.DataBindings.Add("Value", My.Settings, "MinuteEnd", DataSourceUpdateMode.OnPropertyChanged)
        dtp.DataBindings.Add("Value", My.Settings, "dtpValue", DataSourceUpdateMode.OnPropertyChanged)
        dgRec.DataSource = New List(Of Record)
    End Sub
    Private Sub CheckForUpdates()

    End Sub
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        MakeBindings() ' Load settings and Make Bindings
        CheckForUpdates() ' Check for updates
        dgRec.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
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
        dtp.CustomFormat = DateFormat
        ' Set the DateTimePicker to today's date and time

        lbl_status.Text = $"Database: {My.Settings.ConnectionString}"
    End Sub
    Private Sub UpdateCalendar()
        ' store the selected item so it will selected again after cleraning the rows
        dgCal.Rows.Clear()
        Dim sDate As String = dtp.Value.ToString(DateFormat)
        Dim Month As Integer = dtp.Value.Month
        Dim Year As Integer = dtp.Value.Year
        Dim FirstDay As New DateTime(Year, Month, 1)
        Dim LastDay As New DateTime(Year, Month, DateTime.DaysInMonth(Year, Month))
        Dim curDate As DateTime = FirstDay
        While curDate <= LastDay
            Dim WillAddRow As Boolean = True
            If curDate.Date.DayOfWeek = DayOfWeek.Saturday AndAlso Not mnuDisplaySaturdays.Checked Then WillAddRow = False
            If curDate.DayOfWeek = DayOfWeek.Sunday AndAlso Not mnuDisplaySundays.Checked Then WillAddRow = False
            If WillAddRow Then dgCal.Rows.Add(curDate.ToString(DateFormat), curDate.DayOfWeek.ToString)
            curDate = curDate.AddDays(1)
        End While
        ViewingMonth = dtp.Value.ToString("yyyy.MM")
        If dgCal.Rows.Count > 0 AndAlso dgCal.SelectedRows.Count = 0 Then
            dgCal.Rows(0).Selected = True
        End If
    End Sub

    Private Sub dgCal_Events(sender As Object, e As EventArgs) Handles dgCal.Click, dgCal.KeyUp, dgCal.SelectionChanged
        If dgCal.SelectedRows.Count > 0 AndAlso dgCal.SelectedRows.Count > 0 Then
            Dim row As DataGridViewRow = dgCal.SelectedRows(0)
            Dim strDate = Convert.ToDateTime(row.Cells("clnDate").Value).ToString("dddd, dd MMMM yyyy")

            lblSelectedDay.Text = $"Add Records to: {strDate}"
            lblSelectedDay.BackColor = row.DefaultCellStyle.BackColor

            Dim curDate As String = dgCal.SelectedRows(0).Cells("clnDate").Value
            Dim dt As DateTime = DateTime.ParseExact(curDate, DateFormat, CultureInfo.InvariantCulture)
            Dim Rows As List(Of Record) = GetDayRecord(dt)
            ShowRecordsInDgRec(Rows)


        End If
    End Sub
    Private Sub dtp_ValueChanged(sender As Object, e As EventArgs) Handles dtp.ValueChanged
        If dtp.Value.ToString("yyyy.MM") <> ViewingMonth Then UpdateCalendar()
    End Sub

    Private Sub Insert_Controls(sender As NumericUpDown, e As EventArgs) Handles HourStart.ValueChanged,
        HourEnd.ValueChanged, MinuteStart.ValueChanged, MinuteEnd.ValueChanged,
        HourStart.KeyUp, HourEnd.KeyUp, MinuteStart.KeyUp, MinuteEnd.KeyUp

    End Sub

    Private Sub AddRecordbtn_Click(sender As Object, e As EventArgs) Handles AddRecordbtn.Click
        If dgCal.SelectedRows.Count > 0 Then
            Dim F As New AddForm
            F.Usertxt.Text = uid
            F.Startstxt.Text = dgCal.SelectedRows(0).Cells("clnDate").Value
            F.ShowDialog()
        End If

        Return
        If dgCal.SelectedRows.Count > 0 Then
            Dim r As New Record()
            With r
                .User = uid ' Developer
                Dim c As DateTime = DateTime.ParseExact(dgCal.SelectedRows(0).Cells("clnDate").Value, DateFormat, CultureInfo.InvariantCulture)
                .Starts = New DateTime(c.Year, c.Month, c.Day, HourStart.Value, HourEnd.Value, 0)
                .Ends = New DateTime(c.Year, c.Month, c.Day, HourEnd.Value, MinuteEnd.Value, 0)
                Dim duration As Integer = (.Ends - .Starts).TotalMinutes

                ''Start: 08:00 End: 09:30 duration 1 Hour 30 Minutes
                InsertConfirmLabel.Text = $"Start: {HourStart.Value}:{MinuteStart.Value} End: {HourEnd.Value}:{MinuteEnd.Value} Duration {FormatTimeDifference(duration)}"

            End With
            InsertRecord(r)
        End If

    End Sub
#Region "Menu"
    Private Sub OpenDatabaeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenDatabaeToolStripMenuItem.Click
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
        dgRec.Rows(0).Cells(4).Value = "11:12"

    End Sub

#End Region

#Region "DG-RECORD"
    Private Sub ShowRecordsInDgRec(records As List(Of Record))
        dgRec.DataSource = Nothing
        dgRec.Columns.Clear()
        If records.Count > 0 Then
            ' Add columns for each property in the Record class
            For Each propInfo In records(0).GetType().GetProperties()
                Dim column As New DataGridViewColumn()
                column.HeaderText = propInfo.Name
                column.DataPropertyName = propInfo.Name
                dgRec.Columns.Add(column)

                ' Set the DefaultCellStyle for each column
                'column.DefaultCellStyle.Format = "N2" ' You can change this format to your desired format
                'column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            Next

            ' Set the DataSource to the list of records
            'dgRec.DataSource = records

            ' Auto-size the columns to fit their content
            dgRec.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells)
        End If

    End Sub
    'Private Sub dgRec_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgRec.CellEndEdit
    '    dgRec.UpdateCellValue(e.ColumnIndex, e.RowIndex)
    '    Debug.WriteLine(ModRec.Started)

    'End Sub
    Private Sub dgRec_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgRec.CellValueChanged
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim rowIndex As Integer = e.RowIndex
            Dim colIndex As Integer = e.ColumnIndex
            Dim modifiedValue As Object = dgRec.Rows(rowIndex).Cells(colIndex).Value

            Debug.WriteLine("Row {0}, Column {1} value changed to: {2}", rowIndex, colIndex, modifiedValue)
        End If
    End Sub

    Private Sub Insert_Controls(sender As Object, e As EventArgs) Handles MinuteStart.ValueChanged, MinuteStart.KeyUp, MinuteEnd.ValueChanged, MinuteEnd.KeyUp, HourStart.ValueChanged, HourStart.KeyUp, HourEnd.ValueChanged, HourEnd.KeyUp, NumericUpDown4.ValueChanged, NumericUpDown4.KeyUp, NumericUpDown3.ValueChanged, NumericUpDown3.KeyUp, NumericUpDown2.ValueChanged, NumericUpDown2.KeyUp, NumericUpDown1.ValueChanged, NumericUpDown1.KeyUp

    End Sub

    Private Sub Insert_Controls(sender As Object, e As KeyEventArgs)

    End Sub
    'Private Sub dgRec_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgRec.CellEndEdit
    '    ' Get the modified value from the edited cell
    '    dgRec.EndEdit()
    '    Dim modifiedValue As Object = dgRec.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
    '    MsgBox(modifiedValue)
    '    ' Now you can use the modifiedValue as needed
    '    ' ...

    '    ' Example: Print the modified value to the Debug output
    '    Debug.WriteLine($"Modified Value: {modifiedValue}")
    '    Return
    '    Dim editedValue = dgRec.Rows(e.RowIndex).Cells(e.ColumnIndex).Value

    '    ' Check if the value has changed
    '    ' Update the underlying data source
    '    Dim record As Record = dgRec.Rows(e.RowIndex).DataBoundItem
    '    Debug.WriteLine($"Starts: {record.Starts} ")
    '    Return
    '    Dim Row As New DataGridViewRow
    '    Row = dgRec.Rows(e.RowIndex)
    '    'Dim record As New Record
    '    record.ID = Row.Cells("ID").Value
    '    record.User = uid
    '    Debug.WriteLine($"Started: {Row.Cells("Started").Value}")
    '    Debug.WriteLine($"Started: {dgRec.Rows(e.RowIndex).Cells(e.ColumnIndex).Value}")

    '    Return
    '    Dim dtStarted As DateTime = Date.ParseExact(Row.Cells("Started").Value, TimeFormat, CultureInfo.InvariantCulture)
    '    Dim dtEnded As DateTime = Date.ParseExact(Row.Cells("Ended").Value, TimeFormat, CultureInfo.InvariantCulture)

    '    Dim dtStarts As New DateTime
    '    dtStarts = Date.ParseExact(Row.Cells("Starts").Value, dbFormat, CultureInfo.InvariantCulture)
    '    Dim dtEnds As DateTime = Date.ParseExact(Row.Cells("Ends").Value, dbFormat, CultureInfo.InvariantCulture)




    '    With dtStarts
    '        record.Starts = New Date(.Year, .Month, .Day, dtStarted.Hour, dtStarted.Minute, 0)
    '    End With
    '    With dtEnds
    '        record.Ends = New Date(.Year, .Month, .Day, dtEnded.Hour, dtEnded.Minute, 0)
    '    End With

    '    Dim msg As String = "After - "

    '    For i As Integer = 0 To Row.Cells.Count - 1
    '        msg &= "[" & i & "] " & Row.Cells(i).OwningColumn.Name & ": " & Row.Cells(i).Value & " "
    '    Next
    '    Debug.WriteLine(msg)
    '    UpdateRecord(record)
    'End Sub

#End Region

End Class
