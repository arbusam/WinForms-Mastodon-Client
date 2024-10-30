<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Post
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Post))
        avatarImage = New PictureBox()
        lblName = New MaterialSkin.Controls.MaterialLabel()
        lblUsername = New MaterialSkin.Controls.MaterialLabel()
        lblTime = New MaterialSkin.Controls.MaterialLabel()
        lblContent = New MaterialSkin.Controls.MaterialLabel()
        lblReplies = New MaterialSkin.Controls.MaterialLabel()
        lblReposts = New MaterialSkin.Controls.MaterialLabel()
        lblLikes = New MaterialSkin.Controls.MaterialLabel()
        LinkLabel1 = New LinkLabel()
        Button1 = New Button()
        PictureBox1 = New PictureBox()
        CType(avatarImage, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' avatarImage
        ' 
        avatarImage.Image = My.Resources.Resources.account_circle_24dp_536DFE_FILL0_wght400_GRAD0_opsz24
        avatarImage.Location = New Point(3, 3)
        avatarImage.Name = "avatarImage"
        avatarImage.Size = New Size(40, 40)
        avatarImage.SizeMode = PictureBoxSizeMode.Zoom
        avatarImage.TabIndex = 0
        avatarImage.TabStop = False
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Depth = 0
        lblName.Font = New Font("Roboto", 14.0F, FontStyle.Regular, GraphicsUnit.Pixel)
        lblName.Location = New Point(49, 3)
        lblName.MouseState = MaterialSkin.MouseState.HOVER
        lblName.Name = "lblName"
        lblName.Size = New Size(97, 19)
        lblName.TabIndex = 1
        lblName.Text = "Arhan Busam"
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Depth = 0
        lblUsername.Font = New Font("Roboto", 14.0F, FontStyle.Regular, GraphicsUnit.Pixel)
        lblUsername.Location = New Point(49, 24)
        lblUsername.MouseState = MaterialSkin.MouseState.HOVER
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(182, 19)
        lblUsername.TabIndex = 2
        lblUsername.Text = "@a12345@fosstodon.org"
        ' 
        ' lblTime
        ' 
        lblTime.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblTime.AutoSize = True
        lblTime.Depth = 0
        lblTime.Font = New Font("Roboto", 14.0F, FontStyle.Regular, GraphicsUnit.Pixel)
        lblTime.Location = New Point(1382, 3)
        lblTime.MouseState = MaterialSkin.MouseState.HOVER
        lblTime.Name = "lblTime"
        lblTime.Size = New Size(55, 19)
        lblTime.TabIndex = 3
        lblTime.Text = "7m ago"
        ' 
        ' lblContent
        ' 
        lblContent.Depth = 0
        lblContent.Font = New Font("Roboto", 24.0F, FontStyle.Bold, GraphicsUnit.Pixel)
        lblContent.FontType = MaterialSkin.MaterialSkinManager.fontType.H5
        lblContent.Location = New Point(7, 59)
        lblContent.MaximumSize = New Size(1486, 0)
        lblContent.MouseState = MaterialSkin.MouseState.HOVER
        lblContent.Name = "lblContent"
        lblContent.Size = New Size(1429, 116)
        lblContent.TabIndex = 4
        lblContent.Text = resources.GetString("lblContent.Text")
        ' 
        ' lblReplies
        ' 
        lblReplies.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        lblReplies.AutoSize = True
        lblReplies.Depth = 0
        lblReplies.Font = New Font("Roboto", 14.0F, FontStyle.Regular, GraphicsUnit.Pixel)
        lblReplies.Location = New Point(7, 244)
        lblReplies.MouseState = MaterialSkin.MouseState.HOVER
        lblReplies.Name = "lblReplies"
        lblReplies.Size = New Size(51, 19)
        lblReplies.TabIndex = 6
        lblReplies.Text = "7 Likes"
        ' 
        ' lblReposts
        ' 
        lblReposts.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        lblReposts.AutoSize = True
        lblReposts.Depth = 0
        lblReposts.Font = New Font("Roboto", 14.0F, FontStyle.Regular, GraphicsUnit.Pixel)
        lblReposts.Location = New Point(682, 244)
        lblReposts.MouseState = MaterialSkin.MouseState.HOVER
        lblReposts.Name = "lblReposts"
        lblReposts.Size = New Size(71, 19)
        lblReposts.TabIndex = 8
        lblReposts.Text = "3 Reposts"
        ' 
        ' lblLikes
        ' 
        lblLikes.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        lblLikes.Depth = 0
        lblLikes.Font = New Font("Roboto", 14.0F, FontStyle.Regular, GraphicsUnit.Pixel)
        lblLikes.Location = New Point(1344, 244)
        lblLikes.MouseState = MaterialSkin.MouseState.HOVER
        lblLikes.Name = "lblLikes"
        lblLikes.Size = New Size(92, 19)
        lblLikes.TabIndex = 10
        lblLikes.Text = "7.3k Likes"
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Location = New Point(7, 150)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(0, 25)
        LinkLabel1.TabIndex = 11
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Transparent
        Button1.Image = My.Resources.Resources.favorite_24dp_536DFE_FILL0_wght400_GRAD0_opsz24
        Button1.Location = New Point(887, 185)
        Button1.Name = "Button1"
        Button1.Size = New Size(0, 0)
        Button1.TabIndex = 12
        Button1.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Anchor = AnchorStyles.Bottom
        PictureBox1.Enabled = False
        PictureBox1.Location = New Point(7, 178)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1429, 50)
        PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize
        PictureBox1.TabIndex = 16
        PictureBox1.TabStop = False
        PictureBox1.Visible = False
        ' 
        ' Post
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(PictureBox1)
        Controls.Add(Button1)
        Controls.Add(LinkLabel1)
        Controls.Add(lblLikes)
        Controls.Add(lblReposts)
        Controls.Add(lblReplies)
        Controls.Add(lblContent)
        Controls.Add(lblTime)
        Controls.Add(lblUsername)
        Controls.Add(lblName)
        Controls.Add(avatarImage)
        Name = "Post"
        Size = New Size(1442, 279)
        CType(avatarImage, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents avatarImage As PictureBox
    Friend WithEvents lblName As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblUsername As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblTime As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblContent As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblReplies As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblReposts As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblLikes As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox

End Class
