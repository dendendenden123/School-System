Imports MySql.Data.MySqlClient
Imports System.Drawing.Drawing2D
Imports System.Runtime.InteropServices

Public Class Form4

    ' Properties to store user type and user ID
    Public Property usertype As String
    Public Property userid As String

    ' Connection string for MySQL database
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

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Apply rounded corners to Panel1, Panel2, Panel3 ,Panel4 and DataGridView1
        ApplyRoundedCorners(Panel1, 20, 20)
        ApplyRoundedCorners(Panel2, 20, 20)
        ApplyRoundedCorners(Panel3, 25, 25)
        ApplyRoundedCorners(Panel4, 25, 25)
        ApplyRoundedCorners(Panel5, 25, 25)
        ApplyRoundedCorners(DataGridView1, 30, 30)
        ApplyRoundedCorners(PictureBox1, 180, 180)



        ' Center Panel2 in the form
        CenterPanel(Panel2)

        ' Load student grades and data
        GetStudentGradesData(Integer.Parse(userid))
        GetStudentData(Integer.Parse(userid))
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)

        ' Create a linear gradient brush for the form's background
        Dim gradientBrush As New LinearGradientBrush(Me.ClientRectangle, Color.FromArgb(0, 112, 205), Color.FromArgb(0, 160, 221), 90)
        e.Graphics.FillRectangle(gradientBrush, Me.ClientRectangle)
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint
        ' Create a gradient brush for Panel2
        Dim gradientBrush As New LinearGradientBrush(Panel2.ClientRectangle, Color.FromArgb(164, 214, 255), Color.FromArgb(0, 160, 221), 90)
        e.Graphics.FillRectangle(gradientBrush, Panel2.ClientRectangle)
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

    Private Sub GetStudentGradesData(studentNumber As Integer)
        Dim sql As String = "SELECT  gr.Section_identifier, gr.Grade, " &
                            "s.Course_number, s.Semester, s.Year, s.Instructor " &
                            "FROM grade_report gr " &
                            "JOIN section s ON gr.Section_identifier = s.Section_identifier " &
                            "WHERE gr.Student_number = @StudentNumber"

        Dim table As New DataTable()

        Using conn As New MySqlConnection(connectionString)
            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@StudentNumber", studentNumber)

                Try
                    conn.Open()
                    Dim adapter As New MySqlDataAdapter(cmd)
                    adapter.Fill(table)

                    DataGridView1.DataSource = table
                Catch ex As MySqlException
                    MessageBox.Show("MySQL error: " & ex.Message)
                Catch ex As Exception
                    MessageBox.Show("An error occurred: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub GetStudentData(userid As Integer)
        Dim sql As String = "SELECT student_number, password, name, address, middleName, lastName FROM Student WHERE student_number = @StudentNumber"

        Using conn As New MySqlConnection(connectionString)
            Using cmd As New MySqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@StudentNumber", userid)

                Try
                    conn.Open()

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            Label7.Text = reader.GetInt32("student_number").ToString()
                            Label8.Text = reader.GetString("name")
                            Label9.Text = reader.GetString("middleName")
                            Label10.Text = reader.GetString("lastName")
                            Label11.Text = reader.GetString("address")
                        End If
                    End Using
                Catch ex As MySqlException
                    MessageBox.Show("MySQL error: " & ex.Message)
                Catch ex As Exception
                    MessageBox.Show("An error occurred: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim form3 As New Form3
        form3.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim form1 As New Form1
        form1.Show()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        ' Handle DataGridView cell click events if needed
    End Sub
End Class
