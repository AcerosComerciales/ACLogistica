<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CEstadoPagosProveedor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CEstadoPagosProveedor))
        Me.AcPanelCaption1 = New ACControles.ACPanelCaption()
        Me.grpCabCuerpo = New System.Windows.Forms.GroupBox()
        Me.rbtnPendientes = New System.Windows.Forms.RadioButton()
        Me.rbtnTodos = New System.Windows.Forms.RadioButton()
        Me.btnExcel = New System.Windows.Forms.Button()
        Me.btnProcesar = New System.Windows.Forms.Button()
        Me.btnClean = New System.Windows.Forms.Button()
        Me.actxaCliRazonSocial = New ACControles.ACTextBoxAyuda()
        Me.lblNroDocumento = New System.Windows.Forms.Label()
        Me.actxaCliRuc = New ACControles.ACTextBoxAyuda()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.c1grdReporte = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.bnavReporte = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.c1grdPagos = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.bnavPagos = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripButton19 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton20 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton21 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton22 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox4 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton23 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton24 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator12 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnAnularPago = New System.Windows.Forms.ToolStripButton()
        Me.AcPanelCaption2 = New ACControles.ACPanelCaption()
        Me.grpCabCuerpo.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.c1grdReporte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bnavReporte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bnavReporte.SuspendLayout()
        CType(Me.c1grdPagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bnavPagos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bnavPagos.SuspendLayout()
        Me.SuspendLayout()
        '
        'AcPanelCaption1
        '
        Me.AcPanelCaption1.ACCaption = "Estado de Pagos por Proveedor"
        Me.AcPanelCaption1.Dock = System.Windows.Forms.DockStyle.Top
        Me.AcPanelCaption1.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.AcPanelCaption1.Location = New System.Drawing.Point(0, 0)
        Me.AcPanelCaption1.Name = "AcPanelCaption1"
        Me.AcPanelCaption1.Size = New System.Drawing.Size(918, 30)
        Me.AcPanelCaption1.TabIndex = 52
        '
        'grpCabCuerpo
        '
        Me.grpCabCuerpo.Controls.Add(Me.rbtnPendientes)
        Me.grpCabCuerpo.Controls.Add(Me.rbtnTodos)
        Me.grpCabCuerpo.Controls.Add(Me.btnExcel)
        Me.grpCabCuerpo.Controls.Add(Me.btnProcesar)
        Me.grpCabCuerpo.Controls.Add(Me.btnClean)
        Me.grpCabCuerpo.Controls.Add(Me.actxaCliRazonSocial)
        Me.grpCabCuerpo.Controls.Add(Me.lblNroDocumento)
        Me.grpCabCuerpo.Controls.Add(Me.actxaCliRuc)
        Me.grpCabCuerpo.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpCabCuerpo.Location = New System.Drawing.Point(0, 30)
        Me.grpCabCuerpo.Name = "grpCabCuerpo"
        Me.grpCabCuerpo.Size = New System.Drawing.Size(918, 66)
        Me.grpCabCuerpo.TabIndex = 53
        Me.grpCabCuerpo.TabStop = False
        Me.grpCabCuerpo.Tag = "EVO"
        '
        'rbtnPendientes
        '
        Me.rbtnPendientes.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbtnPendientes.AutoSize = True
        Me.rbtnPendientes.Checked = True
        Me.rbtnPendientes.Location = New System.Drawing.Point(630, 12)
        Me.rbtnPendientes.Name = "rbtnPendientes"
        Me.rbtnPendientes.Size = New System.Drawing.Size(102, 17)
        Me.rbtnPendientes.TabIndex = 7
        Me.rbtnPendientes.TabStop = True
        Me.rbtnPendientes.Text = "Solo Pendientes"
        Me.rbtnPendientes.UseVisualStyleBackColor = True
        '
        'rbtnTodos
        '
        Me.rbtnTodos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbtnTodos.AutoSize = True
        Me.rbtnTodos.Location = New System.Drawing.Point(531, 12)
        Me.rbtnTodos.Name = "rbtnTodos"
        Me.rbtnTodos.Size = New System.Drawing.Size(93, 17)
        Me.rbtnTodos.TabIndex = 6
        Me.rbtnTodos.Text = "Mostrar Todos"
        Me.rbtnTodos.UseVisualStyleBackColor = True
        '
        'btnExcel
        '
        Me.btnExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExcel.Location = New System.Drawing.Point(864, 12)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(42, 41)
        Me.btnExcel.TabIndex = 5
        Me.btnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExcel.UseVisualStyleBackColor = True
        '
        'btnProcesar
        '
        Me.btnProcesar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProcesar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProcesar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProcesar.Location = New System.Drawing.Point(738, 12)
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(120, 41)
        Me.btnProcesar.TabIndex = 4
        Me.btnProcesar.Text = "Procesar"
        Me.btnProcesar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnProcesar.UseVisualStyleBackColor = True
        '
        'btnClean
        '
        Me.btnClean.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClean.Location = New System.Drawing.Point(680, 31)
        Me.btnClean.Name = "btnClean"
        Me.btnClean.Size = New System.Drawing.Size(36, 28)
        Me.btnClean.TabIndex = 3
        Me.btnClean.UseVisualStyleBackColor = True
        '
        'actxaCliRazonSocial
        '
        Me.actxaCliRazonSocial.ACActivarAyudaAuto = False
        Me.actxaCliRazonSocial.ACLongitudAceptada = 0
        Me.actxaCliRazonSocial.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.actxaCliRazonSocial.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
        Me.actxaCliRazonSocial.Location = New System.Drawing.Point(184, 33)
        Me.actxaCliRazonSocial.MaxLength = 80
        Me.actxaCliRazonSocial.Name = "actxaCliRazonSocial"
        Me.actxaCliRazonSocial.Size = New System.Drawing.Size(490, 24)
        Me.actxaCliRazonSocial.TabIndex = 2
        Me.actxaCliRazonSocial.Tag = "EVO"
        '
        'lblNroDocumento
        '
        Me.lblNroDocumento.AutoSize = True
        Me.lblNroDocumento.Location = New System.Drawing.Point(3, 39)
        Me.lblNroDocumento.Name = "lblNroDocumento"
        Me.lblNroDocumento.Size = New System.Drawing.Size(62, 13)
        Me.lblNroDocumento.TabIndex = 0
        Me.lblNroDocumento.Text = "Proveedor :"
        '
        'actxaCliRuc
        '
        Me.actxaCliRuc.ACActivarAyudaAuto = False
        Me.actxaCliRuc.ACLongitudAceptada = 0
        Me.actxaCliRuc.Location = New System.Drawing.Point(67, 35)
        Me.actxaCliRuc.MaxLength = 14
        Me.actxaCliRuc.Name = "actxaCliRuc"
        Me.actxaCliRuc.Size = New System.Drawing.Size(111, 20)
        Me.actxaCliRuc.TabIndex = 1
        Me.actxaCliRuc.Tag = "EVO"
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 96)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.c1grdReporte)
        Me.SplitContainer2.Panel1.Controls.Add(Me.bnavReporte)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.AcPanelCaption2)
        Me.SplitContainer2.Panel2.Controls.Add(Me.bnavPagos)
        Me.SplitContainer2.Panel2.Controls.Add(Me.c1grdPagos)
        Me.SplitContainer2.Size = New System.Drawing.Size(918, 365)
        Me.SplitContainer2.SplitterDistance = 180
        Me.SplitContainer2.TabIndex = 54
        '
        'c1grdReporte
        '
        Me.c1grdReporte.ColumnInfo = "2,1,0,0,0,100,Columns:0{Width:25;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.c1grdReporte.Dock = System.Windows.Forms.DockStyle.Fill
        Me.c1grdReporte.Location = New System.Drawing.Point(0, 0)
        Me.c1grdReporte.Name = "c1grdReporte"
        Me.c1grdReporte.Rows.Count = 2
        Me.c1grdReporte.Rows.DefaultSize = 20
        Me.c1grdReporte.Size = New System.Drawing.Size(918, 155)
        Me.c1grdReporte.StyleInfo = resources.GetString("c1grdReporte.StyleInfo")
        Me.c1grdReporte.TabIndex = 64
        '
        'bnavReporte
        '
        Me.bnavReporte.AddNewItem = Me.ToolStripButton1
        Me.bnavReporte.CountItem = Me.ToolStripLabel1
        Me.bnavReporte.DeleteItem = Me.ToolStripButton2
        Me.bnavReporte.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.bnavReporte.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripSeparator1, Me.ToolStripTextBox1, Me.ToolStripLabel1, Me.ToolStripSeparator2, Me.ToolStripButton5, Me.ToolStripButton6, Me.ToolStripSeparator3, Me.ToolStripButton1, Me.ToolStripButton2})
        Me.bnavReporte.Location = New System.Drawing.Point(0, 155)
        Me.bnavReporte.MoveFirstItem = Me.ToolStripButton3
        Me.bnavReporte.MoveLastItem = Me.ToolStripButton6
        Me.bnavReporte.MoveNextItem = Me.ToolStripButton5
        Me.bnavReporte.MovePreviousItem = Me.ToolStripButton4
        Me.bnavReporte.Name = "bnavReporte"
        Me.bnavReporte.PositionItem = Me.ToolStripTextBox1
        Me.bnavReporte.Size = New System.Drawing.Size(918, 25)
        Me.bnavReporte.TabIndex = 63
        Me.bnavReporte.Text = "BindingNavigator1"
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
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(50, 23)
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
        'c1grdPagos
        '
        Me.c1grdPagos.ColumnInfo = "2,1,0,0,0,95,Columns:0{Width:25;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.c1grdPagos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.c1grdPagos.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.c1grdPagos.Location = New System.Drawing.Point(0, 0)
        Me.c1grdPagos.Name = "c1grdPagos"
        Me.c1grdPagos.Rows.Count = 2
        Me.c1grdPagos.Rows.DefaultSize = 19
        Me.c1grdPagos.Size = New System.Drawing.Size(918, 181)
        Me.c1grdPagos.StyleInfo = resources.GetString("c1grdPagos.StyleInfo")
        Me.c1grdPagos.TabIndex = 64
        '
        'bnavPagos
        '
        Me.bnavPagos.AddNewItem = Me.ToolStripButton19
        Me.bnavPagos.CountItem = Me.ToolStripLabel4
        Me.bnavPagos.DeleteItem = Me.ToolStripButton20
        Me.bnavPagos.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.bnavPagos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton21, Me.ToolStripButton22, Me.ToolStripSeparator10, Me.ToolStripTextBox4, Me.ToolStripLabel4, Me.ToolStripSeparator11, Me.ToolStripButton23, Me.ToolStripButton24, Me.ToolStripSeparator12, Me.ToolStripButton19, Me.ToolStripButton20, Me.tsbtnAnularPago})
        Me.bnavPagos.Location = New System.Drawing.Point(0, 156)
        Me.bnavPagos.MoveFirstItem = Me.ToolStripButton21
        Me.bnavPagos.MoveLastItem = Me.ToolStripButton24
        Me.bnavPagos.MoveNextItem = Me.ToolStripButton23
        Me.bnavPagos.MovePreviousItem = Me.ToolStripButton22
        Me.bnavPagos.Name = "bnavPagos"
        Me.bnavPagos.PositionItem = Me.ToolStripTextBox4
        Me.bnavPagos.Size = New System.Drawing.Size(918, 25)
        Me.bnavPagos.TabIndex = 63
        Me.bnavPagos.Text = "BindingNavigator1"
        '
        'ToolStripButton19
        '
        Me.ToolStripButton19.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton19.Image = CType(resources.GetObject("ToolStripButton19.Image"), System.Drawing.Image)
        Me.ToolStripButton19.Name = "ToolStripButton19"
        Me.ToolStripButton19.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton19.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton19.Text = "Add new"
        Me.ToolStripButton19.Visible = False
        '
        'ToolStripLabel4
        '
        Me.ToolStripLabel4.Name = "ToolStripLabel4"
        Me.ToolStripLabel4.Size = New System.Drawing.Size(35, 22)
        Me.ToolStripLabel4.Text = "of {0}"
        Me.ToolStripLabel4.ToolTipText = "Total number of items"
        '
        'ToolStripButton20
        '
        Me.ToolStripButton20.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton20.Image = CType(resources.GetObject("ToolStripButton20.Image"), System.Drawing.Image)
        Me.ToolStripButton20.Name = "ToolStripButton20"
        Me.ToolStripButton20.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton20.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton20.Text = "Delete"
        Me.ToolStripButton20.Visible = False
        '
        'ToolStripButton21
        '
        Me.ToolStripButton21.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton21.Image = CType(resources.GetObject("ToolStripButton21.Image"), System.Drawing.Image)
        Me.ToolStripButton21.Name = "ToolStripButton21"
        Me.ToolStripButton21.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton21.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton21.Text = "Move first"
        '
        'ToolStripButton22
        '
        Me.ToolStripButton22.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton22.Image = CType(resources.GetObject("ToolStripButton22.Image"), System.Drawing.Image)
        Me.ToolStripButton22.Name = "ToolStripButton22"
        Me.ToolStripButton22.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton22.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton22.Text = "Move previous"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripTextBox4
        '
        Me.ToolStripTextBox4.AccessibleName = "Position"
        Me.ToolStripTextBox4.AutoSize = False
        Me.ToolStripTextBox4.Name = "ToolStripTextBox4"
        Me.ToolStripTextBox4.Size = New System.Drawing.Size(50, 23)
        Me.ToolStripTextBox4.Text = "0"
        Me.ToolStripTextBox4.ToolTipText = "Current position"
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        Me.ToolStripSeparator11.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton23
        '
        Me.ToolStripButton23.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton23.Image = CType(resources.GetObject("ToolStripButton23.Image"), System.Drawing.Image)
        Me.ToolStripButton23.Name = "ToolStripButton23"
        Me.ToolStripButton23.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton23.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton23.Text = "Move next"
        '
        'ToolStripButton24
        '
        Me.ToolStripButton24.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton24.Image = CType(resources.GetObject("ToolStripButton24.Image"), System.Drawing.Image)
        Me.ToolStripButton24.Name = "ToolStripButton24"
        Me.ToolStripButton24.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton24.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton24.Text = "Move last"
        '
        'ToolStripSeparator12
        '
        Me.ToolStripSeparator12.Name = "ToolStripSeparator12"
        Me.ToolStripSeparator12.Size = New System.Drawing.Size(6, 25)
        '
        'tsbtnAnularPago
        '
        Me.tsbtnAnularPago.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnAnularPago.Name = "tsbtnAnularPago"
        Me.tsbtnAnularPago.Size = New System.Drawing.Size(76, 22)
        Me.tsbtnAnularPago.Text = "Anular Pago"
        '
        'AcPanelCaption2
        '
        Me.AcPanelCaption2.ACCaption = "Pagos Realizados"
        Me.AcPanelCaption2.Dock = System.Windows.Forms.DockStyle.Top
        Me.AcPanelCaption2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.AcPanelCaption2.Location = New System.Drawing.Point(0, 0)
        Me.AcPanelCaption2.Name = "AcPanelCaption2"
        Me.AcPanelCaption2.Size = New System.Drawing.Size(918, 15)
        Me.AcPanelCaption2.TabIndex = 66
        '
        'CEstadoPagosProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(918, 461)
        Me.Controls.Add(Me.SplitContainer2)
        Me.Controls.Add(Me.grpCabCuerpo)
        Me.Controls.Add(Me.AcPanelCaption1)
        Me.Name = "CEstadoPagosProveedor"
        Me.Text = "Estado de Pagos por Proveedor"
        Me.grpCabCuerpo.ResumeLayout(False)
        Me.grpCabCuerpo.PerformLayout()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.Panel2.PerformLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.c1grdReporte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bnavReporte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bnavReporte.ResumeLayout(False)
        Me.bnavReporte.PerformLayout()
        CType(Me.c1grdPagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bnavPagos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bnavPagos.ResumeLayout(False)
        Me.bnavPagos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AcPanelCaption1 As ACControles.ACPanelCaption
    Friend WithEvents grpCabCuerpo As System.Windows.Forms.GroupBox
    Friend WithEvents rbtnPendientes As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnTodos As System.Windows.Forms.RadioButton
    Friend WithEvents btnExcel As System.Windows.Forms.Button
    Friend WithEvents btnProcesar As System.Windows.Forms.Button
    Friend WithEvents btnClean As System.Windows.Forms.Button
    Friend WithEvents actxaCliRazonSocial As ACControles.ACTextBoxAyuda
    Friend WithEvents lblNroDocumento As System.Windows.Forms.Label
    Friend WithEvents actxaCliRuc As ACControles.ACTextBoxAyuda
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents c1grdReporte As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents bnavReporte As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents c1grdPagos As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents bnavPagos As System.Windows.Forms.BindingNavigator
    Friend WithEvents ToolStripButton19 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel4 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton20 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton21 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton22 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripTextBox4 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator11 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton23 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton24 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator12 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbtnAnularPago As System.Windows.Forms.ToolStripButton
    Friend WithEvents AcPanelCaption2 As ACControles.ACPanelCaption
End Class
