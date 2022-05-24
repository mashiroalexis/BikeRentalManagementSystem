﻿Public Class frmRentBike
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

    Private Sub btnAddNewRent_Click(sender As Object, e As EventArgs) Handles btnAddNewRent.Click
        Dim i As Integer
        For i = 0 To (clbAvailableBikes.Items.Count - 1)
            clbAvailableBikes.SetItemChecked(i, False)
        Next

        MsgBox("Added Successfully!", vbInformation, "")
        txtNoofBikesRented.Text = ""
        txtCustomername.Text = ""
        txtHoursrented.Text = ""
        txtfee.Text = ""

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Dim i As Integer
        For i = 0 To (clbAvailableBikes.Items.Count - 1)
            clbAvailableBikes.SetItemChecked(i, False)
        Next
        txtNoofBikesRented.Text = ""
        txtCustomername.Text = ""
        txtHoursrented.Text = ""
        txtfee.Text = ""
    End Sub
End Class