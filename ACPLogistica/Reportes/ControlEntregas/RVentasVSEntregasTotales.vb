Imports C1.Win.C1FlexGrid
Imports ACFramework
Imports ACEVentas
Imports DAConexion
Imports System.Globalization
Imports CrystalDecisions.Shared.Json
Imports ACBLogistica
Imports ACBVentas

Public Class RVentasVSEntregasTotales

    Private managerBReporte As ACBLogistica.BReporte

    'Private bs_almacenes As BindingSource

    Private x_dtdata As DataSet

    Private bs_reporte As BindingSource

    Private bs_series As BindingSource
    Private bs_detdocumentos As BindingSource
    Private bs_tipodocumento As BindingSource
    Private bs_tipodocfacturacion As BindingSource
    Private managerGenerarDocsVenta As BGenerarDocsVenta

    Dim bs_almacenesOrigen As BindingSource
    Dim bs_almacenesDestino As BindingSource

    Dim ListaGuiasVentasOrdenesOrigen As New List(Of DataSet)
    Dim ListaGuiasVentasOrdenesDestino As New List(Of DataSet)
    Dim listaTemporalOrigen As DataSet
    Dim listaTemporalDestino As DataSet
    Private m_order As Integer = 1




#Region "Constructorsito"

    Public Sub New()



        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()


        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Try
            'formatearGrillaOrigen()
            formatearGrillaDestino()
            'grpAlmacenes.Visible = True
            'CargarAlmacenesOrigen()
            CargarAlmacenesDestino()
            'CargarCombos()
            ' rbtnImporte.Enabled = False
            managerBReporte = New ACBLogistica.BReporte
            managerGenerarDocsVenta = New BGenerarDocsVenta(GApp.Periodo, GApp.Zona, GApp.Sucursal)

            AcFecha.ACDtpFecha_De.Value = New DateTime(DateTime.Now.Year, 1, 1)
            AcFecha.ACDtpFecha_A.Value = DateTime.Now
        Catch ex As Exception
            ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), Colecciones.getError("00000"), ex)
        End Try
    End Sub

#End Region

    'Private Function CargarCombos()
    '    Try '' Documento de Venta 
    '        Dim listDoc As New List(Of ETipos)
    '        Dim listDocBus As New List(Of ETipos)
    '        For Each Item As ETipos In Colecciones.TiposDocComprobante()
    '            listDoc.Add(Item.Clone)
    '            listDocBus.Add(Item.Clone)
    '        Next
    '        bs_tipodocumento = New BindingSource() : bs_tipodocumento.DataSource = listDocBus
    '        AddHandler bs_tipodocumento.CurrentChanged, AddressOf bs_tipodocumento_CurrentChanged
    '        bs_tipodocumento_CurrentChanged(Nothing, Nothing)
    '        'ACFramework.ACUtilitarios.ACCargaCombo(cmbTipoDocumento, listDoc, "TIPOS_Descripcion", "TIPOS_Codigo")

    '        bs_tipodocfacturacion = New BindingSource()
    '        bs_tipodocfacturacion.DataSource = Colecciones.TiposDocCompFacturacion()
    '        ACFramework.ACUtilitarios.ACCargaCombo(cmbTipoDocumento, bs_tipodocfacturacion, "TIPOS_Descripcion", "TIPOS_Codigo")
    '        AddHandler bs_tipodocfacturacion.CurrentChanged, AddressOf bs_documentosventa_CurrentChanged
    '        bs_documentosventa_CurrentChanged(Nothing, Nothing)

    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Function


    'Private Sub bs_documentosventa_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Try
    '        Dim managerGenerarDocsVenta As New BGenerarDocsVenta(GApp.Periodo, GApp.Zona, GApp.Sucursal)
    '        If Not IsNothing(bs_tipodocfacturacion.Current) Then
    '            '' Cargar las series
    '            If managerGenerarDocsVenta.GetSeries(CType(bs_tipodocfacturacion.Current, ETipos).TIPOS_Codigo) Then
    '                bs_series = New BindingSource
    '                bs_series.DataSource = managerGenerarDocsVenta.ListVENT_PVentDocumento
    '                Dim _default As String = ""
    '                For Each Item As EVENT_PVentDocumento In managerGenerarDocsVenta.ListVENT_PVentDocumento
    '                    If cmbTipoDocumento.SelectedValue = ETipos.getTipoComprobante(ETipos.TipoComprobanteVenta.Factura) Then
    '                        If Item.PVDOCU_Predeterminado Then
    '                            _default = Item.PVDOCU_Serie
    '                            Exit For
    '                        End If
    '                    ElseIf cmbTipoDocumento.SelectedValue = ETipos.getTipoComprobante(ETipos.TipoComprobanteVenta.Boleta) Then
    '                        If Item.PVDOCU_PredetBoleta Then
    '                            _default = Item.PVDOCU_Serie
    '                            Exit For
    '                        End If
    '                    End If
    '                Next
    '                '  ACFramework.ACUtilitarios.ACCargaCombo(cmbSerie, bs_series, "PVDOCU_Serie", "PVDOCU_Serie", _default)
    '                '   cmbBusSerie.Enabled = True
    '            Else
    '                'cmbBusSerie.Enabled = False
    '                'cmbBusSerie.SelectedIndex = -1
    '                'Throw New Exception("No se puede cargar las series, posiblemente no tenga series asignadas")
    '            End If
    '        End If
    '    Catch ex As Exception
    '        ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso cargar Series", ex)
    '    End Try
    'End Sub
    'Private Sub bs_tipodocumento_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Try
    '        If Not IsNothing(bs_tipodocumento.Current) Then
    '            '' Cargar las series
    '            Dim managerGenerarDocsVenta As New BGenerarDocsVenta(GApp.Periodo, GApp.Zona, GApp.Sucursal)
    '            If managerGenerarDocsVenta.GetSeries(CType(bs_tipodocumento.Current, ETipos).TIPOS_Codigo) Then
    '                bs_series = New BindingSource
    '                bs_series.DataSource = managerGenerarDocsVenta.ListVENT_PVentDocumento
    '                ACFramework.ACUtilitarios.ACCargaCombo(cmbSerie, managerGenerarDocsVenta.ListVENT_PVentDocumento, "PVDOCU_Serie", "PVDOCU_Serie")
    '                AddHandler bs_series.CurrentChanged, AddressOf bs_series_CurrentChanged
    '                bs_series_CurrentChanged(Nothing, Nothing)
    '            End If
    '        End If
    '    Catch ex As Exception
    '        ACControles.ACDialogos.ACMostrarMensajeError("Error: " & Me.Text, "Ocurrio un error en el proceso Cambiar Registro", ex)
    '    End Try
    'End Sub
    'Private Sub bs_series_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Try
    '        Dim managerGenerarDocsVenta As New BGenerarDocsVenta(GApp.Periodo, GApp.Zona, GApp.Sucursal)
    '        If Not IsNothing(bs_series) Then
    '            If Not IsNothing(bs_series.Current) Then
    '                Dim x_numero As Integer = managerGenerarDocsVenta.getNumero(CType(bs_series.Current, EVENT_PVentDocumento).PVDOCU_Serie, CType(bs_tipodocumento.Current, ETipos).TIPOS_Codigo)
    '                If Not IsNothing(CType(bs_series.Current, EVENT_PVentDocumento).PVDOCU_DispositivoImpresion) Then
    '                    '    tscmbImpresora.Text = CType(bs_series.Current, EVENT_PVentDocumento).PVDOCU_DispositivoImpresion
    '                End If
    '            End If
    '        End If
    '    Catch ex As Exception
    '        ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso cambiar serie", ex)
    '    End Try
    'End Sub

    'Private Function CargarAlmacenesOrigen()

    '    Try
    '        Dim _filter As New ACFramework.ACFiltrador(Of EPuntoVenta)(String.Format("PVENT_Activo=True")) 'PVENT_ActivoAlmacen

    '        Dim bs_almacenesOrigen = New BindingSource
    '        'Colecciones.GetAlmacenesAcceso()
    '        Colecciones.GetPuntosVenta()
    '        bs_almacenesOrigen.DataSource = _filter.ACFiltrar(Colecciones.PuntosVenta)
    '        c1grdAlmacenesDestino.DataSource = bs_almacenesOrigen
    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Function
    Private Function CargarAlmacenesDestino()

        Try
            Dim bs_almacenesDestino = New BindingSource
            Colecciones.GetPuntosVenta()


            If (GApp.EmpresaRUC = "20100241022" Or GApp.EmpresaRUC = "20100241022 ") Then
                Dim listaFinal = Colecciones.PuntosVenta.Where(Function(p) p.PVENT_Activo = True AndAlso p.SUCUR_Id <> 3 AndAlso GApp.ESucursal.SUCUR_Id AndAlso p.PVENT_Id <> 9 AndAlso p.PVENT_Id <> 1 AndAlso p.PVENT_Id <> 7 AndAlso p.PVENT_Id <> 13).ToList()

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




#Region "Formateo de Grillas "
    Private Sub formatearGrillaDestino()
        Dim _index As Integer = 1
        Try

            ACFrameworkC1.ACUtilitarios.ACFormatearGrilla(c1grdAlmacenesDestino, 1, 1, 4, 1)
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdAlmacenesDestino, _index, "Marcar", "Seleccionar", "Seleccionar", 80, True, True, "System.Boolean") : _index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdAlmacenesDestino, _index, "Almacen", "PVENT_Descripcion", "PVENT_Descripcion", 150, True, False, "System.Decimal", Parametros.GetParametro(EParametros.TipoParametros.pg_FMondo2d)) : _index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdAlmacenesDestino, _index, "Estado", "PVENT_Activo", "PVENT_Descripcion", 150, True, False, "System.Boolean") : _index += 1

            c1grdAlmacenesDestino.AllowEditing = True
            c1grdAlmacenesDestino.Styles.Alternate.BackColor = Color.LightGray
            c1grdAlmacenesDestino.Styles.Fixed.TextAlign = TextAlignEnum.CenterCenter
            c1grdAlmacenesDestino.Styles.Highlight.BackColor = Color.Gray
            c1grdAlmacenesDestino.SelectionMode = SelectionModeEnum.Row
        Catch ex As Exception
            ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Text), "No se puede dar formato a la grilla", ex)
        End Try
    End Sub



    Private Sub c1grdReporte_MouseClick(sender As Object, e As MouseEventArgs) Handles c1grdReporte.MouseClick
        Try
            If e.Button = System.Windows.Forms.MouseButtons.Right Then
                If c1grdAlmacenesDestino.Rows.Count > 1 Then
                    AccmsSeleccionarC11.ACMostrar(c1grdAlmacenesDestino, System.Windows.Forms.Cursor.Position, "Seleccionar")
                End If
            End If
        Catch ex As Exception
            ACControles.ACDialogos.MostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ha ocurrido un error en el proceso seleccionar", ex)
        End Try
    End Sub

    Private Sub btnProcesar_Click(sender As Object, e As EventArgs) Handles btnProcesar.Click
        'Buscar Productos Iniciar Proceso

        Try


            BusquedaVentasFull()
        Catch ex As Exception
            If ACUtilitarios.ACCrearCadena("StrConn", GApp.Servidor, GApp.BaseDatos, GApp.Usuario, GApp.Password_DB) Then
                DAEnterprise.Instanciar("StrConn", True)
            End If
            ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), String.Format(Colecciones.getError("00101"), "Procesar Consulta"), ex)
        End Try


    End Sub


    Private Sub BusquedaVentasFull() 'Conexion a Diferentes BD   ORIGINAL 
        x_dtdata = New DataSet
        bs_reporte = New BindingSource
        pgBar.Minimum = 0
        pgBar.Value = 0
        pgBar.Step = 1

        Dim _fecini As DateTime = New DateTime(AcFecha.ACFecha_De.Value.Year, AcFecha.ACFecha_De.Value.Month, 1)
        Dim _fecfin As DateTime = DateSerial(Year(AcFecha.ACFecha_A.Value), Month(AcFecha.ACFecha_A.Value) + 1, 0)
        Dim _nroalmacenes As Short = 0



        If TypeOf c1grdAlmacenesDestino.DataSource Is BindingSource Then
            Dim bs_almacenes As BindingSource = DirectCast(c1grdAlmacenesDestino.DataSource, BindingSource)

            ' Lista acumulativa de cotizaciones
            Dim ListaGuiasVentasOrdenes As New List(Of DataSet)

            If bs_almacenes.List IsNot Nothing Then
                For Each itemAlmacen As EPuntoVenta In bs_almacenes.List.OfType(Of EPuntoVenta)()
                    If itemAlmacen.Seleccionar Then
                        If ACUtilitarios.ACCrearCadena("ConexionPuntoVentas", itemAlmacen.PVENT_DireccionIP, itemAlmacen.PVENT_BaseDatos) Then
                            DAEnterprise.Instanciar("ConexionPuntoVentas", True)
                            Try
                                If (itemAlmacen.PVENT_DireccionIP = "192.168.30.2") Then

                                Else
                                    Dim listaTemporal As New List(Of DataSet)


                                    Dim ds As DataSet = managerBReporte.ALMA_REPOSS_TOTAL_Almacen(x_dtdata, _fecini, _fecfin)
                                    If ds IsNot Nothing AndAlso ds.Tables.Count > 0 AndAlso ds.Tables(0).Rows.Count > 0 Then
                                        ListaGuiasVentasOrdenes.Add(ds)
                                    End If
                                    'listaTemporal = managerBReporte.ALMA_REPOSS_TOTAL_Almacen(x_dtdata, _fecini, _fecfin)
                                    'CargarCotizacionCompraCabecera(AcFecha.ACDtpFecha_De.Value, AcFecha.ACDtpFecha_A.Value, itemAlmacen.SUCUR_Nombre)

                                    ' Acumular la lista
                                    ListaGuiasVentasOrdenes.AddRange(listaTemporal)
                                End If

                            Catch ex As Exception
                                MessageBox.Show("Error" + ex.Message() + "En La Sucursal " + itemAlmacen.SUCUR_Nombre)
                            End Try
                        End If
                    End If
                Next
            Else

            End If

            ' Asignar la lista acumulada a la grilla después de completar el bucle
            'Dim bindingSource As New BindingSource()
            'bindingSource.DataSource = ListaGuiasVentasOrdenes
            'c1grdReporte.DataSource = bindingSource

            Dim dtUnido As New DataTable()
            For Each ds As DataSet In ListaGuiasVentasOrdenes
                If ds IsNot Nothing AndAlso ds.Tables.Count > 0 Then
                    If dtUnido.Columns.Count = 0 Then
                        dtUnido = ds.Tables(0).Clone() 'Clona estructura
                    End If
                    For Each row As DataRow In ds.Tables(0).Rows
                        dtUnido.ImportRow(row)
                    Next
                End If
            Next

            ' Asignar el DataTable unido a la grilla
            bs_reporte.DataSource = dtUnido
            c1grdReporte.DataSource = bs_reporte
            bnavReporte.BindingSource = bs_reporte

            c1grdReporte.AllowEditing = False
            c1grdReporte.AllowSorting = True
            For index As Integer = 1 To 99
                If bs_reporte.Count = 0 Then
                    pgBar.Value = index + 1

                Else
                    pgBar.Value = index + 1

                End If
            Next


        End If

    End Sub

    'Private Sub BusquedaVentasFull() 'Conexion a Diferentes BD 
    '    x_dtdata = New DataSet
    '    bs_reporte = New BindingSource
    '    pgBar.Minimum = 0
    '    pgBar.Value = 0
    '    pgBar.Step = 1

    '    Dim _fecini As DateTime = New DateTime(AcFecha.ACFecha_De.Value.Year, AcFecha.ACFecha_De.Value.Month, 1)
    '    Dim _fecfin As DateTime = DateSerial(Year(AcFecha.ACFecha_A.Value), Month(AcFecha.ACFecha_A.Value) + 1, 0)
    '    Dim _nroalmacenes As Short = 0


    '    'GENERAMOS LAS VARIABLES GLOBALES 
    '    '***************************************************************
    '    Dim dtUnido As New DataTable()
    '    ' Lista acumulativa de cotizaciones
    '    'Dim ListaGuiasVentasOrdenes As New List(Of DataSet)


    '    ''**************************************************************


    '    If TypeOf c1grdAlmacenesOrigen.DataSource Is BindingSource Then
    '        Dim bs_almacenesOrigen As BindingSource = DirectCast(c1grdAlmacenesOrigen.DataSource, BindingSource)
    '        Dim bs_almacenesDestino As BindingSource = DirectCast(c1grdAlmacenesDestino.DataSource, BindingSource)


    '        If bs_almacenesOrigen.List IsNot Nothing Then
    '            For Each itemAlmacenOrigen As EPuntoVenta In bs_almacenesOrigen.List.OfType(Of EPuntoVenta)()
    '                If itemAlmacenOrigen.Seleccionar Then
    '                    If ACUtilitarios.ACCrearCadena("ConexionPuntoVentas", itemAlmacenOrigen.PVENT_DireccionIP, itemAlmacenOrigen.PVENT_BaseDatos) Then
    '                        DAEnterprise.Instanciar("ConexionPuntoVentas", True)
    '                        '************************************************************************************************************
    '                        '*******************************************PRIMERO GUARDAMOS EN LA LISTA *****************************************************************
    '                        '*************************************************LOS REGISTROS DE LAS LISTAS EN EL ORIGEN***********************************************************

    '                        If GApp.EPuntoVenta.PVENT_DireccionIP = itemAlmacenOrigen.PVENT_DireccionIP Then
    '                            listaTemporalOrigen = managerBReporte.ALMA_REPOSS_TOTAL_AlmacenLocal(x_dtdata, _fecini, _fecfin)
    '                            If listaTemporalOrigen IsNot Nothing AndAlso listaTemporalOrigen.Tables.Count > 0 AndAlso listaTemporalOrigen.Tables(0).Rows.Count > 0 Then
    '                                ListaGuiasVentasOrdenesOrigen.Add(listaTemporalOrigen)
    '                            End If


    '                        Else
    '                            listaTemporalOrigen = managerBReporte.ALMA_REPOSS_TOTAL_AlmacenExterno(x_dtdata, _fecini, _fecfin)
    '                            If listaTemporalOrigen IsNot Nothing AndAlso listaTemporalOrigen.Tables.Count > 0 AndAlso listaTemporalOrigen.Tables(0).Rows.Count > 0 Then
    '                                ListaGuiasVentasOrdenesOrigen.Add(listaTemporalOrigen)
    '                            End If



    '                    End If
    '                        ' Acumular la lista
    '                        'ListaGuiasVentasOrdenesOrigen.AddRange(listaTemporalOrigen)
    '                        '************************************************************************************************************
    '                        '************************************************************************************************************
    '                        '************************************************************************************************************

    '                        'Conexion con la seleccion 
    '                        For Each itemAlmacenDestino As EPuntoVenta In bs_almacenesDestino.List.OfType(Of EPuntoVenta)()
    '                            If itemAlmacenDestino.Seleccionar Then
    '                                ExtraerDatosSucursalesExternos("ConexionPuntoVentas", itemAlmacenDestino.PVENT_DireccionIP, itemAlmacenDestino.PVENT_BaseDatos, _fecini, _fecfin)

    '                            End If
    '                        Next
    '                            End If

    '                End If
    '            Next
    '        Else

    '        End If

    '        ' Asignar la lista acumulada a la grilla después de completar el bucle
    '        'Dim bindingSource As New BindingSource()
    '        'bindingSource.DataSource = ListaGuiasVentasOrdenes
    '        'c1grdReporte.DataSource = bindingSource

    '        'Dim dtUnido As New DataTable()
    '        'For Each ds As DataSet In ListaGuiasVentasOrdenesDestino
    '        '    If ds IsNot Nothing AndAlso ds.Tables.Count > 0 Then
    '        '        If dtUnido.Columns.Count = 0 Then
    '        '            dtUnido = ds.Tables(0).Clone() 'Clona estructura
    '        '        End If
    '        '        For Each row As DataRow In ds.Tables(0).Rows
    '        '            dtUnido.ImportRow(row)
    '        '        Next
    '        '    End If
    '        'Next


    '        '´*****************************FUNCION DE LISTAS***************************************************
    '        '**********************************************************************************
    '        CruzeDeListasOrigenDestino()

    '        ' Asignar el DataTable unido a la grilla
    '        bs_reporte.DataSource = dtUnido
    '        c1grdReporte.DataSource = bs_reporte

    '        c1grdReporte.AllowEditing = False

    '    End If

    'End Sub


    Private Function ExtraerDatosSucursalesExternos(ByVal NombreConexion As String, ByVal DireccionIP As String, ByVal BaseDATOS As String, ByVal _fecini As Date, ByVal _fecfin As Date)
        If ACUtilitarios.ACCrearCadena("ConexionPuntoVentas", DireccionIP, BaseDATOS) Then
            DAEnterprise.Instanciar("ConexionPuntoVentas", True)





            listaTemporalDestino = managerBReporte.ALMA_REPOSS_TOTAL_AlmacenExterno(x_dtdata, _fecini, _fecfin)
            If listaTemporalDestino IsNot Nothing AndAlso listaTemporalDestino.Tables.Count > 0 AndAlso listaTemporalDestino.Tables(0).Rows.Count > 0 Then
                ListaGuiasVentasOrdenesDestino.Add(listaTemporalDestino)
            End If
            'listaTemporal = managerBReporte.ALMA_REPOSS_TOTAL_Almacen(x_dtdata, _fecini, _fecfin)
            'CargarCotizacionCompraCabecera(AcFecha.ACDtpFecha_De.Value, AcFecha.ACDtpFecha_A.Value, itemAlmacen.SUCUR_Nombre)

            ' Acumular la lista
            'ListaGuiasVentasOrdenesDestino.AddRange(listaTemporalDestino)


        End If
    End Function

    Private Function CruzeDeListasOrigenDestino()
        For Each dsOrigen As DataSet In ListaGuiasVentasOrdenesOrigen
            For Each filaOrigen As DataRow In dsOrigen.Tables(0).Rows
                Dim codigoOrigen As String = filaOrigen("DOCVE_Codigo").ToString()

                ' Buscar en TODAS las filas de TODOS los datasets destino
                Dim existeEnDestino As Boolean = ListaGuiasVentasOrdenesDestino.Any(
                Function(dsDestino)
                    dsDestino.Tables(0).AsEnumerable().
                        Any(Function(f) f("DOCVE_Codigo").ToString() = codigoOrigen)
                End Function
            )

                If existeEnDestino Then
                    Console.WriteLine($"Documento {codigoOrigen} ya está en la lista destino")
                Else
                    Console.WriteLine($"Documento {codigoOrigen} NO está en la lista destino")
                End If
            Next
        Next
    End Function







    Private Sub btnExcel_Click(sender As Object, e As EventArgs) Handles btnExcel.Click
        'Asignar Tabla excel Para generar Reporte
        Try
            Utilitarios.ExportarXLS(c1grdReporte, "Reporte Entregas")
        Catch ex As Exception
            ACControles.ACDialogos.ACMostrarMensajeInformacion(String.Format("Información: {0}", Me.Text), "No se puede Exportar a Excel")
        End Try
    End Sub




#End Region
    Private Sub txtBusNumero_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyData = Keys.Enter Then
            txtBusNumero_ACAyudaClick(Nothing, Nothing)
        End If
    End Sub
    Private Sub txtBusNumero_ACAyudaClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            ' BusquedaXDocumento(txtBusqueda.Text)
        Catch ex As Exception
            ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Convert.ToString(Text)), "No se puede cargar la ayuda de documentos", ex)
        End Try
    End Sub

    'Private Sub c1grdReporte_BeforeSort(sender As Object, e As SortColEventArgs) Handles c1grdReporte.BeforeSort
    '    'Cambios para ordenar las tablas 

    '    Try
    '        Ordenar(c1grdReporte.Cols(e.Col).UserData)
    '        c1grdReporte.Subtotal(AggregateEnum.Clear)
    '    Catch ex As Exception
    '        ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso ordenar", ex)
    '    End Try


    'End Sub


    Private Sub c1grdReporte_BeforeSort(sender As Object, e As SortColEventArgs) Handles c1grdReporte.BeforeSort
        '     Private Sub c1grdBusqueda_BeforeSort(ByVal sender As System.Object, ByVal e As C1.Win.C1FlexGrid.SortColEventArgs) Handles c1grdBusqueda.BeforeSort
        Try
            ' Obtener nombre de campo desde UserData
            Ordenar(c1grdReporte.Cols(e.Col).UserData.ToString())

            ' Limpiar subtotales después de ordenar
            c1grdReporte.Subtotal(AggregateEnum.Clear)



            ' c1grdReporte.Subtotal(AggregateEnum.Clear)
        Catch ex As Exception
            ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso ordenar", ex)
        End Try
        'End Sub
    End Sub
    'Private Sub Ordenar(ByVal x_columna As String)
    '    Dim _ordenador As New ACOrdenador(Of EDIST_OrdenesDetalle)
    '    Try
    '        If m_order = 2 Then x_columna += " DESC"
    '        _ordenador.ACOrdenamiento = x_columna

    '        CType(bs_reporte.DataSource, List(Of EDIST_OrdenesDetalle)).Sort(_ordenador)
    '        c1grdReporte.Refresh()
    '        m_order = IIf(m_order = 1, 2, 1)
    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Sub

    'Usamos ordenar con bignidinrsrouce en una datatble 

    Private Sub Ordenar(ByVal x_columna As String)
        Try
            ' Añadir DESC si corresponde
            If m_order = 2 Then x_columna &= " DESC"

            ' --- Ordenar usando BindingSource.Sort ---
            bs_reporte.Sort = x_columna       ' si DataSource es DataTable/DataView
            c1grdReporte.Refresh()

            ' Cambiar orden para próxima vez
            m_order = If(m_order = 1, 2, 1)

        Catch ex As Exception
            Throw
        End Try
    End Sub




End Class