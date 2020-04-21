Imports System.Windows.Forms
Imports xpeg_count_project

Public Class ChangeNameDialog
    Public ExpenseCode As String
    Dim ListOfNames As List(Of String)
    Private Sub Dialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListOfNames = _EXPENSES.GetNames
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
            MessageBox.Show("Digite o nome da sua despesa.", "XPEG Count", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            If IsNumeric(TextBox_Value.Text) Then
                MessageBox.Show("O nome da sua despesa não pode ser um número.", "XPEG Count", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                If TextBox_Value.Text = _EXPENSE.Name(ExpenseCode) Then
                    Me.DialogResult = System.Windows.Forms.DialogResult.Cancel : Me.Close()
                Else
                    If ListOfNames.Contains(TextBox_Value.Text) Then
                        MessageBox.Show("Este nome já está sendo utilizado por outra despesa." & vbNewLine & "Por favor, escolha outro.", "XPEG Count", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Else
                        Me.DialogResult = System.Windows.Forms.DialogResult.OK : Me.Close()
                    End If

                End If
            End If
        End If
    End Sub

    Private Sub CancelDialog()
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub


End Class
