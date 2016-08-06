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
        MsgBox(nombre + vbNewLine + direccion + vbNewLine + telefono + vbNewLine + CStr(id_persona))
        'Enviar a la base de datos

    End Function

    Public Function Asignar_id_Persona() As Integer
        BDcadena = "SELECT id_persona FROM sisviam.persona;"
        Return BuscarID("id_persona")
    End Function

    Public Function Modificar_Persona()
        'Actualizar base de datos objeto Me
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Ingresar_Persona()
        Dispose()
    End Sub

    Private Sub Persona_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nombre = ""
        direccion = ""
        telefono = ""
    End Sub
End Class