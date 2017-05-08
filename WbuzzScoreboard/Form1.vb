Imports AForge
Imports AForge.Controls
Public Class Form1
    Dim Pad1Button, Pad2Button, Pad3Button, Pad4Button As Boolean
    Dim Pad1Score, Pad2Score, Pad3Score, Pad4Score As Long
    Dim JoystickID As Byte
    Dim info As List(Of Joystick.DeviceInfo) = Joystick.GetAvailableDevices

    Private Sub Pad1AddSubBtn_Click(sender As Object, e As EventArgs) Handles Pad1AddSubBtn.Click
        Pad1Score += Pad1ScoreTxt.Text
        Scoreboard.Sync(Pad1Score, Pad2Score, Pad3Score, Pad4Score)
        Scoreboard.Reset()
    End Sub

    Private Sub Pad2AddSubBtn_Click(sender As Object, e As EventArgs) Handles Pad2AddSubBtn.Click
        Pad2Score += Pad2ScoreTxt.Text
        Scoreboard.Sync(Pad1Score, Pad2Score, Pad3Score, Pad4Score)
        Scoreboard.Reset()
    End Sub

    Private Sub Pad3AddSubBtn_Click(sender As Object, e As EventArgs) Handles Pad3AddSubBtn.Click
        Pad3Score += Pad3ScoreTxt.Text
        Scoreboard.Sync(Pad1Score, Pad2Score, Pad3Score, Pad4Score)
        Scoreboard.Reset()
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

    Private Sub ShowScreen_Click(sender As Object, e As EventArgs) Handles ShowScreen.Click
        If WbuzzStatusLbl.Text = "WbuzzStatus" Then
            MessageBox.Show("You'll probably want to initialize joystick first.", "WbuzzScoreBoard", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Scoreboard.Show()
        Scoreboard.Reset()
        PressDetect.Start()
    End Sub

    Private Sub PressDetect_Tick(sender As Object, e As EventArgs) Handles PressDetect.Tick
        If Pad1Button Then
            My.Computer.Audio.Play(My.Resources.ff_buzzer, AudioPlayMode.Background)
            Scoreboard.CallOut(1)
            PressDetect.Stop()
            Exit Sub
        End If
        If Pad2Button Then
            My.Computer.Audio.Play(My.Resources.ff_buzzer, AudioPlayMode.Background)
            Scoreboard.CallOut(2)
            PressDetect.Stop()
            Exit Sub
        End If
        If Pad3Button Then
            My.Computer.Audio.Play(My.Resources.ff_buzzer, AudioPlayMode.Background)
            Scoreboard.CallOut(3)
            PressDetect.Stop()
            Exit Sub
        End If
        If Pad4Button Then
            My.Computer.Audio.Play(My.Resources.ff_buzzer, AudioPlayMode.Background)
            Scoreboard.CallOut(4)
            PressDetect.Stop()
            Exit Sub
        End If
    End Sub

    Private Sub ResetBtn_Click(sender As Object, e As EventArgs) Handles ResetBtn.Click
        Scoreboard.Reset()
        PressDetect.Start()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim arr As New List(Of String)
        arr.Add("List of connected devices:")
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
        Try
            Dim joy As New Joystick(IDNumberTxt.Text)
            WbuzzPoller.Start()
            WbuzzStatusLbl.Text = info(IDNumberTxt.Text - 1).Name
        Catch ex As Exception
            MessageBox.Show("Can't initialize (wrong joystick ID?)", "WbuzzScoreboard", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try
    End Sub



    'Dim joy As New Joystick(1)


    Private Sub WbuzzPoller_Tick(sender As Object, e As EventArgs) Handles WbuzzPoller.Tick
        Dim joy As New Joystick(IDNumberTxt.Text)
        Dim status As Joystick.Status = joy.GetCurrentStatus
        Pad1Button = status.IsButtonPressed(Joystick.Buttons.Button1)
        Pad2Button = status.IsButtonPressed(Joystick.Buttons.Button6)
        Pad3Button = status.IsButtonPressed(Joystick.Buttons.Button11)
        Pad4Button = status.IsButtonPressed(Joystick.Buttons.Button16)
        If Pad1Button Then
            Pad1ButtonLbl.BackColor = Color.Red
        Else
            Pad1ButtonLbl.BackColor = Color.White
        End If
        If Pad2Button Then
            Pad2ButtonLbl.BackColor = Color.Red
        Else
            Pad2ButtonLbl.BackColor = Color.White
        End If
        If Pad3Button Then
            Pad3ButtonLbl.BackColor = Color.Red
        Else
            Pad3ButtonLbl.BackColor = Color.White
        End If
        If Pad4Button Then
            Pad4ButtonLbl.BackColor = Color.Red
        Else
            Pad4ButtonLbl.BackColor = Color.White
        End If
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
End Class
