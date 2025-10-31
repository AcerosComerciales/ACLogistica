<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RGuiasGeneralFecha
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
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RGuiasGeneralFecha))
      Me.AcFecha = New ACControles.ACFecha(Me.components)
      Me.btnProcesar = New System.Windows.Forms.Button()
      Me.Panel2 = New System.Windows.Forms.Panel()
      Me.btnExcel = New System.Windows.Forms.Button()
      Me.AcPanelCaption6 = New ACControles.ACPanelCaption()
      Me.ToolStripSeparator12 = New System.Windows.Forms.ToolStripSeparator()
      Me.ToolStripButton24 = New System.Windows.Forms.ToolStripButton()
      Me.ToolStripButton23 = New System.Windows.Forms.ToolStripButton()
      Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator()
      Me.ToolStripTextBox4 = New System.Windows.Forms.ToolStripTextBox()
      Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
      Me.ToolStripButton22 = New System.Windows.Forms.ToolStripButton()
      Me.ToolStripButton21 = New System.Windows.Forms.ToolStripButton()
      Me.ToolStripButton20 = New System.Windows.Forms.ToolStripButton()
      Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel()
      Me.ToolStripButton19 = New System.Windows.Forms.ToolStripButton()
      Me.bnavNavegador = New System.Windows.Forms.BindingNavigator(Me.components)
      Me.actxnSaldoAnteriorEfectivoDol = New ACControles.ACTextBoxNumerico()
      Me.Label1 = New System.Windows.Forms.Label()
      Me.actxnSaldoAnteriorEfectivo = New ACControles.ACTextBoxNumerico()
      Me.Label6 = New System.Windows.Forms.Label()
      Me.c1grdBusqueda = New C1.Win.C1FlexGrid.C1FlexGrid()
      Me.Panel7 = New System.Windows.Forms.Panel()
      Me.Panel1 = New System.Windows.Forms.Panel()
      Me.AcPanelCaption1 = New ACControles.ACPanelCaption()
      Me.Panel2.SuspendLayout()
      CType(Me.bnavNavegador, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.bnavNavegador.SuspendLayout()
      CType(Me.c1grdBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.Panel7.SuspendLayout()
      Me.Panel1.SuspendLayout()
      Me.SuspendLayout()
      '
      'AcFecha
      '
      Me.AcFecha.ACFecha_A = New Date(2013, 12, 11, 12, 8, 17, 318)
      Me.AcFecha.ACFecha_De = New Date(2013, 12, 11, 12, 8, 17, 316)
      Me.AcFecha.ACFormatoControl = ACControles.ACFecha.ACTipoFormatoControl.Horizontal
      Me.AcFecha.ACHoyChecked = False
      Me.AcFecha.Location = New System.Drawing.Point(12, 6)
      Me.AcFecha.MaximumSize = New System.Drawing.Size(340, 50)
      Me.AcFecha.MinimumSize = New System.Drawing.Size(337, 43)
      Me.AcFecha.Name = "AcFecha"
      Me.AcFecha.Size = New System.Drawing.Size(337, 50)
      Me.AcFecha.TabIndex = 25
      Me.AcFecha.TabStop = False
      '
      'btnProcesar
      '
      Me.btnProcesar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.btnProcesar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnProcesar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
      Me.btnProcesar.Location = New System.Drawing.Point(495, 6)
      Me.btnProcesar.Name = "btnProcesar"
      Me.btnProcesar.Size = New System.Drawing.Size(120, 41)
      Me.btnProcesar.TabIndex = 7
      Me.btnProcesar.Text = "Procesar"
      Me.btnProcesar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.btnProcesar.UseVisualStyleBackColor = True
      '
      'Panel2
      '
      Me.Panel2.Controls.Add(Me.AcFecha)
      Me.Panel2.Controls.Add(Me.btnExcel)
      Me.Panel2.Controls.Add(Me.btnProcesar)
      Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
      Me.Panel2.Location = New System.Drawing.Point(0, 30)
      Me.Panel2.Name = "Panel2"
      Me.Panel2.Size = New System.Drawing.Size(667, 63)
      Me.Panel2.TabIndex = 57
      '
      'btnExcel
      '
      Me.btnExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.btnExcel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.btnExcel.Location = New System.Drawing.Point(621, 6)
      Me.btnExcel.Name = "btnExcel"
      Me.btnExcel.Size = New System.Drawing.Size(43, 41)
      Me.btnExcel.TabIndex = 8
      Me.btnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.btnExcel.UseVisualStyleBackColor = True
      '
      'AcPanelCaption6
      '
      Me.AcPanelCaption6.ACCaption = "Cuadre de Efectivo"
      Me.AcPanelCaption6.Dock = System.Windows.Forms.DockStyle.Top
      Me.AcPanelCaption6.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
      Me.AcPanelCaption6.Location = New System.Drawing.Point(0, 0)
      Me.AcPanelCaption6.Name = "AcPanelCaption6"
      Me.AcPanelCaption6.Size = New System.Drawing.Size(667, 25)
      Me.AcPanelCaption6.TabIndex = 73
      '
      'ToolStripSeparator12
      '
      Me.ToolStripSeparator12.Name = "ToolStripSeparator12"
      Me.ToolStripSeparator12.Size = New System.Drawing.Size(6, 25)
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
      'ToolStripButton23
      '
      Me.ToolStripButton23.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
      Me.ToolStripButton23.Image = CType(resources.GetObject("ToolStripButton23.Image"), System.Drawing.Image)
      Me.ToolStripButton23.Name = "ToolStripButton23"
      Me.ToolStripButton23.RightToLeftAutoMirrorImage = True
      Me.ToolStripButton23.Size = New System.Drawing.Size(23, 22)
      Me.ToolStripButton23.Text = "Move next"
      '
      'ToolStripSeparator11
      '
      Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
      Me.ToolStripSeparator11.Size = New System.Drawing.Size(6, 25)
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
      'ToolStripSeparator10
      '
      Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
      Me.ToolStripSeparator10.Size = New System.Drawing.Size(6, 25)
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
      'ToolStripButton21
      '
      Me.ToolStripButton21.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
      Me.ToolStripButton21.Image = CType(resources.GetObject("ToolStripButton21.Image"), System.Drawing.Image)
      Me.ToolStripButton21.Name = "ToolStripButton21"
      Me.ToolStripButton21.RightToLeftAutoMirrorImage = True
      Me.ToolStripButton21.Size = New System.Drawing.Size(23, 22)
      Me.ToolStripButton21.Text = "Move first"
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
      'ToolStripLabel4
      '
      Me.ToolStripLabel4.Name = "ToolStripLabel4"
      Me.ToolStripLabel4.Size = New System.Drawing.Size(35, 22)
      Me.ToolStripLabel4.Text = "of {0}"
      Me.ToolStripLabel4.ToolTipText = "Total number of items"
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
      'bnavNavegador
      '
      Me.bnavNavegador.AddNewItem = Me.ToolStripButton19
      Me.bnavNavegador.CountItem = Me.ToolStripLabel4
      Me.bnavNavegador.DeleteItem = Me.ToolStripButton20
      Me.bnavNavegador.Dock = System.Windows.Forms.DockStyle.Bottom
      Me.bnavNavegador.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton21, Me.ToolStripButton22, Me.ToolStripSeparator10, Me.ToolStripTextBox4, Me.ToolStripLabel4, Me.ToolStripSeparator11, Me.ToolStripButton23, Me.ToolStripButton24, Me.ToolStripSeparator12, Me.ToolStripButton19, Me.ToolStripButton20})
      Me.bnavNavegador.Location = New System.Drawing.Point(0, 394)
      Me.bnavNavegador.MoveFirstItem = Me.ToolStripButton21
      Me.bnavNavegador.MoveLastItem = Me.ToolStripButton24
      Me.bnavNavegador.MoveNextItem = Me.ToolStripButton23
      Me.bnavNavegador.MovePreviousItem = Me.ToolStripButton22
      Me.bnavNavegador.Name = "bnavNavegador"
      Me.bnavNavegador.PositionItem = Me.ToolStripTextBox4
      Me.bnavNavegador.Size = New System.Drawing.Size(667, 25)
      Me.bnavNavegador.TabIndex = 71
      Me.bnavNavegador.Text = "BindingNavigator1"
      '
      'actxnSaldoAnteriorEfectivoDol
      '
      Me.actxnSaldoAnteriorEfectivoDol.ACEnteros = 9
      Me.actxnSaldoAnteriorEfectivoDol.ACEstandar = ACControles.ACEstandaresFormato.ACDecimal
      Me.actxnSaldoAnteriorEfectivoDol.ACNegativo = True
      Me.actxnSaldoAnteriorEfectivoDol.ACValue = New Decimal(New Integer() {0, 0, 0, 131072})
      Me.actxnSaldoAnteriorEfectivoDol.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.actxnSaldoAnteriorEfectivoDol.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
      Me.actxnSaldoAnteriorEfectivoDol.Location = New System.Drawing.Point(537, 3)
      Me.actxnSaldoAnteriorEfectivoDol.MaxLength = 12
      Me.actxnSaldoAnteriorEfectivoDol.Name = "actxnSaldoAnteriorEfectivoDol"
      Me.actxnSaldoAnteriorEfectivoDol.Size = New System.Drawing.Size(118, 26)
      Me.actxnSaldoAnteriorEfectivoDol.TabIndex = 28
      Me.actxnSaldoAnteriorEfectivoDol.Tag = "EV"
      Me.actxnSaldoAnteriorEfectivoDol.Text = "0.00"
      Me.actxnSaldoAnteriorEfectivoDol.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
      '
      'Label1
      '
      Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.Label1.AutoSize = True
      Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
      Me.Label1.Location = New System.Drawing.Point(399, 7)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(132, 19)
      Me.Label1.TabIndex = 27
      Me.Label1.Text = "Saldo Anterior : US$"
      '
      'actxnSaldoAnteriorEfectivo
      '
      Me.actxnSaldoAnteriorEfectivo.ACEnteros = 9
      Me.actxnSaldoAnteriorEfectivo.ACEstandar = ACControles.ACEstandaresFormato.ACDecimal
      Me.actxnSaldoAnteriorEfectivo.ACNegativo = True
      Me.actxnSaldoAnteriorEfectivo.ACValue = New Decimal(New Integer() {0, 0, 0, 131072})
      Me.actxnSaldoAnteriorEfectivo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.actxnSaldoAnteriorEfectivo.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World)
      Me.actxnSaldoAnteriorEfectivo.Location = New System.Drawing.Point(275, 3)
      Me.actxnSaldoAnteriorEfectivo.MaxLength = 12
      Me.actxnSaldoAnteriorEfectivo.Name = "actxnSaldoAnteriorEfectivo"
      Me.actxnSaldoAnteriorEfectivo.Size = New System.Drawing.Size(118, 26)
      Me.actxnSaldoAnteriorEfectivo.TabIndex = 26
      Me.actxnSaldoAnteriorEfectivo.Tag = "EV"
      Me.actxnSaldoAnteriorEfectivo.Text = "0.00"
      Me.actxnSaldoAnteriorEfectivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
      '
      'Label6
      '
      Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.Label6.AutoSize = True
      Me.Label6.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
      Me.Label6.Location = New System.Drawing.Point(147, 7)
      Me.Label6.Name = "Label6"
      Me.Label6.Size = New System.Drawing.Size(122, 19)
      Me.Label6.TabIndex = 0
      Me.Label6.Text = "Saldo Anterior : S/."
      '
      'c1grdBusqueda
      '
      Me.c1grdBusqueda.ColumnInfo = "2,1,0,0,0,100,Columns:0{Width:25;}" & Global.Microsoft.VisualBasic.ChrW(9)
      Me.c1grdBusqueda.Dock = System.Windows.Forms.DockStyle.Fill
      Me.c1grdBusqueda.Location = New System.Drawing.Point(0, 60)
      Me.c1grdBusqueda.Name = "c1grdBusqueda"
      Me.c1grdBusqueda.Rows.Count = 2
      Me.c1grdBusqueda.Rows.DefaultSize = 20
      Me.c1grdBusqueda.Size = New System.Drawing.Size(667, 334)
      Me.c1grdBusqueda.StyleInfo = resources.GetString("c1grdBusqueda.StyleInfo")
      Me.c1grdBusqueda.TabIndex = 74
      '
      'Panel7
      '
      Me.Panel7.Controls.Add(Me.actxnSaldoAnteriorEfectivoDol)
      Me.Panel7.Controls.Add(Me.Label1)
      Me.Panel7.Controls.Add(Me.actxnSaldoAnteriorEfectivo)
      Me.Panel7.Controls.Add(Me.Label6)
      Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
      Me.Panel7.Location = New System.Drawing.Point(0, 25)
      Me.Panel7.Name = "Panel7"
      Me.Panel7.Size = New System.Drawing.Size(667, 35)
      Me.Panel7.TabIndex = 72
      '
      'Panel1
      '
      Me.Panel1.Controls.Add(Me.c1grdBusqueda)
      Me.Panel1.Controls.Add(Me.Panel7)
      Me.Panel1.Controls.Add(Me.bnavNavegador)
      Me.Panel1.Controls.Add(Me.AcPanelCaption6)
      Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
      Me.Panel1.Location = New System.Drawing.Point(0, 30)
      Me.Panel1.Name = "Panel1"
      Me.Panel1.Size = New System.Drawing.Size(667, 419)
      Me.Panel1.TabIndex = 56
      '
      'AcPanelCaption1
      '
      Me.AcPanelCaption1.ACCaption = "Reporte de Consulta de Efectivo"
      Me.AcPanelCaption1.Dock = System.Windows.Forms.DockStyle.Top
      Me.AcPanelCaption1.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
      Me.AcPanelCaption1.Location = New System.Drawing.Point(0, 0)
      Me.AcPanelCaption1.Name = "AcPanelCaption1"
      Me.AcPanelCaption1.Size = New System.Drawing.Size(667, 30)
      Me.AcPanelCaption1.TabIndex = 55
      '
      'RGuiasGeneralFecha
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(667, 449)
      Me.Controls.Add(Me.Panel2)
      Me.Controls.Add(Me.Panel1)
      Me.Controls.Add(Me.AcPanelCaption1)
      Me.Name = "RGuiasGeneralFecha"
      Me.Text = "Reporte de Guías po Fecha"
      Me.Panel2.ResumeLayout(False)
      CType(Me.bnavNavegador, System.ComponentModel.ISupportInitialize).EndInit()
      Me.bnavNavegador.ResumeLayout(False)
      Me.bnavNavegador.PerformLayout()
      CType(Me.c1grdBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
      Me.Panel7.ResumeLayout(False)
      Me.Panel7.PerformLayout()
      Me.Panel1.ResumeLayout(False)
      Me.Panel1.PerformLayout()
      Me.ResumeLayout(False)

   End Sub
   Friend WithEvents AcFecha As ACControles.ACFecha
   Friend WithEvents btnProcesar As System.Windows.Forms.Button
   Friend WithEvents Panel2 As System.Windows.Forms.Panel
   Friend WithEvents btnExcel As System.Windows.Forms.Button
   Friend WithEvents AcPanelCaption6 As ACControles.ACPanelCaption
   Friend WithEvents ToolStripSeparator12 As System.Windows.Forms.ToolStripSeparator
   Friend WithEvents ToolStripButton24 As System.Windows.Forms.ToolStripButton
   Friend WithEvents ToolStripButton23 As System.Windows.Forms.ToolStripButton
   Friend WithEvents ToolStripSeparator11 As System.Windows.Forms.ToolStripSeparator
   Friend WithEvents ToolStripTextBox4 As System.Windows.Forms.ToolStripTextBox
   Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
   Friend WithEvents ToolStripButton22 As System.Windows.Forms.ToolStripButton
   Friend WithEvents ToolStripButton21 As System.Windows.Forms.ToolStripButton
   Friend WithEvents ToolStripButton20 As System.Windows.Forms.ToolStripButton
   Friend WithEvents ToolStripLabel4 As System.Windows.Forms.ToolStripLabel
   Friend WithEvents ToolStripButton19 As System.Windows.Forms.ToolStripButton
   Friend WithEvents bnavNavegador As System.Windows.Forms.BindingNavigator
   Friend WithEvents actxnSaldoAnteriorEfectivoDol As ACControles.ACTextBoxNumerico
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents actxnSaldoAnteriorEfectivo As ACControles.ACTextBoxNumerico
   Friend WithEvents Label6 As System.Windows.Forms.Label
   Friend WithEvents c1grdBusqueda As C1.Win.C1FlexGrid.C1FlexGrid
   Friend WithEvents Panel7 As System.Windows.Forms.Panel
   Friend WithEvents Panel1 As System.Windows.Forms.Panel
   Friend WithEvents AcPanelCaption1 As ACControles.ACPanelCaption
End Class
