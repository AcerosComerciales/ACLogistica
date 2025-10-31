Imports ACDLogistica
Imports ACELogistica
Imports ACEVentas
Imports DAConexion

Public Class BStocksIniciales
#Region " Variables "


    Private Shared d_stocksiniciales As DStocksIniciales

    Private m_listarticulos As List(Of ELOG_StockIniciales)

    Private m_elog_stockiniciales As ELOG_StockIniciales


#End Region
#Region " Constructores "

    Public Sub New()
        d_stocksiniciales = New DStocksIniciales
    End Sub

#End Region

#Region " Propiedades "

    Public Property LOG_StockIniciales() As ELOG_StockIniciales
        Get
            Return m_elog_stockiniciales
        End Get
        Set(ByVal value As ELOG_StockIniciales)
            m_elog_stockiniciales = value
        End Set
    End Property
    Public Property ListArticulos() As List(Of ELOG_StockIniciales)
        Get
            Return m_listarticulos
        End Get
        Set(ByVal value As List(Of ELOG_StockIniciales))
            m_listarticulos = value
        End Set
    End Property
#End Region

#Region "Metodos"
    ''' <summary> 
    ''' Capa de Negocio: LOG_STOCKSINI_StockALaUltimaFecha
    ''' </summary> 
    ''' <param name="x_perio_codigo">Parametro 1: </param> 
    ''' <param name="x_almac_id">Parametro 2: </param> 
    ''' <param name="x_zonas_codigo">Parametro 3: </param> 

    ''' <returns></returns> 
    ''' <remarks></remarks> 
    Public Function LOG_STOCKSINI_StockALaUltimaFecha(ByVal x_perio_codigo As String, ByVal x_almac_id As Short, ByVal x_zonas_codigo As String, ByVal x_fecha As DateTime) As Boolean
        m_listarticulos = New List(Of ELOG_StockIniciales)
        Try
            Return d_stocksiniciales.LOG_STOCKSINI_StockALaUltimaFecha(m_listarticulos, x_perio_codigo, x_almac_id, x_zonas_codigo, x_fecha)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    ''' <summary> 
    ''' Capa de Negocio: LOG_STOCKSS_StockInicialXPeriodo
    ''' </summary> 
    ''' <param name="x_perio_codigo">Parametro 1: </param> 
    ''' <param name="x_almac_id">Parametro 2: </param> 
    ''' <param name="x_zonas_codigo">Parametro 3: </param> 
    ''' <returns></returns> 
    ''' <remarks></remarks> 
    Public Function LOG_STOCKSS_StockInicialXPeriodo(ByRef x_datatable As DataTable, ByVal x_perio_codigo As String, ByVal x_almac_id As Short, ByVal x_zonas_codigo As String, ByVal x_fecha As DateTime) As Boolean
        m_listarticulos = New List(Of ELOG_StockIniciales)
        Try
            Return d_stocksiniciales.LOG_STOCKSS_StockInicialXPeriodo(m_listarticulos, x_perio_codigo, x_almac_id, x_zonas_codigo, x_fecha)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    ''' <summary>
    ''' Grabar listado de articulos
    ''' </summary>
    ''' <param name="x_usuario">codigo de usuario</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Grabar(ByVal x_usuario As String, ByVal x_periodo As String, ByVal x_almac_id As Short) As Boolean
        Try
            DAEnterprise.BeginTransaction()
            For Each item As ELOG_StockIniciales In m_listarticulos
                Dim _articulo As New BLOG_StockIniciales
                item.PERIO_Codigo = x_periodo
                item.ALMAC_Id = x_almac_id
                item.STINI_Fecha = New DateTime(x_periodo, 1, 1)
                _articulo.LOG_StockIniciales = item

                ' m_blog_stocks.LOG_Stocks.Instanciar(ACFramework.ACEInstancia.Nuevo)
                _articulo.LOG_StockIniciales.Instanciar(ACFramework.ACEInstancia.Nuevo)
                If _articulo.Guardar(x_usuario) Then
                    '   If _docsventa.Guardar(x_usuario) Then
                    DAEnterprise.CommitTransaction()
                    Return True
                Else
                    Throw New Exception("No se puede Grabar el Stock Inicial,Consulte con el Administrador")
                End If
            Next

        Catch ex As Exception
            Throw ex
        End Try
    End Function
#End Region

End Class
