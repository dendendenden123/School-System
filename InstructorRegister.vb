Imports System.Net
Imports System.Net.Mail
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports MySql.Data.MySqlClient

Public Class InstructorRegister
    ' Connection string for your MySQL database
    Dim connString As String = "Server=localhost;Database=school_system;User Id=root;Password=;"




    Function sendMail(receiver As String, username As String, password As String, lastname As String)

        Try
            ' Create a new MailMessage object
            Dim mail As New MailMessage()

            ' Set the sender's email address
            mail.From = New MailAddress("schoolsesteem@gmail.com")

            ' Set the recipient's email address
            mail.To.Add(receiver)

            ' Set the subject and body of the email
            mail.Subject = "Your Login Credentials for School System"
            mail.Body = "Dear Mr/Ms. " & lastname & Environment.NewLine & "We are pleased to inform you that your account as Instructor in School System has been successfully created. Below are your login credentials to access the system: " & Environment.NewLine & Environment.NewLine & " username : " & username & Environment.NewLine &
"Password: " & password


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
    End Function



    Function GeneratePassword(ByVal length As Integer) As String
        ' Character sets
        Dim lowercase As String = "abcdefghijklmnopqrstuvwxyz"
        Dim uppercase As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        Dim numbers As String = "0123456789"
        Dim specialCharacters As String = "!@#$%^&*()-_=+[]{}|;:,.<>?/"

        ' Combine all character sets into one string
        Dim allCharacters As String = lowercase & uppercase & numbers & specialCharacters

        ' Create a new instance of the Random class
        Dim rand As New Random()

        ' Variable to store the generated password
        Dim password As String = ""

        ' Ensure password contains at least one character from each character set
        password &= lowercase(rand.Next(0, lowercase.Length))
        password &= uppercase(rand.Next(0, uppercase.Length))
        password &= numbers(rand.Next(0, numbers.Length))
        password &= specialCharacters(rand.Next(0, specialCharacters.Length))

        ' Generate the rest of the password
        For i As Integer = 4 To length - 1
            password &= allCharacters(rand.Next(0, allCharacters.Length))
        Next

        ' Return the shuffled password to avoid predictable sequences
        Return ShufflePassword(password)
    End Function

    ' Function to shuffle the characters in the password
    Function ShufflePassword(ByVal password As String) As String
        Dim rand As New Random()
        Dim chars As Char() = password.ToCharArray()

        ' Shuffle using Fisher-Yates algorithm
        For i As Integer = chars.Length - 1 To 1 Step -1
            Dim j As Integer = rand.Next(0, i + 1)
            ' Swap characters
            Dim temp As Char = chars(i)
            chars(i) = chars(j)
            chars(j) = temp
        Next

        ' Return the shuffled password as a string
        Return New String(chars)
    End Function


    Private Sub registerBtn_Click(sender As Object, e As EventArgs) Handles registerBtn.Click
        ' Get values from the text boxes
        Dim instructorId As String = firstNameTxt.Text ' Use first name as the instructor ID
        Dim password As String = GeneratePassword(12)
        Dim firstName As String = firstNameTxt.Text
        Dim middleName As String = middleNameTxt.Text
        Dim lastName As String = lastNameTxt.Text
        Dim birthday As Date = birthdatyDateTimePIcker.Value
        Dim address As String = addressTxt.Text
        Dim email1 As String = email.Text

        ' Validate that all required fields are filled
        If String.IsNullOrEmpty(instructorId) OrElse String.IsNullOrEmpty(password) OrElse
            String.IsNullOrEmpty(firstName) OrElse String.IsNullOrEmpty(middleName) OrElse
            String.IsNullOrEmpty(lastName) OrElse String.IsNullOrEmpty(address) Then
            message.Text = "All fields are required."
            message.ForeColor = Color.Red
            Return
        End If

        ' Insert data into the instructor table
        Dim query As String = "INSERT INTO instructor (instructor_id, password, firstName, middleName, lastName, birthday, address, email) " &
                              "VALUES (@instructor_id, @password, @firstName, @middleName, @lastName, @birthday, @address, @email)"

        Using conn As New MySqlConnection(connString)
            Using cmd As New MySqlCommand(query, conn)
                ' Add parameters to the SQL command
                cmd.Parameters.AddWithValue("@instructor_id", instructorId)
                cmd.Parameters.AddWithValue("@password", password) ' Consider hashing passwords for security
                cmd.Parameters.AddWithValue("@firstName", firstName)
                cmd.Parameters.AddWithValue("@middleName", middleName)
                cmd.Parameters.AddWithValue("@lastName", lastName)
                cmd.Parameters.AddWithValue("@birthday", birthday)
                cmd.Parameters.AddWithValue("@address", address)
                cmd.Parameters.AddWithValue("@email", email1)

                Try
                    ' Open connection and execute the query
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    ' Display success message
                    sendMail(email1, instructorId, password, lastName)
                    message.Text = "Instructor registered successfully! " & Environment.NewLine & " Log in credentials was sent to Instructor's email Account"
                    message.ForeColor = Color.Green
                Catch ex As Exception
                    ' Handle any errors during the insertion
                    message.Text = "An error occurred: " & ex.Message
                    message.ForeColor = Color.Red
                End Try
            End Using
        End Using
    End Sub

    ' Event handler for message label click (optional)
    Private Sub message_Click(sender As Object, e As EventArgs) Handles message.Click
        ' You can define any action when the message label is clicked, if needed
    End Sub
End Class
