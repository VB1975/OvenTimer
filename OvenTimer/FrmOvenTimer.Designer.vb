<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmOvenTimer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmOvenTimer))
        Me.PnlTimer = New System.Windows.Forms.Panel()
        Me.TxtSeconds = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtMinutes = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtHours = New System.Windows.Forms.TextBox()
        Me.BtnStart = New System.Windows.Forms.Button()
        Me.BtnReset = New System.Windows.Forms.Button()
        Me.BtnStop = New System.Windows.Forms.Button()
        Me.CboPresets = New System.Windows.Forms.ComboBox()
        Me.TimTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PnlTimer.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlTimer
        '
        Me.PnlTimer.BackColor = System.Drawing.Color.White
        Me.PnlTimer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlTimer.Controls.Add(Me.TxtSeconds)
        Me.PnlTimer.Controls.Add(Me.Label2)
        Me.PnlTimer.Controls.Add(Me.TxtMinutes)
        Me.PnlTimer.Controls.Add(Me.Label1)
        Me.PnlTimer.Controls.Add(Me.TxtHours)
        Me.PnlTimer.Location = New System.Drawing.Point(17, 57)
        Me.PnlTimer.Name = "PnlTimer"
        Me.PnlTimer.Size = New System.Drawing.Size(325, 63)
        Me.PnlTimer.TabIndex = 0
        '
        'TxtSeconds
        '
        Me.TxtSeconds.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtSeconds.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSeconds.Location = New System.Drawing.Point(245, 3)
        Me.TxtSeconds.MaxLength = 2
        Me.TxtSeconds.Name = "TxtSeconds"
        Me.TxtSeconds.Size = New System.Drawing.Size(72, 55)
        Me.TxtSeconds.TabIndex = 2
        Me.TxtSeconds.Text = "00"
        Me.TxtSeconds.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(202, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 55)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = ":"
        '
        'TxtMinutes
        '
        Me.TxtMinutes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtMinutes.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMinutes.Location = New System.Drawing.Point(124, 3)
        Me.TxtMinutes.MaxLength = 2
        Me.TxtMinutes.Name = "TxtMinutes"
        Me.TxtMinutes.Size = New System.Drawing.Size(72, 55)
        Me.TxtMinutes.TabIndex = 1
        Me.TxtMinutes.Text = "00"
        Me.TxtMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(81, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 55)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = ":"
        '
        'TxtHours
        '
        Me.TxtHours.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtHours.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtHours.Location = New System.Drawing.Point(3, 3)
        Me.TxtHours.MaxLength = 2
        Me.TxtHours.Name = "TxtHours"
        Me.TxtHours.Size = New System.Drawing.Size(72, 55)
        Me.TxtHours.TabIndex = 0
        Me.TxtHours.Text = "00"
        Me.TxtHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnStart
        '
        Me.BtnStart.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.BtnStart.Enabled = False
        Me.BtnStart.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnStart.ForeColor = System.Drawing.Color.White
        Me.BtnStart.Location = New System.Drawing.Point(18, 153)
        Me.BtnStart.Name = "BtnStart"
        Me.BtnStart.Size = New System.Drawing.Size(324, 82)
        Me.BtnStart.TabIndex = 1
        Me.BtnStart.Text = "Start"
        Me.BtnStart.UseVisualStyleBackColor = False
        '
        'BtnReset
        '
        Me.BtnReset.BackColor = System.Drawing.Color.CornflowerBlue
        Me.BtnReset.Enabled = False
        Me.BtnReset.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReset.ForeColor = System.Drawing.Color.White
        Me.BtnReset.Location = New System.Drawing.Point(17, 329)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(324, 82)
        Me.BtnReset.TabIndex = 3
        Me.BtnReset.Text = "Reset"
        Me.BtnReset.UseVisualStyleBackColor = False
        '
        'BtnStop
        '
        Me.BtnStop.BackColor = System.Drawing.Color.IndianRed
        Me.BtnStop.Enabled = False
        Me.BtnStop.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.BtnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnStop.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnStop.ForeColor = System.Drawing.Color.White
        Me.BtnStop.Location = New System.Drawing.Point(17, 241)
        Me.BtnStop.Name = "BtnStop"
        Me.BtnStop.Size = New System.Drawing.Size(324, 82)
        Me.BtnStop.TabIndex = 2
        Me.BtnStop.Text = "Stop"
        Me.BtnStop.UseVisualStyleBackColor = False
        '
        'CboPresets
        '
        Me.CboPresets.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboPresets.FormattingEnabled = True
        Me.CboPresets.Location = New System.Drawing.Point(17, 12)
        Me.CboPresets.Name = "CboPresets"
        Me.CboPresets.Size = New System.Drawing.Size(325, 39)
        Me.CboPresets.TabIndex = 0
        '
        'TimTimer
        '
        Me.TimTimer.Interval = 1000
        '
        'Label3
        '
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label3.Location = New System.Drawing.Point(21, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 21)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "h h"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label4.Location = New System.Drawing.Point(142, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 21)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "m m"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label5.Location = New System.Drawing.Point(263, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 21)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "s s"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmOvenTimer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(363, 431)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CboPresets)
        Me.Controls.Add(Me.BtnStop)
        Me.Controls.Add(Me.BtnReset)
        Me.Controls.Add(Me.BtnStart)
        Me.Controls.Add(Me.PnlTimer)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.MaximizeBox = False
        Me.Name = "FrmOvenTimer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Oven Timer"
        Me.TopMost = True
        Me.PnlTimer.ResumeLayout(False)
        Me.PnlTimer.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlTimer As Panel
    Friend WithEvents TxtHours As TextBox
    Friend WithEvents TxtSeconds As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtMinutes As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnStart As Button
    Friend WithEvents BtnReset As Button
    Friend WithEvents BtnStop As Button
    Friend WithEvents CboPresets As ComboBox
    Friend WithEvents TimTimer As Timer
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
