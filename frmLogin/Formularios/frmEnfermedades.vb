Public Class frmEnfermedades
    Private tablaDatos As New DataTable
    Protected objetoFunciones As New fEnfermedades
    Protected objetoEnfermedades As New eEnfermedades



    Private Sub MostrarData()
        Try
            tablaDatos = objetoFunciones.Mostrar
            If tablaDatos.Rows.Count > 0 Then
                dgvEnfermedades.DataSource = tablaDatos
                dgvEnfermedades.ColumnHeadersVisible = True
                dgvEnfermedades.Rows(0).Selected = True
                TrasladaInfo()
                txtBuscarE.Visible = True
                cbbBuscarE.Visible = True
            Else
                dgvEnfermedades.DataSource = Nothing
                dgvEnfermedades.ColumnHeadersVisible = False
            End If
        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al mostrar los datos, contacte al administrador del sistema ==> ldc19 " & ex.Message, "Error :(", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub TrasladaInfo()
        lblCodigoE.Text = dgvEnfermedades.SelectedCells.Item(0).Value
        txtNombreE.Text = dgvEnfermedades.SelectedCells.Item(1).Value
        rbDescripcionE.Text = dgvEnfermedades.SelectedCells.Item(2).Value
    End Sub

    Private Sub limpiar()
        txtNombreE.Text = ""
        rbDescripcionE.Text = ""
        lblCodigoE.Text = "0"
        txtBuscarE.Text = ""
        cbbBuscarE.Text = "Nombre"
    End Sub

    Private Sub estadoIncial()
        gbMenuE.Enabled = True
        gbTxtE.Enabled = False
        btnActualizarE.Visible = False
        btnCancelarE.Visible = False
        btnGuardarE.Visible = False
        txtBuscarE.Visible = False
        cbbBuscarE.Visible = False
        dgvEnfermedades.Visible = False
    End Sub

    Private Sub habilitarBotones()
        gbMenuE.Enabled = False
        gbTxtE.Enabled = True
        btnCancelarE.Visible = True
        txtBuscarE.Visible = False
        cbbBuscarE.Visible = False
        dgvEnfermedades.Visible = False
    End Sub

    Private Sub asignarValoresE()
        Try
            objetoEnfermedades.Enf_Id = lblCodigoE.Text
            objetoEnfermedades.Enf_Nombre = txtNombreE.Text
            objetoEnfermedades.Enf_Descripcion = rbDescripcionE.Text
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub buscar()
        Try
            Dim categoria As String = ""
            If cbbBuscarE.Text = "Nombre" Then
                categoria = "enf_Nombre"
            ElseIf cbbBuscarE.Text = "Codigo" Then
                categoria = "enf_Id"
            Else
                MessageBox.Show("Seleccione el Campo de busqueda :)", "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
            Dim dataset As New DataSet
            dataset.Tables.Add(tablaDatos.Copy)
            Dim dataview As New DataView(dataset.Tables(0))
            dataview.RowFilter = categoria & " like '" & txtBuscarE.Text & "%'"
            If dataview.Count > 0 Then
                dgvEnfermedades.DataSource = dataview
            Else
                dgvEnfermedades.DataSource = Nothing
            End If

        Catch ex As Exception
            MessageBox.Show("ups.. ocurrio un problema al obtener la informacion , contacte al administrador del sistema ==> (ldc81)  " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub btnMostrarE_Click(sender As Object, e As EventArgs) Handles btnMostrarE.Click
        MostrarData()
        dgvEnfermedades.Visible = True
    End Sub

    Private Sub frmEnfermedades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'MostrarData()
    End Sub

    Private Sub btnVolverE_Click(sender As Object, e As EventArgs) Handles btnVolverE.Click
        frm_Menu.Show()
        Me.Close()
    End Sub

    Private Sub dgvEnfermedades_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEnfermedades.CellClick
        TrasladaInfo()
    End Sub

    Private Sub btnNuevoE_Click(sender As Object, e As EventArgs) Handles btnNuevoE.Click
        habilitarBotones()
        limpiar()
        btnGuardarE.Visible = True


    End Sub

    Private Sub btnModificarE_Click(sender As Object, e As EventArgs) Handles btnModificarE.Click
        habilitarBotones()
        btnActualizarE.Visible = True
    End Sub

    Private Sub btnCancelarE_Click(sender As Object, e As EventArgs) Handles btnCancelarE.Click
        estadoIncial()
        limpiar()
        MessageBox.Show("Se ha cancelado la operacion , no se ha modificado ningun Dato", "Operacion Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnGuardarE_Click(sender As Object, e As EventArgs) Handles btnGuardarE.Click
        asignarValoresE()
        If objetoFunciones.insertarData(objetoEnfermedades) Then
            MessageBox.Show("Se ha Guardado satisfactoriamente", "Insertar de Registros", MessageBoxButtons.OK)
            limpiar()
            estadoIncial()
            MostrarData()
        Else
            MessageBox.Show("No se Pudo Registrar, verifique e intentelo nuevamente", "Error al insertar", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnActualizarE_Click(sender As Object, e As EventArgs) Handles btnActualizarE.Click
        asignarValoresE()
        If objetoFunciones.EditaData(objetoEnfermedades) Then
            MessageBox.Show("Se ha modificado satisfactoriamente", "Edicion De datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
            estadoIncial()
            MostrarData()
        Else
            MessageBox.Show("No Se ha modificado El registro, Verifica la informacion o cotacta con el administrador", "Edicion De datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnEliminarE_Click(sender As Object, e As EventArgs) Handles btnEliminarE.Click
        Try
            Dim respuesta As DialogResult
            respuesta = MessageBox.Show("Esta seguro de eliminar el/los elementos seleccionados?", "Eliminación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If respuesta = Windows.Forms.DialogResult.OK Then
                Dim n As Integer = objetoFunciones.Eliminar(dgvEnfermedades)
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

    Private Sub txtBuscarE_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarE.TextChanged
        buscar()

    End Sub
End Class