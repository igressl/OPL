Module Politicas
#Region "Variables"
    Dim str_NombreFormulario As String, _
        objFormulario As Form, _
        strNivelPermiso As String
#End Region
#Region "Metodos"
    ''' <summary>
    ''' Aplica los permisos/politicas de acuerdo al perfil del usuario
    ''' </summary>
    ''' <param name="Entidad">
    ''' Objeto donde está cargada la información del usuario
    ''' </param>
    ''' <param name="Formulario">
    ''' Formulario al que se aplicaran los permisos
    ''' </param>
    ''' <remarks>
    ''' No hay observaciones adicionales
    ''' </remarks>
    Public Sub Aplicar_Politicas(ByRef Entidad As SOLink.clUsuario, _
                                 ByRef Formulario As Form, _
                                 Optional ByRef Auxiliar As Object = Nothing)
        Dim strFormaName As String
        Try
            ''RO Read Only, permisos solo lectura / consulta
            'strFormaName = Formulario.Name.ToString
            'If Not (Entidad.Formularios Is Nothing) Then
            '    For Each Forma As Object In Entidad.Formularios
            '        str_NombreFormulario = CType(Forma, Encephalon.Formulario).Nombre
            '        strNivelPermiso = CType(Forma, Encephalon.Formulario).Permiso
            '        If strFormaName = str_NombreFormulario Then
            '            Select Case str_NombreFormulario
            '                Case Is = "frmOrdenCompra"
            '                    Select Case strNivelPermiso
            '                        Case Is = "ABSOLUTO"
            '                        Case Is = "ADMINISTRACION"
            '                        Case Is = "CONSULTA"
            '                            With CType(Formulario, frmOrdenCompra)
            '                                .cmdPrint.Enabled = False
            '                            End With
            '                        Case Is = "OPERACION"
            '                    End Select
            '                Case Is = "frmCatArticulo"
            '                    Select Case strNivelPermiso
            '                        Case Is = "ABSOLUTO"
            '                            With CType(Formulario, frmCatArticulo)
            '                                .Edicion_Ubi = True
            '                                .Edicion_Code = True
            '                                .cmdProcesar.Enabled = True
            '                                .cmdCancelar.Enabled = True
            '                            End With
            '                        Case Is = "ADMINISTRACION"
            '                            With CType(Formulario, frmCatArticulo)
            '                                .Edicion_Ubi = True
            '                                .cmdProcesar.Enabled = False
            '                                .cmdCancelar.Enabled = False
            '                            End With
            '                        Case Is = "CONSULTA"
            '                            With CType(Formulario, frmCatArticulo)
            '                                .Edicion_Ubi = False
            '                                .cmdProcesar.Enabled = False
            '                                .cmdCancelar.Enabled = True
            '                                .cmdEditar_Ubicacion.Enabled = False
            '                                .cmd_Cancel_Edit.Enabled = False
            '                            End With
            '                            Exit Sub
            '                        Case Is = "OPERACION"
            '                            With CType(Formulario, frmCatArticulo)
            '                                .Edicion_Ubi = False
            '                                .tdbgArticulos.Enabled = False
            '                                .cmdEditar_Ubicacion.Enabled = False
            '                                .cmd_Cancel_Edit.Enabled = False
            '                                .cmdAdicionaUbicacion.Enabled = False
            '                                .cmdProcesar.Enabled = True
            '                                .txtCode.Focus()
            '                            End With
            '                    End Select
            '                Case Is = "frmKardex"
            '                    Select Case strNivelPermiso
            '                        Case Is = "CONSULTA"
            '                            With CType(Formulario, frmKardex)
            '                            End With
            '                        Case Is = "OPERACION", "ADMINISTRACION"
            '                    End Select
            '                Case Is = "frmConfigs"
            '                    Select Case strNivelPermiso
            '                        Case Is = "CONSULTA"
            '                            With CType(Formulario, frmConfigs)
            '                                .cmdProcesar_A.Enabled = False
            '                                .cmdProcesa_B.Enabled = False
            '                                .cmdProcesar_Fams.Enabled = False
            '                                .cmdProcesar_SubFams.Enabled = False
            '                            End With
            '                        Case Is = "OPERACION", "ADMINISTRACION"
            '                            With CType(Formulario, frmConfigs)
            '                                .cmdProcesar_A.Enabled = True
            '                                .cmdProcesa_B.Enabled = True
            '                                .cmdProcesar_Fams.Enabled = True
            '                                .cmdProcesar_SubFams.Enabled = True
            '                            End With
            '                    End Select
            '                Case Is = "frmSolicitudRefs"
            '                    With CType(Formulario, frmSolicitudRefs)
            '                        Select Case strNivelPermiso
            '                            Case Is = "OPERACION"
            '                                .cmdProcesar.Enabled = True
            '                                .cmdKill_Sol.Enabled = False
            '                                If Not (Auxiliar Is Nothing) Then
            '                                    .cmdPrint.Enabled = False
            '                                    With .tdbgSolItems
            '                                        .AllowAddNew = True
            '                                        .Enabled = True
            '                                        If .Splits(0).DisplayColumns.Count > 0 Then
            '                                            With .Splits(0).DisplayColumns
            '                                                .Item(0).Locked = False
            '                                                .Item(9).Locked = False
            '                                                .Item(5).Locked = False
            '                                            End With
            '                                            .Refresh()
            '                                            .MoveLast()
            '                                            .MoveFirst()
            '                                            .Update()
            '                                        End If
            '                                    End With
            '                                End If
            '                            Case Is = "ADMINISTRACION", "ABSOLUTO"
            '                                .cmdProcesar.Enabled = True
            '                                If Not (Auxiliar Is Nothing) Then
            '                                    .cmdPrint.Enabled = False
            '                                    With .tdbgSolItems
            '                                        .AllowAddNew = True
            '                                        .Enabled = True
            '                                        If .Splits(0).DisplayColumns.Count > 0 Then
            '                                            With .Splits(0).DisplayColumns
            '                                                .Item(0).Locked = False
            '                                                .Item(9).Locked = False
            '                                                .Item(5).Locked = False
            '                                            End With
            '                                            .Refresh()
            '                                            .MoveLast()
            '                                            .MoveFirst()
            '                                            .Update()
            '                                        End If
            '                                    End With
            '                                    .cmdKill_Sol.Enabled = Not (CType(Auxiliar, BOStorage.Solicitud_Refs).Cancelado)
            '                                Else
            '                                    .cmdKill_Sol.Enabled = False
            '                                End If
            '                            Case Is = "CONSULTA"
            '                                .cmdProcesar.Enabled = False
            '                                .cmdKill_Sol.Enabled = False
            '                        End Select
            '                    End With                                
            '            End Select
            '        End If
            '    Next
            'Else
            '    str_NombreFormulario = Formulario.Name.ToString
            '    strNivelPermiso = "CONSULTA"
            'End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub Verifica_Recursos(ByVal Sujeto As SOLink.clUsuario, ByRef MdiMaestro As Form)
        Dim strTarget As String, _
            strNombre As String
        Try
            'Verificamos los menues a los que tiene acceso el usuario            
            With Sujeto
                If .Tipo_Acceso = "COMPLETO" Then
                    For Each Ren As DataRow In .Storage.Tables.Item(3).Rows
                        strNombre = Ren.Item(1).ToString
                        'Mnu_Access(CType(MdiMaestro, Main).mnuMenuStrip, strNombre)
                    Next
                End If
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub Mnu_Access(ByRef MnuMaster As MenuStrip, ByVal Nombre As String)
        Dim blnFound As Boolean
        Try
            For Each Hijo As ToolStripMenuItem In MnuMaster.Items
                'El codigo funciona bien, solo está comentado para avanzar mas rapido
                'If Hijo.Name = Nombre Then
                '    Hijo.Enabled = True
                '    blnFound = True
                'End If
                Hijo.Enabled = True
                If blnFound = False Then
                    If Hijo.DropDownItems.Count > 0 Then
                        SubMnuAcces(Hijo.DropDownItems, Nombre)
                    End If
                Else
                    Exit Sub
                End If
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub SubMnuAcces(ByRef colOpcionesMenu As ToolStripItemCollection, ByVal Nombre As String)
        Dim blnFound As Boolean
        Try
            For Each itmOpcion As ToolStripItem In colOpcionesMenu
                If TypeName(itmOpcion) <> "ToolStripSeparator" Then
                    ' si es una opción de menú normal... 
                    'If itmOpcion.Name = Nombre Then
                    itmOpcion.Enabled = True
                    '    blnFound = True
                    'End If
                    If blnFound = False Then
                        If DirectCast(itmOpcion, ToolStripMenuItem).DropDownItems.Count > 0 Then
                            SubMnuAcces(DirectCast(itmOpcion, ToolStripMenuItem).DropDownItems, Nombre)
                        End If
                    Else
                        Exit Sub
                    End If
                End If
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
#End Region

End Module
