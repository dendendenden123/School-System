<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentRegister
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
        Panel1 = New Panel()
        Label2 = New Label()
        PictureBox3 = New PictureBox()
        Panel2 = New Panel()
        Panel3 = New Panel()
        lastNameTxt = New TextBox()
        addressTxt = New TextBox()
        firstNameTxt = New TextBox()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label3 = New Label()
        middleNameTxt = New TextBox()
        emailTxt = New TextBox()
        registerBtn = New Button()
        message = New Label()
        Label1 = New Label()
        Panel4 = New Panel()
        Label4 = New Label()
        Panel1.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(164), CByte(214), CByte(255))
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(PictureBox3)
        Panel1.Controls.Add(Panel2)
        Panel1.ForeColor = SystemColors.Control
        Panel1.Location = New Point(271, 122)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1361, 791)
        Panel1.TabIndex = 14
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 27F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(5), CByte(48), CByte(82))
        Label2.Location = New Point(27, 32)
        Label2.Name = "Label2"
        Label2.Size = New Size(445, 61)
        Label2.TabIndex = 14
        Label2.Text = "REGISTER STUDENT"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.snapedit_1728656906414
        PictureBox3.Location = New Point(27, 113)
        PictureBox3.Margin = New Padding(3, 4, 3, 4)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(686, 623)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 13
        PictureBox3.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(217), CByte(238), CByte(255))
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(Panel3)
        Panel2.Controls.Add(registerBtn)
        Panel2.Controls.Add(message)
        Panel2.Controls.Add(Label1)
        Panel2.Location = New Point(719, 113)
        Panel2.Margin = New Padding(3, 4, 3, 4)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(610, 623)
        Panel2.TabIndex = 12
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.White
        Panel3.Controls.Add(lastNameTxt)
        Panel3.Controls.Add(addressTxt)
        Panel3.Controls.Add(firstNameTxt)
        Panel3.Controls.Add(Label9)
        Panel3.Controls.Add(Label8)
        Panel3.Controls.Add(Label7)
        Panel3.Controls.Add(Label6)
        Panel3.Controls.Add(Label3)
        Panel3.Controls.Add(middleNameTxt)
        Panel3.Controls.Add(emailTxt)
        Panel3.Location = New Point(13, 139)
        Panel3.Margin = New Padding(3, 4, 3, 4)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(580, 360)
        Panel3.TabIndex = 14
        ' 
        ' lastNameTxt
        ' 
        lastNameTxt.BackColor = Color.FromArgb(CByte(164), CByte(214), CByte(255))
        lastNameTxt.Font = New Font("Segoe UI", 14F)
        lastNameTxt.ForeColor = Color.Black
        lastNameTxt.Location = New Point(196, 145)
        lastNameTxt.Name = "lastNameTxt"
        lastNameTxt.Size = New Size(369, 39)
        lastNameTxt.TabIndex = 1
        ' 
        ' addressTxt
        ' 
        addressTxt.BackColor = Color.FromArgb(CByte(164), CByte(214), CByte(255))
        addressTxt.Font = New Font("Segoe UI", 14F)
        addressTxt.ForeColor = Color.Black
        addressTxt.Location = New Point(196, 201)
        addressTxt.Name = "addressTxt"
        addressTxt.Size = New Size(369, 39)
        addressTxt.TabIndex = 3
        ' 
        ' firstNameTxt
        ' 
        firstNameTxt.BackColor = Color.FromArgb(CByte(164), CByte(214), CByte(255))
        firstNameTxt.Font = New Font("Segoe UI", 14F)
        firstNameTxt.ForeColor = Color.Black
        firstNameTxt.Location = New Point(196, 34)
        firstNameTxt.Name = "firstNameTxt"
        firstNameTxt.Size = New Size(369, 39)
        firstNameTxt.TabIndex = 1
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold)
        Label9.ForeColor = Color.FromArgb(CByte(5), CByte(48), CByte(82))
        Label9.Location = New Point(17, 200)
        Label9.Name = "Label9"
        Label9.Size = New Size(105, 31)
        Label9.TabIndex = 0
        Label9.Text = "Address:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold)
        Label8.ForeColor = Color.FromArgb(CByte(5), CByte(48), CByte(82))
        Label8.Location = New Point(17, 144)
        Label8.Name = "Label8"
        Label8.Size = New Size(132, 31)
        Label8.TabIndex = 0
        Label8.Text = "Last Name:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold)
        Label7.ForeColor = Color.FromArgb(CByte(5), CByte(48), CByte(82))
        Label7.Location = New Point(17, 92)
        Label7.Name = "Label7"
        Label7.Size = New Size(165, 31)
        Label7.TabIndex = 0
        Label7.Text = "Middle Name:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold)
        Label6.ForeColor = Color.FromArgb(CByte(5), CByte(48), CByte(82))
        Label6.Location = New Point(17, 36)
        Label6.Name = "Label6"
        Label6.Size = New Size(136, 31)
        Label6.TabIndex = 0
        Label6.Text = "First Name:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold)
        Label3.ForeColor = Color.FromArgb(CByte(5), CByte(48), CByte(82))
        Label3.Location = New Point(17, 263)
        Label3.Name = "Label3"
        Label3.Size = New Size(79, 31)
        Label3.TabIndex = 0
        Label3.Text = "Email:"
        ' 
        ' middleNameTxt
        ' 
        middleNameTxt.BackColor = Color.FromArgb(CByte(164), CByte(214), CByte(255))
        middleNameTxt.Font = New Font("Segoe UI", 14F)
        middleNameTxt.ForeColor = Color.Black
        middleNameTxt.Location = New Point(196, 90)
        middleNameTxt.Name = "middleNameTxt"
        middleNameTxt.Size = New Size(369, 39)
        middleNameTxt.TabIndex = 3
        ' 
        ' emailTxt
        ' 
        emailTxt.BackColor = Color.FromArgb(CByte(164), CByte(214), CByte(255))
        emailTxt.Font = New Font("Segoe UI", 14F)
        emailTxt.ForeColor = Color.Black
        emailTxt.Location = New Point(196, 261)
        emailTxt.Name = "emailTxt"
        emailTxt.Size = New Size(369, 39)
        emailTxt.TabIndex = 1
        ' 
        ' registerBtn
        ' 
        registerBtn.BackColor = Color.FromArgb(CByte(5), CByte(48), CByte(82))
        registerBtn.Font = New Font("Segoe UI", 9.25F)
        registerBtn.Location = New Point(13, 510)
        registerBtn.Name = "registerBtn"
        registerBtn.Size = New Size(115, 37)
        registerBtn.TabIndex = 5
        registerBtn.Text = "REGISTER"
        registerBtn.UseVisualStyleBackColor = False
        ' 
        ' message
        ' 
        message.AutoSize = True
        message.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        message.ForeColor = Color.Red
        message.Location = New Point(147, 517)
        message.Name = "message"
        message.Size = New Size(0, 23)
        message.TabIndex = 11
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(5), CByte(48), CByte(82))
        Label1.Location = New Point(13, 80)
        Label1.Name = "Label1"
        Label1.Size = New Size(191, 37)
        Label1.TabIndex = 0
        Label1.Text = "Student Form"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(5), CByte(48), CByte(82))
        Panel4.Location = New Point(298, 154)
        Panel4.Margin = New Padding(3, 4, 3, 4)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(1355, 779)
        Panel4.TabIndex = 15
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(113, 574)
        Label4.Name = "Label4"
        Label4.Size = New Size(25, 20)
        Label4.TabIndex = 4
        Label4.Text = "    "
        ' 
        ' StudentRegister
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(0), CByte(160), CByte(221))
        ClientSize = New Size(1924, 1055)
        Controls.Add(Panel1)
        Controls.Add(Panel4)
        Name = "StudentRegister"
        StartPosition = FormStartPosition.CenterScreen
        Text = "AdminRegister"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents emailTxt As TextBox
    Friend WithEvents registerBtn As Button
    Friend WithEvents message As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lastNameTxt As TextBox
    Friend WithEvents addressTxt As TextBox
    Friend WithEvents firstNameTxt As TextBox
    Friend WithEvents middleNameTxt As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
