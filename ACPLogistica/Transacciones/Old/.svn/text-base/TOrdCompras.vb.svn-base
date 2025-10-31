Imports ACBLogistica
Imports ACBVentas
Imports ACELogistica
Imports ACEVentas
Imports ACFramework

Imports Microsoft.Practices.Unity
Imports C1.Win.C1FlexGrid

Public Class TOrdCompras

#Region " Variables "

   Private m_order As Integer = 1
   Private managerGenerarOrdenCompra As BGenerarOrdenCompra
   Private managerABAS_OrdenesCompra As BABAS_OrdenesCompra
   Private managerConsultaArticulos As BConsultaArticulos
   Private managerABAS_CotizacionesCompra As BABAS_CotizacionesCompra
   Private managerABAS_ListaPreciosCompra As BABAS_ListaPreciosCompra
   Private managerEntidades As BEntidades
   Private m_listprecios As List(Of EABAS_ListaPreciosCompra)

   Private m_listBindHelper As List(Of ACBindHelper)

   Private m_eabas_ordenescompra As EABAS_OrdenesCompra
   Private m_earticulos As EArticulos
   Private m_eentidades As EEntidades

   Private bs_abas_ordenescompra As BindingSource
   Private bs_detabas_ordenescompra As BindingSource
   Private bs_moneda As BindingSource

   Private m_proceso_modificar As Boolean = False
   Private m_modificando As Boolean
   Private m_modArticulo As Boolean = False

   private frmCons As CProductos

   Enum Seteo
      Activar
      Desactivar
   End Enum

   Enum Inicio
      Normail
      Busqueda
   End Enum

#End Region

#Region " Propiedades "

   Public Property ABAS_OrdenesCompra() As EABAS_OrdenesCompra
      Get
         Return m_eabas_ordenescompra
      End Get
      Set(ByVal value As EABAS_OrdenesCompra)
         m_eabas_ordenescompra = value
      End Set
   End Property
#End Region

#Region " Constructores "

   Public Sub New(ByVal x_opcion As Inicio)

      ' This call is required by the Windows Form Designer.
      InitializeComponent()

      ' Add any initialization after the InitializeComponent() call.
      Try
         Inicializacion()
         Select Case x_opcion
            Case Inicio.Busqueda
               acTool.ACTipoToolBar = ACControles.ACToolBarMantHorizontalNew.tipoToolBar.ToolSalir
               acbtnSeleccionar.Visible = True
               actsbtnPrevisualizar.Visible = True
               Me.WindowState = FormWindowState.Normal
               Me.MaximizeBox = True
               Me.MinimizeBox = False
               Me.StartPosition = FormStartPosition.CenterScreen
               txtBusqueda_ACAyudaClick(Nothing, Nothing)
            Case Inicio.Normail

            Case Else

         End Select

      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "No se puede cargar los controles iniciales", ex)
      End Try
   End Sub

   Public Sub New()
      ' This call is required by the Windows Form Designer.
      InitializeComponent()
      Try
         Inicializacion()

      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "No se puede cargar los controles iniciales", ex)
      End Try
   End Sub

   Private Sub Inicializacion()
      Try
         tabMantenimiento.HideTabsMode = Crownwood.DotNetMagic.Controls.HideTabsModes.HideAlways
         tabMantenimiento.SelectedTab = tabBusqueda
         '' Inicializar los componentes con Unity
         managerGenerarOrdenCompra = New BGenerarOrdenCompra
         managerEntidades = New BEntidades
         managerConsultaArticulos = New BConsultaArticulos(GApp.Periodo)
         managerABAS_OrdenesCompra = New BABAS_OrdenesCompra
         managerABAS_CotizacionesCompra = New BABAS_CotizacionesCompra
         managerABAS_ListaPreciosCompra = New BABAS_ListaPreciosCompra
         '' Iniciarlizar los componentes graficos
         formatearGrilla()
         cargaCombos()
         setEtiqueta(ETipos.TipoMoneda.Soles)
         '' Aplicar el titulo segun el tipo de documento que se va a cargar
         Me.Text = acpnlTitulo.ACCaption
         Me.Icon = Icon.FromHandle(ACPLogistica.My.Resources.GuiaProc_16x16.GetHicon)
      Catch ex As Exception
         Throw ex
      End Try
   End Sub
#End Region

#Region " Metodos "

   ''' <summary>
   ''' Convertir la cotizacion de compra a orden de compra, copiando todos los valores de la cotización de compra.
   ''' </summary>
   ''' <param name="x_eabas_cotizacionescompra"></param>
   ''' <remarks></remarks>
   Private Sub CotizToOrden(ByVal x_eabas_cotizacionescompra As EABAS_CotizacionesCompra)
      Try
         Dim x_codigo As String = x_eabas_cotizacionescompra.COTCO_Codigo
         '' Cargar Cotizacion
         If managerABAS_CotizacionesCompra.Cargar(x_codigo, True) Then
            '' Setear Valores
            setInstancia(ACUtilitarios.ACSetInstancia.Nuevo)
            '' Cargar los datos de la cabecera
            Dim m_cotizacionc As EABAS_CotizacionesCompra = managerABAS_CotizacionesCompra.ABAS_CotizacionesCompra
            m_eabas_ordenescompra.ENTID_CodigoProveedor = m_cotizacionc.ENTID_CodigoProveedor
            m_eabas_ordenescompra.ORDCO_DireccionProveedor = m_cotizacionc.COTCO_DireccionProveedor
            m_eabas_ordenescompra.ORDCO_AtencionProveedor = m_cotizacionc.COTCO_AtencionProveedor
            m_eabas_ordenescompra.ORDCO_TelefonoProveedor = m_cotizacionc.COTCO_TelefonoProveedor
            m_eabas_ordenescompra.ORDCO_CorreoProveedor = m_cotizacionc.COTCO_CorreoProveedor
            m_eabas_ordenescompra.COTCO_Codigo = m_cotizacionc.COTCO_Codigo
            AsignarBinding()
            '' Cargar los datos del detalle
            m_eabas_ordenescompra.ListABAS_OrdenesCompraDetalle = New List(Of EABAS_OrdenesCompraDetalle)
            For Each Item As EABAS_CotizacionesCompraDetalle In m_cotizacionc.ListABAS_CotizacionesCompraDetalle
               Dim detalle As New EABAS_OrdenesCompraDetalle()
               detalle.ARTIC_Codigo = Item.ARTIC_Codigo
               detalle.ORDCD_Cantidad = Item.COTCD_Cantidad
               If managerConsultaArticulos.cargarProducto(Item.ARTIC_Codigo) Then
                  detalle.Articulo = managerConsultaArticulos.Articulos
                  detalle.ORDCD_PesoUnitario = detalle.Articulo.ARTIC_Peso
                  detalle.ARTIC_Descripcion = detalle.Articulo.ARTIC_Descripcion
                  detalle.TIPOS_UnidadMedida = detalle.Articulo.TIPOS_UndMedCorta
               End If
               If managerABAS_ListaPreciosCompra.GetPreciosArticulo(m_cotizacionc.ENTID_CodigoProveedor, Item.ARTIC_Codigo) Then
                  For Each precio As EABAS_ListaPreciosCompra In managerABAS_ListaPreciosCompra.ListABAS_ListaPreciosCompra
                     If precio.TIPOS_CodTipoMoneda.Equals(cmbMoneda.SelectedValue) Then
                        detalle.ORDCD_PrecioUnitario = precio.Precio
                        Exit For
                     End If
                  Next
                  detalle.ListEABAS_ListaPreciosCompra = New List(Of EABAS_ListaPreciosCompra)(managerABAS_ListaPreciosCompra.ListABAS_ListaPreciosCompra)
               End If
               m_eabas_ordenescompra.ListABAS_OrdenesCompraDetalle.Add(detalle)
            Next
            calcular()
            '' Actualiza en los controles
            bs_detabas_ordenescompra = New BindingSource()
            bs_detabas_ordenescompra.DataSource = m_eabas_ordenescompra.ListABAS_OrdenesCompraDetalle
            c1grdDetalle.DataSource = bs_detabas_ordenescompra
            bnavProductos.BindingSource = bs_detabas_ordenescompra
            '' Cargar datos del Proveedor
            If managerEntidades.Cargar(m_cotizacionc.ENTID_CodigoProveedor) Then
               actxaProvCodigo.Text = managerEntidades.Entidades.ENTID_Codigo
               actxaProvRuc.Text = managerEntidades.Entidades.ENTID_NroDocumento
               actxaProvRazonSocial.Text = managerEntidades.Entidades.ENTID_RazonSocial
            End If
            '' Activar Controles
            pnlItem.Enabled = True
            actxaNroCotizacion.Enabled = False
            setRol(IIf(getFilterRol(), Seteo.Activar, Seteo.Desactivar))
            cmbMoneda.Focus()
         End If
      Catch ex As Exception
         Throw ex
      End Try
   End Sub

   Private Sub subirItem()
      Try
         If IsNothing(CType(bs_detabas_ordenescompra.Current, EABAS_OrdenesCompraDetalle).Articulo) Then
            '' Cargar Producto
            actxaProdCodigo.Text = CType(bs_detabas_ordenescompra.Current, EABAS_CotizacionesCompraDetalle).ARTIC_Codigo
            txtProdDescripcion.Text = CType(bs_detabas_ordenescompra.Current, EABAS_OrdenesCompraDetalle).ARTIC_Descripcion
            txtUnidad.Text = CType(bs_detabas_ordenescompra.Current, EABAS_OrdenesCompraDetalle).TIPOS_UnidadMedida
            actxnCantidad.Text = CType(bs_detabas_ordenescompra.Current, EABAS_OrdenesCompraDetalle).ORDCD_Cantidad
            actxnPrecio.Text = CType(bs_detabas_ordenescompra.Current, EABAS_OrdenesCompraDetalle).ORDCD_PrecioUnitario
            actxnSubImporte.Text = CType(bs_detabas_ordenescompra.Current, EABAS_OrdenesCompraDetalle).ORDCD_SubImporteCompra
            m_earticulos = New EArticulos()
            Me.KeyPreview = True
            '' Asignar Metodos a controles
         Else
            m_earticulos = CType(bs_detabas_ordenescompra.Current, EABAS_OrdenesCompraDetalle).Articulo
            setProducto(True)
            txtUnidad.Text = CType(bs_detabas_ordenescompra.Current, EABAS_OrdenesCompraDetalle).TIPOS_UnidadMedida
            actxnCantidad.Text = CType(bs_detabas_ordenescompra.Current, EABAS_OrdenesCompraDetalle).ORDCD_Cantidad
            actxnPrecio.Text = CType(bs_detabas_ordenescompra.Current, EABAS_OrdenesCompraDetalle).ORDCD_PrecioUnitario
            actxnSubImporte.Text = CType(bs_detabas_ordenescompra.Current, EABAS_OrdenesCompraDetalle).ORDCD_SubImporteCompra
         End If
      Catch ex As Exception
         Throw ex
      End Try
   End Sub

   Private Function getFilterRol() As Boolean
      Try
         If Not IsNothing(managerEntidades.Entidades.ListEntidadesTipos) Then
            If managerEntidades.Entidades.ListEntidadesTipos.Count > 0 Then
               Dim _filter As New ACFiltrador(Of EEntidadesRoles)
               _filter.ACFiltro = "ROLES_Id=" & EEntidades.TipoEntidad.EnBlanco
               If _filter.ACFiltrar(managerEntidades.Entidades.ListEntidadesTipos).Count > 0 Then
                  Return True
               Else
                  Return False
               End If
            Else
               Return False
            End If
         End If
      Catch ex As Exception
         Throw ex
      End Try
   End Function

   Private Function addDetalle() As Boolean
      Try
         Dim _filter As New ACFiltrador(Of EABAS_OrdenesCompraDetalle)
         _filter.ACFiltro = String.Format("ARTIC_Codigo={0}", m_earticulos.ARTIC_Codigo)
         _filter.ACFiltrar(m_eabas_ordenescompra.ListABAS_OrdenesCompraDetalle)
         If _filter.ACListaFiltrada.Count > 0 Then
            If ACControles.ACDialogos.ACMostrarMensajePregunta(String.Format("Registro Duplicado: {0}", Me.Text) _
             , "El producto ya fue ingresado, deseas actualizar la cantidad ingresada?" _
             , ACControles.ACDialogos.LabelBotom.Si_No) = DialogResult.Yes Then
               _filter.ACListaFiltrada(0).ORDCD_Cantidad = actxnCantidad.Text
               _filter.ACListaFiltrada(0).ORDCD_PrecioUnitario = actxnPrecio.Text
               bs_detabas_ordenescompra.ResetBindings(False)
               calcular()
               Return True
            End If
         Else
            Dim _detalle As New EABAS_OrdenesCompraDetalle
            _detalle.Articulo = m_earticulos
            _detalle.ARTIC_Descripcion = m_earticulos.ARTIC_Descripcion
            _detalle.ARTIC_Codigo = m_earticulos.ARTIC_Codigo
            _detalle.ORDCD_PesoUnitario = m_earticulos.ARTIC_Peso
            _detalle.ORDCD_Cantidad = actxnCantidad.Text
            _detalle.ARTIC_Codigo = m_earticulos.ARTIC_Codigo
            _detalle.TIPOS_UnidadMedida = m_earticulos.TIPOS_UndMedCorta
            _detalle.ORDCD_Cantidad = actxnCantidad.Text
            _detalle.ORDCD_PrecioUnitario = actxnPrecio.Text
            _detalle.ORDCD_SubImporteCompra = actxnSubImporte.Text
            '' Actualizar contenido
            m_eabas_ordenescompra.ListABAS_OrdenesCompraDetalle.Add(_detalle)
            bs_detabas_ordenescompra.ResetBindings(False)
            calcular()
            Return True
         End If
      Catch ex As Exception
         Throw ex
      End Try
   End Function

   ''' <summary>
   ''' Activar los controles segun los permisos o el rol que tiene el cliente
   ''' </summary>
   ''' <param name="x_opcion"></param>
   ''' <remarks></remarks>
   Private Sub setRol(ByVal x_opcion As Seteo)
      Try
         actxaProvCodigo.ReadOnly = IIf(x_opcion = Seteo.Activar, False, True)
         actxaProvCodigo.ACActivarAyuda = IIf(x_opcion = Seteo.Activar, True, False)
         actxaProvCodigo.ACAyuda.Enabled = IIf(x_opcion = Seteo.Activar, True, False)
         actxaProvRazonSocial.ReadOnly = IIf(x_opcion = Seteo.Activar, False, True)
         actxaProvRazonSocial.ACActivarAyuda = IIf(x_opcion = Seteo.Activar, True, False)
         actxaProvRazonSocial.ACAyuda.Enabled = IIf(x_opcion = Seteo.Activar, True, False)
         actxaProvRuc.ReadOnly = IIf(x_opcion = Seteo.Activar, False, True)
         actxaProvRuc.ACAyuda.Enabled = IIf(x_opcion = Seteo.Activar, True, False)
         actxaProvRuc.ACActivarAyuda = IIf(x_opcion = Seteo.Activar, True, False)
         actxaNroCotizacion.ReadOnly = IIf(x_opcion = Seteo.Activar, False, True)
         actxaNroCotizacion.ACAyuda.Enabled = IIf(x_opcion = Seteo.Activar, True, False)
         actxaNroCotizacion.ACActivarAyuda = IIf(x_opcion = Seteo.Activar, True, False)
      Catch ex As Exception
         Throw ex
      End Try
   End Sub

#Region " Metodos Utilitarios "

   Private Sub Ordenar(ByVal x_columna As String)
      Dim _ordenador As New ACOrdenador(Of EABAS_OrdenesCompra)
      Try
         If m_order = 2 Then x_columna &= " DESC"
         _ordenador.ACOrdenamiento = x_columna
         CType(bs_abas_ordenescompra.DataSource, List(Of EABAS_OrdenesCompra)).Sort(_ordenador)
         c1grdBusqueda.Refresh()
         m_order = IIf(m_order = 1, 2, 1)
      Catch ex As Exception
         Throw ex
      End Try
   End Sub

   Private Function getCampo() As Short
      Try
         If (rbtnCliente.Checked) Then
            Return 0
         ElseIf rbtnNroCotizacion.Checked Then
            Return 1
         Else
            Return 0
         End If
      Catch ex As Exception
         Throw ex
      End Try
   End Function

   Private Function validar(ByRef m_msg As String)
      Try
         '' Validar al Cliente
         Dim _msg As String = ""
         If Not ACUtilitarios.ACDatosOk(pnlCabecera, _msg) Then
            m_msg &= _msg
            Return False
         End If
         '' Validar Detalle
         ValidarDetalle(m_msg)
         '' Verificar si hay pedidos
         If Not m_eabas_ordenescompra.ListABAS_OrdenesCompraDetalle.Count > 0 Then
            m_msg &= String.Format("- No se ha ingresado ningun articulo{0}", vbNewLine)
         End If
         Return Not (m_msg.Length > 0)
      Catch ex As Exception
         Throw ex
      End Try
   End Function

   Private Function ValidarDetalle(ByRef m_msg As String) As Boolean
      Try
         bs_detabas_ordenescompra.ResetBindings(False)
         '' Valida que la cantidad y el precio es superior a 0
         For Each Item As EABAS_OrdenesCompraDetalle In m_eabas_ordenescompra.ListABAS_OrdenesCompraDetalle
            If Not (Item.ORDCD_Cantidad * Item.ORDCD_PrecioUnitario) > 0 Then
               m_msg &= String.Format("- El Producto {0} tiene como cantidad {1} y precio {2}, la cual no es aceptable.{3}", Item.Articulo.ARTIC_Descripcion, Item.ORDCD_Cantidad, Item.ORDCD_PrecioUnitario, vbNewLine)
            End If
            '' Validar que no se hayan ingresado cantidades decimales para las unidades que no lo permiten
            Dim _filter As New ACFiltrador(Of ETipos)
            m_earticulos = Item.Articulo
            _filter.ACFiltro = String.Format("TIPOS_Codigo={0}", m_earticulos.TIPOS_CodUnidadMedida)
            If Not _filter.ACFiltrar(Colecciones.TiposUniMedDecimal).Count > 0 Then
               If (Item.ORDCD_Cantidad - Math.Truncate(Item.ORDCD_Cantidad)) > 0 Then
                  m_msg &= String.Format("- El Producto: {0}, no permite que se ingresen cantidades decimales{1}", Item.ARTIC_Descripcion, vbNewLine)
               End If
            End If
         Next
         Return Not (m_msg.Length > 0)
      Catch ex As Exception
         Throw ex
      End Try
   End Function

   Private Sub formatearGrilla()
      Dim index As Integer = 1
      Try
         ACFrameworkC1.ACUtilitarios.ACFormatearGrilla(c1grdBusqueda, 1, 1, 16, 1, 3)
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Codigo", "ENTID_CodigoProveedor", "ENTID_CodigoProveedor", 150, False, False, "System.String") : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Fecha", "ORDCO_FechaDocumento", "ORDCO_FechaDocumento", 150, True, False, "System.DateTime", Parametros.GetParametro(EParametros.TipoParametros.pg_FormatoFecha)) : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Codigo", "Codigo", "Codigo", 150, True, False, "System.String") : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Cotización", "COTCO_Codigo", "COTCO_Codigo", 150, False, False, "System.String") : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Almacen", "ALMAC_Descripcion", "ALMAC_Descripcion", 150, True, False, "System.String") : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Codigo", "ENTID_CodigoProveedor", "ENTID_CodigoProveedor", 150, True, False, "System.String") : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Proveedor", "ENTID_Proveedor", "ENTID_Proveedor", 150, True, False, "System.String") : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Dirección", "ORDCO_DireccionProveedor", "ORDCO_DireccionProveedor", 150, True, False, "System.String") : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Atención", "ORDCO_AtencionProveedor", "ORDCO_AtencionProveedor", 150, True, False, "System.String") : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Telefono", "ORDCO_TelefonoProveedor", "ORDCO_TelefonoProveedor", 150, True, False, "System.Decimal", Parametros.GetParametro(EParametros.TipoParametros.pg_FMondo2d)) : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "E-Mail", "ORDCO_CorreoProveedor", "ORDCO_CorreoProveedor", 150, True, False, "System.String") : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Estado", "ORDCO_Estado_Text", "ORDCO_Estado_Text", 150, True, False, "System.String") : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Doc. Base", "DocBase", "DocBase", 150, True, False, "System.String") : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Doc. Referencia", "DocReferencia", "DocReferencia", 150, True, False, "System.String") : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "COTCO_Estado", "ORDCO_Estado", "ORDCO_Estado", 150, False, False, "System.String") : index += 1

         c1grdBusqueda.AllowEditing = False
         c1grdBusqueda.AllowSorting = AllowSortingEnum.SingleColumn
         c1grdBusqueda.Styles.Alternate.BackColor = Color.LightGray
         c1grdBusqueda.Styles.Fixed.TextAlign = TextAlignEnum.CenterCenter
         c1grdBusqueda.Styles.Highlight.BackColor = Color.Gray
         c1grdBusqueda.SelectionMode = SelectionModeEnum.Row
         c1grdBusqueda.Tree.Column = 2

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
         ACFrameworkC1.ACUtilitarios.ACFormatearGrilla(c1grdDetalle, 1, 1, 7, 1, 0)
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdDetalle, index, "Codigo", "ARTIC_Codigo", "ARTIC_Codigo", 107, True, False, "System.String") : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdDetalle, index, "Descripción", "ARTIC_Descripcion", "ARTIC_Descripcion", 334, True, False, "System.String") : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdDetalle, index, "Unidad", "TIPOS_UnidadMedida", "TIPOS_UnidadMedida", 45, True, False, "System.String") : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdDetalle, index, "Precio", "ORDCD_PrecioUnitario", "ORDCD_PrecioUnitario", 77, True, True, "System.Decimal", Parametros.GetParametro(EParametros.TipoParametros.pg_FMondo2d)) : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdDetalle, index, "Cantidad", "ORDCD_Cantidad", "ORDCD_Cantidad", 92, True, True, "System.Decimal", Parametros.GetParametro(EParametros.TipoParametros.pg_FMondo2d)) : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdDetalle, index, "Sub-Importe", "ORDCD_SubImporteCompra", "ORDCD_SubImporteCompra", 100, True, False, "System.Decimal", Parametros.GetParametro(EParametros.TipoParametros.pg_FMondo2d)) : index += 1
         c1grdDetalle.AllowEditing = True
         c1grdDetalle.AutoResize = False
         c1grdDetalle.Cols(0).Width = 18
         c1grdDetalle.Styles.Alternate.BackColor = Color.LightGray
         c1grdDetalle.Styles.Fixed.TextAlign = TextAlignEnum.CenterCenter
         c1grdDetalle.Styles.Highlight.BackColor = Color.Gray
         c1grdDetalle.SelectionMode = SelectionModeEnum.Row
         c1grdDetalle.AllowResizing = AllowResizingEnum.None
         c1grdDetalle.ExtendLastCol = True
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Text), "No se puede dar formato a la grilla", ex)
      End Try
   End Sub

   Private Sub cargaCombos()
      Try
         bs_moneda = New BindingSource() : bs_moneda.DataSource = Colecciones.Tipos(ETipos.MyTipos.TipoMoneda)
         AddHandler bs_moneda.CurrentChanged, AddressOf bs_monedas_CurrentChanged : bs_monedas_CurrentChanged(Nothing, Nothing)
         ACFramework.ACUtilitarios.ACCargaCombo(cmbMoneda, bs_moneda, "TIPOS_Descripcion", "TIPOS_Codigo")
         ACFramework.ACUtilitarios.ACCargaCombo(cmbTipoDocDestino, Colecciones.TiposDocComprobante, "TIPOS_Descripcion", "TIPOS_Codigo")
         ACUtilitarios.ACCargaCombo(cmbTipoPago, Colecciones.Tipos(ETipos.MyTipos.CondicionPago), "TIPOS_Descripcion", "TIPOS_Codigo")
      Catch ex As Exception
         Throw ex
      End Try
   End Sub

   Private Sub setInstancia(ByVal _opcion As ACUtilitarios.ACSetInstancia)
      Select Case _opcion
         Case ACUtilitarios.ACSetInstancia.Nuevo
            ACUtilitarios.ACLimpiaVar(pnlCabecera)
            ACUtilitarios.ACLimpiaVar(pnlItem)
            ACUtilitarios.ACLimpiaVar(grpDocReferencia)
            ACUtilitarios.ACLimpiaVar(grpCabecera)
            setInstanciaModificar(False)
            actxaProvCodigo.Focus()
            m_modificando = False
            actsbtnPrevisualizar.Visible = True
            pnlItem.Enabled = False
            btnClean.Enabled = True
            btnNuevoProveedor.Enabled = True
            actxaNroCotizacion.Enabled = True
            c1grdDetalle.AllowEditing = True
            acTool.ACBtnAnularVisible = False
            actsbtnPrevisualizar.Visible = False
            grpCabecera.Enabled = True
            ACUtilitarios.ACSetControl(grpCabecera, False, ACUtilitarios.TipoPropiedad.ACReadOnly)
            AddHandler c1grdDetalle.KeyDown, AddressOf c1grdDetalle_KeyDown
         Case ACUtilitarios.ACSetInstancia.Modificado
            setInstanciaModificar(True)
            pnlItem.Enabled = True
            c1grdDetalle.Focus()
            m_modificando = True
            actsbtnPrevisualizar.Visible = True
            btnClean.Enabled = False
            btnNuevoProveedor.Enabled = False
            actxaNroCotizacion.Enabled = False
            acTool.ACBtnAnularVisible = False
            actsbtnPrevisualizar.Visible = False
            AddHandler c1grdDetalle.KeyDown, AddressOf c1grdDetalle_KeyDown
         Case ACUtilitarios.ACSetInstancia.Guardar
            txtBusqueda.Focus()
            m_modificando = False
            actsbtnPrevisualizar.Visible = True
            btnClean.Enabled = False
            btnNuevoProveedor.Enabled = False
            actxaNroCotizacion.Enabled = False
            acTool.ACBtnAnularVisible = True
            actsbtnPrevisualizar.Visible = True
            RemoveHandler c1grdDetalle.KeyDown, AddressOf c1grdDetalle_KeyDown
         Case ACUtilitarios.ACSetInstancia.Deshacer
            actxaProvCodigo.Focus()
            m_modificando = False
            actsbtnPrevisualizar.Visible = True
            btnNuevoProveedor.Enabled = False
            btnClean.Enabled = False
            actxaNroCotizacion.Enabled = False
            acTool.ACBtnAnularVisible = True
            actsbtnPrevisualizar.Visible = True
            'm_modificar = False
            RemoveHandler c1grdDetalle.KeyDown, AddressOf c1grdDetalle_KeyDown
         Case ACUtilitarios.ACSetInstancia.Previsualizar
            ACUtilitarios.ACSetControl(pnlCabecera, True, ACUtilitarios.TipoPropiedad.ACReadOnly)
            ACUtilitarios.ACSetControl(grpCabecera, True, ACUtilitarios.TipoPropiedad.ACReadOnly)
            ACUtilitarios.ACSetControl(grpDocReferencia, True, ACUtilitarios.TipoPropiedad.ACReadOnly)
            pnlItem.Enabled = False
            actxaProvRazonSocial.ACAyuda.Enabled = False
            actxaProvRazonSocial.ACActivarAyuda = False
            actxaProvRuc.ACAyuda.Enabled = False
            actxaProvRuc.ACActivarAyuda = False
            actxaProvCodigo.ACAyuda.Enabled = False
            actxaProvCodigo.ACActivarAyuda = False
            actxaNroCotizacion.Enabled = False
            actxaDocReferencia.ACActivarAyuda = False
            actxaDocReferencia.ACAyuda.Enabled = False
            c1grdDetalle.AllowEditing = False
            RemoveHandler c1grdDetalle.KeyDown, AddressOf c1grdDetalle_KeyDown
            acTool.setInstancia(ACControles.ACToolBarMantHorizontalNew.TipoInstancia.Nuevo)
            acTool.ACBtnGrabarVisible = False
            acTool.ACBtnAnularVisible = True
            actsbtnPrevisualizar.Visible = False
            btnClean.Enabled = False
            btnNuevoProveedor.Enabled = False
      End Select
   End Sub

   Private Sub setInstanciaModificar(ByVal x_opcion As Boolean)
      Try
         ACUtilitarios.ACSetControl(pnlCabecera, x_opcion, ACUtilitarios.TipoPropiedad.ACReadOnly)
         ACUtilitarios.ACSetControl(pnlItem, x_opcion, ACUtilitarios.TipoPropiedad.ACReadOnly)
         ACUtilitarios.ACSetControl(grpDocReferencia, x_opcion, ACUtilitarios.TipoPropiedad.ACReadOnly)
         actxaProvCodigo.ACAyuda.Enabled = Not x_opcion
         actxaProvCodigo.ACActivarAyuda = Not x_opcion
         actxaProvRazonSocial.ACAyuda.Enabled = Not x_opcion
         actxaProvRazonSocial.ACActivarAyuda = Not x_opcion
         actxaProvRuc.ACAyuda.Enabled = Not x_opcion
         actxaProvRuc.ACActivarAyuda = Not x_opcion
         actxaProdCodigo.ACActivarAyuda = Not x_opcion
         actxaProdCodigo.ACAyuda.Enabled = Not x_opcion
         pnlCabecera.Enabled = Not x_opcion
      Catch ex As Exception
         Throw ex
      End Try
   End Sub

   Private Sub calcular()
      Try
         If Not IsNothing(m_eabas_ordenescompra) Then
            If Not IsNothing(m_eabas_ordenescompra.ListABAS_OrdenesCompraDetalle) Then
               Dim _importe As Double = 0
               Dim _importeTotal As Double = 0
               Dim _pesoTotal As Double = 0
               Dim _cantidad As Double = 0
               Dim _igv As Double = Parametros.GetParametro(EParametros.TipoParametros.PIGV)
               For Each Item As EABAS_OrdenesCompraDetalle In m_eabas_ordenescompra.ListABAS_OrdenesCompraDetalle
                  _importeTotal += Item.ORDCD_PrecioUnitario * Item.ORDCD_Cantidad
                  _pesoTotal += Item.Articulo.ARTIC_Peso * Item.ORDCD_Cantidad
                  Item.ORDCD_SubImporteCompra = Item.ORDCD_PrecioUnitario * Item.ORDCD_Cantidad
               Next

               '= Math.Round(_importeTotal, 2)
               Dim _total As Double = Math.Round(_importeTotal * ((_igv + 100) / 100), 2)
               Dim _importeIgv As Double = Math.Round(_importeTotal * (_igv / 100), 2)

               actxnTotal.Text = _total.ToString() : actxnTotal.Formatear()
               actxnIGV.Text = _importeIgv.ToString() : actxnIGV.Formatear()

               actxnImporte.Text = _importeTotal.ToString() : actxnImporte.Formatear()
               actxnPeso.Text = _pesoTotal.ToString() : actxnPeso.Formatear()

               bs_detabas_ordenescompra.ResetBindings(False)
            End If
         End If
      Catch ex As Exception
         Throw ex
      End Try
   End Sub

#End Region

#Region " Cargar Datos"

   ''' <summary>
   ''' Cargar los datos en el control Visual C1FlexGrid
   ''' </summary>
   Private Sub cargarDatos()
      Try
         bs_abas_ordenescompra = New BindingSource()
         bs_abas_ordenescompra.DataSource = managerABAS_OrdenesCompra.ListABAS_OrdenesCompra
         c1grdBusqueda.DataSource = bs_abas_ordenescompra
         bnavBusqueda.BindingSource = bs_abas_ordenescompra
         AddHandler bs_abas_ordenescompra.CurrentChanged, AddressOf bs_detordencompra_CurrentChanged
         bs_detordencompra_CurrentChanged(Nothing, Nothing)
      Catch ex As Exception
         Throw ex
      End Try
   End Sub

   ''' <summary>
   ''' Realiza el enlace de los controles visuales con la clase esquema
   ''' </summary>
   Private Sub AsignarBinding()
      Try
         If Not IsNothing(m_listBindHelper) Then
            For Each Item As ACBindHelper In m_listBindHelper
               Item.ACUnBind()
            Next
         End If
         m_listBindHelper = New List(Of ACBindHelper)()
         m_listBindHelper.Add(ACBindHelper.ACBind(txtCodigo, "Text", m_eabas_ordenescompra, "ORDCO_Codigo"))
         If m_eabas_ordenescompra.ORDCO_FechaDocumento.Year < 1700 Then m_eabas_ordenescompra.ORDCO_FechaDocumento = DateTime.Now
         m_listBindHelper.Add(ACBindHelper.ACBind(dtpFecEmision, "Value", m_eabas_ordenescompra, "ORDCO_FechaDocumento"))
         m_listBindHelper.Add(ACBindHelper.ACBind(txtDireccion, "Text", m_eabas_ordenescompra, "ORDCO_DireccionProveedor"))
         m_listBindHelper.Add(ACBindHelper.ACBind(txtTelefono, "Text", m_eabas_ordenescompra, "ORDCO_TelefonoProveedor"))
         m_listBindHelper.Add(ACBindHelper.ACBind(txtEMail, "Text", m_eabas_ordenescompra, "ORDCO_CorreoProveedor"))
         m_listBindHelper.Add(ACBindHelper.ACBind(txtAtencion, "Text", m_eabas_ordenescompra, "ORDCO_AtencionProveedor"))
         m_listBindHelper.Add(ACBindHelper.ACBind(txtCondiciones, "Text", m_eabas_ordenescompra, "ORDCO_Condiciones"))
         m_listBindHelper.Add(ACBindHelper.ACBind(txtObservaciones, "Text", m_eabas_ordenescompra, "ORDCO_Observaciones"))
         m_listBindHelper.Add(ACBindHelper.ACBind(cmbMoneda, "SelectedValue", m_eabas_ordenescompra, "TIPOS_CodTipoMoneda"))
         m_listBindHelper.Add(ACBindHelper.ACBind(cmbTipoDocDestino, "SelectedValue", m_eabas_ordenescompra, "TIPOS_CodTipoDocDestino"))
         m_listBindHelper.Add(ACBindHelper.ACBind(actxnPeso, "Text", m_eabas_ordenescompra, "ORDCO_PesoTotal"))
         m_listBindHelper.Add(ACBindHelper.ACBind(actxnImporte, "Text", m_eabas_ordenescompra, "ORDCO_ImporteCompra"))
         m_listBindHelper.Add(ACBindHelper.ACBind(actxnIGV, "Text", m_eabas_ordenescompra, "ORDCO_ImporteIgv"))
         m_listBindHelper.Add(ACBindHelper.ACBind(actxnTotal, "Text", m_eabas_ordenescompra, "ORDCO_TotalCompra"))

         m_listBindHelper.Add(ACBindHelper.ACBind(actxaNroCotizacion, "Text", m_eabas_ordenescompra, "COTCO_Codigo"))
         m_listBindHelper.Add(ACBindHelper.ACBind(actxaDocReferencia, "Text", m_eabas_ordenescompra, "DOCCO_Codigo"))
         m_listBindHelper.Add(ACBindHelper.ACBind(cmbTipoPago, "SelectedValue", m_eabas_ordenescompra, "TIPOS_CodTipoPago"))
      Catch ex As Exception
         Throw ex
      End Try
   End Sub

   Private Sub bs_detordencompra_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
      Try
         acTool.ACBtnModificarVisible = False
         If Not IsNothing(bs_abas_ordenescompra.Current) Then
            If CType(bs_abas_ordenescompra.Current, EABAS_OrdenesCompra).ORDCO_Estado = EABAS_OrdenesCompra.getEstado(EABAS_OrdenesCompra.Estado.Confirmado) Then
               acTool.ACBtnAnularEnabled = False
            ElseIf CType(bs_abas_ordenescompra.Current, EABAS_OrdenesCompra).ORDCO_Estado = EABAS_OrdenesCompra.getEstado(EABAS_OrdenesCompra.Estado.Anulado) Then
               acbtnSeleccionar.Enabled = False
               acTool.ACBtnAnularEnabled = False
            Else
               acbtnSeleccionar.Enabled = True
               acTool.ACBtnAnularEnabled = True
            End If
         End If
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso Cargar Propiedades del Cotización/Pedido", ex)
      End Try
   End Sub

#End Region

#Region " Para el Proveedor "
   Private Sub AyudaEntidad(ByVal x_cadenas As String, ByVal x_campo As String, ByVal x_opcion As EEntidades.TipoEntidad)
      Try
         Dim _where As New Hashtable
         _where.Add(x_campo, New ACWhere(x_cadenas, ACWhere.TipoWhere._Like))
         managerEntidades.Ayuda(_where, x_opcion)
         Dim Ayuda As New ACControlesC1.ACAyudaFlex("Buscar Entidad", managerEntidades.DTEntidades, False)
         If Ayuda.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Select Case x_opcion
               Case EEntidades.TipoEntidad.ProveedoresLogistica
                  '' Cargar datos del cliente
                  m_eabas_ordenescompra.ENTID_CodigoProveedor = Ayuda.Respuesta.Rows(0)("Codigo")
                  If managerEntidades.Cargar(m_eabas_ordenescompra.ENTID_CodigoProveedor, EEntidades.TipoInicializacion.Proveedor) Then
                     actxaProvCodigo.Text = managerEntidades.Entidades.ENTID_Codigo
                     actxaProvRazonSocial.Text = managerEntidades.Entidades.ENTID_RazonSocial
                     actxaProvRuc.Text = managerEntidades.Entidades.ENTID_NroDocumento
                     txtDireccion.Text = Ayuda.Respuesta.Rows(0)("Dirección").ToString()
                     txtTelefono.Text = managerEntidades.Entidades.ENTID_Telefono1
                     txtEMail.Text = managerEntidades.Entidades.ENTID_EMail
                     '' Cargar datos adicionales del proveedor
                     m_eentidades = managerEntidades.Entidades
                     txtAtencion.Text = m_eentidades.Proveedor.PROVE_Atencion
                     setRol(IIf(getFilterRol(), Seteo.Activar, Seteo.Desactivar))
                     txtAtencion.Focus()
                  End If
                  '' Cargar datos adicionales del proveedor
                  pnlItem.Enabled = True
               Case EEntidades.TipoEntidad.Vendedores
                  Dim x_entid_codigo As String = Ayuda.Respuesta.Rows(0)("Codigo")
            End Select
         End If
      Catch ex As Exception
         Throw ex
      End Try
   End Sub
#End Region

#Region " Procesos "

   ''' <summary>
   ''' Ejecutar la busqueda de una cadena en la tabla Neumaticos
   ''' </summary>
   ''' <param name="x_cadena">Cadena objetivo</param>
   ''' <returns></returns>
   Private Function busqueda(ByVal x_cadena As String) As Boolean
      Try
         'If txtBusqueda.ACEstadoAutoAyuda Then
         If managerABAS_OrdenesCompra.Busqueda(GApp.Zona, GApp.Sucursal, x_cadena, getCampo(), chkTodos.Checked, AcFecha.ACDtpFecha_De.Value.Date, AcFecha.ACDtpFecha_A.Value.Date) Then
            acTool.ACBtnEliminarEnabled = True
            acTool.ACBtnModificarEnabled = True
         Else
            acTool.ACBtnEliminarEnabled = False
            acTool.ACBtnModificarEnabled = False
         End If
         cargarDatos()
         'End If
         Return acTool.ACBtnEliminarEnabled
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Convert.ToString(Text)), "No se puede cargar la ayuda de los conductores", ex)
      End Try
      Return False
   End Function

   Private Function grabarOrdenCompra(ByRef m_msg As String) As Boolean
      Try
         If validar(m_msg) Then
            If ACControles.ACDialogos.ACMostrarMensajePregunta(String.Format("Grabar Orden de Compra: {0}", Me.Text) _
             , "Desea grabar la Orden de Compra?" _
             , ACControles.ACDialogos.LabelBotom.Si_No) = DialogResult.Yes Then
               '' Obtener datos

               m_eabas_ordenescompra.ALMAC_Id = GApp.Almacen
               '' Obtener el correlativo y asignarlo
               Dim x_corre As Integer = 0
               m_eabas_ordenescompra.ORDCO_Codigo = managerABAS_OrdenesCompra.getCorrelativo(x_corre, GApp.Almacen)
               m_eabas_ordenescompra.ORDCO_Serie = GApp.Almacen.ToString("000")
               m_eabas_ordenescompra.ORDCO_Numero = x_corre
               '' Definir el Estado
               m_eabas_ordenescompra.ORDCO_Estado = EABAS_OrdenesCompra.getEstado(EABAS_OrdenesCompra.Estado.Ingresado)
               '' Asignar la clase pedido a la capa de negocio 
               managerGenerarOrdenCompra.ABAS_OrdenesCompra = m_eabas_ordenescompra
               '' Grabar el pedido
               Return managerGenerarOrdenCompra.GrabaOrdenCompra(GApp.Usuario, m_msg)
            End If
         End If
         Return False
      Catch ex As Exception
         Throw ex
      End Try
   End Function

   Private Sub nuevaOrdenCompra()
      Try
         '' Inicializar clase Pedido
         m_eabas_ordenescompra = New EABAS_OrdenesCompra
         m_eabas_ordenescompra.Instanciar(ACEInstancia.Nuevo)
         '' Instanciar clase
         AsignarBinding()
         setInstancia(ACUtilitarios.ACSetInstancia.Nuevo)
         '' Para Cargar detalle del producto
         bs_detabas_ordenescompra = New BindingSource
         m_eabas_ordenescompra.ListABAS_OrdenesCompraDetalle = New List(Of EABAS_OrdenesCompraDetalle)
         bs_detabas_ordenescompra.DataSource = m_eabas_ordenescompra.ListABAS_OrdenesCompraDetalle
         c1grdDetalle.DataSource = bs_detabas_ordenescompra
         bnavProductos.BindingSource = bs_detabas_ordenescompra

         tabMantenimiento.SelectedTab = tabDatos
         cmbTipoDocDestino.Focus()
      Catch ex As Exception
         Throw ex
      End Try
   End Sub

#End Region

#End Region

#Region " Metodos de Controles"

   Private Sub chkAgrupar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
      Try
         If chkAgrupar.Checked Then
            Ordenar("ENTID_Proveedor")
            c1grdBusqueda.Subtotal(AggregateEnum.Count, 0, 1, 1, "Agrupado por: {0}")
         Else
            c1grdBusqueda.Subtotal(AggregateEnum.Clear)
         End If
         c1grdBusqueda.AutoSizeCols()
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Convert.ToString(Text)), "No se agrupar resultados", ex)
      End Try
   End Sub

   Private Sub acbtnSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
      Try
         If Not IsNothing(bs_abas_ordenescompra) Then
            If Not IsNothing(bs_abas_ordenescompra.Current) Then
               If ACControles.ACDialogos.ACMostrarMensajePregunta(String.Format("Seleccionar Registro: {0}", Me.Text) _
                   , String.Format("Desea seleccionar el registro con codigo: {0}? ", CType(bs_abas_ordenescompra.Current, EABAS_OrdenesCompra).ORDCO_Codigo) _
                   , ACControles.ACDialogos.LabelBotom.Si_No) = DialogResult.Yes Then
                  m_eabas_ordenescompra = CType(bs_abas_ordenescompra.Current, EABAS_OrdenesCompra)
                  Me.DialogResult = Windows.Forms.DialogResult.OK
               End If
            Else
               ACControles.ACDialogos.ACMostrarMensajeInformacion(String.Format("Información: {0}", Me.Text), "No se puede seleccionar una orden, debe seleccionar un registro")
            End If
         Else
            ACControles.ACDialogos.ACMostrarMensajeInformacion(String.Format("Información: {0}", Me.Text), "No se puede seleccionar una orden, debe cargar algunr egistro ")
         End If
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en seleccionarr orden de compra", ex)
      End Try
   End Sub

   Private Sub txtProdDescripcion_SizeChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
      Try
         c1grdDetalle.Cols(2).Width = txtProdDescripcion.Size.Width
      Catch ex As Exception

      End Try
   End Sub

   Private Sub btnNuevoProveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
      Try
         Dim frmEntidad As New MEntidad(MEntidad.Inicio.NuevaEntidad, EEntidades.TipoEntidad.Proveedores)
         If frmEntidad.ShowDialog() = Windows.Forms.DialogResult.OK Then
            m_eentidades = frmEntidad.EEntidad
            m_eabas_ordenescompra.ENTID_CodigoProveedor = m_eentidades.ENTID_Codigo
            actxaProvCodigo.Text = managerEntidades.Entidades.ENTID_Codigo
            actxaProvRazonSocial.Text = managerEntidades.Entidades.ENTID_RazonSocial
            actxaProvRuc.Text = managerEntidades.Entidades.ENTID_NroDocumento
            txtDireccion.Text = managerEntidades.Entidades.ENTID_Direccion
            setRol(IIf(getFilterRol(), Seteo.Activar, Seteo.Desactivar))
            pnlItem.Enabled = True
         End If
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso Nuevo Cliente", ex)
      End Try
   End Sub

   Private Sub btnClean_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
      Try
         m_eentidades = New EEntidades
         actxaProvCodigo.Clear()
         actxaProvRazonSocial.Clear()
         actxaProvRuc.Clear()
         txtDireccion.Clear()
         setRol(Seteo.Activar)
         pnlItem.Enabled = False
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso Limpiar Entidad", ex)
      End Try
   End Sub

   Private Sub AcFecha_ACFecIni_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles acFecha.ACFecIni_KeyDown
      If e.KeyData = Keys.Enter Then
         AcFecha.ACDtpFecha_A.Focus()
      End If
   End Sub

   Private Sub AcFecha_ACFecFin_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles AcFecha.ACFecFin_KeyDown
      If e.KeyData = Keys.Enter Then
         txtBusqueda_ACAyudaClick(Nothing, Nothing)
      End If
   End Sub

#Region " ToolBar "

   Private Sub acTool_ACBtnRehusar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles acTool.ACBtnRehusar_Click
      Try
         'Dim x_codigo As Long = m_event_pedidos.PEDID_Id
         'nuevoPedido()
         'If managerVENT_Pedidos.Cargar(x_codigo, True) Then
         '   m_event_pedidos = managerVENT_Pedidos.VENT_Pedidos
         '   m_event_pedidos.Instanciar(ACEInstancia.Nuevo)
         '   AsignarBinding()
         '   '' Cargar listado de Productos
         '   bs_detcotizacionescompras = New BindingSource
         '   bs_detPedido.DataSource = m_event_pedidos.ListDetPedidos
         '   c1grdDetalle.DataSource = bs_detcotizacionescompras
         '   bnavProductos.BindingSource = bs_detcotizacionescompras
         '   tabMantenimiento.SelectedTab = tabDatos
         '   '' Cargar datos del Cliente
         '   actxaCliCodigo.Text = m_event_pedidos.ENTID_Codigo
         '   actxaCliRuc.Text = m_event_pedidos.ENTID_NroDocumento
         '   '' Cargar Vendedor
         '   cargarVendedor(m_event_pedidos.ENTID_CodigoVendedor)
         '   acTool.setInstancia(ACControles.ACToolBarMantHorizontalNew.TipoInstancia.Nuevo)
         '   acTool.ACBtnRehusarVisible = False
         '   actsbtnPrevisualizar.Visible = False
         'End If
         ' '' Activar las opciones generales del teclado
         'KeyPreview = True
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso Rehuzar Cotización Pedido", ex)
      End Try
   End Sub

   Private Sub actsbtnPrevisualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles actsbtnPrevisualizar.Click
      Try
         If Not IsNothing(bs_abas_ordenescompra) Then
            If Not IsNothing(bs_abas_ordenescompra.Current) Then
               Dim x_codigo As String = CType(bs_abas_ordenescompra.Current, EABAS_OrdenesCompra).ORDCO_Codigo
               '' Cargar Cotizacion
               If managerABAS_OrdenesCompra.Cargar(x_codigo, True) Then
                  m_eabas_ordenescompra = managerABAS_OrdenesCompra.ABAS_OrdenesCompra
                  AsignarBinding()
                  '' Cargar listado de Productos
                  bs_detabas_ordenescompra = New BindingSource
                  bs_detabas_ordenescompra.DataSource = m_eabas_ordenescompra.ListABAS_OrdenesCompraDetalle
                  c1grdDetalle.DataSource = bs_detabas_ordenescompra
                  bnavProductos.BindingSource = bs_detabas_ordenescompra
                  tabMantenimiento.SelectedTab = tabDatos
                  '' Cargar datos del Cliente
                  If managerEntidades.Cargar(m_eabas_ordenescompra.ENTID_CodigoProveedor) Then
                     actxaProvCodigo.Text = m_eabas_ordenescompra.ENTID_CodigoProveedor
                     actxaProvRuc.Text = m_eabas_ordenescompra.ENTID_NroDocumento
                     actxaProvRazonSocial.Text = managerEntidades.Entidades.ENTID_RazonSocial
                  End If
                  '' Setear Valores
                  setInstancia(ACUtilitarios.ACSetInstancia.Previsualizar)
               Else
                  ACControles.ACDialogos.ACMostrarMensajeInformacion(String.Format("Información: {0}", Me.Text), "No se puede cargar, por que no selecciono ningun registro ")
               End If
            Else
               ACControles.ACDialogos.ACMostrarMensajeInformacion(String.Format("Información: {0}", Me.Text), "No se puede cargar por que no cargo ningun registro enla grilla ")
            End If
         End If
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso Previsualizar", ex)
      End Try
   End Sub

   Private Sub acTool_ACBtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles acTool.ACBtnNuevo_Click
      Try
         nuevaOrdenCompra()
         setProducto(False)
         actxaNroCotizacion.ReadOnly = False : actxaNroCotizacion.ACAyuda.Enabled = True : actxaNroCotizacion.ACActivarAyuda = True
         '' Activar las opciones generales del teclado
         KeyPreview = True

         '' Campos Obligatorios
         'actxaCodigo.Focus()
         eprError.SetError(Me.actxaProvCodigo, "Campo Obligatorio")
         eprError.SetError(Me.actxaProvRazonSocial, "Campo Obligatorio")
         eprError.SetError(Me.txtCodigo, "Campo Obligatorio")
         eprError.SetError(Me.cmbTipoDocDestino, "Campo Obligatorio")
         eprError.SetError(Me.actxaNroCotizacion, "Campo Obligatorio")
         Me.KeyPreview = True


      Catch ex As Exception
         acTool.setInstancia(ACControles.ACToolBarMantHorizontalNew.TipoInstancia.Cancelar)
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso Nueva Cotización/Pedido", ex)
      End Try
   End Sub

   Private Sub acTool_ACBtnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles acTool.ACBtnGrabar_Click
      Dim m_msg As String = ""
      Try
         If grabarOrdenCompra(m_msg) Then
            '' Manejar las opciones de la barra de herramientas
            acTool.setInstancia(ACControles.ACToolBarMantHorizontalNew.TipoInstancia.Cancelar)
            tabMantenimiento.SelectedTab = tabBusqueda
            ACControles.ACDialogos.ACMostrarMensajeSatisfactorio(String.Format("Información: {0}", Me.Text), "Grabado Satisfactoriamente")
            acTool.ACBtnModificarVisible = m_proceso_modificar
            txtBusqueda_ACAyudaClick(Nothing, Nothing)
            setInstancia(ACUtilitarios.ACSetInstancia.Guardar)
         Else
            acTool.setInstancia(ACControles.ACToolBarMantHorizontalNew.TipoInstancia.Nuevo)
            ACControles.ACDialogos.ACMostrarMensajeInformacion(String.Format("Información: {0}", Me.Text), "No se puede grabar, revise los detalles:", m_msg)
         End If
      Catch ex As Exception
         acTool.setInstancia(ACControles.ACToolBarMantHorizontalNew.TipoInstancia.Nuevo)
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso Grabar Cotización/Pedido", ex)
      End Try
   End Sub

   Private Sub acTool_ACBtnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles acTool.ACBtnImprimir_Click
      Try
         If Not IsNothing(bs_abas_ordenescompra) Then
            If Not IsNothing(bs_abas_ordenescompra.Current) Then
               Dim x_codigo As String = CType(bs_abas_ordenescompra.Current, EABAS_OrdenesCompra).ORDCO_Codigo
               If managerGenerarOrdenCompra.RegistroCompra(x_codigo) Then
                  Dim dtDatos As New DTOrdenCompra
                  Dim i As Integer = 0

                  For Each Item As DataRow In managerGenerarOrdenCompra.Datos.Tables(0).Rows
                     Dim _dr As DataRow = dtDatos.OrdenCompra.NewRow()
                     _dr("Codigo") = Item("Codigo")
                     _dr("ORDCO_FechaDocumento") = Item("ORDCO_FechaDocumento")
                     _dr("ORDCO_AtencionProveedor") = Item("ORDCO_AtencionProveedor")
                     _dr("ORDCO_TelefonoProveedor") = Item("ORDCO_TelefonoProveedor")
                     _dr("ORDCO_CorreoProveedor") = Item("ORDCO_CorreoProveedor")
                     _dr("ORDCO_Condiciones") = Item("ORDCO_Condiciones")
                     _dr("ORDCO_ImporteCompra") = Item("ORDCO_ImporteCompra")
                     _dr("ORDCO_TotalCompra") = Item("ORDCO_TotalCompra")
                     _dr("ORDCO_ImporteIgv") = Item("ORDCO_ImporteIgv")
                     _dr("ORDCO_DireccionProveedor") = Item("ORDCO_DireccionProveedor")
                     _dr("ENTID_Proveedor") = Item("ENTID_Proveedor")
                     _dr("Usuario") = GApp.EUsuarioEntidad.ENTID_Nombres
                     dtDatos.OrdenCompra.Rows.Add(_dr)
                  Next

                  For Each Item As DataRow In managerGenerarOrdenCompra.Datos.Tables(1).Rows
                     Dim _dr As DataRow = dtDatos.OrdenCompraDetalle.NewRow()
                     _dr("Codigo") = Item("Codigo")
                     _dr("ARTIC_Descripcion") = Item("ARTIC_Descripcion")
                     _dr("ORDCD_Item") = Item("ORDCD_Item")
                     _dr("ORDCD_PrecioUnitario") = Item("ORDCD_PrecioUnitario")
                     _dr("ORDCD_Cantidad") = Item("ORDCD_Cantidad")
                     _dr("ORDCD_SubImporteCompra") = Item("ORDCD_SubImporteCompra")
                     dtDatos.OrdenCompraDetalle.Rows.Add(_dr)
                  Next
                  Dim Informe As New CROrdenCompra
                  Informe.SetDataSource(dtDatos)
                  Dim reporte As New RReportView(Informe)
                  reporte.ShowDialog()
               End If
            Else
               ACControles.ACDialogos.ACMostrarMensajeInformacion(String.Format("Información: {0}", Me.Text), "No se puede cargar el reporte por que no se ha seleccionado ninguna Orden de Compra")
            End If
         Else
            ACControles.ACDialogos.ACMostrarMensajeInformacion(String.Format("Información: {0}", Me.Text), "No se puede cargar el reporte por que no se ha cargado ningun registro")
         End If
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso Imprimir Cotización/Pedido", ex)
      End Try
   End Sub

   Private Sub acTool_ACBtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles acTool.ACBtnCancelar_Click
      Try
         If pnlItem.Enabled Then
            If ACControles.ACDialogos.ACMostrarMensajePregunta(String.Format("Cancelar Orden de Compra: {0}", Me.Text) _
                , "Desea cancelar la Orden de Compra?" _
                , ACControles.ACDialogos.LabelBotom.Si_No) = DialogResult.Yes Then
               tabMantenimiento.SelectedTab = tabBusqueda
               acTool.ACBtnModificarVisible = m_proceso_modificar
               setInstancia(ACUtilitarios.ACSetInstancia.Deshacer)
            Else
               acTool.setInstancia(ACControles.ACToolBarMantHorizontalNew.TipoInstancia.Nuevo)
            End If
         Else
            tabMantenimiento.SelectedTab = tabBusqueda
            acTool.ACBtnModificarVisible = m_proceso_modificar
            setInstancia(ACUtilitarios.ACSetInstancia.Deshacer)
         End If
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso cancelar la Cotización/Pedido", ex)
      End Try
   End Sub

   Private Sub acTool_ACBtnAnular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles acTool.ACBtnAnular_Click
      Try
         If Not IsNothing(bs_abas_ordenescompra) Then
            If Not IsNothing(bs_abas_ordenescompra.Current) Then
               If ACControles.ACDialogos.ACMostrarMensajePregunta(String.Format("Anular Registro: {0}", Me.Text) _
                   , String.Format("Desea anular el registro con codigo: {0}", CType(bs_abas_ordenescompra.Current, EABAS_OrdenesCompra).ORDCO_Codigo) _
                   , ACControles.ACDialogos.LabelBotom.Si_No) = DialogResult.Yes Then
                  Dim _ordecompra As New EABAS_OrdenesCompra
                  _ordecompra.ORDCO_Codigo = CType(bs_abas_ordenescompra.Current, EABAS_OrdenesCompra).ORDCO_Codigo
                  _ordecompra.ORDCO_Estado = EABAS_OrdenesCompra.getEstado(EABAS_OrdenesCompra.Estado.Anulado)
                  _ordecompra.Instanciar(ACEInstancia.Modificado)
                  managerABAS_OrdenesCompra.ABAS_OrdenesCompra = _ordecompra
                  If managerABAS_OrdenesCompra.Guardar(GApp.Usuario) Then
                     ACControles.ACDialogos.ACMostrarMensajeSatisfactorio(String.Format("Información: {0}", Me.Text), "Anulado satisfactoriamente")
                     tabMantenimiento.SelectedTab = tabBusqueda
                     setInstancia(ACUtilitarios.ACSetInstancia.Deshacer)
                     txtBusqueda_ACAyudaClick(Nothing, Nothing)
                  Else
                     ACControles.ACDialogos.ACMostrarMensajeInformacion(String.Format("Información: {0}", Me.Text), "No se puede Anular")
                  End If
               End If
            Else
               ACControles.ACDialogos.ACMostrarMensajeInformacion(String.Format("Información: {0}", Me.Text), "No se puede anular por que no cargo ningun registro")
            End If
         Else
            ACControles.ACDialogos.ACMostrarMensajeInformacion(String.Format("Información: {0}", Me.Text), "No se puede anular por que no se seleccion ningun registro")
         End If
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso Anular Cotización Pedido", ex)
      End Try
   End Sub

   Private Sub acTool_ACBtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles acTool.ACBtnSalir_Click
      Try
         Me.Close()
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso Salir", ex)
      End Try
   End Sub

#End Region

#Region " Ayuda para Proveedor "

   Private Sub actxaProvCodigo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles actxaProvCodigo.KeyDown
      Try
         If e.KeyData = Keys.Enter And actxaProvCodigo.Text.ToString().Length >= Constantes.LongitudCodigo Then
            '' Cargar datos adicionales cliente
            If managerEntidades.Cargar(actxaProvCodigo.Text, EEntidades.TipoInicializacion.Cliente) Then
               '' Cargar datos del cliente
               m_eabas_ordenescompra.ENTID_CodigoProveedor = managerEntidades.Entidades.ENTID_Codigo
               m_eentidades = managerEntidades.Entidades
               actxaProvCodigo.Text = managerEntidades.Entidades.ENTID_Codigo
               actxaProvRazonSocial.Text = managerEntidades.Entidades.ENTID_RazonSocial
               actxaProvRuc.Text = managerEntidades.Entidades.ENTID_NroDocumento
               txtDireccion.Text = managerEntidades.Entidades.ENTID_Direccion
               setRol(IIf(getFilterRol(), Seteo.Activar, Seteo.Desactivar))
               pnlItem.Enabled = True
            Else
               ACControles.ACDialogos.ACMostrarMensajeInformacion(String.Format("Información: {0}", Me.Text), String.Format("El codigo {0} no existe", actxaProvCodigo.Text))
               btnClean_Click(Nothing, Nothing)
            End If
         End If
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso Cargar Cliente", ex)
      End Try
   End Sub

   Private Sub actxaProvCodigo_ACAyudaClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles actxaProvCodigo.ACAyudaClick
      Try
         AyudaEntidad(actxaProvCodigo.Text, "ENTID_Codigo", EEntidades.TipoEntidad.ProveedoresLogistica)
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso busqueda de cliente por codigo", ex)
      End Try
   End Sub

   Private Sub actxaProvRazonSocial_ACAyudaClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles actxaProvRazonSocial.ACAyudaClick
      Try
         AyudaEntidad(actxaProvRazonSocial.Text, "ENTID_RazonSocial", EEntidades.TipoEntidad.ProveedoresLogistica)
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso busqueda de cliente por Nombre/Razon Social", ex)
      End Try
   End Sub

   Private Sub actxaProvRuc_ACAyudaClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles actxaProvRuc.ACAyudaClick
      Try
         AyudaEntidad(actxaProvCodigo.Text, "ENTID_NroDocumento", EEntidades.TipoEntidad.ProveedoresLogistica)
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso Documento de Identidad", ex)
      End Try
   End Sub

#End Region

#Region " Ayuda para el Producto "

   Private Sub txtBusqueda_ACAyudaClick(ByVal sender As Object, ByVal e As EventArgs) Handles txtBusqueda.ACAyudaClick, btnConsultar.Click
      Try
         busqueda(txtBusqueda.Text)
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Convert.ToString(Text)), "No se puede cargar la ayuda de los conductores", ex)
      End Try
   End Sub

   Private Sub actxaProdCodigo_ACAyudaClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles actxaProdCodigo.ACAyudaClick
      Try
         If IsNothing(frmCons) Then
            frmCons = New CProductos(CProductos.Origen.Cotizaciones) With {.StartPosition = FormStartPosition.CenterScreen}
         End If
         Me.KeyPreview = False
         If frmCons.ShowDialog() = Windows.Forms.DialogResult.OK Then
            If managerConsultaArticulos.cargarProducto(frmCons.Articulo.ARTIC_Codigo) Then
               m_earticulos = managerConsultaArticulos.Articulos
               setProducto(True)
               Dim _filter As New ACFiltrador(Of ETipos)
               _filter.ACFiltro = String.Format("TIPOS_Codigo={0}", m_earticulos.TIPOS_CodUnidadMedida)
               If _filter.ACFiltrar(Colecciones.TiposUniMedDecimal).Count > 0 Then
                  actxnCantidad.ACDecimales = 2
               Else
                  actxnCantidad.ACDecimales = 0
               End If
               Me.KeyPreview = True
            End If
         End If
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso cargar productos", ex)
      End Try
   End Sub

   Private Sub setProducto(ByVal x_opcion As Boolean)
      Try
         If x_opcion Then
            actxaProdCodigo.Text = m_earticulos.ARTIC_Codigo
            txtProdDescripcion.Text = m_earticulos.ARTIC_Descripcion
            txtUnidad.Text = m_earticulos.TIPOS_UndMedCorta
            If managerABAS_ListaPreciosCompra.GetPreciosArticulo(m_eentidades.ENTID_Codigo, m_earticulos.ARTIC_Codigo) Then
               For Each Item As EABAS_ListaPreciosCompra In managerABAS_ListaPreciosCompra.ListABAS_ListaPreciosCompra
                  If Item.TIPOS_CodTipoMoneda.Equals(cmbMoneda.SelectedValue) Then
                     actxnPrecio.Text = Item.Precio
                     Exit For
                  End If
               Next
               m_listprecios = New List(Of EABAS_ListaPreciosCompra)(managerABAS_ListaPreciosCompra.ListABAS_ListaPreciosCompra)
            End If
            txtUnidad.Focus()
         Else
            actxaProdCodigo.Clear()
            txtProdDescripcion.Clear()
            actxnCantidad.Text = "0.00"
            actxnPrecio.Text = "0.00"
            actxnSubImporte.Text = "0.00"
         End If
         calcular()
      Catch ex As Exception
         Throw ex
      End Try
   End Sub
#End Region

#Region " Ayudas "

   Private Sub actxaNroCotizacion_ACAyudaClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles actxaNroCotizacion.ACAyudaClick
      Try
         Dim frmCotiz As New TCotCompras(TCotCompras.Inicio.Busqueda)
         frmCotiz.StartPosition = FormStartPosition.CenterScreen

         If frmCotiz.ShowDialog() = Windows.Forms.DialogResult.OK Then
            CotizToOrden(frmCotiz.ABAS_Cotizacioncompra)
            pnlItem.Enabled = False
         End If
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso cargar Cotización", ex)
      End Try
   End Sub

   Private Sub actxaDocReferencia_ACAyudaClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles actxaDocReferencia.ACAyudaClick
      Try
         If rbtnDocVenta.Checked Then
            Dim frmDocVenta As New CDocumentos() With {.StartPosition = FormStartPosition.CenterScreen, .MaximizeBox = False, .FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle}
            If frmDocVenta.ShowDialog() = Windows.Forms.DialogResult.OK Then
               actxaDocReferencia.Text = frmDocVenta.VENT_DocsVenta.DOCVE_Codigo
            End If
         Else
            ACControles.ACDialogos.ACMostrarMensajeInformacion(String.Format("Información: {0}", Me.Text), "Funcion No Implementada")
         End If
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso Ayuda del documento de referencia", ex)
      End Try
   End Sub

#End Region

#Region " Textos "
   Private Sub actxnCalc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles actxnPrecio.TextChanged, actxnCantidad.TextChanged
      Try
         If Not actxnCantidad.Text.Equals("") And Not actxnImporte.Text.Equals("") Then
            Dim _cantidad As Double = actxnCantidad.Text
            Dim _importe As Double = actxnPrecio.Text
            actxnSubImporte.Text = (_cantidad * _importe).ToString(Parametros.GetParametro(EParametros.TipoParametros.pg_FMondo2d))
         End If
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso calcular importe", ex)
      End Try
   End Sub

   Private Sub txtOpcion_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtOpcion.KeyPress
      Try
         Select Case e.KeyChar
            Case "+"c
               If m_modArticulo Then
                  e.Handled = True
                  CType(bs_detabas_ordenescompra.Current, EABAS_OrdenesCompraDetalle).ORDCD_Cantidad = actxnCantidad.Text
                  CType(bs_detabas_ordenescompra.Current, EABAS_OrdenesCompraDetalle).ORDCD_PrecioUnitario = actxnPrecio.Text
                  CType(bs_detabas_ordenescompra.Current, EABAS_OrdenesCompraDetalle).ORDCD_SubImporteCompra = actxnSubImporte.Text
                  setProducto(False)
                  c1grdDetalle.Enabled = True
                  Me.KeyPreview = False
                  m_modArticulo = False
                  actxaProdCodigo.Focus()
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

   Private Sub txtOpcion_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtOpcion.KeyDown
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
               Me.KeyPreview = False
               m_modArticulo = False
            Case Else

         End Select
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Text), "No se puede procesar", ex)
      End Try
   End Sub

   Private Sub txtBusqueda_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBusqueda.Enter
      Me.KeyPreview = False
   End Sub

   Private Sub txtBusqueda_KeyUp(ByVal sender As Object, ByVal e As KeyEventArgs) Handles txtBusqueda.KeyUp
      Try
         If e.KeyCode = Keys.Enter Then
            busqueda(txtBusqueda.Text)
         End If
      Catch ex As Exception
         Throw ex
      End Try
   End Sub

   Private Sub txtBusqueda_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBusqueda.KeyDown
      Try
         Select Case e.KeyCode
            Case Keys.Down
               bs_abas_ordenescompra.Position += 1
               e.Handled = True
               Exit Select
            Case Keys.Up
               bs_abas_ordenescompra.Position -= 1
               e.Handled = True
               Exit Select
            Case Keys.PageDown
               bs_abas_ordenescompra.Position += 10
               e.Handled = True
               Exit Select
            Case Keys.PageUp
               bs_abas_ordenescompra.Position -= 10
               e.Handled = True
               Exit Select
            Case Keys.Enter
               'actsbtnPrevisualizar_Click(Nothing, Nothing)
         End Select
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "No puede completar el proceso ejecutado por el teclado", ex)
      End Try
   End Sub

#End Region

#Region " Grillas "

   Private Sub c1grdDetalle_AfterEdit(ByVal sender As System.Object, ByVal e As C1.Win.C1FlexGrid.RowColEventArgs) Handles c1grdDetalle.AfterEdit
      Try
         For Each Item As EABAS_OrdenesCompraDetalle In m_eabas_ordenescompra.ListABAS_OrdenesCompraDetalle
            Item.ORDCD_SubImporteCompra = Item.ORDCD_Cantidad * Item.ORDCD_PrecioUnitario
         Next
         calcular()
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso calcular precio", ex)
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

   Private Sub c1grdBusqueda_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c1grdBusqueda.DoubleClick
      If Not IsNothing(bs_abas_ordenescompra) Then
         If Not IsNothing(bs_abas_ordenescompra.Current) Then
            '' Codigo
            actsbtnPrevisualizar_Click(Nothing, Nothing)
         Else
            ACControles.ACDialogos.ACMostrarMensajeInformacion(String.Format("Información: {0}", Me.Text), "No se puede <<Mensaje>> ")
         End If
      Else
         ACControles.ACDialogos.ACMostrarMensajeInformacion(String.Format("Información: {0}", Me.Text), "No se puede <<Mensaje>> ")
      End If
   End Sub

   Private Sub c1grdBusqueda_OwnerDrawCell(ByVal sender As System.Object, ByVal e As C1.Win.C1FlexGrid.OwnerDrawCellEventArgs) Handles c1grdBusqueda.OwnerDrawCell
      Try
         If e.Row < c1grdBusqueda.Rows.Fixed OrElse e.Col < c1grdBusqueda.Cols.Fixed Then Return
         If c1grdBusqueda.Cols(e.Col).Name = "ORDCO_FechaDocumento" Or c1grdBusqueda.Cols(e.Col).Name = "ALMAC_Descripcion" Or c1grdBusqueda.Cols(e.Col).Name = "ENTID_Proveedor" Then
            If c1grdBusqueda.Rows(e.Row)("ORDCO_Estado") = EABAS_OrdenesCompra.getEstado(EABAS_OrdenesCompra.Estado.Confirmado) Then
               e.Style = c1grdBusqueda.Styles("Facturado")
            End If
         End If
         If c1grdBusqueda.Rows(e.Row)("ORDCO_Estado") = EABAS_OrdenesCompra.getEstado(EABAS_OrdenesCompra.Estado.Anulado) Then
            e.Style = c1grdBusqueda.Styles("Anulado")
         End If
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso cambia de color", ex)
      End Try
   End Sub

   Private Sub c1grdDetalle_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c1grdDetalle.Enter
      Me.KeyPreview = False
   End Sub

   Private Sub c1grdDetalle_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
      Try
         'e.SuppressKeyPress = True
         Select Case e.KeyCode
            Case Keys.Enter
               subirItem()
               'SendKeys.Send("{F4}")
               c1grdDetalle.Enabled = False
               m_modArticulo = True
            Case Keys.Delete
               If ACControles.ACDialogos.ACMostrarMensajePregunta(String.Format("Quitar Registro: {0}", Me.Text) _
             , String.Format("Desea quitar el Articulo : {0} ", CType(bs_detabas_ordenescompra.Current, EABAS_OrdenesCompraDetalle).ARTIC_Descripcion) _
             , ACControles.ACDialogos.LabelBotom.Si_No) = DialogResult.Yes Then
                  Dim m_det As EABAS_OrdenesCompraDetalle = CType(bs_detabas_ordenescompra.Current, EABAS_OrdenesCompraDetalle)
                  m_eabas_ordenescompra.ListABAS_OrdenesCompraDetalle.Remove(m_det)
                  bs_detabas_ordenescompra.ResetBindings(False)
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


   Private Sub setEtiqueta(ByVal x_moneda As ETipos.TipoMoneda)
      Try
         Select Case x_moneda
            Case ETipos.TipoMoneda.Soles
               lbligv.Text = String.Format("I.G.V. : {0}", Constantes.Moneda(ETipos.TipoMoneda.Soles))
               lblImporte.Text = String.Format("Importe : {0}", Constantes.Moneda(ETipos.TipoMoneda.Soles))
               lblTotal.Text = String.Format("Total : {0}", Constantes.Moneda(ETipos.TipoMoneda.Soles))
               lblPrecio.Text = String.Format("Precio {0}", Constantes.Moneda(ETipos.TipoMoneda.Soles))
            Case ETipos.TipoMoneda.Dolares
               lbligv.Text = String.Format("I.G.V. : {0}", Constantes.Moneda(ETipos.TipoMoneda.Dolares))
               lblImporte.Text = String.Format("Importe : {0}", Constantes.Moneda(ETipos.TipoMoneda.Dolares))
               lblTotal.Text = String.Format("Total : {0}", Constantes.Moneda(ETipos.TipoMoneda.Dolares))
               lblPrecio.Text = String.Format("Precio {0}", Constantes.Moneda(ETipos.TipoMoneda.Dolares))
            Case Else
               setEtiqueta(ETipos.TipoMoneda.Soles)
         End Select
      Catch ex As Exception
         Throw ex
      End Try
   End Sub

   Private Sub bs_monedas_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
      Try
         calcular()
         If cmbMoneda.SelectedValue = ETipos.getTipo(ETipos.TipoMoneda.Soles) Then
            setEtiqueta(ETipos.TipoMoneda.Soles)
         ElseIf cmbMoneda.SelectedValue = ETipos.getTipo(ETipos.TipoMoneda.Dolares) Then
            setEtiqueta(ETipos.TipoMoneda.Dolares)
         Else
            setEtiqueta(ETipos.TipoMoneda.Soles)
         End If
         setPrecio(cmbMoneda.SelectedValue)
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError("Error: " & Me.Text, "Ocurrio un error en el proceso <Procesos>", ex)
      End Try
   End Sub

   Private Sub setPrecio(ByVal x_moneda As String)
      Try
         If Not IsNothing(m_eabas_ordenescompra) Then
            For Each Item As EABAS_OrdenesCompraDetalle In m_eabas_ordenescompra.ListABAS_OrdenesCompraDetalle
               Item.ORDCD_PrecioUnitario = 0
               If Not IsNothing(Item.ListEABAS_ListaPreciosCompra) Then
                  For Each Precio As EABAS_ListaPreciosCompra In Item.ListEABAS_ListaPreciosCompra
                     If Precio.TIPOS_CodTipoMoneda.Equals(x_moneda) Then
                        Item.ORDCD_PrecioUnitario = Precio.Precio
                        Exit For
                     End If
                  Next
               End If
            Next
         End If
      Catch ex As Exception
         Throw ex
      End Try
   End Sub

End Class