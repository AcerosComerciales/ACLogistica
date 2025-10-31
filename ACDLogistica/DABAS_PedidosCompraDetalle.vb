Imports System.Data.Common
Imports ACELogistica
Imports ACFramework
Imports DAConexion

Public Class DABAS_PedidosCompraDetalle
    #Region " Variables "
	Private m_formatofecha As String
	Public ReadOnly Property Tabla() As String
		Get
			Return "ABAS_PedidosCompraDetalle"
		End Get
	End Property
	Public ReadOnly Property Esquema() As String
		Get
			Return "Logistica"
		End Get
	End Property

#End Region
    #Region " Constructores "
	
	Public Sub New()
		m_formatofecha = "yyyy-MM-dd HH:mm:ss.fff"
	End Sub

#End Region
    #Region  " Procedimientos Almacenados "
    	Public Function ABAS_PDDETSD_UnReg(ByVal x_where As Hashtable) As Integer
		Try
			DAEnterprise.AsignarProcedure(getDelete(x_where), CommandType.Text)
			Return DAEnterprise.ExecuteNonQuery()
		Catch ex As Exception
			Throw ex
		End Try
	End Function
    Public Function ABAS_PDDETSD_UnReg(ByVal x_abas_pedidoscompradetalle As EABAS_PedidosCompraDetalle) As Integer
		Try
			DAEnterprise.AsignarProcedure(getDelete(x_abas_pedidoscompradetalle), CommandType.Text)
			Return DAEnterprise.ExecuteNonQuery()
		Catch ex As Exception
			Throw ex
		End Try
	End Function
    Public Function ABAS_PDDETSI_UnReg(ByRef x_abas_pedidoscompradetalle As EABAS_PedidosCompraDetalle, ByVal x_usuario As String) As Integer
		Dim m_filas As Integer
		Try
			DAEnterprise.AsignarProcedure(getInsert(x_abas_pedidoscompradetalle, x_usuario), CommandType.Text)
			m_filas = DAEnterprise.ExecuteNonQuery()
			Return m_filas
		Catch ex As Exception
			Throw ex
		End Try
	End Function
    Public Function ABAS_PDDETSU_UnReg(ByVal x_vent_pedidosdetalle As EABAS_PedidosCompraDetalle, ByVal x_usuario As String) As Integer
		Try
			DAEnterprise.AsignarProcedure(getUpdate(x_vent_pedidosdetalle, x_usuario), CommandType.Text)
			Return DAEnterprise.ExecuteNonQuery()
		Catch ex As Exception
			Throw ex
		End Try
	End Function
    Public Function ABAS_PDDETSS_Todos(ByRef listEABAS_PedidosCompraDetalle As List(Of EABAS_PedidosCompraDetalle), ByVal x_join As List(Of ACJoin), ByVal x_where As Hashtable) As Boolean
		Try
			DAEnterprise.AsignarProcedure(getSelectAll(x_join, x_where), CommandType.Text)
			Using reader As DbDataReader = DAEnterprise.ExecuteDataReader()
				If reader.HasRows
					Dim _utilitarios As New ACEsquemas(New EABAS_PedidosCompraDetalle())
					While reader.Read()
						Dim e_abas_pedidoscompradetalle As New EABAS_PedidosCompraDetalle()
						_utilitarios.ACCargarEsquemas(reader, e_abas_pedidoscompradetalle)
						e_abas_pedidoscompradetalle.Instanciar(ACEInstancia.Consulta)
						listEABAS_PedidosCompraDetalle.Add(e_abas_pedidoscompradetalle)
					End While
					Return True
				Else
					Return False
				End If
			End Using
		Catch ex As Exception
			Throw ex
		End Try
	End Function
    #End Region
    #Region " Procedimientos Adicionales "
     Private Function getSelectAll(ByVal x_join As List(Of ACJoin), ByVal x_where As HashTable, ByVal x_distinct As Boolean) As String
			Dim sql As String = ""
			Try

				Dim _join As New ACGenerador(Of EABAS_PedidosCompraDetalle)(m_formatofecha)
 
				sql &= _join.getJoin(Esquema, Tabla, x_join, x_where, x_distinct)

				Return sql
			Catch ex As Exception
				Throw ex
			End Try
		End Function
    	Private Function getSelectAll(ByVal x_join As List(Of ACJoin), ByVal x_where As HashTable) As String
			Dim sql As String = ""
			Try

				Dim _join As New ACGenerador(Of EABAS_PedidosCompraDetalle)(m_formatofecha)
 
				sql &= _join.getJoin(Esquema, Tabla, x_join, x_where)

				Return sql
			Catch ex As Exception
				Throw ex
			End Try
		End Function
    Private Function getDelete(ByVal x_where As HashTable) As String 
			Dim sql As String = ""
			Try

				sql  = " DELETE FROM Logistica.ABAS_PedidosCompraDetalle" & vbNewLine
				sql &= " WHERE "
				Dim _where As New ACGenerador(Of EABAS_PedidosCompraDetalle)(m_formatofecha) 
				sql &= _where.getWhere(x_where, True) 

				Return sql
			Catch ex As Exception
				Throw ex
			End Try
		End Function
    	Private Function getDelete(ByVal x_abas_pedidoscompradetalle As EABAS_PedidosCompraDetalle) As String 
			Dim sql As String = ""
			Try

				sql  = " DELETE FROM Logistica.ABAS_PedidosCompraDetalle" & vbNewLine
				sql &= " WHERE "
				sql &= "    PEDID_Codigo = " & IIf(IsNothing(x_abas_pedidoscompradetalle.PEDID_Codigo), "Null", "'" & x_abas_pedidoscompradetalle.PEDID_Codigo & "'") & vbNewLine
				sql &= "And PDDET_Item = " & IIf(x_abas_pedidoscompradetalle.PDDET_Item = 0, "Null", x_abas_pedidoscompradetalle.PDDET_Item.ToString()) & vbNewLine

				Return sql
			Catch ex As Exception
				Throw ex
			End Try
		End Function
    Private Function getInsert(ByVal x_vent_pedidosdetalle As EABAS_PedidosCompraDetalle, ByVal x_usuario As String) As String
			Dim sql As String = ""
			Try
				Dim _fecha As DateTime = getDateTime()
				x_vent_pedidosdetalle.PDDET_UsrCrea = x_usuario
				x_vent_pedidosdetalle.PDDET_FecCrea = _fecha

				Dim _insert As New ACFramework.ACGenerador(Of EABAS_PedidosCompraDetalle)(_fecha, m_formatofecha)
				sql = _insert.getInsert(Esquema, Tabla, x_vent_pedidosdetalle, x_vent_pedidosdetalle.Hash, New String() {})


				Return sql
			Catch ex As Exception
				Throw ex
			End Try
		End Function
    Private Function getUpdate(ByVal x_abas_pedidoscompradetalle As EABAS_PedidosCompraDetalle, ByVal x_usuario As String) As String
			Dim sql As String = ""
			Try
				Dim _fecha As DateTime = getDateTime()
				x_abas_pedidoscompradetalle.PDDET_UsrMod = x_usuario
				x_abas_pedidoscompradetalle.PDDET_FecMod = _fecha

				Dim _update As New ACFramework.ACGenerador(Of EABAS_PedidosCompraDetalle)(_fecha, m_formatofecha)
				Dim _where As New Hashtable()
				_where.Add("PEDID_Codigo", New ACWhere(x_ABAS_PedidosCompraDetalle.PEDID_Codigo, ACWhere.TipoWhere.Igual))
				_where.Add("PDDET_Item", New ACWhere(x_ABAS_PedidosCompraDetalle.PDDET_Item, ACWhere.TipoWhere.Igual))
				sql = _update.getUpdate(Esquema, Tabla, x_abas_pedidoscompradetalle, _where, x_abas_pedidoscompradetalle.Hash, New String() {})

				Return sql
			Catch ex As Exception
				Throw ex
			End Try
		End Function
    #End Region
    #Region " Metodos "
	
	Private Function getDate() As String
		Dim x_datos As New DataTable()
		Try
			DAEnterprise.AsignarProcedure("Select GetDate()", CommandType.Text)
			x_datos = DAEnterprise.ExecuteDataSet().Tables(0)
			Dim _fecha As DateTime = x_datos.Rows(0)(0)
			Return "'" & _fecha.ToString(m_formatofecha) & "'"
		Catch ex As Exception
			Throw ex
		End Try
	End Function

	Private Function getDateTime() As DateTime
		Dim x_datos As New DataTable()
		Try
			DAEnterprise.AsignarProcedure("Select GetDate()", CommandType.Text)
			x_datos = DAEnterprise.ExecuteDataSet().Tables(0)
			Dim _fecha As DateTime = x_datos.Rows(0)(0)
			Return _fecha
		Catch ex As Exception
			Throw ex
		End Try
	End Function
   
#End Region
End Class
