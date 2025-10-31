<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RIngresosvsCompras
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RIngresosvsCompras))
        Me.tstool = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnSalir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtngrabar = New System.Windows.Forms.ToolStripButton()
        Me.pnlCabecera = New System.Windows.Forms.Panel()
        Me.GRPVS = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.c1grdPuntosVentas = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.chkCTodos = New System.Windows.Forms.CheckBox()
        Me.grpproveedor = New System.Windows.Forms.GroupBox()
        Me.rbtnDocIngreso = New System.Windows.Forms.RadioButton()
        Me.rbtnDocCompra = New System.Windows.Forms.RadioButton()
        Me.rbtngDevolucion = New System.Windows.Forms.RadioButton()
        Me.rbtnproveedor = New System.Windows.Forms.RadioButton()
        Me.actxaProRazonSocial = New ACControles.ACTextBoxAyuda()
        Me.btnCargar = New System.Windows.Forms.Button()
        Me.AcFecha = New ACControles.ACFecha(Me.components)
        Me.acpnlTitulo = New ACControles.ACPanelCaption()
        Me.bnavCBusqueda = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.c1grdBusqueda = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.tstool.SuspendLayout()
        Me.pnlCabecera.SuspendLayout()
        Me.GRPVS.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.c1grdPuntosVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpproveedor.SuspendLayout()
        CType(Me.bnavCBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bnavCBusqueda.SuspendLayout()
        CType(Me.c1grdBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tstool
        '
        Me.tstool.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tstool.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tstool.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripSeparator1, Me.tsbtnSalir, Me.ToolStripSeparator2, Me.tsbtngrabar})
        Me.tstool.Location = New System.Drawing.Point(0, 571)
        Me.tstool.Name = "tstool"
        Me.tstool.Size = New System.Drawing.Size(1255, 39)
        Me.tstool.TabIndex = 10
        Me.tstool.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton1.Image = Global.ACPLogistica.My.Resources.Resources.Excel2_32x32
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(36, 36)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'tsbtnSalir
        '
        Me.tsbtnSalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbtnSalir.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsbtnSalir.Image = Global.ACPLogistica.My.Resources.Resources.Exit_32x32
        Me.tsbtnSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnSalir.Name = "tsbtnSalir"
        Me.tsbtnSalir.Size = New System.Drawing.Size(76, 36)
        Me.tsbtnSalir.Text = "Salir"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 39)
        '
        'tsbtngrabar
        '
        Me.tsbtngrabar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbtngrabar.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.tsbtngrabar.Image = Global.ACPLogistica.My.Resources.Resources.Grabar_32x32
        Me.tsbtngrabar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtngrabar.Name = "tsbtngrabar"
        Me.tsbtngrabar.Size = New System.Drawing.Size(94, 36)
        Me.tsbtngrabar.Text = "Grabar"
        '
        'pnlCabecera
        '
        Me.pnlCabecera.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.pnlCabecera.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlCabecera.Controls.Add(Me.GRPVS)
        Me.pnlCabecera.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlCabecera.Location = New System.Drawing.Point(0, 39)
        Me.pnlCabecera.Name = "pnlCabecera"
        Me.pnlCabecera.Size = New System.Drawing.Size(1255, 129)
        Me.pnlCabecera.TabIndex = 9
        '
        'GRPVS
        '
        Me.GRPVS.Controls.Add(Me.GroupBox3)
        Me.GRPVS.Controls.Add(Me.chkCTodos)
        Me.GRPVS.Controls.Add(Me.grpproveedor)
        Me.GRPVS.Controls.Add(Me.btnCargar)
        Me.GRPVS.Controls.Add(Me.AcFecha)
        Me.GRPVS.Dock = System.Windows.Forms.DockStyle.Top
        Me.GRPVS.Location = New System.Drawing.Point(0, 0)
        Me.GRPVS.Name = "GRPVS"
        Me.GRPVS.Size = New System.Drawing.Size(1253, 122)
        Me.GRPVS.TabIndex = 30
        Me.GRPVS.TabStop = False
        Me.GRPVS.Text = "Opciones de Busqueda "
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.c1grdPuntosVentas)
        Me.GroupBox3.Location = New System.Drawing.Point(651, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(248, 100)
        Me.GroupBox3.TabIndex = 30
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Almacenes"
        '
        'c1grdPuntosVentas
        '
        Me.c1grdPuntosVentas.ColumnInfo = "2,1,0,0,0,100,Columns:0{Width:25;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.c1grdPuntosVentas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.c1grdPuntosVentas.Location = New System.Drawing.Point(3, 16)
        Me.c1grdPuntosVentas.Name = "c1grdPuntosVentas"
        Me.c1grdPuntosVentas.Rows.Count = 2
        Me.c1grdPuntosVentas.Rows.DefaultSize = 20
        Me.c1grdPuntosVentas.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.c1grdPuntosVentas.Size = New System.Drawing.Size(242, 81)
        Me.c1grdPuntosVentas.StyleInfo = resources.GetString("c1grdPuntosVentas.StyleInfo")
        Me.c1grdPuntosVentas.TabIndex = 8
        '
        'chkCTodos
        '
        Me.chkCTodos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkCTodos.AutoSize = True
        Me.chkCTodos.Location = New System.Drawing.Point(1006, 92)
        Me.chkCTodos.Name = "chkCTodos"
        Me.chkCTodos.Size = New System.Drawing.Size(94, 17)
        Me.chkCTodos.TabIndex = 29
        Me.chkCTodos.Text = "Mostrar Todos"
        Me.chkCTodos.UseVisualStyleBackColor = True
        '
        'grpproveedor
        '
        Me.grpproveedor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpproveedor.Controls.Add(Me.rbtnDocIngreso)
        Me.grpproveedor.Controls.Add(Me.rbtnDocCompra)
        Me.grpproveedor.Controls.Add(Me.rbtngDevolucion)
        Me.grpproveedor.Controls.Add(Me.rbtnproveedor)
        Me.grpproveedor.Controls.Add(Me.actxaProRazonSocial)
        Me.grpproveedor.Location = New System.Drawing.Point(11, 39)
        Me.grpproveedor.Name = "grpproveedor"
        Me.grpproveedor.Size = New System.Drawing.Size(634, 73)
        Me.grpproveedor.TabIndex = 23
        Me.grpproveedor.TabStop = False
        Me.grpproveedor.Text = "Datos de Reistro "
        '
        'rbtnDocIngreso
        '
        Me.rbtnDocIngreso.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbtnDocIngreso.AutoSize = True
        Me.rbtnDocIngreso.Location = New System.Drawing.Point(168, 19)
        Me.rbtnDocIngreso.Name = "rbtnDocIngreso"
        Me.rbtnDocIngreso.Size = New System.Drawing.Size(86, 17)
        Me.rbtnDocIngreso.TabIndex = 25
        Me.rbtnDocIngreso.Text = "Doc. Ingreso"
        Me.rbtnDocIngreso.UseVisualStyleBackColor = True
        '
        'rbtnDocCompra
        '
        Me.rbtnDocCompra.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbtnDocCompra.AutoSize = True
        Me.rbtnDocCompra.Location = New System.Drawing.Point(280, 19)
        Me.rbtnDocCompra.Name = "rbtnDocCompra"
        Me.rbtnDocCompra.Size = New System.Drawing.Size(87, 17)
        Me.rbtnDocCompra.TabIndex = 24
        Me.rbtnDocCompra.Text = "Doc. Compra"
        Me.rbtnDocCompra.UseVisualStyleBackColor = True
        '
        'rbtngDevolucion
        '
        Me.rbtngDevolucion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbtngDevolucion.AutoSize = True
        Me.rbtngDevolucion.Location = New System.Drawing.Point(483, 19)
        Me.rbtngDevolucion.Name = "rbtngDevolucion"
        Me.rbtngDevolucion.Size = New System.Drawing.Size(113, 17)
        Me.rbtngDevolucion.TabIndex = 23
        Me.rbtngDevolucion.Text = "Nro G. Devolucion"
        Me.rbtngDevolucion.UseVisualStyleBackColor = True
        '
        'rbtnproveedor
        '
        Me.rbtnproveedor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbtnproveedor.AutoSize = True
        Me.rbtnproveedor.Checked = True
        Me.rbtnproveedor.Location = New System.Drawing.Point(384, 19)
        Me.rbtnproveedor.Name = "rbtnproveedor"
        Me.rbtnproveedor.Size = New System.Drawing.Size(93, 17)
        Me.rbtnproveedor.TabIndex = 22
        Me.rbtnproveedor.TabStop = True
        Me.rbtnproveedor.Text = "Por Proveedor"
        Me.rbtnproveedor.UseVisualStyleBackColor = True
        '
        'actxaProRazonSocial
        '
        Me.actxaProRazonSocial.ACActivarAyudaAuto = False
        Me.actxaProRazonSocial.ACLongitudAceptada = 0
        Me.actxaProRazonSocial.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.actxaProRazonSocial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.actxaProRazonSocial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.actxaProRazonSocial.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
        Me.actxaProRazonSocial.Location = New System.Drawing.Point(6, 43)
        Me.actxaProRazonSocial.MaxLength = 32767
        Me.actxaProRazonSocial.Name = "actxaProRazonSocial"
        Me.actxaProRazonSocial.Size = New System.Drawing.Size(622, 24)
        Me.actxaProRazonSocial.TabIndex = 14
        Me.actxaProRazonSocial.Tag = "EV"
        '
        'btnCargar
        '
        Me.btnCargar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCargar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCargar.Image = Global.ACPLogistica.My.Resources.Resources.Check_Proces_32x32
        Me.btnCargar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCargar.Location = New System.Drawing.Point(1117, 63)
        Me.btnCargar.Name = "btnCargar"
        Me.btnCargar.Size = New System.Drawing.Size(125, 46)
        Me.btnCargar.TabIndex = 20
        Me.btnCargar.Text = "Procesar "
        Me.btnCargar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCargar.UseVisualStyleBackColor = True
        '
        'AcFecha
        '
        Me.AcFecha.ACFecha_A = New Date(2025, 9, 4, 14, 56, 11, 359)
        Me.AcFecha.ACFecha_De = New Date(2025, 9, 4, 14, 56, 11, 355)
        Me.AcFecha.ACFechaObligatoria = True
        Me.AcFecha.ACFormatoControl = ACControles.ACFecha.ACTipoFormatoControl.Horizontal
        Me.AcFecha.ACHoyChecked = False
        Me.AcFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AcFecha.Location = New System.Drawing.Point(905, 11)
        Me.AcFecha.MaximumSize = New System.Drawing.Size(337, 43)
        Me.AcFecha.MinimumSize = New System.Drawing.Size(337, 43)
        Me.AcFecha.Name = "AcFecha"
        Me.AcFecha.Size = New System.Drawing.Size(337, 43)
        Me.AcFecha.TabIndex = 19
        Me.AcFecha.TabStop = False
        '
        'acpnlTitulo
        '
        Me.acpnlTitulo.ACCaption = "Compras Versus Ingresos almacen"
        Me.acpnlTitulo.BackColor = System.Drawing.Color.Red
        Me.acpnlTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.acpnlTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.acpnlTitulo.InactiveGradientHighColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(145, Byte), Integer))
        Me.acpnlTitulo.InactiveGradientLowColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.acpnlTitulo.Location = New System.Drawing.Point(0, 0)
        Me.acpnlTitulo.Name = "acpnlTitulo"
        Me.acpnlTitulo.Size = New System.Drawing.Size(1255, 39)
        Me.acpnlTitulo.TabIndex = 8
        '
        'bnavCBusqueda
        '
        Me.bnavCBusqueda.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.bnavCBusqueda.CountItem = Me.BindingNavigatorCountItem
        Me.bnavCBusqueda.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.bnavCBusqueda.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.bnavCBusqueda.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem})
        Me.bnavCBusqueda.Location = New System.Drawing.Point(0, 546)
        Me.bnavCBusqueda.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.bnavCBusqueda.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.bnavCBusqueda.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.bnavCBusqueda.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.bnavCBusqueda.Name = "bnavCBusqueda"
        Me.bnavCBusqueda.PositionItem = Me.BindingNavigatorPositionItem
        Me.bnavCBusqueda.Size = New System.Drawing.Size(1255, 25)
        Me.bnavCBusqueda.TabIndex = 12
        Me.bnavCBusqueda.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
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
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
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
        'c1grdBusqueda
        '
        Me.c1grdBusqueda.ColumnInfo = "2,1,0,0,0,90,Columns:0{Width:25;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.c1grdBusqueda.Dock = System.Windows.Forms.DockStyle.Fill
        Me.c1grdBusqueda.Location = New System.Drawing.Point(0, 168)
        Me.c1grdBusqueda.Name = "c1grdBusqueda"
        Me.c1grdBusqueda.Rows.Count = 2
        Me.c1grdBusqueda.Rows.DefaultSize = 18
        Me.c1grdBusqueda.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.c1grdBusqueda.Size = New System.Drawing.Size(1255, 378)
        Me.c1grdBusqueda.TabIndex = 13
        '
        'RIngresosvsCompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1255, 610)
        Me.Controls.Add(Me.c1grdBusqueda)
        Me.Controls.Add(Me.bnavCBusqueda)
        Me.Controls.Add(Me.tstool)
        Me.Controls.Add(Me.pnlCabecera)
        Me.Controls.Add(Me.acpnlTitulo)
        Me.Name = "RIngresosvsCompras"
        Me.Text = "RIngresosvsCompras"
        Me.tstool.ResumeLayout(False)
        Me.tstool.PerformLayout()
        Me.pnlCabecera.ResumeLayout(False)
        Me.GRPVS.ResumeLayout(False)
        Me.GRPVS.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.c1grdPuntosVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpproveedor.ResumeLayout(False)
        Me.grpproveedor.PerformLayout()
        CType(Me.bnavCBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bnavCBusqueda.ResumeLayout(False)
        Me.bnavCBusqueda.PerformLayout()
        CType(Me.c1grdBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout

End Sub
    Friend WithEvents tstool As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbtnSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents pnlCabecera As System.Windows.Forms.Panel
    Friend WithEvents AcFecha As ACControles.ACFecha
    Friend WithEvents acpnlTitulo As ACControles.ACPanelCaption
    Friend WithEvents rbtnproveedor As System.Windows.Forms.RadioButton
    Friend WithEvents grpproveedor As System.Windows.Forms.GroupBox
    Friend WithEvents actxaProRazonSocial As ACControles.ACTextBoxAyuda
    Friend WithEvents bnavCBusqueda As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents chkCTodos As System.Windows.Forms.CheckBox
    Private WithEvents GRPVS As System.Windows.Forms.GroupBox
    Friend WithEvents btnCargar As System.Windows.Forms.Button
    Friend WithEvents rbtnDocIngreso As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnDocCompra As System.Windows.Forms.RadioButton
    Friend WithEvents rbtngDevolucion As System.Windows.Forms.RadioButton
    Friend WithEvents c1grdBusqueda As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents tsbtngrabar As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents c1grdPuntosVentas As C1.Win.C1FlexGrid.C1FlexGrid
End Class
