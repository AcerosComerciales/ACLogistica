Imports ACDLogistica
Imports ACELogistica
Imports ACEVentas
Imports ACFramework


Public Class BABAS_PedidosCompra
#Region " Variables "
	
	Private m_eabas_pedidoscompra As EABAS_PedidosCompra
	Private m_listABAS_PedidosCompra As List(Of EaBAS_PedidosCompra)
	Private m_dtABAS_PedidosCompra As DataTable

	Private m_dsABAS_PedidosCompra As DataSet
	Private d_abas_pedidoscompra As DABAS_PedidosCompra


#End Region
    #Region " Constructores "
	
	Public Sub New()
		d_abas_pedidoscompra = New DABAS_PedidosCompra()
	End Sub

#End Region
#Region " Propiedades "
	
	Public Property ABAS_PedidosCompra() As EABAS_PedidosCompra
		Get
			return m_eabas_pedidoscompra
		End Get
		Set(ByVal value As EABAS_PedidosCompra)
			m_eabas_pedidoscompra = value
		End Set
	End Property
    Public Property ListABAS_PedidosCompra() As List(Of EABAS_PedidosCompra)
		Get
			return m_listABAS_PedidosCompra
		End Get
		Set(ByVal value As List(Of EABAS_PedidosCompra))
			m_listABAS_PedidosCompra = value
		End Set
	End Property
#End Region
    Public Function Cargar(ByVal x_pedid_codigo As String) As Boolean
		Try
			m_eabas_pedidoscompra = New EABAS_PedidosCompra()
			Return d_abas_pedidoscompra.ABAS_PEDIDSS_UnReg(m_eabas_pedidoscompra, x_pedid_codigo)
		Catch ex As Exception
			Throw ex
		End Try
	End Function
    	Public Function Cargar(ByVal x_where As Hashtable) As Boolean
		Try
			m_eabas_pedidoscompra = New EABAS_PedidosCompra()
			Return d_abas_pedidoscompra.ABAS_PEDIDSS_UnReg(m_eabas_pedidoscompra, x_where)
		Catch ex As Exception
			Throw ex
		End Try
	End Function
    Public Function Cargar(ByVal x_join As List(Of ACFramework.ACJoin), ByVal x_where As Hashtable) As Boolean
		Try
			m_eabas_pedidoscompra = New EABAS_PedidosCompra()
			Return d_abas_pedidoscompra.ABAS_PEDIDSS_UnReg(m_eabas_pedidoscompra, x_join, x_where)
		Catch ex As Exception
			Throw ex
		End Try
	End Function
    
   ''' <summary>
   ''' Realiza la carga del documento con su respectivo detalle
   ''' </summary>
   ''' <param name="x_pedidco_codigo">Codigo de cotización</param>
   ''' <param name="x_detalle">Opción para cargar el detalle</param>
   ''' <returns></returns>
   ''' <remarks></remarks>
   Public Function Cargar(ByVal x_pedidco_codigo As String, ByVal x_detalle As Boolean) As Boolean
      Try
         'Dim _join As New List(Of ACJoin)
         '_join.Add(New ACJoin(EEntidades.Esquema, EEntidades.Tabla, "Ent", ACJoin.TipoJoin.Inner _
         '                   , New ACCampos() {New ACCampos("ENTID_Codigo", "ENTID_CodigoProveedor")} _
         '                   , New ACCampos() {New ACCampos("ENTID_RazonSocial", "ENTID_Proveedor") _
         '                                   , New ACCampos("ENTID_Codigo", "ENTID_CodigoProveedor") _
         '                                   , New ACCampos("ENTID_NroDocumento", "ENTID_NroDocumento") _
         '                                   , New ACCampos("ENTID_Direccion", "ENTID_Direccion") _
         '                                   , New ACCampos("ENTID_Telefono1", "ENTID_Telefono") _
         '                                   , New ACCampos("ENTID_EMail", "ENTID_Correo")}))
         Dim _where As New Hashtable()
         _where.Add("PEDID_Codigo", New ACWhere(x_pedidco_codigo, ACWhere.TipoWhere.Igual))
         If Cargar( _where) Then' If Cargar(_join, _where) Then
            If x_detalle Then
               Dim m_babas_pedidoscompradetalle As New BABAS_PedidosCompraDetalle
               Dim _joinDet As New List(Of ACJoin)
               _joinDet.Add(New ACJoin(EArticulos.Esquema, EArticulos.Tabla, "Art", ACJoin.TipoJoin.Inner _
                                  , New ACCampos() {New ACCampos("ARTIC_Codigo", "ARTIC_Codigo")} _
                                  , New ACCampos() {New ACCampos("ARTIC_Descripcion", "ARTIC_Descripcion") _
                                                    , New ACCampos("ARTIC_Id", "ARTIC_Id")}))
                _joinDet.Add(New ACJoin(ETipos.Esquema, ETipos.Tabla, "Uni", "Art", ACJoin.TipoJoin.Inner _
                            , New ACCampos() {New ACCampos("TIPOS_Codigo", "TIPOS_CodUnidadMedida")} _
                            , New ACCampos() {New ACCampos("TIPOS_Descripcion", "TIPOS_Descripcion"), _
                                              New ACCampos("TIPOS_DescCorta", "TIPOS_UnidadMedida")}))
               Dim _whereDet As New Hashtable()
               _whereDet.Add("PEDID_Codigo", New ACWhere(x_pedidco_codigo, ACWhere.TipoWhere.Igual))
               m_babas_pedidoscompradetalle.CargarTodos(_joinDet, _whereDet)
               m_eabas_pedidoscompra.ListDetPedidosCompra = New List(Of EABAS_PedidosCompraDetalle)(m_babas_pedidoscompradetalle.ListABAS_PedidosCompraDetalle)
            End If
            Return True
         Else
            Return False
         End If
      Catch ex As Exception
         Throw ex
      End Try
   End Function

    #Region " Metodos "

   ''' <summary> 
   ''' Capa de Negocio: VENT_PEDIDSS_BusPedidoReposicion
   ''' </summary>
   ''' <param name="x_fecini">Parametro 1: </param> 
   ''' <param name="x_fecfin">Parametro 2: </param> 
   ''' <param name="x_zonas_codigo">Parametro 3: </param> 
   ''' <param name="x_pvent_id">Parametro 4: </param> 
   ''' <param name="x_pvent_iddestino">Parametro 5: </param> 
   ''' <param name="x_sucur_id">Parametro 6: </param> 
   ''' <param name="x_pedid_tipo">Parametro 7: </param> 
   ''' <param name="x_opcion">Parametro 8: </param> 
   ''' <param name="x_cadena">Parametro 9: </param> 
   ''' <param name="x_todos">Parametro 10: </param> 
   ''' <returns></returns> 
   ''' <remarks></remarks> 
   Public Function BusquedaPedidoCompra(ByVal x_cadena As String, ByVal x_campo As Short, ByVal x_todos As Boolean,ByVal x_fecini As DateTime, ByVal x_fecfin As DateTime _
                         , ByVal x_zonas_codigo As String, ByVal x_sucur_id As Short) As Boolean
      m_listABAS_PedidosCompra = New List(Of EABAS_PedidosCompra)
      Try
         
            Return d_abas_pedidoscompra.ABAS_PEDIDSS_ConsPedidoCompra(m_listABAS_PedidosCompra, x_fecini, x_fecfin, x_zonas_codigo,  x_sucur_id,  x_campo, x_cadena, x_todos)
        
      Catch ex As Exception
         Throw ex
      End Try
   End Function
    Public Function getCorrelativo(ByVal x_campo As String, ByVal x_where As Hashtable) As Integer
		Try
			Return d_abas_pedidoscompra.getCorrelativo(x_campo, x_where) + 1 
		Catch ex As Exception
			Throw ex
		End Try
	End Function
    Public Function getCorrelativo(ByVal x_campo As String) As Integer
		Try
			Return d_abas_pedidoscompra.getCorrelativo(x_campo) + 1 
		Catch ex As Exception
			Throw ex
		End Try
	End Function
    Public Function Guardar(ByVal x_usuario As String) As Boolean
		Try
			If m_eabas_pedidoscompra.Nuevo Then
				d_abas_pedidoscompra.ABAS_PEDIDSI_UnReg(m_eabas_pedidoscompra, x_usuario)
			ElseIf m_eabas_pedidoscompra.Modificado Then
				d_abas_pedidoscompra.ABAS_PEDIDSU_UnReg(m_eabas_pedidoscompra, x_usuario)
			ElseIf m_eabas_pedidoscompra.Eliminado Then
				d_abas_pedidoscompra.ABAS_PEDIDSD_UnReg(ABAS_PedidosCompra)
			End If
			Return True
		Catch ex As Exception
			Throw ex
		End Try
	End Function
    #End Region

End Class
