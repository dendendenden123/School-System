Imports System.Net
Imports System.Net.Mail
Imports MySql.Data.MySqlClient

Public Class StudentRegister
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
            mail.Body = "Dear Mr/Ms. " & lastname & Environment.NewLine & "We are pleased to inform you that your account as Student in School System has been successfully created. Below are your login credentials to access the system: " & Environment.NewLine & Environment.NewLine & " username : " & username & Environment.NewLine &
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
            Label4.Text = "Error: " & ex.Message
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

    ' Event handler for the register button click
    Private Sub registerBtn_Click(sender As Object, e As EventArgs) Handles registerBtn.Click
        ' Get values from the text boxes
        Dim email As String = emailTxt.Text
        Dim password As String = GeneratePassword(12)
        Dim firstName As String = firstNameTxt.Text
        Dim middleName As String = middleNameTxt.Text
        Dim lastName As String = lastNameTxt.Text
        Dim address As String = addressTxt.Text
        Dim studentNumber As String = GenerateStudentNumber()

        ' Validate that all required fields are filled
        If String.IsNullOrEmpty(email) OrElse String.IsNullOrEmpty(password) OrElse
            String.IsNullOrEmpty(firstName) OrElse String.IsNullOrEmpty(middleName) OrElse
            String.IsNullOrEmpty(lastName) OrElse String.IsNullOrEmpty(address) Then
            message.Text = "All fields are required."
            message.ForeColor = Color.Red
            Return
        End If

        ' Insert data into the student table
        Dim query As String = "INSERT INTO student (student_number, password, email, name, middleName, lastName, address) " &
                              "VALUES (@student_number, @password, @email, @name, @middleName, @lastName, @address)"

        Using conn As New MySqlConnection(connString)
            Using cmd As New MySqlCommand(query, conn)
                ' Add parameters to the SQL command
                cmd.Parameters.AddWithValue("@student_number", studentNumber)
                cmd.Parameters.AddWithValue("@password", password) ' Consider hashing passwords for security
                cmd.Parameters.AddWithValue("@email", email)
                cmd.Parameters.AddWithValue("@name", firstName)
                cmd.Parameters.AddWithValue("@middleName", middleName)
                cmd.Parameters.AddWithValue("@lastName", lastName)
                cmd.Parameters.AddWithValue("@address", address)

                Try
                    ' Open connection and execute the query
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    ' Display success message
                    sendMail(email, studentNumber, password, lastName)
                    message.Text = "Student registered successfully! " & Environment.NewLine & " Log in credentials was sent to Student's email Account"
                    message.ForeColor = Color.Green
                Catch ex As Exception
                    ' Handle any errors during the insertion
                    message.Text = "An error occurred: " & ex.Message
                    message.ForeColor = Color.Red
                End Try
            End Using
        End Using
    End Sub

    ' Function to generate a random 4-digit student number
    Private Function GenerateStudentNumber() As String
        Dim randomDigits As Integer = New Random().Next(1000, 9999) ' Generate a random 4-digit integer
        Return randomDigits.ToString() ' Convert to string and return the 4-digit number
    End Function

    Private Sub message_Click(sender As Object, e As EventArgs) Handles message.Click

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class
