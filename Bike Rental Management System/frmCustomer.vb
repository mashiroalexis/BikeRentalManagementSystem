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
        switchMenu(frmAddCustomer)
        Me.Close()

    End Sub

    Private Sub btnAddNewCust_MouseHover(sender As Object, e As EventArgs) Handles btnAddNewCust.MouseHover
        btnAddNewCust.ForeColor = Color.WhiteSmoke
    End Sub

    Private Sub btnAddNewCust_MouseLeave(sender As Object, e As EventArgs) Handles btnAddNewCust.MouseLeave
        btnAddNewCust.ForeColor = Color.LightGray
    End Sub

    Private Sub frmCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'MessageBox.Show("I am loaded", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
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
            dgvCustomers.Rows.Add(rdr(0), rdr(1), rdr(2), rdr(3), rdr(4))
        End While
        con.Close()

    End Sub

    Private Sub dgvCustomers_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCustomers.CellContentClick

    End Sub


    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        switchMenu(frmEditCostumer)
        Me.Close()

    End Sub

    'switch forms
    Dim activeChildForm As Form = Nothing
    Private Sub switchMenu(panel As Form)
        If activeChildForm IsNot Nothing Then
            activeChildForm.Close()
        End If

        frmMain.pnlChildFormContainer.Controls.Clear()
        panel.TopLevel = False
        panel.Dock = DockStyle.Fill
        panel.FormBorderStyle = FormBorderStyle.None
        frmMain.pnlChildFormContainer.Controls.Add(panel)
        frmMain.pnlChildFormContainer.Tag = panel
        panel.BringToFront()
        panel.Show()
    End Sub

    Private Sub dgvCustomers_MouseClick(sender As Object, e As MouseEventArgs) Handles dgvCustomers.MouseClick
        Try
            If dgvCustomers.Rows.Count > 0 Then
                Dim dr As DataGridViewRow = dgvCustomers.SelectedRows(0)
                frmEditCostumer.txtCustomerID.Text = dr.Cells(0).Value.ToString()
                frmEditCostumer.txtFullName.Text = dr.Cells(1).Value.ToString()
                frmEditCostumer.txtAddress.Text = dr.Cells(2).Value.ToString()
                frmEditCostumer.txtContactNumber.Text = dr.Cells(3).Value.ToString()
                frmEditCostumer.txtEmailAddress.Text = dr.Cells(4).Value.ToString()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim dr As DataGridViewRow = dgvCustomers.SelectedRows(0)
        frmDeleteCustomer.txtCustomerId.Text = dr.Cells(0).Value.ToString()
        Me.Close()
        switchMenu(frmDeleteCustomer)


    End Sub
End Class