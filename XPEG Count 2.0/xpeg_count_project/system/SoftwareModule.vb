Imports System.Text
Imports System.IO
Imports System.Security.Cryptography
Imports System.Drawing.Drawing2D

Module SoftwareModule

  

   



    Public _PROPERTY_CATEGORYS_IMAGE_SIZE As New Size(24, 24)

    Public _PROPERTY_MENU_ICONS_SIZE As New Size(24, 24)

    Public _PROPERTY_DASHBOARD_ANIMATION_SPEED As Integer = 30






    ' Public _INI As New ClassINI
    '  Public _DIRECTORIES As New ClassDirectories
    Public _FUNCTIONS As New ClassFunctions
    Public _CATEGORYS As New Class_Categorys
    'Public _DASHBOARD As New SystemClass_Dashboard
    'Public _CREDITCARDS As New SystemClass_CreditCard
    'Public _SETTINGS As New SystemClass_Settings


    Public CountLog As New CountLogClass


    'Public Function _RequestUserPassword() As Boolean
    '    Dim RequestPass As New RequestUserPasswordDialog
    '    RequestPass = New RequestUserPasswordDialog
    '    If RequestPass.ShowDialog = DialogResult.OK Then
    '        Return True
    '    Else
    '        Return False
    '    End If
    'End Function


    'EMULAR FUNÇÃO
    Function _FormatNumberStringToMoney(ByVal value As Decimal) As String
        Return _StringToMoney(value)
    End Function
End Module


Public Class ClassINI
 
End Class

Public Class ClassDirectories

    Private SoftwarePath As DirectoryInfo = New DirectoryInfo(My.Application.Info.DirectoryPath)

    Public PrimaryPath As String = My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\XPEG Count\"

    Public ExpensesPath As String = PrimaryPath & "expenses\"
    Public SettingsPath As String = PrimaryPath & "settings\"
    Public CategorysPath As String = PrimaryPath & "categorys\"
    Public IconsPath As String = PrimaryPath & "icons\"
    Public LanguagesPath As String = PrimaryPath & "languages\"

    ''' <summary>
    ''' Diretório dos Arquivos de 'Ajuda'
    ''' </summary>
    Public HelpPath As DirectoryInfo = New DirectoryInfo(SoftwarePath.FullName + "\help\pt-br\")


    Public Sub CreateDirectories()
        'Despesas
        If Not IO.Directory.Exists(ExpensesPath) Then IO.Directory.CreateDirectory(ExpensesPath)

        'Configurações
        If Not IO.Directory.Exists(SettingsPath) Then IO.Directory.CreateDirectory(SettingsPath)

        'Categorias
        If Not IO.Directory.Exists(CategorysPath) Then IO.Directory.CreateDirectory(CategorysPath)

        'Icones
        If Not IO.Directory.Exists(IconsPath) Then IO.Directory.CreateDirectory(IconsPath)

        'Idiomas
        If Not IO.Directory.Exists(LanguagesPath) Then IO.Directory.CreateDirectory(LanguagesPath)
        ' TransferIconsPath()
    End Sub

    Public Sub TransferIconsPath()
        Dim IconPathSystem = My.Application.Info.DirectoryPath & "\icons\"

        Dim CategorysIcons As DirectoryInfo = New DirectoryInfo(IconPathSystem)
        Dim FoldersPath() As DirectoryInfo = CategorysIcons.GetDirectories
        For Each a As DirectoryInfo In FoldersPath
            If Not IO.Directory.Exists(IconsPath & a.Name) Then
                Try
                    My.Computer.FileSystem.CopyDirectory(a.FullName, IconsPath & a.Name)
                Catch ex As Exception
                End Try
            End If
        Next
    End Sub
End Class


Public Class ClassFunctions

    ''' <summary>
    ''' Funções de manupilação da imagem
    ''' </summary>
    ''' <remarks></remarks>
    Public Images As New ClassFunctions_Image

    ''' <summary>
    ''' Funções das Interfaces
    ''' </summary>
    ''' <remarks></remarks>
    Public Interfaces As New ClassFunctions_Interface

    ''' <summary>
    ''' Funções de Códigos
    ''' </summary>
    ''' <remarks></remarks>
    Public Codes As New ClassFunctions_Codes


    Public Sub ReplaceChars(ByVal TxtBox As TextBox)
        TxtBox.Text = TxtBox.Text.Replace(".", ".")

        TxtBox.Text = TxtBox.Text.Replace("/", "")
        TxtBox.Text = TxtBox.Text.Replace("*", "")
        TxtBox.Text = TxtBox.Text.Replace("-", "")
        TxtBox.Text = TxtBox.Text.Replace("+", "")
        TxtBox.Text = TxtBox.Text.Replace("""", "")
        TxtBox.Text = TxtBox.Text.Replace("'", "")
        TxtBox.Text = TxtBox.Text.Replace("_", "")
        TxtBox.Text = TxtBox.Text.Replace("!", "")
        TxtBox.Text = TxtBox.Text.Replace("@", "")
        TxtBox.Text = TxtBox.Text.Replace("#", "")
        TxtBox.Text = TxtBox.Text.Replace("$", "")
        TxtBox.Text = TxtBox.Text.Replace("%", "")
        TxtBox.Text = TxtBox.Text.Replace("¨", "")
        TxtBox.Text = TxtBox.Text.Replace("&", "")
        TxtBox.Text = TxtBox.Text.Replace("*", "")
        TxtBox.Text = TxtBox.Text.Replace("(", "")
        TxtBox.Text = TxtBox.Text.Replace(")", "")
        TxtBox.Text = TxtBox.Text.Replace("=", "")

        TxtBox.Text = TxtBox.Text.Replace("\", "")
        TxtBox.Text = TxtBox.Text.Replace("|", "")
        TxtBox.Text = TxtBox.Text.Replace("<", "")
        TxtBox.Text = TxtBox.Text.Replace(">", "")
        TxtBox.Text = TxtBox.Text.Replace(":", "")
        TxtBox.Text = TxtBox.Text.Replace(";", "")
        TxtBox.Text = TxtBox.Text.Replace("^", "")
        TxtBox.Text = TxtBox.Text.Replace("~", "")
        TxtBox.Text = TxtBox.Text.Replace("]", "")
        TxtBox.Text = TxtBox.Text.Replace("}", "")
        TxtBox.Text = TxtBox.Text.Replace("º", "")
        TxtBox.Text = TxtBox.Text.Replace("ª", "")
        TxtBox.Text = TxtBox.Text.Replace("{", "")
        TxtBox.Text = TxtBox.Text.Replace("[", "")
        TxtBox.Text = TxtBox.Text.Replace("´", "")
        TxtBox.Text = TxtBox.Text.Replace("`", "")
        TxtBox.Text = TxtBox.Text.Replace("§", "")
    End Sub


    ''' <summary>
    ''' Obter valor total de todas as despesas lançadas.
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function GetValueTotalFromAllExpenses() As Decimal
        Dim TOTAL As Decimal = 0
        Dim LIST_Expenses As New List(Of String)

        Dim DirDiretorio As DirectoryInfo = New DirectoryInfo(_DIRECTORIES.ExpensesPath)
        Dim oFileInfoCollection() As DirectoryInfo
        Dim oFileInfo As DirectoryInfo
        Dim i As Integer

        '### Preenche o FileCollection com um Array de objetos FileInfo
        oFileInfoCollection = DirDiretorio.GetDirectories()

        '### Podemos utilizar os objetos da coleção oFileCollection para preencher um ListBox por exemplo
        For i = 0 To oFileInfoCollection.Length() - 1
            oFileInfo = oFileInfoCollection.GetValue(i)
            LIST_Expenses.Add(oFileInfo.FullName)
        Next

        For Each a As String In LIST_Expenses
            Try
                Dim DirDiretorio2 As DirectoryInfo = New DirectoryInfo(a & "\plots\")
                Dim oFileInfoCollection2() As FileInfo : oFileInfoCollection2 = DirDiretorio2.GetFiles("*.ini")
                For i = 0 To oFileInfoCollection2.Length() - 1

                    Dim ff As String = oFileInfoCollection2(i).FullName
                    TOTAL = TOTAL + _INI.ReadIniFile(ff, "VALUE", "price")
                Next
            Catch ex As Exception
            End Try
        Next

        Return TOTAL
    End Function

    ''' <summary>
    ''' obter valor ja pago de todas as depesas.
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function GetValueFromExpensesPaid() As Decimal
        Dim TOTAL As Decimal = 0
        Dim LIST_Expenses As New List(Of String)

        Dim DirDiretorio As DirectoryInfo = New DirectoryInfo(_DIRECTORIES.ExpensesPath)
        Dim oFileInfoCollection() As DirectoryInfo
        Dim oFileInfo As DirectoryInfo
        Dim i As Integer

        '### Preenche o FileCollection com um Array de objetos FileInfo
        oFileInfoCollection = DirDiretorio.GetDirectories()

        '### Podemos utilizar os objetos da coleção oFileCollection para preencher um ListBox por exemplo
        For i = 0 To oFileInfoCollection.Length() - 1
            oFileInfo = oFileInfoCollection.GetValue(i)
            LIST_Expenses.Add(oFileInfo.FullName)
        Next

        For Each a As String In LIST_Expenses
            Try
                Dim DirDiretorio2 As DirectoryInfo = New DirectoryInfo(a & "\plots\")
                Dim oFileInfoCollection2() As FileInfo : oFileInfoCollection2 = DirDiretorio2.GetFiles("*.ini")
                For i = 0 To oFileInfoCollection2.Length() - 1

                    Dim ff As String = oFileInfoCollection2(i).FullName
                    Dim status As String = _INI.ReadIniFile(ff, "STATUS", "value", 0)
                    If status = 3 Then TOTAL = TOTAL + _INI.ReadIniFile(ff, "VALUE", "price")
                Next
            Catch ex As Exception

            End Try

        Next

        Return TOTAL
    End Function

    Function GetNumberOfExpense() As Integer

        Dim DirDiretorio As DirectoryInfo = New DirectoryInfo(_DIRECTORIES.ExpensesPath)
        Dim oFileInfoCollection() As DirectoryInfo

        '### Preenche o FileCollection com um Array de objetos FileInfo
        oFileInfoCollection = DirDiretorio.GetDirectories()

        '### Podemos utilizar os objetos da coleção oFileCollection para preencher um ListBox por exemplo
        Return oFileInfoCollection.Length()
    End Function

    Public Function Cryptography(ByVal value As String) As String

        'Crria um objeto encoding para assegurar o encoding padrão para o texto fonte

        Dim Ue As New UnicodeEncoding()


        'Retorna um array de bytes baseado no texto fonte

        Dim ByteSourceText() As Byte = Ue.GetBytes(value)


        'Instancia um objeto MD5

        Dim Md5 As New MD5CryptoServiceProvider()


        'Calcula o valor do hash para o texto

        Dim ByteHash() As Byte = Md5.ComputeHash(ByteSourceText)


        'Converte o valor para o formato string e retorna

        Return Convert.ToBase64String(ByteHash)


    End Function


    Public Function GetMonthName(ByVal mnth As Integer) As String
        Dim MonthN = _LANGUAGE.RESOURCES.Dates.GetMonth(mnth)

        Dim FirstLetter = MonthN(0).ToString.ToUpper
        Dim NewWord As String = FirstLetter

        For i = 1 To MonthN.Length - 1
            NewWord &= MonthN(i)
        Next
        Return NewWord
    End Function

    Public Function GetPorcentage(ByVal xvalue As Decimal, ByVal xp100 As Decimal) As Integer
        Try
            Dim _per100 As Decimal = xp100
            Dim _val As Decimal = xvalue
            Dim Result As Decimal
            Result = Val(_val * 100) / Val(_per100)
            Return Result
        Catch ex As Exception
            Return 0
        End Try
     
    End Function

    ''' <summary>
    ''' Calculo da Taxa de Juros
    ''' </summary>
    ''' <param name="interestValue"></param>
    ''' <param name="capitalValue"></param>
    ''' <returns></returns>
    Public Function CalcInteresTax(ByVal interestValue As Decimal, ByVal capitalValue As Decimal) As Decimal
        Try
            Dim X As Decimal = (100 * interestValue) / capitalValue
            Return X
        Catch
            Return 0
        End Try
    End Function



    ''' <summary>
    ''' Obter valor de todas as despesas do mês requisitado.
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function GetValueFromExpensesOfMonth(ByVal dt As Date) As Decimal
        Dim TOTAL As Decimal = 0
        Dim LIST_Expenses As New List(Of String)

        Dim DirDiretorio As DirectoryInfo = New DirectoryInfo(_DIRECTORIES.ExpensesPath)
        Dim oFileInfoCollection() As DirectoryInfo
        Dim oFileInfo As DirectoryInfo
        Dim i As Integer

        '### Preenche o FileCollection com um Array de objetos FileInfo
        oFileInfoCollection = DirDiretorio.GetDirectories()

        '### Podemos utilizar os objetos da coleção oFileCollection para preencher um ListBox por exemplo
        For i = 0 To oFileInfoCollection.Length() - 1
            oFileInfo = oFileInfoCollection.GetValue(i)
            LIST_Expenses.Add(oFileInfo.FullName)
        Next

        For Each a As String In LIST_Expenses
            Try
                Dim DirDiretorio2 As DirectoryInfo = New DirectoryInfo(a & "\plots\")
                Dim oFileInfoCollection2() As FileInfo : oFileInfoCollection2 = DirDiretorio2.GetFiles("*.ini")
                For i = 0 To oFileInfoCollection2.Length() - 1

                    Dim ff As String = oFileInfoCollection2(i).FullName

                    Dim PlotDate As Date = _INI.ReadIniFile(ff, "PLOT", "month")
                    If PlotDate.Date.Month = dt.Month And PlotDate.Date.Year = dt.Year Then _
                    TOTAL = TOTAL + _INI.ReadIniFile(ff, "VALUE", "price")
                Next
            Catch ex As Exception
            End Try
        Next

        Return TOTAL
    End Function

    ''' <summary>
    ''' obter valor ja pago das despesas do mês requisitado
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function GetValueFromExpensesPaidOfMonth(ByVal dt As Date) As Decimal
        Dim TOTAL As Decimal = 0
        Dim LIST_Expenses As New List(Of String)

        Dim DirDiretorio As DirectoryInfo = New DirectoryInfo(_DIRECTORIES.ExpensesPath)
        Dim oFileInfoCollection() As DirectoryInfo
        Dim oFileInfo As DirectoryInfo
        Dim i As Integer

        '### Preenche o FileCollection com um Array de objetos FileInfo
        oFileInfoCollection = DirDiretorio.GetDirectories()

        '### Podemos utilizar os objetos da coleção oFileCollection para preencher um ListBox por exemplo
        For i = 0 To oFileInfoCollection.Length() - 1
            oFileInfo = oFileInfoCollection.GetValue(i)
            LIST_Expenses.Add(oFileInfo.FullName)
        Next

        For Each a As String In LIST_Expenses
            Try
                Dim DirDiretorio2 As DirectoryInfo = New DirectoryInfo(a & "\plots\")
                Dim oFileInfoCollection2() As FileInfo : oFileInfoCollection2 = DirDiretorio2.GetFiles("*.ini")
                For i = 0 To oFileInfoCollection2.Length() - 1

                    Dim ff As String = oFileInfoCollection2(i).FullName
                    Dim status As String = _INI.ReadIniFile(ff, "STATUS", "value", 0)
                    Dim PlotDate As Date = _INI.ReadIniFile(ff, "PLOT", "month")

                    If PlotDate.Date.Year = dt.Year And PlotDate.Date.Month = dt.Month Then
                        If status = 3 Then TOTAL = TOTAL + _INI.ReadIniFile(ff, "VALUE", "price")
                    End If

                Next
            Catch ex As Exception

            End Try

        Next

        Return TOTAL
    End Function







End Class



Public Class ClassFunctions_Image



    Public Function ChangeImageResolution(ByVal img As Bitmap, ByVal img_new_pixel As Integer, Optional ByVal img_new_height As Integer = 0) As Bitmap
        ' cria bitmap
        Dim novoBitmap As New Bitmap(img_new_pixel, img_new_pixel, img.PixelFormat)

        ' cria objeto Graphics
        Dim g As Graphics = Graphics.FromImage(novoBitmap)

        ' modos de interpolação
        g.InterpolationMode = InterpolationMode.HighQualityBicubic

        ' qualidade de renderização
        g.SmoothingMode = SmoothingMode.HighQuality

        ' renderiza a imagem
        g.DrawImage(img, New Rectangle(0, 0, img_new_pixel, img_new_pixel),
                                  New Rectangle(0, 0, img.Width, img.Height), GraphicsUnit.Pixel)

        ' libera memória
        g.Dispose()

        ' retorna a nova imagem
        Return novoBitmap

    End Function

    Public Function InvertColorFromImage(ByVal img As Bitmap) As Image
        For X As Integer = 0 To (img.Width) - 1
            For Y As Integer = 0 To (img.Height) - 1
                Dim C As Color = img.GetPixel(X, Y)
                img.SetPixel(X, Y, Color.FromArgb(C.A, 255 - C.R, 255 - C.G, 255 - C.B))
            Next
        Next

        Return img
    End Function

    Public Function InvertColorFromImage(ByVal img As Bitmap, ByVal select_color As Color) As Image
        For X As Integer = 0 To (img.Width) - 1
            For Y As Integer = 0 To (img.Height) - 1

                Dim C As Color = img.GetPixel(X, Y)

                img.SetPixel(X, Y, Color.FromArgb(C.A, select_color.R, select_color.G, select_color.B))
            Next
        Next

        Return img
    End Function

End Class

Public Class ClassFunctions_Codes

    ''' <summary>
    ''' Gerar Números
    ''' </summary>
    ''' <param name="amount_number"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function GenerateNumbers(ByVal amount_number As Integer)
        Dim R As New Random
        Dim Numbers = ""
        For i = 1 To amount_number
            Numbers &= R.Next(0, 9)
        Next
        Return Numbers
    End Function

    ''' <summary>
    ''' Gerar Letras
    ''' </summary>
    ''' <param name="amount_lyrics"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function GenerateLyrics(ByVal amount_lyrics As Integer)
        Dim L() As String = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"}
        Dim R As New Random
        Dim Numbers = ""
        For i = 1 To amount_lyrics
            Numbers &= L(R.Next(0, 25))
        Next
        Return Numbers
    End Function

    ''' <summary>
    ''' Gerar Código de Comentário
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function GenerateCommentCode() As String
        Dim AA = GenerateLyrics(30)
        Return AA
    End Function

    ''' <summary>
    ''' Gerar Código do Histórico de Pagamento
    ''' </summary>
    ''' <returns></returns>
    Function GenerateHistoricPaymentCode() As String
        Dim AA = GenerateLyrics(2)
        Dim DateNow = Now.Date.Day & Now.Date.Month & Now.Date.Year
        Dim Code = AA & DateNow
        Return Code
    End Function

    Function GenerateCategoryCode()
        Dim AAA = GenerateLyrics(3)
        Dim NNNN = GenerateNumbers(5)
        Dim Code = AAA & NNNN
        If Not IO.Directory.Exists(_DIRECTORIES.CategorysPath & Code) Then
            Return Code
        End If
    End Function


    ''' <summary>
    ''' Gerar Código para Nova Despesa
    ''' </summary>
    Function GenerateExpenseCode()
        Dim AAA = GenerateLyrics(3)
        Dim NNNN = GenerateNumbers(7)
        Dim Code = "EXPENSE_" & AAA & NNNN
        If Not IO.Directory.Exists(_DIRECTORIES.ExpensesPath & Code) Then Return Code
    End Function

    ''' <summary>
    ''' Gerar Código para Novo Cartão de Crédito
    ''' </summary>
    Function GenerateCreditCardCode()
        Dim AAA = GenerateLyrics(3)
        Dim NNNN = GenerateNumbers(7)
        Dim Code = "CARD.CREDIT_" & AAA & NNNN
        If Not IO.Directory.Exists(_DIRECTORIES.ExpensesPath & Code) Then Return Code
    End Function

    ''' <summary>
    ''' Gerar Novo Código Para Parcela
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function GeneratePlotCode()
        Dim AAA = GenerateLyrics(5)
        Dim NNN = GenerateNumbers(5)
        Dim Code = "PLOT_" & AAA & NNN
        Return Code
    End Function

End Class

Public Class ClassFunctions_Interface
    'Dim a As New Class_ExpensesAndPlots.GetValue


    Protected Declare Function CreateRoundRectRgn Lib "Gdi32" (ByVal X1 As Integer, ByVal Y1 As Integer, ByVal X2 As Integer, ByVal Y2 As Integer, ByVal X3 As Integer, ByVal Y3 As Integer) As Integer
    Protected regionHandle As IntPtr
    Public Sub MakeRoundedEdges(ByVal element As Object, Optional ByVal size_border As Integer = 2)
        regionHandle = New IntPtr(CreateRoundRectRgn(0, 0, element.Width, element.Height, size_border, size_border))
        element.Region = Region.FromHrgn(regionHandle)
        element.Region.ReleaseHrgn(regionHandle)
    End Sub


    Public Sub DrawGradient(ByVal ctrl As Control, ByVal ctrl_graphics As PaintEventArgs, ByVal color1 As Color, ByVal color2 As Color)
        Dim retangulo As Rectangle = New Rectangle(0, 0, ctrl.Width, ctrl.Height)
        Dim meu_efeito As Brush = New Drawing.Drawing2D.LinearGradientBrush(retangulo, color1, color2, Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal)
        ctrl_graphics.Graphics.FillRectangle(meu_efeito, retangulo)
    End Sub


    ''' <summary>
    ''' Tonalidade de Cor
    ''' </summary>
    Function ColorTone(ByVal baseCode As Color) As Color
        ''Novas Cores:
        Dim NewR, NewG, NewB As Integer

        ''Obter RGB da Cor:
        Dim R As Integer = baseCode.R : Dim G As Integer = baseCode.G : Dim B As Integer = baseCode.B

        ''Obter Nova Cor:
        If Val(R + 20) <= 255 Then NewR = (R + 20) Else NewR = (R - 20)
        If Val(G + 20) <= 255 Then NewG = (G + 20) Else NewG = (G - 20)
        If Val(B + 20) <= 255 Then NewB = (B + 20) Else NewB = (B - 20)

        ''Nova Cor:
        Dim NewColor = Color.FromArgb(NewR, NewG, NewB)
        ''Retornar Cor:
        Return NewColor
    End Function
End Class


Public Class Class_ExpensesAndPlots


    Public Class GetValue

    End Class


End Class


Public Class Class_Categorys

    Function GetName(ByVal code As String) As String
        If code = "" Then
            Return "despesas sem categoria"
        Else
            Dim FileCategory As String = _DIRECTORIES.CategorysPath & code & "\category.ini"

            Dim Retorno = _LANGUAGE.RESOURCES.CategorysDefaultName.CategoryName(code)
            Select Case Retorno
                Case "error"
                    Return _INI.ReadIniFile(FileCategory, "CATEGORY", "name", "")
                Case Else
                    Return Retorno
            End Select
        End If
    End Function

    Function GetIconFile(ByVal code As String) As FileInfo
        Dim FileCategory As String = _DIRECTORIES.CategorysPath & code & "\category.ini"
        Dim IconCatego = _INI.ReadIniFile(FileCategory, "ICON", "file")

        Return New FileInfo(_DIRECTORIES.IconsPath & IconCatego)
    End Function

    Function GetIconImage(ByVal code As String) As Image
        Dim FileCategory As String = _DIRECTORIES.CategorysPath & code & "\category.ini"
        Dim IconCategory As String

        Select Case CheckCategoryStandard(code)
            Case True
                IconCategory = _DIRECTORIES.CategorysPath & code & "\icon.png"
                Dim img As Image = Image.FromFile(IconCategory)
                Return img

            Case False
                IconCategory = _INI.ReadIniFile(FileCategory, "ICON", "file")
                If IO.File.Exists(_DIRECTORIES.IconsPath & IconCategory) Then
                    Dim img As Image = Image.FromFile(_DIRECTORIES.IconsPath & IconCategory)
                    Return img
                Else
                    Return Nothing
                End If

        End Select
    End Function

    Function GetColor(ByVal code As String) As Color
        Dim FileCategory As String = _DIRECTORIES.CategorysPath & code & "\category.ini"
        Try
            Dim ColorCategory As Color = Color.FromArgb(_INI.ReadIniFile(FileCategory, "CATEGORY", "color"))
            Return ColorCategory
        Catch ex As Exception
            Return Color.Black
        End Try
    End Function

    Function GetIconColor(ByVal code As String) As Color
        Dim FileCategory As String = _DIRECTORIES.CategorysPath & code & "\category.ini"
        Try
            Dim ColorIcon As Color = Color.FromArgb(_INI.ReadIniFile(FileCategory, "ICON", "color"))
            Return ColorIcon
        Catch ex As Exception
            Return Color.White
        End Try
    End Function


    Function CheckCategoryStandard(ByVal category_code As String) As Boolean
        Select Case category_code
            Case "XC.CATEGORY_CLOTHING" : Return True
            Case "XC.CATEGORY_CREDITCARD" : Return True
            Case "XC.CATEGORY_EDUCATION" : Return True
            Case "XC.CATEGORY_ELECTRONICS" : Return True
            Case "XC.CATEGORY_HEALTH" : Return True
            Case "XC.CATEGORY_HOME" : Return True
            Case "XC.CATEGORY_RECREATION" : Return True
            Case "XC.CATEGORY_RESTAURANT" : Return True
            Case "XC.CATEGORY_SERVICES" : Return True
            Case "XC.CATEGORY_SUPERMARKET" : Return True
            Case "XC.CATEGORY_TRANSPORT" : Return True
            Case "XC.CATEGORY_TRIP" : Return True
            Case Else : Return False
        End Select

    End Function

    ''' <summary>
    ''' Obter uma lista com todos os códigos das categorias cadastradas no sistema
    ''' </summary>
    ''' <returns></returns>
    Public Function GetAllCategorys() As List(Of String)
        Dim DirPath As DirectoryInfo = New DirectoryInfo(_DIRECTORIES.CategorysPath)
        Dim CategorysFolders() As DirectoryInfo : CategorysFolders = DirPath.GetDirectories()

        Dim CategorysList As New List(Of String)
        For Each A As DirectoryInfo In CategorysFolders
            CategorysList.Add(A.Name)
        Next

        Return CategorysList

    End Function

    ''' <summary>
    ''' Obter Despesas da Categoria Solicitada | RETORNA UM LIST COM OS CÓDIGOS DAS DESPESAS
    ''' </summary>
    Public Function GetExpensesOfCategory(ByVal category_code As String) As List(Of String)
        ''Obter Todas as Despesas:
        Dim ExpensesList = _EXPENSES.GetExpenses(True)
        ''Lista de Retorno:
        Dim ListOfExpensesOfCategory As New List(Of String)
        ''Loop na Lista de Verificação:
        For Each EXPENSE As String In ExpensesList : If _EXPENSE.Category(EXPENSE) = category_code Then ListOfExpensesOfCategory.Add(EXPENSE)
        Next
        Return ListOfExpensesOfCategory
    End Function


End Class


Public Class CountLogClass

    Public Sub WriteInLog(ByVal text As String, Optional ByVal title As String = "")
        Try
            Dim DataForLog As String = "[" & Now.Date.Day & "." & Now.Date.Month & "." & Now.Date.Year & "]"

            Dim FileLog As String = _DIRECTORIES.PrimaryPath & "count_log " & DataForLog & ".txt"

            Dim TextInFile As String
            If IO.File.Exists(FileLog) Then TextInFile = My.Computer.FileSystem.ReadAllText(FileLog)

            TextInFile += title + vbNewLine + text & vbNewLine

            My.Computer.FileSystem.WriteAllText(FileLog, TextInFile, False)
        Catch ex As Exception

        End Try


    End Sub
End Class

Public Class ExpensesOpenedClass
    Public ExpenseCode As String
    Public ExpenseForm As ViewExpenseForm
End Class
