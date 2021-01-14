Imports System.Data.SqlClient

Public Class fUsuarios
    Inherits Conexiones
    Dim comandoSql As SqlCommand

    Public Function validarUsuario(ByVal credenciales As eUsuarios) As DataTable
        Try
            conectar()
            comandoSql = New SqlCommand("sp_LoginUsuarios")
            comandoSql.CommandType = CommandType.StoredProcedure
            comandoSql.Connection = miconexion
            comandoSql.Parameters.AddWithValue("@usu_Clave", credenciales.Usu_Clave)
            comandoSql.Parameters.AddWithValue("@usu_Nickname", credenciales.Usu_Nickname)
            If comandoSql.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(comandoSql)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("upss no pudimos verificar los datos, contacte al administrador del sistema")
            Return Nothing
        Finally
            Desconectar()
        End Try

    End Function





End Class
