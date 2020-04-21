Imports System.Windows.Forms

Public Class SelectCreditCardDialog

    ''' <summary>
    ''' Código do Cartão de Crédito Selecionado
    ''' </summary>
    ''' <returns></returns>
    Public Property SelectedCreditCard As String

    Private Sub SelectCreditCardDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Sub ImportCardCredits()
        ''Obter Lista de Cartões:
        Dim CardsList = _CREDITCARDS.GetCards()
        ''Adicionar na Lista:
        For Each CARD As String In CardsList
            Dim Item As CreditCardItemList = New CreditCardItemList
            Item.SelectForm = Me
            Item.CreditCard_Code = CARD
            ListCards_Panel.Controls.Add(Item)
        Next
        If CardsList.Count = 0 Then ListCards_Panel.Controls.Add(Label_NoResults)
    End Sub
End Class
