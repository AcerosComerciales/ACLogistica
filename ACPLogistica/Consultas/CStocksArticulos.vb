Imports ACBLogistica
Imports ACELogistica
Imports ACEVentas
Imports ACBVentas
Imports ACFramework
Imports ACFrameworkC1
Imports ACReporteador

Imports Microsoft.Practices.Unity
Imports Microsoft.Practices.Unity.Configuration
Imports C1.Win.C1FlexGrid
Imports C1.C1Preview
Imports System.Text.RegularExpressions

Public Class CStocksArticulos

#Region " Variables "
   Private managerConsultaArticulos As BConsultaArticulos
   Private managerGenerarReportes As BGenerarReportes

   Private m_listLineas As List(Of ELineas)
   Private m_listSubLineas As List(Of ELineas)

   Private m_reporte As DataTable

   Private bs_reporte As BindingSource
   Private bs_lineas As BindingSource
   Private bs_sublineas As BindingSource

   Private m_opcion As Reporte
   Private m_cadena As String

   Enum Reporte
      Linea = 1
      SubLinea = 2
      Todo = 3
   End Enum

#End Region

#Region " Propiedades "

#End Region

#Region " Constructores "
   Public Sub New()

      ' This call is required by the Windows Form Designer.
      InitializeComponent()

      ' Add any initialization after the InitializeComponent() call.
      Try
         managerConsultaArticulos = New BConsultaArticulos(GApp.Periodo)
         managerGenerarReportes = New BGenerarReportes

         cargarCombos()
         FormatearGrilla()
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "No se puede cargar los controles iniciales", ex)
      End Try
   End Sub
#End Region

#Region " Metodos "

   Private Sub UpdateTotals()
      Try
         c1grdBusqueda.Subtotal(AggregateEnum.Clear)
         Dim c As Integer = 2
         c1grdBusqueda.Subtotal(AggregateEnum.Sum, 2, 2, c, "{0}".ToUpper())
         c1grdBusqueda.Subtotal(AggregateEnum.Sum, 1, 1, c, "{0}".ToUpper())
         'c1grdBusqueda.Subtotal(AggregateEnum.Sum, 0, -1, c, "Grand Total")
         'c1grdBusqueda.AutoSizeCols()
         c1grdBusqueda.AutoSizeCols()
      Catch ex As Exception
         Throw ex
      End Try
   End Sub

#Region " Metodos Utilitarios "
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

   Private Sub FormatearGrilla()
      Dim _index As Integer = 1
      Try
         ACFrameworkC1.ACUtilitarios.ACFormatearGrilla(c1grdBusqueda, 1, 1, 9, 1, 1)
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, _index, "Linea", "Linea", "Linea", 150, False, False, "System.String", "") : _index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, _index, "SubLinea", "SubLinea", "SubLinea", 150, False, False, "System.String", "") : _index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, _index, "Orden", "Orden", "Orden", 40, True, False, "System.Integer", "") : _index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, _index, "Código", "Codigo", "Codigo", 70, True, False, "System.String", "") : _index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, _index, "Descripción", "Descripcion", "Descripcion", 500, True, False, "System.String", "") : _index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, _index, "Stock Almacen", "StockAlmacen", "StockAlmacen", 90, True, False, "System.Decimal", Parametros.GetParametro(EParametros.TipoParametros.pg_FMondo2d)) : _index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, _index, "Stock Orden Compra", "OrdenCompra", "OrdenCompra", 90, True, False, "System.Decimal", Parametros.GetParametro(EParametros.TipoParametros.pg_FMondo2d)) : _index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, _index, "Stock Transito", "Transito", "Transito", 90, True, False, "System.Decimal", Parametros.GetParametro(EParametros.TipoParametros.pg_FMondo2d)) : _index += 1

         c1grdBusqueda.AllowEditing = False
         c1grdBusqueda.AllowResizing = AllowResizingEnum.Columns
         c1grdBusqueda.Styles.Alternate.BackColor = Color.LightGray
         c1grdBusqueda.Styles.Fixed.TextAlign = TextAlignEnum.CenterCenter
         c1grdBusqueda.Styles.Highlight.BackColor = Color.Gray
         c1grdBusqueda.SelectionMode = SelectionModeEnum.Row
         c1grdBusqueda.SubtotalPosition = SubtotalPositionEnum.AboveData
         c1grdBusqueda.Tree.Column = 5
         c1grdBusqueda.AutoResize = True

         Dim s As CellStyle = c1grdBusqueda.Styles(CellStyleEnum.Subtotal0)
         s.BackColor = Color.Black
         s.ForeColor = Color.White
         s.Font = New Font(c1grdBusqueda.Font, FontStyle.Bold)

         s = c1grdBusqueda.Styles(CellStyleEnum.Subtotal1)
         s.BackColor = Color.DarkBlue
         s.ForeColor = Color.White
         s = c1grdBusqueda.Styles(CellStyleEnum.Subtotal2)
         s.BackColor = Color.DarkRed
         s.ForeColor = Color.White

         'more setup
         c1grdBusqueda.AllowDragging = AllowDraggingEnum.None
         c1grdBusqueda.AllowEditing = False
         c1grdBusqueda.Cols(0).WidthDisplay \= 3
      Catch ex As Exception
         Throw ex
      End Try
   End Sub

   Private Sub setReporte(ByVal x_opcion As Reporte)
      Select Case x_opcion
         Case Reporte.Linea
            m_opcion = Reporte.Linea
            m_cadena = cmbLinea.SelectedValue
            lblLinea.Enabled = True
            cmbLinea.Enabled = True
            lblSublinea.Enabled = False
            cmbSubLinea.Enabled = False
         Case Reporte.SubLinea
            m_opcion = Reporte.SubLinea
            m_cadena = cmbSubLinea.SelectedValue
            lblLinea.Enabled = True
            cmbLinea.Enabled = True
            lblSublinea.Enabled = True
            cmbSubLinea.Enabled = True
         Case Reporte.Todo
            m_cadena = ""
            m_opcion = Reporte.Todo
            lblLinea.Enabled = False
            cmbLinea.Enabled = False
            lblSublinea.Enabled = False
            cmbSubLinea.Enabled = False
         Case Else
            m_cadena = ""
            m_opcion = Reporte.Todo
            lblLinea.Enabled = False
            cmbLinea.Enabled = False
            lblSublinea.Enabled = False
            cmbSubLinea.Enabled = False
      End Select
   End Sub
#End Region

#Region " Cargar Datos "
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
#End Region
#End Region

#Region " Metodos de Controles"

   Private Sub rbtn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtnTodo.CheckedChanged, rbtnLinea.CheckedChanged, rbtnSubLinea.CheckedChanged
      If rbtnTodo.Checked Then setReporte(Reporte.Todo)
      If rbtnLinea.Checked Then setReporte(Reporte.Linea)
      If rbtnSubLinea.Checked Then setReporte(Reporte.SubLinea)
   End Sub

   Private Sub tsbtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnSalir.Click
      Me.Close()
   End Sub

   Private Sub btnCargar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCargar.Click
      m_reporte = New DataTable
      Try
         Select Case m_opcion
            Case Reporte.Linea
               m_cadena = cmbLinea.SelectedValue
            Case Reporte.SubLinea
               m_cadena = cmbSubLinea.SelectedValue
         End Select

         If managerGenerarReportes.StocksArticulos(m_cadena, CType(m_opcion, Integer), m_reporte) Then
            Dim _orden As Integer = 1
            Dim _linea As String = m_reporte.Rows(0)("SubLinea")
            For Each Item As DataRow In m_reporte.Rows
               Item("Codigo") = Regex.Replace(Item("Codigo"), "^(\d{2})(\d{2})(\d{3})$", "$1.$2.$3")
               If Not Item("SubLinea").Equals(_linea) Then
                  _linea = Item("SubLinea")
                  _orden = 1
               End If
               Item("Orden") = _orden
               _orden += 1
            Next
            bs_reporte = New BindingSource()
            bs_reporte.DataSource = m_reporte
            c1grdBusqueda.DataSource = bs_reporte
            bnavNavievador.BindingSource = bs_reporte
            chkFiltroCols.Checked = False
            UpdateTotals()
         End If
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso cargar datos del Reporte", ex)
      End Try
   End Sub

   Private Sub tsbtnprevisualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnprevisualizar.Click
      Try
         Utilitarios.reportToScreen(c1grdBusqueda, "Compras por Proveedor", "Reporte", "", DateTime.Now, New Printing.PaperSize("A4", 827, 1169), New Printing.Margins(40, 40, 120, 40), , , True, False, , , , , Utilitarios.Sizepage.FitTopageWidth)
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso Previsualizar", ex)
      End Try
   End Sub

#End Region

End Class