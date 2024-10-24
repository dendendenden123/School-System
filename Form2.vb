Imports System.Runtime.InteropServices
Imports System.Drawing.Drawing2D
Imports MySql.Data.MySqlClient

Public Class Form2
    Private connectionString As String = "Server=localhost;Database=school_system;User Id=root;Password=;"

    ' Import the CreateRoundRectRgn function from gdi32.dll
    <DllImport("gdi32.dll", EntryPoint:="CreateRoundRectRgn")>
    Private Shared Function CreateRoundRectRgn(
        nLeftRect As Integer,
        nTopRect As Integer,
        nRightRect As Integer,
        nBottomRect As Integer,
        nWidthEllipse As Integer,
        nHeightEllipse As Integer
    ) As IntPtr
    End Function

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Apply rounded corners to labels , buttons, and panels
        ApplyRoundedCorners(Panel1, 20, 20)
        ApplyRoundedCorners(Panel2, 20, 20)
        ApplyRoundedCorners(Panel3, 20, 20)
        ApplyRoundedCorners(Panel4, 20, 20)
        ApplyRoundedCorners(Panel5, 20, 20)
        ApplyRoundedCorners(Panel6, 20, 20)
        ApplyRoundedCorners(Panel7, 20, 20)
        ApplyRoundedCorners(Panel8, 20, 20)
        ApplyRoundedCorners(Panel9, 20, 20)
        ApplyRoundedCorners(Label1, 20, 20)
        ApplyRoundedCorners(Label2, 20, 20)
        ApplyRoundedCorners(Label3, 20, 20)
        ApplyRoundedCorners(Label4, 20, 20)
        ApplyRoundedCorners(Label5, 20, 20)
        ApplyRoundedCorners(Label6, 20, 20)
        ApplyRoundedCorners(Label7, 20, 20)
        ApplyRoundedCorners(PictureBox1, 20, 20)
        ApplyRoundedCorners(editCourseBtn, 55, 55)
        ApplyRoundedCorners(editSectionBtn, 55, 55)
        ApplyRoundedCorners(editGradeReportBtn, 55, 55)
        ApplyRoundedCorners(editPrerequisiteBtn, 55, 55)
        ApplyRoundedCorners(editStudenBtn, 55, 55)
        ApplyRoundedCorners(refreshBtn, 55, 55)
        ApplyRoundedCorners(LogOutAdmin, 55, 55)

        ' Apply rounded corners to DataGridView controls
        ApplyRoundedCorners(courseTable, 20, 20)
        ApplyRoundedCorners(gradereportTable, 20, 20)
        ApplyRoundedCorners(prerequisiteTable, 20, 20)
        ApplyRoundedCorners(sectionTable, 20, 20)
        ApplyRoundedCorners(studentTable, 20, 20)

        ' Load data for all tables
        LoadCourseTable()
        LoadGradeReportTable()
        LoadPrerequisiteTable()
        LoadSectionTable()
        LoadStudentTable()
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)

        ' Create a linear gradient brush for the background
        Dim gradientBrush As New LinearGradientBrush(Me.ClientRectangle, Color.FromArgb(217, 238, 255), Color.FromArgb(0, 160, 221), 90)
        e.Graphics.FillRectangle(gradientBrush, Me.ClientRectangle)
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        ' Create a gradient brush for Panel1
        Dim gradientBrush As New LinearGradientBrush(Panel1.ClientRectangle, Color.FromArgb(0, 160, 221), Color.FromArgb(164, 214, 255), 90)
        e.Graphics.FillRectangle(gradientBrush, Panel1.ClientRectangle)
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint
        ' Create a gradient brush for Panel1
        Dim gradientBrush As New LinearGradientBrush(Panel2.ClientRectangle, Color.FromArgb(0, 112, 205), Color.FromArgb(0, 160, 221), 90)
        e.Graphics.FillRectangle(gradientBrush, Panel2.ClientRectangle)
    End Sub
    Private Sub ApplyRoundedCorners(control As Control, width As Integer, height As Integer)
        ' Create a rounded rectangle region for the control
        Dim regionHandle As IntPtr = CreateRoundRectRgn(0, 0, control.Width, control.Height, width, height)
        control.Region = Region.FromHrgn(regionHandle)
    End Sub

    ' Load Course table
    Private Sub LoadCourseTable()
        Using conn As New MySqlConnection(connectionString)
            Dim query As String = "SELECT * FROM COURSE"
            Dim adapter As New MySqlDataAdapter(query, conn)
            Dim table As New DataTable()
            Try
                conn.Open()
                adapter.Fill(table)
                courseTable.DataSource = table
            Catch ex As MySqlException
                MessageBox.Show("Error loading COURSE table: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Load Grade Report table
    Private Sub LoadGradeReportTable()
        Using conn As New MySqlConnection(connectionString)
            Dim query As String = "SELECT * FROM GRADE_REPORT"
            Dim adapter As New MySqlDataAdapter(query, conn)
            Dim table As New DataTable()
            Try
                conn.Open()
                adapter.Fill(table)
                gradereportTable.DataSource = table
            Catch ex As MySqlException
                MessageBox.Show("Error loading GRADE_REPORT table: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Load Prerequisite table
    Private Sub LoadPrerequisiteTable()
        Using conn As New MySqlConnection(connectionString)
            Dim query As String = "SELECT * FROM PREREQUISITE"
            Dim adapter As New MySqlDataAdapter(query, conn)
            Dim table As New DataTable()
            Try
                conn.Open()
                adapter.Fill(table)
                prerequisiteTable.DataSource = table
            Catch ex As MySqlException
                MessageBox.Show("Error loading PREREQUISITE table: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Load Section table
    Private Sub LoadSectionTable()
        Using conn As New MySqlConnection(connectionString)
            Dim query As String = "SELECT * FROM SECTION"
            Dim adapter As New MySqlDataAdapter(query, conn)
            Dim table As New DataTable()
            Try
                conn.Open()
                adapter.Fill(table)
                sectionTable.DataSource = table
            Catch ex As MySqlException
                MessageBox.Show("Error loading SECTION table: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Load Student table
    Private Sub LoadStudentTable()
        Using conn As New MySqlConnection(connectionString)
            Dim query As String = "SELECT * FROM student"
            Dim adapter As New MySqlDataAdapter(query, conn)
            Dim table As New DataTable()
            Try
                conn.Open()
                adapter.Fill(table)
                studentTable.DataSource = table
            Catch ex As MySqlException
                MessageBox.Show("Error loading STUDENT table: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Button click event handlers
    Private Sub editCourseBtn_Click(sender As Object, e As EventArgs) Handles editCourseBtn.Click
        Dim editCourse As New EditCourse
        editCourse.Show()
    End Sub

    Private Sub editSectionBtn_Click(sender As Object, e As EventArgs) Handles editSectionBtn.Click
        Dim editSection As New EditSection
        editSection.Show()
    End Sub

    Private Sub editGradeReportBtn_Click(sender As Object, e As EventArgs) Handles editGradeReportBtn.Click
        Dim editGrade As New EditGrade
        editGrade.Show()
    End Sub

    Private Sub editPrerequisiteBtn_Click(sender As Object, e As EventArgs) Handles editPrerequisiteBtn.Click
        Dim editPrerequisite As New EditPrerequisite
        editPrerequisite.Show
    End Sub

    Private Sub refreshBtn_Click(sender As Object, e As EventArgs) Handles refreshBtn.Click
        LoadCourseTable()
        LoadGradeReportTable()
        LoadPrerequisiteTable()
        LoadSectionTable()
        LoadStudentTable() ' Refresh student data when refresh button is clicked
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim form3 As New Form3
        form3.Show()
        Me.Hide()
    End Sub

    Private Sub gradereportTable_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gradereportTable.CellContentClick
        ' Handle actions when a cell is clicked in the Grade Report table
    End Sub

    Private Sub prerequisiteTable_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles prerequisiteTable.CellContentClick
        ' Handle actions when a cell is clicked in the Prerequisite table
    End Sub

    Private Sub sectionTable_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles sectionTable.CellContentClick
        ' Handle actions when a cell is clicked in the Section table
    End Sub

    Private Sub studentTable_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles studentTable.CellContentClick
        ' Handle actions when a cell is clicked in the Student table
    End Sub

    Private Sub editStudenBtn_Click(sender As Object, e As EventArgs) Handles editStudenBtn.Click
        Dim student As New EditStudent
        student.Show()
    End Sub

    Private Sub LogOutAdmin_Click(sender As Object, e As EventArgs) Handles LogOutAdmin.Click
        Dim form3 As New Form3
        form3.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim reg As New registerUserType
        reg.Show()
    End Sub
End Class
