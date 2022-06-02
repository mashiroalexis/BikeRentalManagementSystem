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
        pbInsta.Visible = False
        pbFB.Visible = False
        pbTwt.Visible = False
        pbDev.Visible = False
        lblTitleDeveloper.Visible = False
    End Sub


    Private Sub pbFB_Click(sender As Object, e As EventArgs) Handles pbFB.Click

    End Sub

    Private Sub pbFB_MouseHover(sender As Object, e As EventArgs) Handles pbFB.MouseHover
        pbFB.ForeColor = Color.WhiteSmoke
    End Sub

    Private Sub pbFB_MouseLeave(sender As Object, e As EventArgs) Handles pbFB.MouseLeave
        pbFB.ForeColor = Color.LightGray
    End Sub

    Private Sub pbInsta_Click(sender As Object, e As EventArgs) Handles pbInsta.Click

    End Sub

    Private Sub pbInsta_MouseHover(sender As Object, e As EventArgs) Handles pbInsta.MouseHover
        pbInsta.ForeColor = Color.WhiteSmoke
    End Sub

    Private Sub pbInsta_MouseLeave(sender As Object, e As EventArgs) Handles pbInsta.MouseLeave
        pbInsta.ForeColor = Color.LightGray
    End Sub

    Private Sub pbTwt_Click(sender As Object, e As EventArgs) Handles pbTwt.Click

    End Sub

    Private Sub pbTwt_MouseHover(sender As Object, e As EventArgs) Handles pbTwt.MouseHover
        pbTwt.ForeColor = Color.WhiteSmoke
    End Sub

    Private Sub pbTwt_MouseLeave(sender As Object, e As EventArgs) Handles pbTwt.MouseLeave
        pbTwt.ForeColor = Color.LightGray
    End Sub

    Private Sub frmAbout_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lblAboutMessage_Click(sender As Object, e As EventArgs) Handles lblAboutMessage.Click

    End Sub
End Class