<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RcruzeAlmacenes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RcruzeAlmacenes))
        Me.acpnlTitulo = New ACControles.ACPanelCaption()
        Me.pnlCabecera = New System.Windows.Forms.Panel()
        Me.chkTodos = New System.Windows.Forms.CheckBox()
        Me.btnCargar = New System.Windows.Forms.Button()
        Me.AcFecha = New ACControles.ACFecha(Me.components)
        Me.grpAlmacenes = New System.Windows.Forms.GroupBox()
        Me.c1grdAlmacenes = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.actxaProdDescripcion = New ACControles.ACTextBoxAyuda()
        Me.actxaProdCodigo = New ACControles.ACTextBoxAyuda()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tstool = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnImprimir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnSalir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.c1grdBusqueda = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.pnlCabecera.SuspendLayout()
        Me.grpAlmacenes.SuspendLayout()
        CType(Me.c1grdAlmacenes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tstool.SuspendLayout()
        CType(Me.c1grdBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'acpnlTitulo
        '
        Me.acpnlTitulo.ACCaption = "Cruce Guias Entre Almacenes"
        Me.acpnlTitulo.BackColor = System.Drawing.Color.Red
        Me.acpnlTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.acpnlTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.acpnlTitulo.InactiveGradientHighColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(145, Byte), Integer))
        Me.acpnlTitulo.InactiveGradientLowColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.acpnlTitulo.Location = New System.Drawing.Point(0, 0)
        Me.acpnlTitulo.Name = "acpnlTitulo"
        Me.acpnlTitulo.Size = New System.Drawing.Size(1036, 39)
        Me.acpnlTitulo.TabIndex = 3
        '
        'pnlCabecera
        '
        Me.pnlCabecera.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.pnlCabecera.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlCabecera.Controls.Add(Me.chkTodos)
        Me.pnlCabecera.Controls.Add(Me.btnCargar)
        Me.pnlCabecera.Controls.Add(Me.AcFecha)
        Me.pnlCabecera.Controls.Add(Me.grpAlmacenes)
        Me.pnlCabecera.Controls.Add(Me.actxaProdDescripcion)
        Me.pnlCabecera.Controls.Add(Me.actxaProdCodigo)
        Me.pnlCabecera.Controls.Add(Me.Label2)
        Me.pnlCabecera.Controls.Add(Me.Label1)
        Me.pnlCabecera.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlCabecera.Location = New System.Drawing.Point(0, 39)
        Me.pnlCabecera.Name = "pnlCabecera"
        Me.pnlCabecera.Size = New System.Drawing.Size(1036, 128)
        Me.pnlCabecera.TabIndex = 4
        '
        'chkTodos
        '
        Me.chkTodos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkTodos.AutoSize = True
        Me.chkTodos.Location = New System.Drawing.Point(876, 106)
        Me.chkTodos.Name = "chkTodos"
        Me.chkTodos.Size = New System.Drawing.Size(94, 17)
        Me.chkTodos.TabIndex = 21
        Me.chkTodos.Text = "Mostrar Todos"
        Me.chkTodos.UseVisualStyleBackColor = True
        '
        'btnCargar
        '
        Me.btnCargar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCargar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCargar.Image = Global.ACPLogistica.My.Resources.Resources.Check_Proces_32x32
        Me.btnCargar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCargar.Location = New System.Drawing.Point(876, 61)
        Me.btnCargar.Name = "btnCargar"
        Me.btnCargar.Size = New System.Drawing.Size(155, 39)
        Me.btnCargar.TabIndex = 20
        Me.btnCargar.Text = "Procesar "
        Me.btnCargar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCargar.UseVisualStyleBackColor = True
        '
        'AcFecha
        '
        Me.AcFecha.ACFecha_A = New Date(2016, 4, 21, 9, 35, 40, 544)
        Me.AcFecha.ACFecha_De = New Date(2016, 4, 21, 9, 35, 40, 543)
        Me.AcFecha.ACFechaObligatoria = True
        Me.AcFecha.ACFormatoControl = ACControles.ACFecha.ACTipoFormatoControl.Horizontal
        Me.AcFecha.ACHoyChecked = False
        Me.AcFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AcFecha.Location = New System.Drawing.Point(694, 12)
        Me.AcFecha.MaximumSize = New System.Drawing.Size(337, 43)
        Me.AcFecha.MinimumSize = New System.Drawing.Size(337, 43)
        Me.AcFecha.Name = "AcFecha"
        Me.AcFecha.Size = New System.Drawing.Size(337, 43)
        Me.AcFecha.TabIndex = 19
        Me.AcFecha.TabStop = False
        '
        'grpAlmacenes
        '
        Me.grpAlmacenes.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpAlmacenes.Controls.Add(Me.c1grdAlmacenes)
        Me.grpAlmacenes.Location = New System.Drawing.Point(440, 5)
        Me.grpAlmacenes.Name = "grpAlmacenes"
        Me.grpAlmacenes.Size = New System.Drawing.Size(227, 124)
        Me.grpAlmacenes.TabIndex = 18
        Me.grpAlmacenes.TabStop = False
        Me.grpAlmacenes.Text = "Almacen"
        '
        'c1grdAlmacenes
        '
        Me.c1grdAlmacenes.ColumnInfo = "2,1,0,0,0,90,Columns:0{Width:25;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.c1grdAlmacenes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.c1grdAlmacenes.Location = New System.Drawing.Point(3, 16)
        Me.c1grdAlmacenes.Name = "c1grdAlmacenes"
        Me.c1grdAlmacenes.Rows.Count = 2
        Me.c1grdAlmacenes.Rows.DefaultSize = 18
        Me.c1grdAlmacenes.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.c1grdAlmacenes.Size = New System.Drawing.Size(221, 105)
        Me.c1grdAlmacenes.StyleInfo = resources.GetString("c1grdAlmacenes.StyleInfo")
        Me.c1grdAlmacenes.TabIndex = 8
        '
        'actxaProdDescripcion
        '
        Me.actxaProdDescripcion.ACActivarAyudaAuto = False
        Me.actxaProdDescripcion.ACLongitudAceptada = 0
        Me.actxaProdDescripcion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.actxaProdDescripcion.Location = New System.Drawing.Point(96, 76)
        Me.actxaProdDescripcion.MaxLength = 32767
        Me.actxaProdDescripcion.Name = "actxaProdDescripcion"
        Me.actxaProdDescripcion.Size = New System.Drawing.Size(338, 20)
        Me.actxaProdDescripcion.TabIndex = 17
        Me.actxaProdDescripcion.Tag = "EVO"
        '
        'actxaProdCodigo
        '
        Me.actxaProdCodigo.ACActivarAyudaAuto = False
        Me.actxaProdCodigo.ACLongitudAceptada = 0
        Me.actxaProdCodigo.Location = New System.Drawing.Point(96, 35)
        Me.actxaProdCodigo.MaxLength = 32767
        Me.actxaProdCodigo.Name = "actxaProdCodigo"
        Me.actxaProdCodigo.Size = New System.Drawing.Size(203, 20)
        Me.actxaProdCodigo.TabIndex = 16
        Me.actxaProdCodigo.Tag = "EVO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Descripción :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Codigo :"
        '
        'tstool
        '
        Me.tstool.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tstool.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tstool.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripSeparator2, Me.tsbtnImprimir, Me.ToolStripSeparator1, Me.tsbtnSalir, Me.ToolStripSeparator3})
        Me.tstool.Location = New System.Drawing.Point(0, 478)
        Me.tstool.Name = "tstool"
        Me.tstool.Size = New System.Drawing.Size(1036, 39)
        Me.tstool.TabIndex = 6
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
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 39)
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
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
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
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 39)
        '
        'c1grdBusqueda
        '
        Me.c1grdBusqueda.ColumnInfo = "2,1,0,0,0,90,Columns:0{Width:25;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.c1grdBusqueda.Dock = System.Windows.Forms.DockStyle.Fill
        Me.c1grdBusqueda.Location = New System.Drawing.Point(0, 167)
        Me.c1grdBusqueda.Name = "c1grdBusqueda"
        Me.c1grdBusqueda.Rows.Count = 2
        Me.c1grdBusqueda.Rows.DefaultSize = 18
        Me.c1grdBusqueda.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row
        Me.c1grdBusqueda.Size = New System.Drawing.Size(1036, 311)
        Me.c1grdBusqueda.StyleInfo = resources.GetString("c1grdBusqueda.StyleInfo")
        Me.c1grdBusqueda.TabIndex = 7
        '
        'RcruzeAlmacenes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1036, 517)
        Me.Controls.Add(Me.c1grdBusqueda)
        Me.Controls.Add(Me.tstool)
        Me.Controls.Add(Me.pnlCabecera)
        Me.Controls.Add(Me.acpnlTitulo)
        Me.Name = "RcruzeAlmacenes"
        Me.Text = "Cruze entre Almacenes"
        Me.pnlCabecera.ResumeLayout(False)
        Me.pnlCabecera.PerformLayout()
        Me.grpAlmacenes.ResumeLayout(False)
        CType(Me.c1grdAlmacenes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tstool.ResumeLayout(False)
        Me.tstool.PerformLayout()
        CType(Me.c1grdBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents acpnlTitulo As ACControles.ACPanelCaption
    Friend WithEvents pnlCabecera As System.Windows.Forms.Panel
    Friend WithEvents actxaProdDescripcion As ACControles.ACTextBoxAyuda
    Friend WithEvents actxaProdCodigo As ACControles.ACTextBoxAyuda
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grpAlmacenes As System.Windows.Forms.GroupBox
    Friend WithEvents c1grdAlmacenes As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents AcFecha As ACControles.ACFecha
    Friend WithEvents btnCargar As System.Windows.Forms.Button
    Friend WithEvents chkTodos As System.Windows.Forms.CheckBox
    Friend WithEvents tstool As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbtnImprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbtnSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents c1grdBusqueda As C1.Win.C1FlexGrid.C1FlexGrid
End Class
