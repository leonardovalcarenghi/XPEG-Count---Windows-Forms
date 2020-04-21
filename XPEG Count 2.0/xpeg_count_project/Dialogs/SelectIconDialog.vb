Imports System.Windows.Forms
Imports System.IO

Public Class SelectIconDialog

    Private Sub SelectIconDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCategorysIcons()
    End Sub

    Dim LIST_CategorysCtrl As New List(Of CategoryIconList)
    Private Sub LoadCategorysIcons()
        'LIMPAR LISTA DE CATEGORIAS NO MENU
        IconsCategoryMenu.Controls.Clear() : FlowLayout_IconsList.Controls.Clear()

        Dim DirPath As DirectoryInfo = New DirectoryInfo(_DIRECTORIES.IconsPath)
        Dim CategoryFolders() As DirectoryInfo = DirPath.GetDirectories
        For Each i As DirectoryInfo In CategoryFolders
            Dim ItemCategory As New CategoryIconList : ItemCategory = New CategoryIconList
            LIST_CategorysCtrl.Add(ItemCategory)
            ItemCategory.FORM_ICON = Me
            ItemCategory.CATEGORY_Path = i.FullName
            ItemCategory.CategoryName = i.Name
            IconsCategoryMenu.Controls.Add(ItemCategory) : ItemCategory.BringToFront()
        Next

        Try
            LoadIconsFromCategory(CategoryFolders(0).FullName)
            LIST_CategorysCtrl(0).CategorySelected = True
        Catch ex As Exception

        End Try


        If CategoryFolders.Length = 0 Then FlowLayout_IconsList.Controls.Add(CategoryIconList_SemIcones)


        For Each A As CategoryIconList In LIST_CategorysCtrl
            If A.CategoryName = "Outros" Then A.BringToFront()
        Next


    End Sub

    Public Sub LoadIconsFromCategory(ByVal category_path As String)
        'LIMPAR LISTA E RESETAR CATEGORIAS'
        FlowLayout_IconsList.Controls.Clear()
        For Each A As CategoryIconList In IconsCategoryMenu.Controls : A.CategorySelected = False : Next

        Dim DirPath As DirectoryInfo = New DirectoryInfo(category_path)
        Dim IconsSubCategory() As DirectoryInfo = DirPath.GetDirectories
        Dim IconsFiles() As FileInfo = DirPath.GetFiles
        Select Case IconsSubCategory.Length
            Case 0
                LoadIcons(DirPath.FullName)
                Dim CategoryLabel As New CategoryIconsSeparatorControl : CategoryLabel = New CategoryIconsSeparatorControl
                CategoryLabel.CategoryName = DirPath.Name
                FlowLayout_IconsList.Controls.Add(CategoryLabel) : CategoryLabel.BringToFront()

            Case Else
                If IconsFiles.Length <> 0 Then
                    Dim CategoryLabel As New CategoryIconsSeparatorControl : CategoryLabel = New CategoryIconsSeparatorControl
                    CategoryLabel.CategoryName = DirPath.Name
                    FlowLayout_IconsList.Controls.Add(CategoryLabel) ' : CategoryLabel.BringToFront()

                    LoadIcons(DirPath.FullName)
                End If

                For Each A As DirectoryInfo In IconsSubCategory
                    Dim CategoryLabel As New CategoryIconsSeparatorControl : CategoryLabel = New CategoryIconsSeparatorControl
                    CategoryLabel.CategoryName = A.Name
                    FlowLayout_IconsList.Controls.Add(CategoryLabel)
                    LoadIcons(A.FullName)
                Next




        End Select
        FlowLayout_IconsList.Controls.Add(PanelSeparator) : PanelSeparator.SendToBack()

    End Sub

    Private Sub LoadIcons(ByVal path As String)
        Dim DirPath As DirectoryInfo = New DirectoryInfo(path)
        Dim IconsFiles() As FileInfo = DirPath.GetFiles
        For Each i As FileInfo In IconsFiles
            Dim Item As New IconSelectItemControl : Item = New IconSelectItemControl
            Dim img As Image = Image.FromFile(i.FullName)
            Item.IMAGE_File = i.FullName
            Item.FORM_SelectIcon = Me
            Item.PictureBox_Icone.Image = _FUNCTIONS.Images.ChangeImageResolution(img, 40, 40)
            Item.ToolTip1.SetToolTip(Item.PictureBox_Icone, i.Name.Replace(".png", ""))
            FlowLayout_IconsList.Controls.Add(Item) ': Item.BringToFront()
        Next



    End Sub

    Dim VAR_SelectIconFile As String
    Public Property SelectIconFile As String
        Get
            Return VAR_SelectIconFile

        End Get
        Set(value As String)
            VAR_SelectIconFile = value
            Dim FileIcon As FileInfo = New FileInfo(VAR_SelectIconFile)
            Label_File.Text = FileIcon.Name.Replace(".png", "")

            Dim ImgIcon As Image = Image.FromFile(VAR_SelectIconFile)
            ImgIcon = _FUNCTIONS.Images.ChangeImageResolution(ImgIcon, 34, 34)
            PictureBox_SelectedIcon.Image = ImgIcon
        End Set
    End Property

    Private Sub Button_OK_Click(sender As Object, e As EventArgs) Handles Button_OK.Click
        If SelectIconFile <> Nothing Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        Else
            MsgBox("Selecione um icone!", MsgBoxStyle.Critical)
        End If
    End Sub
End Class
