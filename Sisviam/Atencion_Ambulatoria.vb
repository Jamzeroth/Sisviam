Public Class Atencion_Ambulatoria
    Private id_aten As Integer
    Private id_can As Integer
    Private id_persona As Integer

    Private Sub Ingresar_Atencion_Ambulatoria(sender As Object, e As EventArgs) Handles GuardarBtn.Click
        If (PersonaCmb.Text <> "Seleccione Responsable") And (CanCmb.Text <> "Seleccione Can") Then
            BDcadena = "SELECT `id_aten` FROM sisviam.atencion_ambulatoria order by `id_aten`;"
            id_aten = AsignarId("id_aten")
            BDcadena = "SELECT `id_can` FROM sisviam.can WHERE `Nombre del can`='" + CanCmb.Text + "';"
            id_can = ObtenerId()
            BDcadena = "SELECT `id_persona` FROM sisviam.persona WHERE `Nombre`='" + PersonaCmb.Text + "';"
            id_persona = ObtenerId()
            BDcadena = "INSERT INTO `sisviam`.`atencion_ambulatoria` (`id_aten`,`persona_id_persona`,`can_id_can`) VALUES ('" + CStr(id_aten) + "', '" + CStr(id_persona) + "', '" + CStr(id_can) + "');"
            Almacenar_Datos()
            Limpiar()
        Else
            MsgBox("Seleccione un Responsable y un Can")
        End If
    End Sub

    Private Sub Limpiar()
        BDcadena = "SELECT sisviam.can.`Nombre del can`, sisviam.can.Raza, sisviam.can.Sexo, sisviam.can.Edad, sisviam.persona.Nombre, sisviam.persona.Dirección, sisviam.persona.Teléfono FROM sisviam.atencion_ambulatoria inner join sisviam.can on sisviam.atencion_ambulatoria.can_id_can=sisviam.can.id_can inner join sisviam.persona on sisviam.atencion_ambulatoria.persona_id_persona=sisviam.persona.id_persona order by `id_can`, `id_aten`;"
        TablaDgv.DataSource = ObtenerTabla()
        TablaDgv.Columns(4).HeaderText = "Responsable"
        BDcadena = "SELECT `Nombre` FROM sisviam.persona;"
        PersonaCmb.DataSource = ObtenerTabla()
        PersonaCmb.DisplayMember = "Nombre"
        BDcadena = "SELECT `Nombre del can` FROM sisviam.can;"
        CanCmb.DataSource = ObtenerTabla()
        CanCmb.DisplayMember = "Nombre del can"
        CanCmb.Text = "Seleccione Can"
        PersonaCmb.Text = "Seleccione Responsable"
    End Sub

    Private Sub Atencion_Ambulatoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Limpiar()
        TablaDgv.Columns("Nombre del can").SortMode = DataGridViewColumnSortMode.NotSortable
        TablaDgv.Columns("Raza").SortMode = DataGridViewColumnSortMode.NotSortable
        TablaDgv.Columns("Sexo").SortMode = DataGridViewColumnSortMode.NotSortable
        TablaDgv.Columns("Edad").SortMode = DataGridViewColumnSortMode.NotSortable
        TablaDgv.Columns("Nombre").SortMode = DataGridViewColumnSortMode.NotSortable
        TablaDgv.Columns("Dirección").SortMode = DataGridViewColumnSortMode.NotSortable
        TablaDgv.Columns("Teléfono").SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub

    Private Sub ICanBtn_Click(sender As Object, e As EventArgs) Handles ICanBtn.Click
        Can.Dispose()
        Can.MdiParent = Me.ParentForm
        Can.Show()
    End Sub

    Private Sub IPersonaBtn_Click(sender As Object, e As EventArgs) Handles IPersonaBtn.Click
        Persona.Dispose()
        Persona.MdiParent = Me.ParentForm
        Persona.Show()
    End Sub
End Class