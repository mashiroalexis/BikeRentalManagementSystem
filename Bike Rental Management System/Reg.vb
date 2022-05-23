Public Class Reg
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        MsgBox("Registration Complete!", vbInformation, "")
        Me.Hide()
        Log.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles lbllogin.Click
        Me.Close()
        Log.Show()
    End Sub

    Private Sub Reg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        roundCorners(Me)
    End Sub

    Private Sub Reg_MouseHover(sender As Object, e As EventArgs) Handles Me.MouseHover
        Me.lbllogin.ForeColor = Color.RoyalBlue
    End Sub

    Private Sub Reg_MouseLeave(sender As Object, e As EventArgs) Handles Me.MouseLeave
        Me.lbllogin.ForeColor = Color.White
    End Sub
End Class