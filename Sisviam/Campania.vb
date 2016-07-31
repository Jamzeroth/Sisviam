Public Class Campania
    Private lugar As String
    Private direccion As String
    Private fecha As Date
    Private numero_atenciones As Integer

    Public Function Ingresar_Campania()
        lugar = LugarTxt.Text
        direccion = DireccionTxt.Text
        numero_atenciones = NatencionesTxt.Text
        fecha = FechaDtp.Text
    End Function

    Public Function Modificar_Campania()
        'Actualizar base de datos Objeto Me
    End Function

    Dim lista As ListViewItem

    Private Sub Listar()
        'Listar todos los elementos de la base de datos
        lista = New ListViewItem(New String() {lugar, direccion, CStr(fecha), CStr(numero_atenciones)})
        ListView1.Items.AddRange(New ListViewItem() {lista})
    End Sub

    Private Sub Limpiar()
        LugarTxt.Text = ""
        DireccionTxt.Text = ""
        NatencionesTxt.Text = ""
        FechaDtp.Text = Now.ToShortDateString
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Ingresar_Campania()
        Listar()
        Limpiar()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Modificar_Campania()
        Listar()
        Limpiar()
    End Sub

    Private Sub Campania_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lugar = ""
        direccion = ""
        fecha = Now.ToShortDateString
        numero_atenciones = 0
        Listar()
    End Sub
End Class