﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditCourse
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
        courseNameTxt = New TextBox()
        Label1 = New Label()
        courseNumberTxt = New TextBox()
        Label2 = New Label()
        departmentTxt = New TextBox()
        Label3 = New Label()
        creditHoursTxt = New TextBox()
        Label4 = New Label()
        insertBtn = New Button()
        updateBtn = New Button()
        deleteBtn = New Button()
        Panel1 = New Panel()
        Panel2 = New Panel()
        Panel3 = New Panel()
        Label6 = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' courseNameTxt
        ' 
        courseNameTxt.Font = New Font("Segoe UI", 12F)
        courseNameTxt.Location = New Point(163, 89)
        courseNameTxt.Margin = New Padding(2)
        courseNameTxt.Multiline = True
        courseNameTxt.Name = "courseNameTxt"
        courseNameTxt.Size = New Size(199, 34)
        courseNameTxt.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F)
        Label1.Location = New Point(48, 95)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(105, 21)
        Label1.TabIndex = 1
        Label1.Text = "Course Name"
        ' 
        ' courseNumberTxt
        ' 
        courseNumberTxt.Font = New Font("Segoe UI", 12F)
        courseNumberTxt.Location = New Point(163, 135)
        courseNumberTxt.Margin = New Padding(2)
        courseNumberTxt.Multiline = True
        courseNumberTxt.Name = "courseNumberTxt"
        courseNumberTxt.Size = New Size(199, 34)
        courseNumberTxt.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F)
        Label2.Location = New Point(31, 141)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(121, 21)
        Label2.TabIndex = 1
        Label2.Text = "Course Number"
        ' 
        ' departmentTxt
        ' 
        departmentTxt.Font = New Font("Segoe UI", 12F)
        departmentTxt.Location = New Point(518, 135)
        departmentTxt.Margin = New Padding(2)
        departmentTxt.Multiline = True
        departmentTxt.Name = "departmentTxt"
        departmentTxt.Size = New Size(199, 34)
        departmentTxt.TabIndex = 0
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F)
        Label3.Location = New Point(410, 141)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(93, 21)
        Label3.TabIndex = 1
        Label3.Text = "Department"
        ' 
        ' creditHoursTxt
        ' 
        creditHoursTxt.Font = New Font("Segoe UI", 12F)
        creditHoursTxt.Location = New Point(518, 89)
        creditHoursTxt.Margin = New Padding(2)
        creditHoursTxt.Multiline = True
        creditHoursTxt.Name = "creditHoursTxt"
        creditHoursTxt.Size = New Size(199, 34)
        creditHoursTxt.TabIndex = 0
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F)
        Label4.Location = New Point(410, 95)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(98, 21)
        Label4.TabIndex = 1
        Label4.Text = "Credit Hours"
        ' 
        ' insertBtn
        ' 
        insertBtn.BackColor = Color.FromArgb(CByte(5), CByte(48), CByte(82))
        insertBtn.Font = New Font("Segoe UI", 12F)
        insertBtn.ForeColor = Color.White
        insertBtn.Location = New Point(26, 27)
        insertBtn.Margin = New Padding(2)
        insertBtn.Name = "insertBtn"
        insertBtn.Size = New Size(108, 41)
        insertBtn.TabIndex = 2
        insertBtn.Text = "Insert"
        insertBtn.UseVisualStyleBackColor = False
        ' 
        ' updateBtn
        ' 
        updateBtn.BackColor = Color.FromArgb(CByte(5), CByte(48), CByte(82))
        updateBtn.Font = New Font("Segoe UI", 12F)
        updateBtn.ForeColor = Color.White
        updateBtn.Location = New Point(149, 27)
        updateBtn.Margin = New Padding(2)
        updateBtn.Name = "updateBtn"
        updateBtn.Size = New Size(108, 41)
        updateBtn.TabIndex = 2
        updateBtn.Text = "Update"
        updateBtn.UseVisualStyleBackColor = False
        ' 
        ' deleteBtn
        ' 
        deleteBtn.BackColor = Color.FromArgb(CByte(5), CByte(48), CByte(82))
        deleteBtn.Font = New Font("Segoe UI", 12F)
        deleteBtn.ForeColor = Color.White
        deleteBtn.Location = New Point(270, 27)
        deleteBtn.Margin = New Padding(2)
        deleteBtn.Name = "deleteBtn"
        deleteBtn.Size = New Size(108, 41)
        deleteBtn.TabIndex = 2
        deleteBtn.Text = "Delete"
        deleteBtn.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(164), CByte(214), CByte(255))
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(creditHoursTxt)
        Panel1.Controls.Add(departmentTxt)
        Panel1.Controls.Add(courseNumberTxt)
        Panel1.Controls.Add(courseNameTxt)
        Panel1.Location = New Point(44, 91)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(760, 365)
        Panel1.TabIndex = 3
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(217), CByte(238), CByte(255))
        Panel2.Controls.Add(deleteBtn)
        Panel2.Controls.Add(updateBtn)
        Panel2.Controls.Add(insertBtn)
        Panel2.Location = New Point(190, 229)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(402, 96)
        Panel2.TabIndex = 3
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(Label6)
        Panel3.Controls.Add(Panel1)
        Panel3.Location = New Point(264, 135)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(850, 499)
        Panel3.TabIndex = 4
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.FromArgb(CByte(5), CByte(48), CByte(82))
        Label6.Font = New Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.White
        Label6.Location = New Point(342, 23)
        Label6.Name = "Label6"
        Label6.Size = New Size(207, 47)
        Label6.TabIndex = 41
        Label6.Text = "Edit Course"
        ' 
        ' EditCourse
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(0), CByte(160), CByte(221))
        ClientSize = New Size(1370, 749)
        Controls.Add(Panel3)
        Margin = New Padding(2)
        Name = "EditCourse"
        StartPosition = FormStartPosition.CenterScreen
        Text = "EditCourse"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents courseNameTxt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents courseNumberTxt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents departmentTxt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents creditHoursTxt As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents insertBtn As Button
    Friend WithEvents updateBtn As Button
    Friend WithEvents deleteBtn As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label6 As Label
End Class
