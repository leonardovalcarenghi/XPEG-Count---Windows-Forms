Public Class FilterBlockContainer
    Inherits ContainerControl

    Sub New()
        ' MyBase.New()
        ' Me.Height = 130
        ' Me.Dock = DockStyle.Top
        CreateElements()
    End Sub

    Dim WithEvents PanelTitle As New Panel
    Dim WithEvents LabelTitle As New Label
    Dim PanelContainer As New ContainerControl
    Dim PanelSeparator As New Panel

    Private Sub CreateElements()
        ''PAINEL TITLE
        PanelTitle.Height = 30
        PanelTitle.BackColor = Color.FromArgb(50, 50, 50)
        PanelTitle.Dock = DockStyle.Top
        MyBase.Controls.Add(PanelTitle)

        ''LABEL TITLE
        LabelTitle.Font = New Font("Segoe UI Semibold", 9)
        LabelTitle.ForeColor = Color.White
        LabelTitle.AutoSize = True
        'LabelTitle.Dock = DockStyle.Left
        LabelTitle.Text = "Block Filter"
        PanelTitle.Controls.Add(LabelTitle) : LabelTitle.Location = New Point(10, 8)

        ''PANEL SEPARATOR
        PanelSeparator.Height = 1
        PanelSeparator.BackColor = Color.FromArgb(70, 70, 70)
        PanelSeparator.Dock = DockStyle.Bottom
        MyBase.Controls.Add(PanelSeparator)

        ''PAINEL CONTAINER
        PanelContainer.Dock = DockStyle.Fill
        MyBase.Controls.Add(PanelContainer) : PanelContainer.BringToFront()

    End Sub

    Public Property BlockTitle As String
        Get
            Return LabelTitle.Text
        End Get
        Set(value As String)
            LabelTitle.Text = value
        End Set
    End Property

    Dim VAR_BlockHeight As Integer
    Public Property BlockHeight As Integer
        Get
            Return VAR_BlockHeight
        End Get
        Set(value As Integer)
            Me.Height = value
            VAR_BlockHeight = value
        End Set
    End Property

    Private Sub Title_MouseClick(sender As Object, e As MouseEventArgs) Handles PanelTitle.MouseClick, LabelTitle.MouseClick
        If Me.Height = 31 Then Me.Height = BlockHeight Else Me.Height = 31
    End Sub

    Private Sub Title_MouseEnter(sender As Object, e As EventArgs) Handles PanelTitle.MouseEnter, LabelTitle.MouseEnter
        PanelTitle.BackColor = Color.FromArgb(45, 45, 45)
    End Sub

    Private Sub Title_MouseLeave(sender As Object, e As EventArgs) Handles PanelTitle.MouseLeave, LabelTitle.MouseLeave
        PanelTitle.BackColor = Color.FromArgb(50, 50, 50)
    End Sub




End Class
