Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim y As Integer

        For y = 1 To 5
            TextBox1.Text = TextBox1.Text & "$" & vbCr
        Next y
    End Sub
End Class
