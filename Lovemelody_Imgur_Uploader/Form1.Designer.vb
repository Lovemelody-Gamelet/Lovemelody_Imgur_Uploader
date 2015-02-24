<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.txtboxImagePath = New System.Windows.Forms.TextBox()
        Me.btnUpload = New System.Windows.Forms.Button()
        Me.txtboxReturnURL = New System.Windows.Forms.TextBox()
        Me.pbImagePreview = New System.Windows.Forms.PictureBox()
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.txtboxProxyServer = New System.Windows.Forms.TextBox()
        Me.txtboxProxyPort = New System.Windows.Forms.TextBox()
        Me.txtboxProxyUsername = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnLookProxy = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtboxProxyPassword = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnPreview = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.WhatIsClientID = New System.Windows.Forms.LinkLabel()
        Me.txtboxCustomClientID = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.JamiePhanLink = New System.Windows.Forms.LinkLabel()
        Me.comboxLang = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LovemelodyLink = New System.Windows.Forms.LinkLabel()
        Me.btnReadProxyReg = New System.Windows.Forms.Button()
        CType(Me.pbImagePreview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtboxImagePath
        '
        Me.txtboxImagePath.Location = New System.Drawing.Point(85, 12)
        Me.txtboxImagePath.Name = "txtboxImagePath"
        Me.txtboxImagePath.ReadOnly = True
        Me.txtboxImagePath.Size = New System.Drawing.Size(245, 20)
        Me.txtboxImagePath.TabIndex = 0
        Me.txtboxImagePath.Text = "http://i.imgur.com/AQbJxMJ.png"
        '
        'btnUpload
        '
        Me.btnUpload.BackColor = System.Drawing.Color.Chartreuse
        Me.btnUpload.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpload.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpload.Location = New System.Drawing.Point(437, 212)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(517, 55)
        Me.btnUpload.TabIndex = 1
        Me.btnUpload.Text = "Upload"
        Me.btnUpload.UseVisualStyleBackColor = False
        '
        'txtboxReturnURL
        '
        Me.txtboxReturnURL.Location = New System.Drawing.Point(10, 47)
        Me.txtboxReturnURL.Name = "txtboxReturnURL"
        Me.txtboxReturnURL.Size = New System.Drawing.Size(429, 20)
        Me.txtboxReturnURL.TabIndex = 2
        Me.txtboxReturnURL.Text = "http://i.imgur.com/AQbJxMJ.png"
        '
        'pbImagePreview
        '
        Me.pbImagePreview.Image = Global.Lovemelody_Imgur_Uploader.My.Resources.Resources.Lovemelody
        Me.pbImagePreview.Location = New System.Drawing.Point(4, 46)
        Me.pbImagePreview.Name = "pbImagePreview"
        Me.pbImagePreview.Size = New System.Drawing.Size(425, 344)
        Me.pbImagePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbImagePreview.TabIndex = 4
        Me.pbImagePreview.TabStop = False
        '
        'btnOpen
        '
        Me.btnOpen.BackColor = System.Drawing.Color.Red
        Me.btnOpen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOpen.Location = New System.Drawing.Point(336, 10)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(92, 25)
        Me.btnOpen.TabIndex = 5
        Me.btnOpen.Text = "Open Image"
        Me.btnOpen.UseVisualStyleBackColor = False
        '
        'txtboxProxyServer
        '
        Me.txtboxProxyServer.AcceptsTab = True
        Me.txtboxProxyServer.Location = New System.Drawing.Point(66, 25)
        Me.txtboxProxyServer.Name = "txtboxProxyServer"
        Me.txtboxProxyServer.Size = New System.Drawing.Size(100, 20)
        Me.txtboxProxyServer.TabIndex = 7
        '
        'txtboxProxyPort
        '
        Me.txtboxProxyPort.AcceptsTab = True
        Me.txtboxProxyPort.Location = New System.Drawing.Point(219, 25)
        Me.txtboxProxyPort.Name = "txtboxProxyPort"
        Me.txtboxProxyPort.Size = New System.Drawing.Size(39, 20)
        Me.txtboxProxyPort.TabIndex = 8
        '
        'txtboxProxyUsername
        '
        Me.txtboxProxyUsername.AcceptsTab = True
        Me.txtboxProxyUsername.Location = New System.Drawing.Point(92, 66)
        Me.txtboxProxyUsername.Name = "txtboxProxyUsername"
        Me.txtboxProxyUsername.Size = New System.Drawing.Size(101, 20)
        Me.txtboxProxyUsername.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Server :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(181, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Port :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Username :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnReadProxyReg)
        Me.GroupBox1.Controls.Add(Me.btnLookProxy)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtboxProxyPassword)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtboxProxyPort)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtboxProxyServer)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtboxProxyUsername)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(437, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(515, 111)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Proxy Connection (Organisation, School, Collage may required), If not required, j" & _
    "ust leave blank)"
        '
        'btnLookProxy
        '
        Me.btnLookProxy.Location = New System.Drawing.Point(301, 18)
        Me.btnLookProxy.Name = "btnLookProxy"
        Me.btnLookProxy.Size = New System.Drawing.Size(196, 23)
        Me.btnLookProxy.TabIndex = 16
        Me.btnLookProxy.Text = "Look up Proxy Settings [LAN Settings]"
        Me.btnLookProxy.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(371, 77)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "ClickShowPassword"
        '
        'txtboxProxyPassword
        '
        Me.txtboxProxyPassword.AcceptsTab = True
        Me.txtboxProxyPassword.Location = New System.Drawing.Point(255, 66)
        Me.txtboxProxyPassword.Name = "txtboxProxyPassword"
        Me.txtboxProxyPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtboxProxyPassword.Size = New System.Drawing.Size(100, 20)
        Me.txtboxProxyPassword.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(199, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Password :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(149, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Return URL / Error Message :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Image Path :"
        '
        'btnPreview
        '
        Me.btnPreview.Location = New System.Drawing.Point(444, 45)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(65, 23)
        Me.btnPreview.TabIndex = 16
        Me.btnPreview.Text = "Preview"
        Me.btnPreview.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.WhatIsClientID)
        Me.GroupBox2.Controls.Add(Me.txtboxCustomClientID)
        Me.GroupBox2.Location = New System.Drawing.Point(437, 126)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(515, 77)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Custom Imgur Client ID (If none just leave blank, Default use Lovemelody's Client" & _
    " ID)"
        '
        'WhatIsClientID
        '
        Me.WhatIsClientID.AutoSize = True
        Me.WhatIsClientID.Location = New System.Drawing.Point(417, 35)
        Me.WhatIsClientID.Name = "WhatIsClientID"
        Me.WhatIsClientID.Size = New System.Drawing.Size(92, 13)
        Me.WhatIsClientID.TabIndex = 1
        Me.WhatIsClientID.TabStop = True
        Me.WhatIsClientID.Text = "What is Client ID?"
        '
        'txtboxCustomClientID
        '
        Me.txtboxCustomClientID.Location = New System.Drawing.Point(9, 33)
        Me.txtboxCustomClientID.Name = "txtboxCustomClientID"
        Me.txtboxCustomClientID.Size = New System.Drawing.Size(402, 20)
        Me.txtboxCustomClientID.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.txtboxReturnURL)
        Me.GroupBox3.Controls.Add(Me.btnPreview)
        Me.GroupBox3.Location = New System.Drawing.Point(437, 273)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(515, 91)
        Me.GroupBox3.TabIndex = 18
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Return Message"
        '
        'JamiePhanLink
        '
        Me.JamiePhanLink.AutoSize = True
        Me.JamiePhanLink.Location = New System.Drawing.Point(599, 374)
        Me.JamiePhanLink.Name = "JamiePhanLink"
        Me.JamiePhanLink.Size = New System.Drawing.Size(62, 13)
        Me.JamiePhanLink.TabIndex = 24
        Me.JamiePhanLink.TabStop = True
        Me.JamiePhanLink.Text = "Jamie Phan"
        '
        'comboxLang
        '
        Me.comboxLang.FormattingEnabled = True
        Me.comboxLang.Items.AddRange(New Object() {"English", "繁體中文"})
        Me.comboxLang.Location = New System.Drawing.Point(837, 371)
        Me.comboxLang.Name = "comboxLang"
        Me.comboxLang.Size = New System.Drawing.Size(121, 21)
        Me.comboxLang.TabIndex = 21
        Me.comboxLang.Text = "繁體中文"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(437, 374)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 13)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Program Author :"
        '
        'LovemelodyLink
        '
        Me.LovemelodyLink.AutoSize = True
        Me.LovemelodyLink.Location = New System.Drawing.Point(529, 374)
        Me.LovemelodyLink.Name = "LovemelodyLink"
        Me.LovemelodyLink.Size = New System.Drawing.Size(64, 13)
        Me.LovemelodyLink.TabIndex = 23
        Me.LovemelodyLink.TabStop = True
        Me.LovemelodyLink.Text = "Lovemelody"
        '
        'btnReadProxyReg
        '
        Me.btnReadProxyReg.Location = New System.Drawing.Point(367, 47)
        Me.btnReadProxyReg.Name = "btnReadProxyReg"
        Me.btnReadProxyReg.Size = New System.Drawing.Size(130, 23)
        Me.btnReadProxyReg.TabIndex = 17
        Me.btnReadProxyReg.Text = "Get Proxy Automatically"
        Me.btnReadProxyReg.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(961, 396)
        Me.Controls.Add(Me.JamiePhanLink)
        Me.Controls.Add(Me.LovemelodyLink)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.comboxLang)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnUpload)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnOpen)
        Me.Controls.Add(Me.pbImagePreview)
        Me.Controls.Add(Me.txtboxImagePath)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "戀愛の旋律♪ Imgur 圖片上傳器 - http://goo.gl/E5kTUH"
        CType(Me.pbImagePreview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtboxImagePath As System.Windows.Forms.TextBox
    Friend WithEvents btnUpload As System.Windows.Forms.Button
    Friend WithEvents txtboxReturnURL As System.Windows.Forms.TextBox
    Friend WithEvents pbImagePreview As System.Windows.Forms.PictureBox
    Friend WithEvents btnOpen As System.Windows.Forms.Button
    Friend WithEvents txtboxProxyServer As System.Windows.Forms.TextBox
    Friend WithEvents txtboxProxyPort As System.Windows.Forms.TextBox
    Friend WithEvents txtboxProxyUsername As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtboxProxyPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnLookProxy As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnPreview As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents WhatIsClientID As System.Windows.Forms.LinkLabel
    Friend WithEvents txtboxCustomClientID As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents JamiePhanLink As System.Windows.Forms.LinkLabel
    Friend WithEvents comboxLang As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents LovemelodyLink As System.Windows.Forms.LinkLabel
    Friend WithEvents btnReadProxyReg As System.Windows.Forms.Button

End Class
