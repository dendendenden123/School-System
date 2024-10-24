<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditStudent
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
        deleteBtn = New Button()
        updateBtn = New Button()
        insertBtn = New Button()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        passwordTxt = New TextBox()
        middleNameTxt = New TextBox()
        firstNameTxt = New TextBox()
        studentNumberTxt = New TextBox()
        lastNameTxt = New TextBox()
        TextBox2 = New TextBox()
        Label5 = New Label()
        addressTxt = New Label()
        Panel1 = New Panel()
        Panel3 = New Panel()
        Panel2 = New Panel()
        Label6 = New Label()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' deleteBtn
        ' 
        deleteBtn.BackColor = Color.FromArgb(CByte(5), CByte(48), CByte(82))
        deleteBtn.Font = New Font("Segoe UI", 12F)
        deleteBtn.ForeColor = Color.White
        deleteBtn.Location = New Point(330, 25)
        deleteBtn.Margin = New Padding(2)
        deleteBtn.Name = "deleteBtn"
        deleteBtn.Size = New Size(108, 41)
        deleteBtn.TabIndex = 11
        deleteBtn.Text = "Delete"
        deleteBtn.UseVisualStyleBackColor = False
        ' 
        ' updateBtn
        ' 
        updateBtn.BackColor = Color.FromArgb(CByte(5), CByte(48), CByte(82))
        updateBtn.Font = New Font("Segoe UI", 12F)
        updateBtn.ForeColor = Color.White
        updateBtn.Location = New Point(175, 25)
        updateBtn.Margin = New Padding(2)
        updateBtn.Name = "updateBtn"
        updateBtn.Size = New Size(108, 41)
        updateBtn.TabIndex = 12
        updateBtn.Text = "Update"
        updateBtn.UseVisualStyleBackColor = False
        ' 
        ' insertBtn
        ' 
        insertBtn.BackColor = Color.FromArgb(CByte(5), CByte(48), CByte(82))
        insertBtn.Font = New Font("Segoe UI", 12F)
        insertBtn.ForeColor = Color.White
        insertBtn.Location = New Point(19, 25)
        insertBtn.Margin = New Padding(2)
        insertBtn.Name = "insertBtn"
        insertBtn.Size = New Size(108, 41)
        insertBtn.TabIndex = 13
        insertBtn.Text = "Insert"
        insertBtn.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI", 12F)
        Label4.Location = New Point(399, 138)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(76, 21)
        Label4.TabIndex = 7
        Label4.Text = "Password"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 12F)
        Label3.Location = New Point(371, 184)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(104, 21)
        Label3.TabIndex = 8
        Label3.Text = "Middle Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 12F)
        Label2.Location = New Point(57, 184)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(86, 21)
        Label2.TabIndex = 9
        Label2.Text = "First Name"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 12F)
        Label1.Location = New Point(18, 138)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(125, 21)
        Label1.TabIndex = 10
        Label1.Text = "Student Number"
        ' 
        ' passwordTxt
        ' 
        passwordTxt.Font = New Font("Segoe UI", 12F)
        passwordTxt.Location = New Point(485, 125)
        passwordTxt.Margin = New Padding(2)
        passwordTxt.Multiline = True
        passwordTxt.Name = "passwordTxt"
        passwordTxt.Size = New Size(198, 34)
        passwordTxt.TabIndex = 3
        ' 
        ' middleNameTxt
        ' 
        middleNameTxt.Font = New Font("Segoe UI", 12F)
        middleNameTxt.Location = New Point(485, 171)
        middleNameTxt.Margin = New Padding(2)
        middleNameTxt.Multiline = True
        middleNameTxt.Name = "middleNameTxt"
        middleNameTxt.Size = New Size(198, 34)
        middleNameTxt.TabIndex = 4
        ' 
        ' firstNameTxt
        ' 
        firstNameTxt.Font = New Font("Segoe UI", 12F)
        firstNameTxt.Location = New Point(163, 171)
        firstNameTxt.Margin = New Padding(2)
        firstNameTxt.Multiline = True
        firstNameTxt.Name = "firstNameTxt"
        firstNameTxt.Size = New Size(198, 34)
        firstNameTxt.TabIndex = 5
        ' 
        ' studentNumberTxt
        ' 
        studentNumberTxt.Font = New Font("Segoe UI", 12F)
        studentNumberTxt.Location = New Point(163, 125)
        studentNumberTxt.Margin = New Padding(2)
        studentNumberTxt.Multiline = True
        studentNumberTxt.Name = "studentNumberTxt"
        studentNumberTxt.Size = New Size(198, 34)
        studentNumberTxt.TabIndex = 6
        ' 
        ' lastNameTxt
        ' 
        lastNameTxt.Font = New Font("Segoe UI", 12F)
        lastNameTxt.Location = New Point(163, 215)
        lastNameTxt.Margin = New Padding(2)
        lastNameTxt.Multiline = True
        lastNameTxt.Name = "lastNameTxt"
        lastNameTxt.Size = New Size(198, 34)
        lastNameTxt.TabIndex = 5
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Segoe UI", 12F)
        TextBox2.Location = New Point(485, 215)
        TextBox2.Margin = New Padding(2)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(198, 34)
        TextBox2.TabIndex = 4
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Segoe UI", 12F)
        Label5.Location = New Point(59, 228)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(84, 21)
        Label5.TabIndex = 9
        Label5.Text = "Last Name"
        ' 
        ' addressTxt
        ' 
        addressTxt.AutoSize = True
        addressTxt.BackColor = Color.Transparent
        addressTxt.Font = New Font("Segoe UI", 12F)
        addressTxt.Location = New Point(409, 228)
        addressTxt.Margin = New Padding(2, 0, 2, 0)
        addressTxt.Name = "addressTxt"
        addressTxt.Size = New Size(66, 21)
        addressTxt.TabIndex = 8
        addressTxt.Text = "Address"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(0), CByte(160), CByte(221))
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(Label6)
        Panel1.Location = New Point(288, 95)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(814, 546)
        Panel1.TabIndex = 14
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(164), CByte(214), CByte(255))
        Panel3.Controls.Add(Panel2)
        Panel3.Controls.Add(Label4)
        Panel3.Controls.Add(Label1)
        Panel3.Controls.Add(addressTxt)
        Panel3.Controls.Add(Label3)
        Panel3.Controls.Add(Label5)
        Panel3.Controls.Add(Label2)
        Panel3.Controls.Add(passwordTxt)
        Panel3.Controls.Add(TextBox2)
        Panel3.Controls.Add(lastNameTxt)
        Panel3.Controls.Add(middleNameTxt)
        Panel3.Controls.Add(firstNameTxt)
        Panel3.Controls.Add(studentNumberTxt)
        Panel3.Location = New Point(56, 82)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(705, 424)
        Panel3.TabIndex = 16
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(217), CByte(238), CByte(255))
        Panel2.Controls.Add(deleteBtn)
        Panel2.Controls.Add(updateBtn)
        Panel2.Controls.Add(insertBtn)
        Panel2.Location = New Point(137, 305)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(455, 91)
        Panel2.TabIndex = 15
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.FromArgb(CByte(5), CByte(48), CByte(82))
        Label6.Font = New Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.White
        Label6.Location = New Point(306, 18)
        Label6.Name = "Label6"
        Label6.Size = New Size(225, 47)
        Label6.TabIndex = 14
        Label6.Text = "Edit Student"
        ' 
        ' EditStudent
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(0), CByte(160), CByte(221))
        ClientSize = New Size(1370, 749)
        Controls.Add(Panel1)
        Margin = New Padding(3, 2, 3, 2)
        Name = "EditStudent"
        Text = "EditStudent"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents deleteBtn As Button
    Friend WithEvents updateBtn As Button
    Friend WithEvents insertBtn As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents passwordTxt As TextBox
    Friend WithEvents middleNameTxt As TextBox
    Friend WithEvents firstNameTxt As TextBox
    Friend WithEvents studentNumberTxt As TextBox
    Friend WithEvents lastNameTxt As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents addressTxt As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
End Class
