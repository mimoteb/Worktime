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
        Me.lbl_status = New System.Windows.Forms.ToolStripStatusLabel()
        Me.dgvRecords = New System.Windows.Forms.DataGridView()
        Me.clnID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnDuration = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblSelectedDay = New System.Windows.Forms.Label()
        Me.dtp = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.HourStart = New System.Windows.Forms.TextBox()
        Me.MinuteStart = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.HourEnd = New System.Windows.Forms.TextBox()
        Me.MinuteEnd = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DurationBox = New System.Windows.Forms.ComboBox()
        CType(Me.dgvCalendar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.dgvRecords, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
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
        Me.clnDate.Width = 78
        '
        'clnDay
        '
        Me.clnDay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.clnDay.HeaderText = "Day"
        Me.clnDay.MinimumWidth = 6
        Me.clnDay.Name = "clnDay"
        Me.clnDay.Width = 71
        '
        'btnOpenDatabase
        '
        Me.btnOpenDatabase.Location = New System.Drawing.Point(997, 52)
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
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lbl_status})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 815)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1176, 22)
        Me.StatusStrip1.TabIndex = 6
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lbl_status
        '
        Me.lbl_status.Name = "lbl_status"
        Me.lbl_status.Size = New System.Drawing.Size(199, 17)
        Me.lbl_status.Text = "Database: No Datebase selected"
        '
        'dgvRecords
        '
        Me.dgvRecords.AllowUserToAddRows = False
        Me.dgvRecords.AllowUserToDeleteRows = False
        Me.dgvRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRecords.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clnID, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.clnDuration})
        Me.dgvRecords.Location = New System.Drawing.Point(281, 275)
        Me.dgvRecords.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.dgvRecords.MultiSelect = False
        Me.dgvRecords.Name = "dgvRecords"
        Me.dgvRecords.RowHeadersWidth = 45
        Me.dgvRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRecords.Size = New System.Drawing.Size(533, 506)
        Me.dgvRecords.TabIndex = 7
        '
        'clnID
        '
        Me.clnID.HeaderText = "ID"
        Me.clnID.MinimumWidth = 6
        Me.clnID.Name = "clnID"
        Me.clnID.Width = 110
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.HeaderText = "Start"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 77
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn2.HeaderText = "End"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 71
        '
        'clnDuration
        '
        Me.clnDuration.HeaderText = "Duration"
        Me.clnDuration.MinimumWidth = 6
        Me.clnDuration.Name = "clnDuration"
        Me.clnDuration.Width = 110
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
        Me.dtp.Location = New System.Drawing.Point(12, 12)
        Me.dtp.Name = "dtp"
        Me.dtp.Size = New System.Drawing.Size(259, 31)
        Me.dtp.TabIndex = 10
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DurationBox)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.MinuteEnd)
        Me.GroupBox1.Controls.Add(Me.MinuteStart)
        Me.GroupBox1.Controls.Add(Me.HourEnd)
        Me.GroupBox1.Controls.Add(Me.HourStart)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lblSelectedDay)
        Me.GroupBox1.Location = New System.Drawing.Point(281, 52)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(533, 214)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add Worktime"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 172)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(430, 25)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Start: 08:00 End: 09:30 duration 1 Hour 30 Minutes"
        '
        'HourStart
        '
        Me.HourStart.Location = New System.Drawing.Point(25, 94)
        Me.HourStart.Name = "HourStart"
        Me.HourStart.Size = New System.Drawing.Size(59, 31)
        Me.HourStart.TabIndex = 13
        '
        'MinuteStart
        '
        Me.MinuteStart.Location = New System.Drawing.Point(90, 94)
        Me.MinuteStart.Name = "MinuteStart"
        Me.MinuteStart.Size = New System.Drawing.Size(67, 31)
        Me.MinuteStart.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(163, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 25)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "To"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 25)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Hour"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(85, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 25)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Minute"
        '
        'HourEnd
        '
        Me.HourEnd.Location = New System.Drawing.Point(200, 94)
        Me.HourEnd.Name = "HourEnd"
        Me.HourEnd.Size = New System.Drawing.Size(59, 31)
        Me.HourEnd.TabIndex = 13
        '
        'MinuteEnd
        '
        Me.MinuteEnd.Location = New System.Drawing.Point(265, 94)
        Me.MinuteEnd.Name = "MinuteEnd"
        Me.MinuteEnd.Size = New System.Drawing.Size(67, 31)
        Me.MinuteEnd.TabIndex = 13
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
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(260, 66)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 25)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Minute"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(347, 66)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 25)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Duration"
        '
        'DurationBox
        '
        Me.DurationBox.FormattingEnabled = True
        Me.DurationBox.Items.AddRange(New Object() {"15 Minutes", "30 Minutes", "45 Minutes", "1 Hour", "1 Hour 15 Minutes", "1 Hour 30 Minutes", "1 Hour 45 Minutes", "2 Hours"})
        Me.DurationBox.Location = New System.Drawing.Point(352, 97)
        Me.DurationBox.Name = "DurationBox"
        Me.DurationBox.Size = New System.Drawing.Size(121, 33)
        Me.DurationBox.TabIndex = 16
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1176, 837)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dtp)
        Me.Controls.Add(Me.dgvRecords)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnOpenDatabase)
        Me.Controls.Add(Me.dgvCalendar)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.22642!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Name = "MainForm"
        Me.Text = "Worktime"
        CType(Me.dgvCalendar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.dgvRecords, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
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
    Friend WithEvents clnID As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents clnDuration As DataGridViewTextBoxColumn
    Friend WithEvents lblSelectedDay As Label
    Friend WithEvents dtp As DateTimePicker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents MinuteStart As TextBox
    Friend WithEvents HourStart As TextBox
    Friend WithEvents DurationBox As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents MinuteEnd As TextBox
    Friend WithEvents HourEnd As TextBox
End Class
