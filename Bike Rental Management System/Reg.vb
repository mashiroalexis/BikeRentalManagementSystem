Public Class Reg
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        MsgBox("Registration Complete!", vbInformation, "")
        Me.Hide()
        Log.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
        Log.Show()

    End Sub
End Class