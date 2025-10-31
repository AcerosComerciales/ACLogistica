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

Public Class RGuiasGeneralFecha

#Region "Variables"
   Private managerreporte As BGenerarReportes
   Private bs_reporte As BindingSource
#End Region

#Region " Propiedades "
  
#End Region


#Region " Constructores "
   Public Sub New(ByVal x_icono As System.Drawing.Bitmap)

      ' This call is required by the designer.
      InitializeComponent()

      ' Add any initialization after the InitializeComponent() call.
      Try
         managerreporte = New BGenerarReportes()

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
         ACFrameworkC1.ACUtilitarios.ACFormatearGrilla(c1grdBusqueda, 1, 1, 11, 1, 0)
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Codigo", "Codigo", "Codigo", 120, True, False, "System.String", "") : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Serie", "Serie", "Serie", 50, True, False, "System.String", "") : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Numero", "Numero", "Numero", 120, True, False, "System.Decimal", Parametros.GetParametro(ACEVentas.EParametros.TipoParametros.pg_FMondo2d)) : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Motivo", "Motivo", "Motivo", 350, True, False, "System.String", "") : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Fecha_Emision", "Fecha_Emision", "Fecha_Emision", 80, True, False, "System.DateTime", Parametros.GetParametro(EParametros.TipoParametros.pg_FormatoFecha)) : index += 1

         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "RUC", "RUC", "RUC", 120, True, False, "System.String", "") : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Descripcion_Cliente", "Descripcion_Cliente", "Descripcion_Cliente", 320, True, False, "System.String", "") : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Cod_Transportista", "Cod_Transportista", "Cod_Transportista", 120, True, False, "System.String", "") : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Descripcion_Transportista", "Descripcion_Transportista", "Descripcion_Transportista", 320, True, False, "System.String", "") : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Estado", "Estado", "Estado", 50, True, False, "System.String") : index += 1

         c1grdBusqueda.AllowEditing = False
         c1grdBusqueda.Styles.Alternate.BackColor = Color.WhiteSmoke
         c1grdBusqueda.Styles.Fixed.TextAlign = TextAlignEnum.CenterCenter
         c1grdBusqueda.Styles.Highlight.BackColor = Color.Gray
         c1grdBusqueda.SelectionMode = SelectionModeEnum.Row
         c1grdBusqueda.AllowResizing = AllowResizingEnum.Both
         c1grdBusqueda.AutoResize = False
         c1grdBusqueda.DrawMode = C1.Win.C1FlexGrid.DrawModeEnum.OwnerDraw
         ' ojo
         'c1grdBusqueda.Cols("DPAGO_Glosa").StyleDisplay.WordWrap = True

         c1grdBusqueda.Tree.Column = 1

         
         c1grdBusqueda.DrawMode = C1.Win.C1FlexGrid.DrawModeEnum.OwnerDraw


      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError("Error: " + Me.Text, "No se puede dar formato a la grilla", ex)
      End Try
   End Sub
#Region "Utilitarios"
  
#End Region
#End Region

#Region " Metodos de Controles"
   Private Sub AcFecha_ACFecIni_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
      If e.KeyData = Keys.Enter Then
         AcFecha.ACDtpFecha_A.Focus()
      End If
   End Sub

   Private Sub AcFecha_ACFecFin_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
      If e.KeyData = Keys.Enter Then
         btnProcesar_Click(Nothing, Nothing)
      End If
   End Sub

   Private Sub btnProcesar_Click(sender As Object, e As EventArgs) Handles btnProcesar.Click
      Try
         formatearGrilla()
         bs_reporte = New BindingSource

         If Not managerreporte.GuiasXFecha(AcFecha.ACDtpFecha_De.Value.Date, AcFecha.ACDtpFecha_A.Value.Date) Then
            managerreporte.ListABAS_Guias = New List(Of EABAS_Guias)
         End If

         bs_reporte.DataSource = managerreporte.ListABAS_Guias
         bnavNavegador.BindingSource = bs_reporte
         c1grdBusqueda.DataSource = bs_reporte
         c1grdBusqueda.AutoSizeRows()

         c1grdBusqueda.AutoSizeCol(c1grdBusqueda.Cols("Codigo").Index)
         c1grdBusqueda.AutoSizeCol(c1grdBusqueda.Cols("Serie").Index)
         c1grdBusqueda.AutoSizeCol(c1grdBusqueda.Cols("Numero").Index)

         c1grdBusqueda.AutoSizeCol(c1grdBusqueda.Cols("Motivo").Index)
         c1grdBusqueda.AutoSizeCol(c1grdBusqueda.Cols("Fecha_Emision").Index)
         c1grdBusqueda.AutoSizeCol(c1grdBusqueda.Cols("RUC").Index)
         c1grdBusqueda.AutoSizeCol(c1grdBusqueda.Cols("Descripcion_Cliente").Index)
         c1grdBusqueda.AutoSizeCol(c1grdBusqueda.Cols("Cod_Transportista").Index)
         c1grdBusqueda.AutoSizeCol(c1grdBusqueda.Cols("Descripcion_Transportista").Index)
         c1grdBusqueda.AutoSizeCol(c1grdBusqueda.Cols("Estado").Index)

      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), String.Format(Colecciones.getError("00101"), "Procesar Consulta"), ex)
      End Try
   End Sub

#End Region

End Class