Imports System.IO
Public Class CreditCard_CountSystem

    ''' <summary>
    ''' Obter/Atribuir Nome do Cartão de Crédito
    ''' </summary>
    Public Property Name(ByVal creditCard_code As String) As String
        Get
            Dim CardFile As FileInfo = New FileInfo("")

        End Get
        Set(value As String)

        End Set

    End Property

    ''' <summary>
    ''' Obter/Atribuir a Descrição do Cartão de Crédito
    ''' </summary>
    Public Property Description(ByVal creditCard_code As String) As String
        Get

        End Get
        Set(value As String)

        End Set
    End Property

    ''' <summary>
    ''' Obter/Atribuir o Icone do Cartão de Crédito
    ''' </summary>
    Public Property Icon(ByVal creditCard_code As String) As Image
        Get

        End Get
        Set(value As Image)

        End Set
    End Property

    ''' <summary>
    ''' Obter/Atribuir a Cor de Destaque do Cartão de Crédito
    ''' </summary>
    Public Property HightColor(ByVal creditCard_code As String) As Image
        Get

        End Get
        Set(value As Image)

        End Set
    End Property
End Class
