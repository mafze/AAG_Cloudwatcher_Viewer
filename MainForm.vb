Imports System.ComponentModel
Imports System.Math

Public Class MainForm
    Dim oCW As Object
    Dim SkyTGraph As New GraphForm

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load

        Try
            oCW = CreateObject("AAG_CloudWatcher.CloudWatcher")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "AAG CloudWatcher Viewer")
            End
        End Try

        Me.Location = My.Settings.Location
        SkyTGraph.Chart_SkyT.ChartAreas(0).AxisX.LabelStyle.Format = "HH:mm"
        SkyTGraph.Chart_SkyT.ChartAreas(0).Axes(1).Maximum = My.Settings.SkyMaxT
        SkyTGraph.Chart_SkyT.ChartAreas(0).Axes(1).Minimum = My.Settings.SkyMinT

        Timer.Interval = 10000
        Timer.Start()
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        Dim AAG_skytemp As Double
        Dim AAG_ambtemp As Double
        Dim AAG_dewpoint As Double
        Dim AAG_relhumid As Double

        AAG_skytemp = oCW.SkyTemperature()
        AAG_ambtemp = oCW.AmbientTemperature()
        AAG_dewpoint = oCW.DewPointTemp()
        AAG_relhumid = oCW.HumidityRelative()

        Label_SkyT.Text = Round(AAG_skytemp, 1).ToString
        Label_AmbT.Text = Round(AAG_ambtemp, 1).ToString
        Label_DewT.Text = Round(AAG_dewpoint, 1).ToString
        Label_RelH.Text = Round(AAG_relhumid, 0).ToString + "%"

        SkyTGraph.Chart_SkyT.Series(0).Points.AddXY(DateTime.Now, Round(AAG_skytemp, 1))
    End Sub

    Private Sub CheckBox_ShowGraph_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_ShowGraph.CheckedChanged
        If CheckBox_ShowGraph.Checked Then
            SkyTGraph.Location = New Point(Me.Location.X, Me.Location.Y + Me.Height)
            'SkyTGraph.Width = Me.Width
            'SkyTGraph.Height = Me.Height

            SkyTGraph.Show()
        Else
            SkyTGraph.Hide()
        End If
    End Sub

    Private Sub Button_ClearGraph_Click(sender As Object, e As EventArgs) Handles Button_ClearGraph.Click
        SkyTGraph.Chart_SkyT.Series(0).Points.Clear()
    End Sub

    Private Sub MainForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        oCW = Nothing
        My.Settings.Location = Me.Location
        My.Settings.SkyMaxT = SkyTGraph.Chart_SkyT.ChartAreas(0).Axes(1).Maximum
        My.Settings.SkyMinT = SkyTGraph.Chart_SkyT.ChartAreas(0).Axes(1).Minimum
    End Sub
End Class
