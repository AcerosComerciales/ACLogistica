Imports System.Data.Common
Imports ACELogistica

Imports ACFramework
Imports DAConexion

Public Class DStocksIniciales
#Region " Variables "
    Private m_formatofecha As String
#End Region

#Region " Constructores "
    Public Sub New()
        m_formatofecha = "yyyy-MM-dd HH:mm:ss.fff"
    End Sub
#End Region
#Region "MEtodos"

    ''' <summary> 
    ''' Capa de Datos: LOG_STOCKSS_StockALaFecha
    ''' </summary>
    ''' <param name="x_perio_codigo">Parametro 1: </param> 
    ''' <param name="x_almac_id">Parametro 2: </param> 
    ''' <param name="x_zonas_codigo">Parametro 3: </param> 
    ''' <returns></returns> 
    ''' <remarks></remarks> 
    Public Function LOG_STOCKSINI_StockALaUltimaFecha(ByVal m_listarticulos As List(Of ELOG_StockIniciales),ByVal x_perio_codigo As String, ByVal x_almac_id As Short, ByVal x_zonas_codigo As String, ByVal x_fecha As Date) As Boolean
        Try
            DAEnterprise.AsignarProcedure("LOG_STOCKSINI_StockALaUltimaFecha")
            DAEnterprise.AgregarParametro("@PERIO_Codigo", x_perio_codigo, DbType.String, 6)
            DAEnterprise.AgregarParametro("@ALMAC_Id", x_almac_id, DbType.Int16, 2)
            DAEnterprise.AgregarParametro("@ZONAS_Codigo", x_zonas_codigo, DbType.String, 5)

            If x_fecha.Year > 2000 Then
                DAEnterprise.AgregarParametro("@Fecha", x_fecha, DbType.DateTime, 8)
            End If
    '        x_datatable = DAEnterprise.ExecuteDataSet().Tables(0)
    '        Return (x_datatable.Rows.Count > 0)
    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Function
             Using reader As DbDataReader = DAEnterprise.ExecuteDataReader()
            If reader.HasRows Then
               While reader.Read()
                  Dim _articulos As New ELOG_StockIniciales()
                  ACEsquemas.ACCargarEsquema(reader, _articulos)
                  _articulos.Instanciar(ACEInstancia.Consulta)
                  m_listarticulos.Add(_articulos)
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
   ''' Capa de Datos: LOG_STOCKSS_StockInicialXPeriodo
   ''' </summary>
   ''' <param name="x_perio_codigo">Parametro 1: </param> 
   ''' <param name="x_almac_id">Parametro 2: </param> 
   ''' <param name="x_zonas_codigo">Parametro 3: </param> 
   ''' <returns></returns> 
   ''' <remarks></remarks> 
   Public Function LOG_STOCKSS_StockInicialXPeriodo(ByVal m_listarticulos As List(Of ELOG_StockIniciales), ByVal x_perio_codigo As String, ByVal x_almac_id As Short, ByVal x_zonas_codigo As String,  ByVal x_fecha As Date) As Boolean
      Try
         DAEnterprise.AsignarProcedure("LOG_STOCKSS_StockInicialXPeriodo")
         DAEnterprise.AgregarParametro("@PERIO_Codigo", x_perio_codigo, DbType.String, 6)
         DAEnterprise.AgregarParametro("@ALMAC_Id", x_almac_id, DbType.Int16, 2)
         DAEnterprise.AgregarParametro("@ZONAS_Codigo", x_zonas_codigo, DbType.String, 5)

         If x_fecha.Year > 2000 Then
            DAEnterprise.AgregarParametro("@Fecha", x_fecha, DbType.DateTime, 8)
         End If
   '      x_datatable = DAEnterprise.ExecuteDataSet().Tables(0)
   '      Return (x_datatable.Rows.Count > 0)
   '   Catch ex As Exception
   '      Throw ex
   '   End Try
   'End Function

    Using reader As DbDataReader = DAEnterprise.ExecuteDataReader()
            If reader.HasRows Then
               While reader.Read()
                  Dim _articulos As New ELOG_StockIniciales()
                  ACEsquemas.ACCargarEsquema(reader, _articulos)
                  _articulos.Instanciar(ACEInstancia.Consulta)
                  m_listarticulos.Add(_articulos)
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
#End Region
End Class
