'=============================================================
'Dear Source Code Reader, 
'   This project is made by lovemelody [http://goo.gl/E5kTUH] and Jamie Phan [http://jamiephan.net]
'   The code is under Creative Common Attribution-NonCommercial 4.0 International Licence.
'        --> Link : http://creativecommons.org/licenses/by-nc/4.0/.
'=============================================================
'致原始碼閱讀者：
'   本專案由戀愛の旋律♪ [http://goo.gl/E5kTUH] 以及 Jamie Phan  [http://jamiephan.net] 製作。
'   本原始碼均由 Creative Common Attribution-NonCommercial 4.0 International 受約束。
'        --> 連結 (英文版為準) : http://creativecommons.org/licenses/by-nc/4.0/
'=============================================================
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        Dim PortNumber
        If txtboxProxyPort.Text = "" Then
            PortNumber = 0
        Else
            PortNumber = Integer.Parse(txtboxProxyPort.Text)
        End If
        Dim upload = New imgurUpload(txtboxImagePath.Text, txtboxCustomClientID.Text, txtboxProxyServer.Text, PortNumber, txtboxProxyUsername.Text, txtboxProxyPassword.Text)
    End Sub

    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
        Try
            Using ofd As New OpenFileDialog
                ofd.Filter = "Lovemelody's Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp;*.apng;*.tiff;*.pdf;*.xcf;*.gimp"
                ofd.Title = "Select File"

                If ofd.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    txtboxImagePath.Text = ofd.FileName
                    pbImagePreview.ImageLocation = txtboxImagePath.Text
                End If
            End Using
        Catch ex As Exception
            txtboxImagePath.Text = ex.Message
        End Try
    End Sub
#Region "Force Port to be numberic data"
    Private Sub txtboxProxyPort_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtboxProxyPort.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
#End Region
#Region "Show the password by clicking the label"
    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.MouseLeave
        txtboxProxyPassword.PasswordChar = "*"
    End Sub
    Private Sub Label6_Click_1(sender As Object, e As EventArgs) Handles Label6.Click
        txtboxProxyPassword.PasswordChar = ""
    End Sub
#End Region
#Region "Copy to clipboard event"
    Sub CopyToClipboard(ByVal a As String)
        Try
            My.Computer.Clipboard.SetText(a)
            MsgBox("Copied to Clipboard.")
        Catch ex As Exception
            Return
        End Try
    End Sub
    Private Sub txtboxReturnURL_Click(sender As Object, e As EventArgs) Handles txtboxReturnURL.Click
        CopyToClipboard(txtboxReturnURL.Text)
    End Sub
#End Region
    Private Sub comboxLang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboxLang.SelectedIndexChanged
        If comboxLang.Text = "English" Then
            LangEng()
        ElseIf comboxLang.Text = "繁體中文" Then
            LangCHT()
            Return
        End If
    End Sub
#Region "All The External Commands"
    Dim RunCommand As New RunCommand
    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LovemelodyLink.LinkClicked
        RunCommand.LovemelodyGoo()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles WhatIsClientID.LinkClicked
        RunCommand.ImgurIDGet()
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles JamiePhanLink.LinkClicked
        RunCommand.JamiePhanLink()
    End Sub
    Private Sub btnPreview_Click(sender As Object, e As EventArgs) Handles btnPreview.Click
        RunCommand.preview()
    End Sub
    Private Sub btnLookProxy_Click(sender As Object, e As EventArgs) Handles btnLookProxy.Click
        RunCommand.LookUpProxy()
    End Sub
#End Region
#Region "Language Settings Goes Here"
    Public Sub LangCHT()
        Me.Text = "戀愛の旋律♪ Imgur 圖片上傳器 - http://goo.gl/E5kTUH"
        Me.Label7.Text = "圖片路徑 ："
        Me.btnOpen.Text = "打開圖片"
        Me.btnUpload.Text = "上傳"
        '=============
        Me.GroupBox3.Text = "傳回的訊息"
        Me.Label5.Text = "傳回 URL / 錯誤訊息 :"
        Me.btnPreview.Text = "檢視"
        '=============
        Me.GroupBox1.Text = "Proxy 連接設定 （機構，學校，學院等可能需要。)，如不需要，留空白即可)"
        Me.Label2.Text = "伺服器 :"
        Me.Label3.Text = "連接埠 :"
        Me.Label4.Text = "使用者名稱 :"
        Me.Label1.Text = "密碼 :"
        Me.btnLookProxy.Text = "查看 Proxy 設定 [區域網絡設定]"
        Me.Label6.Text = "點一下看看密碼"
        '========================
        Me.GroupBox2.Text = "自訂Imgur的Client ID（如沒有，留空白即可，預設使用戀愛の旋律♪的Client ID。）"
        Me.WhatIsClientID.Text = "什麼是Client ID ？"
        '========================
        Me.Label8.Text = "程式製作者："
        Me.LovemelodyLink.Text = "戀愛の旋律♪"
    End Sub



    Public Sub LangEng()
        Me.Text = "Lovemelody Imgur Image Uploader - http://goo.gl/E5kTUH"
        Me.Label7.Text = "Image Path :"
        Me.btnOpen.Text = "Open Image"
        Me.btnUpload.Text = "Upload"
        '=============
        Me.GroupBox3.Text = "Return Message"
        Me.Label5.Text = "Return URL / Error Message :"
        Me.btnPreview.Text = "Preview"
        '=============
        Me.GroupBox1.Text = "Proxy Connection (Organisation, School, Collage may required), If not required, just leave blank)"
        Me.Label2.Text = "Server :"
        Me.Label3.Text = "Port :"
        Me.Label4.Text = "Username :"
        Me.Label1.Text = "Password :"
        Me.btnLookProxy.Text = "Look up Proxy Settings [LAN Settings]"
        Me.Label6.Text = "ClickShowPassword"
        '========================
        Me.GroupBox2.Text = "Custom Imgur Client ID (If none just leave blank, Default use Lovemelody's Client ID)"
        Me.WhatIsClientID.Text = "What is Client ID?"
        '==========================
        Me.Label8.Text = "Program Author :"
        Me.LovemelodyLink.Text = "Lovemelody"
    End Sub
#End Region
End Class
