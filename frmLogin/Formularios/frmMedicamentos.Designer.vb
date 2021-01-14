<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMedicamentos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMedicamentos))
        Me.lblCatBuscar = New System.Windows.Forms.Label()
        Me.cbbBuscarMt = New System.Windows.Forms.ComboBox()
        Me.lblBuscar = New System.Windows.Forms.Label()
        Me.txtBuscarMt = New System.Windows.Forms.TextBox()
        Me.gbTxtMt = New System.Windows.Forms.GroupBox()
        Me.txtCoste = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbbEnfermedad = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbbProveedorMt = New System.Windows.Forms.ComboBox()
        Me.btnActualizarMt = New System.Windows.Forms.Button()
        Me.btnCancelarMt = New System.Windows.Forms.Button()
        Me.btnGuardarMt = New System.Windows.Forms.Button()
        Me.lblDescripcionE = New System.Windows.Forms.Label()
        Me.lblnombreE = New System.Windows.Forms.Label()
        Me.txtNombreMt = New System.Windows.Forms.TextBox()
        Me.rbDescripcionMt = New System.Windows.Forms.RichTextBox()
        Me.lblCodigoMt = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dgvMedicamentos = New System.Windows.Forms.DataGridView()
        Me.gbMenuMt = New System.Windows.Forms.GroupBox()
        Me.btnRegresarMt = New System.Windows.Forms.PictureBox()
        Me.btnEliminarMt = New System.Windows.Forms.Button()
        Me.btnModificarMt = New System.Windows.Forms.Button()
        Me.btnNuevoMt = New System.Windows.Forms.Button()
        Me.btnMostrarMt = New System.Windows.Forms.Button()
        Me.gbTxtMt.SuspendLayout()
        CType(Me.dgvMedicamentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbMenuMt.SuspendLayout()
        CType(Me.btnRegresarMt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCatBuscar
        '
        Me.lblCatBuscar.AutoSize = True
        Me.lblCatBuscar.Location = New System.Drawing.Point(369, 79)
        Me.lblCatBuscar.Name = "lblCatBuscar"
        Me.lblCatBuscar.Size = New System.Drawing.Size(68, 13)
        Me.lblCatBuscar.TabIndex = 31
        Me.lblCatBuscar.Text = "Buscar Por : "
        Me.lblCatBuscar.Visible = False
        '
        'cbbBuscarMt
        '
        Me.cbbBuscarMt.FormattingEnabled = True
        Me.cbbBuscarMt.Items.AddRange(New Object() {"Nombre Medicamento", "Proveedor"})
        Me.cbbBuscarMt.Location = New System.Drawing.Point(443, 76)
        Me.cbbBuscarMt.Name = "cbbBuscarMt"
        Me.cbbBuscarMt.Size = New System.Drawing.Size(137, 21)
        Me.cbbBuscarMt.TabIndex = 30
        Me.cbbBuscarMt.Text = "Nombre Medicamento"
        Me.cbbBuscarMt.Visible = False
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.Location = New System.Drawing.Point(586, 80)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(40, 13)
        Me.lblBuscar.TabIndex = 29
        Me.lblBuscar.Text = "Buscar"
        Me.lblBuscar.Visible = False
        '
        'txtBuscarMt
        '
        Me.txtBuscarMt.Location = New System.Drawing.Point(632, 77)
        Me.txtBuscarMt.Name = "txtBuscarMt"
        Me.txtBuscarMt.Size = New System.Drawing.Size(128, 20)
        Me.txtBuscarMt.TabIndex = 28
        Me.txtBuscarMt.Visible = False
        '
        'gbTxtMt
        '
        Me.gbTxtMt.Controls.Add(Me.txtCoste)
        Me.gbTxtMt.Controls.Add(Me.Label3)
        Me.gbTxtMt.Controls.Add(Me.cbbEnfermedad)
        Me.gbTxtMt.Controls.Add(Me.Label2)
        Me.gbTxtMt.Controls.Add(Me.Label1)
        Me.gbTxtMt.Controls.Add(Me.cbbProveedorMt)
        Me.gbTxtMt.Controls.Add(Me.btnActualizarMt)
        Me.gbTxtMt.Controls.Add(Me.btnCancelarMt)
        Me.gbTxtMt.Controls.Add(Me.btnGuardarMt)
        Me.gbTxtMt.Controls.Add(Me.lblDescripcionE)
        Me.gbTxtMt.Controls.Add(Me.lblnombreE)
        Me.gbTxtMt.Controls.Add(Me.txtNombreMt)
        Me.gbTxtMt.Controls.Add(Me.rbDescripcionMt)
        Me.gbTxtMt.Controls.Add(Me.lblCodigoMt)
        Me.gbTxtMt.Controls.Add(Me.Label9)
        Me.gbTxtMt.Enabled = False
        Me.gbTxtMt.Location = New System.Drawing.Point(11, 77)
        Me.gbTxtMt.Name = "gbTxtMt"
        Me.gbTxtMt.Size = New System.Drawing.Size(342, 364)
        Me.gbTxtMt.TabIndex = 27
        Me.gbTxtMt.TabStop = False
        '
        'txtCoste
        '
        Me.txtCoste.Location = New System.Drawing.Point(126, 234)
        Me.txtCoste.Name = "txtCoste"
        Me.txtCoste.Size = New System.Drawing.Size(90, 20)
        Me.txtCoste.TabIndex = 30
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(79, 237)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Costo"
        '
        'cbbEnfermedad
        '
        Me.cbbEnfermedad.FormattingEnabled = True
        Me.cbbEnfermedad.Location = New System.Drawing.Point(126, 203)
        Me.cbbEnfermedad.Name = "cbbEnfermedad"
        Me.cbbEnfermedad.Size = New System.Drawing.Size(201, 21)
        Me.cbbEnfermedad.TabIndex = 28
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 203)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Enfermedad Principal"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 264)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Proveedor/Farmacia"
        '
        'cbbProveedorMt
        '
        Me.cbbProveedorMt.FormattingEnabled = True
        Me.cbbProveedorMt.Location = New System.Drawing.Point(126, 264)
        Me.cbbProveedorMt.Name = "cbbProveedorMt"
        Me.cbbProveedorMt.Size = New System.Drawing.Size(201, 21)
        Me.cbbProveedorMt.TabIndex = 25
        '
        'btnActualizarMt
        '
        Me.btnActualizarMt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnActualizarMt.FlatAppearance.BorderSize = 0
        Me.btnActualizarMt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActualizarMt.Image = CType(resources.GetObject("btnActualizarMt.Image"), System.Drawing.Image)
        Me.btnActualizarMt.Location = New System.Drawing.Point(63, 317)
        Me.btnActualizarMt.Name = "btnActualizarMt"
        Me.btnActualizarMt.Size = New System.Drawing.Size(129, 41)
        Me.btnActualizarMt.TabIndex = 24
        Me.btnActualizarMt.UseVisualStyleBackColor = True
        Me.btnActualizarMt.Visible = False
        '
        'btnCancelarMt
        '
        Me.btnCancelarMt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancelarMt.FlatAppearance.BorderSize = 0
        Me.btnCancelarMt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelarMt.Image = CType(resources.GetObject("btnCancelarMt.Image"), System.Drawing.Image)
        Me.btnCancelarMt.Location = New System.Drawing.Point(198, 317)
        Me.btnCancelarMt.Name = "btnCancelarMt"
        Me.btnCancelarMt.Size = New System.Drawing.Size(129, 41)
        Me.btnCancelarMt.TabIndex = 23
        Me.btnCancelarMt.UseVisualStyleBackColor = True
        Me.btnCancelarMt.Visible = False
        '
        'btnGuardarMt
        '
        Me.btnGuardarMt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGuardarMt.FlatAppearance.BorderSize = 0
        Me.btnGuardarMt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardarMt.Image = CType(resources.GetObject("btnGuardarMt.Image"), System.Drawing.Image)
        Me.btnGuardarMt.Location = New System.Drawing.Point(63, 317)
        Me.btnGuardarMt.Name = "btnGuardarMt"
        Me.btnGuardarMt.Size = New System.Drawing.Size(129, 41)
        Me.btnGuardarMt.TabIndex = 22
        Me.btnGuardarMt.UseVisualStyleBackColor = True
        Me.btnGuardarMt.Visible = False
        '
        'lblDescripcionE
        '
        Me.lblDescripcionE.AutoSize = True
        Me.lblDescripcionE.Location = New System.Drawing.Point(6, 83)
        Me.lblDescripcionE.Name = "lblDescripcionE"
        Me.lblDescripcionE.Size = New System.Drawing.Size(63, 13)
        Me.lblDescripcionE.TabIndex = 21
        Me.lblDescripcionE.Text = "Descripcion"
        '
        'lblnombreE
        '
        Me.lblnombreE.AutoSize = True
        Me.lblnombreE.Location = New System.Drawing.Point(6, 36)
        Me.lblnombreE.Name = "lblnombreE"
        Me.lblnombreE.Size = New System.Drawing.Size(126, 13)
        Me.lblnombreE.TabIndex = 20
        Me.lblnombreE.Text = "Nombre de Medicamento"
        '
        'txtNombreMt
        '
        Me.txtNombreMt.Location = New System.Drawing.Point(9, 52)
        Me.txtNombreMt.Name = "txtNombreMt"
        Me.txtNombreMt.Size = New System.Drawing.Size(166, 20)
        Me.txtNombreMt.TabIndex = 19
        '
        'rbDescripcionMt
        '
        Me.rbDescripcionMt.Location = New System.Drawing.Point(9, 99)
        Me.rbDescripcionMt.Name = "rbDescripcionMt"
        Me.rbDescripcionMt.Size = New System.Drawing.Size(318, 74)
        Me.rbDescripcionMt.TabIndex = 18
        Me.rbDescripcionMt.Text = ""
        '
        'lblCodigoMt
        '
        Me.lblCodigoMt.AutoSize = True
        Me.lblCodigoMt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigoMt.Location = New System.Drawing.Point(307, 16)
        Me.lblCodigoMt.Name = "lblCodigoMt"
        Me.lblCodigoMt.Size = New System.Drawing.Size(18, 20)
        Me.lblCodigoMt.TabIndex = 17
        Me.lblCodigoMt.Text = "0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(214, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 20)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Codigo"
        '
        'dgvMedicamentos
        '
        Me.dgvMedicamentos.AllowUserToAddRows = False
        Me.dgvMedicamentos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvMedicamentos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        Me.dgvMedicamentos.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark
        Me.dgvMedicamentos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvMedicamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMedicamentos.Location = New System.Drawing.Point(372, 113)
        Me.dgvMedicamentos.Name = "dgvMedicamentos"
        Me.dgvMedicamentos.ReadOnly = True
        Me.dgvMedicamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMedicamentos.Size = New System.Drawing.Size(384, 322)
        Me.dgvMedicamentos.TabIndex = 26
        '
        'gbMenuMt
        '
        Me.gbMenuMt.Controls.Add(Me.btnRegresarMt)
        Me.gbMenuMt.Controls.Add(Me.btnEliminarMt)
        Me.gbMenuMt.Controls.Add(Me.btnModificarMt)
        Me.gbMenuMt.Controls.Add(Me.btnNuevoMt)
        Me.gbMenuMt.Controls.Add(Me.btnMostrarMt)
        Me.gbMenuMt.Location = New System.Drawing.Point(11, 4)
        Me.gbMenuMt.Name = "gbMenuMt"
        Me.gbMenuMt.Size = New System.Drawing.Size(749, 73)
        Me.gbMenuMt.TabIndex = 25
        Me.gbMenuMt.TabStop = False
        Me.gbMenuMt.Text = "Menu"
        '
        'btnRegresarMt
        '
        Me.btnRegresarMt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRegresarMt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.btnRegresarMt.Image = CType(resources.GetObject("btnRegresarMt.Image"), System.Drawing.Image)
        Me.btnRegresarMt.Location = New System.Drawing.Point(669, 8)
        Me.btnRegresarMt.Name = "btnRegresarMt"
        Me.btnRegresarMt.Size = New System.Drawing.Size(73, 59)
        Me.btnRegresarMt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnRegresarMt.TabIndex = 15
        Me.btnRegresarMt.TabStop = False
        '
        'btnEliminarMt
        '
        Me.btnEliminarMt.AutoSize = True
        Me.btnEliminarMt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEliminarMt.FlatAppearance.BorderSize = 0
        Me.btnEliminarMt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminarMt.Image = CType(resources.GetObject("btnEliminarMt.Image"), System.Drawing.Image)
        Me.btnEliminarMt.Location = New System.Drawing.Point(495, 17)
        Me.btnEliminarMt.Name = "btnEliminarMt"
        Me.btnEliminarMt.Size = New System.Drawing.Size(156, 41)
        Me.btnEliminarMt.TabIndex = 12
        Me.btnEliminarMt.UseVisualStyleBackColor = True
        '
        'btnModificarMt
        '
        Me.btnModificarMt.AutoSize = True
        Me.btnModificarMt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnModificarMt.FlatAppearance.BorderSize = 0
        Me.btnModificarMt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificarMt.Image = CType(resources.GetObject("btnModificarMt.Image"), System.Drawing.Image)
        Me.btnModificarMt.Location = New System.Drawing.Point(333, 17)
        Me.btnModificarMt.Name = "btnModificarMt"
        Me.btnModificarMt.Size = New System.Drawing.Size(156, 41)
        Me.btnModificarMt.TabIndex = 13
        Me.btnModificarMt.UseVisualStyleBackColor = True
        '
        'btnNuevoMt
        '
        Me.btnNuevoMt.AutoSize = True
        Me.btnNuevoMt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNuevoMt.FlatAppearance.BorderSize = 0
        Me.btnNuevoMt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevoMt.Image = CType(resources.GetObject("btnNuevoMt.Image"), System.Drawing.Image)
        Me.btnNuevoMt.Location = New System.Drawing.Point(171, 17)
        Me.btnNuevoMt.Name = "btnNuevoMt"
        Me.btnNuevoMt.Size = New System.Drawing.Size(156, 41)
        Me.btnNuevoMt.TabIndex = 14
        Me.btnNuevoMt.UseVisualStyleBackColor = True
        '
        'btnMostrarMt
        '
        Me.btnMostrarMt.AutoSize = True
        Me.btnMostrarMt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMostrarMt.FlatAppearance.BorderSize = 0
        Me.btnMostrarMt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMostrarMt.Image = CType(resources.GetObject("btnMostrarMt.Image"), System.Drawing.Image)
        Me.btnMostrarMt.Location = New System.Drawing.Point(9, 17)
        Me.btnMostrarMt.Name = "btnMostrarMt"
        Me.btnMostrarMt.Size = New System.Drawing.Size(156, 41)
        Me.btnMostrarMt.TabIndex = 11
        Me.btnMostrarMt.UseVisualStyleBackColor = True
        '
        'frmMedicamentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(770, 439)
        Me.Controls.Add(Me.lblCatBuscar)
        Me.Controls.Add(Me.cbbBuscarMt)
        Me.Controls.Add(Me.lblBuscar)
        Me.Controls.Add(Me.txtBuscarMt)
        Me.Controls.Add(Me.gbTxtMt)
        Me.Controls.Add(Me.dgvMedicamentos)
        Me.Controls.Add(Me.gbMenuMt)
        Me.Name = "frmMedicamentos"
        Me.Text = "Medicamentos"
        Me.gbTxtMt.ResumeLayout(False)
        Me.gbTxtMt.PerformLayout()
        CType(Me.dgvMedicamentos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbMenuMt.ResumeLayout(False)
        Me.gbMenuMt.PerformLayout()
        CType(Me.btnRegresarMt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCatBuscar As Label
    Friend WithEvents cbbBuscarMt As ComboBox
    Friend WithEvents lblBuscar As Label
    Friend WithEvents txtBuscarMt As TextBox
    Friend WithEvents gbTxtMt As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbbProveedorMt As ComboBox
    Friend WithEvents btnActualizarMt As Button
    Friend WithEvents btnCancelarMt As Button
    Friend WithEvents btnGuardarMt As Button
    Friend WithEvents lblDescripcionE As Label
    Friend WithEvents lblnombreE As Label
    Friend WithEvents txtNombreMt As TextBox
    Friend WithEvents rbDescripcionMt As RichTextBox
    Friend WithEvents lblCodigoMt As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents dgvMedicamentos As DataGridView
    Friend WithEvents gbMenuMt As GroupBox
    Friend WithEvents btnRegresarMt As PictureBox
    Friend WithEvents btnEliminarMt As Button
    Friend WithEvents btnModificarMt As Button
    Friend WithEvents btnNuevoMt As Button
    Friend WithEvents btnMostrarMt As Button
    Friend WithEvents txtCoste As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cbbEnfermedad As ComboBox
    Friend WithEvents Label2 As Label
End Class
