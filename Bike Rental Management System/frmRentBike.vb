Public Class frmRentBike
    Private Sub pbCloseRentForm_Click(sender As Object, e As EventArgs) Handles pbCloseRentForm.Click
        Me.Close()
    End Sub

    Private Sub pbCloseRentForm_MouseHover(sender As Object, e As EventArgs) Handles pbCloseRentForm.MouseHover
        Me.pbCloseRentForm.ForeColor = Color.WhiteSmoke
    End Sub

    Private Sub pbCloseRentForm_MouseLeave(sender As Object, e As EventArgs) Handles pbCloseRentForm.MouseLeave
        Me.pbCloseRentForm.ForeColor = Color.LightGray
    End Sub
End Class