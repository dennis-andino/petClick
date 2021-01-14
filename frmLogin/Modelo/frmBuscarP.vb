Imports System.Data.SqlClient

Public Class frmBuscarP
    Inherits Conexiones
    Dim comandosql As SqlCommand

    Public Function Mostrar() As DataTable

        Try
            conectar()
            comandosql = New SqlCommand("sp_sPacienteCliente")
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

    Public Function MostrarMedicos() As DataTable

        Try
            conectar()
            comandosql = New SqlCommand("sp_sVeterinarioEspecialidad")
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
End Class
