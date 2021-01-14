<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMedicos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMedicos))
        Me.lblCatBuscar = New System.Windows.Forms.Label()
        Me.cbbBuscarM = New System.Windows.Forms.ComboBox()
        Me.lblBuscar = New System.Windows.Forms.Label()
        Me.txtBuscarM = New System.Windows.Forms.TextBox()
        Me.gbtxtMedicos = New System.Windows.Forms.GroupBox()
        Me.lblEspecialidades = New System.Windows.Forms.Label()
        Me.cbbEspecialidadM = New System.Windows.Forms.ComboBox()
        Me.lblCodigoM = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTelM = New System.Windows.Forms.TextBox()
        Me.txtCelM = New System.Windows.Forms.TextBox()
        Me.txtCorreoM = New System.Windows.Forms.TextBox()
        Me.txtApellidosM = New System.Windows.Forms.TextBox()
        Me.txtDircasaM = New System.Windows.Forms.TextBox()
        Me.txtNombresM = New System.Windows.Forms.TextBox()
        Me.dgvMedicos = New System.Windows.Forms.DataGridView()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnVolverM = New System.Windows.Forms.PictureBox()
        Me.btnCancelarC = New System.Windows.Forms.Button()
        Me.btnGuardarM = New System.Windows.Forms.Button()
        Me.btnEliminarM = New System.Windows.Forms.Button()
        Me.btnModificarM = New System.Windows.Forms.Button()
        Me.btnNuevoM = New System.Windows.Forms.Button()
        Me.btnMostrarM = New System.Windows.Forms.Button()
        Me.gbMenuMedicos = New System.Windows.Forms.GroupBox()
        Me.gbtxtMedicos.SuspendLayout()
        CType(Me.dgvMedicos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnVolverM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbMenuMedicos.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblCatBuscar
        '
        Me.lblCatBuscar.AutoSize = True
        Me.lblCatBuscar.Location = New System.Drawing.Point(437, 76)
        Me.lblCatBuscar.Name = "lblCatBuscar"
        Me.lblCatBuscar.Size = New System.Drawing.Size(68, 13)
        Me.lblCatBuscar.TabIndex = 27
        Me.lblCatBuscar.Text = "Buscar Por : "
        Me.lblCatBuscar.Visible = False
        '
        'cbbBuscarM
        '
        Me.cbbBuscarM.FormattingEnabled = True
        Me.cbbBuscarM.Items.AddRange(New Object() {"Nombre", "Especialidad"})
        Me.cbbBuscarM.Location = New System.Drawing.Point(511, 73)
        Me.cbbBuscarM.Name = "cbbBuscarM"
        Me.cbbBuscarM.Size = New System.Drawing.Size(74, 21)
        Me.cbbBuscarM.TabIndex = 26
        Me.cbbBuscarM.Text = "Nombre"
        Me.cbbBuscarM.Visible = False
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.Location = New System.Drawing.Point(591, 77)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(40, 13)
        Me.lblBuscar.TabIndex = 23
        Me.lblBuscar.Text = "Buscar"
        Me.lblBuscar.Visible = False
        '
        'txtBuscarM
        '
        Me.txtBuscarM.Location = New System.Drawing.Point(637, 74)
        Me.txtBuscarM.Name = "txtBuscarM"
        Me.txtBuscarM.Size = New System.Drawing.Size(129, 20)
        Me.txtBuscarM.TabIndex = 22
        Me.txtBuscarM.Visible = False
        '
        'gbtxtMedicos
        '
        Me.gbtxtMedicos.Controls.Add(Me.lblEspecialidades)
        Me.gbtxtMedicos.Controls.Add(Me.cbbEspecialidadM)
        Me.gbtxtMedicos.Controls.Add(Me.lblCodigoM)
        Me.gbtxtMedicos.Controls.Add(Me.Label9)
        Me.gbtxtMedicos.Controls.Add(Me.Label7)
        Me.gbtxtMedicos.Controls.Add(Me.Label6)
        Me.gbtxtMedicos.Controls.Add(Me.Label5)
        Me.gbtxtMedicos.Controls.Add(Me.Label3)
        Me.gbtxtMedicos.Controls.Add(Me.Label2)
        Me.gbtxtMedicos.Controls.Add(Me.Label1)
        Me.gbtxtMedicos.Controls.Add(Me.txtTelM)
        Me.gbtxtMedicos.Controls.Add(Me.txtCelM)
        Me.gbtxtMedicos.Controls.Add(Me.txtCorreoM)
        Me.gbtxtMedicos.Controls.Add(Me.txtApellidosM)
        Me.gbtxtMedicos.Controls.Add(Me.txtDircasaM)
        Me.gbtxtMedicos.Controls.Add(Me.txtNombresM)
        Me.gbtxtMedicos.Enabled = False
        Me.gbtxtMedicos.Location = New System.Drawing.Point(12, 76)
        Me.gbtxtMedicos.Name = "gbtxtMedicos"
        Me.gbtxtMedicos.Size = New System.Drawing.Size(318, 323)
        Me.gbtxtMedicos.TabIndex = 19
        Me.gbtxtMedicos.TabStop = False
        Me.gbtxtMedicos.Text = "Detalle de Informacion"
        '
        'lblEspecialidades
        '
        Me.lblEspecialidades.AutoSize = True
        Me.lblEspecialidades.Location = New System.Drawing.Point(24, 109)
        Me.lblEspecialidades.Name = "lblEspecialidades"
        Me.lblEspecialidades.Size = New System.Drawing.Size(67, 13)
        Me.lblEspecialidades.TabIndex = 17
        Me.lblEspecialidades.Text = "Especialidad"
        '
        'cbbEspecialidadM
        '
        Me.cbbEspecialidadM.FormattingEnabled = True
        Me.cbbEspecialidadM.Location = New System.Drawing.Point(121, 106)
        Me.cbbEspecialidadM.Name = "cbbEspecialidadM"
        Me.cbbEspecialidadM.Size = New System.Drawing.Size(174, 21)
        Me.cbbEspecialidadM.TabIndex = 16
        '
        'lblCodigoM
        '
        Me.lblCodigoM.AutoSize = True
        Me.lblCodigoM.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigoM.Location = New System.Drawing.Point(278, 16)
        Me.lblCodigoM.Name = "lblCodigoM"
        Me.lblCodigoM.Size = New System.Drawing.Size(18, 20)
        Me.lblCodigoM.TabIndex = 15
        Me.lblCodigoM.Text = "0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(185, 16)
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 146)
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
        'txtTelM
        '
        Me.txtTelM.Location = New System.Drawing.Point(21, 216)
        Me.txtTelM.Name = "txtTelM"
        Me.txtTelM.Size = New System.Drawing.Size(135, 20)
        Me.txtTelM.TabIndex = 6
        '
        'txtCelM
        '
        Me.txtCelM.Location = New System.Drawing.Point(162, 216)
        Me.txtCelM.Name = "txtCelM"
        Me.txtCelM.Size = New System.Drawing.Size(133, 20)
        Me.txtCelM.TabIndex = 5
        '
        'txtCorreoM
        '
        Me.txtCorreoM.Location = New System.Drawing.Point(21, 271)
        Me.txtCorreoM.Name = "txtCorreoM"
        Me.txtCorreoM.Size = New System.Drawing.Size(274, 20)
        Me.txtCorreoM.TabIndex = 4
        '
        'txtApellidosM
        '
        Me.txtApellidosM.Location = New System.Drawing.Point(161, 66)
        Me.txtApellidosM.Name = "txtApellidosM"
        Me.txtApellidosM.Size = New System.Drawing.Size(134, 20)
        Me.txtApellidosM.TabIndex = 3
        '
        'txtDircasaM
        '
        Me.txtDircasaM.Location = New System.Drawing.Point(21, 162)
        Me.txtDircasaM.Name = "txtDircasaM"
        Me.txtDircasaM.Size = New System.Drawing.Size(274, 20)
        Me.txtDircasaM.TabIndex = 2
        '
        'txtNombresM
        '
        Me.txtNombresM.Location = New System.Drawing.Point(21, 66)
        Me.txtNombresM.Name = "txtNombresM"
        Me.txtNombresM.Size = New System.Drawing.Size(135, 20)
        Me.txtNombresM.TabIndex = 0
        '
        'dgvMedicos
        '
        Me.dgvMedicos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvMedicos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        Me.dgvMedicos.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark
        Me.dgvMedicos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMedicos.Location = New System.Drawing.Point(336, 100)
        Me.dgvMedicos.Name = "dgvMedicos"
        Me.dgvMedicos.ReadOnly = True
        Me.dgvMedicos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMedicos.Size = New System.Drawing.Size(430, 304)
        Me.dgvMedicos.TabIndex = 15
        '
        'btnActualizar
        '
        Me.btnActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnActualizar.FlatAppearance.BorderSize = 0
        Me.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActualizar.Image = CType(resources.GetObject("btnActualizar.Image"), System.Drawing.Image)
        Me.btnActualizar.Location = New System.Drawing.Point(66, 405)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(129, 41)
        Me.btnActualizar.TabIndex = 25
        Me.btnActualizar.UseVisualStyleBackColor = True
        Me.btnActualizar.Visible = False
        '
        'btnVolverM
        '
        Me.btnVolverM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnVolverM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.btnVolverM.Image = CType(resources.GetObject("btnVolverM.Image"), System.Drawing.Image)
        Me.btnVolverM.Location = New System.Drawing.Point(680, 4)
        Me.btnVolverM.Name = "btnVolverM"
        Me.btnVolverM.Size = New System.Drawing.Size(73, 59)
        Me.btnVolverM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnVolverM.TabIndex = 24
        Me.btnVolverM.TabStop = False
        '
        'btnCancelarC
        '
        Me.btnCancelarC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancelarC.FlatAppearance.BorderSize = 0
        Me.btnCancelarC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelarC.Image = CType(resources.GetObject("btnCancelarC.Image"), System.Drawing.Image)
        Me.btnCancelarC.Location = New System.Drawing.Point(201, 405)
        Me.btnCancelarC.Name = "btnCancelarC"
        Me.btnCancelarC.Size = New System.Drawing.Size(129, 41)
        Me.btnCancelarC.TabIndex = 21
        Me.btnCancelarC.UseVisualStyleBackColor = True
        Me.btnCancelarC.Visible = False
        '
        'btnGuardarM
        '
        Me.btnGuardarM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGuardarM.FlatAppearance.BorderSize = 0
        Me.btnGuardarM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardarM.Image = CType(resources.GetObject("btnGuardarM.Image"), System.Drawing.Image)
        Me.btnGuardarM.Location = New System.Drawing.Point(66, 405)
        Me.btnGuardarM.Name = "btnGuardarM"
        Me.btnGuardarM.Size = New System.Drawing.Size(129, 41)
        Me.btnGuardarM.TabIndex = 20
        Me.btnGuardarM.UseVisualStyleBackColor = True
        Me.btnGuardarM.Visible = False
        '
        'btnEliminarM
        '
        Me.btnEliminarM.AutoSize = True
        Me.btnEliminarM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEliminarM.FlatAppearance.BorderSize = 0
        Me.btnEliminarM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminarM.Image = CType(resources.GetObject("btnEliminarM.Image"), System.Drawing.Image)
        Me.btnEliminarM.Location = New System.Drawing.Point(497, 18)
        Me.btnEliminarM.Name = "btnEliminarM"
        Me.btnEliminarM.Size = New System.Drawing.Size(156, 41)
        Me.btnEliminarM.TabIndex = 16
        Me.btnEliminarM.UseVisualStyleBackColor = True
        '
        'btnModificarM
        '
        Me.btnModificarM.AutoSize = True
        Me.btnModificarM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnModificarM.FlatAppearance.BorderSize = 0
        Me.btnModificarM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificarM.Image = CType(resources.GetObject("btnModificarM.Image"), System.Drawing.Image)
        Me.btnModificarM.Location = New System.Drawing.Point(334, 18)
        Me.btnModificarM.Name = "btnModificarM"
        Me.btnModificarM.Size = New System.Drawing.Size(156, 41)
        Me.btnModificarM.TabIndex = 17
        Me.btnModificarM.UseVisualStyleBackColor = True
        '
        'btnNuevoM
        '
        Me.btnNuevoM.AutoSize = True
        Me.btnNuevoM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNuevoM.FlatAppearance.BorderSize = 0
        Me.btnNuevoM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevoM.Image = CType(resources.GetObject("btnNuevoM.Image"), System.Drawing.Image)
        Me.btnNuevoM.Location = New System.Drawing.Point(172, 18)
        Me.btnNuevoM.Name = "btnNuevoM"
        Me.btnNuevoM.Size = New System.Drawing.Size(156, 41)
        Me.btnNuevoM.TabIndex = 18
        Me.btnNuevoM.UseVisualStyleBackColor = True
        '
        'btnMostrarM
        '
        Me.btnMostrarM.AutoSize = True
        Me.btnMostrarM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMostrarM.FlatAppearance.BorderSize = 0
        Me.btnMostrarM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMostrarM.Image = CType(resources.GetObject("btnMostrarM.Image"), System.Drawing.Image)
        Me.btnMostrarM.Location = New System.Drawing.Point(10, 18)
        Me.btnMostrarM.Name = "btnMostrarM"
        Me.btnMostrarM.Size = New System.Drawing.Size(156, 41)
        Me.btnMostrarM.TabIndex = 14
        Me.btnMostrarM.UseVisualStyleBackColor = True
        '
        'gbMenuMedicos
        '
        Me.gbMenuMedicos.Controls.Add(Me.btnEliminarM)
        Me.gbMenuMedicos.Controls.Add(Me.btnModificarM)
        Me.gbMenuMedicos.Controls.Add(Me.btnNuevoM)
        Me.gbMenuMedicos.Controls.Add(Me.btnMostrarM)
        Me.gbMenuMedicos.Location = New System.Drawing.Point(12, 4)
        Me.gbMenuMedicos.Name = "gbMenuMedicos"
        Me.gbMenuMedicos.Size = New System.Drawing.Size(662, 63)
        Me.gbMenuMedicos.TabIndex = 28
        Me.gbMenuMedicos.TabStop = False
        Me.gbMenuMedicos.Text = "Menu"
        '
        'frmMedicos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(776, 467)
        Me.Controls.Add(Me.gbtxtMedicos)
        Me.Controls.Add(Me.gbMenuMedicos)
        Me.Controls.Add(Me.lblCatBuscar)
        Me.Controls.Add(Me.cbbBuscarM)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.btnVolverM)
        Me.Controls.Add(Me.lblBuscar)
        Me.Controls.Add(Me.txtBuscarM)
        Me.Controls.Add(Me.btnCancelarC)
        Me.Controls.Add(Me.btnGuardarM)
        Me.Controls.Add(Me.dgvMedicos)
        Me.Name = "frmMedicos"
        Me.Text = "Medicos"
        Me.gbtxtMedicos.ResumeLayout(False)
        Me.gbtxtMedicos.PerformLayout()
        CType(Me.dgvMedicos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnVolverM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbMenuMedicos.ResumeLayout(False)
        Me.gbMenuMedicos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCatBuscar As Label
    Friend WithEvents cbbBuscarM As ComboBox
    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnVolverM As PictureBox
    Friend WithEvents lblBuscar As Label
    Friend WithEvents txtBuscarM As TextBox
    Friend WithEvents btnCancelarC As Button
    Friend WithEvents btnGuardarM As Button
    Friend WithEvents gbtxtMedicos As GroupBox
    Friend WithEvents lblCodigoM As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTelM As TextBox
    Friend WithEvents txtCelM As TextBox
    Friend WithEvents txtCorreoM As TextBox
    Friend WithEvents txtApellidosM As TextBox
    Friend WithEvents txtDircasaM As TextBox
    Friend WithEvents txtNombresM As TextBox
    Friend WithEvents btnEliminarM As Button
    Friend WithEvents dgvMedicos As DataGridView
    Friend WithEvents btnModificarM As Button
    Friend WithEvents btnNuevoM As Button
    Friend WithEvents btnMostrarM As Button
    Friend WithEvents lblEspecialidades As Label
    Friend WithEvents cbbEspecialidadM As ComboBox
    Friend WithEvents gbMenuMedicos As GroupBox
End Class
