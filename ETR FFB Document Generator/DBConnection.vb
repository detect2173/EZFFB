Imports Npgsql
Imports System.Data
Imports System.Configuration

''' <summary>
''' Handles database connections and queries related to the student roster.
''' </summary>
Public Class DBConnection

    ''' <summary>
    ''' Creates and returns a new PostgreSQL database connection.
    ''' </summary>
    ''' <returns>The NpgsqlConnection object.</returns>
    Public Shared Function GetConnection() As NpgsqlConnection
        ' Retrieve environment variables for database credentials
        Dim username As String = Environment.GetEnvironmentVariable("DB_USERNAME")
        Dim password As String = Environment.GetEnvironmentVariable("DB_PASSWORD")

        ' Create the connection string
        Dim connectionString As String = $"Host=localhost;Username={username};Password={password};Database=postgres"

        ' Return a new NpgsqlConnection object
        Return New NpgsqlConnection(connectionString)
    End Function

    ''' <summary>
    ''' Fetches the student roster data from the database.
    ''' </summary>
    ''' <returns>A DataTable containing the student roster data.</returns>
    Public Shared Function FetchRosterData() As DataTable
        ' Initialize and open the connection
        Using conn As NpgsqlConnection = GetConnection()
            conn.Open()

            ' Execute the SQL command to fetch data
            Using cmd As New NpgsqlCommand("SELECT * FROM roster.roster", conn)
                Using reader As NpgsqlDataReader = cmd.ExecuteReader()
                    ' Load the fetched data into a DataTable
                    Dim dataTable As New DataTable()
                    dataTable.Load(reader)
                    Return dataTable
                End Using
            End Using
        End Using
    End Function

End Class
