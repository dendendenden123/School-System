<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditSection
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
        Label5 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        semesterTxt = New TextBox()
        yearTxt = New TextBox()
        InstructorTxt = New TextBox()
        courseNumberTxt = New TextBox()
        sectionIdentiferTxt = New TextBox()
        Panel1 = New Panel()
        Panel2 = New Panel()
        Panel3 = New Panel()
        Label6 = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' deleteBtn
        ' 
        deleteBtn.BackColor = Color.FromArgb(CByte(5), CByte(48), CByte(82))
        deleteBtn.Font = New Font("Segoe UI", 12F)
        deleteBtn.ForeColor = Color.White
        deleteBtn.Location = New Point(272, 28)
        deleteBtn.Margin = New Padding(2)
        deleteBtn.Name = "deleteBtn"
        deleteBtn.Size = New Size(108, 41)
        deleteBtn.TabIndex = 13
        deleteBtn.Text = "Delete"
        deleteBtn.UseVisualStyleBackColor = False
        ' 
        ' updateBtn
        ' 
        updateBtn.BackColor = Color.FromArgb(CByte(5), CByte(48), CByte(82))
        updateBtn.Font = New Font("Segoe UI", 12F)
        updateBtn.ForeColor = Color.White
        updateBtn.Location = New Point(151, 28)
        updateBtn.Margin = New Padding(2)
        updateBtn.Name = "updateBtn"
        updateBtn.Size = New Size(108, 41)
        updateBtn.TabIndex = 14
        updateBtn.Text = "Update"
        updateBtn.UseVisualStyleBackColor = False
        ' 
        ' insertBtn
        ' 
        insertBtn.BackColor = Color.FromArgb(CByte(5), CByte(48), CByte(82))
        insertBtn.Font = New Font("Segoe UI", 12F)
        insertBtn.ForeColor = Color.White
        insertBtn.Location = New Point(27, 28)
        insertBtn.Margin = New Padding(2)
        insertBtn.Name = "insertBtn"
        insertBtn.Size = New Size(108, 41)
        insertBtn.TabIndex = 15
        insertBtn.Text = "Insert"
        insertBtn.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F)
        Label4.Location = New Point(412, 75)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(75, 21)
        Label4.TabIndex = 8
        Label4.Text = "Semester"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F)
        Label3.Location = New Point(412, 121)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(40, 21)
        Label3.TabIndex = 9
        Label3.Text = "Year"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Microsoft Sans Serif", 12F)
        Label5.Location = New Point(98, 164)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(77, 20)
        Label5.TabIndex = 10
        Label5.Text = "Instructor"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F)
        Label2.Location = New Point(51, 121)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(121, 21)
        Label2.TabIndex = 11
        Label2.Text = "Course Number"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F)
        Label1.Location = New Point(42, 75)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(127, 21)
        Label1.TabIndex = 12
        Label1.Text = "Section Identifier"
        ' 
        ' semesterTxt
        ' 
        semesterTxt.Font = New Font("Segoe UI", 12F)
        semesterTxt.Location = New Point(519, 68)
        semesterTxt.Margin = New Padding(2)
        semesterTxt.Multiline = True
        semesterTxt.Name = "semesterTxt"
        semesterTxt.Size = New Size(198, 34)
        semesterTxt.TabIndex = 3
        ' 
        ' yearTxt
        ' 
        yearTxt.Font = New Font("Segoe UI", 12F)
        yearTxt.Location = New Point(519, 115)
        yearTxt.Margin = New Padding(2)
        yearTxt.Multiline = True
        yearTxt.Name = "yearTxt"
        yearTxt.Size = New Size(198, 34)
        yearTxt.TabIndex = 4
        ' 
        ' InstructorTxt
        ' 
        InstructorTxt.Font = New Font("Segoe UI", 12F)
        InstructorTxt.Location = New Point(183, 157)
        InstructorTxt.Margin = New Padding(2)
        InstructorTxt.Multiline = True
        InstructorTxt.Name = "InstructorTxt"
        InstructorTxt.Size = New Size(198, 34)
        InstructorTxt.TabIndex = 5
        ' 
        ' courseNumberTxt
        ' 
        courseNumberTxt.Font = New Font("Segoe UI", 12F)
        courseNumberTxt.Location = New Point(183, 115)
        courseNumberTxt.Margin = New Padding(2)
        courseNumberTxt.Multiline = True
        courseNumberTxt.Name = "courseNumberTxt"
        courseNumberTxt.Size = New Size(198, 34)
        courseNumberTxt.TabIndex = 6
        ' 
        ' sectionIdentiferTxt
        ' 
        sectionIdentiferTxt.Font = New Font("Segoe UI", 12F)
        sectionIdentiferTxt.Location = New Point(183, 68)
        sectionIdentiferTxt.Margin = New Padding(2)
        sectionIdentiferTxt.Multiline = True
        sectionIdentiferTxt.Name = "sectionIdentiferTxt"
        sectionIdentiferTxt.Size = New Size(198, 34)
        sectionIdentiferTxt.TabIndex = 7
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(164), CByte(214), CByte(255))
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(semesterTxt)
        Panel1.Controls.Add(yearTxt)
        Panel1.Controls.Add(InstructorTxt)
        Panel1.Controls.Add(courseNumberTxt)
        Panel1.Controls.Add(sectionIdentiferTxt)
        Panel1.Location = New Point(40, 90)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(758, 375)
        Panel1.TabIndex = 16
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(217), CByte(238), CByte(255))
        Panel2.Controls.Add(deleteBtn)
        Panel2.Controls.Add(updateBtn)
        Panel2.Controls.Add(insertBtn)
        Panel2.Location = New Point(193, 249)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(399, 93)
        Panel2.TabIndex = 16
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(Label6)
        Panel3.Controls.Add(Panel1)
        Panel3.Location = New Point(289, 72)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(843, 504)
        Panel3.TabIndex = 17
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.FromArgb(CByte(5), CByte(48), CByte(82))
        Label6.Font = New Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.White
        Label6.Location = New Point(321, 22)
        Label6.Name = "Label6"
        Label6.Size = New Size(217, 47)
        Label6.TabIndex = 17
        Label6.Text = "Edit Section"
        ' 
        ' EditSection
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(0), CByte(160), CByte(221))
        ClientSize = New Size(1370, 749)
        Controls.Add(Panel3)
        Margin = New Padding(2)
        Name = "EditSection"
        StartPosition = FormStartPosition.CenterScreen
        Text = "EditSection"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents deleteBtn As Button
    Friend WithEvents updateBtn As Button
    Friend WithEvents insertBtn As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents semesterTxt As TextBox
    Friend WithEvents yearTxt As TextBox
    Friend WithEvents InstructorTxt As TextBox
    Friend WithEvents courseNumberTxt As TextBox
    Friend WithEvents sectionIdentiferTxt As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label6 As Label
End Class
