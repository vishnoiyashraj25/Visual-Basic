Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenCreateSubmissionForm()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        OpenViewSubmissionsForm()
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown, Button1.KeyDown, Button2.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.N Then
            OpenCreateSubmissionForm()
        ElseIf e.Control AndAlso e.KeyCode = Keys.V Then
            OpenViewSubmissionsForm()
        End If
    End Sub

    Private Sub OpenCreateSubmissionForm()
        Dim createForm As New CreateSubmissionForm()
        createForm.Show()
    End Sub

    Private Sub OpenViewSubmissionsForm()
        Dim viewForm As New ViewSubmissionsForm()
        viewForm.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Ensure the form can capture key events
        Me.KeyPreview = True
    End Sub
End Class
