<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditPrerequisite
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
        Label1 = New Label()
        prerequisiteNumberTxt = New TextBox()
        courseNumberTxt = New TextBox()
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
        deleteBtn.Location = New Point(272, 21)
        deleteBtn.Margin = New Padding(2)
        deleteBtn.Name = "deleteBtn"
        deleteBtn.Size = New Size(108, 41)
        deleteBtn.TabIndex = 35
        deleteBtn.Text = "Delete"
        deleteBtn.UseVisualStyleBackColor = False
        ' 
        ' updateBtn
        ' 
        updateBtn.BackColor = Color.FromArgb(CByte(5), CByte(48), CByte(82))
        updateBtn.Font = New Font("Segoe UI", 12F)
        updateBtn.ForeColor = Color.White
        updateBtn.Location = New Point(151, 21)
        updateBtn.Margin = New Padding(2)
        updateBtn.Name = "updateBtn"
        updateBtn.Size = New Size(108, 41)
        updateBtn.TabIndex = 36
        updateBtn.Text = "Update"
        updateBtn.UseVisualStyleBackColor = False
        ' 
        ' insertBtn
        ' 
        insertBtn.BackColor = Color.FromArgb(CByte(5), CByte(48), CByte(82))
        insertBtn.Font = New Font("Segoe UI", 12F)
        insertBtn.ForeColor = Color.White
        insertBtn.Location = New Point(28, 21)
        insertBtn.Margin = New Padding(2)
        insertBtn.Name = "insertBtn"
        insertBtn.Size = New Size(108, 41)
        insertBtn.TabIndex = 37
        insertBtn.Text = "Insert"
        insertBtn.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F)
        Label4.Location = New Point(375, 97)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(155, 21)
        Label4.TabIndex = 32
        Label4.Text = "Prerequisite Number"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F)
        Label1.Location = New Point(19, 97)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(121, 21)
        Label1.TabIndex = 34
        Label1.Text = "Course Number"
        ' 
        ' prerequisiteNumberTxt
        ' 
        prerequisiteNumberTxt.Font = New Font("Segoe UI", 12F)
        prerequisiteNumberTxt.Location = New Point(544, 90)
        prerequisiteNumberTxt.Margin = New Padding(2)
        prerequisiteNumberTxt.Multiline = True
        prerequisiteNumberTxt.Name = "prerequisiteNumberTxt"
        prerequisiteNumberTxt.Size = New Size(199, 34)
        prerequisiteNumberTxt.TabIndex = 29
        ' 
        ' courseNumberTxt
        ' 
        courseNumberTxt.Font = New Font("Segoe UI", 12F)
        courseNumberTxt.Location = New Point(144, 90)
        courseNumberTxt.Margin = New Padding(2)
        courseNumberTxt.Multiline = True
        courseNumberTxt.Name = "courseNumberTxt"
        courseNumberTxt.Size = New Size(199, 34)
        courseNumberTxt.TabIndex = 31
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(164), CByte(214), CByte(255))
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(prerequisiteNumberTxt)
        Panel1.Controls.Add(courseNumberTxt)
        Panel1.Location = New Point(47, 106)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(763, 305)
        Panel1.TabIndex = 38
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(217), CByte(238), CByte(255))
        Panel2.Controls.Add(deleteBtn)
        Panel2.Controls.Add(updateBtn)
        Panel2.Controls.Add(insertBtn)
        Panel2.Location = New Point(194, 188)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(405, 84)
        Panel2.TabIndex = 38
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(Label6)
        Panel3.Controls.Add(Panel1)
        Panel3.Location = New Point(256, 137)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(862, 462)
        Panel3.TabIndex = 39
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.FromArgb(CByte(5), CByte(48), CByte(82))
        Label6.Font = New Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.White
        Label6.Location = New Point(299, 32)
        Label6.Name = "Label6"
        Label6.Size = New Size(294, 47)
        Label6.TabIndex = 39
        Label6.Text = "Edit Prerequisite"
        ' 
        ' EditPrerequisite
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(0), CByte(160), CByte(221))
        ClientSize = New Size(1370, 749)
        Controls.Add(Panel3)
        Margin = New Padding(2)
        Name = "EditPrerequisite"
        StartPosition = FormStartPosition.CenterScreen
        Text = "EditPrerequisite"
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
    Friend WithEvents Label1 As Label
    Friend WithEvents prerequisiteNumberTxt As TextBox
    Friend WithEvents courseNumberTxt As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label6 As Label
End Class
