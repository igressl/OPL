Public Class Vehiculo
#Region "Herencia"
    Inherits SOLink.clConectividad
#End Region
#Region "Variables"
    Dim obj_L_TipoVehiculo As BOVehicleSH.TipoVehiculo, _
        obj_L_Marca As BOVehicleSH.Marca, _
        str_L_IdVehiculo, _
        str_L_IdStatus, _
        str_L_Eco, _
        str_L_Serie_Chasis, _
        str_L_Serie_Motor, _
        str_L_Matricula, _
        str_L_Modelo, _
        str_L_Año As String, _
        bln_L_Activo As Boolean, _
        col_L_Params As Collection, _
        dbl_L_Kilometros As Double
#End Region
#Region "Propiedades"
    Public Property Kilometros As Double
        Get
            Return dbl_L_Kilometros
        End Get
        Set(ByVal value As Double)
            dbl_L_Kilometros = value
        End Set
    End Property
    Public Property Tipo As BOVehicleSH.TipoVehiculo
        Get
            Return obj_L_TipoVehiculo
        End Get
        Set(ByVal value As BOVehicleSH.TipoVehiculo)
            obj_L_TipoVehiculo = value
        End Set
    End Property
    Public Property Marca As BOVehicleSH.Marca
        Get
            Return obj_L_Marca
        End Get
        Set(ByVal value As BOVehicleSH.Marca)
            obj_L_Marca = value
        End Set
    End Property
    Public Property IdVehiculo As String
        Get
            Return str_L_IdVehiculo
        End Get
        Set(ByVal value As String)
            str_L_IdVehiculo = value
        End Set
    End Property
    Public Property IdStatus As String
        Get
            Return str_L_IdStatus
        End Get
        Set(ByVal value As String)
            str_L_IdStatus = value
        End Set
    End Property
    Public Property Economico As String
        Get
            Return str_L_Eco
        End Get
        Set(ByVal value As String)
            str_L_Eco = value
        End Set
    End Property
    Public Property SerieChasis As String
        Get
            Return str_L_Serie_Chasis
        End Get
        Set(ByVal value As String)
            str_L_Serie_Chasis = value
        End Set
    End Property
    Public Property SerieMotor As String
        Get
            Return str_L_Serie_Motor
        End Get
        Set(ByVal value As String)
            str_L_Serie_Motor = value
        End Set
    End Property
    Public Property Matricula As String
        Get
            Return str_L_Matricula
        End Get
        Set(ByVal value As String)
            str_L_Matricula = value
        End Set
    End Property
    Public Property Modelo As String
        Get
            Return str_L_Modelo
        End Get
        Set(ByVal value As String)
            str_L_Modelo = value
        End Set
    End Property
    Public Property Año As String
        Get
            Return str_L_Año
        End Get
        Set(ByVal value As String)
            str_L_Año = value
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
#End Region
#Region "Métodos"
    Public Sub Guardar()
        Try
            col_L_Params = Nothing
            col_L_Params = New Collection
            With col_L_Params
                .Add(Me.Tipo.IdTipoVehiculo)
                .Add(Me.Economico)
                .Add(Me.SerieChasis)
                .Add(Me.SerieMotor)
                .Add(Me.Matricula)
                .Add(Me.Marca.IdMarca)
                .Add(Me.Modelo)
                .Add(Me.Año)
            End With
            Me.Return_Records("pa_AdicionaVehiculo", col_L_Params)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub Preparar()
        Try
            Me.Return_Records("pa_Selector_TipoVehiculo")
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub Listar()
        Try
            Return_Records("pa_Lista_Vehiculo", , True)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub Actualizar()
        Try
            col_L_Params = Nothing
            col_L_Params = New Collection
            With col_L_Params
                .Add(Me.IdVehiculo)
                .Add(Me.Tipo.IdTipoVehiculo)
                .Add(Me.Marca.IdMarca)
                .Add(Me.Economico)
                .Add(Me.SerieChasis)
                .Add(Me.SerieMotor)
                .Add(Me.Matricula)
                .Add(Me.Modelo)
                .Add(Me.Año)
            End With
            Return_Records("pa_Actualiza_Vehiculo", col_L_Params)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub Desactivar()
        Try
            col_L_Params = Nothing
            col_L_Params = New Collection
            col_L_Params.Add(Me.IdVehiculo)
            Return_Records("pa_DesactivaUnidad", col_L_Params)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
#End Region
    Public Sub New()
        obj_L_TipoVehiculo = New BOVehicleSH.TipoVehiculo
        obj_L_Marca = New BOVehicleSH.Marca
    End Sub
End Class
