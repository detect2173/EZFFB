
Imports System.Data
Imports System.Configuration
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports System.IO



Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CopyLogToDocuments()
        SetupLogic.SetupUI()
        ' Populate and set up DataGrid
        DBConnection.PopulateAndRefreshRoster(dgvRoster)
        dgvRoster.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.DarkGray
    End Sub

    Private Sub Guna2Button8_Click(sender As Object, e As EventArgs) Handles Guna2Button8.Click
        Dim logFilePath As String = System.IO.Path.Combine(Application.StartupPath, "roster_updater.log")
        System.Diagnostics.Process.Start(New System.Diagnostics.ProcessStartInfo() With {
    .FileName = logFilePath,
    .UseShellExecute = True
})
    End Sub

    Public Sub CopyLogToDocuments()
        Dim sourcePath As String = Path.Combine(Application.StartupPath, "roster_updater.log")
        Dim destPath As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "roster_updater.log")

        If File.Exists(sourcePath) Then
            File.Copy(sourcePath, destPath, True)
        End If
    End Sub

    Private Sub btnUpdateDB_Click(sender As Object, e As EventArgs) Handles btnUpdateDB.Click
        Dim startupPath As String = Application.StartupPath
        Dim exePath As String = Path.Combine(startupPath, "roster_updater.exe")

        If File.Exists(exePath) Then
            Process.Start(exePath)
        Else
            MessageBox.Show("roster_updater.exe not found.")
        End If
    End Sub

    Private Sub btnReload_Click(sender As Object, e As EventArgs) Handles btnReload.Click
        DBConnection.PopulateAndRefreshRoster(dgvRoster)
    End Sub

    Private Sub dgvRoster_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRoster.CellClick
        ' Check if there are no selected rows or if the clicked cell is a header or an empty row
        If dgvRoster.SelectedRows.Count = 0 OrElse e.RowIndex < 0 OrElse e.RowIndex >= dgvRoster.Rows.Count - 1 Then
            Return
        End If

        Try
            txtID.Text = dgvRoster.SelectedRows(0).Cells(0).Value.ToString()
            txtFName.Text = dgvRoster.SelectedRows(0).Cells(1).Value.ToString()
            txtLName.Text = dgvRoster.SelectedRows(0).Cells(2).Value.ToString()
            dtpDOB.Value = Convert.ToDateTime(dgvRoster.SelectedRows(0).Cells(3).Value)
            dtpDOE.Value = Convert.ToDateTime(dgvRoster.SelectedRows(0).Cells(4).Value)
            txtEMail.Text = dgvRoster.SelectedRows(0).Cells(5).Value.ToString()
            cmbSize.Text = dgvRoster.SelectedRows(0).Cells(6).Value.ToString()
            cmbTrade.Text = dgvRoster.SelectedRows(0).Cells(7).Value.ToString()
            cmbIncentive.Text = dgvRoster.SelectedRows(0).Cells(8).Value.ToString()
            txtID.ReadOnly = True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ResetControls()
        txtID.Text = String.Empty
        txtFName.Text = String.Empty
        txtLName.Text = String.Empty
        dtpDOB.Value = DateTime.Now
        dtpDOE.Value = DateTime.Now
        txtEMail.Text = String.Empty

        cmbTrade.SelectedIndex = -1
        cmbSize.SelectedIndex = -1
        cmbIncentive.SelectedIndex = -1

        txtID.ReadOnly = False
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ResetControls()
    End Sub

    Private Sub cmbSearch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSearch.SelectedIndexChanged
        ' Replace with your function to load the data into dgvRoster
        DBConnection.PopulateAndRefreshRoster(dgvRoster)

        Try
            Dim rosterDataTable As DataTable = CType(dgvRoster.DataSource, DataTable)

            Dim comparisonDate As DateTime = DateTime.Today.AddYears(-18)

            Dim filteredRows As EnumerableRowCollection(Of DataRow)

            If cmbSearch.SelectedItem = "Adults" Then
                filteredRows = rosterDataTable.AsEnumerable().Where(Function(row)
                                                                        Dim dob As DateTime
                                                                        DateTime.TryParse(row("DOB").ToString(), dob)
                                                                        Return dob <= comparisonDate
                                                                    End Function)
            ElseIf cmbSearch.SelectedItem = "Minors" Then
                filteredRows = rosterDataTable.AsEnumerable().Where(Function(row)
                                                                        Dim dob As DateTime
                                                                        DateTime.TryParse(row("DOB").ToString(), dob)
                                                                        Return dob > comparisonDate
                                                                    End Function)
            Else
                filteredRows = rosterDataTable.AsEnumerable()
            End If

            Dim filteredDataTable As DataTable = filteredRows.CopyToDataTable()

            dgvRoster.DataSource = filteredDataTable
            ' Replace with your function to update the row count label, if applicable
            lblCount.Text = dgvRoster.Rows.Count

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
