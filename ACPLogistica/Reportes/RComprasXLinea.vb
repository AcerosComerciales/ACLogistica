Imports System.Diagnostics.Eventing.Reader
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

Public Class RComprasXLinea

#Region " Variables "
   Private managerConsultaArticulos As BConsultaArticulos
   Private managerGenerarReportes As BGenerarReportes

   Private m_listLineas As List(Of ELineas)

   Private m_reporte As DataSet
   Private _subtitulo2 As String
   Private _subtitulo1 As String

   Private bs_reporte As BindingSource
   Private bs_lineas As BindingSource
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
#Region " Metodos Utilitarios "
   Public Function cargarCombos() As Boolean
      Try
         managerConsultaArticulos.cargarProductos()
         m_listLineas = New List(Of ELineas)(managerConsultaArticulos.ListLineas)
         bs_lineas = New BindingSource()
         bs_lineas.DataSource = m_listLineas

         ACFramework.ACUtilitarios.ACCargaCombo(cmbLinea, bs_lineas, "LINEA_Nombre", "LINEA_Codigo")
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
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, _index, "Código", "Codigo", "Codigo", 70, False, False, "System.String", "") : _index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, _index, "Descripción", "Descripcion", "Descripcion", 380, True, False, "System.String", "") : _index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, _index, "Peso", "Peso", "Peso", 90, True, False, "System.Decimal", Parametros.GetParametro(EParametros.TipoParametros.pg_FMondo2d)) : _index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, _index, "Cantidad", "Cantidad", "Cantidad", 90, True, False, "System.Decimal", Parametros.GetParametro(EParametros.TipoParametros.pg_FMondo2d)) : _index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, _index, "Dolares US$", "Dolares", "Dolares", 90, True, False, "System.Decimal", Parametros.GetParametro(EParametros.TipoParametros.pg_FMondo2d)) : _index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, _index, "Soles S/.", "Soles", "Soles", 90, True, False, "System.Decimal", Parametros.GetParametro(EParametros.TipoParametros.pg_FMondo2d)) : _index += 1

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

#End Region

#End Region

#Region " Metodos de Controles"

#End Region

   Private Sub btnCargar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCargar.Click
      m_reporte = New DataSet
      Try
         bs_reporte = New BindingSource()
            Dim _destino As Short
          Select Case   GApp.Empresa 
              Case "PROMA"
                Select Case GApp.Almacen
                    Case 5
                        _destino=2
                        Case 6
                            _destino=3
                            Case 1
                                _destino=4
                               case else
                                   _destino=1
                End Select
            Case Else
                Select Case GApp.Almacen
                    Case 5
                        _destino=2
                        Case 6
                            _destino=3
                            Case 11
                                _destino=4
                                Case else
                                    _destino=1
                End Select
          End Select


         If Not managerGenerarReportes.ComprasXLinea(cmbLinea.SelectedValue, AcFecha.ACDtpFecha_De.Value.Date, AcFecha.ACDtpFecha_A.Value.Date.AddDays(1), m_reporte ,_destino) Then
            m_reporte = New DataSet
         End If
          bs_reporte.DataSource = m_reporte.Tables(0)
          c1grdBusqueda.DataSource = bs_reporte
         'bs_reporte.DataSource = m_reporte
         'c1grdBusqueda.DataSource = bs_reporte
         bnavNavegador.BindingSource = bs_reporte
         chkFiltroCols.Checked = False
         _subtitulo1 = cmbLinea.Text
         _subtitulo2 = String.Format("Fechas : desde {0} hasta {1}", AcFecha.ACDtpFecha_De.Value.Date.ToString("dd/MM/yyyy"), AcFecha.ACDtpFecha_A.Value.Date.ToString("dd/MM/yyyy"))
         UpdateTotals()
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso cargar datos del Reporte", ex)
      End Try
   End Sub

   Private Sub UpdateTotals()
      Try
         c1grdBusqueda.Subtotal(AggregateEnum.Clear)
         Dim c As Integer
         For c = 5 To c1grdBusqueda.Cols.Count - 1
            c1grdBusqueda.Subtotal(AggregateEnum.Sum, 2, 2, c, "{0} - Total :")
         Next
         c1grdBusqueda.Subtotal(AggregateEnum.Sum, 1, 1, 5, "{0} - Total :")
         'c1grdBusqueda.Subtotal(AggregateEnum.Sum, 0, -1, c, "Grand Total")
         'c1grdBusqueda.AutoSizeCols()
      Catch ex As Exception
         Throw ex
      End Try
   End Sub

   Private Sub tsbtnprevisualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnprevisualizar.Click
      Try
         Utilitarios.reportToScreen(c1grdBusqueda, "Compras por Linea", "Reporte", "", DateTime.Now, New Printing.PaperSize("A4", 827, 1169), New Printing.Margins(40, 40, 120, 40), _subtitulo1, _subtitulo2, True, False)
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso Previsualizar", ex)
      End Try
   End Sub

    Private Sub tsbtnExcel_Click(sender As Object, e As EventArgs) Handles tsbtnExcel.Click
        Try
            Utilitarios.ExportarXLS(c1grdBusqueda, "Compras X linea")
        Catch ex As Exception
            ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso Exportar a Excel", ex)
        End Try
    End Sub
End Class