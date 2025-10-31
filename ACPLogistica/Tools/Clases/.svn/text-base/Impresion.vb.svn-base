Imports System.Text
Imports ACImpresion
Imports ACFramework
Imports ACBVentas
Imports ACEVentas

Imports CrystalDecisions

Imports Microsoft.VisualBasic.PowerPacks.Printing.Compatibility.VB6
Imports CrystalDecisions.CrystalReports.Engine

Public Class Impresion

#Region " Variables "
   Private m_printername As String
#End Region

#Region " Propiedades "

#End Region

#Region " Constructores "
   Public Sub New(ByVal x_printer As String)
      Try
         m_printername = x_printer
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", "Impresion"), "Ocurrio un error en el proceso Inicializar Impresora", ex)
      End Try
   End Sub
#End Region

#Region " Metodos "


#Region " Impresion Facturas"
   Public Function Print_Factura(ByVal x_docve_codigo As String, ByVal x_serie As String, ByVal x_puntoventa As String, Optional ByVal x_lineas As Integer = 25) As Boolean
      Try
         Dim m_docven As New ACEVentas.EVENT_DocsVenta
         If Get_Facturas(m_docven, x_docve_codigo, x_puntoventa) Then
            Select Case GApp.Empresa
               Case "ACERO", "VIRTU"
                  If m_docven.TIPOS_CodTipoDocumento = ETipos.getTipoComprobante(ETipos.TipoComprobanteVenta.Factura) Then
                     Select Case x_serie
                        Case "016", "011", "013", "014", "015", "021"
                           Return ImprimirF016Aceros(m_docven, x_lineas)
                        Case "017"
                           Return ImprimirF016Aceros(m_docven, x_lineas)
                        Case ""
                           Throw New Exception("Metodo de Impresión no Implementado")
                        Case Else
                           Throw New Exception("Metodo de Impresión no Implementado")
                     End Select
                  ElseIf m_docven.TIPOS_CodTipoDocumento = ETipos.getTipoComprobante(ETipos.TipoComprobanteVenta.Boleta) Then
                     Select Case x_serie
                        Case "016", "011", "013", "014", "015", "021"
                           Return ImprimirB016AcerosV2(m_docven, x_lineas)
                        Case Else
                           Throw New Exception("Metodo de Impresión no Implementado")
                     End Select
                  End If
            End Select
            Return False
         End If
      Catch ex As Exception
         Throw ex
      End Try
   End Function

#Region " Serie 016 "
   Private Function ImprimirF016Aceros(ByVal m_docventa As EVENT_DocsVenta, ByVal x_filas As Integer) As Boolean
      Dim m_texto As String = ""
      Dim m_space As Integer = 0
      Dim m_cabecera As New StringBuilder
      Dim m_cuerpo As New StringBuilder
      Dim m_pie As New StringBuilder
      Try
         '' Generar Cabecera
         ACFramework.ACUtilitarios.ImprimeLinBlanco(m_cabecera, 6)
         m_cabecera.Append(String.Format("{0}{1}", Space(m_space + 110), m_docventa.Documento))
         ACFramework.ACUtilitarios.ImprimeLinBlanco(m_cabecera, 2)
         Dim _cab As New List(Of String)
         _cab.Add(String.Format("{0}{1}{2}{3}", Space(m_space + 37) _
                                          , m_docventa.DOCVE_FechaDocumento.Day.ToString("00").PadRight(10, " ") _
                                          , MonthName(m_docventa.DOCVE_FechaDocumento.Month).ToUpper().PadRight(28, " ").Substring(0, 28), m_docventa.DOCVE_FechaDocumento.Year.ToString("0000")))
         _cab.Add(String.Format("{0}{1}", Space(m_space + 12), m_docventa.DOCVE_DescripcionCliente))
         _cab.Add(String.Format("{0}{1}", Space(m_space + 12), m_docventa.DOCVE_DireccionCliente))
         _cab.Add(String.Format("{0}{1}{2}", Space(m_space + 10), m_docventa.ENTID_NroDocumento.PadRight(100, " "), m_docventa.DOCVE_FechaDocumento.ToString("dd/MM/yyyy")))
         _cab.Add(New String(""))

         ACUtilitarios.genTexto(_cab, m_cabecera)
         ACFramework.ACUtilitarios.ImprimeLinBlanco(m_cabecera, 1)
         '' Generar Detalle
         Dim x_fila As Integer = 0
         Dim x_peso As Decimal = 0
         For Each item As EVENT_DocsVentaDetalle In m_docventa.ListVENT_DocsVentaDetalle
            x_peso += item.DOCVD_Cantidad
            Dim x_lista As New List(Of String)
            If IsNothing(item.DOCVD_Detalle) Then item.DOCVD_Detalle = ""
            If ACUtilitarios.GetTextoLines(item.DOCVD_Detalle, 75, x_lista) > 0 Then
               m_cuerpo.Append(String.Format("{0}{1}{2}{3}{4}{5}{6}", Space(m_space) _
                                                   , ACUtilitarios.Alinear(ACAlineacion.Derecha, item.DOCVD_Cantidad.ToString("###,##0.000"), 11) _
                                                   , ACUtilitarios.Alinear(ACAlineacion.Centro, item.DOCVD_Unidad, 17) _
                                                   , x_lista(0).PadRight(75, " ").Substring(0, 75) _
                                                   , ACUtilitarios.Alinear(ACAlineacion.Derecha, item.DOCVD_PrecioUnitario.ToString("###,##0.00"), 17) _
                                                   , ACUtilitarios.Alinear(ACAlineacion.Derecha, item.DOCVD_SubImporteVenta.ToString("###,##0.00"), 17) _
                                                   , vbNewLine))
               If x_lista.Count > 1 Then
                  Dim j As Integer
                  For j = 1 To x_lista.Count - 1
                     m_cuerpo.Append(String.Format("{0}{1}{2}", Space(m_space + 28), x_lista(j).Trim(), vbNewLine))
                  Next
               End If
               x_fila += x_lista.Count
            Else
               x_fila += 1
               m_cuerpo.Append(String.Format("{0}{1}{2}{3}{4}{5}", Space(m_space) _
                                                   , ACUtilitarios.Alinear(ACAlineacion.Derecha, item.DOCVD_Cantidad.ToString("###,##0.0000"), 11) _
                                                   , ACUtilitarios.Alinear(ACAlineacion.Centro, item.DOCVD_Unidad, 16) _
                                                   , "" _
                                                   , ACUtilitarios.Alinear(ACAlineacion.Derecha, item.DOCVD_PrecioUnitario.ToString("###,##0.0000"), 18) _
                                                   , ACUtilitarios.Alinear(ACAlineacion.Derecha, item.DOCVD_SubImporteVenta.ToString("###,##0.0000"), 18) _
                                                   ))
            End If

         Next

         ACUtilitarios.ImprimeLinBlanco(m_cuerpo, x_filas - x_fila)

         '' Generar Pie de Pagina
         Dim _pie As New List(Of String)
         _pie.Add(New String(" "))
         If (IsNothing(m_docventa.DOCVE_NotaPie)) Then
            _pie.Add(New String(" "))
         Else
            _pie.Add(New String(String.Format("{0}{1}", Space(m_space + 28), m_docventa.DOCVE_NotaPie.Trim())))
         End If
         _pie.Add(New String(" "))
         Dim _filter As New ACFiltrador(Of ETipos)
         _filter.ACFiltro = String.Format("TIPOS_Codigo={0}", m_docventa.TIPOS_CodTipoMoneda)
         _filter.ACFiltrar(Colecciones.Tipos)
         Dim _simb = m_docventa.TIPOS_TipoMoneda
         If m_docventa.TIPOS_CodTipoMoneda.Equals(ETipos.getTipo(ETipos.TipoMoneda.Dolares)) Then
            _pie.Add(String.Format("{0}{1}", Space(m_space + 5), ACUtilitarios.NumPalabra(m_docventa.DOCVE_TotalPagar, _filter.ACListaFiltrada(0).TIPOS_Descripcion)))
         Else
            _pie.Add(String.Format("{0}{1}", Space(m_space + 5), ACUtilitarios.NumPalabra(m_docventa.DOCVE_TotalPagar, "NUEVOS SOLES")))
         End If

         _pie.Add(New String(""))
         _pie.Add(New String(""))
         ACUtilitarios.genTexto(_pie, m_pie)
         m_cabecera.Append(m_cuerpo)
         m_cabecera.Append(m_pie)

         _pie = New List(Of String)
         _pie.Add(String.Format("{0} {1} {2} {3} {4} {5} {6}", Space(m_space) _
                                    , (_simb & " " & m_docventa.DOCVE_ImporteVenta.ToString(Parametros.GetParametro(EParametros.TipoParametros.pg_FMondo2d))).ToString().PadLeft(16, " ").Substring(0, 16) _
                                    , (_simb & " " & m_docventa.DOCVE_ImporteIgv.ToString(Parametros.GetParametro(EParametros.TipoParametros.pg_FMondo2d))).ToString().PadLeft(22, " ").Substring(0, 22) _
                                    , (_simb & " " & m_docventa.DOCVE_TotalVenta.ToString(Parametros.GetParametro(EParametros.TipoParametros.pg_FMondo2d))).ToString().PadLeft(22, " ").Substring(0, 22) _
                                    , (_simb & " " & m_docventa.DOCVE_AfectoPercepcion.ToString(Parametros.GetParametro(EParametros.TipoParametros.pg_FMondo2d))).ToString().PadLeft(22, " ").Substring(0, 22) _
                                    , (_simb & " " & m_docventa.DOCVE_ImportePercepcion.ToString(Parametros.GetParametro(EParametros.TipoParametros.pg_FMondo2d))).ToString().PadLeft(22, " ").Substring(0, 22) _
                                    , (_simb & " " & m_docventa.DOCVE_TotalPagar.ToString(Parametros.GetParametro(EParametros.TipoParametros.pg_FMondo2d))).ToString().PadLeft(26, " ").Substring(0, 26)))
         _pie.Add(New String(""))
         _pie.Add(New String(""))
         _pie.Add(String.Format("{0} {1} {2} {3} {4}", Space(m_space + 3) _
                                    , (" " & x_peso.ToString(Parametros.GetParametro(EParametros.TipoParametros.pg_FMondo4d)) & " Kg.").ToString().PadLeft(16, " ").Substring(0, 12) _
                                    , (" " & DateTime.Now.ToString("hh:mm tt")).PadLeft(27, " ").Substring(0, 27) _
                                    , (" " & m_docventa.ENTID_Vendedor.PadRight(22, " ").Substring(0, 22)).ToString().PadLeft(22, " ").Substring(0, 22) _
                                    , (" " & m_docventa.Cotizador).ToString().PadLeft(24, " ").Substring(0, 24)))

         _pie.Add(New String(" "))
         _pie.Add(New String(" "))
         m_pie = New StringBuilder()
         ACUtilitarios.genTexto(_pie, m_pie)
         '' Imprimir
         ACFramework.ACUtilitarios.ImprimeLinBlanco(m_pie, 3)
         m_cabecera.Append(m_pie)
         'SetPrinterNormal(m_cabecera, ACInterEspaciado.Seis, 68)
         'SetPrinterTitulo(m_pie, ACInterEspaciado.Seis, 3)

         ACImpresion.ACImprimir.Inicializar(m_printername)
         ACImpresion.ACImprimir.SendStringToPrinter(Chr(18))
         ACImpresion.ACImprimir.SendStringToPrinter(ACFuncImpresion.NumeroLineas(68))
         ACImpresion.ACImprimir.SendStringToPrinter(ACFuncImpresion.Fuente(ACFuentes.Draft))
         ACImpresion.ACImprimir.SendStringToPrinter(String.Format("{0}{1}", Chr(27), Chr(15)))
         ACImpresion.ACImprimir.SendStringToPrinter(ACFuncImpresion.FuenteDraft(ACDrafts.Draft10PCI))
         ACImpresion.ACImprimir.SendStringToPrinter(ACFuncImpresion.Condensado(False))
         ACImpresion.ACImprimir.SendStringToPrinter(ACFuncImpresion.Interespaciado(ACInterEspaciado.Seis))
         ACImprimir.SendStringToPrinter(m_cabecera.ToString())

         Return True
      Catch ex As Exception
         Throw ex
      End Try
   End Function
#End Region

#End Region

#Region " Impresion Boletas"
#Region " Serie 016 "
   Private Function ImprimirB016Aceros(ByVal m_docventa As EVENT_DocsVenta, ByVal x_filas As Integer) As Boolean
      Dim m_texto As String = ""
      Dim m_space As Integer = 0
      Dim m_cabecera As New StringBuilder
      Dim m_cuerpo As New StringBuilder
      Dim m_pie As New StringBuilder
      Try
         '' Generar Cabecera
         ACFramework.ACUtilitarios.ImprimeLinBlanco(m_cabecera, 6)
         Dim _cab As New List(Of String)
         _cab.Add(String.Format("{0}{1}{2}{3}", Space(m_space + 10), _
                                         m_docventa.DOCVE_DescripcionCliente.PadRight(43, " ").Substring(0, 43), _
                                         m_docventa.ENTID_NroDocumento.PadRight(15, " "), _
                                         m_docventa.Documento))
         _cab.Add(String.Format("{0}{1}{2}", Space(m_space + 10), _
                                         m_docventa.DOCVE_DireccionCliente.PadRight(68, " ").Substring(0, 68), _
                                         m_docventa.DOCVE_FechaDocumento.ToString(Parametros.GetParametro(EParametros.TipoParametros.pg_FormatoFecha)).PadRight(10, " ")))
         ACUtilitarios.genTexto(_cab, m_cabecera)
         ACFramework.ACUtilitarios.ImprimeLinBlanco(m_cabecera, 2)
         '' Generar Detalle
         Dim x_fila As Integer = 0
         Dim x_peso As Decimal = 0
         For Each item As EVENT_DocsVentaDetalle In m_docventa.ListVENT_DocsVentaDetalle
            x_peso += item.DOCVD_PesoUnitario * item.DOCVD_Cantidad
            Dim x_lista As New List(Of String)
            If IsNothing(item.ARTIC_Descripcion) Then item.ARTIC_Descripcion = ""
            If ACUtilitarios.GetTextoLines(item.ARTIC_Descripcion, 50, x_lista) > 0 Then
               m_cuerpo.Append(String.Format("{0}{1}{2}{3}{4}{5}{6}", Space(m_space) _
                                                   , ACUtilitarios.Alinear(ACAlineacion.Derecha, item.DOCVD_Cantidad.ToString("###,##0.00"), 9) _
                                                   , ACUtilitarios.Alinear(ACAlineacion.Centro, item.DOCVD_Unidad, 12) _
                                                   , x_lista(0).PadRight(75, " ").Substring(0, 45) _
                                                   , ACUtilitarios.Alinear(ACAlineacion.Derecha, item.DOCVD_PrecioUnitario.ToString("###,##0.00"), 14) _
                                                   , ACUtilitarios.Alinear(ACAlineacion.Derecha, item.DOCVD_SubImporteVenta.ToString("###,##0.00"), 15) _
                                                   , vbNewLine))
               If x_lista.Count > 1 Then
                  Dim j As Integer
                  For j = 1 To x_lista.Count - 1
                     m_cuerpo.Append(String.Format("{0}{1}{2}", Space(m_space + 28), x_lista(j).Trim(), vbNewLine))
                  Next
               End If
               x_fila += x_lista.Count
            Else
               x_fila += 1
               m_cuerpo.Append(String.Format("{0}{1}{2}{3}{4}{5}", Space(m_space) _
                                                   , ACUtilitarios.Alinear(ACAlineacion.Derecha, item.DOCVD_Cantidad.ToString("###,##0.0000"), 9) _
                                                   , ACUtilitarios.Alinear(ACAlineacion.Centro, item.DOCVD_Unidad, 12) _
                                                   , "" _
                                                   , ACUtilitarios.Alinear(ACAlineacion.Derecha, item.DOCVD_PrecioUnitario.ToString("###,##0.0000"), 14) _
                                                   , ACUtilitarios.Alinear(ACAlineacion.Derecha, item.DOCVD_SubImporteVenta.ToString("###,##0.0000"), 15) _
                                                   ))
            End If

         Next
         ACUtilitarios.ImprimeLinBlanco(m_cuerpo, x_filas - x_fila)

         '' Generar Pie de Pagina
         Dim _pie As New List(Of String)
         _pie.Add(String.Format(""))
         Dim _filter As New ACFiltrador(Of ETipos)
         _filter.ACFiltro = String.Format("TIPOS_Codigo={0}", m_docventa.TIPOS_CodTipoMoneda)
         _filter.ACFiltrar(Colecciones.Tipos)
         Dim _simb = "S/."
         If _filter.ACListaFiltrada.Count > 0 Then
            _simb = _filter.ACListaFiltrada(0).TIPOS_DescCorta
            _pie.Add(String.Format("{0}{1}{2}", Space(m_space + 5), ACUtilitarios.NumPalabra(m_docventa.DOCVE_TotalPagar, _filter.ACListaFiltrada(0).TIPOS_Descripcion).PadRight(80, " ").Substring(0, 80), _
                                   (_simb & " " & m_docventa.DOCVE_TotalPagar.ToString(Parametros.GetParametro(EParametros.TipoParametros.pg_FMondo2d)))).ToString().PadLeft(18, " "))
         Else
            _pie.Add(String.Format("{0}{1}{2}", Space(m_space + 5), ACUtilitarios.NumPalabra(m_docventa.DOCVE_TotalPagar, "NUEVOS SOLES").PadRight(80, " ").Substring(0, 80), _
                                   (_simb & " " & m_docventa.DOCVE_TotalPagar.ToString(Parametros.GetParametro(EParametros.TipoParametros.pg_FMondo2d)))).ToString().PadLeft(18, " "))
         End If

         _pie.Add(String.Format(""))
         _pie.Add(String.Format(""))
         _pie.Add(String.Format("{0} {1} {2} {3} {4}", Space(m_space + 3) _
                                    , (" " & x_peso.ToString(Parametros.GetParametro(EParametros.TipoParametros.pg_FMondo4d))).ToString().PadLeft(15, " ").Substring(0, 15) _
                                    , (" " & DateTime.Now.ToString("hh:mm tt")).PadRight(20, " ").Substring(0, 20) _
                                    , (" " & GApp.EUsuario.USER_CodUsr.PadRight(12, " ").Substring(0, 12)) _
                                    , (" " & m_docventa.ENTID_Vendedor).ToString().PadLeft(20, " ").Substring(0, 20)))

         _pie.Add(String.Format(""))
         _pie.Add(String.Format(""))

         ACUtilitarios.genTexto(_pie, m_pie)

         '' Generar Documento Final
         m_cabecera.Append(m_cuerpo)
         m_cabecera.Append(m_pie)

         '' Imprimir
         ACFramework.ACUtilitarios.ImprimeLinBlanco(m_cabecera, 3)

         ACImpresion.ACImprimir.Inicializar(m_printername)
         ACImpresion.ACImprimir.SendStringToPrinter(Chr(18))
         ACImpresion.ACImprimir.SendStringToPrinter(ACFuncImpresion.NumeroLineas(68))
         ACImpresion.ACImprimir.SendStringToPrinter(ACFuncImpresion.Fuente(ACFuentes.Draft))
         ACImpresion.ACImprimir.SendStringToPrinter(String.Format("{0}{1}", Chr(27), Chr(15)))
         ACImpresion.ACImprimir.SendStringToPrinter(ACFuncImpresion.FuenteDraft(ACDrafts.Draft10PCI))
         ACImpresion.ACImprimir.SendStringToPrinter(ACFuncImpresion.Condensado(False))
         ACImpresion.ACImprimir.SendStringToPrinter(ACFuncImpresion.Interespaciado(ACInterEspaciado.Ocho))
         ACImprimir.SendStringToPrinter(m_cabecera.ToString())

         Return True
      Catch ex As Exception
         Throw ex
      End Try
   End Function

   Private Function ImprimirB016AcerosV2(ByVal m_docventa As EVENT_DocsVenta, ByVal x_filas As Integer) As Boolean
      Dim m_texto As String = ""
      Dim m_space As Integer = 0
      Dim m_cabecera As New StringBuilder
      Dim m_cuerpo As New StringBuilder
      Dim m_pie As New StringBuilder
      Try
         '' Generar Cabecera
         ACFramework.ACUtilitarios.ImprimeLinBlanco(m_cabecera, 6)
         Dim _cab As New List(Of String)
         If IsNothing(m_docventa.DOCVE_DescripcionCliente) Then m_docventa.DOCVE_DescripcionCliente = ""
         If IsNothing(m_docventa.DOCVE_DireccionCliente) Then m_docventa.DOCVE_DireccionCliente = ""
         _cab.Add(String.Format("{0}{1}{2}{3}", Space(m_space + 10), _
                                         m_docventa.DOCVE_DescripcionCliente.PadRight(43, " ").Substring(0, 43), _
                                         m_docventa.ENTID_NroDocumento.PadRight(15, " "), _
                                         m_docventa.Documento))
         _cab.Add(String.Format("{0}{1}{2}", Space(m_space + 10), _
                                         m_docventa.DOCVE_DireccionCliente.PadRight(68, " ").Substring(0, 68), _
                                         m_docventa.DOCVE_FechaDocumento.ToString(Parametros.GetParametro(EParametros.TipoParametros.pg_FormatoFecha)).PadRight(10, " ")))
         ACUtilitarios.genTexto(_cab, m_cabecera)
         ACFramework.ACUtilitarios.ImprimeLinBlanco(m_cabecera, 2)
         SetPrinter(m_cabecera, ACInterEspaciado.Ocho)
         '' Generar Detalle
         Dim x_fila As Integer = 0
         Dim x_peso As Decimal = 0
         For Each item As EVENT_DocsVentaDetalle In m_docventa.ListVENT_DocsVentaDetalle
            x_peso += item.DOCVD_PesoUnitario * item.DOCVD_Cantidad
            Dim x_lista As New List(Of String)
            If IsNothing(item.ARTIC_Descripcion) Then item.ARTIC_Descripcion = ""
            If ACUtilitarios.GetTextoLines(item.ARTIC_Descripcion, 50, x_lista) > 0 Then
               m_cuerpo.Append(String.Format("{0}{1}{2}{3}{4}{5}{6}", Space(m_space) _
                                                   , ACUtilitarios.Alinear(ACAlineacion.Derecha, item.DOCVD_Cantidad.ToString("###,##0.00"), 9) _
                                                   , ACUtilitarios.Alinear(ACAlineacion.Centro, item.DOCVD_Unidad, 12) _
                                                   , x_lista(0).PadRight(75, " ").Substring(0, 45) _
                                                   , ACUtilitarios.Alinear(ACAlineacion.Derecha, item.DOCVD_PrecioUnitario.ToString("###,##0.00"), 14) _
                                                   , ACUtilitarios.Alinear(ACAlineacion.Derecha, item.DOCVD_SubImporteVenta.ToString("###,##0.00"), 15) _
                                                   , vbNewLine))
               'If x_lista.Count > 1 Then
               '   Dim j As Integer
               '   For j = 1 To x_lista.Count - 1
               '      m_cuerpo.Append(String.Format("{0}{1}{2}", Space(m_space + 28), x_lista(j).Trim(), vbNewLine))
               '   Next
               'End If
               'x_fila += x_lista.Count
            Else
               x_fila += 1
               m_cuerpo.Append(String.Format("{0}{1}{2}{3}{4}{5}", Space(m_space) _
                                                   , ACUtilitarios.Alinear(ACAlineacion.Derecha, item.DOCVD_Cantidad.ToString("###,##0.0000"), 9) _
                                                   , ACUtilitarios.Alinear(ACAlineacion.Centro, item.DOCVD_Unidad, 12) _
                                                   , "" _
                                                   , ACUtilitarios.Alinear(ACAlineacion.Derecha, item.DOCVD_PrecioUnitario.ToString("###,##0.0000"), 14) _
                                                   , ACUtilitarios.Alinear(ACAlineacion.Derecha, item.DOCVD_SubImporteVenta.ToString("###,##0.0000"), 15) _
                                                   ))
            End If

         Next
         ACUtilitarios.ImprimeLinBlanco(m_cuerpo, x_filas - x_fila)
         SetPrinter(m_cuerpo, ACInterEspaciado.Seis)

         '' Generar Pie de Pagina
         Dim _pie As New List(Of String)
         _pie.Add(String.Format(""))
         Dim _filter As New ACFiltrador(Of ETipos)
         _filter.ACFiltro = String.Format("TIPOS_Codigo={0}", m_docventa.TIPOS_CodTipoMoneda)
         _filter.ACFiltrar(Colecciones.Tipos)
         Dim _simb = "S/."
         If _filter.ACListaFiltrada.Count > 0 Then
            _simb = _filter.ACListaFiltrada(0).TIPOS_DescCorta
            _pie.Add(String.Format("{0}{1}{2}", Space(m_space + 5), ACUtilitarios.NumPalabra(m_docventa.DOCVE_TotalPagar, _filter.ACListaFiltrada(0).TIPOS_Descripcion).PadRight(80, " ").Substring(0, 80), _
                                   (_simb & " " & m_docventa.DOCVE_TotalPagar.ToString(Parametros.GetParametro(EParametros.TipoParametros.pg_FMondo2d)))).ToString().PadLeft(18, " "))
         Else
            _pie.Add(String.Format("{0}{1}{2}", Space(m_space + 5), ACUtilitarios.NumPalabra(m_docventa.DOCVE_TotalPagar, "NUEVOS SOLES").PadRight(80, " ").Substring(0, 80), _
                                   (_simb & " " & m_docventa.DOCVE_TotalPagar.ToString(Parametros.GetParametro(EParametros.TipoParametros.pg_FMondo2d)))).ToString().PadLeft(18, " "))
         End If

         _pie.Add(String.Format(""))
         _pie.Add(String.Format(""))
         _pie.Add(String.Format("{0} {1} {2} {3} {4}", Space(m_space + 3) _
                                    , (" " & x_peso.ToString(Parametros.GetParametro(EParametros.TipoParametros.pg_FMondo4d))).ToString().PadLeft(15, " ").Substring(0, 15) _
                                    , (" " & DateTime.Now.ToString("hh:mm tt")).PadRight(20, " ").Substring(0, 20) _
                                    , (" " & GApp.EUsuario.USER_CodUsr.PadRight(12, " ").Substring(0, 12)) _
                                    , (" " & m_docventa.ENTID_Vendedor).ToString().PadLeft(20, " ").Substring(0, 20)))

         _pie.Add(String.Format(""))
         _pie.Add(String.Format(""))

         ACUtilitarios.genTexto(_pie, m_pie)

         '' Imprimir
         ACFramework.ACUtilitarios.ImprimeLinBlanco(m_pie, 3)
         SetPrinter(m_pie, ACInterEspaciado.Ocho)

         '         SetPrinter(m_cabecera, ACInterEspaciado.Seis)

         Return True
      Catch ex As Exception
         Throw ex
      End Try
   End Function

   Private Sub SetPrinter(ByVal x_file As StringBuilder, ByVal x_interlineado As ACInterEspaciado)
      Try
         ACImpresion.ACImprimir.Inicializar(m_printername)
         ACImpresion.ACImprimir.SendStringToPrinter(Chr(18))
         ACImpresion.ACImprimir.SendStringToPrinter(ACFuncImpresion.NumeroLineas(68))
         ACImpresion.ACImprimir.SendStringToPrinter(ACFuncImpresion.Fuente(ACFuentes.Draft))
         ACImpresion.ACImprimir.SendStringToPrinter(String.Format("{0}{1}", Chr(27), Chr(15)))
         ACImpresion.ACImprimir.SendStringToPrinter(ACFuncImpresion.FuenteDraft(ACDrafts.Draft10PCI))
         ACImpresion.ACImprimir.SendStringToPrinter(ACFuncImpresion.Condensado(False))
         ACImpresion.ACImprimir.SendStringToPrinter(ACFuncImpresion.Interespaciado(x_interlineado))
         ACImprimir.SendStringToPrinter(x_file.ToString())
      Catch ex As Exception
         Throw ex
      End Try
   End Sub
#End Region
#End Region

#Region " Obtener Datos "
   Private Function Get_Facturas(ByRef m_docsventa As ACEVentas.EVENT_DocsVenta, ByVal x_docve_codigo As String, ByVal m_puntoventa As String) As Boolean
      Try
         Dim m_bGenerarDocs As New BGenerarDocsVenta(m_puntoventa, GApp.Periodo, GApp.Zona, GApp.Sucursal)
         If m_bGenerarDocs.getDocsVentaVentas(x_docve_codigo) Then
            m_docsventa = m_bGenerarDocs.VENT_DocsVenta
            Return True
         End If
         Return False
      Catch ex As Exception
         Throw ex
      End Try
   End Function

#End Region

#End Region

#Region " Metodos de Controles"

#End Region
End Class
