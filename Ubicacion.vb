Public Class Ubicacion
#Region "Herencia"
    Inherits SOLink.clConectividad
#End Region
#Region "Variables"
    Dim str_l_id_almacen, _
        str_l_id_ana_ub, _
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
            Return str_l_id_ana_ub
        End Get
        Set(value As String)
            str_l_id_ana_ub = value
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
#Region "Métodos"
    Public Sub registrar()
        Try
            col_l_coleccion = Nothing
            col_l_coleccion = New Collection
            With col_l_coleccion
                .Add(Me.id_anaq_ub)
                .Add(Me.desc_anaq)
            End With
            Me.Return_Records("pa_add_ubi", col_l_coleccion)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub listar(Optional ByVal param As Boolean = False)
        Try
            If param Then
            Else
                Me.Return_Records("pa_listar_ubs_detail", , True)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
#End Region
End Class
