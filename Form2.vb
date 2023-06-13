Public Class Form2
    Private Sub lbl_admin_Click(sender As Object, e As EventArgs)
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub btn_login_Click_1(sender As Object, e As EventArgs) Handles btn_login.Click
        If txt_password.Text = "" Then
            MessageBox.Show("Please Enter Password", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf txt_password.Text = "admin123" Then
            Form4.Show()
            Me.Hide()
        Else
            MessageBox.Show("Wrong Password", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub
    Private Sub lbl_admin_Click_1(sender As Object, e As EventArgs) Handles lbl_admin.Click

        Form1.txt_username.Text = ""
        Form1.mtxt_password.Text = ""

        Form1.Show()
        Me.Hide()
    End Sub

End Class