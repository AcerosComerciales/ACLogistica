<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class COrdenesCompras
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(COrdenesCompras))
        Me.acpnlTitulo = New ACControles.ACPanelCaption()
        Me.c1grdBusqueda = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.bnavBusqueda = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripButton13 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton14 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton15 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton16 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox3 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton17 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton18 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbtnOCompra = New System.Windows.Forms.RadioButton()
        Me.rbtnDCompra = New System.Windows.Forms.RadioButton()
        Me.btnMTConsultar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtBusqueda = New ACControles.ACTextBoxAyuda()
        Me.rbtnRazonSocial = New System.Windows.Forms.RadioButton()
        Me.rbtnCodigo = New System.Windows.Forms.RadioButton()
        Me.chkMTTodos = New System.Windows.Forms.CheckBox()
        Me.AcFecha = New ACControles.ACFecha(Me.components)
        Me.acTool = New ACControles.ACToolBarMantHorizontalNew(Me.components)
        Me.actsbtnSeleccionar = New ACControles.ACToolStripButton(Me.components)
        CType(Me.c1grdBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bnavBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bnavBusqueda.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.acTool.SuspendLayout()
        Me.SuspendLayout()
        '
        'acpnlTitulo
        '
        Me.acpnlTitulo.ACCaption = "Consulta de Ordenes / Documentos"
        Me.acpnlTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.acpnlTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.0!, System.Drawing.FontStyle.Bold)
        Me.acpnlTitulo.Location = New System.Drawing.Point(0, 0)
        Me.acpnlTitulo.Name = "acpnlTitulo"
        Me.acpnlTitulo.Size = New System.Drawing.Size(764, 45)
        Me.acpnlTitulo.TabIndex = 14
        '
        'c1grdBusqueda
        '
        Me.c1grdBusqueda.ColumnInfo = "2,1,0,0,0,100,Columns:0{Width:25;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.c1grdBusqueda.Dock = System.Windows.Forms.DockStyle.Fill
        Me.c1grdBusqueda.Location = New System.Drawing.Point(0, 165)
        Me.c1grdBusqueda.Name = "c1grdBusqueda"
        Me.c1grdBusqueda.Rows.Count = 2
        Me.c1grdBusqueda.Rows.DefaultSize = 20
        Me.c1grdBusqueda.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.c1grdBusqueda.Size = New System.Drawing.Size(764, 255)
        Me.c1grdBusqueda.StyleInfo = resources.GetString("c1grdBusqueda.StyleInfo")
        Me.c1grdBusqueda.TabIndex = 15
        '
        'bnavBusqueda
        '
        Me.bnavBusqueda.AddNewItem = Me.ToolStripButton13
        Me.bnavBusqueda.CountItem = Me.ToolStripLabel3
        Me.bnavBusqueda.DeleteItem = Me.ToolStripButton14
        Me.bnavBusqueda.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton15, Me.ToolStripButton16, Me.ToolStripSeparator7, Me.ToolStripTextBox3, Me.ToolStripLabel3, Me.ToolStripSeparator8, Me.ToolStripButton17, Me.ToolStripButton18, Me.ToolStripSeparator9, Me.ToolStripButton13, Me.ToolStripButton14})
        Me.bnavBusqueda.Location = New System.Drawing.Point(0, 140)
        Me.bnavBusqueda.MoveFirstItem = Me.ToolStripButton15
        Me.bnavBusqueda.MoveLastItem = Me.ToolStripButton18
        Me.bnavBusqueda.MoveNextItem = Me.ToolStripButton17
        Me.bnavBusqueda.MovePreviousItem = Me.ToolStripButton16
        Me.bnavBusqueda.Name = "bnavBusqueda"
        Me.bnavBusqueda.PositionItem = Me.ToolStripTextBox3
        Me.bnavBusqueda.Size = New System.Drawing.Size(764, 25)
        Me.bnavBusqueda.TabIndex = 17
        Me.bnavBusqueda.Text = "BindingNavigator2"
        '
        'ToolStripButton13
        '
        Me.ToolStripButton13.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton13.Image = CType(resources.GetObject("ToolStripButton13.Image"), System.Drawing.Image)
        Me.ToolStripButton13.Name = "ToolStripButton13"
        Me.ToolStripButton13.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton13.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton13.Text = "Add new"
        Me.ToolStripButton13.Visible = False
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(37, 22)
        Me.ToolStripLabel3.Text = "de {0}"
        Me.ToolStripLabel3.ToolTipText = "Total number of items"
        '
        'ToolStripButton14
        '
        Me.ToolStripButton14.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton14.Image = CType(resources.GetObject("ToolStripButton14.Image"), System.Drawing.Image)
        Me.ToolStripButton14.Name = "ToolStripButton14"
        Me.ToolStripButton14.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton14.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton14.Text = "Delete"
        Me.ToolStripButton14.Visible = False
        '
        'ToolStripButton15
        '
        Me.ToolStripButton15.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton15.Image = CType(resources.GetObject("ToolStripButton15.Image"), System.Drawing.Image)
        Me.ToolStripButton15.Name = "ToolStripButton15"
        Me.ToolStripButton15.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton15.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton15.Text = "Move first"
        '
        'ToolStripButton16
        '
        Me.ToolStripButton16.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton16.Image = CType(resources.GetObject("ToolStripButton16.Image"), System.Drawing.Image)
        Me.ToolStripButton16.Name = "ToolStripButton16"
        Me.ToolStripButton16.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton16.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton16.Text = "Move previous"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripTextBox3
        '
        Me.ToolStripTextBox3.AccessibleName = "Position"
        Me.ToolStripTextBox3.AutoSize = False
        Me.ToolStripTextBox3.Name = "ToolStripTextBox3"
        Me.ToolStripTextBox3.Size = New System.Drawing.Size(50, 21)
        Me.ToolStripTextBox3.Text = "0"
        Me.ToolStripTextBox3.ToolTipText = "Current position"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton17
        '
        Me.ToolStripButton17.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton17.Image = CType(resources.GetObject("ToolStripButton17.Image"), System.Drawing.Image)
        Me.ToolStripButton17.Name = "ToolStripButton17"
        Me.ToolStripButton17.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton17.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton17.Text = "Move next"
        '
        'ToolStripButton18
        '
        Me.ToolStripButton18.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton18.Image = CType(resources.GetObject("ToolStripButton18.Image"), System.Drawing.Image)
        Me.ToolStripButton18.Name = "ToolStripButton18"
        Me.ToolStripButton18.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton18.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton18.Text = "Move last"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 25)
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbtnOCompra)
        Me.GroupBox1.Controls.Add(Me.rbtnDCompra)
        Me.GroupBox1.Controls.Add(Me.btnMTConsultar)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.chkMTTodos)
        Me.GroupBox1.Controls.Add(Me.AcFecha)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 45)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(764, 95)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Opciones de Busqueda"
        '
        'rbtnOCompra
        '
        Me.rbtnOCompra.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbtnOCompra.AutoSize = True
        Me.rbtnOCompra.Checked = True
        Me.rbtnOCompra.Location = New System.Drawing.Point(12, 16)
        Me.rbtnOCompra.Name = "rbtnOCompra"
        Me.rbtnOCompra.Size = New System.Drawing.Size(108, 17)
        Me.rbtnOCompra.TabIndex = 33
        Me.rbtnOCompra.TabStop = True
        Me.rbtnOCompra.Text = "Orden de Compra"
        Me.rbtnOCompra.UseVisualStyleBackColor = True
        '
        'rbtnDCompra
        '
        Me.rbtnDCompra.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbtnDCompra.AutoSize = True
        Me.rbtnDCompra.Location = New System.Drawing.Point(138, 16)
        Me.rbtnDCompra.Name = "rbtnDCompra"
        Me.rbtnDCompra.Size = New System.Drawing.Size(134, 17)
        Me.rbtnDCompra.TabIndex = 34
        Me.rbtnDCompra.Text = "Documento de Compra"
        Me.rbtnDCompra.UseVisualStyleBackColor = True
        '
        'btnMTConsultar
        '
        Me.btnMTConsultar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMTConsultar.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
        Me.btnMTConsultar.Image = Global.ACPLogistica.My.Resources.Resources.Search_files_32x32
        Me.btnMTConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMTConsultar.Location = New System.Drawing.Point(659, 44)
        Me.btnMTConsultar.Name = "btnMTConsultar"
        Me.btnMTConsultar.Size = New System.Drawing.Size(99, 42)
        Me.btnMTConsultar.TabIndex = 32
        Me.btnMTConsultar.Text = "Consultar"
        Me.btnMTConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnMTConsultar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.txtBusqueda)
        Me.GroupBox2.Controls.Add(Me.rbtnRazonSocial)
        Me.GroupBox2.Controls.Add(Me.rbtnCodigo)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 34)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(415, 56)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos del Registro"
        '
        'txtBusqueda
        '
        Me.txtBusqueda.ACActivarAyudaAuto = False
        Me.txtBusqueda.ACLongitudAceptada = 0
        Me.txtBusqueda.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBusqueda.Location = New System.Drawing.Point(6, 32)
        Me.txtBusqueda.MaxLength = 32767
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(396, 20)
        Me.txtBusqueda.TabIndex = 0
        '
        'rbtnRazonSocial
        '
        Me.rbtnRazonSocial.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbtnRazonSocial.AutoSize = True
        Me.rbtnRazonSocial.Checked = True
        Me.rbtnRazonSocial.Location = New System.Drawing.Point(239, 12)
        Me.rbtnRazonSocial.Name = "rbtnRazonSocial"
        Me.rbtnRazonSocial.Size = New System.Drawing.Size(88, 17)
        Me.rbtnRazonSocial.TabIndex = 1
        Me.rbtnRazonSocial.TabStop = True
        Me.rbtnRazonSocial.Text = "Razon Social"
        Me.rbtnRazonSocial.UseVisualStyleBackColor = True
        '
        'rbtnCodigo
        '
        Me.rbtnCodigo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rbtnCodigo.AutoSize = True
        Me.rbtnCodigo.Location = New System.Drawing.Point(344, 12)
        Me.rbtnCodigo.Name = "rbtnCodigo"
        Me.rbtnCodigo.Size = New System.Drawing.Size(58, 17)
        Me.rbtnCodigo.TabIndex = 2
        Me.rbtnCodigo.Text = "Codigo"
        Me.rbtnCodigo.UseVisualStyleBackColor = True
        '
        'chkMTTodos
        '
        Me.chkMTTodos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkMTTodos.AutoSize = True
        Me.chkMTTodos.Location = New System.Drawing.Point(559, 59)
        Me.chkMTTodos.Name = "chkMTTodos"
        Me.chkMTTodos.Size = New System.Drawing.Size(94, 17)
        Me.chkMTTodos.TabIndex = 4
        Me.chkMTTodos.Text = "Mostrar Todos"
        Me.chkMTTodos.UseVisualStyleBackColor = True
        '
        'AcFecha
        '
        Me.AcFecha.ACFecha_A = New Date(2025, 9, 2, 11, 57, 53, 215)
        Me.AcFecha.ACFecha_De = New Date(2025, 9, 2, 11, 57, 53, 213)
        Me.AcFecha.ACFechaObligatoria = True
        Me.AcFecha.ACFormatoControl = ACControles.ACFecha.ACTipoFormatoControl.Horizontal
        Me.AcFecha.ACHoyChecked = False
        Me.AcFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AcFecha.Location = New System.Drawing.Point(427, 0)
        Me.AcFecha.MaximumSize = New System.Drawing.Size(337, 43)
        Me.AcFecha.MinimumSize = New System.Drawing.Size(337, 43)
        Me.AcFecha.Name = "AcFecha"
        Me.AcFecha.Size = New System.Drawing.Size(337, 43)
        Me.AcFecha.TabIndex = 3
        Me.AcFecha.TabStop = False
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
        Me.acTool.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.actsbtnSeleccionar})
        Me.acTool.Location = New System.Drawing.Point(0, 420)
        Me.acTool.Name = "acTool"
        Me.acTool.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.acTool.Size = New System.Drawing.Size(764, 56)
        Me.acTool.TabIndex = 18
        Me.acTool.Text = "AcToolBarMantHorizontalNew1"
        '
        'actsbtnSeleccionar
        '
        Me.actsbtnSeleccionar.AutoSize = False
        Me.actsbtnSeleccionar.Image = Global.ACPLogistica.My.Resources.Resources.Aceptar_32x32
        Me.actsbtnSeleccionar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.actsbtnSeleccionar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.actsbtnSeleccionar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.actsbtnSeleccionar.Name = "tsbBoton"
        Me.actsbtnSeleccionar.Size = New System.Drawing.Size(84, 53)
        Me.actsbtnSeleccionar.Text = "Seleccionar"
        Me.actsbtnSeleccionar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.actsbtnSeleccionar.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        Me.actsbtnSeleccionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.actsbtnSeleccionar.Visible = False
        '
        'COrdenesCompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(764, 476)
        Me.Controls.Add(Me.c1grdBusqueda)
        Me.Controls.Add(Me.acTool)
        Me.Controls.Add(Me.bnavBusqueda)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.acpnlTitulo)
        Me.Name = "COrdenesCompras"
        Me.Text = "Consulta de Ordenes / Documentos"
        CType(Me.c1grdBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bnavBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bnavBusqueda.ResumeLayout(False)
        Me.bnavBusqueda.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.acTool.ResumeLayout(False)
        Me.acTool.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents acpnlTitulo As ACControles.ACPanelCaption
   Friend WithEvents c1grdBusqueda As C1.Win.C1FlexGrid.C1FlexGrid
   Friend WithEvents bnavBusqueda As System.Windows.Forms.BindingNavigator
   Friend WithEvents ToolStripButton13 As System.Windows.Forms.ToolStripButton
   Friend WithEvents ToolStripLabel3 As System.Windows.Forms.ToolStripLabel
   Friend WithEvents ToolStripButton14 As System.Windows.Forms.ToolStripButton
   Friend WithEvents ToolStripButton15 As System.Windows.Forms.ToolStripButton
   Friend WithEvents ToolStripButton16 As System.Windows.Forms.ToolStripButton
   Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
   Friend WithEvents ToolStripTextBox3 As System.Windows.Forms.ToolStripTextBox
   Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
   Friend WithEvents ToolStripButton17 As System.Windows.Forms.ToolStripButton
   Friend WithEvents ToolStripButton18 As System.Windows.Forms.ToolStripButton
   Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
   Private WithEvents GroupBox1 As System.Windows.Forms.GroupBox
   Friend WithEvents rbtnOCompra As System.Windows.Forms.RadioButton
   Friend WithEvents rbtnDCompra As System.Windows.Forms.RadioButton
   Friend WithEvents btnMTConsultar As System.Windows.Forms.Button
   Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
   Friend WithEvents txtBusqueda As ACControles.ACTextBoxAyuda
   Friend WithEvents rbtnRazonSocial As System.Windows.Forms.RadioButton
   Friend WithEvents rbtnCodigo As System.Windows.Forms.RadioButton
   Friend WithEvents chkMTTodos As System.Windows.Forms.CheckBox
   Friend WithEvents AcFecha As ACControles.ACFecha
   Friend WithEvents acTool As ACControles.ACToolBarMantHorizontalNew
   Friend WithEvents actsbtnSeleccionar As ACControles.ACToolStripButton
End Class
