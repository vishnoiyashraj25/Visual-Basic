Imports System.Net.Http
Imports Newtonsoft.Json

Public Class ViewSubmissionsForm
    Private currentIndex As Integer = 0
    Private submissions As List(Of Submission)

    Private Async Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        submissions = Await GetSubmissionsAsync()
        If submissions.Count > 0 Then
            DisplaySubmission(currentIndex)
        Else
            MessageBox.Show("No submissions available.")
        End If
    End Sub

    Private Sub DisplaySubmission(index As Integer)
        lblName.Text = submissions(index).SubmissionName
        lblEmail.Text = submissions(index).Email
        lblPhone.Text = submissions(index).Phone
        lblGitHub.Text = submissions(index).GitHubLink
        lblStopwatch.Text = submissions(index).StopwatchTime
    End Sub

    Private Async Function GetSubmissionsAsync() As Task(Of List(Of Submission))
        Using client As New HttpClient()
            Dim response As HttpResponseMessage = Await client.GetAsync("http://localhost:3000/read")
            If response.IsSuccessStatusCode Then
                Dim jsonResponse As String = Await response.Content.ReadAsStringAsync()
                Return JsonConvert.DeserializeObject(Of List(Of Submission))(jsonResponse)
            Else
                MessageBox.Show("Failed to retrieve submissions")
                Return New List(Of Submission)
            End If
        End Using
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            DisplaySubmission(currentIndex)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If currentIndex < submissions.Count - 1 Then
            currentIndex += 1
            DisplaySubmission(currentIndex)
        End If
    End Sub
End Class
