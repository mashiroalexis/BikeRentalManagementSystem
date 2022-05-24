Public Class frmAddCustomer
    Private Sub frmAddCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        roundCorners(Me)
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Added Successfully!", vbInformation, "")

        txtFullName.Text = ""
        txtAddress.Text = ""
        txtContactNumber.Text = ""
        txtEmailAddress.Text = ""
    End Sub
End Class