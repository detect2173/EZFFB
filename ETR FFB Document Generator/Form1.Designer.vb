<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        tc1 = New Guna.UI2.WinForms.Guna2TabControl()
        TabPage1 = New TabPage()
        Guna2Separator4 = New Guna.UI2.WinForms.Guna2Separator()
        Guna2Separator5 = New Guna.UI2.WinForms.Guna2Separator()
        Guna2Separator6 = New Guna.UI2.WinForms.Guna2Separator()
        Guna2Separator3 = New Guna.UI2.WinForms.Guna2Separator()
        Guna2Separator2 = New Guna.UI2.WinForms.Guna2Separator()
        Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        TabPage2 = New TabPage()
        TabPage3 = New TabPage()
        dgvRoster = New Guna.UI2.WinForms.Guna2DataGridView()
        tc1.SuspendLayout()
        TabPage1.SuspendLayout()
        CType(Guna2PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        TabPage3.SuspendLayout()
        CType(dgvRoster, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' tc1
        ' 
        tc1.Alignment = TabAlignment.Left
        tc1.Controls.Add(TabPage1)
        tc1.Controls.Add(TabPage2)
        tc1.Controls.Add(TabPage3)
        tc1.Dock = DockStyle.Fill
        tc1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        tc1.ItemSize = New Size(180, 40)
        tc1.Location = New Point(0, 0)
        tc1.Name = "tc1"
        tc1.SelectedIndex = 0
        tc1.Size = New Size(1029, 630)
        tc1.TabButtonHoverState.BorderColor = Color.Empty
        tc1.TabButtonHoverState.FillColor = Color.FromArgb(CByte(40), CByte(52), CByte(70))
        tc1.TabButtonHoverState.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point)
        tc1.TabButtonHoverState.ForeColor = Color.White
        tc1.TabButtonHoverState.InnerColor = Color.FromArgb(CByte(40), CByte(52), CByte(70))
        tc1.TabButtonIdleState.BorderColor = Color.Empty
        tc1.TabButtonIdleState.FillColor = Color.FromArgb(CByte(102), CByte(6), CByte(8))
        tc1.TabButtonIdleState.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point)
        tc1.TabButtonIdleState.ForeColor = Color.Gray
        tc1.TabButtonIdleState.InnerColor = Color.FromArgb(CByte(33), CByte(42), CByte(57))
        tc1.TabButtonSelectedState.BorderColor = Color.Empty
        tc1.TabButtonSelectedState.FillColor = Color.Black
        tc1.TabButtonSelectedState.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point)
        tc1.TabButtonSelectedState.ForeColor = Color.OldLace
        tc1.TabButtonSelectedState.InnerColor = Color.Silver
        tc1.TabButtonSize = New Size(180, 40)
        tc1.TabIndex = 0
        tc1.TabMenuBackColor = Color.FromArgb(CByte(102), CByte(6), CByte(8))
        ' 
        ' TabPage1
        ' 
        TabPage1.BackColor = Color.Black
        TabPage1.Controls.Add(Guna2Separator4)
        TabPage1.Controls.Add(Guna2Separator5)
        TabPage1.Controls.Add(Guna2Separator6)
        TabPage1.Controls.Add(Guna2Separator3)
        TabPage1.Controls.Add(Guna2Separator2)
        TabPage1.Controls.Add(Guna2Separator1)
        TabPage1.Controls.Add(Guna2PictureBox1)
        TabPage1.Location = New Point(184, 4)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(841, 622)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Home"
        ' 
        ' Guna2Separator4
        ' 
        Guna2Separator4.FillThickness = 4
        Guna2Separator4.Location = New Point(533, 77)
        Guna2Separator4.Name = "Guna2Separator4"
        Guna2Separator4.Size = New Size(140, 10)
        Guna2Separator4.TabIndex = 6
        ' 
        ' Guna2Separator5
        ' 
        Guna2Separator5.FillThickness = 4
        Guna2Separator5.Location = New Point(533, 61)
        Guna2Separator5.Name = "Guna2Separator5"
        Guna2Separator5.Size = New Size(170, 10)
        Guna2Separator5.TabIndex = 5
        ' 
        ' Guna2Separator6
        ' 
        Guna2Separator6.FillThickness = 4
        Guna2Separator6.Location = New Point(532, 45)
        Guna2Separator6.Name = "Guna2Separator6"
        Guna2Separator6.Size = New Size(200, 10)
        Guna2Separator6.TabIndex = 4
        ' 
        ' Guna2Separator3
        ' 
        Guna2Separator3.FillThickness = 4
        Guna2Separator3.Location = New Point(171, 77)
        Guna2Separator3.Name = "Guna2Separator3"
        Guna2Separator3.Size = New Size(140, 10)
        Guna2Separator3.TabIndex = 3
        ' 
        ' Guna2Separator2
        ' 
        Guna2Separator2.FillThickness = 4
        Guna2Separator2.Location = New Point(140, 61)
        Guna2Separator2.Name = "Guna2Separator2"
        Guna2Separator2.Size = New Size(170, 10)
        Guna2Separator2.TabIndex = 2
        ' 
        ' Guna2Separator1
        ' 
        Guna2Separator1.FillThickness = 4
        Guna2Separator1.Location = New Point(111, 45)
        Guna2Separator1.Name = "Guna2Separator1"
        Guna2Separator1.Size = New Size(200, 10)
        Guna2Separator1.TabIndex = 1
        ' 
        ' Guna2PictureBox1
        ' 
        Guna2PictureBox1.CustomizableEdges = CustomizableEdges1
        Guna2PictureBox1.Image = My.Resources.Resources.ETR_Logo_2023
        Guna2PictureBox1.ImageRotate = 0F
        Guna2PictureBox1.Location = New Point(331, 8)
        Guna2PictureBox1.Name = "Guna2PictureBox1"
        Guna2PictureBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2PictureBox1.Size = New Size(181, 94)
        Guna2PictureBox1.TabIndex = 0
        Guna2PictureBox1.TabStop = False
        ' 
        ' TabPage2
        ' 
        TabPage2.BackColor = Color.OldLace
        TabPage2.Location = New Point(184, 4)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(841, 622)
        TabPage2.TabIndex = 1
        TabPage2.Text = "FFB DOCS"
        ' 
        ' TabPage3
        ' 
        TabPage3.BackColor = Color.White
        TabPage3.Controls.Add(dgvRoster)
        TabPage3.Location = New Point(184, 4)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3)
        TabPage3.Size = New Size(841, 622)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Student Roster"
        ' 
        ' dgvRoster
        ' 
        dgvRoster.AllowUserToAddRows = False
        dgvRoster.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = Color.White
        dgvRoster.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        dgvRoster.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgvRoster.BackgroundColor = Color.OldLace
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgvRoster.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgvRoster.ColumnHeadersHeight = 25
        dgvRoster.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        dgvRoster.DefaultCellStyle = DataGridViewCellStyle3
        dgvRoster.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgvRoster.Location = New Point(0, 368)
        dgvRoster.Name = "dgvRoster"
        dgvRoster.ReadOnly = True
        dgvRoster.RowHeadersVisible = False
        dgvRoster.RowTemplate.Height = 25
        dgvRoster.Size = New Size(841, 254)
        dgvRoster.TabIndex = 0
        dgvRoster.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        dgvRoster.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        dgvRoster.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        dgvRoster.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        dgvRoster.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        dgvRoster.ThemeStyle.BackColor = Color.OldLace
        dgvRoster.ThemeStyle.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgvRoster.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        dgvRoster.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        dgvRoster.ThemeStyle.HeaderStyle.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        dgvRoster.ThemeStyle.HeaderStyle.ForeColor = Color.White
        dgvRoster.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        dgvRoster.ThemeStyle.HeaderStyle.Height = 25
        dgvRoster.ThemeStyle.ReadOnly = True
        dgvRoster.ThemeStyle.RowsStyle.BackColor = Color.White
        dgvRoster.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvRoster.ThemeStyle.RowsStyle.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        dgvRoster.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        dgvRoster.ThemeStyle.RowsStyle.Height = 25
        dgvRoster.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgvRoster.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(9F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1029, 630)
        Controls.Add(tc1)
        Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        FormBorderStyle = FormBorderStyle.Fixed3D
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Margin = New Padding(4)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Fact Finding Board Document Generator"
        tc1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        CType(Guna2PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        TabPage3.ResumeLayout(False)
        CType(dgvRoster, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents tc1 As Guna.UI2.WinForms.Guna2TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents dgvRoster As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2Separator4 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Guna2Separator5 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Guna2Separator6 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Guna2Separator3 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Guna2Separator2 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
End Class
