
Imports System.Data
Imports System.Configuration
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel


Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Populate and set up DataGrid
        DBConnection.PopulateAndRefreshRoster(dgvRoster)
        dgvRoster.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.DarkGray
    End Sub
End Class
