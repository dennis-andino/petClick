<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarMedico
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblCatBuscar = New System.Windows.Forms.Label()
        Me.cbbBuscarMe = New System.Windows.Forms.ComboBox()
        Me.lblBuscar = New System.Windows.Forms.Label()
        Me.txtBuscarMe = New System.Windows.Forms.TextBox()
        Me.dgvBMedicos = New System.Windows.Forms.DataGridView()
        CType(Me.dgvBMedicos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(372, 32)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Ingrese el Nombre  del Medico o  Especialidad  Para Buscar," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "haga doble click par" &
    "a seleccionar y continuar." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblCatBuscar
        '
        Me.lblCatBuscar.AutoSize = True
        Me.lblCatBuscar.Location = New System.Drawing.Point(6, 64)
        Me.lblCatBuscar.Name = "lblCatBuscar"
        Me.lblCatBuscar.Size = New System.Drawing.Size(60, 13)
        Me.lblCatBuscar.TabIndex = 49
        Me.lblCatBuscar.Text = "Filtrar Por : "
        '
        'cbbBuscarMe
        '
        Me.cbbBuscarMe.FormattingEnabled = True
        Me.cbbBuscarMe.Items.AddRange(New Object() {"Medico", "Especialidad"})
        Me.cbbBuscarMe.Location = New System.Drawing.Point(80, 61)
        Me.cbbBuscarMe.Name = "cbbBuscarMe"
        Me.cbbBuscarMe.Size = New System.Drawing.Size(74, 21)
        Me.cbbBuscarMe.TabIndex = 48
        Me.cbbBuscarMe.Text = "Medico"
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.Location = New System.Drawing.Point(160, 65)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(40, 13)
        Me.lblBuscar.TabIndex = 47
        Me.lblBuscar.Text = "Buscar"
        '
        'txtBuscarMe
        '
        Me.txtBuscarMe.Location = New System.Drawing.Point(206, 62)
        Me.txtBuscarMe.Name = "txtBuscarMe"
        Me.txtBuscarMe.Size = New System.Drawing.Size(174, 20)
        Me.txtBuscarMe.TabIndex = 46
        '
        'dgvBMedicos
        '
        Me.dgvBMedicos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvBMedicos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        Me.dgvBMedicos.BackgroundColor = System.Drawing.SystemColors.ControlDark
        Me.dgvBMedicos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvBMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBMedicos.Location = New System.Drawing.Point(9, 88)
        Me.dgvBMedicos.Name = "dgvBMedicos"
        Me.dgvBMedicos.ReadOnly = True
        Me.dgvBMedicos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBMedicos.Size = New System.Drawing.Size(371, 192)
        Me.dgvBMedicos.TabIndex = 45
        '
        'frmBuscarMedico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(386, 287)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblCatBuscar)
        Me.Controls.Add(Me.cbbBuscarMe)
        Me.Controls.Add(Me.lblBuscar)
        Me.Controls.Add(Me.txtBuscarMe)
        Me.Controls.Add(Me.dgvBMedicos)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.HelpButton = True
        Me.Name = "frmBuscarMedico"
        Me.Text = "BuscarMedico"
        CType(Me.dgvBMedicos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblCatBuscar As Label
    Friend WithEvents cbbBuscarMe As ComboBox
    Friend WithEvents lblBuscar As Label
    Friend WithEvents txtBuscarMe As TextBox
    Friend WithEvents dgvBMedicos As DataGridView
End Class
