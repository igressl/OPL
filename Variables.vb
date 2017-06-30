Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Module Variables
#Region "Constantes"
    Friend Const CONFIRMACION As String = "CONFIRME"
    Friend Const VERIFICACION As String = "VERIFIQUE"
    Friend Const NO_VISIBLE As String = "_0v"
    Friend Const ALINEACION_DE As String = "_D1"
    Friend Const ALINEACION_IZ As String = "_I1"
    Friend Const CENTRAR As String = "_C1"
    Friend Const FORM_MONEY As String = "_F$"
    Friend Const FORM_NUMBER5 As String = "_F#5"
    Friend Const FORM_NUMBER2 As String = "_F#2"
    Friend Const CHECK_BOX As String = "_Chk"
    Friend Const AGRUPACELDAS As String = "_A1"
    Friend Const DESBLOQUEAR As String = "_UnLock"
    Friend Const CENTRO As C1.Win.C1TrueDBGrid.AlignHorzEnum = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
    Friend Const DERECHA As C1.Win.C1TrueDBGrid.AlignHorzEnum = C1.Win.C1TrueDBGrid.AlignHorzEnum.Far
    Friend Const IZQUIERDA As C1.Win.C1TrueDBGrid.AlignHorzEnum = C1.Win.C1TrueDBGrid.AlignHorzEnum.Near
    Friend Const CHECKBOX As C1.Win.C1TrueDBGrid.PresentationEnum = C1.Win.C1TrueDBGrid.PresentationEnum.CheckBox
    Friend Const SI As Windows.Forms.DialogResult = DialogResult.Yes
    Friend Const NO As Windows.Forms.DialogResult = DialogResult.No
    Friend Const Aceptar As Windows.Forms.DialogResult = DialogResult.OK
    Friend Const Cancelar As Windows.Forms.DialogResult = DialogResult.Cancel
    Friend Const Pregunta As MessageBoxButtons = MessageBoxButtons.YesNo
    Friend Const OK As MessageBoxButtons = MessageBoxButtons.OK
    Friend Const QU As MessageBoxIcon = MessageBoxIcon.Question
    Friend Const AVISO As MessageBoxIcon = MessageBoxIcon.Information
    Friend Const ALL_OPT As String = "Todas"
    Friend Const VOID_DOCUMENT = "NULO"
    Friend Const TOPEPRECIO As Double = 1000000
    Friend Const IDX_OUT_INTERVAL As Integer = -1
    Friend Const PREPARACION_EXPORTAR As String = "PRP"
    Friend Const EXPORTACION_COMPLETA As String = "EXP"
#End Region
#Region "Variables generales"
    'Friend objAlmacen As BOStorage.Almacen, _
    '       objAnaquel As BOStorage.Anaquel, _
    '       objGaveta As BOStorage.Gaveta, _
    '       objFamilia As BOStorage.Familia, _
    '       objSubFamilia As BOStorage.subFamilia, _
    '       objMedidas As BOStorage.Auxiliar, _
    '       objDato As SIMA_NET.clInfoItem, _
    '       objArticulo As BOStorage.Articulo, _
    '       objMarca As BOStorage.Marca, _
    '       objCargador As BOStorage.clCommon, _
    '       objEntidad As clObjeto, _
    '       objSolRefs As BOStorage.Solicitud_Refs, _
    '       objSolCompra As BOStorage.SolicitudCompra, _
    '       obj_Compra As BOProvisioning.OrdenCompra, _
    '       objCotizacion As BOProvisioning.Precotizacion, _
    '       Comodin As Objeto_Comodin, _
    '       obj_L_Cargador As BOMaintenance.Cargador, _
    '       obj_G_Transferencia As BOStorage.Transferencia, _
    '       objMovimiento As BOStorage.Movimiento, _
    '       objSolicitudCompra As BOStorage.SolicitudCompra, _
    '       obj_Consulta_Ordenes_Abastecimiento As BOStorage.SolicitudCompra, _
    Friend strFileNameXport As String, _
           objDialog_SvFile As Windows.Forms.SaveFileDialog, _
           blnVaribleBooleana As Boolean, _
           strVariable_String As String, _
           intVar_Entera As Int16, _
           objArray As ArrayList, _
           strErr_Log As String, _
           objArrListaMnus As ArrayList, _
           Entidad As SOLink.clUsuario, _
           Entidad_Autorizacion As SOLink.clUsuario, _
           objManagement As SOLink.Management, _
           Tabla_Items_Sol_Refs As DataTable, _
           dtUnidades As DataTable, _
           dtCatalogo_Articulos_Central As System.Data.DataTable, _
           str_Main_Title As String, _
           dt_Repositorio_Seleccion As Data.DataTable, _
           g_obj_Coleccion_Seleccion As Collection, _
           sht_Index_Row_Demandante As Short, _
           objReporte As CrystalDecisions.CrystalReports.Engine.ReportDocument, _
           strVar_String As String, _
           dt_Items_Movimientos As System.Data.DataTable, _
           obj_Grid_SolRefs_Referencia As C1.Win.C1TrueDBGrid.C1TrueDBGrid, _
           Tabla_Items_OrdenAbastecimiento As System.Data.DataTable, _
           blnRemoto As Boolean, _
           objNotificador As Form, _
           lbl_Etiqueta_Aviso As System.Windows.Forms.Label, _
           g_dt_Unidades As System.Data.DataTable, _
           dtUnidades_BKP As DataTable, _
           dtStats_Partidas As DataTable, _
           dt_Pedido_SolRefa As System.Data.DataTable, _
           dv As System.Data.DataView, _
           cm As CurrencyManager, _
           foundRow As DataRow, _
           intIndexRenglon As Integer, _
           dtTabla_Cotizacion As System.Data.DataTable, _
           dtTabla_Auxiliar As System.Data.DataTable, _
           dtFamilias_Aux As System.Data.DataTable, _
           obj_TablaFiltrada_Cotizacion As System.Data.DataTable, _
           obj_TablaFiltrada_Compra As System.Data.DataTable, _
           dt_L_Tabla_Instancia As System.Data.DataTable, _
           dt_Tabla_Reflejo_Cols_Visibles As DataTable, _
           bln_Modo_Autorizacion As Boolean, _
           dt_Ubicaciones_Usuario_Almacen As DataTable, _
           arr_Arreglo_Datos As ArrayList, _
           str_G_Caption_txt_TS As String, _
           str_G_Importe_Partidas_General As String, _
           str_G_Cantidad_Partidas_General As String, _
           dt_G_Tabla_Aux As DataTable, _
           obj_G_Traveler_Menu As System.Windows.Forms.ContextMenuStrip, _
           bln_G_Mod_Edicion As Boolean, _
           str_L_TipoMov_Adicion_Grid As String, _
           str_G_Motivo_Rechazo_Adicion As String, _
           ControlBag, ParameterBag As Collection, _
           obj_Fuente As Font, _
           objEntidad As clObjeto, _
           dt_m_empresa As DataTable, _
           obj_g_almacen As BoAlmacenSH.Almacen, _
           obj_g_anaquel As BoAlmacenSH.Anaquel, _
           obj_g_ubicacion As BoAlmacenSH.Ubicacion, _
           obj_g_combustible As BOVehicleSH.TipoCombustible, _
           obj_g_tipo_veh As BOVehicleSH.TipoVehiculo
#End Region
#Region "Variables de formularios"    
    Friend obj_Main As MDIMaster,
         objfrmCat As frmCatalogos, _
         objAlms As frmAlmacen, _
         obj_match As frm_matchs
#End Region
End Module
