Public Class Settings

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        AddHandler MyBase.Load, AddressOf Settings_Load
        AddHandler btnSaveSettings.Click, AddressOf btnSaveSettings_Click
    End Sub
    Private Sub Settings_Load(sender As Object, e As EventArgs)
        txtCenter.Text = My.Settings.CenterName
        txtPhone.Text = My.Settings.PhoneNumber
    End Sub

    Private Sub btnSaveSettings_Click(sender As Object, e As EventArgs)
        My.Settings.CenterName = txtCenter.Text
        My.Settings.PhoneNumber = txtPhone.Text
        My.Settings.Save()
        Me.Close()
    End Sub

    Private Sub txtPhone_TextChanged(sender As Object, e As EventArgs)
        Dim text As String = txtPhone.Text
        text = text.Replace("(", "").Replace(")", "").Replace("-", "").Replace(" ", "")

        If text.Length >= 10 Then
            text = text.Substring(0, 10)
            txtPhone.Text = String.Format("({0}) {1}-{2}", text.Substring(0, 3), text.Substring(3, 3), text.Substring(6))
            txtPhone.SelectionStart = txtPhone.Text.Length
        End If
    End Sub


End Class