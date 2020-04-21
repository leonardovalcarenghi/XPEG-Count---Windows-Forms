Imports System.Windows.Forms

Public Class ViewCommentDialog

    Private Sub Button_Cancel_Click(sender As Object, e As EventArgs) Handles Button_Cancel.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.None
        Me.Close()
    End Sub
End Class
