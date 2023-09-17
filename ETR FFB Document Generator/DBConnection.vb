Imports Npgsql
Imports System.Data
Imports System.Configuration

Public Class DBConnection

    Public Shared Function GetConnection() As NpgsqlConnection
        Dim username As String = Environment.GetEnvironmentVariable("DB_USERNAME")
        Dim password As String = Environment.GetEnvironmentVariable("DB_PASSWORD")

        Dim connectionString As String = $"Host=localhost;Username={username};Password={password};Database=postgres"

        Return New NpgsqlConnection(connectionString)
    End Function
    'Public Shared Function GetConnection() As NpgsqlConnection
    '    Dim username As String = "postgres"
    '    Dim password As String = "Jbbb2023?"
    '    'Dim connectionString As String = $"Host=localhost;Username={username};Password={password};Database=roster"
    '    Dim connectionString As String = "Host=localhost;Username=postgres;Password=Jbbb2023?;Database=postgres"

    '    Return New NpgsqlConnection(connectionString)
    'End Function

    Public Shared Function FetchRosterData() As DataTable
        Using conn As NpgsqlConnection = GetConnection()
            conn.Open()

            Using cmd As New NpgsqlCommand("SELECT * FROM roster.roster", conn)
                Using reader As NpgsqlDataReader = cmd.ExecuteReader()
                    Dim dataTable As New DataTable()
                    dataTable.Load(reader)
                    Return dataTable
                End Using
            End Using
        End Using
    End Function

End Class
