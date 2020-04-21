Module CountModuleCenter


    ''' <summary>
    ''' Acessar Funções e Caminhos de Diretórios da Aplicação
    ''' </summary>
    ''' <remarks></remarks>
    Public _DIRECTORIES As New ClassDirectories

    ''' <summary>
    ''' Acessar Funções de Arquivo de Sistema (*.ini)
    ''' </summary>
    ''' <remarks></remarks>
    Public _INI As New INI_CountSystem

    ''' <summary>
    ''' Obter Informações Gerais da Despesa
    ''' </summary>
    Public _EXPENSE As New Expense_CountSystem

    ''' <summary>
    ''' Despesas Cadastradas
    ''' </summary>
    ''' <remarks></remarks>
    Public _EXPENSES As New Expenses_CountSystem

    ''' <summary>
    ''' Cartões de Crédito
    ''' </summary>
    Public _CREDITCARDS As New CreditCards_CountSystem

    ''' <summary>
    ''' Obter Informações de um Cartão de Crédito
    ''' </summary>
    ''' <remarks></remarks>
    Public _CREDIT_CARD As New CreditCard_CountSystem

    ''' <summary>
    ''' Acessar Valores da DashBoard
    ''' </summary>
    ''' <remarks></remarks>
    Public _DASHBOARD As New Dashboard_CountSystem

    ''' <summary>
    ''' Funções e Recursos Gerais do Software
    ''' </summary>
    ''' <remarks></remarks>
    Public _SOFTWARE As New Software_CountSystem

    ''' <summary>
    ''' Acessar Configurações do XPEG Count
    ''' </summary>
    ''' <remarks></remarks>
    Public _SETTINGS As New Settings_CountSystem

End Module
