Imports ACBLogistica
Imports DAConexion
Imports ACEVentas
Imports ACBVentas
Imports ACELogistica
Imports ACFramework
Imports ACSeguridad
Imports C1.Win.C1FlexGrid

Public Class RVentasB
#Region " Variables "
    'Declare Auto Function FindWindow Lib "USER32.DLL" (ByVal LpClassName As String,ByVal LpWindowName As String)as IntPtr
    'Declare Auto Function SendMessageA Lib "user32.DLL" (ByVal hWnd As IntPtr,ByVal wMsg As Int32, ByVal wParam As Int32,
    '                                                     ByVal lParam As String)as Int32
    Private Const WM_CLOSE = &H10
    Dim estado as String
    Dim x_codigo As String 
       Private bs_letras As BindingSource
    Private m_timer As System.Windows.Forms.Timer
    Dim list As  ArrayList
    Private bs_pv As BindingSource
    Private bs_ventas As BindingSource
    Private bs_ordenes as BindingSource
    Private bs_guias As BindingSource
    Private bs_notas As BindingSource
    Private bs_pagos As BindingSource
    Private bs_doctrasaladodetalle As BindingSource
    Private m_order As Integer = 1
    Private managerEntidades As BEntidades
    Private bs_reporte As BindingSource
    Private gt As EDIST_GuiasTodas
    Public columna as Integer    
    Private bs_series As BindingSource
    Private bs_tipodocumento As BindingSource
    Private m_listBindHelper As List(Of ACBindHelper)
    Private frmCons As CProductos
    Private m_earticulos As EArticulos
    Private m_reporte As ACBLogistica.BReporte
    Private _generarNotasC as ACBVentas.BGenerarDocsVenta
    Private m_motivoguia As ETipos.MotivoTraslado
    Private m_event_docsventa As ACEVentas.EVENT_DocsVenta
    Private managerConsultaArticulos As BConsultaArticulos
    Private managerVENT_DocsVenta As BVENT_DocsVenta
    Private m_entid_codigo As String
    Private m_artic_descripion As String
    Private m_cargado As Boolean = False

     Private bs_docalmacenentregas As BindingSource
#End Region


#Region " Constructores "
    Public Sub New(ByVal x_icono As System.Drawing.Bitmap)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Try

            'managerConsultaArticulos = New BConsultaArticulos(GApp.Periodo)
            
            m_reporte = New ACBLogistica.BReporte(GApp.Almacen, GApp.Periodo, GApp.Sucursal)
            managerVENT_DocsVenta = New BVENT_DocsVenta(GApp.Periodo, GApp.Zona, GApp.Sucursal)
            


            managerEntidades = New BEntidades
            tabMantenimiento.HideTabsMode = Crownwood.DotNetMagic.Controls.HideTabsModes.HideAlways
            tabMantenimiento.SelectedTab = tabBusGuias

            actxaCliRuc.ACAyuda.Enabled = False
            actxaCliRazonSocial.ACActivarAyudaAuto = False
            actxaCliRuc.Enabled = False
            actxaCliRazonSocial.Enabled = False
            acTool.ACBtnNuevo.Visible = False
            acTool.ACBtnModificar.Visible = False
            actsbtnPrevisualizar.Visible = True
            'formatearGrilla()
            'cargarCombos()

            Dim listDoc As New List(Of ETipos)
            Dim listDocBus As New List(Of ETipos)
            For Each Item As ETipos In Colecciones.TiposDocComprobante()
                listDoc.Add(Item.Clone)
                listDocBus.Add(Item.Clone)
            Next

             bs_tipodocumento = New BindingSource() : bs_tipodocumento.DataSource = listDocBus
           'ACFramework.ACUtilitarios.ACCargaCombo(cmbTipoDocumento, listDoc, "TIPOS_Descripcion", "TIPOS_Codigo")
            ACFramework.ACUtilitarios.ACCargaCombo(cmbMotTraslado, bs_tipodocumento, "TIPOS_Descripcion", "TIPOS_Codigo")
            ACFramework.ACUtilitarios.ACCargaCombo(cmbguia, bs_tipodocumento, "TIPOS_Descripcion", "TIPOS_Codigo")


            If Not IsNothing(x_icono) Then Me.Icon = Icon.FromHandle(x_icono.GetHicon)

            formatearGrillaPV()
            '''puntos de venta
            bs_pv = New BindingSource
            Dim _filter As New ACFramework.ACFiltrador(Of EPuntoVenta)(String.Format("PVENT_Activo=True"))

            Colecciones.GetPuntoVentaxAlmacen(GApp.Almacen)
            bs_pv.DataSource = _filter.ACFiltrar(Colecciones.PuntosVentaxAlmacen)
            c1grdPuntosVentas.DataSource = bs_pv


            If c1grdPuntosVentas.DataSource.Count>1 Then
                GroupBox3.Visible=True
                GroupBox1.Size()= New Size(826,48)
                Else 
                GroupBox3.Visible=False
                GroupBox1.Size()= New Size(1056,48)
                For items = 1 To c1grdPuntosVentas.Rows.Count - 1
                    c1grdPuntosVentas.Rows(1)("Seleccionar") = true'item_tabla("CANT_ItemPendiente")
                Next
            End If



            ACFramework.ACUtilitarios.ACCargaCombo(cmbCondPago, Colecciones.Tipos(ETipos.MyTipos.CondicionPago), "TIPOS_Descripcion", "TIPOS_Codigo")
            ACFramework.ACUtilitarios.ACCargaCombo(cmbMoneda, Colecciones.Tipos(ETipos.MyTipos.TipoMoneda), "TIPOS_Descripcion", "TIPOS_Codigo")

            ACFramework.ACUtilitarios.ACCargaCombo(cmbEntrega, Colecciones.ListEstadoEntrega, ACLista.Descripcion, ACLista.Codigo)

        Catch ex As Exception
            ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), Colecciones.getError("00000"), ex)
        End Try
    End Sub
#End Region

  

Private Sub RVentas_Load( sender As Object,  e As EventArgs) Handles MyBase.Load
        'tbcDetalles.TabPages.Remove(tpgAdmin)
        'tbcDetalles.TabPages.Remove(tpgLetras)
        'tbcDetalles.TabPages.Remove(tpgCheques)
      
         tbcDetalles.SelectedTab = tpgAdicionales
End Sub

Private Sub actxaCliRuc_ACAyudaClick( sender As Object,  e As EventArgs) Handles actxaCliRuc.ACAyudaClick
           Try
            AyudaEntidad(actxaCliRuc.Text, "ENTID_NroDocumento", "Razon Social", 1, EEntidades.TipoEntidad.Clientes)
        Catch ex As Exception
            ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso Documento de Identidad", ex)
        End Try
End Sub
#Region " Metodos "

     Private Sub formatearGrilla()

        Dim index As Integer = 1
        Try

            index = 1

            ACFrameworkC1.ACUtilitarios.ACFormatearGrilla(c1grdDetalle, 1, 1, 10, 1, 0)
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdDetalle, index, "Item", "DOCVD_Item", "DOCVD_Item", 80, True, False, "System.Integer", "#0") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdDetalle, index, "Codigo", "ARTIC_Codigo", "ARTIC_Codigo", 80, True, False, "System.String") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdDetalle, index, "Cantidad", "DOCVD_Cantidad", "DOCVD_Cantidad", 75, True, False, "System.Decimal", Parametros.GetParametro(EParametros.TipoParametros.pg_FMondo2d)) : index += 1                        
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdDetalle, index, "Unidad", "TIPOS_UnidadMedida", "TIPOS_UnidadMedida", 69, True, False, "System.String") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdDetalle, index, "Descripción", "ARTIC_Descripcion", "ARTIC_Descripcion", 191, True, False, "System.String") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdDetalle, index, "Peso Unitario", "DOCVD_PesoUnitario", "DOCVD_PesoUnitario", 75, True, False, "System.Decimal", Parametros.GetParametro(EParametros.TipoParametros.pg_FMondo4d)) : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdDetalle, index, "Peso Total", "SubPeso_", "SubPeso_", 75, True, False, "System.Decimal", Parametros.GetParametro(EParametros.TipoParametros.pg_FMondo4d)) : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdDetalle, index, "Precio", "DOCVD_PrecioUnitario", "DOCVD_PrecioUnitario", 110, True, True, "System.Decimal", Parametros.GetParametro(EParametros.TipoParametros.pg_FMondo2d)) : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdDetalle, index, "Sub-Importe", "DOCVD_SubImporteVenta", "DOCVD_SubImporteVenta", 100, True, True, "System.Decimal", Parametros.GetParametro(EParametros.TipoParametros.pg_FMondo2d)) : index += 1
            
            c1grdDetalle.AllowEditing = True
            c1grdDetalle.AutoResize = True
            c1grdDetalle.AllowResizing = True
            c1grdDetalle.Cols(0).Width = 15
            c1grdDetalle.ExtendLastCol = False
            c1grdDetalle.AllowSorting = AllowSortingEnum.SingleColumn

            c1grdDetalle.Styles.Alternate.BackColor = Color.LightGray
            c1grdDetalle.Styles.Fixed.TextAlign = TextAlignEnum.CenterCenter
            c1grdDetalle.Styles.Highlight.BackColor = Color.Gray
            c1grdDetalle.SelectionMode = SelectionModeEnum.Row
            c1grdDetalle.AllowResizing = AllowResizingEnum.Columns

            Dim tt As C1.Win.C1FlexGrid.CellStyle = c1grdDetalle.Styles.Add("Total")
            tt.BackColor = Color.LightGreen
            tt.ForeColor = Color.DarkBlue
            tt.Font = New Font(c1grdDetalle.Font, FontStyle.Regular)

            Dim uu As C1.Win.C1FlexGrid.CellStyle = c1grdDetalle.Styles.Add("Entregado")
            uu.BackColor = Color.DarkSlateBlue
            uu.ForeColor = Color.White
            uu.Font = New Font(c1grdDetalle.Font, FontStyle.Regular)

            Dim dd As C1.Win.C1FlexGrid.CellStyle = c1grdDetalle.Styles.Add("GUIRD_Cantidad")
            dd.BackColor = Color.Green
            dd.ForeColor = Color.White
            dd.Font = New Font(c1grdDetalle.Font, FontStyle.Bold)
            c1grdDetalle.DrawMode = C1.Win.C1FlexGrid.DrawModeEnum.OwnerDraw

            Dim ddd As C1.Win.C1FlexGrid.CellStyle = c1grdDetalle.Styles.Add("Anulado")
            ddd.BackColor = Color.Maroon
            ddd.ForeColor = Color.White
            ddd.Font = New Font(c1grdDetalle.Font, FontStyle.Bold)
            c1grdDetalle.DrawMode = C1.Win.C1FlexGrid.DrawModeEnum.OwnerDraw


            index = 1
            ACFrameworkC1.ACUtilitarios.ACFormatearGrilla(c1grdReporte, 1, 1, 14, 1, 0)
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdReporte, index, "Fec. Doc", "DOCVE_FechaDocumento", "DOCVE_FechaDocumento", 90, True, False, "System.DateTime", Parametros.GetParametro(EParametros.TipoParametros.pg_FormatoFecha)) : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdReporte, index, "Documento", "Documento", "Documento", 90, True, False, "System.String") : index += 1            
            ''ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdReporte, index, "Tipo Doc.", "TIPOS_TipoDocumento", "TIPOS_TipoDocumento", 100, True, False, "System.String") : index += 1            
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdReporte, index, "Raz. Social", "DOCVE_DescripcionCliente", "DOCVE_DescripcionCliente", 150, True, False, "System.String") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdReporte, index, "R.U.C. / D.N.I.", "ENTID_CodigoCliente", "ENTID_CodigoCliente", 90, True, False, "System.String") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdReporte, index, "Doc. Cotizacion", "PEDID_Codigo", "PEDID_Codigo", 90, True, False, "System.String") : index += 1            
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdReporte, index, "Cotizador", "ENTID_Cotizador", "ENTID_Cotizador", 150, True, False, "System.String") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdReporte, index, "Estado", "DOCVE_Estado", "DOCVE_Estado", 90, True, False, "System.String") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdReporte, index, "Condicion ", "VENTAS_Condicion", "VENTAS_Condicion", 90, True, False, "System.String") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdReporte, index, "Tipo Despacho", "DOCVE_EstEntrega", "DOCVE_EstEntrega", 90, True, False, "System.String") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdReporte, index, "Total Peso", "DOCVE_TotalPeso", "DOCVE_TotalPeso", 70, True, False, "System.Decimal", Parametros.GetParametro(ACEVentas.EParametros.TipoParametros.pg_FMondo2d)) : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdReporte, index, "DOCVE_CODIGO", "DOCVE_Codigo", "DOCVE_Codigo", 90, false, False, "System.String") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdReporte, index, "Revisión Control", "VENTAS_RevisadoControl", "VENTAS_RevisadoControl", 150, True, False, "System.Boolean") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdReporte, index, "Revisión Usuario", "VENTAS_RevisadoUsr", "VENTAS_RevisadoUsr", 150, True, False, "System.String") : index += 1
            c1grdReporte.AllowEditing = False
            c1grdReporte.Styles.Alternate.BackColor = Color.LightGray
            c1grdReporte.Styles.Fixed.TextAlign = TextAlignEnum.CenterCenter
            c1grdReporte.Styles.Highlight.BackColor = Color.Gray
            c1grdReporte.SelectionMode = SelectionModeEnum.Row
            c1grdReporte.AllowSorting = AllowSortingEnum.SingleColumn


            Dim s As CellStyle = c1grdReporte.Styles(CellStyleEnum.Subtotal0)
            s.BackColor = Color.Black
            s.ForeColor = Color.White
            s.Font = New Font(c1grdReporte.Font, FontStyle.Bold)

            s = c1grdReporte.Styles(CellStyleEnum.Subtotal1)
            s.BackColor = Color.DarkBlue
            s.ForeColor = Color.White
            s = c1grdReporte.Styles(CellStyleEnum.Subtotal2)
            s.BackColor = Color.DarkRed
            s.ForeColor = Color.White

            Dim k1 As C1.Win.C1FlexGrid.CellStyle = c1grdReporte.Styles.Add("Anulado")
            k1.BackColor = Color.Red
            k1.ForeColor = Color.White
            k1.Font = New Font(c1grdReporte.Font, FontStyle.Bold)

            Dim k3 As C1.Win.C1FlexGrid.CellStyle = c1grdReporte.Styles.Add("Confirmado")
            k3.BackColor = Color.Green
            k3.ForeColor = Color.White
            k3.Font = New Font(c1grdReporte.Font, FontStyle.Bold)

            Dim j1 As C1.Win.C1FlexGrid.CellStyle = c1grdReporte.Styles.Add("ISoles")
            j1.BackColor = Color.DarkBlue
            j1.ForeColor = Color.White
            j1.Font = New Font(c1grdReporte.Font, FontStyle.Bold)

            Dim j22 As C1.Win.C1FlexGrid.CellStyle = c1grdReporte.Styles.Add("IDolares")
            j22.BackColor = Color.Blue
            j22.ForeColor = Color.White
            j22.Font = New Font(c1grdReporte.Font, FontStyle.Bold)

            Dim k2 As C1.Win.C1FlexGrid.CellStyle = c1grdReporte.Styles.Add("EDolares")
            k2.BackColor = Color.Red
            k2.ForeColor = Color.White
            k2.Font = New Font(c1grdReporte.Font, FontStyle.Bold)

            c1grdReporte.DrawMode = C1.Win.C1FlexGrid.DrawModeEnum.OwnerDraw

            c1grdReporte.Rows(0).AllowMerging = True
            c1grdReporte.Rows(0).AllowMerging = True
            index = 1
            'ACFrameworkC1.ACUtilitarios.ACFormatearGrilla(c1grdLetras, 1, 1, 8, 1, 0)
            'ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdLetras, index, "Codigo", "DPAGO_Id", "DPAGO_Id", 110, True, False, "System.String", "00000") : index += 1
            'ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdLetras, index, "Fecha", "DPAGO_Fecha", "DPAGO_Fecha", 319, True, True, "System.String", Parametros.GetParametro(EParametros.TipoParametros.pg_FormatoFecha)) : index += 1
            'ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdLetras, index, "Banco", "BANCO_Descripcion", "BANCO_Descripcion", 319, True, True, "System.String") : index += 1
            'ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdLetras, index, "Numero", "DPAGO_Numero", "DPAGO_Numero", 110, True, True, "System.String") : index += 1
            'ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdLetras, index, "Documento", "DocVenta", "DocVenta", 319, True, True, "System.String") : index += 1
            'ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdLetras, index, "Moneda", "TIPOS_TipoMoneda", "TIPOS_TipoMoneda", 110, True, True, "System.String") : index += 1
            'ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdLetras, index, "Importe", "DPAGO_Importe", "DPAGO_Importe", 100, True, True, "System.Decimal", Parametros.GetParametro(EParametros.TipoParametros.pg_FMondo2d)) : index += 1
            'c1grdLetras.AllowEditing = False
            'c1grdLetras.AutoResize = True
            'c1grdLetras.Cols(0).Width = 18
            'c1grdLetras.Styles.Alternate.BackColor = Color.LightGray
            'c1grdLetras.Styles.Fixed.TextAlign = TextAlignEnum.CenterCenter
            'c1grdLetras.Styles.Highlight.BackColor = Color.Gray
            'c1grdLetras.SelectionMode = SelectionModeEnum.Row
            'c1grdLetras.AllowResizing = AllowResizingEnum.None

            index = 1
            ACFrameworkC1.ACUtilitarios.ACFormatearGrilla(c1grdGuiasRemision, 1, 1, 9, 1, 0)
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdGuiasRemision, index, "Fecha Emisión", "GUIAR_FechaEmision", "GUIAR_FechaEmision", 150, True, False, "System.DateTime") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdGuiasRemision, index, "Doc. Guia", "Documento", "Documento", 150, True, False, "System.String") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdGuiasRemision, index, "Punto Venta", "PVENT_Origen", "PVENT_Origen", 150, True, False, "System.String") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdGuiasRemision, index, "Transportista", "GUIAR_DescripcionTransportista", "GUIAR_DescripcionTransportista", 150, True, False, "System.String") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdGuiasRemision, index, "Conductor", "GUIAR_DescripcionConductor", "GUIAR_DescripcionConductor", 150, True, False, "System.String") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdGuiasRemision, index, "Vehiculo", "GUIAR_DescripcionVehiculo", "GUIAR_DescripcionVehiculo", 150, True, False, "System.String") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdGuiasRemision, index, "Total Peso", "GUIAR_TotalPeso", "GUIAR_TotalPeso", 150, True, False, "System.Decimal") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdGuiasRemision, index, "Estado", "GUIAR_Estado", "GUIAR_Estado", 150, False, False, "System.Decimal") : index += 1

            c1grdGuiasRemision.AllowEditing = False
            c1grdGuiasRemision.AllowSorting = AllowSortingEnum.SingleColumn
            c1grdGuiasRemision.Styles.Alternate.BackColor = Color.LightGray
            c1grdGuiasRemision.Styles.Fixed.TextAlign = TextAlignEnum.CenterCenter
            c1grdGuiasRemision.Styles.Highlight.BackColor = Color.Gray
            c1grdGuiasRemision.SelectionMode = SelectionModeEnum.Row
            c1grdGuiasRemision.SubtotalPosition = SubtotalPositionEnum.AboveData
            c1grdGuiasRemision.Tree.Column = 2

            Dim gx As C1.Win.C1FlexGrid.CellStyle = c1grdGuiasRemision.Styles.Add("Anulado")
            gx.BackColor = Color.Red
            gx.ForeColor = Color.White
            gx.Font = New Font(c1grdGuiasRemision.Font, FontStyle.Bold)
            c1grdGuiasRemision.DrawMode = C1.Win.C1FlexGrid.DrawModeEnum.OwnerDraw

            index = 1
            ACFrameworkC1.ACUtilitarios.ACFormatearGrilla(c1grdOrdenes, 1, 1, 7, 1, 0)
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdOrdenes, index, "Fecha Emisión", "ORDEN_FechaIngreso", "ORDEN_FechaIngreso", 150, True, False, "System.DateTime") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdOrdenes, index, "Doc. Orden", "Documento", "Documento", 150, True, False, "System.String") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdOrdenes, index, "Origen", "PVENT_Origen", "PVENT_Origen", 150, True, False, "System.String") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdOrdenes, index, "Destino", "PVENT_Destino", "PVENT_Destino", 150, True, False, "System.String") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdOrdenes, index, "Total Peso", "Peso", "Peso", 150, True, False, "System.Decimal") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdOrdenes, index, "Estado", "ORDEN_Estado", "ORDEN_Estado", 150, False, False, "System.Decimal") : index += 1

            c1grdOrdenes.AllowEditing = False
            c1grdOrdenes.AllowSorting = AllowSortingEnum.SingleColumn
            c1grdOrdenes.Styles.Alternate.BackColor = Color.LightGray
            c1grdOrdenes.Styles.Fixed.TextAlign = TextAlignEnum.CenterCenter
            c1grdOrdenes.Styles.Highlight.BackColor = Color.Gray
            c1grdOrdenes.SelectionMode = SelectionModeEnum.Row
            c1grdOrdenes.SubtotalPosition = SubtotalPositionEnum.AboveData
            c1grdOrdenes.Tree.Column = 2

            Dim ox As C1.Win.C1FlexGrid.CellStyle = c1grdOrdenes.Styles.Add("Anulado")
            ox.BackColor = Color.Red
            ox.ForeColor = Color.White
            ox.Font = New Font(c1grdOrdenes.Font, FontStyle.Bold)
            c1grdOrdenes.DrawMode = C1.Win.C1FlexGrid.DrawModeEnum.OwnerDraw

            index = 1
            ACFrameworkC1.ACUtilitarios.ACFormatearGrilla(c1grdPagos, 1, 1, 12, 1, 0)
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdPagos, index, "Cod. Caja", "CAJA_Id", "CAJA_Id", 80, True, False, "System.Integer", "0000000") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdPagos, index, "Documento", "Documento", "Documento", 80, True, False, "System.Integer", "0000000") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdPagos, index, "Orden Doc.", "CAJA_OrdenDocumento", "CAJA_OrdenDocumento", 90, True, False, "System.Integer") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdPagos, index, "Fecha", "CAJA_Fecha", "CAJA_Fecha", 350, True, False, "System.DateTime", Parametros.GetParametro(EParametros.TipoParametros.pg_FormatoFecha)) : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdPagos, index, "Fecha Proceso", "CAJA_FechaPago", "CAJA_FechaPago", 350, True, False, "System.DateTime", Parametros.GetParametro(EParametros.TipoParametros.pg_FormatoFecha)) : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdPagos, index, "Importe", "CAJA_Importe", "CAJA_Importe", 100, True, False, "System.Decimal", Parametros.GetParametro(ACEVentas.EParametros.TipoParametros.pg_FMondo2d)) : index += 1

            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdPagos, index, "Transacción", "TIPOS_Transaccion", "TIPOS_Transaccion", 80, True, False, "System.String") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdPagos, index, "Moneda", "TIPOS_TipoMoneda", "TIPOS_TipoMoneda", 80, True, False, "System.String") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdPagos, index, "Confirmacion", "Cod_Confirmacion", "Cod_Confirmacion", 90, True, False, "System.String") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdPagos, index, "Glosa", "Glosa", "Glosa", 80, True, False, "System.String") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdPagos, index, "Fecha", "DPAGO_Fecha", "DPAGO_Fecha", 80, True, False, "System.DateTime", Parametros.GetParametro(EParametros.TipoParametros.pg_FormatoFecha)) : index += 1

            c1grdPagos.AllowEditing = False
            c1grdPagos.Styles.Alternate.BackColor = Color.LightGray
            c1grdPagos.Styles.Fixed.TextAlign = TextAlignEnum.CenterCenter
            c1grdPagos.Styles.Highlight.BackColor = Color.Gray
            c1grdPagos.SelectionMode = SelectionModeEnum.Row
            c1grdPagos.AutoResize = True
            c1grdPagos.DrawMode = C1.Win.C1FlexGrid.DrawModeEnum.OwnerDraw

            Dim t2 As C1.Win.C1FlexGrid.CellStyle = c1grdPagos.Styles.Add("Facturado")
            t2.BackColor = Color.LightGreen
            t2.ForeColor = Color.DarkBlue
            t2.Font = New Font(c1grdPagos.Font, FontStyle.Regular)

            Dim u2 As C1.Win.C1FlexGrid.CellStyle = c1grdPagos.Styles.Add("Facturar")
            u2.BackColor = Color.Green
            u2.ForeColor = Color.White
            u2.Font = New Font(c1grdPagos.Font, FontStyle.Regular)

            Dim j2 As C1.Win.C1FlexGrid.CellStyle = c1grdPagos.Styles.Add("Pagar")
            j2.BackColor = Color.DarkBlue
            j2.ForeColor = Color.White
            j2.Font = New Font(c1grdPagos.Font, FontStyle.Bold)

            Dim d3 As C1.Win.C1FlexGrid.CellStyle = c1grdPagos.Styles.Add("Anulado")
            d3.BackColor = Color.Red
            d3.ForeColor = Color.White
            d3.Font = New Font(c1grdPagos.Font, FontStyle.Bold)
            c1grdPagos.DrawMode = C1.Win.C1FlexGrid.DrawModeEnum.OwnerDraw


            index = 1
            ACFrameworkC1.ACUtilitarios.ACFormatearGrilla(c1grdPendientes, 1, 1, 12, 1, 0)
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdPendientes, index, "Item", "GUIRD_ItemDocumento", "GUIRD_ItemDocumento", 80, False, False, "System.Integer", "#0") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdPendientes, index, "Almacen", "ALMAC_Descripcion", "ALMAC_Descripcion", 80, False, False, "System.String") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdPendientes, index, "Codigo", "ARTIC_Codigo", "ARTIC_Codigo", 80, True, False, "System.String") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdPendientes, index, "Descripción", "ARTIC_Descripcion", "ARTIC_Descripcion", 191, True, False, "System.String") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdPendientes, index, "Unidad", "TIPOS_UnidadMedidaCorta", "TIPOS_UnidadMedidaCorta", 69, True, False, "System.String") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdPendientes, index, "Total Doc.", "DOCVD_Cantidad", "DOCVD_Cantidad", 75, True, False, "System.Decimal", Parametros.GetParametro(EParametros.TipoParametros.pg_FMondo2d)) : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdPendientes, index, "Entregado", "Entregado", "Entregado", 75, True, False, "System.Decimal", Parametros.GetParametro(EParametros.TipoParametros.pg_FMondo2d)) : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdPendientes, index, "Diferencia", "Diferencia", "Diferencia", 75, False, False, "System.Decimal", Parametros.GetParametro(EParametros.TipoParametros.pg_FMondo2d)) : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdPendientes, index, "Pendiente", "GUIRD_Cantidad", "GUIRD_Cantidad", 75, True, False, "System.Decimal", Parametros.GetParametro(EParametros.TipoParametros.pg_FMondo2d)) : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdPendientes, index, "Peso", "GUIRD_PesoUnitario", "GUIRD_PesoUnitario", 75, True, False, "System.Decimal", Parametros.GetParametro(EParametros.TipoParametros.pg_FMondo4d)) : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdPendientes, index, "Peso Doc.", "SubPeso", "SubPeso", 75, True, False, "System.Decimal", Parametros.GetParametro(EParametros.TipoParametros.pg_FMondo4d)) : index += 1
            c1grdPendientes.AllowEditing = True
            c1grdPendientes.AutoResize = True
            c1grdPendientes.Cols(0).Width = 15
            c1grdPendientes.ExtendLastCol = False
            c1grdPendientes.AllowSorting = AllowSortingEnum.SingleColumn

            c1grdPendientes.Styles.Alternate.BackColor = Color.LightGray
            c1grdPendientes.Styles.Fixed.TextAlign = TextAlignEnum.CenterCenter
            c1grdPendientes.Styles.Highlight.BackColor = Color.Gray
            c1grdPendientes.SelectionMode = SelectionModeEnum.Row
            c1grdPendientes.AllowResizing = AllowResizingEnum.Columns

            Dim ttt As C1.Win.C1FlexGrid.CellStyle = c1grdPendientes.Styles.Add("Total")
            ttt.BackColor = Color.LightGreen
            ttt.ForeColor = Color.DarkBlue
            ttt.Font = New Font(c1grdPendientes.Font, FontStyle.Regular)

            Dim uuu As C1.Win.C1FlexGrid.CellStyle = c1grdPendientes.Styles.Add("Entregado")
            uuu.BackColor = Color.DarkSlateBlue
            uuu.ForeColor = Color.White
            uuu.Font = New Font(c1grdPendientes.Font, FontStyle.Regular)

            
            Dim dddd As C1.Win.C1FlexGrid.CellStyle = c1grdPendientes.Styles.Add("Cantidad")
            dddd.BackColor = Color.Red
            dddd.ForeColor = Color.White
            dddd.Font = New Font(c1grdPendientes.Font, FontStyle.Bold)
            c1grdPendientes.DrawMode = C1.Win.C1FlexGrid.DrawModeEnum.OwnerDraw

            '_M
            index = 1
            ACFrameworkC1.ACUtilitarios.ACFormatearGrilla(c1grdNotasCredito, 1, 1, 7, 1, 0)
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdNotasCredito, index, "Fecha Documento", "DOCVE_FechaDocumento", "DOCVE_FechaDocumento", 150, True, False, "System.DateTime") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdNotasCredito, index, "Doc. Nota", "Documento", "Documento", 150, True, False, "System.String") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdNotasCredito, index, "Motivo", "DOCVE_Motivo", "DOCVE_Motivo", 150, True, False, "System.String") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdNotasCredito, index, "Fecha Ingreso", "DOCVE_FecCrea", "DOCVE_FecCrea", 150, True, False, "System.String") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdNotasCredito, index, "Total Monto", "DOCVE_TotalPagar", "DOCVE_TotalPagar", 150, True, False, "System.Decimal") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdNotasCredito, index, "Estado", "DOCVE_Estado", "DOCVE_Estado", 150, False, False, "System.Decimal") : index += 1

            c1grdNotasCredito.AllowEditing = False
            c1grdNotasCredito.AllowSorting = AllowSortingEnum.SingleColumn
            c1grdNotasCredito.Styles.Alternate.BackColor = Color.LightGray
            c1grdNotasCredito.Styles.Fixed.TextAlign = TextAlignEnum.CenterCenter
            c1grdNotasCredito.Styles.Highlight.BackColor = Color.Gray
            c1grdNotasCredito.SelectionMode = SelectionModeEnum.Row
            c1grdNotasCredito.SubtotalPosition = SubtotalPositionEnum.AboveData
            c1grdNotasCredito.Tree.Column = 2

            Dim nx As C1.Win.C1FlexGrid.CellStyle = c1grdNotasCredito.Styles.Add("Anulado")
            nx.BackColor = Color.Red
            nx.ForeColor = Color.White
            nx.Font = New Font(c1grdNotasCredito.Font, FontStyle.Bold)
            c1grdNotasCredito.DrawMode = C1.Win.C1FlexGrid.DrawModeEnum.OwnerDraw

             
         '''entregas en el almacen
            ''' 

            index = 1
            ACFrameworkC1.ACUtilitarios.ACFormatearGrilla(c1grdAlmacen, 1, 1, 11, 1, 0)
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdAlmacen, index, "Item", "DOCVD_Item", "DOCVD_Item", 80, False, False, "System.Integer", "#0") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdAlmacen, index, "Almacen", "ALMAC_Descripcion", "ALMAC_Descripcion", 80, False, False, "System.String") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdAlmacen, index, "Codigo", "ARTIC_Codigo", "ARTIC_Codigo", 80, True, False, "System.String") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdAlmacen, index, "Descripción", "ARTIC_Descripcion", "ARTIC_Descripcion", 191, True, False, "System.String") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdAlmacen, index, "Unidad", "TIPOS_UnidadMedidaCorta", "TIPOS_UnidadMedidaCorta", 69, True, False, "System.String") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdAlmacen, index, "Total Doc.", "DOCVD_Cantidad", "DOCVD_Cantidad", 75, True, False, "System.Decimal", Parametros.GetParametro(EParametros.TipoParametros.pg_FMondo2d)) : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdAlmacen, index, "Entregado", "DOCVD_CantidadEntregada", "DOCVD_CantidadEntregada", 75, True, False, "System.Decimal", Parametros.GetParametro(EParametros.TipoParametros.pg_FMondo2d)) : index += 1
           ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdAlmacen, index, "Pendiente", "Diferencia", "Diferencia", 75, True, False, "System.Decimal", Parametros.GetParametro(EParametros.TipoParametros.pg_FMondo2d)) : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdAlmacen, index, "Fecha Entrega", "DOCVD_FecAlmacen", "DOCVD_FecAlmacen", 80, True, False, "System.DateTime", Parametros.GetParametro(EParametros.TipoParametros.pg_FormatoFecha)) : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdAlmacen, index, "Usuario", "DOCVD_UsuarioAlmacen", "DOCVD_UsuarioAlmacen", 191, True, False, "System.String") : index += 1
            c1grdAlmacen.AllowEditing = True
            c1grdAlmacen.AutoResize = True
            c1grdAlmacen.Cols(0).Width = 15
            c1grdAlmacen.ExtendLastCol = False
            c1grdAlmacen.AllowSorting = AllowSortingEnum.SingleColumn

            c1grdAlmacen.Styles.Alternate.BackColor = Color.LightGray
            c1grdAlmacen.Styles.Fixed.TextAlign = TextAlignEnum.CenterCenter
            c1grdAlmacen.Styles.Highlight.BackColor = Color.Gray
            c1grdAlmacen.SelectionMode = SelectionModeEnum.Row
            c1grdAlmacen.AllowResizing = AllowResizingEnum.Columns

            Dim ta As C1.Win.C1FlexGrid.CellStyle = c1grdAlmacen.Styles.Add("Total")
            ta.BackColor = Color.LightGreen
            ta.ForeColor = Color.DarkBlue
            ta.Font = New Font(c1grdPendientes.Font, FontStyle.Regular)

            Dim ua As C1.Win.C1FlexGrid.CellStyle = c1grdAlmacen.Styles.Add("Entregado")
            ua.BackColor = Color.DarkSlateBlue
            ua.ForeColor = Color.White
            ua.Font = New Font(c1grdPendientes.Font, FontStyle.Regular)


            Dim da As C1.Win.C1FlexGrid.CellStyle = c1grdAlmacen.Styles.Add("Cantidad")
            da.BackColor = Color.Red
            da.ForeColor = Color.White
            da.Font = New Font(c1grdAlmacen.Font, FontStyle.Bold)
            c1grdAlmacen.DrawMode = C1.Win.C1FlexGrid.DrawModeEnum.OwnerDraw




        Catch ex As Exception
            ACControles.ACDialogos.ACMostrarMensajeError("Error: " + Me.Text, "No se puede dar formato a la grilla", ex)
        End Try
    End Sub
     Private Sub formatearGrillaPV()

        Dim index As Integer = 1
        Try

             ACFrameworkC1.ACUtilitarios.ACFormatearGrilla(c1grdPuntosVentas, 1, 1, 3, 1)
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdPuntosVentas, index, "X", "Seleccionar", "Seleccionar", 80, True, True, "System.Boolean") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdPuntosVentas, index, "Punto de Venta", "PVENT_Descripcion", "PVENT_Descripcion", 150, True, False, "System.Decimal", Parametros.GetParametro(EParametros.TipoParametros.pg_FMondo2d)) : index += 1

            c1grdPuntosVentas.AllowEditing = True
            c1grdPuntosVentas.Styles.Alternate.BackColor = Color.LightGray
            c1grdPuntosVentas.Styles.Fixed.TextAlign = TextAlignEnum.CenterCenter
            c1grdPuntosVentas.Styles.Highlight.BackColor = Color.Gray
            c1grdPuntosVentas.SelectionMode = SelectionModeEnum.Row
       Catch ex As Exception
            ACControles.ACDialogos.ACMostrarMensajeError("Error: " + Me.Text, "No se puede dar formato a la grilla", ex)
        End Try
    End Sub







 Private Sub AyudaEntidad(ByVal x_cadenas As String, ByVal x_campo As String, ByVal x_descripcion As String, ByVal x_opcion As Short, ByVal x_opcionentidad As EEntidades.TipoEntidad)
        Try
            Dim _where As New Hashtable
            _where.Add(x_campo, New ACWhere(x_cadenas, ACWhere.TipoWhere._Like))
            If x_cadenas.Length = 0 Then
                Dim _campos() As ACCampos = {New ACCampos("@Opcion", x_opcion.ToString()), New ACCampos("@Cadena", x_cadenas), New ACCampos("@ROLES_Id", x_opcionentidad.GetHashCode.ToString())}
                Dim _busqueda As New ACCampos("@Cadena", x_descripcion)
                Dim AyudaText As New ACControlesC1.ACAyudaTextFlex("Buscar Entidad", "ENTISS_TodosAyuda", _campos, _busqueda, False)
                If AyudaText.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                    Select Case x_opcionentidad
                        Case EEntidades.TipoEntidad.Clientes
                            '' Cargar datos del cliente
                            m_entid_codigo = AyudaText.Respuesta.Rows(0)("Codigo")
                            actxaCliRazonSocial.Text = AyudaText.Respuesta.Rows(0)("Razon Social").ToString()
                            actxaCliRuc.Text = AyudaText.Respuesta.Rows(0)("Doc./R.U.C.").ToString()
                            setCliente()
                            btnProcesar.Focus()
                        Case EEntidades.TipoEntidad.Vendedores
                            Dim x_entid_codigo As String = AyudaText.Respuesta.Rows(0)("Codigo")
                    End Select
                End If
            Else
                If managerEntidades.Ayuda(_where, x_opcionentidad) Then
                    Dim Ayuda As New ACControlesC1.ACAyudaFlex("Buscar Entidad", managerEntidades.DTEntidades, False)
                    If Ayuda.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                        Select Case x_opcionentidad
                            Case EEntidades.TipoEntidad.Clientes
                                '' Cargar datos del cliente
                                m_entid_codigo = Ayuda.Respuesta.Rows(0)("Codigo")
                                actxaCliRazonSocial.Text = Ayuda.Respuesta.Rows(0)("Razon Social").ToString()
                                actxaCliRuc.Text = Ayuda.Respuesta.Rows(0)("Doc./R.U.C.").ToString()
                                setCliente()
                                btnProcesar.Focus()
                            Case EEntidades.TipoEntidad.Vendedores
                                Dim x_entid_codigo As String = Ayuda.Respuesta.Rows(0)("Codigo")
                        End Select
                    End If
                Else
                    ACControles.ACDialogos.ACMostrarMensajeInformacion(String.Format("Información: {0}", Me.Text), "No se puede mostrar la ayuda, posiblemente no haya datos que mostrar")
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

     Private Sub setCliente()
        '' Cargar datos adicionales cliente
        If actxaCliRuc.ACAyuda.Enabled = True Then
            If managerEntidades.CargarDocIden(actxaCliRuc.Text, EEntidades.TipoInicializacion.Direcciones) Then
                '' Cargar datos del cliente
                m_entid_codigo = managerEntidades.Entidades.ENTID_Codigo

                Dim x_direcciones As New EDirecciones
                x_direcciones.DIREC_Id = 0
                x_direcciones.Direccion = managerEntidades.Entidades.Direccion
                x_direcciones.UBIGO_Codigo = managerEntidades.Entidades.UBIGO_Codigo
                If IsNothing(managerEntidades.Entidades.ListDirecciones) Then managerEntidades.Entidades.ListDirecciones = New List(Of EDirecciones)()
                managerEntidades.Entidades.ListDirecciones.Insert(0, x_direcciones)

                actxaCliRazonSocial.Text = managerEntidades.Entidades.ENTID_RazonSocial
                actxaCliRuc.Text = managerEntidades.Entidades.ENTID_NroDocumento
            Else
                ACControles.ACDialogos.ACMostrarMensajeInformacion(String.Format("Documento de Identidad: {0}", Me.Text) _
                                , String.Format("El Documento de Identidad {0} no existe, ¿Desea Ingresar la Entidad?", actxaCliRuc.Text) _
                                )
                actxaCliRuc.Focus()
            End If
        End If
    End Sub

       Private Sub cargarDatos()
        Try
            bs_ventas = New BindingSource()
            ''bs_ventas.DataSource = m_reporte.ListVENT_DocsVenta
            m_reporte.ListVENT_DocsVenta= Nothing
            m_reporte.ListVENT_DocsVenta= list.Cast(Of ACEVentas.EVENT_DocsVenta).ToList()
            bs_ventas.DataSource = m_reporte.ListVENT_DocsVenta
            c1grdReporte.DataSource = bs_ventas
            bnavCBusqueda.BindingSource = bs_ventas
            AddHandler bs_ventas.CurrentChanged, AddressOf bs_VENTAS_CurrentChanged
            bs_VENTAS_CurrentChanged(Nothing, Nothing)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
        Private Sub bs_VENTAS_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If Not IsNothing(bs_ventas) Then
                If Not IsNothing(bs_ventas.Current) Then
                    If CType(bs_ventas.Current, ACEVentas.EVENT_DocsVenta).DOCVE_Estado = ACEVentas.EVENT_DocsVenta.getEstado(ACEVentas.EVENT_DocsVenta.Estado.Ingresado) Then
                        acTool.ACBtnAnularEnabled = True
                    Else
                        acTool.ACBtnAnularEnabled = False
                    End If
                End If
            End If
        Catch ex As Exception
            ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso Cargar Propiedades del Cotización/Pedido", ex)
        End Try
    End Sub


     Private Sub cargarventa(ByVal x_codigo As String)
        Try
           '' If m_reporte.CargarVentas(x_codigo) Then
            If managerVENT_DocsVenta.Cargar(x_codigo,True) Then
                setInstancia(ACFramework.ACUtilitarios.ACSetInstancia.Previsualizar)
                estado=""
               cargarCliente(managerVENT_DocsVenta.VENT_DocsVenta.ENTID_CodigoCliente)
                setInstancia(ACUtilitarios.ACSetInstancia.Previsualizar)
                If  managerVENT_DocsVenta.VENT_DocsVenta.PEDID_Codigo Isnot Nothing then                  
                txtcotizacion.Text="COT-"+managerVENT_DocsVenta.VENT_DocsVenta.PEDID_Codigo.Substring(2,3)+"-"+managerVENT_DocsVenta.VENT_DocsVenta.PEDID_Codigo.Substring(5,7)                  
                End If
                m_event_docsventa = New ACEVentas.EVENT_DocsVenta()
                m_event_docsventa = managerVENT_DocsVenta.VENT_DocsVenta

                AsignarBinding()
                tabMantenimiento.SelectedTab = tabDatos
                bs_reporte = New BindingSource
                
                bs_reporte.DataSource = m_event_docsventa.ListVENT_DocsVentaDetalle
                bnavProductos.BindingSource = bs_reporte
                c1grdDetalle.DataSource = bs_reporte

                 ''Cargar almacen
                CargarAlmacenEntregas()

                ''cargartodo

                '' Cargar Vendedor
                cargarVendedor(m_event_docsventa.ENTID_CodigoVendedor)
                '' Cargar Cliente
                'cargarCliente(m_event_docsventa.ENTID_CodigoCliente)


                'managerVENT_DocsVenta.Cargar(m_event_docsventa.ENTID_CodigoCliente)
                actxaDescCliente.Text = managerVENT_DocsVenta.VENT_DocsVenta.DOCVE_DescripcionCliente
                actxaCodCliente.Text = managerVENT_DocsVenta.VENT_DocsVenta.ENTID_CodigoCliente
               


                ' Cargar Documentos de Pago
                '' Cargar Letras
                'cargarLetras()
                '' Cargar Docmento
                'cmbDocumento.SelectedValue = m_event_docsventa.TIPOS_CodTipoDocumento
                'cmbSerie.SelectedValue = m_event_docsventa.DOCVE_Serie
                'actxnNumero.Text = m_event_docsventa.DOCVE_Numero
                'actxnPercepcionMO.Text = actxnPercepcion.Text
                c1grdDetalle.AutoSizeCols()
                '' Cargar Guias
                Dim _generarguias As New BGenerarGuias( GApp.Almacen, GApp.Periodo, GApp.Zona, GApp.Sucursal)
                _generarguias.GuiasXDocumentoL(m_event_docsventa.DOCVE_Codigo, GApp.EAlmacen.ALMAC_Id)
                bs_guias = New BindingSource
                bs_guias.DataSource = _generarguias.ListDIST_GuiasRemision
                c1grdGuiasRemision.DataSource = bs_guias
                bnavGuiasRemision.BindingSource = bs_guias
                '' Cargar Ordenes
                Dim _generarOrdenes As New BGenerarOrdenes(GApp.Periodo)
                _generarOrdenes.OrdenesXDocumentoL(m_event_docsventa.DOCVE_Codigo, GApp.Almacen)
                bs_ordenes = New BindingSource
                bs_ordenes.DataSource = _generarOrdenes.ListDIST_Ordenes
                c1grdOrdenes.DataSource = bs_ordenes
                bnavOrdenes.BindingSource = bs_ordenes
                '--------------------------
                '' Cargar Notas de Credito
                CargarNotas()
                '' Cargar Pagos
                CargarPagos()
                '' cargar Pendientes
                cargarPendientes()
                '' Admin
                'actxaCodUsrModFecPago.Text = m_event_docsventa.DOCVE_FPUsrMod
                'actxaDescUsrModFecPago.Text = m_event_docsventa.ENTID_UsrAdmin
                If Not m_event_docsventa.DOCVE_FechaPago.Year > 1900 Then m_event_docsventa.DOCVE_FechaPago = DateTime.Now
                '' Adicionales
                actxaCodFacturador.Text = m_event_docsventa.DOCVE_UsrCrea
                actxaDescFacturador.Text = m_event_docsventa.ENTID_Facturador
                actxaCodCotizador.Text = m_event_docsventa.ENTID_CodigoCotizador
                actxaDescCotizador.Text = m_event_docsventa.ENTID_Cotizador
                dtpFecCreacion.Value = m_event_docsventa.DOCVE_FecCrea
                dtpFecCreacion.Enabled = False
                dtpHoraCreacion.Value = m_event_docsventa.DOCVE_FecCrea
                dtpHoraCreacion.Enabled = False
                'chkPermisoGenGuias.Checked = m_event_docsventa.DOCVE_PerGenGuia

''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

                If m_event_docsventa.DOCVE_Estado.Equals("X") Then
                    estado="X"
                   
                    
                    If m_event_docsventa.DOCVE_MotivoAnulacion is Nothing Then
                    else
                    txtMotivoAnulacion.Text=m_event_docsventa.DOCVE_MotivoAnulacion
                    End If
                    
                    dtpFechaAnulacion.Value = m_event_docsventa.DOCVE_FecMod
                    tbcDetalles.Visible = True
                    acpnlTitulo.Active = True
                     grpDocumento.BackColor = Color.Maroon
                    pnlPie.BackColor = Color.Maroon
                    acpnlTitulo.InactiveGradientLowColor = Color.Maroon
                    acpnlTitulo.InactiveGradientHighColor = Color.Maroon
                    grpDetalleDocumento.BackColor=Color.Maroon
                    tbcDetalles.TabPages.Add(tpgDetAnulacion)
                    tbcDetalles.SelectedTab = tpgDetAnulacion
                  
                Else
                    tbcDetalles.SelectedTab = tpgAdicionales
                   tbcDetalles.TabPages.Remove(tpgDetAnulacion)
                    tpgDetAnulacion.Visible = False
                    txtMotivoAnulacion.Clear()
                    ''tbcDetalles.Visible = true
                    acpnlTitulo.Active = False
                    grpDetalleDocumento.BackColor=Color.FromArgb(3, 55, 145)
                    grpFlete.BackColor = Color.FromArgb(3, 55, 145)
                    pnlPie.BackColor = Color.FromArgb(3, 55, 145)
                    grpDocumento.BackColor = Color.FromArgb(3, 55, 145)
             
              
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
Private Sub CargarAlmacenEntregas()

        Try
            Dim x_codigo As String = m_event_docsventa.DOCVE_Codigo
            Dim m_edist_docsalmacen As New ACEVentas.EVENT_DocsVenta

            Dim managerGenerarAlmacen As New BGenerarDocsVenta(GApp.Almacen, GApp.Periodo, GApp.Zona, GApp.Sucursal)
            If managerGenerarAlmacen.cargar(x_codigo, GApp.Almacen, True, False) Then
               
                ' Cargar el detalle de la guia de remision
                m_edist_docsalmacen.ListVENT_DocsVentaDetalle = New List(Of ACEVentas.EVENT_DocsVentaDetalle)

            End If

            bs_docalmacenentregas = New BindingSource
            bs_docalmacenentregas.DataSource = managerGenerarAlmacen.VENT_DocsVenta.ListVENT_DocsVentaDetalle
            bnavProductos.BindingSource = bs_docalmacenentregas
            c1grdAlmacen.DataSource = bs_docalmacenentregas
        Catch ex As Exception
            Throw ex
        End Try
    End Sub       
 Private Sub cargarVendedor(ByVal x_vend_codigo As String)
        Try
            If managerVENT_DocsVenta.getVendedor(x_vend_codigo) Then
                actxaNomVendedor.Text = managerVENT_DocsVenta.Vendedor.ENTID_Nombres
                actxaCodVendedor.Text = managerVENT_DocsVenta.Vendedor.ENTID_Codigo
            Else
                managerVENT_DocsVenta.getVendedor(Parametros.GetParametro(EParametros.TipoParametros.pg_VendedorDefa))
                m_event_docsventa.ENTID_CodigoVendedor = managerVENT_DocsVenta.Vendedor.ENTID_Codigo
                actxaNomVendedor.Text = managerVENT_DocsVenta.Vendedor.ENTID_Nombres
                actxaCodVendedor.Text = managerVENT_DocsVenta.Vendedor.ENTID_Codigo
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    ' Private Sub cargarLetras()
    '    Try
    '        bs_letras = New BindingSource
    '        If Not managerVENT_DocsVenta.GetLetras() Then
    '            managerVENT_DocsVenta.VENT_DocsVenta.ListTESO_DocsPagos = New List(Of ETESO_DocsPagos)
    '        End If
    '        bs_letras.DataSource = managerVENT_DocsVenta.VENT_DocsVenta.ListTESO_DocsPagos
    '        c1grdLetras.DataSource = bs_letras
    '        bnavLetras.BindingSource = bs_letras

    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Sub
     Private Sub CargarNotas()
        Try

            Dim _codigo As String = m_event_docsventa.DOCVE_Codigo
             _generarNotasC = new ACBVentas.BGenerarDocsVenta(GApp.Zona, GApp.Sucursal, GApp.Periodo)
            If Not _generarNotasC.DocumentosRelacionados(_codigo) Then
                _generarNotasC.ListVENT_DocsVenta = New List(Of ACEVentas.EVENT_DocsVenta)
            End If
            bs_notas = New BindingSource
            bs_notas.DataSource = _generarNotasC.ListVENT_DocsVenta
            c1grdNotasCredito.DataSource = bs_notas
            bnavNotas.BindingSource = bs_notas
            '  c1grdNotasCredito.Subtotal(AggregateEnum.Sum, 0, -1, 6, "Total")
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
     Private Sub CargarPagos()
        Try

            'o(ByVal x_servidor As String, ByVal x_servidornombre As String, ByVal x_basedatos As String, ByVal x_servidor_admin As String, ByVal x_periodo As String)
            '   GApp.SetIP_HostName(GApp.Servidor, GApp.ServidorNombre, GApp.BaseDatos, GApp.Usuario_DB, GApp.Periodo)
            Dim _codigo As String = m_event_docsventa.DOCVE_Codigo
            '   Dim managerbadministracioncaja As New BAdminCaja(GApp.Zona, GApp.Sucursal, GApp.PuntoVenta, GApp.Periodo) 'Comentaod el 16-09-2025 
            Dim managerbadministracioncaja As New BAdminCaja(GApp.Zona, GApp.Sucursal, GApp.Periodo)
            If Not managerbadministracioncaja.VENT_DOCVESS_CajaPagos(_codigo) Then
                managerbadministracioncaja.ListTESO_CajaPagos = New List(Of ETESO_Caja)
            End If
            bs_pagos = New BindingSource
            bs_pagos.DataSource = managerbadministracioncaja.ListTESO_CajaPagos
            c1grdPagos.DataSource = bs_pagos
            bnavPagos.BindingSource = bs_pagos
            c1grdPagos.Subtotal(AggregateEnum.Sum, 0, -1, 6, "Total")
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
     Private Sub cargarPendientes()
        Try
            Dim x_codigo As String = m_event_docsventa.DOCVE_Codigo
             Dim x_estentrega As String = m_event_docsventa.DOCVE_EstEntrega
            Dim m_edist_docstraslado As New ACEVentas.EDIST_GuiasRemision
            If m_event_docsventa.DOCVE_EstEntrega.Equals(Colecciones.GetEntrega(Colecciones.TEntrega.Pendiente)) Then
                Dim managerGenerarGuias As New BGenerarGuias( GApp.Almacen, GApp.Periodo, GApp.Zona, GApp.Sucursal)
                If managerGenerarGuias.cargarL(x_codigo, GApp.Almacen, True, False,x_estentrega) Then
                    m_edist_docstraslado.Instanciar(ACEInstancia.Nuevo)
                    m_edist_docstraslado.GUIAR_Estado = ACEVentas.EDIST_GuiasRemision.getEstado(ACEVentas.EDIST_GuiasRemision.Estado.Ingresado)
                    m_edist_docstraslado.ENTID_CodigoCliente = managerGenerarGuias.VENT_DocsVenta.ENTID_CodigoCliente
                    m_edist_docstraslado.DOCVE_Codigo = managerGenerarGuias.VENT_DocsVenta.DOCVE_Codigo
                    m_edist_docstraslado.ORDEN_Codigo = managerGenerarGuias.VENT_DocsVenta.ORDEN_Codigo

                    m_edist_docstraslado.GUIAR_StockDevuelto = managerGenerarGuias.VENT_DocsVenta.DOCVE_StockDevuelto
                    ' Cargar el detalle de la guia de remision
                    m_edist_docstraslado.ListDIST_GuiasRemisionDetalle = New List(Of ACEVentas.EDIST_GuiasRemisionDetalle)
                    For Each Item As ACEVentas.EVENT_DocsVentaDetalle In managerGenerarGuias.VENT_DocsVenta.ListVENT_DocsVentaDetalle
                        Dim _doct As New ACEVentas.EDIST_GuiasRemisionDetalle()
                        _doct.ARTIC_Codigo = Item.ARTIC_Codigo
                        _doct.ARTIC_Descripcion = Item.ARTIC_Descripcion
                        If Item.Diferencia = Item.DOCVD_Cantidad Then
                            _doct.GUIRD_Cantidad = Item.DOCVD_Cantidad
                        ElseIf Item.Diferencia = 0 Then
                            _doct.GUIRD_Cantidad = 0
                        Else
                            _doct.GUIRD_Cantidad = Item.Diferencia
                        End If

                        _doct.TIPOS_UnidadMedidaCorta = Item.TIPOS_UnidadMedidaCorta
                        _doct.GUIRD_ItemDocumento = Item.DOCVD_Item
                        _doct.GUIRD_PesoUnitario = Item.DOCVD_PesoUnitario
                        _doct.TIPOS_UnidadMedida = Item.TIPOS_UnidadMedida
                        _doct.TIPOS_CodUnidadMedida = Item.TIPOS_CodUnidadMedida
                        _doct.GUIRD_Cantidad = Item.Diferencia
                        _doct.Diferencia = Item.Diferencia
                        _doct.Entregado = Item.Entregado
                        _doct.DOCVD_Cantidad = Item.DOCVD_Cantidad
                        _doct.ALMAC_Descripcion = Item.ALMAC_Descripcion
                        m_edist_docstraslado.ListDIST_GuiasRemisionDetalle.Add(_doct)
                    Next
                End If
            Else
                m_edist_docstraslado.ListDIST_GuiasRemisionDetalle = New List(Of ACEVentas.EDIST_GuiasRemisionDetalle)
            End If
            bs_doctrasaladodetalle = New BindingSource
            bs_doctrasaladodetalle.DataSource = m_edist_docstraslado.ListDIST_GuiasRemisionDetalle
            bnavProductos.BindingSource = bs_doctrasaladodetalle
            c1grdPendientes.DataSource = bs_doctrasaladodetalle
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    
    #Region "Cargar Datos"
    Private Sub AsignarBinding()
        Try
            m_listBindHelper = New List(Of ACBindHelper)()
            If m_event_docsventa.DOCVE_FechaDocumento.Year < 1700 Then m_event_docsventa.DOCVE_FechaDocumento = DateTime.Now
            m_listBindHelper.Add(ACBindHelper.ACBind(dtpFechaEmision, "Value", m_event_docsventa, "DOCVE_FechaDocumento"))
            If m_event_docsventa.DOCVE_FechaTransaccion.Year < 1700 Then m_event_docsventa.DOCVE_FechaTransaccion = DateTime.Now
            m_listBindHelper.Add(ACBindHelper.ACBind(dtpFechaTraslado, "Value", m_event_docsventa, "DOCVE_FechaTransaccion"))

            m_listBindHelper.Add(ACBindHelper.ACBind(actxnImporte, "Text", m_event_docsventa, "DOCVE_ImporteVenta"))
            m_listBindHelper.Add(ACBindHelper.ACBind(actxnIGV, "Text", m_event_docsventa, "DOCVE_ImporteIgv"))
            m_listBindHelper.Add(ACBindHelper.ACBind(actxnTotal, "Text", m_event_docsventa, "DOCVE_TotalVenta"))
            m_listBindHelper.Add(ACBindHelper.ACBind(cmbEntrega, "SelectedValue", m_event_docsventa, "DOCVE_EstEntrega"))
            ''m_listBindHelper.Add(ACBindHelper.ACBind(actxnPPercepcion, "Text", m_event_docsventa, "DOCVE_PorcentajePercepcion"))
            'm_listBindHelper.Add(ACBindHelper.ACBind(actxnPercepcion, "Text", m_event_docsventa, "DOCVE_ImportePercepcion"))
            ''m_listBindHelper.Add(ACBindHelper.ACBind(actxnPercepcionSoles, "Text", m_event_docsventa, "DOCVE_ImportePercepcionSoles"))
            m_listBindHelper.Add(ACBindHelper.ACBind(actxnTotalPagar, "Text", m_event_docsventa, "DOCVE_TotalPagar"))
            m_listBindHelper.Add(ACBindHelper.ACBind(actxnPesoTotal, "Text", m_event_docsventa, "DOCVE_TotalPeso"))


            m_listBindHelper.Add(ACBindHelper.ACBind(txtdireccion, "Text", m_event_docsventa, "DOCVE_DireccionCliente"))'
            m_listBindHelper.Add(ACBindHelper.ACBind(actxaCodCliente, "Text", m_event_docsventa, "ENTID_CodigoCliente"))'
            m_listBindHelper.Add(ACBindHelper.ACBind(actxnPesoTotal, "Text", m_event_docsventa, "DOCVE_TotalPeso"))'
            m_listBindHelper.Add(ACBindHelper.ACBind(cmbGuiaSerie, "Text", m_event_docsventa, "DOCVE_Serie"))
            m_listBindHelper.Add(ACBindHelper.ACBind(cmbGuia, "SelectedValue", m_event_docsventa, "TIPOS_CodTipoDocumento"))
            m_listBindHelper.Add(ACBindHelper.ACBind(cmbmottraslado, "SelectedValue", m_event_docsventa, "TIPOS_CodTipoDocumento"))

            m_listBindHelper.Add(ACBindHelper.ACBind(actxnNumero, "Text", m_event_docsventa, "DOCVE_Numero"))
            m_listBindHelper.Add(ACBindHelper.ACBind(actxaDescCliente, "Text",m_event_docsventa , "DOCVE_DescripcionCliente"))'
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
#End Region

Private Sub cargarCliente(ByVal x_entid_codigo As String)
        Try
            If managerEntidades.Cargar(x_entid_codigo, EEntidades.TipoInicializacion.EntTipos_Dir_Tel) Then
                actxaDescCliente.Text = managerEntidades.Entidades.ENTID_RazonSocial
                actxaCodCliente.Text = managerEntidades.Entidades.ENTID_Codigo

            End If
        Catch ex As Exception
            Throw ex
        End Try
End Sub

    Private Sub setInstancia(ByVal _opcion As ACUtilitarios.ACSetInstancia)
        Try
            actxaCodCliente.ACAyuda.Enabled = True
            actxaCodCliente.ACActivarAyuda = True
            'actxaCodCliente.ReadOnly = True
            actxaDescCliente.ACAyuda.Enabled = True
            actxaDescCliente.ACActivarAyuda = True
            actxaDescCliente.ReadOnly = False
            'actxaDescCliente.ReadOnly = True

            acTool.ACBtnEliminarVisible = False
            Select Case _opcion
                Case ACUtilitarios.ACSetInstancia.Nuevo
                    ACUtilitarios.ACLimpiaVar(pnlCabecera)
                    ACUtilitarios.ACSetControl(pnlCabecera, False, ACUtilitarios.TipoPropiedad.ACReadOnly)
                    ACUtilitarios.ACLimpiaVar(pnlItem)
                    actxaCodCliente.Focus()
                    actsbtnPrevisualizar.Visible = False

                    ''.00
                Case ACUtilitarios.ACSetInstancia.Modificado
                    ''.0000

                    ''.00000000000000000
                Case ACUtilitarios.ACSetInstancia.Guardar
                    acTool.ACBtnImprimirVisible = False
                    acTool.ACBtnBuscarVisible = True
                    actsbtnPrevisualizar.Visible = True
                Case ACUtilitarios.ACSetInstancia.Deshacer
                    acTool.ACBtnModificarVisible = False
                    acTool.ACBtnBuscarVisible = False
                    acTool.ACBtnImprimirVisible = False
                    actsbtnPrevisualizar.Visible = True
                    Me.KeyPreview = False
                Case ACUtilitarios.ACSetInstancia.Previsualizar
                    ACUtilitarios.ACLimpiaVar(pnlCabecera)
                    ACUtilitarios.ACSetControl(pnlCabecera, True, ACUtilitarios.TipoPropiedad.ACReadOnly)
                    txtdireccion.Enabled = True
                    'cmbDirOrigenSalTrans.Enabled = True
                    'cmbDirDestino.Enabled = True
                    cmbGuia.Enabled = False
                    actsbtnPrevisualizar.Visible = False
                    acTool.ACBtnEliminarVisible = False
                    '' Asignar Permisos
                    Dim _validate As ACValidarUsuario
                    _validate = New ACValidarUsuario(GApp.DataConexion, GApp.DataUsuario, ACValidarUsuario.Operacion.ValidarVariosProcesos)
                    For Each item As ACSeguridad.EProcesos In _validate.ListProcesos
                        Select Case item.PROC_Codigo
                            Case Procesos.getProceso(Procesos.TipoProcesos.Desp_EliGuiaRemSalTralado)
                                acTool.ACBtnEliminarVisible = True
                        End Select
                    Next
                    tbcDetalles.TabPages.Add(tpgDetAnulacion)
            End Select
            acTool.ACBtnModificarVisible = False
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    #End Region

Private Sub rbtncliente_CheckedChanged( sender As Object,  e As EventArgs) Handles rbtncliente.CheckedChanged
           If rbtncliente.Checked Then
            actxaCliRuc.ACAyuda.Enabled = True
            actxaCliRazonSocial.ACActivarAyudaAuto = True
            actxaCliRuc.Enabled = True
            actxaCliRazonSocial.Enabled = True


        End If

End Sub

Private Sub btnProcesar_Click( sender As Object,  e As EventArgs) Handles btnProcesar.Click
        Try
            Dim _j As Integer = 1
            formatearGrilla()
            list = new ArrayList()
             For Each itemAlPV As EPuntoVenta In CType(BS_PV.DataSource, List(Of EPuntoVenta))
                    If itemAlPV.Seleccionar Then
                            If m_reporte.Repor_Ventas_Todo(itemAlPV.PVENT_Id, actxaCliRazonSocial.Text, AcFecha.ACDtpFecha_De.Value.Date, AcFecha.ACDtpFecha_A.Value.Date, chkctodos.Checked,"Bol.") Then
                                list.AddRange(m_reporte.ListVENT_DocsVenta)
                            End If
                    End If
            Next

            cargarDatos()
            c1grdReporte.AutoSizeCols()

        
             If m_reporte.ControlPendietnesTotdo(GApp.Almacen, AcFecha.ACDtpFecha_De.Value.Date, AcFecha.ACDtpFecha_A.Value.Date,"facturas") Then
                        Dim _ik As Integer = 1
                        For items = 1 To c1grdReporte.Rows.Count - 1

                    ''''otra forma de recorrer
                            'If  (From p In  m_reporte.DTReportes.Rows
                            '    Where p("DOCVE_CODIGO")=c1grdReporte.Rows(items)("DOCVE_Codigo") ).Any() Then
                                
                            '        c1grdReporte.Rows(_ik)("VENTAS_Condicion") = "Pendiente"'item_tabla("CANT_ItemPendiente")
                            'End If
                           
                         For Each item_tabla As DataRow In m_reporte.DTReportes.Rows
                                If item_tabla("DOCVE_CODIGO") = c1grdReporte.Rows(items)("DOCVE_Codigo") Then
                                        c1grdReporte.Rows(_ik)("VENTAS_Condicion") = "Pendiente"'item_tabla("CANT_ItemPendiente")

                                End If
                         Next
                            _ik += 1
                          Next
                    End If
            LiberarMemoria()
        Catch ex As Exception
            ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), Colecciones.getError("00000"), ex)
        End Try
End Sub

Private Sub tsbtnExcel_Click( sender As Object,  e As EventArgs) Handles tsbtnExcel.Click
         Try
            Utilitarios.ExportarXLS(c1grdReporte, "Documentos Todos")
        Catch ex As Exception
            ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso Exportar a Excel", ex)
        End Try
End Sub

Private Sub actsbtnPrevisualizar_Click( sender As Object,  e As EventArgs) Handles actsbtnPrevisualizar.Click
         Try
            If Not IsNothing(bs_ventas) Then
                If Not IsNothing(bs_ventas.Current) Then
                    x_codigo= CType(bs_ventas.Current, ACEVentas.EVENT_DocsVenta).DOCVE_Codigo
                    Dim x_confir As Boolean = CType(bs_ventas.Current, ACEVentas.EVENT_DocsVenta).VENTAS_RevisadoControl
                    ' InitControles(False)
                    If x_confir = True Then
                        btnRevision.Visible=False
                        Else 
                        btnRevision.Visible=True
                    End If
                    cargarVenta(x_codigo)
                    acTool.ACBtnVolverVisible = True
                    acTool.ACBtnBuscarVisible = False
                    acTool.ACBtnCancelarVisible = False
                    acTool.ACBtnImprimirVisible = False
                    actsbtnPrevisualizar.Visible = False
                    acTool.ACBtnAnularVisible = False
                    Dim _validate As ACValidarUsuario
                    _validate = New ACValidarUsuario(GApp.DataConexion, GApp.DataUsuario, ACValidarUsuario.Operacion.ValidarVariosProcesos)
                    For Each item As ACSeguridad.EProcesos In _validate.ListProcesos
                        Select Case item.PROC_Codigo
                            Case Procesos.getProceso(Procesos.TipoProcesos.Desp_AnularGuiasTrasSalMismoDia)
                                If Not acpnlTitulo.Active Then
                                    acTool.ACBtnAnularVisible = True
                                End If
                            Case Procesos.getProceso(Procesos.TipoProcesos.Desp_AnularGuiasTrasSalPosteriores)
                                If Not acpnlTitulo.Active Then
                                    acTool.ACBtnAnularVisible = True
                                    ' m_pgremisionp = True
                                End If
                        End Select
                    Next
                Else
                    ACControles.ACDialogos.ACMostrarMensajeInformacion(String.Format("Información: {0}", Me.Text), "No se puede visualizar por que no ha seleccionado ningun registro")
                End If
            Else
                ACControles.ACDialogos.ACMostrarMensajeInformacion(String.Format("Información: {0}", Me.Text), "No se puede visualizar por que no se ha cargado ningun registro")
            End If
           
        Catch ex As Exception
            ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso Visualizar Documento", ex)
        End Try
End Sub

Private Sub acTool_ACBtnVolver_Click( sender As Object,  e As EventArgs) Handles acTool.ACBtnVolver_Click
          tabMantenimiento.SelectedTab = tabBusGuias
        acTool.ACBtnVolverVisible = False
        acTool.ACBtnBuscarVisible = False
        acTool.ACBtnCancelarVisible = False
        acTool.ACBtnNuevoVisible = False
        acTool.ACBtnModificarVisible = False
        acTool.ACBtnImprimirVisible = False
        actsbtnPrevisualizar.Visible = True
        acTool.ACBtnAnularVisible = False
        acpnlTitulo.Active = False

        grpDocumento.BackColor = Color.DarkBlue
        pnlPie.BackColor = Color.DarkBlue
        acpnlTitulo.InactiveGradientLowColor = Color.DarkBlue
        acpnlTitulo.InactiveGradientHighColor = Color.CornflowerBlue
End Sub

Private Sub c1grdReporte_BeforeDoubleClick( sender As Object,  e As BeforeMouseDownEventArgs) Handles c1grdReporte.BeforeDoubleClick
           actsbtnPrevisualizar_Click(Nothing, Nothing)
End Sub


Private Sub c1grdReporte_BeforeSort( sender As Object,  e As SortColEventArgs) Handles c1grdReporte.BeforeSort
         Try
            Ordenar(c1grdReporte.Cols(e.Col).UserData)
        Catch ex As Exception
            ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso ordenar", ex)
        End Try
End Sub

    Private Sub Ordenar(ByVal x_columna As String)
        Dim _ordenador As New ACOrdenador(Of ACEVentas.EVENT_DocsVenta)
        Try
            If Not IsNothing(bs_ventas) Then
                If Not IsNothing(bs_ventas.Current) Then
                    If m_order = 2 Then x_columna &= " DESC"
                    _ordenador.ACOrdenamiento = x_columna
                    CType(bs_ventas.DataSource, List(Of ACEVentas.EVENT_DocsVenta)).Sort(_ordenador)
                    c1grdReporte.Refresh()
                    m_order = IIf(m_order = 1, 2, 1)
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

Private Sub c1grdReporte_OwnerDrawCell( sender As Object,  e As OwnerDrawCellEventArgs) Handles c1grdReporte.OwnerDrawCell
           Try
            If e.Row < c1grdReporte.Rows.Fixed OrElse e.Col < c1grdReporte.Cols.Fixed Then Return
            If c1grdReporte.Rows(e.Row)("DOCVE_Estado") = "Confirmado" Then
                e.Style = c1grdReporte.Styles("Confirmado")
            End If
            If c1grdReporte.Rows(e.Row)("DOCVE_Estado") = "Anulado" Then
                e.Style = c1grdReporte.Styles("Anulado")
            End If

            If c1grdReporte.Cols(e.Col).Name = "VENTAS_Condicion" Then
              
                    If c1grdReporte.Rows(e.Row)("VENTAS_Condicion") ="Entregado" Then
                    
                        e.Style = c1grdReporte.Styles("Confirmado")
                    else
                    e.Style = c1grdReporte.Styles("Anulado")
                    End If
                
             End If
            

        Catch ex As Exception
            ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso cambia de color", ex)
        End Try
End Sub



Private Sub btnRevision_Click( sender As Object,  e As EventArgs) Handles btnRevision.Click
        Try

            if m_reporte.Ventas_VerificacionControl(GApp.Sucursal,m_event_docsventa.Docve_Codigo,GApp.EUsuario.USER_CodUsr,"1") Then
                'Timer1.Start()
                'Timer1.Interval=3
                if ACControles.ACDialogos.ACMostrarMensajeSatisfactorio(String.Format("Información:"), String.Format("Verificacion Correcta" ))

                    acTool_ACBtnVolver_Click(Nothing,Nothing)
                    actualizar()
                    'btnProcesar_Click(Nothing,Nothing)
                    
                        if(Columna =c1grdReporte.Rows.Count)
                             c1grdReporte.TopRow=columna-10
                            c1grdReporte.Select(columna-1,0) 
                        Else If (columna-10 <=0)Then
                            c1grdReporte.TopRow=1
                            c1grdReporte.Select(columna,0)
                       Else 
                            c1grdReporte.TopRow=columna-10
                            c1grdReporte.Select(columna,0)
                        End If
                        columna=0
                end If
                'c1grdReporte.RowSel
            End If
            LiberarMemoria()
        Catch ex As Exception
            ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), Colecciones.getError("00000"), ex)
        End Try
End Sub

private sub actualizar()
        
                Dim consult =(From p In  m_reporte.ListVENT_DocsVenta
                                              Where p.DOCVE_Codigo =x_codigo).Single()           
                                consult.VENTAS_RevisadoControl=True
                                consult.VENTAS_RevisadoUsr=GApp.EUsuario.USER_CodUsr
                                Dim cm as CurrencyManager
                                cm=Me.BindingContext(m_reporte.ListVENT_DocsVenta)
                                cm.Refresh()
   
End Sub
    private sub actualizar2()
        
                Dim consult =(From p In  m_reporte.ListVENT_DocsVenta
                                              Where p.DOCVE_Codigo =x_codigo).Single()           
                                consult.DOCVE_RevisadoControl2=True
                                consult.DOCVE_RevisadoUsr2=GApp.EUsuario.USER_CodUsr
                                Dim cm as CurrencyManager
                                cm=Me.BindingContext(m_reporte.ListVENT_DocsVenta)
                                cm.Refresh()
   
End Sub



    Private Declare Auto Function SetProcessWorkingSetSize Lib "kernel32.dll" (ByVal procHandle As IntPtr, ByVal min As Int32, ByVal max As Int32) As Boolean
 
    Public Sub LiberarMemoria()
        Try
        Dim memoria As Process
      memoria = Process.GetCurrentProcess()
      SetProcessWorkingSetSize(memoria.Handle, -1, -1)
 
     Catch ex As Exception
 
     End Try
 
    End Sub

'Private Sub Timer1_Tick( sender As Object,  e As EventArgs) Handles Timer1.Tick
'            Timer1.Stop()
'          dim ti as IntPtr=FindWindow(Nothing,"Información:")
'            If ti <>IntPtr.Zero then
'                SendMessageA(ti,WM_CLOSE,Nothing,Nothing)
'                acTool_ACBtnVolver_Click(Nothing,Nothing)
'                btnProcesar_Click(Nothing,Nothing)
'            End If

'End Sub

Private Sub c1grdReporte_Click( sender As Object,  e As EventArgs) Handles c1grdReporte.Click
        Columna= c1grdReporte.RowSel+1
End Sub


Private Sub c1grdDetalle_OwnerDrawCell_2( sender As Object,  e As OwnerDrawCellEventArgs) Handles c1grdDetalle.OwnerDrawCell
         Try

            If e.Row < c1grdDetalle.Rows.Fixed OrElse e.Col < c1grdDetalle.Cols.Fixed Then Return

                If c1grdDetalle.Cols(e.Col).Name = "DOCVD_Cantidad" Then
              
                    If c1grdDetalle.Rows(e.Row)("DOCVD_Cantidad") > 0 Then
                    
                         If estado="X" Then
                        e.Style = c1grdDetalle.Styles("Anulado")
                        Else 
                        e.Style = c1grdDetalle.Styles("GUIRD_Cantidad")
                    End If

                    End If             
             End If
        Catch ex As Exception
            ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso cambia de color", ex)
        End Try
End Sub

Private Sub btnExcel_Click( sender As Object,  e As EventArgs) Handles btnExcel.Click
          Try
            Utilitarios.ExportarXLS(c1grdReporte, "Documentos Todos")
        Catch ex As Exception
            ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso Exportar a Excel", ex)
        End Try
End Sub

Private Sub cmbMoneda_SelectedIndexChanged( sender As Object,  e As EventArgs) Handles cmbMoneda.SelectedIndexChanged
         Try
         If cmbMoneda.SelectedValue.Equals(ETipos.getTipo(ETipos.TipoMoneda.Dolares)) Then
            setEtiqueta(ETipos.TipoMoneda.Dolares)
         Else
            setEtiqueta(ETipos.TipoMoneda.Soles)
         End If
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), String.Format(Colecciones.getError("00101"), "Cambio de Moneda"), ex)
      End Try
End Sub

     Private Sub setEtiqueta(ByVal x_moneda As ETipos.TipoMoneda)
      Try
         Select Case x_moneda
            Case ETipos.TipoMoneda.Soles
               If IsNothing(m_event_docsventa) Then
                  lbligv.Text = String.Format("I.G.V. {1:0#}%: {0}", Constantes.Moneda(ETipos.TipoMoneda.Soles), Parametros.GetParametro(EParametros.TipoParametros.PIGV))
               Else
                  lbligv.Text = String.Format("I.G.V. {1:0#}%: {0}", Constantes.Moneda(ETipos.TipoMoneda.Soles), m_event_docsventa.DOCVE_PorcentajeIGV)
               End If
               lblImporte.Text = String.Format("Importe : {0}", Constantes.Moneda(ETipos.TipoMoneda.Soles))
              ' lblVPercepcion.Text = String.Format("Percepción : {0}", Constantes.Moneda(ETipos.TipoMoneda.Soles))
               lblTotal.Text = String.Format("Total : {0}", Constantes.Moneda(ETipos.TipoMoneda.Soles))
               lblTotalPagar.Text = String.Format("Total Pagar : {0}", Constantes.Moneda(ETipos.TipoMoneda.Soles))
            Case ETipos.TipoMoneda.Dolares
               If IsNothing(m_event_docsventa) Then
                  lbligv.Text = String.Format("I.G.V. {1:0#}%: {0}", Constantes.Moneda(ETipos.TipoMoneda.Dolares), Parametros.GetParametro(EParametros.TipoParametros.PIGV))
               Else
                  lbligv.Text = String.Format("I.G.V. {1:0#}%: {0}", Constantes.Moneda(ETipos.TipoMoneda.Dolares), m_event_docsventa.DOCVE_PorcentajeIGV)
               End If
               lblImporte.Text = String.Format("Importe : {0}", Constantes.Moneda(ETipos.TipoMoneda.Dolares))
               'lblVPercepcion.Text = String.Format("Percepción : {0}", Constantes.Moneda(ETipos.TipoMoneda.Dolares))
               lblTotal.Text = String.Format("Total : {0}", Constantes.Moneda(ETipos.TipoMoneda.Dolares))
               lblTotalPagar.Text = String.Format("Total Pagar : {0}", Constantes.Moneda(ETipos.TipoMoneda.Dolares))
            Case Else
               setEtiqueta(ETipos.TipoMoneda.Soles)
         End Select
      Catch ex As Exception
         Throw ex
      End Try
   End Sub

Private Sub c1grdOrdenes_OwnerDrawCell( sender As Object,  e As OwnerDrawCellEventArgs) Handles c1grdOrdenes.OwnerDrawCell
      
          Try
         If e.Row < c1grdOrdenes.Rows.Fixed OrElse e.Col < c1grdOrdenes.Cols.Fixed Then Return
         If c1grdOrdenes.Rows(e.Row)("ORDEN_Estado") = ACEVentas.Constantes.getEstado(ACEVentas.Constantes.Estado.Anulado) Then
            e.Style = c1grdOrdenes.Styles("Anulado")
         End If
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso cambia de color", ex)
      End Try
End Sub

Private Sub c1grdGuiasRemision_OwnerDrawCell( sender As Object,  e As OwnerDrawCellEventArgs) Handles c1grdGuiasRemision.OwnerDrawCell
          Try
         If e.Row < c1grdGuiasRemision.Rows.Fixed OrElse e.Col < c1grdGuiasRemision.Cols.Fixed Then Return
         If c1grdGuiasRemision.Rows(e.Row)("GUIAR_Estado") = ACEVentas.Constantes.getEstado(ACEVentas.Constantes.Estado.Anulado) Then
            e.Style = c1grdGuiasRemision.Styles("Anulado")
         End If
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso cambia de color", ex)
      End Try
End Sub

Private Sub c1grdPendientes_OwnerDrawCell( sender As Object,  e As OwnerDrawCellEventArgs) Handles c1grdPendientes.OwnerDrawCell
        
          Try
         If e.Row < c1grdPendientes.Rows.Fixed OrElse e.Col < c1grdPendientes.Cols.Fixed Then Return
         If c1grdPendientes.Cols(e.Col).Name = "DOCVD_Cantidad" Then
            If c1grdPendientes.Rows(e.Row)("DOCVD_Cantidad") > 0 Then
               e.Style = c1grdPendientes.Styles("Total")
            End If
         End If
         If c1grdPendientes.Cols(e.Col).Name = "Entregado" Then
            If c1grdPendientes.Rows(e.Row)("Entregado") > 0 Then
               e.Style = c1grdPendientes.Styles("Entregado")
            End If
         End If

         If c1grdPendientes.Cols(e.Col).Name = "GUIRD_Cantidad" Then
            If c1grdPendientes.Rows(e.Row)("GUIRD_Cantidad") > 0 Then
               e.Style = c1grdPendientes.Styles("Cantidad")
            End If
         End If

      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso cambia de color", ex)
      End Try
End Sub

Private Sub c1grdNotasCredito_OwnerDrawCell( sender As Object,  e As OwnerDrawCellEventArgs) Handles c1grdNotasCredito.OwnerDrawCell
          Try
            If e.Row < c1grdNotasCredito.Rows.Fixed OrElse e.Col < c1grdNotasCredito.Cols.Fixed Then Return
            If c1grdNotasCredito.Rows(e.Row)("DOCVE_Estado") = ACEVentas.Constantes.getEstado(ACEVentas.Constantes.Estado.Anulado) Then
                e.Style = c1grdNotasCredito.Styles("Anulado")
            End If
        Catch ex As Exception
            ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso cambia de color", ex)
        End Try

End Sub


Private Sub c1grdGuiasRemision_DoubleClick( sender As Object,  e As EventArgs) Handles c1grdGuiasRemision.DoubleClick
         Try
            
            If Not IsNothing(bs_guias) Then
                If Not IsNothing(bs_guias.Current) Then
                    Dim x_codigo As String = CType(bs_guias.Current, ACEVentas.EDIST_GuiasRemision).GUIAR_Codigo
                   
                   
                     Dim _frm As New RGuias(True,x_codigo) With {.StartPosition = FormStartPosition.CenterScreen}
                     If _frm.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                        
                     End If
                Else
                    ACControles.ACDialogos.ACMostrarMensajeInformacion(String.Format("Información: {0}", Me.Text), "No se puede visualizar por que no ha seleccionado ningun registro")
                End If
            Else
                ACControles.ACDialogos.ACMostrarMensajeInformacion(String.Format("Información: {0}", Me.Text), "No se puede visualizar por que no se ha cargado ningun registro")
            End If
           
        Catch ex As Exception
            ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso Visualizar Documento", ex)
        End Try
End Sub

Private Sub c1grdOrdenes_DoubleClick( sender As Object,  e As EventArgs) Handles c1grdOrdenes.DoubleClick
         Try
            
            If Not IsNothing(bs_ordenes) Then
                If Not IsNothing(bs_ordenes.Current) Then
                    Dim x_codigo As String = CType(bs_ordenes.Current, ACEVentas.EDIST_Ordenes).ORDEN_Codigo
                   
                   
                     Dim _frm As New ROrdenesIngreso(True,x_codigo) With {.StartPosition = FormStartPosition.CenterScreen}
                     If _frm.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                        
                     End If
                Else
                    ACControles.ACDialogos.ACMostrarMensajeInformacion(String.Format("Información: {0}", Me.Text), "No se puede visualizar por que no ha seleccionado ningun registro")
                End If
            Else
                ACControles.ACDialogos.ACMostrarMensajeInformacion(String.Format("Información: {0}", Me.Text), "No se puede visualizar por que no se ha cargado ningun registro")
            End If
           
        Catch ex As Exception
            ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso Visualizar Documento", ex)
        End Try
End Sub

Private Sub btnRevision2_Click( sender As Object,  e As EventArgs) Handles btnRevision2.Click
           Try

            if m_reporte.Ventas_VerificacionControl(GApp.Sucursal,m_event_docsventa.Docve_Codigo,GApp.EUsuario.USER_CodUsr,"2") Then
                'Timer1.Start()
                'Timer1.Interval=3
                if ACControles.ACDialogos.ACMostrarMensajeSatisfactorio(String.Format("Información:"), String.Format("Verificacion Correcta" ))

                    acTool_ACBtnVolver_Click(Nothing,Nothing)
                    actualizar2()
                    'btnProcesar_Click(Nothing,Nothing)
                    
                        if(Columna =c1grdReporte.Rows.Count)
                             c1grdReporte.TopRow=columna-10
                            c1grdReporte.Select(columna-1,0) 
                        Else If (columna-10 <=0)Then
                            c1grdReporte.TopRow=1
                            c1grdReporte.Select(columna,0)
                       Else 
                            c1grdReporte.TopRow=columna-10
                            c1grdReporte.Select(columna,0)
                        End If
                        columna=0
                end If
                'c1grdReporte.RowSel
            End If
            LiberarMemoria()
        Catch ex As Exception
            ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), Colecciones.getError("00000"), ex)
        End Try
End Sub
End Class



