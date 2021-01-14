Public Class frmConsultas
    Dim objetoFunciones As New fServicios
    Dim objetoHistorial As New eHistorial
    Public codmedico As String
    Private Sub frmServicios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblfechaS.Text = DateTime.Now.ToShortDateString
        CargarServicios()
    End Sub


    Private Sub CargarServicios()
        cbbServicio.DataSource = objetoFunciones.getServicios.Tables(0)
        cbbServicio.DisplayMember = "ser_Nombre"
        cbbServicio.ValueMember = "ser_Id"
    End Sub

    Public Sub EnviarDatosHi()
        objetoHistorial.His_id = 0
        objetoHistorial.His_cliente = lblclidS.Text
        objetoHistorial.His_paciente = lblpacidS.Text
        objetoHistorial.His_fecha = lblfechaS.Text
        objetoHistorial.His_motivo = txtmotivosS.Text
        objetoHistorial.His_servicio = cbbServicio.SelectedValue
        objetoHistorial.His_personal = codmedico
        objetoHistorial.His_costo = txtCosto.Text
        objetoHistorial.His_diagnostico = rtbdiagS.Text
        objetoHistorial.His_tratamiento = rtbtratS.Text
        objetoHistorial.His_proximacita = dtpcitaS.Value
    End Sub


    Private Sub btnCancelarS_Click(sender As Object, e As EventArgs) Handles btnCancelarCons.Click
        MessageBox.Show("Se ha cancelado la operacion , no se ha modificado ningun Dato", "Operacion Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
        frm_Menu.Show()
    End Sub

    Private Sub txtAtendidoS_Click(sender As Object, e As EventArgs) Handles txtAtendidoS.Click
        frmBuscarMedico.ShowDialog()
    End Sub

    Private Sub btnRegConsulta_Click(sender As Object, e As EventArgs) Handles btnRegConsulta.Click
        EnviarDatosHi()
        If objetoFunciones.InsertarDatosHi(objetoHistorial) Then
            MessageBox.Show("Se ha Guardado satisfactoriamente", "Insertar de Registros", MessageBoxButtons.OK)

        Else
            MessageBox.Show("No se Pudo Registrar, verifique e intentelo nuevamente", "Error al insertar", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class