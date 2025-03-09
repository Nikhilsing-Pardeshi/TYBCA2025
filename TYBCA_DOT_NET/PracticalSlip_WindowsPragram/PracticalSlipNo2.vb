Public Class PracticalSlipNo2
    Dim x, y As Int16
    Dim isForword As Boolean

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If x >= Me.Width Then
            isForword = False
        End If

        If x <= 0 Then
            isForword = True
        End If

        If isForword Then
            x += 10
        Else
            x -= 10
        End If

        lblText.Location = New Point(x, y)
    End Sub

    Private Sub PracticalSlipNo2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        x = 0
        y = 100
        lblText.Location = New Point(x, y)
        Timer1.Enabled = True
        isForword = True
    End Sub

End Class
