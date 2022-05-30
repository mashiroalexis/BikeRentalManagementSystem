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

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles dtpRenttime.ValueChanged
        dtpRenttime.Format = DateTimePickerFormat.Custom
        dtpRenttime.CustomFormat = "hh:mm tt"
        dtpRenttime.ShowUpDown = True
    End Sub

    Private Sub dtpReturntime_ValueChanged(sender As Object, e As EventArgs) Handles dtpReturntime.ValueChanged
        dtpReturntime.Format = DateTimePickerFormat.Custom
        dtpReturntime.CustomFormat = "hh:mm tt"
        dtpReturntime.ShowUpDown = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim d1 As DateTime = dtp1.Value
        Dim d2 As DateTime = dtp2.Value
        Dim result As TimeSpan = d2.Subtract(d1)
        Dim days As TimeSpan = result.Duration
        Dim hrs As Double = Math.Round(result.TotalHours)

        If hrs < 1 Then
            MessageBox.Show("Minimum 1hr to rent a bike", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        txtHoursrented.Text = hrs.ToString
    End Sub
End Class