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
                Pad1NameLbl.BackColor = Color.Red
                CurrentBlink = 1
            Case 2
                Pad2Score.BackColor = Color.Red
                Pad2NameLbl.BackColor = Color.Red
                CurrentBlink = 2
            Case 3
                Pad3Score.BackColor = Color.Red
                Pad3NameLbl.BackColor = Color.Red
                CurrentBlink = 3
            Case 4
                Pad4Score.BackColor = Color.Red
                Pad4NameLbl.BackColor = Color.Red
                CurrentBlink = 4
            Case 5
                CurrentBlink = 5
        End Select
    End Sub
    Public Sub Reset()
        Pad1Score.BackColor = Color.Black
        Pad1NameLbl.BackColor = Color.Black
        Pad2Score.BackColor = Color.Black
        Pad2NameLbl.BackColor = Color.Black
        Pad3Score.BackColor = Color.Black
        Pad3NameLbl.BackColor = Color.Black
        Pad4Score.BackColor = Color.Black
        Pad4NameLbl.BackColor = Color.Black
        CurrentBlink = 0
        Form1.WbuzzBlinker.Stop()
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
                Case 5
                    Pad1Score.ForeColor = Color.Black
                    Pad2Score.ForeColor = Color.Black
                    Pad3Score.ForeColor = Color.Black
                    Pad4Score.ForeColor = Color.Black
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

        Pad1Score.Text = Pad1

        Pad2Score.Text = Pad2

        Pad3Score.Text = Pad3

        Pad4Score.Text = Pad4

    End Sub
End Class