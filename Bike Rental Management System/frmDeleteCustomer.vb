Imports System.Data
Imports System.Data.SqlClient


Public Class frmDeleteCustomer
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
        switchFormsInMain(frmCustomer)

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            Dim con As SqlConnection = New SqlConnection(getConnectionString())
            Dim cmd As SqlCommand = New SqlCommand("DELETE from tblCustomer WHERE id=@id", con)
            cmd.Parameters.AddWithValue("@id", txtCustomerId.Text)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            Me.Close()
            switchFormsInMain(frmCustomer)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
End Class