<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Campania
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.FechaDtp = New System.Windows.Forms.DateTimePicker()
        Me.NatencionesTxt = New System.Windows.Forms.TextBox()
        Me.DireccionTxt = New System.Windows.Forms.TextBox()
        Me.LugarTxt = New System.Windows.Forms.TextBox()
        Me.GuardarBtn = New System.Windows.Forms.Button()
        Me.ModificarBtn = New System.Windows.Forms.Button()
        Me.TablaDgv = New System.Windows.Forms.DataGridView()
        CType(Me.TablaDgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(228, 212)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Dirección"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(62, 212)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Lugar"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(62, 238)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Fecha"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(228, 238)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "N. de atenciones"
        '
        'FechaDtp
        '
        Me.FechaDtp.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.FechaDtp.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaDtp.Location = New System.Drawing.Point(105, 235)
        Me.FechaDtp.Name = "FechaDtp"
        Me.FechaDtp.Size = New System.Drawing.Size(100, 20)
        Me.FechaDtp.TabIndex = 3
        '
        'NatencionesTxt
        '
        Me.NatencionesTxt.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.NatencionesTxt.Location = New System.Drawing.Point(322, 235)
        Me.NatencionesTxt.Name = "NatencionesTxt"
        Me.NatencionesTxt.Size = New System.Drawing.Size(100, 20)
        Me.NatencionesTxt.TabIndex = 4
        '
        'DireccionTxt
        '
        Me.DireccionTxt.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.DireccionTxt.Location = New System.Drawing.Point(322, 209)
        Me.DireccionTxt.Name = "DireccionTxt"
        Me.DireccionTxt.Size = New System.Drawing.Size(100, 20)
        Me.DireccionTxt.TabIndex = 2
        '
        'LugarTxt
        '
        Me.LugarTxt.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.LugarTxt.Location = New System.Drawing.Point(105, 209)
        Me.LugarTxt.Name = "LugarTxt"
        Me.LugarTxt.Size = New System.Drawing.Size(100, 20)
        Me.LugarTxt.TabIndex = 1
        '
        'GuardarBtn
        '
        Me.GuardarBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.GuardarBtn.Location = New System.Drawing.Point(156, 276)
        Me.GuardarBtn.Name = "GuardarBtn"
        Me.GuardarBtn.Size = New System.Drawing.Size(75, 23)
        Me.GuardarBtn.TabIndex = 5
        Me.GuardarBtn.Text = "Guardar"
        Me.GuardarBtn.UseVisualStyleBackColor = True
        '
        'ModificarBtn
        '
        Me.ModificarBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.ModificarBtn.Location = New System.Drawing.Point(259, 276)
        Me.ModificarBtn.Name = "ModificarBtn"
        Me.ModificarBtn.Size = New System.Drawing.Size(75, 23)
        Me.ModificarBtn.TabIndex = 6
        Me.ModificarBtn.Text = "Modificar"
        Me.ModificarBtn.UseVisualStyleBackColor = True
        '
        'TablaDgv
        '
        Me.TablaDgv.AllowUserToAddRows = False
        Me.TablaDgv.AllowUserToDeleteRows = False
        Me.TablaDgv.AllowUserToOrderColumns = True
        Me.TablaDgv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TablaDgv.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TablaDgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TablaDgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.TablaDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TablaDgv.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TablaDgv.DefaultCellStyle = DataGridViewCellStyle2
        Me.TablaDgv.Location = New System.Drawing.Point(12, 12)
        Me.TablaDgv.MultiSelect = False
        Me.TablaDgv.Name = "TablaDgv"
        Me.TablaDgv.ReadOnly = True
        Me.TablaDgv.RowHeadersVisible = False
        Me.TablaDgv.Size = New System.Drawing.Size(460, 191)
        Me.TablaDgv.TabIndex = 61
        '
        'Campania
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 311)
        Me.Controls.Add(Me.TablaDgv)
        Me.Controls.Add(Me.ModificarBtn)
        Me.Controls.Add(Me.GuardarBtn)
        Me.Controls.Add(Me.LugarTxt)
        Me.Controls.Add(Me.DireccionTxt)
        Me.Controls.Add(Me.NatencionesTxt)
        Me.Controls.Add(Me.FechaDtp)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MinimumSize = New System.Drawing.Size(500, 350)
        Me.Name = "Campania"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Campañas"
        CType(Me.TablaDgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents FechaDtp As System.Windows.Forms.DateTimePicker
    Friend WithEvents NatencionesTxt As System.Windows.Forms.TextBox
    Friend WithEvents DireccionTxt As System.Windows.Forms.TextBox
    Friend WithEvents LugarTxt As System.Windows.Forms.TextBox
    Friend WithEvents GuardarBtn As System.Windows.Forms.Button
    Friend WithEvents ModificarBtn As System.Windows.Forms.Button
    Friend WithEvents TablaDgv As System.Windows.Forms.DataGridView
End Class
