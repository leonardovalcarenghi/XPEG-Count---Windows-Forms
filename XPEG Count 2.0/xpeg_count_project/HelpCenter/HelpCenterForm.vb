Imports System.IO

Public Class HelpCenterForm

    Private Sub HelpCenterForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = Screen.PrimaryScreen.WorkingArea.Width - 10
        Me.Height = Screen.PrimaryScreen.WorkingArea.Height - 10
        Me.Left = 5 : Me.Top = 5

        ImportCategorysOfHelp()
    End Sub

    Private Sub ImportCategorysOfHelp()
        Dim ListOfCategorys = _SOFTWARE.GetHelpCategorys
        For Each CATEGORY As DirectoryInfo In ListOfCategorys
            Dim Item As HelpCategoryItemList = New HelpCategoryItemList
            Item.CategoryOfHelp_Path = CATEGORY : Item.FormFather = Me
            CategorysListPanel.Controls.Add(Item)
        Next

    End Sub
End Class