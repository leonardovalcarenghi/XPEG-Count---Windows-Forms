Public Class CategoryIconsSeparatorControl
    Private Sub CategoryIconsSeparatorControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.Transparent
    End Sub


    Public Property CategoryName As String
        Get
            Return CategoryIcon_Label.Text
        End Get
        Set(value As String)
            CategoryIcon_Label.Text = value
        End Set
    End Property
End Class
