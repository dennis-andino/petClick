Imports System.Data.SqlClient
Public Class fMedicos
    Inherits Conexiones
    Dim comandoSQl As SqlCommand


    Public Function Mostrar() As DataTable

        Try
            conectar()
            comandoSQl = New SqlCommand("sp_sVeterinario")
            comandoSQl.CommandType = CommandType.StoredProcedure
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
            MsgBox("Ha ocurrido un error al extraer los datos, contacte al administrador del sistema ==> " & ex.Message, MsgBoxStyle.Critical, "problemas de conexion")
            Return Nothing
        Finally
            Desconectar()

        End Try
    End Function


    Public Function InsertarDatos(dt As eMedicos) As Boolean
        Try
            conectar()
            comandoSQl = New SqlCommand("sp_iVeterinario")
            comandoSQl.CommandType = CommandType.StoredProcedure
            comandoSQl.Connection = miconexion
            comandoSQl.Parameters.AddWithValue("Vet_Nombres", dt.Vet_Nombres)
            comandoSQl.Parameters.AddWithValue("Vet_Apellidos", dt.Vet_Apellidos)
            comandoSQl.Parameters.AddWithValue("Vet_DireccionC", dt.Vet_DireccionC)
            comandoSQl.Parameters.AddWithValue("Vet_Telefono", dt.Vet_Telefono)
            comandoSQl.Parameters.AddWithValue("Vet_Celular", dt.Vet_Celular)
            comandoSQl.Parameters.AddWithValue("Vet_Correo", dt.Vet_Correo)
            comandoSQl.Parameters.AddWithValue("Vet_EspecialidadId", dt.Vet_EspecialidadId)
            If comandoSQl.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al insertar los datos , verifique la conexio al servidor o comuniquese con el administrador. ldc66==> " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            Desconectar()
        End Try

    End Function


    Public Function getEspecialidades() As DataSet
        Try
            conectar()
            comandoSQl = New SqlCommand("sp_sEspecialidades_lista")
            comandoSQl.CommandType = CommandType.StoredProcedure
            comandoSQl.Connection = miconexion
            If comandoSQl.ExecuteNonQuery Then
                Dim adapter As New SqlDataAdapter(comandoSQl)
                Dim data As New DataSet
                adapter.Fill(data)
                Return data
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al insertar los datos , verifique la conexio al servidor o comuniquese con el administrador. ldc66==> " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        Finally
            Desconectar()
        End Try
    End Function

    Public Function ModificarMedicos(dt As eMedicos) As Boolean
        Try
            conectar()
            comandoSQl = New SqlCommand("sp_uVeterinario")
            comandoSQl.CommandType = CommandType.StoredProcedure
            comandoSQl.Connection = miconexion
            comandoSQl.Parameters.AddWithValue("Vet_Id", dt.Vet_Id)
            comandoSQl.Parameters.AddWithValue("Vet_Nombres", dt.Vet_Nombres)
            comandoSQl.Parameters.AddWithValue("Vet_Apellidos", dt.Vet_Apellidos)
            comandoSQl.Parameters.AddWithValue("Vet_DireccionC", dt.Vet_DireccionC)
            comandoSQl.Parameters.AddWithValue("Vet_Telefono", dt.Vet_Telefono)
            comandoSQl.Parameters.AddWithValue("Vet_Celular", dt.Vet_Celular)
            comandoSQl.Parameters.AddWithValue("Vet_Correo", dt.Vet_Correo)
            comandoSQl.Parameters.AddWithValue("Vet_EspecialidadId", dt.Vet_EspecialidadId)
            If comandoSQl.ExecuteNonQuery Then
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

    Public Function Eliminar(ByRef dgv As DataGridView) As Integer
        Try
            conectar()
            Dim n As Integer = 0
            comandoSQl = New SqlCommand("sp_dVeterinario")
            comandoSQl.CommandType = CommandType.StoredProcedure
            comandoSQl.Connection = miconexion
            For Each row As DataGridViewRow In dgv.SelectedRows
                Dim vet_Id As Object = row.Cells(0).Value
                comandoSQl.Parameters.Clear()
                comandoSQl.Parameters.AddWithValue("vet_Id", vet_Id)
                Dim result As Integer = comandoSQl.ExecuteNonQuery()
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
