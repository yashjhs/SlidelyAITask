<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateSubmissionForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        txtName = New TextBox()
        txtGitHubRepo = New TextBox()
        txtPhoneNumber = New TextBox()
        txtEmail = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        btnToggleStopwatch = New Button()
        lblStopwatch = New Label()
        btnSubmit = New Button()
        Timer1 = New Timer(components)
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(368, 93)
        txtName.Name = "txtName"
        txtName.Size = New Size(211, 23)
        txtName.TabIndex = 0
        ' 
        ' txtGitHubRepo
        ' 
        txtGitHubRepo.Location = New Point(368, 237)
        txtGitHubRepo.Name = "txtGitHubRepo"
        txtGitHubRepo.Size = New Size(211, 23)
        txtGitHubRepo.TabIndex = 3
        ' 
        ' txtPhoneNumber
        ' 
        txtPhoneNumber.Location = New Point(368, 192)
        txtPhoneNumber.Name = "txtPhoneNumber"
        txtPhoneNumber.Size = New Size(211, 23)
        txtPhoneNumber.TabIndex = 2
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(368, 139)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(211, 23)
        txtEmail.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ControlLight
        Label1.Location = New Point(238, 101)
        Label1.Name = "Label1"
        Label1.Size = New Size(55, 20)
        Label1.TabIndex = 1
        Label1.Text = "Name:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold Or FontStyle.Italic)
        Label2.ForeColor = SystemColors.ControlLight
        Label2.Location = New Point(238, 147)
        Label2.Name = "Label2"
        Label2.Size = New Size(51, 20)
        Label2.TabIndex = 5
        Label2.Text = "Email:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold Or FontStyle.Italic)
        Label3.ForeColor = SystemColors.ControlLight
        Label3.Location = New Point(238, 200)
        Label3.Name = "Label3"
        Label3.Size = New Size(117, 20)
        Label3.TabIndex = 6
        Label3.Text = "Phone Number:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold Or FontStyle.Italic)
        Label4.ForeColor = SystemColors.ControlLight
        Label4.Location = New Point(238, 245)
        Label4.Name = "Label4"
        Label4.Size = New Size(93, 20)
        Label4.TabIndex = 7
        Label4.Text = "GitHub Link:"
        ' 
        ' btnToggleStopwatch
        ' 
        btnToggleStopwatch.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        btnToggleStopwatch.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnToggleStopwatch.Location = New Point(238, 300)
        btnToggleStopwatch.Name = "btnToggleStopwatch"
        btnToggleStopwatch.Size = New Size(217, 32)
        btnToggleStopwatch.TabIndex = 4
        btnToggleStopwatch.Text = "Start Stopwatch (Ctrl + T)"
        btnToggleStopwatch.UseVisualStyleBackColor = False
        ' 
        ' lblStopwatch
        ' 
        lblStopwatch.AutoSize = True
        lblStopwatch.BorderStyle = BorderStyle.FixedSingle
        lblStopwatch.Font = New Font("Segoe UI Semibold", 17.25F, FontStyle.Bold)
        lblStopwatch.ForeColor = SystemColors.ControlLight
        lblStopwatch.Location = New Point(473, 300)
        lblStopwatch.Name = "lblStopwatch"
        lblStopwatch.Size = New Size(106, 33)
        lblStopwatch.TabIndex = 9
        lblStopwatch.Text = "00:00:00"
        ' 
        ' btnSubmit
        ' 
        btnSubmit.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        btnSubmit.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSubmit.Location = New Point(238, 365)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(341, 34)
        btnSubmit.TabIndex = 5
        btnSubmit.Text = "Submit (Ctrl + S)"
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' Timer1
        ' 
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Algerian", 21F, FontStyle.Underline)
        Label5.ForeColor = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        Label5.Location = New Point(238, 29)
        Label5.Name = "Label5"
        Label5.Size = New Size(344, 31)
        Label5.TabIndex = 11
        Label5.Text = "Create New Submission"
        Label5.TextAlign = ContentAlignment.TopCenter
        ' 
        ' CreateSubmissionForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaptionText
        ClientSize = New Size(800, 450)
        Controls.Add(Label5)
        Controls.Add(btnSubmit)
        Controls.Add(lblStopwatch)
        Controls.Add(btnToggleStopwatch)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtEmail)
        Controls.Add(txtPhoneNumber)
        Controls.Add(txtGitHubRepo)
        Controls.Add(txtName)
        Name = "CreateSubmissionForm"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtName As TextBox
    Friend WithEvents txtGitHubRepo As TextBox
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnToggleStopwatch As Button
    Friend WithEvents lblStopwatch As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label5 As Label
End Class
