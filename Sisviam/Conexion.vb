Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient

Module Conexion
    Public _cadena As String
    Public _conexion As MySqlConnection

    Public Function conexion_global() As Boolean
        Dim _estado As Boolean = True
        Try
            _cadena = ("server=localhost; database=sisviam; user id=JAM; password=")
            _conexion = New MySqlConnection(_cadena)
            _conexion.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            _estado = False
        End Try
        Return _estado
    End Function
    Public Sub cerrar()
        _conexion.Close()
    End Sub

End Module
