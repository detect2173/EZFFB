Module SetupLogic
    Public Sub SetupUI()
        ' Setup cmbTrade
        Form1.cmbTrade.Items.Clear()
        For Each item In Student.TradeOptions.Keys
            Form1.cmbTrade.Items.Add(item)
        Next

        ' Setup cmbSize
        Form1.cmbSize.Items.Clear()
        For Each item In Student.SizeOptions.Keys
            Form1.cmbSize.Items.Add(item)
        Next

        ' Setup cmbIncentive
        Form1.cmbIncentive.Items.Clear()
        For Each item In Student.IncentiveOptions.Keys
            Form1.cmbIncentive.Items.Add(item)
        Next
    End Sub
End Module
