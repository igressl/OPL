Public Class Anaquel
#Region "Herencia"
    Inherits SOLink.clConectividad
#End Region
#Region "Variables"
    Dim str_l_id_almacen, _
        str_l_id_anaq_ub, _
        str_l_desc_anaq As String, _
        col_l_coleccion As Collection
#End Region
#Region "Propiedades"
    Public Property id_almacen As String
        Get
            Return str_l_id_almacen
        End Get
        Set(value As String)
            str_l_id_almacen = value
        End Set
    End Property
    Public Property id_anaq_ub As String
        Get
            Return str_l_id_anaq_ub
        End Get
        Set(value As String)
            str_l_id_anaq_ub = value
        End Set
    End Property
    Public Property desc_anaq As String
        Get
            Return str_l_desc_anaq
        End Get
        Set(value As String)
            str_l_desc_anaq = value
        End Set
    End Property
#End Region
#Region "Metodos"
    Public Sub listar(Optional ByVal Parametrizado As Boolean = False)
        Try
            If Parametrizado Then
                col_l_coleccion = Nothing
                col_l_coleccion = New Collection
                col_l_coleccion.Add(Me.id_almacen)
                Me.Return_Records("pa_listar_anaqs_param_alm", col_l_coleccion, True)
            Else
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub registrar()
        Try
            col_l_coleccion = Nothing
            col_l_coleccion = New Collection
            With col_l_coleccion
                .Add(Me.id_almacen)
                .Add(Me.desc_anaq)
            End With
            Return_Records("pa_reg_anaq", col_l_coleccion, False)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
#End Region
End Class
