<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Atencion_Ambulatoria
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
        Me.CanCmb = New System.Windows.Forms.ComboBox()
        Me.PersonaCmb = New System.Windows.Forms.ComboBox()
        Me.ICanBtn = New System.Windows.Forms.Button()
        Me.IPersonaBtn = New System.Windows.Forms.Button()
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
        Me.Label1.Location = New System.Drawing.Point(29, 264)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Can"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 291)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Responsable"
        '
        'CanCmb
        '
        Me.CanCmb.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.CanCmb.FormattingEnabled = True
        Me.CanCmb.Location = New System.Drawing.Point(104, 261)
        Me.CanCmb.Name = "CanCmb"
        Me.CanCmb.Size = New System.Drawing.Size(140, 21)
        Me.CanCmb.TabIndex = 1
        Me.CanCmb.Text = "Seleccione Can"
        '
        'PersonaCmb
        '
        Me.PersonaCmb.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.PersonaCmb.FormattingEnabled = True
        Me.PersonaCmb.Location = New System.Drawing.Point(104, 288)
        Me.PersonaCmb.Name = "PersonaCmb"
        Me.PersonaCmb.Size = New System.Drawing.Size(140, 21)
        Me.PersonaCmb.TabIndex = 3
        Me.PersonaCmb.Text = "Seleccione Responsable"
        '
        'ICanBtn
        '
        Me.ICanBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.ICanBtn.Location = New System.Drawing.Point(332, 259)
        Me.ICanBtn.Name = "ICanBtn"
        Me.ICanBtn.Size = New System.Drawing.Size(75, 23)
        Me.ICanBtn.TabIndex = 2
        Me.ICanBtn.Text = "Ingresar Can"
        Me.ICanBtn.UseVisualStyleBackColor = True
        '
        'IPersonaBtn
        '
        Me.IPersonaBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.IPersonaBtn.Location = New System.Drawing.Point(310, 286)
        Me.IPersonaBtn.Name = "IPersonaBtn"
        Me.IPersonaBtn.Size = New System.Drawing.Size(123, 23)
        Me.IPersonaBtn.TabIndex = 4
        Me.IPersonaBtn.Text = "Ingresar Responsable"
        Me.IPersonaBtn.UseVisualStyleBackColor = True
        '
        'GuardarBtn
        '
        Me.GuardarBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.GuardarBtn.Location = New System.Drawing.Point(134, 326)
        Me.GuardarBtn.Name = "GuardarBtn"
        Me.GuardarBtn.Size = New System.Drawing.Size(75, 23)
        Me.GuardarBtn.TabIndex = 5
        Me.GuardarBtn.Text = "Guardar"
        Me.GuardarBtn.UseVisualStyleBackColor = True
        '
        'ModificarBtn
        '
        Me.ModificarBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.ModificarBtn.Location = New System.Drawing.Point(274, 326)
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
        Me.TablaDgv.Size = New System.Drawing.Size(460, 241)
        Me.TablaDgv.TabIndex = 62
        '
        'Atencion_Ambulatoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 361)
        Me.Controls.Add(Me.TablaDgv)
        Me.Controls.Add(Me.ModificarBtn)
        Me.Controls.Add(Me.GuardarBtn)
        Me.Controls.Add(Me.IPersonaBtn)
        Me.Controls.Add(Me.ICanBtn)
        Me.Controls.Add(Me.PersonaCmb)
        Me.Controls.Add(Me.CanCmb)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MinimumSize = New System.Drawing.Size(500, 400)
        Me.Name = "Atencion_Ambulatoria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Atención Ambulatoria"
        CType(Me.TablaDgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CanCmb As System.Windows.Forms.ComboBox
    Friend WithEvents PersonaCmb As System.Windows.Forms.ComboBox
    Friend WithEvents ICanBtn As System.Windows.Forms.Button
    Friend WithEvents IPersonaBtn As System.Windows.Forms.Button
    Friend WithEvents GuardarBtn As System.Windows.Forms.Button
    Friend WithEvents ModificarBtn As System.Windows.Forms.Button
    Friend WithEvents TablaDgv As System.Windows.Forms.DataGridView
End Class
