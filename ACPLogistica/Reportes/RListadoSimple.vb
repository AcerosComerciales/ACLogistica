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

Public Class RListadoSimple

#Region " Variables "
   Private managerGenerarReportes As BGenerarReportes
   Private managerConsultaArticulos As BConsultaArticulos

   Private m_reporte As DataTable

   Private bs_reporte As BindingSource
   Private bs_lineas As BindingSource
   Private bs_sublineas As BindingSource

   Private m_listLineas As List(Of ELineas)
   Private m_listSubLineas As List(Of ELineas)

   Private _subtitulo1 As String
   Private _subtitulo2 As String
#End Region

#Region " Propiedades "

#End Region

#Region " Constructores "
   Public Sub New()
      ' This call is required by the Windows Form Designer.
      InitializeComponent()
      Try
         managerGenerarReportes = New BGenerarReportes
         managerConsultaArticulos = New BConsultaArticulos(GApp.Periodo)

         FormatearGrilla()
         cargarCombos()
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError("Error: " & Convert.ToString(Me.Text), "No se puede cargar los controles iniciales", ex)
      End Try
   End Sub
#End Region

#Region " Metodos "
#Region " Utilitarios "
   Private Sub FormatearGrilla()
      Dim _index As Integer = 1
      Try
         ACFrameworkC1.ACUtilitarios.ACFormatearGrilla(c1grdBusqueda, 1, 1, 11, 1, 1)
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, _index, "Linea", "Linea", "Linea", 150, False, False, "System.String", "") : _index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, _index, "SubLinea", "SubLinea", "SubLinea", 150, False, False, "System.String", "") : _index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, _index, "Codigo", "Codigo", "Codigo", 90, True, False, "System.String", "") : _index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, _index, "Descripción", "Descripción", "Descripción", 300, True, False, "System.String", "") : _index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, _index, "Tipo Producto", "Tipo Producto", "Tipo Producto", 90, True, False, "System.String", "") : _index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, _index, "Categoría", "Categoría", "Categoría", 90, True, False, "System.String", "") : _index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, _index, "Unidad Medida", "Unidad", "Unidad", 130, True, False, "System.String", "") : _index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, _index, "Color", "Color", "Color", 90, True, False, "System.String", "") : _index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, _index, "Peso", "Peso", "Peso", 90, True, False, "System.String", "") : _index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, _index, "Moneda", "MonedaDesc", "MonedaDesc", 130, True, False, "System.String", "") : _index += 1

         c1grdBusqueda.AllowEditing = False
         c1grdBusqueda.AllowResizing = AllowResizingEnum.None
         c1grdBusqueda.Styles.Alternate.BackColor = Color.LightGray
         c1grdBusqueda.Styles.Fixed.TextAlign = TextAlignEnum.CenterCenter
         c1grdBusqueda.Styles.Highlight.BackColor = Color.Gray
         c1grdBusqueda.SelectionMode = SelectionModeEnum.Row
         c1grdBusqueda.SubtotalPosition = SubtotalPositionEnum.AboveData
         c1grdBusqueda.Tree.Column = 4
         c1grdBusqueda.AutoResize = False

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

   Private Function cargarCombos() As Boolean
      Try
         managerConsultaArticulos.cargarProductos()
         Dim _lin As New ELineas
         _lin.LINEA_Codigo = "0000"
         _lin.LINEA_Nombre = "<< Todos >>"
         managerConsultaArticulos.ListLineas.Insert(0, _lin)
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

   Private Sub bs_lineas_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
      Try
         Me.KeyPreview = True
         If cmbLinea.SelectedValue.ToString().Equals("0000") Then
            cmbSubLinea.Enabled = False
            bs_sublineas = New BindingSource()
            'ACFramework.ACUtilitarios.ACCargaCombo(cmbSubLinea, bs_sublineas, "LINEA_Nombre", "LINEA_Codigo")
         Else
            cmbSubLinea.Enabled = True
            Dim _filter As New ACFiltrador(Of ELineas)() With {.ACFiltro = String.Format("LINEA_CodPadre={0}", cmbLinea.SelectedValue)}
            bs_sublineas = New BindingSource()
            bs_sublineas.DataSource = _filter.ACFiltrar(_filter.ACFiltrar(m_listSubLineas))
            ACFramework.ACUtilitarios.ACCargaCombo(cmbSubLinea, bs_sublineas, "LINEA_Nombre", "LINEA_Codigo")
         End If
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso Cargar Sub Lineas", ex)
      End Try
   End Sub
#End Region
#End Region

#Region " Metodos de Controles"

#End Region

   Private Sub btnCargar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCargar.Click
      m_reporte = New DataTable
      Try
         Dim _cadena As String = ""
         If Not IsNothing(cmbSubLinea.SelectedValue) Then
            If cmbSubLinea.Enabled Then
               _cadena = cmbSubLinea.SelectedValue
               _subtitulo1 = String.Format("Linea : {0}", cmbLinea.Text)
               _subtitulo2 = String.Format("Sub - Linea : {0}", cmbSubLinea.Text)
            Else
               _cadena = ""
               _subtitulo1 = String.Format("Linea : {0}", cmbLinea.Text)
               _subtitulo2 = ""
            End If
         End If
         bs_reporte = New BindingSource()
         If Not managerGenerarReportes.GetArticulos("LINEA_Codigo", _cadena, m_reporte) Then
            m_reporte = New DataTable
         End If
         bs_reporte.DataSource = m_reporte
         c1grdBusqueda.DataSource = bs_reporte
         bnavNavievador.BindingSource = bs_reporte

         UpdateTotals()
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso cargar datos del Reporte", ex)
      End Try
   End Sub

   Private Sub tsbtnprevisualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnprevisualizar.Click
      Try
         Utilitarios.reportToScreen(c1grdBusqueda, "Reporte: Listado Simple de Articulos Por Linea, Sublinea", "Reporte", "", DateTime.Now, New Printing.PaperSize("A4", 827, 1169), New Printing.Margins(40, 40, 120, 40), _subtitulo1, _subtitulo2, True, False, , , , , Utilitarios.Sizepage.FitTopageWidth)
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso Previsualizar", ex)
      End Try
   End Sub

   Private Sub UpdateTotals()
      Try
         c1grdBusqueda.Subtotal(AggregateEnum.Clear)
         Dim c As Integer = 2
         c1grdBusqueda.Subtotal(AggregateEnum.Sum, 2, 2, c, "{0}")
         c1grdBusqueda.Subtotal(AggregateEnum.Sum, 1, 1, c, "{0}")
         'c1grdBusqueda.Subtotal(AggregateEnum.Sum, 0, -1, c, "Grand Total")
         'c1grdBusqueda.AutoSizeCols()
      Catch ex As Exception
         Throw ex
      End Try
   End Sub
End Class