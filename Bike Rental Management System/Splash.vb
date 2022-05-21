Public Class Splash
    Dim tmrC As Integer
    Private Sub tmrSplashForm_Tick(sender As Object, e As EventArgs) Handles tmrSplashForm.Tick
        tmrC += 1
        If tmrC >= 3 Then
            Me.tmrSplashForm.Enabled = False
            Me.Hide()
            frmMain.Show()

        End If

    End Sub

    Private Sub Splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class