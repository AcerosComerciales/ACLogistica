Imports ACBLogistica
Imports ACBVentas
Imports ACEVentas
Imports ACFramework
Imports C1.Win.C1FlexGrid

Public Class MOrdenarProductos
#Region " Variables "
   Private managerAdmArticulos As BAdministrarArticulos

   Private bs_reporte As BindingSource
   Private bs_lineas As BindingSource
   Private bs_sublineas As BindingSource

   Private m_opcion As Reporte
   Private m_cadena As String


   Private m_listLineas As List(Of ELineas)
   Private m_listSubLineas As List(Of ELineas)

   Enum Reporte
      Linea = 1
      SubLinea = 2
      Todo = 3
   End Enum

#End Region

#Region " Propiedades "

#End Region

#Region " Constructores "
   Public Sub New(ByVal x_icono As System.Drawing.Bitmap)

      ' This call is required by the designer.
      InitializeComponent()

      ' Add any initialization after the InitializeComponent() call.
      Try

         managerAdmArticulos = New BAdministrarArticulos

         cargarCombos()
         FormatearGrilla()
         btnGrabar.Enabled = False

         If Not IsNothing(x_icono) Then Me.Icon = Icon.FromHandle(x_icono.GetHicon)

      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), Colecciones.getError("00000"), ex)
      End Try
   End Sub
#End Region

#Region " Metodos "
   Public Function cargarCombos() As Boolean
      Try
         Dim managerConsultaArticulos As New BConsultaArticulos(GApp.Periodo)
         managerConsultaArticulos.cargarProductos()
         m_listLineas = New List(Of ELineas)(managerConsultaArticulos.ListLineas)
         bs_lineas = New BindingSource()
         bs_lineas.DataSource = m_listLineas
         m_listSubLineas = New List(Of ELineas)(managerConsultaArticulos.ListSubLineas)

         ACFramework.ACUtilitarios.ACCargaCombo(cmbLinea, bs_lineas, "LINEA_Nombre", "LINEA_Codigo")
         AddHandler bs_lineas.CurrentChanged, AddressOf bs_lineas_CurrentChanged
         bs_lineas_CurrentChanged(Nothing, Nothing)

         '' Cargar Almacenes
         Dim _listalmacenes As New List(Of EAlmacenes)
         Dim _almacen As New EAlmacenes() : _almacen.ALMAC_Id = -1 : _almacen.ALMAC_Descripcion = " < Todos >"
         _listalmacenes.Add(_almacen)
         For Each item As EAlmacenes In Colecciones.Almacenes
            _listalmacenes.Add(item.Clone())
         Next
         ACFramework.ACUtilitarios.ACCargaCombo(tscmbAlmacen.ComboBox, _listalmacenes, "ALMAC_Descripcion", "ALMAC_Id")

      Catch ex As Exception
         Throw ex
      End Try
   End Function

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

   Private Sub FormatearGrilla()
      Dim _index As Integer = 1
      Try
         ACFrameworkC1.ACUtilitarios.ACFormatearGrilla(c1grdBusqueda, 1, 1, 7, 1, 1)
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, _index, "Linea", "Linea", "Linea", 150, False, False, "System.String", "") : _index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, _index, "SubLinea", "SubLinea", "SubLinea", 150, False, False, "System.String", "") : _index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, _index, "Orden", "Orden", "Orden", 40, True, False, "System.Integer", "") : _index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, _index, "Código", "Codigo", "Codigo", 70, True, False, "System.String", "") : _index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, _index, "Descripcion", "ARTIC_Descripcion", "ARTIC_Descripcion", 500, True, False, "System.String", "") : _index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, _index, "Orden", "ARTIC_Orden", "ARTIC_Orden", 90, True, False, "System.Integer", "###0") : _index += 1

         c1grdBusqueda.AllowEditing = True
         c1grdBusqueda.AllowResizing = AllowResizingEnum.None
         c1grdBusqueda.Styles.Alternate.BackColor = Color.LightGray
         c1grdBusqueda.Styles.Fixed.TextAlign = TextAlignEnum.CenterCenter
         c1grdBusqueda.Styles.Highlight.BackColor = Color.Gray
         c1grdBusqueda.SelectionMode = SelectionModeEnum.Row
         c1grdBusqueda.SubtotalPosition = SubtotalPositionEnum.AboveData
         c1grdBusqueda.Tree.Column = 5
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
         c1grdBusqueda.Cols(0).WidthDisplay \= 3
      Catch ex As Exception
         Throw ex
      End Try
   End Sub
#End Region

#Region " Metodos de Controles"
   Private Sub tsbtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnSalir.Click
      Me.Close()
   End Sub
#End Region

   Private Sub btnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click
      Try
         Select Case m_opcion
            Case Reporte.Linea
               m_cadena = cmbLinea.SelectedValue
            Case Reporte.SubLinea
               m_cadena = cmbSubLinea.SelectedValue
         End Select

         'If managerGenerarReportes.Stocks(m_cadena, GApp.Almacen, CType(m_opcion, Integer), m_reporte, GApp.Periodo, GApp.Zona) Then
         Dim x_linea As String = Nothing
         If rbtnLinea.Checked Then x_linea = cmbLinea.SelectedValue
         Dim x_sublinea As String = Nothing
         If rbtnSubLinea.Checked Then
            x_sublinea = cmbSubLinea.SelectedValue
            btnGrabar.Enabled = True
            c1grdBusqueda.Cols("ARTIC_Orden").AllowEditing = True
         End If
         Dim _fecha As Date
         If dtpFecha.Checked Then
            _fecha = dtpFecha.Value
         Else
            _fecha = Nothing
         End If

         If managerAdmArticulos.ARTICSS_OrdenarProductos(GApp.Periodo, GApp.Almacen, GApp.Zona, x_linea, x_sublinea, _fecha) Then
            Dim _orden As Integer = 1
            Dim _linea As String = managerAdmArticulos.ListArticulos(0).SubLinea
            For Each Item As EArticulos In managerAdmArticulos.ListArticulos
               'Item("Codigo") = Regex.Replace(Item("Codigo"), "^(\d{2})(\d{2})(\d{3})$", "$1.$2.$3")
               If Not Item.SubLinea.Equals(_linea) Then
                  _linea = Item.SubLinea
                  _orden = 1
               End If
               Item.OrdenItem = _orden
               _orden += 1
            Next
            bs_reporte = New BindingSource()
            bs_reporte.DataSource = managerAdmArticulos.ListArticulos
            c1grdBusqueda.DataSource = bs_reporte
            bnavNavievador.BindingSource = bs_reporte

            c1grdBusqueda.Subtotal(AggregateEnum.Clear)
            Dim c As Integer = 2
            c1grdBusqueda.Subtotal(AggregateEnum.Sum, 2, 2, c, "{0}".ToUpper())
            c1grdBusqueda.Subtotal(AggregateEnum.Sum, 1, 1, c, "{0}".ToUpper())
         End If
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso cargar datos del Reporte", ex)
      End Try
   End Sub

   Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
      Try
         If ACControles.ACDialogos.ACMostrarMensajePregunta(String.Format("Guardar Registro: {0}", Me.Text) _
                                     , "¿Desea actualizar el orden de los Articulos?" _
                                     , ACControles.ACDialogos.LabelBotom.Si_No) = DialogResult.Yes Then
            If managerAdmArticulos.Grabar(GApp.Usuario) Then
               ACControles.ACDialogos.ACMostrarMensajeSatisfactorio(String.Format("Información: {0}", Me.Text), "Grabado satisfactoriamente")
            End If
         End If
         btnCargar_Click(Nothing, Nothing)
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), String.Format(Colecciones.getError("00101"), "Grabar Cambios en el Orden"), ex)
      End Try
   End Sub

   Private Sub rbtnTodo_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnTodo.CheckedChanged, rbtnLinea.CheckedChanged
      If rbtnTodo.Checked Then
         cmbLinea.Enabled = False
         cmbSubLinea.Enabled = False
         cmbLinea.SelectedIndex = -1
         cmbSubLinea.SelectedIndex = -1
      ElseIf rbtnLinea.Checked Then
         cmbLinea.Enabled = True
         cmbSubLinea.Enabled = False
         cmbLinea.SelectedIndex = 0
         cmbSubLinea.SelectedIndex = -1
      ElseIf rbtnSubLinea.Checked Then
         cmbLinea.Enabled = True
         cmbSubLinea.Enabled = True
         cmbLinea.SelectedIndex = 0
         cmbSubLinea.SelectedIndex = 0
      Else
         cmbLinea.Enabled = False
         cmbSubLinea.Enabled = False
         cmbLinea.SelectedIndex = -1
         cmbSubLinea.SelectedIndex = -1
      End If
   End Sub

   Private Sub c1grdBusqueda_AfterEdit(sender As Object, e As RowColEventArgs) Handles c1grdBusqueda.AfterEdit
      Try

      Catch ex As Exception

      End Try
   End Sub

   Private Sub c1grdBusqueda_BeforeEdit(sender As Object, e As RowColEventArgs) Handles c1grdBusqueda.BeforeEdit
      Try

      Catch ex As Exception

      End Try
   End Sub
End Class