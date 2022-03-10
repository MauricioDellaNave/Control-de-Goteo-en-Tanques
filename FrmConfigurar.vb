Imports System.IO

Public Class FrmConfigurar

    Dim mNegocio As New Negocio


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        FrmPrincipal.Visible = True
        Me.Visible = False
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Me.InputPanel1.Enabled = True Then
            Me.InputPanel1.Enabled = False
        Else
            Me.InputPanel1.Enabled = True
        End If
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        ''/////////////////ARCHIVO////////////////////
        Try
            'Creamos la carpeta UPLOAD
            If Not Directory.Exists("\Upload") Then
                '' MsgBox("Se creo la carpeta \UPLOAD donde se almacenaran los muestreos", MsgBoxStyle.Information, "Informacion del Sistema")
                Directory.CreateDirectory("\Upload")

                'creamos el archivo txt y escribimos
                Const fic As String = "\Upload\Config.txt"
                'MsgBox("el txt no existe lo creo")
                Dim sw As New System.IO.StreamWriter(fic)
                sw.WriteLine(Me.txtHost.Text & "," & Me.txtCarpeta.Text)
                sw.Close()
            Else
                'escribimos en el archivo txt ya existente
                Const fic As String = "\Upload\Config.txt"
                'MsgBox("el txt ya existe escribo linea nueva")
                Dim sw As New System.IO.StreamWriter(fic, False)
                sw.WriteLine(Me.txtHost.Text & "," & Me.txtCarpeta.Text)
                sw.Close()
            End If

        Catch oe As Exception
            MsgBox(oe.Message, MsgBoxStyle.Critical)
        End Try

        MsgBox("Los datos de configuración fueron almacenados.", MsgBoxStyle.Information, "Informacion del Sistema")
    End Sub

    Private Sub FrmConfigurar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mNegocio.CargarDestinoRED()
        Me.txtHost.Text = mNegocio.Host
        Me.txtCarpeta.Text = mNegocio.Carpeta
    End Sub

    Private Sub Label1_ParentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.ParentChanged

    End Sub
End Class