Public Class Form1
    Dim A As Integer
    Dim b As String
    Dim RND As New Random

    Dim box() As Integer = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}

    Private Sub Form1_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        b = MsgBox("Are you sure you want to give up?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Give up?")
        If b = MsgBoxResult.No Then
            Form2.Visible = True
        End If

    End Sub

    Private Sub Label_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click, Label2.Click, Label3.Click, Label4.Click, Label5.Click, Label6.Click, Label7.Click, Label8.Click, Label9.Click
        Dim clickedLabel = TryCast(sender, Label)

        If clickedLabel IsNot Nothing Then
            If clickedLabel.Text = "" Then
                clickedLabel.Text = "X"
            End If
            Label10.Text = Label10.Text + "a"
            clickedLabel.Enabled = False
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim coward As Boolean = False

        If (box(0) + box(4) + box(8) = 4) And box(0) <> 1 And box(4) <> 1 And box(8) <> 1 Then
            coward = True
        ElseIf (box(2) + box(4) + box(6) = 4) And box(2) <> 1 And box(4) <> 1 And box(6) <> 1 Then
            coward = True
        Else
            For i As Integer = 0 To 2
                If (box(i) + box(i + 3) + box(i + 6) = 4) And box(i) <> 1 And box(i + 3) <> 1 And box(i + 6) <> 1 Then
                    coward = True
                ElseIf (box(3 * i) + box(3 * i + 1) + box(3 * i + 2) = 4) And box(3 * i) <> 1 And box(3 * i + 1) <> 1 And box(3 * i + 2) <> 1 Then
                    coward = True
                End If
            Next
        End If

        If coward Then
            b = MsgBox("Finish this match! Don't be a coward!", MsgBoxStyle.Exclamation, MsgBoxStyle.OkOnly)
        Else
            Form2.Visible = True
            box = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
        End If
        If Strings.Len(Label11.Text) <> 9 Then
            For i = 1 To 12
                Dim Label As Label
                Label = Me.Controls("Labela" & i)
                Label.Text = ""
                Label.Visible = False
            Next
        End If
    End Sub

    Private Sub Label_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label1.TextChanged, Label2.TextChanged, Label3.TextChanged, Label4.TextChanged, Label5.TextChanged, Label6.TextChanged, Label7.TextChanged, Label8.TextChanged, Label9.TextChanged
        Dim ChangedLabel = TryCast(sender, Label)

        If ChangedLabel IsNot Nothing Then
            Label11.Text += Chr(96 + Replace(ChangedLabel.Name, "Label", ""))
            If ChangedLabel.Text = "X" Then
                box(Replace(ChangedLabel.Name, "Label", "") - 1) = 1
            ElseIf ChangedLabel.Text = "O" Then
                box(Replace(ChangedLabel.Name, "Label", "") - 1) = 2
            End If
        End If
    End Sub

    Private Sub Label13_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label13.TextChanged
        A = RND.Next(1, 9)
        Label12.Text = Str(A)

        Dim rndLabel As Label
        rndLabel = Me.Controls("Label" & A)

        If rndLabel.Text = "" Then
            rndLabel.Text = "O"
        Else
            Label13.Text = Label13.Text + "a"
        End If
    End Sub

    Private Sub Label10_TextChanged1(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label10.TextChanged
        Dim win As Short = 0

        If box(0) = 1 And box(4) = 1 And box(8) = 1 Then
            win = 1
        ElseIf box(2) = 1 And box(4) = 1 And box(6) = 1 Then
            win = 1
        Else
            For i As Integer = 0 To 2
                If box(i) = 1 And box(i + 3) = 1 And box(i + 6) = 1 Then
                    win = 1
                ElseIf box(3 * i) = 1 And box(3 * i + 1) = 1 And box(3 * i + 2) = 1 Then
                    win = 1
                End If
            Next
        End If
        If win <> 1 Then
            If Label1.Text = "O" And Label2.Text = "O" And Label3.Text = "" Then
                Label3.Text = "O"
                win = 2

            ElseIf Label1.Text = "O" And Label3.Text = "O" And Label2.Text = "" Then
                Label2.Text = "O"
                win = 2

            ElseIf Label2.Text = "O" And Label3.Text = "O" And Label1.Text = "" Then
                Label1.Text = "O"
                win = 2


            ElseIf Label4.Text = "O" And Label5.Text = "O" And Label6.Text = "" Then
                Label6.Text = "O"
                win = 2

            ElseIf Label4.Text = "O" And Label6.Text = "O" And Label5.Text = "" Then
                Label5.Text = "O"
                win = 2

            ElseIf Label5.Text = "O" And Label6.Text = "O" And Label4.Text = "" Then
                Label4.Text = "O"
                win = 2


            ElseIf Label7.Text = "O" And Label8.Text = "O" And Label9.Text = "" Then
                Label9.Text = "O"
                win = 2

            ElseIf Label7.Text = "O" And Label9.Text = "O" And Label8.Text = "" Then
                Label8.Text = "O"
                win = 2

            ElseIf Label8.Text = "O" And Label9.Text = "O" And Label7.Text = "" Then
                Label7.Text = "O"
                win = 2


            ElseIf Label1.Text = "O" And Label4.Text = "O" And Label7.Text = "" Then
                Label7.Text = "O"
                win = 2

            ElseIf Label1.Text = "O" And Label7.Text = "O" And Label4.Text = "" Then
                Label4.Text = "O"
                win = 2

            ElseIf Label4.Text = "O" And Label7.Text = "O" And Label1.Text = "" Then
                Label1.Text = "O"
                win = 2


            ElseIf Label2.Text = "O" And Label5.Text = "O" And Label8.Text = "" Then
                Label8.Text = "O"
                win = 2

            ElseIf Label2.Text = "O" And Label8.Text = "O" And Label5.Text = "" Then
                Label5.Text = "O"
                win = 2

            ElseIf Label5.Text = "O" And Label8.Text = "O" And Label2.Text = "" Then
                Label2.Text = "O"
                win = 2


            ElseIf Label3.Text = "O" And Label6.Text = "O" And Label9.Text = "" Then
                Label9.Text = "O"
                win = 2

            ElseIf Label3.Text = "O" And Label9.Text = "O" And Label6.Text = "" Then
                Label6.Text = "O"
                win = 2

            ElseIf Label6.Text = "O" And Label9.Text = "O" And Label3.Text = "" Then
                Label3.Text = "O"
                win = 2


            ElseIf Label1.Text = "O" And Label5.Text = "O" And Label9.Text = "" Then
                Label9.Text = "O"
                win = 2

            ElseIf Label1.Text = "O" And Label9.Text = "O" And Label5.Text = "" Then
                Label5.Text = "O"
                win = 2

            ElseIf Label5.Text = "O" And Label9.Text = "O" And Label1.Text = "" Then
                Label1.Text = "O"
                win = 2


            ElseIf Label7.Text = "O" And Label5.Text = "O" And Label3.Text = "" Then
                Label3.Text = "O"
                win = 2

            ElseIf Label7.Text = "O" And Label3.Text = "O" And Label5.Text = "" Then
                Label5.Text = "O"
                win = 2

            ElseIf Label5.Text = "O" And Label3.Text = "O" And Label7.Text = "" Then
                Label7.Text = "O"
                win = 2
            End If
        End If

        If win = 1 Then
            b = MsgBox("You win!", MsgBoxStyle.OkOnly, "Congratulation!")
        ElseIf win = 2 Then
            b = MsgBox("Try again later.", MsgBoxStyle.OkOnly, "You lose!")
        End If

        If b = MsgBoxResult.Ok Then
            b = 0
            For i = 1 To 9
                Dim Label As Label
                Label = Me.Controls("Label" & i)
                Label.Text = ""
                Label.Visible = True
            Next
            box = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
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
        For i = 1 To 9
            Dim Label As Label
            Label = Me.Controls("Label" & i)
            If Label.Text = "" Then
                Label.Enabled = True
            End If
        Next
        If Strings.Len(Label11.Text) <> 9 Then
            For i = 1 To 12
                Dim Label As Label
                Label = Me.Controls("Labela" & i)
                Label.Text = ""
                Label.Visible = False
            Next
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
            ElseIf Label4.Text = "O" And Label1.Text = "O" Then
                labela7.Visible = True
                labela7.Text = "O"
            ElseIf Label4.Text = "O" And Label7.Text = "O" Then
                labela10.Visible = True
                labela10.Text = "O"
            ElseIf Label4.Text = "O" And Label5.Text = "O" Then
                labela2.Visible = True
                labela2.Text = "O"
            ElseIf Label6.Text = "O" And Label3.Text = "O" Then
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
            box = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
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
            For i = 1 To 12
                Dim Label As Label
                Label = Me.Controls("Labela" & i)
                Label.Text = ""
                Label.Visible = False
            Next
            For i = 1 To 14
                Dim Label As Label
                Label = Me.Controls("Label" & i)
                Label.Text = ""
            Next
        End If
    End Sub
End Class
