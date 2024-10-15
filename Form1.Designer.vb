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
        MaterialDivider1 = New MaterialSkin.Controls.MaterialDivider()
        PictureBox1 = New PictureBox()
        MaterialDivider2 = New MaterialSkin.Controls.MaterialDivider()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MaterialDivider1
        ' 
        MaterialDivider1.BackColor = Color.FromArgb(CByte(30), CByte(0), CByte(0), CByte(0))
        MaterialDivider1.Depth = 0
        MaterialDivider1.Location = New Point(-66, 85)
        MaterialDivider1.MouseState = MaterialSkin.MouseState.HOVER
        MaterialDivider1.Name = "MaterialDivider1"
        MaterialDivider1.Size = New Size(1705, 1)
        MaterialDivider1.TabIndex = 0
        MaterialDivider1.Text = "MaterialDivider1"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.account_circle_24dp_536DFE_FILL0_wght400_GRAD0_opsz24
        PictureBox1.Location = New Point(1506, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(60, 60)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' MaterialDivider2
        ' 
        MaterialDivider2.BackColor = Color.FromArgb(CByte(30), CByte(0), CByte(0), CByte(0))
        MaterialDivider2.Depth = 0
        MaterialDivider2.Location = New Point(250, 85)
        MaterialDivider2.MouseState = MaterialSkin.MouseState.HOVER
        MaterialDivider2.Name = "MaterialDivider2"
        MaterialDivider2.Size = New Size(1, 885)
        MaterialDivider2.TabIndex = 2
        MaterialDivider2.Text = "MaterialDivider2"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1578, 844)
        Controls.Add(MaterialDivider2)
        Controls.Add(PictureBox1)
        Controls.Add(MaterialDivider1)
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents MaterialDivider1 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents MaterialDivider2 As MaterialSkin.Controls.MaterialDivider

End Class
