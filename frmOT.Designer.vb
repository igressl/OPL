<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOT
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOT))
        Me.tbOT = New System.Windows.Forms.TabControl()
        Me.tbpOTMovimientos = New System.Windows.Forms.TabPage()
        Me.tbpConsultas = New System.Windows.Forms.TabPage()
        Me.imlOT = New System.Windows.Forms.ImageList(Me.components)
        Me.tdbgO = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.tbOT.SuspendLayout()
        Me.tbpOTMovimientos.SuspendLayout()
        CType(Me.tdbgO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbOT
        '
        Me.tbOT.Controls.Add(Me.tbpOTMovimientos)
        Me.tbOT.Controls.Add(Me.tbpConsultas)
        Me.tbOT.ImageList = Me.imlOT
        Me.tbOT.Location = New System.Drawing.Point(19, 10)
        Me.tbOT.Name = "tbOT"
        Me.tbOT.SelectedIndex = 0
        Me.tbOT.Size = New System.Drawing.Size(886, 564)
        Me.tbOT.TabIndex = 0
        '
        'tbpOTMovimientos
        '
        Me.tbpOTMovimientos.Controls.Add(Me.tdbgO)
        Me.tbpOTMovimientos.ImageIndex = 63
        Me.tbpOTMovimientos.Location = New System.Drawing.Point(4, 39)
        Me.tbpOTMovimientos.Name = "tbpOTMovimientos"
        Me.tbpOTMovimientos.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpOTMovimientos.Size = New System.Drawing.Size(878, 521)
        Me.tbpOTMovimientos.TabIndex = 0
        Me.tbpOTMovimientos.Text = "Operacion"
        Me.tbpOTMovimientos.UseVisualStyleBackColor = True
        '
        'tbpConsultas
        '
        Me.tbpConsultas.ImageIndex = 62
        Me.tbpConsultas.Location = New System.Drawing.Point(4, 39)
        Me.tbpConsultas.Name = "tbpConsultas"
        Me.tbpConsultas.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpConsultas.Size = New System.Drawing.Size(878, 521)
        Me.tbpConsultas.TabIndex = 1
        Me.tbpConsultas.Text = "Consultas"
        Me.tbpConsultas.UseVisualStyleBackColor = True
        '
        'imlOT
        '
        Me.imlOT.ImageStream = CType(resources.GetObject("imlOT.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imlOT.TransparentColor = System.Drawing.Color.Transparent
        Me.imlOT.Images.SetKeyName(0, "Icons8-Windows-8-Business-Organization.ico")
        Me.imlOT.Images.SetKeyName(1, "Icons8-Windows-8-Business-Org-Unit.ico")
        Me.imlOT.Images.SetKeyName(2, "Icons8-Windows-8-Business-Overtime.ico")
        Me.imlOT.Images.SetKeyName(3, "Icons8-Windows-8-Business-Package.ico")
        Me.imlOT.Images.SetKeyName(4, "Icons8-Windows-8-Business-Parallel-Tasks.ico")
        Me.imlOT.Images.SetKeyName(5, "Icons8-Windows-8-Business-Planner.ico")
        Me.imlOT.Images.SetKeyName(6, "Icons8-Windows-8-Business-Process.ico")
        Me.imlOT.Images.SetKeyName(7, "Icons8-Windows-8-Business-Self-Service-Kiosk.ico")
        Me.imlOT.Images.SetKeyName(8, "Icons8-Windows-8-Business-Serial-Tasks.ico")
        Me.imlOT.Images.SetKeyName(9, "Icons8-Windows-8-Cinema-Adventures.ico")
        Me.imlOT.Images.SetKeyName(10, "Icons8-Windows-8-City-Police-Badge.ico")
        Me.imlOT.Images.SetKeyName(11, "Icons8-Windows-8-Database.ico")
        Me.imlOT.Images.SetKeyName(12, "Icons8-Windows-8-Database-Accept.ico")
        Me.imlOT.Images.SetKeyName(13, "Icons8-Windows-8-Database-Add.ico")
        Me.imlOT.Images.SetKeyName(14, "Icons8-Windows-8-Database-Backup.ico")
        Me.imlOT.Images.SetKeyName(15, "Icons8-Windows-8-Database-Configuration.ico")
        Me.imlOT.Images.SetKeyName(16, "Icons8-Windows-8-Diy-Drill.ico")
        Me.imlOT.Images.SetKeyName(17, "Icons8-Windows-8-Diy-Hammer.ico")
        Me.imlOT.Images.SetKeyName(18, "Icons8-Windows-8-Ecommerce-Delivery.ico")
        Me.imlOT.Images.SetKeyName(19, "Icons8-Windows-8-Files-Hot-Article.ico")
        Me.imlOT.Images.SetKeyName(20, "Icons8-Windows-8-Healthcare-Ambulance.ico")
        Me.imlOT.Images.SetKeyName(21, "Icons8-Windows-8-Industry-Automatic.ico")
        Me.imlOT.Images.SetKeyName(22, "Icons8-Windows-8-Industry-Automotive.ico")
        Me.imlOT.Images.SetKeyName(23, "Icons8-Windows-8-Industry-Electro-Devices.ico")
        Me.imlOT.Images.SetKeyName(24, "Icons8-Windows-8-Industry-Engineering.ico")
        Me.imlOT.Images.SetKeyName(25, "Icons8-Windows-8-Industry-Manual.ico")
        Me.imlOT.Images.SetKeyName(26, "Icons8-Windows-8-Industry-Oil-Industry.ico")
        Me.imlOT.Images.SetKeyName(27, "Icons8-Windows-8-Industry-Poison.ico")
        Me.imlOT.Images.SetKeyName(28, "Icons8-Windows-8-Industry-Trash.ico")
        Me.imlOT.Images.SetKeyName(29, "Icons8-Windows-8-Maps-Center-Direction.ico")
        Me.imlOT.Images.SetKeyName(30, "Icons8-Windows-8-Maps-Gps-Searching.ico")
        Me.imlOT.Images.SetKeyName(31, "Icons8-Windows-8-Mobile-Blackberry.ico")
        Me.imlOT.Images.SetKeyName(32, "Icons8-Windows-8-Mobile-Cell-Phone.ico")
        Me.imlOT.Images.SetKeyName(33, "Icons8-Windows-8-Mobile-Empty-Battery.ico")
        Me.imlOT.Images.SetKeyName(34, "Icons8-Windows-8-Mobile-Full-Battery.ico")
        Me.imlOT.Images.SetKeyName(35, "Icons8-Windows-8-Mobile-Phone.ico")
        Me.imlOT.Images.SetKeyName(36, "Icons8-Windows-8-Mobile-Speaker.ico")
        Me.imlOT.Images.SetKeyName(37, "Icons8-Windows-8-Mobile-Touchscreen-Smartphone.ico")
        Me.imlOT.Images.SetKeyName(38, "Icons8-Windows-8-Network-Medium-Connection.ico")
        Me.imlOT.Images.SetKeyName(39, "Icons8-Windows-8-Numbers-0-Black.ico")
        Me.imlOT.Images.SetKeyName(40, "Icons8-Windows-8-Numbers-1-Black.ico")
        Me.imlOT.Images.SetKeyName(41, "Icons8-Windows-8-Numbers-2-Black.ico")
        Me.imlOT.Images.SetKeyName(42, "Icons8-Windows-8-Numbers-3-Black.ico")
        Me.imlOT.Images.SetKeyName(43, "Icons8-Windows-8-Numbers-4-Black.ico")
        Me.imlOT.Images.SetKeyName(44, "Icons8-Windows-8-Numbers-5-Black.ico")
        Me.imlOT.Images.SetKeyName(45, "Icons8-Windows-8-Numbers-6-Black.ico")
        Me.imlOT.Images.SetKeyName(46, "Icons8-Windows-8-Numbers-7-Black.ico")
        Me.imlOT.Images.SetKeyName(47, "Icons8-Windows-8-Numbers-8-Black.ico")
        Me.imlOT.Images.SetKeyName(48, "Icons8-Windows-8-Numbers-9-Black.ico")
        Me.imlOT.Images.SetKeyName(49, "Icons8-Windows-8-Photo-Video-Slr-Back-Side.ico")
        Me.imlOT.Images.SetKeyName(50, "Icons8-Windows-8-Programming-Dashboard.ico")
        Me.imlOT.Images.SetKeyName(51, "Icons8-Windows-8-Programming-Settings-3.ico")
        Me.imlOT.Images.SetKeyName(52, "Icons8-Windows-8-Science-Caliper.ico")
        Me.imlOT.Images.SetKeyName(53, "Icons8-Windows-8-Science-Humidity.ico")
        Me.imlOT.Images.SetKeyName(54, "Icons8-Windows-8-Science-Pressure.ico")
        Me.imlOT.Images.SetKeyName(55, "Icons8-Windows-8-Science-Temperature.ico")
        Me.imlOT.Images.SetKeyName(56, "Icons8-Windows-8-Science-Time.ico")
        Me.imlOT.Images.SetKeyName(57, "Icons8-Windows-8-Security-App-Shield.ico")
        Me.imlOT.Images.SetKeyName(58, "Icons8-Windows-8-Security-Fingerprint-Scan.ico")
        Me.imlOT.Images.SetKeyName(59, "Icons8-Windows-8-Security-Hand-Palm-Scan.ico")
        Me.imlOT.Images.SetKeyName(60, "Icons8-Windows-8-Security-Key-Security.ico")
        Me.imlOT.Images.SetKeyName(61, "Icons8-Windows-8-Security-Password-1.ico")
        Me.imlOT.Images.SetKeyName(62, "Icons8-Windows-8-Sports-Centre-Of-Gravity.ico")
        Me.imlOT.Images.SetKeyName(63, "Icons8-Windows-8-Transport-Engine.ico")
        Me.imlOT.Images.SetKeyName(64, "Icons8-Windows-8-Transport-Gas-Pump.ico")
        Me.imlOT.Images.SetKeyName(65, "Icons8-Windows-8-Transport-Interstate-Truck.ico")
        Me.imlOT.Images.SetKeyName(66, "Icons8-Windows-8-Transport-Speedometer.ico")
        Me.imlOT.Images.SetKeyName(67, "Icons8-Windows-8-Transport-Steering-Wheel.ico")
        Me.imlOT.Images.SetKeyName(68, "Icons8-Windows-8-Transport-Tire.ico")
        Me.imlOT.Images.SetKeyName(69, "Icons8-Windows-8-Transport-Truck.ico")
        Me.imlOT.Images.SetKeyName(70, "Icons8-Windows-8-Travel-Customs-Officer.ico")
        Me.imlOT.Images.SetKeyName(71, "Icons8-Windows-8-Travel-Right-Shoe.ico")
        Me.imlOT.Images.SetKeyName(72, "Icons8-Windows-8-User-Interface-Installing-Updates.ico")
        Me.imlOT.Images.SetKeyName(73, "Icons8-Windows-8-User-Interface-Zoom-In.ico")
        Me.imlOT.Images.SetKeyName(74, "Icons8-Windows-8-User-Interface-Zoom-Out.ico")
        Me.imlOT.Images.SetKeyName(75, "Icons8-Windows-8-Very-Basic-Clock.ico")
        Me.imlOT.Images.SetKeyName(76, "Icons8-Windows-8-Very-Basic-Lock.ico")
        Me.imlOT.Images.SetKeyName(77, "Icons8-Windows-8-Very-Basic-Services.ico")
        Me.imlOT.Images.SetKeyName(78, "Icons8-Windows-8-Very-Basic-Settings.ico")
        Me.imlOT.Images.SetKeyName(79, "Icons8-Windows-8-Very-Basic-Support.ico")
        Me.imlOT.Images.SetKeyName(80, "Icons8-Windows-8-Very-Basic-Unlock.ico")
        Me.imlOT.Images.SetKeyName(81, "Icons8-Windows-8-Weather-Thermometer.ico")
        Me.imlOT.Images.SetKeyName(82, "Iconshock-Aviation-Altimeter.ico")
        '
        'tdbgO
        '
        Me.tdbgO.GroupByCaption = "Drag a column header here to group by that column"
        Me.tdbgO.Images.Add(CType(resources.GetObject("tdbgO.Images"), System.Drawing.Image))
        Me.tdbgO.Location = New System.Drawing.Point(6, 128)
        Me.tdbgO.Name = "tdbgO"
        Me.tdbgO.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.tdbgO.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.tdbgO.PreviewInfo.ZoomFactor = 75.0R
        Me.tdbgO.PrintInfo.PageSettings = CType(resources.GetObject("C1TrueDBGrid1.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.tdbgO.Size = New System.Drawing.Size(869, 387)
        Me.tdbgO.TabIndex = 0
        Me.tdbgO.Text = "C1TrueDBGrid1"
        Me.tdbgO.PropBag = resources.GetString("tdbgO.PropBag")
        '
        'frmOT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(917, 584)
        Me.Controls.Add(Me.tbOT)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmOT"
        Me.Text = "Orden de trabajo"
        Me.tbOT.ResumeLayout(False)
        Me.tbpOTMovimientos.ResumeLayout(False)
        CType(Me.tdbgO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tbOT As System.Windows.Forms.TabControl
    Friend WithEvents tbpOTMovimientos As System.Windows.Forms.TabPage
    Friend WithEvents tbpConsultas As System.Windows.Forms.TabPage
    Friend WithEvents imlOT As System.Windows.Forms.ImageList
    Friend WithEvents tdbgO As C1.Win.C1TrueDBGrid.C1TrueDBGrid
End Class
