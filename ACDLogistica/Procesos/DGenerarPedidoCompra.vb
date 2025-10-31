Imports DAConexion

Public Class DGenerarPedidoCompra

#Region " Variables "
    Private m_formatofecha As String
#End Region

#Region " Constructores "
    Public Sub New()
        m_formatofecha = "yyyy-MM-dd HH:mm:ss.fff"
    End Sub
#End Region

#Region " Procedimientos Almacenados "

    Public Function getCorrelativo(ByVal x_pvent_id As Long, ByVal x_tipo As String) As Integer
        Try
            DAEnterprise.AsignarProcedure(getSelectAllC(x_pvent_id, x_tipo), CommandType.Text)
            Dim m_data As DataSet = DAEnterprise.ExecuteDataSet()
            Return CType(m_data.Tables(0).Rows(0)("Codigo"), Integer)
        Catch ex As Exception
            Throw ex
        End Try
    End Function
  

    Public Sub getActualizar(ByVal x_pedid_codigo As String, ByVal x_imprsiones As Integer)
        Try
            DAEnterprise.AsignarProcedure(getactualizar_t(x_pedid_codigo, x_imprsiones), CommandType.Text)
            DAEnterprise.ExecuteNonQuery()

        Catch ex As Exception
            Throw ex
        End Try
    End Sub




#Region " Adicionales "


    Private Function getSelectAllC(ByVal x_pvent_id As Long, ByVal x_tipo As String) As String
        Dim sql As String = ""
        Try
            sql &= String.Format(" SELECT Convert(Int, IsNull(Max(PEDID_Numero), '0')) As Codigo FROM Ventas.VENT_Pedidos {0}", vbNewLine)
            sql &= String.Format(" Where PVENT_Id = {0} And PEDID_Tipo = '{1}' {2}", x_pvent_id.ToString, x_tipo, vbNewLine)
            Return sql
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function getSelectimpresiones(ByVal x_pedid_codigo As String) As String
        Dim sql As String = ""
        Try
            sql &= String.Format(" SELECT IsNull(PEDID_Impresiones,0) As Codigo FROM Ventas.VENT_Pedidos {0}", vbNewLine)
            sql &= String.Format(" Where PEDID_Codigo = '{0}' ", x_pedid_codigo.ToString, vbNewLine)
            Return sql
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function getactualizar_t(ByVal x_pedid_codigo As String, ByVal x_impresiones As Integer) As String
        Dim sql As String = ""
        Try
            sql &= String.Format(" update Ventas.VENT_Pedidos ", vbNewLine)
            sql &= String.Format(" set PEDID_Impresiones={0}", x_impresiones, vbNewLine)
            sql &= String.Format(" Where PEDID_Codigo = '{0}' ", x_pedid_codigo.ToString, vbNewLine)
            Return sql
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Function getSelectAllCorte(ByVal x_pvent_id As Long, ByVal x_tipo As String) As String
        Dim sql As String = ""
        Try
            sql &= String.Format(" SELECT Convert(Int, IsNull(Max(PEDID_Numero), '0')) As Codigo FROM Ventas.VENT_Pedidos {0}", vbNewLine)
            sql &= String.Format(" Where PVENT_Id = {0} And TIPOS_CodTipoDocumento = '{1}' {2}", x_pvent_id.ToString, x_tipo, vbNewLine)
            Return sql
        Catch ex As Exception
            Throw ex
        End Try
    End Function


    Public Function getDateTime() As DateTime
        Dim x_datos As New DataTable()
        Try
            DAEnterprise.AsignarProcedure("Select GetDate()", CommandType.Text)
            x_datos = DAEnterprise.ExecuteDataSet().Tables(0)
            Dim _fecha As DateTime = x_datos.Rows(0)(0)
            Return _fecha
        Catch ex As Exception
            Throw ex
        End Try
    End Function


#End Region
#End Region

#Region " Metodos "


#End Region


End Class


