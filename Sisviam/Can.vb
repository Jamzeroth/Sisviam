Public Class Can
    Private id_can As Integer
    Private nombre As String
    Private raza As String
    Private color As String
    Private sexo As String
    Private edad As Integer
    Private peso As Double
    Private fecha_ingreso As Date
    Private observacion As String

    Public Function Ingresar_Can()
        id_can = Asignar_id_can()
        nombre = NombreTxt.Text
        raza = RazaTxt.Text
        color = ColorTxt.Text
        observacion = ObservacionTxt.Text
        If (PesoTxt.Text = "") Then peso = 0 Else peso = CDbl(PesoTxt.Text) 'Se debe poder ingresar con coma o punto
        If (HembraRdb.Checked) Then
            sexo = HembraRdb.Text
        ElseIf (MachoRdb.Checked) Then
            sexo = MachoRdb.Text
        Else
            MsgBox("Aún no selecciona un sexo")
        End If
        If (AniosCmb.Text = "Años") Then edad = 0 Else edad = 12 * CInt(AniosCmb.Text)
        If (MesesCmb.Text = "Meses") Then edad += 0 Else edad += CInt(MesesCmb.Text)
        fecha_ingreso = CDate(FechaDtp.Text)
        BDcadena = "INSERT INTO `sisviam`.`can` (`id_can`,`Nombre`,`Raza`,`Color`,`Sexo`,`Peso`,`Observación`,`Edad`,`Fecha de ingreso`) VALUES ('" + CStr(id_can) + "', '" + nombre + "','" + raza + "', '" + color + "', '" + sexo + "','" + CStr(peso) + "','" + observacion + "','" + CStr(edad) + "','" + CStr(fecha_ingreso) + "');"
        Almacenar_Datos()
    End Function

    Public Function Asignar_id_can() As Integer
        BDcadena = "SELECT id_can FROM sisviam.can;"
        Return AsignarId("id_can")
    End Function

    Public Function Modificar_Can()
        Dim y As Integer = CInt(TablaDgv.SelectedCells(0).RowIndex) 'filas
        Dim x As Integer = CInt(TablaDgv.SelectedCells(0).ColumnIndex) 'columnas
        Dim atributo As String = ""
        Select Case (x)
            Case 0
                atributo = "Nombre"
            Case 1
                atributo = "Raza"
            Case 2
                atributo = "Color"
            Case 3
                atributo = "Sexo"
            Case 4
                atributo = "Peso"
            Case 5
                atributo = "Observación"
            Case 6
                atributo = "Edad"
            Case 7
                atributo = "Fecha de ingreso"
        End Select
        Dim nuevo As String = InputBox("Ingrese un nuevo dato para: " + atributo, "Modificar", CStr(TablaDgv.SelectedCells(0).Value))
        BDcadena = "UPDATE `sisviam`.`can` SET `" + atributo + "`='" + nuevo + "' WHERE `id_can`='" + CStr(y) + "';"
        Actualizar_Datos()
    End Function

    Private Sub Can_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        id_can = 0
        nombre = ""
        edad = 0
        raza = ""
        color = ""
        sexo = ""
        peso = 0
        fecha_ingreso = Now.ToShortDateString
        observacion = ""
        Limpiar()
        TablaDgv.Columns("Nombre").SortMode = DataGridViewColumnSortMode.NotSortable
        TablaDgv.Columns("Raza").SortMode = DataGridViewColumnSortMode.NotSortable
        TablaDgv.Columns("Color").SortMode = DataGridViewColumnSortMode.NotSortable
        TablaDgv.Columns("Sexo").SortMode = DataGridViewColumnSortMode.NotSortable
        TablaDgv.Columns("Peso").SortMode = DataGridViewColumnSortMode.NotSortable
        TablaDgv.Columns("Observación").SortMode = DataGridViewColumnSortMode.NotSortable
        TablaDgv.Columns("Edad").SortMode = DataGridViewColumnSortMode.NotSortable
        TablaDgv.Columns("Fecha de ingreso").SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub

    Private Sub Limpiar()
        NombreTxt.Text = ""
        RazaTxt.Text = ""
        AniosCmb.Text = "Años"
        ColorTxt.Text = ""
        PesoTxt.Text = ""
        MesesCmb.Text = "Meses"
        ObservacionTxt.Text = ""
        FechaDtp.Text = Now.ToShortDateString
        HembraRdb.Checked = False
        MachoRdb.Checked = False
        BDcadena = "SELECT `Nombre`,`Raza`,`Color`,`Sexo`,`Peso`,`Observación`,`Edad`,`Fecha de ingreso` FROM sisviam.can;"
        TablaDgv.DataSource = ObtenerTabla()
    End Sub

    Private Sub GuardarBtn_Click_1(sender As Object, e As EventArgs) Handles GuardarBtn.Click
        Ingresar_Can()
        Limpiar()
    End Sub

    Private Sub ModificarBtn_Click(sender As Object, e As EventArgs) Handles ModificarBtn.Click
        Modificar_Can()
        Limpiar()
    End Sub
End Class