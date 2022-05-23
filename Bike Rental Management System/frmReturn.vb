Public Class frmReturn
    Private Sub pbCloseReturnForm_Click(sender As Object, e As EventArgs) Handles pbCloseReturnForm.Click
        Me.Close()
    End Sub

    Private Sub pbCloseReturnForm_MouseHover(sender As Object, e As EventArgs) Handles pbCloseReturnForm.MouseHover
        pbCloseReturnForm.ForeColor = Color.WhiteSmoke
    End Sub

    Private Sub pbCloseReturnForm_MouseLeave(sender As Object, e As EventArgs) Handles pbCloseReturnForm.MouseLeave
        pbCloseReturnForm.ForeColor = Color.LightGray
    End Sub
End Class