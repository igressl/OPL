<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_matchs
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_matchs))
        Me.tdbg_itm_nam = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.tdbg_itm_partnum = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.cmd_close = New System.Windows.Forms.Button()
        Me.lbl_concidencias = New System.Windows.Forms.Label()
        CType(Me.tdbg_itm_nam, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tdbg_itm_partnum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tdbg_itm_nam
        '
        Me.tdbg_itm_nam.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
        Me.tdbg_itm_nam.AllowSort = False
        Me.tdbg_itm_nam.AllowUpdate = False
        Me.tdbg_itm_nam.AlternatingRows = True
        Me.tdbg_itm_nam.CaptionHeight = 23
        Me.tdbg_itm_nam.DirectionAfterEnter = C1.Win.C1TrueDBGrid.DirectionAfterEnterEnum.MoveNone
        Me.tdbg_itm_nam.GroupByCaption = "Drag a column header here to group by that column"
        Me.tdbg_itm_nam.Images.Add(CType(resources.GetObject("tdbg_itm_nam.Images"), System.Drawing.Image))
        Me.tdbg_itm_nam.Location = New System.Drawing.Point(13, 230)
        Me.tdbg_itm_nam.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tdbg_itm_nam.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.HighlightRow
        Me.tdbg_itm_nam.Name = "tdbg_itm_nam"
        Me.tdbg_itm_nam.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.tdbg_itm_nam.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.tdbg_itm_nam.PreviewInfo.ZoomFactor = 75.0R
        Me.tdbg_itm_nam.PrintInfo.PageSettings = CType(resources.GetObject("tdbg_itm_nam.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.tdbg_itm_nam.RowHeight = 21
        Me.tdbg_itm_nam.Size = New System.Drawing.Size(305, 386)
        Me.tdbg_itm_nam.TabIndex = 13
        Me.tdbg_itm_nam.Text = "C1TrueDBGrid1"
        Me.tdbg_itm_nam.PropBag = resources.GetString("tdbg_itm_nam.PropBag")
        '
        'tdbg_itm_partnum
        '
        Me.tdbg_itm_partnum.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
        Me.tdbg_itm_partnum.AllowSort = False
        Me.tdbg_itm_partnum.AllowUpdate = False
        Me.tdbg_itm_partnum.AlternatingRows = True
        Me.tdbg_itm_partnum.CaptionHeight = 23
        Me.tdbg_itm_partnum.DirectionAfterEnter = C1.Win.C1TrueDBGrid.DirectionAfterEnterEnum.MoveNone
        Me.tdbg_itm_partnum.GroupByCaption = "Drag a column header here to group by that column"
        Me.tdbg_itm_partnum.Images.Add(CType(resources.GetObject("tdbg_itm_partnum.Images"), System.Drawing.Image))
        Me.tdbg_itm_partnum.Location = New System.Drawing.Point(326, 230)
        Me.tdbg_itm_partnum.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tdbg_itm_partnum.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.HighlightRow
        Me.tdbg_itm_partnum.Name = "tdbg_itm_partnum"
        Me.tdbg_itm_partnum.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.tdbg_itm_partnum.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.tdbg_itm_partnum.PreviewInfo.ZoomFactor = 75.0R
        Me.tdbg_itm_partnum.PrintInfo.PageSettings = CType(resources.GetObject("tdbg_itm_partnum.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.tdbg_itm_partnum.RowHeight = 21
        Me.tdbg_itm_partnum.Size = New System.Drawing.Size(322, 386)
        Me.tdbg_itm_partnum.TabIndex = 14
        Me.tdbg_itm_partnum.Text = "C1TrueDBGrid1"
        Me.tdbg_itm_partnum.PropBag = resources.GetString("tdbg_itm_partnum.PropBag")
        '
        'cmd_close
        '
        Me.cmd_close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen
        Me.cmd_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen
        Me.cmd_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_close.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_close.ForeColor = System.Drawing.Color.White
        Me.cmd_close.Location = New System.Drawing.Point(12, 166)
        Me.cmd_close.Name = "cmd_close"
        Me.cmd_close.Size = New System.Drawing.Size(636, 56)
        Me.cmd_close.TabIndex = 15
        Me.cmd_close.Text = "Cerrar"
        Me.cmd_close.UseVisualStyleBackColor = True
        '
        'lbl_concidencias
        '
        Me.lbl_concidencias.BackColor = System.Drawing.Color.Black
        Me.lbl_concidencias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_concidencias.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_concidencias.ForeColor = System.Drawing.Color.GreenYellow
        Me.lbl_concidencias.Location = New System.Drawing.Point(13, 18)
        Me.lbl_concidencias.Name = "lbl_concidencias"
        Me.lbl_concidencias.Size = New System.Drawing.Size(635, 145)
        Me.lbl_concidencias.TabIndex = 16
        Me.lbl_concidencias.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'frm_matchs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(661, 621)
        Me.Controls.Add(Me.lbl_concidencias)
        Me.Controls.Add(Me.cmd_close)
        Me.Controls.Add(Me.tdbg_itm_partnum)
        Me.Controls.Add(Me.tdbg_itm_nam)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_matchs"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_matchs"
        CType(Me.tdbg_itm_nam, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tdbg_itm_partnum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tdbg_itm_nam As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents tdbg_itm_partnum As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents cmd_close As System.Windows.Forms.Button
    Friend WithEvents lbl_concidencias As System.Windows.Forms.Label
End Class
