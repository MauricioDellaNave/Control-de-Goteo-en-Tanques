Option Explicit On
Imports System.IO
Imports ClienteFTPPDA
Imports System.Windows.Forms.Keys
Imports System.Drawing
Imports Microsoft.VisualBasic

Public Class FrmPrincipal

#Region "Declaraciones"

    Dim mNegocio As New Negocio
    Dim Destino As String

#End Region


    Private Sub button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button1.Click
        FrmMuestreo.Show()
        Me.Visible = False
        FrmMuestreo.btnGuardar.Enabled = False
    End Sub

    Private Sub button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button2.Click
        FrmConfigurar.Show()
        Me.Visible = False
    End Sub

    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click
        close
    End Sub


    Private Sub Transferir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTransferir.Click


        ''CONFIGURO LA TRANSFERENCIA POR RED
        mNegocio.CargarDestinoRED()
        mNegocio.TransferirRED()


    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        FrmSalir.Visible = True
    End Sub

    Private Sub FrmPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
