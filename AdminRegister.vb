Imports MySql.Data.MySqlClient

Public Class AdminRegister
    ' Connection string for your MySQL database
    Dim connString As String = "Server=localhost;Database=school_system;User Id=root;Password=;"

    ' Event handler for the register button click
    Private Sub registerBtn_Click(sender As Object, e As EventArgs) Handles registerBtn.Click
        ' Get values from the text boxes
        Dim username As String = usernameTxt.Text
        Dim password As String = passTxt.Text

        ' Validate that both fields are filled
        If String.IsNullOrEmpty(username) OrElse String.IsNullOrEmpty(password) Then
            message.Text = "Username and password are required."
            message.ForeColor = Color.Red
            Return
        End If

        ' Insert data into the masterkey (admin) table
        Dim query As String = "INSERT INTO masterkey (admin, username) VALUES (@admin, @username)"

        Using conn As New MySqlConnection(connString)
            Using cmd As New MySqlCommand(query, conn)
                ' Add parameters to the SQL command
                cmd.Parameters.AddWithValue("@admin", password) ' Store the password as the admin field
                cmd.Parameters.AddWithValue("@username", username)

                Try
                    ' Open connection and execute the query
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    ' Display success message
                    message.Text = "Admin registered successfully! Username: " & username
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
