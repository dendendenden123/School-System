Imports MySql.Data.MySqlClient
Imports System.Runtime.InteropServices
Imports System.Drawing.Drawing2D

Public Class EditSection

    ' Define your connection string here
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

    ' On form load, apply styling
    Private Sub EditSection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Apply rounded corners to text boxes and buttons
        ApplyRoundedCorners(sectionIdentiferTxt, 30, 25)
        ApplyRoundedCorners(courseNumberTxt, 30, 25)
        ApplyRoundedCorners(semesterTxt, 30, 25)
        ApplyRoundedCorners(yearTxt, 30, 25)
        ApplyRoundedCorners(InstructorTxt, 30, 25)
        ApplyRoundedCorners(updateBtn, 60, 60)
        ApplyRoundedCorners(insertBtn, 60, 60)
        ApplyRoundedCorners(deleteBtn, 60, 60)
        ApplyRoundedCorners(Panel1, 20, 20)
        ApplyRoundedCorners(Panel2, 20, 20)
        ApplyRoundedCorners(Panel3, 20, 20)
        ApplyRoundedCorners(Label6, 20, 20)

        ' Center the Panel3 in the form
        CenterPanel(Panel3)
    End Sub

    ' Method to apply rounded corners
    Private Sub ApplyRoundedCorners(control As Control, width As Integer, height As Integer)
        Dim regionHandle As IntPtr = CreateRoundRectRgn(0, 0, control.Width, control.Height, width, height)
        control.Region = Region.FromHrgn(regionHandle)
    End Sub

    ' Method to center the panel (if any)
    Private Sub CenterPanel(panel As Panel)
        Dim x As Integer = (Me.ClientSize.Width - panel.Width) \ 2
        Dim y As Integer = (Me.ClientSize.Height - panel.Height) \ 2
        panel.Location = New Point(x, y)
    End Sub

    ' Custom painting for the form background
    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)

        Dim gradientBrush As New LinearGradientBrush(Me.ClientRectangle, Color.FromArgb(0, 112, 205), Color.FromArgb(0, 160, 221), 90)
        e.Graphics.FillRectangle(gradientBrush, Me.ClientRectangle)
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint
        Dim gradientBrush As New LinearGradientBrush(Panel3.ClientRectangle, Color.FromArgb(164, 214, 255), Color.FromArgb(0, 160, 221), 90)
        e.Graphics.FillRectangle(gradientBrush, Panel3.ClientRectangle)
    End Sub

    ' Insert Section Button
    Private Sub insertBtn_Click(sender As Object, e As EventArgs) Handles insertBtn.Click
        If ValidateInputs() Then
            ExecuteDatabaseOperation("INSERT", GetSectionData())
        End If
    End Sub

    ' Update Section Button
    Private Sub updateBtn_Click(sender As Object, e As EventArgs) Handles updateBtn.Click
        If ValidateInputs() Then
            ExecuteDatabaseOperation("UPDATE", GetSectionData())
        End If
    End Sub

    ' Delete Section Button
    Private Sub deleteBtn_Click(sender As Object, e As EventArgs) Handles deleteBtn.Click
        Dim sectionIdentifier As Integer
        If Integer.TryParse(sectionIdentiferTxt.Text, sectionIdentifier) Then
            Try
                Using connection As New MySqlConnection(connectionString)
                    connection.Open()
                    Dim query As String = "DELETE FROM SECTION WHERE Section_identifier = @Section_identifier;"
                    Using cmd As New MySqlCommand(query, connection)
                        cmd.Parameters.AddWithValue("@Section_identifier", sectionIdentifier)
                        cmd.ExecuteNonQuery()
                        MessageBox.Show("Section deleted successfully.")
                        ClearInputs()
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error deleting section: " & ex.Message)
            End Try
        Else
            MessageBox.Show("Invalid Section Identifier.")
        End If
    End Sub

    ' Validate inputs before processing
    Private Function ValidateInputs() As Boolean
        Dim sectionIdentifier, year As Integer
        If Not Integer.TryParse(sectionIdentiferTxt.Text, sectionIdentifier) Then
            MessageBox.Show("Invalid Section Identifier.")
            Return False
        End If
        If Not Integer.TryParse(yearTxt.Text, year) Then
            MessageBox.Show("Invalid Year.")
            Return False
        End If
        Return True
    End Function

    ' Get section data from inputs
    Private Function GetSectionData() As Dictionary(Of String, Object)
        Dim sectionData As New Dictionary(Of String, Object)
        sectionData("Section_identifier") = Integer.Parse(sectionIdentiferTxt.Text)
        sectionData("Course_number") = courseNumberTxt.Text
        sectionData("Semester") = semesterTxt.Text
        sectionData("Year") = Integer.Parse(yearTxt.Text)
        sectionData("Instructor") = InstructorTxt.Text
        Return sectionData
    End Function

    ' Execute database operation
    Private Sub ExecuteDatabaseOperation(operation As String, sectionData As Dictionary(Of String, Object))
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Dim query As String = If(operation = "INSERT",
                    "INSERT INTO SECTION (Section_identifier, Course_number, Semester, Year, Instructor) VALUES (@Section_identifier, @Course_number, @Semester, @Year, @Instructor)",
                    "UPDATE SECTION SET Course_number = @Course_number, Semester = @Semester, Year = @Year, Instructor = @Instructor WHERE Section_identifier = @Section_identifier")

                Using cmd As New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@Section_identifier", sectionData("Section_identifier"))
                    cmd.Parameters.AddWithValue("@Course_number", sectionData("Course_number"))
                    cmd.Parameters.AddWithValue("@Semester", sectionData("Semester"))
                    cmd.Parameters.AddWithValue("@Year", sectionData("Year"))
                    cmd.Parameters.AddWithValue("@Instructor", sectionData("Instructor"))
                    cmd.ExecuteNonQuery()
                    MessageBox.Show($"Section {operation.ToLower()}d successfully.")
                    ClearInputs()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error {operation.ToLower()}ing section: " & ex.Message)
        End Try
    End Sub

    ' Clear input fields after operation
    Private Sub ClearInputs()
        sectionIdentiferTxt.Clear()
        courseNumberTxt.Clear()
        semesterTxt.Clear()
        yearTxt.Clear()
        InstructorTxt.Clear()
    End Sub

End Class
