<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Me.mtxt_return = New System.Windows.Forms.MaskedTextBox()
        Me.mtxt_issue = New System.Windows.Forms.MaskedTextBox()
        Me.txt_studentid = New System.Windows.Forms.TextBox()
        Me.lbl_studentid = New System.Windows.Forms.Label()
        Me.cmb_status = New System.Windows.Forms.ComboBox()
        Me.lbl_status = New System.Windows.Forms.Label()
        Me.cmb_language = New System.Windows.Forms.ComboBox()
        Me.lbl_rerturn_date = New System.Windows.Forms.Label()
        Me.lbl_issue_date = New System.Windows.Forms.Label()
        Me.lbl_language = New System.Windows.Forms.Label()
        Me.txt_author = New System.Windows.Forms.TextBox()
        Me.lbl_author = New System.Windows.Forms.Label()
        Me.txt_bookname = New System.Windows.Forms.TextBox()
        Me.txt_bookid = New System.Windows.Forms.TextBox()
        Me.lbl_bookname = New System.Windows.Forms.Label()
        Me.lbl_bookid = New System.Windows.Forms.Label()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.btn_search_studentid = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pic_exit = New System.Windows.Forms.PictureBox()
        Me.lbl_registration = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.pic_exit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mtxt_return
        '
        Me.mtxt_return.Location = New System.Drawing.Point(514, 329)
        Me.mtxt_return.Mask = "00/00/0000"
        Me.mtxt_return.Name = "mtxt_return"
        Me.mtxt_return.Size = New System.Drawing.Size(178, 27)
        Me.mtxt_return.TabIndex = 109
        Me.mtxt_return.ValidatingType = GetType(Date)
        '
        'mtxt_issue
        '
        Me.mtxt_issue.Location = New System.Drawing.Point(514, 238)
        Me.mtxt_issue.Mask = "00/00/0000"
        Me.mtxt_issue.Name = "mtxt_issue"
        Me.mtxt_issue.Size = New System.Drawing.Size(178, 27)
        Me.mtxt_issue.TabIndex = 108
        Me.mtxt_issue.ValidatingType = GetType(Date)
        '
        'txt_studentid
        '
        Me.txt_studentid.Font = New System.Drawing.Font("Cambria", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_studentid.Location = New System.Drawing.Point(125, 96)
        Me.txt_studentid.Name = "txt_studentid"
        Me.txt_studentid.Size = New System.Drawing.Size(504, 29)
        Me.txt_studentid.TabIndex = 107
        '
        'lbl_studentid
        '
        Me.lbl_studentid.AutoSize = True
        Me.lbl_studentid.Font = New System.Drawing.Font("Cambria", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_studentid.Location = New System.Drawing.Point(18, 99)
        Me.lbl_studentid.Name = "lbl_studentid"
        Me.lbl_studentid.Size = New System.Drawing.Size(101, 21)
        Me.lbl_studentid.TabIndex = 106
        Me.lbl_studentid.Text = "Student ID :"
        '
        'cmb_status
        '
        Me.cmb_status.FormattingEnabled = True
        Me.cmb_status.Items.AddRange(New Object() {"Borrowed", "Returning"})
        Me.cmb_status.Location = New System.Drawing.Point(169, 418)
        Me.cmb_status.Name = "cmb_status"
        Me.cmb_status.Size = New System.Drawing.Size(174, 28)
        Me.cmb_status.TabIndex = 105
        '
        'lbl_status
        '
        Me.lbl_status.AutoSize = True
        Me.lbl_status.Font = New System.Drawing.Font("Cambria", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_status.Location = New System.Drawing.Point(38, 420)
        Me.lbl_status.Name = "lbl_status"
        Me.lbl_status.Size = New System.Drawing.Size(67, 21)
        Me.lbl_status.TabIndex = 104
        Me.lbl_status.Text = "Status :"
        '
        'cmb_language
        '
        Me.cmb_language.FormattingEnabled = True
        Me.cmb_language.Items.AddRange(New Object() {"Malay", "English", "Chinese", "Tamil"})
        Me.cmb_language.Location = New System.Drawing.Point(514, 161)
        Me.cmb_language.Name = "cmb_language"
        Me.cmb_language.Size = New System.Drawing.Size(174, 28)
        Me.cmb_language.TabIndex = 103
        '
        'lbl_rerturn_date
        '
        Me.lbl_rerturn_date.AutoSize = True
        Me.lbl_rerturn_date.Font = New System.Drawing.Font("Cambria", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_rerturn_date.Location = New System.Drawing.Point(397, 330)
        Me.lbl_rerturn_date.Name = "lbl_rerturn_date"
        Me.lbl_rerturn_date.Size = New System.Drawing.Size(112, 21)
        Me.lbl_rerturn_date.TabIndex = 102
        Me.lbl_rerturn_date.Text = "Return Date :"
        '
        'lbl_issue_date
        '
        Me.lbl_issue_date.AutoSize = True
        Me.lbl_issue_date.Font = New System.Drawing.Font("Cambria", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_issue_date.Location = New System.Drawing.Point(397, 238)
        Me.lbl_issue_date.Name = "lbl_issue_date"
        Me.lbl_issue_date.Size = New System.Drawing.Size(100, 21)
        Me.lbl_issue_date.TabIndex = 101
        Me.lbl_issue_date.Text = "Issue Date :"
        '
        'lbl_language
        '
        Me.lbl_language.AutoSize = True
        Me.lbl_language.Font = New System.Drawing.Font("Cambria", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_language.Location = New System.Drawing.Point(397, 163)
        Me.lbl_language.Name = "lbl_language"
        Me.lbl_language.Size = New System.Drawing.Size(98, 21)
        Me.lbl_language.TabIndex = 100
        Me.lbl_language.Text = "Language : "
        '
        'txt_author
        '
        Me.txt_author.Font = New System.Drawing.Font("Cambria", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_author.Location = New System.Drawing.Point(169, 330)
        Me.txt_author.Name = "txt_author"
        Me.txt_author.Size = New System.Drawing.Size(174, 29)
        Me.txt_author.TabIndex = 99
        '
        'lbl_author
        '
        Me.lbl_author.AutoSize = True
        Me.lbl_author.Font = New System.Drawing.Font("Cambria", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_author.Location = New System.Drawing.Point(39, 333)
        Me.lbl_author.Name = "lbl_author"
        Me.lbl_author.Size = New System.Drawing.Size(73, 21)
        Me.lbl_author.TabIndex = 98
        Me.lbl_author.Text = "Author :"
        '
        'txt_bookname
        '
        Me.txt_bookname.Font = New System.Drawing.Font("Cambria", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_bookname.Location = New System.Drawing.Point(169, 159)
        Me.txt_bookname.Name = "txt_bookname"
        Me.txt_bookname.Size = New System.Drawing.Size(174, 29)
        Me.txt_bookname.TabIndex = 97
        '
        'txt_bookid
        '
        Me.txt_bookid.Font = New System.Drawing.Font("Cambria", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_bookid.Location = New System.Drawing.Point(169, 242)
        Me.txt_bookid.Name = "txt_bookid"
        Me.txt_bookid.Size = New System.Drawing.Size(174, 29)
        Me.txt_bookid.TabIndex = 96
        '
        'lbl_bookname
        '
        Me.lbl_bookname.AutoSize = True
        Me.lbl_bookname.Font = New System.Drawing.Font("Cambria", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_bookname.Location = New System.Drawing.Point(38, 162)
        Me.lbl_bookname.Name = "lbl_bookname"
        Me.lbl_bookname.Size = New System.Drawing.Size(108, 21)
        Me.lbl_bookname.TabIndex = 95
        Me.lbl_bookname.Text = "Book Name :"
        '
        'lbl_bookid
        '
        Me.lbl_bookid.AutoSize = True
        Me.lbl_bookid.Font = New System.Drawing.Font("Cambria", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbl_bookid.Location = New System.Drawing.Point(39, 245)
        Me.lbl_bookid.Name = "lbl_bookid"
        Me.lbl_bookid.Size = New System.Drawing.Size(85, 21)
        Me.lbl_bookid.TabIndex = 94
        Me.lbl_bookid.Text = "Book ID : "
        '
        'btn_edit
        '
        Me.btn_edit.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.btn_edit.Font = New System.Drawing.Font("Calisto MT", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_edit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_edit.Location = New System.Drawing.Point(622, 463)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(120, 43)
        Me.btn_edit.TabIndex = 110
        Me.btn_edit.Text = "Edit"
        Me.btn_edit.UseVisualStyleBackColor = False
        '
        'btn_search_studentid
        '
        Me.btn_search_studentid.BackColor = System.Drawing.Color.CadetBlue
        Me.btn_search_studentid.Font = New System.Drawing.Font("Calisto MT", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_search_studentid.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_search_studentid.Location = New System.Drawing.Point(649, 92)
        Me.btn_search_studentid.Name = "btn_search_studentid"
        Me.btn_search_studentid.Size = New System.Drawing.Size(82, 34)
        Me.btn_search_studentid.TabIndex = 111
        Me.btn_search_studentid.Text = "Search"
        Me.btn_search_studentid.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Controls.Add(Me.pic_exit)
        Me.Panel1.Controls.Add(Me.lbl_registration)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(760, 55)
        Me.Panel1.TabIndex = 112
        '
        'pic_exit
        '
        Me.pic_exit.Image = Global.Assignment_LibraryManagementSystem.My.Resources.Resources.exit_full_screen
        Me.pic_exit.Location = New System.Drawing.Point(698, 0)
        Me.pic_exit.Name = "pic_exit"
        Me.pic_exit.Size = New System.Drawing.Size(59, 58)
        Me.pic_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_exit.TabIndex = 3
        Me.pic_exit.TabStop = False
        '
        'lbl_registration
        '
        Me.lbl_registration.AutoSize = True
        Me.lbl_registration.Font = New System.Drawing.Font("Tahoma", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl_registration.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_registration.Location = New System.Drawing.Point(16, 10)
        Me.lbl_registration.Name = "lbl_registration"
        Me.lbl_registration.Size = New System.Drawing.Size(266, 34)
        Me.lbl_registration.TabIndex = 2
        Me.lbl_registration.Text = "Borrowing Details"
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(754, 518)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btn_search_studentid)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.mtxt_return)
        Me.Controls.Add(Me.mtxt_issue)
        Me.Controls.Add(Me.txt_studentid)
        Me.Controls.Add(Me.lbl_studentid)
        Me.Controls.Add(Me.cmb_status)
        Me.Controls.Add(Me.lbl_status)
        Me.Controls.Add(Me.cmb_language)
        Me.Controls.Add(Me.lbl_rerturn_date)
        Me.Controls.Add(Me.lbl_issue_date)
        Me.Controls.Add(Me.lbl_language)
        Me.Controls.Add(Me.txt_author)
        Me.Controls.Add(Me.lbl_author)
        Me.Controls.Add(Me.txt_bookname)
        Me.Controls.Add(Me.txt_bookid)
        Me.Controls.Add(Me.lbl_bookname)
        Me.Controls.Add(Me.lbl_bookid)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form6"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form6"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pic_exit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mtxt_return As MaskedTextBox
    Friend WithEvents mtxt_issue As MaskedTextBox
    Friend WithEvents txt_studentid As TextBox
    Friend WithEvents lbl_studentid As Label
    Friend WithEvents cmb_status As ComboBox
    Friend WithEvents lbl_status As Label
    Friend WithEvents cmb_language As ComboBox
    Friend WithEvents lbl_rerturn_date As Label
    Friend WithEvents lbl_issue_date As Label
    Friend WithEvents lbl_language As Label
    Friend WithEvents txt_author As TextBox
    Friend WithEvents lbl_author As Label
    Friend WithEvents txt_bookname As TextBox
    Friend WithEvents txt_bookid As TextBox
    Friend WithEvents lbl_bookname As Label
    Friend WithEvents lbl_bookid As Label
    Friend WithEvents btn_edit As Button
    Friend WithEvents btn_search_studentid As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pic_exit As PictureBox
    Friend WithEvents lbl_registration As Label
End Class
