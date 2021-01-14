<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEnfermedades
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEnfermedades))
        Me.gbMenuE = New System.Windows.Forms.GroupBox()
        Me.btnVolverE = New System.Windows.Forms.PictureBox()
        Me.btnEliminarE = New System.Windows.Forms.Button()
        Me.btnModificarE = New System.Windows.Forms.Button()
        Me.btnNuevoE = New System.Windows.Forms.Button()
        Me.btnMostrarE = New System.Windows.Forms.Button()
        Me.dgvEnfermedades = New System.Windows.Forms.DataGridView()
        Me.gbTxtE = New System.Windows.Forms.GroupBox()
        Me.btnActualizarE = New System.Windows.Forms.Button()
        Me.btnCancelarE = New System.Windows.Forms.Button()
        Me.btnGuardarE = New System.Windows.Forms.Button()
        Me.lblDescripcionE = New System.Windows.Forms.Label()
        Me.lblnombreE = New System.Windows.Forms.Label()
        Me.txtNombreE = New System.Windows.Forms.TextBox()
        Me.rbDescripcionE = New System.Windows.Forms.RichTextBox()
        Me.lblCodigoE = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblCatBuscar = New System.Windows.Forms.Label()
        Me.cbbBuscarE = New System.Windows.Forms.ComboBox()
        Me.lblBuscar = New System.Windows.Forms.Label()
        Me.txtBuscarE = New System.Windows.Forms.TextBox()
        Me.gbMenuE.SuspendLayout()
        CType(Me.btnVolverE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvEnfermedades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbTxtE.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbMenuE
        '
        Me.gbMenuE.Controls.Add(Me.btnVolverE)
        Me.gbMenuE.Controls.Add(Me.btnEliminarE)
        Me.gbMenuE.Controls.Add(Me.btnModificarE)
        Me.gbMenuE.Controls.Add(Me.btnNuevoE)
        Me.gbMenuE.Controls.Add(Me.btnMostrarE)
        Me.gbMenuE.Location = New System.Drawing.Point(9, 12)
        Me.gbMenuE.Name = "gbMenuE"
        Me.gbMenuE.Size = New System.Drawing.Size(749, 73)
        Me.gbMenuE.TabIndex = 0
        Me.gbMenuE.TabStop = False
        Me.gbMenuE.Text = "Menu"
        '
        'btnVolverE
        '
        Me.btnVolverE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnVolverE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.btnVolverE.Image = CType(resources.GetObject("btnVolverE.Image"), System.Drawing.Image)
        Me.btnVolverE.Location = New System.Drawing.Point(669, 8)
        Me.btnVolverE.Name = "btnVolverE"
        Me.btnVolverE.Size = New System.Drawing.Size(73, 59)
        Me.btnVolverE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnVolverE.TabIndex = 15
        Me.btnVolverE.TabStop = False
        '
        'btnEliminarE
        '
        Me.btnEliminarE.AutoSize = True
        Me.btnEliminarE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEliminarE.FlatAppearance.BorderSize = 0
        Me.btnEliminarE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminarE.Image = CType(resources.GetObject("btnEliminarE.Image"), System.Drawing.Image)
        Me.btnEliminarE.Location = New System.Drawing.Point(495, 17)
        Me.btnEliminarE.Name = "btnEliminarE"
        Me.btnEliminarE.Size = New System.Drawing.Size(156, 41)
        Me.btnEliminarE.TabIndex = 12
        Me.btnEliminarE.UseVisualStyleBackColor = True
        '
        'btnModificarE
        '
        Me.btnModificarE.AutoSize = True
        Me.btnModificarE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnModificarE.FlatAppearance.BorderSize = 0
        Me.btnModificarE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificarE.Image = CType(resources.GetObject("btnModificarE.Image"), System.Drawing.Image)
        Me.btnModificarE.Location = New System.Drawing.Point(333, 17)
        Me.btnModificarE.Name = "btnModificarE"
        Me.btnModificarE.Size = New System.Drawing.Size(156, 41)
        Me.btnModificarE.TabIndex = 13
        Me.btnModificarE.UseVisualStyleBackColor = True
        '
        'btnNuevoE
        '
        Me.btnNuevoE.AutoSize = True
        Me.btnNuevoE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNuevoE.FlatAppearance.BorderSize = 0
        Me.btnNuevoE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevoE.Image = CType(resources.GetObject("btnNuevoE.Image"), System.Drawing.Image)
        Me.btnNuevoE.Location = New System.Drawing.Point(171, 17)
        Me.btnNuevoE.Name = "btnNuevoE"
        Me.btnNuevoE.Size = New System.Drawing.Size(156, 41)
        Me.btnNuevoE.TabIndex = 14
        Me.btnNuevoE.UseVisualStyleBackColor = True
        '
        'btnMostrarE
        '
        Me.btnMostrarE.AutoSize = True
        Me.btnMostrarE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMostrarE.FlatAppearance.BorderSize = 0
        Me.btnMostrarE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMostrarE.Image = CType(resources.GetObject("btnMostrarE.Image"), System.Drawing.Image)
        Me.btnMostrarE.Location = New System.Drawing.Point(9, 17)
        Me.btnMostrarE.Name = "btnMostrarE"
        Me.btnMostrarE.Size = New System.Drawing.Size(156, 41)
        Me.btnMostrarE.TabIndex = 11
        Me.btnMostrarE.UseVisualStyleBackColor = True
        '
        'dgvEnfermedades
        '
        Me.dgvEnfermedades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvEnfermedades.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        Me.dgvEnfermedades.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark
        Me.dgvEnfermedades.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvEnfermedades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEnfermedades.Location = New System.Drawing.Point(374, 133)
        Me.dgvEnfermedades.Name = "dgvEnfermedades"
        Me.dgvEnfermedades.ReadOnly = True
        Me.dgvEnfermedades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEnfermedades.Size = New System.Drawing.Size(384, 322)
        Me.dgvEnfermedades.TabIndex = 2
        Me.dgvEnfermedades.Visible = False
        '
        'gbTxtE
        '
        Me.gbTxtE.Controls.Add(Me.btnActualizarE)
        Me.gbTxtE.Controls.Add(Me.btnCancelarE)
        Me.gbTxtE.Controls.Add(Me.btnGuardarE)
        Me.gbTxtE.Controls.Add(Me.lblDescripcionE)
        Me.gbTxtE.Controls.Add(Me.lblnombreE)
        Me.gbTxtE.Controls.Add(Me.txtNombreE)
        Me.gbTxtE.Controls.Add(Me.rbDescripcionE)
        Me.gbTxtE.Controls.Add(Me.lblCodigoE)
        Me.gbTxtE.Controls.Add(Me.Label9)
        Me.gbTxtE.Enabled = False
        Me.gbTxtE.Location = New System.Drawing.Point(9, 91)
        Me.gbTxtE.Name = "gbTxtE"
        Me.gbTxtE.Size = New System.Drawing.Size(342, 364)
        Me.gbTxtE.TabIndex = 3
        Me.gbTxtE.TabStop = False
        '
        'btnActualizarE
        '
        Me.btnActualizarE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnActualizarE.FlatAppearance.BorderSize = 0
        Me.btnActualizarE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActualizarE.Image = CType(resources.GetObject("btnActualizarE.Image"), System.Drawing.Image)
        Me.btnActualizarE.Location = New System.Drawing.Point(59, 317)
        Me.btnActualizarE.Name = "btnActualizarE"
        Me.btnActualizarE.Size = New System.Drawing.Size(129, 41)
        Me.btnActualizarE.TabIndex = 24
        Me.btnActualizarE.UseVisualStyleBackColor = True
        Me.btnActualizarE.Visible = False
        '
        'btnCancelarE
        '
        Me.btnCancelarE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancelarE.FlatAppearance.BorderSize = 0
        Me.btnCancelarE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelarE.Image = CType(resources.GetObject("btnCancelarE.Image"), System.Drawing.Image)
        Me.btnCancelarE.Location = New System.Drawing.Point(198, 317)
        Me.btnCancelarE.Name = "btnCancelarE"
        Me.btnCancelarE.Size = New System.Drawing.Size(129, 41)
        Me.btnCancelarE.TabIndex = 23
        Me.btnCancelarE.UseVisualStyleBackColor = True
        Me.btnCancelarE.Visible = False
        '
        'btnGuardarE
        '
        Me.btnGuardarE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGuardarE.FlatAppearance.BorderSize = 0
        Me.btnGuardarE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardarE.Image = CType(resources.GetObject("btnGuardarE.Image"), System.Drawing.Image)
        Me.btnGuardarE.Location = New System.Drawing.Point(59, 317)
        Me.btnGuardarE.Name = "btnGuardarE"
        Me.btnGuardarE.Size = New System.Drawing.Size(129, 41)
        Me.btnGuardarE.TabIndex = 22
        Me.btnGuardarE.UseVisualStyleBackColor = True
        Me.btnGuardarE.Visible = False
        '
        'lblDescripcionE
        '
        Me.lblDescripcionE.AutoSize = True
        Me.lblDescripcionE.Location = New System.Drawing.Point(6, 105)
        Me.lblDescripcionE.Name = "lblDescripcionE"
        Me.lblDescripcionE.Size = New System.Drawing.Size(66, 13)
        Me.lblDescripcionE.TabIndex = 21
        Me.lblDescripcionE.Text = "Descripcion "
        '
        'lblnombreE
        '
        Me.lblnombreE.AutoSize = True
        Me.lblnombreE.Location = New System.Drawing.Point(6, 56)
        Me.lblnombreE.Name = "lblnombreE"
        Me.lblnombreE.Size = New System.Drawing.Size(119, 13)
        Me.lblnombreE.TabIndex = 20
        Me.lblnombreE.Text = "Nombre de Enfermedad"
        '
        'txtNombreE
        '
        Me.txtNombreE.Location = New System.Drawing.Point(9, 72)
        Me.txtNombreE.Name = "txtNombreE"
        Me.txtNombreE.Size = New System.Drawing.Size(166, 20)
        Me.txtNombreE.TabIndex = 19
        '
        'rbDescripcionE
        '
        Me.rbDescripcionE.Location = New System.Drawing.Point(9, 121)
        Me.rbDescripcionE.Name = "rbDescripcionE"
        Me.rbDescripcionE.Size = New System.Drawing.Size(318, 178)
        Me.rbDescripcionE.TabIndex = 18
        Me.rbDescripcionE.Text = ""
        '
        'lblCodigoE
        '
        Me.lblCodigoE.AutoSize = True
        Me.lblCodigoE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigoE.Location = New System.Drawing.Point(292, 29)
        Me.lblCodigoE.Name = "lblCodigoE"
        Me.lblCodigoE.Size = New System.Drawing.Size(18, 20)
        Me.lblCodigoE.TabIndex = 17
        Me.lblCodigoE.Text = "0"
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
        'lblCatBuscar
        '
        Me.lblCatBuscar.AutoSize = True
        Me.lblCatBuscar.Location = New System.Drawing.Point(430, 93)
        Me.lblCatBuscar.Name = "lblCatBuscar"
        Me.lblCatBuscar.Size = New System.Drawing.Size(68, 13)
        Me.lblCatBuscar.TabIndex = 17
        Me.lblCatBuscar.Text = "Buscar Por : "
        Me.lblCatBuscar.Visible = False
        '
        'cbbBuscarE
        '
        Me.cbbBuscarE.FormattingEnabled = True
        Me.cbbBuscarE.Items.AddRange(New Object() {"Nombre", "Codigo"})
        Me.cbbBuscarE.Location = New System.Drawing.Point(504, 90)
        Me.cbbBuscarE.Name = "cbbBuscarE"
        Me.cbbBuscarE.Size = New System.Drawing.Size(74, 21)
        Me.cbbBuscarE.TabIndex = 16
        Me.cbbBuscarE.Text = "Nombre"
        Me.cbbBuscarE.Visible = False
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.Location = New System.Drawing.Point(584, 94)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(40, 13)
        Me.lblBuscar.TabIndex = 15
        Me.lblBuscar.Text = "Buscar"
        Me.lblBuscar.Visible = False
        '
        'txtBuscarE
        '
        Me.txtBuscarE.Location = New System.Drawing.Point(630, 91)
        Me.txtBuscarE.Name = "txtBuscarE"
        Me.txtBuscarE.Size = New System.Drawing.Size(128, 20)
        Me.txtBuscarE.TabIndex = 14
        Me.txtBuscarE.Visible = False
        '
        'frmEnfermedades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(769, 475)
        Me.Controls.Add(Me.lblCatBuscar)
        Me.Controls.Add(Me.cbbBuscarE)
        Me.Controls.Add(Me.lblBuscar)
        Me.Controls.Add(Me.txtBuscarE)
        Me.Controls.Add(Me.gbTxtE)
        Me.Controls.Add(Me.dgvEnfermedades)
        Me.Controls.Add(Me.gbMenuE)
        Me.Name = "frmEnfermedades"
        Me.Text = "Enfermedades"
        Me.gbMenuE.ResumeLayout(False)
        Me.gbMenuE.PerformLayout()
        CType(Me.btnVolverE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvEnfermedades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbTxtE.ResumeLayout(False)
        Me.gbTxtE.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbMenuE As GroupBox
    Friend WithEvents btnVolverE As PictureBox
    Friend WithEvents btnEliminarE As Button
    Friend WithEvents btnModificarE As Button
    Friend WithEvents btnNuevoE As Button
    Friend WithEvents btnMostrarE As Button
    Friend WithEvents dgvEnfermedades As DataGridView
    Friend WithEvents gbTxtE As GroupBox
    Friend WithEvents lblCodigoE As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtNombreE As TextBox
    Friend WithEvents rbDescripcionE As RichTextBox
    Friend WithEvents lblnombreE As Label
    Friend WithEvents lblDescripcionE As Label
    Friend WithEvents btnActualizarE As Button
    Friend WithEvents btnCancelarE As Button
    Friend WithEvents btnGuardarE As Button
    Friend WithEvents lblCatBuscar As Label
    Friend WithEvents cbbBuscarE As ComboBox
    Friend WithEvents lblBuscar As Label
    Friend WithEvents txtBuscarE As TextBox
End Class
