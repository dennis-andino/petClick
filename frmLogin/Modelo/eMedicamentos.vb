Public Class eMedicamentos
    Private med_Id, med_Enfermedad, med_proveedor As Int16
    Private med_Nombre, med_Descripcion As String
    Private med_Costo As Double

    Public Sub New()

    End Sub


    Public Property Med_Id1 As Int16
        Get
            Return med_Id
        End Get
        Set(value As Int16)
            med_Id = value
        End Set
    End Property

    Public Property Med_Enfermedad1 As Int16
        Get
            Return med_Enfermedad
        End Get
        Set(value As Int16)
            med_Enfermedad = value
        End Set
    End Property

    Public Property Med_proveedor1 As Int16
        Get
            Return med_proveedor
        End Get
        Set(value As Int16)
            med_proveedor = value
        End Set
    End Property

    Public Property Med_Nombre1 As String
        Get
            Return med_Nombre
        End Get
        Set(value As String)
            med_Nombre = value
        End Set
    End Property

    Public Property Med_Descripcion1 As String
        Get
            Return med_Descripcion
        End Get
        Set(value As String)
            med_Descripcion = value
        End Set
    End Property

    Public Property Med_Costo1 As Double
        Get
            Return med_Costo
        End Get
        Set(value As Double)
            med_Costo = value
        End Set
    End Property
End Class
