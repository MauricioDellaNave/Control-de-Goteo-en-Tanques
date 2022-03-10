Option Explicit On
Imports System.IO
Imports ClienteFTPPDA
Imports System.Windows.Forms.Keys

Public Class FrmMuestreo

    Dim mNegocio As New Negocio
    Dim Goteo As Integer
    Dim Camara As Integer


    Public Sub Limpiar()
        Me.txtControl.Text = ""
        Me.txtStock.Text = ""
        Me.txtRepo.Text = ""
        Me.txtCloro.Text = ""
        Me.txtComentario.Text = ""
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        FrmPrincipal.Visible = True
        Me.Visible = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        'Validacion de textbox

        If Me.txtControl.Text <> "" And Me.txtStock.Text <> "" And Me.txtRepo.Text <> "" And Me.txtCloro.Text <> "" Then

            mNegocio.PuntoControl = Me.txtControl.Text
            mNegocio.Stock = Me.txtStock.Text
            mNegocio.Reposicion = Me.txtRepo.Text
            mNegocio.CloroLibre = Me.txtCloro.Text
            mNegocio.Comentarios = Me.txtComentario.Text

            If Me.chkBien.Checked Then
                mNegocio.Goteo = 1
            Else
                mNegocio.Goteo = 0
            End If

            If Me.chkLimpia.Checked = True Then
                mNegocio.Camara = 1
            Else
                mNegocio.Camara = 0
            End If

            ''/////////////////ARCHIVO////////////////////
            'llamamos a crear archivo
            mNegocio.CrearArchivo()

            MsgBox("Los datos fueron cargados exitosamente.", MsgBoxStyle.Information, "Informacion del Sistema")
            Limpiar()

            FrmPrincipal.Visible = True
            Me.Visible = False

        Else

            MsgBox("Falta ingresar datos, verifiquelos e intente nuevamente.", MsgBoxStyle.Critical, "Informacion del Sistema")

        End If
    End Sub

    Private Sub chkBien_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkBien.CheckStateChanged
        If Me.chkBien.Checked = True Then
            Me.chkMal.Checked = False
        End If
    End Sub

    Private Sub chkMal_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMal.CheckStateChanged
        If Me.chkMal.Checked = True Then
            Me.chkBien.Checked = False
        End If
    End Sub

    Private Sub chkLimpia_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkLimpia.CheckStateChanged
        If Me.chkLimpia.Checked = True Then
            Me.chkSucia.Checked = False
        End If
    End Sub

    Private Sub chkSucia_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSucia.CheckStateChanged
        If Me.chkSucia.Checked = True Then
            Me.chkLimpia.Checked = False
        End If
    End Sub

    Private Sub txtControl_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtControl.TextChanged
        If Me.txtControl.Text <> "" Then
            Me.btnGuardar.Enabled = True
        End If
    End Sub

    Private Sub txtStock_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtStock.KeyPress
        If Not (Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar)) Then e.Handled = True
    End Sub

    Private Sub txtRepo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRepo.KeyPress
        If Not (Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar)) Then e.Handled = True
    End Sub

    Private Sub txtCloro_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCloro.KeyPress
        If Not (Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar)) Then e.Handled = True
    End Sub

    Private Sub FrmMuestreo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.chkBien.Checked = True
        Me.chkLimpia.Checked = True
    End Sub
End Class