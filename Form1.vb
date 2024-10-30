Imports MaterialSkin
Imports MaterialSkin.Controls
Imports HtmlAgilityPack
Imports System.Net.Http
Imports System.Threading.Tasks
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports System.ComponentModel
Imports System.Drawing
Imports System.IO

Public Class Form1
    Inherits MaterialForm
    Private isDrawerOpen As Boolean = False

    Private maxID As String = "999999999999999999"
    Private maxSearchID As String = "999999999999999999"

    Private isLoading As Boolean = False
    Private searchIsLoading As Boolean = False

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
            Try
                Dim post As Post
                If responsePost("media_attachments").Count > 0 Then
                    If responsePost("media_attachments")(0)("type") = "image" Then
                        post = New Post(responsePost("account")("display_name"), responsePost("account")("acct"), Await DownloadImageAsync(responsePost("account")("avatar_static")), HTML_To_Text(responsePost("content")), Await DownloadImageAsync(responsePost("media_attachments")(0)("preview_url")), responsePost("favourites_count"), responsePost("replies_count"), responsePost("reblogs_count"), localDate, False)
                    Else
                        post = New Post(responsePost("account")("display_name"), responsePost("account")("acct"), Await DownloadImageAsync(responsePost("account")("avatar_static")), HTML_To_Text(responsePost("content")), Nothing, responsePost("favourites_count"), responsePost("replies_count"), responsePost("reblogs_count"), localDate, False)
                    End If
                Else
                    post = New Post(responsePost("account")("display_name"), responsePost("account")("acct"), Await DownloadImageAsync(responsePost("account")("avatar_static")), HTML_To_Text(responsePost("content")), Nothing, responsePost("favourites_count"), responsePost("replies_count"), responsePost("reblogs_count"), localDate, False)
                End If
                FlowLayoutPanel1.Controls.Add(post)
            Catch e As Exception
                Console.WriteLine("Error loading post: " & e.ToString())
            End Try
        Next
        isLoading = False
    End Sub
    Private Async Function DownloadImageAsync(url As String) As Task(Of Image)
        Using client As New HttpClient()
            Dim response As HttpResponseMessage = Await client.GetAsync(url)
            response.EnsureSuccessStatusCode()
            Dim stream As Stream = Await response.Content.ReadAsStreamAsync()
            Return Image.FromStream(stream)
        End Using
    End Function


    Async Sub Load_Trending_Posts()
        Dim url As String = "https://mastodon.social/api/v1/trends/statuses?limit=40"
        Dim response As String = Await GetRequestAsync(url)
        Dim jsonResponse As JArray = JArray.Parse(response)
        Dim format As String = "MM/dd/yyyy HH:mm:ss"
        Dim lastResponse As JToken = jsonResponse.Last
        For Each responsePost In jsonResponse
            Dim utcDate As DateTime = DateTime.ParseExact(responsePost("created_at"), format, System.Globalization.CultureInfo.InvariantCulture)
            Dim localDate As DateTime = utcDate.ToLocalTime()
            Try
                Dim post As Post
                If responsePost("media_attachments").Count > 0 Then
                    If responsePost("media_attachments")(0)("type") = "image" Then
                        post = New Post(responsePost("account")("display_name"), responsePost("account")("acct"), Await DownloadImageAsync(responsePost("account")("avatar_static")), HTML_To_Text(responsePost("content")), Await DownloadImageAsync(responsePost("media_attachments")(0)("preview_url")), responsePost("favourites_count"), responsePost("replies_count"), responsePost("reblogs_count"), localDate, False)
                    Else
                        post = New Post(responsePost("account")("display_name"), responsePost("account")("acct"), Await DownloadImageAsync(responsePost("account")("avatar_static")), HTML_To_Text(responsePost("content")), Nothing, responsePost("favourites_count"), responsePost("replies_count"), responsePost("reblogs_count"), localDate, False)
                    End If
                Else
                    post = New Post(responsePost("account")("display_name"), responsePost("account")("acct"), Await DownloadImageAsync(responsePost("account")("avatar_static")), HTML_To_Text(responsePost("content")), Nothing, responsePost("favourites_count"), responsePost("replies_count"), responsePost("reblogs_count"), localDate, False)
                End If
                FlowLayoutPanel2.Controls.Add(post)
            Catch e As Exception
                Console.WriteLine("Error loading post: " & e.ToString())
            End Try
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

    Async Sub Load_Search_Posts()
        Dim url As String = "https://mastodon.social/api/v1/timelines/tag/" & MaterialTextBox21.Text & "?limit=10&max_id=" & maxSearchID
        Dim response As String = Await GetRequestAsync(url)
        If response = "[]" Then
            Exit Sub
        End If
        Dim jsonResponse As JArray = JArray.Parse(response)
        Dim format As String = "MM/dd/yyyy HH:mm:ss"
        Dim lastResponse As JToken = jsonResponse.Last
        maxSearchID = lastResponse("id")
        For Each responsePost In jsonResponse
            Dim utcDate As DateTime = DateTime.ParseExact(responsePost("created_at"), format, System.Globalization.CultureInfo.InvariantCulture)
            Dim localDate As DateTime = utcDate.ToLocalTime()
            Try
                Dim post As Post
                If responsePost("media_attachments").Count > 0 Then
                    If responsePost("media_attachments")(0)("type") = "image" Then
                        post = New Post(responsePost("account")("display_name"), responsePost("account")("acct"), Await DownloadImageAsync(responsePost("account")("avatar_static")), HTML_To_Text(responsePost("content")), Await DownloadImageAsync(responsePost("media_attachments")(0)("preview_url")), responsePost("favourites_count"), responsePost("replies_count"), responsePost("reblogs_count"), localDate, False)
                    Else
                        post = New Post(responsePost("account")("display_name"), responsePost("account")("acct"), Await DownloadImageAsync(responsePost("account")("avatar_static")), HTML_To_Text(responsePost("content")), Nothing, responsePost("favourites_count"), responsePost("replies_count"), responsePost("reblogs_count"), localDate, False)
                    End If
                Else
                    post = New Post(responsePost("account")("display_name"), responsePost("account")("acct"), Await DownloadImageAsync(responsePost("account")("avatar_static")), HTML_To_Text(responsePost("content")), Nothing, responsePost("favourites_count"), responsePost("replies_count"), responsePost("reblogs_count"), localDate, False)
                End If
                FlowLayoutPanel3.Controls.Add(post)
            Catch e As Exception
                Console.WriteLine("Error loading post: " & e.ToString())
            End Try
        Next
        searchIsLoading = False
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

    Private Sub MaterialButton1_Click(sender As Object, e As EventArgs) Handles MaterialButton1.Click
        FlowLayoutPanel3.Controls.Clear()
        If Not MaterialTextBox21.Text = "" And MaterialTextBox21.Text IsNot Nothing Then
            Load_Search_Posts()
        End If
    End Sub

    Private Sub FlowLayoutPanel3_MouseWheel(sender As Object, e As MouseEventArgs) Handles FlowLayoutPanel3.MouseWheel
        ' Check if the user has scrolled to the bottom
        If FlowLayoutPanel3.VerticalScroll.Value + FlowLayoutPanel3.ClientSize.Height >= FlowLayoutPanel3.VerticalScroll.Maximum Then
            ' Load more tweets if not already loading
            If Not searchIsLoading Then
                searchIsLoading = True
                Load_Search_Posts()
            End If
        End If
    End Sub
End Class
