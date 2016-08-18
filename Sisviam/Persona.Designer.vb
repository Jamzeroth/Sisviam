<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Persona
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NombreTxt = New System.Windows.Forms.TextBox()
        Me.DireccionTxt = New System.Windows.Forms.TextBox()
        Me.TelefonoTxt = New System.Windows.Forms.TextBox()
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
        Me.Label1.Location = New System.Drawing.Point(241, 224)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(240, 250)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Dirección"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(240, 276)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Teléfono"
        '
        'NombreTxt
        '
        Me.NombreTxt.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.NombreTxt.Location = New System.Drawing.Point(310, 221)
        Me.NombreTxt.Name = "NombreTxt"
        Me.NombreTxt.Size = New System.Drawing.Size(100, 20)
        Me.NombreTxt.TabIndex = 1
        '
        'DireccionTxt
        '
        Me.DireccionTxt.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.DireccionTxt.Location = New System.Drawing.Point(310, 247)
        Me.DireccionTxt.Name = "DireccionTxt"
        Me.DireccionTxt.Size = New System.Drawing.Size(100, 20)
        Me.DireccionTxt.TabIndex = 2
        '
        'TelefonoTxt
        '
        Me.TelefonoTxt.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.TelefonoTxt.Location = New System.Drawing.Point(310, 273)
        Me.TelefonoTxt.Name = "TelefonoTxt"
        Me.TelefonoTxt.Size = New System.Drawing.Size(100, 20)
        Me.TelefonoTxt.TabIndex = 3
        '
        'GuardarBtn
        '
        Me.GuardarBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.GuardarBtn.Location = New System.Drawing.Point(222, 323)
        Me.GuardarBtn.Name = "GuardarBtn"
        Me.GuardarBtn.Size = New System.Drawing.Size(75, 23)
        Me.GuardarBtn.TabIndex = 4
        Me.GuardarBtn.Text = "Guardar"
        Me.GuardarBtn.UseVisualStyleBackColor = True
        '
        'ModificarBtn
        '
        Me.ModificarBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.ModificarBtn.Location = New System.Drawing.Point(347, 323)
        Me.ModificarBtn.Name = "ModificarBtn"
        Me.ModificarBtn.Size = New System.Drawing.Size(75, 23)
        Me.ModificarBtn.TabIndex = 5
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
        Me.TablaDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TablaDgv.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TablaDgv.Location = New System.Drawing.Point(12, 12)
        Me.TablaDgv.MultiSelect = False
        Me.TablaDgv.Name = "TablaDgv"
        Me.TablaDgv.ReadOnly = True
        Me.TablaDgv.RowHeadersVisible = False
        Me.TablaDgv.Size = New System.Drawing.Size(613, 203)
        Me.TablaDgv.TabIndex = 6
        '
        'Persona
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(637, 358)
        Me.Controls.Add(Me.TablaDgv)
        Me.Controls.Add(Me.ModificarBtn)
        Me.Controls.Add(Me.GuardarBtn)
        Me.Controls.Add(Me.TelefonoTxt)
        Me.Controls.Add(Me.DireccionTxt)
        Me.Controls.Add(Me.NombreTxt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MinimumSize = New System.Drawing.Size(300, 200)
        Me.Name = "Persona"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Persona"
        CType(Me.TablaDgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents NombreTxt As System.Windows.Forms.TextBox
    Friend WithEvents DireccionTxt As System.Windows.Forms.TextBox
    Friend WithEvents TelefonoTxt As System.Windows.Forms.TextBox
    Friend WithEvents GuardarBtn As System.Windows.Forms.Button
    Friend WithEvents ModificarBtn As System.Windows.Forms.Button
    Friend WithEvents TablaDgv As System.Windows.Forms.DataGridView
End Class
