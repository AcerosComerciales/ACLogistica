Imports ACDLogistica
Imports ACELogistica

Public Class BCaja
#Region " Variables "
    Private d_administracioncaja As DCaja

    Private m_list_cajapagos As List(Of ECaja)
#End Region
    Public Sub New()
        d_administracioncaja = New DCaja()
    End Sub

#Region "Propiedades"

    Public Property List_CajaPagos() As List(Of ECaja)
        Get
            Return m_list_cajapagos
        End Get
        Set(ByVal value As List(Of ECaja))
            m_list_cajapagos = value
        End Set
    End Property
#End Region
#Region "Caja"

    Public Function ABAS_DOCCOSS_CajaPagos(ByVal x_docco_codigo As String, ByVal x_entid_codigo As String) As Boolean
        m_list_cajapagos = New List(Of ECaja)
        Try
            Return d_administracioncaja.ABAS_DOCCOSS_CajaPagos(m_list_cajapagos, x_docco_codigo, x_entid_codigo)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
#End Region
End Class
