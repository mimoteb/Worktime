﻿Imports System.Data.SQLite
Imports System.Globalization

Public Class MainForm
    Private EditedOriginalValue As Object
    Private EditedID As Integer
    Private EditedRow As New DataGridViewRow

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
    End Sub
    Private Sub CheckForUpdates()

    End Sub
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MakeBindings() ' Load settings and Make Bindings
        CheckForUpdates() ' Check for updates

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
            dgRec.DataSource = Rows
            dgRec.Columns("ID").Visible = False
            dgRec.Columns("User").Visible = False
            dgRec.Columns("Ends").Visible = False
            dgRec.Columns("Starts").Visible = False
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
            Dim r As New Record()
            With r
                .User = uid ' Developer
                Dim c As DateTime = DateTime.ParseExact(dgCal.SelectedRows(0).Cells("clnDate").Value, DateFormat, CultureInfo.InvariantCulture)
                .starts = New DateTime(c.Year, c.Month, c.Day, HourStart.Value, HourEnd.Value, 0)
                .ends = New DateTime(c.Year, c.Month, c.Day, HourEnd.Value, MinuteEnd.Value, 0)
                Dim duration As Integer = (.ends - .starts).TotalMinutes

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
        Dim Rows As New List(Of Record)
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
                    .Starts = r.GetDateTime(r.GetOrdinal("starts"))
                    .Ends = r.GetDateTime(r.GetOrdinal("ends"))
                End With
                Rows.Add(rec)
            End While
        End If
        dgRec.DataSource = Rows

    End Sub

#End Region

#Region "DG-RECORD"
    Private Sub dgRec_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgRec.CellFormatting
        If e.ColumnIndex >= 0 AndAlso e.RowIndex >= 0 Then
            Dim columnName As String = dgRec.Columns(e.ColumnIndex).Name

            If columnName = "Starts" OrElse columnName = "Ends" Then
                ' Check if the cell value is a DateTime
                If TypeOf e.Value Is DateTime Then
                    ' Format the DateTime value
                    e.Value = DirectCast(e.Value, DateTime).ToString(dbFormat)
                    e.FormattingApplied = True
                End If
            End If
        End If
    End Sub
    Private Sub dgRec_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles dgRec.CellBeginEdit
        EditedRow = dgRec.Rows(e.RowIndex)
        EditedOriginalValue = dgRec.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
        EditedID = CInt(dgRec.Rows(e.RowIndex).Cells("ID").Value)
        Debug.WriteLine($"[{EditedID}] Original Cell Value: {EditedOriginalValue.ToString()}")
        For i As Integer = 0 To EditedRow.Cells.Count - 1
            Debug.WriteLine($"[{i}]Row-{EditedRow.Cells(i).OwningColumn.Name} : {EditedRow.Cells(i).Value}")
        Next

    End Sub
    Private Sub dgRec_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgRec.CellEndEdit
        Debug.WriteLine($"Before: {EditedRow.Cells(e.ColumnIndex).Value}")
        EditedRow.Cells(e.ColumnIndex).Value = dgCal.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
        Debug.WriteLine($"After: {EditedRow.Cells(e.ColumnIndex).Value}")
        'Dim editedValue = dgRec.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
        'Debug.WriteLine($"[{EditedID}] editedValue: {editedValue}")
        'If Not Object.Equals(EditedOriginalValue, editedValue) Then
        '    Dim record As Record = dgRec.Rows(e.RowIndex).DataBoundItem

        '    UpdateRecord(record)
        'End If
    End Sub
#End Region

End Class
