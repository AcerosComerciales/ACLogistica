Imports ACBLogistica
Imports ACBVentas
Imports ACControles
Imports ACELogistica
Imports ACFramework
Imports ACEVentas
Imports C1.Win.C1FlexGrid
Imports DAConexion

Public Class TPedidoCompra
#Region " Variables "

    Private managerGenerarPedidoCompra As BGenerarPedidoCompra
       Private managerConsultaArticulos As BConsultaArticulos
    Private managerABAS_PedidosCompra As BABAS_PedidosCompra  
  
    Private m_eabas_pedidoscompra As EABAS_PedidosCompra

Private m_listBindHelper As List(Of ACBindHelper)

    Private bs_pedidos As BindingSource
    Private bs_detPedido As BindingSource
    Private bs_puntoventa As BindingSource
    Private bs_puntoventapedido As BindingSource

    Private m_earticulos As EArticulos
    Private m_puntoventa As EPuntoVenta
    Private frmCons As CProductos

    Private m_modArticulo As Boolean = False
    Private m_tinicio As TInicio

       Private managerEntidades As BEntidades

    Enum TInicio
        Normal
        Busqueda
    End Enum

#End Region
#Region " Propiedades "
      Public Property ABAS_Pedidoscompra() As EABAS_PedidosCompra
      Get
         Return m_eabas_pedidoscompra
      End Get
      Set(ByVal value As EABAS_PedidosCompra)
         m_eabas_pedidoscompra = value
      End Set
   End Property



    Public Property PuntoVenta() As EPuntoVenta
        Get
            Return m_puntoventa
        End Get
        Set(ByVal value As EPuntoVenta)
            m_puntoventa = value
        End Set
    End Property

#End Region
#Region " Constructores "
    'Public Sub New(ByVal x_icono As System.Drawing.Bitmap, ByVal x_opcion As TInicio)
        Public Sub New()


        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Try
             Inicializacion()
           ' m_tinicio = x_opcion
        Catch ex As Exception
            ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), Colecciones.getError("00000"), ex)
        End Try
    End Sub
      Public Sub New(byval x_inicio as TInicio)
      ' This call is required by the Windows Form Designer.
      InitializeComponent()
      Try
         Inicializacion()
         txtBusqueda_ACAyudaClick(Nothing, Nothing)
         Me.MinimizeBox = False
         If x_inicio = TInicio.Busqueda Then
            acTool.ACBtnNuevoVisible = False
            acTool.ACBtnModificarVisible = False
            acTool.ACBtnImprimirVisible = False
            acTool.ACBtnAnularVisible = False
            acbtnSeleccionar.Visible = True
         End If
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "No se puede cargar los controles iniciales", ex)
      End Try
   End Sub
     Private sub Inicializacion() 
      try
         tabMantenimiento.HideTabsMode = Crownwood.DotNetMagic.Controls.HideTabsModes.HideAlways
         tabMantenimiento.SelectedTab = tabBusqueda
        '' Inicializar los componentes con Unity
         managerGenerarPedidoCompra = New BGenerarPedidoCompra(GApp.Periodo)
         managerEntidades = New BEntidades
         managerConsultaArticulos = New BConsultaArticulos(GApp.Periodo)
           managerABAS_PedidosCompra = New BABAS_PedidosCompra

         '' Iniciarlizar los componentes graficos
         formatearGrilla()
         '' Aplicar el titulo segun el tipo de documento que se va a cargar
         Me.Text = acpnlTitulo.ACCaption
         '' Obtener el proceso que se va a validar
         'GApp.DataUsuario.PROC_Codigo = Constantes.getProceso(Constantes.TipoProcesos.ModificarPedido)
         'Dim _validate As New ACValidarUsuario(GApp.DataConexion, GApp.DataUsuario, ACValidarUsuario.Operacion.ValidarProceso)
         'm_proceso_modificar = _validate.ACProceso
         'acTool.ACBtnModificarVisible = m_proceso_modificar

             AddHandler acTool.ACBtnAnular_Click, AddressOf acTool_ACBtnAnular_Click
              
        

         Me.Icon = Icon.FromHandle(ACPLogistica.My.Resources.Guia_16x16.GetHicon)

             AcFecha.ACDtpFecha_De.Value = DateTime.Now.AddDays(-1 * DateTime.Now.Day + 1)
             setInstancia(ACUtilitarios.ACSetInstancia.Deshacer)
      Catch ex As Exception
         throw ex
      End Try
   End Sub
#End Region

    
   Private Sub setInstancia(ByVal _opcion As ACUtilitarios.ACSetInstancia)
      actsbtnPrevisualizar.Visible = False
      acTool.ACBtnModificarVisible = True
      RemoveHandler c1grdDetalle.KeyDown, AddressOf c1grdDetalle_KeyDown
      Select Case _opcion
         Case ACUtilitarios.ACSetInstancia.Nuevo
            ACUtilitarios.ACLimpiaVar(pnlItem)
            actsbtnPrevisualizar.Visible = False
            acTool.ACBtnModificarVisible = False
            acTool.ACBtnImprimirVisible = False
            chkAnulada.Checked = False
            chkAtendida.Checked = False
            acpnlTitulo.Active = False
            AddHandler c1grdDetalle.KeyDown, AddressOf c1grdDetalle_KeyDown
         Case ACUtilitarios.ACSetInstancia.Modificado
            AddHandler c1grdDetalle.KeyDown, AddressOf c1grdDetalle_KeyDown
         Case ACUtilitarios.ACSetInstancia.Guardar
         Case ACUtilitarios.ACSetInstancia.Deshacer
                tabMantenimiento.SelectedTab = tabBusqueda
                acpnlTitulo.Active = False
            If m_tinicio = TInicio.Busqueda Then
               acbtnSeleccionar.Visible = True
            Else
               acbtnSeleccionar.Visible = False
            End If
            actsbtnPrevisualizar.Visible = True
            acpnlTitulo.Active = False
         Case ACUtilitarios.ACSetInstancia.Previsualizar
            acTool.setInstancia(ACControles.ACToolBarMantHorizontalNew.TipoInstancia.Nuevo)
            acTool.ACBtnGrabarVisible = False
                'acTool.ACBtnRehusarVisible = True
            actsbtnPrevisualizar.Visible = False
            acTool.ACBtnImprimirVisible = True
         Case Else
            setInstancia(ACUtilitarios.ACSetInstancia.Deshacer)
      End Select

   End Sub
     ''' <summary>
   ''' Activar los controles segun los permisos o el rol que tiene el cliente
   ''' </summary>
   ''' <param name="x_opcion"></param>
   ''' <remarks></remarks>
   Private Sub setRol(ByVal x_opcion As Constantes.Seteo)
      Try
         'actxaProvCodigo.ReadOnly = IIf(x_opcion = Constantes.Seteo.Activar, False, True)
         'actxaProvCodigo.ACActivarAyuda = IIf(x_opcion = Constantes.Seteo.Activar, True, False)
         'actxaProvCodigo.ACAyuda.Enabled = IIf(x_opcion = Constantes.Seteo.Activar, True, False)
         actxaDescEncargado.ReadOnly = IIf(x_opcion = Constantes.Seteo.Activar, False, True)
         actxaDescEncargado.ACActivarAyuda = IIf(x_opcion = Constantes.Seteo.Activar, True, False)
         actxaDescEncargado.ACAyuda.Enabled = IIf(x_opcion = Constantes.Seteo.Activar, True, False)
         actxaCodEncargado.ReadOnly = IIf(x_opcion = Constantes.Seteo.Activar, False, True)
         actxaCodEncargado.ACAyuda.Enabled = IIf(x_opcion = Constantes.Seteo.Activar, True, False)
         actxaCodEncargado.ACActivarAyuda = IIf(x_opcion = Constantes.Seteo.Activar, True, False)
      Catch ex As Exception
         Throw ex
      End Try
   End Sub
      ''' <summary>
   ''' Dar instancia de activacion para la modificación de los registros
   ''' </summary>
   ''' <param name="x_opcion"></param>
   ''' <remarks></remarks>
   Private Sub setInstanciaModificar(ByVal x_opcion As Boolean)
      Try
  
         ACUtilitarios.ACSetControl(pnlItem, x_opcion, ACUtilitarios.TipoPropiedad.ACReadOnly)
         ACUtilitarios.ACSetControl(GroupBox1, x_opcion, ACUtilitarios.TipoPropiedad.ACReadOnly)
         'actxaProvCodigo.ACAyuda.Enabled = Not x_opcion
         'actxaProvCodigo.ACActivarAyuda = Not x_opcion
         actxaCodEncargado.ACAyuda.Enabled = Not x_opcion
         actxaCodEncargado.ACActivarAyuda = Not x_opcion
         actxaDescEncargado.ACAyuda.Enabled = Not x_opcion
         actxaDescEncargado.ACActivarAyuda = Not x_opcion
         actxaProdCodigo.ACActivarAyuda = Not x_opcion
         actxaProdCodigo.ACAyuda.Enabled = Not x_opcion
         'pnlCabHeader.Enabled = Not x_opcion
      Catch ex As Exception
         Throw ex
      End Try
   End Sub
    Private Sub formatearGrilla()
        Dim index As Integer = 1
        Try
            ACFrameworkC1.ACUtilitarios.ACFormatearGrilla(c1grdBusqueda, 1, 1, 9, 1, 0)
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Fecha", "PEDID_FechaDocumento", "PEDID_FechaDocumento", 150, True, False, "System.DateTime") : index += 1
            'ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Destino", "PVtaDestino", "PVtaDestino", 150, True, False, "System.String") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Codigo", "PEDID_Codigo", "PEDID_Codigo", 150, True, False, "System.String") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Solicitante", "PEDID_DescripcionEncargado", "PEDID_DescripcionEncargado", 150, True, False, "System.String") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Cotizacion", "COTCO_Codigo", "COTCO_Codigo", 150, True, False, "System.String") : index += 1
           ' ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Nro. Doc. Cli.", "ENTID_NroDocumento", "ENTID_NroDocumento", 150, True, False, "System.String") : index += 1
            'ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Cliente", "ENTID_Cliente", "ENTID_Cliente", 150, True, False, "System.String") : index += 1
            'ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Moneda", "TIPOS_TipoMoneda", "TIPOS_TipoMoneda", 150, True, False, "System.String") : index += 1
            'ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Condición", "TIPOS_CondicionPago", "TIPOS_CondicionPago", 150, True, False, "System.String") : index += 1
            
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Observaciones", "PEDID_Observaciones", "PEDID_Observaciones", 150, True, False, "System.String") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Peso Total", "PEDID_TotalPeso", "PEDID_TotalPeso", 110, True, False, "System.Decimal", Parametros.GetParametro(EParametros.TipoParametros.pg_FMondo2d)) : index += 1
            'ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Vendedor", "ENTID_Vendedor", "ENTID_Vendedor", 150, True, False, "System.String") : index += 1
            'ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Facturar", "PEDID_ParaFacturar", "PEDID_ParaFacturar", 150, True, False, "System.Boolean") : index += 1
           ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Estado", "PEDID_Estado_Text", "PEDID_Estado_Text", 150, True, False, "System.String") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Estado", "PEDID_Estado", "PEDID_Estado", 150, False, False, "System.String") : index += 1
           ' ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Rel.", "PEDID_CodRelacionado", "PEDID_CodRelacionado", 150, False, False, "System.String") : index += 1

            c1grdBusqueda.AllowEditing = False
            c1grdBusqueda.Styles.Alternate.BackColor = Color.LightGray
            c1grdBusqueda.Styles.Fixed.TextAlign = TextAlignEnum.CenterCenter
            c1grdBusqueda.Styles.Highlight.BackColor = Color.Gray
            c1grdBusqueda.SelectionMode = SelectionModeEnum.Row
            c1grdBusqueda.AllowSorting = AllowSortingEnum.SingleColumn

            Dim t As C1.Win.C1FlexGrid.CellStyle = c1grdBusqueda.Styles.Add("Atendido")
            t.BackColor = Color.Green
            t.ForeColor = Color.White
            t.Font = New Font(c1grdBusqueda.Font, FontStyle.Regular)

            Dim d As C1.Win.C1FlexGrid.CellStyle = c1grdBusqueda.Styles.Add("Anulado")
            d.BackColor = Color.Red
            d.ForeColor = Color.White
            d.Font = New Font(c1grdBusqueda.Font, FontStyle.Bold)
            c1grdBusqueda.DrawMode = C1.Win.C1FlexGrid.DrawModeEnum.OwnerDraw

            index = 1
            ACFrameworkC1.ACUtilitarios.ACFormatearGrilla(c1grdDetalle, 1, 1, 7, 1, 0)
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdDetalle, index, "Codigo", "ARTIC_Codigo", "ARTIC_Codigo", 110, True, False, "System.String") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdDetalle, index, "Descripción", "ARTIC_Descripcion", "ARTIC_Descripcion", 160, True, False, "System.String") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdDetalle, index, "Unidad", "TIPOS_UnidadMedida", "TIPOS_UnidadMedida", 160, True, False, "System.String") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdDetalle, index, "Peso", "PDDET_PesoUnitario", "PDDET_PesoUnitario", 110, True, False, "System.Decimal", Parametros.GetParametro(EParametros.TipoParametros.pg_FMondo2d)) : index += 1
            'ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdDetalle, index, "Promedio", "PEDID_PromedioVentas", "PEDID_PromedioVentas", 110, True, False, "System.Decimal", Parametros.GetParametro(EParametros.TipoParametros.pg_FMondo2d)) : index += 1
           ' ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdDetalle, index, "S. Principal", "PDDET_StockPrincipal", "PDDET_StockPrincipal", 110, True, False, "System.Decimal", Parametros.GetParametro(EParametros.TipoParametros.pg_FMondo2d)) : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdDetalle, index, "S. Local", "PDDET_StockLocal", "PDDET_StockLocal", 110, True, False, "System.Decimal", Parametros.GetParametro(EParametros.TipoParametros.pg_FMondo2d)) : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdDetalle, index, "Cantidad", "PDDET_Cantidad", "PDDET_Cantidad", 110, True, False, "System.Decimal", Parametros.GetParametro(EParametros.TipoParametros.pg_FMondo2d)) : index += 1
          '  ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdDetalle, index, "Diferencia", "PDDET_PRFaltante", "PDDET_PRFaltante", 110, True, False, "System.Decimal", Parametros.GetParametro(EParametros.TipoParametros.pg_FMondo2d)) : index += 1
            c1grdDetalle.AllowEditing = False
            c1grdDetalle.AutoResize = True
            c1grdDetalle.Cols(0).Width = 18
            c1grdDetalle.Styles.Alternate.BackColor = Color.LightGray
            c1grdDetalle.Styles.Fixed.TextAlign = TextAlignEnum.CenterCenter
            c1grdDetalle.Styles.Highlight.BackColor = Color.Gray
            c1grdDetalle.SelectionMode = SelectionModeEnum.Row
            c1grdDetalle.AllowResizing = AllowResizingEnum.Columns

        Catch ex As Exception
            ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Text), "No se puede dar formato a la grilla", ex)
        End Try
    End Sub
    
 Private Sub nuevoPedido()
      Try
          '' Inicializar clase Pedido
         m_eabas_pedidoscompra = New EABAS_PedidosCompra
         m_eabas_pedidoscompra.Instanciar(ACEInstancia.Nuevo)
         '' Instanciar clase
             AsignarBinding()
         setInstancia(ACUtilitarios.ACSetInstancia.Nuevo)
         cargarEncargado(GApp.EUsuario.USER_DNI)
         '' Para Cargar detalle del producto
            bs_detPedido = New BindingSource
          m_eabas_pedidoscompra.ListDetPedidosCompra = New List(Of EABAS_PedidosCompraDetalle)
         bs_detPedido.DataSource = m_eabas_pedidoscompra.ListDetPedidosCompra
         c1grdDetalle.DataSource = bs_detPedido
         bnavProductos.BindingSource = bs_detPedido

         tabMantenimiento.SelectedTab = tabDatos
         dtpFecha.Focus()
         txtSerie.Text = GApp.Almacen.ToString("000")
         txtSerie.ReadOnly = True
         Dim _where As New Hashtable
         _where.Add("SUCUR_Id", New ACWhere(GApp.Sucursal))
         _where.Add("PEDID_Tipo", New ACWhere(EABAS_PedidosCompra.TipoPedido.PC.ToString().Substring(1, 1)))
         Dim m_cotizacion As New BABAS_PedidosCompra
         Dim x_corre As Integer = m_cotizacion.getCorrelativo("PEDID_Numero", _where)
         actxnNumero.Text = x_corre
         actxnNumero.ReadOnly = True
 

         
      Catch ex As Exception
         Throw ex
      End Try
   End Sub
Private Sub cargarEncargado(ByVal x_entid_codigo As String)
      Try
         If managerEntidades.Cargar(x_entid_codigo, EEntidades.TipoInicializacion.Direcciones) Then
            actxaDescEncargado.Text = managerEntidades.Entidades.ENTID_RazonSocial
            actxaCodEncargado.Text=managerEntidades.Entidades.ENTID_Codigo
            
         End If
      Catch ex As Exception
         Throw ex
      End Try
   End Sub

   Private Sub setProducto(ByVal x_opcion As Boolean)
      Try
         If x_opcion Then
            actxaProdCodigo.Text = m_earticulos.ARTIC_Codigo
            txtProdDescripcion.Text = m_earticulos.ARTIC_Descripcion
            txtUnidad.Text = m_earticulos.TIPOS_UnidadMedida
            actxnPeso.Text = m_earticulos.ARTIC_Peso
           
            actxnStockLocal.ACClear()
            actxnStockLocal.Text = m_earticulos.StockLocal

            'For Each item As ACELogistica.ELOG_Stocks In m_earticulos.ListLOG_Stocks
            '   If item.ALMAC_Id = CType(cmbPuntoVenta.SelectedItem, EPuntoVenta).ALMAC_Id Then
            '      actxnStockPrincipal.Text = item.STOCK_Cantidad
            '   End If
            'Next
           ' actxncantidad.Focus()
                actxnStockLocal.Focus()
         Else
            actxaProdCodigo.Clear()
            txtProdDescripcion.Clear()
            txtUnidad.Clear()
            actxnPeso.ACClear()
           
            actxnStockLocal.ACClear()

            actxnCantidad.Text = "0.00"
            'actxnPromedio.Text = "0.00"
            m_earticulos = Nothing
         End If
      Catch ex As Exception
         Throw ex
      End Try
   End Sub

   Private Sub calcular(Optional ByVal x_moneda As Boolean = False)
     Try
         If Not IsNothing(m_eabas_pedidoscompra) Then
            If Not IsNothing(m_eabas_pedidoscompra.ListDetPedidosCompra) Then
               If m_eabas_pedidoscompra.ListDetPedidosCompra.Count > 0 Then
                 
                  Dim _pesoTotal As Double = 0
                 
                  Dim _cantidad As Double = 0
                    For Each Item As EABAS_PedidosCompraDetalle In m_eabas_pedidoscompra.ListDetPedidosCompra
                         _pesoTotal += Item.PDDET_PesoUnitario * Item.PDDET_Cantidad
                              Next

                  actxnPesoTotal.Text = _pesoTotal : actxnPesoTotal.Formatear()
               End If
                    End If
                End If
      Catch ex As Exception
         Throw ex
      End Try
   End Sub

   Private Function addDetallePedido() As Boolean
      Try
         If Not IsNothing(m_earticulos) Then
            For Each item As EABAS_PedidosCompraDetalle In m_eabas_pedidoscompra.ListDetPedidosCompra
               If item.ARTIC_Codigo = m_earticulos.ARTIC_Codigo Then
                  Throw New Exception(String.Format("No puede ingresar el mismo producto {0}, modifique el existente", item.ARTIC_Descripcion))
               End If
            Next
            Dim _detPedido As New EABAS_PedidosCompraDetalle
            _detPedido.Articulo = m_earticulos
            _detPedido.ARTIC_Codigo = m_earticulos.ARTIC_Codigo
            _detPedido.PDDET_Cantidad = actxnCantidad.Text
            _detPedido.PDDET_PesoUnitario = m_earticulos.ARTIC_Peso
            _detPedido.TIPOS_UnidadMedida = txtUnidad.Text
          
            _detPedido.ARTIC_Codigo = m_earticulos.ARTIC_Codigo
            _detPedido.ARTIC_Descripcion = m_earticulos.ARTIC_Descripcion
            _detPedido.PDDET_StockLocal = actxnStockLocal.Text
            
           
            _detPedido.ALMAC_Id = GApp.Almacen
            If _detPedido.PDDET_Cantidad > 0 Then
            
                 m_eabas_pedidoscompra.ListDetPedidosCompra.Add(_detPedido)
               bs_detPedido.ResetBindings(False)
               calcular()
               Return True
            Else
               ACControles.ACDialogos.ACMostrarMensajeInformacion(String.Format("Información: {0}", Me.Text), "No se puede agregar el producto, por la Cantida/Precio es incorrecto, corrija y vuelva a intentarlo ")
               If _detPedido.PDDET_Cantidad = 0 Then
                  actxnCantidad.Focus()
               End If
               Return False
            End If
         End If
      Catch ex As Exception
         Throw ex
      End Try
   End Function

   Private Function validar(ByRef m_msg As String) As Boolean
      Try
         '' Validar al Cliente
         Dim _msg As String = ""
         '' Validar Detalle
         ValidarDetalle(m_msg)
         '' Verificar si hay pedidos
         If Not m_eabas_pedidoscompra.ListDetPedidosCompra.Count > 0 Then
            m_msg &= String.Format("- No se ha ingresado ningun articulo{0}", vbNewLine)
         End If


          Dim x_correlativo As String= String.Format("{0}{1:000}{2:0000000}", EABAS_PedidosCompra.TipoPedido.PC.ToString(), GApp.Almacen, Convert.ToInt32(actxnNumero.Text))
         Dim _pedidocompra As New BABAS_PedidosCompra
            If _pedidocompra.Cargar(x_correlativo) then'(managerGenerarPedidoCompra.ABAS_PedidosCompra.PEDID_Codigo) Then
            If _pedidocompra.ABAS_PedidosCompra.PEDID_Estado.Equals(Constantes.getEstado(Constantes.Estado.Confirmado)) Then
               m_msg &= String.Format("- No se puede grabar este pedido, por que ya fue confirmado en el punto de venta solicitado{0}", vbNewLine)
            End If
         End If

         Return Not (m_msg.Length > 0)
      Catch ex As Exception
         Throw ex
      End Try
   End Function

   Private Function ValidarDetalle(ByRef m_msg As String) As Boolean
      Try
         bs_detPedido.ResetBindings(False)
         '' Valida que la cantidad y el precio es superior a 0
         For Each Item As EABAS_PedidosCompraDetalle In m_eabas_pedidoscompra.ListDetPedidosCompra
            If Not Item.PDDET_Cantidad > 0 Then
               m_msg &= String.Format("- El Producto {0} tiene como cantidad {1}, no es aceptable.{2}", Item.Articulo.ARTIC_Descripcion, Item.PDDET_Cantidad, vbNewLine)
            End If
            If Not IsNothing(Item.Articulo) Then
               '' Validar que no se hayan ingresado cantidades decimales para las unidades que no lo permiten
               Dim _filter As New ACFiltrador(Of ETipos)

               m_earticulos = Item.Articulo
               _filter.ACFiltro = String.Format("TIPOS_Codigo={0}", m_earticulos.TIPOS_CodUnidadMedida)
               If Not _filter.ACFiltrar(Colecciones.TiposUniMedDecimal).Count > 0 Then
                  If (Item.PDDET_Cantidad - Math.Truncate(Item.PDDET_Cantidad)) > 0 Then
                     m_msg &= String.Format("- El Producto: {0}, no permite que se ingresen cantidades decimales{1}", Item.ARTIC_Descripcion, vbNewLine)
                  End If
               End If
            End If
         Next

         Return Not (m_msg.Length > 0)
      Catch ex As Exception
         Throw ex
      End Try
   End Function

   Private Function grabarPedido(ByRef m_msg As String) As Boolean
      Try

         If validar(m_msg) Then
            If ACControles.ACDialogos.ACMostrarMensajePregunta(String.Format("Grabar Pedido de Compra: {0}", Me.Text) _
             , "Desea grabar el Pedido de Compra?" _
             , ACControles.ACDialogos.LabelBotom.Si_No) = DialogResult.Yes Then

                     If m_eabas_pedidoscompra.Nuevo Then
                  '' Obtener datos
                  m_eabas_pedidoscompra.ZONAS_Codigo = GApp.Zona
                  m_eabas_pedidoscompra.SUCUR_Id = GApp.Sucursal
                  m_eabas_pedidoscompra.ALMAC_Id = GApp.Almacen
                        m_eabas_pedidoscompra.ENTID_CodigoEncargado=actxaCodEncargado.Text
                        m_eabas_pedidoscompra.PEDID_DescripcionEncargado=actxaDescEncargado.Text
                           m_eabas_pedidoscompra.PEDID_Tipo=EABAS_PedidosCompra.TipoPedido.PC.ToString().Substring(1, 1)
                  '' Obtener el correlativo y asignarlo
                                    Dim _where As New Hashtable
                  _where.Add("SUCUR_Id", New ACWhere(GApp.Sucursal))
                  _where.Add("PEDID_Tipo", New ACWhere(EABAS_PedidosCompra.TipoPedido.PC.ToString().Substring(1, 1)))
                  Dim m_pedidocompra As New BABAS_PedidosCompra
                  Dim x_corre As Integer = m_pedidocompra.getCorrelativo("PEDID_Numero", _where)
                  m_eabas_pedidoscompra.PEDID_Codigo = String.Format("{0}{1:000}{2:0000000}", EABAS_PedidosCompra.TipoPedido.PC.ToString(), GApp.Almacen, x_corre)
                m_eabas_pedidoscompra.PEDID_Numero = x_corre
               
                  '' Definir el Estado
                  m_eabas_pedidoscompra.PEDID_Estado = EABAS_PedidosCompra.getEstado(EABAS_PedidosCompra.Estado.Ingresado)
                  '' Asignar la clase pedido a la capa de negocio 
               End If
              managerGenerarPedidoCompra.ABAS_PedidosCompra = m_eabas_pedidoscompra
               '' Grabar el pedido
               If managerGenerarPedidoCompra.GrabarPedidoCompra(GApp.Usuario,  m_msg) Then
                  Return True
               Else
                  ACControles.ACDialogos.ACMostrarMensajeInformacion(String.Format("Información: {0}", Me.Text), "No se puede grabar, revise los detalles:", m_msg)
               End If
            End If
         End If
         Return False
      Catch ex As Exception
         Throw ex
      End Try
                  
              
            
   End Function

   Private Function busqueda(ByVal x_cadena As String) As Boolean
      Try
         '  If managerABAS_PedidosCompra.BusquedaPedidoCompra(x_cadena, getCampo(), chkCTodos.Checked,  AcFecha.AcFecha_De.Value.Date, AcFecha.ACFecha_A.Value.Date, GApp.Zona, GApp.Sucursal) Then

           'If txtBusqueda.ACEstadoAutoAyuda Then
        ' chkAgrupar.Checked = False
         If managerABAS_PedidosCompra.BusquedaPedidoCompra(x_cadena, getCampo(), chkCTodos.Checked,  AcFecha.AcFecha_De.Value.Date, AcFecha.ACFecha_A.Value.Date, GApp.Zona, GApp.Sucursal) Then
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

   Private Sub cargarDatos()
     Try
         bs_pedidos= New BindingSource()
         bs_pedidos.DataSource = managerABAS_PedidosCompra.ListABAS_PedidosCompra

         c1grdBusqueda.DataSource = bs_pedidos
         bnavBusqueda.BindingSource = bs_pedidos
         AddHandler bs_pedidos.CurrentChanged, AddressOf bs_pedidos_CurrentChanged
         bs_pedidos_CurrentChanged(Nothing, Nothing)
      Catch ex As Exception
         Throw ex
      End Try
   End Sub

   Private Function getCampo() As Short
      Try
         Return 0
      Catch ex As Exception
         Throw ex
      End Try
   End Function
      ''' <summary>
   ''' Realiza el enlace de los controles visuales con la clase esquema
   ''' </summary>
   Private Sub AsignarBinding()
      Try
         m_listBindHelper = New List(Of ACBindHelper)()
        ' m_listBindHelper.Add(ACBindHelper.ACBind(txtSerie, "Text", m_eabas_pedidoscompra, GApp.Almacen.ToString("000")))'"COTCO_Codigo"))
            m_listBindHelper.Add(ACBindHelper.ACBind(actxnNumero, "Text", m_eabas_pedidoscompra, "PEDID_Numero"))
         If m_eabas_pedidoscompra.PEDID_FechaDocumento.Year < 1700 Then m_eabas_pedidoscompra.PEDID_FechaDocumento = DateTime.Now
         m_listBindHelper.Add(ACBindHelper.ACBind(dtpFecha, "Value", m_eabas_pedidoscompra, "PEDID_FechaDocumento"))
   

         ''PEDID_SubTotal
            m_listBindHelper.Add(ACBindHelper.ACBind(actxnPesoTotal, "Text", m_eabas_pedidoscompra, "PEDID_TotalPeso"))
              m_listBindHelper.Add(ACBindHelper.ACBind(txtObservacion, "Text",m_eabas_pedidoscompra, "PEDID_Observaciones"))
      Catch ex As Exception
         Throw ex
      End Try
   End Sub

   Private Sub subirItem()
      Try
         If IsNothing(CType(bs_detPedido.Current, EABAS_PedidosCompraDetalle).Articulo) Then
            '' Cargar Producto
            actxaProdCodigo.Text = CType(bs_detPedido.Current, EABAS_PedidosCompraDetalle).ARTIC_Codigo
            txtProdDescripcion.Text = CType(bs_detPedido.Current, EABAS_PedidosCompraDetalle).ARTIC_Descripcion
            actxnCantidad.Text = CType(bs_detPedido.Current, EABAS_PedidosCompraDetalle).PDDET_Cantidad
            '' Cargar Precios
            m_earticulos = New EArticulos()
            Label14.Focus()
         Else
            m_earticulos = CType(bs_detPedido.Current, EABAS_PedidosCompraDetalle).Articulo
            setProducto(True)
            actxnCantidad.Text = CType(bs_detPedido.Current, EABAS_PedidosCompraDetalle).PDDET_Cantidad
         End If
      Catch ex As Exception
         Throw ex
      End Try
   End Sub



#Region " Metodos de Controles"
  
   Private Sub bs_pedidos_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
      Try
        If Not IsNothing(bs_pedidos.Current) Then
            Select Case CType(bs_pedidos.Current, EABAS_PedidosCompra).PEDID_Estado
               Case EABAS_PedidosCompra.getEstado(EVENT_Pedidos.Estado.Confirmado), _
                    EABAS_PedidosCompra.getEstado(EVENT_Pedidos.Estado.Anulado)
                  acTool.ACBtnModificarEnabled = False
                  acTool.ACBtnAnularEnabled = False
               Case Else
                  acTool.ACBtnModificarEnabled = True
                        acTool.ACBtnModificarVisible=True
                  acTool.ACBtnAnularEnabled = True
            End Select
            acTool.ACBtnModificarVisible = False
         End If
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso Cargar Propiedades del Cotización/Pedido", ex)
      End Try
   End Sub

   Private Sub actxaProdCodigo_ACAyudaClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles actxaProdCodigo.ACAyudaClick
      Try
         If IsNothing(frmCons) Then
            frmCons = New CProductos(CProductos.Origen.Pedidos) With {.StartPosition = FormStartPosition.CenterScreen}
         End If
         Me.KeyPreview = False
         If frmCons.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            m_earticulos = frmCons.Articulo
         
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
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso cargar productos", ex)
      End Try
   End Sub

   Private Sub txtOpcion_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtOpcion.KeyPress
      Try
         Select Case e.KeyChar
            Case "+"c
               If m_modArticulo Then
                  e.Handled = True
                  CType(bs_detPedido.Current, EABAS_PedidosCompraDetalle).PDDET_Cantidad = actxnCantidad.Text
                  CType(bs_detPedido.Current, EABAS_PedidosCompraDetalle).ARTIC_Codigo = actxaProdCodigo.Text
                  CType(bs_detPedido.Current, EABAS_PedidosCompraDetalle).ARTIC_Descripcion = txtProdDescripcion.Text

                  setProducto(False)
                  calcular()
                  c1grdDetalle.Enabled = True
                  Me.KeyPreview = False
                  m_modArticulo = False
               Else
                  e.Handled = True
                  If addDetallePedido() Then
                     actxaProdCodigo.Focus()
                     txtOpcion.Text = ""
                     txtOpcion.SelectAll()
                     setProducto(False)
                  End If
               End If
            Case "-"c
               e.Handled = True
            Case Else
                    'e.Handled = True
                    If m_modArticulo Then
                        e.Handled = True
                        CType(bs_detPedido.Current, EABAS_PedidosCompraDetalle).PDDET_Cantidad = actxnCantidad.Text
                        CType(bs_detPedido.Current, EABAS_PedidosCompraDetalle).ARTIC_Codigo = actxaProdCodigo.Text
                        CType(bs_detPedido.Current, EABAS_PedidosCompraDetalle).ARTIC_Descripcion = txtProdDescripcion.Text

                        setProducto(False)
                        calcular()
                        c1grdDetalle.Enabled = True
                        Me.KeyPreview = False
                        m_modArticulo = False
                    Else
                        e.Handled = True

                    End If
         End Select
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso opciones", ex)
      End Try
   End Sub

   Private Sub txtOpcion_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtOpcion.KeyDown
      Try
         Select Case e.KeyData
            Case Keys.Enter
                    If m_modArticulo Then

                    Else

                        addDetallePedido()
                        setProducto(False)
                        Me.KeyPreview = True
                        m_modArticulo = False
                    End If
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

   Private Sub _KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
      If e.KeyCode = Keys.Enter Then
         If sender.Name = "txtBusqueda" Then
            Exit Sub
         End If
         If TypeOf ActiveControl Is ACControles.ACTextBoxAyuda And ActiveControl.Name = "actxaProdCodigo" Then
            Exit Sub
         End If
         SendKeys.Send("{TAB}")
      End If
   End Sub

   Private Sub acTool_ACBtnAnular_Click(sender As Object, e As EventArgs) Handles acTool.ACBtnAnular_Click
      Try
         If ACControles.ACDialogos.ACMostrarMensajePregunta(String.Format("Anular Registro: {0}", Me.Text) _
             , String.Format("Desea anular el Pedido Nro: {0}", CType(bs_pedidos.Current, EABAS_PedidosCompra).PEDID_Codigo) _
             , ACControles.ACDialogos.LabelBotom.Si_No) = DialogResult.Yes Then
            If managerGenerarPedidoCompra.AnularPedidoReposicion(CType(bs_pedidos.Current, EABAS_PedidosCompra).PEDID_Codigo, GApp.Usuario) Then
               ACControles.ACDialogos.ACMostrarMensajeSatisfactorio(String.Format("Información: {0}", Me.Text), "Anulado satisfactoriamente")
               acTool_ACBtnCancelar_Click(Nothing, Nothing)
               btnCConsulta_Click(Nothing, Nothing)
               acTool.setInstancia(ACControles.ACToolBarMantHorizontalNew.TipoInstancia.Cancelar)
            Else
               ACControles.ACDialogos.ACMostrarMensajeInformacion(String.Format("Información: {0}", Me.Text), "No se puede anular el documento")
            End If
         End If
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso Anular Cotización Pedido", ex)
      End Try
   End Sub

   Private Sub acTool_ACBtnCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles acTool.ACBtnCancelar_Click
      Try
         setInstancia(ACUtilitarios.ACSetInstancia.Deshacer)
         btnCConsulta_Click(Nothing, Nothing)
      Catch ex As Exception
         acTool.setInstancia(ACControles.ACToolBarMantHorizontalNew.TipoInstancia.Volver)
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), String.Format(Colecciones.getError("00101"), "Cancelar Operacion"), ex)
      End Try
   End Sub

   Private Sub acTool_ACBtnGrabar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles acTool.ACBtnGrabar_Click
      Dim m_msg As String = ""
      Try
         acTool.setInstancia(ACControles.ACToolBarMantHorizontalNew.TipoInstancia.Cancelar)
         acTool.ACBtnImprimirVisible = False
         acTool.ACBtnAnularVisible = False
         actsbtnPrevisualizar.Visible = False

         If grabarPedido(m_msg) Then
            '' Manejar las opciones de la barra de herramientas
            tabMantenimiento.SelectedTab = tabBusqueda
            ACControles.ACDialogos.ACMostrarMensajeSatisfactorio(String.Format("Información: {0}", Me.Text), String.Format("Documento {0}, fue grabado Satisfactoriamente con el Codigo: {1}", _
                                                                                                                           "Pedido de Resposición", _
                                                                                                                           managerGenerarPedidoCompra.ABAS_PedidosCompra.PEDID_Codigo))
            Me.KeyPreview = True
            actsbtnPrevisualizar.Visible = False
            txtBusqueda_ACAyudaClick(Nothing, Nothing)
            setInstancia(ACUtilitarios.ACSetInstancia.Deshacer)
         Else
            acTool.setInstancia(ACControles.ACToolBarMantHorizontalNew.TipoInstancia.Nuevo)
            If m_msg.Length > 0 Then ACControles.ACDialogos.ACMostrarMensajeInformacion(String.Format("Información: {0}", Me.Text), "No se puede grabar, revise los detalles:", m_msg)
         End If
      Catch ex As Exception
         acTool.setInstancia(ACControles.ACToolBarMantHorizontalNew.TipoInstancia.Nuevo)
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), String.Format(Colecciones.getError("00101"), "Grabar Registro"), ex)
      End Try
   End Sub

   'Private Sub acTool_ACBtnImprimir_Click(sender As Object, e As EventArgs) Handles acTool.ACBtnImprimir_Click
   '   Try
   '      Dim _imprimir As New TImprimir(managerGenerarPedidoCompra.ABAS_PedidosCompra.PEDID_Codigo, TImprimir.TImpresion.PedidoReposicion) With {.WindowState = FormWindowState.Normal, .StartPosition = FormStartPosition.CenterScreen}
   '      _imprimir.ShowDialog()
   '   Catch ex As Exception
   '      acTool.setInstancia(ACControles.ACToolBarMantHorizontalNew.TipoInstancia.Nuevo)
   '      ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), String.Format(Colecciones.getError("00101"), "Grabar Registro"), ex)
   '   End Try
   'End Sub

   Private Sub acTool_ACBtnModificar_Click(sender As Object, e As EventArgs) Handles acTool.ACBtnModificar_Click
      Try
            
         If ACControles.ACDialogos.ACMostrarMensajePregunta(String.Format("Modificar Registro: {0}", Me.Text) _
             , "¿Desea modificar el pedido de compra?" _
             , ACControles.ACDialogos.LabelBotom.Si_No) = DialogResult.Yes Then
            setInstancia(ACUtilitarios.ACSetInstancia.Modificado)
            setInstanciaModificar(False) : setRol(Constantes.Seteo.Desactivar)

            ''cotización debe permitir modificar los datos, cuando se encuentre en estado "I"
            If m_eabas_pedidoscompra.PEDID_Estado() = EABAS_PedidosCompra.getEstado(EABAS_PedidosCompra.Estado.Ingresado) Then
               '' Los items son eliminados para ser ingresados de nuevo
               'c1grdDetalle.Clear()
               'c1grdDetalle.RemoveItem()
            End If

            c1grdDetalle.AllowEditing = True

            actxaProdCodigo.Focus()
            acTool.ACBtnImprimirVisible = False : acTool.ACBtnAnularVisible = False : acTool.ACBtnBuscarVisible = False
         End If
     
      Catch ex As Exception
         acTool.setInstancia(ACControles.ACToolBarMantHorizontalNew.TipoInstancia.Cancelar)
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso Modificar", ex)
      End Try
   End Sub

   Private Sub acTool_ACBtnNuevo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles acTool.ACBtnNuevo_Click
      Try
       
            nuevoPedido()
               frmCons = New CProductos(CProductos.Origen.Cotizaciones) With {.StartPosition = FormStartPosition.CenterScreen}
           '' Activar las opciones generales del teclado
            KeyPreview = True

            '' Campos Obligatorios
            actxaProdCodigo.Focus()
           
           ' m_eabas_cotizacionescompra = estado.Nuevo
            Me.KeyPreview = True
           
          '  pnlPedSeparacion.Visible = False
  
        Catch ex As Exception
            acTool.setInstancia(ACControles.ACToolBarMantHorizontalNew.TipoInstancia.Cancelar)
            ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso Nueva Cotización/Pedido", ex)
        End Try
   End Sub

   Private Sub acTool_ACBtnSalir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles acTool.ACBtnSalir_Click
      Me.Close()
   End Sub

   Private Sub txtBusqueda_ACAyudaClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
      Try
         busqueda("")
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Convert.ToString(Text)), "No se puede cargar la Busqueda", ex)
      End Try
   End Sub

   Private Sub btnCConsulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCConsulta.Click
      Try
         txtBusqueda_ACAyudaClick(Nothing, Nothing)
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Text), "No se puede realizar la consulta", ex)
      End Try
   End Sub

   Private Sub c1grdBusqueda_OwnerDrawCell(ByVal sender As System.Object, ByVal e As C1.Win.C1FlexGrid.OwnerDrawCellEventArgs) Handles c1grdBusqueda.OwnerDrawCell
      Try
         If e.Row < c1grdBusqueda.Rows.Fixed OrElse e.Col < c1grdBusqueda.Cols.Fixed Then Return
         If c1grdBusqueda.Cols(e.Col).Name = "PEDID_FechaDocumento" Or c1grdBusqueda.Cols(e.Col).Name = "PEDID_Codigo" Or c1grdBusqueda.Cols(e.Col).Name = "TIPOS_TipoDocumento" _
            Or c1grdBusqueda.Cols(e.Col).Name = "PEDID_Numero" Then
            If c1grdBusqueda.Rows(e.Row)("PEDID_Estado") = EABAS_PedidosCompra.getEstado(EABAS_PedidosCompra.Estado.Confirmado) Then
               e.Style = c1grdBusqueda.Styles("Atendido")
            End If
         End If

         If c1grdBusqueda.Rows(e.Row)("PEDID_Estado") = EABAS_PedidosCompra.getEstado(EABAS_PedidosCompra.Estado.Anulado) Then
            e.Style = c1grdBusqueda.Styles("Anulado")
         End If
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso cambia de color", ex)
      End Try
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
                                                                , String.Format("Desea quitar el Articulo : {0} ", CType(bs_detPedido.Current, EABAS_PedidosCompraDetalle).ARTIC_Descripcion) _
                                                                , ACControles.ACDialogos.LabelBotom.Si_No) = DialogResult.Yes Then
                  Dim m_det As EABAS_PedidosCompraDetalle = CType(bs_detPedido.Current, EABAS_PedidosCompraDetalle)
                  managerGenerarPedidoCompra.ABAS_PedidosCompra.ListDetPedidosCompra.Remove(m_det)
                  bs_detPedido.ResetBindings(False)
                  calcular()
               End If
            Case Else
               e.Handled = False
         End Select
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Text), "No se puede calcular carga el Item", ex)
      End Try
   End Sub



   Private Sub acbtnSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles acbtnSeleccionar.Click
      
         Try
         If Not IsNothing(bs_pedidos) Then
            If Not IsNothing(bs_pedidos.Current) Then
               m_eabas_pedidoscompra = CType(bs_pedidos.Current, EABAS_PedidosCompra)
               Me.DialogResult = System.Windows.Forms.DialogResult.OK
               Me.Close()
            Else
               ACControles.ACDialogos.ACMostrarMensajeInformacion(String.Format("Información: {0}", Me.Text), "No se puede continuar por que no ha seleccionado ninguna cotización de compra")
            End If
         Else
            ACControles.ACDialogos.ACMostrarMensajeInformacion(String.Format("Información: {0}", Me.Text), "No se puede continuar por que no ha seleccionado ninguna cotización de compra")
         End If
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso seleccionar Cotizacion", ex)
      End Try
      
   End Sub

   Private Sub actsbtnPrevisualizar_Click(sender As Object, e As EventArgs) Handles actsbtnPrevisualizar.Click
      Try
            If Not IsNothing(bs_pedidos) Then
            If Not IsNothing(bs_pedidos.Current) Then
               '' Codigo
               Dim x_codigo As String = CType(bs_pedidos.Current, EABAS_PedidosCompra).PEDID_Codigo
               '' Cargar Cotizacion
               If managerGenerarPedidoCompra.Cargar(x_codigo, True) Then
                  setInstancia(ACUtilitarios.ACSetInstancia.Nuevo)
                  m_eabas_pedidoscompra = managerGenerarPedidoCompra.ABAS_PedidosCompra
                  AsignarBinding()
                  '' Cargar listado de Productos
                  bs_detPedido = New BindingSource
                  bs_detPedido.DataSource = m_eabas_pedidoscompra.ListDetPedidosCompra
                  c1grdDetalle.DataSource = bs_detPedido
                  bnavProductos.BindingSource = bs_detPedido
                  tabMantenimiento.SelectedTab = tabDatos
                      txtSerie.Text =  GApp.Almacen.ToString("000")
            txtSerie.ReadOnly = True       

                         '' Cargar datos del encargado
                  If managerEntidades.Cargar(m_eabas_pedidoscompra.ENTID_CodigoEncargado) Then
                     'actxaProvCodigo.Text = m_eabas_cotizacionescompra.ENTID_CodigoProveedor
                     actxaCodEncargado.Text = m_eabas_pedidoscompra.ENTID_CodigoEncargado
                     actxaDescEncargado.Text = managerEntidades.Entidades.ENTID_RazonSocial
                  End If
                         '' Setear Valores
         'acTool_ACBtnModificar_Click(Nothing, Nothing)
             setInstancia(ACUtilitarios.ACSetInstancia.Previsualizar)
         acTool.ACBtnCancelarVisible = True
         acTool.ACBtnAnularVisible = True
         If CType(bs_pedidos.Current, EABAS_PedidosCompra).PEDID_Estado = EABAS_PedidosCompra.getEstado(EABAS_PedidosCompra.Estado.Confirmado) Then
            acTool.ACBtnAnularEnabled = False
            acTool.ACBtnImprimirEnabled = True
            chkAtendida.Checked = True
            acpnlTitulo.Active = False
         ElseIf CType(bs_pedidos.Current, EABAS_PedidosCompra).PEDID_Estado = EABAS_PedidosCompra.getEstado(EABAS_PedidosCompra.Estado.Anulado) Then
            acTool.ACBtnAnularEnabled = False
            acTool.ACBtnImprimirEnabled = False
            chkAnulada.Checked = True
            acpnlTitulo.Active = True
         Else
            acTool.ACBtnAnularEnabled = True
            acTool.ACBtnImprimirEnabled = True
            acTool.ACBtnImprimirVisible = True
            chkAnulada.Checked = False
                 acTool.ACBtnModificarVisible=true
                             acTool.ACBtnModificarEnabled = true
                           
         End If


       End If
            Else
               ACControles.ACDialogos.ACMostrarMensajeInformacion(String.Format("Información: {0}", Me.Text), "No se puede Cargar documento por que no se ha cargado ninguno")
            End If
         Else
            ACControles.ACDialogos.ACMostrarMensajeInformacion(String.Format("Información: {0}", Me.Text), "No se puede documento por que no se ha cargado ninguno ")
         End If
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso Previsualizar", ex)
      End Try
        End Sub
#End Region

    Private Sub tabMantenimiento_SelectionChanged(sender As Crownwood.DotNetMagic.Controls.TabControl, oldPage As Crownwood.DotNetMagic.Controls.TabPage, newPage As Crownwood.DotNetMagic.Controls.TabPage) Handles tabMantenimiento.SelectionChanged

    End Sub

'Private Sub tscmbImpresora_DropDown_1( sender As Object,  e As EventArgs) 
'         Try
'            If IsNothing(Colecciones.ListPrinter) Then
'                Colecciones.CargarImpresoras()
'            End If
'            ACFramework.ACUtilitarios.ACCargaCombo(tscmbImpresora.ComboBox, Colecciones.ListPrinter, "DeviceName", "DeviceName")
'        Catch ex As Exception

'        End Try
'End Sub


Private Sub actxaProdCodigo_TextChanged( sender As Object,  e As EventArgs) Handles actxaProdCodigo.TextChanged

End Sub

Private Sub tsbtnExcel_Click( sender As Object,  e As EventArgs) Handles tsbtnExcel.Click
            Try
            Utilitarios.ExportarXLS(c1grdDetalle, "Pedido de Compra")
        Catch ex As Exception
            ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso Exportar a Excel", ex)
        End Try
End Sub
End Class