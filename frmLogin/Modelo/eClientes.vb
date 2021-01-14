Public Class eClientes
    Protected _cli_Id As Integer
    Protected _cli_Nombre, _cli_Apellido, _cli_DireccionT, _cli_DireccionC, _cli_Telefono, _cli_Celular, _cli_Correo As String

    Public Sub New()

    End Sub

    Public Property Cli_Id As Integer
        Get
            Return _cli_Id
        End Get
        Set(value As Integer)
            _cli_Id = value
        End Set
    End Property

    Public Property Cli_Nombre As String
        Get
            Return _cli_Nombre
        End Get
        Set(value As String)
            _cli_Nombre = value
        End Set
    End Property

    Public Property Cli_Apellido As String
        Get
            Return _cli_Apellido
        End Get
        Set(value As String)
            _cli_Apellido = value
        End Set
    End Property

    Public Property Cli_DireccionT As String
        Get
            Return _cli_DireccionT
        End Get
        Set(value As String)
            _cli_DireccionT = value
        End Set
    End Property

    Public Property Cli_DireccionC As String
        Get
            Return _cli_DireccionC
        End Get
        Set(value As String)
            _cli_DireccionC = value
        End Set
    End Property

    Public Property Cli_Telefono As String
        Get
            Return _cli_Telefono
        End Get
        Set(value As String)
            _cli_Telefono = value
        End Set
    End Property

    Public Property Cli_Celular As String
        Get
            Return _cli_Celular
        End Get
        Set(value As String)
            _cli_Celular = value
        End Set
    End Property

    Public Property Cli_Correo As String
        Get
            Return _cli_Correo
        End Get
        Set(value As String)
            _cli_Correo = value
        End Set
    End Property
End Class
