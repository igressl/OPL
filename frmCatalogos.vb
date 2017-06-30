Public Class frmCatalogos
    Public bln_Cbo_Modo_Edicion As Boolean
    Dim objTipoVeh As BOVehicleSH.TipoVehiculo, _
        objTipoComb As BOVehicleSH.TipoCombustible, _
        objVehiculo As BOVehicleSH.Vehiculo, _
        objUso As BOVehicleSH.Uso,
        bln_M_Modo_Carga As Boolean, _
        str_L_IDRecord As String, _
        intVar As Integer, _
        objMarca As BOVehicleSH.Marca, _
        objConjunto As BOVehicleSH.Conjunto, _
        objSubConjunto As BOVehicleSH.Subconjunto, _
        col_L_Parametros As Collection, _
        objReparacion As BOVehicleSH.Reparacion
#Region "Handlers"
    Private Sub Combo_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cboCombustible.Validating, _
                                                                                                                   cboUso.Validating, _
                                                                                                                   cboTipoUnidad.Validating, _
                                                                                                                   cboMarca.Validating, _
                                                                                                                   cboTipoUnidad.Validating, _
                                                                                                                   cboMarca.Validating, _
                                                                                                                   cboTVConjuntos.Validating, _
                                                                                                                   cboTipoVehiculoSBS.Validating, _
                                                                                                                   cboTipoVehiculo_Fix.Validating, _
                                                                                                                   cboConjunto_Fix.Validating, _
                                                                                                                   cboSubConjuntoFix.Validating, _
                                                                                                                   cboQry_Fix_Tv.Validating, _
                                                                                                                   cboQry_Fix_Conj.Validating, _
                                                                                                                   cboQry_Fix_SubC.Validating

        Try
            ValidandoCombo(sender)
        Catch ex As Exception
            MostrarError(ex, Me.MdiParent)
        End Try
    End Sub
    Private Sub Manejador_Letras(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSubConjunto.KeyPress, _
                                                                                                                    txtFix_Description.KeyPress

        Try
            Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
            KeyAscii = CShort(SoloLETRAS(KeyAscii))
            If KeyAscii = 0 Then
                e.Handled = True
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub CaracteresBasicos(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMarca.KeyPress, _
                                                                                                            txtDescripcion.KeyPress, _
                                                                                                            txtEco.KeyPress, _
                                                                                                            txtMatricula.KeyPress, _
                                                                                                            txtModelo.KeyPress, _
                                                                                                            txtEco.KeyPress, _
                                                                                                            txtSCConj.KeyPress, _
                                                                                                            txtFix_Description.KeyPress

        Try
            Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
            KeyAscii = CShort(SoloCarateresLegales(KeyAscii))
            If KeyAscii = 0 Then
                e.Handled = True
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub Grids_MenuCopia(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles tdbgUnidades.MouseClick, _
                                                                                                                tdbgTiposVehiculo.MouseClick, _
                                                                                                                tdbgTiposVehiculo.MouseClick, _
                                                                                                                tdbgFix_Qry.MouseClick
        Try
            If e.Button = Windows.Forms.MouseButtons.Right Then
                obj_Main.Menu_Copiar_Pegar(sender, e.X, e.Y)
            End If
        Catch ex As Exception
            MostrarError(ex, Me.MdiParent)
        End Try
    End Sub
#End Region
#Region "Metodos locales"
    Public Function Puede_Guardar() As Boolean
        Dim bln_P_Resultado As Boolean
        bln_P_Resultado = False
        Try
            If cboCombustible.SelectedIndex <> -1 And _
               Me.cboUso.SelectedIndex <> -1 And _
               Not (ProcesaCadena(txtDescripcion.Text) Is Nothing) Then
                bln_P_Resultado = True
            End If
            Return bln_P_Resultado
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Sub Rutina_Limpieza()
        Try

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
#End Region
    Private Sub tdbgFix_Qry_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tdbgFix_Qry.KeyDown
        Dim int_L_IDX, _
            int_L_RwBkmk As Integer, _
            str_L_Record As String
        Try
            With tdbgFix_Qry
                If Not (.DataSource Is Nothing) Then
                    If .VisibleRows > 0 Then
                        If e.KeyCode = Keys.Enter Then
                            int_L_RwBkmk = .RowBookmark(.Row)
                            If int_L_RwBkmk <> -1 Then
                                str_L_Record = .Columns.Item(0).CellValue(int_L_RwBkmk).ToString
                                If Not (str_L_Record Is Nothing) Then
                                    intVar = Determinar_Renglon(str_L_Record, .DataSource)
                                    If intVar <> -1 Then
                                        objReparacion = Nothing
                                        objReparacion = New BOVehicleSH.Reparacion
                                        With objReparacion
                                            .IdReparacion = DirectCast(tdbgFix_Qry.DataSource, DataTable).Rows(intVar).Item(0).ToString
                                            .Descripcion = DirectCast(tdbgFix_Qry.DataSource, DataTable).Rows(intVar).Item(4).ToString
                                            .IdSubConjunto = DirectCast(tdbgFix_Qry.DataSource, DataTable).Rows(intVar).Item(5).ToString
                                        End With
                                        'Cambiamos el tab
                                        tabMode.SelectTab(0)
                                        cboTipoVehiculo_Fix.Text = DirectCast(.DataSource, DataTable).Rows(intVar).Item(1).ToString
                                        cboConjunto_Fix.Text = DirectCast(.DataSource, DataTable).Rows(intVar).Item(2).ToString
                                        cboSubConjuntoFix.Text = DirectCast(.DataSource, DataTable).Rows(intVar).Item(3).ToString
                                        txtFix_Description.Text = objReparacion.Descripcion
                                        cmdOperFix_Process.Text = "&Editar"
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End With
        Catch ex As Exception
            MostrarError(ex, Me.MdiParent)
        End Try
    End Sub
    Private Sub cmdProcesarTipoVeh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdProcesarTipoVeh.Click
        Dim str_P_Caption As String, _
            obj_L_TC As BOVehicleSH.TipoCombustible, _
            col_P_Params As Collection, _
            bln_L_Bool As Boolean
        Try
            str_P_Caption = cmdProcesarTipoVeh.Text
            Select Case str_P_Caption
                Case Is = "&Actualizar"
                    If Not (objTipoVeh Is Nothing) Then
                        col_P_Params = Nothing
                        col_P_Params = New Collection
                        With col_P_Params
                            .Add(txtDescripcion)
                        End With
                        If Grupo_Parametros_Validos(col_P_Params) Then
                            Activar_Interface(Me, False)
                            With objTipoVeh
                                .Descripcion = modHerramientas.ProcesaCadena(txtDescripcion.Text)
                                .Actualizar()
                            End With
                            Activar_Interface(Me, True)
                            'Actualización exitosa
                            ActualizarInt(2, Me)
                        End If
                    End If
                Case Is = "&Editar"
                    If Not (objTipoVeh Is Nothing) Then
                        If MessageBox.Show("¿Modificar el tipo de vehículo?", _
                                       "Confirme", _
                                       MessageBoxButtons.YesNo, _
                                       MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                            obj_L_TC = Nothing
                            obj_L_TC = New BOVehicleSH.TipoCombustible
                            cboCombustible.Text = objTipoVeh.Combustible
                            cboUso.Text = objTipoVeh.Uso
                            With txtDescripcion
                                .Text = objTipoVeh.Descripcion
                                .Enabled = True
                            End With
                            Me.cmdProcesarTipoVeh.Text = "&Actualizar"
                            Me.cmdXprtTiVh.Enabled = False
                            bln_L_Bool = Not (objTipoVeh.Relacionado)
                            With cmdKill
                                .Visible = bln_L_Bool
                                .Enabled = bln_L_Bool
                            End With
                        End If
                    End If
                Case Is = "&Nuevo"
                    If MessageBox.Show("¿Adicionar un nuevo tipo de vehículo?", _
                                       "Confirme", _
                                       MessageBoxButtons.YesNo, _
                                       MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        bln_M_Modo_Carga = True
                        objTipoComb = New BOVehicleSH.TipoCombustible
                        Activar_Interface(Me, False, True)
                        objTipoComb.Listar()
                        Activar_Interface(Me, True, False)
                        modHerramientas.CargaCombo(Me.cboCombustible, objTipoComb.Storage.Tables(0), 0, 1, False, True)
                        bln_M_Modo_Carga = False
                        ActualizarInt(1, Me)
                    End If
                Case Is = "&Guardar"
                    If MessageBox.Show("¿Registrar un nuevo tipo?", _
                                       "Confirme", _
                                       MessageBoxButtons.YesNo, _
                                       MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        If Puede_Guardar() Then
                            objTipoVeh = New BOVehicleSH.TipoVehiculo
                            Activar_Interface(Me, False, True)
                            With objTipoVeh
                                .IdCombustible = cboCombustible.SelectedValue.ToString
                                .IdUso = Me.cboUso.SelectedValue.ToString
                                .Descripcion = ProcesaCadena(txtDescripcion.Text)
                                .Registrar()
                            End With
                            Activar_Interface(Me, True)
                            'Guardado exitoso
                            ActualizarInt(2, Me)
                        Else
                            MessageBox.Show("Tiene que seleccionar un tipo de uso, tipo de combustible e indicar la descripcion", "Verifique", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Exit Sub
                        End If
                    End If
            End Select
        Catch ex As Exception
            Activar_Interface(Me, True)
            bln_M_Modo_Carga = False
            MostrarError(ex, Me.MdiParent)
        End Try
    End Sub
    Private Sub cboCombustible_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCombustible.SelectedIndexChanged
        Try
            If bln_M_Modo_Carga = False Then
                With cboCombustible
                    If .SelectedIndex <> -1 Then
                        objUso = Nothing
                        objUso = New BOVehicleSH.Uso
                        '---------------------------------
                        Activar_Interface(Me, False, True)
                        '---------------------------------
                        objUso.Listar()
                        '---------------------------------
                        Activar_Interface(Me, True)
                        '---------------------------------
                        modHerramientas.CargaCombo(Me.cboUso, objUso.Storage.Tables(0), 0, 1, False, True)
                    End If
                End With
            End If
        Catch ex As Exception
            Activar_Interface(Me, True)
            MostrarError(ex, Me.MdiParent)
        End Try
    End Sub
    Private Sub cboUso_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboUso.SelectedIndexChanged
        Try
            If bln_M_Modo_Carga = False Then
                With cboUso
                    If .SelectedIndex <> -1 Then
                        txtDescripcion.Text = ""
                        txtDescripcion.Enabled = True
                    Else
                        txtDescripcion.Enabled = False
                    End If
                End With
            End If
        Catch ex As Exception
            MostrarError(ex, Me.MdiParent)
        End Try
    End Sub
    Private Sub cmdXprtTiVh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdXprtTiVh.Click
        Dim str_L_Texto As String
        Try
            str_L_Texto = cmdXprtTiVh.Text.ToString
            Select Case str_L_Texto
                Case Is = "Consultar"
                    objTipoVeh = Nothing
                    objTipoVeh = New BOVehicleSH.TipoVehiculo
                    Activar_Interface(Me, False)
                    objTipoVeh.Listar()
                    Activar_Interface(Me, True)
                    Grid_Dinamico(Me.tdbgTiposVehiculo, objTipoVeh.Storage.Tables.Item(0), , True)
                    If objTipoVeh.Storage.Tables.Item(0).Rows.Count > 0 Then
                        cmdXprtTiVh.Text = "Exportar"
                    Else
                        cmdXprtTiVh.Text = "Consultar"
                    End If
                Case Is = "Exportar"
                    Gestionar_Export(sender, Me, tdbgTiposVehiculo)
                    cmdXprtTiVh.Text = "Consultar"
            End Select
        Catch ex As Exception
            Activar_Interface(Me, True)
            MostrarError(ex, Me.MdiParent)
        End Try
    End Sub
    Private Sub tdbgTiposVehiculo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tdbgTiposVehiculo.KeyDown
        Dim int_L_Row, _
            int_L_RwBkmk As Integer
        Try
            With tdbgTiposVehiculo
                If Not (.DataSource Is Nothing) Then
                    If .VisibleRows > 0 Then
                        If e.KeyCode = Keys.Enter Then
                            int_L_Row = .Row
                            int_L_RwBkmk = .RowBookmark(int_L_Row)
                            If int_L_RwBkmk <> -1 Then
                                'str_L_IDRecord = .Rows(int_L_RwBkmk).Item(0).ToString
                                str_L_IDRecord = .Columns.Item(0).CellValue(int_L_RwBkmk).ToString
                                If Not (str_L_IDRecord Is Nothing) Then
                                    intVar = Determinar_Renglon(str_L_IDRecord, .DataSource)
                                    If intVar <> -1 Then
                                        objTipoVeh = Nothing
                                        objTipoVeh = New BOVehicleSH.TipoVehiculo
                                        With objTipoVeh
                                            .IdTipoVehiculo = DirectCast(tdbgTiposVehiculo.DataSource, DataTable).Rows(intVar).Item(0).ToString
                                            .Combustible = DirectCast(tdbgTiposVehiculo.DataSource, DataTable).Rows(intVar).Item(3).ToString
                                            .Descripcion = DirectCast(tdbgTiposVehiculo.DataSource, DataTable).Rows(intVar).Item(2).ToString
                                            .Uso = DirectCast(tdbgTiposVehiculo.DataSource, DataTable).Rows(intVar).Item(1).ToString
                                            .IdCombustible = DirectCast(tdbgTiposVehiculo.DataSource, DataTable).Rows(intVar).Item(4).ToString
                                            .IdUso = DirectCast(tdbgTiposVehiculo.DataSource, DataTable).Rows(intVar).Item(5).ToString
                                            .Relacionado = CBool(DirectCast(tdbgTiposVehiculo.DataSource, DataTable).Rows(intVar).Item(6))
                                        End With
                                        ActualizarInt(3, Me, objTipoVeh)
                                        'Encontramos el registro, creamos un objeto para poder ser editado si así se desea
                                        'mostramos valores en la interfaz
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End With
        Catch ex As Exception
            MostrarError(ex, Me.MdiParent)
        End Try
    End Sub
    Private Sub tdbgTiposVehiculo_RowColChange(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.RowColChangeEventArgs) Handles tdbgTiposVehiculo.RowColChange
        Try
            With tdbgTiposVehiculo
                If Not (.DataSource Is Nothing) Then
                    If cmdProcesarTipoVeh.Text = "&Editar" Then
                        cboCombustible.Text = ""
                        cboUso.Text = ""
                        txtDescripcion.Text = ""
                        cmdProcesarTipoVeh.Text = "&Nuevo"
                    End If
                End If
            End With
        Catch ex As Exception
            MostrarError(ex, Me.MdiParent)
        End Try
    End Sub
    Private Sub cmdKill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdKill.Click
        Try
            If Not (objTipoVeh Is Nothing) Then
                If MessageBox.Show("¿Eliminar el tipo de vehiculo seleccionado?", _
                                   "Confirme", _
                                   MessageBoxButtons.YesNo, _
                                   MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    Activar_Interface(Me, False)
                    objTipoVeh.Eliminar()
                    Activar_Interface(Me, True)
                    ActualizarInt(2, Me)
                End If
            End If
        Catch ex As Exception
            Activar_Interface(Me, True)
            MostrarError(ex, Me.MdiParent)
        End Try
    End Sub
    Private Sub cmdCancelTipoVeh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelTipoVeh.Click
        Try
            Dim str_L_Caption As String
            str_L_Caption = cmdProcesarTipoVeh.Text
            Select Case str_L_Caption
                Case Is = "&Nuevo"
                    Me.Close()
                Case Is = "&Guardar", "&Editar", "&Actualizar"
                    ActualizarInt(2, Me)
            End Select
        Catch ex As Exception
            MostrarError(ex, Me.MdiParent)
        End Try
    End Sub
    Private Sub cmdProcesarVehiculo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdProcesarVehiculo.Click
        Dim str_L_Caption, _
            str_P_Eco, _
            str_P_Chasis, _
            str_P_Motor, _
            str_P_Modelo, _
            str_P_Matricula As String, _
            col_Ctrls As Collection

        Try
            str_L_Caption = cmdProcesarVehiculo.Text
            Select Case str_L_Caption
                Case Is = "&Guardar"
                    If Not (objVehiculo Is Nothing) Then
                        If MessageBox.Show("¿Registrar los datos del nuevo vehiculo?", _
                                       "Confirme", _
                                       MessageBoxButtons.YesNo, _
                                       MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                            col_Ctrls = New Collection
                            With col_Ctrls
                                .Add(cboTipoUnidad)
                                .Add(cboMarca)
                                .Add(txtEco)
                                .Add(txtSerieChasis)
                                .Add(txtSerieMotor)
                                .Add(txtMatricula)
                                .Add(txtModelo)
                            End With
                            If Grupo_Parametros_Validos(col_Ctrls) Then
                                str_P_Eco = Extrae_Letras(txtEco.Text, True)
                                str_P_Chasis = Extrae_Letras(txtSerieChasis.Text, True)
                                str_P_Motor = Extrae_Letras(txtSerieMotor.Text, True)
                                str_P_Matricula = Extrae_Letras(txtMatricula.Text, True)
                                str_P_Modelo = Extrae_Letras(txtModelo.Text, True)
                                Activar_Interface(Me, False, True)
                                With objVehiculo
                                    .Tipo.IdTipoVehiculo = cboTipoUnidad.SelectedValue.ToString
                                    .Economico = str_P_Eco
                                    .SerieChasis = str_P_Chasis
                                    .SerieMotor = str_P_Motor
                                    .Matricula = str_P_Matricula
                                    .Marca.IdMarca = cboMarca.SelectedValue.ToString
                                    .Modelo = str_P_Modelo
                                    .Año = numAño.Value.ToString
                                    .Guardar()
                                End With
                                Activar_Interface(Me, True)
                                ActualizarInt(8, Me)
                            End If
                        End If
                    End If
                Case Is = "&Nuevo"
                    If MessageBox.Show("¿Registrar un nuevo vehículo?", "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        objVehiculo = Nothing
                        objVehiculo = New BOVehicleSH.Vehiculo
                        '-----------------------------------
                        Activar_Interface(Me, False, True)
                        '-----------------------------------
                        objVehiculo.Preparar()
                        '-----------------------------------
                        Activar_Interface(Me, True)
                        '-----------------------------------
                        ActualizarInt(7, Me)
                        CargaCombo(Me.cboMarca, objVehiculo.Storage.Tables.Item(1), 0, 1, False, True, , , True)
                        CargaCombo(cboTipoUnidad, objVehiculo.Storage.Tables.Item(0), 0, 1, False, True, , , True)
                    Else
                        Exit Sub
                    End If
                Case Is = "&Editar"
                    If Not (objVehiculo Is Nothing) Then
                        If MessageBox.Show("¿Modificar el registro seleccionado?", _
                                           "Confirme", _
                                           MessageBoxButtons.YesNo, _
                                           MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                            '----------------------------
                            Activar_Interface(Me, False)
                            '----------------------------
                            objVehiculo.Preparar()
                            '----------------------------
                            Activar_Interface(Me, True)
                            '----------------------------
                            ActualizarInt(10, Me, objVehiculo)
                        End If
                    End If
                Case Is = "&Actualizar"
                    If Not (objVehiculo Is Nothing) Then
                        If MessageBox.Show("¿Actualizar la información del registro?", _
                                           "Confirme", _
                                           MessageBoxButtons.YesNo, _
                                           MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                            col_Ctrls = Nothing
                            col_Ctrls = New Collection
                            With col_Ctrls
                                .Add(cboTipoUnidad)
                                .Add(cboMarca)
                                .Add(txtEco)
                                .Add(txtSerieMotor)
                                .Add(txtSerieChasis)
                                .Add(txtMatricula)
                                .Add(txtModelo)
                            End With
                            If Grupo_Parametros_Validos(col_Ctrls) = True Then
                                With objVehiculo
                                    .Tipo.IdTipoVehiculo = cboTipoUnidad.SelectedValue.ToString
                                    .Marca.IdMarca = cboMarca.SelectedValue.ToString
                                    .Economico = Extrae_Letras(txtEco.Text, True)
                                    .SerieMotor = Extrae_Letras(txtSerieMotor.Text, True)
                                    .SerieChasis = Extrae_Letras(txtSerieChasis.Text, True)
                                    .Matricula = Extrae_Letras(txtMatricula.Text, True)
                                    .Modelo = Extrae_Letras(txtModelo.Text, True)
                                    .Año = numAño.Value.ToString
                                End With
                                '------------------------------------------------
                                Activar_Interface(Me, False, True)
                                '------------------------------------------------
                                objVehiculo.Actualizar()
                                '------------------------------------------------
                                Activar_Interface(Me, True)
                                '------------------------------------------------
                                ActualizarInt(8, Me)
                            End If
                        End If
                    End If
            End Select
        Catch ex As Exception
            Activar_Interface(Me, True)
            MostrarError(ex, Me.MdiParent)
        End Try
    End Sub
    Private Sub cmdProcessMarca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdProcessMarca.Click
        Dim str_L_Caption As String, _
            str_L_Marca As String
        Try
            str_L_Caption = cmdProcessMarca.Text
            Select Case str_L_Caption
                Case Is = "&Actualizar"
                    If Not (objMarca Is Nothing) Then
                        If MessageBox.Show("¿Actualizar el registro seleccionado?", _
                                       "Confirme", _
                                       MessageBoxButtons.YesNo, _
                                       MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                            str_L_Marca = ProcesaCadena(txtMarca.Text)
                            If Not (str_L_Marca Is Nothing) Then
                                '---------------------------------
                                Activar_Interface(Me, False, True)
                                '---------------------------------
                                With objMarca
                                    .Descripcion = str_L_Marca
                                    .Actualizar()
                                End With
                                '---------------------------------
                                Activar_Interface(Me, True)
                                '---------------------------------
                                ActualizarInt(6, Me)
                            Else
                                MessageBox.Show("La información está incompleta, por favor verifique", _
                                                "Aviso", _
                                                MessageBoxButtons.OK, _
                                                MessageBoxIcon.Information)
                            End If
                        End If
                    End If
                Case Is = "&Editar"
                    If MessageBox.Show("¿Editar el elemento seleccionado?", _
                                       "Confirma", _
                                       MessageBoxButtons.YesNo, _
                                       MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        ActualizarInt(5, Me)
                    End If
                Case Is = "&Nuevo"
                    If MessageBox.Show("¿Iniciar el registro de una nueva marca?", _
                                       "Confirme", _
                                       MessageBoxButtons.YesNo, _
                                       MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        ActualizarInt(4, Me)
                    End If
                Case Is = "&Guardar"
                    If MessageBox.Show("¿Guardar la información?", _
                                       "Confirme", _
                                       MessageBoxButtons.YesNo, _
                                       MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                        objMarca = Nothing
                        objMarca = New BOVehicleSH.Marca
                        str_L_Marca = ProcesaCadena(txtMarca.Text)
                        If Not (str_L_Marca Is Nothing) Then
                            '------------------------------------
                            Activar_Interface(Me, False, True)
                            '------------------------------------
                            With objMarca
                                .Descripcion = str_L_Marca
                                .Registrar()
                            End With
                            '------------------------------------
                            Activar_Interface(Me, True)
                            '------------------------------------
                            ActualizarInt(6, Me)
                        Else
                            MessageBox.Show("La información que indicó está incompleta, por favor verifique", _
                                            "Aviso", _
                                            MessageBoxButtons.OK, _
                                            MessageBoxIcon.Information)
                        End If
                    End If
            End Select
        Catch ex As Exception
            MostrarError(ex, Me.MdiParent)
            Activar_Interface(Me, True)
        End Try
    End Sub
    Private Sub cmdXporMarca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdXporMarca.Click
        Try
            objMarca = Nothing
            objMarca = New BOVehicleSH.Marca
            Activar_Interface(Me, False, True)
            objMarca.Listar()
            Activar_Interface(Me, True, False)
            Grid_Dinamico(Me.tdbgMarca, objMarca.Storage.Tables.Item(0), , True)
        Catch ex As Exception
            Activar_Interface(Me, True, False)
            MostrarError(ex, Me.MdiParent)
        End Try
    End Sub
    Private Sub tdbgUnidades_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tdbgUnidades.KeyDown
        Dim int_L_IDX, _
            intVar_X, _
            int_L_RwBkmk As Integer, _
            str_L_Record As String
        Try
            If Not (tdbgUnidades.DataSource Is Nothing) Then
                With tdbgUnidades
                    int_L_IDX = .Row
                    int_L_RwBkmk = .RowBookmark(int_L_IDX)
                    If int_L_RwBkmk <> -1 Then
                        objVehiculo = Nothing
                        str_L_Record = .Columns.Item(0).CellValue(int_L_RwBkmk).ToString
                        intVar_X = Determinar_Renglon(str_L_Record, .DataSource)
                        objVehiculo = New BOVehicleSH.Vehiculo
                        With DirectCast(.DataSource, DataTable)
                            objVehiculo.IdVehiculo = .Rows(intVar_X).Item(0).ToString
                            objVehiculo.Tipo.IdTipoVehiculo = .Rows(intVar_X).Item(1).ToString
                            objVehiculo.Matricula = .Rows(intVar_X).Item(2).ToString
                            objVehiculo.Economico = .Rows(intVar_X).Item(3).ToString
                            objVehiculo.SerieChasis = .Rows(intVar_X).Item(4).ToString
                            objVehiculo.SerieMotor = .Rows(intVar_X).Item(5).ToString
                            objVehiculo.Tipo.Descripcion = .Rows(intVar_X).Item(6).ToString
                            objVehiculo.Marca.Descripcion = .Rows(intVar_X).Item(7).ToString
                            objVehiculo.Modelo = .Rows(intVar_X).Item(8).ToString
                            objVehiculo.Año = .Rows(intVar_X).Item(9).ToString
                        End With
                        ActualizarInt(9, Me, objVehiculo)
                    End If
                End With
            End If
        Catch ex As Exception
            MostrarError(ex, Me.MdiParent)
        End Try
    End Sub
    Private Sub tdbgMarca_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tdbgMarca.KeyDown
        Dim int_L_IDX, _
            int_L_RwBkmk As Integer, _
            str_L_Record As String
        Try
            With tdbgMarca
                If Not (.DataSource Is Nothing) Then
                    If .VisibleRows > 0 Then
                        If e.KeyCode = Keys.Enter Then
                            int_L_IDX = .Row
                            int_L_RwBkmk = .RowBookmark(int_L_IDX)
                            If int_L_RwBkmk <> -1 Then
                                str_L_Record = .Columns.Item(0).CellValue(int_L_RwBkmk).ToString
                                If Not (str_L_Record Is Nothing) Then
                                    intVar = Determinar_Renglon(str_L_Record, .DataSource)
                                    If intVar <> -1 Then
                                        objMarca = Nothing
                                        objMarca = New BOVehicleSH.Marca
                                        With objMarca
                                            .IdMarca = DirectCast(tdbgMarca.DataSource, DataTable).Rows(intVar).Item(0).ToString
                                            .Descripcion = DirectCast(tdbgMarca.DataSource, DataTable).Rows(intVar).Item(1).ToString
                                        End With
                                        txtMarca.Text = objMarca.Descripcion
                                        cmdProcessMarca.Text = "&Editar"
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End With
        Catch ex As Exception
            MostrarError(ex, Me.MdiParent)
        End Try
    End Sub
    Private Sub tdbgMarca_RowColChange(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.RowColChangeEventArgs) Handles tdbgMarca.RowColChange
        Try
            With tdbgMarca
                If Not (.DataSource Is Nothing) Then
                    objMarca = Nothing
                    txtMarca.Text = Nothing
                    cmdProcessMarca.Text = "&Nuevo"
                End If
            End With
        Catch ex As Exception
            MostrarError(ex, Me.MdiParent)
        End Try
    End Sub
    Private Sub cmdXprtVehiculo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdXprtVehiculo.Click
        Try
            objVehiculo = Nothing
            objVehiculo = New BOVehicleSH.Vehiculo
            Activar_Interface(Me, False)
            objVehiculo.Listar()
            Activar_Interface(Me, True)
            Export_Manager(objVehiculo.Storage.Tables.Item(0), cmdXprtVehiculo, cmdXportUns, tdbgUnidades, PREPARACION_EXPORTAR, Me)
        Catch ex As Exception
            Activar_Interface(Me, True)
            MostrarError(ex, Me.MdiParent)
        End Try
    End Sub
    Private Sub cmdXportUns_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdXportUns.Click
        Try
            Export_Manager(tdbgUnidades.DataSource, cmdXprtVehiculo, cmdXportUns, Me.tdbgUnidades, EXPORTACION_COMPLETA, Me)
            Reset_Grid(Me.tdbgUnidades)
        Catch ex As Exception
            MostrarError(ex, Me.MdiParent)
        End Try
    End Sub
    Private Sub cmdKillUnit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdKillUnit.Click
        Try
            If Not (objVehiculo Is Nothing) Then
                If MessageBox.Show("¿Desea desactivar la unidad seleccionada?", _
                                       "Confirme", _
                                       MessageBoxButtons.YesNo, _
                                       MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    '------------------------------------------------
                    Activar_Interface(Me, False, True)
                    '------------------------------------------------
                    objVehiculo.Desactivar()
                    '------------------------------------------------
                    Activar_Interface(Me, True)
                    '------------------------------------------------
                    ActualizarInt(8, Me)
                End If
            End If
        Catch ex As Exception
            Activar_Interface(Me, True)
            MostrarError(ex, Me.MdiParent)
        End Try
    End Sub
    Private Sub cmdProces_conjunto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdProces_conjunto.Click
        Dim str_L_Caption As String, _
            obj_L_TipoV_Loader As BOVehicleSH.TipoVehiculo, _
            str_L_IdTipoVehiculo As String, _
            col_L_Params As Collection
        Try
            str_L_Caption = Me.cmdProces_conjunto.Text
            Select Case str_L_Caption
                Case Is = "&Actualizar"
                    If Not (objConjunto Is Nothing) Then
                        If MessageBox.Show("¿Actualizar la información del elemento seleccionado?", _
                                           "Confirme", _
                                           MessageBoxButtons.YesNo, _
                                           MessageBoxIcon.Question) = SI Then
                            col_L_Params = Nothing
                            col_L_Params = New Collection
                            col_L_Params.Add(txtSCConj)
                            If Grupo_Parametros_Validos(col_L_Params) Then
                                Activar_Interface(Me, False)
                                With objConjunto
                                    .Descripcion = ProcesaCadena(txtSCConj.Text, True)
                                    .Actualizar()
                                End With
                                Activar_Interface(Me, True)
                                ActualizarInt(12, Me)
                            End If
                        End If
                    Else
                        MessageBox.Show("El objeto objConjunto es inexistente y por lo tanto no hay transacción", _
                                        "Aviso", _
                                        MessageBoxButtons.OK, _
                                        MessageBoxIcon.Warning)
                        Exit Sub
                    End If
                Case Is = "&Editar"
                    If Not (objConjunto Is Nothing) Then
                        If MessageBox.Show("¿Editar el elemento seleccionado?", _
                                       "Confirme", _
                                       MessageBoxButtons.YesNo, _
                                       MessageBoxIcon.Information) = SI Then
                            'Sólo permitimos la modificación de la descripcion
                            ActualizarInt(13, Me, objConjunto)
                        End If
                    End If
                Case Is = "&Guardar"
                    If MessageBox.Show("¿Registrar el nuevo conjunto?", _
                                       "Confirme", _
                                       MessageBoxButtons.YesNo, _
                                       MessageBoxIcon.Information) = SI Then
                        '---------------------------
                        objConjunto = Nothing
                        '---------------------------
                        objConjunto = New BOVehicleSH.Conjunto
                        '---------------------------
                        col_L_Params = Nothing
                        col_L_Params = New Collection
                        col_L_Params.Add(cboTVConjuntos)
                        col_L_Params.Add(txtSCConj)
                        With objConjunto
                            If Grupo_Parametros_Validos(col_L_Params) = True Then
                                str_L_IdTipoVehiculo = cboTVConjuntos.SelectedValue.ToString
                                .IDTipoVehiculo = str_L_IdTipoVehiculo
                                .Descripcion = ProcesaCadena(txtSCConj.Text)
                                '---------------------------
                                Activar_Interface(Me, False)
                                '---------------------------
                                .Registrar()
                                '---------------------------
                                Activar_Interface(Me, True)
                                '------------------------  
                                ActualizarInt(12, Me)
                            Else
                                MessageBox.Show("Los parámetros están incompletos, por favor verificar", "Verifique", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                Exit Sub
                            End If
                        End With
                    End If
                Case Is = "&Procesar"
                    If MessageBox.Show("¿Desea registrar un nuevo conjunto?", "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = SI Then
                        obj_L_TipoV_Loader = New BOVehicleSH.TipoVehiculo
                        '----------------------------
                        Activar_Interface(Me, False)
                        '----------------------------
                        obj_L_TipoV_Loader.Listar(True)
                        '----------------------------
                        Activar_Interface(Me, True)
                        '----------------------------
                        ActualizarInt(11, Me, obj_L_TipoV_Loader)
                    Else
                        Exit Sub
                    End If
            End Select
        Catch ex As Exception
            Activar_Interface(Me, True)
            MostrarError(ex, Me.MdiParent)
        End Try
    End Sub
    Private Sub cmdCancel_Conj_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel_Conj.Click
        Dim str_L_Caption_Proc As String
        Try
            str_L_Caption_Proc = cmdProces_conjunto.Text
            Select Case str_L_Caption_Proc
                Case Is = "&Procesar"
                Case Is = "&Guardar"
                    If MessageBox.Show("¿Cancelar el registro de un nuevo conjunto?", _
                                       "Confirme", _
                                       MessageBoxButtons.YesNo, _
                                       MessageBoxIcon.Question) = SI Then
                        ActualizarInt(12, Me)
                    End If
                Case Is = "&Editar"
                    ActualizarInt(12, Me)
                    Me.TDbgConjuntos.Enabled = True
                Case Is = "&Actualizar"
                    If MessageBox.Show("¿Cancelar la edición del elemento seleccionado?", _
                                        "Confirme", _
                                        MessageBoxButtons.YesNo, _
                                        MessageBoxIcon.Question) = SI Then
                        ActualizarInt(12, Me)
                        Me.TDbgConjuntos.Enabled = True
                    End If
                Case Is = ""
                Case Is = ""
            End Select
        Catch ex As Exception
            Activar_Interface(Me, True)
            MostrarError(ex, Me.MdiParent)
        End Try
    End Sub
    Private Sub cmdQueryC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdQueryC.Click
        Dim objConjunto_Query As BOVehicleSH.Conjunto
        Try
            objConjunto_Query = Nothing
            objConjunto_Query = New BOVehicleSH.Conjunto
            Activar_Interface(Me, False)
            objConjunto_Query.Listar()
            Activar_Interface(Me, True)
            Grid_Dinamico(Me.TDbgConjuntos, objConjunto_Query.Storage.Tables.Item(0), , True)
        Catch ex As Exception
            Activar_Interface(Me, True)
            MostrarError(ex, Me.MdiParent)
        End Try
    End Sub
    Private Sub TDbgConjuntos_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TDbgConjuntos.KeyDown
        Dim int_L_IDX, _
            intVar_X, _
            int_L_RwBkmk As Integer, _
            str_L_Record As String
        Try
            If e.KeyCode = Keys.Enter Then
                If Not (TDbgConjuntos.DataSource Is Nothing) Then
                    With TDbgConjuntos
                        int_L_IDX = .Row
                        int_L_RwBkmk = .RowBookmark(int_L_IDX)
                        If int_L_RwBkmk <> -1 Then
                            objConjunto = Nothing
                            objConjunto = New BOVehicleSH.Conjunto
                            str_L_Record = .Columns.Item(0).CellValue(int_L_RwBkmk).ToString
                            intVar_X = Determinar_Renglon(str_L_Record, .DataSource)
                            If intVar_X <> -1 Then
                                With objConjunto
                                    .IdConjunto = DirectCast(TDbgConjuntos.DataSource, DataTable).Rows(intVar_X).Item(0)
                                    .IDTipoVehiculo = DirectCast(TDbgConjuntos.DataSource, DataTable).Rows(intVar_X).Item(1)
                                    .TipoVehiculo = DirectCast(TDbgConjuntos.DataSource, DataTable).Rows(intVar_X).Item(2)
                                    .Descripcion = DirectCast(TDbgConjuntos.DataSource, DataTable).Rows(intVar_X).Item(3)
                                End With
                                With objConjunto
                                    cboTVConjuntos.Text = .TipoVehiculo
                                    txtSCConj.Text = .Descripcion
                                End With
                                cmdProces_conjunto.Text = "&Editar"
                            End If
                        End If
                    End With
                End If
            End If
        Catch ex As Exception
            MostrarError(ex, Me.MdiParent)
        End Try
    End Sub
    Private Sub cmdKillConj_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdKillConj.Click
        Try
            If Not (objConjunto Is Nothing) Then
                If MessageBox.Show("¿Está seguro de que desea eliminar el conjunto indicado?", _
                                   "Verifique", _
                                   MessageBoxButtons.YesNo, _
                                   MessageBoxIcon.Question) = SI Then
                End If
            End If
        Catch ex As Exception
            MostrarError(ex, Me.MdiParent)
        End Try
    End Sub
    Private Sub cmdXport_C_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdXport_C.Click
        Try
            Export_Manager(TDbgConjuntos.DataSource, cmdQueryC, cmdXport_C, TDbgConjuntos, EXPORTACION_COMPLETA, Me)
            Reset_Grid(TDbgConjuntos)
        Catch ex As Exception
            MostrarError(ex, Me.MdiParent)
        End Try
    End Sub
    Private Sub cmdXportSubs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdQueySubs.Click
        Try
            objSubConjunto = Nothing
            objSubConjunto = New BOVehicleSH.Subconjunto
            ActualizarInt(17, Me, objConjunto)
            Activar_Interface(Me, False)
            objSubConjunto.Listar()
            Activar_Interface(Me, True)
            Grid_Dinamico(tdbgSubs, objSubConjunto.Storage.Tables.Item(0), False, True)
        Catch ex As Exception
            Activar_Interface(Me, True)
            MostrarError(ex, Me.MdiParent)
        End Try
    End Sub
    Private Sub cmdProcesar_Subs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdProcesar_Subs.Click
        Dim str_P_Caption As String
        Try
            str_P_Caption = cmdProcesar_Subs.Text
            Select Case str_P_Caption
                Case Is = "&Actualizar"
                    If Not (objSubConjunto Is Nothing) Then                        
                        If MessageBox.Show("¿Desea actualizar el registro seleccionado?", _
                                       "Confirme", _
                                       MessageBoxButtons.YesNo, _
                                       MessageBoxIcon.Question) = SI Then
                            col_L_Parametros = Nothing
                            col_L_Parametros = New Collection
                            With col_L_Parametros
                                .Add(txtSubConjunto)
                            End With
                            If Grupo_Parametros_Validos(col_L_Parametros) Then
                                '▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬
                                Activar_Interface(Me, False)
                                '▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬
                                With objSubConjunto
                                    '.Conjunto_Padre.IdConjunto = cboConjunto_SBS.SelectedValue.ToString
                                    .Descripcion = txtSubConjunto.Text
                                    .Actualizar()
                                End With
                                '▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬
                                Activar_Interface(Me, True)
                                '▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬
                                ActualizarInt(15, Me)
                                '▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬
                            Else
                                MessageBox.Show("Hay datos incompletos, por favor verifique", _
                                                "Verifique", _
                                                MessageBoxButtons.OK, _
                                                MessageBoxIcon.Information _
                                                )
                                Exit Sub
                            End If
                        End If
                    End If
                Case Is = "&Editar"
                    If Not (objSubConjunto Is Nothing) Then
                        If MessageBox.Show("¿Editar el elemento seleccionado?", _
                                           "Confirme", _
                                           MessageBoxButtons.YesNo, _
                                           MessageBoxIcon.Question) = SI Then
                            '▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬
                            ActualizarInt(16, Me)
                            '▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬
                            Activar_Interface(Me, False)
                            '▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬
                            'objSubConjunto.Conjunto_Padre.Listar(True)
                            '▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬
                            Activar_Interface(Me, True)
                            '▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬
                            bln_M_Modo_Carga = True
                            '*************************
                            'CargaCombo(cboConjunto_SBS, objSubConjunto.Conjunto_Padre.Storage.Tables.Item(0), 0, 1, , True, , , True)
                            '*************************
                            bln_M_Modo_Carga = False
                            '▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬
                        End If
                    End If
                Case Is = "&Guardar"
                    col_L_Parametros = Nothing
                    col_L_Parametros = New Collection
                    With col_L_Parametros
                        .Add(cboConjunto_SBS)
                        .Add(txtSubConjunto)
                    End With
                    If Grupo_Parametros_Validos(col_L_Parametros) Then
                        '---------------------------
                        Activar_Interface(Me, False)
                        '---------------------------
                        objSubConjunto = Nothing
                        objSubConjunto = New BOVehicleSH.Subconjunto
                        With objSubConjunto
                            .Conjunto_Padre.IdConjunto = cboConjunto_SBS.SelectedValue.ToString
                            .Descripcion = ProcesaCadena(txtSubConjunto.Text)
                            .Registrar()
                        End With
                        '---------------------------
                        Activar_Interface(Me, True)
                        '---------------------------
                        ActualizarInt(15, Me)
                    Else
                        MessageBox.Show("Los datos están incompletos", "Verifique", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    End If
                Case Is = "&Procesar"
                    If MessageBox.Show("¿Registrar un nuevo subconjunto?", _
                                       "Confirme", _
                                       MessageBoxButtons.YesNo, _
                                       MessageBoxIcon.Question) = SI Then
                        '▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬

                        '▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬
                        objTipoVeh = Nothing
                        objTipoVeh = New BOVehicleSH.TipoVehiculo
                        Activar_Interface(Me, False)
                        objTipoVeh.Listar(True)
                        Activar_Interface(Me, True)
                        '▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬
                        bln_Cbo_Modo_Edicion = True
                        '▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬
                        CargaCombo(cboTipoVehiculoSBS, objTipoVeh.Storage.Tables.Item(0), 0, 1, , True, , , True)
                        '▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬
                        bln_Cbo_Modo_Edicion = False
                        '▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬
                        ActualizarInt(14, Me)
                    End If
            End Select
        Catch ex As Exception
            bln_Cbo_Modo_Edicion = False
            Activar_Interface(Me, True)
            MostrarError(ex, Me.MdiParent)
        End Try
    End Sub
    Private Sub cboTipoVehiculoSBS_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoVehiculoSBS.SelectedIndexChanged
        Dim str_P_IdTipoVehiculo As String, _
            obj_P_Conjunto_Lista As BOVehicleSH.Conjunto
        Try
            '----------------------------------
            ResetCombo(cboConjunto_SBS, False)
            With txtSubConjunto
                .Text = Nothing
                .Enabled = False
            End With
            '----------------------------------
            If bln_Cbo_Modo_Edicion = False Then
                str_P_IdTipoVehiculo = cboTipoVehiculoSBS.SelectedValue.ToString
                If Not (str_P_IdTipoVehiculo Is Nothing) Then
                    If Len(str_P_IdTipoVehiculo) > 0 Then
                        obj_P_Conjunto_Lista = Nothing
                        obj_P_Conjunto_Lista = New BOVehicleSH.Conjunto
                        '▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬
                        Activar_Interface(Me, False)
                        '▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬
                        With obj_P_Conjunto_Lista
                            .IDTipoVehiculo = str_P_IdTipoVehiculo
                            .Listar(True)
                        End With
                        '▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬
                        Activar_Interface(Me, True)
                        '▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬
                        bln_Cbo_Modo_Edicion = True
                        CargaCombo(cboConjunto_SBS, obj_P_Conjunto_Lista.Storage.Tables.Item(0), 0, 1, False, True, False, , True)
                        bln_Cbo_Modo_Edicion = False
                    End If
                End If
            End If
        Catch ex As Exception
            bln_Cbo_Modo_Edicion = False
            Activar_Interface(Me, True)
            MostrarError(ex, Me.MdiParent)
        End Try
    End Sub
    Private Sub cboConjunto_SBS_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboConjunto_SBS.SelectedIndexChanged
        Try
            If cboConjunto_SBS.SelectedIndex <> -1 Then
                With txtSubConjunto
                    .Text = Nothing
                    .Enabled = True
                    .Focus()
                End With
            End If
        Catch ex As Exception
            bln_Cbo_Modo_Edicion = False
            Activar_Interface(Me, True)
            MostrarError(ex, Me.MdiParent)
        End Try
    End Sub
    Private Sub tdbgSubs_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tdbgSubs.KeyDown
        Dim int_L_IDX, _
            intVar_X, _
            int_L_RwBkmk As Integer, _
            str_L_Record As String
        Try
            With tdbgSubs
                If Not (.DataSource Is Nothing) Then
                    If e.KeyCode = Keys.Enter Then
                        If .Row <> -1 Then
                            int_L_IDX = .Row
                            int_L_RwBkmk = .RowBookmark(int_L_IDX)
                            str_L_Record = .Columns.Item(0).CellValue(int_L_RwBkmk).ToString
                            intVar_X = Determinar_Renglon(str_L_Record, .DataSource)
                            If intVar_X <> -1 Then
                                objSubConjunto = Nothing
                                objSubConjunto = New BOVehicleSH.Subconjunto
                                '▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬
                                With objSubConjunto
                                    .IdSubConjunto = DirectCast(tdbgSubs.DataSource, DataTable).Rows(intVar_X).Item(0).ToString
                                    .Conjunto_Padre.IdConjunto = DirectCast(tdbgSubs.DataSource, DataTable).Rows(intVar_X).Item(1).ToString
                                    .Conjunto_Padre.IDTipoVehiculo = DirectCast(tdbgSubs.DataSource, DataTable).Rows(intVar_X).Item(2).ToString
                                    .Conjunto_Padre.TipoVehiculo = DirectCast(tdbgSubs.DataSource, DataTable).Rows(intVar_X).Item(3).ToString
                                    .Conjunto_Padre.Descripcion = DirectCast(tdbgSubs.DataSource, DataTable).Rows(intVar_X).Item(4).ToString
                                    .Descripcion = DirectCast(tdbgSubs.DataSource, DataTable).Rows(intVar_X).Item(5).ToString
                                End With
                                '▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬
                                cboTipoVehiculoSBS.Text = objSubConjunto.Conjunto_Padre.TipoVehiculo
                                cboConjunto_SBS.Text = objSubConjunto.Conjunto_Padre.Descripcion
                                txtSubConjunto.Text = objSubConjunto.Descripcion
                                '▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬
                                cmdProcesar_Subs.Text = "&Editar"
                                '▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬
                            End If
                        End If
                    End If
                End If
            End With
        Catch ex As Exception
            MostrarError(ex, Me.MdiParent)
        End Try
    End Sub
    Private Sub cmdCancelSubs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelSubs.Click
        Dim str_L_Canceltext As String
        Try
            str_L_Canceltext = cmdProcesar_Subs.Text
            Select Case str_L_Canceltext
                Case Is = "&Actualizar"
                    If MessageBox.Show("¿Cancelar la modificación del elemento seleccionado?", _
                                       "Confirme", _
                                       MessageBoxButtons.YesNo, _
                                       MessageBoxIcon.Question) = SI Then
                        ActualizarInt(17, Me, objConjunto)
                        tdbgSubs.Enabled = True
                    End If
                Case Is = "&Editar"
                    ActualizarInt(17, Me, objConjunto)
            End Select
        Catch ex As Exception
            MostrarError(ex, Me.MdiParent)
        End Try
    End Sub
    Private Sub cmdOperFix_Process_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOperFix_Process.Click
        Dim str_L_Caption As String, _
            colCtrls As Collection, _
            str_L_Des_Act As String
        Try
            str_L_Caption = cmdOperFix_Process.Text
            Select Case str_L_Caption
                Case Is = "&Actualizar"
                    If Not (objReparacion Is Nothing) Then
                        str_L_Des_Act = ProcesaCadena(txtFix_Description.Text, True)
                        If Not (str_L_Des_Act) Is Nothing Then
                            If MessageBox.Show("¿Actualizar el registro seleccionado?", _
                                           "Confirme", _
                                           MessageBoxButtons.YesNo, _
                                           MessageBoxIcon.Question) = SI Then
                                Activar_Interface(Me, False, True)
                                With objReparacion
                                    .Descripcion = str_L_Des_Act
                                    .Actualiza()
                                End With
                                Activar_Interface(Me, True)
                                ActualizarInt(21, Me)
                            End If
                        Else
                            MessageBox.Show("Debe indicar la descripción de la reparación/actividad", _
                                            "Información incompleta", _
                                            MessageBoxButtons.OK, _
                                            MessageBoxIcon.Information)
                            '---------
                            Exit Sub
                            '---------
                        End If
                    End If
                Case Is = "&Editar"
                    If Not (objReparacion Is Nothing) Then
                        If MessageBox.Show("¿Editar el elemento seleccionado?", _
                                           "Confirme", _
                                        MessageBoxButtons.YesNo, _
                                        MessageBoxIcon.Question) = SI Then
                            '------------------------------
                            Reset_Grid(tdbgFix_Qry, False)
                            '------------------------------
                            With cmdModify_Rep_Cond
                                .Enabled = True
                                .Visible = True
                            End With
                            '----------------------------------------
                            cmdOperFix_Process.Text = "&Actualizar"
                            '----------------------------------------
                            With txtFix_Description
                                .Text = objReparacion.Descripcion
                                .Enabled = True
                                .Focus()
                            End With
                            '----------------------------------
                            tabMode.TabPages(1).Enabled = False
                            '----------------------------------
                        Else
                            Exit Sub
                        End If
                    End If
                Case Is = "&Guardar"
                    If MessageBox.Show("¿Registrar la nueva reparación?", _
                                       "Confirme", _
                                       MessageBoxButtons.YesNo, _
                                       MessageBoxIcon.Question) = SI Then
                        colCtrls = Nothing
                        colCtrls = New Collection
                        With colCtrls
                            .Add(cboSubConjuntoFix)
                            .Add(txtFix_Description)
                        End With
                        If Grupo_Parametros_Validos(colCtrls) Then
                            objReparacion = Nothing
                            objReparacion = New BOVehicleSH.Reparacion
                            With objReparacion
                                .IdSubConjunto = cboSubConjuntoFix.SelectedValue.ToString
                                .Descripcion = ProcesaCadena(txtFix_Description.Text, True)
                                .Registra()
                            End With
                            'no hubo error, actualizmos la interfaz
                            ActualizarInt(19, Me)
                        Else
                            MessageBox.Show("Los datos están incompletos", _
                                            "Verificar", _
                                            MessageBoxButtons.OK, _
                                            MessageBoxIcon.Exclamation)
                        End If
                    End If
                Case Is = "&Procesar"
                    If MessageBox.Show("¿Iniciar el registro de una nueva reparación?", _
                                       "Confirme", _
                                       MessageBoxButtons.YesNo, _
                                       MessageBoxIcon.Question) = SI Then
                        objTipoVeh = Nothing
                        objTipoVeh = New BOVehicleSH.TipoVehiculo
                        Activar_Interface(Me, False)
                        'objTipoVeh.Listar(False)
                        objTipoVeh.Listar(True)
                        Activar_Interface(Me, True)
                        bln_G_Mod_Edicion = True
                        ActualizarInt(18, Me, objTipoVeh)
                        bln_G_Mod_Edicion = False
                    End If
            End Select
        Catch ex As Exception
            bln_G_Mod_Edicion = False
            Activar_Interface(Me, True)
            MostrarError(ex, Me.MdiParent)
        End Try
    End Sub
    Private Sub cboTipoVehiculo_Fix_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoVehiculo_Fix.SelectedIndexChanged
        Try
            If bln_G_Mod_Edicion = False Then
                bln_G_Mod_Edicion = True
                objConjunto = Nothing
                objConjunto = New BOVehicleSH.Conjunto
                bln_G_Mod_Edicion = True
                Activar_Interface(Me, False)
                With objConjunto
                    .IDTipoVehiculo = cboTipoVehiculo_Fix.SelectedValue.ToString
                    .Listar(True)
                End With
                Activar_Interface(Me, True)
                'Reinicio del cuadro de texto de la reparacion
                With txtFix_Description
                    .Text = Nothing
                    .Enabled = False
                End With
                'Reinicio combo subconjunto
                ResetCombo(cboSubConjuntoFix, False)
                CargaCombo(cboConjunto_Fix, objConjunto.Storage.Tables.Item(0), 0, 1, False, True, , , True)

                bln_G_Mod_Edicion = False
            End If
        Catch ex As Exception
            bln_G_Mod_Edicion = False
            Activar_Interface(Me, True)
            MostrarError(ex, Me.MdiParent)
        End Try
    End Sub
    Private Sub cboConjunto_Fix_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboConjunto_Fix.SelectedIndexChanged
        Try
            If bln_G_Mod_Edicion = False Then
                '------------------------
                bln_G_Mod_Edicion = True
                '------------------------
                objSubConjunto = Nothing
                objSubConjunto = New BOVehicleSH.Subconjunto
                With objSubConjunto
                    .Conjunto_Padre.IdConjunto = cboConjunto_Fix.SelectedValue.ToString
                    .Listar(True)
                End With
                CargaCombo(cboSubConjuntoFix, objSubConjunto.Storage.Tables.Item(0), 0, 1, , True, False, , True)
                '------------------------
                bln_G_Mod_Edicion = False
                '------------------------
            End If
        Catch ex As Exception
            bln_G_Mod_Edicion = False
            Activar_Interface(Me, True)
            MostrarError(ex, Me.MdiParent)
        End Try
    End Sub
    Private Sub cboSubConjuntoFix_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSubConjuntoFix.SelectedIndexChanged
        Try
            With txtFix_Description
                .Text = Nothing
                .Enabled = True
            End With
        Catch ex As Exception
            Activar_Interface(Me, True)
            MostrarError(ex, Me.MdiParent)
        End Try
    End Sub
    Private Sub cmdStarterTV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdStarterTV.Click
        Dim objTipoVeh = New BOVehicleSH.TipoVehiculo
        Try
            'Reiniciaremos todos los combos
            bln_G_Mod_Edicion = True
            '----------------------------
            ResetCombo(cboQry_Fix_Tv)
            ResetCombo(cboQry_Fix_Conj)
            ResetCombo(cboQry_Fix_SubC)
            '----------------------------
            bln_G_Mod_Edicion = False
            If objTipoVeh Is Nothing Then
                objTipoVeh = Nothing
            End If
            objTipoVeh = New BOVehicleSH.TipoVehiculo
            Activar_Interface(Me, False)
            objTipoVeh.Listar(True)
            Activar_Interface(Me, True)
            bln_G_Mod_Edicion = True
            modHerramientas.CargaCombo(cboQry_Fix_Tv, objTipoVeh.Storage.Tables.Item(0), 0, 1, False, True, , , True)
            bln_G_Mod_Edicion = False
        Catch ex As Exception
            bln_G_Mod_Edicion = False
            Activar_Interface(Me, True)
            MostrarError(ex, Me.MdiParent)
        End Try
    End Sub
    Private Sub cboQry_Fix_Tv_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboQry_Fix_Tv.SelectedIndexChanged
        Try
            If bln_G_Mod_Edicion = False Then
                bln_G_Mod_Edicion = True
                'Reiniciamos el grisd, por si tiene resultados
                Reset_Grid(tdbgFix_Qry, False)
                'Desactivamos el boton de exportar
                cmdQryFix_Xport.Enabled = False
                'Reiniciamos los combos dependientes
                ResetCombo(cboQry_Fix_SubC, False)
                ResetCombo(cboQry_Fix_Conj, False)
                objConjunto = Nothing
                objConjunto = New BOVehicleSH.Conjunto
                bln_G_Mod_Edicion = True
                Activar_Interface(Me, False)
                With objConjunto
                    .IDTipoVehiculo = cboQry_Fix_Tv.SelectedValue.ToString
                    .Listar(True)
                End With
                Activar_Interface(Me, True)
                CargaCombo(cboQry_Fix_Conj, objConjunto.Storage.Tables.Item(0), 0, 1, False, True, , , True)
                bln_G_Mod_Edicion = False
            End If
        Catch ex As Exception
            bln_G_Mod_Edicion = False
            Activar_Interface(Me, True)
            MostrarError(ex, Me.MdiParent)
        End Try
    End Sub
    Private Sub cboQry_Fix_Conj_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboQry_Fix_Conj.SelectedIndexChanged
        Try
            If bln_G_Mod_Edicion = False Then
                '------------------------
                bln_G_Mod_Edicion = True
                '------------------------
                'Reiniciamos el grisd, por si tiene resultados
                Reset_Grid(tdbgFix_Qry, False)
                'Desactivamos el boton de exportar
                cmdQryFix_Xport.Enabled = False
                ResetCombo(cboQry_Fix_SubC, False)
                objSubConjunto = Nothing
                objSubConjunto = New BOVehicleSH.Subconjunto
                With objSubConjunto
                    .Conjunto_Padre.IdConjunto = cboQry_Fix_Conj.SelectedValue.ToString
                    .Listar(True)
                End With
                CargaCombo(cboQry_Fix_SubC, objSubConjunto.Storage.Tables.Item(0), 0, 1, False, True, , , True)
                '------------------------
                bln_G_Mod_Edicion = False
                '------------------------
            End If
        Catch ex As Exception
            bln_G_Mod_Edicion = False
            Activar_Interface(Me, True)
            MostrarError(ex, Me.MdiParent)
        End Try

    End Sub
    Private Sub cmdQryFixQry_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdQryFixQry.Click
        Dim obj_L_Reparaciones As BOVehicleSH.Reparacion, _
            str_L_IdTipoVeh, _
            str_L_IdConj, _
            str_L_IdSub As String
        Try
            If bln_G_Mod_Edicion = False Then

                obj_L_Reparaciones = Nothing
                If cboQry_Fix_Tv.SelectedIndex <> -1 Then
                    If cboQry_Fix_Conj.SelectedIndex <> -1 Then
                        If cboQry_Fix_SubC.SelectedIndex <> -1 Then
                            'Iniciamos la consulta
                            '--------------------------------------------------------
                            '--------------------------------------------------------
                            str_L_IdSub = cboQry_Fix_SubC.SelectedValue.ToString    '*
                            obj_L_Reparaciones = New BOVehicleSH.Reparacion         '*
                            '--------------------------------------------------------
                            '--------------------------------------------------------
                            Activar_Interface(Me, False, True)
                            With obj_L_Reparaciones
                                .Listar(str_L_IdSub)
                            End With
                            Activar_Interface(Me, True, False)
                            Grid_Dinamico(tdbgFix_Qry, obj_L_Reparaciones.Storage.Tables.Item(0), False, True)
                            'Activar el boton de exportacion
                            With cmdQryFix_Xport
                                .Enabled = DirectCast(tdbgFix_Qry.DataSource, DataTable).Rows.Count > 0
                                .Visible = .Enabled
                            End With
                        Else
                            MessageBox.Show("Por favor indique el subconjunto", _
                                            "Verifique", _
                                            MessageBoxButtons.OK, _
                                            MessageBoxIcon.Information)
                        End If
                    Else
                        MessageBox.Show("Por favor indique el conjunto", _
                                        "Verifique", _
                                        MessageBoxButtons.OK, _
                                        MessageBoxIcon.Information)
                    End If
                Else
                    MessageBox.Show("Por favor indique el tipo de unidad", _
                                    "Verifique", _
                                    MessageBoxButtons.OK, _
                                    MessageBoxIcon.Information)
                End If
            End If
        Catch ex As Exception
            bln_G_Mod_Edicion = False
            Activar_Interface(Me, True)
            MostrarError(ex, Me.MdiParent)
        End Try
    End Sub
    Private Sub cboQry_Fix_SubC_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboQry_Fix_SubC.SelectedIndexChanged
        Try
            'Reiniciamos el grisd, por si tiene resultados
            Reset_Grid(tdbgFix_Qry, False)
            'Desactivamos el boton de exportar
            cmdQryFix_Xport.Enabled = False
        Catch ex As Exception
            MostrarError(ex, Me.MdiParent)
        End Try
    End Sub
    Private Sub cmdQryFix_Xport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdQryFix_Xport.Click
        Try
            'Export_Manager(tdbgFix_Qry.DataSource, cmdXprtVehiculo, cmdXportUns, Me.tdbgUnidades, EXPORTACION_COMPLETA, Me)
            Export_Manager(tdbgFix_Qry.DataSource, cmdQryFixQry, cmdQryFix_Xport, tdbgFix_Qry, "EXP", Me)
            Reset_Grid(Me.tdbgFix_Qry)
        Catch ex As Exception
            MostrarError(ex, Me.MdiParent)
        End Try
    End Sub
    Private Sub cmdModify_Rep_Cond_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModify_Rep_Cond.Click
        Try
            If Not (objReparacion Is Nothing) Then
                If MessageBox.Show("¿Está seguro de que desea eliminar/desactivar la acticidad?", _
                                   "Verifique", _
                                    MessageBoxButtons.YesNo, _
                                    MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    '---------------------------------
                    Activar_Interface(Me, False)
                    '---------------------------------
                    objReparacion.Desactivar()
                    '---------------------------------
                    Activar_Interface(Me, True)
                    '---------------------------------
                    ActualizarInt(21, Me)
                    '---------------------------------
                End If
            End If            
        Catch ex As Exception
            Activar_Interface(Me, True, True)
            MostrarError(ex, Me.MdiParent)
        End Try
    End Sub
    Private Sub cmdOperFix_Cancel_Click(sender As System.Object, e As System.EventArgs) Handles cmdOperFix_Cancel.Click
        Dim str_L_Caption As String
        Try
            str_L_Caption = cmdOperFix_Process.Text
            Select Case str_L_Caption
                Case Is = "&Editar"
                    If MessageBox.Show("¿Esta seguro de que desea salir sin registrar?", _
                                       "Confirme", _
                                       MessageBoxButtons.YesNo, _
                                       MessageBoxIcon.Question) = SI Then
                        'eliminamos el objeto y regresamos la interfaz a la normalidad
                        ActualizarInt(22, Me)
                    End If
                Case Is = "&Actualizar"
                    If MessageBox.Show("¿Esta seguro de que desea salir sin registrar?", _
                                       "Confirme", _
                                       MessageBoxButtons.YesNo, _
                                       MessageBoxIcon.Question) = SI Then
                        'eliminamos el objeto y regresamos la interfaz a la normalidad
                        ActualizarInt(19, Me)
                    End If
                Case Is = "&Guardar"
                    If MessageBox.Show("¿Esta seguro de que desea salir sin registrar?", _
                                       "Confirme", _
                                       MessageBoxButtons.YesNo, _
                                       MessageBoxIcon.Question) = SI Then
                        'eliminamos el objeto y regresamos la interfaz a la normalidad
                        ActualizarInt(19, Me)
                    End If
            End Select
        Catch ex As Exception
            Activar_Interface(Me, True, True)
            MostrarError(ex, Me.MdiParent)
        End Try
    End Sub

    Private Sub txtMarca_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtMarca.TextChanged

    End Sub

    Private Sub txtModelo_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtModelo.TextChanged

    End Sub

    Private Sub cboTipoUnidad_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboTipoUnidad.SelectedIndexChanged

    End Sub

    Private Sub cboMarca_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboMarca.SelectedIndexChanged

    End Sub
End Class