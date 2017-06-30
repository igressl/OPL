Public Class frmAlmacen
#Region "Variables"
    Dim str_l_caption As String, _
        dt_m_tabla As DataTable, _
        dr_m_renglon As DataRow, _
        dc_m_columna As DataColumn, _
        col_l_cols As Collection, _
        obj_m_almacen As BoAlmacenSH.Almacen, _
        obj_m_anaquel As BoAlmacenSH.Anaquel, _
        obj_m_ubicacion As BoAlmacenSH.Ubicacion, _
        obj_m_tipo_veh As BOVehicleSH.TipoVehiculo, _
        obj_m_conjunto As BOVehicleSH.Conjunto, _
        obj_m_articulo As BoAlmacenSH.Articulo
#End Region

    Private Sub Manejador_Legales(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbo_prc_anaq.KeyPress, _
                                                                                                                     cbo_prc_ubi.KeyPress, _
                                                                                                                     txt_num_parte.KeyPress, _
                                                                                                                     txt_descrip_art.KeyPress
        Try
            Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
            '---------------------------------------------------------
            If Char.IsLetter(e.KeyChar) Then
                e.KeyChar = Char.ToUpper(e.KeyChar)
            End If
            '---------------------------------------------------------
            KeyAscii = CShort(SoloCarateresLegales(KeyAscii))
            If KeyAscii = 0 Then
                e.Handled = True
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub Manejador_Letras(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbo_prc_alm.KeyPress
        Try
            Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
            '---------------------------------------------------------
            If Char.IsLetter(e.KeyChar) Then
                e.KeyChar = Char.ToUpper(e.KeyChar)
            End If
            '---------------------------------------------------------
            KeyAscii = CShort(SoloLETRAS(KeyAscii))
            If KeyAscii = 0 Then
                e.Handled = True
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub Combo_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cbo_typ_fuel.Validating, _
                                                                                                                   cbo_typ_veh.Validating

        Try
            ValidandoCombo(sender)
        Catch ex As Exception
            MostrarError(ex, Me.MdiParent)
        End Try
    End Sub
    Private Sub Tipo_Registro(ByRef int_entidad As Integer)
        Dim str_l_text_save As String
        Try
            Select Case int_entidad
                Case Is = 0 'Almacen
                    obj_m_almacen = Nothing
                    str_l_text_save = ProcesaCadena(cbo_prc_alm.Text)
                    If Not (str_l_text_save Is Nothing) Then
                        obj_m_almacen = New BoAlmacenSH.Almacen
                        '---------------------------------
                        Activar_Interface(Me, False, True)
                        '---------------------------------
                        With obj_m_almacen
                            .id_empresa = cbo_prc_emp_ubi.SelectedValue.ToString
                            .descripcion = str_l_text_save
                            .registra()
                        End With
                        '---------------------------------
                        Activar_Interface(Me, True)
                        '---------------------------------
                        'Limpiamos la interfaz lista para el siguiente registro
                        ActualizarInt(3, Me)
                    Else
                        MessageBox.Show("Los datos para registrar un nuevo almacén están incompletos", _
                                        "Verifique", _
                                        MessageBoxButtons.OK, _
                                        MessageBoxIcon.Information)
                        Exit Sub
                    End If
                    'Validamos que los datos sean correctos
                Case Is = 1 'Anaquel
                    obj_m_anaquel = Nothing
                    If cbo_prc_alm.SelectedIndex <> -1 Then
                        str_l_text_save = ProcesaCadena(cbo_prc_anaq.Text)
                        If Not (str_l_text_save Is Nothing) Then
                            obj_m_anaquel = New BoAlmacenSH.Anaquel
                            '---------------------------------
                            Activar_Interface(Me, False, True)
                            '---------------------------------
                            With obj_m_anaquel
                                .id_almacen = cbo_prc_alm.SelectedValue.ToString
                                .desc_anaq = str_l_text_save
                                .registrar()
                            End With
                            '---------------------------------
                            Activar_Interface(Me, True)
                            '---------------------------------
                            ActualizarInt(5, Me)
                        Else
                            Beep()
                            MessageBox.Show("Los datos para registrar un nuevo almacén están incompletos", _
                                            "Verifique", _
                                            MessageBoxButtons.OK, _
                                            MessageBoxIcon.Information)
                            Exit Sub
                        End If
                    Else
                        Beep()
                    End If
                Case Is = 2 'Ubicacion
                    obj_g_ubicacion = Nothing
                    If cbo_prc_anaq.SelectedIndex <> -1 And _
                        cbo_prc_alm.SelectedIndex <> -1 Then
                        str_l_text_save = ProcesaCadena(cbo_prc_ubi.Text)
                        If (Not str_l_text_save Is Nothing) Then
                            obj_g_ubicacion = New BoAlmacenSH.Ubicacion
                            '----------------------------
                            Activar_Interface(Me, False)
                            '----------------------------
                            With obj_g_ubicacion
                                .id_anaq_ub = cbo_prc_anaq.SelectedValue.ToString
                                .desc_anaq = str_l_text_save
                                .registrar()
                            End With
                            '----------------------------
                            Activar_Interface(Me, True)
                            '----------------------------
                            'Limpieza de la pantalla
                            ActualizarInt(5, Me)

                        Else
                            MessageBox.Show("Los datos para registrar una nueva ubicación", _
                                            "Verifique", _
                                            MessageBoxButtons.OK, _
                                            MessageBoxIcon.Information)
                        End If
                    End If
            End Select
        Catch ex As Exception
            Activar_Interface(Me, True)
            Throw ex
        End Try
    End Sub
    Private Sub cmd_prc_ubs_Click(sender As System.Object, e As System.EventArgs) Handles cmd_prc_ubs.Click
        Try
            str_l_caption = cmd_prc_ubs.Text
            Select Case str_l_caption
                Case Is = "&Guardar"
                    If MessageBox.Show("Confirme el registro de la nueva entidad tipo [" & cbo_entidad.Text & " ]", _
                                       "Confirme", _
                                       MessageBoxButtons.YesNo, _
                                       MessageBoxIcon.Question) = SI Then
                        '------------------------------------------------
                        Tipo_Registro(cbo_entidad.SelectedValue.ToString)
                        '------------------------------------------------
                    End If
                Case Is = "&Iniciar"
                    If cbo_entidad.SelectedIndex <> -1 Then
                        If MessageBox.Show("¿Iniciar el registro de una entidad tipo [ " & cbo_entidad.Text & " ] ?", _
                                           "Confirme", _
                                           MessageBoxButtons.YesNo, _
                                           MessageBoxIcon.Question) = SI Then
                            ActualizarInt(2, Me, cbo_entidad.SelectedIndex, dt_m_empresa)
                        End If
                    End If
                Case Is = "&Procesar"
                    If MessageBox.Show("¿Registrar una nueva entidad?", "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = SI Then
                        modHerramientas.CargaCombo(cbo_entidad, dt_m_tabla, 0, 1, , True)
                        ActualizarInt(1, Me)
                        dt_m_empresa = Nothing
                        dt_m_empresa = New DataTable
                        col_l_cols = New Collection
                        With col_l_cols
                            .Add("id_empresa")
                            .Add("nombre_emp")
                        End With
                        Tabla_Volatil(dt_m_empresa, col_l_cols)
                        With dt_m_empresa
                            dr_m_renglon = Nothing
                            dr_m_renglon = .NewRow
                            dr_m_renglon.Item(0) = "1"
                            dr_m_renglon.Item(1) = "OPL Logistica"
                            .Rows.Add(dr_m_renglon)
                        End With
                    End If
            End Select
        Catch ex As Exception
            Activar_Interface(Me, True)
            MostrarError(ex, Me.MdiParent)
        End Try
    End Sub
    Private Sub carga_entidades()
        Try
            dt_m_tabla = Nothing
            dt_m_tabla = New DataTable
            '------------------------
            dc_m_columna = Nothing
            dc_m_columna = New DataColumn
            With dc_m_columna
                .DataType = System.Type.GetType("System.String")
                .ColumnName = "id_entidad"
            End With
            dt_m_tabla.Columns.Add(dc_m_columna)
            '------------------------
            dc_m_columna = Nothing
            dc_m_columna = New DataColumn
            With dc_m_columna
                .DataType = System.Type.GetType("System.String")
                .ColumnName = "desc_ent"
            End With
            dt_m_tabla.Columns.Add(dc_m_columna)
            '------------------------
            'Agregamos los renglones
            '++++++++++++++++++++++++++++++++++++++
            dr_m_renglon = Nothing
            dr_m_renglon = dt_m_tabla.NewRow
            With dr_m_renglon
                .Item(0) = "0"
                .Item(1) = "Almacén"
            End With
            dt_m_tabla.Rows.Add(dr_m_renglon)
            '++++++++++++++++++++++++++++++++++++++
            dr_m_renglon = Nothing
            dr_m_renglon = dt_m_tabla.NewRow
            With dr_m_renglon
                .Item(0) = "1"
                .Item(1) = "Anaquel"
            End With
            dt_m_tabla.Rows.Add(dr_m_renglon)
            '++++++++++++++++++++++++++++++++++++++
            dr_m_renglon = Nothing
            dr_m_renglon = dt_m_tabla.NewRow
            With dr_m_renglon
                .Item(0) = "2"
                .Item(1) = "Ubicación"
            End With
            dt_m_tabla.Rows.Add(dr_m_renglon)
            '++++++++++++++++++++++++++++++++++++++
        Catch ex As Exception
            MostrarError(ex, Me.MdiParent)
        End Try
    End Sub
    Public Sub New()
        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        carga_entidades()
    End Sub
    Private Sub cmd_cnl_ubs_Click(sender As System.Object, e As System.EventArgs) Handles cmd_cnl_ubs.Click
        Dim str_l_capt_opr As String
        Try
            str_l_capt_opr = cmd_prc_ubs.Text.ToString
            Select Case str_l_capt_opr
                Case Is = "&Guardar"
                    If MessageBox.Show("¿Cancelar el registro de entidades de almacenamiento?", _
                                       "Advertencia", _
                                       MessageBoxButtons.YesNo, _
                                       MessageBoxIcon.Question) = SI Then
                        ActualizarInt(5, Me)
                    End If
                Case Is = "&Iniciar"
                    If MessageBox.Show("¿Abandonar el proceso?", _
                                       "Confirme", _
                                       MessageBoxButtons.YesNo, _
                                       MessageBoxIcon.Question) = SI Then
                        ActualizarInt(4, Me)
                    End If
            End Select
        Catch ex As Exception
            Activar_Interface(Me, True)
            MostrarError(ex, Me.MdiParent)
        End Try
    End Sub
    Private Sub cbo_prc_alm_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbo_prc_alm.SelectedIndexChanged
        Try
            If bln_G_Mod_Edicion = False Then
                With cbo_prc_anaq
                    If .DropDownStyle = ComboBoxStyle.Simple Then
                        .Text = Nothing
                    Else
                        'En este caso, damos por hecho que estamos registrando una ubicacion
                        'obj_g_anaquel
                        If cbo_prc_alm.SelectedIndex <> -1 Then
                            '+++++++++++++++++++++++++++++
                            bln_G_Mod_Edicion = True
                            '+++++++++++++++++++++++++++++
                            ResetCombo(cbo_prc_anaq, False)
                            'reiniciamos el combo que se usa como entrada para la ubicacion
                            With cbo_prc_ubi
                                .DataSource = Nothing
                                .Items.Clear()
                                .DropDownStyle = ComboBoxStyle.Simple
                                .Text = Nothing
                                .Enabled = False
                            End With
                            '------------------------------
                            obj_g_anaquel = New BoAlmacenSH.Anaquel
                            obj_g_anaquel.id_almacen = cbo_prc_alm.SelectedValue.ToString
                            obj_g_anaquel.listar(True)
                            '+++++++++++++++++++++++++++++
                            bln_G_Mod_Edicion = False
                            '+++++++++++++++++++++++++++++
                            modHerramientas.CargaCombo(cbo_prc_anaq, obj_g_anaquel.Storage.Tables.Item(0), 0, 1, False, True, , , True)
                        End If
                        '.DataSource = Nothing
                        '.Items.Clear()
                        '.Text = Nothing
                        '.SelectedIndex = -1
                    End If
                End With

                '    With cbo_prc_alm
                '        If Not (.DataSource Is Nothing) Then
                '            If .SelectedIndex <> -1 Then
                '                ActualizarInt(5, Me, , cbo_entidad.SelectedValue)
                '            End If
                '        End If
                '    End With
            End If
        Catch ex As Exception
            bln_G_Mod_Edicion = False
            Activar_Interface(Me, True)
            MostrarError(ex, Me.MdiParent)
        End Try
    End Sub
    Private Sub cbo_prc_anaq_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbo_prc_anaq.SelectedIndexChanged
        Try
            If cbo_prc_ubi.DropDownStyle = ComboBoxStyle.Simple Then
                With cbo_prc_ubi
                    .Text = Nothing
                    .Enabled = True
                End With
            End If
        Catch ex As Exception
            bln_G_Mod_Edicion = False
            Activar_Interface(Me, True)
            MostrarError(ex, Me.MdiParent)
        End Try
    End Sub
    Private Sub cmd_qry_ents_Click(sender As System.Object, e As System.EventArgs) Handles cmd_qry_ents.Click
        Try
            '----------------------------------
            Activar_Interface(Me, False, True)
            '----------------------------------
            obj_m_ubicacion = Nothing
            obj_m_ubicacion = New BoAlmacenSH.Ubicacion
            obj_m_ubicacion.listar()
            Grid_Dinamico(Me.tdbg_ubs, obj_m_ubicacion.Storage.Tables.Item(0))
            '----------------------------------
            Activar_Interface(Me, True)
            '----------------------------------
        Catch ex As Exception
            Activar_Interface(Me, True)
            MostrarError(ex, Me.MdiParent)
        End Try
    End Sub
    Private Sub cmd_prc_art_Click(sender As System.Object, e As System.EventArgs) Handles cmd_prc_art.Click
        Dim str_m_proceso, _
            str_m_num_parte, _
            str_m_desc_art As String, _
            idx_sel_val As Integer
        Try
            str_m_proceso = cmd_prc_art.Text
            Select Case str_m_proceso
                Case Is = "&Continuar"
                    ActualizarInt(8, Me)
                Case Is = "&Confirmar"
                    If MessageBox.Show("¿Iniciar el guardado del artículo?", _
                                       "Confirme", _
                                       MessageBoxButtons.YesNo, _
                                       MessageBoxIcon.Question) = SI Then
                        'Bloqueamos los cuadros de texto
                        txt_num_parte.ReadOnly = True
                        txt_descrip_art.ReadOnly = True
                        cbo_typ_fuel.Enabled = False
                        cbo_typ_veh.Enabled = False
                        cbo_typ_conj.Enabled = False
                        cmd_prc_art.Text = "&Guardar"
                    Else
                        cmd_prc_art.Text = "&Validar"
                    End If
                Case Is = "&Guardar"
                    If MessageBox.Show("¿Desea registrar el artículo?", _
                                       "Confirme", _
                                       MessageBoxButtons.YesNo, _
                                       MessageBoxIcon.Question) = SI Then
                        str_m_num_parte = ProcesaCadena(txt_num_parte.Text, True)
                        str_m_desc_art = ProcesaCadena(txt_descrip_art.Text, True)
                        idx_sel_val = cbo_typ_conj.SelectedIndex
                        If Not (str_m_num_parte Is Nothing) And _
                            Not (str_m_desc_art Is Nothing) And _
                            (idx_sel_val <> -1) Then
                            '---------------------------
                            Activar_Interface(Me, False)
                            '---------------------------
                            obj_m_articulo = Nothing
                            obj_m_articulo = New BoAlmacenSH.Articulo
                            With obj_m_articulo
                                .descripcion = str_m_desc_art
                                .num_parte = str_m_num_parte
                                .id_conjunto = cbo_typ_conj.SelectedValue
                                .registrar()
                            End With
                            '---------------------------
                            Activar_Interface(Me, True)
                            '---------------------------                            
                            If Not (obj_m_articulo.id_articulo Is Nothing) Then
                                txt_cod_interno.Text = obj_m_articulo.codigo
                                qr_codigo_item.Text = obj_m_articulo.codigo
                            End If
                            cmd_prc_art.Text = "&Continuar"
                        Else
                            MessageBox.Show("Indique número de parte y descripción del artículo", "Verifique", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            Exit Sub
                        End If
                    End If
                Case Is = "&Validar"
                    'El objetivo d e este proceso
                    'es que el usuario esté avisado
                    'que existen registros muy parecidos 
                    'a los que quiere dar de alta o que
                    'no hay registros similares.
                    'La razón es evitar la duplicidad 
                    str_m_num_parte = ProcesaCadena(txt_num_parte.Text, True)
                    str_m_desc_art = ProcesaCadena(txt_descrip_art.Text, True)
                    idx_sel_val = cbo_typ_conj.SelectedIndex
                    If Not (str_m_num_parte Is Nothing) And _
                        Not (str_m_desc_art Is Nothing) And _
                            (idx_sel_val <> -1) Then
                        MessageBox.Show("Inicia el proceso de búsqueda auxiliar del número de parte y descripcion", _
                                        "Aviso", _
                                        MessageBoxButtons.OK, _
                                        MessageBoxIcon.Information)
                        '----------------------------
                        Activar_Interface(Me, False)
                        '----------------------------
                        obj_m_articulo = Nothing
                        obj_m_articulo = New BoAlmacenSH.Articulo
                        With obj_m_articulo
                            .descripcion = str_m_desc_art
                            .num_parte = str_m_num_parte
                            .muestra_coincidencias()
                        End With
                        '----------------------------
                        Activar_Interface(Me, True)
                        '----------------------------
                        cmd_prc_art.Text = "&Confirmar"
                        '----------------------------
                        If obj_m_articulo.tiene_coincidencias Then
                            obj_match = New frm_matchs
                            '------------------------------------------------------------------------------------------
                            With obj_match
                                .lbl_concidencias.Text = "Coincidencias para descripción :" & Chr(13) & str_m_desc_art & Chr(13) & " y/o número de parte : " & str_m_num_parte

                            End With
                            Grid_Dinamico(obj_match.tdbg_itm_nam, obj_m_articulo.Storage.Tables.Item(0), , True)
                            Grid_Dinamico(obj_match.tdbg_itm_partnum, obj_m_articulo.Storage.Tables.Item(1), , True)
                            '------------------------------------------------------------------------------------------
                            CargarFormularioMDI_Child(obj_match, Me.MdiParent, False, , True, True)
                        Else
                            MessageBox.Show("No se han encontrado registros similares", "Búsqueda completa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    Else
                        MessageBox.Show("Indique número de parte, conjunto y descripción del artículo", "Verifique", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    End If
                Case Is = "&Procesar"
                    If MessageBox.Show("¿Iniciar el registro de un nuevo artículo?", _
                                       "Confirme", _
                                       MessageBoxButtons.YesNo, _
                                       MessageBoxIcon.Question) = SI Then
                        ActualizarInt(7, Me)
                    End If
            End Select
        Catch ex As Exception
            bln_G_Mod_Edicion = False
            Activar_Interface(Me, True)
            MostrarError(ex, Me.MdiParent)
        End Try
    End Sub
    Private Sub cbo_typ_fuel_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbo_typ_fuel.SelectedIndexChanged
        Try
            '------------------------------
            ResetCombo(cbo_typ_veh, False)
            ResetCombo(cbo_typ_conj, False)
            '------------------------------
            If Not (bln_G_Mod_Edicion) Then
                If cbo_typ_fuel.SelectedIndex <> -1 Then
                    '***********************
                    bln_G_Mod_Edicion = True
                    '***********************
                    obj_m_tipo_veh = Nothing
                    obj_m_tipo_veh = New BOVehicleSH.TipoVehiculo
                    '---------------------------
                    Activar_Interface(Me, False)
                    '---------------------------
                    obj_m_tipo_veh.Listar(cbo_typ_fuel.SelectedValue.ToString)
                    '---------------------------
                    Activar_Interface(Me, True)
                    '---------------------------
                    CargaCombo(cbo_typ_veh, obj_m_tipo_veh.Storage.Tables(0), 0, 1, , True, , , True)
                    '***********************
                    bln_G_Mod_Edicion = False
                    '***********************
                End If
            End If
        Catch ex As Exception
            bln_G_Mod_Edicion = False
            Activar_Interface(Me, True)
            MostrarError(ex, Me.MdiParent)
        End Try
    End Sub
    Private Sub cbo_typ_veh_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbo_typ_veh.SelectedIndexChanged
        Try
            ResetCombo(cbo_typ_conj, False)
            If Not (bln_G_Mod_Edicion) Then
                If cbo_typ_veh.SelectedIndex <> -1 Then
                    Activar_Interface(Me, False, True)
                    obj_m_conjunto = Nothing
                    obj_m_conjunto = New BOVehicleSH.Conjunto
                    With obj_m_conjunto
                        .IDTipoVehiculo = cbo_typ_veh.SelectedValue.ToString
                        .Listar(True)
                    End With
                    Activar_Interface(Me, True)
                    modHerramientas.CargaCombo(cbo_typ_conj, obj_m_conjunto.Storage.Tables(0), 0, 1, False, True, , , True)
                End If
            End If            
        Catch ex As Exception
            bln_G_Mod_Edicion = False
            Activar_Interface(Me, True)
            MostrarError(ex, Me.MdiParent)
        End Try
    End Sub
    Private Sub txt_num_parte_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt_num_parte.KeyDown
        Dim str_l_text As String
        Try
            If e.KeyCode = Keys.Enter Then
                str_l_text = ProcesaCadena(txt_num_parte.Text, True)
                If Not (str_l_text Is Nothing) Then

                End If
            End If
        Catch ex As Exception
            Activar_Interface(Me, True)
            MostrarError(ex, Me.MdiParent)
        End Try
    End Sub

    Private Sub cmd_prcs_qry_Click(sender As System.Object, e As System.EventArgs) Handles cmd_prcs_qry.Click

    End Sub
End Class