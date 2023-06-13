Imports System.Collections.ObjectModel
Imports System.Data.SqlClient

Public Class Form5
    Dim connection = New SqlConnection("Server=DESKTOP-GN5TRCK\SQLEXPRESS;Database=LibraryManagementSystem;Integrated Security=True")

    Private Sub DisplayBook()
        connection.Open()
        Dim query = "select*from Borrow"
        Dim adapter As SqlDataAdapter
        Dim cmd = New SqlCommand(query, connection)
        adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        Dim ds = New DataSet()
        adapter.Fill(ds)
        Form4.borrow_grid.DataSource = ds.Tables(0)
        connection.Close()
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click

        If txt_studentid.Text = "" Or txt_bookid.Text = "" Or txt_bookname.Text = "" Or txt_author.Text = "" Or cmb_language.SelectedIndex = -1 Or cmb_status.SelectedIndex = -1 Or mtxt_issue.Text = "" Or mtxt_return.Text = "" Then
            MessageBox.Show("Missing Information", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            connection.Open()
            Dim query = "insert into Borrow values('" & txt_studentid.Text & "', '" & txt_bookname.Text & "','" & txt_bookid.Text & "','" & txt_author.Text & "',
        '" & cmb_status.SelectedItem.ToString & "', '" & cmb_language.SelectedItem.ToString & "','" & mtxt_issue.Text & "','" & mtxt_return.Text & "')"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query.ToString, connection)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Book Saved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            connection.Close()
            DisplayBook()
            Reset()

            Form4.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

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
    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        If MessageBox.Show("This will erase everything! Are you sure?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = vbNo Then
            Exit Sub
        Else
            Reset()
        End If

    End Sub

    Private Sub pic_exit_Click(sender As Object, e As EventArgs) Handles pic_exit.Click
        Form4.Show()
        Me.Hide()
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