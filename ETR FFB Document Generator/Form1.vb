﻿
Imports System.Data
Imports System.Configuration
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports System.IO



Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CopyLogToDocuments()
        ' Populate and set up DataGrid
        DBConnection.PopulateAndRefreshRoster(dgvRoster)
        dgvRoster.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.DarkGray
    End Sub

    Private Sub Guna2Button8_Click(sender As Object, e As EventArgs) Handles Guna2Button8.Click
        Dim logFilePath As String = System.IO.Path.Combine(Application.StartupPath, "roster_updater.log")
        System.Diagnostics.Process.Start("explorer.exe", "/select," & logFilePath)
    End Sub

    Public Sub CopyLogToDocuments()
        Dim sourcePath As String = Path.Combine(Application.StartupPath, "roster_updater.log")
        Dim destPath As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "roster_updater.log")

        If File.Exists(sourcePath) Then
            File.Copy(sourcePath, destPath, True)
        End If
    End Sub
End Class
