Public Class Log

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Me.Hide()
        Splash.Show()

    End Sub

    Private Sub Log_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        roundCorners(Me)



    End Sub

    Private Sub txtLogin_TextChanged(sender As Object, e As EventArgs) Handles txtLogin.TextChanged


    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles lblsignup.Click
        Me.Hide()
        Reg.Show()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblclose.Click
        Me.Close()

    End Sub
End Class
