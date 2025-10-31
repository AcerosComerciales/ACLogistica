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

Public Class CComprasXProveedor
#Region " Variables "
   Private managerGenerarReportes As BGenerarReportes
   Private managerEntidades As BEntidades

   Private bs_reporte As BindingSource

   Private m_reporte As DataTable
   Private _subtitulo2 As String
   Private _subtitulo1 As String
#End Region

#Region " Propiedades "

#End Region

#Region " Constructores "
   Public Sub New()
      ' This call is required by the Windows Form Designer.
      InitializeComponent()
      Try
         managerGenerarReportes = New BGenerarReportes
         managerEntidades = New BEntidades

         formatearGrilla()
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError("Error: " & Convert.ToString(Me.Text), "No se puede cargar los controles iniciales", ex)
      End Try
   End Sub
#End Region

#Region " Metodos "

   Private Sub AyudaEntidad(ByVal x_cadenas As String, ByVal x_campo As String, ByVal x_opcion As EEntidades.TipoEntidad)
      Try
         Me.KeyPreview = False
         Dim _where As New Hashtable
         _where.Add(x_campo, New ACWhere(x_cadenas, ACWhere.TipoWhere._Like))
         managerEntidades.Ayuda(_where, x_opcion)
         Dim Ayuda As New ACControlesC1.ACAyudaFlex("Buscar Entidad", managerEntidades.DTEntidades, False)
         If Ayuda.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Select Case x_opcion
               Case EEntidades.TipoEntidad.Proveedores
                  '' Cargar datos del cliente                 
                  actxaProvCodigo.Text = Ayuda.Respuesta.Rows(0)("Codigo")
                  actxaProvRazonSocial.Text = Ayuda.Respuesta.Rows(0)("Razon Social")
                  '' Cargar datos adicionales del proveedor
                  setRol(Constantes.Seteo.Desactivar)
                  btnCargar.Focus()
                  Me.KeyPreview = True
            End Select
         End If
      Catch ex As Exception
         Throw ex
      End Try
   End Sub

   Private Sub setRol(ByVal x_opcion As Constantes.Seteo)
      Try
         actxaProvCodigo.ReadOnly = IIf(x_opcion = Constantes.Seteo.Activar, False, True)
         actxaProvCodigo.ACActivarAyuda = IIf(x_opcion = Constantes.Seteo.Activar, True, False)
         actxaProvCodigo.ACAyuda.Enabled = IIf(x_opcion = Constantes.Seteo.Activar, True, False)
         actxaProvRazonSocial.ReadOnly = IIf(x_opcion = Constantes.Seteo.Activar, False, True)
         actxaProvRazonSocial.ACActivarAyuda = IIf(x_opcion = Constantes.Seteo.Activar, True, False)
         actxaProvRazonSocial.ACAyuda.Enabled = IIf(x_opcion = Constantes.Seteo.Activar, True, False)
      Catch ex As Exception
         Throw ex
      End Try
   End Sub

   Private Sub UpdateTotals()
      Try
         c1grdBusqueda.Subtotal(AggregateEnum.Clear)
         Dim c As Integer
         For c = 5 To c1grdBusqueda.Cols.Count - 1
            c1grdBusqueda.Subtotal(AggregateEnum.Sum, 0, -1, c, "Total : ")
         Next
         c1grdBusqueda.AutoSizeCols()
      Catch ex As Exception
         Throw ex
      End Try
   End Sub
   Private Sub formatearGrilla()
      Dim index As Integer = 1
      Try
         ACFrameworkC1.ACUtilitarios.ACFormatearGrilla(c1grdBusqueda, 2, 2, 11, 1, 0)
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "ARTIC_Codigo", "ARTIC_Codigo", "ARTIC_Codigo", 150, False, False, "System.String") : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Fecha", "DOCCO_FechaDocumento", "DOCCO_FechaDocumento", 150, True, False, "System.DateTime") : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Documento", "Documento", "Documento", 150, True, False, "System.String") : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Articulo", "ARTIC_Descripcion", "ARTIC_Descripcion", 150, True, False, "System.String") : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Unidad", "TIPOS_UnidadMedida", "TIPOS_UnidadMedida", 150, True, False, "System.String") : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Peso (Kg)", "INGCD_PesoUnitario", "INGCD_PesoUnitario", 150, True, False, "System.Decimal", Parametros.GetParametro(EParametros.TipoParametros.pg_FMondo4d)) : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Pendiente", "Pendiente", "Pendiente", 150, True, False, "System.Decimal", Parametros.GetParametro(EParametros.TipoParametros.pg_FMondo2d)) : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Ingresado", "Ingresado", "Ingresado", 150, True, False, "System.Decimal", Parametros.GetParametro(EParametros.TipoParametros.pg_FMondo2d)) : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Transito", "Transito", "Transito", 150, True, False, "System.Decimal", Parametros.GetParametro(EParametros.TipoParametros.pg_FMondo2d)) : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Total", "INGCD_CantidadTotal", "INGCD_CantidadTotal", 150, True, False, "System.Decimal", Parametros.GetParametro(EParametros.TipoParametros.pg_FMondo2d)) : index += 1

         c1grdBusqueda.AllowEditing = False
         c1grdBusqueda.AllowSorting = AllowSortingEnum.SingleColumn
         c1grdBusqueda.Styles.Alternate.BackColor = Color.LightGray
         c1grdBusqueda.Styles.Fixed.TextAlign = TextAlignEnum.CenterCenter
         c1grdBusqueda.Styles.Highlight.BackColor = Color.Gray
         c1grdBusqueda.SelectionMode = SelectionModeEnum.Row
         c1grdBusqueda.SubtotalPosition = SubtotalPositionEnum.AboveData

         Dim u As C1.Win.C1FlexGrid.CellStyle = c1grdBusqueda.Styles.Add("Facturar")
         u.BackColor = Color.Green
         u.ForeColor = Color.White
         u.Font = New Font(c1grdBusqueda.Font, FontStyle.Regular)

         c1grdBusqueda.AutoSizeCols()
         c1grdBusqueda.Tree.Column = 2

         c1grdBusqueda.Rows(0).AllowMerging = True
         c1grdBusqueda.Rows(1).AllowMerging = True

         c1grdBusqueda.Rows(1)(9) = c1grdBusqueda.Rows(0)(9)
         c1grdBusqueda.Rows(1)(8) = c1grdBusqueda.Rows(0)(8)
         Dim rg As CellRange = c1grdBusqueda.GetCellRange(0, 8, 0, 9)
         rg.Data = "Recibido"
         c1grdBusqueda.MergedRanges.Add(rg)

         For i As Integer = 0 To 7
            rg = c1grdBusqueda.GetCellRange(0, i, 1, i)
            c1grdBusqueda.MergedRanges.Add(rg)
         Next
         rg = c1grdBusqueda.GetCellRange(0, 10, 1, 10)
         c1grdBusqueda.MergedRanges.Add(rg)

      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Text), "No se puede dar formato a la grilla", ex)
      End Try
   End Sub
#End Region

#Region " Metodos de Controles"

   Private Sub tsbtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnSalir.Click
      Me.Close()
   End Sub

   Private Sub btnCargar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCargar.Click
      Try
         bs_reporte = New BindingSource()
         Dim x_entid_codigo As String = actxaProvCodigo.Text
         If Not managerGenerarReportes.PendientesXProveedor(x_entid_codigo, AcFecha.ACDtpFecha_De.Value.Date, AcFecha.ACDtpFecha_A.Value.Date.AddDays(1), m_reporte) Then
            m_reporte = New DataTable
         End If
         bs_reporte.DataSource = m_reporte
         c1grdBusqueda.DataSource = bs_reporte
         bnavNavievador.BindingSource = bs_reporte
         chkFiltroCols.Checked = False
         _subtitulo1 = String.Format("Proveedor : {0}", actxaProvRazonSocial.Text)
         _subtitulo2 = String.Format("Fechas : desde {0} hasta {1}", AcFecha.ACDtpFecha_De.Value.Date.ToString("dd/MM/yyyy"), AcFecha.ACDtpFecha_A.Value.Date.ToString("dd/MM/yyyy"))
         UpdateTotals()
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso cargar Reporte", ex)
      End Try
   End Sub

   Private Sub btnClean_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClean.Click
      Try
         actxaProvCodigo.Clear()
         actxaProvRazonSocial.Clear()
         setRol(Constantes.Seteo.Activar)
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso Limpiar Entidad", ex)
      End Try
   End Sub

   Private Sub tsbtnprevisualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnprevisualizar.Click
      Try
         Utilitarios.reportToScreen(c1grdBusqueda, "Consulta de Pendientes por Proveedor", "Reporte", "", DateTime.Now, New Printing.PaperSize("A4", 827, 1169), New Printing.Margins(40, 40, 120, 40), _subtitulo1, _subtitulo2, True, True, , , , , Utilitarios.Sizepage.FitTopageWidth)
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso Previsualizar", ex)
      End Try
   End Sub

#Region " Ayudas "

   Private Sub actxaProvRazonSocial_ACAyudaClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles actxaProvRazonSocial.ACAyudaClick
      Try
         AyudaEntidad(actxaProvRazonSocial.Text, "ENTID_RazonSocial", EEntidades.TipoEntidad.Proveedores)
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso busqueda de cliente por Nombre/Razon Social", ex)
      End Try
   End Sub

   Private Sub actxaProvCodigo_ACAyudaClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles actxaProvCodigo.ACAyudaClick
      Try
         AyudaEntidad(actxaProvCodigo.Text, "ENTID_Codigo", EEntidades.TipoEntidad.Proveedores)
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso busqueda de cliente por codigo", ex)
      End Try
   End Sub
#End Region

#End Region

   Private Sub chkAgrupar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAgrupar.CheckedChanged
      Try
         If chkAgrupar.Checked Then
            m_reporte.DefaultView.Sort = "ARTIC_Codigo"
            bs_reporte.ResetBindings(False)
            c1grdBusqueda.Subtotal(AggregateEnum.Count, 1, 1, 1, "Agrupado por: {0}")
         Else
            c1grdBusqueda.Subtotal(AggregateEnum.Clear)
         End If
         c1grdBusqueda.AutoSizeCols()
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Convert.ToString(Text)), "No se agrupar resultados", ex)
      End Try
   End Sub

   Private Sub c1grdBusqueda_OwnerDrawCell(ByVal sender As System.Object, ByVal e As C1.Win.C1FlexGrid.OwnerDrawCellEventArgs) Handles c1grdBusqueda.OwnerDrawCell
      Try
         If e.Row < c1grdBusqueda.Rows.Fixed OrElse e.Col < c1grdBusqueda.Cols.Fixed Then Return
         If c1grdBusqueda.Cols(e.Col).Name = "Pendiente" Then
            If c1grdBusqueda(e.Row, "Pendiente") > 0 Then
               e.Style = c1grdBusqueda.Styles("Facturar")
            End If
         End If
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso cambia de color", ex)
      End Try
   End Sub
End Class