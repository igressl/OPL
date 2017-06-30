Public Class Conjunto
#Region "Herencia"
    Inherits SOLink.clConectividad
#End Region
#Region "Variables"
    Dim str_L_IdConjunto, _
        str_L_IDTipoVehiculo, _
        str_L_Descripcion As String, _
        bln_L_Activo As Boolean, _
        str_L_TipoVehiculo As String, _
        col_L_Params As Collection
#End Region
#Region "Propiedades"
    Public Property TipoVehiculo As String
        Get
            Return str_L_TipoVehiculo
        End Get
        Set(ByVal value As String)
            str_L_TipoVehiculo = value
        End Set
    End Property
    Public Property Activo As Boolean
        Get
            Return bln_L_Activo
        End Get
        Set(ByVal value As Boolean)
            bln_L_Activo = value
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
    Public Property IDTipoVehiculo As String
        Get
            Return str_L_IDTipoVehiculo
        End Get
        Set(ByVal value As String)
            str_L_IDTipoVehiculo = value
        End Set
    End Property
    Public Property IdConjunto As String
        Get
            Return str_L_IdConjunto
        End Get
        Set(ByVal value As String)
            str_L_IdConjunto = value
        End Set
    End Property
#End Region
#Region "Metodos"
    Public Sub Actualizar()
        Try
            col_L_Params = Nothing
            col_L_Params = New Collection
            With col_L_Params
                .Add(Me.IdConjunto)
                .Add(Me.IDTipoVehiculo)
                .Add(Me.Descripcion)
            End With
            Me.Return_Records("pa_Actualiza_Conjunto", col_L_Params)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub Registrar()
        Try
            col_L_Params = Nothing
            col_L_Params = New Collection
            With col_L_Params
                .Add(Me.IDTipoVehiculo)
                .Add(Me.Descripcion)
            End With
            Me.Return_Records("pa_AdicionaConjunto", col_L_Params)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub    
    Public Sub Listar(Optional ByRef Parametrizado As Boolean = False)
        Try
            If Parametrizado = False Then
                Return_Records("pa_Lista_Conjuntos", , True)
            Else
                col_L_Params = Nothing
                col_L_Params = New Collection
                col_L_Params.Add(Me.IDTipoVehiculo)
                Return_Records("pa_Lista_Conjuntos_Parametrizado", col_L_Params, True)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region
End Class
