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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.WbuzzStatusLbl = New System.Windows.Forms.Label()
        Me.WbuzzInitBtn = New System.Windows.Forms.Button()
        Me.LED1Chk = New System.Windows.Forms.CheckBox()
        Me.LED2Chk = New System.Windows.Forms.CheckBox()
        Me.LED3Chk = New System.Windows.Forms.CheckBox()
        Me.LED4Chk = New System.Windows.Forms.CheckBox()
        Me.Pad1ButtonLbl = New System.Windows.Forms.Label()
        Me.Pad2ButtonLbl = New System.Windows.Forms.Label()
        Me.Pad3ButtonLbl = New System.Windows.Forms.Label()
        Me.Pad4ButtonLbl = New System.Windows.Forms.Label()
        Me.WbuzzPoller = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
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
        Me.GroupBox1.Size = New System.Drawing.Size(213, 173)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Status and Debug"
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
        'WbuzzStatusLbl
        '
        Me.WbuzzStatusLbl.AutoSize = True
        Me.WbuzzStatusLbl.Location = New System.Drawing.Point(87, 16)
        Me.WbuzzStatusLbl.Name = "WbuzzStatusLbl"
        Me.WbuzzStatusLbl.Size = New System.Drawing.Size(84, 13)
        Me.WbuzzStatusLbl.TabIndex = 1
        Me.WbuzzStatusLbl.Text = "WbuzzStatusLbl"
        '
        'WbuzzInitBtn
        '
        Me.WbuzzInitBtn.Enabled = False
        Me.WbuzzInitBtn.Location = New System.Drawing.Point(9, 33)
        Me.WbuzzInitBtn.Name = "WbuzzInitBtn"
        Me.WbuzzInitBtn.Size = New System.Drawing.Size(75, 23)
        Me.WbuzzInitBtn.TabIndex = 2
        Me.WbuzzInitBtn.Text = "Initialize"
        Me.WbuzzInitBtn.UseVisualStyleBackColor = True
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
        'WbuzzPoller
        '
        Me.WbuzzPoller.Interval = 200
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(662, 461)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Control Board"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

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
End Class
