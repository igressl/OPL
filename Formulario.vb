Public Class Formulario
#Region "Herencia"
#End Region
#Region "Variables"
    Dim str_Nombre As String, _
        str_Permiso As String
#End Region
#Region "Propiedades"
    Public Property Nombre() As String
        Get
            Return str_Nombre
        End Get
        Set(ByVal value As String)
            str_Nombre = value
        End Set
    End Property
    Public Property Permiso() As String
        Get
            Return str_Permiso
        End Get
        Set(ByVal value As String)
            str_Permiso = value
        End Set
    End Property
#End Region

End Class
