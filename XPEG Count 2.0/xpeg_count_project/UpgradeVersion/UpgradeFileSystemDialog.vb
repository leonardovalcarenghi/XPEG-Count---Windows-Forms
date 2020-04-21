Imports System.Windows.Forms

Public Class UpgradeFileSystemDialog

    Public LIST_ExpensesToConvert As New List(Of String)


    Public PAGE_Welcome As New UpgradeFileSystem_WelcomeToNewVersion
    Public PAGE_SelectExpenses As New UpgradeFileSystem_SelectExpenses
    Public PAGE_Converting As New UpgradeFileSystem_Converting

    Dim PageSelected = 0

    Private Sub UpgradeFileSystemDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PAGE_SelectExpenses.FORM_Parent = Me
        PAGE_Converting.FORM_Parent = Me

        PagesCtrlPanel.Controls.Add(PAGE_Welcome)
    End Sub

    Private Sub Button_Next_Click(sender As Object, e As EventArgs) Handles Button_Next.Click
        PageSelected += 1
        Select Case PageSelected
            Case 1
                Button_Back.Show()

                PagesCtrlPanel.Controls.Clear()
                PagesCtrlPanel.Controls.Add(PAGE_SelectExpenses)
            Case 2

                Button_Back.Enabled = False
                Button_Next.Enabled = False

                For i As Integer = 0 To PAGE_SelectExpenses.CheckedListBox_Expenses.Items.Count - 1
                    If PAGE_SelectExpenses.CheckedListBox_Expenses.GetItemChecked(i) = True Then
                        Me.LIST_ExpensesToConvert.Add(PAGE_SelectExpenses.ExpensesList.Item(i))
                    End If
                Next

                PagesCtrlPanel.Controls.Clear()
                PagesCtrlPanel.Controls.Add(PAGE_Converting)

                PAGE_Converting.Timer_Convert.Start()
        End Select
    End Sub

    Private Sub Button_Back_Click(sender As Object, e As EventArgs) Handles Button_Back.Click
        PageSelected -= 1
        Select Case PageSelected
            Case 2
                Button_Next.Enabled = True
                Button_Back.Hide()
                PagesCtrlPanel.Controls.Clear()
                PagesCtrlPanel.Controls.Add(PAGE_Welcome)
            Case 3
                PagesCtrlPanel.Controls.Clear()
                PagesCtrlPanel.Controls.Add(PAGE_SelectExpenses)
        End Select
    End Sub
End Class
