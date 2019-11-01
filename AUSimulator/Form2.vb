Public Class Form2


    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        Revolutions.Value = TrackBar1.Value



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.Text = "Motor eiskalt" Then
            CoolantTrack.Value = 4
            OilTrack.Value = 3
            TrackBar1.Value = 1200
            Revolutions.Value = 1200
        End If
        If ComboBox1.Text = "Gerade Betriebswarm" Then
            CoolantTrack.Value = 78
            OilTrack.Value = 70
            TrackBar1.Minimum = 780
            TrackBar1.Value = 780
            Revolutions.Value = 780
        End If
        If ComboBox1.Text = "Vorher Autobahn vollgas" Then
            CoolantTrack.Value = 95
            OilTrack.Value = 105
            TrackBar1.Minimum = 780
            TrackBar1.Value = 780
            Revolutions.Value = 780
        End If
        If ComboBox1.Text = "Überhitzt" Then
            CoolantTrack.Value = 118
            OilTrack.Value = 110
            TrackBar1.Minimum = 780
            TrackBar1.Value = 780
            Revolutions.Value = 780
        End If
    End Sub

    Private Sub TrackBar3_Scroll(sender As Object, e As EventArgs) Handles OilTrack.Scroll
        OilBar.Value = OilTrack.Value

    End Sub

    Private Sub TrackBar2_Scroll(sender As Object, e As EventArgs) Handles CoolantTrack.Scroll
        CoolantBar.Value = CoolantTrack.Value

    End Sub

    Private Sub TempScaleAndHighIdle_Tick(sender As Object, e As EventArgs) Handles TempScaleAndHighIdle.Tick
        TrackBar1.Minimum = TextBox2.Text

        Revolutions.Maximum = TextBox1.Text
        TrackBar1.Maximum = TextBox1.Text

        If CoolantBar.Value <= OilBar.Value - 20 And CoolantBar.Value > 20 Then
            CoolantTrack.Value = OilTrack.Value - 19
        End If

        If OilBar.Value <= CoolantBar.Value - 20 And OilBar.Value > 20 Then
            OilTrack.Value = CoolantTrack.Value - 19
        End If

        CoolantBar.Value = CoolantTrack.Value
        OilBar.Value = OilTrack.Value

        Label19.Text = CoolantBar.Value
        Label20.Text = OilBar.Value
    End Sub

    Private Sub LambdaCalc_Tick(sender As Object, e As EventArgs) Handles LambdaCalc.Tick
        If CoolantBar.Value < 30 And Revolutions.Value <= 1200 Then
            LambdaBar.Value = 37
        ElseIf Revolutions.Value > 1500 Then
            LambdaBar.Value = 40
        End If
        If CoolantBar.Value > 30 And Revolutions.Value <= 1000 Then
            LambdaBar.Value = 50
        End If
        If CoolantBar.Value < 60 And CoolantBar.Value > 31 Then
            LambdaBar.Value = 45
        End If

    End Sub

    Private Sub LambdaSway1_Tick(sender As Object, e As EventArgs) Handles LambdaSway1.Tick
        LambdaBar.Value = LambdaBar.Value + 4
    End Sub

    Private Sub LambdaSway2_Tick(sender As Object, e As EventArgs) Handles LambdaSway2.Tick
        LambdaBar.Value = LambdaBar.Value - 4
    End Sub

    Private Sub ThermalSimulation_Tick(sender As Object, e As EventArgs) Handles ThermalSimulation.Tick
        If OilTrack.Value <= 110 Then

            If Revolutions.Value <= 1200 Then
                OilTrack.Value = OilTrack.Value + 1
            End If

            If Revolutions.Value > 1201 And Revolutions.Value < 3500 Then
                OilTrack.Value = OilTrack.Value + 5
            End If

            If Revolutions.Value > 3501 And Revolutions.Value < 5000 Then
                OilTrack.Value = OilTrack.Value + 7
            End If

            If Revolutions.Value > 5000 Then
                OilTrack.Value = CoolantTrack.Value + 9
            End If

        End If
        If OilTrack.Value >= 110 Then
            If Revolutions.Value < 3000 Then
                OilTrack.Value = OilTrack.Value - 2
            End If
        End If
        If CoolantTrack.Value <= 102 Then

            If Revolutions.Value <= 1200 Then
                CoolantTrack.Value = CoolantTrack.Value + 2
            End If

            If Revolutions.Value > 1201 And Revolutions.Value < 3500 Then
                CoolantTrack.Value = CoolantTrack.Value + 6
            End If

            If Revolutions.Value > 3501 And Revolutions.Value < 5000 Then
                CoolantTrack.Value = CoolantTrack.Value + 8
            End If

            If Revolutions.Value > 5000 Then
                CoolantTrack.Value = CoolantTrack.Value + 10
            End If

        End If
        If CoolantTrack.Value >= 100 Then
            If Revolutions.Value < 3000 Then
                CoolantTrack.Value = CoolantTrack.Value - 3
            End If
        End If
    End Sub

    Private Sub RevSway_Tick(sender As Object, e As EventArgs) Handles RevSway.Tick
        Label8.Text = TrackBar1.Value
    End Sub

    Private Sub RevSwayDown_Tick(sender As Object, e As EventArgs)
        If Revolutions.Value < 6996 Then
            Revolutions.Value = Revolutions.Value + 4
        End If
    End Sub

    Private Sub LambdaError_Tick(sender As Object, e As EventArgs) Handles LambdaError.Tick
        LambdaBar.Value = LambdaBar.Value + 25
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            LambdaError.Enabled = True
            LambdaError.Start()
        Else
            LambdaError.Stop()
        End If
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Revolutions.Value = 780
    End Sub
End Class