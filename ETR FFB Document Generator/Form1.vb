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


    Private Function OpenFileDialogAndGetPath() As String
        Dim filePath As String = String.Empty
        Dim openFileDialog1 As New OpenFileDialog()

        openFileDialog1.InitialDirectory = "c:\"
        openFileDialog1.Filter = "CSV files (*.csv)|*.csv"
        openFileDialog1.FilterIndex = 2
        openFileDialog1.RestoreDirectory = True

        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            filePath = openFileDialog1.FileName
        End If

        Return filePath
    End Function

    Private Sub Guna2Button9_Click(sender As Object, e As EventArgs) Handles Guna2Button9.Click
        Dim csvFilePath As String = OpenFileDialogAndGetPath()
        If Not String.IsNullOrEmpty(csvFilePath) Then
            ' Call your Python script here and pass in the csvFilePath
        End If
    End Sub
End Class
