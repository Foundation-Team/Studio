Public Class Form1
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Register.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox2.UseSystemPasswordChar = True
        Panel1.Visible = False
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim d As New DAOClass
        Dim obj As SqlClient.SqlDataReader
        obj = d.getdata("select passwd from login_p where mob_no = '" & TextBox1.Text & "'")

        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Please Enter Id and Password ")
        ElseIf IsNumeric(TextBox1.Text) Then
            If obj.Read Then
                If obj.Item(0) = TextBox2.Text Then
                    'MessageBox.Show("Login Successful")
                    Panel1.Visible = True
                    Timer1.Start()
                Else
                    MsgBox("Wrong Password")
                End If
            Else
                MsgBox("Login Unsuccessful")
            End If
        Else
            MessageBox.Show("Please Enter Only Number...!", "Error")
            TextBox1.Focus()
            TextBox1.Clear()
        End If
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If TextBox2.UseSystemPasswordChar = True Then
            TextBox2.UseSystemPasswordChar = False

        ElseIf TextBox2.UseSystemPasswordChar = False Then
            TextBox2.UseSystemPasswordChar = True

        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        Dim d As String
        d = Convert.ToString(ProgressBar1.Value)
        Label9.Text = d + "%"

        If ProgressBar1.Value = 100 Then
            Me.Visible = False
            User.Show()
            Timer1.Enabled = False
        End If
    End Sub
End Class
