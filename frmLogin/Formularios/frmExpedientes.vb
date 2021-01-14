Public Class frmExpedientes
    Private tablaDatos As New DataTable
    Protected objetoFunciones As New fExpediente
    Protected objetoExpediente As New eExpediente


    Private Sub btnVolverEx_Click(sender As Object, e As EventArgs) Handles btnVolverEx.Click
        Me.Hide()
        frm_Menu.Show()
        Me.Close()
    End Sub

    Private Sub frmExpedientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarExpediente()
    End Sub

    Private Sub MostrarExpediente()
        Try
            tablaDatos = objetoFunciones.MostrarEx
            If tablaDatos.Rows.Count > 0 Then
                dgvExpedientes.DataSource = tablaDatos
                dgvExpedientes.ColumnHeadersVisible = True
                dgvExpedientes.Columns("mas_Id").Visible = False
                dgvExpedientes.Columns("cli_Nombre").Visible = False
                dgvExpedientes.Columns("cli_Apellido").Visible = False
                dgvExpedientes.Columns("mas_Habitat").Visible = False
                dgvExpedientes.Columns("mas_Peso").Visible = False
                dgvExpedientes.Columns("mas_Otros").Visible = False
                dgvExpedientes.Rows(0).Selected = True
                trasladarInfoEx()
            Else
                dgvExpedientes.DataSource = Nothing
                dgvExpedientes.ColumnHeadersVisible = False
            End If
        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al mostrar los datos, contacte al administrador del sistema ==> ldc23 " & ex.Message, "Error :(", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub trasladarInfoEx()
        lblCodigoEx.Text = dgvExpedientes.SelectedCells.Item(0).Value
        txtNombreEx.Text = dgvExpedientes.SelectedCells.Item(1).Value
        txtduenoEX.Text = dgvExpedientes.SelectedCells.Item(2).Value & " " & dgvExpedientes.SelectedCells.Item(3).Value
        cbbSexoEx.Text = dgvExpedientes.SelectedCells.Item(4).Value
        cbbfamiliaEx.Text = dgvExpedientes.SelectedCells.Item(5).Value
        cbbrazaEX.Text = dgvExpedientes.SelectedCells.Item(6).Value
        txtSangreEx.Text = dgvExpedientes.SelectedCells.Item(8).Value
        dtpfechnacEx.Value = dgvExpedientes.SelectedCells.Item(7).Value
        txtcolorEx.Text = dgvExpedientes.SelectedCells.Item(9).Value
        txtpesoEx.Text = dgvExpedientes.SelectedCells.Item(11).Value
        txthabitatEx.Text = dgvExpedientes.SelectedCells.Item(10).Value
        rtbotrosEx.Text = dgvExpedientes.SelectedCells.Item(12).Value
    End Sub

    Private Sub EnviarDatosEx(evento As Boolean)
        objetoExpediente.Mas_Id = lblCodigoEx.Text
        objetoExpediente.Mas_Nombre = txtNombreEx.Text
        objetoExpediente.Mas_Sexo = cbbSexoEx.SelectedItem.ToString()
        objetoExpediente.Mas_EspecieId = cbbfamiliaEx.SelectedValue
        objetoExpediente.Mas_EspecieTipoId = cbbrazaEX.SelectedValue
        objetoExpediente.Mas_FechaNac = dtpfechnacEx.Value
        objetoExpediente.Mas_TipoSangre = txtSangreEx.Text
        objetoExpediente.Mas_Color = txtcolorEx.Text
        objetoExpediente.Mas_Peso = txtpesoEx.Text
        objetoExpediente.Mas_Habitat = txthabitatEx.Text
        objetoExpediente.Mas_Otros = rtbotrosEx.Text
        If evento Then
            objetoExpediente.Mas_DuenhoID = txtduenoEX.Text
        End If
    End Sub

    Private Sub limpiarEx()
        lblCodigoEx.Text = "0"
        txtNombreEx.Text = ""
        txtduenoEX.Text = ""
        cbbSexoEx.Text = "-"
        cbbfamiliaEx.Text = ""
        cbbrazaEX.Text = ""
        txtSangreEx.Text = ""
        dtpfechnacEx.ResetText()
        txtcolorEx.Text = ""
        txtpesoEx.Text = ""
        txthabitatEx.Text = ""
        rtbotrosEx.Text = ""
        txtBuscarEx.Text = ""
    End Sub

    Private Sub habilitarControlesEx()
        gbMenuEx.Enabled = False
        gbtxtEx.Enabled = True
        lblBuscar.Visible = False
        lblCatBuscar.Visible = False
        txtBuscarEx.Visible = False
        cbbBuscarEx.Visible = False
        dgvExpedientes.Enabled = False
        btnCancelarEx.Visible = True

    End Sub

    Private Sub normalizaControlesEx()
        gbMenuEx.Enabled = True
        dgvExpedientes.Enabled = True
        gbtxtEx.Enabled = False
        btnActualizarEx.Visible = False
        btnGuardarEx.Visible = False
        btnCancelarEx.Visible = False
        lblBuscar.Visible = False
        lblCatBuscar.Visible = False
        txtBuscarEx.Visible = False
        cbbBuscarEx.Visible = False
        txtduenoEX.Enabled = False
        lblduenho.Text = "Pertenece A:"
        MostrarExpediente()
    End Sub

    Private Sub CargarFamilia()
        cbbfamiliaEx.DataSource = objetoFunciones.getFamilia.Tables(0)
        cbbfamiliaEx.DisplayMember = "esp_Nombre"
        cbbfamiliaEx.ValueMember = "esp_Id"
    End Sub

    Private Sub CargaRaza()
        cbbrazaEX.DataSource = objetoFunciones.getRaza(cbbfamiliaEx.SelectedValue).Tables(0)
        cbbrazaEX.DisplayMember = "raz_Nombre"
        cbbrazaEX.ValueMember = "raz_Id"
    End Sub

    Private Sub buscarExpediente()
        Try
            Dim categoria As String = ""
            If cbbBuscarEx.Text = "Cliente" Then
                categoria = "cli_Nombre"
            ElseIf cbbBuscarEx.Text = "Mascota" Then
                categoria = "mas_Nombre"
            Else
                MessageBox.Show("Seleccione el Campo de Filtrado :)", "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

            Dim dataset As New DataSet
            dataset.Tables.Add(tablaDatos.Copy)
            Dim dataview As New DataView(dataset.Tables(0))
            dataview.RowFilter = categoria & " like '" & txtBuscarEx.Text & "%'"
            If dataview.Count > 0 Then
                dgvExpedientes.DataSource = dataview
            Else
                dgvExpedientes.DataSource = Nothing
            End If

        Catch ex As Exception
            MessageBox.Show("ups.. ocurrio un problema al obtener la informacion , contacte al administrador del sistema ==> (ldc150)  " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnMostrarEx_Click(sender As Object, e As EventArgs) Handles btnMostrarEx.Click
        lblCatBuscar.Visible = True
        txtBuscarEx.Visible = True
        cbbBuscarEx.Visible = True
        dgvExpedientes.Enabled = True
    End Sub

    Private Sub btnModificarEx_Click(sender As Object, e As EventArgs) Handles btnModificarEx.Click
        habilitarControlesEx()
        CargarFamilia()
        cbbfamiliaEx.Text = dgvExpedientes.SelectedCells.Item(5).Value
        CargaRaza()
        cbbrazaEX.Text = dgvExpedientes.SelectedCells.Item(6).Value
        btnActualizarEx.Visible = True
        txtduenoEX.Enabled = False
    End Sub

    Private Sub cbbfamiliaEx_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbbfamiliaEx.SelectionChangeCommitted
        CargaRaza()
    End Sub

    Private Sub dgvExpedientes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvExpedientes.CellClick
        trasladarInfoEx()
    End Sub

    Private Sub btnNuevoEx_Click(sender As Object, e As EventArgs) Handles btnNuevoEx.Click
        limpiarEx()
        lblduenho.Text = "ID de Cliente"
        txtduenoEX.Enabled = True
        habilitarControlesEx()
        btnGuardarEx.Visible = True
        CargarFamilia()
        CargaRaza()
    End Sub

    Private Sub btnCancelarEx_Click(sender As Object, e As EventArgs) Handles btnCancelarEx.Click
        normalizaControlesEx()
        MostrarExpediente()
        MessageBox.Show("Se ha cancelado la operacion , no se ha modificado ningun Dato", "Operacion Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnGuardarEx_Click(sender As Object, e As EventArgs) Handles btnGuardarEx.Click
        EnviarDatosEx(True)
        If objetoFunciones.InsertarDatosEX(objetoExpediente) Then
            MessageBox.Show("Se ha Guardado satisfactoriamente", "Insertar de Registros", MessageBoxButtons.OK)
            limpiarEx()
            normalizaControlesEx()
            MostrarExpediente()
        Else
            MessageBox.Show("No se Pudo Registrar, verifique e intentelo nuevamente", "Error al insertar", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnActualizarEx_Click(sender As Object, e As EventArgs) Handles btnActualizarEx.Click
        EnviarDatosEx(False)
        If objetoFunciones.ModificarEx(objetoExpediente) Then
            MessageBox.Show("Se ha modificado satisfactoriamente", "Edicion De datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
            normalizaControlesEx()
            MostrarExpediente()
        Else
            MessageBox.Show("No Se ha modificado El registro, Verifica la informacion o contacta con el administrador", "Edicion De datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnEliminarEx_Click(sender As Object, e As EventArgs) Handles btnEliminarEx.Click
        Try
            Dim respuesta As DialogResult
            respuesta = MessageBox.Show("Esta seguro de eliminar el/los elementos seleccionados?", "Eliminación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If respuesta = Windows.Forms.DialogResult.OK Then
                Dim n As Integer = objetoFunciones.EliminarEx(dgvExpedientes)
                If n > 0 Then
                    MessageBox.Show("Se Han Eliminado " & CStr(n) & " Registros Satisfactoriamente", "Eliminacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("No Se Selecciono ningun registro,Intentelo nuevamente", "Eliminacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            Else
                MessageBox.Show("No se elimino Ningun Registro,Operacion Cancelada por Usuario", "Operacion Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Hand)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        Finally
            MostrarExpediente()
        End Try
    End Sub

    Private Sub txtBuscarEx_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarEx.TextChanged
        buscarExpediente()
    End Sub
End Class