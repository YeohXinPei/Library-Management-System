Imports System.Collections.ObjectModel
Imports System.Data.SqlClient

Public Class Form3
    Dim connection = New SqlConnection("Server=DESKTOP-GN5TRCK\SQLEXPRESS;Database=LibraryManagementSystem;Integrated Security=True")
    Public Sub ExecuteQuery(query As String)

        Dim Command As New SqlCommand(query, connection)
        connection.Open()

        Command.ExecuteNonQuery()

        connection.Close()

    End Sub

    Private Sub pic_exit_Click(sender As Object, e As EventArgs) Handles pic_exit.Click

        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub btn_sign_up_Click_1(sender As Object, e As EventArgs) Handles btn_sign_up.Click, btn_signup.Click
        If txt_username.Text = "" Or mtxt_password.Text = "" Or mtxt_phone_number.Text = "" Then
            MessageBox.Show("Missing Information", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim query As String = "INSERT INTO Login (Username, Password, Phone_number)
        VALUES ('" & txt_username.Text & "','" & mtxt_password.Text & "','" & mtxt_phone_number.Text & "')"

            ExecuteQuery(query)

            MessageBox.Show("Data Saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Form1.Show()
            Me.Hide()

        End If

    End Sub

End Class