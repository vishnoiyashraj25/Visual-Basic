<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Button1 = New Button()
        Button2 = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.CornflowerBlue
        Button1.Font = New Font("Segoe UI Historic", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(374, 368)
        Button1.Margin = New Padding(5, 5, 5, 5)
        Button1.Name = "Button1"
        Button1.Size = New Size(741, 131)
        Button1.TabIndex = 0
        Button1.Text = "Create Submission Form (Ctrl + N)"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Cornsilk
        Button2.Font = New Font("Segoe UI Historic", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(377, 175)
        Button2.Margin = New Padding(5, 5, 5, 5)
        Button2.Name = "Button2"
        Button2.Size = New Size(738, 131)
        Button2.TabIndex = 1
        Button2.Text = "View Submission Form (Ctrl + V)"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(415, 96)
        Label1.Margin = New Padding(5, 0, 5, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(645, 38)
        Label1.TabIndex = 2
        Label1.Text = "Yash Raj Vishnoi , Slidly Task 2-Slidly Form App "
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(17F, 38F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlLightLight
        ClientSize = New Size(1360, 684)
        Controls.Add(Label1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(5, 5, 5, 5)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
End Class
