<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        Me.btn_search_studentid = New System.Windows.Forms.Button()
        Me.txt_studentid = New System.Windows.Forms.TextBox()
        Me.lbl_studentid = New System.Windows.Forms.Label()
        Me.login_grid = New System.Windows.Forms.DataGridView()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.txt_phonenumber = New System.Windows.Forms.TextBox()
        Me.lbl_password = New System.Windows.Forms.Label()
        Me.lbl_phonenumber = New System.Windows.Forms.Label()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_search_username = New System.Windows.Forms.Button()
        Me.txt_username1 = New System.Windows.Forms.TextBox()
        Me.lbl_username1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_logout = New System.Windows.Forms.Button()
        Me.pic_exit = New System.Windows.Forms.PictureBox()
        Me.lbl_welcome_to_library_system = New System.Windows.Forms.Label()
        Me.lbl_admin = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lbl_profile = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.login_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.pic_exit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_search_studentid
        '
        Me.btn_search_studentid.BackColor = System.Drawing.Color.SteelBlue
        Me.btn_search_studentid.Font = New System.Drawing.Font("Calisto MT", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_search_studentid.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_search_studentid.Location = New System.Drawing.Point(501, 117)
        Me.btn_search_studentid.Name = "btn_search_studentid"
        Me.btn_search_studentid.Size = New System.Drawing.Size(98, 34)
        Me.btn_search_studentid.TabIndex = 114
        Me.btn_search_studentid.Text = "Search"
        Me.btn_search_studentid.UseVisualStyleBackColor = False
        '
        'txt_studentid
        '
        Me.txt_studentid.Font = New System.Drawing.Font("Cambria", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_studentid.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt_studentid.Location = New System.Drawing.Point(138, 117)
        Me.txt_studentid.Name = "txt_studentid"
        Me.txt_studentid.Size = New System.Drawing.Size(348, 29)
        Me.txt_studentid.TabIndex = 113
        '
        'lbl_studentid
        '
        Me.lbl_studentid.AutoSize = True
        Me.lbl_studentid.Font = New System.Drawing.Font("Cambria", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_studentid.Location = New System.Drawing.Point(31, 120)
        Me.lbl_studentid.Name = "lbl_studentid"
        Me.lbl_studentid.Size = New System.Drawing.Size(101, 21)
        Me.lbl_studentid.TabIndex = 112
        Me.lbl_studentid.Text = "Student ID :"
        '
        'login_grid
        '
        Me.login_grid.BackgroundColor = System.Drawing.SystemColors.Info
        Me.login_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.login_grid.Location = New System.Drawing.Point(12, 188)
        Me.login_grid.Name = "login_grid"
        Me.login_grid.RowHeadersWidth = 51
        Me.login_grid.RowTemplate.Height = 29
        Me.login_grid.Size = New System.Drawing.Size(652, 391)
        Me.login_grid.TabIndex = 115
        '
        'txt_password
        '
        Me.txt_password.Font = New System.Drawing.Font("Cambria", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_password.Location = New System.Drawing.Point(67, 247)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.Size = New System.Drawing.Size(332, 29)
        Me.txt_password.TabIndex = 119
        '
        'txt_phonenumber
        '
        Me.txt_phonenumber.Font = New System.Drawing.Font("Cambria", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_phonenumber.Location = New System.Drawing.Point(748, 435)
        Me.txt_phonenumber.Name = "txt_phonenumber"
        Me.txt_phonenumber.Size = New System.Drawing.Size(332, 29)
        Me.txt_phonenumber.TabIndex = 118
        '
        'lbl_password
        '
        Me.lbl_password.AutoSize = True
        Me.lbl_password.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.lbl_password.Font = New System.Drawing.Font("Cambria", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_password.Location = New System.Drawing.Point(67, 210)
        Me.lbl_password.Name = "lbl_password"
        Me.lbl_password.Size = New System.Drawing.Size(95, 21)
        Me.lbl_password.TabIndex = 117
        Me.lbl_password.Text = "Password :"
        '
        'lbl_phonenumber
        '
        Me.lbl_phonenumber.AutoSize = True
        Me.lbl_phonenumber.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.lbl_phonenumber.Font = New System.Drawing.Font("Cambria", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_phonenumber.Location = New System.Drawing.Point(748, 402)
        Me.lbl_phonenumber.Name = "lbl_phonenumber"
        Me.lbl_phonenumber.Size = New System.Drawing.Size(139, 21)
        Me.lbl_phonenumber.TabIndex = 116
        Me.lbl_phonenumber.Text = "Phone Number : "
        '
        'btn_edit
        '
        Me.btn_edit.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.btn_edit.Font = New System.Drawing.Font("Calisto MT", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_edit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_edit.Location = New System.Drawing.Point(314, 424)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(120, 43)
        Me.btn_edit.TabIndex = 122
        Me.btn_edit.Text = "Edit"
        Me.btn_edit.UseVisualStyleBackColor = False
        '
        'btn_search_username
        '
        Me.btn_search_username.BackColor = System.Drawing.Color.SteelBlue
        Me.btn_search_username.Font = New System.Drawing.Font("Calisto MT", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_search_username.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_search_username.Location = New System.Drawing.Point(748, 244)
        Me.btn_search_username.Name = "btn_search_username"
        Me.btn_search_username.Size = New System.Drawing.Size(98, 30)
        Me.btn_search_username.TabIndex = 125
        Me.btn_search_username.Text = "Search"
        Me.btn_search_username.UseVisualStyleBackColor = False
        '
        'txt_username1
        '
        Me.txt_username1.Font = New System.Drawing.Font("Cambria", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_username1.Location = New System.Drawing.Point(748, 209)
        Me.txt_username1.Name = "txt_username1"
        Me.txt_username1.Size = New System.Drawing.Size(332, 29)
        Me.txt_username1.TabIndex = 124
        '
        'lbl_username1
        '
        Me.lbl_username1.AutoSize = True
        Me.lbl_username1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.lbl_username1.Font = New System.Drawing.Font("Cambria", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_username1.Location = New System.Drawing.Point(67, 77)
        Me.lbl_username1.Name = "lbl_username1"
        Me.lbl_username1.Size = New System.Drawing.Size(98, 21)
        Me.lbl_username1.TabIndex = 123
        Me.lbl_username1.Text = "Username :"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel1.Controls.Add(Me.btn_logout)
        Me.Panel1.Controls.Add(Me.pic_exit)
        Me.Panel1.Controls.Add(Me.lbl_welcome_to_library_system)
        Me.Panel1.Controls.Add(Me.lbl_admin)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(-1, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1164, 73)
        Me.Panel1.TabIndex = 126
        '
        'btn_logout
        '
        Me.btn_logout.BackColor = System.Drawing.Color.Crimson
        Me.btn_logout.Font = New System.Drawing.Font("Cambria", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_logout.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_logout.Location = New System.Drawing.Point(70, 27)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.Size = New System.Drawing.Size(99, 37)
        Me.btn_logout.TabIndex = 23
        Me.btn_logout.Text = "Logout"
        Me.btn_logout.UseVisualStyleBackColor = False
        '
        'pic_exit
        '
        Me.pic_exit.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.pic_exit.Image = Global.Assignment_LibraryManagementSystem.My.Resources.Resources.exit_full_screen
        Me.pic_exit.Location = New System.Drawing.Point(1091, 3)
        Me.pic_exit.Name = "pic_exit"
        Me.pic_exit.Size = New System.Drawing.Size(70, 70)
        Me.pic_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_exit.TabIndex = 24
        Me.pic_exit.TabStop = False
        '
        'lbl_welcome_to_library_system
        '
        Me.lbl_welcome_to_library_system.AutoSize = True
        Me.lbl_welcome_to_library_system.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lbl_welcome_to_library_system.Font = New System.Drawing.Font("Cascadia Mono", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_welcome_to_library_system.ForeColor = System.Drawing.SystemColors.Window
        Me.lbl_welcome_to_library_system.Location = New System.Drawing.Point(267, 18)
        Me.lbl_welcome_to_library_system.Name = "lbl_welcome_to_library_system"
        Me.lbl_welcome_to_library_system.Size = New System.Drawing.Size(665, 40)
        Me.lbl_welcome_to_library_system.TabIndex = 25
        Me.lbl_welcome_to_library_system.Text = "WELCOME TO LIBRARY MANAGEMENT SYSTEM"
        '
        'lbl_admin
        '
        Me.lbl_admin.AutoSize = True
        Me.lbl_admin.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lbl_admin.Font = New System.Drawing.Font("Californian FB", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl_admin.Location = New System.Drawing.Point(70, 3)
        Me.lbl_admin.Name = "lbl_admin"
        Me.lbl_admin.Size = New System.Drawing.Size(57, 27)
        Me.lbl_admin.TabIndex = 3
        Me.lbl_admin.Text = "User"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.PictureBox1.Image = Global.Assignment_LibraryManagementSystem.My.Resources.Resources.user__4_
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(70, 67)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel2.Controls.Add(Me.lbl_profile)
        Me.Panel2.Controls.Add(Me.btn_edit)
        Me.Panel2.Controls.Add(Me.txt_password)
        Me.Panel2.Controls.Add(Me.lbl_username1)
        Me.Panel2.Controls.Add(Me.lbl_password)
        Me.Panel2.Location = New System.Drawing.Point(681, 91)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(468, 488)
        Me.Panel2.TabIndex = 127
        '
        'lbl_profile
        '
        Me.lbl_profile.AutoSize = True
        Me.lbl_profile.Font = New System.Drawing.Font("Century Schoolbook", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl_profile.Location = New System.Drawing.Point(173, 25)
        Me.lbl_profile.Name = "lbl_profile"
        Me.lbl_profile.Size = New System.Drawing.Size(132, 35)
        Me.lbl_profile.TabIndex = 128
        Me.lbl_profile.Text = "Profile "
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Assignment_LibraryManagementSystem.My.Resources.Resources.refresh
        Me.PictureBox2.Location = New System.Drawing.Point(619, 77)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(45, 45)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 128
        Me.PictureBox2.TabStop = False
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SeaShell
        Me.ClientSize = New System.Drawing.Size(1161, 591)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btn_search_username)
        Me.Controls.Add(Me.txt_username1)
        Me.Controls.Add(Me.txt_phonenumber)
        Me.Controls.Add(Me.lbl_phonenumber)
        Me.Controls.Add(Me.login_grid)
        Me.Controls.Add(Me.btn_search_studentid)
        Me.Controls.Add(Me.txt_studentid)
        Me.Controls.Add(Me.lbl_studentid)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form7"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form7"
        CType(Me.login_grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pic_exit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_search_studentid As Button
    Friend WithEvents txt_studentid As TextBox
    Friend WithEvents lbl_studentid As Label
    Friend WithEvents login_grid As DataGridView
    Friend WithEvents txt_username As TextBox
    Friend WithEvents lbl_username As Label
    Friend WithEvents txt_password As TextBox
    Friend WithEvents txt_phonenumber As TextBox
    Friend WithEvents lbl_password As Label
    Friend WithEvents lbl_phonenumber As Label
    Friend WithEvents btn_edit As Button
    Friend WithEvents btn_search_username As Button
    Friend WithEvents txt_username1 As TextBox
    Friend WithEvents lbl_username1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_logout As Button
    Friend WithEvents pic_exit As PictureBox
    Friend WithEvents lbl_welcome_to_library_system As Label
    Friend WithEvents lbl_admin As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lbl_profile As Label
    Friend WithEvents PictureBox2 As PictureBox
End Class
