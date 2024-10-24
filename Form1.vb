Imports MySql.Data.MySqlClient
Imports System.Drawing.Drawing2D
Imports System.Runtime.InteropServices

Public Class Form1

    ' Properties to store user type and user ID
    Public Property usertype As String
    Public Property userid As String

    ' Connection string for MySQL database
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

    ' Form Load Event
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Apply rounded corners to Panel1, Panel2, Panel3, Picturebox1 , studentnumberTxt
        ApplyRoundedCorners(Panel1, 20, 20)
        ApplyRoundedCorners(Panel2, 20, 20)
        ApplyRoundedCorners(Panel3, 20, 20)
        ApplyRoundedCorners(PictureBox1, 20, 20)
        ApplyRoundedCorners(studentnumberTxt, 25, 20)
        ApplyRoundedCorners(sectionIdentifierTxt, 25, 20)
        ' Center Panel1 in the form
        CenterPanel(Panel2)

        ' Add gradient background to the form
        Me.BackColor = Color.White
    End Sub

    ' Form Paint Event for Gradient Background
    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)

        ' Create a linear gradient brush for the form's background
        Dim gradientBrush As New LinearGradientBrush(Me.ClientRectangle, Color.FromArgb(0, 112, 205), Color.FromArgb(0, 160, 221), 90)
        e.Graphics.FillRectangle(gradientBrush, Me.ClientRectangle)
    End Sub

    ' Panel1 Paint Event for Gradient Background
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        ' Create a gradient brush for Panel1
        Dim gradientBrush As New LinearGradientBrush(Panel1.ClientRectangle, Color.FromArgb(0, 112, 205), Color.FromArgb(0, 160, 221), 90)
        e.Graphics.FillRectangle(gradientBrush, Panel1.ClientRectangle)
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint
        ' Create a gradient brush for Panel2
        Dim gradientBrush As New LinearGradientBrush(Panel2.ClientRectangle, Color.FromArgb(164, 214, 255), Color.FromArgb(0, 160, 221), 90)
        e.Graphics.FillRectangle(gradientBrush, Panel2.ClientRectangle)
    End Sub
    ' Function to Apply Rounded Corners to Controls
    Private Sub ApplyRoundedCorners(control As Control, width As Integer, height As Integer)
        ' Create a rounded rectangle region for the control
        Dim regionHandle As IntPtr = CreateRoundRectRgn(0, 0, control.Width, control.Height, width, height)
        control.Region = Region.FromHrgn(regionHandle)
    End Sub

    ' Function to Center a Panel in the Form
    Private Sub CenterPanel(panel As Panel)
        ' Calculate the new position for the panel to center it in the form
        Dim x As Integer = (Me.ClientSize.Width - panel.Width) \ 2
        Dim y As Integer = (Me.ClientSize.Height - panel.Height) \ 2
        panel.Location = New Point(x, y)
    End Sub

    ' Database Functionality (unchanged from original)
    Private Sub studentnumberTxt_TextChanged(sender As Object, e As EventArgs)
    End Sub

    Private Sub sectionIdentifierTxt_TextChanged(sender As Object, e As EventArgs)
    End Sub

    Private Sub enrollBtn_Click(sender As Object, e As EventArgs)
    End Sub

    Private Function CheckEnrollment(studentNumber As Integer, courseNumber As String) As Boolean
        Using conn As New MySqlConnection(connectionString)
            Dim sql As String = "SELECT * FROM GRADE_REPORT WHERE Student_number = @StudentNumber AND Section_identifier IN (SELECT Section_identifier FROM SECTION WHERE Course_number = @CourseNumber)"
            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@StudentNumber", studentNumber)
                cmd.Parameters.AddWithValue("@CourseNumber", courseNumber)
                conn.Open()
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                Return reader.HasRows
            End Using
        End Using
    End Function

    Private Function GetCourseNumber(sectionIdentifier As Integer) As String
        Using conn As New MySqlConnection(connectionString)
            Dim sql As String = "SELECT Course_number FROM SECTION WHERE Section_identifier = @SectionIdentifier"
            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@SectionIdentifier", sectionIdentifier)
                conn.Open()
                Dim result = cmd.ExecuteScalar()
                Return If(result IsNot Nothing, result.ToString(), String.Empty)
            End Using
        End Using
    End Function

    Private Function CheckPrerequisites(courseNumber As String, studentNumber As Integer) As Boolean
        Using conn As New MySqlConnection(connectionString)
            Dim sql As String = "SELECT Prerequisite_number FROM PREREQUISITE WHERE Course_number = @CourseNumber"
            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@CourseNumber", courseNumber)
                conn.Open()
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    Dim prereq As String = reader("Prerequisite_number").ToString()
                    If Not HasPassedPrerequisite(prereq, studentNumber) Then
                        Return False
                    End If
                End While
            End Using
        End Using
        Return True
    End Function

    Private Function HasPassedPrerequisite(prereq As String, studentNumber As Integer) As Boolean
        Using conn As New MySqlConnection(connectionString)
            Dim sql As String = "SELECT Grade FROM GRADE_REPORT WHERE Student_number = @StudentNumber AND Section_identifier IN (SELECT Section_identifier FROM SECTION WHERE Course_number = @Prereq)"
            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@StudentNumber", studentNumber)
                cmd.Parameters.AddWithValue("@Prereq", prereq)
                conn.Open()
                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                Return reader.HasRows
            End Using
        End Using
    End Function

    Private Sub EnrollStudent(studentNumber As Integer, sectionIdentifier As Integer)
        Using conn As New MySqlConnection(connectionString)
            Dim sql As String = "INSERT INTO GRADE_REPORT (Student_number, Section_identifier, Grade) VALUES (@StudentNumber, @SectionIdentifier, 'N')"
            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@StudentNumber", studentNumber)
                cmd.Parameters.AddWithValue("@SectionIdentifier", sectionIdentifier)
                conn.Open()
                cmd.ExecuteNonQuery()
                messageTxt.Text = "Student enrolled successfully."
                messageTxt.ForeColor = Color.Green
            End Using
        End Using
    End Sub

    ' Event handler for the enroll button
    Private Sub enrollBtn_Click_1(sender As Object, e As EventArgs) Handles enrollBtn.Click
        Dim studentNumber As Integer
        Dim sectionIdentifier As Integer

        If Not Integer.TryParse(studentnumberTxt.Text, studentNumber) Then
            messageTxt.Text = "Please enter a valid student number."
            messageTxt.ForeColor = Color.Red
            Return
        End If

        If Not Integer.TryParse(sectionIdentifierTxt.Text, sectionIdentifier) Then
            messageTxt.Text = "Please enter a valid section identifier."
            messageTxt.ForeColor = Color.Red
            Return
        End If

        ' Get the course number based on the section identifier
        Dim courseNumber = GetCourseNumber(sectionIdentifier)
        If String.IsNullOrEmpty(courseNumber) Then
            messageTxt.Text = "Section does not exist."
            messageTxt.ForeColor = Color.Red
            Return
        End If

        ' Check if the student is already enrolled in the same course
        If CheckEnrollment(studentNumber, courseNumber) Then
            messageTxt.Text = "Student is already enrolled in this course."
            messageTxt.ForeColor = Color.Red
        ElseIf CheckPrerequisites(courseNumber, studentNumber) Then
            EnrollStudent(studentNumber, sectionIdentifier)
        Else
            messageTxt.Text = "Student does not meet the prerequisites for this course."
            messageTxt.ForeColor = Color.Red
        End If
    End Sub

    Private Sub messageTxt_Click(sender As Object, e As EventArgs) Handles messageTxt.Click
    End Sub
End Class
