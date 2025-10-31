Imports System
Imports System.Data
Imports System.Data.Common
Imports System.Collections.Generic

Imports ACFramework
Imports DAConexion
Imports ACELogistica
Imports System.Data.SqlClient
Imports System.Threading.Tasks
Imports System.Threading

Partial Public Class DDIST_Ordenes

#Region " Variables "
    Private m_formatofecha As String
    Public ReadOnly Property Tabla() As String
        Get
            Return "DIST_Ordenes"
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

    Private ReadOnly _connStr As String
    Public Sub New(connStr As String)
        _connStr = connStr
    End Sub


#Region "Procedimientos Asincronos"


#End Region
#Region "ORDENES "


    'SI QUIERES VER LO QUE ESTA CONSULTA TRAE SEPARADOS POR INDEXACION DE NADA ESPECIAL BY FRANK 

    'Using rd = Await cmd.ExecuteReaderAsync(ct).ConfigureAwait(False)

    '                ' 🔹 Imprimir nombres de columnas con índice
    '                For i As Integer = 0 To rd.FieldCount - 1
    '                    Debug.Write($"[{i}] {rd.GetName(i)}" & vbTab)
    '                Next
    '                Debug.WriteLine("")

    '                ' 🔹 Imprimir filas con índice + valor
    '                While Await rd.ReadAsync(ct).ConfigureAwait(False)
    '                    For i As Integer = 0 To rd.FieldCount - 1
    '                        Debug.Write($"[{i}] {rd(i).ToString()}" & vbTab)
    '                    Next
    '                    Debug.WriteLine("")
    '                End While

    '            End Using


    Public Async Function ObtenerOrdenesOrigenAsync(ct As CancellationToken, ByVal fecha_inicio As DateTime, ByVal fecha_fin As DateTime, ByVal PuntoOrigen As Long, ByVal AlmacenOrigen As Long, ByVal DireccionIp As String, ByVal NameBd As String) As Task(Of List(Of EDIST_OrdenesDetalle))
        Dim lista As New List(Of EDIST_OrdenesDetalle)
        Using cn As New SqlConnection(_connStr)
            Await cn.OpenAsync(ct).ConfigureAwait(False)
            Using cmd As New SqlCommand("ALMA_REPOSS_TOTAL_Ordenes", cn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@FecIni", fecha_inicio)
                cmd.Parameters.AddWithValue("@FecFin", fecha_fin)
                cmd.Parameters.AddWithValue("@PuntoOrigen", PuntoOrigen)
                cmd.Parameters.AddWithValue("@AlmacenOrigen", AlmacenOrigen)
                cmd.Parameters.AddWithValue("@Ip", DireccionIp)
                cmd.Parameters.AddWithValue("@BD", NameBd)


                'Using rd = Await cmd.ExecuteReaderAsync(ct).ConfigureAwait(False)

                '    ' Imprimir nombres de columnas con índice
                '    For i As Integer = 0 To rd.FieldCount - 1
                '        Debug.Write($"[{i}] {rd.GetName(i)}" & vbTab)
                '    Next
                '    Debug.WriteLine("")

                '    ' Imprimir filas con índice + valor
                '    While Await rd.ReadAsync(ct).ConfigureAwait(False)
                '        For i As Integer = 0 To rd.FieldCount - 1
                '            Debug.Write($"[{i}] {rd(i).ToString()}" & vbTab)
                '        Next
                '        Debug.WriteLine("")
                '    End While

                'End Using



                Using rd = Await cmd.ExecuteReaderAsync(ct).ConfigureAwait(False)
                    While Await rd.ReadAsync(ct).ConfigureAwait(False)
                        lista.Add(New EDIST_OrdenesDetalle With {
                            .ORDET_FecCrea = rd.GetDateTime(0),
                             .ORDEN_Codigo = rd.GetString(1),
                            .DOCVE_Codigo = rd.GetString(2),
                            .ARTIC_Codigo = rd.GetString(3),
                            .ORDET_Cantidad = rd.GetDecimal(4),
                            .ORDET_CantidadEntregada = rd.GetDecimal(5),
                            .ARTIC_Descripcion = rd.GetString(6),
                            .ORDET_Item = rd.GetInt16(7),
                            .ORDEN_Codorigen = rd.GetString(8)
                                        })
                        '.Metros = rd.GetDecimal(5)

                    End While
                End Using
            End Using
        End Using
        Return lista
    End Function

    'Funcion para el destino 

    Public Async Function ObtenerOrdenesDestinoAsync(ct As CancellationToken, ByVal fecha_inicio As DateTime, ByVal fecha_fin As DateTime, ByVal PuntoOrigen As Long, ByVal AlmacenDestino As Long, ByVal DireccionIp As String, ByVal NameBd As String) As Task(Of List(Of EDIST_OrdenesDetalle))
        Dim lista As New List(Of EDIST_OrdenesDetalle)
        Using cn As New SqlConnection(_connStr)
            Await cn.OpenAsync(ct).ConfigureAwait(False)
            Using cmd As New SqlCommand("ALMA_REPOSS_TOTAL_Ordenes_Destino", cn)
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.AddWithValue("@FecIni", fecha_inicio)
                cmd.Parameters.AddWithValue("@FecFin", fecha_fin)
                cmd.Parameters.AddWithValue("@PuntoDestino", PuntoOrigen)
                cmd.Parameters.AddWithValue("@AlmacenDestino", AlmacenDestino)
                cmd.Parameters.AddWithValue("@Ip", DireccionIp)
                cmd.Parameters.AddWithValue("@BD", NameBd)


                'Using rd = Await cmd.ExecuteReaderAsync(ct).ConfigureAwait(False)

                '    ' Imprimir nombres de columnas con índice
                '    For i As Integer = 0 To rd.FieldCount - 1
                '        Debug.Write($"[{i}] {rd.GetName(i)}" & vbTab)
                '    Next
                '    Debug.WriteLine("")

                '    ' Imprimir filas con índice + valor
                '    While Await rd.ReadAsync(ct).ConfigureAwait(False)
                '        For i As Integer = 0 To rd.FieldCount - 1
                '            Debug.Write($"[{i}] {rd(i).ToString()}" & vbTab)
                '        Next
                '        Debug.WriteLine("")
                '    End While

                'End Using



                Using rd = Await cmd.ExecuteReaderAsync(ct).ConfigureAwait(False)
                    While Await rd.ReadAsync(ct).ConfigureAwait(False)
                        lista.Add(New EDIST_OrdenesDetalle With {
                            .ORDET_FecCrea  = rd.GetDateTime(0),
                            .ORDEN_Codigo = rd.GetString(1),
                            .DOCVE_Codigo = rd.GetString(2),
                            .ARTIC_Codigo = rd.GetString(3),
                            .ORDET_Cantidad = rd.GetDecimal(4),
                            .ORDET_CantidadEntregada = rd.GetDecimal(5),
                            .ARTIC_Descripcion = rd.GetString(6),
                            .ORDET_Item = rd.GetInt16(7),
                            .ORDEN_Codorigen = rd.GetString(8)
                                        })
                        '.Metros = rd.GetDecimal(5)

                    End While
                End Using
            End Using
        End Using
        Return lista
    End Function




    'Using rd = Await cmd.ExecuteReaderAsync(ct).ConfigureAwait(False)
    '                While Await rd.ReadAsync(ct).ConfigureAwait(False)
    '                    lista.Add(New EDIST_OrdenesDetalle With {
    '                        .ORDEN_Codigo = rd.GetString(0),
    '                        .ORDET_FecCrea = rd.GetDateTime(1),
    '                        .ARTIC_Codigo = rd.GetString(2),
    '                        .ORDET_Cantidad = rd.GetDecimal(3),
    '                        .ARTIC_Descripcion = rd.GetString(4)
    '                                    })
    '                    '.Metros = rd.GetDecimal(5)

    '                End While
    'End Using

    'While Await rd.ReadAsync(ct).ConfigureAwait(False)
    '            lista.Add(New EDIST_Ordenes With {
    '                .DOCVE_Codigo = rd.GetString(0),
    '                .ORDEN_FecCrea = rd.GetDateTime(1),
    '                .ORDEN_Codigo = rd.GetString(2),
    '                .Cantidad = rd.GetDecimal(3),
    '                .Descripcion = rd.GetString(4),
    '                .Metros = rd.GetDecimal(5)
    '            })
    '        End While

    '.DOCVE_Codigo = rd.GetString(0),
    '                .ORDEN_FecCrea = rd.GetDateTime(1),
    '                .ORDEN_Codigo = rd.GetString(2),
    '                .Cantidad = rd.GetDecimal(3),
    '                .Descripcion = rd.GetString(4),
    '                .Metros = rd.GetDecimal(5)



#End Region


#Region " Procedimientos Almacenados "





    Public Function DIST_ORDENSS_Todos(ByRef x_listDIST_Ordenes As List(Of EDIST_Ordenes)) As Boolean
        Try
            DAEnterprise.AsignarProcedure(getSelectAll(), CommandType.Text)
            Using reader As DbDataReader = DAEnterprise.ExecuteDataReader()
                If reader.HasRows Then
                    Dim _utilitarios As New ACEsquemas(New EDIST_Ordenes())
                    While reader.Read()
                        Dim x_edist_ordenes As New EDIST_Ordenes()
                        _utilitarios.ACCargarEsquemas(reader, x_edist_ordenes)
                        x_edist_ordenes.Instanciar(ACEInstancia.Consulta)
                        x_listDIST_Ordenes.Add(x_edist_ordenes)
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

    Public Function DIST_ORDENSS_Todos(ByRef x_listDIST_Ordenes As List(Of EDIST_Ordenes), ByVal x_where As Hashtable) As Boolean
        Try
            DAEnterprise.AsignarProcedure(getSelectAll(x_where), CommandType.Text)
            Using reader As DbDataReader = DAEnterprise.ExecuteDataReader()
                If reader.HasRows Then
                    Dim _utilitarios As New ACEsquemas(New EDIST_Ordenes())
                    While reader.Read()
                        Dim x_edist_ordenes As New EDIST_Ordenes()
                        _utilitarios.ACCargarEsquemas(reader, x_edist_ordenes)
                        x_edist_ordenes.Instanciar(ACEInstancia.Consulta)
                        x_listDIST_Ordenes.Add(x_edist_ordenes)
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

    'ProcSucurOrdenes




    Public Function DIST_ORDENSS_Todos(ByRef x_listDIST_Ordenes As List(Of EDIST_Ordenes), ByVal x_join As List(Of ACJoin), ByVal x_where As Hashtable) As Boolean
        Try
            DAEnterprise.AsignarProcedure(getSelectAll(x_join, x_where), CommandType.Text)
            Using reader As DbDataReader = DAEnterprise.ExecuteDataReader()
                If reader.HasRows Then
                    Dim _utilitarios As New ACEsquemas(New EDIST_Ordenes())
                    While reader.Read()
                        Dim x_edist_ordenes As New EDIST_Ordenes()
                        _utilitarios.ACCargarEsquemas(reader, x_edist_ordenes)
                        x_edist_ordenes.Instanciar(ACEInstancia.Consulta)
                        x_listDIST_Ordenes.Add(x_edist_ordenes)
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

    Public Function DIST_ORDENSS_Todos(ByRef x_listDIST_Ordenes As List(Of EDIST_Ordenes), ByVal x_join As List(Of ACJoin), ByVal x_where As Hashtable, ByVal x_distinct As Boolean) As Boolean
        Try
            DAEnterprise.AsignarProcedure(getSelectAll(x_join, x_where, x_distinct), CommandType.Text)
            Using reader As DbDataReader = DAEnterprise.ExecuteDataReader()
                If reader.HasRows Then
                    Dim _utilitarios As New ACEsquemas(New EDIST_Ordenes())
                    While reader.Read()
                        Dim x_edist_ordenes As New EDIST_Ordenes()
                        _utilitarios.ACCargarEsquemas(reader, x_edist_ordenes)
                        x_edist_ordenes.Instanciar(ACEInstancia.Consulta)
                        x_listDIST_Ordenes.Add(x_edist_ordenes)
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

    Public Function DIST_ORDENSS_Todos(ByRef m_datos As DataSet, ByVal x_where As Hashtable) As Boolean
        Try
            DAEnterprise.AsignarProcedure(getSelectAll(x_where), CommandType.Text)
            m_datos = DAEnterprise.ExecuteDataSet()
            Return m_datos.Tables.Count > 0
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function DIST_ORDENSS_Todos(ByRef m_datos As DataSet, ByVal m_campos() As ACCampos, ByVal x_where As Hashtable) As Boolean
        Try
            DAEnterprise.AsignarProcedure(getSelectAll(m_campos, x_where), CommandType.Text)
            m_datos = DAEnterprise.ExecuteDataSet()
            Return m_datos.Tables.Count > 0
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function DIST_ORDENSS_Todos(ByRef m_datos As DataSet, ByVal x_join As List(Of ACJoin), ByVal x_where As Hashtable) As Boolean
        Try
            DAEnterprise.AsignarProcedure(getSelectAll(x_join, x_where), CommandType.Text)
            m_datos = DAEnterprise.ExecuteDataSet()
            Return m_datos.Tables.Count > 0
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function DIST_ORDENSS_UnReg(ByRef x_edist_ordenes As EDIST_Ordenes, ByVal x_orden_codigo As String) As Boolean
        Try
            DAEnterprise.AsignarProcedure(getSelectBy(x_orden_codigo), CommandType.Text)
            Using reader As DbDataReader = DAEnterprise.ExecuteDataReader()
                If reader.HasRows Then
                    reader.Read()
                    ACEsquemas.ACCargarEsquema(reader, x_edist_ordenes)
                    x_edist_ordenes.Instanciar(ACEInstancia.Consulta)
                    Return True
                Else
                    Return False
                End If
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Function





    Public Function DIST_ORDENSS_UnReg(ByRef x_edist_ordenes As EDIST_Ordenes, ByVal x_where As Hashtable) As Boolean
        Try
            DAEnterprise.AsignarProcedure(getSelectBy(x_where), CommandType.Text)
            Using reader As DbDataReader = DAEnterprise.ExecuteDataReader()
                If reader.HasRows Then
                    reader.Read()
                    ACEsquemas.ACCargarEsquema(reader, x_edist_ordenes)
                    x_edist_ordenes.Instanciar(ACEInstancia.Consulta)
                    Return True
                Else
                    Return False
                End If
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function DIST_ORDENSS_UnReg(ByRef x_edist_ordenes As EDIST_Ordenes, ByVal x_join As List(Of ACJoin), ByVal x_where As Hashtable) As Boolean
        Try
            DAEnterprise.AsignarProcedure(getSelectBy(x_join, x_where), CommandType.Text)
            Using reader As DbDataReader = DAEnterprise.ExecuteDataReader()
                If reader.HasRows Then
                    reader.Read()
                    ACEsquemas.ACCargarEsquema(reader, x_edist_ordenes)
                    x_edist_ordenes.Instanciar(ACEInstancia.Consulta)
                    Return True
                Else
                    Return False
                End If
            End Using
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function DIST_ORDENSI_UnReg(ByRef x_dist_ordenes As EDIST_Ordenes, ByVal x_usuario As String) As Integer
        Try
            DAEnterprise.AsignarProcedure(getInsert(x_dist_ordenes, x_usuario), CommandType.Text)
            Return DAEnterprise.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function DIST_ORDENSI_UnReg(ByRef x_dist_ordenes As EDIST_Ordenes, ByVal x_usuario As String, ByVal x_setfecha() As String) As Integer
        Try
            DAEnterprise.AsignarProcedure(getInsert(x_dist_ordenes, x_usuario, x_setfecha), CommandType.Text)
            Return DAEnterprise.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function DIST_ORDENSI_UnReg(ByRef x_dist_ordenes As EDIST_Ordenes, ByVal x_usuario As String, ByVal x_excluir() As String, ByVal x_setfecha() As String) As Integer
        Try
            DAEnterprise.AsignarProcedure(getInsert(x_dist_ordenes, x_usuario, x_excluir, x_setfecha), CommandType.Text)
            Return DAEnterprise.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function DIST_ORDENSU_UnReg(ByVal x_dist_ordenes As EDIST_Ordenes, ByVal x_usuario As String) As Integer
        Try
            DAEnterprise.AsignarProcedure(getUpdate(x_dist_ordenes, x_usuario), CommandType.Text)
            Return DAEnterprise.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function DIST_ORDENSU_UnReg(ByVal x_dist_ordenes As EDIST_Ordenes, ByVal x_usuario As String, ByVal x_setfecha() As String) As Integer
        Try
            DAEnterprise.AsignarProcedure(getUpdate(x_dist_ordenes, x_usuario, x_setfecha), CommandType.Text)
            Return DAEnterprise.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function DIST_ORDENSU_UnReg(ByVal x_dist_ordenes As EDIST_Ordenes, ByVal x_where As Hashtable, ByVal x_usuario As String) As Integer
        Try
            DAEnterprise.AsignarProcedure(getUpdate(x_dist_ordenes, x_where, x_usuario), CommandType.Text)
            Return DAEnterprise.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function DIST_ORDENSU_UnReg(ByVal x_dist_ordenes As EDIST_Ordenes, ByVal x_where As Hashtable, ByVal x_usuario As String, ByVal x_setfecha() As String) As Integer
        Try
            DAEnterprise.AsignarProcedure(getUpdate(x_dist_ordenes, x_where, x_usuario, x_setfecha), CommandType.Text)
            Return DAEnterprise.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function DIST_ORDENSU_UnReg(ByVal x_dist_ordenes As EDIST_Ordenes, ByVal x_where As Hashtable, ByVal x_usuario As String, ByVal x_excluir() As String, ByVal x_setfecha() As String) As Integer
        Try
            DAEnterprise.AsignarProcedure(getUpdate(x_dist_ordenes, x_where, x_usuario, x_excluir, x_setfecha), CommandType.Text)
            Return DAEnterprise.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function DIST_ORDENSU_UnReg(ByVal x_dist_ordenes As EDIST_Ordenes, ByVal x_where As Hashtable, ByVal x_usuario As String, ByVal x_excluir() As String, ByVal x_setfecha() As String, ByVal x_setcampos() As String) As Integer
        Try
            DAEnterprise.AsignarProcedure(getUpdate(x_dist_ordenes, x_where, x_usuario, x_excluir, x_setfecha, x_setcampos), CommandType.Text)
            Return DAEnterprise.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function DIST_ORDENSD_UnReg(ByVal x_dist_ordenes As EDIST_Ordenes) As Integer
        Try
            DAEnterprise.AsignarProcedure(getDelete(x_dist_ordenes), CommandType.Text)
            Return DAEnterprise.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function DIST_ORDENSD_UnReg(ByVal x_where As Hashtable) As Integer
        Try
            DAEnterprise.AsignarProcedure(getDelete(x_where), CommandType.Text)
            Return DAEnterprise.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function getCorrelativo(ByVal x_campo As String) As Integer
        Try
            DAEnterprise.AsignarProcedure(getSelectId(x_campo), CommandType.Text)
            Dim m_data As DataSet = DAEnterprise.ExecuteDataSet()
            Return CType(m_data.Tables(0).Rows(0)("Id"), Integer)
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


#Region "Procedimientos Adicionales "
    Private Function getSelectAll() As String
        Dim sql As String = ""
        Try
            sql = " SELECT * "
            sql &= " FROM Logistica.DIST_Ordenes" & vbNewLine

            Return sql
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function getSelectAll(ByVal x_where As Hashtable) As String
        Dim sql As String = ""
        Try
            sql = " SELECT  * " & vbNewLine
            sql &= " FROM Logistica.DIST_Ordenes" & vbNewLine
            sql &= " WHERE " & vbNewLine
            Dim _where As New ACGenerador(Of EDIST_Ordenes)(m_formatofecha)
            sql &= _where.getWhere(x_where, True)

            Return sql
        Catch ex As Exception
            Throw ex
        End Try
    End Function




    Private Function getSelectAll(ByVal m_campos() As ACCampos, ByVal x_where As Hashtable) As String
        Dim sql As String = ""
        Try
            sql = " SELECT  " & vbNewLine
            Dim i As Boolean = True
            For Each Item As ACCampos In m_campos
                If i Then
                    sql &= String.Format(" {0} As {1}{2}", Item.CampoOrigen, Item.CampoDestino, vbNewLine)
                    i = False
                Else
                    sql &= String.Format(",{0} As {1}{2}", Item.CampoOrigen, Item.CampoDestino, vbNewLine)
                End If
            Next
            sql &= " FROM Logistica.DIST_Ordenes" & vbNewLine
            sql &= " WHERE " & vbNewLine
            Dim _where As New ACGenerador(Of EDIST_Ordenes)(m_formatofecha)
            sql &= _where.getWhere(x_where, True)

            Return sql
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function getSelectAll(ByVal x_join As List(Of ACJoin), ByVal x_where As Hashtable) As String
        Dim sql As String = ""
        Try

            Dim _join As New ACGenerador(Of EDIST_Ordenes)(m_formatofecha)

            sql &= _join.getJoin(Esquema, Tabla, x_join, x_where)

            Return sql
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function getSelectAll(ByVal x_join As List(Of ACJoin), ByVal x_where As Hashtable, ByVal x_distinct As Boolean) As String
        Dim sql As String = ""
        Try

            Dim _join As New ACGenerador(Of EDIST_Ordenes)(m_formatofecha)

            sql &= _join.getJoin(Esquema, Tabla, x_join, x_where, x_distinct)

            Return sql
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function getSelectBy(ByVal x_orden_codigo As String) As String
        Dim sql As String = ""
        Try
            sql = " SELECT * " & vbNewLine
            sql &= " FROM Logistica.DIST_Ordenes" & vbNewLine
            sql &= " WHERE " & vbNewLine
            sql &= "ORDEN_Codigo = " + IIf(IsNothing(x_orden_codigo), "Null", "'" & x_orden_codigo & "'") & vbNewLine

            Return sql
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function getSelectBy(ByVal x_where As Hashtable) As String
        Dim sql As String = ""
        Try
            sql = " SELECT  * " & vbNewLine
            sql &= " FROM Logistica.DIST_Ordenes" & vbNewLine
            sql &= " WHERE " & vbNewLine
            Dim _where As New ACGenerador(Of EDIST_Ordenes)(m_formatofecha)
            sql &= _where.getWhere(x_where, True)

            Return sql
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function getSelectBy(ByVal x_join As List(Of ACJoin), ByVal x_where As Hashtable) As String
        Dim sql As String = ""
        Try

            Dim _join As New ACGenerador(Of EDIST_Ordenes)(m_formatofecha)

            sql &= _join.getJoin(Esquema, Tabla, x_join, x_where)

            Return sql
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function getInsert(ByVal x_dist_ordenes As EDIST_Ordenes, ByVal x_usuario As String) As String
        Dim sql As String = ""
        Try
            Dim _fecha As DateTime = getDateTime()
            x_dist_ordenes.ORDEN_UsrCrea = x_usuario
            x_dist_ordenes.ORDEN_FecCrea = _fecha

            Dim _insert As New ACFramework.ACGenerador(Of EDIST_Ordenes)(_fecha, m_formatofecha)
            sql = _insert.getInsert(Esquema, Tabla, x_dist_ordenes, x_dist_ordenes.Hash, New String() {})


            Return sql
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function getInsert(ByVal x_dist_ordenes As EDIST_Ordenes, ByVal x_usuario As String, ByVal x_setfecha() As String) As String
        Dim sql As String = ""
        Try
            Dim _fecha As DateTime = getDateTime()
            x_dist_ordenes.ORDEN_UsrCrea = x_usuario
            x_dist_ordenes.ORDEN_FecCrea = _fecha

            Dim _insert As New ACFramework.ACGenerador(Of EDIST_Ordenes)(_fecha, m_formatofecha)
            sql = _insert.getInsertFecha(Esquema, Tabla, x_dist_ordenes, x_dist_ordenes.Hash, New String() {}, x_setfecha)


            Return sql
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function getInsert(ByVal x_dist_ordenes As EDIST_Ordenes, ByVal x_usuario As String, ByVal x_excluir() As String, ByVal x_setfecha() As String) As String
        Dim sql As String = ""
        Try
            Dim _fecha As DateTime = getDateTime()
            x_dist_ordenes.ORDEN_UsrCrea = x_usuario
            x_dist_ordenes.ORDEN_FecCrea = _fecha

            Dim _insert As New ACFramework.ACGenerador(Of EDIST_Ordenes)(_fecha, m_formatofecha)
            sql = _insert.getInsertFecha(Esquema, Tabla, x_dist_ordenes, x_dist_ordenes.Hash, x_excluir, x_setfecha)


            Return sql
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function getUpdate(ByVal x_dist_ordenes As EDIST_Ordenes, ByVal x_usuario As String) As String
        Dim sql As String = ""
        Try
            Dim _fecha As DateTime = getDateTime()
            x_dist_ordenes.ORDEN_UsrMod = x_usuario
            x_dist_ordenes.ORDEN_FecMod = _fecha

            Dim _update As New ACFramework.ACGenerador(Of EDIST_Ordenes)(_fecha, m_formatofecha)
            Dim _where As New Hashtable()
            _where.Add("ORDEN_Codigo", New ACWhere(x_dist_ordenes.ORDEN_Codigo, ACWhere.TipoWhere.Igual))
            sql = _update.getUpdate(Esquema, Tabla, x_dist_ordenes, _where, x_dist_ordenes.Hash, New String() {})

            Return sql
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function getUpdate(ByVal x_dist_ordenes As EDIST_Ordenes, ByVal x_usuario As String, ByVal x_setfecha() As String) As String
        Dim sql As String = ""
        Try
            Dim _fecha As DateTime = getDateTime()
            x_dist_ordenes.ORDEN_UsrMod = x_usuario
            x_dist_ordenes.ORDEN_FecMod = _fecha

            Dim _update As New ACFramework.ACGenerador(Of EDIST_Ordenes)(_fecha, m_formatofecha)
            Dim _where As New Hashtable()
            _where.Add("ORDEN_Codigo", New ACWhere(x_dist_ordenes.ORDEN_Codigo, ACWhere.TipoWhere.Igual))
            sql = _update.getUpdateFecha(Esquema, Tabla, x_dist_ordenes, _where, x_dist_ordenes.Hash, New String() {}, x_setfecha)

            Return sql
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function getUpdate(ByVal x_dist_ordenes As EDIST_Ordenes, ByVal x_where As Hashtable, ByVal x_usuario As String) As String
        Dim sql As String = ""
        Try
            Dim _fecha As DateTime = getDateTime()
            x_dist_ordenes.ORDEN_UsrMod = x_usuario
            x_dist_ordenes.ORDEN_FecMod = _fecha

            Dim _update As New ACFramework.ACGenerador(Of EDIST_Ordenes)(_fecha, m_formatofecha)
            sql = _update.getUpdate(Esquema, Tabla, x_dist_ordenes, x_where, x_dist_ordenes.Hash, New String() {})

            Return sql
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function getUpdate(ByVal x_dist_ordenes As EDIST_Ordenes, ByVal x_where As Hashtable, ByVal x_usuario As String, ByVal x_setfecha() As String) As String
        Dim sql As String = ""
        Try
            Dim _fecha As DateTime = getDateTime()
            x_dist_ordenes.ORDEN_UsrMod = x_usuario
            x_dist_ordenes.ORDEN_FecMod = _fecha

            Dim _update As New ACFramework.ACGenerador(Of EDIST_Ordenes)(_fecha, m_formatofecha)
            Dim _where As New Hashtable()
            _where.Add("ORDEN_Codigo", New ACWhere(x_dist_ordenes.ORDEN_Codigo, ACWhere.TipoWhere.Igual))
            sql = _update.getUpdateFecha(Esquema, Tabla, x_dist_ordenes, _where, x_dist_ordenes.Hash, New String() {}, x_setfecha)

            Return sql
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function getUpdate(ByVal x_dist_ordenes As EDIST_Ordenes, ByVal x_where As Hashtable, ByVal x_usuario As String, ByVal x_excluir() As String, ByVal x_setfecha() As String) As String
        Dim sql As String = ""
        Try
            Dim _fecha As DateTime = getDateTime()
            x_dist_ordenes.ORDEN_UsrMod = x_usuario
            x_dist_ordenes.ORDEN_FecMod = _fecha

            Dim _update As New ACFramework.ACGenerador(Of EDIST_Ordenes)(_fecha, m_formatofecha)
            sql = _update.getUpdateFecha(Esquema, Tabla, x_dist_ordenes, x_where, x_dist_ordenes.Hash, x_excluir, x_setfecha)

            Return sql
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function getUpdate(ByVal x_dist_ordenes As EDIST_Ordenes, ByVal x_where As Hashtable, ByVal x_usuario As String, ByVal x_excluir() As String, ByVal x_setfecha() As String, ByVal x_setcampos() As String) As String
        Dim sql As String = ""
        Try
            Dim _fecha As DateTime = getDateTime()
            x_dist_ordenes.ORDEN_UsrMod = x_usuario
            x_dist_ordenes.ORDEN_FecMod = _fecha

            Dim _update As New ACFramework.ACGenerador(Of EDIST_Ordenes)(_fecha, m_formatofecha)
            sql = _update.getUpdate(Esquema, Tabla, x_dist_ordenes, x_where, x_dist_ordenes.Hash, x_excluir, x_setfecha, x_setcampos)

            Return sql
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function getDelete(ByVal x_dist_ordenes As EDIST_Ordenes) As String
        Dim sql As String = ""
        Try

            sql = " DELETE FROM Logistica.DIST_Ordenes" & vbNewLine
            sql &= " WHERE "
            sql &= "    ORDEN_Codigo = " & IIf(IsNothing(x_dist_ordenes.ORDEN_Codigo), "Null", "'" & x_dist_ordenes.ORDEN_Codigo & "'") & vbNewLine

            Return sql
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function getDelete(ByVal x_where As Hashtable) As String
        Dim sql As String = ""
        Try

            sql = " DELETE FROM Logistica.DIST_Ordenes" & vbNewLine
            sql &= " WHERE "
            Dim _where As New ACGenerador(Of EDIST_Ordenes)(m_formatofecha)
            sql &= _where.getWhere(x_where, True)

            Return sql
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function getSelectId(ByVal x_campo As String) As String
        Dim sql As String = ""
        Try

            sql = String.Format(" SELECT IsNull(Max({0}), 0) As Id From Logistica.DIST_Ordenes ", x_campo)

            Return sql
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function getSelectId(ByVal x_campo As String, ByVal x_where As Hashtable) As String
        Dim sql As String = ""
        Try

            sql = String.Format(" SELECT IsNull(Max({0}), 0) As Id From Logistica.DIST_Ordenes ", x_campo)
            sql &= " WHERE "
            Dim _where As New ACGenerador(Of EDIST_Ordenes)(m_formatofecha)
            sql &= _where.getWhere(x_where, True)

            Return sql
        Catch ex As Exception
            Throw ex
        End Try
    End Function

#End Region
#End Region

#Region " Metodos "

    Private Function getDate() As String
        Dim x_datos As New DataTable()
        Try
            DAEnterprise.AsignarProcedure("select GetDate()", CommandType.Text)
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
            DAEnterprise.AsignarProcedure("select GetDate()", CommandType.Text)
            x_datos = DAEnterprise.ExecuteDataSet().Tables(0)
            Dim _fecha As DateTime = x_datos.Rows(0)(0)
            Return _fecha
        Catch ex As Exception
            Throw ex
        End Try
    End Function

#End Region

End Class

