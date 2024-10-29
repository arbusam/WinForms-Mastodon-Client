Imports MaterialSkin
Imports MaterialSkin.Controls

Public Class Form1
    Inherits MaterialForm
    Private isDrawerOpen As Boolean = False

    Private Sub MaterialDivider1_Click(sender As Object, e As EventArgs)

    End Sub
    Public Sub New()
        InitializeComponent()

        Dim materialSkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        materialSkinManager.AddFormToManage(Me)
        materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT

        ' Optional: Set color scheme
        materialSkinManager.ColorScheme = New ColorScheme(
            Primary.Blue600, Primary.Blue700, Primary.Blue200,
            Accent.LightBlue200, TextShade.WHITE)
        PictureBox1.BackColor = ColorTranslator.FromHtml("#1E88E5")
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tweet As New Post("Arhan Busam", "@a12345@fostodon.org", "I hope you enjoy the app!", 7300, 3, New Date(2024, 4, 20), True)
        MaterialListView1.Controls.Add(tweet)
        'Dim tweet2 As New Post("Arhan Busam", "@a12345@fostodon.org", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed mattis mauris varius tellus pharetra posuere. Fusce nec euismod massa, aliquet maximus leo. Nulla consectetur, urna sed porttitor laoreet, ex orci mollis magna, quis venenatis tortor metus ac lacus. Quisque finibus tempor gravida. Morbi et lacus at purus consequat vehicula quis id lorem. Sed velit elit, blandit quis pharetra sit amet, porttitor vel purus. Praesent ex urna, venenatis non bibendum eget, ultricies ac nulla.", 52000000, 52, New Date(2020, 4, 20), False)
        'MaterialListView1.Controls.Add(tweet2)
    End Sub

    Private Sub MaterialDrawer1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MaterialDrawer4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub
End Class
