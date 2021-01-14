Public Class eUsuarios
    Protected _usu_Nickname As Integer
    Protected _usu_Clave, _usu_NombreCompleto, _usu_Puesto As String



    Public Property Usu_Nickname As Integer
        Get
            Return _usu_Nickname
        End Get
        Set(value As Integer)
            _usu_Nickname = value
        End Set
    End Property

    Public Property Usu_Clave As String
        Get
            Return _usu_Clave
        End Get
        Set(value As String)
            _usu_Clave = value
        End Set
    End Property

    Public Property Usu_NombreCompleto As String
        Get
            Return _usu_NombreCompleto
        End Get
        Set(value As String)
            _usu_NombreCompleto = value
        End Set
    End Property

    Public Property Usu_Puesto As String
        Get
            Return _usu_Puesto
        End Get
        Set(value As String)
            _usu_Puesto = value
        End Set
    End Property
End Class
