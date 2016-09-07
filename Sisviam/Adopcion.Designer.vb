<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Adopcion
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GuardarBtn = New System.Windows.Forms.Button()
        Me.ICanBtn = New System.Windows.Forms.Button()
        Me.ResponsableCmb = New System.Windows.Forms.ComboBox()
        Me.CanCmb = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SeguimientoCmb = New System.Windows.Forms.ComboBox()
        Me.FechaDtp = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.AdoptanteCmd = New System.Windows.Forms.ComboBox()
        Me.IAdoptanteBtn = New System.Windows.Forms.Button()
        Me.TablaDgv = New System.Windows.Forms.DataGridView()
        CType(Me.TablaDgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GuardarBtn
        '
        Me.GuardarBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.GuardarBtn.Location = New System.Drawing.Point(260, 376)
        Me.GuardarBtn.Name = "GuardarBtn"
        Me.GuardarBtn.Size = New System.Drawing.Size(75, 23)
        Me.GuardarBtn.TabIndex = 7
        Me.GuardarBtn.Text = "Guardar"
        Me.GuardarBtn.UseVisualStyleBackColor = True
        '
        'ICanBtn
        '
        Me.ICanBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.ICanBtn.Location = New System.Drawing.Point(237, 303)
        Me.ICanBtn.Name = "ICanBtn"
        Me.ICanBtn.Size = New System.Drawing.Size(75, 23)
        Me.ICanBtn.TabIndex = 2
        Me.ICanBtn.Text = "Ingresar Can"
        Me.ICanBtn.UseVisualStyleBackColor = True
        '
        'ResponsableCmb
        '
        Me.ResponsableCmb.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.ResponsableCmb.FormattingEnabled = True
        Me.ResponsableCmb.Location = New System.Drawing.Point(374, 334)
        Me.ResponsableCmb.Name = "ResponsableCmb"
        Me.ResponsableCmb.Size = New System.Drawing.Size(140, 21)
        Me.ResponsableCmb.TabIndex = 6
        Me.ResponsableCmb.Text = "Seleccione Responsable"
        '
        'CanCmb
        '
        Me.CanCmb.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.CanCmb.FormattingEnabled = True
        Me.CanCmb.Location = New System.Drawing.Point(73, 303)
        Me.CanCmb.Name = "CanCmb"
        Me.CanCmb.Size = New System.Drawing.Size(127, 21)
        Me.CanCmb.TabIndex = 1
        Me.CanCmb.Text = "Seleccione Can"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(371, 308)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Responsable"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 308)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Can"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(545, 308)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "F. de entrega"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(545, 337)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Seguimiento"
        '
        'SeguimientoCmb
        '
        Me.SeguimientoCmb.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.SeguimientoCmb.FormattingEnabled = True
        Me.SeguimientoCmb.Items.AddRange(New Object() {"Excelente", "Regular", "Pesimo"})
        Me.SeguimientoCmb.Location = New System.Drawing.Point(621, 334)
        Me.SeguimientoCmb.Name = "SeguimientoCmb"
        Me.SeguimientoCmb.Size = New System.Drawing.Size(100, 21)
        Me.SeguimientoCmb.TabIndex = 7
        Me.SeguimientoCmb.Text = "Estado"
        '
        'FechaDtp
        '
        Me.FechaDtp.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.FechaDtp.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaDtp.Location = New System.Drawing.Point(622, 303)
        Me.FechaDtp.Name = "FechaDtp"
        Me.FechaDtp.Size = New System.Drawing.Size(100, 20)
        Me.FechaDtp.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 337)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Adoptante"
        '
        'AdoptanteCmd
        '
        Me.AdoptanteCmd.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.AdoptanteCmd.FormattingEnabled = True
        Me.AdoptanteCmd.Location = New System.Drawing.Point(73, 334)
        Me.AdoptanteCmd.Name = "AdoptanteCmd"
        Me.AdoptanteCmd.Size = New System.Drawing.Size(127, 21)
        Me.AdoptanteCmd.TabIndex = 4
        Me.AdoptanteCmd.Text = "Seleccione Adoptante"
        '
        'IAdoptanteBtn
        '
        Me.IAdoptanteBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.IAdoptanteBtn.Location = New System.Drawing.Point(214, 332)
        Me.IAdoptanteBtn.Name = "IAdoptanteBtn"
        Me.IAdoptanteBtn.Size = New System.Drawing.Size(120, 23)
        Me.IAdoptanteBtn.TabIndex = 5
        Me.IAdoptanteBtn.Text = "Ingresar Adoptante"
        Me.IAdoptanteBtn.UseVisualStyleBackColor = True
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
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TablaDgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.TablaDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TablaDgv.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TablaDgv.DefaultCellStyle = DataGridViewCellStyle4
        Me.TablaDgv.Location = New System.Drawing.Point(12, 12)
        Me.TablaDgv.MultiSelect = False
        Me.TablaDgv.Name = "TablaDgv"
        Me.TablaDgv.ReadOnly = True
        Me.TablaDgv.RowHeadersVisible = False
        Me.TablaDgv.Size = New System.Drawing.Size(710, 285)
        Me.TablaDgv.TabIndex = 63
        '
        'Adopcion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(734, 411)
        Me.Controls.Add(Me.TablaDgv)
        Me.Controls.Add(Me.IAdoptanteBtn)
        Me.Controls.Add(Me.AdoptanteCmd)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.FechaDtp)
        Me.Controls.Add(Me.SeguimientoCmb)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GuardarBtn)
        Me.Controls.Add(Me.ICanBtn)
        Me.Controls.Add(Me.ResponsableCmb)
        Me.Controls.Add(Me.CanCmb)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MinimumSize = New System.Drawing.Size(750, 450)
        Me.Name = "Adopcion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Adopciones"
        CType(Me.TablaDgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GuardarBtn As System.Windows.Forms.Button
    Friend WithEvents ICanBtn As System.Windows.Forms.Button
    Friend WithEvents ResponsableCmb As System.Windows.Forms.ComboBox
    Friend WithEvents CanCmb As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents SeguimientoCmb As System.Windows.Forms.ComboBox
    Friend WithEvents FechaDtp As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents AdoptanteCmd As System.Windows.Forms.ComboBox
    Friend WithEvents IAdoptanteBtn As System.Windows.Forms.Button
    Friend WithEvents TablaDgv As System.Windows.Forms.DataGridView
End Class
