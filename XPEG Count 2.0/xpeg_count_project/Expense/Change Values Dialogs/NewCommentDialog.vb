Imports System.Windows.Forms

Public Class NewCommentDialog


    Private Sub NewCommentDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox_Title.Focus() : TextBox_Title.Select()
    End Sub




    Private Sub CheckFields()
        If TextBox_Title.Text = Nothing Then
            MsgBox("Digite um título para o seu comentário", MsgBoxStyle.Critical)
            TextBox_Title.Focus() : TextBox_Title.Select()
        Else
            If TextBox_Comment.Text = Nothing Then
                MsgBox("Digite o seu comentário", MsgBoxStyle.Critical)
                TextBox_Comment.Focus() : TextBox_Comment.Select()
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

    Private Sub Button_OK_Click(sender As Object, e As EventArgs) Handles Button_OK.Click
        CheckFields()
    End Sub

    Private Sub Button_Cancel_Click(sender As Object, e As EventArgs) Handles Button_Cancel.Click
        CancelDialog()
    End Sub
End Class
