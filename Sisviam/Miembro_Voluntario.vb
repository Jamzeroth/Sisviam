Public Class Miembro_Voluntario
    Private id_mv As Integer
    Private nombre As String
    Private edad As Integer
    Private direccion As String
    Private telefono As String
    Private sexo As String
    Private profesion_estudios As String
    Private fecha_ingreso As Date
    Private funcion As String

    Public Function Ingresar_Miembro_Voluntario()
        id_mv = Asignar_id_mv()
        nombre = NombreTxt.Text
        direccion = DireccionTxt.Text
        telefono = TelefonoTxt.Text
        profesion_estudios = Profesion_EstudiosTxt.Text
        funcion = FuncionTxt.Text
        If (AniosCmb.Text = "Años") Then edad = 0 Else edad = CInt(AniosCmb.Text)
        If (FemeninoRdb.Checked) Then
            sexo = FemeninoRdb.Text
        ElseIf (MasculinoRdb.Checked) Then
            sexo = MasculinoRdb.Text
        Else
            MsgBox("Aún no selecciona un género")
        End If
        fecha_ingreso = CDate(FechaDtp.Text)
        BDcadena = "INSERT INTO `sisviam`.`miembro_voluntario` (`id_mv`,`Nombre`,`Edad`,`Dirección`,`Teléfono`,`Género`,`Profesión o estudios`,`Fecha de ingreso`,`Función`) VALUES ('" + CStr(id_mv) + "', '" + nombre + "','" + CStr(edad) + "', '" + direccion + "', '" + telefono + "','" + sexo + "','" + profesion_estudios + "','" + CStr(fecha_ingreso) + "','" + funcion + "');"
        Almacenar_Datos()
    End Function

    Public Function Asignar_id_mv() As Integer
        BDcadena = "SELECT id_mv FROM sisviam.miembro_voluntario;"
        Return AsignarId("id_mv")
    End Function

    Public Function Modificar_Miembro_Voluntario()
        Dim y As Integer = CInt(TablaDgv.SelectedCells(0).RowIndex) 'filas
        Dim x As Integer = CInt(TablaDgv.SelectedCells(0).ColumnIndex) 'columnas
        Dim atributo As String = ""
        Select Case (x)
            Case 0
                atributo = "Nombre"
            Case 1
                atributo = "Edad"
            Case 2
                atributo = "Dirección"
            Case 3
                atributo = "Teléfono"
            Case 4
                atributo = "Género"
            Case 5
                atributo = "Profesión o estudios"
            Case 6
                atributo = "Fecha de ingreso"
            Case 7
                atributo = "Función"
        End Select
        Dim nuevo As String = InputBox("Ingrese un nuevo dato para: " + atributo, "Modificar", CStr(TablaDgv.SelectedCells(0).Value))
        BDcadena = "UPDATE `sisviam`.`miembro_voluntario` SET `" + atributo + "`='" + nuevo + "' WHERE `id_mv`='" + CStr(y) + "';"
        Actualizar_Datos()
    End Function

    Private Sub Miembro_Voluntario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nombre = ""
        edad = 0
        direccion = ""
        telefono = ""
        sexo = ""
        profesion_estudios = ""
        fecha_ingreso = Now.ToShortDateString
        funcion = ""
        Limpiar()
        TablaDgv.Columns("Nombre").SortMode = DataGridViewColumnSortMode.NotSortable
        TablaDgv.Columns("Edad").SortMode = DataGridViewColumnSortMode.NotSortable
        TablaDgv.Columns("Dirección").SortMode = DataGridViewColumnSortMode.NotSortable
        TablaDgv.Columns("Teléfono").SortMode = DataGridViewColumnSortMode.NotSortable
        TablaDgv.Columns("Género").SortMode = DataGridViewColumnSortMode.NotSortable
        TablaDgv.Columns("Profesión o estudios").SortMode = DataGridViewColumnSortMode.NotSortable
        TablaDgv.Columns("Fecha de ingreso").SortMode = DataGridViewColumnSortMode.NotSortable
        TablaDgv.Columns("Función").SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub

    Private Sub Limpiar()
        NombreTxt.Text = ""
        AniosCmb.Text = "Años"
        DireccionTxt.Text = ""
        TelefonoTxt.Text = ""
        Profesion_EstudiosTxt.Text = ""
        FuncionTxt.Text = ""
        FechaDtp.Text = Now.ToShortDateString
        FemeninoRdb.Checked = False
        MasculinoRdb.Checked = False
        BDcadena = "SELECT `Nombre`,`Edad`,`Dirección`,`Teléfono`,`Género`,`Profesión o estudios`,`Fecha de ingreso`,`Función` FROM sisviam.miembro_voluntario;"
        TablaDgv.DataSource = ObtenerTabla()
    End Sub

    Private Sub GuardarBtn_Click(sender As Object, e As EventArgs) Handles GuardarBtn.Click
        Ingresar_Miembro_Voluntario()
        Limpiar()
    End Sub

    Private Sub ModificarBtn_Click(sender As Object, e As EventArgs) Handles ModificarBtn.Click
        Modificar_Miembro_Voluntario()
        Limpiar()
    End Sub
End Class