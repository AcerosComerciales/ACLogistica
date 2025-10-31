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


Public Class BPuntoVentaSucursales
        Private Shared m_mutex As New Mutex()
    Private Shared m_instance As Colecciones = Nothing

    Private Shared m_dist_puntoVenta As BPuntoVentaSucursales
    Private Shared m_listPuntoVenta As List(Of EPuntoVenta)
    Private Shared m_listPuntoVentaxalma As List(Of EPuntoVenta)

    Sub New()
        m_dist_puntoVenta = New BPuntoVentaSucursales()
    End Sub

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

    Public Function ProcSucurOrdenes(ByVal x_almac_id As Short) As List(Of EPuntoVenta)
        Dim resultado As New List(Of EPuntoVenta)

        Try
            DAEnterprise.AsignarProcedure("ProcSucurOrdenes")
            DAEnterprise.AgregarParametro("@PuntoVenta", x_almac_id, DbType.Int16, 2)

            DAEnterprise.CommandTimeOut = 0
            Using reader As DbDataReader = DAEnterprise.ExecuteDataReader()
                While reader.Read()
                    Dim _epuntoVentas As New EPuntoVenta()
                    ACEsquemas.ACCargarEsquema(reader, _epuntoVentas)
                    _epuntoVentas.Instanciar(ACEInstancia.Consulta)
                    resultado.Add(_epuntoVentas)
                End While
            End Using

        Catch ex As Exception
            Throw ' mejor usar solo Throw para conservar el stacktrace original
        End Try

        Return resultado
    End Function



End Class
