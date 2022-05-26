Public Class frmReturn

    Private Sub pbCloseReturnForm_Click(sender As Object, e As EventArgs) Handles pbCloseReturnForm.Click
        Me.Close()
    End Sub

    Private Sub frmReturn_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles dtpRentDate.ValueChanged
        dtpRentDate.Format = DateTimePickerFormat.Custom
        dtpRentDate.CustomFormat = "dd/MM/yyyy"
    End Sub
    Private Sub dtpReturnDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpRentTime.ValueChanged
        dtpRentTime.Format = DateTimePickerFormat.Custom
        dtpRentTime.CustomFormat = "hh:mm tt"
        dtpRentTime.ShowUpDown = True
    End Sub

    Private Sub dtpReturnTime_ValueChanged(sender As Object, e As EventArgs) Handles dtpReturnTime.ValueChanged
        dtpReturnTime.Format = DateTimePickerFormat.Custom
        dtpReturnTime.CustomFormat = "hh:mm tt"
        dtpReturnTime.ShowUpDown = True
    End Sub
End Class