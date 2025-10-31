Imports ACBLogistica
Imports ACBVentas
Imports ACELogistica
Imports ACEVentas
Imports ACFramework

Imports Microsoft.Practices.Unity
Imports C1.Win.C1FlexGrid

Public Class TRegIngrMercaderia2
#Region " Variables "
   Private managerGenerarRegMercTransito As BGenerarRegMercTransito
   Private managerABAS_IngresosCompra As BABAS_IngresosCompra
   Private managerEntidades As BEntidades

   Private m_eentidades As EEntidades

   Private bs_detabas_ingresoscompra As BindingSource
   Private bs_abas_ingresocompras As BindingSource
   Private bs_tipodocingreso As BindingSource
   Private bs_tipodocumento As BindingSource

   Private m_listBindHelper As List(Of ACBindHelper)

   Private m_order As Integer = 1

   Private m_frmconsultas As COrdenesCompras
#End Region

#Region " Propiedades "

#End Region

#Region " Constructores "
   Public Sub New()

      ' This call is required by the designer.
      InitializeComponent()

      ' Add any initialization after the InitializeComponent() call.
      Try
         Inicializar()
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), Colecciones.getError("00000"), ex)
      End Try
   End Sub

   Private Sub Inicializar()
      Try
         tabMantenimiento.HideTabsMode = Crownwood.DotNetMagic.Controls.HideTabsModes.HideAlways
         tabMantenimiento.SelectedTab = tabBusqueda
         '' Inicializar los componentes con Unity
         'managerABAS_DocsCompra = new BABAS_DocsCompra)("abas_docscompraDAO")
         managerGenerarRegMercTransito = New BGenerarRegMercTransito(GApp.Periodo)
         managerABAS_IngresosCompra = New BABAS_IngresosCompra
         managerEntidades = New BEntidades
         '' Iniciarlizar los componentes graficos
         formatearGrilla()
         cargaCombos()
         '' Aplicar el titulo segun el tipo de documento que se va a cargar
         Me.Text = acpnlTitulo.ACCaption

         setInstancia(ACUtilitarios.ACSetInstancia.Deshacer)
         Me.Icon = Icon.FromHandle(ACPLogistica.My.Resources.Cotizacion_16x16.GetHicon)


      Catch ex As Exception
         Throw ex
      End Try
   End Sub
#End Region

#Region " Metodos "
   Private Sub formatearGrilla()
      Dim index As Integer = 1
      Try
         index = 1
         ACFrameworkC1.ACUtilitarios.ACFormatearGrilla(c1grdDetalle, 1, 1, 9, 1, 0)
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdDetalle, index, "Item", "INGCD_Item", "INGCD_Item", 40, True, False, "System.String") : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdDetalle, index, "Codigo", "ARTIC_Codigo", "ARTIC_Codigo", 107, True, False, "System.String") : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdDetalle, index, "Descripción", "ARTIC_Descripcion", "ARTIC_Descripcion", 275, True, False, "System.String") : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdDetalle, index, "Unidad", "TIPOS_UnidadMedida", "TIPOS_UnidadMedida", 70, True, False, "System.String") : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdDetalle, index, "Cant. Total", "INGCD_CantidadTotal", "INGCD_CantidadTotal", 70, True, False, "System.Decimal", Parametros.GetParametro(EParametros.TipoParametros.pg_FMondo2d)) : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdDetalle, index, "Entregado", "Entregado", "Entregado", 95, True, False, "System.Decimal", Parametros.GetParametro(EParametros.TipoParametros.pg_FMondo2d)) : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdDetalle, index, "Pendiente", "Pendiente", "Pendiente", 0, False, False, "System.Decimal", Parametros.GetParametro(EParametros.TipoParametros.pg_FMondo2d)) : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdDetalle, index, "Cantidad", "INGCD_Cantidad", "INGCD_Cantidad", 95, True, True, "System.Decimal", Parametros.GetParametro(EParametros.TipoParametros.pg_FMondo2d)) : index += 1

         c1grdDetalle.AllowEditing = True
         c1grdDetalle.AutoResize = False
         c1grdDetalle.Cols(0).Width = 18
         c1grdDetalle.Styles.Alternate.BackColor = Color.LightGray
         c1grdDetalle.Styles.Fixed.TextAlign = TextAlignEnum.CenterCenter
         c1grdDetalle.Styles.Highlight.BackColor = Color.Gray
         c1grdDetalle.SelectionMode = SelectionModeEnum.Row
         c1grdDetalle.AllowResizing = AllowResizingEnum.None
         c1grdDetalle.ExtendLastCol = True

         index = 1
         ACFrameworkC1.ACUtilitarios.ACFormatearGrilla(c1grdMTBusqueda, 1, 1, 12, 1, 2)
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdMTBusqueda, index, "Codigo", "ENTID_CodigoProveedor", "ENTID_CodigoProveedor", 150, False, False, "System.String") : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdMTBusqueda, index, "Fecha", "INGCO_FechaDocumento", "INGCO_FechaDocumento", 150, True, False, "System.DateTime") : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdMTBusqueda, index, "Codigo", "INGCO_Codigo", "INGCO_Codigo", 150, True, False, "System.String") : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdMTBusqueda, index, "Documento", "Documento", "Documento", 150, True, False, "System.String") : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdMTBusqueda, index, "Doc. Ref.", "Referencia", "Referencia", 150, True, False, "System.String") : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdMTBusqueda, index, "Doc. Compra", "DocCompra", "DocCompra", 150, True, False, "System.String") : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdMTBusqueda, index, "Almacen", "ALMAC_Descripcion", "ALMAC_Descripcion", 150, True, False, "System.String") : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdMTBusqueda, index, "Codigo", "ENTID_CodigoProveedor", "ENTID_CodigoProveedor", 150, True, False, "System.String") : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdMTBusqueda, index, "Proveedor", "ENTID_Proveedor", "ENTID_Proveedor", 150, True, False, "System.String") : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdMTBusqueda, index, "Estado", "INGCO_Estado_Text", "INGCO_Estado_Text", 150, True, False, "System.String") : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdMTBusqueda, index, "COTCO_Estado", "INGCO_Estado", "INGCO_Estado", 150, False, False, "System.String") : index += 1

         c1grdMTBusqueda.AllowEditing = False
         c1grdMTBusqueda.AllowSorting = AllowSortingEnum.SingleColumn
         c1grdMTBusqueda.Styles.Alternate.BackColor = Color.LightGray
         c1grdMTBusqueda.Styles.Fixed.TextAlign = TextAlignEnum.CenterCenter
         c1grdMTBusqueda.Styles.Highlight.BackColor = Color.Gray
         c1grdMTBusqueda.SelectionMode = SelectionModeEnum.Row

         Dim tt As C1.Win.C1FlexGrid.CellStyle = c1grdMTBusqueda.Styles.Add("Facturado")
         tt.BackColor = Color.LightGreen
         tt.ForeColor = Color.DarkBlue
         tt.Font = New Font(c1grdMTBusqueda.Font, FontStyle.Regular)

         Dim uu As C1.Win.C1FlexGrid.CellStyle = c1grdMTBusqueda.Styles.Add("Facturar")
         uu.BackColor = Color.Green
         uu.ForeColor = Color.White
         uu.Font = New Font(c1grdMTBusqueda.Font, FontStyle.Regular)

         Dim dd As C1.Win.C1FlexGrid.CellStyle = c1grdMTBusqueda.Styles.Add("Anulado")
         dd.BackColor = Color.Red
         dd.ForeColor = Color.White
         dd.Font = New Font(c1grdMTBusqueda.Font, FontStyle.Bold)
         c1grdMTBusqueda.DrawMode = C1.Win.C1FlexGrid.DrawModeEnum.OwnerDraw

         c1grdMTBusqueda.SubtotalPosition = SubtotalPositionEnum.AboveData
         c1grdMTBusqueda.Tree.Column = 2

         Dim s As CellStyle = c1grdMTBusqueda.Styles(CellStyleEnum.Subtotal0)
         s.BackColor = Color.White
         s.ForeColor = Color.Red
         s.Font = New Font(c1grdMTBusqueda.Font, FontStyle.Bold)
      Catch ex As Exception
         Throw ex
      End Try
   End Sub

   Private Sub cargaCombos()
      Try
         bs_tipodocingreso = New BindingSource
         bs_tipodocingreso.DataSource = Colecciones.TiposDocMerTransito
         ACFramework.ACUtilitarios.ACCargaCombo(cmbTipoDoc, bs_tipodocingreso, "TIPOS_Descripcion", "TIPOS_Codigo")
         AddHandler bs_tipodocingreso.CurrentChanged, AddressOf bs_tipodocingreso_CurrentChanged
         bs_tipodocingreso_CurrentChanged(Nothing, Nothing)

         bs_tipodocumento = New BindingSource : bs_tipodocumento.DataSource = Colecciones.TiposDocMerTransito()
         AddHandler bs_tipodocumento.CurrentChanged, AddressOf bs_tipodocumento_CurrentChanged
         ACUtilitarios.ACCargaCombo(cmbDocumento, bs_tipodocumento, "TIPOS_Descripcion", "TIPOS_Codigo")

         ACUtilitarios.ACCargaCombo(ComboBox1, Colecciones.Almacenes, "ALMAC_Descripcion", "ALMAC_Id", GApp.Almacen)

         ComboBox1.Enabled = False
         Label4.Enabled = False
      Catch ex As Exception
         Throw ex
      End Try
   End Sub

   Private Sub bs_tipodocingreso_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
      Try
         If CType(bs_tipodocingreso.Current, ETipos).TIPOS_Codigo = ETipos.getTipoComprobante(ETipos.TipoComprobanteVenta.RegistroMercaderia) Then
            txtSerie.Enabled = False
            actxnNumero.Enabled = False
         Else
            txtSerie.Enabled = True
            actxnNumero.Enabled = True
         End If
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError("Error: " & Me.Text, "Ocurrio un error en el proceso <Procesos>", ex)
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
            If actxnNumero.Text > 7 Then actxnNumero.Text = actxnNumero.Text.Substring(0, 7)
            txtSerie.MaxLength = 3 : actxnNumero.MaxLength = 7
         End If
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso <Procesos>", ex)
      End Try
   End Sub

   Private Sub setInstancia(ByVal _opcion As ACUtilitarios.ACSetInstancia)
      acTool.ACBtnModificarVisible = False
      Select Case _opcion
         Case ACUtilitarios.ACSetInstancia.Nuevo
            ACUtilitarios.ACLimpiaVar(pnlCabecera)
            ACUtilitarios.ACLimpiaVar(pnlItem)
            ACUtilitarios.ACLimpiaVar(grpDocReferencia)
            actsbtnPrevisualizar.Visible = False
            pnlItem.Enabled = False
            tabMantenimiento.SelectedTab = tabDatos
         Case ACUtilitarios.ACSetInstancia.Modificado
            pnlItem.Enabled = True
            c1grdDetalle.Focus()
            actsbtnPrevisualizar.Visible = True
            tabMantenimiento.SelectedTab = tabDatos
         Case ACUtilitarios.ACSetInstancia.Guardar
            txtBusqueda.Focus()
            actsbtnPrevisualizar.Visible = True
            tabMantenimiento.SelectedTab = tabDatos
         Case ACUtilitarios.ACSetInstancia.Deshacer
            actsbtnPrevisualizar.Visible = True
            acTool.ACBtnBuscarVisible = False
            tabMantenimiento.SelectedTab = tabBusqueda
         Case ACUtilitarios.ACSetInstancia.Previsualizar
            ACUtilitarios.ACSetControl(pnlCabecera, True, ACUtilitarios.TipoPropiedad.ACReadOnly)
            ACUtilitarios.ACSetControl(grpDocReferencia, True, ACUtilitarios.TipoPropiedad.ACReadOnly)
            pnlItem.Enabled = False
            acTool.setInstancia(ACControles.ACToolBarMantHorizontalNew.TipoInstancia.Nuevo)
            acTool.ACBtnGrabarVisible = False
            'acTool.ACBtnRehusarVisible = True
            actsbtnPrevisualizar.Visible = False
            tabMantenimiento.SelectedTab = tabDatos
      End Select
   End Sub

   ''' <summary>
   ''' Ejecutar la busqueda de una cadena en la tabla Neumaticos
   ''' </summary>
   ''' <param name="x_cadena">Cadena objetivo</param>
   ''' <returns></returns>
   Private Function busquedaDatos(ByVal x_cadena As String) As Boolean
      Try
         'If txtBusqueda.ACEstadoAutoAyuda Then
         If managerABAS_IngresosCompra.Busqueda(x_cadena, getMTCampo(), chkMTTodos.Checked, AcFecha.ACDtpFecha_De.Value.Date, AcFecha.ACDtpFecha_A.Value.Date.AddDays(1)) Then
            acTool.ACBtnEliminarEnabled = True
            acTool.ACBtnModificarEnabled = True
         Else
            acTool.ACBtnEliminarEnabled = False
            acTool.ACBtnModificarEnabled = False
         End If
         MTcargarDatos()
         'End If
         Return acTool.ACBtnEliminarEnabled
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Convert.ToString(Text)), "No se puede cargar la ayuda de los conductores", ex)
      End Try
      Return False
   End Function

   Private Function getMTCampo() As String
      Try
         If (rbtnMTProveedor.Checked) Then
            Return "ENTID_RazonSocial"
         ElseIf rbtnOCOrdeCompra.Checked Then
            Return "DOCCO_Codigo"
         Else
            Return "ENTID_RazonSocial"
         End If
      Catch ex As Exception
         Throw ex
      End Try
   End Function

   ''' <summary>
   ''' Cargar los datos en el control Visual C1FlexGrid
   ''' </summary>
   Private Sub MTCargarDatos()
      Try
         bs_abas_ingresocompras = New BindingSource()
         bs_abas_ingresocompras.DataSource = managerABAS_IngresosCompra.ListABAS_IngresosCompra
         c1grdMTBusqueda.DataSource = bs_abas_ingresocompras
         bnavProductos.BindingSource = bs_abas_ingresocompras
         AddHandler bs_abas_ingresocompras.CurrentChanged, AddressOf bs_detordencompra_CurrentChanged
         bs_detordencompra_CurrentChanged(Nothing, Nothing)
         chkAgrupar_CheckedChanged(Nothing, Nothing)
      Catch ex As Exception
         Throw ex
      End Try
   End Sub

   Private Sub OrdenarPedidos(ByVal x_columna As String)
      Dim _ordenador As New ACOrdenador(Of EABAS_IngresosCompra)
      Try
         If m_order = 2 Then x_columna += " DESC"
         _ordenador.ACOrdenamiento = x_columna
         CType(bs_abas_ingresocompras.DataSource, List(Of EABAS_IngresosCompra)).Sort(_ordenador)
         c1grdMTBusqueda.Refresh()
         m_order = IIf(m_order = 1, 2, 1)
      Catch ex As Exception
         Throw ex
      End Try
   End Sub

   Private Sub AyudaEntidad(ByVal x_cadenas As String, ByVal x_campo As String, ByVal x_opcion As EEntidades.TipoEntidad)
      Try
         Me.KeyPreview = False
         Dim _where As New Hashtable
         _where.Add(x_campo, New ACWhere(x_cadenas, ACWhere.TipoWhere._Like))
         If managerEntidades.Ayuda(_where, x_opcion) Then
            Dim Ayuda As New ACControlesC1.ACAyudaFlex("Buscar Entidad", managerEntidades.DTEntidades, False)
            If Ayuda.ShowDialog() = Windows.Forms.DialogResult.OK Then
               Select Case x_opcion
                  Case EEntidades.TipoEntidad.ProveedoresLogistica
                     '' Cargar datos del cliente
                     managerGenerarRegMercTransito.BABAS_IngresosCompra.ABAS_IngresosCompra.ENTID_CodigoProveedor = Ayuda.Respuesta.Rows(0)("Codigo")
                     If managerEntidades.Cargar(managerGenerarRegMercTransito.BABAS_IngresosCompra.ABAS_IngresosCompra.ENTID_CodigoProveedor, EEntidades.TipoInicializacion.Proveedor) Then
                        'actxaProvCodigo.Text = managerEntidades.Entidades.ENTID_Codigo
                        actxaProvRazonSocial.Text = managerEntidades.Entidades.ENTID_RazonSocial
                        actxaProvRuc.Text = managerEntidades.Entidades.ENTID_NroDocumento
                        '' Cargar datos adicionales del proveedor
                     End If
                     '' Cargar datos adicionales del proveedor
                     pnlItem.Enabled = True
                     actxaProdCodigo.Focus()
                     Me.KeyPreview = True
                  Case EEntidades.TipoEntidad.Vendedores
                     Dim x_entid_codigo As String = Ayuda.Respuesta.Rows(0)("Codigo")
               End Select
            End If
         Else
            ACControles.ACDialogos.ACMostrarMensajeInformacion(String.Format("Información: {0}", Me.Text), "No se puede cargar la ayuda, posiblemente no hay datos que mostrar por que no hay coincidencias en la busqueda")
         End If
      Catch ex As Exception
         Throw ex
      End Try
   End Sub

   Private Sub NuevoProveedor(ByVal x_entid_nrodocumento As String)
      Try
         Dim frmEntidad As New MEntidad(MEntidad.Inicio.NuevaEntidad, ACEVentas.EEntidades.TipoEntidad.Clientes)
         frmEntidad.StartPosition = FormStartPosition.CenterScreen
         If x_entid_nrodocumento.Length > 0 Then
            frmEntidad.EEntidad.ENTID_NroDocumento = x_entid_nrodocumento
            frmEntidad.lblNombres.Focus()
         End If
         If frmEntidad.ShowDialog() = Windows.Forms.DialogResult.OK Then
            m_eentidades = frmEntidad.EEntidad
            managerGenerarRegMercTransito.BABAS_IngresosCompra.ABAS_IngresosCompra.ENTID_CodigoProveedor = m_eentidades.ENTID_Codigo

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
            'cargarProveedor(managerEntidades.Cliente.ENTID_CodigoVendedor)
            'cargarProveedor(IIf(IsNothing(managerEntidades.Cliente), Parametros.GetParametro(EParametros.TipoParametros.pg_VendedorDefa), managerEntidades.Cliente.ENTID_CodigoVendedor))
            'setRolProveedor(IIf(getFilterRol(), Seteo.Activar, Seteo.Desactivar))
            pnlItem.Enabled = True
            'calcular()
         End If
      Catch ex As Exception
         Throw ex
      End Try
   End Sub

   Private Sub AsignarBinding()
      Try
         m_listBindHelper = New List(Of ACBindHelper)()
         m_listBindHelper.Add(ACBindHelper.ACBind(txtCodigo, "Text", managerGenerarRegMercTransito.ABAS_IngresosCompra, "INGCO_Codigo"))
         If managerGenerarRegMercTransito.ABAS_IngresosCompra.INGCO_FechaDocumento.Year < 1700 Then managerGenerarRegMercTransito.ABAS_IngresosCompra.INGCO_FechaDocumento = DateTime.Now
         m_listBindHelper.Add(ACBindHelper.ACBind(dtpFecEmision, "Value", managerGenerarRegMercTransito.ABAS_IngresosCompra, "INGCO_FechaDocumento"))
         m_listBindHelper.Add(ACBindHelper.ACBind(actxaProvRuc, "Text", managerGenerarRegMercTransito.ABAS_IngresosCompra, "ENTID_CodigoProveedor"))
         m_listBindHelper.Add(ACBindHelper.ACBind(cmbTipoDoc, "SelectedValue", managerGenerarRegMercTransito.ABAS_IngresosCompra, "TIPOS_CodTipoDocumento"))
         m_listBindHelper.Add(ACBindHelper.ACBind(txtSerie, "Text", managerGenerarRegMercTransito.ABAS_IngresosCompra, "INGCO_Serie"))
         m_listBindHelper.Add(ACBindHelper.ACBind(actxnNumero, "Text", managerGenerarRegMercTransito.ABAS_IngresosCompra, "INGCO_Numero"))
      Catch ex As Exception
         Throw ex
      End Try
   End Sub
#End Region

#Region " Metodos de Controles"

   Private Sub _KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
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

   Private Sub AcFecha_ACFecIni_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles acFecha.ACFecIni_KeyDown
      If e.KeyData = Keys.Enter Then
         AcFecha.ACDtpFecha_A.Focus()
      End If
   End Sub

   Private Sub AcFecha_ACFecFin_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles acFecha.ACFecFin_KeyDown
      If e.KeyData = Keys.Enter Then
         btnMTConsultar_Click(Nothing, Nothing)
      End If
   End Sub

   Private Sub btnMTConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMTConsultar.Click
      txtMTBusqueda_ACAyudaClick(Nothing, Nothing)
   End Sub

   Private Sub txtMTBusqueda_ACAyudaClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBusqueda.ACAyudaClick
      Try
         busquedaDatos(txtBusqueda.Text)
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Convert.ToString(Text)), "No se puede cargar la ayuda de los conductores", ex)
      End Try
   End Sub

   Private Sub bs_detordencompra_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
      Try
         If Not IsNothing(bs_abas_ingresocompras.Current) Then
            If CType(bs_abas_ingresocompras.Current, EABAS_IngresosCompra).INGCO_Estado = EABAS_IngresosCompra.getEstado(EABAS_IngresosCompra.Estado.Confirmado) Then
               acTool.ACBtnModificarEnabled = False
               acTool.ACBtnAnularEnabled = False
            Else
               acTool.ACBtnModificarEnabled = True
               acTool.ACBtnAnularEnabled = True
            End If
         End If
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso Cargar Propiedades del Cotización/Pedido", ex)
      End Try
   End Sub

   Private Sub chkAgrupar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAgrupar.CheckedChanged
      Try
         If chkAgrupar.Checked Then
            OrdenarPedidos("ENTID_CodigoProveedor")
            c1grdMTBusqueda.Subtotal(AggregateEnum.Sum, 1, 1, 1, 1, "Proveedor: {0}")
         Else
            c1grdMTBusqueda.Subtotal(AggregateEnum.Clear)
         End If
         c1grdMTBusqueda.AutoSizeCols()
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Convert.ToString(Text)), "No se agrupar resultados", ex)
      End Try
   End Sub

   Private Sub acTool_ACBtnCancelar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles acTool.ACBtnCancelar_Click
      Try
         setInstancia(ACUtilitarios.ACSetInstancia.Deshacer)
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), String.Format(Colecciones.getError("00101"), "Cancelar registro de mercaderia"), ex)
      End Try
   End Sub

   Private Sub acTool_ACBtnGrabar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles acTool.ACBtnGrabar_Click
      Try
         setInstancia(ACUtilitarios.ACSetInstancia.Deshacer)
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), String.Format(Colecciones.getError("00101"), "Grabar registro de mercaderia"), ex)
      End Try
   End Sub

   Private Sub acTool_ACBtnNuevo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles acTool.ACBtnNuevo_Click
      Try
         m_frmconsultas = Nothing
         setInstancia(ACUtilitarios.ACSetInstancia.Nuevo)
         managerGenerarRegMercTransito.BABAS_IngresosCompra = New BABAS_IngresosCompra
         managerGenerarRegMercTransito.ABAS_IngresosCompra = New EABAS_IngresosCompra
         AsignarBinding()

         bs_detabas_ingresoscompra = New BindingSource
         bs_detabas_ingresoscompra.DataSource = managerGenerarRegMercTransito.ABAS_IngresosCompra.ListABAS_IngresosCompraDetalle
         c1grdDetalle.DataSource = bs_detabas_ingresoscompra
         bnavProductos.BindingSource = bs_detabas_ingresoscompra

      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), String.Format(Colecciones.getError("00101"), "Nuevo Registro de Mercaderia"), ex)
      End Try
   End Sub

   Private Sub acTool_ACBtnSalir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles acTool.ACBtnSalir_Click
      Me.Close()
   End Sub

   Private Sub actxaProvCodigo_ACAyudaClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles actxaProvRuc.ACAyudaClick
      Try
         AyudaEntidad(actxaProvRuc.Text, "ENTID_NroDocumento", EEntidades.TipoEntidad.Proveedores)
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso Documento de Identidad", ex)
      End Try
   End Sub

   Private Sub actxaProvNombres_ACAyudaClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles actxaProvRazonSocial.ACAyudaClick
      Try
         AyudaEntidad(actxaProvRazonSocial.Text, "ENTID_RazonSocial", EEntidades.TipoEntidad.ProveedoresLogistica)
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso busqueda de cliente por Nombre/Razon Social", ex)
      End Try
   End Sub

   Private Sub actxaProvRuc_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles actxaProvRuc.KeyDown
      Try
         If e.KeyData = Keys.Enter Then
            If actxaProvRuc.Text.ToString().Length >= Constantes.LongitudCodigo Then
               '' Cargar datos adicionales cliente
               If actxaProvRuc.ACAyuda.Enabled = True Then
                  If managerEntidades.CargarDocIden(actxaProvRuc.Text, EEntidades.TipoInicializacion.Proveedor) Then
                     '' Cargar datos del cliente   
                     managerGenerarRegMercTransito.ABAS_IngresosCompra.ENTID_CodigoProveedor = managerEntidades.Entidades.ENTID_Codigo
                     m_eentidades = managerEntidades.Entidades

                     actxaProvRazonSocial.Text = managerEntidades.Entidades.ENTID_RazonSocial
                     actxaProvRuc.Text = managerEntidades.Entidades.ENTID_NroDocumento
                     'cargarProveedor(managerEntidades.Proveedor.ENTID_Codigo)
                     'setRolProveedor(IIf(getFilterRol(), Seteo.Activar, Seteo.Desactivar))
                     pnlItem.Enabled = True
                  Else
                     If ACControles.ACDialogos.ACMostrarMensajePregunta(String.Format("Documento de Identidad: {0}", Me.Text) _
                                     , String.Format("El Documento de Identidad {0} no existe, ¿Desea Ingresar la Entidad?", actxaProvRuc.Text) _
                                     , ACControles.ACDialogos.LabelBotom.Si_No) = DialogResult.Yes Then
                        NuevoProveedor(actxaProvRuc.Text)
                     Else
                        btnClean_Click(Nothing, Nothing)
                        Label4.Focus()
                     End If
                  End If
               End If
            Else
               ACControles.ACDialogos.ACMostrarMensajeInformacion(String.Format("Información: {0}", Me.Text), String.Format("El Documento de Identidad {0} no existe, el documento ingresado tienen menos de 8 numeros", actxaProvRuc.Text))
               btnClean_Click(Nothing, Nothing)
               Label4.Focus()
            End If
         End If
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso Cargar Cliente", ex)
      End Try
   End Sub

   Private Sub btnClean_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClean.Click
      Try
         m_eentidades = New EEntidades
         'actxaProvCodigo.Clear()
         actxaProvRazonSocial.Clear()
         actxaProvRuc.Clear()
         'setRol(Constantes.Seteo.Activar)
         pnlItem.Enabled = False
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso Limpiar Entidad", ex)
      End Try
   End Sub
#End Region

   Private Function getOpcion() As BGenerarRegMercTransito.TConsulta
      If RadioButton1.Checked Then
         Return BGenerarRegMercTransito.TConsulta.Ordenes
      ElseIf RadioButton2.Checked Then
         Return BGenerarRegMercTransito.TConsulta.Compras
      End If
   End Function

   Private Function CargarDatos() As Boolean
      Try
         If getOpcion() = BGenerarRegMercTransito.TConsulta.Compras Then
            managerGenerarRegMercTransito.ABAS_DocsCompra = New BABAS_DocsCompra
            managerGenerarRegMercTransito.ABAS_DocsCompra.ABAS_DocsCompra = m_frmconsultas.ABAS_DocsCompra
         ElseIf getOpcion() = BGenerarRegMercTransito.TConsulta.Ordenes Then
            managerGenerarRegMercTransito.ABAS_OrdenesCompra = New BABAS_OrdenesCompra
            managerGenerarRegMercTransito.ABAS_OrdenesCompra.ABAS_OrdenesCompra = m_frmconsultas.ABAS_OrdenesCompra
         End If
         Return managerGenerarRegMercTransito.ConvertToIngreso(getOpcion())
      Catch ex As Exception
         Throw ex
      End Try
   End Function

   Private Sub actxaOrdenCompra_ACAyudaClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles actxaOrdenCompra.ACAyudaClick
      Try
         If IsNothing(m_frmconsultas) Then m_frmconsultas = New COrdenesCompras(getOpcion()) With {.StartPosition = FormStartPosition.CenterScreen}
         If m_frmconsultas.ShowDialog() = Windows.Forms.DialogResult.OK Then
            CargarDatos()
         End If
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), String.Format(Colecciones.getError("00101"), "Ayuda de Orde de Compra/Doc. de Compra"), ex)
      End Try
   End Sub
End Class