Imports System.Data.SqlClient

Public Class fEnfermedades
    Inherits Conexiones
    Dim instruccionSQL As SqlCommand

    Public Function Mostrar() As DataTable
        Try
            conectar()
            instruccionSQL = New SqlCommand("sp_sEnfermedades")
            instruccionSQL.CommandType = CommandType.StoredProcedure
            instruccionSQL.Connection = miconexion
            If instruccionSQL.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim adaptador As New SqlDataAdapter(instruccionSQL)
                adaptador.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al extraer los datos, contacte al administrador del sistema ==> ldc23 " & ex.Message, "Sin Conexion a DB", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        Finally
            Desconectar()
        End Try
    End Function

    Public Function insertarData(ByRef dt As eEnfermedades) As Boolean
        Try
            conectar()
            instruccionSQL = New SqlCommand("sp_iEnfermedades")
            instruccionSQL.CommandType = CommandType.StoredProcedure
            instruccionSQL.Connection = miconexion
            instruccionSQL.Parameters.AddWithValue("Enf_Nombre", dt.Enf_Nombre)
            instruccionSQL.Parameters.AddWithValue("Enf_Descripcion", dt.Enf_Descripcion)
            If instruccionSQL.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al insertar los datos, contacte al administrador del sistema ==> ldc45 " & ex.Message, "Error al insertar", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            Desconectar()
        End Try
    End Function

    Public Function EditaData(ByRef dt As eEnfermedades) As Boolean
        Try
            conectar()
            instruccionSQL = New SqlCommand("sp_uEnfermedades")
            instruccionSQL.CommandType = CommandType.StoredProcedure
            instruccionSQL.Connection = miconexion
            instruccionSQL.Parameters.AddWithValue("Enf_Id", dt.Enf_Id)
            instruccionSQL.Parameters.AddWithValue("Enf_Nombre", dt.Enf_Nombre)
            instruccionSQL.Parameters.AddWithValue("Enf_Descripcion", dt.Enf_Descripcion)
            If instruccionSQL.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al insertar los datos, contacte al administrador del sistema ==> ldc67 " & ex.Message, "Error al insertar", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            Desconectar()
        End Try
    End Function

    Public Function Eliminar(ByRef dgv As DataGridView) As Integer
        Try
            conectar()
            Dim n As Integer = 0
            instruccionSQL = New SqlCommand("sp_dEnfermedades")
            instruccionSQL.CommandType = CommandType.StoredProcedure
            instruccionSQL.Connection = miconexion
            For Each row As DataGridViewRow In dgv.SelectedRows
                Dim Enf_Id As Object = row.Cells(0).Value
                instruccionSQL.Parameters.Clear()
                instruccionSQL.Parameters.AddWithValue("Enf_Id", Enf_Id)
                Dim result As Integer = instruccionSQL.ExecuteNonQuery()
                n += result
            Next
            Return n
        Catch ex As Exception
            MessageBox.Show("No se pudo Eliminar el/los Registros seleccionados, contacte con el administrador.   (ldc90) ==> " & ex.Message, "Error al Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return 0
        Finally
            Desconectar()
        End Try
    End Function


End Class
