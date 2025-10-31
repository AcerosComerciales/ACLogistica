<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TControlDescuentos
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
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TControlDescuentos))
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
      Me.tsbtnAgregarServicio = New System.Windows.Forms.ToolStripButton()
      Me.tsbtnModificarServicio = New System.Windows.Forms.ToolStripButton()
      Me.pnlPie = New System.Windows.Forms.Panel()
      Me.Label13 = New System.Windows.Forms.Label()
      Me.actxnTotal = New ACControles.ACTextBoxNumerico()
      Me.btnCalcular = New System.Windows.Forms.Button()
      Me.pnlCabecera = New System.Windows.Forms.Panel()
      Me.Label25 = New System.Windows.Forms.Label()
      Me.actxnTipoCambio = New ACControles.ACTextBoxNumerico()
      Me.Label15 = New System.Windows.Forms.Label()
      Me.cmbMoneda = New System.Windows.Forms.ComboBox()
      Me.grpTPago = New System.Windows.Forms.GroupBox()
      Me.cmbTipoPago = New System.Windows.Forms.ComboBox()
      Me.Label27 = New System.Windows.Forms.Label()
      Me.Label14 = New System.Windows.Forms.Label()
      Me.dtpFecPago = New System.Windows.Forms.DateTimePicker()
      Me.Label4 = New System.Windows.Forms.Label()
      Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
      Me.grpDocumento = New System.Windows.Forms.GroupBox()
      Me.txtSerie = New System.Windows.Forms.TextBox()
      Me.actxnNumero = New ACControles.ACTextBoxNumerico()
      Me.Label19 = New System.Windows.Forms.Label()
      Me.Label23 = New System.Windows.Forms.Label()
      Me.Label21 = New System.Windows.Forms.Label()
      Me.cmbDocumento = New System.Windows.Forms.ComboBox()
      Me.Label3 = New System.Windows.Forms.Label()
      Me.Label1 = New System.Windows.Forms.Label()
      Me.Label2 = New System.Windows.Forms.Label()
      Me.txtProvNombres = New System.Windows.Forms.TextBox()
      Me.txtProvCodigo = New System.Windows.Forms.TextBox()
      Me.tabBusqueda = New Crownwood.DotNetMagic.Controls.TabPage()
      Me.c1grdBusqueda = New C1.Win.C1FlexGrid.C1FlexGrid()
      Me.grpBusqueda = New System.Windows.Forms.GroupBox()
      Me.btnConsultar = New System.Windows.Forms.Button()
      Me.rbtnProveedor = New System.Windows.Forms.RadioButton()
      Me.acFecha = New ACControles.ACFecha(Me.components)
      Me.grpProveedor = New System.Windows.Forms.GroupBox()
      Me.rbtnBCodigo = New System.Windows.Forms.RadioButton()
      Me.txtBusqueda = New ACControles.ACTextBoxAyuda()
      Me.rbtnBRazSocial = New System.Windows.Forms.RadioButton()
      Me.rbtnBNomComercial = New System.Windows.Forms.RadioButton()
      Me.rbtnDocVenta = New System.Windows.Forms.RadioButton()
      Me.grpDocumentos = New System.Windows.Forms.GroupBox()
      Me.txtCSerie = New ACControles.ACTextBoxNumerico()
      Me.Label18 = New System.Windows.Forms.Label()
      Me.Label22 = New System.Windows.Forms.Label()
      Me.Label24 = New System.Windows.Forms.Label()
      Me.cmbTipoDocumento = New System.Windows.Forms.ComboBox()
      Me.txtBusNumero = New ACControles.ACTextBoxAyuda()
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
      Me.acpnlTitulo = New ACControles.ACPanelCaption()
      Me.acTool = New ACControles.ACToolBarMantHorizontalNew(Me.components)
      Me.acbtnCuota = New ACControles.ACToolStripButton(Me.components)
      Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
      Me.AccmsSeleccionarC1 = New ACControlesC1.ACCMSSeleccionarC1()
      Me.tabMantenimiento.SuspendLayout()
      Me.tabDatos.SuspendLayout()
      Me.pnlDatos.SuspendLayout()
      Me.pnlDetalle.SuspendLayout()
      CType(Me.c1grdDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.bnavProductos, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.bnavProductos.SuspendLayout()
      Me.pnlPie.SuspendLayout()
      Me.pnlCabecera.SuspendLayout()
      Me.grpTPago.SuspendLayout()
      Me.grpDocumento.SuspendLayout()
      Me.tabBusqueda.SuspendLayout()
      CType(Me.c1grdBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.grpBusqueda.SuspendLayout()
      Me.grpProveedor.SuspendLayout()
      Me.grpDocumentos.SuspendLayout()
      CType(Me.bnavBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.bnavBusqueda.SuspendLayout()
      Me.acTool.SuspendLayout()
      Me.SuspendLayout()
      '
      'tabMantenimiento
      '
      Me.tabMantenimiento.BackColor = System.Drawing.Color.LightSteelBlue
      Me.tabMantenimiento.Dock = System.Windows.Forms.DockStyle.Fill
      Me.tabMantenimiento.Location = New System.Drawing.Point(0, 40)
      Me.tabMantenimiento.MediaPlayerDockSides = False
      Me.tabMantenimiento.Name = "tabMantenimiento"
      Me.tabMantenimiento.OfficeDockSides = False
      Me.tabMantenimiento.SelectedIndex = 1
      Me.tabMantenimiento.ShowDropSelect = False
      Me.tabMantenimiento.Size = New System.Drawing.Size(852, 470)
      Me.tabMantenimiento.TabIndex = 0
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
      Me.tabDatos.Size = New System.Drawing.Size(850, 445)
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
      Me.pnlDatos.Size = New System.Drawing.Size(850, 445)
      Me.pnlDatos.TabIndex = 1
      '
      'pnlDetalle
      '
      Me.pnlDetalle.Controls.Add(Me.c1grdDetalle)
      Me.pnlDetalle.Controls.Add(Me.bnavProductos)
      Me.pnlDetalle.Controls.Add(Me.pnlPie)
      Me.pnlDetalle.Dock = System.Windows.Forms.DockStyle.Fill
      Me.pnlDetalle.Location = New System.Drawing.Point(0, 133)
      Me.pnlDetalle.Name = "pnlDetalle"
      Me.pnlDetalle.Size = New System.Drawing.Size(850, 312)
      Me.pnlDetalle.TabIndex = 69
      '
      'c1grdDetalle
      '
      Me.c1grdDetalle.BackColor = System.Drawing.Color.White
      Me.c1grdDetalle.ColumnInfo = resources.GetString("c1grdDetalle.ColumnInfo")
      Me.c1grdDetalle.Dock = System.Windows.Forms.DockStyle.Fill
      Me.c1grdDetalle.Location = New System.Drawing.Point(0, 0)
      Me.c1grdDetalle.Name = "c1grdDetalle"
      Me.c1grdDetalle.Rows.Count = 5
      Me.c1grdDetalle.Rows.DefaultSize = 20
      Me.c1grdDetalle.Size = New System.Drawing.Size(850, 240)
      Me.c1grdDetalle.StyleInfo = resources.GetString("c1grdDetalle.StyleInfo")
      Me.c1grdDetalle.TabIndex = 8
      '
      'bnavProductos
      '
      Me.bnavProductos.AddNewItem = Me.ToolStripButton1
      Me.bnavProductos.CountItem = Me.ToolStripLabel1
      Me.bnavProductos.DeleteItem = Me.ToolStripButton2
      Me.bnavProductos.Dock = System.Windows.Forms.DockStyle.Bottom
      Me.bnavProductos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripSeparator1, Me.ToolStripTextBox1, Me.ToolStripLabel1, Me.ToolStripSeparator2, Me.ToolStripButton5, Me.ToolStripButton6, Me.ToolStripSeparator3, Me.ToolStripButton1, Me.ToolStripButton2, Me.tsbtnAgregarServicio, Me.tsbtnModificarServicio})
      Me.bnavProductos.Location = New System.Drawing.Point(0, 240)
      Me.bnavProductos.MoveFirstItem = Me.ToolStripButton3
      Me.bnavProductos.MoveLastItem = Me.ToolStripButton6
      Me.bnavProductos.MoveNextItem = Me.ToolStripButton5
      Me.bnavProductos.MovePreviousItem = Me.ToolStripButton4
      Me.bnavProductos.Name = "bnavProductos"
      Me.bnavProductos.PositionItem = Me.ToolStripTextBox1
      Me.bnavProductos.Size = New System.Drawing.Size(850, 25)
      Me.bnavProductos.TabIndex = 9
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
      'tsbtnAgregarServicio
      '
      Me.tsbtnAgregarServicio.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
      Me.tsbtnAgregarServicio.Image = CType(resources.GetObject("tsbtnAgregarServicio.Image"), System.Drawing.Image)
      Me.tsbtnAgregarServicio.Name = "tsbtnAgregarServicio"
      Me.tsbtnAgregarServicio.RightToLeftAutoMirrorImage = True
      Me.tsbtnAgregarServicio.Size = New System.Drawing.Size(113, 22)
      Me.tsbtnAgregarServicio.Text = "Agregar Servicio"
      Me.tsbtnAgregarServicio.Visible = False
      '
      'tsbtnModificarServicio
      '
      Me.tsbtnModificarServicio.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
      Me.tsbtnModificarServicio.Image = Global.ACPLogistica.My.Resources.Resources.Edit_16x16
      Me.tsbtnModificarServicio.Name = "tsbtnModificarServicio"
      Me.tsbtnModificarServicio.RightToLeftAutoMirrorImage = True
      Me.tsbtnModificarServicio.Size = New System.Drawing.Size(122, 22)
      Me.tsbtnModificarServicio.Text = "Modificar Servicio"
      Me.tsbtnModificarServicio.ToolTipText = "Modificar Servicio"
      Me.tsbtnModificarServicio.Visible = False
      '
      'pnlPie
      '
      Me.pnlPie.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(145, Byte), Integer))
      Me.pnlPie.Controls.Add(Me.Label13)
      Me.pnlPie.Controls.Add(Me.actxnTotal)
      Me.pnlPie.Controls.Add(Me.btnCalcular)
      Me.pnlPie.Dock = System.Windows.Forms.DockStyle.Bottom
      Me.pnlPie.Location = New System.Drawing.Point(0, 265)
      Me.pnlPie.Name = "pnlPie"
      Me.pnlPie.Size = New System.Drawing.Size(850, 47)
      Me.pnlPie.TabIndex = 10
      '
      'Label13
      '
      Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.Label13.AutoSize = True
      Me.Label13.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label13.ForeColor = System.Drawing.Color.White
      Me.Label13.Location = New System.Drawing.Point(468, 12)
      Me.Label13.Name = "Label13"
      Me.Label13.Size = New System.Drawing.Size(158, 23)
      Me.Label13.TabIndex = 1
      Me.Label13.Text = "Total Descuento :"
      '
      'actxnTotal
      '
      Me.actxnTotal.ACEnteros = 9
      Me.actxnTotal.ACEstandar = ACControles.ACEstandaresFormato.ACDecimal
      Me.actxnTotal.ACNegativo = True
      Me.actxnTotal.ACValue = New Decimal(New Integer() {0, 0, 0, 131072})
      Me.actxnTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.actxnTotal.Font = New System.Drawing.Font("Courier New", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.actxnTotal.Location = New System.Drawing.Point(645, 8)
      Me.actxnTotal.MaxLength = 12
      Me.actxnTotal.Name = "actxnTotal"
      Me.actxnTotal.ReadOnly = True
      Me.actxnTotal.Size = New System.Drawing.Size(177, 31)
      Me.actxnTotal.TabIndex = 2
      Me.actxnTotal.Tag = ""
      Me.actxnTotal.Text = "0.00"
      Me.actxnTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
      '
      'btnCalcular
      '
      Me.btnCalcular.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
      Me.btnCalcular.Image = Global.ACPLogistica.My.Resources.Resources.Calculator_red_32x32
      Me.btnCalcular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
      Me.btnCalcular.Location = New System.Drawing.Point(17, 2)
      Me.btnCalcular.Name = "btnCalcular"
      Me.btnCalcular.Size = New System.Drawing.Size(105, 42)
      Me.btnCalcular.TabIndex = 0
      Me.btnCalcular.Text = "Calcular"
      Me.btnCalcular.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.ToolTip.SetToolTip(Me.btnCalcular, "Calcular el Flete en el Precio del Producto")
      Me.btnCalcular.UseVisualStyleBackColor = True
      '
      'pnlCabecera
      '
      Me.pnlCabecera.Controls.Add(Me.Label25)
      Me.pnlCabecera.Controls.Add(Me.actxnTipoCambio)
      Me.pnlCabecera.Controls.Add(Me.Label15)
      Me.pnlCabecera.Controls.Add(Me.cmbMoneda)
      Me.pnlCabecera.Controls.Add(Me.grpTPago)
      Me.pnlCabecera.Controls.Add(Me.Label4)
      Me.pnlCabecera.Controls.Add(Me.dtpFecha)
      Me.pnlCabecera.Controls.Add(Me.grpDocumento)
      Me.pnlCabecera.Controls.Add(Me.Label3)
      Me.pnlCabecera.Controls.Add(Me.Label1)
      Me.pnlCabecera.Controls.Add(Me.Label2)
      Me.pnlCabecera.Controls.Add(Me.txtProvNombres)
      Me.pnlCabecera.Controls.Add(Me.txtProvCodigo)
      Me.pnlCabecera.Dock = System.Windows.Forms.DockStyle.Top
      Me.pnlCabecera.Location = New System.Drawing.Point(0, 0)
      Me.pnlCabecera.Name = "pnlCabecera"
      Me.pnlCabecera.Size = New System.Drawing.Size(850, 133)
      Me.pnlCabecera.TabIndex = 68
      '
      'Label25
      '
      Me.Label25.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.Label25.AutoSize = True
      Me.Label25.Location = New System.Drawing.Point(419, 100)
      Me.Label25.Name = "Label25"
      Me.Label25.Size = New System.Drawing.Size(82, 15)
      Me.Label25.TabIndex = 10
      Me.Label25.Text = "Tipo Cambio :"
      '
      'actxnTipoCambio
      '
      Me.actxnTipoCambio.ACEnteros = 9
      Me.actxnTipoCambio.ACEstandar = ACControles.ACEstandaresFormato.ACDecimal
      Me.actxnTipoCambio.ACNegativo = True
      Me.actxnTipoCambio.ACValue = New Decimal(New Integer() {0, 0, 0, 131072})
      Me.actxnTipoCambio.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.actxnTipoCambio.Location = New System.Drawing.Point(506, 96)
      Me.actxnTipoCambio.MaxLength = 12
      Me.actxnTipoCambio.Name = "actxnTipoCambio"
      Me.actxnTipoCambio.ReadOnly = True
      Me.actxnTipoCambio.Size = New System.Drawing.Size(136, 23)
      Me.actxnTipoCambio.TabIndex = 11
      Me.actxnTipoCambio.Tag = "EVO"
      Me.actxnTipoCambio.Text = "0.00"
      Me.actxnTipoCambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
      '
      'Label15
      '
      Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.Label15.AutoSize = True
      Me.Label15.Location = New System.Drawing.Point(444, 75)
      Me.Label15.Name = "Label15"
      Me.Label15.Size = New System.Drawing.Size(57, 15)
      Me.Label15.TabIndex = 8
      Me.Label15.Text = "Moneda :"
      '
      'cmbMoneda
      '
      Me.cmbMoneda.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.cmbMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.cmbMoneda.FormattingEnabled = True
      Me.cmbMoneda.Location = New System.Drawing.Point(506, 71)
      Me.cmbMoneda.Name = "cmbMoneda"
      Me.cmbMoneda.Size = New System.Drawing.Size(136, 23)
      Me.cmbMoneda.TabIndex = 9
      Me.cmbMoneda.Tag = "ECO"
      '
      'grpTPago
      '
      Me.grpTPago.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.grpTPago.Controls.Add(Me.cmbTipoPago)
      Me.grpTPago.Controls.Add(Me.Label27)
      Me.grpTPago.Controls.Add(Me.Label14)
      Me.grpTPago.Controls.Add(Me.dtpFecPago)
      Me.grpTPago.Location = New System.Drawing.Point(648, 57)
      Me.grpTPago.Name = "grpTPago"
      Me.grpTPago.Size = New System.Drawing.Size(175, 67)
      Me.grpTPago.TabIndex = 12
      Me.grpTPago.TabStop = False
      Me.grpTPago.Text = "Pago"
      '
      'cmbTipoPago
      '
      Me.cmbTipoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.cmbTipoPago.FormattingEnabled = True
      Me.cmbTipoPago.Location = New System.Drawing.Point(58, 14)
      Me.cmbTipoPago.Name = "cmbTipoPago"
      Me.cmbTipoPago.Size = New System.Drawing.Size(106, 23)
      Me.cmbTipoPago.TabIndex = 1
      Me.cmbTipoPago.Tag = "ECO"
      '
      'Label27
      '
      Me.Label27.AutoSize = True
      Me.Label27.Location = New System.Drawing.Point(18, 18)
      Me.Label27.Name = "Label27"
      Me.Label27.Size = New System.Drawing.Size(37, 15)
      Me.Label27.TabIndex = 0
      Me.Label27.Text = "Tipo :"
      '
      'Label14
      '
      Me.Label14.AutoSize = True
      Me.Label14.Location = New System.Drawing.Point(9, 43)
      Me.Label14.Name = "Label14"
      Me.Label14.Size = New System.Drawing.Size(44, 15)
      Me.Label14.TabIndex = 2
      Me.Label14.Text = "Fecha :"
      '
      'dtpFecPago
      '
      Me.dtpFecPago.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
      Me.dtpFecPago.Location = New System.Drawing.Point(57, 39)
      Me.dtpFecPago.Name = "dtpFecPago"
      Me.dtpFecPago.Size = New System.Drawing.Size(107, 23)
      Me.dtpFecPago.TabIndex = 3
      '
      'Label4
      '
      Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.Label4.AutoSize = True
      Me.Label4.Location = New System.Drawing.Point(650, 9)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(44, 15)
      Me.Label4.TabIndex = 5
      Me.Label4.Text = "Fecha :"
      '
      'dtpFecha
      '
      Me.dtpFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
      Me.dtpFecha.Location = New System.Drawing.Point(702, 5)
      Me.dtpFecha.Name = "dtpFecha"
      Me.dtpFecha.Size = New System.Drawing.Size(121, 23)
      Me.dtpFecha.TabIndex = 6
      '
      'grpDocumento
      '
      Me.grpDocumento.Controls.Add(Me.txtSerie)
      Me.grpDocumento.Controls.Add(Me.actxnNumero)
      Me.grpDocumento.Controls.Add(Me.Label19)
      Me.grpDocumento.Controls.Add(Me.Label23)
      Me.grpDocumento.Controls.Add(Me.Label21)
      Me.grpDocumento.Controls.Add(Me.cmbDocumento)
      Me.grpDocumento.Location = New System.Drawing.Point(11, 59)
      Me.grpDocumento.Name = "grpDocumento"
      Me.grpDocumento.Size = New System.Drawing.Size(402, 57)
      Me.grpDocumento.TabIndex = 7
      Me.grpDocumento.TabStop = False
      '
      'txtSerie
      '
      Me.txtSerie.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtSerie.Location = New System.Drawing.Point(244, 30)
      Me.txtSerie.MaxLength = 3
      Me.txtSerie.Name = "txtSerie"
      Me.txtSerie.Size = New System.Drawing.Size(45, 23)
      Me.txtSerie.TabIndex = 3
      Me.txtSerie.Tag = "EVO"
      '
      'actxnNumero
      '
      Me.actxnNumero.ACEnteros = 8
      Me.actxnNumero.ACEstandar = ACControles.ACEstandaresFormato.ACNinguno
      Me.actxnNumero.ACFormato = "#######0"
      Me.actxnNumero.ACNegativo = True
      Me.actxnNumero.ACValue = New Decimal(New Integer() {0, 0, 0, 131072})
      Me.actxnNumero.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.actxnNumero.Location = New System.Drawing.Point(295, 30)
      Me.actxnNumero.MaxLength = 12
      Me.actxnNumero.Name = "actxnNumero"
      Me.actxnNumero.Size = New System.Drawing.Size(100, 23)
      Me.actxnNumero.TabIndex = 5
      Me.actxnNumero.Tag = "EVO"
      Me.actxnNumero.Text = "0"
      Me.actxnNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
      '
      'Label19
      '
      Me.Label19.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.Label19.AutoSize = True
      Me.Label19.Location = New System.Drawing.Point(305, 13)
      Me.Label19.Name = "Label19"
      Me.Label19.Size = New System.Drawing.Size(51, 15)
      Me.Label19.TabIndex = 4
      Me.Label19.Text = "Numero"
      '
      'Label23
      '
      Me.Label23.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.Label23.AutoSize = True
      Me.Label23.Location = New System.Drawing.Point(251, 13)
      Me.Label23.Name = "Label23"
      Me.Label23.Size = New System.Drawing.Size(32, 15)
      Me.Label23.TabIndex = 2
      Me.Label23.Text = "Serie"
      '
      'Label21
      '
      Me.Label21.AutoSize = True
      Me.Label21.Location = New System.Drawing.Point(10, 13)
      Me.Label21.Name = "Label21"
      Me.Label21.Size = New System.Drawing.Size(70, 15)
      Me.Label21.TabIndex = 0
      Me.Label21.Text = "Documento"
      '
      'cmbDocumento
      '
      Me.cmbDocumento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.cmbDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.cmbDocumento.FormattingEnabled = True
      Me.cmbDocumento.Location = New System.Drawing.Point(8, 30)
      Me.cmbDocumento.Name = "cmbDocumento"
      Me.cmbDocumento.Size = New System.Drawing.Size(228, 23)
      Me.cmbDocumento.TabIndex = 1
      Me.cmbDocumento.Tag = "O"
      '
      'Label3
      '
      Me.Label3.AutoSize = True
      Me.Label3.Location = New System.Drawing.Point(220, 9)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(73, 15)
      Me.Label3.TabIndex = 3
      Me.Label3.Text = "Razon Social"
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.Location = New System.Drawing.Point(92, 9)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(46, 15)
      Me.Label1.TabIndex = 1
      Me.Label1.Text = "Codigo"
      '
      'Label2
      '
      Me.Label2.AutoSize = True
      Me.Label2.Location = New System.Drawing.Point(15, 35)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(67, 15)
      Me.Label2.TabIndex = 0
      Me.Label2.Text = "Proveedor :"
      '
      'txtProvNombres
      '
      Me.txtProvNombres.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtProvNombres.Location = New System.Drawing.Point(212, 31)
      Me.txtProvNombres.Name = "txtProvNombres"
      Me.txtProvNombres.ReadOnly = True
      Me.txtProvNombres.Size = New System.Drawing.Size(611, 23)
      Me.txtProvNombres.TabIndex = 4
      '
      'txtProvCodigo
      '
      Me.txtProvCodigo.Location = New System.Drawing.Point(85, 31)
      Me.txtProvCodigo.Name = "txtProvCodigo"
      Me.txtProvCodigo.ReadOnly = True
      Me.txtProvCodigo.Size = New System.Drawing.Size(121, 23)
      Me.txtProvCodigo.TabIndex = 2
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
      Me.tabBusqueda.Size = New System.Drawing.Size(850, 445)
      Me.tabBusqueda.TabIndex = 0
      Me.tabBusqueda.Title = "Busqueda"
      Me.tabBusqueda.ToolTip = "Busqueda"
      '
      'c1grdBusqueda
      '
      Me.c1grdBusqueda.ColumnInfo = "2,1,0,0,0,100,Columns:0{Width:25;}" & Global.Microsoft.VisualBasic.ChrW(9)
      Me.c1grdBusqueda.Dock = System.Windows.Forms.DockStyle.Fill
      Me.c1grdBusqueda.Location = New System.Drawing.Point(0, 119)
      Me.c1grdBusqueda.Name = "c1grdBusqueda"
      Me.c1grdBusqueda.Rows.Count = 2
      Me.c1grdBusqueda.Rows.DefaultSize = 20
      Me.c1grdBusqueda.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
      Me.c1grdBusqueda.Size = New System.Drawing.Size(850, 301)
      Me.c1grdBusqueda.StyleInfo = resources.GetString("c1grdBusqueda.StyleInfo")
      Me.c1grdBusqueda.TabIndex = 2
      '
      'grpBusqueda
      '
      Me.grpBusqueda.Controls.Add(Me.btnConsultar)
      Me.grpBusqueda.Controls.Add(Me.rbtnProveedor)
      Me.grpBusqueda.Controls.Add(Me.acFecha)
      Me.grpBusqueda.Controls.Add(Me.grpProveedor)
      Me.grpBusqueda.Controls.Add(Me.rbtnDocVenta)
      Me.grpBusqueda.Controls.Add(Me.grpDocumentos)
      Me.grpBusqueda.Dock = System.Windows.Forms.DockStyle.Top
      Me.grpBusqueda.Location = New System.Drawing.Point(0, 0)
      Me.grpBusqueda.Name = "grpBusqueda"
      Me.grpBusqueda.Size = New System.Drawing.Size(850, 119)
      Me.grpBusqueda.TabIndex = 0
      Me.grpBusqueda.TabStop = False
      Me.grpBusqueda.Text = "Opciones de Busqueda"
      '
      'btnConsultar
      '
      Me.btnConsultar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.btnConsultar.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
      Me.btnConsultar.Image = Global.ACPLogistica.My.Resources.Resources.Search_files_32x32
      Me.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
      Me.btnConsultar.Location = New System.Drawing.Point(740, 63)
      Me.btnConsultar.Name = "btnConsultar"
      Me.btnConsultar.Size = New System.Drawing.Size(99, 42)
      Me.btnConsultar.TabIndex = 29
      Me.btnConsultar.Text = "Consultar"
      Me.btnConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.btnConsultar.UseVisualStyleBackColor = True
      '
      'rbtnProveedor
      '
      Me.rbtnProveedor.AutoSize = True
      Me.rbtnProveedor.Checked = True
      Me.rbtnProveedor.Location = New System.Drawing.Point(19, 46)
      Me.rbtnProveedor.Name = "rbtnProveedor"
      Me.rbtnProveedor.Size = New System.Drawing.Size(79, 19)
      Me.rbtnProveedor.TabIndex = 12
      Me.rbtnProveedor.TabStop = True
      Me.rbtnProveedor.Text = "Proveedor"
      Me.rbtnProveedor.UseVisualStyleBackColor = True
      '
      'acFecha
      '
      Me.acFecha.ACFecha_A = New Date(2012, 11, 29, 16, 32, 12, 580)
      Me.acFecha.ACFecha_De = New Date(2012, 11, 29, 16, 32, 12, 578)
      Me.acFecha.ACFechaObligatoria = True
      Me.acFecha.ACFormatoControl = ACControles.ACFecha.ACTipoFormatoControl.Horizontal
      Me.acFecha.ACHoyChecked = False
      Me.acFecha.ACIncrementoFecha_A = ACControles.ACFecha.ACTipoIncremento.Dia
      Me.acFecha.ACIncrementoFecha_De = ACControles.ACFecha.ACTipoIncremento.Dia
      Me.acFecha.ACIntervalos = ACControles.ACFecha.ACIntervalo.Ninguno
      Me.acFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.acFecha.Location = New System.Drawing.Point(514, 0)
      Me.acFecha.MaximumSize = New System.Drawing.Size(337, 43)
      Me.acFecha.MinimumSize = New System.Drawing.Size(337, 43)
      Me.acFecha.Name = "acFecha"
      Me.acFecha.Size = New System.Drawing.Size(337, 43)
      Me.acFecha.TabIndex = 2
      Me.acFecha.TabStop = False
      '
      'grpProveedor
      '
      Me.grpProveedor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.grpProveedor.Controls.Add(Me.rbtnBCodigo)
      Me.grpProveedor.Controls.Add(Me.txtBusqueda)
      Me.grpProveedor.Controls.Add(Me.rbtnBRazSocial)
      Me.grpProveedor.Controls.Add(Me.rbtnBNomComercial)
      Me.grpProveedor.Location = New System.Drawing.Point(6, 48)
      Me.grpProveedor.Name = "grpProveedor"
      Me.grpProveedor.Size = New System.Drawing.Size(440, 63)
      Me.grpProveedor.TabIndex = 0
      Me.grpProveedor.TabStop = False
      '
      'rbtnBCodigo
      '
      Me.rbtnBCodigo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.rbtnBCodigo.AutoSize = True
      Me.rbtnBCodigo.Location = New System.Drawing.Point(146, 15)
      Me.rbtnBCodigo.Name = "rbtnBCodigo"
      Me.rbtnBCodigo.Size = New System.Drawing.Size(64, 19)
      Me.rbtnBCodigo.TabIndex = 3
      Me.rbtnBCodigo.Text = "Codigo"
      Me.rbtnBCodigo.UseVisualStyleBackColor = True
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
      Me.txtBusqueda.Size = New System.Drawing.Size(421, 23)
      Me.txtBusqueda.TabIndex = 0
      '
      'rbtnBRazSocial
      '
      Me.rbtnBRazSocial.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.rbtnBRazSocial.AutoSize = True
      Me.rbtnBRazSocial.Checked = True
      Me.rbtnBRazSocial.Location = New System.Drawing.Point(214, 15)
      Me.rbtnBRazSocial.Name = "rbtnBRazSocial"
      Me.rbtnBRazSocial.Size = New System.Drawing.Size(91, 19)
      Me.rbtnBRazSocial.TabIndex = 1
      Me.rbtnBRazSocial.TabStop = True
      Me.rbtnBRazSocial.Text = "Razon Social"
      Me.rbtnBRazSocial.UseVisualStyleBackColor = True
      '
      'rbtnBNomComercial
      '
      Me.rbtnBNomComercial.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.rbtnBNomComercial.AutoSize = True
      Me.rbtnBNomComercial.Location = New System.Drawing.Point(300, 15)
      Me.rbtnBNomComercial.Name = "rbtnBNomComercial"
      Me.rbtnBNomComercial.Size = New System.Drawing.Size(126, 19)
      Me.rbtnBNomComercial.TabIndex = 2
      Me.rbtnBNomComercial.Text = "Nombre Comercial"
      Me.rbtnBNomComercial.UseVisualStyleBackColor = True
      '
      'rbtnDocVenta
      '
      Me.rbtnDocVenta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.rbtnDocVenta.AutoSize = True
      Me.rbtnDocVenta.Location = New System.Drawing.Point(476, 45)
      Me.rbtnDocVenta.Name = "rbtnDocVenta"
      Me.rbtnDocVenta.Size = New System.Drawing.Size(137, 19)
      Me.rbtnDocVenta.TabIndex = 11
      Me.rbtnDocVenta.Text = "Documento de Venta"
      Me.rbtnDocVenta.UseVisualStyleBackColor = True
      '
      'grpDocumentos
      '
      Me.grpDocumentos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.grpDocumentos.Controls.Add(Me.txtCSerie)
      Me.grpDocumentos.Controls.Add(Me.Label18)
      Me.grpDocumentos.Controls.Add(Me.Label22)
      Me.grpDocumentos.Controls.Add(Me.Label24)
      Me.grpDocumentos.Controls.Add(Me.cmbTipoDocumento)
      Me.grpDocumentos.Controls.Add(Me.txtBusNumero)
      Me.grpDocumentos.Location = New System.Drawing.Point(452, 48)
      Me.grpDocumentos.Name = "grpDocumentos"
      Me.grpDocumentos.Size = New System.Drawing.Size(278, 63)
      Me.grpDocumentos.TabIndex = 14
      Me.grpDocumentos.TabStop = False
      '
      'txtCSerie
      '
      Me.txtCSerie.ACDecimales = 0
      Me.txtCSerie.ACEstandar = ACControles.ACEstandaresFormato.ACSoloNumeros
      Me.txtCSerie.ACFormato = "#############"
      Me.txtCSerie.ACNegativo = True
      Me.txtCSerie.ACValue = New Decimal(New Integer() {0, 0, 0, 131072})
      Me.txtCSerie.Location = New System.Drawing.Point(119, 36)
      Me.txtCSerie.MaxLength = 4
      Me.txtCSerie.Name = "txtCSerie"
      Me.txtCSerie.Size = New System.Drawing.Size(48, 23)
      Me.txtCSerie.TabIndex = 3
      Me.txtCSerie.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
      '
      'Label18
      '
      Me.Label18.AutoSize = True
      Me.Label18.Location = New System.Drawing.Point(180, 17)
      Me.Label18.Name = "Label18"
      Me.Label18.Size = New System.Drawing.Size(51, 15)
      Me.Label18.TabIndex = 4
      Me.Label18.Text = "Numero"
      '
      'Label22
      '
      Me.Label22.AutoSize = True
      Me.Label22.Location = New System.Drawing.Point(120, 17)
      Me.Label22.Name = "Label22"
      Me.Label22.Size = New System.Drawing.Size(32, 15)
      Me.Label22.TabIndex = 2
      Me.Label22.Text = "Serie"
      '
      'Label24
      '
      Me.Label24.AutoSize = True
      Me.Label24.Location = New System.Drawing.Point(11, 17)
      Me.Label24.Name = "Label24"
      Me.Label24.Size = New System.Drawing.Size(58, 15)
      Me.Label24.TabIndex = 0
      Me.Label24.Text = "Tipo Doc."
      '
      'cmbTipoDocumento
      '
      Me.cmbTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.cmbTipoDocumento.DropDownWidth = 350
      Me.cmbTipoDocumento.FormattingEnabled = True
      Me.cmbTipoDocumento.Location = New System.Drawing.Point(6, 36)
      Me.cmbTipoDocumento.Name = "cmbTipoDocumento"
      Me.cmbTipoDocumento.Size = New System.Drawing.Size(107, 23)
      Me.cmbTipoDocumento.TabIndex = 1
      '
      'txtBusNumero
      '
      Me.txtBusNumero.ACActivarAyudaAuto = False
      Me.txtBusNumero.ACLongitudAceptada = 0
      Me.txtBusNumero.ACTipo = ACControles.ACTextBoxAyuda.TipoTextBoxAyuda.Numerico
      Me.txtBusNumero.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtBusNumero.Location = New System.Drawing.Point(173, 36)
      Me.txtBusNumero.MaxLength = 9
      Me.txtBusNumero.Name = "txtBusNumero"
      Me.txtBusNumero.Size = New System.Drawing.Size(91, 23)
      Me.txtBusNumero.TabIndex = 5
      '
      'bnavBusqueda
      '
      Me.bnavBusqueda.AddNewItem = Me.BindingNavigatorAddNewItem
      Me.bnavBusqueda.CountItem = Me.BindingNavigatorCountItem
      Me.bnavBusqueda.DeleteItem = Me.BindingNavigatorDeleteItem
      Me.bnavBusqueda.Dock = System.Windows.Forms.DockStyle.Bottom
      Me.bnavBusqueda.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem})
      Me.bnavBusqueda.Location = New System.Drawing.Point(0, 420)
      Me.bnavBusqueda.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
      Me.bnavBusqueda.MoveLastItem = Me.BindingNavigatorMoveLastItem
      Me.bnavBusqueda.MoveNextItem = Me.BindingNavigatorMoveNextItem
      Me.bnavBusqueda.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
      Me.bnavBusqueda.Name = "bnavBusqueda"
      Me.bnavBusqueda.PositionItem = Me.BindingNavigatorPositionItem
      Me.bnavBusqueda.Size = New System.Drawing.Size(850, 25)
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
      'acpnlTitulo
      '
      Me.acpnlTitulo.ACCaption = "Nota de Credito por Cuota Mensual"
      Me.acpnlTitulo.Dock = System.Windows.Forms.DockStyle.Top
      Me.acpnlTitulo.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
      Me.acpnlTitulo.Location = New System.Drawing.Point(0, 0)
      Me.acpnlTitulo.Name = "acpnlTitulo"
      Me.acpnlTitulo.Size = New System.Drawing.Size(852, 40)
      Me.acpnlTitulo.TabIndex = 1
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
      Me.acTool.ACBtnModificarEnabled = False
      Me.acTool.ACBtnModificarVisible = False
      Me.acTool.ACBtnNuevoEnabled = False
      Me.acTool.ACBtnNuevoVisible = False
      Me.acTool.ACBtnRehusarEnabled = False
      Me.acTool.ACBtnRehusarVisible = False
      Me.acTool.ACBtnReporteEnabled = False
      Me.acTool.ACBtnReporteVisible = False
      Me.acTool.ACBtnSalirText = "&Salir"
      Me.acTool.ACBtnVolverEnabled = False
      Me.acTool.ACBtnVolverVisible = False
      Me.acTool.ACTipoToolBar = ACControles.ACToolBarMantHorizontalNew.tipoToolBar.ToolSalir
      Me.acTool.Dock = System.Windows.Forms.DockStyle.Bottom
      Me.acTool.Font = New System.Drawing.Font("Tahoma", 9.5!)
      Me.acTool.ImageScalingSize = New System.Drawing.Size(32, 32)
      Me.acTool.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.acbtnCuota})
      Me.acTool.Location = New System.Drawing.Point(0, 510)
      Me.acTool.Name = "acTool"
      Me.acTool.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
      Me.acTool.Size = New System.Drawing.Size(852, 56)
      Me.acTool.TabIndex = 15
      Me.acTool.Text = "AcToolBarMantHorizontalNew1"
      '
      'acbtnCuota
      '
      Me.acbtnCuota.AutoSize = False
      Me.acbtnCuota.Image = Global.ACPLogistica.My.Resources.Resources.Check_Proces_32x32
      Me.acbtnCuota.ImageAlign = System.Drawing.ContentAlignment.TopCenter
      Me.acbtnCuota.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
      Me.acbtnCuota.ImageTransparentColor = System.Drawing.Color.Magenta
      Me.acbtnCuota.Name = "tsbBoton"
      Me.acbtnCuota.Size = New System.Drawing.Size(75, 53)
      Me.acbtnCuota.Text = "Asi&gnar"
      Me.acbtnCuota.TextAlign = System.Drawing.ContentAlignment.BottomCenter
      Me.acbtnCuota.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
      Me.acbtnCuota.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
      '
      'AccmsSeleccionarC1
      '
      Me.AccmsSeleccionarC1.Name = "cmsOpciones"
      Me.AccmsSeleccionarC1.Size = New System.Drawing.Size(209, 92)
      '
      'TControlDescuentos
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(852, 566)
      Me.Controls.Add(Me.tabMantenimiento)
      Me.Controls.Add(Me.acpnlTitulo)
      Me.Controls.Add(Me.acTool)
      Me.MinimumSize = New System.Drawing.Size(860, 500)
      Me.Name = "TControlDescuentos"
      Me.Text = "Nota de Credito por Cuota Mensual"
      Me.tabMantenimiento.ResumeLayout(False)
      Me.tabDatos.ResumeLayout(False)
      Me.pnlDatos.ResumeLayout(False)
      Me.pnlDetalle.ResumeLayout(False)
      Me.pnlDetalle.PerformLayout()
      CType(Me.c1grdDetalle, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.bnavProductos, System.ComponentModel.ISupportInitialize).EndInit()
      Me.bnavProductos.ResumeLayout(False)
      Me.bnavProductos.PerformLayout()
      Me.pnlPie.ResumeLayout(False)
      Me.pnlPie.PerformLayout()
      Me.pnlCabecera.ResumeLayout(False)
      Me.pnlCabecera.PerformLayout()
      Me.grpTPago.ResumeLayout(False)
      Me.grpTPago.PerformLayout()
      Me.grpDocumento.ResumeLayout(False)
      Me.grpDocumento.PerformLayout()
      Me.tabBusqueda.ResumeLayout(False)
      Me.tabBusqueda.PerformLayout()
      CType(Me.c1grdBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
      Me.grpBusqueda.ResumeLayout(False)
      Me.grpBusqueda.PerformLayout()
      Me.grpProveedor.ResumeLayout(False)
      Me.grpProveedor.PerformLayout()
      Me.grpDocumentos.ResumeLayout(False)
      Me.grpDocumentos.PerformLayout()
      CType(Me.bnavBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
      Me.bnavBusqueda.ResumeLayout(False)
      Me.bnavBusqueda.PerformLayout()
      Me.acTool.ResumeLayout(False)
      Me.acTool.PerformLayout()
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Private WithEvents tabMantenimiento As Crownwood.DotNetMagic.Controls.TabControl
   Private WithEvents tabDatos As Crownwood.DotNetMagic.Controls.TabPage
   Friend WithEvents pnlDatos As System.Windows.Forms.Panel
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
   Friend WithEvents pnlPie As System.Windows.Forms.Panel
   Friend WithEvents Label13 As System.Windows.Forms.Label
   Friend WithEvents actxnTotal As ACControles.ACTextBoxNumerico
   Friend WithEvents pnlCabecera As System.Windows.Forms.Panel
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Private WithEvents tabBusqueda As Crownwood.DotNetMagic.Controls.TabPage
   Friend WithEvents c1grdBusqueda As C1.Win.C1FlexGrid.C1FlexGrid
   Private WithEvents grpBusqueda As System.Windows.Forms.GroupBox
   Friend WithEvents acFecha As ACControles.ACFecha
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
   Friend WithEvents acTool As ACControles.ACToolBarMantHorizontalNew
   Friend WithEvents btnConsultar As System.Windows.Forms.Button
   Friend WithEvents rbtnProveedor As System.Windows.Forms.RadioButton
   Friend WithEvents grpProveedor As System.Windows.Forms.GroupBox
   Friend WithEvents txtBusqueda As ACControles.ACTextBoxAyuda
   Friend WithEvents rbtnBRazSocial As System.Windows.Forms.RadioButton
   Friend WithEvents rbtnBNomComercial As System.Windows.Forms.RadioButton
   Friend WithEvents rbtnDocVenta As System.Windows.Forms.RadioButton
   Friend WithEvents grpDocumentos As System.Windows.Forms.GroupBox
   Friend WithEvents Label18 As System.Windows.Forms.Label
   Friend WithEvents Label22 As System.Windows.Forms.Label
   Friend WithEvents Label24 As System.Windows.Forms.Label
   Friend WithEvents cmbTipoDocumento As System.Windows.Forms.ComboBox
   Friend WithEvents txtBusNumero As ACControles.ACTextBoxAyuda
   Friend WithEvents acbtnCuota As ACControles.ACToolStripButton
   Friend WithEvents txtProvNombres As System.Windows.Forms.TextBox
   Friend WithEvents txtProvCodigo As System.Windows.Forms.TextBox
   Friend WithEvents btnCalcular As System.Windows.Forms.Button
   Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
   Friend WithEvents txtCSerie As ACControles.ACTextBoxNumerico
   Friend WithEvents tsbtnAgregarServicio As System.Windows.Forms.ToolStripButton
   Friend WithEvents tsbtnModificarServicio As System.Windows.Forms.ToolStripButton
   Friend WithEvents rbtnBCodigo As System.Windows.Forms.RadioButton
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents grpDocumento As System.Windows.Forms.GroupBox
   Friend WithEvents txtSerie As System.Windows.Forms.TextBox
   Friend WithEvents actxnNumero As ACControles.ACTextBoxNumerico
   Friend WithEvents Label19 As System.Windows.Forms.Label
   Friend WithEvents Label23 As System.Windows.Forms.Label
   Friend WithEvents Label21 As System.Windows.Forms.Label
   Friend WithEvents cmbDocumento As System.Windows.Forms.ComboBox
   Friend WithEvents AccmsSeleccionarC1 As ACControlesC1.ACCMSSeleccionarC1
   Friend WithEvents Label4 As System.Windows.Forms.Label
   Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
   Friend WithEvents Label25 As System.Windows.Forms.Label
   Friend WithEvents actxnTipoCambio As ACControles.ACTextBoxNumerico
   Friend WithEvents Label15 As System.Windows.Forms.Label
   Friend WithEvents cmbMoneda As System.Windows.Forms.ComboBox
   Friend WithEvents grpTPago As System.Windows.Forms.GroupBox
   Friend WithEvents cmbTipoPago As System.Windows.Forms.ComboBox
   Friend WithEvents Label27 As System.Windows.Forms.Label
   Friend WithEvents Label14 As System.Windows.Forms.Label
   Friend WithEvents dtpFecPago As System.Windows.Forms.DateTimePicker
End Class
