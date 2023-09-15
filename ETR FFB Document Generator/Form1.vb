Imports System.Configuration

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EncryptAppSettings()

    End Sub

    Private Sub EncryptAppSettings()
        Dim config As Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
        Dim section As ConfigurationSection = config.GetSection("appSettings")

        If Not section.SectionInformation.IsProtected Then
            section.SectionInformation.ProtectSection("DataProtectionConfigurationProvider")
            config.Save()
        End If
    End Sub
End Class
