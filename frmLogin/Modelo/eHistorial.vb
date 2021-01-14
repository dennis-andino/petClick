Public Class eHistorial

    Private _his_id, _his_paciente, _his_cliente, _his_personal, _his_servicio As Int16
    Private _his_motivo, _his_diagnostico, _his_tratamiento As String
    Private _his_proximacita, _his_fecha As Date
    Private _his_costo As Double

    Public Sub New()

    End Sub

    Public Property His_id As Int16
        Get
            Return _his_id
        End Get
        Set(value As Int16)
            _his_id = value
        End Set
    End Property

    Public Property His_paciente As Int16
        Get
            Return _his_paciente
        End Get
        Set(value As Int16)
            _his_paciente = value
        End Set
    End Property

    Public Property His_cliente As Int16
        Get
            Return _his_cliente
        End Get
        Set(value As Int16)
            _his_cliente = value
        End Set
    End Property

    Public Property His_personal As Int16
        Get
            Return _his_personal
        End Get
        Set(value As Int16)
            _his_personal = value
        End Set
    End Property

    Public Property His_servicio As Int16
        Get
            Return _his_servicio
        End Get
        Set(value As Int16)
            _his_servicio = value
        End Set
    End Property

    Public Property His_motivo As String
        Get
            Return _his_motivo
        End Get
        Set(value As String)
            _his_motivo = value
        End Set
    End Property

    Public Property His_diagnostico As String
        Get
            Return _his_diagnostico
        End Get
        Set(value As String)
            _his_diagnostico = value
        End Set
    End Property

    Public Property His_tratamiento As String
        Get
            Return _his_tratamiento
        End Get
        Set(value As String)
            _his_tratamiento = value
        End Set
    End Property

    Public Property His_proximacita As Date
        Get
            Return _his_proximacita
        End Get
        Set(value As Date)
            _his_proximacita = value
        End Set
    End Property

    Public Property His_fecha As Date
        Get
            Return _his_fecha
        End Get
        Set(value As Date)
            _his_fecha = value
        End Set
    End Property

    Public Property His_costo As Double
        Get
            Return _his_costo
        End Get
        Set(value As Double)
            _his_costo = value
        End Set
    End Property
End Class
