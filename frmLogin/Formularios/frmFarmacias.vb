Public Class frmFarmacias
    Private objetoFarmacia As New eFarmacias
    Private objetoFunciones As New fFarmacias
    Private tablaDatosFarmacia As New DataTable

    Private Sub MostrarDatos()
        Try
            tablaDatosFarmacia = objetoFunciones.MostrarFarmacia
            If tablaDatosFarmacia.Rows.Count > 0 Then
                dgvFarmacias.DataSource = tablaDatosFarmacia
                dgvFarmacias.ColumnHeadersVisible = True
                dgvFarmacias.Columns("far_Id").Visible = False

                dgvFarmacias.Rows(0).Selected = True
                trasladaInfo()
            Else
                dgvFarmacias.DataSource = Nothing
                dgvFarmacias.ColumnHeadersVisible = False
            End If
        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al mostrar los datos, contacte al administrador del sistema ==> ldc21 " & ex.Message, "Error :(", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub EnviarDatosFa(evento As Boolean)
        objetoFarmacia.Far_Nombre = txtNombreFa.Text
        objetoFarmacia.Far_Direccion = rbDireccionFa.Text
        If evento Then
            objetoFarmacia.Far_Id = lblCodigoFa.Text
        End If
    End Sub

    Private Sub trasladaInfo()
        txtNombreFa.Text = dgvFarmacias.SelectedCells.Item(1).Value
        rbDireccionFa.Text = dgvFarmacias.SelectedCells.Item(2).Value
        lblCodigoFa.Text = dgvFarmacias.SelectedCells.Item(0).Value
    End Sub

    Private Sub limpiaInfo()
        txtNombreFa.Text = ""
        rbDireccionFa.Text = ""
        lblCodigoFa.Text = "0"
    End Sub

    Private Sub activarBotones()
        gbMenuFa.Enabled = False
        gbTxtFa.Enabled = True
        btnCancelarFa.Visible = True
        txtBuscarFa.Visible = False
        cbbBuscarFa.Visible = False
    End Sub

    Private Sub NormalizarBotones()
        gbMenuFa.Enabled = True
        gbTxtFa.Enabled = False
        btnCancelarFa.Visible = False
        txtBuscarFa.Visible = False
        cbbBuscarFa.Visible = False
        btnActualizarFa.Visible = False
        btnGuardarFa.Visible = False
        MostrarDatos()
    End Sub

    Private Sub buscarFarmacia()
        Try
            Dim categoria As String = ""
            If cbbBuscarFa.Text = "Nombre" Then
                categoria = "far_Nombre"
            ElseIf cbbBuscarFa.Text = "Direccion" Then
                categoria = "far_Direccion"
            Else
                MessageBox.Show("Seleccione el Campo de Filtrado :)", "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

            Dim dataset As New DataSet
            dataset.Tables.Add(tablaDatosFarmacia.Copy)
            Dim dataview As New DataView(dataset.Tables(0))
            dataview.RowFilter = categoria & " like '" & txtBuscarFa.Text & "%'"
            If dataview.Count > 0 Then
                dgvFarmacias.DataSource = dataview
            Else
                dgvFarmacias.DataSource = Nothing
            End If

        Catch ex As Exception
            MessageBox.Show("ups.. ocurrio un problema al obtener la informacion , contacte al administrador del sistema ==> (ldc150)  " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnMostrarFa_Click(sender As Object, e As EventArgs) Handles btnMostrarFa.Click
        txtBuscarFa.Visible = True
        cbbBuscarFa.Visible = True
    End Sub

    Private Sub frmFarmacias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarDatos()
    End Sub

    Private Sub btnVolverFa_Click(sender As Object, e As EventArgs) Handles btnVolverFa.Click
        Me.Close()
    End Sub

    Private Sub dgvFarmacias_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFarmacias.CellClick
        trasladaInfo()
    End Sub

    Private Sub btnNuevoFa_Click(sender As Object, e As EventArgs) Handles btnNuevoFa.Click
        activarBotones()
        btnGuardarFa.Visible = True
        limpiaInfo()
    End Sub

    Private Sub btnModificarFa_Click(sender As Object, e As EventArgs) Handles btnModificarFa.Click
        activarBotones()
        btnActualizarFa.Visible = True
    End Sub

    Private Sub txtBuscarFa_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarFa.TextChanged
        buscarFarmacia()
    End Sub

    Private Sub btnCancelarFa_Click(sender As Object, e As EventArgs) Handles btnCancelarFa.Click
        NormalizarBotones()
        MostrarDatos()
        MessageBox.Show("Se ha cancelado la operacion , no se ha modificado ningun Dato", "Operacion Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnGuardarFa_Click(sender As Object, e As EventArgs) Handles btnGuardarFa.Click
        EnviarDatosFa(False)
        If objetoFunciones.InsertarFarmacia(objetoFarmacia) Then
            MessageBox.Show("Se ha Guardado satisfactoriamente", "Insertar de Registros", MessageBoxButtons.OK)
            limpiaInfo()
            NormalizarBotones()
            MostrarDatos()
        Else
            MessageBox.Show("No se Pudo Registrar, verifique e intentelo nuevamente", "Error al insertar", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnActualizarFa_Click(sender As Object, e As EventArgs) Handles btnActualizarFa.Click
        EnviarDatosFa(True)
        If objetoFunciones.ModificarFarmacia(objetoFarmacia) Then
            MessageBox.Show("Se ha modificado satisfactoriamente", "Edicion De datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
            limpiaInfo()
            NormalizarBotones()
            MostrarDatos()
        Else
            MessageBox.Show("No Se ha modificado El registro, Verifica la informacion o contacta con el administrador", "Edicion De datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnEliminarFa_Click(sender As Object, e As EventArgs) Handles btnEliminarFa.Click
        Try
            Dim respuesta As DialogResult
            respuesta = MessageBox.Show("Esta seguro de eliminar el/los elementos seleccionados?", "Eliminación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If respuesta = Windows.Forms.DialogResult.OK Then
                Dim n As Integer = objetoFunciones.EliminarFa(dgvFarmacias)
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
            MostrarDatos()
        End Try
    End Sub
End Class