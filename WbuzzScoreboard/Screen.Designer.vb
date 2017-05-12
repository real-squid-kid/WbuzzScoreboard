<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Scoreboard
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
        Me.Pad1Score = New System.Windows.Forms.Label()
        Me.Pad2Score = New System.Windows.Forms.Label()
        Me.Pad3Score = New System.Windows.Forms.Label()
        Me.Pad4Score = New System.Windows.Forms.Label()
        Me.Blinker = New System.Windows.Forms.Timer(Me.components)
        Me.Pad1NameLbl = New System.Windows.Forms.Label()
        Me.Pad2NameLbl = New System.Windows.Forms.Label()
        Me.Pad3NameLbl = New System.Windows.Forms.Label()
        Me.Pad4NameLbl = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Pad1Score
        '
        Me.Pad1Score.BackColor = System.Drawing.Color.Black
        Me.Pad1Score.Font = New System.Drawing.Font("PT Mono", 47.99999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Pad1Score.ForeColor = System.Drawing.Color.White
        Me.Pad1Score.Location = New System.Drawing.Point(12, 56)
        Me.Pad1Score.Name = "Pad1Score"
        Me.Pad1Score.Size = New System.Drawing.Size(182, 72)
        Me.Pad1Score.TabIndex = 0
        Me.Pad1Score.Text = "0000"
        Me.Pad1Score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Pad2Score
        '
        Me.Pad2Score.BackColor = System.Drawing.Color.Black
        Me.Pad2Score.Font = New System.Drawing.Font("PT Mono", 47.99999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Pad2Score.ForeColor = System.Drawing.Color.White
        Me.Pad2Score.Location = New System.Drawing.Point(200, 56)
        Me.Pad2Score.Name = "Pad2Score"
        Me.Pad2Score.Size = New System.Drawing.Size(182, 72)
        Me.Pad2Score.TabIndex = 0
        Me.Pad2Score.Text = "0000"
        Me.Pad2Score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Pad3Score
        '
        Me.Pad3Score.BackColor = System.Drawing.Color.Black
        Me.Pad3Score.Font = New System.Drawing.Font("PT Mono", 47.99999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Pad3Score.ForeColor = System.Drawing.Color.White
        Me.Pad3Score.Location = New System.Drawing.Point(388, 56)
        Me.Pad3Score.Name = "Pad3Score"
        Me.Pad3Score.Size = New System.Drawing.Size(182, 72)
        Me.Pad3Score.TabIndex = 0
        Me.Pad3Score.Text = "0000"
        Me.Pad3Score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Pad4Score
        '
        Me.Pad4Score.BackColor = System.Drawing.Color.Black
        Me.Pad4Score.Font = New System.Drawing.Font("PT Mono", 47.99999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Pad4Score.ForeColor = System.Drawing.Color.White
        Me.Pad4Score.Location = New System.Drawing.Point(576, 56)
        Me.Pad4Score.Name = "Pad4Score"
        Me.Pad4Score.Size = New System.Drawing.Size(182, 72)
        Me.Pad4Score.TabIndex = 0
        Me.Pad4Score.Text = "0000"
        Me.Pad4Score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Blinker
        '
        Me.Blinker.Enabled = True
        Me.Blinker.Interval = 500
        '
        'Pad1NameLbl
        '
        Me.Pad1NameLbl.BackColor = System.Drawing.Color.Black
        Me.Pad1NameLbl.Font = New System.Drawing.Font("PT Mono", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Pad1NameLbl.ForeColor = System.Drawing.Color.White
        Me.Pad1NameLbl.Location = New System.Drawing.Point(12, 9)
        Me.Pad1NameLbl.Name = "Pad1NameLbl"
        Me.Pad1NameLbl.Size = New System.Drawing.Size(182, 48)
        Me.Pad1NameLbl.TabIndex = 0
        Me.Pad1NameLbl.Text = "Player 1"
        Me.Pad1NameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Pad2NameLbl
        '
        Me.Pad2NameLbl.BackColor = System.Drawing.Color.Black
        Me.Pad2NameLbl.Font = New System.Drawing.Font("PT Mono", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Pad2NameLbl.ForeColor = System.Drawing.Color.White
        Me.Pad2NameLbl.Location = New System.Drawing.Point(200, 8)
        Me.Pad2NameLbl.Name = "Pad2NameLbl"
        Me.Pad2NameLbl.Size = New System.Drawing.Size(182, 48)
        Me.Pad2NameLbl.TabIndex = 0
        Me.Pad2NameLbl.Text = "Player 2"
        Me.Pad2NameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Pad3NameLbl
        '
        Me.Pad3NameLbl.BackColor = System.Drawing.Color.Black
        Me.Pad3NameLbl.Font = New System.Drawing.Font("PT Mono", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Pad3NameLbl.ForeColor = System.Drawing.Color.White
        Me.Pad3NameLbl.Location = New System.Drawing.Point(388, 8)
        Me.Pad3NameLbl.Name = "Pad3NameLbl"
        Me.Pad3NameLbl.Size = New System.Drawing.Size(182, 48)
        Me.Pad3NameLbl.TabIndex = 0
        Me.Pad3NameLbl.Text = "Player 3"
        Me.Pad3NameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Pad4NameLbl
        '
        Me.Pad4NameLbl.BackColor = System.Drawing.Color.Black
        Me.Pad4NameLbl.Font = New System.Drawing.Font("PT Mono", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Pad4NameLbl.ForeColor = System.Drawing.Color.White
        Me.Pad4NameLbl.Location = New System.Drawing.Point(576, 8)
        Me.Pad4NameLbl.Name = "Pad4NameLbl"
        Me.Pad4NameLbl.Size = New System.Drawing.Size(182, 48)
        Me.Pad4NameLbl.TabIndex = 0
        Me.Pad4NameLbl.Text = "Player 4"
        Me.Pad4NameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Scoreboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(775, 136)
        Me.Controls.Add(Me.Pad4Score)
        Me.Controls.Add(Me.Pad3Score)
        Me.Controls.Add(Me.Pad2Score)
        Me.Controls.Add(Me.Pad4NameLbl)
        Me.Controls.Add(Me.Pad3NameLbl)
        Me.Controls.Add(Me.Pad2NameLbl)
        Me.Controls.Add(Me.Pad1NameLbl)
        Me.Controls.Add(Me.Pad1Score)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Scoreboard"
        Me.Text = "Screen"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Pad1Score As Label
    Friend WithEvents Pad2Score As Label
    Friend WithEvents Pad3Score As Label
    Friend WithEvents Pad4Score As Label
    Friend WithEvents Blinker As Timer
    Friend WithEvents Pad1NameLbl As Label
    Friend WithEvents Pad2NameLbl As Label
    Friend WithEvents Pad3NameLbl As Label
    Friend WithEvents Pad4NameLbl As Label
End Class
