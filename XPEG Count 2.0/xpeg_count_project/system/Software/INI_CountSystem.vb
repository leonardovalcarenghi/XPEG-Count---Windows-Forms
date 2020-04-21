Imports System.Text

Public Class INI_CountSystem

    Private Declare Auto Function GetPrivateProfileString Lib "Kernel32" (ByVal lpAppName As String, ByVal lpKeyName As String, ByVal lpDefault As String, ByVal lpReturnedString As StringBuilder, ByVal nSize As Integer, ByVal lpFileName As String) As Integer
    Private Declare Auto Function WritePrivateProfileString Lib "Kernel32" (ByVal lpAppName As String, ByVal lpKeyName As String, ByVal lpString As String, ByVal lpFileName As String) As Integer

    ''' <summary>
    '''  Ler Arquivo INI
    ''' </summary>
    ''' <param name="_file">Nome do arquivo para salvar</param>
    ''' <param name="_key">Chave</param>
    ''' <param name="_section">Seção</param>
    ''' <param name="_value">Valor a ser escrito</param>
    ''' <remarks></remarks>
    Public Sub WriteIniFile(ByVal _file As String, ByVal _section As String, ByVal _key As String, ByVal _value As String)
        WritePrivateProfileString(_section, _key, _value, _file)
    End Sub

    ''' <summary>
    ''' Salvar/Escrever Arquivo INI
    ''' </summary>
    ''' <param name="_file">Nome do arquivo para salvar</param>
    ''' <param name="_key">Chave</param>
    ''' <param name="_section">Seção</param>
    ''' <param name="_default_value">Valor de backup, caso não seja carregado nada</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function ReadIniFile(ByVal _file As String, ByVal _section As String, ByVal _key As String, Optional ByVal _default_value As Object = Nothing) As String
        Const MAX_LENGTH As Integer = 500
        Dim string_builder As New StringBuilder(MAX_LENGTH)

        GetPrivateProfileString(_section, _key, _default_value, string_builder, MAX_LENGTH, _file)
        '   GetPrivateProfileString(section_name, key_name, default_value, string_builder, MAX_LENGTH, file_name)

        Return string_builder.ToString()
    End Function

End Class
