<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TRegMerTransitoOrden
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
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TRegMerTransitoOrden))
      Me.acTool = New ACControles.ACToolBarMantHorizontalNew(Me.components)
      Me.actsbtnPrevisualizar = New ACControles.ACToolStripButton(Me.components)
      Me.tabMantenimiento = New Crownwood.DotNetMagic.Controls.TabControl()
      Me.tabDatos = New Crownwood.DotNetMagic.Controls.TabPage()
      Me.pnlDatos = New System.Windows.Forms.Panel()
      Me.pnlDetalle = New System.Windows.Forms.Panel()
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
      Me.pnlItem = New System.Windows.Forms.Panel()
      Me.txtOpcion = New System.Windows.Forms.TextBox()
      Me.actxnCantidad = New ACControles.ACTextBoxNumerico()
      Me.Label8 = New System.Windows.Forms.Label()
      Me.txtProdDescripcion = New System.Windows.Forms.TextBox()
      Me.Label7 = New System.Windows.Forms.Label()
      Me.Label11 = New System.Windows.Forms.Label()
      Me.actxaProdCodigo = New ACControles.ACTextBoxAyuda()
      Me.pnlPie = New System.Windows.Forms.Panel()
      Me.pnlCabecera = New System.Windows.Forms.Panel()
      Me.Label3 = New System.Windows.Forms.Label()
      Me.txtOrdCompra = New System.Windows.Forms.TextBox()
      Me.Label2 = New System.Windows.Forms.Label()
      Me.txtCodOrdCompra = New System.Windows.Forms.TextBox()
      Me.grpDocReferencia = New System.Windows.Forms.GroupBox()
      Me.txtSerie = New System.Windows.Forms.TextBox()
      Me.actxnNumero = New ACControles.ACTextBoxNumerico()
      Me.Label15 = New System.Windows.Forms.Label()
      Me.Label18 = New System.Windows.Forms.Label()
      Me.Label23 = New System.Windows.Forms.Label()
      Me.cmbTipoDoc = New System.Windows.Forms.ComboBox()
      Me.Label6 = New System.Windows.Forms.Label()
      Me.txtNroOrden = New System.Windows.Forms.TextBox()
      Me.txtRazSocial = New System.Windows.Forms.TextBox()
      Me.txtCodProveedor = New System.Windows.Forms.TextBox()
      Me.Label5 = New System.Windows.Forms.Label()
      Me.Label17 = New System.Windows.Forms.Label()
      Me.Label20 = New System.Windows.Forms.Label()
      Me.Label1 = New System.Windows.Forms.Label()
      Me.dtpFecEmision = New System.Windows.Forms.DateTimePicker()
      Me.txtCodigo = New System.Windows.Forms.TextBox()
      Me.tabBusqueda = New Crownwood.DotNetMagic.Controls.TabPage()
      Me.c1grdBusqueda = New C1.Win.C1FlexGrid.C1FlexGrid()
      Me.grpBusqueda = New System.Windows.Forms.GroupBox()
      Me.btnConsultar = New System.Windows.Forms.Button()
      Me.grpCliente = New System.Windows.Forms.GroupBox()
      Me.txtBusqueda = New ACControles.ACTextBoxAyuda()
      Me.rbtnProveedor = New System.Windows.Forms.RadioButton()
      Me.rbtnNroOrdenCompra = New System.Windows.Forms.RadioButton()
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
      Me.tabMercTransito = New Crownwood.DotNetMagic.Controls.TabPage()
      Me.c1grdMTBusqueda = New C1.Win.C1FlexGrid.C1FlexGrid()
      Me.GroupBox1 = New System.Windows.Forms.GroupBox()
      Me.btnMTConsultar = New System.Windows.Forms.Button()
      Me.chkAgrupar = New System.Windows.Forms.CheckBox()
      Me.GroupBox2 = New System.Windows.Forms.GroupBox()
      Me.txtMTBusqueda = New ACControles.ACTextBoxAyuda()
      Me.rbtnMTProveedor = New System.Windows.Forms.RadioButton()
      Me.rbtnOCOrdeCompra = New System.Windows.Forms.RadioButton()
      Me.chkMTTodos = New System.Windows.Forms.CheckBox()
      Me.AcMTFecha = New ACControles.ACFecha(Me.components)
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
      Me.acpnlTitulo = New ACControles.ACPanelCaption()
      Me.eprError = New System.Windows.Forms.ErrorProvider(Me.components)
      Me.acTool.SuspendLayout()
      Me.tabMantenimiento.SuspendLayout()
      Me.tabDatos.SuspendLayout()
      Me.pnlDatos.SuspendLayout()
      Me.pnlDetalle.SuspendLayout()
      CType(Me.c1grdDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.bnavProductos, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.bnavProductos.SuspendLayout()
      Me.pnlItem.SuspendLayout()
      Me.pnlCabecera.SuspendLayout()
      Me.grpDocReferencia.SuspendLayout()
      Me.tabBusqueda.SuspendLayout()
      CType(Me.c1grdBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.grpBusqueda.SuspendLayout()
      Me.grpCliente.SuspendLayout()
      CType(Me.bnavBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.bnavBusqueda.SuspendLayout()
      Me.tabMercTransito.SuspendLayout()
      CType(Me.c1grdMTBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.GroupBox1.SuspendLayout()
      Me.GroupBox2.SuspendLayout()
      CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.BindingNavigator1.SuspendLayout()
      CType(Me.eprError, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'acTool
      '
      Me.acTool.ACBtnAnularEnabled = False
      Me.acTool.ACBtnAnularVisible = False
      Me.acTool.ACBtnBuscarEnabled = False
      Me.acTool.ACBtnBuscarVisible = False
      Me.acTool.ACBtnCancelarEnabled = False
      Me.acTool.ACBtnCancelarText = "&Volver"
      Me.acTool.ACBtnCancelarVisible = False
      Me.acTool.ACBtnEliminarEnabled = False
      Me.acTool.ACBtnEliminarVisible = False
      Me.acTool.ACBtnGrabarEnabled = False
      Me.acTool.ACBtnGrabarVisible = False
      Me.acTool.ACBtnImprimirEnabled = False
      Me.acTool.ACBtnImprimirVisible = False
      Me.acTool.ACBtnRehusarEnabled = False
      Me.acTool.ACBtnRehusarVisible = False
      Me.acTool.ACBtnReporteEnabled = False
      Me.acTool.ACBtnReporteVisible = False
      Me.acTool.ACBtnSalirText = "&Salir"
      Me.acTool.ACBtnVolverEnabled = False
      Me.acTool.ACBtnVolverVisible = False
      Me.acTool.ACTipoToolBar = ACControles.ACToolBarMantHorizontalNew.tipoToolBar.ToolNuevoGrabar
      Me.acTool.Dock = System.Windows.Forms.DockStyle.Bottom
      Me.acTool.Font = New System.Drawing.Font("Tahoma", 9.5!)
      Me.acTool.ImageScalingSize = New System.Drawing.Size(32, 32)
      Me.acTool.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.actsbtnPrevisualizar})
      Me.acTool.Location = New System.Drawing.Point(0, 466)
      Me.acTool.Name = "acTool"
      Me.acTool.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
      Me.acTool.Size = New System.Drawing.Size(792, 56)
      Me.acTool.TabIndex = 12
      Me.acTool.Text = "AcToolBarMantHorizontalNew1"
      '
      'actsbtnPrevisualizar
      '
      Me.actsbtnPrevisualizar.AutoSize = False
      Me.actsbtnPrevisualizar.Image = Global.ACPLogistica.My.Resources.Resources.Buscar2_32x32
      Me.actsbtnPrevisualizar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
      Me.actsbtnPrevisualizar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
      Me.actsbtnPrevisualizar.ImageTransparentColor = System.Drawing.Color.Magenta
      Me.actsbtnPrevisualizar.Name = "tsbBoton"
      Me.actsbtnPrevisualizar.Size = New System.Drawing.Size(84, 53)
      Me.actsbtnPrevisualizar.Text = "Revisar"
      Me.actsbtnPrevisualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
      Me.actsbtnPrevisualizar.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
      Me.actsbtnPrevisualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
      Me.actsbtnPrevisualizar.Visible = False
      '
      'tabMantenimiento
      '
      Me.tabMantenimiento.BackColor = System.Drawing.Color.LightSteelBlue
      Me.tabMantenimiento.Dock = System.Windows.Forms.DockStyle.Fill
      Me.tabMantenimiento.Location = New System.Drawing.Point(0, 45)
      Me.tabMantenimiento.MediaPlayerDockSides = False
      Me.tabMantenimiento.Name = "tabMantenimiento"
      Me.tabMantenimiento.OfficeDockSides = False
      Me.tabMantenimiento.SelectedIndex = 0
      Me.tabMantenimiento.ShowDropSelect = False
      Me.tabMantenimiento.Size = New System.Drawing.Size(792, 421)
      Me.tabMantenimiento.TabIndex = 14
      Me.tabMantenimiento.TabPages.AddRange(New Crownwood.DotNetMagic.Controls.TabPage() {Me.tabDatos, Me.tabBusqueda, Me.tabMercTransito})
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
      Me.tabDatos.SelectTextBackColor = System.Drawing.Color.Empty
      Me.tabDatos.SelectTextColor = System.Drawing.Color.Empty
      Me.tabDatos.Size = New System.Drawing.Size(790, 396)
      Me.tabDatos.TabIndex = 4
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
      Me.pnlDatos.Size = New System.Drawing.Size(790, 396)
      Me.pnlDatos.TabIndex = 1
      '
      'pnlDetalle
      '
      Me.pnlDetalle.Controls.Add(Me.c1grdDetalle)
      Me.pnlDetalle.Controls.Add(Me.bnavProductos)
      Me.pnlDetalle.Controls.Add(Me.pnlItem)
      Me.pnlDetalle.Controls.Add(Me.pnlPie)
      Me.pnlDetalle.Dock = System.Windows.Forms.DockStyle.Fill
      Me.pnlDetalle.Location = New System.Drawing.Point(0, 142)
      Me.pnlDetalle.Name = "pnlDetalle"
      Me.pnlDetalle.Size = New System.Drawing.Size(790, 254)
      Me.pnlDetalle.TabIndex = 69
      '
      'c1grdDetalle
      '
      Me.c1grdDetalle.BackColor = System.Drawing.Color.White
      Me.c1grdDetalle.ColumnInfo = resources.GetString("c1grdDetalle.ColumnInfo")
      Me.c1grdDetalle.Dock = System.Windows.Forms.DockStyle.Fill
      Me.c1grdDetalle.Location = New System.Drawing.Point(0, 47)
      Me.c1grdDetalle.Name = "c1grdDetalle"
      Me.c1grdDetalle.Rows.Count = 5
      Me.c1grdDetalle.Rows.DefaultSize = 20
      Me.c1grdDetalle.Size = New System.Drawing.Size(790, 174)
      Me.c1grdDetalle.StyleInfo = resources.GetString("c1grdDetalle.StyleInfo")
      Me.c1grdDetalle.TabIndex = 8
      '
      'bnavProductos
      '
      Me.bnavProductos.AddNewItem = Me.ToolStripButton1
      Me.bnavProductos.CountItem = Me.ToolStripLabel1
      Me.bnavProductos.DeleteItem = Me.ToolStripButton2
      Me.bnavProductos.Dock = System.Windows.Forms.DockStyle.Bottom
      Me.bnavProductos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripSeparator1, Me.ToolStripTextBox1, Me.ToolStripLabel1, Me.ToolStripSeparator2, Me.ToolStripButton5, Me.ToolStripButton6, Me.ToolStripSeparator3, Me.ToolStripButton1, Me.ToolStripButton2})
      Me.bnavProductos.Location = New System.Drawing.Point(0, 196)
      Me.bnavProductos.MoveFirstItem = Me.ToolStripButton3
      Me.bnavProductos.MoveLastItem = Me.ToolStripButton6
      Me.bnavProductos.MoveNextItem = Me.ToolStripButton5
      Me.bnavProductos.MovePreviousItem = Me.ToolStripButton4
      Me.bnavProductos.Name = "bnavProductos"
      Me.bnavProductos.PositionItem = Me.ToolStripTextBox1
      Me.bnavProductos.Size = New System.Drawing.Size(790, 25)
      Me.bnavProductos.TabIndex = 9
      Me.bnavProductos.Text = "BindingNavigator1"
      Me.bnavProductos.Visible = False
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
      'pnlItem
      '
      Me.pnlItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(145, Byte), Integer))
      Me.pnlItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.pnlItem.Controls.Add(Me.txtOpcion)
      Me.pnlItem.Controls.Add(Me.actxnCantidad)
      Me.pnlItem.Controls.Add(Me.Label8)
      Me.pnlItem.Controls.Add(Me.txtProdDescripcion)
      Me.pnlItem.Controls.Add(Me.Label7)
      Me.pnlItem.Controls.Add(Me.Label11)
      Me.pnlItem.Controls.Add(Me.actxaProdCodigo)
      Me.pnlItem.Dock = System.Windows.Forms.DockStyle.Top
      Me.pnlItem.Location = New System.Drawing.Point(0, 0)
      Me.pnlItem.Name = "pnlItem"
      Me.pnlItem.Size = New System.Drawing.Size(790, 47)
      Me.pnlItem.TabIndex = 1
      '
      'txtOpcion
      '
      Me.txtOpcion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtOpcion.BackColor = System.Drawing.Color.Gainsboro
      Me.txtOpcion.Location = New System.Drawing.Point(753, 21)
      Me.txtOpcion.Name = "txtOpcion"
      Me.txtOpcion.Size = New System.Drawing.Size(25, 23)
      Me.txtOpcion.TabIndex = 20
      '
      'actxnCantidad
      '
      Me.actxnCantidad.ACEnteros = 9
      Me.actxnCantidad.ACEstandar = ACControles.ACEstandaresFormato.ACDecimal
      Me.actxnCantidad.ACNegativo = True
      Me.actxnCantidad.ACValue = New Decimal(New Integer() {0, 0, 0, 131072})
      Me.actxnCantidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.actxnCantidad.Location = New System.Drawing.Point(659, 21)
      Me.actxnCantidad.MaxLength = 12
      Me.actxnCantidad.Name = "actxnCantidad"
      Me.actxnCantidad.Size = New System.Drawing.Size(93, 23)
      Me.actxnCantidad.TabIndex = 9
      Me.actxnCantidad.Text = "0.00"
      Me.actxnCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
      '
      'Label8
      '
      Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.Label8.AutoSize = True
      Me.Label8.ForeColor = System.Drawing.Color.White
      Me.Label8.Location = New System.Drawing.Point(679, 5)
      Me.Label8.Name = "Label8"
      Me.Label8.Size = New System.Drawing.Size(55, 15)
      Me.Label8.TabIndex = 8
      Me.Label8.Text = "Cantidad"
      '
      'txtProdDescripcion
      '
      Me.txtProdDescripcion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtProdDescripcion.Location = New System.Drawing.Point(126, 21)
      Me.txtProdDescripcion.Name = "txtProdDescripcion"
      Me.txtProdDescripcion.ReadOnly = True
      Me.txtProdDescripcion.Size = New System.Drawing.Size(531, 23)
      Me.txtProdDescripcion.TabIndex = 3
      '
      'Label7
      '
      Me.Label7.AutoSize = True
      Me.Label7.ForeColor = System.Drawing.Color.White
      Me.Label7.Location = New System.Drawing.Point(138, 5)
      Me.Label7.Name = "Label7"
      Me.Label7.Size = New System.Drawing.Size(69, 15)
      Me.Label7.TabIndex = 2
      Me.Label7.Text = "Descripcion"
      '
      'Label11
      '
      Me.Label11.AutoSize = True
      Me.Label11.ForeColor = System.Drawing.Color.White
      Me.Label11.Location = New System.Drawing.Point(29, 5)
      Me.Label11.Name = "Label11"
      Me.Label11.Size = New System.Drawing.Size(46, 15)
      Me.Label11.TabIndex = 0
      Me.Label11.Text = "Codigo"
      '
      'actxaProdCodigo
      '
      Me.actxaProdCodigo.ACActivarAyudaAuto = False
      Me.actxaProdCodigo.ACLongitudAceptada = 0
      Me.actxaProdCodigo.ACTipo = ACControles.ACTextBoxAyuda.TipoTextBoxAyuda.AlfaNumerico
      Me.actxaProdCodigo.Location = New System.Drawing.Point(19, 21)
      Me.actxaProdCodigo.MaxLength = 32767
      Me.actxaProdCodigo.Name = "actxaProdCodigo"
      Me.actxaProdCodigo.Size = New System.Drawing.Size(105, 23)
      Me.actxaProdCodigo.TabIndex = 1
      '
      'pnlPie
      '
      Me.pnlPie.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(145, Byte), Integer))
      Me.pnlPie.Dock = System.Windows.Forms.DockStyle.Bottom
      Me.pnlPie.Location = New System.Drawing.Point(0, 221)
      Me.pnlPie.Name = "pnlPie"
      Me.pnlPie.Size = New System.Drawing.Size(790, 33)
      Me.pnlPie.TabIndex = 10
      '
      'pnlCabecera
      '
      Me.pnlCabecera.Controls.Add(Me.Label3)
      Me.pnlCabecera.Controls.Add(Me.txtOrdCompra)
      Me.pnlCabecera.Controls.Add(Me.Label2)
      Me.pnlCabecera.Controls.Add(Me.txtCodOrdCompra)
      Me.pnlCabecera.Controls.Add(Me.grpDocReferencia)
      Me.pnlCabecera.Controls.Add(Me.Label6)
      Me.pnlCabecera.Controls.Add(Me.txtNroOrden)
      Me.pnlCabecera.Controls.Add(Me.txtRazSocial)
      Me.pnlCabecera.Controls.Add(Me.txtCodProveedor)
      Me.pnlCabecera.Controls.Add(Me.Label5)
      Me.pnlCabecera.Controls.Add(Me.Label17)
      Me.pnlCabecera.Controls.Add(Me.Label20)
      Me.pnlCabecera.Controls.Add(Me.Label1)
      Me.pnlCabecera.Controls.Add(Me.dtpFecEmision)
      Me.pnlCabecera.Controls.Add(Me.txtCodigo)
      Me.pnlCabecera.Dock = System.Windows.Forms.DockStyle.Top
      Me.pnlCabecera.Location = New System.Drawing.Point(0, 0)
      Me.pnlCabecera.Name = "pnlCabecera"
      Me.pnlCabecera.Size = New System.Drawing.Size(790, 142)
      Me.pnlCabecera.TabIndex = 0
      '
      'Label3
      '
      Me.Label3.AutoSize = True
      Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label3.Location = New System.Drawing.Point(558, 69)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(102, 13)
      Me.Label3.TabIndex = 12
      Me.Label3.Text = "Cod. Ord. Compra :"
      '
      'txtOrdCompra
      '
      Me.txtOrdCompra.Location = New System.Drawing.Point(109, 64)
      Me.txtOrdCompra.Name = "txtOrdCompra"
      Me.txtOrdCompra.ReadOnly = True
      Me.txtOrdCompra.Size = New System.Drawing.Size(115, 23)
      Me.txtOrdCompra.TabIndex = 9
      '
      'Label2
      '
      Me.Label2.AutoSize = True
      Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label2.Location = New System.Drawing.Point(3, 69)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(100, 13)
      Me.Label2.TabIndex = 8
      Me.Label2.Text = "Nro. Ord. Compra :"
      '
      'txtCodOrdCompra
      '
      Me.txtCodOrdCompra.Location = New System.Drawing.Point(664, 64)
      Me.txtCodOrdCompra.Name = "txtCodOrdCompra"
      Me.txtCodOrdCompra.ReadOnly = True
      Me.txtCodOrdCompra.Size = New System.Drawing.Size(115, 23)
      Me.txtCodOrdCompra.TabIndex = 13
      '
      'grpDocReferencia
      '
      Me.grpDocReferencia.Controls.Add(Me.txtSerie)
      Me.grpDocReferencia.Controls.Add(Me.actxnNumero)
      Me.grpDocReferencia.Controls.Add(Me.Label15)
      Me.grpDocReferencia.Controls.Add(Me.Label18)
      Me.grpDocReferencia.Controls.Add(Me.Label23)
      Me.grpDocReferencia.Controls.Add(Me.cmbTipoDoc)
      Me.grpDocReferencia.Dock = System.Windows.Forms.DockStyle.Bottom
      Me.grpDocReferencia.Location = New System.Drawing.Point(0, 90)
      Me.grpDocReferencia.Name = "grpDocReferencia"
      Me.grpDocReferencia.Size = New System.Drawing.Size(790, 52)
      Me.grpDocReferencia.TabIndex = 14
      Me.grpDocReferencia.TabStop = False
      Me.grpDocReferencia.Text = "Documentos de Referencia"
      '
      'txtSerie
      '
      Me.txtSerie.Location = New System.Drawing.Point(385, 20)
      Me.txtSerie.MaxLength = 3
      Me.txtSerie.Name = "txtSerie"
      Me.txtSerie.Size = New System.Drawing.Size(66, 23)
      Me.txtSerie.TabIndex = 3
      Me.txtSerie.Tag = "EN"
      '
      'actxnNumero
      '
      Me.actxnNumero.ACDecimales = 0
      Me.actxnNumero.ACEstandar = ACControles.ACEstandaresFormato.ACSoloNumeros
      Me.actxnNumero.ACFormato = "#############"
      Me.actxnNumero.ACNegativo = True
      Me.actxnNumero.ACValue = New Decimal(New Integer() {0, 0, 0, 0})
      Me.actxnNumero.Location = New System.Drawing.Point(529, 20)
      Me.actxnNumero.MaxLength = 10
      Me.actxnNumero.Name = "actxnNumero"
      Me.actxnNumero.Size = New System.Drawing.Size(110, 23)
      Me.actxnNumero.TabIndex = 5
      Me.actxnNumero.Tag = "EN"
      Me.actxnNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
      '
      'Label15
      '
      Me.Label15.AutoSize = True
      Me.Label15.Location = New System.Drawing.Point(466, 24)
      Me.Label15.Name = "Label15"
      Me.Label15.Size = New System.Drawing.Size(57, 15)
      Me.Label15.TabIndex = 4
      Me.Label15.Text = "Numero :"
      '
      'Label18
      '
      Me.Label18.AutoSize = True
      Me.Label18.Location = New System.Drawing.Point(338, 24)
      Me.Label18.Name = "Label18"
      Me.Label18.Size = New System.Drawing.Size(38, 15)
      Me.Label18.TabIndex = 2
      Me.Label18.Text = "Serie :"
      '
      'Label23
      '
      Me.Label23.AutoSize = True
      Me.Label23.Location = New System.Drawing.Point(39, 24)
      Me.Label23.Name = "Label23"
      Me.Label23.Size = New System.Drawing.Size(64, 15)
      Me.Label23.TabIndex = 0
      Me.Label23.Text = "Tipo Doc. :"
      '
      'cmbTipoDoc
      '
      Me.cmbTipoDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.cmbTipoDoc.FormattingEnabled = True
      Me.cmbTipoDoc.Location = New System.Drawing.Point(109, 20)
      Me.cmbTipoDoc.Name = "cmbTipoDoc"
      Me.cmbTipoDoc.Size = New System.Drawing.Size(211, 23)
      Me.cmbTipoDoc.TabIndex = 1
      Me.cmbTipoDoc.Tag = "ECO"
      '
      'Label6
      '
      Me.Label6.AutoSize = True
      Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label6.Location = New System.Drawing.Point(239, 69)
      Me.Label6.Name = "Label6"
      Me.Label6.Size = New System.Drawing.Size(76, 13)
      Me.Label6.TabIndex = 10
      Me.Label6.Text = "Doc. Compra :"
      '
      'txtNroOrden
      '
      Me.txtNroOrden.Location = New System.Drawing.Point(323, 64)
      Me.txtNroOrden.Name = "txtNroOrden"
      Me.txtNroOrden.ReadOnly = True
      Me.txtNroOrden.Size = New System.Drawing.Size(115, 23)
      Me.txtNroOrden.TabIndex = 11
      '
      'txtRazSocial
      '
      Me.txtRazSocial.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtRazSocial.Location = New System.Drawing.Point(323, 36)
      Me.txtRazSocial.Name = "txtRazSocial"
      Me.txtRazSocial.ReadOnly = True
      Me.txtRazSocial.Size = New System.Drawing.Size(456, 23)
      Me.txtRazSocial.TabIndex = 7
      '
      'txtCodProveedor
      '
      Me.txtCodProveedor.Location = New System.Drawing.Point(109, 36)
      Me.txtCodProveedor.Name = "txtCodProveedor"
      Me.txtCodProveedor.ReadOnly = True
      Me.txtCodProveedor.Size = New System.Drawing.Size(115, 23)
      Me.txtCodProveedor.TabIndex = 5
      '
      'Label5
      '
      Me.Label5.AutoSize = True
      Me.Label5.Location = New System.Drawing.Point(36, 40)
      Me.Label5.Name = "Label5"
      Me.Label5.Size = New System.Drawing.Size(67, 15)
      Me.Label5.TabIndex = 4
      Me.Label5.Text = "&Proveedor :"
      '
      'Label17
      '
      Me.Label17.AutoSize = True
      Me.Label17.Location = New System.Drawing.Point(236, 40)
      Me.Label17.Name = "Label17"
      Me.Label17.Size = New System.Drawing.Size(79, 15)
      Me.Label17.TabIndex = 6
      Me.Label17.Text = "&Razon Social :"
      '
      'Label20
      '
      Me.Label20.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.Label20.AutoSize = True
      Me.Label20.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label20.Location = New System.Drawing.Point(567, 12)
      Me.Label20.Name = "Label20"
      Me.Label20.Size = New System.Drawing.Size(75, 13)
      Me.Label20.TabIndex = 2
      Me.Label20.Text = "Nro. Ingreso :"
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.Location = New System.Drawing.Point(59, 11)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(44, 15)
      Me.Label1.TabIndex = 0
      Me.Label1.Text = "Fecha :"
      '
      'dtpFecEmision
      '
      Me.dtpFecEmision.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
      Me.dtpFecEmision.Location = New System.Drawing.Point(109, 7)
      Me.dtpFecEmision.Name = "dtpFecEmision"
      Me.dtpFecEmision.Size = New System.Drawing.Size(96, 23)
      Me.dtpFecEmision.TabIndex = 1
      '
      'txtCodigo
      '
      Me.txtCodigo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtCodigo.Location = New System.Drawing.Point(649, 7)
      Me.txtCodigo.Name = "txtCodigo"
      Me.txtCodigo.ReadOnly = True
      Me.txtCodigo.Size = New System.Drawing.Size(130, 23)
      Me.txtCodigo.TabIndex = 3
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
      Me.tabBusqueda.Selected = False
      Me.tabBusqueda.SelectTextBackColor = System.Drawing.Color.Empty
      Me.tabBusqueda.SelectTextColor = System.Drawing.Color.Empty
      Me.tabBusqueda.Size = New System.Drawing.Size(790, 396)
      Me.tabBusqueda.TabIndex = 5
      Me.tabBusqueda.Title = "Busqueda"
      Me.tabBusqueda.ToolTip = "Busqueda"
      '
      'c1grdBusqueda
      '
      Me.c1grdBusqueda.ColumnInfo = "2,1,0,0,0,100,Columns:0{Width:25;}" & Global.Microsoft.VisualBasic.ChrW(9)
      Me.c1grdBusqueda.Dock = System.Windows.Forms.DockStyle.Fill
      Me.c1grdBusqueda.Location = New System.Drawing.Point(0, 96)
      Me.c1grdBusqueda.Name = "c1grdBusqueda"
      Me.c1grdBusqueda.Rows.Count = 2
      Me.c1grdBusqueda.Rows.DefaultSize = 20
      Me.c1grdBusqueda.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
      Me.c1grdBusqueda.Size = New System.Drawing.Size(790, 300)
      Me.c1grdBusqueda.StyleInfo = resources.GetString("c1grdBusqueda.StyleInfo")
      Me.c1grdBusqueda.TabIndex = 2
      '
      'grpBusqueda
      '
      Me.grpBusqueda.Controls.Add(Me.btnConsultar)
      Me.grpBusqueda.Controls.Add(Me.grpCliente)
      Me.grpBusqueda.Controls.Add(Me.chkTodos)
      Me.grpBusqueda.Controls.Add(Me.AcFecha)
      Me.grpBusqueda.Dock = System.Windows.Forms.DockStyle.Top
      Me.grpBusqueda.Location = New System.Drawing.Point(0, 0)
      Me.grpBusqueda.Name = "grpBusqueda"
      Me.grpBusqueda.Size = New System.Drawing.Size(790, 96)
      Me.grpBusqueda.TabIndex = 4
      Me.grpBusqueda.TabStop = False
      Me.grpBusqueda.Text = "Opciones de Busqueda de Ordenes de Compra"
      '
      'btnConsultar
      '
      Me.btnConsultar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.btnConsultar.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
      Me.btnConsultar.Image = Global.ACPLogistica.My.Resources.Resources.Search_files_32x32
      Me.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
      Me.btnConsultar.Location = New System.Drawing.Point(685, 49)
      Me.btnConsultar.Name = "btnConsultar"
      Me.btnConsultar.Size = New System.Drawing.Size(99, 42)
      Me.btnConsultar.TabIndex = 33
      Me.btnConsultar.Text = "Consultar"
      Me.btnConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.btnConsultar.UseVisualStyleBackColor = True
      '
      'grpCliente
      '
      Me.grpCliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.grpCliente.Controls.Add(Me.txtBusqueda)
      Me.grpCliente.Controls.Add(Me.rbtnProveedor)
      Me.grpCliente.Controls.Add(Me.rbtnNroOrdenCompra)
      Me.grpCliente.Location = New System.Drawing.Point(11, 20)
      Me.grpCliente.Name = "grpCliente"
      Me.grpCliente.Size = New System.Drawing.Size(436, 63)
      Me.grpCliente.TabIndex = 9
      Me.grpCliente.TabStop = False
      Me.grpCliente.Text = "Datos de la Orden de Compra"
      '
      'txtBusqueda
      '
      Me.txtBusqueda.ACActivarAyudaAuto = False
      Me.txtBusqueda.ACLongitudAceptada = 0
      Me.txtBusqueda.ACTipo = ACControles.ACTextBoxAyuda.TipoTextBoxAyuda.AlfaNumerico
      Me.txtBusqueda.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtBusqueda.Location = New System.Drawing.Point(6, 36)
      Me.txtBusqueda.MaxLength = 32767
      Me.txtBusqueda.Name = "txtBusqueda"
      Me.txtBusqueda.Size = New System.Drawing.Size(417, 23)
      Me.txtBusqueda.TabIndex = 0
      '
      'rbtnProveedor
      '
      Me.rbtnProveedor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.rbtnProveedor.AutoSize = True
      Me.rbtnProveedor.Checked = True
      Me.rbtnProveedor.Location = New System.Drawing.Point(195, 15)
      Me.rbtnProveedor.Name = "rbtnProveedor"
      Me.rbtnProveedor.Size = New System.Drawing.Size(79, 19)
      Me.rbtnProveedor.TabIndex = 1
      Me.rbtnProveedor.TabStop = True
      Me.rbtnProveedor.Text = "Proveedor"
      Me.rbtnProveedor.UseVisualStyleBackColor = True
      '
      'rbtnNroOrdenCompra
      '
      Me.rbtnNroOrdenCompra.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.rbtnNroOrdenCompra.AutoSize = True
      Me.rbtnNroOrdenCompra.Location = New System.Drawing.Point(257, 15)
      Me.rbtnNroOrdenCompra.Name = "rbtnNroOrdenCompra"
      Me.rbtnNroOrdenCompra.Size = New System.Drawing.Size(166, 19)
      Me.rbtnNroOrdenCompra.TabIndex = 2
      Me.rbtnNroOrdenCompra.Text = "Nro Orden del Documento"
      Me.rbtnNroOrdenCompra.UseVisualStyleBackColor = True
      '
      'chkTodos
      '
      Me.chkTodos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.chkTodos.AutoSize = True
      Me.chkTodos.Location = New System.Drawing.Point(576, 60)
      Me.chkTodos.Name = "chkTodos"
      Me.chkTodos.Size = New System.Drawing.Size(103, 19)
      Me.chkTodos.TabIndex = 4
      Me.chkTodos.Text = "Mostrar Todos"
      Me.chkTodos.UseVisualStyleBackColor = True
      '
      'AcFecha
      '
      Me.AcFecha.ACFecha_A = New Date(2012, 12, 22, 8, 16, 29, 586)
      Me.AcFecha.ACFecha_De = New Date(2012, 12, 22, 8, 16, 29, 584)
      Me.AcFecha.ACFechaObligatoria = True
      Me.AcFecha.ACFormatoControl = ACControles.ACFecha.ACTipoFormatoControl.Horizontal
      Me.AcFecha.ACHoyChecked = False
      Me.AcFecha.ACIncrementoFecha_A = ACControles.ACFecha.ACTipoIncremento.Dia
      Me.AcFecha.ACIncrementoFecha_De = ACControles.ACFecha.ACTipoIncremento.Dia
      Me.AcFecha.ACIntervalos = ACControles.ACFecha.ACIntervalo.Ninguno
      Me.AcFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.AcFecha.Location = New System.Drawing.Point(453, 0)
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
      Me.bnavBusqueda.Location = New System.Drawing.Point(0, 371)
      Me.bnavBusqueda.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
      Me.bnavBusqueda.MoveLastItem = Me.BindingNavigatorMoveLastItem
      Me.bnavBusqueda.MoveNextItem = Me.BindingNavigatorMoveNextItem
      Me.bnavBusqueda.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
      Me.bnavBusqueda.Name = "bnavBusqueda"
      Me.bnavBusqueda.PositionItem = Me.BindingNavigatorPositionItem
      Me.bnavBusqueda.Size = New System.Drawing.Size(790, 25)
      Me.bnavBusqueda.TabIndex = 3
      Me.bnavBusqueda.Text = "BindingNavigator1"
      Me.bnavBusqueda.Visible = False
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
      'tabMercTransito
      '
      Me.tabMercTransito.Controls.Add(Me.c1grdMTBusqueda)
      Me.tabMercTransito.Controls.Add(Me.GroupBox1)
      Me.tabMercTransito.Controls.Add(Me.BindingNavigator1)
      Me.tabMercTransito.InactiveBackColor = System.Drawing.Color.Empty
      Me.tabMercTransito.InactiveTextBackColor = System.Drawing.Color.Empty
      Me.tabMercTransito.InactiveTextColor = System.Drawing.Color.Empty
      Me.tabMercTransito.Location = New System.Drawing.Point(1, 1)
      Me.tabMercTransito.Name = "tabMercTransito"
      Me.tabMercTransito.SelectBackColor = System.Drawing.Color.Empty
      Me.tabMercTransito.Selected = False
      Me.tabMercTransito.SelectTextBackColor = System.Drawing.Color.Empty
      Me.tabMercTransito.SelectTextColor = System.Drawing.Color.Empty
      Me.tabMercTransito.Size = New System.Drawing.Size(790, 396)
      Me.tabMercTransito.TabIndex = 6
      Me.tabMercTransito.Title = "Merc. Transito"
      Me.tabMercTransito.ToolTip = "Merc. Transito"
      '
      'c1grdMTBusqueda
      '
      Me.c1grdMTBusqueda.ColumnInfo = "2,1,0,0,0,100,Columns:0{Width:25;}" & Global.Microsoft.VisualBasic.ChrW(9)
      Me.c1grdMTBusqueda.Dock = System.Windows.Forms.DockStyle.Fill
      Me.c1grdMTBusqueda.Location = New System.Drawing.Point(0, 88)
      Me.c1grdMTBusqueda.Name = "c1grdMTBusqueda"
      Me.c1grdMTBusqueda.Rows.Count = 2
      Me.c1grdMTBusqueda.Rows.DefaultSize = 20
      Me.c1grdMTBusqueda.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
      Me.c1grdMTBusqueda.Size = New System.Drawing.Size(790, 283)
      Me.c1grdMTBusqueda.StyleInfo = resources.GetString("c1grdMTBusqueda.StyleInfo")
      Me.c1grdMTBusqueda.TabIndex = 5
      '
      'GroupBox1
      '
      Me.GroupBox1.Controls.Add(Me.btnMTConsultar)
      Me.GroupBox1.Controls.Add(Me.chkAgrupar)
      Me.GroupBox1.Controls.Add(Me.GroupBox2)
      Me.GroupBox1.Controls.Add(Me.chkMTTodos)
      Me.GroupBox1.Controls.Add(Me.AcMTFecha)
      Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
      Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
      Me.GroupBox1.Name = "GroupBox1"
      Me.GroupBox1.Size = New System.Drawing.Size(790, 88)
      Me.GroupBox1.TabIndex = 7
      Me.GroupBox1.TabStop = False
      Me.GroupBox1.Text = "Opciones de Busqueda de Mercaderia en Transito"
      '
      'btnMTConsultar
      '
      Me.btnMTConsultar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.btnMTConsultar.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
      Me.btnMTConsultar.Image = Global.ACPLogistica.My.Resources.Resources.Search_files_32x32
      Me.btnMTConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
      Me.btnMTConsultar.Location = New System.Drawing.Point(685, 44)
      Me.btnMTConsultar.Name = "btnMTConsultar"
      Me.btnMTConsultar.Size = New System.Drawing.Size(99, 42)
      Me.btnMTConsultar.TabIndex = 32
      Me.btnMTConsultar.Text = "Consultar"
      Me.btnMTConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.btnMTConsultar.UseVisualStyleBackColor = True
      '
      'chkAgrupar
      '
      Me.chkAgrupar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.chkAgrupar.AutoSize = True
      Me.chkAgrupar.Location = New System.Drawing.Point(438, 59)
      Me.chkAgrupar.Name = "chkAgrupar"
      Me.chkAgrupar.Size = New System.Drawing.Size(129, 19)
      Me.chkAgrupar.TabIndex = 10
      Me.chkAgrupar.Text = "Agrupar Resultados"
      Me.chkAgrupar.UseVisualStyleBackColor = True
      '
      'GroupBox2
      '
      Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.GroupBox2.Controls.Add(Me.txtMTBusqueda)
      Me.GroupBox2.Controls.Add(Me.rbtnMTProveedor)
      Me.GroupBox2.Controls.Add(Me.rbtnOCOrdeCompra)
      Me.GroupBox2.Location = New System.Drawing.Point(6, 20)
      Me.GroupBox2.Name = "GroupBox2"
      Me.GroupBox2.Size = New System.Drawing.Size(423, 63)
      Me.GroupBox2.TabIndex = 9
      Me.GroupBox2.TabStop = False
      Me.GroupBox2.Text = "Datos del Registro"
      '
      'txtMTBusqueda
      '
      Me.txtMTBusqueda.ACActivarAyudaAuto = False
      Me.txtMTBusqueda.ACLongitudAceptada = 0
      Me.txtMTBusqueda.ACTipo = ACControles.ACTextBoxAyuda.TipoTextBoxAyuda.AlfaNumerico
      Me.txtMTBusqueda.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtMTBusqueda.Location = New System.Drawing.Point(6, 36)
      Me.txtMTBusqueda.MaxLength = 32767
      Me.txtMTBusqueda.Name = "txtMTBusqueda"
      Me.txtMTBusqueda.Size = New System.Drawing.Size(404, 23)
      Me.txtMTBusqueda.TabIndex = 0
      '
      'rbtnMTProveedor
      '
      Me.rbtnMTProveedor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.rbtnMTProveedor.AutoSize = True
      Me.rbtnMTProveedor.Checked = True
      Me.rbtnMTProveedor.Location = New System.Drawing.Point(179, 15)
      Me.rbtnMTProveedor.Name = "rbtnMTProveedor"
      Me.rbtnMTProveedor.Size = New System.Drawing.Size(79, 19)
      Me.rbtnMTProveedor.TabIndex = 1
      Me.rbtnMTProveedor.TabStop = True
      Me.rbtnMTProveedor.Text = "Proveedor"
      Me.rbtnMTProveedor.UseVisualStyleBackColor = True
      '
      'rbtnOCOrdeCompra
      '
      Me.rbtnOCOrdeCompra.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.rbtnOCOrdeCompra.AutoSize = True
      Me.rbtnOCOrdeCompra.Location = New System.Drawing.Point(267, 15)
      Me.rbtnOCOrdeCompra.Name = "rbtnOCOrdeCompra"
      Me.rbtnOCOrdeCompra.Size = New System.Drawing.Size(143, 19)
      Me.rbtnOCOrdeCompra.TabIndex = 2
      Me.rbtnOCOrdeCompra.Text = "Nro Orden de Compra"
      Me.rbtnOCOrdeCompra.UseVisualStyleBackColor = True
      '
      'chkMTTodos
      '
      Me.chkMTTodos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.chkMTTodos.AutoSize = True
      Me.chkMTTodos.Location = New System.Drawing.Point(576, 59)
      Me.chkMTTodos.Name = "chkMTTodos"
      Me.chkMTTodos.Size = New System.Drawing.Size(103, 19)
      Me.chkMTTodos.TabIndex = 4
      Me.chkMTTodos.Text = "Mostrar Todos"
      Me.chkMTTodos.UseVisualStyleBackColor = True
      '
      'AcMTFecha
      '
      Me.AcMTFecha.ACFecha_A = New Date(2012, 12, 22, 8, 16, 29, 658)
      Me.AcMTFecha.ACFecha_De = New Date(2012, 12, 22, 8, 16, 29, 656)
      Me.AcMTFecha.ACFechaObligatoria = True
      Me.AcMTFecha.ACFormatoControl = ACControles.ACFecha.ACTipoFormatoControl.Horizontal
      Me.AcMTFecha.ACHoyChecked = False
      Me.AcMTFecha.ACIncrementoFecha_A = ACControles.ACFecha.ACTipoIncremento.Dia
      Me.AcMTFecha.ACIncrementoFecha_De = ACControles.ACFecha.ACTipoIncremento.Dia
      Me.AcMTFecha.ACIntervalos = ACControles.ACFecha.ACIntervalo.Ninguno
      Me.AcMTFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.AcMTFecha.Location = New System.Drawing.Point(453, 0)
      Me.AcMTFecha.MaximumSize = New System.Drawing.Size(337, 43)
      Me.AcMTFecha.MinimumSize = New System.Drawing.Size(337, 43)
      Me.AcMTFecha.Name = "AcMTFecha"
      Me.AcMTFecha.Size = New System.Drawing.Size(337, 43)
      Me.AcMTFecha.TabIndex = 3
      Me.AcMTFecha.TabStop = False
      '
      'BindingNavigator1
      '
      Me.BindingNavigator1.AddNewItem = Me.ToolStripButton7
      Me.BindingNavigator1.CountItem = Me.ToolStripLabel2
      Me.BindingNavigator1.DeleteItem = Me.ToolStripButton8
      Me.BindingNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom
      Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton9, Me.ToolStripButton10, Me.ToolStripSeparator4, Me.ToolStripTextBox2, Me.ToolStripLabel2, Me.ToolStripSeparator5, Me.ToolStripButton11, Me.ToolStripButton12, Me.ToolStripSeparator6, Me.ToolStripButton7, Me.ToolStripButton8})
      Me.BindingNavigator1.Location = New System.Drawing.Point(0, 371)
      Me.BindingNavigator1.MoveFirstItem = Me.ToolStripButton9
      Me.BindingNavigator1.MoveLastItem = Me.ToolStripButton12
      Me.BindingNavigator1.MoveNextItem = Me.ToolStripButton11
      Me.BindingNavigator1.MovePreviousItem = Me.ToolStripButton10
      Me.BindingNavigator1.Name = "BindingNavigator1"
      Me.BindingNavigator1.PositionItem = Me.ToolStripTextBox2
      Me.BindingNavigator1.Size = New System.Drawing.Size(790, 25)
      Me.BindingNavigator1.TabIndex = 6
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
      'acpnlTitulo
      '
      Me.acpnlTitulo.ACCaption = "Registro de Mercaderia en Transito"
      Me.acpnlTitulo.Dock = System.Windows.Forms.DockStyle.Top
      Me.acpnlTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.0!, System.Drawing.FontStyle.Bold)
      Me.acpnlTitulo.Location = New System.Drawing.Point(0, 0)
      Me.acpnlTitulo.Name = "acpnlTitulo"
      Me.acpnlTitulo.Size = New System.Drawing.Size(792, 45)
      Me.acpnlTitulo.TabIndex = 13
      '
      'eprError
      '
      Me.eprError.ContainerControl = Me
      '
      'TRegMerTransitoOrden
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.BackColor = System.Drawing.Color.LightSteelBlue
      Me.ClientSize = New System.Drawing.Size(792, 522)
      Me.Controls.Add(Me.tabMantenimiento)
      Me.Controls.Add(Me.acpnlTitulo)
      Me.Controls.Add(Me.acTool)
      Me.Name = "TRegMerTransitoOrden"
      Me.Text = "Registro de Mercaderia en Transito"
      Me.acTool.ResumeLayout(False)
      Me.acTool.PerformLayout()
      Me.tabMantenimiento.ResumeLayout(False)
      Me.tabDatos.ResumeLayout(False)
      Me.pnlDatos.ResumeLayout(False)
      Me.pnlDetalle.ResumeLayout(False)
      Me.pnlDetalle.PerformLayout()
      CType(Me.c1grdDetalle, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.bnavProductos, System.ComponentModel.ISupportInitialize).EndInit()
      Me.bnavProductos.ResumeLayout(False)
      Me.bnavProductos.PerformLayout()
      Me.pnlItem.ResumeLayout(False)
      Me.pnlItem.PerformLayout()
      Me.pnlCabecera.ResumeLayout(False)
      Me.pnlCabecera.PerformLayout()
      Me.grpDocReferencia.ResumeLayout(False)
      Me.grpDocReferencia.PerformLayout()
      Me.tabBusqueda.ResumeLayout(False)
      Me.tabBusqueda.PerformLayout()
      CType(Me.c1grdBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
      Me.grpBusqueda.ResumeLayout(False)
      Me.grpBusqueda.PerformLayout()
      Me.grpCliente.ResumeLayout(False)
      Me.grpCliente.PerformLayout()
      CType(Me.bnavBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
      Me.bnavBusqueda.ResumeLayout(False)
      Me.bnavBusqueda.PerformLayout()
      Me.tabMercTransito.ResumeLayout(False)
      Me.tabMercTransito.PerformLayout()
      CType(Me.c1grdMTBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
      Me.GroupBox1.ResumeLayout(False)
      Me.GroupBox1.PerformLayout()
      Me.GroupBox2.ResumeLayout(False)
      Me.GroupBox2.PerformLayout()
      CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.BindingNavigator1.ResumeLayout(False)
      Me.BindingNavigator1.PerformLayout()
      CType(Me.eprError, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents acTool As ACControles.ACToolBarMantHorizontalNew
   Private WithEvents tabMantenimiento As Crownwood.DotNetMagic.Controls.TabControl
   Private WithEvents tabDatos As Crownwood.DotNetMagic.Controls.TabPage
   Friend WithEvents pnlDatos As System.Windows.Forms.Panel
   Private WithEvents tabBusqueda As Crownwood.DotNetMagic.Controls.TabPage
   Friend WithEvents c1grdBusqueda As C1.Win.C1FlexGrid.C1FlexGrid
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
   Friend WithEvents acpnlTitulo As ACControles.ACPanelCaption
   Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
   Friend WithEvents Label20 As System.Windows.Forms.Label
   Friend WithEvents dtpFecEmision As System.Windows.Forms.DateTimePicker
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents pnlCabecera As System.Windows.Forms.Panel
   Friend WithEvents pnlDetalle As System.Windows.Forms.Panel
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
   Friend WithEvents pnlItem As System.Windows.Forms.Panel
   Friend WithEvents txtOpcion As System.Windows.Forms.TextBox
   Friend WithEvents actxnCantidad As ACControles.ACTextBoxNumerico
   Friend WithEvents Label8 As System.Windows.Forms.Label
   Friend WithEvents txtProdDescripcion As System.Windows.Forms.TextBox
   Friend WithEvents Label7 As System.Windows.Forms.Label
   Friend WithEvents Label11 As System.Windows.Forms.Label
   Friend WithEvents actxaProdCodigo As ACControles.ACTextBoxAyuda
   Friend WithEvents pnlPie As System.Windows.Forms.Panel
   Friend WithEvents Label5 As System.Windows.Forms.Label
   Friend WithEvents Label17 As System.Windows.Forms.Label
   Private WithEvents grpBusqueda As System.Windows.Forms.GroupBox
   Friend WithEvents chkTodos As System.Windows.Forms.CheckBox
   Friend WithEvents rbtnNroOrdenCompra As System.Windows.Forms.RadioButton
   Friend WithEvents rbtnProveedor As System.Windows.Forms.RadioButton
   Friend WithEvents AcFecha As ACControles.ACFecha
   Friend WithEvents actsbtnPrevisualizar As ACControles.ACToolStripButton
   Friend WithEvents txtRazSocial As System.Windows.Forms.TextBox
   Friend WithEvents txtCodProveedor As System.Windows.Forms.TextBox
   Friend WithEvents Label6 As System.Windows.Forms.Label
   Friend WithEvents txtNroOrden As System.Windows.Forms.TextBox
   Friend WithEvents grpCliente As System.Windows.Forms.GroupBox
   Friend WithEvents txtBusqueda As ACControles.ACTextBoxAyuda
   Friend WithEvents grpDocReferencia As System.Windows.Forms.GroupBox
   Friend WithEvents txtSerie As System.Windows.Forms.TextBox
   Friend WithEvents actxnNumero As ACControles.ACTextBoxNumerico
   Friend WithEvents Label15 As System.Windows.Forms.Label
   Friend WithEvents Label18 As System.Windows.Forms.Label
   Friend WithEvents Label23 As System.Windows.Forms.Label
   Friend WithEvents cmbTipoDoc As System.Windows.Forms.ComboBox
   Friend WithEvents btnConsultar As System.Windows.Forms.Button
   Friend WithEvents eprError As System.Windows.Forms.ErrorProvider
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents txtCodOrdCompra As System.Windows.Forms.TextBox
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents txtOrdCompra As System.Windows.Forms.TextBox
   Friend WithEvents tabMercTransito As Crownwood.DotNetMagic.Controls.TabPage
   Friend WithEvents c1grdMTBusqueda As C1.Win.C1FlexGrid.C1FlexGrid
   Private WithEvents GroupBox1 As System.Windows.Forms.GroupBox
   Friend WithEvents btnMTConsultar As System.Windows.Forms.Button
   Friend WithEvents chkAgrupar As System.Windows.Forms.CheckBox
   Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
   Friend WithEvents txtMTBusqueda As ACControles.ACTextBoxAyuda
   Friend WithEvents rbtnMTProveedor As System.Windows.Forms.RadioButton
   Friend WithEvents rbtnOCOrdeCompra As System.Windows.Forms.RadioButton
   Friend WithEvents chkMTTodos As System.Windows.Forms.CheckBox
   Friend WithEvents AcMTFecha As ACControles.ACFecha
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
End Class
