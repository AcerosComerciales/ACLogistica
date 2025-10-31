<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MCompras
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MCompras))
        Me.actool = New ACControles.ACToolBarMantHorizontalNew(Me.components)
        Me.tsbtnPrevisualizar = New ACControles.ACToolStripButton(Me.components)
        Me.acpnlTitulo = New ACControles.ACPanelCaption()
        Me.tabMantenimiento = New Crownwood.DotNetMagic.Controls.TabControl()
        Me.tabDatos = New Crownwood.DotNetMagic.Controls.TabPage()
        Me.pnlDatos = New System.Windows.Forms.Panel()
        Me.pnlDetalle = New System.Windows.Forms.Panel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.c1grdDetalle = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.bnavProductos = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator13 = New System.Windows.Forms.ToolStripSeparator()
        Me.tbcDetalles = New Crownwood.DotNetMagic.Controls.TabControl()
        Me.tpgAdmin = New Crownwood.DotNetMagic.Controls.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkPaseAnularDocumentos = New System.Windows.Forms.CheckBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbtnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator24 = New System.Windows.Forms.ToolStripSeparator()
        Me.tpgDetAnulacion = New Crownwood.DotNetMagic.Controls.TabPage()
        Me.chkAnuladoCaja = New System.Windows.Forms.CheckBox()
        Me.txtMotivoAnulacion = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dtpFechaAnulacion = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tpgAdicionales = New Crownwood.DotNetMagic.Controls.TabPage()
        Me.dtpFecImpresion = New System.Windows.Forms.DateTimePicker()
        Me.dtpHoraImpresion = New System.Windows.Forms.DateTimePicker()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.dtpFecCreacion = New System.Windows.Forms.DateTimePicker()
        Me.dtpHoraCreacion = New System.Windows.Forms.DateTimePicker()
        Me.actxaDescFacturador = New ACControles.ACTextBoxAyuda()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.actxaCodCotizador = New ACControles.ACTextBoxAyuda()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.chkRevisionCaja = New System.Windows.Forms.CheckBox()
        Me.chkAnulada = New System.Windows.Forms.CheckBox()
        Me.txtCotizacionC = New System.Windows.Forms.TextBox()
        Me.chkStockDevuelto = New System.Windows.Forms.CheckBox()
        Me.txtTelFax = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.actxaDescCotizador = New ACControles.ACTextBoxAyuda()
        Me.chkPendiente = New System.Windows.Forms.CheckBox()
        Me.txtDirigida = New System.Windows.Forms.TextBox()
        Me.actxaCodFacturador = New ACControles.ACTextBoxAyuda()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tpgGuias = New Crownwood.DotNetMagic.Controls.TabPage()
        Me.c1grdGuiasRemision = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.bnavGuiasRemision = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripButton19 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton20 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton21 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton22 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox4 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton23 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton24 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator12 = New System.Windows.Forms.ToolStripSeparator()
        Me.tpgOrden = New Crownwood.DotNetMagic.Controls.TabPage()
        Me.c1grdOrdenes = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.bnavOrdenes = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripButton13 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton14 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton15 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton16 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox3 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton17 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton18 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.tpgPagos = New Crownwood.DotNetMagic.Controls.TabPage()
        Me.c1grdPagos = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.bnavPagos = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripButton25 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel7 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton26 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton31 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton32 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator17 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox6 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator18 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton33 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton34 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator19 = New System.Windows.Forms.ToolStripSeparator()
        Me.AcPanelCaption2 = New ACControles.ACPanelCaption()
        Me.tpgPendiente = New Crownwood.DotNetMagic.Controls.TabPage()
        Me.c1grdPendientes = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.AcPanelCaption1 = New ACControles.ACPanelCaption()
        Me.bnavNotas = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripButton35 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel8 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton36 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton37 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton38 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator20 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox7 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator21 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton39 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton40 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator22 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator23 = New System.Windows.Forms.ToolStripSeparator()
        Me.tpgNotas = New Crownwood.DotNetMagic.Controls.TabPage()
        Me.c1grdNotasCredito = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton8 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton9 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton10 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox2 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton11 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton12 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.tpgLetras = New Crownwood.DotNetMagic.Controls.TabPage()
        Me.c1grdLetras = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.bnavLetras = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripLabel6 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton27 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton28 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator14 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox5 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator15 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton29 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton30 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator16 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnAddLetra = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnQuitLetra = New System.Windows.Forms.ToolStripButton()
        Me.tpgCheques = New Crownwood.DotNetMagic.Controls.TabPage()
        Me.tpgAlmacen = New Crownwood.DotNetMagic.Controls.TabPage()
        Me.c1grdAlmacen = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.AcPanelCaption3 = New ACControles.ACPanelCaption()
        Me.BindingNavigator2 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripButton41 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel9 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton42 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton43 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton44 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator25 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox8 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator26 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton45 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton46 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator27 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator28 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnAnularEntregaAlmacen = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnAnularTodoEntregaAlmacen = New System.Windows.Forms.ToolStripButton()
        Me.pnlPie = New System.Windows.Forms.Panel()
        Me.grpDetalleDocumento = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.pnlDetProductos = New System.Windows.Forms.Panel()
        Me.actxnFlete = New ACControles.ACTextBoxNumerico()
        Me.actxnGastos = New ACControles.ACTextBoxNumerico()
        Me.actxnDescuento = New ACControles.ACTextBoxNumerico()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.actxnPDetraccion = New ACControles.ACTextBoxNumerico()
        Me.lblPDetraccion = New System.Windows.Forms.Label()
        Me.actxnDetraccionSoles = New ACControles.ACTextBoxNumerico()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.actxnPRetencion = New ACControles.ACTextBoxNumerico()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.actxnRetencionSoles = New ACControles.ACTextBoxNumerico()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.actxnPercepcionSoles = New ACControles.ACTextBoxNumerico()
        Me.actxnPesoTotal = New ACControles.ACTextBoxNumerico()
        Me.actxnPercepcionMO = New ACControles.ACTextBoxNumerico()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.actxnAfectoPercepcionSoles = New ACControles.ACTextBoxNumerico()
        Me.actxnAfectoPercepcionMO = New ACControles.ACTextBoxNumerico()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.grpDetPago = New System.Windows.Forms.GroupBox()
        Me.lblDetraccion = New System.Windows.Forms.Label()
        Me.actxnVDetraccion = New ACControles.ACTextBoxNumerico()
        Me.lblRetencion = New System.Windows.Forms.Label()
        Me.actxnVRetencion = New ACControles.ACTextBoxNumerico()
        Me.lblVPercepcion = New System.Windows.Forms.Label()
        Me.lblImporte = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lbligv = New System.Windows.Forms.Label()
        Me.lblTotalPagar = New System.Windows.Forms.Label()
        Me.actxnImporte = New ACControles.ACTextBoxNumerico()
        Me.actxnIGV = New ACControles.ACTextBoxNumerico()
        Me.actxnTotalPagar = New ACControles.ACTextBoxNumerico()
        Me.actxnTotal = New ACControles.ACTextBoxNumerico()
        Me.actxnPercepcion = New ACControles.ACTextBoxNumerico()
        Me.pnlCabecera = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.actxaCliRazonSocial = New ACControles.ACTextBoxAyuda()
        Me.cmbCondPago = New System.Windows.Forms.ComboBox()
        Me.pnlCabHeader = New System.Windows.Forms.Panel()
        Me.grpDocumento = New System.Windows.Forms.GroupBox()
        Me.txtSerie = New System.Windows.Forms.TextBox()
        Me.actxnNumero = New ACControles.ACTextBoxNumerico()
        Me.cmbDocumento = New System.Windows.Forms.ComboBox()
        Me.txtOrdenCompra = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.dtpFecCaja = New System.Windows.Forms.DateTimePicker()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.dtpFecEmision = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.actxaCliRuc = New ACControles.ACTextBoxAyuda()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblMoneda = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbMoneda = New System.Windows.Forms.ComboBox()
        Me.dtpFecPlazo = New System.Windows.Forms.DateTimePicker()
        Me.actxnPlazo = New ACControles.ACTextBoxNumerico()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.actxnTCVentaSunat = New ACControles.ACTextBoxNumerico()
        Me.actxnTipoCambio = New ACControles.ACTextBoxNumerico()
        Me.lblVenDolarSunat = New System.Windows.Forms.Label()
        Me.tabBusqueda = New Crownwood.DotNetMagic.Controls.TabPage()
        Me.c1grdBusqueda = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.grpBusqueda = New System.Windows.Forms.GroupBox()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.rbtnNroDocumento = New System.Windows.Forms.RadioButton()
        Me.rbtnProveedor = New System.Windows.Forms.RadioButton()
        Me.grpCliente = New System.Windows.Forms.GroupBox()
        Me.txtBusqueda = New ACControles.ACTextBoxAyuda()
        Me.grpDocumentos = New System.Windows.Forms.GroupBox()
        Me.txtBusSerie = New System.Windows.Forms.TextBox()
        Me.cmbTipoDocumento = New System.Windows.Forms.ComboBox()
        Me.txtBusNumero = New ACControles.ACTextBoxAyuda()
        Me.chkTodos = New System.Windows.Forms.CheckBox()
        Me.AcFecha = New ACControles.ACFecha(Me.components)
        Me.bnavBusqueda = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.actool.SuspendLayout()
        Me.tabMantenimiento.SuspendLayout()
        Me.tabDatos.SuspendLayout()
        Me.pnlDatos.SuspendLayout()
        Me.pnlDetalle.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.c1grdDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bnavProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bnavProductos.SuspendLayout()
        Me.tbcDetalles.SuspendLayout()
        Me.tpgAdmin.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.tpgDetAnulacion.SuspendLayout()
        Me.tpgAdicionales.SuspendLayout()
        Me.tpgGuias.SuspendLayout()
        CType(Me.c1grdGuiasRemision, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bnavGuiasRemision, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bnavGuiasRemision.SuspendLayout()
        Me.tpgOrden.SuspendLayout()
        CType(Me.c1grdOrdenes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bnavOrdenes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bnavOrdenes.SuspendLayout()
        Me.tpgPagos.SuspendLayout()
        CType(Me.c1grdPagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bnavPagos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bnavPagos.SuspendLayout()
        Me.tpgPendiente.SuspendLayout()
        CType(Me.c1grdPendientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bnavNotas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bnavNotas.SuspendLayout()
        Me.tpgNotas.SuspendLayout()
        CType(Me.c1grdNotasCredito, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.tpgLetras.SuspendLayout()
        CType(Me.c1grdLetras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bnavLetras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bnavLetras.SuspendLayout()
        Me.tpgAlmacen.SuspendLayout()
        CType(Me.c1grdAlmacen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator2.SuspendLayout()
        Me.pnlPie.SuspendLayout()
        Me.grpDetalleDocumento.SuspendLayout()
        Me.pnlDetProductos.SuspendLayout()
        Me.grpDetPago.SuspendLayout()
        Me.pnlCabecera.SuspendLayout()
        Me.pnlCabHeader.SuspendLayout()
        Me.grpDocumento.SuspendLayout()
        Me.tabBusqueda.SuspendLayout()
        CType(Me.c1grdBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpBusqueda.SuspendLayout()
        Me.grpCliente.SuspendLayout()
        Me.grpDocumentos.SuspendLayout()
        CType(Me.bnavBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bnavBusqueda.SuspendLayout()
        Me.SuspendLayout()
        '
        'actool
        '
        Me.actool.ACBtnBuscarEnabled = False
        Me.actool.ACBtnBuscarVisible = False
        Me.actool.ACBtnCancelarEnabled = False
        Me.actool.ACBtnCancelarVisible = False
        Me.actool.ACBtnEliminarEnabled = False
        Me.actool.ACBtnEliminarVisible = False
        Me.actool.ACBtnGrabarEnabled = False
        Me.actool.ACBtnGrabarVisible = False
        Me.actool.ACBtnImprimirEnabled = False
        Me.actool.ACBtnImprimirVisible = False
        Me.actool.ACBtnNuevoEnabled = False
        Me.actool.ACBtnNuevoVisible = False
        Me.actool.ACBtnRehusarEnabled = False
        Me.actool.ACBtnRehusarVisible = False
        Me.actool.ACBtnReporteEnabled = False
        Me.actool.ACBtnReporteVisible = False
        Me.actool.ACBtnSalirEnabled = False
        Me.actool.ACBtnSalirText = "&Salir"
        Me.actool.ACBtnSalirVisible = False
        Me.actool.ACBtnVolverEnabled = False
        Me.actool.ACBtnVolverVisible = False
        Me.actool.ACTipoToolBar = ACControles.ACToolBarMantHorizontalNew.tipoToolBar.ToolGrabarAnular
        Me.actool.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.actool.Font = New System.Drawing.Font("Tahoma", 9.5!)
        Me.actool.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.actool.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbtnPrevisualizar})
        Me.actool.Location = New System.Drawing.Point(0, 569)
        Me.actool.Name = "actool"
        Me.actool.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.actool.Size = New System.Drawing.Size(1138, 56)
        Me.actool.TabIndex = 15
        Me.actool.Text = "AcToolBarMantHorizontalNew1"
        '
        'tsbtnPrevisualizar
        '
        Me.tsbtnPrevisualizar.AutoSize = False
        Me.tsbtnPrevisualizar.Image = Global.ACPLogistica.My.Resources.Resources.Buscar2_32x32
        Me.tsbtnPrevisualizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.tsbtnPrevisualizar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbtnPrevisualizar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnPrevisualizar.Name = "tsbBoton"
        Me.tsbtnPrevisualizar.Size = New System.Drawing.Size(84, 53)
        Me.tsbtnPrevisualizar.Text = "Revisar"
        Me.tsbtnPrevisualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.tsbtnPrevisualizar.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        Me.tsbtnPrevisualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'acpnlTitulo
        '
        Me.acpnlTitulo.ACCaption = "Documentos de Compra"
        Me.acpnlTitulo.ActiveGradientHighColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.acpnlTitulo.ActiveGradientLowColor = System.Drawing.Color.Maroon
        Me.acpnlTitulo.ActiveTextColor = System.Drawing.Color.White
        Me.acpnlTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.acpnlTitulo.Font = New System.Drawing.Font("Tahoma", 15.0!, System.Drawing.FontStyle.Bold)
        Me.acpnlTitulo.Location = New System.Drawing.Point(0, 0)
        Me.acpnlTitulo.Name = "acpnlTitulo"
        Me.acpnlTitulo.Size = New System.Drawing.Size(1138, 29)
        Me.acpnlTitulo.TabIndex = 16
        '
        'tabMantenimiento
        '
        Me.tabMantenimiento.BackColor = System.Drawing.Color.LightSteelBlue
        Me.tabMantenimiento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabMantenimiento.Location = New System.Drawing.Point(0, 29)
        Me.tabMantenimiento.MediaPlayerDockSides = False
        Me.tabMantenimiento.Name = "tabMantenimiento"
        Me.tabMantenimiento.OfficeDockSides = False
        Me.tabMantenimiento.SelectedIndex = 1
        Me.tabMantenimiento.ShowDropSelect = False
        Me.tabMantenimiento.Size = New System.Drawing.Size(1138, 540)
        Me.tabMantenimiento.TabIndex = 17
        Me.tabMantenimiento.TabPages.AddRange(New Crownwood.DotNetMagic.Controls.TabPage() {Me.tabDatos, Me.tabBusqueda})
        Me.tabMantenimiento.TextTips = True
        '
        'tabDatos
        '
        Me.tabDatos.Controls.Add(Me.pnlDatos)
        Me.tabDatos.InactiveBackColor = System.Drawing.Color.Empty
        Me.tabDatos.InactiveTextBackColor = System.Drawing.Color.Empty
        Me.tabDatos.InactiveTextColor = System.Drawing.Color.Empty
        Me.tabDatos.Location = New System.Drawing.Point(1, 1)
        Me.tabDatos.Name = "tabDatos"
        Me.tabDatos.SelectBackColor = System.Drawing.Color.Empty
        Me.tabDatos.Selected = False
        Me.tabDatos.SelectTextBackColor = System.Drawing.Color.Empty
        Me.tabDatos.SelectTextColor = System.Drawing.Color.Empty
        Me.tabDatos.Size = New System.Drawing.Size(1136, 515)
        Me.tabDatos.TabIndex = 4
        Me.tabDatos.Title = "Datos"
        Me.tabDatos.ToolTip = "Datos"
        '
        'pnlDatos
        '
        Me.pnlDatos.Controls.Add(Me.pnlDetalle)
        Me.pnlDatos.Controls.Add(Me.pnlPie)
        Me.pnlDatos.Controls.Add(Me.pnlCabecera)
        Me.pnlDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDatos.Location = New System.Drawing.Point(0, 0)
        Me.pnlDatos.Name = "pnlDatos"
        Me.pnlDatos.Size = New System.Drawing.Size(1136, 515)
        Me.pnlDatos.TabIndex = 1
        '
        'pnlDetalle
        '
        Me.pnlDetalle.Controls.Add(Me.SplitContainer1)
        Me.pnlDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDetalle.Location = New System.Drawing.Point(0, 126)
        Me.pnlDetalle.Name = "pnlDetalle"
        Me.pnlDetalle.Size = New System.Drawing.Size(1136, 206)
        Me.pnlDetalle.TabIndex = 5
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.c1grdDetalle)
        Me.SplitContainer1.Panel1.Controls.Add(Me.bnavProductos)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.tbcDetalles)
        Me.SplitContainer1.Size = New System.Drawing.Size(1136, 206)
        Me.SplitContainer1.SplitterDistance = 582
        Me.SplitContainer1.TabIndex = 3
        '
        'c1grdDetalle
        '
        Me.c1grdDetalle.BackColor = System.Drawing.Color.White
        Me.c1grdDetalle.ColumnInfo = "2,1,0,0,0,100,Columns:0{Width:18;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:107;Caption:""Codigo"";}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.c1grdDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.c1grdDetalle.Location = New System.Drawing.Point(0, 0)
        Me.c1grdDetalle.Name = "c1grdDetalle"
        Me.c1grdDetalle.Rows.Count = 2
        Me.c1grdDetalle.Rows.DefaultSize = 20
        Me.c1grdDetalle.Size = New System.Drawing.Size(582, 181)
        Me.c1grdDetalle.StyleInfo = resources.GetString("c1grdDetalle.StyleInfo")
        Me.c1grdDetalle.TabIndex = 1
        '
        'bnavProductos
        '
        Me.bnavProductos.AddNewItem = Me.ToolStripButton1
        Me.bnavProductos.CountItem = Me.ToolStripLabel1
        Me.bnavProductos.DeleteItem = Me.ToolStripButton2
        Me.bnavProductos.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.bnavProductos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripSeparator1, Me.ToolStripTextBox1, Me.ToolStripLabel1, Me.ToolStripSeparator2, Me.ToolStripButton5, Me.ToolStripButton6, Me.ToolStripSeparator3, Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripSeparator13})
        Me.bnavProductos.Location = New System.Drawing.Point(0, 181)
        Me.bnavProductos.MoveFirstItem = Me.ToolStripButton3
        Me.bnavProductos.MoveLastItem = Me.ToolStripButton6
        Me.bnavProductos.MoveNextItem = Me.ToolStripButton5
        Me.bnavProductos.MovePreviousItem = Me.ToolStripButton4
        Me.bnavProductos.Name = "bnavProductos"
        Me.bnavProductos.PositionItem = Me.ToolStripTextBox1
        Me.bnavProductos.Size = New System.Drawing.Size(582, 25)
        Me.bnavProductos.TabIndex = 2
        Me.bnavProductos.Text = "BindingNavigator1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "Add new"
        Me.ToolStripButton1.Visible = False
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(35, 22)
        Me.ToolStripLabel1.Text = "of {0}"
        Me.ToolStripLabel1.ToolTipText = "Total number of items"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "Delete"
        Me.ToolStripButton2.Visible = False
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton3.Text = "Move first"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton4.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton4.Text = "Move previous"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.AccessibleName = "Position"
        Me.ToolStripTextBox1.AutoSize = False
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(50, 21)
        Me.ToolStripTextBox1.Text = "0"
        Me.ToolStripTextBox1.ToolTipText = "Current position"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton5.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton5.Text = "Move next"
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"), System.Drawing.Image)
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton6.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton6.Text = "Move last"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator13
        '
        Me.ToolStripSeparator13.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator13.Name = "ToolStripSeparator13"
        Me.ToolStripSeparator13.Size = New System.Drawing.Size(6, 25)
        '
        'tbcDetalles
        '
        Me.tbcDetalles.BackColor = System.Drawing.Color.LightSteelBlue
        Me.tbcDetalles.BoldSelectedPage = True
        Me.tbcDetalles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbcDetalles.Location = New System.Drawing.Point(0, 0)
        Me.tbcDetalles.MediaPlayerDockSides = False
        Me.tbcDetalles.Name = "tbcDetalles"
        Me.tbcDetalles.OfficeDockSides = False
        Me.tbcDetalles.PositionTop = True
        Me.tbcDetalles.SelectedIndex = 2
        Me.tbcDetalles.ShowArrows = True
        Me.tbcDetalles.ShowDropSelect = False
        Me.tbcDetalles.Size = New System.Drawing.Size(550, 206)
        Me.tbcDetalles.TabIndex = 12
        Me.tbcDetalles.TabPages.AddRange(New Crownwood.DotNetMagic.Controls.TabPage() {Me.tpgAdmin, Me.tpgDetAnulacion, Me.tpgAdicionales, Me.tpgGuias, Me.tpgOrden, Me.tpgPagos, Me.tpgPendiente, Me.tpgNotas, Me.tpgLetras, Me.tpgCheques, Me.tpgAlmacen})
        Me.tbcDetalles.TextTips = True
        '
        'tpgAdmin
        '
        Me.tpgAdmin.Controls.Add(Me.GroupBox2)
        Me.tpgAdmin.InactiveBackColor = System.Drawing.Color.Empty
        Me.tpgAdmin.InactiveTextBackColor = System.Drawing.Color.Empty
        Me.tpgAdmin.InactiveTextColor = System.Drawing.Color.Empty
        Me.tpgAdmin.Location = New System.Drawing.Point(1, 24)
        Me.tpgAdmin.Name = "tpgAdmin"
        Me.tpgAdmin.SelectBackColor = System.Drawing.Color.Empty
        Me.tpgAdmin.Selected = False
        Me.tpgAdmin.SelectTextBackColor = System.Drawing.Color.Empty
        Me.tpgAdmin.SelectTextColor = System.Drawing.Color.Empty
        Me.tpgAdmin.Size = New System.Drawing.Size(548, 181)
        Me.tpgAdmin.TabIndex = 13
        Me.tpgAdmin.Title = "Administración"
        Me.tpgAdmin.ToolTip = "Administración"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkPaseAnularDocumentos)
        Me.GroupBox2.Controls.Add(Me.ToolStrip1)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(548, 125)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Documento de Compra"
        '
        'chkPaseAnularDocumentos
        '
        Me.chkPaseAnularDocumentos.AutoSize = True
        Me.chkPaseAnularDocumentos.Enabled = False
        Me.chkPaseAnularDocumentos.Location = New System.Drawing.Point(6, 22)
        Me.chkPaseAnularDocumentos.Name = "chkPaseAnularDocumentos"
        Me.chkPaseAnularDocumentos.Size = New System.Drawing.Size(220, 19)
        Me.chkPaseAnularDocumentos.TabIndex = 23
        Me.chkPaseAnularDocumentos.Text = "Permitir Anular Documento de Venta"
        Me.chkPaseAnularDocumentos.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbtnGuardar, Me.ToolStripSeparator24})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 97)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(542, 25)
        Me.ToolStrip1.TabIndex = 21
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsbtnGuardar
        '
        Me.tsbtnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnGuardar.Name = "tsbtnGuardar"
        Me.tsbtnGuardar.Size = New System.Drawing.Size(53, 22)
        Me.tsbtnGuardar.Text = "Guardar"
        '
        'ToolStripSeparator24
        '
        Me.ToolStripSeparator24.Name = "ToolStripSeparator24"
        Me.ToolStripSeparator24.Size = New System.Drawing.Size(6, 25)
        '
        'tpgDetAnulacion
        '
        Me.tpgDetAnulacion.Controls.Add(Me.chkAnuladoCaja)
        Me.tpgDetAnulacion.Controls.Add(Me.txtMotivoAnulacion)
        Me.tpgDetAnulacion.Controls.Add(Me.Label10)
        Me.tpgDetAnulacion.Controls.Add(Me.dtpFechaAnulacion)
        Me.tpgDetAnulacion.Controls.Add(Me.Label2)
        Me.tpgDetAnulacion.InactiveBackColor = System.Drawing.Color.Empty
        Me.tpgDetAnulacion.InactiveTextBackColor = System.Drawing.Color.Empty
        Me.tpgDetAnulacion.InactiveTextColor = System.Drawing.Color.Empty
        Me.tpgDetAnulacion.Location = New System.Drawing.Point(1, 24)
        Me.tpgDetAnulacion.Name = "tpgDetAnulacion"
        Me.tpgDetAnulacion.SelectBackColor = System.Drawing.Color.Empty
        Me.tpgDetAnulacion.Selected = False
        Me.tpgDetAnulacion.SelectTextBackColor = System.Drawing.Color.Empty
        Me.tpgDetAnulacion.SelectTextColor = System.Drawing.Color.Empty
        Me.tpgDetAnulacion.Size = New System.Drawing.Size(548, 181)
        Me.tpgDetAnulacion.TabIndex = 9
        Me.tpgDetAnulacion.Title = "Det. Anulación"
        Me.tpgDetAnulacion.ToolTip = "Detalle Anulación"
        '
        'chkAnuladoCaja
        '
        Me.chkAnuladoCaja.AutoSize = True
        Me.chkAnuladoCaja.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkAnuladoCaja.Location = New System.Drawing.Point(179, 11)
        Me.chkAnuladoCaja.Name = "chkAnuladoCaja"
        Me.chkAnuladoCaja.Size = New System.Drawing.Size(211, 19)
        Me.chkAnuladoCaja.TabIndex = 41
        Me.chkAnuladoCaja.Tag = "EO"
        Me.chkAnuladoCaja.Text = "Anulado Despues de la Facturacion"
        Me.chkAnuladoCaja.UseVisualStyleBackColor = True
        '
        'txtMotivoAnulacion
        '
        Me.txtMotivoAnulacion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMotivoAnulacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMotivoAnulacion.Location = New System.Drawing.Point(70, 40)
        Me.txtMotivoAnulacion.Multiline = True
        Me.txtMotivoAnulacion.Name = "txtMotivoAnulacion"
        Me.txtMotivoAnulacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMotivoAnulacion.Size = New System.Drawing.Size(468, 83)
        Me.txtMotivoAnulacion.TabIndex = 40
        Me.txtMotivoAnulacion.Tag = "EV"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 42)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 15)
        Me.Label10.TabIndex = 39
        Me.Label10.Text = "Motivo :"
        '
        'dtpFechaAnulacion
        '
        Me.dtpFechaAnulacion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaAnulacion.Location = New System.Drawing.Point(70, 9)
        Me.dtpFechaAnulacion.Name = "dtpFechaAnulacion"
        Me.dtpFechaAnulacion.Size = New System.Drawing.Size(96, 23)
        Me.dtpFechaAnulacion.TabIndex = 26
        Me.dtpFechaAnulacion.Tag = "E"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 15)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Fecha :"
        '
        'tpgAdicionales
        '
        Me.tpgAdicionales.Controls.Add(Me.dtpFecImpresion)
        Me.tpgAdicionales.Controls.Add(Me.dtpHoraImpresion)
        Me.tpgAdicionales.Controls.Add(Me.Label17)
        Me.tpgAdicionales.Controls.Add(Me.dtpFecCreacion)
        Me.tpgAdicionales.Controls.Add(Me.dtpHoraCreacion)
        Me.tpgAdicionales.Controls.Add(Me.actxaDescFacturador)
        Me.tpgAdicionales.Controls.Add(Me.Label14)
        Me.tpgAdicionales.Controls.Add(Me.actxaCodCotizador)
        Me.tpgAdicionales.Controls.Add(Me.Label18)
        Me.tpgAdicionales.Controls.Add(Me.chkRevisionCaja)
        Me.tpgAdicionales.Controls.Add(Me.chkAnulada)
        Me.tpgAdicionales.Controls.Add(Me.txtCotizacionC)
        Me.tpgAdicionales.Controls.Add(Me.chkStockDevuelto)
        Me.tpgAdicionales.Controls.Add(Me.txtTelFax)
        Me.tpgAdicionales.Controls.Add(Me.Label8)
        Me.tpgAdicionales.Controls.Add(Me.Label28)
        Me.tpgAdicionales.Controls.Add(Me.actxaDescCotizador)
        Me.tpgAdicionales.Controls.Add(Me.chkPendiente)
        Me.tpgAdicionales.Controls.Add(Me.txtDirigida)
        Me.tpgAdicionales.Controls.Add(Me.actxaCodFacturador)
        Me.tpgAdicionales.Controls.Add(Me.Label7)
        Me.tpgAdicionales.Controls.Add(Me.Label11)
        Me.tpgAdicionales.InactiveBackColor = System.Drawing.Color.Empty
        Me.tpgAdicionales.InactiveTextBackColor = System.Drawing.Color.Empty
        Me.tpgAdicionales.InactiveTextColor = System.Drawing.Color.Empty
        Me.tpgAdicionales.Location = New System.Drawing.Point(1, 24)
        Me.tpgAdicionales.Name = "tpgAdicionales"
        Me.tpgAdicionales.SelectBackColor = System.Drawing.Color.Empty
        Me.tpgAdicionales.SelectTextBackColor = System.Drawing.Color.Empty
        Me.tpgAdicionales.SelectTextColor = System.Drawing.Color.Empty
        Me.tpgAdicionales.Size = New System.Drawing.Size(548, 181)
        Me.tpgAdicionales.TabIndex = 11
        Me.tpgAdicionales.Title = "Adicionales"
        Me.tpgAdicionales.ToolTip = "Datos Adicionales"
        '
        'dtpFecImpresion
        '
        Me.dtpFecImpresion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecImpresion.Location = New System.Drawing.Point(157, 82)
        Me.dtpFecImpresion.Name = "dtpFecImpresion"
        Me.dtpFecImpresion.Size = New System.Drawing.Size(96, 23)
        Me.dtpFecImpresion.TabIndex = 54
        Me.dtpFecImpresion.Tag = "E"
        '
        'dtpHoraImpresion
        '
        Me.dtpHoraImpresion.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpHoraImpresion.Location = New System.Drawing.Point(259, 82)
        Me.dtpHoraImpresion.Name = "dtpHoraImpresion"
        Me.dtpHoraImpresion.Size = New System.Drawing.Size(96, 23)
        Me.dtpHoraImpresion.TabIndex = 53
        Me.dtpHoraImpresion.Tag = "E"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(13, 88)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(138, 15)
        Me.Label17.TabIndex = 52
        Me.Label17.Text = "Ultima Fecha Impresión :"
        '
        'dtpFecCreacion
        '
        Me.dtpFecCreacion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecCreacion.Location = New System.Drawing.Point(112, 55)
        Me.dtpFecCreacion.Name = "dtpFecCreacion"
        Me.dtpFecCreacion.Size = New System.Drawing.Size(96, 23)
        Me.dtpFecCreacion.TabIndex = 51
        Me.dtpFecCreacion.Tag = "E"
        '
        'dtpHoraCreacion
        '
        Me.dtpHoraCreacion.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpHoraCreacion.Location = New System.Drawing.Point(214, 55)
        Me.dtpHoraCreacion.Name = "dtpHoraCreacion"
        Me.dtpHoraCreacion.Size = New System.Drawing.Size(96, 23)
        Me.dtpHoraCreacion.TabIndex = 31
        Me.dtpHoraCreacion.Tag = "E"
        '
        'actxaDescFacturador
        '
        Me.actxaDescFacturador.ACActivarAyuda = False
        Me.actxaDescFacturador.ACActivarAyudaAuto = False
        Me.actxaDescFacturador.ACLongitudAceptada = 0
        Me.actxaDescFacturador.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.actxaDescFacturador.Location = New System.Drawing.Point(179, 29)
        Me.actxaDescFacturador.MaxLength = 32767
        Me.actxaDescFacturador.Name = "actxaDescFacturador"
        Me.actxaDescFacturador.ReadOnly = True
        Me.actxaDescFacturador.Size = New System.Drawing.Size(362, 23)
        Me.actxaDescFacturador.TabIndex = 50
        Me.actxaDescFacturador.Tag = "EVO"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(11, 59)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(94, 15)
        Me.Label14.TabIndex = 29
        Me.Label14.Text = "Fecha Creación :"
        '
        'actxaCodCotizador
        '
        Me.actxaCodCotizador.ACActivarAyuda = False
        Me.actxaCodCotizador.ACActivarAyudaAuto = False
        Me.actxaCodCotizador.ACLongitudAceptada = 0
        Me.actxaCodCotizador.Location = New System.Drawing.Point(82, 3)
        Me.actxaCodCotizador.MaxLength = 32767
        Me.actxaCodCotizador.Name = "actxaCodCotizador"
        Me.actxaCodCotizador.ReadOnly = True
        Me.actxaCodCotizador.Size = New System.Drawing.Size(91, 23)
        Me.actxaCodCotizador.TabIndex = 49
        Me.actxaCodCotizador.Tag = "EVO"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(11, 34)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(67, 13)
        Me.Label18.TabIndex = 48
        Me.Label18.Text = "Facturador :"
        '
        'chkRevisionCaja
        '
        Me.chkRevisionCaja.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkRevisionCaja.AutoSize = True
        Me.chkRevisionCaja.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkRevisionCaja.Enabled = False
        Me.chkRevisionCaja.Location = New System.Drawing.Point(309, 163)
        Me.chkRevisionCaja.Name = "chkRevisionCaja"
        Me.chkRevisionCaja.Size = New System.Drawing.Size(118, 19)
        Me.chkRevisionCaja.TabIndex = 47
        Me.chkRevisionCaja.Tag = "EO"
        Me.chkRevisionCaja.Text = "Revision de Caja :"
        Me.chkRevisionCaja.UseVisualStyleBackColor = True
        '
        'chkAnulada
        '
        Me.chkAnulada.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkAnulada.AutoSize = True
        Me.chkAnulada.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkAnulada.Enabled = False
        Me.chkAnulada.Location = New System.Drawing.Point(473, 137)
        Me.chkAnulada.Name = "chkAnulada"
        Me.chkAnulada.Size = New System.Drawing.Size(70, 19)
        Me.chkAnulada.TabIndex = 5
        Me.chkAnulada.Tag = "EO"
        Me.chkAnulada.Text = "Anulada"
        Me.chkAnulada.UseVisualStyleBackColor = True
        '
        'txtCotizacionC
        '
        Me.txtCotizacionC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCotizacionC.Location = New System.Drawing.Point(84, 134)
        Me.txtCotizacionC.Name = "txtCotizacionC"
        Me.txtCotizacionC.Size = New System.Drawing.Size(153, 23)
        Me.txtCotizacionC.TabIndex = 42
        Me.txtCotizacionC.Tag = "EV"
        '
        'chkStockDevuelto
        '
        Me.chkStockDevuelto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkStockDevuelto.AutoSize = True
        Me.chkStockDevuelto.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkStockDevuelto.Enabled = False
        Me.chkStockDevuelto.Location = New System.Drawing.Point(432, 163)
        Me.chkStockDevuelto.Name = "chkStockDevuelto"
        Me.chkStockDevuelto.Size = New System.Drawing.Size(111, 19)
        Me.chkStockDevuelto.TabIndex = 25
        Me.chkStockDevuelto.Text = "Stock Devuelto :"
        Me.chkStockDevuelto.UseVisualStyleBackColor = True
        '
        'txtTelFax
        '
        Me.txtTelFax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTelFax.Location = New System.Drawing.Point(75, 159)
        Me.txtTelFax.Name = "txtTelFax"
        Me.txtTelFax.Size = New System.Drawing.Size(110, 23)
        Me.txtTelFax.TabIndex = 40
        Me.txtTelFax.Tag = "EV"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(14, 163)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 15)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "Telf/Fax :"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(9, 137)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(69, 15)
        Me.Label28.TabIndex = 41
        Me.Label28.Text = "Cotizacion :"
        '
        'actxaDescCotizador
        '
        Me.actxaDescCotizador.ACActivarAyuda = False
        Me.actxaDescCotizador.ACActivarAyudaAuto = False
        Me.actxaDescCotizador.ACLongitudAceptada = 0
        Me.actxaDescCotizador.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.actxaDescCotizador.Location = New System.Drawing.Point(179, 3)
        Me.actxaDescCotizador.MaxLength = 32767
        Me.actxaDescCotizador.Name = "actxaDescCotizador"
        Me.actxaDescCotizador.ReadOnly = True
        Me.actxaDescCotizador.Size = New System.Drawing.Size(362, 23)
        Me.actxaDescCotizador.TabIndex = 24
        Me.actxaDescCotizador.Tag = "EVO"
        '
        'chkPendiente
        '
        Me.chkPendiente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkPendiente.AutoSize = True
        Me.chkPendiente.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkPendiente.Enabled = False
        Me.chkPendiente.Location = New System.Drawing.Point(389, 138)
        Me.chkPendiente.Name = "chkPendiente"
        Me.chkPendiente.Size = New System.Drawing.Size(79, 19)
        Me.chkPendiente.TabIndex = 7
        Me.chkPendiente.Tag = "EO"
        Me.chkPendiente.Text = "Pendiente"
        Me.chkPendiente.UseVisualStyleBackColor = True
        '
        'txtDirigida
        '
        Me.txtDirigida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDirigida.Location = New System.Drawing.Point(75, 110)
        Me.txtDirigida.Name = "txtDirigida"
        Me.txtDirigida.Size = New System.Drawing.Size(387, 23)
        Me.txtDirigida.TabIndex = 38
        Me.txtDirigida.Tag = "EV"
        '
        'actxaCodFacturador
        '
        Me.actxaCodFacturador.ACActivarAyuda = False
        Me.actxaCodFacturador.ACActivarAyudaAuto = False
        Me.actxaCodFacturador.ACLongitudAceptada = 0
        Me.actxaCodFacturador.Location = New System.Drawing.Point(82, 29)
        Me.actxaCodFacturador.MaxLength = 32767
        Me.actxaCodFacturador.Name = "actxaCodFacturador"
        Me.actxaCodFacturador.ReadOnly = True
        Me.actxaCodFacturador.Size = New System.Drawing.Size(91, 23)
        Me.actxaCodFacturador.TabIndex = 23
        Me.actxaCodFacturador.Tag = "EVO"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 115)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 15)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "Dirigida :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(11, 7)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(60, 13)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Cotizador :"
        '
        'tpgGuias
        '
        Me.tpgGuias.Controls.Add(Me.c1grdGuiasRemision)
        Me.tpgGuias.Controls.Add(Me.bnavGuiasRemision)
        Me.tpgGuias.InactiveBackColor = System.Drawing.Color.Empty
        Me.tpgGuias.InactiveTextBackColor = System.Drawing.Color.Empty
        Me.tpgGuias.InactiveTextColor = System.Drawing.Color.Empty
        Me.tpgGuias.Location = New System.Drawing.Point(1, 24)
        Me.tpgGuias.Name = "tpgGuias"
        Me.tpgGuias.SelectBackColor = System.Drawing.Color.Empty
        Me.tpgGuias.Selected = False
        Me.tpgGuias.SelectTextBackColor = System.Drawing.Color.Empty
        Me.tpgGuias.SelectTextColor = System.Drawing.Color.Empty
        Me.tpgGuias.Size = New System.Drawing.Size(548, 181)
        Me.tpgGuias.TabIndex = 4
        Me.tpgGuias.Title = "Guias"
        Me.tpgGuias.ToolTip = "Guias de Venta"
        '
        'c1grdGuiasRemision
        '
        Me.c1grdGuiasRemision.BackColor = System.Drawing.Color.White
        Me.c1grdGuiasRemision.ColumnInfo = "2,1,0,0,0,100,Columns:0{Width:18;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:107;Caption:""Codigo"";}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.c1grdGuiasRemision.Dock = System.Windows.Forms.DockStyle.Fill
        Me.c1grdGuiasRemision.Location = New System.Drawing.Point(0, 0)
        Me.c1grdGuiasRemision.Name = "c1grdGuiasRemision"
        Me.c1grdGuiasRemision.Rows.Count = 2
        Me.c1grdGuiasRemision.Rows.DefaultSize = 20
        Me.c1grdGuiasRemision.Size = New System.Drawing.Size(548, 156)
        Me.c1grdGuiasRemision.StyleInfo = resources.GetString("c1grdGuiasRemision.StyleInfo")
        Me.c1grdGuiasRemision.TabIndex = 3
        '
        'bnavGuiasRemision
        '
        Me.bnavGuiasRemision.AddNewItem = Me.ToolStripButton19
        Me.bnavGuiasRemision.CountItem = Me.ToolStripLabel4
        Me.bnavGuiasRemision.DeleteItem = Me.ToolStripButton20
        Me.bnavGuiasRemision.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.bnavGuiasRemision.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton21, Me.ToolStripButton22, Me.ToolStripSeparator10, Me.ToolStripTextBox4, Me.ToolStripLabel4, Me.ToolStripSeparator11, Me.ToolStripButton23, Me.ToolStripButton24, Me.ToolStripSeparator12, Me.ToolStripButton19, Me.ToolStripButton20})
        Me.bnavGuiasRemision.Location = New System.Drawing.Point(0, 156)
        Me.bnavGuiasRemision.MoveFirstItem = Me.ToolStripButton21
        Me.bnavGuiasRemision.MoveLastItem = Me.ToolStripButton24
        Me.bnavGuiasRemision.MoveNextItem = Me.ToolStripButton23
        Me.bnavGuiasRemision.MovePreviousItem = Me.ToolStripButton22
        Me.bnavGuiasRemision.Name = "bnavGuiasRemision"
        Me.bnavGuiasRemision.PositionItem = Me.ToolStripTextBox4
        Me.bnavGuiasRemision.Size = New System.Drawing.Size(548, 25)
        Me.bnavGuiasRemision.TabIndex = 4
        Me.bnavGuiasRemision.Text = "BindingNavigator1"
        '
        'ToolStripButton19
        '
        Me.ToolStripButton19.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton19.Image = CType(resources.GetObject("ToolStripButton19.Image"), System.Drawing.Image)
        Me.ToolStripButton19.Name = "ToolStripButton19"
        Me.ToolStripButton19.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton19.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton19.Text = "Add new"
        Me.ToolStripButton19.Visible = False
        '
        'ToolStripLabel4
        '
        Me.ToolStripLabel4.Name = "ToolStripLabel4"
        Me.ToolStripLabel4.Size = New System.Drawing.Size(35, 22)
        Me.ToolStripLabel4.Text = "of {0}"
        Me.ToolStripLabel4.ToolTipText = "Total number of items"
        '
        'ToolStripButton20
        '
        Me.ToolStripButton20.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton20.Image = CType(resources.GetObject("ToolStripButton20.Image"), System.Drawing.Image)
        Me.ToolStripButton20.Name = "ToolStripButton20"
        Me.ToolStripButton20.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton20.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton20.Text = "Delete"
        Me.ToolStripButton20.Visible = False
        '
        'ToolStripButton21
        '
        Me.ToolStripButton21.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton21.Image = CType(resources.GetObject("ToolStripButton21.Image"), System.Drawing.Image)
        Me.ToolStripButton21.Name = "ToolStripButton21"
        Me.ToolStripButton21.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton21.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton21.Text = "Move first"
        '
        'ToolStripButton22
        '
        Me.ToolStripButton22.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton22.Image = CType(resources.GetObject("ToolStripButton22.Image"), System.Drawing.Image)
        Me.ToolStripButton22.Name = "ToolStripButton22"
        Me.ToolStripButton22.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton22.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton22.Text = "Move previous"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripTextBox4
        '
        Me.ToolStripTextBox4.AccessibleName = "Position"
        Me.ToolStripTextBox4.AutoSize = False
        Me.ToolStripTextBox4.Name = "ToolStripTextBox4"
        Me.ToolStripTextBox4.Size = New System.Drawing.Size(50, 21)
        Me.ToolStripTextBox4.Text = "0"
        Me.ToolStripTextBox4.ToolTipText = "Current position"
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        Me.ToolStripSeparator11.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton23
        '
        Me.ToolStripButton23.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton23.Image = CType(resources.GetObject("ToolStripButton23.Image"), System.Drawing.Image)
        Me.ToolStripButton23.Name = "ToolStripButton23"
        Me.ToolStripButton23.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton23.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton23.Text = "Move next"
        '
        'ToolStripButton24
        '
        Me.ToolStripButton24.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton24.Image = CType(resources.GetObject("ToolStripButton24.Image"), System.Drawing.Image)
        Me.ToolStripButton24.Name = "ToolStripButton24"
        Me.ToolStripButton24.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton24.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton24.Text = "Move last"
        '
        'ToolStripSeparator12
        '
        Me.ToolStripSeparator12.Name = "ToolStripSeparator12"
        Me.ToolStripSeparator12.Size = New System.Drawing.Size(6, 25)
        '
        'tpgOrden
        '
        Me.tpgOrden.Controls.Add(Me.c1grdOrdenes)
        Me.tpgOrden.Controls.Add(Me.bnavOrdenes)
        Me.tpgOrden.InactiveBackColor = System.Drawing.Color.Empty
        Me.tpgOrden.InactiveTextBackColor = System.Drawing.Color.Empty
        Me.tpgOrden.InactiveTextColor = System.Drawing.Color.Empty
        Me.tpgOrden.Location = New System.Drawing.Point(1, 24)
        Me.tpgOrden.Name = "tpgOrden"
        Me.tpgOrden.SelectBackColor = System.Drawing.Color.Empty
        Me.tpgOrden.Selected = False
        Me.tpgOrden.SelectTextBackColor = System.Drawing.Color.Empty
        Me.tpgOrden.SelectTextColor = System.Drawing.Color.Empty
        Me.tpgOrden.Size = New System.Drawing.Size(548, 181)
        Me.tpgOrden.TabIndex = 5
        Me.tpgOrden.Title = "Orden"
        Me.tpgOrden.ToolTip = "Orden"
        '
        'c1grdOrdenes
        '
        Me.c1grdOrdenes.BackColor = System.Drawing.Color.White
        Me.c1grdOrdenes.ColumnInfo = "2,1,0,0,0,100,Columns:0{Width:18;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:107;Caption:""Codigo"";}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.c1grdOrdenes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.c1grdOrdenes.Location = New System.Drawing.Point(0, 0)
        Me.c1grdOrdenes.Name = "c1grdOrdenes"
        Me.c1grdOrdenes.Rows.Count = 2
        Me.c1grdOrdenes.Rows.DefaultSize = 20
        Me.c1grdOrdenes.Size = New System.Drawing.Size(548, 156)
        Me.c1grdOrdenes.StyleInfo = resources.GetString("c1grdOrdenes.StyleInfo")
        Me.c1grdOrdenes.TabIndex = 3
        '
        'bnavOrdenes
        '
        Me.bnavOrdenes.AddNewItem = Me.ToolStripButton13
        Me.bnavOrdenes.CountItem = Me.ToolStripLabel3
        Me.bnavOrdenes.DeleteItem = Me.ToolStripButton14
        Me.bnavOrdenes.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.bnavOrdenes.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton15, Me.ToolStripButton16, Me.ToolStripSeparator7, Me.ToolStripTextBox3, Me.ToolStripLabel3, Me.ToolStripSeparator8, Me.ToolStripButton17, Me.ToolStripButton18, Me.ToolStripSeparator9, Me.ToolStripButton13, Me.ToolStripButton14})
        Me.bnavOrdenes.Location = New System.Drawing.Point(0, 156)
        Me.bnavOrdenes.MoveFirstItem = Me.ToolStripButton15
        Me.bnavOrdenes.MoveLastItem = Me.ToolStripButton18
        Me.bnavOrdenes.MoveNextItem = Me.ToolStripButton17
        Me.bnavOrdenes.MovePreviousItem = Me.ToolStripButton16
        Me.bnavOrdenes.Name = "bnavOrdenes"
        Me.bnavOrdenes.PositionItem = Me.ToolStripTextBox3
        Me.bnavOrdenes.Size = New System.Drawing.Size(548, 25)
        Me.bnavOrdenes.TabIndex = 4
        Me.bnavOrdenes.Text = "BindingNavigator1"
        '
        'ToolStripButton13
        '
        Me.ToolStripButton13.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton13.Image = CType(resources.GetObject("ToolStripButton13.Image"), System.Drawing.Image)
        Me.ToolStripButton13.Name = "ToolStripButton13"
        Me.ToolStripButton13.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton13.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton13.Text = "Add new"
        Me.ToolStripButton13.Visible = False
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(35, 22)
        Me.ToolStripLabel3.Text = "of {0}"
        Me.ToolStripLabel3.ToolTipText = "Total number of items"
        '
        'ToolStripButton14
        '
        Me.ToolStripButton14.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton14.Image = CType(resources.GetObject("ToolStripButton14.Image"), System.Drawing.Image)
        Me.ToolStripButton14.Name = "ToolStripButton14"
        Me.ToolStripButton14.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton14.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton14.Text = "Delete"
        Me.ToolStripButton14.Visible = False
        '
        'ToolStripButton15
        '
        Me.ToolStripButton15.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton15.Image = CType(resources.GetObject("ToolStripButton15.Image"), System.Drawing.Image)
        Me.ToolStripButton15.Name = "ToolStripButton15"
        Me.ToolStripButton15.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton15.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton15.Text = "Move first"
        '
        'ToolStripButton16
        '
        Me.ToolStripButton16.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton16.Image = CType(resources.GetObject("ToolStripButton16.Image"), System.Drawing.Image)
        Me.ToolStripButton16.Name = "ToolStripButton16"
        Me.ToolStripButton16.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton16.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton16.Text = "Move previous"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripTextBox3
        '
        Me.ToolStripTextBox3.AccessibleName = "Position"
        Me.ToolStripTextBox3.AutoSize = False
        Me.ToolStripTextBox3.Name = "ToolStripTextBox3"
        Me.ToolStripTextBox3.Size = New System.Drawing.Size(50, 21)
        Me.ToolStripTextBox3.Text = "0"
        Me.ToolStripTextBox3.ToolTipText = "Current position"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton17
        '
        Me.ToolStripButton17.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton17.Image = CType(resources.GetObject("ToolStripButton17.Image"), System.Drawing.Image)
        Me.ToolStripButton17.Name = "ToolStripButton17"
        Me.ToolStripButton17.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton17.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton17.Text = "Move next"
        '
        'ToolStripButton18
        '
        Me.ToolStripButton18.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton18.Image = CType(resources.GetObject("ToolStripButton18.Image"), System.Drawing.Image)
        Me.ToolStripButton18.Name = "ToolStripButton18"
        Me.ToolStripButton18.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton18.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton18.Text = "Move last"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 25)
        '
        'tpgPagos
        '
        Me.tpgPagos.Controls.Add(Me.c1grdPagos)
        Me.tpgPagos.Controls.Add(Me.bnavPagos)
        Me.tpgPagos.Controls.Add(Me.AcPanelCaption2)
        Me.tpgPagos.InactiveBackColor = System.Drawing.Color.Empty
        Me.tpgPagos.InactiveTextBackColor = System.Drawing.Color.Empty
        Me.tpgPagos.InactiveTextColor = System.Drawing.Color.Empty
        Me.tpgPagos.Location = New System.Drawing.Point(1, 24)
        Me.tpgPagos.Name = "tpgPagos"
        Me.tpgPagos.SelectBackColor = System.Drawing.Color.Empty
        Me.tpgPagos.Selected = False
        Me.tpgPagos.SelectTextBackColor = System.Drawing.Color.Empty
        Me.tpgPagos.SelectTextColor = System.Drawing.Color.Empty
        Me.tpgPagos.Size = New System.Drawing.Size(548, 181)
        Me.tpgPagos.TabIndex = 10
        Me.tpgPagos.Title = "Pagos"
        Me.tpgPagos.ToolTip = "Detalle de Pagos"
        '
        'c1grdPagos
        '
        Me.c1grdPagos.ColumnInfo = "2,1,0,0,0,95,Columns:0{Width:25;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.c1grdPagos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.c1grdPagos.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.c1grdPagos.Location = New System.Drawing.Point(0, 15)
        Me.c1grdPagos.Name = "c1grdPagos"
        Me.c1grdPagos.Rows.Count = 2
        Me.c1grdPagos.Rows.DefaultSize = 19
        Me.c1grdPagos.Size = New System.Drawing.Size(548, 141)
        Me.c1grdPagos.StyleInfo = resources.GetString("c1grdPagos.StyleInfo")
        Me.c1grdPagos.TabIndex = 68
        '
        'bnavPagos
        '
        Me.bnavPagos.AddNewItem = Me.ToolStripButton25
        Me.bnavPagos.CountItem = Me.ToolStripLabel7
        Me.bnavPagos.DeleteItem = Me.ToolStripButton26
        Me.bnavPagos.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.bnavPagos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton31, Me.ToolStripButton32, Me.ToolStripSeparator17, Me.ToolStripTextBox6, Me.ToolStripLabel7, Me.ToolStripSeparator18, Me.ToolStripButton33, Me.ToolStripButton34, Me.ToolStripSeparator19, Me.ToolStripButton25, Me.ToolStripButton26})
        Me.bnavPagos.Location = New System.Drawing.Point(0, 156)
        Me.bnavPagos.MoveFirstItem = Me.ToolStripButton31
        Me.bnavPagos.MoveLastItem = Me.ToolStripButton34
        Me.bnavPagos.MoveNextItem = Me.ToolStripButton33
        Me.bnavPagos.MovePreviousItem = Me.ToolStripButton32
        Me.bnavPagos.Name = "bnavPagos"
        Me.bnavPagos.PositionItem = Me.ToolStripTextBox6
        Me.bnavPagos.Size = New System.Drawing.Size(548, 25)
        Me.bnavPagos.TabIndex = 67
        Me.bnavPagos.Text = "BindingNavigator1"
        '
        'ToolStripButton25
        '
        Me.ToolStripButton25.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton25.Image = CType(resources.GetObject("ToolStripButton25.Image"), System.Drawing.Image)
        Me.ToolStripButton25.Name = "ToolStripButton25"
        Me.ToolStripButton25.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton25.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton25.Text = "Add new"
        Me.ToolStripButton25.Visible = False
        '
        'ToolStripLabel7
        '
        Me.ToolStripLabel7.Name = "ToolStripLabel7"
        Me.ToolStripLabel7.Size = New System.Drawing.Size(35, 22)
        Me.ToolStripLabel7.Text = "of {0}"
        Me.ToolStripLabel7.ToolTipText = "Total number of items"
        '
        'ToolStripButton26
        '
        Me.ToolStripButton26.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton26.Image = CType(resources.GetObject("ToolStripButton26.Image"), System.Drawing.Image)
        Me.ToolStripButton26.Name = "ToolStripButton26"
        Me.ToolStripButton26.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton26.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton26.Text = "Delete"
        Me.ToolStripButton26.Visible = False
        '
        'ToolStripButton31
        '
        Me.ToolStripButton31.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton31.Image = CType(resources.GetObject("ToolStripButton31.Image"), System.Drawing.Image)
        Me.ToolStripButton31.Name = "ToolStripButton31"
        Me.ToolStripButton31.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton31.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton31.Text = "Move first"
        '
        'ToolStripButton32
        '
        Me.ToolStripButton32.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton32.Image = CType(resources.GetObject("ToolStripButton32.Image"), System.Drawing.Image)
        Me.ToolStripButton32.Name = "ToolStripButton32"
        Me.ToolStripButton32.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton32.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton32.Text = "Move previous"
        '
        'ToolStripSeparator17
        '
        Me.ToolStripSeparator17.Name = "ToolStripSeparator17"
        Me.ToolStripSeparator17.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripTextBox6
        '
        Me.ToolStripTextBox6.AccessibleName = "Position"
        Me.ToolStripTextBox6.AutoSize = False
        Me.ToolStripTextBox6.Name = "ToolStripTextBox6"
        Me.ToolStripTextBox6.Size = New System.Drawing.Size(50, 23)
        Me.ToolStripTextBox6.Text = "0"
        Me.ToolStripTextBox6.ToolTipText = "Current position"
        '
        'ToolStripSeparator18
        '
        Me.ToolStripSeparator18.Name = "ToolStripSeparator18"
        Me.ToolStripSeparator18.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton33
        '
        Me.ToolStripButton33.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton33.Image = CType(resources.GetObject("ToolStripButton33.Image"), System.Drawing.Image)
        Me.ToolStripButton33.Name = "ToolStripButton33"
        Me.ToolStripButton33.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton33.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton33.Text = "Move next"
        '
        'ToolStripButton34
        '
        Me.ToolStripButton34.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton34.Image = CType(resources.GetObject("ToolStripButton34.Image"), System.Drawing.Image)
        Me.ToolStripButton34.Name = "ToolStripButton34"
        Me.ToolStripButton34.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton34.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton34.Text = "Move last"
        '
        'ToolStripSeparator19
        '
        Me.ToolStripSeparator19.Name = "ToolStripSeparator19"
        Me.ToolStripSeparator19.Size = New System.Drawing.Size(6, 25)
        '
        'AcPanelCaption2
        '
        Me.AcPanelCaption2.ACCaption = "Pagos Realizados"
        Me.AcPanelCaption2.Dock = System.Windows.Forms.DockStyle.Top
        Me.AcPanelCaption2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.AcPanelCaption2.Location = New System.Drawing.Point(0, 0)
        Me.AcPanelCaption2.Name = "AcPanelCaption2"
        Me.AcPanelCaption2.Size = New System.Drawing.Size(548, 15)
        Me.AcPanelCaption2.TabIndex = 69
        '
        'tpgPendiente
        '
        Me.tpgPendiente.Controls.Add(Me.c1grdPendientes)
        Me.tpgPendiente.Controls.Add(Me.AcPanelCaption1)
        Me.tpgPendiente.Controls.Add(Me.bnavNotas)
        Me.tpgPendiente.InactiveBackColor = System.Drawing.Color.Empty
        Me.tpgPendiente.InactiveTextBackColor = System.Drawing.Color.Empty
        Me.tpgPendiente.InactiveTextColor = System.Drawing.Color.Empty
        Me.tpgPendiente.Location = New System.Drawing.Point(1, 24)
        Me.tpgPendiente.Name = "tpgPendiente"
        Me.tpgPendiente.SelectBackColor = System.Drawing.Color.Empty
        Me.tpgPendiente.Selected = False
        Me.tpgPendiente.SelectTextBackColor = System.Drawing.Color.Empty
        Me.tpgPendiente.SelectTextColor = System.Drawing.Color.Empty
        Me.tpgPendiente.Size = New System.Drawing.Size(548, 181)
        Me.tpgPendiente.TabIndex = 12
        Me.tpgPendiente.Title = "Pendientes"
        Me.tpgPendiente.ToolTip = "Pendiente de Entrega"
        '
        'c1grdPendientes
        '
        Me.c1grdPendientes.BackColor = System.Drawing.Color.White
        Me.c1grdPendientes.ColumnInfo = "2,1,0,0,0,100,Columns:0{Width:20;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:103;Caption:""Codigo"";}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.c1grdPendientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.c1grdPendientes.Location = New System.Drawing.Point(0, 15)
        Me.c1grdPendientes.Name = "c1grdPendientes"
        Me.c1grdPendientes.Rows.Count = 2
        Me.c1grdPendientes.Rows.DefaultSize = 20
        Me.c1grdPendientes.Size = New System.Drawing.Size(548, 141)
        Me.c1grdPendientes.StyleInfo = resources.GetString("c1grdPendientes.StyleInfo")
        Me.c1grdPendientes.TabIndex = 10
        '
        'AcPanelCaption1
        '
        Me.AcPanelCaption1.ACCaption = "Pendientes de Entrega"
        Me.AcPanelCaption1.Dock = System.Windows.Forms.DockStyle.Top
        Me.AcPanelCaption1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.AcPanelCaption1.Location = New System.Drawing.Point(0, 0)
        Me.AcPanelCaption1.Name = "AcPanelCaption1"
        Me.AcPanelCaption1.Size = New System.Drawing.Size(548, 15)
        Me.AcPanelCaption1.TabIndex = 70
        '
        'bnavNotas
        '
        Me.bnavNotas.AddNewItem = Me.ToolStripButton35
        Me.bnavNotas.CountItem = Me.ToolStripLabel8
        Me.bnavNotas.DeleteItem = Me.ToolStripButton36
        Me.bnavNotas.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.bnavNotas.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton37, Me.ToolStripButton38, Me.ToolStripSeparator20, Me.ToolStripTextBox7, Me.ToolStripLabel8, Me.ToolStripSeparator21, Me.ToolStripButton39, Me.ToolStripButton40, Me.ToolStripSeparator22, Me.ToolStripButton35, Me.ToolStripButton36, Me.ToolStripSeparator23})
        Me.bnavNotas.Location = New System.Drawing.Point(0, 156)
        Me.bnavNotas.MoveFirstItem = Me.ToolStripButton37
        Me.bnavNotas.MoveLastItem = Me.ToolStripButton40
        Me.bnavNotas.MoveNextItem = Me.ToolStripButton39
        Me.bnavNotas.MovePreviousItem = Me.ToolStripButton38
        Me.bnavNotas.Name = "bnavNotas"
        Me.bnavNotas.PositionItem = Me.ToolStripTextBox7
        Me.bnavNotas.Size = New System.Drawing.Size(548, 25)
        Me.bnavNotas.TabIndex = 11
        Me.bnavNotas.Text = "BindingNavigator2"
        '
        'ToolStripButton35
        '
        Me.ToolStripButton35.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton35.Image = CType(resources.GetObject("ToolStripButton35.Image"), System.Drawing.Image)
        Me.ToolStripButton35.Name = "ToolStripButton35"
        Me.ToolStripButton35.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton35.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton35.Text = "Add new"
        Me.ToolStripButton35.Visible = False
        '
        'ToolStripLabel8
        '
        Me.ToolStripLabel8.Name = "ToolStripLabel8"
        Me.ToolStripLabel8.Size = New System.Drawing.Size(35, 22)
        Me.ToolStripLabel8.Text = "of {0}"
        Me.ToolStripLabel8.ToolTipText = "Total number of items"
        '
        'ToolStripButton36
        '
        Me.ToolStripButton36.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton36.Image = CType(resources.GetObject("ToolStripButton36.Image"), System.Drawing.Image)
        Me.ToolStripButton36.Name = "ToolStripButton36"
        Me.ToolStripButton36.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton36.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton36.Text = "Delete"
        Me.ToolStripButton36.Visible = False
        '
        'ToolStripButton37
        '
        Me.ToolStripButton37.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton37.Image = CType(resources.GetObject("ToolStripButton37.Image"), System.Drawing.Image)
        Me.ToolStripButton37.Name = "ToolStripButton37"
        Me.ToolStripButton37.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton37.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton37.Text = "Move first"
        '
        'ToolStripButton38
        '
        Me.ToolStripButton38.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton38.Image = CType(resources.GetObject("ToolStripButton38.Image"), System.Drawing.Image)
        Me.ToolStripButton38.Name = "ToolStripButton38"
        Me.ToolStripButton38.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton38.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton38.Text = "Move previous"
        '
        'ToolStripSeparator20
        '
        Me.ToolStripSeparator20.Name = "ToolStripSeparator20"
        Me.ToolStripSeparator20.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripTextBox7
        '
        Me.ToolStripTextBox7.AccessibleName = "Position"
        Me.ToolStripTextBox7.AutoSize = False
        Me.ToolStripTextBox7.Name = "ToolStripTextBox7"
        Me.ToolStripTextBox7.Size = New System.Drawing.Size(50, 21)
        Me.ToolStripTextBox7.Text = "0"
        Me.ToolStripTextBox7.ToolTipText = "Current position"
        '
        'ToolStripSeparator21
        '
        Me.ToolStripSeparator21.Name = "ToolStripSeparator21"
        Me.ToolStripSeparator21.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton39
        '
        Me.ToolStripButton39.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton39.Image = CType(resources.GetObject("ToolStripButton39.Image"), System.Drawing.Image)
        Me.ToolStripButton39.Name = "ToolStripButton39"
        Me.ToolStripButton39.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton39.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton39.Text = "Move next"
        '
        'ToolStripButton40
        '
        Me.ToolStripButton40.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton40.Image = CType(resources.GetObject("ToolStripButton40.Image"), System.Drawing.Image)
        Me.ToolStripButton40.Name = "ToolStripButton40"
        Me.ToolStripButton40.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton40.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton40.Text = "Move last"
        '
        'ToolStripSeparator22
        '
        Me.ToolStripSeparator22.Name = "ToolStripSeparator22"
        Me.ToolStripSeparator22.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator23
        '
        Me.ToolStripSeparator23.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator23.Name = "ToolStripSeparator23"
        Me.ToolStripSeparator23.Size = New System.Drawing.Size(6, 25)
        '
        'tpgNotas
        '
        Me.tpgNotas.Controls.Add(Me.c1grdNotasCredito)
        Me.tpgNotas.Controls.Add(Me.BindingNavigator1)
        Me.tpgNotas.InactiveBackColor = System.Drawing.Color.Empty
        Me.tpgNotas.InactiveTextBackColor = System.Drawing.Color.Empty
        Me.tpgNotas.InactiveTextColor = System.Drawing.Color.Empty
        Me.tpgNotas.Location = New System.Drawing.Point(1, 24)
        Me.tpgNotas.Name = "tpgNotas"
        Me.tpgNotas.SelectBackColor = System.Drawing.Color.Empty
        Me.tpgNotas.Selected = False
        Me.tpgNotas.SelectTextBackColor = System.Drawing.Color.Empty
        Me.tpgNotas.SelectTextColor = System.Drawing.Color.Empty
        Me.tpgNotas.Size = New System.Drawing.Size(548, 181)
        Me.tpgNotas.TabIndex = 6
        Me.tpgNotas.Title = "Nota de Credito"
        Me.tpgNotas.ToolTip = "Nota de Credito"
        '
        'c1grdNotasCredito
        '
        Me.c1grdNotasCredito.BackColor = System.Drawing.Color.White
        Me.c1grdNotasCredito.ColumnInfo = "2,1,0,0,0,100,Columns:0{Width:18;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:107;Caption:""Codigo"";}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.c1grdNotasCredito.Dock = System.Windows.Forms.DockStyle.Fill
        Me.c1grdNotasCredito.Location = New System.Drawing.Point(0, 0)
        Me.c1grdNotasCredito.Name = "c1grdNotasCredito"
        Me.c1grdNotasCredito.Rows.Count = 2
        Me.c1grdNotasCredito.Rows.DefaultSize = 20
        Me.c1grdNotasCredito.Size = New System.Drawing.Size(548, 156)
        Me.c1grdNotasCredito.StyleInfo = resources.GetString("c1grdNotasCredito.StyleInfo")
        Me.c1grdNotasCredito.TabIndex = 3
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.ToolStripButton7
        Me.BindingNavigator1.CountItem = Me.ToolStripLabel2
        Me.BindingNavigator1.DeleteItem = Me.ToolStripButton8
        Me.BindingNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton9, Me.ToolStripButton10, Me.ToolStripSeparator4, Me.ToolStripTextBox2, Me.ToolStripLabel2, Me.ToolStripSeparator5, Me.ToolStripButton11, Me.ToolStripButton12, Me.ToolStripSeparator6, Me.ToolStripButton7, Me.ToolStripButton8})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 156)
        Me.BindingNavigator1.MoveFirstItem = Me.ToolStripButton9
        Me.BindingNavigator1.MoveLastItem = Me.ToolStripButton12
        Me.BindingNavigator1.MoveNextItem = Me.ToolStripButton11
        Me.BindingNavigator1.MovePreviousItem = Me.ToolStripButton10
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.ToolStripTextBox2
        Me.BindingNavigator1.Size = New System.Drawing.Size(548, 25)
        Me.BindingNavigator1.TabIndex = 4
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'ToolStripButton7
        '
        Me.ToolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton7.Image = CType(resources.GetObject("ToolStripButton7.Image"), System.Drawing.Image)
        Me.ToolStripButton7.Name = "ToolStripButton7"
        Me.ToolStripButton7.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton7.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton7.Text = "Add new"
        Me.ToolStripButton7.Visible = False
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(35, 22)
        Me.ToolStripLabel2.Text = "of {0}"
        Me.ToolStripLabel2.ToolTipText = "Total number of items"
        '
        'ToolStripButton8
        '
        Me.ToolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton8.Image = CType(resources.GetObject("ToolStripButton8.Image"), System.Drawing.Image)
        Me.ToolStripButton8.Name = "ToolStripButton8"
        Me.ToolStripButton8.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton8.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton8.Text = "Delete"
        Me.ToolStripButton8.Visible = False
        '
        'ToolStripButton9
        '
        Me.ToolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton9.Image = CType(resources.GetObject("ToolStripButton9.Image"), System.Drawing.Image)
        Me.ToolStripButton9.Name = "ToolStripButton9"
        Me.ToolStripButton9.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton9.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton9.Text = "Move first"
        '
        'ToolStripButton10
        '
        Me.ToolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton10.Image = CType(resources.GetObject("ToolStripButton10.Image"), System.Drawing.Image)
        Me.ToolStripButton10.Name = "ToolStripButton10"
        Me.ToolStripButton10.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton10.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton10.Text = "Move previous"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripTextBox2
        '
        Me.ToolStripTextBox2.AccessibleName = "Position"
        Me.ToolStripTextBox2.AutoSize = False
        Me.ToolStripTextBox2.Name = "ToolStripTextBox2"
        Me.ToolStripTextBox2.Size = New System.Drawing.Size(50, 21)
        Me.ToolStripTextBox2.Text = "0"
        Me.ToolStripTextBox2.ToolTipText = "Current position"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton11
        '
        Me.ToolStripButton11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton11.Image = CType(resources.GetObject("ToolStripButton11.Image"), System.Drawing.Image)
        Me.ToolStripButton11.Name = "ToolStripButton11"
        Me.ToolStripButton11.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton11.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton11.Text = "Move next"
        '
        'ToolStripButton12
        '
        Me.ToolStripButton12.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton12.Image = CType(resources.GetObject("ToolStripButton12.Image"), System.Drawing.Image)
        Me.ToolStripButton12.Name = "ToolStripButton12"
        Me.ToolStripButton12.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton12.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton12.Text = "Move last"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'tpgLetras
        '
        Me.tpgLetras.Controls.Add(Me.c1grdLetras)
        Me.tpgLetras.Controls.Add(Me.bnavLetras)
        Me.tpgLetras.InactiveBackColor = System.Drawing.Color.Empty
        Me.tpgLetras.InactiveTextBackColor = System.Drawing.Color.Empty
        Me.tpgLetras.InactiveTextColor = System.Drawing.Color.Empty
        Me.tpgLetras.Location = New System.Drawing.Point(1, 24)
        Me.tpgLetras.Name = "tpgLetras"
        Me.tpgLetras.SelectBackColor = System.Drawing.Color.Empty
        Me.tpgLetras.Selected = False
        Me.tpgLetras.SelectTextBackColor = System.Drawing.Color.Empty
        Me.tpgLetras.SelectTextColor = System.Drawing.Color.Empty
        Me.tpgLetras.Size = New System.Drawing.Size(548, 181)
        Me.tpgLetras.TabIndex = 7
        Me.tpgLetras.Title = "Letras"
        Me.tpgLetras.ToolTip = "Letras"
        '
        'c1grdLetras
        '
        Me.c1grdLetras.BackColor = System.Drawing.Color.White
        Me.c1grdLetras.ColumnInfo = "2,1,0,0,0,100,Columns:0{Width:18;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:107;Caption:""Codigo"";}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.c1grdLetras.Dock = System.Windows.Forms.DockStyle.Fill
        Me.c1grdLetras.Location = New System.Drawing.Point(0, 0)
        Me.c1grdLetras.Name = "c1grdLetras"
        Me.c1grdLetras.Rows.Count = 2
        Me.c1grdLetras.Rows.DefaultSize = 20
        Me.c1grdLetras.Size = New System.Drawing.Size(548, 156)
        Me.c1grdLetras.StyleInfo = resources.GetString("c1grdLetras.StyleInfo")
        Me.c1grdLetras.TabIndex = 5
        '
        'bnavLetras
        '
        Me.bnavLetras.AddNewItem = Nothing
        Me.bnavLetras.CountItem = Me.ToolStripLabel6
        Me.bnavLetras.DeleteItem = Nothing
        Me.bnavLetras.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.bnavLetras.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton27, Me.ToolStripButton28, Me.ToolStripSeparator14, Me.ToolStripTextBox5, Me.ToolStripLabel6, Me.ToolStripSeparator15, Me.ToolStripButton29, Me.ToolStripButton30, Me.ToolStripSeparator16, Me.tsbtnAddLetra, Me.tsbtnQuitLetra})
        Me.bnavLetras.Location = New System.Drawing.Point(0, 156)
        Me.bnavLetras.MoveFirstItem = Me.ToolStripButton27
        Me.bnavLetras.MoveLastItem = Me.ToolStripButton30
        Me.bnavLetras.MoveNextItem = Me.ToolStripButton29
        Me.bnavLetras.MovePreviousItem = Me.ToolStripButton28
        Me.bnavLetras.Name = "bnavLetras"
        Me.bnavLetras.PositionItem = Me.ToolStripTextBox5
        Me.bnavLetras.Size = New System.Drawing.Size(548, 25)
        Me.bnavLetras.TabIndex = 6
        Me.bnavLetras.Text = "BindingNavigator1"
        '
        'ToolStripLabel6
        '
        Me.ToolStripLabel6.Name = "ToolStripLabel6"
        Me.ToolStripLabel6.Size = New System.Drawing.Size(35, 22)
        Me.ToolStripLabel6.Text = "of {0}"
        Me.ToolStripLabel6.ToolTipText = "Total number of items"
        '
        'ToolStripButton27
        '
        Me.ToolStripButton27.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton27.Image = CType(resources.GetObject("ToolStripButton27.Image"), System.Drawing.Image)
        Me.ToolStripButton27.Name = "ToolStripButton27"
        Me.ToolStripButton27.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton27.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton27.Text = "Move first"
        '
        'ToolStripButton28
        '
        Me.ToolStripButton28.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton28.Image = CType(resources.GetObject("ToolStripButton28.Image"), System.Drawing.Image)
        Me.ToolStripButton28.Name = "ToolStripButton28"
        Me.ToolStripButton28.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton28.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton28.Text = "Move previous"
        '
        'ToolStripSeparator14
        '
        Me.ToolStripSeparator14.Name = "ToolStripSeparator14"
        Me.ToolStripSeparator14.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripTextBox5
        '
        Me.ToolStripTextBox5.AccessibleName = "Position"
        Me.ToolStripTextBox5.AutoSize = False
        Me.ToolStripTextBox5.Name = "ToolStripTextBox5"
        Me.ToolStripTextBox5.Size = New System.Drawing.Size(50, 21)
        Me.ToolStripTextBox5.Text = "0"
        Me.ToolStripTextBox5.ToolTipText = "Current position"
        '
        'ToolStripSeparator15
        '
        Me.ToolStripSeparator15.Name = "ToolStripSeparator15"
        Me.ToolStripSeparator15.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton29
        '
        Me.ToolStripButton29.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton29.Image = CType(resources.GetObject("ToolStripButton29.Image"), System.Drawing.Image)
        Me.ToolStripButton29.Name = "ToolStripButton29"
        Me.ToolStripButton29.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton29.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton29.Text = "Move next"
        '
        'ToolStripButton30
        '
        Me.ToolStripButton30.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton30.Image = CType(resources.GetObject("ToolStripButton30.Image"), System.Drawing.Image)
        Me.ToolStripButton30.Name = "ToolStripButton30"
        Me.ToolStripButton30.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton30.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton30.Text = "Move last"
        '
        'ToolStripSeparator16
        '
        Me.ToolStripSeparator16.Name = "ToolStripSeparator16"
        Me.ToolStripSeparator16.Size = New System.Drawing.Size(6, 25)
        '
        'tsbtnAddLetra
        '
        Me.tsbtnAddLetra.Image = CType(resources.GetObject("tsbtnAddLetra.Image"), System.Drawing.Image)
        Me.tsbtnAddLetra.Name = "tsbtnAddLetra"
        Me.tsbtnAddLetra.RightToLeftAutoMirrorImage = True
        Me.tsbtnAddLetra.Size = New System.Drawing.Size(69, 22)
        Me.tsbtnAddLetra.Text = "Agregar"
        '
        'tsbtnQuitLetra
        '
        Me.tsbtnQuitLetra.Image = CType(resources.GetObject("tsbtnQuitLetra.Image"), System.Drawing.Image)
        Me.tsbtnQuitLetra.Name = "tsbtnQuitLetra"
        Me.tsbtnQuitLetra.RightToLeftAutoMirrorImage = True
        Me.tsbtnQuitLetra.Size = New System.Drawing.Size(60, 22)
        Me.tsbtnQuitLetra.Text = "Quitar"
        '
        'tpgCheques
        '
        Me.tpgCheques.InactiveBackColor = System.Drawing.Color.Empty
        Me.tpgCheques.InactiveTextBackColor = System.Drawing.Color.Empty
        Me.tpgCheques.InactiveTextColor = System.Drawing.Color.Empty
        Me.tpgCheques.Location = New System.Drawing.Point(1, 24)
        Me.tpgCheques.Name = "tpgCheques"
        Me.tpgCheques.SelectBackColor = System.Drawing.Color.Empty
        Me.tpgCheques.Selected = False
        Me.tpgCheques.SelectTextBackColor = System.Drawing.Color.Empty
        Me.tpgCheques.SelectTextColor = System.Drawing.Color.Empty
        Me.tpgCheques.Size = New System.Drawing.Size(548, 181)
        Me.tpgCheques.TabIndex = 8
        Me.tpgCheques.Title = "Cheques"
        Me.tpgCheques.ToolTip = "Cheques"
        '
        'tpgAlmacen
        '
        Me.tpgAlmacen.Controls.Add(Me.c1grdAlmacen)
        Me.tpgAlmacen.Controls.Add(Me.AcPanelCaption3)
        Me.tpgAlmacen.Controls.Add(Me.BindingNavigator2)
        Me.tpgAlmacen.InactiveBackColor = System.Drawing.Color.Empty
        Me.tpgAlmacen.InactiveTextBackColor = System.Drawing.Color.Empty
        Me.tpgAlmacen.InactiveTextColor = System.Drawing.Color.Empty
        Me.tpgAlmacen.Location = New System.Drawing.Point(1, 24)
        Me.tpgAlmacen.Name = "tpgAlmacen"
        Me.tpgAlmacen.SelectBackColor = System.Drawing.Color.Empty
        Me.tpgAlmacen.Selected = False
        Me.tpgAlmacen.SelectTextBackColor = System.Drawing.Color.Empty
        Me.tpgAlmacen.SelectTextColor = System.Drawing.Color.Empty
        Me.tpgAlmacen.Size = New System.Drawing.Size(548, 181)
        Me.tpgAlmacen.TabIndex = 14
        Me.tpgAlmacen.Title = "Almacen"
        Me.tpgAlmacen.ToolTip = "Almacen"
        '
        'c1grdAlmacen
        '
        Me.c1grdAlmacen.BackColor = System.Drawing.Color.White
        Me.c1grdAlmacen.ColumnInfo = "2,1,0,0,0,100,Columns:0{Width:20;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:103;Caption:""Codigo"";}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.c1grdAlmacen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.c1grdAlmacen.Location = New System.Drawing.Point(0, 15)
        Me.c1grdAlmacen.Name = "c1grdAlmacen"
        Me.c1grdAlmacen.Rows.Count = 2
        Me.c1grdAlmacen.Rows.DefaultSize = 20
        Me.c1grdAlmacen.Size = New System.Drawing.Size(548, 141)
        Me.c1grdAlmacen.StyleInfo = resources.GetString("c1grdAlmacen.StyleInfo")
        Me.c1grdAlmacen.TabIndex = 71
        '
        'AcPanelCaption3
        '
        Me.AcPanelCaption3.ACCaption = "Ingresos de Almacen"
        Me.AcPanelCaption3.Dock = System.Windows.Forms.DockStyle.Top
        Me.AcPanelCaption3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.AcPanelCaption3.Location = New System.Drawing.Point(0, 0)
        Me.AcPanelCaption3.Name = "AcPanelCaption3"
        Me.AcPanelCaption3.Size = New System.Drawing.Size(548, 15)
        Me.AcPanelCaption3.TabIndex = 73
        '
        'BindingNavigator2
        '
        Me.BindingNavigator2.AddNewItem = Me.ToolStripButton41
        Me.BindingNavigator2.CountItem = Me.ToolStripLabel9
        Me.BindingNavigator2.DeleteItem = Me.ToolStripButton42
        Me.BindingNavigator2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BindingNavigator2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton43, Me.ToolStripButton44, Me.ToolStripSeparator25, Me.ToolStripTextBox8, Me.ToolStripLabel9, Me.ToolStripSeparator26, Me.ToolStripButton45, Me.ToolStripButton46, Me.ToolStripSeparator27, Me.ToolStripButton41, Me.ToolStripButton42, Me.ToolStripSeparator28, Me.tsbtnAnularEntregaAlmacen, Me.tsbtnAnularTodoEntregaAlmacen})
        Me.BindingNavigator2.Location = New System.Drawing.Point(0, 156)
        Me.BindingNavigator2.MoveFirstItem = Me.ToolStripButton43
        Me.BindingNavigator2.MoveLastItem = Me.ToolStripButton46
        Me.BindingNavigator2.MoveNextItem = Me.ToolStripButton45
        Me.BindingNavigator2.MovePreviousItem = Me.ToolStripButton44
        Me.BindingNavigator2.Name = "BindingNavigator2"
        Me.BindingNavigator2.PositionItem = Me.ToolStripTextBox8
        Me.BindingNavigator2.Size = New System.Drawing.Size(548, 25)
        Me.BindingNavigator2.TabIndex = 72
        Me.BindingNavigator2.Text = "BindingNavigator2"
        '
        'ToolStripButton41
        '
        Me.ToolStripButton41.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton41.Image = CType(resources.GetObject("ToolStripButton41.Image"), System.Drawing.Image)
        Me.ToolStripButton41.Name = "ToolStripButton41"
        Me.ToolStripButton41.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton41.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton41.Text = "Add new"
        Me.ToolStripButton41.Visible = False
        '
        'ToolStripLabel9
        '
        Me.ToolStripLabel9.Name = "ToolStripLabel9"
        Me.ToolStripLabel9.Size = New System.Drawing.Size(35, 22)
        Me.ToolStripLabel9.Text = "of {0}"
        Me.ToolStripLabel9.ToolTipText = "Total number of items"
        '
        'ToolStripButton42
        '
        Me.ToolStripButton42.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton42.Image = CType(resources.GetObject("ToolStripButton42.Image"), System.Drawing.Image)
        Me.ToolStripButton42.Name = "ToolStripButton42"
        Me.ToolStripButton42.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton42.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton42.Text = "Delete"
        Me.ToolStripButton42.Visible = False
        '
        'ToolStripButton43
        '
        Me.ToolStripButton43.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton43.Image = CType(resources.GetObject("ToolStripButton43.Image"), System.Drawing.Image)
        Me.ToolStripButton43.Name = "ToolStripButton43"
        Me.ToolStripButton43.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton43.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton43.Text = "Move first"
        '
        'ToolStripButton44
        '
        Me.ToolStripButton44.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton44.Image = CType(resources.GetObject("ToolStripButton44.Image"), System.Drawing.Image)
        Me.ToolStripButton44.Name = "ToolStripButton44"
        Me.ToolStripButton44.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton44.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton44.Text = "Move previous"
        '
        'ToolStripSeparator25
        '
        Me.ToolStripSeparator25.Name = "ToolStripSeparator25"
        Me.ToolStripSeparator25.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripTextBox8
        '
        Me.ToolStripTextBox8.AccessibleName = "Position"
        Me.ToolStripTextBox8.AutoSize = False
        Me.ToolStripTextBox8.Name = "ToolStripTextBox8"
        Me.ToolStripTextBox8.Size = New System.Drawing.Size(50, 21)
        Me.ToolStripTextBox8.Text = "0"
        Me.ToolStripTextBox8.ToolTipText = "Current position"
        '
        'ToolStripSeparator26
        '
        Me.ToolStripSeparator26.Name = "ToolStripSeparator26"
        Me.ToolStripSeparator26.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton45
        '
        Me.ToolStripButton45.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton45.Image = CType(resources.GetObject("ToolStripButton45.Image"), System.Drawing.Image)
        Me.ToolStripButton45.Name = "ToolStripButton45"
        Me.ToolStripButton45.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton45.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton45.Text = "Move next"
        '
        'ToolStripButton46
        '
        Me.ToolStripButton46.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton46.Image = CType(resources.GetObject("ToolStripButton46.Image"), System.Drawing.Image)
        Me.ToolStripButton46.Name = "ToolStripButton46"
        Me.ToolStripButton46.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton46.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton46.Text = "Move last"
        '
        'ToolStripSeparator27
        '
        Me.ToolStripSeparator27.Name = "ToolStripSeparator27"
        Me.ToolStripSeparator27.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator28
        '
        Me.ToolStripSeparator28.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator28.Name = "ToolStripSeparator28"
        Me.ToolStripSeparator28.Size = New System.Drawing.Size(6, 25)
        '
        'tsbtnAnularEntregaAlmacen
        '
        Me.tsbtnAnularEntregaAlmacen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnAnularEntregaAlmacen.Name = "tsbtnAnularEntregaAlmacen"
        Me.tsbtnAnularEntregaAlmacen.Size = New System.Drawing.Size(83, 22)
        Me.tsbtnAnularEntregaAlmacen.Text = "Anular X Item"
        '
        'tsbtnAnularTodoEntregaAlmacen
        '
        Me.tsbtnAnularTodoEntregaAlmacen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnAnularTodoEntregaAlmacen.Name = "tsbtnAnularTodoEntregaAlmacen"
        Me.tsbtnAnularTodoEntregaAlmacen.Size = New System.Drawing.Size(76, 22)
        Me.tsbtnAnularTodoEntregaAlmacen.Text = "Anular Todo"
        '
        'pnlPie
        '
        Me.pnlPie.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(145, Byte), Integer))
        Me.pnlPie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlPie.Controls.Add(Me.grpDetalleDocumento)
        Me.pnlPie.Controls.Add(Me.pnlDetProductos)
        Me.pnlPie.Controls.Add(Me.grpDetPago)
        Me.pnlPie.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlPie.ForeColor = System.Drawing.Color.White
        Me.pnlPie.Location = New System.Drawing.Point(0, 332)
        Me.pnlPie.Name = "pnlPie"
        Me.pnlPie.Size = New System.Drawing.Size(1136, 183)
        Me.pnlPie.TabIndex = 4
        '
        'grpDetalleDocumento
        '
        Me.grpDetalleDocumento.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(145, Byte), Integer))
        Me.grpDetalleDocumento.Controls.Add(Me.Label12)
        Me.grpDetalleDocumento.Controls.Add(Me.txtObservaciones)
        Me.grpDetalleDocumento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpDetalleDocumento.Location = New System.Drawing.Point(0, 127)
        Me.grpDetalleDocumento.Name = "grpDetalleDocumento"
        Me.grpDetalleDocumento.Size = New System.Drawing.Size(892, 54)
        Me.grpDetalleDocumento.TabIndex = 2
        Me.grpDetalleDocumento.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(10, 19)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(90, 15)
        Me.Label12.TabIndex = 41
        Me.Label12.Text = "Observaciones :"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtObservaciones.Location = New System.Drawing.Point(106, 17)
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservaciones.Size = New System.Drawing.Size(768, 23)
        Me.txtObservaciones.TabIndex = 42
        Me.txtObservaciones.Tag = "EV"
        '
        'pnlDetProductos
        '
        Me.pnlDetProductos.Controls.Add(Me.actxnFlete)
        Me.pnlDetProductos.Controls.Add(Me.actxnGastos)
        Me.pnlDetProductos.Controls.Add(Me.actxnDescuento)
        Me.pnlDetProductos.Controls.Add(Me.Label21)
        Me.pnlDetProductos.Controls.Add(Me.Label20)
        Me.pnlDetProductos.Controls.Add(Me.Label9)
        Me.pnlDetProductos.Controls.Add(Me.actxnPDetraccion)
        Me.pnlDetProductos.Controls.Add(Me.lblPDetraccion)
        Me.pnlDetProductos.Controls.Add(Me.actxnDetraccionSoles)
        Me.pnlDetProductos.Controls.Add(Me.Label52)
        Me.pnlDetProductos.Controls.Add(Me.actxnPRetencion)
        Me.pnlDetProductos.Controls.Add(Me.Label47)
        Me.pnlDetProductos.Controls.Add(Me.actxnRetencionSoles)
        Me.pnlDetProductos.Controls.Add(Me.Label48)
        Me.pnlDetProductos.Controls.Add(Me.Label26)
        Me.pnlDetProductos.Controls.Add(Me.Label15)
        Me.pnlDetProductos.Controls.Add(Me.actxnPercepcionSoles)
        Me.pnlDetProductos.Controls.Add(Me.actxnPesoTotal)
        Me.pnlDetProductos.Controls.Add(Me.actxnPercepcionMO)
        Me.pnlDetProductos.Controls.Add(Me.Label16)
        Me.pnlDetProductos.Controls.Add(Me.Label13)
        Me.pnlDetProductos.Controls.Add(Me.actxnAfectoPercepcionSoles)
        Me.pnlDetProductos.Controls.Add(Me.actxnAfectoPercepcionMO)
        Me.pnlDetProductos.Controls.Add(Me.Label25)
        Me.pnlDetProductos.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlDetProductos.Location = New System.Drawing.Point(0, 0)
        Me.pnlDetProductos.Name = "pnlDetProductos"
        Me.pnlDetProductos.Size = New System.Drawing.Size(892, 127)
        Me.pnlDetProductos.TabIndex = 1
        '
        'actxnFlete
        '
        Me.actxnFlete.ACEnteros = 9
        Me.actxnFlete.ACEstandar = ACControles.ACEstandaresFormato.ACDecimal
        Me.actxnFlete.ACNegativo = True
        Me.actxnFlete.ACValue = New Decimal(New Integer() {0, 0, 0, 131072})
        Me.actxnFlete.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.actxnFlete.Location = New System.Drawing.Point(91, 67)
        Me.actxnFlete.MaxLength = 12
        Me.actxnFlete.Name = "actxnFlete"
        Me.actxnFlete.ReadOnly = True
        Me.actxnFlete.Size = New System.Drawing.Size(105, 23)
        Me.actxnFlete.TabIndex = 64
        Me.actxnFlete.Tag = "EV"
        Me.actxnFlete.Text = "0.00"
        Me.actxnFlete.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'actxnGastos
        '
        Me.actxnGastos.ACEnteros = 9
        Me.actxnGastos.ACEstandar = ACControles.ACEstandaresFormato.ACDecimal
        Me.actxnGastos.ACNegativo = True
        Me.actxnGastos.ACValue = New Decimal(New Integer() {0, 0, 0, 131072})
        Me.actxnGastos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.actxnGastos.Location = New System.Drawing.Point(91, 38)
        Me.actxnGastos.MaxLength = 12
        Me.actxnGastos.Name = "actxnGastos"
        Me.actxnGastos.ReadOnly = True
        Me.actxnGastos.Size = New System.Drawing.Size(105, 23)
        Me.actxnGastos.TabIndex = 63
        Me.actxnGastos.Tag = "EV"
        Me.actxnGastos.Text = "0.00"
        Me.actxnGastos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'actxnDescuento
        '
        Me.actxnDescuento.ACEnteros = 9
        Me.actxnDescuento.ACEstandar = ACControles.ACEstandaresFormato.ACDecimal
        Me.actxnDescuento.ACNegativo = True
        Me.actxnDescuento.ACValue = New Decimal(New Integer() {0, 0, 0, 131072})
        Me.actxnDescuento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.actxnDescuento.Location = New System.Drawing.Point(91, 9)
        Me.actxnDescuento.MaxLength = 12
        Me.actxnDescuento.Name = "actxnDescuento"
        Me.actxnDescuento.ReadOnly = True
        Me.actxnDescuento.Size = New System.Drawing.Size(105, 23)
        Me.actxnDescuento.TabIndex = 62
        Me.actxnDescuento.Tag = "EV"
        Me.actxnDescuento.Text = "0.00"
        Me.actxnDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(16, 69)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(38, 15)
        Me.Label21.TabIndex = 61
        Me.Label21.Text = "Flete :"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(16, 41)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(48, 15)
        Me.Label20.TabIndex = 60
        Me.Label20.Text = "Gastos :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(16, 12)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 15)
        Me.Label9.TabIndex = 59
        Me.Label9.Text = "Descuento :"
        '
        'actxnPDetraccion
        '
        Me.actxnPDetraccion.ACEnteros = 9
        Me.actxnPDetraccion.ACEstandar = ACControles.ACEstandaresFormato.ACDecimal
        Me.actxnPDetraccion.ACNegativo = True
        Me.actxnPDetraccion.ACValue = New Decimal(New Integer() {0, 0, 0, 131072})
        Me.actxnPDetraccion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.actxnPDetraccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.actxnPDetraccion.Enabled = False
        Me.actxnPDetraccion.Location = New System.Drawing.Point(652, 77)
        Me.actxnPDetraccion.MaxLength = 12
        Me.actxnPDetraccion.Name = "actxnPDetraccion"
        Me.actxnPDetraccion.ReadOnly = True
        Me.actxnPDetraccion.Size = New System.Drawing.Size(35, 23)
        Me.actxnPDetraccion.TabIndex = 58
        Me.actxnPDetraccion.Tag = "EV"
        Me.actxnPDetraccion.Text = "0.00"
        Me.actxnPDetraccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblPDetraccion
        '
        Me.lblPDetraccion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPDetraccion.AutoSize = True
        Me.lblPDetraccion.Enabled = False
        Me.lblPDetraccion.Location = New System.Drawing.Point(569, 81)
        Me.lblPDetraccion.Name = "lblPDetraccion"
        Me.lblPDetraccion.Size = New System.Drawing.Size(86, 15)
        Me.lblPDetraccion.TabIndex = 57
        Me.lblPDetraccion.Text = "Detracción % : "
        '
        'actxnDetraccionSoles
        '
        Me.actxnDetraccionSoles.ACEnteros = 9
        Me.actxnDetraccionSoles.ACEstandar = ACControles.ACEstandaresFormato.ACDecimal
        Me.actxnDetraccionSoles.ACNegativo = True
        Me.actxnDetraccionSoles.ACValue = New Decimal(New Integer() {0, 0, 0, 131072})
        Me.actxnDetraccionSoles.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.actxnDetraccionSoles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.actxnDetraccionSoles.Enabled = False
        Me.actxnDetraccionSoles.Location = New System.Drawing.Point(787, 77)
        Me.actxnDetraccionSoles.MaxLength = 12
        Me.actxnDetraccionSoles.Name = "actxnDetraccionSoles"
        Me.actxnDetraccionSoles.ReadOnly = True
        Me.actxnDetraccionSoles.Size = New System.Drawing.Size(102, 23)
        Me.actxnDetraccionSoles.TabIndex = 56
        Me.actxnDetraccionSoles.Tag = "EV"
        Me.actxnDetraccionSoles.Text = "0.00"
        Me.actxnDetraccionSoles.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label52
        '
        Me.Label52.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label52.AutoSize = True
        Me.Label52.Enabled = False
        Me.Label52.Location = New System.Drawing.Point(695, 80)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(90, 15)
        Me.Label52.TabIndex = 55
        Me.Label52.Text = "Detracción :  {0}"
        '
        'actxnPRetencion
        '
        Me.actxnPRetencion.ACEnteros = 9
        Me.actxnPRetencion.ACEstandar = ACControles.ACEstandaresFormato.ACDecimal
        Me.actxnPRetencion.ACNegativo = True
        Me.actxnPRetencion.ACValue = New Decimal(New Integer() {0, 0, 0, 131072})
        Me.actxnPRetencion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.actxnPRetencion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.actxnPRetencion.Enabled = False
        Me.actxnPRetencion.Location = New System.Drawing.Point(652, 53)
        Me.actxnPRetencion.MaxLength = 12
        Me.actxnPRetencion.Name = "actxnPRetencion"
        Me.actxnPRetencion.ReadOnly = True
        Me.actxnPRetencion.Size = New System.Drawing.Size(35, 23)
        Me.actxnPRetencion.TabIndex = 54
        Me.actxnPRetencion.Tag = "EV"
        Me.actxnPRetencion.Text = "0.00"
        Me.actxnPRetencion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label47
        '
        Me.Label47.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label47.AutoSize = True
        Me.Label47.Enabled = False
        Me.Label47.Location = New System.Drawing.Point(569, 57)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(82, 15)
        Me.Label47.TabIndex = 53
        Me.Label47.Text = "Retención % : "
        '
        'actxnRetencionSoles
        '
        Me.actxnRetencionSoles.ACEnteros = 9
        Me.actxnRetencionSoles.ACEstandar = ACControles.ACEstandaresFormato.ACDecimal
        Me.actxnRetencionSoles.ACNegativo = True
        Me.actxnRetencionSoles.ACValue = New Decimal(New Integer() {0, 0, 0, 131072})
        Me.actxnRetencionSoles.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.actxnRetencionSoles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.actxnRetencionSoles.Enabled = False
        Me.actxnRetencionSoles.Location = New System.Drawing.Point(787, 53)
        Me.actxnRetencionSoles.MaxLength = 12
        Me.actxnRetencionSoles.Name = "actxnRetencionSoles"
        Me.actxnRetencionSoles.ReadOnly = True
        Me.actxnRetencionSoles.Size = New System.Drawing.Size(102, 23)
        Me.actxnRetencionSoles.TabIndex = 52
        Me.actxnRetencionSoles.Tag = "EV"
        Me.actxnRetencionSoles.Text = "0.00"
        Me.actxnRetencionSoles.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label48
        '
        Me.Label48.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label48.AutoSize = True
        Me.Label48.Enabled = False
        Me.Label48.Location = New System.Drawing.Point(695, 56)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(86, 15)
        Me.Label48.TabIndex = 51
        Me.Label48.Text = "Retención :  {0}"
        '
        'Label26
        '
        Me.Label26.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(712, 105)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(67, 15)
        Me.Label26.TabIndex = 1
        Me.Label26.Text = "Peso Total :"
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(760, 34)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(21, 15)
        Me.Label15.TabIndex = 50
        Me.Label15.Text = "S/."
        '
        'actxnPercepcionSoles
        '
        Me.actxnPercepcionSoles.ACEnteros = 9
        Me.actxnPercepcionSoles.ACEstandar = ACControles.ACEstandaresFormato.ACDecimal
        Me.actxnPercepcionSoles.ACNegativo = True
        Me.actxnPercepcionSoles.ACValue = New Decimal(New Integer() {0, 0, 0, 131072})
        Me.actxnPercepcionSoles.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.actxnPercepcionSoles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.actxnPercepcionSoles.Location = New System.Drawing.Point(787, 28)
        Me.actxnPercepcionSoles.MaxLength = 12
        Me.actxnPercepcionSoles.Name = "actxnPercepcionSoles"
        Me.actxnPercepcionSoles.ReadOnly = True
        Me.actxnPercepcionSoles.Size = New System.Drawing.Size(103, 23)
        Me.actxnPercepcionSoles.TabIndex = 49
        Me.actxnPercepcionSoles.Tag = "EV"
        Me.actxnPercepcionSoles.Text = "0.00"
        Me.actxnPercepcionSoles.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'actxnPesoTotal
        '
        Me.actxnPesoTotal.ACEnteros = 9
        Me.actxnPesoTotal.ACEstandar = ACControles.ACEstandaresFormato.ACDecimal
        Me.actxnPesoTotal.ACFormato = "###,###,##0.0000"
        Me.actxnPesoTotal.ACNegativo = True
        Me.actxnPesoTotal.ACValue = New Decimal(New Integer() {0, 0, 0, 131072})
        Me.actxnPesoTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.actxnPesoTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.actxnPesoTotal.Location = New System.Drawing.Point(785, 101)
        Me.actxnPesoTotal.MaxLength = 12
        Me.actxnPesoTotal.Name = "actxnPesoTotal"
        Me.actxnPesoTotal.ReadOnly = True
        Me.actxnPesoTotal.Size = New System.Drawing.Size(105, 23)
        Me.actxnPesoTotal.TabIndex = 2
        Me.actxnPesoTotal.Tag = "EV"
        Me.actxnPesoTotal.Text = "0.0000"
        Me.actxnPesoTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'actxnPercepcionMO
        '
        Me.actxnPercepcionMO.ACEnteros = 9
        Me.actxnPercepcionMO.ACEstandar = ACControles.ACEstandaresFormato.ACDecimal
        Me.actxnPercepcionMO.ACNegativo = True
        Me.actxnPercepcionMO.ACValue = New Decimal(New Integer() {0, 0, 0, 131072})
        Me.actxnPercepcionMO.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.actxnPercepcionMO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.actxnPercepcionMO.Location = New System.Drawing.Point(651, 28)
        Me.actxnPercepcionMO.MaxLength = 12
        Me.actxnPercepcionMO.Name = "actxnPercepcionMO"
        Me.actxnPercepcionMO.ReadOnly = True
        Me.actxnPercepcionMO.Size = New System.Drawing.Size(103, 23)
        Me.actxnPercepcionMO.TabIndex = 48
        Me.actxnPercepcionMO.Tag = "EV"
        Me.actxnPercepcionMO.Text = "0.00"
        Me.actxnPercepcionMO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(570, 32)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(72, 15)
        Me.Label16.TabIndex = 47
        Me.Label16.Text = "Percepcion :"
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(760, 8)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(21, 15)
        Me.Label13.TabIndex = 46
        Me.Label13.Text = "S/."
        '
        'actxnAfectoPercepcionSoles
        '
        Me.actxnAfectoPercepcionSoles.ACEnteros = 9
        Me.actxnAfectoPercepcionSoles.ACEstandar = ACControles.ACEstandaresFormato.ACDecimal
        Me.actxnAfectoPercepcionSoles.ACNegativo = True
        Me.actxnAfectoPercepcionSoles.ACValue = New Decimal(New Integer() {0, 0, 0, 131072})
        Me.actxnAfectoPercepcionSoles.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.actxnAfectoPercepcionSoles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.actxnAfectoPercepcionSoles.Location = New System.Drawing.Point(787, 4)
        Me.actxnAfectoPercepcionSoles.MaxLength = 12
        Me.actxnAfectoPercepcionSoles.Name = "actxnAfectoPercepcionSoles"
        Me.actxnAfectoPercepcionSoles.ReadOnly = True
        Me.actxnAfectoPercepcionSoles.Size = New System.Drawing.Size(103, 23)
        Me.actxnAfectoPercepcionSoles.TabIndex = 45
        Me.actxnAfectoPercepcionSoles.Tag = "EV"
        Me.actxnAfectoPercepcionSoles.Text = "0.00"
        Me.actxnAfectoPercepcionSoles.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'actxnAfectoPercepcionMO
        '
        Me.actxnAfectoPercepcionMO.ACEnteros = 9
        Me.actxnAfectoPercepcionMO.ACEstandar = ACControles.ACEstandaresFormato.ACDecimal
        Me.actxnAfectoPercepcionMO.ACNegativo = True
        Me.actxnAfectoPercepcionMO.ACValue = New Decimal(New Integer() {0, 0, 0, 131072})
        Me.actxnAfectoPercepcionMO.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.actxnAfectoPercepcionMO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.actxnAfectoPercepcionMO.Location = New System.Drawing.Point(651, 5)
        Me.actxnAfectoPercepcionMO.MaxLength = 12
        Me.actxnAfectoPercepcionMO.Name = "actxnAfectoPercepcionMO"
        Me.actxnAfectoPercepcionMO.ReadOnly = True
        Me.actxnAfectoPercepcionMO.Size = New System.Drawing.Size(105, 23)
        Me.actxnAfectoPercepcionMO.TabIndex = 4
        Me.actxnAfectoPercepcionMO.Tag = "EV"
        Me.actxnAfectoPercepcionMO.Text = "0.00"
        Me.actxnAfectoPercepcionMO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label25
        '
        Me.Label25.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(536, 9)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(110, 15)
        Me.Label25.TabIndex = 3
        Me.Label25.Text = "Afecto Percepcion :"
        '
        'grpDetPago
        '
        Me.grpDetPago.Controls.Add(Me.lblDetraccion)
        Me.grpDetPago.Controls.Add(Me.actxnVDetraccion)
        Me.grpDetPago.Controls.Add(Me.lblRetencion)
        Me.grpDetPago.Controls.Add(Me.actxnVRetencion)
        Me.grpDetPago.Controls.Add(Me.lblVPercepcion)
        Me.grpDetPago.Controls.Add(Me.lblImporte)
        Me.grpDetPago.Controls.Add(Me.lblTotal)
        Me.grpDetPago.Controls.Add(Me.lbligv)
        Me.grpDetPago.Controls.Add(Me.lblTotalPagar)
        Me.grpDetPago.Controls.Add(Me.actxnImporte)
        Me.grpDetPago.Controls.Add(Me.actxnIGV)
        Me.grpDetPago.Controls.Add(Me.actxnTotalPagar)
        Me.grpDetPago.Controls.Add(Me.actxnTotal)
        Me.grpDetPago.Controls.Add(Me.actxnPercepcion)
        Me.grpDetPago.Dock = System.Windows.Forms.DockStyle.Right
        Me.grpDetPago.Location = New System.Drawing.Point(892, 0)
        Me.grpDetPago.Name = "grpDetPago"
        Me.grpDetPago.Size = New System.Drawing.Size(242, 181)
        Me.grpDetPago.TabIndex = 3
        Me.grpDetPago.TabStop = False
        '
        'lblDetraccion
        '
        Me.lblDetraccion.AutoSize = True
        Me.lblDetraccion.ForeColor = System.Drawing.Color.White
        Me.lblDetraccion.Location = New System.Drawing.Point(33, 132)
        Me.lblDetraccion.Name = "lblDetraccion"
        Me.lblDetraccion.Size = New System.Drawing.Size(87, 15)
        Me.lblDetraccion.TabIndex = 18
        Me.lblDetraccion.Text = "Detracción : {0}"
        '
        'actxnVDetraccion
        '
        Me.actxnVDetraccion.ACEnteros = 9
        Me.actxnVDetraccion.ACEstandar = ACControles.ACEstandaresFormato.ACDecimal
        Me.actxnVDetraccion.ACNegativo = True
        Me.actxnVDetraccion.ACValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.actxnVDetraccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.actxnVDetraccion.Location = New System.Drawing.Point(124, 128)
        Me.actxnVDetraccion.MaxLength = 12
        Me.actxnVDetraccion.Name = "actxnVDetraccion"
        Me.actxnVDetraccion.ReadOnly = True
        Me.actxnVDetraccion.Size = New System.Drawing.Size(108, 23)
        Me.actxnVDetraccion.TabIndex = 19
        Me.actxnVDetraccion.Tag = "EV"
        Me.actxnVDetraccion.Text = "0.00"
        Me.actxnVDetraccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblRetencion
        '
        Me.lblRetencion.AutoSize = True
        Me.lblRetencion.ForeColor = System.Drawing.Color.White
        Me.lblRetencion.Location = New System.Drawing.Point(33, 108)
        Me.lblRetencion.Name = "lblRetencion"
        Me.lblRetencion.Size = New System.Drawing.Size(83, 15)
        Me.lblRetencion.TabIndex = 16
        Me.lblRetencion.Text = "Retención : {0}"
        '
        'actxnVRetencion
        '
        Me.actxnVRetencion.ACEnteros = 9
        Me.actxnVRetencion.ACEstandar = ACControles.ACEstandaresFormato.ACDecimal
        Me.actxnVRetencion.ACNegativo = True
        Me.actxnVRetencion.ACValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.actxnVRetencion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.actxnVRetencion.Location = New System.Drawing.Point(124, 104)
        Me.actxnVRetencion.MaxLength = 12
        Me.actxnVRetencion.Name = "actxnVRetencion"
        Me.actxnVRetencion.ReadOnly = True
        Me.actxnVRetencion.Size = New System.Drawing.Size(109, 23)
        Me.actxnVRetencion.TabIndex = 17
        Me.actxnVRetencion.Tag = "EV"
        Me.actxnVRetencion.Text = "0.00"
        Me.actxnVRetencion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblVPercepcion
        '
        Me.lblVPercepcion.AutoSize = True
        Me.lblVPercepcion.ForeColor = System.Drawing.Color.White
        Me.lblVPercepcion.Location = New System.Drawing.Point(29, 85)
        Me.lblVPercepcion.Name = "lblVPercepcion"
        Me.lblVPercepcion.Size = New System.Drawing.Size(89, 15)
        Me.lblVPercepcion.TabIndex = 15
        Me.lblVPercepcion.Text = "Percepcion : {0}"
        '
        'lblImporte
        '
        Me.lblImporte.AutoSize = True
        Me.lblImporte.ForeColor = System.Drawing.Color.White
        Me.lblImporte.Location = New System.Drawing.Point(46, 12)
        Me.lblImporte.Name = "lblImporte"
        Me.lblImporte.Size = New System.Drawing.Size(72, 15)
        Me.lblImporte.TabIndex = 11
        Me.lblImporte.Text = "Importe : {0}"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.ForeColor = System.Drawing.Color.White
        Me.lblTotal.Location = New System.Drawing.Point(61, 61)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(56, 15)
        Me.lblTotal.TabIndex = 13
        Me.lblTotal.Text = "Total : {0}"
        '
        'lbligv
        '
        Me.lbligv.AutoSize = True
        Me.lbligv.ForeColor = System.Drawing.Color.White
        Me.lbligv.Location = New System.Drawing.Point(37, 36)
        Me.lbligv.Name = "lbligv"
        Me.lbligv.Size = New System.Drawing.Size(82, 15)
        Me.lbligv.TabIndex = 12
        Me.lbligv.Text = "I.G.V. 18% : S/."
        '
        'lblTotalPagar
        '
        Me.lblTotalPagar.AutoSize = True
        Me.lblTotalPagar.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
        Me.lblTotalPagar.ForeColor = System.Drawing.Color.White
        Me.lblTotalPagar.Location = New System.Drawing.Point(10, 157)
        Me.lblTotalPagar.Name = "lblTotalPagar"
        Me.lblTotalPagar.Size = New System.Drawing.Size(107, 17)
        Me.lblTotalPagar.TabIndex = 14
        Me.lblTotalPagar.Text = "Total Pagar : {0}"
        '
        'actxnImporte
        '
        Me.actxnImporte.ACEnteros = 9
        Me.actxnImporte.ACEstandar = ACControles.ACEstandaresFormato.ACDecimal
        Me.actxnImporte.ACNegativo = True
        Me.actxnImporte.ACValue = New Decimal(New Integer() {0, 0, 0, 131072})
        Me.actxnImporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.actxnImporte.Location = New System.Drawing.Point(124, 10)
        Me.actxnImporte.MaxLength = 12
        Me.actxnImporte.Name = "actxnImporte"
        Me.actxnImporte.ReadOnly = True
        Me.actxnImporte.Size = New System.Drawing.Size(109, 23)
        Me.actxnImporte.TabIndex = 1
        Me.actxnImporte.Tag = "EVO"
        Me.actxnImporte.Text = "0.00"
        Me.actxnImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'actxnIGV
        '
        Me.actxnIGV.ACEnteros = 9
        Me.actxnIGV.ACEstandar = ACControles.ACEstandaresFormato.ACDecimal
        Me.actxnIGV.ACNegativo = True
        Me.actxnIGV.ACValue = New Decimal(New Integer() {0, 0, 0, 131072})
        Me.actxnIGV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.actxnIGV.Location = New System.Drawing.Point(124, 33)
        Me.actxnIGV.MaxLength = 12
        Me.actxnIGV.Name = "actxnIGV"
        Me.actxnIGV.ReadOnly = True
        Me.actxnIGV.Size = New System.Drawing.Size(109, 23)
        Me.actxnIGV.TabIndex = 3
        Me.actxnIGV.Tag = "EVO"
        Me.actxnIGV.Text = "0.00"
        Me.actxnIGV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'actxnTotalPagar
        '
        Me.actxnTotalPagar.ACEnteros = 9
        Me.actxnTotalPagar.ACEstandar = ACControles.ACEstandaresFormato.ACDecimal
        Me.actxnTotalPagar.ACNegativo = True
        Me.actxnTotalPagar.ACValue = New Decimal(New Integer() {0, 0, 0, 131072})
        Me.actxnTotalPagar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.actxnTotalPagar.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
        Me.actxnTotalPagar.Location = New System.Drawing.Point(124, 152)
        Me.actxnTotalPagar.MaxLength = 12
        Me.actxnTotalPagar.Name = "actxnTotalPagar"
        Me.actxnTotalPagar.ReadOnly = True
        Me.actxnTotalPagar.Size = New System.Drawing.Size(109, 26)
        Me.actxnTotalPagar.TabIndex = 9
        Me.actxnTotalPagar.Tag = "EVO"
        Me.actxnTotalPagar.Text = "0.00"
        Me.actxnTotalPagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'actxnTotal
        '
        Me.actxnTotal.ACEnteros = 9
        Me.actxnTotal.ACEstandar = ACControles.ACEstandaresFormato.ACDecimal
        Me.actxnTotal.ACNegativo = True
        Me.actxnTotal.ACValue = New Decimal(New Integer() {0, 0, 0, 131072})
        Me.actxnTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.actxnTotal.Location = New System.Drawing.Point(124, 57)
        Me.actxnTotal.MaxLength = 12
        Me.actxnTotal.Name = "actxnTotal"
        Me.actxnTotal.ReadOnly = True
        Me.actxnTotal.Size = New System.Drawing.Size(109, 23)
        Me.actxnTotal.TabIndex = 5
        Me.actxnTotal.Tag = "EVO"
        Me.actxnTotal.Text = "0.00"
        Me.actxnTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'actxnPercepcion
        '
        Me.actxnPercepcion.ACEnteros = 9
        Me.actxnPercepcion.ACEstandar = ACControles.ACEstandaresFormato.ACDecimal
        Me.actxnPercepcion.ACNegativo = True
        Me.actxnPercepcion.ACValue = New Decimal(New Integer() {0, 0, 0, 131072})
        Me.actxnPercepcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.actxnPercepcion.Location = New System.Drawing.Point(124, 81)
        Me.actxnPercepcion.MaxLength = 12
        Me.actxnPercepcion.Name = "actxnPercepcion"
        Me.actxnPercepcion.ReadOnly = True
        Me.actxnPercepcion.Size = New System.Drawing.Size(109, 23)
        Me.actxnPercepcion.TabIndex = 7
        Me.actxnPercepcion.Tag = "EV"
        Me.actxnPercepcion.Text = "0.00"
        Me.actxnPercepcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'pnlCabecera
        '
        Me.pnlCabecera.BackColor = System.Drawing.Color.LightSteelBlue
        Me.pnlCabecera.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlCabecera.Controls.Add(Me.Label6)
        Me.pnlCabecera.Controls.Add(Me.actxaCliRazonSocial)
        Me.pnlCabecera.Controls.Add(Me.cmbCondPago)
        Me.pnlCabecera.Controls.Add(Me.pnlCabHeader)
        Me.pnlCabecera.Controls.Add(Me.actxaCliRuc)
        Me.pnlCabecera.Controls.Add(Me.Label5)
        Me.pnlCabecera.Controls.Add(Me.txtDireccion)
        Me.pnlCabecera.Controls.Add(Me.Label4)
        Me.pnlCabecera.Controls.Add(Me.lblMoneda)
        Me.pnlCabecera.Controls.Add(Me.Label3)
        Me.pnlCabecera.Controls.Add(Me.cmbMoneda)
        Me.pnlCabecera.Controls.Add(Me.dtpFecPlazo)
        Me.pnlCabecera.Controls.Add(Me.actxnPlazo)
        Me.pnlCabecera.Controls.Add(Me.Label19)
        Me.pnlCabecera.Controls.Add(Me.Label31)
        Me.pnlCabecera.Controls.Add(Me.actxnTCVentaSunat)
        Me.pnlCabecera.Controls.Add(Me.actxnTipoCambio)
        Me.pnlCabecera.Controls.Add(Me.lblVenDolarSunat)
        Me.pnlCabecera.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlCabecera.Location = New System.Drawing.Point(0, 0)
        Me.pnlCabecera.Name = "pnlCabecera"
        Me.pnlCabecera.Size = New System.Drawing.Size(1136, 126)
        Me.pnlCabecera.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Enabled = False
        Me.Label6.Location = New System.Drawing.Point(926, 78)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 15)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Plazo :"
        '
        'actxaCliRazonSocial
        '
        Me.actxaCliRazonSocial.ACActivarAyudaAuto = False
        Me.actxaCliRazonSocial.ACLongitudAceptada = 0
        Me.actxaCliRazonSocial.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.actxaCliRazonSocial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.actxaCliRazonSocial.Location = New System.Drawing.Point(321, 48)
        Me.actxaCliRazonSocial.MaxLength = 32767
        Me.actxaCliRazonSocial.Name = "actxaCliRazonSocial"
        Me.actxaCliRazonSocial.Size = New System.Drawing.Size(805, 23)
        Me.actxaCliRazonSocial.TabIndex = 7
        Me.actxaCliRazonSocial.Tag = "EVO"
        '
        'cmbCondPago
        '
        Me.cmbCondPago.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbCondPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCondPago.FormattingEnabled = True
        Me.cmbCondPago.Location = New System.Drawing.Point(97, 99)
        Me.cmbCondPago.Name = "cmbCondPago"
        Me.cmbCondPago.Size = New System.Drawing.Size(331, 23)
        Me.cmbCondPago.TabIndex = 43
        Me.cmbCondPago.Tag = "EO"
        '
        'pnlCabHeader
        '
        Me.pnlCabHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(145, Byte), Integer))
        Me.pnlCabHeader.Controls.Add(Me.grpDocumento)
        Me.pnlCabHeader.Controls.Add(Me.txtOrdenCompra)
        Me.pnlCabHeader.Controls.Add(Me.Label34)
        Me.pnlCabHeader.Controls.Add(Me.dtpFecCaja)
        Me.pnlCabHeader.Controls.Add(Me.Label30)
        Me.pnlCabHeader.Controls.Add(Me.dtpFecEmision)
        Me.pnlCabHeader.Controls.Add(Me.Label1)
        Me.pnlCabHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlCabHeader.ForeColor = System.Drawing.Color.White
        Me.pnlCabHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlCabHeader.Name = "pnlCabHeader"
        Me.pnlCabHeader.Size = New System.Drawing.Size(1134, 43)
        Me.pnlCabHeader.TabIndex = 0
        '
        'grpDocumento
        '
        Me.grpDocumento.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(145, Byte), Integer))
        Me.grpDocumento.Controls.Add(Me.txtSerie)
        Me.grpDocumento.Controls.Add(Me.actxnNumero)
        Me.grpDocumento.Controls.Add(Me.cmbDocumento)
        Me.grpDocumento.Dock = System.Windows.Forms.DockStyle.Right
        Me.grpDocumento.ForeColor = System.Drawing.Color.White
        Me.grpDocumento.Location = New System.Drawing.Point(756, 0)
        Me.grpDocumento.Name = "grpDocumento"
        Me.grpDocumento.Size = New System.Drawing.Size(378, 43)
        Me.grpDocumento.TabIndex = 19
        Me.grpDocumento.TabStop = False
        Me.grpDocumento.Text = "Documento de Compra"
        '
        'txtSerie
        '
        Me.txtSerie.Location = New System.Drawing.Point(217, 16)
        Me.txtSerie.MaxLength = 4
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.Size = New System.Drawing.Size(50, 23)
        Me.txtSerie.TabIndex = 31
        '
        'actxnNumero
        '
        Me.actxnNumero.ACEnteros = 8
        Me.actxnNumero.ACFormato = "#######0"
        Me.actxnNumero.ACNegativo = True
        Me.actxnNumero.ACValue = New Decimal(New Integer() {0, 0, 0, 131072})
        Me.actxnNumero.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.actxnNumero.Location = New System.Drawing.Point(269, 16)
        Me.actxnNumero.MaxLength = 12
        Me.actxnNumero.Name = "actxnNumero"
        Me.actxnNumero.ReadOnly = True
        Me.actxnNumero.Size = New System.Drawing.Size(100, 23)
        Me.actxnNumero.TabIndex = 5
        Me.actxnNumero.Tag = "EVO"
        Me.actxnNumero.Text = "0"
        Me.actxnNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmbDocumento
        '
        Me.cmbDocumento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbDocumento.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(145, Byte), Integer))
        Me.cmbDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDocumento.Enabled = False
        Me.cmbDocumento.FormattingEnabled = True
        Me.cmbDocumento.Items.AddRange(New Object() {"Boleta", "Factura"})
        Me.cmbDocumento.Location = New System.Drawing.Point(5, 16)
        Me.cmbDocumento.Name = "cmbDocumento"
        Me.cmbDocumento.Size = New System.Drawing.Size(210, 23)
        Me.cmbDocumento.TabIndex = 1
        Me.cmbDocumento.Tag = "ECO"
        '
        'txtOrdenCompra
        '
        Me.txtOrdenCompra.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtOrdenCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOrdenCompra.Location = New System.Drawing.Point(657, 11)
        Me.txtOrdenCompra.Name = "txtOrdenCompra"
        Me.txtOrdenCompra.ReadOnly = True
        Me.txtOrdenCompra.Size = New System.Drawing.Size(89, 23)
        Me.txtOrdenCompra.TabIndex = 30
        Me.txtOrdenCompra.Tag = "V"
        '
        'Label34
        '
        Me.Label34.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label34.AutoSize = True
        Me.Label34.Enabled = False
        Me.Label34.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(557, 16)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(99, 13)
        Me.Label34.TabIndex = 29
        Me.Label34.Text = "Orden de Compra :"
        '
        'dtpFecCaja
        '
        Me.dtpFecCaja.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecCaja.Location = New System.Drawing.Point(326, 11)
        Me.dtpFecCaja.Name = "dtpFecCaja"
        Me.dtpFecCaja.Size = New System.Drawing.Size(96, 23)
        Me.dtpFecCaja.TabIndex = 24
        Me.dtpFecCaja.Tag = "E"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(206, 15)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(110, 15)
        Me.Label30.TabIndex = 23
        Me.Label30.Text = "Fecha Transacción :"
        '
        'dtpFecEmision
        '
        Me.dtpFecEmision.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecEmision.Location = New System.Drawing.Point(101, 11)
        Me.dtpFecEmision.Name = "dtpFecEmision"
        Me.dtpFecEmision.Size = New System.Drawing.Size(96, 23)
        Me.dtpFecEmision.TabIndex = 22
        Me.dtpFecEmision.Tag = "E"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 15)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Fecha Emi&sion :"
        '
        'actxaCliRuc
        '
        Me.actxaCliRuc.ACActivarAyudaAuto = False
        Me.actxaCliRuc.ACLongitudAceptada = 0
        Me.actxaCliRuc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.actxaCliRuc.Location = New System.Drawing.Point(97, 48)
        Me.actxaCliRuc.MaxLength = 32767
        Me.actxaCliRuc.Name = "actxaCliRuc"
        Me.actxaCliRuc.Size = New System.Drawing.Size(128, 23)
        Me.actxaCliRuc.TabIndex = 10
        Me.actxaCliRuc.Tag = "EVO"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(28, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 15)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Direccion :"
        '
        'txtDireccion
        '
        Me.txtDireccion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDireccion.Location = New System.Drawing.Point(97, 74)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.ReadOnly = True
        Me.txtDireccion.Size = New System.Drawing.Size(823, 23)
        Me.txtDireccion.TabIndex = 12
        Me.txtDireccion.Tag = "V"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 15)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Doc / R.U.C. :"
        '
        'lblMoneda
        '
        Me.lblMoneda.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMoneda.AutoSize = True
        Me.lblMoneda.Location = New System.Drawing.Point(441, 103)
        Me.lblMoneda.Name = "lblMoneda"
        Me.lblMoneda.Size = New System.Drawing.Size(57, 15)
        Me.lblMoneda.TabIndex = 35
        Me.lblMoneda.Text = "&Moneda :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(236, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "&Razon Social :"
        '
        'cmbMoneda
        '
        Me.cmbMoneda.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMoneda.DropDownWidth = 250
        Me.cmbMoneda.FormattingEnabled = True
        Me.cmbMoneda.Location = New System.Drawing.Point(506, 99)
        Me.cmbMoneda.Name = "cmbMoneda"
        Me.cmbMoneda.Size = New System.Drawing.Size(96, 23)
        Me.cmbMoneda.TabIndex = 36
        Me.cmbMoneda.Tag = "EO"
        '
        'dtpFecPlazo
        '
        Me.dtpFecPlazo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpFecPlazo.Enabled = False
        Me.dtpFecPlazo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecPlazo.Location = New System.Drawing.Point(1025, 74)
        Me.dtpFecPlazo.Name = "dtpFecPlazo"
        Me.dtpFecPlazo.Size = New System.Drawing.Size(101, 23)
        Me.dtpFecPlazo.TabIndex = 34
        Me.dtpFecPlazo.Tag = "E"
        '
        'actxnPlazo
        '
        Me.actxnPlazo.ACDecimales = 0
        Me.actxnPlazo.ACEnteros = 9
        Me.actxnPlazo.ACFormato = "########0"
        Me.actxnPlazo.ACNegativo = True
        Me.actxnPlazo.ACValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.actxnPlazo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.actxnPlazo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.actxnPlazo.Location = New System.Drawing.Point(974, 74)
        Me.actxnPlazo.MaxLength = 12
        Me.actxnPlazo.Name = "actxnPlazo"
        Me.actxnPlazo.Size = New System.Drawing.Size(49, 23)
        Me.actxnPlazo.TabIndex = 33
        Me.actxnPlazo.Text = "0"
        Me.actxnPlazo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(16, 103)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(75, 15)
        Me.Label19.TabIndex = 2
        Me.Label19.Text = "Cond. Pago :"
        '
        'Label31
        '
        Me.Label31.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(751, 103)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(82, 15)
        Me.Label31.TabIndex = 25
        Me.Label31.Text = "Tipo Cam&bio :"
        '
        'actxnTCVentaSunat
        '
        Me.actxnTCVentaSunat.ACDecimales = 4
        Me.actxnTCVentaSunat.ACEnteros = 9
        Me.actxnTCVentaSunat.ACFormato = "###,###,##0.0000"
        Me.actxnTCVentaSunat.ACNegativo = True
        Me.actxnTCVentaSunat.ACValue = New Decimal(New Integer() {0, 0, 0, 196608})
        Me.actxnTCVentaSunat.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.actxnTCVentaSunat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.actxnTCVentaSunat.Location = New System.Drawing.Point(1069, 99)
        Me.actxnTCVentaSunat.MaxLength = 12
        Me.actxnTCVentaSunat.Name = "actxnTCVentaSunat"
        Me.actxnTCVentaSunat.ReadOnly = True
        Me.actxnTCVentaSunat.Size = New System.Drawing.Size(57, 23)
        Me.actxnTCVentaSunat.TabIndex = 28
        Me.actxnTCVentaSunat.Text = "0.0000"
        Me.actxnTCVentaSunat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'actxnTipoCambio
        '
        Me.actxnTipoCambio.ACDecimales = 4
        Me.actxnTipoCambio.ACEnteros = 9
        Me.actxnTipoCambio.ACFormato = "###,###,##0.0000"
        Me.actxnTipoCambio.ACNegativo = True
        Me.actxnTipoCambio.ACValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.actxnTipoCambio.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.actxnTipoCambio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.actxnTipoCambio.Location = New System.Drawing.Point(838, 99)
        Me.actxnTipoCambio.MaxLength = 12
        Me.actxnTipoCambio.Name = "actxnTipoCambio"
        Me.actxnTipoCambio.ReadOnly = True
        Me.actxnTipoCambio.Size = New System.Drawing.Size(52, 23)
        Me.actxnTipoCambio.TabIndex = 26
        Me.actxnTipoCambio.Text = "0.0000"
        Me.actxnTipoCambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblVenDolarSunat
        '
        Me.lblVenDolarSunat.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblVenDolarSunat.AutoSize = True
        Me.lblVenDolarSunat.Location = New System.Drawing.Point(896, 103)
        Me.lblVenDolarSunat.Name = "lblVenDolarSunat"
        Me.lblVenDolarSunat.Size = New System.Drawing.Size(123, 15)
        Me.lblVenDolarSunat.TabIndex = 27
        Me.lblVenDolarSunat.Text = "Venta Dolar Sunat : {0}"
        '
        'tabBusqueda
        '
        Me.tabBusqueda.Controls.Add(Me.c1grdBusqueda)
        Me.tabBusqueda.Controls.Add(Me.grpBusqueda)
        Me.tabBusqueda.Controls.Add(Me.bnavBusqueda)
        Me.tabBusqueda.InactiveBackColor = System.Drawing.Color.Empty
        Me.tabBusqueda.InactiveTextBackColor = System.Drawing.Color.Empty
        Me.tabBusqueda.InactiveTextColor = System.Drawing.Color.Empty
        Me.tabBusqueda.Location = New System.Drawing.Point(1, 1)
        Me.tabBusqueda.Name = "tabBusqueda"
        Me.tabBusqueda.SelectBackColor = System.Drawing.Color.Empty
        Me.tabBusqueda.SelectTextBackColor = System.Drawing.Color.Empty
        Me.tabBusqueda.SelectTextColor = System.Drawing.Color.Empty
        Me.tabBusqueda.Size = New System.Drawing.Size(1136, 515)
        Me.tabBusqueda.TabIndex = 5
        Me.tabBusqueda.Title = "Busqueda"
        Me.tabBusqueda.ToolTip = "Busqueda"
        '
        'c1grdBusqueda
        '
        Me.c1grdBusqueda.AutoClipboard = True
        Me.c1grdBusqueda.ColumnInfo = "2,1,0,0,0,100,Columns:0{Width:25;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.c1grdBusqueda.Dock = System.Windows.Forms.DockStyle.Fill
        Me.c1grdBusqueda.Location = New System.Drawing.Point(0, 92)
        Me.c1grdBusqueda.Name = "c1grdBusqueda"
        Me.c1grdBusqueda.Rows.Count = 2
        Me.c1grdBusqueda.Rows.DefaultSize = 20
        Me.c1grdBusqueda.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.c1grdBusqueda.Size = New System.Drawing.Size(1136, 398)
        Me.c1grdBusqueda.StyleInfo = resources.GetString("c1grdBusqueda.StyleInfo")
        Me.c1grdBusqueda.TabIndex = 6
        '
        'grpBusqueda
        '
        Me.grpBusqueda.Controls.Add(Me.btnConsultar)
        Me.grpBusqueda.Controls.Add(Me.rbtnNroDocumento)
        Me.grpBusqueda.Controls.Add(Me.rbtnProveedor)
        Me.grpBusqueda.Controls.Add(Me.grpCliente)
        Me.grpBusqueda.Controls.Add(Me.grpDocumentos)
        Me.grpBusqueda.Controls.Add(Me.chkTodos)
        Me.grpBusqueda.Controls.Add(Me.AcFecha)
        Me.grpBusqueda.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpBusqueda.Location = New System.Drawing.Point(0, 0)
        Me.grpBusqueda.Name = "grpBusqueda"
        Me.grpBusqueda.Size = New System.Drawing.Size(1136, 92)
        Me.grpBusqueda.TabIndex = 5
        Me.grpBusqueda.TabStop = False
        Me.grpBusqueda.Text = "Opciones de Busqueda"
        '
        'btnConsultar
        '
        Me.btnConsultar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnConsultar.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.btnConsultar.Image = Global.ACPLogistica.My.Resources.Resources.Buscar2_32x32
        Me.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConsultar.Location = New System.Drawing.Point(1035, 47)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(95, 42)
        Me.btnConsultar.TabIndex = 33
        Me.btnConsultar.Text = "Consultar"
        Me.btnConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'rbtnNroDocumento
        '
        Me.rbtnNroDocumento.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbtnNroDocumento.AutoSize = True
        Me.rbtnNroDocumento.Location = New System.Drawing.Point(401, 35)
        Me.rbtnNroDocumento.Name = "rbtnNroDocumento"
        Me.rbtnNroDocumento.Size = New System.Drawing.Size(88, 19)
        Me.rbtnNroDocumento.TabIndex = 2
        Me.rbtnNroDocumento.Text = "Documento"
        Me.rbtnNroDocumento.UseVisualStyleBackColor = True
        '
        'rbtnProveedor
        '
        Me.rbtnProveedor.AutoSize = True
        Me.rbtnProveedor.Checked = True
        Me.rbtnProveedor.Location = New System.Drawing.Point(19, 35)
        Me.rbtnProveedor.Name = "rbtnProveedor"
        Me.rbtnProveedor.Size = New System.Drawing.Size(79, 19)
        Me.rbtnProveedor.TabIndex = 1
        Me.rbtnProveedor.TabStop = True
        Me.rbtnProveedor.Text = "Proveedor"
        Me.rbtnProveedor.UseVisualStyleBackColor = True
        '
        'grpCliente
        '
        Me.grpCliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpCliente.Controls.Add(Me.txtBusqueda)
        Me.grpCliente.Location = New System.Drawing.Point(6, 38)
        Me.grpCliente.Name = "grpCliente"
        Me.grpCliente.Size = New System.Drawing.Size(374, 49)
        Me.grpCliente.TabIndex = 7
        Me.grpCliente.TabStop = False
        '
        'txtBusqueda
        '
        Me.txtBusqueda.ACActivarAyudaAuto = False
        Me.txtBusqueda.ACLongitudAceptada = 0
        Me.txtBusqueda.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBusqueda.Location = New System.Drawing.Point(9, 19)
        Me.txtBusqueda.MaxLength = 32767
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(355, 23)
        Me.txtBusqueda.TabIndex = 0
        '
        'grpDocumentos
        '
        Me.grpDocumentos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpDocumentos.Controls.Add(Me.txtBusSerie)
        Me.grpDocumentos.Controls.Add(Me.cmbTipoDocumento)
        Me.grpDocumentos.Controls.Add(Me.txtBusNumero)
        Me.grpDocumentos.Location = New System.Drawing.Point(386, 38)
        Me.grpDocumentos.Name = "grpDocumentos"
        Me.grpDocumentos.Size = New System.Drawing.Size(410, 49)
        Me.grpDocumentos.TabIndex = 5
        Me.grpDocumentos.TabStop = False
        '
        'txtBusSerie
        '
        Me.txtBusSerie.Location = New System.Drawing.Point(245, 19)
        Me.txtBusSerie.MaxLength = 4
        Me.txtBusSerie.Name = "txtBusSerie"
        Me.txtBusSerie.Size = New System.Drawing.Size(50, 23)
        Me.txtBusSerie.TabIndex = 1
        '
        'cmbTipoDocumento
        '
        Me.cmbTipoDocumento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoDocumento.FormattingEnabled = True
        Me.cmbTipoDocumento.Location = New System.Drawing.Point(10, 19)
        Me.cmbTipoDocumento.Name = "cmbTipoDocumento"
        Me.cmbTipoDocumento.Size = New System.Drawing.Size(231, 23)
        Me.cmbTipoDocumento.TabIndex = 0
        '
        'txtBusNumero
        '
        Me.txtBusNumero.ACActivarAyudaAuto = False
        Me.txtBusNumero.ACLongitudAceptada = 0
        Me.txtBusNumero.ACTipo = ACControles.ACTextBoxAyuda.TipoTextBoxAyuda.Numerico
        Me.txtBusNumero.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBusNumero.Location = New System.Drawing.Point(301, 19)
        Me.txtBusNumero.MaxLength = 32767
        Me.txtBusNumero.Name = "txtBusNumero"
        Me.txtBusNumero.Size = New System.Drawing.Size(99, 23)
        Me.txtBusNumero.TabIndex = 3
        '
        'chkTodos
        '
        Me.chkTodos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkTodos.AutoSize = True
        Me.chkTodos.Location = New System.Drawing.Point(927, 52)
        Me.chkTodos.Name = "chkTodos"
        Me.chkTodos.Size = New System.Drawing.Size(102, 19)
        Me.chkTodos.TabIndex = 4
        Me.chkTodos.Text = "Mostrar Todos"
        Me.chkTodos.UseVisualStyleBackColor = True
        '
        'AcFecha
        '
        Me.AcFecha.ACFecha_A = Nothing
        Me.AcFecha.ACFecha_De = Nothing
        Me.AcFecha.ACFechaChecked = False
        Me.AcFecha.ACFormatoControl = ACControles.ACFecha.ACTipoFormatoControl.Horizontal
        Me.AcFecha.ACHoyChecked = False
        Me.AcFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AcFecha.Location = New System.Drawing.Point(799, 0)
        Me.AcFecha.MaximumSize = New System.Drawing.Size(337, 43)
        Me.AcFecha.MinimumSize = New System.Drawing.Size(337, 43)
        Me.AcFecha.Name = "AcFecha"
        Me.AcFecha.Size = New System.Drawing.Size(337, 43)
        Me.AcFecha.TabIndex = 3
        Me.AcFecha.TabStop = False
        '
        'bnavBusqueda
        '
        Me.bnavBusqueda.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.bnavBusqueda.CountItem = Me.BindingNavigatorCountItem
        Me.bnavBusqueda.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.bnavBusqueda.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.bnavBusqueda.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem})
        Me.bnavBusqueda.Location = New System.Drawing.Point(0, 490)
        Me.bnavBusqueda.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.bnavBusqueda.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.bnavBusqueda.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.bnavBusqueda.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.bnavBusqueda.Name = "bnavBusqueda"
        Me.bnavBusqueda.PositionItem = Me.BindingNavigatorPositionItem
        Me.bnavBusqueda.Size = New System.Drawing.Size(1136, 25)
        Me.bnavBusqueda.TabIndex = 3
        Me.bnavBusqueda.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        Me.BindingNavigatorAddNewItem.Visible = False
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        Me.BindingNavigatorDeleteItem.Visible = False
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 21)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'MCompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1138, 625)
        Me.Controls.Add(Me.tabMantenimiento)
        Me.Controls.Add(Me.acpnlTitulo)
        Me.Controls.Add(Me.actool)
        Me.Name = "MCompras"
        Me.Text = "MCompras"
        Me.actool.ResumeLayout(False)
        Me.actool.PerformLayout()
        Me.tabMantenimiento.ResumeLayout(False)
        Me.tabDatos.ResumeLayout(False)
        Me.pnlDatos.ResumeLayout(False)
        Me.pnlDetalle.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.c1grdDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bnavProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bnavProductos.ResumeLayout(False)
        Me.bnavProductos.PerformLayout()
        Me.tbcDetalles.ResumeLayout(False)
        Me.tpgAdmin.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.tpgDetAnulacion.ResumeLayout(False)
        Me.tpgDetAnulacion.PerformLayout()
        Me.tpgAdicionales.ResumeLayout(False)
        Me.tpgAdicionales.PerformLayout()
        Me.tpgGuias.ResumeLayout(False)
        Me.tpgGuias.PerformLayout()
        CType(Me.c1grdGuiasRemision, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bnavGuiasRemision, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bnavGuiasRemision.ResumeLayout(False)
        Me.bnavGuiasRemision.PerformLayout()
        Me.tpgOrden.ResumeLayout(False)
        Me.tpgOrden.PerformLayout()
        CType(Me.c1grdOrdenes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bnavOrdenes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bnavOrdenes.ResumeLayout(False)
        Me.bnavOrdenes.PerformLayout()
        Me.tpgPagos.ResumeLayout(False)
        Me.tpgPagos.PerformLayout()
        CType(Me.c1grdPagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bnavPagos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bnavPagos.ResumeLayout(False)
        Me.bnavPagos.PerformLayout()
        Me.tpgPendiente.ResumeLayout(False)
        Me.tpgPendiente.PerformLayout()
        CType(Me.c1grdPendientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bnavNotas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bnavNotas.ResumeLayout(False)
        Me.bnavNotas.PerformLayout()
        Me.tpgNotas.ResumeLayout(False)
        Me.tpgNotas.PerformLayout()
        CType(Me.c1grdNotasCredito, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        Me.tpgLetras.ResumeLayout(False)
        Me.tpgLetras.PerformLayout()
        CType(Me.c1grdLetras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bnavLetras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bnavLetras.ResumeLayout(False)
        Me.bnavLetras.PerformLayout()
        Me.tpgAlmacen.ResumeLayout(False)
        Me.tpgAlmacen.PerformLayout()
        CType(Me.c1grdAlmacen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator2.ResumeLayout(False)
        Me.BindingNavigator2.PerformLayout()
        Me.pnlPie.ResumeLayout(False)
        Me.grpDetalleDocumento.ResumeLayout(False)
        Me.grpDetalleDocumento.PerformLayout()
        Me.pnlDetProductos.ResumeLayout(False)
        Me.pnlDetProductos.PerformLayout()
        Me.grpDetPago.ResumeLayout(False)
        Me.grpDetPago.PerformLayout()
        Me.pnlCabecera.ResumeLayout(False)
        Me.pnlCabecera.PerformLayout()
        Me.pnlCabHeader.ResumeLayout(False)
        Me.pnlCabHeader.PerformLayout()
        Me.grpDocumento.ResumeLayout(False)
        Me.grpDocumento.PerformLayout()
        Me.tabBusqueda.ResumeLayout(False)
        Me.tabBusqueda.PerformLayout()
        CType(Me.c1grdBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpBusqueda.ResumeLayout(False)
        Me.grpBusqueda.PerformLayout()
        Me.grpCliente.ResumeLayout(False)
        Me.grpCliente.PerformLayout()
        Me.grpDocumentos.ResumeLayout(False)
        Me.grpDocumentos.PerformLayout()
        CType(Me.bnavBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bnavBusqueda.ResumeLayout(False)
        Me.bnavBusqueda.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents actool As ACControles.ACToolBarMantHorizontalNew
    Friend WithEvents tsbtnPrevisualizar As ACControles.ACToolStripButton
    Friend WithEvents acpnlTitulo As ACControles.ACPanelCaption
    Private WithEvents tabMantenimiento As Crownwood.DotNetMagic.Controls.TabControl
    Private WithEvents tabDatos As Crownwood.DotNetMagic.Controls.TabPage
    Friend WithEvents pnlDatos As System.Windows.Forms.Panel
    Friend WithEvents pnlDetalle As System.Windows.Forms.Panel
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents c1grdDetalle As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents bnavProductos As System.Windows.Forms.BindingNavigator
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton6 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator13 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents tbcDetalles As Crownwood.DotNetMagic.Controls.TabControl
    Friend WithEvents tpgAdmin As Crownwood.DotNetMagic.Controls.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkPaseAnularDocumentos As System.Windows.Forms.CheckBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbtnGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator24 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tpgDetAnulacion As Crownwood.DotNetMagic.Controls.TabPage
    Friend WithEvents chkAnuladoCaja As System.Windows.Forms.CheckBox
    Friend WithEvents txtMotivoAnulacion As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaAnulacion As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tpgAdicionales As Crownwood.DotNetMagic.Controls.TabPage
    Friend WithEvents dtpFecImpresion As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpHoraImpresion As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents dtpFecCreacion As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpHoraCreacion As System.Windows.Forms.DateTimePicker
    Friend WithEvents actxaDescFacturador As ACControles.ACTextBoxAyuda
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents actxaCodCotizador As ACControles.ACTextBoxAyuda
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents chkRevisionCaja As System.Windows.Forms.CheckBox
    Friend WithEvents chkAnulada As System.Windows.Forms.CheckBox
    Friend WithEvents txtCotizacionC As System.Windows.Forms.TextBox
    Friend WithEvents chkStockDevuelto As System.Windows.Forms.CheckBox
    Friend WithEvents txtTelFax As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents actxaDescCotizador As ACControles.ACTextBoxAyuda
    Friend WithEvents chkPendiente As System.Windows.Forms.CheckBox
    Friend WithEvents txtDirigida As System.Windows.Forms.TextBox
    Friend WithEvents actxaCodFacturador As ACControles.ACTextBoxAyuda
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Private WithEvents tpgGuias As Crownwood.DotNetMagic.Controls.TabPage
    Friend WithEvents c1grdGuiasRemision As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents bnavGuiasRemision As System.Windows.Forms.BindingNavigator
    Friend WithEvents ToolStripButton19 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel4 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton20 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton21 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton22 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripTextBox4 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator11 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton23 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton24 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator12 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents tpgOrden As Crownwood.DotNetMagic.Controls.TabPage
    Friend WithEvents c1grdOrdenes As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents bnavOrdenes As System.Windows.Forms.BindingNavigator
    Friend WithEvents ToolStripButton13 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton14 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton15 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton16 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripTextBox3 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton17 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton18 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tpgPagos As Crownwood.DotNetMagic.Controls.TabPage
    Friend WithEvents c1grdPagos As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents bnavPagos As System.Windows.Forms.BindingNavigator
    Friend WithEvents ToolStripButton25 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel7 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton26 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton31 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton32 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator17 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripTextBox6 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator18 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton33 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton34 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator19 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AcPanelCaption2 As ACControles.ACPanelCaption
    Friend WithEvents tpgPendiente As Crownwood.DotNetMagic.Controls.TabPage
    Friend WithEvents c1grdPendientes As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents AcPanelCaption1 As ACControles.ACPanelCaption
    Friend WithEvents bnavNotas As System.Windows.Forms.BindingNavigator
    Friend WithEvents ToolStripButton35 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel8 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton36 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton37 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton38 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator20 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripTextBox7 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator21 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton39 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton40 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator22 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator23 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tpgNotas As Crownwood.DotNetMagic.Controls.TabPage
    Friend WithEvents c1grdNotasCredito As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents BindingNavigator1 As System.Windows.Forms.BindingNavigator
    Friend WithEvents ToolStripButton7 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton8 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton9 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton10 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripTextBox2 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton11 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton12 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tpgLetras As Crownwood.DotNetMagic.Controls.TabPage
    Friend WithEvents c1grdLetras As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents bnavLetras As System.Windows.Forms.BindingNavigator
    Friend WithEvents ToolStripLabel6 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton27 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton28 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator14 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripTextBox5 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator15 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton29 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton30 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator16 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbtnAddLetra As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnQuitLetra As System.Windows.Forms.ToolStripButton
    Friend WithEvents tpgCheques As Crownwood.DotNetMagic.Controls.TabPage
    Friend WithEvents tpgAlmacen As Crownwood.DotNetMagic.Controls.TabPage
    Friend WithEvents c1grdAlmacen As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents AcPanelCaption3 As ACControles.ACPanelCaption
    Friend WithEvents BindingNavigator2 As System.Windows.Forms.BindingNavigator
    Friend WithEvents ToolStripButton41 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel9 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton42 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton43 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton44 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator25 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripTextBox8 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator26 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton45 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton46 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator27 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator28 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbtnAnularEntregaAlmacen As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnAnularTodoEntregaAlmacen As System.Windows.Forms.ToolStripButton
    Friend WithEvents pnlPie As System.Windows.Forms.Panel
    Friend WithEvents grpDetalleDocumento As System.Windows.Forms.GroupBox
    Friend WithEvents pnlDetProductos As System.Windows.Forms.Panel
    Friend WithEvents actxnPDetraccion As ACControles.ACTextBoxNumerico
    Friend WithEvents lblPDetraccion As System.Windows.Forms.Label
    Friend WithEvents actxnDetraccionSoles As ACControles.ACTextBoxNumerico
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents actxnPRetencion As ACControles.ACTextBoxNumerico
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents actxnRetencionSoles As ACControles.ACTextBoxNumerico
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents actxnPercepcionSoles As ACControles.ACTextBoxNumerico
    Friend WithEvents actxnPesoTotal As ACControles.ACTextBoxNumerico
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents actxnPercepcionMO As ACControles.ACTextBoxNumerico
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents actxnAfectoPercepcionSoles As ACControles.ACTextBoxNumerico
    Friend WithEvents actxnAfectoPercepcionMO As ACControles.ACTextBoxNumerico
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents grpDetPago As System.Windows.Forms.GroupBox
    Friend WithEvents lblDetraccion As System.Windows.Forms.Label
    Friend WithEvents actxnVDetraccion As ACControles.ACTextBoxNumerico
    Friend WithEvents lblRetencion As System.Windows.Forms.Label
    Friend WithEvents actxnVRetencion As ACControles.ACTextBoxNumerico
    Friend WithEvents lblVPercepcion As System.Windows.Forms.Label
    Friend WithEvents lblImporte As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lbligv As System.Windows.Forms.Label
    Friend WithEvents lblTotalPagar As System.Windows.Forms.Label
    Friend WithEvents actxnImporte As ACControles.ACTextBoxNumerico
    Friend WithEvents actxnIGV As ACControles.ACTextBoxNumerico
    Friend WithEvents actxnTotalPagar As ACControles.ACTextBoxNumerico
    Friend WithEvents actxnTotal As ACControles.ACTextBoxNumerico
    Friend WithEvents actxnPercepcion As ACControles.ACTextBoxNumerico
    Friend WithEvents pnlCabecera As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents actxaCliRazonSocial As ACControles.ACTextBoxAyuda
    Friend WithEvents cmbCondPago As System.Windows.Forms.ComboBox
    Friend WithEvents pnlCabHeader As System.Windows.Forms.Panel
    Friend WithEvents grpDocumento As System.Windows.Forms.GroupBox
    Friend WithEvents actxnNumero As ACControles.ACTextBoxNumerico
    Friend WithEvents cmbDocumento As System.Windows.Forms.ComboBox
    Friend WithEvents txtOrdenCompra As System.Windows.Forms.TextBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents dtpFecCaja As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents dtpFecEmision As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents actxaCliRuc As ACControles.ACTextBoxAyuda
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblMoneda As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbMoneda As System.Windows.Forms.ComboBox
    Friend WithEvents dtpFecPlazo As System.Windows.Forms.DateTimePicker
    Friend WithEvents actxnPlazo As ACControles.ACTextBoxNumerico
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents actxnTCVentaSunat As ACControles.ACTextBoxNumerico
    Friend WithEvents actxnTipoCambio As ACControles.ACTextBoxNumerico
    Friend WithEvents lblVenDolarSunat As System.Windows.Forms.Label
    Private WithEvents tabBusqueda As Crownwood.DotNetMagic.Controls.TabPage
    Friend WithEvents c1grdBusqueda As C1.Win.C1FlexGrid.C1FlexGrid
    Private WithEvents grpBusqueda As System.Windows.Forms.GroupBox
    Friend WithEvents btnConsultar As System.Windows.Forms.Button
    Friend WithEvents rbtnNroDocumento As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnProveedor As System.Windows.Forms.RadioButton
    Friend WithEvents grpCliente As System.Windows.Forms.GroupBox
    Friend WithEvents txtBusqueda As ACControles.ACTextBoxAyuda
    Friend WithEvents grpDocumentos As System.Windows.Forms.GroupBox
    Friend WithEvents cmbTipoDocumento As System.Windows.Forms.ComboBox
    Friend WithEvents txtBusNumero As ACControles.ACTextBoxAyuda
    Friend WithEvents chkTodos As System.Windows.Forms.CheckBox
    Friend WithEvents AcFecha As ACControles.ACFecha
    Friend WithEvents bnavBusqueda As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents txtBusSerie As System.Windows.Forms.TextBox
    Friend WithEvents txtSerie As System.Windows.Forms.TextBox
    Friend WithEvents actxnFlete As ACControles.ACTextBoxNumerico
    Friend WithEvents actxnGastos As ACControles.ACTextBoxNumerico
    Friend WithEvents actxnDescuento As ACControles.ACTextBoxNumerico
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
