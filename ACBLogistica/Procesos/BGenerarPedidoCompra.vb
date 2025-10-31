Imports ACBVentas
Imports ACDLogistica
Imports ACELogistica
Imports ACEVentas
Imports ACFramework
Imports DAConexion

Public Class BGenerarPedidoCompra
#Region " Variables "
    Private m_dtGenerarCotizacion As DataTable

    Private ds_generarcotizacion As DataSet

    Private d_generarpedidocompra As DGenerarPedidoCompra


    Private m_eabas_pedidoscompra As EABAS_PedidosCompra
    ' Private m_evendedor As EEntidades


    Private m_listABAS_PedidosCompra As List(Of EABAS_PedidosCompra)

    'Private d_vent_pventdocumento As DVENT_PVentDocumento
    'Private m_listVENT_PVentDocumento As List(Of EVENT_PVentDocumento)


    Private m_periodo As String
#End Region
#Region " Constructores "
    Public Sub New(ByVal x_periodo As String)
        d_generarpedidocompra = New DGenerarPedidoCompra()
        m_periodo = x_periodo
    End Sub
#End Region
#Region " Propiedades "
    Public Property ABAS_PedidosCompra() As EABAS_PedidosCompra
        Get
            Return m_eabas_pedidoscompra
        End Get
        Set(ByVal value As EABAS_PedidosCompra)
            m_eabas_pedidoscompra = value
        End Set
    End Property
    
   Public Property ListABAS_PedidosCompra() As List(Of EABAS_PedidosCompra)
      Get
         Return m_listABAS_PedidosCompra
      End Get
      Set(ByVal value As List(Of EABAS_PedidosCompra))
         m_listABAS_PedidosCompra = value
      End Set
   End Property
   
  
#End Region
#Region " Metodos "
 
    ''' <summary>
   ''' Anular pedido de reposicion, con su respectiva separacion de stocks
   ''' </summary>
   ''' <param name="x_codigo">codigo del pedido</param>
   ''' <param name="x_usuario">codigo del usuario</param>
   ''' <returns>devuelve el valor verdadero si se carga datos de la consulta ejecutada</returns>
   ''' <remarks></remarks>
   Public Function AnularPedidoReposicion(ByVal x_codigo As String, ByVal x_usuario As String) As Boolean
      Dim m_babas_pedidoscompra As New BABAS_PedidosCompra
      m_babas_pedidoscompra.ABAS_PedidosCompra = New EABAS_PedidosCompra
      Try
         DAEnterprise.BeginTransaction()
         m_babas_pedidoscompra.ABAS_PedidosCompra.Instanciar(ACEInstancia.Modificado)
         m_babas_pedidoscompra.ABAS_PedidosCompra.PEDID_Codigo = x_codigo
         m_babas_pedidoscompra.ABAS_PedidosCompra.PEDID_Estado = EABAS_PedidosCompra.getEstado(EABAS_PedidosCompra.Estado.Anulado)
         If m_babas_pedidoscompra.Guardar(x_usuario) Then
            DAEnterprise.CommitTransaction()
            Return True
         Else
            Throw New Exception("No se pudo anular el pedido de Reposicion")
         End If
      Catch ex As Exception
         DAEnterprise.RollBackTransaction()
         Throw ex
      End Try
   End Function
    ''' <summary>
    ''' Grabar un pedido de reposicioncon su respectivo detalle
    ''' </summary>
    ''' <param name="x_usuario">Codigo de usuario</param>
    ''' <param name="x_zonas_codigo">Codigo de la zona</param>
    ''' <param name="x_sucur_id">Codigo de la sucursal</param>
    ''' <param name="x_pvent_id">Codigo del punto de venta</param>
    ''' <param name="x_almac_id">Codigo del almacen</param>
    ''' <param name="x_msg">Mensaje devuelto en caso de existir algun error o limitacion de usuario</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GrabarPedidoCompra(ByVal x_usuario As String,   ByRef x_msg As String) As Boolean
       
           Try
         '' Inicializar Clase Negocio 
         Dim m_bABAS_PedidosCompra As New BABAS_PedidosCompra() With {.ABAS_PedidosCompra = m_eabas_pedidoscompra}
         m_bABAS_PedidosCompra.ABAS_PedidosCompra.PEDID_Id = m_bABAS_PedidosCompra.getCorrelativo("PEDID_Id")
         '' Iniciar transaccion
         DAEnterprise.BeginTransaction()
         If m_bABAS_PedidosCompra.Guardar(x_usuario) Then
            Dim i As Integer = 1
            '' Eliminar todo el detalle en caso de que existan
            Dim m_detalle As New BABAS_PedidosCompraDetalle()
            Dim x_where As New Hashtable() : x_where.Add("PEDID_Codigo", New ACWhere(m_eabas_pedidoscompra.PEDID_Codigo))
            m_detalle.Eliminar(x_where)

            '' Grabar los detalles
            For Each Item As EABAS_PedidosCompraDetalle In m_bABAS_PedidosCompra.ABAS_PedidosCompra.ListDetPedidosCompra
               Item.PEDID_Codigo = m_bABAS_PedidosCompra.ABAS_PedidosCompra.PEDID_Codigo
                    Item.ZONAS_Codigo=m_bABAS_PedidosCompra.ABAS_PedidosCompra.ZONAS_Codigo
               Item.PDDET_Item = i
               Item.Instanciar(ACEInstancia.Nuevo)

               i += 1
               Dim m_babas_pedidocompradetalle As New BABAS_PedidosCompraDetalle() With {.ABAS_PedidosCompraDetalle = Item}
               m_babas_pedidocompradetalle.Guardar(x_usuario)
            Next
         Else
            DAEnterprise.RollBackTransaction()
            x_msg &= String.Format("- No se completo el grabado de la cabecera del pedido{0}", vbNewLine)
            Return False
         End If
        
       
         '' Culminar la transaccion
         DAEnterprise.CommitTransaction()
         Return True
      Catch ex As Exception
         '' Deshacer la transaccion en caso de que surja un error ed
         DAEnterprise.RollBackTransaction()
         Throw ex
      End Try
    End Function
      ''' <summary>
   ''' cargar pedido con su detalle
   ''' </summary>
   ''' <param name="x_pedid_codigo"></param>
   ''' <param name="x_detalle"></param>
   ''' <returns></returns>
   ''' <remarks></remarks>
   Public Function Cargar(ByVal x_pedid_codigo As String, ByVal x_detalle As Boolean) As Boolean
      Try
         Dim _join As New List(Of ACJoin)
         _join.Add(New ACJoin(EEntidades.Esquema, EEntidades.Tabla, "Ent", ACJoin.TipoJoin.Inner _
                            , New ACCampos() {New ACCampos("ENTID_Codigo", "PEDID_UsrCrea")} _
                            , New ACCampos() {New ACCampos("ENTID_RazonSocial", "Usuario") _
                                            , New ACCampos("ENTID_PtrNombre1", "PrtNombre")}))
         Dim _where As New Hashtable()
         _where.Add("PEDID_Codigo", New ACWhere(x_pedid_codigo, ACWhere.TipoWhere.Igual))

         Dim m_babas_pedidoscompra As New BABAS_PedidosCompra()
         If m_babas_pedidoscompra.Cargar(_join, _where) Then
            m_eabas_pedidoscompra = m_babas_pedidoscompra.ABAS_PedidosCompra
           ' m_eabas_pedidoscompra.Cotizador = m_eabas_pedidoscompra.Usuario.Substring(m_event_pedidos.PrtNombre)
            If x_detalle Then
               Dim m_babas_pedidoscompradetalle As New BABAS_PedidosCompraDetalle
               Dim _joinDet As New List(Of ACJoin)
               _joinDet.Add(New ACJoin("dbo", "Articulos", "Art", ACJoin.TipoJoin.Inner _
                                  , New ACCampos() {New ACCampos("ARTIC_Codigo", "ARTIC_Codigo")} _
                                  , New ACCampos() {New ACCampos("ARTIC_Descripcion", "ARTIC_Descripcion"), _
                                                    New ACCampos("ARTIC_Codigo", "ARTIC_Codigo"), _
                                                    New ACCampos("ARTIC_Peso", "ARTIC_Peso"), _
                                                    New ACCampos("ARTIC_Percepcion", "ARTIC_Percepcion"), _
                                                    New ACCampos("TIPOS_CodUnidadMedida", "TIPOS_CodUnidadMedida")}))
                ''New ACCampos("ARTIC_Peso", "PDDET_PesoUnitario"), _
               _joinDet.Add(New ACJoin(ETipos.Esquema, ETipos.Tabla, "Uni", "Art", ACJoin.TipoJoin.Inner _
                            , New ACCampos() {New ACCampos("TIPOS_Codigo", "TIPOS_CodUnidadMedida")} _
                            , New ACCampos() {New ACCampos("TIPOS_Descripcion", "TIPOS_Descripcion"), _
                                              New ACCampos("TIPOS_DescCorta", "TIPOS_UnidadMedida")}))
               _joinDet.Add(New ACJoin(EAlmacenes.Esquema, EAlmacenes.Tabla, "Alm", ACJoin.TipoJoin.Inner _
                            , New ACCampos() {New ACCampos("ALMAC_Id", "ALMAC_Id")} _
                            , New ACCampos() {New ACCampos("ALMAC_Descripcion", "ALMAC_Descripcion")}))
               Dim _whereDet As New Hashtable()
               _whereDet.Add("PEDID_Codigo", New ACWhere(x_pedid_codigo, ACWhere.TipoWhere.Igual))

               m_babas_pedidoscompradetalle.CargarTodos(_joinDet, _whereDet)
               m_eabas_pedidoscompra.ListDetPedidosCompra = New List(Of EABAS_PedidosCompraDetalle)(m_babas_pedidoscompradetalle.ListABAS_PedidosCompraDetalle)
               For Each item As EABAS_PedidosCompraDetalle In m_eabas_pedidoscompra.ListDetPedidosCompra
                  item.ARTIC_Peso = item.PDDET_Cantidad * item.ARTIC_Peso
               Next

            End If
            Return True
         Else
            Return False
         End If
      Catch ex As Exception
         Throw ex
      End Try

   End Function
#End Region
End Class
