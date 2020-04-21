Public Class BlockInformationsControl

    Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        Me.BackColor = Color.Transparent
    End Sub


    Public Property BlockTitle As String
        Get
            Return BlockTitle_Label.Text
        End Get
        Set(value As String)
            Select Case value
                Case "" : BlockText_Label.Top = (PanelInformations.Height - BlockText_Label.Height) / 2
                Case Else : BlockText_Label.Top = 22
            End Select
            BlockTitle_Label.Text = value
        End Set
    End Property

    Public Property BlockText As String
        Get
            Return BlockText_Label.Text
        End Get
        Set(value As String)
            BlockText_Label.Text = value
        End Set
    End Property

    Public Property BlockIcon As Image
        Get
            Return BlockIcon_PictureBox.Image
        End Get
        Set(value As Image)
            BlockIcon_PictureBox.Image = value
        End Set
    End Property

    Public Property ShowIcon As Boolean
        Get
            Return PanelIcon.Visible
        End Get
        Set(value As Boolean)
            PanelIcon.Visible = value
        End Set
    End Property

    Public Property AllowMouseClick As Boolean

    Public Property ExpenseHighlightColor As Color

End Class
