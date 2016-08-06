Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient

Module Base_Datos
    Public BDcadena As String = "server=localhost; database=sisviam; user id=JAM; password=Sisviam2016"
    Public BDconexion As New MySqlConnection(BDcadena)

    Public Function Conectar() As Boolean
        Try
            BDconexion.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return False
        End Try
        Return True
    End Function

    Public Function BuscarID(ByVal columna As String) As Integer
        Dim Da As New MySql.Data.MySqlClient.MySqlDataAdapter(BDcadena, BDconexion)
        Dim Ds As New DataSet
        Da.Fill(Ds, "ID")
        Dim Ot As DataTable
        Ot = Ds.Tables("ID")
        Dim Ofil As DataRow
        Dim cont As Integer = 1
        For Each Ofil In Ot.Rows
            If (cont = CInt(Ofil.Item(columna))) Then
                cont += 1
            Else
                Return cont
            End If
        Next
        Return cont
    End Function

    Public Sub Cerrar()
        BDconexion.Close()
    End Sub
End Module
