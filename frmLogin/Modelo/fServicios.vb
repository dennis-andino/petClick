Imports System.Data.SqlClient
Public Class fServicios
    Inherits Conexiones
    Dim comandoSQL As SqlCommand

    Public Sub New()
    End Sub

    Public Function InsertarDatosHi(dt As eHistorial) As Boolean
        Try
            conectar()
            comandoSQL = New SqlCommand("sp_ihistorial")
            comandoSQL.CommandType = CommandType.StoredProcedure
            comandoSQL.Connection = miconexion
            comandoSQL.Parameters.AddWithValue("His_motivo", dt.His_motivo)
            comandoSQL.Parameters.AddWithValue("His_fecha", dt.His_fecha)
            comandoSQL.Parameters.AddWithValue("His_diagnostico", dt.His_diagnostico)
            comandoSQL.Parameters.AddWithValue("His_tratamiento", dt.His_tratamiento)
            comandoSQL.Parameters.AddWithValue("His_proximacita", dt.His_proximacita)
            comandoSQL.Parameters.AddWithValue("His_costo", dt.His_costo)
            comandoSQL.Parameters.AddWithValue("His_paciente", dt.His_paciente)
            comandoSQL.Parameters.AddWithValue("His_cliente", dt.His_cliente)
            comandoSQL.Parameters.AddWithValue("His_personal", dt.His_personal)
            comandoSQL.Parameters.AddWithValue("His_servicio", dt.His_servicio)
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

    Public Function MostrarHistorial() As DataTable
        Try
            conectar()
            comandoSQL = New SqlCommand("sp_shistorial")
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


    Public Function getServicios() As DataSet
        Try
            conectar()
            comandoSQL = New SqlCommand("sp_sServicios")
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
