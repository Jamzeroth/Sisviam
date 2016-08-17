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
        id_mv = Asignar_id_Miembro_Voluntario()
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
        'Enviar a la base de datos objeto Me
    End Function

    Public Function Asignar_id_Miembro_Voluntario() As Integer
        BDcadena = "SELECT id_mv FROM sisviam.persona;"
        Return AsignarId("id_mv")
    End Function

    Public Function Modificar_Miembro_Voluntario()
        'Actualiza base de datos objeto Me
    End Function

    Dim lista As ListViewItem

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
        BDcadena = "SELECT 'Nombre','Dirección','Teléfono','Género','Profesión o estudios','Fecha de ingreso','Función' FROM sisviam.persona;"
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