Imports Npgsql
Imports System.Data
Imports System.Configuration
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs)
        ' Encrypt appSettings
        EncryptionUtility.EncryptAppSettings()

        ' Fetch roster data and set up DataGrid
        dgvRoster.DataSource = DBConnection.FetchRosterData()
        dgvRoster.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.DarkGray
    End Sub
End Class
