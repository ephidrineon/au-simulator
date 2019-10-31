Public Class Form7
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value > Form5.RevLow.Text And ProgressBar1.Value < Form5.RevHigh.Text Then
            Label8.ForeColor = Color.Green
            ProgressBar2.PerformStep()
        Else ProgressBar2.Value = 0
        End If
        If ProgressBar2.Value = 30 Then
            Button2.Enabled = True
        End If
        Me.LambdaBar.Value = Form2.LambdaBar.Value
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Label8.Text = Form2.CoolantBar.Value
        Label3.Text = Form2.Revolutions.Value
        If Form2.Revolutions.Value > ProgressBar1.Minimum And Form2.Revolutions.Value < ProgressBar1.Maximum Then
            Me.ProgressBar1.Value = Form2.Revolutions.Value
        ElseIf Form2.Revolutions.Value > ProgressBar1.Maximum Then
            Me.ProgressBar1.Value = ProgressBar1.Maximum
        End If
        If Form2.Revolutions.Value > ProgressBar1.Minimum And Form2.Revolutions.Value < ProgressBar1.Maximum Then
            Me.ProgressBar1.Value = Form2.Revolutions.Value
        ElseIf Form2.Revolutions.Value < ProgressBar1.Minimum Then
            Me.ProgressBar1.Value = ProgressBar1.Minimum
        End If
        Label3.Text = Form2.Revolutions.Value
    End Sub

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label7.Text = Form5.EngTemp.Text
        ProgressBar1.Minimum = Form5.RevLow.Text
        ProgressBar1.Maximum = Form5.RevHigh.Text
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form8.Show()
    End Sub
End Class