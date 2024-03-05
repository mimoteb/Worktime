﻿Imports io
Public Class MainForm
    Private originalValue As Object
    Private edited_ID As Integer
    Private var_year As Integer = 2024
    Private var_month As Integer = 4
    ' Declare DateTimePicker1 with WithEvents
    ' Hello from VS
    Private Sub dgvRecords_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles dgvRecords.CellBeginEdit
        originalValue = dgvRecords.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
        edited_ID = CInt(dgvRecords.Rows(e.RowIndex).Cells("ID").Value)
        Debug.WriteLine($"[{edited_ID}] Original Cell Value: {originalValue.ToString()}")
    End Sub

    Private Sub dgvRecords_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRecords.CellEndEdit
        Dim editedValue = dgvRecords.Rows(e.RowIndex).Cells(e.ColumnIndex).Value

        If Not Object.Equals(originalValue, editedValue) Then
            Dim record As Record = dgvRecords.Rows(e.RowIndex).DataBoundItem
            UpdateRecord(record)
        End If
    End Sub

    Private Sub btnOpenDatabase_Click(sender As Object, e As EventArgs) Handles btnOpenDatabase.Click
        ofd.Multiselect = False
        ofd.ShowDialog()

        If IO.File.Exists(ofd.FileName) Then
            DatabaseFileName = ofd.FileName
            lbl_status.Text = $"Database: {DatabaseFileName}"
            ofd.FileName = DatabaseFileName

            InsertRecord(Date.Now, 1, 1)
            LoadDataGridView()
            My.Settings.db = ofd.FileName
        Else
            MsgBox("Error wrong file", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ofd.FileName = My.Settings.db
        dtp.Format = DateTimePickerFormat.Custom
        dtp.CustomFormat = "MMMM yyyy"
        ' Set the DateTimePicker to today's date and time
        dtp.Value = DateTime.Now
        PopulateDataGridView()
        lbl_status.Text = $"Database: {My.Settings.db}"
    End Sub


    Private Sub dtp_ValueChanged(sender As Object, e As EventArgs) Handles dtp.ValueChanged
        Dim selectedMonth As Integer = dtp.Value.Month
        Dim selectedYear As Integer = dtp.Value.Year
        PopulateDataGridView()
    End Sub

    Private Sub LoadDataGridView()
        Dim records As List(Of Record) = GetAllRecords()

        dgvRecords.Rows.Clear()
        dgvRecords.DataSource = records

        dgvRecords.Columns("startdatetime").HeaderText = "Start Time"
        dgvRecords.Columns("Duration").HeaderText = "Duration (minutes)"
        dgvRecords.Columns("User").HeaderText = "User ID"

        dgvRecords.Columns("startdatetime").DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss"
        dgvRecords.Columns("startdatetime").Width = 150
        dgvRecords.Columns("Duration").Width = 100
        dgvRecords.Columns("User").Width = 80

        dgvRecords.Columns("startdatetime").SortMode = DataGridViewColumnSortMode.Automatic
        dgvRecords.Columns("Duration").SortMode = DataGridViewColumnSortMode.Automatic
        dgvRecords.Columns("User").SortMode = DataGridViewColumnSortMode.Automatic
    End Sub
    Private Sub PopulateDataGridView()
        Dim Month As Integer = dtp.Value.Month
        Dim Year As Integer = dtp.Value.Year
        dgvRecords.Rows.Clear()

        Dim firstDayOfMonth As New DateTime(Year, Month, 1)
        Dim lastDayOfMonth As New DateTime(Year, Month, DateTime.DaysInMonth(Year, Month))
        Dim currentDate As DateTime = firstDayOfMonth

        While currentDate <= lastDayOfMonth
            dgvRecords.Rows.Add(0, currentDate, currentDate.DayOfWeek)

            If dgvRecords.Rows(dgvRecords.Rows.Count - 1).Cells("Day").Value = "Sunday" Then
                dgvRecords.Rows(dgvRecords.Rows.Count - 1).DefaultCellStyle.BackColor = Color.Red
            End If
            Dim lastRow As DataGridViewRow = dgvRecords.Rows(dgvRecords.Rows.Count - 1)

            currentDate = currentDate.AddDays(1)
        End While

    End Sub


End Class
