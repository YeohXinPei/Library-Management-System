<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.lbl_admin = New System.Windows.Forms.Label()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.lbl_password = New System.Windows.Forms.Label()
        Me.btn_login = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lbl_login = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_admin
        '
        Me.lbl_admin.AutoSize = True
        Me.lbl_admin.Font = New System.Drawing.Font("Segoe UI Semibold", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.lbl_admin.Location = New System.Drawing.Point(336, 290)
        Me.lbl_admin.Name = "lbl_admin"
        Me.lbl_admin.Size = New System.Drawing.Size(50, 25)
        Me.lbl_admin.TabIndex = 38
        Me.lbl_admin.Text = "User"
        '
        'txt_password
        '
        Me.txt_password.Location = New System.Drawing.Point(217, 187)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.Size = New System.Drawing.Size(282, 27)
        Me.txt_password.TabIndex = 37
        Me.txt_password.UseSystemPasswordChar = True
        '
        'lbl_password
        '
        Me.lbl_password.AutoSize = True
        Me.lbl_password.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_password.Location = New System.Drawing.Point(298, 140)
        Me.lbl_password.Name = "lbl_password"
        Me.lbl_password.Size = New System.Drawing.Size(110, 31)
        Me.lbl_password.TabIndex = 36
        Me.lbl_password.Text = "Password"
        '
        'btn_login
        '
        Me.btn_login.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btn_login.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_login.ForeColor = System.Drawing.Color.White
        Me.btn_login.Location = New System.Drawing.Point(195, 232)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(329, 45)
        Me.btn_login.TabIndex = 35
        Me.btn_login.Text = "Login"
        Me.btn_login.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Assignment_LibraryManagementSystem.My.Resources.Resources.lock
        Me.PictureBox2.Location = New System.Drawing.Point(325, 75)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(52, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 34
        Me.PictureBox2.TabStop = False
        '
        'lbl_login
        '
        Me.lbl_login.AutoSize = True
        Me.lbl_login.Font = New System.Drawing.Font("Californian FB", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl_login.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.lbl_login.Location = New System.Drawing.Point(256, 22)
        Me.lbl_login.Name = "lbl_login"
        Me.lbl_login.Size = New System.Drawing.Size(184, 34)
        Me.lbl_login.TabIndex = 33
        Me.lbl_login.Text = " Admin Login"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(718, 334)
        Me.Controls.Add(Me.lbl_admin)
        Me.Controls.Add(Me.txt_password)
        Me.Controls.Add(Me.lbl_password)
        Me.Controls.Add(Me.btn_login)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.lbl_login)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_admin As Label
    Friend WithEvents txt_password As TextBox
    Friend WithEvents lbl_password As Label
    Friend WithEvents btn_login As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lbl_login As Label
End Class
