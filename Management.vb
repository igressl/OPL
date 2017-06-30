Public Class Management
#Region "Herencia"
    Inherits clConectividad
#End Region
#Region "Variables"
    Private dt_Usuarios_Un_Log As DataTable, _
            dt_Log_Usuario As DataTable
#End Region
#Region "Propiedades"
    ''' <summary>
    ''' Lista de usuarios que al menos una vez han ingresado al sistema
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Usuarios_Logs() As DataTable
        Get
            Return dt_Usuarios_Un_Log
        End Get
        Set(ByVal value As DataTable)
            dt_Usuarios_Un_Log = value
        End Set
    End Property
    ''' <summary>
    ''' Lista la actividad del usuario en un lapso definido
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Log_Usuario() As DataTable
        Get
            Return dt_Log_Usuario
        End Get
        Set(ByVal value As DataTable)
            dt_Log_Usuario = value
        End Set
    End Property
#End Region
#Region "Metodos"
    Public Sub Registro_Mnus(ByVal strIdentificador As String, _
                             ByVal strTexto As String)
        Try
            strSentenciaSQL = "EXECUTE pa_Adiciona_Mnu_Sec '" & strTexto & "', '" & strIdentificador & "'"
            Execute_cmd_No_Results(strSentenciaSQL)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    ''' <summary>
    ''' Carga el listado de usuarios que al menos se han firmado una
    ''' vez en el sistema
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Carga_Usuarios_Log_Uso()
        Try
            Return_Records("pa_Lista_User_Logs")
            If Storage.Tables.Count > 0 Then
                Usuarios_Logs = Storage.Tables.Item(0)
            Else
                Exit Sub
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    ''' <summary>
    ''' Carga la actividad que el usuario ha tenido en el sistema
    ''' </summary>
    ''' <param name="Usuario">
    ''' Oid del usuario
    ''' </param>
    ''' <param name="Inicio">
    ''' Inicio del rango
    ''' </param>
    ''' <param name="Fin">
    ''' Fin del rango
    ''' </param>
    ''' <remarks>
    ''' Llena un datatable con la actividad encontrada
    ''' </remarks>
    Public Sub Carga_Usr_Activity(ByVal Usuario As String, _
                                  ByVal Inicio As String, _
                                  ByVal Fin As String)
        Dim col_Params As Collection
        col_Params = New Collection
        With col_Params
            .Add(Usuario)
            .Add(Inicio)
            .Add(Fin)
        End With
        Try
            Return_Records("List_Activity_Usr", col_Params)
            Log_Usuario = Storage.Tables.Item(0)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    ''' <summary>
    ''' Carga los niveles de permiso
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Carga_Politicas()
        Try
            Return_Records("pa_Carga_Policies")
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
#End Region
#Region "Funciones"
#End Region
End Class
