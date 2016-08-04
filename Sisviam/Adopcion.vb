Public Class Adopcion
    Private id_mv As Integer
    Private id_can As Integer
    Private id_persona As Integer
    Private fecha_entrega As Date
    Private seguimiento As Integer

    Public Function Ingresar_Adopcion()
        fecha_entrega = FechaDtp.Text
        seguimiento = SeguimientoDtp.Text
    End Function

    Public Function Modificar_Adopcion()

    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Can.Dispose()
        Can.MdiParent = Me.ParentForm
        Can.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Persona.Dispose()
        Persona.MdiParent = Me.ParentForm
        Persona.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub
End Class