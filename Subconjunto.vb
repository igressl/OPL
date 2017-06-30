Public Class Subconjunto
#Region "Herencia"
    Inherits SOLink.clConectividad
#End Region
#Region "Constructor"
    Public Sub New()
        Me.Conjunto_Padre = New BOVehicleSH.Conjunto

    End Sub
#End Region
#Region "Variables"
    Dim str_L_IdSubConjunto, _
        st_L_Conjunto, _
        str_L_Descripcion As String, _
        col_L_Parametros As Collection, _
        obj_L_Conjunto As Conjunto
#End Region
#Region "Propiedades"
    Public Property Conjunto_Padre As Conjunto
        Get
            Return obj_L_Conjunto
        End Get
        Set(ByVal value As Conjunto)
            obj_L_Conjunto = value
        End Set
    End Property
    Public Property IdSubConjunto As String
        Get
            Return str_L_IdSubConjunto
        End Get
        Set(ByVal value As String)
            str_L_IdSubConjunto = value
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
    Public Sub Registrar()
        Try
            col_L_Parametros = Nothing
            col_L_Parametros = New Collection
            With col_L_Parametros
                .Add(Conjunto_Padre.IdConjunto)
                .Add(Me.Descripcion)
            End With
            Me.Return_Records("pa_AdicionaSubConjunto", col_L_Parametros)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub Listar(Optional ByVal Especifico As Boolean = False)
        Try
            If Especifico Then
                col_L_Parametros = Nothing
                col_L_Parametros = New Collection
                col_L_Parametros.Add(Me.Conjunto_Padre.IdConjunto)
                Me.Return_Records("pa_Listado_SubConjuntos_Param", col_L_Parametros, True)
            Else
                Me.Return_Records("pa_Listado_SubConjuntos", , True)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub Actualizar()
        Try
            col_L_Parametros = Nothing
            col_L_Parametros = New Collection
            With col_L_Parametros
                .Add(Me.IdSubConjunto)
                .Add(Me.Conjunto_Padre.IdConjunto)
                .Add(Me.Descripcion)
            End With
            Me.Return_Records("pa_Actualiza_SubConjunto", col_L_Parametros)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
#End Region    
End Class
