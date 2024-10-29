Public Class Post
    Public Sub New(username As String, email As String, content As String, likes As Integer, replies As Integer, reposts As Integer, datePosted As Date, liked As Boolean)
        InitializeComponent()

        Dim likesString As String
        If likes >= 1000000 Then
            likesString = (likes / 1000000).ToString("0.0") & "m"
        ElseIf likes >= 1000 Then
            likesString = (likes / 1000).ToString("0.0") & "k"
        Else
            likesString = likes.ToString()
        End If

        Dim timeString As String
        Dim timeSpan As TimeSpan = Date.Now - datePosted
        If timeSpan.Days > 365 Then
            Dim years As Integer = timeSpan.Days \ 365
            timeString = years & "y ago"
        ElseIf timeSpan.Days > 30 Then
            Dim months As Integer = timeSpan.Days \ 30
            timeString = months & "mo ago"
        ElseIf timeSpan.Days > 0 Then
            timeString = timeSpan.Days & "d ago"
        ElseIf timeSpan.Hours > 0 Then
            timeString = timeSpan.Hours & "h ago"
        ElseIf timeSpan.Minutes > 0 Then
            timeString = timeSpan.Minutes & "m ago"
        Else
            timeString = timeSpan.Seconds & "s ago"
        End If

        ' Set the content of the controls
        lblName.Text = username
        lblUsername.Text = email
        lblContent.Text = content
        lblLikes.Text = likesString
        lblReplies.Text = replies.ToString()
        lblReposts.Text = reposts.ToString()
        lblTime.Text = timeString

        If liked Then
            btnLike.Image = My.Resources.like_filled
        End If

        AdjustHeight()
    End Sub

    Private Sub AdjustHeight()
        ' Measure the height of lblTweetContent after setting the text
        lblContent.Height = TextRenderer.MeasureText(lblContent.Text, lblContent.Font, New Size(lblContent.Width, Integer.MaxValue), TextFormatFlags.WordBreak).Height

        ' Set the height of the UserControl based on content + padding for buttons
        Me.Height = lblContent.Top + lblContent.Height + 50 ' Add padding for the buttons
    End Sub

    Private Sub Post_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
