Imports System.Threading
Imports System.IO
Imports ACEVentas

Public Class Constantes
   Private Shared mInstance As Constantes = Nothing
   Private Shared mMutex As New System.Threading.Mutex

   Public Shared Function Initialize() As Constantes
      mMutex.WaitOne()
      If mInstance Is Nothing Then
         mInstance = New Constantes
      End If
      mMutex.ReleaseMutex()
      Return mInstance
   End Function

#Region " Enumeradores "
   Enum Seteo
      Activar
      Desactivar
   End Enum
     Enum Estado
      Ingresado
      Anulado
      Eliminado
      Confirmado
      Activo
      Terminado
   End Enum
     Public Shared Function getEstado(ByVal x_opcion As Estado)
      Select Case x_opcion
         Case Estado.Anulado
            Return "X"
         Case Estado.Confirmado
            Return "C"
         Case Estado.Eliminado
            Return "E"
         Case Estado.Ingresado
            Return "I"
         Case Estado.Activo
            Return "A"
        Case Estado.Terminado
            Return "T"
         Case Else
            Return "I"
      End Select
   End Function
#End Region

#Region " Estados "

   Public Enum MyTipos
      Tipos
      MarcasNeumaticos
      Sexo
      DocumentoIndentidad
      TipoNeumatico
      EstadoCivil
      TipoMoneda
      TipoDocumento
      TipoGasto
      TipoUnidad
      TipoPago
      ModoPago
      MarcasRanflas
      RelacionEntidades
      MarcasVehiculos
      TipoVehiculos
      TipoCombustible
      TipoMantenimiento
      TipoPieza
      TipoAlmacen
      TipoIncidencia
      TipoDocumentoInterno
      TipoOrigenDestino
   End Enum

   Public Enum EstadoDocVta
      Ingresado
      Confirmado
      Anulado
      Extornado
      Gestionado
   End Enum

   Public Enum EstadoViajes
      Ingresado
      Confirmado
      Anulado
   End Enum

   ''' <summary>
   ''' Estado de documentos de venta
   ''' </summary>
   ''' <param name="Estado"></param>
   ''' <returns></returns>
   ''' <remarks></remarks>
   Public Shared Function getEstado(ByVal Estado As EstadoDocVta) As String
      Select Case Estado
         Case EstadoDocVta.Ingresado : Return "I"
         Case EstadoDocVta.Confirmado : Return "C"
         Case EstadoDocVta.Anulado : Return "X"
         Case EstadoDocVta.Extornado : Return "T"
         Case Else : Return "I"
      End Select
   End Function

   ''' <summary>
   ''' Estados de Viajes
   ''' </summary>
   ''' <param name="Estado"></param>
   ''' <returns></returns>
   ''' <remarks></remarks>
   Public Shared Function getEstado(ByVal Estado As EstadoViajes) As String
      Select Case Estado
         Case EstadoViajes.Ingresado : Return "I"
         Case EstadoViajes.Confirmado : Return "C"
         Case EstadoViajes.Anulado : Return "X"
         Case Else : Return "I"
      End Select
   End Function

#End Region

#Region " Para la tabla tipos "
   Public Shared ReadOnly Property getCodTipo(ByVal x_opcion As MyTipos)
      Get
         Select Case x_opcion
            Case MyTipos.Tipos
               Return "TIP"
            Case MyTipos.MarcasNeumaticos
               Return "MAN"
            Case MyTipos.Sexo
               Return "SEX"
            Case MyTipos.DocumentoIndentidad
               Return "DID"
            Case MyTipos.EstadoCivil
               Return "ECV"
            Case MyTipos.MarcasRanflas
               Return "MAR"
            Case MyTipos.MarcasVehiculos
               Return "MAV"
            Case MyTipos.ModoPago
               Return "MPG"
            Case MyTipos.RelacionEntidades
               Return "REE"
            Case MyTipos.TipoAlmacen
               Return "ALM"
            Case MyTipos.TipoMantenimiento
               Return "MNT"
            Case MyTipos.TipoPieza
               Return "TPZ"
            Case MyTipos.TipoCombustible
               Return "CMB"
            Case MyTipos.TipoDocumento
               Return "TDO"
            Case MyTipos.TipoGasto
               Return "GTO"
            Case MyTipos.TipoMoneda
               Return "MND"
            Case MyTipos.TipoNeumatico
               Return "NEU"
            Case MyTipos.TipoPago
               Return "PGO"
            Case MyTipos.TipoUnidad
               Return "UND"
            Case MyTipos.TipoVehiculos
               Return "VEH"
            Case MyTipos.TipoIncidencia
               Return "INC"
            Case MyTipos.TipoDocumentoInterno
               Return "TDI"
            Case MyTipos.TipoOrigenDestino
               Return "TOD"
            Case Else
               Return "MAN"
         End Select
      End Get
   End Property

#End Region

#Region " Tipo de Entidad "
   Public Shared ReadOnly Property PersonaNatural() As String
      Get
         Return "N"
      End Get
   End Property

   Public Shared ReadOnly Property PersonaJuridica() As String
      Get
         Return "J"
      End Get
   End Property
#End Region

#Region " Procesos "

   Enum TipoProcesos
      ModificarPedido
      ValueTwo
   End Enum

   Public Shared ReadOnly Property getProceso(ByVal x_opcion As TipoProcesos)
      Get
         Select Case x_opcion
            Case TipoProcesos.ModificarPedido
               Return "MPEDI"
            Case 2
               Return ""
            Case Else
               Return ""
         End Select
      End Get
   End Property


#End Region

#Region " Constantes para entidades "
   Public Shared ReadOnly Property LongitudCodigo() As Integer
      Get
         Return 11
      End Get
   End Property
#End Region


#Region " Monedas "
   Public Shared ReadOnly Property Moneda(ByVal x_tipo As ETipos.TipoMoneda) As String
      Get
         Select Case x_tipo
            Case ETipos.TipoMoneda.Soles
               Return "S/."
            Case ETipos.TipoMoneda.Dolares
               Return "$"
            Case Else
               Return "S/."
         End Select
      End Get
   End Property

#End Region

#Region " Otros Formatos "

    Public Shared ReadOnly Property Formatofecha() As String
        Get
            Return "dd/MM/yyyy"
        End Get
    End Property

#End Region


End Class