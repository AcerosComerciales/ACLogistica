Public Class RPendientesXDocumento
#Region " Variables "


#End Region

#Region " Propiedades "

#End Region

#Region " Constructores "
    Public Sub New(ByVal x_icono As System.Drawing.Bitmap)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        AcFecha.ACDtpFecha_A.Value = Date.Now
        AcFecha.ACDtpFecha_De.Value = Date.Now
        If Not IsNothing(x_icono) Then Me.Icon = Icon.FromHandle(x_icono.GetHicon)
    End Sub
#End Region

#Region " Metodos "
    Private Function GetTipoReporte() As Reporte.TReportePendienteCompras
        If rbtnOrdenesCompra.Checked Then
            Return Reporte.TReportePendienteCompras.PendienteOrdenesCompra
        ElseIf rbtnDocsCompra.Checked Then
            Return Reporte.TReportePendienteCompras.PendienteDocsCompra


        Else
            Return Reporte.TReportePendienteCompras.PendienteDocsCompra
        End If
    End Function
#End Region

#Region " Metodos de Controles"
    Private Sub btnProcesar_Click(sender As Object, e As EventArgs) Handles btnProcesar.Click
        Try
            Dim _reporte As New Reporte()
            If Not _reporte.RReportePendientesCompras(AcFecha.ACFecha_De.Value.Date, AcFecha.ACFecha_A.Value.Date, False, GetTipoReporte()) Then
                ACControles.ACDialogos.ACMostrarMensajeInformacion(String.Format("Información: {0}", Me.Text), "No se puede cargar el reporte, posiblemento no haya datos que mostrar")
            End If
        Catch ex As Exception
            ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), Colecciones.getError("00000"), ex)
        End Try
    End Sub

    Private Sub AcFecha_ACFecIni_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles AcFecha.ACFecIni_KeyDown
        If e.KeyData = Keys.Enter Then
            AcFecha.ACDtpFecha_A.Focus()
        End If
    End Sub

    Private Sub AcFecha_ACFecFin_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles AcFecha.ACFecFin_KeyDown
        If e.KeyData = Keys.Enter Then
            btnProcesar_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
#End Region

End Class