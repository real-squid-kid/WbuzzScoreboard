Imports System.ComponentModel
Imports AForge
Imports AForge.Controls
Imports HidLibrary
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


    Private Sub Pad1AddSubBtn_Click(sender As Object, e As EventArgs) Handles Pad1AddSubBtn.Click
        Pad1Score += Pad1ScoreTxt.Text
        Scoreboard.Sync(Pad1Score, Pad2Score, Pad3Score, Pad4Score)
        Scoreboard.Reset()
        LightPads(0)

    End Sub

    Private Sub Pad2AddSubBtn_Click(sender As Object, e As EventArgs) Handles Pad2AddSubBtn.Click
        Pad2Score += Pad2ScoreTxt.Text
        Scoreboard.Sync(Pad1Score, Pad2Score, Pad3Score, Pad4Score)
        Scoreboard.Reset()
        LightPads(0)
    End Sub

    Private Sub Pad3AddSubBtn_Click(sender As Object, e As EventArgs) Handles Pad3AddSubBtn.Click
        Pad3Score += Pad3ScoreTxt.Text
        Scoreboard.Sync(Pad1Score, Pad2Score, Pad3Score, Pad4Score)
        Scoreboard.Reset()
        LightPads(0)
    End Sub

    Private Sub Pad4AddSubBtn_Click(sender As Object, e As EventArgs) Handles Pad4AddSubBtn.Click
        Pad4Score += Pad4ScoreTxt.Text
        Scoreboard.Sync(Pad1Score, Pad2Score, Pad3Score, Pad4Score)
        Scoreboard.Reset()
    End Sub

    Private Sub Pad1ScoreSetBtn_Click(sender As Object, e As EventArgs) Handles Pad1ScoreSetBtn.Click
        Pad1Score = Pad1ScoreTxt.Text
        Scoreboard.Sync(Pad1Score, Pad2Score, Pad3Score, Pad4Score)
        Scoreboard.Reset()
    End Sub

    Private Sub Pad2ScoreSetBtn_Click(sender As Object, e As EventArgs) Handles Pad2ScoreSetBtn.Click
        Pad2Score = Pad2ScoreTxt.Text
        Scoreboard.Sync(Pad1Score, Pad2Score, Pad3Score, Pad4Score)
        Scoreboard.Reset()
    End Sub

    Private Sub Pad3ScoreSetBtn_Click(sender As Object, e As EventArgs) Handles Pad3ScoreSetBtn.Click
        Pad3Score = Pad3ScoreTxt.Text
        Scoreboard.Sync(Pad1Score, Pad2Score, Pad3Score, Pad4Score)
        Scoreboard.Reset()
    End Sub

    Private Sub Pad4ScoreSetBtn_Click(sender As Object, e As EventArgs) Handles Pad4ScoreSetBtn.Click
        Pad4Score = Pad4ScoreTxt.Text
        Scoreboard.Sync(Pad1Score, Pad2Score, Pad3Score, Pad4Score)
        Scoreboard.Reset()
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

    Private Sub ShowScreen_Click(sender As Object, e As EventArgs) Handles ShowScreen.Click
        If WbuzzStatusLbl.Text = "WbuzzStatus" Then
            MessageBox.Show("You'll probably want to initialize joystick first.", "WbuzzScoreBoard", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Scoreboard.Show()
        Scoreboard.Reset()
        PressDetect.Start()
        LightPads(5)
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
            End Select
            BlinkState = 1
        Else
            BlinkState = 2
            LightPads(0)
        End If
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
        My.Computer.Audio.Play(My.Resources.ff_buzzer, AudioPlayMode.Background)
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
        PressDetect.Start()
        LightPads(5)
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
    End Sub

    Private Sub WbuzzInitBtn_Click(sender As Object, e As EventArgs) Handles WbuzzInitBtn.Click
        WbuzzPoller.Stop()
        WbuzzBlinker.Stop()
        Try
            Dim joy As New Joystick(IDNumberTxt.Text)
            WbuzzPoller.Start()
            IDNumberTxt.Enabled = False
        Catch ex As Exception
            MessageBox.Show("Can't initialize (wrong joystick ID?)", "WbuzzScoreboard", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try
        'init pads
        Try
            PadsFinder = HidDevices.Enumerate(&H54C).ToList
            Pads = PadsFinder(0)
            Pads.OpenDevice()
            LightPads(0)
            PadBlink = 0
        Catch
            MessageBox.Show("Can't initialize Wbuzz pads properly (not connected?)", "WbuzzScoreboard", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try
        Try
            WbuzzStatusLbl.Text = info(IDNumberTxt.Text - 1).Name
        Catch ex As Exception

        End Try
    End Sub

    Private Sub WbuzzPoller_Tick(sender As Object, e As EventArgs) Handles WbuzzPoller.Tick
        Dim joy As New Joystick(IDNumberTxt.Text)
        Dim status As Joystick.Status = joy.GetCurrentStatus
        Dim buttons As String = Convert.ToString(status.Buttons, 2).PadLeft(20, "0"c)
        Dim PadButtons() As Char
        PadButtons = buttons.ToCharArray

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

            Pad1ButtonLbl.Text = Pad1Button
        Pad2ButtonLbl.Text = Pad2Button
        Pad3ButtonLbl.Text = Pad3Button
        Pad4ButtonLbl.Text = Pad4Button
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

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Try
            LightPads(0)
            Pads.CloseDevice()
        Catch
        End Try

    End Sub

End Class
