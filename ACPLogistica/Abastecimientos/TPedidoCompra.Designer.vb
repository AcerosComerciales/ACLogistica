<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TPedidoCompra
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TPedidoCompra))
        Me.tabMantenimiento = New Crownwood.DotNetMagic.Controls.TabControl()
        Me.tabDatos = New Crownwood.DotNetMagic.Controls.TabPage()
        Me.pnlDetalle = New System.Windows.Forms.Panel()
        Me.c1grdDetalle = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.bnavProductos = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.tbcDetalles = New Crownwood.DotNetMagic.Controls.TabControl()
        Me.tpgDetAnulacion = New Crownwood.DotNetMagic.Controls.TabPage()
        Me.txtMotivoAnulacion = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.dtpFechaAnulacion = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.pnlItem = New System.Windows.Forms.Panel()
        Me.actxnStockLocal = New ACControles.ACTextBoxNumerico()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtUnidad = New System.Windows.Forms.TextBox()
        Me.actxnPeso = New ACControles.ACTextBoxNumerico()
        Me.txtOpcion = New System.Windows.Forms.TextBox()
        Me.actxnCantidad = New ACControles.ACTextBoxNumerico()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtProdDescripcion = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.actxaProdCodigo = New ACControles.ACTextBoxAyuda()
        Me.pnlPie = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtObservacion = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.actxnPesoTotal = New ACControles.ACTextBoxNumerico()
        Me.lblTotalPagar = New System.Windows.Forms.Label()
        Me.chkAtendida = New System.Windows.Forms.CheckBox()
        Me.chkAnulada = New System.Windows.Forms.CheckBox()
        Me.pnlCabecera = New System.Windows.Forms.Panel()
        Me.actxaDescEncargado = New ACControles.ACTextBoxAyuda()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.actxaCodEncargado = New ACControles.ACTextBoxAyuda()
        Me.grpDocGuiaRemision = New System.Windows.Forms.GroupBox()
        Me.txtSerie = New System.Windows.Forms.TextBox()
        Me.actxnNumero = New ACControles.ACTextBoxNumerico()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.tabBusqueda = New Crownwood.DotNetMagic.Controls.TabPage()
        Me.c1grdBusqueda = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.bnavBusqueda = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtCBusqueda = New ACControles.ACTextBoxAyuda()
        Me.rbtCCliente = New System.Windows.Forms.RadioButton()
        Me.rbtnCDocumento = New System.Windows.Forms.RadioButton()
        Me.btnCConsulta = New System.Windows.Forms.Button()
        Me.chkCTodos = New System.Windows.Forms.CheckBox()
        Me.acpnlTitulo = New ACControles.ACPanelCaption()
        Me.acTool = New ACControles.ACToolBarMantHorizontalNew(Me.components)
        Me.acbtnSeleccionar = New ACControles.ACToolStripButton(Me.components)
        Me.actsbtnPrevisualizar = New ACControles.ACToolStripButton(Me.components)
        Me.AcFecha = New ACControles.ACFecha(Me.components)
        Me.tsbtnExcel = New System.Windows.Forms.ToolStripButton()
        Me.tabMantenimiento.SuspendLayout
        Me.tabDatos.SuspendLayout
        Me.pnlDetalle.SuspendLayout
        CType(Me.c1grdDetalle,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.bnavProductos,System.ComponentModel.ISupportInitialize).BeginInit
        Me.bnavProductos.SuspendLayout
        Me.tbcDetalles.SuspendLayout
        Me.tpgDetAnulacion.SuspendLayout
        Me.pnlItem.SuspendLayout
        Me.pnlPie.SuspendLayout
        Me.GroupBox1.SuspendLayout
        Me.Panel1.SuspendLayout
        Me.pnlCabecera.SuspendLayout
        Me.grpDocGuiaRemision.SuspendLayout
        Me.tabBusqueda.SuspendLayout
        CType(Me.c1grdBusqueda,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.bnavBusqueda,System.ComponentModel.ISupportInitialize).BeginInit
        Me.bnavBusqueda.SuspendLayout
        Me.GroupBox2.SuspendLayout
        Me.acTool.SuspendLayout
        Me.SuspendLayout
        '
        'tabMantenimiento
        '
        Me.tabMantenimiento.BackColor = System.Drawing.Color.LightSteelBlue
        Me.tabMantenimiento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tabMantenimiento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabMantenimiento.Location = New System.Drawing.Point(0, 29)
        Me.tabMantenimiento.MediaPlayerDockSides = false
        Me.tabMantenimiento.Name = "tabMantenimiento"
        Me.tabMantenimiento.OfficeDockSides = false
        Me.tabMantenimiento.SelectedIndex = 0
        Me.tabMantenimiento.ShowDropSelect = false
        Me.tabMantenimiento.Size = New System.Drawing.Size(991, 445)
        Me.tabMantenimiento.TabIndex = 6
        Me.tabMantenimiento.TabPages.AddRange(New Crownwood.DotNetMagic.Controls.TabPage() {Me.tabDatos, Me.tabBusqueda})
        Me.tabMantenimiento.TextTips = true
        '
        'tabDatos
        '
        Me.tabDatos.Controls.Add(Me.pnlDetalle)
        Me.tabDatos.Controls.Add(Me.pnlPie)
        Me.tabDatos.Controls.Add(Me.pnlCabecera)
        Me.tabDatos.InactiveBackColor = System.Drawing.Color.Empty
        Me.tabDatos.InactiveTextBackColor = System.Drawing.Color.Empty
        Me.tabDatos.InactiveTextColor = System.Drawing.Color.Empty
        Me.tabDatos.Location = New System.Drawing.Point(1, 1)
        Me.tabDatos.Name = "tabDatos"
        Me.tabDatos.SelectBackColor = System.Drawing.Color.Empty
        Me.tabDatos.SelectTextBackColor = System.Drawing.Color.Empty
        Me.tabDatos.SelectTextColor = System.Drawing.Color.Empty
        Me.tabDatos.Size = New System.Drawing.Size(989, 420)
        Me.tabDatos.TabIndex = 4
        Me.tabDatos.Title = "Datos"
        Me.tabDatos.ToolTip = "Datos"
        '
        'pnlDetalle
        '
        Me.pnlDetalle.Controls.Add(Me.c1grdDetalle)
        Me.pnlDetalle.Controls.Add(Me.bnavProductos)
        Me.pnlDetalle.Controls.Add(Me.tbcDetalles)
        Me.pnlDetalle.Controls.Add(Me.pnlItem)
        Me.pnlDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDetalle.Location = New System.Drawing.Point(0, 66)
        Me.pnlDetalle.Name = "pnlDetalle"
        Me.pnlDetalle.Size = New System.Drawing.Size(989, 299)
        Me.pnlDetalle.TabIndex = 2
        '
        'c1grdDetalle
        '
        Me.c1grdDetalle.BackColor = System.Drawing.Color.White
        Me.c1grdDetalle.ColumnInfo = "2,1,0,0,0,105,Columns:0{Width:18;}"&Global.Microsoft.VisualBasic.ChrW(9)&"1{Width:107;Caption:""Codigo"";}"&Global.Microsoft.VisualBasic.ChrW(9)
        Me.c1grdDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.c1grdDetalle.Font = New System.Drawing.Font("Tahoma", 14!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.c1grdDetalle.Location = New System.Drawing.Point(0, 51)
        Me.c1grdDetalle.Name = "c1grdDetalle"
        Me.c1grdDetalle.Rows.Count = 2
        Me.c1grdDetalle.Rows.DefaultSize = 21
        Me.c1grdDetalle.Size = New System.Drawing.Size(565, 223)
        Me.c1grdDetalle.StyleInfo = resources.GetString("c1grdDetalle.StyleInfo")
        Me.c1grdDetalle.TabIndex = 74
        '
        'bnavProductos
        '
        Me.bnavProductos.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.bnavProductos.CountItem = Me.BindingNavigatorCountItem
        Me.bnavProductos.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.bnavProductos.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.bnavProductos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ToolStripSeparator4, Me.tsbtnExcel})
        Me.bnavProductos.Location = New System.Drawing.Point(0, 274)
        Me.bnavProductos.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.bnavProductos.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.bnavProductos.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.bnavProductos.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.bnavProductos.Name = "bnavProductos"
        Me.bnavProductos.PositionItem = Me.BindingNavigatorPositionItem
        Me.bnavProductos.Size = New System.Drawing.Size(565, 25)
        Me.bnavProductos.TabIndex = 73
        Me.bnavProductos.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"),System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        Me.BindingNavigatorAddNewItem.Visible = false
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
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"),System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        Me.BindingNavigatorDeleteItem.Visible = false
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"),System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"),System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true
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
        Me.BindingNavigatorPositionItem.AutoSize = false
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
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"),System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"),System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'tbcDetalles
        '
        Me.tbcDetalles.BackColor = System.Drawing.Color.LightSteelBlue
        Me.tbcDetalles.BoldSelectedPage = true
        Me.tbcDetalles.Dock = System.Windows.Forms.DockStyle.Right
        Me.tbcDetalles.Location = New System.Drawing.Point(565, 51)
        Me.tbcDetalles.MediaPlayerDockSides = false
        Me.tbcDetalles.Name = "tbcDetalles"
        Me.tbcDetalles.OfficeDockSides = false
        Me.tbcDetalles.PositionTop = true
        Me.tbcDetalles.SelectedIndex = 0
        Me.tbcDetalles.ShowArrows = true
        Me.tbcDetalles.ShowDropSelect = false
        Me.tbcDetalles.Size = New System.Drawing.Size(424, 248)
        Me.tbcDetalles.TabIndex = 72
        Me.tbcDetalles.TabPages.AddRange(New Crownwood.DotNetMagic.Controls.TabPage() {Me.tpgDetAnulacion})
        Me.tbcDetalles.TextTips = true
        Me.tbcDetalles.Visible = false
        '
        'tpgDetAnulacion
        '
        Me.tpgDetAnulacion.Controls.Add(Me.txtMotivoAnulacion)
        Me.tpgDetAnulacion.Controls.Add(Me.Label18)
        Me.tpgDetAnulacion.Controls.Add(Me.dtpFechaAnulacion)
        Me.tpgDetAnulacion.Controls.Add(Me.Label12)
        Me.tpgDetAnulacion.InactiveBackColor = System.Drawing.Color.Empty
        Me.tpgDetAnulacion.InactiveTextBackColor = System.Drawing.Color.Empty
        Me.tpgDetAnulacion.InactiveTextColor = System.Drawing.Color.Empty
        Me.tpgDetAnulacion.Location = New System.Drawing.Point(1, 24)
        Me.tpgDetAnulacion.Name = "tpgDetAnulacion"
        Me.tpgDetAnulacion.SelectBackColor = System.Drawing.Color.Empty
        Me.tpgDetAnulacion.SelectTextBackColor = System.Drawing.Color.Empty
        Me.tpgDetAnulacion.SelectTextColor = System.Drawing.Color.Empty
        Me.tpgDetAnulacion.Size = New System.Drawing.Size(422, 223)
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
        Me.txtMotivoAnulacion.Size = New System.Drawing.Size(342, 134)
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
        'Label12
        '
        Me.Label12.AutoSize = true
        Me.Label12.Location = New System.Drawing.Point(19, 13)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(44, 15)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "Fecha :"
        '
        'pnlItem
        '
        Me.pnlItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(3,Byte),Integer), CType(CType(55,Byte),Integer), CType(CType(145,Byte),Integer))
        Me.pnlItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlItem.Controls.Add(Me.actxnStockLocal)
        Me.pnlItem.Controls.Add(Me.Label5)
        Me.pnlItem.Controls.Add(Me.Label3)
        Me.pnlItem.Controls.Add(Me.txtUnidad)
        Me.pnlItem.Controls.Add(Me.actxnPeso)
        Me.pnlItem.Controls.Add(Me.txtOpcion)
        Me.pnlItem.Controls.Add(Me.actxnCantidad)
        Me.pnlItem.Controls.Add(Me.Label9)
        Me.pnlItem.Controls.Add(Me.Label14)
        Me.pnlItem.Controls.Add(Me.txtProdDescripcion)
        Me.pnlItem.Controls.Add(Me.Label17)
        Me.pnlItem.Controls.Add(Me.lblCodigo)
        Me.pnlItem.Controls.Add(Me.actxaProdCodigo)
        Me.pnlItem.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlItem.Location = New System.Drawing.Point(0, 0)
        Me.pnlItem.Name = "pnlItem"
        Me.pnlItem.Size = New System.Drawing.Size(989, 51)
        Me.pnlItem.TabIndex = 0
        '
        'actxnStockLocal
        '
        Me.actxnStockLocal.ACEnteros = 9
        Me.actxnStockLocal.ACEstandar = ACControles.ACEstandaresFormato.ACMoneda
        Me.actxnStockLocal.ACNegativo = true
        Me.actxnStockLocal.ACValue = New Decimal(New Integer() {0, 0, 0, 131072})
        Me.actxnStockLocal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.actxnStockLocal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.actxnStockLocal.Location = New System.Drawing.Point(802, 21)
        Me.actxnStockLocal.MaxLength = 12
        Me.actxnStockLocal.Name = "actxnStockLocal"
        Me.actxnStockLocal.ReadOnly = true
        Me.actxnStockLocal.Size = New System.Drawing.Size(72, 23)
        Me.actxnStockLocal.TabIndex = 13
        Me.actxnStockLocal.Tag = "V"
        Me.actxnStockLocal.Text = "0.00"
        Me.actxnStockLocal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = true
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 11!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(810, 5)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "S. Local"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = true
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 11!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(671, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Unidad"
        '
        'txtUnidad
        '
        Me.txtUnidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtUnidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUnidad.Location = New System.Drawing.Point(658, 21)
        Me.txtUnidad.Name = "txtUnidad"
        Me.txtUnidad.ReadOnly = true
        Me.txtUnidad.Size = New System.Drawing.Size(68, 23)
        Me.txtUnidad.TabIndex = 5
        Me.txtUnidad.Tag = "V"
        '
        'actxnPeso
        '
        Me.actxnPeso.ACEnteros = 9
        Me.actxnPeso.ACEstandar = ACControles.ACEstandaresFormato.ACMoneda
        Me.actxnPeso.ACNegativo = true
        Me.actxnPeso.ACValue = New Decimal(New Integer() {0, 0, 0, 131072})
        Me.actxnPeso.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.actxnPeso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.actxnPeso.Location = New System.Drawing.Point(728, 21)
        Me.actxnPeso.MaxLength = 12
        Me.actxnPeso.Name = "actxnPeso"
        Me.actxnPeso.ReadOnly = true
        Me.actxnPeso.Size = New System.Drawing.Size(72, 23)
        Me.actxnPeso.TabIndex = 7
        Me.actxnPeso.Tag = "EV"
        Me.actxnPeso.Text = "0.00"
        Me.actxnPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtOpcion
        '
        Me.txtOpcion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtOpcion.BackColor = System.Drawing.Color.Gainsboro
        Me.txtOpcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOpcion.Location = New System.Drawing.Point(951, 21)
        Me.txtOpcion.MaxLength = 1
        Me.txtOpcion.Name = "txtOpcion"
        Me.txtOpcion.Size = New System.Drawing.Size(25, 23)
        Me.txtOpcion.TabIndex = 16
        '
        'actxnCantidad
        '
        Me.actxnCantidad.ACEnteros = 9
        Me.actxnCantidad.ACEstandar = ACControles.ACEstandaresFormato.ACMoneda
        Me.actxnCantidad.ACNegativo = true
        Me.actxnCantidad.ACValue = New Decimal(New Integer() {0, 0, 0, 131072})
        Me.actxnCantidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.actxnCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.actxnCantidad.Location = New System.Drawing.Point(876, 21)
        Me.actxnCantidad.MaxLength = 12
        Me.actxnCantidad.Name = "actxnCantidad"
        Me.actxnCantidad.Size = New System.Drawing.Size(73, 23)
        Me.actxnCantidad.TabIndex = 15
        Me.actxnCantidad.Tag = "EV"
        Me.actxnCantidad.Text = "0.00"
        Me.actxnCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = true
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 11!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(749, 5)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 13)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Peso"
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = true
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 11!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(888, 5)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(57, 13)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = "C&antidad"
        '
        'txtProdDescripcion
        '
        Me.txtProdDescripcion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtProdDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProdDescripcion.Location = New System.Drawing.Point(120, 21)
        Me.txtProdDescripcion.Name = "txtProdDescripcion"
        Me.txtProdDescripcion.ReadOnly = true
        Me.txtProdDescripcion.Size = New System.Drawing.Size(536, 23)
        Me.txtProdDescripcion.TabIndex = 3
        Me.txtProdDescripcion.Tag = "V"
        '
        'Label17
        '
        Me.Label17.AutoSize = true
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 11!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(125, 5)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(72, 13)
        Me.Label17.TabIndex = 2
        Me.Label17.Text = "Descripcion"
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = true
        Me.lblCodigo.Font = New System.Drawing.Font("Tahoma", 11!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
        Me.lblCodigo.ForeColor = System.Drawing.Color.White
        Me.lblCodigo.Location = New System.Drawing.Point(11, 5)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(45, 13)
        Me.lblCodigo.TabIndex = 0
        Me.lblCodigo.Text = "C&odigo"
        '
        'actxaProdCodigo
        '
        Me.actxaProdCodigo.ACActivarAyudaAuto = false
        Me.actxaProdCodigo.ACLongitudAceptada = 0
        Me.actxaProdCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.actxaProdCodigo.Location = New System.Drawing.Point(4, 21)
        Me.actxaProdCodigo.MaxLength = 32767
        Me.actxaProdCodigo.Name = "actxaProdCodigo"
        Me.actxaProdCodigo.Size = New System.Drawing.Size(110, 23)
        Me.actxaProdCodigo.TabIndex = 1
        Me.actxaProdCodigo.Tag = "EV"
        '
        'pnlPie
        '
        Me.pnlPie.BackColor = System.Drawing.Color.FromArgb(CType(CType(3,Byte),Integer), CType(CType(55,Byte),Integer), CType(CType(145,Byte),Integer))
        Me.pnlPie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlPie.Controls.Add(Me.GroupBox1)
        Me.pnlPie.Controls.Add(Me.Panel1)
        Me.pnlPie.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlPie.Location = New System.Drawing.Point(0, 365)
        Me.pnlPie.Name = "pnlPie"
        Me.pnlPie.Size = New System.Drawing.Size(989, 55)
        Me.pnlPie.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(3,Byte),Integer), CType(CType(55,Byte),Integer), CType(CType(145,Byte),Integer))
        Me.GroupBox1.Controls.Add(Me.txtObservacion)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(7, 1, 9, 3)
        Me.GroupBox1.Size = New System.Drawing.Size(562, 53)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = false
        Me.GroupBox1.Text = "Observaciones"
        '
        'txtObservacion
        '
        Me.txtObservacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtObservacion.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtObservacion.Location = New System.Drawing.Point(7, 17)
        Me.txtObservacion.Multiline = true
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservacion.Size = New System.Drawing.Size(546, 33)
        Me.txtObservacion.TabIndex = 0
        Me.txtObservacion.Tag = "EV"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.actxnPesoTotal)
        Me.Panel1.Controls.Add(Me.lblTotalPagar)
        Me.Panel1.Controls.Add(Me.chkAtendida)
        Me.Panel1.Controls.Add(Me.chkAnulada)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(562, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(425, 53)
        Me.Panel1.TabIndex = 6
        '
        'actxnPesoTotal
        '
        Me.actxnPesoTotal.ACEnteros = 9
        Me.actxnPesoTotal.ACEstandar = ACControles.ACEstandaresFormato.ACDecimal
        Me.actxnPesoTotal.ACNegativo = true
        Me.actxnPesoTotal.ACValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.actxnPesoTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.actxnPesoTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.actxnPesoTotal.Font = New System.Drawing.Font("Segoe UI", 14!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
        Me.actxnPesoTotal.Location = New System.Drawing.Point(284, 13)
        Me.actxnPesoTotal.MaxLength = 12
        Me.actxnPesoTotal.Name = "actxnPesoTotal"
        Me.actxnPesoTotal.ReadOnly = true
        Me.actxnPesoTotal.Size = New System.Drawing.Size(132, 26)
        Me.actxnPesoTotal.TabIndex = 4
        Me.actxnPesoTotal.Tag = "EVO"
        Me.actxnPesoTotal.Text = "0.00"
        Me.actxnPesoTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblTotalPagar
        '
        Me.lblTotalPagar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.lblTotalPagar.AutoSize = true
        Me.lblTotalPagar.Font = New System.Drawing.Font("Segoe UI", 13!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
        Me.lblTotalPagar.ForeColor = System.Drawing.Color.White
        Me.lblTotalPagar.Location = New System.Drawing.Point(184, 18)
        Me.lblTotalPagar.Name = "lblTotalPagar"
        Me.lblTotalPagar.Size = New System.Drawing.Size(80, 17)
        Me.lblTotalPagar.TabIndex = 3
        Me.lblTotalPagar.Text = "Peso Total :"
        '
        'chkAtendida
        '
        Me.chkAtendida.AutoSize = true
        Me.chkAtendida.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkAtendida.Enabled = false
        Me.chkAtendida.ForeColor = System.Drawing.Color.White
        Me.chkAtendida.Location = New System.Drawing.Point(93, 20)
        Me.chkAtendida.Name = "chkAtendida"
        Me.chkAtendida.Size = New System.Drawing.Size(74, 19)
        Me.chkAtendida.TabIndex = 2
        Me.chkAtendida.Tag = "EO"
        Me.chkAtendida.Text = "Atendida"
        Me.chkAtendida.UseVisualStyleBackColor = true
        '
        'chkAnulada
        '
        Me.chkAnulada.AutoSize = true
        Me.chkAnulada.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkAnulada.Enabled = false
        Me.chkAnulada.ForeColor = System.Drawing.Color.White
        Me.chkAnulada.Location = New System.Drawing.Point(16, 20)
        Me.chkAnulada.Name = "chkAnulada"
        Me.chkAnulada.Size = New System.Drawing.Size(70, 19)
        Me.chkAnulada.TabIndex = 1
        Me.chkAnulada.Tag = "EO"
        Me.chkAnulada.Text = "Anulada"
        Me.chkAnulada.UseVisualStyleBackColor = true
        '
        'pnlCabecera
        '
        Me.pnlCabecera.BackColor = System.Drawing.Color.LightSteelBlue
        Me.pnlCabecera.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlCabecera.Controls.Add(Me.actxaDescEncargado)
        Me.pnlCabecera.Controls.Add(Me.Label7)
        Me.pnlCabecera.Controls.Add(Me.actxaCodEncargado)
        Me.pnlCabecera.Controls.Add(Me.grpDocGuiaRemision)
        Me.pnlCabecera.Controls.Add(Me.Label1)
        Me.pnlCabecera.Controls.Add(Me.dtpFecha)
        Me.pnlCabecera.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlCabecera.Location = New System.Drawing.Point(0, 0)
        Me.pnlCabecera.Name = "pnlCabecera"
        Me.pnlCabecera.Size = New System.Drawing.Size(989, 66)
        Me.pnlCabecera.TabIndex = 0
        '
        'actxaDescEncargado
        '
        Me.actxaDescEncargado.ACActivarAyudaAuto = false
        Me.actxaDescEncargado.ACLongitudAceptada = 0
        Me.actxaDescEncargado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.actxaDescEncargado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.actxaDescEncargado.Location = New System.Drawing.Point(229, 35)
        Me.actxaDescEncargado.MaxLength = 80
        Me.actxaDescEncargado.Name = "actxaDescEncargado"
        Me.actxaDescEncargado.Size = New System.Drawing.Size(467, 23)
        Me.actxaDescEncargado.TabIndex = 8
        Me.actxaDescEncargado.Tag = "EVO"
        '
        'Label7
        '
        Me.Label7.AutoSize = true
        Me.Label7.Location = New System.Drawing.Point(35, 37)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 15)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Encargado :"
        '
        'actxaCodEncargado
        '
        Me.actxaCodEncargado.ACActivarAyudaAuto = false
        Me.actxaCodEncargado.ACLongitudAceptada = 0
        Me.actxaCodEncargado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.actxaCodEncargado.Location = New System.Drawing.Point(110, 35)
        Me.actxaCodEncargado.MaxLength = 14
        Me.actxaCodEncargado.Name = "actxaCodEncargado"
        Me.actxaCodEncargado.Size = New System.Drawing.Size(113, 23)
        Me.actxaCodEncargado.TabIndex = 7
        Me.actxaCodEncargado.Tag = "EVO"
        '
        'grpDocGuiaRemision
        '
        Me.grpDocGuiaRemision.BackColor = System.Drawing.Color.FromArgb(CType(CType(3,Byte),Integer), CType(CType(55,Byte),Integer), CType(CType(145,Byte),Integer))
        Me.grpDocGuiaRemision.Controls.Add(Me.txtSerie)
        Me.grpDocGuiaRemision.Controls.Add(Me.actxnNumero)
        Me.grpDocGuiaRemision.Controls.Add(Me.Label2)
        Me.grpDocGuiaRemision.Controls.Add(Me.Label6)
        Me.grpDocGuiaRemision.Dock = System.Windows.Forms.DockStyle.Right
        Me.grpDocGuiaRemision.ForeColor = System.Drawing.Color.White
        Me.grpDocGuiaRemision.Location = New System.Drawing.Point(702, 0)
        Me.grpDocGuiaRemision.Name = "grpDocGuiaRemision"
        Me.grpDocGuiaRemision.Size = New System.Drawing.Size(285, 64)
        Me.grpDocGuiaRemision.TabIndex = 0
        Me.grpDocGuiaRemision.TabStop = false
        Me.grpDocGuiaRemision.Text = "Documento"
        '
        'txtSerie
        '
        Me.txtSerie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSerie.Location = New System.Drawing.Point(58, 22)
        Me.txtSerie.MaxLength = 50
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.Size = New System.Drawing.Size(51, 23)
        Me.txtSerie.TabIndex = 2
        Me.txtSerie.Tag = "EVO"
        '
        'actxnNumero
        '
        Me.actxnNumero.ACEnteros = 8
        Me.actxnNumero.ACFormato = "#######0"
        Me.actxnNumero.ACNegativo = true
        Me.actxnNumero.ACValue = New Decimal(New Integer() {0, 0, 0, 131072})
        Me.actxnNumero.Location = New System.Drawing.Point(178, 22)
        Me.actxnNumero.MaxLength = 7
        Me.actxnNumero.Name = "actxnNumero"
        Me.actxnNumero.Size = New System.Drawing.Size(94, 23)
        Me.actxnNumero.TabIndex = 4
        Me.actxnNumero.Tag = "EVO"
        Me.actxnNumero.Text = "0"
        Me.actxnNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Location = New System.Drawing.Point(120, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Numero"
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.Location = New System.Drawing.Point(17, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 15)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Serie"
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(63, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fecha :"
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(116, 5)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(101, 23)
        Me.dtpFecha.TabIndex = 1
        Me.dtpFecha.Tag = "E"
        '
        'tabBusqueda
        '
        Me.tabBusqueda.Controls.Add(Me.c1grdBusqueda)
        Me.tabBusqueda.Controls.Add(Me.bnavBusqueda)
        Me.tabBusqueda.Controls.Add(Me.GroupBox2)
        Me.tabBusqueda.InactiveBackColor = System.Drawing.Color.Empty
        Me.tabBusqueda.InactiveTextBackColor = System.Drawing.Color.Empty
        Me.tabBusqueda.InactiveTextColor = System.Drawing.Color.Empty
        Me.tabBusqueda.Location = New System.Drawing.Point(1, 1)
        Me.tabBusqueda.Name = "tabBusqueda"
        Me.tabBusqueda.SelectBackColor = System.Drawing.Color.Empty
        Me.tabBusqueda.Selected = false
        Me.tabBusqueda.SelectTextBackColor = System.Drawing.Color.Empty
        Me.tabBusqueda.SelectTextColor = System.Drawing.Color.Empty
        Me.tabBusqueda.Size = New System.Drawing.Size(989, 420)
        Me.tabBusqueda.TabIndex = 5
        Me.tabBusqueda.Title = "Busqueda"
        Me.tabBusqueda.ToolTip = "Busqueda"
        '
        'c1grdBusqueda
        '
        Me.c1grdBusqueda.ColumnInfo = "2,1,0,0,0,100,Columns:0{Width:25;}"&Global.Microsoft.VisualBasic.ChrW(9)
        Me.c1grdBusqueda.Dock = System.Windows.Forms.DockStyle.Fill
        Me.c1grdBusqueda.Location = New System.Drawing.Point(0, 72)
        Me.c1grdBusqueda.Name = "c1grdBusqueda"
        Me.c1grdBusqueda.Rows.Count = 2
        Me.c1grdBusqueda.Rows.DefaultSize = 20
        Me.c1grdBusqueda.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.c1grdBusqueda.Size = New System.Drawing.Size(989, 323)
        Me.c1grdBusqueda.StyleInfo = resources.GetString("c1grdBusqueda.StyleInfo")
        Me.c1grdBusqueda.TabIndex = 1
        '
        'bnavBusqueda
        '
        Me.bnavBusqueda.AddNewItem = Me.ToolStripButton1
        Me.bnavBusqueda.CountItem = Me.ToolStripLabel1
        Me.bnavBusqueda.DeleteItem = Me.ToolStripButton2
        Me.bnavBusqueda.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.bnavBusqueda.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripSeparator1, Me.ToolStripTextBox1, Me.ToolStripLabel1, Me.ToolStripSeparator2, Me.ToolStripButton5, Me.ToolStripButton6, Me.ToolStripSeparator3, Me.ToolStripButton1, Me.ToolStripButton2})
        Me.bnavBusqueda.Location = New System.Drawing.Point(0, 395)
        Me.bnavBusqueda.MoveFirstItem = Me.ToolStripButton3
        Me.bnavBusqueda.MoveLastItem = Me.ToolStripButton6
        Me.bnavBusqueda.MoveNextItem = Me.ToolStripButton5
        Me.bnavBusqueda.MovePreviousItem = Me.ToolStripButton4
        Me.bnavBusqueda.Name = "bnavBusqueda"
        Me.bnavBusqueda.PositionItem = Me.ToolStripTextBox1
        Me.bnavBusqueda.Size = New System.Drawing.Size(989, 25)
        Me.bnavBusqueda.TabIndex = 2
        Me.bnavBusqueda.Text = "BindingNavigator1"
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.AcFecha)
        Me.GroupBox2.Controls.Add(Me.txtCBusqueda)
        Me.GroupBox2.Controls.Add(Me.rbtCCliente)
        Me.GroupBox2.Controls.Add(Me.rbtnCDocumento)
        Me.GroupBox2.Controls.Add(Me.btnCConsulta)
        Me.GroupBox2.Controls.Add(Me.chkCTodos)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(989, 72)
        Me.GroupBox2.TabIndex = 40
        Me.GroupBox2.TabStop = false
        Me.GroupBox2.Text = "Opciones de Busqueda, documentos de Traslado"
        '
        'txtCBusqueda
        '
        Me.txtCBusqueda.ACActivarAyudaAuto = false
        Me.txtCBusqueda.ACLongitudAceptada = 0
        Me.txtCBusqueda.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtCBusqueda.Location = New System.Drawing.Point(14, 41)
        Me.txtCBusqueda.MaxLength = 32767
        Me.txtCBusqueda.Name = "txtCBusqueda"
        Me.txtCBusqueda.Size = New System.Drawing.Size(528, 23)
        Me.txtCBusqueda.TabIndex = 0
        '
        'rbtCCliente
        '
        Me.rbtCCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.rbtCCliente.AutoSize = true
        Me.rbtCCliente.Checked = true
        Me.rbtCCliente.Location = New System.Drawing.Point(298, 16)
        Me.rbtCCliente.Name = "rbtCCliente"
        Me.rbtCCliente.Size = New System.Drawing.Size(81, 19)
        Me.rbtCCliente.TabIndex = 1
        Me.rbtCCliente.TabStop = true
        Me.rbtCCliente.Text = "Encargado"
        Me.rbtCCliente.UseVisualStyleBackColor = true
        '
        'rbtnCDocumento
        '
        Me.rbtnCDocumento.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.rbtnCDocumento.AutoSize = true
        Me.rbtnCDocumento.Location = New System.Drawing.Point(394, 16)
        Me.rbtnCDocumento.Name = "rbtnCDocumento"
        Me.rbtnCDocumento.Size = New System.Drawing.Size(146, 19)
        Me.rbtnCDocumento.TabIndex = 2
        Me.rbtnCDocumento.Text = "Codigo de Documento"
        Me.rbtnCDocumento.UseVisualStyleBackColor = true
        '
        'btnCConsulta
        '
        Me.btnCConsulta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnCConsulta.Font = New System.Drawing.Font("Tahoma", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.btnCConsulta.Image = Global.ACPLogistica.My.Resources.Resources.Buscar2_32x32
        Me.btnCConsulta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCConsulta.Location = New System.Drawing.Point(548, 19)
        Me.btnCConsulta.Name = "btnCConsulta"
        Me.btnCConsulta.Size = New System.Drawing.Size(99, 42)
        Me.btnCConsulta.TabIndex = 31
        Me.btnCConsulta.Text = "Consultar"
        Me.btnCConsulta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCConsulta.UseVisualStyleBackColor = true
        '
        'chkCTodos
        '
        Me.chkCTodos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.chkCTodos.AutoSize = true
        Me.chkCTodos.Location = New System.Drawing.Point(877, 47)
        Me.chkCTodos.Name = "chkCTodos"
        Me.chkCTodos.Size = New System.Drawing.Size(101, 19)
        Me.chkCTodos.TabIndex = 26
        Me.chkCTodos.Text = "Mostrar Todos"
        Me.chkCTodos.UseVisualStyleBackColor = true
        '
        'acpnlTitulo
        '
        Me.acpnlTitulo.ACCaption = "Pedido de Compra"
        Me.acpnlTitulo.Active = true
        Me.acpnlTitulo.ActiveGradientHighColor = System.Drawing.Color.CornflowerBlue
        Me.acpnlTitulo.ActiveGradientLowColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(64,Byte),Integer))
        Me.acpnlTitulo.ActiveTextColor = System.Drawing.Color.White
        Me.acpnlTitulo.BackColor = System.Drawing.Color.Red
        Me.acpnlTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.acpnlTitulo.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold)
        Me.acpnlTitulo.InactiveGradientHighColor = System.Drawing.Color.FromArgb(CType(CType(3,Byte),Integer), CType(CType(55,Byte),Integer), CType(CType(145,Byte),Integer))
        Me.acpnlTitulo.InactiveGradientLowColor = System.Drawing.Color.FromArgb(CType(CType(90,Byte),Integer), CType(CType(135,Byte),Integer), CType(CType(215,Byte),Integer))
        Me.acpnlTitulo.Location = New System.Drawing.Point(0, 0)
        Me.acpnlTitulo.Name = "acpnlTitulo"
        Me.acpnlTitulo.Size = New System.Drawing.Size(991, 29)
        Me.acpnlTitulo.TabIndex = 7
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
        Me.acTool.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.acbtnSeleccionar, Me.actsbtnPrevisualizar})
        Me.acTool.Location = New System.Drawing.Point(0, 474)
        Me.acTool.Name = "acTool"
        Me.acTool.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.acTool.Size = New System.Drawing.Size(991, 56)
        Me.acTool.TabIndex = 8
        Me.acTool.Text = "AcToolBarMantHorizontalNew1"
        '
        'acbtnSeleccionar
        '
        Me.acbtnSeleccionar.AutoSize = false
        Me.acbtnSeleccionar.Image = CType(resources.GetObject("acbtnSeleccionar.Image"),System.Drawing.Image)
        Me.acbtnSeleccionar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.acbtnSeleccionar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.acbtnSeleccionar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.acbtnSeleccionar.Name = "tsbBoton"
        Me.acbtnSeleccionar.Size = New System.Drawing.Size(84, 53)
        Me.acbtnSeleccionar.Text = "Seleccionar"
        Me.acbtnSeleccionar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.acbtnSeleccionar.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        Me.acbtnSeleccionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
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
        Me.actsbtnPrevisualizar.Text = "Revisar"
        Me.actsbtnPrevisualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.actsbtnPrevisualizar.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        Me.actsbtnPrevisualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'AcFecha
        '
        Me.AcFecha.ACFecha_A = New Date(2024, 3, 25, 15, 8, 55, 491)
        Me.AcFecha.ACFecha_De = New Date(2024, 3, 25, 15, 8, 55, 489)
        Me.AcFecha.ACFechaObligatoria = true
        Me.AcFecha.ACFormatoControl = ACControles.ACFecha.ACTipoFormatoControl.Horizontal
        Me.AcFecha.ACHoyChecked = false
        Me.AcFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.AcFecha.Location = New System.Drawing.Point(646, 0)
        Me.AcFecha.MaximumSize = New System.Drawing.Size(337, 43)
        Me.AcFecha.MinimumSize = New System.Drawing.Size(337, 43)
        Me.AcFecha.Name = "AcFecha"
        Me.AcFecha.Size = New System.Drawing.Size(337, 43)
        Me.AcFecha.TabIndex = 32
        Me.AcFecha.TabStop = false
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
        'TPedidoCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(991, 530)
        Me.Controls.Add(Me.tabMantenimiento)
        Me.Controls.Add(Me.acpnlTitulo)
        Me.Controls.Add(Me.acTool)
        Me.Name = "TPedidoCompra"
        Me.Text = "TPedidoCompra"
        Me.tabMantenimiento.ResumeLayout(false)
        Me.tabDatos.ResumeLayout(false)
        Me.pnlDetalle.ResumeLayout(false)
        Me.pnlDetalle.PerformLayout
        CType(Me.c1grdDetalle,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.bnavProductos,System.ComponentModel.ISupportInitialize).EndInit
        Me.bnavProductos.ResumeLayout(false)
        Me.bnavProductos.PerformLayout
        Me.tbcDetalles.ResumeLayout(false)
        Me.tpgDetAnulacion.ResumeLayout(false)
        Me.tpgDetAnulacion.PerformLayout
        Me.pnlItem.ResumeLayout(false)
        Me.pnlItem.PerformLayout
        Me.pnlPie.ResumeLayout(false)
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox1.PerformLayout
        Me.Panel1.ResumeLayout(false)
        Me.Panel1.PerformLayout
        Me.pnlCabecera.ResumeLayout(false)
        Me.pnlCabecera.PerformLayout
        Me.grpDocGuiaRemision.ResumeLayout(false)
        Me.grpDocGuiaRemision.PerformLayout
        Me.tabBusqueda.ResumeLayout(false)
        Me.tabBusqueda.PerformLayout
        CType(Me.c1grdBusqueda,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.bnavBusqueda,System.ComponentModel.ISupportInitialize).EndInit
        Me.bnavBusqueda.ResumeLayout(false)
        Me.bnavBusqueda.PerformLayout
        Me.GroupBox2.ResumeLayout(false)
        Me.GroupBox2.PerformLayout
        Me.acTool.ResumeLayout(false)
        Me.acTool.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Private WithEvents tabMantenimiento As Crownwood.DotNetMagic.Controls.TabControl
    Private WithEvents tabDatos As Crownwood.DotNetMagic.Controls.TabPage
    Friend WithEvents pnlDetalle As System.Windows.Forms.Panel
    Friend WithEvents c1grdDetalle As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents bnavProductos As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents tbcDetalles As Crownwood.DotNetMagic.Controls.TabControl
    Friend WithEvents tpgDetAnulacion As Crownwood.DotNetMagic.Controls.TabPage
    Friend WithEvents txtMotivoAnulacion As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaAnulacion As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents pnlItem As System.Windows.Forms.Panel
    Friend WithEvents actxnStockLocal As ACControles.ACTextBoxNumerico
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtUnidad As System.Windows.Forms.TextBox
    Friend WithEvents actxnPeso As ACControles.ACTextBoxNumerico
    Friend WithEvents txtOpcion As System.Windows.Forms.TextBox
    Friend WithEvents actxnCantidad As ACControles.ACTextBoxNumerico
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtProdDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents actxaProdCodigo As ACControles.ACTextBoxAyuda
    Friend WithEvents pnlPie As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtObservacion As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents actxnPesoTotal As ACControles.ACTextBoxNumerico
    Friend WithEvents lblTotalPagar As System.Windows.Forms.Label
    Friend WithEvents chkAtendida As System.Windows.Forms.CheckBox
    Friend WithEvents chkAnulada As System.Windows.Forms.CheckBox
    Friend WithEvents pnlCabecera As System.Windows.Forms.Panel
    Friend WithEvents grpDocGuiaRemision As System.Windows.Forms.GroupBox
    Friend WithEvents txtSerie As System.Windows.Forms.TextBox
    Friend WithEvents actxnNumero As ACControles.ACTextBoxNumerico
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Private WithEvents tabBusqueda As Crownwood.DotNetMagic.Controls.TabPage
    Friend WithEvents c1grdBusqueda As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents bnavBusqueda As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents acpnlTitulo As ACControles.ACPanelCaption
    Friend WithEvents acTool As ACControles.ACToolBarMantHorizontalNew
    Friend WithEvents acbtnSeleccionar As ACControles.ACToolStripButton
    Friend WithEvents actsbtnPrevisualizar As ACControles.ACToolStripButton
    Friend WithEvents actxaDescEncargado As ACControles.ACTextBoxAyuda
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents actxaCodEncargado As ACControles.ACTextBoxAyuda
    Private WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCBusqueda As ACControles.ACTextBoxAyuda
    Friend WithEvents rbtCCliente As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnCDocumento As System.Windows.Forms.RadioButton
    Friend WithEvents btnCConsulta As System.Windows.Forms.Button
    Friend WithEvents chkCTodos As System.Windows.Forms.CheckBox
    Friend WithEvents AcFecha As ACControles.ACFecha
    Friend WithEvents tsbtnExcel As System.Windows.Forms.ToolStripButton
End Class
