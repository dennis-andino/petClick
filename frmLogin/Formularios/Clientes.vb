Public Class frmClientes
    Private tablaInfo As New DataTable
    Protected objetoOperaciones As New fClientes
    Protected objetoClientes As New eClientes


    Private Sub btnVolverC_Click(sender As Object, e As EventArgs) Handles btnVolverC.Click
        Me.Close()
    End Sub
    'Mostrar la informacion obtenida de la base de datos
    Private Sub muestraData()
        Try
            tablaInfo = objetoOperaciones.Mostrar
            If tablaInfo.Rows.Count > 0 Then
                dgvClientes.DataSource = tablaInfo
                dgvClientes.Columns("cli_Id").Visible = False
                dgvClientes.Columns("cli_DireccionT").Visible = False
                dgvClientes.Columns("cli_DireccionC").Visible = False
                dgvClientes.Columns("cli_Telefono").Visible = False
                dgvClientes.Columns("cli_Correo").Visible = False
                dgvClientes.Rows(0).Selected = True

                pasainfo()
            Else
                dgvClientes.DataSource = Nothing
                MessageBox.Show("No hay Clientes Registrados", "Sin Datos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
        Catch ex As Exception
            MessageBox.Show("ups.. ocurrio un problema al obtener la informacion , contacte al administrador del sistema ==> (ldc32)" & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub pasainfo()
        lblCodigoC.Text = dgvClientes.SelectedCells.Item(0).Value
        txtNombresC.Text = dgvClientes.SelectedCells.Item(1).Value
        txtApellidosC.Text = dgvClientes.SelectedCells.Item(2).Value
        txtDirtrabajoC.Text = dgvClientes.SelectedCells.Item(3).Value
        txtDircasaC.Text = dgvClientes.SelectedCells.Item(4).Value
        txtTelC.Text = dgvClientes.SelectedCells.Item(5).Value
        txtCelC.Text = dgvClientes.SelectedCells.Item(6).Value
        txtCorreoC.Text = dgvClientes.SelectedCells.Item(7).Value
    End Sub

    'metodo para buscar la informacion
    Private Sub buscar()
        Try
            Dim categoria As String = ""
            If cbbBuscarCli.Text = "Nombre" Then
                categoria = "cli_Nombre"
            ElseIf cbbBuscarCli.Text = "Celular" Then
                categoria = "cli_Celular"
            Else
                MessageBox.Show("Seleccione el Campo de busqueda :)", "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

            Dim dataset As New DataSet
            dataset.Tables.Add(tablaInfo.Copy)
            Dim dataview As New DataView(dataset.Tables(0))
            dataview.RowFilter = categoria & " like '" & txtBuscarC.Text & "%'"
            If dataview.Count <> 0 Then
                dgvClientes.DataSource = dataview
            Else
                dgvClientes.DataSource = Nothing
            End If
        Catch ex As Exception
            MessageBox.Show("ups.. ocurrio un problema al obtener la informacion , contacte al administrador del sistema ==> (ldc69)" & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub asignarValores()
        objetoClientes.Cli_Id = lblCodigoC.Text
        objetoClientes.Cli_Nombre = txtNombresC.Text
        objetoClientes.Cli_Apellido = txtApellidosC.Text
        objetoClientes.Cli_Telefono = txtTelC.Text
        objetoClientes.Cli_Celular = txtCelC.Text
        objetoClientes.Cli_DireccionC = txtDircasaC.Text
        objetoClientes.Cli_DireccionT = txtDirtrabajoC.Text
        objetoClientes.Cli_Correo = txtCorreoC.Text
    End Sub


    Private Sub btnMostrarC_Click(sender As Object, e As EventArgs) Handles btnMostrarC.Click
        lblBuscar.Visible = True
        lblCatBuscar.Visible = True
        txtBuscarC.Visible = True
        cbbBuscarCli.Visible = True
    End Sub

    Private Sub dgvClientes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvClientes.CellClick
        pasainfo()
    End Sub

    'metodo para limpiar los texboxs
    Private Sub limpiarC()
        lblCodigoC.Text = ""
        txtNombresC.Text = ""
        txtApellidosC.Text = ""
        txtDirtrabajoC.Text = ""
        txtDircasaC.Text = ""
        txtTelC.Text = ""
        txtCelC.Text = ""
        txtCorreoC.Text = ""
        txtBuscarC.Text = ""
    End Sub

    Private Sub deshabilitarbotones()
        btnModificarC.Enabled = False
        btnEliminarC.Enabled = False
        btnMostrarC.Enabled = False
        btnNuevoC.Enabled = False
        btnCancelarC.Visible = True
        btnVolverC.Enabled = False
        dgvClientes.Visible = False
        gbMenuCliente.Enabled = True
        txtBuscarC.Visible = False
        cbbBuscarCli.Visible = False
        lblBuscar.Visible = False
        lblCatBuscar.Visible = False
    End Sub

    Private Sub habilitarBotones()
        btnModificarC.Enabled = True
        btnEliminarC.Enabled = True
        btnMostrarC.Enabled = True
        btnNuevoC.Enabled = True
        btnGuardarC.Visible = False
        btnCancelarC.Visible = False
        btnActualizar.Visible = False
        btnVolverC.Enabled = True
        dgvClientes.Visible = True
        gbMenuCliente.Enabled = False
        txtBuscarC.Visible = False
        cbbBuscarCli.Visible = False
        lblBuscar.Visible = False
        lblCatBuscar.Visible = False
    End Sub

    Private Sub btnNuevoC_Click(sender As Object, e As EventArgs) Handles btnNuevoC.Click
        deshabilitarbotones()
        btnGuardarC.Visible = True
        limpiarC()

    End Sub

    Private Sub btnCancelarC_Click(sender As Object, e As EventArgs) Handles btnCancelarC.Click
        habilitarBotones()
        limpiarC()
        muestraData()
        MessageBox.Show("Se ha cancelado la operacion , no se ha modificado ningun Dato", "Operacion Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnGuardarC_Click(sender As Object, e As EventArgs) Handles btnGuardarC.Click
        asignarValores()
        If objetoOperaciones.InsertarDatos(objetoClientes) Then
            MessageBox.Show("Se ha Guardado satisfactoriamente", "Insertar de Registros", MessageBoxButtons.OK)
            habilitarBotones()
            limpiarC()
            muestraData()
        Else
            MessageBox.Show("No se Pudo Registrar, verifique e intentelo nuevamente", "Error al insertar", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Try
            asignarValores()
            If objetoOperaciones.Modificar(objetoClientes) Then
                MessageBox.Show("Se ha modificado satisfactoriamente", "Edicion De datos", MessageBoxButtons.OK)
                btnActualizar.Visible = False
                habilitarBotones()
                muestraData()

            Else
                MessageBox.Show("No se pudo Modificar la informacion, verifique la conexion de su base de datos e intentelo nuevamente. :| ", "Datos no ingresados", MessageBoxButtons.OK)
            End If

        Catch ex As Exception
            MsgBox("ups.. ocurrio un problema al guardar la informacion , contacte al administrador del sistema ==> " & ex.Message)
        End Try
    End Sub

    Private Sub btnModificarC_Click(sender As Object, e As EventArgs) Handles btnModificarC.Click
        deshabilitarbotones()
        btnActualizar.Visible = True
    End Sub

    Private Sub btnEliminarC_Click(sender As Object, e As EventArgs) Handles btnEliminarC.Click
        Try
            Dim respuesta As DialogResult
            respuesta = MessageBox.Show("Esta seguro de eliminar el/los elementos seleccionados?", "Eliminación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If respuesta = Windows.Forms.DialogResult.OK Then
                Dim n As Integer = objetoOperaciones.EliminaVarios(dgvClientes)
                MessageBox.Show("Se han elminado " & CStr(n) & "  Registros Satisfactoriamente", "Eliminacion de Registros", MessageBoxButtons.OK, MessageBoxIcon.Information)
                muestraData()
            Else
                MsgBox("No se pudieron eliminar los registros , Operacion Cancelada", MsgBoxStyle.Information)
            End If

        Catch ex As Exception
            MsgBox("No se pudieron eliminar los registros , verifique e intentelo de nuevo  ==> ln181  " & ex.Message)
        End Try
    End Sub

    Private Sub txtBuscarC_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarC.TextChanged
        buscar()
    End Sub

    Private Sub frmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        muestraData()
    End Sub
End Class