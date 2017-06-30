Public Class clUsuario
#Region "Herencia"
    Inherits clConectividad
#End Region
#Region "Variables"
    Dim str_L_OidUsuario As String, _
        str_L_Password As String, _
        str_L_OidAgencia As String, _
        str_L_Agencia As String, _
        col_L_Menues As Collection, _
        col_L_Formularios As Collection, _
        str_L_WorkStation As String, _
        str_L_Win_User As String, _
        col_L_Almacenes As Collection, _
        str_L_UserName As String, _
        str_L_Time_Log As String, _
        str_L_NombreCompleto As String, _
        str_L_Paterno As String, _
        str_L_Materno As String, _
        str_L_Nombres As String, _
        str_L_OidAlmacen As String, _
        str_L_Almacen As String, _
        blnAutorizado As Boolean, _
        str_L_Servidor As String, _
        colGenerica As Collection, _
        strAccess_Level As String, _
        str_L_MACAdd As String, _
        str_L_Identificadores_Seleccionados As String, _
        bln_L_Autoriza As Boolean, _
        str_L_Monto_Auto As String, _
        dt_L_Permisos_Formularios As DataTable, _
        dt_L_Permisos_Menues As DataTable, _
        str_L_OidUsuario_Ejecutor As String, _
        dt_L_Niveles_Permisos As DataTable, _
        dt_L_Almacenes As DataTable, _
        bln_L_Autoriza_Sobre_Precio As Boolean
#End Region
#Region "Propiedades"
    Public Property Autoriza_Sobreprecio() As Boolean
        Get
            Return bln_L_Autoriza_Sobre_Precio
        End Get
        Set(ByVal value As Boolean)
            bln_L_Autoriza_Sobre_Precio = value
        End Set
    End Property
    Public Property Almacenes() As DataTable
        Get
            Return dt_L_Almacenes
        End Get
        Set(ByVal value As DataTable)
            dt_L_Almacenes = value
        End Set
    End Property
    Public Property Permisos() As DataTable
        Get
            Return dt_L_Niveles_Permisos
        End Get
        Set(ByVal value As DataTable)
            dt_L_Niveles_Permisos = value
        End Set
    End Property
    Public Property OidUsuario_Ejecutor() As String
        Get
            Return str_L_OidUsuario_Ejecutor
        End Get
        Set(ByVal value As String)
            str_L_OidUsuario_Ejecutor = value
        End Set
    End Property
    Public Property Mnus_Autorized() As DataTable
        Get
            Return dt_L_Permisos_Menues
        End Get
        Set(ByVal value As DataTable)
            dt_L_Permisos_Menues = value
        End Set
    End Property
    Public Property Forms_Autorized() As DataTable
        Get
            Return dt_L_Permisos_Formularios
        End Get
        Set(ByVal value As DataTable)
            dt_L_Permisos_Formularios = value
        End Set
    End Property
    Public Property Autoriza() As Boolean
        Get
            Return bln_L_Autoriza
        End Get
        Set(ByVal value As Boolean)
            bln_L_Autoriza = value
        End Set
    End Property
    Public Property Monto_Autorizacion() As String
        Get
            Return str_L_Monto_Auto
        End Get
        Set(ByVal value As String)
            str_L_Monto_Auto = value
        End Set
    End Property
    Public Property Servidor() As String
        Get
            Return str_L_Servidor
        End Get
        Set(ByVal value As String)
            str_L_Servidor = value
        End Set
    End Property
    Public Property OidUsuario() As String
        Get
            Return str_L_OidUsuario
        End Get
        Set(ByVal value As String)
            str_L_OidUsuario = value
        End Set
    End Property
    Public Property OidAlmacen() As String
        Get
            Return str_L_OidAlmacen
        End Get
        Set(ByVal value As String)
            str_L_OidAlmacen = value
        End Set
    End Property
    Public Property OidAgencia() As String
        Get
            Return str_L_OidAgencia
        End Get
        Set(ByVal value As String)
            str_L_OidAgencia = value
        End Set
    End Property
    Public Property Paterno() As String
        Get
            Return str_L_Paterno
        End Get
        Set(ByVal value As String)
            str_L_Paterno = value
        End Set
    End Property
    Public Property Materno() As String
        Get
            Return str_L_Materno
        End Get
        Set(ByVal value As String)
            str_L_Materno = value
        End Set
    End Property
    Public Property Nombres() As String
        Get
            Return str_L_Nombres

        End Get
        Set(ByVal value As String)
            str_L_Nombres = value
        End Set
    End Property
    Public Property Agencia() As String
        Get
            Return str_L_Agencia
        End Get
        Set(ByVal value As String)
            str_L_Agencia = value
        End Set
    End Property
    Public Property UserName() As String
        Get
            Return str_L_UserName
        End Get
        Set(ByVal value As String)
            str_L_UserName = value
        End Set
    End Property
    Public Property Password() As String
        Get
            Return str_L_Password
        End Get
        Set(ByVal value As String)
            str_L_Password = value
        End Set
    End Property
    Public Property Nombre_Completo() As String
        Get
            Return str_L_NombreCompleto
        End Get
        Set(ByVal value As String)
            str_L_NombreCompleto = value
        End Set
    End Property
    Public Property Almacen() As String
        Get
            Return str_L_Almacen
        End Get
        Set(ByVal value As String)
            str_L_Almacen = value
        End Set
    End Property
    Public Property Menues() As Collection
        Get
            Return col_L_Menues
        End Get
        Set(ByVal value As Collection)
            col_L_Menues = value
        End Set
    End Property
    Public Property Formularios() As Collection
        Get
            Return col_L_Formularios
        End Get
        Set(ByVal value As Collection)
            col_L_Formularios = value
        End Set
    End Property
    Public Property Log_DateTime() As String
        Get
            Return str_L_Time_Log
        End Get
        Set(ByVal value As String)
            str_L_Time_Log = value
        End Set
    End Property
    Public Property WorkStation() As String
        Get
            Return str_L_WorkStation
        End Get
        Set(ByVal value As String)
            str_L_WorkStation = value
        End Set
    End Property
    Public Property Win_User() As String
        Get
            Return str_L_Win_User
        End Get
        Set(ByVal value As String)
            str_L_Win_User = value
        End Set
    End Property
    Public Property Acceso_Autorizado() As Boolean
        Get
            Return blnAutorizado

        End Get
        Set(ByVal value As Boolean)
            blnAutorizado = value
        End Set
    End Property
    Public Property Coleccion() As Collection
        Get
            Return colGenerica
        End Get
        Set(ByVal value As Collection)
            colGenerica = value
        End Set
    End Property
    Public Property Tipo_Acceso() As String
        Get
            Return strAccess_Level
        End Get
        Set(ByVal value As String)
            strAccess_Level = value
        End Set
    End Property
    Public Property DireccionMAC() As String
        Get
            Return str_L_MACAdd
        End Get
        Set(ByVal value As String)
            str_L_MACAdd = value
        End Set
    End Property
    Public Property Identificadores_Seleccionados() As String
        Get
            Return str_L_Identificadores_Seleccionados
        End Get
        Set(ByVal value As String)
            str_L_Identificadores_Seleccionados = value
        End Set
    End Property
#End Region
#Region "Metodos"
    Public Sub LogVersionControl()
        Dim col_LogVersionControl As Collection
        Try
            col_LogVersionControl = Nothing
            col_LogVersionControl = New Collection
            If Not (OidUsuario Is Nothing) Then
                strSentenciaSQL = "pa_Ingresa_LogVersion_Control '" & My.Application.Info.Version.ToString & "','" _
                                                    & My.Application.Info.Version.Major & "','" _
                                                    & My.Application.Info.Version.Minor & "','" _
                                                    & My.Application.Info.Version.Build & "','" _
                                                    & My.Application.Info.Version.Revision & "','" _
                                                    & Me.OidUsuario & "','" _
                                                    & Me.WorkStation & "','" _
                                                    & Me.Win_User & "','" _
                                                    & Me.UserName & "','" _
                                                    & Me.DireccionMAC & "'"
                Me.Execute_cmd_No_Results(strSentenciaSQL)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    ''' <summary>
    ''' Este sub determina si el usuario puede validarse y carga sus atributos
    ''' </summary>
    ''' <remarks>
    ''' La información se almacena en un datatable
    ''' </remarks>
    Public Sub Log_In()
        Dim strPaso As String
        Try
            Coleccion = Nothing
            Coleccion = New Collection
            With Coleccion
                .Add(Codificar(Me.UserName))
                .Add(Codificar(Me.Password))
                .Add(Me.OidAlmacen)
            End With
            Return_Records("pa_Load_User_Rights", Coleccion)
            'NOTA: "Storage" es un dataset que se usa para almacenar
            'información de una consulta con mas de un resultado
            strPaso = Storage.Tables.Item(0).Rows(0).Item(0).ToString
            Tipo_Acceso = strPaso
            Select Case strPaso
                Case Is = "COMPLETO", "PARCIAL"
                    Acceso_Autorizado = True
                    'El usuario está registrados, cargamos su info
                    If Storage.Tables.Count > 1 Then
                        With Storage.Tables.Item(1).Rows(0)
                            Me.OidUsuario = .Item(0).ToString
                            Me.OidAlmacen = .Item(1).ToString
                            Me.OidAgencia = .Item(2).ToString
                            Me.Paterno = .Item(3).ToString
                            Me.Materno = .Item(4).ToString
                            Me.Nombres = .Item(5).ToString
                            Me.Agencia = .Item(6).ToString
                            Me.Nombre_Completo = .Item(9).ToString
                            Me.Almacen = .Item(10).ToString
                            Me.Log_DateTime = .Item(11).ToString
                            Me.Servidor = .Item(12).ToString
                            Me.Autoriza = CBool(.Item(13).ToString)
                            Me.Monto_Autorizacion = .Item(14).ToString
                        End With
                        'Adicionamos los formularios a los que tiene acceso el usuario y sus permisos
                        Me.Formularios = Nothing
                        Formularios = New Collection

                        For Each Reng As System.Data.DataRow In Storage.Tables.Item(2).Rows
                            objFormulario = Nothing
                            objFormulario = New SOLink.Formulario
                            With Reng
                                objFormulario.Nombre = .Item(0).ToString
                                objFormulario.Permiso = .Item(1).ToString
                            End With
                            Formularios.Add(objFormulario)
                        Next
                    End If
                Case Is = "INVALIDO"
                    'El usuario no está registrado con el usuario y contraseña indicados (o para pronto, no coinciden password y usuario)
                    Acceso_Autorizado = False
                    Exit Sub
            End Select
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    ''' <summary>
    ''' Permite adicionar un nuevo usuario
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Adicionar()
        Dim col_Exe As Collection
        Try
            col_Exe = Nothing
            col_Exe = New Collection
            strSentenciaSQL = "EXECUTE pa_Registra_Usr '" & _
                              Codificar(RTrim(LTrim(Nombre))).ToString & "', '" & _
                              Codificar(RTrim(LTrim(Paterno))).ToString & "', '" & _
                              Codificar(RTrim(LTrim(Materno))).ToString & "', '" & _
                              Codificar(LTrim(RTrim(UserName))).ToString & "', '" & _
                              Codificar(LTrim(RTrim(Password))).ToString & "', '" & _
                              OidAgencia & "', '" & _
                              OidUsuario & "', '" & _
                              Identificadores_Seleccionados & "'"
            col_Exe.Add(strSentenciaSQL)
            Ejecucion_Transaccionada(col_Exe)
            'Si todo sale bien, cargamos la info del usuario
        Catch ex As Exception
            Throw ex
        End Try

    End Sub
    ''' <summary>
    ''' Permite cargar las agencias, para indicar
    ''' a cual pertenecerá el usuario, siempre y cuando estas 
    ''' tengan relacion con un almacen
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Cargar_Agencias()
        Try
            Return_Records("pa_Listar_Agencias")
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub Cargar_Almacenes_Agencia(ByRef OidAgencia As String)
        Dim colPar As Collection
        Try
            colPar = Nothing
            colPar = New Collection
            colPar.Add(OidAgencia)
            Return_Records("pa_Carga_Listado_Almacenes", colPar)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    ''' <summary>
    ''' Permite listar los usuarios activos
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Listar()
        Try
            Return_Records("pa_Lista_Usuarios_Activos", , True)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub Cargar()
        Dim colPar As Collection
        Try
            colPar = New Collection
            colPar.Add(Me.OidUsuario)
            'Utilizamos la información del set para cargar propiedades
            Return_Records("pa_Load_User_Info", colPar)
            If Not (Storage Is Nothing) Then
                If Storage.Tables.Count > 0 Then
                    With Me.Storage.Tables.Item(0).Rows.Item(0)
                        Me.OidUsuario = .Item(0).ToString
                        Me.OidAgencia = .Item(1).ToString
                        Me.Paterno = .Item(2).ToString
                        Me.Materno = .Item(3).ToString
                        Me.Nombres = .Item(4).ToString
                        Me.Agencia = .Item(5).ToString
                        Me.Nombre_Completo = .Item(6).ToString
                        Me.Autoriza = CBool(.Item(7).ToString)
                        Me.Monto_Autorizacion = .Item(8).ToString
                        Me.UserName = .Item(9).ToString
                        Me.Password = .Item(10).ToString
                    End With
                    '------------------------------------------
                    Forms_Autorized = Storage.Tables.Item(1)
                    Mnus_Autorized = Storage.Tables.Item(2)
                    Permisos = Storage.Tables.Item(3)
                    Almacenes = Storage.Tables.Item(4)
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub Actualizar()
    End Sub
    ''' <summary>
    ''' Desactiva al usuario seleccionado
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub Desactivar()
        Try
            Execute_cmd_No_Results("EXECUTE pa_Deactivate_User_NET '" & OidUsuario & "',' " & OidUsuario_Ejecutor & "'")
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
#End Region
End Class
