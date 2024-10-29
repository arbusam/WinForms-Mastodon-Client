Imports MaterialSkin
Imports MaterialSkin.Controls
Imports HtmlAgilityPack
Imports System.Net.Http
Imports System.Threading.Tasks
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports System.ComponentModel

Public Class Form1
    Inherits MaterialForm
    Private isDrawerOpen As Boolean = False

    Private maxID As String = "999999999999999999"

    Private isLoading As Boolean = False

    Private trendingIsLoaded As Boolean = False

    ' Event handler for when the FlowLayoutPanel scrolls
    Private Sub FlowLayoutPanel1_MouseWheel(sender As Object, e As MouseEventArgs) Handles FlowLayoutPanel1.MouseWheel
        ' Check if the user has scrolled to the bottom
        If FlowLayoutPanel1.VerticalScroll.Value + FlowLayoutPanel1.ClientSize.Height >= FlowLayoutPanel1.VerticalScroll.Maximum Then
            ' Load more tweets if not already loading
            If Not isLoading Then
                isLoading = True
                Load_Public_Posts()
            End If
        End If
    End Sub

    Async Function GetRequestAsync(ByVal url As String) As Task(Of String)
        ' Initialize the HttpClient
        Using client As New HttpClient()
            Try
                ' Send GET request
                Dim response As HttpResponseMessage = Await client.GetAsync(url)

                ' Check if request was successful
                response.EnsureSuccessStatusCode()

                ' Read and return response content as string
                Dim responseBody As String = Await response.Content.ReadAsStringAsync()
                Return responseBody
            Catch e As HttpRequestException
                Console.WriteLine("Request error: " & e.Message)
                Return String.Empty
            End Try
        End Using
    End Function

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

    Async Sub Load_Public_Posts()
        Dim url As String = "https://mastodon.social/api/v1/timelines/public?limit=10&max_id=" & maxID
        Dim response As String = Await GetRequestAsync(url)
        Dim jsonResponse As JArray = JArray.Parse(response)
        Dim format As String = "MM/dd/yyyy HH:mm:ss"
        Dim lastResponse As JToken = jsonResponse.Last
        maxID = lastResponse("id")
        For Each responsePost In jsonResponse
            Dim utcDate As DateTime = DateTime.ParseExact(responsePost("created_at"), format, System.Globalization.CultureInfo.InvariantCulture)
            Dim localDate As DateTime = utcDate.ToLocalTime()
            Dim post As New Post(responsePost("account")("display_name"), responsePost("account")("acct"), HTML_To_Text(responsePost("content")), responsePost("favourites_count"), responsePost("replies_count"), responsePost("reblogs_count"), localDate, False)
            FlowLayoutPanel1.Controls.Add(post)
        Next
        isLoading = False
    End Sub

    Async Sub Load_Trending_Posts()
        Dim url As String = "https://mastodon.social/api/v1/trends/statuses?limit=40"
        Dim response As String = Await GetRequestAsync(url)
        Dim jsonResponse As JArray = JArray.Parse(response)
        Dim format As String = "MM/dd/yyyy HH:mm:ss"
        Dim lastResponse As JToken = jsonResponse.Last
        maxID = lastResponse("id")
        For Each responsePost In jsonResponse
            Dim utcDate As DateTime = DateTime.ParseExact(responsePost("created_at"), format, System.Globalization.CultureInfo.InvariantCulture)
            Dim localDate As DateTime = utcDate.ToLocalTime()
            Dim post As New Post(responsePost("account")("display_name"), responsePost("account")("acct"), HTML_To_Text(responsePost("content")), responsePost("favourites_count"), responsePost("replies_count"), responsePost("reblogs_count"), localDate, False)
            FlowLayoutPanel2.Controls.Add(post)
        Next

        Dim label As Label = New MaterialLabel With {
            .Text = "That's all!",
            .Font = New Font("Roboto", 24.0, FontStyle.Bold, GraphicsUnit.Pixel),
            .FontType = MaterialSkin.MaterialSkinManager.fontType.H5,
            .Padding = New Padding(10, 30, 10, 30)
        }
        FlowLayoutPanel2.Controls.Add(label)
        trendingIsLoaded = True
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim tweet As New Post("Arhan Busam", "@a12345@fostodon.org", "I hope you enjoy the app!", 7300, 3, New Date(2024, 4, 20), True)
        'FlowLayoutPanel1.Controls.Add(tweet)
        'Dim tweet2 As New Post("Arhan Busam", "@a12345@fostodon.org", "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed mattis mauris varius tellus pharetra posuere. Fusce nec euismod massa, aliquet maximus leo. Nulla consectetur, urna sed porttitor laoreet, ex orci mollis magna, quis venenatis tortor metus ac lacus. Quisque finibus tempor gravida. Morbi et lacus at purus consequat vehicula quis id lorem. Sed velit elit, blandit quis pharetra sit amet, porttitor vel purus. Praesent ex urna, venenatis non bibendum eget, ultricies ac nulla.", 52000000, 52, New Date(2020, 4, 20), False)
        'FlowLayoutPanel1.Controls.Add(tweet2)
        Load_Posts()
    End Sub

    Private Sub Load_Posts()
        If MaterialTabControl1.SelectedTab.TabIndex = 0 Then
            Load_Public_Posts()
        ElseIf MaterialTabControl1.SelectedTab.TabIndex = 1 And Not trendingIsLoaded Then
            Load_Trending_Posts()
        End If
    End Sub

    Private Function HTML_To_Text(htmlContent As String)
        ' Load HTML content into HtmlDocument
        Dim htmlDoc As New HtmlDocument()
        htmlDoc.LoadHtml(htmlContent)

        ' Extract plain text from HTML
        Dim plainText As String = htmlDoc.DocumentNode.InnerText
        Return plainText
    End Function

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

    Private Sub MaterialTabSelector1_Click(sender As Object, e As EventArgs) Handles MaterialTabSelector1.Click

    End Sub

    Private Sub MaterialTabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MaterialTabControl1.SelectedIndexChanged
        Load_Posts()
    End Sub
End Class
