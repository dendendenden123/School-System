Imports MySql.Data.MySqlClient
Imports System.Runtime.InteropServices
Imports System.Drawing.Drawing2D

Public Class EditStudent
    Private connectionString As String = "Server=localhost;Database=school_system;User Id=root;Password=;"

    ' Property to hold the student number passed from the main form
    Public Property StudentNumber As String

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

    ' On form load, retrieve the student information and apply styling
    Private Sub EditStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' If a student number is provided, load the student data
        If Not String.IsNullOrEmpty(StudentNumber) Then
            LoadStudentData(StudentNumber)
        End If

        ' Apply rounded corners to text boxes, buttons, and labels
        ApplyRoundedCorners(studentNumberTxt, 30, 25)
        ApplyRoundedCorners(passwordTxt, 30, 25)
        ApplyRoundedCorners(firstNameTxt, 30, 25)
        ApplyRoundedCorners(middleNameTxt, 30, 25)
        ApplyRoundedCorners(lastNameTxt, 30, 25)
        ApplyRoundedCorners(addressTxt, 30, 25)
        ApplyRoundedCorners(updateBtn, 60, 60)
        ApplyRoundedCorners(insertBtn, 60, 60)
        ApplyRoundedCorners(deleteBtn, 60, 60)
        ApplyRoundedCorners(TextBox2, 20, 20)
        ApplyRoundedCorners(Label6, 20, 20)

        ' Apply rounded corners to panels
        ApplyRoundedCorners(Panel1, 20, 20)
        ApplyRoundedCorners(Panel2, 20, 20)
        ApplyRoundedCorners(Panel3, 20, 20)

        ' Center the Panel1 in the form
        CenterPanel(Panel1)
    End Sub

    ' Method to load student data into the fields
    Private Sub LoadStudentData(studentNumber As String)
        Using conn As New MySqlConnection(connectionString)
            Dim query As String = "SELECT * FROM STUDENT WHERE student_number = @studentNumber"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@studentNumber", studentNumber)

                Try
                    conn.Open()
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            studentNumberTxt.Text = reader("student_number").ToString()
                            passwordTxt.Text = reader("password").ToString()
                            firstNameTxt.Text = reader("name").ToString()
                            middleNameTxt.Text = reader("middleName").ToString()
                            lastNameTxt.Text = reader("lastName").ToString()
                            addressTxt.Text = reader("address").ToString()
                        End If
                    End Using
                Catch ex As MySqlException
                    MessageBox.Show("Error loading student data: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    ' Method to apply rounded corners
    Private Sub ApplyRoundedCorners(control As Control, width As Integer, height As Integer)
        ' Create a rounded rectangle region for the control
        Dim regionHandle As IntPtr = CreateRoundRectRgn(0, 0, control.Width, control.Height, width, height)
        control.Region = Region.FromHrgn(regionHandle)
    End Sub

    ' Method to center the panel
    Private Sub CenterPanel(panel As Panel)
        ' Calculate the new position for the panel to center it in the form
        Dim x As Integer = (Me.ClientSize.Width - panel.Width) \ 2
        Dim y As Integer = (Me.ClientSize.Height - panel.Height) \ 2
        panel.Location = New Point(x, y)
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)

        ' Create a linear gradient brush for the background
        Dim gradientBrush As New LinearGradientBrush(Me.ClientRectangle, Color.FromArgb(0, 112, 205), Color.FromArgb(0, 160, 221), 90)
        e.Graphics.FillRectangle(gradientBrush, Me.ClientRectangle)
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        ' Create a gradient brush for Panel1
        Dim gradientBrush As New LinearGradientBrush(Panel1.ClientRectangle, Color.FromArgb(164, 214, 255), Color.FromArgb(0, 160, 221), 90)
        e.Graphics.FillRectangle(gradientBrush, Panel1.ClientRectangle)
    End Sub


    ' Method to update student data when the update button is clicked
    Private Sub updateBtn_Click(sender As Object, e As EventArgs) Handles updateBtn.Click
        Using conn As New MySqlConnection(connectionString)
            Dim query As String = "UPDATE STUDENT SET password = @password, name = @firstName, middleName = @middleName, lastName = @lastName, address = @address WHERE student_number = @studentNumber"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@studentNumber", studentNumberTxt.Text)
                cmd.Parameters.AddWithValue("@password", passwordTxt.Text)
                cmd.Parameters.AddWithValue("@firstName", firstNameTxt.Text)
                cmd.Parameters.AddWithValue("@middleName", middleNameTxt.Text)
                cmd.Parameters.AddWithValue("@lastName", lastNameTxt.Text)
                cmd.Parameters.AddWithValue("@address", addressTxt.Text)

                Try
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Student updated successfully!")
                Catch ex As MySqlException
                    MessageBox.Show("Error updating student: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    ' Method to insert a new student when the insert button is clicked
    Private Sub insertBtn_Click(sender As Object, e As EventArgs) Handles insertBtn.Click
        Using conn As New MySqlConnection(connectionString)
            Dim query As String = "INSERT INTO STUDENT (student_number, password, name, middleName, lastName, address) VALUES (@studentNumber, @password, @firstName, @middleName, @lastName, @address)"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@studentNumber", studentNumberTxt.Text)
                cmd.Parameters.AddWithValue("@password", passwordTxt.Text)
                cmd.Parameters.AddWithValue("@firstName", firstNameTxt.Text)
                cmd.Parameters.AddWithValue("@middleName", middleNameTxt.Text)
                cmd.Parameters.AddWithValue("@lastName", lastNameTxt.Text)
                cmd.Parameters.AddWithValue("@address", addressTxt.Text)

                Try
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Student added successfully!")
                Catch ex As MySqlException
                    MessageBox.Show("Error adding student: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    ' Method to delete a student when the delete button is clicked
    Private Sub deleteBtn_Click(sender As Object, e As EventArgs) Handles deleteBtn.Click
        Using conn As New MySqlConnection(connectionString)
            Dim query As String = "DELETE FROM STUDENT WHERE student_number = @studentNumber"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@studentNumber", studentNumberTxt.Text)

                Try
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Student deleted successfully!")
                Catch ex As MySqlException
                    MessageBox.Show("Error deleting student: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

End Class
