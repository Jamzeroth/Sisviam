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
    End Function

    Public Function Asignar_id_Persona() As Integer
        'Devuelve un id para una persona
        Dim val As Integer = CInt(Rnd(10))
        Return val
    End Function

    Public Function Modificar_Persona()
        'Actualizar base de datos objeto Me
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Ingresar_Persona()
    End Sub
End Class