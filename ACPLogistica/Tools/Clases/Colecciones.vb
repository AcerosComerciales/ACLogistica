Imports System
Imports System.Threading
Imports System.Collections.Generic

Imports ACFramework
Imports ACELogistica
Imports ACBLogistica
Imports ACBVentas
Imports ACEVentas

Imports Microsoft.Practices.Unity
Imports Microsoft.Practices.Unity.Configuration

Imports Microsoft.VisualBasic.PowerPacks.Printing.Compatibility.VB6
Imports DAConexion
Imports System.Data.Common

Public Class Colecciones
    Private Shared m_mutex As New Mutex()
    Private Shared m_instance As Colecciones = Nothing


    Enum TipoInicializacion
        Todos
        Tipos
        Sucursales
        Ubigeos
        Otros
        NroCuentas
        Destinos
    End Enum


#Region " Definicion Clase "
    Private Sub New()
        m_listTipos = New List(Of ACEVentas.ETipos)()
        m_listEstados = New List(Of Lista)()
        m_listEstadosProgramacion = New List(Of Lista)()
        m_listEstadosEntrega = New List(Of Lista)()
        m_listGestionados = New List(Of Lista)()
        m_listTiposDocumento = New List(Of Lista)()
        m_listPedidos = New List(Of Lista)
        m_listUbigeo = New List(Of EUbigeos)()
        m_listNroCuentas = New List(Of ECuentas)()
        m_listPuntoVenta = New List(Of EPuntoVenta)
        m_listDestinos = New List(Of EDestinos)
    End Sub

    ''' <summary>
    ''' Inicializa la instancia de la clase Colecciones
    ''' </summary>
    ''' <returns>Retorna la instancia que se utilizara para llamar a Colecciones</returns>
    ''' <remarks>Una vez inicializada la clase Colecciones se podrán utilizar la colecciones que se carguen</remarks>

    Public Shared Function Inicializar(Optional ByVal x_cargar As Boolean = False) As Colecciones
        m_mutex.WaitOne()
        Try
            If m_instance Is Nothing Then
                m_instance = New Colecciones()
            End If
            ' Cargar las colecciones
            If x_cargar Then
                GetTodosTipos()
                GetTiposDocumento()
                GetEstados()
                GetEstadosProgramacion()
                GetEstadosEntrega()
                GetEstadoGestionado()
                GetTipoPedido()
                GetUbigeos()
                GetSucursales()
                GetPuntosVenta()
                GetZonas()
                GetAlmacenes()
                getListaPrecios()
                GetEstadoEntrega()

                GetNroCuentas()
                GetNroCuentasDT()
                GetPuntosVenta()
                GetPeriodos()
                GetEstadoEntregaOrden()

                GetDestinos()
            Else
                GetTodosTipos()
                GetTiposDocumento()
            End If
            m_errores = ACUtilitarios.cargarErrores()
        Catch ex As Exception
            Throw ex
        Finally
            m_mutex.ReleaseMutex()
        End Try
        Return m_instance
    End Function

    Public Shared Function Inicializar(ByVal x_opcion As TipoInicializacion) As Colecciones
        m_mutex.WaitOne()
        Try
            If m_instance Is Nothing Then
                m_instance = New Colecciones()
            End If
            ' Cargar las colecciones
            If x_opcion = TipoInicializacion.Tipos Or x_opcion = TipoInicializacion.Todos Then
                GetTodosTipos()
            End If

            If x_opcion = TipoInicializacion.Sucursales Or x_opcion = TipoInicializacion.Todos Then
                GetSucursales()
            End If

            If x_opcion = TipoInicializacion.Ubigeos Or x_opcion = TipoInicializacion.Todos Then
                GetUbigeos()
            End If

            If x_opcion = TipoInicializacion.Otros Or x_opcion = TipoInicializacion.Todos Then
                GetTiposDocumento()
                GetEstados()
                GetEstadosProgramacion()
                GetEstadosEntrega()
                GetEstadoGestionado()
                GetTipoPedido()
            End If

            If x_opcion = TipoInicializacion.NroCuentas Or x_opcion = TipoInicializacion.Todos Then
                GetNroCuentas()
            End If

            m_errores = ACUtilitarios.cargarErrores()
        Catch ex As Exception
            Throw ex
        Finally
            m_mutex.ReleaseMutex()
        End Try
        Return m_instance
    End Function
#End Region

#Region " Errores Personalizados "
    Private Shared m_errores As Hashtable
    Public Shared Function getError(ByVal x_codigo As String) As String
        Return ACUtilitarios.getError(x_codigo)
    End Function

#End Region

#Region " Productos "

#End Region

#Region " Servicios "

#End Region

#Region " Puntos de Venta "
    Private Shared m_listPuntoVenta As List(Of EPuntoVenta)
    Private Shared m_listPuntoVentaxalma As List(Of EPuntoVenta)
    Public Shared ReadOnly Property PuntosVenta() As List(Of EPuntoVenta)
        Get
            Return m_listPuntoVenta
        End Get
    End Property
    Public Shared ReadOnly Property PuntosVentaxAlmacen() As List(Of EPuntoVenta)
        Get
            Return m_listPuntoVentaxalma
        End Get
    End Property

    Public Shared ReadOnly Property PuntosVentaDespachos() As List(Of EPuntoVenta)
        Get
            Dim _filter As New ACFiltrador(Of EPuntoVenta)(String.Format("PVENT_ActivoDespachos=TRUE"))
            Return _filter.ACFiltrar(m_listPuntoVenta)
        End Get
    End Property
    Public Shared Sub GetPuntosVenta()
        Try
            Dim managerPuntosVenta As BPuntoVenta
            managerPuntosVenta = New BPuntoVenta
            Dim _Join As New List(Of ACJoin)()
            _Join.Add(New ACJoin(ESucursales.Esquema, ESucursales.Tabla, ACJoin.TipoJoin.Inner _
                              , New ACCampos() {New ACCampos("SUCUR_Id", "SUCUR_Id")} _
                              , New ACCampos() {New ACCampos("SUCUR_Nombre", "SUCUR_Nombre")}))
            _Join.Add(New ACJoin(EAlmacenes.Esquema, EAlmacenes.Tabla, ACJoin.TipoJoin.Inner _
                              , New ACCampos() {New ACCampos("ALMAC_Id", "ALMAC_Id")} _
                              , New ACCampos() {New ACCampos("ALMAC_Descripcion", "ALMAC_Nombre")}))
            Dim _where As New Hashtable()
            _where.Add("PVENT_Descripcion", New ACWhere("", ACWhere.TipoWhere._Like))
            
            If managerPuntosVenta.CargarTodos(_Join, _where) Then
                m_listPuntoVenta = New List(Of EPuntoVenta)(managerPuntosVenta.ListPuntoVenta)
            Else
                m_listPuntoVenta = New List(Of EPuntoVenta)()
            End If
        Catch ex As Exception
            Throw New Exception(String.Format("Error: No se han podido obtener las sucursales.{0}[{1}]", Environment.NewLine, ex.Message))
        End Try
    End Sub

       Public Shared Sub GetPuntosVentaExceptuandoPuntoLocal()
        Try
            Dim managerPuntosVenta As BPuntoVenta
            managerPuntosVenta = New BPuntoVenta
            Dim _Join As New List(Of ACJoin)()
            _Join.Add(New ACJoin(ESucursales.Esquema, ESucursales.Tabla, ACJoin.TipoJoin.Inner _
                              , New ACCampos() {New ACCampos("SUCUR_Id", "SUCUR_Id")} _
                              , New ACCampos() {New ACCampos("SUCUR_Nombre", "SUCUR_Nombre")}))
            _Join.Add(New ACJoin(EAlmacenes.Esquema, EAlmacenes.Tabla, ACJoin.TipoJoin.Inner _
                              , New ACCampos() {New ACCampos("ALMAC_Id", "ALMAC_Id")} _
                              , New ACCampos() {New ACCampos("ALMAC_Descripcion", "ALMAC_Nombre")}))
            Dim _where As New Hashtable()
            _where.Add("PVENT_Descripcion", New ACWhere("", ACWhere.TipoWhere._Like))
            _where.Add("SUCUR_Id",New ACWhere(GApp.ESucursal.SUCUR_Id,ACWhere.TipoWhere.Diferente))
            
            If managerPuntosVenta.CargarTodos(_Join, _where) Then
                m_listPuntoVenta = New List(Of EPuntoVenta)(managerPuntosVenta.ListPuntoVenta)
            Else
                m_listPuntoVenta = New List(Of EPuntoVenta)()
            End If
        Catch ex As Exception
            Throw New Exception(String.Format("Error: No se han podido obtener las sucursales.{0}[{1}]", Environment.NewLine, ex.Message))
        End Try
    End Sub


    'EXCEPTION DISCRIMAOOMP POR ALMACEN EN VEZ DE PUNTO VENTA SPOR ORIGEN 


    Public Shared Sub GetPuntosVentaExcepcionXAlmacenOrigen()
        Try
            DAEnterprise.AsignarProcedure("ExtraerPuntoVentaOrdenesOrigen")

            Using reader As DbDataReader = DAEnterprise.ExecuteDataReader()
                If reader.HasRows Then
                    While reader.Read()
                        Dim _putoVenta As New EPuntoVenta()
                        ACEsquemas.ACCargarEsquema(reader, _putoVenta)
                        _putoVenta.Instanciar(ACEInstancia.Consulta)
                        m_listPuntoVenta.Add(_putoVenta)
                    End While
                    'Return True
                Else
                    'Return False
                End If
            End Using
            'Return True
        Catch ex As Exception
            Throw ex
        End Try
    End Sub


    'Try
    'Dim managerPuntosVenta As BPuntoVenta
    '        managerPuntosVenta = New BPuntoVenta
    '        Dim _Join As New List(Of ACJoin)()
    '        _Join.Add(New ACJoin(ESucursales.Esquema, ESucursales.Tabla, ACJoin.TipoJoin.Inner _
    '                          , New ACCampos() {New ACCampos("SUCUR_Id", "SUCUR_Id")} _
    '                          , New ACCampos() {New ACCampos("SUCUR_Nombre", "SUCUR_Nombre")}))
    '        _Join.Add(New ACJoin(EAlmacenes.Esquema, EAlmacenes.Tabla, ACJoin.TipoJoin.Inner _
    '                          , New ACCampos() {New ACCampos("ALMAC_Id", "ALMAC_Id")} _
    '                          , New ACCampos() {New ACCampos("ALMAC_Descripcion", "ALMAC_Nombre")}))
    '        Dim _where As New Hashtable()
    '        _where.Add("PVENT_Id", New ACWhere(GApp.ESucursal.SUCUR_Id, ACWhere.TipoWhere.Diferente))
    '        _where.Add("PVENT_Id", New ACWhere(3, ACWhere.TipoWhere.Diferente))
    '        If managerPuntosVenta.CargarTodos(_Join, _where) Then
    '            m_listPuntoVenta = New List(Of EPuntoVenta)(managerPuntosVenta.ListPuntoVenta)
    '        Else
    '            m_listPuntoVenta = New List(Of EPuntoVenta)()
    '        End If
    'Catch ex As Exception
    'Throw New Exception(String.Format("Error: No se han podido obtener las sucursales.{0}[{1}]", Environment.NewLine, ex.Message))
    'End Try



    'EXCEPTURAMOS ODISCRIMINAMOS POR ALAMCEN EN VEZ DE UNTO VENTA  POR DESTINO

    Public Shared Sub GetPuntosVentaExcepcionXAlmacenDestino()
        Try
            Dim managerPuntosVenta As BPuntoVenta
            managerPuntosVenta = New BPuntoVenta
            Dim _Join As New List(Of ACJoin)()
            _Join.Add(New ACJoin(ESucursales.Esquema, ESucursales.Tabla, ACJoin.TipoJoin.Inner _
                              , New ACCampos() {New ACCampos("SUCUR_Id", "SUCUR_Id")} _
                              , New ACCampos() {New ACCampos("SUCUR_Nombre", "SUCUR_Nombre")}))
            _Join.Add(New ACJoin(EAlmacenes.Esquema, EAlmacenes.Tabla, ACJoin.TipoJoin.Inner _
                              , New ACCampos() {New ACCampos("ALMAC_Id", "ALMAC_Id")} _
                              , New ACCampos() {New ACCampos("ALMAC_Descripcion", "ALMAC_Nombre")}))
            Dim _where As New Hashtable()
            _where.Add("PVENT_Id", New ACWhere(GApp.EPuntoVenta.PVENT_Id, ACWhere.TipoWhere.Diferente))
            '_where.Add("PVENT_Id", New ACWhere("", ACWhere.TipoWhere.Diferente))
            '_where.Add("ALMAC_Id", New ACWhere("", ACWhere.TipoWhere.Diferente))
            If managerPuntosVenta.CargarTodos(_Join, _where) Then
                m_listPuntoVenta = New List(Of EPuntoVenta)(managerPuntosVenta.ListPuntoVenta)
            Else
                m_listPuntoVenta = New List(Of EPuntoVenta)()
            End If
        Catch ex As Exception
            Throw New Exception(String.Format("Error: No se han podido obtener las sucursales.{0}[{1}]", Environment.NewLine, ex.Message))
        End Try
    End Sub




    Public Shared Sub GetPuntoVentaxAlmacen(ByVal _almacen As String)
        Try
            Dim managerPuntosVenta As New BPuntoVenta
            Dim _where As New Hashtable()
            _where.Add("PVENT_Activo", New ACWhere(True, ACWhere.TipoWhere.Igual))
            _where.Add("ALMAC_Id", New ACWhere(_almacen, ACWhere.TipoWhere.Igual))
            _where.Add("PVENT_Id", New ACWhere(9, ACWhere.TipoWhere.Diferente))
            If managerPuntosVenta.CargarTodos(_where) Then
                m_listPuntoVentaxalma = New List(Of EPuntoVenta)(managerPuntosVenta.ListPuntoVenta)
            Else
                m_listPuntoVentaxalma = New List(Of EPuntoVenta)()
            End If
        Catch ex As Exception
            Throw New Exception(String.Format("Error: No se han podido obtener los punto de venta por almacen.{0}[{1}]", Environment.NewLine, ex.Message))
        End Try


    End Sub







#End Region

#Region " Sucursales "
    Private Shared m_listSucursales As List(Of ESucursales)
    Public Shared ReadOnly Property Sucursales() As List(Of ESucursales)
        Get
            Return m_listSucursales
        End Get
    End Property

    Public Shared Sub GetSucursales()
        Try
            Dim managerBSucursales As BSucursales
            managerBSucursales = New BSucursales
            If managerBSucursales.CargarTodos() Then
                m_listSucursales = New List(Of ESucursales)(managerBSucursales.ListSucursales)
            Else
                m_listSucursales = New List(Of ESucursales)()
            End If
        Catch ex As Exception
            Throw New Exception(String.Format("Error: No se han podido obtener las sucursales.{0}[{1}]", Environment.NewLine, ex.Message))
        End Try
    End Sub
#End Region

#Region " Zonas "
    Private Shared m_listZonas As List(Of EZonas)
    Public Shared ReadOnly Property Zonas() As List(Of EZonas)
        Get
            Return m_listZonas
        End Get
    End Property

    Public Shared Sub GetZonas()
        Try
            Dim managerZonas As BZonas
            managerZonas = New BZonas
            If managerZonas.CargarTodos() Then
                m_listZonas = New List(Of EZonas)(managerZonas.ListZonas)
            Else
                m_listZonas = New List(Of EZonas)()
            End If
        Catch ex As Exception
            Throw New Exception(String.Format("Error: No se han podido obtener las zonas.{0}[{1}]", Environment.NewLine, ex.Message))
        End Try
    End Sub
#End Region

#Region " Almacenes "
    Private Shared m_listAlmacenes As List(Of EAlmacenes)
    Public Shared ReadOnly Property Almacenes() As List(Of EAlmacenes)
        Get
            Return m_listAlmacenes
        End Get
    End Property

    Public Shared Sub GetAlmacenes()
        Try
            Dim managerBAlmacenes As BAlmacenes
            managerBAlmacenes = New BAlmacenes
            Dim _join As New List(Of ACJoin)
            _join.Add(New ACJoin(EPuntoVenta.Esquema, EPuntoVenta.Tabla, ACJoin.TipoJoin.Inner,
                                 New ACCampos() {New ACCampos("ALMAC_Id", "ALMAC_Id")},
                                 New ACCampos() {New ACCampos("PVENT_DireccionIP", "PVENT_DireccionIP"), New ACCampos("PVENT_BaseDatos", "PVENT_BaseDatos"),
                                                 New ACCampos("PVENT_BDAdmin", "PVENT_BDAdmin"), New ACCampos("PVENT_DireccionIPDesc", "PVENT_DireccionIPDesc")}))
            Dim _where As New Hashtable
            If managerBAlmacenes.CargarTodos(_join, _where) Then
                m_listAlmacenes = New List(Of EAlmacenes)(managerBAlmacenes.ListAlmacenes)
            Else
                m_listAlmacenes = New List(Of EAlmacenes)()
            End If
        Catch ex As Exception
            Throw New Exception(String.Format("Error: No se han podido obtener los Tipos.{0}[{1}]", Environment.NewLine, ex.Message))
        End Try
    End Sub
    Private Shared m_listAlmacenesAcceso As List(Of EAlmacenes)
    Public Shared ReadOnly Property AlmacenesAcceso() As List(Of EAlmacenes)
        Get
            Return m_listAlmacenesAcceso
        End Get
    End Property
    Public Shared Sub GetAlmacenesAcceso()
        Try
            Dim managerBAlmacenes As BAlmacenes
            managerBAlmacenes = New BAlmacenes()
            Dim _join As New List(Of ACJoin)
            _join.Add(New ACJoin(EPuntoVenta.Esquema, EPuntoVenta.Tabla, "PVent", ACJoin.TipoJoin.Inner,
                                 New ACCampos() {New ACCampos("ALMAC_Id", "ALMAC_Id")},
                                 New ACCampos() {New ACCampos("PVENT_DireccionIP", "PVENT_DireccionIP"), New ACCampos("PVENT_BaseDatos", "PVENT_BaseDatos"),
                                                 New ACCampos("PVENT_BDAdmin", "PVENT_BDAdmin"), New ACCampos("PVENT_DireccionIPDesc", "PVENT_DireccionIPDesc"),
                                                 New ACCampos("PVENT_Principal", "PVENT_Principal")}))
            Dim _where As New Hashtable
            '_where.Add("ZONAS_Codigo", New ACWhere(GApp.Zona))
            If managerBAlmacenes.CargarTodos(_join, _where) Then
                Dim _filter As New ACFiltrador(Of EAlmacenes)(String.Format("PVENT_Principal={0}", True))
                m_listAlmacenesAcceso = New List(Of EAlmacenes)()
                For Each item As EAlmacenes In _filter.ACFiltrar(managerBAlmacenes.ListAlmacenes)
                    If item.ALMAC_Id <> GApp.Almacen Then
                        m_listAlmacenesAcceso.Add(item.Clone)
                    End If
                Next
            Else
                m_listAlmacenesAcceso = New List(Of EAlmacenes)()
            End If
        Catch ex As Exception
            Throw New Exception(String.Format("Error: No se han podido obtener los Almacenes.{0}[{1}]", Environment.NewLine, ex.Message))
        End Try
    End Sub

    Public Shared Sub GetAlmacenesAccesoTodos()
        Try
            Dim managerBAlmacenes As BAlmacenes
            managerBAlmacenes = New BAlmacenes()
            Dim _join As New List(Of ACJoin)
            _join.Add(New ACJoin(EPuntoVenta.Esquema, EPuntoVenta.Tabla, "PVent", ACJoin.TipoJoin.Inner,
                                 New ACCampos() {New ACCampos("ALMAC_Id", "ALMAC_Id")},
                                 New ACCampos() {New ACCampos("PVENT_DireccionIP", "PVENT_DireccionIP"), New ACCampos("PVENT_BaseDatos", "PVENT_BaseDatos"),
                                                 New ACCampos("PVENT_BDAdmin", "PVENT_BDAdmin"), New ACCampos("PVENT_DireccionIPDesc", "PVENT_DireccionIPDesc"),
                                                 New ACCampos("PVENT_Principal", "PVENT_Principal")}))
            Dim _where As New Hashtable
            '_where.Add("ZONAS_Codigo", New ACWhere(GApp.Zona))
            If managerBAlmacenes.CargarTodos(_join, _where) Then
                Dim _filter As New ACFiltrador(Of EAlmacenes)(String.Format("PVENT_Principal={0}", True))
                m_listAlmacenesAcceso = New List(Of EAlmacenes)()
                For Each item As EAlmacenes In _filter.ACFiltrar(managerBAlmacenes.ListAlmacenes)

                    m_listAlmacenesAcceso.Add(item.Clone)

                Next
            Else
                m_listAlmacenesAcceso = New List(Of EAlmacenes)()
            End If
        Catch ex As Exception
            Throw New Exception(String.Format("Error: No se han podido obtener los Almacenes.{0}[{1}]", Environment.NewLine, ex.Message))
        End Try
    End Sub



#End Region

#Region " Estado de Entrega "
    Private Shared m_listEstadoEntrega As List(Of ACFramework.ACLista)

    Public Shared ReadOnly Property ListEstadoEntrega() As List(Of ACFramework.ACLista)
        Get
            Return m_listEstadoEntrega
        End Get
    End Property

    Private Shared Sub GetEstadoEntrega()
        Try
            m_listEstadoEntrega = New List(Of ACLista)
            m_listEstadoEntrega.Add(New ACFramework.ACLista("E", "Entrega Directa"))
            m_listEstadoEntrega.Add(New ACFramework.ACLista("P", "Pendiente de Orden / Guia"))
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Enum TEntrega
        EntregaDirecta
        Pendiente
    End Enum
    Public Shared Function GetEntrega(ByVal x_tipo As TEntrega) As String
        Select Case x_tipo
            Case TEntrega.EntregaDirecta
                Return "E"
            Case TEntrega.Pendiente
                Return "P"
            Case Else
                Return "E"
        End Select
    End Function


#End Region

#Region " Impresoras "
    Private Shared m_listPrinters As List(Of Printer)


    Private Shared m_printerdefault As String
    Public Shared ReadOnly Property PrinterDefault() As String
        Get
            Return m_printerdefault
        End Get
    End Property

    Public Shared Sub CargarImpresoras()
        m_listPrinters = New List(Of Printer)
        For index As Integer = 0 To Printers.Count - 1
            Try
                m_listPrinters.Add(Printers(index))
                If Printers(index).IsDefaultPrinter Then m_printerdefault = Printers(index).DeviceName
            Catch ex As Exception
            End Try
        Next
    End Sub

    Public Shared ReadOnly Property ListPrinter() As List(Of Printer)
        Get
            Return m_listPrinters
        End Get
    End Property

#End Region

#Region "NroCuentas"
    Private Shared m_listNroCuentas As List(Of ECuentas)
    Private Shared m_dtCuentas As DataTable

    Public Shared ReadOnly Property NroCuentas() As List(Of ECuentas)
        Get
            Return m_listNroCuentas
        End Get
    End Property

    Public Shared ReadOnly Property NroCuentasDT() As DataTable
        Get
            Return m_dtCuentas
        End Get
    End Property

    'Public Shared Sub GetNroCuentas()
    '    Try
    '        Dim managerBCuentas As IBCuentas
    '        managerBCuentas = Principal.containerB.Resolve(Of IBCuentas)("cuentasDAO")
    '        If managerBCuentas.CargarTodos() Then
    '            m_listNroCuentas = New List(Of ECuentas)(managerBCuentas.ListCuentas)
    '            m_dtCuentas = managerBCuentas.CuentasDT '
    '        Else
    '            m_listNroCuentas = New List(Of ECuentas)()
    '            m_dtCuentas = New DataTable() '
    '        End If
    '    Catch ex As Exception
    '        Throw New Exception(String.Format("Error: No se han podido obtener los nros cuentas.{0}[{1}]", Environment.NewLine, ex.Message))
    '    End Try
    'End Sub
    ''

    Public Shared Sub GetNroCuentas()
        Try
            Dim managerBNroCuentas As New BCuentas

            If managerBNroCuentas.CargarTodos() Then
                m_listNroCuentas = New List(Of ECuentas)(managerBNroCuentas.ListCuentas)
            Else
                m_listNroCuentas = New List(Of ECuentas)()
            End If
        Catch ex As Exception
            Throw New Exception(String.Format("Error: No se han podido obtener los Nro de cuentas.{0}[{1}]", Environment.NewLine, ex.Message))
        End Try
    End Sub
    ''

    Public Shared Sub GetNroCuentasDT()
        Try
            Dim managerCuentas As New BCuentas

            If managerCuentas.CargarTodos() Then
                m_dtCuentas = managerCuentas.CargarTodosDT()
                m_dtCuentas.Columns("CUENT_Id").ColumnName = "CODIGO"
                m_dtCuentas.Columns("CUENT_Numero").ColumnName = "NUMERO"
            Else
                m_dtCuentas = New DataTable()
            End If

        Catch ex As Exception
            Throw New Exception("Error: No se han podido obtener los bancos." + Environment.NewLine + "[" + ex.Message + "]")
        End Try
    End Sub
#End Region

#Region " Tipos "

    Private Shared m_listTipos As List(Of ACEVentas.ETipos)

    Public Shared ReadOnly Property Tipos() As List(Of ACEVentas.ETipos)
        Get
            Return m_listTipos
        End Get
    End Property

    Public Shared ReadOnly Property Tipos(ByVal x_opcion As ACEVentas.ETipos.MyTipos) As List(Of ACEVentas.ETipos)
        Get
            Dim _filter As New ACFiltrador(Of ACEVentas.ETipos)() With {.ACFiltro = String.Format("TIPOS_Codigo={0}%", ACEVentas.ETipos.getCodTipo(x_opcion))}
            If ACEVentas.ETipos.getCodTipo(x_opcion).Equals("TIP") Then
                _filter.ACFiltrar(m_listTipos)
                Dim _filter2 As New ACFiltrador(Of ACEVentas.ETipos)() With {.ACFiltro = " TIPOS_Protegido=False"}
                Return _filter2.ACFiltrar(_filter.ACListaFiltrada)
            End If
            Return _filter.ACFiltrar(m_listTipos)
        End Get
    End Property

    Public Shared Sub GetTodosTipos()
        Try
            Dim managerTipos As BTipos
            managerTipos = New BTipos
            If managerTipos.CargarTodos() Then
                m_listTipos = New List(Of ACEVentas.ETipos)(managerTipos.ListTipos)
            Else
                m_listTipos = New List(Of ACEVentas.ETipos)()
            End If
        Catch ex As Exception
            Throw New Exception(String.Format("Error: No se han podido obtener los Tipos.{0}[{1}]", Environment.NewLine, ex.Message))
        End Try
    End Sub

    Public Shared Function GetTipos(ByVal x_tipo_codtabla As String) As List(Of ACEVentas.ETipos)
        Try
            Dim _filtrador As New ACFiltrador(Of ACEVentas.ETipos)() With {.ACFiltro = String.Format("TIPOS_Codigo={0}%", x_tipo_codtabla)}
            Return _filtrador.ACFiltrar(m_listTipos)
        Catch ex As Exception
            Throw New Exception(String.Format("Error: No se han podido obtener los Tipos.{0}[{1}]", Environment.NewLine, ex.Message))
        End Try
    End Function

    Public Shared ReadOnly Property TiposDocComprobante()
        Get
            Dim _filter As New ACFiltrador(Of ACEVentas.ETipos)() With {.ACFiltro = String.Format("TIPOS_Codigo={0}%", ACEVentas.ETipos.getCodTipo(ACEVentas.ETipos.MyTipos.TipoDocComprobante))}
            Dim _filter2 As New ACFiltrador(Of ACEVentas.ETipos)() With {.ACFiltro = "TIPOS_Numero<6"}
            _filter.ACFiltrar(m_listTipos)
            Return _filter2.ACFiltrar(_filter.ACListaFiltrada)
        End Get
    End Property


    Public Shared ReadOnly Property TiposDocCompFacturacion() As List(Of ETipos)
        Get
            Dim _filter As New ACFiltrador(Of ETipos)() With {.ACFiltro = String.Format("TIPOS_Codigo={0}%", ETipos.getCodTipo(ETipos.MyTipos.TipoDocComprobante))}
            Dim _filter2 As New ACFiltrador(Of ETipos)() With {.ACFiltro = "TIPOS_NVentas=5"}
            _filter.ACFiltrar(m_listTipos)
            Return _filter2.ACFiltrar(_filter.ACListaFiltrada)
        End Get
    End Property

    Public Shared ReadOnly Property TiposDocMerTransito()
        Get
            Dim _filter As New ACFiltrador(Of ACEVentas.ETipos)() With {.ACFiltro = String.Format("TIPOS_Codigo={0}%", ACEVentas.ETipos.getCodTipo(ACEVentas.ETipos.MyTipos.TipoDocComprobante))}
            Dim _filter2 As New ACFiltrador(Of ACEVentas.ETipos)() With {.ACFiltro = "TIPOS_NLogistica=5"}
            _filter.ACFiltrar(m_listTipos)
            Return _filter2.ACFiltrar(_filter.ACListaFiltrada)
        End Get
    End Property

    Public Shared ReadOnly Property TiposNotasCredito()
        Get
            Dim _filter As New ACFiltrador(Of ACEVentas.ETipos)() With {.ACFiltro = String.Format("TIPOS_Codigo={0}%", ACEVentas.ETipos.getCodTipo(ACEVentas.ETipos.MyTipos.TipoDocComprobante))}
            Dim _filter2 As New ACFiltrador(Of ACEVentas.ETipos)() With {.ACFiltro = "TIPOS_Numero=7"}
            _filter.ACFiltrar(m_listTipos)
            Return _filter2.ACFiltrar(_filter.ACListaFiltrada)
        End Get
    End Property

    Public Shared ReadOnly Property TiposUniMedDecimal()
        Get
            Dim _filter As New ACFiltrador(Of ACEVentas.ETipos)() With {.ACFiltro = String.Format("TIPOS_Codigo={0}%", ACEVentas.ETipos.getCodTipo(ACEVentas.ETipos.MyTipos.TipoUnidad))}
            Dim _filter2 As New ACFiltrador(Of ACEVentas.ETipos)() With {.ACFiltro = "TIPOS_Numero=1"}
            _filter.ACFiltrar(m_listTipos)
            Return _filter2.ACFiltrar(_filter.ACListaFiltrada)
        End Get
    End Property

    Public Shared ReadOnly Property TiposDocNotas() As List(Of ACEVentas.ETipos)
        Get
            Dim _filter As New ACFiltrador(Of ACEVentas.ETipos)() With {.ACFiltro = String.Format("TIPOS_Codigo={0}%", ACEVentas.ETipos.getCodTipo(ACEVentas.ETipos.MyTipos.TipoDocComprobante))}
            Dim _filter2 As New ACFiltrador(Of ACEVentas.ETipos)() With {.ACFiltro = "TIPOS_Numero=7"}
            _filter.ACFiltrar(m_listTipos)
            Return _filter2.ACFiltrar(_filter.ACListaFiltrada)
        End Get
    End Property

    Public Shared ReadOnly Property TiposDeArreglo()
        Get
            Dim _filter As New ACFiltrador(Of ACEVentas.ETipos)() With {.ACFiltro = String.Format("TIPOS_Codigo={0}%", ACEVentas.ETipos.getCodTipo(ACEVentas.ETipos.MyTipos.TipoDeArreglo))}
            Return _filter.ACFiltrar(m_listTipos)
        End Get
    End Property

    Public Shared ReadOnly Property TiposDocsTraslado() As List(Of ACEVentas.ETipos)
        Get
            Dim _filter As New ACFiltrador(Of ACEVentas.ETipos)() With {.ACFiltro = String.Format("TIPOS_Codigo={0}%", ACEVentas.ETipos.getCodTipo(ACEVentas.ETipos.MyTipos.TipoDocComprobante))}
            Dim _filter2 As New ACFiltrador(Of ACEVentas.ETipos)() With {.ACFiltro = "TIPOS_Numero=8"}
            Dim _filter3 As New ACFiltrador(Of ACEVentas.ETipos)() With {.ACFiltro = "TIPOS_Codigo=CPD09"}
            _filter.ACFiltrar(m_listTipos)
            _filter2.ACFiltrar(_filter.ACListaFiltrada)
            _filter3.ACFiltrar(_filter.ACListaFiltrada)
            For Each Item As ACEVentas.ETipos In _filter3.ACListaFiltrada
                _filter2.ACListaFiltrada.Add(Item)
            Next
            Return _filter2.ACListaFiltrada
        End Get
    End Property
#End Region

#Region " Tipos de Datos Genericos"

#Region "Variables"
    Private Shared m_listTiposDocumento As List(Of Lista)
    Private Shared m_listEstados As List(Of Lista)
    Private Shared m_listEstadosProgramacion As List(Of Lista)
    Private Shared m_listEstadosEntrega As List(Of Lista)
    Private Shared m_listGestionados As List(Of Lista)
    Private Shared m_listPedidos As List(Of Lista)
#End Region

#Region "Propiedades"
    Public Shared ReadOnly Property TiposDocumento() As List(Of Lista)
        Get
            Return m_listTiposDocumento
        End Get
    End Property

    Public Shared ReadOnly Property Estados() As List(Of Lista)
        Get
            Return m_listEstados
        End Get
    End Property

    Public Shared ReadOnly Property EstadosProgramacion() As List(Of Lista)
        Get
            Return m_listEstadosProgramacion
        End Get
    End Property

    Public Shared ReadOnly Property EstadosEntrega() As List(Of Lista)
        Get
            Return m_listEstadosEntrega
        End Get
    End Property

    Public Shared ReadOnly Property EstadoGestionados() As List(Of Lista)
        Get
            Return m_listGestionados
        End Get
    End Property

    Public Shared ReadOnly Property TipoPedidos() As List(Of Lista)
        Get
            Return m_listPedidos
        End Get
    End Property
#End Region

#Region "Metodos"
    Public Shared Sub GetTiposDocumento()
        Try
            m_listTiposDocumento = New List(Of Lista)
        Catch
            Throw New Exception("Error: No se han podido obtener los Estados.")
        End Try
    End Sub

    Public Shared Sub GetEstados()
        Try
            m_listEstados = New List(Of Lista)
            ' INGRESADO
            m_listEstados.Add(New Lista("I", "INGRESADO"))
            ' CONFIRMADO
            m_listEstados.Add(New Lista("C", "CONFIRMADO"))
            ' ANULADO
            m_listEstados.Add(New Lista("X", "ANULADO"))
        Catch
            Throw New Exception("Error: No se han podido obtener los Estados.")
        End Try
    End Sub

    Public Shared Sub GetEstadosProgramacion()
        Try
            m_listEstadosProgramacion = New List(Of Lista)
            ' INGRESADO
            m_listEstadosProgramacion.Add(New Lista("C", "Confirmado"))
            ' CONFIRMADO
            m_listEstadosProgramacion.Add(New Lista("B", "Probable"))
            ' ANULADO
            m_listEstadosProgramacion.Add(New Lista("P", "Pendiente de Entrega"))

        Catch
            Throw New Exception("Error: No se han podido obtener los Estados.")
        End Try
    End Sub

    Public Shared Sub GetEstadosEntrega()
        Try
            m_listEstadosEntrega = New List(Of Lista)
            ' INGRESADO
            m_listEstadosEntrega.Add(New Lista("P", "Pendiente"))
            ' CONFIRMADO
            m_listEstadosEntrega.Add(New Lista("E", "Entregado"))
        Catch
            Throw New Exception("Error: No se han podido obtener los Estados.")
        End Try
    End Sub

    Public Shared Sub GetEstadoGestionado()
        Try
            m_listGestionados = New List(Of Lista)
            ' TODOS
            m_listGestionados.Add(New Lista("T", "<< TODOS >>"))
            ' GESTIONADO
            m_listGestionados.Add(New Lista("True", "GESTIONADOS"))
            ' NO GESTIONADO
            m_listGestionados.Add(New Lista("False", "NO GESTIONADOS"))

        Catch
            Throw New Exception("Error: No se han podido obtener los Estados.")
        End Try
    End Sub

    Public Shared Sub GetTipoPedido()
        Try
            m_listPedidos = New List(Of Lista)
            m_listPedidos.Add(New Lista("N", "Pedido"))
            m_listPedidos.Add(New Lista("C", "Cotización"))
        Catch
            Throw New Exception("Error: No se han podido obtener los Tipos de Pedidos.")
        End Try
    End Sub
#End Region
#End Region

#Region " Periodos "
    Private Shared m_listPeriodos As New List(Of EPeriodos)

    Public Shared ReadOnly Property ListPeriodos As List(Of EPeriodos)
        Get
            Return m_listPeriodos
        End Get
    End Property

    Private Shared Sub GetPeriodos()
        Try
            Dim managerPeriodos As New BPeriodos
            Dim _where As New Hashtable
            _where.Add("PERIO_Activo", New ACWhere(True))
            If managerPeriodos.CargarTodos(_where) Then
                m_listPeriodos = New List(Of EPeriodos)(managerPeriodos.ListPeriodos)
            Else
                m_listPeriodos = New List(Of EPeriodos)
            End If
        Catch ex As Exception
            Throw New Exception("Error: No se han podido obtener los Periodos." + Environment.NewLine + "[" + ex.Message + "]")
        End Try
    End Sub
#End Region

#Region " Ubigeos "
    Private Shared m_listUbigeo As List(Of EUbigeos)
    Private Shared m_dtUbigeo As DataTable

    Public Shared ReadOnly Property Ubigeos() As List(Of EUbigeos)
        Get
            Return m_listUbigeo
        End Get
    End Property

    Public Shared ReadOnly Property UbigeosDT() As DataTable
        Get
            Return m_dtUbigeo
        End Get
    End Property

    Public Shared Sub GetUbigeos()
        Try
            Dim managerUbigeos As BUbigeos
            managerUbigeos = New BUbigeos
            If managerUbigeos.CargarTodosLTD() Then
                m_listUbigeo = New List(Of EUbigeos)(managerUbigeos.ListUbigeos)
                m_dtUbigeo = managerUbigeos.UbigeosDT
            Else
                m_listUbigeo = New List(Of EUbigeos)()
                m_dtUbigeo = New DataTable()
            End If

        Catch ex As Exception
            Throw New Exception("Error: No se han podido obtener los ubigeos." + Environment.NewLine + "[" + ex.Message + "]")
        End Try
    End Sub

    Public Shared Sub GetUbigeosDT()
        Try
            Dim managerUbigeos As BUbigeos
            managerUbigeos = New BUbigeos
            If managerUbigeos.CargarTodos() Then
                m_dtUbigeo = managerUbigeos.CargarTodosDT()
            Else
                m_dtUbigeo = New DataTable()
            End If

        Catch ex As Exception
            Throw New Exception("Error: No se han podido obtener los ubigeos." + Environment.NewLine + "[" + ex.Message + "]")
        End Try
    End Sub
#End Region

#Region "Clases Auxiliares"
    Public Class Lista
        Implements ICloneable

#Region " Campos "
        Private m_Codigo As String
        Private m_Descripcion As String
        Private m_longitud As Integer
#End Region

#Region " Constructor "
        Sub New(ByVal x_Codigo As String, ByVal x_Descripcion As String)
            Codigo = x_Codigo
            Descripcion = x_Descripcion
        End Sub

        Sub New(ByVal x_Codigo As String, ByVal x_Descripcion As String, ByVal x_longitud As Integer)
            Codigo = x_Codigo
            Descripcion = x_Descripcion
            m_longitud = x_longitud
        End Sub
#End Region

#Region " Propiedades "
        Public Property Codigo() As String
            Get
                Return m_Codigo
            End Get
            Set(ByVal value As String)
                m_Codigo = value
            End Set
        End Property
        Public Property Descripcion() As String
            Get
                Return m_Descripcion
            End Get
            Set(ByVal value As String)
                m_Descripcion = value
            End Set
        End Property

        Public Property Longitud() As Integer
            Get
                Return m_longitud
            End Get
            Set(ByVal value As Integer)
                m_longitud = value
            End Set
        End Property

#End Region

        Public Function Clone() As Object Implements System.ICloneable.Clone
            Try
                Dim cloneInstance As Lista
                cloneInstance = DirectCast(Me, Lista)
                Return cloneInstance.MemberwiseClone()
            Catch ex As Exception
                Throw ex
            End Try
        End Function
    End Class
#End Region

#Region " Lista de Precios "
    Private Shared m_listaPrecios As List(Of EVENT_ListaPrecios)
    Private Shared m_listEstadoEntregaOrd As List(Of ACFramework.ACLista)

    Public Shared ReadOnly Property ListaPrecios() As List(Of EVENT_ListaPrecios)
        Get
            Return m_listaPrecios
        End Get
    End Property

    Public Shared Sub getListaPrecios()
        Try
            Dim managerVENT_ListaPrecios As New BVENT_ListaPrecios
            If managerVENT_ListaPrecios.CargarTodos() Then
                m_listaPrecios = New List(Of EVENT_ListaPrecios)(managerVENT_ListaPrecios.ListVENT_ListaPrecios)
            Else
                m_listaPrecios = New List(Of EVENT_ListaPrecios)()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Shared ReadOnly Property ListEstadoEntregaOrden() As List(Of ACFramework.ACLista)
        Get
            Return m_listEstadoEntregaOrd
        End Get
    End Property

    Private Shared Sub GetEstadoEntregaOrden()
        Try
            m_listEstadoEntregaOrd = New List(Of ACLista)
            m_listEstadoEntregaOrd.Add(New ACFramework.ACLista("E", "Entrega Directa"))
            m_listEstadoEntregaOrd.Add(New ACFramework.ACLista("P", "Pendiente de Guia"))
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
#End Region

#Region " Destinos "
    Private Shared m_listDestinos As New List(Of EDestinos)

    Public Shared ReadOnly Property ListDestinos As List(Of EDestinos)
        Get
            Return m_listDestinos
        End Get
    End Property

    Private Shared Sub GetDestinos()
        Try
            Dim managerDestinos As New BDestinos

            If managerDestinos.CargarTodos() Then
                m_listDestinos = New List(Of EDestinos)(managerDestinos.ListDestinos)
            Else
                m_listDestinos = New List(Of EDestinos)
            End If
        Catch ex As Exception
            Throw New Exception("Error: No se han podido obtener los Destinos." + Environment.NewLine + "[" + ex.Message + "]")
        End Try
    End Sub
#End Region



#Region " Roles "

    Private Shared m_listRoles As List(Of ERoles)

    Public Shared Sub GetRoles()
        Try
            Dim managerRoles As BRoles
            managerRoles = New BRoles
            managerRoles.CargarTodos()
            m_listRoles = New List(Of ERoles)(managerRoles.ListRoles)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Shared ReadOnly Property Roles() As List(Of ERoles)
        Get
            Return m_listRoles
        End Get
    End Property

#End Region

#Region "Bancos"
    Private Shared m_listBancos As List(Of EBancos)
    Private Shared m_dtBanco As DataTable

    Public Shared ReadOnly Property Bancos() As List(Of EBancos)
        Get
            Return m_listBancos
        End Get
    End Property

    Public Shared ReadOnly Property BancosDT() As DataTable
        Get
            Return m_dtBanco
        End Get
    End Property

    Public Shared Sub GetBancos()
        Try
            Dim managerBBancos As BBancos
            managerBBancos = New BBancos()
            If managerBBancos.CargarTodos() Then
                m_listBancos = New List(Of EBancos)(managerBBancos.ListBancos)
                m_dtBanco = managerBBancos.BancosDT '
            Else
                m_listBancos = New List(Of EBancos)()
                m_dtBanco = New DataTable() '
            End If
        Catch ex As Exception
            Throw New Exception(String.Format("Error: No se han podido obtener los bancos.{0}[{1}]", Environment.NewLine, ex.Message))
        End Try
    End Sub

    Public Shared Sub GetBancosDT()
        Try
            Dim managerBancos As BBancos
            managerBancos = New BBancos()

            If managerBancos.CargarTodos() Then
                m_dtBanco = managerBancos.CargarTodosDT()
                m_dtBanco.Columns("BANCO_Id").ColumnName = "CODIGO"
                m_dtBanco.Columns("BANCO_Descripcion").ColumnName = "DESCRIPCION"
            Else
                m_dtBanco = New DataTable()
            End If

        Catch ex As Exception
            Throw New Exception("Error: No se han podido obtener los bancos." + Environment.NewLine + "[" + ex.Message + "]")
        End Try
    End Sub

#End Region

End Class
