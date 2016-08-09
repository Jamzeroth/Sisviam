<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MENU
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MENU))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.InicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CanesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdopcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AtencionesAmbulatoriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MiembrosYVoluntariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CampañasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PersonaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InicioToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(784, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'InicioToolStripMenuItem
        '
        Me.InicioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CanesToolStripMenuItem, Me.AdopcionesToolStripMenuItem, Me.AtencionesAmbulatoriosToolStripMenuItem, Me.MiembrosYVoluntariosToolStripMenuItem, Me.CampañasToolStripMenuItem, Me.PersonaToolStripMenuItem})
        Me.InicioToolStripMenuItem.Name = "InicioToolStripMenuItem"
        Me.InicioToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.InicioToolStripMenuItem.Text = "Inicio"
        '
        'CanesToolStripMenuItem
        '
        Me.CanesToolStripMenuItem.Name = "CanesToolStripMenuItem"
        Me.CanesToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.CanesToolStripMenuItem.Text = "Canes"
        '
        'AdopcionesToolStripMenuItem
        '
        Me.AdopcionesToolStripMenuItem.Name = "AdopcionesToolStripMenuItem"
        Me.AdopcionesToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.AdopcionesToolStripMenuItem.Text = "Adopciones"
        '
        'AtencionesAmbulatoriosToolStripMenuItem
        '
        Me.AtencionesAmbulatoriosToolStripMenuItem.Name = "AtencionesAmbulatoriosToolStripMenuItem"
        Me.AtencionesAmbulatoriosToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.AtencionesAmbulatoriosToolStripMenuItem.Text = "Atenciones Ambulatorias"
        '
        'MiembrosYVoluntariosToolStripMenuItem
        '
        Me.MiembrosYVoluntariosToolStripMenuItem.Name = "MiembrosYVoluntariosToolStripMenuItem"
        Me.MiembrosYVoluntariosToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.MiembrosYVoluntariosToolStripMenuItem.Text = "Miembros y Voluntarios"
        '
        'CampañasToolStripMenuItem
        '
        Me.CampañasToolStripMenuItem.Name = "CampañasToolStripMenuItem"
        Me.CampañasToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.CampañasToolStripMenuItem.Text = "Campañas"
        '
        'PersonaToolStripMenuItem
        '
        Me.PersonaToolStripMenuItem.Name = "PersonaToolStripMenuItem"
        Me.PersonaToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.PersonaToolStripMenuItem.Text = "Persona"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(629, 490)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(143, 59)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'MENU
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MENU"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sisviam"
        Me.TransparencyKey = System.Drawing.Color.Transparent
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents InicioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CanesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdopcionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AtencionesAmbulatoriosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CampañasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MiembrosYVoluntariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PersonaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
