Imports MySql.Data.MySqlClient
Imports System.Runtime.InteropServices
Imports System.Drawing.Drawing2D

Public Class EditPrerequisite
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
    Private Sub EditPrerequisite_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Apply rounded corners to text boxes and buttons
        ApplyRoundedCorners(courseNumberTxt, 30, 25)
        ApplyRoundedCorners(prerequisiteNumberTxt, 30, 25)
        ApplyRoundedCorners(insertBtn, 60, 60)
        ApplyRoundedCorners(updateBtn, 60, 60)
        ApplyRoundedCorners(deleteBtn, 60, 60)
        ApplyRoundedCorners(Panel1, 20, 20)
        ApplyRoundedCorners(Panel2, 20, 20)
        ApplyRoundedCorners(Panel3, 20, 20)
        ApplyRoundedCorners(Label6, 20, 20)


        ' Center the Panel1 in the form (if any)
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
        ' Insert a new prerequisite record
        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                Dim query As String = "INSERT INTO PREREQUISITE (Course_number, Prerequisite_number) VALUES (@courseNumber, @prerequisiteNumber)"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@courseNumber", courseNumberTxt.Text)
                    cmd.Parameters.AddWithValue("@prerequisiteNumber", prerequisiteNumberTxt.Text)

                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("Prerequisite inserted successfully.")
                    Else
                        MessageBox.Show("Error inserting prerequisite.")
                    End If
                End Using
            Catch ex As MySqlException
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub updateBtn_Click(sender As Object, e As EventArgs) Handles updateBtn.Click
        ' Update an existing prerequisite record
        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                Dim query As String = "UPDATE PREREQUISITE SET Prerequisite_number = @prerequisiteNumber WHERE Course_number = @courseNumber AND Prerequisite_number = @oldPrerequisiteNumber"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@courseNumber", courseNumberTxt.Text)
                    cmd.Parameters.AddWithValue("@prerequisiteNumber", prerequisiteNumberTxt.Text)
                    cmd.Parameters.AddWithValue("@oldPrerequisiteNumber", prerequisiteNumberTxt.Tag) ' Assume Tag holds the original prerequisite number

                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("Prerequisite updated successfully.")
                    Else
                        MessageBox.Show("Error updating prerequisite or record not found.")
                    End If
                End Using
            Catch ex As MySqlException
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub deleteBtn_Click(sender As Object, e As EventArgs) Handles deleteBtn.Click
        ' Delete a prerequisite record
        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                Dim query As String = "DELETE FROM PREREQUISITE WHERE Course_number = @courseNumber AND Prerequisite_number = @prerequisiteNumber"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@courseNumber", courseNumberTxt.Text)
                    cmd.Parameters.AddWithValue("@prerequisiteNumber", prerequisiteNumberTxt.Text)

                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("Prerequisite deleted successfully.")
                    Else
                        MessageBox.Show("Error deleting prerequisite or record not found.")
                    End If
                End Using
            Catch ex As MySqlException
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub
End Class
