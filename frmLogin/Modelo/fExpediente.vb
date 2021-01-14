Imports System.Data.SqlClient

Public Class fExpediente
    Inherits Conexiones
    Dim comandoSQL As SqlCommand

    Public Function MostrarEx() As DataTable
        Try
            conectar()
            comandoSQL = New SqlCommand("sp_sMascota")
            comandoSQL.CommandType = CommandType.StoredProcedure
            comandoSQl.Connection = miconexion
            If comandoSQl.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim adaptador As New SqlDataAdapter(comandoSQl)
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

    Public Function InsertarDatosEX(dt As eExpediente) As Boolean
        Try
            conectar()
            comandoSQL = New SqlCommand("sp_iMascota")
            comandoSQL.CommandType = CommandType.StoredProcedure
            comandoSQL.Connection = miconexion
            comandoSQL.Parameters.AddWithValue("Mas_DuenhoID", dt.Mas_DuenhoID)
            comandoSQL.Parameters.AddWithValue("Mas_Nombre", dt.Mas_Nombre)
            comandoSQL.Parameters.AddWithValue("Mas_Sexo", dt.Mas_Sexo)
            comandoSQL.Parameters.AddWithValue("Mas_EspecieId", dt.Mas_EspecieId)
            comandoSQL.Parameters.AddWithValue("Mas_EspecieTipoId", dt.Mas_EspecieTipoId)
            comandoSQL.Parameters.AddWithValue("Mas_FechaNac", dt.Mas_FechaNac)
            comandoSQL.Parameters.AddWithValue("Mas_TipoSangre", dt.Mas_TipoSangre)
            comandoSQL.Parameters.AddWithValue("Mas_Color", dt.Mas_Color)
            comandoSQL.Parameters.AddWithValue("Mas_Habitat", dt.Mas_Habitat)
            comandoSQL.Parameters.AddWithValue("Mas_Peso", dt.Mas_Peso)
            comandoSQL.Parameters.AddWithValue("Mas_Otros", dt.Mas_Otros)
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

    Public Function ModificarEx(ByRef dt As eExpediente) As Boolean
        Try
            conectar()
            comandoSQL = New SqlCommand("sp_uMascota")
            comandoSQL.CommandType = CommandType.StoredProcedure
            comandoSQL.Connection = miconexion
            comandoSQL.Parameters.AddWithValue("mas_Id", dt.Mas_Id)
            comandoSQL.Parameters.AddWithValue("mas_Nombre", dt.Mas_Nombre)
            comandoSQL.Parameters.AddWithValue("mas_Sexo", dt.Mas_Sexo)
            comandoSQL.Parameters.AddWithValue("mas_EspecieId", dt.Mas_EspecieId)
            comandoSQL.Parameters.AddWithValue("mas_EspecieTipoId", dt.Mas_EspecieTipoId)
            comandoSQL.Parameters.AddWithValue("mas_FechaNac", dt.Mas_FechaNac)
            comandoSQL.Parameters.AddWithValue("mas_TipoSangre", dt.Mas_TipoSangre)
            comandoSQL.Parameters.AddWithValue("mas_Color", dt.Mas_Color)
            comandoSQL.Parameters.AddWithValue("mas_Habitat", dt.Mas_Habitat)
            comandoSQL.Parameters.AddWithValue("mas_Peso", dt.Mas_Peso)
            comandoSQL.Parameters.AddWithValue("mas_Otros", dt.Mas_Otros)
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

    Public Function EliminarEx(ByRef dgv As DataGridView) As Integer
        Try
            conectar()
            Dim n As Integer = 0
            comandoSQL = New SqlCommand("sp_dMascota")
            comandoSQL.CommandType = CommandType.StoredProcedure
            comandoSQL.Connection = miconexion
            For Each row As DataGridViewRow In dgv.SelectedRows
                Dim mas_Id As Object = row.Cells(0).Value
                comandoSQL.Parameters.Clear()
                comandoSQL.Parameters.AddWithValue("mas_Id", mas_Id)
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



    Public Function getFamilia() As DataSet
        Try
            conectar()
            comandoSQL = New SqlCommand("sp_sEspecie")
            comandoSQL.CommandType = CommandType.StoredProcedure
            comandoSQL.Connection = miconexion
            If comandoSQL.ExecuteNonQuery Then
                Dim adapter As New SqlDataAdapter(comandoSQL)
                Dim data As New DataSet
                adapter.Fill(data)
                Return data
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al obtener los datos , verifique la conexio al servidor o comuniquese con el administrador. ldc46==> " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        Finally
            Desconectar()
        End Try
    End Function

    Public Function getRaza(especie As Int16) As DataSet
        Try
            conectar()
            comandoSQL = New SqlCommand("sp_srazaPorEspecie")
            comandoSQL.CommandType = CommandType.StoredProcedure
            comandoSQL.Connection = miconexion
            comandoSQL.Parameters.AddWithValue("especieId", especie)
            If comandoSQL.ExecuteNonQuery Then
                Dim adapter As New SqlDataAdapter(comandoSQL)
                Dim data As New DataSet
                adapter.Fill(data)
                Return data
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al obtener los datos , verifique la conexio al servidor o comuniquese con el administrador. ldc46==> " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        Finally
            Desconectar()
        End Try
    End Function
End Class
