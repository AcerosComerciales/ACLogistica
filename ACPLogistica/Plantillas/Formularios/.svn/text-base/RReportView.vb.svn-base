Imports ACBLogistica
Imports ACBVentas
Imports ACELogistica
Imports ACEVentas
Imports ACFramework

Imports Microsoft.Practices.Unity
Imports C1.Win.C1FlexGrid
Imports CrystalDecisions.CrystalReports.Engine


Public Class RReportView

   Public Sub New(ByVal dtDatos As ReportDocument)

      ' This call is required by the designer.
      InitializeComponent()

      ' Add any initialization after the InitializeComponent() call.
      Try
         crvReporte.ReportSource = dtDatos
         crvReporte.Zoom(100)

      Catch ex As Exception

      End Try
   End Sub

   Sub New(ByVal dtDatos As CROrdenCompra)
      ' This call is required by the Windows Form Designer.
      InitializeComponent()
      ' Add any initialization after the InitializeComponent() call.
      Try
         crvReporte.ReportSource = dtDatos
      Catch ex As Exception

      End Try
   End Sub

   Sub New(ByVal dtDatos As CRCotizCompra)
      ' This call is required by the Windows Form Designer.
      InitializeComponent()
      ' Add any initialization after the InitializeComponent() call.
      Try
         crvReporte.ReportSource = dtDatos
      Catch ex As Exception
         Throw ex
      End Try
   End Sub

   Private Sub ReportView_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

   End Sub
End Class