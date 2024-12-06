Public Class Form1
    Dim op As String
    Dim isfno As Boolean = False
    Dim fno, sno, res As Decimal

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtinput.Focus()
        txtinput.Text = "0"
    End Sub

    Private Sub btn0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn0.Click
        removezero(0)
    End Sub

    Private Sub btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click
        removezero(1)
    End Sub

    Private Sub Btn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn2.Click
        removezero(2)
    End Sub

    Private Sub btn3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn3.Click
        removezero(3)
    End Sub

    Private Sub btn4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn4.Click
        removezero(4)
    End Sub

    Private Sub btn5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn5.Click
        removezero(5)
    End Sub

    Private Sub btn6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn6.Click
        removezero(6)
    End Sub

    Private Sub btn7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn7.Click
        removezero(7)
    End Sub

    Private Sub btn8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn8.Click
        removezero(8)
    End Sub

    Private Sub btn9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn9.Click
        removezero(9)
    End Sub

    Private Sub removezero(ByVal num As Integer)
        If txtinput.Text = "0" Then
            txtinput.Text = num
        Else
            txtinput.Text &= num
        End If
    End Sub

    Private Sub dot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dot.Click
        If Not txtinput.Text.Contains(".") Then
            txtinput.Text &= "."
        End If
    End Sub

    Private Sub btnplus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnplus.Click
        op = "+"
        isFirstnumAvailable()
    End Sub

    Private Sub btnminus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnminus.Click
        op = "-"
        isFirstnumAvailable()
    End Sub

    Private Sub btnmul_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnmul.Click
        op = "*"
        isFirstnumAvailable()
    End Sub

    Private Sub btndiv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndiv.Click
        op = "/"
        isFirstnumAvailable()
    End Sub

    Private Sub isFirstnumAvailable()
        If isfno = False Then
            fno = CType(txtinput.Text, Decimal)
            isfno = True
            txtinput.Text = ""
        End If
    End Sub

    Private Sub equal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles equal.Click
        If isfno Then
            If txtinput.Text <> "" Then
                sno = CType(txtinput.Text, Decimal)
            Else
                MsgBox("Enter the number", , "Input")
                txtinput.Focus()
                Exit Sub
            End If
        End If

        Select Case op
            Case "+"
                res = fno + sno
            Case "-"
                res = fno - sno
            Case "*"
                res = fno * sno
            Case "/"
                If sno = 0 Then
                    txtinput.Text = "Division by zero"
                    Exit Sub
                Else
                    res = fno / sno
                End If
        End Select

        txtinput.Text = res
        isfno = False
    End Sub

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        txtinput.Focus()
        txtinput.Text = "0"
        isfno = False
    End Sub

    Private Sub btnoff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnoff.Click
        End
    End Sub
End Class
