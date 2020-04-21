Public Class CategoryIconList

    Public FORM_ICON As SelectIconDialog
    Public CATEGORY_Path As String

    Private Sub CategoryIconList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Dock = DockStyle.Top
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

    Dim VAR_CAtegorySelected As Boolean = False
    Public Property CategorySelected As Boolean
        Get
            Return VAR_CAtegorySelected
        End Get
        Set(value As Boolean)
            VAR_CAtegorySelected = value
            Select Case value
                Case True
                    CategoryIcon_Label.Font = New Font("Segoe UI Semibold", CategoryIcon_Label.Font.Size)
                Case Else
                    CategoryIcon_Label.Font = New Font("Segoe UI", CategoryIcon_Label.Font.Size)
            End Select

        End Set
    End Property


    Private Sub CategoryIconList_MouseClick(sender As Object, e As MouseEventArgs) Handles MyBase.MouseClick, CategoryIcon_Label.MouseClick
        If e.Button = MouseButtons.Left Then
            FORM_ICON.LoadIconsFromCategory(CATEGORY_Path)
            Me.CategorySelected = True
        End If
    End Sub

    Private Sub CategoryIconList_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown, CategoryIcon_Label.MouseDown
        If e.Button = MouseButtons.Left Then
            Me.BackColor = Color.FromArgb(215, 215, 215)
        End If
    End Sub

    Private Sub CategoryIconList_MouseEnter(sender As Object, e As EventArgs) Handles MyBase.MouseEnter, CategoryIcon_Label.MouseEnter
        Me.BackColor = Color.FromArgb(220, 220, 220)
    End Sub

    Private Sub CategoryIconList_MouseLeave(sender As Object, e As EventArgs) Handles MyBase.MouseLeave, CategoryIcon_Label.MouseLeave
        Me.BackColor = Color.Transparent
    End Sub
End Class
