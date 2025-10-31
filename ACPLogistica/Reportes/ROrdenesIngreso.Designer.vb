<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ROrdenesIngreso
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ROrdenesIngreso))
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
        Me.cmbtipoordenes = New System.Windows.Forms.ComboBox()
        Me.actxnNumero = New ACControles.ACTextBoxNumerico()
        Me.cmbGuiaSerie = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.pnlCabecera = New System.Windows.Forms.Panel()
        Me.grpObservaciones = New System.Windows.Forms.GroupBox()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.txtDirDestino = New System.Windows.Forms.TextBox()
        Me.cmbDirOrigen = New System.Windows.Forms.ComboBox()
        Me.cmbDirCliente = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.grpFlete = New System.Windows.Forms.GroupBox()
        Me.cmbEntrega = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDocOrigen = New System.Windows.Forms.TextBox()
        Me.cmbPuntoVenta = New System.Windows.Forms.ComboBox()
        Me.dtpFechaEmision = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.actxaDescCliente = New ACControles.ACTextBoxAyuda()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.actxaCodCliente = New ACControles.ACTextBoxAyuda()
        Me.tabBusGuias = New Crownwood.DotNetMagic.Controls.TabPage()
        Me.c1grdReporte = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.c1grdPuntosVentas = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.chkctodos = New System.Windows.Forms.CheckBox()
        Me.btnExcel = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
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
        CType(Me.bnavProductos,System.ComponentModel.ISupportInitialize).BeginInit
        Me.bnavProductos.SuspendLayout
        Me.pnlPie.SuspendLayout
        Me.grpDocumento.SuspendLayout
        Me.pnlCabecera.SuspendLayout
        Me.grpObservaciones.SuspendLayout
        Me.grpFlete.SuspendLayout
        Me.tabBusGuias.SuspendLayout
        CType(Me.c1grdReporte,System.ComponentModel.ISupportInitialize).BeginInit
        Me.Panel1.SuspendLayout
        Me.GroupBox3.SuspendLayout
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
        Me.tabMantenimiento.Size = New System.Drawing.Size(1312, 680)
        Me.tabMantenimiento.TabIndex = 20
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
        Me.tabDatos.Size = New System.Drawing.Size(1310, 655)
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
        Me.pnlDatos.Size = New System.Drawing.Size(1310, 655)
        Me.pnlDatos.TabIndex = 1
        '
        'pnlDetalle
        '
        Me.pnlDetalle.Controls.Add(Me.c1grdDetalle)
        Me.pnlDetalle.Controls.Add(Me.tbcDetalles)
        Me.pnlDetalle.Controls.Add(Me.bnavProductos)
        Me.pnlDetalle.Controls.Add(Me.pnlPie)
        Me.pnlDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDetalle.Location = New System.Drawing.Point(0, 273)
        Me.pnlDetalle.Name = "pnlDetalle"
        Me.pnlDetalle.Size = New System.Drawing.Size(1310, 382)
        Me.pnlDetalle.TabIndex = 2
        '
        'c1grdDetalle
        '
        Me.c1grdDetalle.BackColor = System.Drawing.Color.White
        Me.c1grdDetalle.ColumnInfo = "2,1,0,0,0,100,Columns:0{Width:20;}"&Global.Microsoft.VisualBasic.ChrW(9)&"1{Width:103;Caption:""Codigo"";}"&Global.Microsoft.VisualBasic.ChrW(9)
        Me.c1grdDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.c1grdDetalle.Location = New System.Drawing.Point(0, 0)
        Me.c1grdDetalle.Name = "c1grdDetalle"
        Me.c1grdDetalle.Rows.Count = 2
        Me.c1grdDetalle.Rows.DefaultSize = 20
        Me.c1grdDetalle.Size = New System.Drawing.Size(784, 307)
        Me.c1grdDetalle.StyleInfo = resources.GetString("c1grdDetalle.StyleInfo")
        Me.c1grdDetalle.TabIndex = 16
        '
        'tbcDetalles
        '
        Me.tbcDetalles.BackColor = System.Drawing.Color.LightSteelBlue
        Me.tbcDetalles.BoldSelectedPage = true
        Me.tbcDetalles.Dock = System.Windows.Forms.DockStyle.Right
        Me.tbcDetalles.Location = New System.Drawing.Point(784, 0)
        Me.tbcDetalles.MediaPlayerDockSides = false
        Me.tbcDetalles.Name = "tbcDetalles"
        Me.tbcDetalles.OfficeDockSides = false
        Me.tbcDetalles.PositionTop = true
        Me.tbcDetalles.SelectedIndex = 0
        Me.tbcDetalles.ShowArrows = true
        Me.tbcDetalles.ShowDropSelect = false
        Me.tbcDetalles.Size = New System.Drawing.Size(526, 307)
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
        Me.tpgDetAnulacion.Size = New System.Drawing.Size(524, 282)
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
        Me.txtMotivoAnulacion.Size = New System.Drawing.Size(444, 193)
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
        'bnavProductos
        '
        Me.bnavProductos.AddNewItem = Me.ToolStripButton1
        Me.bnavProductos.CountItem = Me.ToolStripLabel1
        Me.bnavProductos.DeleteItem = Me.ToolStripButton2
        Me.bnavProductos.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.bnavProductos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripSeparator1, Me.ToolStripTextBox1, Me.ToolStripLabel1, Me.ToolStripSeparator2, Me.ToolStripButton5, Me.ToolStripButton6, Me.ToolStripSeparator3, Me.ToolStripButton1, Me.ToolStripButton2, Me.tscmbImpresora, Me.ToolStripLabel5, Me.ToolStripSeparator13})
        Me.bnavProductos.Location = New System.Drawing.Point(0, 307)
        Me.bnavProductos.MoveFirstItem = Me.ToolStripButton3
        Me.bnavProductos.MoveLastItem = Me.ToolStripButton6
        Me.bnavProductos.MoveNextItem = Me.ToolStripButton5
        Me.bnavProductos.MovePreviousItem = Me.ToolStripButton4
        Me.bnavProductos.Name = "bnavProductos"
        Me.bnavProductos.PositionItem = Me.ToolStripTextBox1
        Me.bnavProductos.Size = New System.Drawing.Size(1310, 25)
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
        Me.pnlPie.Location = New System.Drawing.Point(0, 332)
        Me.pnlPie.Name = "pnlPie"
        Me.pnlPie.Size = New System.Drawing.Size(1310, 50)
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
        Me.btnRevision.Size = New System.Drawing.Size(141, 43)
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
        Me.actxnPesoTotal.Location = New System.Drawing.Point(1182, 15)
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
        Me.Label3.Location = New System.Drawing.Point(1098, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Peso Total :"
        '
        'grpDocumento
        '
        Me.grpDocumento.BackColor = System.Drawing.Color.FromArgb(CType(CType(3,Byte),Integer), CType(CType(55,Byte),Integer), CType(CType(145,Byte),Integer))
        Me.grpDocumento.Controls.Add(Me.cmbtipoordenes)
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
        'cmbtipoordenes
        '
        Me.cmbtipoordenes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbtipoordenes.Enabled = false
        Me.cmbtipoordenes.Font = New System.Drawing.Font("Segoe UI", 14!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
        Me.cmbtipoordenes.FormattingEnabled = true
        Me.cmbtipoordenes.Items.AddRange(New Object() {"Boleta", "Factura"})
        Me.cmbtipoordenes.Location = New System.Drawing.Point(7, 16)
        Me.cmbtipoordenes.Name = "cmbtipoordenes"
        Me.cmbtipoordenes.Size = New System.Drawing.Size(235, 27)
        Me.cmbtipoordenes.TabIndex = 0
        Me.cmbtipoordenes.Tag = "C"
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
        Me.pnlCabecera.Controls.Add(Me.grpObservaciones)
        Me.pnlCabecera.Controls.Add(Me.txtDirDestino)
        Me.pnlCabecera.Controls.Add(Me.cmbDirOrigen)
        Me.pnlCabecera.Controls.Add(Me.cmbDirCliente)
        Me.pnlCabecera.Controls.Add(Me.Label7)
        Me.pnlCabecera.Controls.Add(Me.grpFlete)
        Me.pnlCabecera.Controls.Add(Me.Label14)
        Me.pnlCabecera.Controls.Add(Me.Label16)
        Me.pnlCabecera.Controls.Add(Me.actxaDescCliente)
        Me.pnlCabecera.Controls.Add(Me.Label2)
        Me.pnlCabecera.Controls.Add(Me.actxaCodCliente)
        Me.pnlCabecera.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlCabecera.Location = New System.Drawing.Point(0, 0)
        Me.pnlCabecera.Name = "pnlCabecera"
        Me.pnlCabecera.Size = New System.Drawing.Size(1310, 273)
        Me.pnlCabecera.TabIndex = 1
        '
        'grpObservaciones
        '
        Me.grpObservaciones.Controls.Add(Me.txtObservaciones)
        Me.grpObservaciones.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.grpObservaciones.Location = New System.Drawing.Point(0, 211)
        Me.grpObservaciones.Name = "grpObservaciones"
        Me.grpObservaciones.Padding = New System.Windows.Forms.Padding(5, 1, 5, 5)
        Me.grpObservaciones.Size = New System.Drawing.Size(1310, 62)
        Me.grpObservaciones.TabIndex = 33
        Me.grpObservaciones.TabStop = false
        Me.grpObservaciones.Text = "Observaciones"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtObservaciones.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtObservaciones.Location = New System.Drawing.Point(5, 17)
        Me.txtObservaciones.MaxLength = 200
        Me.txtObservaciones.Multiline = true
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservaciones.Size = New System.Drawing.Size(1300, 40)
        Me.txtObservaciones.TabIndex = 0
        Me.txtObservaciones.Tag = "EV"
        '
        'txtDirDestino
        '
        Me.txtDirDestino.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDirDestino.Location = New System.Drawing.Point(130, 185)
        Me.txtDirDestino.Name = "txtDirDestino"
        Me.txtDirDestino.Size = New System.Drawing.Size(708, 23)
        Me.txtDirDestino.TabIndex = 32
        Me.txtDirDestino.Tag = "V"
        '
        'cmbDirOrigen
        '
        Me.cmbDirOrigen.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.cmbDirOrigen.FormattingEnabled = true
        Me.cmbDirOrigen.Location = New System.Drawing.Point(130, 103)
        Me.cmbDirOrigen.Name = "cmbDirOrigen"
        Me.cmbDirOrigen.Size = New System.Drawing.Size(1169, 23)
        Me.cmbDirOrigen.TabIndex = 31
        Me.cmbDirOrigen.Tag = ""
        '
        'cmbDirCliente
        '
        Me.cmbDirCliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.cmbDirCliente.FormattingEnabled = true
        Me.cmbDirCliente.Location = New System.Drawing.Point(130, 156)
        Me.cmbDirCliente.Name = "cmbDirCliente"
        Me.cmbDirCliente.Size = New System.Drawing.Size(1169, 23)
        Me.cmbDirCliente.TabIndex = 30
        Me.cmbDirCliente.Tag = "ECO"
        '
        'Label7
        '
        Me.Label7.AutoSize = true
        Me.Label7.Location = New System.Drawing.Point(5, 191)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 15)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Dirección Llegada :"
        '
        'grpFlete
        '
        Me.grpFlete.BackColor = System.Drawing.Color.FromArgb(CType(CType(3,Byte),Integer), CType(CType(55,Byte),Integer), CType(CType(145,Byte),Integer))
        Me.grpFlete.Controls.Add(Me.cmbEntrega)
        Me.grpFlete.Controls.Add(Me.Label8)
        Me.grpFlete.Controls.Add(Me.Label5)
        Me.grpFlete.Controls.Add(Me.txtDocOrigen)
        Me.grpFlete.Controls.Add(Me.cmbPuntoVenta)
        Me.grpFlete.Controls.Add(Me.dtpFechaEmision)
        Me.grpFlete.Controls.Add(Me.Label1)
        Me.grpFlete.Controls.Add(Me.Label4)
        Me.grpFlete.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpFlete.Location = New System.Drawing.Point(0, 0)
        Me.grpFlete.Name = "grpFlete"
        Me.grpFlete.Size = New System.Drawing.Size(1310, 89)
        Me.grpFlete.TabIndex = 0
        Me.grpFlete.TabStop = false
        '
        'cmbEntrega
        '
        Me.cmbEntrega.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.cmbEntrega.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEntrega.Enabled = false
        Me.cmbEntrega.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cmbEntrega.FormattingEnabled = true
        Me.cmbEntrega.Location = New System.Drawing.Point(1147, 52)
        Me.cmbEntrega.Name = "cmbEntrega"
        Me.cmbEntrega.Size = New System.Drawing.Size(157, 25)
        Me.cmbEntrega.TabIndex = 32
        Me.cmbEntrega.Tag = "ECO"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = true
        Me.Label8.Enabled = false
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(1032, 58)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(114, 15)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Condición Entrega: :"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = true
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(1031, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 15)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Documento Origen :"
        '
        'txtDocOrigen
        '
        Me.txtDocOrigen.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtDocOrigen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDocOrigen.Location = New System.Drawing.Point(1147, 22)
        Me.txtDocOrigen.Name = "txtDocOrigen"
        Me.txtDocOrigen.ReadOnly = true
        Me.txtDocOrigen.Size = New System.Drawing.Size(141, 23)
        Me.txtDocOrigen.TabIndex = 29
        Me.txtDocOrigen.Tag = "VO"
        '
        'cmbPuntoVenta
        '
        Me.cmbPuntoVenta.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.cmbPuntoVenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPuntoVenta.Font = New System.Drawing.Font("Segoe UI", 15!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
        Me.cmbPuntoVenta.FormattingEnabled = true
        Me.cmbPuntoVenta.Location = New System.Drawing.Point(103, 45)
        Me.cmbPuntoVenta.Name = "cmbPuntoVenta"
        Me.cmbPuntoVenta.Size = New System.Drawing.Size(911, 28)
        Me.cmbPuntoVenta.TabIndex = 28
        Me.cmbPuntoVenta.Tag = "ECO"
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
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(20, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 15)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Orden Para :"
        '
        'Label14
        '
        Me.Label14.AutoSize = true
        Me.Label14.Location = New System.Drawing.Point(9, 159)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(103, 15)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "Dirección Cliente :"
        '
        'Label16
        '
        Me.Label16.AutoSize = true
        Me.Label16.Location = New System.Drawing.Point(10, 106)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(102, 15)
        Me.Label16.TabIndex = 5
        Me.Label16.Text = "Dirección Origen :"
        '
        'actxaDescCliente
        '
        Me.actxaDescCliente.ACActivarAyudaAuto = false
        Me.actxaDescCliente.ACLongitudAceptada = 0
        Me.actxaDescCliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.actxaDescCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.actxaDescCliente.Enabled = false
        Me.actxaDescCliente.Location = New System.Drawing.Point(250, 129)
        Me.actxaDescCliente.MaxLength = 80
        Me.actxaDescCliente.Name = "actxaDescCliente"
        Me.actxaDescCliente.Size = New System.Drawing.Size(1049, 23)
        Me.actxaDescCliente.TabIndex = 12
        Me.actxaDescCliente.Tag = "VO"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Location = New System.Drawing.Point(61, 133)
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
        Me.actxaCodCliente.Location = New System.Drawing.Point(130, 129)
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
        Me.tabBusGuias.Size = New System.Drawing.Size(1310, 655)
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
        Me.c1grdReporte.Size = New System.Drawing.Size(1310, 523)
        Me.c1grdReporte.StyleInfo = resources.GetString("c1grdReporte.StyleInfo")
        Me.c1grdReporte.TabIndex = 74
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Controls.Add(Me.chkctodos)
        Me.Panel1.Controls.Add(Me.btnExcel)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.btnProcesar)
        Me.Panel1.Controls.Add(Me.AcFecha)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1310, 107)
        Me.Panel1.TabIndex = 73
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.c1grdPuntosVentas)
        Me.GroupBox3.Location = New System.Drawing.Point(723, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(230, 100)
        Me.GroupBox3.TabIndex = 30
        Me.GroupBox3.TabStop = false
        Me.GroupBox3.Text = "Puntos de Ventas"
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
        Me.c1grdPuntosVentas.Size = New System.Drawing.Size(224, 78)
        Me.c1grdPuntosVentas.StyleInfo = resources.GetString("c1grdPuntosVentas.StyleInfo")
        Me.c1grdPuntosVentas.TabIndex = 8
        '
        'chkctodos
        '
        Me.chkctodos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.chkctodos.AutoSize = true
        Me.chkctodos.Location = New System.Drawing.Point(958, 60)
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
        Me.btnExcel.Location = New System.Drawing.Point(1260, 60)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(42, 41)
        Me.btnExcel.TabIndex = 17
        Me.btnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExcel.UseVisualStyleBackColor = true
        Me.btnExcel.Visible = false
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.actxaCliRazonSocial)
        Me.GroupBox1.Controls.Add(Me.actxaCliRuc)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(710, 48)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = false
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.Location = New System.Drawing.Point(6, -2)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 15)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Cliente"
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
        Me.actxaCliRazonSocial.Size = New System.Drawing.Size(570, 24)
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
        Me.btnProcesar.Location = New System.Drawing.Point(1134, 60)
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(120, 41)
        Me.btnProcesar.TabIndex = 10
        Me.btnProcesar.Text = "Procesar"
        Me.btnProcesar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnProcesar.UseVisualStyleBackColor = true
        '
        'AcFecha
        '
        Me.AcFecha.ACFecha_A = New Date(2023, 6, 28, 12, 31, 18, 389)
        Me.AcFecha.ACFecha_De = New Date(2023, 6, 28, 12, 31, 18, 387)
        Me.AcFecha.ACFechaObligatoria = true
        Me.AcFecha.ACFormatoControl = ACControles.ACFecha.ACTipoFormatoControl.Horizontal
        Me.AcFecha.ACHoyChecked = false
        Me.AcFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.AcFecha.Location = New System.Drawing.Point(965, 4)
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
        Me.bnavCBusqueda.Location = New System.Drawing.Point(0, 630)
        Me.bnavCBusqueda.MoveFirstItem = Me.ToolStripButton9
        Me.bnavCBusqueda.MoveLastItem = Me.ToolStripButton12
        Me.bnavCBusqueda.MoveNextItem = Me.ToolStripButton11
        Me.bnavCBusqueda.MovePreviousItem = Me.ToolStripButton10
        Me.bnavCBusqueda.Name = "bnavCBusqueda"
        Me.bnavCBusqueda.PositionItem = Me.ToolStripTextBox2
        Me.bnavCBusqueda.Size = New System.Drawing.Size(1310, 25)
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
        Me.acpnlTitulo.ACCaption = "Reporte Ordenes de Ingreso"
        Me.acpnlTitulo.ActiveGradientHighColor = System.Drawing.Color.FromArgb(CType(CType(192,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer))
        Me.acpnlTitulo.ActiveGradientLowColor = System.Drawing.Color.Maroon
        Me.acpnlTitulo.ActiveTextColor = System.Drawing.Color.White
        Me.acpnlTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.acpnlTitulo.Font = New System.Drawing.Font("Tahoma", 14!, System.Drawing.FontStyle.Bold)
        Me.acpnlTitulo.InactiveGradientHighColor = System.Drawing.Color.CornflowerBlue
        Me.acpnlTitulo.InactiveGradientLowColor = System.Drawing.Color.DarkBlue
        Me.acpnlTitulo.Location = New System.Drawing.Point(0, 0)
        Me.acpnlTitulo.Name = "acpnlTitulo"
        Me.acpnlTitulo.Size = New System.Drawing.Size(1312, 33)
        Me.acpnlTitulo.TabIndex = 19
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
        Me.acTool.Location = New System.Drawing.Point(0, 713)
        Me.acTool.Name = "acTool"
        Me.acTool.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.acTool.Size = New System.Drawing.Size(1312, 56)
        Me.acTool.TabIndex = 21
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
        Me.btnRevision2.Location = New System.Drawing.Point(741, 7)
        Me.btnRevision2.Name = "btnRevision2"
        Me.btnRevision2.Size = New System.Drawing.Size(131, 43)
        Me.btnRevision2.TabIndex = 8
        Me.btnRevision2.Text = "Revision 2"
        Me.btnRevision2.UseVisualStyleBackColor = false
        '
        'ROrdenesIngreso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1312, 769)
        Me.Controls.Add(Me.tabMantenimiento)
        Me.Controls.Add(Me.acpnlTitulo)
        Me.Controls.Add(Me.acTool)
        Me.Name = "ROrdenesIngreso"
        Me.Text = "ROrdenesIngreso"
        Me.tabMantenimiento.ResumeLayout(false)
        Me.tabDatos.ResumeLayout(false)
        Me.pnlDatos.ResumeLayout(false)
        Me.pnlDetalle.ResumeLayout(false)
        Me.pnlDetalle.PerformLayout
        CType(Me.c1grdDetalle,System.ComponentModel.ISupportInitialize).EndInit
        Me.tbcDetalles.ResumeLayout(false)
        Me.tpgDetAnulacion.ResumeLayout(false)
        Me.tpgDetAnulacion.PerformLayout
        CType(Me.bnavProductos,System.ComponentModel.ISupportInitialize).EndInit
        Me.bnavProductos.ResumeLayout(false)
        Me.bnavProductos.PerformLayout
        Me.pnlPie.ResumeLayout(false)
        Me.pnlPie.PerformLayout
        Me.grpDocumento.ResumeLayout(false)
        Me.grpDocumento.PerformLayout
        Me.pnlCabecera.ResumeLayout(false)
        Me.pnlCabecera.PerformLayout
        Me.grpObservaciones.ResumeLayout(false)
        Me.grpObservaciones.PerformLayout
        Me.grpFlete.ResumeLayout(false)
        Me.grpFlete.PerformLayout
        Me.tabBusGuias.ResumeLayout(false)
        Me.tabBusGuias.PerformLayout
        CType(Me.c1grdReporte,System.ComponentModel.ISupportInitialize).EndInit
        Me.Panel1.ResumeLayout(false)
        Me.Panel1.PerformLayout
        Me.GroupBox3.ResumeLayout(false)
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
    Friend WithEvents c1grdDetalle As C1.Win.C1FlexGrid.C1FlexGrid
    Private WithEvents tbcDetalles As Crownwood.DotNetMagic.Controls.TabControl
    Friend WithEvents tpgDetAnulacion As Crownwood.DotNetMagic.Controls.TabPage
    Friend WithEvents txtMotivoAnulacion As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents dtpFechaAnulacion As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label21 As System.Windows.Forms.Label
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
    Friend WithEvents btnRevision As System.Windows.Forms.Button
    Friend WithEvents actxnPesoTotal As ACControles.ACTextBoxNumerico
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents grpDocumento As System.Windows.Forms.GroupBox
    Friend WithEvents cmbtipoordenes As System.Windows.Forms.ComboBox
    Friend WithEvents actxnNumero As ACControles.ACTextBoxNumerico
    Friend WithEvents cmbGuiaSerie As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents pnlCabecera As System.Windows.Forms.Panel
    Friend WithEvents grpObservaciones As System.Windows.Forms.GroupBox
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents txtDirDestino As System.Windows.Forms.TextBox
    Friend WithEvents cmbDirOrigen As System.Windows.Forms.ComboBox
    Friend WithEvents cmbDirCliente As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents grpFlete As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDocOrigen As System.Windows.Forms.TextBox
    Friend WithEvents cmbPuntoVenta As System.Windows.Forms.ComboBox
    Friend WithEvents dtpFechaEmision As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents actxaDescCliente As ACControles.ACTextBoxAyuda
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents actxaCodCliente As ACControles.ACTextBoxAyuda
    Friend WithEvents tabBusGuias As Crownwood.DotNetMagic.Controls.TabPage
    Friend WithEvents c1grdReporte As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents chkctodos As System.Windows.Forms.CheckBox
    Friend WithEvents btnExcel As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents actxaCliRazonSocial As ACControles.ACTextBoxAyuda
    Friend WithEvents actxaCliRuc As ACControles.ACTextBoxAyuda
    Friend WithEvents btnProcesar As System.Windows.Forms.Button
    Friend WithEvents AcFecha As ACControles.ACFecha
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
    Private WithEvents acpnlTitulo As ACControles.ACPanelCaption
    Friend WithEvents acTool As ACControles.ACToolBarMantHorizontalNew
    Friend WithEvents actsbtnPrevisualizar As ACControles.ACToolStripButton
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents c1grdPuntosVentas As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents cmbEntrega As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnRevision2 As System.Windows.Forms.Button
End Class
