Module ActInterf
    Public Sub ActualizarInt(ByVal Caso As Integer, ByRef Formulario As Form, Optional ByRef Objeto_Utileria As Object = Nothing, Optional ByRef OBJ_U2 As Object = Nothing)
        Dim str_P_FormName As String, _
            col_p_Ctrls As Collection
        Try
            str_P_FormName = Formulario.Name.ToString
            Select Case str_P_FormName
                Case Is = "frmAlmacen"
                    Select Case Caso
                        Case Is = 1
                            With DirectCast(Formulario, frmAlmacen)
                                .cmd_prc_ubs.Text = "&Iniciar"
                                .cmd_qry_ents.Enabled = False
                                '.cmd_exe_qry_ubs.Enabled = False
                            End With
                        Case Is = 2
                            'Activamos diferentes combos en función del tipo de entidad a registrar
                            If Not (Objeto_Utileria Is Nothing) Then
                                '------------------------
                                bln_G_Mod_Edicion = True
                                '------------------------
                                With DirectCast(Formulario, frmAlmacen)
                                    With .cbo_prc_ubi
                                        .DataSource = Nothing
                                        .Items.Clear()
                                        .Text = Nothing
                                    End With
                                    With .cbo_prc_anaq
                                        .DataSource = Nothing
                                        .Items.Clear()
                                        .Text = Nothing
                                    End With
                                    With .cbo_prc_alm
                                        .DataSource = Nothing
                                        .Items.Clear()
                                        .Text = Nothing
                                    End With
                                    'Llenamos el combo de empresa
                                    .cbo_entidad.Enabled = False
                                    .cbo_prc_emp_ubi.DropDownStyle = ComboBoxStyle.DropDownList
                                    modHerramientas.CargaCombo(.cbo_prc_emp_ubi, DirectCast(OBJ_U2, DataTable), 0, 1, , False)
                                    '----------------------------------------------------------------------------------------------------
                                    Select Case DirectCast(Objeto_Utileria, Integer)
                                        Case Is = 0 'Almacen
                                            With .cbo_prc_alm
                                                .DropDownStyle = ComboBoxStyle.Simple
                                                .Enabled = True
                                            End With
                                            .cmd_prc_ubs.Text = "&Guardar"
                                        Case Is = 1 'Anaquel
                                            'verificamos e instanciamos el objeto                                            
                                            obj_g_almacen = Nothing
                                            obj_g_almacen = New BoAlmacenSH.Almacen
                                            With obj_g_almacen
                                                .id_empresa = DirectCast(OBJ_U2, DataTable).Rows(0).Item(0)
                                                .listar()
                                            End With
                                            .cbo_prc_alm.DropDownStyle = ComboBoxStyle.DropDownList
                                            '------------------------
                                            bln_G_Mod_Edicion = True
                                            '------------------------
                                            CargaCombo(.cbo_prc_alm, obj_g_almacen.Storage.Tables.Item(0), 0, 1, False, True, , , )
                                            '------------------------
                                            bln_G_Mod_Edicion = False
                                            '------------------------
                                            bln_G_Mod_Edicion = True
                                            '------------------------
                                            With .cbo_prc_anaq
                                                .DataSource = Nothing
                                                .Text = Nothing
                                                .DropDownStyle = ComboBoxStyle.Simple
                                                .Enabled = True
                                                .Focus()
                                            End With
                                            '------------------------
                                            bln_G_Mod_Edicion = False
                                            '------------------------
                                            With .cmd_prc_ubs
                                                .Text = "&Guardar"
                                            End With
                                        Case Is = 2 'Ubicacion
                                            'verificamos e instanciamos el objeto                                            
                                            obj_g_almacen = Nothing
                                            obj_g_almacen = New BoAlmacenSH.Almacen
                                            With obj_g_almacen
                                                .id_empresa = DirectCast(OBJ_U2, DataTable).Rows(0).Item(0)
                                                .listar()
                                            End With
                                            .cbo_prc_alm.DropDownStyle = ComboBoxStyle.DropDownList
                                            '------------------------
                                            bln_G_Mod_Edicion = True
                                            '------------------------
                                            CargaCombo(.cbo_prc_alm, obj_g_almacen.Storage.Tables.Item(0), 0, 1, False, True, , , )
                                            '------------------------
                                            With .cbo_prc_anaq
                                                .DropDownStyle = ComboBoxStyle.DropDownList
                                                .DataSource = Nothing
                                                .Items.Clear()
                                                .Enabled = False
                                            End With
                                            With .cbo_prc_ubi
                                                .DataSource = Nothing
                                                .Items.Clear()
                                                .DropDownStyle = ComboBoxStyle.Simple
                                                .Enabled = False
                                            End With
                                            '------------------------
                                            With .cmd_prc_ubs
                                                .Text = "&Guardar"
                                            End With
                                            bln_G_Mod_Edicion = False
                                    End Select
                                End With
                            End If
                        Case Is = 3
                            'Limpieza posterior a la adicion
                            With DirectCast(Formulario, frmAlmacen)
                                With .cbo_entidad
                                    .DropDownStyle = ComboBoxStyle.DropDown
                                    .DataSource = Nothing
                                    .Items.Clear()
                                    .Text = Nothing
                                    .Enabled = False
                                End With
                                With .cbo_prc_emp_ubi
                                    .DropDownStyle = ComboBoxStyle.DropDown
                                    .DataSource = Nothing
                                    .Items.Clear()
                                    .Text = Nothing
                                    .Enabled = False
                                End With
                                With .cbo_prc_alm
                                    .DropDownStyle = ComboBoxStyle.DropDown
                                    .DataSource = Nothing
                                    .Items.Clear()
                                    .Text = Nothing
                                    .Enabled = False
                                End With
                                .cmd_prc_ubs.Text = "&Procesar"
                                .cmd_qry_ents.Enabled = True
                                '.cmd_exe_qry_ubs.Enabled = True
                            End With
                        Case Is = 4
                            'Cancelación en "Inicio"
                            With DirectCast(Formulario, frmAlmacen)
                                With .cbo_entidad
                                    .DataSource = Nothing
                                    .Items.Clear()
                                    .Text = Nothing
                                    .Enabled = False
                                    '.SelectedIndex = -1
                                End With
                                .cmd_prc_ubs.Text = "&Procesar"
                                .cmd_qry_ents.Enabled = True
                                '.cmd_exe_qry_ubs.Enabled = True
                                dt_m_empresa = Nothing
                            End With
                        Case Is = 5
                            '-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+
                            bln_G_Mod_Edicion = True
                            With DirectCast(Formulario, frmAlmacen)
                                '@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
                                With .cbo_entidad
                                    .DropDownStyle = ComboBoxStyle.DropDown
                                    .DataSource = Nothing
                                    .Text = Nothing
                                    .Items.Clear()
                                    .Enabled = False
                                End With
                                '@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
                                With .cbo_prc_emp_ubi
                                    .DropDownStyle = ComboBoxStyle.DropDown
                                    .DataSource = Nothing
                                    .Text = Nothing
                                    .Items.Clear()
                                    .Enabled = False
                                End With
                                '@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
                                With .cbo_prc_ubi
                                    .DropDownStyle = ComboBoxStyle.DropDown
                                    .DataSource = Nothing
                                    .Text = Nothing
                                    .Items.Clear()
                                    .Enabled = False
                                End With
                                '*******************************************
                                With .cbo_prc_anaq
                                    .DropDownStyle = ComboBoxStyle.DropDown
                                    .DataSource = Nothing
                                    .Text = Nothing
                                    .Items.Clear()
                                    .Enabled = False
                                End With
                                '*******************************************
                                With .cbo_prc_alm
                                    .DropDownStyle = ComboBoxStyle.DropDown
                                    .DataSource = Nothing
                                    .Text = Nothing
                                    .Items.Clear()
                                    .Enabled = False
                                End With
                                '///////////////////////////////////////////
                                .cmd_prc_ubs.Text = "&Procesar"
                                '.cmd_exe_qry_ubs.Enabled = True
                                .cmd_qry_ents.Enabled = True
                                '///////////////////////////////////////////
                            End With
                            '-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+
                            bln_G_Mod_Edicion = False
                        Case Is = 6
                            With DirectCast(Formulario, frmAlmacen)
                                Select Case DirectCast(OBJ_U2, Integer)
                                    Case Is = 1 'Anaquel
                                        With .cbo_prc_anaq
                                            .DataSource = Nothing
                                            .Items.Clear()
                                            .Text = Nothing
                                            .DropDownStyle = ComboBoxStyle.Simple
                                            .Enabled = True
                                        End With
                                End Select
                            End With
                            '---------------------------------------------------------
                            'inicia el registro de un nuevo articulo
                            '---------------------------------------------------------
                        Case Is = 7
                            '*****************************************
                            Activar_Interface(Formulario, False, True)
                            '*****************************************
                            'Para evitar problemas con las operaciones de los combos
                            bln_G_Mod_Edicion = True
                            '*****************************************
                            obj_g_combustible = Nothing
                            obj_g_combustible = New BOVehicleSH.TipoCombustible
                            obj_g_combustible.Listar()
                            '**********************************
                            Activar_Interface(Formulario, True)
                            '**********************************
                            With DirectCast(Formulario, frmAlmacen)
                                .qr_codigo_item.Text = "ready"
                                .cmd_prc_art.Text = "&Validar"
                                CargaCombo(.cbo_typ_fuel, obj_g_combustible.Storage.Tables(0), 0, 1, , True, , , True)
                                '/////////////////////////
                                bln_G_Mod_Edicion = False
                                '/////////////////////////
                                With .txt_num_parte
                                    .Enabled = True
                                    .ReadOnly = False
                                    .Text = Nothing
                                End With
                                With .txt_descrip_art
                                    .Enabled = True
                                    .ReadOnly = False
                                    .Text = Nothing
                                    .Focus()
                                End With

                            End With
                        Case Is = 8
                            With DirectCast(Formulario, frmAlmacen)
                                .qr_codigo_item.Text = "meine Nummer ist siebenundvierzig"
                                .txt_cod_interno.Text = Nothing
                                .txt_num_parte.Text = Nothing
                                .txt_descrip_art.Text = Nothing
                                '///////////////////////
                                bln_G_Mod_Edicion = True
                                '///////////////////////
                                ResetCombo(.cbo_typ_conj, False)
                                ResetCombo(.cbo_typ_veh, False)
                                ResetCombo(.cbo_typ_fuel, False)
                                '///////////////////////
                                bln_G_Mod_Edicion = False
                                '///////////////////////
                                .cmd_prc_art.Text = "&Procesar"
                            End With
                    End Select
                Case Is = "frmCatalogos"
                    Select Case Caso
                        Case Is = 1
                            With DirectCast(Formulario, frmCatalogos)
                                .cmdProcesarTipoVeh.Text = "&Guardar"
                                Reset_Grid(.tdbgTiposVehiculo)
                                With .cmdXprtTiVh
                                    .Text = "Consultar"
                                    .Enabled = False
                                End With
                            End With
                        Case Is = 2
                            'Registro exitoso
                            With DirectCast(Formulario, frmCatalogos)
                                ResetCombo(.cboUso, False)
                                ResetCombo(.cboCombustible)
                                Reset_Grid(.tdbgTiposVehiculo)
                                With .cmdKill
                                    .Enabled = False
                                    .Visible = False
                                End With
                                With .txtDescripcion
                                    .Text = Nothing
                                    .Enabled = False
                                End With
                                With .cmdProcesarTipoVeh
                                    .Text = "&Nuevo"
                                    .Focus()
                                End With
                                With .cmdXprtTiVh
                                    .Enabled = True
                                    .Text = "Consultar"
                                End With

                            End With
                        Case Is = 3
                            If Not Objeto_Utileria Is Nothing Then
                                'Carga de las propiedades del tipo de vehiculo
                                With DirectCast(Formulario, frmCatalogos)
                                    .cboCombustible.Text = DirectCast(Objeto_Utileria, BOVehicleSH.TipoVehiculo).Combustible
                                    .cboUso.Text = DirectCast(Objeto_Utileria, BOVehicleSH.TipoVehiculo).Uso
                                    .txtDescripcion.Text = DirectCast(Objeto_Utileria, BOVehicleSH.TipoVehiculo).Descripcion
                                    .cmdProcesarTipoVeh.Text = "&Editar"
                                End With
                            End If
                        Case Is = 4
                            With DirectCast(Formulario, frmCatalogos)
                                Reset_Grid(.tdbgMarca, False)
                                .cmdProcessMarca.Text = "&Guardar"
                                .cmdXporMarca.Enabled = False
                                With .txtMarca
                                    .Enabled = True
                                    .Text = Nothing
                                    .Focus()
                                End With
                            End With
                        Case Is = 5
                            'Preparamos la interfaz para edición de una marca
                            With DirectCast(Formulario, frmCatalogos)
                                .tdbgMarca.Enabled = False
                                .cmdXporMarca.Enabled = False
                                .cmdProcessMarca.Text = "&Actualizar"
                                With .txtMarca
                                    .Enabled = True
                                    .Focus()
                                End With
                            End With
                        Case Is = 6
                            With DirectCast(Formulario, frmCatalogos)
                                Reset_Grid(.tdbgMarca)
                                With .txtMarca
                                    .Text = Nothing
                                    .Enabled = False
                                End With
                                .cmdProcessMarca.Text = "&Nuevo"
                                .cmdXporMarca.Enabled = True
                            End With
                            'Activamos el alta de un vehículo
                        Case Is = 7
                            With DirectCast(Formulario, frmCatalogos)
                                Reset_Grid(.tdbgUnidades, False)
                                With .txtModelo
                                    .Text = Nothing
                                    .Enabled = True
                                End With
                                With .numAño
                                    .Value = 2000
                                    .Enabled = True
                                End With
                                With .txtMatricula
                                    .Text = Nothing
                                    .Enabled = True
                                End With
                                With .cmdKillUnit
                                    .Enabled = False
                                    .Visible = False
                                End With
                                With .txtEco
                                    .Text = Nothing
                                    .Enabled = True
                                End With
                                With .txtSerieMotor
                                    .Text = Nothing
                                    .Enabled = True
                                End With
                                With .txtSerieChasis
                                    .Text = Nothing
                                    .Enabled = True
                                End With
                                With .cmdXportUns
                                    .Enabled = False
                                    .Visible = False
                                End With
                                .cmdXprtVehiculo.Enabled = False
                                .cmdProcesarVehiculo.Text = "&Guardar"
                            End With
                        Case Is = 8
                            'Preparamos la interfaz después de un registro de unidad
                            With DirectCast(Formulario, frmCatalogos)
                                .cmdXprtVehiculo.Enabled = True
                                ResetCombo(.cboTipoUnidad, False)
                                ResetCombo(.cboMarca, False)
                                With .txtEco
                                    .Text = Nothing
                                    .Enabled = False
                                End With
                                With .txtSerieMotor
                                    .Text = Nothing
                                    .Enabled = False
                                End With
                                With .txtSerieChasis
                                    .Text = Nothing
                                    .Enabled = False
                                End With
                                With .txtMatricula
                                    .Text = Nothing
                                    .Enabled = False
                                End With
                                With .txtModelo
                                    .Text = Nothing
                                    .Enabled = False
                                End With
                                With .numAño
                                    .Value = 2000
                                    .Enabled = False
                                End With
                                .cmdProcesarVehiculo.Text = "&Nuevo"
                                'Adiciono este pedacito de codigo, para limpiar en caso de edición
                                With .cmdKillUnit
                                    .Enabled = False
                                    .Visible = False
                                End With
                                Reset_Grid(.tdbgUnidades, False)
                            End With
                        Case Is = 9
                            With DirectCast(Formulario, frmCatalogos)
                                If Not (Objeto_Utileria Is Nothing) Then
                                    .cboTipoUnidad.Text = DirectCast(Objeto_Utileria, BOVehicleSH.Vehiculo).Tipo.Descripcion
                                    .cboMarca.Text = DirectCast(Objeto_Utileria, BOVehicleSH.Vehiculo).Marca.Descripcion
                                    .txtEco.Text = DirectCast(Objeto_Utileria, BOVehicleSH.Vehiculo).Economico
                                    .txtSerieMotor.Text = DirectCast(Objeto_Utileria, BOVehicleSH.Vehiculo).SerieMotor
                                    .txtSerieChasis.Text = DirectCast(Objeto_Utileria, BOVehicleSH.Vehiculo).SerieChasis
                                    .txtMatricula.Text = DirectCast(Objeto_Utileria, BOVehicleSH.Vehiculo).Matricula
                                    .txtModelo.Text = DirectCast(Objeto_Utileria, BOVehicleSH.Vehiculo).Modelo
                                    .numAño.Value = DirectCast(Objeto_Utileria, BOVehicleSH.Vehiculo).Año
                                    .cmdProcesarVehiculo.Text = "&Editar"
                                End If
                            End With
                        Case Is = 10
                            'Preparación para la edición de un vehículo
                            With DirectCast(Formulario, frmCatalogos)
                                col_p_Ctrls = New Collection
                                col_p_Ctrls.Add(.cmdXporMarca)
                                col_p_Ctrls.Add(.cmdKillUnit)
                                col_p_Ctrls.Add(.tdbgUnidades)
                                Activa_Desactiva__Gpo_Controles(col_p_Ctrls, False)
                                .cmdXportUns.Visible = False
                                .cmdKillUnit.Visible = True
                                col_p_Ctrls = Nothing
                                col_p_Ctrls = New Collection
                                col_p_Ctrls.Add(.cboTipoUnidad)
                                col_p_Ctrls.Add(.cboMarca)
                                col_p_Ctrls.Add(.txtEco)
                                col_p_Ctrls.Add(.txtSerieMotor)
                                col_p_Ctrls.Add(.txtSerieChasis)
                                col_p_Ctrls.Add(.txtMatricula)
                                col_p_Ctrls.Add(.txtModelo)
                                col_p_Ctrls.Add(.numAño)
                                col_p_Ctrls.Add(.cmdKillUnit)
                                '--------------------------------------------------------------------------------------------------------------------------------
                                CargaCombo(.cboTipoUnidad, DirectCast(Objeto_Utileria, BOVehicleSH.Vehiculo).Storage.Tables.Item(0), 0, 1, False)
                                CargaCombo(.cboMarca, DirectCast(Objeto_Utileria, BOVehicleSH.Vehiculo).Storage.Tables.Item(1), 0, 1, False)
                                .numAño.Value = CInt(DirectCast(Objeto_Utileria, BOVehicleSH.Vehiculo).Año)
                                '--------------------------------------------------------------------------------------------------------------------------------
                                Activa_Desactiva__Gpo_Controles(col_p_Ctrls, True)
                                .cmdProcesarVehiculo.Text = "&Actualizar"
                            End With
                        Case Is = 11
                            With DirectCast(Formulario, frmCatalogos)
                                Reset_Grid(.TDbgConjuntos, False)
                                .cmdQueryC.Enabled = False
                                .cmdXport_C.Enabled = False
                                modHerramientas.ResetCombo(.cboTVConjuntos, False)
                                'modHerramientas.ResetCombo(.cboFilterConj, False)
                                modHerramientas.CargaCombo(.cboTVConjuntos, DirectCast(Objeto_Utileria, BOVehicleSH.TipoVehiculo).Storage.Tables(0), 0, 1, False, True, , , True)
                                With .txtSCConj
                                    .Text = Nothing
                                    .Enabled = True
                                End With
                                .cboTVConjuntos.Focus()
                                .cmdProces_conjunto.Text = "&Guardar"
                            End With
                        Case Is = 12
                            With DirectCast(Formulario, frmCatalogos)
                                With .cmdKillConj
                                    .Enabled = False
                                    .Visible = False
                                End With
                                .cmdQueryC.Enabled = True
                                .cmdProces_conjunto.Text = "&Procesar"
                                With .txtSCConj
                                    .Text = Nothing
                                    .Enabled = False
                                End With
                                ResetCombo(.cboTVConjuntos, False)
                                Reset_Grid(.TDbgConjuntos, False)
                            End With
                        Case Is = 13
                            With DirectCast(Formulario, frmCatalogos)
                                .cmdProces_conjunto.Text = "&Actualizar"
                                .cmdQueryC.Enabled = False
                                .cmdXport_C.Enabled = False
                                .TDbgConjuntos.Enabled = False
                                With .cmdKillConj
                                    .Enabled = True
                                    .Visible = True
                                End With
                                With .txtSCConj
                                    .Enabled = True
                                    .Text = DirectCast(Objeto_Utileria, BOVehicleSH.Conjunto).Descripcion
                                End With
                            End With
                        Case Is = 14    'Inicia el registro de un subconjunto
                            With DirectCast(Formulario, frmCatalogos)
                                Reset_Grid(.tdbgSubs, False)
                                .cdmXportSbs.Enabled = False
                                .cmdQueySubs.Enabled = False
                                '▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬
                                .cmdProcesar_Subs.Text = "&Guardar"
                                '▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬
                                With .cboTipoVehiculoSBS
                                    If Not (.DataSource Is Nothing) Then
                                        .Focus()
                                    End If
                                End With
                            End With
                        Case Is = 15
                            With DirectCast(Formulario, frmCatalogos)
                                With .txtSubConjunto
                                    .Text = Nothing
                                    .Enabled = False
                                End With
                                .bln_Cbo_Modo_Edicion = True
                                Reset_Grid(.tdbgSubs, False)
                                ResetCombo(.cboConjunto_SBS, False)
                                ResetCombo(.cboTipoVehiculoSBS, False)
                                .cmdQueySubs.Enabled = True
                                .cmdProcesar_Subs.Text = "&Procesar"
                            End With
                        Case Is = 16
                            With DirectCast(Formulario, frmCatalogos)
                                .cmdQueySubs.Enabled = False
                                .cdmXportSbs.Enabled = False
                                .tdbgSubs.Enabled = False
                                .cmdProcesar_Subs.Text = "&Actualizar"
                                With .txtSubConjunto
                                    .Enabled = True
                                    .Focus()
                                End With
                            End With
                        Case Is = 17
                            With DirectCast(Formulario, frmCatalogos)
                                .cmdQueySubs.Enabled = True
                                .cboTipoVehiculoSBS.Text = Nothing
                                .cboConjunto_SBS.Text = Nothing
                                .txtSubConjunto.Text = Nothing
                                .cmdProcesar_Subs.Text = "&Procesar"
                            End With
                        Case Is = 18
                            'Inicia el registro de una reparacion
                            With DirectCast(Formulario, frmCatalogos)
                                If Not Objeto_Utileria Is Nothing Then
                                    '-------------------------------------
                                    .tabMode.TabPages(1).Enabled = False
                                    .cmdOperFix_Process.Text = "&Guardar"
                                    Reset_Grid(.tdbgFix_Qry, False)
                                    ResetCombo(.cboSubConjuntoFix, False)
                                    ResetCombo(.cboConjunto_Fix, False)
                                    CargaCombo(.cboTipoVehiculo_Fix, DirectCast(Objeto_Utileria, BOVehicleSH.TipoVehiculo).Storage.Tables.Item(0), 0, 1, , True, , , True)
                                    '-------------------------------------
                                    'Adicionamos la limpieza de la carga de las consultas
                                    Reset_Grid(.tdbgFix_Qry, False)
                                    With .txtFix_Description
                                        .Text = Nothing
                                        .Enabled = False
                                    End With
                                    bln_G_Mod_Edicion = True
                                    ResetCombo(.cboQry_Fix_Tv, False)
                                    ResetCombo(.cboQry_Fix_Conj, False)
                                    ResetCombo(.cboQry_Fix_SubC, False)
                                    bln_G_Mod_Edicion = False

                                End If
                            End With
                        Case Is = 19
                            'el programa registra con éxito una reparación
                            With DirectCast(Formulario, frmCatalogos)
                                With .txtFix_Description
                                    .Text = Nothing
                                    .Enabled = False
                                End With
                                bln_G_Mod_Edicion = True
                                ResetCombo(.cboSubConjuntoFix, False)
                                ResetCombo(.cboConjunto_Fix, False)
                                ResetCombo(.cboTipoVehiculo_Fix, False)
                                bln_G_Mod_Edicion = False
                                .cmdOperFix_Process.Text = "&Procesar"
                                If Not (.tabMode.TabPages(1).Enabled) Then
                                    .tabMode.TabPages(1).Enabled = True
                                End If
                                If .cmdModify_Rep_Cond.Visible Then
                                    With .cmdModify_Rep_Cond
                                        .Enabled = False
                                        .Visible = False
                                    End With
                                End If
                            End With
                        Case Is = 20
                            With DirectCast(Formulario, frmCatalogos)
                                With .cmdQryFix_Xport
                                    .Enabled = False
                                    .Visible = False
                                End With
                                ResetCombo(.cboQry_Fix_SubC, False)
                                ResetCombo(.cboQry_Fix_Conj, False)
                                ResetCombo(.cboQry_Fix_Tv, False)
                            End With
                        Case Is = 21
                            With DirectCast(Formulario, frmCatalogos)
                                bln_G_Mod_Edicion = True
                                With .cmdQryFix_Xport
                                    .Enabled = False
                                    .Visible = False
                                End With
                                With .cmdModify_Rep_Cond
                                    .Enabled = False
                                    .Visible = False
                                End With
                                .cmdOperFix_Process.Text = "&Procesar"
                                With .txtFix_Description
                                    .Enabled = False
                                    .Text = Nothing
                                End With
                                ResetCombo(.cboSubConjuntoFix, False)
                                ResetCombo(.cboConjunto_Fix, False)
                                ResetCombo(.cboTipoVehiculo_Fix, False)
                                .tabMode.TabPages(1).Enabled = True
                                ResetCombo(.cboQry_Fix_SubC, False)
                                ResetCombo(.cboQry_Fix_Conj, False)
                                ResetCombo(.cboQry_Fix_Tv, False)
                                bln_G_Mod_Edicion = False
                            End With
                        Case Is = 22
                            With DirectCast(Formulario, frmCatalogos)
                                bln_G_Mod_Edicion = True
                                With .txtFix_Description
                                    .Text = Nothing
                                End With
                                ResetCombo(.cboSubConjuntoFix, False)
                                ResetCombo(.cboConjunto_Fix, False)
                                ResetCombo(.cboTipoVehiculo_Fix, False)
                                bln_G_Mod_Edicion = False
                                .cmdOperFix_Process.Text = "&Procesar"
                            End With
                    End Select
            End Select
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Module
