Public Class eFarmacias
    Private far_Id1 As Int16
    Private far_Nombre1, far_Direccion1 As String

    Public Sub New()
        far_Id1 = 0
        far_Nombre1 = ""
        far_Direccion1 = ""
    End Sub


    Public Property Far_Id As Int16
        Get
            Return far_Id1
        End Get
        Set(value As Int16)
            far_Id1 = value
        End Set
    End Property

    Public Property Far_Nombre As String
        Get
            Return Far_Nombre1
        End Get
        Set(value As String)
            far_Nombre1 = value
        End Set
    End Property

    Public Property Far_Direccion As String
        Get
            Return Far_Direccion1
        End Get
        Set(value As String)
            far_Direccion1 = value
        End Set
    End Property
End Class
