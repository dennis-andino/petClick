Public Class frmBuscarPaciente
    Dim objetoPacientes As New frmBuscarP
    Dim tablaDatos As New DataTable
    Private Sub frmBuscarPaciente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarClientes()
    End Sub

    Private Sub MostrarClientes()
        Try
            tablaDatos = objetoPacientes.Mostrar
            If tablaDatos.Rows.Count > 0 Then
                dgvPacientes.DataSource = tablaDatos
                dgvPacientes.ColumnHeadersVisible = True
                dgvPacientes.Rows(0).Selected = True
            Else
                dgvPacientes.DataSource = Nothing
                dgvPacientes.ColumnHeadersVisible = False
            End If
        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al mostrar los datos, contacte al administrador del sistema ==> ldc23 " & ex.Message, "Error :(", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub buscarPaciente()
        Try
            Dim categoria As String = ""
            If cbbBuscarPa.Text = "Cliente" Then
                categoria = "cli_Nombre"
            ElseIf cbbBuscarPa.Text = "Mascota" Then
                categoria = "mas_Nombre"
            Else
                MessageBox.Show("Seleccione el Campo de Filtrado :)", "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

            Dim dataset As New DataSet
            dataset.Tables.Add(tablaDatos.Copy)
            Dim dataview As New DataView(dataset.Tables(0))
            dataview.RowFilter = categoria & " like '" & txtBuscarPa.Text & "%'"
            If dataview.Count > 0 Then
                dgvPacientes.DataSource = dataview
            Else
                dgvPacientes.DataSource = Nothing
            End If

        Catch ex As Exception
            MessageBox.Show("ups.. ocurrio un problema al obtener la informacion , contacte al administrador del sistema ==> (ldc150)  " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgvPacientes_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPacientes.CellDoubleClick
        My.Forms.frmConsultas.lblpacidS.Text = dgvPacientes.SelectedCells.Item(0).Value
        My.Forms.frmConsultas.lblnombrePacS.Text = dgvPacientes.SelectedCells.Item(1).Value
        My.Forms.frmConsultas.lblduenoP.Text = dgvPacientes.SelectedCells.Item(2).Value
        My.Forms.frmConsultas.lblclidS.Text = dgvPacientes.SelectedCells.Item(3).Value
        Me.Close()
    End Sub

    Private Sub txtBuscarPa_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarPa.TextChanged
        buscarPaciente()
    End Sub
End Class