'Imports System.Configuration

'''' <summary>
'''' Utility class for handling encryption-related tasks.
'''' </summary>
'Public Class EncryptionUtility

'    ''' <summary>
'    ''' Encrypts the appSettings section in the app.config file.
'    ''' </summary>
'    Public Shared Sub EncryptAppSettings()
'        Try
'            Dim config As Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
'            Dim section As ConfigurationSection = config.GetSection("appSettings")

'            If section Is Nothing Then
'                Return
'            End If

'            If Not section.SectionInformation.IsProtected Then
'                section.SectionInformation.ProtectSection("DataProtectionConfigurationProvider")
'                config.Save()
'            End If
'        Catch ex As Exception
'            MessageBox.Show("An error occurred: " & ex.Message)
'        End Try
'    End Sub
'End Class
