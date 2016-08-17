Public Class Persona
    Private id_persona As Integer
    Private nombre As String
    Private direccion As String
    Private telefono As String

    Public Function Ingresar_Persona()
        nombre = NombreTxt.Text
        direccion = DireccionTxt.Text
        telefono = TelefonoTxt.Text
        id_persona = Asignar_id_Persona()
        BDcadena = "INSERT INTO `sisviam`.`persona` (`id_persona`, `Nombre`, `Dirección`, `Teléfono`) VALUES ('" + CStr(id_persona) + "', '" + nombre + "', '" + direccion + "', '" + telefono + "');"
        Almacenar_Datos()
    End Function

    Public Function Asignar_id_Persona() As Integer
        BDcadena = "SELECT id_persona FROM sisviam.persona;"
        Return AsignarId("id_persona")
    End Function

    Public Function Modificar_Persona()
        Dim y As Integer = CInt(TablaDgv.SelectedCells(0).RowIndex) 'filas
        Dim x As Integer = CInt(TablaDgv.SelectedCells(0).ColumnIndex) 'columnas
        Dim atributo As String = ""
        'MsgBox("x " + CStr(x) + vbNewLine + "y " + CStr(y))
        Select Case (x)
            Case 0
                atributo = "Nombre"
            Case 1
                atributo = "Dirección"
            Case 2
                atributo = "Teléfono"
        End Select
        Dim nuevo As String = InputBox("Ingrese un nuevo dato para: " + atributo, "Modificar", CStr(TablaDgv.SelectedCells(0).Value))
        BDcadena = "UPDATE `sisviam`.`persona` SET `" + atributo + "`='" + nuevo + "' WHERE `id_persona`='" + CStr(y) + "';"
        Actualizar_Datos()
    End Function

    Private Sub Persona_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nombre = ""
        direccion = ""
        telefono = ""
        Limpiar()
        TablaDgv.Columns("Nombre").SortMode = DataGridViewColumnSortMode.NotSortable
        TablaDgv.Columns("Dirección").SortMode = DataGridViewColumnSortMode.NotSortable
        TablaDgv.Columns("Teléfono").SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub

    Public Sub Limpiar()
        NombreTxt.Text = ""
        DireccionTxt.Text = ""
        TelefonoTxt.Text = ""
        BDcadena = "SELECT Nombre,Dirección,Teléfono FROM sisviam.persona;"
        TablaDgv.DataSource = ObtenerTabla()
    End Sub

    Private Sub ModificarBtn_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ModificarBtn.Click
        Modificar_Persona()
        Limpiar()
    End Sub

    Private Sub GuardarBtn_Click(sender As Object, e As EventArgs) Handles GuardarBtn.Click
        Ingresar_Persona()
        Limpiar()
    End Sub
End Class