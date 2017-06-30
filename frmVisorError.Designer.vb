<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVisorError
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVisorError))
        Me.cmdUnloadError = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'cmdUnloadError
        '
        Me.cmdUnloadError.BackColor = System.Drawing.Color.Black
        Me.cmdUnloadError.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed
        Me.cmdUnloadError.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdUnloadError.ForeColor = System.Drawing.Color.Tomato
        Me.cmdUnloadError.Image = CType(resources.GetObject("cmdUnloadError.Image"), System.Drawing.Image)
        Me.cmdUnloadError.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdUnloadError.Location = New System.Drawing.Point(444, 376)
        Me.cmdUnloadError.Name = "cmdUnloadError"
        Me.cmdUnloadError.Size = New System.Drawing.Size(84, 45)
        Me.cmdUnloadError.TabIndex = 1
        Me.cmdUnloadError.Text = "Cerrar"
        Me.cmdUnloadError.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdUnloadError.UseVisualStyleBackColor = False
        '
        'frmVisorError
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(540, 433)
        Me.Controls.Add(Me.cmdUnloadError)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmVisorError"
        Me.Text = "frmVisorError"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdUnloadError As System.Windows.Forms.Button
End Class
