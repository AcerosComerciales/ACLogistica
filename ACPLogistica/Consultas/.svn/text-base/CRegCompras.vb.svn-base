Imports ACBLogistica
Imports ACBVentas
Imports ACELogistica
Imports ACEVentas
Imports ACFramework

Imports Microsoft.Practices.Unity
Imports C1.Win.C1FlexGrid

Public Class CRegCompras

#Region " Variables "
   Private managerABAS_IngresosCompra As BABAS_IngresosCompra

   Private bs_abas_ingresocompras As BindingSource
#End Region

#Region " Propiedades "

#End Region

#Region " Constructores "
   Public Sub New()
      ' This call is required by the Windows Form Designer.
      InitializeComponent()
      Try
         tabMantenimiento.HideTabsMode = Crownwood.DotNetMagic.Controls.HideTabsModes.HideAlways
         tabMantenimiento.SelectedTab = tabBusqueda
         '' Inicializar los componentes con Unity
         managerABAS_IngresosCompra = New BABAS_IngresosCompra
         '' Iniciarlizar los componentes graficos
         formatearGrilla()
         'cargaCombos()
         setInstancia(ACUtilitarios.ACSetInstancia.Deshacer)
         '' Aplicar el titulo segun el tipo de documento que se va a cargar
         Me.Text = acpnlTitulo.ACCaption
         '' Obtener el proceso que se va a validar
         'GApp.DataUsuario.PROC_Codigo = Constantes.getProceso(Constantes.TipoProcesos.ModificarPedido)
         'Dim _validate As New ACValidarUsuario(GApp.DataConexion, GApp.DataUsuario, ACValidarUsuario.Operacion.ValidarProceso)
         'm_proceso_modificar = _validate.ACProceso
         'acTool.ACBtnModificarVisible = m_proceso_modificar
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "No se puede cargar los controles iniciales", ex)
      End Try
   End Sub
#End Region

#Region " Metodos "

#Region " Utilitarios "

   Private Sub setInstancia(ByVal _opcion As ACUtilitarios.ACSetInstancia)
      acTool.ACBtnModificarVisible = False
      acTool.ACBtnNuevoVisible = False
      Select Case _opcion
         Case ACUtilitarios.ACSetInstancia.Nuevo
            actsbtnPrevisualizar.Visible = False
            tabMantenimiento.SelectedTab = tabDatos
         Case ACUtilitarios.ACSetInstancia.Modificado
            actsbtnPrevisualizar.Visible = True
         Case ACUtilitarios.ACSetInstancia.Guardar
            txtBusqueda.Focus()
            actsbtnPrevisualizar.Visible = True
         Case ACUtilitarios.ACSetInstancia.Deshacer
            acTool.ACBtnBuscarVisible = False
            actsbtnPrevisualizar.Visible = True
            tabMantenimiento.SelectedTab = tabBusqueda
         Case ACUtilitarios.ACSetInstancia.Previsualizar
            'acTool.setInstancia(ACControles.ACToolBarMantHorizontalNew.TipoInstancia.Volver)
            actsbtnPrevisualizar.Visible = False
            acTool.ACBtnVolverVisible = True
      End Select
   End Sub

   Private Sub formatearGrilla()
      Dim index As Integer = 1
      Try
         ACFrameworkC1.ACUtilitarios.ACFormatearGrilla(c1grdBusqueda, 1, 1, 10, 1, 2)
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Cod. Orden", "ORDCO_Codigo", "ORDCO_Codigo", 150, True, False, "System.String") : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Fecha", "INGCO_FechaDocumento", "INGCO_FechaDocumento", 150, True, False, "System.DateTime") : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Codigo", "INGCO_Codigo", "INGCO_Codigo", 150, True, False, "System.String") : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Doc. Ref.", "Referencia", "Referencia", 150, True, False, "System.String") : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Doc. Compra", "DOCCO_Codigo", "DOCCO_Codigo", 150, True, False, "System.String") : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Almacen", "ALMAC_Descripcion", "ALMAC_Descripcion", 150, True, False, "System.String") : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Proveedor", "ENTID_Proveedor", "ENTID_Proveedor", 150, True, False, "System.String") : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Estado", "INGCO_Estado_Text", "INGCO_Estado_Text", 150, True, False, "System.String") : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "COTCO_Estado", "INGCO_Estado", "INGCO_Estado", 150, False, False, "System.String") : index += 1

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

         c1grdBusqueda.SubtotalPosition = SubtotalPositionEnum.AboveData
         c1grdBusqueda.Tree.Column = 1

         Dim s As CellStyle = c1grdBusqueda.Styles(CellStyleEnum.Subtotal0)
         s.BackColor = Color.White
         s.ForeColor = Color.Red
         s.Font = New Font(c1grdBusqueda.Font, FontStyle.Bold)


      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Text), "No se puede dar formato a la grilla", ex)
      End Try
   End Sub

   Private Function getCampo() As String
      Try
         If (rbtnProveedor.Checked) Then
            Return "ENTID_RazonSocial"
         ElseIf rbtnNroOrdenCompra.Checked Then
            Return "ORDCO_Codigo"
         Else
            Return "ENTID_RazonSocial"
         End If
      Catch ex As Exception
         Throw ex
      End Try
   End Function
#End Region

#Region " Cargar Datos "
   ''' <summary>
   ''' Cargar los datos en el control Visual C1FlexGrid
   ''' </summary>
   Private Sub cargarDatos()
      Try
         bs_abas_ingresocompras = New BindingSource()
         bs_abas_ingresocompras.DataSource = managerABAS_IngresosCompra.ListABAS_IngresosCompra
         c1grdBusqueda.DataSource = bs_abas_ingresocompras
         bnavBusqueda.BindingSource = bs_abas_ingresocompras
         AddHandler bs_abas_ingresocompras.CurrentChanged, AddressOf bs_detordencompra_CurrentChanged
         bs_detordencompra_CurrentChanged(Nothing, Nothing)
         chkAgrupar_CheckedChanged(Nothing, Nothing)
      Catch ex As Exception
         Throw ex
      End Try
   End Sub

   Private Sub bs_detordencompra_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
      Try
         If Not IsNothing(bs_abas_ingresocompras.Current) Then
            If CType(bs_abas_ingresocompras.Current, EABAS_IngresosCompra).INGCO_Estado = EABAS_IngresosCompra.getEstado(EABAS_IngresosCompra.Estado.Confirmado) Then
               acTool.ACBtnModificarEnabled = False
            Else
               acTool.ACBtnModificarEnabled = True
            End If
         End If
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso Cargar Propiedades del Cotización/Pedido", ex)
      End Try
   End Sub
#End Region
   ''' <summary>
   ''' Ejecutar la busqueda de una cadena en la tabla Neumaticos
   ''' </summary>
   ''' <param name="x_cadena">Cadena objetivo</param>
   ''' <returns></returns>
   Private Function busquedaDatos(ByVal x_cadena As String) As Boolean
      Try
         'If txtBusqueda.ACEstadoAutoAyuda Then
         If managerABAS_IngresosCompra.Busqueda(x_cadena, getCampo(), chkTodos.Checked, AcFecha.ACDtpFecha_De.Value.Date, AcFecha.ACDtpFecha_A.Value.Date) Then
            acTool.ACBtnEliminarEnabled = True
            acTool.ACBtnModificarEnabled = True
         Else
            acTool.ACBtnEliminarEnabled = False
            acTool.ACBtnModificarEnabled = False
         End If
         cargarDatos()
         'End If
         Return acTool.ACBtnEliminarEnabled
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Convert.ToString(Text)), "No se puede cargar la ayuda de los conductores", ex)
      End Try
      Return False
   End Function
#End Region

#Region " Metodos de Controles"
#Region " Ayudas "

   Private Sub txtBusqueda_ACAyudaClick(ByVal sender As Object, ByVal e As EventArgs) Handles txtBusqueda.ACAyudaClick
      Try
         busquedaDatos(txtBusqueda.Text)
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Convert.ToString(Text)), "No se puede cargar la ayuda de los conductores", ex)
      End Try
   End Sub

#End Region

#Region " ToolBar "

   Private Sub acTool_ACBtnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles acTool.ACBtnVolver_Click
      Try
         setInstancia(ACUtilitarios.ACSetInstancia.Deshacer)
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso Volver", ex)
      End Try
   End Sub

   Private Sub acTool_ACBtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles acTool.ACBtnNuevo_Click

   End Sub

   Private Sub acTool_ACBtnGrabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles acTool.ACBtnGrabar_Click

   End Sub

   Private Sub acTool_ACBtnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles acTool.ACBtnImprimir_Click

   End Sub

   Private Sub acTool_ACBtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles acTool.ACBtnCancelar_Click
      Try
         setInstancia(ACUtilitarios.ACSetInstancia.Deshacer)
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso cancelar la Cotización/Pedido", ex)
      End Try
   End Sub

   Private Sub acTool_ACBtnAnular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles acTool.ACBtnAnular_Click
      Dim msg As String = ""
      Try
         If validar(msg) Then
            Dim _codigo As String = CType(bs_abas_ingresocompras.Current, EABAS_IngresosCompra).INGCO_Id
            If ACControles.ACDialogos.ACMostrarMensajePregunta(String.Format("Anular Registro: {0}", Me.Text) _
                , String.Format("Desea anular el registro de ingreso Nro : {0}, del proveedor {1} " _
                                , _codigo _
                                , CType(bs_abas_ingresocompras.Current, EABAS_IngresosCompra).ENTID_Proveedor) _
                , ACControles.ACDialogos.LabelBotom.Si_No) = DialogResult.Yes Then
               managerABAS_IngresosCompra.ABAS_IngresosCompra = New EABAS_IngresosCompra

               managerABAS_IngresosCompra.ABAS_IngresosCompra.ENTID_CodigoProveedor = CType(bs_abas_ingresocompras.Current, EABAS_IngresosCompra).ENTID_CodigoProveedor
               managerABAS_IngresosCompra.ABAS_IngresosCompra.INGCO_Estado = EABAS_IngresosCompra.getEstado(EABAS_IngresosCompra.Estado.Anulado)
               managerABAS_IngresosCompra.ABAS_IngresosCompra.Instanciar(ACEInstancia.Modificado)
               If managerABAS_IngresosCompra.Guardar(GApp.Usuario) Then
                  ACControles.ACDialogos.ACMostrarMensajeSatisfactorio(String.Format("Información: {0}", Me.Text), String.Format("Registro de Ingreso Nro {0}, Anulada satisfactoriamente", _codigo))
                  setInstancia(ACUtilitarios.ACSetInstancia.Deshacer)
                  txtBusqueda_ACAyudaClick(Nothing, Nothing)
                  'actsbtnPrevisualizar_Click(Nothing, Nothing)
               End If
            End If
         Else
            ACControles.ACDialogos.ACMostrarMensajeInformacion(String.Format("Información: {0}", Me.Text), "No se puede cargar", msg)
         End If
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso Anular Cotización Pedido", ex)
      End Try
   End Sub

   Private Sub acTool_ACBtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles acTool.ACBtnSalir_Click
      Try
         Me.Close()
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso Salir", ex)
      End Try
   End Sub


   Private Function validar(ByRef msg As String) As Boolean
      Try
         If Not IsNothing(bs_abas_ingresocompras) Then
            If Not IsNothing(bs_abas_ingresocompras.Current) Then
               Return True
            Else
               msg = "No se ha seleccionado ningun registro"
               Return False
            End If
         Else
            msg = "No se ha cargado ningun registro"
            Return False
         End If
      Catch ex As Exception
         Throw ex
      End Try
   End Function
#End Region

#Region " Grillas "
   Private Sub c1grdBusqueda_OwnerDrawCell(ByVal sender As System.Object, ByVal e As C1.Win.C1FlexGrid.OwnerDrawCellEventArgs) Handles c1grdBusqueda.OwnerDrawCell
      Try
         If e.Row < c1grdBusqueda.Rows.Fixed OrElse e.Col < c1grdBusqueda.Cols.Fixed Then Return
         If c1grdBusqueda.Rows(e.Row)("INGCO_Estado") = EABAS_IngresosCompra.getEstado(EABAS_IngresosCompra.Estado.Confirmado) Then
            e.Style = c1grdBusqueda.Styles("Facturado")
         End If
         If c1grdBusqueda.Rows(e.Row)("INGCO_Estado") = EABAS_IngresosCompra.getEstado(EABAS_IngresosCompra.Estado.Anulado) Then
            e.Style = c1grdBusqueda.Styles("Anulado")
         End If
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso cambia de color", ex)
      End Try
   End Sub
#End Region
#End Region

   Private Sub chkAgrupar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAgrupar.CheckedChanged
      Try
         If chkAgrupar.Checked Then
            c1grdBusqueda.Subtotal(AggregateEnum.Sum, 0, 1, 1, "Orden: {0}")
         Else
            c1grdBusqueda.Subtotal(AggregateEnum.Clear)
         End If
         c1grdBusqueda.AutoSizeCols()
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Convert.ToString(Text)), "No se agrupar resultados", ex)
      End Try
   End Sub

   Private Sub actsbtnPrevisualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles actsbtnPrevisualizar.Click
      Try
         If Not IsNothing(bs_abas_ingresocompras) Then
            If Not IsNothing(bs_abas_ingresocompras.Current) Then
               Dim _form As TRegMerTransitoOrden
               Dim x_codigo As String = CType(bs_abas_ingresocompras.Current, EABAS_IngresosCompra).INGCO_Id
               Dim x_almac_id As String = CType(bs_abas_ingresocompras.Current, EABAS_IngresosCompra).ALMAC_Id
               Dim x_entidad As String = CType(bs_abas_ingresocompras.Current, EABAS_IngresosCompra).ENTID_CodigoProveedor
               setInstancia(ACUtilitarios.ACSetInstancia.Previsualizar)
               _form = New TRegMerTransitoOrden(TRegMerTransito.Inicializacion.Consulta, x_codigo, x_almac_id, x_entidad)
               _form.TopLevel = False
               tabMantenimiento.SelectedTab = tabDatos
               Me.pnlDetalle.Controls.Add(_form)
               _form.Show()
            Else
               ACControles.ACDialogos.ACMostrarMensajeInformacion(String.Format("Información: {0}", Me.Text), "No se puede cargar, seleccione algun registro")
            End If
         Else
            ACControles.ACDialogos.ACMostrarMensajeInformacion(String.Format("Información: {0}", Me.Text), "No se puede cargar, cargue algun registro")
         End If
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Convert.ToString(Text)), "No puede previsualizar el registro de compra", ex)
      End Try
   End Sub
End Class