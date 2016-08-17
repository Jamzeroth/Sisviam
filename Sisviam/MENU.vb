﻿Public Class MENU

    Private Sub CanesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CanesToolStripMenuItem.Click
        Can.Dispose()
        Can.MdiParent = Me
        Can.Show()
    End Sub

    Private Sub AdopcionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdopcionesToolStripMenuItem.Click
        Adopcion.MdiParent = Me
        Adopcion.Show()
    End Sub

    Private Sub AtencionesAmbulatoriosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AtencionesAmbulatoriosToolStripMenuItem.Click
        Atencion_Ambulatoria.MdiParent = Me
        Atencion_Ambulatoria.Show()
    End Sub

    Private Sub MiembrosYVoluntariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MiembrosYVoluntariosToolStripMenuItem.Click
        Miembro_Voluntario.MdiParent = Me
        Miembro_Voluntario.Show()
    End Sub

    Private Sub CampañasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CampañasToolStripMenuItem.Click
        Campania.MdiParent = Me
        Campania.Show()
    End Sub

    Private Sub MENU_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ctl As Control
        Dim ctlMDI As MdiClient
        For Each ctl In Me.Controls
            Try
                ctlMDI = CType(ctl, MdiClient)
                ctlMDI.BackColor = Me.BackColor
            Catch exc As InvalidCastException
            End Try
        Next
        If Conectar() Then MsgBox("No se Puede Acceder a la Base de Datos")
        BDcadena = ""
    End Sub

    Private Sub PersonaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PersonaToolStripMenuItem.Click
        Persona.MdiParent = Me
        Persona.Show()
    End Sub

    Private Sub MENU_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Desconectar()
    End Sub
End Class
