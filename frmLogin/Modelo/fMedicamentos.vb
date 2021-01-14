Imports System.Data.SqlClient

Public Class fMedicamentos
    Inherits Conexiones
    Dim comandoSQL As SqlCommand


    Public Function MostrarMed() As DataTable
        Try
            conectar()
            comandoSQL = New SqlCommand("sp_sMedicamentos")
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
            MsgBox("Ha ocurrido un error al extraer los datos, contacte al administrador del sistema ==> lnc24" & ex.Message, MsgBoxStyle.Critical, "problemas de conexion")
            Return Nothing
        Finally
            Desconectar()

        End Try
    End Function

    Public Function InsertarDatosmed(ByRef dt As eMedicamentos) As Boolean
        Try
            conectar()
            comandoSQL = New SqlCommand("sp_iMedicamentos")
            comandoSQL.CommandType = CommandType.StoredProcedure
            comandoSQL.Connection = miconexion
            comandoSQL.Parameters.AddWithValue("Med_Nombre", dt.Med_Nombre1)
            comandoSQL.Parameters.AddWithValue("Med_Descripcion", dt.Med_Descripcion1)
            comandoSQL.Parameters.AddWithValue("Med_Costo", dt.Med_Costo1)
            comandoSQL.Parameters.AddWithValue("Med_Enfermedad", dt.Med_Enfermedad1)
            comandoSQL.Parameters.AddWithValue("Med_proveedor", dt.Med_proveedor1)

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

    Public Function ModificarMed(ByRef dt As eMedicamentos) As Boolean
        Try
            conectar()
            comandoSQL = New SqlCommand("sp_uMedicametos")
            comandoSQL.CommandType = CommandType.StoredProcedure
            comandoSQL.Connection = miconexion
            comandoSQL.Parameters.AddWithValue("mas_Id", dt.Med_Id1)
            comandoSQL.Parameters.AddWithValue("Med_Nombre1", dt.Med_Nombre1)
            comandoSQL.Parameters.AddWithValue("Med_Descripcion1", dt.Med_Descripcion1)
            comandoSQL.Parameters.AddWithValue("Med_Costo1", dt.Med_Costo1)
            comandoSQL.Parameters.AddWithValue("Med_Enfermedad1", dt.Med_Enfermedad1)
            comandoSQL.Parameters.AddWithValue("Med_proveedor1", dt.Med_proveedor1)
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

    Public Function EliminarMeds(ByRef dgv As DataGridView) As Integer
        Try
            conectar()
            Dim n As Integer = 0
            comandoSQL = New SqlCommand("sp_dMedicamentos")
            comandoSQL.CommandType = CommandType.StoredProcedure
            comandoSQL.Connection = miconexion
            For Each row As DataGridViewRow In dgv.SelectedRows
                Dim med_Id As Object = row.Cells(0).Value
                comandoSQL.Parameters.Clear()
                comandoSQL.Parameters.AddWithValue("med_Id", med_Id)
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



    Public Function getFarmacias() As DataSet
        Try
            conectar()
            comandoSQL = New SqlCommand("sp_sFarmaciab")
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

    Public Function getEnfermedades() As DataSet
        Try
            conectar()
            comandoSQL = New SqlCommand("sp_sEnfermedadesBasico")
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
End Class
