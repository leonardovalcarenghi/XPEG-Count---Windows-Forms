Imports System.ComponentModel

<DefaultEvent("MouseClick")>
Public Class IconSelectItemControl

    Public IMAGE_File
    Public FORM_SelectIcon As SelectIconDialog

    Private Sub PictureBox_Icone_MouseClick(sender As Object, e As MouseEventArgs) Handles PictureBox_Icone.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Left Then
            FORM_SelectIcon.SelectIconFile = IMAGE_File
        End If
    End Sub

    Private Sub PictureBox_Icone_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox_Icone.MouseEnter
        PictureBox_Icone.BackColor = Color.FromArgb(230, 230, 230)
    End Sub

    Private Sub PictureBox_Icone_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox_Icone.MouseLeave
        PictureBox_Icone.BackColor = Color.Transparent
    End Sub

    Private Sub IconSelectItemControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
