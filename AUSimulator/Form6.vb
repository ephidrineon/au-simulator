Public Class Form6
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label8.Text = Form2.CoolantBar.Value
        Label3.Text = Form2.Revolutions.Value
        If Form2.Revolutions.Value < 1000 Then
            Me.ProgressBar1.Value = Form2.Revolutions.Value
        ElseIf Form2.Revolutions.Value > 1000 Then
            Me.ProgressBar1.Value = 1000
        End If
        Label3.Text = Form2.Revolutions.Value
    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label7.Text = Form5.EngTemp.Text
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Label8.Text >= Label7.Text And ProgressBar1.Value > Form5.IdleLow.Text And ProgressBar1.Value < Form5.IdleHigh.Text Then
            Label8.ForeColor = Color.Green
            ProgressBar2.PerformStep()
        Else ProgressBar2.Value = 0
        End If
        If ProgressBar2.Value = 30 Then
            Button2.Enabled = True
        End If
        Me.LambdaBar.Value = Form2.LambdaBar.Value
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form7.Show()
    End Sub
End Class