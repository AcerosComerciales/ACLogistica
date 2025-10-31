Imports ACBVentas
Imports ACEVentas
Imports ACFramework
Imports ACFrameworkC1
Imports ACELogistica
Imports Microsoft.Practices.Unity
Imports Microsoft.Practices.Unity.Configuration
Imports C1.Win.C1FlexGrid

Public Class CProductos
#Region " Variables "
   Private managerConsultaArticulos As BConsultaArticulos
   Private managerArticulos As BArticulos
   Private m_listLineas As List(Of ELineas)
   Private m_listSubLineas As List(Of ELineas)

   Private bs_productos As BindingSource
   Private bs_lineas As BindingSource
   Private bs_sublineas As BindingSource
   Private bs_precios As BindingSource
   Private bs_stocks As BindingSource

   Private m_opcion As Origen

   Private m_articulo As EArticulos


   Enum Origen
      Cotizaciones
      Pedidos
   End Enum

#End Region

#Region " Propiedades "

   Public Property Articulo() As EArticulos
      Get
         Return m_articulo
      End Get
      Set(ByVal value As EArticulos)
         m_articulo = value
      End Set
   End Property
#End Region

#Region " Constructores "
   Public Sub New(ByVal x_opcion As Origen)

      ' This call is required by the Windows Form Designer.
      InitializeComponent()

      Try
         m_opcion = x_opcion
         Inicializar()
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "No se puede cargar los controles iniciales", ex)
      End Try
   End Sub

   Public Sub New(ByVal x_opcion As Origen, ByVal x_cadena As String, ByVal x_campo As String)
      ' This call is required by the Windows Form Designer.
      InitializeComponent()
      Try
         m_opcion = x_opcion
         Inicializar()
         If Not IsNothing(x_cadena) Then
            If x_campo.Equals("ARTIC_Codigo") Then
               If x_cadena.Length = 2 Then
                  cmbLinea.SelectedValue = x_cadena
               ElseIf x_cadena.Length >= 4 Then
                  cmbLinea.SelectedValue = x_cadena.Substring(0, 2)
                  cmbSubLinea.SelectedValue = x_cadena.Substring(0, 4)
               End If
            End If
         End If
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "No se puede cargar los controles iniciales", ex)
      End Try
   End Sub

   Private Sub Inicializar()
      Try
         managerArticulos = New BArticulos
         managerConsultaArticulos = New BConsultaArticulos(GApp.Periodo)
         formatearGrilla()
         cargarCombos()
         Me.KeyPreview = True

         Select Case m_opcion
            Case Origen.Cotizaciones

            Case Origen.Pedidos

            Case Else

         End Select
      Catch ex As Exception
         Throw ex
      End Try
   End Sub

   Public Function cargarCombos() As Boolean
      Try
         managerConsultaArticulos.cargarProductos()
         m_listLineas = New List(Of ELineas)(managerConsultaArticulos.ListLineas)
         bs_lineas = New BindingSource()
         bs_lineas.DataSource = m_listLineas
         m_listSubLineas = New List(Of ELineas)(managerConsultaArticulos.ListSubLineas)

         ACFramework.ACUtilitarios.ACCargaCombo(cmbLinea, bs_lineas, "LINEA_Nombre", "LINEA_Codigo")
         AddHandler bs_lineas.CurrentChanged, AddressOf bs_lineas_CurrentChanged
         bs_lineas_CurrentChanged(Nothing, Nothing)
      Catch ex As Exception
         Throw ex
      End Try
   End Function

#End Region

#Region " Metodos "

   Private Function setDatos() As Boolean
      Try
         If Not IsNothing(bs_productos) Then
            If CType(bs_productos.DataSource, List(Of EArticulos)).Count > 0 Then
               m_articulo = New EArticulos
               m_articulo = CType(bs_productos.Current, EArticulos)
               Return True
            Else
               ACControles.ACDialogos.ACMostrarMensajeInformacion(String.Format("Información: {0}", Me.Text), "No ha seleccionado ningun Item")
               Return False
            End If
         Else
            ACControles.ACDialogos.ACMostrarMensajeInformacion(String.Format("Información: {0}", Me.Text), "No ha seleccionado ningun Item")
            Return False
         End If
      Catch ex As Exception
         Throw ex
      End Try
   End Function

   Private Sub c1grdBusqueda_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c1grdBusqueda.DoubleClick
      Try
         If setDatos() Then
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
         Else
            Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
         End If
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso No se puede seleccionar el articulo", ex)
      End Try
   End Sub

#Region " Metodos Utilitarios "
   ''' <summary>
   ''' Dar Formato a la grilla de busqueda
   ''' </summary>
   ''' <remarks></remarks>
   Private Sub formatearGrilla()
      Dim _index As Integer = 1
      Try
         ACFrameworkC1.ACUtilitarios.ACFormatearGrilla(c1grdBusqueda, 1, 1, 5, 1, 0)
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, _index, "Codigo", "ARTIC_Codigo", "ARTIC_Codigo", 150, True, False, "System.String", "") : _index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, _index, "Nombre", "ARTIC_Descripcion", "ARTIC_Descripcion", 150, True, False, "System.String", "") : _index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, _index, "Peso", "ARTIC_Peso", "ARTIC_Peso", 100, False, False, "System.Decimal", Parametros.GetParametro(EParametros.TipoParametros.pg_FMondo2d)) : _index += 1
             'ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, _index, "Stock", "StockLocal", "StockLocal", 100, True, False, "System.Decimal", Parametros.GetParametro(EParametros.TipoParametros.pg_FMondo2d)) : _index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, _index, "Moneda", "TIPOS_TipoMoneda", "TIPOS_TipoMoneda", 150, False, False, "System.String") : _index += 1

         c1grdBusqueda.AllowEditing = False
         c1grdBusqueda.Styles.Alternate.BackColor = Color.LightGray
         c1grdBusqueda.Styles.Fixed.TextAlign = TextAlignEnum.CenterCenter
         c1grdBusqueda.Styles.Highlight.BackColor = Color.Gray
         c1grdBusqueda.SelectionMode = SelectionModeEnum.Row

         _index = 1

         'Precios
         ACFrameworkC1.ACUtilitarios.ACFormatearGrilla(c1grdUltimosPrecios, 1, 1, 6, 1)
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdUltimosPrecios, _index, "Documento", "Documento", "Documento", 80, True, False) : _index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdUltimosPrecios, _index, "Moneda", "TIPOS_TipoMoneda", "TIPOS_TipoMoneda", 150, True, False, "System.String") : _index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdUltimosPrecios, _index, "Precio", "DOCCD_PrecioUnitario", "DOCCD_PrecioUnitario", 100, True, False, "System.Decimal", Parametros.GetParametro(EParametros.TipoParametros.pg_FMondo2d)) : _index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdUltimosPrecios, _index, "Fecha", "DOCCO_FechaDocumento", "DOCCO_FechaDocumento", 80, True, False) : _index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdUltimosPrecios, _index, "Proveedor", "ENTID_RazonSocial", "ENTID_RazonSocial", 80, True, False) : _index += 1

         c1grdUltimosPrecios.Styles.Fixed.TextAlign = TextAlignEnum.CenterCenter
         c1grdUltimosPrecios.Styles.Fixed.Font = New Font(Font.FontFamily.Name, 10, FontStyle.Bold)
         c1grdUltimosPrecios.Rows(0).Height = 25

         _index = 1

         ACFrameworkC1.ACUtilitarios.ACFormatearGrilla(c1grdStock, 1, 1, 5, 1)
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdStock, _index, "Almacen", "ALMAC_Descripcion", "ALMAC_Descripcion", 100, True, False) : _index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdStock, _index, "Cod. Almacen", "ALMAC_Id", "ALMAC_Id", 0, False, False, "System.Integer") : _index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdStock, _index, "Stock", "STOCK_Cantidad", "STOCK_Cantidad", 100, True, False, "System.Decimal", Parametros.GetParametro(EParametros.TipoParametros.pg_FMondo2d)) : _index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdStock, _index, "Orden", "Orden", "Orden", 0, False, False, "System.Integer") : _index += 1

         c1grdStock.Styles.Fixed.TextAlign = TextAlignEnum.CenterCenter
         c1grdStock.Styles.Fixed.Font = New Font(Font.FontFamily.Name, 12, FontStyle.Bold)
         c1grdStock.Rows(0).Height = 30


      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Text), "No se puede dar formato a la grilla", ex)
      End Try
   End Sub
#End Region

   Private Sub bs_lineas_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
      Try
         Me.KeyPreview = True
         Dim _filter As New ACFiltrador(Of ELineas)() With {.ACFiltro = String.Format("LINEA_CodPadre={0}", cmbLinea.SelectedValue)}
         bs_sublineas = New BindingSource()
         bs_sublineas.DataSource = _filter.ACFiltrar(_filter.ACFiltrar(m_listSubLineas))
         ACFramework.ACUtilitarios.ACCargaCombo(cmbSubLinea, bs_sublineas, "LINEA_Nombre", "LINEA_Codigo")
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso Cargar Sub Lineas", ex)
      End Try
   End Sub

   Private Sub bs_productos_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
      Try
         If Not IsNothing(bs_productos) Then
            If CType(bs_productos.DataSource, List(Of EArticulos)).Count > 0 Then
               Dim x_artic_codigo As String = CType(bs_productos.Current, EArticulos).ARTIC_Codigo
               bs_precios = New BindingSource()
               bs_stocks = New BindingSource()
               If managerConsultaArticulos.CargarUltimos(3, x_artic_codigo) Then
                  bs_precios.DataSource = managerConsultaArticulos.DTConsultaArticulos
               Else
                  managerConsultaArticulos.DTConsultaArticulos = New DataTable()
                  bs_precios.DataSource = managerConsultaArticulos.DTConsultaArticulos
               End If
               If managerConsultaArticulos.cargarStocks(x_artic_codigo, GApp.Zona, GApp.Almacen) Then
                  bs_stocks.DataSource = managerConsultaArticulos.ListStock
                      '  CType(bs_productos.Current, EArticulos).ListLOG_Stocks = New List(Of ELOG_Stocks)(managerConsultaArticulos.ListStock)
                  CType(bs_productos.Current, EArticulos).StockLocal = managerConsultaArticulos.ListStock(0).STOCK_Cantidad
               Else
                  managerConsultaArticulos.ListStock = New List(Of ELOG_Stocks)()
                  bs_stocks.DataSource = managerConsultaArticulos.ListStock
                        ' CType(bs_productos.Current, EArticulos).StockLocal =CType(bs_stocks.Current, EArticulos).StockLocal
                         Dim _stocks As New ELOG_Stocks
                  _stocks.STOCK_Cantidad = 0
                  _stocks.Orden = 5
                  _stocks.ALMAC_Descripcion = GApp.Ealmacen.ALMAC_Descripcion
                  _stocks.ALMAC_Id = GApp.Almacen
                  managerConsultaArticulos.ListStock.Add(_stocks)
                  bs_stocks.DataSource = managerConsultaArticulos.ListStock
                  CType(bs_productos.Current, EArticulos).StockLocal = _stocks.STOCK_Cantidad

                        
               End If
               c1grdUltimosPrecios.DataSource = bs_precios
               CType(bs_productos.Current, EArticulos).ListPPrecios = New List(Of EPPrecios)()
               c1grdStock.DataSource = bs_stocks
               'CType(bs_productos.Current, EArticulos).ListLOG_Stocks = New List(Of ELOG_Stocks)(managerConsultaArticulos.ListStock)
               '' Resaltar el Almacen Local
               If managerConsultaArticulos.ListStock.Count > 1 Then
                  For index As Integer = 1 To c1grdStock.Rows.Count - 1
                     If c1grdStock.Rows(index)("ALMAC_Id") = GApp.EAlmacen.ALMAC_Id Then
                        c1grdStock.Rows(index)("Orden") = 0
                     Else
                        c1grdStock.Rows(index).StyleDisplay.Font = New Font(Font.FontFamily.Name, 8, FontStyle.Regular)
                        c1grdStock.Rows(index).Height = -1
                     End If
                  Next
                  c1grdStock.Rows(1).StyleNew.Font = New Font(Font.FontFamily.Name, 12, FontStyle.Bold)
                  c1grdStock.Rows(1).Height = 30
               End If
               c1grdStock.FinishEditing()
               Dim _list As New ACOrdenador(Of ELOG_Stocks)
               _list.ACOrdenamiento = "Orden ASC"
               managerConsultaArticulos.ListStock.Sort(_list)
               c1grdStock.Refresh()
               c1grdStock.AutoSizeCols()
               bs_stocks.ResetBindings(False)
            End If
         End If
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso Cambiar Registro", ex)
      End Try
   End Sub
#End Region

#Region " Metodos de Controles"

   Private Sub _KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
      If e.KeyCode = Keys.Enter Then
         If sender.Name = "txtBusqueda" Then
            Exit Sub
         End If
         SendKeys.Send("{TAB}")
      End If
   End Sub

   Private Sub txtBusqueda_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBusqueda.KeyDown
      Try
         Select Case e.KeyCode
            Case Keys.Down
               RemoveHandler Me.txtBusqueda.TextChanged, AddressOf txtBusqueda_TextChanged
               bs_productos.Position += 1
               AddHandler Me.txtBusqueda.TextChanged, AddressOf txtBusqueda_TextChanged
               e.Handled = True
               Exit Select
            Case Keys.Up
               RemoveHandler Me.txtBusqueda.TextChanged, AddressOf txtBusqueda_TextChanged
               bs_productos.Position -= 1
               AddHandler Me.txtBusqueda.TextChanged, AddressOf txtBusqueda_TextChanged
               e.Handled = True
               Exit Select
            Case Keys.PageDown
               RemoveHandler Me.txtBusqueda.TextChanged, AddressOf txtBusqueda_TextChanged
               bs_productos.Position += 10
               AddHandler Me.txtBusqueda.TextChanged, AddressOf txtBusqueda_TextChanged
               e.Handled = True
               e.Handled = True
               Exit Select
            Case Keys.PageUp
               RemoveHandler Me.txtBusqueda.TextChanged, AddressOf txtBusqueda_TextChanged
               bs_productos.Position -= 10
               AddHandler Me.txtBusqueda.TextChanged, AddressOf txtBusqueda_TextChanged
               e.Handled = True
               e.Handled = True
               Exit Select
            Case Keys.Enter
               If setDatos() Then
                  Me.DialogResult = System.Windows.Forms.DialogResult.OK
                  Me.Close()
               Else
                  Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
               End If
            Case Keys.Escape
               Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
               Me.Close()
               '   Exit Select
         End Select

      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "No puede completar el proceso ejecutado por el teclado", ex)
      End Try
   End Sub

   Private Sub txtBusqueda_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBusqueda.TextChanged
      Try
         If Not IsNothing(bs_productos) Then
            If managerArticulos.ListArticulos.Count > 0 Then
               Dim _filter As New ACFiltrador(Of EArticulos)() With {.ACFiltro = String.Format("ARTIC_Descripcion=%{0}%", txtBusqueda.Text)}
               bs_productos = New BindingSource()
               bs_productos.DataSource = _filter.ACFiltrar(managerArticulos.ListArticulos)
               c1grdBusqueda.DataSource = bs_productos
               bnavBusqueda.BindingSource = bs_productos
               AddHandler bs_productos.CurrentChanged, AddressOf bs_productos_CurrentChanged
               bs_productos_CurrentChanged(Nothing, Nothing)
               Me.KeyPreview = False
            End If
         End If
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso buscar articulo", ex)
      End Try
   End Sub

   Private Sub cmbSubLinea_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbSubLinea.KeyDown
      Try   
         Me.KeyPreview = True
         If e.KeyCode = Keys.Enter Then
            Dim _join As New List(Of ACJoin)
            '_join.Add(New ACJoin(ETipos.Esquema, ETipos.Tabla, ACJoin.TipoJoin.Inner _
            '                     , New ACCampos() {New ACCampos("TIPOS_Codigo", "TIPOS_CodTipoMoneda")} _
            '                     , New ACCampos() {New ACCampos("TIPOS_Descripcion", "TIPOS_TipoMoneda") _
            '                                       , New ACCampos("TIPOS_DescCorta", "TIPOS_TipoMonedaCorta")}))
             _join.Add(New ACJoin(ETipos.Esquema, ETipos.Tabla, ACJoin.TipoJoin.Inner _
                                 , New ACCampos() {New ACCampos("TIPOS_Codigo", "TIPOS_CodUnidadMedida")} _
                                 , New ACCampos() {New ACCampos("TIPOS_Descripcion", "TIPOS_CodUnidadMedida") _
                                                   , New ACCampos("TIPOS_DescCorta", "TIPOS_UnidadMedida")}))
                Dim _where As New Hashtable()


                _where.Add("LINEA_Codigo", New ACWhere(cmbSubLinea.SelectedValue, ACWhere.TipoWhere.Igual))
                _where.Add("ARTIC_Descontinuado", New ACWhere(0, ACWhere.TipoWhere.Igual))
                _where.Add("OrderBy", New ACWhere(New ACOrderBy() {New ACOrderBy("ARTIC_Orden", ACOrderBy.Ordenamiento.Ascendente)}))

                bs_productos = New BindingSource()
                If managerArticulos.CargarTodos(_join,_where) then
            'If managerArticulos.CargarTodos(_where) Then
               bs_productos.DataSource = managerArticulos.ListArticulos
               c1grdBusqueda.DataSource = bs_productos
               '' Crear  el metodo para cargar los precios
               AddHandler bs_productos.CurrentChanged, AddressOf bs_productos_CurrentChanged
               bs_productos_CurrentChanged(Nothing, Nothing)
               txtBusqueda.Enabled = True
            Else
               managerArticulos.ListArticulos = New List(Of EArticulos)
               bs_productos.DataSource = managerArticulos.ListArticulos
               c1grdBusqueda.DataSource = bs_productos
               cmbLinea.Focus()
               txtBusqueda.Enabled = False
               ACControles.ACDialogos.ACMostrarMensajeInformacion(String.Format("Información: {0}", Me.Text), "NO existen articulos en esta sub-linea, elija otra sub-line")
            End If
         End If
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso Cargar Sub Lineas", ex)
      End Try
   End Sub

#End Region

   'Private Sub c1grdBusqueda_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c1grdBusqueda.Enter
   '   Me.KeyPreview = False
   'End Sub
    Private Sub c1grdBusqueda_OwnerDrawCell(ByVal sender As System.Object, ByVal e As C1.Win.C1FlexGrid.OwnerDrawCellEventArgs) Handles c1grdBusqueda.OwnerDrawCell
      Try
         If e.Row < c1grdBusqueda.Rows.Fixed OrElse e.Col < c1grdBusqueda.Cols.Fixed Then Return
         If c1grdBusqueda.Cols(e.Col).Name = "StockLocal" Then
            If c1grdBusqueda.Rows(e.Row)("StockLocal") <= 0 Then
               e.Style = c1grdBusqueda.Styles("SinStock")
            End If
            'If c1grdBusqueda.Rows(e.Row)("StockLocal") > 0 Then
            '   e.Style = c1grdBusqueda.Styles("Stock")
            'End If
         End If
        
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso cambia de color", ex)
      End Try
   End Sub


   Private Sub c1grdBusqueda_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c1grdBusqueda.Enter


        Me.KeyPreview = False
    End Sub

   Private Sub c1grdBusqueda_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles c1grdBusqueda.KeyDown
      If e.KeyCode = Keys.Enter Then
         If setDatos() Then
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
         Else
            Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
         End If
      End If
   End Sub
End Class
