Public Class RealTimeCalc

    Private Sub calculate(sender As Object, e As EventArgs) Handles calcHour.ValueChanged, calcMinute.ValueChanged
        Try
            'Correct order of the lines is important here! careful before making any changes
            Dim H As Integer = calcHour.Value
            Dim M As Integer = calcMinute.Value
            calcHoursSpent.Text = $"Hours spent in School: {H}:{M}"
            Dim result As Decimal = 0
            result = H * 60 + M
            result = result / 45
            result = result * 60
            calcWorkingHours.Text = $"Hours spent in School: {ConvertMinutesToHHMM(result)}"
            result = result / 60
            result = result * 18.5
            result = Math.Round(result, 2, MidpointRounding.ToEven)
            calcIncome.Text = $"Income: €{result}"
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally

        End Try

    End Sub
End Class