Public Class Form1
    Dim c As Integer 
    Dim path As String 

    Private Sub Form1_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Activated
        c = 1
        path = "C:\Users\admin\Documents\d\" 
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dt As DateTime = Now()
        
        TextBox1.Text = dt.ToString("dd-MM-yyyy") 
        TextBox2.Text = dt.ToString("HH:mm:ss")

        Timer1.Start()

        If dt.Hour < 6 Then
            TextBox3.Text = "Good Morning"
        ElseIf dt.Hour < 18 Then
            TextBox3.Text = "Good Afternoon"
        Else
            TextBox3.Text = "Good Evening"
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Try

            PictureBox1.Image = Image.FromFile(path & c.ToString() & ".jpg")
            c += 1
            If c > 5 Then c = 1 
        Catch ex As Exception
            MessageBox.Show("Error loading image: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub colorchange()
        TextBox3.BackColor = Color.FromArgb(HScrollBar1.Value, HScrollBar2.Value, HScrollBar3.Value)
    End Sub

    Private Sub HScrollBar1_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles HScrollBar1.Scroll
        colorchange()
    End Sub

    Private Sub HScrollBar2_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles HScrollBar2.Scroll
        colorchange()
    End Sub

    Private Sub HScrollBar3_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles HScrollBar3.Scroll
        colorchange()
    End Sub

    Private Sub VScrollBar1_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles VScrollBar1.Scroll
        TextBox3.Font = New Font(TextBox3.Font.FontFamily, VScrollBar1.Value)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        End
    End Sub
End Class
