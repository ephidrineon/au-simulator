Public Class Form7
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Label8.Text >= Label7.Text And ProgressBar1.Value > Form5.RevLow.Text And ProgressBar1.Value < Form5.RevHigh.Text Then
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
        If Form2.Revolutions.Value < 4000 And Form2.Revolutions.Value > 2000 Then
            Me.ProgressBar1.Value = Form2.Revolutions.Value
        ElseIf Form2.Revolutions.Value > 4000 Then
            Me.ProgressBar1.Value = 4000
        End If
        If Form2.Revolutions.Value > 2000 And Form2.Revolutions.Value < 4000 Then
            Me.ProgressBar1.Value = Form2.Revolutions.Value
        ElseIf Form2.Revolutions.Value < 2000 Then
            Me.ProgressBar1.Value = 2000
        End If
        Label3.Text = Form2.Revolutions.Value
    End Sub

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label7.Text = Form5.EngTemp.Text
    End Sub
End Class