Imports System.ComponentModel
Imports AForge
Imports AForge.Controls
Imports HidLibrary
Imports System.IO

Public Class Form1
    Dim Pad1Button, Pad2Button, Pad3Button, Pad4Button As Byte
    Dim Vote1, Vote2, Vote3, Vote4 As Byte
    Dim CanVote As Boolean
    Dim Pad1Score, Pad2Score, Pad3Score, Pad4Score As Long
    Dim JoystickID As Byte
    Dim info As List(Of Joystick.DeviceInfo) = Joystick.GetAvailableDevices
    Dim PadsFinder As List(Of HidLibrary.HidDevice)
    Dim Pads As HidDevice
    Dim BlinkState, PadBlink As Byte
    Dim AllSounds As String()



    Public Sub ChangeScore(pad As Byte, val As Long, par As Single)
        Select Case par
            Case 1
                If pad = 1 Then Pad1Score += val
                If pad = 2 Then Pad2Score += val
                If pad = 3 Then Pad3Score += val
                If pad = 4 Then Pad4Score += val
                Scoreboard.Sync(Pad1Score, Pad2Score, Pad3Score, Pad4Score)
                Scoreboard.Reset()
                LightPads(0)
                Exit Select
            Case -1
                If pad = 1 Then Pad1Score -= val
                If pad = 2 Then Pad2Score -= val
                If pad = 3 Then Pad3Score -= val
                If pad = 4 Then Pad4Score -= val
                Scoreboard.Sync(Pad1Score, Pad2Score, Pad3Score, Pad4Score)
                Scoreboard.Reset()
                LightPads(0)
                Exit Select
            Case 0
                If pad = 1 Then Pad1Score = val
                If pad = 2 Then Pad2Score = val
                If pad = 3 Then Pad3Score = val
                If pad = 4 Then Pad4Score = val
                Scoreboard.Sync(Pad1Score, Pad2Score, Pad3Score, Pad4Score)
                Scoreboard.Reset()
                LightPads(0)
                Exit Select
        End Select
    End Sub

    Private Sub Pad1AddSubBtn_Click(sender As Object, e As EventArgs) Handles Pad1AddSubBtn.Click
        ChangeScore(1, Pad1ScoreTxt.Text, 1)
    End Sub

    Private Sub Pad2AddSubBtn_Click(sender As Object, e As EventArgs) Handles Pad2AddSubBtn.Click
        ChangeScore(2, Pad2ScoreTxt.Text, 1)
    End Sub

    Private Sub Pad3AddSubBtn_Click(sender As Object, e As EventArgs) Handles Pad3AddSubBtn.Click
        ChangeScore(3, Pad3ScoreTxt.Text, 1)
    End Sub

    Private Sub Pad4AddSubBtn_Click(sender As Object, e As EventArgs) Handles Pad4AddSubBtn.Click
        ChangeScore(4, Pad4ScoreTxt.Text, 1)
    End Sub

    Private Sub Pad1ScoreSetBtn_Click(sender As Object, e As EventArgs) Handles Pad1ScoreSetBtn.Click
        ChangeScore(1, Pad1ScoreTxt.Text, 0)
    End Sub

    Private Sub Pad2ScoreSetBtn_Click(sender As Object, e As EventArgs) Handles Pad2ScoreSetBtn.Click
        ChangeScore(2, Pad2ScoreTxt.Text, 0)
    End Sub

    Private Sub Pad3ScoreSetBtn_Click(sender As Object, e As EventArgs) Handles Pad3ScoreSetBtn.Click
        ChangeScore(3, Pad3ScoreTxt.Text, 0)
    End Sub

    Private Sub Pad4ScoreSetBtn_Click(sender As Object, e As EventArgs) Handles Pad4ScoreSetBtn.Click
        ChangeScore(4, Pad4ScoreTxt.Text, 0)
    End Sub

    Private Sub Pad1SubBtn_Click(sender As Object, e As EventArgs) Handles Pad1SubBtn.Click
        ChangeScore(1, Pad1ScoreTxt.Text, -1)
    End Sub

    Private Sub Pad2SubBtn_Click(sender As Object, e As EventArgs) Handles Pad2SubBtn.Click
        ChangeScore(2, Pad2ScoreTxt.Text, -1)
    End Sub

    Private Sub Pad3SubBtn_Click(sender As Object, e As EventArgs) Handles Pad3SubBtn.Click
        ChangeScore(3, Pad3ScoreTxt.Text, -1)
    End Sub

    Private Sub Pad4SubBtn_Click(sender As Object, e As EventArgs) Handles Pad4SubBtn.Click
        ChangeScore(4, Pad4ScoreTxt.Text, -1)
    End Sub

    Private Sub ResetVotingBtn_Click(sender As Object, e As EventArgs) Handles ResetVotingBtn.Click
        Vote1 = 0
        Vote2 = 0
        Vote3 = 0
        Vote4 = 0
        CanVote = True
        Pad1VoteLbl.Text = "Pad1: " & Vote1
        Pad2VoteLbl.Text = "Pad2: " & Vote2
        Pad3VoteLbl.Text = "Pad3: " & Vote3
        Pad4VoteLbl.Text = "Pad4: " & Vote4
    End Sub

    Private Sub Vote1Btn_Click(sender As Object, e As EventArgs) Handles Vote1Btn.Click
        CanVote = False
        If Vote1 = 1 Then
            Pad1Score += VoteValueLbl.Text
        Else
            Pad1Score -= VoteValueLbl.Text
        End If
        If Vote2 = 1 Then
            Pad2Score += VoteValueLbl.Text
        Else
            Pad2Score -= VoteValueLbl.Text
        End If
        If Vote3 = 1 Then
            Pad3Score += VoteValueLbl.Text
        Else
            Pad3Score -= VoteValueLbl.Text
        End If
        If Vote4 = 1 Then
            Pad4Score += VoteValueLbl.Text
        Else
            Pad4Score -= VoteValueLbl.Text
        End If
        Scoreboard.Sync(Pad1Score, Pad2Score, Pad3Score, Pad4Score)

    End Sub

    Private Sub Vote2Btn_Click(sender As Object, e As EventArgs) Handles Vote2Btn.Click
        CanVote = False
        If Vote1 = 2 Then
            Pad1Score += VoteValueLbl.Text
        Else
            Pad1Score -= VoteValueLbl.Text
        End If
        If Vote2 = 2 Then
            Pad2Score += VoteValueLbl.Text
        Else
            Pad2Score -= VoteValueLbl.Text
        End If
        If Vote3 = 2 Then
            Pad3Score += VoteValueLbl.Text
        Else
            Pad3Score -= VoteValueLbl.Text
        End If
        If Vote4 = 2 Then
            Pad4Score += VoteValueLbl.Text
        Else
            Pad4Score -= VoteValueLbl.Text
        End If
        Scoreboard.Sync(Pad1Score, Pad2Score, Pad3Score, Pad4Score)
    End Sub

    Private Sub Vote3Btn_Click(sender As Object, e As EventArgs) Handles Vote3Btn.Click
        CanVote = False
        If Vote1 = 3 Then
            Pad1Score += VoteValueLbl.Text
        Else
            Pad1Score -= VoteValueLbl.Text
        End If
        If Vote2 = 3 Then
            Pad2Score += VoteValueLbl.Text
        Else
            Pad2Score -= VoteValueLbl.Text
        End If
        If Vote3 = 3 Then
            Pad3Score += VoteValueLbl.Text
        Else
            Pad3Score -= VoteValueLbl.Text
        End If
        If Vote4 = 3 Then
            Pad4Score += VoteValueLbl.Text
        Else
            Pad4Score -= VoteValueLbl.Text
        End If
        Scoreboard.Sync(Pad1Score, Pad2Score, Pad3Score, Pad4Score)
    End Sub

    Private Sub Vote4Btn_Click(sender As Object, e As EventArgs) Handles Vote4Btn.Click
        CanVote = False
        If Vote1 = 4 Then
            Pad1Score += VoteValueLbl.Text
        Else
            Pad1Score -= VoteValueLbl.Text
        End If
        If Vote2 = 4 Then
            Pad2Score += VoteValueLbl.Text
        Else
            Pad2Score -= VoteValueLbl.Text
        End If
        If Vote3 = 4 Then
            Pad3Score += VoteValueLbl.Text
        Else
            Pad3Score -= VoteValueLbl.Text
        End If
        If Vote4 = 4 Then
            Pad4Score += VoteValueLbl.Text
        Else
            Pad4Score -= VoteValueLbl.Text
        End If
        Scoreboard.Sync(Pad1Score, Pad2Score, Pad3Score, Pad4Score)
    End Sub

    Private Sub Pad1NameTxt_TextChanged(sender As Object, e As EventArgs) Handles Pad1NameTxt.TextChanged
        Scoreboard.Pad1NameLbl.Text = Pad1NameTxt.Text
    End Sub

    Private Sub Pad2NameTxt_TextChanged(sender As Object, e As EventArgs) Handles Pad2NameTxt.TextChanged
        Scoreboard.Pad2NameLbl.Text = Pad2NameTxt.Text
    End Sub

    Private Sub Pad3NameTxt_TextChanged(sender As Object, e As EventArgs) Handles Pad3NameTxt.TextChanged
        Scoreboard.Pad3NameLbl.Text = Pad3NameTxt.Text
    End Sub

    Private Sub Pad4NameTxt_TextChanged(sender As Object, e As EventArgs) Handles Pad4NameTxt.TextChanged
        Scoreboard.Pad4NameLbl.Text = Pad4NameTxt.Text
    End Sub



    Private Sub ShowScreen_Click(sender As Object, e As EventArgs) Handles ShowScreen.Click
        If WbuzzStatusLbl.Text = "WbuzzStatus" Then
            MessageBox.Show("You'll probably want to initialize joystick first.", "WbuzzScoreBoard", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Scoreboard.Show()
        Scoreboard.Reset()
        If BuzzActiveChk.Checked Then
            PressDetect.Start()
            LightPads(5)
        End If

    End Sub

    Private Sub WbuzzBlinker_Tick(sender As Object, e As EventArgs) Handles WbuzzBlinker.Tick
        If BlinkState = 2 Then
            Select Case PadBlink
                Case 0
                    LightPads(0)
                Case 1
                    LightPads(1)
                Case 2
                    LightPads(2)
                Case 3
                    LightPads(3)
                Case 4
                    LightPads(4)
                Case 5
                    LightPads(5)
            End Select
            BlinkState = 1
        Else
            BlinkState = 2
            LightPads(0)
        End If
    End Sub

    Private Sub BlinkAllBtn_Click(sender As Object, e As EventArgs) Handles BlinkAllBtn.Click
        LightPads(0)
        Scoreboard.CallOut(5)
        PressDetect.Stop()
        PadBlink = 5
        WbuzzBlinker.Start()
    End Sub

    Private Sub Pad1Chk_CheckedChanged(sender As Object, e As EventArgs) Handles Pad1Chk.CheckedChanged
        Scoreboard.Pad1NameLbl.Visible = Pad1Chk.Checked
        Scoreboard.Pad1Score.Visible = Pad1Chk.Checked
    End Sub

    Private Sub Pad2Chk_CheckedChanged(sender As Object, e As EventArgs) Handles Pad2Chk.CheckedChanged
        Scoreboard.Pad2NameLbl.Visible = Pad2Chk.Checked
        Scoreboard.Pad2Score.Visible = Pad2Chk.Checked
    End Sub

    Private Sub Pad3Chk_CheckedChanged(sender As Object, e As EventArgs) Handles Pad3Chk.CheckedChanged
        Scoreboard.Pad3NameLbl.Visible = Pad3Chk.Checked
        Scoreboard.Pad3Score.Visible = Pad3Chk.Checked
    End Sub

    Private Sub Pad4Chk_CheckedChanged(sender As Object, e As EventArgs) Handles Pad4Chk.CheckedChanged
        Scoreboard.Pad4NameLbl.Visible = Pad4Chk.Checked
        Scoreboard.Pad4Score.Visible = Pad4Chk.Checked
    End Sub

    Public Sub LightPads(e As Byte)
        Select Case e
            Case 5
                Dim OutData(7) As Byte
                OutData(0) = &H0
                OutData(1) = &H0
                OutData(2) = &HFF
                OutData(3) = &HFF
                OutData(4) = &HFF
                OutData(5) = &HFF
                OutData(6) = &H0
                OutData(7) = &H0
                Pads.Write(OutData)
            Case 0
                Dim OutData(7) As Byte
                OutData(0) = &H0
                OutData(1) = &H0
                OutData(2) = &H0
                OutData(3) = &H0
                OutData(4) = &H0
                OutData(5) = &H0
                OutData(6) = &H0
                OutData(7) = &H0
                Pads.Write(OutData)
            Case 1
                Dim OutData(7) As Byte
                OutData(0) = &H0
                OutData(1) = &H0
                OutData(2) = &HFF
                OutData(3) = &H0
                OutData(4) = &H0
                OutData(5) = &H0
                OutData(6) = &H0
                OutData(7) = &H0
                Pads.Write(OutData)
            Case 2
                Dim OutData(7) As Byte
                OutData(0) = &H0
                OutData(1) = &H0
                OutData(2) = &H0
                OutData(3) = &HFF
                OutData(4) = &H0
                OutData(5) = &H0
                OutData(6) = &H0
                OutData(7) = &H0
                Pads.Write(OutData)
            Case 3
                Dim OutData(7) As Byte
                OutData(0) = &H0
                OutData(1) = &H0
                OutData(2) = &H0
                OutData(3) = &H0
                OutData(4) = &HFF
                OutData(5) = &H0
                OutData(6) = &H0
                OutData(7) = &H0
                Pads.Write(OutData)
            Case 4
                Dim OutData(7) As Byte
                OutData(0) = &H0
                OutData(1) = &H0
                OutData(2) = &H0
                OutData(3) = &H0
                OutData(4) = &H0
                OutData(5) = &HFF
                OutData(6) = &H0
                OutData(7) = &H0
                Pads.Write(OutData)
        End Select
    End Sub

    Private Sub PressDetect_Tick(sender As Object, e As EventArgs) Handles PressDetect.Tick
        If Pad1Button = 5 Then
            RedButton(1)
            Exit Sub
        End If
        If Pad2Button = 5 Then
            RedButton(2)
            Exit Sub
        End If
        If Pad3Button = 5 Then
            RedButton(3)
            Exit Sub
        End If
        If Pad4Button = 5 Then
            RedButton(4)
            Exit Sub
        End If
    End Sub
    Public Sub RedButton(e As Byte)
        LightPads(0)
        If SoundChk.Checked Then
            Dim playme As String
            playme = Directory.GetCurrentDirectory & "\sounds\" & SoundList.SelectedItem
            If My.Settings.Sound <> Nothing Then
                If My.Settings.Sound = "Default" Then
                    My.Computer.Audio.Play(My.Resources.ff_buzzer, AudioPlayMode.Background)
                Else
                    Try
                        My.Computer.Audio.Play(playme, AudioPlayMode.Background)
                    Catch

                    End Try
                End If
            End If
        End If
        Scoreboard.CallOut(e)
        PressDetect.Stop()
        PadBlink = e
        WbuzzBlinker.Start()
        Select Case e
            Case 1
                Pad1ScoreLbl.BackColor = Color.Red
            Case 2
                Pad2ScoreLbl.BackColor = Color.Red
            Case 3
                Pad3ScoreLbl.BackColor = Color.Red
            Case 4
                Pad4ScoreLbl.BackColor = Color.Red
        End Select
        Exit Sub
    End Sub

    Private Sub ResetBtn_Click(sender As Object, e As EventArgs) Handles ResetBtn.Click
        Scoreboard.Reset()
        If BuzzActiveChk.Checked Then
            PressDetect.Start()
            LightPads(5)
        End If
        WbuzzBlinker.Stop()
        PadBlink = 0
        Pad1ScoreLbl.BackColor = Color.White
        Pad2ScoreLbl.BackColor = Color.White
        Pad3ScoreLbl.BackColor = Color.White
        Pad4ScoreLbl.BackColor = Color.White
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim arr As New List(Of String) From {
            "List of connected devices:"
        }

        For n = 0 To info.Count - 1
            arr.Add("ID:" & info(n).ID & ", " & info(n).Name)
        Next
        For Each f In arr
            DeviceListTxt.AppendText(f & Environment.NewLine)
        Next
        Pad1Score = 0
        Pad2Score = 0
        Pad3Score = 0
        Pad4Score = 0
        'init soundlist
        SoundList.Items.Add("Default")
        Try
            Dim path As String = Directory.GetCurrentDirectory
            path &= "\sounds\"
            AllSounds = Directory.GetFiles(path)
            For Each a In AllSounds
                Dim m As String() = a.Split("\")
                SoundList.Items.Add(m(m.GetUpperBound(0)))
            Next
        Catch fu As Exception
            MessageBox.Show(fu.ToString, "WbuzzScoreboard", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try

    End Sub

    Public Function SoundCrop(e As String)
        Dim ret As String
        Dim a As String() = e.Split("\")
        ret = a(a.GetUpperBound(0))
        Return ret
    End Function

    Private Sub WbuzzInitBtn_Click(sender As Object, e As EventArgs) Handles WbuzzInitBtn.Click
        WbuzzPoller.Stop()
        WbuzzBlinker.Stop()
        'init joystick routine
        Try
            Dim joy As New Joystick(IDNumberTxt.Text)
            WbuzzPoller.Start()
            IDNumberTxt.Enabled = False
        Catch ex As Exception
            MessageBox.Show("Can't initialize (wrong joystick ID?) " & ex.ToString, "WbuzzScoreboard", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try
        'init led lights
        Try
            PadsFinder = HidDevices.Enumerate(&H54C).ToList
            Pads = PadsFinder(0)
            Pads.OpenDevice()
            LightPads(0)
            PadBlink = 0
        Catch ex As Exception
            MessageBox.Show("Can't initialize Wbuzz pads properly (not connected?) " & ex.ToString, "WbuzzScoreboard", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try
        Try
            WbuzzStatusLbl.Text = info(IDNumberTxt.Text - 1).Name
        Catch ex As Exception

        End Try
    End Sub

    Private Sub WbuzzPoller_Tick(sender As Object, e As EventArgs) Handles WbuzzPoller.Tick
        'опрос джойстика
        Dim joy As New Joystick(IDNumberTxt.Text)
        Dim status As Joystick.Status = joy.GetCurrentStatus
        'получение кнопок
        Dim buttons As String = Convert.ToString(status.Buttons, 2).PadLeft(20, "0"c)
        Dim PadButtons() As Char
        PadButtons = buttons.ToCharArray
        'установка статуса кнопок
        Pad1Button = 0
        If PadButtons(15).Equals("1"c) Then Pad1Button = 1
        If PadButtons(16).Equals("1"c) Then Pad1Button = 2
        If PadButtons(17).Equals("1"c) Then Pad1Button = 3
        If PadButtons(18).Equals("1"c) Then Pad1Button = 4
        If PadButtons(19).Equals("1"c) Then Pad1Button = 5
        Pad2Button = 0
        If PadButtons(10).Equals("1"c) Then Pad2Button = 1
        If PadButtons(11).Equals("1"c) Then Pad2Button = 2
        If PadButtons(12).Equals("1"c) Then Pad2Button = 3
        If PadButtons(13).Equals("1"c) Then Pad2Button = 4
        If PadButtons(14).Equals("1"c) Then Pad2Button = 5
        Pad3Button = 0
        If PadButtons(5).Equals("1"c) Then Pad3Button = 1
        If PadButtons(6).Equals("1"c) Then Pad3Button = 2
        If PadButtons(7).Equals("1"c) Then Pad3Button = 3
        If PadButtons(8).Equals("1"c) Then Pad3Button = 4
        If PadButtons(9).Equals("1"c) Then Pad3Button = 5
        Pad4Button = 0
        If PadButtons(0).Equals("1"c) Then Pad4Button = 1
        If PadButtons(1).Equals("1"c) Then Pad4Button = 2
        If PadButtons(2).Equals("1"c) Then Pad4Button = 3
        If PadButtons(3).Equals("1"c) Then Pad4Button = 4
        If PadButtons(4).Equals("1"c) Then Pad4Button = 5
        'голосовалка
        If CanVote Then
            If Pad1Button >= 1 And Pad1Button <= 4 Then Vote1 = Pad1Button
            If Pad2Button >= 1 And Pad2Button <= 4 Then Vote2 = Pad2Button
            If Pad3Button >= 1 And Pad3Button <= 4 Then Vote3 = Pad3Button
            If Pad4Button >= 1 And Pad4Button <= 4 Then Vote4 = Pad4Button
            Pad1VoteLbl.Text = "Pad1: " & Vote1
            Pad2VoteLbl.Text = "Pad2: " & Vote2
            Pad3VoteLbl.Text = "Pad3: " & Vote3
            Pad4VoteLbl.Text = "Pad4: " & Vote4
            ResetVotingBtn.BackColor = Color.Red
        Else
            ResetVotingBtn.BackColor = Color.LightGray
        End If
        'показываем нажатия
        Pad1ButtonLbl.Text = Pad1Button
        Pad2ButtonLbl.Text = Pad2Button
        Pad3ButtonLbl.Text = Pad3Button
        Pad4ButtonLbl.Text = Pad4Button
        'подбивание значений на экране
        Pad1ScoreLbl.Text = "Pad 1: " & Pad1Score
        Pad2ScoreLbl.Text = "Pad 2: " & Pad2Score
        Pad3ScoreLbl.Text = "Pad 3: " & Pad3Score
        Pad4ScoreLbl.Text = "Pad 4: " & Pad4Score
        If PressDetect.Enabled Then
            ResetBtn.BackColor = Color.Red
        Else
            ResetBtn.BackColor = Color.Gray
        End If
    End Sub

    Private Sub SoundList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SoundList.SelectedIndexChanged
        If SoundList.SelectedItem = "None" Then
            My.Settings.Sound = Nothing
        Else
            If SoundList.SelectedItem = "Default" Then
                My.Settings.Sound = "Default"
            Else

                My.Settings.Sound = SoundList.SelectedItem
            End If
        End If
    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        'уходим красиво
        Try
            LightPads(0)
            Pads.CloseDevice()
        Catch
        End Try

    End Sub


End Class
