<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RGuias
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RGuias))
        Me.tabMantenimiento = New Crownwood.DotNetMagic.Controls.TabControl()
        Me.tabDatos = New Crownwood.DotNetMagic.Controls.TabPage()
        Me.pnlDatos = New System.Windows.Forms.Panel()
        Me.pnlDetalle = New System.Windows.Forms.Panel()
        Me.c1grdDetalle = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.tbcDetalles = New Crownwood.DotNetMagic.Controls.TabControl()
        Me.tpgDetAnulacion = New Crownwood.DotNetMagic.Controls.TabPage()
        Me.txtMotivoAnulacion = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.dtpFechaAnulacion = New System.Windows.Forms.DateTimePicker()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.pnlItem = New System.Windows.Forms.Panel()
        Me.txtProdUnidad = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.actxnProdPeso = New ACControles.ACTextBoxNumerico()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtOpcion = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtProdDescripcion = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.actxaProdCodigo = New ACControles.ACTextBoxAyuda()
        Me.actxnProdCantidad = New ACControles.ACTextBoxNumerico()
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
        Me.tscmbImpresora = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripLabel5 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator13 = New System.Windows.Forms.ToolStripSeparator()
        Me.pnlPie = New System.Windows.Forms.Panel()
        Me.btnRevision = New System.Windows.Forms.Button()
        Me.actxnPesoTotal = New ACControles.ACTextBoxNumerico()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.grpDocumento = New System.Windows.Forms.GroupBox()
        Me.cmbGuia = New System.Windows.Forms.ComboBox()
        Me.actxnNumero = New ACControles.ACTextBoxNumerico()
        Me.cmbGuiaSerie = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.pnlCabecera = New System.Windows.Forms.Panel()
        Me.cmbDirOrigenSalTrans = New System.Windows.Forms.ComboBox()
        Me.cmbDirDestino = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtPesoVehiculo = New System.Windows.Forms.TextBox()
        Me.actxaCodDirDestino = New ACControles.ACTextBoxAyuda()
        Me.txtAlmDestino = New System.Windows.Forms.TextBox()
        Me.cmbDirOrigen = New System.Windows.Forms.ComboBox()
        Me.grpFlete = New System.Windows.Forms.GroupBox()
        Me.txtNroDocVenta = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpFechaEmision = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbMotTraslado = New System.Windows.Forms.ComboBox()
        Me.dtpFechaTraslado = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtLicenciaConducir = New System.Windows.Forms.TextBox()
        Me.lblDescVehiculo = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtCertificado = New System.Windows.Forms.TextBox()
        Me.lblNomConductor = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.actxaDescVehiculo = New ACControles.ACTextBoxAyuda()
        Me.actxaDescConductor = New ACControles.ACTextBoxAyuda()
        Me.actxaCodVehiculo = New ACControles.ACTextBoxAyuda()
        Me.actxaDescTransportista = New ACControles.ACTextBoxAyuda()
        Me.actxaCodConductor = New ACControles.ACTextBoxAyuda()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.actxaCodTransportista = New ACControles.ACTextBoxAyuda()
        Me.txtAlmOrigen = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.actxaDescCliente = New ACControles.ACTextBoxAyuda()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.actxaCodCliente = New ACControles.ACTextBoxAyuda()
        Me.tabBusGuias = New Crownwood.DotNetMagic.Controls.TabPage()
        Me.c1grdReporte = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.c1grdPuntosVentas = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.chkctodos = New System.Windows.Forms.CheckBox()
        Me.btnExcel = New System.Windows.Forms.Button()
        Me.rbtncliente = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.actxaCliRazonSocial = New ACControles.ACTextBoxAyuda()
        Me.actxaCliRuc = New ACControles.ACTextBoxAyuda()
        Me.btnProcesar = New System.Windows.Forms.Button()
        Me.AcFecha = New ACControles.ACFecha(Me.components)
        Me.bnavCBusqueda = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.tsbtnExcel = New System.Windows.Forms.ToolStripButton()
        Me.acpnlTitulo = New ACControles.ACPanelCaption()
        Me.acTool = New ACControles.ACToolBarMantHorizontalNew(Me.components)
        Me.actsbtnPrevisualizar = New ACControles.ACToolStripButton(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnRevision2 = New System.Windows.Forms.Button()
        Me.tabMantenimiento.SuspendLayout
        Me.tabDatos.SuspendLayout
        Me.pnlDatos.SuspendLayout
        Me.pnlDetalle.SuspendLayout
        CType(Me.c1grdDetalle,System.ComponentModel.ISupportInitialize).BeginInit
        Me.tbcDetalles.SuspendLayout
        Me.tpgDetAnulacion.SuspendLayout
        Me.pnlItem.SuspendLayout
        CType(Me.bnavProductos,System.ComponentModel.ISupportInitialize).BeginInit
        Me.bnavProductos.SuspendLayout
        Me.pnlPie.SuspendLayout
        Me.grpDocumento.SuspendLayout
        Me.pnlCabecera.SuspendLayout
        Me.grpFlete.SuspendLayout
        Me.tabBusGuias.SuspendLayout
        CType(Me.c1grdReporte,System.ComponentModel.ISupportInitialize).BeginInit
        Me.Panel1.SuspendLayout
        Me.GroupBox4.SuspendLayout
        CType(Me.c1grdPuntosVentas,System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox1.SuspendLayout
        CType(Me.bnavCBusqueda,System.ComponentModel.ISupportInitialize).BeginInit
        Me.bnavCBusqueda.SuspendLayout
        Me.acTool.SuspendLayout
        Me.SuspendLayout
        '
        'tabMantenimiento
        '
        Me.tabMantenimiento.BackColor = System.Drawing.Color.LightSteelBlue
        Me.tabMantenimiento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabMantenimiento.Location = New System.Drawing.Point(0, 33)
        Me.tabMantenimiento.MediaPlayerDockSides = false
        Me.tabMantenimiento.Name = "tabMantenimiento"
        Me.tabMantenimiento.OfficeDockSides = false
        Me.tabMantenimiento.SelectedIndex = 0
        Me.tabMantenimiento.ShowDropSelect = false
        Me.tabMantenimiento.Size = New System.Drawing.Size(1268, 611)
        Me.tabMantenimiento.TabIndex = 17
        Me.tabMantenimiento.TabPages.AddRange(New Crownwood.DotNetMagic.Controls.TabPage() {Me.tabDatos, Me.tabBusGuias})
        Me.tabMantenimiento.TextTips = true
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
        Me.tabDatos.SelectTextBackColor = System.Drawing.Color.Empty
        Me.tabDatos.SelectTextColor = System.Drawing.Color.Empty
        Me.tabDatos.Size = New System.Drawing.Size(1266, 586)
        Me.tabDatos.TabIndex = 1
        Me.tabDatos.Title = "Datos"
        Me.tabDatos.ToolTip = "Datos"
        '
        'pnlDatos
        '
        Me.pnlDatos.Controls.Add(Me.pnlDetalle)
        Me.pnlDatos.Controls.Add(Me.pnlCabecera)
        Me.pnlDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDatos.Location = New System.Drawing.Point(0, 0)
        Me.pnlDatos.Name = "pnlDatos"
        Me.pnlDatos.Size = New System.Drawing.Size(1266, 586)
        Me.pnlDatos.TabIndex = 1
        '
        'pnlDetalle
        '
        Me.pnlDetalle.Controls.Add(Me.c1grdDetalle)
        Me.pnlDetalle.Controls.Add(Me.tbcDetalles)
        Me.pnlDetalle.Controls.Add(Me.pnlItem)
        Me.pnlDetalle.Controls.Add(Me.bnavProductos)
        Me.pnlDetalle.Controls.Add(Me.pnlPie)
        Me.pnlDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDetalle.Location = New System.Drawing.Point(0, 209)
        Me.pnlDetalle.Name = "pnlDetalle"
        Me.pnlDetalle.Size = New System.Drawing.Size(1266, 377)
        Me.pnlDetalle.TabIndex = 2
        '
        'c1grdDetalle
        '
        Me.c1grdDetalle.BackColor = System.Drawing.Color.White
        Me.c1grdDetalle.ColumnInfo = "2,1,0,0,0,100,Columns:0{Width:20;}"&Global.Microsoft.VisualBasic.ChrW(9)&"1{Width:103;Caption:""Codigo"";}"&Global.Microsoft.VisualBasic.ChrW(9)
        Me.c1grdDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.c1grdDetalle.Location = New System.Drawing.Point(0, 49)
        Me.c1grdDetalle.Name = "c1grdDetalle"
        Me.c1grdDetalle.Rows.Count = 2
        Me.c1grdDetalle.Rows.DefaultSize = 20
        Me.c1grdDetalle.Size = New System.Drawing.Size(842, 253)
        Me.c1grdDetalle.StyleInfo = resources.GetString("c1grdDetalle.StyleInfo")
        Me.c1grdDetalle.TabIndex = 16
        '
        'tbcDetalles
        '
        Me.tbcDetalles.BackColor = System.Drawing.Color.LightSteelBlue
        Me.tbcDetalles.BoldSelectedPage = true
        Me.tbcDetalles.Dock = System.Windows.Forms.DockStyle.Right
        Me.tbcDetalles.Location = New System.Drawing.Point(842, 49)
        Me.tbcDetalles.MediaPlayerDockSides = false
        Me.tbcDetalles.Name = "tbcDetalles"
        Me.tbcDetalles.OfficeDockSides = false
        Me.tbcDetalles.PositionTop = true
        Me.tbcDetalles.SelectedIndex = 0
        Me.tbcDetalles.ShowArrows = true
        Me.tbcDetalles.ShowDropSelect = false
        Me.tbcDetalles.Size = New System.Drawing.Size(424, 253)
        Me.tbcDetalles.TabIndex = 15
        Me.tbcDetalles.TabPages.AddRange(New Crownwood.DotNetMagic.Controls.TabPage() {Me.tpgDetAnulacion})
        Me.tbcDetalles.TextTips = true
        Me.tbcDetalles.Visible = false
        '
        'tpgDetAnulacion
        '
        Me.tpgDetAnulacion.Controls.Add(Me.txtMotivoAnulacion)
        Me.tpgDetAnulacion.Controls.Add(Me.Label18)
        Me.tpgDetAnulacion.Controls.Add(Me.dtpFechaAnulacion)
        Me.tpgDetAnulacion.Controls.Add(Me.Label21)
        Me.tpgDetAnulacion.InactiveBackColor = System.Drawing.Color.Empty
        Me.tpgDetAnulacion.InactiveTextBackColor = System.Drawing.Color.Empty
        Me.tpgDetAnulacion.InactiveTextColor = System.Drawing.Color.Empty
        Me.tpgDetAnulacion.Location = New System.Drawing.Point(1, 24)
        Me.tpgDetAnulacion.Name = "tpgDetAnulacion"
        Me.tpgDetAnulacion.SelectBackColor = System.Drawing.Color.Empty
        Me.tpgDetAnulacion.SelectTextBackColor = System.Drawing.Color.Empty
        Me.tpgDetAnulacion.SelectTextColor = System.Drawing.Color.Empty
        Me.tpgDetAnulacion.Size = New System.Drawing.Size(422, 228)
        Me.tpgDetAnulacion.TabIndex = 9
        Me.tpgDetAnulacion.Title = "Det. Anulación"
        Me.tpgDetAnulacion.ToolTip = "Detalle Anulación"
        '
        'txtMotivoAnulacion
        '
        Me.txtMotivoAnulacion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtMotivoAnulacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMotivoAnulacion.Location = New System.Drawing.Point(70, 40)
        Me.txtMotivoAnulacion.Multiline = true
        Me.txtMotivoAnulacion.Name = "txtMotivoAnulacion"
        Me.txtMotivoAnulacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtMotivoAnulacion.Size = New System.Drawing.Size(342, 139)
        Me.txtMotivoAnulacion.TabIndex = 40
        Me.txtMotivoAnulacion.Tag = "EV"
        '
        'Label18
        '
        Me.Label18.AutoSize = true
        Me.Label18.Location = New System.Drawing.Point(12, 42)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(51, 15)
        Me.Label18.TabIndex = 39
        Me.Label18.Text = "Motivo :"
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
        'Label21
        '
        Me.Label21.AutoSize = true
        Me.Label21.Location = New System.Drawing.Point(19, 13)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(44, 15)
        Me.Label21.TabIndex = 25
        Me.Label21.Text = "Fecha :"
        '
        'pnlItem
        '
        Me.pnlItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(3,Byte),Integer), CType(CType(55,Byte),Integer), CType(CType(145,Byte),Integer))
        Me.pnlItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlItem.Controls.Add(Me.txtProdUnidad)
        Me.pnlItem.Controls.Add(Me.Label9)
        Me.pnlItem.Controls.Add(Me.actxnProdPeso)
        Me.pnlItem.Controls.Add(Me.Label11)
        Me.pnlItem.Controls.Add(Me.txtOpcion)
        Me.pnlItem.Controls.Add(Me.Label12)
        Me.pnlItem.Controls.Add(Me.txtProdDescripcion)
        Me.pnlItem.Controls.Add(Me.Label17)
        Me.pnlItem.Controls.Add(Me.Label15)
        Me.pnlItem.Controls.Add(Me.actxaProdCodigo)
        Me.pnlItem.Controls.Add(Me.actxnProdCantidad)
        Me.pnlItem.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlItem.Location = New System.Drawing.Point(0, 0)
        Me.pnlItem.Name = "pnlItem"
        Me.pnlItem.Size = New System.Drawing.Size(1266, 49)
        Me.pnlItem.TabIndex = 0
        '
        'txtProdUnidad
        '
        Me.txtProdUnidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtProdUnidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProdUnidad.Location = New System.Drawing.Point(959, 21)
        Me.txtProdUnidad.Name = "txtProdUnidad"
        Me.txtProdUnidad.ReadOnly = true
        Me.txtProdUnidad.Size = New System.Drawing.Size(80, 23)
        Me.txtProdUnidad.TabIndex = 5
        Me.txtProdUnidad.Tag = "EVO"
        Me.txtProdUnidad.Visible = false
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = true
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 11!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(960, 4)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 13)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Unidad"
        Me.Label9.Visible = false
        '
        'actxnProdPeso
        '
        Me.actxnProdPeso.ACEnteros = 9
        Me.actxnProdPeso.ACEstandar = ACControles.ACEstandaresFormato.ACDecimal
        Me.actxnProdPeso.ACFormato = "###,###,##0.0000"
        Me.actxnProdPeso.ACNegativo = true
        Me.actxnProdPeso.ACValue = New Decimal(New Integer() {0, 0, 0, 131072})
        Me.actxnProdPeso.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.actxnProdPeso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.actxnProdPeso.Location = New System.Drawing.Point(1039, 21)
        Me.actxnProdPeso.MaxLength = 12
        Me.actxnProdPeso.Name = "actxnProdPeso"
        Me.actxnProdPeso.ReadOnly = true
        Me.actxnProdPeso.Size = New System.Drawing.Size(80, 23)
        Me.actxnProdPeso.TabIndex = 7
        Me.actxnProdPeso.Tag = "EVO"
        Me.actxnProdPeso.Text = "0.0000"
        Me.actxnProdPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.actxnProdPeso.Visible = false
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = true
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 11!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(1054, 4)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(34, 13)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Peso"
        Me.Label11.Visible = false
        '
        'txtOpcion
        '
        Me.txtOpcion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtOpcion.BackColor = System.Drawing.Color.Gainsboro
        Me.txtOpcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOpcion.Location = New System.Drawing.Point(1229, 21)
        Me.txtOpcion.MaxLength = 1
        Me.txtOpcion.Name = "txtOpcion"
        Me.txtOpcion.Size = New System.Drawing.Size(25, 23)
        Me.txtOpcion.TabIndex = 10
        Me.txtOpcion.Visible = false
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = true
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 11!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(1124, 5)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(57, 13)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "C&antidad"
        Me.Label12.Visible = false
        '
        'txtProdDescripcion
        '
        Me.txtProdDescripcion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtProdDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProdDescripcion.Location = New System.Drawing.Point(129, 21)
        Me.txtProdDescripcion.Name = "txtProdDescripcion"
        Me.txtProdDescripcion.ReadOnly = true
        Me.txtProdDescripcion.Size = New System.Drawing.Size(828, 23)
        Me.txtProdDescripcion.TabIndex = 3
        Me.txtProdDescripcion.Tag = "V"
        Me.txtProdDescripcion.Visible = false
        '
        'Label17
        '
        Me.Label17.AutoSize = true
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 11!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(137, 5)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(72, 13)
        Me.Label17.TabIndex = 2
        Me.Label17.Text = "Descripcion"
        Me.Label17.Visible = false
        '
        'Label15
        '
        Me.Label15.AutoSize = true
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 11!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(26, 5)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(45, 13)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "C&odigo"
        Me.Label15.Visible = false
        '
        'actxaProdCodigo
        '
        Me.actxaProdCodigo.ACActivarAyudaAuto = false
        Me.actxaProdCodigo.ACLongitudAceptada = 0
        Me.actxaProdCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.actxaProdCodigo.Location = New System.Drawing.Point(19, 21)
        Me.actxaProdCodigo.MaxLength = 32767
        Me.actxaProdCodigo.Name = "actxaProdCodigo"
        Me.actxaProdCodigo.Size = New System.Drawing.Size(110, 23)
        Me.actxaProdCodigo.TabIndex = 1
        Me.actxaProdCodigo.Tag = "EV"
        Me.actxaProdCodigo.Visible = false
        '
        'actxnProdCantidad
        '
        Me.actxnProdCantidad.ACEnteros = 9
        Me.actxnProdCantidad.ACEstandar = ACControles.ACEstandaresFormato.ACMoneda
        Me.actxnProdCantidad.ACNegativo = true
        Me.actxnProdCantidad.ACValue = New Decimal(New Integer() {0, 0, 0, 131072})
        Me.actxnProdCantidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.actxnProdCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.actxnProdCantidad.Location = New System.Drawing.Point(1119, 21)
        Me.actxnProdCantidad.MaxLength = 12
        Me.actxnProdCantidad.Name = "actxnProdCantidad"
        Me.actxnProdCantidad.Size = New System.Drawing.Size(110, 23)
        Me.actxnProdCantidad.TabIndex = 9
        Me.actxnProdCantidad.Tag = "EV"
        Me.actxnProdCantidad.Text = "0.00"
        Me.actxnProdCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.actxnProdCantidad.Visible = false
        '
        'bnavProductos
        '
        Me.bnavProductos.AddNewItem = Me.ToolStripButton1
        Me.bnavProductos.CountItem = Me.ToolStripLabel1
        Me.bnavProductos.DeleteItem = Me.ToolStripButton2
        Me.bnavProductos.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.bnavProductos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripSeparator1, Me.ToolStripTextBox1, Me.ToolStripLabel1, Me.ToolStripSeparator2, Me.ToolStripButton5, Me.ToolStripButton6, Me.ToolStripSeparator3, Me.ToolStripButton1, Me.ToolStripButton2, Me.tscmbImpresora, Me.ToolStripLabel5, Me.ToolStripSeparator13})
        Me.bnavProductos.Location = New System.Drawing.Point(0, 302)
        Me.bnavProductos.MoveFirstItem = Me.ToolStripButton3
        Me.bnavProductos.MoveLastItem = Me.ToolStripButton6
        Me.bnavProductos.MoveNextItem = Me.ToolStripButton5
        Me.bnavProductos.MovePreviousItem = Me.ToolStripButton4
        Me.bnavProductos.Name = "bnavProductos"
        Me.bnavProductos.PositionItem = Me.ToolStripTextBox1
        Me.bnavProductos.Size = New System.Drawing.Size(1266, 25)
        Me.bnavProductos.TabIndex = 2
        Me.bnavProductos.Text = "BindingNavigator1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"),System.Drawing.Image)
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.RightToLeftAutoMirrorImage = true
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "Add new"
        Me.ToolStripButton1.Visible = false
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
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"),System.Drawing.Image)
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.RightToLeftAutoMirrorImage = true
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "Delete"
        Me.ToolStripButton2.Visible = false
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"),System.Drawing.Image)
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.RightToLeftAutoMirrorImage = true
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton3.Text = "Move first"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"),System.Drawing.Image)
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.RightToLeftAutoMirrorImage = true
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
        Me.ToolStripTextBox1.AutoSize = false
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
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"),System.Drawing.Image)
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.RightToLeftAutoMirrorImage = true
        Me.ToolStripButton5.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton5.Text = "Move next"
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"),System.Drawing.Image)
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.RightToLeftAutoMirrorImage = true
        Me.ToolStripButton6.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton6.Text = "Move last"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'tscmbImpresora
        '
        Me.tscmbImpresora.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tscmbImpresora.Name = "tscmbImpresora"
        Me.tscmbImpresora.Size = New System.Drawing.Size(300, 25)
        '
        'ToolStripLabel5
        '
        Me.ToolStripLabel5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel5.Name = "ToolStripLabel5"
        Me.ToolStripLabel5.Size = New System.Drawing.Size(66, 22)
        Me.ToolStripLabel5.Text = "Impresora :"
        '
        'ToolStripSeparator13
        '
        Me.ToolStripSeparator13.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator13.Name = "ToolStripSeparator13"
        Me.ToolStripSeparator13.Size = New System.Drawing.Size(6, 25)
        '
        'pnlPie
        '
        Me.pnlPie.BackColor = System.Drawing.Color.FromArgb(CType(CType(3,Byte),Integer), CType(CType(55,Byte),Integer), CType(CType(145,Byte),Integer))
        Me.pnlPie.Controls.Add(Me.btnRevision2)
        Me.pnlPie.Controls.Add(Me.btnRevision)
        Me.pnlPie.Controls.Add(Me.actxnPesoTotal)
        Me.pnlPie.Controls.Add(Me.Label3)
        Me.pnlPie.Controls.Add(Me.grpDocumento)
        Me.pnlPie.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlPie.Location = New System.Drawing.Point(0, 327)
        Me.pnlPie.Name = "pnlPie"
        Me.pnlPie.Size = New System.Drawing.Size(1266, 50)
        Me.pnlPie.TabIndex = 3
        '
        'btnRevision
        '
        Me.btnRevision.BackColor = System.Drawing.Color.FromArgb(CType(CType(3,Byte),Integer), CType(CType(55,Byte),Integer), CType(CType(145,Byte),Integer))
        Me.btnRevision.Font = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
        Me.btnRevision.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnRevision.Image = Global.ACPLogistica.My.Resources.Resources.Aceptar_32x32
        Me.btnRevision.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRevision.Location = New System.Drawing.Point(584, 7)
        Me.btnRevision.Name = "btnRevision"
        Me.btnRevision.Size = New System.Drawing.Size(140, 43)
        Me.btnRevision.TabIndex = 4
        Me.btnRevision.Text = "Revision 1"
        Me.btnRevision.UseVisualStyleBackColor = false
        '
        'actxnPesoTotal
        '
        Me.actxnPesoTotal.ACEnteros = 9
        Me.actxnPesoTotal.ACEstandar = ACControles.ACEstandaresFormato.ACDecimal
        Me.actxnPesoTotal.ACFormato = "###,###,##0.0000"
        Me.actxnPesoTotal.ACNegativo = true
        Me.actxnPesoTotal.ACValue = New Decimal(New Integer() {0, 0, 0, 131072})
        Me.actxnPesoTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.actxnPesoTotal.Font = New System.Drawing.Font("Segoe UI", 14!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
        Me.actxnPesoTotal.Location = New System.Drawing.Point(1138, 15)
        Me.actxnPesoTotal.MaxLength = 12
        Me.actxnPesoTotal.Name = "actxnPesoTotal"
        Me.actxnPesoTotal.ReadOnly = true
        Me.actxnPesoTotal.Size = New System.Drawing.Size(117, 26)
        Me.actxnPesoTotal.TabIndex = 3
        Me.actxnPesoTotal.Tag = "EVO"
        Me.actxnPesoTotal.Text = "0.0000"
        Me.actxnPesoTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = true
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 13!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(1054, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Peso Total :"
        '
        'grpDocumento
        '
        Me.grpDocumento.BackColor = System.Drawing.Color.FromArgb(CType(CType(3,Byte),Integer), CType(CType(55,Byte),Integer), CType(CType(145,Byte),Integer))
        Me.grpDocumento.Controls.Add(Me.cmbGuia)
        Me.grpDocumento.Controls.Add(Me.actxnNumero)
        Me.grpDocumento.Controls.Add(Me.cmbGuiaSerie)
        Me.grpDocumento.Controls.Add(Me.Label19)
        Me.grpDocumento.Controls.Add(Me.Label23)
        Me.grpDocumento.Dock = System.Windows.Forms.DockStyle.Left
        Me.grpDocumento.ForeColor = System.Drawing.Color.White
        Me.grpDocumento.Location = New System.Drawing.Point(0, 0)
        Me.grpDocumento.Name = "grpDocumento"
        Me.grpDocumento.Size = New System.Drawing.Size(578, 50)
        Me.grpDocumento.TabIndex = 0
        Me.grpDocumento.TabStop = false
        Me.grpDocumento.Text = "Documento"
        '
        'cmbGuia
        '
        Me.cmbGuia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGuia.Enabled = false
        Me.cmbGuia.Font = New System.Drawing.Font("Segoe UI", 14!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
        Me.cmbGuia.FormattingEnabled = true
        Me.cmbGuia.Items.AddRange(New Object() {"Boleta", "Factura"})
        Me.cmbGuia.Location = New System.Drawing.Point(7, 16)
        Me.cmbGuia.Name = "cmbGuia"
        Me.cmbGuia.Size = New System.Drawing.Size(235, 27)
        Me.cmbGuia.TabIndex = 0
        Me.cmbGuia.Tag = "C"
        '
        'actxnNumero
        '
        Me.actxnNumero.ACEnteros = 8
        Me.actxnNumero.ACFormato = "#######0"
        Me.actxnNumero.ACNegativo = true
        Me.actxnNumero.ACValue = New Decimal(New Integer() {0, 0, 0, 131072})
        Me.actxnNumero.Enabled = false
        Me.actxnNumero.Font = New System.Drawing.Font("Segoe UI", 14!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
        Me.actxnNumero.Location = New System.Drawing.Point(455, 16)
        Me.actxnNumero.MaxLength = 7
        Me.actxnNumero.Name = "actxnNumero"
        Me.actxnNumero.Size = New System.Drawing.Size(112, 26)
        Me.actxnNumero.TabIndex = 4
        Me.actxnNumero.Tag = "EVO"
        Me.actxnNumero.Text = "0"
        Me.actxnNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmbGuiaSerie
        '
        Me.cmbGuiaSerie.Enabled = false
        Me.cmbGuiaSerie.Font = New System.Drawing.Font("Segoe UI", 14!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
        Me.cmbGuiaSerie.FormattingEnabled = true
        Me.cmbGuiaSerie.Location = New System.Drawing.Point(309, 16)
        Me.cmbGuiaSerie.Name = "cmbGuiaSerie"
        Me.cmbGuiaSerie.Size = New System.Drawing.Size(60, 27)
        Me.cmbGuiaSerie.TabIndex = 2
        Me.cmbGuiaSerie.Tag = "ECO"
        '
        'Label19
        '
        Me.Label19.AutoSize = true
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 13!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.Label19.Location = New System.Drawing.Point(384, 20)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(56, 17)
        Me.Label19.TabIndex = 3
        Me.Label19.Text = "Numero"
        '
        'Label23
        '
        Me.Label23.AutoSize = true
        Me.Label23.Font = New System.Drawing.Font("Segoe UI", 13!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.Label23.Location = New System.Drawing.Point(257, 20)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(37, 17)
        Me.Label23.TabIndex = 1
        Me.Label23.Text = "Serie"
        '
        'pnlCabecera
        '
        Me.pnlCabecera.Controls.Add(Me.cmbDirOrigenSalTrans)
        Me.pnlCabecera.Controls.Add(Me.cmbDirDestino)
        Me.pnlCabecera.Controls.Add(Me.Label8)
        Me.pnlCabecera.Controls.Add(Me.txtPesoVehiculo)
        Me.pnlCabecera.Controls.Add(Me.actxaCodDirDestino)
        Me.pnlCabecera.Controls.Add(Me.txtAlmDestino)
        Me.pnlCabecera.Controls.Add(Me.cmbDirOrigen)
        Me.pnlCabecera.Controls.Add(Me.grpFlete)
        Me.pnlCabecera.Controls.Add(Me.txtLicenciaConducir)
        Me.pnlCabecera.Controls.Add(Me.lblDescVehiculo)
        Me.pnlCabecera.Controls.Add(Me.Label20)
        Me.pnlCabecera.Controls.Add(Me.txtCertificado)
        Me.pnlCabecera.Controls.Add(Me.lblNomConductor)
        Me.pnlCabecera.Controls.Add(Me.Label14)
        Me.pnlCabecera.Controls.Add(Me.actxaDescVehiculo)
        Me.pnlCabecera.Controls.Add(Me.actxaDescConductor)
        Me.pnlCabecera.Controls.Add(Me.actxaCodVehiculo)
        Me.pnlCabecera.Controls.Add(Me.actxaDescTransportista)
        Me.pnlCabecera.Controls.Add(Me.actxaCodConductor)
        Me.pnlCabecera.Controls.Add(Me.Label25)
        Me.pnlCabecera.Controls.Add(Me.actxaCodTransportista)
        Me.pnlCabecera.Controls.Add(Me.txtAlmOrigen)
        Me.pnlCabecera.Controls.Add(Me.Label16)
        Me.pnlCabecera.Controls.Add(Me.Label13)
        Me.pnlCabecera.Controls.Add(Me.actxaDescCliente)
        Me.pnlCabecera.Controls.Add(Me.Label2)
        Me.pnlCabecera.Controls.Add(Me.actxaCodCliente)
        Me.pnlCabecera.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlCabecera.Location = New System.Drawing.Point(0, 0)
        Me.pnlCabecera.Name = "pnlCabecera"
        Me.pnlCabecera.Size = New System.Drawing.Size(1266, 209)
        Me.pnlCabecera.TabIndex = 1
        '
        'cmbDirOrigenSalTrans
        '
        Me.cmbDirOrigenSalTrans.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.cmbDirOrigenSalTrans.Enabled = false
        Me.cmbDirOrigenSalTrans.FormattingEnabled = true
        Me.cmbDirOrigenSalTrans.Location = New System.Drawing.Point(163, 103)
        Me.cmbDirOrigenSalTrans.Name = "cmbDirOrigenSalTrans"
        Me.cmbDirOrigenSalTrans.Size = New System.Drawing.Size(747, 23)
        Me.cmbDirOrigenSalTrans.TabIndex = 28
        '
        'cmbDirDestino
        '
        Me.cmbDirDestino.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.cmbDirDestino.FormattingEnabled = true
        Me.cmbDirDestino.Location = New System.Drawing.Point(163, 102)
        Me.cmbDirDestino.Name = "cmbDirDestino"
        Me.cmbDirDestino.Size = New System.Drawing.Size(778, 23)
        Me.cmbDirDestino.TabIndex = 27
        Me.cmbDirDestino.Visible = false
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = true
        Me.Label8.Location = New System.Drawing.Point(947, 106)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(93, 15)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Punto de Venta :"
        '
        'txtPesoVehiculo
        '
        Me.txtPesoVehiculo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtPesoVehiculo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPesoVehiculo.Location = New System.Drawing.Point(1138, 181)
        Me.txtPesoVehiculo.MaxLength = 50
        Me.txtPesoVehiculo.Name = "txtPesoVehiculo"
        Me.txtPesoVehiculo.ReadOnly = true
        Me.txtPesoVehiculo.Size = New System.Drawing.Size(117, 23)
        Me.txtPesoVehiculo.TabIndex = 25
        Me.txtPesoVehiculo.Tag = "EVO"
        Me.txtPesoVehiculo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'actxaCodDirDestino
        '
        Me.actxaCodDirDestino.ACActivarAyudaAuto = false
        Me.actxaCodDirDestino.ACLongitudAceptada = 0
        Me.actxaCodDirDestino.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.actxaCodDirDestino.Location = New System.Drawing.Point(103, 102)
        Me.actxaCodDirDestino.MaxLength = 10
        Me.actxaCodDirDestino.Name = "actxaCodDirDestino"
        Me.actxaCodDirDestino.ReadOnly = true
        Me.actxaCodDirDestino.Size = New System.Drawing.Size(53, 23)
        Me.actxaCodDirDestino.TabIndex = 6
        Me.actxaCodDirDestino.Tag = "VO"
        '
        'txtAlmDestino
        '
        Me.txtAlmDestino.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtAlmDestino.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAlmDestino.Enabled = false
        Me.txtAlmDestino.Location = New System.Drawing.Point(1052, 103)
        Me.txtAlmDestino.Name = "txtAlmDestino"
        Me.txtAlmDestino.ReadOnly = true
        Me.txtAlmDestino.Size = New System.Drawing.Size(203, 23)
        Me.txtAlmDestino.TabIndex = 9
        '
        'cmbDirOrigen
        '
        Me.cmbDirOrigen.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.cmbDirOrigen.BackColor = System.Drawing.Color.White
        Me.cmbDirOrigen.Enabled = false
        Me.cmbDirOrigen.Font = New System.Drawing.Font("Segoe UI", 14!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.cmbDirOrigen.FormattingEnabled = true
        Me.cmbDirOrigen.Location = New System.Drawing.Point(103, 71)
        Me.cmbDirOrigen.Name = "cmbDirOrigen"
        Me.cmbDirOrigen.Size = New System.Drawing.Size(832, 27)
        Me.cmbDirOrigen.TabIndex = 2
        Me.cmbDirOrigen.Tag = "ECO"
        '
        'grpFlete
        '
        Me.grpFlete.BackColor = System.Drawing.Color.FromArgb(CType(CType(3,Byte),Integer), CType(CType(55,Byte),Integer), CType(CType(145,Byte),Integer))
        Me.grpFlete.Controls.Add(Me.txtNroDocVenta)
        Me.grpFlete.Controls.Add(Me.Label5)
        Me.grpFlete.Controls.Add(Me.dtpFechaEmision)
        Me.grpFlete.Controls.Add(Me.Label10)
        Me.grpFlete.Controls.Add(Me.Label1)
        Me.grpFlete.Controls.Add(Me.cmbMotTraslado)
        Me.grpFlete.Controls.Add(Me.dtpFechaTraslado)
        Me.grpFlete.Controls.Add(Me.Label4)
        Me.grpFlete.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpFlete.Location = New System.Drawing.Point(0, 0)
        Me.grpFlete.Name = "grpFlete"
        Me.grpFlete.Size = New System.Drawing.Size(1266, 70)
        Me.grpFlete.TabIndex = 0
        Me.grpFlete.TabStop = false
        '
        'txtNroDocVenta
        '
        Me.txtNroDocVenta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtNroDocVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNroDocVenta.Enabled = false
        Me.txtNroDocVenta.Font = New System.Drawing.Font("Segoe UI", 14!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
        Me.txtNroDocVenta.Location = New System.Drawing.Point(970, 12)
        Me.txtNroDocVenta.MaxLength = 50
        Me.txtNroDocVenta.Name = "txtNroDocVenta"
        Me.txtNroDocVenta.Size = New System.Drawing.Size(285, 26)
        Me.txtNroDocVenta.TabIndex = 7
        Me.txtNroDocVenta.Tag = "EVO"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = true
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(881, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 15)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Doc. Origen :"
        '
        'dtpFechaEmision
        '
        Me.dtpFechaEmision.Enabled = false
        Me.dtpFechaEmision.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaEmision.Location = New System.Drawing.Point(103, 13)
        Me.dtpFechaEmision.Name = "dtpFechaEmision"
        Me.dtpFechaEmision.Size = New System.Drawing.Size(109, 23)
        Me.dtpFechaEmision.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = true
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 13!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(847, 43)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(110, 17)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Motivo Traslado :"
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(8, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fecha Emisión :"
        '
        'cmbMotTraslado
        '
        Me.cmbMotTraslado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.cmbMotTraslado.BackColor = System.Drawing.Color.Silver
        Me.cmbMotTraslado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMotTraslado.Enabled = false
        Me.cmbMotTraslado.Font = New System.Drawing.Font("Tahoma", 14!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
        Me.cmbMotTraslado.FormattingEnabled = true
        Me.cmbMotTraslado.Location = New System.Drawing.Point(970, 39)
        Me.cmbMotTraslado.MaxLength = 100
        Me.cmbMotTraslado.Name = "cmbMotTraslado"
        Me.cmbMotTraslado.Size = New System.Drawing.Size(285, 25)
        Me.cmbMotTraslado.TabIndex = 5
        Me.cmbMotTraslado.Tag = "ECO"
        '
        'dtpFechaTraslado
        '
        Me.dtpFechaTraslado.Enabled = false
        Me.dtpFechaTraslado.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaTraslado.Location = New System.Drawing.Point(103, 40)
        Me.dtpFechaTraslado.Name = "dtpFechaTraslado"
        Me.dtpFechaTraslado.Size = New System.Drawing.Size(109, 23)
        Me.dtpFechaTraslado.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(5, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 15)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Fecha Traslado :"
        '
        'txtLicenciaConducir
        '
        Me.txtLicenciaConducir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtLicenciaConducir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLicenciaConducir.Location = New System.Drawing.Point(696, 181)
        Me.txtLicenciaConducir.Name = "txtLicenciaConducir"
        Me.txtLicenciaConducir.Size = New System.Drawing.Size(113, 23)
        Me.txtLicenciaConducir.TabIndex = 19
        '
        'lblDescVehiculo
        '
        Me.lblDescVehiculo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.lblDescVehiculo.AutoSize = true
        Me.lblDescVehiculo.Location = New System.Drawing.Point(819, 159)
        Me.lblDescVehiculo.Name = "lblDescVehiculo"
        Me.lblDescVehiculo.Size = New System.Drawing.Size(58, 15)
        Me.lblDescVehiculo.TabIndex = 20
        Me.lblDescVehiculo.Text = "Vehiculo :"
        '
        'Label20
        '
        Me.Label20.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Label20.AutoSize = true
        Me.Label20.Location = New System.Drawing.Point(891, 185)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(71, 15)
        Me.Label20.TabIndex = 23
        Me.Label20.Text = "Certificado :"
        '
        'txtCertificado
        '
        Me.txtCertificado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtCertificado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCertificado.Enabled = false
        Me.txtCertificado.Location = New System.Drawing.Point(970, 181)
        Me.txtCertificado.MaxLength = 50
        Me.txtCertificado.Name = "txtCertificado"
        Me.txtCertificado.Size = New System.Drawing.Size(161, 23)
        Me.txtCertificado.TabIndex = 24
        Me.txtCertificado.Tag = "EVO"
        '
        'lblNomConductor
        '
        Me.lblNomConductor.AutoSize = true
        Me.lblNomConductor.Location = New System.Drawing.Point(27, 185)
        Me.lblNomConductor.Name = "lblNomConductor"
        Me.lblNomConductor.Size = New System.Drawing.Size(70, 15)
        Me.lblNomConductor.TabIndex = 16
        Me.lblNomConductor.Text = "Conductor :"
        '
        'Label14
        '
        Me.Label14.AutoSize = true
        Me.Label14.Location = New System.Drawing.Point(15, 159)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(80, 15)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "Transportista :"
        '
        'actxaDescVehiculo
        '
        Me.actxaDescVehiculo.ACActivarAyudaAuto = false
        Me.actxaDescVehiculo.ACLongitudAceptada = 0
        Me.actxaDescVehiculo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.actxaDescVehiculo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.actxaDescVehiculo.Enabled = false
        Me.actxaDescVehiculo.Location = New System.Drawing.Point(970, 155)
        Me.actxaDescVehiculo.MaxLength = 100
        Me.actxaDescVehiculo.Name = "actxaDescVehiculo"
        Me.actxaDescVehiculo.Size = New System.Drawing.Size(285, 23)
        Me.actxaDescVehiculo.TabIndex = 22
        Me.actxaDescVehiculo.Tag = "EVO"
        '
        'actxaDescConductor
        '
        Me.actxaDescConductor.ACActivarAyudaAuto = false
        Me.actxaDescConductor.ACLongitudAceptada = 0
        Me.actxaDescConductor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.actxaDescConductor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.actxaDescConductor.Enabled = false
        Me.actxaDescConductor.Location = New System.Drawing.Point(218, 181)
        Me.actxaDescConductor.MaxLength = 100
        Me.actxaDescConductor.Name = "actxaDescConductor"
        Me.actxaDescConductor.Size = New System.Drawing.Size(472, 23)
        Me.actxaDescConductor.TabIndex = 18
        Me.actxaDescConductor.Tag = "EVO"
        '
        'actxaCodVehiculo
        '
        Me.actxaCodVehiculo.ACActivarAyudaAuto = false
        Me.actxaCodVehiculo.ACLongitudAceptada = 0
        Me.actxaCodVehiculo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.actxaCodVehiculo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.actxaCodVehiculo.Enabled = false
        Me.actxaCodVehiculo.Location = New System.Drawing.Point(884, 155)
        Me.actxaCodVehiculo.MaxLength = 10
        Me.actxaCodVehiculo.Name = "actxaCodVehiculo"
        Me.actxaCodVehiculo.Size = New System.Drawing.Size(78, 23)
        Me.actxaCodVehiculo.TabIndex = 21
        Me.actxaCodVehiculo.Tag = "EVO"
        '
        'actxaDescTransportista
        '
        Me.actxaDescTransportista.ACActivarAyudaAuto = false
        Me.actxaDescTransportista.ACLongitudAceptada = 0
        Me.actxaDescTransportista.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.actxaDescTransportista.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.actxaDescTransportista.Enabled = false
        Me.actxaDescTransportista.Location = New System.Drawing.Point(218, 155)
        Me.actxaDescTransportista.MaxLength = 100
        Me.actxaDescTransportista.Name = "actxaDescTransportista"
        Me.actxaDescTransportista.Size = New System.Drawing.Size(591, 23)
        Me.actxaDescTransportista.TabIndex = 15
        Me.actxaDescTransportista.Tag = "EVO"
        '
        'actxaCodConductor
        '
        Me.actxaCodConductor.ACActivarAyudaAuto = false
        Me.actxaCodConductor.ACLongitudAceptada = 0
        Me.actxaCodConductor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.actxaCodConductor.Enabled = false
        Me.actxaCodConductor.Location = New System.Drawing.Point(103, 181)
        Me.actxaCodConductor.MaxLength = 14
        Me.actxaCodConductor.Name = "actxaCodConductor"
        Me.actxaCodConductor.Size = New System.Drawing.Size(109, 23)
        Me.actxaCodConductor.TabIndex = 17
        Me.actxaCodConductor.Tag = "EVO"
        '
        'Label25
        '
        Me.Label25.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Label25.AutoSize = true
        Me.Label25.Location = New System.Drawing.Point(947, 77)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(93, 15)
        Me.Label25.TabIndex = 3
        Me.Label25.Text = "Punto de Venta :"
        '
        'actxaCodTransportista
        '
        Me.actxaCodTransportista.ACActivarAyudaAuto = false
        Me.actxaCodTransportista.ACLongitudAceptada = 0
        Me.actxaCodTransportista.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.actxaCodTransportista.Enabled = false
        Me.actxaCodTransportista.Location = New System.Drawing.Point(103, 155)
        Me.actxaCodTransportista.MaxLength = 14
        Me.actxaCodTransportista.Name = "actxaCodTransportista"
        Me.actxaCodTransportista.Size = New System.Drawing.Size(109, 23)
        Me.actxaCodTransportista.TabIndex = 14
        Me.actxaCodTransportista.Tag = "EVO"
        '
        'txtAlmOrigen
        '
        Me.txtAlmOrigen.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtAlmOrigen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAlmOrigen.Enabled = false
        Me.txtAlmOrigen.Location = New System.Drawing.Point(1052, 73)
        Me.txtAlmOrigen.Name = "txtAlmOrigen"
        Me.txtAlmOrigen.ReadOnly = true
        Me.txtAlmOrigen.Size = New System.Drawing.Size(203, 23)
        Me.txtAlmOrigen.TabIndex = 4
        '
        'Label16
        '
        Me.Label16.AutoSize = true
        Me.Label16.Location = New System.Drawing.Point(13, 106)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(84, 15)
        Me.Label16.TabIndex = 5
        Me.Label16.Text = "D. de Llegada :"
        '
        'Label13
        '
        Me.Label13.AutoSize = true
        Me.Label13.Location = New System.Drawing.Point(17, 77)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(80, 15)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "D. de Partida :"
        '
        'actxaDescCliente
        '
        Me.actxaDescCliente.ACActivarAyudaAuto = false
        Me.actxaDescCliente.ACLongitudAceptada = 0
        Me.actxaDescCliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.actxaDescCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.actxaDescCliente.Enabled = false
        Me.actxaDescCliente.Location = New System.Drawing.Point(218, 129)
        Me.actxaDescCliente.MaxLength = 80
        Me.actxaDescCliente.Name = "actxaDescCliente"
        Me.actxaDescCliente.Size = New System.Drawing.Size(1037, 23)
        Me.actxaDescCliente.TabIndex = 12
        Me.actxaDescCliente.Tag = "VO"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Location = New System.Drawing.Point(47, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 15)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Cliente :"
        '
        'actxaCodCliente
        '
        Me.actxaCodCliente.ACActivarAyudaAuto = false
        Me.actxaCodCliente.ACLongitudAceptada = 0
        Me.actxaCodCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.actxaCodCliente.Enabled = false
        Me.actxaCodCliente.Location = New System.Drawing.Point(103, 129)
        Me.actxaCodCliente.MaxLength = 14
        Me.actxaCodCliente.Name = "actxaCodCliente"
        Me.actxaCodCliente.Size = New System.Drawing.Size(109, 23)
        Me.actxaCodCliente.TabIndex = 11
        Me.actxaCodCliente.Tag = "VO"
        '
        'tabBusGuias
        '
        Me.tabBusGuias.Controls.Add(Me.c1grdReporte)
        Me.tabBusGuias.Controls.Add(Me.Panel1)
        Me.tabBusGuias.Controls.Add(Me.bnavCBusqueda)
        Me.tabBusGuias.InactiveBackColor = System.Drawing.Color.Empty
        Me.tabBusGuias.InactiveTextBackColor = System.Drawing.Color.Empty
        Me.tabBusGuias.InactiveTextColor = System.Drawing.Color.Empty
        Me.tabBusGuias.Location = New System.Drawing.Point(1, 1)
        Me.tabBusGuias.Name = "tabBusGuias"
        Me.tabBusGuias.SelectBackColor = System.Drawing.Color.Empty
        Me.tabBusGuias.Selected = false
        Me.tabBusGuias.SelectTextBackColor = System.Drawing.Color.Empty
        Me.tabBusGuias.SelectTextColor = System.Drawing.Color.Empty
        Me.tabBusGuias.Size = New System.Drawing.Size(1266, 586)
        Me.tabBusGuias.TabIndex = 6
        Me.tabBusGuias.Title = "Buscar Guias"
        Me.tabBusGuias.ToolTip = "Buscar Guias"
        '
        'c1grdReporte
        '
        Me.c1grdReporte.ColumnInfo = "2,1,0,0,0,100,Columns:0{Width:25;}"&Global.Microsoft.VisualBasic.ChrW(9)
        Me.c1grdReporte.Dock = System.Windows.Forms.DockStyle.Fill
        Me.c1grdReporte.Location = New System.Drawing.Point(0, 107)
        Me.c1grdReporte.Name = "c1grdReporte"
        Me.c1grdReporte.Rows.Count = 2
        Me.c1grdReporte.Rows.DefaultSize = 20
        Me.c1grdReporte.Size = New System.Drawing.Size(1266, 454)
        Me.c1grdReporte.StyleInfo = resources.GetString("c1grdReporte.StyleInfo")
        Me.c1grdReporte.TabIndex = 74
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel1.Controls.Add(Me.GroupBox4)
        Me.Panel1.Controls.Add(Me.chkctodos)
        Me.Panel1.Controls.Add(Me.btnExcel)
        Me.Panel1.Controls.Add(Me.rbtncliente)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.btnProcesar)
        Me.Panel1.Controls.Add(Me.AcFecha)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1266, 107)
        Me.Panel1.TabIndex = 73
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.c1grdPuntosVentas)
        Me.GroupBox4.Location = New System.Drawing.Point(680, 3)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(227, 100)
        Me.GroupBox4.TabIndex = 32
        Me.GroupBox4.TabStop = false
        Me.GroupBox4.Text = "Puntos de Ventas"
        '
        'c1grdPuntosVentas
        '
        Me.c1grdPuntosVentas.ColumnInfo = "2,1,0,0,0,100,Columns:0{Width:25;}"&Global.Microsoft.VisualBasic.ChrW(9)
        Me.c1grdPuntosVentas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.c1grdPuntosVentas.Location = New System.Drawing.Point(3, 19)
        Me.c1grdPuntosVentas.Name = "c1grdPuntosVentas"
        Me.c1grdPuntosVentas.Rows.Count = 2
        Me.c1grdPuntosVentas.Rows.DefaultSize = 20
        Me.c1grdPuntosVentas.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.c1grdPuntosVentas.Size = New System.Drawing.Size(221, 78)
        Me.c1grdPuntosVentas.StyleInfo = resources.GetString("c1grdPuntosVentas.StyleInfo")
        Me.c1grdPuntosVentas.TabIndex = 8
        '
        'chkctodos
        '
        Me.chkctodos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.chkctodos.AutoSize = true
        Me.chkctodos.Location = New System.Drawing.Point(914, 60)
        Me.chkctodos.Name = "chkctodos"
        Me.chkctodos.Size = New System.Drawing.Size(101, 19)
        Me.chkctodos.TabIndex = 27
        Me.chkctodos.Text = "Mostrar Todos"
        Me.chkctodos.UseVisualStyleBackColor = true
        '
        'btnExcel
        '
        Me.btnExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnExcel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnExcel.Image = Global.ACPLogistica.My.Resources.Resources.Excel2_32x32
        Me.btnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExcel.Location = New System.Drawing.Point(1216, 60)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(42, 41)
        Me.btnExcel.TabIndex = 17
        Me.btnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExcel.UseVisualStyleBackColor = true
        Me.btnExcel.Visible = false
        '
        'rbtncliente
        '
        Me.rbtncliente.AutoSize = true
        Me.rbtncliente.Location = New System.Drawing.Point(12, 1)
        Me.rbtncliente.Name = "rbtncliente"
        Me.rbtncliente.Size = New System.Drawing.Size(83, 19)
        Me.rbtncliente.TabIndex = 15
        Me.rbtncliente.Text = "Por Cliente"
        Me.rbtncliente.UseVisualStyleBackColor = true
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.actxaCliRazonSocial)
        Me.GroupBox1.Controls.Add(Me.actxaCliRuc)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(670, 48)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = false
        '
        'actxaCliRazonSocial
        '
        Me.actxaCliRazonSocial.ACActivarAyudaAuto = false
        Me.actxaCliRazonSocial.ACLongitudAceptada = 0
        Me.actxaCliRazonSocial.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.actxaCliRazonSocial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.actxaCliRazonSocial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.actxaCliRazonSocial.Font = New System.Drawing.Font("Tahoma", 14!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
        Me.actxaCliRazonSocial.Location = New System.Drawing.Point(134, 14)
        Me.actxaCliRazonSocial.MaxLength = 32767
        Me.actxaCliRazonSocial.Name = "actxaCliRazonSocial"
        Me.actxaCliRazonSocial.Size = New System.Drawing.Size(530, 24)
        Me.actxaCliRazonSocial.TabIndex = 14
        Me.actxaCliRazonSocial.Tag = "EV"
        '
        'actxaCliRuc
        '
        Me.actxaCliRuc.ACActivarAyudaAuto = false
        Me.actxaCliRuc.ACLongitudAceptada = 0
        Me.actxaCliRuc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.actxaCliRuc.Font = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
        Me.actxaCliRuc.Location = New System.Drawing.Point(6, 15)
        Me.actxaCliRuc.MaxLength = 32767
        Me.actxaCliRuc.Name = "actxaCliRuc"
        Me.actxaCliRuc.Size = New System.Drawing.Size(122, 23)
        Me.actxaCliRuc.TabIndex = 13
        Me.actxaCliRuc.Tag = "EVO"
        '
        'btnProcesar
        '
        Me.btnProcesar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnProcesar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnProcesar.Image = Global.ACPLogistica.My.Resources.Resources.Check_Proces_32x32
        Me.btnProcesar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProcesar.Location = New System.Drawing.Point(1090, 60)
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(120, 41)
        Me.btnProcesar.TabIndex = 10
        Me.btnProcesar.Text = "Procesar"
        Me.btnProcesar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnProcesar.UseVisualStyleBackColor = true
        '
        'AcFecha
        '
        Me.AcFecha.ACFecha_A = New Date(2023, 7, 8, 9, 36, 51, 142)
        Me.AcFecha.ACFecha_De = New Date(2023, 7, 8, 9, 36, 51, 140)
        Me.AcFecha.ACFechaObligatoria = true
        Me.AcFecha.ACFormatoControl = ACControles.ACFecha.ACTipoFormatoControl.Horizontal
        Me.AcFecha.ACHoyChecked = false
        Me.AcFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.AcFecha.Location = New System.Drawing.Point(921, 4)
        Me.AcFecha.MaximumSize = New System.Drawing.Size(340, 50)
        Me.AcFecha.MinimumSize = New System.Drawing.Size(337, 43)
        Me.AcFecha.Name = "AcFecha"
        Me.AcFecha.Size = New System.Drawing.Size(337, 50)
        Me.AcFecha.TabIndex = 9
        Me.AcFecha.TabStop = false
        '
        'bnavCBusqueda
        '
        Me.bnavCBusqueda.AddNewItem = Me.ToolStripButton7
        Me.bnavCBusqueda.CountItem = Me.ToolStripLabel2
        Me.bnavCBusqueda.DeleteItem = Me.ToolStripButton8
        Me.bnavCBusqueda.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.bnavCBusqueda.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton9, Me.ToolStripButton10, Me.ToolStripSeparator4, Me.ToolStripTextBox2, Me.ToolStripLabel2, Me.ToolStripSeparator5, Me.ToolStripButton11, Me.ToolStripButton12, Me.ToolStripSeparator6, Me.ToolStripButton7, Me.ToolStripButton8, Me.tsbtnExcel})
        Me.bnavCBusqueda.Location = New System.Drawing.Point(0, 561)
        Me.bnavCBusqueda.MoveFirstItem = Me.ToolStripButton9
        Me.bnavCBusqueda.MoveLastItem = Me.ToolStripButton12
        Me.bnavCBusqueda.MoveNextItem = Me.ToolStripButton11
        Me.bnavCBusqueda.MovePreviousItem = Me.ToolStripButton10
        Me.bnavCBusqueda.Name = "bnavCBusqueda"
        Me.bnavCBusqueda.PositionItem = Me.ToolStripTextBox2
        Me.bnavCBusqueda.Size = New System.Drawing.Size(1266, 25)
        Me.bnavCBusqueda.TabIndex = 8
        Me.bnavCBusqueda.Text = "BindingNavigator1"
        '
        'ToolStripButton7
        '
        Me.ToolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton7.Image = CType(resources.GetObject("ToolStripButton7.Image"),System.Drawing.Image)
        Me.ToolStripButton7.Name = "ToolStripButton7"
        Me.ToolStripButton7.RightToLeftAutoMirrorImage = true
        Me.ToolStripButton7.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton7.Text = "Add new"
        Me.ToolStripButton7.Visible = false
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
        Me.ToolStripButton8.Image = CType(resources.GetObject("ToolStripButton8.Image"),System.Drawing.Image)
        Me.ToolStripButton8.Name = "ToolStripButton8"
        Me.ToolStripButton8.RightToLeftAutoMirrorImage = true
        Me.ToolStripButton8.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton8.Text = "Delete"
        Me.ToolStripButton8.Visible = false
        '
        'ToolStripButton9
        '
        Me.ToolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton9.Image = CType(resources.GetObject("ToolStripButton9.Image"),System.Drawing.Image)
        Me.ToolStripButton9.Name = "ToolStripButton9"
        Me.ToolStripButton9.RightToLeftAutoMirrorImage = true
        Me.ToolStripButton9.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton9.Text = "Move first"
        '
        'ToolStripButton10
        '
        Me.ToolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton10.Image = CType(resources.GetObject("ToolStripButton10.Image"),System.Drawing.Image)
        Me.ToolStripButton10.Name = "ToolStripButton10"
        Me.ToolStripButton10.RightToLeftAutoMirrorImage = true
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
        Me.ToolStripTextBox2.AutoSize = false
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
        Me.ToolStripButton11.Image = CType(resources.GetObject("ToolStripButton11.Image"),System.Drawing.Image)
        Me.ToolStripButton11.Name = "ToolStripButton11"
        Me.ToolStripButton11.RightToLeftAutoMirrorImage = true
        Me.ToolStripButton11.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton11.Text = "Move next"
        '
        'ToolStripButton12
        '
        Me.ToolStripButton12.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton12.Image = CType(resources.GetObject("ToolStripButton12.Image"),System.Drawing.Image)
        Me.ToolStripButton12.Name = "ToolStripButton12"
        Me.ToolStripButton12.RightToLeftAutoMirrorImage = true
        Me.ToolStripButton12.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton12.Text = "Move last"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'tsbtnExcel
        '
        Me.tsbtnExcel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbtnExcel.Image = Global.ACPLogistica.My.Resources.Resources.Excel2_32x32
        Me.tsbtnExcel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnExcel.Name = "tsbtnExcel"
        Me.tsbtnExcel.Size = New System.Drawing.Size(98, 22)
        Me.tsbtnExcel.Text = "Enviar a Excel"
        '
        'acpnlTitulo
        '
        Me.acpnlTitulo.ACCaption = "Reporte de Guias"
        Me.acpnlTitulo.ActiveGradientHighColor = System.Drawing.Color.FromArgb(CType(CType(192,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer))
        Me.acpnlTitulo.ActiveGradientLowColor = System.Drawing.Color.Maroon
        Me.acpnlTitulo.ActiveTextColor = System.Drawing.Color.White
        Me.acpnlTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.acpnlTitulo.Font = New System.Drawing.Font("Tahoma", 14!, System.Drawing.FontStyle.Bold)
        Me.acpnlTitulo.InactiveGradientHighColor = System.Drawing.Color.CornflowerBlue
        Me.acpnlTitulo.InactiveGradientLowColor = System.Drawing.Color.DarkBlue
        Me.acpnlTitulo.Location = New System.Drawing.Point(0, 0)
        Me.acpnlTitulo.Name = "acpnlTitulo"
        Me.acpnlTitulo.Size = New System.Drawing.Size(1268, 33)
        Me.acpnlTitulo.TabIndex = 16
        '
        'acTool
        '
        Me.acTool.ACBtnAnularEnabled = false
        Me.acTool.ACBtnAnularVisible = false
        Me.acTool.ACBtnBuscarEnabled = false
        Me.acTool.ACBtnBuscarVisible = false
        Me.acTool.ACBtnCancelarEnabled = false
        Me.acTool.ACBtnCancelarVisible = false
        Me.acTool.ACBtnEliminarEnabled = false
        Me.acTool.ACBtnEliminarVisible = false
        Me.acTool.ACBtnGrabarEnabled = false
        Me.acTool.ACBtnGrabarVisible = false
        Me.acTool.ACBtnImprimirEnabled = false
        Me.acTool.ACBtnImprimirVisible = false
        Me.acTool.ACBtnRehusarEnabled = false
        Me.acTool.ACBtnRehusarVisible = false
        Me.acTool.ACBtnReporteEnabled = false
        Me.acTool.ACBtnReporteVisible = false
        Me.acTool.ACBtnSalirEnabled = false
        Me.acTool.ACBtnSalirText = "&Salir"
        Me.acTool.ACBtnSalirVisible = false
        Me.acTool.ACBtnVolverEnabled = false
        Me.acTool.ACBtnVolverVisible = false
        Me.acTool.ACTipoToolBar = ACControles.ACToolBarMantHorizontalNew.tipoToolBar.ToolNuevoGrabar
        Me.acTool.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.acTool.Font = New System.Drawing.Font("Tahoma", 9.5!)
        Me.acTool.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.acTool.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.actsbtnPrevisualizar})
        Me.acTool.Location = New System.Drawing.Point(0, 644)
        Me.acTool.Name = "acTool"
        Me.acTool.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.acTool.Size = New System.Drawing.Size(1268, 56)
        Me.acTool.TabIndex = 18
        Me.acTool.Text = "AcToolBarMantHorizontalNew1"
        '
        'actsbtnPrevisualizar
        '
        Me.actsbtnPrevisualizar.AutoSize = false
        Me.actsbtnPrevisualizar.Image = Global.ACPLogistica.My.Resources.Resources.Buscar2_32x32
        Me.actsbtnPrevisualizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.actsbtnPrevisualizar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.actsbtnPrevisualizar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.actsbtnPrevisualizar.Name = "tsbBoton"
        Me.actsbtnPrevisualizar.Size = New System.Drawing.Size(84, 53)
        Me.actsbtnPrevisualizar.Text = "Re&visar"
        Me.actsbtnPrevisualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.actsbtnPrevisualizar.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        Me.actsbtnPrevisualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.actsbtnPrevisualizar.Visible = false
        '
        'btnRevision2
        '
        Me.btnRevision2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnRevision2.BackColor = System.Drawing.Color.FromArgb(CType(CType(3,Byte),Integer), CType(CType(55,Byte),Integer), CType(CType(145,Byte),Integer))
        Me.btnRevision2.Font = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
        Me.btnRevision2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnRevision2.Image = Global.ACPLogistica.My.Resources.Resources.Aceptar_32x32
        Me.btnRevision2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRevision2.Location = New System.Drawing.Point(740, 7)
        Me.btnRevision2.Name = "btnRevision2"
        Me.btnRevision2.Size = New System.Drawing.Size(122, 43)
        Me.btnRevision2.TabIndex = 8
        Me.btnRevision2.Text = "Revision 2"
        Me.btnRevision2.UseVisualStyleBackColor = false
        '
        'RGuias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1268, 700)
        Me.Controls.Add(Me.tabMantenimiento)
        Me.Controls.Add(Me.acpnlTitulo)
        Me.Controls.Add(Me.acTool)
        Me.Name = "RGuias"
        Me.Text = "RGuias"
        Me.tabMantenimiento.ResumeLayout(false)
        Me.tabDatos.ResumeLayout(false)
        Me.pnlDatos.ResumeLayout(false)
        Me.pnlDetalle.ResumeLayout(false)
        Me.pnlDetalle.PerformLayout
        CType(Me.c1grdDetalle,System.ComponentModel.ISupportInitialize).EndInit
        Me.tbcDetalles.ResumeLayout(false)
        Me.tpgDetAnulacion.ResumeLayout(false)
        Me.tpgDetAnulacion.PerformLayout
        Me.pnlItem.ResumeLayout(false)
        Me.pnlItem.PerformLayout
        CType(Me.bnavProductos,System.ComponentModel.ISupportInitialize).EndInit
        Me.bnavProductos.ResumeLayout(false)
        Me.bnavProductos.PerformLayout
        Me.pnlPie.ResumeLayout(false)
        Me.pnlPie.PerformLayout
        Me.grpDocumento.ResumeLayout(false)
        Me.grpDocumento.PerformLayout
        Me.pnlCabecera.ResumeLayout(false)
        Me.pnlCabecera.PerformLayout
        Me.grpFlete.ResumeLayout(false)
        Me.grpFlete.PerformLayout
        Me.tabBusGuias.ResumeLayout(false)
        Me.tabBusGuias.PerformLayout
        CType(Me.c1grdReporte,System.ComponentModel.ISupportInitialize).EndInit
        Me.Panel1.ResumeLayout(false)
        Me.Panel1.PerformLayout
        Me.GroupBox4.ResumeLayout(false)
        CType(Me.c1grdPuntosVentas,System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox1.PerformLayout
        CType(Me.bnavCBusqueda,System.ComponentModel.ISupportInitialize).EndInit
        Me.bnavCBusqueda.ResumeLayout(false)
        Me.bnavCBusqueda.PerformLayout
        Me.acTool.ResumeLayout(false)
        Me.acTool.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Private WithEvents tabMantenimiento As Crownwood.DotNetMagic.Controls.TabControl
    Private WithEvents tabDatos As Crownwood.DotNetMagic.Controls.TabPage
    Friend WithEvents pnlDatos As System.Windows.Forms.Panel
    Friend WithEvents pnlDetalle As System.Windows.Forms.Panel
    Friend WithEvents pnlItem As System.Windows.Forms.Panel
    Friend WithEvents txtProdUnidad As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents actxnProdPeso As ACControles.ACTextBoxNumerico
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtOpcion As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtProdDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents actxaProdCodigo As ACControles.ACTextBoxAyuda
    Friend WithEvents actxnProdCantidad As ACControles.ACTextBoxNumerico
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
    Friend WithEvents tscmbImpresora As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripLabel5 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator13 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents pnlPie As System.Windows.Forms.Panel
    Friend WithEvents actxnPesoTotal As ACControles.ACTextBoxNumerico
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents grpDocumento As System.Windows.Forms.GroupBox
    Friend WithEvents cmbGuia As System.Windows.Forms.ComboBox
    Friend WithEvents actxnNumero As ACControles.ACTextBoxNumerico
    Friend WithEvents cmbGuiaSerie As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents pnlCabecera As System.Windows.Forms.Panel
    Friend WithEvents cmbDirOrigenSalTrans As System.Windows.Forms.ComboBox
    Friend WithEvents cmbDirDestino As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtPesoVehiculo As System.Windows.Forms.TextBox
    Public WithEvents actxaCodDirDestino As ACControles.ACTextBoxAyuda
    Friend WithEvents txtAlmDestino As System.Windows.Forms.TextBox
    Friend WithEvents cmbDirOrigen As System.Windows.Forms.ComboBox
    Friend WithEvents grpFlete As System.Windows.Forms.GroupBox
    Friend WithEvents dtpFechaEmision As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbMotTraslado As System.Windows.Forms.ComboBox
    Friend WithEvents dtpFechaTraslado As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtLicenciaConducir As System.Windows.Forms.TextBox
    Friend WithEvents lblDescVehiculo As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtCertificado As System.Windows.Forms.TextBox
    Friend WithEvents lblNomConductor As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents actxaDescVehiculo As ACControles.ACTextBoxAyuda
    Friend WithEvents actxaDescConductor As ACControles.ACTextBoxAyuda
    Friend WithEvents actxaCodVehiculo As ACControles.ACTextBoxAyuda
    Friend WithEvents actxaDescTransportista As ACControles.ACTextBoxAyuda
    Friend WithEvents actxaCodConductor As ACControles.ACTextBoxAyuda
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents actxaCodTransportista As ACControles.ACTextBoxAyuda
    Friend WithEvents txtAlmOrigen As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents actxaDescCliente As ACControles.ACTextBoxAyuda
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents actxaCodCliente As ACControles.ACTextBoxAyuda
    Friend WithEvents tabBusGuias As Crownwood.DotNetMagic.Controls.TabPage
    Friend WithEvents bnavCBusqueda As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents tsbtnExcel As System.Windows.Forms.ToolStripButton
    Friend WithEvents c1grdReporte As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents chkctodos As System.Windows.Forms.CheckBox
    Friend WithEvents btnExcel As System.Windows.Forms.Button
    Friend WithEvents rbtncliente As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents actxaCliRazonSocial As ACControles.ACTextBoxAyuda
    Friend WithEvents actxaCliRuc As ACControles.ACTextBoxAyuda
    Friend WithEvents btnProcesar As System.Windows.Forms.Button
    Friend WithEvents AcFecha As ACControles.ACFecha
    Friend WithEvents actsbtnPrevisualizar As ACControles.ACToolStripButton
    Friend WithEvents acTool As ACControles.ACToolBarMantHorizontalNew
    Private WithEvents acpnlTitulo As ACControles.ACPanelCaption
    Friend WithEvents btnRevision As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents c1grdDetalle As C1.Win.C1FlexGrid.C1FlexGrid
    Private WithEvents tbcDetalles As Crownwood.DotNetMagic.Controls.TabControl
    Friend WithEvents tpgDetAnulacion As Crownwood.DotNetMagic.Controls.TabPage
    Friend WithEvents txtMotivoAnulacion As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaAnulacion As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtNroDocVenta As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents c1grdPuntosVentas As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents btnRevision2 As System.Windows.Forms.Button
End Class
