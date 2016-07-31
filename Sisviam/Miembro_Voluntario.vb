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
        'Se obtiene un numero aleatorio para asignar?
        Dim val As Integer = 1
        Return val
    End Function

    Public Function Modificar_Miembro_Voluntario()
        'Actualiza base de datos objeto Me
    End Function

    Dim lista As ListViewItem

    Private Sub Listar()
        'Listar todos los elementos de la base de datos
        lista = New ListViewItem(New String() {nombre, CStr(edad), direccion, telefono, sexo, profesion_estudios, CStr(fecha_ingreso), funcion})
        ListView1.Items.AddRange(New ListViewItem() {lista})
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
    End Sub

    Private Sub Miembro_Voluntario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        id_mv = 0
        nombre = ""
        edad = 0
        direccion = ""
        telefono = ""
        sexo = ""
        profesion_estudios = ""
        fecha_ingreso = Now.ToShortDateString
        funcion = ""
        Listar()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Ingresar_Miembro_Voluntario()
        Listar()
        Limpiar()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Modificar_Miembro_Voluntario()
        Listar()
        Limpiar()
    End Sub
End Class