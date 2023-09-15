Imports Npgsql
Imports System.Data
Imports System.Configuration

Public Class DBConnection

    Public Shared Function GetConnection() As NpgsqlConnection
        Dim username As String = Environment.GetEnvironmentVariable("DB_USERNAME")
        Dim password As String = Environment.GetEnvironmentVariable("DB_PASSWORD")
        Dim connectionString As String = $"Host=localhost;Username={username};Password={password};Database=roster"

        Return New NpgsqlConnection(connectionString)
    End Function

    Public Function FetchRosterData() As DataTable
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
