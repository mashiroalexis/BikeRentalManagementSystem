
Imports System.Data
Imports System.Data.SqlClient
Public Class Reg
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim rdr As SqlDataReader = Nothing
        Dim con As SqlConnection = New SqlConnection(getConnectionString())
        Dim cmd As SqlCommand = New SqlCommand("SELECT * FROM tblUser username = @username", con)
        cmd.Parameters.AddWithValue("@username", txtUsername.Text)
        cmd.Parameters.AddWithValue("@email", txtEmail.Text)
        cmd.Parameters.AddWithValue("@contactNo", txtContact.Text)
        con.Open()
        rdr = cmd.ExecuteReader()

        If rdr.Read() Then
            MsgBox("Duplicate")
        Else
            MsgBox("You can create new account!")
        End If
        con.Close()
    End Sub


    Private Sub Reg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        roundCorners(Me)
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Dim rdr As SqlDataReader = Nothing
        Dim con As SqlConnection = New SqlConnection(getConnectionString())
        Dim cmd As SqlCommand = New SqlCommand("SELECT username FROM tblUser where username = @username", con)
        cmd.Parameters.AddWithValue("@username", txtUsername.Text)
        con.Open()
        rdr = cmd.ExecuteReader()

        If rdr.Read() Then
            MsgBox("success")
        Else
            MsgBox("failed")
        End If


    End Sub
End Class