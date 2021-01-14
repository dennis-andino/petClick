Imports System.Data.SqlClient

Public Class fFarmacias
    Inherits Conexiones
    Dim comandoSQL As SqlCommand


    Public Function MostrarFarmacia() As DataTable
        Try
            conectar()
            comandoSQL = New SqlCommand("sp_sFarmacias")
            comandoSQL.CommandType = CommandType.StoredProcedure
            comandoSQL.Connection = miconexion
            If comandoSQL.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim adaptador As New SqlDataAdapter(comandoSQL)
                adaptador.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If

        Catch ex As Exception
            MsgBox("Ha ocurrido un error al extraer los datos, contacte al administrador del sistema ==> lnc23" & ex.Message, MsgBoxStyle.Critical, "problemas de conexion")
            Return Nothing
        Finally
            Desconectar()

        End Try
    End Function

    Public Function InsertarFarmacia(dt As eFarmacias) As Boolean
        Try
            conectar()
            comandoSQL = New SqlCommand("sp_iFarmacias")
            comandoSQL.CommandType = CommandType.StoredProcedure
            comandoSQL.Connection = miconexion
            comandoSQL.Parameters.AddWithValue("Far_Nombre", dt.Far_Nombre)
            comandoSQL.Parameters.AddWithValue("Far_Direccion", dt.Far_Direccion)
            If comandoSQL.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al insertar los datos , verifique la conexio al servidor o comuniquese con el administrador. ldc54==> " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            Desconectar()
        End Try

    End Function

    Public Function ModificarFarmacia(ByRef dt As eFarmacias) As Boolean
        Try
            conectar()
            comandoSQL = New SqlCommand("sp_uFarmacias")
            comandoSQL.CommandType = CommandType.StoredProcedure
            comandoSQL.Connection = miconexion
            comandoSQL.Parameters.AddWithValue("Far_Id", dt.Far_Id)
            comandoSQL.Parameters.AddWithValue("Far_Nombre", dt.Far_Nombre)
            comandoSQL.Parameters.AddWithValue("Far_Direccion", dt.Far_Direccion)
            If comandoSQL.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al insertar los datos , verifique la conexion al servidor o comuniquese con el administrador. ldc103==> " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            Desconectar()

        End Try
    End Function

    Public Function EliminarFa(ByRef dgv As DataGridView) As Integer
        Try
            conectar()
            Dim n As Integer = 0
            comandoSQL = New SqlCommand("sp_dFarmacias")
            comandoSQL.CommandType = CommandType.StoredProcedure
            comandoSQL.Connection = miconexion
            For Each row As DataGridViewRow In dgv.SelectedRows
                Dim far_Id As Object = row.Cells(0).Value
                comandoSQL.Parameters.Clear()
                comandoSQL.Parameters.AddWithValue("far_Id", far_Id)
                Dim result As Integer = comandoSQL.ExecuteNonQuery()
                n += result
            Next
            Return n
        Catch ex As Exception
            MessageBox.Show("No se pudo Eliminar el/los Registros seleccionados, contacte con el administrador.   (ldc127) ==> " & ex.Message, "Error al Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return 0
        Finally
            Desconectar()
        End Try
    End Function





End Class
