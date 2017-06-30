Public Class Almacen
#Region "Herencia"
    Inherits SOLink.clConectividad
#End Region
#Region "Variables"
    Dim str_l_id_empresa, _
        str_l_id_almacen, _
        str_l_desc_almacen As String, _
        col_l_parms As Collection
#End Region
#Region "Propiedades"
    Public Property id_empresa As String
        Get
            Return str_l_id_empresa
        End Get
        Set(value As String)
            str_l_id_empresa = value
        End Set
    End Property
    Public Property id_almacen As String
        Get
            Return str_l_id_almacen
        End Get
        Set(value As String)
            str_l_id_almacen = value
        End Set
    End Property
    Public Property descripcion As String
        Get
            Return str_l_desc_almacen
        End Get
        Set(value As String)
            str_l_desc_almacen = value
        End Set
    End Property
#End Region
#Region "Metodos"
    Public Sub registra()
        Try
            col_l_parms = Nothing
            col_l_parms = New Collection
            With col_l_parms
                .Add(Me.id_empresa)
                .Add(Me.descripcion)
            End With
            Me.Return_Records("pa_add_almacen", col_l_parms)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub listar()
        Try
            col_l_parms = Nothing
            col_l_parms = New Collection
            col_l_parms.Add(Me.id_empresa)
            Me.Return_Records("pa_load_alms", col_l_parms, True)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
#End Region
End Class
