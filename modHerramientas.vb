Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Drawing.Printing
Imports System.Drawing
Imports Microsoft.Win32
Imports System
Imports System.IO
Imports System.Threading
Imports System.Diagnostics

Module modHerramientas
#Region "Variables y constantes"
    Public Clip_Board As String
    Public objForma As Form
    Public Const CABECERA_ERROR As String = "Se ha presentado un error"
    Public objReport As CrystalDecisions.CrystalReports.Engine.ReportDocument
    'Public objFormaReporteador As frmMainReporter
    Public objFormaReporteador As frmReporter
    Private OptPrnPage As New PageSettings
    Private StrToPrn As String
    Private LlaveRegistro As RegistryKey
    Private NivelAcceso As System.Security.Permissions.RegistryPermissionAccess
    Private SecurityCard As System.Security.Permissions.RegistryPermission
    Private prnTxt As PrintDocument
    Private strPrintName As String
    Private strNombreFuente As String
    Private FontPrn As Font
    Private strPathReport As String
    Private strRegReadUsuario As String
    Private strRegReadPassword As String
    Private PathFinder As SOLink.clConectividad
    Private blnResultado As Boolean, dt_L_DataFiltrada As DataTable
    'Private obj_Ticket_Form As frmTicket
    Dim obj_L_Dato As DataRow, _
    int_L_IDX_Local As Int16
#End Region
#Region "Cargas"
    ''' <summary>
    ''' Carga las formas hijas, pero solo una vez
    ''' </summary>
    ''' <param name="Formulario">
    ''' Formulario MDIChild
    ''' </param>
    ''' <param name="ObjConsola">
    ''' Formulario MDIParent
    ''' </param>
    ''' <param name="Maximizar">
    ''' Falso / Verdadero para maximizar el formulario en la carga
    ''' </param>
    ''' <remarks></remarks>
    Public Sub CargarFormularioMDI_Child(ByRef Formulario As Form, _
                                         ByRef ObjConsola As Form, _
                                         Optional ByVal Maximizar As Boolean = False, _
                                         Optional ByRef Entidad As SOLink.clUsuario = Nothing, _
                                         Optional ByVal NoMDI As Boolean = False, _
                                         Optional ByVal Dialogo As Boolean = False)
        '--------------------------------
        'Proyecto   :SIL(Sistema de llantas)
        'Programó   :Israel Greß
        'Fecha      :06/Abril/2005
        '--------------------------------
        'Descripcion :Carga las formas hijas, pero solo una vez
        '-------------------------------- 
        '[Modificaciones:]
        Dim r As Int16, _
            blnFound As Boolean, _
            intIndexFound As Int16
        Try
            If Not (Entidad Is Nothing) Then
                Aplicar_Politicas(Entidad, Formulario)
            End If
            If ObjConsola.MdiChildren.Length > 0 Then
                For r = 0 To ObjConsola.MdiChildren.Length - 1
                    If ObjConsola.MdiChildren(r).Name.ToString = _
                        Formulario.Name.ToString Then
                        blnFound = True
                        intIndexFound = r
                        Exit For
                    Else
                        blnFound = False
                    End If
                Next
                If blnFound = False Then
                    'El objeto no esta cargado
                    With Formulario
                        If NoMDI = False Then
                            .MdiParent = ObjConsola
                        End If
                        If Dialogo Then
                            .ShowDialog()
                            Exit Sub
                        End If
                        If Maximizar = True Then
                            .StartPosition = FormStartPosition.CenterParent
                            .WindowState = FormWindowState.Maximized
                        Else
                            For r = 0 To ObjConsola.MdiChildren.Length - 1
                                ObjConsola.MdiChildren(r).WindowState = FormWindowState.Normal
                            Next
                            .StartPosition = FormStartPosition.CenterParent
                            .WindowState = FormWindowState.Normal
                        End If
                        .Show()
                    End With
                Else
                    'El objeto está cargado ,solo se envia al frente
                    With ObjConsola.MdiChildren(intIndexFound)
                        .WindowState = FormWindowState.Normal
                        .StartPosition = FormStartPosition.CenterParent
                        .BringToFront()
                    End With
                    Exit Sub
                End If
            Else
                With Formulario
                    .MdiParent = ObjConsola
                    If Maximizar = True Then
                        .WindowState = FormWindowState.Maximized
                        .StartPosition = FormStartPosition.CenterParent
                    Else
                        .WindowState = FormWindowState.Normal
                        .FormBorderStyle = FormBorderStyle.FixedSingle
                        .StartPosition = FormStartPosition.CenterScreen
                    End If
                    .Show()
                End With
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub Actualizar_Apariencia_Grid_Dinamico(ByRef Rejilla As C1.Win.C1TrueDBGrid.C1TrueDBGrid)
        Dim strCadena As String, _
                    strNombreColumna As String, _
                    intVerificador As Int16, _
                    intContador As Int16, _
                    intTotColumnas As Int16, _
                    intContAux As Int16, _
                    intCol As Int16, _
                    intBloquear As Int16, _
                    colNoVisibles As New Collection, _
                    colAlineacion_Der As New Collection, _
                    colAlineacion_Izq As New Collection, _
                    colCentrar As New Collection, _
                    colFormatoMoneda As New Collection, _
                    colCheckBoxes As New Collection, _
                    colAgrupar As New Collection, _
                    colBloquear As New Collection
        Try

            intTotColumnas = (CType(Rejilla.DataSource, DataTable).Columns.Count - 1)
            For intContador = 0 To intTotColumnas
                With CType(Rejilla.DataSource, DataTable).Columns(intContador)
                    strCadena = .ColumnName
                    strNombreColumna = strCadena
                    intBloquear = InStr(strCadena, DESBLOQUEAR, CompareMethod.Text)
                    If intBloquear = 0 Then
                        If (colBloquear Is Nothing) Then
                            colBloquear = New Collection
                        End If
                        colBloquear.Add(intContador)
                    Else
                        strCadena = Replace(strCadena, DESBLOQUEAR, "")
                    End If
                    intVerificador = 0
                    '---------------------------------------------------------------------
                    intVerificador = InStr(strCadena, FORM_NUMBER5, CompareMethod.Text)
                    If intVerificador > 0 Then
                        strCadena = Replace(strCadena, FORM_NUMBER5, "")
                    End If
                    intVerificador = 0
                    intVerificador = InStr(strCadena, FORM_NUMBER2, CompareMethod.Text)
                    If intVerificador > 0 Then
                        strCadena = Replace(strCadena, FORM_NUMBER2, "")
                    End If
                    '---------------------------------------------------------------------
                    intVerificador = InStr(strCadena, NO_VISIBLE, CompareMethod.Text)
                    If intVerificador > 0 Then
                        strCadena = Replace(strCadena, NO_VISIBLE, "")
                        If (colNoVisibles Is Nothing) Then
                            colNoVisibles = New Collection
                        End If
                        colNoVisibles.Add(intContador)
                    End If
                    intVerificador = 0
                    intVerificador = InStr(strCadena, CHECK_BOX, CompareMethod.Text)
                    If intVerificador > 0 Then
                        strCadena = Replace(strCadena, CHECK_BOX, "")
                        If (colCheckBoxes Is Nothing) Then
                            colCheckBoxes = New Collection
                        End If
                        colCheckBoxes.Add(intContador)
                    End If
                    intVerificador = 0
                    intVerificador = InStr(strCadena, AGRUPACELDAS, CompareMethod.Text)
                    If intVerificador > 0 Then
                        strCadena = Replace(strCadena, AGRUPACELDAS, "")
                        If (colAgrupar Is Nothing) Then
                            colAgrupar = New Collection
                        End If
                        colAgrupar.Add(intContador)
                    End If
                    intVerificador = 0
                    intVerificador = InStr(strCadena, ALINEACION_DE, CompareMethod.Text)
                    If intVerificador > 0 Then
                        strCadena = Replace(strCadena, ALINEACION_DE, "")
                        If (colAlineacion_Der Is Nothing) Then
                            colAlineacion_Der = New Collection
                        End If
                        colAlineacion_Der.Add(intContador)
                    End If
                    intVerificador = 0
                    intVerificador = InStr(strCadena, ALINEACION_IZ, CompareMethod.Text)
                    If intVerificador > 0 Then
                        strCadena = Replace(strCadena, ALINEACION_IZ, "")
                        If (colAlineacion_Izq Is Nothing) Then
                            colAlineacion_Izq = New Collection
                        End If
                        colAlineacion_Izq.Add(intContador)
                    End If
                    intVerificador = 0
                    intVerificador = InStr(strCadena, CENTRAR, CompareMethod.Text)
                    If intVerificador > 0 Then
                        strCadena = Replace(strCadena, CENTRAR, "")
                        If (colCentrar Is Nothing) Then
                            colCentrar = New Collection
                        End If
                        colCentrar.Add(intContador)
                    End If
                    .ColumnName = strCadena
                End With
            Next
            If Not (colBloquear Is Nothing) Then
                If colBloquear.Count > 0 Then
                    For intContAux = 1 To colBloquear.Count
                        intCol = CInt(colBloquear.Item(intContAux))
                        Rejilla.Splits(0).DisplayColumns(intCol).Locked = True
                    Next
                End If
            End If
            If Not (colNoVisibles Is Nothing) Then
                For intContAux = 1 To colNoVisibles.Count
                    intCol = CInt(colNoVisibles.Item(intContAux))
                    Rejilla.Splits(0).DisplayColumns(intCol).Visible = False
                Next
            End If
            If Not (colCheckBoxes Is Nothing) Then
                For intContAux = 1 To colCheckBoxes.Count
                    intCol = CInt(colCheckBoxes.Item(intContAux))
                    Rejilla.Columns(intCol).ValueItems.Presentation = CHECKBOX
                Next
            End If
            If Not (colAgrupar Is Nothing) Then
                For intContAux = 1 To colAgrupar.Count
                    intCol = CInt(colAgrupar.Item(intContAux))
                    Rejilla.Splits(0).DisplayColumns(intCol).Merge = True
                Next
            End If
            If Not (colAlineacion_Der Is Nothing) Then
                For intContAux = 1 To colAlineacion_Der.Count
                    intCol = CInt(colAlineacion_Der.Item(intContAux))
                    Rejilla.Splits(0).DisplayColumns(intCol).Style.HorizontalAlignment = DERECHA
                    Rejilla.Splits(0).DisplayColumns(intCol).AutoSize()
                Next
            End If
            If Not (colAlineacion_Izq Is Nothing) Then
                For intContAux = 1 To colAlineacion_Izq.Count
                    intCol = CInt(colAlineacion_Izq.Item(intContAux))
                    Rejilla.Splits(0).DisplayColumns(intCol).Style.HorizontalAlignment = IZQUIERDA
                    Rejilla.Splits(0).DisplayColumns(intCol).AutoSize()
                Next
            End If
            If Not (colCentrar Is Nothing) Then
                For intContAux = 1 To colCentrar.Count
                    intCol = CInt(colCentrar.Item(intContAux))
                    Rejilla.Splits(0).DisplayColumns(intCol).Style.HorizontalAlignment = CENTRO
                    Rejilla.Splits(0).DisplayColumns(intCol).AutoSize()
                Next
            End If
            'Permite un tamaño adecuado para las columnas
            '********************************************************************************
            For Each obj_L_ColTemp As C1.Win.C1TrueDBGrid.C1DataColumn In Rejilla.Columns
                If Rejilla.Splits(0).DisplayColumns.Item(obj_L_ColTemp).Visible Then
                    Rejilla.Splits(0).DisplayColumns.Item(obj_L_ColTemp).AutoSize()
                End If
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    ''' <summary>
    ''' Carga de forma dinamica un grid a partir de un datatable, crea la estructura
    ''' y llena los datos
    ''' </summary>
    ''' <param name="Rejilla">
    ''' Nombre del grid a llenar
    ''' </param>
    ''' <param name="Datos_Extraidos">
    ''' Datatable donde radican los datos
    ''' </param>
    ''' <remarks></remarks>
    Public Sub Grid_Dinamico(ByRef Rejilla As C1.Win.C1TrueDBGrid.C1TrueDBGrid, _
                             ByRef Datos_Extraidos As Data.DataTable, _
                             Optional ByVal Estilos_Columnas_Activos As Boolean = False, _
                             Optional ByVal Activar As Boolean = False)
        '--------------------------------
        'Proyecto   :SIL(Sistema de llantas)
        'Programó: Israel(Greß)
        'Fecha      :15/Abril/2005
        '--------------------------------
        'Descripcion :Llena de forma dinamica el grid,
        'modifica los nombres de las columnas  y su comportamiento
        'de acuerdo a su encabezado
        '-------------------------------- 
        '[Modificaciones:]
        'Notas:
        '_0v:    No(visible)
        '_D1:Alineacion a la derecha
        '_I1:Alineacion a la izquierda
        '_C1:    Centrar()
        '_F$:Formato de moneda
        '_F#5:Forma de números (###,###,##0.0000000) ¡A huevo que pude! desde la data, pero pude!
        '_F#2:Formato de números (###,###,##0.00)
        '--------------------------------------------------
        'Jorge A. Garcia Chong
        'adicion de checkboxes, merge's, bloqueo de columna
        Dim strCadena As String, _
                    strNombreColumna As String, _
                    intVerificador As Int16, _
                    intContador As Int16, _
                    intTotColumnas As Int16, _
                    intContAux As Int16, _
                    intCol As Int16, _
                    intBloquear As Int16, _
                    colNoVisibles As New Collection, _
                    colAlineacion_Der As New Collection, _
                    colAlineacion_Izq As New Collection, _
                    colCentrar As New Collection, _
                    colFormatoMoneda As New Collection, _
                    colCheckBoxes As New Collection, _
                    colAgrupar As New Collection, _
                    colBloquear As New Collection
        Try
            Reset_Grid(Rejilla)
            intTotColumnas = (Datos_Extraidos.Columns.Count - 1)
            For intContador = 0 To intTotColumnas
                With Datos_Extraidos.Columns(intContador)
                    strCadena = .ColumnName
                    strNombreColumna = strCadena
                    intBloquear = InStr(strCadena, DESBLOQUEAR, CompareMethod.Text)
                    If intBloquear = 0 Then
                        If (colBloquear Is Nothing) Then
                            colBloquear = New Collection
                        End If
                        colBloquear.Add(intContador)
                    Else
                        strCadena = Replace(strCadena, DESBLOQUEAR, "")
                    End If
                    intVerificador = 0
                    '---------------------------------------------------------------------
                    intVerificador = InStr(strCadena, FORM_NUMBER5, CompareMethod.Text)
                    If intVerificador > 0 Then
                        strCadena = Replace(strCadena, FORM_NUMBER5, "")
                    End If
                    intVerificador = 0
                    intVerificador = InStr(strCadena, FORM_NUMBER2, CompareMethod.Text)
                    If intVerificador > 0 Then
                        strCadena = Replace(strCadena, FORM_NUMBER2, "")
                    End If
                    '---------------------------------------------------------------------
                    intVerificador = InStr(strCadena, NO_VISIBLE, CompareMethod.Text)
                    If intVerificador > 0 Then
                        strCadena = Replace(strCadena, NO_VISIBLE, "")
                        If (colNoVisibles Is Nothing) Then
                            colNoVisibles = New Collection
                        End If
                        colNoVisibles.Add(intContador)
                    End If
                    intVerificador = 0
                    intVerificador = InStr(strCadena, CHECK_BOX, CompareMethod.Text)
                    If intVerificador > 0 Then
                        strCadena = Replace(strCadena, CHECK_BOX, "")
                        If (colCheckBoxes Is Nothing) Then
                            colCheckBoxes = New Collection
                        End If
                        colCheckBoxes.Add(intContador)
                    End If
                    intVerificador = 0
                    intVerificador = InStr(strCadena, AGRUPACELDAS, CompareMethod.Text)
                    If intVerificador > 0 Then
                        strCadena = Replace(strCadena, AGRUPACELDAS, "")
                        If (colAgrupar Is Nothing) Then
                            colAgrupar = New Collection
                        End If
                        colAgrupar.Add(intContador)
                    End If
                    intVerificador = 0
                    intVerificador = InStr(strCadena, ALINEACION_DE, CompareMethod.Text)
                    If intVerificador > 0 Then
                        strCadena = Replace(strCadena, ALINEACION_DE, "")
                        If (colAlineacion_Der Is Nothing) Then
                            colAlineacion_Der = New Collection
                        End If
                        colAlineacion_Der.Add(intContador)
                    End If
                    intVerificador = 0
                    intVerificador = InStr(strCadena, ALINEACION_IZ, CompareMethod.Text)
                    If intVerificador > 0 Then
                        strCadena = Replace(strCadena, ALINEACION_IZ, "")
                        If (colAlineacion_Izq Is Nothing) Then
                            colAlineacion_Izq = New Collection
                        End If
                        colAlineacion_Izq.Add(intContador)
                    End If
                    intVerificador = 0
                    intVerificador = InStr(strCadena, CENTRAR, CompareMethod.Text)
                    If intVerificador > 0 Then
                        strCadena = Replace(strCadena, CENTRAR, "")
                        If (colCentrar Is Nothing) Then
                            colCentrar = New Collection
                        End If
                        colCentrar.Add(intContador)
                    End If
                    .ColumnName = strCadena
                End With
            Next
            Rejilla.DataSource = Datos_Extraidos
            If Not (colBloquear Is Nothing) Then
                If colBloquear.Count > 0 Then
                    For intContAux = 1 To colBloquear.Count
                        intCol = CInt(colBloquear.Item(intContAux))
                        Rejilla.Splits(0).DisplayColumns(intCol).Locked = True
                    Next
                End If
            End If
            If Not (colNoVisibles Is Nothing) Then
                For intContAux = 1 To colNoVisibles.Count
                    intCol = CInt(colNoVisibles.Item(intContAux))
                    Rejilla.Splits(0).DisplayColumns(intCol).Visible = False
                Next
            End If
            If Not (colCheckBoxes Is Nothing) Then
                For intContAux = 1 To colCheckBoxes.Count
                    intCol = CInt(colCheckBoxes.Item(intContAux))
                    Rejilla.Columns(intCol).ValueItems.Presentation = CHECKBOX
                Next
            End If
            If Not (colAgrupar Is Nothing) Then
                For intContAux = 1 To colAgrupar.Count
                    intCol = CInt(colAgrupar.Item(intContAux))
                    Rejilla.Splits(0).DisplayColumns(intCol).Merge = True
                Next
            End If
            If Not (colAlineacion_Der Is Nothing) Then
                For intContAux = 1 To colAlineacion_Der.Count
                    intCol = CInt(colAlineacion_Der.Item(intContAux))
                    Rejilla.Splits(0).DisplayColumns(intCol).Style.HorizontalAlignment = DERECHA
                    Rejilla.Splits(0).DisplayColumns(intCol).AutoSize()
                Next
            End If
            If Not (colAlineacion_Izq Is Nothing) Then
                For intContAux = 1 To colAlineacion_Izq.Count
                    intCol = CInt(colAlineacion_Izq.Item(intContAux))
                    Rejilla.Splits(0).DisplayColumns(intCol).Style.HorizontalAlignment = IZQUIERDA
                    Rejilla.Splits(0).DisplayColumns(intCol).AutoSize()
                Next
            End If
            If Not (colCentrar Is Nothing) Then
                For intContAux = 1 To colCentrar.Count
                    intCol = CInt(colCentrar.Item(intContAux))
                    Rejilla.Splits(0).DisplayColumns(intCol).Style.HorizontalAlignment = CENTRO
                    Rejilla.Splits(0).DisplayColumns(intCol).AutoSize()
                Next
            End If

            'Permite un tamaño adecuado para las columnas
            '********************************************************************************
            For Each obj_L_ColTemp As C1.Win.C1TrueDBGrid.C1DataColumn In Rejilla.Columns
                If Rejilla.Splits(0).DisplayColumns.Item(obj_L_ColTemp).Visible Then
                    Rejilla.Splits(0).DisplayColumns.Item(obj_L_ColTemp).AutoSize()
                End If
            Next
            '********************************************************************************
            'Activamos el fetch si la funcion lo permite
            'Estilos_Columnas_Activos
            For Each obj_L_ColTemp As C1.Win.C1TrueDBGrid.C1DisplayColumn In Rejilla.Splits(0).DisplayColumns
                obj_L_ColTemp.FetchStyle = Estilos_Columnas_Activos
            Next
            'Permite agrupacion avanzada
            For Each obj_L_ColTemp As C1.Win.C1TrueDBGrid.C1DataColumn In Rejilla.Columns
                'Este metodo permite captar los eventos al agrupar columnas...
                'Lo desactivo por que aun no he podido dejar los textos de los
                'renglones agrupados como los quiero

                'Pinche Tdbgrid ojete, me ganaste una batalla pero no la guerra
                '********************************************************************
                'obj_L_ColTemp.Aggregate = C1.Win.C1TrueDBGrid.AggregateEnum.Custom
                '********************************************************************
            Next
            If Not (colFormatoMoneda Is Nothing) Then 'colFormatoMoneda
            End If
            If Activar Then Rejilla.Enabled = Activar
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    'Public Sub DropDown_Dinamico()
    '    Try

    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Sub
    ''' <summary>
    ''' La funcion carga un combo a partir de un datable
    ''' </summary>
    ''' <param name="C_Combo">
    ''' Nombre del combo a cargar
    ''' </param>
    ''' <param name="Datos">
    ''' Datatable a utilizar
    ''' </param>
    ''' <param name="intColValMember">
    ''' Valor real del combo (el que no se muestra)
    ''' </param>
    ''' <param name="intColDisplayMember">
    ''' Texto a mostrar en el combo para cada valor
    ''' </param>
    ''' <param name="blnOptAll">
    ''' Mostrar la opcion "Todos" (Opcional)
    ''' </param>
    ''' <param name="Activate">
    ''' Activar el combo después de la carga (Opcional)
    ''' </param>
    ''' <param name="Opcion_Adicionar">
    ''' Permite que el combo muestre la opcion "Adicionar"
    ''' </param>
    ''' <param name="Mostrar_Nada">
    ''' Indica si el combo deberá estar en blanco (sin texto) al final de la carga
    ''' </param>
    ''' <remarks></remarks>
    Public Sub CargaCombo(ByRef C_Combo As ComboBox, _
                          ByRef Datos As DataTable, _
                          ByVal intColValMember As Int16, _
                          ByVal intColDisplayMember As Int16, _
                          Optional ByVal blnOptAll As Boolean = False, _
                          Optional ByVal Activate As Boolean = False, _
                          Optional ByVal Opcion_Adicionar As Boolean = False, _
                          Optional ByVal strDescripcionFunc As String = Nothing, _
                          Optional ByVal Mostrar_Nada As Boolean = False)
        Dim blnFlag As Boolean, _
            intIndx As Int16, _
            intIndx2 As Int16, _
            intIndx3 As Int16, _
            int_Mov As Int16, _
            RenDatos As Data.DataRow
        blnFlag = False
        intIndx = -1
        Try
            If Not (Datos Is Nothing) Then
                If Not (strDescripcionFunc Is Nothing) Then
                    blnFlag = True
                    With Datos.Rows
                        intIndx = (.Count)
                        .Add()
                        '.Item(intIndx).Item(0) = " " + strDescripcionFunc 'en esta columna por lo regular almacenamos el oid
                        '.Item(intIndx).Item(1) = " " + strDescripcionFunc 'y en esta la descripcion
                        'Nota: adicionamos un espacio al frente, para que al ordenar la tabla, la "Descripcion" quede al principio
                        Do While intIndx > -1
                            If intIndx = 0 Then
                                .Item(0).Item(0) = strDescripcionFunc
                                .Item(0).Item(1) = strDescripcionFunc
                            Else
                                .Item(intIndx).Item(0) = .Item(intIndx - 1).Item(0)
                                .Item(intIndx).Item(1) = .Item(intIndx - 1).Item(1)
                            End If
                            intIndx = intIndx - 1
                        Loop
                        intIndx = 0
                    End With
                End If
                If blnOptAll = True Then
                    With Datos.Rows
                        RenDatos = Datos.NewRow
                        With RenDatos
                            .Item(intColValMember) = "TODOS"
                            .Item(intColDisplayMember) = "TODOS"
                        End With
                        Datos.Rows.Add(RenDatos)
                        'Datos.Rows.InsertAt(RenDatos, 0) Adiciona el renglón en la posición 1
                        'intIndx2 = (.Count)
                        '.Add()
                        '.Item(intIndx2).Item(0) = "TODOS" 'en esta columna por lo regular almacenamos el oid
                        '.Item(intIndx2).Item(1) = "TODOS" 'y en esta la descripcion
                    End With
                End If
                If Opcion_Adicionar Then
                    With Datos.Rows
                        intIndx3 = (.Count)
                        .Add()
                        .Item(intIndx3).Item(0) = "Adicionar..." 'en esta columna por lo regular almacenamos el oid
                        .Item(intIndx3).Item(1) = "VOID" 'y en esta la descripcion
                    End With
                End If
                With C_Combo
                    .DataSource = Nothing
                    .DataSource = Datos.Copy
                    .ValueMember = Datos.Columns(intColValMember).ToString
                    .DisplayMember = Datos.Columns(intColDisplayMember).ToString
                    If Mostrar_Nada Then
                        .SelectedIndex = -1
                    End If
                    If .DropDownStyle.ToString <> "DropDownList" And .DropDownStyle.ToString <> "Simple" Then
                        .AutoCompleteMode = AutoCompleteMode.Suggest
                        .AutoCompleteSource = AutoCompleteSource.ListItems
                    End If
                    If Datos.Rows.Count > 0 Then
                        .Enabled = Activate
                        If .Enabled = True Then
                            .Focus()
                        End If
                    Else
                        .Enabled = False
                    End If
                End With
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    ''' <summary>
    ''' Carga un combo a partir de un arraylist
    ''' </summary>
    ''' <param name="UI_Combo">
    ''' Combo a llenar
    ''' </param>
    ''' <param name="Arreglo">
    ''' Array list que tiene los valores
    ''' </param>
    ''' <param name="Todos">
    ''' Adicionar la opcion "Todos" al combo
    ''' </param>
    ''' <param name="Activar">
    ''' Activar el combo después de la carga
    ''' </param>
    ''' <remarks></remarks>
    Public Sub CargaCombo(ByRef UI_Combo As Windows.Forms.ComboBox, _
                          ByRef Arreglo As ArrayList, _
                          Optional ByVal Todos As Boolean = False, _
                          Optional ByVal Activar As Boolean = False)
        Try
            With UI_Combo
                .DataSource = Nothing
                .Items.Clear()
                .Text = ""
                .Enabled = Activar
                .DataSource = Arreglo
                .ValueMember = "Valor"
                .DisplayMember = "Vista"
                .SelectedIndex = 0
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    ''' <summary>
    ''' Carga el treeview indicado
    ''' </summary>
    ''' <param name="Arbol"></param>
    ''' <param name="Datos"></param>
    ''' <param name="NombrePadre"></param>
    ''' <param name="ListaImagenes"></param>
    ''' <remarks></remarks>
    Public Sub Cargar_Arbol(ByRef Arbol As Windows.Forms.TreeView, _
                            ByVal Datos As DataTable, _
                            ByVal NombrePadre As String, _
                            ByRef ListaImagenes As Windows.Forms.ImageList, _
                            ByVal intIndexImagen As Int16)
        Dim int_L_Rows As Int16, _
            int_L_Cols As Int16, _
            int_L_Limite As Int16, _
            str_L_Valor As String, _
            str_L_Texto As String
        Try
            int_L_Rows = (Datos.Rows.Count - 1)
            int_L_Cols = (Datos.Columns.Count - 1)
            With Arbol
                .ImageList = ListaImagenes
                .BeginUpdate()
                .Nodes.Clear()
                .Nodes.Add(NombrePadre, NombrePadre, intIndexImagen)
                For int_L_Limite = 0 To int_L_Rows
                    str_L_Valor = Datos.Rows.Item(int_L_Limite).Item(0).ToString
                    str_L_Texto = Datos.Rows.Item(int_L_Limite).Item(1).ToString
                    .Nodes.Item(0).Nodes.Add(str_L_Valor, str_L_Texto, intIndexImagen, intIndexImagen)
                Next
                .ExpandAll()
                .EndUpdate()
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    ''' <summary>
    ''' Carga los datos obtenidos en los ValueItems de una columna
    ''' </summary>
    ''' <param name="Datos">
    ''' Datatable donde residen los datos
    ''' </param>
    ''' <param name="Columna">
    ''' Columna donde se almacenaran los ValueItems
    ''' </param>
    ''' <param name="intColDisplay">
    ''' Indice de la columna de la tabla donde están los datos para mostrar
    ''' </param>
    ''' <param name="intColValue">
    ''' Indice de la columna de la tabla donde están los datos que se utilizaran para los registros
    ''' </param>
    ''' <param name="Presentacion">
    ''' Tipo de presentacion (Combo, RadioButton etc)
    ''' </param>
    ''' <remarks>
    ''' Nada adicional
    ''' </remarks>
    Public Sub Carga_Value_Items(ByRef Datos As DataTable, _
                                ByRef Columna As C1.Win.C1TrueDBGrid.C1DataColumn, _
                                ByVal intColDisplay As Int16, _
                                ByVal intColValue As Int16, _
                                ByVal Presentacion As C1.Win.C1TrueDBGrid.PresentationEnum)
        Dim obj_L_ValItem As C1.Win.C1TrueDBGrid.ValueItem
        Try
            For int_L_Ren As Int16 = 0 To Datos.Rows.Count - 1
                'Construyendo el ValueItem
                obj_L_ValItem = New C1.Win.C1TrueDBGrid.ValueItem
                With obj_L_ValItem
                    .Value = Datos.Rows(int_L_Ren).Item(intColValue).ToString
                    .DisplayValue = Datos.Rows(int_L_Ren).Item(intColDisplay).ToString
                End With
                'Adicionando y destruyendo el ValueItem
                Columna.ValueItems.Values.Add(obj_L_ValItem)
                obj_L_ValItem = Nothing
            Next
            With Columna.ValueItems
                .Presentation = Presentacion
                .Translate = True
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    ''' <summary>
    ''' Carga una lista check a partir de una datatable
    ''' </summary>
    ''' <param name="Lista">
    ''' Lista a cargar
    ''' </param>
    ''' <param name="Datos">
    ''' Datatable fuente de datos
    ''' </param>
    ''' <param name="OpcionTodos">
    ''' Indica si la lista contendrá la opcion "Todos"
    ''' </param>
    ''' <remarks></remarks>
    Public Sub Cargar_ChkList(ByRef Lista As System.Windows.Forms.CheckedListBox, _
                              ByRef Datos As System.Data.DataTable, _
                              Optional ByVal OpcionTodos As Boolean = False)
        Try
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    ''' <summary>
    ''' Limpia los elementos seleccionados de un checklist
    ''' </summary>
    ''' <param name="Lista">
    ''' Lista check objetivo
    ''' </param>
    ''' <remarks></remarks>
    Public Sub Remove_Checked(ByRef Lista As System.Windows.Forms.CheckedListBox, _
                              Optional ByRef Avanzado As Boolean = False, _
                              Optional ByRef Valor_Target As String = Nothing)
        Dim x As Int16
        Try
            Do While Lista.CheckedIndices.Count > 0
                x = Lista.CheckedIndices.Item(0)
                Lista.SetItemCheckState(x, CheckState.Unchecked)
                Lista.SelectedIndices.Clear()
            Loop
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub InicializaCbo_Unidad(ByRef C_Combo As ComboBox)
        Try
            If g_dt_Unidades Is Nothing Then
                g_dt_Unidades = New System.Data.DataTable
                With g_dt_Unidades
                    .Columns.Add("Tipo")
                    .Columns.Add("Descripcion")
                    .Rows.Add()
                    .Rows.Add()
                    .Rows.Item(0).Item(0) = "TRACTOR"
                    .Rows.Item(0).Item(1) = "TRACTOR"
                    .Rows.Item(1).Item(0) = "REMOLQUE"
                    .Rows.Item(1).Item(1) = "REMOLQUE"
                End With
                With C_Combo
                    .DataSource = Nothing
                    .DataSource = g_dt_Unidades
                    .ValueMember = g_dt_Unidades.Columns(0).ToString
                    .DisplayMember = g_dt_Unidades.Columns(1).ToString
                End With
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub InicializaCboStats_Items()
        Try
            dtStats_Partidas = Nothing
            dtStats_Partidas = New System.Data.DataTable
            With dtStats_Partidas
                .Columns.Add("Valor")
                .Columns.Add("Descripcion")
                For intVar_Entera = 1 To 3
                    .Rows.Add()
                Next intVar_Entera
                'Carga de valores a los renglones

            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    ''' <summary>
    ''' Adiciona valueItems con valores True y False a la columna
    ''' de un grid determinado
    ''' </summary>
    ''' <param name="Columna">
    ''' Columna perteneciente al grid donde estaran los ValueItems
    ''' </param>
    ''' <remarks></remarks>
    Public Sub Value_Items_Si_No(ByRef Columna As C1.Win.C1TrueDBGrid.C1DataColumn)
        Dim obj_L_ValItem As C1.Win.C1TrueDBGrid.ValueItem
        Try
            obj_L_ValItem = Nothing
            obj_L_ValItem = New C1.Win.C1TrueDBGrid.ValueItem
            With obj_L_ValItem
                .Value = "-1"
                .DisplayValue = "Si"
            End With
            Columna.ValueItems.Values.Add(obj_L_ValItem)
            obj_L_ValItem = Nothing
            obj_L_ValItem = New C1.Win.C1TrueDBGrid.ValueItem
            With obj_L_ValItem
                .Value = "0"
                .DisplayValue = "No"
            End With
            Columna.ValueItems.Values.Add(obj_L_ValItem)
            With Columna.ValueItems
                .Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.ComboBox
                .Translate = True
                .CycleOnClick = True
                .DefaultItem = 1
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    ''' <summary>
    ''' Carga un listview a partir de un datatable
    ''' </summary>
    ''' <param name="VisorLista">
    ''' Nombre de control listView
    ''' </param>
    ''' <param name="Data">
    ''' DataTable con los datos que se van a anexar, asegurese que la tabla no esta vacia
    ''' </param>
    ''' <param name="IdColum">
    ''' Numero de la columna que contiene el identificador (Columna Oculta)
    ''' </param>
    ''' <param name="DataCol">
    ''' Numero de la columna que contiene la descripcion (Columna visible)
    ''' </param>
    ''' <param name="TipoVista">
    ''' tipo de vista en la que deseas presentar el ListView
    ''' </param>
    ''' <param name="ListaImagenes">
    ''' Si desea imagenes cargue un ImageList con la coleccion de imagenes (si se omite llena el list sin imagenes)
    ''' </param>
    ''' <param name="ImageIndex">
    ''' Numero de imagen que desea mostrar (sin el paso anterior este no es necesario)
    ''' </param>
    ''' <remarks></remarks>
    Public Sub Carga_ListView(ByRef VisorLista As System.Windows.Forms.ListView, _
                              ByVal Data As System.Data.DataTable, _
                              ByVal IdColum As Integer, _
                              ByVal DataCol As Integer, _
                              ByVal TipoVista As System.Windows.Forms.View, _
                              Optional ByRef ListaImagenes As System.Windows.Forms.ImageList = Nothing, _
                              Optional ByVal ImageIndex As Integer = -1)
        Dim int_Busca_Items As Integer
        Try
            With VisorLista
                .Clear()
                .View = TipoVista
                If Not (ListaImagenes Is Nothing) Then
                    .LargeImageList = ListaImagenes
                    .StateImageList = ListaImagenes
                    .SmallImageList = ListaImagenes
                    For int_Busca_Items = 0 To Data.Rows.Count - 1
                        .Items.Add(Data.Rows(int_Busca_Items).Item(IdColum).ToString, _
                                   Data.Rows(int_Busca_Items).Item(DataCol).ToString, _
                                   ListaImagenes.Images.Keys(ImageIndex).ToString)
                        .Items(int_Busca_Items).Tag = Data.Rows(int_Busca_Items).Item(IdColum).ToString
                    Next
                Else
                    For int_Busca_Items = 0 To Data.Rows.Count - 1
                        .Items.Add(Data.Rows(int_Busca_Items).Item(DataCol).ToString)
                        .Items(int_Busca_Items).Tag = Data.Rows(int_Busca_Items).Item(IdColum).ToString
                    Next
                End If
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    ''' <summary>
    ''' Limpia la data contenida dentro del combo y lo reinicia,
    ''' dejándolo listo para uso inmediato
    ''' </summary>
    ''' <param name="C_Combo">
    ''' Control combo a reinicializar
    ''' </param>
    ''' <param name="Desactivar">
    ''' Activar/desactivar el combo posteriormente a su reinicio
    ''' </param>
    ''' <param name="Texto_Nuevo">
    ''' Si se desea poner algun texto al terminar el reset del combo
    ''' </param>
    ''' <remarks></remarks>
    Public Sub LimpiarCombo(ByRef C_Combo As ComboBox, _
                            Optional ByVal Desactivar As Boolean = False, _
                            Optional ByVal Texto_Nuevo As String = Nothing)
        Try
            With C_Combo
                .DataSource = Nothing
                .Items.Clear()
                If Texto_Nuevo = Nothing Then
                    .Text = ""
                Else
                    .Text = Texto_Nuevo
                End If
                If Desactivar Then
                    .Enabled = False
                Else
                    .Enabled = True
                End If
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    ''' <summary>
    ''' Construye un TreeView a partir de las filas de un DataTable. 
    ''' Usa las columnas como nivel de profundidad y las filas como ramificaciones
    ''' (no almacena ids)
    ''' </summary>
    ''' <param name="ControlTreeView">
    ''' Nombre del control Treview destino 
    ''' </param>
    ''' <param name="dt">
    ''' Nombre del objeto DataTable que contiene los datos que se desean ramificar
    ''' </param>
    ''' <param name="ImageList">
    ''' Nombre del objeto opcional ImageList que contenga las imagenes que se van a reflejar
    ''' </param>
    ''' <param name="intImageIndexDad">
    ''' Indice opcional de la imagen para los nodos padre contenida en el ImageList
    ''' </param>
    ''' <param name="intImageIndexChild">
    ''' Indice opcional de la imagen para los nodos hijo contenida en el ImageList
    ''' </param>
    ''' <remarks></remarks>
    Public Sub BuildTreeView(ByRef ControlTreeView As System.Windows.Forms.TreeView, _
                             ByRef dt As DataTable, _
                             Optional ByRef ImageList As System.Windows.Forms.ImageList = Nothing, _
                             Optional ByVal intImageIndexDad As Integer = 0, _
                             Optional ByVal intImageIndexChild As Integer = 0)
        Dim intRow As Integer
        Dim xcol As Integer
        Dim xFila As Integer
        Dim dr As DataRow
        Dim blnExiste As Boolean
        Dim mNodo As New TreeNode
        Try
            'Prepara la carga del árbol
            ControlTreeView.BeginUpdate()
            ControlTreeView.Nodes.Clear()
            'Extraer una fila del datatable y colocarlas cada una en un datatable
            For intRow = 0 To dt.Rows.Count - 1
                Dim dtExtractRow As New DataTable
                For xcol = 0 To dt.Columns.Count - 1
                    dtExtractRow.Columns.Add(New DataColumn(dt.Columns(xcol).ToString, GetType(String)))
                Next
                dr = dtExtractRow.NewRow()
                For xFila = 0 To dt.Columns.Count - 1
                    dr(dtExtractRow.Columns(xFila).Caption) = dt.Rows(intRow).Item(xFila).ToString
                Next
                dtExtractRow.Rows.Add(dr)
                'Validacion de existencia del padre
                blnExiste = False
                For Each nodo As TreeNode In ControlTreeView.Nodes
                    If nodo.Text = dtExtractRow.Rows(0).Item(0).ToString Then
                        blnExiste = True
                        Exit For
                    Else
                        blnExiste = False
                    End If
                Next
                If blnExiste = False Then
                    'Agregando nodo padre y llamar a la funcion recursiva para agregar los hijos
                    If Not (ImageList Is Nothing) Then
                        ControlTreeView.ImageList = ImageList
                        mNodo = ControlTreeView.Nodes.Add(dtExtractRow.Rows(0).Item(0).ToString, dtExtractRow.Rows(0).Item(0).ToString, intImageIndexDad)
                    Else
                        mNodo = ControlTreeView.Nodes.Add(dtExtractRow.Rows(0).Item(0).ToString, dtExtractRow.Rows(0).Item(0).ToString)
                    End If
                    mNodo.Tag = dtExtractRow.Rows(0).Item(0).ToString
                    dtExtractRow.Columns.Remove(dtExtractRow.Columns(0).Caption.ToString)
                    If Not (ImageList Is Nothing) Then
                        CargarNodosHijos(mNodo, dtExtractRow, ImageList, intImageIndexChild)
                    Else
                        CargarNodosHijos(mNodo, dtExtractRow)
                    End If
                Else
                    'Obtener nodo padre y llamar a la funcion recursiva para agregar los hijos
                    mNodo = Nothing
                    mNodo = ControlTreeView.Nodes.Item(dtExtractRow.Rows(0).Item(0).ToString)
                    dtExtractRow.Columns.Remove(dtExtractRow.Columns(0).Caption.ToString)
                    If Not (ImageList Is Nothing) Then
                        CargarNodosHijos(mNodo, dtExtractRow, ImageList, intImageIndexChild)
                    Else
                        CargarNodosHijos(mNodo, dtExtractRow)
                    End If
                End If
                dtExtractRow = Nothing
            Next
            'Finaliza la carga del árbol
            ControlTreeView.EndUpdate()
            ControlTreeView.ExpandAll()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    ''' <summary>
    ''' Complemento para rellenar nodos hijos recursiva
    ''' </summary>
    ''' <param name="NodoPadre">
    ''' Nodo raiz o nodo hijo que será tomado como raiz para un nodo hijo nuevo
    ''' </param>
    ''' <param name="dt">
    ''' Tabla que contiene una fila de la data original con los valores a crear como nodos
    ''' </param>
    ''' <param name="ImageList">
    ''' 
    ''' </param>
    ''' <param name="intImageIndexChild"></param>
    ''' <remarks></remarks>
    Private Sub CargarNodosHijos(ByRef NodoPadre As TreeNode, _
                                 ByRef dt As DataTable, _
                                 Optional ByRef ImageList As System.Windows.Forms.ImageList = Nothing, _
                                 Optional ByVal intImageIndexChild As Integer = 0)
        'Obtiene los nodos dependientes de NodoPadre
        Dim mNodo As New TreeNode
        Dim blnExiste As Boolean
        Try
            'Validacion de existencia de un subpadre
            blnExiste = False
            For Each nodo As TreeNode In NodoPadre.Nodes
                If nodo.Text = dt.Rows(0).Item(0).ToString Then
                    blnExiste = True
                    Exit For
                Else
                    blnExiste = False
                End If
            Next
            If blnExiste = False Then
                'Agregando nodo subpadre y llamar a la funcion recursiva para agregar los hijos
                If Not (ImageList Is Nothing) Then
                    mNodo = NodoPadre.Nodes.Add(dt.Rows(0).Item(0).ToString, dt.Rows(0).Item(0).ToString, intImageIndexChild)
                Else
                    mNodo = NodoPadre.Nodes.Add(dt.Rows(0).Item(0).ToString, dt.Rows(0).Item(0).ToString)
                End If
                mNodo.Tag = dt.Rows(0).Item(0).ToString
                dt.Columns.Remove(dt.Columns(0).Caption.ToString)
            Else
                'Obtener nodo padre y llamar a la funcion recursiva para agregar los hijos
                mNodo = Nothing
                mNodo = NodoPadre.Nodes.Item(dt.Rows(0).Item(0).ToString)
                dt.Columns.Remove(dt.Columns(0).Caption.ToString)
            End If
            'Recurrir a esta misma funcion para los sub nodos 
            Do While dt.Columns.Count <> 0
                If Not (ImageList Is Nothing) Then
                    CargarNodosHijos(mNodo, dt, ImageList, intImageIndexChild)
                Else
                    CargarNodosHijos(mNodo, dt)
                End If
            Loop
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub ConstruyeObjeto(ByRef Parrilla As C1.Win.C1TrueDBGrid.C1TrueDBGrid)
        Try

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
#End Region
#Region "Varios"
#Region "Funciones"
    ''' <summary>
    ''' Devuelve la primera direccion MAC que encuentra
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetMacAdd() As String
        Dim Macadd As String = ""
        Dim MACaddFormat As String = ""
        Macadd = System.Net.NetworkInformation.NetworkInterface.GetAllNetworkInterfaces(0).GetPhysicalAddress.ToString()
        For x As Int16 = 0 To Macadd.Length - 2 Step 2
            MACaddFormat = MACaddFormat & "-" & Macadd.Substring(x, 2)
        Next
        Return MACaddFormat.Remove(0, 1)
    End Function
    ''' <summary>
    ''' Esta función determina la posicion del registro seleccionado en un grid en su 
    ''' fuente de datos, si un C1TrueDbGrid es agrupado o filtrado, la propiedad RowBookMark
    ''' NO devuelve la posicion real, por lo cual deberemos obtenerla con esta funcion
    ''' </summary>
    ''' <param name="Cadena_Busqueda">
    ''' Valor que utilizamos para la búsqueda, de preferencia un uniqueidentifier que sea unico (parece tonto, pero si utilizamos una foreing key estaremos en problemas)
    ''' </param>
    ''' <param name="Fuente_Datos_Grid">
    ''' Datatable que sirve como fuente de datos al C1TrueDbGrid
    ''' </param>
    ''' <returns></returns>
    ''' Regresa un entero mayor a cero en caso de encontrarlo, de lo contrario devuelve -1
    ''' <remarks>
    ''' Esta función esta basada en que la tabla tiene una primary key y sobre ella se hará la busqueda
    ''' </remarks>
    Public Function Determinar_Renglon(ByVal Cadena_Busqueda As String, ByVal Fuente_Datos_Grid As DataTable) As Integer
        Try
            'En el módulo de variables está declarada foundRow y 
            'la utilizamos para obtener un datarow a partir de la
            'datatable, buscando en en campo el valor que obtuvimos del 
            'grid
            If Not (Fuente_Datos_Grid) Is Nothing Then
                foundRow = Fuente_Datos_Grid.Rows.Find(Cadena_Busqueda)
                'Una vez que obtenemos el DataRow, buscamos su índice dentro de la tabla
                intIndexRenglon = Fuente_Datos_Grid.Rows.IndexOf(foundRow)
                'Y está listo, regresamos el valor encontrado
                Return intIndexRenglon
            Else
                Return -1
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Function
    ''' <summary>
    ''' Esta función encuentra la primera incidencia en una columna indicada
    ''' posteriormente determina el identificador en la columna cero, utiliza la función
    ''' "Determinar_Renglon" y devuelve la posición en la tabla
    ''' </summary>
    ''' <param name="Cadena_Busqueda">
    ''' Cadena a buscar
    ''' </param>
    ''' <param name="Fuente_Datos_Grid">
    ''' Datatable en donde se buscará
    ''' </param>
    ''' <param name="Columna_Busqueda">
    ''' Columna en la que se llevará a cabo la busqueda
    ''' </param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Rastrear_Record(ByVal Cadena_Busqueda As String, _
                                      ByRef Fuente_Datos_Grid As DataTable, _
                                      ByVal Columna_Busqueda As Integer) As Integer
        Dim dr_L_DataRow_Tracker As DataRow, _
            str_L_Identificador_Maestro As String, _
            int_L_Number_Holder As Integer
        Try
            int_L_Number_Holder = -1
            If Not (Fuente_Datos_Grid Is Nothing) Then
                With Fuente_Datos_Grid
                    If .Rows.Count > 0 Then
                        For Each dr_L_DataRow_Tracker In .Rows
                            If Cadena_Busqueda = dr_L_DataRow_Tracker.Item(Columna_Busqueda).ToString Then
                                'Siempre se asume que el identificador de cada renglon 
                                'radica en la columna CERO, de hecho, todas las cargas de data
                                'estan pensadas de esa manera
                                str_L_Identificador_Maestro = dr_L_DataRow_Tracker.Item(0).ToString
                                int_L_Number_Holder = Determinar_Renglon(str_L_Identificador_Maestro, Fuente_Datos_Grid)
                                Return int_L_Number_Holder
                                Exit For
                            End If
                        Next
                    Else
                        int_L_Number_Holder = -1
                    End If
                End With
            Else
                int_L_Number_Holder = 0
            End If
            Return int_L_Number_Holder
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function ProcesaCadena(ByVal Cadena As String, Optional ByVal Mayusculas As Boolean = False) As String
        Dim CadenaObjetivo As String
        '--------------------------------
        'Proyecto   :SIL(Sistema de llantas)
        'Programó   :Israel Greß
        'Fecha      :08/Abril/2005
        '--------------------------------
        'Descripcion :Limpia la cadena de caracteres de caracteres ilegales
        '-------------------------------- 
        '[Modificaciones:]
        Try
            CadenaObjetivo = Replace(Cadena, "°", "", 1, , CompareMethod.Text)
            CadenaObjetivo = Replace(Cadena, "=", "", 1, , CompareMethod.Text)
            CadenaObjetivo = Replace(Cadena, "¡", "", 1, , CompareMethod.Text)
            CadenaObjetivo = Replace(Cadena, "!", "", 1, , CompareMethod.Text)
            CadenaObjetivo = Replace(Cadena, "¿", "", 1, , CompareMethod.Text)
            CadenaObjetivo = Replace(Cadena, "?", "", 1, , CompareMethod.Text)
            CadenaObjetivo = Replace(Cadena, "'", "", 1, , CompareMethod.Text)
            CadenaObjetivo = Replace(CadenaObjetivo, "", "", 1, , CompareMethod.Text)
            CadenaObjetivo = Replace(CadenaObjetivo, Chr(10), "", , , CompareMethod.Text)
            CadenaObjetivo = Replace(CadenaObjetivo, Chr(13), "", , , CompareMethod.Text)
            CadenaObjetivo = Replace(CadenaObjetivo, Chr(9), "", , , CompareMethod.Text)
            CadenaObjetivo = Replace(CadenaObjetivo, Chr(34), "", , , CompareMethod.Text)
            CadenaObjetivo = Replace(CadenaObjetivo, "|", "", 1, , CompareMethod.Text)
            CadenaObjetivo = UCase(CadenaObjetivo)
            CadenaObjetivo = LTrim(RTrim(CadenaObjetivo))
            If Len(CadenaObjetivo) = 0 Then
                CadenaObjetivo = vbNullString
            End If
            If RTrim(LTrim(CadenaObjetivo)) <> vbNullString Then
                If Mayusculas Then
                    CadenaObjetivo = UCase(CadenaObjetivo)
                End If
                Return CadenaObjetivo
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function Clean_Chain(ByVal strData As String, Optional ByRef blnUpper As Boolean = Nothing) As String
        Try
            strData = Trim(RTrim(LTrim(strData)))
            strData = Replace(strData, "'", "")
            strData = Replace(strData, "|", "")
            strData = Replace(strData, "°", "")
            If blnUpper = True Then
                strData = UCase(strData)
            End If
            Return strData
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function Valid_Key(ByRef objTecla As Integer) As Boolean
        Select Case objTecla
            Case 96 To 105
                Return True
            Case Is = 190
                Return True
            Case Else
                Return False
        End Select
    End Function
    ''' <summary>
    ''' Determina si un cuadro de texto puede aceptar números unicamente
    ''' tomando en cuenta que un combo box indica un determinador valor.
    ''' Por ejemplo: si el combo indica el valor "TRACTOR" el cuadro de texto
    ''' sólo podrá recibir numeros, a diferencia de un valor "REMOLQUE" que 
    ''' permite recibir caracteres alfanumericos
    ''' </summary>
    ''' <param name="Lista">
    ''' Combo  mandante
    ''' </param>
    ''' <param name="Letra">
    ''' el valor Key ingresadi
    ''' </param>
    ''' <returns>
    ''' Devuelve verdadero o falso para asignarlo al Handled
    ''' </returns>
    ''' <remarks></remarks>
    Public Function Validar_Entrada_Combo_Mandante(ByRef Lista As ComboBox, ByRef Letra As KeyPressEventArgs) As Boolean
        Dim str_L_Val_Combo As String, _
            sht_L_KeyAscii As Short
        Try
            If Asc(Letra.KeyChar) = 13 Then
                Return False
            Else
                If Not (Lista.SelectedValue Is Nothing) Then
                    str_L_Val_Combo = Lista.SelectedValue
                    If str_L_Val_Combo = "REMOLQUE" Then
                        Return False
                    Else
                        sht_L_KeyAscii = CShort(Asc(Letra.KeyChar))
                        Return (SoloNumeros(sht_L_KeyAscii) = 0)
                    End If
                Else
                    Return False
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function Remueve_No_Imprimibles(ByRef Cadena As String) As String
        Dim int_L_Contador As Integer, _
            str_L_Cadena_Procesada As String
        Try
            str_L_Cadena_Procesada = Cadena
            For int_L_Contador = 0 To 31
                str_L_Cadena_Procesada = Replace(str_L_Cadena_Procesada, Chr(int_L_Contador), "")
            Next
            str_L_Cadena_Procesada = LTrim(RTrim(Trim(str_L_Cadena_Procesada)))
            Return str_L_Cadena_Procesada
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    ''' <summary>
    ''' Funcion que determina si el caracter ingresado es un numero
    ''' </summary>
    ''' <param name="Keyascii">
    ''' Valor Keyascii a evaluar
    ''' </param>
    ''' <returns>
    ''' Devuelve un entero o cero
    ''' </returns>
    ''' <remarks></remarks>
    Public Function SoloNumeros(ByVal Keyascii As Short) As Short
        Try
            If InStr("1234567890", Chr(Keyascii)) = 0 Then
                SoloNumeros = 0
            Else
                SoloNumeros = Keyascii
            End If
            Select Case Keyascii
                Case 8
                    SoloNumeros = Keyascii
                Case 13
                    SoloNumeros = Keyascii
                Case 46
                    SoloNumeros = Keyascii
            End Select
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Function SoloLETRAS(ByVal KeyAscii As Integer, Optional ByVal Minusculas As Boolean = False) As Integer
        If Minusculas = True Then
            KeyAscii = Asc(LCase(Chr(KeyAscii)))
        Else
            KeyAscii = Asc(UCase(Chr(KeyAscii)))
        End If

        If Minusculas = True Then
            If InStr("abcdefghijklmnñopqrstuvwxyz", Chr(KeyAscii)) = 0 Then
                SoloLETRAS = 0
            Else
                SoloLETRAS = KeyAscii
            End If
        Else
            If InStr("ABCDEFGHIJKLMNÑOPQRSTUVWXYZ", Chr(KeyAscii)) = 0 Then
                SoloLETRAS = 0
            Else
                SoloLETRAS = KeyAscii
            End If
        End If
        If KeyAscii = 8 Then SoloLETRAS = KeyAscii
        If KeyAscii = 13 Then SoloLETRAS = KeyAscii
        If KeyAscii = 32 Then SoloLETRAS = KeyAscii
    End Function
    Function SoloCarateresLegales(ByVal KeyAscii As Integer) As Integer
        If InStr("ABCDEFGHIJKLMNÑOPQRSTUVWXYZabcdefghijklmnopqrstuwvxyz1234567890-/", Chr(KeyAscii)) = 0 Then
            SoloCarateresLegales = 0
        Else
            SoloCarateresLegales = KeyAscii
        End If
        If KeyAscii = 8 Then SoloCarateresLegales = KeyAscii
        If KeyAscii = 13 Then SoloCarateresLegales = KeyAscii
        If KeyAscii = 32 Then SoloCarateresLegales = KeyAscii
    End Function
    Public Function Extrae_Letras(ByRef Cadena_Objetivo As String, Optional ByVal IncluirNumeros As Boolean = False) As String
        Dim str_L_Result, _
            str_L_Cadena_Trabajo, _
            str_L_Char As String, _
            int_L_Cont, _
            in_L_loop As Integer, _
            str_Cadena_Validacion As String
        Try
            str_L_Result = ""
            str_L_Cadena_Trabajo = ProcesaCadena(Cadena_Objetivo)
            If Not (str_L_Cadena_Trabajo Is Nothing) Then
                int_L_Cont = Len(str_L_Cadena_Trabajo)
                in_L_loop = 1
                Do While in_L_loop <= int_L_Cont
                    str_L_Char = Mid(str_L_Cadena_Trabajo, in_L_loop, 1)
                    If IncluirNumeros Then
                        str_Cadena_Validacion = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz1234567890"
                    Else
                        str_Cadena_Validacion = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz"
                    End If
                    If InStr(str_Cadena_Validacion, str_L_Char) > 0 Then
                        str_L_Result = str_L_Result + str_L_Char
                        Debug.Print(str_L_Result)
                    End If
                    in_L_loop = in_L_loop + 1
                Loop
            Else
                str_L_Result = Nothing
            End If
            If Len(str_L_Result) = 0 Then
                str_L_Result = Nothing
            End If
            Return str_L_Result
        Catch ex As Exception
            Throw ex
        End Try
    End Function    
    Public Function Tiene_Numeros(ByRef CadenaEvaluada As String) As Boolean
        Dim bln_P_Resultado As Boolean, _
            int_P_Longitud As Int16, _
            str_P_Caracter As String, _
            int_P_Contador As Int16, _
            int_Sum As Int16
        int_P_Longitud = Len(CadenaEvaluada)
        int_Sum = 0
        str_P_Caracter = ""
        For int_P_Contador = 1 To int_P_Longitud
            str_P_Caracter = Mid(CadenaEvaluada, int_P_Contador, 1)
            bln_P_Resultado = (InStr("1234567890", str_P_Caracter) > 0)
            If bln_P_Resultado = True Then
                int_Sum = int_Sum + 1
            End If
        Next
        Return (int_Sum > 0)
    End Function
    ''' <summary>
    ''' Formatea la fecha para operaciones con SQL
    ''' </summary>
    ''' <param name="Fecha">
    ''' Control Datepicker donde está la fecha seleccionada.
    ''' </param>
    ''' <returns>
    ''' Devuelve un string
    ''' </returns>
    ''' <remarks></remarks>
    Public Function FormatearFecha(ByRef Fecha As System.Windows.Forms.DateTimePicker)
        Dim str_Valor_Obtenido As String
        Try
            str_Valor_Obtenido = Format(Fecha.Value, "yyyy" & "-" & "MM" & "-" & "dd")
            Return str_Valor_Obtenido
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    ''' <summary>
    ''' Indica si el articulo seleccionado ya está adicionado en el grid host
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    ''' 
    ''' <summary>
    ''' A partir de un datable determinado, la función determina
    ''' si existen elementos marcados a traves de un campo en ella
    ''' que tiene valores de 0 y/o -1
    ''' </summary>
    ''' <param name="Tabla">
    ''' Tabla en la que se llevará a cabo la busqueda
    ''' </param>
    ''' <param name="Columna_Busqueda">
    ''' Columna en la que se llevará a cabo la búsqueda
    ''' </param>
    ''' <returns>
    ''' Regresa un booleano
    ''' </returns>
    ''' <remarks></remarks>
    Friend Function Existen_Elementos_Seleccionados(ByRef Tabla As System.Data.DataTable, _
                                                    ByVal Columna_Busqueda As Int16) As Boolean
        Dim dr_L_Reng As System.Data.DataRow
        blnResultado = False
        For Each dr_L_Reng In Tabla.Rows
            With dr_L_Reng
                If IsNumeric(.Item(Columna_Busqueda)) Then
                    If CBool(.Item(Columna_Busqueda)) Then
                        blnResultado = True
                        Exit For
                    End If
                End If
            End With
        Next
        Return blnResultado
    End Function
    ''' <summary>
    ''' A partir de una tabla, esta función extraerá
    ''' aquellos renglones que en uno de los campos tengan un
    ''' valor booleano positivo, esto indica que serán utilizados para otro proceso
    ''' </summary>
    ''' <param name="Tabla">
    ''' Tabla que contiene los datos a filtrar
    ''' </param>
    ''' <param name="intCol">
    ''' Columna en la que radica el valor boolean
    ''' </param>
    ''' <param name="TipoFiltro">
    ''' Indica el tipo de filtrado, este puede cambiar de acuerdo al documento destino
    ''' </param>
    ''' <returns>
    ''' Devuelve una datatable con la misma estructura que la del parámetro
    ''' </returns>
    ''' <remarks></remarks>
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="Tabla">
    ''' 
    ''' </param>
    ''' <param name="Identificador">
    ''' 
    ''' </param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Friend Function Item_Seleccionado(ByRef Tabla As DataTable, _
                                      ByVal Identificador As String) As Boolean
        Dim bln_Resultado As Boolean, _
            int_L_Index_Found As Integer
        Try
            If Tabla Is Nothing Then
                Return False
                Exit Function
            Else
                int_L_Index_Found = Determinar_Renglon(Identificador, Tabla)
                bln_Resultado = Not ((int_L_Index_Found = -1))
                Return bln_Resultado
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    ''' <summary>
    ''' Retorna los identificadores seleccionados de los nodos hijos de un treeview en una cadena sin guiones
    ''' </summary>
    ''' <param name="Nodos">
    ''' Colleccion de nodos de un treeview
    ''' </param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function ScanTreeView(ByRef Nodos As TreeNodeCollection) As String
        Dim strIDsTree As String = ""
        Try
            For Each nodo As TreeNode In Nodos
                If nodo.Nodes.Count <> 0 Then
                    strIDsTree = strIDsTree & ScanTreeView(nodo.Nodes)
                Else
                    If nodo.Checked = True And nodo.Name.ToString.Length = 36 Then
                        strIDsTree = strIDsTree & Replace(nodo.Name.ToString, "-", "")
                    Else
                    End If
                End If
            Next
            Return strIDsTree
        Catch ex As Exception
            Return strIDsTree
            Throw ex
        End Try
    End Function
    ''' <summary>
    ''' Determina si los valores entre dos Datepickers forman un rango válido
    ''' </summary>
    ''' <param name="Inicio">
    ''' Combo de fecha de inicio
    ''' </param>
    ''' <param name="Final">
    ''' Combo de fecha final
    ''' </param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Rango_Valido(ByRef Inicio As DateTimePicker, _
                                 ByRef Final As DateTimePicker) As Boolean
        Try
            If Inicio.Value <= Final.Value Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function NuevoId() As String
        Dim strOidNew As String
        Try
            strOidNew = Guid.NewGuid.ToString.ToUpper
            Return strOidNew
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Sub Sumatoria_Items(ByRef Tabla As DataTable, _
                               Optional ByVal Columna_Cantidad As Integer = Nothing, _
                               Optional ByVal Columna_Precio As Integer = Nothing)
        Dim dr_L_Renglon_Calculos As DataRow, _
            dbl_L_Importe_Acumulado As Double, _
            dbl_L_Cantidad_Acumulado As Double, _
            dbl_L_Cantidad As Double, _
            dbl_L_Importe As Double, _
            dbl_L_Precio As Double
        '---------------------------
        'Inicialización de variables
        dbl_L_Importe_Acumulado = 0
        dbl_L_Cantidad_Acumulado = 0
        dbl_L_Cantidad = 0
        dbl_L_Importe = 0
        '---------------------------
        Try
            If Not (Tabla Is Nothing) Then
                If Tabla.Rows.Count > 0 Then
                    For Each dr_L_Renglon_Calculos In Tabla.Rows
                        dbl_L_Cantidad = 0
                        dbl_L_Precio = 0
                        With dr_L_Renglon_Calculos
                            If IsNumeric(.Item(Columna_Cantidad)) And IsNumeric(.Item(Columna_Precio)) Then
                                dbl_L_Cantidad = CDbl(.Item(Columna_Cantidad))
                                dbl_L_Precio = CDbl(.Item(Columna_Precio))
                                dbl_L_Importe = dbl_L_Cantidad * dbl_L_Precio
                                dbl_L_Cantidad_Acumulado = dbl_L_Cantidad_Acumulado + dbl_L_Cantidad
                                dbl_L_Importe_Acumulado = dbl_L_Importe_Acumulado + dbl_L_Importe
                            Else
                                Exit For
                            End If
                        End With
                    Next
                End If
            End If
            str_G_Cantidad_Partidas_General = Format(dbl_L_Cantidad_Acumulado, "###,###,##0.00000")
            str_G_Importe_Partidas_General = Format(dbl_L_Importe_Acumulado, "###,###,##0.00000")
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Function Valores_Combos_Validos(ByRef Coleccion_Valores As Collection) As Boolean
        Dim Valor_Retorno As Boolean
        Valor_Retorno = True
        Try
            For Each Item As Object In Coleccion_Valores
                If Item Is Nothing Then
                    Valor_Retorno = Not (Item Is Nothing)
                    Exit For
                End If
            Next
            Return Valor_Retorno
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    ''' <summary>
    ''' Indica si el item ya está dentro de los elementos de la orden de compra actual
    ''' </summary>
    ''' <param name="Identificador">
    ''' Globaluniqueidentifier de SCItem
    ''' </param>
    ''' <returns>
    ''' Coleccion, con los valores de encontrado e indice
    ''' </returns>
    ''' <remarks></remarks>
    Friend Function Item_Compra_Registrado(ByVal Identificador As String, _
                                           ByRef Data_Actual As DataTable, _
                                           ByVal Columna_Identificador As Int16) As Collection
        Dim bln_L_Variable As Boolean, _
            str_L_Local_Match As String, _
            int_L_RowFoundNum As Int16, _
            col_Retorno As Collection
        '----------------------------------------
        col_Retorno = Nothing
        col_Retorno = New Collection
        bln_L_Variable = False
        int_L_RowFoundNum = -1
        Try
            '----------------------------------------
            With Data_Actual.Rows
                foundRow = .Find(Identificador)
                int_L_RowFoundNum = .IndexOf(foundRow)
            End With
            '----------------------------------------
            bln_L_Variable = (int_L_RowFoundNum > -1)
            '----------------------------------------
            With col_Retorno
                .Add(bln_L_Variable)
                .Add(int_L_RowFoundNum)
            End With
            Return col_Retorno
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function Grupo_Parametros_Validos(ByRef Coleccion_Controles As Collection) As Boolean
        Dim str_L_TipoObjeto As String, _
            bln_Suma_Boolean As Boolean, _
            str_L_Cadena_Validadora As String, _
            bln_L_Variable As Boolean, _
            int_L_IDX_Item As Int16
        bln_Suma_Boolean = True
        Try
            For Each Objeto_control As Object In Coleccion_Controles
                str_L_TipoObjeto = Objeto_control.GetType.ToString()
                Select Case str_L_TipoObjeto
                    'Case Is = "System.Windows.Forms.DateTimePicker"
                    '    With CType(Objeto_control, Windows.Forms.DateTimePicker)

                    '    End With
                    Case Is = "System.Windows.Forms.TextBox"
                        With CType(Objeto_control, Windows.Forms.TextBox)
                            If Not (.Text) Is Nothing Then
                                'str_L_Cadena_Validadora = modHerramientas.ProcesaCadena(.Text)
                                str_L_Cadena_Validadora = Extrae_Letras(.Text, True)
                                bln_L_Variable = (Len(str_L_Cadena_Validadora) > 0)
                            Else
                                bln_L_Variable = False
                            End If
                        End With
                    Case Is = "System.Windows.Forms.ComboBox"
                        If Not (DirectCast(Objeto_control, System.Windows.Forms.ComboBox).SelectedValue Is Nothing) Then
                            With DirectCast(Objeto_control, System.Windows.Forms.ComboBox)
                                If .SelectedIndex <> -1 Then
                                    str_L_Cadena_Validadora = .SelectedValue.ToString
                                    If Len(str_L_Cadena_Validadora) > 0 Then
                                        bln_L_Variable = True
                                    Else
                                        bln_L_Variable = False
                                    End If
                                Else
                                    bln_L_Variable = False
                                End If
                            End With
                        Else
                            bln_L_Variable = False
                        End If
                    Case Is = ""
                End Select
                bln_Suma_Boolean = (bln_Suma_Boolean And bln_L_Variable)
            Next
            Return bln_Suma_Boolean
        Catch ex As Exception
            Throw ex
        End Try
    End Function
#End Region
#Region "Metodos"
    ''' <summary>
    ''' Esta función activa o desactiva los controles que están referenciados
    ''' dentro de una colección
    ''' </summary>
    ''' <param name="Controles">
    ''' Es el nombre de la colección donde están las referencias a los controles
    ''' </param>
    ''' <param name="Activar">
    ''' Indica si se activa (True) o desactiva (False) el contenido de la colección
    ''' </param>
    ''' <remarks>
    ''' No confundir con la función que se usa para desactivar o activar los controles de un formulario
    ''' completo
    ''' </remarks>
    Public Sub Activa_Desactiva__Gpo_Controles(ByRef Controles As Collection, ByVal Activar As Boolean)
        Try
            For Each Elemento As Object In Controles
                DirectCast(Elemento, System.Windows.Forms.Control).Enabled = Activar
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    ''' <summary>
    ''' Elimina los renglones seleccionados en una tabla fuente de datos de un grid
    ''' </summary>
    ''' <param name="Datos">
    ''' Datatable donde radican los registros
    ''' </param>
    ''' <param name="Columna_Check">
    ''' Indice de la columna donde está el valor booleano
    ''' </param>
    ''' <param name="Columna_Guia">
    ''' Indice de columna guia del identificador de registro
    ''' </param>
    ''' <remarks></remarks>
    Public Sub RemueveSeleccionados(ByRef Datos As DataTable, _
                                    ByVal Columna_Check As Int16, _
                                    Optional ByVal Columna_Guia As Int16 = 0, _
                                    Optional ByRef Grid_Host As C1.Win.C1TrueDBGrid.C1TrueDBGrid = Nothing)
        Try
            Dim intmast As Int16, _
                intLL As Int16
            intmast = Datos.Rows.Count - 1
            Do While intmast > 0
                Dim dr_L_Ren As DataRow
                dr_L_Ren = Datos.Rows.Item(intmast)
                If Not (String.IsNullOrEmpty(dr_L_Ren.Item(Columna_Check).ToString)) Then
                    If CBool(dr_L_Ren.Item(1).ToString) Then
                        intLL = Rastrear_Record(dr_L_Ren.Item(Columna_Guia), Datos, Columna_Guia)
                        Datos.Rows.Item(intLL).Delete()
                    End If
                End If
                intmast = intmast - 1
            Loop
            If Not (Grid_Host Is Nothing) Then
                Grid_Host.Refresh()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    ''' <summary>
    ''' Determina los items adicionados en el grid maestro del 
    ''' centro de mando de compras,los busca en el grid de la orden de compra
    ''' </summary>
    ''' <param name="Master_Gear">
    ''' Datatable maestro
    ''' </param>
    ''' <param name="Secondary_Gear">
    ''' Datatable secundario
    ''' </param>
    ''' <remarks></remarks>
    Friend Sub Check_Secondary_Gear(ByRef Master_Gear As DataTable, _
                                    ByRef Secondary_Gear As DataTable, _
                                    ByVal Columna_Identificador_Master As Int16, _
                                    ByVal Columna_Identificador_Secondary As Int16, _
                                    Optional ByVal Columna_Check As Int16 = -1)

        Dim bln_Encontrado As Boolean, _
            str_Item_Identificador_master As String, _
            DR_L_RenDatosSG As DataRow, _
            bln_L_Checado As Boolean, _
            DR_L_New_Row As DataRow, _
            str_L_SecondaryCol_Name As String, _
            str_L_MasterCol_Name As String, _
            int_L_Index_Col_Master As Int16, _
            int_L_Index_Col_Secondary As Int16, _
            int_IDX_Found As Int16, _
            bln_L_Adicionar As Boolean
        Try
            bln_L_Adicionar = False
            For Each dr_L_Master_DRW As DataRow In Master_Gear.Rows
                If Columna_Check <> -1 Then
                    bln_L_Checado = CBool(dr_L_Master_DRW.Item(Columna_Check).ToString)
                    If bln_L_Checado Then
                        str_Item_Identificador_master = dr_L_Master_DRW.Item(Columna_Identificador_Master).ToString
                        bln_Encontrado = CType(Item_Compra_Registrado(str_Item_Identificador_master, _
                                                           Secondary_Gear, _
                                                           Columna_Identificador_Secondary).Item(1), Boolean)
                        If bln_Encontrado = False Then
                            DR_L_New_Row = Secondary_Gear.NewRow
                            'Recorremos la tabla madre para comparar
                            'los nombres de las columnas, si son
                            'iguales, entonces almacenaremos el valor
                            'en el renglon nuevo
                            For Each dc_L_Col_Sec As DataColumn In Secondary_Gear.Columns
                                str_L_SecondaryCol_Name = dc_L_Col_Sec.ColumnName.ToString
                                For Each dc_L_Col_Prim As DataColumn In Master_Gear.Columns
                                    str_L_MasterCol_Name = dc_L_Col_Prim.ColumnName.ToString
                                    If str_L_SecondaryCol_Name = str_L_MasterCol_Name Then
                                        'Determinamos los indices de las columnas que dan match
                                        int_L_Index_Col_Master = Master_Gear.Columns.IndexOf(dc_L_Col_Prim)
                                        int_L_Index_Col_Secondary = Secondary_Gear.Columns.IndexOf(dc_L_Col_Sec)
                                        DR_L_New_Row.Item(int_L_Index_Col_Secondary) = dr_L_Master_DRW.Item(int_L_Index_Col_Master).ToString
                                    End If
                                Next
                            Next
                            Secondary_Gear.Rows.Add(DR_L_New_Row)
                        End If
                    End If
                Else
                    str_Item_Identificador_master = dr_L_Master_DRW.Item(Columna_Identificador_Master).ToString
                    bln_Encontrado = CType(Item_Compra_Registrado(str_Item_Identificador_master, _
                                                        Secondary_Gear, _
                                                        Columna_Identificador_Secondary).Item(1), Boolean)
                End If
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    ''' <summary>
    ''' Activa / desactiva la interfase seleccionada y la marca como 
    ''' ocupada si asi se le indica
    ''' </summary>
    ''' <param name="Formulario">
    ''' Nombre del formulario
    ''' </param>
    ''' <param name="Activar">
    ''' Bloquear / Desbloquear el formulario
    ''' </param>
    ''' <param name="MarcarOcupado">
    ''' Mostrar cursor con reloj de arena
    ''' </param>
    ''' <param name="Notificacion">
    ''' (Opcional)Mostrar mensaje en barra de status, objeto
    ''' </param>
    ''' <remarks>
    ''' </remarks>
    ''' 
    Public Sub Activar_Interface(ByRef Formulario As Form, _
                                 ByVal Activar As Boolean, _
                                 Optional ByVal MarcarOcupado As Boolean = Nothing, _
                                 Optional ByRef Notificacion As System.Windows.Forms.StatusStrip = Nothing)

        '--------------------------------
        'Proyecto   :SIL(Sistema de llantas)
        'Programó   :Israel Greß
        'Fecha      :06/Abril/2005
        '--------------------------------
        'Descripcion :Bloquea o desbloquea los controles de un formulario en especifico
        '-------------------------------- 
        '[Notas:]
        '-------------------------------- 
        'Primero determinamos los controles "Maestros", es decir aquellos
        'que pueden contener controles ,pero cuyo unico "Maestro"
        'o contenedor es el formulario.
        'Por ejemplo: 
        'En un formulario tenemos un boton, 
        'una barra de estado y un tab.
        'El tab tiene dos páginas, si utilizamos
        'la propiedad Count de la propiedad controls del
        'formulario nos dirá que solo tiene 3 controles
        'por que los que estan "dentro" del tab no los toma
        'en cuenta.
        'Para determinar los controles "esclavos" de 
        'un control subordinado es necesario utilizar
        'su propiedad controls.
        'Es muy importante tomar en cuenta
        'que los controles "heredan" la propiedad
        '"Enabled" de su "maestro" o contenedor
        '-------------------------------- 
        '[Modificaciones:]
        '-------------------------------- 
        Dim ContMaestro, _
            ContMaestroSub, _
            ContEsclavo, _
            TotContMaestro, _
            TotConMaesSub, _
            TotConEsclavo As Int16
        Try
            If MarcarOcupado = Nothing Then
                MarcarOcupado = Not (Activar)
            End If
            TotContMaestro = (Formulario.Controls.Count - 1)
            'Bloquear = Not (Bloquear)
            If Activar = False Then
                '                Formulario.po
                For ContMaestro = 0 To TotContMaestro
                    If Formulario.Controls.Item(ContMaestro).GetType.ToString <> "System.Windows.Forms.TabControl" And _
                       Formulario.Controls.Item(ContMaestro).GetType.ToString <> "System.Windows.Forms.StatusBar" Then
                        With Formulario.Controls.Item(ContMaestro)
                            .Tag = CType(.Enabled, Int16).ToString
                            .Enabled = Activar
                        End With
                    Else
                        'Es probable que tenga controles "Subordinados"
                        TotConMaesSub = (Formulario.Controls.Item(ContMaestro).Controls.Count - 1)
                        For ContMaestroSub = 0 To TotConMaesSub
                            If Formulario.Controls.Item(ContMaestro).Controls.Item(ContMaestroSub).GetType.ToString <> "System.Windows.Forms.TabPage" Then
                                With Formulario.Controls.Item(ContMaestro).Controls.Item(ContMaestroSub)
                                    .Tag = CType(.Enabled, Int16).ToString
                                    .Enabled = Activar
                                End With
                            Else
                                'En este caso si tiene hijos, no modificaremos su estado "Enabled"
                                'ya que si lo haremos modificaremos el de todos sus hijos
                                TotConEsclavo = (Formulario.Controls.Item(ContMaestro).Controls.Item(ContMaestroSub).Controls.Count - 1)
                                For ContEsclavo = 0 To TotConEsclavo
                                    With Formulario.Controls.Item(ContMaestro).Controls.Item(ContMaestroSub).Controls.Item(ContEsclavo)
                                        .Tag = CType(.Enabled, Int16).ToString
                                        .Enabled = Activar
                                    End With
                                Next
                            End If
                        Next
                    End If
                Next
            Else
                For ContMaestro = 0 To TotContMaestro
                    If Formulario.Controls.Item(ContMaestro).GetType.ToString <> "System.Windows.Forms.TabControl" And _
                       Formulario.Controls.Item(ContMaestro).GetType.ToString <> "System.Windows.Forms.StatusBar" Then
                        With Formulario.Controls.Item(ContMaestro)
                            .Enabled = CType(.Tag, Boolean)
                        End With
                    Else
                        'Es probable que tenga controles "Subordinados"
                        TotConMaesSub = (Formulario.Controls.Item(ContMaestro).Controls.Count - 1)
                        For ContMaestroSub = 0 To TotConMaesSub
                            If Formulario.Controls.Item(ContMaestro).Controls.Item(ContMaestroSub).GetType.ToString <> "System.Windows.Forms.TabPage" Then
                                With Formulario.Controls.Item(ContMaestro).Controls.Item(ContMaestroSub)
                                    .Enabled = CType(.Tag, Boolean)
                                End With
                            Else
                                'En este caso si tiene hijos, no modificaremos su estado "Enabled"
                                'ya que si lo haremos modificaremos el de todos sus hijos
                                TotConEsclavo = (Formulario.Controls.Item(ContMaestro).Controls.Item(ContMaestroSub).Controls.Count - 1)
                                For ContEsclavo = 0 To TotConEsclavo
                                    With Formulario.Controls.Item(ContMaestro).Controls.Item(ContMaestroSub).Controls.Item(ContEsclavo)
                                        .Enabled = CType(.Tag, Boolean)
                                    End With
                                Next
                            End If
                        Next
                    End If
                Next
            End If
            If MarcarOcupado = True Then
                Formulario.Cursor = Cursors.WaitCursor
                If Not (Notificacion Is Nothing) Then
                    Notificacion.Items.Item(0).Text = "Cargando... por favor espere"
                End If
            Else
                Formulario.Cursor = Cursors.Default
                If Not (Notificacion Is Nothing) Then
                    Notificacion.Items.Item(0).Text = ""
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub Notificacion(ByRef Etiqueta As System.Windows.Forms.ToolStripStatusLabel, _
                            ByRef Mensaje As String, Optional ByVal Limpiar As Boolean = False)
        Try
            If Limpiar = False Then
                Etiqueta.Text = ""
                Etiqueta.Text = Mensaje
            Else
                Etiqueta.Text = ""
            End If
        Catch ex As Exception
            Throw (ex)
        End Try
    End Sub
    ''' <summary>
    ''' Manejador central de errores
    ''' </summary>
    ''' <param name="ex">
    ''' Objeto excepcion (por referencia)
    ''' </param>
    ''' <param name="ObjConsola">
    ''' Nombre del MDI maestro
    ''' </param>
    ''' <remarks></remarks>
    Public Sub MostrarError(ByRef ex As Exception, ByRef ObjConsola As Form)
        '--------------------------------
        'Proyecto   :SIL(Sistema de llantas)
        'Programó   :Israel Greß
        'Fecha      :06/Abril/2005
        '-------------------------------- 
        'Descripcion :Permite el control de er.RunWorkerAsync()rores centralizado
        '-------------------------------- 
        '[Modificaciones:]
        Dim strNombrePc, _
            strLoginName, _
            str_L_TipoExep, _
            mstrMsgFinal, _
            strChainInfo As String, _
            int_L_IndexLabel As Int16, _
            obj_L_Font As Font, _
            int_currentSize As Int16
        Try
            strNombrePc = Environment.MachineName
            strLoginName = Environment.UserName
            objNotificador = New frmVisorError
            With objNotificador
                .WindowState = FormWindowState.Normal
                .StartPosition = FormStartPosition.CenterScreen
                '.MdiParent = ObjConsola
                .TopMost = True
                .Opacity = 0.85
            End With
            lbl_Etiqueta_Aviso = Nothing
            lbl_Etiqueta_Aviso = New System.Windows.Forms.Label
            obj_L_Font = Nothing


            With lbl_Etiqueta_Aviso
                int_currentSize = .Font.Size
                int_currentSize += 2.0F
                .TextAlign = ContentAlignment.MiddleLeft
                .Font = New Font(.Font.Name, int_currentSize, .Font.Style, .Font.Unit)
                .ForeColor = Color.Orange
                .Visible = True
                .Height = 267
                .Width = 453
                .Left = 12
                .Top = 9
                .BackColor = Color.Transparent
            End With

            str_L_TipoExep = ex.GetType.ToString
            If str_L_TipoExep = "System.Data.SqlClient.SqlException" Then
                If DirectCast(ex, SqlClient.SqlException).Number = 50000 Then
                    'Mostramos un msgbox normal, pero con el mensaje de error.                
                    MessageBox.Show(ex.Message.ToString, "Verificación del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ex = Nothing
                    Exit Sub
                Else
                    With objNotificador
                        .Controls.Add(lbl_Etiqueta_Aviso)
                        int_L_IndexLabel = .Controls.IndexOf(lbl_Etiqueta_Aviso)
                        .Controls.Item(int_L_IndexLabel).Text = ("* [Clase:]" & ex.TargetSite.DeclaringType.Name & ControlChars.CrLf & _
                                                 "* [Metodo:]" & ex.TargetSite.Name & ControlChars.CrLf & _
                                                 "* [Componente :] " & ex.TargetSite.Module.Name.ToString & ControlChars.NewLine & _
                                                "* [Descripcion :] " & ex.Message.ToString & ControlChars.NewLine & _
                                                 "* [Estación de trabajo :] " & strNombrePc & ControlChars.NewLine & _
                                                 "* [Usuario de red :] " & strLoginName & ControlChars.NewLine)
                        .ShowDialog()
                    End With
                End If
            Else
                With objNotificador
                    .Controls.Add(lbl_Etiqueta_Aviso)
                    int_L_IndexLabel = .Controls.IndexOf(lbl_Etiqueta_Aviso)
                    .Controls.Item(int_L_IndexLabel).Text = ("* [Clase:]" & ex.TargetSite.DeclaringType.Name & ControlChars.CrLf & _
                                             "* [Metodo:]" & ex.TargetSite.Name & ControlChars.CrLf & _
                                             "* [Componente :] " & ex.TargetSite.Module.Name.ToString & ControlChars.NewLine & _
                                            "* [Descripcion :] " & ex.Message.ToString & ControlChars.NewLine & _
                                             "* [Estación de trabajo :] " & strNombrePc & ControlChars.NewLine & _
                                             "* [Usuario de red :] " & strLoginName & ControlChars.NewLine)
                    .ShowDialog()
                End With
            End If
            'Dim sSource As String
            'Dim sLog As String
            'Dim sEvent As String
            'Dim sMachine As String
            'sSource = "CTLLOG"
            'sLog = "Application"
            'sEvent = "Sample Event"
            'sMachine = "MEXSIS12"


            'Dim ELog As New EventLog(sLog, strNombrePc, ex.Message.ToString)
            'ELog.WriteEntry(sEvent)
            'ELog.WriteEntry(sEvent, EventLogEntryType.Warning, 234, CType(3, Short))
            'EventLog.WriteEntry("Evento de prueba para el registro", ex.Message.ToString, System.Diagnostics.EventLogEntryType.Error)
        Catch Last As Exception
            MessageBox.Show(Last.Message.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
    ''' <summary>
    ''' Limpia el TrueDbGrid para dejarlo en estado inicial
    ''' </summary>
    ''' <param name="Rejilla"></param>
    ''' <remarks></remarks>
    Public Sub Reset_Grid(ByRef Rejilla As C1.Win.C1TrueDBGrid.C1TrueDBGrid, Optional ByVal Activo As Boolean = True)
        '--------------------------------
        'Proyecto   :SAT
        'Programó   :Israel Greß
        'Fecha      :23/Agosto/2007
        '--------------------------------
        'Descripcion :Reinicia el grid objetivo
        '-------------------------------- 
        '[Notas:]
        '-------------------------------- 
        Try
            Dim dt_L_Data_Table_Empty As DataTable
            dt_L_Data_Table_Empty = Nothing
            dt_L_Data_Table_Empty = New DataTable
            With Rejilla
                .DataSource = Nothing
                .DataSource = dt_L_Data_Table_Empty
                .Rebind(False)
                .Refresh()
                .DataSource = Nothing
                .Refresh()
                If Not (Activo) Then .Enabled = False
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub Notificacion_Tool_Tip(ByRef Msgr As System.Windows.Forms.ToolTip, _
                                     ByRef txtBox As System.Windows.Forms.MaskedTextBox, _
                                     ByRef Titulo As String, ByRef Mensaje As String)
        Try
            With Msgr
                .ToolTipTitle = Titulo
                .Show(Mensaje, txtBox)
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub Test_Msg(ByRef Barra_Msg As System.Windows.Forms.StatusStrip)
        Try
            With Barra_Msg.Items.Item(0)
                .Text = "Cargando...por favor espere"
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    ''' <summary>
    ''' Exporta el contenido del grid a Excel
    ''' </summary>
    ''' <param name="Grid">
    ''' Nombre del control que contiene los datos
    ''' </param>
    ''' <param name="Formulario">
    ''' Formulario que contiene al grid
    ''' </param>
    ''' <param name="Mensajero">
    ''' Barra de status para emitir mensaje
    ''' </param>
    ''' <param name="Boton_Deactivate" >
    ''' Boton que inicia la accion de exportar
    ''' </param>
    ''' <remarks>
    ''' Nada de consideración
    ''' </remarks>
    Public Sub Expo_Grid_Excel(ByRef Grid As C1.Win.C1TrueDBGrid.C1TrueDBGrid, _
                               ByRef Formulario As Windows.Forms.Form, _
                               Optional ByRef Boton_Deactivate As System.Windows.Forms.Button = Nothing)
        Try
            If Not (Boton_Deactivate Is Nothing) Then
                Boton_Deactivate.Enabled = False
            End If
            If Not (Grid.DataSource Is Nothing) And Grid.VisibleRows > 0 Then
                If Not (objDialog_SvFile Is Nothing) Then
                    objDialog_SvFile = Nothing
                End If
                objDialog_SvFile = New Windows.Forms.SaveFileDialog
                With objDialog_SvFile
                    .Reset()
                    .CreatePrompt = False
                    .OverwritePrompt = True
                    .AddExtension = True
                    .DefaultExt = ".xls"
                    .Filter = "Archivos de Microsoft Excel(*.xls)|*.xls"
                    .ShowDialog()
                    strFileNameXport = .FileName
                    Activar_Interface(Formulario, False, True)
                    With Grid
                        If strFileNameXport <> "" Then
                            .ExportToExcel(strFileNameXport, True)
                        End If
                    End With
                    Activar_Interface(Formulario, True, False)
                End With
            End If
        Catch ex As Exception
            Activar_Interface(Formulario, True)
            Throw ex
        End Try
    End Sub
    Public Sub Accion_Nodo(ByRef objNodo As TreeNode, _
                                   ByVal MostrarConteo As Boolean)
        Dim objChild As TreeNode, _
            int_ChkSum As Int16, _
            objAux As TreeNode, _
            int_L_IndexChild As Int16, _
            bln_Stat_Check As Boolean
        Try
            With objNodo
                bln_Stat_Check = .Checked
                If .Parent Is Nothing Then
                    'No tiene padre es raiz, pasamos el valor a sus hijos,
                    'si el valor es positivo, estamos pasando el valor a sus hijos
                    If bln_Stat_Check Then
                        For Each objAux In .Nodes
                            objAux.Checked = True
                        Next
                    Else
                        For Each objAux In .Nodes
                            objAux.Checked = False
                        Next
                    End If
                Else
                    'Depende del valor, tiene hijos y es padre
                    If bln_Stat_Check Then
                        'Se trata de un sub nodo, si tiene hijos les pasamos el valor positivo
                        For Each objAux In .Nodes
                            objAux.Checked = True
                        Next
                    Else
                        If .Nodes.Count = 0 Then
                            'ultimo eslabon de la cadena, sólo le cambiamos el valor a su padre
                            '.Parent.Checked = bln_Stat_Check
                            'Beep()
                        Else
                            For Each objAux In .Nodes
                                objAux.Checked = False
                            Next
                        End If
                    End If
                End If
            End With
            'With objNodo
            'If (.Parent Is Nothing) Then
            '    'Se trata de un nodo "Padre"
            '    If .Checked = True Then
            '        'Determinar si sus hijos están checados
            '        int_ChkSum = 0
            '        For Each objAux In .Nodes
            '            int_ChkSum = int_ChkSum + (CType(objAux.Checked, Int16) * -1)
            '        Next
            '        If int_ChkSum <> .Nodes.Count Then
            '            For Each objChild In objNodo.Nodes
            '                objChild.Checked = .Checked
            '            Next
            '            .Expand()
            '        End If
            '    Else
            '        'Determinar si todos los hijos estan checados si lo estan y el padre no esta checado los mandamos todos a la burguer
            '        int_ChkSum = 0
            '        For Each objAux In .Nodes
            '            int_ChkSum = int_ChkSum + (CType(objAux.Checked, Int16) * -1)
            '        Next
            '        If (int_ChkSum = .Nodes.Count) And .Checked = False Then
            '            For Each objAux In .Nodes
            '                objAux.Checked = False
            '            Next
            '            If .IsExpanded Then
            '                .Collapse(True)
            '            End If
            '        End If
            '    End If
            'Else
            '    'Dado que se trata de un nodo hijo,sería util contar los nodos hijos checados
            '    'Contar los hijos "Checados"
            '    int_L_IndexChild = Nothing
            '    'Vamos a checar si el nodo tiene hijitos (¡Ahhhh que mamón el sr. programador!.. "Hijitos", pinche cursi.)
            '    If objNodo.Nodes.Count > 0 Then
            '        For Each obj_l_NodeItem As TreeNode In objNodo.Nodes
            '            obj_l_NodeItem.Checked = bln_Stat_Check
            '        Next
            '    End If
            '    For Each objChild In .Parent.Nodes
            '        If objChild.Checked Then
            '            int_L_IndexChild = int_L_IndexChild + 1
            '        End If
            '    Next
            '    If MostrarConteo = True Then
            '        If int_L_IndexChild > 0 Then
            '            .Parent.Text = .Parent.Name + Space(1) + "[" + int_L_IndexChild.ToString + "]"
            '        Else
            '            .Parent.Text = .Parent.Name
            '        End If
            '    End If
            '    If .Checked = False Then
            '        .Parent.Checked = .Checked
            '    End If
            'End If
            'End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub RastrearMnus(ByVal Objeto As MenuStrip, _
                            Optional ByVal Deactivate As Boolean = False)
        Try
            objArrListaMnus = Nothing
            objArrListaMnus = New ArrayList
            For Each Hijo As ToolStripMenuItem In Objeto.Items
                If Deactivate = True Then
                    '*********************
                    With Hijo
                        If .Text = "&Archivo" Or .Text = "&Salir" Then
                            .Enabled = True
                        Else
                            .Enabled = False
                        End If
                    End With
                    '*********************
                End If
                objEntidad = Nothing
                objEntidad = New clObjeto
                With objEntidad
                    .Identificador = Hijo.Name.ToString
                    .Texto = Hijo.Text.ToString
                End With
                objArrListaMnus.Add(objEntidad)
                If Hijo.DropDownItems.Count > 0 Then
                    SubRastreo(Hijo.DropDownItems, Deactivate)
                End If
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub SubRastreo(ByRef colOpcionesMenu As ToolStripItemCollection, _
                          Optional ByVal Deactivate As Boolean = False)
        Try
            For Each itmOpcion As ToolStripItem In colOpcionesMenu
                If Deactivate = True Then
                    itmOpcion.Enabled = False
                End If
                objEntidad = Nothing
                objEntidad = New clObjeto
                If TypeName(itmOpcion) <> "ToolStripSeparator" Then
                    With objEntidad
                        .Identificador = itmOpcion.Name.ToString
                        If .Texto = "&Salir" Then
                        End If
                        .Texto = itmOpcion.Text.ToString
                    End With
                    objArrListaMnus.Add(objEntidad)
                    ' si es una opción de menú normal... 
                    If DirectCast(itmOpcion, ToolStripMenuItem).DropDownItems.Count > 0 Then
                        SubRastreo(DirectCast(itmOpcion, ToolStripMenuItem).DropDownItems, Deactivate)
                    End If
                End If
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub Deactivate_Mnus(ByVal Objeto As MenuStrip)
        Try
            RastrearMnus(Objeto, True)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    ''' <summary>
    ''' Permite adicionar Items a un grid en funcion de sus necesidades
    ''' </summary>
    ''' <param name="Grid_Receptor">
    ''' Receptor de la data seleccionada
    ''' </param>
    ''' <param name="sht_Index_Guia">
    ''' Indice del grid receptor, en el caso que se requiera
    ''' </param>
    ''' <remarks></remarks>
    Public Sub Adicionar_Grid_Items(ByRef Grid_Receptor As C1.Win.C1TrueDBGrid.C1TrueDBGrid, _
                                    Optional ByRef sht_Index_Guia As Short = Nothing)
        Dim str_Grid_Name As String, _
            str_L_Identificador As String, _
            int_L_UltimoIndice As Integer, _
            int_L_Row_ToUpdate As Integer, _
            int_L_UltimoAdd As Integer, _
            int_L_Variable_Funcion_Grid As Int16
        Try
            str_Grid_Name = Grid_Receptor.Name.ToString
            'En función del grid que recibirá los datos, cambiará el 
            'valor de la variable apuntando quizá a diferente columna
            int_L_Variable_Funcion_Grid = Nothing
            Select Case str_Grid_Name
                Case Is = "tdbgMCMovimientos"
                    int_L_Variable_Funcion_Grid = 0
                Case Is = "tdbgSolItems"
                    int_L_Variable_Funcion_Grid = 0
                Case Is = "tdbgOrdenAbastecimiento"
                    'int_L_Variable_Funcion_Grid = 1
                    int_L_Variable_Funcion_Grid = 0
                Case Else
                    int_L_Variable_Funcion_Grid = 0
            End Select
            'If Registrado(Grid_Receptor, Articulo) = False Then
            '    With Grid_Receptor
            '        If CType(.DataSource, System.Data.DataTable).Rows.Count <= sht_Index_Guia Then
            '            sht_Index_Guia = -1
            '        End If
            '        If sht_Index_Guia = -1 Then
            '            'Se trata de una adicion, tomamos el anterior ID y adicionamos un renglon nuevo al Datatable
            '            'Copiamos un renglon cualquiera, y le cambiamos los valores, con el fin de no perder
            '            'la utilidad del primary key en el grid.
            '            'Limpiamos todos los datos del renglon, y asignamos nuevo valor a la columna de SCItem
            '            obj_L_Dato = CType(Grid_Receptor.DataSource, System.Data.DataTable).NewRow
            '            obj_L_Dato(0) = modHerramientas.NuevoId
            '            CType(Grid_Receptor.DataSource, System.Data.DataTable).Rows.Add(obj_L_Dato)
            '            int_L_UltimoAdd = CType(Grid_Receptor.DataSource, System.Data.DataTable).Rows.Count - 1
            '            If str_Grid_Name = "tdbgSolItems" Then
            '                str_L_Identificador = CType(Grid_Receptor.DataSource, System.Data.DataTable).Rows.Item(int_L_UltimoAdd - 1).Item(int_L_Variable_Funcion_Grid).ToString
            '            Else
            '                str_L_Identificador = CType(Grid_Receptor.DataSource, System.Data.DataTable).Rows.Item(int_L_UltimoAdd).Item(int_L_Variable_Funcion_Grid).ToString
            '            End If
            '            Moldeado_SolRef(.DataSource, Articulo, int_L_UltimoAdd, str_L_Identificador, str_Grid_Name, str_L_TipoMov_Adicion_Grid)
            '            int_L_Row_ToUpdate = int_L_UltimoAdd
            '        Else
            '            'Hay un renglon seleccionado, ese es el que debemos actualizar
            '            'Registramos el ID de la reparacion
            '            '*********************************************************************************************
            '            'str_L_Identificador = CType(.DataSource, System.Data.DataTable).Rows(sht_Index_Guia).Item(0).ToString
            '            str_L_Identificador = CType(.DataSource, System.Data.DataTable).Rows(sht_Index_Guia).Item(int_L_Variable_Funcion_Grid).ToString
            '            '*********************************************************************************************
            '            Moldeado_SolRef(.DataSource, Articulo, sht_Index_Guia, str_L_Identificador, str_Grid_Name)
            '            int_L_Row_ToUpdate = sht_Index_Guia
            '            sht_Index_Guia = -1
            '        End If
            '        .RefetchRow(int_L_Row_ToUpdate)
            '        For Each L_Col As C1.Win.C1TrueDBGrid.C1DisplayColumn In Grid_Receptor.Splits(0).DisplayColumns
            '            With L_Col
            '                If .Visible Then
            '                    .AutoSize()
            '                End If
            '            End With
            '        Next
            '    End With
            'End If
        Catch ex As Exception
            Throw ex
            'MostrarError(ex, Main)
        End Try
    End Sub
    ''' <summary>
    ''' Auxilia al manejo de la opcion "Todos" en los check lists
    ''' Si la opcion "Todos" es activada, todos los elementos del check se marcan
    ''' asi a la inversa,mas que otra cosa, es una ayuda visual para el usuario
    ''' IMPORTANTE: el control debe tener la propiedad CheckOnClick = TRUE
    ''' [Ok, ok es mamona la función, pero al usuario le ayuda, ya que es medio babas :)]
    ''' </summary>
    ''' <param name="Emisor">
    ''' Control del cual se desea controlar el comportamiento
    ''' </param>
    ''' <remarks></remarks>
    Public Sub OptionAll(ByRef Emisor As Object)
        Dim int_L_Index As String, _
            str_L_Valor_Seleccionado As String, _
            str_L_Valor_Local As String, _
            blnChecado As Boolean, _
            x As Int16, _
            obj_L_Checked_L_B As System.Windows.Forms.CheckedListBox
        Try
            'Referenciamos al objeto que emite
            obj_L_Checked_L_B = Emisor
            With obj_L_Checked_L_B
                'Determinamos el índice del item seleccionado, ya sea que esté verificado o no
                int_L_Index = .Items.IndexOf(.SelectedItem)
                str_L_Valor_Seleccionado = .Items(int_L_Index).ToString
                .SelectedItems.Clear()
                If Not .GetItemChecked(int_L_Index) Then
                    'El valor NO esta seleccionado 
                    If str_L_Valor_Seleccionado = ALL_OPT Then
                        'ponemos todos los demas elementos en estado indeterminado si el valor es "Todos"
                        For x = 0 To .Items.Count - 1
                            If x <> int_L_Index Then
                                .SetItemCheckState(x, CheckState.Indeterminate)
                            Else
                                .SetItemCheckState(int_L_Index, CheckState.Checked)
                            End If
                        Next x
                    Else
                        .SetItemCheckState(int_L_Index, CheckState.Checked)
                    End If
                Else
                    'El valor SI está seleccionado
                    If str_L_Valor_Seleccionado = ALL_OPT Then
                        'Dado que el valor desmarcado es "Todas", ponemos todos los elementos como "Unchecked"
                        .SetItemCheckState(int_L_Index, CheckState.Unchecked)
                        For x = 0 To .Items.Count - 1
                            .SetItemCheckState(x, CheckState.Unchecked)
                        Next x
                    Else
                        'Seleccion de otro valor diferente a "Todos", en caso de que "Todos" esté checado, lo desactivamos
                        For x = 0 To .Items.Count - 1
                            '.SetItemCheckState(x, CheckState.Checked)
                            If .Items(x).ToString = ALL_OPT Then
                                .SetItemCheckState(x, CheckState.Unchecked)
                            Else
                                Select Case .GetItemCheckState(x)
                                    Case CheckState.Indeterminate
                                        .SetItemCheckState(x, CheckState.Checked)
                                    Case CheckState.Checked
                                        If str_L_Valor_Seleccionado = .Items(int_L_Index).ToString Then
                                            .SetItemCheckState(int_L_Index, CheckState.Unchecked)
                                            Exit For
                                        End If
                                End Select
                            End If
                        Next x
                    End If
                End If
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    ''' <summary>
    ''' Formatea los datos recibidos para generar una impresion tipo Ticket
    ''' </summary>
    ''' <param name="strSolicitudRef">
    ''' Folio de solicitud de refacciones (Tipo Texto)
    ''' </param>
    ''' <param name="strFolioSalida">
    ''' Folio de salida de almacen (Tipo Texto)
    ''' </param>
    ''' <param name="strFolioMaestro">
    ''' Folio maestro de la orden de trabajo (Tipo Texto)
    ''' </param>
    ''' <param name="strVehiculo">
    ''' Tipo de veiculo (Tipo Texto)
    ''' </param>
    ''' <param name="strNumero">
    ''' Numero (Tipo Texto)
    ''' </param>
    ''' <param name="strMecanico">
    ''' Nombre del mecanico que solicita (Tipo Texto)
    ''' </param>
    ''' <param name="strResponsable">
    ''' Nombre del responsable que genera el ticket (Tipo Texto)
    ''' </param>
    ''' <param name="strFechaSalida">
    ''' Fehca de entrega (Tipo Texto)
    ''' </param>
    ''' <param name="intIndexDescripcion">
    ''' Columna que contiene la descripcion del articulo (Tipo entero)
    ''' </param>
    ''' <param name="intIndexCodigo">
    ''' Columna que contiene el codigo del articulo solicitado (Tipo entero)
    ''' </param>
    ''' <param name="intIndexCantidad">
    ''' Columna que contiene la cantidad solicitada por articulo (Tipo entero)
    ''' </param>
    ''' <param name="dtDescripcion">
    ''' informacion de las partidas solicitadas al almacen (Tipo Datatable)
    ''' </param>
    ''' <remarks></remarks>
    Public Sub Imprimir(ByVal strSolicitudRef As String, _
                        ByVal strFolioSalida As String, _
                        ByVal strFolioMaestro As String, _
                        ByVal strVehiculo As String, _
                        ByVal strDiario As String, _
                        ByVal strNumero As String, _
                        ByVal strMecanico As String, _
                        ByVal strResponsable As String, _
                        ByVal strFechaSalida As String, _
                        ByVal intIndexDescripcion As Int16, _
                        ByVal intIndexCodigo As Int16, _
                        ByVal intIndexCantidad As Int16, _
                        ByVal dtDescripcion As DataTable, _
                        ByVal blnImpresionDirecta As Boolean)
        Dim X As Int16, _
                        Y As Int16, _
                        RowDatos As DataRow, _
                        strFolios As String = "", _
                        str_Datos As String = "", _
                        str_Pie As String = "", _
                        str_Cadena As String = "", _
                        str_Codigo As String = "", _
                        str_Cantidad As String = "", _
                        strComplemento As String = "", _
                        Suma As Double
        Try
            'Encabezado del ticket
            strSolicitudRef = "RRA: " & ProcesaCadena(strSolicitudRef)
            strFolioSalida = "SAL: " & ProcesaCadena(strFolioSalida)
            str_Cadena = ""
            strComplemento = ""
            For Y = 1 To 32 - (strSolicitudRef.Length + strFolioSalida.Length)
                strComplemento = strComplemento & " "
            Next
            str_Cadena = str_Cadena & strSolicitudRef & strComplemento & strFolioSalida & ControlChars.CrLf
            strFolioMaestro = "OT:  " & ProcesaCadena(strFolioMaestro)
            strVehiculo = "TV:  " & ProcesaCadena(strVehiculo)
            strComplemento = ""
            For Y = 1 To 32 - (strFolioMaestro.Length + strVehiculo.Length)
                strComplemento = strComplemento & " "
            Next
            str_Cadena = str_Cadena & strFolioMaestro & strComplemento & strVehiculo & ControlChars.CrLf
            str_Cadena = str_Cadena & "DIARIO: " & ProcesaCadena(strDiario) & ControlChars.CrLf
            str_Cadena = str_Cadena & "NUMERO: " & ProcesaCadena(strNumero) & ControlChars.CrLf
            If strMecanico.Length > 27 Then
                str_Cadena = str_Cadena & "MEC: " & ProcesaCadena(strMecanico.Substring(0, 26)) & ControlChars.CrLf
            Else
                str_Cadena = str_Cadena & "MEC: " & ProcesaCadena(strMecanico) & ControlChars.CrLf
            End If
            str_Cadena = str_Cadena & "FECHA SAL: " & strFechaSalida & ControlChars.CrLf
            For Y = 1 To 32
                str_Cadena = str_Cadena & "_"
            Next
            str_Cadena = str_Cadena & ControlChars.CrLf
            X = 0
            'Formateo de la Data
            For Each RowDatos In dtDescripcion.Rows
                X = X + 1
                'Numeracion de articulos
                strComplemento = ""
                For Y = X.ToString.Length To 3
                    strComplemento = strComplemento & "0"
                Next
                str_Cadena = str_Cadena & strComplemento & X.ToString & ") "
                'Descripcion del articulo
                If ProcesaCadena(RowDatos.Item(intIndexDescripcion).ToString).Length >= 21 Then
                    str_Cadena = str_Cadena & ProcesaCadena(RowDatos.Item(intIndexDescripcion).ToString.Substring(0, 20)) & ControlChars.CrLf
                Else
                    str_Cadena = str_Cadena & ProcesaCadena(RowDatos.Item(intIndexDescripcion).ToString) & ControlChars.CrLf
                End If
                strComplemento = ""
                'Codigo del articulo 
                For Y = ProcesaCadena(RowDatos.Item(intIndexCodigo).ToString).Length To 23
                    strComplemento = strComplemento & " "
                Next
                If ProcesaCadena(RowDatos.Item(intIndexCodigo).ToString).Length < 24 Then
                    str_Codigo = RTrim(LTrim(RowDatos.Item(intIndexCodigo).ToString))
                Else
                    str_Codigo = RTrim(LTrim(RowDatos.Item(intIndexCodigo).ToString)).Substring(0, 23)
                End If
                'Cantidad solicitada
                str_Cantidad = Format(CDbl(RowDatos.Item(intIndexCantidad).ToString), "#####.00")
                strComplemento = ""
                For Y = 1 To 32 - (str_Codigo.ToString.Length + str_Cantidad.ToString.Length)
                    strComplemento = strComplemento & " "
                Next
                str_Cadena = str_Cadena & str_Codigo & strComplemento & str_Cantidad & ControlChars.CrLf
                Suma = Suma + CType(RTrim(LTrim(RowDatos.Item(intIndexCantidad).ToString)), Double)
            Next
            For Y = 1 To 32
                str_Cadena = str_Cadena & "_"
            Next
            str_Cadena = str_Cadena & ControlChars.CrLf
            strComplemento = ""

            For Y = 1 To 32 - (X.ToString.Length + Suma.ToString.Length)
                strComplemento = strComplemento & " "
            Next
            str_Cadena = str_Cadena & ControlChars.CrLf & ControlChars.CrLf & "Totales" & ControlChars.CrLf
            str_Cadena = str_Cadena & X.ToString & " Partidas" & ControlChars.CrLf
            str_Cadena = str_Cadena & Format(Suma, "#,###,####.00") & " Articulos" & ControlChars.CrLf
            For Y = 1 To 32
                str_Cadena = str_Cadena & "_"
            Next
            str_Cadena = str_Cadena & ControlChars.CrLf
            If strResponsable.Length > 29 Then
                str_Cadena = str_Cadena & strResponsable.Substring(0, 29) & ControlChars.CrLf
            Else
                str_Cadena = str_Cadena & strResponsable & ControlChars.CrLf
            End If
            str_Cadena = str_Cadena & ControlChars.CrLf & ControlChars.CrLf
            For Y = 1 To 32
                str_Cadena = str_Cadena & "_"
            Next
            str_Cadena = str_Cadena & ControlChars.CrLf
            For Y = 1 To 32
                str_Cadena = str_Cadena & "_"
            Next
            str_Cadena = str_Cadena & ControlChars.CrLf
            'Guardando el texto en una variable local
            StrToPrn = str_Cadena
            'Preparar la impresion e imprimir

            If blnImpresionDirecta = True Then
                SetPrintTicket()
            Else
                'obj_Ticket_Form = New frmTicket
                'CargarFormularioMDI_Child(obj_Ticket_Form, Main, , Entidad)
                'With obj_Ticket_Form
                '    .txtPreview.Text = str_Cadena
                '    .ShowDialog()
                'End With
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub Imprimir(ByVal strTicket As String)
        Try
            StrToPrn = strTicket
            SetPrintTicket()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    ''' <summary>
    ''' Reporteador Crystal central
    ''' </summary>
    ''' <param name="Reporte">
    ''' Nombre del reporte que se solicita
    ''' </param>
    ''' <param name="Parametros">
    ''' colleccion de parametros SQL necesarios para la generacion del reporte
    ''' </param>
    ''' <param name="DirectoImpresora">
    ''' determina si la impresion es directa (enviarla a la impresora predeterminada actual) o debe presentarse en pantalla antes de enviarse
    ''' </param>
    ''' <remarks></remarks>
    Public Sub Imprimir(ByVal Reporte As String, ByVal strPath As String, ByRef Parametros As Collection, ByVal DirectoImpresora As Boolean, ByRef FormaMDI As Form)
        Dim A As Integer
        Dim x As Int16
        Dim objCodificador As SOLink.clConectividad
        Try
            strPathReport = Nothing
            PathFinder = Nothing
            PathFinder = New SOLink.clConectividad
            With PathFinder
                '.Determinar_Rutas_RPTS()
                strRegReadUsuario = .CR_User_DB
                strRegReadPassword = .CR_Pass_DB
                Select Case strPath
                    Case Is = "MTTO"
                        With .Plug_Doc_Mtto
                            Select Case Reporte
                            End Select
                        End With
                    Case Is = "ALM"
                        With .Plug_Doc_Almacen
                            Select Case Reporte
                                Case Is = "Salidas"
                                    strPathReport = .GetValue("Salidas").ToString
                                Case Is = "Solicitudes"
                                    strPathReport = .GetValue("Solicitudes").ToString
                            End Select
                        End With
                    Case Is = "COM"
                        With .Plug_Doc_Compras
                            Select Case Reporte
                                Case Is = "Compra"
                                    strPathReport = .GetValue("Compras").ToString
                            End Select
                        End With
                End Select
            End With
            If strRegReadUsuario <> "" And strRegReadPassword <> "" And strPathReport <> "" Then
                objReport = Nothing
                objReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument
                'Definiendo la coleccion de parameter fields
                '********************************************************
                With objReport
                    .FileName = strPathReport
                    .SetDatabaseLogon(strRegReadUsuario, strRegReadPassword)
                    For x = 1 To Parametros.Count
                        A = x - 1
                        If objReport.ParameterFields.Item(A).ReportName = "" Then
                            objReport.SetParameterValue(A, Parametros.Item(x))
                        End If
                    Next
                End With
                If DirectoImpresora Then
                    'Impresion directa a impresora
                    objReport.PrintToPrinter(1, True, 0, 0)
                    Exit Sub
                Else
                    objFormaReporteador = Nothing
                    objFormaReporteador = New frmReporter
                    With objFormaReporteador
                        .Text = "Impresor central"
                        '.crvVisorCentral.ReportSource = objReport
                        .MdiParent = FormaMDI
                        .WindowState = FormWindowState.Maximized
                        .StartPosition = FormStartPosition.CenterScreen
                        .Show()
                    End With
                End If
            End If
        Catch ex As Exception
            Throw ex
        Finally
            objCodificador = Nothing
        End Try
    End Sub
    ''' <summary>
    ''' Selecciona una impresora previamente identificada como impresora de tickets, la coloca como predeterminada
    ''' y una vez usada regresa la impresora predeterminada anterior al cambio
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub SetPrintTicket()
        Dim WshNetwork As Object
        Dim Impresoras As String
        Dim strGetDefImpresora As String = ""
        Dim strSetImpresora As String = ""
        Dim blnImpresoraActiva As Boolean
        WshNetwork = Microsoft.VisualBasic.CreateObject("WScript.Network")
        Try
            'Obtenemos el valor de habilitado y el nombre preestablecido en el registro de windows de la impresora de tickets
            NivelAcceso = Security.Permissions.RegistryPermissionAccess.Read
            SecurityCard = New System.Security.Permissions.RegistryPermission(NivelAcceso, "HKEY_LOCAL_MACHINE\Software\SICOM")
            LlaveRegistro = Registry.LocalMachine.OpenSubKey("Software\SICOM\Conexiones")
            blnImpresoraActiva = CType(LlaveRegistro.GetValue("EnabledTicketPrinter"), Boolean)
            strNombreFuente = CType(LlaveRegistro.GetValue("PrintFontTK"), String)
            If blnImpresoraActiva.ToString = True Then
                strPrintName = CType(LlaveRegistro.GetValue("SwithcPrinter"), String)
                'Eliminamos y generamos un nuevo objeto de tipo printdocument
                prnTxt = Nothing
                prnTxt = New PrintDocument
                'Buscando impresora de tickets
                For Each Impresoras In PrinterSettings.InstalledPrinters
                    Debug.Print(InStr(Impresoras, strPrintName, CompareMethod.Text).ToString & Impresoras)
                    If InStr(Impresoras, strPrintName, CompareMethod.Text) <> 0 Then
                        strSetImpresora = Impresoras.ToString
                    End If
                Next
                'si el nombre de la impresora fue detectado continuamos con el proceso de 
                'impresion de lo contrario debemos generar un mensaje y salir
                If strSetImpresora <> "" Then
                    'Guardando nombre de impresora que actualmente este como predeterminada
                    strGetDefImpresora = prnTxt.PrinterSettings.PrinterName
                    'Colocar la impresora de tickets como predeterminada
                    WshNetwork.SetDefaultPrinter(strSetImpresora)
                    'crear el evento de impresion NOTA: la impresion convierte el texto en imagen
                    AddHandler prnTxt.PrintPage, AddressOf ImprimirTexto
                    prnTxt.PrinterSettings.Duplex = Duplex.Simplex
                    prnTxt.Print()
                    'Regresamos el nombre de la impresora predeterminada del equipo
                    If strGetDefImpresora <> "" Then
                        WshNetwork.SetDefaultPrinter(strGetDefImpresora)
                    End If
                Else
                    'Mandar exception con mensaje de no encontrada
                    MessageBox.Show("No se encontró la impresora de Tickets" & _
                                    Chr(13) & Chr(13) & _
                                    "Verifique que la impresora con el nombre: " & _
                                    strPrintName & _
                                    " exista", _
                                    "Atencion", _
                                    MessageBoxButtons.OK, _
                                    MessageBoxIcon.Exclamation)
                End If
            Else
                'Mandar exception con mensaje de no encontrada
                MessageBox.Show("La impresora de Tickets esta inhabilitada" & _
                                Chr(13) & Chr(13) & _
                                "Es necesario habilitar la impresora: " & _
                                strPrintName & _
                                " para poder imprimir tikets", _
                                "Atencion", _
                                MessageBoxButtons.OK, _
                                MessageBoxIcon.Exclamation)
            End If
        Catch ex As Exception
            Throw ex
        Finally
            WshNetwork = Nothing
            prnTxt = Nothing
        End Try
    End Sub
    ''' <summary>
    ''' Imprime el contenido de la variable privada StrToPrn de tipo string, Complemento del ticket
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ImprimirTexto(ByVal sender As System.Object, ByVal ePrint As PrintPageEventArgs)
        Try
            'Establecemos el tipo, el tamaño y estilo de fuente 
            FontPrn = New Font(strNombreFuente, 9, FontStyle.Regular)
            'Preparamos el grafico que se enviará a la impresora de tickets
            ePrint.Graphics.DrawString(StrToPrn, FontPrn, Brushes.Black, 0, 0)
            'indicamos que solo se envie una vez la impresion 
            ePrint.HasMorePages = False
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    ''' <summary>
    ''' Limpia las casillas de verificacion de los Treeview de forma recursiva
    ''' </summary>
    ''' <param name="ColNodeTreeView">
    ''' Coleccion primaria de nodos
    ''' </param>
    ''' <remarks></remarks>
    Public Sub LimpiaNodosTreeView(ByRef ColNodeTreeView As TreeNodeCollection)
        Try
            For Each nodo As TreeNode In ColNodeTreeView
                If nodo.Nodes.Count <> 0 Then
                    LimpiaNodosTreeView(nodo.Nodes)
                Else
                    If nodo.Checked = True Then
                        nodo.Checked = False
                    End If
                End If
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub Cambia_Valores_Multiple_Renglon(ByVal strReferencia As String, ByRef Tabla As DataTable)
        Try

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    ''' <summary>
    ''' Exporta un data table a excel sin formato y sin omitir nombres de columna
    ''' </summary>
    ''' <param name="pDataTable">
    ''' Datos en forma de un data table (puede usarce el datasource de los grids)
    ''' </param>
    ''' <param name="strDefaultName">
    ''' Nombre del archivo de Excel a crear
    ''' </param>
    ''' <remarks></remarks>
    Public Sub DataTableToExcel(ByRef pDataTable As DataTable, Optional ByVal strDefaultName As String = "")
        Dim strFileTemp As String = "", _
            strFilexls As String = "", _
            Control_SaveFileDialog As New System.Windows.Forms.SaveFileDialog, _
            strCelda As String = "", _
            dc As DataColumn
        Try
            If Not (pDataTable Is Nothing) Then
                If pDataTable.Rows.Count < 65534 Then
                    With Control_SaveFileDialog
                        .Reset()
                        .Title = "Exportar a excel"
                        .DefaultExt = "xls"
                        .Filter = ("Microsoft Excel(*.xls)|*.xls")
                        .FileName = strDefaultName & "_" & _
                                    UCase(Now.Day.ToString) & _
                                    Format(Now, "MMM") & _
                                    Now.Year.ToString
                        .ShowDialog()
                        If .FileName.ToString.Trim <> "" Then
                            strFileTemp = Path.GetTempFileName()
                            FileOpen(1, strFileTemp, OpenMode.Output)
                            For Each dc In pDataTable.Columns
                                strCelda &= dc.Caption & Microsoft.VisualBasic.ControlChars.Tab
                            Next
                            PrintLine(1, strCelda)
                            Dim i As Integer = 0
                            Dim dr As DataRow
                            For Each dr In pDataTable.Rows
                                i = 0 : strCelda = ""
                                For Each dc In pDataTable.Columns
                                    If Not IsDBNull(dr(i)) Then
                                        strCelda &= CStr(dr(i)) & Microsoft.VisualBasic.ControlChars.Tab
                                    Else
                                        strCelda &= Microsoft.VisualBasic.ControlChars.Tab
                                    End If
                                    i += 1
                                Next
                                PrintLine(1, strCelda)
                            Next
                            FileClose(1)
                            File.WriteAllText(.FileName, File.ReadAllText(strFileTemp))
                            File.Delete(strFileTemp)
                        End If
                    End With
                Else
                    MessageBox.Show("Los datos exceden el tamaño de la hoja de excel", _
                                    "Informe", _
                                    MessageBoxButtons.OK, _
                                    MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("No hay datos que exportar", _
                                "Informe", _
                                MessageBoxButtons.OK, _
                                MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            Throw ex
        Finally
            Control_SaveFileDialog = Nothing
        End Try
    End Sub
    ''' <summary>
    ''' Filtra las columnas para su exportación a excel
    ''' no muestra identificadores globales ni columnas invisibles
    ''' </summary>
    ''' <param name="Grid"></param>
    ''' <remarks></remarks>
    Public Sub Filtra_Cols(ByRef Grid As C1.Win.C1TrueDBGrid.C1TrueDBGrid)
        Dim int_L_Index_No_Visible As Int16, _
            str_L_ColName As String, _
            int_L_Col2 As Int16, _
            int_L_PrefijoOid_Encontrado As Int16

        Try
            dt_Tabla_Reflejo_Cols_Visibles = Nothing
            dt_Tabla_Reflejo_Cols_Visibles = CType(Grid.DataSource, DataTable).Copy
            dt_Tabla_Reflejo_Cols_Visibles.PrimaryKey = Nothing
            For Each DC As C1.Win.C1TrueDBGrid.C1DisplayColumn In Grid.Splits(0).DisplayColumns
                int_L_PrefijoOid_Encontrado = -1
                If DC.Visible = False Then
                    int_L_Index_No_Visible = Grid.Splits(0).DisplayColumns.IndexOf(DC)
                    str_L_ColName = CType(Grid.DataSource, DataTable).Columns.Item(int_L_Index_No_Visible).ColumnName
                    'En la copia, eliminamos las columnas que no son visibles en el grid padre
                    int_L_PrefijoOid_Encontrado = InStr(str_L_ColName, "ID", CompareMethod.Text)
                    If int_L_PrefijoOid_Encontrado > 0 Then
                        'En este caso, se trata de columnas de uniqueidentifiers, por eso la eliminamos
                        For Each ColD As DataColumn In dt_Tabla_Reflejo_Cols_Visibles.Columns
                            If ColD.ColumnName = str_L_ColName Then
                                dt_Tabla_Reflejo_Cols_Visibles.Columns.Remove(ColD)
                                Exit For
                            End If
                        Next
                    End If
                End If
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    ''' <summary>
    ''' Función auxiliar, sólo visible para el módulo
    ''' oculta las columnas que el usuario no necesita ver
    ''' </summary>
    ''' <param name="Tabla">
    ''' Tabla de la cual ocultaremos las columnas
    ''' </param>
    ''' <param name="Esquema">
    ''' De acuerdo al tipo de documento, algunas columnas serán visibles
    ''' </param>
    ''' <remarks></remarks>
    Private Sub Ocultar_Columnas(ByRef Tabla As DataTable, ByVal Esquema As String)
        Try
            With Tabla
                .Columns.Item(0).ColumnName += "_0v"
                'Cantidad solicitada
                .Columns.Item(5).ColumnName += ALINEACION_DE
                Select Case Esquema
                    Case Is = "Cotizacion"
                        'Precio tope
                        .Columns.Item(6).ColumnName += "_0v"
                        'Precio compra
                        .Columns.Item(8).ColumnName += "_0v"
                        'Descuento
                        .Columns.Item(10).ColumnName += "_0v"
                    Case Is = "Compra"
                        .Columns.Item(1).ColumnName += "_0v"
                        .Columns.Item(6).ColumnName += ALINEACION_DE
                        .Columns.Item(7).ColumnName += ALINEACION_DE
                        .Columns.Item(8).ColumnName += ALINEACION_DE
                        .Columns.Item(9).ColumnName += "_0v"
                        .Columns.Item(10).ColumnName += ALINEACION_DE
                        .Columns.Item(11).ColumnName += "_0v"
                        .Columns.Item(17).ColumnName += "_0v"
                End Select
                '    .Columns.Item(7).ColumnName += "_0v"
                '   .Columns.Item(9).ColumnName += "_0v"
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub ValidandoCombo(ByRef Componente As Windows.Forms.ComboBox, Optional ByRef ComboDependiente As Windows.Forms.ComboBox = Nothing)
        Try
            With Componente
                If .SelectedValue Is Nothing Then
                    .SelectedIndex = -1
                    .Text = ""
                    If Not (ComboDependiente Is Nothing) Then
                        ResetCombo(ComboDependiente)
                    End If
                End If
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub Llena_Combo_Base_Array(ByRef UI_Combo As Windows.Forms.ComboBox, _
                                      ByRef Arreglo As ArrayList, _
                                      Optional ByVal Todos As Boolean = False)
        Try

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    ''' <summary>
    ''' Limpia el texto en un combo con un valor inválido
    ''' </summary>
    ''' <param name="Combo_Invalido"></param>
    ''' <remarks></remarks>
    Public Sub LimpiaCombo_Invalido(ByRef Combo_Invalido As ComboBox)
        Try
            With Combo_Invalido
                If .SelectedValue Is Nothing Then
                    .Text = ""
                End If
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    ''' <summary>
    ''' Esta función envía el rango seleccionado al clipboard para que pueda ser pegado en excel
    ''' o en otra parte, sólo copiaremos las columnas visibles.
    ''' </summary>
    ''' <param name="Grid_Host">
    ''' Grid que contiene los datos seleccionados
    ''' </param>
    ''' <remarks></remarks>
    Public Sub Copy_To_Clip_Board(ByRef Grid_Host As C1.Win.C1TrueDBGrid.C1TrueDBGrid)
        Dim int_L_Renglon As Int16, _
            int_L_RowBkmk As Int16, _
            int_L_Column As Int16, _
            str_L_Valor As String, _
            strTemp As String, _
            row As Integer, _
            col As C1.Win.C1TrueDBGrid.C1DataColumn, _
            cols As Integer, _
            rows As Integer, _
            int_L_IDX_ColVis As Integer, _
            str_L_Text_Encabezados As String, _
            str_L_Cleaner As String, _
            bln_L_IsChkBox As Boolean
        Try
            '---------------------------------------------------------------------
            strTemp = Nothing
            str_L_Text_Encabezados = Nothing
            With Grid_Host

                If Not (.DataSource Is Nothing) Then
                    If .SelectedRows.Count > 0 Then
                        'Determinamos el nombre de los encabezados del grid para hacer
                        'mas facil la lectura de la información.
                        '*************************************************************
                        For Each col In .SelectedCols
                            int_L_IDX_ColVis = .Columns.IndexOf(col)
                            'Determinamos si esta columna tiene un checkbox
                            bln_L_IsChkBox = (.Columns.Item(int_L_IDX_ColVis).ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.CheckBox)
                            With .Splits(0).DisplayColumns.Item(int_L_IDX_ColVis)
                                If .Visible And bln_L_IsChkBox = False Then
                                    str_L_Text_Encabezados = str_L_Text_Encabezados & .Name.ToString & vbTab
                                End If
                            End With
                        Next
                        '*************************************************************
                        str_L_Text_Encabezados = str_L_Text_Encabezados & vbCrLf
                        strTemp = str_L_Text_Encabezados
                        For Each row In .SelectedRows
                            For Each col In .SelectedCols
                                int_L_IDX_ColVis = .Columns.IndexOf(col)
                                bln_L_IsChkBox = (.Columns.Item(int_L_IDX_ColVis).ValueItems.Presentation = C1.Win.C1TrueDBGrid.PresentationEnum.CheckBox)
                                If .Splits(0).DisplayColumns.Item(int_L_IDX_ColVis).Visible And _
                                    bln_L_IsChkBox = False Then
                                    str_L_Cleaner = col.CellText(row).ToString
                                    str_L_Cleaner = Remueve_No_Imprimibles(str_L_Cleaner)
                                    strTemp = strTemp & str_L_Cleaner & vbTab
                                End If
                            Next
                            strTemp = strTemp & vbCrLf
                        Next
                        System.Windows.Forms.Clipboard.SetDataObject(strTemp, False)
                    Else
                        'Verificamos si es un renglon valido, para copiar 
                        'el contenido de la celda
                        int_L_Renglon = .Row
                        int_L_RowBkmk = .RowBookmark(int_L_Renglon)
                        If int_L_RowBkmk <> -1 Then
                            int_L_Column = .Col
                            str_L_Valor = CType(.DataSource, DataTable).Rows.Item(int_L_RowBkmk).Item(int_L_Column).ToString
                            If Not (str_L_Valor Is Nothing) Then
                                System.Windows.Forms.Clipboard.SetDataObject(str_L_Valor, True)
                            End If
                        End If
                    End If
                Else
                    Beep()
                End If
            End With
            '---------------------------------------------------------------------
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub Con_Focus(ByVal sender As Object, ByVal e As System.EventArgs)
        Try
            DirectCast(sender, TextBox).BackColor = Color.Yellow
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub Sin_Focus(ByVal sender As Object, ByVal e As System.EventArgs)
        Try
            DirectCast(sender, TextBox).BackColor = Color.White
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub ResetCombo(ByRef Componente As Windows.Forms.ComboBox, Optional ByVal Activar As Boolean = False)
        Try
            With Componente
                .DataSource = Nothing
                .Text = ""
                .Enabled = Activar
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    ''' <summary>
    ''' Este procedimiento cambia el boton "CancelButton" en el formulario activo de acuerdo al tab  seleccionado
    ''' </summary>
    ''' <param name="Formulario">
    '''Formulario Donde reside el tab
    ''' </param>
    ''' <param name="Etiqueta">
    ''' Tab en donde está los botones a buscar y establecer
    ''' </param>
    ''' <remarks></remarks>
    Public Sub Establece_Botones_Control(ByRef Formulario As Windows.Forms.Form, ByRef Etiqueta As Windows.Forms.TabControl)
        Try
            For Each obj_Control As Object In Etiqueta.SelectedTab.Controls
                If TypeName(obj_Control) = "Button" Then
                    If DirectCast(obj_Control, Windows.Forms.Button).Text Like "*ancel*" Then
                        Formulario.CancelButton = DirectCast(obj_Control, Button)
                        Exit Sub
                    End If
                End If
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub Gestionar_Export(ByRef Boton As System.Windows.Forms.Button, _
                                ByRef Forma As System.Windows.Forms.Form,
                                ByVal Grilla As C1.Win.C1TrueDBGrid.C1TrueDBGrid)
        Try
            If Not (Boton Is Nothing) And Not (Grilla Is Nothing) And Not (Forma Is Nothing) Then
                If Boton.Text = "Exportar" Then
                    If Not (Grilla.DataSource Is Nothing) Then
                        If DirectCast(Grilla.DataSource, DataTable).Rows.Count > 0 Then
                            Expo_Grid_Excel(Grilla, Forma)
                            Reset_Grid(Grilla)
                        Else
                            With Boton
                                .Text = "Consulta"
                            End With
                        End If                        
                    End If                    
                End If
            End If
        Catch ex As Exception
            Activar_Interface(Forma, True)
            Throw ex
        End Try
    End Sub
    Public Sub Export_Manager(ByRef Datos As DataTable, _
                              ByRef BotonCarga As Windows.Forms.Button, _
                              ByRef BotonExporta As Windows.Forms.Button, _
                              ByRef Rejilla As C1.Win.C1TrueDBGrid.C1TrueDBGrid, _
                              ByVal Fase As String, _
                              ByRef Formulario As Windows.Forms.Form)
        Try
            Select Case Fase
                Case Is = "PRP"
                    'Preparamos todo para poder exportar
                    If Not (Datos Is Nothing) Then
                        If Datos.Rows.Count > 0 Then
                            Grid_Dinamico(Rejilla, Datos, True)
                        End If
                        BotonCarga.Enabled = False
                        With BotonExporta
                            .Visible = True
                            .Enabled = True
                        End With
                        Rejilla.Enabled = True
                    End If
                Case Is = "EXP"
                    Expo_Grid_Excel(Rejilla, Formulario)
                    'ya exportamos, regresamos las cosas a la normalidad
                    'Reset_Grid(Rejilla)
                    With BotonExporta
                        .Visible = False
                        .Enabled = False
                    End With
                    BotonCarga.Enabled = True
            End Select
        Catch ex As Exception
            With BotonExporta
                .Visible = False
                .Enabled = False
            End With
            Throw ex
        End Try
    End Sub    
#End Region
#Region "Objetos"
    Public Sub Tabla_Volatil(ByRef Variable As DataTable, ByRef col_columnas As Collection)
        Dim dc_l_columna As DataColumn
        Try
            If Not (Variable Is Nothing) And _
                Not (col_columnas Is Nothing) Then
                For Each col_name As String In col_columnas
                    dc_l_columna = New DataColumn
                    dc_l_columna.ColumnName = col_name
                    Variable.Columns.Add(dc_l_columna)
                    dc_l_columna = Nothing
                Next
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
#End Region
#End Region
End Module
