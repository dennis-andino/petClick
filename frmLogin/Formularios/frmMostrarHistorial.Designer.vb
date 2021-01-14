<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMostrarHistorial
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
        Me.dgvHistoriales = New System.Windows.Forms.DataGridView()
        Me.lblCatBuscar = New System.Windows.Forms.Label()
        Me.cbbHistorial = New System.Windows.Forms.ComboBox()
        Me.lblBuscar = New System.Windows.Forms.Label()
        Me.txtBuscarHistorial = New System.Windows.Forms.TextBox()
        CType(Me.dgvHistoriales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvHistoriales
        '
        Me.dgvHistoriales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvHistoriales.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        Me.dgvHistoriales.BackgroundColor = System.Drawing.SystemColors.ControlDark
        Me.dgvHistoriales.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvHistoriales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHistoriales.Location = New System.Drawing.Point(12, 70)
        Me.dgvHistoriales.Name = "dgvHistoriales"
        Me.dgvHistoriales.ReadOnly = True
        Me.dgvHistoriales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvHistoriales.Size = New System.Drawing.Size(1089, 395)
        Me.dgvHistoriales.TabIndex = 32
        '
        'lblCatBuscar
        '
        Me.lblCatBuscar.AutoSize = True
        Me.lblCatBuscar.Location = New System.Drawing.Point(528, 14)
        Me.lblCatBuscar.Name = "lblCatBuscar"
        Me.lblCatBuscar.Size = New System.Drawing.Size(60, 13)
        Me.lblCatBuscar.TabIndex = 43
        Me.lblCatBuscar.Text = "Filtrar Por : "
        '
        'cbbHistorial
        '
        Me.cbbHistorial.FormattingEnabled = True
        Me.cbbHistorial.Items.AddRange(New Object() {"Nombre de Mascota", "Nombre de Cliente"})
        Me.cbbHistorial.Location = New System.Drawing.Point(594, 11)
        Me.cbbHistorial.Name = "cbbHistorial"
        Me.cbbHistorial.Size = New System.Drawing.Size(171, 21)
        Me.cbbHistorial.TabIndex = 42
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.Location = New System.Drawing.Point(835, 15)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(40, 13)
        Me.lblBuscar.TabIndex = 41
        Me.lblBuscar.Text = "Buscar"
        '
        'txtBuscarHistorial
        '
        Me.txtBuscarHistorial.Location = New System.Drawing.Point(881, 12)
        Me.txtBuscarHistorial.Name = "txtBuscarHistorial"
        Me.txtBuscarHistorial.Size = New System.Drawing.Size(220, 20)
        Me.txtBuscarHistorial.TabIndex = 40
        '
        'frmMostrarHistorial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(1113, 486)
        Me.Controls.Add(Me.lblCatBuscar)
        Me.Controls.Add(Me.cbbHistorial)
        Me.Controls.Add(Me.lblBuscar)
        Me.Controls.Add(Me.txtBuscarHistorial)
        Me.Controls.Add(Me.dgvHistoriales)
        Me.Name = "frmMostrarHistorial"
        Me.Text = "Historiales"
        CType(Me.dgvHistoriales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvHistoriales As DataGridView
    Friend WithEvents lblCatBuscar As Label
    Friend WithEvents cbbHistorial As ComboBox
    Friend WithEvents lblBuscar As Label
    Friend WithEvents txtBuscarHistorial As TextBox
End Class
