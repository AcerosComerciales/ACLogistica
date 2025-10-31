Imports ACELogistica
Imports ACDLogistica

Public Class BDestinos


#Region " Variables "

    Private m_destinos As EDestinos
    Private m_listDestinos As List(Of EDestinos)
    Private m_dtDestinos As DataTable

    Private m_dsDestinos As DataSet
    Private d_destinos As DDestinos


#End Region

#Region " Constructores "

    Public Sub New()
        d_destinos = New DDestinos()
    End Sub

#End Region

#Region " Propiedades "

    Public Property Destinos() As EDestinos
        Get
            Return m_destinos
        End Get
        Set(ByVal value As EDestinos)
            m_destinos = value
        End Set
    End Property
    Public Property ListDestinos() As List(Of EDestinos)
        Get
            Return m_listDestinos
        End Get
        Set(ByVal value As List(Of EDestinos))
            m_listDestinos = value
        End Set
    End Property
    Public Property DTDestinos() As DataTable
        Get
            Return m_dtDestinos
        End Get
        Set(ByVal value As DataTable)
            m_dtDestinos = value
        End Set
    End Property
    Public Property DSPeriodos() As DataSet
        Get
            Return m_dsDestinos
        End Get
        Set(ByVal value As DataSet)
            m_dsDestinos = value
        End Set
    End Property

#End Region

#Region " Funciones para obtencion de datos "


    Public Function getListDestinos() As List(Of EDestinos)
        Return Me.m_listDestinos
    End Function
    Public Sub setListDestinos(ByVal _listdestinos As List(Of EDestinos))
        Me.m_listDestinos = m_listDestinos
    End Sub
    Public Function getDestinos() As EDestinos
        Return Me.m_destinos
    End Function
    Public Sub setDestinos(ByVal x_destinos As EDestinos)
        Me.m_destinos = x_destinos
    End Sub
#End Region

#Region " Metodos "

    Public Function CargarTodos() As Boolean
        Try
            m_listDestinos = New List(Of EDestinos)()
            Return d_destinos.DESTINOSS_Todos(m_listDestinos)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function CargarTodos(ByVal x_where As Hashtable) As Boolean
        Try
            m_listDestinos = New List(Of EDestinos)()
            Return d_destinos.DESTINOSS_Todos(m_listDestinos, x_where)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function CargarTodos(ByVal x_join As List(Of ACFramework.ACJoin), ByVal x_where As Hashtable) As Boolean
        Try
            m_listDestinos = New List(Of EDestinos)()
            Return d_destinos.DESTINOSS_Todos(m_listDestinos, x_join, x_where)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function CargarTodos(ByVal x_join As List(Of ACFramework.ACJoin), ByVal x_where As Hashtable, ByVal x_distinct As Boolean) As Boolean
        Try
            m_listDestinos = New List(Of EDestinos)()
            Return d_destinos.DESTINOSS_Todos(m_listDestinos, x_join, x_where, x_distinct)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function CargarTodosDS(ByVal x_where As Hashtable) As Boolean
        Try
            m_dsDestinos = New DataSet()
            Return d_destinos.DESTINOSS_Todos(m_dsDestinos, x_where)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function CargarTodosDS(ByVal x_join As List(Of ACFramework.ACJoin), ByVal x_where As Hashtable) As Boolean
        Try
            m_dsDestinos = New DataSet()
            Return d_destinos.DESTINOSS_Todos(m_dsDestinos, x_join, x_where)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function CargarTodosDT(ByVal x_where As Hashtable) As Boolean
        Try
            m_dsDestinos = New DataSet()
            Dim _opcion As Boolean = d_destinos.DESTINOSS_Todos(m_dsDestinos, x_where)
            If _opcion Then
                m_dtDestinos = m_dsDestinos.Tables(0)
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    'Public Function CargarTodosDT(ByVal x_join As List(Of ACFramework.ACJoin), ByVal x_where As Hashtable) As Boolean
    '    Try
    '        m_dsDestinos = New DataSet()
    '        Dim _opcion As Boolean = d_destinos.DESTINOSS_Todos(m_dsDestinos, x_join, x_where)
    '        If _opcion Then
    '            m_dtDestinos = m_dsDestinos.Tables(0)
    '            Return True
    '        Else
    '            Return False
    '        End If
    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Function

    Public Function Cargar(ByVal x_perio_codigo As String) As Boolean
        Try
            m_destinos = New EDestinos()
            Return d_destinos.DESTINOSS_UnReg(m_destinos, x_perio_codigo)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function Cargar(ByVal x_where As Hashtable) As Boolean
        Try
            m_destinos = New EDestinos()
            Return d_destinos.DESTINOSS_UnReg(m_destinos, x_where)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    'Public Function Cargar(ByVal x_join As List(Of ACFramework.ACJoin), ByVal x_where As Hashtable) As Boolean
    '    Try
    '        m_destinos = New EDestinos()
    '        Return d_destinos.DESTINOSS_UnReg(m_destinos, x_join, x_where)
    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Function
    Public Function Guardar(ByVal x_usuario As String) As Boolean
        Try
            If m_destinos.Nuevo Then
                d_destinos.DESTINOSI_UnReg(m_destinos, x_usuario)
            ElseIf m_destinos.Modificado Then
                d_destinos.DESTINOSU_UnReg(m_destinos, x_usuario)
            ElseIf m_destinos.Eliminado Then
                d_destinos.DESTINOSD_UnReg(m_destinos)
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function Guardar(ByVal x_where As Hashtable, ByVal x_usuario As String) As Boolean
        Try
            If m_destinos.Nuevo Then
                d_destinos.DESTINOSI_UnReg(m_destinos, x_usuario)
            ElseIf m_destinos.Modificado Then
                d_destinos.DESTINOSU_UnReg(m_destinos, x_where, x_usuario)
            ElseIf m_destinos.Eliminado Then
                d_destinos.DESTINOSD_UnReg(x_where)
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function Guardar(ByVal x_where As Hashtable, ByVal x_usuario As String, ByVal x_excluir() As String, ByVal x_setfecha() As String) As Boolean
        Try
            If m_destinos.Nuevo Then
                d_destinos.DESTINOSI_UnReg(m_destinos, x_usuario, x_excluir, x_setfecha)
            ElseIf m_destinos.Modificado Then
                d_destinos.DESTINOSU_UnReg(m_destinos, x_where, x_usuario, x_excluir, x_setfecha)
            ElseIf m_destinos.Eliminado Then
                d_destinos.DESTINOSD_UnReg(m_destinos)
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function Guardar(ByVal x_where As Hashtable, ByVal x_usuario As String, ByVal x_excluir() As String, ByVal x_setfecha() As String, ByVal x_setcampos() As String) As Boolean
        Try
            If m_destinos.Nuevo Then
                d_destinos.DESTINOSI_UnReg(m_destinos, x_usuario, x_excluir, x_setfecha)
            ElseIf m_destinos.Modificado Then
                d_destinos.DESTINOSU_UnReg(m_destinos, x_where, x_usuario, x_excluir, x_setfecha, x_setcampos)
            ElseIf m_destinos.Eliminado Then
                d_destinos.DESTINOSD_UnReg(m_destinos)
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function Guardar(ByVal x_usuario As String, ByVal x_setfecha() As String) As Boolean
        Try
            If m_destinos.Nuevo Then
                d_destinos.DESTINOSI_UnReg(m_destinos, x_usuario, x_setfecha)
            ElseIf m_destinos.Modificado Then
                d_destinos.DESTINOSU_UnReg(m_destinos, x_usuario, x_setfecha)
            ElseIf m_destinos.Eliminado Then
                d_destinos.DESTINOSD_UnReg(m_destinos)
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function Guardar(ByVal x_usuario As String, ByVal x_excluir() As String, ByVal x_setfecha() As String) As Boolean
        Try
            If m_destinos.Nuevo Then
                d_destinos.DESTINOSI_UnReg(m_destinos, x_usuario, x_excluir, x_setfecha)
            ElseIf m_destinos.Eliminado Then
                d_destinos.DESTINOSD_UnReg(m_destinos)
            End If
            Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function Eliminar(ByVal x_where As Hashtable) As Boolean
        Try
            m_listDestinos = New List(Of EDestinos)()
            Return d_destinos.DESTINOSD_UnReg(x_where) > 0
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function getCorrelativo(ByVal x_campo As String) As Integer
        Try
            Return d_destinos.getCorrelativo(x_campo) + 1
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function getCorrelativo(ByRef x_id As Integer, ByVal x_campo As String) As Integer
        Try
            x_id = d_destinos.getCorrelativo(x_campo)
            Return (x_id + 1)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function getCorrelativo(ByVal x_campo As String, ByVal x_where As Hashtable) As Integer
        Try
            Return d_destinos.getCorrelativo(x_campo, x_where) + 1
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Public Function getCorrelativo(ByRef x_id As Integer, ByVal x_campo As String, ByVal x_where As Hashtable) As Integer
        Try
            x_id = d_destinos.getCorrelativo(x_campo, x_where)
            Return (x_id + 1)
        Catch ex As Exception
            Throw ex
        End Try
    End Function

#End Region

End Class
