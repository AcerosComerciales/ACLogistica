Imports ACBLogistica
Imports ACBVentas

Imports ACELogistica
Imports ACEVentas

Imports ACFramework
Imports ACSeguridad
Imports C1.Win.C1FlexGrid

Public Class MCompras
#Region " Variables "
    Private managerABAS_DocsCompra As BABAS_DocsCompra
    Private managerABAS_OrdenesCompra As BABAS_OrdenesCompra
    ' Private managerGenerarDocsVenta As BGenerarDocsVenta
    Private managerEntidades As BEntidades


    Private bs_documentos As BindingSource
    Private bs_detdocumentos As BindingSource
    Private bs_tipodocumento As BindingSource
    Private bs_tipodocfacturacion As BindingSource
    Private bs_series As BindingSource
    Private bs_letras As BindingSource
    Private bs_pagos As BindingSource
    Private bs_notas As BindingSource
    Private bs_doctrasaladodetalle As BindingSource
    Private bs_docalmacenentregas As BindingSource
    Private m_eabas_docscompra As EABAS_DocsCompra
    Private m_listBindHelper As List(Of ACBindHelper)
    Private m_habilitargrabar As Boolean

    Private m_permisocuadres As Boolean = False
    Private m_perverareadministracion As Boolean = False

    Private m_paseanulacion As Boolean = False

    Private m_order As Integer = 1

    Private chk_genguia As Integer = 0
    Private chk_paseanula As Integer = 0
    Private chk_impdocu As Integer = 0
#End Region

#Region " Propiedades "

#End Region

#Region " Constructores "

    'R 20-12-2017

    Private _valor As String
    Public Sub New(valor As String)
        InitializeComponent()
        Try
            _valor = valor
        Catch ex As Exception
            ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "No se puede cargar los controles iniciales", ex)
        End Try
    End Sub

    Public Sub New(ByVal x_icono As System.Drawing.Bitmap)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Try
            Inicializacion(x_icono)
        Catch ex As Exception
            ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "No se puede cargar los controles iniciales", ex)
        End Try
    End Sub

    Public Sub New(ByVal x_icono As System.Drawing.Bitmap, ByVal x_docco_codigo As String, ByVal x_entid_codigo As String)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Try
            Inicializacion(x_icono)
            Me.MaximizeBox = False
            cargar(x_docco_codigo, x_entid_codigo)
            actool.ACTipoToolBar = ACControles.ACToolBarMantHorizontalNew.tipoToolBar.ToolSalir
        Catch ex As Exception
            ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "No se puede cargar los controles iniciales", ex)
        End Try
    End Sub

    Private Sub Inicializacion(ByVal x_icono As System.Drawing.Bitmap)
        Try
            tabMantenimiento.HideTabsMode = Crownwood.DotNetMagic.Controls.HideTabsModes.HideAlways
            tabMantenimiento.SelectedTab = tabBusqueda

            managerABAS_DocsCompra = New BABAS_DocsCompra()
            managerABAS_OrdenesCompra = New BABAS_OrdenesCompra()
            '  managerGenerarDocsVenta = New BGenerarDocsVenta(GApp.PuntoVenta, GApp.Periodo, GApp.Zona, GApp.Sucursal)
            managerEntidades = New BEntidades()

            formatearGrilla()
            CargarCombos()
            setInstancia(ACFramework.ACUtilitarios.ACSetInstancia.Deshacer)
            chkAnulada.Enabled = False

            AcFecha.ACFechaChecked = True

            actool.ACBtnSalirVisible = True
            bnavBusqueda.Visible = True
            ' Permisos
            m_habilitargrabar = False

            'txtBusSerie.Visible = True

            tsbtnAnularEntregaAlmacen.Visible = False
            tsbtnAnularTodoEntregaAlmacen.Visible = False
            m_permisocuadres = False
            tbcDetalles.TabPages.Remove(tpgLetras)
            'tbcDetalles.TabPages.Remove(tpgNotas)
            tbcDetalles.TabPages.Remove(tpgDetAnulacion)
            tbcDetalles.TabPages.Remove(tpgCheques)
            tbcDetalles.TabPages.Remove(_tpgOrden)
            tbcDetalles.TabPages.Remove(tpgAlmacen)


            'Dim _validate As ACValidarUsuario
            '_validate = New ACValidarUsuario(GApp.DataConexion, GApp.DataUsuario, ACValidarUsuario.Operacion.ValidarVariosProcesos)
            'For Each item As ACSeguridad.EProcesos In _validate.ListProcesos
            '    Select Case item.PROC_Codigo
            '        'Case Procesos.getProceso(Procesos.TipoProcesos.AdmVen_ModVentasAPendienteEntrega)
            '        '    cmbEntrega.Enabled = True
            '        '    m_habilitargrabar = True
            '        'Case Procesos.getProceso(Procesos.TipoProcesos.AdmVen_BuscarDocVtaPtosVnta)
            '        '    m_habilitarbuscarptovta = True
            '        '    cmbBusSerie.Visible = False
            '        '    txtBusSerie.Visible = True
            '        'Case Procesos.getProceso(Procesos.TipoProcesos.Caj_AnularPago)
            '        '    tsbtnAnularPago.Visible = True
            '        'Case Procesos.getProceso(Procesos.TipoProcesos.AdmVen_VerAreaAdministracion)
            '        '    m_perverareadministracion = True
            '        '    chkPermisoGenGuias.Enabled = True
            '        Case Procesos.getProceso(Procesos.TipoProcesos.AdmVen_PermitirDarPaseParaAnularDocumentos)
            '            m_paseanulacion = True
            '            chkPaseAnularDocumentos.Enabled = True

            '        Case Procesos.getProceso(Procesos.TipoProcesos.Alm_AnularEntrega) '-----'''''20240125
            '            tsbtnAnularEntregaAlmacen.Visible = True
            '            tsbtnAnularTodoEntregaAlmacen.Visible = True
            '    End Select
            'Next
            If Not (m_perverareadministracion Or m_paseanulacion) Then tbcDetalles.TabPages.Remove(tpgAdmin)

            'If Not m_paseanulacion Then tbcDetalles.TabPages.Remove(tpgAdmin)
            '' Cambiar Icono
            If Not IsNothing(x_icono) Then Me.Icon = Icon.FromHandle(x_icono.GetHicon)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
#End Region

#Region " Metodos "

#Region " Utilitarios "
    Private Sub CargarCombos()
        Try '' Documento de Venta 
            Dim listDoc As New List(Of ETipos)
            Dim listDocBus As New List(Of ETipos)
            For Each Item As ETipos In Colecciones.TiposDocComprobante()
                listDoc.Add(Item.Clone)
                listDocBus.Add(Item.Clone)
            Next
            bs_tipodocumento = New BindingSource() : bs_tipodocumento.DataSource = listDocBus
            'AddHandler bs_tipodocumento.CurrentChanged, AddressOf bs_tipodocumento_CurrentChanged
            'bs_tipodocumento_CurrentChanged(Nothing, Nothing)
            'ACFramework.ACUtilitarios.ACCargaCombo(cmbTipoDocumento, listDoc, "TIPOS_Descripcion", "TIPOS_Codigo")
            ACFramework.ACUtilitarios.ACCargaCombo(cmbDocumento, bs_tipodocumento, "TIPOS_Descripcion", "TIPOS_Codigo")

            bs_tipodocfacturacion = New BindingSource()
            bs_tipodocfacturacion.DataSource = Colecciones.TiposDocCompFacturacion()
            ACFramework.ACUtilitarios.ACCargaCombo(cmbTipoDocumento, bs_tipodocfacturacion, "TIPOS_Descripcion", "TIPOS_Codigo")
            ' AddHandler bs_tipodocfacturacion.CurrentChanged   , AddressOf bs_documentosventa_CurrentChanged
            ' bs_documentosventa_CurrentChanged(Nothing, Nothing)

            ACFramework.ACUtilitarios.ACCargaCombo(cmbMoneda, Colecciones.Tipos(ETipos.MyTipos.TipoMoneda), "TIPOS_DescCorta", "TIPOS_Codigo")
            AddHandler cmbMoneda.SelectedIndexChanged, AddressOf cmbMoneda_SelectedIndexChanged
            cmbMoneda_SelectedIndexChanged(Nothing, Nothing)

            ACFramework.ACUtilitarios.ACCargaCombo(cmbCondPago, Colecciones.Tipos(ETipos.MyTipos.CondicionPago), "TIPOS_Descripcion", "TIPOS_Codigo")


        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub formatearGrilla()
        Dim index As Integer = 1
        Try
            ACFrameworkC1.ACUtilitarios.ACFormatearGrilla(c1grdBusqueda, 1, 1, 14, 1, 2)
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Fecha", "DOCCO_FechaDocumento", "DOCCO_FechaDocumento", 150, True, False, "System.DateTime", Constantes.Formatofecha) : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Documento", "Documento", "Documento", 150, True, False, "System.String") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Codigo", "DOCCO_Codigo", "DOCCO_Codigo", 150, False, False, "System.String") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "R.U.C.", "ENTID_CodigoProveedor", "ENTID_CodigoProveedor", 150, True, False, "System.String") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Proveedor", "ENTID_Proveedor", "ENTID_Proveedor", 150, True, False, "System.String") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Moneda", "TIPOS_TipoMoneda", "TIPOS_TipoMoneda", 150, True, False, "System.String") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Total Pagar", "DOCCO_TotalCompra", "DOCCO_TotalCompra", 150, True, False, "System.Decimal", Parametros.GetParametro(EParametros.TipoParametros.pg_FMondo2d)) : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Numero", "DOCCO_Numero", "DOCCO_Numero", 150, False, False, "System.String") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Usuario", "Usuario", "Usuario", 150, True, False, "System.String") : index += 1
            ' ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Vendedor", "ENTID_Vendedor", "ENTID_Vendedor", 150, True, False, "System.String") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Estado", "DOCCO_Estado_Text", "DOCCO_Estado_Text", 150, True, False, "System.String") : index += 1
            ' ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Condición", "Condicion", "Condicion", 150, True, False, "System.String") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Estado", "DOCCO_Estado", "DOCCO_Estado", 150, False, False, "System.String") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Tipo Pago", "TIPOS_TipoPago", "TIPOS_TipoPago", 150, True, False, "System.String") : index += 1
            ' 'ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Impresiones", "DOCVE_Impresiones", "DOCVE_Impresiones", 150, True, False, "System.String") : index += 1
            ' ' ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Sunat", "generado", "generado", 150, True, False, "System.String") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "O/C", "ORDEN_Codigo", "ORDEN_Codigo", 150, True, False, "System.String") : index += 1

            c1grdBusqueda.AllowEditing = False
            c1grdBusqueda.Styles.Alternate.BackColor = Color.LightGray
            c1grdBusqueda.Styles.Fixed.TextAlign = TextAlignEnum.CenterCenter
            c1grdBusqueda.Styles.Highlight.BackColor = Color.Gray
            c1grdBusqueda.SelectionMode = SelectionModeEnum.Row
            c1grdBusqueda.AllowSorting = AllowSortingEnum.SingleColumn

            Dim t As C1.Win.C1FlexGrid.CellStyle = c1grdBusqueda.Styles.Add("Facturado")
            t.BackColor = Color.LightGreen
            t.ForeColor = Color.DarkBlue
            t.Font = New Font(c1grdBusqueda.Font, FontStyle.Regular)


            Dim j As C1.Win.C1FlexGrid.CellStyle = c1grdBusqueda.Styles.Add("Alinear")
            j.TextAlign = TextAlignEnum.CenterCenter
            j.Font = New Font(c1grdBusqueda.Font, FontStyle.Regular)



            Dim u As C1.Win.C1FlexGrid.CellStyle = c1grdBusqueda.Styles.Add("Facturar")
            u.BackColor = Color.Green
            u.ForeColor = Color.White
            u.Font = New Font(c1grdBusqueda.Font, FontStyle.Regular)

            Dim d As C1.Win.C1FlexGrid.CellStyle = c1grdBusqueda.Styles.Add("Anulado")
            d.BackColor = Color.Red
            d.ForeColor = Color.White
            d.Font = New Font(c1grdBusqueda.Font, FontStyle.Bold)
            c1grdBusqueda.DrawMode = C1.Win.C1FlexGrid.DrawModeEnum.OwnerDraw

            index = 1
            ACFrameworkC1.ACUtilitarios.ACFormatearGrilla(c1grdDetalle, 1, 1, 7, 1, 0)
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdDetalle, index, "Item", "DOCCD_Item", "DOCCD_Item", 110, True, False, "System.Integer") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdDetalle, index, "Codigo", "ARTIC_Codigo", "ARTIC_Codigo", 110, True, False, "System.String") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdDetalle, index, "Descripción", "ARTIC_Descripcion", "ARTIC_Descripcion", 319, True, True, "System.String") : index += 1
            ' ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdDetalle, index, "Lista", "LPREC_Id", "LPREC_Id", 110, True, True, "System.Integer") : index += 1
            ' ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdDetalle, index, "Percepcion", "DOCCD_Percepcion", "DOCCD_Percepcion", 110, True, True, "System.Boolean") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdDetalle, index, "Cantidad", "DOCCD_Cantidad", "DOCCD_Cantidad", 110, True, True, "System.Decimal", Parametros.GetParametro(EParametros.TipoParametros.pg_FMondo2d)) : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdDetalle, index, "Precio", "DOCCD_PrecioUnitario", "DOCCD_PrecioUnitario", 110, True, True, "System.Decimal", Parametros.GetParametro(EParametros.TipoParametros.pg_FMondo2d)) : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdDetalle, index, "Sub-Importe", "DOCCD_SubImporteCompra", "DOCCD_SubImporteCompra", 100, True, True, "System.Decimal", Parametros.GetParametro(EParametros.TipoParametros.pg_FMondo2d)) : index += 1
            c1grdDetalle.AllowEditing = False
            c1grdDetalle.AutoResize = False
            c1grdDetalle.Cols(0).Width = 18
            c1grdDetalle.Styles.Alternate.BackColor = Color.LightGray
            c1grdDetalle.Styles.Fixed.TextAlign = TextAlignEnum.CenterCenter
            c1grdDetalle.Styles.Highlight.BackColor = Color.Gray
            c1grdDetalle.SelectionMode = SelectionModeEnum.Row
            c1grdDetalle.AllowResizing = AllowResizingEnum.None


            index = 1
            ACFrameworkC1.ACUtilitarios.ACFormatearGrilla(c1grdLetras, 1, 1, 8, 1, 0)
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdLetras, index, "Codigo", "DPAGO_Id", "DPAGO_Id", 110, True, False, "System.String", "00000") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdLetras, index, "Fecha", "DPAGO_Fecha", "DPAGO_Fecha", 319, True, True, "System.String", Parametros.GetParametro(EParametros.TipoParametros.pg_FormatoFecha)) : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdLetras, index, "Banco", "BANCO_Descripcion", "BANCO_Descripcion", 319, True, True, "System.String") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdLetras, index, "Numero", "DPAGO_Numero", "DPAGO_Numero", 110, True, True, "System.String") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdLetras, index, "Documento", "DocCompra", "DocCompra", 319, True, True, "System.String") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdLetras, index, "Moneda", "TIPOS_TipoMoneda", "TIPOS_TipoMoneda", 110, True, True, "System.String") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdLetras, index, "Importe", "DPAGO_Importe", "DPAGO_Importe", 100, True, True, "System.Decimal", Parametros.GetParametro(EParametros.TipoParametros.pg_FMondo2d)) : index += 1
            c1grdLetras.AllowEditing = False
            c1grdLetras.AutoResize = True
            c1grdLetras.Cols(0).Width = 18
            c1grdLetras.Styles.Alternate.BackColor = Color.LightGray
            c1grdLetras.Styles.Fixed.TextAlign = TextAlignEnum.CenterCenter
            c1grdLetras.Styles.Highlight.BackColor = Color.Gray
            c1grdLetras.SelectionMode = SelectionModeEnum.Row
            c1grdLetras.AllowResizing = AllowResizingEnum.None

            index = 1
            ACFrameworkC1.ACUtilitarios.ACFormatearGrilla(c1grdGuiasRemision, 1, 1, 7, 1, 0)
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdGuiasRemision, index, "Fecha Emisión", "INGCO_FechaIngreso", "INGCO_FechaIngreso", 150, True, False, "System.DateTime") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdGuiasRemision, index, "Doc. Guia", "INGCO_Codigo", "INGCO_Codigo", 150, True, False, "System.String") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdGuiasRemision, index, "Almacen", "ALMAC_Descripcion", "ALMAC_Descripcion", 150, True, False, "System.String") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdGuiasRemision, index, "Usuario", "ENTID_CodUsuario", "ENTID_CodUsuario", 150, True, False, "System.String") : index += 1
            'ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdGuiasRemision, index, "Conductor", "GUIAR_DescripcionConductor", "GUIAR_DescripcionConductor", 150, True, False, "System.String") : index += 1
            ' ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdGuiasRemision, index, "Vehiculo", "GUIAR_DescripcionVehiculo", "GUIAR_DescripcionVehiculo", 150, True, False, "System.String") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdGuiasRemision, index, "Total Peso", "INGCO_PesoTotal", "INGCO_PesoTotal", 150, True, False, "System.Decimal") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdGuiasRemision, index, "Estado", "INGCO_Estado", "INGCO_Estado", 150, False, False, "System.Decimal") : index += 1
            'ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdGuiasRemision, index, "Tipo Transporte", "GUIAR_TipoGuia", "GUIAR_TipoGuia", 150, True, False, "System.Decimal") : index += 1

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
            ACFrameworkC1.ACUtilitarios.ACFormatearGrilla(c1grdPagos, 1, 1, 9, 1, 0)
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdPagos, index, "Cod. Caja", "CAJA_Id", "CAJA_Id", 80, True, False, "System.Integer", "0000000") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdPagos, index, "Fecha", "CAJA_Fecha", "CAJA_Fecha", 350, True, False, "System.DateTime", Parametros.GetParametro(EParametros.TipoParametros.pg_FormatoFecha)) : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdPagos, index, "Fecha Proceso", "CAJA_FechaPago", "CAJA_FechaPago", 350, True, False, "System.DateTime", Parametros.GetParametro(EParametros.TipoParametros.pg_FormatoFecha)) : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdPagos, index, "Importe", "CAJA_Importe", "CAJA_Importe", 100, True, False, "System.Decimal", Parametros.GetParametro(ACEVentas.EParametros.TipoParametros.pg_FMondo2d)) : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdPagos, index, "Cuenta", "TIPOS_CodTipoOrigen", "TIPOS_CodTipoOrigen", 90, True, False, "System.Integer") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdPagos, index, "Transacción", "TIPOS_CodTransaccion", "TIPOS_CodTransaccion", 80, True, False, "System.String") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdPagos, index, "Moneda", "TIPOS_TipoMoneda", "TIPOS_TipoMoneda", 80, True, False, "System.String") : index += 1

            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdPagos, index, "Glosa", "CAJA_Glosa", "CAJA_Glosa", 80, True, False, "System.String") : index += 1


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
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdPendientes, index, "Item", "INGCD_Item", "INGCD_Item", 80, False, False, "System.Integer", "#0") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdPendientes, index, "Almacen", "ALMAC_Descripcion", "ALMAC_Descripcion", 80, False, False, "System.String") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdPendientes, index, "Codigo", "ARTIC_Codigo", "ARTIC_Codigo", 80, True, False, "System.String") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdPendientes, index, "Descripción", "ARTIC_Descripcion", "ARTIC_Descripcion", 191, True, False, "System.String") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdPendientes, index, "Unidad", "TIPOS_UnidadMedidaCorta", "TIPOS_UnidadMedidaCorta", 69, True, False, "System.String") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdPendientes, index, "Total Doc.", "DOCCD_Cantidad", "DOCCD_Cantidad", 75, True, False, "System.Decimal", Parametros.GetParametro(EParametros.TipoParametros.pg_FMondo2d)) : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdPendientes, index, "Entregado", "Entregado", "Entregado", 75, True, False, "System.Decimal", Parametros.GetParametro(EParametros.TipoParametros.pg_FMondo2d)) : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdPendientes, index, "Diferencia", "Diferencia", "Diferencia", 75, False, False, "System.Decimal", Parametros.GetParametro(EParametros.TipoParametros.pg_FMondo2d)) : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdPendientes, index, "Pendiente", "INGCD_Cantidad", "INGCD_Cantidad", 75, True, False, "System.Decimal", Parametros.GetParametro(EParametros.TipoParametros.pg_FMondo2d)) : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdPendientes, index, "Peso", "INGCD_PesoUnitario", "INGCD_PesoUnitario", 75, True, False, "System.Decimal", Parametros.GetParametro(EParametros.TipoParametros.pg_FMondo4d)) : index += 1
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

            Dim tt As C1.Win.C1FlexGrid.CellStyle = c1grdPendientes.Styles.Add("Total")
            tt.BackColor = Color.LightGreen
            tt.ForeColor = Color.DarkBlue
            tt.Font = New Font(c1grdPendientes.Font, FontStyle.Regular)

            Dim uu As C1.Win.C1FlexGrid.CellStyle = c1grdPendientes.Styles.Add("Entregado")
            uu.BackColor = Color.DarkSlateBlue
            uu.ForeColor = Color.White
            uu.Font = New Font(c1grdPendientes.Font, FontStyle.Regular)


            Dim dd As C1.Win.C1FlexGrid.CellStyle = c1grdPendientes.Styles.Add("Cantidad")
            dd.BackColor = Color.Red
            dd.ForeColor = Color.White
            dd.Font = New Font(c1grdPendientes.Font, FontStyle.Bold)
            c1grdPendientes.DrawMode = C1.Win.C1FlexGrid.DrawModeEnum.OwnerDraw

            '_M
            index = 1
            ACFrameworkC1.ACUtilitarios.ACFormatearGrilla(c1grdNotasCredito, 1, 1, 7, 1, 0)
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdNotasCredito, index, "Fecha Documento", "DOCCO_FechaDocumento", "DOCCO_FechaDocumento", 150, True, False, "System.DateTime") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdNotasCredito, index, "Doc. Nota", "Documento", "Documento", 150, True, False, "System.String") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdNotasCredito, index, "Peso", "DOCCO_TotalPeso", "DOCCO_TotalPeso", 150, True, False, "System.String") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdNotasCredito, index, "Fecha Ingreso - Almacen", "DOCCO_FechaPago", "DOCCO_FecPago", 150, True, False, "System.DateTime") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdNotasCredito, index, "Total Monto", "DOCCO_TotalCompra", "DOCCO_TotalCompra", 150, True, False, "System.Decimal") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdNotasCredito, index, "Estado", "DOCCO_Estado", "DOCCO_Estado", 150, False, False, "System.Decimal") : index += 1

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
            ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Text), "No se puede dar formato a la grilla", ex)
        End Try
    End Sub

    Private Sub Ordenar(ByVal x_columna As String)
        Dim _ordenador As New ACOrdenador(Of EABAS_DocsCompra)
        Try
            If m_order = 2 Then x_columna += " DESC"
            _ordenador.ACOrdenamiento = x_columna
            CType(bs_documentos.DataSource, List(Of EABAS_DocsCompra)).Sort(_ordenador)
            c1grdBusqueda.Refresh()
            m_order = IIf(m_order = 1, 2, 1)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub setInstancia(ByVal x_opcion As ACFramework.ACUtilitarios.ACSetInstancia)
        Try
            actool.ACBtnModificarVisible = False
            actool.ACBtnGrabarVisible = False
            actool.ACBtnAnularVisible = False
            actool.ACBtnEliminarVisible = False

            Select Case x_opcion
                Case ACFramework.ACUtilitarios.ACSetInstancia.Nuevo

                Case ACFramework.ACUtilitarios.ACSetInstancia.Guardar

                Case ACFramework.ACUtilitarios.ACSetInstancia.Modificado

                Case ACFramework.ACUtilitarios.ACSetInstancia.Previsualizar
                    '' Habilitar Botones
                    actool.ACBtnAnularVisible = False
                    actool.ACBtnEliminarVisible = False
                    ' actool.ACBtnImprimirVisible = True
                    '' Inicializar Controles
                    ACFramework.ACUtilitarios.ACSetControl(grpDetalleDocumento, True, ACFramework.ACUtilitarios.TipoPropiedad.ACReadOnly)
                    '' DesHabilitar Controles
                    actxaCliRazonSocial.ACAyuda.Enabled = False
                    actxaCliRazonSocial.ACActivarAyuda = False
                    actxaCliRuc.ACAyuda.Enabled = False
                    actxaCliRuc.ACActivarAyuda = False
                
                    'pnlCabHeader.Enabled = False
                    dtpFecCaja.Enabled = False
                    dtpFecEmision.Enabled = False
                    txtOrdenCompra.Enabled = False
                    cmbDocumento.Enabled = False
                    txtSerie.Enabled = False
                    actxnNumero.Enabled = False

                    actool.setInstancia(ACControles.ACToolBarMantHorizontalNew.TipoInstancia.Nuevo)
                    actool.ACBtnGrabarVisible = False
                    tsbtnPrevisualizar.Visible = False
                    grpDocumento.Enabled = True
                    cmbDocumento.Enabled = False
                    txtSerie.Enabled = False
                    actxnNumero.ReadOnly = True
                    actxnPlazo.ReadOnly = False
                    dtpFecPlazo.Enabled = False
                    txtDirigida.ReadOnly = True
                    txtTelFax.ReadOnly = True
                    txtCotizacionC.ReadOnly = True
                    cmbMoneda.Enabled = False
                    cmbCondPago.Enabled = False
                    '' Detalles de Anulacion
                    dtpFechaAnulacion.Enabled = False
                    chkAnuladoCaja.Enabled = False
                    txtMotivoAnulacion.ReadOnly = True
                    '' Detalles Adicionales
                    actxaCodFacturador.ACAyuda.Enabled = False
                    actxaCodFacturador.ReadOnly = True
                    actxaCodFacturador.ACActivarAyuda = False
                    actxaDescFacturador.ACAyuda.Enabled = False
                    actxaDescFacturador.ReadOnly = True
                    actxaDescFacturador.ACActivarAyuda = False

                    actxaCodCotizador.ACAyuda.Enabled = False
                    actxaCodCotizador.ReadOnly = True
                    actxaCodCotizador.ACActivarAyuda = False
                    actxaDescCotizador.ACAyuda.Enabled = False
                    actxaDescCotizador.ReadOnly = True
                    actxaDescCotizador.ACActivarAyuda = False

                    txtObservaciones.ReadOnly = True
                    chkAnulada.Checked = False
                    tbcDetalles.TabPages.Add(tpgDetAnulacion)
                    actool.ACBtnGrabarVisible = m_habilitargrabar

                    '' Asignar Permisos
                    Dim _validate As ACValidarUsuario
                    _validate = New ACValidarUsuario(GApp.DataConexion, GApp.DataUsuario, ACValidarUsuario.Operacion.ValidarVariosProcesos)
                    For Each item As ACSeguridad.EProcesos In _validate.ListProcesos
                        Select Case item.PROC_Codigo
                            Case Procesos.getProceso(Procesos.TipoProcesos.AdmVen_EliminarFacturas)
                                actool.ACBtnEliminarVisible = True
                            Case Procesos.getProceso(Procesos.TipoProcesos.AdmVen_AnularFacturasMismoDia)
                                actool.ACBtnAnularVisible = True
                            Case Procesos.getProceso(Procesos.TipoProcesos.AdmVen_AnularFacturasFecAnterior)
                                actool.ACBtnAnularVisible = True
                            Case Procesos.getProceso(Procesos.TipoProcesos.AdmVen_ImprimirFactura)
                                actool.ACBtnImprimirVisible = True '''''este essss

                        End Select
                    Next

                Case ACFramework.ACUtilitarios.ACSetInstancia.Deshacer
                    tsbtnPrevisualizar.Visible = True
                    acpnlTitulo.Active = False
                    pnlDetProductos.BackColor = Color.FromArgb(3, 55, 145)
                Case Else

            End Select

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
#End Region

#Region " Cargar Datos "
    Private Function cargar_compras(ByVal x_codigo As String) As Boolean

        Try
            If managerABAS_DocsCompra.Cargar(x_codigo, True) Then
                '' Setear Valores
                'setInstancia(ACFramework.ACUtilitarios.ACSetInstancia.Previsualizar)
                '' Cargar
                m_eabas_docscompra = New EABAS_DocsCompra()
                m_eabas_docscompra = managerABAS_DocsCompra.ABAS_DocsCompra
                AsignarBinding()
                bs_detdocumentos = New BindingSource()
                bs_detdocumentos.DataSource = m_eabas_docscompra.ListEABAS_DocsCompraDetalle
                c1grdDetalle.DataSource = bs_detdocumentos
                bnavProductos.BindingSource = bs_detdocumentos

                Return True
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function cargar(ByVal x_codigo As String, ByVal x_entid_codigo As String) As Boolean
        Try
            If managerABAS_DocsCompra.Cargar(x_codigo, x_entid_codigo, True) Then
                '' Setear Valores
                setInstancia(ACFramework.ACUtilitarios.ACSetInstancia.Previsualizar)
                '' Cargar
                m_eabas_docscompra = New EABAS_DocsCompra()
                m_eabas_docscompra = managerABAS_DocsCompra.ABAS_DocsCompra


                For Each Item As EABAS_DocsCompraDetalle In m_eabas_docscompra.ListEABAS_DocsCompraDetalle

                    Item.ARTIC_Descripcion = Item.ARTIC_Descripcion

                Next
                AsignarBinding()
                bs_detdocumentos = New BindingSource()
                bs_detdocumentos.DataSource = m_eabas_docscompra.ListEABAS_DocsCompraDetalle
                c1grdDetalle.DataSource = bs_detdocumentos
                bnavProductos.BindingSource = bs_detdocumentos
                tabMantenimiento.SelectedTab = tabDatos

                ''Cargar almacen
                '  CargarAlmacenEntregas()



                '' Cargar Cliente
                'cargarCliente(m_event_docsventa.ENTID_CodigoCliente)

                'R 14/06/2017
                cargarProveedor(m_eabas_docscompra.ENTID_CodigoProveedor)
                ' Cargar Documentos de Pago
                '' Cargar Letras
                ' cargarLetras()
                '' Cargar Docmento
                cmbDocumento.SelectedValue = m_eabas_docscompra.TIPOS_CodTipoDocumento
                txtSerie.Text = m_eabas_docscompra.DOCCO_Serie
                actxnNumero.Text = m_eabas_docscompra.DOCCO_Numero
                actxnPercepcionMO.Text = actxnPercepcion.Text
                c1grdDetalle.AutoSizeCols()
                '' Cargar Guias
                Dim _generarguias As New BABAS_IngresosCompra()
                _generarguias.GuiasXDocumento(m_eabas_docscompra.DOCCO_Codigo, m_eabas_docscompra.ENTID_CodigoProveedor, GApp.Almacen)
                Dim bs_guias As New BindingSource
                bs_guias.DataSource = _generarguias.ListABAS_IngresosCompra
                c1grdGuiasRemision.DataSource = bs_guias
                bnavGuiasRemision.BindingSource = bs_guias
                ' '' Cargar Ordenes
                'Dim _generarOrdenes As New BGenerarOrdenes(GApp.Periodo)
                '_generarOrdenes.OrdenesXDocumento(m_event_docsventa.DOCVE_Codigo, GApp.PuntoVenta)
                'Dim bs_ordenes As New BindingSource
                'bs_ordenes.DataSource = _generarOrdenes.ListDIST_Ordenes
                'c1grdOrdenes.DataSource = bs_ordenes
                'bnavOrdenes.BindingSource = bs_ordenes
                ''--------------------------
                '' Cargar Notas de Credito
                CargarNotas()


                '' Cargar Pagos
                CargarPagos()
                '' cargar Pendientes
                cargarPendientes()
                '' Admin
                'actxaCodUsrModFecPago.Text = m_event_docsventa.DOCVE_FPUsrMod
                'actxaDescUsrModFecPago.Text = m_event_docsventa.ENTID_UsrAdmin
                If Not m_eabas_docscompra.DOCCO_FechaPago.Year > 1900 Then m_eabas_docscompra.DOCCO_FechaPago = DateTime.Now
                '' Adicionales
                actxaCodFacturador.Text = m_eabas_docscompra.DOCCO_UsrCrea
                actxaDescFacturador.Text = m_eabas_docscompra.DOCCO_UsrCrea
                actxaCodCotizador.Text = m_eabas_docscompra.DOCCO_UsrCrea
                actxaDescCotizador.Text = m_eabas_docscompra.DOCCO_UsrCrea
                dtpFecCreacion.Value = m_eabas_docscompra.DOCCO_FecCrea
                dtpFecCreacion.Enabled = False
                dtpHoraCreacion.Value = m_eabas_docscompra.DOCCO_FecCrea
                dtpHoraCreacion.Enabled = False

                '  chkPaseAnularDocumentos.Checked = m_eabas_docscompra.DOCVE_PaseAnulacion
                '' Activar Titulo de Anulados
                If m_eabas_docscompra.DOCCO_Estado.Equals(Constantes.getEstado(Constantes.Estado.Anulado)) Then
                    chkAnulada.Checked = True
                    acpnlTitulo.Active = IIf(m_eabas_docscompra.DOCCO_Estado.Equals(Constantes.getEstado(Constantes.Estado.Anulado)), True, False)
                    pnlDetProductos.BackColor = Color.Maroon
                    actool.ACBtnImprimirEnabled = True

                    actool.ACBtnAnularEnabled = False
                    actool.ACBtnGrabarEnabled = False

                    'dtpFechaAnulacion.Value = m_eabas_docscompra.DOCVE_FecAnulacion
                    'txtMotivoAnulacion.Text = m_eabas_docscompra.DOCVE_MotivoAnulacion
                    'chkAnuladoCaja.Checked = m_eabas_docscompra.DOCVE_AnuladoCaja

                    tbcDetalles.SelectedTab = tpgDetAnulacion
                Else
                    tbcDetalles.TabPages.Remove(tpgDetAnulacion)
                    tpgDetAnulacion.Visible = False
                    tbcDetalles.SelectedTab = tpgAdicionales
                End If



                Return True
            End If
            Return False
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Private Sub CargarNotas()
        Try

            Dim _codigo As String = m_eabas_docscompra.DOCCO_Codigo
            Dim _entid_codigo As String = m_eabas_docscompra.ENTID_CodigoProveedor
            Dim _generarNotasC As New BGenerarDocsCompra()
            If Not _generarNotasC.DocumentosRelacionados(_codigo, _entid_codigo) Then
                _generarNotasC.ListABAS_NotasCreditoCompra = New List(Of EABAS_DocsCompra)
            End If
            bs_notas = New BindingSource
            bs_notas.DataSource = _generarNotasC.ListABAS_NotasCreditoCompra
            c1grdNotasCredito.DataSource = bs_notas
            bnavNotas.BindingSource = bs_notas
            '  c1grdNotasCredito.Subtotal(AggregateEnum.Sum, 0, -1, 6, "Total")
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub CargarPagos()
        Try
            Dim _codigo As String = m_eabas_docscompra.DOCCO_Codigo
            Dim _entid_codigo As String = m_eabas_docscompra.ENTID_CodigoProveedor
            Dim managerbadministracioncaja As New BCaja()
            If Not managerbadministracioncaja.ABAS_DOCCOSS_CajaPagos(_codigo, _entid_codigo) Then
                managerbadministracioncaja.List_CajaPagos = New List(Of ECaja)
            End If
            bs_pagos = New BindingSource
            bs_pagos.DataSource = managerbadministracioncaja.List_CajaPagos
            c1grdPagos.DataSource = bs_pagos
            bnavPagos.BindingSource = bs_pagos
            c1grdPagos.Subtotal(AggregateEnum.Sum, 0, -1, 4, "Total")
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub cargarPendientes()
        Try
            Dim x_codigo As String = m_eabas_docscompra.DOCCO_Codigo
            Dim x_entid_codigo As String = m_eabas_docscompra.ENTID_CodigoProveedor
            ' Dim x_estentrega As String = m_eabas_docscompra.DOCVE_EstEntrega
            Dim m_edist_docstraslado As New EABAS_IngresosCompra
            'If m_event_docsventa.DOCVE_EstEntrega.Equals(Colecciones.GetEntrega(Colecciones.TEntrega.Pendiente)) Then
            Dim managerGenerarGuias As New BABAS_IngresosCompra()

            If managerGenerarGuias.cargar(x_codigo, x_entid_codigo, GApp.Almacen, True) Then
                m_edist_docstraslado.Instanciar(ACEInstancia.Nuevo)
                m_edist_docstraslado.INGCO_Estado = EABAS_IngresosCompra.getEstado(EABAS_IngresosCompra.Estado.Ingresado)
                m_edist_docstraslado.ENTID_CodigoProveedor = managerGenerarGuias.ABAS_DocsCompra.ENTID_CodigoProveedor
                m_edist_docstraslado.DOCCO_Codigo = managerGenerarGuias.ABAS_DocsCompra.DOCCO_Codigo
                ' m_edist_docstraslado.ORDEN_Codigo = managerGenerarGuias.VENT_DocsVenta.ORDEN_Codigo

                '  m_edist_docstraslado.GUIAR_StockDevuelto = managerGenerarGuias.VENT_DocsVenta.DOCVE_StockDevuelto
                ' Cargar el detalle de la guia de remision
                m_edist_docstraslado.ListABAS_IngresosCompraDetalle = New List(Of EABAS_IngresosCompraDetalle)
                For Each Item As EABAS_DocsCompraDetalle In managerGenerarGuias.ABAS_DocsCompra.ListEABAS_DocsCompraDetalle
                    Dim _doct As New EABAS_IngresosCompraDetalle
                    _doct.ARTIC_Codigo = Item.ARTIC_Codigo
                    _doct.ARTIC_Descripcion = Item.ARTIC_Descripcion
                    If Item.Diferencia = Item.DOCCD_Cantidad Then
                        _doct.INGCD_Cantidad = Item.DOCCD_Cantidad
                    ElseIf Item.Diferencia = 0 Then
                        _doct.INGCD_Cantidad = 0
                    Else
                        _doct.INGCD_Cantidad = Item.Diferencia
                    End If

                    _doct.TIPOS_UnidadMedidaCorta = Item.TIPOS_UnidadMedidaCorta
                    '_doct.GUIRD_ItemDocumento = Item.DOCCD_Item
                    _doct.INGCD_PesoUnitario = Item.DOCCD_PesoUnitario
                    _doct.TIPOS_UnidadMedida = Item.TIPOS_UnidadMedida
                    _doct.TIPOS_CodUnidadMedida = Item.TIPOS_CodUnidadMedida
                    _doct.INGCD_Cantidad = Item.Diferencia
                    _doct.Diferencia = Item.Diferencia
                    _doct.Entregado = Item.Entregado
                    _doct.INGCD_Cantidad = Item.DOCCD_Cantidad
                    '_doct.ALMAC_Descripcion = Item.ALMAC_Descripcion
                    m_edist_docstraslado.ListABAS_IngresosCompraDetalle.Add(_doct)
                Next
            End If
            'Else
            '    m_edist_docstraslado.ListDIST_GuiasRemisionDetalle = New List(Of EDIST_GuiasRemisionDetalle)
            'End If
            bs_doctrasaladodetalle = New BindingSource
            bs_doctrasaladodetalle.DataSource = m_edist_docstraslado.ListABAS_IngresosCompraDetalle
            bnavProductos.BindingSource = bs_doctrasaladodetalle
            c1grdPendientes.DataSource = bs_doctrasaladodetalle
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    'Private Sub CargarAlmacenEntregas()

    '    Try
    '        Dim x_codigo As String = m_eabas_docscompra.DOCCO_Codigo
    '        Dim m_edist_docsalmacen As New ACELogistica.EVENT_DocsVenta

    '        Dim managerGenerarAlmacen As New BGenerarDocsVenta(GApp.Almacen, GApp.Periodo, GApp.Zona, GApp.Sucursal)
    '        If managerGenerarAlmacen.cargar(x_codigo, GApp.Almacen, True, False) Then

    '            ' Cargar el detalle de la guia de remision
    '            m_edist_docsalmacen.ListVENT_DocsVentaDetalle = New List(Of ACELogistica.EVENT_DocsVentaDetalle)

    '        End If

    '        bs_docalmacenentregas = New BindingSource
    '        bs_docalmacenentregas.DataSource = managerGenerarAlmacen.VENT_DocsVenta.ListVENT_DocsVentaDetalle
    '        bnavProductos.BindingSource = bs_docalmacenentregas
    '        c1grdAlmacen.DataSource = bs_docalmacenentregas
    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Sub


    'Private Sub bs_tipodocumento_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Try
    '        If Not IsNothing(bs_tipodocumento.Current) Then
    '            '' Cargar las series
    '            Dim managerGenerarDocsVenta As New BGenerarDocsVenta(GApp.PuntoVenta, GApp.Periodo, GApp.Zona, GApp.Sucursal)
    '            If managerGenerarDocsVenta.GetSeries(CType(bs_tipodocumento.Current, ETipos).TIPOS_Codigo) Then
    '                bs_series = New BindingSource
    '                bs_series.DataSource = managerGenerarDocsVenta.ListVENT_PVentDocumento
    '                ACFramework.ACUtilitarios.ACCargaCombo(cmbSerie, managerGenerarDocsVenta.ListVENT_PVentDocumento, "PVDOCU_Serie", "PVDOCU_Serie")
    '                'AddHandler bs_series.CurrentChanged, AddressOf bs_series_CurrentChanged
    '                'bs_series_CurrentChanged(Nothing, Nothing)
    '            End If
    '        End If
    '    Catch ex As Exception
    '        ACControles.ACDialogos.ACMostrarMensajeError("Error: " & Me.Text, "Ocurrio un error en el proceso Cambiar Registro", ex)
    '    End Try
    'End Sub


    Private Sub cargarProveedor(ByVal x_entid_codigo As String)
        Try
            'managerEntidades.Cargar(x_entid_codigo)
            'actxaCliRazonSocial.Text = managerEntidades.Entidades.ENTID_RazonSocial
            'actxaCliRuc.Text = managerEntidades.Entidades.ENTID_NroDocumento
            ''actxaCliRazonSocial.Text = managerEntidades.ENTISS_BuscarCl

            'R 14/06/2017
            managerEntidades.Cargar(x_entid_codigo)
            'managerABAS_DocsCompra.Cargar(x_entid_codigo)
            actxaCliRazonSocial.Text = managerEntidades.Entidades.ENTID_RazonSocial
            actxaCliRuc.Text = managerEntidades.Entidades.ENTID_Codigo
            txtDireccion.Text = managerEntidades.Entidades.ENTID_Direccion

            ''actxaCliRazonSocial.Text = managerEntidades.ENTISS_BuscarCl

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub cargarDatos(ByVal x_opcion As Boolean)
        Try
            bs_documentos = New BindingSource()
            If x_opcion Then
                bs_documentos.DataSource = managerABAS_DocsCompra.ListABAS_DocsCompra
            Else
                managerABAS_DocsCompra.ListABAS_DocsCompra = New List(Of EABAS_DocsCompra)
                bs_documentos.DataSource = managerABAS_DocsCompra.ListABAS_DocsCompra
            End If
            c1grdBusqueda.DataSource = bs_documentos
            bnavBusqueda.BindingSource = bs_documentos
            AddHandler bs_documentos.CurrentChanged, AddressOf bs_docscompra_CurrentChanged
            bs_docscompra_CurrentChanged(Nothing, Nothing)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub


    Private Sub AsignarBinding()
        Try
            m_listBindHelper = New List(Of ACBindHelper)()
            m_listBindHelper.Add(ACBindHelper.ACBind(cmbMoneda, "SelectedValue", m_eabas_docscompra, "TIPOS_CodTipoMoneda"))
            m_listBindHelper.Add(ACBindHelper.ACBind(cmbCondPago, "SelectedValue", m_eabas_docscompra, "TIPOS_CodTipoPago"))
            m_listBindHelper.Add(ACBindHelper.ACBind(txtOrdenCompra, "Text", m_eabas_docscompra, "ORDEN_Codigo"))
            If m_eabas_docscompra.DOCCO_FechaDocumento.Year < 1700 Then m_eabas_docscompra.DOCCO_FechaDocumento = DateTime.Now
            m_listBindHelper.Add(ACBindHelper.ACBind(dtpFecEmision, "Value", m_eabas_docscompra, "DOCCO_FechaDocumento"))
            If m_eabas_docscompra.DOCCO_FechaPago.Year < 1700 Then m_eabas_docscompra.DOCCO_FechaPago = DateTime.Now
            m_listBindHelper.Add(ACBindHelper.ACBind(dtpFecCaja, "Value", m_eabas_docscompra, "DOCCO_FechaPago"))

            m_listBindHelper.Add(ACBindHelper.ACBind(actxnImporte, "Text", m_eabas_docscompra, "DOCCO_ImporteCompra"))
            m_listBindHelper.Add(ACBindHelper.ACBind(actxnIGV, "Text", m_eabas_docscompra, "DOCCO_ImporteIgv"))
            m_listBindHelper.Add(ACBindHelper.ACBind(actxnTotal, "Text", m_eabas_docscompra, "DOCCO_TotalCompra"))

            '  m_listBindHelper.Add(ACBindHelper.ACBind(actxnPercepcion, "Text", m_eabas_docscompra, "DOCCO_ImportePercepcion"))
            ' m_listBindHelper.Add(ACBindHelper.ACBind(actxnPercepcionSoles, "Text", m_eabas_docscompra, "DOCCO_ImportePercepcionSoles"))
            m_listBindHelper.Add(ACBindHelper.ACBind(actxnTotalPagar, "Text", m_eabas_docscompra, "DOCCO_TotalCompra"))
            m_listBindHelper.Add(ACBindHelper.ACBind(actxnPesoTotal, "Text", m_eabas_docscompra, "DOCCO_TotalPeso"))


            ' m_listBindHelper.Add(ACBindHelper.ACBind(txtDireccion, "Text", m_eabas_docscompra, "DOCCO_DireccionCliente"))
            'm_listBindHelper.Add(ACBindHelper.ACBind(actxnTipoCambio, "Text", m_eabas_docscompra, "DOCCO_TipoCambio"))
            m_listBindHelper.Add(ACBindHelper.ACBind(actxnTCVentaSunat, "Text", m_eabas_docscompra, "DOCCO_TipoCambioSunat"))

            ' m_listBindHelper.Add(ACBindHelper.ACBind(actxnAfectoPercepcionMO, "Text", m_eabas_docscompra, "DOCCO_AfectoPercepcion"))
            ' m_listBindHelper.Add(ACBindHelper.ACBind(actxnAfectoPercepcionSoles, "Text", m_eabas_docscompra, "DOCCO_AfectoPercepcionSoles"))


            ' ''''Adicionales

            m_listBindHelper.Add(ACBindHelper.ACBind(actxnGastos, "Text", m_eabas_docscompra, "DOCCO_Gastos"))
            m_listBindHelper.Add(ACBindHelper.ACBind(actxnFlete, "Text", m_eabas_docscompra, "DOCCO_Flete"))
            m_listBindHelper.Add(ACBindHelper.ACBind(actxnDescuento, "Text", m_eabas_docscompra, "DOCCO_Descuento"))

            m_listBindHelper.Add(ACBindHelper.ACBind(actxaCliRuc, "Text", m_eabas_docscompra, "ENTID_CodigoProveedor"))

            '   m_listBindHelper.Add(ACBindHelper.ACBind(actxnPlazo, "Text", m_eabas_docscompra, "DOCCO_Plazo"))
            'If m_eabas_docscompra.DOCVE_PlazoFecha.Year < 1700 Then m_eabas_docscompra.DOCVE_PlazoFecha = DateTime.Now
            'm_listBindHelper.Add(ACBindHelper.ACBind(dtpFecPlazo, "Value", m_eabas_docscompra, "DOCVE_PlazoFecha"))

            'm_listBindHelper.Add(ACBindHelper.ACBind(txtDirigida, "Text", m_eabas_docscompra, "DOCCO_Dirigida"))
            'm_listBindHelper.Add(ACBindHelper.ACBind(txtTelFax, "Text", m_eabas_docscompra, "DOCCO_NroTelefono"))
            m_listBindHelper.Add(ACBindHelper.ACBind(txtCotizacionC, "Text", m_eabas_docscompra, "ORDEN_Codigo"))

            m_listBindHelper.Add(ACBindHelper.ACBind(actxnTipoCambio, "Text", m_eabas_docscompra, "DOCCO_TipoCambioSunat"))



            '' Adicionales
            '  m_listBindHelper.Add(ACBindHelper.ACBind(txtMotivoAnulacion, "Text", m_eabas_docscompra, "DOCCO_MotivoAnulacion"))
            'm_listBindHelper.Add(ACBindHelper.ACBind(txtObservaciones, "Text", m_eabas_docscompra, "DOCCO_Observaciones"))
            'If m_eabas_docscompra.DOCVE_FecAnulacion.Year < 1700 Then m_eabas_docscompra.DOCVE_FecAnulacion = DateTime.Now
            'm_listBindHelper.Add(ACBindHelper.ACBind(dtpFechaAnulacion, "Value", m_eabas_docscompra, "DOCVE_FecAnulacion"))


            If m_eabas_docscompra.DOCCO_Estado.Equals(EABAS_DocsCompra.getEstado(EABAS_DocsCompra.Estado.Anulado)) Then
                chkAnulada.Checked = True
            Else
                chkAnulada.Checked = False
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    'Private Sub cargarLetras()
    '    Try
    '        bs_letras = New BindingSource
    '        If Not managerABAS_DocsCompra.GetLetras() Then
    '            managerABAS_DocsCompra.VENT_DocsVenta.ListTESO_DocsPagos = New List(Of ETESO_DocsPagos)
    '        End If
    '        bs_letras.DataSource = managerABAS_DocsCompra.VENT_DocsVenta.ListTESO_DocsPagos
    '        c1grdLetras.DataSource = bs_letras
    '        bnavLetras.BindingSource = bs_letras

    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Sub
#End Region

    Private Function busquedaProveedor(ByVal x_cadena As String) As Boolean
        Try
            Dim m_return As Boolean
            'If txtBusqueda.ACEstadoAutoAyuda Then
            If managerABAS_DocsCompra.BusDocsCompra(AcFecha.ACDtpFecha_De.Value.Date, AcFecha.ACDtpFecha_A.Value.Date, GApp.Almacen, txtBusqueda.Text, chkTodos.Checked) Then
                '  If managerVENT_DocsVenta.getCliente(x_cadena, "ENTID_Nombres", chkTodos.Checked, AcFecha.ACFechaChecked, AcFecha.ACDtpFecha_De.Value.Date, AcFecha.ACDtpFecha_A.Value.Date.AddDays(1), GApp.PuntoVenta) Then
                cargarDatos(True)
            Else
                cargarDatos(False)
            End If
            'End If
            Return m_return
        Catch ex As Exception
            ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Convert.ToString(Text)), "No se puede cargar la ayuda de los conductores", ex)
        End Try
        Return False
    End Function

    Private Function busquedaDocumentos(ByVal x_cadena As String) As Boolean
        Try
            Dim m_return As Boolean
            'If txtBusqueda.ACEstadoAutoAyuda Then
            ' If managerABAS_DocsCompra.getDocumentos(txtBusSerie.Text, txtBusNumero.Text, chkTodos.Checked, cmbTipoDocumento.SelectedValue, AcFecha.ACFechaChecked, AcFecha.ACDtpFecha_De.Value.Date, AcFecha.ACDtpFecha_A.Value.Date.AddDays(1), IIf(m_habilitarbuscarptovta, 0, GApp.PuntoVenta)) Then
            If managerABAS_DocsCompra.Busqueda(cmbTipoDocumento.SelectedValue, txtBusSerie.Text, txtBusNumero.Text, chkTodos.Checked, AcFecha.ACDtpFecha_De.Value.Date, AcFecha.ACDtpFecha_A.Value.Date) Then
                cargarDatos(True)
            Else
                cargarDatos(False)
            End If
            'End If
            Return m_return
        Catch ex As Exception
            ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Convert.ToString(Text)), "No se puede cargar la ayuda de los conductores", ex)
        End Try
        Return False
    End Function

    Private Sub bs_docscompra_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If Not IsNothing(bs_documentos.Current) Then
                If CType(bs_documentos.Current, EABAS_DocsCompra).DOCCO_Estado = EABAS_DocsCompra.getEstado(EABAS_DocsCompra.Estado.Anulado) Then
                    actool.ACBtnAnularEnabled = False
                Else
                    actool.ACBtnAnularEnabled = True
                End If
            End If
        Catch ex As Exception
            ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso Cambiar Registro", ex)
        End Try
    End Sub

    'Private Sub bs_documentosventa_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Try
    '        If Not IsNothing(bs_tipodocfacturacion.Current) Then
    '            '' Cargar las series
    '            If managerGenerarDocsVenta.GetSeries(CType(bs_tipodocfacturacion.Current, ETipos).TIPOS_Codigo) Then
    '                bs_series = New BindingSource
    '                bs_series.DataSource = managerGenerarDocsVenta.ListVENT_PVentDocumento
    '                Dim _default As String = ""
    '                For Each Item As EVENT_PVentDocumento In managerGenerarDocsVenta.ListVENT_PVentDocumento
    '                    If cmbTipoDocumento.SelectedValue = ETipos.getTipoComprobante(ETipos.TipoComprobanteVenta.Factura) Then
    '                        If Item.PVDOCU_Predeterminado Then
    '                            _default = Item.PVDOCU_Serie
    '                            Exit For
    '                        End If
    '                    ElseIf cmbTipoDocumento.SelectedValue = ETipos.getTipoComprobante(ETipos.TipoComprobanteVenta.Boleta) Then
    '                        If Item.PVDOCU_PredetBoleta Then
    '                            _default = Item.PVDOCU_Serie
    '                            Exit For
    '                        End If
    '                    End If
    '                Next
    '                ACFramework.ACUtilitarios.ACCargaCombo(cmbBusSerie, bs_series, "PVDOCU_Serie", "PVDOCU_Serie", _default)
    '                cmbBusSerie.Enabled = True
    '            Else
    '                cmbBusSerie.Enabled = False
    '                cmbBusSerie.SelectedIndex = -1
    '                Throw New Exception("No se puede cargar las series, posiblemente no tenga series asignadas")
    '            End If
    '        End If
    '    Catch ex As Exception
    '        ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso cargar Series", ex)
    '    End Try
    'End Sub
#End Region

#Region " Metodos de Controles"

    Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
        Try
            If rbtnProveedor.Checked Then
                txtBusqueda_ACAyudaClick(Nothing, Nothing)
            ElseIf rbtnNroDocumento.Checked Then
                txtBusNumero_ACAyudaClick(Nothing, Nothing)
            End If
        Catch ex As Exception
            ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso consultar documentos", ex)
        End Try
    End Sub

    Private Sub rbtnProveedor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtnProveedor.CheckedChanged
        Try
            grpDocumentos.Enabled = rbtnNroDocumento.Checked
            grpCliente.Enabled = rbtnProveedor.Checked
        Catch ex As Exception
            ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso seleccionar tipo de consulta", ex)
        End Try
    End Sub


    Private Sub AcFecha_ACFecIni_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles AcFecha.ACFecIni_KeyDown
        If e.KeyData = Keys.Enter Then
            AcFecha.ACDtpFecha_A.Focus()
        End If
    End Sub

    Private Sub AcFecha_ACFecFin_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles AcFecha.ACFecFin_KeyDown
        If e.KeyData = Keys.Enter Then
            btnConsultar_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub AyudaEntidad(ByVal x_cadenas As String, ByVal x_campo As Short, ByVal x_descripcion As String, ByVal x_opcion As EEntidades.TipoEntidad)
        Try
            'Dim _where As New Hashtable
            '_where.Add(x_campo, New ACWhere(x_cadenas, ACWhere.TipoWhere._Like))
            'If managerEntidades.Ayuda(_where, x_opcion) Then
            'Dim Ayuda As New ACControlesC1.ACAyudaTextFlex("Buscar Entidad", managerEntidades.DTEntidades, False)
            Dim _campos() As ACCampos = {New ACCampos("@Opcion", x_campo), _
                                         New ACCampos("@Cadena", x_cadenas), _
                                         New ACCampos("@ROLES_Id", x_opcion.GetHashCode.ToString())}
            Dim _busqueda As New ACCampos("@Cadena", x_descripcion)

            Dim Ayuda As New ACControlesC1.ACAyudaTextFlex("Buscar Entidad", "ENTISS_TodosAyuda", _campos, _busqueda, False)
            If Ayuda.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                Select Case x_opcion
                    Case EEntidades.TipoEntidad.Vendedores
                        Dim x_entid_codigo As String = Ayuda.Respuesta.Rows(0)("Codigo")
                        '   cargarUsuario(x_entid_codigo)
                End Select
            Else

            End If
            'Else
            'ACControles.ACDialogos.ACMostrarMensajeInformacion(String.Format("Información: {0}", Me.Text), "No se puede mostrar la ayuda, posiblemente no haya datos que mostrar")
            'End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub c1grdPendientes_OwnerDrawCell(ByVal sender As System.Object, ByVal e As C1.Win.C1FlexGrid.OwnerDrawCellEventArgs) Handles c1grdPendientes.OwnerDrawCell
        Try
            If e.Row < c1grdPendientes.Rows.Fixed OrElse e.Col < c1grdPendientes.Cols.Fixed Then Return
            If c1grdPendientes.Cols(e.Col).Name = "DOCCD_Cantidad" Then
                If c1grdPendientes.Rows(e.Row)("DOCCD_Cantidad") > 0 Then
                    e.Style = c1grdPendientes.Styles("Total")
                End If
            End If
            If c1grdPendientes.Cols(e.Col).Name = "Entregado" Then
                If c1grdPendientes.Rows(e.Row)("Entregado") > 0 Then
                    e.Style = c1grdPendientes.Styles("Entregado")
                End If
            End If

            If c1grdPendientes.Cols(e.Col).Name = "INGCD_Cantidad" Then
                If c1grdPendientes.Rows(e.Row)("INGCD_Cantidad") > 0 Then
                    e.Style = c1grdPendientes.Styles("Cantidad")
                End If
            End If

        Catch ex As Exception
            ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso cambia de color", ex)
        End Try
    End Sub
    Private Sub c1grdAlmacen_OwnerDrawCell(ByVal sender As System.Object, ByVal e As C1.Win.C1FlexGrid.OwnerDrawCellEventArgs) Handles c1grdAlmacen.OwnerDrawCell
        Try
            If e.Row < c1grdAlmacen.Rows.Fixed OrElse e.Col < c1grdAlmacen.Cols.Fixed Then Return
            If c1grdAlmacen.Cols(e.Col).Name = "DOCCD_Cantidad" Then
                If c1grdAlmacen.Rows(e.Row)("DOCCD_Cantidad") > 0 Then
                    e.Style = c1grdAlmacen.Styles("Total")
                End If
            End If
            If c1grdAlmacen.Cols(e.Col).Name = "DOCCD_CantidadEntregada" Then
                If c1grdAlmacen.Rows(e.Row)("DOCCD_CantidadEntregada") > 0 Then
                    e.Style = c1grdAlmacen.Styles("Entregado")
                End If
            End If

            If c1grdAlmacen.Cols(e.Col).Name = "Diferencia" Then
                If c1grdAlmacen.Rows(e.Row)("Diferencia") > 0 Then
                    e.Style = c1grdAlmacen.Styles("Cantidad")
                End If
            End If

        Catch ex As Exception
            ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso cambia de color", ex)
        End Try
    End Sub



#Region " Tool Bar "

    'Private Sub actool_ACBtnGrabar_Click(sender As Object, e As EventArgs) Handles actool.ACBtnGrabar_Click
    '    Try
    '        Dim x_documento As String = CType(bs_documentos.Current, ACELogistica.EVENT_DocsVenta).Documento
    '        If ACControles.ACDialogos.ACMostrarMensajePregunta(String.Format("Grabar Registro: {0}", Me.Text) _
    '                                             , String.Format("Desea Grabar el registro: {0}", x_documento) _
    '                                             , ACControles.ACDialogos.LabelBotom.Si_No) = DialogResult.Yes Then
    '            managerGenerarDocsVenta.VENT_DocsVenta = m_eabas_docscompra
    '            ' managerGenerarDocsVenta.VENT_DocsVenta.ENTID_CodigoVendedor = actxaCodVendedor.Text
    '            managerGenerarDocsVenta.VENT_DocsVenta.DOCVE_FechaDocumento = dtpFecEmision.Value
    '            If managerGenerarDocsVenta.GrabarDocVenta(GApp.Usuario) Then
    '                tabMantenimiento.SelectedTab = tabBusqueda
    '                setInstancia(ACFramework.ACUtilitarios.ACSetInstancia.Deshacer)
    '            End If
    '        End If
    '    Catch ex As Exception
    '        ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), String.Format(Colecciones.getError("00101"), "Grabar Registro"), ex)
    '    End Try
    'End Sub

  

    Private Sub actool_ACBtnSalir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles actool.ACBtnSalir_Click
        Me.Close()
    End Sub

    Private Sub actool_ACBtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles actool.ACBtnCancelar_Click
        Try
            tabMantenimiento.SelectedTab = tabBusqueda
            setInstancia(ACFramework.ACUtilitarios.ACSetInstancia.Deshacer)
        Catch ex As Exception
            ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso cancelar la Cotización/Pedido", ex)
        End Try
    End Sub

    Private Sub actsbtnPrevisualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnPrevisualizar.Click
        Try
            If Not IsNothing(bs_documentos) Then
                If Not IsNothing(bs_documentos.Current) Then
                    '' Codigo
                    Dim x_codigo As String = CType(bs_documentos.Current, EABAS_DocsCompra).DOCCO_Codigo
                    Dim x_entid_codigo As String = CType(bs_documentos.Current, EABAS_DocsCompra).ENTID_CodigoProveedor
                    If Not cargar(x_codigo, x_entid_codigo) Then
                        ACControles.ACDialogos.ACMostrarMensajeInformacion(String.Format("Información: {0}", Me.Text), "No se puede cargar el registro")
                    End If
                Else
                    ACControles.ACDialogos.ACMostrarMensajeInformacion(String.Format("Información: {0}", Me.Text), "No se puede por que no se ha seleccionado ningun registro")
                End If
            Else
                ACControles.ACDialogos.ACMostrarMensajeInformacion(String.Format("Información: {0}", Me.Text), "No se puede continuar por que no se ha cargado ningun registro ")
            End If
        Catch ex As Exception
            ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso previsualizar", ex)
        End Try
    End Sub

    'Private Sub actool_ACBtnAnular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles actool.ACBtnAnular_Click
    '    Try


    '        Dim _documento As String = String.Format("{0} {1}", cmbDocumento.Text, managerABAS_DocsCompra.ABAS_DocsCompra.Documento)


    '        Dim x_fecha As DateTime
    '        x_fecha = m_eabas_docscompra.DOCCO_FechaDocumento
    '        Dim _existe As Boolean
    '        Dim _limite As Decimal = Parametros.GetParametro("pg_TAnulacion", _existe)
    '        If Math.Abs(DateDiff(DateInterval.Day, DateTime.Now, x_fecha)) > _limite Then
    '            Throw New Exception("No se puede anular un documento que ya excedio los 7 dias")
    '        End If

    '        'If m_eabas_docscompra.DOCVE_EstEntrega = "E" Then
    '        '    Dim m_msg As String = ""
    '        '    For Each Item As ACELogistica.EVENT_DocsVentaDetalle In m_event_docsventa.ListVENT_DocsVentaDetalle
    '        '        Dim _stock As Decimal = 0
    '        '        If Item.DOCVD_CantidadEntregada > 0 Then
    '        '            '' Validar las entregas en almacen
    '        '            m_msg &= String.Format("-{1}-{2}, Cant. Documento: {3}, Cantidad Entregada: {4}. {0}", vbNewLine, _
    '        '                                   Item.ARTIC_Codigo, Item.ARTIC_Descripcion, Item.DOCVD_Cantidad, Item.DOCVD_CantidadEntregada)
    '        '        End If
    '        '    Next
    '        '    If m_msg.Length > 0 Then
    '        '        If Not ACControles.ACDialogos.ACMostrarMensajePregunta(String.Format("Articulos entregados en almacen: {0}", Me.Text) _
    '        '                    , String.Format("Articulos entregados en almacen, revise el detalle, ¿desea Continuar con la anulación? ") _
    '        '                    , m_msg, ACControles.ACDialogos.LabelBotom.Si_No) = DialogResult.Yes Then
    '        '            Return
    '        '        End If
    '        '    End If
    '        'End If

    '        If ACControles.ACDialogos.ACMostrarMensajePregunta(String.Format("Anular Documento de Venta: {0}", Me.Text) _
    '                                                      , String.Format("Desea anular el documento: {0}", _documento) _
    '                                                      , ACControles.ACDialogos.LabelBotom.Si_No) = DialogResult.Yes Then
    '            GApp.DataUsuario.PROC_Codigo = Procesos.getProceso(Procesos.TipoProcesos.AdmVen_AnularFacturasFecAnterior)
    '            Dim _validate As New ACValidarUsuario(GApp.DataConexion, GApp.DataUsuario, ACValidarUsuario.Operacion.ValidarProceso)

    '            Dim _frmMotivo As New DMotivo(DMotivo.TDocumento.Recibo) With {.StartPosition = FormStartPosition.CenterScreen, .WindowState = FormWindowState.Normal}

    '            If _frmMotivo.ShowDialog() = Windows.Forms.DialogResult.OK Then
    '                Dim _motivo As String = String.Format("Usuario: {1} {0} - Fecha: {2:dd/MM/yyyy HH:mm} {0} Motivo: {3} {0} Maquina: {4}-{5}", _
    '                                                          vbNewLine, GApp.EUsuario.USER_CodUsr, DateTime.Now, _
    '                                                          _frmMotivo.Motivo, GApp.HostName, GApp.HostIP)

    '                m_paseanulacion = m_eabas_docscompra.DOCVE_PaseAnulacion

    '                If managerABAS_DocsCompra.AnularDocumentoVentas(m_eabas_docscompra.DOCCO_Codigo, m_eabas_docscompra.DOCCO_FechaPago, _
    '                                                            m_eabas_docscompra.PEDID_Codigo, _validate.ACProceso, _motivo, m_paseanulacion, GApp.Usuario) Then
    '                    ACControles.ACDialogos.ACMostrarMensajeSatisfactorio(String.Format("Información: {0}", Me.Text), "Anulado satisfactoriamente")
    '                    btnConsultar_Click(Nothing, Nothing)
    '                    actool_ACBtnCancelar_Click(Nothing, Nothing)
    '                Else
    '                    ACControles.ACDialogos.ACMostrarMensajeInformacion(String.Format("Información: {0}", Me.Text), "No se puede anular el documento")
    '                End If
    '            End If
    '        End If

    '    Catch ex As Exception
    '        ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso anular factura", ex)
    '    End Try
    'End Sub

    'Private Sub actool_ACBtnEliminar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles actool.ACBtnEliminar_Click
    '    Dim _xdocpago As Boolean = False
    '    Try
    '        If ACControles.ACDialogos.ACMostrarMensajePregunta(String.Format("Eliminar Documento de Venta: {0}", Me.Text) _
    '                                                         , String.Format("Desea Eliminar el documento: {0}", CType(bs_documentos.Current, ACELogistica.EVENT_DocsVenta).Documento) _
    '                                                         , ACControles.ACDialogos.LabelBotom.Si_No) = DialogResult.Yes Then
    '            GApp.DataUsuario.PROC_Codigo = Procesos.getProceso(Procesos.TipoProcesos.AdmVen_EliminarFacturas)
    '            Dim _validate As New ACValidarUsuario(GApp.DataConexion, GApp.DataUsuario, ACValidarUsuario.Operacion.ValidarProceso)
    '            If Not _validate.ACProceso Then
    '                Throw New Exception("No tiene permitido eliminar Facturas, solicite autorización a su administrador")
    '            End If
    '            Dim _caja As New BTESO_Caja
    '            Dim _wherecaja As New Hashtable
    '            _wherecaja.Add("DOCVE_Codigo", New ACWhere(m_eabas_docscompra.DOCVE_Codigo))
    '            _wherecaja.Add("CAJA_Estado", New ACWhere(Constantes.getEstado(Constantes.Estado.Anulado), ACWhere.TipoWhere.Diferente))

    '            If _caja.CargarTodos(_wherecaja) Then
    '                If _caja.ListTESO_Caja.Count = 1 And _caja.ListTESO_Caja(0).CAJA_Importe = m_eabas_docscompra.DOCVE_TotalPagar Then
    '                    If ACControles.ACDialogos.ACMostrarMensajePregunta(String.Format("Eliminar Documento de Venta: {0}", Me.Text) _
    '                                                           , String.Format("Desea Eliminar el documento de Pago: {0}", CType(bs_documentos.Current, ACELogistica.EVENT_DocsVenta).Documento) _
    '                                                           , ACControles.ACDialogos.LabelBotom.Si_No) = DialogResult.Yes Then
    '                        _xdocpago = True
    '                    End If
    '                End If
    '            End If

    '            If managerABAS_DocsCompra.EliminarDocumentoVenta(m_eabas_docscompra.DOCVE_Codigo, m_eabas_docscompra.PEDID_Codigo, _xdocpago, GApp.Usuario) Then
    '                ACControles.ACDialogos.ACMostrarMensajeSatisfactorio(String.Format("Información: {0}", Me.Text), "Eliminado satisfactoriamente")
    '                actool_ACBtnCancelar_Click(Nothing, Nothing)
    '                btnConsultar_Click(Nothing, Nothing)
    '                setInstancia(ACFramework.ACUtilitarios.ACSetInstancia.Deshacer)
    '            Else
    '                ACControles.ACDialogos.ACMostrarMensajeInformacion(String.Format("Información: {0}", Me.Text), "No se puede Eliminar el documento")
    '            End If
    '        End If
    '    Catch ex As Exception
    '        ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), String.Format(Colecciones.getError("00101"), "Eliminar el Documento de Venta"), ex)
    '    End Try
    'End Sub
#End Region

#Region " Grillas "
    Private Sub c1grdBusqueda_OwnerDrawCell(ByVal sender As System.Object, ByVal e As C1.Win.C1FlexGrid.OwnerDrawCellEventArgs) Handles c1grdBusqueda.OwnerDrawCell
        Try
            If e.Row < c1grdBusqueda.Rows.Fixed OrElse e.Col < c1grdBusqueda.Cols.Fixed Then Return
            If c1grdBusqueda.Rows(e.Row)("DOCCO_Estado") = ACELogistica.EVENT_DocsVenta.getEstado(ACELogistica.EVENT_DocsVenta.Estado.Confirmado) Then
                e.Style = c1grdBusqueda.Styles("Facturado")
            End If
            If c1grdBusqueda.Rows(e.Row)("DOCCO_Estado") = ACELogistica.EVENT_DocsVenta.getEstado(ACELogistica.EVENT_DocsVenta.Estado.Anulado) Then
                e.Style = c1grdBusqueda.Styles("Anulado")
            End If

            'If c1grdBusqueda.Cols(e.Col).Name = "DOCCO_Impresiones" Then
            '    e.Style = c1grdBusqueda.Styles("Alinear")
            'End If

            'If c1grdBusqueda.Cols(e.Col).Name = "Condicion" Then
            '    If c1grdBusqueda(e.Row, "Condicion").Equals("Pendiente") Then
            '        e.Style = c1grdBusqueda.Styles("Anulado")
            '    End If
            '    If c1grdBusqueda(e.Row, "Condicion").Equals("Entregado") Then
            '        e.Style = c1grdBusqueda.Styles("Facturar")
            '    End If
            'End If
            If c1grdBusqueda.Cols(e.Col).Name = "TIPOS_TipoPago" Then
                If c1grdBusqueda(e.Row, "TIPOS_TipoPago").Equals("Credito") Or c1grdBusqueda(e.Row, "TIPOS_TipoPago").Equals("Bancarizac") Or c1grdBusqueda(e.Row, "TIPOS_TipoPago").Equals(Nothing) Then
                    e.Style = c1grdBusqueda.Styles("Anulado")
                End If
                If c1grdBusqueda(e.Row, "TIPOS_TipoPago").Equals("Contado") Then
                    e.Style = c1grdBusqueda.Styles("Facturar")
                End If
            End If
        Catch ex As Exception
            ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso cambia de color", ex)
        End Try
    End Sub

    Private Sub c1grdGuiasRemision_OwnerDrawCell(ByVal sender As System.Object, ByVal e As C1.Win.C1FlexGrid.OwnerDrawCellEventArgs) Handles c1grdGuiasRemision.OwnerDrawCell
        Try
            If e.Row < c1grdGuiasRemision.Rows.Fixed OrElse e.Col < c1grdGuiasRemision.Cols.Fixed Then Return
            If c1grdGuiasRemision.Rows(e.Row)("INGCO_Estado") = Constantes.getEstado(Constantes.Estado.Anulado) Then
                e.Style = c1grdGuiasRemision.Styles("Anulado")
            End If
        Catch ex As Exception
            ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso cambia de color", ex)
        End Try
    End Sub

    Private Sub c1grdOrdenes_OwnerDrawCell(ByVal sender As System.Object, ByVal e As C1.Win.C1FlexGrid.OwnerDrawCellEventArgs) Handles c1grdOrdenes.OwnerDrawCell
        Try
            If e.Row < c1grdOrdenes.Rows.Fixed OrElse e.Col < c1grdOrdenes.Cols.Fixed Then Return
            If c1grdOrdenes.Rows(e.Row)("ORDEN_Estado") = Constantes.getEstado(Constantes.Estado.Anulado) Then
                e.Style = c1grdOrdenes.Styles("Anulado")
            End If
        Catch ex As Exception
            ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso cambia de color", ex)
        End Try
    End Sub
    Private Sub c1grdNotasCredito_OwnerDrawCell(ByVal sender As System.Object, ByVal e As C1.Win.C1FlexGrid.OwnerDrawCellEventArgs) Handles c1grdNotasCredito.OwnerDrawCell
        Try
            If e.Row < c1grdNotasCredito.Rows.Fixed OrElse e.Col < c1grdNotasCredito.Cols.Fixed Then Return
            If c1grdNotasCredito.Rows(e.Row)("DOCCO_Estado") = Constantes.getEstado(Constantes.Estado.Anulado) Then
                e.Style = c1grdNotasCredito.Styles("Anulado")
            End If
        Catch ex As Exception
            ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso cambia de color", ex)
        End Try
    End Sub

    Private Sub c1grdBusqueda_BeforeSort(ByVal sender As System.Object, ByVal e As C1.Win.C1FlexGrid.SortColEventArgs) Handles c1grdBusqueda.BeforeSort
        Try
            Ordenar(c1grdBusqueda.Cols(e.Col).UserData)
            c1grdBusqueda.Subtotal(AggregateEnum.Clear)
        Catch ex As Exception
            ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso ordenar", ex)
        End Try
    End Sub
#End Region

#Region " Ayudas "

    Private Sub txtBusNumero_ACAyudaClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBusNumero.ACAyudaClick
        Try
            busquedaDocumentos(txtBusqueda.Text)
        Catch ex As Exception
            ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Convert.ToString(Text)), "No se puede cargar la ayuda de documentos", ex)
        End Try
    End Sub

    Private Sub txtBusqueda_ACAyudaClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBusqueda.ACAyudaClick
        Try
            busquedaProveedor(txtBusqueda.Text)
        Catch ex As Exception
            ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Convert.ToString(Text)), "No se puede cargar la ayuda de clientes", ex)
        End Try
    End Sub

#End Region
#End Region

    'Private Sub tsbtnAddLetra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnAddLetra.Click
    '    Try
    '        Dim _frmletra As New MDocsPago(ETipos.TipoDocPago.Letra, False, MDocsPago.TipoInicio.Dialogo) With {.WindowState = FormWindowState.Normal, .StartPosition = FormStartPosition.CenterScreen}
    '        If _frmletra.ShowDialog() = Windows.Forms.DialogResult.OK Then
    '            If managerABAS_DocsCompra.GuardarDocsPago(GApp.Usuario, _frmletra.TESO_DocsPagos) Then
    '                ACControles.ACDialogos.ACMostrarMensajeSatisfactorio(String.Format("Información: {0}", Me.Text), "Grabado satisfactoriamente")
    '            Else
    '                Throw New Exception("No se puede completar el proceso de agregar letra.")
    '            End If
    '        Else
    '        End If
    '    Catch ex As Exception
    '        ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), String.Format(Colecciones.getError("00101"), "Agregar Letra"), ex)
    '    End Try
    'End Sub

    Private Sub txtBusNumero_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBusNumero.KeyDown
        If e.KeyData = Keys.Enter Then
            txtBusNumero_ACAyudaClick(Nothing, Nothing)
        End If
    End Sub

    Private Sub cmbMoneda_SelectedIndexChanged(sender As Object, e As EventArgs)
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
                    If IsNothing(m_eabas_docscompra) Then
                        lbligv.Text = String.Format("I.G.V. {1:0#}%: {0}", Constantes.Moneda(ETipos.TipoMoneda.Soles), Parametros.GetParametro(EParametros.TipoParametros.PIGV))
                    Else
                        lbligv.Text = String.Format("I.G.V. {1:0#}%: {0}", Constantes.Moneda(ETipos.TipoMoneda.Soles), m_eabas_docscompra.DOCCO_PorcentajeIGV)
                    End If
                    lblImporte.Text = String.Format("Importe : {0}", Constantes.Moneda(ETipos.TipoMoneda.Soles))
                    lblVPercepcion.Text = String.Format("Percepción : {0}", Constantes.Moneda(ETipos.TipoMoneda.Soles))
                    lblTotal.Text = String.Format("Total : {0}", Constantes.Moneda(ETipos.TipoMoneda.Soles))
                    lblTotalPagar.Text = String.Format("Total Pagar : {0}", Constantes.Moneda(ETipos.TipoMoneda.Soles))
                Case ETipos.TipoMoneda.Dolares
                    If IsNothing(m_eabas_docscompra) Then
                        lbligv.Text = String.Format("I.G.V. {1:0#}%: {0}", Constantes.Moneda(ETipos.TipoMoneda.Dolares), Parametros.GetParametro(EParametros.TipoParametros.PIGV))
                    Else
                        lbligv.Text = String.Format("I.G.V. {1:0#}%: {0}", Constantes.Moneda(ETipos.TipoMoneda.Dolares), m_eabas_docscompra.DOCCO_PorcentajeIGV)
                    End If
                    lblImporte.Text = String.Format("Importe : {0}", Constantes.Moneda(ETipos.TipoMoneda.Dolares))
                    lblVPercepcion.Text = String.Format("Percepción : {0}", Constantes.Moneda(ETipos.TipoMoneda.Dolares))
                    lblTotal.Text = String.Format("Total : {0}", Constantes.Moneda(ETipos.TipoMoneda.Dolares))
                    lblTotalPagar.Text = String.Format("Total Pagar : {0}", Constantes.Moneda(ETipos.TipoMoneda.Dolares))
                Case Else
                    setEtiqueta(ETipos.TipoMoneda.Soles)
            End Select
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub c1grdBusqueda_DoubleClick(sender As Object, e As EventArgs) Handles c1grdBusqueda.DoubleClick
        actsbtnPrevisualizar_Click(Nothing, Nothing)
    End Sub

    Private Sub txtBusqueda_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBusqueda.KeyDown
        If e.KeyData = Keys.Enter Then
            txtBusqueda_ACAyudaClick(Nothing, Nothing)
        End If
    End Sub

    'Private Sub tsbtnAnularPago_Click(sender As Object, e As EventArgs) Handles tsbtnAnularPago.Click
    '    Try
    '        If ACControles.ACDialogos.ACMostrarMensajePregunta(String.Format("Anular Registro: {0}", Me.Text) _
    '                                             , String.Format("Desea Anular el registro de Pago: {0}", CType(bs_pagos.Current, ETESO_Caja).Documento) _
    '                                             , ACControles.ACDialogos.LabelBotom.Si_No) = DialogResult.Yes Then
    '            Dim _frmMotivo As New DMotivo(DMotivo.TDocumento.PagoCaja) With {.StartPosition = FormStartPosition.CenterScreen, .WindowState = FormWindowState.Normal}
    '            If _frmMotivo.ShowDialog() = Windows.Forms.DialogResult.OK Then
    '                Dim _motivo As String = String.Format("Usuario: {1} {0} - Fecha: {2:dd/MM/yyyy HH:mm} {0} Motivo: {3} {0} Maquina: {4}-{5}", _
    '                                                        vbNewLine, GApp.EUsuario.USER_CodUsr, DateTime.Now, _
    '                                                        _frmMotivo.Motivo, GApp.HostName, GApp.HostIP)
    '                Dim _id As Long = CType(bs_pagos.Current, ETESO_Caja).CAJA_Id
    '                Dim managerbadministracioncaja As New BAdminCaja(GApp.Zona, GApp.Sucursal, GApp.PuntoVenta, GApp.Periodo)
    '                managerbadministracioncaja.AnularPago(GApp.PuntoVenta, _id, _motivo, GApp.Usuario, CType(bs_pagos.Current, ETESO_Caja).CAJA_Fecha)
    '                CargarPagos()
    '                ACControles.ACDialogos.ACMostrarMensajeSatisfactorio(String.Format("Información: {0}", Me.Text), String.Format(Colecciones.getError("01005")))
    '            Else
    '                Throw New Exception("No se puede completar el proceso anular Guia")
    '            End If
    '        End If
    '    Catch ex As Exception
    '        ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), String.Format(Colecciones.getError("00101"), "Anular Pago"), ex)
    '    End Try
    'End Sub


    'Private Sub tsbtnGuardar_Click(sender As Object, e As EventArgs) Handles tsbtnGuardar.Click
    '    Try
    '        Dim _codigo As String = m_eabas_docscompra.DOCCO_Codigo

    '        If chk_paseanula > 0 Then
    '            If ACControles.ACDialogos.ACMostrarMensajePregunta(String.Format("Asignar Permiso: {0}", Me.Text) _
    '                                        , String.Format("Desea Asignar permiso para Anular el Documento: {0}", _codigo) _
    '                                        , ACControles.ACDialogos.LabelBotom.Si_No) = DialogResult.Yes Then
    '                If managerABAS_DocsCompra.SetPermisoAnularDocumentos(_codigo, chkPaseAnularDocumentos.Checked, _
    '                                                           GApp.Usuario) Then
    '                    ACControles.ACDialogos.ACMostrarMensajeSatisfactorio(String.Format("Información: {0}", Me.Text), "Grabado satisfactoriamente")
    '                End If
    '            End If
    '        End If

    '    Catch ex As Exception
    '        ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), String.Format(Colecciones.getError("00101"), "Guardando permiso"), ex)
    '    End Try
    'End Sub



    Private Sub chkPaseAnularDocumentos_CheckedChanged(sender As Object, e As EventArgs) Handles chkPaseAnularDocumentos.CheckedChanged
        Try
            If chkPaseAnularDocumentos.Checked Then
                chk_paseanula = 1
            Else
                chk_paseanula = 2
            End If
        Catch ex As Exception
            ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso asignacion de permiso", ex)
        End Try
    End Sub


    'Private Sub tsbtnAnularEntregaAlmacen_Click(sender As Object, e As EventArgs) Handles tsbtnAnularEntregaAlmacen.Click
    '    Try
    '        If ACControles.ACDialogos.ACMostrarMensajePregunta(String.Format("Anular Registro: {0}", Me.Text) _
    '                                             , String.Format("Desea Anular el registro de Almacen: {0}", CType(bs_docalmacenentregas.Current, ACELogistica.EVENT_DocsVentaDetalle).DOCVE_Codigo) _
    '                                             , ACControles.ACDialogos.LabelBotom.Si_No) = DialogResult.Yes Then

    '            GApp.DataUsuario.PROC_Codigo = Procesos.getProceso(Procesos.TipoProcesos.Alm_AnularEntregaDespuesDeFecha)
    '            Dim _validat As New ACValidarUsuario(GApp.DataConexion, GApp.DataUsuario, ACValidarUsuario.Operacion.ValidarProceso)

    '            Dim _frmMotivo As New DMotivo(DMotivo.TDocumento.Recibo) With {.StartPosition = FormStartPosition.CenterScreen, .WindowState = FormWindowState.Normal}
    '            If _frmMotivo.ShowDialog() = Windows.Forms.DialogResult.OK Then
    '                Dim _motivo As String = String.Format("Usuario: {1} {0} - Fecha: {2:dd/MM/yyyy HH:mm} {0} Motivo: {3} {0} Maquina: {4}-{5}", _
    '                                                        vbNewLine, GApp.EUsuario.USER_CodUsr, DateTime.Now, _
    '                                                        _frmMotivo.Motivo, GApp.HostName, GApp.HostIP)



    '                If managerABAS_DocsCompra.AnularEntregaAlmacenXItem(m_eabas_docscompra.DOCCO_Codigo, CType(bs_docalmacenentregas.Current, ACELogistica.EVENT_DocsVentaDetalle).ARTIC_Codigo, _
    '                                                         CType(bs_docalmacenentregas.Current, ACELogistica.EVENT_DocsVentaDetalle).DOCVD_Item, CType(bs_docalmacenentregas.Current, ACELogistica.EVENT_DocsVentaDetalle).Entregado, _
    '                                                         CType(bs_docalmacenentregas.Current, ACELogistica.EVENT_DocsVentaDetalle).DOCVD_FecAlmacen, _validat.ACProceso, _motivo, GApp.Usuario) Then
    '                    ACControles.ACDialogos.ACMostrarMensajeSatisfactorio(String.Format("Información: {0}", Me.Text), "Anulado satisfactoriamente")
    '                    ' btnConsultar_Click(Nothing, Nothing)
    '                    'actool_ACBtnCancelar_Click(Nothing, Nothing)
    '                    CargarAlmacenEntregas()
    '                Else
    '                    ACControles.ACDialogos.ACMostrarMensajeInformacion(String.Format("Información: {0}", Me.Text), "No se puede anular la entrega")
    '                End If
    '            End If
    '        End If
    '    Catch ex As Exception
    '        ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), String.Format(Colecciones.getError("00101"), "Anular Entrega"), ex)
    '    End Try
    'End Sub


    'Private Sub tsbtnAnularTodoEntregaAlmacen_Click(sender As Object, e As EventArgs) Handles tsbtnAnularTodoEntregaAlmacen.Click
    '    Try
    '        If ACControles.ACDialogos.ACMostrarMensajePregunta(String.Format("Anular Registros: {0}", Me.Text) _
    '                                             , String.Format("Desea Anular Todas las Entregas de Almacen: {0}", CType(bs_docalmacenentregas.Current, ACELogistica.EVENT_DocsVentaDetalle).DOCVE_Codigo) _
    '                                             , ACControles.ACDialogos.LabelBotom.Si_No) = DialogResult.Yes Then

    '            GApp.DataUsuario.PROC_Codigo = Procesos.getProceso(Procesos.TipoProcesos.Alm_AnularEntregaDespuesDeFecha)
    '            Dim _validat As New ACValidarUsuario(GApp.DataConexion, GApp.DataUsuario, ACValidarUsuario.Operacion.ValidarProceso)

    '            Dim _frmMotivo As New DMotivo(DMotivo.TDocumento.Recibo) With {.StartPosition = FormStartPosition.CenterScreen, .WindowState = FormWindowState.Normal}
    '            If _frmMotivo.ShowDialog() = Windows.Forms.DialogResult.OK Then
    '                Dim _motivo As String = String.Format("Usuario: {1} {0} - Fecha: {2:dd/MM/yyyy HH:mm} {0} Motivo: {3} {0} Maquina: {4}-{5}", _
    '                                                        vbNewLine, GApp.EUsuario.USER_CodUsr, DateTime.Now, _
    '                                                        _frmMotivo.Motivo, GApp.HostName, GApp.HostIP)

    '                If managerABAS_DocsCompra.AnularEntregaAlmacenTodo(m_eabas_docscompra.DOCCO_Codigo, CType(bs_docalmacenentregas.Current, ACELogistica.EVENT_DocsVentaDetalle).DOCVD_FecAlmacen, _validat.ACProceso, _motivo, GApp.Usuario) Then
    '                    ACControles.ACDialogos.ACMostrarMensajeSatisfactorio(String.Format("Información: {0}", Me.Text), "Anulado satisfactoriamente")
    '                    ' btnConsultar_Click(Nothing, Nothing)
    '                    'actool_ACBtnCancelar_Click(Nothing, Nothing)
    '                    CargarAlmacenEntregas()
    '                Else
    '                    ACControles.ACDialogos.ACMostrarMensajeInformacion(String.Format("Información: {0}", Me.Text), "No se puede anular la entrega")
    '                End If
    '            End If
    '        End If
    '    Catch ex As Exception
    '        ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), String.Format(Colecciones.getError("00101"), "Anular Entrega"), ex)
    '    End Try
    'End Sub

    Private Sub MCompras_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub actool_ACBtnAnular_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub actool_ACBtnImprimir_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub actool_ACBtnGrabar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub actool_ACBtnEliminar_Click(sender As Object, e As EventArgs)

    End Sub
End Class