Imports System.Runtime.InteropServices
Imports System.Security.Cryptography.X509Certificates
Imports MySql.Data.MySqlClient
Imports System.Drawing.Drawing2D
Imports System.Net
Imports System.Net.Mail

Public Class Form3
    Dim connString As String = "Server=localhost;Database=school_system;User Id=root;Password=;"

    Public Property usertype As String
    Public Property userid As String

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

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Apply rounded corners to TextBox1 and TextBox2
        ApplyRoundedCorners(TextBox1, 30, 25) ' Adjust the width and height of the ellipse
        ApplyRoundedCorners(TextBox2, 30, 25)

        ' Apply rounded corners to Panel1, Panel2, PictureBox3, and Button1
        ApplyRoundedCorners(Panel1, 20, 20)
        ApplyRoundedCorners(Panel2, 20, 20) ' Added line for Panel2
        ApplyRoundedCorners(Panel3, 20, 20) ' Added line for Panel3
        ApplyRoundedCorners(Panel4, 20, 20) ' Added line for Panel4
        ApplyRoundedCorners(PictureBox3, 20, 20) ' Added line for PictureBox3

        ' Center the Panel1 in the form
        CenterPanel(Panel1)
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)

        ' Create a linear gradient brush for the background
        Dim gradientBrush As New LinearGradientBrush(Me.ClientRectangle, Color.FromArgb(0, 112, 205), Color.FromArgb(0, 160, 221), 90)
        e.Graphics.FillRectangle(gradientBrush, Me.ClientRectangle)
    End Sub

    Private Sub ApplyRoundedCorners(control As Control, width As Integer, height As Integer)
        ' Create a rounded rectangle region for the control
        Dim regionHandle As IntPtr = CreateRoundRectRgn(0, 0, control.Width, control.Height, width, height)
        control.Region = Region.FromHrgn(regionHandle)
    End Sub

    Private Sub CenterPanel(panel As Panel)
        ' Calculate the new position for the panel to center it in the form
        Dim x As Integer = (Me.ClientSize.Width - panel.Width) \ 2
        Dim y As Integer = (Me.ClientSize.Height - panel.Height) \ 2
        panel.Location = New Point(x, y)
    End Sub

    Public Function AuthenticateUser(username As String, password As String) As String
        Dim userType As String = String.Empty
        Dim queryStudent As String = "SELECT COUNT(*) FROM Student WHERE student_number = @username AND password = @password"
        Dim queryInstructor As String = "SELECT COUNT(*) FROM Instructor WHERE instructor_id = @username AND password = @password"
        Dim queryAdmin As String = "SELECT COUNT(*) FROM masterkey WHERE username = @username AND admin = @password"

        Using conn As New MySqlConnection(connString)
            conn.Open()

            ' Check Admin table first (since Admin should have the highest priority)
            Using cmdAdmin As New MySqlCommand(queryAdmin, conn)
                cmdAdmin.Parameters.AddWithValue("@username", username)
                cmdAdmin.Parameters.AddWithValue("@password", password)

                If Convert.ToInt32(cmdAdmin.ExecuteScalar()) > 0 Then
                    userType = "Admin"
                End If
            End Using

            ' Check Instructor table if not already determined to be Admin
            If String.IsNullOrEmpty(userType) Then
                Using cmdInstructor As New MySqlCommand(queryInstructor, conn)
                    cmdInstructor.Parameters.AddWithValue("@username", username)
                    cmdInstructor.Parameters.AddWithValue("@password", password)

                    If Convert.ToInt32(cmdInstructor.ExecuteScalar()) > 0 Then
                        userType = "Instructor"
                    End If
                End Using

                ' Check Student table if not already determined to be Admin or Instructor
            End If
            If String.IsNullOrEmpty(userType) Then
                Using cmdStudent As New MySqlCommand(queryStudent, conn)
                    cmdStudent.Parameters.AddWithValue("@username", username)
                    cmdStudent.Parameters.AddWithValue("@password", password)

                    If Convert.ToInt32(cmdStudent.ExecuteScalar()) > 0 Then
                        userType = "Student"
                    End If
                End Using
            End If
        End Using

        Return userType ' Returns empty string if no match is found
    End Function


    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username As String = TextBox1.Text
        Dim password As String = TextBox2.Text

        Dim userType As String = AuthenticateUser(username, password)

        If Not String.IsNullOrEmpty(userType) Then
            Select Case userType
                Case "Student"
                    Dim form4 As New Form4
                    form4.usertype = "Student"
                    form4.userid = TextBox1.Text
                    form4.Show()
                    Me.Hide()

                Case "Instructor"
                    Dim form5 As New Form5
                    form5.usertype = "Instructor"
                    form5.userid = TextBox1.Text
                    form5.Show()
                    Me.Hide()

                Case "Admin"
                    Dim form2 As New Form2
                    form2.Show()
                    Me.Hide()
            End Select
        Else
            Label5.Text = "Invalid username or password."
        End If
    End Sub

    Private Sub registerBtn_Click(sender As Object, e As EventArgs)
        Dim reg As New registerUserType
        reg.Show()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Panel2_Paint_1(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

        Try
            ' Create a new MailMessage object
            Dim mail As New MailMessage

            ' Set the sender's email address
            mail.From = New MailAddress("schoolsesteem@gmail.com")

            ' Set the recipient's email address
            mail.To.Add("den910068@gmail.com")

            ' Set the subject and body of the email
            mail.Subject = "Test Email"
            mail.Body = "This is a test email sent from VB.NET via Gmail SMTP."

            ' Set the Gmail SMTP server details
            Dim smtpServer As New SmtpClient("smtp.gmail.com")
            smtpServer.Port = 587
            smtpServer.Credentials = New NetworkCredential("schoolsesteem@gmail.com", "burc srto cwnb ngty")
            smtpServer.EnableSsl = True ' Enable SSL for secure connection

            ' Send the email
            smtpServer.Send(mail)

        Catch ex As Exception
            ' Handle any exceptions that occur
            Label5.Text = "Error: " & ex.Message
        End Try
    End Sub
End Class
