Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class registerUserType
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub registerUserType_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub adminBtn_Click(sender As Object, e As EventArgs) Handles adminBtn.Click
        Dim admin As New AdminRegister
        admin.Show()
        Me.Hide()

    End Sub

    Private Sub studentBtn_Click(sender As Object, e As EventArgs) Handles studentBtn.Click
        Dim student As New StudentRegister
        student.Show()
        Me.Hide()
    End Sub

    Private Sub instructorBtn_Click(sender As Object, e As EventArgs) Handles instructorBtn.Click
        Dim instructor As New InstructorRegister
        instructor.Show()
        Me.Hide()
    End Sub
End Class