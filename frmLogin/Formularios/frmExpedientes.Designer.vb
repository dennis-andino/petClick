<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExpedientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmExpedientes))
        Me.gbMenuEx = New System.Windows.Forms.GroupBox()
        Me.btnEliminarEx = New System.Windows.Forms.Button()
        Me.btnVolverEx = New System.Windows.Forms.PictureBox()
        Me.btnModificarEx = New System.Windows.Forms.Button()
        Me.btnNuevoEx = New System.Windows.Forms.Button()
        Me.btnMostrarEx = New System.Windows.Forms.Button()
        Me.gbtxtEx = New System.Windows.Forms.GroupBox()
        Me.txtSangreEx = New System.Windows.Forms.TextBox()
        Me.cbbSexoEx = New System.Windows.Forms.ComboBox()
        Me.rtbotrosEx = New System.Windows.Forms.RichTextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtpesoEx = New System.Windows.Forms.TextBox()
        Me.dtpfechnacEx = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbbrazaEX = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblEspecialidades = New System.Windows.Forms.Label()
        Me.cbbfamiliaEx = New System.Windows.Forms.ComboBox()
        Me.lblCodigoEx = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblduenho = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txthabitatEx = New System.Windows.Forms.TextBox()
        Me.txtduenoEX = New System.Windows.Forms.TextBox()
        Me.txtcolorEx = New System.Windows.Forms.TextBox()
        Me.txtNombreEx = New System.Windows.Forms.TextBox()
        Me.lblCatBuscar = New System.Windows.Forms.Label()
        Me.cbbBuscarEx = New System.Windows.Forms.ComboBox()
        Me.btnActualizarEx = New System.Windows.Forms.Button()
        Me.lblBuscar = New System.Windows.Forms.Label()
        Me.txtBuscarEx = New System.Windows.Forms.TextBox()
        Me.btnCancelarEx = New System.Windows.Forms.Button()
        Me.btnGuardarEx = New System.Windows.Forms.Button()
        Me.dgvExpedientes = New System.Windows.Forms.DataGridView()
        Me.btnBuscarCliId = New System.Windows.Forms.Button()
        Me.gbMenuEx.SuspendLayout()
        CType(Me.btnVolverEx, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbtxtEx.SuspendLayout()
        CType(Me.dgvExpedientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbMenuEx
        '
        Me.gbMenuEx.Controls.Add(Me.btnEliminarEx)
        Me.gbMenuEx.Controls.Add(Me.btnVolverEx)
        Me.gbMenuEx.Controls.Add(Me.btnModificarEx)
        Me.gbMenuEx.Controls.Add(Me.btnNuevoEx)
        Me.gbMenuEx.Controls.Add(Me.btnMostrarEx)
        Me.gbMenuEx.Location = New System.Drawing.Point(13, 12)
        Me.gbMenuEx.Name = "gbMenuEx"
        Me.gbMenuEx.Size = New System.Drawing.Size(867, 73)
        Me.gbMenuEx.TabIndex = 30
        Me.gbMenuEx.TabStop = False
        Me.gbMenuEx.Text = "Menu"
        '
        'btnEliminarEx
        '
        Me.btnEliminarEx.AutoSize = True
        Me.btnEliminarEx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEliminarEx.FlatAppearance.BorderSize = 0
        Me.btnEliminarEx.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminarEx.Image = CType(resources.GetObject("btnEliminarEx.Image"), System.Drawing.Image)
        Me.btnEliminarEx.Location = New System.Drawing.Point(543, 18)
        Me.btnEliminarEx.Name = "btnEliminarEx"
        Me.btnEliminarEx.Size = New System.Drawing.Size(156, 41)
        Me.btnEliminarEx.TabIndex = 16
        Me.btnEliminarEx.UseVisualStyleBackColor = True
        '
        'btnVolverEx
        '
        Me.btnVolverEx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnVolverEx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.btnVolverEx.Image = CType(resources.GetObject("btnVolverEx.Image"), System.Drawing.Image)
        Me.btnVolverEx.Location = New System.Drawing.Point(770, 8)
        Me.btnVolverEx.Name = "btnVolverEx"
        Me.btnVolverEx.Size = New System.Drawing.Size(73, 59)
        Me.btnVolverEx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnVolverEx.TabIndex = 29
        Me.btnVolverEx.TabStop = False
        '
        'btnModificarEx
        '
        Me.btnModificarEx.AutoSize = True
        Me.btnModificarEx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnModificarEx.FlatAppearance.BorderSize = 0
        Me.btnModificarEx.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificarEx.Image = CType(resources.GetObject("btnModificarEx.Image"), System.Drawing.Image)
        Me.btnModificarEx.Location = New System.Drawing.Point(366, 18)
        Me.btnModificarEx.Name = "btnModificarEx"
        Me.btnModificarEx.Size = New System.Drawing.Size(156, 41)
        Me.btnModificarEx.TabIndex = 17
        Me.btnModificarEx.UseVisualStyleBackColor = True
        '
        'btnNuevoEx
        '
        Me.btnNuevoEx.AutoSize = True
        Me.btnNuevoEx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNuevoEx.FlatAppearance.BorderSize = 0
        Me.btnNuevoEx.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevoEx.Image = CType(resources.GetObject("btnNuevoEx.Image"), System.Drawing.Image)
        Me.btnNuevoEx.Location = New System.Drawing.Point(189, 19)
        Me.btnNuevoEx.Name = "btnNuevoEx"
        Me.btnNuevoEx.Size = New System.Drawing.Size(156, 41)
        Me.btnNuevoEx.TabIndex = 18
        Me.btnNuevoEx.UseVisualStyleBackColor = True
        '
        'btnMostrarEx
        '
        Me.btnMostrarEx.AutoSize = True
        Me.btnMostrarEx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMostrarEx.FlatAppearance.BorderSize = 0
        Me.btnMostrarEx.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMostrarEx.Image = CType(resources.GetObject("btnMostrarEx.Image"), System.Drawing.Image)
        Me.btnMostrarEx.Location = New System.Drawing.Point(12, 19)
        Me.btnMostrarEx.Name = "btnMostrarEx"
        Me.btnMostrarEx.Size = New System.Drawing.Size(156, 41)
        Me.btnMostrarEx.TabIndex = 14
        Me.btnMostrarEx.UseVisualStyleBackColor = True
        '
        'gbtxtEx
        '
        Me.gbtxtEx.Controls.Add(Me.btnBuscarCliId)
        Me.gbtxtEx.Controls.Add(Me.txtSangreEx)
        Me.gbtxtEx.Controls.Add(Me.cbbSexoEx)
        Me.gbtxtEx.Controls.Add(Me.rtbotrosEx)
        Me.gbtxtEx.Controls.Add(Me.Label12)
        Me.gbtxtEx.Controls.Add(Me.txtpesoEx)
        Me.gbtxtEx.Controls.Add(Me.dtpfechnacEx)
        Me.gbtxtEx.Controls.Add(Me.Label11)
        Me.gbtxtEx.Controls.Add(Me.Label10)
        Me.gbtxtEx.Controls.Add(Me.cbbrazaEX)
        Me.gbtxtEx.Controls.Add(Me.Label8)
        Me.gbtxtEx.Controls.Add(Me.Label4)
        Me.gbtxtEx.Controls.Add(Me.lblEspecialidades)
        Me.gbtxtEx.Controls.Add(Me.cbbfamiliaEx)
        Me.gbtxtEx.Controls.Add(Me.lblCodigoEx)
        Me.gbtxtEx.Controls.Add(Me.Label9)
        Me.gbtxtEx.Controls.Add(Me.Label7)
        Me.gbtxtEx.Controls.Add(Me.Label5)
        Me.gbtxtEx.Controls.Add(Me.Label3)
        Me.gbtxtEx.Controls.Add(Me.lblduenho)
        Me.gbtxtEx.Controls.Add(Me.Label1)
        Me.gbtxtEx.Controls.Add(Me.txthabitatEx)
        Me.gbtxtEx.Controls.Add(Me.txtduenoEX)
        Me.gbtxtEx.Controls.Add(Me.txtcolorEx)
        Me.gbtxtEx.Controls.Add(Me.txtNombreEx)
        Me.gbtxtEx.Enabled = False
        Me.gbtxtEx.Location = New System.Drawing.Point(13, 104)
        Me.gbtxtEx.Name = "gbtxtEx"
        Me.gbtxtEx.Size = New System.Drawing.Size(345, 399)
        Me.gbtxtEx.TabIndex = 32
        Me.gbtxtEx.TabStop = False
        Me.gbtxtEx.Text = "Expediente"
        '
        'txtSangreEx
        '
        Me.txtSangreEx.Location = New System.Drawing.Point(248, 120)
        Me.txtSangreEx.Name = "txtSangreEx"
        Me.txtSangreEx.Size = New System.Drawing.Size(80, 20)
        Me.txtSangreEx.TabIndex = 30
        '
        'cbbSexoEx
        '
        Me.cbbSexoEx.AutoCompleteCustomSource.AddRange(New String() {"M", "F"})
        Me.cbbSexoEx.FormattingEnabled = True
        Me.cbbSexoEx.Items.AddRange(New Object() {"M", "F"})
        Me.cbbSexoEx.Location = New System.Drawing.Point(289, 67)
        Me.cbbSexoEx.Name = "cbbSexoEx"
        Me.cbbSexoEx.Size = New System.Drawing.Size(45, 21)
        Me.cbbSexoEx.TabIndex = 29
        Me.cbbSexoEx.Text = "-"
        '
        'rtbotrosEx
        '
        Me.rtbotrosEx.Location = New System.Drawing.Point(9, 282)
        Me.rtbotrosEx.Name = "rtbotrosEx"
        Me.rtbotrosEx.Size = New System.Drawing.Size(324, 111)
        Me.rtbotrosEx.TabIndex = 28
        Me.rtbotrosEx.Text = ""
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(9, 214)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(54, 13)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "Peso(Lbs)"
        '
        'txtpesoEx
        '
        Me.txtpesoEx.Location = New System.Drawing.Point(9, 230)
        Me.txtpesoEx.Name = "txtpesoEx"
        Me.txtpesoEx.Size = New System.Drawing.Size(107, 20)
        Me.txtpesoEx.TabIndex = 25
        '
        'dtpfechnacEx
        '
        Me.dtpfechnacEx.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfechnacEx.Location = New System.Drawing.Point(9, 174)
        Me.dtpfechnacEx.Name = "dtpfechnacEx"
        Me.dtpfechnacEx.Size = New System.Drawing.Size(209, 20)
        Me.dtpfechnacEx.TabIndex = 24
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(7, 157)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(108, 13)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Fecha de Nacimiento"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(241, 103)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 13)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Tipo de Sangre"
        '
        'cbbrazaEX
        '
        Me.cbbrazaEX.FormattingEnabled = True
        Me.cbbrazaEX.Location = New System.Drawing.Point(126, 119)
        Me.cbbrazaEX.Name = "cbbrazaEX"
        Me.cbbrazaEX.Size = New System.Drawing.Size(111, 21)
        Me.cbbrazaEX.TabIndex = 20
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(126, 103)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Raza"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 103)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Familia"
        '
        'lblEspecialidades
        '
        Me.lblEspecialidades.AutoSize = True
        Me.lblEspecialidades.Location = New System.Drawing.Point(287, 51)
        Me.lblEspecialidades.Name = "lblEspecialidades"
        Me.lblEspecialidades.Size = New System.Drawing.Size(31, 13)
        Me.lblEspecialidades.TabIndex = 17
        Me.lblEspecialidades.Text = "Sexo"
        '
        'cbbfamiliaEx
        '
        Me.cbbfamiliaEx.FormattingEnabled = True
        Me.cbbfamiliaEx.Location = New System.Drawing.Point(9, 119)
        Me.cbbfamiliaEx.Name = "cbbfamiliaEx"
        Me.cbbfamiliaEx.Size = New System.Drawing.Size(111, 21)
        Me.cbbfamiliaEx.TabIndex = 16
        '
        'lblCodigoEx
        '
        Me.lblCodigoEx.AutoSize = True
        Me.lblCodigoEx.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigoEx.Location = New System.Drawing.Point(313, 16)
        Me.lblCodigoEx.Name = "lblCodigoEx"
        Me.lblCodigoEx.Size = New System.Drawing.Size(18, 20)
        Me.lblCodigoEx.TabIndex = 15
        Me.lblCodigoEx.Text = "0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(220, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 20)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Codigo"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 266)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Otra Informacion"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(124, 214)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Habitat"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(221, 157)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Descripcion Color"
        '
        'lblduenho
        '
        Me.lblduenho.AutoSize = True
        Me.lblduenho.Location = New System.Drawing.Point(126, 51)
        Me.lblduenho.Name = "lblduenho"
        Me.lblduenho.Size = New System.Drawing.Size(69, 13)
        Me.lblduenho.TabIndex = 8
        Me.lblduenho.Text = "Pertenece A:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Nombre de Mascota"
        '
        'txthabitatEx
        '
        Me.txthabitatEx.Location = New System.Drawing.Point(122, 230)
        Me.txthabitatEx.Name = "txthabitatEx"
        Me.txthabitatEx.Size = New System.Drawing.Size(110, 20)
        Me.txthabitatEx.TabIndex = 6
        '
        'txtduenoEX
        '
        Me.txtduenoEX.Enabled = False
        Me.txtduenoEX.Location = New System.Drawing.Point(129, 67)
        Me.txtduenoEX.Name = "txtduenoEX"
        Me.txtduenoEX.Size = New System.Drawing.Size(132, 20)
        Me.txtduenoEX.TabIndex = 3
        '
        'txtcolorEx
        '
        Me.txtcolorEx.Location = New System.Drawing.Point(224, 174)
        Me.txtcolorEx.Name = "txtcolorEx"
        Me.txtcolorEx.Size = New System.Drawing.Size(110, 20)
        Me.txtcolorEx.TabIndex = 2
        '
        'txtNombreEx
        '
        Me.txtNombreEx.Location = New System.Drawing.Point(9, 67)
        Me.txtNombreEx.Name = "txtNombreEx"
        Me.txtNombreEx.Size = New System.Drawing.Size(111, 20)
        Me.txtNombreEx.TabIndex = 0
        '
        'lblCatBuscar
        '
        Me.lblCatBuscar.AutoSize = True
        Me.lblCatBuscar.Location = New System.Drawing.Point(553, 104)
        Me.lblCatBuscar.Name = "lblCatBuscar"
        Me.lblCatBuscar.Size = New System.Drawing.Size(60, 13)
        Me.lblCatBuscar.TabIndex = 39
        Me.lblCatBuscar.Text = "Filtrar Por : "
        Me.lblCatBuscar.Visible = False
        '
        'cbbBuscarEx
        '
        Me.cbbBuscarEx.FormattingEnabled = True
        Me.cbbBuscarEx.Items.AddRange(New Object() {"Mascota", "Cliente"})
        Me.cbbBuscarEx.Location = New System.Drawing.Point(627, 101)
        Me.cbbBuscarEx.Name = "cbbBuscarEx"
        Me.cbbBuscarEx.Size = New System.Drawing.Size(74, 21)
        Me.cbbBuscarEx.TabIndex = 38
        Me.cbbBuscarEx.Text = "Cliente"
        Me.cbbBuscarEx.Visible = False
        '
        'btnActualizarEx
        '
        Me.btnActualizarEx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnActualizarEx.FlatAppearance.BorderSize = 0
        Me.btnActualizarEx.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActualizarEx.Image = CType(resources.GetObject("btnActualizarEx.Image"), System.Drawing.Image)
        Me.btnActualizarEx.Location = New System.Drawing.Point(364, 462)
        Me.btnActualizarEx.Name = "btnActualizarEx"
        Me.btnActualizarEx.Size = New System.Drawing.Size(129, 41)
        Me.btnActualizarEx.TabIndex = 37
        Me.btnActualizarEx.UseVisualStyleBackColor = True
        Me.btnActualizarEx.Visible = False
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.Location = New System.Drawing.Point(707, 105)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(40, 13)
        Me.lblBuscar.TabIndex = 36
        Me.lblBuscar.Text = "Buscar"
        Me.lblBuscar.Visible = False
        '
        'txtBuscarEx
        '
        Me.txtBuscarEx.Location = New System.Drawing.Point(753, 102)
        Me.txtBuscarEx.Name = "txtBuscarEx"
        Me.txtBuscarEx.Size = New System.Drawing.Size(129, 20)
        Me.txtBuscarEx.TabIndex = 35
        Me.txtBuscarEx.Visible = False
        '
        'btnCancelarEx
        '
        Me.btnCancelarEx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancelarEx.FlatAppearance.BorderSize = 0
        Me.btnCancelarEx.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelarEx.Image = CType(resources.GetObject("btnCancelarEx.Image"), System.Drawing.Image)
        Me.btnCancelarEx.Location = New System.Drawing.Point(499, 462)
        Me.btnCancelarEx.Name = "btnCancelarEx"
        Me.btnCancelarEx.Size = New System.Drawing.Size(129, 41)
        Me.btnCancelarEx.TabIndex = 34
        Me.btnCancelarEx.UseVisualStyleBackColor = True
        Me.btnCancelarEx.Visible = False
        '
        'btnGuardarEx
        '
        Me.btnGuardarEx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGuardarEx.FlatAppearance.BorderSize = 0
        Me.btnGuardarEx.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardarEx.Image = CType(resources.GetObject("btnGuardarEx.Image"), System.Drawing.Image)
        Me.btnGuardarEx.Location = New System.Drawing.Point(364, 462)
        Me.btnGuardarEx.Name = "btnGuardarEx"
        Me.btnGuardarEx.Size = New System.Drawing.Size(129, 41)
        Me.btnGuardarEx.TabIndex = 33
        Me.btnGuardarEx.UseVisualStyleBackColor = True
        Me.btnGuardarEx.Visible = False
        '
        'dgvExpedientes
        '
        Me.dgvExpedientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvExpedientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        Me.dgvExpedientes.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark
        Me.dgvExpedientes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvExpedientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvExpedientes.Location = New System.Drawing.Point(364, 128)
        Me.dgvExpedientes.Name = "dgvExpedientes"
        Me.dgvExpedientes.ReadOnly = True
        Me.dgvExpedientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvExpedientes.Size = New System.Drawing.Size(518, 328)
        Me.dgvExpedientes.TabIndex = 31
        '
        'btnBuscarCliId
        '
        Me.btnBuscarCliId.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBuscarCliId.Image = CType(resources.GetObject("btnBuscarCliId.Image"), System.Drawing.Image)
        Me.btnBuscarCliId.Location = New System.Drawing.Point(261, 67)
        Me.btnBuscarCliId.Name = "btnBuscarCliId"
        Me.btnBuscarCliId.Size = New System.Drawing.Size(24, 21)
        Me.btnBuscarCliId.TabIndex = 31
        Me.btnBuscarCliId.UseVisualStyleBackColor = True
        '
        'frmExpedientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(892, 515)
        Me.Controls.Add(Me.gbtxtEx)
        Me.Controls.Add(Me.lblCatBuscar)
        Me.Controls.Add(Me.cbbBuscarEx)
        Me.Controls.Add(Me.btnActualizarEx)
        Me.Controls.Add(Me.lblBuscar)
        Me.Controls.Add(Me.txtBuscarEx)
        Me.Controls.Add(Me.btnCancelarEx)
        Me.Controls.Add(Me.btnGuardarEx)
        Me.Controls.Add(Me.dgvExpedientes)
        Me.Controls.Add(Me.gbMenuEx)
        Me.Name = "frmExpedientes"
        Me.Text = "Expedientes/Mascotas"
        Me.gbMenuEx.ResumeLayout(False)
        Me.gbMenuEx.PerformLayout()
        CType(Me.btnVolverEx, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbtxtEx.ResumeLayout(False)
        Me.gbtxtEx.PerformLayout()
        CType(Me.dgvExpedientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbMenuEx As GroupBox
    Friend WithEvents btnEliminarEx As Button
    Friend WithEvents btnModificarEx As Button
    Friend WithEvents btnNuevoEx As Button
    Friend WithEvents btnMostrarEx As Button
    Friend WithEvents btnVolverEx As PictureBox
    Friend WithEvents gbtxtEx As GroupBox
    Friend WithEvents lblEspecialidades As Label
    Friend WithEvents cbbfamiliaEx As ComboBox
    Friend WithEvents lblCodigoEx As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblduenho As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txthabitatEx As TextBox
    Friend WithEvents txtduenoEX As TextBox
    Friend WithEvents txtcolorEx As TextBox
    Friend WithEvents txtNombreEx As TextBox
    Friend WithEvents lblCatBuscar As Label
    Friend WithEvents cbbBuscarEx As ComboBox
    Friend WithEvents btnActualizarEx As Button
    Friend WithEvents lblBuscar As Label
    Friend WithEvents txtBuscarEx As TextBox
    Friend WithEvents btnCancelarEx As Button
    Friend WithEvents btnGuardarEx As Button
    Friend WithEvents dgvExpedientes As DataGridView
    Friend WithEvents cbbSexoEx As ComboBox
    Friend WithEvents rtbotrosEx As RichTextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtpesoEx As TextBox
    Friend WithEvents dtpfechnacEx As DateTimePicker
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents cbbrazaEX As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtSangreEx As TextBox
    Friend WithEvents btnBuscarCliId As Button
End Class
