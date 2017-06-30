Imports System.Windows.Forms

Public Class MDIMaster
    Public obj_G_Gird As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents mnu_Context_Copy_Paste As System.Windows.Forms.ContextMenuStrip
    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs) Handles NewToolStripMenuItem.Click, NewToolStripButton.Click, NewWindowToolStripMenuItem.Click
        ' Cree una nueva instancia del formulario secundario.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Ventana " & m_ChildFormNumber

        ChildForm.Show()
    End Sub
    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs) Handles OpenToolStripMenuItem.Click, OpenToolStripButton.Click
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: agregue código aquí para abrir el archivo.
        End If
    End Sub
    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: agregue código aquí para guardar el contenido actual del formulario en un archivo.
        End If
    End Sub
    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CutToolStripMenuItem.Click
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CopyToolStripMenuItem.Click
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PasteToolStripMenuItem.Click
        'Utilice My.Computer.Clipboard.GetText() o My.Computer.Clipboard.GetData para recuperar la información del Portapapeles.
    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolBarToolStripMenuItem.Click
        Me.ToolStrip.Visible = Me.ToolBarToolStripMenuItem.Checked
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles StatusBarToolStripMenuItem.Click
        Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ArrangeIconsToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        ' Cierre todos los formularios secundarios del principal.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer
    Private Sub MDIMaster_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim objCon As SOLink.clConectividad
        Try
            objCon = New SOLink.clConectividad
            'objCon.Return_Records("SSSS")
        Catch ex As Exception

        End Try
    End Sub
    Private Sub CatalogMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CatalogMenu.Click
        'Try
        '    Me.Cursor = Cursors.WaitCursor
        '    objfrmCat = New frmCatalogos
        '    CargarFormularioMDI_Child(objfrmCat, Me, False)
        '    Me.Cursor = Cursors.Default
        'Catch ex As Exception
        '    MostrarError(ex, Me)
        'End Try
    End Sub
    Private Sub CatálogosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CatálogosToolStripMenuItem.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            objfrmCat = New frmCatalogos
            CargarFormularioMDI_Child(objfrmCat, Me, False)
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MostrarError(ex, Me)
        End Try
    End Sub
    ''' <summary>
    ''' Este procedimiento permite mostrar el menu contextual
    ''' declarado en el formulario principal, el menu contextual es utilizado
    ''' para poder copiar texto o rango de celdas a excel
    ''' </summary>
    ''' <param name="Grid_Host">
    ''' Nombre del grid de donde copiaremos la informacion
    ''' </param>
    ''' <param name="Coord_X">
    ''' Posicion coordenada X del mouse
    ''' </param>
    ''' <param name="Coord_Y">
    ''' Posicion coordenada Y del mouse
    ''' </param>
    ''' <remarks></remarks>
    Public Sub Menu_Copiar_Pegar(ByRef Grid_Host As C1.Win.C1TrueDBGrid.C1TrueDBGrid, _
                                 ByVal Coord_X As Integer, _
                                 ByVal Coord_Y As Integer)
        Try
            If Not (Grid_Host.DataSource Is Nothing) Then
                obj_G_Gird = Nothing
                obj_G_Gird = Grid_Host
                With mnu_Context_Copy_PasteX
                    .Visible = True
                    .Show(Grid_Host, New Point(Coord_X, Coord_Y), ToolStripDropDownDirection.BelowRight)
                End With
            Else
                Exit Sub
            End If
        Catch ex As Exception
            MostrarError(ex, Me)
        End Try
    End Sub
    Private Sub CopiarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopiarToolStripMenuItem.Click
        Try
            Copy_To_Clip_Board(obj_G_Gird)
        Catch ex As Exception
            MostrarError(ex, Me)
        End Try
    End Sub

    Private Sub AlmacenToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AlmacenToolStripMenuItem.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            objAlms = New frmAlmacen
            CargarFormularioMDI_Child(objAlms, Me, False)
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            MostrarError(ex, Me)
        End Try
    End Sub
End Class
