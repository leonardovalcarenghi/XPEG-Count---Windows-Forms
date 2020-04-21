Imports System.ComponentModel

<DefaultEvent("MouseClick")>
Public Class MonthsLabelsForCalendarMode

    Public Property MonthName As String
        Get
            Return MonthNameLabel.Text()
        End Get
        Set(value As String)
            MonthNameLabel.Text = value
        End Set
    End Property

    Dim VAR_MenuSelected As Boolean = False

    Public Property MenuSelected As Boolean
        Get
            Return VAR_MenuSelected
        End Get
        Set(value As Boolean)
            VAR_MenuSelected = value
            Select Case value
                Case True : MonthNameLabel.Font = New Font("Segoe UI Semibold;", MonthNameLabel.Font.Size, FontStyle.Bold)
                Case False : MonthNameLabel.Font = New Font("Segoe UI SemiLight; ", MonthNameLabel.Font.Size, FontStyle.Regular)
            End Select
        End Set
    End Property


    Private Sub MonthsLabelsForCalendarMode_MouseClick(sender As Object, e As MouseEventArgs) Handles MonthNameLabel.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Left Then MyBase.OnMouseClick(e)
    End Sub

    Private Sub MonthsLabelsForCalendarMode_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown, MonthNameLabel.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then Me.BackColor = Color.FromArgb(225, 225, 225)
    End Sub

    Private Sub MonthsLabelsForCalendarMode_MouseEnter(sender As Object, e As EventArgs) Handles MyBase.MouseEnter, MonthNameLabel.MouseEnter
        Me.BackColor = Color.FromArgb(230, 230, 230)
    End Sub

    Private Sub MonthsLabelsForCalendarMode_MouseLeave(sender As Object, e As EventArgs) Handles MyBase.MouseLeave, MonthNameLabel.MouseLeave
        Me.BackColor = Color.Transparent
    End Sub
End Class
