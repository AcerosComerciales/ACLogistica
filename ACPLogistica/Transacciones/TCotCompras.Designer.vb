<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TCotCompras
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TCotCompras))
        Me.tabDatos = New Crownwood.DotNetMagic.Controls.TabPage()
        Me.pnlDetalle = New System.Windows.Forms.Panel()
        Me.c1grdDetalle = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.pnlItem = New System.Windows.Forms.Panel()
        Me.txtOpcion = New System.Windows.Forms.TextBox()
        Me.actxnProdCantidad = New ACControles.ACTextBoxNumerico()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtProdDescripcion = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.actxaProdCodigo = New ACControles.ACTextBoxAyuda()
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
        Me.pnlCabecera = New System.Windows.Forms.Panel()
        Me.grpCabCuerpo = New System.Windows.Forms.GroupBox()
        Me.txtAtencion = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.txtEMail = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnNuevoProveedor = New System.Windows.Forms.Button()
        Me.btnClean = New System.Windows.Forms.Button()
        Me.actxaProvRazonSocial = New ACControles.ACTextBoxAyuda()
        Me.actxaProvRuc = New ACControles.ACTextBoxAyuda()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pnlCabHeader = New System.Windows.Forms.Panel()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.actxaNroPedidoCompra = New ACControles.ACTextBoxAyuda()
        Me.dtpFecEmision = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlPie = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtObservacion = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.actxnPesoTotal = New ACControles.ACTextBoxNumerico()
        Me.lblTotalPagar = New System.Windows.Forms.Label()
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
        Me.grpBusqueda = New System.Windows.Forms.GroupBox()
        Me.chkAgrupar = New System.Windows.Forms.CheckBox()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.chkTodos = New System.Windows.Forms.CheckBox()
        Me.txtBusqueda = New ACControles.ACTextBoxAyuda()
        Me.rbtnNroCotizacion = New System.Windows.Forms.RadioButton()
        Me.rbtnCliente = New System.Windows.Forms.RadioButton()
        Me.AcFecha = New ACControles.ACFecha(Me.components)
        Me.tabMantenimiento = New Crownwood.DotNetMagic.Controls.TabControl()
        Me.acpnlTitulo = New ACControles.ACPanelCaption()
        Me.acTool = New ACControles.ACToolBarMantHorizontalNew(Me.components)
        Me.acbtnSeleccionar = New ACControles.ACToolStripButton(Me.components)
        Me.actsbtnPrevisualizar = New ACControles.ACToolStripButton(Me.components)
        Me.eprError = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.actxaCotizacionProveedor = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.tabDatos.SuspendLayout()
        Me.pnlDetalle.SuspendLayout()
        CType(Me.c1grdDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlItem.SuspendLayout()
        CType(Me.bnavProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bnavProductos.SuspendLayout()
        Me.pnlCabecera.SuspendLayout()
        Me.grpCabCuerpo.SuspendLayout()
        Me.pnlCabHeader.SuspendLayout()
        Me.pnlPie.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.tabBusqueda.SuspendLayout()
        CType(Me.c1grdBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bnavBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bnavBusqueda.SuspendLayout()
        Me.grpBusqueda.SuspendLayout()
        Me.tabMantenimiento.SuspendLayout()
        Me.acTool.SuspendLayout()
        CType(Me.eprError, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabDatos
        '
        Me.tabDatos.Controls.Add(Me.pnlDetalle)
        Me.tabDatos.Controls.Add(Me.pnlCabecera)
        Me.tabDatos.Controls.Add(Me.pnlPie)
        Me.tabDatos.InactiveBackColor = System.Drawing.Color.Empty
        Me.tabDatos.InactiveTextBackColor = System.Drawing.Color.Empty
        Me.tabDatos.InactiveTextColor = System.Drawing.Color.Empty
        Me.tabDatos.Location = New System.Drawing.Point(1, 1)
        Me.tabDatos.Name = "tabDatos"
        Me.tabDatos.SelectBackColor = System.Drawing.Color.Empty
        Me.tabDatos.SelectTextBackColor = System.Drawing.Color.Empty
        Me.tabDatos.SelectTextColor = System.Drawing.Color.Empty
        Me.tabDatos.Size = New System.Drawing.Size(882, 548)
        Me.tabDatos.TabIndex = 4
        Me.tabDatos.Title = "Datos"
        Me.tabDatos.ToolTip = "Datos"
        '
        'pnlDetalle
        '
        Me.pnlDetalle.Controls.Add(Me.c1grdDetalle)
        Me.pnlDetalle.Controls.Add(Me.pnlItem)
        Me.pnlDetalle.Controls.Add(Me.bnavProductos)
        Me.pnlDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDetalle.Location = New System.Drawing.Point(0, 151)
        Me.pnlDetalle.Name = "pnlDetalle"
        Me.pnlDetalle.Size = New System.Drawing.Size(882, 346)
        Me.pnlDetalle.TabIndex = 2
        '
        'c1grdDetalle
        '
        Me.c1grdDetalle.BackColor = System.Drawing.Color.White
        Me.c1grdDetalle.ColumnInfo = "2,1,0,0,0,105,Columns:0{Width:18;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:107;Caption:""Codigo"";}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.c1grdDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.c1grdDetalle.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.c1grdDetalle.Location = New System.Drawing.Point(0, 52)
        Me.c1grdDetalle.Name = "c1grdDetalle"
        Me.c1grdDetalle.Rows.Count = 2
        Me.c1grdDetalle.Rows.DefaultSize = 21
        Me.c1grdDetalle.Size = New System.Drawing.Size(882, 269)
        Me.c1grdDetalle.StyleInfo = resources.GetString("c1grdDetalle.StyleInfo")
        Me.c1grdDetalle.TabIndex = 1
        '
        'pnlItem
        '
        Me.pnlItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(145, Byte), Integer))
        Me.pnlItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlItem.Controls.Add(Me.txtOpcion)
        Me.pnlItem.Controls.Add(Me.actxnProdCantidad)
        Me.pnlItem.Controls.Add(Me.Label14)
        Me.pnlItem.Controls.Add(Me.txtProdDescripcion)
        Me.pnlItem.Controls.Add(Me.Label17)
        Me.pnlItem.Controls.Add(Me.Label18)
        Me.pnlItem.Controls.Add(Me.actxaProdCodigo)
        Me.pnlItem.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlItem.Location = New System.Drawing.Point(0, 0)
        Me.pnlItem.Name = "pnlItem"
        Me.pnlItem.Size = New System.Drawing.Size(882, 52)
        Me.pnlItem.TabIndex = 0
        '
        'txtOpcion
        '
        Me.txtOpcion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtOpcion.BackColor = System.Drawing.Color.Gainsboro
        Me.txtOpcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOpcion.Location = New System.Drawing.Point(848, 21)
        Me.txtOpcion.MaxLength = 1
        Me.txtOpcion.Name = "txtOpcion"
        Me.txtOpcion.Size = New System.Drawing.Size(25, 23)
        Me.txtOpcion.TabIndex = 10
        '
        'actxnProdCantidad
        '
        Me.actxnProdCantidad.ACEnteros = 9
        Me.actxnProdCantidad.ACEstandar = ACControles.ACEstandaresFormato.ACDecimal
        Me.actxnProdCantidad.ACFormato = ""
        Me.actxnProdCantidad.ACNegativo = True
        Me.actxnProdCantidad.ACValue = New Decimal(New Integer() {0, 0, 0, 131072})
        Me.actxnProdCantidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.actxnProdCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.actxnProdCantidad.Location = New System.Drawing.Point(737, 21)
        Me.actxnProdCantidad.MaxLength = 12
        Me.actxnProdCantidad.Name = "actxnProdCantidad"
        Me.actxnProdCantidad.Size = New System.Drawing.Size(110, 23)
        Me.actxnProdCantidad.TabIndex = 5
        Me.actxnProdCantidad.Tag = "EV"
        Me.actxnProdCantidad.Text = "0.00"
        Me.actxnProdCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(747, 5)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(57, 13)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "C&antidad"
        '
        'txtProdDescripcion
        '
        Me.txtProdDescripcion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtProdDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProdDescripcion.Location = New System.Drawing.Point(128, 21)
        Me.txtProdDescripcion.Name = "txtProdDescripcion"
        Me.txtProdDescripcion.ReadOnly = True
        Me.txtProdDescripcion.Size = New System.Drawing.Size(607, 23)
        Me.txtProdDescripcion.TabIndex = 3
        Me.txtProdDescripcion.Tag = "V"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(137, 5)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(72, 13)
        Me.Label17.TabIndex = 2
        Me.Label17.Text = "Descripcion"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(26, 5)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(45, 13)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "C&odigo"
        '
        'actxaProdCodigo
        '
        Me.actxaProdCodigo.ACActivarAyudaAuto = False
        Me.actxaProdCodigo.ACLongitudAceptada = 0
        Me.actxaProdCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.actxaProdCodigo.Location = New System.Drawing.Point(16, 21)
        Me.actxaProdCodigo.MaxLength = 32767
        Me.actxaProdCodigo.Name = "actxaProdCodigo"
        Me.actxaProdCodigo.Size = New System.Drawing.Size(110, 23)
        Me.actxaProdCodigo.TabIndex = 1
        Me.actxaProdCodigo.Tag = "EV"
        '
        'bnavProductos
        '
        Me.bnavProductos.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.bnavProductos.CountItem = Me.BindingNavigatorCountItem
        Me.bnavProductos.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.bnavProductos.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.bnavProductos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem})
        Me.bnavProductos.Location = New System.Drawing.Point(0, 321)
        Me.bnavProductos.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.bnavProductos.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.bnavProductos.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.bnavProductos.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.bnavProductos.Name = "bnavProductos"
        Me.bnavProductos.PositionItem = Me.BindingNavigatorPositionItem
        Me.bnavProductos.Size = New System.Drawing.Size(882, 25)
        Me.bnavProductos.TabIndex = 2
        Me.bnavProductos.Text = "BindingNavigator1"
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
        'pnlCabecera
        '
        Me.pnlCabecera.BackColor = System.Drawing.Color.LightSteelBlue
        Me.pnlCabecera.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlCabecera.Controls.Add(Me.grpCabCuerpo)
        Me.pnlCabecera.Controls.Add(Me.pnlCabHeader)
        Me.pnlCabecera.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlCabecera.Location = New System.Drawing.Point(0, 0)
        Me.pnlCabecera.Name = "pnlCabecera"
        Me.pnlCabecera.Size = New System.Drawing.Size(882, 151)
        Me.pnlCabecera.TabIndex = 1
        '
        'grpCabCuerpo
        '
        Me.grpCabCuerpo.Controls.Add(Me.txtAtencion)
        Me.grpCabCuerpo.Controls.Add(Me.Label8)
        Me.grpCabCuerpo.Controls.Add(Me.txtCodigo)
        Me.grpCabCuerpo.Controls.Add(Me.Label34)
        Me.grpCabCuerpo.Controls.Add(Me.txtEMail)
        Me.grpCabCuerpo.Controls.Add(Me.Label7)
        Me.grpCabCuerpo.Controls.Add(Me.txtTelefono)
        Me.grpCabCuerpo.Controls.Add(Me.Label6)
        Me.grpCabCuerpo.Controls.Add(Me.btnNuevoProveedor)
        Me.grpCabCuerpo.Controls.Add(Me.btnClean)
        Me.grpCabCuerpo.Controls.Add(Me.actxaProvRazonSocial)
        Me.grpCabCuerpo.Controls.Add(Me.actxaProvRuc)
        Me.grpCabCuerpo.Controls.Add(Me.Label3)
        Me.grpCabCuerpo.Controls.Add(Me.Label4)
        Me.grpCabCuerpo.Controls.Add(Me.txtDireccion)
        Me.grpCabCuerpo.Controls.Add(Me.Label5)
        Me.grpCabCuerpo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpCabCuerpo.Location = New System.Drawing.Point(0, 30)
        Me.grpCabCuerpo.Name = "grpCabCuerpo"
        Me.grpCabCuerpo.Size = New System.Drawing.Size(880, 119)
        Me.grpCabCuerpo.TabIndex = 1
        Me.grpCabCuerpo.TabStop = False
        Me.grpCabCuerpo.Tag = "EVO"
        '
        'txtAtencion
        '
        Me.txtAtencion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAtencion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAtencion.Location = New System.Drawing.Point(751, 92)
        Me.txtAtencion.Name = "txtAtencion"
        Me.txtAtencion.ReadOnly = True
        Me.txtAtencion.Size = New System.Drawing.Size(119, 23)
        Me.txtAtencion.TabIndex = 13
        Me.txtAtencion.Tag = "EV"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(689, 96)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 15)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Atención :"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(87, 12)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Size = New System.Drawing.Size(122, 23)
        Me.txtCodigo.TabIndex = 1
        Me.txtCodigo.Tag = "V"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(34, 17)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(47, 13)
        Me.Label34.TabIndex = 0
        Me.Label34.Text = "Codigo :"
        '
        'txtEMail
        '
        Me.txtEMail.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEMail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEMail.Location = New System.Drawing.Point(315, 92)
        Me.txtEMail.Name = "txtEMail"
        Me.txtEMail.ReadOnly = True
        Me.txtEMail.Size = New System.Drawing.Size(362, 23)
        Me.txtEMail.TabIndex = 11
        Me.txtEMail.Tag = "EV"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(267, 96)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 15)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "EMail :"
        '
        'txtTelefono
        '
        Me.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTelefono.Location = New System.Drawing.Point(88, 92)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.ReadOnly = True
        Me.txtTelefono.Size = New System.Drawing.Size(122, 23)
        Me.txtTelefono.TabIndex = 9
        Me.txtTelefono.Tag = "EV"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(22, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 15)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Telefono :"
        '
        'btnNuevoProveedor
        '
        Me.btnNuevoProveedor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNuevoProveedor.Image = Global.ACPLogistica.My.Resources.Resources.Nuevo_16x16
        Me.btnNuevoProveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNuevoProveedor.Location = New System.Drawing.Point(799, 36)
        Me.btnNuevoProveedor.Name = "btnNuevoProveedor"
        Me.btnNuevoProveedor.Size = New System.Drawing.Size(30, 27)
        Me.btnNuevoProveedor.TabIndex = 4
        Me.btnNuevoProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNuevoProveedor.UseVisualStyleBackColor = True
        '
        'btnClean
        '
        Me.btnClean.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClean.Image = Global.ACPLogistica.My.Resources.Resources.Delete_16x16
        Me.btnClean.Location = New System.Drawing.Point(835, 36)
        Me.btnClean.Name = "btnClean"
        Me.btnClean.Size = New System.Drawing.Size(36, 27)
        Me.btnClean.TabIndex = 5
        Me.btnClean.UseVisualStyleBackColor = True
        '
        'actxaProvRazonSocial
        '
        Me.actxaProvRazonSocial.ACActivarAyudaAuto = False
        Me.actxaProvRazonSocial.ACLongitudAceptada = 0
        Me.actxaProvRazonSocial.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.actxaProvRazonSocial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.actxaProvRazonSocial.Location = New System.Drawing.Point(315, 38)
        Me.actxaProvRazonSocial.MaxLength = 32767
        Me.actxaProvRazonSocial.Name = "actxaProvRazonSocial"
        Me.actxaProvRazonSocial.Size = New System.Drawing.Size(464, 23)
        Me.actxaProvRazonSocial.TabIndex = 3
        Me.actxaProvRazonSocial.Tag = "EVO"
        '
        'actxaProvRuc
        '
        Me.actxaProvRuc.ACActivarAyudaAuto = False
        Me.actxaProvRuc.ACLongitudAceptada = 0
        Me.actxaProvRuc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.actxaProvRuc.Location = New System.Drawing.Point(88, 38)
        Me.actxaProvRuc.MaxLength = 32767
        Me.actxaProvRuc.Name = "actxaProvRuc"
        Me.actxaProvRuc.Size = New System.Drawing.Size(122, 23)
        Me.actxaProvRuc.TabIndex = 1
        Me.actxaProvRuc.Tag = "EVO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(230, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "&Razon Social :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 15)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Doc / R.U.C. :"
        '
        'txtDireccion
        '
        Me.txtDireccion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDireccion.Location = New System.Drawing.Point(88, 66)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.ReadOnly = True
        Me.txtDireccion.Size = New System.Drawing.Size(691, 23)
        Me.txtDireccion.TabIndex = 7
        Me.txtDireccion.Tag = "EV"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 70)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 15)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Dirección :"
        '
        'pnlCabHeader
        '
        Me.pnlCabHeader.Controls.Add(Me.actxaCotizacionProveedor)
        Me.pnlCabHeader.Controls.Add(Me.Label21)
        Me.pnlCabHeader.Controls.Add(Me.Label28)
        Me.pnlCabHeader.Controls.Add(Me.actxaNroPedidoCompra)
        Me.pnlCabHeader.Controls.Add(Me.dtpFecEmision)
        Me.pnlCabHeader.Controls.Add(Me.Label1)
        Me.pnlCabHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlCabHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlCabHeader.Name = "pnlCabHeader"
        Me.pnlCabHeader.Size = New System.Drawing.Size(880, 30)
        Me.pnlCabHeader.TabIndex = 0
        '
        'Label21
        '
        Me.Label21.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label21.Location = New System.Drawing.Point(647, 6)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(107, 13)
        Me.Label21.TabIndex = 23
        Me.Label21.Text = "Nro. Pedido Compra:"
        '
        'actxaNroPedidoCompra
        '
        Me.actxaNroPedidoCompra.ACActivarAyudaAuto = False
        Me.actxaNroPedidoCompra.ACLongitudAceptada = 0
        Me.actxaNroPedidoCompra.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.actxaNroPedidoCompra.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.actxaNroPedidoCompra.Location = New System.Drawing.Point(758, 3)
        Me.actxaNroPedidoCompra.MaxLength = 32767
        Me.actxaNroPedidoCompra.Name = "actxaNroPedidoCompra"
        Me.actxaNroPedidoCompra.Size = New System.Drawing.Size(119, 23)
        Me.actxaNroPedidoCompra.TabIndex = 24
        Me.actxaNroPedidoCompra.Tag = "EV"
        '
        'dtpFecEmision
        '
        Me.dtpFecEmision.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecEmision.Location = New System.Drawing.Point(98, 3)
        Me.dtpFecEmision.Name = "dtpFecEmision"
        Me.dtpFecEmision.Size = New System.Drawing.Size(100, 23)
        Me.dtpFecEmision.TabIndex = 22
        Me.dtpFecEmision.Tag = "E"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 15)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Fecha Emi&sion :"
        '
        'pnlPie
        '
        Me.pnlPie.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(145, Byte), Integer))
        Me.pnlPie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlPie.Controls.Add(Me.GroupBox1)
        Me.pnlPie.Controls.Add(Me.Panel1)
        Me.pnlPie.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlPie.Location = New System.Drawing.Point(0, 497)
        Me.pnlPie.Name = "pnlPie"
        Me.pnlPie.Size = New System.Drawing.Size(882, 51)
        Me.pnlPie.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(145, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.txtObservacion)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(7, 1, 9, 3)
        Me.GroupBox1.Size = New System.Drawing.Size(455, 49)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Observaciones"
        '
        'txtObservacion
        '
        Me.txtObservacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtObservacion.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservacion.Location = New System.Drawing.Point(7, 17)
        Me.txtObservacion.Multiline = True
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservacion.Size = New System.Drawing.Size(439, 29)
        Me.txtObservacion.TabIndex = 0
        Me.txtObservacion.Tag = "EV"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.actxnPesoTotal)
        Me.Panel1.Controls.Add(Me.lblTotalPagar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(455, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(425, 49)
        Me.Panel1.TabIndex = 7
        '
        'actxnPesoTotal
        '
        Me.actxnPesoTotal.ACEnteros = 9
        Me.actxnPesoTotal.ACEstandar = ACControles.ACEstandaresFormato.ACDecimal
        Me.actxnPesoTotal.ACNegativo = True
        Me.actxnPesoTotal.ACValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.actxnPesoTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.actxnPesoTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.actxnPesoTotal.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
        Me.actxnPesoTotal.Location = New System.Drawing.Point(284, 10)
        Me.actxnPesoTotal.MaxLength = 12
        Me.actxnPesoTotal.Name = "actxnPesoTotal"
        Me.actxnPesoTotal.ReadOnly = True
        Me.actxnPesoTotal.Size = New System.Drawing.Size(132, 26)
        Me.actxnPesoTotal.TabIndex = 4
        Me.actxnPesoTotal.Tag = "EVO"
        Me.actxnPesoTotal.Text = "0.00"
        Me.actxnPesoTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblTotalPagar
        '
        Me.lblTotalPagar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotalPagar.AutoSize = True
        Me.lblTotalPagar.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
        Me.lblTotalPagar.ForeColor = System.Drawing.Color.White
        Me.lblTotalPagar.Location = New System.Drawing.Point(183, 13)
        Me.lblTotalPagar.Name = "lblTotalPagar"
        Me.lblTotalPagar.Size = New System.Drawing.Size(80, 17)
        Me.lblTotalPagar.TabIndex = 3
        Me.lblTotalPagar.Text = "Peso Total :"
        '
        'tabBusqueda
        '
        Me.tabBusqueda.Controls.Add(Me.c1grdBusqueda)
        Me.tabBusqueda.Controls.Add(Me.bnavBusqueda)
        Me.tabBusqueda.Controls.Add(Me.grpBusqueda)
        Me.tabBusqueda.InactiveBackColor = System.Drawing.Color.Empty
        Me.tabBusqueda.InactiveTextBackColor = System.Drawing.Color.Empty
        Me.tabBusqueda.InactiveTextColor = System.Drawing.Color.Empty
        Me.tabBusqueda.Location = New System.Drawing.Point(1, 1)
        Me.tabBusqueda.Name = "tabBusqueda"
        Me.tabBusqueda.SelectBackColor = System.Drawing.Color.Empty
        Me.tabBusqueda.Selected = False
        Me.tabBusqueda.SelectTextBackColor = System.Drawing.Color.Empty
        Me.tabBusqueda.SelectTextColor = System.Drawing.Color.Empty
        Me.tabBusqueda.Size = New System.Drawing.Size(882, 548)
        Me.tabBusqueda.TabIndex = 5
        Me.tabBusqueda.Title = "Busqueda"
        Me.tabBusqueda.ToolTip = "Busqueda"
        '
        'c1grdBusqueda
        '
        Me.c1grdBusqueda.ColumnInfo = "2,1,0,0,0,100,Columns:0{Width:25;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.c1grdBusqueda.Dock = System.Windows.Forms.DockStyle.Fill
        Me.c1grdBusqueda.Location = New System.Drawing.Point(0, 71)
        Me.c1grdBusqueda.Name = "c1grdBusqueda"
        Me.c1grdBusqueda.Rows.Count = 2
        Me.c1grdBusqueda.Rows.DefaultSize = 20
        Me.c1grdBusqueda.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.c1grdBusqueda.Size = New System.Drawing.Size(882, 452)
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
        Me.bnavBusqueda.Location = New System.Drawing.Point(0, 523)
        Me.bnavBusqueda.MoveFirstItem = Me.ToolStripButton3
        Me.bnavBusqueda.MoveLastItem = Me.ToolStripButton6
        Me.bnavBusqueda.MoveNextItem = Me.ToolStripButton5
        Me.bnavBusqueda.MovePreviousItem = Me.ToolStripButton4
        Me.bnavBusqueda.Name = "bnavBusqueda"
        Me.bnavBusqueda.PositionItem = Me.ToolStripTextBox1
        Me.bnavBusqueda.Size = New System.Drawing.Size(882, 25)
        Me.bnavBusqueda.TabIndex = 2
        Me.bnavBusqueda.Text = "BindingNavigator1"
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
        Me.ToolStripLabel1.Size = New System.Drawing.Size(37, 22)
        Me.ToolStripLabel1.Text = "de {0}"
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
        'grpBusqueda
        '
        Me.grpBusqueda.Controls.Add(Me.chkAgrupar)
        Me.grpBusqueda.Controls.Add(Me.btnConsultar)
        Me.grpBusqueda.Controls.Add(Me.chkTodos)
        Me.grpBusqueda.Controls.Add(Me.txtBusqueda)
        Me.grpBusqueda.Controls.Add(Me.rbtnNroCotizacion)
        Me.grpBusqueda.Controls.Add(Me.rbtnCliente)
        Me.grpBusqueda.Controls.Add(Me.AcFecha)
        Me.grpBusqueda.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpBusqueda.Location = New System.Drawing.Point(0, 0)
        Me.grpBusqueda.Name = "grpBusqueda"
        Me.grpBusqueda.Size = New System.Drawing.Size(882, 71)
        Me.grpBusqueda.TabIndex = 0
        Me.grpBusqueda.TabStop = False
        Me.grpBusqueda.Text = "Opciones de Busqueda"
        '
        'chkAgrupar
        '
        Me.chkAgrupar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkAgrupar.AutoSize = True
        Me.chkAgrupar.Location = New System.Drawing.Point(354, 19)
        Me.chkAgrupar.Name = "chkAgrupar"
        Me.chkAgrupar.Size = New System.Drawing.Size(69, 19)
        Me.chkAgrupar.TabIndex = 31
        Me.chkAgrupar.Text = "Agrupar"
        Me.chkAgrupar.UseVisualStyleBackColor = True
        '
        'btnConsultar
        '
        Me.btnConsultar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnConsultar.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.btnConsultar.Image = Global.ACPLogistica.My.Resources.Resources.Search_files_32x32
        Me.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConsultar.Location = New System.Drawing.Point(440, 13)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(99, 42)
        Me.btnConsultar.TabIndex = 30
        Me.btnConsultar.Text = "Consultar"
        Me.btnConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'chkTodos
        '
        Me.chkTodos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkTodos.AutoSize = True
        Me.chkTodos.Location = New System.Drawing.Point(247, 19)
        Me.chkTodos.Name = "chkTodos"
        Me.chkTodos.Size = New System.Drawing.Size(101, 19)
        Me.chkTodos.TabIndex = 4
        Me.chkTodos.Text = "Mostrar Todos"
        Me.chkTodos.UseVisualStyleBackColor = True
        '
        'txtBusqueda
        '
        Me.txtBusqueda.ACActivarAyudaAuto = False
        Me.txtBusqueda.ACLongitudAceptada = 0
        Me.txtBusqueda.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBusqueda.Location = New System.Drawing.Point(10, 41)
        Me.txtBusqueda.MaxLength = 32767
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(413, 23)
        Me.txtBusqueda.TabIndex = 0
        '
        'rbtnNroCotizacion
        '
        Me.rbtnNroCotizacion.AutoSize = True
        Me.rbtnNroCotizacion.Location = New System.Drawing.Point(83, 19)
        Me.rbtnNroCotizacion.Name = "rbtnNroCotizacion"
        Me.rbtnNroCotizacion.Size = New System.Drawing.Size(104, 19)
        Me.rbtnNroCotizacion.TabIndex = 2
        Me.rbtnNroCotizacion.Text = "Nro Cotización"
        Me.rbtnNroCotizacion.UseVisualStyleBackColor = True
        '
        'rbtnCliente
        '
        Me.rbtnCliente.AutoSize = True
        Me.rbtnCliente.Checked = True
        Me.rbtnCliente.Location = New System.Drawing.Point(10, 19)
        Me.rbtnCliente.Name = "rbtnCliente"
        Me.rbtnCliente.Size = New System.Drawing.Size(62, 19)
        Me.rbtnCliente.TabIndex = 1
        Me.rbtnCliente.TabStop = True
        Me.rbtnCliente.Text = "Cliente"
        Me.rbtnCliente.UseVisualStyleBackColor = True
        '
        'AcFecha
        '
        Me.AcFecha.ACFecha_A = New Date(2025, 9, 20, 12, 40, 13, 617)
        Me.AcFecha.ACFecha_De = New Date(2025, 9, 20, 12, 40, 13, 606)
        Me.AcFecha.ACFechaObligatoria = True
        Me.AcFecha.ACFormatoControl = ACControles.ACFecha.ACTipoFormatoControl.Horizontal
        Me.AcFecha.ACHoyChecked = False
        Me.AcFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AcFecha.Location = New System.Drawing.Point(545, 0)
        Me.AcFecha.MaximumSize = New System.Drawing.Size(337, 43)
        Me.AcFecha.MinimumSize = New System.Drawing.Size(337, 43)
        Me.AcFecha.Name = "AcFecha"
        Me.AcFecha.Size = New System.Drawing.Size(337, 43)
        Me.AcFecha.TabIndex = 3
        Me.AcFecha.TabStop = False
        '
        'tabMantenimiento
        '
        Me.tabMantenimiento.BackColor = System.Drawing.Color.LightSteelBlue
        Me.tabMantenimiento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tabMantenimiento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabMantenimiento.Location = New System.Drawing.Point(0, 32)
        Me.tabMantenimiento.MediaPlayerDockSides = False
        Me.tabMantenimiento.Name = "tabMantenimiento"
        Me.tabMantenimiento.OfficeDockSides = False
        Me.tabMantenimiento.SelectedIndex = 0
        Me.tabMantenimiento.ShowDropSelect = False
        Me.tabMantenimiento.Size = New System.Drawing.Size(884, 573)
        Me.tabMantenimiento.TabIndex = 0
        Me.tabMantenimiento.TabPages.AddRange(New Crownwood.DotNetMagic.Controls.TabPage() {Me.tabDatos, Me.tabBusqueda})
        Me.tabMantenimiento.TextTips = True
        '
        'acpnlTitulo
        '
        Me.acpnlTitulo.ACCaption = "Cotización de Compras"
        Me.acpnlTitulo.BackColor = System.Drawing.Color.Red
        Me.acpnlTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.acpnlTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.acpnlTitulo.InactiveGradientHighColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(145, Byte), Integer))
        Me.acpnlTitulo.InactiveGradientLowColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.acpnlTitulo.Location = New System.Drawing.Point(0, 0)
        Me.acpnlTitulo.Name = "acpnlTitulo"
        Me.acpnlTitulo.Size = New System.Drawing.Size(884, 32)
        Me.acpnlTitulo.TabIndex = 1
        '
        'acTool
        '
        Me.acTool.ACBtnBuscarEnabled = False
        Me.acTool.ACBtnBuscarVisible = False
        Me.acTool.ACBtnCancelarEnabled = False
        Me.acTool.ACBtnCancelarText = "&Volver"
        Me.acTool.ACBtnCancelarVisible = False
        Me.acTool.ACBtnEliminarEnabled = False
        Me.acTool.ACBtnEliminarVisible = False
        Me.acTool.ACBtnGrabarEnabled = False
        Me.acTool.ACBtnGrabarVisible = False
        Me.acTool.ACBtnRehusarEnabled = False
        Me.acTool.ACBtnRehusarVisible = False
        Me.acTool.ACBtnReporteEnabled = False
        Me.acTool.ACBtnReporteVisible = False
        Me.acTool.ACBtnSalirText = "&Salir"
        Me.acTool.ACBtnVolverEnabled = False
        Me.acTool.ACBtnVolverVisible = False
        Me.acTool.ACTipoToolBar = ACControles.ACToolBarMantHorizontalNew.tipoToolBar.ToolNuevoGrabarAnularImprimir
        Me.acTool.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.acTool.Font = New System.Drawing.Font("Tahoma", 9.5!)
        Me.acTool.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.acTool.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.acbtnSeleccionar, Me.actsbtnPrevisualizar})
        Me.acTool.Location = New System.Drawing.Point(0, 605)
        Me.acTool.Name = "acTool"
        Me.acTool.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.acTool.Size = New System.Drawing.Size(884, 56)
        Me.acTool.TabIndex = 2
        Me.acTool.Text = "AcToolBarMantHorizontalNew1"
        '
        'acbtnSeleccionar
        '
        Me.acbtnSeleccionar.AutoSize = False
        Me.acbtnSeleccionar.Image = Global.ACPLogistica.My.Resources.Resources.Aceptar_32x32
        Me.acbtnSeleccionar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.acbtnSeleccionar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.acbtnSeleccionar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.acbtnSeleccionar.Name = "tsbBoton"
        Me.acbtnSeleccionar.Size = New System.Drawing.Size(84, 53)
        Me.acbtnSeleccionar.Text = "&Seleccionar"
        Me.acbtnSeleccionar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.acbtnSeleccionar.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        Me.acbtnSeleccionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.acbtnSeleccionar.Visible = False
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
        Me.actsbtnPrevisualizar.Text = "Pre&visualizar"
        Me.actsbtnPrevisualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.actsbtnPrevisualizar.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        Me.actsbtnPrevisualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'eprError
        '
        Me.eprError.ContainerControl = Me
        '
        'actxaCotizacionProveedor
        '
        Me.actxaCotizacionProveedor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.actxaCotizacionProveedor.Location = New System.Drawing.Point(432, 4)
        Me.actxaCotizacionProveedor.Name = "actxaCotizacionProveedor"
        Me.actxaCotizacionProveedor.Size = New System.Drawing.Size(209, 23)
        Me.actxaCotizacionProveedor.TabIndex = 15
        Me.actxaCotizacionProveedor.Tag = "EVO"
        '
        'Label28
        '
        Me.Label28.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(286, 6)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(140, 15)
        Me.Label28.TabIndex = 14
        Me.Label28.Text = "Nº Cotizacion Proveedor:"
        '
        'TCotCompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 661)
        Me.Controls.Add(Me.tabMantenimiento)
        Me.Controls.Add(Me.acpnlTitulo)
        Me.Controls.Add(Me.acTool)
        Me.Name = "TCotCompras"
        Me.Text = "Cotización y Pedidos"
        Me.tabDatos.ResumeLayout(false)
        Me.pnlDetalle.ResumeLayout(false)
        Me.pnlDetalle.PerformLayout
        CType(Me.c1grdDetalle,System.ComponentModel.ISupportInitialize).EndInit
        Me.pnlItem.ResumeLayout(false)
        Me.pnlItem.PerformLayout
        CType(Me.bnavProductos,System.ComponentModel.ISupportInitialize).EndInit
        Me.bnavProductos.ResumeLayout(false)
        Me.bnavProductos.PerformLayout
        Me.pnlCabecera.ResumeLayout(false)
        Me.grpCabCuerpo.ResumeLayout(false)
        Me.grpCabCuerpo.PerformLayout
        Me.pnlCabHeader.ResumeLayout(false)
        Me.pnlCabHeader.PerformLayout
        Me.pnlPie.ResumeLayout(false)
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox1.PerformLayout
        Me.Panel1.ResumeLayout(false)
        Me.Panel1.PerformLayout
        Me.tabBusqueda.ResumeLayout(false)
        Me.tabBusqueda.PerformLayout
        CType(Me.c1grdBusqueda,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.bnavBusqueda,System.ComponentModel.ISupportInitialize).EndInit
        Me.bnavBusqueda.ResumeLayout(false)
        Me.bnavBusqueda.PerformLayout
        Me.grpBusqueda.ResumeLayout(false)
        Me.grpBusqueda.PerformLayout
        Me.tabMantenimiento.ResumeLayout(false)
        Me.acTool.ResumeLayout(false)
        Me.acTool.PerformLayout
        CType(Me.eprError,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
   Friend WithEvents acTool As ACControles.ACToolBarMantHorizontalNew
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
   Friend WithEvents pnlCabecera As System.Windows.Forms.Panel
   Friend WithEvents Label5 As System.Windows.Forms.Label
   Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
   Friend WithEvents Label4 As System.Windows.Forms.Label
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents dtpFecEmision As System.Windows.Forms.DateTimePicker
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Private WithEvents tabBusqueda As Crownwood.DotNetMagic.Controls.TabPage
   Friend WithEvents acpnlTitulo As ACControles.ACPanelCaption
   Private WithEvents tabMantenimiento As Crownwood.DotNetMagic.Controls.TabControl
   Friend WithEvents actxaProvRazonSocial As ACControles.ACTextBoxAyuda
   Friend WithEvents actxaProvRuc As ACControles.ACTextBoxAyuda
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
   Private WithEvents grpBusqueda As System.Windows.Forms.GroupBox
   Friend WithEvents rbtnNroCotizacion As System.Windows.Forms.RadioButton
   Friend WithEvents rbtnCliente As System.Windows.Forms.RadioButton
   Friend WithEvents AcFecha As ACControles.ACFecha
   Friend WithEvents pnlCabHeader As System.Windows.Forms.Panel
   Friend WithEvents grpCabCuerpo As System.Windows.Forms.GroupBox
   Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
   Friend WithEvents Label34 As System.Windows.Forms.Label
   Friend WithEvents pnlItem As System.Windows.Forms.Panel
   Friend WithEvents txtOpcion As System.Windows.Forms.TextBox
   Friend WithEvents actxnProdCantidad As ACControles.ACTextBoxNumerico
   Friend WithEvents Label14 As System.Windows.Forms.Label
   Friend WithEvents txtProdDescripcion As System.Windows.Forms.TextBox
   Friend WithEvents Label17 As System.Windows.Forms.Label
   Friend WithEvents Label18 As System.Windows.Forms.Label
   Friend WithEvents actxaProdCodigo As ACControles.ACTextBoxAyuda
   Friend WithEvents txtBusqueda As ACControles.ACTextBoxAyuda
   Friend WithEvents actsbtnPrevisualizar As ACControles.ACToolStripButton
   Friend WithEvents btnClean As System.Windows.Forms.Button
   Friend WithEvents btnNuevoProveedor As System.Windows.Forms.Button
   Friend WithEvents txtAtencion As System.Windows.Forms.TextBox
   Friend WithEvents Label8 As System.Windows.Forms.Label
   Friend WithEvents txtEMail As System.Windows.Forms.TextBox
   Friend WithEvents Label7 As System.Windows.Forms.Label
   Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
   Friend WithEvents Label6 As System.Windows.Forms.Label
   Friend WithEvents chkTodos As System.Windows.Forms.CheckBox
    Friend WithEvents acbtnSeleccionar As ACControles.ACToolStripButton
   Friend WithEvents btnConsultar As System.Windows.Forms.Button
   Friend WithEvents chkAgrupar As System.Windows.Forms.CheckBox
   Friend WithEvents eprError As System.Windows.Forms.ErrorProvider
   Friend WithEvents pnlPie As System.Windows.Forms.Panel
   Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
   Friend WithEvents txtObservacion As System.Windows.Forms.TextBox
   Friend WithEvents Panel1 As System.Windows.Forms.Panel
   Friend WithEvents actxnPesoTotal As ACControles.ACTextBoxNumerico
   Friend WithEvents lblTotalPagar As System.Windows.Forms.Label
   Friend WithEvents Label21 As System.Windows.Forms.Label
   Friend WithEvents actxaNroPedidoCompra As ACControles.ACTextBoxAyuda
    Friend WithEvents actxaCotizacionProveedor As TextBox
    Friend WithEvents Label28 As Label
End Class
