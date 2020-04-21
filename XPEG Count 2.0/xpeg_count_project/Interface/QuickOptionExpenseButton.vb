Imports System.ComponentModel

<DefaultEvent("MouseClick")>
Public Class QuickOptionExpenseButton
    Private Sub QuickOptionExpenseButton_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _FUNCTIONS.Interfaces.MakeRoundedEdges(QuickButtonIcon, 3)
    End Sub

    Public Property ButtonIcon As Image
        Get
            Return QuickButtonIcon.Image
        End Get
        Set(value As Image)
            QuickButtonIcon.Image = value
        End Set
    End Property

    Public Property ButtonText As String
        Get
            Return ToolTip1.GetToolTip(QuickButtonIcon)
        End Get
        Set(value As String)
            ToolTip1.SetToolTip(QuickButtonIcon, value)
        End Set
    End Property

    Dim BackC As Color
    Public Property ButtonColor As Color
        Get
            Return BackC
        End Get
        Set(value As Color)
            BackC = value
            QuickButtonIcon.BackColor = BackC
        End Set
    End Property

    Public Property ButtonColor_MouseEnter As Color
    Public Property ButtonColor_MouseDown As Color

    Private Sub QuickButtonIcon_MouseClick(sender As Object, e As MouseEventArgs) Handles QuickButtonIcon.MouseClick
        If e.Button = MouseButtons.Left Then MyBase.OnMouseClick(e) : Invalidate()
    End Sub

    Private Sub QuickButtonIcon_MouseDown(sender As Object, e As MouseEventArgs) Handles QuickButtonIcon.MouseDown
        If e.Button = MouseButtons.Left Then QuickButtonIcon.BackColor = ButtonColor_MouseDown
    End Sub

    Private Sub QuickButtonIcon_MouseLeave(sender As Object, e As EventArgs) Handles QuickButtonIcon.MouseLeave
        QuickButtonIcon.BackColor = BackC
    End Sub

    Private Sub QuickButtonIcon_MouseEnter(sender As Object, e As EventArgs) Handles QuickButtonIcon.MouseEnter
        QuickButtonIcon.BackColor = ButtonColor_MouseEnter
    End Sub

    Private Sub QuickOptionExpenseButton_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        QuickButtonIcon.Width = Me.Height
    End Sub

    Private Sub QuickOptionExpenseButton_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        QuickButtonIcon.Width = Me.Height
    End Sub
End Class
