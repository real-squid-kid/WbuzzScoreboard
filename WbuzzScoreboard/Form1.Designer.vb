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
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DeviceListTxt = New System.Windows.Forms.TextBox()
        Me.IDNumberTxt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.WbuzzDebugLbl = New System.Windows.Forms.Label()
        Me.Pad4ButtonLbl = New System.Windows.Forms.Label()
        Me.Pad3ButtonLbl = New System.Windows.Forms.Label()
        Me.Pad2ButtonLbl = New System.Windows.Forms.Label()
        Me.Pad1ButtonLbl = New System.Windows.Forms.Label()
        Me.LED4Chk = New System.Windows.Forms.CheckBox()
        Me.LED3Chk = New System.Windows.Forms.CheckBox()
        Me.LED2Chk = New System.Windows.Forms.CheckBox()
        Me.LED1Chk = New System.Windows.Forms.CheckBox()
        Me.WbuzzInitBtn = New System.Windows.Forms.Button()
        Me.WbuzzStatusLbl = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.WbuzzPoller = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ShowScreen = New System.Windows.Forms.Button()
        Me.ResetBtn = New System.Windows.Forms.Button()
        Me.PressDetect = New System.Windows.Forms.Timer(Me.components)
        Me.Pad1ScoreTxt = New System.Windows.Forms.TextBox()
        Me.Pad2ScoreTxt = New System.Windows.Forms.TextBox()
        Me.Pad3ScoreTxt = New System.Windows.Forms.TextBox()
        Me.Pad4ScoreTxt = New System.Windows.Forms.TextBox()
        Me.Pad1ScoreLbl = New System.Windows.Forms.Label()
        Me.Pad2ScoreLbl = New System.Windows.Forms.Label()
        Me.Pad3ScoreLbl = New System.Windows.Forms.Label()
        Me.Pad4ScoreLbl = New System.Windows.Forms.Label()
        Me.Pad1AddSubBtn = New System.Windows.Forms.Button()
        Me.Pad2AddSubBtn = New System.Windows.Forms.Button()
        Me.Pad3AddSubBtn = New System.Windows.Forms.Button()
        Me.Pad4AddSubBtn = New System.Windows.Forms.Button()
        Me.Pad1ScoreSetBtn = New System.Windows.Forms.Button()
        Me.Pad2ScoreSetBtn = New System.Windows.Forms.Button()
        Me.Pad3ScoreSetBtn = New System.Windows.Forms.Button()
        Me.Pad4ScoreSetBtn = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DeviceListTxt)
        Me.GroupBox1.Controls.Add(Me.IDNumberTxt)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.WbuzzDebugLbl)
        Me.GroupBox1.Controls.Add(Me.Pad4ButtonLbl)
        Me.GroupBox1.Controls.Add(Me.Pad3ButtonLbl)
        Me.GroupBox1.Controls.Add(Me.Pad2ButtonLbl)
        Me.GroupBox1.Controls.Add(Me.Pad1ButtonLbl)
        Me.GroupBox1.Controls.Add(Me.LED4Chk)
        Me.GroupBox1.Controls.Add(Me.LED3Chk)
        Me.GroupBox1.Controls.Add(Me.LED2Chk)
        Me.GroupBox1.Controls.Add(Me.LED1Chk)
        Me.GroupBox1.Controls.Add(Me.WbuzzInitBtn)
        Me.GroupBox1.Controls.Add(Me.WbuzzStatusLbl)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(445, 186)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Status and Debug"
        '
        'DeviceListTxt
        '
        Me.DeviceListTxt.Enabled = False
        Me.DeviceListTxt.Location = New System.Drawing.Point(234, 13)
        Me.DeviceListTxt.Multiline = True
        Me.DeviceListTxt.Name = "DeviceListTxt"
        Me.DeviceListTxt.Size = New System.Drawing.Size(199, 167)
        Me.DeviceListTxt.TabIndex = 8
        '
        'IDNumberTxt
        '
        Me.IDNumberTxt.Location = New System.Drawing.Point(133, 35)
        Me.IDNumberTxt.Name = "IDNumberTxt"
        Me.IDNumberTxt.Size = New System.Drawing.Size(20, 20)
        Me.IDNumberTxt.TabIndex = 7
        Me.IDNumberTxt.Text = "1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(87, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "at ID #"
        '
        'WbuzzDebugLbl
        '
        Me.WbuzzDebugLbl.AutoSize = True
        Me.WbuzzDebugLbl.Location = New System.Drawing.Point(9, 156)
        Me.WbuzzDebugLbl.Name = "WbuzzDebugLbl"
        Me.WbuzzDebugLbl.Size = New System.Drawing.Size(72, 13)
        Me.WbuzzDebugLbl.TabIndex = 5
        Me.WbuzzDebugLbl.Text = "WbuzzDebug"
        '
        'Pad4ButtonLbl
        '
        Me.Pad4ButtonLbl.AutoSize = True
        Me.Pad4ButtonLbl.BackColor = System.Drawing.Color.White
        Me.Pad4ButtonLbl.Location = New System.Drawing.Point(72, 133)
        Me.Pad4ButtonLbl.Name = "Pad4ButtonLbl"
        Me.Pad4ButtonLbl.Size = New System.Drawing.Size(69, 13)
        Me.Pad4ButtonLbl.TabIndex = 4
        Me.Pad4ButtonLbl.Text = "Pad 4 Button"
        '
        'Pad3ButtonLbl
        '
        Me.Pad3ButtonLbl.AutoSize = True
        Me.Pad3ButtonLbl.BackColor = System.Drawing.Color.White
        Me.Pad3ButtonLbl.Location = New System.Drawing.Point(72, 110)
        Me.Pad3ButtonLbl.Name = "Pad3ButtonLbl"
        Me.Pad3ButtonLbl.Size = New System.Drawing.Size(69, 13)
        Me.Pad3ButtonLbl.TabIndex = 4
        Me.Pad3ButtonLbl.Text = "Pad 3 Button"
        '
        'Pad2ButtonLbl
        '
        Me.Pad2ButtonLbl.AutoSize = True
        Me.Pad2ButtonLbl.BackColor = System.Drawing.Color.White
        Me.Pad2ButtonLbl.Location = New System.Drawing.Point(72, 86)
        Me.Pad2ButtonLbl.Name = "Pad2ButtonLbl"
        Me.Pad2ButtonLbl.Size = New System.Drawing.Size(69, 13)
        Me.Pad2ButtonLbl.TabIndex = 4
        Me.Pad2ButtonLbl.Text = "Pad 2 Button"
        '
        'Pad1ButtonLbl
        '
        Me.Pad1ButtonLbl.AutoSize = True
        Me.Pad1ButtonLbl.BackColor = System.Drawing.Color.White
        Me.Pad1ButtonLbl.Location = New System.Drawing.Point(72, 63)
        Me.Pad1ButtonLbl.Name = "Pad1ButtonLbl"
        Me.Pad1ButtonLbl.Size = New System.Drawing.Size(69, 13)
        Me.Pad1ButtonLbl.TabIndex = 4
        Me.Pad1ButtonLbl.Text = "Pad 1 Button"
        '
        'LED4Chk
        '
        Me.LED4Chk.AutoSize = True
        Me.LED4Chk.Enabled = False
        Me.LED4Chk.Location = New System.Drawing.Point(9, 132)
        Me.LED4Chk.Name = "LED4Chk"
        Me.LED4Chk.Size = New System.Drawing.Size(56, 17)
        Me.LED4Chk.TabIndex = 3
        Me.LED4Chk.Text = "LED 4"
        Me.LED4Chk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LED4Chk.UseVisualStyleBackColor = True
        '
        'LED3Chk
        '
        Me.LED3Chk.AutoSize = True
        Me.LED3Chk.Enabled = False
        Me.LED3Chk.Location = New System.Drawing.Point(9, 109)
        Me.LED3Chk.Name = "LED3Chk"
        Me.LED3Chk.Size = New System.Drawing.Size(56, 17)
        Me.LED3Chk.TabIndex = 3
        Me.LED3Chk.Text = "LED 3"
        Me.LED3Chk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LED3Chk.UseVisualStyleBackColor = True
        '
        'LED2Chk
        '
        Me.LED2Chk.AutoSize = True
        Me.LED2Chk.Enabled = False
        Me.LED2Chk.Location = New System.Drawing.Point(9, 86)
        Me.LED2Chk.Name = "LED2Chk"
        Me.LED2Chk.Size = New System.Drawing.Size(56, 17)
        Me.LED2Chk.TabIndex = 3
        Me.LED2Chk.Text = "LED 2"
        Me.LED2Chk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LED2Chk.UseVisualStyleBackColor = True
        '
        'LED1Chk
        '
        Me.LED1Chk.AutoSize = True
        Me.LED1Chk.Enabled = False
        Me.LED1Chk.Location = New System.Drawing.Point(9, 63)
        Me.LED1Chk.Name = "LED1Chk"
        Me.LED1Chk.Size = New System.Drawing.Size(56, 17)
        Me.LED1Chk.TabIndex = 3
        Me.LED1Chk.Text = "LED 1"
        Me.LED1Chk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.LED1Chk.UseVisualStyleBackColor = True
        '
        'WbuzzInitBtn
        '
        Me.WbuzzInitBtn.Location = New System.Drawing.Point(9, 33)
        Me.WbuzzInitBtn.Name = "WbuzzInitBtn"
        Me.WbuzzInitBtn.Size = New System.Drawing.Size(75, 23)
        Me.WbuzzInitBtn.TabIndex = 2
        Me.WbuzzInitBtn.Text = "Initialize"
        Me.WbuzzInitBtn.UseVisualStyleBackColor = True
        '
        'WbuzzStatusLbl
        '
        Me.WbuzzStatusLbl.AutoSize = True
        Me.WbuzzStatusLbl.Location = New System.Drawing.Point(87, 16)
        Me.WbuzzStatusLbl.Name = "WbuzzStatusLbl"
        Me.WbuzzStatusLbl.Size = New System.Drawing.Size(84, 13)
        Me.WbuzzStatusLbl.TabIndex = 1
        Me.WbuzzStatusLbl.Text = "WbuzzStatusLbl"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Wbuzz status:"
        '
        'WbuzzPoller
        '
        Me.WbuzzPoller.Interval = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 372)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(374, 52)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "WbuzzScoreboard 0.11" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Original work by Vasily ""SquidKid"" Macrov" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Distributed unde" &
    "r GPL v3 license." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Using AForge library under LGPL v3 license. More: http://www." &
    "aforgenet.com"
        '
        'ShowScreen
        '
        Me.ShowScreen.Location = New System.Drawing.Point(13, 206)
        Me.ShowScreen.Name = "ShowScreen"
        Me.ShowScreen.Size = New System.Drawing.Size(114, 44)
        Me.ShowScreen.TabIndex = 2
        Me.ShowScreen.Text = "Show Scoreboard"
        Me.ShowScreen.UseVisualStyleBackColor = True
        '
        'ResetBtn
        '
        Me.ResetBtn.Location = New System.Drawing.Point(134, 206)
        Me.ResetBtn.Name = "ResetBtn"
        Me.ResetBtn.Size = New System.Drawing.Size(75, 23)
        Me.ResetBtn.TabIndex = 3
        Me.ResetBtn.Text = "Reset"
        Me.ResetBtn.UseVisualStyleBackColor = True
        '
        'PressDetect
        '
        Me.PressDetect.Interval = 10
        '
        'Pad1ScoreTxt
        '
        Me.Pad1ScoreTxt.Location = New System.Drawing.Point(13, 279)
        Me.Pad1ScoreTxt.Name = "Pad1ScoreTxt"
        Me.Pad1ScoreTxt.Size = New System.Drawing.Size(100, 20)
        Me.Pad1ScoreTxt.TabIndex = 4
        Me.Pad1ScoreTxt.Text = "0"
        '
        'Pad2ScoreTxt
        '
        Me.Pad2ScoreTxt.Location = New System.Drawing.Point(119, 279)
        Me.Pad2ScoreTxt.Name = "Pad2ScoreTxt"
        Me.Pad2ScoreTxt.Size = New System.Drawing.Size(100, 20)
        Me.Pad2ScoreTxt.TabIndex = 4
        Me.Pad2ScoreTxt.Text = "0"
        '
        'Pad3ScoreTxt
        '
        Me.Pad3ScoreTxt.Location = New System.Drawing.Point(225, 279)
        Me.Pad3ScoreTxt.Name = "Pad3ScoreTxt"
        Me.Pad3ScoreTxt.Size = New System.Drawing.Size(100, 20)
        Me.Pad3ScoreTxt.TabIndex = 4
        Me.Pad3ScoreTxt.Text = "0"
        '
        'Pad4ScoreTxt
        '
        Me.Pad4ScoreTxt.Location = New System.Drawing.Point(331, 279)
        Me.Pad4ScoreTxt.Name = "Pad4ScoreTxt"
        Me.Pad4ScoreTxt.Size = New System.Drawing.Size(100, 20)
        Me.Pad4ScoreTxt.TabIndex = 4
        Me.Pad4ScoreTxt.Text = "0"
        '
        'Pad1ScoreLbl
        '
        Me.Pad1ScoreLbl.AutoSize = True
        Me.Pad1ScoreLbl.Location = New System.Drawing.Point(12, 263)
        Me.Pad1ScoreLbl.Name = "Pad1ScoreLbl"
        Me.Pad1ScoreLbl.Size = New System.Drawing.Size(94, 13)
        Me.Pad1ScoreLbl.TabIndex = 5
        Me.Pad1ScoreLbl.Text = "Pad 1: Pad1Score"
        '
        'Pad2ScoreLbl
        '
        Me.Pad2ScoreLbl.AutoSize = True
        Me.Pad2ScoreLbl.Location = New System.Drawing.Point(116, 263)
        Me.Pad2ScoreLbl.Name = "Pad2ScoreLbl"
        Me.Pad2ScoreLbl.Size = New System.Drawing.Size(94, 13)
        Me.Pad2ScoreLbl.TabIndex = 5
        Me.Pad2ScoreLbl.Text = "Pad 2: Pad2Score"
        '
        'Pad3ScoreLbl
        '
        Me.Pad3ScoreLbl.AutoSize = True
        Me.Pad3ScoreLbl.Location = New System.Drawing.Point(222, 263)
        Me.Pad3ScoreLbl.Name = "Pad3ScoreLbl"
        Me.Pad3ScoreLbl.Size = New System.Drawing.Size(94, 13)
        Me.Pad3ScoreLbl.TabIndex = 5
        Me.Pad3ScoreLbl.Text = "Pad 3: Pad3Score"
        '
        'Pad4ScoreLbl
        '
        Me.Pad4ScoreLbl.AutoSize = True
        Me.Pad4ScoreLbl.Location = New System.Drawing.Point(328, 263)
        Me.Pad4ScoreLbl.Name = "Pad4ScoreLbl"
        Me.Pad4ScoreLbl.Size = New System.Drawing.Size(94, 13)
        Me.Pad4ScoreLbl.TabIndex = 5
        Me.Pad4ScoreLbl.Text = "Pad 4: Pad4Score"
        '
        'Pad1AddSubBtn
        '
        Me.Pad1AddSubBtn.Location = New System.Drawing.Point(13, 306)
        Me.Pad1AddSubBtn.Name = "Pad1AddSubBtn"
        Me.Pad1AddSubBtn.Size = New System.Drawing.Size(100, 23)
        Me.Pad1AddSubBtn.TabIndex = 6
        Me.Pad1AddSubBtn.Text = "Add/Subtract"
        Me.Pad1AddSubBtn.UseVisualStyleBackColor = True
        '
        'Pad2AddSubBtn
        '
        Me.Pad2AddSubBtn.Location = New System.Drawing.Point(119, 306)
        Me.Pad2AddSubBtn.Name = "Pad2AddSubBtn"
        Me.Pad2AddSubBtn.Size = New System.Drawing.Size(100, 23)
        Me.Pad2AddSubBtn.TabIndex = 6
        Me.Pad2AddSubBtn.Text = "Add/Subtract"
        Me.Pad2AddSubBtn.UseVisualStyleBackColor = True
        '
        'Pad3AddSubBtn
        '
        Me.Pad3AddSubBtn.Location = New System.Drawing.Point(225, 306)
        Me.Pad3AddSubBtn.Name = "Pad3AddSubBtn"
        Me.Pad3AddSubBtn.Size = New System.Drawing.Size(100, 23)
        Me.Pad3AddSubBtn.TabIndex = 6
        Me.Pad3AddSubBtn.Text = "Add/Subtract"
        Me.Pad3AddSubBtn.UseVisualStyleBackColor = True
        '
        'Pad4AddSubBtn
        '
        Me.Pad4AddSubBtn.Location = New System.Drawing.Point(331, 306)
        Me.Pad4AddSubBtn.Name = "Pad4AddSubBtn"
        Me.Pad4AddSubBtn.Size = New System.Drawing.Size(100, 23)
        Me.Pad4AddSubBtn.TabIndex = 6
        Me.Pad4AddSubBtn.Text = "Add/Subtract"
        Me.Pad4AddSubBtn.UseVisualStyleBackColor = True
        '
        'Pad1ScoreSetBtn
        '
        Me.Pad1ScoreSetBtn.Location = New System.Drawing.Point(13, 335)
        Me.Pad1ScoreSetBtn.Name = "Pad1ScoreSetBtn"
        Me.Pad1ScoreSetBtn.Size = New System.Drawing.Size(100, 23)
        Me.Pad1ScoreSetBtn.TabIndex = 6
        Me.Pad1ScoreSetBtn.Text = "Set"
        Me.Pad1ScoreSetBtn.UseVisualStyleBackColor = True
        '
        'Pad2ScoreSetBtn
        '
        Me.Pad2ScoreSetBtn.Location = New System.Drawing.Point(119, 335)
        Me.Pad2ScoreSetBtn.Name = "Pad2ScoreSetBtn"
        Me.Pad2ScoreSetBtn.Size = New System.Drawing.Size(100, 23)
        Me.Pad2ScoreSetBtn.TabIndex = 6
        Me.Pad2ScoreSetBtn.Text = "Set"
        Me.Pad2ScoreSetBtn.UseVisualStyleBackColor = True
        '
        'Pad3ScoreSetBtn
        '
        Me.Pad3ScoreSetBtn.Location = New System.Drawing.Point(225, 335)
        Me.Pad3ScoreSetBtn.Name = "Pad3ScoreSetBtn"
        Me.Pad3ScoreSetBtn.Size = New System.Drawing.Size(100, 23)
        Me.Pad3ScoreSetBtn.TabIndex = 6
        Me.Pad3ScoreSetBtn.Text = "Set"
        Me.Pad3ScoreSetBtn.UseVisualStyleBackColor = True
        '
        'Pad4ScoreSetBtn
        '
        Me.Pad4ScoreSetBtn.Location = New System.Drawing.Point(331, 335)
        Me.Pad4ScoreSetBtn.Name = "Pad4ScoreSetBtn"
        Me.Pad4ScoreSetBtn.Size = New System.Drawing.Size(100, 23)
        Me.Pad4ScoreSetBtn.TabIndex = 6
        Me.Pad4ScoreSetBtn.Text = "Set"
        Me.Pad4ScoreSetBtn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(466, 368)
        Me.Controls.Add(Me.Pad4AddSubBtn)
        Me.Controls.Add(Me.Pad3AddSubBtn)
        Me.Controls.Add(Me.Pad2AddSubBtn)
        Me.Controls.Add(Me.Pad4ScoreSetBtn)
        Me.Controls.Add(Me.Pad3ScoreSetBtn)
        Me.Controls.Add(Me.Pad2ScoreSetBtn)
        Me.Controls.Add(Me.Pad1ScoreSetBtn)
        Me.Controls.Add(Me.Pad1AddSubBtn)
        Me.Controls.Add(Me.Pad4ScoreLbl)
        Me.Controls.Add(Me.Pad3ScoreLbl)
        Me.Controls.Add(Me.Pad2ScoreLbl)
        Me.Controls.Add(Me.Pad1ScoreLbl)
        Me.Controls.Add(Me.Pad4ScoreTxt)
        Me.Controls.Add(Me.Pad3ScoreTxt)
        Me.Controls.Add(Me.Pad2ScoreTxt)
        Me.Controls.Add(Me.Pad1ScoreTxt)
        Me.Controls.Add(Me.ResetBtn)
        Me.Controls.Add(Me.ShowScreen)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Control Board"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Pad4ButtonLbl As Label
    Friend WithEvents Pad3ButtonLbl As Label
    Friend WithEvents Pad2ButtonLbl As Label
    Friend WithEvents Pad1ButtonLbl As Label
    Friend WithEvents LED4Chk As CheckBox
    Friend WithEvents LED3Chk As CheckBox
    Friend WithEvents LED2Chk As CheckBox
    Friend WithEvents LED1Chk As CheckBox
    Friend WithEvents WbuzzInitBtn As Button
    Friend WithEvents WbuzzStatusLbl As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents WbuzzPoller As Timer
    Friend WithEvents WbuzzDebugLbl As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents IDNumberTxt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DeviceListTxt As TextBox
    Friend WithEvents ShowScreen As Button
    Friend WithEvents ResetBtn As Button
    Friend WithEvents PressDetect As Timer
    Friend WithEvents Pad1ScoreTxt As TextBox
    Friend WithEvents Pad2ScoreTxt As TextBox
    Friend WithEvents Pad3ScoreTxt As TextBox
    Friend WithEvents Pad4ScoreTxt As TextBox
    Friend WithEvents Pad1ScoreLbl As Label
    Friend WithEvents Pad2ScoreLbl As Label
    Friend WithEvents Pad3ScoreLbl As Label
    Friend WithEvents Pad4ScoreLbl As Label
    Friend WithEvents Pad1AddSubBtn As Button
    Friend WithEvents Pad2AddSubBtn As Button
    Friend WithEvents Pad3AddSubBtn As Button
    Friend WithEvents Pad4AddSubBtn As Button
    Friend WithEvents Pad1ScoreSetBtn As Button
    Friend WithEvents Pad2ScoreSetBtn As Button
    Friend WithEvents Pad3ScoreSetBtn As Button
    Friend WithEvents Pad4ScoreSetBtn As Button
End Class
