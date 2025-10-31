Imports ACBLogistica
Imports ACEVentas
Imports ACBVentas

Imports ACFramework
Imports C1.Win.C1FlexGrid

Public Class RKardexXArticuloStockFisico
#Region " Variables "
    Private bs_reporte As BindingSource

    Private frmCons As CProductos
    Private m_earticulos As EArticulos
    Private m_reporte As ACBLogistica.BReporte
    Private managerConsultaArticulos As BConsultaArticulos

    Private m_artic_codigo As String
    Private m_artic_descripion As String
    Private m_cargado As Boolean = False
#End Region

#Region " Propiedades "

#End Region

#Region " Constructores "
    Public Sub New(ByVal x_icono As System.Drawing.Bitmap)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Try

            managerConsultaArticulos = New BConsultaArticulos(GApp.Periodo)
            m_reporte = New ACBLogistica.BReporte(GApp.Almacen, GApp.Periodo, GApp.Sucursal)

            actxaProdDescripcion.ACAyuda.Enabled = False
            actxaProdDescripcion.ACActivarAyudaAuto = False

            formatearGrilla()

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
            index = 1
            ACFrameworkC1.ACUtilitarios.ACFormatearGrilla(c1grdBusqueda, 1, 1, 8, 1, 2)

            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Nro", "Movimiento", "ENTID_CodigoProveedor", 90, False, False, "System.String") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Fecha", "DOCVE_FechaDocumento", "INGCO_FechaDocumento", 90, True, False, "System.DateTime", Parametros.GetParametro(EParametros.TipoParametros.pg_FormatoFecha)) : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Documento", "Documento", "Documento", 200, True, False, "System.String") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Descripción", "DOCVE_DescripcionCliente", "DOCVE_DescripcionCliente", 400, True, False, "System.String") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Entrada", "Ingreso", "Ingreso", 90, True, False, "System.Decimal", Parametros.GetParametro(EParametros.TipoParametros.pg_FMondo2d)) : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Salida", "Salida", "Salida", 90, True, False, "System.Decimal", Parametros.GetParametro(EParametros.TipoParametros.pg_FMondo2d)) : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Stock", "Stock", "Stock", 90, True, False, "System.Decimal", Parametros.GetParametro(EParametros.TipoParametros.pg_FMondo2d)) : index += 1

            c1grdBusqueda.AllowEditing = False
            c1grdBusqueda.AllowSorting = AllowSortingEnum.SingleColumn
            c1grdBusqueda.Styles.Alternate.BackColor = Color.LightGray
            c1grdBusqueda.Styles.Fixed.TextAlign = TextAlignEnum.CenterCenter
            c1grdBusqueda.Styles.Highlight.BackColor = Color.Gray
            c1grdBusqueda.SelectionMode = SelectionModeEnum.Row
            c1grdBusqueda.AutoResize = False
            c1grdBusqueda.Cols("DOCVE_DescripcionCliente").Style.WordWrap = True

            '.Tree.Column = 1

            Dim tt As C1.Win.C1FlexGrid.CellStyle = c1grdBusqueda.Styles.Add("Facturado")
            tt.BackColor = Color.LightGreen
            tt.ForeColor = Color.DarkBlue
            tt.Font = New Font(c1grdBusqueda.Font, FontStyle.Regular)

            Dim uu As C1.Win.C1FlexGrid.CellStyle = c1grdBusqueda.Styles.Add("Facturar")
            uu.BackColor = Color.Green
            uu.ForeColor = Color.White
            uu.Font = New Font(c1grdBusqueda.Font, FontStyle.Regular)

            Dim dd As C1.Win.C1FlexGrid.CellStyle = c1grdBusqueda.Styles.Add("Anulado")
            dd.BackColor = Color.Red
            dd.ForeColor = Color.White
            dd.Font = New Font(c1grdBusqueda.Font, FontStyle.Bold)
            c1grdBusqueda.DrawMode = C1.Win.C1FlexGrid.DrawModeEnum.OwnerDraw

            c1grdBusqueda.SubtotalPosition = SubtotalPositionEnum.AboveData
            c1grdBusqueda.Tree.Column = 2

            Dim s As CellStyle = c1grdBusqueda.Styles(CellStyleEnum.Subtotal0)
            s.BackColor = Color.White
            s.ForeColor = Color.Red
            s.Font = New Font(c1grdBusqueda.Font, FontStyle.Bold)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub setProducto(ByVal x_opcion As Boolean)
        Try
            If x_opcion Then
                'If managerConsultaArticulos.cargarProducto(m_earticulos.ARTIC_Codigo) Then
                actxaProdCodigo.Text = m_earticulos.ARTIC_Codigo
                actxaProdDescripcion.Text = m_earticulos.ARTIC_Descripcion
                btnCargar.Focus()
                'End If
            Else
                actxaProdCodigo.Clear()
                actxaProdDescripcion.Clear()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
#End Region

#Region " Metodos de Controles"
    Private Sub AcFecha_ACFecIni_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles AcFecha.ACFecIni_KeyDown
        If e.KeyData = Keys.Enter Then
            AcFecha.ACDtpFecha_A.Focus()
        End If
    End Sub

    Private Sub AcFecha_ACFecFin_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles AcFecha.ACFecFin_KeyDown
        If e.KeyData = Keys.Enter Then
            btnCargar_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub btnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click
        Try
            formatearGrilla()
            Dim _ingreso As Decimal = 0
            Dim _egreso As Decimal = 0
            bs_reporte = New BindingSource
            m_artic_codigo = actxaProdCodigo.Text
            m_artic_descripion = actxaProdDescripcion.Text

            If m_reporte.KardexXArticuloStockFisico(actxaProdCodigo.Text, GApp.Almacen, GApp.Periodo, GApp.Zona, AcFecha.ACDtpFecha_De.Value.Date, AcFecha.ACDtpFecha_A.Value.Date) Then
                m_cargado = True
                For Each item As DataRow In m_reporte.DTTabla.Rows
                    _ingreso += item("Ingreso")

                    If item("Movimiento").Equals(0) Then
                        _egreso += 0
                    Else
                        _egreso += item("Salida")
                    End If
                Next

                bs_reporte.DataSource = m_reporte.DTTabla
            Else
                m_cargado = False
                bs_reporte.DataSource = Nothing
            End If
            c1grdBusqueda.DataSource = bs_reporte
            bnavNavegador.BindingSource = bs_reporte

            c1grdBusqueda.Subtotal(AggregateEnum.Sum, 0, -1, c1grdBusqueda.Cols("Ingreso").Index, "Total")
            c1grdBusqueda.Subtotal(AggregateEnum.Sum, 0, -1, c1grdBusqueda.Cols("Salida").Index, "Total")
            c1grdBusqueda.Subtotal(AggregateEnum.Sum, 0, -1, c1grdBusqueda.Cols("Stock").Index, "Total")
            'c1grdBusqueda.Subtotal(AggregateEnum.None, 0, 1, c1grdBusqueda.Cols("Descripción").Index, "Total algomas")

            c1grdBusqueda.Rows(1)("Stock") = _ingreso - _egreso

            actxnIngresos.Text = _ingreso : actxnIngresos.Formatear()
            actxnSalida.Text = _egreso : actxnSalida.Formatear()
            actxnStock.Text = _ingreso - _egreso : actxnStock.Formatear()

            c1grdBusqueda.AutoSizeRows()
            c1grdBusqueda.AutoSizeCol(3)
        Catch ex As Exception
            ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), String.Format(Colecciones.getError("00101"), "Cargar el Reporte"), ex)
        End Try
    End Sub

    Private Sub tsbtnprevisualizar_Click(sender As Object, e As EventArgs) Handles tsbtnprevisualizar.Click
        Try
            Dim _reporte As New Reporte
            If m_cargado Then
                _reporte.RKardexXArticulo(m_reporte.DTTabla, AcFecha.ACDtpFecha_De.Value.Date, AcFecha.ACDtpFecha_A.Value.Date, String.Format("{0} - {1}", m_artic_codigo, m_artic_descripion), False)
            Else
                m_artic_codigo = actxaProdCodigo.Text
                m_artic_descripion = actxaProdDescripcion.Text
                _reporte.RKardexXArticulo(m_artic_codigo, AcFecha.ACDtpFecha_De.Value.Date, AcFecha.ACDtpFecha_A.Value.Date, String.Format("{0} - {1}", m_artic_codigo, m_artic_descripion), False)
            End If


        Catch ex As Exception
            ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), String.Format(Colecciones.getError("00101"), "Cargar el Reporte"), ex)
        End Try
    End Sub

    Private Sub actxaProdCodigo_ACAyudaClick(sender As Object, e As EventArgs) Handles actxaProdCodigo.ACAyudaClick
        Try
            If IsNothing(frmCons) Then frmCons = New CProductos(CProductos.Origen.Cotizaciones) With {.StartPosition = FormStartPosition.CenterScreen}
            Me.KeyPreview = False
            If frmCons.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                m_earticulos = frmCons.Articulo
                setProducto(True)

                Me.KeyPreview = True
            End If
        Catch ex As Exception
            ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso cargar productos", ex)
        End Try
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Try
            If m_cargado Then
                Utilitarios.ExportarXLS(c1grdBusqueda, "Kardex")
            Else
                Throw New Exception("No se ha cargado el reporte, para continuar haga click en el boton procesar")
            End If
        Catch ex As Exception
            ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), String.Format(Colecciones.getError("00101"), "Cargar el Reporte"), ex)
        End Try
    End Sub

    Private Sub tsbtnSalir_Click(sender As Object, e As EventArgs) Handles tsbtnSalir.Click
        Me.Close()
    End Sub

    Private Sub actxaProdCodigo_KeyDown(sender As Object, e As KeyEventArgs) Handles actxaProdCodigo.KeyDown
        Try
            If e.KeyData = Keys.Enter Then
                If actxaProdCodigo.Text.Trim.Length = 7 Then
                    Dim _art As New BArticulos
                    If _art.Cargar(actxaProdCodigo.Text.Trim) Then
                        actxaProdCodigo.Text = _art.Articulos.ARTIC_Codigo
                        actxaProdDescripcion.Text = _art.Articulos.ARTIC_Descripcion
                    End If
                End If
            End If
        Catch ex As Exception
            ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), String.Format(Colecciones.getError("00101"), "Cargar el Articulo"), ex)
        End Try
    End Sub
#End Region

End Class
