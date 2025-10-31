Imports System
Imports System.Data
Imports System.Data.Common
Imports System.Collections.Generic

Imports ACFramework
Imports DAConexion
Imports ACELogistica

Partial Public Class DABAS_IngresosCompra

#Region " Variables "
	
#End Region

#Region " Constructores "
	
#End Region

#Region " Procedimientos Almacenados "

   ''' <summary> 
   ''' Capa de Datos: LOG_INGSS_Consulta
   ''' </summary>
   ''' <param name="x_cadena">Parametro 1: </param> 
   ''' <param name="x_opcion">Parametro 2: </param> 
   ''' <param name="x_todos">Parametro 3: </param> 
   ''' <param name="x_fecini">Parametro 4: </param> 
   ''' <param name="x_fecfin">Parametro 5: </param> 
   ''' <returns></returns> 
   ''' <remarks></remarks> 
   Public Function LOG_INGSS_Consulta(ByVal m_listabas_ingresoscompra As List(Of EABAS_IngresosCompra), ByVal x_cadena As String, ByVal x_opcion As Short, ByVal x_todos As Boolean, ByVal x_fecini As Date, ByVal x_fecfin As Date) As Boolean
      Try
         DAEnterprise.AsignarProcedure("LOG_INGSS_Consulta")
         DAEnterprise.AgregarParametro("@Cadena", x_cadena, DbType.String, 50)
         DAEnterprise.AgregarParametro("@Opcion", x_opcion, DbType.Int16, 2)
         DAEnterprise.AgregarParametro("@Todos", x_todos, DbType.Boolean, 1)
         DAEnterprise.AgregarParametro("@FecIni", x_fecini, DbType.DateTime, 8)
         DAEnterprise.AgregarParametro("@FecFin", x_fecfin, DbType.DateTime, 8)
         Using reader As DbDataReader = DAEnterprise.ExecuteDataReader()
                If reader.HasRows Then

                    While reader.Read()
                        Dim _abas_ingresoscompra As New EABAS_IngresosCompra()
                        ACEsquemas.ACCargarEsquema(reader, _abas_ingresoscompra)
                        _abas_ingresoscompra.Instanciar(ACEInstancia.Consulta)
                        m_listabas_ingresoscompra.Add(_abas_ingresoscompra)
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

     Public Function LOG_INGSS_ConsultaIT(ByVal m_listabas_ingresoscompra As List(Of EABAS_IngresosCompra), ByVal x_cadena As String, ByVal x_opcion As Short, ByVal x_tipo As String, ByVal x_todos As Boolean, ByVal x_fecini As Date, ByVal x_fecfin As Date) As Boolean
      Try
         DAEnterprise.AsignarProcedure("LOG_INGSS_ConsultaIngTransformacion")
         DAEnterprise.AgregarParametro("@Cadena", x_cadena, DbType.String, 50)
         DAEnterprise.AgregarParametro("@Opcion", x_opcion, DbType.Int16, 2)
         DAEnterprise.AgregarParametro("@Tipo", x_tipo, DbType.String, 10)
         DAEnterprise.AgregarParametro("@Todos", x_todos, DbType.Boolean, 1)
         DAEnterprise.AgregarParametro("@FecIni", x_fecini, DbType.DateTime, 8)
         DAEnterprise.AgregarParametro("@FecFin", x_fecfin, DbType.DateTime, 8)
         Using reader As DbDataReader = DAEnterprise.ExecuteDataReader()
                If reader.HasRows Then

                    While reader.Read()
                        Dim _abas_ingresoscompra As New EABAS_IngresosCompra()
                        ACEsquemas.ACCargarEsquema(reader, _abas_ingresoscompra)
                        _abas_ingresoscompra.Instanciar(ACEInstancia.Consulta)
                        m_listabas_ingresoscompra.Add(_abas_ingresoscompra)
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
    ''' <summary> 
    ''' Capa de Datos: LOG_DIST_GUIASS_ObtDetDocCompra
    ''' </summary>
    ''' <param name="x_docco_codigo">Parametro 1: </param> 
    ''' <param name="x_almac_id">Parametro 2: </param> 
    ''' <returns></returns> 
    ''' <remarks></remarks> 
    Public Function LOG_DIST_GUIASS_ObtDetDocCompra(ByVal m_listabas_docscompradetalle As List(Of EABAS_DocsCompraDetalle), ByVal x_docco_codigo As String, ByVal x_entid_codigo As String, ByVal x_almac_id As Short) As Boolean
        Try
            DAEnterprise.AsignarProcedure("LOG_DIST_GUIASS_ObtDetDocCompra")
            DAEnterprise.AgregarParametro("@DOCCO_Codigo", x_docco_codigo, DbType.String, 15)
            DAEnterprise.AgregarParametro("@ENTID_Codigo", x_entid_codigo, DbType.String, 14)
            DAEnterprise.AgregarParametro("@ALMAC_Id", x_almac_id, DbType.Int16, 2)

            Using reader As DbDataReader = DAEnterprise.ExecuteDataReader()
                If reader.HasRows Then
                    While reader.Read()
                        Dim _abas_docscompradetalle As New EABAS_DocsCompraDetalle()
                        ACEsquemas.ACCargarEsquema(reader, _abas_docscompradetalle)
                        _abas_docscompradetalle.Instanciar(ACEInstancia.Consulta)
                        m_listabas_docscompradetalle.Add(_abas_docscompradetalle)
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

    ''' <summary> 
    ''' Capa de Datos: LOG_ABASS_GuiasXDocumento
    ''' </summary>
    ''' <param name="x_docco_codigo">Parametro 1: </param> 
    ''' <param name="x_almac_id">Parametro 2: </param> 
    ''' <returns></returns> 
    ''' <remarks></remarks> 
    Public Function LOG_ABASS_GuiasXDocumento(ByRef m_listabas_ingresoscompra As List(Of EABAS_IngresosCompra), ByVal x_docco_codigo As String, ByVal x_entid_codigo As String, ByVal x_almac_id As Long) As Boolean
        Try
            DAEnterprise.AsignarProcedure("LOG_ABASS_GuiasXDocumento")
            DAEnterprise.AgregarParametro("@DOCCO_Codigo", x_docco_codigo, DbType.String, 15)
            DAEnterprise.AgregarParametro("@ENTID_Codigo", x_entid_codigo, DbType.String, 14)
            DAEnterprise.AgregarParametro("@ALMAC_Id", x_almac_id, DbType.Int64, 8)
            Using reader As DbDataReader = DAEnterprise.ExecuteDataReader()
                If reader.HasRows Then
                    While reader.Read()
                        Dim _abas_guiasingreso As New EABAS_IngresosCompra()
                        ACEsquemas.ACCargarEsquema(reader, _abas_guiasingreso)
                        _abas_guiasingreso.Instanciar(ACEInstancia.Consulta)
                        m_listabas_ingresoscompra.Add(_abas_guiasingreso)
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






   Public Function getCodCorrelativo(ByVal x_ordco_codigo As String) As Integer
      Try
         DAEnterprise.AsignarProcedure(getSelectCorr(x_ordco_codigo), CommandType.Text)
         Dim m_data As DataSet = DAEnterprise.ExecuteDataSet()
         Return CType(m_data.Tables(0).Rows(0)("Codigo"), Integer)
      Catch ex As Exception
         Throw ex
      End Try
   End Function

#Region "Procedimientos Adicionales "
   Private Function getSelectCorr(ByVal x_ordco_codigo As String) As String
      Dim sql As String = ""
      Try
         sql &= String.Format(" Select IsNull(Max(INGCO_Interno), 0) As Codigo from Logistica.ABAS_IngresosCompraDetalle where ordco_codigo = '{0}' {1}", x_ordco_codigo, vbNewLine)
         Return sql
      Catch ex As Exception
         Throw ex
      End Try
   End Function
#End Region
#End Region

#Region " Metodos "
	
#End Region


End Class

