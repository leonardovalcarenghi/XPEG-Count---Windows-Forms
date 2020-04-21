Imports System.IO

Public Class HistoricPayment_CountSystem


    ''' <summary>
    ''' Obter/Editar Valor do Histórico
    ''' </summary>
    Public Property Value(ByVal historicFile As FileInfo) As Decimal
        Get
            If IO.File.Exists(historicFile.FullName) Then
                Dim HistoricValue = _INI.ReadIniFile(historicFile.FullName, "HISTORIC", "value", 0)
                Return HistoricValue
            Else
                Return 0
            End If
        End Get
        Set(value As Decimal)
            If IO.File.Exists(historicFile.FullName) Then
                _INI.WriteIniFile(historicFile.FullName, "HISTORIC", "value", value)
            End If
        End Set
    End Property

    ''' <summary>
    ''' Obter Data de Pagamento
    ''' </summary>
    Public Function PayDate(ByVal historicFile As FileInfo) As Date
        If historicFile.Exists() Then
            Dim HistoricDate = _INI.ReadIniFile(historicFile.FullName, "HISTORIC", "date", "01/01/2019")
            Return HistoricDate
        Else
            Return "01/01/2019"
        End If
    End Function

    ''' <summary>
    ''' Obter Tipo de Pagamento
    ''' </summary>
    Public Function Type(ByVal historicFile As FileInfo) As typeHistoric
        If IO.File.Exists(historicFile.FullName) Then Dim HistoricType = _INI.ReadIniFile(historicFile.FullName, "PAYMENT", "type", 0) : Return HistoricType _
        Else Return 0
    End Function


   
    ''' <summary>
    ''' Obter Comentários do Histórico
    ''' </summary>
    Public Function Comments(ByVal historicFile As FileInfo) As String
        If historicFile.Exists() Then
            Dim HistoricComments = _INI.ReadIniFile(historicFile.FullName, "HISTORIC", "comments", "")
            Return HistoricComments
        Else
            Return ""
        End If
    End Function

    ''' <summary>
    ''' Remover Histórico de Pagamento
    ''' </summary>
    Public Function Delete(ByVal historicFile As FileInfo) As Boolean
        Try
            IO.File.Delete(historicFile.FullName)
            Return True
        Catch ex As Exception
            Return False

        End Try
    End Function

    ''' <summary>
    ''' Obter/Definir se Histórico de Pagamento possue Taxas.
    ''' </summary>
    Public Property Interst(ByVal historicFile As FileInfo) As Boolean
        Get
            If IO.File.Exists(historicFile.FullName) Then Dim HistoricInterest = _INI.ReadIniFile(historicFile.FullName, "PAYMENT", "interest", False) : Return HistoricInterest _
            Else Return False
        End Get
        Set(value As Boolean)
            If IO.File.Exists(historicFile.FullName) Then _INI.WriteIniFile(historicFile.FullName, "PAYMENT", "interest", value)
        End Set
    End Property

    ''' <summary>
    ''' Obter/Definir Valor de Juros do Pagamento [DEFINIR NÃO DISPONÍVEL].
    ''' </summary>
    Public Property Tax(ByVal historicFile As FileInfo) As Decimal
        Get
            If IO.File.Exists(historicFile.FullName) Then
                If Interst(historicFile) = True Then
                    Dim HistoricTax = _INI.ReadIniFile(historicFile.FullName, "PAYMENT", "tax", False)
                    Return HistoricTax
                Else
                    Return 0
                End If
            Else
                Return 0
            End If
        End Get
        Set(value As Decimal)

        End Set
    End Property

    ''' <summary>
    ''' Obter/Definir se Histórico de Pagamento possue Descontos.
    ''' </summary>
    Public Property Discount(ByVal historicFile As FileInfo) As Boolean
        Get
            If IO.File.Exists(historicFile.FullName) Then Dim HistoricDiscount = _INI.ReadIniFile(historicFile.FullName, "PAYMENT", "discount", False) : Return HistoricDiscount _
            Else Return False
        End Get
        Set(value As Boolean)
            If IO.File.Exists(historicFile.FullName) Then _INI.WriteIniFile(historicFile.FullName, "PAYMENT", "discount", value)
        End Set
    End Property



    Enum typeHistoric : errortype : totalType : partialType : restType : End Enum




End Class


