Imports ACBLogistica
Imports ACELogistica
Imports ACFramework
Imports C1.Win.C1FlexGrid
Imports ACEVentas
Imports ACBVentas
Imports ACSeguridad

Public Class TArreglos
#Region " Variables "
   Private managerArreglos As BCTRL_Arreglos
   Private managerConsultaArticulos As BConsultaArticulos

   Private bs_tipodocumento As BindingSource
   Private bs_arreglos As BindingSource
   Private bs_detarreglos As BindingSource

   Private m_earticulos As ACEVentas.EArticulos

   Private m_order As Integer = 1
   Private m_modArticulo As Boolean = False

   Private frmCons As CProductos
   Private m_listBindHelper As List(Of ACBindHelper)

   Private m_crear As Boolean = False
   Private m_anular As Boolean = False
   Private m_anularfecha As Boolean = False
#End Region

#Region " Propiedades "

#End Region

#Region " Constructores "
   Public Sub New(ByVal x_icono As System.Drawing.Bitmap)

      ' This call is required by the designer.
      InitializeComponent()

      ' Add any initialization after the InitializeComponent() call.
      Try
         setInstancia(ACUtilitarios.ACSetInstancia.Deshacer)
         tabMantenimiento.HideTabsMode = Crownwood.DotNetMagic.Controls.HideTabsModes.HideAlways
         tabMantenimiento.SelectedTab = tabBusqueda
         managerArreglos = New BCTRL_Arreglos()
         managerConsultaArticulos = New BConsultaArticulos(GApp.Periodo)

         formatearGrilla()
         cargarCombos()

         Dim _validate As ACValidarUsuario
         _validate = New ACValidarUsuario(GApp.DataConexion, GApp.DataUsuario, ACValidarUsuario.Operacion.ValidarVariosProcesos)
         For Each item As ACSeguridad.EProcesos In _validate.ListProcesos
            Select Case item.PROC_Codigo
               Case Procesos.getProceso(Procesos.TipoProcesos.ControlLog_CrearArreglo)
                  m_crear = True
               Case Procesos.getProceso(Procesos.TipoProcesos.ControlLog_AnularArreglo)
                  m_anular = True
               Case Procesos.getProceso(Procesos.TipoProcesos.ControlLog_AnularArregloPosterior)
                  m_anularfecha = True
            End Select
         Next


         setInstancia(ACUtilitarios.ACSetInstancia.Deshacer)
         If Not IsNothing(x_icono) Then Me.Icon = Icon.FromHandle(x_icono.GetHicon)
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), Colecciones.getError("00000"), ex)
      End Try
   End Sub
#End Region

#Region " Metodos "
   Private Sub formatearGrilla()
      Dim index As Integer = 1
      Try
            ACFrameworkC1.ACUtilitarios.ACFormatearGrilla(c1grdBusqueda, 1, 1, 8, 1, 0)
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Codigo", "ARREG_Codigo", "ARREG_Codigo", 150, True, False, "System.String") : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Fecha", "ARREG_Fecha", "ARREG_Fecha", 150, True, False, "System.DateTime") : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Fecha Ingreso", "ARREG_FechaIngreso", "ARREG_FechaIngreso", 150, True, False, "System.DateTime") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Tipo Arreglo", "TIPOS_TipoArreglo", "TIPOS_TipoArreglo", 150, True, False, "System.String") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Usuario", "Usuario", "Usuario", 150, True, False, "System.String") : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Estado", "ARREG_Estado_Text", "ARREG_Estado_Text", 150, False, False, "System.String") : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Estado", "ARREG_Estado", "ARREG_Estado", 150, True, False, "System.String") : index += 1

         c1grdBusqueda.AllowEditing = False
         c1grdBusqueda.Styles.Alternate.BackColor = Color.LightGray
         c1grdBusqueda.Styles.Fixed.TextAlign = TextAlignEnum.CenterCenter
         c1grdBusqueda.Styles.Highlight.BackColor = Color.Gray
         c1grdBusqueda.SelectionMode = SelectionModeEnum.Row
         c1grdBusqueda.AllowSorting = AllowSortingEnum.SingleColumn
         c1grdBusqueda.AllowResizing = AllowResizingEnum.Columns

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
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdDetalle, index, "Item", "ARRDT_Item", "ARRDT_Item", 110, True, False, "System.Integer") : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdDetalle, index, "Codigo", "ARTIC_Codigo", "ARTIC_Codigo", 110, True, False, "System.String") : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdDetalle, index, "Descripción", "ARTIC_Descripcion", "ARTIC_Descripcion", 90, True, False, "System.String") : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdDetalle, index, "Unidad", "TIPOS_UnidadMedida", "TIPOS_UnidadMedida", 90, True, False, "System.String") : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdDetalle, index, "Peso", "ARTIC_Peso", "ARTIC_Peso", 100, True, False, "System.Decimal", Parametros.GetParametro(EParametros.TipoParametros.pg_FMondo4d)) : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdDetalle, index, "Cantidad", "ARRDT_Cantidad", "ARRDT_Cantidad", 110, True, False, "System.Decimal", Parametros.GetParametro(EParametros.TipoParametros.pg_FMondo2d)) : index += 1

         c1grdDetalle.AllowEditing = True
         c1grdDetalle.AutoResize = True
         c1grdDetalle.Cols(0).Width = 18
         c1grdDetalle.Styles.Alternate.BackColor = Color.LightGray
         c1grdDetalle.Styles.Fixed.TextAlign = TextAlignEnum.CenterCenter
         c1grdDetalle.Styles.Highlight.BackColor = Color.Gray
         c1grdDetalle.SelectionMode = SelectionModeEnum.Row
         c1grdDetalle.AllowResizing = AllowResizingEnum.None
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Text), "No se puede dar formato a la grilla", ex)
      End Try
   End Sub

   Private Sub cargarCombos()
      Try
         '' Tipo de Documento Comprobante
         bs_tipodocumento = New BindingSource
         bs_tipodocumento.DataSource = Colecciones.TiposDeArreglo()
         ACUtilitarios.ACCargaCombo(cmbTArreglo, bs_tipodocumento, "TIPOS_Descripcion", "TIPOS_Codigo")
         AddHandler bs_tipodocumento.CurrentChanged, AddressOf bs_tipodocumento_CurrentChanged

      Catch ex As Exception
         Throw ex
      End Try
   End Sub

   ''' <summary>
   ''' Realiza el enlace de los controles visuales con la clase esquema
   ''' </summary>
   Private Sub AsignarBinding()
      Try
         m_listBindHelper = New List(Of ACBindHelper)()
         m_listBindHelper.Add(ACBindHelper.ACBind(cmbTArreglo, "SelectedValue", managerArreglos.CTRL_Arreglos, "TIPOS_CodTipoArreglo"))
         m_listBindHelper.Add(ACBindHelper.ACBind(txtSerie, "Text", managerArreglos.CTRL_Arreglos, "ARREG_Serie"))
         m_listBindHelper.Add(ACBindHelper.ACBind(actxnNumero, "Text", managerArreglos.CTRL_Arreglos, "ARREG_Numero"))
         m_listBindHelper.Add(ACBindHelper.ACBind(txtObservaciones, "Text", managerArreglos.CTRL_Arreglos, "ARREG_Observaciones"))

         If managerArreglos.CTRL_Arreglos.ARREG_Fecha.Year < 1700 Then managerArreglos.CTRL_Arreglos.ARREG_Fecha = DateTime.Now
         m_listBindHelper.Add(ACBindHelper.ACBind(dtpFecha, "Value", managerArreglos.CTRL_Arreglos, "ARREG_Fecha"))

         If managerArreglos.CTRL_Arreglos.ARREG_FechaIngreso.Year < 1700 Then managerArreglos.CTRL_Arreglos.ARREG_FechaIngreso = DateTime.Now
         m_listBindHelper.Add(ACBindHelper.ACBind(dtpFechaIngreso, "Value", managerArreglos.CTRL_Arreglos, "ARREG_FechaIngreso"))


      Catch ex As Exception
         Throw ex
      End Try
   End Sub

   Private Sub bs_tipodocumento_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
      Try
         Dim _where As New Hashtable
         _where.Add("TIPOS_CodTipoArreglo", New ACWhere(cmbTArreglo.SelectedValue))
         _where.Add("ARREG_Serie", New ACWhere(GApp.Almacen.ToString("000")))
         Dim _numero As Integer = managerArreglos.getCorrelativo("ARREG_Numero", _where)
         actxnNumero.Text = _numero
         txtSerie.Text = GApp.Almacen.ToString("000")
         txtCodigo.Text = String.Format("{0} {1}-{2:0000000}", CType(cmbTArreglo.SelectedItem, ACEVentas.ETipos).TIPOS_DescCorta, txtSerie.Text, _numero)
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError("Error: " & Me.Text, "Ocurrio un error en el proceso Cambiar de tipo de Arreglo", ex)
      End Try
   End Sub

   Private Sub setInstancia(ByVal _opcion As ACUtilitarios.ACSetInstancia)
      actsbtnPrevisualizar.Visible = False
      acTool.ACBtnRehusarVisible = False
      acTool.ACBtnAnularVisible = False
      Select Case _opcion
         Case ACUtilitarios.ACSetInstancia.Nuevo
            ACUtilitarios.ACLimpiaVar(pnlItem)
            ACUtilitarios.ACLimpiaVar(pnlCabecera)
            actsbtnPrevisualizar.Visible = False
            tabMantenimiento.SelectedTab = tabDatos
            cmbTArreglo.SelectedIndex = 0
            dtpFecha.Value = DateTime.Now
            dtpFechaIngreso.Value = DateTime.Now
            ACUtilitarios.ACSetControl(pnlCabecera, False, ACUtilitarios.TipoPropiedad.ACReadOnly)
            pnlItem.Enabled = True
            Me.KeyPreview = True
            acTool.ACBtnImprimirVisible = False
         Case ACUtilitarios.ACSetInstancia.Modificado
         Case ACUtilitarios.ACSetInstancia.Guardar
         Case ACUtilitarios.ACSetInstancia.Deshacer
            actsbtnPrevisualizar.Visible = True
            tabMantenimiento.SelectedTab = tabBusqueda
            Me.KeyPreview = False
                acTool.ACBtnNuevoEnabled = m_crear
                'acTool.ACBtnNuevoEnabled = True
            acTool.ACBtnImprimirVisible = False
         Case ACUtilitarios.ACSetInstancia.Previsualizar
            acTool.setInstancia(ACControles.ACToolBarMantHorizontalNew.TipoInstancia.Nuevo)
            acTool.ACBtnGrabarVisible = False
            acTool.ACBtnRehusarVisible = False
            actsbtnPrevisualizar.Visible = False
                acTool.ACBtnNuevoVisible = False
                ' acTool.ACBtnNuevoVisible = True
                'acTool.ACBtnAnularVisible = True
            ACUtilitarios.ACSetControl(pnlCabecera, True, ACUtilitarios.TipoPropiedad.ACReadOnly)
            pnlItem.Enabled = False
            acTool.ACBtnAnularVisible = m_anular
            acTool.ACBtnImprimirVisible = True
            Me.KeyPreview = True
         Case Else
            setInstancia(ACUtilitarios.ACSetInstancia.Deshacer)
      End Select
      acTool.ACBtnModificarVisible = False
   End Sub

   Private Sub setProducto(ByVal x_opcion As Boolean)
      Try
         If x_opcion Then
            If managerConsultaArticulos.cargarProducto(m_earticulos.ARTIC_Codigo) Then
               m_earticulos = managerConsultaArticulos.Articulos
               actxaProdCodigo.Text = m_earticulos.ARTIC_Codigo
               txtProdDescripcion.Text = m_earticulos.ARTIC_Descripcion
               txtUnidad.Text = m_earticulos.TIPOS_UndMedCorta
               txtProdDescripcion.Focus()
            End If
         Else
            actxaProdCodigo.Clear()
            txtProdDescripcion.Clear()
            actxnCantidad.Text = "0.00"
         End If
      Catch ex As Exception
         Throw ex
      End Try
   End Sub

   Private Function addDetalle() As Boolean
      Try

         Dim _detarreglos As New ECTRL_ArreglosDetalle
         _detarreglos.Articulo = m_earticulos
         _detarreglos.ARTIC_Codigo = m_earticulos.ARTIC_Codigo
         _detarreglos.ARTIC_Descripcion = m_earticulos.ARTIC_Descripcion
         _detarreglos.TIPOS_UnidadMedida = m_earticulos.TIPOS_UndMedCorta
         _detarreglos.ARTIC_Peso = m_earticulos.ARTIC_Peso
         _detarreglos.ARRDT_Cantidad = actxnCantidad.Text
         _detarreglos.TIPOS_CodUnidadMedida = m_earticulos.TIPOS_CodUnidadMedida
         '' Actualizar contenido
         managerArreglos.CTRL_Arreglos.ListCTRL_ArreglosDetalle.Add(_detarreglos)
         bs_detarreglos.ResetBindings(False)
            Calcular()
         Return True
         'End If
      Catch ex As Exception
         Throw ex
      End Try
   End Function
#End Region

#Region " Metodos de Controles"

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

   Private Sub c1grdBusqueda_OwnerDrawCell(ByVal sender As System.Object, ByVal e As C1.Win.C1FlexGrid.OwnerDrawCellEventArgs) Handles c1grdBusqueda.OwnerDrawCell
      Try
         If e.Row < c1grdBusqueda.Rows.Fixed OrElse e.Col < c1grdBusqueda.Cols.Fixed Then Return

         If c1grdBusqueda.Rows(e.Row)("ARREG_Estado") = EVENT_Pedidos.getEstado(EVENT_Pedidos.Estado.Anulado) Then
            e.Style = c1grdBusqueda.Styles("Anulado")
         End If
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso cambia de color", ex)
      End Try
   End Sub

   Private Sub actxaProdCodigo_ACAyudaClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles actxaProdCodigo.ACAyudaClick
      Try
         If IsNothing(frmCons) Then frmCons = New CProductos(CProductos.Origen.Cotizaciones) With {.StartPosition = FormStartPosition.CenterScreen}
         Me.KeyPreview = False
         If frmCons.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            m_earticulos = frmCons.Articulo
            setProducto(True)
            Dim _filter As New ACFiltrador(Of ACEVentas.ETipos)
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
                        CType(bs_detarreglos.Current, EABAS_IngresosCompraDetalle).INGCD_Cantidad = actxnCantidad.Text
                        CType(bs_detarreglos.Current, EABAS_IngresosCompraDetalle).ARTIC_Codigo = actxaProdCodigo.Text
                        CType(bs_detarreglos.Current, EABAS_IngresosCompraDetalle).ARTIC_Descripcion = txtProdDescripcion.Text
                        setProducto(False)

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
                    c1grdDetalle.AutoSizeCols()
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
               Me.KeyPreview = False
               m_modArticulo = False

               acTool.Focus()
               acTool.ACBtnGrabar.Select()

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
 
   Private Sub c1grdDetalle_AfterEdit(ByVal sender As System.Object, ByVal e As C1.Win.C1FlexGrid.RowColEventArgs) Handles c1grdDetalle.AfterEdit
      Try

      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Text), "No se puede calcular", ex)
      End Try
   End Sub

#Region "Tool Bar"

   Private Sub acTool_ACBtnAnular_Click(sender As Object, e As EventArgs) Handles acTool.ACBtnAnular_Click
      Try
         If ACControles.ACDialogos.ACMostrarMensajePregunta(String.Format("Anular Arreglo: {0}", Me.Text) _
                                     , String.Format("Desea Anular el registro: {0}", txtCodigo.Text) _
                                     , ACControles.ACDialogos.LabelBotom.Si_No) = DialogResult.Yes Then
            Dim _frmMotivo As New DMotivo(DMotivo.TDocumento.Recibo) With {.StartPosition = FormStartPosition.CenterScreen, .WindowState = FormWindowState.Normal}
            If _frmMotivo.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
               Dim _motivo As String = String.Format("Usuario: {1} {0} - Fecha: {2:dd/MM/yyyy HH:mm} {0} Motivo: {3} {0} Maquina: {4}-{5}", _
                                                         vbNewLine, GApp.EUsuario.USER_CodUsr, DateTime.Now, _
                                                         _frmMotivo.Motivo, GApp.HostName, GApp.HostIP)

                    If managerArreglos.Anular(GApp.Periodo, _motivo, m_anularfecha, GApp.Usuario) Then
                        ACControles.ACDialogos.ACMostrarMensajeSatisfactorio(String.Format("Información: {0}", Me.Text), String.Format("Anulación realizada"))

                        setInstancia(ACUtilitarios.ACSetInstancia.Deshacer)
                        btnConsultar_Click(Nothing, Nothing)
                    End If

            End If
            
         End If
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Text), "No se puede anular el arreglo", ex)
      End Try
   End Sub

   Private Sub acTool_ACBtnCancelar_Click(sender As Object, e As EventArgs) Handles acTool.ACBtnCancelar_Click
      Try
         setInstancia(ACUtilitarios.ACSetInstancia.Deshacer)
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), String.Format(Colecciones.getError("00101"), "Cancelar Arreglo"), ex)
      End Try
   End Sub

   Private Sub acTool_ACBtnGrabar_Click(sender As Object, e As EventArgs) Handles acTool.ACBtnGrabar_Click
      Try
         If ACControles.ACDialogos.ACMostrarMensajePregunta(String.Format("Grabar Registro: {0}", Me.Text) _
                                     , String.Format("Desea Grabar el registro: {0}", txtCodigo.Text) _
                                     , ACControles.ACDialogos.LabelBotom.Si_No) = DialogResult.Yes Then
            managerArreglos.CTRL_Arreglos.ALMAC_Id = GApp.Almacen
            managerArreglos.CTRL_Arreglos.ARREG_Estado = ACEVentas.Constantes.getEstado(ACEVentas.Constantes.Estado.Ingresado)
            If managerArreglos.Guardar(GApp.Usuario, True, GApp.Periodo) Then
               ACControles.ACDialogos.ACMostrarMensajeSatisfactorio(String.Format("Información: {0}", Me.Text), String.Format(Colecciones.getError("01000")))
               setInstancia(ACUtilitarios.ACSetInstancia.Deshacer)
               btnConsultar_Click(Nothing, Nothing)
            Else
               Throw New Exception("No se completo el proceso de grabar registro")
            End If
         End If

      Catch ex As Exception
         acTool.setInstancia(ACControles.ACToolBarMantHorizontalNew.TipoInstancia.Nuevo)
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), String.Format(Colecciones.getError("00101"), "Grabando Arreglo"), ex)
      End Try
   End Sub

   Private Sub acTool_ACBtnImprimir_Click(sender As Object, e As EventArgs) Handles acTool.ACBtnImprimir_Click
      Try
         Dim m_reporte As New Reporte
         m_reporte.RArreglo(managerArreglos.CTRL_Arreglos.ARREG_Codigo, False)
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), String.Format(Colecciones.getError("00101"), "Mostrando Reporte"), ex)
      End Try
   End Sub

   Private Sub acTool_ACBtnModificar_Click(sender As Object, e As EventArgs) Handles acTool.ACBtnModificar_Click

   End Sub

   Private Sub acTool_ACBtnNuevo_Click(sender As Object, e As EventArgs) Handles acTool.ACBtnNuevo_Click
      Try
         setInstancia(ACUtilitarios.ACSetInstancia.Nuevo)
         managerArreglos.CTRL_Arreglos = New ECTRL_Arreglos
         managerArreglos.CTRL_Arreglos.Instanciar(ACEInstancia.Nuevo)

         AsignarBinding()

         managerArreglos.CTRL_Arreglos.ListCTRL_ArreglosDetalle = New List(Of ECTRL_ArreglosDetalle)
         bs_detarreglos = New BindingSource
         bs_detarreglos.DataSource = managerArreglos.CTRL_Arreglos.ListCTRL_ArreglosDetalle
         c1grdDetalle.DataSource = bs_detarreglos
         bnavDetArreglos.BindingSource = bs_detarreglos

         bs_tipodocumento_CurrentChanged(Nothing, Nothing)

      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), String.Format(Colecciones.getError("00101"), "Nuevo Arreglo"), ex)
      End Try
   End Sub

   Private Sub acTool_ACBtnSalir_Click(sender As Object, e As EventArgs) Handles acTool.ACBtnSalir_Click
      Me.Close()
   End Sub
#End Region

#End Region
     Private Sub Calcular()
      Try
         Dim _peso As Decimal = 0
         For Each Item As ECTRL_ArreglosDetalle In managerArreglos.CTRL_Arreglos.ListCTRL_ArreglosDetalle
            _peso += Item.ARRDT_Cantidad * Item.ARTIC_Peso
         Next
         actxnPesoTotal.Text = _peso
         actxnPesoTotal.Formatear()
      Catch ex As Exception
         Throw ex
      End Try
   End Sub

   Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
      Try
         If rbtnFecha.Checked Then
            managerArreglos.BuscarArreglos(BCTRL_Arreglos.TBus.Fecha, AcFecha.ACFecha_De.Value.Date, AcFecha.ACFecha_A.Value.Date, txtBusqueda.Text)
         ElseIf rbtnCodigo.Checked Then
            managerArreglos.BuscarArreglos(BCTRL_Arreglos.TBus.Codigo, AcFecha.ACFecha_De.Value.Date, AcFecha.ACFecha_A.Value.Date, txtBusqueda.Text)
         End If
         bs_arreglos = New BindingSource
         bs_arreglos.DataSource = managerArreglos.ListCTRL_Arreglos
         c1grdBusqueda.DataSource = bs_arreglos
         bnavBusqueda.BindingSource = bs_arreglos

      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), String.Format(Colecciones.getError("00101"), "Busqueda"), ex)
      End Try
   End Sub

   Private Sub rbtnFecha_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnFecha.CheckedChanged
      AcFecha.Enabled = rbtnFecha.Checked
      txtBusqueda.Enabled = rbtnCodigo.Checked
   End Sub

   Private Sub actsbtnPrevisualizar_Click(sender As Object, e As EventArgs) Handles actsbtnPrevisualizar.Click
      Try
         Dim _codigo As String = CType(bs_arreglos.Current, ECTRL_Arreglos).ARREG_Codigo
         If managerArreglos.Cargar(_codigo, True) Then
            setInstancia(ACUtilitarios.ACSetInstancia.Nuevo)
            AsignarBinding()
            bs_detarreglos = New BindingSource
            bs_detarreglos.DataSource = managerArreglos.CTRL_Arreglos.ListCTRL_ArreglosDetalle
            c1grdDetalle.DataSource = bs_detarreglos
            bnavDetArreglos.BindingSource = bs_detarreglos
                Calcular()
            txtCodigo.Text = String.Format("{0} {1}-{2:0000000}", CType(cmbTArreglo.SelectedItem, ETipos).TIPOS_DescCorta, txtSerie.Text, managerArreglos.CTRL_Arreglos.ARREG_Numero)
                setInstancia(ACUtilitarios.ACSetInstancia.Previsualizar)
                
         End If

      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), String.Format(Colecciones.getError("00101"), "Revisar"), ex)
      End Try
   End Sub

    
    Private Sub TArreglos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub tabMantenimiento_SelectionChanged(sender As Crownwood.DotNetMagic.Controls.TabControl, oldPage As Crownwood.DotNetMagic.Controls.TabPage, newPage As Crownwood.DotNetMagic.Controls.TabPage) Handles tabMantenimiento.SelectionChanged

    End Sub
End Class