Imports System.Windows.Forms

Public Class SettingsCountDialog
    
    Private Sub SettingsCountDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSettings()
    End Sub

    Private Sub LoadSettings()

        ''Confirmar Saída:
        Select Case XpegCountSettings.Default.ConfirmClose
            Case True : ComboBox_ConfirmClosing.SelectedIndex = 1
            Case False : ComboBox_ConfirmClosing.SelectedIndex = 0
        End Select

        ''AutoTab do Calendário:
        Select Case XpegCountSettings.Default.AutoTabInCalendar
            Case True : ComboBox_AutoTabInCalendar.SelectedIndex = 1
            Case False : ComboBox_AutoTabInCalendar.SelectedIndex = 0
        End Select

        ''Alterar Status X dias antes:
        ComboBox_ChangeStatusInXDaysBefore.SelectedIndex = XpegCountSettings.Default.ChangeStatusInXBeforeDays - 1
    End Sub









    Private Sub ComboBox_ConfirmClosing_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_ConfirmClosing.SelectedIndexChanged
        XpegCountSettings.Default.ConfirmClose = ComboBox_ConfirmClosing.SelectedIndex
        XpegCountSettings.Default.Save()
    End Sub

    Private Sub ComboBox_AutoTabInCalendar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_AutoTabInCalendar.SelectedIndexChanged
        XpegCountSettings.Default.AutoTabInCalendar = ComboBox_AutoTabInCalendar.SelectedIndex
        XpegCountSettings.Default.Save()
    End Sub

    Private Sub ComboBox_ChangeStatusInXDaysBefore_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_ChangeStatusInXDaysBefore.SelectedIndexChanged
        XpegCountSettings.Default.ChangeStatusInXBeforeDays = ComboBox_ChangeStatusInXDaysBefore.SelectedIndex + 1
    End Sub
End Class
