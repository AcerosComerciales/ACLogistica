Imports C1.Win.C1FlexGrid
Imports ACFramework
Imports ACELogistica
Imports ACBLogistica
Imports ACEVentas
Imports ACBVentas

Imports Microsoft.Practices.Unity
Imports Microsoft.Practices.Unity.Configuration
Imports System.Reflection

Public Class TCosteo

#Region " Variables "
   Private m_eabas_docscompra As EABAS_DocsCompra

   Private m_flete As EABAS_Costeos
   Private m_gasto As EABAS_Costeos
   Private m_servicios As EABAS_Costeos

   Private m_listBindHelper As List(Of ACBindHelper)
   Private m_listBH_Flete As List(Of ACBindHelper)
   Private m_listBH_Gastos As List(Of ACBindHelper)
   Private m_listBH_Servicios As List(Of ACBindHelper)

   Private bs_docscompra As BindingSource
   Private bs_detdocscompra As BindingSource

   Private bs_fmoneda As BindingSource
   Private bs_gmoneda As BindingSource
   Private bs_smoneda As BindingSource

   Private managerGenerarDocsCompra As BGenerarDocsCompra
   Private managerABAS_DocsCompra As BABAS_DocsCompra
   Private managerConsultaArticulos As BConsultaArticulos
   Private managerEntidades As BEntidades
   Private managerTipoCambio As BTipoCambio
   Private managerABAS_OrdenesCompra As BABAS_OrdenesCompra
   Private managerGenerarCosteo As BGenerarCosteo

   Private frmCons As CProductos

   Private m_order As Integer = 1


   Enum TipoCosteo
      Flete
      Gasto
      Servicio
      Descuento
   End Enum

#End Region

#Region " Propiedades "

#End Region

#Region " Constructores "
   Public Sub New()

      ' This call is required by the Windows Form Designer.
      InitializeComponent()

      ' Add any initialization after the InitializeComponent() call.
      Try
         tabMantenimiento.HideTabsMode = Crownwood.DotNetMagic.Controls.HideTabsModes.HideAlways
         tabMantenimiento.SelectedTab = tabBusqueda

         managerGenerarDocsCompra = New BGenerarDocsCompra
         managerABAS_DocsCompra = New BABAS_DocsCompra
         managerConsultaArticulos = New BConsultaArticulos(GApp.Periodo)
         managerEntidades = New BEntidades
         managerTipoCambio = New BTipoCambio
         managerABAS_OrdenesCompra = New BABAS_OrdenesCompra
         managerGenerarCosteo = New BGenerarCosteo

         formatearGrilla()
         cargarCombos()
         acFecha.ACDtpFecha_De.Value = DateTime.Now.AddDays(-1 * DateTime.Now.Day + 1)
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "No se puede cargar los controles iniciales", ex)
      End Try
   End Sub
#End Region

#Region " Metodos "

#Region " Utilitarios "
   ''' <summary>
   ''' dar formato a la grilal de busqueda
   ''' </summary>
   ''' <remarks></remarks>
   Private Sub formatearGrilla()
      Dim index As Integer = 1
      Try
         ACFrameworkC1.ACUtilitarios.ACFormatearGrilla(c1grdBusqueda, 1, 1, 12, 1, 1)
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Fecha", "DOCCO_FechaDocumento", "DOCCO_FechaDocumento", 150, True, False, "System.DateTime") : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Codigo", "DOCCO_Codigo", "DOCCO_Codigo", 150, False, False, "System.String") : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Documento", "Documento", "Documento", 150, True, False, "System.String") : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Orden", "CodigoOrden", "CodigoOrden", 150, True, False, "System.String") : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Cod. Proveedor", "ENTID_CodigoProveedor", "ENTID_CodigoProveedor", 150, True, False, "System.String") : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Proveedor", "ENTID_Proveedor", "ENTID_Proveedor", 150, True, False, "System.String") : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Moneda", "TIPOS_TipoMoneda", "TIPOS_TipoMoneda", 150, True, False, "System.String") : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Total Compra", "DOCCO_TotalCompra", "DOCCO_TotalCompra", 150, True, False, "System.Decimal", Parametros.GetParametro(EParametros.TipoParametros.pg_FMondo2d)) : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Tipo Pago", "TIPOS_TipoPago", "TIPOS_TipoPago", 150, True, False, "System.String") : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Estado", "DOCCO_Estado_Text", "DOCCO_Estado_Text", 150, True, False, "System.String") : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Estado", "DOCCO_Estado", "DOCCO_Estado", 150, False, False, "System.String") : index += 1

         c1grdBusqueda.AllowEditing = False
         c1grdBusqueda.AllowSorting = AllowSortingEnum.SingleColumn
         c1grdBusqueda.Styles.Alternate.BackColor = Color.LightGray
         c1grdBusqueda.Styles.Fixed.TextAlign = TextAlignEnum.CenterCenter
         c1grdBusqueda.Styles.Highlight.BackColor = Color.Gray
         c1grdBusqueda.SelectionMode = SelectionModeEnum.Row

         Dim t As C1.Win.C1FlexGrid.CellStyle = c1grdBusqueda.Styles.Add("Facturado")
         t.BackColor = Color.LightGreen
         t.ForeColor = Color.DarkBlue
         t.Font = New Font(c1grdBusqueda.Font, FontStyle.Regular)

         Dim u As C1.Win.C1FlexGrid.CellStyle = c1grdBusqueda.Styles.Add("Facturar")
         u.BackColor = Color.Green
         u.ForeColor = Color.White
         u.Font = New Font(c1grdBusqueda.Font, FontStyle.Regular)

         Dim d As C1.Win.C1FlexGrid.CellStyle = c1grdBusqueda.Styles.Add("Anulado")
         d.BackColor = Color.Red
         d.ForeColor = Color.White
         d.Font = New Font(c1grdBusqueda.Font, FontStyle.Bold)
         c1grdBusqueda.DrawMode = C1.Win.C1FlexGrid.DrawModeEnum.OwnerDraw

         formatearGrilla(1)
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Text), "No se puede dar formato a la grilla", ex)
      End Try
   End Sub

   ''' <summary>
   ''' dar formato a la grilla de proceso de costeo
   ''' </summary>
   ''' <param name="x_descuentos"></param>
   ''' <remarks></remarks>
   Private Sub formatearGrilla(ByVal x_descuentos As Integer)
      Dim index As Integer = 1
      Try
         c1grdBusqueda.FinishEditing()
         ACFrameworkC1.ACUtilitarios.ACFormatearGrilla(c1grdDetalle, 2, 2, (16 + x_descuentos), 1, 2)
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdDetalle, index, "Codigo", "ARTIC_Codigo", "ARTIC_Codigo", 80, True, False, "System.String") : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdDetalle, index, "Descripción", "ARTIC_Descripcion", "ARTIC_Descripcion", 191, True, False, "System.String") : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdDetalle, index, "Unidad", "TIPOS_UnidadMedida", "TIPOS_UnidadMedida", 69, True, False, "System.String") : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdDetalle, index, "Peso", "DOCCD_PesoUnitario", "DOCCD_PesoUnitario", 75, True, False, "System.Decimal", Parametros.GetParametro(EParametros.TipoParametros.pg_FMondo4d)) : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdDetalle, index, "Cantidad", "DOCCD_Cantidad", "DOCCD_Cantidad", 75, True, False, "System.Decimal", Parametros.GetParametro(EParametros.TipoParametros.pg_FMondo2d)) : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdDetalle, index, "Precio Unit.", "DOCCD_PrecioUnitario", "DOCCD_PrecioUnitario", 75, True, False, "System.Decimal", Parametros.GetParametro(EParametros.TipoParametros.pg_FMondo2d)) : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdDetalle, index, "Peso Doc.", "DOCCD_SubPeso", "DOCCD_SubPeso", 75, True, False, "System.Decimal", Parametros.GetParametro(EParametros.TipoParametros.pg_FMondo4d)) : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdDetalle, index, "Sub-Importe", "DOCCD_SubImporteCompra", "DOCCD_SubImporteCompra", 75, True, False, "System.Decimal", Parametros.GetParametro(EParametros.TipoParametros.pg_FMondo2d)) : index += 1
         ' Para los descuentos
         For i As Integer = 1 To x_descuentos
            Dim x_name As String = String.Format("Descuento_{0}", i.ToString())
            Dim x_title As String = String.Format("Descuento {0}", i.ToString())
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdDetalle, index, x_title, x_name, x_name, 75, True, True, "System.Decimal", Parametros.GetParametro(EParametros.TipoParametros.pg_FMondo2d)) : index += 1
         Next
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdDetalle, index, "Servicio", "Servicio", "Servicio", 75, True, True, "System.Decimal", Parametros.GetParametro(EParametros.TipoParametros.pg_FMondo2d)) : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdDetalle, index, "Costo Con IGV", "Costo", "Costo", 75, True, False, "System.Decimal", Parametros.GetParametro(EParametros.TipoParametros.pg_FMondo2d)) : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdDetalle, index, "Costo Sin IGV", "CostoIGV", "CostoIGV", 75, True, False, "System.Decimal", Parametros.GetParametro(EParametros.TipoParametros.pg_FMondo2d)) : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdDetalle, index, "Destino", "TIPOS_TipoDestino", "TIPOS_TipoDestino", 80, True, False, "System.String") : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdDetalle, index, "Cantidad", "COSTE_Cantidad", "COSTE_Cantidad", 191, tpgServicios.Enabled, True, "System.Decimal") : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdDetalle, index, "Codigo", "ARTIC_CodServicio", "ARTIC_CodServicio", 80, tpgServicios.Enabled, True, "System.String") : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdDetalle, index, "Descripción", "ARTIC_DesServicio", "ARTIC_DesServicio", 191, tpgServicios.Enabled, True, "System.String") : index += 1

         c1grdDetalle.AllowEditing = True
         c1grdDetalle.AutoResize = True
         c1grdDetalle.Cols(0).Width = 15
         
         c1grdDetalle.Styles.Alternate.BackColor = Color.LightGray
         c1grdDetalle.Styles.Fixed.TextAlign = TextAlignEnum.CenterCenter
         c1grdDetalle.Styles.Highlight.BackColor = Color.Gray
         c1grdDetalle.SelectionMode = SelectionModeEnum.Row
         c1grdDetalle.AllowResizing = AllowResizingEnum.Columns
         c1grdDetalle.DrawMode = C1.Win.C1FlexGrid.DrawModeEnum.OwnerDraw

         For i As Integer = 1 To c1grdDetalle.Cols.Count - 1
            c1grdDetalle.Rows(1)(i) = c1grdDetalle.Rows(0)(i)
         Next
         c1grdDetalle.Rows(0).AllowMerging = True
         c1grdDetalle.Rows(0).AllowMerging = True
         Dim rg As CellRange = c1grdDetalle.GetCellRange(0, 9, 0, 8 + x_descuentos)
         rg.Data = "Descuentos"
         c1grdDetalle.MergedRanges.Add(rg)

         For i As Integer = 0 To 8
            rg = c1grdDetalle.GetCellRange(0, i, 1, i)
            c1grdDetalle.MergedRanges.Add(rg)
         Next

         For j As Integer = 9 To c1grdDetalle.Cols.Count - 2
            rg = c1grdDetalle.GetCellRange(0, j + x_descuentos, 1, j + x_descuentos)
            c1grdDetalle.MergedRanges.Add(rg)
         Next
         rg = c1grdDetalle.GetCellRange(0, 12 + x_descuentos, 0, 14 + x_descuentos)
         rg.Data = "Articulo Destino"
         c1grdDetalle.MergedRanges.Add(rg)

         '' Agregar Botones en la Grilla
         Dim cs As CellStyle
         cs = c1grdDetalle.Styles.Add("Botoncito")
         cs.ComboList = "..."
         RemoveHandler c1grdDetalle.CellButtonClick, AddressOf c1grdDetalle_CellButtonClick
         'cs.Font = New Font(c1grdDetalle.Font.FontFamily, c1grdDetalle.Font.Size)
         AddHandler c1grdDetalle.CellButtonClick, AddressOf c1grdDetalle_CellButtonClick
         c1grdDetalle.ShowButtons = ShowButtonsEnum.Always
         c1grdDetalle.Cols("ARTIC_CodServicio").Style = cs
         c1grdDetalle.Cols("ARTIC_DesServicio").Style = cs

         '' Colores 
         Dim u As C1.Win.C1FlexGrid.CellStyle = c1grdDetalle.Styles.Add("Confirmado")
         u.BackColor = Color.Red
         u.ForeColor = Color.White
         u.Font = New Font(c1grdDetalle.Font, FontStyle.Bold)

         If Not IsNothing(m_eabas_docscompra) Then
            If Not IsNothing(m_eabas_docscompra.ListEABAS_DocsCompraDetalle) Then
               bs_detdocscompra = New BindingSource
               bs_detdocscompra.DataSource = m_eabas_docscompra.ListEABAS_DocsCompraDetalle
               AddHandler bs_detdocscompra.CurrentChanged, AddressOf bs_doccomprasdetalle_CurrentChanged
               c1grdDetalle.DataSource = bs_detdocscompra
               bnavProductos.BindingSource = bs_detdocscompra
            End If
         End If
      Catch ex As Exception
         Throw ex
      End Try
   End Sub

   ''' <summary>
   ''' dar la instancia de control segun el proceso, activando y desactivando controles visuales
   ''' </summary>
   ''' <param name="_opcion"></param>
   ''' <remarks></remarks>
   Private Sub setInstancia(ByVal _opcion As ACUtilitarios.ACSetInstancia)
      Select Case _opcion
         Case ACUtilitarios.ACSetInstancia.Nuevo
            ACUtilitarios.ACLimpiaVar(pnlFletes)
            ACUtilitarios.ACLimpiaVar(pnlGastos)
            ACUtilitarios.ACLimpiaVar(pnlServicio)
            tabCosteo.SelectedTab = tpgFlete
            nudNroDescuentos.Value = 1
            txtProvCodigo.Focus()
            btnFModProveedor.Enabled = True
            acbtnCostear.Visible = False
         Case ACUtilitarios.ACSetInstancia.Modificado
         Case ACUtilitarios.ACSetInstancia.Guardar
            acbtnCostear.Visible = True
            txtBusqueda.Focus()
         Case ACUtilitarios.ACSetInstancia.Deshacer
            acbtnCostear.Visible = True
         Case ACUtilitarios.ACSetInstancia.Previsualizar
            ACUtilitarios.ACLimpiaVar(pnlCabecera)
            acbtnCostear.Visible = False
      End Select
   End Sub

   ''' <summary>
   ''' carga los combos de la interfaz visual de la clase tipos
   ''' </summary>
   ''' <remarks></remarks>
   Private Sub cargarCombos()
      Try
         Dim listMSer As New List(Of ETipos)()
         Dim listMGas As New List(Of ETipos)()
         Dim listMFle As New List(Of ETipos)()
         Dim listMoneda As New List(Of ETipos)()
         For Each Item As ETipos In Colecciones.Tipos(ETipos.MyTipos.TipoMoneda)
            listMFle.Add(Item.Clone())
            listMGas.Add(Item.Clone())
            listMGas.Add(Item.Clone())
            listMoneda.Add(Item.Clone())
         Next
         bs_fmoneda = New BindingSource() : bs_fmoneda.DataSource = listMFle
         bs_smoneda = New BindingSource() : bs_smoneda.DataSource = listMSer
         bs_gmoneda = New BindingSource() : bs_gmoneda.DataSource = listMGas
         ACUtilitarios.ACCargaCombo(cmbFMoneda, bs_fmoneda, "TIPOS_Descripcion", "TIPOS_Codigo")
         ACUtilitarios.ACCargaCombo(cmbGMoneda, bs_gmoneda, "TIPOS_Descripcion", "TIPOS_Codigo")
         ACUtilitarios.ACCargaCombo(cmbSMoneda, bs_smoneda, "TIPOS_Descripcion", "TIPOS_Codigo")
         ACUtilitarios.ACCargaCombo(cmbMoneda, listMoneda, "TIPOS_Descripcion", "TIPOS_Codigo")
         AddHandler bs_fmoneda.CurrentChanged, AddressOf bs_fmoneda_CurrentChanged
         AddHandler bs_gmoneda.CurrentChanged, AddressOf bs_gmoneda_CurrentChanged
         AddHandler bs_smoneda.CurrentChanged, AddressOf bs_smoneda_CurrentChanged

         Dim listBus As New List(Of ETipos)()
         Dim listGas As New List(Of ETipos)()
         Dim listFle As New List(Of ETipos)()
         Dim listSer As New List(Of ETipos)()
         Dim listBas As New List(Of ETipos)()
         For Each Item As ETipos In Colecciones.TiposDocMerTransito()
            listBus.Add(Item.Clone())
            listGas.Add(Item.Clone())
            listFle.Add(Item.Clone())
            listSer.Add(Item.Clone())
            listBas.Add(Item.Clone())
         Next
         ACUtilitarios.ACCargaCombo(cmbTipoDocumento, listBus, "TIPOS_Descripcion", "TIPOS_Codigo")
         ACUtilitarios.ACCargaCombo(cmbFTipoDocumento, listFle, "TIPOS_Descripcion", "TIPOS_Codigo")
         ACUtilitarios.ACCargaCombo(cmbGTipoDocumento, listGas, "TIPOS_Descripcion", "TIPOS_Codigo")
         ACUtilitarios.ACCargaCombo(cmbSTipoDocumento, listSer, "TIPOS_Descripcion", "TIPOS_Codigo")

      Catch ex As Exception
         Throw ex
      End Try
   End Sub

   ''' <summary>
   ''' valida los datos a ser enviados a la base de datos, para verificar su integridad antes del proceso grabar
   ''' </summary>
   ''' <param name="m_msg"></param>
   ''' <returns></returns>
   ''' <remarks></remarks>
   Private Function validar(ByRef m_msg As String)
      Try
         '' Validar al Cliente
         Dim _msg As String = ""
         Dim _flete As Double = actxnFlete.Text
         If Not ACUtilitarios.ACDatosOk(pnlFletes, _msg) And _flete > 0 Then
            m_msg &= "Falta un campo Obligatorio: " & _msg
            Return False
         End If
         _msg = ""
         Dim _gasto As Double = actxnGasto.Text
         If Not ACUtilitarios.ACDatosOk(pnlGastos, _msg) And _gasto > 0 Then
            m_msg &= _msg
            Return False
         End If
         ' Validar Detalle
         ValidarDetalle(m_msg)
         ' Verificar si hay pedidos
         If Not m_eabas_docscompra.ListEABAS_DocsCompraDetalle.Count > 0 Then
            m_msg &= String.Format("{0}- No se ha ingresado ningun articulo{0}", vbNewLine)
         End If
         Return Not (m_msg.Length > 0)
      Catch ex As Exception
         Throw ex
      End Try
   End Function

   ''' <summary>
   ''' Recorre el detalle y verificar que cada servicio tenga su respectivo producto destino y su proveedor, asi
   ''' como los datos minimos del mismo
   ''' </summary>
   ''' <param name="m_msg"></param>
   ''' <returns></returns>
   ''' <remarks></remarks>
   Private Function ValidarDetalle(ByRef m_msg As String) As Boolean
      Try
         For Each Item As EABAS_DocsCompraDetalle In m_eabas_docscompra.ListEABAS_DocsCompraDetalle
            If Item.Servicio > 0 Then
               If IsNothing(Item.CServicios) Then
                  m_msg &= String.Format("- El Item del articulo: {0}, tiene un servicio que no tiene datos completos{1}", Item.ARTIC_Codigo, vbNewLine)
               Else
                  If IsNothing(Item.CServicios.ARTIC_Codigo) Then
                     m_msg &= String.Format("- El Item del articulo: {0}, tiene un servicio activado, pero no tiene el articulo destino {1}", Item.ARTIC_Codigo, vbNewLine)
                  End If
                  If IsNothing(Item.CServicios.COSTE_CodigoProveedor) Then
                     m_msg &= String.Format("- El Item del articulo: {0}, tiene un servicio activado, pero no un proveedor del servicio{1}", Item.ARTIC_Codigo, vbNewLine)
                  End If
                  If IsNothing(Item.CServicios.COSTE_CodigoDocumento) Then
                     m_msg &= String.Format("- El Item del articulo: {0}, tiene un servicio activado, pero no un documento de referencia{1}", Item.ARTIC_Codigo, vbNewLine)
                  End If
               End If
               If Not Item.COSTE_Cantidad > 0 Then
                  m_msg &= String.Format("- El Item del articulo: {0}, tiene un servicio activado, pero no tiene una cantidad definida{1}", Item.ARTIC_Codigo, vbNewLine)
               End If
            End If
         Next
         Return Not (m_msg.Length > 0)
      Catch ex As Exception
         Throw ex
      End Try
   End Function

   ''' <summary>
   ''' Obtener los campos para la busqueda
   ''' </summary>
   ''' <returns></returns>
   ''' <remarks></remarks>
   Private Function getCampo() As Short
      Try
         If (rbtnProveedor.Checked) Then
            Return 0
         ElseIf rbtnNroOrdenCompra.Checked Then
            Return 1
         Else
            Return 0
         End If
      Catch ex As Exception
         Throw ex
      End Try
   End Function

#End Region

#Region " Cargar Datos "
   ''' <summary>
   ''' asignar los valores respectivos a los gastos a los controles respectivos
   ''' </summary>
   ''' <remarks></remarks> 
   Private Sub setGasto()
      Try
         If Not IsNothing(m_gasto.COSTE_CodigoDocumento) Then
            Dim _tdoc As String = ETipos.getTipoComprobante(ETipos.TipoComprobanteVenta.Ticket).Substring(3, 2)
            If m_gasto.COSTE_CodigoDocumento.Substring(0, 2).Equals(_tdoc) Then
               cmbGTipoDocumento.SelectedValue = ETipos.getTipoComprobante(ETipos.TipoComprobanteVenta.Ticket)
               txtGSerie.Text = m_gasto.COSTE_CodigoDocumento.Substring(2, 4)
               actxnGNumero.Text = m_gasto.COSTE_CodigoDocumento.Substring(6, 9)
            Else
               cmbGTipoDocumento.SelectedValue = ETipos.getCodTipo(ETipos.MyTipos.TipoDocComprobante) & m_gasto.COSTE_CodigoDocumento.Substring(0, 2)
               txtGSerie.Text = m_gasto.COSTE_CodigoDocumento.Substring(2, 3)
               actxnGNumero.Text = m_gasto.COSTE_CodigoDocumento.Substring(5, 7)
            End If
            actxaGProvRazonSocial.Text = m_gasto.ENTID_RazonSocial
            actxaGCodProveedor.Text = m_gasto.COSTE_CodigoProveedor
         End If
      Catch ex As Exception
         Throw ex
      End Try
   End Sub

   ''' <summary>
   '''  asignar los valores respectivos a los fletes a los controles respectivos
   ''' </summary>
   ''' <remarks></remarks>
   Private Sub setFlete()
      Try
         If Not IsNothing(m_flete.COSTE_CodigoDocumento) Then
            Dim _tdoc As String = ETipos.getTipoComprobante(ETipos.TipoComprobanteVenta.Ticket).Substring(3, 2)
            If m_flete.COSTE_CodigoDocumento.Substring(0, 2).Equals(_tdoc) Then
               cmbFTipoDocumento.SelectedValue = ETipos.getTipoComprobante(ETipos.TipoComprobanteVenta.Ticket)
               txtFSerie.Text = m_flete.COSTE_CodigoDocumento.Substring(2, 4)
               actxnFNumero.Text = m_flete.COSTE_CodigoDocumento.Substring(6, 9)
            Else
               cmbFTipoDocumento.SelectedValue = ETipos.getCodTipo(ETipos.MyTipos.TipoDocComprobante) & m_flete.COSTE_CodigoDocumento.Substring(0, 2)
               txtFSerie.Text = m_flete.COSTE_CodigoDocumento.Substring(2, 3)
               actxnFNumero.Text = m_flete.COSTE_CodigoDocumento.Substring(5, 7)
            End If
            actxaFProvRazonSocial.Text = m_flete.ENTID_RazonSocial
            actxaFCodProveedor.Text = m_flete.COSTE_CodigoProveedor
         End If
      Catch ex As Exception
         Throw ex
      End Try
   End Sub

   ''' <summary>
   ''' asignar los valores a la interfaz de la clase servicios
   ''' </summary>
   ''' <remarks></remarks>
   Private Sub setServicios()
      Try
         If Not IsNothing(m_servicios.COSTE_CodigoDocumento) Then
            Dim _tdoc As String = ETipos.getTipoComprobante(ETipos.TipoComprobanteVenta.Ticket).Substring(3, 2)
            If m_servicios.COSTE_CodigoDocumento.Substring(0, 2).Equals(_tdoc) Then
               cmbSTipoDocumento.SelectedValue = ETipos.getTipoComprobante(ETipos.TipoComprobanteVenta.Ticket)
               txtSSerie.Text = m_servicios.COSTE_CodigoDocumento.Substring(2, 4)
               actxnSNumero.Text = m_servicios.COSTE_CodigoDocumento.Substring(6, 9)
            Else
               cmbSTipoDocumento.SelectedValue = ETipos.getCodTipo(ETipos.MyTipos.TipoDocComprobante) & m_servicios.COSTE_CodigoDocumento.Substring(0, 2)
               txtSSerie.Text = m_servicios.COSTE_CodigoDocumento.Substring(2, 3)
               actxnSNumero.Text = m_servicios.COSTE_CodigoDocumento.Substring(5, 7)
            End If
            actxaSProvRazonSocial.Text = m_servicios.ENTID_RazonSocial
            actxaSCodProveedor.Text = m_servicios.COSTE_CodigoProveedor
         End If
      Catch ex As Exception
         Throw ex
      End Try
   End Sub

   Private Sub LimpiarBinding()
      Try
         If Not IsNothing(m_listBindHelper) Then
            For Each Item As ACBindHelper In m_listBindHelper
               Item.ACUnBind()
            Next
         End If
      Catch ex As Exception
         Throw ex
      End Try
   End Sub

   ''' <summary>
   ''' crear el enlace de los objetos visuales y las clases de la capa esquemas
   ''' </summary>
   ''' <remarks></remarks>
   Private Sub AsignarBinding()
      Try
         m_listBindHelper = New List(Of ACBindHelper)()
         If m_eabas_docscompra.DOCCO_FechaDocumento.Year < 1700 Then m_eabas_docscompra.DOCCO_FechaDocumento = DateTime.Now
         m_listBindHelper.Add(ACBindHelper.ACBind(dtpFecha, "Value", m_eabas_docscompra, "DOCCO_FechaDocumento"))
         m_listBindHelper.Add(ACBindHelper.ACBind(txtProvCodigo, "Text", m_eabas_docscompra, "ENTID_CodigoProveedor"))
         m_listBindHelper.Add(ACBindHelper.ACBind(cmbMoneda, "SelectedValue", m_eabas_docscompra, "TIPOS_CodTipoMoneda"))
         m_listBindHelper.Add(ACBindHelper.ACBind(actxnTipoCambio, "Text", m_eabas_docscompra, "DOCCO_TipoCambioSunat"))
         If m_eabas_docscompra.DOCCO_FechaPago.Year < 1700 Then m_eabas_docscompra.DOCCO_FechaPago = DateTime.Now
         m_listBindHelper.Add(ACBindHelper.ACBind(actxnImporte, "Text", m_eabas_docscompra, "DOCCO_ImporteCompra"))
         m_listBindHelper.Add(ACBindHelper.ACBind(actxnIGV, "Text", m_eabas_docscompra, "DOCCO_ImporteIgv"))
         m_listBindHelper.Add(ACBindHelper.ACBind(actxnTotal, "Text", m_eabas_docscompra, "DOCCO_TotalCompra"))
         m_listBindHelper.Add(ACBindHelper.ACBind(actxaOrdCompra, "Text", m_eabas_docscompra, "ORDCO_Codigo"))
      Catch ex As Exception
         Throw ex
      End Try
   End Sub

   ''' <summary>
   ''' crear el enlace de los objetos visuales y las clases de la capa esquemas de los fletes
   ''' </summary>
   ''' <remarks></remarks>
   Private Sub ABFletes()
      Try
         m_listBH_Flete = New List(Of ACBindHelper)()
         m_listBH_Flete.Add(ACBindHelper.ACBind(actxaFCodProveedor, "Text", m_flete, "COSTE_CodigoProveedor"))
         m_listBH_Flete.Add(ACBindHelper.ACBind(actxnFlete, "Text", m_flete, "COSTE_Importe"))
         m_listBH_Flete.Add(ACBindHelper.ACBind(cmbFMoneda, "SelectedValue", m_flete, "TIPOS_CodTipoMoneda"))
      Catch ex As Exception
         Throw ex
      End Try
   End Sub

   ''' <summary>
   ''' crear el enlace de los objetos visuales y las clases de la capa esquemas de los servicios
   ''' </summary>
   ''' <remarks></remarks>
   Private Sub ABServicios()
      Try
         m_listBH_Servicios = New List(Of ACBindHelper)()
         m_listBH_Servicios.Add(ACBindHelper.ACBind(actxaSCodProveedor, "Text", m_servicios, "COSTE_CodigoProveedor"))
         m_listBH_Servicios.Add(ACBindHelper.ACBind(actxnGastoServicio, "Text", m_servicios, "COSTE_Importe"))
         m_listBH_Servicios.Add(ACBindHelper.ACBind(cmbSMoneda, "SelectedValue", m_servicios, "TIPOS_CodTipoMoneda"))
      Catch ex As Exception
         Throw ex
      End Try
   End Sub

   ''' <summary>
   ''' crear el enlace de los objetos visuales y las clases de la capa esquemas de los gastos
   ''' </summary>
   ''' <remarks></remarks>
   Private Sub ABGastos()
      Try
         m_listBH_Gastos = New List(Of ACBindHelper)()
         m_listBH_Gastos.Add(ACBindHelper.ACBind(actxaGCodProveedor, "Text", m_gasto, "COSTE_CodigoProveedor"))
         m_listBH_Gastos.Add(ACBindHelper.ACBind(actxnGasto, "Text", m_gasto, "COSTE_Importe"))
         m_listBH_Gastos.Add(ACBindHelper.ACBind(cmbGMoneda, "SelectedValue", m_gasto, "TIPOS_CodTipoMoneda"))
      Catch ex As Exception
         Throw ex
      End Try
   End Sub

   ''' <summary>
   ''' ayuda para cargar la ayuda de entidad
   ''' </summary>
   ''' <param name="x_cadenas">Cadena a buscar</param>
   ''' <param name="x_campo">Campo por el cual se realiza la busqueda</param>
   ''' <param name="x_opcion"></param>
   ''' <remarks></remarks>
   Private Sub AyudaEntidad(ByVal x_cadenas As String, ByVal x_campo As String, ByVal x_opcion As EEntidades.TipoEntidad)
      Try
         Dim _where As New Hashtable
         _where.Add(x_campo, New ACWhere(x_cadenas, ACWhere.TipoWhere._Like))
         managerEntidades.Ayuda(_where, x_opcion)
         Dim Ayuda As New ACControlesC1.ACAyudaFlex("Buscar Entidad", managerEntidades.DTEntidades, False)
         If Ayuda.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Select Case x_opcion
               Case EEntidades.TipoEntidad.ProveedoresLogistica
                  If tabCosteo.SelectedTab Is tpgFlete Then
                     actxaFCodProveedor.Text = Ayuda.Respuesta.Rows(0)("Codigo").ToString()
                     actxaFProvRazonSocial.Text = Ayuda.Respuesta.Rows(0)("Razon Social").ToString()
                     ' '' Cargar datos adicionales Proveedor
                  ElseIf tabCosteo.SelectedTab Is tpgGastos Then
                     actxaGCodProveedor.Text = Ayuda.Respuesta.Rows(0)("Codigo").ToString()
                     actxaGProvRazonSocial.Text = Ayuda.Respuesta.Rows(0)("Razon Social").ToString()
                     ' '' Cargar datos adicionales Proveedor
                  Else
                     actxaSCodProveedor.Text = Ayuda.Respuesta.Rows(0)("Codigo").ToString()
                     actxaSProvRazonSocial.Text = Ayuda.Respuesta.Rows(0)("Razon Social").ToString()
                     ' '' Cargar datos adicionales Proveedor
                  End If
            End Select
         End If
      Catch ex As Exception
         Throw ex
      End Try
   End Sub

   ''' <summary>
   ''' Cargar los datos de costeo a la grilla de busqueda
   ''' </summary>
   ''' <remarks></remarks>
   Private Sub cargarDatos()
      Try
         bs_docscompra = New BindingSource()
         bs_docscompra.DataSource = managerABAS_DocsCompra.ListABAS_DocsCompra
         c1grdBusqueda.DataSource = bs_docscompra
         bnavBusqueda.BindingSource = bs_docscompra
         AddHandler bs_docscompra.CurrentChanged, AddressOf bs_registrocompras_CurrentChanged
         bs_registrocompras_CurrentChanged(Nothing, Nothing)
      Catch ex As Exception
         Throw ex
      End Try
   End Sub

   Private Sub bs_registrocompras_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
      Try
         If Not IsNothing(bs_docscompra) Then
            If Not IsNothing(bs_docscompra.Current) Then
               If CType(bs_docscompra.Current, EABAS_DocsCompra).DOCCO_Estado = EABAS_DocsCompra.getEstado(EABAS_DocsCompra.Estado.Ingresado) Then
                  acbtnCostear.Enabled = True
                  acTool.ACBtnModificarVisible = False
                  If CType(bs_docscompra.Current, EABAS_DocsCompra).TIPOS_CodTipoDocumento = ETipos.getTipoComprobante(ETipos.TipoComprobanteVenta.NotaCredito) Then
                     acbtnCostear.Enabled = False
                  End If
               Else
                  acbtnCostear.Enabled = False
                  acTool.ACBtnModificarVisible = True
               End If
            End If
         End If
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso Cargar Propiedades del Cotización/Pedido", ex)
      End Try
   End Sub

   Private Sub bs_doccomprasdetalle_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
      Try
         If Not IsNothing(bs_detdocscompra) Then
            If Not IsNothing(bs_detdocscompra.Current) Then

            End If
         End If
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso Cargar Propiedades del Cotización/Pedido", ex)
      End Try
   End Sub

   Private Sub bs_fmoneda_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
      Try
         If Not IsNothing(bs_fmoneda) Then
            If Not IsNothing(bs_fmoneda.Current) Then
               calcular()
            End If
         End If
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso moneda", ex)
      End Try
   End Sub

   Private Sub bs_gmoneda_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
      Try
         If Not IsNothing(bs_gmoneda) Then
            If Not IsNothing(bs_gmoneda.Current) Then
               calcular()
            End If
         End If
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso moneda", ex)
      End Try
   End Sub

   Private Sub bs_smoneda_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
      Try
         If Not IsNothing(bs_smoneda) Then
            If Not IsNothing(bs_smoneda.Current) Then
               calcular()
            End If
         End If
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso moneda", ex)
      End Try
   End Sub
#End Region

#Region " Procesos "

   Private Sub Ordenar(ByVal x_columna As String)
      Dim _ordenador As New ACOrdenador(Of EABAS_DocsCompra)
      Try
         If m_order = 2 Then x_columna += " DESC"
         _ordenador.ACOrdenamiento = x_columna
         CType(bs_docscompra.DataSource, List(Of EABAS_DocsCompra)).Sort(_ordenador)
         c1grdBusqueda.Refresh()
         m_order = IIf(m_order = 1, 2, 1)
      Catch ex As Exception
         Throw ex
      End Try
   End Sub

   Private Function getMonto(ByVal x_opcion As TipoCosteo, ByRef combo As ComboBox, ByVal _tcambio As Double, ByVal x_monto As Double) As Double
      Try
         Select Case x_opcion
            Case TipoCosteo.Flete
               If Not IsNothing(cmbFMoneda.SelectedValue) Then
                  If cmbMoneda.SelectedValue = cmbFMoneda.SelectedValue Then
                     x_monto = actxnFlete.Text
                  Else
                     If combo.SelectedValue = ETipos.getTipo(ETipos.TipoMoneda.Soles) Then
                        x_monto = x_monto / _tcambio
                     ElseIf combo.SelectedValue = ETipos.getTipo(ETipos.TipoMoneda.Dolares) Then
                        x_monto = x_monto * _tcambio
                     Else
                        x_monto = x_monto / _tcambio
                     End If
                  End If
               End If
               Return x_monto
            Case TipoCosteo.Gasto
               If Not IsNothing(cmbGMoneda.SelectedValue) Then
                  If cmbMoneda.SelectedValue = cmbGMoneda.SelectedValue Then
                     x_monto = actxnGasto.Text
                  Else
                     If combo.SelectedValue = ETipos.getTipo(ETipos.TipoMoneda.Soles) Then
                        x_monto = x_monto / _tcambio
                     ElseIf combo.SelectedValue = ETipos.getTipo(ETipos.TipoMoneda.Dolares) Then
                        x_monto = x_monto * _tcambio
                     Else
                        x_monto = x_monto / _tcambio
                     End If
                  End If
               End If
               Return x_monto
            Case TipoCosteo.Servicio
               If Not IsNothing(cmbSMoneda.SelectedValue) Then
                  If cmbMoneda.SelectedValue = cmbSMoneda.SelectedValue Then
                     x_monto = actxnGastoServicio.Text
                  Else
                     If combo.SelectedValue = ETipos.getTipo(ETipos.TipoMoneda.Soles) Then
                        x_monto = x_monto / _tcambio
                     ElseIf combo.SelectedValue = ETipos.getTipo(ETipos.TipoMoneda.Dolares) Then
                        x_monto = x_monto * _tcambio
                     Else
                        x_monto = x_monto / _tcambio
                     End If
                  End If
               End If
               Return x_monto
            Case Else
               Return 0
         End Select
      Catch ex As Exception
         Throw ex
      End Try
   End Function

   ''' <summary>
   ''' Proceso para calcular los valores numericos en la interfaz
   ''' </summary>
   ''' <remarks></remarks>
   Private Sub calcular()
      Try
         If Not IsNothing(m_eabas_docscompra) Then
            If Not IsNothing(m_eabas_docscompra.ListEABAS_DocsCompraDetalle) Then
               Dim _tcambio As Double = actxnTipoCambio.Text
               Dim _flete As Double = getMonto(TipoCosteo.Flete, cmbFMoneda, _tcambio, actxnFlete.Text)
               Dim _gasto As Double = getMonto(TipoCosteo.Gasto, cmbGMoneda, _tcambio, actxnGasto.Text)
               Dim _servicio As Double = getMonto(TipoCosteo.Servicio, cmbSMoneda, _tcambio, actxnGastoServicio.Text)

               Dim igv As Double = Parametros.GetParametro(EParametros.TipoParametros.PIGV)
               Dim _igv As Double = IIf(Parametros.GetParametro(EParametros.TipoParametros.PIGV).ToString() = "", 0, Parametros.GetParametro(EParametros.TipoParametros.PIGV))
               If _igv = 0 Then
                  acTool.ACBtnGrabarEnabled = False
                  Throw New Exception("El I.G.V. No puede ser 0, por favor revise el parametro y coloque el valor adecuado")
               Else
                  acTool.ACBtnGrabarEnabled = True
               End If
               igv = igv / 100 + 1
               '' Obtiene los codigo para los respectivos registros
               getNroDocumentos()
               For Each Item As EABAS_DocsCompraDetalle In m_eabas_docscompra.ListEABAS_DocsCompraDetalle
                  Dim _costo As Double = Item.DOCCD_SubImporteCompra / Item.DOCCD_Cantidad
                  Dim _gastosXitem As Double = ((_gasto * Item.DOCCD_SubPeso) / 1000) / Item.DOCCD_Cantidad
                  Item.CCosteos = New List(Of EABAS_Costeos)()
                  If _gastosXitem > 0 Then Item.CCosteos.Add(New EABAS_Costeos(Item.ARTIC_Codigo, Item.ENTID_CodigoProveedor, Item.DOCCD_Item, ETipos.getTipo(ETipos.TipoCosteo.Gastos), _gastosXitem, m_gasto.COSTE_CodigoDocumento, m_gasto.COSTE_CodigoProveedor))
                  Dim _fleteXitem As Double = ((Item.DOCCD_SubPeso * _flete) / 1000) / Item.DOCCD_Cantidad
                  If _fleteXitem > 0 Then Item.CCosteos.Add(New EABAS_Costeos(Item.ARTIC_Codigo, Item.ENTID_CodigoProveedor, Item.DOCCD_Item, ETipos.getTipo(ETipos.TipoCosteo.Fletes), _fleteXitem, m_flete.COSTE_CodigoDocumento, m_flete.COSTE_CodigoProveedor))
                  Dim _servicioXitem As Double = ((Item.DOCCD_SubPeso * _servicio) / 1000) / Item.DOCCD_Cantidad
                  If _servicioXitem > 0 Then Item.CCosteos.Add(New EABAS_Costeos(Item.ARTIC_Codigo, Item.ENTID_CodigoProveedor, Item.DOCCD_Item, ETipos.getTipo(ETipos.TipoCosteo.Servicio), _servicioXitem, m_servicios.COSTE_CodigoDocumento, m_servicios.COSTE_CodigoProveedor))
                  Item.Servicio = _servicioXitem * Item.DOCCD_Cantidad
                  '' Calcular el descuento, usando reflection
                  Dim _tipo As Type = GetType(EABAS_DocsCompraDetalle)
                  Dim _info As PropertyInfo
                  Dim _descuento As Double = 0
                  '' Recorrer los descuentos
                  For index As Integer = 1 To nudNroDescuentos.Value
                     Dim x_campo As String = String.Format("Descuento_{0}", index.ToString())
                     _info = _tipo.GetProperty(x_campo)
                     Dim _des As Double = CType(_info.GetValue(Item, Nothing), Decimal)
                     _descuento = _costo * (_des / 100)
                     _costo -= _descuento
                     If _descuento > 0 Then
                        Dim x_descuento As New EABAS_Costeos(Item.ARTIC_Codigo, Item.ENTID_CodigoProveedor, Item.DOCCD_Item, ETipos.getTipo(ETipos.TipoCosteo.Descuentos))
                        x_descuento.COSTE_Porcentaje = _des
                        x_descuento.COSTE_Importe = _descuento
                        Item.CCosteos.Add(x_descuento)
                     End If
                  Next
                  Dim _total As Double = _costo + _gastosXitem + _fleteXitem + _servicioXitem
                  Item.Costo = _total * igv
                  Item.CostoIGV = _total
               Next
               bs_detdocscompra.ResetBindings(False)
               c1grdDetalle.AutoSizeCols()
            Else
               ACControles.ACDialogos.ACMostrarMensajeInformacion(String.Format("Información: {0}", Me.Text), "No se puede calcular, por que no existen registros")
            End If
         Else
            ACControles.ACDialogos.ACMostrarMensajeInformacion(String.Format("Información: {0}", Me.Text), "No se puede calcular por que no se ha cargado un documento de compra")
         End If
      Catch ex As Exception
         Throw ex
      End Try
   End Sub

   ''' <summary>
   ''' Convertir una orden de compra a documento de venta
   ''' </summary>
   ''' <param name="x_codigo"></param>
   ''' <remarks></remarks>
   Private Sub setOrdenToDocCompra(ByVal x_codigo As String)
      Try
         If managerABAS_OrdenesCompra.Cargar(x_codigo, True) Then
            '' Inicializar clase 
            m_eabas_docscompra = New EABAS_DocsCompra
            m_eabas_docscompra.Instanciar(ACEInstancia.Nuevo)
            setInstancia(ACUtilitarios.ACSetInstancia.Nuevo)
            '' Asignar Valores de la orden de compra: Cabecera
            Dim _orden As EABAS_OrdenesCompra = managerABAS_OrdenesCompra.ABAS_OrdenesCompra
            m_eabas_docscompra.ORDCO_Codigo = _orden.ORDCO_Codigo
            m_eabas_docscompra.ENTID_CodigoProveedor = _orden.ENTID_CodigoProveedor
            '' Asignar Valores de la orden de compra: Detalle
            m_eabas_docscompra.ListEABAS_DocsCompraDetalle = New List(Of EABAS_DocsCompraDetalle)()
            For Each Item As EABAS_OrdenesCompraDetalle In _orden.ListABAS_OrdenesCompraDetalle
               Dim _detalle As New EABAS_DocsCompraDetalle() With {.ARTIC_Codigo = Item.ARTIC_Codigo, .ARTIC_Descripcion = Item.ARTIC_Descripcion, .DOCCD_Cantidad = Item.ORDCD_Cantidad, .DOCCD_PesoUnitario = Item.ORDCD_PesoUnitario, .DOCCD_PrecioUnitario = Item.ORDCD_PrecioUnitario, .DOCCD_SubImporteCompra = Item.ORDCD_SubImporteCompra}
               m_eabas_docscompra.ListEABAS_DocsCompraDetalle.Add(_detalle)
            Next
            txtProvNombres.Text = m_eabas_docscompra.ENTID_Proveedor
            '' Instanciar clase
            LimpiarBinding()
            AsignarBinding()
            '' Cambiar tipo de cambio
            managerTipoCambio.getUltTipoCambio()
            actxnTipoCambio.Text = managerTipoCambio.TipoCambio.TIPOC_CompraOficina
            '' Para Cargar detalle del producto
            bs_detdocscompra = New BindingSource
            bs_detdocscompra.DataSource = m_eabas_docscompra.ListEABAS_DocsCompraDetalle
            c1grdDetalle.DataSource = bs_detdocscompra
            bnavProductos.BindingSource = bs_detdocscompra

            tabMantenimiento.SelectedTab = tabDatos
            txtProvCodigo.Focus()
         End If
      Catch ex As Exception
         Throw ex
      End Try
   End Sub

   ''' <summary>
   ''' Nuevo costeo, inicializa los controles necesarios para crear un nuevo costeo a partir de un documento 
   ''' de venta
   ''' </summary>
   ''' <remarks></remarks>
   Private Sub nuevoCosteoCompra()
      Try
         ' Cargar el tipo de cambio
         managerTipoCambio.getUltTipoCambio()
         actxnTipoCambio.Text = managerTipoCambio.TipoCambio.TIPOC_CompraOficina
         '' Inicializar clase 
         m_eabas_docscompra = New EABAS_DocsCompra
         '' Cargar la clase
         Dim x_codigo As String = CType(bs_docscompra.Current, EABAS_DocsCompra).DOCCO_Codigo
         Dim x_enti_codigo As String = CType(bs_docscompra.Current, EABAS_DocsCompra).ENTID_CodigoProveedor
         If managerABAS_DocsCompra.ObtenerDocCosteados(x_enti_codigo, x_codigo, True) Then
            m_eabas_docscompra = managerABAS_DocsCompra.ABAS_DocsCompra
            '' Instanciar clase
            AsignarBinding()
            txtProvNombres.Text = CType(bs_docscompra.Current, EABAS_DocsCompra).ENTID_Proveedor
            setInstancia(ACUtilitarios.ACSetInstancia.Nuevo)
            '' Para Cargar detalle del producto si el primer item tiene como destino a produccion
            If m_eabas_docscompra.ListEABAS_DocsCompraDetalle.Count > 0 Then
               If m_eabas_docscompra.ListEABAS_DocsCompraDetalle(0).TIPOS_CodTipoDestino.Equals(ETipos.getTipo(ETipos.TipoDestino.Produccion)) Then
                  For Each Item As EABAS_DocsCompraDetalle In m_eabas_docscompra.ListEABAS_DocsCompraDetalle
                     Item.COSTE_Cantidad = Item.DOCCD_Cantidad
                  Next
                  c1grdDetalle.Cols("COSTE_Cantidad").Visible = True
                  c1grdDetalle.Cols("ARTIC_CodServicio").Visible = True
                  c1grdDetalle.Cols("ARTIC_DesServicio").Visible = True
                  tpgServicios.Enabled = True
               Else
                  c1grdDetalle.Cols("COSTE_Cantidad").Visible = False
                  c1grdDetalle.Cols("ARTIC_CodServicio").Visible = False
                  c1grdDetalle.Cols("ARTIC_DesServicio").Visible = False
                  tpgServicios.Enabled = False
               End If
            End If
            bs_detdocscompra = New BindingSource
            bs_detdocscompra.DataSource = m_eabas_docscompra.ListEABAS_DocsCompraDetalle
            AddHandler bs_detdocscompra.CurrentChanged, AddressOf bs_doccomprasdetalle_CurrentChanged
            c1grdDetalle.DataSource = bs_detdocscompra
            bnavProductos.BindingSource = bs_detdocscompra
            '' Iniciar Clases Internas
            tabMantenimiento.SelectedTab = tabDatos
            txtProvCodigo.Focus()
         Else
            acTool.setInstancia(ACControles.ACToolBarMantHorizontalNew.TipoInstancia.Cancelar)
            ACControles.ACDialogos.ACMostrarMensajeInformacion(String.Format("Información: {0}", Me.Text), "No se puede cargar el documento de venta")
         End If
      Catch ex As Exception
         Throw ex
      End Try
   End Sub

   ''' <summary>
   ''' realizar la busqueda de los documentos de compra que pueden costearse
   ''' </summary>
   ''' <param name="x_cadena">Cadena que se busca</param>
   ''' <param name="x_documento">opcion para buscar por numero documento o cadena de texto</param>
   ''' <returns></returns>
   ''' <remarks></remarks>
   Private Function busqueda(ByVal x_cadena As String, Optional ByVal x_documento As Boolean = False) As Boolean
      Try
         If x_documento Then
            If managerABAS_DocsCompra.Busqueda(cmbTipoDocumento.SelectedValue, txtCSerie.Text, txtBusNumero.Text, chkTodos.Checked, acFecha.ACDtpFecha_De.Value.Date, acFecha.ACDtpFecha_A.Value.Date) Then
               acTool.ACBtnEliminarEnabled = True
               acTool.ACBtnModificarEnabled = True
            Else
               acTool.ACBtnEliminarEnabled = False
               acTool.ACBtnModificarEnabled = False
            End If
            cargarDatos()
         Else
            'If txtBusqueda.ACEstadoAutoAyuda Then
            If managerABAS_DocsCompra.Busqueda(GApp.Zona, GApp.Sucursal, x_cadena, getCampo(), chkTodos.Checked, acFecha.ACDtpFecha_De.Value.Date, acFecha.ACDtpFecha_A.Value.Date) Then
               acTool.ACBtnEliminarEnabled = True
               acTool.ACBtnModificarEnabled = True
            Else
               acTool.ACBtnEliminarEnabled = False
               acTool.ACBtnModificarEnabled = False
            End If
            cargarDatos()
            'End If
            Return acTool.ACBtnEliminarEnabled
         End If
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Convert.ToString(Text)), "No se puede cargar la ayuda de los conductores", ex)
      End Try
      Return False
   End Function

   ''' <summary>
   ''' grabar en la base el costeo realizado
   ''' </summary>
   ''' <param name="m_msg"></param>
   ''' <returns></returns>
   ''' <remarks></remarks>
   Private Function grabarCosteos(ByRef m_msg As String) As Boolean
      Try
         If validar(m_msg) Then
            If ACControles.ACDialogos.ACMostrarMensajePregunta(String.Format("Grabar Costeo: {0}", Me.Text) _
                     , String.Format("Desea grabar el costeo realizado al documento de compra con codigo: {0}?", m_eabas_docscompra.Documento) _
                     , ACControles.ACDialogos.LabelBotom.Si_No) = DialogResult.Yes Then
               '' Cargar Clases
               managerGenerarCosteo.Flete = m_flete
               managerGenerarCosteo.Gasto = m_gasto
               managerGenerarCosteo.Servicios = m_servicios
               '' Grabar
               calcular()
               If managerGenerarCosteo.GrabarCosteo(m_eabas_docscompra, GApp.Usuario) Then
                  Return True
               End If
               Return False
            End If
         End If
         Return False
      Catch ex As Exception
         Throw ex
      End Try
   End Function

   ''' <summary>
   ''' obtener los codigos de los respectivos items, como servicios, gastos, fletes y descuentos respectivos
   ''' </summary>
   ''' <remarks></remarks>
   Private Sub getNroDocumentos()
      Try
         ' Flete
         If Not IsNothing(m_flete) And Not IsNothing(cmbFTipoDocumento.SelectedValue) Then
            Dim x_coddocflete As String
            If ETipos.getTipoComprobante(ETipos.TipoComprobanteVenta.Ticket) = cmbFTipoDocumento.SelectedValue Then
               x_coddocflete = String.Format("{0}{1}{2}", cmbFTipoDocumento.SelectedValue.Substring(3, 2) _
                                             , txtFSerie.Text.PadLeft(4, "0"), actxnFNumero.Text.ToString().PadLeft(9, "0"))
            Else
               x_coddocflete = String.Format("{0}{1}{2}", cmbFTipoDocumento.SelectedValue.Substring(3, 2) _
                                             , txtFSerie.Text.PadLeft(3, "0"), actxnFNumero.Text.ToString().PadLeft(7, "0"))
            End If
            m_flete.COSTE_CodigoDocumento = x_coddocflete
         End If
         If Not IsNothing(m_gasto) And Not IsNothing(cmbGTipoDocumento.SelectedValue) Then
            ' Gasto
            Dim x_coddocgasto As String
            If ETipos.getTipoComprobante(ETipos.TipoComprobanteVenta.Ticket) = cmbGTipoDocumento.SelectedValue Then
               x_coddocgasto = String.Format("{0}{1}{2}", cmbGTipoDocumento.SelectedValue.Substring(3, 2) _
                                             , txtGSerie.Text.PadLeft(4, "0"), actxnGNumero.Text.ToString().PadLeft(9, "0"))
            Else
               x_coddocgasto = String.Format("{0}{1}{2}", cmbGTipoDocumento.SelectedValue.Substring(3, 2) _
                                             , txtGSerie.Text.PadLeft(3, "0"), actxnGNumero.Text.ToString().PadLeft(7, "0"))
            End If
            m_gasto.COSTE_CodigoDocumento = x_coddocgasto
         End If

         If Not IsNothing(m_servicios) And Not IsNothing(cmbSTipoDocumento.SelectedValue) Then
            ' Gasto
            Dim x_coddocservicio As String
            If ETipos.getTipoComprobante(ETipos.TipoComprobanteVenta.Ticket) = cmbSTipoDocumento.SelectedValue Then
               x_coddocservicio = String.Format("{0}{1}{2}", cmbSTipoDocumento.SelectedValue.Substring(3, 2) _
                                             , txtSSerie.Text.PadLeft(4, "0"), actxnSNumero.Text.ToString().PadLeft(9, "0"))
            Else
               x_coddocservicio = String.Format("{0}{1}{2}", cmbSTipoDocumento.SelectedValue.Substring(3, 2) _
                                             , txtSSerie.Text.PadLeft(3, "0"), actxnSNumero.Text.ToString().PadLeft(7, "0"))
            End If
            m_servicios.COSTE_CodigoDocumento = x_coddocservicio
         End If
      Catch ex As Exception
         Throw ex
      End Try
   End Sub

#End Region

#End Region

#Region " Metodos de Controles"

   Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
      If rbtnDatos.Checked Then
         txtBusqueda_ACAyudaClick(Nothing, Nothing)
      ElseIf rbtnDocVenta.Checked Then
         txtBusNumero_ACAyudaClick(Nothing, Nothing)
      End If
   End Sub

   Private Sub cmbGTipoDocumento_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbGTipoDocumento.SelectedIndexChanged
      Try
         If ETipos.getTipoComprobante(ETipos.TipoComprobanteVenta.Ticket) = cmbGTipoDocumento.SelectedValue Then
            txtGSerie.MaxLength = 4
            actxnGNumero.MaxLength = 9
         Else
            If txtGSerie.Text.Length > 3 Then txtGSerie.Text = txtGSerie.Text.Substring(0, 3)
            If actxnGNumero.Text.Length > 7 Then actxnGNumero.Text = actxnGNumero.Text.Substring(0, 7)
            txtGSerie.MaxLength = 3
            actxnGNumero.MaxLength = 7
         End If
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso definiendo documento", ex)
      End Try
   End Sub

   Private Sub cmbSTipoDocumento_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSTipoDocumento.SelectedIndexChanged
      Try
         If ETipos.getTipoComprobante(ETipos.TipoComprobanteVenta.Ticket) = cmbSTipoDocumento.SelectedValue Then
            txtSSerie.MaxLength = 4
            actxnSNumero.MaxLength = 9
         Else
            If txtSSerie.Text.Length > 3 Then txtSSerie.Text = txtSSerie.Text.Substring(0, 3)
            If actxnSNumero.Text.Length > 7 Then actxnSNumero.Text = actxnSNumero.Text.Substring(0, 7)
            txtSSerie.MaxLength = 3
            actxnSNumero.MaxLength = 7
         End If
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso definiendo documento", ex)
      End Try
   End Sub

   Private Sub acbtnCostear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles acbtnCostear.Click
      Try
         If Not IsNothing(bs_docscompra) Then
            If Not IsNothing(bs_docscompra.Current) Then
               RemoveHandler actxnGasto.TextChanged, AddressOf actxnGasto_TextChanged
               RemoveHandler actxnFlete.TextChanged, AddressOf actxnFlete_TextChanged
               RemoveHandler actxnGastoServicio.TextChanged, AddressOf actxnGastoServicio_TextChanged
               RemoveHandler c1grdDetalle.AfterEdit, AddressOf c1grdDetalle_AfterEdit
               RemoveHandler nudNroDescuentos.ValueChanged, AddressOf nudNroDescuentos_ValueChanged

               acTool.setInstancia(ACControles.ACToolBarMantHorizontalNew.TipoInstancia.Nuevo)
               setInstancia(ACUtilitarios.ACSetInstancia.Nuevo)
               nuevoCosteoCompra()
               '' Iniciar Clases elementales
               m_flete = New EABAS_Costeos() : ABFletes()
               m_gasto = New EABAS_Costeos() : ABGastos()
               m_servicios = New EABAS_Costeos() : ABServicios()
               calcular()
               '' Activar las opciones generales del teclado
               KeyPreview = True
               txtDocumento.Text = m_eabas_docscompra.Documento

               AddHandler actxnGasto.TextChanged, AddressOf actxnGasto_TextChanged
               AddHandler actxnFlete.TextChanged, AddressOf actxnFlete_TextChanged
               AddHandler actxnGastoServicio.TextChanged, AddressOf actxnGastoServicio_TextChanged
               AddHandler c1grdDetalle.AfterEdit, AddressOf c1grdDetalle_AfterEdit
               AddHandler nudNroDescuentos.ValueChanged, AddressOf nudNroDescuentos_ValueChanged
            Else
               ACControles.ACDialogos.ACMostrarMensajeInformacion(String.Format("Información: {0}", Me.Text), "No se puede <<Mensaje>> ")
            End If
         Else
            ACControles.ACDialogos.ACMostrarMensajeInformacion(String.Format("Información: {0}", Me.Text), "No se puede <<Mensaje>> ")
         End If
      Catch ex As Exception
         acTool.setInstancia(ACControles.ACToolBarMantHorizontalNew.TipoInstancia.Cancelar)
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso de iniciar costeo", ex)
      End Try
   End Sub

   Private Sub cmbFTipoDocumento_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbFTipoDocumento.SelectedIndexChanged
      Try
         If ETipos.getTipoComprobante(ETipos.TipoComprobanteVenta.Ticket) = cmbFTipoDocumento.SelectedValue Then
            txtFSerie.MaxLength = 4
            actxnFNumero.MaxLength = 9
         Else
            If txtFSerie.Text.Length > 3 Then txtFSerie.Text = txtFSerie.Text.Substring(0, 3)
            If actxnFNumero.Text.Length > 7 Then actxnFNumero.Text = actxnFNumero.Text.Substring(0, 7)
            txtFSerie.MaxLength = 3
            actxnFNumero.MaxLength = 7
         End If
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso definiendo documento", ex)
      End Try
   End Sub

   Private Sub btnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcular.Click
      Try
         calcular()
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso calcular", ex)
      End Try
   End Sub

   Private Sub nudNroDescuentos_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
      Try
         formatearGrilla(nudNroDescuentos.Value)
         nupADescuento.Maximum = nudNroDescuentos.Value
         calcular()
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso modificar descuentos", ex)
      End Try
   End Sub

   Private Sub rbtnDatos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtnDatos.CheckedChanged
      grpCliente.Enabled = rbtnDatos.Checked
      grpDocumentos.Enabled = rbtnDocVenta.Checked
   End Sub

#Region " ToolBar "

   Private Sub acTool_ACBtnSalir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles acTool.ACBtnSalir_Click
      Try
         Me.Close()
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso Salir", ex)
      End Try
   End Sub

   Private Sub acTool_ACBtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles acTool.ACBtnCancelar_Click
      Try
         If ACControles.ACDialogos.ACMostrarMensajePregunta(String.Format("Cancelar Pedido/Cotización: {0}", Me.Text) _
             , "Desea cancelar el Pedido/Cotización?" _
             , ACControles.ACDialogos.LabelBotom.Si_No) = DialogResult.Yes Then
            'acTool.setInstancia(ACControles.ACToolBarMantHorizontalNew.TipoInstancia.Cancelar)
            tabMantenimiento.SelectedTab = tabBusqueda
            setInstancia(ACUtilitarios.ACSetInstancia.Deshacer)
         Else
            acTool.setInstancia(ACControles.ACToolBarMantHorizontalNew.TipoInstancia.Nuevo)
         End If
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso cancelar la Cotización/Pedido", ex)
      End Try
   End Sub

   Private Sub acTool_ACBtnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles acTool.ACBtnModificar_Click
      Try
         If Not IsNothing(bs_docscompra) Then
            If Not IsNothing(bs_docscompra.Current) Then
               '' Codigo
               Dim x_docco_codigo As String = CType(bs_docscompra.Current, EABAS_DocsCompra).DOCCO_Codigo
               Dim x_entid_codigo As String = CType(bs_docscompra.Current, EABAS_DocsCompra).ENTID_CodigoProveedor
               Dim _max As Integer
               If managerGenerarCosteo.CargarCosteo(x_docco_codigo, x_entid_codigo, _max) Then
                  RemoveHandler actxnGasto.TextChanged, AddressOf actxnGasto_TextChanged
                  RemoveHandler actxnFlete.TextChanged, AddressOf actxnFlete_TextChanged
                  RemoveHandler actxnGastoServicio.TextChanged, AddressOf actxnGastoServicio_TextChanged
                  RemoveHandler c1grdDetalle.AfterEdit, AddressOf c1grdDetalle_AfterEdit
                  RemoveHandler nudNroDescuentos.ValueChanged, AddressOf nudNroDescuentos_ValueChanged

                  m_eabas_docscompra = managerGenerarCosteo.ABAS_DocsCompra
                  '' Instanciar clase
                  AsignarBinding()
                  txtProvNombres.Text = m_eabas_docscompra.ENTID_Proveedor
                  setInstancia(ACUtilitarios.ACSetInstancia.Nuevo)
                  RemoveHandler actxnFlete.TextChanged, AddressOf actxnFlete_TextChanged
                  RemoveHandler actxnGasto.TextChanged, AddressOf actxnGasto_TextChanged
                  RemoveHandler actxnGastoServicio.TextChanged, AddressOf actxnGastoServicio_TextChanged
                  m_flete = managerGenerarCosteo.Flete : If IsNothing(m_flete) Then m_flete = New EABAS_Costeos
                  ABFletes() : setFlete()
                  m_gasto = managerGenerarCosteo.Gasto : If IsNothing(m_gasto) Then m_gasto = New EABAS_Costeos
                  ABGastos() : setGasto()
                  m_servicios = managerGenerarCosteo.Servicios : If IsNothing(m_servicios) Then m_servicios = New EABAS_Costeos
                  ABServicios() : setServicios()
                  AddHandler actxnFlete.TextChanged, AddressOf actxnFlete_TextChanged
                  AddHandler actxnGasto.TextChanged, AddressOf actxnGasto_TextChanged
                  AddHandler actxnGastoServicio.TextChanged, AddressOf actxnGastoServicio_TextChanged
                  acTool.setInstancia(ACControles.ACToolBarMantHorizontalNew.TipoInstancia.Nuevo)
                  '' Para Cargar detalle del producto
                  bs_detdocscompra = New BindingSource
                  bs_detdocscompra.DataSource = m_eabas_docscompra.ListEABAS_DocsCompraDetalle
                  AddHandler bs_detdocscompra.CurrentChanged, AddressOf bs_doccomprasdetalle_CurrentChanged
                  c1grdDetalle.DataSource = bs_detdocscompra
                  bnavProductos.BindingSource = bs_detdocscompra
                  '' Iniciar Clases Internas

                  tabMantenimiento.SelectedTab = tabDatos
                  txtProvCodigo.Focus()
                  If _max > 0 Then nudNroDescuentos.Value = _max
                  calcular()
                  '' Activar las opciones generales del teclado
                  KeyPreview = True
                  txtDocumento.Text = m_eabas_docscompra.Documento

                  AddHandler actxnGasto.TextChanged, AddressOf actxnGasto_TextChanged
                  AddHandler actxnFlete.TextChanged, AddressOf actxnFlete_TextChanged
                  AddHandler actxnGastoServicio.TextChanged, AddressOf actxnGastoServicio_TextChanged
                  AddHandler c1grdDetalle.AfterEdit, AddressOf c1grdDetalle_AfterEdit
                  AddHandler nudNroDescuentos.ValueChanged, AddressOf nudNroDescuentos_ValueChanged
               End If
            Else
               ACControles.ACDialogos.ACMostrarMensajeInformacion(String.Format("Información: {0}", Me.Text), "No se puede modificar por que no ha seleccionado un registro")
            End If
         Else
            ACControles.ACDialogos.ACMostrarMensajeInformacion(String.Format("Información: {0}", Me.Text), "No se puede modificar por que no ha cargado ningun registro")
         End If
      Catch ex As Exception
         acTool.setInstancia(ACControles.ACToolBarMantHorizontalNew.TipoInstancia.Cancelar)
         setInstancia(ACUtilitarios.ACSetInstancia.Deshacer)
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso modificar costeo", ex)
      End Try
   End Sub

   Private Sub acTool_ACBtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles acTool.ACBtnNuevo_Click
      Try

      Catch ex As Exception
         acTool.setInstancia(ACControles.ACToolBarMantHorizontalNew.TipoInstancia.Cancelar)
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso Nueva Cotización/Pedido", ex)
      End Try
   End Sub

   Private Sub acTool_ACBtnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles acTool.ACBtnGrabar_Click
      Dim m_msg As String = ""
      Try
         If grabarCosteos(m_msg) Then
            '' Manejar las opciones de la barra de herramientas
            acTool.setInstancia(ACControles.ACToolBarMantHorizontalNew.TipoInstancia.Cancelar)
            tabMantenimiento.SelectedTab = tabBusqueda
            ACControles.ACDialogos.ACMostrarMensajeSatisfactorio(String.Format("Información: {0}", Me.Text), "Grabado Satisfactoriamente")
            btnConsultar_Click(Nothing, Nothing)
            'acTool.ACBtnModificarVisible = m_proceso_modificar
            'txtBusqueda_ACAyudaClick(Nothing, Nothing)
            setInstancia(ACUtilitarios.ACSetInstancia.Guardar)
         Else
            acTool.setInstancia(ACControles.ACToolBarMantHorizontalNew.TipoInstancia.Nuevo)
            ACControles.ACDialogos.ACMostrarMensajeInformacion(String.Format("Información: {0}", Me.Text), "No se puede grabar, revise los detalles:", m_msg)
         End If
      Catch ex As Exception
         acTool.setInstancia(ACControles.ACToolBarMantHorizontalNew.TipoInstancia.Nuevo)
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso Grabar el Costeo", ex)
      End Try
   End Sub

#End Region

#Region " Textos"

   Private Sub txtSSerie_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSSerie.KeyPress
      If Char.IsDigit(e.KeyChar) Then
         e.Handled = False
      ElseIf Char.IsControl(e.KeyChar) Then
         e.Handled = False
      Else
         e.Handled = True
      End If
   End Sub

   Private Sub txtGSerie_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtGSerie.KeyPress
      If Char.IsDigit(e.KeyChar) Then
         e.Handled = False
      ElseIf Char.IsControl(e.KeyChar) Then
         e.Handled = False
      Else
         e.Handled = True
      End If
   End Sub

   Private Sub txtFSerie_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFSerie.KeyPress
      If Char.IsDigit(e.KeyChar) Then
         e.Handled = False
      ElseIf Char.IsControl(e.KeyChar) Then
         e.Handled = False
      Else
         e.Handled = True
      End If
   End Sub

   Private Sub actxnGastoServicio_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
      Try
         If Not actxnGastoServicio.Text.Equals("") Then
            calcular()
         End If
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso calcular", ex)
      End Try
   End Sub

   Private Sub actxnGasto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
      Try
         If Not actxnGasto.Text.Equals("") Then
            calcular()
         End If
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso calcular", ex)
      End Try
   End Sub

   Private Sub actxnFlete_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
      Try
         If Not actxnFlete.Text.Equals("") Then
            calcular()
         End If
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso calcular", ex)
      End Try
   End Sub

#End Region

#Region " Ayudas "

   Private Sub txtBusNumero_ACAyudaClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBusNumero.ACAyudaClick
      Try
         busqueda(txtBusqueda.Text, True)
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Convert.ToString(Text)), "No se puede cargar la ayuda para los registros de compra", ex)
      End Try
   End Sub

   Private Sub txtBusqueda_ACAyudaClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBusqueda.ACAyudaClick
      Try
         busqueda(txtBusqueda.Text)
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Convert.ToString(Text)), "No se puede cargar la ayuda para los registros de compra", ex)
      End Try
   End Sub

   Private Sub actxaProvNombres_ACAyudaClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles actxaFProvRazonSocial.ACAyudaClick, actxaGProvRazonSocial.ACAyudaClick
      Try
         If tabCosteo.SelectedTab Is tpgFlete Then
            AyudaEntidad(actxaFProvRazonSocial.Text, "ENTID_Nombres", EEntidades.TipoEntidad.ProveedoresLogistica)
         Else
            AyudaEntidad(actxaGProvRazonSocial.Text, "ENTID_Nombres", EEntidades.TipoEntidad.ProveedoresLogistica)
         End If
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso busqueda de proveedores por descripción", ex)
      End Try
   End Sub

   Private Sub actxaProvCodigo_ACAyudaClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles actxaFCodProveedor.ACAyudaClick, actxaGCodProveedor.ACAyudaClick, actxaSCodProveedor.ACAyudaClick
      Try
         If tabCosteo.SelectedTab Is tpgFlete Then
            AyudaEntidad(actxaFCodProveedor.Text, "ENTID_Codigo", EEntidades.TipoEntidad.ProveedoresLogistica)
         ElseIf tabCosteo.SelectedTab Is tpgGastos Then
            AyudaEntidad(actxaGCodProveedor.Text, "ENTID_Codigo", EEntidades.TipoEntidad.ProveedoresLogistica)
         Else
            AyudaEntidad(actxaSCodProveedor.Text, "ENTID_Codigo", EEntidades.TipoEntidad.ProveedoresLogistica)
         End If
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso busqueda de proveedores por descripción", ex)
      End Try
   End Sub

#End Region

#Region " Grillas "

   Private Sub c1grdDetalle_CellButtonClick(ByVal sender As System.Object, ByVal e As C1.Win.C1FlexGrid.RowColEventArgs)
      Dim rc As Rectangle = c1grdDetalle.GetCellRect(e.Row, e.Col)
      rc.Offset(0, rc.Height)
      Try
         If c1grdDetalle.Cols(e.Col).Name = "ARTIC_CodServicio" Or c1grdDetalle.Cols(e.Col).Name = "ARTIC_DesServicio" Then
            If cmbSTipoDocumento.SelectedIndex < 0 Or txtSSerie.Text.Equals("") Or actxnSNumero.Text.Equals("") Then
               ACControles.ACDialogos.ACMostrarMensajeInformacion(String.Format("Información: {0}", Me.Text), "No se puede agregar producto destino si no se ha definido el documento del servicio")
               Exit Sub
            End If
            If IsNothing(frmCons) Then
               frmCons = New CProductos(CProductos.Origen.Cotizaciones) With {.StartPosition = FormStartPosition.CenterScreen}
            End If
            Me.KeyPreview = False
            If frmCons.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
               CType(bs_detdocscompra.Current, EABAS_DocsCompraDetalle).ARTIC_CodServicio = frmCons.Articulo.ARTIC_Codigo
               CType(bs_detdocscompra.Current, EABAS_DocsCompraDetalle).ARTIC_DesServicio = frmCons.Articulo.ARTIC_Descripcion

               Dim _servicios As New EABAS_Costeos
               _servicios.DOCCD_Item = CType(bs_detdocscompra.Current, EABAS_DocsCompraDetalle).DOCCD_Item
               _servicios.TIPOS_CodTipoCosteo = ETipos.getTipo(ETipos.TipoCosteo.Servicio)
               _servicios.ARTIC_Descripcion = frmCons.Articulo.ARTIC_Descripcion
               _servicios.ENTID_RazonSocial = m_servicios.ENTID_RazonSocial
               _servicios.ARTIC_Codigo = frmCons.Articulo.ARTIC_Codigo
               _servicios.COSTE_CodigoProveedor = m_servicios.COSTE_CodigoProveedor
               If cmbSTipoDocumento.SelectedValue.ToString() = ETipos.getTipoComprobante(ETipos.TipoComprobanteVenta.Ticket) Then
                  _servicios.COSTE_CodigoDocumento = cmbSTipoDocumento.SelectedValue.ToString().Substring(3, 2) & txtSSerie.Text.PadLeft(4, "0") & actxnSNumero.Text.PadLeft(9, "0")
               Else
                  _servicios.COSTE_CodigoDocumento = cmbSTipoDocumento.SelectedValue.ToString().Substring(3, 2) & txtSSerie.Text.PadLeft(3, "0") & actxnSNumero.Text.PadLeft(7, "0")
               End If
               _servicios.COSTE_Importe = CType(bs_detdocscompra.Current, EABAS_DocsCompraDetalle).Servicio
               CType(bs_detdocscompra.Current, EABAS_DocsCompraDetalle).ARTIC_CodServicio = _servicios.ARTIC_Codigo
               CType(bs_detdocscompra.Current, EABAS_DocsCompraDetalle).ARTIC_DesServicio = _servicios.ARTIC_Descripcion
               CType(bs_detdocscompra.Current, EABAS_DocsCompraDetalle).CServicios = _servicios

               bs_detdocscompra.ResetBindings(False)
               c1grdDetalle.AutoSizeCols()
               c1grdDetalle.Cols("ARTIC_CodServicio").Width = c1grdDetalle.Cols("ARTIC_CodServicio").Width + 20
               Me.KeyPreview = True
            End If
         End If
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso cargar productos", ex)
      End Try
   End Sub

   Private Sub c1grdBusqueda_BeforeSort(ByVal sender As System.Object, ByVal e As C1.Win.C1FlexGrid.SortColEventArgs) Handles c1grdBusqueda.BeforeSort
      Try
         Ordenar(c1grdBusqueda.Cols(e.Col).UserData)
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso ordenar", ex)
      End Try
   End Sub

   Private Sub c1grdDetalle_OwnerDrawCell(ByVal sender As System.Object, ByVal e As C1.Win.C1FlexGrid.OwnerDrawCellEventArgs) Handles c1grdDetalle.OwnerDrawCell
      Try
         If e.Row < c1grdDetalle.Rows.Fixed OrElse e.Col < c1grdDetalle.Cols.Fixed Then Return
         If c1grdDetalle.Cols(e.Col).Name = "Costo" Then
            e.Style = c1grdDetalle.Styles("Confirmado")
         End If
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso colorear columna", ex)
      End Try
   End Sub

   Private Sub c1grdDetalle_AfterEdit(ByVal sender As System.Object, ByVal e As C1.Win.C1FlexGrid.RowColEventArgs)
      Try
         calcular()
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso calcular", ex)
      End Try
   End Sub

   Private Sub c1grdBusqueda_OwnerDrawCell(ByVal sender As System.Object, ByVal e As C1.Win.C1FlexGrid.OwnerDrawCellEventArgs) Handles c1grdBusqueda.OwnerDrawCell
      Try
         If e.Row < c1grdBusqueda.Rows.Fixed OrElse e.Col < c1grdBusqueda.Cols.Fixed Then Return
         If c1grdBusqueda.Rows(e.Row)("DOCCO_Estado") = EABAS_CotizacionesCompra.getEstado(EABAS_CotizacionesCompra.Estado.Confirmado) Then
            e.Style = c1grdBusqueda.Styles("Facturado")
         End If
         If c1grdBusqueda.Rows(e.Row)("DOCCO_Estado") = EABAS_CotizacionesCompra.getEstado(EABAS_CotizacionesCompra.Estado.Anulado) Then
            e.Style = c1grdBusqueda.Styles("Anulado")
         End If
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso cambia de color", ex)
      End Try
   End Sub

   Private Sub c1grdDetalle_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c1grdDetalle.Enter
      Me.KeyPreview = False
   End Sub

#End Region

   Private Sub _KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
      If e.KeyCode = Keys.Enter Then
         If sender.Name = "txtBusqueda" Then
            Exit Sub
         End If
         SendKeys.Send("{TAB}")
      End If
   End Sub

   Private Sub AcFecha_ACFecIni_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles acFecha.ACFecIni_KeyDown
      If e.KeyData = Keys.Enter Then
         AcFecha.ACDtpFecha_A.Focus()
      End If
   End Sub

   Private Sub AcFecha_ACFecFin_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles acFecha.ACFecFin_KeyDown
      If e.KeyData = Keys.Enter Then
         btnConsultar_Click(Nothing, Nothing)
      End If
   End Sub

   Private Sub TOrdenCompra_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
      txtBusqueda_ACAyudaClick(Nothing, Nothing)
   End Sub
#End Region

   Private Sub btnAsignar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAsignar.Click
      Try
         For Each item As EABAS_DocsCompraDetalle In m_eabas_docscompra.ListEABAS_DocsCompraDetalle
            If nupADescuento.Value = 1 Then item.Descuento_1 = actxnPorcDescuento.Text
            If nupADescuento.Value = 2 Then item.Descuento_2 = actxnPorcDescuento.Text
            If nupADescuento.Value = 3 Then item.Descuento_3 = actxnPorcDescuento.Text
            If nupADescuento.Value = 4 Then item.Descuento_4 = actxnPorcDescuento.Text
            If nupADescuento.Value = 5 Then item.Descuento_5 = actxnPorcDescuento.Text
            If nupADescuento.Value = 6 Then item.Descuento_6 = actxnPorcDescuento.Text
            If nupADescuento.Value = 7 Then item.Descuento_7 = actxnPorcDescuento.Text
            If nupADescuento.Value = 8 Then item.Descuento_8 = actxnPorcDescuento.Text
            If nupADescuento.Value = 9 Then item.Descuento_9 = actxnPorcDescuento.Text
            If nupADescuento.Value = 10 Then item.Descuento_10 = actxnPorcDescuento.Text
         Next
         bs_detdocscompra.ResetBindings(False)
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error al momento de asignar los descuentos", ex)
      End Try
   End Sub
End Class
