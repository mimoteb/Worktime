<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.dgvRecords = New System.Windows.Forms.DataGridView()
        Me.btnOpenDatabase = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ofd = New System.Windows.Forms.OpenFileDialog()
        Me.dtp = New System.Windows.Forms.DateTimePicker()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lbl_status = New System.Windows.Forms.ToolStripStatusLabel()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.date_t = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DayofWeek = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvRecords, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvRecords
        '
        Me.dgvRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRecords.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.date_t, Me.DayofWeek})
        Me.dgvRecords.Location = New System.Drawing.Point(20, 79)
        Me.dgvRecords.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.dgvRecords.Name = "dgvRecords"
        Me.dgvRecords.RowHeadersWidth = 45
        Me.dgvRecords.Size = New System.Drawing.Size(711, 790)
        Me.dgvRecords.TabIndex = 0
        '
        'btnOpenDatabase
        '
        Me.btnOpenDatabase.Location = New System.Drawing.Point(20, 23)
        Me.btnOpenDatabase.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.btnOpenDatabase.Name = "btnOpenDatabase"
        Me.btnOpenDatabase.Size = New System.Drawing.Size(222, 44)
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
        Me.dtp.Location = New System.Drawing.Point(444, 36)
        Me.dtp.Name = "dtp"
        Me.dtp.Size = New System.Drawing.Size(287, 31)
        Me.dtp.TabIndex = 5
        Me.dtp.Value = New Date(2024, 3, 1, 0, 0, 0, 0)
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(18, 18)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lbl_status})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 862)
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
        'id
        '
        Me.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.id.HeaderText = "id"
        Me.id.MinimumWidth = 6
        Me.id.Name = "id"
        Me.id.Width = 55
        '
        'date_t
        '
        Me.date_t.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.date_t.HeaderText = "Date"
        Me.date_t.MinimumWidth = 6
        Me.date_t.Name = "date_t"
        Me.date_t.Width = 78
        '
        'DayofWeek
        '
        Me.DayofWeek.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DayofWeek.HeaderText = "Day"
        Me.DayofWeek.MinimumWidth = 6
        Me.DayofWeek.Name = "DayofWeek"
        Me.DayofWeek.Width = 71
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1176, 884)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.dtp)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnOpenDatabase)
        Me.Controls.Add(Me.dgvRecords)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.22642!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Name = "MainForm"
        Me.Text = "Worktime"
        CType(Me.dgvRecords, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvRecords As DataGridView
    Friend WithEvents btnOpenDatabase As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ofd As OpenFileDialog
    Friend WithEvents dtp As DateTimePicker
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lbl_status As ToolStripStatusLabel
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents date_t As DataGridViewTextBoxColumn
    Friend WithEvents DayofWeek As DataGridViewTextBoxColumn
End Class
