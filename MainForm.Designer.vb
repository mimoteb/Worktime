<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.btnOpenDatabase = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ofd = New System.Windows.Forms.OpenFileDialog()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Infolbl = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lbl_status = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.dgvRecords = New System.Windows.Forms.DataGridView()
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
        Me.test = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TeacherLogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCalc = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDisplaySaturdays = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDisplaySundays = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.dgCal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.dgvRecords, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.MinuteEnd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HourEnd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MinuteStart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HourStart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgCal
        '
        Me.dgCal.AllowUserToAddRows = False
        Me.dgCal.AllowUserToDeleteRows = False
        Me.dgCal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgCal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCal.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clnDate, Me.clnDayName, Me.clnWorkedHours, Me.clnWorkedHoursInSchool, Me.clnMonthlyIncome})
        Me.dgCal.Location = New System.Drawing.Point(13, 27)
        Me.dgCal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgCal.MultiSelect = False
        Me.dgCal.Name = "dgCal"
        Me.dgCal.ReadOnly = True
        Me.dgCal.RowHeadersWidth = 45
        Me.dgCal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgCal.Size = New System.Drawing.Size(478, 612)
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
        'btnOpenDatabase
        '
        Me.btnOpenDatabase.Location = New System.Drawing.Point(1194, 480)
        Me.btnOpenDatabase.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnOpenDatabase.Name = "btnOpenDatabase"
        Me.btnOpenDatabase.Size = New System.Drawing.Size(69, 26)
        Me.btnOpenDatabase.TabIndex = 2
        Me.btnOpenDatabase.Text = "Open Database"
        Me.btnOpenDatabase.UseVisualStyleBackColor = True
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
        Me.StatusStrip1.Size = New System.Drawing.Size(1422, 22)
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
        'dgvRecords
        '
        Me.dgvRecords.AllowUserToAddRows = False
        Me.dgvRecords.AllowUserToDeleteRows = False
        Me.dgvRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRecords.Location = New System.Drawing.Point(568, 250)
        Me.dgvRecords.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgvRecords.MultiSelect = False
        Me.dgvRecords.Name = "dgvRecords"
        Me.dgvRecords.RowHeadersWidth = 45
        Me.dgvRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRecords.Size = New System.Drawing.Size(480, 194)
        Me.dgvRecords.TabIndex = 7
        '
        'lblSelectedDay
        '
        Me.lblSelectedDay.AutoSize = True
        Me.lblSelectedDay.Location = New System.Drawing.Point(18, 23)
        Me.lblSelectedDay.Name = "lblSelectedDay"
        Me.lblSelectedDay.Size = New System.Drawing.Size(35, 20)
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
        Me.GroupBox1.Location = New System.Drawing.Point(608, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(480, 180)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add Worktime"
        '
        'AddRecordbtn
        '
        Me.AddRecordbtn.Location = New System.Drawing.Point(5, 141)
        Me.AddRecordbtn.Name = "AddRecordbtn"
        Me.AddRecordbtn.Size = New System.Drawing.Size(308, 34)
        Me.AddRecordbtn.TabIndex = 17
        Me.AddRecordbtn.Text = "Add"
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
        'test
        '
        Me.test.Location = New System.Drawing.Point(1055, 351)
        Me.test.Name = "test"
        Me.test.Size = New System.Drawing.Size(134, 34)
        Me.test.TabIndex = 13
        Me.test.Text = "TEST"
        Me.test.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(568, 452)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(480, 223)
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
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(18, 18)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TeacherLogToolStripMenuItem, Me.SettingsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1422, 24)
        Me.MenuStrip1.TabIndex = 15
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TeacherLogToolStripMenuItem
        '
        Me.TeacherLogToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCalc, Me.mnuExit})
        Me.TeacherLogToolStripMenuItem.Name = "TeacherLogToolStripMenuItem"
        Me.TeacherLogToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.TeacherLogToolStripMenuItem.Text = "Teacher Log"
        '
        'mnuCalc
        '
        Me.mnuCalc.Name = "mnuCalc"
        Me.mnuCalc.Size = New System.Drawing.Size(180, 22)
        Me.mnuCalc.Text = "Calculator"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuDisplaySaturdays, Me.mnuDisplaySundays})
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'mnuDisplaySaturdays
        '
        Me.mnuDisplaySaturdays.Name = "mnuDisplaySaturdays"
        Me.mnuDisplaySaturdays.Size = New System.Drawing.Size(180, 22)
        Me.mnuDisplaySaturdays.Text = "Show Saturdays"
        '
        'mnuDisplaySundays
        '
        Me.mnuDisplaySundays.Name = "mnuDisplaySundays"
        Me.mnuDisplaySundays.Size = New System.Drawing.Size(180, 22)
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
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(180, 22)
        Me.mnuExit.Text = "Exit"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1422, 703)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.test)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dtp)
        Me.Controls.Add(Me.dgvRecords)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnOpenDatabase)
        Me.Controls.Add(Me.dgCal)
        Me.Font = New System.Drawing.Font("Segoe UI", 10.86792!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "MainForm"
        Me.Text = "Worktime"
        CType(Me.dgCal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.dgvRecords, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.MinuteEnd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HourEnd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MinuteStart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HourStart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgCal As DataGridView
    Friend WithEvents btnOpenDatabase As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ofd As OpenFileDialog
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lbl_status As ToolStripStatusLabel
    Friend WithEvents dgvRecords As DataGridView
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
    Friend WithEvents test As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents MenuStrip1 As MenuStrip
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
End Class
