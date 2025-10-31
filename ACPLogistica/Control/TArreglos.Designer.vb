<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TArreglos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TArreglos))
        Me.acpnlTitulo = New ACControles.ACPanelCaption()
        Me.tabMantenimiento = New Crownwood.DotNetMagic.Controls.TabControl()
        Me.tabDatos = New Crownwood.DotNetMagic.Controls.TabPage()
        Me.pnlDetalle = New System.Windows.Forms.Panel()
        Me.c1grdDetalle = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.bnavDetArreglos = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.pnlItem = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtUnidad = New System.Windows.Forms.TextBox()
        Me.txtOpcion = New System.Windows.Forms.TextBox()
        Me.actxnCantidad = New ACControles.ACTextBoxNumerico()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtProdDescripcion = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.actxaProdCodigo = New ACControles.ACTextBoxAyuda()
        Me.pnlPie = New System.Windows.Forms.Panel()
        Me.chkAnulada = New System.Windows.Forms.CheckBox()
        Me.actxnPesoTotal = New ACControles.ACTextBoxNumerico()
        Me.lblTotalPagar = New System.Windows.Forms.Label()
        Me.txtDocReferencia = New System.Windows.Forms.TextBox()
        Me.actxaCodReferencia = New ACControles.ACTextBoxAyuda()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pnlCabecera = New System.Windows.Forms.Panel()
        Me.actxnNumero = New ACControles.ACTextBoxNumerico()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtSerie = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpFechaIngreso = New System.Windows.Forms.DateTimePicker()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbTArreglo = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
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
        Me.grpBusqueda = New System.Windows.Forms.GroupBox()
        Me.rbtnFecha = New System.Windows.Forms.RadioButton()
        Me.rbtnCodigo = New System.Windows.Forms.RadioButton()
        Me.txtBusqueda = New ACControles.ACTextBoxAyuda()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.AcFecha = New ACControles.ACFecha(Me.components)
        Me.acTool = New ACControles.ACToolBarMantHorizontalNew(Me.components)
        Me.actsbtnPrevisualizar = New ACControles.ACToolStripButton(Me.components)
        Me.tabMantenimiento.SuspendLayout
        Me.tabDatos.SuspendLayout
        Me.pnlDetalle.SuspendLayout
        CType(Me.c1grdDetalle,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.bnavDetArreglos,System.ComponentModel.ISupportInitialize).BeginInit
        Me.bnavDetArreglos.SuspendLayout
        Me.pnlItem.SuspendLayout
        Me.pnlPie.SuspendLayout
        Me.pnlCabecera.SuspendLayout
        Me.tabBusqueda.SuspendLayout
        CType(Me.c1grdBusqueda,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.bnavBusqueda,System.ComponentModel.ISupportInitialize).BeginInit
        Me.bnavBusqueda.SuspendLayout
        Me.grpBusqueda.SuspendLayout
        Me.acTool.SuspendLayout
        Me.SuspendLayout
        '
        'acpnlTitulo
        '
        Me.acpnlTitulo.ACCaption = "Arreglo de Inventario"
        Me.acpnlTitulo.BackColor = System.Drawing.Color.Red
        Me.acpnlTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.acpnlTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.acpnlTitulo.InactiveGradientHighColor = System.Drawing.Color.FromArgb(CType(CType(3,Byte),Integer), CType(CType(55,Byte),Integer), CType(CType(145,Byte),Integer))
        Me.acpnlTitulo.InactiveGradientLowColor = System.Drawing.Color.FromArgb(CType(CType(90,Byte),Integer), CType(CType(135,Byte),Integer), CType(CType(215,Byte),Integer))
        Me.acpnlTitulo.Location = New System.Drawing.Point(0, 0)
        Me.acpnlTitulo.Name = "acpnlTitulo"
        Me.acpnlTitulo.Size = New System.Drawing.Size(992, 39)
        Me.acpnlTitulo.TabIndex = 2
        '
        'tabMantenimiento
        '
        Me.tabMantenimiento.BackColor = System.Drawing.Color.LightSteelBlue
        Me.tabMantenimiento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tabMantenimiento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabMantenimiento.Location = New System.Drawing.Point(0, 39)
        Me.tabMantenimiento.MediaPlayerDockSides = false
        Me.tabMantenimiento.Name = "tabMantenimiento"
        Me.tabMantenimiento.OfficeDockSides = false
        Me.tabMantenimiento.SelectedIndex = 0
        Me.tabMantenimiento.ShowDropSelect = false
        Me.tabMantenimiento.Size = New System.Drawing.Size(992, 546)
        Me.tabMantenimiento.TabIndex = 9
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
        Me.tabDatos.Size = New System.Drawing.Size(990, 521)
        Me.tabDatos.TabIndex = 4
        Me.tabDatos.Title = "Datos"
        Me.tabDatos.ToolTip = "Datos"
        '
        'pnlDetalle
        '
        Me.pnlDetalle.Controls.Add(Me.c1grdDetalle)
        Me.pnlDetalle.Controls.Add(Me.bnavDetArreglos)
        Me.pnlDetalle.Controls.Add(Me.pnlItem)
        Me.pnlDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDetalle.Location = New System.Drawing.Point(0, 128)
        Me.pnlDetalle.Name = "pnlDetalle"
        Me.pnlDetalle.Size = New System.Drawing.Size(990, 346)
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
        Me.c1grdDetalle.Size = New System.Drawing.Size(990, 270)
        Me.c1grdDetalle.StyleInfo = resources.GetString("c1grdDetalle.StyleInfo")
        Me.c1grdDetalle.TabIndex = 1
        '
        'bnavDetArreglos
        '
        Me.bnavDetArreglos.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.bnavDetArreglos.CountItem = Me.BindingNavigatorCountItem
        Me.bnavDetArreglos.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.bnavDetArreglos.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.bnavDetArreglos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem})
        Me.bnavDetArreglos.Location = New System.Drawing.Point(0, 321)
        Me.bnavDetArreglos.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.bnavDetArreglos.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.bnavDetArreglos.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.bnavDetArreglos.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.bnavDetArreglos.Name = "bnavDetArreglos"
        Me.bnavDetArreglos.PositionItem = Me.BindingNavigatorPositionItem
        Me.bnavDetArreglos.Size = New System.Drawing.Size(990, 25)
        Me.bnavDetArreglos.TabIndex = 4
        Me.bnavDetArreglos.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"),System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
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
        'pnlItem
        '
        Me.pnlItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(3,Byte),Integer), CType(CType(55,Byte),Integer), CType(CType(145,Byte),Integer))
        Me.pnlItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlItem.Controls.Add(Me.Label3)
        Me.pnlItem.Controls.Add(Me.txtUnidad)
        Me.pnlItem.Controls.Add(Me.txtOpcion)
        Me.pnlItem.Controls.Add(Me.actxnCantidad)
        Me.pnlItem.Controls.Add(Me.Label14)
        Me.pnlItem.Controls.Add(Me.txtProdDescripcion)
        Me.pnlItem.Controls.Add(Me.Label17)
        Me.pnlItem.Controls.Add(Me.lblCodigo)
        Me.pnlItem.Controls.Add(Me.actxaProdCodigo)
        Me.pnlItem.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlItem.Location = New System.Drawing.Point(0, 0)
        Me.pnlItem.Name = "pnlItem"
        Me.pnlItem.Size = New System.Drawing.Size(990, 51)
        Me.pnlItem.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = true
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 11!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(816, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Unidad"
        '
        'txtUnidad
        '
        Me.txtUnidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtUnidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUnidad.Location = New System.Drawing.Point(803, 21)
        Me.txtUnidad.Name = "txtUnidad"
        Me.txtUnidad.ReadOnly = true
        Me.txtUnidad.Size = New System.Drawing.Size(68, 23)
        Me.txtUnidad.TabIndex = 5
        Me.txtUnidad.Tag = "V"
        '
        'txtOpcion
        '
        Me.txtOpcion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtOpcion.BackColor = System.Drawing.Color.Gainsboro
        Me.txtOpcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOpcion.Location = New System.Drawing.Point(952, 21)
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
        Me.actxnCantidad.Location = New System.Drawing.Point(877, 21)
        Me.actxnCantidad.MaxLength = 12
        Me.actxnCantidad.Name = "actxnCantidad"
        Me.actxnCantidad.Size = New System.Drawing.Size(73, 23)
        Me.actxnCantidad.TabIndex = 15
        Me.actxnCantidad.Tag = "EV"
        Me.actxnCantidad.Text = "0.00"
        Me.actxnCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = true
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 11!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(889, 5)
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
        Me.txtProdDescripcion.Location = New System.Drawing.Point(116, 21)
        Me.txtProdDescripcion.Name = "txtProdDescripcion"
        Me.txtProdDescripcion.ReadOnly = true
        Me.txtProdDescripcion.Size = New System.Drawing.Size(681, 23)
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
        Me.pnlPie.Controls.Add(Me.chkAnulada)
        Me.pnlPie.Controls.Add(Me.actxnPesoTotal)
        Me.pnlPie.Controls.Add(Me.lblTotalPagar)
        Me.pnlPie.Controls.Add(Me.txtDocReferencia)
        Me.pnlPie.Controls.Add(Me.actxaCodReferencia)
        Me.pnlPie.Controls.Add(Me.Label5)
        Me.pnlPie.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlPie.ForeColor = System.Drawing.Color.White
        Me.pnlPie.Location = New System.Drawing.Point(0, 474)
        Me.pnlPie.Name = "pnlPie"
        Me.pnlPie.Size = New System.Drawing.Size(990, 47)
        Me.pnlPie.TabIndex = 3
        '
        'chkAnulada
        '
        Me.chkAnulada.AutoSize = true
        Me.chkAnulada.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkAnulada.Enabled = false
        Me.chkAnulada.ForeColor = System.Drawing.Color.White
        Me.chkAnulada.Location = New System.Drawing.Point(417, 15)
        Me.chkAnulada.Name = "chkAnulada"
        Me.chkAnulada.Size = New System.Drawing.Size(70, 19)
        Me.chkAnulada.TabIndex = 1
        Me.chkAnulada.Tag = "EO"
        Me.chkAnulada.Text = "Anulada"
        Me.chkAnulada.UseVisualStyleBackColor = true
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
        Me.actxnPesoTotal.Location = New System.Drawing.Point(845, 9)
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
        Me.lblTotalPagar.Location = New System.Drawing.Point(745, 14)
        Me.lblTotalPagar.Name = "lblTotalPagar"
        Me.lblTotalPagar.Size = New System.Drawing.Size(81, 17)
        Me.lblTotalPagar.TabIndex = 3
        Me.lblTotalPagar.Text = "Peso Total :"
        '
        'txtDocReferencia
        '
        Me.txtDocReferencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDocReferencia.Location = New System.Drawing.Point(251, 13)
        Me.txtDocReferencia.Name = "txtDocReferencia"
        Me.txtDocReferencia.ReadOnly = true
        Me.txtDocReferencia.Size = New System.Drawing.Size(160, 23)
        Me.txtDocReferencia.TabIndex = 10
        Me.txtDocReferencia.Tag = "V"
        '
        'actxaCodReferencia
        '
        Me.actxaCodReferencia.ACActivarAyudaAuto = false
        Me.actxaCodReferencia.ACLongitudAceptada = 0
        Me.actxaCodReferencia.Location = New System.Drawing.Point(117, 13)
        Me.actxaCodReferencia.MaxLength = 10
        Me.actxaCodReferencia.Name = "actxaCodReferencia"
        Me.actxaCodReferencia.Size = New System.Drawing.Size(128, 23)
        Me.actxaCodReferencia.TabIndex = 9
        Me.actxaCodReferencia.Tag = "VO"
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Enabled = false
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label5.Location = New System.Drawing.Point(9, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Doc. Referencia :"
        '
        'pnlCabecera
        '
        Me.pnlCabecera.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlCabecera.Controls.Add(Me.actxnNumero)
        Me.pnlCabecera.Controls.Add(Me.Label7)
        Me.pnlCabecera.Controls.Add(Me.txtSerie)
        Me.pnlCabecera.Controls.Add(Me.Label6)
        Me.pnlCabecera.Controls.Add(Me.Label2)
        Me.pnlCabecera.Controls.Add(Me.dtpFechaIngreso)
        Me.pnlCabecera.Controls.Add(Me.txtCodigo)
        Me.pnlCabecera.Controls.Add(Me.Label34)
        Me.pnlCabecera.Controls.Add(Me.txtObservaciones)
        Me.pnlCabecera.Controls.Add(Me.Label4)
        Me.pnlCabecera.Controls.Add(Me.cmbTArreglo)
        Me.pnlCabecera.Controls.Add(Me.Label19)
        Me.pnlCabecera.Controls.Add(Me.Label1)
        Me.pnlCabecera.Controls.Add(Me.dtpFecha)
        Me.pnlCabecera.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlCabecera.Location = New System.Drawing.Point(0, 0)
        Me.pnlCabecera.Name = "pnlCabecera"
        Me.pnlCabecera.Size = New System.Drawing.Size(990, 128)
        Me.pnlCabecera.TabIndex = 0
        '
        'actxnNumero
        '
        Me.actxnNumero.ACDecimales = 0
        Me.actxnNumero.ACEnteros = 9
        Me.actxnNumero.ACFormato = "########0"
        Me.actxnNumero.ACNegativo = true
        Me.actxnNumero.ACValue = New Decimal(New Integer() {0, 0, 0, 131072})
        Me.actxnNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.actxnNumero.Location = New System.Drawing.Point(501, 4)
        Me.actxnNumero.MaxLength = 12
        Me.actxnNumero.Name = "actxnNumero"
        Me.actxnNumero.ReadOnly = true
        Me.actxnNumero.Size = New System.Drawing.Size(73, 23)
        Me.actxnNumero.TabIndex = 17
        Me.actxnNumero.Tag = "EV"
        Me.actxnNumero.Text = "0"
        Me.actxnNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = true
        Me.Label7.Enabled = false
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label7.Location = New System.Drawing.Point(444, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Numero :"
        '
        'txtSerie
        '
        Me.txtSerie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSerie.Location = New System.Drawing.Point(384, 4)
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.ReadOnly = true
        Me.txtSerie.Size = New System.Drawing.Size(49, 23)
        Me.txtSerie.TabIndex = 14
        Me.txtSerie.TabStop = false
        Me.txtSerie.Tag = "V"
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.Enabled = false
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label6.Location = New System.Drawing.Point(340, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Serie :"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Location = New System.Drawing.Point(26, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Fecha Ingreso :"
        '
        'dtpFechaIngreso
        '
        Me.dtpFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaIngreso.Location = New System.Drawing.Point(124, 57)
        Me.dtpFechaIngreso.Name = "dtpFechaIngreso"
        Me.dtpFechaIngreso.Size = New System.Drawing.Size(101, 23)
        Me.dtpFechaIngreso.TabIndex = 5
        Me.dtpFechaIngreso.Tag = "E"
        '
        'txtCodigo
        '
        Me.txtCodigo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodigo.Location = New System.Drawing.Point(813, 4)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = true
        Me.txtCodigo.Size = New System.Drawing.Size(160, 23)
        Me.txtCodigo.TabIndex = 3
        Me.txtCodigo.TabStop = false
        Me.txtCodigo.Tag = "V"
        '
        'Label34
        '
        Me.Label34.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Label34.AutoSize = true
        Me.Label34.Enabled = false
        Me.Label34.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label34.Location = New System.Drawing.Point(760, 9)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(47, 13)
        Me.Label34.TabIndex = 2
        Me.Label34.Text = "Codigo :"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtObservaciones.Location = New System.Drawing.Point(124, 85)
        Me.txtObservaciones.MaxLength = 200
        Me.txtObservaciones.Multiline = true
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservaciones.Size = New System.Drawing.Size(849, 34)
        Me.txtObservaciones.TabIndex = 12
        Me.txtObservaciones.Tag = "EV"
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Location = New System.Drawing.Point(22, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 15)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Observaciones :"
        '
        'cmbTArreglo
        '
        Me.cmbTArreglo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTArreglo.FormattingEnabled = true
        Me.cmbTArreglo.Location = New System.Drawing.Point(124, 4)
        Me.cmbTArreglo.Name = "cmbTArreglo"
        Me.cmbTArreglo.Size = New System.Drawing.Size(201, 23)
        Me.cmbTArreglo.TabIndex = 7
        Me.cmbTArreglo.Tag = "EO"
        '
        'Label19
        '
        Me.Label19.AutoSize = true
        Me.Label19.Location = New System.Drawing.Point(17, 8)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(95, 15)
        Me.Label19.TabIndex = 6
        Me.Label19.Text = "Tipo de Arreglo :"
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(68, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fecha :"
        '
        'dtpFecha
        '
        Me.dtpFecha.Enabled = false
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(124, 31)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(101, 23)
        Me.dtpFecha.TabIndex = 1
        Me.dtpFecha.Tag = "E"
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
        Me.tabBusqueda.Selected = false
        Me.tabBusqueda.SelectTextBackColor = System.Drawing.Color.Empty
        Me.tabBusqueda.SelectTextColor = System.Drawing.Color.Empty
        Me.tabBusqueda.Size = New System.Drawing.Size(990, 521)
        Me.tabBusqueda.TabIndex = 5
        Me.tabBusqueda.Title = "Busqueda"
        Me.tabBusqueda.ToolTip = "Busqueda"
        '
        'c1grdBusqueda
        '
        Me.c1grdBusqueda.ColumnInfo = "2,1,0,0,0,100,Columns:0{Width:25;}"&Global.Microsoft.VisualBasic.ChrW(9)
        Me.c1grdBusqueda.Dock = System.Windows.Forms.DockStyle.Fill
        Me.c1grdBusqueda.Location = New System.Drawing.Point(0, 89)
        Me.c1grdBusqueda.Name = "c1grdBusqueda"
        Me.c1grdBusqueda.Rows.Count = 2
        Me.c1grdBusqueda.Rows.DefaultSize = 20
        Me.c1grdBusqueda.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.c1grdBusqueda.Size = New System.Drawing.Size(990, 407)
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
        Me.bnavBusqueda.Location = New System.Drawing.Point(0, 496)
        Me.bnavBusqueda.MoveFirstItem = Me.ToolStripButton3
        Me.bnavBusqueda.MoveLastItem = Me.ToolStripButton6
        Me.bnavBusqueda.MoveNextItem = Me.ToolStripButton5
        Me.bnavBusqueda.MovePreviousItem = Me.ToolStripButton4
        Me.bnavBusqueda.Name = "bnavBusqueda"
        Me.bnavBusqueda.PositionItem = Me.ToolStripTextBox1
        Me.bnavBusqueda.Size = New System.Drawing.Size(990, 25)
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
        'grpBusqueda
        '
        Me.grpBusqueda.Controls.Add(Me.rbtnFecha)
        Me.grpBusqueda.Controls.Add(Me.rbtnCodigo)
        Me.grpBusqueda.Controls.Add(Me.txtBusqueda)
        Me.grpBusqueda.Controls.Add(Me.btnConsultar)
        Me.grpBusqueda.Controls.Add(Me.AcFecha)
        Me.grpBusqueda.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpBusqueda.Location = New System.Drawing.Point(0, 0)
        Me.grpBusqueda.Name = "grpBusqueda"
        Me.grpBusqueda.Size = New System.Drawing.Size(990, 89)
        Me.grpBusqueda.TabIndex = 0
        Me.grpBusqueda.TabStop = false
        Me.grpBusqueda.Text = "Opciones de Busqueda"
        '
        'rbtnFecha
        '
        Me.rbtnFecha.AutoSize = true
        Me.rbtnFecha.Checked = true
        Me.rbtnFecha.Location = New System.Drawing.Point(13, 22)
        Me.rbtnFecha.Name = "rbtnFecha"
        Me.rbtnFecha.Size = New System.Drawing.Size(98, 19)
        Me.rbtnFecha.TabIndex = 35
        Me.rbtnFecha.TabStop = true
        Me.rbtnFecha.Text = "Fecha Ingreso"
        Me.rbtnFecha.UseVisualStyleBackColor = true
        '
        'rbtnCodigo
        '
        Me.rbtnCodigo.AutoSize = true
        Me.rbtnCodigo.Location = New System.Drawing.Point(373, 22)
        Me.rbtnCodigo.Name = "rbtnCodigo"
        Me.rbtnCodigo.Size = New System.Drawing.Size(64, 19)
        Me.rbtnCodigo.TabIndex = 34
        Me.rbtnCodigo.Text = "Codigo"
        Me.rbtnCodigo.UseVisualStyleBackColor = true
        '
        'txtBusqueda
        '
        Me.txtBusqueda.ACActivarAyudaAuto = false
        Me.txtBusqueda.ACLongitudAceptada = 0
        Me.txtBusqueda.Location = New System.Drawing.Point(363, 60)
        Me.txtBusqueda.MaxLength = 32767
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(92, 23)
        Me.txtBusqueda.TabIndex = 33
        '
        'btnConsultar
        '
        Me.btnConsultar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnConsultar.Font = New System.Drawing.Font("Tahoma", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.btnConsultar.Image = Global.ACPLogistica.My.Resources.Resources.Search_files_32x32
        Me.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConsultar.Location = New System.Drawing.Point(879, 22)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(99, 44)
        Me.btnConsultar.TabIndex = 32
        Me.btnConsultar.Text = "Consultar"
        Me.btnConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnConsultar.UseVisualStyleBackColor = true
        '
        'AcFecha
        '
        Me.AcFecha.ACFecha_A = New Date(2017, 8, 25, 9, 42, 33, 815)
        Me.AcFecha.ACFecha_De = New Date(2017, 8, 25, 9, 42, 33, 813)
        Me.AcFecha.ACFechaObligatoria = true
        Me.AcFecha.ACFormatoControl = ACControles.ACFecha.ACTipoFormatoControl.Horizontal
        Me.AcFecha.ACHoyChecked = false
        Me.AcFecha.Location = New System.Drawing.Point(6, 44)
        Me.AcFecha.MaximumSize = New System.Drawing.Size(340, 50)
        Me.AcFecha.MinimumSize = New System.Drawing.Size(340, 43)
        Me.AcFecha.Name = "AcFecha"
        Me.AcFecha.Size = New System.Drawing.Size(340, 45)
        Me.AcFecha.TabIndex = 3
        Me.AcFecha.TabStop = false
        Me.AcFecha.Text = " -"
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
        Me.acTool.Location = New System.Drawing.Point(0, 585)
        Me.acTool.Name = "acTool"
        Me.acTool.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.acTool.Size = New System.Drawing.Size(992, 56)
        Me.acTool.TabIndex = 8
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
        Me.actsbtnPrevisualizar.Text = "Revisar"
        Me.actsbtnPrevisualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.actsbtnPrevisualizar.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        Me.actsbtnPrevisualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'TArreglos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(992, 641)
        Me.Controls.Add(Me.tabMantenimiento)
        Me.Controls.Add(Me.acTool)
        Me.Controls.Add(Me.acpnlTitulo)
        Me.Name = "TArreglos"
        Me.Text = "Arreglo de Inventario"
        Me.tabMantenimiento.ResumeLayout(false)
        Me.tabDatos.ResumeLayout(false)
        Me.pnlDetalle.ResumeLayout(false)
        Me.pnlDetalle.PerformLayout
        CType(Me.c1grdDetalle,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.bnavDetArreglos,System.ComponentModel.ISupportInitialize).EndInit
        Me.bnavDetArreglos.ResumeLayout(false)
        Me.bnavDetArreglos.PerformLayout
        Me.pnlItem.ResumeLayout(false)
        Me.pnlItem.PerformLayout
        Me.pnlPie.ResumeLayout(false)
        Me.pnlPie.PerformLayout
        Me.pnlCabecera.ResumeLayout(false)
        Me.pnlCabecera.PerformLayout
        Me.tabBusqueda.ResumeLayout(false)
        Me.tabBusqueda.PerformLayout
        CType(Me.c1grdBusqueda,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.bnavBusqueda,System.ComponentModel.ISupportInitialize).EndInit
        Me.bnavBusqueda.ResumeLayout(false)
        Me.bnavBusqueda.PerformLayout
        Me.grpBusqueda.ResumeLayout(false)
        Me.grpBusqueda.PerformLayout
        Me.acTool.ResumeLayout(false)
        Me.acTool.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
   Friend WithEvents acpnlTitulo As ACControles.ACPanelCaption
   Private WithEvents tabMantenimiento As Crownwood.DotNetMagic.Controls.TabControl
   Private WithEvents tabDatos As Crownwood.DotNetMagic.Controls.TabPage
   Friend WithEvents pnlDetalle As System.Windows.Forms.Panel
   Friend WithEvents c1grdDetalle As C1.Win.C1FlexGrid.C1FlexGrid
   Friend WithEvents pnlPie As System.Windows.Forms.Panel
   Friend WithEvents chkAnulada As System.Windows.Forms.CheckBox
   Friend WithEvents actxnPesoTotal As ACControles.ACTextBoxNumerico
   Friend WithEvents lblTotalPagar As System.Windows.Forms.Label
   Friend WithEvents pnlCabecera As System.Windows.Forms.Panel
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
   Private WithEvents grpBusqueda As System.Windows.Forms.GroupBox
   Friend WithEvents btnConsultar As System.Windows.Forms.Button
   Friend WithEvents AcFecha As ACControles.ACFecha
   Friend WithEvents acTool As ACControles.ACToolBarMantHorizontalNew
   Friend WithEvents actsbtnPrevisualizar As ACControles.ACToolStripButton
   Friend WithEvents pnlItem As System.Windows.Forms.Panel
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents txtUnidad As System.Windows.Forms.TextBox
   Friend WithEvents txtOpcion As System.Windows.Forms.TextBox
   Friend WithEvents actxnCantidad As ACControles.ACTextBoxNumerico
   Friend WithEvents Label14 As System.Windows.Forms.Label
   Friend WithEvents txtProdDescripcion As System.Windows.Forms.TextBox
   Friend WithEvents Label17 As System.Windows.Forms.Label
   Friend WithEvents lblCodigo As System.Windows.Forms.Label
   Friend WithEvents actxaProdCodigo As ACControles.ACTextBoxAyuda
   Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
   Friend WithEvents Label4 As System.Windows.Forms.Label
   Friend WithEvents cmbTArreglo As System.Windows.Forms.ComboBox
   Friend WithEvents Label19 As System.Windows.Forms.Label
   Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
   Friend WithEvents Label34 As System.Windows.Forms.Label
   Friend WithEvents txtDocReferencia As System.Windows.Forms.TextBox
   Friend WithEvents Label5 As System.Windows.Forms.Label
   Friend WithEvents actxaCodReferencia As ACControles.ACTextBoxAyuda
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents dtpFechaIngreso As System.Windows.Forms.DateTimePicker
   Friend WithEvents txtBusqueda As ACControles.ACTextBoxAyuda
   Friend WithEvents actxnNumero As ACControles.ACTextBoxNumerico
   Friend WithEvents Label7 As System.Windows.Forms.Label
   Friend WithEvents txtSerie As System.Windows.Forms.TextBox
   Friend WithEvents Label6 As System.Windows.Forms.Label
   Friend WithEvents rbtnFecha As System.Windows.Forms.RadioButton
   Friend WithEvents rbtnCodigo As System.Windows.Forms.RadioButton
   Friend WithEvents bnavDetArreglos As System.Windows.Forms.BindingNavigator
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
End Class
