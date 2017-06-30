Public Class Articulo
#Region "Herencia"
    Inherits SOLink.clConectividad
#End Region
#Region "Variables"
    Dim str_l_id_ubicacion, _
        str_l_id_articulo, _
        str_l_num_parte, _
        str_l_descripcion, _
        str_l_id_conjunto, _
        str_l_codigo As String, _
        bln_l_activo, _
        dbl_existencia, _
        dbl_p_actual As Double, _
        col_l_params As Collection, _
        bln_l_found_coincidences As Boolean
#End Region
#Region "Propiedades"
    Public Property tiene_coincidencias
        Get
            Return bln_l_found_coincidences
        End Get
        Set(value)
            bln_l_found_coincidences = value
        End Set
    End Property
    Public Property precio_actual As Double
        Get
            Return dbl_p_actual
        End Get
        Set(value As Double)
            dbl_p_actual = value
        End Set
    End Property
    Public Property existencia As Double
        Get
            Return dbl_existencia
        End Get
        Set(value As Double)
            dbl_existencia = value
        End Set
    End Property
    Public Property activo As Boolean
        Get
            Return bln_l_activo
        End Get
        Set(value As Boolean)
            bln_l_activo = value
        End Set
    End Property
    Public Property codigo As String
        Get
            Return str_l_codigo
        End Get
        Set(value As String)
            str_l_codigo = value
        End Set
    End Property
    Public Property id_conjunto As String
        Get
            Return str_l_id_conjunto
        End Get
        Set(value As String)
            str_l_id_conjunto = value
        End Set
    End Property
    Public Property descripcion As String
        Get
            Return str_l_descripcion
        End Get
        Set(value As String)
            str_l_descripcion = value
        End Set
    End Property
    Public Property num_parte As String
        Get
            Return str_l_num_parte
        End Get
        Set(value As String)
            str_l_num_parte = value
        End Set
    End Property
    Public Property id_articulo As String
        Get
            Return str_l_id_articulo
        End Get
        Set(value As String)
            str_l_id_articulo = value
        End Set
    End Property
    Public Property id_ubicacion As String
        Get
            Return str_l_id_ubicacion
        End Get
        Set(value As String)
            str_l_id_ubicacion = value
        End Set
    End Property
#End Region
#Region "Metodos"
    Public Sub registrar()
        Try
            col_l_params = Nothing
            col_l_params = New Collection
            With col_l_params
                .Add(Me.num_parte)
                .Add(Me.descripcion)
                .Add(Me.id_conjunto)
            End With
            Me.Return_Records("pa_adiciona_articulo", col_l_params)
            '--------------------------------------
            With Me.Storage.Tables.Item(0)
                If .Rows.Count > 0 Then
                    With .Rows(0)
                        Me.id_articulo = .Item(0).ToString
                        Me.codigo = .Item(1).ToString
                    End With
                End If                
            End With
            '--------------------------------------
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub muestra_coincidencias()
        Try
            col_l_params = Nothing
            col_l_params = New Collection
            With col_l_params
                .Add(Me.descripcion)
                .Add(Me.num_parte)
            End With
            Me.Return_Records("pa_lista_coincidencias", col_l_params)
            tiene_coincidencias = Me.Storage.Tables.Item(0).Rows.Count > 0 Or Me.Storage.Tables.Item(1).Rows.Count > 0
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
#End Region

End Class
