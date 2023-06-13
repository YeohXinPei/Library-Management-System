<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btn_register = New System.Windows.Forms.Button()
        Me.btn_login = New System.Windows.Forms.Button()
        Me.lbl_admin = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.lbl_login = New System.Windows.Forms.Label()
        Me.lbl_username = New System.Windows.Forms.Label()
        Me.lbl_password = New System.Windows.Forms.Label()
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.mtxt_password = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_register
        '
        Me.btn_register.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btn_register.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_register.ForeColor = System.Drawing.Color.White
        Me.btn_register.Location = New System.Drawing.Point(538, 233)
        Me.btn_register.Name = "btn_register"
        Me.btn_register.Size = New System.Drawing.Size(133, 45)
        Me.btn_register.TabIndex = 28
        Me.btn_register.Text = "&Register"
        Me.btn_register.UseVisualStyleBackColor = False
        '
        'btn_login
        '
        Me.btn_login.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btn_login.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_login.ForeColor = System.Drawing.Color.White
        Me.btn_login.Location = New System.Drawing.Point(400, 233)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(137, 45)
        Me.btn_login.TabIndex = 23
        Me.btn_login.Text = "&Login"
        Me.btn_login.UseVisualStyleBackColor = False
        '
        'lbl_admin
        '
        Me.lbl_admin.AutoSize = True
        Me.lbl_admin.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.lbl_admin.Location = New System.Drawing.Point(502, 292)
        Me.lbl_admin.Name = "lbl_admin"
        Me.lbl_admin.Size = New System.Drawing.Size(67, 25)
        Me.lbl_admin.TabIndex = 29
        Me.lbl_admin.Text = "Admin"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(31, 55)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(325, 318)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 30
        Me.PictureBox3.TabStop = False
        '
        'lbl_login
        '
        Me.lbl_login.AutoSize = True
        Me.lbl_login.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.lbl_login.Font = New System.Drawing.Font("Californian FB", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl_login.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.lbl_login.Location = New System.Drawing.Point(521, 55)
        Me.lbl_login.Name = "lbl_login"
        Me.lbl_login.Size = New System.Drawing.Size(67, 27)
        Me.lbl_login.TabIndex = 31
        Me.lbl_login.Text = "Login"
        '
        'lbl_username
        '
        Me.lbl_username.AutoSize = True
        Me.lbl_username.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_username.Location = New System.Drawing.Point(400, 94)
        Me.lbl_username.Name = "lbl_username"
        Me.lbl_username.Size = New System.Drawing.Size(91, 25)
        Me.lbl_username.TabIndex = 24
        Me.lbl_username.Text = "Username"
        '
        'lbl_password
        '
        Me.lbl_password.AutoSize = True
        Me.lbl_password.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_password.Location = New System.Drawing.Point(404, 159)
        Me.lbl_password.Name = "lbl_password"
        Me.lbl_password.Size = New System.Drawing.Size(87, 25)
        Me.lbl_password.TabIndex = 25
        Me.lbl_password.Text = "Password"
        '
        'txt_username
        '
        Me.txt_username.Location = New System.Drawing.Point(400, 122)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(271, 27)
        Me.txt_username.TabIndex = 26
        '
        'mtxt_password
        '
        Me.mtxt_password.Location = New System.Drawing.Point(400, 187)
        Me.mtxt_password.Mask = "0000"
        Me.mtxt_password.Name = "mtxt_password"
        Me.mtxt_password.Size = New System.Drawing.Size(271, 27)
        Me.mtxt_password.TabIndex = 32
        Me.mtxt_password.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label1.Font = New System.Drawing.Font("Californian FB", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(179, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(390, 34)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Library Manangement System"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(718, 334)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.mtxt_password)
        Me.Controls.Add(Me.lbl_login)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.lbl_admin)
        Me.Controls.Add(Me.btn_register)
        Me.Controls.Add(Me.txt_username)
        Me.Controls.Add(Me.lbl_password)
        Me.Controls.Add(Me.lbl_username)
        Me.Controls.Add(Me.btn_login)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_register As Button
    Friend WithEvents btn_login As Button
    Friend WithEvents lbl_admin As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents lbl_login As Label
    Friend WithEvents lbl_username As Label
    Friend WithEvents lbl_password As Label
    Friend WithEvents txt_username As TextBox
    Friend WithEvents mtxt_password As MaskedTextBox
    Friend WithEvents Label1 As Label
End Class
