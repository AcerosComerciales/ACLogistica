Imports ACEVentas

Public Class EABAS_PedidosCompraDetalle

    #Region " Variables "
     Private m_artic_descripcion As String
       Private m_articulo As EArticulos
    Private m_artic_peso As Decimal
    #End Region
    #Region " Propiedades "
    Public Property ARTIC_Descripcion() As String
      Get
         Return m_artic_descripcion
      End Get
      Set(ByVal value As String)
         If Not IsNothing(m_artic_descripcion) Then
            If Not m_artic_descripcion.Equals(value) Then
               m_artic_descripcion = value
            End If
         Else
            m_artic_descripcion = value
         End If
      End Set
   End Property
     Public Property Articulo() As EArticulos
      Get
         Return m_articulo
      End Get
      Set(ByVal value As EArticulos)
         m_articulo = value
      End Set
   End Property
    Public Property ARTIC_Peso() As Decimal
      Get
         Return m_artic_peso
      End Get
      Set(ByVal value As Decimal)
         m_artic_peso = value
      End Set
   End Property
       #End Region
End Class
