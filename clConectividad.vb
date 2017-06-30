Imports Microsoft.Win32
Imports System.Data.SqlClient
Public Class clConectividad
#Region "Herencia"
    Inherits clObjeto
#End Region
#Region "Variables"
    Private LlaveRegistro As RegistryKey, _
            NivelAcceso As System.Security.Permissions.RegistryPermissionAccess, _
            SecurityCard As System.Security.Permissions.RegistryPermission, _
            ds_Local As DataSet, _
            dt_Local As DataTable, _
            int_L_Registros As Int16, _
            dst_Storage As DataSet, _
            dtr_Cabinet As DataTable
    Private v_col_MultiDataTable As Collection
    'Variables para conexion de Formatos
    Private obj_Reg_Key_MTTO As RegistryKey, _
            obj_Reg_Key_Alm As RegistryKey, _
            obj_Reg_Key_Compras As RegistryKey, _
            obj_Reg_Key_Conectividad As RegistryKey, _
            str_Pass_CR As String, _
            str_UserNameDB_CR As String
#End Region
#Region "Propiedades"
#Region "Propiedades de objeto varias"
    Friend Property ds_Datos_Extraccion() As DataSet
        Get
            Return ds_Local
        End Get
        Set(ByVal Value As DataSet)
            ds_Local = Value
        End Set
    End Property
    Public Property dt_Datos() As DataTable
        Get
            Return dt_Local
        End Get
        Set(ByVal Value As DataTable)
            dt_Local = Value
        End Set
    End Property
    Friend Property col_MultiDataTables() As Collection
        Get
            Return v_col_MultiDataTable
        End Get
        Set(ByVal value As Collection)
            v_col_MultiDataTable = value
        End Set
    End Property
    Protected Friend Property Registros_Afectados() As Int16
        Get
            Return int_L_Registros
        End Get
        Set(ByVal value As Int16)
            int_L_Registros = value
        End Set
    End Property
    ''' <summary>
    ''' Contiene en datatables los resultados obtenidos a partir del query
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Storage() As DataSet
        Get
            Return dst_Storage
        End Get
        Set(ByVal value As DataSet)
            dst_Storage = value
        End Set
    End Property
#End Region
#Region "Conexiones para RPTS"
    ''' <summary>
    ''' Crea un objeto RegistryKey que contiene la ruta de los documentos que se usarán en Mtto
    ''' para su visualizacion en reporteador central y su impresion
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Plug_Doc_Mtto() As RegistryKey
        Get
            Return obj_Reg_Key_MTTO
        End Get
        Set(ByVal value As RegistryKey)
            obj_Reg_Key_MTTO = value
        End Set
    End Property
    ''' <summary>
    ''' Crea un objeto RegistryKey que contiene la ruta de los documentos que se usarán en almacen
    ''' para su visualizacion en reporteador central y su impresion
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Plug_Doc_Almacen() As RegistryKey
        Get
            Return obj_Reg_Key_Alm
        End Get
        Set(ByVal value As RegistryKey)
            obj_Reg_Key_Alm = value
        End Set
    End Property
    ''' <summary>
    ''' Crea un objeto RegistryKey que contiene la ruta de los documentos que se usarán en compras
    ''' para su visualizacion en reporteador central y su impresion
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Plug_Doc_Compras() As RegistryKey
        Get
            Return obj_Reg_Key_Compras
        End Get
        Set(ByVal value As RegistryKey)
            obj_Reg_Key_Compras = value
        End Set
    End Property
    ''' <summary>
    ''' Obtiene la cadena de conexion y passwords
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Property Conectividad() As RegistryKey
        Get
            Return obj_Reg_Key_Conectividad
        End Get
        Set(ByVal value As RegistryKey)
            obj_Reg_Key_Conectividad = value
        End Set
    End Property
    Public Property CR_User_DB() As String
        Get
            Return str_UserNameDB_CR

        End Get
        Set(ByVal value As String)
            str_UserNameDB_CR = value
        End Set
    End Property
    Public Property CR_Pass_DB() As String
        Get
            Return str_Pass_CR
        End Get
        Set(ByVal value As String)
            str_Pass_CR = value
        End Set
    End Property

#End Region
#End Region
#Region "Metodos"
#Region "Inicializacion de conexiones de formatos"
    Protected Friend Sub Determinar_Rutas_RPTS()
        '--------------------------------
        'Proyecto   :SIL
        'Programó   :Israel Greß
        'Fecha      :04/Abril/2005
        '--------------------------------
        'Descripcion :Lee el registry y determina la cadena de conexion
        '--------------------------------   
        '[Modificaciones:]
        '13/Noviembre/2008 Igreß
        'Enrutamos la conectividad de SIMA_Net hacia un punto distinto
        Try
            NivelAcceso = Security.Permissions.RegistryPermissionAccess.Read
            SecurityCard = New System.Security.Permissions.RegistryPermission(NivelAcceso, "HKEY_LOCAL_MACHINE\Software\SICOM")
            'Ruta docs Mtto
            Plug_Doc_Mtto = Registry.LocalMachine.OpenSubKey("Software\SICOM\Conexiones\DOCS\MTTO")
            'Ruta docs Alm
            Plug_Doc_Almacen = Registry.LocalMachine.OpenSubKey("Software\SICOM\Conexiones\DOCS\ALM")
            'Ruta docs Compras
            Plug_Doc_Compras = Registry.LocalMachine.OpenSubKey("Software\SICOM\Conexiones\DOCS\COM")
            'Conectividad
            Conectividad = Registry.LocalMachine.OpenSubKey("Software\SICOM\Conexiones")
            With Conectividad
                CR_User_DB = Decodificar(CType(.GetValue("dbUser"), String))
                CR_Pass_DB = Decodificar(CType(.GetValue("dbPass"), String))
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
#End Region
    Protected Friend Function NuevoId() As String
        Dim strOidNew As String
        Try
            strOidNew = Guid.NewGuid.ToString.ToUpper
            Return strOidNew
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Private Sub Leer_Cadena()
        '--------------------------------
        'Proyecto   :SIL
        'Programó   :Israel Greß
        'Fecha      :04/Abril/2005
        '--------------------------------
        'Descripcion :Lee el registry y determina la cadena de conexion
        '--------------------------------   
        '[Modificaciones:]
        '05/Diciembre/2016  Igreß
        'Cambiamos por completo la conectividad
        '05/Abril/2017      Igreß 
        'Adicionamos la posibilidad de conectarse a 32 o 64 bits

        'Produccion
        '////////////////////////////////////////////////////////////////////////
        'LlaveRegistro = Registry.LocalMachine.OpenSubKey("Software\OPL", True)
        'strcnString = Decodificar(LlaveRegistro.GetValue("Verbindung", ""))
        '////////////////////////////////////////////////////////////////////////
        'Data Source=192.168.137.103;Initial Catalog=OPL_DB;User Id=opl_operator;Password=opl_operator;
        Try
            Is64Bit = Environment.Is64BitOperatingSystem            
            If Is64Bit Then

                '***************************************************************************************
                LlaveRegistro = Registry.LocalMachine.OpenSubKey("Software\WOW6432Node\OPL", True)
                '***************************************************************************************
            Else
                '***************************************************************************************            
                LlaveRegistro = Registry.LocalMachine.OpenSubKey("Software\OPL", True)
                '***************************************************************************************            
            End If
            strcnString = Decodificar(LlaveRegistro.GetValue("Verbindung", ""))
            strcnString = strcnString + " async = true"
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub Conectar()
        '--------------------------------
        'Proyecto   :SAT(Suite Administrativa de Telefonia Movil)
        'Programó   :Israel Greß
        'Fecha      :14/Noviembre/2006
        '--------------------------------
        'Descripcion :Genera una conexion a base de datos
        '-------------------------------- 
        Try
            Leer_Cadena()
            cn_Conexion = New Data.SqlClient.SqlConnection(strcnString)
            cn_Conexion.Open()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    ''' <summary>
    ''' Ejecuta un grupo de comandos  de modo transaccionado
    ''' se utiliza principalmente para registro de documentos tales
    ''' como una solicitud de refacciones, ya que almacena el registro padre
    ''' y los items del documento en un solo método
    ''' </summary>
    ''' <param name="colComandos">
    ''' Coleccion donde están los comandos SQL a ejecutar de modo transaccional
    ''' </param>
    ''' <remarks></remarks>
    Friend Sub Ejecucion_Transaccionada(ByRef colComandos As Collection)
        Dim int_L_Indicator As Int16, _
            int_L_Indi_Anidado As Int16, _
            strComando As String, _
            blnTranOpen As Boolean, _
            objArLista As ArrayList, _
            int_Bound_Anidado As Int16
        Try
            Conectar()
            Transaccion = cn_Conexion.BeginTransaction : blnTranOpen = True
            cm_ComandoSQL = New Data.SqlClient.SqlCommand
            With cm_ComandoSQL
                .Connection = cn_Conexion
                NuevoId()
                .Transaction = Transaccion
                For int_L_Indicator = 1 To colComandos.Count
                    objArLista = Nothing
                    objArLista = New ArrayList
                    objArLista.Add(colComandos.Item(int_L_Indicator))
                    int_Bound_Anidado = objArLista.Count - 1
                    For int_L_Indi_Anidado = 0 To int_Bound_Anidado
                        strComando = objArLista.Item(int_L_Indi_Anidado).ToString
                        If Not (strComando Is Nothing) Then
                            .CommandText = strComando
                            Debug.Print(strComando)
                            .ExecuteNonQuery()
                        End If
                    Next
                Next
                Transaccion.Commit()
            End With
        Catch ex As Exception
            If blnTranOpen Then
                Transaccion.Rollback()
            End If
            Throw ex
        Finally
            Me.Desconectar()
        End Try
    End Sub
    Private Sub Desconectar()
        '--------------------------------
        'Proyecto   :SIL(Sistema de llantas)
        'Programó   :Israel Greß
        'Fecha      :11/Abril/2005
        '--------------------------------
        'Descripcion :Desconecta la fuente de datos y libera recursos
        '-------------------------------- 
        '[Modificaciones:]
        Try
            If Not ((cn_Conexion Is Nothing)) Then
                With cn_Conexion
                    If .State = ConnectionState.Open = True Then
                        .Close()
                    End If
                    .Dispose()
                End With
            End If
            If Not (cm_ComandoSQL Is Nothing) Then
                With cm_ComandoSQL
                    .Dispose()
                End With
            End If
        Catch Genex As Exception
            Throw Genex
        End Try
    End Sub
    Protected Friend Sub Execute_cmd_No_Results(ByVal strComando As String)
        '--------------------------------
        'Proyecto   :SAT(Suite Administrativa de Telefonia Movil)
        'Programó   :Israel Greß
        'Fecha      :14/Noviembre/2006
        '--------------------------------
        'Descripcion :Utiliza un comando de SQL para instrucciones que no devuelen un resultado
        '-------------------------------- 
        Try
            Conectar()
            cm_ComandoSQL = New Data.SqlClient.SqlCommand
            With cm_ComandoSQL
                .Connection = cn_Conexion
                .CommandText = strComando
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    ''' <summary>
    ''' Ejecuta una instruccion de SQL de forma asícrona sin devolver ningun registro
    ''' </summary>
    ''' <param name="strComando">
    ''' La sentencia SQL a ejecutar
    ''' </param>
    ''' <remarks>
    ''' Nada adicional
    ''' </remarks>
    Public Sub Execute_cmd_No_Results_Asincrona(ByVal strComando As String)
        '--------------------------------
        'Proyecto   :SAT(Suite Administrativa de Telefonia Movil)
        'Programó   :Israel Greß
        'Fecha      :14/Noviembre/2006
        '--------------------------------
        'Descripcion :Utiliza un comando de SQL para instrucciones que no devuelen un resultado
        '-------------------------------- 
        Try
            Conectar()
            cm_ComandoSQL = New Data.SqlClient.SqlCommand
            With cm_ComandoSQL
                .Connection = cn_Conexion
                .CommandText = strComando
                'Registros_Afectados = .ExecuteNonQuery()
            End With
            iResult = cm_ComandoSQL.BeginExecuteNonQuery(New System.AsyncCallback(AddressOf CerrarEjecucion), cm_ComandoSQL)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub CerrarEjecucion(ByVal iRes As IAsyncResult)
        Try
            cm_ComandoSQL.EndExecuteNonQuery(iRes)
            cm_ComandoSQL.Dispose()
            cm_ComandoSQL = Nothing
            RaiseEvent Async_Advise()
        Catch ex As Exception
            Throw ex
        Finally
            Desconectar()
        End Try
    End Sub
    ''' <summary>
    ''' Ejecuta una sentencia SQL y devuelve resultados
    ''' </summary>
    ''' <param name="strComando"></param>
    ''' <remarks></remarks>
    Public Sub Execute_cmd_With_Results(ByVal strComando As String, _
                                        Optional ByVal PK As Boolean = False, _
                                        Optional ByVal ColIndex As Int16 = 0)
        '--------------------------------
        'Proyecto   :SAT(Suite Administrativa de Telefonia Movil)
        'Programó   :Israel Greß
        'Fecha      :14/Noviembre/2006
        '--------------------------------
        'Descripcion :Utiliza un comando de SQL para instrucciones que SI devuelen un resultado
        '-------------------------------- 
        Try
            Conectar()
            cm_ComandoSQL = New Data.SqlClient.SqlCommand
            With cm_ComandoSQL
                .Connection = cn_Conexion
                .CommandText = strComando
                .CommandType = CommandType.Text
            End With
            dr_Lector = cm_ComandoSQL.ExecuteReader
            ConstruyeTablaDatos(dr_Lector, PK, ColIndex)
        Catch ex As Exception
            Throw ex
        Finally
            Desconectar()
        End Try
    End Sub
    Public Sub Execute_cmd_With_MultiResults(ByVal strComando As String, _
                                            ByRef ColMultiReader As Collection)
        '--------------------------------
        'Proyecto   :libre
        'Programó   :Jorge A. Garcia Chong
        'Fecha      :11/12/07
        '--------------------------------
        'Descripcion :Utiliza un comando de SQL para instrucciones que SI devuelen un resultado
        Try
            Conectar()
            cm_ComandoSQL = New Data.SqlClient.SqlCommand
            With cm_ComandoSQL
                .Connection = cn_Conexion
                .CommandText = strComando
                .CommandType = CommandType.Text
            End With
            dr_Lector = cm_ComandoSQL.ExecuteReader
            If Not (ColMultiReader Is Nothing) Then
                ColMultiReader = Nothing
            End If
            ColMultiReader = New Collection
            Construye_MultiTablas(dr_Lector, ColMultiReader)
        Catch ex As Exception
            Throw ex
        Finally
            Desconectar()
            dr_Lector.Close()
        End Try
    End Sub
    ''' <summary>
    ''' Devuelve los registros de una ejecucion con uno o mas sets de resultados
    ''' </summary>
    ''' <param name="strSPSQL">
    ''' Nombre del stored procedure a ejecutar
    ''' </param>
    ''' <param name="Parametros">
    ''' Opcional- Coleccion de parametros
    ''' </param>
    ''' <param name="DetectarPKs">
    ''' Opcional -Le indica al constructor de tablas si debe localizar y utilizar las columnas PK
    ''' </param>
    ''' <remarks></remarks>
    Protected Friend Sub Return_Records(ByVal strSPSQL As String, _
                              Optional ByRef Parametros As Collection = Nothing, _
                              Optional ByVal DetectarPKs As Boolean = False, _
                              Optional ByVal Resumir_Resultados As Boolean = False)
        '--------------------------------
        'Proyecto   :SAT(Suite Administrativa de Telefonia Movil)
        'Programó   :Israel Greß
        'Fecha      :14/Noviembre/2006
        '--------------------------------
        'Descripcion :Utiliza un comando de SQL para instrucciones que SI devuelen un resultado
        '-------------------------------- 
        Dim int_L_CountParam As Int16
        Try
            Conectar()
            cm_ComandoSQL = New Data.SqlClient.SqlCommand
            With cm_ComandoSQL
                .Connection = cn_Conexion
                .CommandTimeout = 0
                .CommandType = CommandType.StoredProcedure
                .CommandText = strSPSQL
                SqlCommandBuilder.DeriveParameters(cm_ComandoSQL)
                If Not (Parametros Is Nothing) Then
                    If Parametros.Count > 0 Then
                        For int_L_CountParam = 1 To Parametros.Count
                            .Parameters(int_L_CountParam).Value = Parametros.Item(int_L_CountParam).ToString
                        Next
                    End If
                End If
                dr_Lector = .ExecuteReader
            End With
            Build_Storage(dr_Lector, DetectarPKs)
            If Resumir_Resultados Then
                Resumir()
            End If
        Catch ex As Exception
            Throw ex
        Finally
            Desconectar()
            If Not (dr_Lector Is Nothing) Then dr_Lector.Close()
        End Try
    End Sub
    Public Sub Execute_Stored_Procedure(ByVal strSentencia As String, _
                                        Optional ByVal objParam1 As Object = Nothing, _
                                        Optional ByVal objParam2 As Object = Nothing, _
                                        Optional ByVal objParam3 As Object = Nothing)
        '--------------------------------
        'Proyecto   :SAT(Suite Administrativa de Telefonia Movil)
        'Programó   :Israel Greß
        'Fecha      :12/Enero/2006
        '--------------------------------
        'Descripcion :Ejecuta un comando de SQL SERVER, se utiliza primordialmente para el registro de fotos
        '-------------------------------- 
        Try
            Conectar()
            cm_ComandoSQL = New Data.SqlClient.SqlCommand
            With cm_ComandoSQL
                .Connection = cn_Conexion
                .CommandText = strSentencia
                .CommandType = CommandType.StoredProcedure
                .Parameters.Add(objParam1)
                .Parameters.Add(objParam2)
                .ExecuteNonQuery()
            End With
            Desconectar()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    ''' <summary>
    ''' Este procedimiento construye las datatables necesarias
    ''' pa un query que devuelve mas de un set de resultados, cuando
    ''' así se le indica, busca las columnas que son primary keys, esto
    ''' se utiliza para las búsquedas en el TrueDbGrid Net
    ''' </summary>
    ''' <param name="Lector">
    ''' Datareader que tiene los resultados
    ''' </param>
    ''' <param name="Cargar_PKs">
    ''' Indica si se han de cargar los PKS
    ''' </param>
    ''' <remarks>
    ''' Si deseas que los números tengan formato (comas, etc) adiciona a la 
    ''' columna al final los caracteres "_F#5" para 5 decimales y "_F#2" para dos decimales
    ''' </remarks>
    Friend Sub Build_Storage(ByRef Lector As Data.SqlClient.SqlDataReader, _
                             Optional ByVal Cargar_PKs As Boolean = False)
        Dim int_Base As Int16, _
            RenDatos As Data.DataRow, _
            PkDc(0) As Data.DataColumn, _
            colDatos As Data.DataColumn, _
            blnFound As Boolean
        Try
            'Lectura dinamica de columnas y multiresultados
            '**********************************************
            Storage = Nothing 'Destruimos el Dataset (por si las moscas)
            Storage = New DataSet
            blnFound = False
            With Lector
                While .HasRows Or .FieldCount > 0 'Mientras esta condicion se cumpla, podemos recorrer todos los resultados posibles
                    dtr_Cabinet = Nothing
                    dtr_Cabinet = New DataTable
                    PkDc(0) = Nothing
                    'Ciclo para determinar el numero de columnas
                    '*******************************************
                    For int_Base = 0 To .FieldCount - 1
                        colDatos = Nothing
                        colDatos = New Data.DataColumn
                        If InStr(Lector.GetName(int_Base), "_BIN", ) > 0 Then
                            With colDatos
                                .DataType = System.Type.GetType("System.Byte[]")
                            End With
                        Else
                            With colDatos
                                '.DataType = System.Type.GetType(Lector.GetFieldType(int_Base).ToString)
                                .DataType = System.Type.GetType("System.String")
                                .ColumnName = Replace(Lector.GetName(int_Base), "_PK", "")
                            End With
                        End If
                        If Cargar_PKs Then
                            If InStr(Lector.GetName(int_Base), "_PK", ) > 0 Then
                                blnFound = True
                                PkDc(0) = Nothing
                                PkDc(0) = New DataColumn
                                PkDc(0) = colDatos
                            End If
                        End If
                        dtr_Cabinet.Columns.Add(colDatos)
                    Next
                    While .Read
                        RenDatos = dtr_Cabinet.NewRow
                        For int_Base = 0 To (.FieldCount - 1)
                            'If (.GetString(int_Base).ToString Is Nothing) Then
                            'End If
                            If InStr(Lector.GetName(int_Base), "_F#5", CompareMethod.Binary) Then
                                If IsNumeric(.GetString(int_Base).ToString) Then
                                    RenDatos(int_Base) = Format(CDbl(Lector.GetString(int_Base).ToString), "###,###,##0.00000")
                                End If
                            Else
                                If InStr(Lector.GetName(int_Base), "_F#2", CompareMethod.Binary) Then
                                    If IsNumeric(.GetString(int_Base).ToString) Then
                                        RenDatos(int_Base) = Format(CDbl(Lector.GetString(int_Base).ToString), "###,###,##0.00")
                                    End If
                                End If
                                'Modifica: Israel Gress 06/12/2016
                                'RenDatos(int_Base) = RTrim(LTrim(.GetString(int_Base).ToString))
                                'Al utilizar.GetString se obliga a hacer una conversión implícita desde el query
                                'es decir, a hacer un cast o convert, sin embargo, en este caso, se puede 
                                'tomar una letra, caracter o número
                                '--------------------------------------------------------------
                                RenDatos(int_Base) = RTrim(LTrim(.GetValue(int_Base).ToString))
                                '--------------------------------------------------------------
                            End If
                        Next
                        dtr_Cabinet.Rows.Add(RenDatos)
                    End While
                    If Cargar_PKs Then
                        If blnFound Then
                            dtr_Cabinet.PrimaryKey = PkDc
                            blnFound = False
                        End If
                    End If
                    'Adicion de la tabla al Dataset
                    '******************************
                    Storage.Tables.Add(dtr_Cabinet)
                    .NextResult()
                End While
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub ConstruyeTablaDatos(ByRef Lector As Data.SqlClient.SqlDataReader, _
                                    Optional ByVal blnAdicionarPK As Boolean = False, _
                                    Optional ByVal IndexPK As Int16 = 0)
        '--------------------------------
        'Proyecto   :SIL(Sistema de llantas)
        'Programó   :Israel Greß
        'Fecha      :08/Abril/2005
        '--------------------------------
        'Descripcion :Arma una dataTable a partir de un datareader
        '-------------------------------- 
        '[Modificaciones:]
        'Adicion de Pk para busqueda por ordenamiento en TBGrid.Net (A veces odio ese pinche control)
        Dim intContadorColumnas As Int16
        Dim ColDatos As Data.DataColumn
        Dim RenDatos As Data.DataRow
        Dim intCols As Int16
        Dim PkDc(0) As Data.DataColumn
        Try
            dt_Datos = New Data.DataTable
            'intCols = Lector.FieldCount
            '*********************************
            If blnAdicionarPK = True Then
                PkDc(0) = New DataColumn
            End If
            '*********************************
            With Lector
                intCols = Lector.FieldCount
                For intContadorColumnas = 0 To (Lector.FieldCount - 1)
                    ColDatos = New Data.DataColumn
                    ColDatos.DataType = System.Type.GetType("System.String")
                    ColDatos.ColumnName = .GetName(intContadorColumnas).ToString
                    dt_Datos.Columns.Add(ColDatos)
                    If blnAdicionarPK = True Then
                        If intContadorColumnas = 0 Then
                            PkDc(0) = ColDatos
                        End If
                    End If
                Next
                While .Read
                    RenDatos = dt_Datos.NewRow
                    For intContadorColumnas = 0 To (Lector.FieldCount - 1)
                        RenDatos(intContadorColumnas) = .GetString(intContadorColumnas).ToString
                    Next
                    dt_Datos.Rows.Add(RenDatos)
                    If blnAdicionarPK = True Then
                        dt_Datos.PrimaryKey = PkDc
                    End If
                End While
            End With
        Catch Genex As Exception
            Throw Genex
        End Try
    End Sub
    Friend Sub Construye_MultiTablas(ByRef Lector As Data.SqlClient.SqlDataReader, ByRef ColMultiReader As Collection)
        '--------------------------------
        'Proyecto   :Libre
        'Programó   :Jorge A. Garcia
        'Fecha      :11/12/07
        '--------------------------------
        'Descripcion : crea tablas para cada datareader 
        '-------------------------------- 
        '[Modificaciones:]
        Dim intContadorColumnas As Int16
        Dim ColDatos As Data.DataColumn
        Dim RenDatos As Data.DataRow
        'En esta coleccion local guardamos todas los data tables que se crean aqui a partir del query
        Dim col_DataTables As New Collection

        Try
            'Establecemos una coleccion limpia
            If Not (col_DataTables Is Nothing) Then
                col_DataTables = Nothing
            End If

            col_DataTables = New Collection

            'Usamos el dataReader y su metodo fieldcount para verificar que existan datatables

            With Lector
                While .FieldCount > 0

                    'aqui hacemos constar que va a crear diferentes datatables 
                    'para cada resultado del reader

                    If Not (dt_Datos Is Nothing) Then
                        dt_Datos = Nothing
                    End If

                    dt_Datos = New Data.DataTable

                    'formateamos el datatable con las columnas especificando el tipo string y nombre

                    For intContadorColumnas = 0 To (Lector.FieldCount - 1)
                        ColDatos = New Data.DataColumn
                        ColDatos.DataType = System.Type.GetType("System.String")
                        ColDatos.ColumnName = .GetName(intContadorColumnas).ToString
                        dt_Datos.Columns.Add(ColDatos)
                    Next

                    'Le adicionamos los datos del resultado del datareader al datatable formateado

                    While .Read
                        RenDatos = dt_Datos.NewRow
                        For intContadorColumnas = 0 To (Lector.FieldCount - 1)
                            RenDatos(intContadorColumnas) = .GetString(intContadorColumnas).ToString
                        Next

                        dt_Datos.Rows.Add(RenDatos)

                    End While

                    'Almacenamos el datatable en la coleccion

                    'col_DataTables.Add(dt_Datos)
                    ColMultiReader.Add(dt_Datos)

                    'Buscamos el siguiente resultado del data reader y ciclamos

                    .NextResult()

                End While

                'Por ultimo copiamos la coleccion local en la propidead del mismo tipo pero global
                'para extraer los datos en el form

                col_MultiDataTables = col_DataTables
            End With
        Catch Genex As Exception
            'si existe algun contratiempo generamos una exepcion para devolverla en el from
            Throw Genex
        End Try
    End Sub
    Friend Function Decodificar(ByVal Cadena_Codificada As String)
        Dim varFin As String, _
            CurSpc As Int16, _
            varLen As Int16, _
            vText As String, _
            varChr As String
        Try
            varFin = ""
            CurSpc = 0
            CurSpc = CurSpc + 1
            vText = Cadena_Codificada
            varLen = Len(vText)
            Do While CurSpc <= varLen
                varChr = Mid(vText, CurSpc, 3)
                Select Case varChr
                    'minuscula
                    Case "coe", "BEC"
                        '------------
                        varChr = "a"
                    Case "wer", "RVM"
                        varChr = "b"
                        '------------
                    Case "ibq", "UJO"
                        varChr = "c"
                        '------------
                    Case "am7", "RVG"
                        varChr = "d"
                        '------------
                    Case "pm1", "OVI"
                        varChr = "e"
                        '------------
                    Case "mop", "VBU"
                        varChr = "f"
                        '------------
                    Case "9v4", "WST"
                        varChr = "g"
                        '------------
                    Case "qu6", "XGK"
                        varChr = "h"
                        '------------
                    Case "zxc", "JXG"
                        varChr = "i"
                        '------------
                    Case "4mp", "LGK"
                        varChr = "j"
                        '------------
                    Case "f88", "MFP"
                        varChr = "k"
                        '------------
                    Case "qe2", "AGO"
                        varChr = "l"
                        '------------
                    Case "vbn", "HAH"
                        varChr = "m"
                        '------------
                    Case "qwt", "INS"
                        varChr = "n"
                        '------------
                    Case "pl5", "EAE"
                        varChr = "o"
                        '------------
                    Case "13s", "ZIH"
                        varChr = "p"
                        '------------
                    Case "c%l", "WGJ"
                        varChr = "q"
                        '------------
                    Case "w$w", "ZBX"
                        varChr = "r"
                        '------------
                    Case "6a@", "SAX"
                        varChr = "s"
                        '------------
                    Case "!2&", "XJH"
                        varChr = "t"
                        '------------
                    Case "(=c", "PBG"
                        varChr = "u"
                        '------------
                    Case "wvf", "TZP"
                        varChr = "v"
                        '------------
                    Case "dp0", "BJS"
                        varChr = "w"
                        '------------
                    Case "w$-", "HQK"
                        varChr = "x"
                        '------------
                    Case "vn&", "AXM"
                        varChr = "y"
                        '------------
                    Case "c*4", "YNW"
                        varChr = "z"
                        '------------
                        'numeros
                    Case "aq@", "MMY"
                        varChr = "1"
                        '------------
                    Case "902", "DYZ"
                        varChr = "2"
                        '------------
                    Case "2.&", "JZD"
                        varChr = "3"
                        '------------
                    Case "/w!", "FNX"
                        varChr = "4"
                        '------------
                    Case "|pq", "KWC"
                        varChr = "5"
                        '------------
                    Case "ml|", "MOC"
                        varChr = "6"
                        '------------
                    Case "t@?", "WSS"
                        varChr = "7"
                        '------------
                    Case ">^s", "LHR"
                        varChr = "8"
                        '------------
                    Case "<s^", "CVF"
                        varChr = "9"
                        '------------
                    Case ";&c", "MNC"
                        varChr = "0"
                        '------------
                        'mayusculas
                    Case "$)c", "JQA"
                        varChr = "A"
                        '------------
                    Case "-gt", "FGC"
                        varChr = "B"
                        '------------
                    Case "|p*", "DYM"
                        varChr = "C"
                        '------------
                    Case "1" & Chr(34) & "r", "KLE"
                        varChr = "D"
                        '------------
                    Case "c>:", "HDN"
                        varChr = "E"
                        '------------
                    Case "@+x", "KWH"
                        varChr = "F"
                        '------------
                    Case "v^a", "GXS"
                        varChr = "G"
                        '------------
                    Case "]eE", "KIV"
                        varChr = "H"
                        '------------
                    Case "aP0", "FSB"
                        varChr = "I"
                        '------------
                    Case "{=1", "MKL"
                        varChr = "J"
                        '------------
                    Case "cWv", "HXP"
                        varChr = "K"
                        '------------
                    Case "cDc", "UKJ"
                        varChr = "L"
                        '------------
                    Case "*,!", "KTF"
                        varChr = "M"
                        '------------
                    Case "fW" & Chr(34), "MHZ"
                        varChr = "N"
                        '------------
                    Case ".?T", "HYP"
                        varChr = "O"
                        '------------
                    Case "%<8", "MDI"
                        varChr = "P"
                        '------------
                    Case "@:a", "CQU"
                        varChr = "Q"
                        '------------
                    Case "&c$", "KOK"
                        varChr = "R"
                        '------------
                    Case "WnY", "VQM"
                        varChr = "S"
                        '------------
                    Case "{Sh", "DXI"
                        varChr = "T"
                        '------------
                    Case "_%M", "TFT"
                        varChr = "U"
                        '------------
                    Case "}@$", "LPG"
                        varChr = "V"
                        '------------
                    Case "QlU", "HTL"
                        varChr = "W"
                        '------------
                    Case "Im^", "OBY"
                        varChr = "X"
                        '------------
                    Case "l|P", "OOP"
                        varChr = "Y"
                        '------------
                    Case ".>#", "DAD"
                        varChr = "Z"
                        '------------
                        'Caracteres especiales
                    Case "\" & Chr(34) & "]", "ULV"
                        varChr = "!"
                        '------------
                    Case "cY,", "CGA"
                        varChr = "@"
                        '------------
                    Case "x%B", "LZL"
                        varChr = "#"
                        '------------
                    Case "a*v", "HRH"
                        varChr = "$"
                        '------------
                    Case "@&T", "NRL"
                        varChr = "%"
                        '------------
                    Case ";%R", "QJV"
                        varChr = "^"
                        '------------
                    Case "eG_", "YXA"
                        varChr = "&"
                        '------------
                    Case "Z/e", "QVS"
                        varChr = "*"
                        '------------
                    Case "rG\", "CIR"
                        varChr = "("
                        '------------
                    Case "]*F", "SCG"
                        varChr = ")"
                        '------------
                    Case "@B*", "LDP"
                        varChr = "_"
                        '------------
                    Case "+Hc", "HLX"
                        varChr = "-"
                        '------------
                    Case "&|D", "DQY"
                        varChr = "="
                        '------------
                    Case "(:#", "UWM"
                        varChr = "+"
                        '------------
                    Case "SlW", "NDL"
                        varChr = "["
                        '------------
                    Case "@QB", "XCV"
                        varChr = "]"
                        '------------
                    Case "{D>", "UES"
                        varChr = "{"
                        '------------
                    Case "+c%", "DHG"
                        varChr = "}"
                        '------------
                    Case "(s:", "UVN"
                        varChr = ":"
                        '------------
                    Case "^a(", "OBG"
                        varChr = ";"
                        '------------
                    Case "16.", "XTA"
                        varChr = "'"
                        '------------
                    Case "s.*", "ZGA"
                        varChr = Chr(34)
                        '------------
                    Case "&?W", "ZQP"
                        varChr = ","
                        '------------
                    Case "GPQ", "SCC"
                        varChr = "."
                        '------------
                    Case "SK*", "VFI"
                        varChr = "<"
                        '------------
                    Case "RL^", "PAG"
                        varChr = ">"
                        '------------
                    Case "40C", "EMP"
                        varChr = "/"
                        '------------
                    Case "?#9", "CVG"
                        varChr = "?"
                        '------------
                    Case "_?/", "AXP"
                        varChr = "\"
                        '------------
                    Case "(_@", "BIY"
                        varChr = "|"
                        '------------
                    Case "=#B", "GUH"
                        varChr = " "
                End Select
                varFin = varFin & varChr
                CurSpc = CurSpc + 3
            Loop
            Return varFin
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Friend Function Codificar(ByVal CadenaNormal As String)
        Dim varFin As String, _
            CurSpc As Int16, _
            varLen As Int16, _
            vText As String, _
            varChr As String
        vText = CadenaNormal
        varFin = ""
        CurSpc = 0
        varLen = Len(vText)
        Do While CurSpc <= varLen
            CurSpc = CurSpc + 1
            varChr = Mid(vText, CurSpc, 1)
            Select Case varChr
                'minuscula
                Case "a"
                    varChr = "coe"
                Case "b"
                    varChr = "wer"
                Case "c"
                    varChr = "ibq"
                Case "d"
                    varChr = "am7"
                Case "e"
                    varChr = "pm1"
                Case "f"
                    varChr = "mop"
                Case "g"
                    varChr = "9v4"
                Case "h"
                    varChr = "qu6"
                Case "i"
                    varChr = "zxc"
                Case "j"
                    varChr = "4mp"
                Case "k"
                    varChr = "f88"
                Case "l"
                    varChr = "qe2"
                Case "m"
                    varChr = "vbn"
                Case "n"
                    varChr = "qwt"
                Case "o"
                    varChr = "pl5"
                Case "p"
                    varChr = "13s"
                Case "q"
                    varChr = "c%l"
                Case "r"
                    varChr = "w$w"
                Case "s"
                    varChr = "6a@"
                Case "t"
                    varChr = "!2&"
                Case "u"
                    varChr = "(=c"
                Case "v"
                    varChr = "wvf"
                Case "w"
                    varChr = "dp0"
                Case "x"
                    varChr = "w$-"
                Case "y"
                    varChr = "vn&"
                Case "z"
                    varChr = "c*4"

                    'numeros
                Case "1"
                    varChr = "aq@"
                Case "2"
                    varChr = "902"
                Case "3"
                    varChr = "2.&"
                Case "4"
                    varChr = "/w!"
                Case "5"
                    varChr = "|pq"
                Case "6"
                    varChr = "ml|"
                Case "7"
                    varChr = "t@?"
                Case "8"
                    varChr = ">^s"
                Case "9"
                    varChr = "<s^"
                Case "0"
                    varChr = ";&c"

                    'mayusculas
                Case "A"
                    varChr = "$)c"
                Case "B"
                    varChr = "-gt"
                Case "C"
                    varChr = "|p*"
                Case "D"
                    varChr = "1" & Chr(34) & "r"
                Case "E"
                    varChr = "c>:"
                Case "F"
                    varChr = "@+x"
                Case "G"
                    varChr = "v^a"
                Case "H"
                    varChr = "]eE"
                Case "I"
                    varChr = "aP0"
                Case "J"
                    varChr = "{=1"
                Case "K"
                    varChr = "cWv"
                Case "L"
                    varChr = "cDc"
                Case "M"
                    varChr = "*,!"
                Case "N"
                    varChr = "fW" & Chr(34)
                Case "O"
                    varChr = ".?T"
                Case "P"
                    varChr = "%<8"
                Case "Q"
                    varChr = "@:a"
                Case "R"
                    varChr = "&c$"
                Case "S"
                    varChr = "WnY"
                Case "T"
                    varChr = "{Sh"
                Case "U"
                    varChr = "_%M"
                Case "V"
                    varChr = "}@$"
                Case "W"
                    varChr = "QlU"
                Case "X"
                    varChr = "Im^"
                Case "Y"
                    varChr = "l|P"
                Case "Z"
                    varChr = ".>#"
                    'Caracteres especiales
                Case "!"
                    varChr = "\" & Chr(34) & "]"
                Case "@"
                    varChr = "cY,"
                Case "#"
                    varChr = "x%B"
                Case "$"
                    varChr = "a*v"
                Case "%"
                    varChr = "@&T"
                Case "^"
                    varChr = ";%R"
                Case "&"
                    varChr = "eG_"
                Case "*"
                    varChr = "Z/e"
                Case "("
                    varChr = "rG\"
                Case ")"
                    varChr = "]*F"
                Case "_"
                    varChr = "@B*"
                Case "-"
                    varChr = "+Hc"
                Case "="
                    varChr = "&|D"
                Case "+"
                    varChr = "(:#"
                Case "["
                    varChr = "SlW"
                Case "]"
                    varChr = "@QB"
                Case "{"
                    varChr = "{D>"
                Case "}"
                    varChr = "+c%"
                Case ":"
                    varChr = "(s:"
                Case ";"
                    varChr = "^a("
                Case "'"
                    varChr = "16."
                Case Chr(34)
                    varChr = "s.*"
                Case ","
                    varChr = "&?W"
                Case "."
                    varChr = "GPQ"
                Case "<"
                    varChr = "SK*"
                Case ">"
                    varChr = "RL^"
                Case "/"
                    varChr = "40C"
                Case "?"
                    varChr = "?#9"
                Case "\"
                    varChr = "_?/"
                Case "|"
                    varChr = "(_@"
                Case " "
                    varChr = "=#B"
            End Select
            varFin = varFin & varChr
        Loop
        Return varFin
    End Function
    ''' <summary>
    ''' Este procedimiento toma los resultados obtenidos en la tabla y los asigna a variables
    ''' una booleana para indicar si la transacción fué exitosa o no y en caso necesario
    ''' una breve explicación de la situación por la cual la transacción fracasó
    ''' I.Greß
    ''' </summary>
    ''' <remarks></remarks>
    Protected Friend Sub Resumir()
        Try
            With Me.Storage.Tables.Item(0).Rows.Item(0)
                Me.Tran_Ok = CBool(.Item(0))
                Me.Situacion = .Item(1).ToString
            End With
        Catch ex As Exception
            Throw
        End Try
    End Sub
#End Region
#Region "Eventos"
    Public Event Instruccion_Ejecutada As StatementCompletedEventHandler
    Public Event Async_Advise()
#End Region
End Class
