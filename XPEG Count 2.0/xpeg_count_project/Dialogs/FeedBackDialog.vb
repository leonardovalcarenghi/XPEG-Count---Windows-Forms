Imports System.Windows.Forms
Imports System.Net.Mail

Public Class FeedBackDialog


    Private Sub SubjectComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SubjectComboBox.SelectedIndexChanged
        Select Case SubjectComboBox.SelectedIndex
            Case 0 'Bugs
                ShowSubjectComplement()

            Case 1 'Melhorias
                ShowSubjectComplement()

            Case 2 'Reclamações
                ShowSubjectComplement()

            Case 3 'Sugestões
                HideSubjectComplemen()
            Case 4 'Outros
                HideSubjectComplemen()
        End Select
    End Sub

    Sub ShowSubjectComplement()
        Label_Complemento.Show() : ComplementSubjectComboBox.Show()
    End Sub
    Sub HideSubjectComplemen()
        Label_Complemento.Hide() : ComplementSubjectComboBox.Hide()
    End Sub

    Private Sub Button_OK_Click(sender As Object, e As EventArgs) Handles Button_OK.Click

        CheckFields()
    End Sub

    Private Sub Button_Cancel_Click(sender As Object, e As EventArgs) Handles Button_Cancel.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub CheckFields()
        If SubjectComboBox.SelectedIndex = Nothing Then
            MsgBox("Selecione um 'Assunto' para o FeedBack.", MsgBoxStyle.Critical, "XPEG Count")
            SubjectComboBox.Select() : SubjectComboBox.Focus()
        Else
            If FullNameTextBox.Text = Nothing Then
                MsgBox("Informe seu nome completo.", MsgBoxStyle.Critical, "XPEG Count")
                FullNameTextBox.Select() : FullNameTextBox.Focus()
            Else
                If EmailTextBox.Text = Nothing Then
                    MsgBox("Informe seu e-maisl para podermos entrar em contato com você.", MsgBoxStyle.Critical, "XPEG Count")
                    EmailTextBox.Select() : EmailTextBox.Focus()
                Else
                    If MessageTextBox.Text = Nothing Then
                        MsgBox("Digite sua mensagem.", MsgBoxStyle.Critical, "XPEG Count")
                        MessageTextBox.Select() : MessageTextBox.Focus()
                    Else
                        Button_OK.Text = "Enviando..." : Button_OK.Enabled = False
                        SendEmail()
                    End If
                End If
            End If
        End If
    End Sub

    Dim XperCountEmail As String = "xpeg.count@gmail.com"
    Dim XperCountPassword As String = "XPEG.COUNT.23"
    Dim DeveloperEmail As String = "leonardo.valcarenghi@gmail.com"

    Private Sub SendEmail()

        Dim FeedBackMessage As String =
            "Assunto: " & SubjectComboBox.SelectedItem.ToString & _
            vbNewLine & _
            "Complemento: " & ComplementSubjectComboBox.Text.ToString & _
             vbNewLine & _
            "Nome do Usuário: " & FullNameTextBox.Text & _
             vbNewLine & _
             "E-mail: " & EmailTextBox.Text & _
              vbNewLine & _
              vbNewLine & _
              vbNewLine & _
              "MENSAGEM" & _
              vbNewLine & _
              MessageTextBox.Text



        Try
            Dim mail As MailMessage = New MailMessage()
            Dim SmtpServer As SmtpClient = New SmtpClient("smtp.gmail.com")
            mail.From = New MailAddress(XperCountEmail)
            mail.[To].Add(DeveloperEmail)
            mail.Subject = "FeedBack do XPEG Count - " & SubjectComboBox.SelectedItem.ToString
            mail.Body = FeedBackMessage
            SmtpServer.Port = 587
            SmtpServer.Credentials = New System.Net.NetworkCredential(XperCountEmail, XperCountPassword)
            SmtpServer.EnableSsl = True
            SmtpServer.Send(mail)

            MsgBox("Sua Mensagem foi enviada com sucesso!" & vbNewLine & "Em breve, entraremos em contato com você.", MsgBoxStyle.Information, "XPEG Count")
            Me.Close()

        Catch ex As Exception
            Button_OK.Enabled = True : Button_OK.Text = "Enviar"
            MsgBox("Error" & vbNewLine & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub


    Private Sub FeedBackDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FullNameTextBox.Text = Environment.UserName
    End Sub
End Class
