<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RealTimeCalc
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.calcIncome = New System.Windows.Forms.Label()
        Me.calcWorkingHours = New System.Windows.Forms.Label()
        Me.calcHoursSpent = New System.Windows.Forms.Label()
        Me.calcMinute = New System.Windows.Forms.NumericUpDown()
        Me.calcHour = New System.Windows.Forms.NumericUpDown()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        CType(Me.calcMinute, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.calcHour, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.calcIncome)
        Me.GroupBox3.Controls.Add(Me.calcWorkingHours)
        Me.GroupBox3.Controls.Add(Me.calcHoursSpent)
        Me.GroupBox3.Controls.Add(Me.calcMinute)
        Me.GroupBox3.Controls.Add(Me.calcHour)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Location = New System.Drawing.Point(20, 23)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.GroupBox3.Size = New System.Drawing.Size(586, 240)
        Me.GroupBox3.TabIndex = 13
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Calculator"
        '
        'calcIncome
        '
        Me.calcIncome.AutoSize = True
        Me.calcIncome.Location = New System.Drawing.Point(17, 199)
        Me.calcIncome.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.calcIncome.Name = "calcIncome"
        Me.calcIncome.Size = New System.Drawing.Size(78, 25)
        Me.calcIncome.TabIndex = 17
        Me.calcIncome.Text = "Income:"
        '
        'calcWorkingHours
        '
        Me.calcWorkingHours.AutoSize = True
        Me.calcWorkingHours.Location = New System.Drawing.Point(17, 163)
        Me.calcWorkingHours.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.calcWorkingHours.Name = "calcWorkingHours"
        Me.calcWorkingHours.Size = New System.Drawing.Size(182, 25)
        Me.calcWorkingHours.TabIndex = 18
        Me.calcWorkingHours.Text = "Total working hours:"
        '
        'calcHoursSpent
        '
        Me.calcHoursSpent.AutoSize = True
        Me.calcHoursSpent.Location = New System.Drawing.Point(162, 112)
        Me.calcHoursSpent.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.calcHoursSpent.Name = "calcHoursSpent"
        Me.calcHoursSpent.Size = New System.Drawing.Size(200, 25)
        Me.calcHoursSpent.TabIndex = 19
        Me.calcHoursSpent.Text = "Hours spent in School:"
        '
        'calcMinute
        '
        Me.calcMinute.Location = New System.Drawing.Point(92, 110)
        Me.calcMinute.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.calcMinute.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.calcMinute.Name = "calcMinute"
        Me.calcMinute.Size = New System.Drawing.Size(60, 31)
        Me.calcMinute.TabIndex = 16
        '
        'calcHour
        '
        Me.calcHour.Location = New System.Drawing.Point(22, 110)
        Me.calcHour.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.calcHour.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.calcHour.Name = "calcHour"
        Me.calcHour.Size = New System.Drawing.Size(60, 31)
        Me.calcHour.TabIndex = 16
        Me.calcHour.Value = Global.Worktime.My.MySettings.Default.HourStart
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(87, 79)
        Me.Label10.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 25)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Minute"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(17, 79)
        Me.Label13.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(54, 25)
        Me.Label13.TabIndex = 15
        Me.Label13.Text = "Hour"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(17, 39)
        Me.Label15.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(214, 25)
        Me.Label15.TabIndex = 8
        Me.Label15.Text = "Hours worked at school:"
        '
        'RealTimeCalc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(621, 271)
        Me.Controls.Add(Me.GroupBox3)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.22642!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Name = "RealTimeCalc"
        Me.Text = "RealTimeCalc"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.calcMinute, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.calcHour, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents calcIncome As Label
    Friend WithEvents calcWorkingHours As Label
    Friend WithEvents calcHoursSpent As Label
    Friend WithEvents calcMinute As NumericUpDown
    Friend WithEvents calcHour As NumericUpDown
    Friend WithEvents Label10 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label15 As Label
End Class
