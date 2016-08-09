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
        nombre = NombreTxt.Text
        direccion = DireccionTxt.Text
        telefono = TelefonoTxt.Text
        BDcadena = "UPDATE `sisviam`.`persona` SET `Nombre`='" + nombre + "', `Dirección`='" + direccion + "', `Teléfono`='" + telefono + "' WHERE `id_persona`='" + CStr(id_persona) + "';"
        Actualizar_Datos()
    End Function

    Public Function Limpiar()
        NombreTxt.Text = ""
        DireccionTxt.Text = ""
        TelefonoTxt.Text = ""
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Ingresar_Persona()
        BDcadena = "SELECT Nombre,Dirección,Teléfono FROM sisviam.persona;"
        DataGridView1.DataSource = ObtenerTabla()
        Limpiar()
    End Sub

    Private Sub Persona_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nombre = ""
        direccion = ""
        telefono = ""
        BDcadena = "SELECT Nombre,Dirección,Teléfono FROM sisviam.persona;"
        DataGridView1.DataSource = ObtenerTabla()
    End Sub
End Class