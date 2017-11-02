Public Class MathTutor

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnShowAnswer_Click(sender As Object, e As EventArgs) Handles btnShowAnswer.Click
        lblAnswer.Visible = True
        lblAnswer.Text = "18 + 64 = 82"
    End Sub
End Class
