Imports ACFramework
Imports System.Security.Cryptography
Imports DAConexion
Imports Microsoft.Practices.Unity
Imports Microsoft.Practices.Unity.Configuration
Imports System.Threading
Imports System.Windows
Imports System.IO
Imports System.Text
Imports ACSeguridad

Public Class Principal

#Region " Variables "
   Private Shared m_usuario As String
   Private Shared m_basedatos As String
   Private Shared m_empresa As String
   Private Shared m_aplicacion As String
   Private Shared m_baseadmin As String
   Private Shared m_servidor As String
   Private Shared m_servidoradmin As String
   Private Shared m_userSql As String
   Private Shared m_passSql As String
   Private Shared m_tag As String
   Private Shared nameFilePrv As String
   Private Shared m_cmdArgs As ObjectModel.ReadOnlyCollection(Of String)
   Private m_tsplash As Integer = 3

   Private m_formatofecha As String

#End Region

#Region " Propiedades "

#End Region
#Region " Constructores "

    ''' <summary>
    ''' Base Desarrollo
    ''' 40975980%BDAcerosComer%ACERO%LOG%ACADMIN%192.168.30.5\SQL8%SA%varserv123%192.168.30.2\SQL8%
    ''' SYNRW8BVfll42tCZYPz8GqTofUZW3rUQzCpJ3pjpHa3iS1trBASX3sAzLhaObXlgaNV4seM8OngC41ir80hdPWeAkFg975uCKpo0UR2Gh2Zq1kIRyJTjS7xwIGROR1mLVxvJZpD8rRjn+24nretfCNtdBzin9ZvMv7tIceFBKZc=
    ''' 
    ''' Real
    ''' 40975980%BDACNet%VIRTU%LOG%ACAdmin%192.168.30.2\SQL8%Logistica%L0gistic4%192.168.30.2\SQL8%
    ''' GO+VgdNyiOGQIGqlTIYXFITmLEtVxiDH1qDHpQ3Fcpu3nGbDZCEBpqH1fOzNN95KkXbgZgY9s2ZMGJIKVoWH1s4mjiozkeCKejIKCgZovU/52J7e4J/AhNXyFySvwND/uW4vuFyeoPI2O6FMpZmwWQpwFPNmcCCuQ/jtlC+7mP0=
    ''' 
    ''' JL
    ''' 44274911%BDACNet%VIRTU%LOG%ACAdmin%192.168.30.2\SQL8%Logistica%L0gistic4%192.168.30.2\SQL8%
    ''' xFtG4TTWxGA1CC8ap4VkEVkb0aGoISmKrPjpSfUwBfyU3RpG8lbl3J2z/bdSyGjK2xPO02s+TaWwdezP5vCAW92ysBByA1NJ+yjOeq7MNs2pEUZiyH/EA/OMCZpYYkrAipurMSVYlkelnwvbRq4ZFTSBSUZ9+2pyyPO4OnTlURc=
    ''' 
    ''' AC-Mili
    ''' OAJEcYG2RbgEwUSr3APc5eFVVhqUMLWBQEeRNNUZzQGjhqEF7/+jq4WnV2oUs7E0GcfKnhoVnhGTdWUxAezYbQfQSNtFFIQ8Qmf4gcjrqKja+eMQDuG/Ci8LCgybcatsiuaBSTpmb77jLbYPgpKb8HHmLzQwon3le7J9qcneaq8=
    ''' 
    ''' Desarrollo
    ''' 40975980%BDACNet%VIRTU%LOG%ACAdmin%192.168.30.3\SQL8%Logistica%L0gistic4%192.168.30.3\SQL8%
    ''' m3JV8b0OWrifEPkgI7C+nPXQlUNb3nQT+tmKKyn/ED9H1O/+HvEeZsW1+K99HvR7p3zenBYKgHxqPwNeTsc9O2b/Z8sY8E5A4n+qJ1wTkOzldrfdsdMW1FlTyRV5bVEx7Eu3EIoltWtNv8D7yhUQrunDbT3h3nN1UUAJVKBUKUk=
    ''' JKnu5KQoEj+xYcmHf1ywBIp3LUsdIthtvumuz3YnRGUNHD/+aS1yGkvVtEbbQeCaN2QjSn/uePiZ4VkMsT65Nf3eMUK6hPqfhpuUWBTvsv1a9806TPgNSkBhST6Jt8Qt2sbNCQCwJk1473wH3hnqG6ksK6dWfGEtTyRHd+vxZaI=
    ''' 
    ''' DESARROLLO 30.3 Alex
    ''' bKpji/hn68F6Be1Or7ppeie3r4ykl4Y1E0ByeBOFU9h0sqw+FPyEmMHVRXK0Dwy7lEiJwHpMqcE5LKcQG6jfrtlGUcFBVsMGPsQCUThXc2ptdkYM1euAJd3Jqauutmp2M9O6WXT8X0IztlfTx/toUx4Agxj+BPmVo0pQee0lNYQ=
    ''' 
    ''' CUSCO 80.10 ALEX
    ''' t9LNiZuFq5YgIv1Om5HpGMAdxHZUQsvHA4VCNqZFUWPoM/VwymE23RVHNCjbnrWqSqZGPjUdNlKXerkA8zq+2tulHQfTrxsTzIRk4qcUeCcEdVKqTE70z7QfBpAxKs5t8hYpZbcj5OTrmyJpkYswX28O1G9Dt7jjZg6cSoTHnf4=
    ''' 
    ''' Local
    ''' 40975980%BDAcerosComerReal%VIRTU%LOG%ACAdmin%(Local)\SQL9%Logistica%L0gistic4%(Local)\SQL9%
    ''' VLgXx87NBqtNflyRC1ksMHBEkbNCSeuFkkmcRgZ6ZzqWs+0KvOOsi5itR6QNcTWJWjHjFcawMEkAbu6Keul8xQTkeqc3j+JWB1zzfX+Ao1hKYFtP/UGdcgOF6tTxXq09XZLo00mywF0Ai+1uL77RUcaC6UClsg6i7D9t30z2Vvo=
    ''' 
    ''' Privada
    ''' <RSAKeyValue><Modulus>zEqM6HLkF6wv2j+wSgfiFvdpKqAXTDTCqOxnW5R7mK4voDvH3sTOCjZ7eEkgh78ZQarTIXs0rOeGD+cSy8Msv2nape/UJp+ehmPmyEqEucxV/M6cOtT+F0+MbX3y4BKX/IntFhVkjKt8OXD2LHBhD4nPUIaePQoNJ5IUFwKLYn0=</Modulus><Exponent>AQAB</Exponent><P>/CWkisV1jWko18lbA89iO6EnZ1gn+o3YhqNra0R3vzQeImGDmIJcmN9k1S3D1nr8ktjhFnabVE6rrgfU1UyoAw==</P><Q>z2m0IcrQtLAKIf9R8YhYHn0MhzcY+/gi/o4gF1XR4utIxRxePmWr6AELIAaCd42IhjJ+HCKNbjmBe2jDjoQDfw==</Q><DP>DjFsPqd4w3n845Cg/+jnhaW/mxCaR38+he2i+UnEV83uOE824hnMbop8mYdW87a+iuGMYgBRJAC9pzEnqM4E0w==</DP><DQ>ksZhg1xLruG4efB842gxu3mQaQszcfNZiDu5N+oyOdt4RoxZoNw/91Dtt38DymhsyVJn7a8B2JN3LoanhG2lLw==</DQ><InverseQ>G82lJlLrAJMmtiJMnCpulBuhlXmYF7hG1CRQ3LoOc9/zCajA6iQkj08x5LrIjB9HNMW8+t+yh6TfZmOiwRHeEQ==</InverseQ><D>ZNqBCdh+Znlo/lPm0gVmRnRKBPMXzVVWrFJZDEsXYV7MwEwC9iUumrge6FkhqCJdc5/Dr4nFjX6XHo6zJsjp84qMHk6Q2dkRkwaWamP4XPukMpT5kvmTThTuHRYau9o2jZitUZtvmUf3tNZV+SkHkQDumtshzssoCP9Th5URFHk=</D></RSAKeyValue>
    ''' Publica
    ''' <RSAKeyValue><Modulus>zEqM6HLkF6wv2j+wSgfiFvdpKqAXTDTCqOxnW5R7mK4voDvH3sTOCjZ7eEkgh78ZQarTIXs0rOeGD+cSy8Msv2nape/UJp+ehmPmyEqEucxV/M6cOtT+F0+MbX3y4BKX/IntFhVkjKt8OXD2LHBhD4nPUIaePQoNJ5IUFwKLYn0=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        m_formatofecha = "yyyy-MM-dd HH:mm:ss.fff"
        Try
            ' Add any initialization after the InitializeComponent() call.

            m_cmdArgs = My.Application.CommandLineArgs
            Dim tAux As New Thread(New ThreadStart(AddressOf InicializarAplicacion))
            tAux.Start()
            While Not tAux.IsAlive
            End While

            spVersion.Text = String.Format("| Versión: {0}", My.Application.Info.Version.ToString())
            ' & Application.ProductVersion.ToString()
            Dim frmss As New SSInicio(m_tsplash, tAux)
            frmss.ShowDialog(Me)
            frmss.Dispose()

            'tstxtBaseDatos.Text = String.Format("| Base Datos: {0}", m_basedatos)
            'tstxtServidor.Text = String.Format("| Servidor: {0}", m_servidor)

        Catch ex As Exception
            ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso Iniciando Aplicación", ex)
            End
        End Try
    End Sub

    Private Sub Principal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            If GApp.EUsuario.NIVE_Codigo.Equals("001") Then
                tsbtnGenerarMenu.Visible = True
                tsbtnGenerarMenu.Enabled = True
            Else
                tsbtnGenerarMenu.Visible = False
                tsbtnGenerarMenu.Enabled = False
            End If
            '' Cargar el entorno de Trabajo
            Using _frmentorno As New ACEntornoTrabajo()
                If _frmentorno.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                    ' Cargar los permisos de la base de administración
                    Dim x_validar As New ACGenerarMenu(GApp.DataConexion, GApp.DataUsuario, mnuPrincipal, ACTypeQueryMenu.asignarMenu, m_formatofecha)
                    Dim _empresa As New ACBVentas.BEntidades
                    If _empresa.Cargar(x_validar.Empresa.EMPR_RUC.Trim) Then
                        x_validar.Empresa.EMPR_Desc = _empresa.Entidades.ENTID_RazonSocial
                    End If
                    GApp.SetEmpresa(x_validar.Empresa)

                    tspUsuario.Text = GApp.EUsuarioEntidad.ENTID_Nombres
                    ' Cargar Valores de Informacion del sistema y de la conexion
                    SetMsg()
                    If CType(Utilitarios.cConfig("pathfondo"), PXML).Valor <> "" Then
                        Dim PictureFile As String = CType(Utilitarios.cConfig("pathfondo"), PXML).Valor
                        Me.BackgroundImageLayout = Utilitarios.cConfiguracion.FondoLayout
                        If GApp.EmpresaCodigo.Equals("ACERO") Or GApp.EmpresaCodigo.Equals("VIRTU") Then
                            Me.BackgroundImage = Overlay(System.Drawing.Image.FromFile(PictureFile), ACPLogistica.My.Resources.Logo_Sistema_419x63, Color.White)
                        Else
                            Me.BackgroundImage = Overlay(System.Drawing.Image.FromFile(PictureFile))
                        End If
                    ElseIf GApp.EmpresaCodigo.Equals("ACERO") Or GApp.EmpresaCodigo.Equals("VIRTU") Then
                        Me.BackgroundImageLayout = ImageLayout.Stretch
                        Me.BackgroundImage = Overlay(ACPLogistica.My.Resources.Wallpaper_Logistica_1024x768, ACPLogistica.My.Resources.Logo_Sistema_419x63, Color.White)
                    Else
                        Me.BackgroundImageLayout = ImageLayout.Stretch
                        Me.BackgroundImage = Overlay(ACPLogistica.My.Resources.Wallpaper_Promasa_1204X903)
                    End If


                Else
                    Me.Close()
                End If
            End Using
        Catch ex As Exception
            ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "No se puede cargar los dialogos iniciales", ex)
            Me.Close()
        End Try
    End Sub

    Private Sub SetMsg()
        Try
            Dim _machine As String = System.Net.Dns.GetHostName()
            Dim _ip As String
            With System.Net.Dns.GetHostByName(_machine)
                Dim x_ip As System.Net.IPAddress
                x_ip = New System.Net.IPAddress(.AddressList(0).Address)
                _ip = x_ip.ToString
            End With
            Dim _cad As String = ""
            GApp.SetIP_HostName(_machine, _ip)
            If GApp.EUsuario.NIVE_Codigo = ACEVentas.Constantes.Nivel(ACEVentas.Constantes.TNiveles.Normal) Then
                _cad = "| Serv: {0}  | Suc. : {1}  | Pti Vta : {2} | Host: {3}"
                tslblUbicacion.Text = String.Format(_cad, GApp.ServidorNombre, GApp.ESucursal.SUCUR_Nombre, GApp.EAlmacen.ALMAC_Descripcion, _
                                                    _machine)
            Else
                _cad = "{5} | Serv: {0} | B.D.: {1} | Host : {4}/{5}"
                tslblUbicacion.Text = String.Format(_cad, GApp.Servidor, GApp.BaseDatos, GApp.ESucursal.SUCUR_Nombre, GApp.EAlmacen.ALMAC_Descripcion, _
                                                    _machine, _ip)
            End If
            tsslPeriodo.Text = GApp.Periodo
            Me.Text = String.Format("{3} / {2} - {0} / {1} (Periodo: {4}) ", GApp.EEmpresa.EMPR_Desc, My.Application.Info.Title, GApp.ESucursal.SUCUR_Nombre, GApp.EAlmacen.ALMAC_Descripcion, GApp.Periodo)
            spVersion.Text = String.Format("Version: {0}", My.Application.Info.Version.ToString())
            '' Verificar version
            Dim _bool As Boolean
            Dim _version As String = Parametros.GetParametro("pg_VersionLOG", _bool).ToString()
            If Not _version.Equals(My.Application.Info.Version.ToString()) Then
                spVersion.ForeColor = Color.White
                spVersion.BackColor = Color.Red
                ' spVersion.Font = New Font(spVersion.Font, FontStyle.Bold)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
#End Region

#Region " Metodos "
   Private Shared Sub InicializarAplicacion()
      'Dim nameFilePub As String = "cpb_" + DateTime.Now.ToString("yyyyMMddhh") & ".xml"
      nameFilePrv = Path.Combine(Application.StartupPath.ToString, String.Format("cpv_{0:yyyyMMddhh}.xml", DateTime.Now))
      Try
         If (m_cmdArgs(0).ToString().Length = 13) Then
            'Return
            Throw New Exception("Error")
         Else
            Dim x_cprivada As New StringBuilder()
            Dim res As String = ""
            If (m_cmdArgs.Count > 1) Then
               Dim _clave As String = "<RSAKeyValue xmlns="""">"
               _clave &= m_cmdArgs(1)
               _clave &= "</RSAKeyValue>"
               res = ACFramework.ACUtilitarios.ACDesEncriptarRSA(m_cmdArgs(0), _clave)
            Else
               Dim exe As Boolean = True
               Dim i As Integer = 0
               While exe
                  If Not (File.Exists(nameFilePrv)) Then
                     System.Threading.Thread.Sleep(1000)
                     Application.DoEvents()
                     i += 10
                     If i > 10 Then Exit While
                  Else
                     exe = False
                  End If
               End While
               If (File.Exists(nameFilePrv)) Then
                  Dim stream As New FileStream(nameFilePrv, FileMode.Open, FileAccess.Read)
                  Dim reader As New StreamReader(stream, Encoding.UTF8)
                  While reader.Peek() > -1
                     x_cprivada.Append(reader.ReadLine())
                  End While
                  reader.Close()
                  res = ACFramework.ACUtilitarios.ACDesEncriptarRSA(m_cmdArgs(0), x_cprivada.ToString())
               Else
                  Dim _clave As String = "<RSAKeyValue xmlns="""">"
                  _clave &= "<Modulus>zEqM6HLkF6wv2j+wSgfiFvdpKqAXTDTCqOxnW5R7mK4voDvH3sTOCjZ7eEkgh78ZQarTIXs0rOeGD+cSy8Msv2nape/UJp+ehmPmyEqEucxV/M6cOtT+F0+MbX3y4BKX/IntFhVkjKt8OXD2LHBhD4nPUIaePQoNJ5IUFwKLYn0=</Modulus><Exponent>AQAB</Exponent><P>/CWkisV1jWko18lbA89iO6EnZ1gn+o3YhqNra0R3vzQeImGDmIJcmN9k1S3D1nr8ktjhFnabVE6rrgfU1UyoAw==</P><Q>z2m0IcrQtLAKIf9R8YhYHn0MhzcY+/gi/o4gF1XR4utIxRxePmWr6AELIAaCd42IhjJ+HCKNbjmBe2jDjoQDfw==</Q><DP>DjFsPqd4w3n845Cg/+jnhaW/mxCaR38+he2i+UnEV83uOE824hnMbop8mYdW87a+iuGMYgBRJAC9pzEnqM4E0w==</DP><DQ>ksZhg1xLruG4efB842gxu3mQaQszcfNZiDu5N+oyOdt4RoxZoNw/91Dtt38DymhsyVJn7a8B2JN3LoanhG2lLw==</DQ><InverseQ>G82lJlLrAJMmtiJMnCpulBuhlXmYF7hG1CRQ3LoOc9/zCajA6iQkj08x5LrIjB9HNMW8+t+yh6TfZmOiwRHeEQ==</InverseQ><D>ZNqBCdh+Znlo/lPm0gVmRnRKBPMXzVVWrFJZDEsXYV7MwEwC9iUumrge6FkhqCJdc5/Dr4nFjX6XHo6zJsjp84qMHk6Q2dkRkwaWamP4XPukMpT5kvmTThTuHRYau9o2jZitUZtvmUf3tNZV+SkHkQDumtshzssoCP9Th5URFHk=</D>"
                  _clave &= "</RSAKeyValue>"
                  Try
                     res = ACFramework.ACUtilitarios.ACDesEncriptarRSA(m_cmdArgs(0), _clave)
                     exe = True
                  Catch ex As Exception
                     MsgBox(String.Format("Error: No existe configuracion de seguridad {0}{1}", vbNewLine, ex.Message))
                  End Try
                  If Not exe Then Throw New Exception(String.Format("Error: {0}", vbNewLine)) 'Return
               End If
            End If

            Dim _argumentos As String() = res.ToString().Split("%"c)
            If (_argumentos.Length > 0) Then m_usuario = _argumentos(0)
            If (_argumentos.Length > 1) Then m_basedatos = _argumentos(1)
            If (_argumentos.Length > 2) Then m_empresa = _argumentos(2)
            If (_argumentos.Length > 3) Then m_aplicacion = _argumentos(3)
            If (_argumentos.Length > 4) Then m_baseadmin = _argumentos(4)
            If (_argumentos.Length > 5) Then m_servidor = _argumentos(5)
            If (_argumentos.Length > 6) Then m_userSql = _argumentos(6)
            If (_argumentos.Length > 7) Then : m_passSql = _argumentos(7)
            Else : m_passSql = ""
            End If
            If (_argumentos.Length > 7) Then : m_tag = _argumentos(7)
            Else : m_tag = ""
            End If
            If (_argumentos.Length > 8) Then m_servidoradmin = _argumentos(8)

            If ACUtilitarios.ACCrearCadena("StrConn", m_servidor, m_basedatos, m_userSql, m_passSql) Then
               DAEnterprise.Instanciar("StrConn")
               GApp.Inicializar(m_empresa, m_aplicacion, m_usuario, m_servidor, m_basedatos, m_baseadmin, m_userSql, m_passSql, m_servidoradmin)
               Colecciones.Inicializar(True)
            Else
               MessageBox.Show("Error inicializando datos")
               Throw New Exception("Error General de Conexion")
            End If
         End If
      Catch ex As Exception
         MessageBox.Show(String.Format("Error inicializando datos{0}{1}", vbNewLine, ex.Message))
         Throw ex
      End Try
   End Sub

   Public Function Overlay(ByVal SourceImage As Image, ByVal OverlayImage As Bitmap, ByVal ColorTransparent As Color) As Bitmap
      Try
         Dim g As Graphics
         'Obtengo Graphic de la imagen de fondo para poder dibujar sobe ella
         g = Drawing.Graphics.FromImage(SourceImage)
         'Hago trasparente la imagen que vamos a superponer	
         OverlayImage.MakeTransparent(ColorTransparent)
         ' Calcular la Posicion de la Imagen
         Dim x_source As Integer = SourceImage.Width : Dim y_source As Integer = SourceImage.Height
         Dim x_over As Integer = OverlayImage.Width : Dim y_over As Integer = OverlayImage.Height
         Dim x_posbelow As Integer = x_source - (x_over + 5) : Dim y_posbelow As Integer = y_source - (y_over + 5)
         Dim x_posover As Integer = 5 : Dim y_posover As Integer = 5
            'Dibujo la imagen sobre el fondo
            'g.DrawImageUnscaledAndClipped(OverlayImage, New Rectangle(New Point(x_posbelow, y_posbelow), New Size(x_over, y_over)))
            'g.DrawImageUnscaledAndClipped(OverlayImage, New Rectangle(New Point(x_posover, y_posover), New Size(x_over, y_over)))
            'Elimino manejador grafico
            g.Dispose()
         'Devuelve la imagen mezclada
         Return SourceImage
      Catch ex As Exception
         Throw ex
      End Try
   End Function

   Public Function Overlay(ByVal SourceImage As Image) As Bitmap
      Try
         Dim g As Graphics
         'Obtengo Graphic de la imagen de fondo para poder dibujar sobe ella
         g = Drawing.Graphics.FromImage(SourceImage)
         Return SourceImage
      Catch ex As Exception
         Throw ex
      End Try
   End Function

   Private Sub GrabarLayout()
      If Me.BackgroundImageLayout.ToString() <> CType(Utilitarios.cConfig("layout"), PXML).Valor Then
         Utilitarios.cConfig("layout") = New PXML(Me.BackgroundImageLayout.ToString(), "layout")
         Utilitarios.saveXML()
      End If
   End Sub

   Private Function Change_BackgroundImage(ByVal _path As String) As Boolean
      Dim imagepath As String = _path
      Dim fs As System.IO.FileStream
      ' MDI Form image background layout change here
      '(Remember control imagebakground layout take default form background layount )
      Me.BackgroundImageLayout = ImageLayout.Stretch
      ' Checking File exists if yes go --->
      If System.IO.File.Exists(imagepath) Then
         ' Read Image file
         fs = System.IO.File.OpenRead(imagepath)
         fs.Position = 0
         ' Change MDI From back ground picture
         For Each ctl As Control In Me.Controls
            If TypeOf ctl Is MdiClient Then
               'ctl.BackColor = Color.AntiqueWhite;
               If System.Drawing.Image.FromStream(fs).Width > 500 And System.Drawing.Image.FromStream(fs).Height > 130 Then
                  If GApp.Empresa.Equals("ACERO") Or GApp.EmpresaCodigo.Equals("VIRTU") Then
                     ctl.BackgroundImage = Overlay(System.Drawing.Image.FromStream(fs), ACPLogistica.My.Resources.Logo_Sistema_419x63, Color.White)
                  Else
                     ctl.BackgroundImage = Overlay(System.Drawing.Image.FromStream(fs))
                  End If
               Else
                  ACControles.ACDialogos.ACMostrarMensajeInformacion(String.Format("Error: {0}", Me.Text), "La resolucion de la imagen no es adecuada")
                  Return False
               End If
               Exit For
            End If
         Next
         Return True
      End If
   End Function

#Region "Tool Bar"
   Private m_numeroform As Integer
   Private m_visible As Boolean

   Public Property PROP_NumeroForm() As Integer
      Get
         m_numeroform += 1
         Return m_numeroform
      End Get
      Set(ByVal value As Integer)
         m_numeroform = value
      End Set
   End Property

   Private Sub MDIParent1_MdiChildActivate(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.MdiChildActivate
      Try
         Dim lfrmFormulario As Form = DirectCast(sender, Form).ActiveMdiChild
         Dim lintNumForm As Integer = toolRecientes.Items.IndexOfKey(lfrmFormulario.Name)
         If lintNumForm < 0 Then
            Me.ppAgregarBoton(lfrmFormulario)
         End If
      Catch ex As Exception

      End Try
   End Sub

   Private Sub frmFormulario_Disposed(ByVal sender As Object, ByVal e As EventArgs)
      ppQuitarBoton(DirectCast(sender, Form))
   End Sub

   Private Sub ppAgregarBoton(ByVal xfrmHijo As Form)
      Dim lobjBoton As New ToolStripButton()
      '-------------------------------------------------------------//
      xfrmHijo.Name = xfrmHijo.Name + PROP_NumeroForm.ToString()
      AddHandler xfrmHijo.Disposed, AddressOf frmFormulario_Disposed
      '-------------------------------------------------------------//

      Dim lstrTexto As String = xfrmHijo.Text

      lobjBoton.Name = xfrmHijo.Name
      lobjBoton.Text = lstrTexto
      lobjBoton.ToolTipText = lstrTexto
      lobjBoton.Alignment = ToolStripItemAlignment.Left
      lobjBoton.TextAlign = ContentAlignment.MiddleLeft

      If m_visible Then
         lobjBoton.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
      Else
         lobjBoton.DisplayStyle = ToolStripItemDisplayStyle.Image
      End If

      AddHandler lobjBoton.Click, AddressOf lobjBoton_Click
      lobjBoton.Image = xfrmHijo.Icon.ToBitmap()

      toolRecientes.Items.Add(lobjBoton)
   End Sub

   Private Sub ppQuitarBoton(ByVal xfrmHijo As Form)
      Try
         Dim lintNumForm As Integer = toolRecientes.Items.IndexOfKey(xfrmHijo.Name)
         If lintNumForm >= 0 Then
            toolRecientes.Items.RemoveAt(lintNumForm)
         End If
      Catch ex As Exception
         MessageBox.Show(ex.ToString())
      End Try
   End Sub

   Private Sub lobjBoton_Click(ByVal sender As Object, ByVal e As EventArgs)
      For Each lfrmHijo As Form In Me.MdiChildren
         If lfrmHijo.Name = DirectCast(sender, ToolStripButton).Name Then
            'Me.MdiChildActivate -= New System.EventHandler(Me.frmPrincipal_MdiChildActivate)
            RemoveHandler Me.MdiChildActivate, AddressOf MDIParent1_MdiChildActivate
            lfrmHijo.Activate()
            'Me.MdiChildActivate += New System.EventHandler(Me.frmPrincipal_MdiChildActivate)
            AddHandler Me.MdiChildActivate, AddressOf MDIParent1_MdiChildActivate
            Exit For
         End If
      Next
   End Sub

   Private Sub tsbtnShowHide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnShowHide.Click
      Try
         m_visible = Not m_visible
         If m_visible Then
            For Each control As ToolStripItem In toolRecientes.Items
               If control.[GetType]() <> System.Type.[GetType]("System.Windows.Forms.ToolStripSeparator") Then
                  DirectCast(control, ToolStripItem).DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
               End If
            Next

            tsbtnShowHide.Image = Global.ACPLogistica.My.Resources.hidemenu
            tsbtnShowHide.ToolTipText = "Ocultar Menu"
            tsbtnShowHide.Text = "Ocultar Menu"
         Else
            For Each control As ToolStripItem In toolRecientes.Items
               If control.[GetType]() <> System.Type.[GetType]("System.Windows.Forms.ToolStripSeparator") Then
                  DirectCast(control, ToolStripItem).DisplayStyle = ToolStripItemDisplayStyle.Image
               End If
            Next

            tsbtnShowHide.Image = Global.ACPLogistica.My.Resources.showmenu
            tsbtnShowHide.ToolTipText = "Mostrar Menu"
         End If
      Catch ex As Exception

      End Try
   End Sub
#End Region

#End Region

#Region " Metodos de Controles"

   Private Sub tsbtnGenerarMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnGenerarMenu.Click
      Try
         If GApp.EUsuario.NIVE_Codigo.Equals("001") And ACControles.ACDialogos.ACMostrarMensajePregunta(String.Format("Generar Menu: {0}", Me.Text) _
                      , "Desea Generar el Menu de la Aplicación? " _
                      , "Al aceptar se volvera a recrear todo el menu en el administrador de aplicaciones" _
                      , ACControles.ACDialogos.LabelBotom.Si_No) = DialogResult.Yes Then
            Dim x_generar As New ACGenerarMenu(GApp.DataConexion, GApp.DataUsuario, mnuPrincipal, ACTypeQueryMenu.generarMenu, m_formatofecha)
            ACControles.ACDialogos.ACMostrarMensajeSatisfactorio(String.Format("Información: {0}", Me.Text), "Generado Satisfactoriamente")
         End If
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso Generar Menu", ex)
      End Try
   End Sub

#Region " Imagen de Fondo"

   Private Sub OptimizadoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptimizadoToolStripMenuItem.Click
      Me.BackgroundImageLayout = ImageLayout.Tile
      GrabarLayout()
   End Sub

   Private Sub ImagenPorDefectoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImagenPorDefectoToolStripMenuItem.Click
      Try
         Utilitarios.cConfig("pathfondo") = New PXML("", "pathfondo")
         If GApp.EmpresaCodigo.Equals("ACERO") Or GApp.EmpresaCodigo.Equals("VIRTU") Then
            Me.BackgroundImageLayout = ImageLayout.Stretch
            Me.BackgroundImage = Overlay(ACPLogistica.My.Resources.Wallpaper_Logistica_1024x768, ACPLogistica.My.Resources.Logo_Sistema_419x63, Color.White)
         Else
            Me.BackgroundImageLayout = ImageLayout.Stretch
                Me.BackgroundImage = Overlay(ACPLogistica.My.Resources.Wallpaper_Promasa_1204X903)
         End If
         Utilitarios.saveXML()
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "No se puede cargar la imagen de fondo", ex)
      End Try
   End Sub

   Private Sub NormalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NormalToolStripMenuItem.Click
      Me.BackgroundImageLayout = ImageLayout.None
      GrabarLayout()
   End Sub

   Private Sub CentradoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CentradoToolStripMenuItem.Click
      Me.BackgroundImageLayout = ImageLayout.Center
      GrabarLayout()
   End Sub

   Private Sub AjustarImagenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AjustarImagenToolStripMenuItem.Click
      Me.BackgroundImageLayout = ImageLayout.Stretch
      GrabarLayout()
   End Sub

   Private Sub MaximizadoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MaximizadoToolStripMenuItem.Click
      Me.BackgroundImageLayout = ImageLayout.Zoom
      GrabarLayout()
   End Sub

   Private Sub CambiarImagenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CambiarImagenToolStripMenuItem.Click
      Try
         Dim openFileDialog1 As New OpenFileDialog
         openFileDialog1.Filter = "Jpg|*.jpg"
         If openFileDialog1.ShowDialog() Then
            Dim Backpath As String = openFileDialog1.FileName
            If Change_BackgroundImage(Backpath) Then
               Utilitarios.cConfig("layout") = New PXML(Me.BackgroundImageLayout.ToString(), "layout")
               Utilitarios.cConfig("pathfondo") = New PXML(Backpath, "pathfondo")
               Utilitarios.saveXML()
            End If
         End If
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "No se puede cargar la imagen de fondo", ex)
      End Try
   End Sub

#End Region

#Region " Opciones del Menu "

   Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
      Me.Close()
   End Sub

   Private Sub CeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CeToolStripMenuItem.Click
      Try
         For Each item As System.Windows.Forms.Form In Me.MdiChildren
            item.Close()
         Next
         If GApp.EUsuario.NIVE_Codigo.Equals("001") Then
            tsbtnGenerarMenu.Visible = True
            tsbtnGenerarMenu.Enabled = True
         End If
         '' Cargar el entorno de Trabajo
         Using _frmentorno As New ACEntornoTrabajo()
            If _frmentorno.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
               tspUsuario.Text = GApp.EUsuarioEntidad.ENTID_Nombres
                     Dim x_validar As New ACGenerarMenu(GApp.DataConexion, GApp.DataUsuario, mnuPrincipal, ACTypeQueryMenu.asignarMenu, m_formatofecha)
                    Dim _empresa As New ACBVentas.BEntidades
                    If _empresa.Cargar(x_validar.Empresa.EMPR_RUC.Trim) Then
                        x_validar.Empresa.EMPR_Desc = _empresa.Entidades.ENTID_RazonSocial
                    End If
                    GApp.SetEmpresa(x_validar.Empresa)
                    GApp.SetEmpresa(x_validar.Empresa)
               ' Cargar los permisos de la base de administración
               SetMsg()
              ' Dim x_validar As New ACGenerarMenu(GApp.DataConexion, GApp.DataUsuario, mnuPrincipal, ACTypeQueryMenu.asignarMenu, m_formatofecha)
            Else
               Me.Close()
            End If
         End Using
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "No se puede cargar los dialogos iniciales", ex)
      End Try
   End Sub

#Region " Abastecimientos "

   Private Sub NotaDeCreditoDeFacturaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NotaDeCreditoDeFacturaToolStripMenuItem.Click
      Dim frmRegNotCreDev As New TRegNotaCredito() With {.MdiParent = Me, .StartPosition = FormStartPosition.CenterScreen, .WindowState = FormWindowState.Maximized}
      frmRegNotCreDev.Show()
   End Sub

   Private Sub ConfirmaciónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MercTranToolStripMenuItem.Click
      Dim frmConfIngreso As New TConfIngreso() With {.MdiParent = Me, .StartPosition = FormStartPosition.CenterScreen, .WindowState = FormWindowState.Maximized}
      frmConfIngreso.Show()
   End Sub

   Private Sub DeDevolucionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeDevolucionToolStripMenuItem.Click
      Dim frmRegNot As New TRegNota() With {.MdiParent = Me, .StartPosition = FormStartPosition.CenterScreen, .WindowState = FormWindowState.Maximized}
      frmRegNot.Show()
   End Sub

   Private Sub NotaDeCreditoPorCuotaMensualToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NotaDeCreditoPorCuotaMensualClickToolStripMenuItem.Click
      Dim frmCDescuentos As New TControlDescuentos() With {.MdiParent = Me, .StartPosition = FormStartPosition.CenterScreen, .WindowState = FormWindowState.Maximized}
      frmCDescuentos.Show()
   End Sub

   Private Sub CosteosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CosteosToolStripMenuItem.Click
      Dim frmCosteo As New TCosteo() With {.MdiParent = Me, .StartPosition = FormStartPosition.CenterScreen, .WindowState = FormWindowState.Maximized}
      frmCosteo.Show()
   End Sub

   Private Sub CosteoDeFletesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
      Dim frmCosteo As New TCosteo() With {.MdiParent = Me, .StartPosition = FormStartPosition.CenterScreen, .WindowState = FormWindowState.Maximized}
      frmCosteo.Show()
   End Sub

   Private Sub RegistroDeMercaderiaEnTransitoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegistroToolStripMenuItem.Click
      Dim frmRegistroCompras As New TRegIngMercaderia(RegistroToolStripMenuItem.Image) With {.MdiParent = Me, .StartPosition = FormStartPosition.CenterScreen, .WindowState = FormWindowState.Maximized}
      frmRegistroCompras.Show()
   End Sub

   Private Sub OrdenDeComprasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrdDeComToolStripMenuItem.Click
      Dim frmOrdenCompra As New TOrdenCompra() With {.MdiParent = Me, .StartPosition = FormStartPosition.CenterScreen, .WindowState = FormWindowState.Maximized}
      frmOrdenCompra.Show()
   End Sub

   Private Sub CotizacionesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CotizacionesToolStripMenuItem.Click
      Dim frmCotCompras As New TCotCompras() With {.MdiParent = Me, .StartPosition = FormStartPosition.CenterScreen, .WindowState = FormWindowState.Maximized}
      frmCotCompras.Show()
   End Sub

   Private Sub RegistroDeComprasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegCompToolStripMenuItem.Click
      Dim frmRegComp As New TRegCompra() With {.MdiParent = Me, .StartPosition = FormStartPosition.CenterScreen, .WindowState = FormWindowState.Maximized}
      frmRegComp.Show()
   End Sub

   Private Sub OrdenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
      Dim frmRegistroCompra As New TRegCompra() With {.MdiParent = Me, .StartPosition = FormStartPosition.CenterScreen, .WindowState = FormWindowState.Maximized}
      frmRegistroCompra.Show()
   End Sub

   Private Sub RequisiciónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
      Dim frmReqCompras As New TReqCompras() With {.MdiParent = Me, .StartPosition = FormStartPosition.CenterScreen, .WindowState = FormWindowState.Maximized}
      frmReqCompras.Show()
   End Sub

#End Region

#Region " Mantenimientos "

   Private Sub ProveedoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProveedoresToolStripMenuItem.Click
      Dim frmEnt As New MEntidad(MEntidad.Inicio.Normal, ACEVentas.EEntidades.TipoEntidad.ProveedoresLogistica) With {.MdiParent = Me, .StartPosition = FormStartPosition.CenterScreen}
      frmEnt.Show()
   End Sub

   Private Sub GeneralToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GeneralToolStripMenuItem.Click

   End Sub

#End Region

#Region " Control de Inventarios "

   Private Sub KardexPorSucursalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

   End Sub

   Private Sub KardexGeneralToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

   End Sub

   Private Sub StockGeneralToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

   End Sub

   Private Sub AjusteDeInventariosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
      Dim frmAjusteInv As New TAjusteInventarios()
      frmAjusteInv.MdiParent = Me
      'frmOrdenC.WindowState = FormWindowState.Maximized
      frmAjusteInv.StartPosition = FormStartPosition.CenterScreen
      frmAjusteInv.Show()
   End Sub

#End Region

#Region " Producción "

#End Region

#Region " Distribución "


#End Region

#Region " Almacenes "

#End Region

#Region " Transportes "

#End Region

#Region " Reportes "
#Region " Articulos "

   Private Sub ListadoAgrupadoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListAgruToolStripMenuItem.Click
      Dim frmRArticulo As New RListadoArticulos() With {.MdiParent = Me, .StartPosition = FormStartPosition.CenterScreen, .WindowState = FormWindowState.Maximized}
      frmRArticulo.Show()
   End Sub

   Private Sub ListadoSimpleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListadoSimpleToolStripMenuItem.Click
      Dim frmRArticuloSim As New RListadoSimple() With {.MdiParent = Me, .StartPosition = FormStartPosition.CenterScreen, .WindowState = FormWindowState.Maximized}
      frmRArticuloSim.Show()
   End Sub

#End Region

#Region " Stocks "

   Private Sub DeArticulosEnTransitoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeArticulosEnTransitoToolStripMenuItem.Click
      Dim frmStockArticulo As New CStocksArticulos() With {.MdiParent = Me, .StartPosition = FormStartPosition.CenterScreen, .WindowState = FormWindowState.Maximized}
      frmStockArticulo.Show()
   End Sub

   Private Sub DeArticulosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeArticulosToolStripMenuItem.Click
      Dim frmStockArticlo As New RStocksArticulos(DeArticulosToolStripMenuItem.Image) With {.MdiParent = Me, .StartPosition = FormStartPosition.CenterScreen, .WindowState = FormWindowState.Maximized}
      frmStockArticlo.Show()
   End Sub

   Private Sub PorProveedorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PorProveedorToolStripMenuItem.Click
      Dim frmCompProv As New RComprasXProveedor() With {.MdiParent = Me, .StartPosition = FormStartPosition.CenterScreen, .WindowState = FormWindowState.Maximized}
      frmCompProv.Show()
   End Sub

#End Region

#Region " Compras "

   Private Sub PorArticuloToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PorArticuloToolStripMenuItem.Click
      Dim frmCompArt As New RComprasXArticulo() With {.MdiParent = Me, .StartPosition = FormStartPosition.CenterScreen, .WindowState = FormWindowState.Maximized}
      frmCompArt.Show()
   End Sub

   Private Sub PorProveedorDetalladoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PorProvDetToolStripMenuItem.Click
      Dim frmCompProvArt As New RComprasXProveedorArticulos() With {.MdiParent = Me, .StartPosition = FormStartPosition.CenterScreen, .WindowState = FormWindowState.Maximized}
      frmCompProvArt.Show()
   End Sub

   Private Sub PorLineaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PorLineaToolStripMenuItem.Click
      Dim frmCompLin As New RComprasXLinea() With {.MdiParent = Me, .StartPosition = FormStartPosition.CenterScreen, .WindowState = FormWindowState.Maximized}
      frmCompLin.Show()
   End Sub

#End Region

#Region " Consultas "

   Private Sub PorIntervaloDeFechasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
      Dim frmCompProveeFec As New CComprasXProveedorXFecha() With {.MdiParent = Me, .StartPosition = FormStartPosition.CenterScreen, .WindowState = FormWindowState.Maximized}
      frmCompProveeFec.Show()
   End Sub

   Private Sub PendientesDeRecojoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PendDeRecToolStripMenuItem.Click
      Dim frmCompProvee As New CComprasXProveedor() With {.MdiParent = Me, .StartPosition = FormStartPosition.CenterScreen, .WindowState = FormWindowState.Maximized}
      frmCompProvee.Show()
   End Sub

   Private Sub EnStocksTransitoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnStocksTransitoToolStripMenuItem.Click
      Dim frmStockArticulo As New CStocksArticulos() With {.MdiParent = Me, .StartPosition = FormStartPosition.CenterScreen, .WindowState = FormWindowState.Maximized}
      frmStockArticulo.Show()
   End Sub

#End Region
#End Region

#End Region
#End Region


   Private Sub UsuariosPorAlmancenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsXAlmToolStripMenuItem.Click
      Dim frmUserPVta As New MUsuarioPorAlmacen() With {.MdiParent = Me, .StartPosition = FormStartPosition.CenterScreen}
      frmUserPVta.Show()
   End Sub

   Private Sub IngXComToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngXComToolStripMenuItem.Click

   End Sub

   Private Sub KardexToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KardexToolStripMenuItem.Click
      Dim frmCompLin As New RKardexXArticulo(KardexToolStripMenuItem.Image) With {.MdiParent = Me, .StartPosition = FormStartPosition.CenterScreen, .WindowState = FormWindowState.Maximized}
      frmCompLin.Show()
   End Sub

   Private Sub DevolverToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DevolverToolStripMenuItem.Click

   End Sub

   Private Sub AdminVentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdminVentasToolStripMenuItem.Click
      Dim frmCDocumentos As New MVentas(AdminVentasToolStripMenuItem.Image) With {.MdiParent = Me, .WindowState = FormWindowState.Maximized, .StartPosition = FormStartPosition.CenterScreen}
      frmCDocumentos.Show()
   End Sub

   Private Sub ArrInvToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArrInvToolStripMenuItem.Click
      Dim frmCDocumentos As New TArreglos(ArrInvToolStripMenuItem.Image) With {.MdiParent = Me, .WindowState = FormWindowState.Maximized, .StartPosition = FormStartPosition.CenterScreen}
      frmCDocumentos.Show()
   End Sub

   Private Sub DeArticulosAUnaFechaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeArticulosAUnaFechaToolStripMenuItem.Click

   End Sub

   Private Sub StockAFechaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StockAFechaToolStripMenuItem.Click
      Dim frmStockArticlo As New RStocksArticulos(DeArticulosToolStripMenuItem.Image) With {.MdiParent = Me, .StartPosition = FormStartPosition.CenterScreen, .WindowState = FormWindowState.Maximized}
      frmStockArticlo.Show()
   End Sub

   Private Sub OrdenarProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrdenarProductosToolStripMenuItem.Click
      Dim frmOrden As New MOrdenarProductos(OrdenarProductosToolStripMenuItem.Image) With {.MdiParent = Me, .StartPosition = FormStartPosition.CenterScreen, .WindowState = FormWindowState.Maximized}
      frmOrden.Show()
   End Sub

   Private Sub GuíasGeneralesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuíasGeneralesToolStripMenuItem.Click
      Dim frmGuiasGeneral As New RGuiasGeneralFecha(RegistroDeRetencionesToolStripMenuItem.Image) With {.MdiParent = Me, .StartPosition = FormStartPosition.CenterScreen, .WindowState = FormWindowState.Maximized}
      frmGuiasGeneral.Show()
   End Sub

   Private Sub DocXCliToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DocXCliToolStripMenuItem.Click
      Dim frmDocCliente As New RDocumentosXCliente(DocXCliToolStripMenuItem.Image) With {.MdiParent = Me, .StartPosition = FormStartPosition.CenterScreen, .WindowState = FormWindowState.Normal}
      frmDocCliente.Show()
   End Sub

   Private Sub InventarioRotativoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InventarioRotativoToolStripMenuItem.Click
      Dim frmInvRot As New CInventarioRotativo(InventarioRotativoToolStripMenuItem.Image) With {.MdiParent = Me, .StartPosition = FormStartPosition.CenterScreen, .WindowState = FormWindowState.Maximized}
      frmInvRot.Show()
   End Sub

    Private Sub StocksDeArticToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StocksDeArticToolStripMenuItem.Click

    End Sub

    Private Sub CruceGAlmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CruceGAlmToolStripMenuItem.Click
        Dim frmCruze As New RcruzeAlmacenes(KardexToolStripMenuItem.Image) With {.MdiParent = Me, .StartPosition = FormStartPosition.CenterScreen, .WindowState = FormWindowState.Maximized}
        frmCruze.Show()
    End Sub

 
    Private Sub GuiasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuiasToolStripMenuItem.Click
        Dim frmGuias As New RGuias(KardexToolStripMenuItem.Image) With {.MdiParent = Me, .StartPosition = FormStartPosition.CenterScreen, .WindowState = FormWindowState.Maximized}
        frmGuias.Show()
    End Sub

    Private Sub ComVsIngAlmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComVsIngAlmToolStripMenuItem.Click
        Dim frmGuias As New RIngresosvsCompras(KardexToolStripMenuItem.Image) With {.MdiParent = Me, .StartPosition = FormStartPosition.CenterScreen, .WindowState = FormWindowState.Maximized}
        frmGuias.Show()
    End Sub

Private Sub VentasToolStripMenuItem_Click( sender As Object,  e As EventArgs) Handles VentasBToolStripMenuItem.Click
        Dim frmVentas As New RVentasB(KardexToolStripMenuItem.Image) With {.MdiParent = Me, .StartPosition = FormStartPosition.CenterScreen, .WindowState = FormWindowState.Maximized}
        frmVentas.Show()
End Sub

Private Sub VentasFToolStripMenuItem_Click( sender As Object,  e As EventArgs) Handles VentasFToolStripMenuItem.Click
        Dim frmVentas As New RVentasF(KardexToolStripMenuItem.Image) With {.MdiParent = Me, .StartPosition = FormStartPosition.CenterScreen, .WindowState = FormWindowState.Maximized}
        frmVentas.Show()
End Sub

Private Sub RevisionOrdenesIngresoToolStripMenuItem_Click( sender As Object,  e As EventArgs) Handles RevisionOrdenesIngresoToolStripMenuItem.Click
         Dim frmOrdenes As New ROrdenesIngreso(KardexToolStripMenuItem.Image) With {.MdiParent = Me, .StartPosition = FormStartPosition.CenterScreen, .WindowState = FormWindowState.Maximized}
        frmOrdenes.Show()
End Sub

Private Sub RevisionOrdenesSalidaToolStripMenuItem_Click( sender As Object,  e As EventArgs) Handles RevisionOrdenesSalidaToolStripMenuItem.Click
          Dim frmOrdenes As New ROrdenesSalida(KardexToolStripMenuItem.Image) With {.MdiParent = Me, .StartPosition = FormStartPosition.CenterScreen, .WindowState = FormWindowState.Maximized}
        frmOrdenes.Show()
End Sub

Private Sub PedidoCompraToolStripMenuItem_Click( sender As Object,  e As EventArgs) Handles PedidoCompraToolStripMenuItem.Click
      '  Dim frmPedidoCompra As New TPedidoCompra(PedidoCompraToolStripMenuItem.Image, TPedidoCompra.TInicio.Normal) With {.MdiParent = Me, .StartPosition = FormStartPosition.CenterScreen, .WindowState = FormWindowState.Maximized}
          Dim frmPedidoCompra As New TPedidoCompra( TPedidoCompra.TInicio.Normal) With {.MdiParent = Me, .StartPosition = FormStartPosition.CenterScreen, .WindowState = FormWindowState.Maximized}
        frmPedidoCompra.Show()
End Sub

Private Sub StocksInicialesToolStripMenuItem_Click( sender As Object,  e As EventArgs) Handles StocksInicialesToolStripMenuItem.Click
          Dim frmStockInicial As New CStocksIniciales(DeArticulosToolStripMenuItem.Image) With {.MdiParent = Me, .StartPosition = FormStartPosition.CenterScreen, .WindowState = FormWindowState.Maximized}
      frmStockInicial.Show()
End Sub

    Private Sub EstadoDePagosPorProveedorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstadoDePagosPorProveedorToolStripMenuItem.Click

    End Sub

    Private Sub AdministraciónDeComprasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdministraciónDeComprasToolStripMenuItem.Click
        Dim frmCDocumentos As New MCompras(AdministraciónDeComprasToolStripMenuItem.Image) With {.MdiParent = Me, .WindowState = FormWindowState.Maximized, .StartPosition = FormStartPosition.CenterScreen}
        frmCDocumentos.Show()
    End Sub

    Private Sub PendientesPorDocumentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PendientesPorDocumentoToolStripMenuItem.Click
        Dim frmPdocumento As New RPendientesXDocumento(PendientesPorDocumentoToolStripMenuItem.Image) With {.MdiParent = Me, .WindowState = FormWindowState.Normal, .StartPosition = FormStartPosition.CenterScreen, .MaximizeBox = False}
        frmPdocumento.Show()
        frmPdocumento.WindowState = FormWindowState.Normal
    End Sub

    Private Sub KardexPorArticuloStockFisicoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KardexPorArticuloStockFisicoToolStripMenuItem.Click
        Dim frmCompLin As New RKardexXArticuloStockFisico(KardexToolStripMenuItem.Image) With {.MdiParent = Me, .StartPosition = FormStartPosition.CenterScreen, .WindowState = FormWindowState.Maximized}
        frmCompLin.Show()
    End Sub

    Private Sub ReportesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportesToolStripMenuItem.Click

    End Sub
    'otro menu 
    'Private Sub ReporteVentasTotalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteVentasTotalToolStripMenuItem.Click
    '    Dim frmVentasvsEntregasTotales As New RVentasVSEntregasTotales() With {.MdiParent = Me, .StartPosition = FormStartPosition.CenterScreen, .WindowState = FormWindowState.Maximized}
    '    frmVentasvsEntregasTotales.Show()
    'End Sub

    Private Sub ReporteCruzesDeOrdenPorPuntoVentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteCruzesDeOrdenPorPuntoVentaToolStripMenuItem.Click
        Dim frmVentasvsEntregasTotales As New ROrdenesCruzeEntregasTotales() With {.MdiParent = Me, .StartPosition = FormStartPosition.CenterScreen, .WindowState = FormWindowState.Maximized}
        frmVentasvsEntregasTotales.Show()
    End Sub

    Private Sub ReporteEntregaXFacturasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteVentasTotalToolStripMenuItem.Click
        Dim frmVentasvsEntregasTotales As New RVentasVSEntregasTotales() With {.MdiParent = Me, .StartPosition = FormStartPosition.CenterScreen, .WindowState = FormWindowState.Maximized}
        frmVentasvsEntregasTotales.Show()
    End Sub
End Class
