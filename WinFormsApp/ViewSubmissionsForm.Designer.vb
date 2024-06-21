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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        lblName = New TextBox()
        lblEmail = New TextBox()
        lblPhone = New TextBox()
        lblGitHub = New TextBox()
        lblStopwatch = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        Label6 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Historic", 12F, FontStyle.Bold)
        Label1.Location = New Point(245, 137)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(82, 32)
        Label1.TabIndex = 0
        Label1.Text = "Name" & vbCrLf
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(245, 194)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(76, 32)
        Label2.TabIndex = 1
        Label2.Text = "Email"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(245, 252)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(129, 32)
        Label3.TabIndex = 2
        Label3.Text = "Phone No"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(245, 310)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(245, 32)
        Label4.TabIndex = 3
        Label4.Text = "GitHub Link for task"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(245, 371)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(134, 32)
        Label5.TabIndex = 4
        Label5.Text = "Stopwatch"
        ' 
        ' lblName
        ' 
        lblName.Location = New Point(538, 137)
        lblName.Margin = New Padding(4, 4, 4, 4)
        lblName.Name = "lblName"
        lblName.ReadOnly = True
        lblName.Size = New Size(384, 39)
        lblName.TabIndex = 5
        ' 
        ' lblEmail
        ' 
        lblEmail.Location = New Point(538, 191)
        lblEmail.Margin = New Padding(4, 4, 4, 4)
        lblEmail.Name = "lblEmail"
        lblEmail.ReadOnly = True
        lblEmail.Size = New Size(384, 39)
        lblEmail.TabIndex = 6
        ' 
        ' lblPhone
        ' 
        lblPhone.Location = New Point(538, 245)
        lblPhone.Margin = New Padding(4, 4, 4, 4)
        lblPhone.Name = "lblPhone"
        lblPhone.ReadOnly = True
        lblPhone.Size = New Size(384, 39)
        lblPhone.TabIndex = 7
        ' 
        ' lblGitHub
        ' 
        lblGitHub.Location = New Point(538, 307)
        lblGitHub.Margin = New Padding(4, 4, 4, 4)
        lblGitHub.Name = "lblGitHub"
        lblGitHub.ReadOnly = True
        lblGitHub.Size = New Size(384, 39)
        lblGitHub.TabIndex = 8
        ' 
        ' lblStopwatch
        ' 
        lblStopwatch.Location = New Point(538, 364)
        lblStopwatch.Margin = New Padding(4, 4, 4, 4)
        lblStopwatch.Name = "lblStopwatch"
        lblStopwatch.ReadOnly = True
        lblStopwatch.Size = New Size(384, 39)
        lblStopwatch.TabIndex = 9
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Cornsilk
        Button1.Location = New Point(190, 491)
        Button1.Margin = New Padding(4, 4, 4, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(450, 69)
        Button1.TabIndex = 10
        Button1.Text = "Previous (Ctrl+P)"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.CornflowerBlue
        Button2.Location = New Point(730, 491)
        Button2.Margin = New Padding(4, 4, 4, 4)
        Button2.Name = "Button2"
        Button2.Size = New Size(450, 69)
        Button2.TabIndex = 11
        Button2.Text = "Next (Ctrl + N)"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(341, 51)
        Label6.Name = "Label6"
        Label6.Size = New Size(661, 38)
        Label6.TabIndex = 12
        Label6.Text = "Yash Raj Vishnoi , Slidly Task -2 , Slidly App Form"
        ' 
        ' ViewSubmissionsForm
        ' 
        AutoScaleDimensions = New SizeF(14F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1382, 879)
        Controls.Add(Label6)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(lblStopwatch)
        Controls.Add(lblGitHub)
        Controls.Add(lblPhone)
        Controls.Add(lblEmail)
        Controls.Add(lblName)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Font = New Font("Segoe UI Historic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(4, 4, 4, 4)
        Name = "ViewSubmissionsForm"
        Text = "ViewSubmissionsForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblName As TextBox
    Friend WithEvents lblEmail As TextBox
    Friend WithEvents lblPhone As TextBox
    Friend WithEvents lblGitHub As TextBox
    Friend WithEvents lblStopwatch As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label6 As Label
End Class
