Imports RestSharp

Public Class ViewSubmissionsForm
    Private currentIndex As Integer = 0

    Private Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        LoadSubmission(0)
    End Sub

    Private Sub LoadSubmission(index As Integer)
        Dim client As New RestClient("http://localhost:3000")
        Dim request As New RestRequest("read", Method.Get)
        request.AddParameter("index", index.ToString())

        Dim response As RestResponse = client.Execute(request)
        If response.IsSuccessful Then
            Dim submission = Newtonsoft.Json.JsonConvert.DeserializeObject(Of Dictionary(Of String, String))(response.Content)

            lblSubmissionName.Text = $"{submission("name")}"
            lblSubmissionEmail.Text = $"{submission("email")}"
            lblSubmissionPhone.Text = $"{submission("phone")}"
            lblSubmissionGithub.Text = $"{submission("github_link")}"
            lblSubmissionTime.Text = $"{submission("stopwatch_time")}"
            currentIndex = index
        Else
            MessageBox.Show("Error: " & response.Content)
        End If
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentIndex > 0 Then
            LoadSubmission(currentIndex - 1)
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        LoadSubmission(currentIndex + 1)
    End Sub

    Private Sub ViewSubmissionsForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.N Then
            btnNext.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.P Then
            btnPrevious.PerformClick()
        End If
    End Sub

    Private Sub lblSubmissionDetails_Click(sender As Object, e As EventArgs)

    End Sub
End Class
