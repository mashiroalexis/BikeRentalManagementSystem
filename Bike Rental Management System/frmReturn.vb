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
    Private Sub dtpReturnDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpReturnDate.ValueChanged
        dtpReturnDate.Format = DateTimePickerFormat.Custom
        dtpReturnDate.CustomFormat = "dd/MM/yyyy"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnOK.Click

    End Sub


End Class