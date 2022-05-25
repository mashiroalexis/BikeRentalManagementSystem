Public Class frmEditCostumer
    Dim customerId As Integer = 0
    Private Sub btlSaveCustomer_Click(sender As Object, e As EventArgs) Handles btlSaveCustomer.Click

    End Sub

    Private Sub frmEditCostumer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub pbCloseCustomerEditForm_Click(sender As Object, e As EventArgs) Handles pbCloseCustomerEditForm.Click
        Me.ResetText()
        Me.Hide()

    End Sub
End Class