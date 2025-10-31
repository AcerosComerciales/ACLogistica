Imports ACBLogistica
Imports ACBVentas
Imports ACELogistica
Imports ACEVentas
Imports ACFramework

Imports Microsoft.Practices.Unity
Imports C1.Win.C1FlexGrid

Public Class TRegMerTransito

#Region " Variables "

   Private m_order As Integer = 1
   Private managerABAS_DocsCompra As BABAS_DocsCompra
   Private managerABAS_IngresosCompra As BABAS_IngresosCompra
   Private managerGenerarRegMercTransito As BGenerarRegMercTransito

   Private m_listBindHelper As List(Of ACBindHelper)

   Private bs_abas_doccompra As BindingSource
   Private bs_detabas_ingresoscompra As BindingSource

   Private m_eabas_ingresoscompra As EABAS_IngresosCompra
   Private m_earticulos As EArticulos

   Private m_modArticulo As Boolean = False


   Enum Inicializacion
      Base
      Consulta
   End Enum

#End Region

#Region " Propiedades "

#End Region

#Region " Constructores "
   Public Sub New(ByVal x_opcion As Inicializacion, ByVal x_codigo As Long, ByVal x_almac_id As Short, ByVal x_entid_codigo As String)
      ' This call is required by the Windows Form Designer.
      InitializeComponent()
      ' Add any initialization after the InitializeComponent() call.
      Try
         Inicializar()

         Select Case x_opcion
            Case Inicializacion.Base

            Case Inicializacion.Consulta
               Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
               Me.WindowState = FormWindowState.Maximized
               Me.tabMantenimiento.SelectedTab = tabDatos
               Me.acpnlTitulo.Visible = False
               Me.acTool.Visible = False
               'Me.pnlItem.Visible = False
               Me.grpDocReferencia.Enabled = False
               cargar(x_codigo, x_almac_id)
               Me.pnlItem.Size = New Size(Me.pnlItem.Size.Width, 0)
               c1grdDetalle.ExtendLastCol = False
               c1grdDetalle.AllowResizing = AllowResizingEnum.Columns
               c1grdDetalle.AutoResize = True
               c1grdDetalle.AllowEditing = False
               c1grdDetalle.Cols("Entregado").Visible = False
               c1grdDetalle.AutoSizeCols()
            Case Else

         End Select

      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "No se puede cargar los controles iniciales", ex)
      End Try
   End Sub

   Public Sub New()

      ' This call is required by the Windows Form Designer.
      InitializeComponent()
      ' Add any initialization after the InitializeComponent() call.
      Try
         Inicializar()
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "No se puede cargar los controles iniciales", ex)
      End Try
   End Sub

   Private Sub Inicializar()
      Try
         tabMantenimiento.HideTabsMode = Crownwood.DotNetMagic.Controls.HideTabsModes.HideAlways
         tabMantenimiento.SelectedTab = tabBusqueda
         '' Inicializar los componentes con Unity
         managerABAS_DocsCompra = New BABAS_DocsCompra
         managerGenerarRegMercTransito = New BGenerarRegMercTransito(GApp.Periodo)
         managerABAS_IngresosCompra = New BABAS_IngresosCompra
         '' Iniciarlizar los componentes graficos
         formatearGrilla()
         cargaCombos()
         '' Aplicar el titulo segun el tipo de documento que se va a cargar
         Me.Text = acpnlTitulo.ACCaption

         setInstancia(ACUtilitarios.ACSetInstancia.Deshacer)
      Catch ex As Exception
         Throw ex
      End Try
   End Sub
#End Region

#Region " Metodos "
   ''' <summary>
   ''' Ejecutar la busqueda de una cadena en la tabla Neumaticos
   ''' </summary>
   ''' <param name="x_cadena">Cadena objetivo</param>
   ''' <returns></returns>
   Private Function busqueda(ByVal x_cadena As String, Optional ByVal x_documento As Boolean = False) As Boolean
      Try
         If x_documento Then
            If managerGenerarRegMercTransito.BusquedaDocsRegCompra(cmbTipoDocumento.SelectedValue, txtCSerie.Text, txtBusNumero.Text, chkTodos.Checked, AcFecha.ACDtpFecha_De.Value.Date, AcFecha.ACDtpFecha_A.Value.Date) Then
               acTool.ACBtnEliminarEnabled = True
               acTool.ACBtnModificarEnabled = True
            Else
               acTool.ACBtnEliminarEnabled = False
               acTool.ACBtnModificarEnabled = False
            End If
            cargarDatos()
         Else
            'If txtBusqueda.ACEstadoAutoAyuda Then
            If managerGenerarRegMercTransito.BusquedaDocsRegCompra(x_cadena, getCampo(), chkTodos.Checked, AcFecha.ACDtpFecha_De.Value.Date, AcFecha.ACDtpFecha_A.Value.Date.AddDays(1)) Then
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
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Total Compra", "DOCCO_TotalCompra", "DOCCO_TotalCompra", 150, True, False, "System.Decimal", Parametros.GetParametro(EParametros.TipoParametros.pg_FMondo2d)) : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Tipo Pago", "TIPOS_TipoPago", "TIPOS_TipoPago", 150, True, False, "System.String") : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Documento", "Documento", "Documento", 150, True, False, "System.String") : index += 1
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

         index = 1
         ACFrameworkC1.ACUtilitarios.ACFormatearGrilla(c1grdDetalle, 1, 1, 8, 1, 0)
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdDetalle, index, "Codigo", "ARTIC_Codigo", "ARTIC_Codigo", 107, True, False, "System.String") : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdDetalle, index, "Descripción", "ARTIC_Descripcion", "ARTIC_Descripcion", 315, True, False, "System.String") : index += 1
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
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Text), "No se puede dar formato a la grilla", ex)
      End Try
   End Sub

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

   Private Sub setInstancia(ByVal _opcion As ACUtilitarios.ACSetInstancia)
      acTool.ACBtnModificarVisible = False
      Select Case _opcion
         Case ACUtilitarios.ACSetInstancia.Nuevo
            ACUtilitarios.ACLimpiaVar(pnlCabecera)
            ACUtilitarios.ACLimpiaVar(pnlItem)
            ACUtilitarios.ACLimpiaVar(grpDocReferencia)
            actsbtnPrevisualizar.Visible = False
            pnlItem.Enabled = False
            AddHandler c1grdDetalle.KeyDown, AddressOf c1grdDetalle_KeyDown
         Case ACUtilitarios.ACSetInstancia.Modificado
            pnlItem.Enabled = True
            c1grdDetalle.Focus()
            actsbtnPrevisualizar.Visible = True
            AddHandler c1grdDetalle.KeyDown, AddressOf c1grdDetalle_KeyDown
         Case ACUtilitarios.ACSetInstancia.Guardar
            txtBusqueda.Focus()
            actsbtnPrevisualizar.Visible = True
            RemoveHandler c1grdDetalle.KeyDown, AddressOf c1grdDetalle_KeyDown
         Case ACUtilitarios.ACSetInstancia.Deshacer
            actsbtnPrevisualizar.Visible = True
            RemoveHandler c1grdDetalle.KeyDown, AddressOf c1grdDetalle_KeyDown
         Case ACUtilitarios.ACSetInstancia.Previsualizar
            ACUtilitarios.ACSetControl(pnlCabecera, True, ACUtilitarios.TipoPropiedad.ACReadOnly)
            ACUtilitarios.ACSetControl(grpDocReferencia, True, ACUtilitarios.TipoPropiedad.ACReadOnly)
            pnlItem.Enabled = False
            acTool.setInstancia(ACControles.ACToolBarMantHorizontalNew.TipoInstancia.Nuevo)
            acTool.ACBtnGrabarVisible = False
            'acTool.ACBtnRehusarVisible = True
            actsbtnPrevisualizar.Visible = False
            RemoveHandler c1grdDetalle.KeyDown, AddressOf c1grdDetalle_KeyDown
      End Select
   End Sub

   Private Sub cargaCombos()
      Try
         ACFramework.ACUtilitarios.ACCargaCombo(cmbTipoDoc, Colecciones.TiposDocMerTransito, "TIPOS_Descripcion", "TIPOS_Codigo")
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
#End Region

#Region " Cargar Datos "

   Private Sub cargar(ByVal x_codigo As Long, ByVal x_almac_id As Short)
      Try
         If managerABAS_IngresosCompra.Cargar(x_codigo, x_almac_id, True) Then
            m_eabas_ingresoscompra = New EABAS_IngresosCompra
            m_eabas_ingresoscompra = managerABAS_IngresosCompra.ABAS_IngresosCompra
            AsignarBinding()
            bs_detabas_ingresoscompra = New BindingSource
            bs_detabas_ingresoscompra.DataSource = managerABAS_IngresosCompra.ABAS_IngresosCompra.ListABAS_IngresosCompraDetalle
            c1grdDetalle.DataSource = bs_detabas_ingresoscompra
            bnavProductos.BindingSource = bs_detabas_ingresoscompra
            tabMantenimiento.SelectedTab = tabDatos
            '' Setear Valores
            setInstancia(ACUtilitarios.ACSetInstancia.Previsualizar)
         End If
      Catch ex As Exception
         Throw ex
      End Try
   End Sub
   ''' <summary>
   ''' Cargar los datos en el control Visual C1FlexGrid
   ''' </summary>
   Private Sub cargarDatos()
      Try
         bs_abas_doccompra = New BindingSource()
         bs_abas_doccompra.DataSource = managerGenerarRegMercTransito.ListABAS_DocsCompra
         c1grdBusqueda.DataSource = bs_abas_doccompra
         bnavBusqueda.BindingSource = bs_abas_doccompra
         AddHandler bs_abas_doccompra.CurrentChanged, AddressOf bs_detdoccompra_CurrentChanged
         bs_detdoccompra_CurrentChanged(Nothing, Nothing)
      Catch ex As Exception
         Throw ex
      End Try
   End Sub

   Private Sub bs_detdoccompra_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
      Try
         If Not IsNothing(bs_abas_doccompra.Current) Then
            If CType(bs_abas_doccompra.Current, EABAS_DocsCompra).DOCCO_Estado = EABAS_DocsCompra.getEstado(EABAS_DocsCompra.Estado.Confirmado) Then
               acTool.ACBtnModificarEnabled = False
            Else
               acTool.ACBtnModificarEnabled = True
            End If
         End If
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso Cargar Propiedades del Cotización/Pedido", ex)
      End Try
   End Sub

   ''' <summary>
   ''' Realiza el enlace de los controles visuales con la clase esquema
   ''' </summary>
   Private Sub AsignarBinding()
      Try
         m_listBindHelper = New List(Of ACBindHelper)()
         m_listBindHelper.Add(ACBindHelper.ACBind(txtCodigo, "Text", m_eabas_ingresoscompra, "INGCO_Codigo"))
         If m_eabas_ingresoscompra.INGCO_FechaDocumento.Year < 1700 Then m_eabas_ingresoscompra.INGCO_FechaDocumento = DateTime.Now
         m_listBindHelper.Add(ACBindHelper.ACBind(dtpFecEmision, "Value", m_eabas_ingresoscompra, "INGCO_FechaDocumento"))
         m_listBindHelper.Add(ACBindHelper.ACBind(txtNroOrden, "Text", m_eabas_ingresoscompra, "DOCCO_Codigo"))
         m_listBindHelper.Add(ACBindHelper.ACBind(txtCodProveedor, "Text", m_eabas_ingresoscompra, "ENTID_CodigoProveedor"))
         m_listBindHelper.Add(ACBindHelper.ACBind(cmbTipoDoc, "SelectedValue", m_eabas_ingresoscompra, "TIPOS_CodTipoDocumento"))
         m_listBindHelper.Add(ACBindHelper.ACBind(txtSerie, "Text", m_eabas_ingresoscompra, "INGCO_Serie"))
         m_listBindHelper.Add(ACBindHelper.ACBind(actxnNumero, "Text", m_eabas_ingresoscompra, "INGCO_Numero"))
      Catch ex As Exception
         Throw ex
      End Try
   End Sub
#End Region

#Region " Procesos "

   Private Sub OrdenarPedidos(ByVal x_columna As String)
      Dim _ordenador As New ACOrdenador(Of EABAS_DocsCompra)
      Try
         If m_order = 2 Then x_columna += " DESC"
         _ordenador.ACOrdenamiento = x_columna
         CType(bs_abas_doccompra.DataSource, List(Of EABAS_DocsCompra)).Sort(_ordenador)
         c1grdBusqueda.Refresh()
         m_order = IIf(m_order = 1, 2, 1)
      Catch ex As Exception
         Throw ex
      End Try
   End Sub

   Private Sub subirItem()
      Try
         If IsNothing(CType(bs_detabas_ingresoscompra.Current, EABAS_IngresosCompraDetalle).Articulo) Then
            '' Cargar Producto
            actxaProdCodigo.Text = CType(bs_detabas_ingresoscompra.Current, EABAS_IngresosCompraDetalle).ARTIC_Codigo
            txtProdDescripcion.Text = CType(bs_detabas_ingresoscompra.Current, EABAS_IngresosCompraDetalle).ARTIC_Descripcion
            actxnCantidad.Text = CType(bs_detabas_ingresoscompra.Current, EABAS_IngresosCompraDetalle).INGCD_Cantidad
            m_earticulos = New EArticulos()
            Me.KeyPreview = True
            pnlItem.Enabled = True
            txtProdDescripcion.Focus()
         Else
            m_earticulos = CType(bs_detabas_ingresoscompra.Current, EABAS_IngresosCompraDetalle).Articulo
            setProducto(True)
            pnlItem.Enabled = True
            actxnCantidad.Text = CType(bs_detabas_ingresoscompra.Current, EABAS_IngresosCompraDetalle).INGCD_Cantidad
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
         Else
            actxaProdCodigo.Clear()
            txtProdDescripcion.Clear()
            actxnCantidad.Text = "0.00"
         End If
      Catch ex As Exception
         Throw ex
      End Try
   End Sub

   Private Sub nuevoIngresioCompra()
      Try
         If Not IsNothing(bs_abas_doccompra) Then
            If Not IsNothing(bs_abas_doccompra.Current) Then
               '' Inicializar clase Pedido
               m_eabas_ingresoscompra = New EABAS_IngresosCompra
               m_eabas_ingresoscompra.Instanciar(ACEInstancia.Nuevo)
               '' Instanciar clase
               AsignarBinding()
               setInstancia(ACUtilitarios.ACSetInstancia.Nuevo)
               '' Para Cargar detalle del producto
               bs_detabas_ingresoscompra = New BindingSource
               m_eabas_ingresoscompra.ListABAS_IngresosCompraDetalle = New List(Of EABAS_IngresosCompraDetalle)
               bs_detabas_ingresoscompra.DataSource = m_eabas_ingresoscompra.ListABAS_IngresosCompraDetalle
               c1grdDetalle.DataSource = bs_detabas_ingresoscompra
               bnavProductos.BindingSource = bs_detabas_ingresoscompra
               '' Cargar los datos de la orden de compra
               setIngreso()
               ''
               tabMantenimiento.SelectedTab = tabDatos
            Else
               acTool.setInstancia(ACControles.ACToolBarMantHorizontalNew.TipoInstancia.Cancelar)
               ACControles.ACDialogos.ACMostrarMensajeInformacion(String.Format("Información: {0}", Me.Text), "No se puede iniciar un nuevo ingreso, debe seleccionar un registro")
            End If
         Else
            acTool.setInstancia(ACControles.ACToolBarMantHorizontalNew.TipoInstancia.Cancelar)
            ACControles.ACDialogos.ACMostrarMensajeInformacion(String.Format("Información: {0}", Me.Text), "No se puede iniciar un nuevo ingreso por que no ha cargado ningun registro")
         End If
      Catch ex As Exception
         Throw ex
      End Try
   End Sub

   Private Sub setIngreso()
      Try
         '' Cargar los datos basicos para la cabecera del ingreso
         Dim _ordencompra As EABAS_DocsCompra = CType(bs_abas_doccompra.Current, EABAS_DocsCompra)
         m_eabas_ingresoscompra.ENTID_CodigoProveedor = _ordencompra.ENTID_CodigoProveedor
         m_eabas_ingresoscompra.DOCCO_Codigo = _ordencompra.DOCCO_Codigo
         m_eabas_ingresoscompra.ORDCO_Codigo = _ordencompra.ORDCO_Codigo
         '' cargar los datos basicos para el detalle del ingreso cargando el detalle de la orden de compra
         managerGenerarRegMercTransito.BABAS_IngresosCompra = New BABAS_IngresosCompra()
         managerGenerarRegMercTransito.ABAS_IngresosCompra = New EABAS_IngresosCompra
         managerGenerarRegMercTransito.cargarDetDif(m_eabas_ingresoscompra.DOCCO_Codigo)
         m_eabas_ingresoscompra.ListABAS_IngresosCompraDetalle = managerGenerarRegMercTransito.ABAS_IngresosCompra.ListABAS_IngresosCompraDetalle
         bs_detabas_ingresoscompra.DataSource = m_eabas_ingresoscompra.ListABAS_IngresosCompraDetalle
         c1grdDetalle.DataSource = bs_detabas_ingresoscompra
         bnavProductos.BindingSource = bs_detabas_ingresoscompra

         bs_detabas_ingresoscompra.ResetBindings(False)
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
         '' Validar Detalle
         ValidarDetalle(m_msg)
         '' Verificar si hay pedidos
         If Not m_eabas_ingresoscompra.ListABAS_IngresosCompraDetalle.Count > 0 Then
            m_msg &= String.Format("- No se ha ingresado ningun articulo{0}", vbNewLine)
         End If
         Return Not (m_msg.Length > 0)
      Catch ex As Exception
         Throw ex
      End Try
   End Function

   Private Function ValidarDetalle(ByRef m_msg As String) As Boolean
      Try
         Dim _msg As String = ""
         Dim _cantidad As Double = 0
         bs_detabas_ingresoscompra.ResetBindings(False)
         '' Valida que la cantidad y el precio es superior a 0
         For Each Item As EABAS_IngresosCompraDetalle In m_eabas_ingresoscompra.ListABAS_IngresosCompraDetalle
            _cantidad += Item.INGCD_Cantidad
            If Not Item.INGCD_Cantidad > 0 Then
               _msg &= String.Format("- El Producto {0} tiene como cantidad {1}, no es aceptable.{2}", Item.ARTIC_Descripcion, Item.INGCD_Cantidad, vbNewLine)
            End If
         Next
         If Not _cantidad > 0 Then
            m_msg &= _msg
         End If

         Return Not (m_msg.Length > 0)
      Catch ex As Exception
         Throw ex
      End Try
   End Function

   Private Function grabarOrdenCompra(ByRef m_msg As String) As Boolean
      Try
         If validar(m_msg) Then
            If ACControles.ACDialogos.ACMostrarMensajePregunta(String.Format("Grabar Ingreso de Mercaderia: {0}", Me.Text) _
             , "Desea grabar el Ingreso de Mercaderia?" _
             , ACControles.ACDialogos.LabelBotom.Si_No) = DialogResult.Yes Then
               '' Obtener datos
               m_eabas_ingresoscompra.ALMAC_Id = GApp.Almacen
               '' Obtener el codigo generando con el tipo de documento y la serie
               'm_eabas_ingresoscompra.INGCO_Serie = txtSerie.Text
               'm_eabas_ingresoscompra.INGCO_Numero = actxnNumero.Text
               m_eabas_ingresoscompra.TIPOS_CodTipoDocumento = cmbTipoDoc.SelectedValue
               Dim _where As New Hashtable
               _where.Add("ORDCO_Codigo", New ACWhere(m_eabas_ingresoscompra.ORDCO_Codigo))
               'm_eabas_ingresoscompra.INGCO_Interno = managerABAS_IngresosCompra.getCorrelativo("INGCO_Interno", _where)
               Dim x_codigo As String
               If ETipos.getTipoComprobante(ETipos.TipoComprobanteVenta.Ticket) = m_eabas_ingresoscompra.TIPOS_CodTipoDocumento Then
                  x_codigo = String.Format("{0}{1}{2}", m_eabas_ingresoscompra.TIPOS_CodTipoDocumento.Substring(3, 2), m_eabas_ingresoscompra.INGCO_Serie.PadLeft(4, "0"), m_eabas_ingresoscompra.INGCO_Numero.ToString().PadLeft(9, "0"))
               Else
                  x_codigo = String.Format("{0}{1}{2}", m_eabas_ingresoscompra.TIPOS_CodTipoDocumento.Substring(3, 2), m_eabas_ingresoscompra.INGCO_Serie.PadLeft(3, "0"), m_eabas_ingresoscompra.INGCO_Numero.ToString().PadLeft(7, "0"))
               End If

               'm_eabas_ingresoscompra.INGCO_Codigo = x_codigo
               '' Definir el Estado
               m_eabas_ingresoscompra.INGCO_Estado = EABAS_IngresosCompra.getEstado(EABAS_IngresosCompra.Estado.Ingresado)
               '' Asignar la clase pedido a la capa de negocio 
               managerGenerarRegMercTransito.ABAS_IngresosCompra = m_eabas_ingresoscompra
               '' Grabar el pedido
               Return managerGenerarRegMercTransito.GrabaIngresoCompra(GApp.Usuario, m_msg)
            End If
         Else

         End If
         Return False
      Catch ex As Exception
         Throw ex
      End Try
   End Function
#End Region
#End Region

#Region " Metodos de Controles"

   Private Sub rbtnDatos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtnDatos.CheckedChanged
      grpCliente.Enabled = rbtnDatos.Checked
      grpDocumentos.Enabled = rbtnDocVenta.Checked
   End Sub

   Private Sub btnConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultar.Click
      If rbtnDatos.Checked Then
         txtBusqueda_ACAyudaClick(Nothing, Nothing)
      ElseIf rbtnDocVenta.Checked Then
         txtBusNumero_ACAyudaClick(Nothing, Nothing)
      End If
   End Sub

   Private Sub AcFecha_ACFecFin_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles AcFecha.ACFecFin_KeyDown, AcFecha.ACFecIni_KeyDown
      If e.KeyCode = Keys.Enter Then
         btnConsultar_Click(Nothing, Nothing)
      End If
   End Sub

   Private Sub cmbTipoDoc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTipoDoc.SelectedIndexChanged
      Try
         If ETipos.getTipoComprobante(ETipos.TipoComprobanteVenta.Ticket) = cmbTipoDoc.SelectedValue Then
            txtSerie.MaxLength = 4
            actxnNumero.MaxLength = 9
         Else
            If txtSerie.Text.Length > 3 Then txtSerie.Text = txtSerie.Text.Substring(0, 3)
            If actxnNumero.Text.Length > 7 Then actxnNumero.Text = actxnNumero.Text.Substring(0, 7)
            txtSerie.MaxLength = 3
            actxnNumero.MaxLength = 7
         End If
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso definiendo documento", ex)
      End Try
   End Sub

   Private Sub txtProdDescripcion_SizeChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtProdDescripcion.SizeChanged
      Try
         c1grdDetalle.Cols(2).Width = txtProdDescripcion.Size.Width - 235
      Catch ex As Exception

      End Try
   End Sub

   Private Sub _KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
      If e.KeyCode = Keys.Enter Then
         If sender.Name = "txtBusqueda" Then
            Exit Sub
         End If
         SendKeys.Send("{TAB}")
      End If
   End Sub

#Region " Ayudas "

   Private Sub txtBusqueda_ACAyudaClick(ByVal sender As Object, ByVal e As EventArgs) Handles txtBusqueda.ACAyudaClick
      Try
         busqueda(txtBusqueda.Text)
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Convert.ToString(Text)), "No se puede cargar la ayuda para los registros de compra", ex)
      End Try
   End Sub

   Private Sub txtBusNumero_ACAyudaClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBusNumero.ACAyudaClick
      Try
         busqueda(txtBusqueda.Text, True)
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Convert.ToString(Text)), "No se puede cargar la ayuda para los registros de compra", ex)
      End Try
   End Sub

#End Region

#Region " ToolBar "

   Private Sub acTool_ACBtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles acTool.ACBtnNuevo_Click
      Try
         nuevoIngresioCompra()
         '' Activar las opciones generales del teclado
         KeyPreview = True
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

   Private Sub acTool_ACBtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles acTool.ACBtnCancelar_Click
      Try
         If ACControles.ACDialogos.ACMostrarMensajePregunta(String.Format("Cancelar Orden de Compra: {0}", Me.Text) _
             , "Desea cancelar la Orden de Compra?" _
             , ACControles.ACDialogos.LabelBotom.Si_No) = DialogResult.Yes Then
            'acTool.setInstancia(ACControles.ACToolBarMantHorizontalNew.TipoInstancia.Cancelar)
            tabMantenimiento.SelectedTab = tabBusqueda
            'acTool.ACBtnModificarVisible = m_proceso_modificar
            setInstancia(ACUtilitarios.ACSetInstancia.Deshacer)
         Else
            acTool.setInstancia(ACControles.ACToolBarMantHorizontalNew.TipoInstancia.Nuevo)
         End If

      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso cancelar la Cotización/Pedido", ex)
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

#Region " Grillas "

   Private Sub c1grdBusqueda_BeforeSort(ByVal sender As System.Object, ByVal e As C1.Win.C1FlexGrid.SortColEventArgs) Handles c1grdBusqueda.BeforeSort
      Try
         OrdenarPedidos(c1grdBusqueda.Cols(e.Col).UserData)
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso ordenar", ex)
      End Try
   End Sub

   Private Sub c1grdDetalle_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c1grdDetalle.Enter
      Me.KeyPreview = False
   End Sub

   Private Sub c1grdDetalle_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
      Try
         Select Case e.KeyCode
            Case Keys.Enter
               subirItem()
               c1grdDetalle.Enabled = False
               m_modArticulo = True
               e.SuppressKeyPress = True
            Case Keys.Delete
               If ACControles.ACDialogos.ACMostrarMensajePregunta(String.Format("Quitar Registro: {0}", Me.Text) _
             , String.Format("Desea quitar el Articulo : {0} ", CType(bs_detabas_ingresoscompra.Current, EABAS_IngresosCompraDetalle).ARTIC_Descripcion) _
             , ACControles.ACDialogos.LabelBotom.Si_No) = DialogResult.Yes Then
                  Dim m_det As EABAS_IngresosCompraDetalle = CType(bs_detabas_ingresoscompra.Current, EABAS_IngresosCompraDetalle)
                  m_eabas_ingresoscompra.ListABAS_IngresosCompraDetalle.Remove(m_det)
                  bs_detabas_ingresoscompra.ResetBindings(False)
               End If
               'Case Else
               '   e.Handled = False
         End Select
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Text), "No se puede calcular carga el Item", ex)
      End Try
   End Sub

   Private Sub c1grdDetalle_AfterEdit(ByVal sender As System.Object, ByVal e As C1.Win.C1FlexGrid.RowColEventArgs) Handles c1grdDetalle.AfterEdit
      Try
         If c1grdDetalle.Cols(e.Col).Name = "INGCD_Cantidad" And e.Row > (c1grdDetalle.Rows.Fixed - 1) Then
            If IsNumeric(c1grdDetalle.Rows(e.Row)(e.Col).ToString()) Then
               Dim _act As Boolean = False
               Dim _cantidad As Double = c1grdDetalle.Rows(e.Row)("INGCD_Cantidad")
               'Dim _cantidadTotal As Double = c1grdDetalle.Rows(e.Row)("INGCD_CantidadTotal")
               Dim _pendiente As Double = c1grdDetalle.Rows(e.Row)("Pendiente")
               If _cantidad = _pendiente Then
                  _act = True
                  CType(bs_detabas_ingresoscompra.Current, EABAS_IngresosCompraDetalle).INGCD_Cantidad = _cantidad
               ElseIf _cantidad > _pendiente Then
                  c1grdDetalle.Rows(e.Row)("INGCD_Cantidad") = c1grdDetalle.Rows(e.Row)("Pendiente")
                  ACControles.ACDialogos.ACMostrarMensajeInformacion(String.Format("Información: {0}", Me.Text), "La cantidad supera el maximo definido")
               ElseIf _cantidad > 0 And _cantidad <= _pendiente Then
                  _act = True
                  CType(bs_detabas_ingresoscompra.Current, EABAS_IngresosCompraDetalle).INGCD_Cantidad = _cantidad
               ElseIf _cantidad < 0 Then
                  c1grdDetalle.Rows(e.Row)("Pendiente") = 0
                  ACControles.ACDialogos.ACMostrarMensajeInformacion(String.Format("Información: {0}", Me.Text), "La cantidad supera el minimo definido")
               End If
            End If
         End If
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso verificar cantidad registrada", ex)
      End Try
   End Sub

#End Region

#Region " Textos "

   Private Sub txtOpcion_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtOpcion.KeyPress
      Try
         Select Case e.KeyChar
            Case "+"c
               e.Handled = True
               Dim _act As Boolean = False
               Dim _cantidad As Double = actxnCantidad.Text
               Dim _cantidadTotal As Double = CType(bs_detabas_ingresoscompra.Current, EABAS_IngresosCompraDetalle).INGCD_CantidadTotal
               If _cantidad = _cantidadTotal Then
                  _act = True
                  CType(bs_detabas_ingresoscompra.Current, EABAS_IngresosCompraDetalle).INGCD_Cantidad = _cantidad
               ElseIf _cantidad > _cantidadTotal Then
                  ACControles.ACDialogos.ACMostrarMensajeInformacion(String.Format("Información: {0}", Me.Text), "La cantidad supera el maximo definido")
               ElseIf _cantidad > 0 And _cantidad <= _cantidadTotal Then
                  _act = True
                  CType(bs_detabas_ingresoscompra.Current, EABAS_IngresosCompraDetalle).INGCD_Cantidad = _cantidad
               ElseIf _cantidad < 0 Then
                  ACControles.ACDialogos.ACMostrarMensajeInformacion(String.Format("Información: {0}", Me.Text), "La cantidad supera el minimo definido")
               End If
               If _act Then
                  setProducto(False)
                  c1grdDetalle.Enabled = True
                  Me.KeyPreview = False
                  m_modArticulo = False
                  pnlItem.Enabled = False
                  c1grdDetalle.Focus()
               Else
                  txtProdDescripcion.Focus()
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

#End Region
#End Region

   Private Sub txtSerie_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSerie.KeyPress
      If Char.IsDigit(e.KeyChar) Then
         e.Handled = False
      ElseIf Char.IsControl(e.KeyChar) Then
         e.Handled = False
      Else
         e.Handled = True
      End If
   End Sub
End Class