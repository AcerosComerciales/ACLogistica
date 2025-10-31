Imports ACBLogistica
Imports ACEVentas
Imports ACBVentas
Imports DAConexion
Imports ACFramework
Imports C1.Win.C1FlexGrid

Public Class RcruzeAlmacenes
#Region " Variables "

    Private bs_almacenes As BindingSource


    Private bs_reporte As BindingSource

    Private frmCons As CProductos
    Private m_earticulos As EArticulos
    Private m_reporte As ACBLogistica.BReporte

    Private managerConsultaArticulos As BConsultaArticulos

    Private m_artic_codigo As String
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

            actxaProdDescripcion.ACAyuda.Enabled = False
            actxaProdDescripcion.ACActivarAyudaAuto = False

            formatearGrilla()
            Cargaralmacenes()

            If Not IsNothing(x_icono) Then Me.Icon = Icon.FromHandle(x_icono.GetHicon)

        Catch ex As Exception
            ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), Colecciones.getError("00000"), ex)
        End Try
    End Sub
#End Region

#Region " Metodos "
    Private Sub Cargaralmacenes()
        Try
            bs_almacenes = New BindingSource
            Dim _filter As New ACFramework.ACFiltrador(Of EAlmacenes)(String.Format("ALMAC_Activo=True"))

            Colecciones.GetAlmacenesAcceso()
            bs_almacenes.DataSource = _filter.ACFiltrar(Colecciones.AlmacenesAcceso)
            c1grdAlmacenes.DataSource = bs_almacenes
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub formatearGrilla()

        Dim _index As Integer = 1
        Try
            formateargrillaguias()
            'Precios
            ACFrameworkC1.ACUtilitarios.ACFormatearGrilla(c1grdAlmacenes, 1, 1, 3, 1)
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdAlmacenes, _index, "X", "Seleccionar", "Seleccionar", 80, True, True, "System.Boolean") : _index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdAlmacenes, _index, "Almacen", "ALMAC_Descripcion", "ALMAC_Descripcion", 150, True, False, "System.Decimal", Parametros.GetParametro(EParametros.TipoParametros.pg_FMondo2d)) : _index += 1

            c1grdAlmacenes.AllowEditing = True
            c1grdAlmacenes.Styles.Alternate.BackColor = Color.LightGray
            c1grdAlmacenes.Styles.Fixed.TextAlign = TextAlignEnum.CenterCenter
            c1grdAlmacenes.Styles.Highlight.BackColor = Color.Gray
            c1grdAlmacenes.SelectionMode = SelectionModeEnum.Row
        Catch ex As Exception
            ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Text), "No se puede dar formato a la grilla", ex)
        End Try

    End Sub


    Private Sub formateargrillaguias()

        Dim index As Integer = 1
        Try
            index = 1

            ACFrameworkC1.ACUtilitarios.ACFormatearGrilla(c1grdBusqueda, 1, 1, 6, 1, 1)

            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Documento", "Documento", "Documento", 90, True, False, "System.String") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Fecha", "GUIAR_FechaDocumento", "GUIAR_FechaDocumento", 90, True, False, "System.DateTime", Parametros.GetParametro(EParametros.TipoParametros.pg_FormatoFecha)) : index += 1
            'ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Diferencia", "Diferencia", "Diferencia", 90, True, False, "System.Decimal") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Estado", "GUIAR_Estado", "GUIAR_Estado", 90, True, False, "System.String") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Cantidad", "GUIAR_Cantidad", "GUIAR_Cantidad", 90, True, False, "System.Decimal") : index += 1

            If Not IsNothing(bs_almacenes) Then
                For Each item As EAlmacenes In CType(bs_almacenes.DataSource, List(Of EAlmacenes))
                    If item.Seleccionar Then
                        c1grdBusqueda.Cols.Count += 1
                        ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, item.ALMAC_Descripcion, String.Format("Alma{0}", item.ALMAC_Id), String.Format("Alma{0}", item.ALMAC_Id), 100, True, False, "System.Decimal", Parametros.GetParametro(EParametros.TipoParametros.pg_FMondo2d))
                        index += 1
                    End If
                Next
                c1grdBusqueda.Cols.Count += 1
                ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Diferencia", "Diferencia", "Diferencia", 90, True, False, "System.Decimal", Parametros.GetParametro(EParametros.TipoParametros.pg_FMondo2d))
                End If

            

            c1grdBusqueda.AllowEditing = False
            c1grdBusqueda.AllowSorting = AllowSortingEnum.SingleColumn
            c1grdBusqueda.Styles.Alternate.BackColor = Color.LightGray
            c1grdBusqueda.Styles.Fixed.TextAlign = TextAlignEnum.CenterCenter
            c1grdBusqueda.Styles.Highlight.BackColor = Color.Gray
            c1grdBusqueda.SelectionMode = SelectionModeEnum.Row
            c1grdBusqueda.AutoResize = False
            ''   c1grdBusqueda.Cols("DOCVE_DescripcionCliente").Style.WordWrap = True

            '.Tree.Column = 1

            Dim tt As C1.Win.C1FlexGrid.CellStyle = c1grdBusqueda.Styles.Add("Confirmado")
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

    Private Sub btnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click
        Try
            Dim _j As Integer = 1

            formateargrillaguias()
            For Each itemAlmacen As EAlmacenes In CType(bs_almacenes.DataSource, List(Of EAlmacenes))
                If itemAlmacen.Seleccionar Then
                    _j += 1
                End If
            Next

            If m_reporte.Repor_ProductXGuias(GApp.Periodo, GApp.Almacen, actxaProdCodigo.Text, AcFecha.ACDtpFecha_De.Value.Date, AcFecha.ACDtpFecha_A.Value.Date, chkTodos.Checked) Then
                'm_cargado = True
                'bs_reporte.DataSource = m_reporte.DTTabla

                c1grdBusqueda.Rows.Count = m_reporte.DTTabla.Rows.Count + 1
                Dim _i As Integer = 1
                For Each item As DataRow In m_reporte.DTTabla.Rows
                    c1grdBusqueda.Rows(_i)("Documento") = item("Documento")
                    c1grdBusqueda.Rows(_i)("GUIAR_FechaDocumento") = item("GUIAR_FechaDocumento")

                    c1grdBusqueda.Rows(_i)("Guiar_Cantidad") = item("Guiar_Cantidad")
                    c1grdBusqueda.Rows(_i)("Diferencia") = c1grdBusqueda.Rows(_i)("Guiar_Cantidad")
                    c1grdBusqueda.Rows(_i)("GUIAR_Estado") = item("GUIAR_Estado")
                    _i += 1

                Next
                c1grdBusqueda.AutoSizeCols()
            End If
            For Each itemAlmacen As EAlmacenes In CType(bs_almacenes.DataSource, List(Of EAlmacenes))
                If itemAlmacen.Seleccionar Then
                    If ACUtilitarios.ACCrearCadena("StrConn", itemAlmacen.PVENT_DireccionIP, itemAlmacen.PVENT_BaseDatos, GApp.Usuario_DB, GApp.Password_DB) Then
                        DAEnterprise.Instanciar("StrConn", True)
                        If m_reporte.Repor_ProductXGuiasv(GApp.Periodo, itemAlmacen.ALMAC_Id, actxaProdCodigo.Text, AcFecha.ACDtpFecha_De.Value.Date, AcFecha.ACDtpFecha_A.Value.Date, chkTodos.Checked) Then
                            Dim _i As Integer = 1

                            For items = 1 To c1grdBusqueda.Rows.Count

                                For Each item As DataRow In m_reporte.DTTabla.Rows
                                    If _i > (c1grdBusqueda.Rows.Count - 1) Then Exit For
                                    If item("Documento") = c1grdBusqueda.Rows(items)("Documento") Then
                                        c1grdBusqueda.Rows(_i)(String.Format("Alma{0}", itemAlmacen.ALMAC_Id)) = item("Guiar_Cantidad")
                                        If Not item("Guiar_Cantidad") Is DBNull.Value Then
                                            c1grdBusqueda.Rows(_i)("Diferencia") -= item("Guiar_Cantidad")
                                        End If
                                    End If


                                Next
                                _i += 1
                            Next
                        End If
                    End If
                    If ACUtilitarios.ACCrearCadena("StrConn", GApp.Servidor, GApp.BaseDatos, GApp.Usuario_DB, GApp.Password_DB) Then
                        DAEnterprise.Instanciar("StrConn", True)
                    End If
                End If
            Next



            
        Catch ex As Exception
            If ACUtilitarios.ACCrearCadena("StrConn", GApp.Servidor, GApp.BaseDatos, GApp.Usuario_DB, GApp.Password_DB) Then
                DAEnterprise.Instanciar("StrConn", True)
            End If
            ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso Cargar Listado Productos", ex)
        End Try
    End Sub


#End Region
#Region "grillas"
    
    Private Sub c1grdBusqueda_OwnerDrawCell(sender As Object, e As OwnerDrawCellEventArgs) Handles c1grdBusqueda.OwnerDrawCell
        Try
            If e.Row < c1grdBusqueda.Rows.Fixed OrElse e.Col < c1grdBusqueda.Cols.Fixed Then Return
            If c1grdBusqueda.Rows(e.Row)("GUIAR_Estado") = "Confirmado" Then
                e.Style = c1grdBusqueda.Styles("Confirmado")
            End If
            If c1grdBusqueda.Rows(e.Row)("GUIAR_Estado") = "Anulado" Then
                e.Style = c1grdBusqueda.Styles("Anulado")
            End If


            If c1grdBusqueda.Cols(e.Col).Name = "Diferencia" Then
                If c1grdBusqueda(e.Row, "Diferencia") > 0 Then
                    e.Style = c1grdBusqueda.Styles("Anulado")
                End If
                If c1grdBusqueda(e.Row, "Diferencia") < 1 And c1grdBusqueda(e.Row, "Diferencia") > -1 Then
                    e.Style = c1grdBusqueda.Styles("Facturar")
                End If
            End If


        Catch ex As Exception
            ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso cambia de color", ex)
        End Try
    End Sub
#End Region

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Try
            Utilitarios.ExportarXLS(c1grdBusqueda, "Cruce de Almacenes")
        Catch ex As Exception
            ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso Exportar a Excel", ex)
        End Try
    End Sub



End Class