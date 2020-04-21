Imports System.IO
Module LVFrame


    ''' <summary>
    ''' Fornece métodos para Gerenciamento de arquivos.
    ''' Para mais informações, consulte a documentação do LVFrame disponível no GitHub.
    ''' </summary>
    Public _File123 As _File


    Public _Interface
    Public _Images
    Public _Layout
    Public _Property

    Public _NetWork
    Public _LVFrame


    ''' <summary>
    ''' Nova Linha
    ''' </summary>
    Public Const LV_NewLine As String = vbNewLine

    ''' <summary>
    ''' True
    ''' </summary>
    Public Const LV_True As Boolean = True

    ''' <summary>
    ''' False
    ''' </summary>
    Public Const LV_False As Boolean = False


End Module

''' <summary>
''' Forneme métodos para Gerenciamento de Arquivos
''' </summary>
Public Class _File

    ''' <summary>
    ''' Criar um Novo Arquivo em Branco no Sistema.
    ''' </summary>
    Public Shared Sub NewFile(ByVal pathFile As String)

    End Sub

    ''' <summary>
    ''' Copiar um Arquivo de um Diretório para Outro.
    ''' </summary>
    Public Shared Sub Copy(ByVal pathFile As String, ByVal pathToCopy As String)

    End Sub

    ''' <summary>
    ''' Mover um Arquivo de um Diretório para Outro.
    ''' </summary>
    Public Shared Sub Move(ByVal pathFile As String, ByVal newPathFile As String)

    End Sub

    ''' <summary>
    ''' Renomear um Arquivo.
    ''' </summary>
    Public Shared Sub Rename(ByVal pathFile As String, ByVal newName As String)

    End Sub

    ''' <summary>
    ''' Excluir um arquivo.
    ''' </summary>
    Public Shared Sub Delete(ByVal pathFile As String)

    End Sub



End Class


Public Class _Layout

    ''' <summary>
    ''' Enviar um Objeto para Frente
    ''' </summary>
    Public Shared Sub Front(ByVal obj As Control)
        obj.BringToFront()
    End Sub

    ''' <summary>
    ''' Enviar um Objeto para Trás
    ''' </summary>
    Public Shared Sub Back(ByVal obj As Control)
        obj.SendToBack()
    End Sub
End Class
