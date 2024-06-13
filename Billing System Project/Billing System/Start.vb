Public Class Start

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        Dim percentage As String
        percentage = Convert.ToString(ProgressBar1.Value)
        percentageLbl.Text = percentage + "%"
        ProgressBar1.Increment(1)

        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Timer1.Stop()
            Dim log = New Loging
            log.Show()
        End If

    End Sub
End Class
