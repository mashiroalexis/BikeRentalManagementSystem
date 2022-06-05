
Imports System.Data
Imports System.Data.SqlClient
Public Class Reg
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim rdr As SqlDataReader = Nothing
        Dim con As SqlConnection = New SqlConnection(getConnectionString())
        Dim cmd As SqlCommand = New SqlCommand("SELECT username, email, contactNo from tblUser WHERE username = @username or email = @email or contactNo = @contactNo", con)
        cmd.Parameters.AddWithValue("@username", txtUsername.Text)
        cmd.Parameters.AddWithValue("@email", txtEmail.Text)
        cmd.Parameters.AddWithValue("@contactNo", txtContact.Text)
        con.Open()
        rdr = cmd.ExecuteReader()

        If Not rdr.Read() Then
            MsgBox("Registered Successfully")
            Dim con1 As SqlConnection = New SqlConnection(getConnectionString())
            Dim cmd1 As SqlCommand = New SqlCommand("INSERT into tblUser values(@fName, @email, @contactNo, @username, @password, @type, @isEnabled)", con1)
            cmd1.Parameters.AddWithValue("@fName", txtFirstName.Text)
            cmd1.Parameters.AddWithValue("@email", txtEmail.Text)
            cmd1.Parameters.AddWithValue("@contactNo", txtContact.Text)
            cmd1.Parameters.AddWithValue("@username", txtUsername.Text)
            cmd1.Parameters.AddWithValue("@password", txtPassword.Text)
            cmd1.Parameters.AddWithValue("@type", "admin")
            cmd1.Parameters.AddWithValue("@isEnabled", 1)
            con1.Open()
            cmd1.ExecuteNonQuery()
            con1.Close()
        Else
            MsgBox("Duplicate")
        End If
        con.Close()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles lbllogin.Click
        Me.Close()
        Log.Show()
    End Sub

    Private Sub Reg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        roundCorners(Me)
    End Sub
End Class