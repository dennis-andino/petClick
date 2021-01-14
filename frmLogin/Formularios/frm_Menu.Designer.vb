<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_Menu
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Menu))
        Me.tsMenu = New System.Windows.Forms.ToolStrip()
        Me.btnExpedientes = New System.Windows.Forms.ToolStripButton()
        Me.btnEnfermedades = New System.Windows.Forms.ToolStripButton()
        Me.btnClientes = New System.Windows.Forms.ToolStripButton()
        Me.btnMedicos = New System.Windows.Forms.ToolStripButton()
        Me.btnUsuarios = New System.Windows.Forms.ToolStripButton()
        Me.btnCerrarSesion = New System.Windows.Forms.ToolStripButton()
        Me.btnFarmacias = New System.Windows.Forms.PictureBox()
        Me.btnHistorales = New System.Windows.Forms.PictureBox()
        Me.btnInforme = New System.Windows.Forms.PictureBox()
        Me.btnMedicamentos = New System.Windows.Forms.PictureBox()
        Me.btn_Enfermedades = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.tsMenu.SuspendLayout()
        CType(Me.btnFarmacias, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnHistorales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnInforme, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMedicamentos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_Enfermedades, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tsMenu
        '
        Me.tsMenu.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.tsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnExpedientes, Me.btnEnfermedades, Me.btnClientes, Me.btnMedicos, Me.btnUsuarios, Me.btnCerrarSesion})
        Me.tsMenu.Location = New System.Drawing.Point(0, 0)
        Me.tsMenu.Name = "tsMenu"
        Me.tsMenu.Size = New System.Drawing.Size(943, 42)
        Me.tsMenu.Stretch = True
        Me.tsMenu.TabIndex = 0
        '
        'btnExpedientes
        '
        Me.btnExpedientes.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnExpedientes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnExpedientes.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExpedientes.Image = CType(resources.GetObject("btnExpedientes.Image"), System.Drawing.Image)
        Me.btnExpedientes.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnExpedientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnExpedientes.ImageTransparentColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnExpedientes.Name = "btnExpedientes"
        Me.btnExpedientes.Size = New System.Drawing.Size(154, 39)
        Me.btnExpedientes.ToolTipText = "Expedientes de Mascotas"
        '
        'btnEnfermedades
        '
        Me.btnEnfermedades.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnEnfermedades.Image = CType(resources.GetObject("btnEnfermedades.Image"), System.Drawing.Image)
        Me.btnEnfermedades.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnEnfermedades.ImageTransparentColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnEnfermedades.Name = "btnEnfermedades"
        Me.btnEnfermedades.Size = New System.Drawing.Size(154, 39)
        Me.btnEnfermedades.ToolTipText = "Enfermedades Comunes"
        '
        'btnClientes
        '
        Me.btnClientes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnClientes.Image = CType(resources.GetObject("btnClientes.Image"), System.Drawing.Image)
        Me.btnClientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnClientes.ImageTransparentColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Size = New System.Drawing.Size(154, 39)
        Me.btnClientes.ToolTipText = "Operaciones con Datos de Clientes"
        '
        'btnMedicos
        '
        Me.btnMedicos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnMedicos.Image = CType(resources.GetObject("btnMedicos.Image"), System.Drawing.Image)
        Me.btnMedicos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnMedicos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnMedicos.Name = "btnMedicos"
        Me.btnMedicos.Size = New System.Drawing.Size(154, 39)
        Me.btnMedicos.ToolTipText = "Equipo de Medicos"
        '
        'btnUsuarios
        '
        Me.btnUsuarios.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnUsuarios.Image = CType(resources.GetObject("btnUsuarios.Image"), System.Drawing.Image)
        Me.btnUsuarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnUsuarios.ImageTransparentColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnUsuarios.Name = "btnUsuarios"
        Me.btnUsuarios.Size = New System.Drawing.Size(154, 39)
        Me.btnUsuarios.ToolTipText = "Operaciones Con Usuarios"
        '
        'btnCerrarSesion
        '
        Me.btnCerrarSesion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnCerrarSesion.Image = CType(resources.GetObject("btnCerrarSesion.Image"), System.Drawing.Image)
        Me.btnCerrarSesion.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnCerrarSesion.ImageTransparentColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnCerrarSesion.Name = "btnCerrarSesion"
        Me.btnCerrarSesion.Size = New System.Drawing.Size(154, 39)
        Me.btnCerrarSesion.ToolTipText = "Salir/Cambiar Usuario"
        '
        'btnFarmacias
        '
        Me.btnFarmacias.Image = CType(resources.GetObject("btnFarmacias.Image"), System.Drawing.Image)
        Me.btnFarmacias.Location = New System.Drawing.Point(31, 256)
        Me.btnFarmacias.Name = "btnFarmacias"
        Me.btnFarmacias.Size = New System.Drawing.Size(140, 132)
        Me.btnFarmacias.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnFarmacias.TabIndex = 12
        Me.btnFarmacias.TabStop = False
        '
        'btnHistorales
        '
        Me.btnHistorales.Image = CType(resources.GetObject("btnHistorales.Image"), System.Drawing.Image)
        Me.btnHistorales.Location = New System.Drawing.Point(31, 83)
        Me.btnHistorales.Name = "btnHistorales"
        Me.btnHistorales.Size = New System.Drawing.Size(140, 132)
        Me.btnHistorales.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnHistorales.TabIndex = 10
        Me.btnHistorales.TabStop = False
        '
        'btnInforme
        '
        Me.btnInforme.Image = CType(resources.GetObject("btnInforme.Image"), System.Drawing.Image)
        Me.btnInforme.Location = New System.Drawing.Point(218, 256)
        Me.btnInforme.Name = "btnInforme"
        Me.btnInforme.Size = New System.Drawing.Size(140, 132)
        Me.btnInforme.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnInforme.TabIndex = 8
        Me.btnInforme.TabStop = False
        '
        'btnMedicamentos
        '
        Me.btnMedicamentos.Image = CType(resources.GetObject("btnMedicamentos.Image"), System.Drawing.Image)
        Me.btnMedicamentos.Location = New System.Drawing.Point(218, 83)
        Me.btnMedicamentos.Name = "btnMedicamentos"
        Me.btnMedicamentos.Size = New System.Drawing.Size(140, 132)
        Me.btnMedicamentos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnMedicamentos.TabIndex = 6
        Me.btnMedicamentos.TabStop = False
        '
        'btn_Enfermedades
        '
        Me.btn_Enfermedades.Image = CType(resources.GetObject("btn_Enfermedades.Image"), System.Drawing.Image)
        Me.btn_Enfermedades.Location = New System.Drawing.Point(414, 83)
        Me.btn_Enfermedades.Name = "btn_Enfermedades"
        Me.btn_Enfermedades.Size = New System.Drawing.Size(140, 132)
        Me.btn_Enfermedades.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btn_Enfermedades.TabIndex = 2
        Me.btn_Enfermedades.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(587, 45)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(344, 410)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'frm_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(943, 478)
        Me.Controls.Add(Me.btnFarmacias)
        Me.Controls.Add(Me.btnHistorales)
        Me.Controls.Add(Me.btnInforme)
        Me.Controls.Add(Me.btnMedicamentos)
        Me.Controls.Add(Me.btn_Enfermedades)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.tsMenu)
        Me.Name = "frm_Menu"
        Me.Text = "petClick Menu"
        Me.tsMenu.ResumeLayout(False)
        Me.tsMenu.PerformLayout()
        CType(Me.btnFarmacias, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnHistorales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnInforme, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMedicamentos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_Enfermedades, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tsMenu As ToolStrip
    Friend WithEvents btnExpedientes As ToolStripButton
    Friend WithEvents btnClientes As ToolStripButton
    Friend WithEvents btnMedicos As ToolStripButton
    Friend WithEvents btnEnfermedades As ToolStripButton
    Friend WithEvents btnUsuarios As ToolStripButton
    Friend WithEvents btnCerrarSesion As ToolStripButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_Enfermedades As PictureBox
    Friend WithEvents btnMedicamentos As PictureBox
    Friend WithEvents btnInforme As PictureBox
    Friend WithEvents btnHistorales As PictureBox
    Friend WithEvents btnFarmacias As PictureBox
End Class
