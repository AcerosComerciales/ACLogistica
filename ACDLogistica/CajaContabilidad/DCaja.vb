Imports System.Data.Common
Imports ACELogistica

Imports ACFramework
Imports DAConexion

Public Class DCaja
#Region "Metodos"
    Public Function ABAS_DOCCOSS_CajaPagos(ByVal m_list_caja As List(Of ECaja), ByVal x_docco_codigo As String, ByVal x_entid_codigo As String) As Boolean
        Try
            DAEnterprise.AsignarProcedure("ABAS_DOCCOSS_CajaPagos")
            DAEnterprise.AgregarParametro("@DOCCO_Codigo", x_docco_codigo, DbType.String, 15)
            DAEnterprise.AgregarParametro("@ENTID_Codigo", x_entid_codigo, DbType.String, 15)
            Using reader As DbDataReader = DAEnterprise.ExecuteDataReader()
                If reader.HasRows Then
                    While reader.Read()
                        Dim _caja As New ECaja()
                        ACEsquemas.ACCargarEsquema(reader, _caja)
                        _caja.Instanciar(ACEInstancia.Consulta)
                        m_list_caja.Add(_caja)
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
