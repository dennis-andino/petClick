Public Class eEnfermedades
    Private _enf_Id As Integer
    Protected _enf_Nombre, _enf_Descripcion As String

    Public Sub New()
    End Sub


    Public Property Enf_Id As Integer
        Get
            Return _enf_Id
        End Get
        Set(value As Integer)
            _enf_Id = value
        End Set
    End Property

    Public Property Enf_Nombre As String
        Get
            Return _enf_Nombre
        End Get
        Set(value As String)
            _enf_Nombre = value
        End Set
    End Property

    Public Property Enf_Descripcion As String
        Get
            Return _enf_Descripcion
        End Get
        Set(value As String)
            _enf_Descripcion = value
        End Set
    End Property

End Class
