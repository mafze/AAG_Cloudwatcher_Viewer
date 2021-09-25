<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GraphSettingsForm
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
        Me.TextBox_MaxT = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox_MinT = New System.Windows.Forms.TextBox()
        Me.Button_OK = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBox_MaxT
        '
        Me.TextBox_MaxT.Location = New System.Drawing.Point(281, 81)
        Me.TextBox_MaxT.Name = "TextBox_MaxT"
        Me.TextBox_MaxT.Size = New System.Drawing.Size(100, 38)
        Me.TextBox_MaxT.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 32)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Max  Sky Temp"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(47, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(201, 32)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Min  Sky Temp"
        '
        'TextBox_MinT
        '
        Me.TextBox_MinT.Location = New System.Drawing.Point(281, 23)
        Me.TextBox_MinT.Name = "TextBox_MinT"
        Me.TextBox_MinT.Size = New System.Drawing.Size(100, 38)
        Me.TextBox_MinT.TabIndex = 2
        '
        'Button_OK
        '
        Me.Button_OK.Location = New System.Drawing.Point(145, 167)
        Me.Button_OK.Name = "Button_OK"
        Me.Button_OK.Size = New System.Drawing.Size(149, 50)
        Me.Button_OK.TabIndex = 4
        Me.Button_OK.Text = "OK"
        Me.Button_OK.UseVisualStyleBackColor = True
        '
        'GraphSettingsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(446, 229)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button_OK)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox_MinT)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox_MaxT)
        Me.Name = "GraphSettingsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Limits"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox_MaxT As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox_MinT As TextBox
    Friend WithEvents Button_OK As Button
End Class
