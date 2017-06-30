Public Class TipoVehiculo
#Region "Herencia"
    Inherits SOLink.clConectividad
#End Region
#Region "Variables"
    Dim str_L_IdTipoVehiculo, _
        str_L_Descripcion, _
        str_L_IdCombustible, _
        str_L_Combustible, _
        str_L_Uso, _
        str_L_IDUso As String, _
        col_L_Params As Collection, _
        bln_L_Relacionado As Boolean
#End Region
#Region "Propiedades"
    Public Property IdTipoVehiculo
        Get
            Return str_L_IdTipoVehiculo
        End Get
        Set(ByVal value)
            str_L_IdTipoVehiculo = value
        End Set
    End Property
    Public Property IdCombustible As String
        Get
            Return str_L_IdCombustible
        End Get
        Set(ByVal value As String)
            str_L_IdCombustible = value
        End Set
    End Property
    Public Property IdUso As String
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
    Public Property Combustible As String
        Get
            Return str_L_Combustible
        End Get
        Set(ByVal value As String)
            str_L_Combustible = value
        End Set
    End Property
    Public Property Uso As String
        Get
            Return str_L_Uso
        End Get
        Set(ByVal value As String)
            str_L_Uso = value
        End Set
    End Property
    Public Property Relacionado As Boolean
        Get
            Return bln_L_Relacionado
        End Get
        Set(ByVal value As Boolean)
            bln_L_Relacionado = value
        End Set
    End Property
#End Region
#Region "Metodos"
    Public Sub Registrar()
        Try
            col_L_Params = Nothing
            col_L_Params = New Collection
            With col_L_Params
                .Add(Me.IdCombustible)
                .Add(Me.IdUso)
                .Add(Me.Descripcion)
            End With
            Me.Return_Records("pa_AdicionaTipo", col_L_Params)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub Actualizar()
        Try
            col_L_Params = Nothing
            col_L_Params = New Collection
            With col_L_Params
                .Add(Me.IdTipoVehiculo)
                .Add(Me.IdCombustible)
                .Add(Me.IdUso)
                .Add(Me.Descripcion)
            End With
            Return_Records("pa_ActualizaTipo", col_L_Params)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    ''' <summary>
    ''' Este procedimiento carga los tipos de vehiculos para diferentes combos
    ''' y consultas
    ''' </summary>
    ''' <param name="Seleccion">[Seleccion = True, carga ademas de los tipos de vehiculos, las marcas][Seleccion = False, sólo carga un listado de tipos de vehiculo] </param>
    ''' <remarks></remarks>
    Public Sub Listar(Optional ByVal Seleccion As Boolean = False)
        Try
            If Seleccion = False Then
                Me.Return_Records("pa_Lista_Tipo_Vehiculos", , True)
            Else
                Me.Return_Records("pa_Selector_TipoVehiculo", , True)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub Listar(ByVal id_tipo_combustible As String)
        Try
            col_L_Params = Nothing
            col_L_Params = New Collection
            col_L_Params.Add(id_tipo_combustible)
            Me.Return_Records("pa_tip_veh_fuel", col_L_Params, True)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub Eliminar()
        Try
            col_L_Params = Nothing
            col_L_Params = New Collection
            col_L_Params.Add(Me.IdTipoVehiculo)
            Return_Records("pa_EliminaTipo", col_L_Params)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
#End Region
End Class
