Imports System.Data
Imports System.Data.SqlClient

Public Class Log
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        logMeIn()
    End Sub
    Private Sub logMeIn()
        Dim con As SqlConnection = New SqlConnection(getConnectionString())
        Dim cmd As SqlCommand = New SqlCommand("SELECT * FROM tblUser where username=@username and password=@password and isEnabled = 1", con)
        Dim rdr As SqlDataReader = Nothing

        cmd.Parameters.AddWithValue("@username", txtUsername.Text)
        cmd.Parameters.AddWithValue("@password", txtPassword.Text)
        con.Open()
        rdr = cmd.ExecuteReader()


        If rdr.Read() = True Then
            setUserId(rdr(0))
            con.Close()
            Splash.Show()
            Me.Hide()
        Else
            MessageBox.Show("Incrrect username or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPassword.Text = ""
        End If

        con.Close()
    End Sub

    Private Sub Log_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        roundCorners(Me)



    End Sub


    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles lblsignup.Click
        Me.Hide()
        Reg.Show()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles btnminimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub txtUsername_Enter(sender As Object, e As EventArgs) Handles txtUsername.Enter
        If txtUsername.Text = "Username" Then
            txtUsername.Text = ""
            txtUsername.ForeColor = Color.White
        End If
    End Sub

    Private Sub txtUsername_Leave(sender As Object, e As EventArgs) Handles txtUsername.Leave
        If txtUsername.Text = "" Then
            txtUsername.Text = "Username"
            txtUsername.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub txtPassword_Enter(sender As Object, e As EventArgs) Handles txtPassword.Enter
        If txtPassword.Text = "Password" Then
            txtPassword.Text = ""
            txtPassword.PasswordChar = "*"
            txtPassword.ForeColor = Color.White
        End If
    End Sub

    Private Sub txtPassword_Leave(sender As Object, e As EventArgs) Handles txtPassword.Leave
        If txtPassword.Text = "" Then
            txtPassword.Text = "Password"
            txtPassword.PasswordChar = ""
            txtPassword.ForeColor = Color.Silver
        End If
    End Sub
    Dim cSec As Integer
    Private Sub pbLogo_Click(sender As Object, e As EventArgs) Handles pbLogo.Click
        cSec += 1
        If cSec >= 3 Then
            cSec = 0
            Me.Hide()
            frmAdminAccess.Show()
        End If

    End Sub



    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        If Asc(e.KeyChar) = 13 Then
            logMeIn()
        End If
    End Sub


End Class

