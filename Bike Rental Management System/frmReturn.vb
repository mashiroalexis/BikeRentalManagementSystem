Imports System.Data
Imports System.Data.SqlClient


Public Class frmReturn

    Private Sub pbCloseReturnForm_Click(sender As Object, e As EventArgs) Handles pbCloseReturnForm.Click
        Me.Close()
    End Sub

    Private Sub frmReturn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadRentals()
        loadReturnedList()
    End Sub

    Private Sub loadReturnedList()
        Try
            Dim rdr As SqlDataReader = Nothing
            Dim con As SqlConnection = New SqlConnection(getConnectionString)
            Dim cmd As SqlCommand = New SqlCommand("SELECT * FROM tblRent where returned = 1", con)
            Dim customerFullName As String
            con.Open()
            rdr = cmd.ExecuteReader()

            dgvReturnedList.Rows.Clear()
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
                dgvReturnedList.Rows.Add(rdr(0), customerFullName, rdr(2), rdr(3), rdr(4), rdr(5), rdr(6))
            End While
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
    Private Sub loadRentals()
        Try
            Dim rdr As SqlDataReader = Nothing
            Dim con As SqlConnection = New SqlConnection(getConnectionString())
            Dim cmd As SqlCommand = New SqlCommand("SELECT * FROM tblRent where returned = 0", con)
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

    Private Sub dgvRentalList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRentalList.CellContentClick

    End Sub

    Private Sub dgvRentalList_MouseClick(sender As Object, e As MouseEventArgs) Handles dgvRentalList.MouseClick
        Try
            If dgvRentalList.Rows.Count > 0 Then

                Dim dr As DataGridViewRow = dgvRentalList.SelectedRows(0)
                If dr.Cells(0).Value Is Nothing Then
                    Return
                End If
                Dim varDptReturn As DateTime = DateTime.Parse(dr.Cells(3).Value.ToString())
                txtRentId.Text = dr.Cells(0).Value.ToString()
                txtCustomerName.Text = dr.Cells(1).Value.ToString()
                dtpRentTime.Value = dr.Cells(2).Value.ToString()
                dtpReturnTime.Value = varDptReturn
                txtHoursRented.Text = dr.Cells(4).Value.ToString()
                txtFee.Text = dr.Cells(5).Value.ToString()
                txtNoOfBikesRented.Text = dr.Cells(6).Value.ToString()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Dim con As SqlConnection = New SqlConnection(getConnectionString())
        Dim cmd As SqlCommand = New SqlCommand("UPDATE tblRent SET returned = 1 where id = @id", con)
        cmd.Parameters.AddWithValue("@id", txtRentId.Text)
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
        loadRentals()
        loadReturnedList()
        clearForm()
        MessageBox.Show("Rented bikes were returned!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub clearForm()
        txtRentId.Text = Nothing
        txtNoOfBikesRented.Text = Nothing
        txtCustomerName.Text = Nothing
        txtHoursRented.Text = Nothing
        dtpRentTime.Value = DateTime.Now
        dtpReturnTime.Value = DateTime.Now
        txtFee.Text = Nothing
    End Sub
End Class