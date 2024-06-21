<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewSubmissionsForm
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
        btnPrevious = New Button()
        btnNext = New Button()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        lblSubmissionEmail = New TextBox()
        lblSubmissionPhone = New TextBox()
        lblSubmissionGithub = New TextBox()
        lblSubmissionName = New TextBox()
        Label6 = New Label()
        lblSubmissionTime = New TextBox()
        SuspendLayout()
        ' 
        ' btnPrevious
        ' 
        btnPrevious.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        btnPrevious.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnPrevious.Location = New Point(230, 355)
        btnPrevious.Name = "btnPrevious"
        btnPrevious.Size = New Size(159, 33)
        btnPrevious.TabIndex = 0
        btnPrevious.Text = "Previous (Ctrl + P)"
        btnPrevious.UseVisualStyleBackColor = False
        ' 
        ' btnNext
        ' 
        btnNext.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        btnNext.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnNext.Location = New Point(395, 355)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(176, 33)
        btnNext.TabIndex = 1
        btnNext.Text = "Next (Ctrl + N)"
        btnNext.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Algerian", 21F, FontStyle.Underline)
        Label5.ForeColor = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        Label5.Location = New Point(230, 41)
        Label5.Name = "Label5"
        Label5.Size = New Size(344, 31)
        Label5.TabIndex = 12
        Label5.Text = "Create New Submission"
        Label5.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold Or FontStyle.Italic)
        Label4.ForeColor = SystemColors.ControlLight
        Label4.Location = New Point(230, 257)
        Label4.Name = "Label4"
        Label4.Size = New Size(93, 20)
        Label4.TabIndex = 20
        Label4.Text = "GitHub Link:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold Or FontStyle.Italic)
        Label3.ForeColor = SystemColors.ControlLight
        Label3.Location = New Point(230, 212)
        Label3.Name = "Label3"
        Label3.Size = New Size(117, 20)
        Label3.TabIndex = 19
        Label3.Text = "Phone Number:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold Or FontStyle.Italic)
        Label2.ForeColor = SystemColors.ControlLight
        Label2.Location = New Point(230, 159)
        Label2.Name = "Label2"
        Label2.Size = New Size(51, 20)
        Label2.TabIndex = 18
        Label2.Text = "Email:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ControlLight
        Label1.Location = New Point(230, 113)
        Label1.Name = "Label1"
        Label1.Size = New Size(55, 20)
        Label1.TabIndex = 14
        Label1.Text = "Name:"
        ' 
        ' lblSubmissionEmail
        ' 
        lblSubmissionEmail.Location = New Point(360, 151)
        lblSubmissionEmail.Name = "lblSubmissionEmail"
        lblSubmissionEmail.Size = New Size(211, 23)
        lblSubmissionEmail.TabIndex = 17
        ' 
        ' lblSubmissionPhone
        ' 
        lblSubmissionPhone.Location = New Point(360, 204)
        lblSubmissionPhone.Name = "lblSubmissionPhone"
        lblSubmissionPhone.Size = New Size(211, 23)
        lblSubmissionPhone.TabIndex = 16
        ' 
        ' lblSubmissionGithub
        ' 
        lblSubmissionGithub.Location = New Point(360, 249)
        lblSubmissionGithub.Name = "lblSubmissionGithub"
        lblSubmissionGithub.Size = New Size(211, 23)
        lblSubmissionGithub.TabIndex = 15
        ' 
        ' lblSubmissionName
        ' 
        lblSubmissionName.Location = New Point(360, 105)
        lblSubmissionName.Name = "lblSubmissionName"
        lblSubmissionName.Size = New Size(211, 23)
        lblSubmissionName.TabIndex = 13
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 11.25F, FontStyle.Bold Or FontStyle.Italic)
        Label6.ForeColor = SystemColors.ControlLight
        Label6.Location = New Point(230, 299)
        Label6.Name = "Label6"
        Label6.Size = New Size(121, 20)
        Label6.TabIndex = 22
        Label6.Text = "Stopwatch Time:"
        ' 
        ' lblSubmissionTime
        ' 
        lblSubmissionTime.Location = New Point(360, 299)
        lblSubmissionTime.Name = "lblSubmissionTime"
        lblSubmissionTime.Size = New Size(211, 23)
        lblSubmissionTime.TabIndex = 21
        ' 
        ' ViewSubmissionsForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaptionText
        ClientSize = New Size(800, 450)
        Controls.Add(Label6)
        Controls.Add(lblSubmissionTime)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(lblSubmissionEmail)
        Controls.Add(lblSubmissionPhone)
        Controls.Add(lblSubmissionGithub)
        Controls.Add(lblSubmissionName)
        Controls.Add(Label5)
        Controls.Add(btnNext)
        Controls.Add(btnPrevious)
        Name = "ViewSubmissionsForm"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblSubmissionEmail As TextBox
    Friend WithEvents lblSubmissionPhone As TextBox
    Friend WithEvents lblSubmissionGithub As TextBox
    Friend WithEvents lblSubmissionName As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents lblSubmissionTime As TextBox
End Class
