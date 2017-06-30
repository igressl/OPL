Public Class Reparacion
#Region "Herencia"
    Inherits SOLink.clConectividad
#End Region
#Region "Variables"
    Dim str_L_IdReparacion, _
        str_L_IdConjunto, _
        str_L_IdSubConjunto, _
        str_L_Descripcion As String, _
        col_L_Parametros As Collection
#End Region
#Region "Propiedades"
    Public Property IdReparacion As String
        Get
            Return str_L_IdReparacion
        End Get
        Set(ByVal value As String)
            str_L_IdReparacion = value
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
    Public Sub Registra()
        Try
            col_L_Parametros = Nothing
            col_L_Parametros = New Collection
            With col_L_Parametros
                .Add(Me.IdSubConjunto)
                .Add(Me.Descripcion)
            End With
            Return_Records("pa_AdicionaActividad", col_L_Parametros)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub Listar(ByVal IDTipoVehiculo As String, ByVal IDConjunto As String, ByVal IDSubConjunto As String)
        Try

        Catch ex As Exception

        End Try
    End Sub
    Public Sub Listar(ByVal IDSubConjunto As String)
        Try
            col_L_Parametros = Nothing
            col_L_Parametros = New Collection
            With col_L_Parametros
                .Add(IDSubConjunto)
            End With
            Return_Records("pa_Lista_Actividades", col_L_Parametros, True)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub Desactivar()
        Try
            col_L_Parametros = Nothing
            col_L_Parametros = New Collection
            col_L_Parametros.Add(Me.IdReparacion)
            Return_Records("pa_Procesa_Actividad", col_L_Parametros)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub Actualiza()
        Try
            col_L_Parametros = Nothing
            col_L_Parametros = New Collection
            With col_L_Parametros
                .Add(IdReparacion)
                .Add(Me.IdSubConjunto)
            End With
            Return_Records("pa_Actualiza_Reparaciones", col_L_Parametros)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
#End Region
End Class
