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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtName = New TextBox()
        txtPhone = New TextBox()
        txtEmail = New TextBox()
        txtGitHub = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        lbl = New Label()
        Timer1 = New Timer(components)
        lblTime = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = SystemColors.ControlText
        Label1.Location = New Point(232, 120)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(81, 32)
        Label1.TabIndex = 0
        Label1.Text = "Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = SystemColors.ControlText
        Label2.Location = New Point(232, 180)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(76, 32)
        Label2.TabIndex = 1
        Label2.Text = "Email"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = SystemColors.ControlText
        Label3.Location = New Point(232, 239)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(127, 32)
        Label3.TabIndex = 2
        Label3.Text = "Phone No"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = SystemColors.ControlText
        Label4.Location = New Point(232, 296)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(260, 32)
        Label4.TabIndex = 3
        Label4.Text = "GitHub Link for Task2"
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(439, 120)
        txtName.Margin = New Padding(4, 4, 4, 4)
        txtName.Name = "txtName"
        txtName.Size = New Size(390, 39)
        txtName.TabIndex = 4
        ' 
        ' txtPhone
        ' 
        txtPhone.Location = New Point(439, 236)
        txtPhone.Margin = New Padding(4, 4, 4, 4)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(390, 39)
        txtPhone.TabIndex = 5
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(439, 177)
        txtEmail.Margin = New Padding(4, 4, 4, 4)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(390, 39)
        txtEmail.TabIndex = 6
        ' 
        ' txtGitHub
        ' 
        txtGitHub.Location = New Point(506, 296)
        txtGitHub.Margin = New Padding(4, 4, 4, 4)
        txtGitHub.Name = "txtGitHub"
        txtGitHub.Size = New Size(380, 39)
        txtGitHub.TabIndex = 7
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(255), CByte(224), CByte(192))
        Button1.ForeColor = SystemColors.ControlText
        Button1.Location = New Point(250, 393)
        Button1.Margin = New Padding(4, 4, 4, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(371, 44)
        Button1.TabIndex = 8
        Button1.Text = "Toggle StopWatch (Ctrl + T)"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.DarkTurquoise
        Button2.ForeColor = SystemColors.ControlText
        Button2.Location = New Point(422, 475)
        Button2.Margin = New Padding(4, 4, 4, 4)
        Button2.Name = "Button2"
        Button2.Size = New Size(304, 44)
        Button2.TabIndex = 9
        Button2.Text = "Submit (Ctrl + S)"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' lbl
        ' 
        lbl.AutoSize = True
        lbl.ForeColor = SystemColors.ControlText
        lbl.Location = New Point(710, 396)
        lbl.Margin = New Padding(4, 0, 4, 0)
        lbl.Name = "lbl"
        lbl.Size = New Size(0, 32)
        lbl.TabIndex = 10
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 1000
        ' 
        ' lblTime
        ' 
        lblTime.AutoSize = True
        lblTime.Location = New Point(698, 393)
        lblTime.Margin = New Padding(4, 0, 4, 0)
        lblTime.Name = "lblTime"
        lblTime.Size = New Size(0, 32)
        lblTime.TabIndex = 11
        ' 
        ' CreateSubmissionForm
        ' 
        AutoScaleDimensions = New SizeF(14F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLightLight
        ClientSize = New Size(1120, 576)
        Controls.Add(lblTime)
        Controls.Add(lbl)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(txtGitHub)
        Controls.Add(txtEmail)
        Controls.Add(txtPhone)
        Controls.Add(txtName)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ForeColor = Color.CornflowerBlue
        Margin = New Padding(4, 4, 4, 4)
        Name = "CreateSubmissionForm"
        Text = "CreateSubmissionForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtGitHub As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents lbl As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblTime As Label
End Class
