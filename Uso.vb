Public Class Uso
#Region "Herencia"
    Inherits SOLink.clConectividad
#End Region
#Region "Variables"
    Dim str_L_IDUso, _
        str_L_Descripcion As String
#End Region
#Region "Propiedades"
    Public Property IDUso As String
        Get
            Return str_L_IDUso
        End Get
        Set(ByVal value As String)
            str_L_IDUso = value
        End Set
    End Property
    Public Property Descripcion As String
        Get
            Return str_L_Descripcion
        End Get
        Set(ByVal value As String)
            str_L_Descripcion = value
        End Set
    End Property
#End Region
#Region "Metodos"
    Public Sub Listar()
        Try
            Me.Return_Records("pa_Lista_Uso")
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
#End Region
End Class
