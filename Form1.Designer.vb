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
        messageLabel = New Label()
        Panel1 = New Panel()
        messageTxt = New Label()
        Label3 = New Label()
        enrollBtn = New Button()
        Label2 = New Label()
        Label1 = New Label()
        sectionIdentifierTxt = New TextBox()
        studentnumberTxt = New TextBox()
        Panel2 = New Panel()
        PictureBox1 = New PictureBox()
        Panel3 = New Panel()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' messageLabel
        ' 
        messageLabel.AutoSize = True
        messageLabel.Location = New Point(167, 219)
        messageLabel.Margin = New Padding(2, 0, 2, 0)
        messageLabel.Name = "messageLabel"
        messageLabel.Size = New Size(0, 20)
        messageLabel.TabIndex = 3
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(164), CByte(214), CByte(255))
        Panel1.Controls.Add(messageTxt)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(enrollBtn)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(sectionIdentifierTxt)
        Panel1.Controls.Add(studentnumberTxt)
        Panel1.Location = New Point(713, 165)
        Panel1.Margin = New Padding(2, 3, 2, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(525, 447)
        Panel1.TabIndex = 4
        ' 
        ' messageTxt
        ' 
        messageTxt.AutoSize = True
        messageTxt.BackColor = Color.Transparent
        messageTxt.ForeColor = Color.Red
        messageTxt.Location = New Point(195, 311)
        messageTxt.Margin = New Padding(2, 0, 2, 0)
        messageTxt.Name = "messageTxt"
        messageTxt.Size = New Size(53, 20)
        messageTxt.TabIndex = 11
        messageTxt.Text = "Label4"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(176, 27)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(198, 81)
        Label3.TabIndex = 10
        Label3.Text = "Enroll"
        ' 
        ' enrollBtn
        ' 
        enrollBtn.BackColor = Color.FromArgb(CByte(5), CByte(48), CByte(82))
        enrollBtn.Font = New Font("Microsoft Sans Serif", 12F)
        enrollBtn.ForeColor = Color.White
        enrollBtn.Location = New Point(375, 384)
        enrollBtn.Margin = New Padding(2, 3, 2, 3)
        enrollBtn.Name = "enrollBtn"
        enrollBtn.Size = New Size(119, 37)
        enrollBtn.TabIndex = 9
        enrollBtn.Text = "Submit"
        enrollBtn.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 12F)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(33, 236)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(160, 28)
        Label2.TabIndex = 7
        Label2.Text = "Section Identifier"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 12F)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(33, 180)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(157, 28)
        Label1.TabIndex = 8
        Label1.Text = "Student Number"
        ' 
        ' sectionIdentifierTxt
        ' 
        sectionIdentifierTxt.Font = New Font("Segoe UI", 12F)
        sectionIdentifierTxt.Location = New Point(195, 221)
        sectionIdentifierTxt.Margin = New Padding(2, 3, 2, 3)
        sectionIdentifierTxt.Multiline = True
        sectionIdentifierTxt.Name = "sectionIdentifierTxt"
        sectionIdentifierTxt.Size = New Size(298, 41)
        sectionIdentifierTxt.TabIndex = 5
        ' 
        ' studentnumberTxt
        ' 
        studentnumberTxt.Font = New Font("Segoe UI", 12F)
        studentnumberTxt.Location = New Point(195, 165)
        studentnumberTxt.Margin = New Padding(2, 3, 2, 3)
        studentnumberTxt.Multiline = True
        studentnumberTxt.Name = "studentnumberTxt"
        studentnumberTxt.Size = New Size(298, 41)
        studentnumberTxt.TabIndex = 6
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(PictureBox1)
        Panel2.Controls.Add(Panel1)
        Panel2.Controls.Add(messageLabel)
        Panel2.Controls.Add(Panel3)
        Panel2.Location = New Point(12, 13)
        Panel2.Margin = New Padding(3, 4, 3, 4)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1335, 804)
        Panel2.TabIndex = 5
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.snapedit_1728712573377
        PictureBox1.Location = New Point(47, 39)
        PictureBox1.Margin = New Padding(3, 4, 3, 4)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(601, 676)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 5
        PictureBox1.TabStop = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(5), CByte(48), CByte(82))
        Panel3.Location = New Point(28, 53)
        Panel3.Margin = New Padding(3, 4, 3, 4)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1291, 761)
        Panel3.TabIndex = 23
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(0), CByte(160), CByte(221))
        ClientSize = New Size(1698, 830)
        Controls.Add(Panel2)
        Margin = New Padding(2, 3, 2, 3)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents messageLabel As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents enrollBtn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents sectionIdentifierTxt As TextBox
    Friend WithEvents studentnumberTxt As TextBox
    Friend WithEvents messageTxt As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel3 As Panel

End Class
