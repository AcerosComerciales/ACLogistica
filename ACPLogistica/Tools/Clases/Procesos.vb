Public Class Procesos
#Region " Variables "

#End Region

#Region " Propiedades "

   Enum TipoProcesos
      AdmVen_AnularFacturasFecAnterior
      AdmVen_AnularFacturasMismoDia
      AdmVen_EliminarFacturas
      AdmVen_ImprimirFactura
      AdmVen_ModVentasAPendienteEntrega
      AdmVen_ModVendedor
      AdmVen_ModFechaFactura
      AdmVen_BuscarDocVtaPtosVnta
Desp_AnularGuiasTrasSalMismoDia
        Desp_AnularGuiasTrasSalPosteriores
        AdmVenLog_PermiteDevolverStock
        Desp_EliGuiaRemSalTralado
      ControlLog_CrearArreglo
      ControlLog_AnularArreglo
      ControlLog_AnularArregloPosterior
        Abastecimientos_AnularCotizacionCompra
        Abastecimientos_AnularOrdenCompra
        ControlLog_IngresarMercaderiaManual
    End Enum
#End Region

#Region " Constructores "

#End Region

#Region " Metodos "


   Public Shared ReadOnly Property getProceso(ByVal x_opcion As TipoProcesos)
      Get
         Select Case x_opcion
            Case TipoProcesos.AdmVen_ModVentasAPendienteEntrega
               Return "VPMPV"
            Case TipoProcesos.AdmVen_ModVendedor
               Return "VPMVE"
            Case TipoProcesos.AdmVen_ModFechaFactura
               Return "ACFEF"
            Case TipoProcesos.AdmVen_AnularFacturasMismoDia
               Return "XFACD"
            Case TipoProcesos.AdmVen_ImprimirFactura
               Return "XFPRI"
            Case TipoProcesos.AdmVen_BuscarDocVtaPtosVnta
                    Return "PBDVT"
                Case TipoProcesos.Desp_AnularGuiasTrasSalMismoDia
                    Return "PXGTS"
                Case TipoProcesos.Desp_AnularGuiasTrasSalPosteriores
                    Return "XGTSP"
                Case TipoProcesos.Desp_EliGuiaRemSalTralado
                    Return "DPEGS"
            Case TipoProcesos.AdmVenLog_PermiteDevolverStock
               Return "PDSKG"
            Case TipoProcesos.ControlLog_CrearArreglo
               Return "CPCAR"
            Case TipoProcesos.ControlLog_AnularArreglo
               Return "CPCXR"
            Case TipoProcesos.ControlLog_AnularArregloPosterior
               Return "CPCXF"
              Case TipoProcesos.Abastecimientos_AnularCotizacionCompra
               Return "LAACC"
             Case TipoProcesos.Abastecimientos_AnularOrdenCompra
                    Return "LAAOC"
                Case TipoProcesos.ControlLog_IngresarMercaderiaManual
                    Return "CLIMM"
                Case Else
               Return ""
         End Select
      End Get
   End Property

#End Region

#Region " Metodos de Controles"

#End Region
End Class
