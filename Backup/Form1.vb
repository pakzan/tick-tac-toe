Public Class Form1
    Dim A As Integer
    Dim b As String
    Dim RND As New Random

    Private Sub Form1_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        b = MsgBox("Are you sure you want to give up?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Give up?")
        If b = MsgBoxResult.No Then
            Form2.Visible = True
        End If

    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click
        If Label9.Text = "" Then
            Label9.Text = "X"
        End If
        Label10.Text = Label10.Text + "a"
        Label9.Enabled = False
        
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        If Label2.Text = "" Then
            Label2.Text = "X"
        End If
        Label10.Text = Label10.Text + "a"
        Label2.Enabled = False
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        If Label3.Text = "" Then
            Label3.Text = "X"
        End If
        Label10.Text = Label10.Text + "a"
        Label3.Enabled = False
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        If Label4.Text = "" Then
            Label4.Text = "X"
        End If
        Label10.Text = Label10.Text + "a"
        Label4.Enabled = False
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click
        If Label5.Text = "" Then
            Label5.Text = "X"
        End If
        Label10.Text = Label10.Text + "a"
        Label5.Enabled = False
    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click
        If Label6.Text = "" Then
            Label6.Text = "X"
        End If
        Label10.Text = Label10.Text + "a"
        Label6.Enabled = False
    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click
        If Label7.Text = "" Then
            Label7.Text = "X"
        End If
        Label10.Text = Label10.Text + "a"
        Label7.Enabled = False
    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click
        If Label8.Text = "" Then
            Label8.Text = "X"
        End If
        Label10.Text = Label10.Text + "a"
        Label8.Enabled = False
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        If Label1.Text = "" Then
            Label1.Text = "X"
        End If
        Label10.Text = Label10.Text + "a"
        Label1.Enabled = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Label1.Text = "O" And Label2.Text = "O" And Label3.Text = "" Then
            b = MsgBox("Finish this match! Don't be a coward!", MsgBoxStyle.Exclamation, MsgBoxStyle.OkOnly)

        ElseIf Label1.Text = "O" And Label3.Text = "O" And Label2.Text = "" Then
            b = MsgBox("Finish this match! Don't be a coward!", MsgBoxStyle.Exclamation, MsgBoxStyle.OkOnly)

        ElseIf Label2.Text = "O" And Label3.Text = "O" And Label1.Text = "" Then
            b = MsgBox("Finish this match! Don't be a coward!", MsgBoxStyle.Exclamation, MsgBoxStyle.OkOnly)

        ElseIf Label4.Text = "O" And Label5.Text = "O" And Label6.Text = "" Then
            b = MsgBox("Finish this match! Don't be a coward!", MsgBoxStyle.Exclamation, MsgBoxStyle.OkOnly)

        ElseIf Label4.Text = "O" And Label6.Text = "O" And Label5.Text = "" Then
            b = MsgBox("Finish this match! Don't be a coward!", MsgBoxStyle.Exclamation, MsgBoxStyle.OkOnly)

        ElseIf Label5.Text = "O" And Label6.Text = "O" And Label4.Text = "" Then
            b = MsgBox("Finish this match! Don't be a coward!", MsgBoxStyle.Exclamation, MsgBoxStyle.OkOnly)

        ElseIf Label7.Text = "O" And Label8.Text = "O" And Label9.Text = "" Then
            b = MsgBox("Finish this match! Don't be a coward!", MsgBoxStyle.Exclamation, MsgBoxStyle.OkOnly)

        ElseIf Label7.Text = "O" And Label9.Text = "O" And Label8.Text = "" Then
            b = MsgBox("Finish this match! Don't be a coward!", MsgBoxStyle.Exclamation, MsgBoxStyle.OkOnly)

        ElseIf Label8.Text = "O" And Label9.Text = "O" And Label7.Text = "" Then
            b = MsgBox("Finish this match! Don't be a coward!", MsgBoxStyle.Exclamation, MsgBoxStyle.OkOnly)

        ElseIf Label1.Text = "O" And Label4.Text = "O" And Label7.Text = "" Then
            b = MsgBox("Finish this match! Don't be a coward!", MsgBoxStyle.Exclamation, MsgBoxStyle.OkOnly)

        ElseIf Label1.Text = "O" And Label7.Text = "O" And Label4.Text = "" Then
            b = MsgBox("Finish this match! Don't be a coward!", MsgBoxStyle.Exclamation, MsgBoxStyle.OkOnly)

        ElseIf Label4.Text = "O" And Label7.Text = "O" And Label1.Text = "" Then
            b = MsgBox("Finish this match! Don't be a coward!", MsgBoxStyle.Exclamation, MsgBoxStyle.OkOnly)


        ElseIf Label2.Text = "O" And Label5.Text = "O" And Label8.Text = "" Then
            b = MsgBox("Finish this match! Don't be a coward!", MsgBoxStyle.Exclamation, MsgBoxStyle.OkOnly)

        ElseIf Label2.Text = "O" And Label8.Text = "O" And Label5.Text = "" Then
            b = MsgBox("Finish this match! Don't be a coward!", MsgBoxStyle.Exclamation, MsgBoxStyle.OkOnly)

        ElseIf Label5.Text = "O" And Label8.Text = "O" And Label2.Text = "" Then
            b = MsgBox("Finish this match! Don't be a coward!", MsgBoxStyle.Exclamation, MsgBoxStyle.OkOnly)


        ElseIf Label3.Text = "O" And Label6.Text = "O" And Label9.Text = "" Then
            b = MsgBox("Finish this match! Don't be a coward!", MsgBoxStyle.Exclamation, MsgBoxStyle.OkOnly)

        ElseIf Label3.Text = "O" And Label9.Text = "O" And Label6.Text = "" Then
            b = MsgBox("Finish this match! Don't be a coward!", MsgBoxStyle.Exclamation, MsgBoxStyle.OkOnly)

        ElseIf Label6.Text = "O" And Label9.Text = "O" And Label3.Text = "" Then
            b = MsgBox("Finish this match! Don't be a coward!", MsgBoxStyle.Exclamation, MsgBoxStyle.OkOnly)

        ElseIf Label1.Text = "O" And Label5.Text = "O" And Label9.Text = "" Then
            b = MsgBox("Finish this match! Don't be a coward!", MsgBoxStyle.Exclamation, MsgBoxStyle.OkOnly)

        ElseIf Label1.Text = "O" And Label9.Text = "O" And Label5.Text = "" Then
            b = MsgBox("Finish this match! Don't be a coward!", MsgBoxStyle.Exclamation, MsgBoxStyle.OkOnly)

        ElseIf Label5.Text = "O" And Label9.Text = "O" And Label1.Text = "" Then
            b = MsgBox("Finish this match! Don't be a coward!", MsgBoxStyle.Exclamation, MsgBoxStyle.OkOnly)

        ElseIf Label7.Text = "O" And Label5.Text = "O" And Label3.Text = "" Then
            b = MsgBox("Finish this match! Don't be a coward!", MsgBoxStyle.Exclamation, MsgBoxStyle.OkOnly)

        ElseIf Label7.Text = "O" And Label3.Text = "O" And Label5.Text = "" Then
            b = MsgBox("Finish this match! Don't be a coward!", MsgBoxStyle.Exclamation, MsgBoxStyle.OkOnly)

        ElseIf Label5.Text = "O" And Label3.Text = "O" And Label7.Text = "" Then
            Label7.Text = "O"
            b = MsgBox("Finish this match! Don't be a coward!", MsgBoxStyle.Exclamation, MsgBoxStyle.OkOnly)
        Else
            Form2.Visible = True
        End If
        If Strings.Len(Label11.Text) <> 9 Then
            labela1.Text = ""
            labela1.Visible = False
            labela2.Text = ""
            labela2.Visible = False
            labela3.Text = ""
            labela3.Visible = False
            labela4.Text = ""
            labela4.Visible = False
            labela5.Text = ""
            labela5.Visible = False
            labela6.Text = ""
            labela6.Visible = False
            labela7.Text = ""
            labela7.Visible = False
            labela8.Text = ""
            labela8.Visible = False
            labela9.Text = ""
            labela9.Visible = False
            labela10.Text = ""
            labela10.Visible = False
            labela11.Text = ""
            labela11.Visible = False
            labela12.Text = ""
            labela12.Visible = False
        End If
    End Sub

    Private Sub Label1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label1.TextChanged
        Label11.Text = Label11.Text + "a"
    End Sub

    Private Sub Label2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label2.TextChanged
        Label11.Text = Label11.Text + "b"
    End Sub
    Private Sub Label3_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label3.TextChanged
        Label11.Text = Label11.Text + "c"
    End Sub
    Private Sub Label4_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label4.TextChanged
        Label11.Text = Label11.Text + "d"
    End Sub
    Private Sub Label5_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label5.TextChanged
        Label11.Text = Label11.Text + "e"
    End Sub
    Private Sub Label6_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label6.TextChanged
        Label11.Text = Label11.Text + "f"
    End Sub
    Private Sub Label7_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label7.TextChanged
        Label11.Text = Label11.Text + "g"
    End Sub
    Private Sub Label8_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label8.TextChanged
        Label11.Text = Label11.Text + "h"
    End Sub
    Private Sub Label9_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label9.TextChanged
        Label11.Text = Label11.Text + "i"
    End Sub

    Private Sub Label13_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label13.TextChanged
        A = RND.Next(1, 9)
        Label12.Text = Str(A)
        Select Case A
            Case Is = 1
                If Label1.Text = "" Then
                    Label1.Text = "O"
                Else
                    Label13.Text = Label13.Text + "a"
                End If
            Case Is = 2
                If Label2.Text = "" Then
                    Label2.Text = "O"
                Else
                    Label13.Text = Label13.Text + "a"
                End If
            Case Is = 3
                If Label3.Text = "" Then
                    Label3.Text = "O"
                Else
                    Label13.Text = Label13.Text + "a"
                End If

            Case Is = 4
                If Label4.Text = "" Then
                    Label4.Text = "O"
                Else
                    Label13.Text = Label13.Text + "a"
                End If
            Case Is = 5
                If Label5.Text = "" Then
                    Label5.Text = "O"
                Else
                    Label13.Text = Label13.Text + "a"
                End If

            Case Is = 6
                If Label6.Text = "" Then
                    Label6.Text = "O"
                Else
                    Label13.Text = Label13.Text + "a"
                End If

            Case Is = 7
                If Label7.Text = "" Then
                    Label7.Text = "O"
                Else
                    Label13.Text = Label13.Text + "a"
                End If

            Case Is = 8
                If Label8.Text = "" Then
                    Label8.Text = "O"
                Else
                    Label13.Text = Label13.Text + "a"
                End If

            Case Is = 9
                If Label9.Text = "" Then
                    Label9.Text = "O"
                Else
                    Label13.Text = Label13.Text + "a"
                End If
        End Select
    End Sub

    Private Sub Label10_TextChanged1(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label10.TextChanged
        If Label1.Text = "X" And Label2.Text = "X" And Label3.Text = "X" Then
            b = MsgBox("You win!", MsgBoxStyle.OkOnly, "Congratulation!")

        ElseIf Label4.Text = "X" And Label5.Text = "X" And Label6.Text = "X" Then
            b = MsgBox("You win!", MsgBoxStyle.OkOnly, "Congratulation!")

        ElseIf Label7.Text = "X" And Label8.Text = "X" And Label9.Text = "X" Then
            b = MsgBox("You win!", MsgBoxStyle.OkOnly, "Congratulation!")

        ElseIf Label1.Text = "X" And Label4.Text = "X" And Label7.Text = "X" Then
            b = MsgBox("You win!", MsgBoxStyle.OkOnly, "Congratulation!")

        ElseIf Label2.Text = "X" And Label5.Text = "X" And Label8.Text = "X" Then
            b = MsgBox("You win!", MsgBoxStyle.OkOnly, "Congratulation!")

        ElseIf Label3.Text = "X" And Label6.Text = "X" And Label9.Text = "X" Then
            b = MsgBox("You win!", MsgBoxStyle.OkOnly, "Congratulation!")

        ElseIf Label1.Text = "X" And Label5.Text = "X" And Label9.Text = "X" Then
            b = MsgBox("You win!", MsgBoxStyle.OkOnly, "Congratulation!")

        ElseIf Label3.Text = "X" And Label5.Text = "X" And Label7.Text = "X" Then
            b = MsgBox("You win!", MsgBoxStyle.OkOnly, "Congratulation!")
        ElseIf Label1.Text = "O" And Label2.Text = "O" And Label3.Text = "" Then
            Label3.Text = "O"
            b = MsgBox("Try again later.", MsgBoxStyle.OkOnly, "You lose!")

        ElseIf Label1.Text = "O" And Label3.Text = "O" And Label2.Text = "" Then
            Label2.Text = "O"
            b = MsgBox("Try again later.", MsgBoxStyle.OkOnly, "You lose!")

        ElseIf Label2.Text = "O" And Label3.Text = "O" And Label1.Text = "" Then
            Label1.Text = "O"
            b = MsgBox("Try again later.", MsgBoxStyle.OkOnly, "You lose!")


        ElseIf Label4.Text = "O" And Label5.Text = "O" And Label6.Text = "" Then
            Label6.Text = "O"
            b = MsgBox("Try again later.", MsgBoxStyle.OkOnly, "You lose!")

        ElseIf Label4.Text = "O" And Label6.Text = "O" And Label5.Text = "" Then
            Label5.Text = "O"
            b = MsgBox("Try again later.", MsgBoxStyle.OkOnly, "You lose!")

        ElseIf Label5.Text = "O" And Label6.Text = "O" And Label4.Text = "" Then
            Label4.Text = "O"
            b = MsgBox("Try again later.", MsgBoxStyle.OkOnly, "You lose!")


        ElseIf Label7.Text = "O" And Label8.Text = "O" And Label9.Text = "" Then
            Label9.Text = "O"
            b = MsgBox("Try again later.", MsgBoxStyle.OkOnly, "You lose!")

        ElseIf Label7.Text = "O" And Label9.Text = "O" And Label8.Text = "" Then
            Label8.Text = "O"
            b = MsgBox("Try again later.", MsgBoxStyle.OkOnly, "You lose!")

        ElseIf Label8.Text = "O" And Label9.Text = "O" And Label7.Text = "" Then
            Label7.Text = "O"
            b = MsgBox("Try again later.", MsgBoxStyle.OkOnly, "You lose!")


        ElseIf Label1.Text = "O" And Label4.Text = "O" And Label7.Text = "" Then
            Label7.Text = "O"
            b = MsgBox("Try again later.", MsgBoxStyle.OkOnly, "You lose!")

        ElseIf Label1.Text = "O" And Label7.Text = "O" And Label4.Text = "" Then
            Label4.Text = "O"
            b = MsgBox("Try again later.", MsgBoxStyle.OkOnly, "You lose!")

        ElseIf Label4.Text = "O" And Label7.Text = "O" And Label1.Text = "" Then
            Label1.Text = "O"
            b = MsgBox("Try again later.", MsgBoxStyle.OkOnly, "You lose!")


        ElseIf Label2.Text = "O" And Label5.Text = "O" And Label8.Text = "" Then
            Label8.Text = "O"
            b = MsgBox("Try again later.", MsgBoxStyle.OkOnly, "You lose!")

        ElseIf Label2.Text = "O" And Label8.Text = "O" And Label5.Text = "" Then
            Label5.Text = "O"
            b = MsgBox("Try again later.", MsgBoxStyle.OkOnly, "You lose!")

        ElseIf Label5.Text = "O" And Label8.Text = "O" And Label2.Text = "" Then
            Label2.Text = "O"
            b = MsgBox("Try again later.", MsgBoxStyle.OkOnly, "You lose!")


        ElseIf Label3.Text = "O" And Label6.Text = "O" And Label9.Text = "" Then
            Label9.Text = "O"
            b = MsgBox("Try again later.", MsgBoxStyle.OkOnly, "You lose!")

        ElseIf Label3.Text = "O" And Label9.Text = "O" And Label6.Text = "" Then
            Label6.Text = "O"
            b = MsgBox("Try again later.", MsgBoxStyle.OkOnly, "You lose!")

        ElseIf Label6.Text = "O" And Label9.Text = "O" And Label3.Text = "" Then
            Label3.Text = "O"
            b = MsgBox("Try again later.", MsgBoxStyle.OkOnly, "You lose!")


        ElseIf Label1.Text = "O" And Label5.Text = "O" And Label9.Text = "" Then
            Label9.Text = "O"
            b = MsgBox("Try again later.", MsgBoxStyle.OkOnly, "You lose!")

        ElseIf Label1.Text = "O" And Label9.Text = "O" And Label5.Text = "" Then
            Label5.Text = "O"
            b = MsgBox("Try again later.", MsgBoxStyle.OkOnly, "You lose!")

        ElseIf Label5.Text = "O" And Label9.Text = "O" And Label1.Text = "" Then
            Label1.Text = "O"
            b = MsgBox("Try again later.", MsgBoxStyle.OkOnly, "You lose!")


        ElseIf Label7.Text = "O" And Label5.Text = "O" And Label3.Text = "" Then
            Label3.Text = "O"
            b = MsgBox("Try again later.", MsgBoxStyle.OkOnly, "You lose!")

        ElseIf Label7.Text = "O" And Label3.Text = "O" And Label5.Text = "" Then
            Label5.Text = "O"
            b = MsgBox("Try again later.", MsgBoxStyle.OkOnly, "You lose!")

        ElseIf Label5.Text = "O" And Label3.Text = "O" And Label7.Text = "" Then
            Label7.Text = "O"
            b = MsgBox("Try again later.", MsgBoxStyle.OkOnly, "You lose!")
        End If
        If b = MsgBoxResult.Ok Then
            b = 0
            Label1.Text = ""
            Label1.Enabled = True
            Label2.Text = ""
            Label2.Enabled = True
            Label3.Text = ""
            Label3.Enabled = True
            Label4.Text = ""
            Label4.Enabled = True
            Label5.Text = ""
            Label5.Enabled = True
            Label6.Text = ""
            Label6.Enabled = True
            Label7.Text = ""
            Label7.Enabled = True
            Label8.Text = ""
            Label8.Enabled = True
            Label9.Text = ""
            Label9.Enabled = True
            Label11.Text = ""
            Label12.Text = ""
            Label13.Text = ""
            Label10.Text = ""
            Label14.ForeColor = Color.Black
            Label14.Font = New Font("Lucida Fax", 20)
            Label14.Text = "Loser Can't Be Chooser!"
            Timer1.Start()

        ElseIf Label1.Text = "X" And Label2.Text = "X" And Label3.Text = "" Then
            Label3.Text = "O"

        ElseIf Label1.Text = "X" And Label3.Text = "X" And Label2.Text = "" Then
            Label2.Text = "O"

        ElseIf Label2.Text = "X" And Label3.Text = "X" And Label1.Text = "" Then
            Label1.Text = "O"


        ElseIf Label4.Text = "X" And Label5.Text = "X" And Label6.Text = "" Then
            Label6.Text = "O"

        ElseIf Label4.Text = "X" And Label6.Text = "X" And Label5.Text = "" Then
            Label5.Text = "O"

        ElseIf Label5.Text = "X" And Label6.Text = "X" And Label4.Text = "" Then
            Label4.Text = "O"


        ElseIf Label7.Text = "X" And Label8.Text = "X" And Label9.Text = "" Then
            Label9.Text = "O"

        ElseIf Label7.Text = "X" And Label9.Text = "X" And Label8.Text = "" Then
            Label8.Text = "O"

        ElseIf Label8.Text = "X" And Label9.Text = "X" And Label7.Text = "" Then
            Label7.Text = "O"


        ElseIf Label1.Text = "X" And Label4.Text = "X" And Label7.Text = "" Then
            Label7.Text = "O"

        ElseIf Label1.Text = "X" And Label7.Text = "X" And Label4.Text = "" Then
            Label4.Text = "O"

        ElseIf Label4.Text = "X" And Label7.Text = "X" And Label1.Text = "" Then
            Label1.Text = "O"


        ElseIf Label2.Text = "X" And Label5.Text = "X" And Label8.Text = "" Then
            Label8.Text = "O"

        ElseIf Label2.Text = "X" And Label8.Text = "X" And Label5.Text = "" Then
            Label5.Text = "O"

        ElseIf Label5.Text = "X" And Label8.Text = "X" And Label2.Text = "" Then
            Label2.Text = "O"


        ElseIf Label3.Text = "X" And Label6.Text = "X" And Label9.Text = "" Then
            Label9.Text = "O"

        ElseIf Label3.Text = "X" And Label9.Text = "X" And Label6.Text = "" Then
            Label6.Text = "O"

        ElseIf Label6.Text = "X" And Label9.Text = "X" And Label3.Text = "" Then
            Label3.Text = "O"


        ElseIf Label1.Text = "X" And Label5.Text = "X" And Label9.Text = "" Then
            Label9.Text = "O"

        ElseIf Label1.Text = "X" And Label9.Text = "X" And Label5.Text = "" Then
            Label5.Text = "O"

        ElseIf Label5.Text = "X" And Label9.Text = "X" And Label1.Text = "" Then
            Label1.Text = "O"


        ElseIf Label7.Text = "X" And Label5.Text = "X" And Label3.Text = "" Then
            Label3.Text = "O"

        ElseIf Label7.Text = "X" And Label3.Text = "X" And Label5.Text = "" Then
            Label5.Text = "O"

        ElseIf Label5.Text = "X" And Label3.Text = "X" And Label7.Text = "" Then
            Label7.Text = "O"
        ElseIf Strings.Len(Label11.Text) = 2 Or Strings.Len(Label11.Text) = 4 Then
            If Strings.Left(Label11.Text, 1) = "a" Then
                If Strings.Mid(Label11.Text, 2, 1) = "c" Or Strings.Mid(Label11.Text, 2, 1) = "e" Or Strings.Mid(Label11.Text, 2, 1) = "g" Then
                    If Label9.Text = "" Then
                        Label9.Text = "O"
                    ElseIf Label11.Text = "agie" Or Label11.Text = "aeig" Then
                        Label3.Text = "O"
                    ElseIf Label11.Text = "acie" Or Label11.Text = "aeic" Then
                        Label7.Text = "O"
                    ElseIf Strings.Len(Label11.Text) = 4 Then
                        Label13.Text = Label13.Text + "a"
                    End If
                End If
                If Strings.Mid(Label11.Text, 2, 1) = "d" Or Strings.Mid(Label11.Text, 2, 1) = "h" Then
                    If Label3.Text = "" Then
                        Label3.Text = "O"
                    ElseIf Label11.Text = "adcb" Or Label11.Text = "ahcb" Then
                        Label5.Text = "O"
                    End If
                End If
                If Strings.Mid(Label11.Text, 2, 1) = "b" Or Strings.Mid(Label11.Text, 2, 1) = "f" Then
                    If Label7.Text = "" Then
                        Label7.Text = "O"
                    ElseIf Label11.Text = "abgd" Or Label11.Text = "afgd" Then
                        Label5.Text = "O"
                    End If
                End If
                If Strings.Mid(Label11.Text, 2, 1) = "i" Then
                    If Label7.Text = "" Then
                        Label7.Text = "O"
                    ElseIf Label11.Text = "aigd" Then
                        Label3.Text = "O"
                    End If
                End If
            End If


            If Strings.Left(Label11.Text, 1) = "c" Then
                If Strings.Mid(Label11.Text, 2, 1) = "i" Or Strings.Mid(Label11.Text, 2, 1) = "e" Or Strings.Mid(Label11.Text, 2, 1) = "a" Then
                    If Label7.Text = "" Then
                        Label7.Text = "O"
                    ElseIf Label11.Text = "cage" Or Label11.Text = "cega" Then
                        Label9.Text = "O"
                    ElseIf Label11.Text = "cige" Or Label11.Text = "cegi" Then
                        Label1.Text = "O"
                    ElseIf Strings.Len(Label11.Text) = 4 Then
                        Label13.Text = Label13.Text + "a"
                    End If
                End If
                If Strings.Mid(Label11.Text, 2, 1) = "b" Or Strings.Mid(Label11.Text, 2, 1) = "d" Then
                    If Label9.Text = "" Then
                        Label9.Text = "O"
                    ElseIf Label11.Text = "cbif" Or Label11.Text = "cdif" Then
                        Label5.Text = "O"
                    End If
                End If
                If Strings.Mid(Label11.Text, 2, 1) = "f" Or Strings.Mid(Label11.Text, 2, 1) = "h" Then
                    If Label1.Text = "" Then
                        Label1.Text = "O"
                    ElseIf Label11.Text = "cfab" Or Label11.Text = "chab" Then
                        Label5.Text = "O"
                    End If
                End If
                If Strings.Mid(Label11.Text, 2, 1) = "g" Then
                    If Label1.Text = "" Then
                        Label1.Text = "O"
                    ElseIf Label11.Text = "cgab" Then
                        Label9.Text = "O"
                    End If
                End If
            End If


            If Strings.Left(Label11.Text, 1) = "g" Then
                If Strings.Mid(Label11.Text, 2, 1) = "a" Or Strings.Mid(Label11.Text, 2, 1) = "e" Or Strings.Mid(Label11.Text, 2, 1) = "i" Then
                    If Label3.Text = "" Then
                        Label3.Text = "O"
                    ElseIf Label11.Text = "gice" Or Label11.Text = "geci" Then
                        Label1.Text = "O"
                    ElseIf Label11.Text = "gace" Or Label11.Text = "geca" Then
                        Label9.Text = "O"
                    ElseIf Strings.Len(Label11.Text) = 4 Then
                        Label13.Text = Label13.Text + "a"
                    End If
                End If
                If Strings.Mid(Label11.Text, 2, 1) = "h" Or Strings.Mid(Label11.Text, 2, 1) = "f" Then
                    If Label1.Text = "" Then
                        Label1.Text = "O"
                    ElseIf Label11.Text = "ghad" Or Label11.Text = "gfad" Then
                        Label5.Text = "O"
                    Else : Label13.Text = Label13.Text + "a"
                    End If
                End If
                If Strings.Mid(Label11.Text, 2, 1) = "d" Or Strings.Mid(Label11.Text, 2, 1) = "b" Then
                    If Label9.Text = "" Then
                        Label9.Text = "O"
                    ElseIf Label11.Text = "gdih" Or Label11.Text = "gbih" Then
                        Label5.Text = "O"
                    End If
                End If
                If Strings.Mid(Label11.Text, 2, 1) = "c" Then
                    If Label9.Text = "" Then
                        Label9.Text = "O"
                    ElseIf Label11.Text = "gcih" Then
                        Label1.Text = "O"
                    End If
                End If
            End If


            If Strings.Left(Label11.Text, 1) = "i" Then
                If Strings.Mid(Label11.Text, 2, 1) = "g" Or Strings.Mid(Label11.Text, 2, 1) = "e" Or Strings.Mid(Label11.Text, 2, 1) = "c" Then
                    If Label1.Text = "" Then
                        Label1.Text = "O"
                    ElseIf Label11.Text = "icae" Or Label11.Text = "ieac" Then
                        Label7.Text = "O"
                    ElseIf Label11.Text = "ieag" Or Label11.Text = "igae" Then
                        Label3.Text = "O"
                    ElseIf Strings.Len(Label11.Text) = 4 Then
                        Label13.Text = Label13.Text + "a"
                    End If
                End If
                If Strings.Mid(Label11.Text, 2, 1) = "f" Or Strings.Mid(Label11.Text, 2, 1) = "b" Then
                    If Label7.Text = "" Then
                        Label7.Text = "O"
                    ElseIf Label11.Text = "ifgh" Or Label11.Text = "ibgh" Then
                        Label5.Text = "O"
                    End If
                End If
                If Strings.Mid(Label11.Text, 2, 1) = "h" Or Strings.Mid(Label11.Text, 2, 1) = "d" Then
                    If Label3.Text = "" Then
                        Label3.Text = "O"
                    ElseIf Label11.Text = "ihcf" Or Label11.Text = "idcf" Then
                        Label5.Text = "O"
                    End If
                End If
                If Strings.Mid(Label11.Text, 2, 1) = "a" Then
                    If Label3.Text = "" Then
                        Label3.Text = "O"
                    ElseIf Label11.Text = "iacf" Then
                        Label7.Text = "O"
                    End If
                End If
            End If


            If Strings.Left(Label11.Text, 1) = "e" Then
                If Strings.Mid(Label11.Text, 2, 1) = "b" Or Strings.Mid(Label11.Text, 2, 1) = "d" Then
                    If Label1.Text = "" Then
                        Label1.Text = "O"
                    ElseIf Label11.Text = "ebai" Then
                        Label7.Text = "O"
                    ElseIf Label11.Text = "edai" Then
                        Label3.Text = "O"

                    End If
                End If
                If Strings.Mid(Label11.Text, 2, 1) = "f" Or Strings.Mid(Label11.Text, 2, 1) = "h" Then
                    If Label9.Text = "" Then
                        Label9.Text = "O"
                    ElseIf Label11.Text = "efia" Then
                        Label7.Text = "O"
                    ElseIf Label11.Text = "ehia" Then
                        Label3.Text = "O"
                    End If
                End If
                If Strings.Mid(Label11.Text, 2, 1) = "a" Then
                    If Label9.Text = "" Then
                        Label9.Text = "O"
                    ElseIf Label11.Text = "eaih" Then
                        Label3.Text = "O"
                    ElseIf Label11.Text = "eaif" Then
                        Label6.Text = "O"
                    End If
                End If
                If Strings.Mid(Label11.Text, 2, 1) = "c" Then
                    If Label7.Text = "" Then
                        Label7.Text = "O"
                    ElseIf Label11.Text = "ecgd" Then
                        Label9.Text = "O"
                    ElseIf Label11.Text = "ecgh" Then
                        Label1.Text = "O"
                    End If
                End If
                If Strings.Mid(Label11.Text, 2, 1) = "g" Then
                    If Label3.Text = "" Then
                        Label3.Text = "O"
                    ElseIf Label11.Text = "egcf" Then
                        Label1.Text = "O"
                    ElseIf Label11.Text = "egcb" Then
                        Label2.Text = "O"
                    End If
                End If
                If Strings.Mid(Label11.Text, 2, 1) = "i" Then
                    If Label1.Text = "" Then
                        Label1.Text = "O"
                    ElseIf Label11.Text = "eiab" Then
                        Label7.Text = "O"
                    ElseIf Label11.Text = "eiad" Then
                        Label4.Text = "O"
                    End If
                End If
            End If


            If Strings.Left(Label11.Text, 1) = "f" Then
                If Strings.Mid(Label11.Text, 2, 1) = "c" Then
                    If Label1.Text = "" Then
                        Label1.Text = "O"
                    ElseIf Strings.Mid(Label11.Text, 4, 1) = "b" Or Strings.Mid(Label11.Text, 4, 1) = "i" Or Strings.Mid(Label11.Text, 4, 1) = "h" Then
                        Label4.Text = "O"
                    ElseIf Strings.Mid(Label11.Text, 4, 1) = "g" Then
                        Label5.Text = "O"
                    ElseIf Strings.Len(Label11.Text) = 4 Then
                        Label13.Text = Label13.Text + "a"
                    End If
                End If
                If Strings.Mid(Label11.Text, 2, 1) = "i" Then
                    If Label7.Text = "" Then
                        Label7.Text = "O"
                    ElseIf Strings.Mid(Label11.Text, 4, 1) = "b" Or Strings.Mid(Label11.Text, 4, 1) = "a" Or Strings.Mid(Label11.Text, 4, 1) = "h" Then
                        Label5.Text = "O"
                    ElseIf Strings.Mid(Label11.Text, 4, 1) = "c" Then
                        Label4.Text = "O"
                    ElseIf Strings.Len(Label11.Text) = 4 Then
                        Label13.Text = Label13.Text + "a"
                    End If
                End If
                If Strings.Mid(Label11.Text, 2, 1) = "a" Then
                    If Label3.Text = "" Then
                        Label3.Text = "O"
                    ElseIf Strings.Mid(Label11.Text, 4, 1) = "i" Then
                        Label5.Text = "O"
                    End If
                End If
                If Strings.Mid(Label11.Text, 2, 1) = "g" Then
                    If Label9.Text = "" Then
                        Label9.Text = "O"
                    ElseIf Strings.Mid(Label11.Text, 4, 1) = "c" Then
                        Label5.Text = "O"
                    End If
                End If
                If Strings.Mid(Label11.Text, 2, 1) = "b" Or Strings.Mid(Label11.Text, 2, 1) = "h" Then
                    If Label5.Text = "" Then
                        Label5.Text = "O"
                    ElseIf Strings.Mid(Label11.Text, 4, 1) = "d" Then
                        Label9.Text = "O"
                    End If
                End If
                If Strings.Mid(Label11.Text, 2, 1) = "d" Then
                    If Label1.Text = "" Then
                        Label1.Text = "O"
                    ElseIf Strings.Mid(Label11.Text, 4, 1) = "b" Then
                        Label9.Text = "O"
                    ElseIf Strings.Mid(Label11.Text, 4, 1) = "e" Or Strings.Mid(Label11.Text, 4, 1) = "h" Or Strings.Mid(Label11.Text, 4, 1) = "g" Then
                        Label3.Text = "O"
                    ElseIf Strings.Len(Label11.Text) = 4 Then
                        Label13.Text = Label13.Text + "a"
                    End If
                End If
                If Strings.Mid(Label11.Text, 2, 1) = "e" Then
                    If Label7.Text = "" Then
                        Label7.Text = "O"
                    ElseIf Strings.Mid(Label11.Text, 4, 1) = "a" Or Strings.Mid(Label11.Text, 4, 1) = "g" Then
                        Label9.Text = "O"
                    ElseIf Strings.Len(Label11.Text) = 4 Then
                        Label13.Text = Label13.Text + "a"
                    End If
                End If
            End If


            If Strings.Left(Label11.Text, 1) = "d" Then
                If Strings.Mid(Label11.Text, 2, 1) = "g" Then
                    If Label9.Text = "" Then
                        Label9.Text = "O"
                    ElseIf Strings.Mid(Label11.Text, 4, 1) = "h" Or Strings.Mid(Label11.Text, 4, 1) = "a" Or Strings.Mid(Label11.Text, 4, 1) = "b" Then
                        Label6.Text = "O"
                    ElseIf Strings.Mid(Label11.Text, 4, 1) = "c" Then
                        Label5.Text = "O"
                    ElseIf Strings.Len(Label11.Text) = 4 Then
                        Label13.Text = Label13.Text + "a"
                    End If
                End If
                If Strings.Mid(Label11.Text, 2, 1) = "a" Then
                    If Label3.Text = "" Then
                        Label3.Text = "O"
                    ElseIf Strings.Mid(Label11.Text, 4, 1) = "h" Or Strings.Mid(Label11.Text, 4, 1) = "i" Or Strings.Mid(Label11.Text, 4, 1) = "b" Then
                        Label5.Text = "O"
                    ElseIf Strings.Mid(Label11.Text, 4, 1) = "g" Then
                        Label6.Text = "O"
                    ElseIf Strings.Len(Label11.Text) = 4 Then
                        Label13.Text = Label13.Text + "a"
                    End If
                End If
                If Strings.Mid(Label11.Text, 2, 1) = "i" Then
                    If Label7.Text = "" Then
                        Label7.Text = "O"
                    ElseIf Strings.Mid(Label11.Text, 4, 1) = "a" Then
                        Label5.Text = "O"
                    End If
                End If
                If Strings.Mid(Label11.Text, 2, 1) = "c" Then
                    If Label1.Text = "" Then
                        Label1.Text = "O"
                    ElseIf Strings.Mid(Label11.Text, 4, 1) = "g" Then
                        Label5.Text = "O"
                    End If
                End If
                If Strings.Mid(Label11.Text, 2, 1) = "h" Or Strings.Mid(Label11.Text, 2, 1) = "b" Then
                    If Label5.Text = "" Then
                        Label5.Text = "O"
                    ElseIf Strings.Mid(Label11.Text, 4, 1) = "f" Then
                        Label1.Text = "O"
                    End If
                End If
                If Strings.Mid(Label11.Text, 2, 1) = "f" Then
                    If Label9.Text = "" Then
                        Label9.Text = "O"
                    ElseIf Strings.Mid(Label11.Text, 4, 1) = "h" Then
                        Label1.Text = "O"
                    ElseIf Strings.Mid(Label11.Text, 4, 1) = "e" Or Strings.Mid(Label11.Text, 4, 1) = "b" Or Strings.Mid(Label11.Text, 4, 1) = "c" Then
                        Label7.Text = "O"
                    ElseIf Strings.Len(Label11.Text) = 4 Then
                        Label13.Text = Label13.Text + "a"
                    End If
                End If
                If Strings.Mid(Label11.Text, 2, 1) = "e" Then
                    If Label3.Text = "" Then
                        Label3.Text = "O"
                    ElseIf Strings.Mid(Label11.Text, 4, 1) = "i" Or Strings.Mid(Label11.Text, 4, 1) = "c" Then
                        Label1.Text = "O"
                    ElseIf Strings.Len(Label11.Text) = 4 Then
                        Label13.Text = Label13.Text + "a"
                    End If
                End If
            End If


            If Strings.Left(Label11.Text, 1) = "h" Then
                If Strings.Mid(Label11.Text, 2, 1) = "i" Then
                    If Label3.Text = "" Then
                        Label3.Text = "O"
                    ElseIf Strings.Mid(Label11.Text, 4, 1) = "f" Or Strings.Mid(Label11.Text, 4, 1) = "g" Or Strings.Mid(Label11.Text, 4, 1) = "d" Then
                        Label2.Text = "O"
                    ElseIf Strings.Mid(Label11.Text, 4, 1) = "a" Then
                        Label5.Text = "O"
                    ElseIf Strings.Len(Label11.Text) = 4 Then
                        Label13.Text = Label13.Text + "a"
                    End If
                End If
                If Strings.Mid(Label11.Text, 2, 1) = "g" Then
                    If Label1.Text = "" Then
                        Label1.Text = "O"
                    ElseIf Strings.Mid(Label11.Text, 4, 1) = "d" Or Strings.Mid(Label11.Text, 4, 1) = "c" Or Strings.Mid(Label11.Text, 4, 1) = "d" Then
                        Label5.Text = "O"
                    ElseIf Strings.Mid(Label11.Text, 4, 1) = "i" Then
                        Label2.Text = "O"
                    ElseIf Strings.Len(Label11.Text) = 4 Then
                        Label13.Text = Label13.Text + "a"
                    End If
                End If
                If Strings.Mid(Label11.Text, 2, 1) = "c" Then
                    If Label9.Text = "" Then
                        Label9.Text = "O"
                    ElseIf Strings.Mid(Label11.Text, 4, 1) = "g" Then
                        Label5.Text = "O"
                    End If
                End If
                If Strings.Mid(Label11.Text, 2, 1) = "a" Then
                    If Label7.Text = "" Then
                        Label7.Text = "O"
                    ElseIf Strings.Mid(Label11.Text, 4, 1) = "i" Then
                        Label5.Text = "O"
                    End If
                End If
                If Strings.Mid(Label11.Text, 2, 1) = "f" Or Strings.Mid(Label11.Text, 2, 1) = "d" Then
                    If Label5.Text = "" Then
                        Label5.Text = "O"
                    ElseIf Strings.Mid(Label11.Text, 4, 1) = "b" Then
                        Label7.Text = "O"
                    End If
                End If
                If Strings.Mid(Label11.Text, 2, 1) = "b" Then
                    If Label3.Text = "" Then
                        Label3.Text = "O"
                    ElseIf Strings.Mid(Label11.Text, 4, 1) = "f" Then
                        Label7.Text = "O"
                    ElseIf Strings.Mid(Label11.Text, 4, 1) = "e" Or Strings.Mid(Label11.Text, 4, 1) = "d" Or Strings.Mid(Label11.Text, 4, 1) = "a" Then
                        Label9.Text = "O"
                    ElseIf Strings.Len(Label11.Text) = 4 Then
                        Label13.Text = Label13.Text + "a"
                    End If
                End If
                If Strings.Mid(Label11.Text, 2, 1) = "e" Then
                    If Label1.Text = "" Then
                        Label1.Text = "O"
                    ElseIf Strings.Mid(Label11.Text, 4, 1) = "c" Or Strings.Mid(Label11.Text, 4, 1) = "a" Then
                        Label7.Text = "O"
                    ElseIf Strings.Len(Label11.Text) = 4 Then
                        Label13.Text = Label13.Text + "a"
                    End If
                End If
            End If


            If Strings.Left(Label11.Text, 1) = "b" Then
                If Strings.Mid(Label11.Text, 2, 1) = "a" Then
                    If Label7.Text = "" Then
                        Label7.Text = "O"
                    ElseIf Strings.Mid(Label11.Text, 4, 1) = "d" Or Strings.Mid(Label11.Text, 4, 1) = "c" Or Strings.Mid(Label11.Text, 4, 1) = "f" Then
                        Label8.Text = "O"
                    ElseIf Strings.Mid(Label11.Text, 4, 1) = "i" Then
                        Label5.Text = "O"
                    ElseIf Strings.Len(Label11.Text) = 4 Then
                        Label13.Text = Label13.Text + "a"
                    End If
                End If
                If Strings.Mid(Label11.Text, 2, 1) = "c" Then
                    If Label9.Text = "" Then
                        Label9.Text = "O"
                    ElseIf Strings.Mid(Label11.Text, 4, 1) = "d" Or Strings.Mid(Label11.Text, 4, 1) = "g" Or Strings.Mid(Label11.Text, 4, 1) = "f" Then
                        Label5.Text = "O"
                    ElseIf Strings.Mid(Label11.Text, 4, 1) = "a" Then
                        Label8.Text = "O"
                    ElseIf Strings.Len(Label11.Text) = 4 Then
                        Label13.Text = Label13.Text + "a"
                    End If
                End If
                If Strings.Mid(Label11.Text, 2, 1) = "g" Then
                    If Label1.Text = "" Then
                        Label1.Text = "O"
                    ElseIf Strings.Mid(Label11.Text, 4, 1) = "c" Then
                        Label5.Text = "O"
                    End If
                End If
                If Strings.Mid(Label11.Text, 2, 1) = "i" Then
                    If Label3.Text = "" Then
                        Label3.Text = "O"
                    ElseIf Strings.Mid(Label11.Text, 4, 1) = "a" Then
                        Label5.Text = "O"
                    End If
                End If
                If Strings.Mid(Label11.Text, 2, 1) = "d" Or Strings.Mid(Label11.Text, 2, 1) = "f" Then
                    If Label5.Text = "" Then
                        Label5.Text = "O"
                    ElseIf Strings.Mid(Label11.Text, 4, 1) = "h" Then
                        Label3.Text = "O"
                    End If
                End If
                If Strings.Mid(Label11.Text, 2, 1) = "h" Then
                    If Label7.Text = "" Then
                        Label7.Text = "O"
                    ElseIf Strings.Mid(Label11.Text, 4, 1) = "d" Then
                        Label3.Text = "O"
                    ElseIf Strings.Mid(Label11.Text, 4, 1) = "e" Or Strings.Mid(Label11.Text, 4, 1) = "f" Or Strings.Mid(Label11.Text, 4, 1) = "i" Then
                        Label1.Text = "O"
                    ElseIf Strings.Len(Label11.Text) = 4 Then
                        Label13.Text = Label13.Text + "a"
                    End If
                End If
                If Strings.Mid(Label11.Text, 2, 1) = "e" Then
                    If Label9.Text = "" Then
                        Label9.Text = "O"
                    ElseIf Strings.Mid(Label11.Text, 4, 1) = "g" Or Strings.Mid(Label11.Text, 4, 1) = "i" Then
                        Label3.Text = "O"
                    ElseIf Strings.Len(Label11.Text) = 4 Then
                        Label13.Text = Label13.Text + "a"
                    End If
                End If
            End If
        ElseIf Strings.Len(Label11.Text) = 0 Or Strings.Len(Label11.Text) = 6 Or Strings.Len(Label11.Text) = 8 Then
            Label13.Text = Label13.Text + "a"



        ElseIf Strings.Len(Label11.Text) = 1 Or Strings.Len(Label11.Text) = 3 Or Strings.Len(Label11.Text) = 5 Or Strings.Len(Label11.Text) = 7 Then

            If Strings.Left(Label11.Text, 1) = "e" And Label5.Text = "X" Then
                If Label1.Text = "" Then
                    Label1.Text = "O"
                ElseIf Strings.Mid(Label11.Text, 3, 1) = "i" And Label7.Text = "" Then
                    Label7.Text = "O"
                Else : Label13.Text = Label13.Text + "a"
                End If
            End If


            If Strings.Left(Label11.Text, 1) = "a" And Label1.Text = "X" Then
                If Label5.Text = "" Then
                    Label5.Text = "O"
                ElseIf Strings.Mid(Label11.Text, 3, 1) = "i" And Label4.Text = "" Then
                    Label4.Text = "O"
                ElseIf Strings.Mid(Label11.Text, 5, 1) = "f" And Label3.Text = "" Then
                    Label3.Text = "O"
                ElseIf Strings.Len(Label11.Text) = 3 Then
                    If Strings.Mid(Label11.Text, 3, 1) = "f" Or Strings.Mid(Label11.Text, 3, 1) = "h" Then
                        Label9.Text = "O"
                    End If
                Else : Label13.Text = Label13.Text + "a"
                End If
            End If


            If Strings.Left(Label11.Text, 1) = "c" And Label3.Text = "X" Then
                If Label5.Text = "" Then
                    Label5.Text = "O"
                ElseIf Strings.Mid(Label11.Text, 3, 1) = "g" And Label2.Text = "" Then
                    Label2.Text = "O"
                ElseIf Strings.Mid(Label11.Text, 5, 1) = "h" And Label9.Text = "" Then
                    Label9.Text = "O"
                ElseIf Strings.Len(Label11.Text) = 3 Then
                    If Strings.Mid(Label11.Text, 3, 1) = "h" Or Strings.Mid(Label11.Text, 3, 1) = "d" Then
                        Label7.Text = "O"
                    End If
                Else : Label13.Text = Label13.Text + "a"
                End If
            End If


            If Strings.Left(Label11.Text, 1) = "g" And Label7.Text = "X" Then
                If Label5.Text = "" Then
                    Label5.Text = "O"
                ElseIf Strings.Mid(Label11.Text, 3, 1) = "c" And Label8.Text = "" Then
                    Label8.Text = "O"
                ElseIf Strings.Mid(Label11.Text, 5, 1) = "b" And Label1.Text = "" Then
                    Label1.Text = "O"
                ElseIf Strings.Len(Label11.Text) = 3 Then
                    If Strings.Mid(Label11.Text, 3, 1) = "b" Or Strings.Mid(Label11.Text, 3, 1) = "f" Then
                        Label3.Text = "O"
                    End If
                Else : Label13.Text = Label13.Text + "a"
                End If
            End If


            If Strings.Left(Label11.Text, 1) = "i" And Label9.Text = "X" Then
                If Label5.Text = "" Then
                    Label5.Text = "O"
                ElseIf Strings.Mid(Label11.Text, 3, 1) = "a" And Label6.Text = "" Then
                    Label6.Text = "O"
                ElseIf Strings.Mid(Label11.Text, 5, 1) = "d" And Label7.Text = "" Then
                    Label7.Text = "O"
                ElseIf Strings.Len(Label11.Text) = 3 Then
                    If Strings.Mid(Label11.Text, 3, 1) = "d" Or Strings.Mid(Label11.Text, 3, 1) = "b" Then
                        Label1.Text = "O"
                    End If
                Else : Label13.Text = Label13.Text + "a"
                End If
            End If


            If Strings.Left(Label11.Text, 1) = "b" And Label2.Text = "X" Then
                If Strings.Len(Label11.Text) = 1 Then
                    A = RND.Next(1, 3)
                    If A = 1 Then
                        Label1.Text = "O"
                    ElseIf A = 2 Then
                        Label5.Text = "O"
                    ElseIf A = 3 Then
                        Label8.Text = "O"
                    End If
                End If
                If Strings.Mid(Label11.Text, 2, 1) = "a" Then
                    If Strings.Len(Label11.Text) = 3 Then
                        If Strings.Mid(Label11.Text, 3, 1) = "c" Or Strings.Mid(Label11.Text, 3, 1) = "g" Or Strings.Mid(Label11.Text, 3, 1) = "i" Then
                            Label5.Text = "O"
                        Else : Label13.Text = Label13.Text + "a"
                        End If
                    ElseIf Strings.Mid(Label11.Text, 3, 1) = "d" Then
                        If Label8.Text = "" Then
                            Label8.Text = "O"
                        ElseIf Strings.Mid(Label11.Text, 5, 1) = "c" Then
                            If Label9.Text = "" Then
                                Label9.Text = "O"
                            Else : Label13.Text = Label13.Text + "a"
                            End If
                        End If
                    ElseIf Strings.Mid(Label11.Text, 3, 1) = "f" Then
                        If Label7.Text = "" Then
                            Label7.Text = "O"
                        End If
                    End If
                End If

                If Strings.Mid(Label11.Text, 2, 1) = "h" Then
                    If Strings.Left(Label11.Text, 3) = "g" Or Strings.Left(Label11.Text, 3) = "i" Then
                        If Label1.Text = "" Then
                            Label1.Text = "O"
                        Else : Label13.Text = Label13.Text + "a"
                        End If
                    ElseIf Strings.Left(Label11.Text, 3) = "e" Then
                        If Label3.Text = "" Then
                            Label3.Text = "O"
                        ElseIf Strings.Left(Label11.Text, 5) = "a" And Label9.Text = "" Then
                            Label9.Text = "O"
                        Else : Label13.Text = Label13.Text + "a"
                        End If
                    ElseIf Strings.Left(Label11.Text, 3) = "d" And Label3.Text = "" Then
                        Label3.Text = "O"
                    ElseIf Strings.Left(Label11.Text, 3) = "f" And Label1.Text = "" Then
                        Label1.Text = "O"
                    ElseIf Strings.Left(Label11.Text, 3) = "a" And Strings.Left(Label11.Text, 5) = "f" And Label7.Text = "" Then
                        Label7.Text = "O"
                    ElseIf Strings.Left(Label11.Text, 3) = "c" And Strings.Left(Label11.Text, 5) = "d" And Label9.Text = "" Then
                        Label9.Text = "O"
                    Else : Label13.Text = Label13.Text + "a"
                    End If
                End If

                If Strings.Mid(Label11.Text, 2, 1) = "e" Then
                    If Strings.Left(Label11.Text, 3) = "g" Or Strings.Left(Label11.Text, 3) = "h" Then
                        If Label3.Text = "" Then
                            Label3.Text = "O"
                        Else : Label13.Text = Label13.Text + "a"
                        End If
                    ElseIf Label1.Text = "" Then
                        If Strings.Left(Label11.Text, 3) = "d" Or Strings.Left(Label11.Text, 3) = "f" Or Strings.Left(Label11.Text, 3) = "i" Then
                            Label1.Text = "O"
                        Else : Label13.Text = Label13.Text + "a"
                        End If
                    Else : Label13.Text = Label13.Text + "a"
                    End If
                End If
            End If



            If Strings.Left(Label11.Text, 1) = "f" And Label6.Text = "X" Then
                If Strings.Len(Label11.Text) = 1 Then
                    A = RND.Next(1, 3)
                    If A = 1 Then
                        Label3.Text = "O"
                    ElseIf A = 2 Then
                        Label5.Text = "O"
                    ElseIf A = 3 Then
                        Label4.Text = "O"
                    End If
                End If
                If Strings.Mid(Label11.Text, 2, 1) = "c" Then
                    If Strings.Len(Label11.Text) = 3 Then
                        If Strings.Mid(Label11.Text, 3, 1) = "i" Or Strings.Mid(Label11.Text, 3, 1) = "a" Or Strings.Mid(Label11.Text, 3, 1) = "g" Then
                            Label5.Text = "O"
                        Else : Label13.Text = Label13.Text + "a"
                        End If
                    ElseIf Strings.Mid(Label11.Text, 3, 1) = "b" Then
                        If Label4.Text = "" Then
                            Label4.Text = "O"
                        ElseIf Strings.Mid(Label11.Text, 5, 1) = "i" Then
                            If Label7.Text = "" Then
                                Label7.Text = "O"
                            End If
                        Else : Label13.Text = Label13.Text + "a"
                        End If
                    ElseIf Strings.Mid(Label11.Text, 3, 1) = "h" Then
                        If Label1.Text = "" Then
                            Label1.Text = "O"
                        Else : Label13.Text = Label13.Text + "a"
                        End If
                    End If
                End If

                If Strings.Mid(Label11.Text, 2, 1) = "d" Then
                    If Strings.Left(Label11.Text, 3) = "a" Or Strings.Left(Label11.Text, 3) = "g" Then
                        If Label3.Text = "" Then
                            Label3.Text = "O"
                        Else : Label13.Text = Label13.Text + "a"
                        End If
                    ElseIf Strings.Left(Label11.Text, 3) = "e" Then
                        If Label9.Text = "" Then
                            Label9.Text = "O"
                        ElseIf Strings.Left(Label11.Text, 5) = "c" And Label9.Text = "" Then
                            Label7.Text = "O"
                        Else : Label13.Text = Label13.Text + "a"
                        End If
                    ElseIf Strings.Left(Label11.Text, 3) = "b" And Label3.Text = "" Then
                        Label9.Text = "O"
                    ElseIf Strings.Left(Label11.Text, 3) = "h" And Label1.Text = "" Then
                        Label3.Text = "O"
                    ElseIf Strings.Left(Label11.Text, 3) = "c" And Strings.Left(Label11.Text, 5) = "h" And Label7.Text = "" Then
                        Label1.Text = "O"
                    ElseIf Strings.Left(Label11.Text, 3) = "i" And Strings.Left(Label11.Text, 5) = "b" And Label9.Text = "" Then
                        Label7.Text = "O"
                    Else : Label13.Text = Label13.Text + "a"
                    End If
                End If

                If Strings.Mid(Label11.Text, 2, 1) = "e" Then
                    If Strings.Left(Label11.Text, 3) = "a" Or Strings.Left(Label11.Text, 3) = "d" Then
                        If Label9.Text = "" Then
                            Label9.Text = "O"
                        Else : Label13.Text = Label13.Text + "a"
                        End If
                    ElseIf Strings.Left(Label11.Text, 3) = "b" Or Strings.Left(Label11.Text, 3) = "h" Or Strings.Left(Label11.Text, 3) = "g" Then
                        If Label3.Text = "" Then
                            Label3.Text = "O"
                        Else : Label13.Text = Label13.Text + "a"
                        End If
                    Else : Label13.Text = Label13.Text + "a"
                    End If
                End If
            End If



            If Strings.Left(Label11.Text, 1) = "d" And Label4.Text = "X" Then
                If Strings.Len(Label11.Text) = 1 Then
                    A = RND.Next(1, 3)
                    If A = 1 Then
                        Label7.Text = "O"
                    ElseIf A = 2 Then
                        Label5.Text = "O"
                    ElseIf A = 3 Then
                        Label6.Text = "O"
                    End If
                End If
                If Strings.Mid(Label11.Text, 2, 1) = "g" Then
                    If Strings.Len(Label11.Text) = 3 Then
                        If Strings.Mid(Label11.Text, 3, 1) = "a" Or Strings.Mid(Label11.Text, 3, 1) = "i" Or Strings.Mid(Label11.Text, 3, 1) = "c" Then
                            Label5.Text = "O"
                        Else : Label13.Text = Label13.Text + "a"
                        End If
                    ElseIf Strings.Mid(Label11.Text, 3, 1) = "h" Then
                        If Label6.Text = "" Then
                            Label6.Text = "O"
                        ElseIf Strings.Mid(Label11.Text, 5, 1) = "a" Then
                            If Label3.Text = "" Then
                                Label3.Text = "O"
                            Else : Label13.Text = Label13.Text + "a"
                            End If
                        Else : Label13.Text = Label13.Text + "a"
                        End If
                    ElseIf Strings.Mid(Label11.Text, 3, 1) = "b" Then
                        If Label9.Text = "" Then
                            Label9.Text = "O"
                        Else : Label13.Text = Label13.Text + "a"
                        End If
                    End If
                End If

                If Strings.Mid(Label11.Text, 2, 1) = "f" Then
                    If Label7.Text = "" Then
                        If Strings.Left(Label11.Text, 3) = "i" Or Strings.Left(Label11.Text, 3) = "c" Then
                            Label7.Text = "O"
                        Else : Label13.Text = Label13.Text + "a"
                        End If
                    ElseIf Strings.Left(Label11.Text, 3) = "e" Then
                        If Label1.Text = "" Then
                            Label1.Text = "O"
                        ElseIf Strings.Left(Label11.Text, 5) = "g" And Label3.Text = "" Then
                            Label3.Text = "O"
                        Else : Label13.Text = Label13.Text + "a"
                        End If
                    ElseIf Strings.Left(Label11.Text, 3) = "h" And Label1.Text = "" Then
                        Label1.Text = "O"
                    ElseIf Strings.Left(Label11.Text, 3) = "b" And Label7.Text = "" Then
                        Label7.Text = "O"
                    ElseIf Strings.Left(Label11.Text, 3) = "g" And Strings.Left(Label11.Text, 5) = "b" And Label7.Text = "" Then
                        Label9.Text = "O"
                    ElseIf Strings.Left(Label11.Text, 3) = "a" And Strings.Left(Label11.Text, 5) = "h" And Label9.Text = "" Then
                        Label3.Text = "O"
                    Else : Label13.Text = Label13.Text + "a"
                    End If
                End If

                If Strings.Mid(Label11.Text, 2, 1) = "e" Then
                    If Strings.Left(Label11.Text, 3) = "i" Or Strings.Left(Label11.Text, 3) = "f" Then
                        If Label1.Text = "" Then
                            Label1.Text = "O"
                        Else : Label13.Text = Label13.Text + "a"
                        End If

                    ElseIf Strings.Left(Label11.Text, 3) = "h" Or Strings.Left(Label11.Text, 3) = "b" Or Strings.Left(Label11.Text, 3) = "c" Then
                        If Label7.Text = "" Then
                            Label7.Text = "O"
                        Else : Label13.Text = Label13.Text + "a"
                        End If
                    Else : Label13.Text = Label13.Text + "a"
                    End If
                End If
            End If



            If Strings.Left(Label11.Text, 1) = "h" And Label8.Text = "X" Then
                If Strings.Len(Label11.Text) = 1 Then
                    A = RND.Next(1, 3)
                    If A = 1 Then
                        Label9.Text = "O"
                    ElseIf A = 2 Then
                        Label5.Text = "O"
                    ElseIf A = 3 Then
                        Label2.Text = "O"
                    End If
                End If
                If Strings.Mid(Label11.Text, 2, 1) = "i" Then
                    If Strings.Len(Label11.Text) = 3 Then
                        If Strings.Mid(Label11.Text, 3, 1) = "g" Or Strings.Mid(Label11.Text, 3, 1) = "c" Or Strings.Mid(Label11.Text, 3, 1) = "a" Then
                            Label5.Text = "O"
                        Else : Label13.Text = Label13.Text + "a"
                        End If
                    ElseIf Strings.Mid(Label11.Text, 3, 1) = "f" Then
                        If Label2.Text = "" Then
                            Label2.Text = "O"
                        ElseIf Strings.Mid(Label11.Text, 5, 1) = "g" Then
                            If Label1.Text = "" Then
                                Label1.Text = "O"
                            Else : Label13.Text = Label13.Text + "a"
                            End If
                        Else : Label13.Text = Label13.Text + "a"
                        End If
                    ElseIf Strings.Mid(Label11.Text, 3, 1) = "d" Then
                        If Label3.Text = "" Then
                            Label3.Text = "O"
                        Else : Label13.Text = Label13.Text + "a"
                        End If
                    Else : Label13.Text = Label13.Text + "a"
                    End If
                End If

                If Strings.Mid(Label11.Text, 2, 1) = "b" Then
                    If Strings.Left(Label11.Text, 3) = "c" Or Strings.Left(Label11.Text, 3) = "a" Then
                        If Label9.Text = "" Then
                            Label9.Text = "O"
                        Else : Label13.Text = Label13.Text + "a"
                        End If
                    ElseIf Strings.Left(Label11.Text, 3) = "e" Then
                        If Label7.Text = "" Then
                            Label7.Text = "O"
                        ElseIf Strings.Left(Label11.Text, 5) = "i" And Label9.Text = "" Then
                            Label1.Text = "O"
                        Else : Label13.Text = Label13.Text + "a"
                        End If
                    ElseIf Strings.Left(Label11.Text, 3) = "f" And Label3.Text = "" Then
                        Label7.Text = "O"
                    ElseIf Strings.Left(Label11.Text, 3) = "d" And Label1.Text = "" Then
                        Label9.Text = "O"
                    ElseIf Strings.Left(Label11.Text, 3) = "i" And Strings.Left(Label11.Text, 5) = "d" And Label7.Text = "" Then
                        Label3.Text = "O"
                    ElseIf Strings.Left(Label11.Text, 3) = "g" And Strings.Left(Label11.Text, 5) = "f" And Label9.Text = "" Then
                        Label1.Text = "O"
                    Else : Label13.Text = Label13.Text + "a"
                    End If
                End If

                If Strings.Mid(Label11.Text, 2, 1) = "e" Then
                    If Strings.Left(Label11.Text, 3) = "c" Or Strings.Left(Label11.Text, 3) = "b" Then
                        If Label7.Text = "" Then
                            Label7.Text = "O"
                        Else : Label13.Text = Label13.Text + "a"
                        End If
                    ElseIf Strings.Left(Label11.Text, 3) = "f" Or Strings.Left(Label11.Text, 3) = "d" Or Strings.Left(Label11.Text, 3) = "a" Then
                        If Label9.Text = "" Then
                            Label9.Text = "O"
                        Else : Label13.Text = Label13.Text + "a"
                        End If
                    Else : Label13.Text = Label13.Text + "a"
                    End If
                End If
            End If

        End If


    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If Label1.Text = "" Then
            Label1.Enabled = True
        End If
        If Label2.Text = "" Then
            Label2.Enabled = True
        End If
        If Label3.Text = "" Then
            Label3.Enabled = True
        End If
        If Label4.Text = "" Then
            Label4.Enabled = True
        End If
        If Label5.Text = "" Then
            Label5.Enabled = True
        End If
        If Label6.Text = "" Then
            Label6.Enabled = True
        End If
        If Label7.Text = "" Then
            Label7.Enabled = True
        End If
        If Label8.Text = "" Then
            Label8.Enabled = True
        End If
        If Label9.Text = "" Then
            Label9.Enabled = True
        End If
        If Strings.Len(Label11.Text) <> 9 Then
            labela1.Text = ""
            labela1.Visible = False
            labela2.Text = ""
            labela2.Visible = False
            labela3.Text = ""
            labela3.Visible = False
            labela4.Text = ""
            labela4.Visible = False
            labela5.Text = ""
            labela5.Visible = False
            labela6.Text = ""
            labela6.Visible = False
            labela7.Text = ""
            labela7.Visible = False
            labela8.Text = ""
            labela8.Visible = False
            labela9.Text = ""
            labela9.Visible = False
            labela10.Text = ""
            labela10.Visible = False
            labela11.Text = ""
            labela11.Visible = False
            labela12.Text = ""
            labela12.Visible = False
        End If
        If Strings.Len(Label11.Text) = 9 Then

            If Label2.Text = "O" And Label1.Text = "O" Then
                labela1.Visible = True
                labela1.Text = "O"
            ElseIf Label2.Text = "O" And Label3.Text = "O" Then
                labela4.Visible = True
                labela4.Text = "O"
            ElseIf Label2.Text = "O" And Label5.Text = "O" Then
                labela8.Visible = True
                labela8.Text = "O"
            ElseIf  Label4.Text = "O" And Label1.Text = "O" Then
                labela7.Visible = True
                labela7.Text = "O"
            ElseIf Label4.Text = "O" And Label7.Text = "O" Then
                labela10.Visible = True
                labela10.Text = "O"
            ElseIf Label4.Text = "O" And Label5.Text = "O" Then
                labela2.Visible = True
                labela2.Text = "O"
           elseif Label6.Text = "O" And Label3.Text = "O" Then
                labela9.Visible = True
                labela9.Text = "O"
            ElseIf Label6.Text = "O" And Label9.Text = "O" Then
                labela12.Visible = True
                labela12.Text = "O"
            ElseIf Label6.Text = "O" And Label5.Text = "O" Then
                labela5.Visible = True
                labela5.Text = "O"
            ElseIf Label8.Text = "O" And Label7.Text = "O" Then
                labela3.Visible = True
                labela3.Text = "O"
            ElseIf Label8.Text = "O" And Label9.Text = "O" Then
                labela6.Visible = True
                labela6.Text = "O"
            ElseIf Label8.Text = "O" And Label5.Text = "O" Then
                labela11.Visible = True
                labela11.Text = "O"
            End If
            Timer2.Start()
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label14.Text = ""
        Timer1.Stop()
        Timer2.Stop()
        Label15.Text = Label15.Text + "a"
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Label14.ForeColor = Color.DarkRed
        Label14.Font = New Font("Showcard Gothic", 30)
        Label14.Text = "TROLL!!!!!"
        Timer1.Start()

    End Sub

    Private Sub Label15_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label15.TextChanged
        If Strings.Len(Label11.Text) = 9 Then
            labela1.Text = ""
            labela1.Visible = False
            labela2.Text = ""
            labela2.Visible = False
            labela3.Text = ""
            labela3.Visible = False
            labela4.Text = ""
            labela4.Visible = False
            labela5.Text = ""
            labela5.Visible = False
            labela6.Text = ""
            labela6.Visible = False
            labela7.Text = ""
            labela7.Visible = False
            labela8.Text = ""
            labela8.Visible = False
            labela9.Text = ""
            labela9.Visible = False
            labela10.Text = ""
            labela10.Visible = False
            labela11.Text = ""
            labela11.Visible = False
            labela12.Text = ""
            labela12.Visible = False
            Label1.Text = ""
            Label2.Text = ""
            Label3.Text = ""
            Label4.Text = ""
            Label5.Text = ""
            Label6.Text = ""
            Label7.Text = ""
            Label8.Text = ""
            Label9.Text = ""
            Label11.Text = ""
            Label12.Text = ""
            Label13.Text = ""
            Label14.Text = ""

        End If
    End Sub
End Class
