Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class AddForm
    Dim Starts As New Date
    Dim ends As New Date
    Dim started As New Date
    Dim ended As New Date

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Me.Close()
    End Sub

    Private Sub TimeTextBoxes_KeyPress_Events(sender As Windows.Forms.TextBox, e As KeyPressEventArgs) Handles Startedtxt.KeyPress, Endedtxt.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not (Char.IsDigit(e.KeyChar) OrElse e.KeyChar = ":" And sender.Text.Length < 5) Then
            e.Handled = True
        End If

        ' Allow backspace, delete, left arrow, and right arrow keys
        If Not (e.KeyChar = ChrW(8) Or e.KeyChar = ChrW(46) Or e.KeyChar = ChrW(37) Or e.KeyChar = ChrW(39)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub AddForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler Startedtxt.KeyPress, AddressOf TimeTextBoxes_KeyPress_Events
        AddHandler Endedtxt.KeyPress, AddressOf TimeTextBoxes_KeyPress_Events
    End Sub
End Class