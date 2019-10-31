Public Class Form8
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label8.Text = Form2.CoolantBar.Value
        Label3.Text = Form2.Revolutions.Value
        If Form2.Revolutions.Value > ProgressBar1.Maximum Then
            Me.ProgressBar1.Value = ProgressBar1.Maximum
        End If
        If Form2.Revolutions.Value > ProgressBar1.Minimum And Form2.Revolutions.Value < ProgressBar1.Maximum Then
            Me.ProgressBar1.Value = Form2.Revolutions.Value
        ElseIf Form2.Revolutions.Value < ProgressBar1.Minimum Then
            Me.ProgressBar1.Value = ProgressBar1.Minimum
        End If
        Label3.Text = Form2.Revolutions.Value
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

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label7.Text = Form5.EngTemp.Text
        ProgressBar1.Minimum = Form5.IdleLow.Text
        ProgressBar1.Maximum = Form5.IdleHigh.Text
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        If Form2.CheckBox2.Checked = False Then
            Label9.Text = "Störgröße aufbringen"
        Else
            Label9.Text = "Lambdaregelung erkannt! Störgröße wegnehmen"
        End If
    End Sub
End Class