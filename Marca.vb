Public Class Marca
#Region "Herencia"
    Inherits SOLink.clConectividad
#End Region
#Region "Variables"
    Dim str_L_IdMarca, _
        str_L_Descripcion As String, _
        col_L_Params As Collection
#End Region
#Region "Propiedades"
    Public Property IdMarca As String
        Get
            Return str_L_IdMarca
        End Get
        Set(ByVal value As String)
            str_L_IdMarca = value
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
            col_L_Params = Nothing
            col_L_Params = New Collection
            col_L_Params.Add(Me.Descripcion)
            Return_Records("pa_RegistraMarca", col_L_Params)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub Actualizar()
        Try
            col_L_Params = Nothing
            col_L_Params = New Collection
            With col_L_Params
                .Add(Me.IdMarca)
                .Add(Me.Descripcion)
            End With
            Return_Records("pa_Actualiza_Marca", col_L_Params)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub Listar()
        Try
            Me.Return_Records("pa_Listar_Marca", , True)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
#End Region
End Class
