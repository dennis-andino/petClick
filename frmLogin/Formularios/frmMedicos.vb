
Public Class frmMedicos
    Private tablaDatos As New DataTable
    Protected objetoFunciones As New fMedicos
    Protected objetoMedicos As New eMedicos


    Private Sub MostrarData()
        Try
            tablaDatos = objetoFunciones.Mostrar
            If tablaDatos.Rows.Count > 0 Then
                dgvMedicos.DataSource = tablaDatos
                dgvMedicos.ColumnHeadersVisible = True
                dgvMedicos.Columns("vet_Id").Visible = False
                dgvMedicos.Columns("vet_DireccionC").Visible = False
                dgvMedicos.Columns("vet_Telefono").Visible = False
                dgvMedicos.Columns("vet_Correo").Visible = False
                dgvMedicos.Rows(0).Selected = True
                trasladarInfo()
            Else
                dgvMedicos.DataSource = Nothing
                dgvMedicos.ColumnHeadersVisible = False
            End If
        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al mostrar los datos, contacte al administrador del sistema ==> ldc23 " & ex.Message, "Error :(", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub buscarMedicos()
        Try
            Dim categoria As String = ""
            If cbbBuscarM.Text = "Nombre" Then
                categoria = "vet_Nombres"
            ElseIf cbbBuscarM.Text = "Especialidad" Then
                categoria = "esp_Nombre"
            Else
                MessageBox.Show("Seleccione el Campo de busqueda :)", "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

            Dim dataset As New DataSet
            dataset.Tables.Add(tablaDatos.Copy)
            Dim dataview As New DataView(dataset.Tables(0))
            dataview.RowFilter = categoria & " like '" & txtBuscarM.Text & "%'"
            If dataview.Count > 0 Then
                dgvMedicos.DataSource = dataview
            Else
                dgvMedicos.DataSource = Nothing
            End If

        Catch ex As Exception
            MessageBox.Show("ups.. ocurrio un problema al obtener la informacion , contacte al administrador del sistema ==> (ldc81)  " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub trasladarInfo()
        lblCodigoM.Text = dgvMedicos.SelectedCells.Item(0).Value
        txtNombresM.Text = dgvMedicos.SelectedCells.Item(1).Value
        txtApellidosM.Text = dgvMedicos.SelectedCells.Item(2).Value
        cbbEspecialidadM.Text = dgvMedicos.SelectedCells.Item(3).Value
        txtDircasaM.Text = dgvMedicos.SelectedCells.Item(4).Value
        txtTelM.Text = dgvMedicos.SelectedCells.Item(5).Value
        txtCelM.Text = dgvMedicos.SelectedCells.Item(6).Value
        txtCorreoM.Text = dgvMedicos.SelectedCells.Item(7).Value

    End Sub

    Private Sub limpiarCampos()
        lblCodigoM.Text = "0"
        txtNombresM.Text = ""
        txtApellidosM.Text = ""
        txtDircasaM.Text = ""
        txtTelM.Text = ""
        txtCelM.Text = ""
        txtBuscarM.Text = ""
        txtCorreoM.Text = ""
        cbbEspecialidadM.Text = ""
    End Sub

    Private Sub habilitarControles()
        gbMenuMedicos.Enabled = False
        gbtxtMedicos.Enabled = True
        btnCancelarC.Visible = True
        txtBuscarM.Visible = False
        cbbBuscarM.Visible = False
    End Sub

    Private Sub NormalizarControles()
        gbMenuMedicos.Enabled = True
        gbtxtMedicos.Enabled = False
        btnCancelarC.Visible = False
        btnActualizar.Visible = False
        btnGuardarM.Visible = False
        limpiarCampos()
        MostrarData()
    End Sub

    Private Sub EnviarDatos()
        objetoMedicos.Vet_Id = lblCodigoM.Text
        objetoMedicos.Vet_Nombres = txtNombresM.Text
        objetoMedicos.Vet_Apellidos = txtApellidosM.Text
        objetoMedicos.Vet_DireccionC = txtDircasaM.Text
        objetoMedicos.Vet_Telefono = txtTelM.Text
        objetoMedicos.Vet_Celular = txtCelM.Text
        objetoMedicos.Vet_Correo = txtCorreoM.Text
        objetoMedicos.Vet_EspecialidadId = cbbEspecialidadM.SelectedValue
    End Sub

    Private Sub CargarEspecialidades()
        cbbEspecialidadM.DataSource = objetoFunciones.getEspecialidades.Tables(0)
        cbbEspecialidadM.DisplayMember = "esp_Nombre"
        cbbEspecialidadM.ValueMember = "esp_Id"
    End Sub

    Private Sub btnMostrarM_Click(sender As Object, e As EventArgs) Handles btnMostrarM.Click
        MostrarData()
        txtBuscarM.Visible = True
        cbbBuscarM.Visible = True
    End Sub

    Private Sub dgvMedicos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMedicos.CellClick
        trasladarInfo()
    End Sub

    Private Sub btnVolverM_Click(sender As Object, e As EventArgs) Handles btnVolverM.Click
        frm_Menu.Show()
        Me.Close()
    End Sub

    Private Sub btnNuevoM_Click(sender As Object, e As EventArgs) Handles btnNuevoM.Click
        limpiarCampos()
        habilitarControles()
        btnGuardarM.Visible = True
        gbtxtMedicos.Enabled = True
        CargarEspecialidades()
    End Sub

    Private Sub btnGuardarM_Click(sender As Object, e As EventArgs) Handles btnGuardarM.Click
        EnviarDatos()
        If objetoFunciones.InsertarDatos(objetoMedicos) Then
            MessageBox.Show("Se ha Guardado satisfactoriamente", "Insertar de Registros", MessageBoxButtons.OK)
            limpiarCampos()
            NormalizarControles()
            MostrarData()
        Else
            MessageBox.Show("No se Pudo Registrar, verifique e intentelo nuevamente", "Error al insertar", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnCancelarC_Click(sender As Object, e As EventArgs) Handles btnCancelarC.Click
        NormalizarControles()
        limpiarCampos()
        MostrarData()
        MessageBox.Show("Se ha cancelado la operacion , no se ha modificado ningun Dato", "Operacion Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnModificarM_Click(sender As Object, e As EventArgs) Handles btnModificarM.Click
        habilitarControles()
        btnActualizar.Visible = True
        CargarEspecialidades()
        cbbEspecialidadM.Text = dgvMedicos.SelectedCells.Item(3).Value
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        EnviarDatos()
        If objetoFunciones.ModificarMedicos(objetoMedicos) Then
            MessageBox.Show("Se ha modificado satisfactoriamente", "Edicion De datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
            NormalizarControles()
            MostrarData()
        Else
            MessageBox.Show("No Se ha modificado El registro, Verifica la informacion o contacta con el administrador", "Edicion De datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnEliminarM_Click(sender As Object, e As EventArgs) Handles btnEliminarM.Click
        Try
            Dim respuesta As DialogResult
            respuesta = MessageBox.Show("Esta seguro de eliminar el/los elementos seleccionados?", "Eliminación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If respuesta = Windows.Forms.DialogResult.OK Then
                Dim n As Integer = objetoFunciones.Eliminar(dgvMedicos)
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
            MostrarData()
        End Try
    End Sub

    Private Sub txtBuscarM_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarM.TextChanged
        buscarMedicos()
    End Sub
End Class