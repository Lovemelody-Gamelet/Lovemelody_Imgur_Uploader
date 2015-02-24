Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Text.RegularExpressions

Public Class imgurUpload
    Public Sub New(imagePath As String, Optional ClientID As String = Nothing, Optional ProxyServer As String = Nothing, Optional ProxyPort As Integer = Nothing, Optional ProxyUsername As String = Nothing, Optional ProxyPassword As String = Nothing)
        'determinate whether user have custom client ID.
        If ClientID = Nothing Then
            ClientID = "906ce2cb57a3e3a" 'Use lovemelody ID.
        End If
        Dim ImgurUploadClient As New WebClient
        'Use Proxy server 
        If ProxyPort = 0 Then
            GoTo Line1 'Terrible programming...dont Use this method
        End If
        If ProxyServer IsNot Nothing Or ProxyPort <> Nothing Then
            ImgurUploadClient.Proxy = New WebProxy(ProxyServer, ProxyPort)
            If ProxyUsername IsNot Nothing Or ProxyPassword IsNot Nothing Then  'If the username and password entered.
                ImgurUploadClient.Proxy.Credentials = New NetworkCredential(ProxyUsername, ProxyPassword)
            End If
        End If
        'Add header
        ImgurUploadClient.Headers.Add("Authorization", "Client-ID " & ClientID)
Line1:
        'Return a request, try if there are an error.
        Dim Keys As New System.Collections.Specialized.NameValueCollection
        Try
            Keys.Add("image", Convert.ToBase64String(File.ReadAllBytes(imagePath)))
            Dim responseArray As Byte() = ImgurUploadClient.UploadValues("https://api.imgur.com/3/image", Keys)
            Dim result = Encoding.ASCII.GetString(responseArray)
            Dim reg As New System.Text.RegularExpressions.Regex("link"":""(.*?)""")
            Dim match As Match = reg.Match(result)
            Dim url As String = match.ToString.Replace("link"":""", "").Replace("""", "").Replace("\/", "/")
            Form1.txtboxReturnURL.Text = url 'Display the return url in form 1
        Catch ex As Exception
            Form1.txtboxReturnURL.Text = "Error, " & ex.Message ' Display an error if occurs.
        End Try
    End Sub
End Class