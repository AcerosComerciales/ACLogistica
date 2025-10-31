Imports System
Imports System.Data
Imports System.Data.Common
Imports System.Collections.Generic
Partial Public Class EABAS_PedidosCompra
      
    #Region " Variables "
   Private m_listDetPedidosCompra As List(Of EABAS_PedidosCompraDetalle)

    #end Region
     Enum TipoPedido
     PC
   End Enum
     Enum Estado
      Ingresado
      Anulado
      Eliminado
      Confirmado
      Rehusado
      Nuevo
   End Enum

    #Region " Propiedades "
  

  
      Public Property ListDetPedidosCompra() As List(Of EABAS_PedidosCompraDetalle)
      Get
         Return m_listDetPedidosCompra
      End Get
      Set(ByVal value As List(Of EABAS_PedidosCompraDetalle))
         m_listDetPedidosCompra = value
      End Set
   End Property
    #End Region
#Region " Metodos "
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
         Case Estado.Rehusado
            Return "R"
         Case Estado.Nuevo
            Return "N"
         Case Else
            Return "I"
      End Select

   End Function


     Public ReadOnly Property PEDID_Estado_Text() As String
      Get
         Select Case m_pedid_estado
            Case getEstado(Estado.Ingresado)
               Return Estado.Ingresado.ToString()
            Case getEstado(Estado.Anulado)
               Return Estado.Anulado.ToString()
            Case getEstado(Estado.Confirmado)
               Return Estado.Confirmado.ToString()
            Case getEstado(Estado.Eliminado)
               Return Estado.Eliminado.ToString()
            Case getEstado(Estado.Rehusado)
               Return Estado.Rehusado.ToString()
            Case getEstado(Estado.Nuevo)
               Return Estado.Nuevo.ToString()
            Case Else
               Return Estado.Ingresado.ToString()
         End Select
      End Get
   End Property
#End Region

End Class

