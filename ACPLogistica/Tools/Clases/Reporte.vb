Imports ACBLogistica
Imports ACELogistica

Imports CrystalDecisions

Imports Microsoft.VisualBasic.PowerPacks.Printing.Compatibility.VB6
Imports CrystalDecisions.CrystalReports.Engine

Public Class Reporte
#Region " Variables "
    Private m_reporte As BReporte


#End Region


    Enum TReportePendienteCompras
        PendienteOrdenesCompra
        PendienteDocsCompra

    End Enum

#Region " Propiedades "

#End Region

#Region " Constructores "
   Public Sub New()
      Try
         m_reporte = New BReporte(GApp.Almacen, GApp.Periodo, GApp.Sucursal)
      Catch ex As Exception
         Throw ex
      End Try
   End Sub
#End Region

#Region " Metodos "
#Region " Kardex "
   Public Function RKardexXArticulo(ByRef x_data As DataTable, ByVal x_fecini As Date, ByVal x_fecfin As Date, ByVal x_articulo As String, ByVal x_imprimir As Boolean)
      Try
         Dim m_Path_Plantillas As String = System.IO.Path.Combine(Application.StartupPath, "Plantillas")
         Dim strReportName As String = "CRKardexXArticulo.rpt"
         Dim strReportPath As String = System.IO.Path.Combine(m_Path_Plantillas, strReportName)
         m_reporte.DTTabla = x_data
         If x_imprimir Then

         Else ' Ver
            VisualizarCC(strReportPath, x_fecini, x_fecfin, x_articulo)
            Return True
         End If

         Return False
      Catch ex As Exception
         Throw ex
      End Try
   End Function

   Public Function RKardexXArticulo(x_artic_codigo As String, ByVal x_fecini As Date, ByVal x_fecfin As Date, ByVal x_articulo As String, ByVal x_imprimir As Boolean)
      Try
         Dim m_Path_Plantillas As String = System.IO.Path.Combine(Application.StartupPath, "Plantillas")
         Dim strReportName As String = "CRKardexXArticulo.rpt"
         Dim strReportPath As String = System.IO.Path.Combine(m_Path_Plantillas, strReportName)
         If m_reporte.KardexXArticulo(x_artic_codigo, GApp.Almacen, GApp.Periodo, GApp.Zona, x_fecini, x_fecfin) Then
            If x_imprimir Then

            Else ' Ver
               VisualizarCC(strReportPath, x_fecini, x_fecfin, x_articulo)
               Return True
            End If
         End If
         Return False
      Catch ex As Exception
         Throw ex
      End Try
   End Function

   Public Function VisualizarCC(ByVal strReportPath As String, ByVal x_fecini As Date, ByVal x_fecfin As Date, ByVal x_articulo As String) As Boolean
      Try
         Dim _dsdatos As New DSKardexXArticulo()
         getDatosKxA(_dsdatos, x_fecini, x_fecfin, x_articulo)

         Dim Informe As New ReportDocument
         Informe.Load(strReportPath)
         Informe.SetDataSource(_dsdatos)

         Dim _reporte As New RReportView(Informe) With {.StartPosition = FormStartPosition.CenterScreen}
         _reporte.Text = String.Format("Kardex de {2}: del {0:dd/MM/yyyy} Al {1:dd/MM/yyyy}", x_fecini, x_fecfin, x_articulo)
         _reporte.Show()

         'Informe.Close()
         Return True
      Catch ex As Exception
         Throw ex
      End Try
   End Function

   Private Function getDatosKxA(ByRef _dsdatos As DSKardexXArticulo, _
                            ByVal x_fecini As Date, ByVal x_fecfin As Date, ByVal x_articulo As String)
      Try
         Dim _dr As DataRow = _dsdatos.DTCabecera.NewRow()
         _dr("Codigo") = "0"
         _dr("FecIni") = x_fecini.ToString(Parametros.GetParametro(ACEVentas.EParametros.TipoParametros.pg_FormatoFecha))
         _dr("FecFin") = x_fecfin.ToString(Parametros.GetParametro(ACEVentas.EParametros.TipoParametros.pg_FormatoFecha))
         _dr("Almacen") = GApp.EAlmacen.ALMAC_Descripcion
         _dr("Empresa") = GApp.EEmpresa.EMPR_Desc
         _dr("RUC") = GApp.EEmpresa.EMPR_RUC
         _dr("Articulo") = x_articulo
         _dsdatos.DTCabecera.Rows.Add(_dr)

         For Each item As DataRow In m_reporte.DTTabla.Rows
            Dim x_dr As DataRow = _dsdatos.DTDetalle.NewRow()
            x_dr("Codigo") = "0"
            x_dr("Movimiento") = item("Movimiento")
            x_dr("Fecha") = CType(item("DOCVE_FechaDocumento"), DateTime).ToString(Parametros.GetParametro(ACEVentas.EParametros.TipoParametros.pg_FormatoFecha))
            x_dr("Descripcion") = item("DOCVE_DescripcionCliente")
            x_dr("Ingreso") = CType(item("Ingreso"), Decimal).ToString(Parametros.GetParametro(ACEVentas.EParametros.TipoParametros.pg_FMondo2d))
            x_dr("Salida") = CType(item("Salida"), Decimal).ToString(Parametros.GetParametro(ACEVentas.EParametros.TipoParametros.pg_FMondo2d))
            x_dr("Stock") = CType(item("Stock"), Decimal).ToString(Parametros.GetParametro(ACEVentas.EParametros.TipoParametros.pg_FMondo3d))
            x_dr("Documento") = item("Documento")
            x_dr("STOCK_Id") = item("STOCK_Id")

            _dsdatos.DTDetalle.Rows.Add(x_dr)
         Next
         Return True
      Catch ex As Exception
         Throw ex
      End Try
   End Function
#End Region

#Region " Ajustes de Inventario "
   Public Function RArreglo(ByVal x_arre_codigo As String, ByVal x_imprimir As Boolean)
      Try
         Dim m_Path_Plantillas As String = System.IO.Path.Combine(Application.StartupPath, "Plantillas")
         Dim strReportName As String = "CRAjustes.rpt"
         Dim strReportPath As String = System.IO.Path.Combine(m_Path_Plantillas, strReportName)
         If m_reporte.REPOSS_ObtenerArreglo(x_arre_codigo, GApp.Almacen) Then
            If x_imprimir Then

            Else ' Ver
               VisualizarArreglo(strReportPath, x_arre_codigo)
               Return True
            End If
         End If
         Return False
      Catch ex As Exception
         Throw ex
      End Try
   End Function

   Public Function VisualizarArreglo(ByVal strReportPath As String, ByVal x_arre_codigo As String) As Boolean
      Try
         Dim _dsdatos As New DSArreglos()
         getDatosArreglo(_dsdatos, x_arre_codigo)

         Dim Informe As New ReportDocument
         Informe.Load(strReportPath)
         Informe.SetDataSource(_dsdatos)

         Dim _reporte As New RReportView(Informe) With {.StartPosition = FormStartPosition.CenterScreen}
         _reporte.Text = String.Format("Arreglo : {0}", x_arre_codigo)
         _reporte.Show()

         'Informe.Close()
         Return True
      Catch ex As Exception
         Throw ex
      End Try
   End Function

   Private Function getDatosArreglo(ByRef _dsdatos As DSArreglos, ByVal x_arre_codigo As String)
      Try
         Dim _dr As DataRow = _dsdatos.CTRL_Arreglos.NewRow()
         _dr("ARREG_Codigo") = m_reporte.CTRL_Arreglos.ARREG_Codigo
         _dr("ARREG_Fecha") = m_reporte.CTRL_Arreglos.ARREG_Fecha.ToString(Parametros.GetParametro(ACEVentas.EParametros.TipoParametros.pg_FormatoFecha))
         _dr("ARREG_FechaIngreso") = m_reporte.CTRL_Arreglos.ARREG_FechaIngreso.ToString(Parametros.GetParametro(ACEVentas.EParametros.TipoParametros.pg_FormatoFecha))
         _dr("ARREG_Observaciones") = m_reporte.CTRL_Arreglos.ARREG_Observaciones
         _dr("TIPOS_TipoArreglo") = m_reporte.CTRL_Arreglos.TIPOS_TipoArreglo
         _dr("Empresa") = GApp.EEmpresa.EMPR_Desc
         _dr("Titulo") = "Arreglo de Kardex"
         _dr("Almacen") = GApp.EAlmacen.ALMAC_Descripcion

         _dr("Creador") = m_reporte.CTRL_Arreglos.UsuarioCreador
         _dr("RUC") = GApp.EEmpresa.EMPR_RUC
         _dr("Imprime") = GApp.EUsuario.USER_CodUsr
         _dsdatos.CTRL_Arreglos.Rows.Add(_dr)

         For Each item As ECTRL_ArreglosDetalle In m_reporte.CTRL_Arreglos.ListCTRL_ArreglosDetalle
            Dim x_dr As DataRow = _dsdatos.CTRL_ArreglosDetalle.NewRow()
            x_dr("ARREG_Codigo") = m_reporte.CTRL_Arreglos.ARREG_Codigo
            x_dr("ARRDT_Cantidad") = item.ARRDT_Cantidad.ToString(Parametros.GetParametro(ACEVentas.EParametros.TipoParametros.pg_FMondo2d))
            x_dr("ARRDT_Item") = item.ARRDT_Item
            x_dr("ARTIC_Codigo") = item.ARTIC_Codigo
            x_dr("TIPOS_UnidadMedida") = item.TIPOS_UnidadMedida
            x_dr("ARTIC_Descripcion") = item.ARTIC_Descripcion

            _dsdatos.CTRL_ArreglosDetalle.Rows.Add(x_dr)
         Next
         Return True
      Catch ex As Exception
         Throw ex
      End Try
   End Function
#End Region

#Region " Reportes "
   Public Function RDocumentosXCliente(ByVal x_fecini As Date, ByVal x_fecfin As Date, ByVal x_almac_id As Long, ByVal x_entid_codigo As String, ByVal x_fecha As Boolean, ByVal x_cliente As String)
      Try
         Dim m_Path_Plantillas As String = System.IO.Path.Combine(Application.StartupPath, "Plantillas")
         Dim strReportName As String = "CRDocumentosXCliente.rpt"
         Dim strReportPath As String = System.IO.Path.Combine(m_Path_Plantillas, strReportName)
         If m_reporte.CTRL_MostrarDocumentosCliente(x_fecini, x_fecfin, x_almac_id, x_entid_codigo, x_fecha) Then
            VisualizarDocumentoXClienteCC(strReportPath, x_fecini, x_fecfin, x_cliente)
            Return True
         End If
         Return False
      Catch ex As Exception
         Throw ex
      End Try
   End Function

   Public Function VisualizarDocumentoXClienteCC(ByVal strReportPath As String, ByVal x_fecini As Date, ByVal x_fecfin As Date, ByVal x_cliente As String) As Boolean
      Try
         Dim _dsdatos As New DSDocumentosXCliente()
         getDatosDocumentoXCliente(_dsdatos, x_fecini, x_fecfin)

         Dim Informe As New ReportDocument
         Informe.Load(strReportPath)
         Informe.SetDataSource(_dsdatos)

         Dim _reporte As New RReportView(Informe) With {.StartPosition = FormStartPosition.CenterScreen}
         _reporte.Text = String.Format("Documentos por Cliente {2}: del {0:dd/MM/yyyy} Al {1:dd/MM/yyyy}", x_fecini, x_fecfin, x_cliente)
         _reporte.Show()

         'Informe.Close()
         Return True
      Catch ex As Exception
         Throw ex
      End Try
   End Function

   Private Function getDatosDocumentoXCliente(ByRef _dsdatos As DSDocumentosXCliente, ByVal x_fecini As Date, ByVal x_fecfin As Date)
      Try
         Dim _dr As DataRow = _dsdatos.Cabecera.NewRow()
         _dr("Codigo") = 0
         _dr("Empresa") = GApp.EEmpresa.EMPR_Desc
         _dr("Titulo") = "Documentos Por Cliente"
         _dr("PuntoVenta") = GApp.EAlmacen.ALMAC_Descripcion
         _dr("FecIni") = x_fecini.ToString(Parametros.GetParametro(ACEVentas.EParametros.TipoParametros.pg_FormatoFecha))
         _dr("FecFin") = x_fecfin.ToString(Parametros.GetParametro(ACEVentas.EParametros.TipoParametros.pg_FormatoFecha))

         _dsdatos.Cabecera.Rows.Add(_dr)

         For Each item As System.Data.DataRow In m_reporte.DTTabla.Rows
            Dim x_dr As DataRow = _dsdatos.Detalle.NewRow()
            x_dr("Codigo") = 0
            x_dr("DOCVE_Codigo") = item("DOCVE_Codigo").ToString()
            x_dr("Documento") = item("Documento").ToString()
            x_dr("DOCVE_DescripcionCliente") = item("DOCVE_DescripcionCliente").ToString()
            x_dr("DOCVE_FechaDocumento") = CType(item("DOCVE_FechaDocumento"), Date).ToString(Parametros.GetParametro(ACEVentas.EParametros.TipoParametros.pg_FormatoFecha))
            x_dr("DOCVE_TotalPagar") = item("TIPOS_TipoMoneda").ToString() & " " & CType(item("DOCVE_TotalPagar"), Decimal).ToString("#,###,##0.00")
            x_dr("GUIAR_Codigo") = item("GUIAR_Codigo").ToString()
            If Not item("DocGuia") Is DBNull.Value Then
               x_dr("DocGuia") = item("DocGuia").ToString()
               x_dr("TIPOS_MotivoTraslado") = item("TIPOS_MotivoTraslado").ToString()
               x_dr("GUIAR_DireccDestino") = item("GUIAR_DireccDestino").ToString()
               x_dr("GUIAR_DescripcionConductor") = item("GUIAR_DescripcionConductor").ToString()
               x_dr("GUIAR_DescripcionTransportista") = item("GUIAR_DescripcionTransportista").ToString()
               x_dr("GUIAR_DescripcionVehiculo") = item("GUIAR_DescripcionVehiculo").ToString()
               x_dr("GUIAR_FechaEmision") = CType(item("GUIAR_FechaEmision"), Date).ToString(Parametros.GetParametro(ACEVentas.EParametros.TipoParametros.pg_FormatoFecha))
               x_dr("GUIAR_TotalPeso") = CType(item("GUIAR_TotalPeso"), Decimal).ToString("#,###,##0.00")
               _dsdatos.Detalle.Rows.Add(x_dr)
            End If
         Next
         Return True
      Catch ex As Exception
         Throw ex
      End Try
   End Function
#End Region

#Region "Cuadre Pendientes - Compras"
    Public Function RReportePendientesCompras(ByVal x_fecini As Date, ByVal x_fecfin As Date, ByVal x_imprimir As Boolean, ByVal x_treporte As TReportePendienteCompras)
        Try
            Dim _btran As New BReporte(GApp.Almacen, GApp.Periodo, GApp.Sucursal)
            Dim m_Path_Plantillas As String = System.IO.Path.Combine(Application.StartupPath, "Plantillas")
            Dim strReportName As String = "CRDReportePendientesCompras.rpt"
            Dim strReportPath As String = System.IO.Path.Combine(m_Path_Plantillas, strReportName)


            Select Case x_treporte
                Case TReportePendienteCompras.PendienteOrdenesCompra
                    If _btran.LOG_ABAS_CuadrePendientesOrdenesCompra(x_fecini, x_fecfin, GApp.Almacen, , ) Then
                        Return VisualizarCPCompras(_btran, strReportPath, x_fecini, x_fecfin, x_treporte, False)
                    End If
                Case TReportePendienteCompras.PendienteDocsCompra
                    If _btran.LOG_ABAS_CuadrePendientesDocsCompras(x_fecini, x_fecfin, GApp.Almacen, , ) Then
                        Return VisualizarCPCompras(_btran, strReportPath, x_fecini, x_fecfin, x_treporte, False)
                    End If
                
            End Select
            Return False
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function VisualizarCPCompras(ByRef m_reporte As BReporte, ByVal strReportPath As String, _
                          ByVal x_fecini As Date, ByVal x_fecfin As Date, ByVal x_treporte As TReportePendienteCompras, ByVal x_fecha As Boolean) As Boolean
        Try
            Dim _dsdatos As New DSDReportePendientesCompras()
            getDatosCPCompras(m_reporte, _dsdatos, x_fecini, x_fecfin, x_treporte, x_fecha)

            Dim Informe As New ReportDocument
            Informe.Load(strReportPath)
            Informe.SetDataSource(_dsdatos)


            Dim reporte As New RReportView(Informe) With {.StartPosition = FormStartPosition.CenterScreen}
            reporte.Text = String.Format("Reporte de Pendientes - Compras: del {0:dd/MM/yyyy} Al {1:dd/MM/yyyy}", x_fecini, x_fecfin)
            reporte.Show()

            'Informe.Close()
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Private Function getDatosCPCompras(ByVal m_reporte As BReporte, ByRef _dsdatos As DSDReportePendientesCompras, _
                              ByVal x_fecini As Date, ByVal x_fecfin As Date, ByVal x_treporte As TReportePendienteCompras, ByVal x_fecha As Boolean)
        Try
            Dim _dr As DataRow = _dsdatos.Cabecera.NewRow()
            _dr("Codigo") = "0"
            If x_fecha Then
                _dr("FecIni") = " - "
                _dr("FecFin") = " - "
            Else
                _dr("FecIni") = x_fecini.ToString(Parametros.GetParametro(ACEVentas.EParametros.TipoParametros.pg_FormatoFecha))
                _dr("FecFin") = x_fecfin.ToString(Parametros.GetParametro(ACEVentas.EParametros.TipoParametros.pg_FormatoFecha))
            End If

            _dr("Almacen") = GApp.EAlmacen.ALMAC_Descripcion
            _dr("Empresa") = GApp.EEmpresa.EMPR_Desc
            _dr("RUC") = GApp.EEmpresa.EMPR_RUC
            Select Case x_treporte
                Case TReportePendienteCompras.PendienteOrdenesCompra
                    _dr("Titulo") = String.Format("CUADRE DE PENDIENTES - {0}", "ORDENES DE COMPRA")
                Case TReportePendienteCompras.PendienteDocsCompra
                    _dr("Titulo") = String.Format("CUADRE DE PENDIENTES - {0}", "DOCS DE COMPRA")
            End Select


            _dsdatos.Cabecera.Rows.Add(_dr)


            For Each item As EABAS_DocsCompraDetalle In m_reporte.ListABAS_DocsCompraDetalle
                Dim x_dr As DataRow = _dsdatos.Detalle.NewRow()
                x_dr("Codigo") = "0"
                x_dr("DOCCO_Codigo") = item.DOCCO_Codigo
                x_dr("Documento") = item.Documento
                x_dr("DOCCO_FechaDocumento") = item.DOCCO_FechaDocumento.ToString(Parametros.GetParametro(ACEVentas.EParametros.TipoParametros.pg_FormatoFecha))
                x_dr("ENTID_CodigoProveedor") = item.ENTID_CodigoProveedor
                x_dr("DOCCO_DescripcionProveedor") = item.DOCCO_DescripcionProveedor
                x_dr("DOCCD_Item") = item.DOCCD_Item
                x_dr("ARTIC_Detalle") = item.ARTIC_Detalle
                x_dr("ARTIC_Codigo") = item.ARTIC_Codigo
                x_dr("ARTIC_Peso") = item.DOCCD_PesoUnitario * item.DOCCD_Cantidad
                x_dr("DOCCD_Cantidad") = item.DOCCD_Cantidad.ToString(Parametros.GetParametro(ACEVentas.EParametros.TipoParametros.pg_FMondo2d))
                x_dr("Saldo") = item.Saldo.ToString(Parametros.GetParametro(ACEVentas.EParametros.TipoParametros.pg_FMondo2d))
                x_dr("SaldoPendiente") = item.Saldo
                ' x_dr("EstadoEntregaOR") = item.ORDEN_EstEntrega
                If (item.DOCCO_Estado = "I") Then
                    x_dr("DOCCO_Estado") = "Ingresado"
                Else
                    x_dr("DOCCO_Estado") = "Confirmado"
                End If


                _dsdatos.Detalle.Rows.Add(x_dr)
            Next
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function
#End Region
#End Region

#Region " Metodos de Controles"

#End Region
End Class
