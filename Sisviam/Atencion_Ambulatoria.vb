Public Class Atencion_Ambulatoria

    Public Function Ingresar_Atencion_Ambulatoria()

    End Function

    Public Function Modificar_Atencion_Ambulatoria()

    End Function

    Dim lista As ListViewItem

    Private Sub Listar()
        'Listar todos los elementos de la base de datos
        lista = New ListViewItem(New String() {})
        ListView1.Items.AddRange(New ListViewItem() {lista})
    End Sub

    Private Sub Limpiar()
        CanCmb.Text = "Seleccione Can"
        ResponsableCmb.Text = "Seleccione Responsable"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Can.Dispose()
        Can.MdiParent = Me.ParentForm
        Can.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Persona.Dispose()
        Persona.MdiParent = Me.ParentForm
        Persona.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Ingresar_Atencion_Ambulatoria()
        Listar()
        Limpiar()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Modificar_Atencion_Ambulatoria()
        Listar()
        Limpiar()
    End Sub

    Private Sub Atencion_Ambulatoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Listar()
    End Sub
End Class