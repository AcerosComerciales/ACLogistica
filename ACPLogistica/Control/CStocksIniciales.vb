Imports ACBLogistica
Imports ACBVentas
Imports ACControles
Imports ACEVentas
Imports ACFramework
Imports C1.Win.C1FlexGrid

Public Class CStocksIniciales
#Region " Variables "
    Private managerConsultaArticulos As BConsultaArticulos

    Private managerStockIniciales As BStocksIniciales
   

    Private m_listPeriodos As List(Of EPeriodos)


    Private m_reporte As DataTable

     Private m_reporteStockInicial As DataTable

    Private bs_reporte As BindingSource
    Private bs_Periodos As BindingSource
  

    Private m_opcion As Reporte
    Private m_cadena As String
#End Region
#Region " Constructores "
    Public Sub New(ByVal x_icono As System.Drawing.Bitmap)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Try
            managerConsultaArticulos = New BConsultaArticulos(GApp.Periodo)
            managerStockIniciales = New BStocksIniciales

            cargarCombos()
            FormatearGrilla()

            If Not IsNothing(x_icono) Then Me.Icon = Icon.FromHandle(x_icono.GetHicon)

        Catch ex As Exception
            ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "No se puede cargar los controles iniciales", ex)
        End Try
    End Sub
#End Region
#Region " Metodos Utilitarios "
    Public Function cargarCombos() As Boolean
        Try
            ''managerConsultaArticulos.cargarProductos()
            m_listPeriodos = Colecciones.ListPeriodos'New List(Of EPeriodos)()
            bs_Periodos = New BindingSource()
            bs_Periodos.DataSource = m_listPeriodos
          

            'ACFramework.ACUtilitarios.ACCargaCombo(cmbPeriodo, bs_Periodos, "LINEA_Nombre", "LINEA_Codigo")
             ACUtilitarios.ACCargaCombo(cmbPeriodo, bs_Periodos, "PERIO_Descripcion", "PERIO_Codigo", GApp.Periodo)
            AddHandler bs_Periodos.CurrentChanged, AddressOf bs_Periodos_CurrentChanged
            bs_Periodos_CurrentChanged(Nothing, Nothing)

          
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub FormatearGrilla()
        Dim _index As Integer = 1
        Try
            ACFrameworkC1.ACUtilitarios.ACFormatearGrilla(c1grdBusqueda, 1, 1, 4, 1, 1)
            'ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, _index, "Linea", "Linea", "Linea", 150, False, False, "System.String", "") : _index += 1
            ' ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, _index, "SubLinea", "SubLinea", "SubLinea", 150, False, False, "System.String", "") : _index += 1
            ' ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, _index, "Orden", "Orden", "Orden", 40, True, False, "System.Integer", "") : _index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, _index, "Código", "ARTIC_Codigo", "ARTIC_Codigo", 70, True, False, "System.String", "") : _index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, _index, "Descripción", "ARTIC_Descripcion", "ARTIC_Descripcion", 500, True, False, "System.String", "") : _index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, _index, "Stock", "STINI_Cantidad", "STINI_Cantidad", 90, True, False, "System.Decimal", Parametros.GetParametro(EParametros.TipoParametros.pg_FMondo2d)) : _index += 1

            c1grdBusqueda.AllowEditing = False
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
            c1grdBusqueda.AllowEditing = False
            c1grdBusqueda.Cols(0).WidthDisplay \= 3
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#End Region
  # Region " Cargar Datos "
   Private Sub bs_Periodos_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
      Try
         Me.KeyPreview = True
        
            dtpFecha.Value = New DateTime((cmbPeriodo.SelectedValue)-1, 12, 31)
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso Cargar Sub Lineas", ex)
      End Try
   End Sub
#End Region


#Region " Metodos de Controles"


   Private Sub tsbtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnSalir.Click
      Me.Close()
   End Sub

   Private Sub btnCargar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCargar.Click
     
      Try
        

        
         Dim _fecha As Date
         If dtpFecha.Checked Then
            _fecha = dtpFecha.Value
         Else
            _fecha = Nothing
         End If

         If managerStockIniciales.LOG_STOCKSINI_StockALaUltimaFecha( GApp.Periodo, GApp.Almacen, GApp.Zona, _fecha) Then
           ' Dim _orden As Integer = 1
           '' Dim _linea As String = m_reporte.Rows(0)("SubLinea")
           ' For Each Item As DataRow In m_reporte.Rows
           '    ''Item("Codigo") = Regex.Replace(Item("Codigo"), "^(\d{2})(\d{2})(\d{3})$", "$1.$2.$3")
           '    'If Not Item("SubLinea").Equals(_linea) Then
           '    '   _linea = Item("SubLinea")
           '       _orden = 1
           '    'End If
           '    Item("Orden") = _orden
           '    _orden += 1
           ' Nexts
            bs_reporte = New BindingSource()
            bs_reporte.DataSource = managerStockIniciales.ListArticulos
            c1grdBusqueda.DataSource = bs_reporte
            bnavNavievador.BindingSource = bs_reporte
    
         End If
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso cargar datos del Reporte", ex)
      End Try
   End Sub


#End Region

 
Private Sub CStocksIniciales_Load( sender As Object,  e As EventArgs) Handles MyBase.Load

End Sub

Private Sub btnCargarStockInicial_Click( sender As Object,  e As EventArgs) Handles btnCargarStockInicial.Click
  
      Try
        
         Dim _fecha As Date
         If dtpFecha.Checked Then
            _fecha = dtpFecha.Value
         Else
            _fecha = Nothing
         End If

         If managerStockIniciales.LOG_STOCKSINI_StockALaUltimaFecha( GApp.Periodo, GApp.Almacen, GApp.Zona, _fecha) Then
           ' Dim _orden As Integer = 1
           '' Dim _linea As String = m_reporte.Rows(0)("SubLinea")
           ' For Each Item As DataRow In m_reporte.Rows
           '    ''Item("Codigo") = Regex.Replace(Item("Codigo"), "^(\d{2})(\d{2})(\d{3})$", "$1.$2.$3")
           '    'If Not Item("SubLinea").Equals(_linea) Then
           '    '   _linea = Item("SubLinea")
           '       _orden = 1
           '    'End If
           '    Item("Orden") = _orden
           '    _orden += 1
           ' Next
            bs_reporte = New BindingSource()
            bs_reporte.DataSource = m_reporteStockInicial
            c1grdBusqueda.DataSource = bs_reporte
            bnavNavievador.BindingSource = bs_reporte
    
         End If
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso cargar datos del Reporte", ex)
      End Try
End Sub

Private Sub btnGrabarStockInicial_Click( sender As Object,  e As EventArgs) Handles btnGrabarStockInicial.Click
  Try
         If ACControles.ACDialogos.ACMostrarMensajePregunta(String.Format("Guardar Registro: {0}", Me.Text) _
                                     , "¿Desea guardar el stock inicial de los Articulos?" _
                                     , ACControles.ACDialogos.LabelBotom.Si_No) = DialogResult.Yes Then
               
            If managerStockIniciales.Grabar(GApp.Usuario,cmbPeriodo.SelectedValue,GApp.Almacen) Then
               ACControles.ACDialogos.ACMostrarMensajeSatisfactorio(String.Format("Información: {0}", Me.Text), "Grabado satisfactoriamente")
                   
            End If
         End If
        ' btnCargar_Click(Nothing, Nothing)
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), String.Format(Colecciones.getError("00101"), "Grabar Stock Inicial"), ex )
      End Try
End Sub
End Class