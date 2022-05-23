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

    End Sub
End Class