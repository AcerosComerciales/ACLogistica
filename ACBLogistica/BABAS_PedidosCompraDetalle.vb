Imports ACDLogistica
Imports ACELogistica
Imports ACFramework
Imports DAConexion


Public Class BABAS_PedidosCompraDetalle
#Region " Variables "
	Private m_abas_pedidoscompradetalle As EABAS_PedidosCompraDetalle
	
	Private m_listABAS_PedidosCompraDetalle As List(Of EABAS_PedidosCompraDetalle)
	Private m_dtABAS_PedidosCompraDetalle As DataTable

	Private m_dsABAS_PedidosCompraDetalle As DataSet
	Private d_abas_pedidoscompradetalle As DABAS_PedidosCompraDetalle 


#End Region

#Region " Constructores "
	
	Public Sub New()
		d_abas_pedidoscompradetalle = New DABAS_PedidosCompraDetalle()
	End Sub

#End Region

#Region " Propiedades "
	
	Public Property ABAS_PedidosCompraDetalle() As EABAS_PedidosCompraDetalle 
		Get
			return m_abas_pedidoscompradetalle
		End Get
		Set(ByVal value As EABAS_PedidosCompraDetalle)
			m_abas_pedidoscompradetalle = value
		End Set
	End Property
	Public Property ListABAS_PedidosCompraDetalle() As List(Of EABAS_PedidosCompraDetalle)
		Get
			return m_listABAS_PedidosCompraDetalle
		End Get
		Set(ByVal value As List(Of EABAS_PedidosCompraDetalle))
			m_listABAS_PedidosCompraDetalle = value
		End Set
	End Property
	Public Property DTABAS_PedidosCompraDetalle() As DataTable
		Get
			return m_dtABAS_PedidosCompraDetalle
		End Get
		Set(ByVal value As DataTable)
			m_dtABAS_PedidosCompraDetalle = value
		End Set
	End Property
	Public Property DSABAS_PedidosCompraDetalle() As DataSet
		Get
			return m_dsABAS_PedidosCompraDetalle
		End Get
		Set(ByVal value As DataSet)
			m_dsABAS_PedidosCompraDetalle = value
		End Set
	End Property

#End Region

#Region " Funciones para obtencion de datos "
	

		Public Function getListABAS_PedidosCompraDetalle() As List(Of EABAS_PedidosCompraDetalle)
			Return Me.m_listABAS_PedidosCompraDetalle
		End Function
		Public Sub setListABAS_PedidosCompraDetalle(ByVal _listabas_pedidoscompradetalle As List (Of EABAS_PedidosCompraDetalle))
			Me.m_listABAS_PedidosCompraDetalle = m_listabas_pedidoscompradetalle 
		End Sub
		Public Function getABAS_PedidosCompraDetalle() As EABAS_PedidosCompraDetalle
			Return Me.m_abas_pedidoscompradetalle
		End Function
		Public Sub setABAS_PedidosCompraDetalle(ByVal x_abas_pedidoscompradetalle As EABAS_PedidosCompraDetalle)
			Me.m_abas_pedidoscompradetalle = x_abas_pedidoscompradetalle 
		End Sub
#End Region

#Region " Metodos "
	Public Function CargarTodos(ByVal x_join As List(Of ACFramework.ACJoin), ByVal x_where As Hashtable) As Boolean
		Try
			m_listABAS_PedidosCompraDetalle = new List(Of EABAS_PedidosCompraDetalle)()
			return d_abas_pedidoscompradetalle.ABAS_PDDETSS_Todos(m_listABAS_PedidosCompraDetalle, x_join, x_where)
		Catch ex As Exception
			Throw ex
		End Try
	End Function
	'Public Function CargarTodos() As Boolean
	'	Try
	'		m_listABAS_PedidosCompraDetalle = new List(Of EABAS_PedidosCompraDetalle)()
	'		return d_abas_pedidoscompradetalle.ABAS_PDDETSS_Todos(m_listABAS_PedidosCompraDetalle)
	'	Catch ex As Exception
	'		Throw ex
	'	End Try
	'End Function

	'Public Function CargarTodos(ByVal x_where As Hashtable) As Boolean
	'	Try
	'		m_listABAS_PedidosCompraDetalle = new List(Of EABAS_PedidosCompraDetalle)()
	'		return d_abas_pedidoscompradetalle.ABAS_PDDETSS_Todos(m_listABAS_PedidosCompraDetalle, x_where)
	'	Catch ex As Exception
	'		Throw ex
	'	End Try
	'End Function

	'Public Function CargarTodos(ByVal x_join As List(Of ACFramework.ACJoin), ByVal x_where As Hashtable) As Boolean
	'	Try
	'		m_listABAS_PedidosCompraDetalle = new List(Of EABAS_PedidosCompraDetalle)()
	'		return d_abas_pedidoscompradetalle.ABAS_PDDETSS_Todos(m_listABAS_PedidosCompraDetalle, x_join, x_where)
	'	Catch ex As Exception
	'		Throw ex
	'	End Try
	'End Function

	'Public Function CargarTodos(ByVal x_join As List(Of ACFramework.ACJoin), ByVal x_where As Hashtable, ByVal x_distinct As Boolean) As Boolean
	'	Try
	'		m_listABAS_PedidosCompraDetalle = new List(Of EABAS_PedidosCompraDetalle)()
	'		return d_abas_pedidosCompradetalle.ABAS_PDDETSS_Todos(m_listABAS_PedidosCompraDetalle, x_join, x_where, x_distinct)
	'	Catch ex As Exception
	'		Throw ex
	'	End Try
	'End Function

	'Public Function CargarTodos(ByVal x_pedid_codigo As String) As Boolean
	'	Try
	'		m_listABAS_PedidosCompraDetalle = new List(Of EABAS_PedidosCompraDetalle)()
	'		Return d_abas_pedidoscompradetalle.ABAS_PDDETSS_Todos(m_listABAS_PedidosCompraDetalle, x_pedid_codigo)
	'	Catch ex As Exception
	'		Throw ex
	'	End Try
	'End Function
	'Public Function CargarTodosDS(ByVal x_where As Hashtable) As Boolean
	'	Try
	'		m_dsABAS_PedidosCompraDetalle = new DataSet()
	'		return d_abas_pedidoscompradetalle.ABAS_PDDETSS_Todos(m_dsABAS_PedidosCompraDetalle, x_where)
	'	Catch ex As Exception
	'		Throw ex
	'	End Try
	'End Function

	'Public Function CargarTodosDS(ByVal x_join As List(Of ACFramework.ACJoin), ByVal x_where As Hashtable) As Boolean
	'	Try
	'		m_dsABAS_PedidosCompraDetalle = new DataSet()
	'		return d_abas_pedidoscompradetalle.ABAS_PDDETSS_Todos(m_dsABAS_PedidosCompraDetalle, x_join, x_where)
	'	Catch ex As Exception
	'		Throw ex
	'	End Try
	'End Function

	'Public Function CargarTodosDT(ByVal x_where As Hashtable) As Boolean
	'	Try
	'		m_dsABAS_PedidosCompraDetalle = new DataSet()
	'		Dim _opcion As Boolean = d_abas_pedidoscompradetalle.ABAS_PDDETSS_Todos(m_dsABAS_PedidosCompraDetalle, x_where)
	'	If _opcion Then
	'		m_dtABAS_PedidosCompraDetalle = m_dsABAS_PedidosCompraDetalle.Tables(0)
	'		Return True
	'	Else
	'		Return False
	'	End If
	'	Catch ex As Exception
	'		Throw ex
	'	End Try
	'End Function

	'Public Function CargarTodosDT(ByVal x_join As List(Of ACFramework.ACJoin), ByVal x_where As Hashtable) As Boolean
	'	Try
	'		m_dsABAS_PedidosCompraDetalle = new DataSet()
	'		Dim _opcion As Boolean = d_abas_pedidosCompradetalle.ABAS_PDDETSS_Todos(m_dsABAS_PedidosCompraDetalle, x_join, x_where)
	'	If _opcion Then
	'		m_dtABAS_PedidosCompraDetalle = m_dsABAS_PedidosCompraDetalle.Tables(0)
	'		Return True
	'	Else
	'		Return False
	'	End If
	'	Catch ex As Exception
	'		Throw ex
	'	End Try
	'End Function

	'Public Function Cargar(ByVal x_pedid_codigo As String, x_pddet_item As Short) As Boolean
	'	Try
	'		m_abas_pedidoscompradetalle = New EABAS_PedidosCompraDetalle()
	'		Return d_abas_pedidoscompradetalle.ABAS_PDDETSS_UnReg(m_abas_pedidoscompradetalle, x_pedid_codigo, x_pddet_item)
	'	Catch ex As Exception
	'		Throw ex
	'	End Try
	'End Function
	'Public Function Cargar(ByVal x_where As Hashtable) As Boolean
	'	Try
	'		m_abas_pedidoscompradetalle = New EABAS_PedidosCompraDetalle()
	'		Return d_abas_pedidoscompradetalle.ABAS_PDDETSS_UnReg(m_abas_pedidoscompradetalle, x_where)
	'	Catch ex As Exception
	'		Throw ex
	'	End Try
	'End Function
	'Public Function Cargar(ByVal x_join As List(Of ACFramework.ACJoin), ByVal x_where As Hashtable) As Boolean
	'	Try
	'		m_abas_pedidoscompradetalle = New EABAS_PedidosCompraDetalle()
	'		Return d_abas_pedidoscompradetalle.ABAS_PDDETSS_UnReg(m_abas_pedidoscompradetalle, x_join, x_where)
	'	Catch ex As Exception
	'		Throw ex
	'	End Try
	'End Function
	'Public Function Guardar(ByVal x_usuario As String) As Boolean
	'	Try
	'		If m_abas_pedidoscompradetalle.Nuevo Then
	'			d_abas_pedidoscompradetalle.ABAS_PDDETSI_UnReg(m_abas_pedidoscompradetalle, x_usuario)
	'		ElseIf m_abas_pedidoscompradetalle.Modificado Then
	'			d_abas_pedidoscompradetalle.ABAS_PDDETSU_UnReg(m_abas_pedidoscompradetalle, x_usuario)
	'		ElseIf m_abas_pedidoscompradetalle.Eliminado Then
	'			d_abas_pedidoscompradetalle.ABAS_PDDETSD_UnReg(m_abas_pedidoscompradetalle)
	'		End If
	'		Return True
	'	Catch ex As Exception
	'		Throw ex
	'	End Try
	'End Function
	'Public Function Guardar(ByVal x_where As Hashtable, ByVal x_usuario As String) As Boolean
	'	Try
	'		If m_abas_pedidoscompradetalle.Nuevo Then
	'			d_abas_pedidoscompradetalle.ABAS_PDDETSI_UnReg(m_abas_pedidoscompradetalle, x_usuario)
	'		ElseIf m_abas_pedidoscompradetalle.Modificado Then
	'			d_abas_pedidoscompradetalle.ABAS_PDDETSU_UnReg(m_abas_pedidoscompradetalle, x_where, x_usuario)
	'		ElseIf m_abas_pedidoscompradetalle.Eliminado Then
	'			d_abas_pedidoscompradetalle.ABAS_PDDETSD_UnReg(x_where)
	'		End If
	'		Return True
	'	Catch ex As Exception
	'		Throw ex
	'	End Try
	'End Function
	'Public Function Guardar(ByVal x_where As Hashtable, ByVal x_usuario As String, ByVal x_excluir() As String, ByVal x_setfecha() As String) As Boolean
	'	Try
	'		If m_abas_pedidoscompradetalle.Nuevo Then
	'			d_abas_pedidoscompradetalle.ABAS_PDDETSI_UnReg(m_abas_pedidoscompradetalle, x_usuario, x_excluir, x_setfecha)
	'		ElseIf m_abas_pedidoscompradetalle.Modificado Then
	'			d_abas_pedidoscompradetalle.ABAS_PDDETSU_UnReg(m_abas_pedidoscompradetalle, x_where, x_usuario, x_excluir, x_setfecha)
	'		ElseIf m_abas_pedidoscompradetalle.Eliminado Then
	'			d_abas_pedidoscompradetalle.ABAS_PDDETSD_UnReg(m_abas_pedidoscompradetalle)
	'		End If
	'		Return True
	'	Catch ex As Exception
	'		Throw ex
	'	End Try
	'End Function
	'Public Function Guardar(ByVal x_where As Hashtable, ByVal x_usuario As String, ByVal x_excluir() As String, ByVal x_setfecha() As String, ByVal x_setcampos() As String) As Boolean
	'	Try
	'		If m_abas_pedidoscompradetalle.Nuevo Then
	'			d_abas_pedidoscompradetalle.ABAS_PDDETSI_UnReg(m_abas_pedidoscompradetalle, x_usuario, x_excluir, x_setfecha)
	'		ElseIf m_abas_pedidoscompradetalle.Modificado Then
	'			d_abas_pedidoscompradetalle.ABAS_PDDETSU_UnReg(m_abas_pedidoscompradetalle, x_where, x_usuario, x_excluir, x_setfecha, x_setcampos)
	'		ElseIf m_abas_pedidoscompradetalle.Eliminado Then
	'			d_abas_pedidoscompradetalle.ABAS_PDDETSD_UnReg(m_abas_pedidoscompradetalle)
	'		End If
	'		Return True
	'	Catch ex As Exception
	'		Throw ex
	'	End Try
	'End Function
	'Public Function Guardar(ByVal x_usuario As String, ByVal x_setfecha() As String) As Boolean
	'	Try
	'		If m_abas_pedidoscompradetalle.Nuevo Then
	'			d_abas_pedidoscompradetalle.ABAS_PDDETSI_UnReg(m_abas_pedidoscompradetalle, x_usuario, x_setfecha)
	'		ElseIf m_abas_pedidoscompradetalle.Modificado Then
	'			d_abas_pedidoscompradetalle.ABAS_PDDETSU_UnReg(m_abas_pedidoscompradetalle, x_usuario, x_setfecha)
	'		ElseIf m_abas_pedidoscompradetalle.Eliminado Then
	'			d_abas_pedidoscompradetalle.ABAS_PDDETSD_UnReg(m_abas_pedidoscompradetalle)
	'		End If
	'		Return True
	'	Catch ex As Exception
	'		Throw ex
	'	End Try
	'End Function
	'Public Function Guardar(ByVal x_usuario As String, ByVal x_excluir() As String, ByVal x_setfecha() As String) As Boolean
	'	Try
	'		If m_abas_pedidoscompradetalle.Nuevo Then
	'			d_abas_pedidoscompradetalle.ABAS_PDDETSI_UnReg(m_abas_pedidoscompradetalle, x_usuario, x_excluir, x_setfecha)
	'		ElseIf m_abas_pedidoscompradetalle.Eliminado Then
	'			d_abas_pedidoscompradetalle.ABAS_PDDETSD_UnReg(m_abas_pedidoscompradetalle)
	'		End If
	'		Return True
	'	Catch ex As Exception
	'		Throw ex
	'	End Try
	'End Function
	'Public Function Eliminar(ByVal x_where As Hashtable) As Boolean
	'	Try
	'		m_listABAS_PedidosCompraDetalle = new List(Of EABAS_PedidosCompraDetalle)()
	'		return d_abas_pedidoscompradetalle.ABAS_PDDETSD_UnReg(x_where) > 0
	'	Catch ex As Exception
	'		Throw ex
	'	End Try
	'End Function

	'Public Function getCorrelativo(ByVal x_campo As String) As Integer
	'	Try
	'		Return d_abas_pedidoscompradetalle.getCorrelativo(x_campo) + 1 
	'	Catch ex As Exception
	'		Throw ex
	'	End Try
	'End Function
	'Public Function getCorrelativo(ByRef x_id As Integer, ByVal x_campo As String) As Integer
	'	Try
	'		x_id = d_abas_pedidoscompradetalle.getCorrelativo(x_campo)
	'		Return (x_id + 1)
	'	Catch ex As Exception
	'		Throw ex
	'	End Try
	'End Function
	'Public Function getCorrelativo(ByVal x_campo As String, ByVal x_where As Hashtable) As Integer
	'	Try
	'		Return d_abas_pedidoscompradetalle.getCorrelativo(x_campo, x_where) + 1 
	'	Catch ex As Exception
	'		Throw ex
	'	End Try
	'End Function
	'Public Function getCorrelativo(ByRef x_id As Integer, ByVal x_campo As String, ByVal x_where As Hashtable) As Integer
	'	Try
	'		x_id = d_abas_pedidoscompradetalle.getCorrelativo(x_campo, x_where)
	'		Return (x_id + 1)
	'	Catch ex As Exception
	'		Throw ex
	'	End Try
	'End Function
    Public Function Guardar(ByVal x_usuario As String) As Boolean
		Try
			If m_abas_pedidoscompradetalle.Nuevo Then
				d_abas_pedidoscompradetalle.ABAS_PDDETSI_UnReg(m_abas_pedidoscompradetalle, x_usuario)
			ElseIf m_abas_pedidoscompradetalle.Modificado Then
				d_abas_pedidoscompradetalle.ABAS_PDDETSU_UnReg(m_abas_pedidoscompradetalle, x_usuario)
			ElseIf m_abas_pedidoscompradetalle.Eliminado Then
				d_abas_pedidoscompradetalle.ABAS_PDDETSD_UnReg(m_abas_pedidoscompradetalle)
			End If
			Return True
		Catch ex As Exception
			Throw ex
		End Try
	End Function
    Public Function Eliminar(ByVal x_where As Hashtable) As Boolean
		Try
			m_listABAS_PedidosCompraDetalle = new List(Of EABAS_PedidosCompraDetalle)()
			return d_abas_pedidoscompradetalle.ABAS_PDDETSD_UnReg(x_where) > 0
		Catch ex As Exception
			Throw ex
		End Try
	End Function
#End Region

 
End Class

