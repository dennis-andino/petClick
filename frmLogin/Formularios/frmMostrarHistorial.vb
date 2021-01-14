Public Class frmMostrarHistorial
    Private tablaHistorial As New DataTable
    Private objetoFunciones As New fServicios

    Private Sub frmMostrarHistorial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarExpediente()
        renombrarColumnas()

    End Sub

    Private Sub MostrarExpediente()
        Try
            tablaHistorial = objetoFunciones.MostrarHistorial
            If tablaHistorial.Rows.Count > 0 Then
                dgvHistoriales.DataSource = tablaHistorial
                dgvHistoriales.Rows(0).Selected = True
            Else
                dgvHistoriales.DataSource = Nothing
                dgvHistoriales.ColumnHeadersVisible = False
            End If
        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al mostrar los datos, contacte al administrador del sistema ==> ldc23 " & ex.Message, "Error :(", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub buscarHistoria()
        Try
            Dim categoria As String = ""
            If cbbHistorial.Text = "Nombre de Cliente" Then
                categoria = "cli_Nombre"
            ElseIf cbbHistorial.Text = "Nombre de Mascota" Then
                categoria = "mas_Nombre"
            Else
                MessageBox.Show("Seleccione el Campo de Filtrado :)", "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

            Dim dataset As New DataSet
            dataset.Tables.Add(tablaHistorial.Copy)
            Dim dataview As New DataView(dataset.Tables(0))
            dataview.RowFilter = categoria & " like '" & txtBuscarHistorial.Text & "%'"
            If dataview.Count > 0 Then
                dgvHistoriales.DataSource = dataview
            Else
                dgvHistoriales.DataSource = Nothing
            End If

        Catch ex As Exception
            MessageBox.Show("ups.. ocurrio un problema al obtener la informacion , contacte al administrador del sistema ==> (ldc150)  " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtBuscarHistorial_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarHistorial.TextChanged
        buscarHistoria()
    End Sub

    Private Sub renombrarColumnas()
        dgvHistoriales.Columns(0).HeaderText = "Registro"
        dgvHistoriales.Columns(1).HeaderText = "Fecha"
        dgvHistoriales.Columns(2).HeaderText = "Paciente"
        dgvHistoriales.Columns(3).HeaderText = "Cliente"
        dgvHistoriales.Columns(4).HeaderText = ""
        dgvHistoriales.Columns(5).HeaderText = "Motivo"
        dgvHistoriales.Columns(6).HeaderText = "Medico"
        dgvHistoriales.Columns(7).HeaderText = ""
        dgvHistoriales.Columns(8).HeaderText = "Diagnostico"
        dgvHistoriales.Columns(9).HeaderText = "Servicio"
        dgvHistoriales.Columns(10).HeaderText = "Tratamiento"
        dgvHistoriales.Columns(11).HeaderText = "Costo Cita"
        dgvHistoriales.Columns(12).HeaderText = "Proxima Cita"
    End Sub
End Class