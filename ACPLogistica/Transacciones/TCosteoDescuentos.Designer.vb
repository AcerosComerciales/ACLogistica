<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TCosteoDescuentos
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
      Me.components = New System.ComponentModel.Container
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TCosteo))
      Me.tabMantenimiento = New Crownwood.DotNetMagic.Controls.TabControl
      Me.tabDatos = New Crownwood.DotNetMagic.Controls.TabPage
      Me.pnlDatos = New System.Windows.Forms.Panel
      Me.pnlDetalle = New System.Windows.Forms.Panel
      Me.c1grdDetalle = New C1.Win.C1FlexGrid.C1FlexGrid
      Me.bnavProductos = New System.Windows.Forms.BindingNavigator(Me.components)
      Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
      Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
      Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox
      Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
      Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
      Me.pnlPie = New System.Windows.Forms.Panel
      Me.Label4 = New System.Windows.Forms.Label
      Me.actxnImporte = New ACControles.ACTextBoxNumerico
      Me.Label13 = New System.Windows.Forms.Label
      Me.Label16 = New System.Windows.Forms.Label
      Me.actxnIGV = New ACControles.ACTextBoxNumerico
      Me.actxnTotal = New ACControles.ACTextBoxNumerico
      Me.pnlCabecera = New System.Windows.Forms.Panel
      Me.actxaProvNombres = New System.Windows.Forms.TextBox
      Me.actxaProvCodigo = New System.Windows.Forms.TextBox
      Me.Label5 = New System.Windows.Forms.Label
      Me.Label25 = New System.Windows.Forms.Label
      Me.actxnTipoCambio = New ACControles.ACTextBoxNumerico
      Me.Label1 = New System.Windows.Forms.Label
      Me.Label15 = New System.Windows.Forms.Label
      Me.dtpFecha = New System.Windows.Forms.DateTimePicker
      Me.cmbMoneda = New System.Windows.Forms.ComboBox
      Me.Label2 = New System.Windows.Forms.Label
      Me.tabBusqueda = New Crownwood.DotNetMagic.Controls.TabPage
      Me.c1grdBusqueda = New C1.Win.C1FlexGrid.C1FlexGrid
      Me.grpBusqueda = New System.Windows.Forms.GroupBox
      Me.chkTodos = New System.Windows.Forms.CheckBox
      Me.rbtnDatos = New System.Windows.Forms.RadioButton
      Me.acFecha = New ACControles.ACFecha(Me.components)
      Me.grpCliente = New System.Windows.Forms.GroupBox
      Me.txtBusqueda = New ACControles.ACTextBoxAyuda
      Me.rbtnProveedor = New System.Windows.Forms.RadioButton
      Me.rbtnNroOrdenCompra = New System.Windows.Forms.RadioButton
      Me.rbtnDocVenta = New System.Windows.Forms.RadioButton
      Me.grpDocumentos = New System.Windows.Forms.GroupBox
      Me.Label18 = New System.Windows.Forms.Label
      Me.txtCSerie = New System.Windows.Forms.TextBox
      Me.Label22 = New System.Windows.Forms.Label
      Me.Label24 = New System.Windows.Forms.Label
      Me.cmbTipoDocumento = New System.Windows.Forms.ComboBox
      Me.txtBusNumero = New ACControles.ACTextBoxAyuda
      Me.bnavBusqueda = New System.Windows.Forms.BindingNavigator(Me.components)
      Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
      Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
      Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
      Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
      Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
      Me.acpnlTitulo = New ACControles.ACPanelCaption
      Me.acTool = New ACControles.ACToolBarMantHorizontalNew(Me.components)
      Me.actxaOrdCompra = New System.Windows.Forms.TextBox
      Me.grpTPago = New System.Windows.Forms.GroupBox
      Me.AcTextBoxNumerico1 = New ACControles.ACTextBoxNumerico
      Me.Label14 = New System.Windows.Forms.Label
      Me.Label19 = New System.Windows.Forms.Label
      Me.AcTextBoxNumerico2 = New ACControles.ACTextBoxNumerico
      Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
      Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
      Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton
      Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton
      Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton
      Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton
      Me.btnCalcular = New System.Windows.Forms.Button
      Me.btnConsultar = New System.Windows.Forms.Button
      Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
      Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
      Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
      Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
      Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
      Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
      Me.acbtnCostear = New ACControles.ACToolStripButton(Me.components)
      Me.tabMantenimiento.SuspendLayout()
      Me.tabDatos.SuspendLayout()
      Me.pnlDatos.SuspendLayout()
      Me.pnlDetalle.SuspendLayout()
      CType(Me.c1grdDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.bnavProductos, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.bnavProductos.SuspendLayout()
      Me.pnlPie.SuspendLayout()
      Me.pnlCabecera.SuspendLayout()
      Me.tabBusqueda.SuspendLayout()
      CType(Me.c1grdBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.grpBusqueda.SuspendLayout()
      Me.grpCliente.SuspendLayout()
      Me.grpDocumentos.SuspendLayout()
      CType(Me.bnavBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.bnavBusqueda.SuspendLayout()
      Me.acTool.SuspendLayout()
      Me.grpTPago.SuspendLayout()
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
      Me.tabMantenimiento.SelectedIndex = 0
      Me.tabMantenimiento.ShowDropSelect = False
      Me.tabMantenimiento.Size = New System.Drawing.Size(852, 470)
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
      Me.pnlDetalle.Location = New System.Drawing.Point(0, 117)
      Me.pnlDetalle.Name = "pnlDetalle"
      Me.pnlDetalle.Size = New System.Drawing.Size(850, 328)
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
      Me.c1grdDetalle.Rows.DefaultSize = 18
      Me.c1grdDetalle.Size = New System.Drawing.Size(850, 268)
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
      Me.bnavProductos.Location = New System.Drawing.Point(0, 268)
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
      'ToolStripLabel1
      '
      Me.ToolStripLabel1.Name = "ToolStripLabel1"
      Me.ToolStripLabel1.Size = New System.Drawing.Size(36, 22)
      Me.ToolStripLabel1.Text = "of {0}"
      Me.ToolStripLabel1.ToolTipText = "Total number of items"
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
      'ToolStripSeparator3
      '
      Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
      Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
      '
      'pnlPie
      '
      Me.pnlPie.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(145, Byte), Integer))
      Me.pnlPie.Controls.Add(Me.Label4)
      Me.pnlPie.Controls.Add(Me.actxnImporte)
      Me.pnlPie.Controls.Add(Me.Label13)
      Me.pnlPie.Controls.Add(Me.Label16)
      Me.pnlPie.Controls.Add(Me.actxnIGV)
      Me.pnlPie.Controls.Add(Me.actxnTotal)
      Me.pnlPie.Dock = System.Windows.Forms.DockStyle.Bottom
      Me.pnlPie.Location = New System.Drawing.Point(0, 293)
      Me.pnlPie.Name = "pnlPie"
      Me.pnlPie.Size = New System.Drawing.Size(850, 35)
      Me.pnlPie.TabIndex = 10
      '
      'Label4
      '
      Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.Label4.AutoSize = True
      Me.Label4.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
      Me.Label4.ForeColor = System.Drawing.Color.White
      Me.Label4.Location = New System.Drawing.Point(358, 11)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(52, 13)
      Me.Label4.TabIndex = 24
      Me.Label4.Text = "Importe :"
      '
      'actxnImporte
      '
      Me.actxnImporte.ACEnteros = 9
      Me.actxnImporte.ACEstandar = ACControles.ACEstandaresFormato.ACDecimal
      Me.actxnImporte.ACNegativo = True
      Me.actxnImporte.ACValue = New Decimal(New Integer() {0, 0, 0, 131072})
      Me.actxnImporte.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.actxnImporte.Location = New System.Drawing.Point(422, 7)
      Me.actxnImporte.MaxLength = 12
      Me.actxnImporte.Name = "actxnImporte"
      Me.actxnImporte.ReadOnly = True
      Me.actxnImporte.Size = New System.Drawing.Size(94, 21)
      Me.actxnImporte.TabIndex = 25
      Me.actxnImporte.Tag = "EVO"
      Me.actxnImporte.Text = "0.00"
      Me.actxnImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
      '
      'Label13
      '
      Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.Label13.AutoSize = True
      Me.Label13.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
      Me.Label13.ForeColor = System.Drawing.Color.White
      Me.Label13.Location = New System.Drawing.Point(689, 11)
      Me.Label13.Name = "Label13"
      Me.Label13.Size = New System.Drawing.Size(38, 13)
      Me.Label13.TabIndex = 13
      Me.Label13.Text = "Total :"
      '
      'Label16
      '
      Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.Label16.AutoSize = True
      Me.Label16.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
      Me.Label16.ForeColor = System.Drawing.Color.White
      Me.Label16.Location = New System.Drawing.Point(528, 11)
      Me.Label16.Name = "Label16"
      Me.Label16.Size = New System.Drawing.Size(43, 13)
      Me.Label16.TabIndex = 14
      Me.Label16.Text = "I.G.V. :"
      '
      'actxnIGV
      '
      Me.actxnIGV.ACEnteros = 9
      Me.actxnIGV.ACEstandar = ACControles.ACEstandaresFormato.ACDecimal
      Me.actxnIGV.ACNegativo = True
      Me.actxnIGV.ACValue = New Decimal(New Integer() {0, 0, 0, 131072})
      Me.actxnIGV.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.actxnIGV.Location = New System.Drawing.Point(583, 7)
      Me.actxnIGV.MaxLength = 12
      Me.actxnIGV.Name = "actxnIGV"
      Me.actxnIGV.ReadOnly = True
      Me.actxnIGV.Size = New System.Drawing.Size(94, 21)
      Me.actxnIGV.TabIndex = 16
      Me.actxnIGV.Tag = "EVO"
      Me.actxnIGV.Text = "0.00"
      Me.actxnIGV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
      '
      'actxnTotal
      '
      Me.actxnTotal.ACEnteros = 9
      Me.actxnTotal.ACEstandar = ACControles.ACEstandaresFormato.ACDecimal
      Me.actxnTotal.ACNegativo = True
      Me.actxnTotal.ACValue = New Decimal(New Integer() {0, 0, 0, 131072})
      Me.actxnTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.actxnTotal.Location = New System.Drawing.Point(739, 7)
      Me.actxnTotal.MaxLength = 12
      Me.actxnTotal.Name = "actxnTotal"
      Me.actxnTotal.ReadOnly = True
      Me.actxnTotal.Size = New System.Drawing.Size(94, 21)
      Me.actxnTotal.TabIndex = 17
      Me.actxnTotal.Tag = "EVO"
      Me.actxnTotal.Text = "0.00"
      Me.actxnTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
      '
      'pnlCabecera
      '
      Me.pnlCabecera.Controls.Add(Me.btnCalcular)
      Me.pnlCabecera.Controls.Add(Me.actxaOrdCompra)
      Me.pnlCabecera.Controls.Add(Me.actxaProvNombres)
      Me.pnlCabecera.Controls.Add(Me.actxaProvCodigo)
      Me.pnlCabecera.Controls.Add(Me.Label5)
      Me.pnlCabecera.Controls.Add(Me.Label25)
      Me.pnlCabecera.Controls.Add(Me.actxnTipoCambio)
      Me.pnlCabecera.Controls.Add(Me.Label1)
      Me.pnlCabecera.Controls.Add(Me.Label15)
      Me.pnlCabecera.Controls.Add(Me.dtpFecha)
      Me.pnlCabecera.Controls.Add(Me.cmbMoneda)
      Me.pnlCabecera.Controls.Add(Me.Label2)
      Me.pnlCabecera.Controls.Add(Me.grpTPago)
      Me.pnlCabecera.Dock = System.Windows.Forms.DockStyle.Top
      Me.pnlCabecera.Location = New System.Drawing.Point(0, 0)
      Me.pnlCabecera.Name = "pnlCabecera"
      Me.pnlCabecera.Size = New System.Drawing.Size(850, 117)
      Me.pnlCabecera.TabIndex = 68
      '
      'actxaProvNombres
      '
      Me.actxaProvNombres.Location = New System.Drawing.Point(206, 36)
      Me.actxaProvNombres.Name = "actxaProvNombres"
      Me.actxaProvNombres.ReadOnly = True
      Me.actxaProvNombres.Size = New System.Drawing.Size(627, 21)
      Me.actxaProvNombres.TabIndex = 14
      '
      'actxaProvCodigo
      '
      Me.actxaProvCodigo.Location = New System.Drawing.Point(78, 36)
      Me.actxaProvCodigo.Name = "actxaProvCodigo"
      Me.actxaProvCodigo.ReadOnly = True
      Me.actxaProvCodigo.Size = New System.Drawing.Size(121, 21)
      Me.actxaProvCodigo.TabIndex = 13
      '
      'Label5
      '
      Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.Label5.AutoSize = True
      Me.Label5.Location = New System.Drawing.Point(592, 12)
      Me.Label5.Name = "Label5"
      Me.Label5.Size = New System.Drawing.Size(99, 13)
      Me.Label5.TabIndex = 7
      Me.Label5.Text = "Orden de Compra :"
      '
      'Label25
      '
      Me.Label25.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.Label25.AutoSize = True
      Me.Label25.Location = New System.Drawing.Point(658, 94)
      Me.Label25.Name = "Label25"
      Me.Label25.Size = New System.Drawing.Size(72, 13)
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
      Me.actxnTipoCambio.Location = New System.Drawing.Point(733, 90)
      Me.actxnTipoCambio.MaxLength = 12
      Me.actxnTipoCambio.Name = "actxnTipoCambio"
      Me.actxnTipoCambio.ReadOnly = True
      Me.actxnTipoCambio.Size = New System.Drawing.Size(100, 21)
      Me.actxnTipoCambio.TabIndex = 11
      Me.actxnTipoCambio.Tag = "EVO"
      Me.actxnTipoCambio.Text = "0.00"
      Me.actxnTipoCambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.Location = New System.Drawing.Point(26, 12)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(43, 13)
      Me.Label1.TabIndex = 0
      Me.Label1.Text = "Fecha :"
      '
      'Label15
      '
      Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.Label15.AutoSize = True
      Me.Label15.Location = New System.Drawing.Point(591, 66)
      Me.Label15.Name = "Label15"
      Me.Label15.Size = New System.Drawing.Size(52, 13)
      Me.Label15.TabIndex = 8
      Me.Label15.Text = "Moneda :"
      '
      'dtpFecha
      '
      Me.dtpFecha.Enabled = False
      Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
      Me.dtpFecha.Location = New System.Drawing.Point(78, 8)
      Me.dtpFecha.Name = "dtpFecha"
      Me.dtpFecha.Size = New System.Drawing.Size(121, 21)
      Me.dtpFecha.TabIndex = 1
      '
      'cmbMoneda
      '
      Me.cmbMoneda.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.cmbMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.cmbMoneda.FormattingEnabled = True
      Me.cmbMoneda.Location = New System.Drawing.Point(651, 63)
      Me.cmbMoneda.Name = "cmbMoneda"
      Me.cmbMoneda.Size = New System.Drawing.Size(182, 21)
      Me.cmbMoneda.TabIndex = 9
      Me.cmbMoneda.Tag = "ECO"
      '
      'Label2
      '
      Me.Label2.AutoSize = True
      Me.Label2.Location = New System.Drawing.Point(8, 39)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(64, 13)
      Me.Label2.TabIndex = 2
      Me.Label2.Text = "Proveedor :"
      '
      'tabBusqueda
      '
      Me.tabBusqueda.Controls.Add(Me.btnConsultar)
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
      Me.tabBusqueda.Size = New System.Drawing.Size(850, 445)
      Me.tabBusqueda.TabIndex = 5
      Me.tabBusqueda.Title = "Busqueda"
      Me.tabBusqueda.ToolTip = "Busqueda"
      '
      'c1grdBusqueda
      '
      Me.c1grdBusqueda.ColumnInfo = "2,1,0,0,0,90,Columns:0{Width:25;}" & Global.Microsoft.VisualBasic.ChrW(9)
      Me.c1grdBusqueda.Dock = System.Windows.Forms.DockStyle.Fill
      Me.c1grdBusqueda.Location = New System.Drawing.Point(0, 118)
      Me.c1grdBusqueda.Name = "c1grdBusqueda"
      Me.c1grdBusqueda.Rows.Count = 2
      Me.c1grdBusqueda.Rows.DefaultSize = 18
      Me.c1grdBusqueda.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
      Me.c1grdBusqueda.Size = New System.Drawing.Size(850, 302)
      Me.c1grdBusqueda.StyleInfo = resources.GetString("c1grdBusqueda.StyleInfo")
      Me.c1grdBusqueda.TabIndex = 2
      '
      'grpBusqueda
      '
      Me.grpBusqueda.Controls.Add(Me.chkTodos)
      Me.grpBusqueda.Controls.Add(Me.rbtnDatos)
      Me.grpBusqueda.Controls.Add(Me.acFecha)
      Me.grpBusqueda.Controls.Add(Me.grpCliente)
      Me.grpBusqueda.Controls.Add(Me.rbtnDocVenta)
      Me.grpBusqueda.Controls.Add(Me.grpDocumentos)
      Me.grpBusqueda.Dock = System.Windows.Forms.DockStyle.Top
      Me.grpBusqueda.Location = New System.Drawing.Point(0, 0)
      Me.grpBusqueda.Name = "grpBusqueda"
      Me.grpBusqueda.Size = New System.Drawing.Size(850, 118)
      Me.grpBusqueda.TabIndex = 5
      Me.grpBusqueda.TabStop = False
      Me.grpBusqueda.Text = "Opciones de Busqueda"
      '
      'chkTodos
      '
      Me.chkTodos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.chkTodos.AutoSize = True
      Me.chkTodos.Location = New System.Drawing.Point(413, 20)
      Me.chkTodos.Name = "chkTodos"
      Me.chkTodos.Size = New System.Drawing.Size(95, 17)
      Me.chkTodos.TabIndex = 26
      Me.chkTodos.Text = "Mostrar Todos"
      Me.chkTodos.UseVisualStyleBackColor = True
      '
      'rbtnDatos
      '
      Me.rbtnDatos.AutoSize = True
      Me.rbtnDatos.Checked = True
      Me.rbtnDatos.Location = New System.Drawing.Point(19, 46)
      Me.rbtnDatos.Name = "rbtnDatos"
      Me.rbtnDatos.Size = New System.Drawing.Size(167, 17)
      Me.rbtnDatos.TabIndex = 12
      Me.rbtnDatos.TabStop = True
      Me.rbtnDatos.Text = "Datos de la Orden de Compra"
      Me.rbtnDatos.UseVisualStyleBackColor = True
      '
      'acFecha
      '
      Me.acFecha.ACFecha_A = New Date(2010, 11, 12, 12, 14, 19, 828)
      Me.acFecha.ACFecha_De = New Date(2010, 11, 12, 12, 14, 19, 828)
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
      Me.acFecha.TabIndex = 25
      Me.acFecha.TabStop = False
      '
      'grpCliente
      '
      Me.grpCliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.grpCliente.Controls.Add(Me.txtBusqueda)
      Me.grpCliente.Controls.Add(Me.rbtnProveedor)
      Me.grpCliente.Controls.Add(Me.rbtnNroOrdenCompra)
      Me.grpCliente.Location = New System.Drawing.Point(6, 48)
      Me.grpCliente.Name = "grpCliente"
      Me.grpCliente.Size = New System.Drawing.Size(557, 63)
      Me.grpCliente.TabIndex = 13
      Me.grpCliente.TabStop = False
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
      Me.txtBusqueda.Size = New System.Drawing.Size(538, 21)
      Me.txtBusqueda.TabIndex = 0
      '
      'rbtnProveedor
      '
      Me.rbtnProveedor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.rbtnProveedor.AutoSize = True
      Me.rbtnProveedor.Checked = True
      Me.rbtnProveedor.Location = New System.Drawing.Point(320, 15)
      Me.rbtnProveedor.Name = "rbtnProveedor"
      Me.rbtnProveedor.Size = New System.Drawing.Size(75, 17)
      Me.rbtnProveedor.TabIndex = 1
      Me.rbtnProveedor.TabStop = True
      Me.rbtnProveedor.Text = "Proveedor"
      Me.rbtnProveedor.UseVisualStyleBackColor = True
      '
      'rbtnNroOrdenCompra
      '
      Me.rbtnNroOrdenCompra.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.rbtnNroOrdenCompra.AutoSize = True
      Me.rbtnNroOrdenCompra.Location = New System.Drawing.Point(414, 15)
      Me.rbtnNroOrdenCompra.Name = "rbtnNroOrdenCompra"
      Me.rbtnNroOrdenCompra.Size = New System.Drawing.Size(130, 17)
      Me.rbtnNroOrdenCompra.TabIndex = 2
      Me.rbtnNroOrdenCompra.Text = "Nro Orden de Compra"
      Me.rbtnNroOrdenCompra.UseVisualStyleBackColor = True
      '
      'rbtnDocVenta
      '
      Me.rbtnDocVenta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.rbtnDocVenta.AutoSize = True
      Me.rbtnDocVenta.Location = New System.Drawing.Point(583, 45)
      Me.rbtnDocVenta.Name = "rbtnDocVenta"
      Me.rbtnDocVenta.Size = New System.Drawing.Size(125, 17)
      Me.rbtnDocVenta.TabIndex = 11
      Me.rbtnDocVenta.Text = "Documento de Venta"
      Me.rbtnDocVenta.UseVisualStyleBackColor = True
      '
      'grpDocumentos
      '
      Me.grpDocumentos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.grpDocumentos.Controls.Add(Me.Label18)
      Me.grpDocumentos.Controls.Add(Me.txtCSerie)
      Me.grpDocumentos.Controls.Add(Me.Label22)
      Me.grpDocumentos.Controls.Add(Me.Label24)
      Me.grpDocumentos.Controls.Add(Me.cmbTipoDocumento)
      Me.grpDocumentos.Controls.Add(Me.txtBusNumero)
      Me.grpDocumentos.Location = New System.Drawing.Point(569, 48)
      Me.grpDocumentos.Name = "grpDocumentos"
      Me.grpDocumentos.Size = New System.Drawing.Size(278, 63)
      Me.grpDocumentos.TabIndex = 14
      Me.grpDocumentos.TabStop = False
      '
      'Label18
      '
      Me.Label18.AutoSize = True
      Me.Label18.Location = New System.Drawing.Point(180, 17)
      Me.Label18.Name = "Label18"
      Me.Label18.Size = New System.Drawing.Size(44, 13)
      Me.Label18.TabIndex = 11
      Me.Label18.Text = "Numero"
      '
      'txtCSerie
      '
      Me.txtCSerie.Location = New System.Drawing.Point(119, 36)
      Me.txtCSerie.MaxLength = 3
      Me.txtCSerie.Name = "txtCSerie"
      Me.txtCSerie.Size = New System.Drawing.Size(45, 21)
      Me.txtCSerie.TabIndex = 28
      Me.txtCSerie.Tag = "EVO"
      '
      'Label22
      '
      Me.Label22.AutoSize = True
      Me.Label22.Location = New System.Drawing.Point(120, 17)
      Me.Label22.Name = "Label22"
      Me.Label22.Size = New System.Drawing.Size(31, 13)
      Me.Label22.TabIndex = 10
      Me.Label22.Text = "Serie"
      '
      'Label24
      '
      Me.Label24.AutoSize = True
      Me.Label24.Location = New System.Drawing.Point(11, 17)
      Me.Label24.Name = "Label24"
      Me.Label24.Size = New System.Drawing.Size(52, 13)
      Me.Label24.TabIndex = 9
      Me.Label24.Text = "Tipo Doc."
      '
      'cmbTipoDocumento
      '
      Me.cmbTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.cmbTipoDocumento.FormattingEnabled = True
      Me.cmbTipoDocumento.Location = New System.Drawing.Point(6, 36)
      Me.cmbTipoDocumento.Name = "cmbTipoDocumento"
      Me.cmbTipoDocumento.Size = New System.Drawing.Size(107, 21)
      Me.cmbTipoDocumento.TabIndex = 8
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
      Me.txtBusNumero.Size = New System.Drawing.Size(91, 21)
      Me.txtBusNumero.TabIndex = 7
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
      'BindingNavigatorCountItem
      '
      Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
      Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(36, 22)
      Me.BindingNavigatorCountItem.Text = "of {0}"
      Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
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
      'BindingNavigatorSeparator2
      '
      Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
      Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
      '
      'acpnlTitulo
      '
      Me.acpnlTitulo.ACCaption = "Costeo"
      Me.acpnlTitulo.Dock = System.Windows.Forms.DockStyle.Top
      Me.acpnlTitulo.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
      Me.acpnlTitulo.Location = New System.Drawing.Point(0, 0)
      Me.acpnlTitulo.Name = "acpnlTitulo"
      Me.acpnlTitulo.Size = New System.Drawing.Size(852, 40)
      Me.acpnlTitulo.TabIndex = 16
      '
      'acTool
      '
      Me.acTool.ACBtnAnularEnabled = False
      Me.acTool.ACBtnAnularVisible = False
      Me.acTool.ACBtnBuscarEnabled = False
      Me.acTool.ACBtnBuscarVisible = False
      Me.acTool.ACBtnCancelarEnabled = False
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
      Me.acTool.ACBtnSalirVisible = False
      Me.acTool.ACBtnVolverEnabled = False
      Me.acTool.ACBtnVolverVisible = False
      Me.acTool.ACTipoToolBar = ACControles.ACToolBarMantHorizontalNew.tipoToolBar.ToolSalir
      Me.acTool.Dock = System.Windows.Forms.DockStyle.Bottom
      Me.acTool.Font = New System.Drawing.Font("Tahoma", 9.5!)
      Me.acTool.ImageScalingSize = New System.Drawing.Size(32, 32)
      Me.acTool.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.acbtnCostear})
      Me.acTool.Location = New System.Drawing.Point(0, 510)
      Me.acTool.Name = "acTool"
      Me.acTool.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
      Me.acTool.Size = New System.Drawing.Size(852, 56)
      Me.acTool.TabIndex = 15
      Me.acTool.Text = "AcToolBarMantHorizontalNew1"
      '
      'actxaOrdCompra
      '
      Me.actxaOrdCompra.Location = New System.Drawing.Point(712, 9)
      Me.actxaOrdCompra.Name = "actxaOrdCompra"
      Me.actxaOrdCompra.ReadOnly = True
      Me.actxaOrdCompra.Size = New System.Drawing.Size(121, 21)
      Me.actxaOrdCompra.TabIndex = 15
      '
      'grpTPago
      '
      Me.grpTPago.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.grpTPago.Controls.Add(Me.Label19)
      Me.grpTPago.Controls.Add(Me.AcTextBoxNumerico2)
      Me.grpTPago.Controls.Add(Me.Label14)
      Me.grpTPago.Controls.Add(Me.AcTextBoxNumerico1)
      Me.grpTPago.Location = New System.Drawing.Point(11, 61)
      Me.grpTPago.Name = "grpTPago"
      Me.grpTPago.Size = New System.Drawing.Size(414, 40)
      Me.grpTPago.TabIndex = 12
      Me.grpTPago.TabStop = False
      Me.grpTPago.Text = "Por TM"
      '
      'AcTextBoxNumerico1
      '
      Me.AcTextBoxNumerico1.ACEnteros = 9
      Me.AcTextBoxNumerico1.ACEstandar = ACControles.ACEstandaresFormato.ACMoneda
      Me.AcTextBoxNumerico1.ACNegativo = True
      Me.AcTextBoxNumerico1.ACValue = New Decimal(New Integer() {0, 0, 0, 131072})
      Me.AcTextBoxNumerico1.Location = New System.Drawing.Point(68, 14)
      Me.AcTextBoxNumerico1.MaxLength = 12
      Me.AcTextBoxNumerico1.Name = "AcTextBoxNumerico1"
      Me.AcTextBoxNumerico1.Size = New System.Drawing.Size(120, 21)
      Me.AcTextBoxNumerico1.TabIndex = 0
      Me.AcTextBoxNumerico1.Text = "0.00"
      Me.AcTextBoxNumerico1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
      '
      'Label14
      '
      Me.Label14.AutoSize = True
      Me.Label14.Location = New System.Drawing.Point(12, 18)
      Me.Label14.Name = "Label14"
      Me.Label14.Size = New System.Drawing.Size(38, 13)
      Me.Label14.TabIndex = 9
      Me.Label14.Text = "Flete :"
      '
      'Label19
      '
      Me.Label19.AutoSize = True
      Me.Label19.Location = New System.Drawing.Point(226, 18)
      Me.Label19.Name = "Label19"
      Me.Label19.Size = New System.Drawing.Size(47, 13)
      Me.Label19.TabIndex = 11
      Me.Label19.Text = "Gastos :"
      '
      'AcTextBoxNumerico2
      '
      Me.AcTextBoxNumerico2.ACEnteros = 9
      Me.AcTextBoxNumerico2.ACEstandar = ACControles.ACEstandaresFormato.ACMoneda
      Me.AcTextBoxNumerico2.ACNegativo = True
      Me.AcTextBoxNumerico2.ACValue = New Decimal(New Integer() {0, 0, 0, 131072})
      Me.AcTextBoxNumerico2.Location = New System.Drawing.Point(282, 14)
      Me.AcTextBoxNumerico2.MaxLength = 12
      Me.AcTextBoxNumerico2.Name = "AcTextBoxNumerico2"
      Me.AcTextBoxNumerico2.Size = New System.Drawing.Size(121, 21)
      Me.AcTextBoxNumerico2.TabIndex = 10
      Me.AcTextBoxNumerico2.Text = "0.00"
      Me.AcTextBoxNumerico2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
      'btnCalcular
      '
      Me.btnCalcular.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.btnCalcular.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
      Me.btnCalcular.Image = Global.ACPLogistica.My.Resources.Resources.Calculator_red_32x32
      Me.btnCalcular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
      Me.btnCalcular.Location = New System.Drawing.Point(431, 63)
      Me.btnCalcular.Name = "btnCalcular"
      Me.btnCalcular.Size = New System.Drawing.Size(93, 42)
      Me.btnCalcular.TabIndex = 30
      Me.btnCalcular.Text = "Calcular"
      Me.btnCalcular.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.btnCalcular.UseVisualStyleBackColor = True
      Me.btnCalcular.Visible = False
      '
      'btnConsultar
      '
      Me.btnConsultar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.btnConsultar.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
      Me.btnConsultar.Image = Global.ACPLogistica.My.Resources.Resources.Buscar2_32x32
      Me.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
      Me.btnConsultar.Location = New System.Drawing.Point(323, 193)
      Me.btnConsultar.Name = "btnConsultar"
      Me.btnConsultar.Size = New System.Drawing.Size(99, 42)
      Me.btnConsultar.TabIndex = 29
      Me.btnConsultar.Text = "Consultar"
      Me.btnConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.btnConsultar.UseVisualStyleBackColor = True
      Me.btnConsultar.Visible = False
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
      'acbtnCostear
      '
      Me.acbtnCostear.AutoSize = False
      Me.acbtnCostear.Image = Global.ACPLogistica.My.Resources.Resources.EMoney_32x32
      Me.acbtnCostear.ImageAlign = System.Drawing.ContentAlignment.TopCenter
      Me.acbtnCostear.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
      Me.acbtnCostear.ImageTransparentColor = System.Drawing.Color.Magenta
      Me.acbtnCostear.Name = "tsbBoton"
      Me.acbtnCostear.Size = New System.Drawing.Size(75, 53)
      Me.acbtnCostear.Text = "Costear"
      Me.acbtnCostear.TextAlign = System.Drawing.ContentAlignment.BottomCenter
      Me.acbtnCostear.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
      Me.acbtnCostear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
      '
      'TCosteo
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(852, 566)
      Me.Controls.Add(Me.tabMantenimiento)
      Me.Controls.Add(Me.acpnlTitulo)
      Me.Controls.Add(Me.acTool)
      Me.MinimumSize = New System.Drawing.Size(860, 500)
      Me.Name = "TCosteo"
      Me.Text = "Costeo"
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
      Me.acTool.ResumeLayout(False)
      Me.acTool.PerformLayout()
      Me.grpTPago.ResumeLayout(False)
      Me.grpTPago.PerformLayout()
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
   Friend WithEvents Label16 As System.Windows.Forms.Label
   Friend WithEvents actxnIGV As ACControles.ACTextBoxNumerico
   Friend WithEvents actxnTotal As ACControles.ACTextBoxNumerico
   Friend WithEvents Label15 As System.Windows.Forms.Label
   Friend WithEvents cmbMoneda As System.Windows.Forms.ComboBox
   Friend WithEvents pnlCabecera As System.Windows.Forms.Panel
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
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
   Friend WithEvents Label25 As System.Windows.Forms.Label
   Friend WithEvents actxnTipoCambio As ACControles.ACTextBoxNumerico
   Friend WithEvents Label4 As System.Windows.Forms.Label
   Friend WithEvents actxnImporte As ACControles.ACTextBoxNumerico
   Friend WithEvents btnConsultar As System.Windows.Forms.Button
   Friend WithEvents Label5 As System.Windows.Forms.Label
   Friend WithEvents rbtnDatos As System.Windows.Forms.RadioButton
   Friend WithEvents grpCliente As System.Windows.Forms.GroupBox
   Friend WithEvents txtBusqueda As ACControles.ACTextBoxAyuda
   Friend WithEvents rbtnProveedor As System.Windows.Forms.RadioButton
   Friend WithEvents rbtnNroOrdenCompra As System.Windows.Forms.RadioButton
   Friend WithEvents rbtnDocVenta As System.Windows.Forms.RadioButton
   Friend WithEvents grpDocumentos As System.Windows.Forms.GroupBox
   Friend WithEvents Label18 As System.Windows.Forms.Label
   Friend WithEvents Label22 As System.Windows.Forms.Label
   Friend WithEvents Label24 As System.Windows.Forms.Label
   Friend WithEvents cmbTipoDocumento As System.Windows.Forms.ComboBox
   Friend WithEvents txtBusNumero As ACControles.ACTextBoxAyuda
   Friend WithEvents chkTodos As System.Windows.Forms.CheckBox
   Friend WithEvents acbtnCostear As ACControles.ACToolStripButton
   Friend WithEvents txtCSerie As System.Windows.Forms.TextBox
   Friend WithEvents actxaProvNombres As System.Windows.Forms.TextBox
   Friend WithEvents actxaProvCodigo As System.Windows.Forms.TextBox
   Friend WithEvents actxaOrdCompra As System.Windows.Forms.TextBox
   Friend WithEvents grpTPago As System.Windows.Forms.GroupBox
   Friend WithEvents Label19 As System.Windows.Forms.Label
   Friend WithEvents AcTextBoxNumerico2 As ACControles.ACTextBoxNumerico
   Friend WithEvents Label14 As System.Windows.Forms.Label
   Friend WithEvents AcTextBoxNumerico1 As ACControles.ACTextBoxNumerico
   Friend WithEvents btnCalcular As System.Windows.Forms.Button
End Class
