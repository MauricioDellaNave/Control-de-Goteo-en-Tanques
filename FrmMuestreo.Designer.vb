<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class FrmMuestreo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    Private mainMenu1 As System.Windows.Forms.MainMenu

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMuestreo))
        Me.mainMenu1 = New System.Windows.Forms.MainMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem7 = New System.Windows.Forms.MenuItem
        Me.txtControl = New System.Windows.Forms.TextBox
        Me.txtStock = New System.Windows.Forms.TextBox
        Me.txtRepo = New System.Windows.Forms.TextBox
        Me.txtComentario = New System.Windows.Forms.TextBox
        Me.txtCloro = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.pictureBox1 = New System.Windows.Forms.PictureBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.InputPanel1 = New Microsoft.WindowsCE.Forms.InputPanel
        Me.chkBien = New System.Windows.Forms.CheckBox
        Me.chkMal = New System.Windows.Forms.CheckBox
        Me.chkLimpia = New System.Windows.Forms.CheckBox
        Me.chkSucia = New System.Windows.Forms.CheckBox
        Me.SuspendLayout()
        '
        'mainMenu1
        '
        Me.mainMenu1.MenuItems.Add(Me.MenuItem1)
        Me.mainMenu1.MenuItems.Add(Me.MenuItem7)
        '
        'MenuItem1
        '
        Me.MenuItem1.Text = "Volver "
        '
        'MenuItem7
        '
        Me.MenuItem7.Text = " Guardar"
        '
        'txtControl
        '
        Me.txtControl.BackColor = System.Drawing.Color.PowderBlue
        Me.txtControl.Location = New System.Drawing.Point(109, 66)
        Me.txtControl.MaxLength = 16
        Me.txtControl.Name = "txtControl"
        Me.txtControl.Size = New System.Drawing.Size(115, 21)
        Me.txtControl.TabIndex = 0
        '
        'txtStock
        '
        Me.txtStock.Location = New System.Drawing.Point(109, 99)
        Me.txtStock.MaxLength = 3
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(115, 21)
        Me.txtStock.TabIndex = 1
        '
        'txtRepo
        '
        Me.txtRepo.Location = New System.Drawing.Point(109, 149)
        Me.txtRepo.MaxLength = 3
        Me.txtRepo.Name = "txtRepo"
        Me.txtRepo.Size = New System.Drawing.Size(115, 21)
        Me.txtRepo.TabIndex = 3
        '
        'txtComentario
        '
        Me.txtComentario.Location = New System.Drawing.Point(3, 239)
        Me.txtComentario.MaxLength = 50
        Me.txtComentario.Multiline = True
        Me.txtComentario.Name = "txtComentario"
        Me.txtComentario.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtComentario.Size = New System.Drawing.Size(229, 43)
        Me.txtComentario.TabIndex = 6
        '
        'txtCloro
        '
        Me.txtCloro.Location = New System.Drawing.Point(109, 173)
        Me.txtCloro.MaxLength = 3
        Me.txtCloro.Name = "txtCloro"
        Me.txtCloro.Size = New System.Drawing.Size(115, 21)
        Me.txtCloro.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(2, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 20)
        Me.Label1.Text = "Punto de Control"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(3, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 20)
        Me.Label2.Text = "Stock (lts)"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(3, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 20)
        Me.Label3.Text = "Goteo"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(3, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 20)
        Me.Label4.Text = "Reposición (lts)"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(3, 174)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 20)
        Me.Label5.Text = "Cloro libre (ppm)"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(3, 199)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(116, 20)
        Me.Label6.Text = "Cámara"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(3, 222)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(116, 20)
        Me.Label7.Text = "Comentarios:"
        '
        'pictureBox1
        '
        Me.pictureBox1.Image = CType(resources.GetObject("pictureBox1.Image"), System.Drawing.Image)
        Me.pictureBox1.Location = New System.Drawing.Point(10, 4)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(211, 59)
        Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(3, 288)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 29)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "Volver"
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(144, 288)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(88, 29)
        Me.btnGuardar.TabIndex = 24
        Me.btnGuardar.Text = "Guardar"
        '
        'chkBien
        '
        Me.chkBien.Location = New System.Drawing.Point(109, 123)
        Me.chkBien.Name = "chkBien"
        Me.chkBien.Size = New System.Drawing.Size(53, 20)
        Me.chkBien.TabIndex = 33
        Me.chkBien.Text = "Bien"
        '
        'chkMal
        '
        Me.chkMal.Location = New System.Drawing.Point(159, 123)
        Me.chkMal.Name = "chkMal"
        Me.chkMal.Size = New System.Drawing.Size(53, 20)
        Me.chkMal.TabIndex = 34
        Me.chkMal.Text = "Mal"
        '
        'chkLimpia
        '
        Me.chkLimpia.Location = New System.Drawing.Point(109, 200)
        Me.chkLimpia.Name = "chkLimpia"
        Me.chkLimpia.Size = New System.Drawing.Size(66, 20)
        Me.chkLimpia.TabIndex = 35
        Me.chkLimpia.Text = "Limpia"
        '
        'chkSucia
        '
        Me.chkSucia.Location = New System.Drawing.Point(170, 200)
        Me.chkSucia.Name = "chkSucia"
        Me.chkSucia.Size = New System.Drawing.Size(61, 20)
        Me.chkSucia.TabIndex = 36
        Me.chkSucia.Text = "Sucia"
        '
        'FrmMuestreo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(240, 320)
        Me.Controls.Add(Me.chkSucia)
        Me.Controls.Add(Me.chkLimpia)
        Me.Controls.Add(Me.chkMal)
        Me.Controls.Add(Me.chkBien)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.pictureBox1)
        Me.Controls.Add(Me.txtComentario)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCloro)
        Me.Controls.Add(Me.txtRepo)
        Me.Controls.Add(Me.txtStock)
        Me.Controls.Add(Me.txtControl)
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(0, 0)
        Me.MinimizeBox = False
        Me.Name = "FrmMuestreo"
        Me.Text = "FrmMuestreo"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtControl As System.Windows.Forms.TextBox
    Friend WithEvents txtStock As System.Windows.Forms.TextBox
    Friend WithEvents txtRepo As System.Windows.Forms.TextBox
    Friend WithEvents txtComentario As System.Windows.Forms.TextBox
    Friend WithEvents txtCloro As System.Windows.Forms.TextBox
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Private WithEvents pictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents InputPanel1 As Microsoft.WindowsCE.Forms.InputPanel
    Friend WithEvents chkBien As System.Windows.Forms.CheckBox
    Friend WithEvents chkMal As System.Windows.Forms.CheckBox
    Friend WithEvents chkLimpia As System.Windows.Forms.CheckBox
    Friend WithEvents chkSucia As System.Windows.Forms.CheckBox
End Class
