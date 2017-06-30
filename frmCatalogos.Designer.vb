<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCatalogos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCatalogos))
        Me.tabCat_Generales = New System.Windows.Forms.TabControl()
        Me.tbpMarca = New System.Windows.Forms.TabPage()
        Me.cmdXporMarca = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdCancelMarca = New System.Windows.Forms.Button()
        Me.imgIconos = New System.Windows.Forms.ImageList(Me.components)
        Me.cmdProcessMarca = New System.Windows.Forms.Button()
        Me.txtMarca = New System.Windows.Forms.TextBox()
        Me.tdbgMarca = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.tbpTipoVehiculo = New System.Windows.Forms.TabPage()
        Me.cmdKill = New System.Windows.Forms.Button()
        Me.tdbgTiposVehiculo = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.cmdXprtTiVh = New System.Windows.Forms.Button()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblUso = New System.Windows.Forms.Label()
        Me.lblCombustible = New System.Windows.Forms.Label()
        Me.cmdCancelTipoVeh = New System.Windows.Forms.Button()
        Me.cmdProcesarTipoVeh = New System.Windows.Forms.Button()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.cboUso = New System.Windows.Forms.ComboBox()
        Me.cboCombustible = New System.Windows.Forms.ComboBox()
        Me.tbpUnidades = New System.Windows.Forms.TabPage()
        Me.cmdXportUns = New System.Windows.Forms.Button()
        Me.lblAño = New System.Windows.Forms.Label()
        Me.lblModelo = New System.Windows.Forms.Label()
        Me.numAño = New System.Windows.Forms.NumericUpDown()
        Me.txtModelo = New System.Windows.Forms.TextBox()
        Me.lblMatricula = New System.Windows.Forms.Label()
        Me.txtMatricula = New System.Windows.Forms.TextBox()
        Me.lblMarca = New System.Windows.Forms.Label()
        Me.cboMarca = New System.Windows.Forms.ComboBox()
        Me.cmdXprtVehiculo = New System.Windows.Forms.Button()
        Me.lblChasis = New System.Windows.Forms.Label()
        Me.lblMotor = New System.Windows.Forms.Label()
        Me.lblEco = New System.Windows.Forms.Label()
        Me.lblTipoVehiculo = New System.Windows.Forms.Label()
        Me.cmdKillUnit = New System.Windows.Forms.Button()
        Me.cmdCancelarVehiculo = New System.Windows.Forms.Button()
        Me.cmdProcesarVehiculo = New System.Windows.Forms.Button()
        Me.txtSerieChasis = New System.Windows.Forms.TextBox()
        Me.txtSerieMotor = New System.Windows.Forms.TextBox()
        Me.txtEco = New System.Windows.Forms.TextBox()
        Me.cboTipoUnidad = New System.Windows.Forms.ComboBox()
        Me.tdbgUnidades = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.tbpConfs = New System.Windows.Forms.TabPage()
        Me.tabDetailsConjs = New System.Windows.Forms.TabControl()
        Me.stbpConjuntos = New System.Windows.Forms.TabPage()
        Me.cmdKillConj = New System.Windows.Forms.Button()
        Me.lblConjunto = New System.Windows.Forms.Label()
        Me.lblTipoVehiculo_C = New System.Windows.Forms.Label()
        Me.cmdProces_conjunto = New System.Windows.Forms.Button()
        Me.cmdCancel_Conj = New System.Windows.Forms.Button()
        Me.cmdQueryC = New System.Windows.Forms.Button()
        Me.cmdXport_C = New System.Windows.Forms.Button()
        Me.txtSCConj = New System.Windows.Forms.TextBox()
        Me.cboTVConjuntos = New System.Windows.Forms.ComboBox()
        Me.TDbgConjuntos = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.stbpSubconjuntos = New System.Windows.Forms.TabPage()
        Me.cmdQueySubs = New System.Windows.Forms.Button()
        Me.cdmXportSbs = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmdProcesar_Subs = New System.Windows.Forms.Button()
        Me.cmdCancelSubs = New System.Windows.Forms.Button()
        Me.tdbgSubs = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.txtSubConjunto = New System.Windows.Forms.TextBox()
        Me.cboConjunto_SBS = New System.Windows.Forms.ComboBox()
        Me.cboTipoVehiculoSBS = New System.Windows.Forms.ComboBox()
        Me.stbpReparaciones = New System.Windows.Forms.TabPage()
        Me.tabMode = New System.Windows.Forms.TabControl()
        Me.tbpOprFix = New System.Windows.Forms.TabPage()
        Me.cmdModify_Rep_Cond = New System.Windows.Forms.Button()
        Me.cmdOperFix_Process = New System.Windows.Forms.Button()
        Me.cmdOperFix_Cancel = New System.Windows.Forms.Button()
        Me.lblOpr_FixDesc = New System.Windows.Forms.Label()
        Me.txtFix_Description = New System.Windows.Forms.TextBox()
        Me.lblOpr_SubC = New System.Windows.Forms.Label()
        Me.lblOpr_Conj = New System.Windows.Forms.Label()
        Me.lblOpr_TV = New System.Windows.Forms.Label()
        Me.cboSubConjuntoFix = New System.Windows.Forms.ComboBox()
        Me.cboConjunto_Fix = New System.Windows.Forms.ComboBox()
        Me.cboTipoVehiculo_Fix = New System.Windows.Forms.ComboBox()
        Me.tbpQryFix = New System.Windows.Forms.TabPage()
        Me.cmdStarterTV = New System.Windows.Forms.Button()
        Me.imlSm = New System.Windows.Forms.ImageList(Me.components)
        Me.cmdQryFix_Xport = New System.Windows.Forms.Button()
        Me.cmdQryFixQry = New System.Windows.Forms.Button()
        Me.lblQry_SubC = New System.Windows.Forms.Label()
        Me.lblQry_Conj = New System.Windows.Forms.Label()
        Me.lblQry_TV = New System.Windows.Forms.Label()
        Me.cboQry_Fix_SubC = New System.Windows.Forms.ComboBox()
        Me.cboQry_Fix_Conj = New System.Windows.Forms.ComboBox()
        Me.cboQry_Fix_Tv = New System.Windows.Forms.ComboBox()
        Me.tdbgFix_Qry = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.tabCat_Generales.SuspendLayout()
        Me.tbpMarca.SuspendLayout()
        CType(Me.tdbgMarca, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbpTipoVehiculo.SuspendLayout()
        CType(Me.tdbgTiposVehiculo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbpUnidades.SuspendLayout()
        CType(Me.numAño, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tdbgUnidades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbpConfs.SuspendLayout()
        Me.tabDetailsConjs.SuspendLayout()
        Me.stbpConjuntos.SuspendLayout()
        CType(Me.TDbgConjuntos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.stbpSubconjuntos.SuspendLayout()
        CType(Me.tdbgSubs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.stbpReparaciones.SuspendLayout()
        Me.tabMode.SuspendLayout()
        Me.tbpOprFix.SuspendLayout()
        Me.tbpQryFix.SuspendLayout()
        CType(Me.tdbgFix_Qry, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabCat_Generales
        '
        Me.tabCat_Generales.Controls.Add(Me.tbpMarca)
        Me.tabCat_Generales.Controls.Add(Me.tbpTipoVehiculo)
        Me.tabCat_Generales.Controls.Add(Me.tbpUnidades)
        Me.tabCat_Generales.Controls.Add(Me.tbpConfs)
        Me.tabCat_Generales.ImageList = Me.imlSm
        Me.tabCat_Generales.Location = New System.Drawing.Point(15, 3)
        Me.tabCat_Generales.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tabCat_Generales.Name = "tabCat_Generales"
        Me.tabCat_Generales.SelectedIndex = 0
        Me.tabCat_Generales.Size = New System.Drawing.Size(744, 451)
        Me.tabCat_Generales.TabIndex = 0
        '
        'tbpMarca
        '
        Me.tbpMarca.Controls.Add(Me.cmdXporMarca)
        Me.tbpMarca.Controls.Add(Me.Label1)
        Me.tbpMarca.Controls.Add(Me.cmdCancelMarca)
        Me.tbpMarca.Controls.Add(Me.cmdProcessMarca)
        Me.tbpMarca.Controls.Add(Me.txtMarca)
        Me.tbpMarca.Controls.Add(Me.tdbgMarca)
        Me.tbpMarca.ImageIndex = 155
        Me.tbpMarca.Location = New System.Drawing.Point(4, 24)
        Me.tbpMarca.Name = "tbpMarca"
        Me.tbpMarca.Size = New System.Drawing.Size(736, 423)
        Me.tbpMarca.TabIndex = 2
        Me.tbpMarca.Text = "Marca"
        Me.tbpMarca.UseVisualStyleBackColor = True
        '
        'cmdXporMarca
        '
        Me.cmdXporMarca.Location = New System.Drawing.Point(506, 382)
        Me.cmdXporMarca.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdXporMarca.Name = "cmdXporMarca"
        Me.cmdXporMarca.Size = New System.Drawing.Size(117, 30)
        Me.cmdXporMarca.TabIndex = 16
        Me.cmdXporMarca.Text = "Consultar"
        Me.cmdXporMarca.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 15)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Marca"
        '
        'cmdCancelMarca
        '
        Me.cmdCancelMarca.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.cmdCancelMarca.ImageIndex = 72
        Me.cmdCancelMarca.ImageList = Me.imgIconos
        Me.cmdCancelMarca.Location = New System.Drawing.Point(186, 41)
        Me.cmdCancelMarca.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdCancelMarca.Name = "cmdCancelMarca"
        Me.cmdCancelMarca.Size = New System.Drawing.Size(110, 46)
        Me.cmdCancelMarca.TabIndex = 14
        Me.cmdCancelMarca.Text = "Cancelar"
        Me.cmdCancelMarca.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.cmdCancelMarca.UseVisualStyleBackColor = True
        '
        'imgIconos
        '
        Me.imgIconos.ImageStream = CType(resources.GetObject("imgIconos.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgIconos.TransparentColor = System.Drawing.Color.Transparent
        Me.imgIconos.Images.SetKeyName(0, "add.ico")
        Me.imgIconos.Images.SetKeyName(1, "add-favorite.ico")
        Me.imgIconos.Images.SetKeyName(2, "add-file.ico")
        Me.imgIconos.Images.SetKeyName(3, "add-folder.ico")
        Me.imgIconos.Images.SetKeyName(4, "add-note.ico")
        Me.imgIconos.Images.SetKeyName(5, "add-printer.ico")
        Me.imgIconos.Images.SetKeyName(6, "add-star.ico")
        Me.imgIconos.Images.SetKeyName(7, "add-user.ico")
        Me.imgIconos.Images.SetKeyName(8, "alert.ico")
        Me.imgIconos.Images.SetKeyName(9, "annexed.ico")
        Me.imgIconos.Images.SetKeyName(10, "back.ico")
        Me.imgIconos.Images.SetKeyName(11, "back-.ico")
        Me.imgIconos.Images.SetKeyName(12, "back-2.ico")
        Me.imgIconos.Images.SetKeyName(13, "back-3.ico")
        Me.imgIconos.Images.SetKeyName(14, "basket.ico")
        Me.imgIconos.Images.SetKeyName(15, "book.ico")
        Me.imgIconos.Images.SetKeyName(16, "box.ico")
        Me.imgIconos.Images.SetKeyName(17, "burn.ico")
        Me.imgIconos.Images.SetKeyName(18, "cal.ico")
        Me.imgIconos.Images.SetKeyName(19, "calculator.ico")
        Me.imgIconos.Images.SetKeyName(20, "camera.ico")
        Me.imgIconos.Images.SetKeyName(21, "cash-register.ico")
        Me.imgIconos.Images.SetKeyName(22, "cc.ico")
        Me.imgIconos.Images.SetKeyName(23, "cd.ico")
        Me.imgIconos.Images.SetKeyName(24, "chat.ico")
        Me.imgIconos.Images.SetKeyName(25, "clock.ico")
        Me.imgIconos.Images.SetKeyName(26, "contacts.ico")
        Me.imgIconos.Images.SetKeyName(27, "copy.ico")
        Me.imgIconos.Images.SetKeyName(28, "cut.ico")
        Me.imgIconos.Images.SetKeyName(29, "db.ico")
        Me.imgIconos.Images.SetKeyName(30, "db1.ico")
        Me.imgIconos.Images.SetKeyName(31, "db2.ico")
        Me.imgIconos.Images.SetKeyName(32, "db3.ico")
        Me.imgIconos.Images.SetKeyName(33, "db4.ico")
        Me.imgIconos.Images.SetKeyName(34, "db5.ico")
        Me.imgIconos.Images.SetKeyName(35, "db6.ico")
        Me.imgIconos.Images.SetKeyName(36, "db7.ico")
        Me.imgIconos.Images.SetKeyName(37, "ddb8.ico")
        Me.imgIconos.Images.SetKeyName(38, "delete.ico")
        Me.imgIconos.Images.SetKeyName(39, "delete-user.ico")
        Me.imgIconos.Images.SetKeyName(40, "down.ico")
        Me.imgIconos.Images.SetKeyName(41, "down-.ico")
        Me.imgIconos.Images.SetKeyName(42, "download.ico")
        Me.imgIconos.Images.SetKeyName(43, "edit.ico")
        Me.imgIconos.Images.SetKeyName(44, "edit-tool.ico")
        Me.imgIconos.Images.SetKeyName(45, "email.ico")
        Me.imgIconos.Images.SetKeyName(46, "engine.ico")
        Me.imgIconos.Images.SetKeyName(47, "explorer.ico")
        Me.imgIconos.Images.SetKeyName(48, "fast-forward.ico")
        Me.imgIconos.Images.SetKeyName(49, "file.ico")
        Me.imgIconos.Images.SetKeyName(50, "file-lock.ico")
        Me.imgIconos.Images.SetKeyName(51, "find-at-disc.ico")
        Me.imgIconos.Images.SetKeyName(52, "find-file.ico")
        Me.imgIconos.Images.SetKeyName(53, "first-page.ico")
        Me.imgIconos.Images.SetKeyName(54, "folder.ico")
        Me.imgIconos.Images.SetKeyName(55, "folder-open.ico")
        Me.imgIconos.Images.SetKeyName(56, "forward.ico")
        Me.imgIconos.Images.SetKeyName(57, "ftp.ico")
        Me.imgIconos.Images.SetKeyName(58, "full-basket.ico")
        Me.imgIconos.Images.SetKeyName(59, "group.ico")
        Me.imgIconos.Images.SetKeyName(60, "hd.ico")
        Me.imgIconos.Images.SetKeyName(61, "hd-as.ico")
        Me.imgIconos.Images.SetKeyName(62, "help.ico")
        Me.imgIconos.Images.SetKeyName(63, "history.ico")
        Me.imgIconos.Images.SetKeyName(64, "home.ico")
        Me.imgIconos.Images.SetKeyName(65, "html.ico")
        Me.imgIconos.Images.SetKeyName(66, "info.ico")
        Me.imgIconos.Images.SetKeyName(67, "install.ico")
        Me.imgIconos.Images.SetKeyName(68, "installer.ico")
        Me.imgIconos.Images.SetKeyName(69, "last-page.ico")
        Me.imgIconos.Images.SetKeyName(70, "lock.ico")
        Me.imgIconos.Images.SetKeyName(71, "misc1.ico")
        Me.imgIconos.Images.SetKeyName(72, "misc2.ico")
        Me.imgIconos.Images.SetKeyName(73, "misc3.ico")
        Me.imgIconos.Images.SetKeyName(74, "misc4.ico")
        Me.imgIconos.Images.SetKeyName(75, "monitor.ico")
        Me.imgIconos.Images.SetKeyName(76, "network.ico")
        Me.imgIconos.Images.SetKeyName(77, "next-.ico")
        Me.imgIconos.Images.SetKeyName(78, "next-2.ico")
        Me.imgIconos.Images.SetKeyName(79, "note.ico")
        Me.imgIconos.Images.SetKeyName(80, "ok.ico")
        Me.imgIconos.Images.SetKeyName(81, "paste.ico")
        Me.imgIconos.Images.SetKeyName(82, "pause.ico")
        Me.imgIconos.Images.SetKeyName(83, "pictures.ico")
        Me.imgIconos.Images.SetKeyName(84, "play.ico")
        Me.imgIconos.Images.SetKeyName(85, "police.ico")
        Me.imgIconos.Images.SetKeyName(86, "price.ico")
        Me.imgIconos.Images.SetKeyName(87, "print.ico")
        Me.imgIconos.Images.SetKeyName(88, "print-preview.ico")
        Me.imgIconos.Images.SetKeyName(89, "record.ico")
        Me.imgIconos.Images.SetKeyName(90, "refresh.ico")
        Me.imgIconos.Images.SetKeyName(91, "remove.ico")
        Me.imgIconos.Images.SetKeyName(92, "remove-file.ico")
        Me.imgIconos.Images.SetKeyName(93, "remove-folder.ico")
        Me.imgIconos.Images.SetKeyName(94, "remove-note.ico")
        Me.imgIconos.Images.SetKeyName(95, "reward.ico")
        Me.imgIconos.Images.SetKeyName(96, "save.ico")
        Me.imgIconos.Images.SetKeyName(97, "save-as.ico")
        Me.imgIconos.Images.SetKeyName(98, "save-new.ico")
        Me.imgIconos.Images.SetKeyName(99, "search.ico")
        Me.imgIconos.Images.SetKeyName(100, "smiley.ico")
        Me.imgIconos.Images.SetKeyName(101, "sound.ico")
        Me.imgIconos.Images.SetKeyName(102, "sound-off.ico")
        Me.imgIconos.Images.SetKeyName(103, "star.ico")
        Me.imgIconos.Images.SetKeyName(104, "statistics.ico")
        Me.imgIconos.Images.SetKeyName(105, "statistics2.ico")
        Me.imgIconos.Images.SetKeyName(106, "stop.ico")
        Me.imgIconos.Images.SetKeyName(107, "stop2.ico")
        Me.imgIconos.Images.SetKeyName(108, "support.ico")
        Me.imgIconos.Images.SetKeyName(109, "uninstall.ico")
        Me.imgIconos.Images.SetKeyName(110, "unlock.ico")
        Me.imgIconos.Images.SetKeyName(111, "up.ico")
        Me.imgIconos.Images.SetKeyName(112, "up-.ico")
        Me.imgIconos.Images.SetKeyName(113, "upload.ico")
        Me.imgIconos.Images.SetKeyName(114, "user2.ico")
        Me.imgIconos.Images.SetKeyName(115, "user3.ico")
        Me.imgIconos.Images.SetKeyName(116, "user-offline.ico")
        Me.imgIconos.Images.SetKeyName(117, "user-online.ico")
        Me.imgIconos.Images.SetKeyName(118, "view.ico")
        Me.imgIconos.Images.SetKeyName(119, "view-save.ico")
        Me.imgIconos.Images.SetKeyName(120, "web-dir.ico")
        Me.imgIconos.Images.SetKeyName(121, "web-search.ico")
        Me.imgIconos.Images.SetKeyName(122, "window.ico")
        Me.imgIconos.Images.SetKeyName(123, "windows.ico")
        Me.imgIconos.Images.SetKeyName(124, "zoom-.ico")
        Me.imgIconos.Images.SetKeyName(125, "zoom+.ico")
        Me.imgIconos.Images.SetKeyName(126, "Antrepo-Container-2-CAI.ico")
        Me.imgIconos.Images.SetKeyName(127, "Antrepo-Container-2-Hapag-4.ico")
        Me.imgIconos.Images.SetKeyName(128, "Antrepo-Container-2-P-O4.ico")
        Me.imgIconos.Images.SetKeyName(129, "Antrepo-Container-4-Cargo-Vans-DHL-Van-Front.ico")
        Me.imgIconos.Images.SetKeyName(130, "Antrepo-Container-4-Cargo-Vans-Dribbble-Van-Back.ico")
        Me.imgIconos.Images.SetKeyName(131, "Antrepo-Container-4-Cargo-Vans-Dribbble-Van-Front.ico")
        Me.imgIconos.Images.SetKeyName(132, "Antrepo-Container-4-Cargo-Vans-Facebook-Van-Back.ico")
        Me.imgIconos.Images.SetKeyName(133, "Antrepo-Container-4-Cargo-Vans-Facebook-Van-Front.ico")
        Me.imgIconos.Images.SetKeyName(134, "Antrepo-Container-4-Cargo-Vans-FedEx-Van-Back.ico")
        Me.imgIconos.Images.SetKeyName(135, "Antrepo-Container-4-Cargo-Vans-FedEx-Van-Front.ico")
        Me.imgIconos.Images.SetKeyName(136, "Antrepo-Container-4-Cargo-Vans-Flickr-Van-Back.ico")
        Me.imgIconos.Images.SetKeyName(137, "Antrepo-Container-4-Cargo-Vans-Google-Van-Front.ico")
        Me.imgIconos.Images.SetKeyName(138, "Antrepo-Container-4-Cargo-Vans-Instagram-Van-Back.ico")
        Me.imgIconos.Images.SetKeyName(139, "Antrepo-Container-4-Cargo-Vans-Instagram-Van-Front.ico")
        Me.imgIconos.Images.SetKeyName(140, "Antrepo-Container-4-Cargo-Vans-Linkedin-Van-Back.ico")
        Me.imgIconos.Images.SetKeyName(141, "Antrepo-Container-4-Cargo-Vans-Linkedin-Van-Front.ico")
        Me.imgIconos.Images.SetKeyName(142, "Antrepo-Container-4-Cargo-Vans-Pinterest-Van-Back.ico")
        Me.imgIconos.Images.SetKeyName(143, "Antrepo-Container-4-Cargo-Vans-TNT-Van-Back.ico")
        Me.imgIconos.Images.SetKeyName(144, "Antrepo-Container-4-Cargo-Vans-Tumblr-Van-Back.ico")
        Me.imgIconos.Images.SetKeyName(145, "Antrepo-Container-4-Cargo-Vans-Tumblr-Van-Front.ico")
        Me.imgIconos.Images.SetKeyName(146, "Antrepo-Container-4-Cargo-Vans-Twitter-Van-Front.ico")
        Me.imgIconos.Images.SetKeyName(147, "Antrepo-Container-4-Cargo-Vans-UPS-Van-Front.ico")
        Me.imgIconos.Images.SetKeyName(148, "Antrepo-Container-4-Cargo-Vans-Yahoo-Van-Front.ico")
        Me.imgIconos.Images.SetKeyName(149, "Antrepo-Container-4-Cargo-Vans-YouTube-Van-Back.ico")
        Me.imgIconos.Images.SetKeyName(150, "Antrepo-Container-After-Effects.ico")
        Me.imgIconos.Images.SetKeyName(151, "Antrepo-Container-Orange.ico")
        Me.imgIconos.Images.SetKeyName(152, "Icons8-Windows-8-Business-Organization.ico")
        Me.imgIconos.Images.SetKeyName(153, "Icons8-Windows-8-Business-Org-Unit.ico")
        Me.imgIconos.Images.SetKeyName(154, "Icons8-Windows-8-Business-Overtime.ico")
        Me.imgIconos.Images.SetKeyName(155, "Icons8-Windows-8-Business-Package.ico")
        Me.imgIconos.Images.SetKeyName(156, "Icons8-Windows-8-Business-Parallel-Tasks.ico")
        Me.imgIconos.Images.SetKeyName(157, "Icons8-Windows-8-Business-Planner.ico")
        Me.imgIconos.Images.SetKeyName(158, "Icons8-Windows-8-Business-Process.ico")
        Me.imgIconos.Images.SetKeyName(159, "Icons8-Windows-8-Business-Self-Service-Kiosk.ico")
        Me.imgIconos.Images.SetKeyName(160, "Icons8-Windows-8-Business-Serial-Tasks.ico")
        Me.imgIconos.Images.SetKeyName(161, "Icons8-Windows-8-Cinema-Adventures.ico")
        Me.imgIconos.Images.SetKeyName(162, "Icons8-Windows-8-City-Police-Badge.ico")
        Me.imgIconos.Images.SetKeyName(163, "Icons8-Windows-8-Database.ico")
        Me.imgIconos.Images.SetKeyName(164, "Icons8-Windows-8-Database-Accept.ico")
        Me.imgIconos.Images.SetKeyName(165, "Icons8-Windows-8-Database-Add.ico")
        Me.imgIconos.Images.SetKeyName(166, "Icons8-Windows-8-Database-Backup.ico")
        Me.imgIconos.Images.SetKeyName(167, "Icons8-Windows-8-Database-Configuration.ico")
        Me.imgIconos.Images.SetKeyName(168, "Icons8-Windows-8-Diy-Drill.ico")
        Me.imgIconos.Images.SetKeyName(169, "Icons8-Windows-8-Diy-Hammer.ico")
        Me.imgIconos.Images.SetKeyName(170, "Icons8-Windows-8-Ecommerce-Delivery.ico")
        Me.imgIconos.Images.SetKeyName(171, "Icons8-Windows-8-Files-Hot-Article.ico")
        Me.imgIconos.Images.SetKeyName(172, "Icons8-Windows-8-Healthcare-Ambulance.ico")
        Me.imgIconos.Images.SetKeyName(173, "Icons8-Windows-8-Industry-Automatic.ico")
        Me.imgIconos.Images.SetKeyName(174, "Icons8-Windows-8-Industry-Automotive.ico")
        Me.imgIconos.Images.SetKeyName(175, "Icons8-Windows-8-Industry-Electro-Devices.ico")
        Me.imgIconos.Images.SetKeyName(176, "Icons8-Windows-8-Industry-Engineering.ico")
        Me.imgIconos.Images.SetKeyName(177, "Icons8-Windows-8-Industry-Manual.ico")
        Me.imgIconos.Images.SetKeyName(178, "Icons8-Windows-8-Industry-Oil-Industry.ico")
        Me.imgIconos.Images.SetKeyName(179, "Icons8-Windows-8-Industry-Poison.ico")
        Me.imgIconos.Images.SetKeyName(180, "Icons8-Windows-8-Industry-Trash.ico")
        Me.imgIconos.Images.SetKeyName(181, "Icons8-Windows-8-Maps-Center-Direction.ico")
        Me.imgIconos.Images.SetKeyName(182, "Icons8-Windows-8-Maps-Gps-Searching.ico")
        Me.imgIconos.Images.SetKeyName(183, "Iconshock-Real-Vista-Accounting-Truck.ico")
        Me.imgIconos.Images.SetKeyName(184, "Icons-Land-Transport-Container (1).ico")
        Me.imgIconos.Images.SetKeyName(185, "Icons-Land-Transport-Container.ico")
        Me.imgIconos.Images.SetKeyName(186, "Icons-Land-Transporter-Fire-Truck-Front-Red.ico")
        Me.imgIconos.Images.SetKeyName(187, "Icons-Land-Transporter-FuelTank-Truck-Front-Grey (1).ico")
        Me.imgIconos.Images.SetKeyName(188, "Icons-Land-Transporter-FuelTank-Truck-Front-Grey.ico")
        Me.imgIconos.Images.SetKeyName(189, "Icons-Land-Transporter-FuelTank-Truck-Left-Grey.ico")
        Me.imgIconos.Images.SetKeyName(190, "Icons-Land-Transporter-FuelTank-Truck-Right-Grey.ico")
        Me.imgIconos.Images.SetKeyName(191, "Icons-Land-Transporter-FuelTank-Truck-Top-Grey.ico")
        Me.imgIconos.Images.SetKeyName(192, "Icons-Land-Transporter-Truck-Front-Green.ico")
        Me.imgIconos.Images.SetKeyName(193, "Icons-Land-Transporter-Truck-Left-Green.ico")
        Me.imgIconos.Images.SetKeyName(194, "Icons-Land-Transporter-Truck-Right-Green.ico")
        Me.imgIconos.Images.SetKeyName(195, "Icons-Land-Transport-ExecutiveCar.ico")
        Me.imgIconos.Images.SetKeyName(196, "Icons-Land-Transport-Lorry.ico")
        Me.imgIconos.Images.SetKeyName(197, "Icons-Land-Transport-TractorUnit.ico")
        Me.imgIconos.Images.SetKeyName(198, "Icons-Land-Transport-Truck.ico")
        Me.imgIconos.Images.SetKeyName(199, "Icons-Land-Transport-Wheel.ico")
        Me.imgIconos.Images.SetKeyName(200, "lorrygreen.ico")
        Me.imgIconos.Images.SetKeyName(201, "tanker_truck.ico")
        Me.imgIconos.Images.SetKeyName(202, "tractorunitblack.ico")
        Me.imgIconos.Images.SetKeyName(203, "truckyellow.ico")
        '
        'cmdProcessMarca
        '
        Me.cmdProcessMarca.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.cmdProcessMarca.ImageIndex = 73
        Me.cmdProcessMarca.ImageList = Me.imgIconos
        Me.cmdProcessMarca.Location = New System.Drawing.Point(68, 41)
        Me.cmdProcessMarca.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdProcessMarca.Name = "cmdProcessMarca"
        Me.cmdProcessMarca.Size = New System.Drawing.Size(110, 46)
        Me.cmdProcessMarca.TabIndex = 13
        Me.cmdProcessMarca.Text = "&Nuevo"
        Me.cmdProcessMarca.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.cmdProcessMarca.UseVisualStyleBackColor = True
        '
        'txtMarca
        '
        Me.txtMarca.Enabled = False
        Me.txtMarca.Location = New System.Drawing.Point(68, 12)
        Me.txtMarca.MaxLength = 15
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.ShortcutsEnabled = False
        Me.txtMarca.Size = New System.Drawing.Size(232, 21)
        Me.txtMarca.TabIndex = 12
        '
        'tdbgMarca
        '
        Me.tdbgMarca.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
        Me.tdbgMarca.AllowSort = False
        Me.tdbgMarca.AllowUpdate = False
        Me.tdbgMarca.AlternatingRows = True
        Me.tdbgMarca.CaptionHeight = 23
        Me.tdbgMarca.DirectionAfterEnter = C1.Win.C1TrueDBGrid.DirectionAfterEnterEnum.MoveNone
        Me.tdbgMarca.GroupByCaption = "Drag a column header here to group by that column"
        Me.tdbgMarca.Images.Add(CType(resources.GetObject("tdbgMarca.Images"), System.Drawing.Image))
        Me.tdbgMarca.Location = New System.Drawing.Point(307, 12)
        Me.tdbgMarca.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tdbgMarca.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.HighlightRow
        Me.tdbgMarca.Name = "tdbgMarca"
        Me.tdbgMarca.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.tdbgMarca.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.tdbgMarca.PreviewInfo.ZoomFactor = 75.0R
        Me.tdbgMarca.PrintInfo.PageSettings = CType(resources.GetObject("tdbgMarca.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.tdbgMarca.RowHeight = 21
        Me.tdbgMarca.Size = New System.Drawing.Size(316, 360)
        Me.tdbgMarca.TabIndex = 11
        Me.tdbgMarca.Text = "C1TrueDBGrid1"
        Me.tdbgMarca.PropBag = resources.GetString("tdbgMarca.PropBag")
        '
        'tbpTipoVehiculo
        '
        Me.tbpTipoVehiculo.Controls.Add(Me.cmdKill)
        Me.tbpTipoVehiculo.Controls.Add(Me.tdbgTiposVehiculo)
        Me.tbpTipoVehiculo.Controls.Add(Me.cmdXprtTiVh)
        Me.tbpTipoVehiculo.Controls.Add(Me.lblDescripcion)
        Me.tbpTipoVehiculo.Controls.Add(Me.lblUso)
        Me.tbpTipoVehiculo.Controls.Add(Me.lblCombustible)
        Me.tbpTipoVehiculo.Controls.Add(Me.cmdCancelTipoVeh)
        Me.tbpTipoVehiculo.Controls.Add(Me.cmdProcesarTipoVeh)
        Me.tbpTipoVehiculo.Controls.Add(Me.txtDescripcion)
        Me.tbpTipoVehiculo.Controls.Add(Me.cboUso)
        Me.tbpTipoVehiculo.Controls.Add(Me.cboCombustible)
        Me.tbpTipoVehiculo.ImageIndex = 181
        Me.tbpTipoVehiculo.Location = New System.Drawing.Point(4, 24)
        Me.tbpTipoVehiculo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbpTipoVehiculo.Name = "tbpTipoVehiculo"
        Me.tbpTipoVehiculo.Size = New System.Drawing.Size(736, 423)
        Me.tbpTipoVehiculo.TabIndex = 0
        Me.tbpTipoVehiculo.Text = "Tipos de vehiculo"
        Me.tbpTipoVehiculo.UseVisualStyleBackColor = True
        '
        'cmdKill
        '
        Me.cmdKill.Enabled = False
        Me.cmdKill.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdKill.ImageIndex = 179
        Me.cmdKill.ImageList = Me.imgIconos
        Me.cmdKill.Location = New System.Drawing.Point(230, 161)
        Me.cmdKill.Name = "cmdKill"
        Me.cmdKill.Size = New System.Drawing.Size(93, 54)
        Me.cmdKill.TabIndex = 11
        Me.cmdKill.Text = "Borrar"
        Me.cmdKill.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdKill.UseVisualStyleBackColor = True
        Me.cmdKill.Visible = False
        '
        'tdbgTiposVehiculo
        '
        Me.tdbgTiposVehiculo.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
        Me.tdbgTiposVehiculo.AllowSort = False
        Me.tdbgTiposVehiculo.AllowUpdate = False
        Me.tdbgTiposVehiculo.AlternatingRows = True
        Me.tdbgTiposVehiculo.CaptionHeight = 23
        Me.tdbgTiposVehiculo.DirectionAfterEnter = C1.Win.C1TrueDBGrid.DirectionAfterEnterEnum.MoveNone
        Me.tdbgTiposVehiculo.GroupByCaption = "Drag a column header here to group by that column"
        Me.tdbgTiposVehiculo.Images.Add(CType(resources.GetObject("tdbgTiposVehiculo.Images"), System.Drawing.Image))
        Me.tdbgTiposVehiculo.Location = New System.Drawing.Point(331, 8)
        Me.tdbgTiposVehiculo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tdbgTiposVehiculo.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.HighlightCell
        Me.tdbgTiposVehiculo.Name = "tdbgTiposVehiculo"
        Me.tdbgTiposVehiculo.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.tdbgTiposVehiculo.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.tdbgTiposVehiculo.PreviewInfo.ZoomFactor = 75.0R
        Me.tdbgTiposVehiculo.PrintInfo.PageSettings = CType(resources.GetObject("tdbgTiposVehiculo.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.tdbgTiposVehiculo.RowHeight = 21
        Me.tdbgTiposVehiculo.Size = New System.Drawing.Size(246, 207)
        Me.tdbgTiposVehiculo.TabIndex = 10
        Me.tdbgTiposVehiculo.Text = "C1TrueDBGrid1"
        Me.tdbgTiposVehiculo.PropBag = resources.GetString("tdbgTiposVehiculo.PropBag")
        '
        'cmdXprtTiVh
        '
        Me.cmdXprtTiVh.Location = New System.Drawing.Point(331, 225)
        Me.cmdXprtTiVh.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdXprtTiVh.Name = "cmdXprtTiVh"
        Me.cmdXprtTiVh.Size = New System.Drawing.Size(134, 57)
        Me.cmdXprtTiVh.TabIndex = 9
        Me.cmdXprtTiVh.Text = "Consultar"
        Me.cmdXprtTiVh.UseVisualStyleBackColor = True
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Location = New System.Drawing.Point(4, 77)
        Me.lblDescripcion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(75, 15)
        Me.lblDescripcion.TabIndex = 7
        Me.lblDescripcion.Text = "Descripcion:"
        '
        'lblUso
        '
        Me.lblUso.AutoSize = True
        Me.lblUso.Location = New System.Drawing.Point(4, 44)
        Me.lblUso.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUso.Name = "lblUso"
        Me.lblUso.Size = New System.Drawing.Size(32, 15)
        Me.lblUso.TabIndex = 6
        Me.lblUso.Text = "Uso:"
        '
        'lblCombustible
        '
        Me.lblCombustible.AutoSize = True
        Me.lblCombustible.Location = New System.Drawing.Point(4, 11)
        Me.lblCombustible.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCombustible.Name = "lblCombustible"
        Me.lblCombustible.Size = New System.Drawing.Size(79, 15)
        Me.lblCombustible.TabIndex = 5
        Me.lblCombustible.Text = "Combustible:"
        '
        'cmdCancelTipoVeh
        '
        Me.cmdCancelTipoVeh.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.cmdCancelTipoVeh.ImageIndex = 72
        Me.cmdCancelTipoVeh.ImageList = Me.imgIconos
        Me.cmdCancelTipoVeh.Location = New System.Drawing.Point(230, 112)
        Me.cmdCancelTipoVeh.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdCancelTipoVeh.Name = "cmdCancelTipoVeh"
        Me.cmdCancelTipoVeh.Size = New System.Drawing.Size(93, 41)
        Me.cmdCancelTipoVeh.TabIndex = 4
        Me.cmdCancelTipoVeh.Text = "Cancelar"
        Me.cmdCancelTipoVeh.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.cmdCancelTipoVeh.UseVisualStyleBackColor = True
        '
        'cmdProcesarTipoVeh
        '
        Me.cmdProcesarTipoVeh.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.cmdProcesarTipoVeh.ImageIndex = 73
        Me.cmdProcesarTipoVeh.ImageList = Me.imgIconos
        Me.cmdProcesarTipoVeh.Location = New System.Drawing.Point(129, 112)
        Me.cmdProcesarTipoVeh.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdProcesarTipoVeh.Name = "cmdProcesarTipoVeh"
        Me.cmdProcesarTipoVeh.Size = New System.Drawing.Size(93, 41)
        Me.cmdProcesarTipoVeh.TabIndex = 3
        Me.cmdProcesarTipoVeh.Text = "&Nuevo"
        Me.cmdProcesarTipoVeh.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.cmdProcesarTipoVeh.UseVisualStyleBackColor = True
        '
        'txtDescripcion
        '
        Me.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion.Enabled = False
        Me.txtDescripcion.Location = New System.Drawing.Point(111, 69)
        Me.txtDescripcion.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtDescripcion.MaxLength = 20
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.ShortcutsEnabled = False
        Me.txtDescripcion.Size = New System.Drawing.Size(212, 33)
        Me.txtDescripcion.TabIndex = 2
        '
        'cboUso
        '
        Me.cboUso.Enabled = False
        Me.cboUso.FormattingEnabled = True
        Me.cboUso.Location = New System.Drawing.Point(111, 36)
        Me.cboUso.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboUso.Name = "cboUso"
        Me.cboUso.Size = New System.Drawing.Size(212, 23)
        Me.cboUso.TabIndex = 1
        '
        'cboCombustible
        '
        Me.cboCombustible.Enabled = False
        Me.cboCombustible.FormattingEnabled = True
        Me.cboCombustible.Location = New System.Drawing.Point(111, 8)
        Me.cboCombustible.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboCombustible.Name = "cboCombustible"
        Me.cboCombustible.Size = New System.Drawing.Size(212, 23)
        Me.cboCombustible.TabIndex = 0
        '
        'tbpUnidades
        '
        Me.tbpUnidades.Controls.Add(Me.cmdXportUns)
        Me.tbpUnidades.Controls.Add(Me.lblAño)
        Me.tbpUnidades.Controls.Add(Me.lblModelo)
        Me.tbpUnidades.Controls.Add(Me.numAño)
        Me.tbpUnidades.Controls.Add(Me.txtModelo)
        Me.tbpUnidades.Controls.Add(Me.lblMatricula)
        Me.tbpUnidades.Controls.Add(Me.txtMatricula)
        Me.tbpUnidades.Controls.Add(Me.lblMarca)
        Me.tbpUnidades.Controls.Add(Me.cboMarca)
        Me.tbpUnidades.Controls.Add(Me.cmdXprtVehiculo)
        Me.tbpUnidades.Controls.Add(Me.lblChasis)
        Me.tbpUnidades.Controls.Add(Me.lblMotor)
        Me.tbpUnidades.Controls.Add(Me.lblEco)
        Me.tbpUnidades.Controls.Add(Me.lblTipoVehiculo)
        Me.tbpUnidades.Controls.Add(Me.cmdKillUnit)
        Me.tbpUnidades.Controls.Add(Me.cmdCancelarVehiculo)
        Me.tbpUnidades.Controls.Add(Me.cmdProcesarVehiculo)
        Me.tbpUnidades.Controls.Add(Me.txtSerieChasis)
        Me.tbpUnidades.Controls.Add(Me.txtSerieMotor)
        Me.tbpUnidades.Controls.Add(Me.txtEco)
        Me.tbpUnidades.Controls.Add(Me.cboTipoUnidad)
        Me.tbpUnidades.Controls.Add(Me.tdbgUnidades)
        Me.tbpUnidades.ImageIndex = 170
        Me.tbpUnidades.Location = New System.Drawing.Point(4, 24)
        Me.tbpUnidades.Name = "tbpUnidades"
        Me.tbpUnidades.Size = New System.Drawing.Size(736, 423)
        Me.tbpUnidades.TabIndex = 1
        Me.tbpUnidades.Text = "Vehiculos"
        Me.tbpUnidades.UseVisualStyleBackColor = True
        '
        'cmdXportUns
        '
        Me.cmdXportUns.Enabled = False
        Me.cmdXportUns.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdXportUns.ImageIndex = 78
        Me.cmdXportUns.ImageList = Me.imgIconos
        Me.cmdXportUns.Location = New System.Drawing.Point(484, 370)
        Me.cmdXportUns.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdXportUns.Name = "cmdXportUns"
        Me.cmdXportUns.Size = New System.Drawing.Size(96, 35)
        Me.cmdXportUns.TabIndex = 34
        Me.cmdXportUns.Text = "Exportar"
        Me.cmdXportUns.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.cmdXportUns.UseVisualStyleBackColor = True
        Me.cmdXportUns.Visible = False
        '
        'lblAño
        '
        Me.lblAño.AutoSize = True
        Me.lblAño.Location = New System.Drawing.Point(29, 220)
        Me.lblAño.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAño.Name = "lblAño"
        Me.lblAño.Size = New System.Drawing.Size(28, 15)
        Me.lblAño.TabIndex = 33
        Me.lblAño.Text = "Año"
        '
        'lblModelo
        '
        Me.lblModelo.AutoSize = True
        Me.lblModelo.Location = New System.Drawing.Point(29, 192)
        Me.lblModelo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblModelo.Name = "lblModelo"
        Me.lblModelo.Size = New System.Drawing.Size(49, 15)
        Me.lblModelo.TabIndex = 32
        Me.lblModelo.Text = "Modelo"
        '
        'numAño
        '
        Me.numAño.Enabled = False
        Me.numAño.Location = New System.Drawing.Point(247, 213)
        Me.numAño.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.numAño.Maximum = New Decimal(New Integer() {2030, 0, 0, 0})
        Me.numAño.Minimum = New Decimal(New Integer() {2000, 0, 0, 0})
        Me.numAño.Name = "numAño"
        Me.numAño.Size = New System.Drawing.Size(86, 21)
        Me.numAño.TabIndex = 31
        Me.numAño.Value = New Decimal(New Integer() {2000, 0, 0, 0})
        '
        'txtModelo
        '
        Me.txtModelo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtModelo.Enabled = False
        Me.txtModelo.Location = New System.Drawing.Point(160, 184)
        Me.txtModelo.MaxLength = 20
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.ShortcutsEnabled = False
        Me.txtModelo.Size = New System.Drawing.Size(173, 21)
        Me.txtModelo.TabIndex = 30
        '
        'lblMatricula
        '
        Me.lblMatricula.AutoSize = True
        Me.lblMatricula.Location = New System.Drawing.Point(29, 162)
        Me.lblMatricula.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMatricula.Name = "lblMatricula"
        Me.lblMatricula.Size = New System.Drawing.Size(58, 15)
        Me.lblMatricula.TabIndex = 29
        Me.lblMatricula.Text = "Matricula"
        '
        'txtMatricula
        '
        Me.txtMatricula.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMatricula.Enabled = False
        Me.txtMatricula.Location = New System.Drawing.Point(160, 154)
        Me.txtMatricula.MaxLength = 20
        Me.txtMatricula.Name = "txtMatricula"
        Me.txtMatricula.ShortcutsEnabled = False
        Me.txtMatricula.Size = New System.Drawing.Size(173, 21)
        Me.txtMatricula.TabIndex = 28
        '
        'lblMarca
        '
        Me.lblMarca.AutoSize = True
        Me.lblMarca.Location = New System.Drawing.Point(29, 50)
        Me.lblMarca.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMarca.Name = "lblMarca"
        Me.lblMarca.Size = New System.Drawing.Size(42, 15)
        Me.lblMarca.TabIndex = 27
        Me.lblMarca.Text = "Marca"
        '
        'cboMarca
        '
        Me.cboMarca.Enabled = False
        Me.cboMarca.FormattingEnabled = True
        Me.cboMarca.Location = New System.Drawing.Point(160, 42)
        Me.cboMarca.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboMarca.Name = "cboMarca"
        Me.cboMarca.Size = New System.Drawing.Size(173, 23)
        Me.cboMarca.TabIndex = 26
        '
        'cmdXprtVehiculo
        '
        Me.cmdXprtVehiculo.Location = New System.Drawing.Point(387, 370)
        Me.cmdXprtVehiculo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdXprtVehiculo.Name = "cmdXprtVehiculo"
        Me.cmdXprtVehiculo.Size = New System.Drawing.Size(72, 35)
        Me.cmdXprtVehiculo.TabIndex = 25
        Me.cmdXprtVehiculo.Text = "Consultar"
        Me.cmdXprtVehiculo.UseVisualStyleBackColor = True
        '
        'lblChasis
        '
        Me.lblChasis.AutoSize = True
        Me.lblChasis.Location = New System.Drawing.Point(29, 135)
        Me.lblChasis.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblChasis.Name = "lblChasis"
        Me.lblChasis.Size = New System.Drawing.Size(74, 15)
        Me.lblChasis.TabIndex = 23
        Me.lblChasis.Text = "Serie chasis"
        '
        'lblMotor
        '
        Me.lblMotor.AutoSize = True
        Me.lblMotor.Location = New System.Drawing.Point(29, 108)
        Me.lblMotor.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMotor.Name = "lblMotor"
        Me.lblMotor.Size = New System.Drawing.Size(71, 15)
        Me.lblMotor.TabIndex = 22
        Me.lblMotor.Text = "Serie motor"
        '
        'lblEco
        '
        Me.lblEco.AutoSize = True
        Me.lblEco.Location = New System.Drawing.Point(27, 81)
        Me.lblEco.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEco.Name = "lblEco"
        Me.lblEco.Size = New System.Drawing.Size(69, 15)
        Me.lblEco.TabIndex = 21
        Me.lblEco.Text = "Económico"
        '
        'lblTipoVehiculo
        '
        Me.lblTipoVehiculo.AutoSize = True
        Me.lblTipoVehiculo.Location = New System.Drawing.Point(22, 17)
        Me.lblTipoVehiculo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTipoVehiculo.Name = "lblTipoVehiculo"
        Me.lblTipoVehiculo.Size = New System.Drawing.Size(96, 15)
        Me.lblTipoVehiculo.TabIndex = 20
        Me.lblTipoVehiculo.Text = "Tipo de vehiculo"
        '
        'cmdKillUnit
        '
        Me.cmdKillUnit.Enabled = False
        Me.cmdKillUnit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdKillUnit.ImageIndex = 179
        Me.cmdKillUnit.ImageList = Me.imgIconos
        Me.cmdKillUnit.Location = New System.Drawing.Point(274, 295)
        Me.cmdKillUnit.Name = "cmdKillUnit"
        Me.cmdKillUnit.Size = New System.Drawing.Size(59, 65)
        Me.cmdKillUnit.TabIndex = 19
        Me.cmdKillUnit.Text = "Borrar"
        Me.cmdKillUnit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdKillUnit.UseVisualStyleBackColor = True
        Me.cmdKillUnit.Visible = False
        '
        'cmdCancelarVehiculo
        '
        Me.cmdCancelarVehiculo.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.cmdCancelarVehiculo.ImageIndex = 72
        Me.cmdCancelarVehiculo.ImageList = Me.imgIconos
        Me.cmdCancelarVehiculo.Location = New System.Drawing.Point(241, 244)
        Me.cmdCancelarVehiculo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdCancelarVehiculo.Name = "cmdCancelarVehiculo"
        Me.cmdCancelarVehiculo.Size = New System.Drawing.Size(92, 43)
        Me.cmdCancelarVehiculo.TabIndex = 18
        Me.cmdCancelarVehiculo.Text = "Cancelar"
        Me.cmdCancelarVehiculo.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.cmdCancelarVehiculo.UseVisualStyleBackColor = True
        '
        'cmdProcesarVehiculo
        '
        Me.cmdProcesarVehiculo.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.cmdProcesarVehiculo.ImageIndex = 73
        Me.cmdProcesarVehiculo.ImageList = Me.imgIconos
        Me.cmdProcesarVehiculo.Location = New System.Drawing.Point(93, 239)
        Me.cmdProcesarVehiculo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdProcesarVehiculo.Name = "cmdProcesarVehiculo"
        Me.cmdProcesarVehiculo.Size = New System.Drawing.Size(92, 43)
        Me.cmdProcesarVehiculo.TabIndex = 17
        Me.cmdProcesarVehiculo.Text = "&Nuevo"
        Me.cmdProcesarVehiculo.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.cmdProcesarVehiculo.UseVisualStyleBackColor = True
        '
        'txtSerieChasis
        '
        Me.txtSerieChasis.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSerieChasis.Enabled = False
        Me.txtSerieChasis.Location = New System.Drawing.Point(160, 127)
        Me.txtSerieChasis.MaxLength = 40
        Me.txtSerieChasis.Name = "txtSerieChasis"
        Me.txtSerieChasis.Size = New System.Drawing.Size(173, 21)
        Me.txtSerieChasis.TabIndex = 15
        '
        'txtSerieMotor
        '
        Me.txtSerieMotor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSerieMotor.Enabled = False
        Me.txtSerieMotor.Location = New System.Drawing.Point(160, 100)
        Me.txtSerieMotor.MaxLength = 40
        Me.txtSerieMotor.Name = "txtSerieMotor"
        Me.txtSerieMotor.Size = New System.Drawing.Size(173, 21)
        Me.txtSerieMotor.TabIndex = 14
        '
        'txtEco
        '
        Me.txtEco.Enabled = False
        Me.txtEco.Location = New System.Drawing.Point(160, 73)
        Me.txtEco.MaxLength = 20
        Me.txtEco.Name = "txtEco"
        Me.txtEco.ShortcutsEnabled = False
        Me.txtEco.Size = New System.Drawing.Size(173, 21)
        Me.txtEco.TabIndex = 13
        '
        'cboTipoUnidad
        '
        Me.cboTipoUnidad.Enabled = False
        Me.cboTipoUnidad.FormattingEnabled = True
        Me.cboTipoUnidad.Location = New System.Drawing.Point(160, 14)
        Me.cboTipoUnidad.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboTipoUnidad.Name = "cboTipoUnidad"
        Me.cboTipoUnidad.Size = New System.Drawing.Size(173, 23)
        Me.cboTipoUnidad.TabIndex = 12
        '
        'tdbgUnidades
        '
        Me.tdbgUnidades.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
        Me.tdbgUnidades.AllowSort = False
        Me.tdbgUnidades.AllowUpdate = False
        Me.tdbgUnidades.AlternatingRows = True
        Me.tdbgUnidades.CaptionHeight = 23
        Me.tdbgUnidades.DirectionAfterEnter = C1.Win.C1TrueDBGrid.DirectionAfterEnterEnum.MoveNone
        Me.tdbgUnidades.GroupByCaption = "Drag a column header here to group by that column"
        Me.tdbgUnidades.Images.Add(CType(resources.GetObject("tdbgUnidades.Images"), System.Drawing.Image))
        Me.tdbgUnidades.Location = New System.Drawing.Point(350, 14)
        Me.tdbgUnidades.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tdbgUnidades.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.HighlightRow
        Me.tdbgUnidades.Name = "tdbgUnidades"
        Me.tdbgUnidades.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.tdbgUnidades.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.tdbgUnidades.PreviewInfo.ZoomFactor = 75.0R
        Me.tdbgUnidades.PrintInfo.PageSettings = CType(resources.GetObject("tdbgUnidades.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.tdbgUnidades.RowHeight = 21
        Me.tdbgUnidades.Size = New System.Drawing.Size(230, 346)
        Me.tdbgUnidades.TabIndex = 11
        Me.tdbgUnidades.PropBag = resources.GetString("tdbgUnidades.PropBag")
        '
        'tbpConfs
        '
        Me.tbpConfs.Controls.Add(Me.tabDetailsConjs)
        Me.tbpConfs.ImageIndex = 156
        Me.tbpConfs.Location = New System.Drawing.Point(4, 24)
        Me.tbpConfs.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbpConfs.Name = "tbpConfs"
        Me.tbpConfs.Size = New System.Drawing.Size(736, 423)
        Me.tbpConfs.TabIndex = 3
        Me.tbpConfs.Text = "Configuraciones"
        Me.tbpConfs.UseVisualStyleBackColor = True
        '
        'tabDetailsConjs
        '
        Me.tabDetailsConjs.Controls.Add(Me.stbpConjuntos)
        Me.tabDetailsConjs.Controls.Add(Me.stbpSubconjuntos)
        Me.tabDetailsConjs.Controls.Add(Me.stbpReparaciones)
        Me.tabDetailsConjs.ImageList = Me.imlSm
        Me.tabDetailsConjs.Location = New System.Drawing.Point(4, 5)
        Me.tabDetailsConjs.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tabDetailsConjs.Name = "tabDetailsConjs"
        Me.tabDetailsConjs.SelectedIndex = 0
        Me.tabDetailsConjs.Size = New System.Drawing.Size(717, 393)
        Me.tabDetailsConjs.TabIndex = 0
        '
        'stbpConjuntos
        '
        Me.stbpConjuntos.BackColor = System.Drawing.Color.SteelBlue
        Me.stbpConjuntos.Controls.Add(Me.cmdKillConj)
        Me.stbpConjuntos.Controls.Add(Me.lblConjunto)
        Me.stbpConjuntos.Controls.Add(Me.lblTipoVehiculo_C)
        Me.stbpConjuntos.Controls.Add(Me.cmdProces_conjunto)
        Me.stbpConjuntos.Controls.Add(Me.cmdCancel_Conj)
        Me.stbpConjuntos.Controls.Add(Me.cmdQueryC)
        Me.stbpConjuntos.Controls.Add(Me.cmdXport_C)
        Me.stbpConjuntos.Controls.Add(Me.txtSCConj)
        Me.stbpConjuntos.Controls.Add(Me.cboTVConjuntos)
        Me.stbpConjuntos.Controls.Add(Me.TDbgConjuntos)
        Me.stbpConjuntos.ImageIndex = 153
        Me.stbpConjuntos.Location = New System.Drawing.Point(4, 24)
        Me.stbpConjuntos.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.stbpConjuntos.Name = "stbpConjuntos"
        Me.stbpConjuntos.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.stbpConjuntos.Size = New System.Drawing.Size(709, 365)
        Me.stbpConjuntos.TabIndex = 0
        Me.stbpConjuntos.Text = "Conjuntos"
        '
        'cmdKillConj
        '
        Me.cmdKillConj.Enabled = False
        Me.cmdKillConj.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdKillConj.ImageIndex = 179
        Me.cmdKillConj.ImageList = Me.imgIconos
        Me.cmdKillConj.Location = New System.Drawing.Point(22, 104)
        Me.cmdKillConj.Name = "cmdKillConj"
        Me.cmdKillConj.Size = New System.Drawing.Size(82, 55)
        Me.cmdKillConj.TabIndex = 23
        Me.cmdKillConj.Text = "Borrar"
        Me.cmdKillConj.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdKillConj.UseVisualStyleBackColor = True
        Me.cmdKillConj.Visible = False
        '
        'lblConjunto
        '
        Me.lblConjunto.AutoSize = True
        Me.lblConjunto.ForeColor = System.Drawing.Color.White
        Me.lblConjunto.Location = New System.Drawing.Point(8, 35)
        Me.lblConjunto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblConjunto.Name = "lblConjunto"
        Me.lblConjunto.Size = New System.Drawing.Size(56, 15)
        Me.lblConjunto.TabIndex = 21
        Me.lblConjunto.Text = "Conjunto"
        '
        'lblTipoVehiculo_C
        '
        Me.lblTipoVehiculo_C.AutoSize = True
        Me.lblTipoVehiculo_C.ForeColor = System.Drawing.Color.White
        Me.lblTipoVehiculo_C.Location = New System.Drawing.Point(8, 12)
        Me.lblTipoVehiculo_C.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTipoVehiculo_C.Name = "lblTipoVehiculo_C"
        Me.lblTipoVehiculo_C.Size = New System.Drawing.Size(96, 15)
        Me.lblTipoVehiculo_C.TabIndex = 20
        Me.lblTipoVehiculo_C.Text = "Tipo de vehiculo"
        '
        'cmdProces_conjunto
        '
        Me.cmdProces_conjunto.Location = New System.Drawing.Point(111, 66)
        Me.cmdProces_conjunto.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdProces_conjunto.Name = "cmdProces_conjunto"
        Me.cmdProces_conjunto.Size = New System.Drawing.Size(71, 30)
        Me.cmdProces_conjunto.TabIndex = 19
        Me.cmdProces_conjunto.Text = "&Procesar"
        Me.cmdProces_conjunto.UseVisualStyleBackColor = True
        '
        'cmdCancel_Conj
        '
        Me.cmdCancel_Conj.Location = New System.Drawing.Point(190, 66)
        Me.cmdCancel_Conj.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdCancel_Conj.Name = "cmdCancel_Conj"
        Me.cmdCancel_Conj.Size = New System.Drawing.Size(71, 29)
        Me.cmdCancel_Conj.TabIndex = 18
        Me.cmdCancel_Conj.Text = "Cancelar"
        Me.cmdCancel_Conj.UseVisualStyleBackColor = True
        '
        'cmdQueryC
        '
        Me.cmdQueryC.Location = New System.Drawing.Point(269, 10)
        Me.cmdQueryC.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdQueryC.Name = "cmdQueryC"
        Me.cmdQueryC.Size = New System.Drawing.Size(79, 22)
        Me.cmdQueryC.TabIndex = 17
        Me.cmdQueryC.Text = "Consultar"
        Me.cmdQueryC.UseVisualStyleBackColor = True
        '
        'cmdXport_C
        '
        Me.cmdXport_C.Location = New System.Drawing.Point(356, 10)
        Me.cmdXport_C.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdXport_C.Name = "cmdXport_C"
        Me.cmdXport_C.Size = New System.Drawing.Size(79, 22)
        Me.cmdXport_C.TabIndex = 16
        Me.cmdXport_C.Text = "Exportar"
        Me.cmdXport_C.UseVisualStyleBackColor = True
        '
        'txtSCConj
        '
        Me.txtSCConj.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSCConj.Enabled = False
        Me.txtSCConj.Location = New System.Drawing.Point(112, 35)
        Me.txtSCConj.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSCConj.MaxLength = 15
        Me.txtSCConj.Name = "txtSCConj"
        Me.txtSCConj.Size = New System.Drawing.Size(149, 21)
        Me.txtSCConj.TabIndex = 14
        '
        'cboTVConjuntos
        '
        Me.cboTVConjuntos.Enabled = False
        Me.cboTVConjuntos.FormattingEnabled = True
        Me.cboTVConjuntos.Location = New System.Drawing.Point(112, 9)
        Me.cboTVConjuntos.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboTVConjuntos.Name = "cboTVConjuntos"
        Me.cboTVConjuntos.Size = New System.Drawing.Size(149, 23)
        Me.cboTVConjuntos.TabIndex = 13
        '
        'TDbgConjuntos
        '
        Me.TDbgConjuntos.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
        Me.TDbgConjuntos.AllowSort = False
        Me.TDbgConjuntos.AllowUpdate = False
        Me.TDbgConjuntos.AlternatingRows = True
        Me.TDbgConjuntos.BackColor = System.Drawing.Color.DarkGray
        Me.TDbgConjuntos.CaptionHeight = 23
        Me.TDbgConjuntos.DataView = C1.Win.C1TrueDBGrid.DataViewEnum.GroupBy
        Me.TDbgConjuntos.DirectionAfterEnter = C1.Win.C1TrueDBGrid.DirectionAfterEnterEnum.MoveNone
        Me.TDbgConjuntos.GroupByCaption = "Arrastre una columna para agrupar"
        Me.TDbgConjuntos.Images.Add(CType(resources.GetObject("TDbgConjuntos.Images"), System.Drawing.Image))
        Me.TDbgConjuntos.Location = New System.Drawing.Point(269, 42)
        Me.TDbgConjuntos.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TDbgConjuntos.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.HighlightRow
        Me.TDbgConjuntos.Name = "TDbgConjuntos"
        Me.TDbgConjuntos.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.TDbgConjuntos.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.TDbgConjuntos.PreviewInfo.ZoomFactor = 75.0R
        Me.TDbgConjuntos.PrintInfo.PageSettings = CType(resources.GetObject("TDbgConjuntos.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.TDbgConjuntos.RowHeight = 21
        Me.TDbgConjuntos.Size = New System.Drawing.Size(432, 318)
        Me.TDbgConjuntos.TabIndex = 12
        Me.TDbgConjuntos.PropBag = resources.GetString("TDbgConjuntos.PropBag")
        '
        'stbpSubconjuntos
        '
        Me.stbpSubconjuntos.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.stbpSubconjuntos.Controls.Add(Me.cmdQueySubs)
        Me.stbpSubconjuntos.Controls.Add(Me.cdmXportSbs)
        Me.stbpSubconjuntos.Controls.Add(Me.Label4)
        Me.stbpSubconjuntos.Controls.Add(Me.Label2)
        Me.stbpSubconjuntos.Controls.Add(Me.Label3)
        Me.stbpSubconjuntos.Controls.Add(Me.cmdProcesar_Subs)
        Me.stbpSubconjuntos.Controls.Add(Me.cmdCancelSubs)
        Me.stbpSubconjuntos.Controls.Add(Me.tdbgSubs)
        Me.stbpSubconjuntos.Controls.Add(Me.txtSubConjunto)
        Me.stbpSubconjuntos.Controls.Add(Me.cboConjunto_SBS)
        Me.stbpSubconjuntos.Controls.Add(Me.cboTipoVehiculoSBS)
        Me.stbpSubconjuntos.ImageIndex = 160
        Me.stbpSubconjuntos.Location = New System.Drawing.Point(4, 24)
        Me.stbpSubconjuntos.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.stbpSubconjuntos.Name = "stbpSubconjuntos"
        Me.stbpSubconjuntos.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.stbpSubconjuntos.Size = New System.Drawing.Size(709, 365)
        Me.stbpSubconjuntos.TabIndex = 1
        Me.stbpSubconjuntos.Text = "Subconjuntos"
        '
        'cmdQueySubs
        '
        Me.cmdQueySubs.Location = New System.Drawing.Point(325, 10)
        Me.cmdQueySubs.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdQueySubs.Name = "cmdQueySubs"
        Me.cmdQueySubs.Size = New System.Drawing.Size(79, 30)
        Me.cmdQueySubs.TabIndex = 26
        Me.cmdQueySubs.Text = "Consultar"
        Me.cmdQueySubs.UseVisualStyleBackColor = True
        '
        'cdmXportSbs
        '
        Me.cdmXportSbs.Location = New System.Drawing.Point(412, 10)
        Me.cdmXportSbs.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cdmXportSbs.Name = "cdmXportSbs"
        Me.cdmXportSbs.Size = New System.Drawing.Size(79, 30)
        Me.cdmXportSbs.TabIndex = 25
        Me.cdmXportSbs.Text = "Exportar"
        Me.cdmXportSbs.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(8, 74)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 15)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "SubConjunto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(8, 41)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 15)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Conjunto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(8, 5)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 15)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Tipo de vehiculo"
        '
        'cmdProcesar_Subs
        '
        Me.cmdProcesar_Subs.Location = New System.Drawing.Point(125, 102)
        Me.cmdProcesar_Subs.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdProcesar_Subs.Name = "cmdProcesar_Subs"
        Me.cmdProcesar_Subs.Size = New System.Drawing.Size(79, 30)
        Me.cmdProcesar_Subs.TabIndex = 21
        Me.cmdProcesar_Subs.Text = "&Procesar"
        Me.cmdProcesar_Subs.UseVisualStyleBackColor = True
        '
        'cmdCancelSubs
        '
        Me.cmdCancelSubs.Location = New System.Drawing.Point(222, 102)
        Me.cmdCancelSubs.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdCancelSubs.Name = "cmdCancelSubs"
        Me.cmdCancelSubs.Size = New System.Drawing.Size(79, 30)
        Me.cmdCancelSubs.TabIndex = 20
        Me.cmdCancelSubs.Text = "Cancelar"
        Me.cmdCancelSubs.UseVisualStyleBackColor = True
        '
        'tdbgSubs
        '
        Me.tdbgSubs.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
        Me.tdbgSubs.AllowSort = False
        Me.tdbgSubs.AllowUpdate = False
        Me.tdbgSubs.AlternatingRows = True
        Me.tdbgSubs.BackColor = System.Drawing.Color.DarkGray
        Me.tdbgSubs.CaptionHeight = 23
        Me.tdbgSubs.DataView = C1.Win.C1TrueDBGrid.DataViewEnum.GroupBy
        Me.tdbgSubs.DirectionAfterEnter = C1.Win.C1TrueDBGrid.DirectionAfterEnterEnum.MoveNone
        Me.tdbgSubs.GroupByCaption = "Arrastre una columna para agrupar"
        Me.tdbgSubs.Images.Add(CType(resources.GetObject("tdbgSubs.Images"), System.Drawing.Image))
        Me.tdbgSubs.Location = New System.Drawing.Point(309, 41)
        Me.tdbgSubs.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tdbgSubs.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.HighlightRow
        Me.tdbgSubs.Name = "tdbgSubs"
        Me.tdbgSubs.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.tdbgSubs.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.tdbgSubs.PreviewInfo.ZoomFactor = 75.0R
        Me.tdbgSubs.PrintInfo.PageSettings = CType(resources.GetObject("tdbgSubs.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.tdbgSubs.RowHeight = 21
        Me.tdbgSubs.Size = New System.Drawing.Size(392, 319)
        Me.tdbgSubs.TabIndex = 16
        Me.tdbgSubs.PropBag = resources.GetString("tdbgSubs.PropBag")
        '
        'txtSubConjunto
        '
        Me.txtSubConjunto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSubConjunto.Enabled = False
        Me.txtSubConjunto.Location = New System.Drawing.Point(112, 71)
        Me.txtSubConjunto.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSubConjunto.MaxLength = 15
        Me.txtSubConjunto.Name = "txtSubConjunto"
        Me.txtSubConjunto.Size = New System.Drawing.Size(189, 21)
        Me.txtSubConjunto.TabIndex = 15
        '
        'cboConjunto_SBS
        '
        Me.cboConjunto_SBS.Enabled = False
        Me.cboConjunto_SBS.FormattingEnabled = True
        Me.cboConjunto_SBS.Location = New System.Drawing.Point(112, 38)
        Me.cboConjunto_SBS.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboConjunto_SBS.Name = "cboConjunto_SBS"
        Me.cboConjunto_SBS.Size = New System.Drawing.Size(189, 23)
        Me.cboConjunto_SBS.TabIndex = 1
        '
        'cboTipoVehiculoSBS
        '
        Me.cboTipoVehiculoSBS.Enabled = False
        Me.cboTipoVehiculoSBS.FormattingEnabled = True
        Me.cboTipoVehiculoSBS.Location = New System.Drawing.Point(112, 5)
        Me.cboTipoVehiculoSBS.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboTipoVehiculoSBS.Name = "cboTipoVehiculoSBS"
        Me.cboTipoVehiculoSBS.Size = New System.Drawing.Size(189, 23)
        Me.cboTipoVehiculoSBS.TabIndex = 0
        '
        'stbpReparaciones
        '
        Me.stbpReparaciones.BackColor = System.Drawing.Color.SlateGray
        Me.stbpReparaciones.Controls.Add(Me.tabMode)
        Me.stbpReparaciones.Controls.Add(Me.tdbgFix_Qry)
        Me.stbpReparaciones.ImageIndex = 168
        Me.stbpReparaciones.Location = New System.Drawing.Point(4, 24)
        Me.stbpReparaciones.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.stbpReparaciones.Name = "stbpReparaciones"
        Me.stbpReparaciones.Size = New System.Drawing.Size(709, 365)
        Me.stbpReparaciones.TabIndex = 2
        Me.stbpReparaciones.Text = " Reparaciones"
        '
        'tabMode
        '
        Me.tabMode.Controls.Add(Me.tbpOprFix)
        Me.tabMode.Controls.Add(Me.tbpQryFix)
        Me.tabMode.ImageList = Me.imlSm
        Me.tabMode.Location = New System.Drawing.Point(4, 8)
        Me.tabMode.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tabMode.Name = "tabMode"
        Me.tabMode.SelectedIndex = 0
        Me.tabMode.Size = New System.Drawing.Size(342, 248)
        Me.tabMode.TabIndex = 28
        '
        'tbpOprFix
        '
        Me.tbpOprFix.BackColor = System.Drawing.Color.DimGray
        Me.tbpOprFix.Controls.Add(Me.cmdModify_Rep_Cond)
        Me.tbpOprFix.Controls.Add(Me.cmdOperFix_Process)
        Me.tbpOprFix.Controls.Add(Me.cmdOperFix_Cancel)
        Me.tbpOprFix.Controls.Add(Me.lblOpr_FixDesc)
        Me.tbpOprFix.Controls.Add(Me.txtFix_Description)
        Me.tbpOprFix.Controls.Add(Me.lblOpr_SubC)
        Me.tbpOprFix.Controls.Add(Me.lblOpr_Conj)
        Me.tbpOprFix.Controls.Add(Me.lblOpr_TV)
        Me.tbpOprFix.Controls.Add(Me.cboSubConjuntoFix)
        Me.tbpOprFix.Controls.Add(Me.cboConjunto_Fix)
        Me.tbpOprFix.Controls.Add(Me.cboTipoVehiculo_Fix)
        Me.tbpOprFix.ImageIndex = 176
        Me.tbpOprFix.Location = New System.Drawing.Point(4, 24)
        Me.tbpOprFix.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbpOprFix.Name = "tbpOprFix"
        Me.tbpOprFix.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbpOprFix.Size = New System.Drawing.Size(334, 220)
        Me.tbpOprFix.TabIndex = 0
        Me.tbpOprFix.Text = "Operaciones"
        '
        'cmdModify_Rep_Cond
        '
        Me.cmdModify_Rep_Cond.Enabled = False
        Me.cmdModify_Rep_Cond.ImageIndex = 179
        Me.cmdModify_Rep_Cond.ImageList = Me.imgIconos
        Me.cmdModify_Rep_Cond.Location = New System.Drawing.Point(16, 111)
        Me.cmdModify_Rep_Cond.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdModify_Rep_Cond.Name = "cmdModify_Rep_Cond"
        Me.cmdModify_Rep_Cond.Size = New System.Drawing.Size(75, 62)
        Me.cmdModify_Rep_Cond.TabIndex = 40
        Me.cmdModify_Rep_Cond.UseVisualStyleBackColor = True
        Me.cmdModify_Rep_Cond.Visible = False
        '
        'cmdOperFix_Process
        '
        Me.cmdOperFix_Process.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.cmdOperFix_Process.ImageIndex = 0
        Me.cmdOperFix_Process.ImageList = Me.imgIconos
        Me.cmdOperFix_Process.Location = New System.Drawing.Point(112, 111)
        Me.cmdOperFix_Process.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdOperFix_Process.Name = "cmdOperFix_Process"
        Me.cmdOperFix_Process.Size = New System.Drawing.Size(76, 62)
        Me.cmdOperFix_Process.TabIndex = 39
        Me.cmdOperFix_Process.Text = "&Procesar"
        Me.cmdOperFix_Process.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.cmdOperFix_Process.UseVisualStyleBackColor = True
        '
        'cmdOperFix_Cancel
        '
        Me.cmdOperFix_Cancel.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.cmdOperFix_Cancel.ImageIndex = 38
        Me.cmdOperFix_Cancel.ImageList = Me.imgIconos
        Me.cmdOperFix_Cancel.Location = New System.Drawing.Point(208, 111)
        Me.cmdOperFix_Cancel.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdOperFix_Cancel.Name = "cmdOperFix_Cancel"
        Me.cmdOperFix_Cancel.Size = New System.Drawing.Size(77, 62)
        Me.cmdOperFix_Cancel.TabIndex = 38
        Me.cmdOperFix_Cancel.Text = "Cancelar"
        Me.cmdOperFix_Cancel.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.cmdOperFix_Cancel.UseVisualStyleBackColor = True
        '
        'lblOpr_FixDesc
        '
        Me.lblOpr_FixDesc.AutoSize = True
        Me.lblOpr_FixDesc.ForeColor = System.Drawing.Color.White
        Me.lblOpr_FixDesc.Location = New System.Drawing.Point(13, 80)
        Me.lblOpr_FixDesc.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblOpr_FixDesc.Name = "lblOpr_FixDesc"
        Me.lblOpr_FixDesc.Size = New System.Drawing.Size(71, 15)
        Me.lblOpr_FixDesc.TabIndex = 35
        Me.lblOpr_FixDesc.Text = "Reparacion"
        '
        'txtFix_Description
        '
        Me.txtFix_Description.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtFix_Description.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFix_Description.Enabled = False
        Me.txtFix_Description.ForeColor = System.Drawing.Color.Black
        Me.txtFix_Description.Location = New System.Drawing.Point(112, 80)
        Me.txtFix_Description.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtFix_Description.MaxLength = 15
        Me.txtFix_Description.Name = "txtFix_Description"
        Me.txtFix_Description.Size = New System.Drawing.Size(173, 21)
        Me.txtFix_Description.TabIndex = 34
        '
        'lblOpr_SubC
        '
        Me.lblOpr_SubC.AutoSize = True
        Me.lblOpr_SubC.ForeColor = System.Drawing.Color.White
        Me.lblOpr_SubC.Location = New System.Drawing.Point(8, 62)
        Me.lblOpr_SubC.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblOpr_SubC.Name = "lblOpr_SubC"
        Me.lblOpr_SubC.Size = New System.Drawing.Size(76, 15)
        Me.lblOpr_SubC.TabIndex = 33
        Me.lblOpr_SubC.Text = "Subconjunto"
        '
        'lblOpr_Conj
        '
        Me.lblOpr_Conj.AutoSize = True
        Me.lblOpr_Conj.ForeColor = System.Drawing.Color.White
        Me.lblOpr_Conj.Location = New System.Drawing.Point(8, 29)
        Me.lblOpr_Conj.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblOpr_Conj.Name = "lblOpr_Conj"
        Me.lblOpr_Conj.Size = New System.Drawing.Size(56, 15)
        Me.lblOpr_Conj.TabIndex = 32
        Me.lblOpr_Conj.Text = "Conjunto"
        '
        'lblOpr_TV
        '
        Me.lblOpr_TV.AutoSize = True
        Me.lblOpr_TV.ForeColor = System.Drawing.Color.White
        Me.lblOpr_TV.Location = New System.Drawing.Point(8, 5)
        Me.lblOpr_TV.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblOpr_TV.Name = "lblOpr_TV"
        Me.lblOpr_TV.Size = New System.Drawing.Size(96, 15)
        Me.lblOpr_TV.TabIndex = 31
        Me.lblOpr_TV.Text = "Tipo de vehiculo"
        '
        'cboSubConjuntoFix
        '
        Me.cboSubConjuntoFix.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cboSubConjuntoFix.Enabled = False
        Me.cboSubConjuntoFix.ForeColor = System.Drawing.Color.Black
        Me.cboSubConjuntoFix.FormattingEnabled = True
        Me.cboSubConjuntoFix.Location = New System.Drawing.Point(112, 54)
        Me.cboSubConjuntoFix.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboSubConjuntoFix.Name = "cboSubConjuntoFix"
        Me.cboSubConjuntoFix.Size = New System.Drawing.Size(173, 23)
        Me.cboSubConjuntoFix.TabIndex = 30
        '
        'cboConjunto_Fix
        '
        Me.cboConjunto_Fix.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cboConjunto_Fix.Enabled = False
        Me.cboConjunto_Fix.ForeColor = System.Drawing.Color.Black
        Me.cboConjunto_Fix.FormattingEnabled = True
        Me.cboConjunto_Fix.Location = New System.Drawing.Point(112, 29)
        Me.cboConjunto_Fix.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboConjunto_Fix.Name = "cboConjunto_Fix"
        Me.cboConjunto_Fix.Size = New System.Drawing.Size(173, 23)
        Me.cboConjunto_Fix.TabIndex = 29
        '
        'cboTipoVehiculo_Fix
        '
        Me.cboTipoVehiculo_Fix.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cboTipoVehiculo_Fix.Enabled = False
        Me.cboTipoVehiculo_Fix.ForeColor = System.Drawing.Color.Black
        Me.cboTipoVehiculo_Fix.FormattingEnabled = True
        Me.cboTipoVehiculo_Fix.Location = New System.Drawing.Point(112, 5)
        Me.cboTipoVehiculo_Fix.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboTipoVehiculo_Fix.Name = "cboTipoVehiculo_Fix"
        Me.cboTipoVehiculo_Fix.Size = New System.Drawing.Size(173, 23)
        Me.cboTipoVehiculo_Fix.TabIndex = 28
        '
        'tbpQryFix
        '
        Me.tbpQryFix.BackColor = System.Drawing.Color.Gainsboro
        Me.tbpQryFix.Controls.Add(Me.cmdStarterTV)
        Me.tbpQryFix.Controls.Add(Me.cmdQryFix_Xport)
        Me.tbpQryFix.Controls.Add(Me.cmdQryFixQry)
        Me.tbpQryFix.Controls.Add(Me.lblQry_SubC)
        Me.tbpQryFix.Controls.Add(Me.lblQry_Conj)
        Me.tbpQryFix.Controls.Add(Me.lblQry_TV)
        Me.tbpQryFix.Controls.Add(Me.cboQry_Fix_SubC)
        Me.tbpQryFix.Controls.Add(Me.cboQry_Fix_Conj)
        Me.tbpQryFix.Controls.Add(Me.cboQry_Fix_Tv)
        Me.tbpQryFix.ImageIndex = 175
        Me.tbpQryFix.Location = New System.Drawing.Point(4, 24)
        Me.tbpQryFix.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbpQryFix.Name = "tbpQryFix"
        Me.tbpQryFix.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbpQryFix.Size = New System.Drawing.Size(334, 220)
        Me.tbpQryFix.TabIndex = 1
        Me.tbpQryFix.Text = "Consulta"
        '
        'cmdStarterTV
        '
        Me.cmdStarterTV.ImageIndex = 90
        Me.cmdStarterTV.ImageList = Me.imlSm
        Me.cmdStarterTV.Location = New System.Drawing.Point(295, 9)
        Me.cmdStarterTV.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdStarterTV.Name = "cmdStarterTV"
        Me.cmdStarterTV.Size = New System.Drawing.Size(32, 23)
        Me.cmdStarterTV.TabIndex = 41
        Me.cmdStarterTV.UseVisualStyleBackColor = True
        '
        'imlSm
        '
        Me.imlSm.ImageStream = CType(resources.GetObject("imlSm.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imlSm.TransparentColor = System.Drawing.Color.Transparent
        Me.imlSm.Images.SetKeyName(0, "add.ico")
        Me.imlSm.Images.SetKeyName(1, "add-favorite.ico")
        Me.imlSm.Images.SetKeyName(2, "add-file.ico")
        Me.imlSm.Images.SetKeyName(3, "add-folder.ico")
        Me.imlSm.Images.SetKeyName(4, "add-note.ico")
        Me.imlSm.Images.SetKeyName(5, "add-printer.ico")
        Me.imlSm.Images.SetKeyName(6, "add-star.ico")
        Me.imlSm.Images.SetKeyName(7, "add-user.ico")
        Me.imlSm.Images.SetKeyName(8, "alert.ico")
        Me.imlSm.Images.SetKeyName(9, "annexed.ico")
        Me.imlSm.Images.SetKeyName(10, "back.ico")
        Me.imlSm.Images.SetKeyName(11, "back-.ico")
        Me.imlSm.Images.SetKeyName(12, "back-2.ico")
        Me.imlSm.Images.SetKeyName(13, "back-3.ico")
        Me.imlSm.Images.SetKeyName(14, "basket.ico")
        Me.imlSm.Images.SetKeyName(15, "book.ico")
        Me.imlSm.Images.SetKeyName(16, "box.ico")
        Me.imlSm.Images.SetKeyName(17, "burn.ico")
        Me.imlSm.Images.SetKeyName(18, "cal.ico")
        Me.imlSm.Images.SetKeyName(19, "calculator.ico")
        Me.imlSm.Images.SetKeyName(20, "camera.ico")
        Me.imlSm.Images.SetKeyName(21, "cash-register.ico")
        Me.imlSm.Images.SetKeyName(22, "cc.ico")
        Me.imlSm.Images.SetKeyName(23, "cd.ico")
        Me.imlSm.Images.SetKeyName(24, "chat.ico")
        Me.imlSm.Images.SetKeyName(25, "clock.ico")
        Me.imlSm.Images.SetKeyName(26, "contacts.ico")
        Me.imlSm.Images.SetKeyName(27, "copy.ico")
        Me.imlSm.Images.SetKeyName(28, "cut.ico")
        Me.imlSm.Images.SetKeyName(29, "db.ico")
        Me.imlSm.Images.SetKeyName(30, "db1.ico")
        Me.imlSm.Images.SetKeyName(31, "db2.ico")
        Me.imlSm.Images.SetKeyName(32, "db3.ico")
        Me.imlSm.Images.SetKeyName(33, "db4.ico")
        Me.imlSm.Images.SetKeyName(34, "db5.ico")
        Me.imlSm.Images.SetKeyName(35, "db6.ico")
        Me.imlSm.Images.SetKeyName(36, "db7.ico")
        Me.imlSm.Images.SetKeyName(37, "ddb8.ico")
        Me.imlSm.Images.SetKeyName(38, "delete.ico")
        Me.imlSm.Images.SetKeyName(39, "delete-user.ico")
        Me.imlSm.Images.SetKeyName(40, "down.ico")
        Me.imlSm.Images.SetKeyName(41, "down-.ico")
        Me.imlSm.Images.SetKeyName(42, "download.ico")
        Me.imlSm.Images.SetKeyName(43, "edit.ico")
        Me.imlSm.Images.SetKeyName(44, "edit-tool.ico")
        Me.imlSm.Images.SetKeyName(45, "email.ico")
        Me.imlSm.Images.SetKeyName(46, "engine.ico")
        Me.imlSm.Images.SetKeyName(47, "explorer.ico")
        Me.imlSm.Images.SetKeyName(48, "fast-forward.ico")
        Me.imlSm.Images.SetKeyName(49, "file.ico")
        Me.imlSm.Images.SetKeyName(50, "file-lock.ico")
        Me.imlSm.Images.SetKeyName(51, "find-at-disc.ico")
        Me.imlSm.Images.SetKeyName(52, "find-file.ico")
        Me.imlSm.Images.SetKeyName(53, "first-page.ico")
        Me.imlSm.Images.SetKeyName(54, "folder.ico")
        Me.imlSm.Images.SetKeyName(55, "folder-open.ico")
        Me.imlSm.Images.SetKeyName(56, "forward.ico")
        Me.imlSm.Images.SetKeyName(57, "ftp.ico")
        Me.imlSm.Images.SetKeyName(58, "full-basket.ico")
        Me.imlSm.Images.SetKeyName(59, "group.ico")
        Me.imlSm.Images.SetKeyName(60, "hd.ico")
        Me.imlSm.Images.SetKeyName(61, "hd-as.ico")
        Me.imlSm.Images.SetKeyName(62, "help.ico")
        Me.imlSm.Images.SetKeyName(63, "history.ico")
        Me.imlSm.Images.SetKeyName(64, "home.ico")
        Me.imlSm.Images.SetKeyName(65, "html.ico")
        Me.imlSm.Images.SetKeyName(66, "info.ico")
        Me.imlSm.Images.SetKeyName(67, "install.ico")
        Me.imlSm.Images.SetKeyName(68, "installer.ico")
        Me.imlSm.Images.SetKeyName(69, "last-page.ico")
        Me.imlSm.Images.SetKeyName(70, "lock.ico")
        Me.imlSm.Images.SetKeyName(71, "misc1.ico")
        Me.imlSm.Images.SetKeyName(72, "misc2.ico")
        Me.imlSm.Images.SetKeyName(73, "misc3.ico")
        Me.imlSm.Images.SetKeyName(74, "misc4.ico")
        Me.imlSm.Images.SetKeyName(75, "monitor.ico")
        Me.imlSm.Images.SetKeyName(76, "network.ico")
        Me.imlSm.Images.SetKeyName(77, "next-.ico")
        Me.imlSm.Images.SetKeyName(78, "next-2.ico")
        Me.imlSm.Images.SetKeyName(79, "note.ico")
        Me.imlSm.Images.SetKeyName(80, "ok.ico")
        Me.imlSm.Images.SetKeyName(81, "paste.ico")
        Me.imlSm.Images.SetKeyName(82, "pause.ico")
        Me.imlSm.Images.SetKeyName(83, "pictures.ico")
        Me.imlSm.Images.SetKeyName(84, "play.ico")
        Me.imlSm.Images.SetKeyName(85, "police.ico")
        Me.imlSm.Images.SetKeyName(86, "price.ico")
        Me.imlSm.Images.SetKeyName(87, "print.ico")
        Me.imlSm.Images.SetKeyName(88, "print-preview.ico")
        Me.imlSm.Images.SetKeyName(89, "record.ico")
        Me.imlSm.Images.SetKeyName(90, "refresh.ico")
        Me.imlSm.Images.SetKeyName(91, "remove.ico")
        Me.imlSm.Images.SetKeyName(92, "remove-file.ico")
        Me.imlSm.Images.SetKeyName(93, "remove-folder.ico")
        Me.imlSm.Images.SetKeyName(94, "remove-note.ico")
        Me.imlSm.Images.SetKeyName(95, "reward.ico")
        Me.imlSm.Images.SetKeyName(96, "save.ico")
        Me.imlSm.Images.SetKeyName(97, "save-as.ico")
        Me.imlSm.Images.SetKeyName(98, "save-new.ico")
        Me.imlSm.Images.SetKeyName(99, "search.ico")
        Me.imlSm.Images.SetKeyName(100, "smiley.ico")
        Me.imlSm.Images.SetKeyName(101, "sound.ico")
        Me.imlSm.Images.SetKeyName(102, "sound-off.ico")
        Me.imlSm.Images.SetKeyName(103, "star.ico")
        Me.imlSm.Images.SetKeyName(104, "statistics.ico")
        Me.imlSm.Images.SetKeyName(105, "statistics2.ico")
        Me.imlSm.Images.SetKeyName(106, "stop.ico")
        Me.imlSm.Images.SetKeyName(107, "stop2.ico")
        Me.imlSm.Images.SetKeyName(108, "support.ico")
        Me.imlSm.Images.SetKeyName(109, "uninstall.ico")
        Me.imlSm.Images.SetKeyName(110, "unlock.ico")
        Me.imlSm.Images.SetKeyName(111, "up.ico")
        Me.imlSm.Images.SetKeyName(112, "up-.ico")
        Me.imlSm.Images.SetKeyName(113, "upload.ico")
        Me.imlSm.Images.SetKeyName(114, "user2.ico")
        Me.imlSm.Images.SetKeyName(115, "user3.ico")
        Me.imlSm.Images.SetKeyName(116, "user-offline.ico")
        Me.imlSm.Images.SetKeyName(117, "user-online.ico")
        Me.imlSm.Images.SetKeyName(118, "view.ico")
        Me.imlSm.Images.SetKeyName(119, "view-save.ico")
        Me.imlSm.Images.SetKeyName(120, "web-dir.ico")
        Me.imlSm.Images.SetKeyName(121, "web-search.ico")
        Me.imlSm.Images.SetKeyName(122, "window.ico")
        Me.imlSm.Images.SetKeyName(123, "windows.ico")
        Me.imlSm.Images.SetKeyName(124, "zoom-.ico")
        Me.imlSm.Images.SetKeyName(125, "zoom+.ico")
        Me.imlSm.Images.SetKeyName(126, "Antrepo-Container-2-CAI.ico")
        Me.imlSm.Images.SetKeyName(127, "Antrepo-Container-2-Hapag-4.ico")
        Me.imlSm.Images.SetKeyName(128, "Antrepo-Container-2-P-O4.ico")
        Me.imlSm.Images.SetKeyName(129, "Antrepo-Container-4-Cargo-Vans-DHL-Van-Front.ico")
        Me.imlSm.Images.SetKeyName(130, "Antrepo-Container-4-Cargo-Vans-Dribbble-Van-Back.ico")
        Me.imlSm.Images.SetKeyName(131, "Antrepo-Container-4-Cargo-Vans-Dribbble-Van-Front.ico")
        Me.imlSm.Images.SetKeyName(132, "Antrepo-Container-4-Cargo-Vans-Facebook-Van-Back.ico")
        Me.imlSm.Images.SetKeyName(133, "Antrepo-Container-4-Cargo-Vans-Facebook-Van-Front.ico")
        Me.imlSm.Images.SetKeyName(134, "Antrepo-Container-4-Cargo-Vans-FedEx-Van-Back.ico")
        Me.imlSm.Images.SetKeyName(135, "Antrepo-Container-4-Cargo-Vans-FedEx-Van-Front.ico")
        Me.imlSm.Images.SetKeyName(136, "Antrepo-Container-4-Cargo-Vans-Flickr-Van-Back.ico")
        Me.imlSm.Images.SetKeyName(137, "Antrepo-Container-4-Cargo-Vans-Google-Van-Front.ico")
        Me.imlSm.Images.SetKeyName(138, "Antrepo-Container-4-Cargo-Vans-Instagram-Van-Back.ico")
        Me.imlSm.Images.SetKeyName(139, "Antrepo-Container-4-Cargo-Vans-Instagram-Van-Front.ico")
        Me.imlSm.Images.SetKeyName(140, "Antrepo-Container-4-Cargo-Vans-Linkedin-Van-Back.ico")
        Me.imlSm.Images.SetKeyName(141, "Antrepo-Container-4-Cargo-Vans-Linkedin-Van-Front.ico")
        Me.imlSm.Images.SetKeyName(142, "Antrepo-Container-4-Cargo-Vans-Pinterest-Van-Back.ico")
        Me.imlSm.Images.SetKeyName(143, "Antrepo-Container-4-Cargo-Vans-TNT-Van-Back.ico")
        Me.imlSm.Images.SetKeyName(144, "Antrepo-Container-4-Cargo-Vans-Tumblr-Van-Back.ico")
        Me.imlSm.Images.SetKeyName(145, "Antrepo-Container-4-Cargo-Vans-Tumblr-Van-Front.ico")
        Me.imlSm.Images.SetKeyName(146, "Antrepo-Container-4-Cargo-Vans-Twitter-Van-Front.ico")
        Me.imlSm.Images.SetKeyName(147, "Antrepo-Container-4-Cargo-Vans-UPS-Van-Front.ico")
        Me.imlSm.Images.SetKeyName(148, "Antrepo-Container-4-Cargo-Vans-Yahoo-Van-Front.ico")
        Me.imlSm.Images.SetKeyName(149, "Antrepo-Container-4-Cargo-Vans-YouTube-Van-Back.ico")
        Me.imlSm.Images.SetKeyName(150, "Antrepo-Container-After-Effects.ico")
        Me.imlSm.Images.SetKeyName(151, "Antrepo-Container-Orange.ico")
        Me.imlSm.Images.SetKeyName(152, "Icons8-Windows-8-Business-Organization.ico")
        Me.imlSm.Images.SetKeyName(153, "Icons8-Windows-8-Business-Org-Unit.ico")
        Me.imlSm.Images.SetKeyName(154, "Icons8-Windows-8-Business-Overtime.ico")
        Me.imlSm.Images.SetKeyName(155, "Icons8-Windows-8-Business-Package.ico")
        Me.imlSm.Images.SetKeyName(156, "Icons8-Windows-8-Business-Parallel-Tasks.ico")
        Me.imlSm.Images.SetKeyName(157, "Icons8-Windows-8-Business-Planner.ico")
        Me.imlSm.Images.SetKeyName(158, "Icons8-Windows-8-Business-Process.ico")
        Me.imlSm.Images.SetKeyName(159, "Icons8-Windows-8-Business-Self-Service-Kiosk.ico")
        Me.imlSm.Images.SetKeyName(160, "Icons8-Windows-8-Business-Serial-Tasks.ico")
        Me.imlSm.Images.SetKeyName(161, "Icons8-Windows-8-Cinema-Adventures.ico")
        Me.imlSm.Images.SetKeyName(162, "Icons8-Windows-8-City-Police-Badge.ico")
        Me.imlSm.Images.SetKeyName(163, "Icons8-Windows-8-Database.ico")
        Me.imlSm.Images.SetKeyName(164, "Icons8-Windows-8-Database-Accept.ico")
        Me.imlSm.Images.SetKeyName(165, "Icons8-Windows-8-Database-Add.ico")
        Me.imlSm.Images.SetKeyName(166, "Icons8-Windows-8-Database-Backup.ico")
        Me.imlSm.Images.SetKeyName(167, "Icons8-Windows-8-Database-Configuration.ico")
        Me.imlSm.Images.SetKeyName(168, "Icons8-Windows-8-Diy-Drill.ico")
        Me.imlSm.Images.SetKeyName(169, "Icons8-Windows-8-Diy-Hammer.ico")
        Me.imlSm.Images.SetKeyName(170, "Icons8-Windows-8-Ecommerce-Delivery.ico")
        Me.imlSm.Images.SetKeyName(171, "Icons8-Windows-8-Files-Hot-Article.ico")
        Me.imlSm.Images.SetKeyName(172, "Icons8-Windows-8-Healthcare-Ambulance.ico")
        Me.imlSm.Images.SetKeyName(173, "Icons8-Windows-8-Industry-Automatic.ico")
        Me.imlSm.Images.SetKeyName(174, "Icons8-Windows-8-Industry-Automotive.ico")
        Me.imlSm.Images.SetKeyName(175, "Icons8-Windows-8-Industry-Electro-Devices.ico")
        Me.imlSm.Images.SetKeyName(176, "Icons8-Windows-8-Industry-Engineering.ico")
        Me.imlSm.Images.SetKeyName(177, "Icons8-Windows-8-Industry-Manual.ico")
        Me.imlSm.Images.SetKeyName(178, "Icons8-Windows-8-Industry-Oil-Industry.ico")
        Me.imlSm.Images.SetKeyName(179, "Icons8-Windows-8-Industry-Poison.ico")
        Me.imlSm.Images.SetKeyName(180, "Icons8-Windows-8-Industry-Trash.ico")
        Me.imlSm.Images.SetKeyName(181, "Icons8-Windows-8-Maps-Center-Direction.ico")
        Me.imlSm.Images.SetKeyName(182, "Icons8-Windows-8-Maps-Gps-Searching.ico")
        Me.imlSm.Images.SetKeyName(183, "Iconshock-Real-Vista-Accounting-Truck.ico")
        Me.imlSm.Images.SetKeyName(184, "Icons-Land-Transport-Container (1).ico")
        Me.imlSm.Images.SetKeyName(185, "Icons-Land-Transport-Container.ico")
        Me.imlSm.Images.SetKeyName(186, "Icons-Land-Transporter-Fire-Truck-Front-Red.ico")
        Me.imlSm.Images.SetKeyName(187, "Icons-Land-Transporter-FuelTank-Truck-Front-Grey (1).ico")
        Me.imlSm.Images.SetKeyName(188, "Icons-Land-Transporter-FuelTank-Truck-Front-Grey.ico")
        Me.imlSm.Images.SetKeyName(189, "Icons-Land-Transporter-FuelTank-Truck-Left-Grey.ico")
        Me.imlSm.Images.SetKeyName(190, "Icons-Land-Transporter-FuelTank-Truck-Right-Grey.ico")
        Me.imlSm.Images.SetKeyName(191, "Icons-Land-Transporter-FuelTank-Truck-Top-Grey.ico")
        Me.imlSm.Images.SetKeyName(192, "Icons-Land-Transporter-Truck-Front-Green.ico")
        Me.imlSm.Images.SetKeyName(193, "Icons-Land-Transporter-Truck-Left-Green.ico")
        Me.imlSm.Images.SetKeyName(194, "Icons-Land-Transporter-Truck-Right-Green.ico")
        Me.imlSm.Images.SetKeyName(195, "Icons-Land-Transport-ExecutiveCar.ico")
        Me.imlSm.Images.SetKeyName(196, "Icons-Land-Transport-Lorry.ico")
        Me.imlSm.Images.SetKeyName(197, "Icons-Land-Transport-TractorUnit.ico")
        Me.imlSm.Images.SetKeyName(198, "Icons-Land-Transport-Truck.ico")
        Me.imlSm.Images.SetKeyName(199, "Icons-Land-Transport-Wheel.ico")
        Me.imlSm.Images.SetKeyName(200, "lorrygreen.ico")
        Me.imlSm.Images.SetKeyName(201, "tanker_truck.ico")
        Me.imlSm.Images.SetKeyName(202, "tractorunitblack.ico")
        Me.imlSm.Images.SetKeyName(203, "truckyellow.ico")
        '
        'cmdQryFix_Xport
        '
        Me.cmdQryFix_Xport.Enabled = False
        Me.cmdQryFix_Xport.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.cmdQryFix_Xport.ImageIndex = 56
        Me.cmdQryFix_Xport.ImageList = Me.imgIconos
        Me.cmdQryFix_Xport.Location = New System.Drawing.Point(187, 91)
        Me.cmdQryFix_Xport.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdQryFix_Xport.Name = "cmdQryFix_Xport"
        Me.cmdQryFix_Xport.Size = New System.Drawing.Size(100, 36)
        Me.cmdQryFix_Xport.TabIndex = 40
        Me.cmdQryFix_Xport.Text = "Exportar"
        Me.cmdQryFix_Xport.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.cmdQryFix_Xport.UseVisualStyleBackColor = True
        Me.cmdQryFix_Xport.Visible = False
        '
        'cmdQryFixQry
        '
        Me.cmdQryFixQry.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.cmdQryFixQry.ImageIndex = 47
        Me.cmdQryFixQry.ImageList = Me.imgIconos
        Me.cmdQryFixQry.Location = New System.Drawing.Point(11, 91)
        Me.cmdQryFixQry.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmdQryFixQry.Name = "cmdQryFixQry"
        Me.cmdQryFixQry.Size = New System.Drawing.Size(100, 36)
        Me.cmdQryFixQry.TabIndex = 39
        Me.cmdQryFixQry.Text = "Consultar"
        Me.cmdQryFixQry.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.cmdQryFixQry.UseVisualStyleBackColor = True
        '
        'lblQry_SubC
        '
        Me.lblQry_SubC.AutoSize = True
        Me.lblQry_SubC.ForeColor = System.Drawing.Color.Black
        Me.lblQry_SubC.Location = New System.Drawing.Point(8, 58)
        Me.lblQry_SubC.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblQry_SubC.Name = "lblQry_SubC"
        Me.lblQry_SubC.Size = New System.Drawing.Size(76, 15)
        Me.lblQry_SubC.TabIndex = 33
        Me.lblQry_SubC.Text = "Subconjunto"
        '
        'lblQry_Conj
        '
        Me.lblQry_Conj.AutoSize = True
        Me.lblQry_Conj.ForeColor = System.Drawing.Color.Black
        Me.lblQry_Conj.Location = New System.Drawing.Point(8, 34)
        Me.lblQry_Conj.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblQry_Conj.Name = "lblQry_Conj"
        Me.lblQry_Conj.Size = New System.Drawing.Size(56, 15)
        Me.lblQry_Conj.TabIndex = 32
        Me.lblQry_Conj.Text = "Conjunto"
        '
        'lblQry_TV
        '
        Me.lblQry_TV.AutoSize = True
        Me.lblQry_TV.ForeColor = System.Drawing.Color.Black
        Me.lblQry_TV.Location = New System.Drawing.Point(8, 9)
        Me.lblQry_TV.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblQry_TV.Name = "lblQry_TV"
        Me.lblQry_TV.Size = New System.Drawing.Size(96, 15)
        Me.lblQry_TV.TabIndex = 31
        Me.lblQry_TV.Text = "Tipo de vehiculo"
        '
        'cboQry_Fix_SubC
        '
        Me.cboQry_Fix_SubC.Enabled = False
        Me.cboQry_Fix_SubC.ForeColor = System.Drawing.Color.Black
        Me.cboQry_Fix_SubC.FormattingEnabled = True
        Me.cboQry_Fix_SubC.Location = New System.Drawing.Point(117, 55)
        Me.cboQry_Fix_SubC.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboQry_Fix_SubC.Name = "cboQry_Fix_SubC"
        Me.cboQry_Fix_SubC.Size = New System.Drawing.Size(170, 23)
        Me.cboQry_Fix_SubC.TabIndex = 30
        '
        'cboQry_Fix_Conj
        '
        Me.cboQry_Fix_Conj.Enabled = False
        Me.cboQry_Fix_Conj.ForeColor = System.Drawing.Color.Black
        Me.cboQry_Fix_Conj.FormattingEnabled = True
        Me.cboQry_Fix_Conj.Location = New System.Drawing.Point(117, 31)
        Me.cboQry_Fix_Conj.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboQry_Fix_Conj.Name = "cboQry_Fix_Conj"
        Me.cboQry_Fix_Conj.Size = New System.Drawing.Size(170, 23)
        Me.cboQry_Fix_Conj.TabIndex = 29
        '
        'cboQry_Fix_Tv
        '
        Me.cboQry_Fix_Tv.Enabled = False
        Me.cboQry_Fix_Tv.ForeColor = System.Drawing.Color.Black
        Me.cboQry_Fix_Tv.FormattingEnabled = True
        Me.cboQry_Fix_Tv.Location = New System.Drawing.Point(117, 6)
        Me.cboQry_Fix_Tv.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboQry_Fix_Tv.Name = "cboQry_Fix_Tv"
        Me.cboQry_Fix_Tv.Size = New System.Drawing.Size(170, 23)
        Me.cboQry_Fix_Tv.TabIndex = 28
        '
        'tdbgFix_Qry
        '
        Me.tdbgFix_Qry.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
        Me.tdbgFix_Qry.AllowSort = False
        Me.tdbgFix_Qry.AllowUpdate = False
        Me.tdbgFix_Qry.AlternatingRows = True
        Me.tdbgFix_Qry.BackColor = System.Drawing.Color.DarkGray
        Me.tdbgFix_Qry.CaptionHeight = 23
        Me.tdbgFix_Qry.DirectionAfterEnter = C1.Win.C1TrueDBGrid.DirectionAfterEnterEnum.MoveNone
        Me.tdbgFix_Qry.GroupByCaption = "Arrastre una columna para agrupar"
        Me.tdbgFix_Qry.Images.Add(CType(resources.GetObject("tdbgFix_Qry.Images"), System.Drawing.Image))
        Me.tdbgFix_Qry.Location = New System.Drawing.Point(350, 8)
        Me.tdbgFix_Qry.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tdbgFix_Qry.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.HighlightRow
        Me.tdbgFix_Qry.Name = "tdbgFix_Qry"
        Me.tdbgFix_Qry.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.tdbgFix_Qry.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.tdbgFix_Qry.PreviewInfo.ZoomFactor = 75.0R
        Me.tdbgFix_Qry.PrintInfo.PageSettings = CType(resources.GetObject("tdbgFix_Qry.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.tdbgFix_Qry.RowHeight = 21
        Me.tdbgFix_Qry.Size = New System.Drawing.Size(348, 352)
        Me.tdbgFix_Qry.TabIndex = 17
        Me.tdbgFix_Qry.PropBag = resources.GetString("tdbgFix_Qry.PropBag")
        '
        'frmCatalogos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(887, 471)
        Me.Controls.Add(Me.tabCat_Generales)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "frmCatalogos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Catalogos generales"
        Me.tabCat_Generales.ResumeLayout(False)
        Me.tbpMarca.ResumeLayout(False)
        Me.tbpMarca.PerformLayout()
        CType(Me.tdbgMarca, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbpTipoVehiculo.ResumeLayout(False)
        Me.tbpTipoVehiculo.PerformLayout()
        CType(Me.tdbgTiposVehiculo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbpUnidades.ResumeLayout(False)
        Me.tbpUnidades.PerformLayout()
        CType(Me.numAño, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tdbgUnidades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbpConfs.ResumeLayout(False)
        Me.tabDetailsConjs.ResumeLayout(False)
        Me.stbpConjuntos.ResumeLayout(False)
        Me.stbpConjuntos.PerformLayout()
        CType(Me.TDbgConjuntos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.stbpSubconjuntos.ResumeLayout(False)
        Me.stbpSubconjuntos.PerformLayout()
        CType(Me.tdbgSubs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.stbpReparaciones.ResumeLayout(False)
        Me.tabMode.ResumeLayout(False)
        Me.tbpOprFix.ResumeLayout(False)
        Me.tbpOprFix.PerformLayout()
        Me.tbpQryFix.ResumeLayout(False)
        Me.tbpQryFix.PerformLayout()
        CType(Me.tdbgFix_Qry, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabCat_Generales As System.Windows.Forms.TabControl
    Friend WithEvents tbpTipoVehiculo As System.Windows.Forms.TabPage
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents cboUso As System.Windows.Forms.ComboBox
    Friend WithEvents cboCombustible As System.Windows.Forms.ComboBox
    Friend WithEvents lblDescripcion As System.Windows.Forms.Label
    Friend WithEvents lblUso As System.Windows.Forms.Label
    Friend WithEvents lblCombustible As System.Windows.Forms.Label
    Friend WithEvents cmdCancelTipoVeh As System.Windows.Forms.Button
    Friend WithEvents cmdProcesarTipoVeh As System.Windows.Forms.Button
    Friend WithEvents cmdXprtTiVh As System.Windows.Forms.Button
    Friend WithEvents tdbgTiposVehiculo As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents tbpUnidades As System.Windows.Forms.TabPage
    Friend WithEvents cmdKill As System.Windows.Forms.Button
    Friend WithEvents imgIconos As System.Windows.Forms.ImageList
    Friend WithEvents tdbgUnidades As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents txtSerieChasis As System.Windows.Forms.TextBox
    Friend WithEvents txtSerieMotor As System.Windows.Forms.TextBox
    Friend WithEvents txtEco As System.Windows.Forms.TextBox
    Friend WithEvents cboTipoUnidad As System.Windows.Forms.ComboBox
    Friend WithEvents cmdKillUnit As System.Windows.Forms.Button
    Friend WithEvents cmdCancelarVehiculo As System.Windows.Forms.Button
    Friend WithEvents cmdProcesarVehiculo As System.Windows.Forms.Button
    Friend WithEvents lblTipoVehiculo As System.Windows.Forms.Label
    Friend WithEvents lblChasis As System.Windows.Forms.Label
    Friend WithEvents lblMotor As System.Windows.Forms.Label
    Friend WithEvents lblEco As System.Windows.Forms.Label
    Friend WithEvents cmdXprtVehiculo As System.Windows.Forms.Button
    Friend WithEvents tbpMarca As System.Windows.Forms.TabPage
    Friend WithEvents txtMarca As System.Windows.Forms.TextBox
    Friend WithEvents tdbgMarca As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdCancelMarca As System.Windows.Forms.Button
    Friend WithEvents cmdProcessMarca As System.Windows.Forms.Button
    Friend WithEvents cboMarca As System.Windows.Forms.ComboBox
    Friend WithEvents lblMarca As System.Windows.Forms.Label
    Friend WithEvents cmdXporMarca As System.Windows.Forms.Button
    Friend WithEvents txtMatricula As System.Windows.Forms.TextBox
    Friend WithEvents lblMatricula As System.Windows.Forms.Label
    Friend WithEvents lblAño As System.Windows.Forms.Label
    Friend WithEvents lblModelo As System.Windows.Forms.Label
    Friend WithEvents numAño As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtModelo As System.Windows.Forms.TextBox
    Friend WithEvents cmdXportUns As System.Windows.Forms.Button
    Friend WithEvents tbpConfs As System.Windows.Forms.TabPage
    Friend WithEvents tabDetailsConjs As System.Windows.Forms.TabControl
    Friend WithEvents stbpConjuntos As System.Windows.Forms.TabPage
    Friend WithEvents stbpSubconjuntos As System.Windows.Forms.TabPage
    Friend WithEvents stbpReparaciones As System.Windows.Forms.TabPage
    Friend WithEvents TDbgConjuntos As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents cboTVConjuntos As System.Windows.Forms.ComboBox
    Friend WithEvents txtSCConj As System.Windows.Forms.TextBox
    Friend WithEvents cmdProces_conjunto As System.Windows.Forms.Button
    Friend WithEvents cmdCancel_Conj As System.Windows.Forms.Button
    Friend WithEvents cmdQueryC As System.Windows.Forms.Button
    Friend WithEvents cmdXport_C As System.Windows.Forms.Button
    Friend WithEvents lblTipoVehiculo_C As System.Windows.Forms.Label
    Friend WithEvents lblConjunto As System.Windows.Forms.Label
    Friend WithEvents cmdKillConj As System.Windows.Forms.Button
    Friend WithEvents txtSubConjunto As System.Windows.Forms.TextBox
    Friend WithEvents cboConjunto_SBS As System.Windows.Forms.ComboBox
    Friend WithEvents cboTipoVehiculoSBS As System.Windows.Forms.ComboBox
    Friend WithEvents tdbgSubs As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmdProcesar_Subs As System.Windows.Forms.Button
    Friend WithEvents cmdCancelSubs As System.Windows.Forms.Button
    Friend WithEvents cmdQueySubs As System.Windows.Forms.Button
    Friend WithEvents cdmXportSbs As System.Windows.Forms.Button
    Friend WithEvents tdbgFix_Qry As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents tabMode As System.Windows.Forms.TabControl
    Friend WithEvents tbpOprFix As System.Windows.Forms.TabPage
    Friend WithEvents tbpQryFix As System.Windows.Forms.TabPage
    Friend WithEvents lblQry_SubC As System.Windows.Forms.Label
    Friend WithEvents lblQry_Conj As System.Windows.Forms.Label
    Friend WithEvents lblQry_TV As System.Windows.Forms.Label
    Friend WithEvents cboQry_Fix_SubC As System.Windows.Forms.ComboBox
    Friend WithEvents cboQry_Fix_Conj As System.Windows.Forms.ComboBox
    Friend WithEvents cboQry_Fix_Tv As System.Windows.Forms.ComboBox
    Friend WithEvents lblOpr_FixDesc As System.Windows.Forms.Label
    Friend WithEvents txtFix_Description As System.Windows.Forms.TextBox
    Friend WithEvents lblOpr_SubC As System.Windows.Forms.Label
    Friend WithEvents lblOpr_Conj As System.Windows.Forms.Label
    Friend WithEvents lblOpr_TV As System.Windows.Forms.Label
    Friend WithEvents cboSubConjuntoFix As System.Windows.Forms.ComboBox
    Friend WithEvents cboConjunto_Fix As System.Windows.Forms.ComboBox
    Friend WithEvents cboTipoVehiculo_Fix As System.Windows.Forms.ComboBox
    Friend WithEvents imlSm As System.Windows.Forms.ImageList
    Friend WithEvents cmdOperFix_Process As System.Windows.Forms.Button
    Friend WithEvents cmdOperFix_Cancel As System.Windows.Forms.Button
    Friend WithEvents cmdQryFixQry As System.Windows.Forms.Button
    Friend WithEvents cmdQryFix_Xport As System.Windows.Forms.Button
    Friend WithEvents cmdStarterTV As System.Windows.Forms.Button
    Friend WithEvents cmdModify_Rep_Cond As System.Windows.Forms.Button
End Class
