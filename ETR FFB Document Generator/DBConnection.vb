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
            Dim connectionString As String = $"Server=localhost;Database=roster;User ID=root;Password=;"
            Return New MySqlConnection(connectionString)
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
            Return Nothing
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
        Form1.lblOBS.Text = CStr(Form1.dgvRoster.Rows.Count)
        Form1.txtCount.Text = CStr(Form1.dgvRoster.Rows.Count)
    End Sub


    'Public Shared Sub PopulateDgvContacts(ByRef dgvContacts As DataGridView)
    '    Dim connString As String = "Server=localhost;Database=roster;User ID=root;Password=;"
    '    Dim query As String = "SELECT * FROM contacts"
    '    Dim conn As New MySqlConnection(connString)
    '    Dim cmd As New MySqlCommand(query, conn)
    '    Dim adapter As New MySqlDataAdapter(cmd)
    '    Dim dt As New DataTable()

    '    Try
    '        conn.Open()
    '        Console.WriteLine("Connected to database.")
    '        adapter.Fill(dt)

    '        If dt.Rows.Count > 0 Then
    '            Console.WriteLine("Data found. Populating DataGridView.")
    '            dgvContacts.DataSource = dt
    '        Else
    '            Console.WriteLine("No data found.")
    '        End If

    '    Catch ex As Exception
    '        MessageBox.Show("An error occurred: " + ex.Message)
    '    Finally
    '        conn.Close()
    '    End Try
    'End Sub


End Class
