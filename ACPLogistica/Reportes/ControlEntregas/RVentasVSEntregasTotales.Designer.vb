<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RVentasVSEntregasTotales
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RVentasVSEntregasTotales))
        Me.pnlCabecera = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.c1grdAlmacenesDestino = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.AcFecha = New ACControles.ACFecha(Me.components)
        Me.btnProcesar = New System.Windows.Forms.Button()
        Me.btnExcel = New System.Windows.Forms.Button()
        Me.pgBar = New System.Windows.Forms.ProgressBar()
        Me.pnlDetalle = New System.Windows.Forms.Panel()
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
        Me.AccmsSeleccionarC11 = New ACControlesC1.ACCMSSeleccionarC1()
        Me.AcPanelCaption1 = New ACControles.ACPanelCaption()
        Me.pnlCabecera.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.c1grdAlmacenesDestino, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.pnlDetalle.SuspendLayout()
        CType(Me.c1grdReporte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bnavReporte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bnavReporte.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlCabecera
        '
        Me.pnlCabecera.Controls.Add(Me.GroupBox1)
        Me.pnlCabecera.Controls.Add(Me.SplitContainer2)
        Me.pnlCabecera.Controls.Add(Me.pgBar)
        Me.pnlCabecera.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlCabecera.Location = New System.Drawing.Point(0, 45)
        Me.pnlCabecera.Name = "pnlCabecera"
        Me.pnlCabecera.Size = New System.Drawing.Size(1229, 156)
        Me.pnlCabecera.TabIndex = 14
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.c1grdAlmacenesDestino)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupBox1.Location = New System.Drawing.Point(803, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(426, 136)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PuntoDestino"
        '
        'c1grdAlmacenesDestino
        '
        Me.c1grdAlmacenesDestino.ColumnInfo = "2,1,0,0,0,90,Columns:0{Width:25;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.c1grdAlmacenesDestino.Dock = System.Windows.Forms.DockStyle.Fill
        Me.c1grdAlmacenesDestino.Location = New System.Drawing.Point(3, 16)
        Me.c1grdAlmacenesDestino.Name = "c1grdAlmacenesDestino"
        Me.c1grdAlmacenesDestino.Rows.Count = 2
        Me.c1grdAlmacenesDestino.Rows.DefaultSize = 18
        Me.c1grdAlmacenesDestino.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.c1grdAlmacenesDestino.Size = New System.Drawing.Size(420, 117)
        Me.c1grdAlmacenesDestino.StyleInfo = resources.GetString("c1grdAlmacenesDestino.StyleInfo")
        Me.c1grdAlmacenesDestino.TabIndex = 8
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Location = New System.Drawing.Point(3, 6)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.AcFecha)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.btnProcesar)
        Me.SplitContainer2.Panel2.Controls.Add(Me.btnExcel)
        Me.SplitContainer2.Size = New System.Drawing.Size(464, 124)
        Me.SplitContainer2.SplitterDistance = 241
        Me.SplitContainer2.TabIndex = 77
        '
        'AcFecha
        '
        Me.AcFecha.ACFecha_A = New Date(2013, 10, 18, 11, 41, 5, 950)
        Me.AcFecha.ACFecha_De = New Date(2013, 10, 18, 11, 41, 5, 947)
        Me.AcFecha.ACFechaObligatoria = True
        Me.AcFecha.ACHoyChecked = False
        Me.AcFecha.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AcFecha.Location = New System.Drawing.Point(0, 0)
        Me.AcFecha.MaximumSize = New System.Drawing.Size(300, 94)
        Me.AcFecha.MinimumSize = New System.Drawing.Size(176, 94)
        Me.AcFecha.Name = "AcFecha"
        Me.AcFecha.Size = New System.Drawing.Size(241, 94)
        Me.AcFecha.TabIndex = 14
        Me.AcFecha.TabStop = False
        '
        'btnProcesar
        '
        Me.btnProcesar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProcesar.BackgroundImage = Global.ACPLogistica.My.Resources.Resources.Buscar2_32x32
        Me.btnProcesar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnProcesar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProcesar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProcesar.Location = New System.Drawing.Point(43, 10)
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(120, 41)
        Me.btnProcesar.TabIndex = 72
        Me.btnProcesar.Text = "Iniciar"
        Me.btnProcesar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnProcesar.UseVisualStyleBackColor = True
        '
        'btnExcel
        '
        Me.btnExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExcel.BackgroundImage = Global.ACPLogistica.My.Resources.Resources.Excel2_32x32
        Me.btnExcel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnExcel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExcel.Location = New System.Drawing.Point(86, 71)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(42, 39)
        Me.btnExcel.TabIndex = 75
        Me.btnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExcel.UseVisualStyleBackColor = True
        '
        'pgBar
        '
        Me.pgBar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pgBar.Location = New System.Drawing.Point(0, 136)
        Me.pgBar.Name = "pgBar"
        Me.pgBar.Size = New System.Drawing.Size(1229, 20)
        Me.pgBar.TabIndex = 74
        '
        'pnlDetalle
        '
        Me.pnlDetalle.Controls.Add(Me.c1grdReporte)
        Me.pnlDetalle.Controls.Add(Me.bnavReporte)
        Me.pnlDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlDetalle.Location = New System.Drawing.Point(0, 201)
        Me.pnlDetalle.Name = "pnlDetalle"
        Me.pnlDetalle.Size = New System.Drawing.Size(1229, 377)
        Me.pnlDetalle.TabIndex = 15
        '
        'c1grdReporte
        '
        Me.c1grdReporte.ColumnInfo = "2,1,0,0,0,100,Columns:0{Width:25;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.c1grdReporte.Dock = System.Windows.Forms.DockStyle.Fill
        Me.c1grdReporte.Location = New System.Drawing.Point(0, 0)
        Me.c1grdReporte.Name = "c1grdReporte"
        Me.c1grdReporte.Rows.Count = 2
        Me.c1grdReporte.Rows.DefaultSize = 20
        Me.c1grdReporte.Size = New System.Drawing.Size(1229, 352)
        Me.c1grdReporte.StyleInfo = resources.GetString("c1grdReporte.StyleInfo")
        Me.c1grdReporte.TabIndex = 70
        '
        'bnavReporte
        '
        Me.bnavReporte.AddNewItem = Me.ToolStripButton1
        Me.bnavReporte.CountItem = Me.ToolStripLabel1
        Me.bnavReporte.DeleteItem = Me.ToolStripButton2
        Me.bnavReporte.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.bnavReporte.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripSeparator1, Me.ToolStripTextBox1, Me.ToolStripLabel1, Me.ToolStripSeparator2, Me.ToolStripButton5, Me.ToolStripButton6, Me.ToolStripSeparator3, Me.ToolStripButton1, Me.ToolStripButton2})
        Me.bnavReporte.Location = New System.Drawing.Point(0, 352)
        Me.bnavReporte.MoveFirstItem = Me.ToolStripButton3
        Me.bnavReporte.MoveLastItem = Me.ToolStripButton6
        Me.bnavReporte.MoveNextItem = Me.ToolStripButton5
        Me.bnavReporte.MovePreviousItem = Me.ToolStripButton4
        Me.bnavReporte.Name = "bnavReporte"
        Me.bnavReporte.PositionItem = Me.ToolStripTextBox1
        Me.bnavReporte.Size = New System.Drawing.Size(1229, 25)
        Me.bnavReporte.TabIndex = 71
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
        'AccmsSeleccionarC11
        '
        Me.AccmsSeleccionarC11.Name = "cmsOpciones"
        Me.AccmsSeleccionarC11.Size = New System.Drawing.Size(209, 92)
        '
        'AcPanelCaption1
        '
        Me.AcPanelCaption1.ACCaption = "Reporte Comparativo AlmacenxGuiasxOrdenesXNotaCredito"
        Me.AcPanelCaption1.ActiveGradientHighColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.AcPanelCaption1.ActiveGradientLowColor = System.Drawing.Color.Maroon
        Me.AcPanelCaption1.ActiveTextColor = System.Drawing.Color.White
        Me.AcPanelCaption1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.AcPanelCaption1.Dock = System.Windows.Forms.DockStyle.Top
        Me.AcPanelCaption1.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.0!, System.Drawing.FontStyle.Bold)
        Me.AcPanelCaption1.Location = New System.Drawing.Point(0, 0)
        Me.AcPanelCaption1.Name = "AcPanelCaption1"
        Me.AcPanelCaption1.Size = New System.Drawing.Size(1229, 45)
        Me.AcPanelCaption1.TabIndex = 18
        '
        'RVentasVSEntregasTotales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1229, 578)
        Me.Controls.Add(Me.pnlDetalle)
        Me.Controls.Add(Me.pnlCabecera)
        Me.Controls.Add(Me.AcPanelCaption1)
        Me.Name = "RVentasVSEntregasTotales"
        Me.Text = "RVentasVSEntregasTotales"
        Me.pnlCabecera.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.c1grdAlmacenesDestino, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.pnlDetalle.ResumeLayout(False)
        Me.pnlDetalle.PerformLayout()
        CType(Me.c1grdReporte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bnavReporte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bnavReporte.ResumeLayout(False)
        Me.bnavReporte.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlCabecera As Panel
    Friend WithEvents btnExcel As Button
    Friend WithEvents btnProcesar As Button
    Friend WithEvents AcFecha As ACControles.ACFecha
    Friend WithEvents pgBar As ProgressBar
    Friend WithEvents pnlDetalle As Panel
    Friend WithEvents c1grdReporte As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents bnavReporte As BindingNavigator
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripButton5 As ToolStripButton
    Friend WithEvents ToolStripButton6 As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents AccmsSeleccionarC11 As ACControlesC1.ACCMSSeleccionarC1
    Friend WithEvents AcPanelCaption1 As ACControles.ACPanelCaption
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents c1grdAlmacenesDestino As C1.Win.C1FlexGrid.C1FlexGrid
End Class
