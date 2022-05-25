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

    Private Sub lblTitleDeveloper_MouseHover(sender As Object, e As EventArgs) Handles lblTitleDeveloper.MouseHover
        lblTitleDeveloper.ForeColor = Color.WhiteSmoke
    End Sub

    Private Sub lblTitleDeveloper_MouseLeave(sender As Object, e As EventArgs) Handles lblTitleDeveloper.MouseLeave
        lblTitleDeveloper.ForeColor = Color.LightGray
    End Sub

    Private Sub lblTitleDeveloper_Click(sender As Object, e As EventArgs) Handles lblTitleDeveloper.Click
        pnlDevMessage.Visible = True
        pbFacebook.Visible = False
        pbInstagram.Visible = False
        pbTwitter.Visible = False
        pbDev.Visible = False
        lblTitleDeveloper.Visible = False
    End Sub
End Class