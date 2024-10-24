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
        Label1 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Button1 = New Button()
        Label5 = New Label()
        Panel1 = New Panel()
        Label2 = New Label()
        PictureBox3 = New PictureBox()
        Panel2 = New Panel()
        Panel3 = New Panel()
        PictureBox2 = New PictureBox()
        PictureBox1 = New PictureBox()
        Panel4 = New Panel()
        Panel1.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(5), CByte(48), CByte(82))
        Label1.Location = New Point(135, 146)
        Label1.Name = "Label1"
        Label1.Size = New Size(173, 37)
        Label1.TabIndex = 0
        Label1.Text = "USER LOGIN"
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.FromArgb(CByte(164), CByte(214), CByte(255))
        TextBox1.Font = New Font("Segoe UI", 14F)
        TextBox1.ForeColor = Color.Black
        TextBox1.Location = New Point(59, 37)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(287, 39)
        TextBox1.TabIndex = 1
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.FromArgb(CByte(164), CByte(214), CByte(255))
        TextBox2.Font = New Font("Segoe UI", 14F)
        TextBox2.ForeColor = Color.Black
        TextBox2.Location = New Point(59, 129)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(287, 39)
        TextBox2.TabIndex = 3
        TextBox2.UseSystemPasswordChar = True
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(5), CByte(48), CByte(82))
        Button1.Font = New Font("Segoe UI", 9.25F)
        Button1.Location = New Point(167, 435)
        Button1.Name = "Button1"
        Button1.Size = New Size(115, 37)
        Button1.TabIndex = 5
        Button1.Text = "LOGIN"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.Red
        Label5.Location = New Point(103, 494)
        Label5.Name = "Label5"
        Label5.Size = New Size(0, 23)
        Label5.TabIndex = 11
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(164), CByte(214), CByte(255))
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(PictureBox3)
        Panel1.Controls.Add(Panel2)
        Panel1.ForeColor = SystemColors.Control
        Panel1.Location = New Point(103, 93)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1361, 791)
        Panel1.TabIndex = 12
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 27F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(5), CByte(48), CByte(82))
        Label2.Location = New Point(27, 32)
        Label2.Name = "Label2"
        Label2.Size = New Size(474, 61)
        Label2.TabIndex = 14
        Label2.Text = "School System Portal"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.snapedit_1728656906414
        PictureBox3.Location = New Point(27, 113)
        PictureBox3.Margin = New Padding(3, 4, 3, 4)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(879, 623)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 13
        PictureBox3.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(217), CByte(238), CByte(255))
        Panel2.Controls.Add(Panel3)
        Panel2.Controls.Add(Button1)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(Label1)
        Panel2.Location = New Point(913, 113)
        Panel2.Margin = New Padding(3, 4, 3, 4)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(416, 623)
        Panel2.TabIndex = 12
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.White
        Panel3.Controls.Add(PictureBox2)
        Panel3.Controls.Add(PictureBox1)
        Panel3.Controls.Add(TextBox1)
        Panel3.Controls.Add(TextBox2)
        Panel3.Location = New Point(26, 210)
        Panel3.Margin = New Padding(3, 4, 3, 4)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(359, 208)
        Panel3.TabIndex = 14
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources._23
        PictureBox2.Location = New Point(11, 129)
        PictureBox2.Margin = New Padding(3, 4, 3, 4)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(40, 43)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 13
        PictureBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources._13
        PictureBox1.Location = New Point(13, 37)
        PictureBox1.Margin = New Padding(3, 4, 3, 4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(40, 43)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 12
        PictureBox1.TabStop = False
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(5), CByte(48), CByte(82))
        Panel4.Location = New Point(130, 125)
        Panel4.Margin = New Padding(3, 4, 3, 4)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(1355, 779)
        Panel4.TabIndex = 13
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(0), CByte(160), CByte(221))
        ClientSize = New Size(1566, 999)
        Controls.Add(Panel1)
        Controls.Add(Panel4)
        Name = "Form3"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form3"
        WindowState = FormWindowState.Maximized
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
End Class
