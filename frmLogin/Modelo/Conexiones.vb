Imports System.Data.SqlClient

Public Class Conexiones
    Protected miconexion As New SqlConnection

    Public Sub New()
        Try
            miconexion = New SqlConnection("Data Source=.\SQLEXPRESS;Initial Catalog=veterinaria; Integrated Security=True")
        Catch ex As Exception
            MsgBox("no se encontro la base de Datos ,Contacte al administrador del Sistema ==>  " & ex.Message)
        End Try

    End Sub

    Protected Function conectar() As Boolean
        Try
            miconexion.Open()
            Return True
        Catch ex As Exception
            MsgBox("Conexion a Base de Datos Fallida,Contacte al administrador del Sistema ==>  " & ex.Message)
            Return False
        End Try
    End Function

    Protected Function Desconectar() As Boolean
        Try
            If miconexion.State Then
                miconexion.Close()
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox("Conexion a Base de Datos no puede ser desconectada,Contacte al administrador del Sistema ==>  " & ex.Message)
            Return False
        End Try
    End Function






End Class
