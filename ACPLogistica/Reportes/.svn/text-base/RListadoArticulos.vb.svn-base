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

Public Class RListadoArticulos

#Region " Variables "
   Private managerGenerarReportes As BGenerarReportes
   Private managerConsultaArticulos As BConsultaArticulos

   Private m_reporte As DataTable

   Private bs_reporte As BindingSource
   Private bs_lineas As BindingSource
   Private bs_sublineas As BindingSource

   Private m_listLineas As List(Of ELineas)
   Private m_listSubLineas As List(Of ELineas)
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
         ACFrameworkC1.ACUtilitarios.ACFormatearGrilla(C1FlexGroup.Grid, 1, 1, 11, 1, 1)
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(C1FlexGroup.Grid, _index, "Linea", "Linea", "Linea", 150, True, False, "System.String", "") : _index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(C1FlexGroup.Grid, _index, "SubLinea", "SubLinea", "SubLinea", 150, True, False, "System.String", "") : _index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(C1FlexGroup.Grid, _index, "Codigo", "Codigo", "Codigo", 150, True, False, "System.String", "") : _index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(C1FlexGroup.Grid, _index, "Descripción", "Descripción", "Descripción", 150, True, False, "System.String", "") : _index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(C1FlexGroup.Grid, _index, "Tipo Producto", "Tipo Producto", "Tipo Producto", 150, True, False, "System.String", "") : _index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(C1FlexGroup.Grid, _index, "Categoría", "Categoría", "Categoría", 150, True, False, "System.String", "") : _index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(C1FlexGroup.Grid, _index, "Unidad Medida", "Unidad Medida", "Unidad Medida", 150, True, False, "System.String", "") : _index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(C1FlexGroup.Grid, _index, "Color", "Color", "Color", 150, True, False, "System.String", "") : _index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(C1FlexGroup.Grid, _index, "Peso", "Peso", "Peso", 150, True, False, "System.String", "") : _index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(C1FlexGroup.Grid, _index, "Moneda", "Moneda", "Moneda", 150, True, False, "System.String", "") : _index += 1
         C1FlexGroup.Grid.AllowEditing = False
         C1FlexGroup.Grid.Styles.Alternate.BackColor = Color.LightGray
         C1FlexGroup.Grid.Styles.Fixed.TextAlign = TextAlignEnum.CenterCenter
         C1FlexGroup.Grid.Styles.Highlight.BackColor = Color.Gray
         C1FlexGroup.Grid.SelectionMode = SelectionModeEnum.Row
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

   Private Sub chkAgruparCols_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAgruparCols.CheckedChanged
      C1FlexGroup.ShowGroups = chkAgruparCols.Checked
   End Sub

   Private Sub chkReorganizarCols_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkReorganizarCols.CheckedChanged
      If chkReorganizarCols.Checked Then
         C1FlexGroup.Grid.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.Columns
      Else
         C1FlexGroup.Grid.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None
      End If
   End Sub

   Private Sub chkOrdenarCols_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkOrdenarCols.CheckedChanged
      If chkOrdenarCols.Checked Then
         C1FlexGroup.Grid.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.SingleColumn
      Else
         C1FlexGroup.Grid.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None
      End If
   End Sub

   Private Sub chkFiltroCols_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFiltroCols.CheckedChanged
      C1FlexGroup.FilterRow = chkFiltroCols.Checked
   End Sub
#End Region

   Private Sub btnCargar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCargar.Click
      m_reporte = New DataTable
      Try
         Dim _cadena As String = ""
         If Not IsNothing(cmbSubLinea.SelectedValue) Then
            If cmbSubLinea.Enabled Then
               _cadena = cmbSubLinea.SelectedValue
            Else
               _cadena = ""
            End If
         End If

         If managerGenerarReportes.GetArticulos("LINEA_Codigo", _cadena, m_reporte) Then
            C1FlexGroup.Grid.DataSource = m_reporte
            bs_reporte = New BindingSource()
            bs_reporte.DataSource = m_reporte
            C1FlexGroup.FilterRow = False
            chkFiltroCols.Checked = False
         End If
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso cargar datos del Reporte", ex)
      End Try
   End Sub

   Private Sub tsbtnprevisualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnprevisualizar.Click
      Try
         Utilitarios.reportToScreen(C1FlexGroup.Grid, "Reporte", "Reporte", "", DateTime.Now, New Printing.PaperSize("A4", 827, 1169), New Printing.Margins(40, 40, 120, 40), , , True, False)

         'Dim m_listFlex As New ACListaFlex()
         'm_listFlex.Add(C1FlexGroup.Grid)
         'Dim _sub() As ACTexto = {New ACTexto(String.Format("Reporte: {0}", "--"), New Font(Me.Font.FontFamily, 8, FontStyle.Regular))}
         'Dim x As New ACPreview(m_listFlex, New ACCabecera(New ACTexto("Reporte de Articulos", New Font(Me.Font.FontFamily, 14, FontStyle.Bold)), GApp.ESucursal.SUCUR_Nombre, "", _sub, New Font(Me.Font.FontFamily, 8, FontStyle.Bold)))
         'x.setCabecera(New ACTexto() {New ACTexto("Listado Simple", New Font(Me.Font.FontFamily, 12, FontStyle.Regular))})
         'x.setMargen(20.0, 3.0, 8.0, 20.0, UnitTypeEnum.Mm)
         'x.setEstilo(ACEEstilo.classicc, True)
         'x.setEstiloLinea(New LineDef("2pt", Color.Black))
         'x.setFuente(New Font("Courier New", 7.5, FontStyle.Regular))

         'x.ACTextoLista = New ACTextoLista()
         'x.ACTextoLista.Add(New ACTexto(String.Format("{0}Historial{0}", vbNewLine), New Font(Me.Font.FontFamily, 8, FontStyle.Bold)))

         ' ''
         'x.ACColumnasLista = New ACColumnaAlineacionLista()
         'x.ACColumnasLista.Add(New ACColumnaAlineacion(New Unit() {New C1.C1Preview.Unit(0, UnitTypeEnum.Mm) _
         '                                                        , New C1.C1Preview.Unit(35, UnitTypeEnum.Mm) _
         '                                                        , New C1.C1Preview.Unit(30, UnitTypeEnum.Mm) _
         '                                                        , New C1.C1Preview.Unit(18, UnitTypeEnum.Mm) _
         '                                                        , New C1.C1Preview.Unit(100, UnitTypeEnum.Mm) _
         '                                                        , New C1.C1Preview.Unit(20, UnitTypeEnum.Mm) _
         '                                                        , New C1.C1Preview.Unit(30, UnitTypeEnum.Mm) _
         '                                                        , New C1.C1Preview.Unit(18, UnitTypeEnum.Mm) _
         '                                                        , New C1.C1Preview.Unit(0, UnitTypeEnum.Mm) _
         '                                                        , New C1.C1Preview.Unit(18, UnitTypeEnum.Mm) _
         '                                                        , New C1.C1Preview.Unit(0, UnitTypeEnum.Mm)}))
         'x.setEstiloLinea(New LineDef(New Unit(0.5, UnitTypeEnum.Mm), Color.Black))

         'x.ACEjecutar()
         'x.ShowDialog()
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso Previsualizar", ex)
      End Try
   End Sub
End Class