<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Can
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MesesCmb = New System.Windows.Forms.ComboBox()
        Me.AniosCmb = New System.Windows.Forms.ComboBox()
        Me.FechaDtp = New System.Windows.Forms.DateTimePicker()
        Me.HembraRdb = New System.Windows.Forms.RadioButton()
        Me.MachoRdb = New System.Windows.Forms.RadioButton()
        Me.ObservacionTxt = New System.Windows.Forms.TextBox()
        Me.PesoTxt = New System.Windows.Forms.TextBox()
        Me.ColorTxt = New System.Windows.Forms.TextBox()
        Me.RazaTxt = New System.Windows.Forms.TextBox()
        Me.NombreTxt = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button1.Location = New System.Drawing.Point(396, 376)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Guardar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MesesCmb
        '
        Me.MesesCmb.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MesesCmb.FormattingEnabled = True
        Me.MesesCmb.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11"})
        Me.MesesCmb.Location = New System.Drawing.Point(275, 329)
        Me.MesesCmb.Name = "MesesCmb"
        Me.MesesCmb.Size = New System.Drawing.Size(51, 21)
        Me.MesesCmb.TabIndex = 7
        Me.MesesCmb.Text = "Meses"
        '
        'AniosCmb
        '
        Me.AniosCmb.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.AniosCmb.FormattingEnabled = True
        Me.AniosCmb.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"})
        Me.AniosCmb.Location = New System.Drawing.Point(226, 329)
        Me.AniosCmb.Name = "AniosCmb"
        Me.AniosCmb.Size = New System.Drawing.Size(50, 21)
        Me.AniosCmb.TabIndex = 6
        Me.AniosCmb.Text = "Años"
        '
        'FechaDtp
        '
        Me.FechaDtp.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar
        Me.FechaDtp.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.FechaDtp.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaDtp.Location = New System.Drawing.Point(427, 330)
        Me.FechaDtp.Name = "FechaDtp"
        Me.FechaDtp.Size = New System.Drawing.Size(100, 20)
        Me.FechaDtp.TabIndex = 8
        '
        'HembraRdb
        '
        Me.HembraRdb.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.HembraRdb.AutoSize = True
        Me.HembraRdb.Location = New System.Drawing.Point(607, 305)
        Me.HembraRdb.Name = "HembraRdb"
        Me.HembraRdb.Size = New System.Drawing.Size(62, 17)
        Me.HembraRdb.TabIndex = 4
        Me.HembraRdb.TabStop = True
        Me.HembraRdb.Text = "Hembra"
        Me.HembraRdb.UseVisualStyleBackColor = True
        '
        'MachoRdb
        '
        Me.MachoRdb.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MachoRdb.AutoSize = True
        Me.MachoRdb.Location = New System.Drawing.Point(669, 306)
        Me.MachoRdb.Name = "MachoRdb"
        Me.MachoRdb.Size = New System.Drawing.Size(58, 17)
        Me.MachoRdb.TabIndex = 4
        Me.MachoRdb.TabStop = True
        Me.MachoRdb.Text = "Macho"
        Me.MachoRdb.UseVisualStyleBackColor = True
        '
        'ObservacionTxt
        '
        Me.ObservacionTxt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ObservacionTxt.Location = New System.Drawing.Point(621, 330)
        Me.ObservacionTxt.Name = "ObservacionTxt"
        Me.ObservacionTxt.Size = New System.Drawing.Size(100, 20)
        Me.ObservacionTxt.TabIndex = 9
        '
        'PesoTxt
        '
        Me.PesoTxt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PesoTxt.Location = New System.Drawing.Point(58, 329)
        Me.PesoTxt.Name = "PesoTxt"
        Me.PesoTxt.Size = New System.Drawing.Size(100, 20)
        Me.PesoTxt.TabIndex = 5
        '
        'ColorTxt
        '
        Me.ColorTxt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ColorTxt.Location = New System.Drawing.Point(427, 303)
        Me.ColorTxt.Name = "ColorTxt"
        Me.ColorTxt.Size = New System.Drawing.Size(100, 20)
        Me.ColorTxt.TabIndex = 3
        '
        'RazaTxt
        '
        Me.RazaTxt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.RazaTxt.Location = New System.Drawing.Point(226, 303)
        Me.RazaTxt.Name = "RazaTxt"
        Me.RazaTxt.Size = New System.Drawing.Size(100, 20)
        Me.RazaTxt.TabIndex = 2
        '
        'NombreTxt
        '
        Me.NombreTxt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.NombreTxt.Location = New System.Drawing.Point(58, 303)
        Me.NombreTxt.Name = "NombreTxt"
        Me.NombreTxt.Size = New System.Drawing.Size(100, 20)
        Me.NombreTxt.TabIndex = 1
        Me.NombreTxt.Tag = ""
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(548, 333)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 13)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Observación"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(352, 332)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 13)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "F. de Ingreso"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 332)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Peso"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(188, 332)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Edad"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(548, 307)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Sexo"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(352, 306)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Color"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(188, 306)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Raza"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 306)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Nombre"
        '
        'ListView1
        '
        Me.ListView1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8})
        Me.ListView1.Location = New System.Drawing.Point(12, 12)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(710, 285)
        Me.ListView1.TabIndex = 39
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Nombre"
        Me.ColumnHeader1.Width = 89
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Raza"
        Me.ColumnHeader2.Width = 68
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Color"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Sexo"
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Peso"
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Edad"
        Me.ColumnHeader6.Width = 103
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "F. de Ingreso"
        Me.ColumnHeader7.Width = 80
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Observacion"
        Me.ColumnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ColumnHeader8.Width = 183
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button2.Location = New System.Drawing.Point(265, 376)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Modificar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Can
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 411)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MesesCmb)
        Me.Controls.Add(Me.AniosCmb)
        Me.Controls.Add(Me.FechaDtp)
        Me.Controls.Add(Me.HembraRdb)
        Me.Controls.Add(Me.MachoRdb)
        Me.Controls.Add(Me.ObservacionTxt)
        Me.Controls.Add(Me.PesoTxt)
        Me.Controls.Add(Me.ColorTxt)
        Me.Controls.Add(Me.RazaTxt)
        Me.Controls.Add(Me.NombreTxt)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MinimumSize = New System.Drawing.Size(750, 450)
        Me.Name = "Can"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Canes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents MesesCmb As System.Windows.Forms.ComboBox
    Friend WithEvents AniosCmb As System.Windows.Forms.ComboBox
    Friend WithEvents FechaDtp As System.Windows.Forms.DateTimePicker
    Friend WithEvents HembraRdb As System.Windows.Forms.RadioButton
    Friend WithEvents MachoRdb As System.Windows.Forms.RadioButton
    Friend WithEvents ObservacionTxt As System.Windows.Forms.TextBox
    Friend WithEvents PesoTxt As System.Windows.Forms.TextBox
    Friend WithEvents ColorTxt As System.Windows.Forms.TextBox
    Friend WithEvents RazaTxt As System.Windows.Forms.TextBox
    Friend WithEvents NombreTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
