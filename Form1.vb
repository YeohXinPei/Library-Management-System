Imports System.Data.SqlClient
Imports Microsoft.VisualBasic.Logging
Imports System.Windows

Public Class Form1

    Dim attempt As Integer

    Dim connection As New SqlConnection("Data Source=DESKTOP-GN5TRCK\SQLEXPRESS;Initial Catalog=LibraryManagementSystem;Integrated Security=True")
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click

        If txt_username.Text = "" Then
            MessageBox.Show("Please Enter Username", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf mtxt_password.Text = "" Then
            MessageBox.Show("Please Enter Password", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else

            connection.Open()
            Dim query = "select * from Login where Username ='" + txt_username.Text + "' and Password = '" + mtxt_password.Text + "'"
            Dim cmd = New SqlCommand(query, connection)
            Dim da = New SqlDataAdapter(cmd)
            Dim ds = New DataSet()
            da.Fill(ds)

            Dim a As Integer
            a = ds.Tables(0).Rows.Count

            If a = 0 Then
                attempt = attempt + 1
                MessageBox.Show("Wrong username or password", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                If attempt >= 3 Then
                    MessageBox.Show("Too many tries. Please try again later.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Hide()
                End If
            Else
                Form7.Show()
                Me.Hide()
            End If
        End If
        connection.Close()
    End Sub

    Private Sub btn_register_Click(sender As Object, e As EventArgs) Handles btn_register.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub lbl_admin_Click(sender As Object, e As EventArgs) Handles lbl_admin.Click
        Form2.Show()
        Me.Hide()
    End Sub

End Class
