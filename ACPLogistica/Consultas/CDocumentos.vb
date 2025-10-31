Imports ACBVentas
Imports ACEVentas
Imports ACFramework
Imports ACFrameworkC1

Imports Microsoft.Practices.Unity
Imports Microsoft.Practices.Unity.Configuration
Imports C1.Win.C1FlexGrid

Public Class CDocumentos
#Region " Variables "
   Private managerVENT_DocsVenta As BVENT_DocsVenta
   Private managerVENT_PVentDocumento As BVENT_PVentDocumento

   Private m_event_docsventa As EVENT_DocsVenta

   Private bs_documentosventa As BindingSource
   Private bs_documentos As BindingSource
#End Region

#Region " Propiedades "

   Public Property VENT_DocsVenta() As EVENT_DocsVenta
      Get
         Return m_event_docsventa
      End Get
      Set(ByVal value As EVENT_DocsVenta)
         m_event_docsventa = value
      End Set
   End Property
#End Region

#Region " Constructores "
   Public Sub New()
      ' This call is required by the Windows Form Designer.
      InitializeComponent()
      Try
         tabMantenimiento.HideTabsMode = Crownwood.DotNetMagic.Controls.HideTabsModes.HideAlways
         tabMantenimiento.SelectedTab = tabBusqueda

         managerVENT_DocsVenta = New BVENT_DocsVenta
         managerVENT_PVentDocumento = New BVENT_PVentDocumento

         formatearGrilla()
         CargarCombos()

         rbtnCliente.Checked = True
         grpCliente.Enabled = True
         grpDocumentos.Enabled = False
         grpRequisicion.Enabled = False
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "No se puede cargar los controles iniciales", ex)
      End Try
   End Sub
#End Region

#Region " Metodos "

#Region " Utilitarios "
   Private Sub CargarCombos()
      Try '' Documento de Venta 
         bs_documentosventa = New BindingSource()
         bs_documentosventa.DataSource = Colecciones.TiposDocComprobante()
         ACFramework.ACUtilitarios.ACCargaCombo(cmbTipoDocumento, bs_documentosventa, "TIPOS_Descripcion", "TIPOS_Codigo")
         AddHandler bs_documentosventa.CurrentChanged, AddressOf bs_documentosventa_CurrentChanged
         bs_documentosventa_CurrentChanged(Nothing, Nothing)
      Catch ex As Exception
         Throw ex
      End Try
   End Sub

   Private Sub formatearGrilla()
      Dim index As Integer = 1
      Try
         ACFrameworkC1.ACUtilitarios.ACFormatearGrilla(c1grdBusqueda, 1, 1, 12, 1, 0)
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Fecha", "DOCVE_FechaDocumento", "DOCVE_FechaDocumento", 150, True, False, "System.DateTime") : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Codigo", "DOCVE_Codigo", "DOCVE_Codigo", 150, True, False, "System.String") : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Cotizador", "Usuario", "Usuario", 150, True, False, "System.String") : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Documento", "TIPOS_TipoDocumento", "TIPOS_TipoDocumento", 150, True, False, "System.String") : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Cliente", "ENTID_Cliente", "ENTID_Cliente", 150, True, False, "System.String") : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Moneda", "TIPOS_TipoMoneda", "TIPOS_TipoMoneda", 150, True, False, "System.String") : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Total Pagar", "DOCVE_TotalPagar", "DOCVE_TotalPagar", 150, True, False, "System.Decimal", Parametros.GetParametro(EParametros.TipoParametros.pg_FMondo2d)) : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Numero", "DOCVE_Numero", "DOCVE_Numero", 150, True, False, "System.String") : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Vendedor", "ENTID_Vendedor", "ENTID_Vendedor", 150, True, False, "System.String") : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Estado", "DOCVE_Estado_Text", "DOCVE_Estado_Text", 150, True, False, "System.String") : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Estado", "DOCVE_Estado", "DOCVE_Estado", 150, False, False, "System.String") : index += 1

         c1grdBusqueda.AllowEditing = False
         c1grdBusqueda.Styles.Alternate.BackColor = Color.LightGray
         c1grdBusqueda.Styles.Fixed.TextAlign = TextAlignEnum.CenterCenter
         c1grdBusqueda.Styles.Highlight.BackColor = Color.Gray
         c1grdBusqueda.SelectionMode = SelectionModeEnum.Row

         Dim t As C1.Win.C1FlexGrid.CellStyle = c1grdBusqueda.Styles.Add("Facturado")
         t.BackColor = Color.LightGreen
         t.ForeColor = Color.DarkBlue
         t.Font = New Font(c1grdBusqueda.Font, FontStyle.Regular)

         Dim u As C1.Win.C1FlexGrid.CellStyle = c1grdBusqueda.Styles.Add("Facturar")
         u.BackColor = Color.Green
         u.ForeColor = Color.White
         u.Font = New Font(c1grdBusqueda.Font, FontStyle.Regular)

         Dim d As C1.Win.C1FlexGrid.CellStyle = c1grdBusqueda.Styles.Add("Anulado")
         d.BackColor = Color.Red
         d.ForeColor = Color.White
         d.Font = New Font(c1grdBusqueda.Font, FontStyle.Bold)
         c1grdBusqueda.DrawMode = C1.Win.C1FlexGrid.DrawModeEnum.OwnerDraw


      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Text), "No se puede dar formato a la grilla", ex)
      End Try
   End Sub

#End Region

#Region " Cargar Datos "
   Private Sub cargarDatos(ByVal x_opcion As Boolean)
      Try
         bs_documentos = New BindingSource()
         If x_opcion Then
            bs_documentos.DataSource = managerVENT_DocsVenta.ListVENT_DocsVenta
         Else
            managerVENT_DocsVenta.ListVENT_DocsVenta = New List(Of EVENT_DocsVenta)
            bs_documentos.DataSource = managerVENT_DocsVenta.ListVENT_DocsVenta
         End If
         c1grdBusqueda.DataSource = bs_documentos
         bnavBusqueda.BindingSource = bs_documentos
      Catch ex As Exception
         Throw ex
      End Try
   End Sub
#End Region

   Private Function busquedaCliente(ByVal x_cadena As String) As Boolean
      Try
         Dim m_return As Boolean
         'If txtBusqueda.ACEstadoAutoAyuda Then
         If managerVENT_DocsVenta.getCliente(x_cadena, "ENTID_Nombres", chkTodos.Checked, AcFecha.ACFechaObligatoria, AcFecha.ACDtpFecha_De.Value.Date, AcFecha.ACDtpFecha_A.Value.Date) Then
            cargarDatos(True)
            '   acTool.ACBtnEliminarEnabled = True
            '   acTool.ACBtnModificarEnabled = True
         Else
            cargarDatos(False)
            '   acTool.ACBtnEliminarEnabled = False
            '   acTool.ACBtnModificarEnabled = False
         End If

         'End If
         Return m_return
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Convert.ToString(Text)), "No se puede cargar la ayuda de los conductores", ex)
      End Try
      Return False
   End Function

   Private Function busquedaDocumentos(ByVal x_cadena As String) As Boolean
      Try
         Dim m_return As Boolean
         'If txtBusqueda.ACEstadoAutoAyuda Then
         If managerVENT_DocsVenta.getDocumentos(cmbSerie.SelectedValue, txtBusNumero.Text, chkTodos.Checked, cmbTipoDocumento.SelectedValue) Then
            cargarDatos(True)
            '   acTool.ACBtnEliminarEnabled = True
            '   acTool.ACBtnModificarEnabled = True
         Else
            cargarDatos(False)
            '   acTool.ACBtnEliminarEnabled = False
            '   acTool.ACBtnModificarEnabled = False
         End If
         'End If
         Return m_return
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Convert.ToString(Text)), "No se puede cargar la ayuda de los conductores", ex)
      End Try
      Return False
   End Function

   Private Sub bs_documentosventa_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
      Try
         If Not IsNothing(bs_documentosventa.Current) Then
            '' Cargar las series
            managerVENT_PVentDocumento.GetSeries(GApp.Zona, GApp.Sucursal, GApp.Sucursal, CType(bs_documentosventa.Current, ETipos).TIPOS_Codigo)
            ACFramework.ACUtilitarios.ACCargaCombo(cmbSerie, managerVENT_PVentDocumento.ListVENT_PVentDocumento, "PVDOCU_Serie", "PVDOCU_Serie")
         End If
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso Cambiar Registro", ex)
      End Try
   End Sub
#End Region

#Region " Metodos de Controles"

   Private Sub actsbtnSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles actsbtnSeleccionar.Click
      Try
         If Not IsNothing(bs_documentos) Then
            If Not IsNothing(bs_documentos.Current) Then
               m_event_docsventa = CType(bs_documentos.Current, EVENT_DocsVenta)
               If ACControles.ACDialogos.ACMostrarMensajePregunta(String.Format("Seleccionar Registro: {0}", Me.Text) _
                   , String.Format("Desea seleccionar el documento: {0} ", "") _
                   , ACControles.ACDialogos.LabelBotom.Si_No) = DialogResult.Yes Then
                  Me.DialogResult = System.Windows.Forms.DialogResult.OK
               End If
            Else
               ACControles.ACDialogos.ACMostrarMensajeInformacion(String.Format("Información: {0}", Me.Text), "No se puede seleccionar, seleccione un registro")
            End If
         Else
            ACControles.ACDialogos.ACMostrarMensajeInformacion(String.Format("Información: {0}", Me.Text), "No se puede seleccionar, realice una busqueda")
         End If
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso seleccionar", ex)
      End Try
   End Sub
#Region " Ayudas "

   Private Sub txtBusNumero_ACAyudaClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBusNumero.ACAyudaClick
      Try
         busquedaDocumentos(txtBusqueda.Text)
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Convert.ToString(Text)), "No se puede cargar la ayuda de documentos", ex)
      End Try
   End Sub

   Private Sub txtBusqueda_ACAyudaClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBusqueda.ACAyudaClick
      Try
         busquedaCliente(txtBusqueda.Text)
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Convert.ToString(Text)), "No se puede cargar la ayuda de clientes", ex)
      End Try
   End Sub

#End Region

#Region " Opciones "

   Private Sub rbtnRequisicion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtnRequisicion.CheckedChanged
      grpRequisicion.Enabled = rbtnRequisicion.Checked
   End Sub

   Private Sub rbtnCliente_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtnCliente.CheckedChanged
      grpCliente.Enabled = rbtnCliente.Checked
   End Sub

   Private Sub rbtnNroCotizacion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtnNroCotizacion.CheckedChanged
      grpDocumentos.Enabled = rbtnNroCotizacion.Checked
   End Sub

#End Region
#End Region
End Class