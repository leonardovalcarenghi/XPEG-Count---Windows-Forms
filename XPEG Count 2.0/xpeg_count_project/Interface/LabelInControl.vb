Public Class LabelInControl

    Private Sub LabelInControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.Transparent
    End Sub

    Public Property Description As String
        Get
            Return LabelText.Text
        End Get
        Set(value As String)
            LabelText.Text = value
        End Set
    End Property

    Dim _DockTop As Boolean = False
    Public Property DockTop As Boolean
        Get
            Return _DockTop
        End Get
        Set(value As Boolean)
            _DockTop = value
            If value = True Then Me.Dock = DockStyle.Top Else Me.Dock = DockStyle.None
        End Set
    End Property
End Class
