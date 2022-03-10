Imports System.IO
Imports System.Net.Sockets
Imports System.Net 


Public Class Negocio


#Region "Constructor"

    Sub New()

    End Sub

    Sub New(ByVal pHost As String, ByVal pCarpeta As String)
        Me.New()
        mHost = pHost
        mCarpeta = pCarpeta
    End Sub


#End Region

#Region "Declaraciones"
    Dim mIP As String
    Dim mPuntoControl As String
    Dim mStock As Integer
    Dim mGoteo As Integer
    Dim mReposicion As Integer
    Dim mCloroLibre As Integer
    Dim mCamara As Integer
    Dim mComentarios As String
    Dim mHoraFecha As String
    Dim mHost As String
    Dim mCarpeta As String
    Public mDestino As String

#End Region

#Region "Property"


    Public Property IP() As String
        Get
            Return mIP
        End Get
        Set(ByVal value As String)
            mIP = value
        End Set
    End Property


    Public Property PuntoControl() As String
        Get
            Return mPuntoControl
        End Get
        Set(ByVal value As String)
            mPuntoControl = value
        End Set
    End Property


    Public Property Stock() As Integer
        Get
            Return mStock
        End Get
        Set(ByVal value As Integer)
            mStock = value
        End Set
    End Property



    Public Property Goteo() As Integer
        Get
            Return mGoteo
        End Get
        Set(ByVal value As Integer)
            mGoteo = value
        End Set
    End Property


    Public Property Reposicion() As Integer
        Get
            Return mReposicion
        End Get
        Set(ByVal value As Integer)
            mReposicion = value
        End Set
    End Property


    Public Property CloroLibre() As Integer
        Get
            Return mCloroLibre
        End Get
        Set(ByVal value As Integer)
            mCloroLibre = value
        End Set
    End Property


    Public Property Camara() As Integer
        Get
            Return mCamara
        End Get
        Set(ByVal value As Integer)
            mCamara = value
        End Set
    End Property



    Public Property Comentarios() As String
        Get
            Return mComentarios
        End Get
        Set(ByVal value As String)
            mComentarios = value
        End Set
    End Property


    Public Property HoraFecha() As String
        Get
            Return mHoraFecha
        End Get
        Set(ByVal value As String)
            mHoraFecha = value
        End Set
    End Property


    Public Property Host() As String
        Get
            Return mHost
        End Get
        Set(ByVal value As String)
            mHost = value
        End Set
    End Property


    Public Property Carpeta() As String
        Get
            Return mCarpeta
        End Get
        Set(ByVal value As String)
            mCarpeta = value
        End Set
    End Property



#End Region

#Region "Metodos"

    Public Sub CrearArchivo()
        Try

            'Creamos la carpeta UPLOAD
            If Not Directory.Exists("\Upload") Then
                '' MsgBox("Se creo la carpeta \UPLOAD donde se almacenaran los muestreos", MsgBoxStyle.Information, "Informacion del Sistema")
                Directory.CreateDirectory("\Upload")

                'creamos el archivo txt y escribimos
                Const fic As String = "\Upload\Muestreo.txt"
                'MsgBox("el txt no existe lo creo")
                Dim sw As New System.IO.StreamWriter(fic)
                sw.WriteLine(mPuntoControl & "," & mStock & "," & mGoteo & "," & mReposicion & "," & mCloroLibre & "," & mCamara & "," & mComentarios & "," & Format(Now(), "dd/MM/yyyy") & "," & Format(Now(), "hh:mm:ss"))
                sw.Close()


            Else

                'escribimos en el archivo txt ya existente
                Const fic As String = "\Upload\Muestreo.txt"
                'MsgBox("el txt ya existe escribo linea nueva")
                Dim sw As New System.IO.StreamWriter(fic, True)
                sw.WriteLine(mPuntoControl & "," & mStock & "," & mGoteo & "," & mReposicion & "," & mCloroLibre & "," & mCamara & "," & mComentarios & "," & Format(Now(), "dd/MM/yyyy") & "," & Format(Now(), "hh:mm:ss"))
                sw.Close()

            End If


        Catch oe As Exception
            MsgBox(oe.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Public Sub TransferirRED()
        Try
            'Transfiero el archivo Muestreo.txt a la carpeta de Red seleccionada
            File.Copy("\Upload\Muestreo.txt", mDestino & "\Muestreo.txt", True)
            MsgBox("El archivo a sido enviado satisfactoriamente.", MsgBoxStyle.Information, "Informacion del Sistema")
        Catch ex As Exception
            MsgBox("No se puede conectar a la Red. Verifique su conexión Wifi.", MsgBoxStyle.Information, "Informacion del Sistema")
        End Try

    End Sub

    Public Function ProbarConexion() As String
        ' Dim pingresult As String = My.Computer.Network.Ping(mIP)

        ' If pingresult = "True" Then
        '   btnConnect.Text = "Conectado"
        '  Else
        '    btnConnect.Text = "Desconectado"
        '  End If

    End Function

    Public Sub CargarDestinoRED()

        Dim objReader As New StreamReader("\Upload\Config.txt")
        Dim sLine As String = ""
        Dim arrText As New ArrayList()

        Do
            sLine = objReader.ReadLine()
            If Not sLine Is Nothing Then
                arrText.Add(sLine)
                'levanto del archivo Config.txt el nombre del host y la carpet compartida
                mCarpeta = (sLine.Remove(0, (InStr(sLine, ","))))
                mHost = (sLine.Substring(0, (InStr(sLine, ",")) - 1))
            End If
        Loop Until sLine Is Nothing
        objReader.Close()

        mDestino = "\\" & mHost & "\" & mCarpeta
    End Sub

#End Region



End Class
