Public Class FrmSalir

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Me.txtClave.Text = "cr52401" Then
            FrmPrincipal.Close()
        Else
            MsgBox("Clave incorrecta", MsgBoxStyle.Critical, "Información del Sistema")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.txtClave.Text = ""
        Me.Visible = False
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If Me.InputPanel1.Enabled = True Then
            Me.InputPanel1.Enabled = False
        Else
            Me.InputPanel1.Enabled = True
        End If
        txtClave.Focus()
    End Sub

    Private Sub FrmSalir_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtClave.Focus()
    End Sub
End Class