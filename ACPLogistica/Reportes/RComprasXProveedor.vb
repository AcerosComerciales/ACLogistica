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

Public Class RComprasXProveedor
#Region " Variables "
   Private managerGenerarReportes As BGenerarReportes
   Private managerEntidades As BEntidades

   Private bs_reporte As BindingSource
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
                  actxaEntCodigo.Text = Ayuda.Respuesta.Rows(0)("Codigo")
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
         actxaEntCodigo.ReadOnly = IIf(x_opcion = Constantes.Seteo.Activar, False, True)
         actxaEntCodigo.ACActivarAyuda = IIf(x_opcion = Constantes.Seteo.Activar, True, False)
         actxaEntCodigo.ACAyuda.Enabled = IIf(x_opcion = Constantes.Seteo.Activar, True, False)
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
         ACFrameworkC1.ACUtilitarios.ACFormatearGrilla(c1grdBusqueda, 1, 1, 8, 1, 0)
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Fecha", "DOCCO_FechaDocumento", "DOCCO_FechaDocumento", 150, True, False, "System.DateTime") : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Moneda", "TIPOS_TipoMoneda", "TIPOS_TipoMoneda", 150, True, False, "System.String") : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Documento", "Documento", "Documento", 150, True, False, "System.String") : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Proveedor", "ENTID_Proveedor", "ENTID_Proveedor", 150, True, False, "System.String") : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Peso (Kg)", "DOCCO_TotalPeso", "DOCCO_TotalPeso", 150, True, False, "System.Decimal", Parametros.GetParametro(EParametros.TipoParametros.pg_FMondo4d)) : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "C. Soles", "TotalCompraSoles", "TotalCompraSoles", 150, True, False, "System.Decimal", Parametros.GetParametro(EParametros.TipoParametros.pg_FMondo2d)) : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "C. Dolares", "TotalCompraDolares", "TotalCompraDolares", 150, True, False, "System.Decimal", Parametros.GetParametro(EParametros.TipoParametros.pg_FMondo2d)) : index += 1

         c1grdBusqueda.AllowEditing = False
         c1grdBusqueda.AllowSorting = AllowSortingEnum.SingleColumn
         c1grdBusqueda.Styles.Alternate.BackColor = Color.LightGray
         c1grdBusqueda.Styles.Fixed.TextAlign = TextAlignEnum.CenterCenter
         c1grdBusqueda.Styles.Highlight.BackColor = Color.Gray
         c1grdBusqueda.SelectionMode = SelectionModeEnum.Row

         c1grdBusqueda.AutoSizeCols()
         c1grdBusqueda.Tree.Column = 1
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
         Dim x_entid_codigo As String = actxaEntCodigo.Text
         If managerGenerarReportes.comprasXproveedor(x_entid_codigo, AcFecha.ACDtpFecha_De.Value.Date, AcFecha.ACDtpFecha_A.Value.Date.AddDays(1)) Then
            For Each Item As EABAS_DocsCompra In managerGenerarReportes.ListEABAS_DocsCompra
               Item.ENTID_Proveedor = actxaProvRazonSocial.Text
            Next
            bs_reporte = New BindingSource
            bs_reporte.DataSource = managerGenerarReportes.ListEABAS_DocsCompra
            c1grdBusqueda.DataSource = bs_reporte
            bnavNavievador.BindingSource = bs_reporte
            UpdateTotals()
         End If
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso cargar Reporte", ex)
      End Try
   End Sub

   Private Sub btnClean_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClean.Click
      Try
         actxaEntCodigo.Clear()
         actxaProvRazonSocial.Clear()
         setRol(Constantes.Seteo.Activar)
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso Limpiar Entidad", ex)
      End Try
   End Sub

   Private Sub tsbtnprevisualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnprevisualizar.Click
      Try
            Utilitarios.reportToScreen(c1grdBusqueda, "Compras por Proveedor", "Reporte", "", DateTime.Now, New Printing.PaperSize("A4", 827, 1169), New Printing.Margins(40, 40, 120, 40), , , True, False)
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

   Private Sub actxaProvCodigo_ACAyudaClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles actxaEntCodigo.ACAyudaClick
      Try
         AyudaEntidad(actxaEntCodigo.Text, "ENTID_Codigo", EEntidades.TipoEntidad.Proveedores)
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso busqueda de cliente por codigo", ex)
      End Try
   End Sub
#End Region

#End Region

    Private Sub tsbtnExcel_Click(sender As Object, e As EventArgs) Handles tsbtnExcel.Click
        Try
            Utilitarios.ExportarXLS(c1grdBusqueda, "Compras por Proveedor")
        Catch ex As Exception
            ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso Exportar a Excel", ex)
        End Try
    End Sub
End Class