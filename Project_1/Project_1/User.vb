Public Class User
    Private Sub User_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = Form1.TextBox1.Text
        TextBox2.Text = Form1.TextBox2.Text
    End Sub
End Class