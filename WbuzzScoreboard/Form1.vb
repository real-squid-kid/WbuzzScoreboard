Imports System.ComponentModel
Imports AForge
Imports AForge.Controls
Imports HidLibrary
Public Class Form1
    Dim Pad1Button, Pad2Button, Pad3Button, Pad4Button As Boolean
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

    Private Sub WbuzzBlinker_Tick(sender As Object, e As EventArgs) Handles WbuzzBlinker.Tick
        If BlinkState = 2 Then
            Select Case PadBlink
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
            BlinkState = 1
        Else
            BlinkState = 2
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
        End If
    End Sub

    Private Sub PressDetect_Tick(sender As Object, e As EventArgs) Handles PressDetect.Tick
        If Pad1Button Then
            My.Computer.Audio.Play(My.Resources.ff_buzzer, AudioPlayMode.Background)
            Scoreboard.CallOut(1)
            PressDetect.Stop()
            PadBlink = 1
            Exit Sub
        End If
        If Pad2Button Then
            My.Computer.Audio.Play(My.Resources.ff_buzzer, AudioPlayMode.Background)
            Scoreboard.CallOut(2)
            PressDetect.Stop()
            PadBlink = 2
            Exit Sub
        End If
        If Pad3Button Then
            My.Computer.Audio.Play(My.Resources.ff_buzzer, AudioPlayMode.Background)
            Scoreboard.CallOut(3)
            PressDetect.Stop()
            PadBlink = 3
            Exit Sub
        End If
        If Pad4Button Then
            My.Computer.Audio.Play(My.Resources.ff_buzzer, AudioPlayMode.Background)
            Scoreboard.CallOut(4)
            PressDetect.Stop()
            PadBlink = 4
            Exit Sub
        End If
    End Sub

    Private Sub ResetBtn_Click(sender As Object, e As EventArgs) Handles ResetBtn.Click
        Scoreboard.Reset()
        PressDetect.Start()
        PadBlink = 0
    End Sub

    Public Class PadsEnum
        Implements IEnumerator

        Public _pad() As HidDevice

        ' Enumerators are positioned before the first element
        ' until the first MoveNext() call.
        Dim position As Integer = -1

        Public Sub New(ByVal list() As HidDevice)
            _pad = list
        End Sub

        Public Function MoveNext() As Boolean Implements IEnumerator.MoveNext
            position = position + 1
            Return (position < _pad.Length)
        End Function

        Public Sub Reset() Implements IEnumerator.Reset
            position = -1
        End Sub

        Public ReadOnly Property Current() As Object Implements IEnumerator.Current
            Get
                Try
                    Return _pad(position)
                Catch ex As IndexOutOfRangeException
                    Throw New InvalidOperationException()
                End Try
            End Get
        End Property
    End Class

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
        WbuzzBlinker.Stop()
        Try
            Dim joy As New Joystick(IDNumberTxt.Text)
            WbuzzPoller.Start()
            IDNumberTxt.Enabled = False
        Catch ex As Exception
            MessageBox.Show("Can't initialize (wrong joystick ID?)", "WbuzzScoreboard", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try
        Try
            PadsFinder = HidDevices.Enumerate(&H54C).ToList
            Pads = PadsFinder(0)
            Pads.OpenDevice()
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
            PadBlink = 0
            WbuzzBlinker.Start()
            LED1Chk.Enabled = True
            LED2Chk.Enabled = True
            LED3Chk.Enabled = True
            LED4Chk.Enabled = True
        Catch
            MessageBox.Show("Can't initialize Wbuzz pads properly (not connected?)", "WbuzzScoreboard", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try
        Try
            WbuzzStatusLbl.Text = info(IDNumberTxt.Text - 1).Name
        Catch ex As Exception

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
        If PadBlink = 0 Then
            Dim OutData(7) As Byte
            OutData(0) = &H0
            OutData(1) = &H0
            If LED1Chk.Checked Then OutData(2) = &HFF Else OutData(2) = &H0
            If LED2Chk.Checked Then OutData(3) = &HFF Else OutData(3) = &H0
            If LED3Chk.Checked Then OutData(4) = &HFF Else OutData(4) = &H0
            If LED4Chk.Checked Then OutData(5) = &HFF Else OutData(5) = &H0
            OutData(6) = &H0
            OutData(7) = &H0
            Pads.Write(OutData)
        End If
    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Try
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
            Pads.CloseDevice()
        Catch
        End Try

    End Sub
End Class
