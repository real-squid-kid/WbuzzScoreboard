Public Class Scoreboard
    Dim CurrentBlink As Byte
    Dim BlinkState As Byte
    Private Sub Scoreboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BlinkState = 1
    End Sub

    Public Sub CallOut(e As Byte)
        Select Case e
            Case 1
                Pad1Score.BackColor = Color.Red
                CurrentBlink = 1
            Case 2
                Pad2Score.BackColor = Color.Red
                CurrentBlink = 2
            Case 3
                Pad3Score.BackColor = Color.Red
                CurrentBlink = 3
            Case 4
                Pad4Score.BackColor = Color.Red
                CurrentBlink = 4
        End Select
    End Sub
    Public Sub Reset()
        Pad1Score.BackColor = Color.Black
        Pad2Score.BackColor = Color.Black
        Pad3Score.BackColor = Color.Black
        Pad4Score.BackColor = Color.Black
        CurrentBlink = 0
    End Sub

    Private Sub Blinker_Tick(sender As Object, e As EventArgs) Handles Blinker.Tick
        If BlinkState = 2 Then
            Select Case CurrentBlink
                Case 1
                    Pad1Score.ForeColor = Color.Red
                Case 2
                    Pad2Score.ForeColor = Color.Red
                Case 3
                    Pad3Score.ForeColor = Color.Red
                Case 4
                    Pad4Score.ForeColor = Color.Red
            End Select
            BlinkState = 1
        Else
            BlinkState = 2
            Pad1Score.ForeColor = Color.White
            Pad2Score.ForeColor = Color.White
            Pad3Score.ForeColor = Color.White
            Pad4Score.ForeColor = Color.White
        End If
    End Sub
    Public Sub Sync(Pad1 As Long, Pad2 As Long, Pad3 As Long, Pad4 As Long)
        Select Case Pad1
            Case Is < 10
                Pad1Score.Text = "000" & Pad1
            Case Is < 100
                Pad1Score.Text = "00" & Pad1
            Case Is < 1000
                Pad1Score.Text = "0" & Pad1
            Case Else
                Pad1Score.Text = Pad1
        End Select
        Select Case Pad2
            Case Is < 10
                Pad2Score.Text = "000" & Pad2
            Case Is < 100
                Pad2Score.Text = "00" & Pad2
            Case Is < 1000
                Pad2Score.Text = "0" & Pad2
            Case Else
                Pad2Score.Text = Pad2
        End Select
        Select Case Pad3
            Case Is < 10
                Pad3Score.Text = "000" & Pad3
            Case Is < 100
                Pad3Score.Text = "00" & Pad3
            Case Is < 1000
                Pad3Score.Text = "0" & Pad3
            Case Else
                Pad3Score.Text = Pad3
        End Select
        Select Case Pad4
            Case Is < 10
                Pad4Score.Text = "000" & Pad4
            Case Is < 100
                Pad4Score.Text = "00" & Pad4
            Case Is < 1000
                Pad4Score.Text = "0" & Pad4
            Case Else
                Pad4Score.Text = Pad4
        End Select
    End Sub
End Class