Imports System.ComponentModel

<DefaultEvent("MouseClick")>
Public Class SelectViewFilterItemListControl

    Private Sub SelectViewFilterItemListControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Dock = DockStyle.Top
        Me.BackColor = Color.Transparent
    End Sub

    Dim VAR_FilterSelected As Boolean = False
    Public Property FilterSelected As Boolean
        Get
            Return VAR_FilterSelected

        End Get
        Set(value As Boolean)
            VAR_FilterSelected = value
            Select Case value
                Case True
                    FilterName_Label.Font = New Font("Segoe UI Semibold", FilterName_Label.Font.Size)
                    PictureBox_Selected.BackColor = Color.Blue

                Case False
                    FilterName_Label.Font = New Font("Segoe UI Semilight", FilterName_Label.Font.Size)
                    PictureBox_Selected.BackColor = Color.Transparent

            End Select
        End Set
    End Property



    Public Property FilterName As String
        Get
            Return FilterName_Label.Text
        End Get
        Set(value As String)
            FilterName_Label.Text = value
        End Set
    End Property

    Public Property FilterDescription As String
        Get
            Return FilterDescription_Label.Text
        End Get
        Set(value As String)
            FilterDescription_Label.Text = value
        End Set
    End Property

    Public Property FilterIcon As Image
        Get
            Return FilterIcon1_PictureBox.Image
        End Get
        Set(value As Image)
            FilterIcon1_PictureBox.Image = value
        End Set
    End Property

    Public Property FilterIcon2 As Image
        Get
            Return FilterIcon2_PictureBox.Image
        End Get
        Set(value As Image)
            FilterIcon2_PictureBox.Image = value
            If value Is Nothing Then
                FilterIcon1_PictureBox.Size = New Size(32, 32)
                FilterIcon2_PictureBox.Hide()
            Else
                FilterIcon1_PictureBox.Size = New Size(20, 20)
                FilterIcon2_PictureBox.Show()

                FilterIcon1_PictureBox.Image = _FUNCTIONS.Images.ChangeImageResolution(FilterIcon, 20, 20)
                FilterIcon2_PictureBox.Image = _FUNCTIONS.Images.ChangeImageResolution(value, 20, 20)
            End If
        End Set
    End Property


    Private Sub FilterPanel_MouseClick(sender As Object, e As MouseEventArgs) Handles FilterIcon1_PictureBox.MouseClick, PictureBox_Selected.MouseClick, Panel1.MouseClick, FilterPanel.MouseClick, FilterName_Label.MouseClick, FilterDescription_Label.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MyBase.OnMouseClick(e)
            Invalidate()
        End If
    End Sub

    Private Sub FilterPanel_MouseDown(sender As Object, e As MouseEventArgs) Handles FilterIcon1_PictureBox.MouseDown, PictureBox_Selected.MouseDown, Panel1.MouseDown, FilterPanel.MouseDown, FilterName_Label.MouseDown, FilterDescription_Label.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then FilterPanel.BackColor = Color.FromArgb(225, 225, 225)
    End Sub

    Private Sub FilterPanel_MouseEnter(sender As Object, e As EventArgs) Handles FilterIcon1_PictureBox.MouseEnter, PictureBox_Selected.MouseEnter, Panel1.MouseEnter, FilterPanel.MouseEnter, FilterName_Label.MouseEnter, FilterDescription_Label.MouseEnter
        FilterPanel.BackColor = Color.FromArgb(230, 230, 230)
    End Sub

    Private Sub FilterPanel_MouseLeave(sender As Object, e As EventArgs) Handles FilterIcon1_PictureBox.MouseLeave, PictureBox_Selected.MouseLeave, Panel1.MouseLeave, FilterPanel.MouseLeave, FilterName_Label.MouseLeave, FilterDescription_Label.MouseLeave
        FilterPanel.BackColor = Color.Transparent
    End Sub
End Class
