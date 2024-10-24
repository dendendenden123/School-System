Imports MySql.Data.MySqlClient
Imports System.Runtime.InteropServices
Imports System.Drawing.Drawing2D

Public Class EditCourse
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
    Private Sub EditCourse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Apply rounded corners to text boxes and buttons
        ApplyRoundedCorners(courseNameTxt, 30, 25)
        ApplyRoundedCorners(courseNumberTxt, 30, 25)
        ApplyRoundedCorners(creditHoursTxt, 30, 25)
        ApplyRoundedCorners(departmentTxt, 30, 25)
        ApplyRoundedCorners(insertBtn, 60, 60)
        ApplyRoundedCorners(updateBtn, 60, 60)
        ApplyRoundedCorners(deleteBtn, 60, 60)
        ApplyRoundedCorners(Panel1, 20, 20)
        ApplyRoundedCorners(Panel2, 20, 20)
        ApplyRoundedCorners(Panel3, 20, 20)
        ApplyRoundedCorners(Label6, 20, 20)

        ' Center the Panel1 in the form
        CenterPanel(Panel3)
    End Sub

    ' Method to apply rounded corners
    Private Sub ApplyRoundedCorners(control As Control, width As Integer, height As Integer)
        ' Create a rounded rectangle region for the control
        Dim regionHandle As IntPtr = CreateRoundRectRgn(0, 0, control.Width, control.Height, width, height)
        control.Region = Region.FromHrgn(regionHandle)
    End Sub

    ' Method to center the panel (if any)
    Private Sub CenterPanel(panel As Panel)
        ' Calculate the new position for the panel to center it in the form
        Dim x As Integer = (Me.ClientSize.Width - panel.Width) \ 2
        Dim y As Integer = (Me.ClientSize.Height - panel.Height) \ 2
        panel.Location = New Point(x, y)
    End Sub

    ' Custom painting for the form background
    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)

        ' Create a linear gradient brush for the background
        Dim gradientBrush As New LinearGradientBrush(Me.ClientRectangle, Color.FromArgb(0, 112, 205), Color.FromArgb(0, 160, 221), 90)
        e.Graphics.FillRectangle(gradientBrush, Me.ClientRectangle)
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint
        Dim gradientBrush As New LinearGradientBrush(Panel3.ClientRectangle, Color.FromArgb(164, 214, 255), Color.FromArgb(0, 160, 221), 90)
        e.Graphics.FillRectangle(gradientBrush, Panel3.ClientRectangle)
    End Sub


    ' Insert Course Button
    Private Sub insertBtn_Click(sender As Object, e As EventArgs) Handles insertBtn.Click
        Dim courseName As String = courseNameTxt.Text
        Dim courseNumber As String = courseNumberTxt.Text
        Dim creditHours As Integer = Integer.Parse(creditHoursTxt.Text)
        Dim department As String = departmentTxt.Text

        Using conn As New MySqlConnection(connectionString)
            Dim query As String = "INSERT INTO COURSE (Course_name, Course_number, Credit_hours, Department) VALUES (@Course_name, @Course_number, @Credit_hours, @Department)"
            Dim cmd As New MySqlCommand(query, conn)

            cmd.Parameters.AddWithValue("@Course_name", courseName)
            cmd.Parameters.AddWithValue("@Course_number", courseNumber)
            cmd.Parameters.AddWithValue("@Credit_hours", creditHours)
            cmd.Parameters.AddWithValue("@Department", department)

            Try
                conn.Open()
                cmd.ExecuteNonQuery()
                MessageBox.Show("Course inserted successfully.")
            Catch ex As MySqlException
                MessageBox.Show("Error inserting course: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Update Course Button
    Private Sub updateBtn_Click(sender As Object, e As EventArgs) Handles updateBtn.Click
        Dim courseName As String = courseNameTxt.Text
        Dim courseNumber As String = courseNumberTxt.Text
        Dim creditHours As Integer = Integer.Parse(creditHoursTxt.Text)
        Dim department As String = departmentTxt.Text

        Using conn As New MySqlConnection(connectionString)
            Dim query As String = "UPDATE COURSE SET Course_name = @Course_name, Credit_hours = @Credit_hours, Department = @Department WHERE Course_number = @Course_number"
            Dim cmd As New MySqlCommand(query, conn)

            cmd.Parameters.AddWithValue("@Course_name", courseName)
            cmd.Parameters.AddWithValue("@Course_number", courseNumber)
            cmd.Parameters.AddWithValue("@Credit_hours", creditHours)
            cmd.Parameters.AddWithValue("@Department", department)

            Try
                conn.Open()
                cmd.ExecuteNonQuery()
                MessageBox.Show("Course updated successfully.")
            Catch ex As MySqlException
                MessageBox.Show("Error updating course: " & ex.Message)
            End Try
        End Using
    End Sub

    ' Delete Course Button
    Private Sub deleteBtn_Click(sender As Object, e As EventArgs) Handles deleteBtn.Click
        Dim courseNumber As String = courseNumberTxt.Text

        Using conn As New MySqlConnection(connectionString)
            Dim query As String = "DELETE FROM COURSE WHERE Course_number = @Course_number"
            Dim cmd As New MySqlCommand(query, conn)

            cmd.Parameters.AddWithValue("@Course_number", courseNumber)

            Try
                conn.Open()
                cmd.ExecuteNonQuery()
                MessageBox.Show("Course deleted successfully.")
            Catch ex As MySqlException
                MessageBox.Show("Error deleting course: " & ex.Message)
            End Try
        End Using
    End Sub
End Class
