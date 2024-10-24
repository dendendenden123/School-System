Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Imports System.Drawing.Drawing2D ' Required for gradient background

Public Class Form5
    Public Property usertype As String
    Public Property userid As String
    Private connectionString As String = "Server=localhost;Database=school_system;User Id=root;Password=;"

    Private Sub GetStudentData(userid As String) ' Assuming userid is the student number you want to query
        Dim sql As String = "SELECT instructor_id, password, firstName, middleName, lastName, birthday, address FROM instructor WHERE instructor_id = @instructor_id"

        ' Variables to hold the retrieved values
        Dim instructor_id As String
        Dim password As String = String.Empty
        Dim firstName As String = String.Empty
        Dim middleName As String = String.Empty
        Dim lastName As String = String.Empty
        Dim address As String = String.Empty
        Dim birthday As DateTime

        ' Create the MySqlConnection object
        Using conn As New MySqlConnection(connectionString)
            Using cmd As New MySqlCommand(sql, conn)
                ' Parameterized query to avoid SQL injection
                cmd.Parameters.AddWithValue("@instructor_id", userid)

                Try
                    ' Open the connection
                    conn.Open()

                    ' Execute the command and use a reader to access the results
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then ' Check if there are any results
                            ' Retrieve values from the reader and store them in variables
                            instructor_id = reader.GetString("instructor_id")
                            password = reader.GetString("password")
                            firstName = reader.GetString("firstName")
                            middleName = If(Not reader.IsDBNull(reader.GetOrdinal("middleName")), reader.GetString("middleName"), String.Empty)
                            lastName = reader.GetString("lastName")
                            address = reader.GetString("address")
                            birthday = reader.GetDateTime("birthday").ToString("yyyy-MM-dd")
                        End If
                    End Using ' This will close the reader
                Catch ex As MySqlException
                    MessageBox.Show("MySQL error: " & ex.Message)
                Catch ex As Exception
                    MessageBox.Show("An error occurred: " & ex.Message)
                Finally
                    ' Ensure the connection is closed if it was opened
                    If conn.State = ConnectionState.Open Then
                        conn.Close()
                    End If
                End Try
            End Using ' This will dispose of the command
        End Using

        ' Update UI Labels with the retrieved data
        Label7.Text = instructor_id
        Label8.Text = firstName
        Label9.Text = middleName
        Label10.Text = lastName
        Label11.Text = address
        Label12.Text = birthday
    End Sub

    Private Sub GetStudentGradesData(Instructor As String)
        ' Define the SQL query to join grade_report and section tables
        Dim sql As String = "SELECT  gr.Student_number, gr.Section_identifier, gr.Grade, " &
                            "s.Course_number, s.Semester, s.Year, s.Instructor " &
                            "FROM grade_report gr " &
                            "JOIN section s ON gr.Section_identifier = s.Section_identifier " &
                            "WHERE s.Instructor = @Instructor"

        ' Create a DataTable to hold the results
        Dim table As New DataTable()

        ' Create the MySqlConnection object
        Using conn As New MySqlConnection(connectionString)
            Using cmd As New MySqlCommand(sql, conn)
                ' Parameterized query to avoid SQL injection
                cmd.Parameters.AddWithValue("@Instructor", Instructor)

                Try
                    ' Open the connection
                    conn.Open()

                    ' Use MySqlDataAdapter to fill the DataTable
                    Dim adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(table)

                    ' Bind the DataTable to a DataGridView (assuming you have one on your form)
                    DataGridView1.DataSource = table
                Catch ex As MySqlException
                    MessageBox.Show("MySQL error: " & ex.Message)
                Catch ex As Exception
                    MessageBox.Show("An error occurred: " & ex.Message)
                Finally
                    ' Ensure the connection is closed if it was opened
                    If conn.State = ConnectionState.Open Then
                        conn.Close()
                    End If
                End Try
            End Using ' This will dispose of the command
        End Using ' This will close and dispose of the connection
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetStudentGradesData(userid)
        GetStudentData(userid)

        ' Apply design changes
        ApplyRoundedCorners(Panel1, 20, 20)
        ApplyRoundedCorners(Panel2, 20, 20)
        ApplyRoundedCorners(Panel3, 20, 20)
        ApplyRoundedCorners(Panel4, 20, 20)
        ApplyRoundedCorners(Panel5, 20, 20)
        ApplyRoundedCorners(Panel6, 20, 20)
        ApplyRoundedCorners(DataGridView1, 30, 30)
        ApplyRoundedCorners(Button1, 10, 10)
        ApplyRoundedCorners(Button2, 10, 10)
        ApplyRoundedCorners(Button3, 10, 10)
        ApplyRoundedCorners(TextBox1, 25, 25)
        CenterPanel(Panel2)


    End Sub

    Private Sub ApplyRoundedCorners(control As Control, radiusX As Integer, radiusY As Integer)
        Dim path As New GraphicsPath()
        path.StartFigure()
        path.AddArc(New Rectangle(0, 0, radiusX, radiusY), 180, 90)
        path.AddArc(New Rectangle(control.Width - radiusX, 0, radiusX, radiusY), -90, 90)
        path.AddArc(New Rectangle(control.Width - radiusX, control.Height - radiusY, radiusX, radiusY), 0, 90)
        path.AddArc(New Rectangle(0, control.Height - radiusY, radiusX, radiusY), 90, 90)
        path.CloseFigure()
        control.Region = New Region(path)
    End Sub


    Private Sub AddPanelShadow(panel As Panel)
        panel.BackColor = Color.LightGray
        panel.Padding = New Padding(5)
        panel.Invalidate() ' Refresh the panel to show the shadow
    End Sub

    Private Sub CenterPanel(panel As Panel)
        panel.Left = (Me.ClientSize.Width - panel.Width) / 2
        panel.Top = (Me.ClientSize.Height - panel.Height) / 2
    End Sub

    ' Applying gradient background from Form4.vb
    Private Sub Form5_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim gradientBrush As New LinearGradientBrush(Me.ClientRectangle, Color.FromArgb(0, 112, 205), Color.FromArgb(0, 160, 221), 90)
        e.Graphics.FillRectangle(gradientBrush, Me.ClientRectangle)
    End Sub

    ' Applying gradient background from Panel1
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint
        Dim gradientBrush As New LinearGradientBrush(Panel2.ClientRectangle, Color.FromArgb(164, 214, 255), Color.FromArgb(0, 160, 221), 90)
        e.Graphics.FillRectangle(gradientBrush, Panel2.ClientRectangle)
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Define your SQL update command
        Dim sql As String = "UPDATE grade_report gr " &
                            "JOIN section s ON gr.Section_identifier = s.Section_identifier " &
                            "SET gr.Grade = @grade " &
                            "WHERE s.Instructor = @Instructor and gr.Student_number = @Student_number"

        ' Create the MySqlConnection object
        Using conn As New MySqlConnection(connectionString)
            Using cmd As New MySqlCommand(sql, conn)
                ' Adding parameters to avoid SQL injection
                cmd.Parameters.AddWithValue("@grade", TextBox1.Text)
                cmd.Parameters.AddWithValue("@Instructor", userid)
                cmd.Parameters.AddWithValue("@Student_number", Label15.Text)

                Try
                    ' Open the connection
                    conn.Open()

                    ' Execute the command
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    ' Notify how many rows were updated
                    MessageBox.Show($"{rowsAffected} rows updated successfully.")
                    GetStudentGradesData(userid)
                Catch ex As MySqlException
                    MessageBox.Show("MySQL error: " & ex.Message)
                Catch ex As Exception
                    MessageBox.Show("An error occurred: " & ex.Message)
                Finally
                    ' Ensure the connection is closed if it was opened
                    If conn.State = ConnectionState.Open Then
                        conn.Close()
                    End If
                End Try
            End Using ' This will dispose of the command
        End Using ' This will dispose of the connection
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        ' Ensure the row index is valid to avoid errors
        If e.RowIndex >= 0 Then
            ' Get the clicked row
            Dim selectedRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

            ' Retrieve the values from the cells in the clicked row
            Dim studentNumber As String = selectedRow.Cells("Student_number").Value.ToString()
            Dim name As String = selectedRow.Cells("Course_number").Value.ToString()
            Dim someValue As String = selectedRow.Cells("Grade").Value.ToString() ' Update this with your actual column name

            ' Set the values to TextBox and Labels
            TextBox1.Text = someValue
            Label15.Text = studentNumber
            Label14.Text = name
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim form3 As New Form3
        form3.Show()
        Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        GetStudentGradesData(userid)
    End Sub


    Private Sub LoadSubjects()
        ' Change the connection string as per your MySQL database settings
        Dim connectionString As String = "server=localhost;userid=root;password=your_password;database=your_database"
        Dim query As String = "Select Section_identifier from section where Instructor = userid"

        ' Establish connection to the database
        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()

                ' Create the command and execute the query
                Using cmd As New MySqlCommand(query, conn)
                    Dim reader As MySqlDataReader = cmd.ExecuteReader()

                    ' Loop through the results and add to ComboBox
                    While reader.Read()
                        ComboBox1.Items.Add(reader("SubjectName").ToString())
                    End While
                End Using

            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
    End Sub
End Class
