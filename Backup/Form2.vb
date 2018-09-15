Public Class Form2
   
    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form1.Visible = True
        Form1.Label10.Text = ""
        Form1.Label1.Text = ""
        Form1.Label2.Text = ""
        Form1.Label3.Text = ""
        Form1.Label4.Text = ""
        Form1.Label5.Text = ""
        Form1.Label6.Text = ""
        Form1.Label7.Text = ""
        Form1.Label8.Text = ""
        Form1.Label9.Text = ""
        Form1.Label11.Text = ""
        Form1.Label12.Text = ""
        Form1.Label13.Text = ""
        Form1.Label10.Text = "a"
        Me.Visible = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form1.Visible = True
        Form1.Label1.Text = ""
        Form1.Label2.Text = ""
        Form1.Label3.Text = ""
        Form1.Label4.Text = ""
        Form1.Label5.Text = ""
        Form1.Label6.Text = ""
        Form1.Label7.Text = ""
        Form1.Label8.Text = ""
        Form1.Label9.Text = ""
        Form1.Label11.Text = ""
        Form1.Label12.Text = ""
        Me.Visible = False
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class