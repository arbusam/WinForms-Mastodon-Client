Public Class Post

    Public Sub New(username As String, email As String, avatar As Image, content As String, image As Image, likes As Integer, replies As Integer, reposts As Integer, datePosted As Date, liked As Boolean)
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
        lblLikes.Text = likesString & " Likes"
        lblReplies.Text = replies.ToString() & " Replies"
        lblReposts.Text = reposts.ToString() & " Reposts"
        lblTime.Text = timeString
        avatarImage.Image = avatar

        If image IsNot Nothing Then
            PictureBox1.Image = image
            PictureBox1.Enabled = True
            PictureBox1.Visible = True
        End If

        AdjustHeight()
    End Sub

    Private Sub AdjustHeight()
        lblContent.Height = TextRenderer.MeasureText(lblContent.Text, lblContent.Font, New Size(lblContent.Width, Integer.MaxValue), TextFormatFlags.WordBreak).Height

        If PictureBox1.Enabled Then
            Me.Height = lblContent.Top + lblContent.Height + PictureBox1.Height * 1.2 + 50
        Else
            Me.Height = lblContent.Top + lblContent.Height + 50
        End If

    End Sub

    Private Sub Post_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
