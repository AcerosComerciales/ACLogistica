<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CStocksIniciales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CStocksIniciales))
        Me.pnlDetalle = New System.Windows.Forms.Panel()
        Me.c1grdBusqueda = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.tstool = New System.Windows.Forms.ToolStrip()
        Me.tsbtnImprimir = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnprevisualizar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnSalir = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnExcel = New System.Windows.Forms.ToolStripButton()
        Me.bnavNavievador = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.btnGrabarStockInicial = New System.Windows.Forms.Button()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.lblPeriodo = New System.Windows.Forms.Label()
        Me.cmbPeriodo = New System.Windows.Forms.ComboBox()
        Me.btnCargar = New System.Windows.Forms.Button()
        Me.acpnlTitulo = New ACControles.ACPanelCaption()
        Me.btnCargarStockInicial = New System.Windows.Forms.Button()
        Me.pnlDetalle.SuspendLayout
        CType(Me.c1grdBusqueda,System.ComponentModel.ISupportInitialize).BeginInit
        Me.tstool.SuspendLayout
        CType(Me.bnavNavievador,System.ComponentModel.ISupportInitialize).BeginInit
        Me.bnavNavievador.SuspendLayout
        Me.pnlCabecera.SuspendLayout
        Me.SuspendLayout
        '
        'pnlDetalle
        '
        Me.pnlDetalle.Controls.Add(Me.c1grdBusqueda)
        Me.pnlDetalle.Controls.Add(Me.tstool)
        Me.pnlDetalle.Controls.Add(Me.bnavNavievador)
        Me.pnlDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDetalle.Location = New System.Drawing.Point(0, 117)
        Me.pnlDetalle.Name = "pnlDetalle"
        Me.pnlDetalle.Size = New System.Drawing.Size(865, 428)
        Me.pnlDetalle.TabIndex = 12
        '
        'c1grdBusqueda
        '
        Me.c1grdBusqueda.ColumnInfo = "2,1,0,0,0,90,Columns:0{Width:25;}"&Global.Microsoft.VisualBasic.ChrW(9)
        Me.c1grdBusqueda.Dock = System.Windows.Forms.DockStyle.Fill
        Me.c1grdBusqueda.Location = New System.Drawing.Point(0, 25)
        Me.c1grdBusqueda.Name = "c1grdBusqueda"
        Me.c1grdBusqueda.Rows.Count = 2
        Me.c1grdBusqueda.Rows.DefaultSize = 18
        Me.c1grdBusqueda.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.c1grdBusqueda.Size = New System.Drawing.Size(865, 364)
        Me.c1grdBusqueda.StyleInfo = resources.GetString("c1grdBusqueda.StyleInfo")
        Me.c1grdBusqueda.TabIndex = 3
        '
        'tstool
        '
        Me.tstool.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tstool.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tstool.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbtnImprimir, Me.tsbtnprevisualizar, Me.ToolStripSeparator1, Me.tsbtnSalir, Me.tsbtnExcel})
        Me.tstool.Location = New System.Drawing.Point(0, 389)
        Me.tstool.Name = "tstool"
        Me.tstool.Size = New System.Drawing.Size(865, 39)
        Me.tstool.TabIndex = 2
        Me.tstool.Text = "ToolStrip1"
        '
        'tsbtnImprimir
        '
        Me.tsbtnImprimir.Font = New System.Drawing.Font("Tahoma", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.tsbtnImprimir.Image = Global.ACPLogistica.My.Resources.Resources.ImprimirRed_32x32
        Me.tsbtnImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnImprimir.Name = "tsbtnImprimir"
        Me.tsbtnImprimir.Size = New System.Drawing.Size(108, 36)
        Me.tsbtnImprimir.Text = "Imprimir"
        Me.tsbtnImprimir.Visible = false
        '
        'tsbtnprevisualizar
        '
        Me.tsbtnprevisualizar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbtnprevisualizar.Font = New System.Drawing.Font("Tahoma", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.tsbtnprevisualizar.Image = Global.ACPLogistica.My.Resources.Resources.Reporte_32x32
        Me.tsbtnprevisualizar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnprevisualizar.Name = "tsbtnprevisualizar"
        Me.tsbtnprevisualizar.Size = New System.Drawing.Size(36, 36)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'tsbtnSalir
        '
        Me.tsbtnSalir.Font = New System.Drawing.Font("Tahoma", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.tsbtnSalir.Image = Global.ACPLogistica.My.Resources.Resources.Exit_32x32
        Me.tsbtnSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnSalir.Name = "tsbtnSalir"
        Me.tsbtnSalir.Size = New System.Drawing.Size(76, 36)
        Me.tsbtnSalir.Text = "Salir"
        '
        'tsbtnExcel
        '
        Me.tsbtnExcel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbtnExcel.Font = New System.Drawing.Font("Tahoma", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.tsbtnExcel.Image = Global.ACPLogistica.My.Resources.Resources.Excel2_32x32
        Me.tsbtnExcel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnExcel.Name = "tsbtnExcel"
        Me.tsbtnExcel.Size = New System.Drawing.Size(36, 36)
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
        Me.bnavNavievador.Size = New System.Drawing.Size(865, 25)
        Me.bnavNavievador.TabIndex = 1
        Me.bnavNavievador.Text = "BindingNavigator1"
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
        'pnlCabecera
        '
        Me.pnlCabecera.Controls.Add(Me.btnCargarStockInicial)
        Me.pnlCabecera.Controls.Add(Me.btnGrabarStockInicial)
        Me.pnlCabecera.Controls.Add(Me.dtpFecha)
        Me.pnlCabecera.Controls.Add(Me.lblPeriodo)
        Me.pnlCabecera.Controls.Add(Me.cmbPeriodo)
        Me.pnlCabecera.Controls.Add(Me.btnCargar)
        Me.pnlCabecera.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlCabecera.Location = New System.Drawing.Point(0, 30)
        Me.pnlCabecera.Name = "pnlCabecera"
        Me.pnlCabecera.Size = New System.Drawing.Size(865, 87)
        Me.pnlCabecera.TabIndex = 13
        '
        'btnGrabarStockInicial
        '
        Me.btnGrabarStockInicial.Image = Global.ACPLogistica.My.Resources.Resources.Grabar_32x32
        Me.btnGrabarStockInicial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGrabarStockInicial.Location = New System.Drawing.Point(719, 23)
        Me.btnGrabarStockInicial.Name = "btnGrabarStockInicial"
        Me.btnGrabarStockInicial.Size = New System.Drawing.Size(143, 39)
        Me.btnGrabarStockInicial.TabIndex = 15
        Me.btnGrabarStockInicial.Text = "Grabar Stock Inicial"
        Me.btnGrabarStockInicial.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGrabarStockInicial.UseVisualStyleBackColor = true
        '
        'dtpFecha
        '
        Me.dtpFecha.Enabled = false
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(142, 46)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.ShowCheckBox = true
        Me.dtpFecha.Size = New System.Drawing.Size(116, 20)
        Me.dtpFecha.TabIndex = 14
        '
        'lblPeriodo
        '
        Me.lblPeriodo.AutoSize = true
        Me.lblPeriodo.Location = New System.Drawing.Point(12, 23)
        Me.lblPeriodo.Name = "lblPeriodo"
        Me.lblPeriodo.Size = New System.Drawing.Size(49, 13)
        Me.lblPeriodo.TabIndex = 9
        Me.lblPeriodo.Text = "Periodo :"
        '
        'cmbPeriodo
        '
        Me.cmbPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPeriodo.FormattingEnabled = true
        Me.cmbPeriodo.Location = New System.Drawing.Point(60, 19)
        Me.cmbPeriodo.Name = "cmbPeriodo"
        Me.cmbPeriodo.Size = New System.Drawing.Size(198, 21)
        Me.cmbPeriodo.TabIndex = 10
        '
        'btnCargar
        '
        Me.btnCargar.Image = Global.ACPLogistica.My.Resources.Resources.Procesos_32x32
        Me.btnCargar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCargar.Location = New System.Drawing.Point(295, 23)
        Me.btnCargar.Name = "btnCargar"
        Me.btnCargar.Size = New System.Drawing.Size(126, 39)
        Me.btnCargar.TabIndex = 8
        Me.btnCargar.Text = "Cargar Datos  "
        Me.btnCargar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCargar.UseVisualStyleBackColor = true
        '
        'acpnlTitulo
        '
        Me.acpnlTitulo.ACCaption = "Stocks Iniciales"
        Me.acpnlTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.acpnlTitulo.Font = New System.Drawing.Font("Tahoma", 10!, System.Drawing.FontStyle.Bold)
        Me.acpnlTitulo.Location = New System.Drawing.Point(0, 0)
        Me.acpnlTitulo.Name = "acpnlTitulo"
        Me.acpnlTitulo.Size = New System.Drawing.Size(865, 30)
        Me.acpnlTitulo.TabIndex = 14
        '
        'btnCargarStockInicial
        '
        Me.btnCargarStockInicial.Image = Global.ACPLogistica.My.Resources.Resources.Procesos_32x32
        Me.btnCargarStockInicial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCargarStockInicial.Location = New System.Drawing.Point(427, 23)
        Me.btnCargarStockInicial.Name = "btnCargarStockInicial"
        Me.btnCargarStockInicial.Size = New System.Drawing.Size(166, 39)
        Me.btnCargarStockInicial.TabIndex = 16
        Me.btnCargarStockInicial.Text = "Cargar Stocks Iniciales"
        Me.btnCargarStockInicial.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCargarStockInicial.UseVisualStyleBackColor = true
        '
        'CStocksIniciales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(865, 545)
        Me.Controls.Add(Me.pnlDetalle)
        Me.Controls.Add(Me.pnlCabecera)
        Me.Controls.Add(Me.acpnlTitulo)
        Me.Name = "CStocksIniciales"
        Me.Text = "CStocksIniciales"
        Me.pnlDetalle.ResumeLayout(false)
        Me.pnlDetalle.PerformLayout
        CType(Me.c1grdBusqueda,System.ComponentModel.ISupportInitialize).EndInit
        Me.tstool.ResumeLayout(false)
        Me.tstool.PerformLayout
        CType(Me.bnavNavievador,System.ComponentModel.ISupportInitialize).EndInit
        Me.bnavNavievador.ResumeLayout(false)
        Me.bnavNavievador.PerformLayout
        Me.pnlCabecera.ResumeLayout(false)
        Me.pnlCabecera.PerformLayout
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents pnlDetalle As System.Windows.Forms.Panel
    Friend WithEvents c1grdBusqueda As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents tstool As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbtnImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnprevisualizar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbtnSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtnExcel As System.Windows.Forms.ToolStripButton
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
    Friend WithEvents pnlCabecera As System.Windows.Forms.Panel
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblPeriodo As System.Windows.Forms.Label
    Friend WithEvents cmbPeriodo As System.Windows.Forms.ComboBox
    Friend WithEvents btnCargar As System.Windows.Forms.Button
    Friend WithEvents acpnlTitulo As ACControles.ACPanelCaption
    Friend WithEvents btnGrabarStockInicial As System.Windows.Forms.Button
    Friend WithEvents btnCargarStockInicial As System.Windows.Forms.Button
End Class
