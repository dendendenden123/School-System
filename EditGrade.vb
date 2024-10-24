Imports MySql.Data.MySqlClient
Imports System.Runtime.InteropServices
Imports System.Drawing.Drawing2D

Public Class EditGrade
    ' Database connection string (update with your own credentials)
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
    Private Sub EditGrade_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Apply rounded corners to text boxes and buttons
        ApplyRoundedCorners(studentNumberTxt, 30, 25)
        ApplyRoundedCorners(sectionIdentifierTxt, 30, 25)
        ApplyRoundedCorners(gradeTxt, 30, 25)
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


    Private Sub insertBtn_Click(sender As Object, e As EventArgs) Handles insertBtn.Click
        ' Insert a new grade report
        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                Dim query As String = "INSERT INTO GRADE_REPORT (Student_number, Section_identifier, Grade) VALUES (@studentNumber, @sectionIdentifier, @grade)"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@studentNumber", Convert.ToInt32(studentNumberTxt.Text))
                    cmd.Parameters.AddWithValue("@sectionIdentifier", Convert.ToInt32(sectionIdentifierTxt.Text))
                    cmd.Parameters.AddWithValue("@grade", gradeTxt.Text)

                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("Grade inserted successfully.")
                    Else
                        MessageBox.Show("Error inserting grade.")
                    End If
                End Using
            Catch ex As MySqlException
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub updateBtn_Click(sender As Object, e As EventArgs) Handles updateBtn.Click
        ' Update an existing grade report
        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                Dim query As String = "UPDATE GRADE_REPORT SET Grade = @grade WHERE Student_number = @studentNumber AND Section_identifier = @sectionIdentifier"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@studentNumber", Convert.ToInt32(studentNumberTxt.Text))
                    cmd.Parameters.AddWithValue("@sectionIdentifier", Convert.ToInt32(sectionIdentifierTxt.Text))
                    cmd.Parameters.AddWithValue("@grade", gradeTxt.Text)

                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("Grade updated successfully.")
                    Else
                        MessageBox.Show("Error updating grade or record not found.")
                    End If
                End Using
            Catch ex As MySqlException
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub deleteBtn_Click(sender As Object, e As EventArgs) Handles deleteBtn.Click
        ' Delete a grade report
        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                Dim query As String = "DELETE FROM GRADE_REPORT WHERE Student_number = @studentNumber AND Section_identifier = @sectionIdentifier"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@studentNumber", Convert.ToInt32(studentNumberTxt.Text))
                    cmd.Parameters.AddWithValue("@sectionIdentifier", Convert.ToInt32(sectionIdentifierTxt.Text))

                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("Grade deleted successfully.")
                    Else
                        MessageBox.Show("Error deleting grade or record not found.")
                    End If
                End Using
            Catch ex As MySqlException
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub
End Class
