Public Class Form1
    Dim quiz(5) As String
    Dim Score As Integer = 0

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        GroupBox1.Visible = False
        GroupBox2.Visible = False
        GroupBox3.Visible = False
        GroupBox4.Visible = False
        GroupBox5.Visible = False
        GroupBox6.Visible = False
        quiz(0) = "1. Who is the father of computer?"
        quiz(1) = "2. _______ keyword is used to declare dynamic array"
        quiz(2) = "3. Who is the CEO of Google?"
        quiz(3) = "4. Which one of the following is a loop construct that will always be executed once?"
        quiz(4) = "5. What is the full form of USB?"
        BtnScore.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Label1.Visible = True
        Label1.Text = quiz(0)
        GroupBox1.Visible = True
        GroupBox2.Visible = True
        Button1.Enabled = False
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Label1.Text = quiz(1)
        GroupBox1.Visible = True
        GroupBox3.Visible = True
        GroupBox2.Visible = False
        Button2.Enabled = False
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Label1.Text = quiz(2)
        GroupBox1.Visible = True
        GroupBox4.Visible = True
        GroupBox2.Visible = False
        GroupBox3.Visible = False
        Button3.Enabled = False
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Label1.Text = quiz(3)
        GroupBox1.Visible = True
        GroupBox5.Visible = True
        GroupBox4.Visible = False
        GroupBox3.Visible = False
        GroupBox2.Visible = False
        Button4.Enabled = False
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Label1.Text = quiz(4)
        GroupBox1.Visible = True
        GroupBox6.Visible = True
        GroupBox2.Visible = False
        GroupBox3.Visible = False
        GroupBox4.Visible = False
        GroupBox5.Visible = False
        Button5.Enabled = False
    End Sub

    Private Sub BtnScore_Click(sender As System.Object, e As System.EventArgs) Handles BtnScore.Click
        MsgBox("Your score is " + Str(Score))
        BtnScore.Enabled = False
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        Score = 0
        GroupBox1.Visible = False
        GroupBox2.Visible = False
        GroupBox3.Visible = False
        GroupBox4.Visible = False
        GroupBox5.Visible = False
        GroupBox6.Visible = False
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
        Button5.Enabled = True
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False
        RadioButton5.Checked = False
        RadioButton6.Checked = False
        RadioButton7.Checked = False
        RadioButton8.Checked = False
        RadioButton9.Checked = False
        RadioButton10.Checked = False
        RadioButton11.Checked = False
        RadioButton12.Checked = False
        RadioButton13.Checked = False
        RadioButton14.Checked = False
        RadioButton15.Checked = False
        RadioButton16.Checked = False
        RadioButton17.Checked = False
        RadioButton18.Checked = False
        RadioButton19.Checked = False
        RadioButton20.Checked = False
        Label1.Text = ""
    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        Dim ans As String
        ans = MsgBox("You are exiting from Quiz program..Are You Sure?", MsgBoxStyle.YesNo, "Quit")
        If ans = vbYes Then
            End
        End If
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        If RadioButton3.Checked Then Score = 20
        If RadioButton7.Checked Then Score += 20
        If RadioButton11.Checked Then Score += 20
        If RadioButton16.Checked Then Score += 20
        If RadioButton20.Checked Then Score += 20
        BtnScore.Enabled = True
    End Sub
End Class
