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
        Me.dgvCalendar = New System.Windows.Forms.DataGridView()
        Me.clnDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnDay = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
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
        CType(Me.dgvCalendar, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'dgvCalendar
        '
        Me.dgvCalendar.AllowUserToAddRows = False
        Me.dgvCalendar.AllowUserToDeleteRows = False
        Me.dgvCalendar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvCalendar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCalendar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clnDate, Me.clnDay})
        Me.dgvCalendar.Location = New System.Drawing.Point(12, 52)
        Me.dgvCalendar.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.dgvCalendar.MultiSelect = False
        Me.dgvCalendar.Name = "dgvCalendar"
        Me.dgvCalendar.ReadOnly = True
        Me.dgvCalendar.RowHeadersWidth = 45
        Me.dgvCalendar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCalendar.Size = New System.Drawing.Size(259, 729)
        Me.dgvCalendar.TabIndex = 0
        '
        'clnDate
        '
        Me.clnDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.clnDate.HeaderText = "Date"
        Me.clnDate.MinimumWidth = 6
        Me.clnDate.Name = "clnDate"
        Me.clnDate.ReadOnly = True
        Me.clnDate.Width = 78
        '
        'clnDay
        '
        Me.clnDay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.clnDay.HeaderText = "Day"
        Me.clnDay.MinimumWidth = 6
        Me.clnDay.Name = "clnDay"
        Me.clnDay.ReadOnly = True
        Me.clnDay.Width = 71
        '
        'btnOpenDatabase
        '
        Me.btnOpenDatabase.Location = New System.Drawing.Point(977, 548)
        Me.btnOpenDatabase.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.btnOpenDatabase.Name = "btnOpenDatabase"
        Me.btnOpenDatabase.Size = New System.Drawing.Size(77, 31)
        Me.btnOpenDatabase.TabIndex = 2
        Me.btnOpenDatabase.Text = "Open Database"
        Me.btnOpenDatabase.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(20, 1344)
        Me.Button2.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(125, 44)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(18, 18)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Infolbl, Me.lbl_status, Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 815)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1580, 22)
        Me.StatusStrip1.TabIndex = 6
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Infolbl
        '
        Me.Infolbl.Name = "Infolbl"
        Me.Infolbl.Size = New System.Drawing.Size(37, 17)
        Me.Infolbl.Text = "INFO"
        '
        'lbl_status
        '
        Me.lbl_status.Name = "lbl_status"
        Me.lbl_status.Size = New System.Drawing.Size(199, 17)
        Me.lbl_status.Text = "Database: No Datebase selected"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(133, 17)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'dgvRecords
        '
        Me.dgvRecords.AllowUserToAddRows = False
        Me.dgvRecords.AllowUserToDeleteRows = False
        Me.dgvRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRecords.Location = New System.Drawing.Point(281, 275)
        Me.dgvRecords.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.dgvRecords.MultiSelect = False
        Me.dgvRecords.Name = "dgvRecords"
        Me.dgvRecords.RowHeadersWidth = 45
        Me.dgvRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRecords.Size = New System.Drawing.Size(533, 231)
        Me.dgvRecords.TabIndex = 7
        '
        'lblSelectedDay
        '
        Me.lblSelectedDay.AutoSize = True
        Me.lblSelectedDay.Location = New System.Drawing.Point(20, 27)
        Me.lblSelectedDay.Name = "lblSelectedDay"
        Me.lblSelectedDay.Size = New System.Drawing.Size(44, 25)
        Me.lblSelectedDay.TabIndex = 8
        Me.lblSelectedDay.Text = "Day"
        '
        'dtp
        '
        Me.dtp.Location = New System.Drawing.Point(963, 707)
        Me.dtp.Name = "dtp"
        Me.dtp.Size = New System.Drawing.Size(259, 31)
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
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.InsertConfirmLabel)
        Me.GroupBox1.Controls.Add(Me.lblSelectedDay)
        Me.GroupBox1.Location = New System.Drawing.Point(281, 52)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(533, 214)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add Worktime"
        '
        'AddRecordbtn
        '
        Me.AddRecordbtn.Location = New System.Drawing.Point(6, 168)
        Me.AddRecordbtn.Name = "AddRecordbtn"
        Me.AddRecordbtn.Size = New System.Drawing.Size(342, 40)
        Me.AddRecordbtn.TabIndex = 17
        Me.AddRecordbtn.Text = "Add"
        Me.AddRecordbtn.UseVisualStyleBackColor = True
        '
        'MinuteEnd
        '
        Me.MinuteEnd.Location = New System.Drawing.Point(281, 97)
        Me.MinuteEnd.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.MinuteEnd.Name = "MinuteEnd"
        Me.MinuteEnd.Size = New System.Drawing.Size(67, 31)
        Me.MinuteEnd.TabIndex = 16
        Me.MinuteEnd.Value = New Decimal(New Integer() {30, 0, 0, 0})
        '
        'HourEnd
        '
        Me.HourEnd.Location = New System.Drawing.Point(208, 97)
        Me.HourEnd.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.HourEnd.Name = "HourEnd"
        Me.HourEnd.Size = New System.Drawing.Size(67, 31)
        Me.HourEnd.TabIndex = 16
        Me.HourEnd.Value = New Decimal(New Integer() {9, 0, 0, 0})
        '
        'MinuteStart
        '
        Me.MinuteStart.Location = New System.Drawing.Point(98, 97)
        Me.MinuteStart.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.MinuteStart.Name = "MinuteStart"
        Me.MinuteStart.Size = New System.Drawing.Size(67, 31)
        Me.MinuteStart.TabIndex = 16
        '
        'HourStart
        '
        Me.HourStart.Location = New System.Drawing.Point(25, 97)
        Me.HourStart.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.HourStart.Name = "HourStart"
        Me.HourStart.Size = New System.Drawing.Size(67, 31)
        Me.HourStart.TabIndex = 16
        Me.HourStart.Value = Global.Worktime.My.MySettings.Default.HourStart
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(276, 66)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 25)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Minute"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(93, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 25)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Minute"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(205, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 25)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Hour"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(171, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 25)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "To"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 25)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Hour"
        '
        'InsertConfirmLabel
        '
        Me.InsertConfirmLabel.AutoSize = True
        Me.InsertConfirmLabel.Location = New System.Drawing.Point(20, 131)
        Me.InsertConfirmLabel.Name = "InsertConfirmLabel"
        Me.InsertConfirmLabel.Size = New System.Drawing.Size(430, 25)
        Me.InsertConfirmLabel.TabIndex = 12
        Me.InsertConfirmLabel.Text = "Start: 08:00 End: 09:30 duration 1 Hour 30 Minutes"
        '
        'test
        '
        Me.test.Location = New System.Drawing.Point(822, 395)
        Me.test.Name = "test"
        Me.test.Size = New System.Drawing.Size(149, 41)
        Me.test.TabIndex = 13
        Me.test.Text = "TEST"
        Me.test.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(281, 515)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(533, 266)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Statistics"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 127)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 25)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Income:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 82)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(182, 25)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Total working hours:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Hours spent in School:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(18, 18)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TeacherLogToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1580, 25)
        Me.MenuStrip1.TabIndex = 15
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TeacherLogToolStripMenuItem
        '
        Me.TeacherLogToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCalc})
        Me.TeacherLogToolStripMenuItem.Name = "TeacherLogToolStripMenuItem"
        Me.TeacherLogToolStripMenuItem.Size = New System.Drawing.Size(91, 21)
        Me.TeacherLogToolStripMenuItem.Text = "Teacher Log"
        '
        'mnuCalc
        '
        Me.mnuCalc.Name = "mnuCalc"
        Me.mnuCalc.Size = New System.Drawing.Size(198, 24)
        Me.mnuCalc.Text = "Calculator"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1580, 837)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.test)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dtp)
        Me.Controls.Add(Me.dgvRecords)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnOpenDatabase)
        Me.Controls.Add(Me.dgvCalendar)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.22642!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Name = "MainForm"
        Me.Text = "Worktime"
        CType(Me.dgvCalendar, System.ComponentModel.ISupportInitialize).EndInit()
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

    Friend WithEvents dgvCalendar As DataGridView
    Friend WithEvents btnOpenDatabase As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ofd As OpenFileDialog
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lbl_status As ToolStripStatusLabel
    Friend WithEvents clnDate As DataGridViewTextBoxColumn
    Friend WithEvents clnDay As DataGridViewTextBoxColumn
    Friend WithEvents dgvRecords As DataGridView
    Friend WithEvents lblSelectedDay As Label
    Friend WithEvents dtp As DateTimePicker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents InsertConfirmLabel As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
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
End Class
