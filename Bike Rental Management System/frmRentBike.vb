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

    Private Sub btnAddNewRent_Click(sender As Object, e As EventArgs) Handles btnAddNewRent.Click
        'Try
        Dim con As SqlConnection = New SqlConnection(getConnectionString())
        Dim cmd As SqlCommand = New SqlCommand("INSERT INTO tblRent VALUES(@customerId, @startRentTime, @returnRentTime, @hrsRented, @fee, @noBikeRented, @returned); Select Scope_Identity()", con)
        cmd.Parameters.AddWithValue("@customerId", txtCustomerId.Text)
        cmd.Parameters.AddWithValue("@startRentTime", dtp1.Value.ToString)
        cmd.Parameters.AddWithValue("@returnRentTime", dtp2.Value.ToString)
        cmd.Parameters.AddWithValue("@hrsRented", txtHoursrented.Text)
        cmd.Parameters.AddWithValue("@fee", txtFee.Text)
        cmd.Parameters.AddWithValue("@noBikeRented", txtNoofBikesRented.Text)
        cmd.Parameters.AddWithValue("@returned", 0)
        con.Open()
        Dim currentRentID As Integer = cmd.ExecuteScalar()
        con.Close()

        For i As Integer = 0 To clbAvailableBikes.Items.Count - 1
            If clbAvailableBikes.GetItemCheckState(i) Then
                con = New SqlConnection(getConnectionString())
                cmd = New SqlCommand("INSERT INTO tblBikeRented VALUES(@bikeId, @rentId)", con)
                cmd.Parameters.AddWithValue("@bikeId", i)
                cmd.Parameters.AddWithValue("@rentId", currentRentID)
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()
            End If
        Next
        loadRentals()
        MessageBox.Show("Bike(s) Rented!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'Catch ex As Exception
        'MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        ' End Try

        For i As Integer = 0 To clbAvailableBikes.Items.Count - 1
            clbAvailableBikes.SetItemChecked(i, False)
        Next
        txtNoofBikesRented.Text = 0
        txtCustomername.Text = ""
        txtHoursrented.Text = 0
        txtFee.Text = 0
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Dim i As Integer
        For i = 0 To (clbAvailableBikes.Items.Count - 1)
            clbAvailableBikes.SetItemChecked(i, False)
        Next
        txtNoofBikesRented.Text = "0"
        txtCustomername.Text = ""
        txtHoursrented.Text = "0"
        txtFee.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
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
        If txtNoofBikesRented.Text > 0 Then
            btnAddNewRent.Enabled = True
        Else
            btnAddNewRent.Enabled = False
            MessageBox.Show("Select a bike to rent", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub


    Private Sub frmRentBike_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadBikesList()
        loadRentals()
    End Sub
    Private Sub loadRentals()
        Try
            Dim rdr As SqlDataReader = Nothing
            Dim con As SqlConnection = New SqlConnection(getConnectionString)
            Dim cmd As SqlCommand = New SqlCommand("SELECT * FROM tblRent", con)
            Dim customerFullName As String
            con.Open()
            rdr = cmd.ExecuteReader()

            dgvRentalList.Rows.Clear()
            While (rdr.Read() = True)
                Dim rdr1 As SqlDataReader = Nothing
                Dim con1 As SqlConnection = New SqlConnection(getConnectionString())
                Dim cmd1 As SqlCommand = New SqlCommand("SELECT fullName FROM tblCustomer where Id = @id", con1)
                cmd1.Parameters.AddWithValue("@id", rdr(1).ToString)
                con1.Open()
                rdr1 = cmd1.ExecuteReader()

                If rdr1.Read() Then
                    customerFullName = rdr1(0).ToString
                    If rdr1 IsNot Nothing Then
                        rdr1.Close()
                    End If
                End If
                con1.Close()
                dgvRentalList.Rows.Add(rdr(0), customerFullName, rdr(2), rdr(3), rdr(4), rdr(5), rdr(6))
            End While
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub

    Private Sub loadBikesList()
        Try
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
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub



    Private Sub txtCustomername_MouseClick(sender As Object, e As MouseEventArgs) Handles txtCustomername.MouseClick
        switchFormsInMain(frmSelectCustomer)
    End Sub

    Private Sub btnCalcu_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
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
        If txtNoofBikesRented.Text > 0 Then
            btnAddNewRent.Enabled = True
        Else
            btnAddNewRent.Enabled = False
            MessageBox.Show("Select a bike to rent", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
End Class