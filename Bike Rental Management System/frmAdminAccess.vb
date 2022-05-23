Imports System.Data
Imports System.Data.SqlClient
Public Class frmAdminAccess

    Private Sub frmAdminAccess_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        roundCorners(Me)
        txtSystemPassword.UseSystemPasswordChar = True
        lblFailMsg.Left = (Me.ClientSize.Width / 2) - (lblFailMsg.Width / 2)

    End Sub
    Dim failCounter As Integer = 0
    Private Sub txtSystemPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSystemPassword.KeyPress
        If Asc(e.KeyChar) = 27 Then
            Me.Hide()
            Log.Show()
        ElseIf Asc(e.KeyChar) = 13 Then
            Dim con As SqlConnection = New SqlConnection("Data Source=ALEXIS\SQLEXPRESS;Initial Catalog=BikeRentalManagementSystem;Integrated Security=True")
            Dim cmd As SqlCommand = New SqlCommand("SELECT * FROM tblSystemAccess where access = '" + Me.txtSystemPassword.Text + "'", con)
            Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
            Dim dt As DataTable = New DataTable()
            sda.Fill(dt)
            If dt.Rows.Count > 0 Then
                Me.Hide()
                Splash.Show()

            Else
                tmrFailMsgBlinker.Enabled = True
                txtSystemPassword.Text = ""
                failCounter += 1
                If failCounter > 2 Then
                    Me.Close()
                End If
            End If
        End If
    End Sub
    Dim msgBlink As Integer = 0
    Private Sub tmrFailMsgBlinker_Tick(sender As Object, e As EventArgs) Handles tmrFailMsgBlinker.Tick
        If msgBlink > 0 Then
            lblFailMsg.Visible = True
            msgBlink = 0
        Else
            msgBlink += 1
            lblFailMsg.Visible = False
        End If
    End Sub

    Private Sub txtSystemPassword_TextChanged(sender As Object, e As EventArgs) Handles txtSystemPassword.TextChanged

    End Sub
End Class