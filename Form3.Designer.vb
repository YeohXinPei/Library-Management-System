<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.mtxt_phone_number = New System.Windows.Forms.MaskedTextBox()
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.btn_signup = New System.Windows.Forms.Button()
        Me.lbl_username = New System.Windows.Forms.Label()
        Me.lbl_password = New System.Windows.Forms.Label()
        Me.lbl_phone_number = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pic_exit = New System.Windows.Forms.PictureBox()
        Me.lbl_registration = New System.Windows.Forms.Label()
        Me.mtxt_password = New System.Windows.Forms.MaskedTextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.pic_exit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(795, 191)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(250, 27)
        Me.DateTimePicker1.TabIndex = 40
        '
        'mtxt_phone_number
        '
        Me.mtxt_phone_number.Location = New System.Drawing.Point(50, 280)
        Me.mtxt_phone_number.Mask = "000-0000 0000"
        Me.mtxt_phone_number.Name = "mtxt_phone_number"
        Me.mtxt_phone_number.Size = New System.Drawing.Size(289, 27)
        Me.mtxt_phone_number.TabIndex = 48
        '
        'txt_username
        '
        Me.txt_username.Font = New System.Drawing.Font("Cambria", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_username.Location = New System.Drawing.Point(46, 115)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(293, 29)
        Me.txt_username.TabIndex = 46
        '
        'btn_signup
        '
        Me.btn_signup.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_signup.Font = New System.Drawing.Font("Cambria", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_signup.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btn_signup.Location = New System.Drawing.Point(63, 351)
        Me.btn_signup.Name = "btn_signup"
        Me.btn_signup.Size = New System.Drawing.Size(242, 39)
        Me.btn_signup.TabIndex = 45
        Me.btn_signup.Text = "Sign Up"
        Me.btn_signup.UseVisualStyleBackColor = False
        '
        'lbl_username
        '
        Me.lbl_username.AutoSize = True
        Me.lbl_username.Font = New System.Drawing.Font("Cambria", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_username.Location = New System.Drawing.Point(46, 81)
        Me.lbl_username.Name = "lbl_username"
        Me.lbl_username.Size = New System.Drawing.Size(93, 21)
        Me.lbl_username.TabIndex = 44
        Me.lbl_username.Text = "Username "
        '
        'lbl_password
        '
        Me.lbl_password.AutoSize = True
        Me.lbl_password.Font = New System.Drawing.Font("Cambria", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_password.Location = New System.Drawing.Point(46, 159)
        Me.lbl_password.Name = "lbl_password"
        Me.lbl_password.Size = New System.Drawing.Size(90, 21)
        Me.lbl_password.TabIndex = 43
        Me.lbl_password.Text = "Password "
        '
        'lbl_phone_number
        '
        Me.lbl_phone_number.AutoSize = True
        Me.lbl_phone_number.Font = New System.Drawing.Font("Cambria", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_phone_number.Location = New System.Drawing.Point(46, 240)
        Me.lbl_phone_number.Name = "lbl_phone_number"
        Me.lbl_phone_number.Size = New System.Drawing.Size(126, 21)
        Me.lbl_phone_number.TabIndex = 42
        Me.lbl_phone_number.Text = "Phone Number"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SlateGray
        Me.Panel1.Controls.Add(Me.pic_exit)
        Me.Panel1.Controls.Add(Me.lbl_registration)
        Me.Panel1.Location = New System.Drawing.Point(-3, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(394, 51)
        Me.Panel1.TabIndex = 41
        '
        'pic_exit
        '
        Me.pic_exit.Image = Global.Assignment_LibraryManagementSystem.My.Resources.Resources.exit_full_screen
        Me.pic_exit.Location = New System.Drawing.Point(338, 0)
        Me.pic_exit.Name = "pic_exit"
        Me.pic_exit.Size = New System.Drawing.Size(53, 51)
        Me.pic_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_exit.TabIndex = 3
        Me.pic_exit.TabStop = False
        '
        'lbl_registration
        '
        Me.lbl_registration.AutoSize = True
        Me.lbl_registration.Font = New System.Drawing.Font("Tahoma", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl_registration.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_registration.Location = New System.Drawing.Point(90, 8)
        Me.lbl_registration.Name = "lbl_registration"
        Me.lbl_registration.Size = New System.Drawing.Size(188, 34)
        Me.lbl_registration.TabIndex = 2
        Me.lbl_registration.Text = "Registration"
        '
        'mtxt_password
        '
        Me.mtxt_password.Location = New System.Drawing.Point(46, 195)
        Me.mtxt_password.Mask = "0000"
        Me.mtxt_password.Name = "mtxt_password"
        Me.mtxt_password.Size = New System.Drawing.Size(293, 27)
        Me.mtxt_password.TabIndex = 49
        Me.mtxt_password.UseSystemPasswordChar = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(390, 421)
        Me.Controls.Add(Me.mtxt_password)
        Me.Controls.Add(Me.mtxt_phone_number)
        Me.Controls.Add(Me.txt_username)
        Me.Controls.Add(Me.btn_signup)
        Me.Controls.Add(Me.lbl_username)
        Me.Controls.Add(Me.lbl_password)
        Me.Controls.Add(Me.lbl_phone_number)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form3"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pic_exit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents mtxt_phone_number As MaskedTextBox
    Friend WithEvents txt_username As TextBox
    Friend WithEvents btn_sign_up As Button
    Friend WithEvents lbl_username As Label
    Friend WithEvents lbl_password As Label
    Friend WithEvents lbl_phone_number As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pic_exit As PictureBox
    Friend WithEvents lbl_registration As Label
    Friend WithEvents btn_signup As Button
    Friend WithEvents mtxt_password As MaskedTextBox
End Class
