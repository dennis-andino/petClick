<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarPaciente
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
        Me.dgvPacientes = New System.Windows.Forms.DataGridView()
        Me.lblBuscar = New System.Windows.Forms.Label()
        Me.txtBuscarPa = New System.Windows.Forms.TextBox()
        Me.cbbBuscarPa = New System.Windows.Forms.ComboBox()
        Me.lblCatBuscar = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgvPacientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvPacientes
        '
        Me.dgvPacientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPacientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        Me.dgvPacientes.BackgroundColor = System.Drawing.SystemColors.ControlDark
        Me.dgvPacientes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPacientes.Location = New System.Drawing.Point(12, 100)
        Me.dgvPacientes.Name = "dgvPacientes"
        Me.dgvPacientes.ReadOnly = True
        Me.dgvPacientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPacientes.Size = New System.Drawing.Size(371, 192)
        Me.dgvPacientes.TabIndex = 32
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.Location = New System.Drawing.Point(163, 77)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(40, 13)
        Me.lblBuscar.TabIndex = 41
        Me.lblBuscar.Text = "Buscar"
        '
        'txtBuscarPa
        '
        Me.txtBuscarPa.Location = New System.Drawing.Point(209, 74)
        Me.txtBuscarPa.Name = "txtBuscarPa"
        Me.txtBuscarPa.Size = New System.Drawing.Size(174, 20)
        Me.txtBuscarPa.TabIndex = 40
        '
        'cbbBuscarPa
        '
        Me.cbbBuscarPa.FormattingEnabled = True
        Me.cbbBuscarPa.Items.AddRange(New Object() {"Cliente", "Mascota"})
        Me.cbbBuscarPa.Location = New System.Drawing.Point(83, 73)
        Me.cbbBuscarPa.Name = "cbbBuscarPa"
        Me.cbbBuscarPa.Size = New System.Drawing.Size(74, 21)
        Me.cbbBuscarPa.TabIndex = 42
        Me.cbbBuscarPa.Text = "Cliente"
        '
        'lblCatBuscar
        '
        Me.lblCatBuscar.AutoSize = True
        Me.lblCatBuscar.Location = New System.Drawing.Point(9, 76)
        Me.lblCatBuscar.Name = "lblCatBuscar"
        Me.lblCatBuscar.Size = New System.Drawing.Size(60, 13)
        Me.lblCatBuscar.TabIndex = 43
        Me.lblCatBuscar.Text = "Filtrar Por : "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(305, 32)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Seleccione el Nombre  del Paciente o  Mascota y " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "haga doble click para continuar" &
    "." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'frmBuscarPaciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(395, 298)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblCatBuscar)
        Me.Controls.Add(Me.cbbBuscarPa)
        Me.Controls.Add(Me.lblBuscar)
        Me.Controls.Add(Me.txtBuscarPa)
        Me.Controls.Add(Me.dgvPacientes)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmBuscarPaciente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pacientes"
        CType(Me.dgvPacientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvPacientes As DataGridView
    Friend WithEvents lblBuscar As Label
    Friend WithEvents txtBuscarPa As TextBox
    Friend WithEvents cbbBuscarPa As ComboBox
    Friend WithEvents lblCatBuscar As Label
    Friend WithEvents Label1 As Label
End Class
