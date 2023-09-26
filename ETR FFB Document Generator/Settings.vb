Public Class Settings
    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCenter.Text = My.Settings.CenterName
        txtPhone.Text = My.Settings.PhoneNumber
    End Sub

    Private Sub btnSaveSettings_Click(sender As Object, e As EventArgs) Handles btnSaveSettings.Click
        My.Settings.CenterName = txtCenter.Text
        My.Settings.PhoneNumber = txtPhone.Text
        My.Settings.Save()
        Me.Close()
    End Sub
End Class