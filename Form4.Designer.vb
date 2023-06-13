<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.borrow_grid = New System.Windows.Forms.DataGridView()
        Me.btn_search_bookid = New System.Windows.Forms.Button()
        Me.btn_search_studentid = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_logout = New System.Windows.Forms.Button()
        Me.pic_exit = New System.Windows.Forms.PictureBox()
        Me.lbl_welcome_to_library_system = New System.Windows.Forms.Label()
        Me.lbl_admin = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txt_student_id = New System.Windows.Forms.TextBox()
        Me.txt_book_id = New System.Windows.Forms.TextBox()
        Me.lbl_student_id = New System.Windows.Forms.Label()
        Me.lbl_book_id = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.borrow_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.pic_exit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_edit
        '
        Me.btn_edit.BackColor = System.Drawing.Color.SteelBlue
        Me.btn_edit.Font = New System.Drawing.Font("Calisto MT", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_edit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_edit.Location = New System.Drawing.Point(812, 184)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(120, 43)
        Me.btn_edit.TabIndex = 64
        Me.btn_edit.Text = "Edit"
        Me.btn_edit.UseVisualStyleBackColor = False
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.Color.SteelBlue
        Me.btn_delete.Font = New System.Drawing.Font("Calisto MT", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_delete.Location = New System.Drawing.Point(955, 184)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(120, 43)
        Me.btn_delete.TabIndex = 63
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'btn_add
        '
        Me.btn_add.BackColor = System.Drawing.Color.SteelBlue
        Me.btn_add.Font = New System.Drawing.Font("Calisto MT", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_add.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_add.Location = New System.Drawing.Point(12, 184)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(120, 43)
        Me.btn_add.TabIndex = 65
        Me.btn_add.Text = "Add"
        Me.btn_add.UseVisualStyleBackColor = False
        '
        'borrow_grid
        '
        Me.borrow_grid.BackgroundColor = System.Drawing.SystemColors.Info
        Me.borrow_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.borrow_grid.Location = New System.Drawing.Point(12, 244)
        Me.borrow_grid.Name = "borrow_grid"
        Me.borrow_grid.RowHeadersWidth = 51
        Me.borrow_grid.RowTemplate.Height = 29
        Me.borrow_grid.Size = New System.Drawing.Size(1065, 290)
        Me.borrow_grid.TabIndex = 78
        '
        'btn_search_bookid
        '
        Me.btn_search_bookid.BackColor = System.Drawing.Color.CadetBlue
        Me.btn_search_bookid.Font = New System.Drawing.Font("Calisto MT", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_search_bookid.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_search_bookid.Location = New System.Drawing.Point(889, 108)
        Me.btn_search_bookid.Name = "btn_search_bookid"
        Me.btn_search_bookid.Size = New System.Drawing.Size(82, 34)
        Me.btn_search_bookid.TabIndex = 80
        Me.btn_search_bookid.Text = "Search"
        Me.btn_search_bookid.UseVisualStyleBackColor = False
        '
        'btn_search_studentid
        '
        Me.btn_search_studentid.BackColor = System.Drawing.Color.CadetBlue
        Me.btn_search_studentid.Font = New System.Drawing.Font("Calisto MT", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_search_studentid.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_search_studentid.Location = New System.Drawing.Point(385, 108)
        Me.btn_search_studentid.Name = "btn_search_studentid"
        Me.btn_search_studentid.Size = New System.Drawing.Size(82, 34)
        Me.btn_search_studentid.TabIndex = 79
        Me.btn_search_studentid.Text = "Search"
        Me.btn_search_studentid.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Panel1.Controls.Add(Me.btn_logout)
        Me.Panel1.Controls.Add(Me.pic_exit)
        Me.Panel1.Controls.Add(Me.lbl_welcome_to_library_system)
        Me.Panel1.Controls.Add(Me.lbl_admin)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1157, 65)
        Me.Panel1.TabIndex = 81
        '
        'btn_logout
        '
        Me.btn_logout.BackColor = System.Drawing.Color.Crimson
        Me.btn_logout.Font = New System.Drawing.Font("Cambria", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_logout.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_logout.Location = New System.Drawing.Point(70, 30)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.Size = New System.Drawing.Size(99, 31)
        Me.btn_logout.TabIndex = 23
        Me.btn_logout.Text = "Logout"
        Me.btn_logout.UseVisualStyleBackColor = False
        '
        'pic_exit
        '
        Me.pic_exit.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.pic_exit.Image = Global.Assignment_LibraryManagementSystem.My.Resources.Resources.exit_full_screen
        Me.pic_exit.Location = New System.Drawing.Point(1023, 3)
        Me.pic_exit.Name = "pic_exit"
        Me.pic_exit.Size = New System.Drawing.Size(63, 62)
        Me.pic_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_exit.TabIndex = 24
        Me.pic_exit.TabStop = False
        '
        'lbl_welcome_to_library_system
        '
        Me.lbl_welcome_to_library_system.AutoSize = True
        Me.lbl_welcome_to_library_system.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.lbl_welcome_to_library_system.Font = New System.Drawing.Font("Cascadia Mono", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_welcome_to_library_system.ForeColor = System.Drawing.SystemColors.Window
        Me.lbl_welcome_to_library_system.Location = New System.Drawing.Point(249, 9)
        Me.lbl_welcome_to_library_system.Name = "lbl_welcome_to_library_system"
        Me.lbl_welcome_to_library_system.Size = New System.Drawing.Size(665, 40)
        Me.lbl_welcome_to_library_system.TabIndex = 25
        Me.lbl_welcome_to_library_system.Text = "WELCOME TO LIBRARY MANAGEMENT SYSTEM"
        '
        'lbl_admin
        '
        Me.lbl_admin.AutoSize = True
        Me.lbl_admin.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.lbl_admin.Font = New System.Drawing.Font("Californian FB", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl_admin.Location = New System.Drawing.Point(70, 3)
        Me.lbl_admin.Name = "lbl_admin"
        Me.lbl_admin.Size = New System.Drawing.Size(75, 27)
        Me.lbl_admin.TabIndex = 3
        Me.lbl_admin.Text = "Admin"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.PictureBox1.Image = Global.Assignment_LibraryManagementSystem.My.Resources.Resources.user__4_
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(61, 62)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'txt_student_id
        '
        Me.txt_student_id.Location = New System.Drawing.Point(165, 113)
        Me.txt_student_id.Name = "txt_student_id"
        Me.txt_student_id.Size = New System.Drawing.Size(214, 27)
        Me.txt_student_id.TabIndex = 82
        '
        'txt_book_id
        '
        Me.txt_book_id.Location = New System.Drawing.Point(656, 113)
        Me.txt_book_id.Name = "txt_book_id"
        Me.txt_book_id.Size = New System.Drawing.Size(218, 27)
        Me.txt_book_id.TabIndex = 83
        '
        'lbl_student_id
        '
        Me.lbl_student_id.AutoSize = True
        Me.lbl_student_id.Font = New System.Drawing.Font("Cambria", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_student_id.Location = New System.Drawing.Point(60, 116)
        Me.lbl_student_id.Name = "lbl_student_id"
        Me.lbl_student_id.Size = New System.Drawing.Size(101, 21)
        Me.lbl_student_id.TabIndex = 84
        Me.lbl_student_id.Text = "Student ID :"
        '
        'lbl_book_id
        '
        Me.lbl_book_id.AutoSize = True
        Me.lbl_book_id.Font = New System.Drawing.Font("Cambria", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_book_id.Location = New System.Drawing.Point(568, 116)
        Me.lbl_book_id.Name = "lbl_book_id"
        Me.lbl_book_id.Size = New System.Drawing.Size(81, 21)
        Me.lbl_book_id.TabIndex = 85
        Me.lbl_book_id.Text = "Book ID :"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Assignment_LibraryManagementSystem.My.Resources.Resources.refresh
        Me.PictureBox2.Location = New System.Drawing.Point(1032, 71)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(45, 45)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 87
        Me.PictureBox2.TabStop = False
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(1087, 546)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.lbl_book_id)
        Me.Controls.Add(Me.lbl_student_id)
        Me.Controls.Add(Me.txt_book_id)
        Me.Controls.Add(Me.txt_student_id)
        Me.Controls.Add(Me.btn_search_bookid)
        Me.Controls.Add(Me.btn_search_studentid)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.borrow_grid)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.btn_delete)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form4"
        CType(Me.borrow_grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pic_exit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_bookname As TextBox
    Friend WithEvents txt_bookid As TextBox
    Friend WithEvents lbl_bookname As Label
    Friend WithEvents lbl_bookid As Label
    Friend WithEvents txt_author As TextBox
    Friend WithEvents lbl_author As Label
    Friend WithEvents btn_edit As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_add As Button
    Friend WithEvents lbl_language As Label
    Friend WithEvents lbl_rerturn_date As Label
    Friend WithEvents lbl_issue_date As Label
    Friend WithEvents cmb_language As ComboBox
    Friend WithEvents lbl_status As Label
    Friend WithEvents cmb_status As ComboBox
    Friend WithEvents txt_studentid As TextBox
    Friend WithEvents lbl_studentid As Label
    Friend WithEvents borrow_grid As DataGridView
    Friend WithEvents mtxt_issuedate As MaskedTextBox
    Friend WithEvents mtxt_returndate As MaskedTextBox
    Friend WithEvents date1 As DateTimePicker
    Friend WithEvents date2 As DateTimePicker
    Friend WithEvents issue As TextBox
    Friend WithEvents returnbox As TextBox
    Friend WithEvents mtxt_issue As MaskedTextBox
    Friend WithEvents mtxt_return As MaskedTextBox
    Friend WithEvents btn_search_bookid As Button
    Friend WithEvents btn_search_studentid As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_logout As Button
    Friend WithEvents pic_exit As PictureBox
    Friend WithEvents lbl_welcome_to_library_system As Label
    Friend WithEvents lbl_admin As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txt_student_id As TextBox
    Friend WithEvents txt_book_id As TextBox
    Friend WithEvents lbl_student_id As Label
    Friend WithEvents lbl_book_id As Label
    Friend WithEvents btn_refresh As Button
    Friend WithEvents PictureBox2 As PictureBox
End Class
