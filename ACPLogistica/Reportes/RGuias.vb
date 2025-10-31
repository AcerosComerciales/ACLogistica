Imports ACBLogistica
Imports DAConexion
Imports ACEVentas
Imports ACBVentas
Imports ACELogistica
Imports ACFramework
Imports ACSeguridad
Imports C1.Win.C1FlexGrid

Public Class RGuias
#Region " Variables "
    'Declare Auto Function FindWindow Lib "USER32.DLL" (ByVal LpClassName As String,ByVal LpWindowName As String)as IntPtr
    'Declare Auto Function SendMessageA Lib "user32.DLL" (ByVal hWnd As IntPtr,ByVal wMsg As Int32, ByVal wParam As Int32,
    '                                                     ByVal lParam As String)as Int32
    Private Const WM_CLOSE = &H10
    Dim estado as String
     Dim list As  ArrayList
    Private bs_pv As BindingSource
    Dim x_codigo As String
    Private m_timer As System.Windows.Forms.Timer
    Private bs_guias As BindingSource
    Private m_order As Integer = 1
    Private managerEntidades As BEntidades
    Private bs_reporte As BindingSource
    Private gt As EDIST_GuiasTodas
    Public columna as Integer    

    Private m_listBindHelper As List(Of ACBindHelper)
    Private frmCons As CProductos
    Private m_earticulos As EArticulos
    Private m_reporte As ACBLogistica.BReporte
    Private m_motivoguia As ETipos.MotivoTraslado
    Private managerConsultaArticulos As BConsultaArticulos

    Private m_entid_codigo As String
    Private m_artic_descripion As String
    Private m_cargado As Boolean = False
#End Region
#Region " Constructores "
    Public Sub New(ByVal x_icono As System.Drawing.Bitmap)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Try

            managerConsultaArticulos = New BConsultaArticulos(GApp.Periodo)
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
                GroupBox4.Visible=True
                GroupBox1.Size()= New Size(670,48)
                Else 
                GroupBox4.Visible=False
                GroupBox1.Size()= New Size(897,48)
                For items = 1 To c1grdPuntosVentas.Rows.Count - 1
                    c1grdPuntosVentas.Rows(1)("Seleccionar") = true'item_tabla("CANT_ItemPendiente")
                Next
            End If
            

            If Not IsNothing(x_icono) Then Me.Icon = Icon.FromHandle(x_icono.GetHicon)

        Catch ex As Exception
            ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), Colecciones.getError("00000"), ex)
        End Try
    End Sub

      Public Sub New( ByVal OPCION As Boolean, ByVal x_codigo As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Try

            managerConsultaArticulos = New BConsultaArticulos(GApp.Periodo)
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
                GroupBox4.Visible=True
                GroupBox1.Size()= New Size(490,48)
                Else 
                GroupBox4.Visible=False
                GroupBox1.Size()= New Size(734,48)
                For items = 1 To c1grdPuntosVentas.Rows.Count - 1
                    c1grdPuntosVentas.Rows(1)("Seleccionar") = true'item_tabla("CANT_ItemPendiente")
                Next
            End If


            'If Not IsNothing(x_icono) Then Me.Icon = Icon.FromHandle(x_icono.GetHicon)

            IF OPCION Then
               tabMantenimiento.SelectedTab = tabDatos
                caragarsoloDetalle(x_codigo)
            End If
            setInstancia(ACUtilitarios.ACSetInstancia.Deshacer)



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
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdDetalle, index, "Item", "GUIRD_ItemDocumento", "GUIRD_ItemDocumento", 80, True, False, "System.Integer", "#0") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdDetalle, index, "Codigo", "ARTIC_Codigo", "ARTIC_Codigo", 80, True, False, "System.String") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdDetalle, index, "Cantidad", "GUIRD_Cantidad", "GUIRD_Cantidad", 75, True, False, "System.Decimal", Parametros.GetParametro(EParametros.TipoParametros.pg_FMondo2d)) : index += 1            
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdDetalle, index, "Unidad", "TIPOS_UnidadMedida", "TIPOS_UnidadMedida", 69, True, False, "System.String") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdDetalle, index, "Descripción", "ARTIC_Descripcion", "ARTIC_Descripcion", 191, True, False, "System.String") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdDetalle, index, "Peso Unitario", "GUIRD_PesoUnitario", "GUIRD_PesoUnitario", 75, True, False, "System.Decimal", Parametros.GetParametro(EParametros.TipoParametros.pg_FMondo4d)) : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdDetalle, index, "Peso Total", "SubPeso", "SubPeso", 75, True, False, "System.Decimal", Parametros.GetParametro(EParametros.TipoParametros.pg_FMondo4d)) : index += 1
            
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

            Dim dd As C1.Win.C1FlexGrid.CellStyle = c1grdDetalle.Styles.Add("GUIRD_Cantidad")
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
            ACFrameworkC1.ACUtilitarios.ACFormatearGrilla(c1grdReporte, 1, 1, 11, 1, 0)
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdReporte, index, "Fec. Doc", "GUIAR_FechaEmision", "GUIAR_FechaEmision", 90, True, False, "System.DateTime", Parametros.GetParametro(EParametros.TipoParametros.pg_FormatoFecha)) : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdReporte, index, "Documento", "Documento", "Documento", 90, True, False, "System.String") : index += 1            
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdReporte, index, "Tipo Doc.", "Tipo_doc", "Tipo_doc", 100, True, False, "System.String") : index += 1            
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdReporte, index, "Doc. Relacion", "doc_relacion", "doc_relacion", 90, True, False, "System.String") : index += 1            
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdReporte, index, "Raz. Social", "GUIAR_Descripcioncliente", "GUIAR_Descripcioncliente", 150, True, False, "System.String") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdReporte, index, "R.U.C. / D.N.I.", "ENTID_CodigoCliente", "ENTID_CodigoCliente", 90, True, False, "System.String") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdReporte, index, "Total Peso", "GUIAR_TotalPeso", "GUIAR_TotalPeso", 70, True, False, "System.Decimal", Parametros.GetParametro(ACEVentas.EParametros.TipoParametros.pg_FMondo2d)) : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdReporte, index, "Estado", "DOTRA_Estado_Text", "DOTRA_Estado_Text", 90, True, False, "System.String") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdReporte, index, "Revisión Control", "GUIAR_RevisadoControl", "GUIAR_RevisadoControl", 150, True, False, "System.Boolean") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdReporte, index, "Revisión Usuario", "GUIAR_RevisadoUsr", "GUIAR_RevisadoUsr", 150, True, False, "System.String") : index += 1
            c1grdReporte.AllowEditing = False
            c1grdReporte.Styles.Alternate.BackColor = Color.LightGray
            c1grdReporte.Styles.Fixed.TextAlign = TextAlignEnum.CenterCenter
            c1grdReporte.Styles.Highlight.BackColor = Color.Gray
            c1grdReporte.SelectionMode = SelectionModeEnum.Row
            c1grdReporte.AllowSorting = AllowSortingEnum.SingleColumn
            'c1grdReporte.AllowEditing = False
            'c1grdReporte.Styles.Alternate.BackColor = Color.LightGray
            'c1grdReporte.Styles.Fixed.TextAlign = TextAlignEnum.CenterCenter
            'c1grdReporte.Styles.Highlight.BackColor = Color.Gray
            'c1grdReporte.SelectionMode = SelectionModeEnum.Row
            'c1grdReporte.AllowResizing = AllowResizingEnum.None
            'c1grdReporte.DrawMode = C1.Win.C1FlexGrid.DrawModeEnum.OwnerDraw
            'c1grdReporte.Tree.Column = 1

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

           
            'Dim rg As CellRange = c1grdReporte.GetCellRange(0, c1grdReporte.Cols("ALMAC_Origen").Index, 0, c1grdReporte.Cols("GUIAR_DireccOrigen").Index)
            'rg.Data = "Origen"
            'c1grdReporte.MergedRanges.Add(rg)
            'rg = c1grdReporte.GetCellRange(0, c1grdReporte.Cols("ENTID_CodigoCliente").Index, 0, c1grdReporte.Cols("PVENT_Destino").Index)
            'rg.Data = "Destino"
            'c1grdReporte.MergedRanges.Add(rg)

            'For i As Integer = 0 To c1grdReporte.Cols("ALMAC_Origen").Index - 1
            '    rg = c1grdReporte.GetCellRange(0, i, 1, i)
            '    c1grdReporte.MergedRanges.Add(rg)
            'Next
            'For i As Integer = c1grdReporte.Cols("GUIAR_DescripcionTransportista").Index To c1grdReporte.Cols.Count - 1
            '    rg = c1grdReporte.GetCellRange(0, i, 1, i)
            '    c1grdReporte.MergedRanges.Add(rg)
            'Next
            'c1grdReporte.AutoSizeCols()


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
                           If m_reporte.Repor_Guias_Todo(GApp.Periodo, GApp.Almacen, actxaCliRuc.Text, rbtncliente.Checked, AcFecha.ACDtpFecha_De.Value.Date, AcFecha.ACDtpFecha_A.Value.Date, chkctodos.Checked,itemAlPV.PVENT_Id) Then
                                list.AddRange(m_reporte.ListDIST_GuiasRemision)
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
            bs_guias = New BindingSource()
            'bs_guias.DataSource = m_reporte.ListDIST_GuiasRemision
           
            m_reporte.ListDIST_GuiasRemision= Nothing
            m_reporte.ListDIST_GuiasRemision= list.Cast(Of ACELogistica.EDIST_GuiasRemision).ToList()
            bs_guias.DataSource = m_reporte.ListDIST_GuiasRemision
            
            c1grdReporte.DataSource = bs_guias
            bnavCBusqueda.BindingSource = bs_guias
            AddHandler bs_guias.CurrentChanged, AddressOf bs_guias_CurrentChanged
            bs_guias_CurrentChanged(Nothing, Nothing)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Private Sub bs_guias_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If Not IsNothing(bs_guias) Then
                If Not IsNothing(bs_guias.Current) Then
                    If CType(bs_guias.Current, ACELogistica.EDIST_GuiasRemision).GUIAR_Estado = ACELogistica.EDIST_GuiasRemision.getEstado(ACELogistica.EDIST_GuiasRemision.Estado.Ingresado) Then
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

    Private Sub rbtncliente_CheckedChanged_1(sender As Object, e As EventArgs) Handles rbtncliente.CheckedChanged
        If rbtncliente.Checked Then


            actxaCliRuc.ACAyuda.Enabled = True
            actxaCliRazonSocial.ACActivarAyudaAuto = True
            actxaCliRuc.Enabled = True
            actxaCliRazonSocial.Enabled = True


        End If

    End Sub

    Private Sub c1grdReporte_OwnerDrawCell_1(sender As Object, e As OwnerDrawCellEventArgs) Handles c1grdReporte.OwnerDrawCell
        Try
            If e.Row < c1grdReporte.Rows.Fixed OrElse e.Col < c1grdReporte.Cols.Fixed Then Return
            If c1grdReporte.Rows(e.Row)("DOTRA_Estado_Text") = "Confirmado" Then
                e.Style = c1grdReporte.Styles("Confirmado")
            End If
            If c1grdReporte.Rows(e.Row)("DOTRA_Estado_Text") = "Anulado" Then
                e.Style = c1grdReporte.Styles("Anulado")
            End If

        Catch ex As Exception
            ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso cambia de color", ex)
        End Try
    End Sub

    Private Sub tsbtnExcel_Click(sender As Object, e As EventArgs) Handles tsbtnExcel.Click
        Try
            Utilitarios.ExportarXLS(c1grdReporte, "Guias por Tipo")
        Catch ex As Exception
            ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso Exportar a Excel", ex)
        End Try
    End Sub


    Private Sub actsbtnPrevisualizar_Click(sender As Object, e As EventArgs) Handles actsbtnPrevisualizar.Click
        Try
            If Not IsNothing(bs_guias) Then
                If Not IsNothing(bs_guias.Current) Then
                    x_codigo = CType(bs_guias.Current, ACELogistica.EDIST_GuiasRemision).GUIAR_Codigo
                    Dim x_confir As Boolean = CType(bs_guias.Current, ACELogistica.EDIST_GuiasRemision).GUIAR_RevisadoControl
                    Dim x_tipo as String =CType(bs_guias.Current, ACELogistica.EDIST_GuiasRemision).Tipo_doc
                    ' InitControles(False)
                    If x_confir = True Then
                        btnRevision.Visible=False
                        Else 
                        btnRevision.Visible=True
                    End If
                    cargarGuia(x_codigo,x_tipo)
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

    Private sub caragarsoloDetalle(x_codigoguia)
         Try
            dim x_confir=False
            
                    If x_confir = False Then
                        btnRevision.Visible=False
                        Else 
                        btnRevision.Visible=True
                    End If
                    cargarGuias(x_codigoguia)
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



#Region "Cargar Datos"
    Private Sub AsignarBinding()
        Try
            m_listBindHelper = New List(Of ACBindHelper)()
            If m_reporte.DIST_GuiasRemision.GUIAR_FechaEmision.Year < 1700 Then m_reporte.DIST_GuiasRemision.GUIAR_FechaEmision = DateTime.Now
            m_listBindHelper.Add(ACBindHelper.ACBind(dtpFechaEmision, "Value", m_reporte.DIST_GuiasRemision, "GUIAR_FechaEmision"))
            If m_reporte.DIST_GuiasRemision.GUIAR_FechaTraslado.Year < 1700 Then m_reporte.DIST_GuiasRemision.GUIAR_FechaTraslado = DateTime.Now
            m_listBindHelper.Add(ACBindHelper.ACBind(dtpFechaTraslado, "Value", m_reporte.DIST_GuiasRemision, "GUIAR_FechaTraslado"))

            m_listBindHelper.Add(ACBindHelper.ACBind(actxaCodDirDestino, "Text", m_reporte.DIST_GuiasRemision, "DIREC_IdDestino"))
            m_listBindHelper.Add(ACBindHelper.ACBind(actxaCodCliente, "Text", m_reporte.DIST_GuiasRemision, "ENTID_CodigoCliente"))
            m_listBindHelper.Add(ACBindHelper.ACBind(actxaCodTransportista, "Text", m_reporte.DIST_GuiasRemision, "ENTID_CodigoTransportista"))
            m_listBindHelper.Add(ACBindHelper.ACBind(actxaCodConductor, "Text", m_reporte.DIST_GuiasRemision, "ENTID_CodigoConductor"))
            'm_listBindHelper.Add(ACBindHelper.ACBind(actxaCodVehiculo, "Text", managerGenerarGuias.DIST_GuiasRemision, "VEHIC_Id"))
            m_listBindHelper.Add(ACBindHelper.ACBind(actxnPesoTotal, "Text", m_reporte.DIST_GuiasRemision, "GUIAR_TotalPeso"))
            m_listBindHelper.Add(ACBindHelper.ACBind(cmbGuiaSerie, "Text", m_reporte.DIST_GuiasRemision, "GUIAR_Serie"))
            m_listBindHelper.Add(ACBindHelper.ACBind(cmbGuia, "SelectedValue", m_reporte.DIST_GuiasRemision, "TIPOS_CodTipoDocumento"))
            m_listBindHelper.Add(ACBindHelper.ACBind(actxnNumero, "Text", m_reporte.DIST_GuiasRemision, "GUIAR_Numero"))
            'm_listBindHelper.Add(ACBindHelper.ACBind(cmbDirOrigen, "Text", m_reporte.DIST_GuiasRemision, "GUIAR_DireccOrigen"))
            'If m_motivoguia = 6 Then
            'm_listBindHelper.Add(ACBindHelper.ACBind(cmbDirOrigen, "Text", m_reporte.DIST_GuiasRemision, "GUIAR_DireccOrigen"))
            'm_listBindHelper.Add(ACBindHelper.ACBind(cmbotro, "Text", m_reporte.DIST_GuiasRemision, "GUIAR_DireccOrigen"))
            'ElseIf m_motivoguia = 7 Then
            '  m_listBindHelper.Add(ACBindHelper.ACBind(cmbDirOrigen, "Text", managerGenerarGuias.DIST_GuiasRemision, "GUIAR_DireccOrigen"))
            'End If
            ' m_listBindHelper.Add(ACBindHelper.ACBind(cmbDirOrigenSalTrans, "Text", managerGenerarGuias.DIST_GuiasRemision, "GUIAR_DireccOrigen"))
            'm_listBindHelper.Add(ACBindHelper.ACBind(cmbDirDestino, "Text", managerGenerarGuias.DIST_GuiasRemision, "GUIAR_"))
            'm_listBindHelper.Add(ACBindHelper.ACBind(cmbDirOrigen, "Text", managerGenerarGuias.DIST_GuiasRemision, "GUIAR_DireccOrigen"))

            m_listBindHelper.Add(ACBindHelper.ACBind(cmbDirOrigenSalTrans, "Text", m_reporte.DIST_GuiasRemision, "GUIAR_DireccDestino"))

            m_listBindHelper.Add(ACBindHelper.ACBind(actxaDescCliente, "Text", m_reporte.DIST_GuiasRemision, "GUIAR_Descripcioncliente"))
            m_listBindHelper.Add(ACBindHelper.ACBind(actxaDescTransportista, "Text", m_reporte.DIST_GuiasRemision, "GUIAR_DescripcionTransportista"))
            m_listBindHelper.Add(ACBindHelper.ACBind(actxaDescConductor, "Text", m_reporte.DIST_GuiasRemision, "GUIAR_DescripcionConductor"))
            m_listBindHelper.Add(ACBindHelper.ACBind(actxaDescVehiculo, "Text", m_reporte.DIST_GuiasRemision, "GUIAR_DescripcionVehiculo"))
            m_listBindHelper.Add(ACBindHelper.ACBind(txtCertificado, "Text", m_reporte.DIST_GuiasRemision, "GUIAR_CertificadoVehiculo"))
            m_listBindHelper.Add(ACBindHelper.ACBind(txtLicenciaConducir, "Text", m_reporte.DIST_GuiasRemision, "GUIAR_LicenciaConductor"))
            m_listBindHelper.Add(ACBindHelper.ACBind(cmbMotTraslado, "SelectedValue", m_reporte.DIST_GuiasRemision, "TIPOS_CodMotivoTraslado"))
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
            bs_guias = New BindingSource
            bs_guias.DataSource = listBusGuia


            ''para cargar datos en combo en la misma empresa "direcciones"

            ACFramework.ACUtilitarios.ACCargaCombo(cmbMotTraslado, Colecciones.Tipos(ETipos.MyTipos.MotivoTraslado), "TIPOS_Descripcion", "TIPOS_Codigo", ETipos.getMotivoTraslado(ETipos.MotivoTraslado.Venta))

            bs_guias = New BindingSource
            bs_guias.DataSource = Colecciones.TiposDocsTraslado
            ACFramework.ACUtilitarios.ACCargaCombo(cmbGuia, bs_guias, "TIPOS_Descripcion", "TIPOS_Codigo")
            ' AddHandler bs_guias.CurrentChanged, AddressOf bs_guias_CurrentChanged
            ' bs_guias_CurrentChanged(Nothing, Nothing)


        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub cargarGuias(ByVal x_codigo As String)
        Try
            If m_reporte.CargarGuia(x_codigo) Then
                estado=""
                txtAlmDestino.Text = ""
                txtAlmOrigen.Text = ""
                cargarCliente(m_reporte.DIST_GuiasRemision.ENTID_CodigoCliente)
                actxaCodDirDestino.Text = m_reporte.DIST_GuiasRemision.GUIAR_DireccDestino
                cmbDirOrigen.Text = m_reporte.DIST_GuiasRemision.GUIAR_DireccOrigen
                'txtAlmOrigen.Text = PuntoVentaXdireccion(cmbDirOrigen.Text)
                'txtAlmDestino.Text = PuntoVentaXdireccion(cmbDirOrigenSalTrans.Text.ToString())
                setInstancia(ACUtilitarios.ACSetInstancia.Previsualizar)

               
                         If  m_reporte.DIST_GuiasRemision.DOCVE_Codigo Isnot Nothing AND Len(m_reporte.DIST_GuiasRemision.DOCVE_Codigo)<=12 then
                            If  m_reporte.DIST_GuiasRemision.DOCVE_Codigo.Substring(0,2)="01"
                            txtNroDocVenta.Text="Fact-"+m_reporte.DIST_GuiasRemision.DOCVE_Codigo.Substring(2,3)+"-"+m_reporte.DIST_GuiasRemision.DOCVE_Codigo.Substring(5,7)
                            ElseIf m_reporte.DIST_GuiasRemision.DOCVE_Codigo.Substring(0,2)="03"
                            txtNroDocVenta.Text="Bol-"+m_reporte.DIST_GuiasRemision.DOCVE_Codigo.Substring(2,3)+"-"+m_reporte.DIST_GuiasRemision.DOCVE_Codigo.Substring(5,7)
                            End If
                        ELSE
                            If  m_reporte.DIST_GuiasRemision.DOCVE_Codigo.Substring(0,2)="01"
                            txtNroDocVenta.Text="Fact-"+m_reporte.DIST_GuiasRemision.DOCVE_Codigo.Substring(2,4)+"-"+m_reporte.DIST_GuiasRemision.DOCVE_Codigo.Substring(6,7)
                            ElseIf m_reporte.DIST_GuiasRemision.DOCVE_Codigo.Substring(0,2)="03"
                            txtNroDocVenta.Text="Bol-"+m_reporte.DIST_GuiasRemision.DOCVE_Codigo.Substring(2,4)+"-"+m_reporte.DIST_GuiasRemision.DOCVE_Codigo.Substring(6,7)
                            End If
                   End If

                AsignarBinding()
                tabMantenimiento.SelectedTab = tabDatos
                bs_reporte = New BindingSource
                bs_reporte.DataSource = m_reporte.DIST_GuiasRemision.ListDIST_GuiasRemisionDetalle
                bnavProductos.BindingSource = bs_reporte
                c1grdDetalle.DataSource = bs_reporte



                cmbDirOrigenSalTrans.Text = m_reporte.DIST_GuiasRemision.GUIAR_DireccDestino


                ''proceso para agarrar el almacen destino

                Dim _list As New List(Of ACEVentas.EPuntoVenta)
                For Each item As ACEVentas.EPuntoVenta In Colecciones.PuntosVenta
                    'If GApp.Almacen <> item.ALMAC_Id Then
                    _list.Add(item.Clone())
                    ' End If
                Next

                Dim x As Integer = 0
                For Each item In _list

                    If (m_reporte.DIST_GuiasRemision.ALMAC_IdDestino.Equals(_list(x).ALMAC_Id)) Then
                        txtAlmDestino.Text = _list(x).ALMAC_Nombre
                    End If

                    If (m_reporte.DIST_GuiasRemision.ALMAC_IdOrigen.Equals(_list(x).ALMAC_Id)) Then
                        txtAlmOrigen.Text = _list(x).ALMAC_Nombre
                    End If

                    x += 1
                Next

                If m_reporte.DIST_GuiasRemision.GUIAR_Estado.Equals("X") Then
                    estado="X"
                   
                    
                    If m_reporte.DIST_GuiasRemision.GUIAR_MotivoAnulacion is Nothing Then
                    txtMotivoAnulacion.Text = "Fecha: " & m_reporte.DIST_GuiasRemision.GUIAR_FecMod & " Usuario:" & m_reporte.DIST_GuiasRemision.Usuario_Modificador    
                    else
                    txtMotivoAnulacion.Text=m_reporte.DIST_GuiasRemision.GUIAR_MotivoAnulacion
                    End If
                    
                    dtpFechaAnulacion.Value = m_reporte.DIST_GuiasRemision.GUIAR_FecMod
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





    Private Sub cargarGuia(ByVal x_codigo As String, ByVal x_tipo As String)
        Try
            If m_reporte.CargarGuia(x_codigo) Then
                estado=""
                txtAlmDestino.Text = ""
                txtAlmOrigen.Text = ""
                cargarCliente(m_reporte.DIST_GuiasRemision.ENTID_CodigoCliente)
                actxaCodDirDestino.Text = m_reporte.DIST_GuiasRemision.GUIAR_DireccDestino
                cmbDirOrigen.Text = m_reporte.DIST_GuiasRemision.GUIAR_DireccOrigen
                'txtAlmOrigen.Text = PuntoVentaXdireccion(cmbDirOrigen.Text)
                'txtAlmDestino.Text = PuntoVentaXdireccion(cmbDirOrigenSalTrans.Text.ToString())
                setInstancia(ACUtilitarios.ACSetInstancia.Previsualizar)

                Select x_tipo
                    Case "Guia Venta"
                         If  m_reporte.DIST_GuiasRemision.DOCVE_Codigo Isnot Nothing AND Len(m_reporte.DIST_GuiasRemision.DOCVE_Codigo)<=12 then
                            If  m_reporte.DIST_GuiasRemision.DOCVE_Codigo.Substring(0,2)="01"
                            txtNroDocVenta.Text="Fact-"+m_reporte.DIST_GuiasRemision.DOCVE_Codigo.Substring(2,3)+"-"+m_reporte.DIST_GuiasRemision.DOCVE_Codigo.Substring(5,7)
                            ElseIf m_reporte.DIST_GuiasRemision.DOCVE_Codigo.Substring(0,2)="03"
                            txtNroDocVenta.Text="Bol-"+m_reporte.DIST_GuiasRemision.DOCVE_Codigo.Substring(2,3)+"-"+m_reporte.DIST_GuiasRemision.DOCVE_Codigo.Substring(5,7)
                            End If
                        ELSE
                            If  m_reporte.DIST_GuiasRemision.DOCVE_Codigo.Substring(0,2)="01"
                            txtNroDocVenta.Text="Fact-"+m_reporte.DIST_GuiasRemision.DOCVE_Codigo.Substring(2,4)+"-"+m_reporte.DIST_GuiasRemision.DOCVE_Codigo.Substring(6,7)
                            ElseIf m_reporte.DIST_GuiasRemision.DOCVE_Codigo.Substring(0,2)="03"
                            txtNroDocVenta.Text="Bol-"+m_reporte.DIST_GuiasRemision.DOCVE_Codigo.Substring(2,4)+"-"+m_reporte.DIST_GuiasRemision.DOCVE_Codigo.Substring(6,7)
                            End If
                    End If

                    Case "Guia Reposicion"
                         txtNroDocVenta.Text="PR-"+m_reporte.DIST_GuiasRemision.PEDID_Codigo.Substring(2,3)+"-"+m_reporte.DIST_GuiasRemision.PEDID_Codigo.Substring(5,7)
                    Case "Ingreso por Traslado"
                        txtNroDocVenta.Text=x_tipo
                    Case "Salida por Traslado"
                        txtNroDocVenta.Text=x_tipo
                    Case "Devolucion"
                        txtNroDocVenta.Text=x_tipo
                    Case "Transformacion"
                        txtNroDocVenta.Text=x_tipo
                End Select

                AsignarBinding()
                tabMantenimiento.SelectedTab = tabDatos
                bs_reporte = New BindingSource
                bs_reporte.DataSource = m_reporte.DIST_GuiasRemision.ListDIST_GuiasRemisionDetalle
                bnavProductos.BindingSource = bs_reporte
                c1grdDetalle.DataSource = bs_reporte



                cmbDirOrigenSalTrans.Text = m_reporte.DIST_GuiasRemision.GUIAR_DireccDestino


                ''proceso para agarrar el almacen destino

                Dim _list As New List(Of ACEVentas.EPuntoVenta)
                For Each item As ACEVentas.EPuntoVenta In Colecciones.PuntosVenta
                    'If GApp.Almacen <> item.ALMAC_Id Then
                    _list.Add(item.Clone())
                    ' End If
                Next

                Dim x As Integer = 0
                For Each item In _list

                    If (m_reporte.DIST_GuiasRemision.ALMAC_IdDestino.Equals(_list(x).ALMAC_Id)) Then
                        txtAlmDestino.Text = _list(x).ALMAC_Nombre
                    End If

                    If (m_reporte.DIST_GuiasRemision.ALMAC_IdOrigen.Equals(_list(x).ALMAC_Id)) Then
                        txtAlmOrigen.Text = _list(x).ALMAC_Nombre
                    End If

                    x += 1
                Next

                If m_reporte.DIST_GuiasRemision.GUIAR_Estado.Equals("X") Then
                    estado="X"
                   
                    
                    If m_reporte.DIST_GuiasRemision.GUIAR_MotivoAnulacion is Nothing Then
                    txtMotivoAnulacion.Text = "Fecha: " & m_reporte.DIST_GuiasRemision.GUIAR_FecMod & " Usuario:" & m_reporte.DIST_GuiasRemision.Usuario_Modificador    
                    else
                    txtMotivoAnulacion.Text=m_reporte.DIST_GuiasRemision.GUIAR_MotivoAnulacion
                    End If
                    
                    dtpFechaAnulacion.Value = m_reporte.DIST_GuiasRemision.GUIAR_FecMod
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
                    ACUtilitarios.ACLimpiaVar(pnlItem)
                    actxaCodCliente.Focus()
                    actsbtnPrevisualizar.Visible = False

                    ''.00
                Case ACUtilitarios.ACSetInstancia.Modificado
                    ''.0000

                    ''.00000000000000000
                Case ACUtilitarios.ACSetInstancia.Guardar
                    acTool.ACBtnImprimirVisible = False
                    acTool.ACBtnBuscarVisible = True
                    actsbtnPrevisualizar.Visible = True


                    '''''''''''''''''''ESTE SET ES ESPECIAL REVISAR ANTES DE MODIFICAR SOLO SIRVE PARA QUE SE MIREN LAS GUIAS
                Case ACUtilitarios.ACSetInstancia.Deshacer

                    acTool.ACBtnModificarVisible = False
                    acTool.ACBtnBuscarVisible = False
                    acTool.ACBtnImprimirVisible = False
                    actsbtnPrevisualizar.Visible = False
                    acTool.ACBtnSalir.Visible = True
                    acTool.ACBtnSalir.Enabled=True
                    acTool.ACBtnVolverVisible=False
                    Me.KeyPreview = False
               
                Case ACUtilitarios.ACSetInstancia.Previsualizar
                    ACUtilitarios.ACLimpiaVar(pnlCabecera)
                    ACUtilitarios.ACSetControl(pnlCabecera, True, ACUtilitarios.TipoPropiedad.ACReadOnly)
                    cmbDirOrigen.Enabled = True
                    cmbDirOrigenSalTrans.Enabled = True
                    cmbDirDestino.Enabled = True
                    cmbGuia.Enabled = False
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

    

    'Private Sub cmbDirOrigen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDirOrigen.SelectedIndexChanged
    '    Try
    '        txtAlmOrigen.Text = CType(cmbDirOrigen.SelectedItem, EAlmacenes).ALMAC_Descripcion
    '    Catch ex As Exception

    '    End Try
    'End Sub

    'Private Sub cmbDirOrigenSalTrans_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDirOrigenSalTrans.SelectedIndexChanged
    '    Try
    '        txtAlmDestino.Text = CType(cmbDirOrigenSalTrans.SelectedItem, EAlmacenes).ALMAC_Descripcion
    '    Catch ex As Exception

    '    End Try
    'End Sub

    Private Sub acTool_ACBtnVolver_Click(sender As Object, e As EventArgs) Handles acTool.ACBtnVolver_Click
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
        Dim _ordenador As New ACOrdenador(Of ACELogistica.EDIST_GuiasRemision)
        Try
            If Not IsNothing(bs_guias) Then
                If Not IsNothing(bs_guias.Current) Then
                    If m_order = 2 Then x_columna &= " DESC"
                    _ordenador.ACOrdenamiento = x_columna
                    CType(bs_guias.DataSource, List(Of ACELogistica.EDIST_GuiasRemision)).Sort(_ordenador)
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

            if m_reporte.Guias_VerificacionControl(GApp.Almacen,m_reporte.DIST_GuiasRemision.GUIAR_Codigo,GApp.EUsuario.USER_CodUsr,"1") Then
                'Timer1.Start()
                'Timer1.Interval=3

                if ACControles.ACDialogos.ACMostrarMensajeSatisfactorio(String.Format("Información:"), String.Format("Verificacion Correcta" ))
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
                end if
                'c1grdReporte.RowSel
            End If
            
            LiberarMemoria()
        Catch ex As Exception
            ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), Colecciones.getError("00000"), ex)
        End Try

End Sub

private sub actualizar()
        
                Dim consult =(From p In  m_reporte.ListDIST_GuiasRemision
                                              Where p.GUIAR_Codigo =x_codigo).Single()           
                                consult.GUIAR_RevisadoControl=True
                                consult.GUIAR_RevisadoUsr=GApp.EUsuario.USER_CodUsr
                                Dim cm as CurrencyManager
                                cm=Me.BindingContext(m_reporte.ListDIST_GuiasRemision)
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

'          Timer1.Stop()
'          dim ti as IntPtr=FindWindow(Nothing,"Información:")
'            If ti <>IntPtr.Zero then
'                SendMessageA(ti,WM_CLOSE,Nothing,Nothing)
'                acTool_ACBtnVolver_Click(Nothing,Nothing)
'                btnProcesar_Click(Nothing,Nothing)
'            End If
        
'End Sub

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

                If c1grdDetalle.Cols(e.Col).Name = "GUIRD_Cantidad" Then
              
                    If c1grdDetalle.Rows(e.Row)("GUIRD_Cantidad") > 0 Then
                    
                         If estado="X" Then
                        e.Style = c1grdDetalle.Styles("Anulado")
                        Else 
                        e.Style = c1grdDetalle.Styles("GUIRD_Cantidad")
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
            Utilitarios.ExportarXLS(c1grdReporte, "Guias por Tipo")
        Catch ex As Exception
            ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso Exportar a Excel", ex)
        End Try
End Sub

Private Sub acTool_ACBtnSalir_Click( sender As Object,  e As EventArgs) Handles acTool.ACBtnSalir_Click
        Me.Close()
End Sub

Private Sub btnRevision2_Click( sender As Object,  e As EventArgs) Handles btnRevision2.Click
        Try

            if m_reporte.Guias_VerificacionControl(GApp.Almacen,m_reporte.DIST_GuiasRemision.GUIAR_Codigo,GApp.EUsuario.USER_CodUsr,"2") Then
                'Timer1.Start()
                'Timer1.Interval=3

                if ACControles.ACDialogos.ACMostrarMensajeSatisfactorio(String.Format("Información:"), String.Format("Verificacion Correcta" ))
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
                end if
                'c1grdReporte.RowSel
            End If
            
            LiberarMemoria()
        Catch ex As Exception
            ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), Colecciones.getError("00000"), ex)
        End Try

End Sub
End Class
