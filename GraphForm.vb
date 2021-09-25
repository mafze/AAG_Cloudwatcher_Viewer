Public Class GraphForm
    Private Sub Chart_SkyT_Click(sender As Object, e As EventArgs) Handles Chart_SkyT.Click
        Dim SkyTLimits As New GraphSettingsForm

        SkyTLimits.TextBox_MaxT.Text = Me.Chart_SkyT.ChartAreas(0).Axes(1).Maximum.ToString
        SkyTLimits.TextBox_MinT.Text = Me.Chart_SkyT.ChartAreas(0).Axes(1).Minimum.ToString

        SkyTLimits.Location = Me.Location

        SkyTLimits.ShowDialog()

        Try
            Me.Chart_SkyT.ChartAreas(0).Axes(1).Maximum = Double.Parse(SkyTLimits.TextBox_MaxT.Text)
            Me.Chart_SkyT.ChartAreas(0).Axes(1).Minimum = Double.Parse(SkyTLimits.TextBox_MinT.Text)
        Catch ex As Exception

        End Try

        SkyTLimits.Dispose()
    End Sub

End Class