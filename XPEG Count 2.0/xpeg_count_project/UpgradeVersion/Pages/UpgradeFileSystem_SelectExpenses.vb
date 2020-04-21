Imports System.IO

Public Class UpgradeFileSystem_SelectExpenses

    Public WithEvents FORM_Parent As UpgradeFileSystemDialog
    Private Sub UpgradeFileSystem_SelectExpenses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Dock = DockStyle.Fill
        Me.BackColor = Color.Transparent

        MoveExpensesToFolder()
    End Sub

    Dim PATH_old_system As DirectoryInfo
    Private Sub MoveExpensesToFolder()

        Dim ExpensesList = _EXPENSES.GetExpenses

        'Criar Diretório com as Parcelas do Sistema Antigo
        PATH_old_system = New DirectoryInfo(_DIRECTORIES.PrimaryPath & "old_system\")
        PATH_old_system.Create()


        For Each A As String In ExpensesList
            Dim ExpenseFile = _DIRECTORIES.ExpensesPath & A & "\expense.ini"
            If IO.File.Exists(ExpenseFile) Then
                IO.Directory.Move(_DIRECTORIES.ExpensesPath & A, PATH_old_system.FullName & A)
            End If
        Next
        ImportExpenses()

    End Sub
    Public ExpensesList As New List(Of String)
    Private Sub ImportExpenses()

        CheckedListBox_Expenses.Items.Clear()

        ' ExpensesList = _EXPENSES_AND_PLOTS.GetExenses

        Dim ExpensesInOldSystem() As DirectoryInfo = PATH_old_system.GetDirectories()

        For Each A As DirectoryInfo In ExpensesInOldSystem
            ExpensesList.Add(A.Name)
            Dim ExpenseFile = A.FullName & "\expense.ini"
            If IO.File.Exists(ExpenseFile) Then
                Dim ExpenseName = _INI.ReadIniFile(ExpenseFile, "EXPENSE", "name", "error")
                CheckedListBox_Expenses.Items.Add(ExpenseName)
            End If


        Next
        FORM_Parent.Button_Next.Enabled = False
    End Sub

    Private Sub LinkLabel_SelectAll_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel_SelectAll.LinkClicked
        For i As Integer = 0 To CheckedListBox_Expenses.Items.Count - 1
            CheckedListBox_Expenses.SetItemChecked(i, True)
        Next
        FORM_Parent.Button_Next.Enabled = True
    End Sub

    Private Sub LinkLabel_SelectNone_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel_SelectNone.LinkClicked
        For i As Integer = 0 To CheckedListBox_Expenses.Items.Count - 1
            CheckedListBox_Expenses.SetItemChecked(i, False)
        Next
        FORM_Parent.Button_Next.Enabled = False
    End Sub

    Private Sub CheckedListBox_Expenses_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBox_Expenses.SelectedIndexChanged
        If CheckedListBox_Expenses.CheckedItems.Count = 0 Then
            FORM_Parent.Button_Next.Enabled = False
        Else
            FORM_Parent.Button_Next.Enabled = True
        End If

        'For i As Integer = 0 To CheckedListBox_Expenses.Items.Count - 1
        '    If CheckedListBox_Expenses.GetItemChecked(i) = True Then
        '        FORM_Parent.LIST_ExpensesToConvert.Add(ExpensesList.Item(i))
        '    Else
        '        If CheckedListBox_Expenses.GetItemChecked(i) = False Then
        '            If FORM_Parent.LIST_ExpensesToConvert.Contains(ExpensesList.Item(i)) Then
        '                FORM_Parent.LIST_ExpensesToConvert.RemoveAt(i)
        '            End If
        '        End If

        '    End If
        'Next


    End Sub

    Private Sub CheckedListBox_Expenses_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles CheckedListBox_Expenses.ItemCheck
        'If e.CurrentValue = CheckState.Checked Then
        '    FORM_Parent.LIST_ExpensesToConvert.Add(ExpensesList.Item(e.Index))
        'Else
        '    Try
        '        FORM_Parent.LIST_ExpensesToConvert.RemoveAt(e.Index)
        '    Catch ex As Exception

        '    End Try

        'End If

    End Sub
End Class
