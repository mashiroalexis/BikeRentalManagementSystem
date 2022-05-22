Public Class frmCustomer
    Private Sub pbCustomerLogo_Click(sender As Object, e As EventArgs) Handles pbCustomerLogo.Click

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
End Class