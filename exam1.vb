Public Class Form1
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label1.Visible = False 
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close() 
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim a, i As Integer
        Dim fact As Long = 1

        If TextBox1.Text = "" Then
            MessageBox.Show("Text Box is Empty", "Error", MessageBoxButtons.OK)
        ElseIf Not IsNumeric(TextBox1.Text) Then

            MessageBox.Show("Please Enter a Number", "Error", MessageBoxButtons.OK)
        Else
            a = Val(TextBox1.Text)

            If a < 0 Then

                MessageBox.Show("Please enter a positive number", "Error", MessageBoxButtons.OK)
            Else

                For i = 1 To a
                    fact *= i
                Next

                Label1.Visible = True
                Label1.Text = "Factorial of " & a & " is: " & fact.ToString()
            End If
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        TextBox1.Text = ""
        Label1.Text = ""
        Label1.Visible = False
    End Sub
End Class
