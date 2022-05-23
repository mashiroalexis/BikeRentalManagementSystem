Public Class frmAbout
    Private Sub pbCloseAboutForm_Click(sender As Object, e As EventArgs) Handles pbCloseAboutForm.Click
        Me.Close()
    End Sub

    Private Sub pbCloseAboutForm_MouseHover(sender As Object, e As EventArgs) Handles pbCloseAboutForm.MouseHover
        pbCloseAboutForm.ForeColor = Color.WhiteSmoke
    End Sub

    Private Sub pbCloseAboutForm_MouseLeave(sender As Object, e As EventArgs) Handles pbCloseAboutForm.MouseLeave
        pbCloseAboutForm.ForeColor = Color.LightGray
    End Sub
End Class