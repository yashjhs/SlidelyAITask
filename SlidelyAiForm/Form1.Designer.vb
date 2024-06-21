<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnViewSubmissions = New Button()
        btnCreateSubmission = New Button()
        Label1 = New Label()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' btnViewSubmissions
        ' 
        btnViewSubmissions.BackColor = Color.Yellow
        btnViewSubmissions.Cursor = Cursors.Hand
        btnViewSubmissions.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnViewSubmissions.Location = New Point(279, 196)
        btnViewSubmissions.Name = "btnViewSubmissions"
        btnViewSubmissions.Size = New Size(265, 44)
        btnViewSubmissions.TabIndex = 0
        btnViewSubmissions.Text = "View Submissions (Ctrl + V)"
        btnViewSubmissions.UseVisualStyleBackColor = False
        ' 
        ' btnCreateSubmission
        ' 
        btnCreateSubmission.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        btnCreateSubmission.Cursor = Cursors.Hand
        btnCreateSubmission.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCreateSubmission.Location = New Point(279, 259)
        btnCreateSubmission.Name = "btnCreateSubmission"
        btnCreateSubmission.Size = New Size(265, 38)
        btnCreateSubmission.TabIndex = 1
        btnCreateSubmission.Text = "Create New Submission  (Ctrl + N)"
        btnCreateSubmission.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Algerian", 18F, FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        Label1.Location = New Point(197, 135)
        Label1.Name = "Label1"
        Label1.Size = New Size(418, 26)
        Label1.TabIndex = 2
        Label1.Text = "Slidely Task 2 - Slidely Form App" & vbCrLf
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Algerian", 27.75F, FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        Label2.Location = New Point(259, 82)
        Label2.Name = "Label2"
        Label2.Size = New Size(305, 41)
        Label2.TabIndex = 3
        Label2.Text = "Yash Agarwal" & vbCrLf
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaptionText
        ClientSize = New Size(800, 450)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnCreateSubmission)
        Controls.Add(btnViewSubmissions)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnViewSubmissions As Button
    Friend WithEvents btnCreateSubmission As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label

End Class
