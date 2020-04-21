Public Class CreditCardItemList

    Public Property SelectForm As SelectCreditCardDialog

    Private Sub ExpenseCategoryListItemControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Dock = DockStyle.Top
        Me.BackColor = Color.Transparent

        _FUNCTIONS.Interfaces.MakeRoundedEdges(PanelColor, 2)

        LoadInformations()


    End Sub


    ''Código do Cartão:
    Public CreditCard_Code As String

    ''Nome do Cartão:
    Protected CreditCard_Name As String

    ''Icone do Cartão:
    Protected CreditCard_Icon As Image

    Private Sub LoadInformations()
        ''Nome do Cartão:
        CreditCard_Name = _CREDITCARDS.GetName(CreditCard_Code)
        CardTitle_Label.Text = CreditCard_Name

        ''Icone do Cartão:
        CreditCard_Icon = Nothing
        CardIcon_PictureBox.Image = CreditCard_Icon
    End Sub





    Private Sub CategoryPanel_MouseClick(sender As Object, e As MouseEventArgs) Handles CardTitle_Label.MouseClick, CategoryPanel.MouseClick, CardIcon_PictureBox.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Left Then
            SelectForm.SelectedCreditCard = CreditCard_Code
            SelectForm.DialogResult = DialogResult.OK : SelectForm.Close()
        End If
    End Sub

    Private Sub CategoryPanel_MouseDown(sender As Object, e As MouseEventArgs) Handles CardTitle_Label.MouseDown, CategoryPanel.MouseDown, CardIcon_PictureBox.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then CategoryPanel.BackColor = Color.FromArgb(225, 225, 225)
    End Sub

    Private Sub CategoryPanel_MouseEnter(sender As Object, e As EventArgs) Handles CardTitle_Label.MouseEnter, CategoryPanel.MouseEnter, CardIcon_PictureBox.MouseEnter
        CategoryPanel.BackColor = Color.FromArgb(230, 230, 230)
    End Sub

    Private Sub CategoryPanel_MouseLeave(sender As Object, e As EventArgs) Handles CardTitle_Label.MouseLeave, CategoryPanel.MouseLeave, CardIcon_PictureBox.MouseLeave
        CategoryPanel.BackColor = Color.Transparent
    End Sub
End Class
