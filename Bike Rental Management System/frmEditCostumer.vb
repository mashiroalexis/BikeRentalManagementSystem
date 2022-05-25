Imports System.Data
Imports System.Data.SqlClient

Public Class frmEditCostumer
    Dim customerId As Integer = 0
    Private Sub btlSaveCustomer_Click(sender As Object, e As EventArgs) Handles btnUpdateCustomer.Click
        Try
            Dim con As SqlConnection = New SqlConnection(getConnectionString())
            Dim cmd As SqlCommand = New SqlCommand("UPDATE tblCustomer SET fullName=@fullName, address=@address, contactNo=@contactNo, email=@email WHERE id=@id", con)
            cmd.Parameters.AddWithValue("@fullName", txtFullName.Text)
            cmd.Parameters.AddWithValue("@address", txtAddress.Text)
            cmd.Parameters.AddWithValue("@contactNo", txtContactNumber.Text)
            cmd.Parameters.AddWithValue("@email", txtEmailAddress.Text)
            cmd.Parameters.AddWithValue("@id", txtCustomerID.Text)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Customer record updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub

    Private Sub frmEditCostumer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub pbCloseCustomerEditForm_Click(sender As Object, e As EventArgs) Handles pbCloseCustomerEditForm.Click
        Me.ResetText()
        Me.Hide()

    End Sub
End Class