<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        courseTable = New DataGridView()
        gradereportTable = New DataGridView()
        prerequisiteTable = New DataGridView()
        sectionTable = New DataGridView()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        editCourseBtn = New Button()
        editSectionBtn = New Button()
        editGradeReportBtn = New Button()
        refreshBtn = New Button()
        editPrerequisiteBtn = New Button()
        Label5 = New Label()
        Button1 = New Button()
        MySqlCommand1 = New MySql.Data.MySqlClient.MySqlCommand()
        studentTable = New DataGridView()
        Label6 = New Label()
        editStudenBtn = New Button()
        Panel2 = New Panel()
        Panel4 = New Panel()
        Panel5 = New Panel()
        Panel6 = New Panel()
        Label8 = New Label()
        Panel7 = New Panel()
        Panel8 = New Panel()
        Panel1 = New Panel()
        Label7 = New Label()
        LogOutAdmin = New Button()
        Panel9 = New Panel()
        Button2 = New Button()
        PictureBox1 = New PictureBox()
        Panel3 = New Panel()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        CType(courseTable, ComponentModel.ISupportInitialize).BeginInit()
        CType(gradereportTable, ComponentModel.ISupportInitialize).BeginInit()
        CType(prerequisiteTable, ComponentModel.ISupportInitialize).BeginInit()
        CType(sectionTable, ComponentModel.ISupportInitialize).BeginInit()
        CType(studentTable, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel6.SuspendLayout()
        Panel1.SuspendLayout()
        Panel9.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' courseTable
        ' 
        courseTable.BackgroundColor = Color.White
        courseTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        courseTable.Location = New Point(18, 43)
        courseTable.Margin = New Padding(2, 3, 2, 3)
        courseTable.Name = "courseTable"
        courseTable.RowHeadersWidth = 62
        courseTable.Size = New Size(575, 245)
        courseTable.TabIndex = 0
        ' 
        ' gradereportTable
        ' 
        gradereportTable.BackgroundColor = Color.White
        gradereportTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        gradereportTable.Location = New Point(621, 43)
        gradereportTable.Margin = New Padding(2, 3, 2, 3)
        gradereportTable.Name = "gradereportTable"
        gradereportTable.RowHeadersWidth = 62
        gradereportTable.Size = New Size(563, 245)
        gradereportTable.TabIndex = 0
        ' 
        ' prerequisiteTable
        ' 
        prerequisiteTable.BackgroundColor = Color.White
        prerequisiteTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        prerequisiteTable.Location = New Point(400, 677)
        prerequisiteTable.Margin = New Padding(2, 3, 2, 3)
        prerequisiteTable.Name = "prerequisiteTable"
        prerequisiteTable.RowHeadersWidth = 62
        prerequisiteTable.Size = New Size(424, 209)
        prerequisiteTable.TabIndex = 0
        ' 
        ' sectionTable
        ' 
        sectionTable.BackgroundColor = Color.White
        sectionTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        sectionTable.Location = New Point(621, 359)
        sectionTable.Margin = New Padding(2, 3, 2, 3)
        sectionTable.Name = "sectionTable"
        sectionTable.RowHeadersWidth = 62
        sectionTable.Size = New Size(563, 245)
        sectionTable.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.FromArgb(CByte(5), CByte(48), CByte(82))
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(272, 9)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(76, 28)
        Label1.TabIndex = 1
        Label1.Text = "Course"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.FromArgb(CByte(5), CByte(48), CByte(82))
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(851, 9)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(139, 28)
        Label2.TabIndex = 1
        Label2.Text = "Grade Report"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.FromArgb(CByte(5), CByte(48), CByte(82))
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = Color.White
        Label3.Location = New Point(561, 639)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(126, 28)
        Label3.TabIndex = 1
        Label3.Text = "Prerequisite"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.FromArgb(CByte(5), CByte(48), CByte(82))
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = Color.White
        Label4.Location = New Point(874, 323)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(91, 28)
        Label4.TabIndex = 1
        Label4.Text = "Sections"
        ' 
        ' editCourseBtn
        ' 
        editCourseBtn.BackColor = Color.FromArgb(CByte(5), CByte(48), CByte(82))
        editCourseBtn.Font = New Font("Segoe UI", 11.5F)
        editCourseBtn.ForeColor = Color.White
        editCourseBtn.Location = New Point(15, 28)
        editCourseBtn.Margin = New Padding(2, 3, 2, 3)
        editCourseBtn.Name = "editCourseBtn"
        editCourseBtn.Size = New Size(171, 53)
        editCourseBtn.TabIndex = 2
        editCourseBtn.Text = "Edit Course"
        editCourseBtn.UseVisualStyleBackColor = False
        ' 
        ' editSectionBtn
        ' 
        editSectionBtn.BackColor = Color.FromArgb(CByte(5), CByte(48), CByte(82))
        editSectionBtn.Font = New Font("Segoe UI", 11.5F)
        editSectionBtn.ForeColor = Color.White
        editSectionBtn.Location = New Point(15, 288)
        editSectionBtn.Margin = New Padding(2, 3, 2, 3)
        editSectionBtn.Name = "editSectionBtn"
        editSectionBtn.Size = New Size(171, 53)
        editSectionBtn.TabIndex = 2
        editSectionBtn.Text = "Edit Sections"
        editSectionBtn.UseVisualStyleBackColor = False
        ' 
        ' editGradeReportBtn
        ' 
        editGradeReportBtn.BackColor = Color.FromArgb(CByte(5), CByte(48), CByte(82))
        editGradeReportBtn.Font = New Font("Segoe UI", 11.5F)
        editGradeReportBtn.ForeColor = Color.White
        editGradeReportBtn.Location = New Point(15, 113)
        editGradeReportBtn.Margin = New Padding(2, 3, 2, 3)
        editGradeReportBtn.Name = "editGradeReportBtn"
        editGradeReportBtn.Size = New Size(171, 53)
        editGradeReportBtn.TabIndex = 2
        editGradeReportBtn.Text = "Edit Grade "
        editGradeReportBtn.UseVisualStyleBackColor = False
        ' 
        ' refreshBtn
        ' 
        refreshBtn.BackColor = Color.FromArgb(CByte(0), CByte(160), CByte(221))
        refreshBtn.Font = New Font("Segoe UI", 10F)
        refreshBtn.ForeColor = Color.Black
        refreshBtn.Location = New Point(19, 832)
        refreshBtn.Margin = New Padding(2, 3, 2, 3)
        refreshBtn.Name = "refreshBtn"
        refreshBtn.Size = New Size(118, 40)
        refreshBtn.TabIndex = 2
        refreshBtn.Text = "Refresh"
        refreshBtn.UseVisualStyleBackColor = False
        ' 
        ' editPrerequisiteBtn
        ' 
        editPrerequisiteBtn.BackColor = Color.FromArgb(CByte(5), CByte(48), CByte(82))
        editPrerequisiteBtn.Font = New Font("Segoe UI", 11.5F)
        editPrerequisiteBtn.ForeColor = Color.White
        editPrerequisiteBtn.Location = New Point(15, 373)
        editPrerequisiteBtn.Margin = New Padding(2, 3, 2, 3)
        editPrerequisiteBtn.Name = "editPrerequisiteBtn"
        editPrerequisiteBtn.Size = New Size(171, 53)
        editPrerequisiteBtn.TabIndex = 2
        editPrerequisiteBtn.Text = "Edit Prerequisite"
        editPrerequisiteBtn.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.FromArgb(CByte(5), CByte(48), CByte(82))
        Label5.Font = New Font("Segoe UI", 17F, FontStyle.Bold)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(18, 25)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(306, 40)
        Label5.TabIndex = 3
        Label5.Text = "ADMIN DASHBOARD"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(1602, 63)
        Button1.Margin = New Padding(2, 3, 2, 3)
        Button1.Name = "Button1"
        Button1.Size = New Size(88, 29)
        Button1.TabIndex = 4
        Button1.Text = "LOG OUT"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' MySqlCommand1
        ' 
        MySqlCommand1.CacheAge = 0
        MySqlCommand1.Connection = Nothing
        MySqlCommand1.EnableCaching = False
        MySqlCommand1.Transaction = Nothing
        ' 
        ' studentTable
        ' 
        studentTable.BackgroundColor = Color.White
        studentTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        studentTable.Location = New Point(18, 359)
        studentTable.Name = "studentTable"
        studentTable.RowHeadersWidth = 51
        studentTable.Size = New Size(575, 245)
        studentTable.TabIndex = 5
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.FromArgb(CByte(5), CByte(48), CByte(82))
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.White
        Label6.Location = New Point(272, 323)
        Label6.Margin = New Padding(2, 0, 2, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(86, 28)
        Label6.TabIndex = 1
        Label6.Text = "Student"
        ' 
        ' editStudenBtn
        ' 
        editStudenBtn.BackColor = Color.FromArgb(CByte(5), CByte(48), CByte(82))
        editStudenBtn.Font = New Font("Segoe UI", 11.5F)
        editStudenBtn.ForeColor = Color.White
        editStudenBtn.Location = New Point(15, 200)
        editStudenBtn.Name = "editStudenBtn"
        editStudenBtn.Size = New Size(171, 53)
        editStudenBtn.TabIndex = 6
        editStudenBtn.Text = "Edit Student"
        editStudenBtn.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(0), CByte(160), CByte(221))
        Panel2.Controls.Add(courseTable)
        Panel2.Controls.Add(gradereportTable)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(prerequisiteTable)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(sectionTable)
        Panel2.Controls.Add(Label6)
        Panel2.Controls.Add(studentTable)
        Panel2.Controls.Add(Panel4)
        Panel2.Controls.Add(Panel5)
        Panel2.Controls.Add(Panel6)
        Panel2.Controls.Add(Panel7)
        Panel2.Controls.Add(Panel8)
        Panel2.Location = New Point(315, 16)
        Panel2.Margin = New Padding(3, 4, 3, 4)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1215, 913)
        Panel2.TabIndex = 12
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(5), CByte(48), CByte(82))
        Panel4.Location = New Point(31, 56)
        Panel4.Margin = New Padding(3, 4, 3, 4)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(576, 245)
        Panel4.TabIndex = 47
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.FromArgb(CByte(5), CByte(48), CByte(82))
        Panel5.Location = New Point(638, 56)
        Panel5.Margin = New Padding(3, 4, 3, 4)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(560, 245)
        Panel5.TabIndex = 48
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.FromArgb(CByte(5), CByte(48), CByte(82))
        Panel6.Controls.Add(Label8)
        Panel6.Location = New Point(31, 371)
        Panel6.Margin = New Padding(3, 4, 3, 4)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(576, 245)
        Panel6.TabIndex = 49
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(571, 148)
        Label8.Name = "Label8"
        Label8.Size = New Size(53, 20)
        Label8.TabIndex = 0
        Label8.Text = "Label8"
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.FromArgb(CByte(5), CByte(48), CByte(82))
        Panel7.Location = New Point(638, 371)
        Panel7.Margin = New Padding(3, 4, 3, 4)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(560, 245)
        Panel7.TabIndex = 50
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = Color.FromArgb(CByte(5), CByte(48), CByte(82))
        Panel8.Location = New Point(410, 693)
        Panel8.Margin = New Padding(3, 4, 3, 4)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(427, 209)
        Panel8.TabIndex = 51
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(164), CByte(214), CByte(255))
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(LogOutAdmin)
        Panel1.Controls.Add(Panel9)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(refreshBtn)
        Panel1.Location = New Point(18, 91)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(279, 895)
        Panel1.TabIndex = 13
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.FromArgb(CByte(5), CByte(48), CByte(82))
        Label7.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        Label7.ForeColor = Color.White
        Label7.Location = New Point(82, 233)
        Label7.Margin = New Padding(2, 0, 2, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(130, 28)
        Label7.TabIndex = 10
        Label7.Text = "Admin (123)"
        ' 
        ' LogOutAdmin
        ' 
        LogOutAdmin.BackColor = Color.FromArgb(CByte(5), CByte(48), CByte(82))
        LogOutAdmin.Font = New Font("Segoe UI", 10F)
        LogOutAdmin.ForeColor = Color.White
        LogOutAdmin.Location = New Point(142, 832)
        LogOutAdmin.Margin = New Padding(2, 3, 2, 3)
        LogOutAdmin.Name = "LogOutAdmin"
        LogOutAdmin.Size = New Size(118, 40)
        LogOutAdmin.TabIndex = 9
        LogOutAdmin.Text = "LogOut"
        LogOutAdmin.UseVisualStyleBackColor = False
        ' 
        ' Panel9
        ' 
        Panel9.BackColor = Color.FromArgb(CByte(217), CByte(238), CByte(255))
        Panel9.Controls.Add(Button2)
        Panel9.Controls.Add(editCourseBtn)
        Panel9.Controls.Add(editGradeReportBtn)
        Panel9.Controls.Add(editPrerequisiteBtn)
        Panel9.Controls.Add(editSectionBtn)
        Panel9.Controls.Add(editStudenBtn)
        Panel9.Location = New Point(40, 297)
        Panel9.Margin = New Padding(3, 4, 3, 4)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(200, 514)
        Panel9.TabIndex = 8
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        Button2.Font = New Font("Segoe UI", 11.5F)
        Button2.ForeColor = Color.White
        Button2.Location = New Point(15, 442)
        Button2.Margin = New Padding(2, 3, 2, 3)
        Button2.Name = "Button2"
        Button2.Size = New Size(171, 53)
        Button2.TabIndex = 7
        Button2.Text = "Register User"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(55, 28)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(171, 185)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 7
        PictureBox1.TabStop = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(5), CByte(48), CByte(82))
        Panel3.Location = New Point(343, 56)
        Panel3.Margin = New Padding(3, 4, 3, 4)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1209, 893)
        Panel3.TabIndex = 46
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(217), CByte(238), CByte(255))
        ClientSize = New Size(1566, 999)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(Button1)
        Controls.Add(Label5)
        Controls.Add(Panel3)
        Margin = New Padding(2, 3, 2, 3)
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form2"
        WindowState = FormWindowState.Maximized
        CType(courseTable, ComponentModel.ISupportInitialize).EndInit()
        CType(gradereportTable, ComponentModel.ISupportInitialize).EndInit()
        CType(prerequisiteTable, ComponentModel.ISupportInitialize).EndInit()
        CType(sectionTable, ComponentModel.ISupportInitialize).EndInit()
        CType(studentTable, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel9.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents courseTable As DataGridView
    Friend WithEvents gradereportTable As DataGridView
    Friend WithEvents prerequisiteTable As DataGridView
    Friend WithEvents sectionTable As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents editCourseBtn As Button
    Friend WithEvents editSectionBtn As Button
    Friend WithEvents editGradeReportBtn As Button
    Friend WithEvents refreshBtn As Button
    Friend WithEvents editPrerequisiteBtn As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents MySqlCommand1 As MySql.Data.MySqlClient.MySqlCommand
    Friend WithEvents studentTable As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents editStudenBtn As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents LogOutAdmin As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Button2 As Button
End Class
