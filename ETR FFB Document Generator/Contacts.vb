Public Class Contacts
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        AddHandler MyBase.Load, AddressOf Contacts_Load
        AddHandler Guna2PictureBox1.Click, AddressOf Guna2PictureBox1_Click
        AddHandler Guna2Button1.Click, AddressOf Guna2Button1_Click
        AddHandler Guna2Button2.Click, AddressOf Guna2Button2_Click
        AddHandler Guna2Button3.Click, AddressOf Guna2Button3_Click
        AddHandler Guna2Button4.Click, AddressOf Guna2Button4_Click
        AddHandler Guna2Button5.Click, AddressOf Guna2Button5_Click
        AddHandler Guna2Button6.Click, AddressOf Guna2Button6_Click
        AddHandler Guna2Button7.Click, AddressOf Guna2Button7_Click
        AddHandler Guna2Button8.Click, AddressOf Guna2Button8_Click
        AddHandler Guna2Button9.Click, AddressOf Guna2Button9_Click
        AddHandler Guna2Button10.Click, AddressOf Guna2Button10_Click
        AddHandler Guna2Button11.Click, AddressOf Guna2Button11_Click
        AddHandler Guna2Button12.Click, AddressOf Guna2Button12_Click
    End Sub


    Private Sub Contacts_Load(sender As Object, e As EventArgs)
        'DBConnection.PopulateDgvContacts(Me.dgvContacts)

    End Sub

    Private Sub Guna2PictureBox1_Click(sender As Object, e As EventArgs)
        Me.Close()

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs)
        DBFunctions.PopulateContactInfoByCenter("Northlands", lblCenter, txtSHRO, txtSHROeMail, txtC2C, txtSHROphone)
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs)
        DBFunctions.PopulateContactInfoByCenter("Excelsior Springs", lblCenter, txtSHRO, txtSHROeMail, txtC2C, txtSHROphone)
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs)
        DBFunctions.PopulateContactInfoByCenter("Hubert H. Humphrey", lblCenter, txtSHRO, txtSHROeMail, txtC2C, txtSHROphone)
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs)
        DBFunctions.PopulateContactInfoByCenter("Iroquois", lblCenter, txtSHRO, txtSHROeMail, txtC2C, txtSHROphone)
    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs)
        DBFunctions.PopulateContactInfoByCenter("Oneonta", lblCenter, txtSHRO, txtSHROeMail, txtC2C, txtSHROphone)
    End Sub

    Private Sub Guna2Button6_Click(sender As Object, e As EventArgs)
        DBFunctions.PopulateContactInfoByCenter("Westover", lblCenter, txtSHRO, txtSHROeMail, txtC2C, txtSHROphone)
    End Sub

    Private Sub Guna2Button7_Click(sender As Object, e As EventArgs)
        DBFunctions.PopulateContactInfoByCenter("Wilmington", lblCenter, txtSHRO, txtSHROeMail, txtC2C, txtSHROphone)
    End Sub

    Private Sub Guna2Button8_Click(sender As Object, e As EventArgs)
        DBFunctions.PopulateContactInfoByCenter("Benjamin L. Hooks", lblCenter, txtSHRO, txtSHROeMail, txtC2C, txtSHROphone)
    End Sub

    Private Sub Guna2Button9_Click(sender As Object, e As EventArgs)
        DBFunctions.PopulateContactInfoByCenter("Montgomery", lblCenter, txtSHRO, txtSHROeMail, txtC2C, txtSHROphone)
    End Sub

    Private Sub Guna2Button10_Click(sender As Object, e As EventArgs)
        DBFunctions.PopulateContactInfoByCenter("ETR Rochester", lblCenter, txtSHRO, txtSHROeMail, txtC2C, txtSHROphone)
    End Sub

    Private Sub Guna2Button11_Click(sender As Object, e As EventArgs)
        DBFunctions.UpdateContactInfo(lblCenter.Text, txtSHRO, txtSHROeMail, txtC2C, txtSHROphone)
        resetControls()
    End Sub

    Private Sub Guna2Button12_Click(sender As Object, e As EventArgs)
        resetControls()
    End Sub

    Public Sub resetControls()
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is Guna.UI2.WinForms.Guna2TextBox Then
                CType(ctrl, Guna.UI2.WinForms.Guna2TextBox).Text = String.Empty
            End If
        Next
        lblCenter.Text = String.Empty
    End Sub
End Class