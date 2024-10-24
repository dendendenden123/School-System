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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        ImageList1 = New ImageList(components)
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label6 = New Label()
        DataGridView1 = New DataGridView()
        Button1 = New Button()
        Button2 = New Button()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Panel1 = New Panel()
        Panel3 = New Panel()
        Panel2 = New Panel()
        Panel5 = New Panel()
        Panel4 = New Panel()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' ImageList1
        ' 
        ImageList1.ColorDepth = ColorDepth.Depth32Bit
        ImageList1.ImageSize = New Size(16, 16)
        ImageList1.TransparentColor = Color.Transparent
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(169, 19)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(151, 177)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 11.5F)
        Label1.Location = New Point(17, 145)
        Label1.Name = "Label1"
        Label1.Size = New Size(161, 28)
        Label1.TabIndex = 1
        Label1.Text = "Student Number:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.FromArgb(CByte(5), CByte(48), CByte(82))
        Label6.Location = New Point(37, 27)
        Label6.Name = "Label6"
        Label6.Size = New Size(192, 38)
        Label6.TabIndex = 6
        Label6.Text = "Grade Report"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.White
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(577, 87)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(726, 577)
        DataGridView1.TabIndex = 8
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(5), CByte(48), CByte(82))
        Button1.Font = New Font("Segoe UI", 12F)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(1130, 23)
        Button1.Name = "Button1"
        Button1.Size = New Size(184, 44)
        Button1.TabIndex = 9
        Button1.Text = "Enroll New Course"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(5), CByte(48), CByte(82))
        Button2.Font = New Font("Segoe UI", 12F)
        Button2.ForeColor = Color.White
        Button2.Location = New Point(1411, 15)
        Button2.Name = "Button2"
        Button2.Size = New Size(141, 37)
        Button2.TabIndex = 10
        Button2.Text = "LOG OUT"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 11.5F)
        Label2.Location = New Point(17, 193)
        Label2.Name = "Label2"
        Label2.Size = New Size(110, 28)
        Label2.TabIndex = 11
        Label2.Text = "First Name:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 11.5F)
        Label3.Location = New Point(17, 239)
        Label3.Name = "Label3"
        Label3.Size = New Size(135, 28)
        Label3.TabIndex = 12
        Label3.Text = "Middle Name:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI", 11.5F)
        Label4.Location = New Point(17, 287)
        Label4.Name = "Label4"
        Label4.Size = New Size(107, 28)
        Label4.TabIndex = 13
        Label4.Text = "Last Name:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe UI", 11.5F)
        Label5.Location = New Point(17, 336)
        Label5.Name = "Label5"
        Label5.Size = New Size(86, 28)
        Label5.TabIndex = 14
        Label5.Text = "Address:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Segoe UI", 11.5F)
        Label7.Location = New Point(254, 145)
        Label7.Name = "Label7"
        Label7.Size = New Size(161, 28)
        Label7.TabIndex = 15
        Label7.Text = "Student Number:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Segoe UI", 11.5F)
        Label8.Location = New Point(254, 193)
        Label8.Name = "Label8"
        Label8.Size = New Size(161, 28)
        Label8.TabIndex = 16
        Label8.Text = "Student Number:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.Transparent
        Label9.Font = New Font("Segoe UI", 11.5F)
        Label9.Location = New Point(254, 239)
        Label9.Name = "Label9"
        Label9.Size = New Size(161, 28)
        Label9.TabIndex = 17
        Label9.Text = "Student Number:"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = Color.Transparent
        Label10.Font = New Font("Segoe UI", 11.5F)
        Label10.Location = New Point(254, 287)
        Label10.Name = "Label10"
        Label10.Size = New Size(161, 28)
        Label10.TabIndex = 18
        Label10.Text = "Student Number:"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.BackColor = Color.Transparent
        Label11.Font = New Font("Segoe UI", 11.5F)
        Label11.Location = New Point(254, 336)
        Label11.Name = "Label11"
        Label11.Size = New Size(161, 28)
        Label11.TabIndex = 19
        Label11.Text = "Student Number:"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(217), CByte(238), CByte(255))
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(Panel3)
        Panel1.Location = New Point(55, 105)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(481, 559)
        Panel1.TabIndex = 20
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.White
        Panel3.Controls.Add(Label11)
        Panel3.Controls.Add(Label10)
        Panel3.Controls.Add(Label3)
        Panel3.Controls.Add(Label2)
        Panel3.Controls.Add(Label9)
        Panel3.Controls.Add(Label4)
        Panel3.Controls.Add(Label1)
        Panel3.Controls.Add(Label8)
        Panel3.Controls.Add(Label5)
        Panel3.Controls.Add(Label7)
        Panel3.Location = New Point(9, 124)
        Panel3.Margin = New Padding(3, 4, 3, 4)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(463, 416)
        Panel3.TabIndex = 20
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(164), CByte(214), CByte(255))
        Panel2.Controls.Add(Panel1)
        Panel2.Controls.Add(Button1)
        Panel2.Controls.Add(DataGridView1)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(Panel5)
        Panel2.Font = New Font("Segoe UI", 11F)
        Panel2.Location = New Point(106, 136)
        Panel2.Margin = New Padding(3, 4, 3, 4)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1360, 740)
        Panel2.TabIndex = 21
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.FromArgb(CByte(5), CByte(48), CByte(82))
        Panel5.Location = New Point(591, 104)
        Panel5.Margin = New Padding(3, 4, 3, 4)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(723, 572)
        Panel5.TabIndex = 49
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(5), CByte(48), CByte(82))
        Panel4.Location = New Point(135, 140)
        Panel4.Margin = New Padding(3, 4, 3, 4)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(1345, 719)
        Panel4.TabIndex = 22
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(0), CByte(160), CByte(221))
        ClientSize = New Size(1566, 999)
        Controls.Add(Panel2)
        Controls.Add(Button2)
        Controls.Add(Panel4)
        Name = "Form4"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form4"
        WindowState = FormWindowState.Maximized
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
End Class
