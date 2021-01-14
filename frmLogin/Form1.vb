Public Class frm_login

    Protected objetoFunciones As New fUsuarios
    Protected objetoConexiones As New Conexiones
    Protected objetoUsuarios As New eUsuarios

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click

        End
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Try
            If txtClave.Text <> "" And txtUsuario.Text <> "" Then
                Dim TablaDatos As DataTable
                Dim nivelUsuario As String
                Dim nombreUsuario As String
                objetoUsuarios.Usu_Nickname = txtUsuario.Text
                objetoUsuarios.Usu_Clave = txtClave.Text
                TablaDatos = objetoFunciones.validarUsuario(objetoUsuarios)
                If TablaDatos.Rows.Count > 0 Then
                    nivelUsuario = TablaDatos.Rows(0)("usu_Puesto")
                    nombreUsuario = TablaDatos.Rows(0)("usu_NombreCompleto")
                    Me.Hide()
                    MessageBox.Show("Bienvenido " & nombreUsuario, "PetClick", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    frm_Menu.Text = "PetClick Principal   " & nombreUsuario
                    If nivelUsuario = "Administrador" Then
                        My.Forms.frm_Menu.btnUsuarios.Enabled = True
                    Else
                        My.Forms.frm_Menu.btnUsuarios.Enabled = False
                    End If

                    frm_Menu.Show()

                Else
                    MsgBox("Usuario o contrasenha no validos , intentelo de nuevo.")
                    txtUsuario.Text = ""
                    txtClave.Text = ""

                End If
            Else
                MsgBox("Ingrese Su Clave y contrasenha para Continuar")
            End If
        Catch ex As Exception
            MsgBox("Ha ocurrido un error al verificar sus Datos , verifique e intentelo de nuevo ln 41==> " & ex.Message)
        End Try

    End Sub
End Class
