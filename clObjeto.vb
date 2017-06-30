Public Class clObjeto
#Region "Variables"
    Dim str_L_Identificador As String, _
        str_L_Texto As String, _
        str_L_Cantidad As String, _
        str_L_Precio As String, _
        str_L_Existencia As String
#End Region
#Region "Propiedades"
    Public Property Identificador() As String
        Get
            Return str_L_Identificador
        End Get
        Set(ByVal value As String)
            str_L_Identificador = value
        End Set
    End Property
    Public Property Texto() As String
        Get
            Return str_L_Texto
        End Get
        Set(ByVal value As String)
            str_L_Texto = value
        End Set
    End Property
    Public Property Cantidad() As String
        Get
            Return str_L_Cantidad
        End Get
        Set(ByVal value As String)
            str_L_Cantidad = value
        End Set
    End Property
    Public Property Precio() As String
        Get
            Return str_L_Precio
        End Get
        Set(ByVal value As String)
            str_L_Precio = value
        End Set
    End Property
    Public Property Existencia() As String
        Get
            Return str_L_Existencia
        End Get
        Set(ByVal value As String)
            str_L_Existencia = value
        End Set
    End Property
#End Region

End Class
