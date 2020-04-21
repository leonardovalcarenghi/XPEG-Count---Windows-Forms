Imports System.IO

Public Class ExpensePlotItemControl

    ''' <summary>
    ''' Código da Despesa
    ''' </summary>
    ''' <remarks></remarks>
    Public ExpenseCode As String

    ''' <summary>
    ''' Diretório da Despesa
    ''' </summary>
    ''' <remarks></remarks>
    Public ExpensePath As DirectoryInfo

    ''' <summary>
    ''' Diretório da Parcela
    ''' </summary>
    ''' <remarks></remarks>
    Public PlotPath As DirectoryInfo

    ''Nome da Despesa:
    Protected ExpenseName As String

    ''Valor da Parcela:
    Protected PlotTotalValue As Decimal

    ''Valor Pago:
    Protected PlotPaidValue As Decimal

    ''Data de Vencimento:
    Protected PlotMaturity As Date

    ''Cor de Status da Parcela:
    Protected PlotStatusColor As Color

    ''Status
    Protected PlotStatus As xpeg_count_project.Plot_CountSystem.StatusPlot

    Private Sub Expense_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''Diretório:
        ExpensePath = _EXPENSE.Path(ExpenseCode)

        'Vigiar Despesa:
        FileWatcher_Values.Path = ExpensePath.FullName

        'Dock no Topo:
        Me.Dock = DockStyle.Top

        ''Fazer Controle Ficar Com Bordas Arredondadas:
        '_FUNCTIONS.Interfaces.MakeRoundedEdges(BaseItemBackgroundPanel)
        _FUNCTIONS.Interfaces.MakeRoundedEdges(PlotValueLabel, 2)
        _FUNCTIONS.Interfaces.MakeRoundedEdges(PlotValuePaidLabel, 2)
        _FUNCTIONS.Interfaces.MakeRoundedEdges(PlotStatusColorPanel, 3)
        Me.Invalidate()
        Me.Refresh()


        'Importar Informações da Despesa e Da Parcela
        ImportInformations()
    End Sub

 

    Private Sub ImportInformations()
        ''Nome da Despsa:
        ExpenseName = _EXPENSE.Name(ExpenseCode)
        ExpenseNameLabel.Text = ExpenseName

        ''Valor da Parcela:
        PlotTotalValue = _EXPENSE.Plot.TotalValue(PlotPath)
        PlotValueLabel.Text = _StringToMoney(PlotTotalValue)

        ''Valor Pago:
        PlotPaidValue = _EXPENSE.Plot.PaidValue(PlotPath)
        If PlotPaidValue = 0 Then PlotValuePaidLabel.Hide() Else PlotValuePaidLabel.Show()
        PlotValuePaidLabel.Text = _StringToMoney(PlotPaidValue)


        ''Data de Vencimento:
        PlotMaturity = _EXPENSE.Plot.MaturityDate(PlotPath)
        MaturiryDayLabel.Text = _TwoNumber(PlotMaturity.Day)
        MaturiryDayLabel.Left = (PlotStatusColorPanel.Width - MaturiryDayLabel.Width) / 2

        ''Cor de Status:
        PlotStatusColor = _EXPENSE.Plot.StatusColor(PlotPath)
        PlotStatusColorPanel.BackColor = PlotStatusColor

        ''Status Escrito:
        PlotStatusLabel.Text = _EXPENSE.Plot.StatusString(PlotPath)

        ''Status da Parcela:
        PlotStatus = _EXPENSE.Plot.Status(PlotPath)
        If PlotStatus <> Plot_CountSystem.StatusPlot.Paid Then Me.SendToBack() 'Se a parcela não está paga, mover para o topo do calendário

    End Sub


    Private Sub FileWatcher_Values_Changed(sender As Object, e As FileSystemEventArgs) Handles FileWatcher_Values.Changed
        If e.ChangeType = WatcherChangeTypes.Changed Then
            If IO.Directory.Exists(ExpensePath.FullName) And IO.Directory.Exists(PlotPath.FullName) Then ImportInformations()
        End If
    End Sub

    Private Sub BaseItem_MouseClick(sender As Object, e As MouseEventArgs) Handles PlotValuesPanel.MouseClick, PlotValuePaidLabel.MouseClick, PlotValueLabel.MouseClick, PlotStatusLabel.MouseClick, PlotInformationsPanel.MouseClick, ExpenseNameLabel.MouseClick, Col03_Panel.MouseClick, Col02_Panel.MouseClick, Col01_Panel.MouseClick, BaseItemBackgroundPanel.MouseClick, MaturiryDayLabel.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Left Then _EXPENSE.OpenExpense(ExpenseCode)
        If e.Button = Windows.Forms.MouseButtons.Right Then _EXPENSE.Plot.Open(PlotPath, True)
    End Sub

    Private Sub BaseItem_MouseDown(sender As Object, e As MouseEventArgs) Handles PlotValuesPanel.MouseDown, PlotValuePaidLabel.MouseDown, PlotValueLabel.MouseDown, PlotStatusLabel.MouseDown, PlotInformationsPanel.MouseDown, ExpenseNameLabel.MouseDown, Col03_Panel.MouseDown, Col02_Panel.MouseDown, Col01_Panel.MouseDown, BaseItemBackgroundPanel.MouseDown, PlotStatusColorPanel.MouseDown, MaturiryDayLabel.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then BaseItemBackgroundPanel.BackColor = Color.FromArgb(220, 220, 220)
    End Sub

    Private Sub BaseItem_MouseEnter(sender As Object, e As EventArgs) Handles PlotValuesPanel.MouseEnter, PlotValuePaidLabel.MouseEnter, PlotValueLabel.MouseEnter, PlotStatusLabel.MouseEnter, PlotInformationsPanel.MouseEnter, ExpenseNameLabel.MouseEnter, Col03_Panel.MouseEnter, Col02_Panel.MouseEnter, Col01_Panel.MouseEnter, BaseItemBackgroundPanel.MouseEnter, PlotStatusColorPanel.MouseEnter, MaturiryDayLabel.MouseEnter
        Me.Invalidate()
        BaseItemBackgroundPanel.BackColor = Color.FromArgb(230, 230, 230)
    End Sub

    Private Sub BaseItem_MouseLeave(sender As Object, e As EventArgs) Handles PlotValuesPanel.MouseLeave, PlotValuePaidLabel.MouseLeave, PlotValueLabel.MouseLeave, PlotStatusLabel.MouseLeave, PlotInformationsPanel.MouseLeave, ExpenseNameLabel.MouseLeave, Col03_Panel.MouseLeave, Col02_Panel.MouseLeave, Col01_Panel.MouseLeave, BaseItemBackgroundPanel.MouseLeave, PlotStatusColorPanel.MouseLeave, MaturiryDayLabel.MouseLeave
        BaseItemBackgroundPanel.BackColor = Color.White
    End Sub

End Class
