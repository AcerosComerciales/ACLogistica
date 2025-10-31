Imports System.Data.Common
Imports ACFramework
Imports DAConexion
Imports ACELogistica

Public Class DABAS_PedidosCompra
    
#Region " Variables "
	Private m_formatofecha As String
	Public ReadOnly Property Tabla() As String
		Get
			Return "ABAS_PedidosCompra"
		End Get
	End Property
	Public ReadOnly Property Esquema() As String
		Get
			Return "Logistica"
		End Get
	End Property
    Public Sub New()
		m_formatofecha = "yyyy-MM-dd HH:mm:ss.fff"
	End Sub

#End Region

#Region " Procedimientos Almacenados "
    
   ''' <summary> 
   ''' Capa de Datos: VENT_PEDIDSS_ConsPedidoReposicion
   ''' </summary>
   ''' <param name="x_fecini">Parametro 1: </param> 
   ''' <param name="x_fecfin">Parametro 2: </param> 
   ''' <param name="x_zonas_codigo">Parametro 3: </param> 
   ''' <param name="x_pvent_id">Parametro 4: </param> 
   ''' <param name="x_sucur_id">Parametro 5: </param> 
   ''' <param name="x_pedid_tipo">Parametro 6: </param> 
   ''' <param name="x_opcion">Parametro 7: </param> 
   ''' <param name="x_cadena">Parametro 8: </param> 
   ''' <param name="x_todos">Parametro 9: </param> 
   ''' <param name="x_pvent_idorigen">Parametro 10: </param> 
   ''' <param name="x_rehusados">Parametro 11: </param> 
   ''' <returns></returns> 
   ''' <remarks></remarks> 
   Public Function ABAS_PEDIDSS_ConsPedidoCompra(ByVal m_listabas_pedidoscompra As List(Of EABAS_PedidosCompra), ByVal x_fecini As Date, ByVal x_fecfin As Date, ByVal x_zonas_codigo As String,  ByVal x_sucur_id As Short,  ByVal x_opcion As Short, ByVal x_cadena As String, ByVal x_todos As Boolean ) As Boolean
      Try
         DAEnterprise.AsignarProcedure("ABAS_PEDIDSS_ConsPedidoCompra")
         DAEnterprise.AgregarParametro("@FecIni", x_fecini, DbType.DateTime, 8)
         DAEnterprise.AgregarParametro("@FecFin", x_fecfin, DbType.DateTime, 8)
         DAEnterprise.AgregarParametro("@ZONAS_Codigo", x_zonas_codigo, DbType.String, 5)
        ' DAEnterprise.AgregarParametro("@PVENT_Id", x_pvent_id, DbType.Int64, 8)
         DAEnterprise.AgregarParametro("@SUCUR_Id", x_sucur_id, DbType.Int16, 2)
       '  DAEnterprise.AgregarParametro("@PEDID_Tipo", x_pedid_tipo, DbType.String, 1)
         DAEnterprise.AgregarParametro("@Opcion", x_opcion, DbType.Int16, 2)
         DAEnterprise.AgregarParametro("@Cadena", x_cadena, DbType.String, 50)
         DAEnterprise.AgregarParametro("@Todos", x_todos, DbType.Boolean, 1)
         

         'DAEnterprise.AgregarParametro("@Rehusados", x_rehusados, DbType.Boolean, 1)
         Using reader As DbDataReader = DAEnterprise.ExecuteDataReader()
            If reader.HasRows Then
               While reader.Read()
                  Dim _abas_pedidoscompra As New EABAS_PedidosCompra()
                  ACEsquemas.ACCargarEsquema(reader, _abas_pedidoscompra)
                  _abas_pedidoscompra.Instanciar(ACEInstancia.Consulta)
                  m_listabas_pedidoscompra.Add(_abas_pedidoscompra)
               End While
               Return True
            Else
               Return False
            End If
         End Using
         Return True
      Catch ex As Exception
         Throw ex
      End Try
   End Function
    Public Function ABAS_PEDIDSS_UnReg(ByRef x_event_pedidos As EABAS_PedidosCompra, ByVal x_pedid_codigo As String) As Boolean
		Try
			DAEnterprise.AsignarProcedure(getSelectBy(x_pedid_codigo), CommandType.Text)
			Using reader As DbDataReader = DAEnterprise.ExecuteDataReader()
				If reader.HasRows Then
					reader.Read()
					ACEsquemas.ACCargarEsquema(reader, x_event_pedidos)
					x_event_pedidos.Instanciar(ACEInstancia.Consulta)
					return True
				Else
					Return False
				End If
			End Using
		Catch ex As Exception
			Throw ex
		End Try
	End Function
    	Public Function ABAS_PEDIDSS_UnReg(ByRef x_eabas_pedidoscompra As EABAS_PedidosCompra, ByVal x_where As Hashtable) As Boolean
		Try
			DAEnterprise.AsignarProcedure(getSelectBy(x_where), CommandType.Text)
			Using reader As DbDataReader = DAEnterprise.ExecuteDataReader()
				If reader.HasRows Then
					reader.Read()
					ACEsquemas.ACCargarEsquema(reader, x_eabas_pedidoscompra)
					x_eabas_pedidoscompra.Instanciar(ACEInstancia.Consulta)
					return True
				Else
					Return False
				End If
			End Using
		Catch ex As Exception
			Throw ex
		End Try
	End Function
    	Public Function ABAS_PEDIDSS_UnReg(ByRef x_event_pedidos As EABAS_PedidosCompra, ByVal x_join As List(Of ACJoin), ByVal x_where As Hashtable) As Boolean
		Try
			DAEnterprise.AsignarProcedure(getSelectBy(x_join, x_where), CommandType.Text)
			Using reader As DbDataReader = DAEnterprise.ExecuteDataReader()
				If reader.HasRows Then
					reader.Read()
					ACEsquemas.ACCargarEsquema(reader, x_event_pedidos)
					x_event_pedidos.Instanciar(ACEInstancia.Consulta)
					return True
				Else
					Return False
				End If
			End Using
		Catch ex As Exception
			Throw ex
		End Try
	End Function
    Public Function ABAS_PEDIDSI_UnReg(ByRef x_vent_pedidos As EABAS_PedidosCompra, ByVal x_usuario As String) As Integer
		Try
			DAEnterprise.AsignarProcedure(getInsert(x_vent_pedidos, x_usuario), CommandType.Text)
			Return DAEnterprise.ExecuteNonQuery()
		Catch ex As Exception
			Throw ex
		End Try
	End Function
    Public Function ABAS_PEDIDSU_UnReg(ByVal x_vent_pedidos As EABAS_PedidosCompra, ByVal x_usuario As String) As Integer
		Try
			DAEnterprise.AsignarProcedure(getUpdate(x_vent_pedidos, x_usuario), CommandType.Text)
			Return DAEnterprise.ExecuteNonQuery()
		Catch ex As Exception
			Throw ex
		End Try
	End Function
    Public Function ABAS_PEDIDSD_UnReg(ByVal x_vent_pedidos As EABAS_PedidosCompra) As Integer
		Try
			DAEnterprise.AsignarProcedure(getDelete(x_vent_pedidos), CommandType.Text)
			Return DAEnterprise.ExecuteNonQuery()
		Catch ex As Exception
			Throw ex
		End Try
	End Function
    	Public Function getCorrelativo(ByVal x_campo As String, ByVal x_where As Hashtable) As Integer
		Try
			DAEnterprise.AsignarProcedure(getSelectId(x_campo, x_where), CommandType.Text)
			Dim m_data As DataSet = DAEnterprise.ExecuteDataSet()
			Return CType(m_data.Tables(0).Rows(0)("Id"), Integer)
		Catch ex As Exception
			Throw ex
		End Try
	End Function

    Public Function getCorrelativo(ByVal x_campo As String) As Integer
		Try
			DAEnterprise.AsignarProcedure(getSelectId(x_campo), CommandType.Text)
			Dim m_data As DataSet = DAEnterprise.ExecuteDataSet()
			Return CType(m_data.Tables(0).Rows(0)("Id"), Decimal)
		Catch ex As Exception
			Throw ex
		End Try
	End Function
#End Region

    
	#region "Procedimientos Adicionales "
    Private Function getSelectId(ByVal x_campo As String) As String 
			Dim sql As String = ""
			Try

				sql  = String.Format(" SELECT IsNull(Max({0}), 0) As Id From Logistica.ABAS_PedidosCompra ", x_campo)

				Return sql
			Catch ex As Exception
				Throw ex
			End Try
		End Function
		Private Function getSelectId(ByVal x_campo As String, ByVal x_where As HashTable) As String 
			Dim sql As String = ""
			Try

				sql  = String.Format(" SELECT IsNull(Max({0}), 0) As Id From Logistica.ABAS_PedidosCompra ", x_campo)
				sql &= " WHERE "
				Dim _where As New ACGenerador(Of EABAS_PedidosCompra)(m_formatofecha) 
				sql &= _where.getWhere(x_where, True) 

				Return sql
			Catch ex As Exception
				Throw ex
			End Try
		End Function

    Private Function getSelectBy(ByVal x_pedid_codigo As String) As String
			Dim sql As String = ""
			Try
				sql  = " SELECT * " & vbNewLine
				sql &= " FROM Logistica.ABAS_PedidosCompra" & vbNewLine
				sql &= " WHERE " & vbNewLine
				sql &= "PEDID_Codigo = " + IIf(IsNothing(x_pedid_codigo), "Null", "'" & x_pedid_codigo & "'") & vbNewLine

				Return sql
			Catch ex As Exception
				Throw ex
			End Try
		End Function
    	Private Function getSelectBy(ByVal x_where As HashTable) As String
			Dim sql As String = ""
			Try
				sql = " SELECT  * " & vbNewLine
				sql &= "FROM Logistica.ABAS_PedidosCompra" & vbNewLine
				sql &= " WHERE " & vbNewLine
				Dim _where As New ACGenerador(Of EABAS_PedidosCompra)(m_formatofecha)
				sql &= _where.getWhere(x_where, True) 

				Return sql
			Catch ex As Exception
				Throw ex
			End Try
		End Function
    	Private Function getSelectBy(ByVal x_join As List(Of ACJoin), ByVal x_where As HashTable) As String
			Dim sql As String = ""
			Try

				Dim _join As New ACGenerador(Of EABAS_PedidosCompra)(m_formatofecha)
 
				sql &= _join.getJoin(Esquema, Tabla, x_join, x_where)

				Return sql
			Catch ex As Exception
				Throw ex
			End Try
		End Function
    Private Function getDelete(ByVal x_abas_pedidoscompra As EABAS_PedidosCompra) As String 
			Dim sql As String = ""
			Try

				sql  = " DELETE FROM logistica.ABAS_PedidosCompra" & vbNewLine
				sql &= " WHERE "
				sql &= "    PEDID_Codigo = " & IIf(IsNothing(x_abas_pedidoscompra.PEDID_Codigo), "Null", "'" & x_abas_pedidoscompra.PEDID_Codigo & "'") & vbNewLine

				Return sql
			Catch ex As Exception
				Throw ex
			End Try
		End Function
    
		Private Function getInsert(ByVal x_abas_pedidoscompra As EABAS_PedidosCompra, ByVal x_usuario As String) As String
			Dim sql As String = ""
			Try
				Dim _fecha As DateTime = getDateTime()
				x_abas_pedidoscompra.PEDID_UsrCrea = x_usuario
				x_abas_pedidoscompra.PEDID_FecCrea = _fecha

				Dim _insert As New ACFramework.ACGenerador(Of EABAS_PedidosCompra)(_fecha, m_formatofecha)
				sql = _insert.getInsert(Esquema, Tabla, x_abas_pedidoscompra, x_abas_pedidoscompra.Hash, New String() {})


				Return sql
			Catch ex As Exception
				Throw ex
			End Try
		End Function
    Private Function getUpdate(ByVal x_vent_pedidos As EABAS_PedidosCompra, ByVal x_usuario As String) As String
			Dim sql As String = ""
			Try
				Dim _fecha As DateTime = getDateTime()
				x_vent_pedidos.PEDID_UsrMod = x_usuario
				x_vent_pedidos.PEDID_FecMod = _fecha

				Dim _update As New ACFramework.ACGenerador(Of EABAS_PedidosCompra)(_fecha, m_formatofecha)
				Dim _where As New Hashtable()
				_where.Add("PEDID_Codigo", New ACWhere(x_VENT_Pedidos.PEDID_Codigo, ACWhere.TipoWhere.Igual))
				sql = _update.getUpdate(Esquema, Tabla, x_vent_pedidos, _where, x_vent_pedidos.Hash, New String() {})

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
