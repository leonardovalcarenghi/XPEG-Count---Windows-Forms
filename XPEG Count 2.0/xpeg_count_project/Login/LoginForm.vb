Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports System.Net.Mail

Public Class LoginForm

    ' TODO: Inserir código para realizar autenticação personalizada utilizando o nome de usuário e senha fornecidos 
    ' (Veja http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' A entidade de segurança personalizada pode ser anexada à entidade de segurança da thread atual da seguinte forma: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' onde CustomPrincipal é a implementação de IPrincipal usada para realizar a autenticação. 
    ' Subsequentemente, My.User irá retornar informações de identificação encapsuladas num objeto CustomPrincipal
    ' como nome de usuário, nome para exibição etc.


    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Login_Panel.Dock = DockStyle.Fill
        _DIRECTORIES.CreateDirectories()
        ' UserName_TextBox.Text = My.User.Name.ToString.Replace(My.Computer.Name & "\", "")

   
    End Sub

    Private Sub OK_Click()
        'If UserName_TextBox.Text = Nothing Then
        '    MessageBox.Show("Digite o seu nome de usuário.", "XPEG Count", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '    UserName_TextBox.Select() : UserName_TextBox.Focus()
        'Else
        '    If UserName_TextBox.Text <> My.User.Name.ToString.Replace(My.Computer.Name & "\", "") Then
        '        MessageBox.Show("Nome de usuário inválido.", "XPEG Count", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '        UserName_TextBox.Select() : UserName_TextBox.Focus()
        '    Else
        '        If My.Settings.User_Password <> Nothing And GooglePassword_TextBox.Text = Nothing Then
        '            MessageBox.Show("Digite sua senha de acesso para continuar.", "XPEG Count", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '            GooglePassword_TextBox.Select() : GooglePassword_TextBox.Focus()
        '        Else
        '            If My.Settings.User_Password = Nothing And GooglePassword_TextBox.Text = Nothing Then
        '                'entrar
        '                LoginOK()
        '            Else
        '                If My.Settings.User_Password = Nothing And GooglePassword_TextBox.Text <> Nothing Then
        '                    MessageBox.Show("A senha digitada não está correta." & vbNewLine & "Por favor, tente novamente.", "XPEG Count", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '                    GooglePassword_TextBox.Text = Nothing : GooglePassword_TextBox.Select() : GooglePassword_TextBox.Focus()
        '                Else
        '                    If GooglePassword_TextBox.Text <> My.Settings.User_Password Then
        '                        MessageBox.Show("A senha digitada não está correta." & vbNewLine & "Por favor, tente novamente.", "XPEG Count", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '                        GooglePassword_TextBox.Text = Nothing : GooglePassword_TextBox.Select() : GooglePassword_TextBox.Focus()
        '                    Else
        '                        If GooglePassword_TextBox.Text = My.Settings.User_Password Then
        '                            LoginOK()

        '                        End If
        '                    End If
        '                End If
        '            End If
        '        End If
        '    End If
        'End If
    End Sub

    Private Sub LoginOK()
        Me.Hide()
        XpegCountForm.Show()
        Me.DialogResult = Windows.Forms.DialogResult.OK

    End Sub

    Private Sub UserName_TextBox_KeyDown(sender As Object, e As KeyEventArgs)
        Select Case e.KeyCode
            Case Keys.Escape
                e.SuppressKeyPress = True
                Me.DialogResult = Windows.Forms.DialogResult.Cancel
                Me.Close()

            Case Keys.Enter
                e.SuppressKeyPress = True
                'GooglePassword_TextBox.Select() : GooglePassword_TextBox.Focus()
        End Select
    End Sub

    Private Sub Password_TextBox_KeyDown(sender As Object, e As KeyEventArgs)
        Select Case e.KeyCode
            Case Keys.Escape
                e.SuppressKeyPress = True
                Me.DialogResult = Windows.Forms.DialogResult.Cancel
                Me.Close()


            Case Keys.Enter
                e.SuppressKeyPress = True
                OK_Click()
        End Select
    End Sub

    Private Sub LoginForm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        If _SOFTWARE.CheckCulture() = False Then

            Dim instructions = "Painel de Controle > Relógio e Região > Região." & vbNewLine & "Na opção de ""Formato"" escolha a opção: ""Português (Brasil)"""

            MessageBox.Show("Desculpe, mas as configurações de cultura/região selecionadas no Windows não são compátiveis com esta versão do XPEG Count." & vbNewLine &
                          "Favor alterar as configurações antes de iniciar o XPEG Count novamente." & vbNewLine & vbNewLine &
                          "Formato Aceito: dd/MM/yyyy - Português (Brasil)" & vbNewLine & vbNewLine & "COMO ALTERAR AS CONFIGURAÇÕES DE REGIÃO DO WINDOWS?" & vbNewLine & instructions, "XPEG Count - Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End 'Encerrar Aplicação
        Else
            LoginOK()
        End If

        'If My.Settings.User_Password = Nothing Then
        'LoginOK()
        ' End If
    End Sub

    Private Sub LinkLabel_ForgetMyPassword_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)

    End Sub

    Private Sub LinkLabel_Back_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub










End Class
