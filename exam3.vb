Public Class Form1
    Dim a(20) As String
    Dim n As Integer

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        n = InputBox("Enter the limit")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim i As Integer
        ComboBox1.Text = "List of items"
        For i = 1 To n
            a(i) = InputBox("Enter an item to be added to combobox")
            If ComboBox1.Items.Contains(a(i)) Then
                MsgBox("Item already exists")
            Else
                ComboBox1.Items.Add(a(i))
            End If
        Next i
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim item As String
        Dim loc As Integer
        item = InputBox("Enter the item to be removed")
        For i = 1 To n
            If a(i) = item Then
                ComboBox1.Items.Remove(a(i))
                a(i) = -1
                loc = 1
            End If
        Next i
        If loc = 1 Then
            MsgBox("Item has been removed")
        Else
            MsgBox("Item not found")
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim item As String
        Dim loc As Integer = 0
        item = InputBox("Enter the item to be searched")
        For i = 1 To n
            If a(i) = item Then
                loc = 1
            End If
        Next i
        If loc = 1 Then
            MsgBox("Item found")
        Else
            MsgBox("Item not found")
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        ComboBox1.Items.Clear()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        End
    End Sub
End Class
