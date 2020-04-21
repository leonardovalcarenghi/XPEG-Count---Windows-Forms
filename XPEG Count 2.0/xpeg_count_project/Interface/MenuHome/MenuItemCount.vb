Public Class MenuItemCount

    Private Sub MenuItemCount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Dock = DockStyle.Top : Me.BackColor = Color.Transparent
    End Sub

    Public Property MenuTitle As String
        Get
            Return MenuTitleLabel.Text
        End Get
        Set(value As String)
            MenuTitleLabel.Text = value
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
End Class
