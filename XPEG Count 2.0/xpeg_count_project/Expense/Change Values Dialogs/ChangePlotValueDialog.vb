Imports System.Windows.Forms

Public Class ChangePlotValueDialog

    Private Sub Dialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox_Value.Focus() : TextBox_Value.Select()
    End Sub

    Private Sub TextBox_Value_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox_Value.KeyDown
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
        If TextBox_Value.Text = Nothing Then
            MessageBox.Show("Digite o valor da parcela.", "XPEG Count", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            If Not IsNumeric(TextBox_Value.Text) Then
                MessageBox.Show("Valor digitado é inválido.", "XPEG Count", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                Me.DialogResult = System.Windows.Forms.DialogResult.OK
                Me.Close()
            End If
        End If

    End Sub

    Private Sub CancelDialog()
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

End Class
