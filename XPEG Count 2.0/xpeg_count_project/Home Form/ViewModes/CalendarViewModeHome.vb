Public Class CalendarViewModeHome

    Private Sub CalendarViewModeHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Dock = DockStyle.Fill : Me.BackColor = Color.Transparent
    End Sub

#Region "Meses do Calendário"

    Private Sub ResetCalendar()
        ''Remover "Selecionado" dos Meses do Calendário:
        Try : For Each MONTH_ITEM As MonthsLabelsForCalendarMode In MonthsPanel.Controls : MONTH_ITEM.MenuSelected = False : Next : Catch : End Try

        ''Limpar Lista de Despesa:
        ExpensesListPanel.Controls.Clear()
    End Sub

    Private Sub MonthItem_01_January_MouseClick(sender As Object, e As MouseEventArgs) Handles MonthItem_01_January.MouseClick
        ''Resetar Calendário:
        ResetCalendar()
        ''Selecionar Esse Mês
        MonthItem_01_January.MenuSelected = True
    End Sub

    Private Sub MonthItem_02_February_MouseClick(sender As Object, e As MouseEventArgs) Handles MonthItem_02_February.MouseClick
        ''Resetar Calendário:
        ResetCalendar()
        ''Selecionar Esse Mês
        MonthItem_02_February.MenuSelected = True
    End Sub

    Private Sub MonthItem_03_March_MouseClick(sender As Object, e As MouseEventArgs) Handles MonthItem_03_March.MouseClick
        ''Resetar Calendário:
        ResetCalendar()
        ''Selecionar Esse Mês
        MonthItem_03_March.MenuSelected = True
    End Sub

    Private Sub MonthItem_04_April_MouseClick(sender As Object, e As MouseEventArgs) Handles MonthItem_04_April.MouseClick
        ''Resetar Calendário:
        ResetCalendar()
        ''Selecionar Esse Mês
        MonthItem_04_April.MenuSelected = True
    End Sub

    Private Sub MonthItem_05_May_MouseClick(sender As Object, e As MouseEventArgs) Handles MonthItem_05_May.MouseClick
        ''Resetar Calendário:
        ResetCalendar()
        ''Selecionar Esse Mês
        MonthItem_05_May.MenuSelected = True
    End Sub

    Private Sub MonthItem_06_June_MouseClick(sender As Object, e As MouseEventArgs) Handles MonthItem_06_June.MouseClick
        ''Resetar Calendário:
        ResetCalendar()
        ''Selecionar Esse Mês
        MonthItem_06_June.MenuSelected = True
    End Sub

    Private Sub MonthItem_07_July_MouseClick(sender As Object, e As MouseEventArgs) Handles MonthItem_07_July.MouseClick
        ''Resetar Calendário:
        ResetCalendar()
        ''Selecionar Esse Mês
        MonthItem_07_July.MenuSelected = True
    End Sub

    Private Sub MonthItem_08_August_MouseClick(sender As Object, e As MouseEventArgs) Handles MonthItem_08_August.MouseClick
        ''Resetar Calendário:
        ResetCalendar()
        ''Selecionar Esse Mês
        MonthItem_08_August.MenuSelected = True
    End Sub

    Private Sub MonthItem_09_September_MouseClick(sender As Object, e As MouseEventArgs) Handles MonthItem_09_September.MouseClick
        ''Resetar Calendário:
        ResetCalendar()
        ''Selecionar Esse Mês
        MonthItem_09_September.MenuSelected = True
    End Sub

    Private Sub MonthItem_10_October_MouseClick(sender As Object, e As MouseEventArgs) Handles MonthItem_10_October.MouseClick
        ''Resetar Calendário:
        ResetCalendar()
        ''Selecionar Esse Mês
        MonthItem_10_October.MenuSelected = True
    End Sub

    Private Sub MonthItem_11_November_MouseClick(sender As Object, e As MouseEventArgs) Handles MonthItem_11_November.MouseClick
        ''Resetar Calendário:
        ResetCalendar()
        ''Selecionar Esse Mês
        MonthItem_11_November.MenuSelected = True
    End Sub

    Private Sub MonthItem_12_December_MouseClick(sender As Object, e As MouseEventArgs) Handles MonthItem_12_December.MouseClick
        ''Resetar Calendário:
        ResetCalendar()
        ''Selecionar Esse Mês
        MonthItem_12_December.MenuSelected = True
    End Sub
#End Region
    
End Class
