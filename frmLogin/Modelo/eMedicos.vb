Public Class eMedicos
    Private vet_Id1, vet_EspecialidadId1 As Int16
    Private vet_Nombres1, vet_Apellidos1, vet_DireccionC1, vet_Telefono1, vet_Celular1, vet_Correo1 As String

    Public Sub New()

    End Sub


    Public Property Vet_Id As Int16
        Get
            Return vet_Id1
        End Get
        Set(value As Int16)
            vet_Id1 = value
        End Set
    End Property

    Public Property Vet_EspecialidadId As Int16
        Get
            Return vet_EspecialidadId1
        End Get
        Set(value As Int16)
            vet_EspecialidadId1 = value
        End Set
    End Property

    Public Property Vet_Nombres As String
        Get
            Return vet_Nombres1
        End Get
        Set(value As String)
            vet_Nombres1 = value
        End Set
    End Property

    Public Property Vet_Apellidos As String
        Get
            Return vet_Apellidos1
        End Get
        Set(value As String)
            vet_Apellidos1 = value
        End Set
    End Property

    Public Property Vet_DireccionC As String
        Get
            Return vet_DireccionC1
        End Get
        Set(value As String)
            vet_DireccionC1 = value
        End Set
    End Property

    Public Property Vet_Telefono As String
        Get
            Return vet_Telefono1
        End Get
        Set(value As String)
            vet_Telefono1 = value
        End Set
    End Property

    Public Property Vet_Celular As String
        Get
            Return vet_Celular1
        End Get
        Set(value As String)
            vet_Celular1 = value
        End Set
    End Property

    Public Property Vet_Correo As String
        Get
            Return vet_Correo1
        End Get
        Set(value As String)
            vet_Correo1 = value
        End Set
    End Property
End Class
