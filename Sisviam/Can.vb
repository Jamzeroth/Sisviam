Public Class Can
    Private id_can As Integer
    Private nombre As String
    Private raza As String
    Private color As String
    Private sexo As String
    Private edad As String
    Private peso As Decimal
    Private fecha_ingreso As Date
    Private observacion As String

    Private Sub Ingresar_Can(sender As Object, e As EventArgs) Handles GuardarBtn.Click
        If (HembraRdb.Checked) Or (MachoRdb.Checked) Then
            BDcadena = "SELECT id_can FROM sisviam.can;"
            id_can = AsignarId("id_can")
            nombre = NombreTxt.Text
            raza = RazaTxt.Text
            If (HembraRdb.Checked) Then sexo = HembraRdb.Text Else sexo = MachoRdb.Text
            color = ColorTxt.Text
            If (AniosCmb.Text <> "Años") And (AniosCmb.Text <> "0") Then
                edad = CStr(AniosCmb.Text)
                If (AniosCmb.Text = "1") Then edad += " Año " Else edad += " Años "
            End If
            If (MesesCmb.Text <> "Meses") And (MesesCmb.Text <> "0") Then
                edad += CStr(MesesCmb.Text)
                If (MesesCmb.Text = "1") Then edad += " Mes" Else edad += " Meses"
            End If
            fecha_ingreso = CDate(FechaDtp.Text)
            observacion = ObservacionTxt.Text
            PesoTxt.Text = Replace(PesoTxt.Text, ".", ",")
            Try
                peso = CDec(PesoTxt.Text)
                BDcadena = "INSERT INTO `sisviam`.`can` (`id_can`,`Nombre del can`,`Raza`,`Color`,`Sexo`,`Peso (kg)`,`Observación`,`Edad`,`Fecha de ingreso`) VALUES ('" + CStr(id_can) + "', '" + nombre + "','" + raza + "', '" + color + "', '" + sexo + "','" + CStr(peso) + "','" + observacion + "','" + edad + "','" + CStr(fecha_ingreso) + "');"
                Almacenar_Datos()
                Limpiar()
            Catch ex As Exception
                MsgBox("Dato de peso mal ingresado")
            End Try
        Else
            MsgBox("Aún no selecciona un sexo")
        End If
    End Sub

    Private Sub Modificar_can(sender As Object, e As EventArgs) Handles ModificarBtn.Click
        Dim y As Integer = CInt(TablaDgv.SelectedCells(0).RowIndex) 'filas
        Dim x As Integer = CInt(TablaDgv.SelectedCells(0).ColumnIndex) 'columnas
        Dim atributo As String = ""
        Select Case (x)
            Case 0
                atributo = "Nombre del can"
            Case 1
                atributo = "Raza"
            Case 2
                atributo = "Sexo"
            Case 3
                atributo = "Color"
            Case 4
                atributo = "Edad"
            Case 5
                atributo = "Peso (kg)"
            Case 6
                atributo = "Fecha de ingreso"
            Case 7
                atributo = "Observación"
        End Select
        Dim nuevo As String = InputBox("Ingrese un nuevo dato para: " + atributo, "Modificar", CStr(TablaDgv.SelectedCells(0).Value))
        BDcadena = "UPDATE `sisviam`.`can` SET `" + atributo + "`='" + nuevo + "' WHERE `id_can`='" + CStr(y) + "';"
        If (nuevo <> "") Then Actualizar_Datos()
        Limpiar()
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
        id_can = 0
        nombre = ""
        edad = ""
        raza = ""
        color = ""
        sexo = ""
        peso = 0
        fecha_ingreso = Now.ToShortDateString
        observacion = ""
        BDcadena = "SELECT `Nombre del can`,`Raza`,`Sexo`,`Color`,`Edad`,`Peso (kg)`,`Fecha de ingreso`,`Observación` FROM sisviam.can;"
        TablaDgv.DataSource = ObtenerTabla()
    End Sub

    Private Sub Can_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Limpiar()
        TablaDgv.Columns("Nombre del can").SortMode = DataGridViewColumnSortMode.NotSortable
        TablaDgv.Columns("Raza").SortMode = DataGridViewColumnSortMode.NotSortable
        TablaDgv.Columns("Color").SortMode = DataGridViewColumnSortMode.NotSortable
        TablaDgv.Columns("Sexo").SortMode = DataGridViewColumnSortMode.NotSortable
        TablaDgv.Columns("Peso (kg)").SortMode = DataGridViewColumnSortMode.NotSortable
        TablaDgv.Columns("Observación").SortMode = DataGridViewColumnSortMode.NotSortable
        TablaDgv.Columns("Edad").SortMode = DataGridViewColumnSortMode.NotSortable
        TablaDgv.Columns("Fecha de ingreso").SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub
End Class