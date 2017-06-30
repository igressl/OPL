<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAlmacen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAlmacen))
        Me.imgIconos = New System.Windows.Forms.ImageList(Me.components)
        Me.imlSm = New System.Windows.Forms.ImageList(Me.components)
        Me.tb_almacenes = New System.Windows.Forms.TabControl()
        Me.tbp_movimientos = New System.Windows.Forms.TabPage()
        Me.QrCodeImgControl1 = New Gma.QrCodeNet.Encoding.Windows.Forms.QrCodeImgControl()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.C1TrueDBGrid1 = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.tbp_catalogos = New System.Windows.Forms.TabPage()
        Me.tbc_catalogos = New System.Windows.Forms.TabControl()
        Me.tbp_articulos = New System.Windows.Forms.TabPage()
        Me.lbl_desc_art = New System.Windows.Forms.Label()
        Me.txt_descrip_art = New System.Windows.Forms.TextBox()
        Me.cmd_prcs_qry = New System.Windows.Forms.Button()
        Me.cmd_xport_qry = New System.Windows.Forms.Button()
        Me.cbo_tip_mov_qry = New System.Windows.Forms.ComboBox()
        Me.dtp_fin = New System.Windows.Forms.DateTimePicker()
        Me.dtp_ini = New System.Windows.Forms.DateTimePicker()
        Me.cmd_canc_art = New System.Windows.Forms.Button()
        Me.cmd_prc_art = New System.Windows.Forms.Button()
        Me.tdbg_itm_mvs = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbo_typ_fuel = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbo_typ_conj = New System.Windows.Forms.ComboBox()
        Me.cbo_typ_veh = New System.Windows.Forms.ComboBox()
        Me.lbl_num_parte = New System.Windows.Forms.Label()
        Me.txt_num_parte = New System.Windows.Forms.TextBox()
        Me.lbl_articulo = New System.Windows.Forms.Label()
        Me.txt_cod_interno = New System.Windows.Forms.TextBox()
        Me.qr_codigo_item = New Gma.QrCodeNet.Encoding.Windows.Forms.QrCodeImgControl()
        Me.tbp_ubicaciones = New System.Windows.Forms.TabPage()
        Me.cmd_kill_ubq = New System.Windows.Forms.Button()
        Me.cmd_qry_ents = New System.Windows.Forms.Button()
        Me.cmd_cnl_ubs = New System.Windows.Forms.Button()
        Me.cmd_prc_ubs = New System.Windows.Forms.Button()
        Me.lbl_ubq_prc = New System.Windows.Forms.Label()
        Me.lbl_anq_prc = New System.Windows.Forms.Label()
        Me.lbl_almacen = New System.Windows.Forms.Label()
        Me.cbo_prc_alm = New System.Windows.Forms.ComboBox()
        Me.cbo_prc_anaq = New System.Windows.Forms.ComboBox()
        Me.cbo_prc_ubi = New System.Windows.Forms.ComboBox()
        Me.lbl_ent = New System.Windows.Forms.Label()
        Me.cbo_entidad = New System.Windows.Forms.ComboBox()
        Me.lbl_emp_ubi = New System.Windows.Forms.Label()
        Me.cbo_prc_emp_ubi = New System.Windows.Forms.ComboBox()
        Me.tdbg_ubs = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.tbp_ubi_arts = New System.Windows.Forms.TabPage()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbo_ubi = New System.Windows.Forms.ComboBox()
        Me.cbo_anql = New System.Windows.Forms.ComboBox()
        Me.cbo_stor = New System.Windows.Forms.ComboBox()
        Me.cbo_entr = New System.Windows.Forms.ComboBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.TabPage8 = New System.Windows.Forms.TabPage()
        Me.txt_cod_ubi = New System.Windows.Forms.TextBox()
        Me.txt_proc_ubs = New System.Windows.Forms.Button()
        Me.cmd_canc_ubs = New System.Windows.Forms.Button()
        Me.C1TrueDBGrid2 = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.tb_almacenes.SuspendLayout()
        Me.tbp_movimientos.SuspendLayout()
        CType(Me.QrCodeImgControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1TrueDBGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbp_catalogos.SuspendLayout()
        Me.tbc_catalogos.SuspendLayout()
        Me.tbp_articulos.SuspendLayout()
        CType(Me.tdbg_itm_mvs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.qr_codigo_item, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbp_ubicaciones.SuspendLayout()
        CType(Me.tdbg_ubs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbp_ubi_arts.SuspendLayout()
        CType(Me.C1TrueDBGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'tb_almacenes
        '
        Me.tb_almacenes.Controls.Add(Me.tbp_movimientos)
        Me.tb_almacenes.Controls.Add(Me.tbp_catalogos)
        Me.tb_almacenes.Controls.Add(Me.TabPage3)
        Me.tb_almacenes.Controls.Add(Me.TabPage4)
        Me.tb_almacenes.Controls.Add(Me.TabPage5)
        Me.tb_almacenes.Controls.Add(Me.TabPage6)
        Me.tb_almacenes.Controls.Add(Me.TabPage7)
        Me.tb_almacenes.Controls.Add(Me.TabPage8)
        Me.tb_almacenes.ImageList = Me.imlSm
        Me.tb_almacenes.Location = New System.Drawing.Point(12, 12)
        Me.tb_almacenes.Name = "tb_almacenes"
        Me.tb_almacenes.SelectedIndex = 0
        Me.tb_almacenes.Size = New System.Drawing.Size(843, 605)
        Me.tb_almacenes.TabIndex = 0
        '
        'tbp_movimientos
        '
        Me.tbp_movimientos.Controls.Add(Me.QrCodeImgControl1)
        Me.tbp_movimientos.Controls.Add(Me.ComboBox1)
        Me.tbp_movimientos.Controls.Add(Me.C1TrueDBGrid1)
        Me.tbp_movimientos.ImageIndex = 159
        Me.tbp_movimientos.Location = New System.Drawing.Point(4, 24)
        Me.tbp_movimientos.Name = "tbp_movimientos"
        Me.tbp_movimientos.Padding = New System.Windows.Forms.Padding(3)
        Me.tbp_movimientos.Size = New System.Drawing.Size(835, 577)
        Me.tbp_movimientos.TabIndex = 0
        Me.tbp_movimientos.Text = "Movimientos"
        Me.tbp_movimientos.UseVisualStyleBackColor = True
        '
        'QrCodeImgControl1
        '
        Me.QrCodeImgControl1.BackColor = System.Drawing.Color.White
        Me.QrCodeImgControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.QrCodeImgControl1.ErrorCorrectLevel = Gma.QrCodeNet.Encoding.ErrorCorrectionLevel.M
        Me.QrCodeImgControl1.Image = CType(resources.GetObject("QrCodeImgControl1.Image"), System.Drawing.Image)
        Me.QrCodeImgControl1.Location = New System.Drawing.Point(725, 6)
        Me.QrCodeImgControl1.Name = "QrCodeImgControl1"
        Me.QrCodeImgControl1.QuietZoneModule = Gma.QrCodeNet.Encoding.Windows.Render.QuietZoneModules.Two
        Me.QrCodeImgControl1.Size = New System.Drawing.Size(103, 80)
        Me.QrCodeImgControl1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.QrCodeImgControl1.TabIndex = 15
        Me.QrCodeImgControl1.TabStop = False
        Me.QrCodeImgControl1.Text = "GA000310040002"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(603, 158)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(127, 23)
        Me.ComboBox1.TabIndex = 14
        '
        'C1TrueDBGrid1
        '
        Me.C1TrueDBGrid1.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
        Me.C1TrueDBGrid1.AllowSort = False
        Me.C1TrueDBGrid1.AllowUpdate = False
        Me.C1TrueDBGrid1.AlternatingRows = True
        Me.C1TrueDBGrid1.CaptionHeight = 23
        Me.C1TrueDBGrid1.DirectionAfterEnter = C1.Win.C1TrueDBGrid.DirectionAfterEnterEnum.MoveNone
        Me.C1TrueDBGrid1.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1TrueDBGrid1.Images.Add(CType(resources.GetObject("C1TrueDBGrid1.Images"), System.Drawing.Image))
        Me.C1TrueDBGrid1.Location = New System.Drawing.Point(4, 266)
        Me.C1TrueDBGrid1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.C1TrueDBGrid1.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.HighlightRow
        Me.C1TrueDBGrid1.Name = "C1TrueDBGrid1"
        Me.C1TrueDBGrid1.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1TrueDBGrid1.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1TrueDBGrid1.PreviewInfo.ZoomFactor = 75.0R
        Me.C1TrueDBGrid1.PrintInfo.PageSettings = CType(resources.GetObject("C1TrueDBGrid1.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1TrueDBGrid1.RowHeight = 21
        Me.C1TrueDBGrid1.Size = New System.Drawing.Size(824, 306)
        Me.C1TrueDBGrid1.TabIndex = 13
        Me.C1TrueDBGrid1.Text = "C1TrueDBGrid1"
        Me.C1TrueDBGrid1.PropBag = resources.GetString("C1TrueDBGrid1.PropBag")
        '
        'tbp_catalogos
        '
        Me.tbp_catalogos.Controls.Add(Me.tbc_catalogos)
        Me.tbp_catalogos.ImageIndex = 153
        Me.tbp_catalogos.Location = New System.Drawing.Point(4, 24)
        Me.tbp_catalogos.Name = "tbp_catalogos"
        Me.tbp_catalogos.Padding = New System.Windows.Forms.Padding(3)
        Me.tbp_catalogos.Size = New System.Drawing.Size(835, 577)
        Me.tbp_catalogos.TabIndex = 1
        Me.tbp_catalogos.Text = "Catálogos"
        Me.tbp_catalogos.UseVisualStyleBackColor = True
        '
        'tbc_catalogos
        '
        Me.tbc_catalogos.Controls.Add(Me.tbp_articulos)
        Me.tbc_catalogos.Controls.Add(Me.tbp_ubicaciones)
        Me.tbc_catalogos.Controls.Add(Me.tbp_ubi_arts)
        Me.tbc_catalogos.ImageList = Me.imlSm
        Me.tbc_catalogos.Location = New System.Drawing.Point(6, 6)
        Me.tbc_catalogos.Name = "tbc_catalogos"
        Me.tbc_catalogos.SelectedIndex = 0
        Me.tbc_catalogos.Size = New System.Drawing.Size(823, 565)
        Me.tbc_catalogos.TabIndex = 0
        '
        'tbp_articulos
        '
        Me.tbp_articulos.Controls.Add(Me.lbl_desc_art)
        Me.tbp_articulos.Controls.Add(Me.txt_descrip_art)
        Me.tbp_articulos.Controls.Add(Me.cmd_prcs_qry)
        Me.tbp_articulos.Controls.Add(Me.cmd_xport_qry)
        Me.tbp_articulos.Controls.Add(Me.cbo_tip_mov_qry)
        Me.tbp_articulos.Controls.Add(Me.dtp_fin)
        Me.tbp_articulos.Controls.Add(Me.dtp_ini)
        Me.tbp_articulos.Controls.Add(Me.cmd_canc_art)
        Me.tbp_articulos.Controls.Add(Me.cmd_prc_art)
        Me.tbp_articulos.Controls.Add(Me.tdbg_itm_mvs)
        Me.tbp_articulos.Controls.Add(Me.Label3)
        Me.tbp_articulos.Controls.Add(Me.cbo_typ_fuel)
        Me.tbp_articulos.Controls.Add(Me.Label2)
        Me.tbp_articulos.Controls.Add(Me.Label1)
        Me.tbp_articulos.Controls.Add(Me.cbo_typ_conj)
        Me.tbp_articulos.Controls.Add(Me.cbo_typ_veh)
        Me.tbp_articulos.Controls.Add(Me.lbl_num_parte)
        Me.tbp_articulos.Controls.Add(Me.txt_num_parte)
        Me.tbp_articulos.Controls.Add(Me.lbl_articulo)
        Me.tbp_articulos.Controls.Add(Me.txt_cod_interno)
        Me.tbp_articulos.Controls.Add(Me.qr_codigo_item)
        Me.tbp_articulos.ImageIndex = 171
        Me.tbp_articulos.Location = New System.Drawing.Point(4, 24)
        Me.tbp_articulos.Name = "tbp_articulos"
        Me.tbp_articulos.Padding = New System.Windows.Forms.Padding(3)
        Me.tbp_articulos.Size = New System.Drawing.Size(815, 537)
        Me.tbp_articulos.TabIndex = 0
        Me.tbp_articulos.Text = "Artículos"
        Me.tbp_articulos.UseVisualStyleBackColor = True
        '
        'lbl_desc_art
        '
        Me.lbl_desc_art.AutoSize = True
        Me.lbl_desc_art.Location = New System.Drawing.Point(6, 78)
        Me.lbl_desc_art.Name = "lbl_desc_art"
        Me.lbl_desc_art.Size = New System.Drawing.Size(75, 15)
        Me.lbl_desc_art.TabIndex = 29
        Me.lbl_desc_art.Text = "Descripcion:"
        '
        'txt_descrip_art
        '
        Me.txt_descrip_art.BackColor = System.Drawing.Color.Beige
        Me.txt_descrip_art.Enabled = False
        Me.txt_descrip_art.ForeColor = System.Drawing.Color.Black
        Me.txt_descrip_art.Location = New System.Drawing.Point(116, 75)
        Me.txt_descrip_art.MaxLength = 25
        Me.txt_descrip_art.Name = "txt_descrip_art"
        Me.txt_descrip_art.ReadOnly = True
        Me.txt_descrip_art.ShortcutsEnabled = False
        Me.txt_descrip_art.Size = New System.Drawing.Size(315, 21)
        Me.txt_descrip_art.TabIndex = 1
        Me.txt_descrip_art.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmd_prcs_qry
        '
        Me.cmd_prcs_qry.ImageIndex = 80
        Me.cmd_prcs_qry.ImageList = Me.imlSm
        Me.cmd_prcs_qry.Location = New System.Drawing.Point(437, 167)
        Me.cmd_prcs_qry.Name = "cmd_prcs_qry"
        Me.cmd_prcs_qry.Size = New System.Drawing.Size(38, 50)
        Me.cmd_prcs_qry.TabIndex = 27
        Me.cmd_prcs_qry.UseVisualStyleBackColor = True
        '
        'cmd_xport_qry
        '
        Me.cmd_xport_qry.ImageIndex = 84
        Me.cmd_xport_qry.ImageList = Me.imlSm
        Me.cmd_xport_qry.Location = New System.Drawing.Point(481, 167)
        Me.cmd_xport_qry.Name = "cmd_xport_qry"
        Me.cmd_xport_qry.Size = New System.Drawing.Size(38, 50)
        Me.cmd_xport_qry.TabIndex = 26
        Me.cmd_xport_qry.UseVisualStyleBackColor = True
        '
        'cbo_tip_mov_qry
        '
        Me.cbo_tip_mov_qry.BackColor = System.Drawing.Color.Beige
        Me.cbo_tip_mov_qry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_tip_mov_qry.Enabled = False
        Me.cbo_tip_mov_qry.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbo_tip_mov_qry.ForeColor = System.Drawing.Color.Black
        Me.cbo_tip_mov_qry.FormattingEnabled = True
        Me.cbo_tip_mov_qry.Location = New System.Drawing.Point(540, 167)
        Me.cbo_tip_mov_qry.Name = "cbo_tip_mov_qry"
        Me.cbo_tip_mov_qry.Size = New System.Drawing.Size(187, 23)
        Me.cbo_tip_mov_qry.TabIndex = 25
        '
        'dtp_fin
        '
        Me.dtp_fin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fin.Location = New System.Drawing.Point(633, 196)
        Me.dtp_fin.Name = "dtp_fin"
        Me.dtp_fin.Size = New System.Drawing.Size(95, 21)
        Me.dtp_fin.TabIndex = 24
        '
        'dtp_ini
        '
        Me.dtp_ini.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_ini.Location = New System.Drawing.Point(532, 196)
        Me.dtp_ini.Name = "dtp_ini"
        Me.dtp_ini.Size = New System.Drawing.Size(95, 21)
        Me.dtp_ini.TabIndex = 23
        '
        'cmd_canc_art
        '
        Me.cmd_canc_art.ImageIndex = 38
        Me.cmd_canc_art.ImageList = Me.imlSm
        Me.cmd_canc_art.Location = New System.Drawing.Point(206, 189)
        Me.cmd_canc_art.Name = "cmd_canc_art"
        Me.cmd_canc_art.Size = New System.Drawing.Size(92, 48)
        Me.cmd_canc_art.TabIndex = 22
        Me.cmd_canc_art.Text = "Cancelar"
        Me.cmd_canc_art.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmd_canc_art.UseVisualStyleBackColor = True
        '
        'cmd_prc_art
        '
        Me.cmd_prc_art.ImageIndex = 0
        Me.cmd_prc_art.ImageList = Me.imlSm
        Me.cmd_prc_art.Location = New System.Drawing.Point(108, 189)
        Me.cmd_prc_art.Name = "cmd_prc_art"
        Me.cmd_prc_art.Size = New System.Drawing.Size(92, 48)
        Me.cmd_prc_art.TabIndex = 5
        Me.cmd_prc_art.Text = "&Procesar"
        Me.cmd_prc_art.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmd_prc_art.UseVisualStyleBackColor = True
        '
        'tdbg_itm_mvs
        '
        Me.tdbg_itm_mvs.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
        Me.tdbg_itm_mvs.AllowSort = False
        Me.tdbg_itm_mvs.AllowUpdate = False
        Me.tdbg_itm_mvs.AlternatingRows = True
        Me.tdbg_itm_mvs.CaptionHeight = 23
        Me.tdbg_itm_mvs.DirectionAfterEnter = C1.Win.C1TrueDBGrid.DirectionAfterEnterEnum.MoveNone
        Me.tdbg_itm_mvs.GroupByCaption = "Drag a column header here to group by that column"
        Me.tdbg_itm_mvs.Images.Add(CType(resources.GetObject("tdbg_itm_mvs.Images"), System.Drawing.Image))
        Me.tdbg_itm_mvs.Location = New System.Drawing.Point(9, 242)
        Me.tdbg_itm_mvs.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tdbg_itm_mvs.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.HighlightRow
        Me.tdbg_itm_mvs.Name = "tdbg_itm_mvs"
        Me.tdbg_itm_mvs.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.tdbg_itm_mvs.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.tdbg_itm_mvs.PreviewInfo.ZoomFactor = 75.0R
        Me.tdbg_itm_mvs.PrintInfo.PageSettings = CType(resources.GetObject("tdbg_itm_mvs.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.tdbg_itm_mvs.RowHeight = 21
        Me.tdbg_itm_mvs.Size = New System.Drawing.Size(799, 287)
        Me.tdbg_itm_mvs.TabIndex = 12
        Me.tdbg_itm_mvs.Text = "C1TrueDBGrid1"
        Me.tdbg_itm_mvs.PropBag = resources.GetString("tdbg_itm_mvs.PropBag")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 15)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Combustible"
        '
        'cbo_typ_fuel
        '
        Me.cbo_typ_fuel.BackColor = System.Drawing.Color.Beige
        Me.cbo_typ_fuel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_typ_fuel.Enabled = False
        Me.cbo_typ_fuel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbo_typ_fuel.ForeColor = System.Drawing.Color.Black
        Me.cbo_typ_fuel.FormattingEnabled = True
        Me.cbo_typ_fuel.Location = New System.Drawing.Point(116, 99)
        Me.cbo_typ_fuel.Name = "cbo_typ_fuel"
        Me.cbo_typ_fuel.Size = New System.Drawing.Size(187, 23)
        Me.cbo_typ_fuel.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 160)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 15)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Conjunto"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 131)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 15)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Tipo de vehículo"
        '
        'cbo_typ_conj
        '
        Me.cbo_typ_conj.BackColor = System.Drawing.Color.Beige
        Me.cbo_typ_conj.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_typ_conj.Enabled = False
        Me.cbo_typ_conj.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbo_typ_conj.ForeColor = System.Drawing.Color.Black
        Me.cbo_typ_conj.FormattingEnabled = True
        Me.cbo_typ_conj.Location = New System.Drawing.Point(116, 157)
        Me.cbo_typ_conj.Name = "cbo_typ_conj"
        Me.cbo_typ_conj.Size = New System.Drawing.Size(187, 23)
        Me.cbo_typ_conj.TabIndex = 4
        '
        'cbo_typ_veh
        '
        Me.cbo_typ_veh.BackColor = System.Drawing.Color.Beige
        Me.cbo_typ_veh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_typ_veh.Enabled = False
        Me.cbo_typ_veh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbo_typ_veh.ForeColor = System.Drawing.Color.Black
        Me.cbo_typ_veh.FormattingEnabled = True
        Me.cbo_typ_veh.Location = New System.Drawing.Point(116, 128)
        Me.cbo_typ_veh.Name = "cbo_typ_veh"
        Me.cbo_typ_veh.Size = New System.Drawing.Size(187, 23)
        Me.cbo_typ_veh.TabIndex = 3
        '
        'lbl_num_parte
        '
        Me.lbl_num_parte.AutoSize = True
        Me.lbl_num_parte.Location = New System.Drawing.Point(6, 53)
        Me.lbl_num_parte.Name = "lbl_num_parte"
        Me.lbl_num_parte.Size = New System.Drawing.Size(103, 15)
        Me.lbl_num_parte.TabIndex = 4
        Me.lbl_num_parte.Text = "Número de parte:"
        '
        'txt_num_parte
        '
        Me.txt_num_parte.BackColor = System.Drawing.Color.Beige
        Me.txt_num_parte.ForeColor = System.Drawing.Color.Black
        Me.txt_num_parte.Location = New System.Drawing.Point(116, 50)
        Me.txt_num_parte.MaxLength = 25
        Me.txt_num_parte.Name = "txt_num_parte"
        Me.txt_num_parte.ReadOnly = True
        Me.txt_num_parte.ShortcutsEnabled = False
        Me.txt_num_parte.Size = New System.Drawing.Size(315, 21)
        Me.txt_num_parte.TabIndex = 0
        Me.txt_num_parte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_articulo
        '
        Me.lbl_articulo.AutoSize = True
        Me.lbl_articulo.Location = New System.Drawing.Point(6, 19)
        Me.lbl_articulo.Name = "lbl_articulo"
        Me.lbl_articulo.Size = New System.Drawing.Size(49, 15)
        Me.lbl_articulo.TabIndex = 2
        Me.lbl_articulo.Text = "Codigo:"
        '
        'txt_cod_interno
        '
        Me.txt_cod_interno.BackColor = System.Drawing.Color.Black
        Me.txt_cod_interno.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cod_interno.ForeColor = System.Drawing.Color.GreenYellow
        Me.txt_cod_interno.Location = New System.Drawing.Point(116, 6)
        Me.txt_cod_interno.Name = "txt_cod_interno"
        Me.txt_cod_interno.ReadOnly = True
        Me.txt_cod_interno.Size = New System.Drawing.Size(315, 35)
        Me.txt_cod_interno.TabIndex = 100
        Me.txt_cod_interno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'qr_codigo_item
        '
        Me.qr_codigo_item.BackColor = System.Drawing.Color.White
        Me.qr_codigo_item.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.qr_codigo_item.Enabled = False
        Me.qr_codigo_item.ErrorCorrectLevel = Gma.QrCodeNet.Encoding.ErrorCorrectionLevel.M
        Me.qr_codigo_item.Image = CType(resources.GetObject("qr_codigo_item.Image"), System.Drawing.Image)
        Me.qr_codigo_item.Location = New System.Drawing.Point(304, 102)
        Me.qr_codigo_item.Name = "qr_codigo_item"
        Me.qr_codigo_item.QuietZoneModule = Gma.QrCodeNet.Encoding.Windows.Render.QuietZoneModules.Two
        Me.qr_codigo_item.Size = New System.Drawing.Size(127, 135)
        Me.qr_codigo_item.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.qr_codigo_item.TabIndex = 0
        Me.qr_codigo_item.TabStop = False
        Me.qr_codigo_item.Text = "meine Nummer ist siebenundvierzig"
        '
        'tbp_ubicaciones
        '
        Me.tbp_ubicaciones.Controls.Add(Me.cmd_kill_ubq)
        Me.tbp_ubicaciones.Controls.Add(Me.cmd_qry_ents)
        Me.tbp_ubicaciones.Controls.Add(Me.cmd_cnl_ubs)
        Me.tbp_ubicaciones.Controls.Add(Me.cmd_prc_ubs)
        Me.tbp_ubicaciones.Controls.Add(Me.lbl_ubq_prc)
        Me.tbp_ubicaciones.Controls.Add(Me.lbl_anq_prc)
        Me.tbp_ubicaciones.Controls.Add(Me.lbl_almacen)
        Me.tbp_ubicaciones.Controls.Add(Me.cbo_prc_alm)
        Me.tbp_ubicaciones.Controls.Add(Me.cbo_prc_anaq)
        Me.tbp_ubicaciones.Controls.Add(Me.cbo_prc_ubi)
        Me.tbp_ubicaciones.Controls.Add(Me.lbl_ent)
        Me.tbp_ubicaciones.Controls.Add(Me.cbo_entidad)
        Me.tbp_ubicaciones.Controls.Add(Me.lbl_emp_ubi)
        Me.tbp_ubicaciones.Controls.Add(Me.cbo_prc_emp_ubi)
        Me.tbp_ubicaciones.Controls.Add(Me.tdbg_ubs)
        Me.tbp_ubicaciones.ImageIndex = 161
        Me.tbp_ubicaciones.Location = New System.Drawing.Point(4, 24)
        Me.tbp_ubicaciones.Name = "tbp_ubicaciones"
        Me.tbp_ubicaciones.Padding = New System.Windows.Forms.Padding(3)
        Me.tbp_ubicaciones.Size = New System.Drawing.Size(815, 537)
        Me.tbp_ubicaciones.TabIndex = 1
        Me.tbp_ubicaciones.Text = "Almacenamiento"
        Me.tbp_ubicaciones.UseVisualStyleBackColor = True
        '
        'cmd_kill_ubq
        '
        Me.cmd_kill_ubq.Enabled = False
        Me.cmd_kill_ubq.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmd_kill_ubq.ImageIndex = 179
        Me.cmd_kill_ubq.ImageList = Me.imgIconos
        Me.cmd_kill_ubq.Location = New System.Drawing.Point(301, 96)
        Me.cmd_kill_ubq.Name = "cmd_kill_ubq"
        Me.cmd_kill_ubq.Size = New System.Drawing.Size(91, 53)
        Me.cmd_kill_ubq.TabIndex = 28
        Me.cmd_kill_ubq.Text = "Borrar"
        Me.cmd_kill_ubq.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmd_kill_ubq.UseVisualStyleBackColor = True
        Me.cmd_kill_ubq.Visible = False
        '
        'cmd_qry_ents
        '
        Me.cmd_qry_ents.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.cmd_qry_ents.ImageIndex = 165
        Me.cmd_qry_ents.ImageList = Me.imlSm
        Me.cmd_qry_ents.Location = New System.Drawing.Point(398, 6)
        Me.cmd_qry_ents.Name = "cmd_qry_ents"
        Me.cmd_qry_ents.Size = New System.Drawing.Size(91, 39)
        Me.cmd_qry_ents.TabIndex = 27
        Me.cmd_qry_ents.Text = "&Consultar"
        Me.cmd_qry_ents.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.cmd_qry_ents.UseVisualStyleBackColor = True
        '
        'cmd_cnl_ubs
        '
        Me.cmd_cnl_ubs.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.cmd_cnl_ubs.ImageIndex = 38
        Me.cmd_cnl_ubs.ImageList = Me.imlSm
        Me.cmd_cnl_ubs.Location = New System.Drawing.Point(301, 48)
        Me.cmd_cnl_ubs.Name = "cmd_cnl_ubs"
        Me.cmd_cnl_ubs.Size = New System.Drawing.Size(91, 39)
        Me.cmd_cnl_ubs.TabIndex = 24
        Me.cmd_cnl_ubs.Text = "Cancelar"
        Me.cmd_cnl_ubs.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.cmd_cnl_ubs.UseVisualStyleBackColor = True
        '
        'cmd_prc_ubs
        '
        Me.cmd_prc_ubs.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.cmd_prc_ubs.ImageIndex = 80
        Me.cmd_prc_ubs.ImageList = Me.imlSm
        Me.cmd_prc_ubs.Location = New System.Drawing.Point(301, 6)
        Me.cmd_prc_ubs.Name = "cmd_prc_ubs"
        Me.cmd_prc_ubs.Size = New System.Drawing.Size(91, 39)
        Me.cmd_prc_ubs.TabIndex = 23
        Me.cmd_prc_ubs.Text = "&Procesar"
        Me.cmd_prc_ubs.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.cmd_prc_ubs.UseVisualStyleBackColor = True
        '
        'lbl_ubq_prc
        '
        Me.lbl_ubq_prc.AutoSize = True
        Me.lbl_ubq_prc.Location = New System.Drawing.Point(9, 125)
        Me.lbl_ubq_prc.Name = "lbl_ubq_prc"
        Me.lbl_ubq_prc.Size = New System.Drawing.Size(65, 15)
        Me.lbl_ubq_prc.TabIndex = 22
        Me.lbl_ubq_prc.Text = "Ubicacion:"
        '
        'lbl_anq_prc
        '
        Me.lbl_anq_prc.AutoSize = True
        Me.lbl_anq_prc.Location = New System.Drawing.Point(6, 96)
        Me.lbl_anq_prc.Name = "lbl_anq_prc"
        Me.lbl_anq_prc.Size = New System.Drawing.Size(55, 15)
        Me.lbl_anq_prc.TabIndex = 21
        Me.lbl_anq_prc.Text = "Anaquel:"
        '
        'lbl_almacen
        '
        Me.lbl_almacen.AutoSize = True
        Me.lbl_almacen.Location = New System.Drawing.Point(6, 67)
        Me.lbl_almacen.Name = "lbl_almacen"
        Me.lbl_almacen.Size = New System.Drawing.Size(58, 15)
        Me.lbl_almacen.TabIndex = 20
        Me.lbl_almacen.Text = "Almacen:"
        '
        'cbo_prc_alm
        '
        Me.cbo_prc_alm.BackColor = System.Drawing.Color.SteelBlue
        Me.cbo_prc_alm.Enabled = False
        Me.cbo_prc_alm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbo_prc_alm.ForeColor = System.Drawing.Color.White
        Me.cbo_prc_alm.FormattingEnabled = True
        Me.cbo_prc_alm.Location = New System.Drawing.Point(82, 64)
        Me.cbo_prc_alm.MaxLength = 25
        Me.cbo_prc_alm.Name = "cbo_prc_alm"
        Me.cbo_prc_alm.Size = New System.Drawing.Size(213, 23)
        Me.cbo_prc_alm.TabIndex = 19
        '
        'cbo_prc_anaq
        '
        Me.cbo_prc_anaq.BackColor = System.Drawing.Color.LightSlateGray
        Me.cbo_prc_anaq.Enabled = False
        Me.cbo_prc_anaq.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbo_prc_anaq.ForeColor = System.Drawing.Color.White
        Me.cbo_prc_anaq.FormattingEnabled = True
        Me.cbo_prc_anaq.Location = New System.Drawing.Point(82, 96)
        Me.cbo_prc_anaq.Name = "cbo_prc_anaq"
        Me.cbo_prc_anaq.Size = New System.Drawing.Size(213, 23)
        Me.cbo_prc_anaq.TabIndex = 18
        '
        'cbo_prc_ubi
        '
        Me.cbo_prc_ubi.BackColor = System.Drawing.Color.DarkSlateGray
        Me.cbo_prc_ubi.Enabled = False
        Me.cbo_prc_ubi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbo_prc_ubi.ForeColor = System.Drawing.Color.White
        Me.cbo_prc_ubi.FormattingEnabled = True
        Me.cbo_prc_ubi.Location = New System.Drawing.Point(82, 125)
        Me.cbo_prc_ubi.Name = "cbo_prc_ubi"
        Me.cbo_prc_ubi.Size = New System.Drawing.Size(213, 23)
        Me.cbo_prc_ubi.TabIndex = 17
        '
        'lbl_ent
        '
        Me.lbl_ent.AutoSize = True
        Me.lbl_ent.Location = New System.Drawing.Point(6, 9)
        Me.lbl_ent.Name = "lbl_ent"
        Me.lbl_ent.Size = New System.Drawing.Size(52, 15)
        Me.lbl_ent.TabIndex = 16
        Me.lbl_ent.Text = "Entidad:"
        '
        'cbo_entidad
        '
        Me.cbo_entidad.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.cbo_entidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_entidad.Enabled = False
        Me.cbo_entidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbo_entidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_entidad.ForeColor = System.Drawing.Color.Black
        Me.cbo_entidad.FormattingEnabled = True
        Me.cbo_entidad.Items.AddRange(New Object() {"Almacen", "Anaquel", "Ubicacion"})
        Me.cbo_entidad.Location = New System.Drawing.Point(82, 6)
        Me.cbo_entidad.Name = "cbo_entidad"
        Me.cbo_entidad.Size = New System.Drawing.Size(213, 24)
        Me.cbo_entidad.TabIndex = 15
        '
        'lbl_emp_ubi
        '
        Me.lbl_emp_ubi.AutoSize = True
        Me.lbl_emp_ubi.Location = New System.Drawing.Point(6, 38)
        Me.lbl_emp_ubi.Name = "lbl_emp_ubi"
        Me.lbl_emp_ubi.Size = New System.Drawing.Size(63, 15)
        Me.lbl_emp_ubi.TabIndex = 14
        Me.lbl_emp_ubi.Text = "Empresa :"
        '
        'cbo_prc_emp_ubi
        '
        Me.cbo_prc_emp_ubi.BackColor = System.Drawing.Color.Gold
        Me.cbo_prc_emp_ubi.Enabled = False
        Me.cbo_prc_emp_ubi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbo_prc_emp_ubi.ForeColor = System.Drawing.Color.Black
        Me.cbo_prc_emp_ubi.FormattingEnabled = True
        Me.cbo_prc_emp_ubi.Location = New System.Drawing.Point(82, 35)
        Me.cbo_prc_emp_ubi.Name = "cbo_prc_emp_ubi"
        Me.cbo_prc_emp_ubi.Size = New System.Drawing.Size(213, 23)
        Me.cbo_prc_emp_ubi.TabIndex = 0
        '
        'tdbg_ubs
        '
        Me.tdbg_ubs.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
        Me.tdbg_ubs.AllowSort = False
        Me.tdbg_ubs.AllowUpdate = False
        Me.tdbg_ubs.AlternatingRows = True
        Me.tdbg_ubs.CaptionHeight = 23
        Me.tdbg_ubs.DataView = C1.Win.C1TrueDBGrid.DataViewEnum.GroupBy
        Me.tdbg_ubs.DirectionAfterEnter = C1.Win.C1TrueDBGrid.DirectionAfterEnterEnum.MoveNone
        Me.tdbg_ubs.GroupByCaption = "Arrastre aquí las columnas para agrupar"
        Me.tdbg_ubs.Images.Add(CType(resources.GetObject("tdbg_ubs.Images"), System.Drawing.Image))
        Me.tdbg_ubs.Location = New System.Drawing.Point(12, 156)
        Me.tdbg_ubs.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tdbg_ubs.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.HighlightRow
        Me.tdbg_ubs.Name = "tdbg_ubs"
        Me.tdbg_ubs.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.tdbg_ubs.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.tdbg_ubs.PreviewInfo.ZoomFactor = 75.0R
        Me.tdbg_ubs.PrintInfo.PageSettings = CType(resources.GetObject("tdbg_ubs.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.tdbg_ubs.RowHeight = 21
        Me.tdbg_ubs.Size = New System.Drawing.Size(791, 373)
        Me.tdbg_ubs.TabIndex = 13
        Me.tdbg_ubs.Text = "C1TrueDBGrid1"
        Me.tdbg_ubs.PropBag = resources.GetString("tdbg_ubs.PropBag")
        '
        'tbp_ubi_arts
        '
        Me.tbp_ubi_arts.Controls.Add(Me.C1TrueDBGrid2)
        Me.tbp_ubi_arts.Controls.Add(Me.cmd_canc_ubs)
        Me.tbp_ubi_arts.Controls.Add(Me.txt_proc_ubs)
        Me.tbp_ubi_arts.Controls.Add(Me.txt_cod_ubi)
        Me.tbp_ubi_arts.Controls.Add(Me.Label7)
        Me.tbp_ubi_arts.Controls.Add(Me.Label6)
        Me.tbp_ubi_arts.Controls.Add(Me.Label5)
        Me.tbp_ubi_arts.Controls.Add(Me.Label4)
        Me.tbp_ubi_arts.Controls.Add(Me.cbo_ubi)
        Me.tbp_ubi_arts.Controls.Add(Me.cbo_anql)
        Me.tbp_ubi_arts.Controls.Add(Me.cbo_stor)
        Me.tbp_ubi_arts.Controls.Add(Me.cbo_entr)
        Me.tbp_ubi_arts.ImageIndex = 157
        Me.tbp_ubi_arts.Location = New System.Drawing.Point(4, 24)
        Me.tbp_ubi_arts.Name = "tbp_ubi_arts"
        Me.tbp_ubi_arts.Size = New System.Drawing.Size(815, 537)
        Me.tbp_ubi_arts.TabIndex = 2
        Me.tbp_ubi_arts.Text = "Ubicacion articulo"
        Me.tbp_ubi_arts.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(68, 157)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 15)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Ubicacion"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(68, 128)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 15)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Anaquel"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(68, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 15)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Almacen"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(68, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 15)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Empresa"
        '
        'cbo_ubi
        '
        Me.cbo_ubi.BackColor = System.Drawing.Color.Beige
        Me.cbo_ubi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_ubi.Enabled = False
        Me.cbo_ubi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbo_ubi.ForeColor = System.Drawing.Color.Black
        Me.cbo_ubi.FormattingEnabled = True
        Me.cbo_ubi.Location = New System.Drawing.Point(131, 154)
        Me.cbo_ubi.Name = "cbo_ubi"
        Me.cbo_ubi.Size = New System.Drawing.Size(187, 23)
        Me.cbo_ubi.TabIndex = 24
        '
        'cbo_anql
        '
        Me.cbo_anql.BackColor = System.Drawing.Color.Beige
        Me.cbo_anql.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_anql.Enabled = False
        Me.cbo_anql.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbo_anql.ForeColor = System.Drawing.Color.Black
        Me.cbo_anql.FormattingEnabled = True
        Me.cbo_anql.Location = New System.Drawing.Point(131, 125)
        Me.cbo_anql.Name = "cbo_anql"
        Me.cbo_anql.Size = New System.Drawing.Size(187, 23)
        Me.cbo_anql.TabIndex = 23
        '
        'cbo_stor
        '
        Me.cbo_stor.BackColor = System.Drawing.Color.Beige
        Me.cbo_stor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_stor.Enabled = False
        Me.cbo_stor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbo_stor.ForeColor = System.Drawing.Color.Black
        Me.cbo_stor.FormattingEnabled = True
        Me.cbo_stor.Location = New System.Drawing.Point(132, 93)
        Me.cbo_stor.Name = "cbo_stor"
        Me.cbo_stor.Size = New System.Drawing.Size(187, 23)
        Me.cbo_stor.TabIndex = 22
        '
        'cbo_entr
        '
        Me.cbo_entr.BackColor = System.Drawing.Color.Beige
        Me.cbo_entr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_entr.Enabled = False
        Me.cbo_entr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbo_entr.ForeColor = System.Drawing.Color.Black
        Me.cbo_entr.FormattingEnabled = True
        Me.cbo_entr.Location = New System.Drawing.Point(131, 64)
        Me.cbo_entr.Name = "cbo_entr"
        Me.cbo_entr.Size = New System.Drawing.Size(187, 23)
        Me.cbo_entr.TabIndex = 21
        '
        'TabPage3
        '
        Me.TabPage3.Location = New System.Drawing.Point(4, 24)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(835, 577)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "TabPage3"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Location = New System.Drawing.Point(4, 24)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(835, 577)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "TabPage4"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'TabPage5
        '
        Me.TabPage5.Location = New System.Drawing.Point(4, 24)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(835, 577)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "TabPage5"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'TabPage6
        '
        Me.TabPage6.Location = New System.Drawing.Point(4, 24)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(835, 577)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "TabPage6"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'TabPage7
        '
        Me.TabPage7.Location = New System.Drawing.Point(4, 24)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Size = New System.Drawing.Size(835, 577)
        Me.TabPage7.TabIndex = 6
        Me.TabPage7.Text = "TabPage7"
        Me.TabPage7.UseVisualStyleBackColor = True
        '
        'TabPage8
        '
        Me.TabPage8.Location = New System.Drawing.Point(4, 24)
        Me.TabPage8.Name = "TabPage8"
        Me.TabPage8.Size = New System.Drawing.Size(835, 577)
        Me.TabPage8.TabIndex = 7
        Me.TabPage8.Text = "TabPage8"
        Me.TabPage8.UseVisualStyleBackColor = True
        '
        'txt_cod_ubi
        '
        Me.txt_cod_ubi.BackColor = System.Drawing.Color.Black
        Me.txt_cod_ubi.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cod_ubi.ForeColor = System.Drawing.Color.GreenYellow
        Me.txt_cod_ubi.Location = New System.Drawing.Point(12, 13)
        Me.txt_cod_ubi.Name = "txt_cod_ubi"
        Me.txt_cod_ubi.ReadOnly = True
        Me.txt_cod_ubi.Size = New System.Drawing.Size(306, 35)
        Me.txt_cod_ubi.TabIndex = 101
        Me.txt_cod_ubi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_proc_ubs
        '
        Me.txt_proc_ubs.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.txt_proc_ubs.ImageIndex = 80
        Me.txt_proc_ubs.ImageList = Me.imlSm
        Me.txt_proc_ubs.Location = New System.Drawing.Point(132, 194)
        Me.txt_proc_ubs.Name = "txt_proc_ubs"
        Me.txt_proc_ubs.Size = New System.Drawing.Size(90, 60)
        Me.txt_proc_ubs.TabIndex = 102
        Me.txt_proc_ubs.Text = "&Procesar"
        Me.txt_proc_ubs.UseVisualStyleBackColor = True
        '
        'cmd_canc_ubs
        '
        Me.cmd_canc_ubs.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.cmd_canc_ubs.ImageIndex = 38
        Me.cmd_canc_ubs.ImageList = Me.imlSm
        Me.cmd_canc_ubs.Location = New System.Drawing.Point(228, 194)
        Me.cmd_canc_ubs.Name = "cmd_canc_ubs"
        Me.cmd_canc_ubs.Size = New System.Drawing.Size(90, 60)
        Me.cmd_canc_ubs.TabIndex = 103
        Me.cmd_canc_ubs.Text = "Cancelar"
        Me.cmd_canc_ubs.UseVisualStyleBackColor = True
        '
        'C1TrueDBGrid2
        '
        Me.C1TrueDBGrid2.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
        Me.C1TrueDBGrid2.AllowSort = False
        Me.C1TrueDBGrid2.AllowUpdate = False
        Me.C1TrueDBGrid2.AlternatingRows = True
        Me.C1TrueDBGrid2.CaptionHeight = 23
        Me.C1TrueDBGrid2.DataView = C1.Win.C1TrueDBGrid.DataViewEnum.GroupBy
        Me.C1TrueDBGrid2.DirectionAfterEnter = C1.Win.C1TrueDBGrid.DirectionAfterEnterEnum.MoveNone
        Me.C1TrueDBGrid2.GroupByCaption = "Arrastre aquí las columnas para agrupar"
        Me.C1TrueDBGrid2.Images.Add(CType(resources.GetObject("C1TrueDBGrid2.Images"), System.Drawing.Image))
        Me.C1TrueDBGrid2.Location = New System.Drawing.Point(325, 13)
        Me.C1TrueDBGrid2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.C1TrueDBGrid2.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.HighlightRow
        Me.C1TrueDBGrid2.Name = "C1TrueDBGrid2"
        Me.C1TrueDBGrid2.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1TrueDBGrid2.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1TrueDBGrid2.PreviewInfo.ZoomFactor = 75.0R
        Me.C1TrueDBGrid2.PrintInfo.PageSettings = CType(resources.GetObject("C1TrueDBGrid2.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1TrueDBGrid2.RowHeight = 21
        Me.C1TrueDBGrid2.Size = New System.Drawing.Size(477, 519)
        Me.C1TrueDBGrid2.TabIndex = 104
        Me.C1TrueDBGrid2.Text = "C1TrueDBGrid1"
        Me.C1TrueDBGrid2.PropBag = resources.GetString("C1TrueDBGrid2.PropBag")
        '
        'frmAlmacen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(861, 629)
        Me.Controls.Add(Me.tb_almacenes)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAlmacen"
        Me.Text = "Control de almacenes"
        Me.tb_almacenes.ResumeLayout(False)
        Me.tbp_movimientos.ResumeLayout(False)
        CType(Me.QrCodeImgControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1TrueDBGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbp_catalogos.ResumeLayout(False)
        Me.tbc_catalogos.ResumeLayout(False)
        Me.tbp_articulos.ResumeLayout(False)
        Me.tbp_articulos.PerformLayout()
        CType(Me.tdbg_itm_mvs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.qr_codigo_item, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbp_ubicaciones.ResumeLayout(False)
        Me.tbp_ubicaciones.PerformLayout()
        CType(Me.tdbg_ubs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbp_ubi_arts.ResumeLayout(False)
        Me.tbp_ubi_arts.PerformLayout()
        CType(Me.C1TrueDBGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents imgIconos As System.Windows.Forms.ImageList
    Friend WithEvents imlSm As System.Windows.Forms.ImageList
    Friend WithEvents tb_almacenes As System.Windows.Forms.TabControl
    Friend WithEvents tbp_movimientos As System.Windows.Forms.TabPage
    Friend WithEvents tbp_catalogos As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage7 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage8 As System.Windows.Forms.TabPage
    Friend WithEvents tbc_catalogos As System.Windows.Forms.TabControl
    Friend WithEvents tbp_articulos As System.Windows.Forms.TabPage
    Friend WithEvents tbp_ubicaciones As System.Windows.Forms.TabPage
    Friend WithEvents qr_codigo_item As Gma.QrCodeNet.Encoding.Windows.Forms.QrCodeImgControl
    Friend WithEvents txt_cod_interno As System.Windows.Forms.TextBox
    Friend WithEvents lbl_articulo As System.Windows.Forms.Label
    Friend WithEvents txt_num_parte As System.Windows.Forms.TextBox
    Friend WithEvents lbl_num_parte As System.Windows.Forms.Label
    Friend WithEvents cbo_typ_conj As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_typ_veh As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbo_typ_fuel As System.Windows.Forms.ComboBox
    Friend WithEvents tdbg_itm_mvs As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents cmd_canc_art As System.Windows.Forms.Button
    Friend WithEvents cmd_prc_art As System.Windows.Forms.Button
    Friend WithEvents cmd_xport_qry As System.Windows.Forms.Button
    Friend WithEvents cbo_tip_mov_qry As System.Windows.Forms.ComboBox
    Friend WithEvents dtp_fin As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_ini As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmd_prcs_qry As System.Windows.Forms.Button
    Friend WithEvents QrCodeImgControl1 As Gma.QrCodeNet.Encoding.Windows.Forms.QrCodeImgControl
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents C1TrueDBGrid1 As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents tdbg_ubs As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents cbo_prc_emp_ubi As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_emp_ubi As System.Windows.Forms.Label
    Friend WithEvents lbl_ent As System.Windows.Forms.Label
    Friend WithEvents cbo_entidad As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_prc_alm As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_prc_anaq As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_prc_ubi As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_almacen As System.Windows.Forms.Label
    Friend WithEvents lbl_anq_prc As System.Windows.Forms.Label
    Friend WithEvents lbl_ubq_prc As System.Windows.Forms.Label
    Friend WithEvents cmd_cnl_ubs As System.Windows.Forms.Button
    Friend WithEvents cmd_prc_ubs As System.Windows.Forms.Button
    Friend WithEvents cmd_qry_ents As System.Windows.Forms.Button
    Friend WithEvents cmd_kill_ubq As System.Windows.Forms.Button
    Friend WithEvents txt_descrip_art As System.Windows.Forms.TextBox
    Friend WithEvents lbl_desc_art As System.Windows.Forms.Label
    Friend WithEvents tbp_ubi_arts As System.Windows.Forms.TabPage
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbo_ubi As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_anql As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_stor As System.Windows.Forms.ComboBox
    Friend WithEvents cbo_entr As System.Windows.Forms.ComboBox
    Friend WithEvents txt_cod_ubi As System.Windows.Forms.TextBox
    Friend WithEvents C1TrueDBGrid2 As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents cmd_canc_ubs As System.Windows.Forms.Button
    Friend WithEvents txt_proc_ubs As System.Windows.Forms.Button
End Class
