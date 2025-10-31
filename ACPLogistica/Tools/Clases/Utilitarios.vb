Imports System.Xml
Imports System.Text
Imports System.Globalization
Imports C1.Win.C1FlexGrid

Imports ACReporteador
Imports ACFramework

Imports vb = Microsoft.VisualBasic
Imports System.IO

Public Class Utilitarios

#Region " Guardar Configuracion "
   Private Shared m_cconfig As Hashtable
   Private Shared m_cconfiguracion As ACFramework.CConfig
   Private Shared m_listCConfig As New List(Of ACFramework.CConfig)

   Public Shared Property cConfig() As Hashtable
      Get
         Return m_cconfig
      End Get
      Set(ByVal value As Hashtable)
         m_cconfig = value
      End Set
   End Property

   Public Shared Property cConfiguracion() As ACFramework.CConfig
      Get
         Return m_cconfiguracion
      End Get
      Set(ByVal value As ACFramework.CConfig)
         m_cconfiguracion = value
      End Set
   End Property

   Public Shared Sub saveXML()
      Try
         Dim pathName As String = Path.Combine(Application.StartupPath, "cConfig.xml")
         m_cconfiguracion.Empresa = IIf(CType(m_cconfig("empresa"), PXML).Valor = "", GApp.Empresa, CType(m_cconfig("empresa"), PXML).Valor)
         m_cconfiguracion.Zona = CType(m_cconfig("zona"), PXML).Valor
         m_cconfiguracion.Sucursal = CType(m_cconfig("sucursal"), PXML).Valor
         m_cconfiguracion.Almacen = CType(m_cconfig("almacen"), PXML).Valor
         m_cconfiguracion.PathFondo = CType(m_cconfig("pathfondo"), PXML).Valor
         m_cconfiguracion.FondoLayout = ACFramework.CConfig.getLayout(CType(m_cconfig("layout"), PXML).Valor)
         m_cconfiguracion.HConfig = m_cconfig
         Dim _noexiste As Boolean = True
         For Each item As ACFramework.CConfig In m_listCConfig
            If item.Empresa.Equals(m_cconfiguracion.Empresa) Then
               _noexiste = False
            End If
         Next
         If _noexiste Then
            m_listCConfig.Add(m_cconfiguracion)
         End If
         ACFramework.CConfig.saveXML(pathName, m_listCConfig)
      Catch ex As Exception
         Throw ex
      End Try
   End Sub

   Public Shared Sub getFileConfigBase()
      Try
         m_cconfiguracion = New ACFramework.CConfig()
         cConfig = ACFramework.CConfig.getFileConfigBase(Application.StartupPath, "cConfig.xml", m_cconfiguracion, m_listCConfig, GApp.Empresa)
      Catch ex As Exception
         Throw ex
      End Try
   End Sub
#End Region

#Region " Especial "
   Private Shared m_numberFormatInfo As NumberFormatInfo = CultureInfo.CurrentCulture.NumberFormat
   Private Shared m_decimalSeparator As String = m_numberFormatInfo.NumberDecimalSeparator
   Private Shared m_GroupSeparator As String = m_numberFormatInfo.NumberGroupSeparator
   Private Shared m_NegativeSign As String = m_numberFormatInfo.NegativeSign
   'Private Shared m_decimales As Integer = 2
   'Private Shared m_enteros As Integer = 8
   Private Shared m_negativo As Boolean = True
   'Private Shared m_formato As String

   Public Shared Sub ValidarKeyPress(ByRef x_text As ComboBox, ByVal e As System.Windows.Forms.KeyPressEventArgs _
                                     , ByVal m_enteros As Integer, ByVal m_decimales As Integer, ByVal m_formato As String)
      Try
         Dim keyInput As String = e.KeyChar.ToString()

         'Si presiono Backspace deja borrar de todas formas
         If e.KeyChar = vbBack Then e.Handled = False : Return
         'Si es signo negativo y ya hay uno entonces no deja
         If keyInput.Equals(m_NegativeSign) And x_text.Text.IndexOf(m_NegativeSign) <> -1 Then e.Handled = True : Return
         'Si es negativo y no esta al comienzo no deja
         If keyInput.Equals(m_NegativeSign) And x_text.SelectionStart > 0 Then e.Handled = True : Return
         'Si es punto/coma decimal
         If keyInput.Equals(m_decimalSeparator) Then
            'Si el todo el texto esta seleccionado limpiar y colocar el separador
            If x_text.Text = x_text.SelectedText Then x_text.Text = keyInput : x_text.SelectionStart = x_text.Text.Length
            'Si ya existe punto no deja
            If x_text.Text.IndexOf(m_decimalSeparator) <> -1 Then e.Handled = True : Return
            'Si ha sido configurado sin decimales tampoco deja
            If m_decimales = 0 Then e.Handled = True : Return
         End If

         If [Char].IsDigit(e.KeyChar) Then
            If x_text.Text = x_text.SelectedText Then x_text.Text = keyInput : x_text.SelectionStart = x_text.Text.Length : e.Handled = True
         End If

         'Si es un numero
         If [Char].IsDigit(e.KeyChar) Then
            'Si no hay un punto/coma decimal 
            If x_text.Text.IndexOf(m_decimalSeparator) = -1 Then
               'Si longitud de numeros ingresados mayor q nro de Enteros no deja
               If LenghtSoloNros(x_text.Text) + 1 > m_enteros Then e.Handled = True : Return
            Else     'Si hay punto/coma decimal
               Dim aParts() As String = x_text.Text.Split(m_decimalSeparator)
               'Si estamos ingresando numeros antes del punto
               If x_text.SelectionStart < x_text.Text.IndexOf(m_decimalSeparator) Then
                  'Si longitud de numeros+1 es mayor q nro de Enteros no deja
                  If LenghtSoloNros(aParts(aParts.GetLowerBound(0))) + 1 > m_enteros Then e.Handled = True : Return
               End If
               'Si estamos ingresando numeros despues del punto
               If x_text.SelectionStart > x_text.Text.IndexOf(m_decimalSeparator) Then
                  'Si longitud de numeros+1 es mayor q nro de Decimales no deja
                  If LenghtSoloNros(aParts(aParts.GetUpperBound(0))) + 1 > m_decimales Then e.Handled = True : Return
               End If
            End If
         ElseIf keyInput.Equals(m_decimalSeparator) OrElse keyInput.Equals(m_GroupSeparator) OrElse keyInput.Equals(m_NegativeSign) Then
            'Punto/coma Decimal, Signo negativo, Caracter de miles is OK
            If keyInput.Equals(m_NegativeSign) Then
               If Not m_negativo Then e.Handled = True : Return
            End If
         Else
            ' Swallow this invalid key and beep
            e.Handled = True
         End If
      Catch ex As Exception
         Throw ex
      End Try
   End Sub

   Private Shared Function LenghtSoloNros(ByVal numero As String) As Integer
      Try
         Dim aChars As Char() = numero.ToCharArray
         Dim len As Integer = 0
         For i As Integer = aChars.GetLowerBound(0) To aChars.GetUpperBound(0)
            If "0123456789".IndexOf(aChars(i)) <> -1 Then
               len += 1
            End If
         Next
         Return len
      Catch ex As Exception
         Throw ex
      End Try
   End Function

   Public Shared Function FormateaText(ByVal TextNum As String, ByVal m_formato As String) As String
      Try
         Dim NumFormat As Double
         If TextNum.Trim.Length = 0 Then
            NumFormat = 0
         ElseIf IsNothing(TextNum) Then
            NumFormat = 0
         Else
            Try
               If TextNum IsNot Nothing Then
                  If IsNumeric(TextNum) Then
                     NumFormat = Convert.ToDecimal(TextNum)
                  End If
               End If
            Catch ex As Exception
               Throw New Exception(String.Format("Error al convertir la cadena de Texto : '{0}' a numérico{1}{2}", TextNum, ControlChars.CrLf, ex.Message), ex)
            End Try
         End If
         'ACValue = NumFormat
         Return NumFormat.ToString(m_formato)
      Catch ex As Exception
         Throw ex
      End Try
   End Function
#End Region

#Region " Reportes "
   Enum typePrintFlex
      toPreviewScreen = 0
      toPrinterPaper = 1
   End Enum


   Enum Sizepage
      FitTopageWidth
      ActualSize
      FitTopage
   End Enum


   Public Shared Function reportToScreen(ByVal _flex As C1FlexGrid, ByVal title As String, ByVal titleFlex As String, _
                                         ByVal resumen As String, ByVal dateShow As DateTime, _
                                         ByVal paperSize As Printing.PaperSize, ByVal paperMargin As Printing.Margins, _
                                         Optional ByVal x_subtitulo1 As String = "", _
                                         Optional ByVal x_subtitulo2 As String = "", _
                                         Optional ByVal PrinterHeader As Boolean = True, _
                                         Optional ByVal LandScape As Boolean = False, _
                                         Optional ByVal toDriver As typePrintFlex = typePrintFlex.toPreviewScreen, _
                                         Optional ByVal Font As String = "Courier New", _
                                         Optional ByVal sizeFont As Int16 = 9, _
                                         Optional ByVal styleFont As FontStyle = FontStyle.Regular, _
                                         Optional ByVal x_opcionsize As Sizepage = Sizepage.ActualSize) As Boolean
      Try
         Dim _borderStyle As Util.BaseControls.BorderStyleEnum = _flex.BorderStyle
         Dim _normalBackColor As Color = _flex.Styles.Normal.BackColor
         Dim _fixedBackColor As Color = _flex.Styles.Fixed.BackColor
         Dim _alternativeBackColor As Color = _flex.Styles.Alternate.BackColor

         _flex.BorderStyle = Util.BaseControls.BorderStyleEnum.None
         _flex.Styles.Fixed.BackColor = Color.White
         _flex.Styles.Normal.BackColor = Color.White
         _flex.Styles.Alternate.BackColor = Color.White

         _flex.PrintParameters.PrintDocument.DefaultPageSettings.PaperSize = paperSize
         _flex.PrintParameters.PrintDocument.DefaultPageSettings.Margins = paperMargin
         _flex.PrintParameters.PrintDocument.DefaultPageSettings.Landscape = LandScape
         _flex.PrintParameters.PrintDocument.OriginAtMargins = False

         'Dim strTitulo As String = "Rechazos por Coordinador del " & dtpDe.NSMaskedTextBox.Text.ToString() & " Al " & dtpA.NSMaskedTextBox.Text.ToString()
         'Dim strHeader As String = DefinirCabeceraReporte(title, dateShow, x_subtitulo1, x_subtitulo2).ToString()

         _flex.PrintParameters.HeaderFont = New Font(Font, sizeFont, FontStyle.Regular)
         '_flex.PrintParameters.Header = strHeader
         _flex.PrintParameters.Header = Reporte_Headers1(x_subtitulo1, x_subtitulo2).ToString()
         _flex.PrintParameters.Header += Reporte_Headers2(title).ToString()
         _flex.PrintParameters.Header += Reporte_Headers3(dateShow).ToString()

         _flex.PrintParameters.FooterFont = New Font(Font, sizeFont, FontStyle.Regular)
         _flex.PrintParameters.Footer = resumen

         Select Case x_opcionsize
            Case Sizepage.ActualSize
               If typePrintFlex.toPreviewScreen = toDriver Then
                  _flex.PrintGrid(titleFlex, PrintGridFlags.ActualSize + PrintGridFlags.ShowPreviewDialog) 'strHeader
               Else
                  _flex.PrintGrid(titleFlex, PrintGridFlags.ActualSize + PrintGridFlags.ShowPageSetupDialog + PrintGridFlags.ShowPrintDialog) 'strHeader
               End If
            Case Sizepage.FitTopage
               If typePrintFlex.toPreviewScreen = toDriver Then
                  _flex.PrintGrid(titleFlex, PrintGridFlags.FitToPage + PrintGridFlags.ShowPreviewDialog) 'strHeader
               Else
                  _flex.PrintGrid(titleFlex, PrintGridFlags.FitToPage + PrintGridFlags.ShowPageSetupDialog + PrintGridFlags.ShowPrintDialog) 'strHeader
               End If
            Case Sizepage.FitTopageWidth
               If typePrintFlex.toPreviewScreen = toDriver Then
                  _flex.PrintGrid(titleFlex, PrintGridFlags.FitToPageWidth + PrintGridFlags.ShowPreviewDialog) 'strHeader
               Else
                  _flex.PrintGrid(titleFlex, PrintGridFlags.FitToPageWidth + PrintGridFlags.ShowPageSetupDialog + PrintGridFlags.ShowPrintDialog) 'strHeader
               End If
         End Select

         _flex.BorderStyle = _borderStyle
         _flex.Styles.Normal.BackColor = _normalBackColor
         _flex.Styles.Fixed.BackColor = _fixedBackColor
         _flex.Styles.Alternate.BackColor = _alternativeBackColor

         Return True
      Catch ex As Exception
         Throw ex
      End Try
   End Function

   Public Shared Function reportPreview(ByVal _flex As C1FlexGrid, ByVal title As String, ByVal titleFlex As String, _
                                        ByVal resumen As String, ByVal dateShow As DateTime, _
                                        ByVal paperSize As Printing.PaperSize, ByVal paperMargin As ACMargen, _
                                        ByVal l_merged As ACCeldaCombinadaLista, _
                                        ByVal text As ACTextoLista, _
                                        Optional ByVal x_subtitulo1 As String = "", _
                                        Optional ByVal x_subtitulo2 As String = "", _
                                        Optional ByVal PrinterHeader As Boolean = True, _
                                        Optional ByVal LandScape As Boolean = False, _
                                        Optional ByVal Font As String = "Courier New", _
                                        Optional ByVal sizeFont As Int16 = 9, _
                                        Optional ByVal styleFont As FontStyle = FontStyle.Regular, _
                                        Optional ByVal x_opcionsize As Sizepage = Sizepage.ActualSize) As Boolean
      Try
         Dim strSucursal As String = GApp.ESucursal.SUCUR_Nombre.ToString()
         Dim strRuc As String = Parametros.GetParametro(ACEVentas.EParametros.TipoParametros.Empresa)
         If l_merged Is Nothing Then
            l_merged = New ACCeldaCombinadaLista
         End If
         Dim footer As New ACPiePagina(resumen)

         Dim style As New ACEstilo()
         style.EEstilo = ACEEstilo.modern
         style.HojaHorizontal = LandScape
         Dim _fuente As Font = New Font(Font, 7)
         Dim _cabecera As ACCabecera = New ACCabecera(New ACTexto(title), strSucursal, strRuc, dateShow, _fuente)
         Dim x As ACPreview
         x = New ACPreview(_flex, l_merged, _cabecera)
         x.ACEstiloReporte = style
         x.ACEstiloReporte.Fuente = New Font(Font, 7, styleFont)
         x.ACEjecutar()
         x.ShowDialog()
         Return True
      Catch ex As Exception
         Throw ex
      End Try
   End Function

   Private Shared Function Reporte_Headers1(ByVal subTitle1 As String, ByVal subTitle2 As String) As StringBuilder
      Try
         Dim cabecera As New StringBuilder()
         cabecera.Append("SUCURSAL".PadRight(8, " ") + " : " + GApp.ESucursal.SUCUR_Nombre.ToString() & vbNewLine)
         If Not IsNothing(Parametros.GetParametro(ACEVentas.EParametros.TipoParametros.Empresa)) Then
            cabecera.Append("RUC".PadRight(8, " ") + " : " + Parametros.GetParametro(ACEVentas.EParametros.TipoParametros.Empresa).ToString())
         End If
         cabecera.Append(vbNewLine & vbNewLine & vbNewLine)
         cabecera.Append(subTitle1 & vbNewLine)
         cabecera.Append(subTitle2 & vbNewLine)
         Return cabecera
      Catch ex As Exception
         Throw ex
      End Try
   End Function
   Private Shared Function Reporte_Headers2(ByVal strTitulo As String) As StringBuilder
      Try
         Dim cabecera As New StringBuilder()
         cabecera.Append(vbTab & vbNewLine & vbNewLine & strTitulo & vbNewLine & vbNewLine & vbNewLine)
         Return cabecera
      Catch ex As Exception
         Throw ex
      End Try
   End Function
   Private Shared Function Reporte_Headers3(ByVal dtFecha As DateTime) As StringBuilder
      Try
         Dim cabecera As New StringBuilder()
         Dim strNroPaginas As String = "PAGINA {0} DE {1}"
         Dim strFecha As String
         strFecha = dtFecha.ToShortDateString() & " " & dtFecha.ToShortTimeString()
         cabecera.Append(vbTab & "FECHA : " & strFecha & vbNewLine & " " & strNroPaginas & vbNewLine & vbNewLine & vbNewLine & vbNewLine & vbNewLine)
         Return cabecera
      Catch ex As Exception
         Throw ex
      End Try
   End Function
#End Region

#Region " VARIOS "
   Public Shared Sub ExportarXLS(ByRef _c1grd As C1FlexGrid, ByVal x_titulo As String)
      Try
         Dim archivo As String, proceso As Process = New Process
         Dim sfdArchivo As New SaveFileDialog()
         sfdArchivo.DefaultExt = ".xls"
         sfdArchivo.Filter = "*.xls|"
         If sfdArchivo.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            archivo = sfdArchivo.FileName
            _c1grd.SaveExcel(archivo, x_titulo, FileFlags.IncludeFixedCells + FileFlags.IncludeMergedRanges)
            Process.Start(archivo)
         End If
      Catch ex As Exception
         Throw ex
      End Try
   End Sub
#End Region

End Class

Public Class Presupuesto
#Region " Variables "
   Private m_orden As Integer
   Private m_descripcion As String
   Private m_monto As Double
#End Region

#Region " Propiedades "

   Public Property Orden() As Integer
      Get
         Return m_orden
      End Get
      Set(ByVal value As Integer)
         m_orden = value
      End Set
   End Property

   Public Property Descripcion() As String
      Get
         Return m_descripcion
      End Get
      Set(ByVal value As String)
         m_descripcion = value
      End Set
   End Property

   Public Property Monto() As Double
      Get
         Return m_monto
      End Get
      Set(ByVal value As Double)
         m_monto = value
      End Set
   End Property

#End Region

#Region " Constructores "
   Public Sub New()

   End Sub

   Public Sub New(ByVal x_orden As Integer, ByVal x_descripcion As String, ByVal x_monto As Double)
      Me.m_orden = x_orden
      Me.m_descripcion = x_descripcion
      Me.m_monto = x_monto
   End Sub

   Public Sub New(ByVal x_descripcion As String, ByVal x_monto As Double)
      Me.m_orden = 0
      Me.m_descripcion = x_descripcion
      Me.m_monto = x_monto
   End Sub
#End Region

#Region " Metodos "

#End Region

#Region " Metodos de Controles"

#End Region
End Class

