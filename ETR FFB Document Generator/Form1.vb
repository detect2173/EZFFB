Imports Npgsql
Imports System.Data
Imports System.Configuration

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dbConn As New DBConnection()
        dgvRoster.DataSource = dbConn.FetchRosterData()

    End Sub


    'Private Sub EncryptAppSettings()
    '    Try
    '        Dim config As Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
    '        Dim section As ConfigurationSection = config.GetSection("appSettings")

    '        If section Is Nothing Then
    '            MessageBox.Show("appSettings section not found.")
    '            Return
    '        End If

    '        If Not section.SectionInformation.IsProtected Then
    '            MessageBox.Show("Encrypting appSettings.")
    '            section.SectionInformation.ProtectSection("DataProtectionConfigurationProvider")
    '            config.Save()
    '        Else
    '            MessageBox.Show("appSettings already encrypted.")
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show("An error occurred: " & ex.Message)
    '    End Try
    'End Sub


End Class
