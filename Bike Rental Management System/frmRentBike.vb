Imports System.Data
Imports System.Data.SqlClient
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
        txtFee.Text = ""

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Dim i As Integer
        For i = 0 To (clbAvailableBikes.Items.Count - 1)
            clbAvailableBikes.SetItemChecked(i, False)
        Next
        txtNoofBikesRented.Text = ""
        txtCustomername.Text = ""
        txtHoursrented.Text = ""
        txtFee.Text = ""
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
        Dim rentPrice As Integer = 0
        Dim noOfBikesRented As Integer = 0

        If Val(txtCustomerId.Text) < 1 Then
            MessageBox.Show("Select a customer first!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If hrs < 1 Then
            txtHoursrented.Text = 0
            MessageBox.Show("Minimum 1hr to rent a bike", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

        txtHoursrented.Text = hrs.ToString
        For i As Integer = 0 To clbAvailableBikes.Items.Count - 1
            If clbAvailableBikes.GetItemCheckState(i) Then
                rentPrice += 50
                txtFee.Text = rentPrice * hrs
                noOfBikesRented += 1
            End If
        Next
        txtNoofBikesRented.Text = noOfBikesRented
    End Sub

    Private Sub clbAvailableBikes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles clbAvailableBikes.SelectedIndexChanged


    End Sub

    Private Sub clbAvailableBikes_MouseClick(sender As Object, e As MouseEventArgs) Handles clbAvailableBikes.MouseClick

    End Sub

    Private Sub clbAvailableBikes_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles clbAvailableBikes.ItemCheck

    End Sub

    Private Sub frmRentBike_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadBikesList()
    End Sub

    Private Sub loadBikesList()
        Dim rdr As SqlDataReader = Nothing
        Dim con As SqlConnection = New SqlConnection(getConnectionString)
        Dim cmd As SqlCommand = New SqlCommand("SELECT * FROM tblBike", con)
        con.Open()
        rdr = cmd.ExecuteReader()

        clbAvailableBikes.Items.Clear()
        While (rdr.Read() = True)
            clbAvailableBikes.Items.Add(rdr(1))
        End While
        con.Close()
    End Sub



    Private Sub txtCustomername_MouseClick(sender As Object, e As MouseEventArgs) Handles txtCustomername.MouseClick
        switchFormsInMain(frmSelectCustomer)
    End Sub
End Class