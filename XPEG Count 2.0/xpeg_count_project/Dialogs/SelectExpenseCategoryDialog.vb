Imports System.Windows.Forms
Imports System.IO

Public Class SelectExpenseCategoryDialog


    Private Sub SelectExpenseCategoryDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ImportCategorys()
    End Sub

    Public AddCategoryDefault As Boolean = False
    Public LIST_DefaultCategorys As New List(Of ExpenseCategoryListItemControl)

    Private Sub ImportCategorys()
        ListCategory_PAnel.Controls.Clear()

        Dim DirPath As DirectoryInfo = New DirectoryInfo(_DIRECTORIES.CategorysPath)
        Dim CategorysFolders() As DirectoryInfo : CategorysFolders = DirPath.GetDirectories()
        For Each A As DirectoryInfo In CategorysFolders
            Dim CategoryInfoFile As String = A.FullName & "\category.ini"

            Dim Item As New ExpenseCategoryListItemControl : Item = New ExpenseCategoryListItemControl
            Item.SelectForm = Me



            Item.CATEGORY_Code = A.Name
            Item.CATEGORY_File = CategoryInfoFile

            Select Case ShowCreditCard
                Case False
                    If A.Name <> "XC.CATEGORY_CREDITCARD" Then
                        If A.Name.Contains("XC.CATEGORY_") Then LIST_DefaultCategorys.Add(Item)
                        ListCategory_PAnel.Controls.Add(Item) : Item.BringToFront()
                    End If

                Case True
                    If A.Name.Contains("XC.CATEGORY_") Then LIST_DefaultCategorys.Add(Item)

                    ListCategory_PAnel.Controls.Add(Item) : Item.BringToFront()
            End Select



        Next
        If AddCategoryDefault = True Then AddCategoryNone()

        ''Colocar as categoras padrões no topo da lista e em ordem alfabetica''
        Dim L() As String = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"}
        For I = L.Length - 1 To 0 Step -1

            For Each B As ExpenseCategoryListItemControl In LIST_DefaultCategorys
                Dim CategoryName = _CATEGORYS.GetName(B.CATEGORY_Code)

                If CategoryName.StartsWith(L(I)) Then B.SendToBack()
            Next

        Next

    End Sub

    Sub AddCategoryNone()
        Dim Item As New ExpenseCategoryListItemControl : Item = New ExpenseCategoryListItemControl
        Item.SelectForm = Me

        Item.CATEGORY_Code = ""
        Item.CATEGORY_File = ""

        ListCategory_PAnel.Controls.Add(Item) : Item.BringToFront()
    End Sub

    Public Property SelectCategoryCode As String

    Public Property ShowCreditCard As Boolean = True

    Private Sub Button_Close_Click(sender As Object, e As EventArgs) Handles Button_Close.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
End Class
