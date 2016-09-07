Public Class Adopcion
    Private id_adop As Integer
    Private id_mv As Integer
    Private id_can As Integer
    Private id_persona As Integer
    Private fecha_entrega As Date
    Private seguimiento As String

    Private Sub Ingresar_Adopcion(sender As Object, e As EventArgs) Handles GuardarBtn.Click
        If (AdoptanteCmd.Text <> "Seleccione Adoptante") And (CanCmb.Text <> "Seleccione Can") And (ResponsableCmb.Text <> "Seleccione Responsable") Then
            seguimiento = SeguimientoCmb.Text
            BDcadena = "SELECT `id_adop` FROM sisviam.adopcion order by `id_adop`;"
            id_adop = AsignarId("id_adop")
            BDcadena = "SELECT `id_can` FROM sisviam.can WHERE `Nombre del can`='" + CanCmb.Text + "';"
            id_can = ObtenerId()
            BDcadena = "SELECT `id_persona` FROM sisviam.persona WHERE `Nombre`='" + AdoptanteCmd.Text + "';"
            id_persona = ObtenerId()
            BDcadena = "SELECT `id_mv` FROM sisviam.miembro_voluntario WHERE `Nombre`='" + ResponsableCmb.Text + "';"
            id_mv = ObtenerId()
            fecha_entrega = CDate(FechaDtp.Text)
            MsgBox(CStr(id_adop) + vbNewLine + CStr(id_can) + vbNewLine + CStr(id_mv) + vbNewLine + CStr(id_persona))
            BDcadena = "INSERT INTO `sisviam`.`adopcion` (`id_adop`,`persona_id_persona`,`can_id_can`,`miembro_voluntario_id_mv`, `Fecha de entrega`, `Seguimiento`) VALUES ('" + CStr(id_adop) + "', '" + CStr(id_persona) + "', '" + CStr(id_can) + "', '" + CStr(id_mv) + "', '" + CStr(fecha_entrega) + "', '" + seguimiento + "');"
            Almacenar_Datos()
            Limpiar()
        Else
            MsgBox("Seleccione un Adoptante, un Can y un Responsable")
        End If
    End Sub

    Private Sub Limpiar()
        BDcadena = "SELECT sisviam.can.`Nombre del can`, sisviam.persona.Nombre, sisviam.persona.Dirección, sisviam.persona.Teléfono, sisviam.miembro_voluntario.nombre, `Fecha de entrega`, `Seguimiento` FROM sisviam.adopcion inner join sisviam.can on sisviam.adopcion.can_id_can=sisviam.can.id_can inner join sisviam.persona on sisviam.adopcion.persona_id_persona=sisviam.persona.id_persona inner join sisviam.miembro_voluntario on sisviam.adopcion.miembro_voluntario_id_mv = sisviam.miembro_voluntario.id_mv order by `id_adop`;"
        TablaDgv.DataSource = ObtenerTabla()
        TablaDgv.Columns(4).HeaderText = "Responsable"
        TablaDgv.Columns(1).HeaderText = "Adoptante"
        BDcadena = "SELECT `Nombre` FROM sisviam.persona;"
        AdoptanteCmd.DataSource = ObtenerTabla()
        AdoptanteCmd.DisplayMember = "Nombre"
        BDcadena = "SELECT `Nombre del can` FROM sisviam.can;"
        CanCmb.DataSource = ObtenerTabla()
        CanCmb.DisplayMember = "Nombre del can"
        BDcadena = "SELECT `Nombre` FROM sisviam.miembro_voluntario;"
        ResponsableCmb.DataSource = ObtenerTabla()
        ResponsableCmb.DisplayMember = "Nombre"
        AdoptanteCmd.Text = "Seleccione Adoptante"
        CanCmb.Text = "Seleccione Can"
        ResponsableCmb.Text = "Seleccione Responsable"
        FechaDtp.Text = Now.ToShortDateString
        SeguimientoCmb.Text = "Estado"
    End Sub

    Private Sub Adopcion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Limpiar()
        TablaDgv.Columns("Nombre del can").SortMode = DataGridViewColumnSortMode.NotSortable
        TablaDgv.Columns("Nombre").SortMode = DataGridViewColumnSortMode.NotSortable
        TablaDgv.Columns("Dirección").SortMode = DataGridViewColumnSortMode.NotSortable
        TablaDgv.Columns("Teléfono").SortMode = DataGridViewColumnSortMode.NotSortable
        TablaDgv.Columns("nombre1").SortMode = DataGridViewColumnSortMode.NotSortable
        TablaDgv.Columns("Fecha de entrega").SortMode = DataGridViewColumnSortMode.NotSortable
        TablaDgv.Columns("Seguimiento").SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub

    Private Sub ICanBtn_Click(sender As Object, e As EventArgs) Handles ICanBtn.Click
        Can.Dispose()
        Can.MdiParent = Me.ParentForm
        Can.Show()
    End Sub

    Private Sub IAdoptanteBtn_Click(sender As Object, e As EventArgs) Handles IAdoptanteBtn.Click
        Persona.Dispose()
        Persona.MdiParent = Me.ParentForm
        Persona.Show()
    End Sub
End Class