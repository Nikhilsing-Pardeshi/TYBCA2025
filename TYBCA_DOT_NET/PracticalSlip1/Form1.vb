Public Class Form1
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Dim n As Integer
        n = Convert.ToInt32(txtNumber.Text)
        txtNumber.Text = n + 1
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNumber.Text = 1
    End Sub
End Class
