Imports C1.Win.C1FlexGrid
Imports ACBLogistica
Imports ACELogistica

Public Class COrdenesCompras

#Region " Variables "

   Private m_bgenerarregmerctransito As BGenerarRegMercTransito
   Private m_tconsulta As BGenerarRegMercTransito.TConsulta

   Private bs_datos As BindingSource

#End Region

#Region " Propiedades "

   Public ReadOnly Property ABAS_OrdenesCompra() As EABAS_OrdenesCompra
      Get
         Return m_bgenerarregmerctransito.ABAS_OrdenesCompra.ABAS_OrdenesCompra
      End Get
   End Property

   Public ReadOnly Property ABAS_DocsCompra() As EABAS_DocsCompra
      Get
         Return m_bgenerarregmerctransito.ABAS_DocsCompra.ABAS_DocsCompra
      End Get
   End Property

   Public Property TConsulta() As BGenerarRegMercTransito.TConsulta
      Get
         Return m_tconsulta
      End Get
      Set(ByVal value As BGenerarRegMercTransito.TConsulta)
         m_tconsulta = value
      End Set
   End Property

#End Region

#Region " Constructores "
   Public Sub New(ByVal x_tconsulta As BGenerarRegMercTransito.TConsulta)

      ' This call is required by the designer.
      InitializeComponent()

      ' Add any initialization after the InitializeComponent() call.
      Try
         m_tconsulta = x_tconsulta
         formatearGrilla(m_tconsulta)
         If m_tconsulta = BGenerarRegMercTransito.TConsulta.Compras Then
            rbtnDCompra.Checked = True
         ElseIf m_tconsulta = BGenerarRegMercTransito.TConsulta.Ordenes Then
            rbtnOCompra.Checked = True
         End If

         m_bgenerarregmerctransito = New BGenerarRegMercTransito(GApp.Periodo)
         acTool.ACTipoToolBar = ACControles.ACToolBarMantHorizontalNew.tipoToolBar.ToolSalir
         acTool.ACBtnSalirVisible = True
         actsbtnSeleccionar.Visible = True
         AcFecha.ACDtpFecha_De.Value = DateTime.Now.AddDays(-1 * DateTime.Now.Day + 1)

         btnMTConsultar_Click(Nothing, Nothing)

      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), Colecciones.getError("00000"), ex)
      End Try
   End Sub
#End Region

#Region " Metodos "
   Private Sub formatearGrilla(ByVal x_opcion As BGenerarRegMercTransito.TConsulta)
      Dim index As Integer = 1
      Try
         index = 1
         If x_opcion = BGenerarRegMercTransito.TConsulta.Compras Then
                ACFrameworkC1.ACUtilitarios.ACFormatearGrilla(c1grdBusqueda, 1, 1, 12, 1, 2)
                ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Codigo", "DOCCO_Codigo", "DOCCO_Codigo", 150, False, False, "System.String") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Fecha", "DOCCO_FechaDocumento", "DOCCO_FechaDocumento", 150, True, False, "System.DateTime", Parametros.GetParametro(ACEVentas.EParametros.TipoParametros.pg_FormatoFecha)) : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Doc. Compras", "Documento", "Documento", 150, True, False, "System.String") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Orden", "CodigoOrden", "CodigoOrden", 150, True, False, "System.String") : index += 1
                ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "OrdenCompra", "ORDCO_Codigo", "ORDCO_Codigo", 150, True, False, "System.String") : index += 1
                ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Cot.Proveedor", "DOCCO_CotizacionProveedor", "DOCCO_CotizacionProveedor", 150, True, False, "System.String") : index += 1



                ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "R.U.C.", "ENTID_CodigoProveedor", "ENTID_CodigoProveedor", 150, True, False, "System.String") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Razon Social Proveedor", "ENTID_Proveedor", "ENTID_Proveedor", 150, True, False, "System.String") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Moneda", "TIPOS_TipoMoneda", "TIPOS_TipoMoneda", 150, True, False, "System.String") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Total", "DOCCO_TotalCompra", "DOCCO_TotalCompra", 150, True, False, "System.Decimal", Parametros.GetParametro(ACEVentas.EParametros.TipoParametros.pg_FMondo2d)) : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Estado", "ORDCO_Estado_Text", "ORDCO_Estado_Text", 150, True, False, "System.String") : index += 1
                'ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Estado", "ORDCO_Estado", "ORDCO_Estado", 150, True, False, "System.String") : index += 1

            ElseIf x_opcion = BGenerarRegMercTransito.TConsulta.Ordenes Then
                ACFrameworkC1.ACUtilitarios.ACFormatearGrilla(c1grdBusqueda, 1, 1, 12, 1, 2)
                ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Codigo", "ORDCO_Codigo", "ORDCO_Codigo", 150, False, False, "System.String") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Fecha", "ORDCO_FechaDocumento", "ORDCO_FechaDocumento", 150, True, False, "System.DateTime", Parametros.GetParametro(ACEVentas.EParametros.TipoParametros.pg_FormatoFecha)) : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Documento", "Documento", "Documento", 150, True, False, "System.String") : index += 1
                ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Cot.Proveedor", "ORDCO_CotizacionProveedor", "ORDCO_CotizacionProveedor", 150, True, False, "System.String") : index += 1



                ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "OrdenCompra", "ORDCO_Codigo", "ORDCO_Codigo", 150, True, False, "System.String") : index += 1

                ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "R.U.C.", "ENTID_CodigoProveedor", "ENTID_CodigoProveedor", 150, True, False, "System.String") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Razon Social Proveedor", "ENTID_Proveedor", "ENTID_Proveedor", 150, True, False, "System.String") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Moneda", "TIPOS_TipoMoneda", "TIPOS_TipoMoneda", 150, True, False, "System.String") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Total", "ORDCO_TotalCompra", "ORDCO_TotalCompra", 150, True, False, "System.Decimal", Parametros.GetParametro(ACEVentas.EParametros.TipoParametros.pg_FMondo2d)) : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Estado", "DOCCO_Estado_Text", "DOCCO_Estado_Text", 150, True, False, "System.String") : index += 1
                ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Estado", "DOCCO_Estado", "DOCCO_Estado", 150, True, False, "System.String") : index += 1
         End If
         c1grdBusqueda.AllowEditing = False
         c1grdBusqueda.AllowSorting = AllowSortingEnum.SingleColumn
         c1grdBusqueda.Styles.Alternate.BackColor = Color.LightGray
         c1grdBusqueda.Styles.Fixed.TextAlign = TextAlignEnum.CenterCenter
         c1grdBusqueda.Styles.Highlight.BackColor = Color.Gray
         c1grdBusqueda.SelectionMode = SelectionModeEnum.Row

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

   Private Function getOpcion() As BGenerarRegMercTransito.TConsulta
      If rbtnOCompra.Checked Then
         Return BGenerarRegMercTransito.TConsulta.Ordenes
      Else
         Return BGenerarRegMercTransito.TConsulta.Compras
      End If
   End Function

   Private Function getOpciontc() As Short
      If rbtnRazonSocial.Checked Then
         Return 0
      ElseIf rbtnCodigo.Checked Then
         Return 1
      End If
   End Function

#End Region

#Region " Metodos de Controles"

   Private Sub btnMTConsultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMTConsultar.Click
      Try
         bs_datos = New BindingSource
         If m_bgenerarregmerctransito.BusquedaOrdenesCompras(getOpcion(), txtBusqueda.Text, getOpciontc(), chkMTTodos.Checked, AcFecha.ACFecha_De.Value.Date, AcFecha.ACFecha_A.Value.Date) Then
            formatearGrilla(getOpcion())
            If getOpcion() = BGenerarRegMercTransito.TConsulta.Compras Then
               bs_datos.DataSource = m_bgenerarregmerctransito.ABAS_DocsCompra.ListABAS_DocsCompra
            Else
               bs_datos.DataSource = m_bgenerarregmerctransito.ABAS_OrdenesCompra.ListABAS_OrdenesCompra
            End If
            c1grdBusqueda.DataSource = bs_datos
            bnavBusqueda.BindingSource = bs_datos
         Else
            bs_datos.ResetBindings(False)
            ACControles.ACDialogos.ACMostrarMensajeInformacion(String.Format("Información: {0}", Me.Text), "Posiblemente no haya datos que mostrar")
         End If
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), String.Format(Colecciones.getError("00101"), "Consultar"), ex)
      End Try
   End Sub

   Private Sub actsbtnSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles actsbtnSeleccionar.Click
      Try
         If m_tconsulta = BGenerarRegMercTransito.TConsulta.Ordenes Then
            m_bgenerarregmerctransito.ABAS_OrdenesCompra.ABAS_OrdenesCompra = CType(bs_datos.Current, EABAS_OrdenesCompra)
         ElseIf m_tconsulta = BGenerarRegMercTransito.TConsulta.Compras Then
            m_bgenerarregmerctransito.ABAS_DocsCompra.ABAS_DocsCompra = CType(bs_datos.Current, EABAS_DocsCompra)
         End If
         Me.DialogResult = System.Windows.Forms.DialogResult.OK
         Me.Close()
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), String.Format(Colecciones.getError("00101"), "Seleccionar"), ex)
      End Try
   End Sub

   Private Sub rbtnDCompra_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtnDCompra.CheckedChanged
      If rbtnOCompra.Checked Then
         m_tconsulta = BGenerarRegMercTransito.TConsulta.Ordenes
      Else
         m_tconsulta = BGenerarRegMercTransito.TConsulta.Compras
      End If
   End Sub

   Private Sub acTool_ACBtnSalir_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles acTool.ACBtnSalir_Click
      Me.Close()
   End Sub

#End Region

End Class