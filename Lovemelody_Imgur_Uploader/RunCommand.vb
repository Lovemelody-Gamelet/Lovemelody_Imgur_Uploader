Public Class RunCommand

    Public Sub LovemelodyGoo()
        Process.Start("http://goo.gl/E5kTUH")
    End Sub

    Public Sub ImgurIDGet()
        Process.Start("www.googledrive.com/host/0B2JIawlS8QjdXzUtbTF4VUVhMFU")
    End Sub

    Public Sub JamiePhanLink()
        Process.Start("http://www.jamiephan.net")
    End Sub
    Public Sub LookUpProxy()
        Shell("C:\Windows\System32\rundll32.exe shell32.dll,Control_RunDLL inetcpl.cpl,,4")
    End Sub
    Public Sub preview()
        Try
            Process.Start(Form1.txtboxReturnURL.Text)
        Catch ex As Exception
            Form1.txtboxReturnURL.Text = ex.Message
        End Try
    End Sub
    Public Sub getProxyReg()
        If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Internet Settings", "ProxyServer", Nothing) Is Nothing Then
            Return
        Else
            Dim ProxyServer = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Internet Settings", "ProxyServer", Nothing)
            Dim words As String() = ProxyServer.ToString.Split(":")
            Form1.txtboxProxyServer.Text = words(0)
            Form1.txtboxProxyPort.Text = words(1)
        End If
    End Sub
End Class
