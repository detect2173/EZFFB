Imports Npgsql
Imports System.Configuration

Public Class DBConnection

    Public Shared Function GetConnection() As NpgsqlConnection
        Dim username As String = ConfigurationManager.AppSettings("DbUsername")
        Dim password As String = ConfigurationManager.AppSettings("DbPassword")
        Dim connectionString As String = $"Host=localhost;Username={username};Password={password};Database=roster"

        Return New NpgsqlConnection(connectionString)
    End Function

End Class
