<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits MaterialSkin.Controls.MaterialForm

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
        MaterialTabControl1 = New MaterialSkin.Controls.MaterialTabControl()
        TabPage1 = New TabPage()
        Panel1 = New Panel()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        TabPage2 = New TabPage()
        FlowLayoutPanel2 = New FlowLayoutPanel()
        TabPage3 = New TabPage()
        MaterialButton1 = New MaterialSkin.Controls.MaterialButton()
        FlowLayoutPanel3 = New FlowLayoutPanel()
        MaterialTextBox21 = New MaterialSkin.Controls.MaterialTextBox2()
        MaterialTabSelector1 = New MaterialSkin.Controls.MaterialTabSelector()
        MaterialTabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        Panel1.SuspendLayout()
        TabPage2.SuspendLayout()
        TabPage3.SuspendLayout()
        SuspendLayout()
        ' 
        ' MaterialTabControl1
        ' 
        MaterialTabControl1.Controls.Add(TabPage1)
        MaterialTabControl1.Controls.Add(TabPage2)
        MaterialTabControl1.Controls.Add(TabPage3)
        MaterialTabControl1.Depth = 0
        MaterialTabControl1.Location = New Point(6, 133)
        MaterialTabControl1.MouseState = MaterialSkin.MouseState.HOVER
        MaterialTabControl1.Multiline = True
        MaterialTabControl1.Name = "MaterialTabControl1"
        MaterialTabControl1.SelectedIndex = 0
        MaterialTabControl1.Size = New Size(1488, 861)
        MaterialTabControl1.TabIndex = 4
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(Panel1)
        TabPage1.Location = New Point(4, 34)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(1480, 823)
        TabPage1.TabIndex = 0
        TabPage1.Text = "Public"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.AutoScroll = True
        Panel1.Controls.Add(FlowLayoutPanel1)
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1484, 827)
        Panel1.TabIndex = 0
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.AutoScroll = True
        FlowLayoutPanel1.FlowDirection = FlowDirection.TopDown
        FlowLayoutPanel1.Location = New Point(0, 0)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(1480, 823)
        FlowLayoutPanel1.TabIndex = 0
        FlowLayoutPanel1.WrapContents = False
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(FlowLayoutPanel2)
        TabPage2.Location = New Point(4, 34)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(1480, 823)
        TabPage2.TabIndex = 1
        TabPage2.Text = "Trending"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' FlowLayoutPanel2
        ' 
        FlowLayoutPanel2.AutoScroll = True
        FlowLayoutPanel2.FlowDirection = FlowDirection.TopDown
        FlowLayoutPanel2.Location = New Point(0, 0)
        FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        FlowLayoutPanel2.Size = New Size(1480, 823)
        FlowLayoutPanel2.TabIndex = 0
        FlowLayoutPanel2.WrapContents = False
        ' 
        ' TabPage3
        ' 
        TabPage3.Controls.Add(MaterialButton1)
        TabPage3.Controls.Add(FlowLayoutPanel3)
        TabPage3.Controls.Add(MaterialTextBox21)
        TabPage3.Location = New Point(4, 34)
        TabPage3.Name = "TabPage3"
        TabPage3.Size = New Size(1480, 823)
        TabPage3.TabIndex = 2
        TabPage3.Text = "Search"
        TabPage3.UseVisualStyleBackColor = True
        ' 
        ' MaterialButton1
        ' 
        MaterialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        MaterialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default
        MaterialButton1.Depth = 0
        MaterialButton1.HighEmphasis = True
        MaterialButton1.Icon = Nothing
        MaterialButton1.Location = New Point(344, 6)
        MaterialButton1.Margin = New Padding(4, 6, 4, 6)
        MaterialButton1.MouseState = MaterialSkin.MouseState.HOVER
        MaterialButton1.Name = "MaterialButton1"
        MaterialButton1.NoAccentTextColor = Color.Empty
        MaterialButton1.Size = New Size(78, 36)
        MaterialButton1.TabIndex = 3
        MaterialButton1.Text = "Search"
        MaterialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        MaterialButton1.UseAccentColor = False
        MaterialButton1.UseVisualStyleBackColor = True
        ' 
        ' FlowLayoutPanel3
        ' 
        FlowLayoutPanel3.AutoScroll = True
        FlowLayoutPanel3.FlowDirection = FlowDirection.TopDown
        FlowLayoutPanel3.Location = New Point(3, 57)
        FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        FlowLayoutPanel3.Size = New Size(1485, 774)
        FlowLayoutPanel3.TabIndex = 2
        FlowLayoutPanel3.WrapContents = False
        ' 
        ' MaterialTextBox21
        ' 
        MaterialTextBox21.AnimateReadOnly = False
        MaterialTextBox21.BackgroundImageLayout = ImageLayout.None
        MaterialTextBox21.CharacterCasing = CharacterCasing.Normal
        MaterialTextBox21.Depth = 0
        MaterialTextBox21.Font = New Font("Roboto", 16.0F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialTextBox21.HideSelection = True
        MaterialTextBox21.Hint = "Search for any topic"
        MaterialTextBox21.LeadingIcon = Nothing
        MaterialTextBox21.Location = New Point(3, 3)
        MaterialTextBox21.MaxLength = 32767
        MaterialTextBox21.MouseState = MaterialSkin.MouseState.OUT
        MaterialTextBox21.Name = "MaterialTextBox21"
        MaterialTextBox21.PasswordChar = ChrW(0)
        MaterialTextBox21.PrefixSuffixText = Nothing
        MaterialTextBox21.ReadOnly = False
        MaterialTextBox21.RightToLeft = RightToLeft.No
        MaterialTextBox21.SelectedText = ""
        MaterialTextBox21.SelectionLength = 0
        MaterialTextBox21.SelectionStart = 0
        MaterialTextBox21.ShortcutsEnabled = True
        MaterialTextBox21.Size = New Size(334, 48)
        MaterialTextBox21.TabIndex = 1
        MaterialTextBox21.TabStop = False
        MaterialTextBox21.TextAlign = HorizontalAlignment.Left
        MaterialTextBox21.TrailingIcon = Nothing
        MaterialTextBox21.UseSystemPasswordChar = False
        ' 
        ' MaterialTabSelector1
        ' 
        MaterialTabSelector1.BaseTabControl = MaterialTabControl1
        MaterialTabSelector1.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal
        MaterialTabSelector1.Depth = 0
        MaterialTabSelector1.Font = New Font("Roboto", 14.0F, FontStyle.Regular, GraphicsUnit.Pixel)
        MaterialTabSelector1.Location = New Point(-14, 55)
        MaterialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER
        MaterialTabSelector1.Name = "MaterialTabSelector1"
        MaterialTabSelector1.Size = New Size(1523, 72)
        MaterialTabSelector1.TabIndex = 5
        MaterialTabSelector1.Text = "MaterialTabSelector1"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1500, 1000)
        Controls.Add(MaterialTabSelector1)
        Controls.Add(MaterialTabControl1)
        MinimumSize = New Size(1500, 1000)
        Name = "Form1"
        Padding = New Padding(3, 63, 3, 3)
        Text = "Mastodon Client"
        MaterialTabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        TabPage2.ResumeLayout(False)
        TabPage3.ResumeLayout(False)
        TabPage3.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents MaterialTabControl1 As MaterialSkin.Controls.MaterialTabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents MaterialTabSelector1 As MaterialSkin.Controls.MaterialTabSelector
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents MaterialTextBox21 As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
    Friend WithEvents MaterialButton1 As MaterialSkin.Controls.MaterialButton

End Class
