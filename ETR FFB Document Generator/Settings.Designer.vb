<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        txtCenter = New Guna.UI2.WinForms.Guna2TextBox()
        txtPhone = New Guna.UI2.WinForms.Guna2TextBox()
        Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        btnSaveSettings = New Guna.UI2.WinForms.Guna2Button()
        Label1 = New Label()
        Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(components)
        SuspendLayout()
        ' 
        ' txtCenter
        ' 
        txtCenter.CustomizableEdges = CustomizableEdges1
        txtCenter.DefaultText = ""
        txtCenter.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtCenter.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtCenter.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtCenter.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtCenter.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtCenter.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txtCenter.ForeColor = Color.FromArgb(CByte(88), CByte(0), CByte(5))
        txtCenter.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtCenter.Location = New Point(92, 42)
        txtCenter.Margin = New Padding(4, 4, 4, 4)
        txtCenter.Name = "txtCenter"
        txtCenter.PasswordChar = ChrW(0)
        txtCenter.PlaceholderText = "i.e. Northlands Job Corps Center"
        txtCenter.SelectedText = ""
        txtCenter.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        txtCenter.Size = New Size(375, 36)
        txtCenter.TabIndex = 0
        ' 
        ' txtPhone
        ' 
        txtPhone.CustomizableEdges = CustomizableEdges3
        txtPhone.DefaultText = ""
        txtPhone.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtPhone.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtPhone.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtPhone.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtPhone.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtPhone.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txtPhone.ForeColor = Color.FromArgb(CByte(88), CByte(0), CByte(5))
        txtPhone.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtPhone.Location = New Point(92, 121)
        txtPhone.Margin = New Padding(4, 4, 4, 4)
        txtPhone.Name = "txtPhone"
        txtPhone.PasswordChar = ChrW(0)
        txtPhone.PlaceholderText = "Enter a 10 Digit Phone Number"
        txtPhone.SelectedText = ""
        txtPhone.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        txtPhone.Size = New Size(375, 36)
        txtPhone.TabIndex = 1
        ' 
        ' Guna2HtmlLabel1
        ' 
        Guna2HtmlLabel1.BackColor = Color.Transparent
        Guna2HtmlLabel1.ForeColor = Color.White
        Guna2HtmlLabel1.Location = New Point(112, 18)
        Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Guna2HtmlLabel1.Size = New Size(76, 17)
        Guna2HtmlLabel1.TabIndex = 2
        Guna2HtmlLabel1.Text = "Center Name:"' 
        ' Guna2HtmlLabel2
        ' 
        Guna2HtmlLabel2.BackColor = Color.Transparent
        Guna2HtmlLabel2.ForeColor = Color.White
        Guna2HtmlLabel2.Location = New Point(112, 97)
        Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Guna2HtmlLabel2.Size = New Size(81, 17)
        Guna2HtmlLabel2.TabIndex = 3
        Guna2HtmlLabel2.Text = "SHRO Phone#:"' 
        ' btnSaveSettings
        ' 
        btnSaveSettings.AutoRoundedCorners = True
        btnSaveSettings.BorderRadius = 17
        btnSaveSettings.CustomizableEdges = CustomizableEdges5
        btnSaveSettings.DisabledState.BorderColor = Color.DarkGray
        btnSaveSettings.DisabledState.CustomBorderColor = Color.DarkGray
        btnSaveSettings.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnSaveSettings.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnSaveSettings.FillColor = Color.White
        btnSaveSettings.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        btnSaveSettings.ForeColor = Color.Black
        btnSaveSettings.HoverState.FillColor = Color.Gray
        btnSaveSettings.HoverState.ForeColor = Color.White
        btnSaveSettings.Location = New Point(219, 172)
        btnSaveSettings.Name = "btnSaveSettings"
        btnSaveSettings.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        btnSaveSettings.Size = New Size(121, 36)
        btnSaveSettings.TabIndex = 4
        btnSaveSettings.Text = "Save Settings"' 
        ' Label1
        ' 
        Label1.BackColor = Color.Black
        Label1.Font = New Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.Snow
        Label1.Location = New Point(29, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(18, 174)
        Label1.TabIndex = 5
        Label1.Text = "SETTINGS"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Guna2BorderlessForm1
        ' 
        Guna2BorderlessForm1.AnimateWindow = True
        Guna2BorderlessForm1.AnimationType = Guna.UI2.WinForms.Guna2BorderlessForm.AnimateWindowType.AW_CENTER
        Guna2BorderlessForm1.ContainerControl = Me
        Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Guna2BorderlessForm1.TransparentWhileDrag = True
        ' 
        ' Settings
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        ClientSize = New Size(506, 226)
        Controls.Add(Label1)
        Controls.Add(btnSaveSettings)
        Controls.Add(Guna2HtmlLabel2)
        Controls.Add(Guna2HtmlLabel1)
        Controls.Add(txtPhone)
        Controls.Add(txtCenter)
        Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Settings"
        Padding = New Padding(5)
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "Settings"
        TopMost = True
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtCenter As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtPhone As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnSaveSettings As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
End Class
