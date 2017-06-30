Public Class Login

    ' TODO: inserte el código para realizar autenticación personalizada usando el nombre de usuario y la contraseña proporcionada 
    ' (Consulte http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' El objeto principal personalizado se puede adjuntar al objeto principal del subproceso actual como se indica a continuación: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' donde CustomPrincipal es la implementación de IPrincipal utilizada para realizar la autenticación. 
    ' Posteriormente, My.User devolverá la información de identidad encapsulada en el objeto CustomPrincipal
    ' como el nombre de usuario, nombre para mostrar, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        'str_Main_Title = "SIGE" & Space(1) & _
        '                                     My.Application.Info.Version.Build.ToString() & Space(1) & _
        '                                     "USR:" & Entidad.Nombre_Completo & _
        '                                     "[" & RTrim(LTrim(Entidad.Agencia)) & "]" & Space(1) & _
        '                                     "DPOT:" & Entidad.Almacen & Space(1) & _
        '                                     "WS:" & Entidad.WorkStation & Space(1) & _
        '                                     "SRVR:" & Entidad.Servidor & Space(1)
        obj_Main = New MDIMaster
        With obj_Main
            .Text = "Control Logístico OPL"
            .Show()
        End With
        Me.Close()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

End Class
