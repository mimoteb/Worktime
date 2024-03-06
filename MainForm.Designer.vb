﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dgvCalendar = New System.Windows.Forms.DataGridView()
        Me.clnDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnDay = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnOpenDatabase = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ofd = New System.Windows.Forms.OpenFileDialog()
        Me.dtp = New System.Windows.Forms.DateTimePicker()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lbl_status = New System.Windows.Forms.ToolStripStatusLabel()
        Me.dgvRecords = New System.Windows.Forms.DataGridView()
        Me.clnID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clnDuration = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblSelectedDay = New System.Windows.Forms.Label()
        CType(Me.dgvCalendar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.dgvRecords, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvCalendar
        '
        Me.dgvCalendar.AllowUserToAddRows = False
        Me.dgvCalendar.AllowUserToDeleteRows = False
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
        Me.btnOpenDatabase.Location = New System.Drawing.Point(194, 12)
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
        'dtp
        '
        Me.dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp.Location = New System.Drawing.Point(822, 63)
        Me.dtp.Name = "dtp"
        Me.dtp.Size = New System.Drawing.Size(174, 31)
        Me.dtp.TabIndex = 5
        Me.dtp.Value = New Date(2024, 3, 1, 0, 0, 0, 0)
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
        Me.dgvRecords.Location = New System.Drawing.Point(281, 52)
        Me.dgvRecords.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.dgvRecords.MultiSelect = False
        Me.dgvRecords.Name = "dgvRecords"
        Me.dgvRecords.RowHeadersWidth = 45
        Me.dgvRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRecords.Size = New System.Drawing.Size(533, 729)
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
        Me.lblSelectedDay.Location = New System.Drawing.Point(288, 17)
        Me.lblSelectedDay.Name = "lblSelectedDay"
        Me.lblSelectedDay.Size = New System.Drawing.Size(44, 25)
        Me.lblSelectedDay.TabIndex = 8
        Me.lblSelectedDay.Text = "Day"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1176, 837)
        Me.Controls.Add(Me.lblSelectedDay)
        Me.Controls.Add(Me.dgvRecords)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.dtp)
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
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvCalendar As DataGridView
    Friend WithEvents btnOpenDatabase As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ofd As OpenFileDialog
    Friend WithEvents dtp As DateTimePicker
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
End Class
