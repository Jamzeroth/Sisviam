Public Class Atencion_Ambulatoria
    Private id_aten As Integer
    Private id_can As Integer
    Private id_persona As Integer

    Public Function Ingresar_Atencion_Ambulatoria()
        BDcadena = "SELECT id_aten FROM sisviam.atencion_ambulatoria;"
        id_aten = AsignarId("id_aten")
        BDcadena = "SELECT id_can FROM sisviam.can WHERE `Nombre del can`='" + CanCmb.Text + "';"
        Almacenar_Datos()
        BDcadena = "SELECT id_persona FROM sisviam.persona WHERE `Nombre`='" + PersonaCmb.Text + "';"
        Almacenar_Datos()
        BDcadena = "INSERT INTO `sisviam`.`atencion_ambulatoria` (`id_aten`,`Persona_id_persona`,`Can_id_can`) VALUES ('" + CStr(id_aten) + "', '" + CStr(id_persona) + "', '" + CStr(id_persona) + "');"
        Almacenar_Datos()
    End Function

    Public Function Modificar_Atencion_Ambulatoria()

    End Function

    Private Sub Atencion_Ambulatoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BDcadena = "ALTER TABLE `sisviam`.`can`CHANGE COLUMN `Nombre` `Nombre del can` VARCHAR(45) NULL DEFAULT NULL COMMENT '' ;"
        Actualizar_Datos()
        Limpiar()
    End Sub

    Private Sub Limpiar()
        CanCmb.Text = "Seleccione Can"
        PersonaCmb.Text = "Seleccione Responsable"
        BDcadena = "SELECT `Nombre del can`,`Raza`,`Sexo`,`Edad` FROM sisviam.can WHERE EXISTS (SELECT `Can_id_can` FROM sisviam.atencion_ambulatoria WHERE can.id_can = atencion_ambulatoria.Can_id_can);"
        Dim TablaAux As DataTable = ObtenerTabla()
        BDcadena = "SELECT `Nombre`,`Dirección`,`Teléfono` FROM sisviam.persona WHERE EXISTS (SELECT `Persona_id_persona` FROM sisviam.atencion_ambulatoria WHERE persona.id_persona = atencion_ambulatoria.Persona_id_persona);"
        TablaAux.Merge(ObtenerTabla())
        TablaDgv.DataSource = TablaAux
        BDcadena = "SELECT `Nombre`,`Dirección`,`Teléfono` FROM sisviam.persona;"
        PersonaCmb.DataSource = ObtenerTabla()
        PersonaCmb.DisplayMember = "Nombre"
        BDcadena = "SELECT `Nombre del can` FROM sisviam.can;"
        CanCmb.DataSource = ObtenerTabla()
        CanCmb.DisplayMember = "Nombre del can"
    End Sub

    Private Sub ICanBtn_Click(sender As Object, e As EventArgs) Handles ICanBtn.Click
        Can.Dispose()
        BDcadena = "ALTER TABLE `sisviam`.`can`CHANGE COLUMN `Nombre del can` `Nombre` VARCHAR(45) NULL DEFAULT NULL COMMENT '' ;"
        Actualizar_Datos()
        Can.MdiParent = Me.ParentForm
        Can.Show()
        BDcadena = "ALTER TABLE `sisviam`.`can`CHANGE COLUMN `Nombre` `Nombre del can` VARCHAR(45) NULL DEFAULT NULL COMMENT '' ;"
        Actualizar_Datos()
    End Sub

    Private Sub IPersonaBtn_Click(sender As Object, e As EventArgs) Handles IPersonaBtn.Click
        Persona.Dispose()
        Persona.MdiParent = Me.ParentForm
        Persona.Show()
    End Sub

    Private Sub GuardarBtn_Click(sender As Object, e As EventArgs) Handles GuardarBtn.Click
        Ingresar_Atencion_Ambulatoria()
        Limpiar()
    End Sub

    Private Sub ModificarBtn_Click(sender As Object, e As EventArgs) Handles ModificarBtn.Click
        Modificar_Atencion_Ambulatoria()
        Limpiar()
    End Sub

    Private Sub Atencion_Ambulatoria_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        BDcadena = "ALTER TABLE `sisviam`.`can`CHANGE COLUMN `Nombre del can` `Nombre` VARCHAR(45) NULL DEFAULT NULL COMMENT '' ;"
        Actualizar_Datos()
    End Sub
End Class