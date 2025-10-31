Imports ACBLogistica
Imports DAConexion
Imports ACEVentas
Imports ACBVentas
Imports ACELogistica
Imports ACFramework
Imports ACSeguridad
Imports C1.Win.C1FlexGrid



Public Class ROrdenesIngreso

#Region " Variables "
    'Declare Auto Function FindWindow Lib "USER32.DLL" (ByVal LpClassName As String,ByVal LpWindowName As String)as IntPtr
    'Declare Auto Function SendMessageA Lib "user32.DLL" (ByVal hWnd As IntPtr,ByVal wMsg As Int32, ByVal wParam As Int32,
    '                                                     ByVal lParam As String)as Int32
    Private Const WM_CLOSE = &H10
    Dim estado as String
     Dim list As  ArrayList
    Private bs_pv As BindingSource
    Dim x_codigo As String
    Private bs_ordenes As BindingSource
    Private bs_puntoventa as BindingSource
    Private bs_tipodocfacturacion As BindingSource
    Private m_order As Integer = 1
    Private managerEntidades As BEntidades
    Private bs_reporte As BindingSource
    Public columna as Integer    
    Private m_listBindHelper As List(Of ACBindHelper)
    Private m_reporte As ACBLogistica.BReporte
    Private m_entid_codigo As String
    Private m_cargado As Boolean = False
#End Region
#Region " Constructores "
    Public Sub New(ByVal x_icono As System.Drawing.Bitmap)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Try

            
            m_reporte = New ACBLogistica.BReporte(GApp.Almacen, GApp.Periodo, GApp.Sucursal)
            managerEntidades = New BEntidades
            tabMantenimiento.HideTabsMode = Crownwood.DotNetMagic.Controls.HideTabsModes.HideAlways
            tabMantenimiento.SelectedTab = tabBusGuias

            actxaCliRuc.ACAyuda.Enabled = True
            actxaCliRazonSocial.ACActivarAyudaAuto = True
            actxaCliRuc.Enabled = True
            actxaCliRazonSocial.Enabled = True
            acTool.ACBtnNuevo.Visible = False
            acTool.ACBtnModificar.Visible = False
            actsbtnPrevisualizar.Visible = True
            formatearGrilla()
            cargarCombos()


             formatearGrillaPV()
            '''puntos de venta
            bs_pv = New BindingSource
            Dim _filter As New ACFramework.ACFiltrador(Of EPuntoVenta)(String.Format("PVENT_Activo=True"))

            Colecciones.GetPuntoVentaxAlmacen(GApp.Almacen)
            bs_pv.DataSource = _filter.ACFiltrar(Colecciones.PuntosVentaxAlmacen)
            c1grdPuntosVentas.DataSource = bs_pv


            If c1grdPuntosVentas.DataSource.Count>1 Then
                GroupBox3.Visible=True
                GroupBox1.Size()= New Size(712,48)
                Else 
                GroupBox3.Visible=False
                GroupBox1.Size()= New Size(948,48)
                For items = 1 To c1grdPuntosVentas.Rows.Count - 1
                    c1grdPuntosVentas.Rows(1)("Seleccionar") = true'item_tabla("CANT_ItemPendiente")
                Next
            End If




            If Not IsNothing(x_icono) Then Me.Icon = Icon.FromHandle(x_icono.GetHicon)

        Catch ex As Exception
            ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), Colecciones.getError("00000"), ex)
        End Try
    End Sub

      Public Sub New(ByVal OPCION As Boolean, ByVal x_codigo As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Try

            
            m_reporte = New ACBLogistica.BReporte(GApp.Almacen, GApp.Periodo, GApp.Sucursal)
            managerEntidades = New BEntidades
            tabMantenimiento.HideTabsMode = Crownwood.DotNetMagic.Controls.HideTabsModes.HideAlways
            tabMantenimiento.SelectedTab = tabBusGuias

            actxaCliRuc.ACAyuda.Enabled = False
            actxaCliRazonSocial.ACActivarAyudaAuto = False
            actxaCliRuc.Enabled = False
            actxaCliRazonSocial.Enabled = False
            acTool.ACBtnNuevo.Visible = False
            acTool.ACBtnModificar.Visible = False
            actsbtnPrevisualizar.Visible = False
            cmbPuntoVenta.Enabled=False
            cmbDirOrigen.Enabled=False
            cmbDirCliente.Enabled=False
            txtDirDestino.Enabled=False
            txtObservaciones.Enabled=False
            formatearGrilla()
            
            cargarCombos()


             formatearGrillaPV()
            '''puntos de venta
            bs_pv = New BindingSource
            Dim _filter As New ACFramework.ACFiltrador(Of EPuntoVenta)(String.Format("PVENT_Activo=True"))

            Colecciones.GetPuntoVentaxAlmacen(GApp.Almacen)
            bs_pv.DataSource = _filter.ACFiltrar(Colecciones.PuntosVentaxAlmacen)
            c1grdPuntosVentas.DataSource = bs_pv


            If c1grdPuntosVentas.DataSource.Count>1 Then
                GroupBox3.Visible=True
                GroupBox1.Size()= New Size(712,48)
                Else 
                GroupBox3.Visible=False
                GroupBox1.Size()= New Size(948,48)
                For items = 1 To c1grdPuntosVentas.Rows.Count - 1
                    c1grdPuntosVentas.Rows(1)("Seleccionar") = true'item_tabla("CANT_ItemPendiente")
                Next
            End If

             IF OPCION Then
               tabMantenimiento.SelectedTab = tabDatos
                caragarsoloDetalle(x_codigo)
            End If
            setInstancia(ACUtilitarios.ACSetInstancia.Modificado)
            AsignarBinding()



        Catch ex As Exception
            ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), Colecciones.getError("00000"), ex)
        End Try
    End Sub

#End Region

#Region "metodos"
    Private Sub formatearGrilla()

        Dim index As Integer = 1
        Try

            index = 1

            ACFrameworkC1.ACUtilitarios.ACFormatearGrilla(c1grdDetalle, 1, 1, 8, 1, 0)
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdDetalle, index, "Item", "ORDET_Item", "ORDET_Item", 80, True, False, "System.Integer", "#0") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdDetalle, index, "Codigo", "ARTIC_Codigo", "ARTIC_Codigo", 80, True, False, "System.String") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdDetalle, index, "Cantidad", "ORDET_Cantidad", "GUIRD_Cantidad", 75, True, False, "System.Decimal", Parametros.GetParametro(EParametros.TipoParametros.pg_FMondo2d)) : index += 1            
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdDetalle, index, "Unidad", "TIPOS_UnidadMedida", "TIPOS_UnidadMedida", 69, True, False, "System.String") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdDetalle, index, "Descripción", "ARTIC_Descripcion", "ARTIC_Descripcion", 191, True, False, "System.String") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdDetalle, index, "Peso Unitario", "PesoUnitario", "PesoUnitario", 75, True, False, "System.Decimal", Parametros.GetParametro(EParametros.TipoParametros.pg_FMondo4d)) : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdDetalle, index, "Kardex", "kardex", "kardex", 150, True, False, "System.Boolean") : index += 1
            
            c1grdDetalle.AllowEditing = True
            c1grdDetalle.AutoResize = True
            c1grdDetalle.AllowResizing = True
            c1grdDetalle.Cols(0).Width = 15
            c1grdDetalle.ExtendLastCol = False
            c1grdDetalle.AllowSorting = AllowSortingEnum.SingleColumn

            c1grdDetalle.Styles.Alternate.BackColor = Color.LightGray
            c1grdDetalle.Styles.Fixed.TextAlign = TextAlignEnum.CenterCenter
            c1grdDetalle.Styles.Highlight.BackColor = Color.Gray
            c1grdDetalle.SelectionMode = SelectionModeEnum.Row
            c1grdDetalle.AllowResizing = AllowResizingEnum.Columns

            Dim tt As C1.Win.C1FlexGrid.CellStyle = c1grdDetalle.Styles.Add("Total")
            tt.BackColor = Color.LightGreen
            tt.ForeColor = Color.DarkBlue
            tt.Font = New Font(c1grdDetalle.Font, FontStyle.Regular)

            Dim uu As C1.Win.C1FlexGrid.CellStyle = c1grdDetalle.Styles.Add("Entregado")
            uu.BackColor = Color.DarkSlateBlue
            uu.ForeColor = Color.White
            uu.Font = New Font(c1grdDetalle.Font, FontStyle.Regular)

            Dim dd As C1.Win.C1FlexGrid.CellStyle = c1grdDetalle.Styles.Add("ORDET_Cantidad")
            dd.BackColor = Color.Green
            dd.ForeColor = Color.White
            dd.Font = New Font(c1grdDetalle.Font, FontStyle.Bold)
            c1grdDetalle.DrawMode = C1.Win.C1FlexGrid.DrawModeEnum.OwnerDraw

            Dim ddd As C1.Win.C1FlexGrid.CellStyle = c1grdDetalle.Styles.Add("Anulado")
            ddd.BackColor = Color.Maroon
            ddd.ForeColor = Color.White
            ddd.Font = New Font(c1grdDetalle.Font, FontStyle.Bold)
            c1grdDetalle.DrawMode = C1.Win.C1FlexGrid.DrawModeEnum.OwnerDraw


            index = 1
            ACFrameworkC1.ACUtilitarios.ACFormatearGrilla(c1grdReporte, 1, 1, 13, 1, 0)
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdReporte, index, "Tipo Doc.", "TIPO_Descripcion", "TIPO_Descripcion", 100, True, False, "System.String") : index += 1            
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdReporte, index, "Fec. Doc", "ORDEN_FechaIngreso", "ORDEN_FechaIngreso", 90, True, False, "System.DateTime", Parametros.GetParametro(EParametros.TipoParametros.pg_FormatoFecha)) : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdReporte, index, "Documento", "Documento", "Documento", 90, True, False, "System.String") : index += 1            
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdReporte, index, "Doc. Relacion", "DocVenta", "DocVenta", 90, True, False, "System.String") : index += 1            
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdReporte, index, "Raz. Social", "ORDEN_DescripcionCliente", "ORDEN_DescripcionCliente", 150, True, False, "System.String") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdReporte, index, "R.U.C. / D.N.I.", "ENTID_CodigoCliente", "ENTID_CodigoCliente", 90, True, False, "System.String") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdReporte, index, "P. Venta Origen", "PVENT_Origen", "PVENT_Origen", 90, True, False, "System.String") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdReporte, index, "P. Venta Destino", "PVENT_Destino", "PVENT_Destino", 90, True, False, "System.String") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdReporte, index, "Total Peso", "ORDEN_TotalPeso", "ORDEN_TotalPeso", 70, True, False, "System.Decimal", Parametros.GetParametro(ACEVentas.EParametros.TipoParametros.pg_FMondo2d)) : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdReporte, index, "Estado", "ORDEN_Estado_Text", "ORDEN_Estado_Text", 90, True, False, "System.String") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdReporte, index, "Revisión Control", "ORDEN_RevisadoControl", "ORDEN_RevisadoControl", 150, True, False, "System.Boolean") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdReporte, index, "Revisión Usuario", "ORDEN_RevisadoUsr", "ORDEN_RevisadoUsr", 150, True, False, "System.String") : index += 1
            c1grdReporte.AllowEditing = False
            c1grdReporte.Styles.Alternate.BackColor = Color.LightGray
            c1grdReporte.Styles.Fixed.TextAlign = TextAlignEnum.CenterCenter
            c1grdReporte.Styles.Highlight.BackColor = Color.Gray
            c1grdReporte.SelectionMode = SelectionModeEnum.Row
            c1grdReporte.AllowSorting = AllowSortingEnum.SingleColumn
          
            Dim s As CellStyle = c1grdReporte.Styles(CellStyleEnum.Subtotal0)
            s.BackColor = Color.Black
            s.ForeColor = Color.White
            s.Font = New Font(c1grdReporte.Font, FontStyle.Bold)

            s = c1grdReporte.Styles(CellStyleEnum.Subtotal1)
            s.BackColor = Color.DarkBlue
            s.ForeColor = Color.White
            s = c1grdReporte.Styles(CellStyleEnum.Subtotal2)
            s.BackColor = Color.DarkRed
            s.ForeColor = Color.White

            Dim k1 As C1.Win.C1FlexGrid.CellStyle = c1grdReporte.Styles.Add("Anulado")
            k1.BackColor = Color.Red
            k1.ForeColor = Color.White
            k1.Font = New Font(c1grdReporte.Font, FontStyle.Bold)

            Dim k3 As C1.Win.C1FlexGrid.CellStyle = c1grdReporte.Styles.Add("Confirmado")
            k3.BackColor = Color.Green
            k3.ForeColor = Color.White
            k3.Font = New Font(c1grdReporte.Font, FontStyle.Bold)

            Dim j1 As C1.Win.C1FlexGrid.CellStyle = c1grdReporte.Styles.Add("ISoles")
            j1.BackColor = Color.DarkBlue
            j1.ForeColor = Color.White
            j1.Font = New Font(c1grdReporte.Font, FontStyle.Bold)

            Dim j2 As C1.Win.C1FlexGrid.CellStyle = c1grdReporte.Styles.Add("IDolares")
            j2.BackColor = Color.Blue
            j2.ForeColor = Color.White
            j2.Font = New Font(c1grdReporte.Font, FontStyle.Bold)

            Dim k2 As C1.Win.C1FlexGrid.CellStyle = c1grdReporte.Styles.Add("EDolares")
            k2.BackColor = Color.Red
            k2.ForeColor = Color.White
            k2.Font = New Font(c1grdReporte.Font, FontStyle.Bold)

            c1grdReporte.DrawMode = C1.Win.C1FlexGrid.DrawModeEnum.OwnerDraw

            c1grdReporte.Rows(0).AllowMerging = True
            c1grdReporte.Rows(0).AllowMerging = True


        Catch ex As Exception
            ACControles.ACDialogos.ACMostrarMensajeError("Error: " + Me.Text, "No se puede dar formato a la grilla", ex)
        End Try
    End Sub

    Private Sub formatearGrillaPV()

        Dim index As Integer = 1
        Try

             ACFrameworkC1.ACUtilitarios.ACFormatearGrilla(c1grdPuntosVentas, 1, 1, 3, 1)
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdPuntosVentas, index, "X", "Seleccionar", "Seleccionar", 80, True, True, "System.Boolean") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdPuntosVentas, index, "Punto de Venta", "PVENT_Descripcion", "PVENT_Descripcion", 150, True, False, "System.Decimal", Parametros.GetParametro(EParametros.TipoParametros.pg_FMondo2d)) : index += 1

            c1grdPuntosVentas.AllowEditing = True
            c1grdPuntosVentas.Styles.Alternate.BackColor = Color.LightGray
            c1grdPuntosVentas.Styles.Fixed.TextAlign = TextAlignEnum.CenterCenter
            c1grdPuntosVentas.Styles.Highlight.BackColor = Color.Gray
            c1grdPuntosVentas.SelectionMode = SelectionModeEnum.Row
       Catch ex As Exception
            ACControles.ACDialogos.ACMostrarMensajeError("Error: " + Me.Text, "No se puede dar formato a la grilla", ex)
        End Try
        End Sub

    Private Sub setCliente()
        '' Cargar datos adicionales cliente
        If actxaCliRuc.ACAyuda.Enabled = True Then
            If managerEntidades.CargarDocIden(actxaCliRuc.Text, EEntidades.TipoInicializacion.Direcciones) Then
                '' Cargar datos del cliente
                m_entid_codigo = managerEntidades.Entidades.ENTID_Codigo

                Dim x_direcciones As New EDirecciones
                x_direcciones.DIREC_Id = 0
                x_direcciones.Direccion = managerEntidades.Entidades.Direccion
                x_direcciones.UBIGO_Codigo = managerEntidades.Entidades.UBIGO_Codigo
                If IsNothing(managerEntidades.Entidades.ListDirecciones) Then managerEntidades.Entidades.ListDirecciones = New List(Of EDirecciones)()
                managerEntidades.Entidades.ListDirecciones.Insert(0, x_direcciones)

                actxaCliRazonSocial.Text = managerEntidades.Entidades.ENTID_RazonSocial
                actxaCliRuc.Text = managerEntidades.Entidades.ENTID_NroDocumento
            Else
                ACControles.ACDialogos.ACMostrarMensajeInformacion(String.Format("Documento de Identidad: {0}", Me.Text) _
                                , String.Format("El Documento de Identidad {0} no existe, ¿Desea Ingresar la Entidad?", actxaCliRuc.Text) _
                                )

                actxaCliRuc.Focus()
            End If
        End If
    End Sub
    Private Sub AyudaEntidad(ByVal x_cadenas As String, ByVal x_campo As String, ByVal x_descripcion As String, ByVal x_opcion As Short, ByVal x_opcionentidad As EEntidades.TipoEntidad)
        Try
            Dim _where As New Hashtable
            _where.Add(x_campo, New ACWhere(x_cadenas, ACWhere.TipoWhere._Like))
            If x_cadenas.Length = 0 Then
                Dim _campos() As ACCampos = {New ACCampos("@Opcion", x_opcion.ToString()), New ACCampos("@Cadena", x_cadenas), New ACCampos("@ROLES_Id", x_opcionentidad.GetHashCode.ToString())}
                Dim _busqueda As New ACCampos("@Cadena", x_descripcion)
                Dim AyudaText As New ACControlesC1.ACAyudaTextFlex("Buscar Entidad", "ENTISS_TodosAyuda", _campos, _busqueda, False)
                If AyudaText.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                    Select Case x_opcionentidad
                        Case EEntidades.TipoEntidad.Clientes
                            '' Cargar datos del cliente
                            m_entid_codigo = AyudaText.Respuesta.Rows(0)("Codigo")
                            actxaCliRazonSocial.Text = AyudaText.Respuesta.Rows(0)("Razon Social").ToString()
                            actxaCliRuc.Text = AyudaText.Respuesta.Rows(0)("Doc./R.U.C.").ToString()
                            setCliente()
                            btnProcesar.Focus()
                        Case EEntidades.TipoEntidad.Vendedores
                            Dim x_entid_codigo As String = AyudaText.Respuesta.Rows(0)("Codigo")
                    End Select
                End If
            Else
                If managerEntidades.Ayuda(_where, x_opcionentidad) Then
                    Dim Ayuda As New ACControlesC1.ACAyudaFlex("Buscar Entidad", managerEntidades.DTEntidades, False)
                    If Ayuda.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                        Select Case x_opcionentidad
                            Case EEntidades.TipoEntidad.Clientes
                                '' Cargar datos del cliente
                                m_entid_codigo = Ayuda.Respuesta.Rows(0)("Codigo")
                                actxaCliRazonSocial.Text = Ayuda.Respuesta.Rows(0)("Razon Social").ToString()
                                actxaCliRuc.Text = Ayuda.Respuesta.Rows(0)("Doc./R.U.C.").ToString()
                                setCliente()
                                btnProcesar.Focus()
                            Case EEntidades.TipoEntidad.Vendedores
                                Dim x_entid_codigo As String = Ayuda.Respuesta.Rows(0)("Codigo")
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
#End Region

    Private Sub btnProcesar_Click(sender As Object, e As EventArgs) Handles btnProcesar.Click 

        Try
            Dim _j As Integer = 1

            formatearGrilla()
            list = new ArrayList()
             For Each itemAlPV As EPuntoVenta In CType(BS_PV.DataSource, List(Of EPuntoVenta))
                    If itemAlPV.Seleccionar Then
                           If m_reporte.ObtenerOrdenes(GApp.Periodo,AcFecha.ACDtpFecha_De.Value.Date,AcFecha.ACDtpFecha_A.Value.Date, GApp.Almacen,ETipos.getTipoOrdenRecojo(ETipos.TipoOrdenRecojo.RecojoIngreso), actxaCliRuc.Text, chkctodos.Checked,itemAlPV.PVENT_Id) Then
                                list.AddRange(m_reporte.ListDIST_Ordenes)
                            End If
                    End If
            Next
            cargarDatos()
            c1grdReporte.AutoSizeCols()
           
            LiberarMemoria()
        Catch ex As Exception
            ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), Colecciones.getError("00000"), ex)
        End Try
    End Sub
    Private Sub cargarDatos()
        Try
            bs_ordenes = New BindingSource()
            'bs_ordenes.DataSource = m_reporte.ListDIST_Ordenes
            m_reporte.ListDIST_Ordenes= Nothing
            m_reporte.ListDIST_Ordenes= list.Cast(Of ACEVentas.EDIST_Ordenes).ToList()
            bs_ordenes.DataSource = m_reporte.ListDIST_Ordenes
            c1grdReporte.DataSource = bs_ordenes
            bnavCBusqueda.BindingSource = bs_ordenes
            AddHandler bs_ordenes.CurrentChanged, AddressOf bs_ordenes_CurrentChanged
            bs_ordenes_CurrentChanged(Nothing, Nothing)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub bs_ordenes_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If Not IsNothing(bs_ordenes) Then
                If Not IsNothing(bs_ordenes.Current) Then
                    If CType(bs_ordenes.Current, ACEVentas.EDIST_Ordenes).Orden_estado = ACELogistica.EDIST_GuiasRemision.getEstado(ACELogistica.EDIST_GuiasRemision.Estado.Ingresado) Then
                        acTool.ACBtnAnularEnabled = True
                    Else
                        acTool.ACBtnAnularEnabled = False
                    End If
                End If
            End If
        Catch ex As Exception
            ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso Cargar Propiedades del Cotización/Pedido", ex)
        End Try
    End Sub

    Private Sub actxaCliRuc_ACAyudaClick_1(sender As Object, e As EventArgs) Handles actxaCliRuc.ACAyudaClick 
        Try
            AyudaEntidad(actxaCliRuc.Text, "ENTID_NroDocumento", "Razon Social", 1, EEntidades.TipoEntidad.Clientes)
        Catch ex As Exception
            ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso Documento de Identidad", ex)
        End Try
    End Sub

  

    Private Sub c1grdReporte_OwnerDrawCell_1(sender As Object, e As OwnerDrawCellEventArgs) Handles c1grdReporte.OwnerDrawCell 
        Try
            If e.Row < c1grdReporte.Rows.Fixed OrElse e.Col < c1grdReporte.Cols.Fixed Then Return
            If c1grdReporte.Rows(e.Row)("ORDEN_Estado_Text") = "Confirmado" Then
                e.Style = c1grdReporte.Styles("Confirmado")
            End If
            If c1grdReporte.Rows(e.Row)("ORDEN_Estado_Text") = "Anulado" Then
                e.Style = c1grdReporte.Styles("Anulado")
            End If

        Catch ex As Exception
            ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso cambia de color", ex)
        End Try
    End Sub

    Private Sub tsbtnExcel_Click(sender As Object, e As EventArgs) Handles tsbtnExcel.Click 
        Try
            Utilitarios.ExportarXLS(c1grdReporte, "Ordenes de Ingreso")
        Catch ex As Exception
            ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso Exportar a Excel", ex)
        End Try
    End Sub

      Private Sub Calcular()
        Try
            Dim _peso As Decimal = 0
            For Each Item As ACEVentas.EDIST_OrdenesDetalle In m_reporte.DIST_Ordenes.ListDIST_OrdenesDetalle
                _peso += Item.ORDET_Cantidad * Item.PesoUnitario
            Next
            actxnPesoTotal.Text = _peso
            actxnPesoTotal.Formatear()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub actsbtnPrevisualizar_Click(sender As Object, e As EventArgs) Handles actsbtnPrevisualizar.Click 
        Try
            If Not IsNothing(bs_ordenes) Then
                If Not IsNothing(bs_ordenes.Current) Then
                    x_codigo = CType(bs_ordenes.Current, ACEVentas.EDIST_Ordenes).ORDEN_Codigo
                    Dim x_confir As Boolean = CType(bs_ordenes.Current, ACEVentas.EDIST_Ordenes).ORDEN_RevisadoControl
                    ' InitControles(False)
                    If x_confir = True Then
                        btnRevision.Visible=False
                        Else 
                        btnRevision.Visible=True
                    End If
                    cargarGuia(x_codigo)
                    Calcular()
                    acTool.ACBtnVolverVisible = True
                    acTool.ACBtnBuscarVisible = False
                    acTool.ACBtnCancelarVisible = False
                    acTool.ACBtnImprimirVisible = False
                    actsbtnPrevisualizar.Visible = False
                    acTool.ACBtnAnularVisible = False

                    Dim _validate As ACValidarUsuario
                    _validate = New ACValidarUsuario(GApp.DataConexion, GApp.DataUsuario, ACValidarUsuario.Operacion.ValidarVariosProcesos)
                    For Each item As ACSeguridad.EProcesos In _validate.ListProcesos
                        Select Case item.PROC_Codigo
                            Case Procesos.getProceso(Procesos.TipoProcesos.Desp_AnularGuiasTrasSalMismoDia)
                                If Not acpnlTitulo.Active Then
                                    acTool.ACBtnAnularVisible = True
                                End If
                            Case Procesos.getProceso(Procesos.TipoProcesos.Desp_AnularGuiasTrasSalPosteriores)
                                If Not acpnlTitulo.Active Then
                                    acTool.ACBtnAnularVisible = True
                                    ' m_pgremisionp = True
                                End If
                        End Select
                    Next
                    setInstancia(ACUtilitarios.ACSetInstancia.Previsualizar)
                  Else
                    ACControles.ACDialogos.ACMostrarMensajeInformacion(String.Format("Información: {0}", Me.Text), "No se puede visualizar por que no ha seleccionado ningun registro")
                End If
            Else
                ACControles.ACDialogos.ACMostrarMensajeInformacion(String.Format("Información: {0}", Me.Text), "No se puede visualizar por que no se ha cargado ningun registro")
            End If
           
        Catch ex As Exception
            ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso Visualizar Documento", ex)
        End Try

    End Sub
#Region "Cargar Datos"
    Private Sub AsignarBinding()
        Try
            m_listBindHelper = New List(Of ACBindHelper)()
            If m_reporte.DIST_Ordenes.ORDEN_FechaIngreso.Year < 1700 Then m_reporte.DIST_Ordenes.ORDEN_FechaIngreso = DateTime.Now
            m_listBindHelper.Add(ACBindHelper.ACBind(dtpFechaEmision, "Value", m_reporte.DIST_Ordenes, "ORDEN_FechaIngreso"))
            
            m_listBindHelper.Add(ACBindHelper.ACBind(cmbPuntoVenta, "SelectedValue", m_reporte.DIST_Ordenes, "PVENT_IdDestino"))
            m_listBindHelper.Add(ACBindHelper.ACBind(cmbentrega, "SelectedValue", m_reporte.DIST_Ordenes, "ORDEN_EstEntrega"))
            m_listBindHelper.Add(ACBindHelper.ACBind(actxaCodCliente, "Text", m_reporte.DIST_Ordenes, "ENTID_CodigoCliente"))
            m_listBindHelper.Add(ACBindHelper.ACBind(actxaDescCliente, "Text", m_reporte.DIST_Ordenes, "ORDEN_DescripcionCliente"))
            m_listBindHelper.Add(ACBindHelper.ACBind(txtDirDestino, "Text", m_reporte.DIST_Ordenes, "ORDEN_DireccionDestino"))
            m_listBindHelper.Add(ACBindHelper.ACBind(txtObservaciones, "Text", m_reporte.DIST_Ordenes, "ORDEN_Observaciones"))
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
#End Region
#Region "Procesos"
    Private Sub cargarCombos()
        Try
            Dim listBusGuia As New List(Of ETipos)()
            For Each item As ETipos In Colecciones.TiposDocsTraslado
                listBusGuia.Add(item.Clone())
            Next

           
            ACUtilitarios.ACCargaCombo(cmbEntrega, Colecciones.ListEstadoEntregaOrden, ACLista.Descripcion, ACLista.Codigo)

             Dim _list As New List(Of EPuntoVenta)

             For Each item As EPuntoVenta In  Colecciones.PuntosVentaDespachos
                If GApp.Almacen <> item.ALMAC_Id Then
                   _list.Add(item.Clone())
                End If
             Next
             bs_puntoventa = New BindingSource
             bs_puntoventa.DataSource = _list
             ACFramework.ACUtilitarios.ACCargaCombo(cmbPuntoVenta, bs_puntoventa, "PVENT_Descripcion", "PVENT_Id")
        
             ACFramework.ACUtilitarios.ACCargaCombo(cmbtipoordenes, Colecciones.Tipos(ETipos.MyTipos.TipoOrdenRecojo), "TIPOS_Descripcion", "TIPOS_Codigo", ETipos.getTipoOrdenRecojo(ETipos.TipoOrdenRecojo.RecojoIngreso))

          
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub cargarGuia(ByVal x_codigo As String)
        Try
            If m_reporte.CargarOrdenes(x_codigo) Then
                estado=""
                cargarCliente(m_reporte.DIST_Ordenes.ENTID_CodigoCliente)

                cmbDirOrigen.Text=m_reporte.DIST_Ordenes.ORDEN_DireccionOrigen
                txtDirDestino.Text=m_reporte.DIST_Ordenes.ORDEN_DireccionDestino
                txtObservaciones.Text=m_reporte.DIST_Ordenes.ORDEN_Observaciones
                
                 If  m_reporte.DIST_Ordenes.DOCVE_Codigo Isnot Nothing AND Len(m_reporte.DIST_Ordenes.DOCVE_Codigo)<=12 then
                        If  m_reporte.DIST_Ordenes.DOCVE_Codigo.Substring(0,2)="01"
                        txtDocOrigen.Text="Fact-"+m_reporte.DIST_Ordenes.DOCVE_Codigo.Substring(2,3)+"-"+m_reporte.DIST_Ordenes.DOCVE_Codigo.Substring(5,7)
                        ElseIf m_reporte.DIST_Ordenes.DOCVE_Codigo.Substring(0,2)="03"
                        txtDocOrigen.Text="Bol-"+m_reporte.DIST_Ordenes.DOCVE_Codigo.Substring(2,3)+"-"+m_reporte.DIST_Ordenes.DOCVE_Codigo.Substring(5,7)
                        End If
                    ELSE
                        If  m_reporte.DIST_Ordenes.DOCVE_Codigo.Substring(0,2)="01"
                        txtDocOrigen.Text="Fact-"+m_reporte.DIST_Ordenes.DOCVE_Codigo.Substring(2,4)+"-"+m_reporte.DIST_Ordenes.DOCVE_Codigo.Substring(6,7)
                        ElseIf m_reporte.DIST_Ordenes.DOCVE_Codigo.Substring(0,2)="03"
                        txtDocOrigen.Text="Bol-"+m_reporte.DIST_Ordenes.DOCVE_Codigo.Substring(2,4)+"-"+m_reporte.DIST_Ordenes.DOCVE_Codigo.Substring(6,7)
                        End If
                End If
                
                cmbGuiaSerie.Text=m_reporte.DIST_Ordenes.ORDEN_Serie
                actxnNumero.Text=m_reporte.DIST_Ordenes.ORDEN_Numero
                actxnPesoTotal.Text=m_reporte.DIST_Ordenes.ORDEN_TotalPeso
                cmbtipoordenes.SelectedValue=m_reporte.DIST_Ordenes.TIPOS_CodTipoOrden

                AsignarBinding()
                tabMantenimiento.SelectedTab = tabDatos
                bs_reporte = New BindingSource
                bs_reporte.DataSource = m_reporte.DIST_Ordenes.ListDIST_Ordenesdetalle
                bnavProductos.BindingSource = bs_reporte
                c1grdDetalle.DataSource = bs_reporte

                
                If m_reporte.ControlyVerificacionKardex(GApp.Almacen,x_codigo ,m_reporte.DIST_Ordenes.TIPOS_CodTipoOrden ) Then
                        Dim _ik As Integer = 1
                        For items = 1 To c1grdDetalle.Rows.Count - 1

                                 For Each item_tabla As DataRow In m_reporte.DTReportes.Rows
                                        If item_tabla(2) = c1grdDetalle.Rows(items)("ARTIC_Codigo") And item_tabla(1) = c1grdDetalle.Rows(items)("ORDET_Item") And item_tabla(3) = c1grdDetalle.Rows(items)("ORDET_Cantidad") Then
                                              c1grdDetalle.Rows(_ik)("kardex") = item_tabla(4)
                                        End If
                                 Next
                                    _ik += 1
                                  Next
                        End If
                

                If m_reporte.DIST_Ordenes.ORDEN_Estado.Equals("X") Then
                    estado="X"
                   
                    
                    If m_reporte.DIST_Ordenes.ORDEN_MotivoAnulacion is Nothing   Then
                        txtMotivoAnulacion.Text = "Fecha: " & m_reporte.DIST_Ordenes.ORDEN_FecMod & " Usuario:" & m_reporte.DIST_Ordenes.Usuario_Modificador  
                    Else 
                        txtMotivoAnulacion.Text =m_reporte.DIST_Ordenes.ORDEN_MotivoAnulacion
                    End If

                    
                    dtpFechaAnulacion.Value = m_reporte.DIST_Ordenes.ORDEN_FecMod
                    'txtrevision.Visible = True
                    'lblrevision.Visible = True
                    tbcDetalles.Visible = True
                    acpnlTitulo.Active = True
                     grpDocumento.BackColor = Color.Maroon
                    pnlPie.BackColor = Color.Maroon
                    acpnlTitulo.InactiveGradientLowColor = Color.Maroon
                    acpnlTitulo.InactiveGradientHighColor = Color.Maroon

                  
                Else
                    txtMotivoAnulacion.Clear()
                    tbcDetalles.Visible = false
                    acpnlTitulo.Active = False
                    grpFlete.BackColor = Color.FromArgb(3, 55, 145)
                    pnlPie.BackColor = Color.FromArgb(3, 55, 145)
                    grpDocumento.BackColor = Color.FromArgb(3, 55, 145)
                  End If
                
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub




    Private Sub cargarCliente(ByVal x_entid_codigo As String)
        Try
            If managerEntidades.Cargar(x_entid_codigo, EEntidades.TipoInicializacion.EntTipos_Dir_Tel) Then
                actxaDescCliente.Text = managerEntidades.Entidades.ENTID_RazonSocial
                actxaCodCliente.Text = managerEntidades.Entidades.ENTID_Codigo
                cmbDirCliente.Text=managerEntidades.Entidades.ENTID_Direccion

            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub setInstancia(ByVal _opcion As ACUtilitarios.ACSetInstancia)
        Try
            actxaCodCliente.ACAyuda.Enabled = True
            actxaCodCliente.ACActivarAyuda = True
            'actxaCodCliente.ReadOnly = True
            actxaDescCliente.ACAyuda.Enabled = True
            actxaDescCliente.ACActivarAyuda = True
            actxaDescCliente.ReadOnly = False
            'actxaDescCliente.ReadOnly = True

            acTool.ACBtnEliminarVisible = False
            Select Case _opcion
                Case ACUtilitarios.ACSetInstancia.Nuevo
                    ACUtilitarios.ACLimpiaVar(pnlCabecera)
                    ACUtilitarios.ACSetControl(pnlCabecera, False, ACUtilitarios.TipoPropiedad.ACReadOnly)
                    actxaCodCliente.Focus()
                    actsbtnPrevisualizar.Visible = False

                    ''.00
                Case ACUtilitarios.ACSetInstancia.Modificado
                  
                    acTool.ACBtnModificarVisible = False
                    acTool.ACBtnBuscarVisible = False
                    acTool.ACBtnImprimirVisible = False
                    actsbtnPrevisualizar.Visible = False
                    acTool.ACBtnSalir.Visible = True
                    acTool.ACBtnSalir.Enabled=True
                    acTool.ACBtnVolverVisible=False
                    Me.KeyPreview = False
               

                    ''.00000000000000000
                Case ACUtilitarios.ACSetInstancia.Guardar
                    acTool.ACBtnImprimirVisible = False
                    acTool.ACBtnBuscarVisible = True
                    actsbtnPrevisualizar.Visible = True
                Case ACUtilitarios.ACSetInstancia.Deshacer
                    acTool.ACBtnModificarVisible = False
                    acTool.ACBtnBuscarVisible = False
                    acTool.ACBtnImprimirVisible = False
                    actsbtnPrevisualizar.Visible = True
                     tabMantenimiento.SelectedTab = tabBusGuias
                    acTool.ACBtnVolverVisible = False
                    acTool.ACBtnBuscarVisible = False
                    acTool.ACBtnCancelarVisible = False
                    acTool.ACBtnNuevoVisible = False
                    acTool.ACBtnModificarVisible = False
                    acTool.ACBtnImprimirVisible = False
                    actsbtnPrevisualizar.Visible = True
                    acTool.ACBtnAnularVisible = False
                    acpnlTitulo.Active = False
                    Me.KeyPreview = False
              Case ACUtilitarios.ACSetInstancia.Previsualizar
                   ACUtilitarios.ACSetControl(pnlCabecera, True, ACUtilitarios.TipoPropiedad.ACReadOnly)
                    grpFlete.Enabled=False
                    pnlCabecera.Enabled=False
                    c1grdDetalle.Enabled=False
                    cmbDirOrigen.Enabled = True
                    cmbtipoordenes.Enabled = False
                    actsbtnPrevisualizar.Visible = False
                    acTool.ACBtnEliminarVisible = False
                    '' Asignar Permisos
                    Dim _validate As ACValidarUsuario
                    _validate = New ACValidarUsuario(GApp.DataConexion, GApp.DataUsuario, ACValidarUsuario.Operacion.ValidarVariosProcesos)
                    For Each item As ACSeguridad.EProcesos In _validate.ListProcesos
                        Select Case item.PROC_Codigo
                            Case Procesos.getProceso(Procesos.TipoProcesos.Desp_EliGuiaRemSalTralado)
                                acTool.ACBtnEliminarVisible = True
                        End Select
                    Next
            End Select
            acTool.ACBtnModificarVisible = False
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region
    
    Private Sub acTool_ACBtnVolver_Click(sender As Object, e As EventArgs) Handles acTool.ACBtnVolver_Click 
       setInstancia(ACUtilitarios.ACSetInstancia.Deshacer)
        grpDocumento.BackColor = Color.DarkBlue
        pnlPie.BackColor = Color.DarkBlue
        acpnlTitulo.InactiveGradientLowColor = Color.DarkBlue
        acpnlTitulo.InactiveGradientHighColor = Color.CornflowerBlue
    End Sub

    Private Sub c1grdReporte_BeforeSort(sender As Object, ByVal e As C1.Win.C1FlexGrid.SortColEventArgs) Handles c1grdReporte.BeforeSort 
        Try
            Ordenar(c1grdReporte.Cols(e.Col).UserData)
        Catch ex As Exception
            ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso ordenar", ex)
        End Try
    End Sub

    Private Sub Ordenar(ByVal x_columna As String)
        Dim _ordenador As New ACOrdenador(Of ACEVENTAS.EDIST_Ordenes)
        Try
            If Not IsNothing(bs_ordenes) Then
                If Not IsNothing(bs_ordenes.Current) Then
                    If m_order = 2 Then x_columna &= " DESC"
                    _ordenador.ACOrdenamiento = x_columna
                    CType(bs_ordenes.DataSource, List(Of ACEVENTAS.EDIST_Ordenes)).Sort(_ordenador)
                    c1grdReporte.Refresh()
                    m_order = IIf(m_order = 1, 2, 1)
                End If
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub


    Private Sub c1grdReporte_BeforeDoubleClick(sender As Object, e As BeforeMouseDownEventArgs) Handles c1grdReporte.BeforeDoubleClick 
        actsbtnPrevisualizar_Click(Nothing, Nothing)
    End Sub

    Private Sub tabMantenimiento_SelectionChanged(sender As Crownwood.DotNetMagic.Controls.TabControl, oldPage As Crownwood.DotNetMagic.Controls.TabPage, newPage As Crownwood.DotNetMagic.Controls.TabPage) Handles tabMantenimiento.SelectionChanged 

    End Sub

Private Sub btnRevision_Click( sender As Object,  e As EventArgs) Handles btnRevision.Click 

        Try

            if m_reporte.Guias_VerificacionControlOrdenes(GApp.Almacen,m_reporte.DIST_Ordenes.ORDEN_Codigo,GApp.EUsuario.USER_CodUsr,m_reporte.DIST_Ordenes.TIPOS_CodTipoOrden,"1") Then
                'Timer1.Start()
                'Timer1.Interval=3
                If ACControles.ACDialogos.ACMostrarMensajeSatisfactorio(String.Format("Información:"), String.Format("Verificacion Correcta" ))
                    acTool_ACBtnVolver_Click(Nothing,Nothing)
                    'btnProcesar_Click(Nothing,Nothing)
                    actualizar()
                    if(Columna =c1grdReporte.Rows.Count)
                         c1grdReporte.TopRow=columna-10
                        c1grdReporte.Select(columna-1,0)
                    Else If (columna-10 <=0)Then
                        c1grdReporte.TopRow=1
                        c1grdReporte.Select(columna,0)
                    Else 
                        c1grdReporte.TopRow=columna-10
                        c1grdReporte.Select(columna,0)
                    End If
                    columna=0
                End If
                'c1grdReporte.RowSel
            End If
            LiberarMemoria()
        Catch ex As Exception
            ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), Colecciones.getError("00000"), ex)
        End Try

End Sub

private sub actualizar()
        
                Dim consult =(From p In  m_reporte.ListDIST_Ordenes
                                              Where p.ORDEN_Codigo =x_codigo).Single()           
                                consult.ORDEN_RevisadoControl=True
                                consult.ORDEN_RevisadoUsr=GApp.EUsuario.USER_CodUsr
                                Dim cm as CurrencyManager
                                cm=Me.BindingContext(m_reporte.ListDIST_Ordenes)
                                cm.Refresh()
   
End Sub
    private sub actualizar2()
        
                Dim consult =(From p In  m_reporte.ListDIST_Ordenes
                                              Where p.ORDEN_Codigo =x_codigo).Single()           
                                consult.ORDEN_RevisadoControl2=True
                                consult.ORDEN_RevisadoUsr2=GApp.EUsuario.USER_CodUsr
                                Dim cm as CurrencyManager
                                cm=Me.BindingContext(m_reporte.ListDIST_Ordenes)
                                cm.Refresh()
   
End Sub


     Private Declare Auto Function SetProcessWorkingSetSize Lib "kernel32.dll" (ByVal procHandle As IntPtr, ByVal min As Int32, ByVal max As Int32) As Boolean
 
    Public Sub LiberarMemoria()
        Try
        Dim memoria As Process
      memoria = Process.GetCurrentProcess()
      SetProcessWorkingSetSize(memoria.Handle, -1, -1)
 
     Catch ex As Exception
 
     End Try
 
    End Sub

'Private Sub Timer1_Tick( sender As Object,  e As EventArgs) Handles Timer1.Tick
          
'             Timer1.Stop()
'          dim ti as IntPtr=FindWindow(Nothing,"Información:")
'            If ti <>IntPtr.Zero then
'                SendMessageA(ti,WM_CLOSE,Nothing,Nothing)
'                acTool_ACBtnVolver_Click(Nothing,Nothing)
'                btnProcesar_Click(Nothing,Nothing)
'            End If

'    End Sub

Private Sub RGuias_Load( sender As Object,  e As EventArgs) Handles MyBase.Load 
        'm_timer = New System.Windows.Forms.Timer()

        '' Instalamos el controlador para el evento Timer
        ''
        'AddHandler m_timer.Tick, AddressOf Timer1_Tick

        '' Configuramos el intervalo de tiempo del temporizador
        ''
        'm_timer.Interval = 3000   ' 3 segundos
End Sub



Private Sub c1grdDetalle_OwnerDrawCell_1( sender As Object,  e As OwnerDrawCellEventArgs) Handles c1grdDetalle.OwnerDrawCell 
          Try

            If e.Row < c1grdDetalle.Rows.Fixed OrElse e.Col < c1grdDetalle.Cols.Fixed Then Return

                If c1grdDetalle.Cols(e.Col).Name = "ORDET_Cantidad" Then
              
                    If c1grdDetalle.Rows(e.Row)("ORDET_Cantidad") > 0 Then
                    
                         If estado="X" Then
                        e.Style = c1grdDetalle.Styles("Anulado")
                        Else 
                        e.Style = c1grdDetalle.Styles("ORDET_Cantidad")
                    End If

                    End If
                
             End If
            

        Catch ex As Exception
            ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso cambia de color", ex)
        End Try
End Sub

Private Sub c1grdReporte_Click( sender As Object,  e As EventArgs) Handles c1grdReporte.Click 
    
Columna= c1grdReporte.RowSel+1
End Sub

Private Sub btnExcel_Click( sender As Object,  e As EventArgs) Handles btnExcel.Click 
          Try
            Utilitarios.ExportarXLS(c1grdReporte, "Ordenes de Ingreso")
        Catch ex As Exception
            ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso Exportar a Excel", ex)
        End Try
End Sub

 Private sub caragarsoloDetalle(x_codigoorden)
         Try
            dim x_confir=False
            
                    If x_confir = False Then
                        btnRevision.Visible=False
                        Else 
                        btnRevision.Visible=True
                    End If
                    cargarGuia(x_codigoorden)
                    acTool.ACBtnVolverVisible = True
                    acTool.ACBtnBuscarVisible = False
                    acTool.ACBtnCancelarVisible = False
                    acTool.ACBtnImprimirVisible = False
                    actsbtnPrevisualizar.Visible = False
                    acTool.ACBtnAnularVisible = False
                    Dim _validate As ACValidarUsuario
                    _validate = New ACValidarUsuario(GApp.DataConexion, GApp.DataUsuario, ACValidarUsuario.Operacion.ValidarVariosProcesos)
                    For Each item As ACSeguridad.EProcesos In _validate.ListProcesos
                        Select Case item.PROC_Codigo
                            Case Procesos.getProceso(Procesos.TipoProcesos.Desp_AnularGuiasTrasSalMismoDia)
                                If Not acpnlTitulo.Active Then
                                    acTool.ACBtnAnularVisible = True
                                End If
                            Case Procesos.getProceso(Procesos.TipoProcesos.Desp_AnularGuiasTrasSalPosteriores)
                                If Not acpnlTitulo.Active Then
                                    acTool.ACBtnAnularVisible = True
                                    ' m_pgremisionp = True
                                End If
                        End Select
                    Next
                
          
        Catch ex As Exception
            ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso Visualizar Documento", ex)
        End Try
    End Sub

Private Sub acTool_ACBtnSalir_Click( sender As Object,  e As EventArgs) Handles acTool.ACBtnSalir_Click
         Me.Close()
End Sub

Private Sub btnRevision2_Click( sender As Object,  e As EventArgs) Handles btnRevision2.Click
          Try

            if m_reporte.Guias_VerificacionControlOrdenes(GApp.Almacen,m_reporte.DIST_Ordenes.ORDEN_Codigo,GApp.EUsuario.USER_CodUsr,m_reporte.DIST_Ordenes.TIPOS_CodTipoOrden,"2") Then
                'Timer1.Start()
                'Timer1.Interval=3
                If ACControles.ACDialogos.ACMostrarMensajeSatisfactorio(String.Format("Información:"), String.Format("Verificacion Correcta" ))
                    acTool_ACBtnVolver_Click(Nothing,Nothing)
                    'btnProcesar_Click(Nothing,Nothing)
                    actualizar2()
                    if(Columna =c1grdReporte.Rows.Count)
                         c1grdReporte.TopRow=columna-10
                        c1grdReporte.Select(columna-1,0)
                    Else If (columna-10 <=0)Then
                        c1grdReporte.TopRow=1
                        c1grdReporte.Select(columna,0)
                    Else 
                        c1grdReporte.TopRow=columna-10
                        c1grdReporte.Select(columna,0)
                    End If
                    columna=0
                End If
                'c1grdReporte.RowSel
            End If
            LiberarMemoria()
        Catch ex As Exception
            ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), Colecciones.getError("00000"), ex)
        End Try
End Sub
End Class

