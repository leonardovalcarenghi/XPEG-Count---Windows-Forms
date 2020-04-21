
Imports System.ComponentModel

<DefaultEvent("CategorySelectedChanged")>
Public Class CountCategorySelector

    Public Event CategorySelectedChanged()

    Private Sub CountCategorySelector_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Btn_Select.Image = _FUNCTIONS.Images.InvertColorFromImage(Btn_Select.Image, Color.White)
    End Sub

    Dim VAR_SelectedCategoryCode
    Public Property SelectedCategoryCode As String
        Get
            Return VAR_SelectedCategoryCode
        End Get
        Set(value As String)
            VAR_SelectedCategoryCode = value

            If VAR_SelectedCategoryCode <> Nothing And IO.Directory.Exists(_DIRECTORIES.CategorysPath & VAR_SelectedCategoryCode) Then
                Dim CategoryName As String = _CATEGORYS.GetName(VAR_SelectedCategoryCode)
                Dim CategoryColor As Color = _CATEGORYS.GetColor(VAR_SelectedCategoryCode)
                Dim IconColor As Color = _CATEGORYS.GetIconColor(VAR_SelectedCategoryCode)
                Dim CategoryIcon As Image = _CATEGORYS.GetIconImage(VAR_SelectedCategoryCode)

                If Not CategoryIcon Is Nothing Then
                    CategoryIcon = _FUNCTIONS.Images.ChangeImageResolution(CategoryIcon, 24, 24)
                    CategoryIcon = _FUNCTIONS.Images.InvertColorFromImage(CategoryIcon, IconColor)
                    CategoryIcon_PictureBox.Image = CategoryIcon

                    CategoryIcon_PictureBox.Width = 28 : CategoryIcon_PictureBox.Show()

                Else
                    CategoryIcon_PictureBox.Image = Nothing
                    CategoryIcon_PictureBox.Width = 6 : CategoryIcon_PictureBox.Show()
                End If

                CategoryIcon_PictureBox.BackColor = CategoryColor
                CategoryName_Label.Text = " " & CategoryName

                RaiseEvent CategorySelectedChanged()
            End If
        End Set
    End Property

    Private Sub Btn_Select_MouseClick(sender As Object, e As MouseEventArgs) Handles Btn_Select.MouseClick
        If e.Button = MouseButtons.Left Then
            Dim SelectCategory As New SelectExpenseCategoryDialog : SelectCategory = New SelectExpenseCategoryDialog
            If SelectCategory.ShowDialog = Windows.Forms.DialogResult.OK Then
                Me.SelectedCategoryCode = SelectCategory.SelectCategoryCode
            End If
        End If
    End Sub

    Private Sub Btn_Select_MouseDown(sender As Object, e As MouseEventArgs) Handles Btn_Select.MouseDown
        If e.Button = MouseButtons.Left Then Btn_Select.BackColor = Color.FromArgb(115, 115, 115)
    End Sub

    Private Sub Btn_Select_MouseEnter(sender As Object, e As EventArgs) Handles Btn_Select.MouseEnter
        Btn_Select.BackColor = Color.FromArgb(110, 110, 110)
    End Sub

    Private Sub Btn_Select_MouseLeave(sender As Object, e As EventArgs) Handles Btn_Select.MouseLeave
        Btn_Select.BackColor = Color.FromArgb(100, 100, 100)
    End Sub
End Class
