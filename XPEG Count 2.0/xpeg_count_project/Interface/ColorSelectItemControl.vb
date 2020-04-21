Imports System.ComponentModel

<DefaultEvent("MouseClick")>
Public Class ColorSelectItemControl

    Private Sub ColorSelectItemControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Property ColorC As Color
        Get
            Return PictureBox_Color.BackColor

        End Get
        Set(value As Color)
            PictureBox_Color.BackColor = value
        End Set
    End Property

    Private Sub PictureBox_Icone_MouseClick(sender As Object, e As MouseEventArgs) Handles PictureBox_Color.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Dim FORM_SelectColor As SelectColorDialog
            FORM_SelectColor = ParentForm.FindForm

            FORM_SelectColor.SelectedColor = ColorC

        End If
    End Sub

    Private Sub PictureBox_Icone_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox_Color.MouseEnter
        Me.BackColor = Color.FromArgb(230, 230, 230)
    End Sub

    Private Sub PictureBox_Icone_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox_Color.MouseLeave
        Me.BackColor = Color.Transparent
    End Sub
End Class
