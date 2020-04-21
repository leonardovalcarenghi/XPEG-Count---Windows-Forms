Imports System.ComponentModel

<DefaultEvent("MouseClick")>
Public Class MenuItemListControl

    Sub New()
        ' Esta chamada é requerida pelo designer.
        InitializeComponent()
        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        Dock = DockStyle.Top : BackColor = Color.Transparent
    End Sub

    Private Sub ItemControl_SizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        Select Case Me.Width : Case 50 : ModeIcon() : Case Is > 50 : ModeFullMenu() : End Select
    End Sub


#Region "Propriedades do Elemento"
    Public Property MenuText As String
        Get
            Return MenuTextLabel.Text
        End Get
        Set(value As String)
            MenuTextLabel.Text = value
        End Set
    End Property

    Public Property MenuIcon As Image
        Get
            Return MenuIconPictureBox.Image
        End Get
        Set(value As Image)
            MenuIconPictureBox.Image = value
        End Set
    End Property

    Dim VAR_ClickAndClose As Boolean = True
    Public Property ClickAndClose As Boolean
        Get
            Return VAR_ClickAndClose
        End Get
        Set(value As Boolean)
            VAR_ClickAndClose = value
        End Set
    End Property

#End Region

#Region "Modo de Visualização"
    Private Sub ModeIcon()
        ''Adaptar Posição do Icone:
        IconBasePanel.Width = Me.Width
        MenuIconPictureBox.Left = (IconBasePanel.Width - MenuIconPictureBox.Width) / 2

        ''Esconder Título:
        TitleBasePanel.Hide()

        ''ToolTip no Icone:
        ItemMenuToolTip.SetToolTip(IconBasePanel, MenuText)
        ItemMenuToolTip.SetToolTip(MenuIconPictureBox, MenuText)
    End Sub

    Private Sub ModeFullMenu()
        ''Adaptar Posição do Icone:
        IconBasePanel.Width = 70
        MenuIconPictureBox.Left = (IconBasePanel.Width - MenuIconPictureBox.Width)

        ''Exibir Título:
        TitleBasePanel.Show()

        ''Remover ToolTip no Icone:
        ItemMenuToolTip.RemoveAll()
    End Sub
#End Region

#Region "Eventos do Mouse"
    Private Sub MenuItem_MouseClick(sender As Object, e As MouseEventArgs) Handles TitleBasePanel.MouseClick, MenuTextLabel.MouseClick, MenuIconPictureBox.MouseClick, ItemBaseBackgroundPanel.MouseClick, IconBasePanel.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Dim HomeForm As XpegCountForm = FindForm()
            If ClickAndClose = True Then HomeForm.CloseMenu()
            MyBase.OnMouseClick(e) : Invalidate()
        End If
    End Sub

    Private Sub MenuItem_MouseDown(sender As Object, e As MouseEventArgs) Handles TitleBasePanel.MouseDown, MenuTextLabel.MouseDown, MenuIconPictureBox.MouseDown, ItemBaseBackgroundPanel.MouseDown, IconBasePanel.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then ItemBaseBackgroundPanel.BackColor = Color.FromArgb(20, 20, 20) : MyBase.OnMouseDown(e) : Invalidate()
    End Sub

    Private Sub MenuItem_MouseEnter(sender As Object, e As EventArgs) Handles TitleBasePanel.MouseEnter, MenuTextLabel.MouseEnter, MenuIconPictureBox.MouseEnter, ItemBaseBackgroundPanel.MouseEnter, IconBasePanel.MouseEnter
        ItemBaseBackgroundPanel.BackColor = Color.FromArgb(25, 25, 25)
        MyBase.OnMouseEnter(e) : Invalidate()
    End Sub

    Private Sub MenuItem_MouseLeave(sender As Object, e As EventArgs) Handles TitleBasePanel.MouseLeave, MenuTextLabel.MouseLeave, MenuIconPictureBox.MouseLeave, ItemBaseBackgroundPanel.MouseLeave, IconBasePanel.MouseLeave
        ItemBaseBackgroundPanel.BackColor = Color.Transparent
        MyBase.OnMouseLeave(e) : Invalidate()
    End Sub
#End Region
    
End Class
