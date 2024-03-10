<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddForm
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
        Me.IDtxt = New System.Windows.Forms.TextBox()
        Me.Usertxt = New System.Windows.Forms.TextBox()
        Me.Startstxt = New System.Windows.Forms.TextBox()
        Me.Startedtxt = New System.Windows.Forms.TextBox()
        Me.Endedtxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'IDtxt
        '
        Me.IDtxt.Location = New System.Drawing.Point(104, 54)
        Me.IDtxt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.IDtxt.Name = "IDtxt"
        Me.IDtxt.ReadOnly = True
        Me.IDtxt.Size = New System.Drawing.Size(208, 29)
        Me.IDtxt.TabIndex = 0
        '
        'Usertxt
        '
        Me.Usertxt.Location = New System.Drawing.Point(104, 93)
        Me.Usertxt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Usertxt.Name = "Usertxt"
        Me.Usertxt.ReadOnly = True
        Me.Usertxt.Size = New System.Drawing.Size(208, 29)
        Me.Usertxt.TabIndex = 0
        '
        'Startstxt
        '
        Me.Startstxt.Location = New System.Drawing.Point(104, 132)
        Me.Startstxt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Startstxt.Name = "Startstxt"
        Me.Startstxt.Size = New System.Drawing.Size(208, 29)
        Me.Startstxt.TabIndex = 0
        '
        'Startedtxt
        '
        Me.Startedtxt.Location = New System.Drawing.Point(104, 171)
        Me.Startedtxt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Startedtxt.Name = "Startedtxt"
        Me.Startedtxt.Size = New System.Drawing.Size(208, 29)
        Me.Startedtxt.TabIndex = 0
        '
        'Endedtxt
        '
        Me.Endedtxt.Location = New System.Drawing.Point(104, 210)
        Me.Endedtxt.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Endedtxt.Name = "Endedtxt"
        Me.Endedtxt.Size = New System.Drawing.Size(208, 29)
        Me.Endedtxt.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "User"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 21)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Day Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(41, 174)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 21)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Started"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(41, 213)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 21)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Ended"
        '
        'AddButton
        '
        Me.AddButton.Location = New System.Drawing.Point(104, 247)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(93, 31)
        Me.AddButton.TabIndex = 2
        Me.AddButton.Text = "Add"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'CancelButton
        '
        Me.CancelButton.Location = New System.Drawing.Point(219, 247)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(93, 31)
        Me.CancelButton.TabIndex = 2
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'AddForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(330, 290)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Endedtxt)
        Me.Controls.Add(Me.Startedtxt)
        Me.Controls.Add(Me.Startstxt)
        Me.Controls.Add(Me.Usertxt)
        Me.Controls.Add(Me.IDtxt)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "AddForm"
        Me.Text = "AddForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents IDtxt As TextBox
    Friend WithEvents Usertxt As TextBox
    Friend WithEvents Startstxt As TextBox
    Friend WithEvents Startedtxt As TextBox
    Friend WithEvents Endedtxt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents AddButton As Button
    Friend WithEvents CancelButton As Button
End Class
