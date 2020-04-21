<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SlideShow02
    Inherits System.Windows.Forms.UserControl

    'Descartar substituições de UserControl para limpar lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: O procedimento a seguir é exigido pelo Windows Form Designer
    'Ele pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TitleMenuLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.HeaderPanel = New System.Windows.Forms.Panel()
        Me.Dashboard_OldUser = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Dashboard_NewUser = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.HeaderPanel.SuspendLayout()
        Me.Dashboard_OldUser.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Dashboard_NewUser.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TitleMenuLabel
        '
        Me.TitleMenuLabel.AutoSize = True
        Me.TitleMenuLabel.BackColor = System.Drawing.Color.Transparent
        Me.TitleMenuLabel.Font = New System.Drawing.Font("Segoe UI Semilight", 20.0!)
        Me.TitleMenuLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.TitleMenuLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TitleMenuLabel.Location = New System.Drawing.Point(30, 30)
        Me.TitleMenuLabel.Name = "TitleMenuLabel"
        Me.TitleMenuLabel.Size = New System.Drawing.Size(498, 37)
        Me.TitleMenuLabel.TabIndex = 28
        Me.TitleMenuLabel.Text = "Vamos começar do início... Mais uma vez!"
        Me.TitleMenuLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(33, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 19)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "DASHBOARD"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(33, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(423, 19)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Sua Dashboard está de cara nova, mais dinamica e mais informativa:"
        '
        'HeaderPanel
        '
        Me.HeaderPanel.Controls.Add(Me.TitleMenuLabel)
        Me.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.HeaderPanel.Location = New System.Drawing.Point(0, 0)
        Me.HeaderPanel.Name = "HeaderPanel"
        Me.HeaderPanel.Size = New System.Drawing.Size(1164, 97)
        Me.HeaderPanel.TabIndex = 33
        '
        'Dashboard_OldUser
        '
        Me.Dashboard_OldUser.Controls.Add(Me.Panel1)
        Me.Dashboard_OldUser.Controls.Add(Me.Label6)
        Me.Dashboard_OldUser.Controls.Add(Me.Label7)
        Me.Dashboard_OldUser.Controls.Add(Me.Label5)
        Me.Dashboard_OldUser.Controls.Add(Me.Label1)
        Me.Dashboard_OldUser.Controls.Add(Me.Label2)
        Me.Dashboard_OldUser.Controls.Add(Me.Label3)
        Me.Dashboard_OldUser.Dock = System.Windows.Forms.DockStyle.Top
        Me.Dashboard_OldUser.Location = New System.Drawing.Point(0, 97)
        Me.Dashboard_OldUser.Name = "Dashboard_OldUser"
        Me.Dashboard_OldUser.Size = New System.Drawing.Size(1164, 313)
        Me.Dashboard_OldUser.TabIndex = 34
        Me.Dashboard_OldUser.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(33, 206)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(580, 38)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Removemos os seletores de anos, mas colocamos eles em outro lugar mais prático e " & _
    "útil." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "E também agora a legenda de ano exibi o mês que está selecionado atualmen" & _
    "te no calendário."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(33, 187)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 19)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Seletores de Anos"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(33, 249)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(147, 19)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Modo de Visualização"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(33, 268)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(657, 38)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Também recolocamos os seletores de visualização em outro local, mas tudo fica ace" & _
    "ssível no botão ""Filtros""," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "localizado no canto superior direito."
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Dashboard_NewUser)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 410)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1164, 196)
        Me.Panel2.TabIndex = 35
        Me.Panel2.Visible = False
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!)
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Label15.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label15.Location = New System.Drawing.Point(33, 3)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(93, 19)
        Me.Label15.TabIndex = 30
        Me.Label15.Text = "DASHBOARD"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!)
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label16.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label16.Location = New System.Drawing.Point(33, 22)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(498, 19)
        Me.Label16.TabIndex = 31
        Me.Label16.Text = "Esta é a sua Dashboard, nela você verá as informações gerais das suas despesas."
        '
        'Dashboard_NewUser
        '
        Me.Dashboard_NewUser.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Dashboard_NewUser.BackgroundImage = Global.xpeg_count_project.My.Resources.SlidesImages.NewDashboard
        Me.Dashboard_NewUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Dashboard_NewUser.Controls.Add(Me.Label9)
        Me.Dashboard_NewUser.Controls.Add(Me.Label10)
        Me.Dashboard_NewUser.Location = New System.Drawing.Point(25, 44)
        Me.Dashboard_NewUser.Name = "Dashboard_NewUser"
        Me.Dashboard_NewUser.Size = New System.Drawing.Size(1136, 140)
        Me.Dashboard_NewUser.TabIndex = 40
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label9.Location = New System.Drawing.Point(130, 12)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(167, 15)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "<-- Visualização de Mês e Ano"
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label10.Location = New System.Drawing.Point(1040, 12)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(60, 15)
        Me.Label10.TabIndex = 38
        Me.Label10.Text = "Filtros -->"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackgroundImage = Global.xpeg_count_project.My.Resources.SlidesImages.NewDashboard
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(25, 44)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1136, 140)
        Me.Panel1.TabIndex = 40
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(130, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(167, 15)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "<-- Visualização de Mês e Ano"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(1040, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 15)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Filtros -->"
        '
        'SlideShow02
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Dashboard_OldUser)
        Me.Controls.Add(Me.HeaderPanel)
        Me.Name = "SlideShow02"
        Me.Size = New System.Drawing.Size(1164, 558)
        Me.HeaderPanel.ResumeLayout(False)
        Me.HeaderPanel.PerformLayout()
        Me.Dashboard_OldUser.ResumeLayout(False)
        Me.Dashboard_OldUser.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Dashboard_NewUser.ResumeLayout(False)
        Me.Dashboard_NewUser.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TitleMenuLabel As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents HeaderPanel As System.Windows.Forms.Panel
    Friend WithEvents Dashboard_OldUser As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Dashboard_NewUser As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label

End Class
