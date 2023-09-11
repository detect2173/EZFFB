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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        tc1 = New Guna.UI2.WinForms.Guna2TabControl()
        TabPage1 = New TabPage()
        TabPage2 = New TabPage()
        TabPage3 = New TabPage()
        tc1.SuspendLayout()
        SuspendLayout()
        ' 
        ' tc1
        ' 
        tc1.Alignment = TabAlignment.Left
        tc1.Controls.Add(TabPage1)
        tc1.Controls.Add(TabPage2)
        tc1.Controls.Add(TabPage3)
        tc1.Dock = DockStyle.Fill
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
        tc1.TabButtonIdleState.ForeColor = Color.FromArgb(CByte(156), CByte(160), CByte(167))
        tc1.TabButtonIdleState.InnerColor = Color.FromArgb(CByte(33), CByte(42), CByte(57))
        tc1.TabButtonSelectedState.BorderColor = Color.Empty
        tc1.TabButtonSelectedState.FillColor = Color.Black
        tc1.TabButtonSelectedState.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point)
        tc1.TabButtonSelectedState.ForeColor = Color.White
        tc1.TabButtonSelectedState.InnerColor = Color.Silver
        tc1.TabButtonSize = New Size(180, 40)
        tc1.TabIndex = 0
        tc1.TabMenuBackColor = Color.FromArgb(CByte(102), CByte(6), CByte(8))
        ' 
        ' TabPage1
        ' 
        TabPage1.Location = New Point(184, 4)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(841, 622)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Home"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' TabPage2
        ' 
        TabPage2.Location = New Point(184, 4)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(841, 622)
        TabPage2.TabIndex = 1
        TabPage2.Text = "FFB DOCS"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' TabPage3
        ' 
        TabPage3.Location = New Point(184, 4)
        TabPage3.Name = "TabPage3"
        TabPage3.Padding = New Padding(3)
        TabPage3.Size = New Size(841, 622)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Student Roster"
        TabPage3.UseVisualStyleBackColor = True
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
        ResumeLayout(False)
    End Sub

    Friend WithEvents tc1 As Guna.UI2.WinForms.Guna2TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
End Class
