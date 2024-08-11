Imports System.Media

Public Class FrmOvenTimer

    Private player As New SoundPlayer(My.Resources.EmergencyAlarm)
    Private TimerRunning As Boolean = False

    Private Const DEFAULT_PRESET_TEXT As String = "Select A Preset..."

    Private Sub FrmOvenTimer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Location = New Point(0, 10)
        LoadPresets()
        EnableButtons()
        CboPresets.Text = DEFAULT_PRESET_TEXT

    End Sub

    Protected Overrides Sub OnFormClosed(e As FormClosedEventArgs)

        player.Dispose()
        MyBase.OnFormClosed(e)

    End Sub

    Private Sub LoadPresets()

        CboPresets.Items.Clear()

        CboPresets.Items.Add(DEFAULT_PRESET_TEXT)
        CboPresets.Items.Add("15 Minutes")
        CboPresets.Items.Add("30 Minutes")
        CboPresets.Items.Add("45 Minutes")
        CboPresets.Items.Add("1 Hour")
        CboPresets.Items.Add("1.5 Hours")
        CboPresets.Items.Add("2 Hours")
        CboPresets.Items.Add("2.5 Hours")
        CboPresets.Items.Add("3 Hours")

    End Sub

    Private Sub FormatPresets()

        If CboPresets.Text = DEFAULT_PRESET_TEXT Then
            CboPresets.ForeColor = Color.FromArgb(215, 215, 215)
        Else
            CboPresets.ForeColor = Color.FromArgb(0, 0, 0)
        End If

    End Sub

    Private Sub RecolorForm()

        If TimerRunning Then
            BackColor = Color.Green
        Else
            BackColor = SystemColors.Control
        End If

    End Sub

    Private Sub CboPresets_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboPresets.SelectedIndexChanged

        Dim H As String = "0", M As String = "0", S As String = "0"

        BtnStart.Focus()
        If CboPresets.Text = DEFAULT_PRESET_TEXT Then Exit Sub

        Select Case CboPresets.SelectedItem
            Case "15 Minutes" : M = "15"
            Case "30 Minutes" : M = "30"
            Case "45 Minutes" : M = "45"
            Case "1 Hour" : H = "1"
            Case "1.5 Hours" : H = "1" : M = "30"
            Case "2 Hours" : H = "2"
            Case "2.5 Hours" : H = "2" : M = "30"
            Case "3 Hours" : H = "3"
        End Select

        TxtHours.Text = H : TxtMinutes.Text = M : TxtSeconds.Text = S
        CboPresets.Text = DEFAULT_PRESET_TEXT

        FormatPresets()
        FormatTimer()
        EnableButtons()
        BtnStart.Focus()

    End Sub

    Private Sub EnableButtons()

        If Val(TxtHours.Text) <> 0 Or Val(TxtMinutes.Text) <> 0 Or Val(TxtSeconds.Text) <> 0 Then
            BtnStart.Enabled = True
            BtnReset.Enabled = False
            If TimerRunning Then
                BtnStart.Enabled = False
                BtnStop.Enabled = True
            Else
                BtnStart.Enabled = True
                BtnStop.Enabled = False
                BtnReset.Enabled = True
            End If
        Else
            BtnStart.Enabled = False
            If Not TimerRunning Then BtnReset.Enabled = False
        End If

        If TimerRunning Then
            TxtHours.Enabled = False : TxtMinutes.Enabled = False : TxtSeconds.Enabled = False
            PnlTimer.BackColor = SystemColors.Control
            CboPresets.Enabled = False
        Else
            TxtHours.Enabled = True : TxtMinutes.Enabled = True : TxtSeconds.Enabled = True
            PnlTimer.BackColor = Color.White
            CboPresets.Enabled = True
        End If

        RecolorForm()

    End Sub

    Private Sub CboPresets_TextChanged(sender As Object, e As EventArgs) Handles CboPresets.TextChanged

        FormatPresets()

    End Sub

    Private Sub CboPresets_DropDown(sender As Object, e As EventArgs) Handles CboPresets.DropDown

        CboPresets.Text = ""
        FormatPresets()

    End Sub

    Private Sub CboPresets_DropDownClosed(sender As Object, e As EventArgs) Handles CboPresets.DropDownClosed

        If CboPresets.SelectedItem = "" Then
            CboPresets.Text = DEFAULT_PRESET_TEXT
            FormatPresets()
        End If

    End Sub

    Private Sub FormatTimer()

        If TxtSeconds.Text.Length = 1 Then TxtSeconds.Text = "0" & TxtSeconds.Text
        If TxtMinutes.Text.Length = 1 Then TxtMinutes.Text = "0" & TxtMinutes.Text
        If TxtHours.Text.Length = 1 Then TxtHours.Text = "0" & TxtHours.Text

    End Sub

    Private Sub TimTimer_Tick(sender As Object, e As EventArgs) Handles TimTimer.Tick

        If Val(TxtHours.Text) <> 0 And Val(TxtMinutes.Text) = 0 And Val(TxtSeconds.Text) = 0 Then
            TxtMinutes.Text = "60"
            TxtHours.Text = Val(TxtHours.Text) - 1
        End If

        If Val(TxtSeconds.Text) = 0 Then
            TxtMinutes.Text = Val(TxtMinutes.Text) - 1
            TxtSeconds.Text = "60"
        End If

        TxtSeconds.Text = Val(TxtSeconds.Text) - 1
        FormatTimer()

        If Val(TxtHours.Text) = 0 And Val(TxtMinutes.Text) = 0 And Val(TxtSeconds.Text) = 0 Then
            player.PlayLooping()
            TimTimer.Enabled = False
            TimerRunning = False
            EnableButtons()
            BackColor = Color.Red
        End If

    End Sub

    Private Sub BtnStart_Click(sender As Object, e As EventArgs) Handles BtnStart.Click

        TimTimer.Enabled = True
        TimerRunning = True
        EnableButtons()
        BtnStop.Focus()

    End Sub

    Private Sub BtnStop_Click(sender As Object, e As EventArgs) Handles BtnStop.Click

        player.Stop()
        TimTimer.Enabled = False
        TimerRunning = False
        EnableButtons()
        BtnReset.Focus()
        If Not TimerRunning Then BtnStop.Enabled = False

    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click

        TxtHours.Text = "00" : TxtMinutes.Text = "00" : TxtSeconds.Text = "00"
        TimerRunning = False
        EnableButtons()

    End Sub

    Private Sub TimerChanged(sender As Object, e As EventArgs) Handles TxtHours.TextChanged, TxtMinutes.TextChanged, TxtSeconds.TextChanged

        If Not TimerRunning Then
            If TxtHours.Text.Length = 2 And TxtMinutes.Text.Length = 2 And
                TxtSeconds.Text.Length = 2 Then EnableButtons()
        End If

    End Sub

    Private Sub CboPresets_TextUpdate(sender As Object, e As EventArgs) Handles CboPresets.TextUpdate

        Dim X As Integer

        For X = 0 To CboPresets.Items.Count - 1
            If CboPresets.Text <> CboPresets.Items.Item(X) Then
                CboPresets.Text = DEFAULT_PRESET_TEXT
                Exit For
            End If
        Next

    End Sub

    Private Sub TxtSeconds_LostFocus(sender As Object, e As EventArgs) Handles TxtSeconds.LostFocus

        If TxtHours.Text = "" Or Not IsNumeric(TxtHours.Text) Then TxtHours.Text = "00"
        If TxtMinutes.Text = "" Or Not IsNumeric(TxtMinutes.Text) Then TxtMinutes.Text = "00"
        If TxtSeconds.Text = "" Or Not IsNumeric(TxtSeconds.Text) Then TxtSeconds.Text = "00"
        EnableButtons()

    End Sub
End Class
