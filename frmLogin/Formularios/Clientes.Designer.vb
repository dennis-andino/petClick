<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClientes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClientes))
        Me.dgvClientes = New System.Windows.Forms.DataGridView()
        Me.gbMenuCliente = New System.Windows.Forms.GroupBox()
        Me.lblCodigoC = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTelC = New System.Windows.Forms.TextBox()
        Me.txtCelC = New System.Windows.Forms.TextBox()
        Me.txtCorreoC = New System.Windows.Forms.TextBox()
        Me.txtApellidosC = New System.Windows.Forms.TextBox()
        Me.txtDircasaC = New System.Windows.Forms.TextBox()
        Me.txtDirtrabajoC = New System.Windows.Forms.TextBox()
        Me.txtNombresC = New System.Windows.Forms.TextBox()
        Me.txtBuscarC = New System.Windows.Forms.TextBox()
        Me.lblBuscar = New System.Windows.Forms.Label()
        Me.cbbBuscarCli = New System.Windows.Forms.ComboBox()
        Me.lblCatBuscar = New System.Windows.Forms.Label()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnVolverC = New System.Windows.Forms.PictureBox()
        Me.btnCancelarC = New System.Windows.Forms.Button()
        Me.btnGuardarC = New System.Windows.Forms.Button()
        Me.btnEliminarC = New System.Windows.Forms.Button()
        Me.btnModificarC = New System.Windows.Forms.Button()
        Me.btnNuevoC = New System.Windows.Forms.Button()
        Me.btnMostrarC = New System.Windows.Forms.Button()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbMenuCliente.SuspendLayout()
        CType(Me.btnVolverC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvClientes
        '
        Me.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvClientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        Me.dgvClientes.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark
        Me.dgvClientes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvClientes.Location = New System.Drawing.Point(427, 93)
        Me.dgvClientes.Name = "dgvClientes"
        Me.dgvClientes.ReadOnly = True
        Me.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvClientes.Size = New System.Drawing.Size(322, 304)
        Me.dgvClientes.TabIndex = 1
        '
        'gbMenuCliente
        '
        Me.gbMenuCliente.Controls.Add(Me.lblCodigoC)
        Me.gbMenuCliente.Controls.Add(Me.Label9)
        Me.gbMenuCliente.Controls.Add(Me.Label7)
        Me.gbMenuCliente.Controls.Add(Me.Label6)
        Me.gbMenuCliente.Controls.Add(Me.Label5)
        Me.gbMenuCliente.Controls.Add(Me.Label4)
        Me.gbMenuCliente.Controls.Add(Me.Label3)
        Me.gbMenuCliente.Controls.Add(Me.Label2)
        Me.gbMenuCliente.Controls.Add(Me.Label1)
        Me.gbMenuCliente.Controls.Add(Me.txtTelC)
        Me.gbMenuCliente.Controls.Add(Me.txtCelC)
        Me.gbMenuCliente.Controls.Add(Me.txtCorreoC)
        Me.gbMenuCliente.Controls.Add(Me.txtApellidosC)
        Me.gbMenuCliente.Controls.Add(Me.txtDircasaC)
        Me.gbMenuCliente.Controls.Add(Me.txtDirtrabajoC)
        Me.gbMenuCliente.Controls.Add(Me.txtNombresC)
        Me.gbMenuCliente.Enabled = False
        Me.gbMenuCliente.Location = New System.Drawing.Point(12, 74)
        Me.gbMenuCliente.Name = "gbMenuCliente"
        Me.gbMenuCliente.Size = New System.Drawing.Size(389, 323)
        Me.gbMenuCliente.TabIndex = 5
        Me.gbMenuCliente.TabStop = False
        Me.gbMenuCliente.Text = "Nuevo Cliente"
        '
        'lblCodigoC
        '
        Me.lblCodigoC.AutoSize = True
        Me.lblCodigoC.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigoC.Location = New System.Drawing.Point(365, 16)
        Me.lblCodigoC.Name = "lblCodigoC"
        Me.lblCodigoC.Size = New System.Drawing.Size(18, 20)
        Me.lblCodigoC.TabIndex = 15
        Me.lblCodigoC.Text = "0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(272, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 20)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Codigo"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(24, 255)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Correo Electronico"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(200, 203)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Movil"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 203)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Telefono de Domicilio"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Direccion de Trabajo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Direccion de Domicilio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(212, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Apellidos"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Nombres "
        '
        'txtTelC
        '
        Me.txtTelC.Location = New System.Drawing.Point(21, 216)
        Me.txtTelC.Name = "txtTelC"
        Me.txtTelC.Size = New System.Drawing.Size(167, 20)
        Me.txtTelC.TabIndex = 6
        '
        'txtCelC
        '
        Me.txtCelC.Location = New System.Drawing.Point(203, 216)
        Me.txtCelC.Name = "txtCelC"
        Me.txtCelC.Size = New System.Drawing.Size(167, 20)
        Me.txtCelC.TabIndex = 5
        '
        'txtCorreoC
        '
        Me.txtCorreoC.Location = New System.Drawing.Point(21, 271)
        Me.txtCorreoC.Name = "txtCorreoC"
        Me.txtCorreoC.Size = New System.Drawing.Size(349, 20)
        Me.txtCorreoC.TabIndex = 4
        '
        'txtApellidosC
        '
        Me.txtApellidosC.Location = New System.Drawing.Point(203, 66)
        Me.txtApellidosC.Name = "txtApellidosC"
        Me.txtApellidosC.Size = New System.Drawing.Size(167, 20)
        Me.txtApellidosC.TabIndex = 3
        '
        'txtDircasaC
        '
        Me.txtDircasaC.Location = New System.Drawing.Point(21, 118)
        Me.txtDircasaC.Name = "txtDircasaC"
        Me.txtDircasaC.Size = New System.Drawing.Size(349, 20)
        Me.txtDircasaC.TabIndex = 2
        '
        'txtDirtrabajoC
        '
        Me.txtDirtrabajoC.Location = New System.Drawing.Point(21, 168)
        Me.txtDirtrabajoC.Name = "txtDirtrabajoC"
        Me.txtDirtrabajoC.Size = New System.Drawing.Size(349, 20)
        Me.txtDirtrabajoC.TabIndex = 1
        '
        'txtNombresC
        '
        Me.txtNombresC.Location = New System.Drawing.Point(21, 66)
        Me.txtNombresC.Name = "txtNombresC"
        Me.txtNombresC.Size = New System.Drawing.Size(167, 20)
        Me.txtNombresC.TabIndex = 0
        '
        'txtBuscarC
        '
        Me.txtBuscarC.Location = New System.Drawing.Point(624, 67)
        Me.txtBuscarC.Name = "txtBuscarC"
        Me.txtBuscarC.Size = New System.Drawing.Size(129, 20)
        Me.txtBuscarC.TabIndex = 8
        Me.txtBuscarC.Visible = False
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.Location = New System.Drawing.Point(578, 70)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(40, 13)
        Me.lblBuscar.TabIndex = 9
        Me.lblBuscar.Text = "Buscar"
        Me.lblBuscar.Visible = False
        '
        'cbbBuscarCli
        '
        Me.cbbBuscarCli.FormattingEnabled = True
        Me.cbbBuscarCli.Items.AddRange(New Object() {"Nombre", "Celular"})
        Me.cbbBuscarCli.Location = New System.Drawing.Point(498, 66)
        Me.cbbBuscarCli.Name = "cbbBuscarCli"
        Me.cbbBuscarCli.Size = New System.Drawing.Size(74, 21)
        Me.cbbBuscarCli.TabIndex = 12
        Me.cbbBuscarCli.Visible = False
        '
        'lblCatBuscar
        '
        Me.lblCatBuscar.AutoSize = True
        Me.lblCatBuscar.Location = New System.Drawing.Point(424, 69)
        Me.lblCatBuscar.Name = "lblCatBuscar"
        Me.lblCatBuscar.Size = New System.Drawing.Size(68, 13)
        Me.lblCatBuscar.TabIndex = 13
        Me.lblCatBuscar.Text = "Buscar Por : "
        Me.lblCatBuscar.Visible = False
        '
        'btnActualizar
        '
        Me.btnActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnActualizar.FlatAppearance.BorderSize = 0
        Me.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActualizar.Image = CType(resources.GetObject("btnActualizar.Image"), System.Drawing.Image)
        Me.btnActualizar.Location = New System.Drawing.Point(133, 403)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(129, 41)
        Me.btnActualizar.TabIndex = 11
        Me.btnActualizar.UseVisualStyleBackColor = True
        Me.btnActualizar.Visible = False
        '
        'btnVolverC
        '
        Me.btnVolverC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnVolverC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.btnVolverC.Image = CType(resources.GetObject("btnVolverC.Image"), System.Drawing.Image)
        Me.btnVolverC.Location = New System.Drawing.Point(680, 2)
        Me.btnVolverC.Name = "btnVolverC"
        Me.btnVolverC.Size = New System.Drawing.Size(73, 59)
        Me.btnVolverC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnVolverC.TabIndex = 10
        Me.btnVolverC.TabStop = False
        '
        'btnCancelarC
        '
        Me.btnCancelarC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancelarC.FlatAppearance.BorderSize = 0
        Me.btnCancelarC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelarC.Image = CType(resources.GetObject("btnCancelarC.Image"), System.Drawing.Image)
        Me.btnCancelarC.Location = New System.Drawing.Point(272, 403)
        Me.btnCancelarC.Name = "btnCancelarC"
        Me.btnCancelarC.Size = New System.Drawing.Size(129, 41)
        Me.btnCancelarC.TabIndex = 7
        Me.btnCancelarC.UseVisualStyleBackColor = True
        Me.btnCancelarC.Visible = False
        '
        'btnGuardarC
        '
        Me.btnGuardarC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGuardarC.FlatAppearance.BorderSize = 0
        Me.btnGuardarC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardarC.Image = CType(resources.GetObject("btnGuardarC.Image"), System.Drawing.Image)
        Me.btnGuardarC.Location = New System.Drawing.Point(133, 403)
        Me.btnGuardarC.Name = "btnGuardarC"
        Me.btnGuardarC.Size = New System.Drawing.Size(129, 41)
        Me.btnGuardarC.TabIndex = 6
        Me.btnGuardarC.UseVisualStyleBackColor = True
        Me.btnGuardarC.Visible = False
        '
        'btnEliminarC
        '
        Me.btnEliminarC.AutoSize = True
        Me.btnEliminarC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEliminarC.FlatAppearance.BorderSize = 0
        Me.btnEliminarC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminarC.Image = CType(resources.GetObject("btnEliminarC.Image"), System.Drawing.Image)
        Me.btnEliminarC.Location = New System.Drawing.Point(498, 12)
        Me.btnEliminarC.Name = "btnEliminarC"
        Me.btnEliminarC.Size = New System.Drawing.Size(156, 41)
        Me.btnEliminarC.TabIndex = 2
        Me.btnEliminarC.UseVisualStyleBackColor = True
        '
        'btnModificarC
        '
        Me.btnModificarC.AutoSize = True
        Me.btnModificarC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnModificarC.FlatAppearance.BorderSize = 0
        Me.btnModificarC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificarC.Image = CType(resources.GetObject("btnModificarC.Image"), System.Drawing.Image)
        Me.btnModificarC.Location = New System.Drawing.Point(336, 12)
        Me.btnModificarC.Name = "btnModificarC"
        Me.btnModificarC.Size = New System.Drawing.Size(156, 41)
        Me.btnModificarC.TabIndex = 3
        Me.btnModificarC.UseVisualStyleBackColor = True
        '
        'btnNuevoC
        '
        Me.btnNuevoC.AutoSize = True
        Me.btnNuevoC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNuevoC.FlatAppearance.BorderSize = 0
        Me.btnNuevoC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevoC.Image = CType(resources.GetObject("btnNuevoC.Image"), System.Drawing.Image)
        Me.btnNuevoC.Location = New System.Drawing.Point(174, 12)
        Me.btnNuevoC.Name = "btnNuevoC"
        Me.btnNuevoC.Size = New System.Drawing.Size(156, 41)
        Me.btnNuevoC.TabIndex = 4
        Me.btnNuevoC.UseVisualStyleBackColor = True
        '
        'btnMostrarC
        '
        Me.btnMostrarC.AutoSize = True
        Me.btnMostrarC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMostrarC.FlatAppearance.BorderSize = 0
        Me.btnMostrarC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMostrarC.Image = CType(resources.GetObject("btnMostrarC.Image"), System.Drawing.Image)
        Me.btnMostrarC.Location = New System.Drawing.Point(12, 12)
        Me.btnMostrarC.Name = "btnMostrarC"
        Me.btnMostrarC.Size = New System.Drawing.Size(156, 41)
        Me.btnMostrarC.TabIndex = 0
        Me.btnMostrarC.UseVisualStyleBackColor = True
        '
        'frmClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(765, 474)
        Me.Controls.Add(Me.lblCatBuscar)
        Me.Controls.Add(Me.cbbBuscarCli)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.btnVolverC)
        Me.Controls.Add(Me.lblBuscar)
        Me.Controls.Add(Me.txtBuscarC)
        Me.Controls.Add(Me.btnCancelarC)
        Me.Controls.Add(Me.btnGuardarC)
        Me.Controls.Add(Me.gbMenuCliente)
        Me.Controls.Add(Me.btnEliminarC)
        Me.Controls.Add(Me.dgvClientes)
        Me.Controls.Add(Me.btnModificarC)
        Me.Controls.Add(Me.btnNuevoC)
        Me.Controls.Add(Me.btnMostrarC)
        Me.Name = "frmClientes"
        Me.Text = "Clientes"
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbMenuCliente.ResumeLayout(False)
        Me.gbMenuCliente.PerformLayout()
        CType(Me.btnVolverC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvClientes As DataGridView
    Friend WithEvents btnEliminarC As Button
    Friend WithEvents btnModificarC As Button
    Friend WithEvents btnNuevoC As Button
    Friend WithEvents btnMostrarC As Button
    Friend WithEvents gbMenuCliente As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTelC As TextBox
    Friend WithEvents txtCelC As TextBox
    Friend WithEvents txtCorreoC As TextBox
    Friend WithEvents txtApellidosC As TextBox
    Friend WithEvents txtDircasaC As TextBox
    Friend WithEvents txtDirtrabajoC As TextBox
    Friend WithEvents txtNombresC As TextBox
    Friend WithEvents btnGuardarC As Button
    Friend WithEvents btnCancelarC As Button
    Friend WithEvents txtBuscarC As TextBox
    Friend WithEvents lblBuscar As Label
    Friend WithEvents lblCodigoC As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnVolverC As PictureBox
    Friend WithEvents btnActualizar As Button
    Friend WithEvents cbbBuscarCli As ComboBox
    Friend WithEvents lblCatBuscar As Label
End Class
