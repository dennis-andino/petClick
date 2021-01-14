Public Class frmMedicamentos
    Private tablaDatos As New DataTable
    Protected objetoFuncionesMed As New fMedicamentos
    Protected objetoMedicamentos As New eMedicamentos

    Private Sub frmMedicamentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarMedicamentos()
    End Sub

    Private Sub MostrarMedicamentos()
        Try
            tablaDatos = objetoFuncionesMed.MostrarMed
            If tablaDatos.Rows.Count > 0 Then
                dgvMedicamentos.DataSource = tablaDatos
                dgvMedicamentos.ColumnHeadersVisible = True
                dgvMedicamentos.Columns("med_Id").Visible = False
                dgvMedicamentos.Columns("med_Descripcion").Visible = False
                dgvMedicamentos.Rows(0).Selected = True
                TrasladoInfo()
            Else
                dgvMedicamentos.DataSource = Nothing
                dgvMedicamentos.ColumnHeadersVisible = False
            End If
        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al mostrar los datos, contacte al administrador del sistema ==> ldc23 " & ex.Message, "Error :(", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub buscarMedicamento()
        Try
            Dim categoria As String = ""
            If cbbBuscarMt.Text = "Nombre Medicamento" Then
                categoria = "med_Id"
            ElseIf cbbBuscarMt.Text = "Proveedor" Then
                categoria = "far_Nombre"
            Else
                MessageBox.Show("Seleccione el Campo de Filtrado :)", "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

            Dim dataset As New DataSet
            dataset.Tables.Add(tablaDatos.Copy)
            Dim dataview As New DataView(dataset.Tables(0))
            dataview.RowFilter = categoria & " like '" & txtBuscarMt.Text & "%'"
            If dataview.Count > 0 Then
                dgvMedicamentos.DataSource = dataview
            Else
                dgvMedicamentos.DataSource = Nothing
            End If

        Catch ex As Exception
            MessageBox.Show("ups.. ocurrio un problema al obtener la informacion , contacte al administrador del sistema ==> (ldc150)  " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub TrasladoInfo()
        lblCodigoMt.Text = dgvMedicamentos.SelectedCells.Item(0).Value
        txtNombreMt.Text = dgvMedicamentos.SelectedCells.Item(1).Value
        rbDescripcionMt.Text = dgvMedicamentos.SelectedCells.Item(2).Value
        txtCoste.Text = dgvMedicamentos.SelectedCells.Item(3).Value
        cbbEnfermedad.Text = dgvMedicamentos.SelectedCells.Item(4).Value
        cbbProveedorMt.Text = dgvMedicamentos.SelectedCells.Item(5).Value
    End Sub

    Private Sub EnviarDatosMt(ByRef evento As Boolean)
        objetoMedicamentos.Med_Nombre1 = txtNombreMt.Text
        objetoMedicamentos.Med_Descripcion1 = rbDescripcionMt.Text
        objetoMedicamentos.Med_Costo1 = txtCoste.Text
        objetoMedicamentos.Med_Enfermedad1 = cbbEnfermedad.SelectedValue
        objetoMedicamentos.Med_proveedor1 = cbbProveedorMt.SelectedValue
        If evento Then
            objetoMedicamentos.Med_Id1 = lblCodigoMt.Text
        End If
    End Sub

    Private Sub limpiaEntorno()
        lblCodigoMt.Text = "0"
        txtNombreMt.Text = ""
        rbDescripcionMt.Text = ""
        txtCoste.Text = ""
        cbbEnfermedad.Text = ""
        cbbProveedorMt.Text = ""
    End Sub

    Private Sub activarControles()
        gbMenuMt.Enabled = False
        gbTxtMt.Enabled = True
        btnCancelarMt.Visible = True
    End Sub

    Private Sub CargarFarmacia()
        cbbProveedorMt.DataSource = objetoFuncionesMed.getFarmacias.Tables(0)
        cbbProveedorMt.DisplayMember = "far_Nombre"
        cbbProveedorMt.ValueMember = "far_Id"
    End Sub

    Private Sub CargarEnfermedades()
        cbbEnfermedad.DataSource = objetoFuncionesMed.getEnfermedades.Tables(0)
        cbbEnfermedad.DisplayMember = "enf_Nombre"
        cbbEnfermedad.ValueMember = "enf_Id"
    End Sub

    Private Sub normalizarControles()
        gbMenuMt.Enabled = True
        gbTxtMt.Enabled = False
        btnCancelarMt.Visible = False
        btnActualizarMt.Visible = False
        btnGuardarMt.Visible = False
        txtBuscarMt.Visible = False
        cbbBuscarMt.Visible = False
        lblBuscar.Visible = False
        lblCatBuscar.Visible = False
    End Sub


    Private Sub btnRegresarMt_Click(sender As Object, e As EventArgs) Handles btnRegresarMt.Click
        Me.Close()
    End Sub

    Private Sub btnMostrarMt_Click(sender As Object, e As EventArgs) Handles btnMostrarMt.Click
        txtBuscarMt.Visible = True
        cbbBuscarMt.Visible = True
        lblBuscar.Visible = True
        lblCatBuscar.Visible = True
    End Sub

    Private Sub btnCancelarMt_Click(sender As Object, e As EventArgs) Handles btnCancelarMt.Click
        normalizarControles()
        MessageBox.Show("Se ha cancelado la operacion , no se ha modificado ningun Dato", "Operacion Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnNuevoMt_Click(sender As Object, e As EventArgs) Handles btnNuevoMt.Click
        limpiaEntorno()
        CargarFarmacia()
        CargarEnfermedades()
        activarControles()
        btnGuardarMt.Visible = True
    End Sub

    Private Sub btnModificarMt_Click(sender As Object, e As EventArgs) Handles btnModificarMt.Click
        activarControles()
        btnActualizarMt.Visible = False
        CargarFarmacia()
        cbbProveedorMt.Text = dgvMedicamentos.SelectedCells.Item(5).Value
        CargarEnfermedades()
        cbbEnfermedad.Text = dgvMedicamentos.SelectedCells.Item(4).Value

    End Sub

    Private Sub btnActualizarMt_Click(sender As Object, e As EventArgs) Handles btnActualizarMt.Click
        EnviarDatosMt(True)
        If objetoFuncionesMed.ModificarMed(objetoMedicamentos) Then
            MessageBox.Show("Se ha modificado satisfactoriamente", "Edicion De datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
            normalizarControles()
            MostrarMedicamentos()
        Else
            MessageBox.Show("No Se ha modificado El registro, Verifica la informacion o contacta con el administrador", "Edicion De datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnGuardarMt_Click(sender As Object, e As EventArgs) Handles btnGuardarMt.Click
        EnviarDatosMt(False)
        If objetoFuncionesMed.InsertarDatosmed(objetoMedicamentos) Then
            MessageBox.Show("Se ha Guardado satisfactoriamente", "Insertar de Registros", MessageBoxButtons.OK)
            normalizarControles()
            MostrarMedicamentos()
        Else
            MessageBox.Show("No se Pudo Registrar, verifique e intentelo nuevamente", "Error al insertar", MessageBoxButtons.OK, MessageBoxIcon.Error)
            MostrarMedicamentos()
            normalizarControles()
        End If
    End Sub

    Private Sub txtBuscarMt_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarMt.TextChanged
        buscarMedicamento()
    End Sub

    Private Sub dgvMedicamentos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMedicamentos.CellClick
        TrasladoInfo()
    End Sub

    Private Sub btnEliminarMt_Click(sender As Object, e As EventArgs) Handles btnEliminarMt.Click
        Try
            Dim respuesta As DialogResult
            respuesta = MessageBox.Show("Esta seguro de eliminar el/los elementos seleccionados?", "Eliminación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If respuesta = Windows.Forms.DialogResult.OK Then
                Dim n As Integer = objetoFuncionesMed.EliminarMeds(dgvMedicamentos)
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
            MostrarMedicamentos()
        End Try
    End Sub
End Class