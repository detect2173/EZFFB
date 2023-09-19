Imports Npgsql
Imports System.Data
Imports System.Configuration
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports Python.Runtime

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs)
        ' Initialize Python Engine here
        Environment.SetEnvironmentVariable("PYTHONNET_PYDLL", "C:\Python311\python311.dll", EnvironmentVariableTarget.Process)
        PythonEngine.Initialize()


        ' Encrypt appSettings
        EncryptionUtility.EncryptAppSettings()

        ' Fetch roster data and set up DataGrid
        dgvRoster.DataSource = DBConnection.FetchRosterData()
        dgvRoster.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.DarkGray

    End Sub

    ' This function displays an OpenFileDialog to allow the user to select a CSV file.
    ' It returns the path of the selected file, or an empty string if no file is selected.
    Private Function OpenFileDialogAndGetPath() As String
        Dim filePath As String = String.Empty  ' Initialize the file path to an empty string
        Dim openFileDialog1 As New OpenFileDialog()  ' Create a new OpenFileDialog instance

        ' Set initial settings for the OpenFileDialog
        openFileDialog1.InitialDirectory = "c:\"  ' Start directory
        openFileDialog1.Filter = "CSV files (*.csv)|*.csv"  ' File types to display
        openFileDialog1.FilterIndex = 2  ' Default filter index
        openFileDialog1.RestoreDirectory = True  ' Restore the directory after dialog closes

        ' Show the OpenFileDialog and check if the user clicked "OK"
        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            filePath = openFileDialog1.FileName  ' Get the selected file path
        End If

        Return filePath  ' Return the selected file path (or empty string if canceled)
    End Function

    ' This event is triggered when the btnUpdateDB is clicked.
    ' It calls the OpenFileDialogAndGetPath function to get the CSV file path.
    ' If a valid path is returned, it initializes the Python engine and calls the Python function
    ' to process the CSV file.
    Private Sub btnUpdateDB_Click(sender As Object, e As EventArgs) Handles btnUpdateDB.Click
        Dim csvFilePath As String = OpenFileDialogAndGetPath()
        If Not String.IsNullOrEmpty(csvFilePath) Then
            ' Run your Python function

            PythonEngine.RunString("import csv_sync")
            PythonEngine.RunString($"csv_sync.process_csv_file('{csvFilePath}')")
        End If
    End Sub



End Class
