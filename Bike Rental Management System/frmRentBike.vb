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

    Private Sub dtpRentdate_ValueChanged(sender As Object, e As EventArgs) Handles dtpRentdate.ValueChanged
        dtpRentdate.Format = DateTimePickerFormat.Custom
        dtpRentdate.CustomFormat = "dd/MM/yyyy"
    End Sub
End Class