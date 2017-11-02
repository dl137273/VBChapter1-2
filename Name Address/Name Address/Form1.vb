Public Class Form1

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub lblName_Click(sender As Object, e As EventArgs) Handles lblName.Click

    End Sub

    Private Sub lblStreet_Click(sender As Object, e As EventArgs) Handles lblStreet.Click

    End Sub

    Private Sub lblCityStateZip_Click(sender As Object, e As EventArgs) Handles lblCityStateZip.Click

    End Sub

    Private Sub btnShowInfo_Click(sender As Object, e As EventArgs) Handles btnShowInfo.Click
        lblName.Visible = True
        lblStreet.Visible = True
        lblCityStateZip.Visible = True
    End Sub
End Class
