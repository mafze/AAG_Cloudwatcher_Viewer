<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GraphForm
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Chart_SkyT = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.Chart_SkyT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Chart_SkyT
        '
        ChartArea1.AxisX.IsMarginVisible = False
        ChartArea1.AxisX.MajorGrid.Enabled = False
        ChartArea1.AxisY.MajorGrid.Enabled = False
        ChartArea1.AxisY.Maximum = -18.0R
        ChartArea1.AxisY.Minimum = -24.0R
        ChartArea1.Name = "ChartArea1"
        Me.Chart_SkyT.ChartAreas.Add(ChartArea1)
        Me.Chart_SkyT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Chart_SkyT.Location = New System.Drawing.Point(0, 0)
        Me.Chart_SkyT.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Chart_SkyT.Name = "Chart_SkyT"
        Series1.BorderWidth = 2
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point
        Series1.MarkerColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Series1.MarkerSize = 2
        Series1.Name = "Series1"
        Series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time
        Me.Chart_SkyT.Series.Add(Series1)
        Me.Chart_SkyT.Size = New System.Drawing.Size(800, 450)
        Me.Chart_SkyT.TabIndex = 0
        Me.Chart_SkyT.Text = "Chart1"
        Me.ToolTip.SetToolTip(Me.Chart_SkyT, "Right-click on the graph to set the maximum and minimum values of the vertical sc" &
        "ale.")
        '
        'ToolTip
        '
        Me.ToolTip.ToolTipTitle = "Graph Help"
        '
        'GraphForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.Chart_SkyT)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "GraphForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Sky Temperature Graph"
        CType(Me.Chart_SkyT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Chart_SkyT As DataVisualization.Charting.Chart
    Friend WithEvents ToolTip As ToolTip
End Class
