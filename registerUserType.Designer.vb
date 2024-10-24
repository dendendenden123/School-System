<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class registerUserType
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
        Label5 = New Label()
        adminBtn = New Button()
        instructorBtn = New Button()
        studentBtn = New Button()
        SuspendLayout()
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.FromArgb(CByte(5), CByte(48), CByte(82))
        Label5.Font = New Font("Segoe UI", 17F, FontStyle.Bold)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(297, 41)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(297, 40)
        Label5.TabIndex = 4
        Label5.Text = "SELECT A USER TYPE"
        ' 
        ' adminBtn
        ' 
        adminBtn.BackColor = Color.DodgerBlue
        adminBtn.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold)
        adminBtn.ForeColor = Color.White
        adminBtn.Location = New Point(133, 121)
        adminBtn.Margin = New Padding(2, 3, 2, 3)
        adminBtn.Name = "adminBtn"
        adminBtn.Size = New Size(171, 53)
        adminBtn.TabIndex = 5
        adminBtn.Text = "ADMIN"
        adminBtn.UseVisualStyleBackColor = False
        ' 
        ' instructorBtn
        ' 
        instructorBtn.BackColor = Color.MediumSlateBlue
        instructorBtn.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold)
        instructorBtn.ForeColor = Color.White
        instructorBtn.Location = New Point(364, 121)
        instructorBtn.Margin = New Padding(2, 3, 2, 3)
        instructorBtn.Name = "instructorBtn"
        instructorBtn.Size = New Size(171, 53)
        instructorBtn.TabIndex = 5
        instructorBtn.Text = "INSTRUCTOR"
        instructorBtn.UseVisualStyleBackColor = False
        ' 
        ' studentBtn
        ' 
        studentBtn.BackColor = Color.Indigo
        studentBtn.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold)
        studentBtn.ForeColor = Color.White
        studentBtn.Location = New Point(593, 121)
        studentBtn.Margin = New Padding(2, 3, 2, 3)
        studentBtn.Name = "studentBtn"
        studentBtn.Size = New Size(171, 53)
        studentBtn.TabIndex = 5
        studentBtn.Text = "STUDENT"
        studentBtn.UseVisualStyleBackColor = False
        ' 
        ' registerUserType
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(0), CByte(160), CByte(225))
        ClientSize = New Size(908, 247)
        Controls.Add(studentBtn)
        Controls.Add(instructorBtn)
        Controls.Add(adminBtn)
        Controls.Add(Label5)
        Name = "registerUserType"
        StartPosition = FormStartPosition.CenterScreen
        Text = "REGISTER"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents adminBtn As Button
    Friend WithEvents instructorBtn As Button
    Friend WithEvents studentBtn As Button
End Class
