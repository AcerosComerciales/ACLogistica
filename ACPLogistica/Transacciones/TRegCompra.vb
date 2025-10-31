Imports C1.Win.C1FlexGrid
Imports ACFramework
Imports ACELogistica
Imports ACBLogistica
Imports ACEVentas
Imports ACBVentas


Imports Microsoft.Practices.Unity
Imports Microsoft.Practices.Unity.Configuration

Public Class TRegCompra

#Region " Variables "
   Private m_order As Integer = 1
   Private m_eabas_docscompra As EABAS_DocsCompra

   Private m_listBindHelper As List(Of ACBindHelper)

   Private bs_docscompra As BindingSource
   Private bs_detdocscompra As BindingSource
   Private bs_tipodocumento As BindingSource

    Private managerGenerarGuias As BGenerarGuias
   Private managerGenerarDocsCompra As BGenerarDocsCompra
   Private managerABAS_DocsCompra As BABAS_DocsCompra
   Private managerConsultaArticulos As BConsultaArticulos
   Private managerEntidades As BEntidades
   Private managerTipoCambio As BTipoCambio
   Private managerABAS_OrdenesCompra As BABAS_OrdenesCompra

   Private m_earticulos As EArticulos
   Private m_eentidades As EEntidades

   Private m_modArticulo As Boolean = False

   Private frmCons As CProductos

   Enum Inicio
      Normal
      Busqueda
   End Enum

   Enum Seteo
      Activar
      Desactivar
   End Enum
#End Region

#Region " Propiedades "
   Public Property ABAS_DocsCompra() As EABAS_DocsCompra
      Get
         Return m_eabas_docscompra
      End Get
      Set(ByVal value As EABAS_DocsCompra)
         m_eabas_docscompra = value
      End Set
   End Property
#End Region

#Region " Constructores "
   Public Sub New()

      ' This call is required by the Windows Form Designer.
      InitializeComponent()

      ' Add any initialization after the InitializeComponent() call.
      Try
         Inicializacion()
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "No se puede cargar los controles iniciales", ex)
      End Try
   End Sub

   Public Sub New(ByVal x_inicio As Inicio)
      ' This call is required by the Windows Form Designer.
      InitializeComponent()
      Try
         Inicializacion()
         If x_inicio = Inicio.Busqueda Then
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

   Private Sub Inicializacion()
      Try
         tabMantenimiento.HideTabsMode = Crownwood.DotNetMagic.Controls.HideTabsModes.HideAlways
         tabMantenimiento.SelectedTab = tabBusqueda

         managerGenerarDocsCompra = New BGenerarDocsCompra
         managerABAS_DocsCompra = New BABAS_DocsCompra
         managerConsultaArticulos = New BConsultaArticulos(GApp.Periodo)
         managerEntidades = New BEntidades
         managerTipoCambio = New BTipoCambio
         managerABAS_OrdenesCompra = New BABAS_OrdenesCompra

         formatearGrilla()
         cargarCombos()

         setInstancia(ACUtilitarios.ACSetInstancia.Deshacer)
         Me.Icon = Icon.FromHandle(ACPLogistica.My.Resources.EditPaper_16x16.GetHicon)
         acFecha.ACDtpFecha_De.Value = DateTime.Now.AddDays(-1 * DateTime.Now.Day + 1)
      Catch ex As Exception
         Throw ex
      End Try
   End Sub
#End Region

#Region " Metodos "
   ''' <summary>
   ''' Activar los controles segun los permisos o el rol que tiene el cliente
   ''' </summary>
   ''' <param name="x_opcion"></param>
   ''' <remarks></remarks>
   Private Sub setRol(ByVal x_opcion As Seteo)
      Try
         actxaProvRuc.ReadOnly = IIf(x_opcion = Seteo.Activar, False, True)
         actxaProvRuc.ACActivarAyuda = IIf(x_opcion = Seteo.Activar, True, False)
         actxaProvRuc.ACAyuda.Enabled = IIf(x_opcion = Seteo.Activar, True, False)
         actxaProvRazonSocial.ReadOnly = IIf(x_opcion = Seteo.Activar, False, True)
         actxaProvRazonSocial.ACActivarAyuda = IIf(x_opcion = Seteo.Activar, True, False)
         actxaProvRazonSocial.ACAyuda.Enabled = IIf(x_opcion = Seteo.Activar, True, False)
      Catch ex As Exception
         Throw ex
      End Try
   End Sub

   Private Function getFilterRol() As Boolean
      Try
         If Not IsNothing(managerEntidades.Entidades) Then
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

   Private Sub NuevoProveedor(ByVal x_entid_nrodocumento As String)
      Try
         Dim frmEntidad As New MEntidad(MEntidad.Inicio.NuevaEntidad, ACEVentas.EEntidades.TipoEntidad.Clientes)
         frmEntidad.StartPosition = FormStartPosition.CenterScreen
         If x_entid_nrodocumento.Length > 0 Then
            frmEntidad.EEntidad.ENTID_NroDocumento = x_entid_nrodocumento
            frmEntidad.lblNombres.Focus()
         End If
         If frmEntidad.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            m_eentidades = frmEntidad.EEntidad
            m_eabas_docscompra.ENTID_CodigoProveedor = m_eentidades.ENTID_Codigo

            Dim l_Tipos As New List(Of ETipos)(Colecciones.GetTipos(m_eentidades.Cliente.TIPOS_CodTipoPercepcion))
            Dim pPercepcion As Double
            If l_Tipos.Count > 0 Then
               pPercepcion = l_Tipos(0).TIPOS_Numero
            End If
            m_eentidades.Cliente.Percepcion = pPercepcion
            managerEntidades.Entidades = m_eentidades
            managerEntidades.Cliente = m_eentidades.Cliente
            actxaProvRazonSocial.Text = managerEntidades.Entidades.ENTID_RazonSocial
            actxaProvRuc.Text = managerEntidades.Entidades.ENTID_NroDocumento
         End If
      Catch ex As Exception
         Throw ex
      End Try
   End Sub

#Region " Utilitarios "

   Private Sub formatearGrilla()
      Dim index As Integer = 1
      Try
            ACFrameworkC1.ACUtilitarios.ACFormatearGrilla(c1grdBusqueda, 1, 1, 15, 1, 0)
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Codigo", "ENTID_CodigoProveedor", "ENTID_CodigoProveedor", 150, False, False, "System.String") : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Fecha", "DOCCO_FechaDocumento", "DOCCO_FechaDocumento", 150, True, False, "System.DateTime", Parametros.GetParametro(EParametros.TipoParametros.pg_FormatoFecha)) : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Codigo", "DOCCO_Codigo", "DOCCO_Codigo", 150, False, False, "System.String") : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Documento", "Documento", "Documento", 150, True, False, "System.String") : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Doc. Base", "DocBase", "DocBase", 150, True, False, "System.String") : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Cod. Proveedor", "ENTID_CodigoProveedor", "ENTID_CodigoProveedor", 150, False, False, "System.String") : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Proveedor", "ENTID_Proveedor", "ENTID_Proveedor", 150, True, False, "System.String") : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Moneda", "TIPOS_TipoMoneda", "TIPOS_TipoMoneda", 150, True, False, "System.String") : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Total Compra", "DOCCO_TotalCompra", "DOCCO_TotalCompra", 150, True, False, "System.Decimal", Parametros.GetParametro(EParametros.TipoParametros.pg_FMondo2d)) : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Tipo Pago", "TIPOS_TipoPago", "TIPOS_TipoPago", 150, True, False, "System.String") : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Estado", "DOCCO_Estado_Text", "DOCCO_Estado_Text", 150, True, False, "System.String") : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Estado", "DOCCO_Estado", "DOCCO_Estado", 150, False, False, "System.String") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Doc. Referencia", "ORDEN_Codigo", "ORDEN_Codigo", 150, True, False, "System.String") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Reg. Almacen", "IngresoReg", "IngresoReg", 150, True, False, "System.Boolean") : index += 1

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
         ACFrameworkC1.ACUtilitarios.ACFormatearGrilla(c1grdDetalle, 1, 1, 10, 1, 0)
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdDetalle, index, "Codigo", "ARTIC_Codigo", "ARTIC_Codigo", 80, True, False, "System.String") : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdDetalle, index, "Descripción", "ARTIC_Descripcion", "ARTIC_Descripcion", 191, True, False, "System.String") : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdDetalle, index, "Unidad", "TIPOS_UnidadMedidaCorta", "TIPOS_UnidadMedidaCorta", 69, True, False, "System.String") : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdDetalle, index, "Peso", "DOCCD_PesoUnitario", "DOCCD_PesoUnitario", 75, True, False, "System.Decimal", Parametros.GetParametro(EParametros.TipoParametros.pg_FMondo4d)) : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdDetalle, index, "Cantidad", "DOCCD_Cantidad", "DOCCD_Cantidad", 75, True, True, "System.Decimal", Parametros.GetParametro(EParametros.TipoParametros.pg_FMondo2d)) : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdDetalle, index, "Precio Unit.", "DOCCD_PrecioUnitario", "DOCCD_PrecioUnitario", 75, True, True, "System.Decimal", Parametros.GetParametro(EParametros.TipoParametros.pg_FMondo2d)) : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdDetalle, index, "Peso Doc.", "DOCCD_SubPeso", "DOCCD_SubPeso", 75, True, True, "System.Decimal", Parametros.GetParametro(EParametros.TipoParametros.pg_FMondo4d)) : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdDetalle, index, "Sub-Importe", "DOCCD_SubImporteCompra", "DOCCD_SubImporteCompra", 75, True, True, "System.Decimal", Parametros.GetParametro(EParametros.TipoParametros.pg_FMondo2d)) : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdDetalle, index, "Destino", "TIPOS_TipoDestino", "TIPOS_TipoDestino", 80, True, True, "System.String") : index += 1
         c1grdDetalle.AllowEditing = True
         c1grdDetalle.AutoResize = False
         c1grdDetalle.Cols(0).Width = 15
         c1grdDetalle.ExtendLastCol = True
         'c1grdDetalle.Cols(2).
         c1grdDetalle.Styles.Alternate.BackColor = Color.LightGray
         c1grdDetalle.Styles.Fixed.TextAlign = TextAlignEnum.CenterCenter
         c1grdDetalle.Styles.Highlight.BackColor = Color.Gray
         c1grdDetalle.SelectionMode = SelectionModeEnum.Row
         c1grdDetalle.AllowResizing = AllowResizingEnum.None
         c1grdDetalle.Cols("TIPOS_TipoDestino").Editor = cmbGDestino
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Text), "No se puede dar formato a la grilla", ex)
      End Try
   End Sub

   Private Sub setInstancia(ByVal _opcion As ACUtilitarios.ACSetInstancia)
      acTool.ACBtnModificarVisible = False
      actsbtnPrevisualizar.Visible = True
      Select Case _opcion
         Case ACUtilitarios.ACSetInstancia.Nuevo
            ACUtilitarios.ACLimpiaVar(pnlCabecera)
            ACUtilitarios.ACLimpiaVar(pnlDetCabecera)
            ACUtilitarios.ACSetControl(pnlCabecera, False, ACUtilitarios.TipoPropiedad.ACReadOnly)
            actxaOrdCompra.ACAyuda.Enabled = True
            actxaOrdCompra.ACActivarAyuda = True
            actxaProvRuc.ACAyuda.Enabled = True
            actxaProvRuc.ACActivarAyuda = True
            actxaProvRazonSocial.ACAyuda.Enabled = True
            actxaProvRazonSocial.ACActivarAyuda = True
            btnNuevoCliente.Enabled = True
            dtpFecha.Enabled = True
            dtpFecPago.Enabled = True
            btnClean.Enabled = True
            actxaProvRuc.Focus()
            pnlDetCabecera.Enabled = False
            btnClean.Enabled = True
                actsbtnPrevisualizar.Visible = False

                AddHandler c1grdDetalle.KeyDown, AddressOf c1grdDetalle_KeyDown
         Case ACUtilitarios.ACSetInstancia.Modificado
            AddHandler c1grdDetalle.KeyDown, AddressOf c1grdDetalle_KeyDown
            Case ACUtilitarios.ACSetInstancia.Guardar
                txtBusqueda.Focus()
            RemoveHandler c1grdDetalle.KeyDown, AddressOf c1grdDetalle_KeyDown
         Case ACUtilitarios.ACSetInstancia.Deshacer
                RemoveHandler c1grdDetalle.KeyDown, AddressOf c1grdDetalle_KeyDown

            Case ACUtilitarios.ACSetInstancia.Previsualizar
            acTool.setInstancia(ACControles.ACToolBarMantHorizontalNew.TipoInstancia.Nuevo)
            acTool.ACBtnGrabarVisible = False
            acTool.ACBtnAnularVisible = False
            actxaOrdCompra.ACAyuda.Enabled = False
            actxaOrdCompra.ACActivarAyuda = False
            actxaProvRuc.ACAyuda.Enabled = False
            actxaProvRuc.ACActivarAyuda = False
            actxaProvRazonSocial.ACAyuda.Enabled = False
            actxaProvRazonSocial.ACActivarAyuda = False
            btnNuevoCliente.Enabled = False
            btnClean.Enabled = False
            dtpFecha.Enabled = False
            dtpFecPago.Enabled = False
            actsbtnPrevisualizar.Visible = False
            ACUtilitarios.ACSetControl(pnlCabecera, True, ACUtilitarios.TipoPropiedad.ACReadOnly)
            RemoveHandler c1grdDetalle.KeyDown, AddressOf c1grdDetalle_KeyDown
      End Select
   End Sub

   Private Sub cargarCombos()
      Try
         ACUtilitarios.ACCargaCombo(cmbMoneda, Colecciones.Tipos(ETipos.MyTipos.TipoMoneda), "TIPOS_DescCorta", "TIPOS_Codigo")
         ACUtilitarios.ACCargaCombo(cmbTipoPago, Colecciones.Tipos(ETipos.MyTipos.CondicionPago), "TIPOS_Descripcion", "TIPOS_Codigo")
         Dim listDestino As New List(Of ETipos)()
         Dim listDestAll As New List(Of ETipos)()
         For Each Item As ETipos In Colecciones.Tipos(ETipos.MyTipos.TipoDestinoArticulo)
            listDestino.Add(Item.Clone())
            listDestAll.Add(Item.Clone())
         Next
         ACUtilitarios.ACCargaCombo(cmbProdDestino, Colecciones.Tipos(ETipos.MyTipos.TipoDestinoArticulo), "TIPOS_Descripcion", "TIPOS_Codigo")
         ACUtilitarios.ACCargaCombo(tscmbDestino, listDestAll, "TIPOS_Descripcion", "TIPOS_Codigo")
         ACUtilitarios.ACCargaCombo(cmbGDestino, listDestino, "TIPOS_Descripcion", "TIPOS_Codigo")
         bs_tipodocumento = New BindingSource : bs_tipodocumento.DataSource = Colecciones.TiposDocMerTransito()
         AddHandler bs_tipodocumento.CurrentChanged, AddressOf bs_tipodocumento_CurrentChanged
         ACUtilitarios.ACCargaCombo(cmbDocumento, bs_tipodocumento, "TIPOS_Descripcion", "TIPOS_Codigo")
         Dim list As New List(Of ETipos)()
         For Each Item As ETipos In Colecciones.TiposDocMerTransito()
            list.Add(Item.Clone())
         Next
         list.Insert(0, New ETipos("", "<< Todos >>"))
         ACUtilitarios.ACCargaCombo(cmbTipoDocumento, list, "TIPOS_Descripcion", "TIPOS_Codigo")
      Catch ex As Exception
         Throw ex
      End Try
   End Sub

   Private Function validar(ByRef m_msg As String)
      c1grdDetalle.FinishEditing()
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

         For Each Item As EABAS_DocsCompraDetalle In m_eabas_docscompra.ListEABAS_DocsCompraDetalle
            If IsNothing(Item.TIPOS_CodTipoDestino) Then
               m_msg &= String.Format("- No se ha asignado un destino a la mercaderia{0}", vbNewLine)
            End If
         Next
         Return Not (m_msg.Length > 0)
      Catch ex As Exception
         Throw ex
      End Try
   End Function

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
   Private Sub AsignarBinding()
      Try
         m_listBindHelper = New List(Of ACBindHelper)()
         If m_eabas_docscompra.DOCCO_FechaDocumento.Year < 1700 Then m_eabas_docscompra.DOCCO_FechaDocumento = DateTime.Now
         m_listBindHelper.Add(ACBindHelper.ACBind(dtpFecha, "Value", m_eabas_docscompra, "DOCCO_FechaDocumento"))
         m_listBindHelper.Add(ACBindHelper.ACBind(actxaProvRuc, "Text", m_eabas_docscompra, "ENTID_CodigoProveedor"))
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
            m_listBindHelper.Add(ACBindHelper.ACBind(actxaOrdCompra, "Text", m_eabas_docscompra, "ORDEN_Codigo"))
            m_listBindHelper.Add(ACBindHelper.ACBind(txtCodigoSAP, "Text", m_eabas_docscompra, "DOCCO_CodigoSAP"))

            'cotco_proveedor by frnak 'DOCCO_CotizacionProveedor = Nothing
            'm_listBindHelper.Add(ACBindHelper.ACBind(actxnCotizacionProveedor, "Text", m_eabas_docscompra, "DOCCO_CotizacionProveedor"))




            m_listBindHelper.Add(ACBindHelper.ACBind(txtDescuento, "Text", m_eabas_docscompra, "DOCCO_Descuento"))
            m_listBindHelper.Add(ACBindHelper.ACBind(txtGastos, "Text", m_eabas_docscompra, "DOCCO_Gastos"))
            m_listBindHelper.Add(ACBindHelper.ACBind(txtFlete, "Text", m_eabas_docscompra, "DOCCO_Flete"))
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
         If Ayuda.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Select Case x_opcion
               Case EEntidades.TipoEntidad.ProveedoresLogistica
                  '' Cargar datos del cliente
                  m_eabas_docscompra.ENTID_CodigoProveedor = Ayuda.Respuesta.Rows(0)("Codigo")
                  actxaProvRuc.Text = Ayuda.Respuesta.Rows(0)("Codigo").ToString()
                  actxaProvRazonSocial.Text = Ayuda.Respuesta.Rows(0)("Razon Social").ToString()
                  ' '' Cargar datos adicionales Proveedor
                  cmbDocumento.Focus()
                  pnlDetCabecera.Enabled = True
                  setRol(IIf(getFilterRol(), Seteo.Activar, Seteo.Desactivar))
                  grpDocumento.Focus()
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
         acTool.ACBtnModificarVisible = False
         If Not IsNothing(bs_docscompra.Current) Then
            If CType(bs_docscompra.Current, EABAS_DocsCompra).DOCCO_Estado = EABAS_DocsCompra.getEstado(EABAS_DocsCompra.Estado.Confirmado) Then
               acTool.ACBtnAnularEnabled = False
            ElseIf CType(bs_docscompra.Current, EABAS_DocsCompra).DOCCO_Estado = EABAS_DocsCompra.getEstado(EABAS_DocsCompra.Estado.Anulado) Then
               acTool.ACBtnAnularEnabled = False
            Else
               acTool.ACBtnAnularEnabled = True
            End If

            If CType(bs_docscompra.Current, EABAS_DocsCompra).TIPOS_CodTipoDocumento = ETipos.getTipoComprobante(ETipos.TipoComprobanteVenta.NotaCredito) Then
               acbtnSeleccionar.Enabled = False
            Else
               acbtnSeleccionar.Enabled = True
            End If
         End If
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso Cargar Propiedades del Cotización/Pedido", ex)
      End Try
   End Sub

   Private Sub bs_tipodocumento_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
      Try
         If CType(bs_tipodocumento.Current, ETipos).TIPOS_Codigo.Equals(ETipos.getTipoComprobante(ETipos.TipoComprobanteVenta.Ticket)) Then
            txtSerie.MaxLength = 4 : actxnNumero.MaxLength = 8
         Else
            If Not txtSerie.Text.Equals("") Then
               If txtSerie.MaxLength > 3 Then txtSerie.Text = txtSerie.Text.Substring(0, 3)
            End If
            If actxnNumero.Text.Length > 7 Then actxnNumero.Text = actxnNumero.Text.Substring(0, 7)
            txtSerie.MaxLength = 3 : actxnNumero.MaxLength = 7
         End If
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso Cambiar Registro", ex)
      End Try
   End Sub
#End Region

#Region " Procesos "

   Private Sub OrdenarPedidos(ByVal x_columna As String)
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
            m_eabas_docscompra.TIPOS_CodTipoMoneda = _orden.TIPOS_CodTipoMoneda
                m_eabas_docscompra.TIPOS_CodTipoPago = _orden.TIPOS_CodTipoPago
                m_eabas_docscompra.DOCCO_CotizacionProveedor = _orden.ORDCO_CotizacionProveedor
                '' Asignar Valores de la orden de compra: Detalle
                m_eabas_docscompra.ListEABAS_DocsCompraDetalle = New List(Of EABAS_DocsCompraDetalle)()
            For Each Item As EABAS_OrdenesCompraDetalle In _orden.ListABAS_OrdenesCompraDetalle
               Dim _detalle As New EABAS_DocsCompraDetalle
               _detalle.ARTIC_Codigo = Item.ARTIC_Codigo
               _detalle.ARTIC_Descripcion = Item.ARTIC_Descripcion
               _detalle.DOCCD_Cantidad = Item.ORDCD_Cantidad
               _detalle.DOCCD_PesoUnitario = Item.ORDCD_PesoUnitario
               _detalle.DOCCD_SubPeso = Item.ORDCD_Cantidad * Item.ORDCD_PesoUnitario
               _detalle.DOCCD_PrecioUnitario = Item.ORDCD_PrecioUnitario
               _detalle.DOCCD_SubImporteCompra = Item.ORDCD_SubImporteCompra
               _detalle.TIPOS_UnidadMedida = Item.TIPOS_UnidadMedida
               _detalle.TIPOS_UnidadMedidaCorta = Item.TIPOS_UnidadMedidaCorta
               m_eabas_docscompra.ListEABAS_DocsCompraDetalle.Add(_detalle)
            Next
            actxaProvRazonSocial.Text = m_eabas_docscompra.ENTID_Proveedor
                actxnCotizacionProveedor.Text = m_eabas_docscompra.DOCCO_CotizacionProveedor
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
            calcular()
         End If
      Catch ex As Exception
         Throw ex
      End Try
   End Sub


   Private Sub calcPrecioPeso()
      Try
         If Not actxnProdCantidad.Text = "" And Not actxnProdPrecUnitario.Text = "" Then
            Dim _cantidad As Double = actxnProdCantidad.Text
            Dim _precuni As Double = actxnProdPrecUnitario.Text
            Dim _peso As Double = actxnProdPeso.Text
            Dim _tprecio As Double = _cantidad * _precuni
            Dim _tpeso As Double = _cantidad * _peso
            actxnProdSubImporte.Text = _tprecio.ToString(Parametros.GetParametro(EParametros.TipoParametros.pg_FMondo2d))
            actxnProdPesoDoc.Text = _tpeso.ToString(Parametros.GetParametro(EParametros.TipoParametros.pg_FMondo4d))
         Else
            actxnProdSubImporte.Text = "0.00"
            actxnProdPesoDoc.Text = "0.00"
         End If
      Catch ex As Exception
         Throw ex
      End Try
   End Sub

   Private Sub nuevoDocCompra()
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
         actxaOrdCompra.Focus()
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
                If managerABAS_DocsCompra.Busqueda(cmbTipoDocumento.SelectedValue, txtCSerie.Text, txtBusNumero.Text, chkTodos.Checked, acFecha.ACDtpFecha_De.Value.Date, acFecha.ACDtpFecha_A.Value.Date) Then ', getCampo() '--, txtBusqueda.Text) Then
                    acTool.ACBtnEliminarEnabled = True
                    acTool.ACBtnModificarEnabled = True
                Else
                    acTool.ACBtnEliminarEnabled = False
                    acTool.ACBtnModificarEnabled = False
                End If
            cargarDatos()
         Else
            'If txtBusqueda.ACEstadoAutoAyuda Then
                Dim PRUEBA As New List(Of ACBVentas.BGenerarGuias)
                Dim _destino As Int16
                If GApp.Almacen = 5 Then
                    _destino = 2
                ElseIf GApp.Almacen = 6 Then
                    _destino = 3
                ElseIf GApp.Almacen = 11 Then 'Lima ventas Es este <<<<-------
                    _destino = 4
                Else
                    _destino = 1
                End If
                'If Not managerGenerarGuias.BusquedaSalida(GApp.Almacen, acFecha.ACDtpFecha_De.Value.Date, acFecha.ACDtpFecha_A.Value.Date, ETipos.getMotivoTraslado(ETipos.MotivoTraslado.Devolucion), 0, 1, txtBusqueda.Text, chkTodos.Checked) Then
                If managerABAS_DocsCompra.Busqueda(chkTodos.Checked, acFecha.ACDtpFecha_De.Value.Date, acFecha.ACDtpFecha_A.Value.Date, getCampo(), txtBusqueda.Text, _destino) Then
                    For Each Item As EABAS_DocsCompra In managerABAS_DocsCompra.ListABAS_DocsCompra
                        If IsNothing(Item.IngresoAlmacen) Then
                            Item.IngresoReg = False
                        Else
                            Item.IngresoReg = True
                        End If

                    Next
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
               m_eabas_docscompra.DOCCO_PorcentajeIGV = Parametros.GetParametro(EParametros.TipoParametros.PIGV)

               '' Obtener el correlativo y asignarlo
               Dim x_codigo As String
               If ETipos.getTipoComprobante(ETipos.TipoComprobanteVenta.Ticket) = m_eabas_docscompra.TIPOS_CodTipoDocumento Then
                  x_codigo = String.Format("{0}{1}{2}", m_eabas_docscompra.TIPOS_CodTipoDocumento.Substring(3, 2), m_eabas_docscompra.DOCCO_Serie.PadLeft(4, "0"), m_eabas_docscompra.DOCCO_Numero.ToString().PadLeft(9, "0"))
               Else
                  x_codigo = String.Format("{0}{1}{2}", m_eabas_docscompra.TIPOS_CodTipoDocumento.Substring(3, 2), m_eabas_docscompra.DOCCO_Serie.PadLeft(3, "0"), m_eabas_docscompra.DOCCO_Numero.ToString().PadLeft(7, "0"))
               End If
               m_eabas_docscompra.DOCCO_Codigo = x_codigo
                    m_eabas_docscompra.ALMAC_Id = GApp.Almacen
                    'grabamos o asignamos la cotizacion del proveedor a nuestra orden de comrpa 


                    '' Definir el Estado
                    m_eabas_docscompra.DOCCO_Estado = EABAS_DocsCompra.getEstado(EABAS_DocsCompra.Estado.Ingresado)
               '' Asignar la clase pedido a la capa de negocio 
               managerGenerarDocsCompra.ABAS_DocsCompra = m_eabas_docscompra

               '' Grabar el pedido
               Return managerGenerarDocsCompra.GrabarDocCompra(GApp.Usuario, True, m_msg)
            End If
         End If
         Return False
      Catch ex As Exception
         Throw ex
      End Try
   End Function

   Private Function addDetalle() As Boolean
      Try
         Dim _filter As New ACFiltrador(Of EABAS_DocsCompraDetalle)
         _filter.ACFiltro = String.Format("ARTIC_Codigo={0}", m_earticulos.ARTIC_Codigo)
         _filter.ACFiltrar(m_eabas_docscompra.ListEABAS_DocsCompraDetalle)
         If _filter.ACListaFiltrada.Count > 0 Then
            If ACControles.ACDialogos.ACMostrarMensajePregunta(String.Format("Registro Duplicado: {0}", Me.Text) _
             , "El producto ya fue ingresado, deseas actualizar la cantidad ingresada?" _
             , ACControles.ACDialogos.LabelBotom.Si_No) = DialogResult.Yes Then
               _filter.ACListaFiltrada(0).DOCCD_Cantidad = actxnProdCantidad.Text
               _filter.ACListaFiltrada(0).DOCCD_PrecioUnitario = actxnProdPrecUnitario.Text
               _filter.ACListaFiltrada(0).DOCCD_PesoUnitario = actxnProdPeso.Text
               _filter.ACListaFiltrada(0).DOCCD_SubImporteCompra = actxnProdSubImporte.Text
               _filter.ACListaFiltrada(0).TIPOS_CodTipoDestino = cmbProdDestino.SelectedValue
               bs_detdocscompra.ResetBindings(False)
               calcular()
               Return True
            End If
         Else
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
         End If
      Catch ex As Exception
         Throw ex
      End Try
   End Function

   Private Sub calcular()
      Try
         bs_detdocscompra.ResetBindings(False)
         Dim _importeTotal As Double = 0
         Dim _pesoTotal As Double = 0
         Dim _igv As Double = IIf(Parametros.GetParametro(EParametros.TipoParametros.PIGV).ToString() = "", 0, Parametros.GetParametro(EParametros.TipoParametros.PIGV))
         If _igv = 0 Then
            acTool.ACBtnGrabarEnabled = False
            Throw New Exception("El I.G.V. No puede ser 0, por favor revise el parametro y coloque el valor adecuado")
         Else
            acTool.ACBtnGrabarEnabled = True
         End If
         For Each Item As EABAS_DocsCompraDetalle In m_eabas_docscompra.ListEABAS_DocsCompraDetalle
            _importeTotal += Item.DOCCD_PrecioUnitario * Item.DOCCD_Cantidad
            _pesoTotal += Item.DOCCD_SubPeso
            Item.DOCCD_SubImporteCompra = Item.DOCCD_PrecioUnitario * Item.DOCCD_Cantidad
            Item.DOCCD_SubPeso = Item.DOCCD_PesoUnitario * Item.DOCCD_Cantidad
         Next
         Dim _total As Double = Math.Round(_importeTotal * ((_igv + 100) / 100), 2)
         Dim _importeIgv As Double = Math.Round(_importeTotal * (_igv / 100), 2)

         actxnIGV.Text = _importeIgv.ToString() : actxnIGV.Formatear()
         actxnTotal.Text = _total.ToString() : actxnTotal.Formatear()
         actxnImporte.Text = _importeTotal.ToString() : actxnImporte.Formatear()
         actxnPesoTotal.Text = _pesoTotal.ToString() : actxnPesoTotal.Formatear()
         bs_detdocscompra.ResetBindings(False)
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


   Private Sub c1grdBusqueda_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c1grdBusqueda.DoubleClick
      If Not IsNothing(bs_docscompra) Then
         If Not IsNothing(bs_docscompra.Current) Then
            '' Codigo

         Else
            ACControles.ACDialogos.ACMostrarMensajeInformacion(String.Format("Información: {0}", Me.Text), "No se puede <<Mensaje>> ")
         End If
      Else
         ACControles.ACDialogos.ACMostrarMensajeInformacion(String.Format("Información: {0}", Me.Text), "No se puede <<Mensaje>> ")
      End If
   End Sub

   Private Sub acbtnSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles acbtnSeleccionar.Click
      Try
         If Not IsNothing(bs_docscompra) Then
            If Not IsNothing(bs_docscompra.Current) Then
               m_eabas_docscompra = CType(bs_docscompra.Current, EABAS_DocsCompra)
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

   Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
      Try
         If rbtnDatos.Checked Then
            txtBusqueda_ACAyudaClick(Nothing, Nothing)
         ElseIf rbtnDocVenta.Checked Then
            txtBusNumero_ACAyudaClick(Nothing, Nothing)
         End If
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Text), "No se puede realizar la consulta", ex)
      End Try
   End Sub

   Private Sub chkAgrupar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAgrupar.CheckedChanged
      Try
         If chkAgrupar.Checked Then
            OrdenarPedidos("ENTID_Proveedor")
            c1grdBusqueda.Subtotal(AggregateEnum.Count, 0, 1, 1, "Agrupado por: {0}")
         Else
            c1grdBusqueda.Subtotal(AggregateEnum.Clear)
         End If
         c1grdBusqueda.AutoSizeCols()
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Convert.ToString(Text)), "No se agrupar resultados", ex)
      End Try
   End Sub

   Private Sub cmbGDestino_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbGDestino.SelectedIndexChanged
      Try
         If Not IsNothing(cmbGDestino.SelectedValue) Then
            If Not IsNothing(bs_detdocscompra) Then
               CType(bs_detdocscompra.Current, EABAS_DocsCompraDetalle).TIPOS_CodTipoDestino = cmbGDestino.SelectedValue
            End If
         End If
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeInformacion(String.Format("Información: {0}", Me.Text), "No se puede <<Mensaje>> ")
      End Try
   End Sub

   Private Sub btnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcular.Click
      Try
         calcular()
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Text), "No se puede calcular", ex)
      End Try
   End Sub

   Private Sub rbtnDatos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtnDatos.CheckedChanged
      grpCliente.Enabled = rbtnDatos.Checked
      grpDocumentos.Enabled = rbtnDocVenta.Checked
   End Sub

   Private Sub txtDescripcion_SizeChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtProdDescripcion.SizeChanged
      Try
         c1grdDetalle.Cols(2).Width = txtProdDescripcion.Size.Width
      Catch ex As Exception

      End Try
   End Sub

   Private Sub tsbtnAsigDestino_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnAsigDestino.Click
      Try
         For Each Item As EABAS_DocsCompraDetalle In m_eabas_docscompra.ListEABAS_DocsCompraDetalle
            Item.TIPOS_CodTipoDestino = tscmbDestino.ComboBox.SelectedValue
            Item.TIPOS_TipoDestino = tscmbDestino.Text
         Next
         c1grdDetalle.Refresh()
      Catch ex As Exception
         Throw ex
      End Try
   End Sub

   Private Sub btnNuevoCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevoCliente.Click
      Try
         Dim frmEntidad As New MEntidad(MEntidad.Inicio.NuevaEntidad, EEntidades.TipoEntidad.ProveedoresLogistica)
         If frmEntidad.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            m_eentidades = frmEntidad.EEntidad
            m_eabas_docscompra.ENTID_CodigoProveedor = m_eentidades.ENTID_Codigo
            actxaProvRuc.Text = managerEntidades.Entidades.ENTID_Codigo
            actxaProvRazonSocial.Text = managerEntidades.Entidades.ENTID_RazonSocial
            setRol(IIf(getFilterRol(), Seteo.Activar, Seteo.Desactivar))
            pnlDetCabecera.Enabled = True
         End If
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso Nuevo Cliente", ex)
      End Try
   End Sub

   Private Sub btnClean_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClean.Click
      Try
         m_eentidades = New EEntidades
         actxaProvRuc.Clear()
         actxaProvRazonSocial.Clear()
         setRol(Seteo.Activar)
         pnlDetCabecera.Enabled = False
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso Limpiar Entidad", ex)
      End Try
   End Sub

   Private Sub txtSerie_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSerie.KeyPress
      If Char.IsDigit(e.KeyChar) Then
         e.Handled = False
      ElseIf Char.IsControl(e.KeyChar) Then
         e.Handled = False
             ElseIf Char.IsLetter(e.KeyChar) Then
         e.Handled = False
      Else
         e.Handled = True
      End If
   End Sub

   Private Sub c1grdDetalle_AfterEdit(ByVal sender As System.Object, ByVal e As C1.Win.C1FlexGrid.RowColEventArgs) Handles c1grdDetalle.AfterEdit
      Try
         calcular()
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Text), "No se puede calcular", ex)
      End Try
   End Sub

   Private Sub actsbtnPrevisualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles actsbtnPrevisualizar.Click
      Try
         If Not IsNothing(bs_docscompra) Then
            If Not IsNothing(bs_docscompra.Current) Then
               '' Codigo
               '' Codigo
               Dim x_codigo As String = CType(bs_docscompra.Current, EABAS_DocsCompra).DOCCO_Codigo
               Dim x_entidad As String = CType(bs_docscompra.Current, EABAS_DocsCompra).ENTID_CodigoProveedor
               '' Cargar Cotizacion
               If managerABAS_DocsCompra.Cargar(x_codigo, x_entidad, True) Then
                        m_eabas_docscompra = managerABAS_DocsCompra.ABAS_DocsCompra


                        AsignarBinding()
                  '' Cargar listado de Productos
                  bs_detdocscompra = New BindingSource
                  bs_detdocscompra.DataSource = m_eabas_docscompra.ListEABAS_DocsCompraDetalle
                  c1grdDetalle.DataSource = bs_detdocscompra
                  bnavProductos.BindingSource = bs_detdocscompra
                  tabMantenimiento.SelectedTab = tabDatos
                  '' Cargar datos del Cliente
                  If managerEntidades.Cargar(m_eabas_docscompra.ENTID_CodigoProveedor) Then
                     'actxaProvCodigo.Text = m_eabas_cotizacionescompra.ENTID_CodigoProveedor
                     actxaProvRuc.Text = m_eabas_docscompra.ENTID_NroDocumento
                     actxaProvRazonSocial.Text = managerEntidades.Entidades.ENTID_RazonSocial
                  End If

                  '' Setear Valores
                  setInstancia(ACUtilitarios.ACSetInstancia.Previsualizar)
                  If Not m_eabas_docscompra.DOCCO_Estado = EABAS_CotizacionesCompra.getEstado(EABAS_CotizacionesCompra.Estado.Ingresado) Then
                     acTool.ACBtnModificarEnabled = False
                  End If
               End If
            Else
               Throw New Exception("No se puede cargar el documento")
            End If
         Else
            Throw New Exception("No se puede cargar el documento")
         End If
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), String.Format(Colecciones.getError("00101"), "Cargar el documento de compra"), ex)
      End Try
   End Sub

#Region " ToolBar "

   Private Sub acTool_ACBtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles acTool.ACBtnNuevo_Click
      Try
         nuevoDocCompra()
         '' Activar las opciones generales del teclado
         KeyPreview = True

         'actxaCodigo.Focus()
         eprError.SetError(Me.actxaProvRuc, "Campo Obligatorio")
         eprError.SetError(Me.actxaOrdCompra, "Campo Obligatorio")
         eprError.SetError(Me.actxaProvRazonSocial, "Campo Obligatorio")
         eprError.SetError(Me.cmbDocumento, "Campo Obligatorio")
         eprError.SetError(Me.actxnNumero, "Campo Obligatorio")
         eprError.SetError(Me.txtSerie, "Campo Obligatorio")
         Me.KeyPreview = True

         Dim _tipocambio As New BTipoCambio
         If _tipocambio.getTipoCambioSunat() Then
            actxnTipoCambio.Text = _tipocambio.TipoCambio.TIPOC_VentaSunat
         End If

         frmCons = Nothing

      Catch ex As Exception
         acTool.setInstancia(ACControles.ACToolBarMantHorizontalNew.TipoInstancia.Cancelar)
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso Nueva Cotización/Pedido", ex)
      End Try
   End Sub

   Private Sub acTool_ACBtnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles acTool.ACBtnGrabar_Click
      Dim m_msg As String = ""
      Try
         If grabarDocCompra(m_msg) Then
            '' Manejar las opciones de la barra de herramientas
            acTool.setInstancia(ACControles.ACToolBarMantHorizontalNew.TipoInstancia.Cancelar)
            tabMantenimiento.SelectedTab = tabBusqueda
            ACControles.ACDialogos.ACMostrarMensajeSatisfactorio(String.Format("Información: {0}", Me.Text), "Grabado Satisfactoriamente")
            'acTool.ACBtnModificarVisible = m_proceso_modificar
            'txtBusqueda_ACAyudaClick(Nothing, Nothing)
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

   Private Sub acTool_ACBtnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles acTool.ACBtnModificar_Click
      Try
         'Dim x_codigo As Long = CType(bs_pedidos.Current, EVENT_Pedidos).PEDID_Id
         '' Cargar Pedido / Cotizacion
         'If managerVENT_Pedidos.Cargar(x_codigo, True) Then
         '   m_event_pedidos = managerVENT_Pedidos.VENT_Pedidos
         '   If m_event_pedidos.PEDID_Estado = EVENT_Pedidos.getEstado(EVENT_Pedidos.Estado.Confirmado) Then
         '      acTool.setInstancia(ACControles.ACToolBarMantHorizontalNew.TipoInstancia.Cancelar)
         '      ACControles.ACDialogos.ACMostrarMensajeInformacion(String.Format("Información: {0}", Me.Text), "No se puede modificar el pedido por que ya fue confirmado", "Se actualizara el listado de pedidos")
         '      txtBusqueda_ACAyudaClick(Nothing, Nothing)
         '      Return
         '   End If
         '   AsignarBinding()
         '   '' Cargar listado de Productos
         '   bs_detPedido = New BindingSource
         '   bs_detPedido.DataSource = m_event_pedidos.ListDetPedidos
         '   c1grdDetalle.DataSource = bs_detPedido
         '   bnavProductos.BindingSource = bs_detPedido
         '   tabMantenimiento.SelectedTab = tabDatos
         '   '' Cargar datos del Cliente
         '   actxaCliCodigo.Text = m_event_pedidos.ENTID_Codigo
         '   actxaCliRuc.Text = m_event_pedidos.ENTID_NroDocumento
         '   '' Cargar Vendedor
         '   cargarVendedor(m_event_pedidos.ENTID_IdVendedor)
         '   '' Setear Valores
         '   setInstancia(ACUtilitarios.ACSetInstancia.Modificado)
         'End If
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso Modificar Pedido", ex)
      End Try
   End Sub

   Private Sub acTool_ACBtnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles acTool.ACBtnImprimir_Click
      Try

      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso Imprimir Cotización/Pedido", ex)
      End Try
   End Sub

   Private Sub acTool_ACBtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles acTool.ACBtnCancelar_Click
      Try
         acTool.ACBtnModificarVisible = False
         If ACControles.ACDialogos.ACMostrarMensajePregunta(String.Format("Cancelar Registro de Compra: {0}", Me.Text) _
             , "Desea cancelar el Registro de Compra?" _
             , ACControles.ACDialogos.LabelBotom.Si_No) = DialogResult.Yes Then
            tabMantenimiento.SelectedTab = tabBusqueda
            setInstancia(ACUtilitarios.ACSetInstancia.Deshacer)
         Else
            acTool.setInstancia(ACControles.ACToolBarMantHorizontalNew.TipoInstancia.Nuevo)
         End If
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso cancelar la Cotización/Pedido", ex)
      End Try
   End Sub

   Private Sub acTool_ACBtnAnular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles acTool.ACBtnAnular_Click
      Try
         m_eabas_docscompra = CType(bs_docscompra.Current, EABAS_DocsCompra)
         If ACControles.ACDialogos.ACMostrarMensajePregunta(String.Format("Anular Registro de Compra: {0}", Me.Text) _
             , String.Format("Desea Anular el documento: {0}?", m_eabas_docscompra.Documento) _
             , ACControles.ACDialogos.LabelBotom.Si_No) = DialogResult.Yes Then
            managerABAS_DocsCompra.ABAS_DocsCompra = New EABAS_DocsCompra()
            managerABAS_DocsCompra.ABAS_DocsCompra.DOCCO_Codigo = m_eabas_docscompra.DOCCO_Codigo
            managerABAS_DocsCompra.ABAS_DocsCompra.ENTID_CodigoProveedor = m_eabas_docscompra.ENTID_CodigoProveedor
            managerABAS_DocsCompra.ABAS_DocsCompra.DOCCO_Estado = EABAS_DocsCompra.getEstado(EABAS_DocsCompra.Estado.Anulado)
            managerABAS_DocsCompra.ABAS_DocsCompra.Instanciar(ACEInstancia.Modificado)
            If managerABAS_DocsCompra.Guardar(GApp.Usuario) Then
               ACControles.ACDialogos.ACMostrarMensajeSatisfactorio(String.Format("Información: {0}", Me.Text), "Anulado Satisfactoriamente")
               setInstancia(ACUtilitarios.ACSetInstancia.Deshacer)
               btnConsultar_Click(sender, e)
            End If
         Else
            acTool.setInstancia(ACControles.ACToolBarMantHorizontalNew.TipoInstancia.Nuevo)
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

#Region " Textos"

   Private Sub actxnProdPrecUnitario_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles actxnProdPrecUnitario.TextChanged
      Try
         calcPrecioPeso()
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Convert.ToString(Text)), "No se puede calcular el precio, peso", ex)
      End Try
   End Sub

   Private Sub actxnProdCantidad_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles actxnProdCantidad.TextChanged
      Try
         calcPrecioPeso()
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Convert.ToString(Text)), "No se puede calcular el precio, peso", ex)
      End Try
   End Sub

   Private Sub txtOpcion_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtOpcion.KeyPress
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

   Private Sub txtOpcion_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtOpcion.KeyDown
      Try

         Select Case e.KeyData
            Case Keys.Enter
               addDetalle()
               setProducto(False)
               m_modArticulo = False
               Label26.Focus()
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
               bs_docscompra.Position += 1
               e.Handled = True
               Exit Select
            Case Keys.Up
               bs_docscompra.Position -= 1
               e.Handled = True
               Exit Select
            Case Keys.PageDown
               bs_docscompra.Position += 10
               e.Handled = True
               Exit Select
            Case Keys.PageUp
               bs_docscompra.Position -= 10
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

#Region " Ayudas "

   Private Sub txtBusNumero_ACAyudaClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBusNumero.ACAyudaClick
      Try
         busqueda(txtBusqueda.Text, True)
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Convert.ToString(Text)), "No se puede cargar la ayuda para los registros de compra", ex)
      End Try
   End Sub

   Private Sub actxaOrdCompra_ACAyudaClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles actxaOrdCompra.ACAyudaClick
      Try
         Dim frmAyuda As New TOrdenCompra(TOrdenCompra.Inicio.Busqueda)
         If frmAyuda.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            actxaOrdCompra.Text = frmAyuda.ABAS_OrdenesCompra.ORDCO_Codigo
            setOrdenToDocCompra(frmAyuda.ABAS_OrdenesCompra.ORDCO_Codigo)
            actxaProvRazonSocial.Text = frmAyuda.ABAS_OrdenesCompra.ENTID_Proveedor
            pnlDetCabecera.Enabled = False
            cmbDocumento.Focus()
            KeyPreview = True
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

   Private Sub actxaProdCodigo_ACAyudaClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles actxaProdCodigo.ACAyudaClick
      Try
         If IsNothing(frmCons) Then frmCons = New CProductos(CProductos.Origen.Cotizaciones) With {.StartPosition = FormStartPosition.CenterScreen}
         If frmCons.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            m_earticulos = frmCons.Articulo
            setProducto(True)
            Dim _filter As New ACFiltrador(Of ETipos)
            _filter.ACFiltro = String.Format("TIPOS_Codigo={0}", m_earticulos.TIPOS_CodUnidadMedida)
            If _filter.ACFiltrar(Colecciones.TiposUniMedDecimal).Count > 0 Then
               actxnProdCantidad.ACDecimales = 2
            Else
               actxnProdCantidad.ACDecimales = 0
            End If
         End If
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso cargar productos", ex)
      End Try
   End Sub

   Private Sub actxaProvNombres_ACAyudaClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles actxaProvRazonSocial.ACAyudaClick
      Try
         AyudaEntidad(actxaProvRazonSocial.Text, "ENTID_Nombres", EEntidades.TipoEntidad.ProveedoresLogistica)
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso busqueda de proveedores por descripción", ex)
      End Try
   End Sub

   Private Sub actxaProvCodigo_ACAyudaClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles actxaProvRuc.ACAyudaClick
      Try
         AyudaEntidad(actxaProvRuc.Text, "ENTID_Codigo", EEntidades.TipoEntidad.ProveedoresLogistica)
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso busqueda de proveedores por descripción", ex)
      End Try
   End Sub

#End Region

#Region " Grillas "

   Private Sub c1grdBusqueda_BeforeSort(ByVal sender As System.Object, ByVal e As C1.Win.C1FlexGrid.SortColEventArgs) Handles c1grdBusqueda.BeforeSort
      Try
         OrdenarPedidos(c1grdBusqueda.Cols(e.Col).UserData)
         c1grdBusqueda.Subtotal(AggregateEnum.Clear)
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso ordenar", ex)
      End Try
   End Sub

   Private Sub c1grdBusqueda_OwnerDrawCell(ByVal sender As System.Object, ByVal e As C1.Win.C1FlexGrid.OwnerDrawCellEventArgs) Handles c1grdBusqueda.OwnerDrawCell
      Try
         If e.Row < c1grdBusqueda.Rows.Fixed OrElse e.Col < c1grdBusqueda.Cols.Fixed Then Return
         If c1grdBusqueda.Cols(e.Col).Name = "DOCCO_FechaDocumento" Or c1grdBusqueda.Cols(e.Col).Name = "Documento" Or c1grdBusqueda.Cols(e.Col).Name = "ENTID_Proveedor" Then
            If c1grdBusqueda.Rows(e.Row)("DOCCO_Estado") = EABAS_DocsCompra.getEstado(EABAS_DocsCompra.Estado.Confirmado) Then
               e.Style = c1grdBusqueda.Styles("Facturado")
            End If
         End If
         If c1grdBusqueda.Rows(e.Row)("DOCCO_Estado") = EABAS_DocsCompra.getEstado(EABAS_DocsCompra.Estado.Anulado) Then
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
         If TypeOf ActiveControl Is ACControles.ACTextBoxAyuda And ActiveControl.Name = "actxaProdCodigo" Then
            Exit Sub
         End If

         SendKeys.Send("{TAB}")
      End If
   End Sub

   Private Sub TRegCompra_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
      btnConsultar_Click(Nothing, Nothing)
   End Sub

   Private Sub AcFecha_ACFecIni_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles acFecha.ACFecIni_KeyDown
      If e.KeyData = Keys.Enter Then
         acFecha.ACDtpFecha_A.Focus()
      End If
   End Sub

   Private Sub AcFecha_ACFecFin_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles acFecha.ACFecFin_KeyDown
      If e.KeyData = Keys.Enter Then
         btnConsultar_Click(Nothing, Nothing)
      End If
   End Sub

#End Region

   Private Sub actxaProvCodigo_KeyDown(sender As Object, e As KeyEventArgs) Handles actxaProvRuc.KeyDown
      Try
         If e.KeyData = Keys.Enter Then
            If actxaProvRuc.Text.ToString().Length >= Constantes.LongitudCodigo Then
               If actxaProvRuc.Text.ToString().Length >= Constantes.LongitudCodigo Then
                  '' Cargar datos adicionales cliente
                  If actxaProvRuc.ACAyuda.Enabled = True Then
                     If managerEntidades.CargarDocIden(actxaProvRuc.Text, EEntidades.TipoInicializacion.Proveedor) Then
                        '' Cargar datos del cliente   
                        m_eabas_docscompra.ENTID_CodigoProveedor = managerEntidades.Entidades.ENTID_Codigo
                        m_eentidades = managerEntidades.Entidades

                        actxaProvRazonSocial.Text = managerEntidades.Entidades.ENTID_RazonSocial
                        actxaProvRuc.Text = managerEntidades.Entidades.ENTID_NroDocumento
                        'cargarProveedor(managerEntidades.Proveedor.ENTID_Codigo)
                        grpDocumento.Focus()
                        pnlDetCabecera.Enabled = True
                     Else
                        If ACControles.ACDialogos.ACMostrarMensajePregunta(String.Format("Documento de Identidad: {0}", Me.Text) _
                                        , String.Format("El Documento de Identidad {0} no existe, ¿Desea Ingresar la Entidad?", actxaProvRuc.Text) _
                                        , ACControles.ACDialogos.LabelBotom.Si_No) = DialogResult.Yes Then
                           NuevoProveedor(actxaProvRuc.Text)
                        Else
                           btnClean_Click(Nothing, Nothing)

                        End If
                     End If
                  End If
               Else
                  ACControles.ACDialogos.ACMostrarMensajeInformacion(String.Format("Información: {0}", Me.Text), String.Format("El Documento de Identidad {0} no existe, el documento ingresado tienen menos de 8 numeros", actxaProvRuc.Text))
                  btnClean_Click(Nothing, Nothing)

               End If
            Else
               If actxaProvRuc.Text.Trim().Length > 0 Then

               End If
            End If
         End If
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso Cargar Proveedor", ex)
      End Try
   End Sub

   Private Sub dtpFecha_ValueChanged(sender As Object, e As EventArgs) Handles dtpFecha.ValueChanged
      Try
         Dim _btipocambio As New BTipoCambio
         If _btipocambio.getTipoCambioSunat(dtpFecha.Value) Then
            actxnTipoCambio.Text = _btipocambio.TipoCambio.TIPOC_VentaSunat
         End If
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), String.Format(Colecciones.getError("00101"), "Cambiar la fecha de facturacion"), ex)
      End Try
   End Sub

   Private Sub txtCodigoSAP_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCodigoSAP.KeyDown
      If e.KeyData = Keys.Enter Then
         KeyPreview = False
         acTool.Focus()
         acTool.ACBtnGrabar.Select()
      End If
   End Sub

    Private Sub Label23_Click(sender As Object, e As EventArgs) Handles Label23.Click

    End Sub

    Private Sub grpCosteo_Enter(sender As Object, e As EventArgs) Handles grpCosteo.Enter

    End Sub

    Private Sub tabMantenimiento_SelectionChanged(sender As Crownwood.DotNetMagic.Controls.TabControl, oldPage As Crownwood.DotNetMagic.Controls.TabPage, newPage As Crownwood.DotNetMagic.Controls.TabPage) Handles tabMantenimiento.SelectionChanged

    End Sub

    Private Sub tscmbDestino_Click(sender As Object, e As EventArgs) Handles tscmbDestino.Click

    End Sub

    Private Sub TRegCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub tsbtnExcel_Click(sender As Object, e As EventArgs) Handles tsbtnExcel.Click
        Try
            Utilitarios.ExportarXLS(c1grdDetalle, "Registro de Compras")
        Catch ex As Exception
            ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso Exportar a Excel", ex)
        End Try
    End Sub


End Class