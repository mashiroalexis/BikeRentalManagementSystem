Public Class Reg
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Registration Complete!", vbInformation, "")
        Me.Hide()
        Log.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Log.Show()

    End Sub
End Class