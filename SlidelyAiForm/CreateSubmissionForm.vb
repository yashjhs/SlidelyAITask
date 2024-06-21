Imports RestSharp

Public Class CreateSubmissionForm
    Private stopwatchRunning As Boolean = False
    Private elapsedTime As TimeSpan = TimeSpan.Zero

    Private Sub btnToggleStopwatch_Click(sender As Object, e As EventArgs) Handles btnToggleStopwatch.Click
        If stopwatchRunning Then
            Timer1.Stop()
            stopwatchRunning = False
            btnToggleStopwatch.Text = "Start Stopwatch"
        Else
            Timer1.Start()
            stopwatchRunning = True
            btnToggleStopwatch.Text = "Pause Stopwatch"
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        elapsedTime = elapsedTime.Add(TimeSpan.FromSeconds(1))
        lblStopwatch.Text = elapsedTime.ToString()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim client As New RestClient("http://localhost:3000")
        Dim request As New RestRequest("submit", Method.Post)
        request.AddJsonBody(New With {
            Key .name = txtName.Text,
            Key .email = txtEmail.Text,
            Key .phone = txtPhoneNumber.Text,
            Key .github_link = txtGitHubRepo.Text,
            Key .stopwatch_time = elapsedTime.ToString()
        })

        Dim response As RestResponse = client.Execute(request)
        If response.IsSuccessful Then
            MessageBox.Show("Submission added successfully!")
            Me.Close()
        Else
            MessageBox.Show("Error: " & response.Content)
        End If
    End Sub

    Private Sub CreateSubmissionForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.S Then
            btnSubmit.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.T Then
            btnToggleStopwatch.PerformClick()
        End If
    End Sub

    Private Sub CreateSubmissionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub


End Class
