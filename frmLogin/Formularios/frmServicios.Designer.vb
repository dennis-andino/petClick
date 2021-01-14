<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmConsultas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConsultas))
        Me.gbinfogSe = New System.Windows.Forms.GroupBox()
        Me.txtCosto = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbbServicio = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblfechaS = New System.Windows.Forms.Label()
        Me.txtAtendidoS = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblclidS = New System.Windows.Forms.Label()
        Me.lblduenoP = New System.Windows.Forms.Label()
        Me.txtmotivosS = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblpacidS = New System.Windows.Forms.Label()
        Me.lblnombrePacS = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gbDatosMedSe = New System.Windows.Forms.GroupBox()
        Me.dtpcitaS = New System.Windows.Forms.DateTimePicker()
        Me.rtbtratS = New System.Windows.Forms.RichTextBox()
        Me.rtbdiagS = New System.Windows.Forms.RichTextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnRegConsulta = New System.Windows.Forms.Button()
        Me.btnCancelarCons = New System.Windows.Forms.Button()
        Me.gbinfogSe.SuspendLayout()
        Me.gbDatosMedSe.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbinfogSe
        '
        Me.gbinfogSe.Controls.Add(Me.txtCosto)
        Me.gbinfogSe.Controls.Add(Me.Label5)
        Me.gbinfogSe.Controls.Add(Me.cbbServicio)
        Me.gbinfogSe.Controls.Add(Me.Label2)
        Me.gbinfogSe.Controls.Add(Me.lblfechaS)
        Me.gbinfogSe.Controls.Add(Me.txtAtendidoS)
        Me.gbinfogSe.Controls.Add(Me.Label13)
        Me.gbinfogSe.Controls.Add(Me.Label12)
        Me.gbinfogSe.Controls.Add(Me.lblclidS)
        Me.gbinfogSe.Controls.Add(Me.lblduenoP)
        Me.gbinfogSe.Controls.Add(Me.txtmotivosS)
        Me.gbinfogSe.Controls.Add(Me.Label9)
        Me.gbinfogSe.Controls.Add(Me.Label8)
        Me.gbinfogSe.Controls.Add(Me.Label7)
        Me.gbinfogSe.Controls.Add(Me.lblpacidS)
        Me.gbinfogSe.Controls.Add(Me.lblnombrePacS)
        Me.gbinfogSe.Controls.Add(Me.Label4)
        Me.gbinfogSe.Controls.Add(Me.Label3)
        Me.gbinfogSe.Location = New System.Drawing.Point(12, 16)
        Me.gbinfogSe.Name = "gbinfogSe"
        Me.gbinfogSe.Size = New System.Drawing.Size(712, 186)
        Me.gbinfogSe.TabIndex = 0
        Me.gbinfogSe.TabStop = False
        Me.gbinfogSe.Text = "Informacion General"
        '
        'txtCosto
        '
        Me.txtCosto.Location = New System.Drawing.Point(409, 145)
        Me.txtCosto.Name = "txtCosto"
        Me.txtCosto.Size = New System.Drawing.Size(170, 20)
        Me.txtCosto.TabIndex = 19
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(342, 149)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Costo Total"
        '
        'cbbServicio
        '
        Me.cbbServicio.FormattingEnabled = True
        Me.cbbServicio.Location = New System.Drawing.Point(409, 106)
        Me.cbbServicio.Name = "cbbServicio"
        Me.cbbServicio.Size = New System.Drawing.Size(170, 21)
        Me.cbbServicio.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(342, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Servicio"
        '
        'lblfechaS
        '
        Me.lblfechaS.AutoSize = True
        Me.lblfechaS.Location = New System.Drawing.Point(576, 16)
        Me.lblfechaS.Name = "lblfechaS"
        Me.lblfechaS.Size = New System.Drawing.Size(13, 13)
        Me.lblfechaS.TabIndex = 15
        Me.lblfechaS.Text = "0"
        '
        'txtAtendidoS
        '
        Me.txtAtendidoS.Location = New System.Drawing.Point(91, 142)
        Me.txtAtendidoS.Name = "txtAtendidoS"
        Me.txtAtendidoS.Size = New System.Drawing.Size(202, 20)
        Me.txtAtendidoS.TabIndex = 14
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(7, 67)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(105, 13)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "Dueño de Paciente :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(247, 67)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(53, 13)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Cliente ID"
        '
        'lblclidS
        '
        Me.lblclidS.AutoSize = True
        Me.lblclidS.Location = New System.Drawing.Point(393, 67)
        Me.lblclidS.Name = "lblclidS"
        Me.lblclidS.Size = New System.Drawing.Size(13, 13)
        Me.lblclidS.TabIndex = 11
        Me.lblclidS.Text = "0"
        '
        'lblduenoP
        '
        Me.lblduenoP.AutoSize = True
        Me.lblduenoP.Location = New System.Drawing.Point(131, 67)
        Me.lblduenoP.Name = "lblduenoP"
        Me.lblduenoP.Size = New System.Drawing.Size(10, 13)
        Me.lblduenoP.TabIndex = 10
        Me.lblduenoP.Text = "-"
        '
        'txtmotivosS
        '
        Me.txtmotivosS.Location = New System.Drawing.Point(91, 105)
        Me.txtmotivosS.Name = "txtmotivosS"
        Me.txtmotivosS.Size = New System.Drawing.Size(202, 20)
        Me.txtmotivosS.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(11, 145)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Atendido Por: "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(11, 105)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Motivo :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(247, 39)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Paciente ID"
        '
        'lblpacidS
        '
        Me.lblpacidS.AutoSize = True
        Me.lblpacidS.Location = New System.Drawing.Point(393, 39)
        Me.lblpacidS.Name = "lblpacidS"
        Me.lblpacidS.Size = New System.Drawing.Size(13, 13)
        Me.lblpacidS.TabIndex = 5
        Me.lblpacidS.Text = "0"
        '
        'lblnombrePacS
        '
        Me.lblnombrePacS.AutoSize = True
        Me.lblnombrePacS.Location = New System.Drawing.Point(88, 39)
        Me.lblnombrePacS.Name = "lblnombrePacS"
        Me.lblnombrePacS.Size = New System.Drawing.Size(10, 13)
        Me.lblnombrePacS.TabIndex = 4
        Me.lblnombrePacS.Text = "-"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Paciente: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(503, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fecha : "
        '
        'gbDatosMedSe
        '
        Me.gbDatosMedSe.Controls.Add(Me.dtpcitaS)
        Me.gbDatosMedSe.Controls.Add(Me.rtbtratS)
        Me.gbDatosMedSe.Controls.Add(Me.rtbdiagS)
        Me.gbDatosMedSe.Controls.Add(Me.Label16)
        Me.gbDatosMedSe.Controls.Add(Me.Label17)
        Me.gbDatosMedSe.Controls.Add(Me.Label15)
        Me.gbDatosMedSe.Location = New System.Drawing.Point(12, 222)
        Me.gbDatosMedSe.Name = "gbDatosMedSe"
        Me.gbDatosMedSe.Size = New System.Drawing.Size(712, 190)
        Me.gbDatosMedSe.TabIndex = 1
        Me.gbDatosMedSe.TabStop = False
        Me.gbDatosMedSe.Text = "Datos Medicos"
        '
        'dtpcitaS
        '
        Me.dtpcitaS.Location = New System.Drawing.Point(90, 159)
        Me.dtpcitaS.Name = "dtpcitaS"
        Me.dtpcitaS.Size = New System.Drawing.Size(200, 20)
        Me.dtpcitaS.TabIndex = 13
        '
        'rtbtratS
        '
        Me.rtbtratS.Location = New System.Drawing.Point(368, 40)
        Me.rtbtratS.Name = "rtbtratS"
        Me.rtbtratS.Size = New System.Drawing.Size(326, 102)
        Me.rtbtratS.TabIndex = 12
        Me.rtbtratS.Text = ""
        '
        'rtbdiagS
        '
        Me.rtbdiagS.Location = New System.Drawing.Point(6, 41)
        Me.rtbdiagS.Name = "rtbdiagS"
        Me.rtbdiagS.Size = New System.Drawing.Size(338, 101)
        Me.rtbdiagS.TabIndex = 11
        Me.rtbdiagS.Text = ""
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(6, 165)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(65, 13)
        Me.Label16.TabIndex = 9
        Me.Label16.Text = "Proxima Cita"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(6, 25)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(69, 13)
        Me.Label17.TabIndex = 10
        Me.Label17.Text = "Diagnostico: "
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(365, 25)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(63, 13)
        Me.Label15.TabIndex = 8
        Me.Label15.Text = "Tratamiento"
        '
        'btnRegConsulta
        '
        Me.btnRegConsulta.AutoSize = True
        Me.btnRegConsulta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRegConsulta.FlatAppearance.BorderSize = 0
        Me.btnRegConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegConsulta.Image = CType(resources.GetObject("btnRegConsulta.Image"), System.Drawing.Image)
        Me.btnRegConsulta.Location = New System.Drawing.Point(567, 418)
        Me.btnRegConsulta.Name = "btnRegConsulta"
        Me.btnRegConsulta.Size = New System.Drawing.Size(157, 41)
        Me.btnRegConsulta.TabIndex = 19
        Me.btnRegConsulta.UseVisualStyleBackColor = True
        '
        'btnCancelarCons
        '
        Me.btnCancelarCons.AutoSize = True
        Me.btnCancelarCons.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancelarCons.FlatAppearance.BorderSize = 0
        Me.btnCancelarCons.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelarCons.Image = CType(resources.GetObject("btnCancelarCons.Image"), System.Drawing.Image)
        Me.btnCancelarCons.Location = New System.Drawing.Point(405, 418)
        Me.btnCancelarCons.Name = "btnCancelarCons"
        Me.btnCancelarCons.Size = New System.Drawing.Size(156, 41)
        Me.btnCancelarCons.TabIndex = 20
        Me.btnCancelarCons.UseVisualStyleBackColor = True
        '
        'frmConsultas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(736, 471)
        Me.Controls.Add(Me.btnRegConsulta)
        Me.Controls.Add(Me.btnCancelarCons)
        Me.Controls.Add(Me.gbDatosMedSe)
        Me.Controls.Add(Me.gbinfogSe)
        Me.Name = "frmConsultas"
        Me.Text = "Nueva Consulta"
        Me.gbinfogSe.ResumeLayout(False)
        Me.gbinfogSe.PerformLayout()
        Me.gbDatosMedSe.ResumeLayout(False)
        Me.gbDatosMedSe.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbinfogSe As GroupBox
    Friend WithEvents txtmotivosS As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblpacidS As Label
    Friend WithEvents lblnombrePacS As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtAtendidoS As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lblclidS As Label
    Friend WithEvents lblduenoP As Label
    Friend WithEvents lblfechaS As Label
    Friend WithEvents gbDatosMedSe As GroupBox
    Friend WithEvents dtpcitaS As DateTimePicker
    Friend WithEvents rtbtratS As RichTextBox
    Friend WithEvents rtbdiagS As RichTextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents btnRegConsulta As Button
    Friend WithEvents btnCancelarCons As Button
    Friend WithEvents txtCosto As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cbbServicio As ComboBox
    Friend WithEvents Label2 As Label
End Class
