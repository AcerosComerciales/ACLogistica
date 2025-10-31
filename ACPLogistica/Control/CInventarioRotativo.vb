Imports ACBLogistica
Imports ACELogistica
Imports ACFramework
Imports C1.Win.C1FlexGrid
Imports ACEVentas
Imports ACBVentas
Imports ACSeguridad

Public Class CInventarioRotativo
#Region " Variables "
    Private managerCTRL_InventarioRotativo As BCTRL_InventarioRotativo
    Private managerConsultaArticulos As ACBVentas.BConsultaArticulos
    Private managerEntidades As ACBVentas.BEntidades

    Private m_eentidades As EEntidades
    Private m_listLineas As List(Of ACEVentas.ELineas)
    Private m_listSubLineas As List(Of ACEVentas.ELineas)
    Private bs_ctrl_inventariorotativo As BindingSource

    Private m_listBindHelper As List(Of ACBindHelper)
    Private bs_lineas As BindingSource
    Private bs_sublineas As BindingSource
    Private bs_detalle As BindingSource

    Private m_lineas_codigo As String
#End Region

#Region " Propiedades "

#End Region

#Region " Constructores "
    Public Sub New(ByVal x_icono As System.Drawing.Bitmap)



        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Try
            tabMantenimiento.HideTabsMode = Crownwood.DotNetMagic.Controls.HideTabsModes.HideAlways
            tabMantenimiento.SelectedTab = tabBusqueda

            managerCTRL_InventarioRotativo = New BCTRL_InventarioRotativo()
            managerConsultaArticulos = New ACBVentas.BConsultaArticulos(GApp.Periodo)
            managerEntidades = New ACBVentas.BEntidades
            CargarCombos()
            formatearGrilla()

            setInstancia(ACUtilitarios.ACSetInstancia.Deshacer)
            If Not IsNothing(x_icono) Then Me.Icon = Icon.FromHandle(x_icono.GetHicon)
        Catch ex As Exception
            ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), Colecciones.getError("00000"), ex)
        End Try
    End Sub
#End Region

#Region " Metodos "
    Private Sub setInstancia(ByVal _opcion As ACUtilitarios.ACSetInstancia)
        'actsbtnPrevisualizar.Visible = False
        'actsbtnPrevisualizar.Visible = False
        AcTool.ACBtnRehusarVisible = False
        AcTool.ACBtnAnularVisible = False
        'RemoveHandler c1grdDetalle.KeyDown, AddressOf c1grdDetalle_KeyDown
        Select Case _opcion
            Case ACUtilitarios.ACSetInstancia.Nuevo
                ACUtilitarios.ACLimpiaVar(pnlCabecera)
                ACUtilitarios.ACLimpiaVar(pnlDetalleDocumento)
                ACUtilitarios.ACLimpiaVar(grpPie)
                txtObservacion.Clear()
                tabMantenimiento.SelectedTab = tabDatos
                actsbtnPrevisualizar.Visible = True
                actxaResCodigo.ACAyuda.Enabled = True
                actxaResNombre.ACActivarAyuda = True
                actxaResNombre.ACAyuda.Enabled = True
                actxaResCodigo.ACActivarAyuda = True
                AcFecha.Enabled = True
                dtpFecha.Value = DateTime.Now
                ACUtilitarios.ACSetControl(pnlCabecera, False, ACUtilitarios.TipoPropiedad.ACReadOnly)
                Me.KeyPreview = True
                AcTool.ACBtnImprimirVisible = False
                AcTool.ACBtnModificarVisible = False
                AcTool.ACBtnAnularVisible = False
            Case ACUtilitarios.ACSetInstancia.Modificado
                'm_modificar = True
                'AddHandler c1grdDetalle.KeyDown, AddressOf c1grdDetalle_KeyDown

            Case ACUtilitarios.ACSetInstancia.Guardar
                txtBusqueda.Focus()
                'm_modificar = False
                'RemoveHandler c1grdDetalle.KeyDown, AddressOf c1grdDetalle_KeyDown

            Case ACUtilitarios.ACSetInstancia.Deshacer
                actxaResCodigo.Focus()
                acTool.ACBtnImprimirVisible = False
                acTool.ACBtnAnularVisible = False
                AcTool.ACBtnRehusarVisible = False
                AcTool.ACBtnModificarVisible = False
                tabMantenimiento.SelectedTab = tabBusqueda
                Me.KeyPreview = False
                'm_modificar = False
                'RemoveHandler c1grdDetalle.KeyDown, AddressOf c1grdDetalle_KeyDown
            Case ACUtilitarios.ACSetInstancia.Previsualizar
                ACUtilitarios.ACSetControl(pnlCabecera, True, ACUtilitarios.TipoPropiedad.ACReadOnly)
                ' ACUtilitarios.ACSetControl(grpDocReferencia, True, ACUtilitarios.TipoPropiedad.ACReadOnly)
                '  GroupBox3.Enabled = False
                actxaResCodigo.ACAyuda.Enabled = False
                actxaResNombre.ACActivarAyuda = False
                AcTool.ACBtnModificarVisible = False
                actxaResNombre.ACAyuda.Enabled = False
                actxaResCodigo.ACActivarAyuda = False
                AcFecha.Enabled = False
                ' item.Enabled = False
                ' btnClean.Enabled = False
                ' nue.Enabled = False
                c1grdDetalle.AllowEditing = False
                'pnlItem.Enabled = False
                AcTool.setInstancia(ACControles.ACToolBarMantHorizontalNew.TipoInstancia.Nuevo)
                AcTool.ACBtnGrabarVisible = False
                AcTool.ACBtnCancelarVisible = True
                actsbtnPrevisualizar.Visible = False

                AcTool.ACBtnAnularVisible = False
                AcTool.ACBtnModificarVisible = False
                AcTool.ACBtnVolverVisible = False


                tabMantenimiento.SelectedTab = tabDatos
            Case Else
                setInstancia(ACUtilitarios.ACSetInstancia.Deshacer)
        End Select
    End Sub


    Private Sub c1grdDetalle_OwnerDrawCell(sender As Object, e As OwnerDrawCellEventArgs) Handles c1grdDetalle.OwnerDrawCell
        ''' SOlo unas columnas
        If e.Row < c1grdDetalle.Rows.Fixed OrElse e.Col < c1grdDetalle.Cols.Fixed Then Return
        If c1grdDetalle.Cols(e.Col).Name = "INROD_Stock" Then
            If c1grdDetalle.Rows(e.Row)("INROD_Stock") > 0 Then
                e.Style = c1grdDetalle.Styles("Stock")
            End If
        End If
        If c1grdDetalle.Cols(e.Col).Name = "INROD_PenOrdenes" Then
            If c1grdDetalle.Rows(e.Row)("INROD_PenOrdenes") > 0 Then
                e.Style = c1grdDetalle.Styles("Pendientes")
            End If
        End If

        If c1grdDetalle.Cols(e.Col).Name = "INROD_PenPedidos" Then
            If c1grdDetalle.Rows(e.Row)("INROD_PenPedidos") > 0 Then
                e.Style = c1grdDetalle.Styles("Pendientes")
            End If
        End If

        If c1grdDetalle.Cols(e.Col).Name = "INROD_PenFacturas" Then
            If c1grdDetalle.Rows(e.Row)("INROD_PenFacturas") > 0 Then
                e.Style = c1grdDetalle.Styles("Pendientes")
            End If
        End If

        If c1grdDetalle.Cols(e.Col).Name = "INROD_PenConfirmacion" Then
            If c1grdDetalle.Rows(e.Row)("INROD_PenConfirmacion") > 0 Then
                e.Style = c1grdDetalle.Styles("Pendientes")
            End If
        End If

        If c1grdDetalle.Cols(e.Col).Name = "INROD_Pendiente" Then
            If c1grdDetalle.Rows(e.Row)("INROD_Pendiente") > 0 Then
                e.Style = c1grdDetalle.Styles("Total")
            End If
        End If
        If c1grdDetalle.Cols(e.Col).Name = "INROD_StockFinal" Then
            If c1grdDetalle.Rows(e.Row)("INROD_StockFinal") > 0 Then
                e.Style = c1grdDetalle.Styles("StockFinal")
            End If
        End If
        If c1grdDetalle.Cols(e.Col).Name = "INROD_StockFisico" Then
            If c1grdDetalle.Rows(e.Row)("INROD_StockFisico") > 0 Then
                e.Style = c1grdDetalle.Styles("StockFisico")
            End If
        End If
    End Sub

   Private Sub formatearGrilla()
        Dim _index As Integer = 1

        Try

            ACFrameworkC1.ACUtilitarios.ACFormatearGrilla(c1grdBusqueda, 1, 1, 7, 1, 0)
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, _index, "Codigo", "INROT_Codigo", "INROT_Codigo", 150, True, False, "System.String") : _index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, _index, "Fecha", "INROT_Fecha", "INROT_Fecha", 150, True, False, "System.DateTime") : _index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, _index, "Fecha Ingreso", "INROT_FecCrea", "INROT_FecCrea", 150, True, False, "System.DateTime") : _index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, _index, "Responsable", "ENTID_CodigoResponsable", "ENTID_CodigoResponsable", 150, True, False, "System.String") : _index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, _index, "Estado", "INROT_Estado_Text", "INROT_Estado_Text", 150, False, False, "System.String") : _index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, _index, "Estado", "INROT_Estado", "INROT_Estado", 150, True, False, "System.String") : _index += 1

            c1grdBusqueda.AllowEditing = False
            c1grdBusqueda.Styles.Alternate.BackColor = Color.LightGray
            c1grdBusqueda.Styles.Fixed.TextAlign = TextAlignEnum.CenterCenter
            c1grdBusqueda.Styles.Highlight.BackColor = Color.Gray
            c1grdBusqueda.SelectionMode = SelectionModeEnum.Row
            c1grdBusqueda.AllowSorting = AllowSortingEnum.SingleColumn
            c1grdBusqueda.AllowResizing = AllowResizingEnum.Columns

            Dim tm As C1.Win.C1FlexGrid.CellStyle = c1grdBusqueda.Styles.Add("Facturado")
            tm.BackColor = Color.LightGreen
            tm.ForeColor = Color.DarkBlue
            tm.Font = New Font(c1grdBusqueda.Font, FontStyle.Regular)

            Dim um As C1.Win.C1FlexGrid.CellStyle = c1grdBusqueda.Styles.Add("Facturar")
            um.BackColor = Color.Green
            um.ForeColor = Color.White
            um.Font = New Font(c1grdBusqueda.Font, FontStyle.Regular)

            Dim dm As C1.Win.C1FlexGrid.CellStyle = c1grdBusqueda.Styles.Add("Anulado")
            dm.BackColor = Color.Red
            dm.ForeColor = Color.White
            dm.Font = New Font(c1grdBusqueda.Font, FontStyle.Bold)
            c1grdBusqueda.DrawMode = C1.Win.C1FlexGrid.DrawModeEnum.OwnerDraw

            _index = 1
            'Precios
            ACFrameworkC1.ACUtilitarios.ACFormatearGrilla(c1grdDetalle, 3, 3, 16, 1)
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdDetalle, _index, "Nro", "INROD_Item", "INROD_Item", 150, True, False, "System.Integer") : _index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdDetalle, _index, "Codigo", "ARTIC_Codigo", "ARTIC_Codigo", 150, True, False, "System.String", "") : _index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdDetalle, _index, "Nombre", "ARTIC_Descripcion", "ARTIC_Descripcion", 150, True, False, "System.String", "") : _index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdDetalle, _index, "Unidad", "TIPOS_UnidadMedida", "TIPOS_UnidadMedida", 150, True, False, "System.String", "") : _index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdDetalle, _index, "Stock", "INROD_Stock", "INROD_Stock", 100, True, False, "System.Decimal", "#,###,##0.00") : _index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdDetalle, _index, "Ordenes", "INROD_PenOrdenes", "INROD_PenOrdenes", 100, True, False, "System.Decimal", "#,###,##0.00") : _index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdDetalle, _index, "Pedidos", "INROD_PenPedidos", "INROD_PenPedidos", 100, True, False, "System.Decimal", "#,###,##0.00") : _index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdDetalle, _index, "Facturas", "INROD_PenFacturas", "INROD_PenFacturas", 100, True, False, "System.Decimal", "#,###,##0.00") : _index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdDetalle, _index, "P. COnf.", "INROD_PenConfirmacion", "INROD_PenConfirmacion", 100, True, False, "System.Decimal", "#,###,##0.00") : _index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdDetalle, _index, "Total", "INROD_Pendiente", "INROD_Pendiente", 100, True, False, "System.Decimal", "#,###,##0.00") : _index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdDetalle, _index, "Final", "INROD_StockFinal", "INROD_StockFinal", 100, True, False, "System.Decimal", "#,###,##0.00") : _index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdDetalle, _index, "Conteo", "INROD_StockFisico", "INROD_StockFisico", 100, True, True, "System.Decimal", "#,###,##0.00") : _index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdDetalle, _index, "Correcto", "INROD_VeriCorrecto", "INROD_VeriCorrecto", 100, True, False, "System.Boolean") : _index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdDetalle, _index, "Sobrante", "INROD_VeriSobrante", "INROD_VeriSobrante", 100, True, False, "System.Decimal", "#,###,##0.00") : _index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdDetalle, _index, "Faltante", "INROD_VeriFaltante", "INROD_VeriFaltante", 100, True, False, "System.Decimal", "#,###,##0.00") : _index += 1

            c1grdDetalle.AllowEditing = True
            c1grdDetalle.Styles.Alternate.BackColor = Color.LightGray
            c1grdDetalle.Styles.Fixed.TextAlign = TextAlignEnum.CenterCenter
            c1grdDetalle.Styles.Highlight.BackColor = Color.Gray
            c1grdDetalle.SelectionMode = SelectionModeEnum.Row


            Dim t As C1.Win.C1FlexGrid.CellStyle = c1grdDetalle.Styles.Add("StockFisico")
            t.BackColor = Color.DarkBlue
            t.ForeColor = Color.White
            t.Font = New Font(c1grdDetalle.Font, FontStyle.Bold)

            t = c1grdDetalle.Styles.Add("Total")
            t.BackColor = Color.LightSalmon
            t.ForeColor = Color.DarkBlue
            t.Font = New Font(c1grdDetalle.Font, FontStyle.Regular)

            t = c1grdDetalle.Styles.Add("Stock")
            t.BackColor = Color.Green
            t.ForeColor = Color.White
            t.Font = New Font(c1grdDetalle.Font, FontStyle.Regular)

            t = c1grdDetalle.Styles.Add("StockFinal")
            t.BackColor = Color.Red
            t.ForeColor = Color.White

            t = c1grdDetalle.Styles.Add("Pendientes")
            t.BackColor = Color.LightSkyBlue
            t.ForeColor = Color.Black
            c1grdDetalle.DrawMode = C1.Win.C1FlexGrid.DrawModeEnum.OwnerDraw

            For index = 1 To c1grdDetalle.Cols("TIPOS_UnidadMedida").Index
                c1grdDetalle.Rows(1)(index - 1) = c1grdDetalle.Rows(0)(index - 1)
                Dim rg As CellRange = c1grdDetalle.GetCellRange(0, index, 2, index)
                c1grdDetalle.MergedRanges.Add(rg)
            Next
            For index = c1grdDetalle.Cols("TIPOS_UnidadMedida").Index + 1 To c1grdDetalle.Cols.Count
                c1grdDetalle.Rows(1)(index - 1) = c1grdDetalle.Rows(0)(index - 1)
                c1grdDetalle.Rows(2)(index - 1) = c1grdDetalle.Rows(0)(index - 1)
            Next

            Dim rg1 As CellRange = c1grdDetalle.GetCellRange(0, c1grdDetalle.Cols("INROD_Stock").Index, 0, c1grdDetalle.Cols("INROD_StockFinal").Index)
            rg1.Data = "Información del Sistema"
            c1grdDetalle.MergedRanges.Add(rg1)

            rg1 = c1grdDetalle.GetCellRange(1, c1grdDetalle.Cols("INROD_Stock").Index, 2, c1grdDetalle.Cols("INROD_Stock").Index)
            rg1.Data = "Stock"
            c1grdDetalle.MergedRanges.Add(rg1)

            rg1 = c1grdDetalle.GetCellRange(1, c1grdDetalle.Cols("INROD_PenOrdenes").Index, 1, c1grdDetalle.Cols("INROD_Pendiente").Index)
            rg1.Data = "Pendientes"
            c1grdDetalle.MergedRanges.Add(rg1)

            rg1 = c1grdDetalle.GetCellRange(1, c1grdDetalle.Cols("INROD_StockFinal").Index, 2, c1grdDetalle.Cols("INROD_StockFinal").Index)
            rg1.Data = "Stock Final"
            c1grdDetalle.MergedRanges.Add(rg1)

            rg1 = c1grdDetalle.GetCellRange(1, c1grdDetalle.Cols("INROD_StockFisico").Index, 2, c1grdDetalle.Cols("INROD_StockFisico").Index)
            rg1.Data = "Stock Fisico"
            c1grdDetalle.MergedRanges.Add(rg1)

            For index = c1grdDetalle.Cols("INROD_VeriCorrecto").Index To c1grdDetalle.Cols.Count - 1
                rg1 = c1grdDetalle.GetCellRange(1, index, 2, index)
                rg1.Data = c1grdDetalle.Cols(index)(0)
                c1grdDetalle.MergedRanges.Add(rg1)
            Next
            rg1 = c1grdDetalle.GetCellRange(0, c1grdDetalle.Cols("INROD_VeriCorrecto").Index, 0, c1grdDetalle.Cols("INROD_VeriFaltante").Index)
            rg1.Data = "Verificación"
            c1grdDetalle.MergedRanges.Add(rg1)

            rg1 = c1grdDetalle.GetCellRange(0, 0, 2, 0)
            c1grdDetalle.MergedRanges.Add(rg1)

        Catch ex As Exception
            ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Text), "No se puede dar formato a la grilla", ex)
        End Try
   End Sub

   Public Function CargarCombos() As Boolean
        Try
            managerConsultaArticulos.cargarProductos()
            Dim _lineas As New List(Of ACEVentas.ELineas)
            Dim _lin As New ACEVentas.ELineas
            _lin.LINEA_Codigo = "000"
            _lin.LINEA_Nombre = "< Todos >"
            _lineas.Add(_lin)
            For Each item As ACEVentas.ELineas In managerConsultaArticulos.ListLineas
                _lineas.Add(item.Clone)
            Next

            m_listLineas = New List(Of ACEVentas.ELineas)(_lineas)
            bs_lineas = New BindingSource()
            bs_lineas.DataSource = m_listLineas
            m_listSubLineas = New List(Of ACEVentas.ELineas)(managerConsultaArticulos.ListSubLineas)

            ACFramework.ACUtilitarios.ACCargaCombo(cmbLinea, bs_lineas, "LINEA_Nombre", "LINEA_Codigo")
            AddHandler bs_lineas.CurrentChanged, AddressOf bs_lineas_CurrentChanged
            bs_lineas_CurrentChanged(Nothing, Nothing)

            Return True
        Catch ex As Exception
            Throw ex
        End Try
   End Function

   Private Sub bs_lineas_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If cmbLinea.SelectedValue = "000" Then
                cmbsublinea.SelectedIndex = -1
                cmbsublinea.Enabled = False
            Else
                cmbsublinea.Enabled = True
                Me.KeyPreview = True
                Dim _filter As New ACFiltrador(Of ACEVentas.ELineas)() With {.ACFiltro = String.Format("LINEA_CodPadre={0}", cmbLinea.SelectedValue)}
                bs_sublineas = New BindingSource()
                Dim _sublinea As New List(Of ACEVentas.ELineas)
                Dim _sl As New ACEVentas.ELineas
                _sl.LINEA_Codigo = "000"
                _sl.LINEA_Nombre = "< Todos >"
                _sublinea.Add(_sl)
                If _filter.ACFiltrar(_filter.ACFiltrar(m_listSubLineas)).Count > 0 Then
                    For Each item As ACEVentas.ELineas In _filter.ACListaFiltrada
                        _sublinea.Add(item.Clone)
                    Next
                End If
                bs_sublineas.DataSource = _sublinea

                ACFramework.ACUtilitarios.ACCargaCombo(cmbsublinea, bs_sublineas, "LINEA_Nombre", "LINEA_Codigo")
            End If
        Catch ex As Exception
            ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso Cargar Sub Lineas", ex)
        End Try
   End Sub

   Private Sub AyudaEntidad(ByVal x_cadenas As String, ByVal x_campo As String, ByVal x_descripcion As String, ByVal x_opcion As Short, ByVal x_opcionentidad As ACEVentas.EEntidades.TipoEntidad)
        Try
            Dim _where As New Hashtable
            _where.Add(x_campo, New ACWhere(x_cadenas, ACWhere.TipoWhere._Like))
            If x_cadenas.Length = 0 Then
                Dim _campos() As ACCampos = {New ACCampos("@Opcion", x_opcion.ToString()), New ACCampos("@Cadena", x_cadenas), New ACCampos("@ROLES_Id", x_opcionentidad.GetHashCode.ToString())}
                Dim _busqueda As New ACCampos("@Cadena", x_descripcion)
                Dim AyudaText As New ACControlesC1.ACAyudaTextFlex("Buscar Entidad", "ENTISS_TodosAyuda", _campos, _busqueda, False)
                If AyudaText.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                    Select Case x_opcionentidad

                        Case ACEVentas.EEntidades.TipoEntidad.Trabajadores
                            '' Cargar datos del cliente
                            actxaResNombre.Text = AyudaText.Respuesta.Rows(0)("Razon Social").ToString()
                            actxaResCodigo.Text = AyudaText.Respuesta.Rows(0)("Doc./R.U.C.").ToString()
                    End Select
                End If
            Else
                If managerEntidades.Ayuda(_where, x_opcionentidad) Then
                    Dim Ayuda As New ACControlesC1.ACAyudaFlex("Buscar Entidad", managerEntidades.DTEntidades, False)
                    If Ayuda.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                        Select Case x_opcionentidad
                            Case ACEVentas.EEntidades.TipoEntidad.Usuarios
                                '' Cargar datos del cliente
                                actxaResNombre.Text = Ayuda.Respuesta.Rows(0)("Razon Social").ToString()
                                actxaResCodigo.Text = Ayuda.Respuesta.Rows(0)("Doc./R.U.C.").ToString()
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
    Private Sub CargarEntidad()
        Try

            '' Cargar datos adicionales cliente
            If actxaResCodigo.ACAyuda.Enabled = True Then
                If managerEntidades.CargarDocIden(actxaResCodigo.Text, EEntidades.TipoEntidad.Trabajadores) Then
                    '' Cargar datos del cliente   
                    managerCTRL_InventarioRotativo.CTRL_InventarioRotativo.ENTID_CodigoResponsable = managerEntidades.Entidades.ENTID_Codigo
                    m_eentidades = managerEntidades.Entidades

                    actxaResNombre.Text = managerEntidades.Entidades.ENTID_RazonSocial
                    actxaResCodigo.Text = managerEntidades.Entidades.ENTID_NroDocumento
                    ' CargarEntidad(managerEntidades.Proveedor.ENTID_Codigo)
                    'setEntidad(IIf(getFilterRol(), Seteo.Activar, Seteo.Desactivar))
                    ' pnlItem.Enabled = True
                    Label2.Focus()
                    'Else
                    ' If ACControles.ACDialogos.ACMostrarMensajePregunta(String.Format("Documento de Identidad: {0}", Me.Text) _
                    '    , String.Format("El Documento de Identidad {0} no existe, ¿Desea Ingresar la Entidad?", actxaResCodigo.Text) _
                    ' , ACControles.ACDialogos.LabelBotom.Si_No) = DialogResult.Yes Then
                    'NuevoProveedor(actxaResCodigo.Text)
                    ' Else
                    '  btnClean_Click(Nothing, Nothing)
                    ' Label5.Focus()
                    '  End If
                End If
            Else
                If managerEntidades.CargarDocIden(actxaResCodigo.Text, EEntidades.TipoInicializacion.Proveedor) Then
                    managerCTRL_InventarioRotativo.CTRL_InventarioRotativo.ENTID_CodigoResponsable = managerEntidades.Entidades.ENTID_Codigo
                    m_eentidades = managerEntidades.Entidades

                    actxaResNombre.Text = managerEntidades.Entidades.ENTID_RazonSocial
                    actxaResCodigo.Text = managerEntidades.Entidades.ENTID_NroDocumento
                End If
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

   Private Sub setEntidad(ByVal x_entid_codigo As String)
        '' Cargar datos adicionales cliente
        If managerEntidades.CargarDocIden(x_entid_codigo, ACEVentas.EEntidades.TipoInicializacion.Direcciones) Then
            '' Cargar datos del cliente

            actxaResCodigo.Text = managerEntidades.Entidades.ENTID_RazonSocial
            actxaResNombre.Text = managerEntidades.Entidades.ENTID_NroDocumento
        Else
            ACControles.ACDialogos.ACMostrarMensajeInformacion(String.Format("Documento de Identidad: {0}", Me.Text) _
                            , String.Format("El Documento de Identidad {0} no existe, ¿Desea Ingresar la Entidad?", x_entid_codigo) _
                            )
            actxaResCodigo.Focus()
            actxaResCodigo.SelectAll()
        End If
    End Sub


#End Region

#Region " Metodos de Controles"

    Private Sub actxaResCodigo_ACAyudaClick(sender As Object, e As EventArgs) Handles actxaResCodigo.ACAyudaClick
        Try
            AyudaEntidad(actxaResCodigo.Text, "ENTID_NroDocumento", "Razon Social", 1, ACEVentas.EEntidades.TipoEntidad.Trabajadores)
        Catch ex As Exception
            ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso Documento de Identidad", ex)
        End Try
    End Sub

    Private Sub actxaResNombre_ACAyudaClick(sender As Object, e As EventArgs) Handles actxaResNombre.ACAyudaClick
        Try
            AyudaEntidad(actxaResNombre.Text, "ENTID_RazonSocial", "Razon Social", 1, ACEVentas.EEntidades.TipoEntidad.Trabajadores)
        Catch ex As Exception
            ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso busqueda de cliente por Nombre/Razon Social", ex)
        End Try
    End Sub
    Private Sub actxaResCodigo_KeyDown(sender As Object, e As KeyEventArgs) Handles actxaResCodigo.KeyDown
        Try
            If e.KeyData = Keys.Enter Then
                If actxaResCodigo.Text.ToString().Length >= ACEVentas.Constantes.LongitudCodigo Then
                    setEntidad(actxaResCodigo.Text)
                Else
                    If actxaResCodigo.Text.Trim().Length > 0 Then
                        ACControles.ACDialogos.ACMostrarMensajeInformacion(String.Format("Información: {0}", Me.Text), String.Format("El Documento de Identidad {0} no existe, el documento ingresado tienen menos de 8 numeros", actxaResCodigo.Text))
                        actxaResCodigo.Focus()
                    End If
                End If
            End If
        Catch ex As Exception
            ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso Cargar Cliente", ex)
        End Try
    End Sub

    Private Sub c1grdDetalle_AfterEdit(sender As Object, e As RowColEventArgs) Handles c1grdDetalle.AfterEdit
        Try
            If c1grdDetalle.Cols(e.Col).Name = "INROD_StockFisico" And e.Row > (c1grdDetalle.Rows.Fixed - 1) Then
                c1grdDetalle.FinishEditing()
                If IsNumeric(c1grdDetalle.Rows(e.Row)(e.Col).ToString()) Then
                    Dim _stock As Decimal = c1grdDetalle.Rows(e.Row)("INROD_StockFinal")
                    Dim _stockfisico As Decimal = c1grdDetalle.Rows(e.Row)("INROD_StockFisico")
                    If _stock = _stockfisico Then
                        c1grdDetalle.Rows(e.Row)("INROD_VeriCorrecto") = True
                    ElseIf _stock > _stockfisico Then
                        c1grdDetalle.Rows(e.Row)("INROD_VeriFaltante") = 0
                        c1grdDetalle.Rows(e.Row)("INROD_VeriFaltante") = Math.Abs(_stock - _stockfisico)
                        c1grdDetalle.Rows(e.Row)("INROD_VeriCorrecto") = False
                    ElseIf _stock < _stockfisico Then
                        c1grdDetalle.Rows(e.Row)("INROD_VeriFaltante") = 0
                        c1grdDetalle.Rows(e.Row)("INROD_VeriSobrante") = Math.Abs(_stock - _stockfisico)
                        c1grdDetalle.Rows(e.Row)("INROD_VeriCorrecto") = False
                    End If
                End If
            End If
        Catch ex As Exception
            ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso actualizar stock", ex)
        End Try
    End Sub

#End Region


 
    Private Sub btnExcel_Click(sender As Object, e As EventArgs)
        Try
            Utilitarios.ExportarXLS(c1grdDetalle, String.Format("{0}", Me.Text))
        Catch ex As Exception
            ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error al generar el documento excel", ex)
        End Try
    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        txtConsultar_ACAyudaClick(Nothing, Nothing)
    End Sub
    Private Sub txtConsultar_ACAyudaClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBusqueda.ACAyudaClick
        Try
            busquedaDatos(txtBusqueda.Text)
        Catch ex As Exception
            ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Convert.ToString(Text)), "No se puede cargar la ayuda de los conductores", ex)
        End Try
    End Sub
    Private Function busquedaDatos(ByVal x_cadena As String) As Boolean
        Try
            If IsNothing(txtBusqueda.Text) Then
                managerCTRL_InventarioRotativo.BuscarInventarioRotativo(BCTRL_InventarioRotativo.TBus.Codigo, AcFecha.ACFecha_De.Value.Date, AcFecha.ACFecha_A.Value.Date, txtBusqueda.Text)

            Else

                managerCTRL_InventarioRotativo.BuscarInventarioRotativo(BCTRL_InventarioRotativo.TBus.Fecha, AcFecha.ACFecha_De.Value.Date, AcFecha.ACFecha_A.Value.Date, txtBusqueda.Text)

            End If
            bs_ctrl_inventariorotativo = New BindingSource
            bs_ctrl_inventariorotativo.DataSource = managerCTRL_InventarioRotativo.ListCTRL_InventarioRotativo
            c1grdBusqueda.DataSource = bs_ctrl_inventariorotativo
            bnavBusqueda.BindingSource = bs_ctrl_inventariorotativo

        Catch ex As Exception
            ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), String.Format(Colecciones.getError("00101"), "Busqueda"), ex)
        End Try
        'Return False
    End Function
    Private Sub CargarDatos()
        Try
            bs_ctrl_inventariorotativo = New BindingSource()
            bs_ctrl_inventariorotativo.DataSource = managerCTRL_InventarioRotativo.CTRL_InventarioRotativo.ListCTRL_InventarioRotativoDetalle 'managerGenerarRegMercTransito.BABAS_IngresosCompra.ListABAS_IngresosCompra
            c1grdBusqueda.DataSource = bs_ctrl_inventariorotativo
            bnavBusqueda.BindingSource = bs_ctrl_inventariorotativo
            AddHandler bs_ctrl_inventariorotativo.CurrentChanged, AddressOf bs_ctrl_inventariorotativo_CurrentChanged
            bs_ctrl_inventariorotativo_CurrentChanged(Nothing, Nothing)
            'chkAgrupar_CheckedChanged(Nothing, Nothing)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub bs_ctrl_inventariorotativo_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If Not IsNothing(bs_ctrl_inventariorotativo.Current) Then
                If CType(bs_ctrl_inventariorotativo.Current, EABAS_IngresosCompra).INGCO_Estado = EABAS_IngresosCompra.getEstado(EABAS_IngresosCompra.Estado.Confirmado) Then
                    acTool.ACBtnModificarEnabled = False
                    acTool.ACBtnAnularVisible = False
                    actsbtnPrevisualizar.Visible = True
                    acTool.ACBtnModificarEnabled = False
                ElseIf CType(bs_ctrl_inventariorotativo.Current, EABAS_IngresosCompra).INGCO_Estado = EABAS_IngresosCompra.getEstado(EABAS_IngresosCompra.Estado.Anulado) Then
                    acTool.ACBtnModificarEnabled = False
                    acTool.ACBtnAnularVisible = False
                    actsbtnPrevisualizar.Visible = True
                Else
                    acTool.ACBtnModificarEnabled = True
                    acTool.ACBtnAnularVisible = False
                    actsbtnPrevisualizar.Visible = True
                    acTool.ACBtnModificarEnabled = True
                End If
            End If
        Catch ex As Exception
            ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso Cargar Propiedades del Cotización/Pedido", ex)
        End Try
    End Sub

    Private Sub AcTool_ACBtnNuevo_Click_1(sender As Object, e As EventArgs) Handles AcTool.ACBtnNuevo_Click
        Try
            formatearGrilla()
            setInstancia(ACUtilitarios.ACSetInstancia.Nuevo)
            txtSerie.Text = GApp.Almacen.ToString("000")
            Dim _where As New Hashtable
            _where.Add("INROT_Serie", New ACWhere(GApp.Almacen.ToString("000")))
            txtNumero.Text = managerCTRL_InventarioRotativo.getCorrelativo("INROT_Numero", _where)

            managerCTRL_InventarioRotativo.CTRL_InventarioRotativo = New ECTRL_InventarioRotativo
            managerCTRL_InventarioRotativo.CTRL_InventarioRotativo.ListCTRL_InventarioRotativoDetalle = New List(Of ECTRL_InventarioRotativoDetalle)
            managerCTRL_InventarioRotativo.CTRL_InventarioRotativo.Instanciar(ACEInstancia.Nuevo)
            bs_detalle = New BindingSource
            bs_detalle.DataSource = managerCTRL_InventarioRotativo.CTRL_InventarioRotativo.ListCTRL_InventarioRotativoDetalle
            c1grdDetalle.DataSource = bs_detalle
            bnavDetalle.BindingSource = bs_detalle



        Catch ex As Exception
            ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), String.Format(Colecciones.getError("00101"), "No se puede crear un documento de Inventario Rotativo"), ex)
        End Try
    End Sub

    Private Sub AcTool_ACBtnGrabar_Click_1(sender As Object, e As EventArgs) Handles AcTool.ACBtnGrabar_Click
        'MsgBox("Grabar")
        Try

            If ACControles.ACDialogos.ACMostrarMensajePregunta(String.Format("Grabar Registro: {0}", Me.Text) _
                                        , String.Format("Desea Grabar el registro: {0}{1}{2}", "IR", txtSerie.Text.Trim().PadLeft(3, "0"), txtNumero.Text.Trim().PadLeft(7, "0")) _
                                        , ACControles.ACDialogos.LabelBotom.Si_No) = DialogResult.Yes Then
                'managerCTRL_InventarioRotativo.CTRL_InventarioRotativo.ALMAC_Id = GApp.Almacen
                managerCTRL_InventarioRotativo.CTRL_InventarioRotativo.INROT_Serie = txtSerie.Text
                managerCTRL_InventarioRotativo.CTRL_InventarioRotativo.INROT_Numero = txtNumero.Text
                managerCTRL_InventarioRotativo.CTRL_InventarioRotativo.ENTID_CodigoResponsable = actxaResCodigo.Text
                managerCTRL_InventarioRotativo.CTRL_InventarioRotativo.INROT_Estado = ACEVentas.Constantes.getEstado(ACEVentas.Constantes.Estado.Ingresado)
                managerCTRL_InventarioRotativo.CTRL_InventarioRotativo.INROT_Observaciones = txtObservacion.Text + " "


                If managerCTRL_InventarioRotativo.GrabarInventarioRotativo(GApp.Usuario, True, GApp.Periodo) Then
                    ACControles.ACDialogos.ACMostrarMensajeSatisfactorio(String.Format("Información: {0}", Me.Text), String.Format(Colecciones.getError("01000")))
                    setInstancia(ACUtilitarios.ACSetInstancia.Deshacer)
                    btnConsultar_Click(Nothing, Nothing)
                Else
                    Throw New Exception("No se completo el proceso de grabar registro")
                End If
            End If

        Catch ex As Exception
            AcTool.setInstancia(ACControles.ACToolBarMantHorizontalNew.TipoInstancia.Nuevo)
            ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), String.Format(Colecciones.getError("00101"), "Grabando Arreglo"), ex)
        End Try
    End Sub

    Private Sub btnCargar_Click_1(sender As Object, e As EventArgs) Handles btnCargar.Click
        Try
            Dim _j As Integer = 1
            pgbar.Minimum = 0
            pgbar.Value = 0

            m_lineas_codigo = cmbLinea.SelectedValue
            Dim _linea As String
            If m_lineas_codigo = "000" Then
                _linea = Nothing
            ElseIf cmbsublinea.SelectedValue = "000" Then
                _linea = cmbLinea.SelectedValue
            Else
                _linea = cmbsublinea.SelectedValue
            End If

            If managerCTRL_InventarioRotativo.CTRLSS_InventarioRotativo(GApp.Periodo, GApp.Almacen, GApp.Zona, actxabusqueda.Text, _linea) Then
                Dim _ordenes As New List(Of ACEVentas.EVENT_DocsVentaDetalle)
                managerCTRL_InventarioRotativo.CTRL_InventarioRotativo.ListCTRL_InventarioRotativoDetalle = New List(Of ECTRL_InventarioRotativoDetalle)
                For Each item As ACEVentas.EArticulos In managerCTRL_InventarioRotativo.ListArticulos
                    Dim _inventario As New ECTRL_InventarioRotativoDetalle
                    _inventario.ARTIC_Codigo = item.ARTIC_Codigo
                    _inventario.ARTIC_Descripcion = item.ARTIC_Descripcion
                    _inventario.INROD_Stock = item.StockLocal
                    _inventario.INROD_Item = _j : _j += 1
                    _inventario.TIPOS_UnidadMedida = item.TIPOS_UnidadMedida
                    managerCTRL_InventarioRotativo.CTRL_InventarioRotativo.ListCTRL_InventarioRotativoDetalle.Add(_inventario)
                Next
                '' Ordenes de recojo pendientes de entrega
                If managerCTRL_InventarioRotativo.CTRLSS_PendientesOrdenes(dtpFecha.Value.Date, GApp.Almacen, _linea) Then
                    For Each item As ECTRL_InventarioRotativoDetalle In managerCTRL_InventarioRotativo.CTRL_InventarioRotativo.ListCTRL_InventarioRotativoDetalle
                        Dim _filter As New ACFiltrador(Of ACEVentas.EVENT_DocsVentaDetalle)
                        _filter.ACFiltro = String.Format("ARTIC_Codigo={0}", item.ARTIC_Codigo)
                        If _filter.ACFiltrar(managerCTRL_InventarioRotativo.ListVENT_DocsVentaDetalle).Count > 0 Then
                            item.INROD_PenOrdenes += _filter.ACListaFiltrada(0).Saldo
                            managerCTRL_InventarioRotativo.ListVENT_DocsVentaDetalle.Remove(_filter.ACListaFiltrada(0))
                        End If
                    Next
                End If
                '' Documentos de Venta Pendientes de entrega
                If managerCTRL_InventarioRotativo.CTRLSS_PendientesVentas(dtpFecha.Value.Date, GApp.Almacen, _linea) Then
                    For Each item As ECTRL_InventarioRotativoDetalle In managerCTRL_InventarioRotativo.CTRL_InventarioRotativo.ListCTRL_InventarioRotativoDetalle
                        Dim _filter As New ACFiltrador(Of ACEVentas.EVENT_DocsVentaDetalle)
                        _filter.ACFiltro = String.Format("ARTIC_Codigo={0}", item.ARTIC_Codigo)
                        If _filter.ACFiltrar(managerCTRL_InventarioRotativo.ListVENT_DocsVentaDetalle).Count > 0 Then
                            item.INROD_PenFacturas += _filter.ACListaFiltrada(0).Saldo
                            managerCTRL_InventarioRotativo.ListVENT_DocsVentaDetalle.Remove(_filter.ACListaFiltrada(0))
                        End If
                    Next
                End If
                '' Pedidos de Reposicion y pedidos pendientes de facturacion
                If managerCTRL_InventarioRotativo.CTRLSS_PedidoReposicion(dtpFecha.Value.Date, GApp.Almacen, _linea) Then
                    For Each item As ECTRL_InventarioRotativoDetalle In managerCTRL_InventarioRotativo.CTRL_InventarioRotativo.ListCTRL_InventarioRotativoDetalle
                        Dim _filter As New ACFiltrador(Of ACEVentas.EVENT_DocsVentaDetalle)
                        _filter.ACFiltro = String.Format("ARTIC_Codigo={0}", item.ARTIC_Codigo)
                        If _filter.ACFiltrar(managerCTRL_InventarioRotativo.ListVENT_DocsVentaDetalle).Count > 0 Then
                            item.INROD_PenPedidos += _filter.ACListaFiltrada(0).Saldo
                            managerCTRL_InventarioRotativo.ListVENT_DocsVentaDetalle.Remove(_filter.ACListaFiltrada(0))
                        End If
                    Next
                End If

                If managerCTRL_InventarioRotativo.CTRLSS_CompraSinConfirmar(dtpFecha.Value.Date, GApp.Almacen, _linea) Then
                    For Each item As ECTRL_InventarioRotativoDetalle In managerCTRL_InventarioRotativo.CTRL_InventarioRotativo.ListCTRL_InventarioRotativoDetalle
                        Dim _filter As New ACFiltrador(Of ACEVentas.EVENT_DocsVentaDetalle)
                        _filter.ACFiltro = String.Format("ARTIC_Codigo={0}", item.ARTIC_Codigo)
                        If _filter.ACFiltrar(managerCTRL_InventarioRotativo.ListVENT_DocsVentaDetalle).Count > 0 Then
                            item.INROD_PenConfirmacion += _filter.ACListaFiltrada(0).Saldo
                            managerCTRL_InventarioRotativo.ListVENT_DocsVentaDetalle.Remove(_filter.ACListaFiltrada(0))
                        End If
                    Next
                End If

                '' Sumar los Totales
                For Each item As ECTRL_InventarioRotativoDetalle In managerCTRL_InventarioRotativo.CTRL_InventarioRotativo.ListCTRL_InventarioRotativoDetalle
                    item.INROD_Pendiente = item.INROD_PenConfirmacion + item.INROD_PenFacturas + item.INROD_PenOrdenes + item.INROD_PenPedidos
                    item.INROD_StockFinal = item.INROD_Stock + item.INROD_Pendiente
                Next

                bs_detalle.DataSource = managerCTRL_InventarioRotativo.CTRL_InventarioRotativo.ListCTRL_InventarioRotativoDetalle
                c1grdDetalle.DataSource = bs_detalle
                bnavDetalle.BindingSource = bs_detalle
            End If
        Catch ex As Exception
            ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), String.Format(Colecciones.getError("00101"), "el listado de productos"), ex)
        End Try
    End Sub

    Private Sub acTool_ACBtnVolver_Click(sender As Object, e As EventArgs) Handles AcTool.ACBtnVolver_Click
        tabMantenimiento.SelectedTab = tabBusqueda
        AcTool.ACBtnVolverVisible = False
        AcTool.ACBtnBuscarVisible = False
        AcTool.ACBtnCancelarVisible = False
        AcTool.ACBtnNuevoVisible = False
        AcTool.ACBtnModificarVisible = False
        AcTool.ACBtnImprimirVisible = False
        actsbtnPrevisualizar.Visible = True
        AcTool.ACBtnAnularVisible = False
        AcTool.ACBtnGrabarVisible = False
        AcTool.ACBtnNuevoVisible = True
        ' grpDocumento.BackColor = Color.DarkBlue
        grpPie.BackColor = Color.DarkBlue
        acpnlTitulo.InactiveGradientLowColor = Color.DarkBlue
        acpnlTitulo.InactiveGradientHighColor = Color.CornflowerBlue
    End Sub
 

    Private Sub tabMantenimiento_SelectionChanged(sender As Crownwood.DotNetMagic.Controls.TabControl, oldPage As Crownwood.DotNetMagic.Controls.TabPage, newPage As Crownwood.DotNetMagic.Controls.TabPage) Handles tabMantenimiento.SelectionChanged

    End Sub

    Private Sub AcTool_ACBtnSalir_Click(sender As Object, e As EventArgs) Handles AcTool.ACBtnSalir_Click
        Me.Close()

    End Sub

    Private Sub actsbtnPrevisualizar_Click(sender As Object, e As EventArgs) Handles actsbtnPrevisualizar.Click
        Try
            Dim _codigo As String = CType(bs_ctrl_inventariorotativo.Current, ECTRL_InventarioRotativo).INROT_Codigo
            If managerCTRL_InventarioRotativo.Cargar(_codigo, True) Then
                setInstancia(ACUtilitarios.ACSetInstancia.Previsualizar)
                AsignarBinding()
                CargarEntidad()
                bs_ctrl_inventariorotativo = New BindingSource
                bs_ctrl_inventariorotativo.DataSource = managerCTRL_InventarioRotativo.CTRL_InventarioRotativo.ListCTRL_InventarioRotativoDetalle '.ListCTRL_ArreglosDetalle
                c1grdDetalle.DataSource = bs_ctrl_inventariorotativo
                bnavDetalle.BindingSource = bs_ctrl_inventariorotativo
                ' txtCodigo.Text = String.Format("{0} {1}-{2:0000000}", CType(cmbTArreglo.SelectedItem, ETipos).TIPOS_DescCorta, txtSerie.Text, managerArreglos.CTRL_Arreglos.ARREG_Numero)
                'setInstancia(ACUtilitarios.ACSetInstancia.Previsualizar)

            End If

        Catch ex As Exception
            ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), String.Format(Colecciones.getError("00101"), "Revisar"), ex)
        End Try
    End Sub
    ''' <summary>
    ''' Realiza el enlace de los controles visuales con la clase esquema
    ''' </summary>
    Private Sub AsignarBinding()
        Try
            m_listBindHelper = New List(Of ACBindHelper)()
            ' m_listBindHelper.Add(ACBindHelper.ACBind(cmbTArreglo, "SelectedValue", managerCTRL_InventarioRotativo.CTRL_Arreglos, "TIPOS_CodTipoArreglo"))
            m_listBindHelper.Add(ACBindHelper.ACBind(txtSerie, "Text", managerCTRL_InventarioRotativo.CTRL_InventarioRotativo, "INROT_Serie"))
            m_listBindHelper.Add(ACBindHelper.ACBind(txtNumero, "Text", managerCTRL_InventarioRotativo.CTRL_InventarioRotativo, "INROT_Numero"))
            m_listBindHelper.Add(ACBindHelper.ACBind(txtObservacion, "Text", managerCTRL_InventarioRotativo.CTRL_InventarioRotativo, "INROT_Observaciones"))
            m_listBindHelper.Add(ACBindHelper.ACBind(actxaResCodigo, "Text", managerCTRL_InventarioRotativo.CTRL_InventarioRotativo, "ENTID_CodigoResponsable"))

            If managerCTRL_InventarioRotativo.CTRL_InventarioRotativo.INROT_Fecha.Year < 1700 Then managerCTRL_InventarioRotativo.CTRL_InventarioRotativo.INROT_Fecha = DateTime.Now
            m_listBindHelper.Add(ACBindHelper.ACBind(dtpFecha, "Value", managerCTRL_InventarioRotativo.CTRL_InventarioRotativo, "INROT_Fecha"))

            ' If managerCTRL_InventarioRotativo.CTRL_InventarioRotativo.ARREG_FechaIngreso.Year < 1700 Then managerCTRL_InventarioRotativo.CTRL_InventarioRotativo.ARREG_FechaIngreso = DateTime.Now
            '  m_listBindHelper.Add(ACBindHelper.ACBind(dtpFechaIngreso, "Value", managerCTRL_InventarioRotativo.CTRL_InventarioRotativo, "ARREG_FechaIngreso"))


        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub AcTool_ACBtnCancelar_Click(sender As Object, e As EventArgs) Handles AcTool.ACBtnCancelar_Click
        tabMantenimiento.SelectedTab = tabBusqueda
        AcTool.ACBtnVolverVisible = False
        AcTool.ACBtnBuscarVisible = False
        AcTool.ACBtnCancelarVisible = False
        AcTool.ACBtnNuevoVisible = False
        AcTool.ACBtnModificarVisible = False
        AcTool.ACBtnImprimirVisible = False
        actsbtnPrevisualizar.Visible = True
        AcTool.ACBtnAnularVisible = False
        AcTool.ACBtnGrabarVisible = False
        AcTool.ACBtnNuevoVisible = True
        ' grpDocumento.BackColor = Color.DarkBlue
        grpPie.BackColor = Color.DarkBlue
        acpnlTitulo.InactiveGradientLowColor = Color.DarkBlue
        acpnlTitulo.InactiveGradientHighColor = Color.CornflowerBlue
    End Sub

    Private Sub btnExcel_Click_1(sender As Object, e As EventArgs) Handles btnExcel.Click
        Try
            Utilitarios.ExportarXLS(c1grdDetalle, String.Format("{0}", Me.Text))
        Catch ex As Exception
            ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error al generar el documento excel", ex)
        End Try
    End Sub
End Class