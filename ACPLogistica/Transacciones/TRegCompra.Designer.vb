<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TRegCompra
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TRegCompra))
        Me.tabMantenimiento = New Crownwood.DotNetMagic.Controls.TabControl()
        Me.tabDatos = New Crownwood.DotNetMagic.Controls.TabPage()
        Me.pnlDatos = New System.Windows.Forms.Panel()
        Me.pnlDetalle = New System.Windows.Forms.Panel()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.cmbGDestino = New System.Windows.Forms.ComboBox()
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
        Me.tsbtnAsigDestino = New System.Windows.Forms.ToolStripButton()
        Me.tscmbDestino = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.pnlDetCabecera = New System.Windows.Forms.Panel()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cmbProdDestino = New System.Windows.Forms.ComboBox()
        Me.actxnProdPrecUnitario = New ACControles.ACTextBoxNumerico()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.actxnProdPeso = New ACControles.ACTextBoxNumerico()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtProdUnidad = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtOpcion = New System.Windows.Forms.TextBox()
        Me.actxnProdSubImporte = New ACControles.ACTextBoxNumerico()
        Me.actxnProdPesoDoc = New ACControles.ACTextBoxNumerico()
        Me.actxnProdCantidad = New ACControles.ACTextBoxNumerico()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtProdDescripcion = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.actxaProdCodigo = New ACControles.ACTextBoxAyuda()
        Me.pnlPie = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCodigoSAP = New System.Windows.Forms.TextBox()
        Me.actxnImporte = New ACControles.ACTextBoxNumerico()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.actxnPesoTotal = New ACControles.ACTextBoxNumerico()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.actxnIGV = New ACControles.ACTextBoxNumerico()
        Me.actxnTotal = New ACControles.ACTextBoxNumerico()
        Me.pnlCabecera = New System.Windows.Forms.Panel()
        Me.grpCosteo = New System.Windows.Forms.GroupBox()
        Me.txtFlete = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtGastos = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtDescuento = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.grpDocumento = New System.Windows.Forms.GroupBox()
        Me.txtSerie = New System.Windows.Forms.TextBox()
        Me.actxnNumero = New ACControles.ACTextBoxNumerico()
        Me.cmbDocumento = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnNuevoCliente = New System.Windows.Forms.Button()
        Me.cmbMoneda = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.grpTPago = New System.Windows.Forms.GroupBox()
        Me.cmbTipoPago = New System.Windows.Forms.ComboBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.dtpFecPago = New System.Windows.Forms.DateTimePicker()
        Me.actxaProvRazonSocial = New ACControles.ACTextBoxAyuda()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.actxaOrdCompra = New ACControles.ACTextBoxAyuda()
        Me.actxnTipoCambio = New ACControles.ACTextBoxNumerico()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.btnClean = New System.Windows.Forms.Button()
        Me.actxaProvRuc = New ACControles.ACTextBoxAyuda()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tabBusqueda = New Crownwood.DotNetMagic.Controls.TabPage()
        Me.c1grdBusqueda = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.grpBusqueda = New System.Windows.Forms.GroupBox()
        Me.chkAgrupar = New System.Windows.Forms.CheckBox()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.chkTodos = New System.Windows.Forms.CheckBox()
        Me.rbtnDatos = New System.Windows.Forms.RadioButton()
        Me.acFecha = New ACControles.ACFecha(Me.components)
        Me.grpCliente = New System.Windows.Forms.GroupBox()
        Me.txtBusqueda = New ACControles.ACTextBoxAyuda()
        Me.rbtnProveedor = New System.Windows.Forms.RadioButton()
        Me.rbtnNroOrdenCompra = New System.Windows.Forms.RadioButton()
        Me.rbtnDocVenta = New System.Windows.Forms.RadioButton()
        Me.grpDocumentos = New System.Windows.Forms.GroupBox()
        Me.txtCSerie = New System.Windows.Forms.TextBox()
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
        Me.tsbtnExcel = New System.Windows.Forms.ToolStripButton()
        Me.acpnlTitulo = New ACControles.ACPanelCaption()
        Me.acTool = New ACControles.ACToolBarMantHorizontalNew(Me.components)
        Me.actsbtnPrevisualizar = New ACControles.ACToolStripButton(Me.components)
        Me.acbtnSeleccionar = New ACControles.ACToolStripButton(Me.components)
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.eprError = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.actxnCotizacionProveedor = New System.Windows.Forms.TextBox()
        Me.tabMantenimiento.SuspendLayout()
        Me.tabDatos.SuspendLayout()
        Me.pnlDatos.SuspendLayout()
        Me.pnlDetalle.SuspendLayout()
        CType(Me.c1grdDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bnavProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bnavProductos.SuspendLayout()
        Me.pnlDetCabecera.SuspendLayout()
        Me.pnlPie.SuspendLayout()
        Me.pnlCabecera.SuspendLayout()
        Me.grpCosteo.SuspendLayout()
        Me.grpDocumento.SuspendLayout()
        Me.grpTPago.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tabBusqueda.SuspendLayout()
        CType(Me.c1grdBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpBusqueda.SuspendLayout()
        Me.grpCliente.SuspendLayout()
        Me.grpDocumentos.SuspendLayout()
        CType(Me.bnavBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bnavBusqueda.SuspendLayout()
        Me.acTool.SuspendLayout()
        CType(Me.eprError, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
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
        Me.tabMantenimiento.Size = New System.Drawing.Size(1217, 466)
        Me.tabMantenimiento.TabIndex = 1
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
        Me.tabDatos.Size = New System.Drawing.Size(1215, 441)
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
        Me.pnlDatos.Size = New System.Drawing.Size(1215, 441)
        Me.pnlDatos.TabIndex = 0
        '
        'pnlDetalle
        '
        Me.pnlDetalle.Controls.Add(Me.btnCalcular)
        Me.pnlDetalle.Controls.Add(Me.cmbGDestino)
        Me.pnlDetalle.Controls.Add(Me.c1grdDetalle)
        Me.pnlDetalle.Controls.Add(Me.bnavProductos)
        Me.pnlDetalle.Controls.Add(Me.pnlDetCabecera)
        Me.pnlDetalle.Controls.Add(Me.pnlPie)
        Me.pnlDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDetalle.Location = New System.Drawing.Point(0, 178)
        Me.pnlDetalle.Name = "pnlDetalle"
        Me.pnlDetalle.Size = New System.Drawing.Size(1215, 263)
        Me.pnlDetalle.TabIndex = 1
        '
        'btnCalcular
        '
        Me.btnCalcular.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
        Me.btnCalcular.Image = Global.ACPLogistica.My.Resources.Resources.Calculator_red_32x32
        Me.btnCalcular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCalcular.Location = New System.Drawing.Point(279, 100)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(124, 42)
        Me.btnCalcular.TabIndex = 26
        Me.btnCalcular.Text = "Re Calcular"
        Me.btnCalcular.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip.SetToolTip(Me.btnCalcular, "Permite calcular el importe y el peso " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "segun la cantidad y precio." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "El peso se c" &
        "alcula multiplicando " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "la canntidad por el peso unitario")
        Me.btnCalcular.UseVisualStyleBackColor = True
        Me.btnCalcular.Visible = False
        '
        'cmbGDestino
        '
        Me.cmbGDestino.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbGDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGDestino.FormattingEnabled = True
        Me.cmbGDestino.Items.AddRange(New Object() {"Boleta", "Factura"})
        Me.cmbGDestino.Location = New System.Drawing.Point(864, 100)
        Me.cmbGDestino.Name = "cmbGDestino"
        Me.cmbGDestino.Size = New System.Drawing.Size(80, 23)
        Me.cmbGDestino.TabIndex = 18
        Me.cmbGDestino.Visible = False
        '
        'c1grdDetalle
        '
        Me.c1grdDetalle.BackColor = System.Drawing.Color.White
        Me.c1grdDetalle.ColumnInfo = "2,1,0,0,0,100,Columns:0{Width:20;}" & Global.Microsoft.VisualBasic.ChrW(9) & "1{Width:103;Caption:""Codigo"";}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.c1grdDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.c1grdDetalle.Location = New System.Drawing.Point(0, 51)
        Me.c1grdDetalle.Name = "c1grdDetalle"
        Me.c1grdDetalle.Rows.Count = 2
        Me.c1grdDetalle.Rows.DefaultSize = 20
        Me.c1grdDetalle.Size = New System.Drawing.Size(1215, 133)
        Me.c1grdDetalle.StyleInfo = resources.GetString("c1grdDetalle.StyleInfo")
        Me.c1grdDetalle.TabIndex = 8
        '
        'bnavProductos
        '
        Me.bnavProductos.AddNewItem = Me.ToolStripButton1
        Me.bnavProductos.CountItem = Me.ToolStripLabel1
        Me.bnavProductos.DeleteItem = Me.ToolStripButton2
        Me.bnavProductos.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.bnavProductos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripSeparator1, Me.ToolStripTextBox1, Me.ToolStripLabel1, Me.ToolStripSeparator2, Me.ToolStripButton5, Me.ToolStripButton6, Me.ToolStripSeparator3, Me.ToolStripButton1, Me.ToolStripButton2, Me.tsbtnAsigDestino, Me.tscmbDestino, Me.ToolStripLabel2})
        Me.bnavProductos.Location = New System.Drawing.Point(0, 184)
        Me.bnavProductos.MoveFirstItem = Me.ToolStripButton3
        Me.bnavProductos.MoveLastItem = Me.ToolStripButton6
        Me.bnavProductos.MoveNextItem = Me.ToolStripButton5
        Me.bnavProductos.MovePreviousItem = Me.ToolStripButton4
        Me.bnavProductos.Name = "bnavProductos"
        Me.bnavProductos.PositionItem = Me.ToolStripTextBox1
        Me.bnavProductos.Size = New System.Drawing.Size(1215, 25)
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
        'tsbtnAsigDestino
        '
        Me.tsbtnAsigDestino.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbtnAsigDestino.Image = Global.ACPLogistica.My.Resources.Resources.Check_Proces_32x32
        Me.tsbtnAsigDestino.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnAsigDestino.Name = "tsbtnAsigDestino"
        Me.tsbtnAsigDestino.Size = New System.Drawing.Size(110, 22)
        Me.tsbtnAsigDestino.Text = "Asignar Destino"
        '
        'tscmbDestino
        '
        Me.tscmbDestino.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tscmbDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.tscmbDestino.Name = "tscmbDestino"
        Me.tscmbDestino.Size = New System.Drawing.Size(150, 25)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(53, 22)
        Me.ToolStripLabel2.Text = "Destino :"
        '
        'pnlDetCabecera
        '
        Me.pnlDetCabecera.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(145, Byte), Integer))
        Me.pnlDetCabecera.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlDetCabecera.Controls.Add(Me.Label20)
        Me.pnlDetCabecera.Controls.Add(Me.cmbProdDestino)
        Me.pnlDetCabecera.Controls.Add(Me.actxnProdPrecUnitario)
        Me.pnlDetCabecera.Controls.Add(Me.Label17)
        Me.pnlDetCabecera.Controls.Add(Me.actxnProdPeso)
        Me.pnlDetCabecera.Controls.Add(Me.Label12)
        Me.pnlDetCabecera.Controls.Add(Me.txtProdUnidad)
        Me.pnlDetCabecera.Controls.Add(Me.Label6)
        Me.pnlDetCabecera.Controls.Add(Me.txtOpcion)
        Me.pnlDetCabecera.Controls.Add(Me.actxnProdSubImporte)
        Me.pnlDetCabecera.Controls.Add(Me.actxnProdPesoDoc)
        Me.pnlDetCabecera.Controls.Add(Me.actxnProdCantidad)
        Me.pnlDetCabecera.Controls.Add(Me.Label10)
        Me.pnlDetCabecera.Controls.Add(Me.Label9)
        Me.pnlDetCabecera.Controls.Add(Me.Label8)
        Me.pnlDetCabecera.Controls.Add(Me.txtProdDescripcion)
        Me.pnlDetCabecera.Controls.Add(Me.Label7)
        Me.pnlDetCabecera.Controls.Add(Me.Label11)
        Me.pnlDetCabecera.Controls.Add(Me.actxaProdCodigo)
        Me.pnlDetCabecera.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlDetCabecera.Location = New System.Drawing.Point(0, 0)
        Me.pnlDetCabecera.Name = "pnlDetCabecera"
        Me.pnlDetCabecera.Size = New System.Drawing.Size(1215, 51)
        Me.pnlDetCabecera.TabIndex = 1
        '
        'Label20
        '
        Me.Label20.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(1104, 5)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(50, 13)
        Me.Label20.TabIndex = 16
        Me.Label20.Text = "Destino"
        '
        'cmbProdDestino
        '
        Me.cmbProdDestino.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbProdDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProdDestino.FormattingEnabled = True
        Me.cmbProdDestino.Items.AddRange(New Object() {"Boleta", "Factura"})
        Me.cmbProdDestino.Location = New System.Drawing.Point(1101, 22)
        Me.cmbProdDestino.Name = "cmbProdDestino"
        Me.cmbProdDestino.Size = New System.Drawing.Size(80, 23)
        Me.cmbProdDestino.TabIndex = 17
        '
        'actxnProdPrecUnitario
        '
        Me.actxnProdPrecUnitario.ACEnteros = 9
        Me.actxnProdPrecUnitario.ACEstandar = ACControles.ACEstandaresFormato.ACDecimal
        Me.actxnProdPrecUnitario.ACNegativo = True
        Me.actxnProdPrecUnitario.ACValue = New Decimal(New Integer() {0, 0, 0, 131072})
        Me.actxnProdPrecUnitario.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.actxnProdPrecUnitario.BackColor = System.Drawing.SystemColors.Window
        Me.actxnProdPrecUnitario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.actxnProdPrecUnitario.Location = New System.Drawing.Point(873, 22)
        Me.actxnProdPrecUnitario.MaxLength = 12
        Me.actxnProdPrecUnitario.Name = "actxnProdPrecUnitario"
        Me.actxnProdPrecUnitario.Size = New System.Drawing.Size(75, 23)
        Me.actxnProdPrecUnitario.TabIndex = 11
        Me.actxnProdPrecUnitario.Tag = "EVO"
        Me.actxnProdPrecUnitario.Text = "0.00"
        Me.actxnProdPrecUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label17
        '
        Me.Label17.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(875, 5)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(71, 13)
        Me.Label17.TabIndex = 10
        Me.Label17.Text = "Precio Unit."
        '
        'actxnProdPeso
        '
        Me.actxnProdPeso.ACEnteros = 9
        Me.actxnProdPeso.ACEstandar = ACControles.ACEstandaresFormato.ACDecimal
        Me.actxnProdPeso.ACFormato = "###,###,##0.0000"
        Me.actxnProdPeso.ACNegativo = True
        Me.actxnProdPeso.ACValue = New Decimal(New Integer() {0, 0, 0, 131072})
        Me.actxnProdPeso.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.actxnProdPeso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.actxnProdPeso.Location = New System.Drawing.Point(721, 22)
        Me.actxnProdPeso.MaxLength = 12
        Me.actxnProdPeso.Name = "actxnProdPeso"
        Me.actxnProdPeso.ReadOnly = True
        Me.actxnProdPeso.Size = New System.Drawing.Size(75, 23)
        Me.actxnProdPeso.TabIndex = 7
        Me.actxnProdPeso.Tag = "EVO"
        Me.actxnProdPeso.Text = "0.0000"
        Me.actxnProdPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(724, 5)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(34, 13)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "Peso"
        '
        'txtProdUnidad
        '
        Me.txtProdUnidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtProdUnidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProdUnidad.Location = New System.Drawing.Point(651, 22)
        Me.txtProdUnidad.Name = "txtProdUnidad"
        Me.txtProdUnidad.ReadOnly = True
        Me.txtProdUnidad.Size = New System.Drawing.Size(69, 23)
        Me.txtProdUnidad.TabIndex = 5
        Me.txtProdUnidad.Tag = "EVO"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(652, 5)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Unidad"
        '
        'txtOpcion
        '
        Me.txtOpcion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtOpcion.BackColor = System.Drawing.SystemColors.Control
        Me.txtOpcion.Location = New System.Drawing.Point(1181, 22)
        Me.txtOpcion.Name = "txtOpcion"
        Me.txtOpcion.Size = New System.Drawing.Size(22, 23)
        Me.txtOpcion.TabIndex = 18
        '
        'actxnProdSubImporte
        '
        Me.actxnProdSubImporte.ACEnteros = 9
        Me.actxnProdSubImporte.ACEstandar = ACControles.ACEstandaresFormato.ACDecimal
        Me.actxnProdSubImporte.ACNegativo = True
        Me.actxnProdSubImporte.ACValue = New Decimal(New Integer() {0, 0, 0, 131072})
        Me.actxnProdSubImporte.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.actxnProdSubImporte.BackColor = System.Drawing.SystemColors.Window
        Me.actxnProdSubImporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.actxnProdSubImporte.Location = New System.Drawing.Point(1025, 22)
        Me.actxnProdSubImporte.MaxLength = 12
        Me.actxnProdSubImporte.Name = "actxnProdSubImporte"
        Me.actxnProdSubImporte.Size = New System.Drawing.Size(75, 23)
        Me.actxnProdSubImporte.TabIndex = 15
        Me.actxnProdSubImporte.Tag = "EVO"
        Me.actxnProdSubImporte.Text = "0.00"
        Me.actxnProdSubImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'actxnProdPesoDoc
        '
        Me.actxnProdPesoDoc.ACEnteros = 9
        Me.actxnProdPesoDoc.ACEstandar = ACControles.ACEstandaresFormato.ACDecimal
        Me.actxnProdPesoDoc.ACFormato = "###,###,##0.0000"
        Me.actxnProdPesoDoc.ACNegativo = True
        Me.actxnProdPesoDoc.ACValue = New Decimal(New Integer() {0, 0, 0, 262144})
        Me.actxnProdPesoDoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.actxnProdPesoDoc.BackColor = System.Drawing.SystemColors.Window
        Me.actxnProdPesoDoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.actxnProdPesoDoc.Location = New System.Drawing.Point(949, 22)
        Me.actxnProdPesoDoc.MaxLength = 12
        Me.actxnProdPesoDoc.Name = "actxnProdPesoDoc"
        Me.actxnProdPesoDoc.Size = New System.Drawing.Size(75, 23)
        Me.actxnProdPesoDoc.TabIndex = 13
        Me.actxnProdPesoDoc.Tag = "EVO"
        Me.actxnProdPesoDoc.Text = "0.0000"
        Me.actxnProdPesoDoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'actxnProdCantidad
        '
        Me.actxnProdCantidad.ACEnteros = 8
        Me.actxnProdCantidad.ACFormato = "#######0.00"
        Me.actxnProdCantidad.ACNegativo = True
        Me.actxnProdCantidad.ACValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.actxnProdCantidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.actxnProdCantidad.BackColor = System.Drawing.SystemColors.Window
        Me.actxnProdCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.actxnProdCantidad.Location = New System.Drawing.Point(797, 22)
        Me.actxnProdCantidad.MaxLength = 12
        Me.actxnProdCantidad.Name = "actxnProdCantidad"
        Me.actxnProdCantidad.Size = New System.Drawing.Size(75, 23)
        Me.actxnProdCantidad.TabIndex = 9
        Me.actxnProdCantidad.Tag = "EVO"
        Me.actxnProdCantidad.Text = "0"
        Me.actxnProdCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(1022, 5)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(78, 13)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Sub Importe"
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(951, 5)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 13)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Peso Doc."
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(798, 5)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Cantidad"
        '
        'txtProdDescripcion
        '
        Me.txtProdDescripcion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtProdDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProdDescripcion.Location = New System.Drawing.Point(93, 22)
        Me.txtProdDescripcion.Name = "txtProdDescripcion"
        Me.txtProdDescripcion.ReadOnly = True
        Me.txtProdDescripcion.Size = New System.Drawing.Size(556, 23)
        Me.txtProdDescripcion.TabIndex = 3
        Me.txtProdDescripcion.Tag = "EVO"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(96, 5)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Descripcion"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(16, 5)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Codigo"
        '
        'actxaProdCodigo
        '
        Me.actxaProdCodigo.ACActivarAyudaAuto = False
        Me.actxaProdCodigo.ACLongitudAceptada = 0
        Me.actxaProdCodigo.BackColor = System.Drawing.SystemColors.Window
        Me.actxaProdCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.actxaProdCodigo.Location = New System.Drawing.Point(12, 22)
        Me.actxaProdCodigo.MaxLength = 32767
        Me.actxaProdCodigo.Name = "actxaProdCodigo"
        Me.actxaProdCodigo.Size = New System.Drawing.Size(80, 23)
        Me.actxaProdCodigo.TabIndex = 1
        Me.actxaProdCodigo.Tag = "EVO"
        '
        'pnlPie
        '
        Me.pnlPie.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(145, Byte), Integer))
        Me.pnlPie.Controls.Add(Me.Label4)
        Me.pnlPie.Controls.Add(Me.txtCodigoSAP)
        Me.pnlPie.Controls.Add(Me.actxnImporte)
        Me.pnlPie.Controls.Add(Me.Label26)
        Me.pnlPie.Controls.Add(Me.actxnPesoTotal)
        Me.pnlPie.Controls.Add(Me.Label3)
        Me.pnlPie.Controls.Add(Me.Label13)
        Me.pnlPie.Controls.Add(Me.Label16)
        Me.pnlPie.Controls.Add(Me.actxnIGV)
        Me.pnlPie.Controls.Add(Me.actxnTotal)
        Me.pnlPie.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlPie.ForeColor = System.Drawing.Color.White
        Me.pnlPie.Location = New System.Drawing.Point(0, 209)
        Me.pnlPie.Name = "pnlPie"
        Me.pnlPie.Size = New System.Drawing.Size(1215, 54)
        Me.pnlPie.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(866, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Importe"
        '
        'txtCodigoSAP
        '
        Me.txtCodigoSAP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodigoSAP.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
        Me.txtCodigoSAP.Location = New System.Drawing.Point(104, 16)
        Me.txtCodigoSAP.MaxLength = 10
        Me.txtCodigoSAP.Name = "txtCodigoSAP"
        Me.txtCodigoSAP.Size = New System.Drawing.Size(173, 26)
        Me.txtCodigoSAP.TabIndex = 1
        Me.txtCodigoSAP.Tag = "EV"
        '
        'actxnImporte
        '
        Me.actxnImporte.ACEnteros = 9
        Me.actxnImporte.ACEstandar = ACControles.ACEstandaresFormato.ACDecimal
        Me.actxnImporte.ACNegativo = True
        Me.actxnImporte.ACValue = New Decimal(New Integer() {0, 0, 0, 131072})
        Me.actxnImporte.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.actxnImporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.actxnImporte.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
        Me.actxnImporte.Location = New System.Drawing.Point(827, 26)
        Me.actxnImporte.MaxLength = 12
        Me.actxnImporte.Name = "actxnImporte"
        Me.actxnImporte.ReadOnly = True
        Me.actxnImporte.Size = New System.Drawing.Size(121, 26)
        Me.actxnImporte.TabIndex = 5
        Me.actxnImporte.Tag = "EVO"
        Me.actxnImporte.Text = "0.00"
        Me.actxnImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
        Me.Label26.Location = New System.Drawing.Point(12, 21)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(76, 15)
        Me.Label26.TabIndex = 0
        Me.Label26.Text = "Codigo SAP :"
        '
        'actxnPesoTotal
        '
        Me.actxnPesoTotal.ACEnteros = 9
        Me.actxnPesoTotal.ACEstandar = ACControles.ACEstandaresFormato.ACDecimal
        Me.actxnPesoTotal.ACFormato = "###,###,##0.0000"
        Me.actxnPesoTotal.ACNegativo = True
        Me.actxnPesoTotal.ACValue = New Decimal(New Integer() {0, 0, 0, 131072})
        Me.actxnPesoTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.actxnPesoTotal.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
        Me.actxnPesoTotal.Location = New System.Drawing.Point(683, 26)
        Me.actxnPesoTotal.MaxLength = 12
        Me.actxnPesoTotal.Name = "actxnPesoTotal"
        Me.actxnPesoTotal.ReadOnly = True
        Me.actxnPesoTotal.Size = New System.Drawing.Size(129, 26)
        Me.actxnPesoTotal.TabIndex = 3
        Me.actxnPesoTotal.Tag = "EVO"
        Me.actxnPesoTotal.Text = "0.0000"
        Me.actxnPesoTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(718, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Peso Total"
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(1126, 5)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(37, 16)
        Me.Label13.TabIndex = 8
        Me.Label13.Text = "Total"
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(1001, 5)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(40, 16)
        Me.Label16.TabIndex = 6
        Me.Label16.Text = "I.G.V."
        '
        'actxnIGV
        '
        Me.actxnIGV.ACEnteros = 9
        Me.actxnIGV.ACEstandar = ACControles.ACEstandaresFormato.ACDecimal
        Me.actxnIGV.ACNegativo = True
        Me.actxnIGV.ACValue = New Decimal(New Integer() {0, 0, 0, 131072})
        Me.actxnIGV.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.actxnIGV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.actxnIGV.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
        Me.actxnIGV.Location = New System.Drawing.Point(961, 26)
        Me.actxnIGV.MaxLength = 12
        Me.actxnIGV.Name = "actxnIGV"
        Me.actxnIGV.ReadOnly = True
        Me.actxnIGV.Size = New System.Drawing.Size(120, 26)
        Me.actxnIGV.TabIndex = 7
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
        Me.actxnTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.actxnTotal.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
        Me.actxnTotal.Location = New System.Drawing.Point(1089, 26)
        Me.actxnTotal.MaxLength = 12
        Me.actxnTotal.Name = "actxnTotal"
        Me.actxnTotal.ReadOnly = True
        Me.actxnTotal.Size = New System.Drawing.Size(109, 26)
        Me.actxnTotal.TabIndex = 9
        Me.actxnTotal.Tag = "EVO"
        Me.actxnTotal.Text = "0.00"
        Me.actxnTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'pnlCabecera
        '
        Me.pnlCabecera.Controls.Add(Me.GroupBox2)
        Me.pnlCabecera.Controls.Add(Me.grpCosteo)
        Me.pnlCabecera.Controls.Add(Me.grpDocumento)
        Me.pnlCabecera.Controls.Add(Me.Label1)
        Me.pnlCabecera.Controls.Add(Me.btnNuevoCliente)
        Me.pnlCabecera.Controls.Add(Me.cmbMoneda)
        Me.pnlCabecera.Controls.Add(Me.Label15)
        Me.pnlCabecera.Controls.Add(Me.Label25)
        Me.pnlCabecera.Controls.Add(Me.grpTPago)
        Me.pnlCabecera.Controls.Add(Me.actxaProvRazonSocial)
        Me.pnlCabecera.Controls.Add(Me.GroupBox1)
        Me.pnlCabecera.Controls.Add(Me.actxnTipoCambio)
        Me.pnlCabecera.Controls.Add(Me.dtpFecha)
        Me.pnlCabecera.Controls.Add(Me.btnClean)
        Me.pnlCabecera.Controls.Add(Me.actxaProvRuc)
        Me.pnlCabecera.Controls.Add(Me.Label2)
        Me.pnlCabecera.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlCabecera.Location = New System.Drawing.Point(0, 0)
        Me.pnlCabecera.Name = "pnlCabecera"
        Me.pnlCabecera.Size = New System.Drawing.Size(1215, 178)
        Me.pnlCabecera.TabIndex = 0
        '
        'grpCosteo
        '
        Me.grpCosteo.Controls.Add(Me.txtFlete)
        Me.grpCosteo.Controls.Add(Me.Label23)
        Me.grpCosteo.Controls.Add(Me.txtGastos)
        Me.grpCosteo.Controls.Add(Me.Label21)
        Me.grpCosteo.Controls.Add(Me.txtDescuento)
        Me.grpCosteo.Controls.Add(Me.Label19)
        Me.grpCosteo.Location = New System.Drawing.Point(4, 119)
        Me.grpCosteo.Name = "grpCosteo"
        Me.grpCosteo.Size = New System.Drawing.Size(470, 53)
        Me.grpCosteo.TabIndex = 14
        Me.grpCosteo.TabStop = False
        Me.grpCosteo.Text = "Costeo"
        '
        'txtFlete
        '
        Me.txtFlete.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFlete.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.txtFlete.Location = New System.Drawing.Point(383, 18)
        Me.txtFlete.MaxLength = 5
        Me.txtFlete.Name = "txtFlete"
        Me.txtFlete.Size = New System.Drawing.Size(75, 26)
        Me.txtFlete.TabIndex = 10
        Me.txtFlete.Tag = "EVO"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(304, 23)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(76, 15)
        Me.Label23.TabIndex = 9
        Me.Label23.Text = "Flete (Tm) S/:"
        '
        'txtGastos
        '
        Me.txtGastos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGastos.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.txtGastos.Location = New System.Drawing.Point(224, 18)
        Me.txtGastos.MaxLength = 5
        Me.txtGastos.Name = "txtGastos"
        Me.txtGastos.Size = New System.Drawing.Size(75, 26)
        Me.txtGastos.TabIndex = 8
        Me.txtGastos.Tag = "EVO"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(162, 23)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(59, 15)
        Me.Label21.TabIndex = 7
        Me.Label21.Text = "Gastos S/:"
        '
        'txtDescuento
        '
        Me.txtDescuento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescuento.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.txtDescuento.Location = New System.Drawing.Point(82, 18)
        Me.txtDescuento.MaxLength = 5
        Me.txtDescuento.Name = "txtDescuento"
        Me.txtDescuento.Size = New System.Drawing.Size(75, 26)
        Me.txtDescuento.TabIndex = 6
        Me.txtDescuento.Tag = "EVO"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(3, 23)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(79, 15)
        Me.Label19.TabIndex = 0
        Me.Label19.Text = "% Descuento:"
        '
        'grpDocumento
        '
        Me.grpDocumento.Controls.Add(Me.txtSerie)
        Me.grpDocumento.Controls.Add(Me.actxnNumero)
        Me.grpDocumento.Controls.Add(Me.cmbDocumento)
        Me.grpDocumento.Location = New System.Drawing.Point(3, 72)
        Me.grpDocumento.Name = "grpDocumento"
        Me.grpDocumento.Size = New System.Drawing.Size(400, 48)
        Me.grpDocumento.TabIndex = 12
        Me.grpDocumento.TabStop = False
        Me.grpDocumento.Text = "Documento de Compra (Tipo/Serie/Numero)"
        '
        'txtSerie
        '
        Me.txtSerie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSerie.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.txtSerie.Location = New System.Drawing.Point(229, 16)
        Me.txtSerie.MaxLength = 5
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.Size = New System.Drawing.Size(45, 26)
        Me.txtSerie.TabIndex = 5
        Me.txtSerie.Tag = "EVO"
        '
        'actxnNumero
        '
        Me.actxnNumero.ACEnteros = 8
        Me.actxnNumero.ACFormato = "#######0"
        Me.actxnNumero.ACNegativo = True
        Me.actxnNumero.ACValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.actxnNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.actxnNumero.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.actxnNumero.Location = New System.Drawing.Point(290, 16)
        Me.actxnNumero.MaxLength = 12
        Me.actxnNumero.Name = "actxnNumero"
        Me.actxnNumero.Size = New System.Drawing.Size(92, 26)
        Me.actxnNumero.TabIndex = 5
        Me.actxnNumero.Tag = "ENO"
        Me.actxnNumero.Text = "0"
        Me.actxnNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmbDocumento
        '
        Me.cmbDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDocumento.DropDownWidth = 250
        Me.cmbDocumento.FormattingEnabled = True
        Me.cmbDocumento.Items.AddRange(New Object() {"Boleta", "Factura"})
        Me.cmbDocumento.Location = New System.Drawing.Point(8, 18)
        Me.cmbDocumento.Name = "cmbDocumento"
        Me.cmbDocumento.Size = New System.Drawing.Size(198, 23)
        Me.cmbDocumento.TabIndex = 1
        Me.cmbDocumento.Tag = "ECO"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1052, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Fecha :"
        '
        'btnNuevoCliente
        '
        Me.btnNuevoCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNuevoCliente.Image = Global.ACPLogistica.My.Resources.Resources.Nuevo_16x16
        Me.btnNuevoCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNuevoCliente.Location = New System.Drawing.Point(1149, 41)
        Me.btnNuevoCliente.Name = "btnNuevoCliente"
        Me.btnNuevoCliente.Size = New System.Drawing.Size(28, 27)
        Me.btnNuevoCliente.TabIndex = 10
        Me.btnNuevoCliente.TabStop = False
        Me.btnNuevoCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNuevoCliente.UseVisualStyleBackColor = True
        '
        'cmbMoneda
        '
        Me.cmbMoneda.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbMoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMoneda.FormattingEnabled = True
        Me.cmbMoneda.Location = New System.Drawing.Point(738, 7)
        Me.cmbMoneda.Name = "cmbMoneda"
        Me.cmbMoneda.Size = New System.Drawing.Size(61, 23)
        Me.cmbMoneda.TabIndex = 2
        Me.cmbMoneda.Tag = "ECO"
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(675, 11)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(57, 15)
        Me.Label15.TabIndex = 1
        Me.Label15.Text = "Moneda :"
        '
        'Label25
        '
        Me.Label25.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(817, 11)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(146, 15)
        Me.Label25.TabIndex = 3
        Me.Label25.Text = "Tipo Cambio Sunat Venta :"
        '
        'grpTPago
        '
        Me.grpTPago.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpTPago.Controls.Add(Me.cmbTipoPago)
        Me.grpTPago.Controls.Add(Me.Label27)
        Me.grpTPago.Controls.Add(Me.Label14)
        Me.grpTPago.Controls.Add(Me.dtpFecPago)
        Me.grpTPago.Location = New System.Drawing.Point(742, 72)
        Me.grpTPago.Name = "grpTPago"
        Me.grpTPago.Size = New System.Drawing.Size(472, 48)
        Me.grpTPago.TabIndex = 13
        Me.grpTPago.TabStop = False
        Me.grpTPago.Text = "Pago"
        '
        'cmbTipoPago
        '
        Me.cmbTipoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoPago.FormattingEnabled = True
        Me.cmbTipoPago.Location = New System.Drawing.Point(84, 16)
        Me.cmbTipoPago.Name = "cmbTipoPago"
        Me.cmbTipoPago.Size = New System.Drawing.Size(219, 23)
        Me.cmbTipoPago.TabIndex = 1
        Me.cmbTipoPago.Tag = "ECO"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(7, 20)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(68, 15)
        Me.Label27.TabIndex = 0
        Me.Label27.Text = "Condicion :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(313, 20)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(44, 15)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "Fecha :"
        '
        'dtpFecPago
        '
        Me.dtpFecPago.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecPago.Location = New System.Drawing.Point(366, 16)
        Me.dtpFecPago.Name = "dtpFecPago"
        Me.dtpFecPago.Size = New System.Drawing.Size(100, 23)
        Me.dtpFecPago.TabIndex = 3
        '
        'actxaProvRazonSocial
        '
        Me.actxaProvRazonSocial.ACActivarAyudaAuto = False
        Me.actxaProvRazonSocial.ACLongitudAceptada = 0
        Me.actxaProvRazonSocial.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.actxaProvRazonSocial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.actxaProvRazonSocial.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
        Me.actxaProvRazonSocial.Location = New System.Drawing.Point(283, 41)
        Me.actxaProvRazonSocial.MaxLength = 32767
        Me.actxaProvRazonSocial.Name = "actxaProvRazonSocial"
        Me.actxaProvRazonSocial.Size = New System.Drawing.Size(845, 26)
        Me.actxaProvRazonSocial.TabIndex = 9
        Me.actxaProvRazonSocial.Tag = "EVO"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(145, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.actxaOrdCompra)
        Me.GroupBox1.Location = New System.Drawing.Point(2, -3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(274, 42)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(10, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Orden de Compra :"
        '
        'actxaOrdCompra
        '
        Me.actxaOrdCompra.ACActivarAyudaAuto = False
        Me.actxaOrdCompra.ACLongitudAceptada = 0
        Me.actxaOrdCompra.Location = New System.Drawing.Point(130, 14)
        Me.actxaOrdCompra.MaxLength = 32767
        Me.actxaOrdCompra.Name = "actxaOrdCompra"
        Me.actxaOrdCompra.Size = New System.Drawing.Size(129, 23)
        Me.actxaOrdCompra.TabIndex = 1
        Me.actxaOrdCompra.Tag = "EV"
        '
        'actxnTipoCambio
        '
        Me.actxnTipoCambio.ACDecimales = 4
        Me.actxnTipoCambio.ACEnteros = 9
        Me.actxnTipoCambio.ACFormato = "###,###,##0.0000"
        Me.actxnTipoCambio.ACNegativo = True
        Me.actxnTipoCambio.ACValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.actxnTipoCambio.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.actxnTipoCambio.Location = New System.Drawing.Point(971, 7)
        Me.actxnTipoCambio.MaxLength = 12
        Me.actxnTipoCambio.Name = "actxnTipoCambio"
        Me.actxnTipoCambio.ReadOnly = True
        Me.actxnTipoCambio.Size = New System.Drawing.Size(60, 23)
        Me.actxnTipoCambio.TabIndex = 4
        Me.actxnTipoCambio.Tag = "EVO"
        Me.actxnTipoCambio.Text = "0.0000"
        Me.actxnTipoCambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dtpFecha
        '
        Me.dtpFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(1104, 7)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(98, 23)
        Me.dtpFecha.TabIndex = 6
        '
        'btnClean
        '
        Me.btnClean.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClean.Image = Global.ACPLogistica.My.Resources.Resources.Delete_16x16
        Me.btnClean.Location = New System.Drawing.Point(1177, 41)
        Me.btnClean.Name = "btnClean"
        Me.btnClean.Size = New System.Drawing.Size(28, 27)
        Me.btnClean.TabIndex = 11
        Me.btnClean.TabStop = False
        Me.btnClean.UseVisualStyleBackColor = True
        '
        'actxaProvRuc
        '
        Me.actxaProvRuc.ACActivarAyudaAuto = False
        Me.actxaProvRuc.ACLongitudAceptada = 0
        Me.actxaProvRuc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.actxaProvRuc.Location = New System.Drawing.Point(132, 43)
        Me.actxaProvRuc.MaxLength = 32767
        Me.actxaProvRuc.Name = "actxaProvRuc"
        Me.actxaProvRuc.Size = New System.Drawing.Size(129, 23)
        Me.actxaProvRuc.TabIndex = 8
        Me.actxaProvRuc.Tag = "EVO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(56, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 15)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Proveedor :"
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
        Me.tabBusqueda.Size = New System.Drawing.Size(1215, 441)
        Me.tabBusqueda.TabIndex = 5
        Me.tabBusqueda.Title = "Busqueda"
        Me.tabBusqueda.ToolTip = "Busqueda"
        '
        'c1grdBusqueda
        '
        Me.c1grdBusqueda.ColumnInfo = "2,1,0,0,0,100,Columns:0{Width:25;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.c1grdBusqueda.Dock = System.Windows.Forms.DockStyle.Fill
        Me.c1grdBusqueda.Location = New System.Drawing.Point(0, 118)
        Me.c1grdBusqueda.Name = "c1grdBusqueda"
        Me.c1grdBusqueda.Rows.Count = 2
        Me.c1grdBusqueda.Rows.DefaultSize = 20
        Me.c1grdBusqueda.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.c1grdBusqueda.Size = New System.Drawing.Size(1215, 298)
        Me.c1grdBusqueda.StyleInfo = resources.GetString("c1grdBusqueda.StyleInfo")
        Me.c1grdBusqueda.TabIndex = 2
        '
        'grpBusqueda
        '
        Me.grpBusqueda.Controls.Add(Me.chkAgrupar)
        Me.grpBusqueda.Controls.Add(Me.btnConsultar)
        Me.grpBusqueda.Controls.Add(Me.chkTodos)
        Me.grpBusqueda.Controls.Add(Me.rbtnDatos)
        Me.grpBusqueda.Controls.Add(Me.acFecha)
        Me.grpBusqueda.Controls.Add(Me.grpCliente)
        Me.grpBusqueda.Controls.Add(Me.rbtnDocVenta)
        Me.grpBusqueda.Controls.Add(Me.grpDocumentos)
        Me.grpBusqueda.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpBusqueda.Location = New System.Drawing.Point(0, 0)
        Me.grpBusqueda.Name = "grpBusqueda"
        Me.grpBusqueda.Size = New System.Drawing.Size(1215, 118)
        Me.grpBusqueda.TabIndex = 5
        Me.grpBusqueda.TabStop = False
        Me.grpBusqueda.Text = "Opciones de Busqueda"
        '
        'chkAgrupar
        '
        Me.chkAgrupar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkAgrupar.AutoSize = True
        Me.chkAgrupar.Location = New System.Drawing.Point(693, 20)
        Me.chkAgrupar.Name = "chkAgrupar"
        Me.chkAgrupar.Size = New System.Drawing.Size(69, 19)
        Me.chkAgrupar.TabIndex = 33
        Me.chkAgrupar.Text = "Agrupar"
        Me.chkAgrupar.UseVisualStyleBackColor = True
        '
        'btnConsultar
        '
        Me.btnConsultar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnConsultar.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.btnConsultar.Image = Global.ACPLogistica.My.Resources.Resources.Search_files_32x32
        Me.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConsultar.Location = New System.Drawing.Point(1110, 63)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(99, 42)
        Me.btnConsultar.TabIndex = 31
        Me.btnConsultar.Text = "Consultar"
        Me.btnConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'chkTodos
        '
        Me.chkTodos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkTodos.AutoSize = True
        Me.chkTodos.Location = New System.Drawing.Point(772, 20)
        Me.chkTodos.Name = "chkTodos"
        Me.chkTodos.Size = New System.Drawing.Size(101, 19)
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
        Me.rbtnDatos.Size = New System.Drawing.Size(181, 19)
        Me.rbtnDatos.TabIndex = 12
        Me.rbtnDatos.TabStop = True
        Me.rbtnDatos.Text = "Datos de la Orden de Compra"
        Me.rbtnDatos.UseVisualStyleBackColor = True
        '
        'acFecha
        '
        Me.acFecha.ACFecha_A = New Date(2025, 9, 20, 13, 0, 10, 662)
        Me.acFecha.ACFecha_De = New Date(2025, 9, 20, 13, 0, 10, 660)
        Me.acFecha.ACFechaObligatoria = True
        Me.acFecha.ACFormatoControl = ACControles.ACFecha.ACTipoFormatoControl.Horizontal
        Me.acFecha.ACHoyChecked = False
        Me.acFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.acFecha.Location = New System.Drawing.Point(879, 0)
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
        Me.grpCliente.Size = New System.Drawing.Size(814, 63)
        Me.grpCliente.TabIndex = 13
        Me.grpCliente.TabStop = False
        '
        'txtBusqueda
        '
        Me.txtBusqueda.ACActivarAyudaAuto = False
        Me.txtBusqueda.ACLongitudAceptada = 0
        Me.txtBusqueda.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBusqueda.Location = New System.Drawing.Point(6, 36)
        Me.txtBusqueda.MaxLength = 32767
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(795, 23)
        Me.txtBusqueda.TabIndex = 0
        '
        'rbtnProveedor
        '
        Me.rbtnProveedor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbtnProveedor.AutoSize = True
        Me.rbtnProveedor.Checked = True
        Me.rbtnProveedor.Location = New System.Drawing.Point(573, 15)
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
        Me.rbtnNroOrdenCompra.Location = New System.Drawing.Point(658, 15)
        Me.rbtnNroOrdenCompra.Name = "rbtnNroOrdenCompra"
        Me.rbtnNroOrdenCompra.Size = New System.Drawing.Size(143, 19)
        Me.rbtnNroOrdenCompra.TabIndex = 2
        Me.rbtnNroOrdenCompra.Text = "Nro Orden de Compra"
        Me.rbtnNroOrdenCompra.UseVisualStyleBackColor = True
        '
        'rbtnDocVenta
        '
        Me.rbtnDocVenta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbtnDocVenta.AutoSize = True
        Me.rbtnDocVenta.Location = New System.Drawing.Point(829, 45)
        Me.rbtnDocVenta.Name = "rbtnDocVenta"
        Me.rbtnDocVenta.Size = New System.Drawing.Size(136, 19)
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
        Me.grpDocumentos.Location = New System.Drawing.Point(826, 48)
        Me.grpDocumentos.Name = "grpDocumentos"
        Me.grpDocumentos.Size = New System.Drawing.Size(278, 63)
        Me.grpDocumentos.TabIndex = 14
        Me.grpDocumentos.TabStop = False
        '
        'txtCSerie
        '
        Me.txtCSerie.Location = New System.Drawing.Point(119, 36)
        Me.txtCSerie.MaxLength = 4
        Me.txtCSerie.Name = "txtCSerie"
        Me.txtCSerie.Size = New System.Drawing.Size(45, 23)
        Me.txtCSerie.TabIndex = 28
        Me.txtCSerie.Tag = "EVO"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(180, 17)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(51, 15)
        Me.Label18.TabIndex = 11
        Me.Label18.Text = "Numero"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(120, 17)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(32, 15)
        Me.Label22.TabIndex = 10
        Me.Label22.Text = "Serie"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(11, 17)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(57, 15)
        Me.Label24.TabIndex = 9
        Me.Label24.Text = "Tipo Doc."
        '
        'cmbTipoDocumento
        '
        Me.cmbTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoDocumento.DropDownWidth = 250
        Me.cmbTipoDocumento.FormattingEnabled = True
        Me.cmbTipoDocumento.Location = New System.Drawing.Point(6, 36)
        Me.cmbTipoDocumento.Name = "cmbTipoDocumento"
        Me.cmbTipoDocumento.Size = New System.Drawing.Size(107, 23)
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
        Me.txtBusNumero.Size = New System.Drawing.Size(91, 23)
        Me.txtBusNumero.TabIndex = 7
        '
        'bnavBusqueda
        '
        Me.bnavBusqueda.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.bnavBusqueda.CountItem = Me.BindingNavigatorCountItem
        Me.bnavBusqueda.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.bnavBusqueda.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.bnavBusqueda.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.tsbtnExcel})
        Me.bnavBusqueda.Location = New System.Drawing.Point(0, 416)
        Me.bnavBusqueda.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.bnavBusqueda.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.bnavBusqueda.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.bnavBusqueda.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.bnavBusqueda.Name = "bnavBusqueda"
        Me.bnavBusqueda.PositionItem = Me.BindingNavigatorPositionItem
        Me.bnavBusqueda.Size = New System.Drawing.Size(1215, 25)
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
        Me.acpnlTitulo.ACCaption = "Registro de Compra"
        Me.acpnlTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.acpnlTitulo.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.acpnlTitulo.Location = New System.Drawing.Point(0, 0)
        Me.acpnlTitulo.Name = "acpnlTitulo"
        Me.acpnlTitulo.Size = New System.Drawing.Size(1217, 40)
        Me.acpnlTitulo.TabIndex = 16
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
        Me.acTool.ACBtnImprimirEnabled = False
        Me.acTool.ACBtnImprimirVisible = False
        Me.acTool.ACBtnRehusarEnabled = False
        Me.acTool.ACBtnRehusarVisible = False
        Me.acTool.ACBtnReporteEnabled = False
        Me.acTool.ACBtnReporteVisible = False
        Me.acTool.ACBtnSalirText = "&Salir"
        Me.acTool.ACBtnVolverEnabled = False
        Me.acTool.ACBtnVolverVisible = False
        Me.acTool.ACTipoToolBar = ACControles.ACToolBarMantHorizontalNew.tipoToolBar.ToolNuevoGrabarAnular
        Me.acTool.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.acTool.Font = New System.Drawing.Font("Tahoma", 9.5!)
        Me.acTool.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.acTool.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.actsbtnPrevisualizar, Me.acbtnSeleccionar})
        Me.acTool.Location = New System.Drawing.Point(0, 506)
        Me.acTool.Name = "acTool"
        Me.acTool.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.acTool.Size = New System.Drawing.Size(1217, 56)
        Me.acTool.TabIndex = 15
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
        Me.actsbtnPrevisualizar.Text = "Pre&visualizar"
        Me.actsbtnPrevisualizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.actsbtnPrevisualizar.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        Me.actsbtnPrevisualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
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
        'eprError
        '
        Me.eprError.ContainerControl = Me
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.actxnCotizacionProveedor)
        Me.GroupBox2.Controls.Add(Me.Label28)
        Me.GroupBox2.Location = New System.Drawing.Point(740, 126)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(472, 48)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cotizacion Proveedor"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(1, 19)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(80, 15)
        Me.Label28.TabIndex = 0
        Me.Label28.Text = "Nº Cotizacion"
        '
        'actxnCotizacionProveedor
        '
        Me.actxnCotizacionProveedor.Location = New System.Drawing.Point(87, 14)
        Me.actxnCotizacionProveedor.Name = "actxnCotizacionProveedor"
        Me.actxnCotizacionProveedor.Size = New System.Drawing.Size(218, 23)
        Me.actxnCotizacionProveedor.TabIndex = 1
        '
        'TRegCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1217, 562)
        Me.Controls.Add(Me.tabMantenimiento)
        Me.Controls.Add(Me.acpnlTitulo)
        Me.Controls.Add(Me.acTool)
        Me.MinimumSize = New System.Drawing.Size(800, 500)
        Me.Name = "TRegCompra"
        Me.Text = "Registro de Compra"
        Me.tabMantenimiento.ResumeLayout(False)
        Me.tabDatos.ResumeLayout(False)
        Me.pnlDatos.ResumeLayout(False)
        Me.pnlDetalle.ResumeLayout(False)
        Me.pnlDetalle.PerformLayout()
        CType(Me.c1grdDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bnavProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bnavProductos.ResumeLayout(False)
        Me.bnavProductos.PerformLayout()
        Me.pnlDetCabecera.ResumeLayout(False)
        Me.pnlDetCabecera.PerformLayout()
        Me.pnlPie.ResumeLayout(False)
        Me.pnlPie.PerformLayout()
        Me.pnlCabecera.ResumeLayout(False)
        Me.pnlCabecera.PerformLayout()
        Me.grpCosteo.ResumeLayout(False)
        Me.grpCosteo.PerformLayout()
        Me.grpDocumento.ResumeLayout(False)
        Me.grpDocumento.PerformLayout()
        Me.grpTPago.ResumeLayout(False)
        Me.grpTPago.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
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
        CType(Me.eprError, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
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
    Friend WithEvents pnlDetCabecera As System.Windows.Forms.Panel
    Friend WithEvents txtOpcion As System.Windows.Forms.TextBox
    Friend WithEvents actxnProdSubImporte As ACControles.ACTextBoxNumerico
    Friend WithEvents actxnProdPesoDoc As ACControles.ACTextBoxNumerico
    Friend WithEvents actxnProdCantidad As ACControles.ACTextBoxNumerico
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtProdDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents actxaProdCodigo As ACControles.ACTextBoxAyuda
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
    Friend WithEvents actxaProvRuc As ACControles.ACTextBoxAyuda
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents actxaProvRazonSocial As ACControles.ACTextBoxAyuda
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
    Friend WithEvents grpDocumento As System.Windows.Forms.GroupBox
    Friend WithEvents cmbDocumento As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents dtpFecPago As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents actxnTipoCambio As ACControles.ACTextBoxNumerico
    Friend WithEvents grpTPago As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents actxnImporte As ACControles.ACTextBoxNumerico
    Friend WithEvents actxnPesoTotal As ACControles.ACTextBoxNumerico
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents actxnNumero As ACControles.ACTextBoxNumerico
    Friend WithEvents actxnProdPeso As ACControles.ACTextBoxNumerico
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtProdUnidad As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents actxnProdPrecUnitario As ACControles.ACTextBoxNumerico
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents cmbProdDestino As System.Windows.Forms.ComboBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents cmbTipoPago As System.Windows.Forms.ComboBox
    Friend WithEvents btnNuevoCliente As System.Windows.Forms.Button
    Friend WithEvents btnClean As System.Windows.Forms.Button
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
    Friend WithEvents actxaOrdCompra As ACControles.ACTextBoxAyuda
    Friend WithEvents txtSerie As System.Windows.Forms.TextBox
    Friend WithEvents txtCSerie As System.Windows.Forms.TextBox
    Friend WithEvents btnCalcular As System.Windows.Forms.Button
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents btnConsultar As System.Windows.Forms.Button
    Friend WithEvents chkAgrupar As System.Windows.Forms.CheckBox
    Friend WithEvents cmbGDestino As System.Windows.Forms.ComboBox
    Friend WithEvents acbtnSeleccionar As ACControles.ACToolStripButton
    Friend WithEvents tsbtnAsigDestino As System.Windows.Forms.ToolStripButton
    Friend WithEvents tscmbDestino As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents eprError As System.Windows.Forms.ErrorProvider
    Friend WithEvents txtCodigoSAP As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents actsbtnPrevisualizar As ACControles.ACToolStripButton
    Friend WithEvents grpCosteo As System.Windows.Forms.GroupBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtGastos As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtDescuento As System.Windows.Forms.TextBox
    Friend WithEvents txtFlete As System.Windows.Forms.TextBox
    Friend WithEvents tsbtnExcel As ToolStripButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents actxnCotizacionProveedor As TextBox
    Friend WithEvents Label28 As Label
End Class
