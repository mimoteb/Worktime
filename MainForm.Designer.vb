﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.dgCal = New System.Windows.Forms.DataGridView()
        Me.clnDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnDayName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnWorkedHours = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnWorkedHoursInSchool = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnMonthlyIncome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ofd = New System.Windows.Forms.OpenFileDialog()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Infolbl = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lbl_status = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.dgRec = New System.Windows.Forms.DataGridView()
        Me.lblSelectedDay = New System.Windows.Forms.Label()
        Me.dtp = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.AddRecordbtn = New System.Windows.Forms.Button()
        Me.MinuteEnd = New System.Windows.Forms.NumericUpDown()
        Me.HourEnd = New System.Windows.Forms.NumericUpDown()
        Me.MinuteStart = New System.Windows.Forms.NumericUpDown()
        Me.HourStart = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.InsertConfirmLabel = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.m = New System.Windows.Forms.MenuStrip()
        Me.TeacherLogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenDatabaeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCalc = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteCurrentWorkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDisplaySaturdays = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDisplaySundays = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.TestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown3 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDown4 = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        CType(Me.dgCal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.dgRec, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.MinuteEnd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HourEnd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MinuteStart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HourStart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.m.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgCal
        '
        Me.dgCal.AllowUserToAddRows = False
        Me.dgCal.AllowUserToDeleteRows = False
        Me.dgCal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgCal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCal.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clnDate, Me.clnDayName, Me.clnWorkedHours, Me.clnWorkedHoursInSchool, Me.clnMonthlyIncome})
        Me.dgCal.Location = New System.Drawing.Point(752, 29)
        Me.dgCal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgCal.MultiSelect = False
        Me.dgCal.Name = "dgCal"
        Me.dgCal.ReadOnly = True
        Me.dgCal.RowHeadersWidth = 45
        Me.dgCal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgCal.Size = New System.Drawing.Size(556, 625)
        Me.dgCal.TabIndex = 0
        '
        'clnDate
        '
        Me.clnDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.clnDate.HeaderText = "Date"
        Me.clnDate.MinimumWidth = 6
        Me.clnDate.Name = "clnDate"
        Me.clnDate.ReadOnly = True
        Me.clnDate.Width = 66
        '
        'clnDayName
        '
        Me.clnDayName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.clnDayName.HeaderText = "Day"
        Me.clnDayName.MinimumWidth = 6
        Me.clnDayName.Name = "clnDayName"
        Me.clnDayName.ReadOnly = True
        Me.clnDayName.Width = 60
        '
        'clnWorkedHours
        '
        Me.clnWorkedHours.HeaderText = "Worked Hours"
        Me.clnWorkedHours.MinimumWidth = 6
        Me.clnWorkedHours.Name = "clnWorkedHours"
        Me.clnWorkedHours.ReadOnly = True
        Me.clnWorkedHours.Width = 110
        '
        'clnWorkedHoursInSchool
        '
        Me.clnWorkedHoursInSchool.HeaderText = "Hours in School"
        Me.clnWorkedHoursInSchool.MinimumWidth = 6
        Me.clnWorkedHoursInSchool.Name = "clnWorkedHoursInSchool"
        Me.clnWorkedHoursInSchool.ReadOnly = True
        Me.clnWorkedHoursInSchool.Width = 110
        '
        'clnMonthlyIncome
        '
        Me.clnMonthlyIncome.HeaderText = "Monthly Income"
        Me.clnMonthlyIncome.MinimumWidth = 6
        Me.clnMonthlyIncome.Name = "clnMonthlyIncome"
        Me.clnMonthlyIncome.ReadOnly = True
        Me.clnMonthlyIncome.Width = 110
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(18, 1129)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 37)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(18, 18)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Infolbl, Me.lbl_status, Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 681)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 13, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1316, 22)
        Me.StatusStrip1.TabIndex = 6
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Infolbl
        '
        Me.Infolbl.Name = "Infolbl"
        Me.Infolbl.Size = New System.Drawing.Size(34, 17)
        Me.Infolbl.Text = "INFO"
        '
        'lbl_status
        '
        Me.lbl_status.Name = "lbl_status"
        Me.lbl_status.Size = New System.Drawing.Size(174, 17)
        Me.lbl_status.Text = "Database: No Datebase selected"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(119, 17)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'dgRec
        '
        Me.dgRec.AllowUserToAddRows = False
        Me.dgRec.AllowUserToDeleteRows = False
        Me.dgRec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgRec.Location = New System.Drawing.Point(13, 29)
        Me.dgRec.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgRec.MultiSelect = False
        Me.dgRec.Name = "dgRec"
        Me.dgRec.RowHeadersWidth = 45
        Me.dgRec.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgRec.Size = New System.Drawing.Size(731, 194)
        Me.dgRec.TabIndex = 7
        '
        'lblSelectedDay
        '
        Me.lblSelectedDay.AutoSize = True
        Me.lblSelectedDay.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectedDay.Location = New System.Drawing.Point(18, 23)
        Me.lblSelectedDay.Name = "lblSelectedDay"
        Me.lblSelectedDay.Size = New System.Drawing.Size(36, 20)
        Me.lblSelectedDay.TabIndex = 8
        Me.lblSelectedDay.Text = "Day"
        '
        'dtp
        '
        Me.dtp.Location = New System.Drawing.Point(13, 647)
        Me.dtp.Name = "dtp"
        Me.dtp.Size = New System.Drawing.Size(380, 27)
        Me.dtp.TabIndex = 10
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.AddRecordbtn)
        Me.GroupBox1.Controls.Add(Me.MinuteEnd)
        Me.GroupBox1.Controls.Add(Me.HourEnd)
        Me.GroupBox1.Controls.Add(Me.MinuteStart)
        Me.GroupBox1.Controls.Add(Me.HourStart)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.InsertConfirmLabel)
        Me.GroupBox1.Controls.Add(Me.lblSelectedDay)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 231)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(363, 180)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add Worktime"
        '
        'AddRecordbtn
        '
        Me.AddRecordbtn.Location = New System.Drawing.Point(5, 141)
        Me.AddRecordbtn.Name = "AddRecordbtn"
        Me.AddRecordbtn.Size = New System.Drawing.Size(174, 34)
        Me.AddRecordbtn.TabIndex = 17
        Me.AddRecordbtn.Text = "Add New Record"
        Me.AddRecordbtn.UseVisualStyleBackColor = True
        '
        'MinuteEnd
        '
        Me.MinuteEnd.Location = New System.Drawing.Point(253, 81)
        Me.MinuteEnd.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.MinuteEnd.Name = "MinuteEnd"
        Me.MinuteEnd.Size = New System.Drawing.Size(60, 27)
        Me.MinuteEnd.TabIndex = 16
        Me.MinuteEnd.Value = New Decimal(New Integer() {30, 0, 0, 0})
        '
        'HourEnd
        '
        Me.HourEnd.Location = New System.Drawing.Point(187, 81)
        Me.HourEnd.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.HourEnd.Name = "HourEnd"
        Me.HourEnd.Size = New System.Drawing.Size(60, 27)
        Me.HourEnd.TabIndex = 16
        Me.HourEnd.Value = New Decimal(New Integer() {9, 0, 0, 0})
        '
        'MinuteStart
        '
        Me.MinuteStart.Location = New System.Drawing.Point(88, 81)
        Me.MinuteStart.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.MinuteStart.Name = "MinuteStart"
        Me.MinuteStart.Size = New System.Drawing.Size(60, 27)
        Me.MinuteStart.TabIndex = 16
        '
        'HourStart
        '
        Me.HourStart.Location = New System.Drawing.Point(22, 81)
        Me.HourStart.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.HourStart.Name = "HourStart"
        Me.HourStart.Size = New System.Drawing.Size(60, 27)
        Me.HourStart.TabIndex = 16
        Me.HourStart.Value = Global.Worktime.My.MySettings.Default.HourStart
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(183, 58)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 20)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Work end time"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(154, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 20)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "To"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 20)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Work Start time"
        '
        'InsertConfirmLabel
        '
        Me.InsertConfirmLabel.AutoSize = True
        Me.InsertConfirmLabel.Location = New System.Drawing.Point(18, 110)
        Me.InsertConfirmLabel.Name = "InsertConfirmLabel"
        Me.InsertConfirmLabel.Size = New System.Drawing.Size(338, 20)
        Me.InsertConfirmLabel.TabIndex = 12
        Me.InsertConfirmLabel.Text = "Start: 08:00 End: 09:30 duration 1 Hour 30 Minutes"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 431)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(363, 210)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Statistics"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(5, 107)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 20)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Income:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(5, 69)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(142, 20)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Total working hours:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Hours spent in School:"
        '
        'm
        '
        Me.m.ImageScalingSize = New System.Drawing.Size(18, 18)
        Me.m.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TeacherLogToolStripMenuItem, Me.SettingsToolStripMenuItem, Me.HelpToolStripMenuItem, Me.TestToolStripMenuItem})
        Me.m.Location = New System.Drawing.Point(0, 0)
        Me.m.Name = "m"
        Me.m.Size = New System.Drawing.Size(1316, 24)
        Me.m.TabIndex = 15
        Me.m.Text = "MenuStrip1"
        '
        'TeacherLogToolStripMenuItem
        '
        Me.TeacherLogToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenDatabaeToolStripMenuItem, Me.mnuCalc, Me.mnuExit})
        Me.TeacherLogToolStripMenuItem.Name = "TeacherLogToolStripMenuItem"
        Me.TeacherLogToolStripMenuItem.Size = New System.Drawing.Size(80, 20)
        Me.TeacherLogToolStripMenuItem.Text = "Application"
        '
        'OpenDatabaeToolStripMenuItem
        '
        Me.OpenDatabaeToolStripMenuItem.Name = "OpenDatabaeToolStripMenuItem"
        Me.OpenDatabaeToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.OpenDatabaeToolStripMenuItem.Text = "Open Database"
        '
        'mnuCalc
        '
        Me.mnuCalc.Name = "mnuCalc"
        Me.mnuCalc.Size = New System.Drawing.Size(160, 22)
        Me.mnuCalc.Text = "Open Calculator"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(160, 22)
        Me.mnuExit.Text = "Exit"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteCurrentWorkToolStripMenuItem, Me.mnuDisplaySaturdays, Me.mnuDisplaySundays})
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.SettingsToolStripMenuItem.Text = "Functions"
        '
        'DeleteCurrentWorkToolStripMenuItem
        '
        Me.DeleteCurrentWorkToolStripMenuItem.Name = "DeleteCurrentWorkToolStripMenuItem"
        Me.DeleteCurrentWorkToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.DeleteCurrentWorkToolStripMenuItem.Text = "Delete Current Work"
        '
        'mnuDisplaySaturdays
        '
        Me.mnuDisplaySaturdays.Name = "mnuDisplaySaturdays"
        Me.mnuDisplaySaturdays.Size = New System.Drawing.Size(181, 22)
        Me.mnuDisplaySaturdays.Text = "Show Saturdays"
        '
        'mnuDisplaySundays
        '
        Me.mnuDisplaySundays.Name = "mnuDisplaySundays"
        Me.mnuDisplaySundays.Size = New System.Drawing.Size(181, 22)
        Me.mnuDisplaySundays.Text = "Show Sundays"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAbout})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'mnuAbout
        '
        Me.mnuAbout.Name = "mnuAbout"
        Me.mnuAbout.Size = New System.Drawing.Size(107, 22)
        Me.mnuAbout.Text = "About"
        '
        'TestToolStripMenuItem
        '
        Me.TestToolStripMenuItem.Name = "TestToolStripMenuItem"
        Me.TestToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.TestToolStripMenuItem.Text = "Test"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.NumericUpDown1)
        Me.GroupBox3.Controls.Add(Me.NumericUpDown2)
        Me.GroupBox3.Controls.Add(Me.NumericUpDown3)
        Me.GroupBox3.Controls.Add(Me.NumericUpDown4)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Location = New System.Drawing.Point(382, 231)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(363, 180)
        Me.GroupBox3.TabIndex = 12
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Update Selected Item"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(5, 141)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(174, 34)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Add New Record"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(253, 81)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(60, 27)
        Me.NumericUpDown1.TabIndex = 16
        Me.NumericUpDown1.Value = New Decimal(New Integer() {30, 0, 0, 0})
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.Location = New System.Drawing.Point(187, 81)
        Me.NumericUpDown2.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(60, 27)
        Me.NumericUpDown2.TabIndex = 16
        Me.NumericUpDown2.Value = New Decimal(New Integer() {9, 0, 0, 0})
        '
        'NumericUpDown3
        '
        Me.NumericUpDown3.Location = New System.Drawing.Point(88, 81)
        Me.NumericUpDown3.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.NumericUpDown3.Name = "NumericUpDown3"
        Me.NumericUpDown3.Size = New System.Drawing.Size(60, 27)
        Me.NumericUpDown3.TabIndex = 16
        '
        'NumericUpDown4
        '
        Me.NumericUpDown4.Location = New System.Drawing.Point(22, 81)
        Me.NumericUpDown4.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.NumericUpDown4.Name = "NumericUpDown4"
        Me.NumericUpDown4.Size = New System.Drawing.Size(60, 27)
        Me.NumericUpDown4.TabIndex = 16
        Me.NumericUpDown4.Value = Global.Worktime.My.MySettings.Default.HourStart
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(183, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 20)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Work end time"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(154, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(25, 20)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "To"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(18, 58)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(112, 20)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Work Start time"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(18, 110)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(338, 20)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Start: 08:00 End: 09:30 duration 1 Hour 30 Minutes"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(18, 23)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(36, 20)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "Day"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1316, 703)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dtp)
        Me.Controls.Add(Me.dgRec)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.m)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.dgCal)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.86792!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.m
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "MainForm"
        Me.Text = "Worktime"
        CType(Me.dgCal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.dgRec, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.MinuteEnd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HourEnd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MinuteStart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HourStart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.m.ResumeLayout(False)
        Me.m.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgCal As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents ofd As OpenFileDialog
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lbl_status As ToolStripStatusLabel
    Friend WithEvents dgRec As DataGridView
    Friend WithEvents lblSelectedDay As Label
    Friend WithEvents dtp As DateTimePicker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents InsertConfirmLabel As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents MinuteEnd As NumericUpDown
    Friend WithEvents HourEnd As NumericUpDown
    Friend WithEvents MinuteStart As NumericUpDown
    Friend WithEvents HourStart As NumericUpDown
    Friend WithEvents AddRecordbtn As Button
    Friend WithEvents Infolbl As ToolStripStatusLabel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents m As MenuStrip
    Friend WithEvents TeacherLogToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuCalc As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuAbout As ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuDisplaySaturdays As ToolStripMenuItem
    Friend WithEvents mnuDisplaySundays As ToolStripMenuItem
    Friend WithEvents clnDate As DataGridViewTextBoxColumn
    Friend WithEvents clnDayName As DataGridViewTextBoxColumn
    Friend WithEvents clnWorkedHours As DataGridViewTextBoxColumn
    Friend WithEvents clnWorkedHoursInSchool As DataGridViewTextBoxColumn
    Friend WithEvents clnMonthlyIncome As DataGridViewTextBoxColumn
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents OpenDatabaeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TestToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteCurrentWorkToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents NumericUpDown2 As NumericUpDown
    Friend WithEvents NumericUpDown3 As NumericUpDown
    Friend WithEvents NumericUpDown4 As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
End Class
