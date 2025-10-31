<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CComprasXProveedor
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
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CComprasXProveedor))
      Me.acpnlTitulo = New ACControles.ACPanelCaption
      Me.pnlCabecera = New System.Windows.Forms.Panel
      Me.chkAgrupar = New System.Windows.Forms.CheckBox
      Me.AcFecha = New ACControles.ACFecha(Me.components)
      Me.GroupBox1 = New System.Windows.Forms.GroupBox
      Me.actxaProvRazonSocial = New ACControles.ACTextBoxAyuda
      Me.actxaProvCodigo = New ACControles.ACTextBoxAyuda
      Me.Label2 = New System.Windows.Forms.Label
      Me.Label1 = New System.Windows.Forms.Label
      Me.pnlDetalle = New System.Windows.Forms.Panel
      Me.c1grdBusqueda = New C1.Win.C1FlexGrid.C1FlexGrid
      Me.tstool = New System.Windows.Forms.ToolStrip
      Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
      Me.bnavNavievador = New System.Windows.Forms.BindingNavigator(Me.components)
      Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
      Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
      Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
      Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
      Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
      Me.chkAgruparCols = New System.Windows.Forms.CheckBox
      Me.chkFiltroCols = New System.Windows.Forms.CheckBox
      Me.chkReorganizarCols = New System.Windows.Forms.CheckBox
      Me.chkOrdenarCols = New System.Windows.Forms.CheckBox
      Me.Panel1 = New System.Windows.Forms.Panel
      Me.tsbtnImprimir = New System.Windows.Forms.ToolStripButton
      Me.tsbtnprevisualizar = New System.Windows.Forms.ToolStripButton
      Me.tsbtnSalir = New System.Windows.Forms.ToolStripButton
      Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
      Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
      Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
      Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
      Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
      Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
      Me.btnClean = New System.Windows.Forms.Button
      Me.btnCargar = New System.Windows.Forms.Button
      Me.pnlCabecera.SuspendLayout()
      Me.GroupBox1.SuspendLayout()
      Me.pnlDetalle.SuspendLayout()
      CType(Me.c1grdBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.tstool.SuspendLayout()
      CType(Me.bnavNavievador, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.bnavNavievador.SuspendLayout()
      Me.Panel1.SuspendLayout()
      Me.SuspendLayout()
      '
      'acpnlTitulo
      '
      Me.acpnlTitulo.ACCaption = "Reporte de Compras por Proveedor"
      Me.acpnlTitulo.Dock = System.Windows.Forms.DockStyle.Top
      Me.acpnlTitulo.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
      Me.acpnlTitulo.Location = New System.Drawing.Point(0, 0)
      Me.acpnlTitulo.Name = "acpnlTitulo"
      Me.acpnlTitulo.Size = New System.Drawing.Size(792, 30)
      Me.acpnlTitulo.TabIndex = 9
      '
      'pnlCabecera
      '
      Me.pnlCabecera.Controls.Add(Me.chkAgrupar)
      Me.pnlCabecera.Controls.Add(Me.AcFecha)
      Me.pnlCabecera.Controls.Add(Me.GroupBox1)
      Me.pnlCabecera.Controls.Add(Me.btnCargar)
      Me.pnlCabecera.Dock = System.Windows.Forms.DockStyle.Top
      Me.pnlCabecera.Location = New System.Drawing.Point(0, 30)
      Me.pnlCabecera.Name = "pnlCabecera"
      Me.pnlCabecera.Size = New System.Drawing.Size(792, 106)
      Me.pnlCabecera.TabIndex = 10
      '
      'chkAgrupar
      '
      Me.chkAgrupar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.chkAgrupar.AutoSize = True
      Me.chkAgrupar.Location = New System.Drawing.Point(199, 71)
      Me.chkAgrupar.Name = "chkAgrupar"
      Me.chkAgrupar.Size = New System.Drawing.Size(119, 17)
      Me.chkAgrupar.TabIndex = 32
      Me.chkAgrupar.Text = "Agrupar por Articulo"
      Me.chkAgrupar.UseVisualStyleBackColor = True
      '
      'AcFecha
      '
      Me.AcFecha.ACFecha_A = New Date(2011, 1, 6, 18, 16, 33, 656)
      Me.AcFecha.ACFecha_De = New Date(2011, 1, 6, 18, 16, 33, 656)
      Me.AcFecha.ACFechaObligatoria = True
      Me.AcFecha.ACFormatoControl = ACControles.ACFecha.ACTipoFormatoControl.Horizontal
      Me.AcFecha.ACHoyChecked = False
      Me.AcFecha.ACIncrementoFecha_A = ACControles.ACFecha.ACTipoIncremento.Mes
      Me.AcFecha.ACIncrementoFecha_De = ACControles.ACFecha.ACTipoIncremento.Dia
      Me.AcFecha.ACIntervalos = ACControles.ACFecha.ACIntervalo.Ninguno
      Me.AcFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.AcFecha.Location = New System.Drawing.Point(324, 57)
      Me.AcFecha.MaximumSize = New System.Drawing.Size(337, 43)
      Me.AcFecha.MinimumSize = New System.Drawing.Size(337, 43)
      Me.AcFecha.Name = "AcFecha"
      Me.AcFecha.Size = New System.Drawing.Size(337, 43)
      Me.AcFecha.TabIndex = 14
      Me.AcFecha.TabStop = False
      '
      'GroupBox1
      '
      Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.GroupBox1.Controls.Add(Me.btnClean)
      Me.GroupBox1.Controls.Add(Me.actxaProvRazonSocial)
      Me.GroupBox1.Controls.Add(Me.actxaProvCodigo)
      Me.GroupBox1.Controls.Add(Me.Label2)
      Me.GroupBox1.Controls.Add(Me.Label1)
      Me.GroupBox1.Location = New System.Drawing.Point(3, 6)
      Me.GroupBox1.Name = "GroupBox1"
      Me.GroupBox1.Size = New System.Drawing.Size(777, 47)
      Me.GroupBox1.TabIndex = 13
      Me.GroupBox1.TabStop = False
      Me.GroupBox1.Text = "Proveedor"
      '
      'actxaProvRazonSocial
      '
      Me.actxaProvRazonSocial.ACActivarAyudaAuto = False
      Me.actxaProvRazonSocial.ACLongitudAceptada = 0
      Me.actxaProvRazonSocial.ACTipo = ACControles.ACTextBoxAyuda.TipoTextBoxAyuda.AlfaNumerico
      Me.actxaProvRazonSocial.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.actxaProvRazonSocial.Location = New System.Drawing.Point(286, 15)
      Me.actxaProvRazonSocial.MaxLength = 32767
      Me.actxaProvRazonSocial.Name = "actxaProvRazonSocial"
      Me.actxaProvRazonSocial.Size = New System.Drawing.Size(436, 20)
      Me.actxaProvRazonSocial.TabIndex = 13
      Me.actxaProvRazonSocial.Tag = "EVO"
      '
      'actxaProvCodigo
      '
      Me.actxaProvCodigo.ACActivarAyudaAuto = False
      Me.actxaProvCodigo.ACLongitudAceptada = 0
      Me.actxaProvCodigo.ACTipo = ACControles.ACTextBoxAyuda.TipoTextBoxAyuda.AlfaNumerico
      Me.actxaProvCodigo.Location = New System.Drawing.Point(67, 15)
      Me.actxaProvCodigo.MaxLength = 32767
      Me.actxaProvCodigo.Name = "actxaProvCodigo"
      Me.actxaProvCodigo.Size = New System.Drawing.Size(122, 20)
      Me.actxaProvCodigo.TabIndex = 12
      Me.actxaProvCodigo.Tag = "EVO"
      '
      'Label2
      '
      Me.Label2.AutoSize = True
      Me.Label2.Location = New System.Drawing.Point(204, 19)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(76, 13)
      Me.Label2.TabIndex = 11
      Me.Label2.Text = "Razon Social :"
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.Location = New System.Drawing.Point(15, 19)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(46, 13)
      Me.Label1.TabIndex = 9
      Me.Label1.Text = "Codigo :"
      '
      'pnlDetalle
      '
      Me.pnlDetalle.Controls.Add(Me.c1grdBusqueda)
      Me.pnlDetalle.Controls.Add(Me.tstool)
      Me.pnlDetalle.Controls.Add(Me.bnavNavievador)
      Me.pnlDetalle.Dock = System.Windows.Forms.DockStyle.Fill
      Me.pnlDetalle.Location = New System.Drawing.Point(0, 136)
      Me.pnlDetalle.Name = "pnlDetalle"
      Me.pnlDetalle.Size = New System.Drawing.Size(792, 399)
      Me.pnlDetalle.TabIndex = 11
      '
      'c1grdBusqueda
      '
      Me.c1grdBusqueda.ColumnInfo = "2,1,0,0,0,90,Columns:0{Width:25;}" & Global.Microsoft.VisualBasic.ChrW(9)
      Me.c1grdBusqueda.Dock = System.Windows.Forms.DockStyle.Fill
      Me.c1grdBusqueda.Location = New System.Drawing.Point(0, 25)
      Me.c1grdBusqueda.Name = "c1grdBusqueda"
      Me.c1grdBusqueda.Rows.Count = 2
      Me.c1grdBusqueda.Rows.DefaultSize = 18
      Me.c1grdBusqueda.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
      Me.c1grdBusqueda.Size = New System.Drawing.Size(792, 335)
      Me.c1grdBusqueda.StyleInfo = resources.GetString("c1grdBusqueda.StyleInfo")
      Me.c1grdBusqueda.TabIndex = 3
      '
      'tstool
      '
      Me.tstool.Dock = System.Windows.Forms.DockStyle.Bottom
      Me.tstool.ImageScalingSize = New System.Drawing.Size(32, 32)
      Me.tstool.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbtnImprimir, Me.tsbtnprevisualizar, Me.ToolStripSeparator1, Me.tsbtnSalir})
      Me.tstool.Location = New System.Drawing.Point(0, 360)
      Me.tstool.Name = "tstool"
      Me.tstool.Size = New System.Drawing.Size(792, 39)
      Me.tstool.TabIndex = 2
      Me.tstool.Text = "ToolStrip1"
      '
      'ToolStripSeparator1
      '
      Me.ToolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
      Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
      Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
      '
      'bnavNavievador
      '
      Me.bnavNavievador.AddNewItem = Me.BindingNavigatorAddNewItem
      Me.bnavNavievador.CountItem = Me.BindingNavigatorCountItem
      Me.bnavNavievador.DeleteItem = Me.BindingNavigatorDeleteItem
      Me.bnavNavievador.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem})
      Me.bnavNavievador.Location = New System.Drawing.Point(0, 0)
      Me.bnavNavievador.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
      Me.bnavNavievador.MoveLastItem = Me.BindingNavigatorMoveLastItem
      Me.bnavNavievador.MoveNextItem = Me.BindingNavigatorMoveNextItem
      Me.bnavNavievador.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
      Me.bnavNavievador.Name = "bnavNavievador"
      Me.bnavNavievador.PositionItem = Me.BindingNavigatorPositionItem
      Me.bnavNavievador.Size = New System.Drawing.Size(792, 25)
      Me.bnavNavievador.TabIndex = 1
      Me.bnavNavievador.Text = "BindingNavigator1"
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
      'chkAgruparCols
      '
      Me.chkAgruparCols.AutoSize = True
      Me.chkAgruparCols.Checked = True
      Me.chkAgruparCols.CheckState = System.Windows.Forms.CheckState.Checked
      Me.chkAgruparCols.Location = New System.Drawing.Point(14, 6)
      Me.chkAgruparCols.Name = "chkAgruparCols"
      Me.chkAgruparCols.Size = New System.Drawing.Size(129, 17)
      Me.chkAgruparCols.TabIndex = 9
      Me.chkAgruparCols.Text = "Agrupar por columnas"
      Me.chkAgruparCols.UseVisualStyleBackColor = True
      '
      'chkFiltroCols
      '
      Me.chkFiltroCols.AutoSize = True
      Me.chkFiltroCols.Location = New System.Drawing.Point(539, 6)
      Me.chkFiltroCols.Name = "chkFiltroCols"
      Me.chkFiltroCols.Size = New System.Drawing.Size(114, 17)
      Me.chkFiltroCols.TabIndex = 12
      Me.chkFiltroCols.Text = "Filtro por columnas"
      Me.chkFiltroCols.UseVisualStyleBackColor = True
      '
      'chkReorganizarCols
      '
      Me.chkReorganizarCols.AutoSize = True
      Me.chkReorganizarCols.Location = New System.Drawing.Point(374, 6)
      Me.chkReorganizarCols.Name = "chkReorganizarCols"
      Me.chkReorganizarCols.Size = New System.Drawing.Size(132, 17)
      Me.chkReorganizarCols.TabIndex = 10
      Me.chkReorganizarCols.Text = "Reorganizar Columnas"
      Me.chkReorganizarCols.UseVisualStyleBackColor = True
      '
      'chkOrdenarCols
      '
      Me.chkOrdenarCols.AutoSize = True
      Me.chkOrdenarCols.Location = New System.Drawing.Point(176, 6)
      Me.chkOrdenarCols.Name = "chkOrdenarCols"
      Me.chkOrdenarCols.Size = New System.Drawing.Size(165, 17)
      Me.chkOrdenarCols.TabIndex = 11
      Me.chkOrdenarCols.Text = "Permitir ordenar por columnas"
      Me.chkOrdenarCols.UseVisualStyleBackColor = True
      '
      'Panel1
      '
      Me.Panel1.Controls.Add(Me.chkAgruparCols)
      Me.Panel1.Controls.Add(Me.chkFiltroCols)
      Me.Panel1.Controls.Add(Me.chkReorganizarCols)
      Me.Panel1.Controls.Add(Me.chkOrdenarCols)
      Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
      Me.Panel1.Location = New System.Drawing.Point(0, 535)
      Me.Panel1.Name = "Panel1"
      Me.Panel1.Size = New System.Drawing.Size(792, 31)
      Me.Panel1.TabIndex = 12
      Me.Panel1.Visible = False
      '
      'tsbtnImprimir
      '
      Me.tsbtnImprimir.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.tsbtnImprimir.Image = Global.ACPLogistica.My.Resources.Resources.ImprimirRed_32x32
      Me.tsbtnImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
      Me.tsbtnImprimir.Name = "tsbtnImprimir"
      Me.tsbtnImprimir.Size = New System.Drawing.Size(108, 36)
      Me.tsbtnImprimir.Text = "Imprimir"
      Me.tsbtnImprimir.Visible = False
      '
      'tsbtnprevisualizar
      '
      Me.tsbtnprevisualizar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
      Me.tsbtnprevisualizar.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.tsbtnprevisualizar.Image = Global.ACPLogistica.My.Resources.Resources.Reporte_32x32
      Me.tsbtnprevisualizar.ImageTransparentColor = System.Drawing.Color.Magenta
      Me.tsbtnprevisualizar.Name = "tsbtnprevisualizar"
      Me.tsbtnprevisualizar.Size = New System.Drawing.Size(141, 36)
      Me.tsbtnprevisualizar.Text = "Pre-Visualizar"
      '
      'tsbtnSalir
      '
      Me.tsbtnSalir.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.tsbtnSalir.Image = Global.ACPLogistica.My.Resources.Resources.Exit_32x32
      Me.tsbtnSalir.ImageTransparentColor = System.Drawing.Color.Magenta
      Me.tsbtnSalir.Name = "tsbtnSalir"
      Me.tsbtnSalir.Size = New System.Drawing.Size(76, 36)
      Me.tsbtnSalir.Text = "Salir"
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
      'btnClean
      '
      Me.btnClean.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.btnClean.Image = Global.ACPLogistica.My.Resources.Resources.Delete_16x16
      Me.btnClean.Location = New System.Drawing.Point(728, 12)
      Me.btnClean.Name = "btnClean"
      Me.btnClean.Size = New System.Drawing.Size(36, 27)
      Me.btnClean.TabIndex = 16
      Me.btnClean.UseVisualStyleBackColor = True
      '
      'btnCargar
      '
      Me.btnCargar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.btnCargar.Image = Global.ACPLogistica.My.Resources.Resources.Procesos_32x32
      Me.btnCargar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
      Me.btnCargar.Location = New System.Drawing.Point(669, 59)
      Me.btnCargar.Name = "btnCargar"
      Me.btnCargar.Size = New System.Drawing.Size(113, 39)
      Me.btnCargar.TabIndex = 8
      Me.btnCargar.Text = "Cargar Datos  "
      Me.btnCargar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.btnCargar.UseVisualStyleBackColor = True
      '
      'CComprasXProveedor
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.BackColor = System.Drawing.Color.LightSteelBlue
      Me.ClientSize = New System.Drawing.Size(792, 566)
      Me.Controls.Add(Me.pnlDetalle)
      Me.Controls.Add(Me.pnlCabecera)
      Me.Controls.Add(Me.acpnlTitulo)
      Me.Controls.Add(Me.Panel1)
      Me.Name = "CComprasXProveedor"
      Me.Text = "Reporte de Compras por Proveedor"
      Me.pnlCabecera.ResumeLayout(False)
      Me.pnlCabecera.PerformLayout()
      Me.GroupBox1.ResumeLayout(False)
      Me.GroupBox1.PerformLayout()
      Me.pnlDetalle.ResumeLayout(False)
      Me.pnlDetalle.PerformLayout()
      CType(Me.c1grdBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
      Me.tstool.ResumeLayout(False)
      Me.tstool.PerformLayout()
      CType(Me.bnavNavievador, System.ComponentModel.ISupportInitialize).EndInit()
      Me.bnavNavievador.ResumeLayout(False)
      Me.bnavNavievador.PerformLayout()
      Me.Panel1.ResumeLayout(False)
      Me.Panel1.PerformLayout()
      Me.ResumeLayout(False)

   End Sub
   Friend WithEvents acpnlTitulo As ACControles.ACPanelCaption
   Friend WithEvents pnlCabecera As System.Windows.Forms.Panel
   Friend WithEvents pnlDetalle As System.Windows.Forms.Panel
   Friend WithEvents btnCargar As System.Windows.Forms.Button
   Friend WithEvents bnavNavievador As System.Windows.Forms.BindingNavigator
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
   Friend WithEvents chkAgruparCols As System.Windows.Forms.CheckBox
   Friend WithEvents chkFiltroCols As System.Windows.Forms.CheckBox
   Friend WithEvents chkReorganizarCols As System.Windows.Forms.CheckBox
   Friend WithEvents chkOrdenarCols As System.Windows.Forms.CheckBox
   Friend WithEvents Panel1 As System.Windows.Forms.Panel
   Friend WithEvents tstool As System.Windows.Forms.ToolStrip
   Friend WithEvents tsbtnImprimir As System.Windows.Forms.ToolStripButton
   Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
   Friend WithEvents tsbtnprevisualizar As System.Windows.Forms.ToolStripButton
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents AcFecha As ACControles.ACFecha
   Friend WithEvents c1grdBusqueda As C1.Win.C1FlexGrid.C1FlexGrid
   Friend WithEvents actxaProvRazonSocial As ACControles.ACTextBoxAyuda
   Friend WithEvents actxaProvCodigo As ACControles.ACTextBoxAyuda
   Friend WithEvents btnClean As System.Windows.Forms.Button
   Friend WithEvents tsbtnSalir As System.Windows.Forms.ToolStripButton
   Friend WithEvents chkAgrupar As System.Windows.Forms.CheckBox
End Class
