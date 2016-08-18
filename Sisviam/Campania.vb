Public Class Campania
    Private id_camp As Integer
    Private lugar As String
    Private direccion As String
    Private fecha As Date
    Private numero_atenciones As Integer

    Public Function Ingresar_Campania()
        BDcadena = "SELECT id_camp FROM sisviam.campania;"
        id_camp = AsignarId("id_camp")
        lugar = LugarTxt.Text
        direccion = DireccionTxt.Text
        numero_atenciones = NatencionesTxt.Text
        fecha = FechaDtp.Text
        BDcadena = "INSERT INTO `sisviam`.`campania` (`id_camp`,`Lugar`,`Dirección`,`Fecha`,`Número de atenciones`) VALUES ('" + CStr(id_camp) + "', '" + lugar + "','" + direccion + "', '" + CStr(fecha) + "', '" + CStr(numero_atenciones) + "');"
        Almacenar_Datos()
    End Function

    Public Function Modificar_Campania()
        Dim y As Integer = CInt(TablaDgv.SelectedCells(0).RowIndex) 'filas
        Dim x As Integer = CInt(TablaDgv.SelectedCells(0).ColumnIndex) 'columnas
        Dim atributo As String = ""
        Select Case (x)
            Case 0
                atributo = "Lugar"
            Case 1
                atributo = "Dirección"
            Case 2
                atributo = "Fecha"
            Case 3
                atributo = "Número de atenciones"
        End Select
        Dim nuevo As String = InputBox("Ingrese un nuevo dato para: " + atributo, "Modificar", CStr(TablaDgv.SelectedCells(0).Value))
        BDcadena = "UPDATE `sisviam`.`campania` SET `" + atributo + "`='" + nuevo + "' WHERE `id_camp`='" + CStr(y) + "';"
        Actualizar_Datos()
    End Function

    Private Sub Campania_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lugar = ""
        direccion = ""
        fecha = Now.ToShortDateString
        numero_atenciones = 0
        Limpiar()
        TablaDgv.Columns("Lugar").SortMode = DataGridViewColumnSortMode.NotSortable
        TablaDgv.Columns("Dirección").SortMode = DataGridViewColumnSortMode.NotSortable
        TablaDgv.Columns("Fecha").SortMode = DataGridViewColumnSortMode.NotSortable
        TablaDgv.Columns("Número de atenciones").SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub

    Private Sub Limpiar()
        LugarTxt.Text = ""
        DireccionTxt.Text = ""
        NatencionesTxt.Text = ""
        FechaDtp.Text = Now.ToShortDateString
        BDcadena = "SELECT `Lugar`,`Dirección`,`Fecha`,`Número de atenciones` FROM sisviam.campania;"
        TablaDgv.DataSource = ObtenerTabla()
    End Sub

    Private Sub GuardarBtn_Click(sender As Object, e As EventArgs) Handles GuardarBtn.Click
        Ingresar_Campania()
        Limpiar()
    End Sub

    Private Sub ModificarBtn_Click(sender As Object, e As EventArgs) Handles ModificarBtn.Click
        Modificar_Campania()
        Limpiar()
    End Sub
End Class