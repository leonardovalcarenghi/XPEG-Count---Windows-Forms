Module CountModuleFunctions


    ''' <summary>
    ''' Função de Par ou Impar | TRUE = PAR / FALSE = ÍMPAR
    ''' </summary>
    ''' <param name="number"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function _EvenOrOdd(ByVal number As Integer) As Boolean
        If number Mod 2 = 0 Then Return True Else Return False
    End Function


    ''' <summary>
    ''' Função de Converter Valor em String Formatada de Moeda (R$ 9.999,88)
    ''' </summary>
    ''' <param name="value"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function _StringToMoney(ByVal value As Decimal, Optional ByVal dollarSign As Boolean = True) As String
        Dim V As String = String.Format("{0:c}", Double.Parse(value))
        If dollarSign = False Then V = V.Replace("R$ ", "")
        Return V
    End Function


    ''' <summary>
    ''' Função de Escrever a Data por Extenso
    ''' </summary>
    ''' <param name="date_"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function _DateByExtenso(ByVal date_ As Date) As String
        Return date_.Day & " de " & _FUNCTIONS.GetMonthName(date_.Month) & " de " & date_.Year
    End Function

    ''' <summary>
    ''' Função de Retornar os números de 1 a 9 com um zero na frente.
    ''' </summary>
    ''' <param name="number"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function _TwoNumber(ByVal number As Integer) As String
        Dim N As String
        If number <= 9 Then N = "0" & number Else N = number
        Return N
    End Function

End Module
