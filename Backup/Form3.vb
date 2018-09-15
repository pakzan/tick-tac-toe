Public Class Form3

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form3_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.VisibleChanged
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = 100
        ProgressBar1.Value = 0
        Label1.Text = "Recalculating..."
        Label2.Text = Label2.Text + "a"
    End Sub

    Private Sub Label2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label2.TextChanged
        Do

            If ProgressBar1.Value < 100 Then
                ProgressBar1.Value = ProgressBar1.Value + 10
            End If
        Loop Until ProgressBar1.Value = 100
        Timer1.start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value = 100 Then
            Me.Visible = False
            Timer1.Stop()
        End If

    End Sub
End Class