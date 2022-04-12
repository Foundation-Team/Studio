Public Class Register
    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        Form1.Show()
        Me.Visible = False
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim d As New DAOClass
        'Dim cmd As New SqlCommand("truncate table login_p", conn)
        If TextBox1.Text = "" Then
            ErrorProvider1.SetError(TextBox1, "Please Enter First Name ")
            TextBox1.Focus()
        ElseIf TextBox2.Text = ""
            ErrorProvider1.SetError(TextBox2, "Please Enter Last Name ")
            TextBox2.Focus()
        ElseIf TextBox3.Text = "" Then
            ErrorProvider1.SetError(TextBox3, "Please Enter Mobile NUmber ")
            TextBox3.Focus()
        ElseIf TextBox4.Text = "" Then
            ErrorProvider1.SetError(TextBox3, "Please Enter Password ")
            TextBox4.Focus()
        ElseIf TextBox5.Text = "" Then
            ErrorProvider1.SetError(TextBox3, "Please Enter Confirm Password ")
            TextBox5.Focus()
        ElseIf IsNumeric(TextBox3.Text) Then
            MsgBox("1 Loop")
            If TextBox4.Text = TextBox5.Text Then
                MsgBox("2 Loop")
                d.adddata("insert into login_p values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox4.Text & "' ,'" & TextBox3.Text & "'  )")
                MessageBox.Show("Register Successful")
                Me.Visible = False
                Form1.Show()
            Else
                ErrorProvider1.SetError(TextBox5, "Password Is Not Match")
                ErrorProvider1.SetError(TextBox4, "Password Is Not Match")
            End If
        End If
    End Sub

End Class