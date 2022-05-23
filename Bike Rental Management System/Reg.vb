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
End Class