Imports System.Data
Imports System.Data.SqlClient


Public Class frmReturn

    Private Sub pbCloseReturnForm_Click(sender As Object, e As EventArgs) Handles pbCloseReturnForm.Click
        Me.Close()
    End Sub

    Private Sub frmReturn_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
End Class