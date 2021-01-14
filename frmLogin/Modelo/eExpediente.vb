Public Class eExpediente
    Dim mas_Peso1 As Double
    Dim mas_FechaNac1 As Date
    Dim mas_Sexo1 As Char
    Dim mas_Id1, mas_DuenhoID1, mas_EspecieId1, mas_EspecieTipoId1 As Int16
    Dim mas_TipoSangre1, mas_Nombre1, mas_Color1, mas_Habitat1, mas_Otros1 As String

    Public Sub New()

    End Sub

    Public Property Mas_Peso As Double
        Get
            Return mas_Peso1
        End Get
        Set(value As Double)
            mas_Peso1 = value
        End Set
    End Property

    Public Property Mas_FechaNac As Date
        Get
            Return mas_FechaNac1
        End Get
        Set(value As Date)
            mas_FechaNac1 = value
        End Set
    End Property

    Public Property Mas_Sexo As Char
        Get
            Return mas_Sexo1
        End Get
        Set(value As Char)
            mas_Sexo1 = value
        End Set
    End Property

    Public Property Mas_Id As Int16
        Get
            Return mas_Id1
        End Get
        Set(value As Int16)
            mas_Id1 = value
        End Set
    End Property

    Public Property Mas_DuenhoID As Int16
        Get
            Return mas_DuenhoID1
        End Get
        Set(value As Int16)
            mas_DuenhoID1 = value
        End Set
    End Property

    Public Property Mas_EspecieId As Int16
        Get
            Return mas_EspecieId1
        End Get
        Set(value As Int16)
            mas_EspecieId1 = value
        End Set
    End Property

    Public Property Mas_EspecieTipoId As Int16
        Get
            Return mas_EspecieTipoId1
        End Get
        Set(value As Int16)
            mas_EspecieTipoId1 = value
        End Set
    End Property

    Public Property Mas_TipoSangre As String
        Get
            Return mas_TipoSangre1
        End Get
        Set(value As String)
            mas_TipoSangre1 = value
        End Set
    End Property

    Public Property Mas_Nombre As String
        Get
            Return mas_Nombre1
        End Get
        Set(value As String)
            mas_Nombre1 = value
        End Set
    End Property

    Public Property Mas_Color As String
        Get
            Return mas_Color1
        End Get
        Set(value As String)
            mas_Color1 = value
        End Set
    End Property

    Public Property Mas_Habitat As String
        Get
            Return mas_Habitat1
        End Get
        Set(value As String)
            mas_Habitat1 = value
        End Set
    End Property

    Public Property Mas_Otros As String
        Get
            Return mas_Otros1
        End Get
        Set(value As String)
            mas_Otros1 = value
        End Set
    End Property
End Class
