Imports System.Collections.ObjectModel
Imports System.Data.SqlClient

Public Class Form7

    Dim connection = New SqlConnection("Server=DESKTOP-GN5TRCK\SQLEXPRESS;Database=LibraryManagementSystem;Integrated Security=True")
    Private Sub DisplayBook()
        connection.Open()
        Dim query = "select Book_name, Book_id, Author, Status, Language, Issue_date, Return_date from Borrow"
        Dim adapter As SqlDataAdapter
        Dim cmd = New SqlCommand(query, connection)
        adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        Dim ds = New DataSet()
        adapter.Fill(ds)
        login_grid.DataSource = ds.Tables(0)
        connection.Close()
    End Sub
    Private Sub btn_search_studentid_Click(sender As Object, e As EventArgs) Handles btn_search_studentid.Click

        If txt_studentid.Text = "" Then
            MessageBox.Show("Please Enter Student ID", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            connection.Open()
            Dim query = ("select * from Borrow where student_id = '" & txt_studentid.Text & "'")
            Dim adapter As SqlDataAdapter
            Dim cmd = New SqlCommand(query, connection)
            adapter = New SqlDataAdapter(cmd)
            Dim builder = New SqlCommandBuilder(adapter)
            Dim ds = New DataSet()
            adapter.Fill(ds)
            login_grid.DataSource = ds.Tables(0)
            connection.Close()

        End If

    End Sub

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayBook()
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click

        connection.Open()
        Dim query = " update Login set Phone_number = '" & txt_phonenumber.Text & "',Password = '" & txt_password.Text & "' where Username = '" & txt_username1.Text & "'"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(query.ToString, connection)
        cmd.ExecuteNonQuery()
        MessageBox.Show("Profile Edited", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        connection.Close()

    End Sub

    Private Sub btn_search_username_Click(sender As Object, e As EventArgs) Handles btn_search_username.Click

        If txt_username1.Text = "" Then
            MessageBox.Show("Please Enter Username", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            connection.Open()
            Dim query = "select*from Login where Username = '" & txt_username1.Text & "'"
            Dim cmd = New SqlCommand(query.ToString, connection)
            cmd.ExecuteNonQuery()
            Dim myReader As SqlDataReader 'reading data
            myReader = cmd.ExecuteReader 'execute sql command

            If myReader.Read() Then
                txt_password.Text = CType(myReader("Password"), String)
                txt_phonenumber.Text = CType(myReader("Phone_number"), String)
                txt_username1.Text = CType(myReader("Username"), String)

            Else
                MessageBox.Show("No Data Found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            connection.Close()

        End If
    End Sub

    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click

        Form1.txt_username.Text = ""
        Form1.mtxt_password.Text = ""

        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub pic_exit_Click(sender As Object, e As EventArgs) Handles pic_exit.Click

        Me.Hide()

    End Sub

    Private Sub txt_studentid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_studentid.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field only accept numbers", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        DisplayBook()
    End Sub
End Class