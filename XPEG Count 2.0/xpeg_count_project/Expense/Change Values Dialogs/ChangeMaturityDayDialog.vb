Imports System.Windows.Forms

Public Class ChangeMaturityDayDialog
    Public IsFebruary As Boolean = False
    Private Sub Dialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker_MaturityDate.Focus() : DateTimePicker_MaturityDate.Select()
    End Sub

    Private Sub TextBox_Value_KeyDown(sender As Object, e As KeyEventArgs) Handles DateTimePicker_MaturityDate.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter : e.SuppressKeyPress = True
                CheckFields()

            Case Keys.Escape : e.SuppressKeyPress = True
                CancelDialog()
        End Select
    End Sub

    Private Sub Button_OK_Click(sender As Object, e As EventArgs) Handles Button_OK.Click
        CheckFields()
    End Sub

    Private Sub Button_Cancel_Click(sender As Object, e As EventArgs) Handles Button_Cancel.Click
        CancelDialog()
    End Sub

    Private Sub CheckFields()
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    'Private Sub CheckFields()
    '    If TextBox_Value.Text = Nothing Then
    '        MessageBox.Show("Digite o dia de vencimento da parcela.", "XPEG Count", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '    Else
    '        If Not IsNumeric(TextBox_Value.Text) Then
    '            MessageBox.Show("O dia digitado é inválido.", "XPEG Count", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '        Else

    '            If IsFebruary = True Then
    '                If Val(TextBox_Value.Text) <= 0 Or Val(TextBox_Value.Text) >= 29 Then
    '                    MessageBox.Show("O dia digitado é inválido.", "XPEG Count", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '                Else
    '                    Me.DialogResult = System.Windows.Forms.DialogResult.OK
    '                    Me.Close()
    '                End If
    '            Else
    '                If IsFebruary = False Then
    '                    If Val(TextBox_Value.Text) <= 0 Or Val(TextBox_Value.Text) >= 31 Then
    '                        MessageBox.Show("O dia digitado é inválido.", "XPEG Count", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '                    Else
    '                        Me.DialogResult = System.Windows.Forms.DialogResult.OK
    '                        Me.Close()
    '                    End If
    '                End If
    '            End If
    '        End If
    '    End If
    'End Sub

    Private Sub CancelDialog()
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
End Class
