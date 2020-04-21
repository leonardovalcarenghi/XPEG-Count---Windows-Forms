Imports System.Windows.Forms

Public Class ViewHelpDialog

    Public FileQuestion As IO.FileInfo

    Private Sub ViewHelpDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RichTextBox1.LoadFile(FileQuestion.FullName)
    End Sub
End Class
