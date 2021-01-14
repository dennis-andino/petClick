Public Class frmBuscarMedico
    Dim objetoMedicos As New frmBuscarP
    Dim tablaDatos As New DataTable


    Private Sub frmBuscarMedico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarClientes()
    End Sub

    Private Sub MostrarClientes()
        Try
            tablaDatos = objetoMedicos.MostrarMedicos
            If tablaDatos.Rows.Count > 0 Then
                dgvBMedicos.DataSource = tablaDatos
                dgvBMedicos.ColumnHeadersVisible = True
                dgvBMedicos.Rows(0).Selected = True
            Else
                dgvBMedicos.DataSource = Nothing
                dgvBMedicos.ColumnHeadersVisible = False
            End If
        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al mostrar los datos, contacte al administrador del sistema ==> ldc23 " & ex.Message, "Error :(", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub buscarPaciente()
        Try
            Dim categoria As String = ""
            If cbbBuscarMe.Text = "Medico" Then
                categoria = "vet_Nombres"
            ElseIf cbbBuscarMe.Text = "Especialidad" Then
                categoria = "esp_Nombre"
            Else
                MessageBox.Show("Seleccione el Campo de Filtrado :)", "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

            Dim dataset As New DataSet
            dataset.Tables.Add(tablaDatos.Copy)
            Dim dataview As New DataView(dataset.Tables(0))
            dataview.RowFilter = categoria & " like '" & txtBuscarMe.Text & "%'"
            If dataview.Count > 0 Then
                dgvBMedicos.DataSource = dataview
            Else
                dgvBMedicos.DataSource = Nothing
            End If

        Catch ex As Exception
            MessageBox.Show("ups.. ocurrio un problema al obtener la informacion , contacte al administrador del sistema ==> (ldc150)  " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtBuscarMe_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarMe.TextChanged
        buscarPaciente()
    End Sub

    Private Sub dgvBMedicos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBMedicos.CellDoubleClick
        My.Forms.frmConsultas.txtAtendidoS.Text = dgvBMedicos.SelectedCells.Item(1).Value & " " & dgvBMedicos.SelectedCells.Item(2).Value
        My.Forms.frmConsultas.codmedico = dgvBMedicos.SelectedCells.Item(0).Value
        Me.Close()
    End Sub
End Class