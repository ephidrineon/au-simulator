Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Form2.CheckBox1.Checked = False Then
            Label11.ForeColor = Color.Red
            Label11.Text = "OBD-Adapter nicht verbunden!"
        ElseIf Form2.CheckBox1.Checked = True Then
            Label11.ForeColor = Color.Green
            Label11.Text = "OBD-Adapter verbunden!"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form4.Show()
    End Sub
End Class