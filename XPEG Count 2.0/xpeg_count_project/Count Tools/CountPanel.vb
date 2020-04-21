Public Class CountPanel
    Inherits Panel

    Dim BORDER_Top, BORDER_Bottom, BORDER_Left, BORDER_Right As New Panel


    Sub New()
        MyBase.New

        NewBorders()

    End Sub

    Dim VAR_BorderColor As Color = Color.Black
    Public Property BorderColor As Color
        Get
            Return VAR_BorderColor
        End Get
        Set(value As Color)
            VAR_BorderColor = value

            BORDER_Top.BackColor = VAR_BorderColor
            BORDER_Bottom.BackColor = VAR_BorderColor
            BORDER_Left.BackColor = VAR_BorderColor
            BORDER_Right.BackColor = VAR_BorderColor
        End Set
    End Property

    Dim VAR_ShowBorder As Boolean = True
    Public Property ShowBorder As Boolean
        Get
            Return VAR_ShowBorder
        End Get
        Set(value As Boolean)
            VAR_ShowBorder = value
            BORDER_Top.Visible = VAR_ShowBorder
            BORDER_Bottom.Visible = VAR_ShowBorder
            BORDER_Left.Visible = VAR_ShowBorder
            BORDER_Right.Visible = VAR_ShowBorder
        End Set
    End Property

    Dim VAR_BorderSize As Integer = 1
    Public Property BorderSize As Integer
        Get
            Return VAR_BorderSize
        End Get
        Set(value As Integer)
            VAR_BorderSize = value

            BORDER_Top.Size = New Size(VAR_BorderSize, VAR_BorderSize)
            BORDER_Bottom.Size = New Size(VAR_BorderSize, VAR_BorderSize)
            BORDER_Left.Size = New Size(VAR_BorderSize, VAR_BorderSize)
            BORDER_Right.Size = New Size(VAR_BorderSize, VAR_BorderSize)
        End Set
    End Property



    Private Sub NewBorders()
        BORDER_Top.Size = New Size(1, 1)
        BORDER_Top.Dock = DockStyle.Top
        BORDER_Top.BackColor = VAR_BorderColor

        BORDER_Bottom.Size = New Size(1, 1)
        BORDER_Bottom.Dock = DockStyle.Bottom
        BORDER_Bottom.BackColor = VAR_BorderColor

        BORDER_Left.Size = New Size(1, 1)
        BORDER_Left.Dock = DockStyle.Left
        BORDER_Left.BackColor = VAR_BorderColor

        BORDER_Right.Size = New Size(1, 1)
        BORDER_Right.Dock = DockStyle.Right
        BORDER_Right.BackColor = VAR_BorderColor


        Me.Controls.Add(BORDER_Top)
        Me.Controls.Add(BORDER_Bottom)
        Me.Controls.Add(BORDER_Left)
        Me.Controls.Add(BORDER_Right)
    End Sub

    Private Sub CountPanel_ControlAdded(sender As Object, e As ControlEventArgs) Handles Me.ControlAdded
        BORDER_Top.SendToBack()
        BORDER_Bottom.SendToBack()
        BORDER_Left.SendToBack()
        BORDER_Right.SendToBack()
    End Sub

    Private Sub CountPanel_ControlRemoved(sender As Object, e As ControlEventArgs) Handles Me.ControlRemoved
        BORDER_Top.SendToBack()
        BORDER_Bottom.SendToBack()
        BORDER_Left.SendToBack()
        BORDER_Right.SendToBack()
    End Sub
End Class
