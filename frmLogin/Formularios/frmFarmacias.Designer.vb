<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFarmacias
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFarmacias))
        Me.lblCatBuscar = New System.Windows.Forms.Label()
        Me.cbbBuscarFa = New System.Windows.Forms.ComboBox()
        Me.lblBuscar = New System.Windows.Forms.Label()
        Me.txtBuscarFa = New System.Windows.Forms.TextBox()
        Me.gbTxtFa = New System.Windows.Forms.GroupBox()
        Me.btnActualizarFa = New System.Windows.Forms.Button()
        Me.btnCancelarFa = New System.Windows.Forms.Button()
        Me.btnGuardarFa = New System.Windows.Forms.Button()
        Me.lblDescripcionE = New System.Windows.Forms.Label()
        Me.lblnombreE = New System.Windows.Forms.Label()
        Me.txtNombreFa = New System.Windows.Forms.TextBox()
        Me.rbDireccionFa = New System.Windows.Forms.RichTextBox()
        Me.lblCodigoFa = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dgvFarmacias = New System.Windows.Forms.DataGridView()
        Me.gbMenuFa = New System.Windows.Forms.GroupBox()
        Me.btnVolverFa = New System.Windows.Forms.PictureBox()
        Me.btnEliminarFa = New System.Windows.Forms.Button()
        Me.btnModificarFa = New System.Windows.Forms.Button()
        Me.btnNuevoFa = New System.Windows.Forms.Button()
        Me.btnMostrarFa = New System.Windows.Forms.Button()
        Me.gbTxtFa.SuspendLayout()
        CType(Me.dgvFarmacias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbMenuFa.SuspendLayout()
        CType(Me.btnVolverFa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCatBuscar
        '
        Me.lblCatBuscar.AutoSize = True
        Me.lblCatBuscar.Location = New System.Drawing.Point(428, 90)
        Me.lblCatBuscar.Name = "lblCatBuscar"
        Me.lblCatBuscar.Size = New System.Drawing.Size(68, 13)
        Me.lblCatBuscar.TabIndex = 24
        Me.lblCatBuscar.Text = "Buscar Por : "
        Me.lblCatBuscar.Visible = False
        '
        'cbbBuscarFa
        '
        Me.cbbBuscarFa.FormattingEnabled = True
        Me.cbbBuscarFa.Items.AddRange(New Object() {"Nombre", "Direccion"})
        Me.cbbBuscarFa.Location = New System.Drawing.Point(502, 87)
        Me.cbbBuscarFa.Name = "cbbBuscarFa"
        Me.cbbBuscarFa.Size = New System.Drawing.Size(74, 21)
        Me.cbbBuscarFa.TabIndex = 23
        Me.cbbBuscarFa.Text = "Nombre"
        Me.cbbBuscarFa.Visible = False
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.Location = New System.Drawing.Point(582, 91)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(40, 13)
        Me.lblBuscar.TabIndex = 22
        Me.lblBuscar.Text = "Buscar"
        Me.lblBuscar.Visible = False
        '
        'txtBuscarFa
        '
        Me.txtBuscarFa.Location = New System.Drawing.Point(628, 88)
        Me.txtBuscarFa.Name = "txtBuscarFa"
        Me.txtBuscarFa.Size = New System.Drawing.Size(128, 20)
        Me.txtBuscarFa.TabIndex = 21
        Me.txtBuscarFa.Visible = False
        '
        'gbTxtFa
        '
        Me.gbTxtFa.Controls.Add(Me.btnActualizarFa)
        Me.gbTxtFa.Controls.Add(Me.btnCancelarFa)
        Me.gbTxtFa.Controls.Add(Me.btnGuardarFa)
        Me.gbTxtFa.Controls.Add(Me.lblDescripcionE)
        Me.gbTxtFa.Controls.Add(Me.lblnombreE)
        Me.gbTxtFa.Controls.Add(Me.txtNombreFa)
        Me.gbTxtFa.Controls.Add(Me.rbDireccionFa)
        Me.gbTxtFa.Controls.Add(Me.lblCodigoFa)
        Me.gbTxtFa.Controls.Add(Me.Label9)
        Me.gbTxtFa.Enabled = False
        Me.gbTxtFa.Location = New System.Drawing.Point(7, 88)
        Me.gbTxtFa.Name = "gbTxtFa"
        Me.gbTxtFa.Size = New System.Drawing.Size(342, 364)
        Me.gbTxtFa.TabIndex = 20
        Me.gbTxtFa.TabStop = False
        '
        'btnActualizarFa
        '
        Me.btnActualizarFa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnActualizarFa.FlatAppearance.BorderSize = 0
        Me.btnActualizarFa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActualizarFa.Image = CType(resources.GetObject("btnActualizarFa.Image"), System.Drawing.Image)
        Me.btnActualizarFa.Location = New System.Drawing.Point(59, 317)
        Me.btnActualizarFa.Name = "btnActualizarFa"
        Me.btnActualizarFa.Size = New System.Drawing.Size(129, 41)
        Me.btnActualizarFa.TabIndex = 24
        Me.btnActualizarFa.UseVisualStyleBackColor = True
        Me.btnActualizarFa.Visible = False
        '
        'btnCancelarFa
        '
        Me.btnCancelarFa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancelarFa.FlatAppearance.BorderSize = 0
        Me.btnCancelarFa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelarFa.Image = CType(resources.GetObject("btnCancelarFa.Image"), System.Drawing.Image)
        Me.btnCancelarFa.Location = New System.Drawing.Point(198, 317)
        Me.btnCancelarFa.Name = "btnCancelarFa"
        Me.btnCancelarFa.Size = New System.Drawing.Size(129, 41)
        Me.btnCancelarFa.TabIndex = 23
        Me.btnCancelarFa.UseVisualStyleBackColor = True
        Me.btnCancelarFa.Visible = False
        '
        'btnGuardarFa
        '
        Me.btnGuardarFa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGuardarFa.FlatAppearance.BorderSize = 0
        Me.btnGuardarFa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardarFa.Image = CType(resources.GetObject("btnGuardarFa.Image"), System.Drawing.Image)
        Me.btnGuardarFa.Location = New System.Drawing.Point(59, 317)
        Me.btnGuardarFa.Name = "btnGuardarFa"
        Me.btnGuardarFa.Size = New System.Drawing.Size(129, 41)
        Me.btnGuardarFa.TabIndex = 22
        Me.btnGuardarFa.UseVisualStyleBackColor = True
        Me.btnGuardarFa.Visible = False
        '
        'lblDescripcionE
        '
        Me.lblDescripcionE.AutoSize = True
        Me.lblDescripcionE.Location = New System.Drawing.Point(6, 105)
        Me.lblDescripcionE.Name = "lblDescripcionE"
        Me.lblDescripcionE.Size = New System.Drawing.Size(52, 13)
        Me.lblDescripcionE.TabIndex = 21
        Me.lblDescripcionE.Text = "Direccion"
        '
        'lblnombreE
        '
        Me.lblnombreE.AutoSize = True
        Me.lblnombreE.Location = New System.Drawing.Point(6, 56)
        Me.lblnombreE.Name = "lblnombreE"
        Me.lblnombreE.Size = New System.Drawing.Size(105, 13)
        Me.lblnombreE.TabIndex = 20
        Me.lblnombreE.Text = "Nombre de Farmacia"
        '
        'txtNombreFa
        '
        Me.txtNombreFa.Location = New System.Drawing.Point(9, 72)
        Me.txtNombreFa.Name = "txtNombreFa"
        Me.txtNombreFa.Size = New System.Drawing.Size(166, 20)
        Me.txtNombreFa.TabIndex = 19
        '
        'rbDireccionFa
        '
        Me.rbDireccionFa.Location = New System.Drawing.Point(9, 121)
        Me.rbDireccionFa.Name = "rbDireccionFa"
        Me.rbDireccionFa.Size = New System.Drawing.Size(318, 178)
        Me.rbDireccionFa.TabIndex = 18
        Me.rbDireccionFa.Text = ""
        '
        'lblCodigoFa
        '
        Me.lblCodigoFa.AutoSize = True
        Me.lblCodigoFa.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigoFa.Location = New System.Drawing.Point(292, 29)
        Me.lblCodigoFa.Name = "lblCodigoFa"
        Me.lblCodigoFa.Size = New System.Drawing.Size(18, 20)
        Me.lblCodigoFa.TabIndex = 17
        Me.lblCodigoFa.Text = "0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(199, 29)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 20)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Codigo"
        '
        'dgvFarmacias
        '
        Me.dgvFarmacias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvFarmacias.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        Me.dgvFarmacias.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark
        Me.dgvFarmacias.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvFarmacias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFarmacias.Location = New System.Drawing.Point(368, 124)
        Me.dgvFarmacias.Name = "dgvFarmacias"
        Me.dgvFarmacias.ReadOnly = True
        Me.dgvFarmacias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvFarmacias.Size = New System.Drawing.Size(384, 322)
        Me.dgvFarmacias.TabIndex = 19
        '
        'gbMenuFa
        '
        Me.gbMenuFa.Controls.Add(Me.btnVolverFa)
        Me.gbMenuFa.Controls.Add(Me.btnEliminarFa)
        Me.gbMenuFa.Controls.Add(Me.btnModificarFa)
        Me.gbMenuFa.Controls.Add(Me.btnNuevoFa)
        Me.gbMenuFa.Controls.Add(Me.btnMostrarFa)
        Me.gbMenuFa.Location = New System.Drawing.Point(7, 9)
        Me.gbMenuFa.Name = "gbMenuFa"
        Me.gbMenuFa.Size = New System.Drawing.Size(749, 73)
        Me.gbMenuFa.TabIndex = 18
        Me.gbMenuFa.TabStop = False
        Me.gbMenuFa.Text = "Menu"
        '
        'btnVolverFa
        '
        Me.btnVolverFa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnVolverFa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.btnVolverFa.Image = CType(resources.GetObject("btnVolverFa.Image"), System.Drawing.Image)
        Me.btnVolverFa.Location = New System.Drawing.Point(669, 8)
        Me.btnVolverFa.Name = "btnVolverFa"
        Me.btnVolverFa.Size = New System.Drawing.Size(73, 59)
        Me.btnVolverFa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnVolverFa.TabIndex = 15
        Me.btnVolverFa.TabStop = False
        '
        'btnEliminarFa
        '
        Me.btnEliminarFa.AutoSize = True
        Me.btnEliminarFa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEliminarFa.FlatAppearance.BorderSize = 0
        Me.btnEliminarFa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminarFa.Image = CType(resources.GetObject("btnEliminarFa.Image"), System.Drawing.Image)
        Me.btnEliminarFa.Location = New System.Drawing.Point(495, 17)
        Me.btnEliminarFa.Name = "btnEliminarFa"
        Me.btnEliminarFa.Size = New System.Drawing.Size(156, 41)
        Me.btnEliminarFa.TabIndex = 12
        Me.btnEliminarFa.UseVisualStyleBackColor = True
        '
        'btnModificarFa
        '
        Me.btnModificarFa.AutoSize = True
        Me.btnModificarFa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnModificarFa.FlatAppearance.BorderSize = 0
        Me.btnModificarFa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificarFa.Image = CType(resources.GetObject("btnModificarFa.Image"), System.Drawing.Image)
        Me.btnModificarFa.Location = New System.Drawing.Point(333, 17)
        Me.btnModificarFa.Name = "btnModificarFa"
        Me.btnModificarFa.Size = New System.Drawing.Size(156, 41)
        Me.btnModificarFa.TabIndex = 13
        Me.btnModificarFa.UseVisualStyleBackColor = True
        '
        'btnNuevoFa
        '
        Me.btnNuevoFa.AutoSize = True
        Me.btnNuevoFa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNuevoFa.FlatAppearance.BorderSize = 0
        Me.btnNuevoFa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevoFa.Image = CType(resources.GetObject("btnNuevoFa.Image"), System.Drawing.Image)
        Me.btnNuevoFa.Location = New System.Drawing.Point(171, 17)
        Me.btnNuevoFa.Name = "btnNuevoFa"
        Me.btnNuevoFa.Size = New System.Drawing.Size(156, 41)
        Me.btnNuevoFa.TabIndex = 14
        Me.btnNuevoFa.UseVisualStyleBackColor = True
        '
        'btnMostrarFa
        '
        Me.btnMostrarFa.AutoSize = True
        Me.btnMostrarFa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMostrarFa.FlatAppearance.BorderSize = 0
        Me.btnMostrarFa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMostrarFa.Image = CType(resources.GetObject("btnMostrarFa.Image"), System.Drawing.Image)
        Me.btnMostrarFa.Location = New System.Drawing.Point(9, 17)
        Me.btnMostrarFa.Name = "btnMostrarFa"
        Me.btnMostrarFa.Size = New System.Drawing.Size(156, 41)
        Me.btnMostrarFa.TabIndex = 11
        Me.btnMostrarFa.UseVisualStyleBackColor = True
        '
        'frmFarmacias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(764, 465)
        Me.Controls.Add(Me.lblCatBuscar)
        Me.Controls.Add(Me.cbbBuscarFa)
        Me.Controls.Add(Me.lblBuscar)
        Me.Controls.Add(Me.txtBuscarFa)
        Me.Controls.Add(Me.gbTxtFa)
        Me.Controls.Add(Me.dgvFarmacias)
        Me.Controls.Add(Me.gbMenuFa)
        Me.Name = "frmFarmacias"
        Me.Text = "Farmacias"
        Me.gbTxtFa.ResumeLayout(False)
        Me.gbTxtFa.PerformLayout()
        CType(Me.dgvFarmacias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbMenuFa.ResumeLayout(False)
        Me.gbMenuFa.PerformLayout()
        CType(Me.btnVolverFa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCatBuscar As Label
    Friend WithEvents cbbBuscarFa As ComboBox
    Friend WithEvents lblBuscar As Label
    Friend WithEvents txtBuscarFa As TextBox
    Friend WithEvents gbTxtFa As GroupBox
    Friend WithEvents btnActualizarFa As Button
    Friend WithEvents btnCancelarFa As Button
    Friend WithEvents btnGuardarFa As Button
    Friend WithEvents lblDescripcionE As Label
    Friend WithEvents lblnombreE As Label
    Friend WithEvents txtNombreFa As TextBox
    Friend WithEvents rbDireccionFa As RichTextBox
    Friend WithEvents lblCodigoFa As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents dgvFarmacias As DataGridView
    Friend WithEvents gbMenuFa As GroupBox
    Friend WithEvents btnVolverFa As PictureBox
    Friend WithEvents btnEliminarFa As Button
    Friend WithEvents btnModificarFa As Button
    Friend WithEvents btnNuevoFa As Button
    Friend WithEvents btnMostrarFa As Button
End Class
