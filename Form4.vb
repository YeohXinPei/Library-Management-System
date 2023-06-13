Imports System.Data.SqlClient
Imports System.Drawing.Text
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class Form4

    Dim key = 0
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
        borrow_grid.DataSource = ds.Tables(0)
        connection.Close()
    End Sub
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayBook()
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Form5.Show()
        Me.Hide()

    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click

        Form6.Show()
        Me.Hide()

    End Sub
    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click

        If MessageBox.Show("This will erase everything! Are you sure?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = vbNo Then
            Exit Sub
        Else
            connection.Open()
            Dim query = " delete from Borrow where student_id = '" & txt_student_id.Text & "'"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query.ToString, connection)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Data deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            connection.Close()
            DisplayBook()
        End If

    End Sub

    Private Sub btn_search_studentid_Click(sender As Object, e As EventArgs) Handles btn_search_studentid.Click


        If txt_student_id.Text = "" Then
            MessageBox.Show("Please Enter Student ID", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            connection.Open()
            Dim query = ("select * from Borrow where student_id = '" & txt_student_id.Text & "'")
            Dim adapter As SqlDataAdapter
            Dim cmd = New SqlCommand(query, connection)
            adapter = New SqlDataAdapter(cmd)
            Dim builder = New SqlCommandBuilder(adapter)
            Dim ds = New DataSet()
            adapter.Fill(ds)
            borrow_grid.DataSource = ds.Tables(0)
            connection.Close()

        End If
    End Sub

    Private Sub pic_exit_Click(sender As Object, e As EventArgs) Handles pic_exit.Click
        Me.Hide()
    End Sub

    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click

        Form2.txt_password.Text = ""
        Form1.Show()
        Me.Hide()

        Form1.txt_username.Text = ""
        Form1.mtxt_password.Text = ""

    End Sub

    Private Sub btn_search_bookid_Click(sender As Object, e As EventArgs) Handles btn_search_bookid.Click

        If txt_book_id.Text = "" Then
            MessageBox.Show("Please Enter Book ID", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else
            connection.Open()
            Dim query = ("select * from Borrow where book_id = '" & txt_book_id.Text & "'")
            Dim adapter As SqlDataAdapter
            Dim cmd = New SqlCommand(query, connection)
            adapter = New SqlDataAdapter(cmd)
            Dim builder = New SqlCommandBuilder(adapter)
            Dim ds = New DataSet()
            adapter.Fill(ds)
            borrow_grid.DataSource = ds.Tables(0)
            connection.Close()

        End If

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        DisplayBook()
    End Sub

    Private Sub txt_student_id_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_student_id.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field only accept numbers", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub txt_book_id_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_book_id.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This field only accept numbers", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub borrow_grid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles borrow_grid.CellContentClick

    End Sub
End Class