<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label_SkyT = New System.Windows.Forms.Label()
        Me.Label_AmbT = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label_DewT = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label_RelH = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CheckBox_ShowGraph = New System.Windows.Forms.CheckBox()
        Me.Button_ClearGraph = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Timer
        '
        Me.Timer.Interval = 300
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.1!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 26)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 44)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sky T:"
        '
        'Label_SkyT
        '
        Me.Label_SkyT.AutoSize = True
        Me.Label_SkyT.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.1!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_SkyT.Location = New System.Drawing.Point(149, 26)
        Me.Label_SkyT.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label_SkyT.Name = "Label_SkyT"
        Me.Label_SkyT.Size = New System.Drawing.Size(53, 44)
        Me.Label_SkyT.TabIndex = 1
        Me.Label_SkyT.Text = "..."
        '
        'Label_AmbT
        '
        Me.Label_AmbT.AutoSize = True
        Me.Label_AmbT.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.1!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_AmbT.Location = New System.Drawing.Point(149, 99)
        Me.Label_AmbT.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label_AmbT.Name = "Label_AmbT"
        Me.Label_AmbT.Size = New System.Drawing.Size(53, 44)
        Me.Label_AmbT.TabIndex = 3
        Me.Label_AmbT.Text = "..."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.1!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 99)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(143, 44)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Amb T:"
        '
        'Label_DewT
        '
        Me.Label_DewT.AutoSize = True
        Me.Label_DewT.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.1!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_DewT.Location = New System.Drawing.Point(404, 26)
        Me.Label_DewT.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label_DewT.Name = "Label_DewT"
        Me.Label_DewT.Size = New System.Drawing.Size(53, 44)
        Me.Label_DewT.TabIndex = 5
        Me.Label_DewT.Text = "..."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.1!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(256, 26)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(139, 44)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Dew T:"
        '
        'Label_RelH
        '
        Me.Label_RelH.AutoSize = True
        Me.Label_RelH.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.1!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_RelH.Location = New System.Drawing.Point(404, 99)
        Me.Label_RelH.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label_RelH.Name = "Label_RelH"
        Me.Label_RelH.Size = New System.Drawing.Size(53, 44)
        Me.Label_RelH.TabIndex = 7
        Me.Label_RelH.Text = "..."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.1!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(256, 99)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 44)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Rel H:"
        '
        'CheckBox_ShowGraph
        '
        Me.CheckBox_ShowGraph.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBox_ShowGraph.AutoSize = True
        Me.CheckBox_ShowGraph.Location = New System.Drawing.Point(90, 171)
        Me.CheckBox_ShowGraph.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CheckBox_ShowGraph.Name = "CheckBox_ShowGraph"
        Me.CheckBox_ShowGraph.Size = New System.Drawing.Size(136, 35)
        Me.CheckBox_ShowGraph.TabIndex = 13
        Me.CheckBox_ShowGraph.Text = "Graph SkyT"
        Me.CheckBox_ShowGraph.UseVisualStyleBackColor = True
        '
        'Button_ClearGraph
        '
        Me.Button_ClearGraph.Location = New System.Drawing.Point(280, 171)
        Me.Button_ClearGraph.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button_ClearGraph.Name = "Button_ClearGraph"
        Me.Button_ClearGraph.Size = New System.Drawing.Size(124, 40)
        Me.Button_ClearGraph.TabIndex = 14
        Me.Button_ClearGraph.Text = "Clear Graph"
        Me.Button_ClearGraph.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(497, 219)
        Me.Controls.Add(Me.Button_ClearGraph)
        Me.Controls.Add(Me.CheckBox_ShowGraph)
        Me.Controls.Add(Me.Label_RelH)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label_DewT)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label_AmbT)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label_SkyT)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainForm"
        Me.Text = "AAG CloudWatcher Viewer"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Timer As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents Label_SkyT As Label
    Friend WithEvents Label_AmbT As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label_DewT As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label_RelH As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents CheckBox_ShowGraph As CheckBox
    Friend WithEvents Button_ClearGraph As Button
End Class
