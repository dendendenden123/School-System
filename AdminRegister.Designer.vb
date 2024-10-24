<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminRegister
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
        Label4 = New Label()
        Label3 = New Label()
        usernameTxt = New TextBox()
        passTxt = New TextBox()
        registerBtn = New Button()
        message = New Label()
        Label1 = New Label()
        Panel4 = New Panel()
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
        Panel1.TabIndex = 16
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 27F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(5), CByte(48), CByte(82))
        Label2.Location = New Point(27, 32)
        Label2.Name = "Label2"
        Label2.Size = New Size(400, 61)
        Label2.TabIndex = 14
        Label2.Text = "REGISTER ADMIN"
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
        Panel3.Controls.Add(Label4)
        Panel3.Controls.Add(Label3)
        Panel3.Controls.Add(usernameTxt)
        Panel3.Controls.Add(passTxt)
        Panel3.Location = New Point(13, 235)
        Panel3.Margin = New Padding(3, 4, 3, 4)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(580, 143)
        Panel3.TabIndex = 14
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold)
        Label4.ForeColor = Color.FromArgb(CByte(5), CByte(48), CByte(82))
        Label4.Location = New Point(17, 75)
        Label4.Name = "Label4"
        Label4.Size = New Size(120, 31)
        Label4.TabIndex = 0
        Label4.Text = "Password:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold)
        Label3.ForeColor = Color.FromArgb(CByte(5), CByte(48), CByte(82))
        Label3.Location = New Point(17, 19)
        Label3.Name = "Label3"
        Label3.Size = New Size(127, 31)
        Label3.TabIndex = 0
        Label3.Text = "Username:"
        ' 
        ' usernameTxt
        ' 
        usernameTxt.BackColor = Color.FromArgb(CByte(164), CByte(214), CByte(255))
        usernameTxt.Font = New Font("Segoe UI", 14F)
        usernameTxt.ForeColor = Color.Black
        usernameTxt.Location = New Point(196, 17)
        usernameTxt.Name = "usernameTxt"
        usernameTxt.Size = New Size(369, 39)
        usernameTxt.TabIndex = 1
        ' 
        ' passTxt
        ' 
        passTxt.BackColor = Color.FromArgb(CByte(164), CByte(214), CByte(255))
        passTxt.Font = New Font("Segoe UI", 14F)
        passTxt.ForeColor = Color.Black
        passTxt.Location = New Point(196, 73)
        passTxt.Name = "passTxt"
        passTxt.Size = New Size(369, 39)
        passTxt.TabIndex = 3
        passTxt.UseSystemPasswordChar = True
        ' 
        ' registerBtn
        ' 
        registerBtn.BackColor = Color.FromArgb(CByte(5), CByte(48), CByte(82))
        registerBtn.Font = New Font("Segoe UI", 9.25F)
        registerBtn.Location = New Point(13, 399)
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
        message.Location = New Point(145, 413)
        message.Name = "message"
        message.Size = New Size(59, 23)
        message.TabIndex = 11
        message.Text = "Label5"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(5), CByte(48), CByte(82))
        Label1.Location = New Point(13, 176)
        Label1.Name = "Label1"
        Label1.Size = New Size(176, 37)
        Label1.TabIndex = 0
        Label1.Text = "Admin Form"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(5), CByte(48), CByte(82))
        Panel4.Location = New Point(298, 154)
        Panel4.Margin = New Padding(3, 4, 3, 4)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(1355, 779)
        Panel4.TabIndex = 17
        ' 
        ' AdminRegister
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(0), CByte(160), CByte(221))
        ClientSize = New Size(1924, 1055)
        Controls.Add(Panel1)
        Controls.Add(Panel4)
        Name = "AdminRegister"
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
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents usernameTxt As TextBox
    Friend WithEvents passTxt As TextBox
    Friend WithEvents registerBtn As Button
    Friend WithEvents message As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel4 As Panel
End Class
