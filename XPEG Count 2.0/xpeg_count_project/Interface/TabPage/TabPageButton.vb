Imports System.ComponentModel

<DefaultEvent("MouseClick")>
Public Class TabPageButton

    Private Sub TabPageButtonControl_MouseClick(sender As Object, e As MouseEventArgs) Handles TabPageButtonTextLabel.MouseClick, TabPageButtonControl.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MyBase.OnClick(e) : Invalidate()
            SelectThisPage()
            ' ButtonSelected = True
        End If
    End Sub

    Private Sub TabPageButtonControl_MouseDown(sender As Object, e As MouseEventArgs) Handles TabPageButtonTextLabel.MouseDown, TabPageButtonControl.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then TabPageButtonControl.BackColor = Color.FromArgb(220, 220, 220)
    End Sub

    Private Sub TabPageButtonControl_MouseEnter(sender As Object, e As EventArgs) Handles TabPageButtonTextLabel.MouseEnter, TabPageButtonControl.MouseEnter
        TabPageButtonControl.BackColor = Color.FromArgb(230, 230, 230)
    End Sub

    Private Sub TabPageButtonControl_MouseLeave(sender As Object, e As EventArgs) Handles TabPageButtonTextLabel.MouseLeave, TabPageButtonControl.MouseLeave
        TabPageButtonControl.BackColor = Color.Transparent
    End Sub


    Public Property ButtonText As String
        Get
            Return TabPageButtonTextLabel.Text
        End Get
        Set(value As String)
            TabPageButtonTextLabel.Text = value

            ' Dim WidthLabel = MeasureString(value, TabPageButtonTextLabel.Font, Me.Width)

            '  Me.Width = Val(WidthLabel.Width + 30)
            'TabPageButtonTextLabel.Left = (TabPageButtonTextLabel.Width - Me.Width) / 2
        End Set
    End Property

    'Friend Function MeasureString(text As String, font As Font, width As Integer) As SizeF
    'Return MeasureString(text, font, width)
    ' End Function

    Public Property ButtonColor As Color = Color.DarkBlue


    Public Property PageCtrl As Control
    Public Property ButtonsTabContainer As TabButtonsContainer

    Dim VAR_ButtonSelected As Boolean = False
    Public Property ButtonSelected As Boolean
        Get
            Return VAR_ButtonSelected
        End Get
        Set(value As Boolean)
            VAR_ButtonSelected = value
            Select Case (value)
                Case True : TabPageButtonTextLabel.Font = New Font("Segoe UI Semibold", TabPageButtonTextLabel.Font.Size, FontStyle.Bold) ' ButtonsTabContainer.SelectTab(Me)
                Case False : TabPageButtonTextLabel.Font = New Font("Segoe UI Semilight", TabPageButtonTextLabel.Font.Size, FontStyle.Regular)
            End Select
        End Set
    End Property

    ''' <summary>
    ''' Selecionar Esta Página
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub SelectThisPage()
        ButtonsTabContainer.SelectTab(Me)
    End Sub

    Private Sub TabPageButton_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Sub New()

        ' Esta chamada é requerida pelo designer.
        MyBase.New()
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        Me.BringToFront()
        Me.Dock = DockStyle.Left
    End Sub
End Class
