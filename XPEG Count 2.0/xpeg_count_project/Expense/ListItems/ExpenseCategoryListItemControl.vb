Public Class ExpenseCategoryListItemControl

    Public CATEGORY_Code
    Public CATEGORY_File

    Private Sub ExpenseCategoryListItemControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Dock = DockStyle.Top
        Me.BackColor = Color.Transparent



        If CATEGORY_Code = "" And CATEGORY_File = "" Then
            DefaultInformations()
        Else
            LoadInformations()
        End If

    End Sub

    Private Sub DefaultInformations()
        ''NOME DA CATEGORIA''
        Dim NomeDaCategoria As String = "despesas sem categoria"
        CategoryTitle_Label.Text = NomeDaCategoria

        ''COR DA CATEGORIA''
        Dim CorDaCategoria As Color = Color.Black
        CategoryIcon_PictureBox.BackColor = CorDaCategoria
    End Sub

    Private Sub LoadInformations()
        ''NOME DA CATEGORIA''
        Dim NomeDaCategoria As String = _CATEGORYS.GetName(CATEGORY_Code)
        CategoryTitle_Label.Text = NomeDaCategoria

        ''ICONE DA CATEGORIA''
        Dim CategoryIcon As Image = _CATEGORYS.GetIconImage(CATEGORY_Code)

        Dim CorDoIcone As Color
        Try : CorDoIcone = Color.FromArgb(_INI.ReadIniFile(CATEGORY_File, "ICON", "color")) : Catch : End Try

        If Not IsNothing(CategoryIcon) Then
            If CategoryIcon.Width > _PROPERTY_CATEGORYS_IMAGE_SIZE.Width Then
                CategoryIcon = _FUNCTIONS.Images.ChangeImageResolution(CategoryIcon, 20)
                CategoryIcon = _FUNCTIONS.Images.InvertColorFromImage(CategoryIcon, CorDoIcone)
                CategoryIcon_PictureBox.Image = CategoryIcon
            End If
        End If


        ''COR DA CATEGORIA''
        Dim CorDaCategoria As Color = Color.FromArgb(_INI.ReadIniFile(CATEGORY_File, "CATEGORY", "color"))
        PanelColor.BackColor = CorDaCategoria


        ''Arredondar Bordas:
        '   _FUNCTIONS.Interfaces.MakeRoundedEdges(PanelColor, 1)

    End Sub


    Public Property SelectForm As SelectExpenseCategoryDialog


    Private Sub CategoryPanel_MouseClick(sender As Object, e As MouseEventArgs) Handles CategoryTitle_Label.MouseClick, CategoryPanel.MouseClick, CategoryIcon_PictureBox.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Left Then
            SelectForm.SelectCategoryCode = CATEGORY_Code
            SelectForm.DialogResult = DialogResult.OK : SelectForm.Close()
        End If
    End Sub

    Private Sub CategoryPanel_MouseDown(sender As Object, e As MouseEventArgs) Handles CategoryTitle_Label.MouseDown, CategoryPanel.MouseDown, CategoryIcon_PictureBox.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then CategoryPanel.BackColor = Color.FromArgb(225, 225, 225)
    End Sub

    Private Sub CategoryPanel_MouseEnter(sender As Object, e As EventArgs) Handles CategoryTitle_Label.MouseEnter, CategoryPanel.MouseEnter, CategoryIcon_PictureBox.MouseEnter
        CategoryPanel.BackColor = Color.FromArgb(230, 230, 230)
    End Sub

    Private Sub CategoryPanel_MouseLeave(sender As Object, e As EventArgs) Handles CategoryTitle_Label.MouseLeave, CategoryPanel.MouseLeave, CategoryIcon_PictureBox.MouseLeave
        CategoryPanel.BackColor = Color.Transparent
    End Sub
End Class
