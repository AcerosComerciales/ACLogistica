Imports System
Imports System.Data
Imports System.Collections.Generic

Imports ACELogistica
Imports ACDLogistica
Imports System.Threading.Tasks
Imports System.Threading

Partial Public Class BDIST_Ordenes

#Region " Variables "

    Private m_edist_ordenes As EDIST_Ordenes
    Private m_listDIST_Ordenes As List(Of EDIST_Ordenes)
    Private m_dtDIST_Ordenes As DataTable

    Private m_dsDIST_Ordenes As DataSet
    Private d_dist_ordenes As DDIST_Ordenes
    Private ReadOnly _dataA As DDIST_Ordenes

    Private ReadOnly _dataB As DDIST_Ordenes

    Private ReadOnly _dataC As DDIST_Ordenes

    Private ReadOnly _conexionLocal As DDIST_Ordenes

#End Region

#Region " Constructores "

    Public Sub New()
        d_dist_ordenes = New DDIST_Ordenes()
    End Sub

#End Region



    Public Sub New(connA As String, connB As String, connC As String)
        _dataA = New DDIST_Ordenes(connA)
        _dataB = New DDIST_Ordenes(connB)
        _dataC = New DDIST_Ordenes(connC)
    End Sub

    Public Sub New(ConnexionLocal)
        _conexionLocal = New DDIST_Ordenes(ConnexionLocal)
    End Sub

#Region "ESTA REGION ES PARA EL ORIGEN "

    'Funcion local
    'ESTAS DOS FUNCIONES NO SE TOCAN ==========================================================================================================================
    Public Async Function ObtenerClientesDeTodasLocalAsync(ct As CancellationToken, ByVal x_fecInici As Date, ByVal x_fecFin As Date, ByVal PuntoOrigen As Long, ByVal AlmacenOrigen As Long, ByVal DireccionIp As String, ByVal nameBd As String) As Task(Of List(Of EDIST_OrdenesDetalle))
        ' Ejecutar en paralelo
        Try
            'ByVal PuntoOrigen As Long, ByVal DireccionIp As String, ByVal NameBd As String
            Dim tA = _conexionLocal.ObtenerOrdenesOrigenAsync(ct, x_fecInici, x_fecFin, Nothing, AlmacenOrigen, DireccionIp, nameBd)
            'Dim tB = _dataB.ObtenerOrdenesAsync(ct, x_fecInici, x_fecFin)
            'Dim tC = _dataC.ObtenerOrdenesAsync(ct, x_fecInici, x_fecFin)

            ' Esperar todas
            Dim resultados = Await Task.WhenAll(tA)

            ' Consolidar
            Dim listaFinal As New List(Of EDIST_OrdenesDetalle)
            For Each r In resultados
                listaFinal.AddRange(r)
            Next
            Return listaFinal
        Catch ex As Exception
            Throw
        End Try
    End Function


    'Function externo
    'ESTAS DOS FUNCIONES NO SE TOCAN ==========================================================================================================================

    Public Async Function ObtenerOrdenesExternaAsync(ct As CancellationToken, ByVal x_fecInici As Date, ByVal x_fecFin As Date, ByVal PuntoOrigen As Long, ByVal AlmacenOrigen As Long, ByVal DireccionIp As String, ByVal nameBd As String) As Task(Of List(Of EDIST_OrdenesDetalle))
        ' Ejecutar en paralelo
        Try
            Dim tA = _conexionLocal.ObtenerOrdenesOrigenAsync(ct, x_fecInici, x_fecFin, PuntoOrigen, AlmacenOrigen, Nothing, Nothing)
            'Dim tB = _dataB.ObtenerOrdenesAsync(ct, x_fecInici, x_fecFin)
            'Dim tC = _dataC.ObtenerOrdenesAsync(ct, x_fecInici, x_fecFin)

            ' Esperar todas
            Dim resultados = Await Task.WhenAll(tA)

            ' Consolidar
            Dim listaFinal As New List(Of EDIST_OrdenesDetalle)
            For Each r In resultados
                listaFinal.AddRange(r)
            Next
            Return listaFinal
        Catch ex As Exception
            Throw
        End Try


    End Function



#End Region


#Region "ESTA REGION ES PARA EL DESTINO OSEA AL REVES "
    'ESTAS DOS FUNCIONES NO SE TOCAN ==========================================================================================================================
    Public Async Function ObtenerClientesDeTodasLocalDestinoAsync(ct As CancellationToken, ByVal x_fecInici As Date, ByVal x_fecFin As Date, ByVal PuntoOrigen As Long, ByVal AlmacenDestino As Long, ByVal DireccionIp As String, ByVal nameBd As String) As Task(Of List(Of EDIST_OrdenesDetalle))
        ' Ejecutar en paralelo
        Try
            'ByVal PuntoOrigen As Long, ByVal DireccionIp As String, ByVal NameBd As String
            Dim tA = _conexionLocal.ObtenerOrdenesDestinoAsync(ct, x_fecInici, x_fecFin, Nothing, AlmacenDestino, DireccionIp, nameBd)
            'Dim tB = _dataB.ObtenerOrdenesAsync(ct, x_fecInici, x_fecFin)
            'Dim tC = _dataC.ObtenerOrdenesAsync(ct, x_fecInici, x_fecFin)

            ' Esperar todas
            Dim resultados = Await Task.WhenAll(tA)

            ' Consolidar
            Dim listaFinal As New List(Of EDIST_OrdenesDetalle)
            For Each r In resultados
                listaFinal.AddRange(r)
            Next
            Return listaFinal
        Catch ex As Exception
            Throw
        End Try
    End Function


    'Function externo
    'ESTAS DOS FUNCIONES NO SE TOCAN ==========================================================================================================================

    Public Async Function ObtenerOrdenesExternaDestinoAsync(ct As CancellationToken, ByVal x_fecInici As Date, ByVal x_fecFin As Date, ByVal PuntoOrigen As Long, ByVal AlmacenDestino As Long, ByVal DireccionIp As String, ByVal nameBd As String) As Task(Of List(Of EDIST_OrdenesDetalle))
        ' Ejecutar en paralelo
        Try
            Dim tA = _conexionLocal.ObtenerOrdenesDestinoAsync(ct, x_fecInici, x_fecFin, PuntoOrigen, AlmacenDestino, Nothing, Nothing)
            'Dim tB = _dataB.ObtenerOrdenesAsync(ct, x_fecInici, x_fecFin)
            'Dim tC = _dataC.ObtenerOrdenesAsync(ct, x_fecInici, x_fecFin)

            ' Esperar todas
            Dim resultados = Await Task.WhenAll(tA)

            ' Consolidar
            Dim listaFinal As New List(Of EDIST_OrdenesDetalle)
            For Each r In resultados
                listaFinal.AddRange(r)
            Next
            Return listaFinal
        Catch ex As Exception
            Throw
        End Try


    End Function




#End Region


#Region " Propiedades "

    Public Property DIST_Ordenes() As EDIST_Ordenes
        Get
            Return m_edist_ordenes
        End Get
        Set(ByVal value As EDIST_Ordenes)
            m_edist_ordenes = value
        End Set
    End Property

    Public Property ListDIST_Ordenes() As List(Of EDIST_Ordenes)
        Get
            Return m_listDIST_Ordenes
        End Get
        Set(ByVal value As List(Of EDIST_Ordenes))
            m_listDIST_Ordenes = value
        End Set
    End Property

    Public Property DTDIST_Ordenes() As DataTable
        Get
            Return m_dtDIST_Ordenes
        End Get
        Set(ByVal value As DataTable)
            m_dtDIST_Ordenes = value
        End Set
    End Property

    Public Property DSDIST_Ordenes() As DataSet
        Get
            Return m_dsDIST_Ordenes
        End Get
        Set(ByVal value As DataSet)
            m_dsDIST_Ordenes = value
        End Set
    End Property


#End Region

#Region " Funciones para obtencion de datos "

#End Region

#Region " Metodos "

    Public Function CargarTodos() As Boolean
        Try
            m_listDIST_Ordenes = New List(Of EDIST_Ordenes)()
            Return d_dist_ordenes.DIST_ORDENSS_Todos(m_listDIST_Ordenes)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function CargarTodos(ByVal x_where As Hashtable) As Boolean
        Try
            m_listDIST_Ordenes = New List(Of EDIST_Ordenes)()
            Return d_dist_ordenes.DIST_ORDENSS_Todos(m_listDIST_Ordenes, x_where)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function CargarTodos(ByVal x_join As List(Of ACFramework.ACJoin), ByVal x_where As Hashtable) As Boolean
        Try
            m_listDIST_Ordenes = New List(Of EDIST_Ordenes)()
            Return d_dist_ordenes.DIST_ORDENSS_Todos(m_listDIST_Ordenes, x_join, x_where)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function CargarTodos(ByVal x_join As List(Of ACFramework.ACJoin), ByVal x_where As Hashtable, ByVal x_distinct As Boolean) As Boolean
        Try
            m_listDIST_Ordenes = New List(Of EDIST_Ordenes)()
            Return d_dist_ordenes.DIST_ORDENSS_Todos(m_listDIST_Ordenes, x_join, x_where, x_distinct)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function CargarTodosDS(ByVal x_where As Hashtable) As Boolean
        Try
            m_dsDIST_Ordenes = New DataSet()
            Return d_dist_ordenes.DIST_ORDENSS_Todos(m_dsDIST_Ordenes, x_where)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function CargarTodosDS(ByVal x_join As List(Of ACFramework.ACJoin), ByVal x_where As Hashtable) As Boolean
        Try
            m_dsDIST_Ordenes = New DataSet()
            Return d_dist_ordenes.DIST_ORDENSS_Todos(m_dsDIST_Ordenes, x_join, x_where)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function CargarTodosDT(ByVal x_where As Hashtable) As Boolean
        Try
            m_dsDIST_Ordenes = New DataSet()
            Dim _opcion As Boolean = d_dist_ordenes.DIST_ORDENSS_Todos(m_dsDIST_Ordenes, x_where)
            If _opcion Then
                m_dtDIST_Ordenes = m_dsDIST_Ordenes.Tables(0)
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function CargarTodosDT(ByVal x_join As List(Of ACFramework.ACJoin), ByVal x_where As Hashtable) As Boolean
        Try
            m_dsDIST_Ordenes = New DataSet()
            Dim _opcion As Boolean = d_dist_ordenes.DIST_ORDENSS_Todos(m_dsDIST_Ordenes, x_join, x_where)
            If _opcion Then
                m_dtDIST_Ordenes = m_dsDIST_Ordenes.Tables(0)
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Cargar(ByVal x_orden_codigo As String) As Boolean
        Try
            m_edist_ordenes = New EDIST_Ordenes()
            Return d_dist_ordenes.DIST_ORDENSS_UnReg(m_edist_ordenes, x_orden_codigo)
        Catch ex As Exception
            Throw ex
        End Try
    End Function


    'Cargados 






    Public Function Cargar(ByVal x_where As Hashtable) As Boolean
        Try
            m_edist_ordenes = New EDIST_Ordenes()
            Return d_dist_ordenes.DIST_ORDENSS_UnReg(m_edist_ordenes, x_where)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Cargar(ByVal x_join As List(Of ACFramework.ACJoin), ByVal x_where As Hashtable) As Boolean
        Try
            m_edist_ordenes = New EDIST_Ordenes()
            Return d_dist_ordenes.DIST_ORDENSS_UnReg(m_edist_ordenes, x_join, x_where)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal x_usuario As String) As Boolean
        Try
            If m_edist_ordenes.Nuevo Then
                d_dist_ordenes.DIST_ORDENSI_UnReg(m_edist_ordenes, x_usuario)
            ElseIf m_edist_ordenes.Modificado Then
                d_dist_ordenes.DIST_ORDENSU_UnReg(m_edist_ordenes, x_usuario)
            ElseIf m_edist_ordenes.Eliminado Then
                d_dist_ordenes.DIST_ORDENSD_UnReg(DIST_Ordenes)
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal x_where As Hashtable, ByVal x_usuario As String) As Boolean
        Try
            If m_edist_ordenes.Nuevo Then
                d_dist_ordenes.DIST_ORDENSI_UnReg(m_edist_ordenes, x_usuario)
            ElseIf m_edist_ordenes.Modificado Then
                d_dist_ordenes.DIST_ORDENSU_UnReg(m_edist_ordenes, x_where, x_usuario)
            ElseIf m_edist_ordenes.Eliminado Then
                d_dist_ordenes.DIST_ORDENSD_UnReg(x_where)
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal x_where As Hashtable, ByVal x_usuario As String, ByVal x_excluir() As String, ByVal x_setfecha() As String) As Boolean
        Try
            If m_edist_ordenes.Nuevo Then
                d_dist_ordenes.DIST_ORDENSI_UnReg(m_edist_ordenes, x_usuario, x_excluir, x_setfecha)
            ElseIf m_edist_ordenes.Modificado Then
                d_dist_ordenes.DIST_ORDENSU_UnReg(m_edist_ordenes, x_where, x_usuario, x_excluir, x_setfecha)
            ElseIf m_edist_ordenes.Eliminado Then
                d_dist_ordenes.DIST_ORDENSD_UnReg(DIST_Ordenes)
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal x_where As Hashtable, ByVal x_usuario As String, ByVal x_excluir() As String, ByVal x_setfecha() As String, ByVal x_setcampos() As String) As Boolean
        Try
            If m_edist_ordenes.Nuevo Then
                d_dist_ordenes.DIST_ORDENSI_UnReg(m_edist_ordenes, x_usuario, x_excluir, x_setfecha)
            ElseIf m_edist_ordenes.Modificado Then
                d_dist_ordenes.DIST_ORDENSU_UnReg(m_edist_ordenes, x_where, x_usuario, x_excluir, x_setfecha, x_setcampos)
            ElseIf m_edist_ordenes.Eliminado Then
                d_dist_ordenes.DIST_ORDENSD_UnReg(DIST_Ordenes)
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal x_usuario As String, ByVal x_setfecha() As String) As Boolean
        Try
            If m_edist_ordenes.Nuevo Then
                d_dist_ordenes.DIST_ORDENSI_UnReg(m_edist_ordenes, x_usuario, x_setfecha)
            ElseIf m_edist_ordenes.Modificado Then
                d_dist_ordenes.DIST_ORDENSU_UnReg(m_edist_ordenes, x_usuario, x_setfecha)
            ElseIf m_edist_ordenes.Eliminado Then
                d_dist_ordenes.DIST_ORDENSD_UnReg(DIST_Ordenes)
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Guardar(ByVal x_usuario As String, ByVal x_excluir() As String, ByVal x_setfecha() As String) As Boolean
        Try
            If m_edist_ordenes.Nuevo Then
                d_dist_ordenes.DIST_ORDENSI_UnReg(m_edist_ordenes, x_usuario, x_excluir, x_setfecha)
            ElseIf m_edist_ordenes.Eliminado Then
                d_dist_ordenes.DIST_ORDENSD_UnReg(DIST_Ordenes)
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function Eliminar(ByVal x_where As Hashtable) As Boolean
        Try
            m_listDIST_Ordenes = New List(Of EDIST_Ordenes)()
            Return d_dist_ordenes.DIST_ORDENSD_UnReg(x_where) > 0
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function getCorrelativo(ByVal x_campo As String) As Integer
        Try
            Return d_dist_ordenes.getCorrelativo(x_campo) + 1
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function getCorrelativo(ByRef x_id As Integer, ByVal x_campo As String) As Integer
        Try
            x_id = d_dist_ordenes.getCorrelativo(x_campo)
            Return (x_id + 1)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function getCorrelativo(ByVal x_campo As String, ByVal x_where As Hashtable) As Integer
        Try
            Return d_dist_ordenes.getCorrelativo(x_campo, x_where) + 1
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function getCorrelativo(ByRef x_id As Integer, ByVal x_campo As String, ByVal x_where As Hashtable) As Integer
        Try
            x_id = d_dist_ordenes.getCorrelativo(x_campo, x_where)
            Return (x_id + 1)
        Catch ex As Exception
            Throw ex
        End Try
    End Function


#End Region

End Class

