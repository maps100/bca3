Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = Nothing Or TextBox2.Text = Nothing Then
            MsgBox("Empty Input. Please Enter Some Data")
            Exit Sub
        End If
        If IsNumeric(TextBox1.Text) = False Or IsNumeric(TextBox2.Text) = False Then
            MsgBox("Non Numeric Input. Please Enter a Number.")
            TextBox1.Clear()
            TextBox1.Focus()
            TextBox2.Clear()
            TextBox2.Focus()
            Exit Sub
        End If
        If Val(TextBox1.Text) < 0 Or Val(TextBox2.Text) <= 0 Then
            MsgBox("Enter a Positive Number")
            TextBox1.Clear()
            TextBox1.Focus()
            TextBox2.Clear()
            TextBox2.Focus()
            Exit Sub
        End If
        Dim a, b, prod, lcm As Integer
        a = Val(TextBox1.Text)
        b = Val(TextBox2.Text)
        prod = a * b
        While a <> b
            If a > b Then a = a - b
            If b > a Then b = b - a
        End While
        lcm = prod \ a
        Label5.Text = a
        Label6.Text = lcm
    End Sub
End Class
