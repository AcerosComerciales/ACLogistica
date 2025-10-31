Imports C1.Win.C1FlexGrid
Imports ACFramework
Imports ACELogistica
Imports ACBLogistica
Imports ACEVentas
Imports ACBVentas

Imports Microsoft.Practices.Unity
Imports Microsoft.Practices.Unity.Configuration

Public Class TCosteoDescuentos

#Region " Variables "
   Private m_eabas_docscompra As EABAS_DocsCompra

   Private m_listBindHelper As List(Of ACBindHelper)

   Private bs_docscompra As BindingSource
   Private bs_detdocscompra As BindingSource

   Private managerGenerarDocsCompra As IBGenerarDocsCompra
   Private managerABAS_DocsCompra As IBABAS_DocsCompra
   Private managerConsultaArticulos As IBConsultaArticulos
   Private managerEntidades As IBEntidades
   Private managerTipoCambio As IBTipoCambio
   Private managerABAS_OrdenesCompra As IBABAS_OrdenesCompra

   Private m_earticulos As EArticulos

   Private m_modArticulo As Boolean = False
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

         managerGenerarDocsCompra = Principal.containerB.Resolve(Of IBGenerarDocsCompra)("generardocscompraDAO")
         managerABAS_DocsCompra = Principal.containerB.Resolve(Of IBABAS_DocsCompra)("abas_docscompraDAO")
         managerConsultaArticulos = Principal.containerB.Resolve(Of IBConsultaArticulos)("consultaarticulosDAO")
         managerEntidades = Principal.containerB.Resolve(Of IBEntidades)("entidadesDAO")
         managerTipoCambio = Principal.containerB.Resolve(Of IBTipoCambio)("tipocambioDAO")
         managerABAS_OrdenesCompra = Principal.containerB.Resolve(Of IBABAS_OrdenesCompra)("abas_ordenescompraDAO")

         formatearGrilla()
         cargarCombos()
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "No se puede cargar los controles iniciales", ex)
      End Try
   End Sub
#End Region

#Region " Metodos "

#Region " Utilitarios "

   Private Sub formatearGrilla()
      Dim index As Integer = 1
      Try
         ACFrameworkC1.ACUtilitarios.ACFormatearGrilla(c1grdBusqueda, 1, 1, 11, 1, 0)
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Fecha", "DOCCO_FechaDocumento", "DOCCO_FechaDocumento", 150, True, False, "System.DateTime") : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Codigo", "DOCCO_Codigo", "DOCCO_Codigo", 150, True, False, "System.String") : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Orden", "ORDCO_Codigo", "ORDCO_Codigo", 150, True, False, "System.String") : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Proveedor", "ENTID_Proveedor", "ENTID_Proveedor", 150, True, False, "System.String") : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Moneda", "TIPOS_TipoMoneda", "TIPOS_TipoMoneda", 150, True, False, "System.String") : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Total Compra", "DOCCO_TotalCompra", "DOCCO_TotalCompra", 150, True, False, "System.Decimal", Parametros.GetParametro(Parametros.TipoParametros.pg_FMondo2d)) : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Tipo Pago", "TIPOS_TipoPago", "TIPOS_TipoPago", 150, True, False, "System.String") : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Documento", "Documento", "Documento", 150, True, False, "System.String") : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Estado", "DOCCO_Estado_Text", "DOCCO_Estado_Text", 150, True, False, "System.String") : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Estado", "DOCCO_Estado", "DOCCO_Estado", 150, False, False, "System.String") : index += 1

         c1grdBusqueda.AllowEditing = False
         c1grdBusqueda.Styles.Alternate.BackColor = Color.WhiteSmoke
         c1grdBusqueda.Styles.Fixed.TextAlign = TextAlignEnum.CenterCenter
         c1grdBusqueda.Styles.Highlight.BackColor = Color.Gray
         c1grdBusqueda.SelectionMode = SelectionModeEnum.Row
         c1grdBusqueda.VisualStyle = VisualStyle.Office2007Blue

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

         index = 1
         ACFrameworkC1.ACUtilitarios.ACFormatearGrilla(c1grdDetalle, 1, 1, 10, 1, 0)
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdDetalle, index, "Codigo", "ARTIC_Codigo", "ARTIC_Codigo", 80, True, False, "System.String") : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdDetalle, index, "Descripción", "ARTIC_Descripcion", "ARTIC_Descripcion", 191, True, True, "System.String") : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdDetalle, index, "Unidad", "TIPOS_UnidadMedida", "TIPOS_UnidadMedida", 69, True, True, "System.String") : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdDetalle, index, "Peso", "DOCCD_PesoUnitario", "DOCCD_PesoUnitario", 75, True, True, "System.Decimal", Parametros.GetParametro(Parametros.TipoParametros.pg_FMondo4d)) : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdDetalle, index, "Cantidad", "DOCCD_Cantidad", "DOCCD_Cantidad", 75, True, True, "System.Decimal", Parametros.GetParametro(Parametros.TipoParametros.pg_FMondo2d)) : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdDetalle, index, "Precio Unit.", "DOCCD_PrecioUnitario", "DOCCD_PrecioUnitario", 75, True, True, "System.Decimal", Parametros.GetParametro(Parametros.TipoParametros.pg_FMondo2d)) : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdDetalle, index, "Peso Doc.", "DOCCD_SubPeso", "DOCCD_SubPeso", 75, True, True, "System.Decimal", Parametros.GetParametro(Parametros.TipoParametros.pg_FMondo4d)) : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdDetalle, index, "Sub-Importe", "DOCCD_SubImporteCompra", "DOCCD_SubImporteCompra", 75, True, True, "System.Decimal", Parametros.GetParametro(Parametros.TipoParametros.pg_FMondo2d)) : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdDetalle, index, "Destino", "TIPOS_TipoDestino", "TIPOS_TipoDestino", 80, True, True, "System.String") : index += 1
         c1grdDetalle.AllowEditing = False
         c1grdDetalle.AutoResize = False
         c1grdDetalle.Cols(0).Width = 15
         c1grdDetalle.ExtendLastCol = True
         'c1grdDetalle.Cols(2).
         c1grdDetalle.Styles.Alternate.BackColor = Color.WhiteSmoke
         c1grdDetalle.Styles.Fixed.TextAlign = TextAlignEnum.CenterCenter
         c1grdDetalle.Styles.Highlight.BackColor = Color.Gray
         c1grdDetalle.SelectionMode = SelectionModeEnum.Row
         c1grdDetalle.AllowResizing = AllowResizingEnum.None
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Text), "No se puede dar formato a la grilla", ex)
      End Try
   End Sub

   Private Sub setInstancia(ByVal _opcion As ACUtilitarios.ACSetInstancia)
      Select Case _opcion
         Case ACUtilitarios.ACSetInstancia.Nuevo
            ACUtilitarios.ACLimpiaVar(pnlCabecera)
            actxaProvCodigo.Focus()
            AddHandler c1grdDetalle.KeyDown, AddressOf c1grdDetalle_KeyDown
         Case ACUtilitarios.ACSetInstancia.Modificado
            AddHandler c1grdDetalle.KeyDown, AddressOf c1grdDetalle_KeyDown
         Case ACUtilitarios.ACSetInstancia.Guardar
            txtBusqueda.Focus()
            RemoveHandler c1grdDetalle.KeyDown, AddressOf c1grdDetalle_KeyDown
         Case ACUtilitarios.ACSetInstancia.Deshacer
            RemoveHandler c1grdDetalle.KeyDown, AddressOf c1grdDetalle_KeyDown
         Case ACUtilitarios.ACSetInstancia.Previsualizar
            ACUtilitarios.ACLimpiaVar(pnlCabecera)
            ACUtilitarios.ACLimpiaVar(pnlDetCabecera)
            RemoveHandler c1grdDetalle.KeyDown, AddressOf c1grdDetalle_KeyDown
      End Select
   End Sub

   Private Sub cargarCombos()
      Try
         ACUtilitarios.ACCargaCombo(cmbMoneda, Colecciones.Tipos(ETipos.MyTipos.TipoMoneda), "TIPOS_Descripcion", "TIPOS_Codigo")
         ACUtilitarios.ACCargaCombo(cmbTipoPago, Colecciones.Tipos(ETipos.MyTipos.TipoPago), "TIPOS_Descripcion", "TIPOS_Codigo")
         ACUtilitarios.ACCargaCombo(cmbProdDestino, Colecciones.Tipos(ETipos.MyTipos.TipoDestinoArticulo), "TIPOS_Descripcion", "TIPOS_Codigo")
         ACUtilitarios.ACCargaCombo(cmbDocumento, Colecciones.TiposDocMerTransito(), "TIPOS_Descripcion", "TIPOS_Codigo")
         Dim list As New List(Of ETipos)()
         For Each Item As ETipos In Colecciones.TiposDocMerTransito()
            list.Add(Item.Clone())
         Next
         ACUtilitarios.ACCargaCombo(cmbTipoDocumento, list, "TIPOS_Descripcion", "TIPOS_Codigo")
      Catch ex As Exception
         Throw ex
      End Try
   End Sub

   Private Function validar(ByRef m_msg As String)
      Try
         '' Validar al Cliente
         Dim _msg As String = ""
         If Not ACUtilitarios.ACDatosOk(pnlCabecera, _msg) Then
            m_msg &= _msg
            Return False
         End If
         ' Validar Detalle
         'ValidarDetalle(m_msg)
         ' Verificar si hay pedidos
         If Not m_eabas_docscompra.ListEABAS_DocsCompraDetalle.Count > 0 Then
            m_msg &= String.Format("- No se ha ingresado ningun articulo{0}", vbNewLine)
         End If
         Return Not (m_msg.Length > 0)
      Catch ex As Exception
         Throw ex
      End Try
   End Function

   Private Function getCampo() As String
      Try
         If (rbtnProveedor.Checked) Then
            Return "ENTID_RazonSocial"
         ElseIf rbtnNroOrdenCompra.Checked Then
            Return "ORDCO_Codigo"
         Else
            Return "ENTID_RazonSocial"
         End If
      Catch ex As Exception
         Throw ex
      End Try
   End Function

#End Region

#Region " Cargar Datos "
   Private Sub AsignarBinding()
      Try
         m_listBindHelper = New List(Of ACBindHelper)()
         If m_eabas_docscompra.DOCCO_FechaDocumento.Year < 1700 Then m_eabas_docscompra.DOCCO_FechaDocumento = DateTime.Now
         m_listBindHelper.Add(ACBindHelper.ACBind(dtpFecha, "Value", m_eabas_docscompra, "DOCCO_FechaDocumento"))
         m_listBindHelper.Add(ACBindHelper.ACBind(actxaProvCodigo, "Text", m_eabas_docscompra, "ENTID_CodigoProveedor"))
         m_listBindHelper.Add(ACBindHelper.ACBind(cmbDocumento, "SelectedValue", m_eabas_docscompra, "TIPOS_CodTipoDocumento"))
         m_listBindHelper.Add(ACBindHelper.ACBind(txtSerie, "Text", m_eabas_docscompra, "DOCCO_Serie"))
         m_listBindHelper.Add(ACBindHelper.ACBind(actxnNumero, "Text", m_eabas_docscompra, "DOCCO_Numero"))
         m_listBindHelper.Add(ACBindHelper.ACBind(cmbMoneda, "SelectedValue", m_eabas_docscompra, "TIPOS_CodTipoMoneda"))
         m_listBindHelper.Add(ACBindHelper.ACBind(actxnTipoCambio, "Text", m_eabas_docscompra, "DOCCO_TipoCambioSunat"))
         m_listBindHelper.Add(ACBindHelper.ACBind(cmbTipoPago, "SelectedValue", m_eabas_docscompra, "TIPOS_CodTipoPago"))
         If m_eabas_docscompra.DOCCO_FechaPago.Year < 1700 Then m_eabas_docscompra.DOCCO_FechaPago = DateTime.Now
         m_listBindHelper.Add(ACBindHelper.ACBind(dtpFecPago, "Value", m_eabas_docscompra, "DOCCO_FechaPago"))
         m_listBindHelper.Add(ACBindHelper.ACBind(actxnPesoTotal, "Text", m_eabas_docscompra, "DOCCO_TotalPeso"))
         m_listBindHelper.Add(ACBindHelper.ACBind(actxnImporte, "Text", m_eabas_docscompra, "DOCCO_ImporteCompra"))
         m_listBindHelper.Add(ACBindHelper.ACBind(actxnIGV, "Text", m_eabas_docscompra, "DOCCO_ImporteIgv"))
         m_listBindHelper.Add(ACBindHelper.ACBind(actxnTotal, "Text", m_eabas_docscompra, "DOCCO_TotalCompra"))
         m_listBindHelper.Add(ACBindHelper.ACBind(actxaOrdCompra, "Text", m_eabas_docscompra, "ORDCO_Codigo"))

      Catch ex As Exception
         Throw ex
      End Try
   End Sub

   Private Sub AyudaEntidad(ByVal x_cadenas As String, ByVal x_campo As String, ByVal x_opcion As EEntidades.TipoEntidad)
      Try
         Dim _where As New Hashtable
         _where.Add(x_campo, New ACWhere(x_cadenas, ACWhere.TipoWhere._Like))
         managerEntidades.Ayuda(_where, x_opcion)
         Dim Ayuda As New ACControlesC1.ACAyudaFlex("Buscar Entidad", managerEntidades.DTEntidades, False)
         If Ayuda.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Select Case x_opcion
               Case EEntidades.TipoEntidad.Proveedores
                  '' Cargar datos del cliente
                  m_eabas_docscompra.ENTID_CodigoProveedor = Ayuda.Respuesta.Rows(0)("Codigo")
                  actxaProvCodigo.Text = Ayuda.Respuesta.Rows(0)("Codigo").ToString()
                  actxaProvNombres.Text = Ayuda.Respuesta.Rows(0)("Razon Social").ToString()
                  ' '' Cargar datos adicionales Proveedor
                  cmbDocumento.Focus()
                  pnlDetCabecera.Enabled = True
            End Select
         End If
      Catch ex As Exception
         Throw ex
      End Try
   End Sub

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
         If Not IsNothing(bs_docscompra.Current) Then

         End If
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso Cargar Propiedades del Cotización/Pedido", ex)
      End Try
   End Sub
#End Region

#Region " Procesos "

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
               Dim _detalle As New EABAS_DocsCompraDetalle
               _detalle.ARTIC_Codigo = Item.ARTIC_Codigo
               _detalle.ARTIC_Descripcion = Item.ARTIC_Descripcion
               _detalle.DOCCD_Cantidad = Item.ORDCD_Cantidad
               _detalle.DOCCD_PesoUnitario = Item.ORDCD_PesoUnitario
               _detalle.DOCCD_PrecioUnitario = Item.ORDCD_PrecioUnitario
               _detalle.DOCCD_SubImporteCompra = Item.ORDCD_SubImporteCompra
               m_eabas_docscompra.ListEABAS_DocsCompraDetalle.Add(_detalle)
            Next
            actxaProvNombres.Text = m_eabas_docscompra.ENTID_Proveedor

            '' Instanciar clase
            AsignarBinding()


            managerTipoCambio.getUltTipoCambio()
            actxnTipoCambio.Text = managerTipoCambio.TipoCambio.TIPOC_CompraOficina
            '' Para Cargar detalle del producto
            bs_detdocscompra = New BindingSource
            bs_detdocscompra.DataSource = m_eabas_docscompra.ListEABAS_DocsCompraDetalle
            c1grdDetalle.DataSource = bs_detdocscompra
            bnavProductos.BindingSource = bs_detdocscompra

            tabMantenimiento.SelectedTab = tabDatos
            actxaProvCodigo.Focus()
         End If
      Catch ex As Exception
         Throw ex
      End Try
   End Sub


   Private Sub calcPrecioPeso()
      Try
         If Not actxnProdCantidad.Text = "" And Not actxnProdPrecUnitario.Text = "" Then
            Dim _cantidad As Decimal = actxnProdCantidad.Text
            Dim _precuni As Decimal = actxnProdPrecUnitario.Text
            Dim _peso As Decimal = actxnProdPeso.Text
            Dim _tprecio As Decimal = _cantidad * _precuni
            Dim _tpeso As Decimal = _cantidad * _peso
            actxnProdSubImporte.Text = _tprecio.ToString(Parametros.GetParametro(Parametros.TipoParametros.pg_FMondo2d))
            actxnProdPesoDoc.Text = _tpeso.ToString(Parametros.GetParametro(Parametros.TipoParametros.pg_FMondo4d))
         Else
            actxnProdSubImporte.Text = "0.00"
            actxnProdPesoDoc.Text = "0.00"
         End If
      Catch ex As Exception
         Throw ex
      End Try
   End Sub

   Private Sub nuevoCosteoCompra()
      Try
         '' Inicializar clase 
         m_eabas_docscompra = New EABAS_DocsCompra
         m_eabas_docscompra.Instanciar(ACEInstancia.Nuevo)
         '' Instanciar clase
         AsignarBinding()
         setInstancia(ACUtilitarios.ACSetInstancia.Nuevo)

         managerTipoCambio.getUltTipoCambio()
         actxnTipoCambio.Text = managerTipoCambio.TipoCambio.TIPOC_CompraOficina
         '' Para Cargar detalle del producto
         bs_detdocscompra = New BindingSource
         m_eabas_docscompra.ListEABAS_DocsCompraDetalle = New List(Of EABAS_DocsCompraDetalle)
         bs_detdocscompra.DataSource = m_eabas_docscompra.ListEABAS_DocsCompraDetalle
         c1grdDetalle.DataSource = bs_detdocscompra
         bnavProductos.BindingSource = bs_detdocscompra

         tabMantenimiento.SelectedTab = tabDatos
         actxaProvCodigo.Focus()
      Catch ex As Exception
         Throw ex
      End Try
   End Sub

   Private Sub setProducto(ByVal x_opcion As Boolean)
      Try
         If x_opcion Then
            If managerConsultaArticulos.cargarProducto(m_earticulos.ARTIC_Codigo) Then
               m_earticulos = managerConsultaArticulos.Articulos
               actxaProdCodigo.Text = m_earticulos.ARTIC_Codigo
               txtProdDescripcion.Text = m_earticulos.ARTIC_Descripcion
               txtProdUnidad.Text = m_earticulos.TIPOS_UndMedCorta
               actxnProdPeso.Text = m_earticulos.ARTIC_Peso
               txtProdDescripcion.Focus()
            End If
         Else
            actxaProdCodigo.Clear()
            txtProdUnidad.Clear()
            txtProdDescripcion.Clear()
            actxnProdCantidad.Text = "0.00"
            actxnProdPrecUnitario.Text = "0.00"
            actxnProdPesoDoc.Text = "0.0000"
            actxnProdPeso.Text = "0.0000"
            actxnProdCantidad.Text = "0.00"
            actxnProdSubImporte.Text = "0.00"
         End If
      Catch ex As Exception
         Throw ex
      End Try
   End Sub

   Private Function busqueda(ByVal x_cadena As String, Optional ByVal x_documento As Boolean = False) As Boolean
      Try
         If x_documento Then
            If managerABAS_DocsCompra.Busqueda(cmbTipoDocumento.SelectedValue, txtCSerie.Text, txtBusNumero.Text, chkTodos.Checked, acFecha.ACDtpFecha_De.Value.Date, acFecha.ACDtpFecha_A.Value.Date.AddDays(1)) Then
               acTool.ACBtnEliminarEnabled = True
               acTool.ACBtnModificarEnabled = True
            Else
               acTool.ACBtnEliminarEnabled = False
               acTool.ACBtnModificarEnabled = False
            End If
            cargarDatos()
         Else
            'If txtBusqueda.ACEstadoAutoAyuda Then
            If managerABAS_DocsCompra.Busqueda(x_cadena, getCampo(), chkTodos.Checked, acFecha.ACDtpFecha_De.Value.Date, acFecha.ACDtpFecha_A.Value.Date.AddDays(1)) Then
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

   Private Function grabarDocCompra(ByRef m_msg As String) As Boolean
      Try
         If validar(m_msg) Then
            If ACControles.ACDialogos.ACMostrarMensajePregunta(String.Format("Grabar Documento de Compra: {0}", Me.Text) _
             , "Desea grabar el Documento de Compra?" _
             , ACControles.ACDialogos.LabelBotom.Si_No) = DialogResult.Yes Then
               '' Obtener datos
               m_eabas_docscompra.DOCCO_PorcentajeIGV = Parametros.GetParametro(Parametros.TipoParametros.PIGV)
               '' Obtener el correlativo y asignarlo
               Dim x_codigo As String
               If ETipos.getTipoComprobante(ETipos.TipoComprobanteVenta.Ticket) = m_eabas_docscompra.TIPOS_CodTipoDocumento Then
                  x_codigo = String.Format("{0}{1}{2}", m_eabas_docscompra.TIPOS_CodTipoDocumento.Substring(3, 2), m_eabas_docscompra.DOCCO_Serie.PadLeft(4, "0"), m_eabas_docscompra.DOCCO_Numero.ToString().PadLeft(9, "0"))
               Else
                  x_codigo = String.Format("{0}{1}{2}", m_eabas_docscompra.TIPOS_CodTipoDocumento.Substring(3, 2), m_eabas_docscompra.DOCCO_Serie.PadLeft(3, "0"), m_eabas_docscompra.DOCCO_Numero.ToString().PadLeft(7, "0"))
               End If
               m_eabas_docscompra.DOCCO_Codigo = x_codigo
               m_eabas_docscompra.PVENT_Id = GApp.PuntoVenta
               m_eabas_docscompra.ALMAC_Id = GApp.Almacen

               '' Definir el Estado
               m_eabas_docscompra.DOCCO_Estado = EABAS_DocsCompra.getEstado(EABAS_DocsCompra.Estado.Ingresado)
               '' Asignar la clase pedido a la capa de negocio 
               managerGenerarDocsCompra.ABAS_DocsCompra = m_eabas_docscompra
               '' Grabar el pedido
               Return managerGenerarDocsCompra.GrabarDocCompra(GApp.Usuario, GApp.Zona, GApp.Sucursal, GApp.PuntoVenta, m_msg)
            End If
         End If
         Return False
      Catch ex As Exception
         Throw ex
      End Try
   End Function

   Private Function addDetalle() As Boolean
      Try

         Dim _detDocCompraDetalle As New EABAS_DocsCompraDetalle
         _detDocCompraDetalle.Articulo = m_earticulos
         _detDocCompraDetalle.ARTIC_Codigo = m_earticulos.ARTIC_Codigo
         _detDocCompraDetalle.ARTIC_Descripcion = m_earticulos.ARTIC_Descripcion
         _detDocCompraDetalle.TIPOS_UnidadMedida = m_earticulos.TIPOS_UndMedCorta
         _detDocCompraDetalle.DOCCD_PesoUnitario = actxnProdPeso.Text
         _detDocCompraDetalle.DOCCD_Cantidad = actxnProdCantidad.Text
         _detDocCompraDetalle.DOCCD_PrecioUnitario = actxnProdPrecUnitario.Text
         _detDocCompraDetalle.DOCCD_SubPeso = actxnProdPesoDoc.Text
         _detDocCompraDetalle.DOCCD_SubImporteCompra = actxnProdSubImporte.Text
         _detDocCompraDetalle.TIPOS_CodTipoDestino = cmbProdDestino.SelectedValue
         _detDocCompraDetalle.TIPOS_TipoDestino = cmbProdDestino.Text
         ' '' Actualizar contenido
         m_eabas_docscompra.ListEABAS_DocsCompraDetalle.Add(_detDocCompraDetalle)
         bs_detdocscompra.ResetBindings(False)
         calcular()
         Return True
      Catch ex As Exception
         Throw ex
      End Try
   End Function

   Private Sub calcular()
      Try
         Dim _importeTotal As Decimal = 0
         Dim _pesoTotal As Decimal = 0
         Dim _igv As Decimal = Parametros.GetParametro(Parametros.TipoParametros.PIGV)
         For Each Item As EABAS_DocsCompraDetalle In m_eabas_docscompra.ListEABAS_DocsCompraDetalle
            _importeTotal += Item.DOCCD_PrecioUnitario * Item.DOCCD_Cantidad
            _pesoTotal += Item.DOCCD_SubPeso
         Next
         Dim _total As Decimal = _importeTotal * ((_igv + 100) / 100)
         Dim _importeIgv As Decimal = _importeTotal * (_igv / 100)

         actxnIGV.Text = _importeIgv.ToString(Parametros.GetParametro(Parametros.TipoParametros.pg_FMondo2d))
         actxnTotal.Text = _total.ToString(Parametros.GetParametro(Parametros.TipoParametros.pg_FMondo2d))
         actxnImporte.Text = _importeTotal.ToString(Parametros.GetParametro(Parametros.TipoParametros.pg_FMondo2d))
         actxnPesoTotal.Text = _pesoTotal.ToString(Parametros.GetParametro(Parametros.TipoParametros.pg_FMondo4d))

      Catch ex As Exception
         Throw ex
      End Try
   End Sub

   Private Sub subirItem()
      Try
         If IsNothing(CType(bs_detdocscompra.Current, EABAS_DocsCompraDetalle).Articulo) Then
            '' Cargar Producto
            actxaProdCodigo.Text = CType(bs_detdocscompra.Current, EABAS_DocsCompraDetalle).ARTIC_Codigo
            txtProdDescripcion.Text = CType(bs_detdocscompra.Current, EABAS_DocsCompraDetalle).ARTIC_Descripcion
            txtProdUnidad.Text = CType(bs_detdocscompra.Current, EABAS_DocsCompraDetalle).TIPOS_UnidadMedida
            actxnProdPeso.Text = CType(bs_detdocscompra.Current, EABAS_DocsCompraDetalle).DOCCD_PesoUnitario
            actxnProdCantidad.Text = CType(bs_detdocscompra.Current, EABAS_DocsCompraDetalle).DOCCD_Cantidad
            actxnProdPrecUnitario.Text = CType(bs_detdocscompra.Current, EABAS_DocsCompraDetalle).DOCCD_PrecioUnitario
            actxnProdSubImporte.Text = CType(bs_detdocscompra.Current, EABAS_DocsCompraDetalle).DOCCD_SubImporteCompra
            actxnProdPesoDoc.Text = CType(bs_detdocscompra.Current, EABAS_DocsCompraDetalle).DOCCD_SubPeso
            If Not IsNothing(CType(bs_detdocscompra.Current, EABAS_DocsCompraDetalle).TIPOS_CodTipoDestino) Then
               cmbProdDestino.SelectedValue = CType(bs_detdocscompra.Current, EABAS_DocsCompraDetalle).TIPOS_CodTipoDestino
            End If
            m_earticulos = New EArticulos()
            '' Asignar Metodos a controles
         Else
            m_earticulos = CType(bs_detdocscompra.Current, EABAS_DocsCompraDetalle).Articulo
            setProducto(True)
            actxnProdCantidad.Text = CType(bs_detdocscompra.Current, EABAS_DocsCompraDetalle).DOCCD_Cantidad
            actxnProdPrecUnitario.Text = CType(bs_detdocscompra.Current, EABAS_DocsCompraDetalle).DOCCD_PrecioUnitario
            actxnProdSubImporte.Text = CType(bs_detdocscompra.Current, EABAS_DocsCompraDetalle).DOCCD_SubImporteCompra
            actxnProdPesoDoc.Text = CType(bs_detdocscompra.Current, EABAS_DocsCompraDetalle).DOCCD_SubPeso
            If Not CType(bs_detdocscompra.Current, EABAS_DocsCompraDetalle).TIPOS_CodTipoDestino.Equals("") Then
               cmbProdDestino.SelectedValue = CType(bs_detdocscompra.Current, EABAS_DocsCompraDetalle).TIPOS_CodTipoDestino
            End If
         End If
      Catch ex As Exception
         Throw ex
      End Try
   End Sub
#End Region

#End Region

#Region " Metodos de Controles"

   Private Sub rbtnDatos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtnDatos.CheckedChanged
      grpCliente.Enabled = rbtnDatos.Checked
      grpDocumentos.Enabled = Not rbtnDatos.Checked
   End Sub

   Private Sub txtDescripcion_SizeChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
      Try
         c1grdDetalle.Cols(2).Width = txtProdDescripcion.Size.Width
      Catch ex As Exception

      End Try
   End Sub

#Region " ToolBar "

   Private Sub acbtnCostear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles acbtnCostear.Click
      Try
         If Not IsNothing(bs_docscompra) Then
            If Not IsNothing(bs_docscompra.Current) Then
               acTool.setInstancia(ACControles.ACToolBarMantHorizontalNew.TipoInstancia.Nuevo)
               setInstancia(ACUtilitarios.ACSetInstancia.Nuevo)
               nuevoCosteoCompra()
               '' Activar las opciones generales del teclado
               KeyPreview = True
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
         'If grabarDocCompra(m_msg) Then
         '   '' Manejar las opciones de la barra de herramientas
         '   acTool.setInstancia(ACControles.ACToolBarMantHorizontalNew.TipoInstancia.Cancelar)
         '   tabMantenimiento.SelectedTab = tabBusqueda
         '   ACControles.ACDialogos.ACMostrarMensajeSatisfactorio(String.Format("Información: {0}", Me.Text), "Grabado Satisfactoriamente")
         '   'acTool.ACBtnModificarVisible = m_proceso_modificar
         '   'txtBusqueda_ACAyudaClick(Nothing, Nothing)
         '   setInstancia(ACUtilitarios.ACSetInstancia.Guardar)
         'Else
         '   acTool.setInstancia(ACControles.ACToolBarMantHorizontalNew.TipoInstancia.Nuevo)
         '   ACControles.ACDialogos.ACMostrarMensajeInformacion(String.Format("Información: {0}", Me.Text), "No se puede grabar, revise los detalles:", m_msg)
         'End If
      Catch ex As Exception
         acTool.setInstancia(ACControles.ACToolBarMantHorizontalNew.TipoInstancia.Nuevo)
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso Grabar Cotización/Pedido", ex)
      End Try
   End Sub
#End Region

#Region " Textos"

   Private Sub actxnProdPrecUnitario_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
      Try
         calcPrecioPeso()
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Convert.ToString(Text)), "No se puede calcular el precio, peso", ex)
      End Try
   End Sub

   Private Sub actxnProdCantidad_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
      Try
         calcPrecioPeso()
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Convert.ToString(Text)), "No se puede calcular el precio, peso", ex)
      End Try
   End Sub

   Private Sub txtOpcion_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
      Try
         Select Case e.KeyChar
            Case "+"c
               If m_modArticulo Then
                  e.Handled = True
                  CType(bs_detdocscompra.Current, EABAS_DocsCompraDetalle).DOCCD_Cantidad = actxnProdCantidad.Text
                  CType(bs_detdocscompra.Current, EABAS_DocsCompraDetalle).DOCCD_PrecioUnitario = actxnProdPrecUnitario.Text
                  CType(bs_detdocscompra.Current, EABAS_DocsCompraDetalle).DOCCD_SubPeso = actxnProdPesoDoc.Text
                  CType(bs_detdocscompra.Current, EABAS_DocsCompraDetalle).DOCCD_SubImporteCompra = actxnProdSubImporte.Text
                  CType(bs_detdocscompra.Current, EABAS_DocsCompraDetalle).TIPOS_CodTipoDestino = cmbProdDestino.SelectedValue
                  setProducto(False)
                  calcular()
                  c1grdDetalle.Enabled = True
                  Me.KeyPreview = False
                  m_modArticulo = False
               Else
                  e.Handled = True
                  actxaProdCodigo.Focus()
                  txtOpcion.Text = ""
                  txtOpcion.SelectAll()
                  addDetalle()
                  setProducto(False)
               End If
            Case "-"c
               e.Handled = True
            Case Else
               e.Handled = True
         End Select
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso opciones", ex)
      End Try
   End Sub

   Private Sub txtOpcion_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
      Try

         Select Case e.KeyData
            Case Keys.Enter
               addDetalle()
               setProducto(False)
               acTool_ACBtnGrabar_Click(Nothing, Nothing)
               Me.KeyPreview = False
               m_modArticulo = False
            Case Keys.Escape
               setProducto(False)
               c1grdDetalle.Enabled = True
               'cmbPrecioUnitario.Enabled = False
               Me.KeyPreview = False
               m_modArticulo = False
            Case Else

         End Select
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Text), "No se puede procesar", ex)
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

   Private Sub actxaOrdCompra_ACAyudaClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
      Try
         Dim frmAyuda As New TOrdCompras(TOrdCompras.Inicio.Busqueda)
         If frmAyuda.ShowDialog = Windows.Forms.DialogResult.OK Then
            actxaOrdCompra.Text = frmAyuda.ABAS_OrdenesCompra.ORDCO_Codigo
            setOrdenToDocCompra(frmAyuda.ABAS_OrdenesCompra.ORDCO_Codigo)
            pnlDetCabecera.Enabled = True
         End If
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Convert.ToString(Text)), "No se puede calcular cargar la aui", ex)
      End Try
   End Sub

   Private Sub txtBusqueda_ACAyudaClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBusqueda.ACAyudaClick
      Try
         busqueda(txtBusqueda.Text)
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Convert.ToString(Text)), "No se puede cargar la ayuda para los registros de compra", ex)
      End Try
   End Sub

   Private Sub actxaProdCodigo_ACAyudaClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
      Try
         Dim frmCons As New CProductos(CProductos.Origen.Cotizaciones) With {.StartPosition = FormStartPosition.CenterScreen}
         Me.KeyPreview = False
         If frmCons.ShowDialog() = Windows.Forms.DialogResult.OK Then
            m_earticulos = frmCons.Articulo
            setProducto(True)
            Me.KeyPreview = True
         End If
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso cargar productos", ex)
      End Try
   End Sub

   Private Sub actxaProvNombres_ACAyudaClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
      Try
         AyudaEntidad(txtProdDescripcion.Text, "ENTID_Nombres", EEntidades.TipoEntidad.Proveedores)
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso busqueda de proveedores por descripción", ex)
      End Try
   End Sub

   Private Sub actxaProvCodigo_ACAyudaClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
      Try
         AyudaEntidad(actxaProvCodigo.Text, "ENTID_Codigo", EEntidades.TipoEntidad.Proveedores)
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso busqueda de proveedores por descripción", ex)
      End Try
   End Sub

#End Region

#Region " Grillas "

   Private Sub c1grdBusqueda_OwnerDrawCell(ByVal sender As System.Object, ByVal e As C1.Win.C1FlexGrid.OwnerDrawCellEventArgs) Handles c1grdBusqueda.OwnerDrawCell
      'Try
      '   If e.Row < c1grdBusqueda.Rows.Fixed OrElse e.Col < c1grdBusqueda.Cols.Fixed Then Return
      '   If c1grdBusqueda.Rows(e.Row)("COTCO_Estado") = EABAS_CotizacionesCompra.getEstado(EABAS_CotizacionesCompra.Estado.Confirmado) Then
      '      e.Style = c1grdBusqueda.Styles("Facturado")
      '   End If
      '   If c1grdBusqueda.Rows(e.Row)("COTCO_Estado") = EABAS_CotizacionesCompra.getEstado(EABAS_CotizacionesCompra.Estado.Anulado) Then
      '      e.Style = c1grdBusqueda.Styles("Anulado")
      '   End If
      'Catch ex As Exception
      '   ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso cambia de color", ex)
      'End Try
   End Sub

   Private Sub c1grdDetalle_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c1grdDetalle.Enter
      Me.KeyPreview = False
   End Sub

   Private Sub c1grdDetalle_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
      Try
         e.SuppressKeyPress = True
         Select Case e.KeyCode
            Case Keys.Enter
               subirItem()
               c1grdDetalle.Enabled = False
               m_modArticulo = True
               Me.KeyPreview = True
            Case Keys.Delete
               If ACControles.ACDialogos.ACMostrarMensajePregunta(String.Format("Quitar Registro: {0}", Me.Text) _
             , String.Format("Desea quitar el Articulo : {0} ", CType(bs_detdocscompra.Current, EABAS_DocsCompraDetalle).ARTIC_Descripcion) _
             , ACControles.ACDialogos.LabelBotom.Si_No) = DialogResult.Yes Then
                  Dim m_det As EABAS_DocsCompraDetalle = CType(bs_detdocscompra.Current, EABAS_DocsCompraDetalle)
                  m_eabas_docscompra.ListEABAS_DocsCompraDetalle.Remove(m_det)
                  bs_detdocscompra.ResetBindings(False)
               End If
            Case Else
               e.Handled = False
         End Select
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Text), "No se puede calcular carga el Item", ex)
      End Try
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

#End Region


End Class