Imports MySql.Data.MySqlClient
Imports System.Data
Imports System.Configuration

''' <summary>
''' Handles database connections and queries related to the student roster.
''' </summary>
Public Class DBConnection

    ''' <summary>
    ''' Creates and returns a new MySQL database connection.
    ''' </summary>
    ''' <returns>The MySqlConnection object.</returns>
    Public Shared Function GetConnection() As MySqlConnection
        Try
            ' Your DB Connection and population logic here
            ' Create the connection string
            Dim connectionString As String = $"Server=localhost;Database=roster;User ID=root;Password=;"
            ' Return a new MySqlConnection object
            Return New MySqlConnection(connectionString)
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try



    End Function

    ''' <summary>
    ''' Fetches the student roster data from the database.
    ''' </summary>
    ''' <returns>A DataTable containing the student roster data.</returns>
    Public Shared Function FetchRosterData() As DataTable
        ' Initialize and open the connection
        Using conn As MySqlConnection = GetConnection()
            conn.Open()

            ' Execute the SQL command to fetch data
            Using cmd As New MySqlCommand("SELECT * FROM roster.roster", conn)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    ' Load the fetched data into a DataTable
                    Dim dataTable As New DataTable()
                    dataTable.Load(reader)
                    Return dataTable
                End Using
            End Using
        End Using
    End Function
    Public Shared Sub PopulateAndRefreshRoster(ByRef dgv As DataGridView)
        ' Fetch data from the database into a DataTable
        Dim rosterData As DataTable = FetchRosterData()

        ' Bind the DataGridView to the DataTable
        dgv.DataSource = rosterData
        Form1.lblOBS.Text = Form1.dgvRoster.Rows.Count
        Form1.txtCount.Text = Form1.dgvRoster.Rows.Count
    End Sub
End Class
