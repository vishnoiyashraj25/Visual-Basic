Imports Newtonsoft.Json
Imports System.Net.Http
Imports System.Text

Public Class CreateSubmissionForm
    Private stopwatch As New Stopwatch()

    Private Sub CreateSubmissionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTime.Text = "00:00:00"
        stopwatch.Start()
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim elapsedTime As TimeSpan = stopwatch.Elapsed
        lblTime.Text = String.Format("{0:00}:{1:00}:{2:00}", elapsedTime.Hours, elapsedTime.Minutes, elapsedTime.Seconds)
    End Sub

    Private Async Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim newSubmission As New Submission With {
            .SubmissionName = txtName.Text,
            .Email = txtEmail.Text,
            .Phone = txtPhone.Text,
            .GitHubLink = txtGitHub.Text,
            .StopwatchTime = stopwatch.Elapsed.ToString()
        }

        Dim jsonSettings As New JsonSerializerSettings()
        jsonSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore

        Dim json As String = JsonConvert.SerializeObject(newSubmission, jsonSettings)
        Dim content As New StringContent(json, Encoding.UTF8, "application/json")

        Using client As New HttpClient()
            Dim response As HttpResponseMessage = Await client.PostAsync("http://localhost:3000/submit", content)
            If response.IsSuccessStatusCode Then
                MessageBox.Show("Submission successful")
            Else
                MessageBox.Show("Submission failed")
            End If
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Disable stopping of the stopwatch
    End Sub


End Class