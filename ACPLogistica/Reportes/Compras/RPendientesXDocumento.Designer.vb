<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RPendientesXDocumento
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
        Me.AcPanelCaption1 = New ACControles.ACPanelCaption()
        Me.rbtnDocsCompra = New System.Windows.Forms.RadioButton()
        Me.rbtnOrdenesCompra = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.AcFecha = New ACControles.ACFecha(Me.components)
        Me.btnProcesar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'AcPanelCaption1
        '
        Me.AcPanelCaption1.ACCaption = "Reporte de Cuadre de Pendientes (Compras)"
        Me.AcPanelCaption1.Dock = System.Windows.Forms.DockStyle.Top
        Me.AcPanelCaption1.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.AcPanelCaption1.Location = New System.Drawing.Point(0, 0)
        Me.AcPanelCaption1.Name = "AcPanelCaption1"
        Me.AcPanelCaption1.Size = New System.Drawing.Size(371, 30)
        Me.AcPanelCaption1.TabIndex = 23
        '
        'rbtnDocsCompra
        '
        Me.rbtnDocsCompra.AutoSize = True
        Me.rbtnDocsCompra.Location = New System.Drawing.Point(189, 36)
        Me.rbtnDocsCompra.Name = "rbtnDocsCompra"
        Me.rbtnDocsCompra.Size = New System.Drawing.Size(167, 17)
        Me.rbtnDocsCompra.TabIndex = 21
        Me.rbtnDocsCompra.Text = "P. de Documentos de Compra"
        Me.rbtnDocsCompra.UseVisualStyleBackColor = True
        '
        'rbtnOrdenesCompra
        '
        Me.rbtnOrdenesCompra.AutoSize = True
        Me.rbtnOrdenesCompra.Checked = True
        Me.rbtnOrdenesCompra.Location = New System.Drawing.Point(12, 36)
        Me.rbtnOrdenesCompra.Name = "rbtnOrdenesCompra"
        Me.rbtnOrdenesCompra.Size = New System.Drawing.Size(147, 17)
        Me.rbtnOrdenesCompra.TabIndex = 20
        Me.rbtnOrdenesCompra.TabStop = True
        Me.rbtnOrdenesCompra.Text = "P. de Ordenes de Compra"
        Me.rbtnOrdenesCompra.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.ACPLogistica.My.Resources.Resources.Volver_32x32
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(246, 117)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 41)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Salir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'AcFecha
        '
        Me.AcFecha.ACFecha_A = New Date(2012, 7, 9, 12, 43, 16, 227)
        Me.AcFecha.ACFecha_De = New Date(2012, 7, 9, 12, 43, 24, 452)
        Me.AcFecha.ACFechaObligatoria = True
        Me.AcFecha.ACHoyChecked = False
        Me.AcFecha.Location = New System.Drawing.Point(10, 65)
        Me.AcFecha.MaximumSize = New System.Drawing.Size(300, 94)
        Me.AcFecha.MinimumSize = New System.Drawing.Size(176, 94)
        Me.AcFecha.Name = "AcFecha"
        Me.AcFecha.Size = New System.Drawing.Size(202, 94)
        Me.AcFecha.TabIndex = 17
        Me.AcFecha.TabStop = False
        '
        'btnProcesar
        '
        Me.btnProcesar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProcesar.Image = Global.ACPLogistica.My.Resources.Resources.Search_files_32x32
        Me.btnProcesar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProcesar.Location = New System.Drawing.Point(246, 71)
        Me.btnProcesar.Name = "btnProcesar"
        Me.btnProcesar.Size = New System.Drawing.Size(120, 41)
        Me.btnProcesar.TabIndex = 18
        Me.btnProcesar.Text = "Procesar"
        Me.btnProcesar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnProcesar.UseVisualStyleBackColor = True
        '
        'RPendientesXDocumento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(371, 171)
        Me.Controls.Add(Me.AcPanelCaption1)
        Me.Controls.Add(Me.rbtnDocsCompra)
        Me.Controls.Add(Me.rbtnOrdenesCompra)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.AcFecha)
        Me.Controls.Add(Me.btnProcesar)
        Me.Name = "RPendientesXDocumento"
        Me.Text = "RPendientesXDocumento"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AcPanelCaption1 As ACControles.ACPanelCaption
    Friend WithEvents rbtnDocsCompra As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnOrdenesCompra As System.Windows.Forms.RadioButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents AcFecha As ACControles.ACFecha
    Friend WithEvents btnProcesar As System.Windows.Forms.Button
End Class
