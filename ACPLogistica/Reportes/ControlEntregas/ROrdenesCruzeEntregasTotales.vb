Imports System.Globalization
Imports System.Threading.Tasks
Imports ACBLogistica
 Imports ACELogistica
'Imports ACEVentas
Imports ACFramework
Imports C1.Win.C1FlexGrid
Imports CrystalDecisions.Shared.Json
Imports DAConexion


Public Class ROrdenesCruzeEntregasTotales


#Region "Inicializacion de Variables"

    Private managerBReporte As ACBLogistica.BReporte

    'Private bs_almacenes As BindingSource

    Private x_dtdata As DataSet

    Private bs_reporte As BindingSource
    Private bs_ReporteNoCoinciden As BindingSource

    Private bs_series As BindingSource
    Private bs_detdocumentos As BindingSource
    Private bs_tipodocumento As BindingSource
    Private bs_tipodocfacturacion As BindingSource
    'Private managerGenerarDocsVenta As BGenerarDocsVenta

    Dim bs_almacenesOrigen As BindingSource
    Dim bs_almacenesDestino As BindingSource

    Dim ListaGuiasVentasOrdenesOrigen As New List(Of DataSet)
    Dim ListaGuiasVentasOrdenesDestino As New List(Of DataSet)
    Dim listaTemporalOrigen As DataSet
    Dim listaTemporalDestino As DataSet
    Dim x_SucursalesOrdenes As New BDIST_Ordenes()

    Dim listaOrdenesDetalleLocal As New List(Of EDIST_OrdenesDetalle)
    Dim listaOrdenesDetalleExterno As New List(Of EDIST_OrdenesDetalle)

    Dim resultadosUnido As New List(Of EDIST_OrdenesDetalle)

    Dim x_sucursalesPventa As New List(Of ACEVentas.EPuntoVenta)
    Dim x_Sucursales As BPuntoVentaSucursales
    Dim listaUnidad As New List(Of EDIST_OrdenesDetalle)
    Dim x_coleccionas As Colecciones()


    Private m_order As Integer = 1


#End Region

    Public Sub New()



        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()


        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Try
            'formatearGrillaOrigen()
            FormatearGRilla()
            formatearGrillaAlmacenesOrigen()
            formatearGrillaAlmacenesDestino()
            InicializarNotify()
            'grpAlmacenes.Visible = True
            'CargarCombos()
            CargarAlmacenesOrigen() ' Atento este es para ver las ordenes que van de las tiendas externas a la actual 
            CargarAlmacenesDestino() 'Atengo este es para ver las ordenes de las Sucursal actual (Local) a las demas 
            CargarTodoAlmacen()
            formateoGrillaDestino()
            managerBReporte = New ACBLogistica.BReporte
            'managerGenerarDocsVenta = New BGenerarDocsVenta(GApp.Periodo, GApp.Zona, GApp.Sucursal)
            pgBar.Minimum = 0
            AcFecha.ACDtpFecha_De.Value = New DateTime(DateTime.Now.Year, 1, 1)
            AcFecha.ACDtpFecha_A.Value = DateTime.Now

            'CargA Sucursal seleccionado 

            CheckActivarOrigen.Checked = True
            CheckActivarOrigen_Click(Nothing, Nothing)

            'validacion de Sucursales 


        Catch ex As Exception
            ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), Colecciones.getError("00000"), ex)
        End Try
    End Sub

    Private Sub FormatearGRilla()
        'c1grdReporte
        Dim _index As Integer = 1
        Try

            ACFrameworkC1.ACUtilitarios.ACFormatearGrilla(c1grdReporte, 1, 1, 11, 1)
               ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdReporte, _index, "Fecha.Doc", "ORDET_FecCrea", "ORDET_FecCrea", 150, True, False,"System.DateTime", Parametros.GetParametro(ACEVentas.EParametros.TipoParametros.pg_FormatoFecha)) : _index += 1
        
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdReporte, _index, "Nº Orden LLegada", "ORDEN_Codorigen", "ORDEN_Codorigen", 150, True, False, "System.String") : _index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdReporte, _index, "Nº Orden Origen", "ORDEN_Codigo", "ORDEN_Codigo", 150, True, False, "System.String") : _index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdReporte, _index, "N° Factura", "DOCVE_Codigo", "DOCVE_Codigo", 150, True, False, "System.String") : _index += 1
            'item ORDET_Item
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdReporte, _index, "NºItem ", "ORDET_Item", "ORDET_Item", 150, True, False, "System.String")
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdReporte, _index, "Cod.Articulo", "ARTIC_Codigo", "ARTIC_Codigo", 150, True, False, "System.String") : _index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdReporte, _index, "Descripcion Articulo", "ARTIC_Descripcion", "ARTIC_Descripcion", 150, True, False, "System.String") : _index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdReporte, _index, "Cantidad Ingreso", "ORDET_Cantidad", "ORDET_Cantidad", 150, True, False, "System.Decimal", Parametros.GetParametro(ACEVentas.EParametros.TipoParametros.pg_FMondo2d)) : _index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdReporte, _index, "Cantidad Salida", "ORDET_CantidadEntregada", "ORDET_CantidadEntregada", 150, True, False, "System.Decimal", Parametros.GetParametro(ACEVentas.EParametros.TipoParametros.pg_FMondo2d)) : _index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdReporte, _index, "Diferencia", "DIferencia", "DIferencia", 150, True, False, "System.Decimal", Parametros.GetParametro(ACEVentas.EParametros.TipoParametros.pg_FMondo2d)) : _index += 1
            'ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdReporte, _index, "Estado", "PVENT_Activo", "PVENT_Descripcion", 150, True, False, "System.Boolean") : _index += 1
            c1grdReporte.AllowSorting = True
            c1grdReporte.AllowEditing = True
            c1grdReporte.Styles.Alternate.BackColor = Color.LightGray
            c1grdReporte.Styles.Fixed.TextAlign = TextAlignEnum.CenterCenter
            c1grdReporte.Styles.Highlight.BackColor = Color.Gray
            c1grdReporte.SelectionMode = SelectionModeEnum.Row


            'Aplicando estilos a grilla 

            'c1grdReporte.Cols(3).Caption = "Texto de Pruebas"

            ''Set row height
            'c1grdReporte.Rows(0).Height = 50

            ''Set word wrapping for fixed rows and columns
            'c1grdReporte.Styles("Fixed").WordWrap = True

        Catch ex As Exception
            ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Text), "No se puede dar formato a la grilla", ex)
        End Try

    End Sub


    Private Function formateoGrillaDestino()
        Dim _index = 1
        _index = 1
        ACFrameworkC1.ACUtilitarios.ACFormatearGrilla(C1FlexGridNoEncontrados, 1, 1, 11, 1)

          ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdReporte, _index, "Fecha.Doc", "ORDET_FecCrea", "ORDET_FecCrea", 150, True, False,"System.DateTime", Parametros.GetParametro(ACEVentas.EParametros.TipoParametros.pg_FormatoFecha)) : _index += 1      
        ACFrameworkC1.ACUtilitarios.ACAgregarColumna(C1FlexGridNoEncontrados, _index, "Nº Orden LLegada", "ORDEN_Codorigen", "ORDEN_Codorigen", 150, True, False, "System.String") : _index += 1
        ACFrameworkC1.ACUtilitarios.ACAgregarColumna(C1FlexGridNoEncontrados, _index, "Nº Orden Origen", "ORDEN_Codigo", "ORDEN_Codigo", 150, True, False, "System.String") : _index += 1
        ACFrameworkC1.ACUtilitarios.ACAgregarColumna(C1FlexGridNoEncontrados, _index, "N° Factura", "DOCVE_Codigo", "DOCVE_Codigo", 150, True, False, "System.String") : _index += 1
        'item ORDET_Item
        ACFrameworkC1.ACUtilitarios.ACAgregarColumna(C1FlexGridNoEncontrados, _index, "NºItem ", "ORDET_Item", "ORDET_Item", 150, True, False, "System.String")
        ACFrameworkC1.ACUtilitarios.ACAgregarColumna(C1FlexGridNoEncontrados, _index, "Cod.Articulo", "ARTIC_Codigo", "ARTIC_Codigo", 150, True, False, "System.String") : _index += 1
        ACFrameworkC1.ACUtilitarios.ACAgregarColumna(C1FlexGridNoEncontrados, _index, "Descripcion Articulo", "ARTIC_Descripcion", "ARTIC_Descripcion", 150, True, False, "System.String") : _index += 1
        ACFrameworkC1.ACUtilitarios.ACAgregarColumna(C1FlexGridNoEncontrados, _index, "Cantidad Ingreso", "ORDET_Cantidad", "ORDET_Cantidad", 150, True, False, "System.Decimal", Parametros.GetParametro(ACEVentas.EParametros.TipoParametros.pg_FMondo2d)) : _index += 1
        ACFrameworkC1.ACUtilitarios.ACAgregarColumna(C1FlexGridNoEncontrados, _index, "Cantidad Salida", "ORDET_CantidadEntregada", "ORDET_CantidadEntregada", 150, True, False, "System.Decimal", Parametros.GetParametro(ACEVentas.EParametros.TipoParametros.pg_FMondo2d)) : _index += 1
        ACFrameworkC1.ACUtilitarios.ACAgregarColumna(C1FlexGridNoEncontrados, _index, "Diferencia", "DIferencia", "DIferencia", 150, True, False, "System.Decimal", Parametros.GetParametro(ACEVentas.EParametros.TipoParametros.pg_FMondo2d)) : _index += 1
        'ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdReporte, _index, "Estado", "PVENT_Activo", "PVENT_Descripcion", 150, True, False, "System.Boolean") : _index += 1

        C1FlexGridNoEncontrados.AllowEditing = True
        C1FlexGridNoEncontrados.Styles.Alternate.BackColor = Color.LightGray
        C1FlexGridNoEncontrados.Styles.Fixed.TextAlign = TextAlignEnum.CenterCenter
        C1FlexGridNoEncontrados.Styles.Highlight.BackColor = Color.Gray
        C1FlexGridNoEncontrados.SelectionMode = SelectionModeEnum.Row


    End Function

    'Formateo de Grillas no encontrados 



    'Formateo de Grillas 

    Private Sub formatearGrillaAlmacenesOrigen()
        Dim _index As Integer = 1
        Try

            ACFrameworkC1.ACUtilitarios.ACFormatearGrilla(c1grdAlmacenesOrigen, 1, 1, 4, 1)
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdAlmacenesOrigen, _index, "Marcar", "Seleccionar", "Seleccionar", 80, True, True, "System.Boolean") : _index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdAlmacenesOrigen, _index, "Almacen", "PVENT_Descripcion", "PVENT_Descripcion", 150, True, False, "System.Decimal", Parametros.GetParametro(ACEVentas.EParametros.TipoParametros.pg_FMondo2d)) : _index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdAlmacenesOrigen, _index, "Estado", "PVENT_Activo", "PVENT_Descripcion", 150, True, False, "System.Boolean") : _index += 1

            c1grdAlmacenesOrigen.AllowEditing = True
            c1grdAlmacenesOrigen.Styles.Alternate.BackColor = Color.LightGray
            c1grdAlmacenesOrigen.Styles.Fixed.TextAlign = TextAlignEnum.CenterCenter
            c1grdAlmacenesOrigen.Styles.Highlight.BackColor = Color.Gray
            c1grdAlmacenesOrigen.SelectionMode = SelectionModeEnum.Row


        Catch ex As Exception
            ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Text), "No se puede dar formato a la grilla", ex)
        End Try
    End Sub


    Private Sub formatearGrillaAlmacenesDestino()


        'APLICAMOS 
        Dim _index = 1

        _index = 1
        ACFrameworkC1.ACUtilitarios.ACFormatearGrilla(c1grdAlmacenesDestino, 1, 1, 4, 1)
        ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdAlmacenesDestino, _index, "Marcar", "Seleccionar", "Seleccionar", 80, True, True, "System.Boolean") : _index += 1
        ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdAlmacenesDestino, _index, "Almacen", "PVENT_Descripcion", "PVENT_Descripcion", 150, True, False, "System.Decimal", Parametros.GetParametro(ACEVentas.EParametros.TipoParametros.pg_FMondo2d)) : _index += 1
        ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdAlmacenesDestino, _index, "Estado", "PVENT_Activo", "PVENT_Descripcion", 150, True, False, "System.Boolean") : _index += 1

        c1grdAlmacenesDestino.AllowEditing = True
        c1grdAlmacenesDestino.Styles.Alternate.BackColor = Color.LightGray
        c1grdAlmacenesDestino.Styles.Fixed.TextAlign = TextAlignEnum.CenterCenter
        c1grdAlmacenesDestino.Styles.Highlight.BackColor = Color.Gray
        c1grdAlmacenesDestino.SelectionMode = SelectionModeEnum.Row


    End Sub

    Private Function CargarAlmacenesDestino()

        Try
            Dim bs_almacenesDestino = New BindingSource
            Colecciones.GetPuntosVentaExceptuandoPuntoLocal()


            If (GApp.EmpresaRUC = "20100241022" Or GApp.EmpresaRUC = "20100241022 ") Then
                Dim listaFinal = Colecciones.PuntosVenta.
        Where(Function(p) p.PVENT_Activo = True AndAlso p.SUCUR_Id <> 3 AndAlso p.PVENT_Id <> 9 AndAlso p.PVENT_Id <> 1 AndAlso p.PVENT_Id <> 7 AndAlso p.PVENT_Id <> 13 ).
        ToList()

                  '     Dim listaFinal = Colecciones.PuntosVenta.
        'Where(Function(p) p.PVENT_Activo = True AndAlso p.SUCUR_Id <> 3 AndAlso GApp.ESucursal.SUCUR_Id AndAlso p.PVENT_Id <> 9 AndAlso p.PVENT_Id <> 1 AndAlso p.PVENT_Id <> 7 AndAlso p.PVENT_Id <> 13 And p.PVENT_Id <> GApp.ESucursal.SUCUR_Id <> p.SUCUR_Id).
        'ToList()

                bs_almacenesDestino.DataSource = listaFinal
            Else
                Dim listaFinal = Colecciones.PuntosVenta.Where(Function(p) p.PVENT_Activo = True AndAlso p.SUCUR_Id <> GApp.ESucursal.SUCUR_Id AndAlso p.PVENT_Id <> 9 AndAlso p.PVENT_Id <> 6).ToList()

                bs_almacenesDestino.DataSource = listaFinal
            End If

            c1grdAlmacenesDestino.DataSource = bs_almacenesDestino
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function CargarAlmacenesOrigen()

        Try
            Dim bs_almacenesOrigen = New BindingSource
            'Colecciones.GetAlmacenesAcceso()
            Colecciones.GetPuntosVenta()
            'Dim _filter As New ACFramework.ACFiltrador(Of ACEVentas.EPuntoVenta)(String.Format("PVENT_Activo=True OR PVENT_ID <> 3")) 'PVENT_ActivoAlmacen
            If (GApp.EmpresaRUC = "20100241022" Or GApp.EmpresaRUC = "20100241022 ") Then


                Dim listaFinal = Colecciones.PuntosVenta.
                 Where(Function(p) p.PVENT_Activo = True AndAlso p.PVENT_Id <> 3 AndAlso p.SUCUR_Id <> GApp.ESucursal.SUCUR_Id AndAlso p.PVENT_Id <> 1 AndAlso p.PVENT_Id <> 9 AndAlso p.PVENT_Id <> 7 AndAlso p.PVENT_Id <> 13).
                 ToList()

                bs_almacenesOrigen.DataSource = listaFinal


            Else
                Dim listaFinal = Colecciones.PuntosVenta.
              Where(Function(p) p.PVENT_Activo = True AndAlso p.SUCUR_Id <> GApp.ESucursal.SUCUR_Id AndAlso p.PVENT_Id <> 6 AndAlso p.PVENT_Id <> 9).
              ToList()

                bs_almacenesOrigen.DataSource = listaFinal

            End If


            '  bs_almacenesOrigen.DataSource = bs_almacenesOrigen '_filter.ACFiltrar(Colecciones.PuntosVenta)
            c1grdAlmacenesOrigen.DataSource = bs_almacenesOrigen
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function CargarTodoAlmacen()

        Try
            Dim bs_almacenesTodo = New BindingSource
            Colecciones.GetPuntosVenta()
            Dim listaFinal = Colecciones.PuntosVenta.
                 Where(Function(p) p.PVENT_Activo = True AndAlso p.PVENT_Id <> 3).
                 ToList()

            bs_almacenesTodo.DataSource = listaFinal
            GridOrigenMuestraTodo.DataSource = bs_almacenesTodo
        Catch ex As Exception
            Throw ex
        End Try
    End Function



    Private Sub btnExcel_Click(sender As Object, e As EventArgs) Handles btnExcel.Click
        'Boton exportacion excel 

        'Asignar Tabla excel Para generar Reporte
        Try
            Utilitarios.ExportarXLS(c1grdReporte, "Reporte Entregas")
        Catch ex As Exception
            ACControles.ACDialogos.ACMostrarMensajeInformacion(String.Format("Información: {0}", Me.Text), "No se puede Exportar a Excel")
        End Try

    End Sub

    Private Sub btnProcesar_Click(sender As Object, e As EventArgs) Handles btnProcesar.Click
        'Inicio de Proceso para aplicar las listas 
        '   BusquedaOrdenesOrigen()

        'Condicionales para busquedas 
        'SI Origen esta seleccionado va a buscar eDel local en donde este ====> hacia las tiendas externas hacia donde van 

        If (CheckActivarOrigen.Checked) Then
            BusquedaOrdenesOrigen()

        ElseIf (CheckActivarDestino.Checked) Then
            BusquedaOrdenesDestino()
        End If

        'SI destino esta seleccionado va a  buscar del Exterior las tiendas externas que nos ayan enviado material 



    End Sub

#Region "notifiy"

    'iNICIALIZAD EL MOENSAJE 
    Private Function InicializarNotify()
        NotifyOrdenes = New NotifyIcon()
        NotifyOrdenes.Icon = SystemIcons.Information ' Puedes cambiarlo
        NotifyOrdenes.Visible = True
        Return True
    End Function
    'Mensaje de Confirmacino Para usuarios 

    'Aqui hago una funcion 

    Private Sub MostrarNotificacionConfirmacion()
        Try
            NotifyOrdenes.Icon = SystemIcons.Information ' O tu propio icono
            NotifyOrdenes.Visible = True
            NotifyOrdenes.Text = "Informacion"
            NotifyOrdenes.BalloonTipText = "El Usuario se Grabo Correctamente"
            NotifyOrdenes.BalloonTipIcon = ToolTipIcon.Info
            NotifyOrdenes.ShowBalloonTip(5000)
        Catch ex As NullReferenceException
            Debug.WriteLine("SE CERROE STO PONGO ESTO PARA QUE NO ME SLAE ")
        End Try
    End Sub
    Private Sub MostrarNotificacionErrorRepetidos()
        Try
            NotifyOrdenes.Icon = SystemIcons.Error ' O tu propio icono
            NotifyOrdenes.Visible = True
            NotifyOrdenes.Text = "Alert"
            NotifyOrdenes.BalloonTipText = "El Usuario ya esta Registrado"
            NotifyOrdenes.BalloonTipIcon = ToolTipIcon.Info
            NotifyOrdenes.ShowBalloonTip(5000)
        Catch ex As NullReferenceException
            Debug.WriteLine("SE CERROE STO PONGO ESTO PARA QUE NO ME SLAE ")
        End Try

        ' Duración en milisegundos'System.NullReferenceException: 'Referencia a objeto no establecida como instancia de un objeto.'

    End Sub


    Private Sub MostrarMensajePersonalizado(ByVal Mensaje As String)
        Try
            NotifyOrdenes.Icon = SystemIcons.Information ' O tu propio icono
            NotifyOrdenes.Visible = True
            NotifyOrdenes.Text = "Alert"
            NotifyOrdenes.BalloonTipText = Mensaje
            NotifyOrdenes.BalloonTipIcon = ToolTipIcon.Info
            NotifyOrdenes.ShowBalloonTip(5000)
        Catch ex As NullReferenceException
            Debug.WriteLine("SE CERROE STO PONGO ESTO PARA QUE NO ME SLAE ")
        End Try

        ' Duración en milisegundos'System.NullReferenceException: 'Referencia a objeto no establecida como instancia de un objeto.'

    End Sub

    Private Sub MostrarNotificacionEliminado()
        Try
            NotifyOrdenes.Icon = SystemIcons.Exclamation ' O tu propio icono
            NotifyOrdenes.Visible = True
            NotifyOrdenes.Text = "Alerta"
            NotifyOrdenes.BalloonTipText = "Se Elimino el Usuario "
            NotifyOrdenes.BalloonTipIcon = ToolTipIcon.Info
            NotifyOrdenes.ShowBalloonTip(5000)
        Catch ex As NullReferenceException
            Debug.WriteLine("SE CERROE STO PONGO ESTO PARA QUE NO ME SLAE ")
        End Try


        ' Duración en milisegundos'System.NullReferenceException: 'Referencia a objeto no establecida como instancia de un objeto.'

    End Sub
    Private Sub MostrarNotificacionUpdate()
        Try
            NotifyOrdenes.Icon = SystemIcons.Information ' O tu propio icono
            NotifyOrdenes.Visible = True
            NotifyOrdenes.Text = "Alerta"
            NotifyOrdenes.BalloonTipText = "Se Actualizo El Usuario "
            NotifyOrdenes.BalloonTipIcon = ToolTipIcon.Info
            NotifyOrdenes.ShowBalloonTip(5000)
        Catch ex As NullReferenceException
            Debug.WriteLine("SE CERROE STO PONGO ESTO PARA QUE NO ME SLAE ")
        End Try


        ' Duración en milisegundos'System.NullReferenceException: 'Referencia a objeto no establecida como instancia de un objeto.'

    End Sub

#End Region

    Private Async Sub BusquedaOrdenesOrigen() 'Funcion creado para el check Origen 
        Try
            x_dtdata = New DataSet
            bs_reporte = New BindingSource
            pgBar.Minimum = 0
            pgBar.Value = 0
            pgBar.Step = 1
            ' Puedes declararlas como constantes o variables
            listaOrdenesDetalleLocal = New List(Of EDIST_OrdenesDetalle)
            listaOrdenesDetalleExterno = New List(Of EDIST_OrdenesDetalle)
            Dim _fecini As DateTime = New DateTime(AcFecha.ACFecha_De.Value.Year, AcFecha.ACFecha_De.Value.Month, 1)
            Dim _fecfin As DateTime = DateSerial(Year(AcFecha.ACFecha_A.Value), Month(AcFecha.ACFecha_A.Value) + 1, 0)
            Dim PutoOrigen As Long = 0
            Dim Almac_id As Long = 0

            Dim cts As New Threading.CancellationTokenSource()

            'Dim _nroalmacenes As Short = 0
            'Creamos nuestra Lista de Tareas 
            Dim Tareas As New List(Of Task(Of List(Of EDIST_OrdenesDetalle))) 'Lista de Ordeens por comcerasare
            Dim TareasExternas As New List(Of Task(Of List(Of EDIST_OrdenesDetalle))) 'Lista de Ordeens por comcerasare
            If TypeOf GridOrigenMuestraTodo.DataSource Is BindingSource Then
                Dim bs_almacenes As BindingSource = DirectCast(GridOrigenMuestraTodo.DataSource, BindingSource)
                If bs_almacenes.List IsNot Nothing Then

                    'UN PEQUEÑO FOR PARA EXTRAER LAS SUCURSALES EXTRAIDAS 

                    For Each itemAlmacen As ACEVentas.EPuntoVenta In bs_almacenes.List.OfType(Of ACEVentas.EPuntoVenta)()
                        If (itemAlmacen.PVENT_DireccionIP = GApp.DataConexion.Servidor And itemAlmacen.PVENT_BaseDatos = GApp.EAlmacen.PVENT_BaseDatos) Then 'Hgo la conexion local primero                       
                            'Conexion Local Primero 
                            Dim connStr As String = String.Format("Data Source={0};Initial Catalog={1};User Id={2};Password={3};", GApp.DataConexion.Servidor, itemAlmacen.PVENT_BaseDatos, GApp.Usuario_DB, GApp.Password_DB)

                            Dim business = New BDIST_Ordenes(connStr)


                            'Tareas.Add(Task.Run(Function()
                            '                        Return business.ObtenerClientesDeTodasLocalAsync(cts.Token, _fecini, _fecfin)
                            '                    End Function))
                            Tareas.Add(business.ObtenerClientesDeTodasLocalAsync(cts.Token, _fecini, _fecfin, Nothing, itemAlmacen.ALMAC_Id, itemAlmacen.PVENT_DireccionIP, itemAlmacen.PVENT_BaseDatos))
                            'ACA LE PONGO NOTHING PORQUE EL ORIGEN EL ALAMCEN LOCAL NO TIENE PUNTO DE ORIGEN EN LOS EXTERIORES SI POR EN DE ESTO NO VA BY FRANK
                            PutoOrigen = itemAlmacen.PVENT_Id
                            Almac_id = itemAlmacen.ALMAC_Id
                        Else
                        End If
                    Next
                Else
                End If
            End If
            Dim bs_almacenesExternos As BindingSource = DirectCast(c1grdAlmacenesOrigen.DataSource, BindingSource)
            If bs_almacenesExternos.List IsNot Nothing Then
                For Each itemAlmacenExterno As ACEVentas.EPuntoVenta In bs_almacenesExternos.List.OfType(Of ACEVentas.EPuntoVenta)()
                    If itemAlmacenExterno.Seleccionar Then
                        Dim ConnStrExterno As String = String.Format("Data Source={0};Initial Catalog={1};User Id={2};Password={3};", itemAlmacenExterno.PVENT_DireccionIP, itemAlmacenExterno.PVENT_BaseDatos, GApp.Usuario_DB, GApp.Password_DB)
                        Dim bussinessExteron = New BDIST_Ordenes(ConnStrExterno)
                        Dim ctsExterno As New Threading.CancellationTokenSource()
                        TareasExternas.Add(bussinessExteron.ObtenerOrdenesExternaAsync(ctsExterno.Token, _fecini, _fecfin, PutoOrigen, Almac_id, Nothing, Nothing)) 'JAJJAJA
                        'Tareas.Add(Task.Run(Function()
                        '                        Return bussinessExteron.ObtenerClientesDeTodasAsync(cts.Token, _fecini, _fecfin)
                        '                    End Function))
                    End If
                Next
            End If



            Dim ObjetoresultadosLocal = Await Task.WhenAll(Tareas)
            Dim ObjetosResultadoExternas = Await Task.WhenAll(TareasExternas)

            MostrarMensajePersonalizado("Se Extrajo la Informacion de las Sucursales")

            'Esperams a que mis  listas y consultas termines todas juntas 
            Dim resultadoLocal As List(Of EDIST_OrdenesDetalle) = ObjetoresultadosLocal.Where(Function(r) r IsNot Nothing).SelectMany(Function(r) r).ToList()
            Dim resultadoExternos As List(Of EDIST_OrdenesDetalle) = ObjetosResultadoExternas.Where(Function(r) r IsNot Nothing).SelectMany(Function(r) r).ToList()
            bs_ReporteNoCoinciden = New BindingSource
            Dim noCoinciden As List(Of EDIST_OrdenesDetalle)

            'Ejecutamos el proceso en 2 plano 


            bs_reporte.DataSource = ComparationForList(resultadoLocal, resultadoExternos, noCoinciden)

            'Hacemos la Compracion de ambas listas 
            c1grdReporte.DataSource = bs_reporte
            bs_ReporteNoCoinciden.DataSource = GetNoCoinciden(resultadoLocal, resultadoExternos)
            'C1 = bs_ReporteNoCoinciden
            C1FlexGridNoEncontrados.DataSource = bs_ReporteNoCoinciden

            For index As Integer = 1 To 99
                If bs_reporte.Count = 0 Then
                    pgBar.Value = index + 1

                Else
                    pgBar.Value = index + 1

                End If
            Next


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Async Sub BusquedaOrdenesDestino() 'Funcion creado para las sucursales ==> destino osea todas las Ordenes nos envian al local 
        Try
            x_dtdata = New DataSet
            bs_reporte = New BindingSource
            pgBar.Minimum = 0
            pgBar.Value = 0
            pgBar.Step = 1
            ' Puedes declararlas como constantes o variables
            listaOrdenesDetalleLocal = New List(Of EDIST_OrdenesDetalle)
            listaOrdenesDetalleExterno = New List(Of EDIST_OrdenesDetalle)
            Dim _fecini As DateTime = New DateTime(AcFecha.ACFecha_De.Value.Year, AcFecha.ACFecha_De.Value.Month, 1)
            Dim _fecfin As DateTime = DateSerial(Year(AcFecha.ACFecha_A.Value), Month(AcFecha.ACFecha_A.Value) + 1, 0)
            Dim PutoDestino As Long = 0
            Dim Almac_id As Long = 0


            Dim cts As New Threading.CancellationTokenSource()

            'Dim _nroalmacenes As Short = 0
            'Creamos nuestra Lista de Tareas 
            Dim Tareas As New List(Of Task(Of List(Of EDIST_OrdenesDetalle))) 'Lista de Ordeens por comcerasare
            Dim TareasExternas As New List(Of Task(Of List(Of EDIST_OrdenesDetalle))) 'Lista de Ordeens por comcerasare
            If TypeOf GridOrigenMuestraTodo.DataSource Is BindingSource Then
                Dim bs_almacenes As BindingSource = DirectCast(GridOrigenMuestraTodo.DataSource, BindingSource)
                If bs_almacenes.List IsNot Nothing Then

                    'UN PEQUEÑO FOR PARA EXTRAER LAS SUCURSALES EXTRAIDAS 

                    For Each itemAlmacen As ACEVentas.EPuntoVenta In bs_almacenes.List.OfType(Of ACEVentas.EPuntoVenta)()
                        If (itemAlmacen.PVENT_DireccionIP = GApp.DataConexion.Servidor And itemAlmacen.PVENT_BaseDatos = GApp.EAlmacen.PVENT_BaseDatos) Then 'Hgo la conexion local primero                       
                            'Conexion Local Primero 
                            Dim connStr As String = String.Format("Data Source={0};Initial Catalog={1};User Id={2};Password={3};", GApp.DataConexion.Servidor, itemAlmacen.PVENT_BaseDatos, GApp.Usuario_DB, GApp.Password_DB)

                            Dim business = New BDIST_Ordenes(connStr)


                            'Tareas.Add(Task.Run(Function()
                            '                        Return business.ObtenerClientesDeTodasLocalAsync(cts.Token, _fecini, _fecfin)
                            '                    End Function))
                            Tareas.Add(business.ObtenerClientesDeTodasLocalDestinoAsync(cts.Token, _fecini, _fecfin, Nothing, itemAlmacen.ALMAC_Id, itemAlmacen.PVENT_DireccionIP, itemAlmacen.PVENT_BaseDatos))
                            'ACA LE PONGO NOTHING PORQUE EL ORIGEN EL ALAMCEN LOCAL NO TIENE PUNTO DE ORIGEN EN LOS EXTERIORES SI POR EN DE ESTO NO VA BY FRANK
                            PutoDestino = itemAlmacen.PVENT_Id
                            Almac_id = itemAlmacen.ALMAC_Id
                        Else
                        End If
                    Next
                Else
                End If
            End If
            Dim bs_almacenesExternos As BindingSource = DirectCast(c1grdAlmacenesDestino.DataSource, BindingSource)
            If bs_almacenesExternos.List IsNot Nothing Then
                For Each itemAlmacenExterno As ACEVentas.EPuntoVenta In bs_almacenesExternos.List.OfType(Of ACEVentas.EPuntoVenta)()
                    If itemAlmacenExterno.Seleccionar Then
                        Dim ConnStrExterno As String = String.Format("Data Source={0};Initial Catalog={1};User Id={2};Password={3};", itemAlmacenExterno.PVENT_DireccionIP, itemAlmacenExterno.PVENT_BaseDatos, GApp.Usuario_DB, GApp.Password_DB)
                        Dim bussinessExteron = New BDIST_Ordenes(ConnStrExterno)
                        Dim ctsExterno As New Threading.CancellationTokenSource()
                        TareasExternas.Add(bussinessExteron.ObtenerOrdenesExternaDestinoAsync(ctsExterno.Token, _fecini, _fecfin, PutoDestino, Almac_id, Nothing, Nothing)) 'JAJJAJA
                        'Tareas.Add(Task.Run(Function()
                        '                        Return bussinessExteron.ObtenerClientesDeTodasAsync(cts.Token, _fecini, _fecfin)
                        '                    End Function))
                    End If
                Next
            End If



            Dim ObjetoresultadosLocal = Await Task.WhenAll(Tareas)
            Dim ObjetosResultadoExternas = Await Task.WhenAll(TareasExternas)

            MostrarMensajePersonalizado("Se Extrajo la Informacion de las Sucursales")

            'Esperams a que mis  listas y consultas termines todas juntas 
            Dim resultadoLocal As List(Of EDIST_OrdenesDetalle) = ObjetoresultadosLocal.Where(Function(r) r IsNot Nothing).SelectMany(Function(r) r).ToList()
            Dim resultadoExternos As List(Of EDIST_OrdenesDetalle) = ObjetosResultadoExternas.Where(Function(r) r IsNot Nothing).SelectMany(Function(r) r).ToList()
            bs_ReporteNoCoinciden = New BindingSource
            Dim noCoinciden As List(Of EDIST_OrdenesDetalle)

            'Ejecutamos el proceso en 2 plano 


            bs_reporte.DataSource = ComparationDestinoForList(resultadoLocal, resultadoExternos, noCoinciden)

            'Hacemos la Compracion de ambas listas 
            c1grdReporte.DataSource = bs_reporte
            BindingNavigatorMatch.BindingSource = bs_reporte
            bs_ReporteNoCoinciden.DataSource = GetNoCoinciden(resultadoLocal, resultadoExternos)
            BindingNavigatorNoEncontrados.BindingSource = bs_ReporteNoCoinciden
            'Visualmente solo para el contador de los bindingi 







            'C1 = bs_ReporteNoCoinciden
            C1FlexGridNoEncontrados.DataSource = bs_ReporteNoCoinciden

            For index As Integer = 1 To 99
                If bs_reporte.Count = 0 Then
                    pgBar.Value = index + 1

                Else
                    pgBar.Value = index + 1

                End If
            Next


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Function ComparationForList(
    ByVal listaLocal As List(Of EDIST_OrdenesDetalle),
    ByVal listaExterna As List(Of EDIST_OrdenesDetalle),
    ByRef noCoinciden As List(Of EDIST_OrdenesDetalle)
) As List(Of EDIST_OrdenesDetalle)

        Dim resultado As New List(Of EDIST_OrdenesDetalle)
        noCoinciden = New List(Of EDIST_OrdenesDetalle)

        ' Agrupar externos por DOCVE_Codigo + Item
        Dim dictExternos = listaExterna.ToDictionary(
    Function(e) e.DOCVE_Codigo & "-" & e.ORDET_Item & "-" & e.ORDEN_Codorigen,
    Function(e) e
)

        ' Recorremos la lista local
        For Each local In listaLocal
            Dim clave = local.DOCVE_Codigo & "-" & local.ORDET_Item & "-" & local.ORDEN_Codigo

            If dictExternos.ContainsKey(clave) Then
                Dim externo = dictExternos(clave)
                resultado.Add(New EDIST_OrdenesDetalle With {
                    .ORDET_FecCrea  = local.ORDET_FecCrea,
            .DOCVE_Codigo = local.DOCVE_Codigo,
            .ORDEN_Codigo = local.ORDEN_Codigo,
            .ORDET_Item = local.ORDET_Item,
            .ORDET_Cantidad = local.ORDET_Cantidad,
            .ORDET_CantidadEntregada = externo.ORDET_CantidadEntregada,
            .DIferencia = local.ORDET_Cantidad - externo.ORDET_CantidadEntregada,
            .ARTIC_Codigo = local.ARTIC_Codigo,
            .ARTIC_Descripcion = local.ARTIC_Descripcion,
            .ORDEN_Codorigen = local.ORDEN_Codorigen
        })

                ' Lo eliminamos para no contarlo luego en noCoinciden
                dictExternos.Remove(clave)
            Else
                '  No hay match  va a noCoinciden
                noCoinciden.Add(local)
            End If
        Next

        ' (existen afuera pero no en local)
        'For Each kvp In dictExternos
        '    Dim externo = kvp.Value.Ejemplo
        '    noCoinciden.Add(New EDIST_OrdenesDetalle With {
        '    .DOCVE_Codigo = externo.DOCVE_Codigo,
        '    .ORDEN_Codigo = externo.ORDEN_Codigo,
        '    .ORDET_Item = externo.ORDET_Item,
        '    .ORDET_Cantidad = 0, ' no existe en local
        '    .ORDET_CantidadEntregada = kvp.Value.CantidadEntregada,
        '    .DIferencia = 0 - kvp.Value.CantidadEntregada,
        '    .ARTIC_Codigo = externo.ARTIC_Codigo,
        '    .ARTIC_Descripcion = externo.ARTIC_Descripcion,
        '    .ORDEN_Codorigen = externo.ORDEN_Codorigen
        '})
        'Next

        Return resultado
    End Function


    '#REGION COMPARATIVOS DESTINO LOCAL 

    Private Function ComparationDestinoForList(ByVal listaLocal As List(Of EDIST_OrdenesDetalle), ByVal listaExterna As List(Of EDIST_OrdenesDetalle), ByRef noCoinciden As List(Of EDIST_OrdenesDetalle)) As List(Of EDIST_OrdenesDetalle)

        Dim resultado As New List(Of EDIST_OrdenesDetalle)
        noCoinciden = New List(Of EDIST_OrdenesDetalle)

        ' Agrupar externos por DOCVE_Codigo + Item
        Dim dictLocal = listaLocal.ToDictionary( 'listaExterna
            Function(e) e.DOCVE_Codigo & "-" & e.ORDET_Item & "-" & e.ORDEN_Codorigen, Function(e) e)

        ' Recorremos la lista externa 
        For Each Externa In listaExterna
            Dim clave = Externa.DOCVE_Codigo & "-" & Externa.ORDET_Item & "-" & Externa.ORDEN_Codigo

            If dictLocal.ContainsKey(clave) Then
                Dim interno = dictLocal(clave)
                resultado.Add(New EDIST_OrdenesDetalle With {
                    .ORDET_FecCrea = Externa.ORDET_FecCrea,
            .DOCVE_Codigo = Externa.DOCVE_Codigo,
            .ORDEN_Codigo = Externa.ORDEN_Codigo,
            .ORDET_Item = Externa.ORDET_Item,
            .ORDET_Cantidad = Externa.ORDET_Cantidad,
            .ORDET_CantidadEntregada = interno.ORDET_CantidadEntregada,
            .DIferencia = Externa.ORDET_Cantidad - interno.ORDET_CantidadEntregada,
            .ARTIC_Codigo = Externa.ARTIC_Codigo,
            .ARTIC_Descripcion = Externa.ARTIC_Descripcion,
            .ORDEN_Codorigen = Externa.ORDEN_Codorigen
        })

                ' Lo eliminamos para no contarlo luego en noCoinciden
                dictLocal.Remove(clave)
            Else
                '  No hay match  va a noCoinciden
                noCoinciden.Add(Externa)
            End If
        Next

        ' (existen afuera pero no en local)
        'For Each kvp In dictExternos
        '    Dim externo = kvp.Value.Ejemplo
        '    noCoinciden.Add(New EDIST_OrdenesDetalle With {
        '    .DOCVE_Codigo = externo.DOCVE_Codigo,
        '    .ORDEN_Codigo = externo.ORDEN_Codigo,
        '    .ORDET_Item = externo.ORDET_Item,
        '    .ORDET_Cantidad = 0, ' no existe en local
        '    .ORDET_CantidadEntregada = kvp.Value.CantidadEntregada,
        '    .DIferencia = 0 - kvp.Value.CantidadEntregada,
        '    .ARTIC_Codigo = externo.ARTIC_Codigo,
        '    .ARTIC_Descripcion = externo.ARTIC_Descripcion,
        '    .ORDEN_Codorigen = externo.ORDEN_Codorigen
        '})
        'Next

        Return resultado
    End Function

    '#FIN COMPARATIVO DESTINO

    'Private Function ComparationForList(ByVal listaLocal As List(Of EDIST_OrdenesDetalle), 'AQUELLOS QUE SI CUADRAN CON EL ITEM Y EL Nº DE DOCUENTOS 
    '                                ByVal listaExterna As List(Of EDIST_OrdenesDetalle),
    '                                ByRef noCoinciden As List(Of EDIST_OrdenesDetalle)) As List(Of EDIST_OrdenesDetalle)

    '    Dim resultado As New List(Of EDIST_OrdenesDetalle)
    '    noCoinciden = New List(Of EDIST_OrdenesDetalle)
    '    Dim Contador As Integer = 0

    '    ' 🔹 Agrupar externos por DOCVE_Codigo + Item, acumulando cantidades entregadas
    '    Dim dictExternos = listaExterna.
    '    GroupBy(Function(e) e.DOCVE_Codigo & "-" & e.ORDET_Item).
    '    ToDictionary(
    '        Function(g) g.Key,
    '        Function(g) New With {
    '            .CantidadEntregada = g.Sum(Function(x) x.ORDET_CantidadEntregada),
    '            .ejemplo = g.First() ' para conservar datos extra como descripción
    '        }
    '    )

    '    '  Recorremos la lista local y papu le agregamos un codigo poniendo como clave la concatenacion par que no se repita 
    '    For Each local In listaLocal
    '        Dim clave = local.DOCVE_Codigo & "-" & local.ORDET_Item
    '        Dim cantidadEntregada As Decimal = 0
    '        Dim ORDEN_EXTERNO As String = ""

    '        If dictExternos.ContainsKey(clave) Then
    '            cantidadEntregada = dictExternos(clave).CantidadEntregada
    '            'ORDEN_EXTERNO = dictExternos(clave).ORDEN_Codigo
    '            ' ya lo usamos lo removemos para saber que ya no hay coincidencia s 
    '            dictExternos.Remove(clave)
    '        End If

    '        resultado.Add(New EDIST_OrdenesDetalle With {
    '        .DOCVE_Codigo = local.DOCVE_Codigo,
    '        .ORDEN_Codigo = local.ORDEN_Codigo,
    '        .ORDET_Item = local.ORDET_Item,
    '        .ORDET_Cantidad = local.ORDET_Cantidad,
    '        .ORDET_CantidadEntregada = cantidadEntregada,
    '        .DIferencia = local.ORDET_Cantidad - cantidadEntregada,
    '        .ARTIC_Codigo = local.ARTIC_Codigo,
    '        .ARTIC_Descripcion = local.ARTIC_Descripcion,
    '        .ORDEN_Codorigen = local.ORDEN_Codorigen
    '    })
    '        Contador += +1
    '    Next

    '    '  Lo que quedó en dictExternos 
    '    'For Each kvp In dictExternos
    '    '    Dim externo = kvp.Value.Ejemplo
    '    '    noCoinciden.Add(New EDIST_OrdenesDetalle With {
    '    '    .DOCVE_Codigo = externo.DOCVE_Codigo,
    '    '    .ORDEN_Codigo = externo.ORDEN_Codigo,
    '    '    .ORDET_Item = externo.ORDET_Item,
    '    '    .ORDET_Cantidad = 0, ' no existe en local
    '    '    .ORDET_CantidadEntregada = kvp.Value.CantidadEntregada,
    '    '    .DIferencia = 0 - kvp.Value.CantidadEntregada
    '    '})
    '    'Next
    '    MostrarMensajePersonalizado("SE Termino de Hacer la Comparacion de " & Contador & " Registros ")
    '    Return resultado
    'End Function

    ' 
    Private Function GetNoCoinciden(ByVal listaLocal As List(Of EDIST_OrdenesDetalle),
                                ByVal listaExterna As List(Of EDIST_OrdenesDetalle)) As List(Of EDIST_OrdenesDetalle)
        Dim contadorNada As Integer = 0

        Dim noCoinciden As New List(Of EDIST_OrdenesDetalle)

        ' Crear conjunto de claves de la local
        Dim clavesLocal = listaLocal.Select(Function(X) X.DOCVE_Codigo & "-" & X.ORDET_Item) '.ToDictionary()
        ' listaLocal.Select(Function(l) l.DOCVE_Codigo & "-" & l.ORDET_Item).ToHashSet()

        ' Agrupamos la externa por DOCVE + Item
        Dim dictExternos = listaExterna.
        GroupBy(Function(e) e.DOCVE_Codigo & "-" & e.ORDET_Item).
        ToDictionary(Function(g) g.Key, Function(g) New With {
            .CantidadEntregada = g.Sum(Function(x) x.ORDET_CantidadEntregada),
            .Ejemplo = g.First()
        })

        ' Tomar solo las claves que no están en local
        For Each kvp In dictExternos
            If Not clavesLocal.Contains(kvp.Key) Then
                Dim externo = kvp.Value.Ejemplo
                noCoinciden.Add(New EDIST_OrdenesDetalle With {
                .DOCVE_Codigo = externo.DOCVE_Codigo,
                .ORDEN_Codigo = externo.ORDEN_Codigo,
                .ORDET_Item = externo.ORDET_Item,
                .ORDET_Cantidad = 0D,
                .ORDET_CantidadEntregada = kvp.Value.CantidadEntregada,
                .DIferencia = -kvp.Value.CantidadEntregada
            })
            End If
            contadorNada += +1
        Next
        MostrarMensajePersonalizado("SE Termino de Hacer la Comparacion de   " & contadorNada & "Registros ")
        Return noCoinciden



    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'Asignar Tabla excel Para generar Reporte
        Try
            Utilitarios.ExportarXLS(C1FlexGridNoEncontrados, "Reporte Entregas No Encontrados ")
        Catch ex As Exception
            ACControles.ACDialogos.ACMostrarMensajeInformacion(String.Format("Información: {0}", Me.Text), "No se puede Exportar a Excel")
        End Try

    End Sub

#Region "CheckBox_PuntoAlmacen"
    Private Sub CheckActivarOrigen_Click(sender As Object, e As EventArgs) Handles CheckActivarOrigen.Click
        If CheckActivarOrigen.Checked Then
            'CheckActivarDestino.Enabled = False
            CheckActivarDestino.Checked = False
            c1grdAlmacenesDestino.Enabled = False
            c1grdAlmacenesOrigen.Enabled = True

        Else

        End If
    End Sub

    Private Sub CheckActivarDestino_Click(sender As Object, e As EventArgs) Handles CheckActivarDestino.Click
        If CheckActivarDestino.Checked Then
            CheckActivarOrigen.Checked = False
            c1grdAlmacenesOrigen.Enabled = False
            c1grdAlmacenesDestino.Enabled = True
        Else

        End If

    End Sub

    Private Sub c1grdReporte_BeforeSort(sender As Object, e As SortColEventArgs) Handles c1grdReporte.BeforeSort
        '     Private Sub c1grdBusqueda_BeforeSort(ByVal sender As System.Object, ByVal e As C1.Win.C1FlexGrid.SortColEventArgs) Handles c1grdBusqueda.BeforeSort
        Try
            Ordenar(c1grdReporte.Cols(e.Col).UserData)
            c1grdReporte.Subtotal(AggregateEnum.Clear)
        Catch ex As Exception
            ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso ordenar", ex)
        End Try
        'End Sub
    End Sub
    Private Sub Ordenar(ByVal x_columna As String)
        Dim _ordenador As New ACOrdenador(Of EDIST_OrdenesDetalle)
        Try
            If m_order = 2 Then x_columna += " DESC"
            _ordenador.ACOrdenamiento = x_columna

            CType(bs_reporte.DataSource, List(Of EDIST_OrdenesDetalle)).Sort(_ordenador)
            c1grdReporte.Refresh()
            m_order = IIf(m_order = 1, 2, 1)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub C1FlexGridNoEncontrados_BeforeSort(sender As Object, e As SortColEventArgs) Handles C1FlexGridNoEncontrados.BeforeSort
        Try
            OrdenarNoEncontrados(C1FlexGridNoEncontrados.Cols(e.Col).UserData)
            c1grdReporte.Subtotal(AggregateEnum.Clear)
        Catch ex As Exception
            ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso ordenar", ex)
        End Try
    End Sub

    Private Sub OrdenarNoEncontrados(ByVal x_columna As String)
        Dim _ordenador As New ACOrdenador(Of EDIST_OrdenesDetalle)
        Try
            If m_order = 2 Then x_columna += " DESC"
            _ordenador.ACOrdenamiento = x_columna

            CType(bs_ReporteNoCoinciden.DataSource, List(Of EDIST_OrdenesDetalle)).Sort(_ordenador)
            C1FlexGridNoEncontrados.Refresh()
            m_order = IIf(m_order = 1, 2, 1)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub


#End Region



    'Private Function ComparationForList(ByVal listaLocal As List(Of EDIST_OrdenesDetalle),
    '                                    ByVal listaExterna As List(Of EDIST_OrdenesDetalle)) As List(Of EDIST_OrdenesDetalle)

    '    Dim resultado As New List(Of EDIST_OrdenesDetalle)

    '    ' 🔹 Agrupar externos por DOCVE_Codigo + Item, acumulando cantidades entregadas
    '    Dim dictExternos = listaExterna.
    '        GroupBy(Function(e) e.DOCVE_Codigo & "-" & e.ORDET_Item).
    '        ToDictionary(
    '            Function(g) g.Key,
    '            Function(g) g.Sum(Function(x) x.ORDET_CantidadEntregada)
    '        )

    '    For Each local In listaLocal
    '        Dim clave = local.DOCVE_Codigo & "-" & local.ORDET_Item
    '        Dim cantidadEntregada As Decimal = 0

    '        If dictExternos.ContainsKey(clave) Then
    '            cantidadEntregada = dictExternos(clave)
    '        End If

    '        ' 🔹 Nuevo objeto con diferencia
    '        resultado.Add(New EDIST_OrdenesDetalle With {
    '            .DOCVE_Codigo = local.DOCVE_Codigo,
    '            .ORDEN_Codigo = local.ORDEN_Codigo,
    '            .ORDET_Item = local.ORDET_Item,
    '            .ORDET_Cantidad = local.ORDET_Cantidad,
    '            .ORDET_CantidadEntregada = cantidadEntregada,
    '            .DIferencia = local.ORDET_Cantidad - cantidadEntregada
    '        })
    '    Next

    '    Return resultado
    'End Function

End Class