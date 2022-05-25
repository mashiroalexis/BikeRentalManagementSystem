Imports System.Data
Imports System.Data.SqlClient
Public Class frmAddCustomer
    Private Sub frmAddCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub pbCloseAddCustomerForm_Click(sender As Object, e As EventArgs) Handles pbCloseAddCustomerForm.Click
        Me.Close()
    End Sub

    Private Sub pbCloseAddCustomerForm_MouseHover(sender As Object, e As EventArgs) Handles pbCloseAddCustomerForm.MouseHover
        pbCloseAddCustomerForm.ForeColor = Color.WhiteSmoke
    End Sub

    Private Sub pbCloseAddCustomerForm_MouseLeave(sender As Object, e As EventArgs) Handles pbCloseAddCustomerForm.MouseLeave
        pbCloseAddCustomerForm.ForeColor = Color.LightGray
    End Sub

    Private Sub btnAddCustomer_Click_1(sender As Object, e As EventArgs) Handles btnAddCustomer.Click
        Try
            ' this is for checking if the customer already exists before adding new custoemr
            Dim rdr As SqlDataReader = Nothing
            Dim con As SqlConnection = New SqlConnection(getConnectionString())
            con.Open()
            Dim cmd As SqlCommand = New SqlCommand("SELECT contactNo FROM tblCustomer where contactNo = '" + txtContactNumber.Text + "'", con)
            rdr = cmd.ExecuteReader()
            If rdr.Read() Then
                MessageBox.Show("Customer already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                If rdr IsNot Nothing Then
                    rdr.Close()
                End If
                Return
            End If
            con.Close()
            ' save new customer to database
            Dim fullName As String = txtFullName.Text
            Dim address As String = txtAddress.Text
            Dim contactNo As String = txtContactNumber.Text
            Dim email As String = txtEmailAddress.Text

            con = New SqlConnection(getConnectionString())
            cmd = New SqlCommand("INSERT INTO tblCustomer VALUES(@fullName, @address, @contactNo, @email)", con)
            cmd.Parameters.AddWithValue("@fullName", fullName)
            cmd.Parameters.AddWithValue("@address", address)
            cmd.Parameters.AddWithValue("@contactNo", contactNo)
            cmd.Parameters.AddWithValue("@email", email)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            txtFullName.Text = ""
            txtAddress.Text = ""
            txtContactNumber.Text = ""
            txtEmailAddress.Text = ""
            MessageBox.Show("New customer record saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
            switchFormsInMain(frmCustomer)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
    End Sub
End Class