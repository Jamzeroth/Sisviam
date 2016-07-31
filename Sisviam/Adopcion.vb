Public Class Adopcion
    Private id_mv As Integer
    Private id_can As Integer
    Private id_persona As Integer
    Private fecha_entrega As Date
    Private seguimiento As Integer

    Public Function Ingresar_Adopcion()

    End Function

    Public Function Modificar_Adopcion()

    End Function

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

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub
End Class