Imports System.Windows.Forms
Imports System.IO

Public Class AboutSoftwareDialog


#Region "Microsoft Store Block"
    Private Sub MicrosoftStore_Panel_MouseClick(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            Process.Start("ms-windows-store://pdp/?productid=9N6ZPXNXZDGF")
        End If
    End Sub

    Private Sub MicrosoftStore_Panel_MouseEnter(sender As Object, e As EventArgs)
        'MicrosoftStore_Panel.BackColor = Color.WhiteSmoke
    End Sub

    Private Sub MicrosoftStore_Panel_MouseLeave(sender As Object, e As EventArgs)
        ' MicrosoftStore_Panel.BackColor = Color.Transparent
    End Sub


#End Region


    Private Sub Dialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''Adaptar Inferface:
        _FUNCTIONS.Interfaces.MakeRoundedEdges(CountSite_Panel, 2)
        _FUNCTIONS.Interfaces.MakeRoundedEdges(CountInstagram_Panel, 2)

        ''Ajustar Icones de 'Ano de Desenvolvimento':
        PictureBox5.Image = _FUNCTIONS.Images.ChangeImageResolution(PictureBox5.Image, 34)

        ''Versão dop Software:
        Label_SoftwareVersion.Text = My.Settings.SOFTWARE_Version

        ''Logs:
        ImportLogs()

        ''Idioma:
        ApplyLanguage()
    End Sub

    Private Sub Button_Close_Click(sender As Object, e As EventArgs) Handles Button_Close.Click
        Me.DialogResult = DialogResult.OK : Me.Close()
    End Sub

    Private Sub Icons8_LinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Process.Start("https://icons8.com.br")
    End Sub

    Sub ImportLogs()
        ''Obter Logs:
        Dim ListOfLogs = _SOFTWARE.GetLogs()

        ''Limpar Lista:
        FlowLayoutPanel_Logs.Controls.Clear()

        ''Adicionar na Lista:
        For Each LOG As FileInfo In ListOfLogs
            Dim Item As LogItemList = New LogItemList With {.LOG_File = LOG}
            FlowLayoutPanel_Logs.Controls.Add(Item)
        Next
    End Sub

#Region "PACOTE DE IDIOMAS"

    ''' <summary>
    ''' Aplicar Idioma no Form
    ''' </summary>
    Private Sub ApplyLanguage()
        ''LABELS''
        'Label_Versão.Text = _LANGUAGE.SCREENS.S_SoftwareAbout.Label01_Versão
        'Label_Desenvolvedor.Text = _LANGUAGE.SCREENS.S_SoftwareAbout.Label02_Desenvolvedor
        'Label_AnoDeDesenvolvimento.Text = _LANGUAGE.SCREENS.S_SoftwareAbout.Label03A_AnoDeDesenvolvimento
        'Year_Label.Text = _LANGUAGE.SCREENS.S_SoftwareAbout.Label03B_DesenvolvidoEm
        'Label_Icones.Text = _LANGUAGE.SCREENS.S_SoftwareAbout.Label04A_Icones
        'Label_IconesFonte.Text = _LANGUAGE.SCREENS.S_SoftwareAbout.Label04B_FonteDosIcones
        'Label_DireitosAutorais.Text = _LANGUAGE.SCREENS.S_SoftwareAbout.Label05_DireitosAutorais

        ' ''BANNER''
        'Label_Avalie.Text = _LANGUAGE.SCREENS.S_SoftwareAbout.BANNER_Label01
        'Label_ConteNos.Text = _LANGUAGE.SCREENS.S_SoftwareAbout.BANNER_Label02

        ' ''INSTAGRAM''
        'Label_Insta01.Text = _LANGUAGE.SCREENS.S_SoftwareAbout.INSTA_Label01
        'Label_Insta02.Text = _LANGUAGE.SCREENS.S_SoftwareAbout.INSTA_Label02

        ' ''BOTTONS''
        'Button_Close.Text = _LANGUAGE.SCREENS.S_SoftwareAbout.Button01_Fechar
    End Sub

    Private Sub InstaTagName_Developer_Click(sender As Object, e As EventArgs)
        '  InstaTagName_App.Show()
    End Sub

    Private Sub InstaTagName_App_Click(sender As Object, e As EventArgs)
        'InstaTagName_App.Hide()
    End Sub


#End Region

End Class
