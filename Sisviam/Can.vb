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
        'Manda a la base de datos objeto Me
        id_can = Asignar_id_Can()
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
    End Function

    Public Function Asignar_id_Can() As Integer
        'Se obtiene numero aleatorio para asignar
        Dim val As Integer = 1
        Return val
    End Function

    Public Function Modificar_Can()
        'Actualiza base de datos objeto Me
    End Function

    Dim lista As ListViewItem

    Private Sub Listar()
        'Listar todo los elementos de la base de datos
        lista = New ListViewItem(New String() {nombre, raza, color, sexo, CStr(peso), CStr(edad), CStr(fecha_ingreso), observacion})
        ListView1.Items.AddRange(New ListViewItem() {lista})
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
    End Sub

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
        Listar()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Ingresar_Can()
        Listar()
        Limpiar()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Modificar_Can()
        Listar()
        Limpiar()
    End Sub
End Class