Public Class frm_Menu
    Private Sub btnCerrarSesion_Click(sender As Object, e As EventArgs) Handles btnCerrarSesion.Click
        End
    End Sub

    Private Sub frm_Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub btnHospitalizacion_MouseHover(sender As Object, e As EventArgs) Handles btn_Enfermedades.MouseHover
        'btnHospitalizacion.Location = New Point(12, 45)
    End Sub

    Private Sub btnHospitalizacion_MouseLeave(sender As Object, e As EventArgs) Handles btn_Enfermedades.MouseLeave
        'btnHospitalizacion.Location = New Point(12, 72)
    End Sub



    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        Me.Hide()
        frmClientes.ShowDialog()
        Me.Show()
    End Sub

    Private Sub btnEnfermedades_Click(sender As Object, e As EventArgs) Handles btnEnfermedades.Click
        'se realizo cambio de funciones por ello los nombres de los controles  no coinciden
        Me.Hide()
        frmBuscarPaciente.ShowDialog()
        frmConsultas.Show()
        Me.Show()
    End Sub

    Private Sub btnMedicos_Click(sender As Object, e As EventArgs) Handles btnMedicos.Click
        Me.Hide()
        frmMedicos.ShowDialog()
        Me.Show()
    End Sub

    Private Sub btnExpedientes_Click(sender As Object, e As EventArgs) Handles btnExpedientes.Click
        Me.Hide()
        frmExpedientes.ShowDialog()
        Me.Show()
    End Sub

    Private Sub btnConsulta_Click(sender As Object, e As EventArgs) Handles btnHistorales.Click
        'se realizo cambio de funciones por ello los nombres de los controles  no coinciden
        Me.Hide()
        frmMostrarHistorial.ShowDialog()
        Me.Show()
    End Sub

    Private Sub btn_Enfermedades_Click(sender As Object, e As EventArgs) Handles btn_Enfermedades.Click
        Me.Hide()
        frmEnfermedades.ShowDialog()
        Me.Show()
    End Sub

    Private Sub btnUsuarios_Click(sender As Object, e As EventArgs) Handles btnUsuarios.Click
        Me.Hide()
        frmUsuarios.ShowDialog()
        Me.Show()
    End Sub

    Private Sub btnFarmacias_Click(sender As Object, e As EventArgs) Handles btnFarmacias.Click
        Me.Hide()
        frmFarmacias.ShowDialog()
        Me.Show()
    End Sub

    Private Sub btnMedicamentos_Click(sender As Object, e As EventArgs) Handles btnMedicamentos.Click
        Me.Hide()
        frmMedicamentos.ShowDialog()
        Me.Show()
    End Sub

    Private Sub btnHistorales_MouseHover(sender As Object, e As EventArgs) Handles btnHistorales.MouseHover
        btnHistorales.Size = New System.Drawing.Size(78, 72)
        btnHistorales.Location = New System.Drawing.Point(64, 106)
    End Sub

    Private Sub btnHistorales_MouseLeave(sender As Object, e As EventArgs) Handles btnHistorales.MouseLeave
        btnHistorales.Size = New System.Drawing.Size(140, 132)
        btnHistorales.Location = New System.Drawing.Point(31, 83)
    End Sub
End Class