﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Miembro_Voluntario
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
        Me.ModificarBtn = New System.Windows.Forms.Button()
        Me.GuardarBtn = New System.Windows.Forms.Button()
        Me.AniosCmb = New System.Windows.Forms.ComboBox()
        Me.FechaDtp = New System.Windows.Forms.DateTimePicker()
        Me.FemeninoRdb = New System.Windows.Forms.RadioButton()
        Me.MasculinoRdb = New System.Windows.Forms.RadioButton()
        Me.FuncionTxt = New System.Windows.Forms.TextBox()
        Me.Profesion_EstudiosTxt = New System.Windows.Forms.TextBox()
        Me.DireccionTxt = New System.Windows.Forms.TextBox()
        Me.TelefonoTxt = New System.Windows.Forms.TextBox()
        Me.NombreTxt = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TablaDgv = New System.Windows.Forms.DataGridView()
        CType(Me.TablaDgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ModificarBtn
        '
        Me.ModificarBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.ModificarBtn.Location = New System.Drawing.Point(389, 376)
        Me.ModificarBtn.Name = "ModificarBtn"
        Me.ModificarBtn.Size = New System.Drawing.Size(75, 23)
        Me.ModificarBtn.TabIndex = 10
        Me.ModificarBtn.Text = "Modificar"
        Me.ModificarBtn.UseVisualStyleBackColor = True
        '
        'GuardarBtn
        '
        Me.GuardarBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.GuardarBtn.Location = New System.Drawing.Point(246, 376)
        Me.GuardarBtn.Name = "GuardarBtn"
        Me.GuardarBtn.Size = New System.Drawing.Size(75, 23)
        Me.GuardarBtn.TabIndex = 9
        Me.GuardarBtn.Text = "Guardar"
        Me.GuardarBtn.UseVisualStyleBackColor = True
        '
        'AniosCmb
        '
        Me.AniosCmb.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.AniosCmb.FormattingEnabled = True
        Me.AniosCmb.Items.AddRange(New Object() {"15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "61", "62", "63", "64", "65", "66", "67", "68", "69", "70", "71", "72", "73", "74", "75"})
        Me.AniosCmb.Location = New System.Drawing.Point(272, 303)
        Me.AniosCmb.Name = "AniosCmb"
        Me.AniosCmb.Size = New System.Drawing.Size(100, 21)
        Me.AniosCmb.TabIndex = 2
        Me.AniosCmb.Text = "Años"
        '
        'FechaDtp
        '
        Me.FechaDtp.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar
        Me.FechaDtp.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.FechaDtp.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaDtp.Location = New System.Drawing.Point(461, 331)
        Me.FechaDtp.Name = "FechaDtp"
        Me.FechaDtp.Size = New System.Drawing.Size(100, 20)
        Me.FechaDtp.TabIndex = 7
        '
        'FemeninoRdb
        '
        Me.FemeninoRdb.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.FemeninoRdb.AutoSize = True
        Me.FemeninoRdb.Location = New System.Drawing.Point(74, 332)
        Me.FemeninoRdb.Name = "FemeninoRdb"
        Me.FemeninoRdb.Size = New System.Drawing.Size(34, 17)
        Me.FemeninoRdb.TabIndex = 5
        Me.FemeninoRdb.TabStop = True
        Me.FemeninoRdb.Text = "F."
        Me.FemeninoRdb.UseVisualStyleBackColor = True
        '
        'MasculinoRdb
        '
        Me.MasculinoRdb.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MasculinoRdb.AutoSize = True
        Me.MasculinoRdb.Location = New System.Drawing.Point(111, 332)
        Me.MasculinoRdb.Name = "MasculinoRdb"
        Me.MasculinoRdb.Size = New System.Drawing.Size(37, 17)
        Me.MasculinoRdb.TabIndex = 5
        Me.MasculinoRdb.TabStop = True
        Me.MasculinoRdb.Text = "M."
        Me.MasculinoRdb.UseVisualStyleBackColor = True
        '
        'FuncionTxt
        '
        Me.FuncionTxt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.FuncionTxt.Location = New System.Drawing.Point(623, 331)
        Me.FuncionTxt.Name = "FuncionTxt"
        Me.FuncionTxt.Size = New System.Drawing.Size(100, 20)
        Me.FuncionTxt.TabIndex = 8
        '
        'Profesion_EstudiosTxt
        '
        Me.Profesion_EstudiosTxt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Profesion_EstudiosTxt.Location = New System.Drawing.Point(272, 331)
        Me.Profesion_EstudiosTxt.Name = "Profesion_EstudiosTxt"
        Me.Profesion_EstudiosTxt.Size = New System.Drawing.Size(100, 20)
        Me.Profesion_EstudiosTxt.TabIndex = 6
        '
        'DireccionTxt
        '
        Me.DireccionTxt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DireccionTxt.Location = New System.Drawing.Point(461, 304)
        Me.DireccionTxt.Name = "DireccionTxt"
        Me.DireccionTxt.Size = New System.Drawing.Size(100, 20)
        Me.DireccionTxt.TabIndex = 3
        '
        'TelefonoTxt
        '
        Me.TelefonoTxt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TelefonoTxt.Location = New System.Drawing.Point(623, 304)
        Me.TelefonoTxt.Name = "TelefonoTxt"
        Me.TelefonoTxt.Size = New System.Drawing.Size(100, 20)
        Me.TelefonoTxt.TabIndex = 4
        '
        'NombreTxt
        '
        Me.NombreTxt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.NombreTxt.Location = New System.Drawing.Point(63, 304)
        Me.NombreTxt.Name = "NombreTxt"
        Me.NombreTxt.Size = New System.Drawing.Size(100, 20)
        Me.NombreTxt.TabIndex = 1
        Me.NombreTxt.Tag = ""
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(568, 334)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 13)
        Me.Label8.TabIndex = 58
        Me.Label8.Text = "Función"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(386, 334)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 13)
        Me.Label7.TabIndex = 57
        Me.Label7.Text = "F. de Ingreso"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(170, 334)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 13)
        Me.Label6.TabIndex = 56
        Me.Label6.Text = "Profesión/Estudios"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(170, 307)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 55
        Me.Label5.Text = "Edad"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 334)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "Género"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(386, 307)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "Dirección"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(568, 307)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "Teléfono"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 307)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Nombre"
        '
        'TablaDgv
        '
        Me.TablaDgv.AllowUserToAddRows = False
        Me.TablaDgv.AllowUserToDeleteRows = False
        Me.TablaDgv.AllowUserToOrderColumns = True
        Me.TablaDgv.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TablaDgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TablaDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TablaDgv.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TablaDgv.Location = New System.Drawing.Point(12, 12)
        Me.TablaDgv.MultiSelect = False
        Me.TablaDgv.Name = "TablaDgv"
        Me.TablaDgv.ReadOnly = True
        Me.TablaDgv.RowHeadersVisible = False
        Me.TablaDgv.Size = New System.Drawing.Size(710, 285)
        Me.TablaDgv.TabIndex = 59
        '
        'Miembro_Voluntario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 411)
        Me.Controls.Add(Me.TablaDgv)
        Me.Controls.Add(Me.ModificarBtn)
        Me.Controls.Add(Me.GuardarBtn)
        Me.Controls.Add(Me.AniosCmb)
        Me.Controls.Add(Me.FechaDtp)
        Me.Controls.Add(Me.FemeninoRdb)
        Me.Controls.Add(Me.MasculinoRdb)
        Me.Controls.Add(Me.FuncionTxt)
        Me.Controls.Add(Me.Profesion_EstudiosTxt)
        Me.Controls.Add(Me.DireccionTxt)
        Me.Controls.Add(Me.TelefonoTxt)
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
        Me.Name = "Miembro_Voluntario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Miembros y Voluntarios"
        CType(Me.TablaDgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ModificarBtn As System.Windows.Forms.Button
    Friend WithEvents GuardarBtn As System.Windows.Forms.Button
    Friend WithEvents AniosCmb As System.Windows.Forms.ComboBox
    Friend WithEvents FechaDtp As System.Windows.Forms.DateTimePicker
    Friend WithEvents FemeninoRdb As System.Windows.Forms.RadioButton
    Friend WithEvents MasculinoRdb As System.Windows.Forms.RadioButton
    Friend WithEvents FuncionTxt As System.Windows.Forms.TextBox
    Friend WithEvents Profesion_EstudiosTxt As System.Windows.Forms.TextBox
    Friend WithEvents DireccionTxt As System.Windows.Forms.TextBox
    Friend WithEvents TelefonoTxt As System.Windows.Forms.TextBox
    Friend WithEvents NombreTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TablaDgv As System.Windows.Forms.DataGridView
End Class
