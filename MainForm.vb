﻿Imports System.Data.Entity.Infrastructure.Interception
Imports io
Public Class MainForm
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
        PopulateDataGridView()
        'ofd.Multiselect = False
        'ofd.ShowDialog()

        'If IO.File.Exists(ofd.FileName) Then
        '    DatabaseFileName = ofd.FileName
        '    lbl_status.Text = $"Database: {DatabaseFileName}"
        '    ofd.FileName = DatabaseFileName

        '    InsertRecord(Date.Now, 1, 1)
        '    LoadDataGridView()
        '    My.Settings.db = ofd.FileName
        'Else
        '    MsgBox("Error wrong file", MsgBoxStyle.Critical)
        'End If
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ofd.FileName = My.Settings.db
        dtp.Format = DateTimePickerFormat.Custom
        dtp.CustomFormat = "MMMM yyyy"
        ' Set the DateTimePicker to today's date and time
        dtp.Value = DateTime.Now

        lbl_status.Text = $"Database: {My.Settings.db}"
    End Sub


    Private Sub dtp_ValueChanged(sender As Object, e As EventArgs) Handles dtp.Click
        PopulateDataGridView()
    End Sub

    Private Sub LoadDataGridView()
        Dim records As List(Of Record) = GetAllRecords()

        dgvCalendar.Rows.Clear()
        dgvCalendar.DataSource = records

        dgvCalendar.Columns("startdatetime").HeaderText = "Start Time"
        dgvCalendar.Columns("Duration").HeaderText = "Duration (minutes)"
        dgvCalendar.Columns("User").HeaderText = "User ID"

        dgvCalendar.Columns("startdatetime").DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss"
        dgvCalendar.Columns("startdatetime").Width = 150
        dgvCalendar.Columns("Duration").Width = 100
        dgvCalendar.Columns("User").Width = 80

        dgvCalendar.Columns("startdatetime").SortMode = DataGridViewColumnSortMode.Automatic
        dgvCalendar.Columns("Duration").SortMode = DataGridViewColumnSortMode.Automatic
        dgvCalendar.Columns("User").SortMode = DataGridViewColumnSortMode.Automatic
    End Sub
    Private Sub PopulateDataGridView()
        dgvCalendar.Rows.Clear()
        Debug.WriteLine("PopulateDataGridView() was called")
        Dim Month As Integer = dtp.Value.Month
        Dim Year As Integer = dtp.Value.Year


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
    End Sub


End Class
