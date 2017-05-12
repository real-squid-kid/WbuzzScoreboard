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
        Me.WbuzzBlinker = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ResetVotingBtn = New System.Windows.Forms.Button()
        Me.Vote4Btn = New System.Windows.Forms.Button()
        Me.Vote3Btn = New System.Windows.Forms.Button()
        Me.Vote2Btn = New System.Windows.Forms.Button()
        Me.Vote1Btn = New System.Windows.Forms.Button()
        Me.VoteValueLbl = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Pad4VoteLbl = New System.Windows.Forms.Label()
        Me.Pad3VoteLbl = New System.Windows.Forms.Label()
        Me.Pad2VoteLbl = New System.Windows.Forms.Label()
        Me.Pad1VoteLbl = New System.Windows.Forms.Label()
        Me.Pad1NameTxt = New System.Windows.Forms.TextBox()
        Me.Pad2NameTxt = New System.Windows.Forms.TextBox()
        Me.Pad3NameTxt = New System.Windows.Forms.TextBox()
        Me.Pad4NameTxt = New System.Windows.Forms.TextBox()
        Me.BuzzActiveChk = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
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
        Me.GroupBox1.Controls.Add(Me.WbuzzInitBtn)
        Me.GroupBox1.Controls.Add(Me.WbuzzStatusLbl)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(389, 186)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Status and Debug"
        '
        'DeviceListTxt
        '
        Me.DeviceListTxt.Enabled = False
        Me.DeviceListTxt.Location = New System.Drawing.Point(177, 13)
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
        Me.Pad4ButtonLbl.Location = New System.Drawing.Point(12, 133)
        Me.Pad4ButtonLbl.Name = "Pad4ButtonLbl"
        Me.Pad4ButtonLbl.Size = New System.Drawing.Size(69, 13)
        Me.Pad4ButtonLbl.TabIndex = 4
        Me.Pad4ButtonLbl.Text = "Pad 4 Button"
        '
        'Pad3ButtonLbl
        '
        Me.Pad3ButtonLbl.AutoSize = True
        Me.Pad3ButtonLbl.BackColor = System.Drawing.Color.White
        Me.Pad3ButtonLbl.Location = New System.Drawing.Point(12, 110)
        Me.Pad3ButtonLbl.Name = "Pad3ButtonLbl"
        Me.Pad3ButtonLbl.Size = New System.Drawing.Size(69, 13)
        Me.Pad3ButtonLbl.TabIndex = 4
        Me.Pad3ButtonLbl.Text = "Pad 3 Button"
        '
        'Pad2ButtonLbl
        '
        Me.Pad2ButtonLbl.AutoSize = True
        Me.Pad2ButtonLbl.BackColor = System.Drawing.Color.White
        Me.Pad2ButtonLbl.Location = New System.Drawing.Point(12, 86)
        Me.Pad2ButtonLbl.Name = "Pad2ButtonLbl"
        Me.Pad2ButtonLbl.Size = New System.Drawing.Size(69, 13)
        Me.Pad2ButtonLbl.TabIndex = 4
        Me.Pad2ButtonLbl.Text = "Pad 2 Button"
        '
        'Pad1ButtonLbl
        '
        Me.Pad1ButtonLbl.AutoSize = True
        Me.Pad1ButtonLbl.BackColor = System.Drawing.Color.White
        Me.Pad1ButtonLbl.Location = New System.Drawing.Point(12, 63)
        Me.Pad1ButtonLbl.Name = "Pad1ButtonLbl"
        Me.Pad1ButtonLbl.Size = New System.Drawing.Size(69, 13)
        Me.Pad1ButtonLbl.TabIndex = 4
        Me.Pad1ButtonLbl.Text = "Pad 1 Button"
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
        Me.Label2.Location = New System.Drawing.Point(12, 411)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(374, 52)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "WbuzzScoreboard 0.2.2" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Original work by Vasily ""SquidKid"" Makrov" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Distributed und" &
    "er GPL v3 license." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Using AForge library under LGPL v3 license. More: http://www" &
    ".aforgenet.com"
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
        Me.PressDetect.Interval = 20
        '
        'Pad1ScoreTxt
        '
        Me.Pad1ScoreTxt.Location = New System.Drawing.Point(15, 319)
        Me.Pad1ScoreTxt.Name = "Pad1ScoreTxt"
        Me.Pad1ScoreTxt.Size = New System.Drawing.Size(100, 20)
        Me.Pad1ScoreTxt.TabIndex = 4
        Me.Pad1ScoreTxt.Text = "0"
        '
        'Pad2ScoreTxt
        '
        Me.Pad2ScoreTxt.Location = New System.Drawing.Point(121, 319)
        Me.Pad2ScoreTxt.Name = "Pad2ScoreTxt"
        Me.Pad2ScoreTxt.Size = New System.Drawing.Size(100, 20)
        Me.Pad2ScoreTxt.TabIndex = 4
        Me.Pad2ScoreTxt.Text = "0"
        '
        'Pad3ScoreTxt
        '
        Me.Pad3ScoreTxt.Location = New System.Drawing.Point(227, 319)
        Me.Pad3ScoreTxt.Name = "Pad3ScoreTxt"
        Me.Pad3ScoreTxt.Size = New System.Drawing.Size(100, 20)
        Me.Pad3ScoreTxt.TabIndex = 4
        Me.Pad3ScoreTxt.Text = "0"
        '
        'Pad4ScoreTxt
        '
        Me.Pad4ScoreTxt.Location = New System.Drawing.Point(333, 319)
        Me.Pad4ScoreTxt.Name = "Pad4ScoreTxt"
        Me.Pad4ScoreTxt.Size = New System.Drawing.Size(100, 20)
        Me.Pad4ScoreTxt.TabIndex = 4
        Me.Pad4ScoreTxt.Text = "0"
        '
        'Pad1ScoreLbl
        '
        Me.Pad1ScoreLbl.AutoSize = True
        Me.Pad1ScoreLbl.Location = New System.Drawing.Point(14, 303)
        Me.Pad1ScoreLbl.Name = "Pad1ScoreLbl"
        Me.Pad1ScoreLbl.Size = New System.Drawing.Size(94, 13)
        Me.Pad1ScoreLbl.TabIndex = 5
        Me.Pad1ScoreLbl.Text = "Pad 1: Pad1Score"
        '
        'Pad2ScoreLbl
        '
        Me.Pad2ScoreLbl.AutoSize = True
        Me.Pad2ScoreLbl.Location = New System.Drawing.Point(118, 303)
        Me.Pad2ScoreLbl.Name = "Pad2ScoreLbl"
        Me.Pad2ScoreLbl.Size = New System.Drawing.Size(94, 13)
        Me.Pad2ScoreLbl.TabIndex = 5
        Me.Pad2ScoreLbl.Text = "Pad 2: Pad2Score"
        '
        'Pad3ScoreLbl
        '
        Me.Pad3ScoreLbl.AutoSize = True
        Me.Pad3ScoreLbl.Location = New System.Drawing.Point(224, 303)
        Me.Pad3ScoreLbl.Name = "Pad3ScoreLbl"
        Me.Pad3ScoreLbl.Size = New System.Drawing.Size(94, 13)
        Me.Pad3ScoreLbl.TabIndex = 5
        Me.Pad3ScoreLbl.Text = "Pad 3: Pad3Score"
        '
        'Pad4ScoreLbl
        '
        Me.Pad4ScoreLbl.AutoSize = True
        Me.Pad4ScoreLbl.Location = New System.Drawing.Point(330, 303)
        Me.Pad4ScoreLbl.Name = "Pad4ScoreLbl"
        Me.Pad4ScoreLbl.Size = New System.Drawing.Size(94, 13)
        Me.Pad4ScoreLbl.TabIndex = 5
        Me.Pad4ScoreLbl.Text = "Pad 4: Pad4Score"
        '
        'Pad1AddSubBtn
        '
        Me.Pad1AddSubBtn.Location = New System.Drawing.Point(15, 346)
        Me.Pad1AddSubBtn.Name = "Pad1AddSubBtn"
        Me.Pad1AddSubBtn.Size = New System.Drawing.Size(100, 23)
        Me.Pad1AddSubBtn.TabIndex = 6
        Me.Pad1AddSubBtn.Text = "Add/Subtract"
        Me.Pad1AddSubBtn.UseVisualStyleBackColor = True
        '
        'Pad2AddSubBtn
        '
        Me.Pad2AddSubBtn.Location = New System.Drawing.Point(121, 346)
        Me.Pad2AddSubBtn.Name = "Pad2AddSubBtn"
        Me.Pad2AddSubBtn.Size = New System.Drawing.Size(100, 23)
        Me.Pad2AddSubBtn.TabIndex = 6
        Me.Pad2AddSubBtn.Text = "Add/Subtract"
        Me.Pad2AddSubBtn.UseVisualStyleBackColor = True
        '
        'Pad3AddSubBtn
        '
        Me.Pad3AddSubBtn.Location = New System.Drawing.Point(227, 346)
        Me.Pad3AddSubBtn.Name = "Pad3AddSubBtn"
        Me.Pad3AddSubBtn.Size = New System.Drawing.Size(100, 23)
        Me.Pad3AddSubBtn.TabIndex = 6
        Me.Pad3AddSubBtn.Text = "Add/Subtract"
        Me.Pad3AddSubBtn.UseVisualStyleBackColor = True
        '
        'Pad4AddSubBtn
        '
        Me.Pad4AddSubBtn.Location = New System.Drawing.Point(333, 346)
        Me.Pad4AddSubBtn.Name = "Pad4AddSubBtn"
        Me.Pad4AddSubBtn.Size = New System.Drawing.Size(100, 23)
        Me.Pad4AddSubBtn.TabIndex = 6
        Me.Pad4AddSubBtn.Text = "Add/Subtract"
        Me.Pad4AddSubBtn.UseVisualStyleBackColor = True
        '
        'Pad1ScoreSetBtn
        '
        Me.Pad1ScoreSetBtn.Location = New System.Drawing.Point(15, 375)
        Me.Pad1ScoreSetBtn.Name = "Pad1ScoreSetBtn"
        Me.Pad1ScoreSetBtn.Size = New System.Drawing.Size(100, 23)
        Me.Pad1ScoreSetBtn.TabIndex = 6
        Me.Pad1ScoreSetBtn.Text = "Set"
        Me.Pad1ScoreSetBtn.UseVisualStyleBackColor = True
        '
        'Pad2ScoreSetBtn
        '
        Me.Pad2ScoreSetBtn.Location = New System.Drawing.Point(121, 375)
        Me.Pad2ScoreSetBtn.Name = "Pad2ScoreSetBtn"
        Me.Pad2ScoreSetBtn.Size = New System.Drawing.Size(100, 23)
        Me.Pad2ScoreSetBtn.TabIndex = 6
        Me.Pad2ScoreSetBtn.Text = "Set"
        Me.Pad2ScoreSetBtn.UseVisualStyleBackColor = True
        '
        'Pad3ScoreSetBtn
        '
        Me.Pad3ScoreSetBtn.Location = New System.Drawing.Point(227, 375)
        Me.Pad3ScoreSetBtn.Name = "Pad3ScoreSetBtn"
        Me.Pad3ScoreSetBtn.Size = New System.Drawing.Size(100, 23)
        Me.Pad3ScoreSetBtn.TabIndex = 6
        Me.Pad3ScoreSetBtn.Text = "Set"
        Me.Pad3ScoreSetBtn.UseVisualStyleBackColor = True
        '
        'Pad4ScoreSetBtn
        '
        Me.Pad4ScoreSetBtn.Location = New System.Drawing.Point(333, 375)
        Me.Pad4ScoreSetBtn.Name = "Pad4ScoreSetBtn"
        Me.Pad4ScoreSetBtn.Size = New System.Drawing.Size(100, 23)
        Me.Pad4ScoreSetBtn.TabIndex = 6
        Me.Pad4ScoreSetBtn.Text = "Set"
        Me.Pad4ScoreSetBtn.UseVisualStyleBackColor = True
        '
        'WbuzzBlinker
        '
        Me.WbuzzBlinker.Interval = 250
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ResetVotingBtn)
        Me.GroupBox2.Controls.Add(Me.Vote4Btn)
        Me.GroupBox2.Controls.Add(Me.Vote3Btn)
        Me.GroupBox2.Controls.Add(Me.Vote2Btn)
        Me.GroupBox2.Controls.Add(Me.Vote1Btn)
        Me.GroupBox2.Controls.Add(Me.VoteValueLbl)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Pad4VoteLbl)
        Me.GroupBox2.Controls.Add(Me.Pad3VoteLbl)
        Me.GroupBox2.Controls.Add(Me.Pad2VoteLbl)
        Me.GroupBox2.Controls.Add(Me.Pad1VoteLbl)
        Me.GroupBox2.Location = New System.Drawing.Point(408, 13)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(187, 186)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Voting"
        '
        'ResetVotingBtn
        '
        Me.ResetVotingBtn.Location = New System.Drawing.Point(106, 15)
        Me.ResetVotingBtn.Name = "ResetVotingBtn"
        Me.ResetVotingBtn.Size = New System.Drawing.Size(75, 23)
        Me.ResetVotingBtn.TabIndex = 10
        Me.ResetVotingBtn.Text = "Reset voting"
        Me.ResetVotingBtn.UseVisualStyleBackColor = True
        '
        'Vote4Btn
        '
        Me.Vote4Btn.Location = New System.Drawing.Point(130, 156)
        Me.Vote4Btn.Name = "Vote4Btn"
        Me.Vote4Btn.Size = New System.Drawing.Size(34, 23)
        Me.Vote4Btn.TabIndex = 9
        Me.Vote4Btn.Text = "4"
        Me.Vote4Btn.UseVisualStyleBackColor = True
        '
        'Vote3Btn
        '
        Me.Vote3Btn.Location = New System.Drawing.Point(90, 156)
        Me.Vote3Btn.Name = "Vote3Btn"
        Me.Vote3Btn.Size = New System.Drawing.Size(34, 23)
        Me.Vote3Btn.TabIndex = 8
        Me.Vote3Btn.Text = "3"
        Me.Vote3Btn.UseVisualStyleBackColor = True
        '
        'Vote2Btn
        '
        Me.Vote2Btn.Location = New System.Drawing.Point(50, 156)
        Me.Vote2Btn.Name = "Vote2Btn"
        Me.Vote2Btn.Size = New System.Drawing.Size(34, 23)
        Me.Vote2Btn.TabIndex = 7
        Me.Vote2Btn.Text = "2"
        Me.Vote2Btn.UseVisualStyleBackColor = True
        '
        'Vote1Btn
        '
        Me.Vote1Btn.Location = New System.Drawing.Point(10, 156)
        Me.Vote1Btn.Name = "Vote1Btn"
        Me.Vote1Btn.Size = New System.Drawing.Size(34, 23)
        Me.Vote1Btn.TabIndex = 6
        Me.Vote1Btn.Text = "1"
        Me.Vote1Btn.UseVisualStyleBackColor = True
        '
        'VoteValueLbl
        '
        Me.VoteValueLbl.Location = New System.Drawing.Point(50, 130)
        Me.VoteValueLbl.Name = "VoteValueLbl"
        Me.VoteValueLbl.Size = New System.Drawing.Size(100, 20)
        Me.VoteValueLbl.TabIndex = 5
        Me.VoteValueLbl.Text = "10"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Value:"
        '
        'Pad4VoteLbl
        '
        Me.Pad4VoteLbl.AutoSize = True
        Me.Pad4VoteLbl.Location = New System.Drawing.Point(7, 86)
        Me.Pad4VoteLbl.Name = "Pad4VoteLbl"
        Me.Pad4VoteLbl.Size = New System.Drawing.Size(38, 13)
        Me.Pad4VoteLbl.TabIndex = 3
        Me.Pad4VoteLbl.Text = "Pad4: "
        '
        'Pad3VoteLbl
        '
        Me.Pad3VoteLbl.AutoSize = True
        Me.Pad3VoteLbl.Location = New System.Drawing.Point(7, 63)
        Me.Pad3VoteLbl.Name = "Pad3VoteLbl"
        Me.Pad3VoteLbl.Size = New System.Drawing.Size(38, 13)
        Me.Pad3VoteLbl.TabIndex = 2
        Me.Pad3VoteLbl.Text = "Pad3: "
        '
        'Pad2VoteLbl
        '
        Me.Pad2VoteLbl.AutoSize = True
        Me.Pad2VoteLbl.Location = New System.Drawing.Point(7, 43)
        Me.Pad2VoteLbl.Name = "Pad2VoteLbl"
        Me.Pad2VoteLbl.Size = New System.Drawing.Size(38, 13)
        Me.Pad2VoteLbl.TabIndex = 1
        Me.Pad2VoteLbl.Text = "Pad2: "
        '
        'Pad1VoteLbl
        '
        Me.Pad1VoteLbl.AutoSize = True
        Me.Pad1VoteLbl.Location = New System.Drawing.Point(7, 20)
        Me.Pad1VoteLbl.Name = "Pad1VoteLbl"
        Me.Pad1VoteLbl.Size = New System.Drawing.Size(38, 13)
        Me.Pad1VoteLbl.TabIndex = 0
        Me.Pad1VoteLbl.Text = "Pad1: "
        '
        'Pad1NameTxt
        '
        Me.Pad1NameTxt.Location = New System.Drawing.Point(15, 280)
        Me.Pad1NameTxt.Name = "Pad1NameTxt"
        Me.Pad1NameTxt.Size = New System.Drawing.Size(100, 20)
        Me.Pad1NameTxt.TabIndex = 8
        Me.Pad1NameTxt.Text = "Player 1"
        '
        'Pad2NameTxt
        '
        Me.Pad2NameTxt.Location = New System.Drawing.Point(121, 280)
        Me.Pad2NameTxt.Name = "Pad2NameTxt"
        Me.Pad2NameTxt.Size = New System.Drawing.Size(100, 20)
        Me.Pad2NameTxt.TabIndex = 8
        Me.Pad2NameTxt.Text = "Player 2"
        '
        'Pad3NameTxt
        '
        Me.Pad3NameTxt.Location = New System.Drawing.Point(227, 280)
        Me.Pad3NameTxt.Name = "Pad3NameTxt"
        Me.Pad3NameTxt.Size = New System.Drawing.Size(100, 20)
        Me.Pad3NameTxt.TabIndex = 8
        Me.Pad3NameTxt.Text = "Player 3"
        '
        'Pad4NameTxt
        '
        Me.Pad4NameTxt.Location = New System.Drawing.Point(333, 280)
        Me.Pad4NameTxt.Name = "Pad4NameTxt"
        Me.Pad4NameTxt.Size = New System.Drawing.Size(100, 20)
        Me.Pad4NameTxt.TabIndex = 8
        Me.Pad4NameTxt.Text = "Player 4"
        '
        'BuzzActiveChk
        '
        Me.BuzzActiveChk.AutoSize = True
        Me.BuzzActiveChk.Checked = True
        Me.BuzzActiveChk.CheckState = System.Windows.Forms.CheckState.Checked
        Me.BuzzActiveChk.Location = New System.Drawing.Point(216, 211)
        Me.BuzzActiveChk.Name = "BuzzActiveChk"
        Me.BuzzActiveChk.Size = New System.Drawing.Size(92, 17)
        Me.BuzzActiveChk.TabIndex = 9
        Me.BuzzActiveChk.Text = "Buzz-in active"
        Me.BuzzActiveChk.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(609, 472)
        Me.Controls.Add(Me.BuzzActiveChk)
        Me.Controls.Add(Me.Pad4NameTxt)
        Me.Controls.Add(Me.Pad3NameTxt)
        Me.Controls.Add(Me.Pad2NameTxt)
        Me.Controls.Add(Me.Pad1NameTxt)
        Me.Controls.Add(Me.GroupBox2)
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
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Pad4ButtonLbl As Label
    Friend WithEvents Pad3ButtonLbl As Label
    Friend WithEvents Pad2ButtonLbl As Label
    Friend WithEvents Pad1ButtonLbl As Label
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
    Friend WithEvents WbuzzBlinker As Timer
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ResetVotingBtn As Button
    Friend WithEvents Vote4Btn As Button
    Friend WithEvents Vote3Btn As Button
    Friend WithEvents Vote2Btn As Button
    Friend WithEvents Vote1Btn As Button
    Friend WithEvents VoteValueLbl As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Pad4VoteLbl As Label
    Friend WithEvents Pad3VoteLbl As Label
    Friend WithEvents Pad2VoteLbl As Label
    Friend WithEvents Pad1VoteLbl As Label
    Friend WithEvents Pad1NameTxt As TextBox
    Friend WithEvents Pad2NameTxt As TextBox
    Friend WithEvents Pad3NameTxt As TextBox
    Friend WithEvents Pad4NameTxt As TextBox
    Friend WithEvents BuzzActiveChk As CheckBox
End Class
