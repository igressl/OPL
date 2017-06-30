Public Class frm_matchs
    Private Sub cmd_close_Click(sender As System.Object, e As System.EventArgs) Handles cmd_close.Click
        Try
            Me.Close()
        Catch ex As Exception
            Activar_Interface(Me, True)
            MostrarError(ex, Me.MdiParent)
        End Try
    End Sub
End Class