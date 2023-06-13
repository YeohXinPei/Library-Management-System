Imports System.Collections.ObjectModel
Imports System.Data.SqlClient

Public Class Form6
    Private Sub Reset()
        txt_bookid.Text = ""
        txt_bookname.Text = ""
        cmb_language.SelectedIndex = -1
        txt_author.Text = ""
        mtxt_issue.Text = ""
        mtxt_return.Text = ""
        cmb_status.SelectedIndex = -1
        txt_studentid.Text = ""

    End Sub

    Dim connection = New SqlConnection("Server=DESKTOP-GN5TRCK\SQLEXPRESS;Database=LibraryManagementSystem;Integrated Security=True")
    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        If txt_studentid.Text = "" Or txt_bookid.Text = "" Or txt_bookname.Text = "" Or txt_author.Text = "" Or cmb_language.SelectedIndex = -1 Or cmb_status.SelectedIndex = -1 Or mtxt_issue.Text = "" Or mtxt_return.Text = "" Then
            MessageBox.Show("Missing Information", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            connection.Open()
            Dim query = " update Borrow set book_id = '" & txt_bookid.Text & "',book_name = ' " & txt_bookname.Text & "',language = ' " & cmb_language.SelectedItem.ToString & "',
        author = ' " & txt_author.Text & "',issue_date = ' " & mtxt_issue.Text & "',return_date = ' " & mtxt_return.Text & "',status = ' " & cmb_status.SelectedItem.ToString & "' where student_id = '" & txt_studentid.Text & "'"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query.ToString, connection)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Book Edited", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            connection.Close()

            Form4.Show()
            Me.Hide()
            Reset()

        End If

    End Sub

    Private Sub btn_search_studentid_Click(sender As Object, e As EventArgs) Handles btn_search_studentid.Click

        If txt_studentid.Text = "" Then
            MessageBox.Show("Please Enter Stuent ID", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            connection.Open()
            Dim query = "select*from Borrow where student_id = '" & txt_studentid.Text & "'"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query.ToString, connection)
            cmd.ExecuteNonQuery()
            Dim myReader As SqlDataReader 'reading data
            myReader = cmd.ExecuteReader 'execute sql command

            If myReader.Read() Then
                txt_bookname.Text = CType(myReader("Book_name"), String)
                txt_bookid.Text = CType(myReader("Book_id"), String)
                txt_author.Text = CType(myReader("Author"), String)
                cmb_status.Text = CType(myReader("Status"), String)
                cmb_language.Text = CType(myReader("Language"), String)
                mtxt_issue.Text = CType(myReader("Issue_date"), String)
                mtxt_return.Text = CType(myReader("Return_date"), String)
            Else
                MessageBox.Show("No Data Found")
            End If
            connection.Close()

        End If
    End Sub

    Private Sub pic_exit_Click(sender As Object, e As EventArgs) Handles pic_exit.Click
        Form4.Show()
        Me.Hide()
    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txt_studentid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_studentid.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field only accept numbers", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub txt_bookid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_bookid.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field only accept numbers", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class