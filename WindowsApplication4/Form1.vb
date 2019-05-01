Public Class Form1

    Private Sub TitleTimer_Tick(sender As Object, e As EventArgs) Handles TitleTimer.Tick
        LogoBox.Left += 20
        TitleLabel.Left += 20
        If (TitleLabel.Right >= ExitBT.Left - 3) Then
            LogoBox.Left = 0
            TitleLabel.Left = LogoBox.Right + 3

        End If


    End Sub

    Private Sub ExitBT_Click(sender As Object, e As EventArgs) Handles ExitBT.Click
        Me.Close()
    End Sub
End Class
