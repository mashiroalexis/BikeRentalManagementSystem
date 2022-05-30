Imports System.Data
Imports System.Data.SqlClient


Public Class frmSelectCustomer
    Private Sub frmSelectCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rdr As SqlDataReader = Nothing
        Dim con As SqlConnection = New SqlConnection(getConnectionString)
        Dim cmd As SqlCommand = New SqlCommand("SELECT * FROM tblCustomer", con)
        con.Open()
        rdr = cmd.ExecuteReader()
        dgvCustomerList.Rows.Clear()
        While (rdr.Read() = True)
            dgvCustomerList.Rows.Add(rdr(0), rdr(1), rdr(2), rdr(3), rdr(4))
        End While
        con.Close()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        switchFormsInMain(frmRentBike)
    End Sub

    Private Sub dgvCustomerList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCustomerList.CellContentClick

    End Sub

    Private Sub dgvCustomerList_MouseClick(sender As Object, e As MouseEventArgs) Handles dgvCustomerList.MouseClick

    End Sub

    Private Sub btnSelectCustomer_Click(sender As Object, e As EventArgs) Handles btnSelectCustomer.Click
        Try
            If dgvCustomerList.Rows.Count > 0 Then
                Dim dr As DataGridViewRow = dgvCustomerList.SelectedRows(0)
                frmRentBike.txtCustomerId.Text = dr.Cells(0).Value.ToString()
                frmRentBike.txtCustomername.Text = dr.Cells(1).Value.ToString()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Me.Close()
        switchFormsInMain(frmRentBike)

    End Sub
End Class