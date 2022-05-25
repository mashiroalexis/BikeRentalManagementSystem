Imports System.Data
Imports System.Data.SqlClient


Public Class frmCustomer
    Private Sub pbCustomerLogo_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub pbCloseCustomerForm_Click(sender As Object, e As EventArgs) Handles pbCloseCustomerForm.Click
        Me.Close()

    End Sub

    Private Sub pbCloseCustomerForm_MouseHover(sender As Object, e As EventArgs) Handles pbCloseCustomerForm.MouseHover
        Me.pbCloseCustomerForm.ForeColor = System.Drawing.Color.WhiteSmoke

    End Sub

    Private Sub pbCloseCustomerForm_MouseLeave(sender As Object, e As EventArgs) Handles pbCloseCustomerForm.MouseLeave
        Me.pbCloseCustomerForm.ForeColor = System.Drawing.Color.LightGray
    End Sub

    Private Sub IconPictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnAddNewCust_Click(sender As Object, e As EventArgs) Handles btnAddNewCust.Click
        frmAddCustomer.Show()

    End Sub

    Private Sub btnAddNewCust_MouseHover(sender As Object, e As EventArgs) Handles btnAddNewCust.MouseHover
        btnAddNewCust.ForeColor = Color.WhiteSmoke
    End Sub

    Private Sub btnAddNewCust_MouseLeave(sender As Object, e As EventArgs) Handles btnAddNewCust.MouseLeave
        btnAddNewCust.ForeColor = Color.LightGray
    End Sub

    Private Sub frmCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadCustomerGrid()
    End Sub

    Private Sub loadCustomerGrid()
        Dim rdr As SqlDataReader = Nothing
        Dim con As SqlConnection = New SqlConnection(getConnectionString)
        Dim cmd As SqlCommand = New SqlCommand("SELECT * FROM tblCustomer", con)
        con.Open()
        rdr = cmd.ExecuteReader()
        dgvCustomers.Rows.Clear()
        While (rdr.Read() = True)
            dgvCustomers.Rows.Add(rdr(1), rdr(2), rdr(3), rdr(4))
        End While
        con.Close()

    End Sub

    Private Sub dgvCustomers_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCustomers.CellContentClick

    End Sub
End Class