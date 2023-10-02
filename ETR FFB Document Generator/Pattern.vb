Imports Guna.UI2.WinForms

Public Class Pattern
    Public Shared pattern As Boolean = False
    Public Shared labelValues As New List(Of String)
    Public Shared dateValues As New List(Of DateTime) ' Clear existing values
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        AddHandler tglNIR1.CheckedChanged, AddressOf tglNIR1_CheckedChanged
        AddHandler tglNIR2.CheckedChanged, AddressOf tglNIR2_CheckedChanged
        AddHandler tglNIR3.CheckedChanged, AddressOf tglNIR3_CheckedChanged
        AddHandler tglNIR4.CheckedChanged, AddressOf tglNIR4_CheckedChanged
        AddHandler tglNIR5.CheckedChanged, AddressOf tglNIR5_CheckedChanged
        AddHandler pbExit.Click, AddressOf pbExit_Click
        AddHandler btnStoreValues.Click, AddressOf btnStoreValues_Click
    End Sub
    Private Sub UpdateLabelsBasedOnToggle()
        Dim toggleSwitches As Guna2ToggleSwitch() = {tglNIR1, tglNIR2, tglNIR3, tglNIR4, tglNIR5}
        Dim labels As Label() = {lblNIR1, lblNIR2, lblNIR3, lblNIR4, lblNIR5}

        For i As Integer = 0 To toggleSwitches.Length - 1
            If toggleSwitches(i).Checked Then
                labels(i).Text = "Failure to follow center rules impacting the rights or ability of others to benefit from the program."
            Else
                labels(i).Text = "Failure to follow center rules impacting the individual’s participation or progress in the program."
            End If
        Next
    End Sub

    Private Sub tglNIR1_CheckedChanged(sender As Object, e As EventArgs)
        UpdateLabelsBasedOnToggle()
    End Sub

    Private Sub tglNIR2_CheckedChanged(sender As Object, e As EventArgs)
        UpdateLabelsBasedOnToggle()
    End Sub

    Private Sub tglNIR3_CheckedChanged(sender As Object, e As EventArgs)
        UpdateLabelsBasedOnToggle()
    End Sub

    Private Sub tglNIR4_CheckedChanged(sender As Object, e As EventArgs)
        UpdateLabelsBasedOnToggle()
    End Sub

    Private Sub tglNIR5_CheckedChanged(sender As Object, e As EventArgs)
        UpdateLabelsBasedOnToggle()
    End Sub

    Private Sub pbExit_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub btnStoreValues_Click(sender As Object, e As EventArgs)
        labelValues.Clear()
        dateValues.Clear()

        ' Array of labels and Guna2DateTimePickers
        Dim labels As Label() = {lblNIR1, lblNIR2, lblNIR3, lblNIR4, lblNIR5}
        Dim datePickers As Guna2DateTimePicker() = {dtpNIR1, dtpNIR2, dtpNIR3, dtpNIR4, dtpNIR5}

        ' Store the label and date values
        For i As Integer = 0 To labels.Length - 1
            labelValues.Add(labels(i).Text)
            dateValues.Add(datePickers(i).Value)
        Next
        pattern = True
        Me.Close()
        ' Now labelValues and dateValues contain the information for later use
    End Sub
    Public Shared Function GetLabelValues() As List(Of String)
        Return labelValues
    End Function

    Public Shared Function GetDateValues() As List(Of DateTime)
        Return dateValues
    End Function

End Class