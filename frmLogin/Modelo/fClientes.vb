Imports System.Data.SqlClient

Public Class fClientes
    Inherits Conexiones
    Dim comandosql As SqlCommand

    Public Function Mostrar() As DataTable

        Try
            conectar()
            comandosql = New SqlCommand("sp_sCliente")
            comandosql.CommandType = CommandType.StoredProcedure
            comandosql.Connection = miconexion
            If comandosql.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim adaptador As New SqlDataAdapter(comandosql)
                adaptador.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If

        Catch ex As Exception
            MsgBox("Ha ocurrido un error al extraer los datos, contacte al administrador del sistema ==> " & ex.Message, MsgBoxStyle.Critical, "problemas de conexion")
            Return Nothing
        Finally
            Desconectar()

        End Try
    End Function

    Public Function Modificar(dt As eClientes) As Boolean
        Try
            conectar()
            comandosql = New SqlCommand("sp_uCliente")
            comandosql.CommandType = CommandType.StoredProcedure
            comandosql.Connection = miconexion
            comandosql.Parameters.AddWithValue("cli_Id", dt.Cli_Id)
            comandosql.Parameters.AddWithValue("cli_Nombre", dt.Cli_Nombre)
            comandosql.Parameters.AddWithValue("cli_Apellido", dt.Cli_Apellido)
            comandosql.Parameters.AddWithValue("cli_DireccionT", dt.Cli_DireccionT)
            comandosql.Parameters.AddWithValue("cli_DireccionC", dt.Cli_DireccionC)
            comandosql.Parameters.AddWithValue("cli_Telefono", dt.Cli_Telefono)
            comandosql.Parameters.AddWithValue("cli_Celular", dt.Cli_Celular)
            comandosql.Parameters.AddWithValue("cli_Correo", dt.Cli_Correo)
            If comandosql.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox("Ha ocurrido un problema al actualizar los datos :| ==>  ", ex.Message)
            Return False
        Finally
            Desconectar()

        End Try
    End Function


    Public Function Eliminar(dt As eClientes) As Boolean
        Try
            conectar()
            comandosql = New SqlCommand("sp_dCliente")
            comandosql.CommandType = CommandType.StoredProcedure
            comandosql.Connection = miconexion
            comandosql.Parameters.AddWithValue("Cli_Id", dt.Cli_Id)
            If comandosql.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox("Ha ocurrido un problema al Eliminar los datos :| ==>  ", ex.Message)
            Return False
        Finally
            Desconectar()

        End Try

    End Function

    Public Function InsertarDatos(dt As eClientes) As Boolean
        Try
            conectar()
            comandosql = New SqlCommand("sp_iCliente")
            comandosql.CommandType = CommandType.StoredProcedure
            comandosql.Connection = miconexion
            comandosql.Parameters.AddWithValue("cli_Nombre", dt.Cli_Nombre)
            comandosql.Parameters.AddWithValue("cli_Apellido", dt.Cli_Apellido)
            comandosql.Parameters.AddWithValue("cli_DireccionT", dt.Cli_DireccionT)
            comandosql.Parameters.AddWithValue("cli_DireccionC", dt.Cli_DireccionC)
            comandosql.Parameters.AddWithValue("cli_Telefono", dt.Cli_Telefono)
            comandosql.Parameters.AddWithValue("cli_Celular", dt.Cli_Celular)
            comandosql.Parameters.AddWithValue("cli_Correo", dt.Cli_Correo)
            If comandosql.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox("Ha ocurrido un problema al Insertar los datos :| ==> " & ex.Message)
            Return False
        Finally
            Desconectar()
        End Try

    End Function


    Public Function EliminaVarios(ByRef dgv As DataGridView) As Integer
        Try
            conectar()
            Dim n As Integer = 0
            comandosql = New SqlCommand("sp_dCliente")
            comandosql.CommandType = CommandType.StoredProcedure
            comandosql.Connection = miconexion
            For Each row As DataGridViewRow In dgv.SelectedRows
                Dim cli_Id As Object = row.Cells(0).Value
                comandosql.Parameters.Clear()
                comandosql.Parameters.AddWithValue("cli_Id", cli_Id)
                Dim resultado As Integer = comandosql.ExecuteNonQuery()
                n += resultado
            Next
            Return n

        Catch ex As Exception
            MsgBox("No se pudieron eliminar los registros , verifique e intentelo de nuevo  (ldc128) ==>  " & ex.Message)
            Return 0
        Finally
            Desconectar()
        End Try
    End Function

End Class
