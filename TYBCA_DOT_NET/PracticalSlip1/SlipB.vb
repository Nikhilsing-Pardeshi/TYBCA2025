Imports System.Data
Imports MySql.Data
Imports MySql.Data.MySqlClient

Public Class SlipB

    Dim con As MySqlConnection
    Dim cmd As MySqlCommand
    Dim connectionString As String = "Server=127.0.0.1;Port=3306;Database=TYBCA2025;Uid=root;Pwd=1234;"
    Dim sqlText = "Select * from Employee"
    Dim adpt As MySqlDataAdapter
    Dim dt As DataTable

    Private Sub SlipB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con = New MySqlConnection(connectionString)
        con.Open()
        cmd = New MySqlCommand(sqlText, con)
        adpt = New MySqlDataAdapter(cmd)
        adpt.Fill(dt)

        DgvEmploeeList.DataSource = dt


    End Sub
End Class