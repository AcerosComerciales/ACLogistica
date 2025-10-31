Imports System
Imports System.Data
Imports System.Data.Common
Imports System.Collections.Generic
Imports System.Xml
Imports ACFramework
Partial Public Class EABAS_PedidosCompra
    #Region " Campos "
    Private m_pedid_codigo As String
	Private m_pvent_id As Long
	Private m_zonas_codigo As String
	Private m_sucur_id As Short
    Private m_almac_id As Short
	Private m_entid_codigoencargado As String	
	
	Private m_pedid_id As Long
	Private m_pedid_descripcionencargado As String
	Private m_pedid_numero As Integer
	Private m_pedid_fechadocumento As Date
    Private m_pedid_totalpeso As Decimal
	Private m_pedid_tipo As String
	Private m_pedid_observaciones As String
	Private m_pedid_estado As String
    Private m_pedid_stocklocal As Decimal
	Private m_pedid_stockprincipal As Decimal
	Private m_pedid_promedioventas As Decimal
	Private m_pedid_fechaanulacion As Date
	Private m_pedid_motivoanulacion As String

        Private m_pedid_usrcrea As String
	Private m_pedid_feccrea As Date
    Private m_pedid_usrmod As String
    Private m_pedid_usrmodificador As String
	Private m_pedid_fecmod As Date
 
	Private m_nuevo As Boolean
	Private m_modificado As Boolean
	Private m_eliminado As Boolean

	Private m_hash As Hashtable
    #End Region

#Region" Constructores "
	
	Public Sub New()

		Try
			Dim _obj As Object = ACELogistica.My.Resources.xmlABAS_PedidosCompra
			Dim _xml As New XmlDocument
			_xml.LoadXml(_obj)
			If IsNothing(m_hash) Then
				m_hash = New Hashtable()
				Dim cPlantilla As XmlNodeList = _xml.GetElementsByTagName("Tabla")
				Dim cCampos As XmlNodeList = CType(cPlantilla(0), XmlElement).GetElementsByTagName("Campos")
				Dim Campo As XmlNodeList = CType(cCampos(0), XmlElement).GetElementsByTagName("CCampo")
				For Each Item As XmlElement In Campo
					m_hash.Add(Item.InnerText.ToString(), New CCampo(Item.GetAttribute("xmlns"), IIf(Item.GetAttribute("Identity") = "1", True, False), IIf(Item.GetAttribute("ForeignKey") = "1", True, False), IIf(Item.GetAttribute("PrimaryKey") = "1", True, False)))
				Next
			End If
		Catch ex As Exception
			Throw ex
		End Try
	End Sub

#End Region

#Region" Propiedades "
	
	Public Property PEDID_Codigo() As String
		Get
			return m_pedid_codigo
		End Get
		Set(ByVal value As String)
			If Not IsNothing(m_pedid_codigo) Then
				If Not m_pedid_codigo.Equals(value) Then
					m_pedid_codigo = value
					OnPEDID_CodigoChanged(m_pedid_codigo, EventArgs.Empty)
				End If
			Else
				m_pedid_codigo = value
				OnPEDID_CodigoChanged(m_pedid_codigo, EventArgs.Empty)
			End If
		End Set
	End Property
   

	Public Property PVENT_Id() As Long
		Get
			return m_pvent_id
		End Get
		Set(ByVal value As Long)
			If Not IsNothing(m_pvent_id) Then
				If Not m_pvent_id.Equals(value) Then
					m_pvent_id = value
					OnPVENT_IdChanged(m_pvent_id, EventArgs.Empty)
				End If
			Else
				m_pvent_id = value
				OnPVENT_IdChanged(m_pvent_id, EventArgs.Empty)
			End If
		End Set
	End Property

	Public Property ZONAS_Codigo() As String
		Get
			return m_zonas_codigo
		End Get
		Set(ByVal value As String)
			If Not IsNothing(m_zonas_codigo) Then
				If Not m_zonas_codigo.Equals(value) Then
					m_zonas_codigo = value
					OnZONAS_CodigoChanged(m_zonas_codigo, EventArgs.Empty)
				End If
			Else
				m_zonas_codigo = value
				OnZONAS_CodigoChanged(m_zonas_codigo, EventArgs.Empty)
			End If
		End Set
	End Property

	Public Property SUCUR_Id() As Short
		Get
			return m_sucur_id
		End Get
		Set(ByVal value As Short)
			If Not IsNothing(m_sucur_id) Then
				If Not m_sucur_id.Equals(value) Then
					m_sucur_id = value
					OnSUCUR_IdChanged(m_sucur_id, EventArgs.Empty)
				End If
			Else
				m_sucur_id = value
				OnSUCUR_IdChanged(m_sucur_id, EventArgs.Empty)
			End If
		End Set
	End Property
    	Public Property ALMAC_Id() As Short
		Get
			return m_almac_id
		End Get
		Set(ByVal value As Short)
			If Not IsNothing(m_almac_id) Then
				If Not m_almac_id.Equals(value) Then
					m_almac_id = value
					OnALMAC_IdChanged(m_almac_id, EventArgs.Empty)
				End If
			Else
				m_almac_id = value
				OnALMAC_IdChanged(m_almac_id, EventArgs.Empty)
			End If
		End Set
	End Property


	Public Property ENTID_CodigoEncargado() As String
		Get
			return m_entid_codigoencargado
		End Get
		Set(ByVal value As String)
			If Not IsNothing(m_entid_codigoencargado) Then
				If Not m_entid_codigoencargado.Equals(value) Then
					m_entid_codigoencargado = value
					OnENTID_CodigoEncargadoChanged(m_entid_codigoencargado, EventArgs.Empty)
				End If
			Else
				m_entid_codigoencargado = value
				OnENTID_CodigoEncargadoChanged(m_entid_codigoencargado, EventArgs.Empty)
			End If
		End Set
	End Property


	


	Public Property PEDID_Id() As Long
		Get
			return m_pedid_id
		End Get
		Set(ByVal value As Long)
			If Not IsNothing(m_pedid_id) Then
				If Not m_pedid_id.Equals(value) Then
					m_pedid_id = value
					OnPEDID_IdChanged(m_pedid_id, EventArgs.Empty)
				End If
			Else
				m_pedid_id = value
				OnPEDID_IdChanged(m_pedid_id, EventArgs.Empty)
			End If
		End Set
	End Property


	Public Property PEDID_DescripcionEncargado() As String
		Get
			return m_pedid_descripcionencargado
		End Get
		Set(ByVal value As String)
			If Not IsNothing(m_pedid_descripcionencargado) Then
				If Not m_pedid_descripcionencargado.Equals(value) Then
					m_pedid_descripcionencargado = value
					OnPEDID_DescripcionEncargadoChanged(m_pedid_descripcionencargado, EventArgs.Empty)
				End If
			Else
				m_pedid_descripcionencargado = value
				OnPEDID_DescripcionEncargadoChanged(m_pedid_descripcionencargado, EventArgs.Empty)
			End If
		End Set
	End Property



	Public Property PEDID_Numero() As Integer
		Get
			return m_pedid_numero
		End Get
		Set(ByVal value As Integer)
			If Not IsNothing(m_pedid_numero) Then
				If Not m_pedid_numero.Equals(value) Then
					m_pedid_numero = value
					OnPEDID_NumeroChanged(m_pedid_numero, EventArgs.Empty)
				End If
			Else
				m_pedid_numero = value
				OnPEDID_NumeroChanged(m_pedid_numero, EventArgs.Empty)
			End If
		End Set
	End Property

	Public Property PEDID_FechaDocumento() As Date
		Get
			return m_pedid_fechadocumento
		End Get
		Set(ByVal value As Date)
			If Not IsNothing(m_pedid_fechadocumento) Then
				If Not m_pedid_fechadocumento.Equals(value) Then
					m_pedid_fechadocumento = value
					OnPEDID_FechaDocumentoChanged(m_pedid_fechadocumento, EventArgs.Empty)
				End If
			Else
				m_pedid_fechadocumento = value
				OnPEDID_FechaDocumentoChanged(m_pedid_fechadocumento, EventArgs.Empty)
			End If
		End Set
	End Property




	Public Property PEDID_TotalPeso() As Decimal
		Get
			return m_pedid_totalpeso
		End Get
		Set(ByVal value As Decimal)
			If Not IsNothing(m_pedid_totalpeso) Then
				If Not m_pedid_totalpeso.Equals(value) Then
					m_pedid_totalpeso = value
					OnPEDID_TotalPesoChanged(m_pedid_totalpeso, EventArgs.Empty)
				End If
			Else
				m_pedid_totalpeso = value
				OnPEDID_TotalPesoChanged(m_pedid_totalpeso, EventArgs.Empty)
			End If
		End Set
	End Property

    Public Property PEDID_Tipo() As String
		Get
			return m_pedid_tipo
		End Get
		Set(ByVal value As String)
			If Not IsNothing(m_pedid_tipo) Then
				If Not m_pedid_tipo.Equals(value) Then
					m_pedid_tipo = value
					OnPEDID_TipoChanged(m_pedid_tipo, EventArgs.Empty)
				End If
			Else
				m_pedid_tipo = value
				OnPEDID_TipoChanged(m_pedid_tipo, EventArgs.Empty)
			End If
		End Set
	End Property


	Public Property PEDID_Observaciones() As String
		Get
			return m_pedid_observaciones
		End Get
		Set(ByVal value As String)
			If Not IsNothing(m_pedid_observaciones) Then
				If Not m_pedid_observaciones.Equals(value) Then
					m_pedid_observaciones = value
					OnPEDID_ObservacionesChanged(m_pedid_observaciones, EventArgs.Empty)
				End If
			Else
				m_pedid_observaciones = value
				OnPEDID_ObservacionesChanged(m_pedid_observaciones, EventArgs.Empty)
			End If
		End Set
	End Property

	Public Property PEDID_Estado() As String
		Get
			return m_pedid_estado
		End Get
		Set(ByVal value As String)
			If Not IsNothing(m_pedid_estado) Then
				If Not m_pedid_estado.Equals(value) Then
					m_pedid_estado = value
					OnPEDID_EstadoChanged(m_pedid_estado, EventArgs.Empty)
				End If
			Else
				m_pedid_estado = value
				OnPEDID_EstadoChanged(m_pedid_estado, EventArgs.Empty)
			End If
		End Set
	End Property

	

	Public Property PEDID_StockLocal() As Decimal
		Get
			return m_pedid_stocklocal
		End Get
		Set(ByVal value As Decimal)
			If Not IsNothing(m_pedid_stocklocal) Then
				If Not m_pedid_stocklocal.Equals(value) Then
					m_pedid_stocklocal = value
					OnPEDID_StockLocalChanged(m_pedid_stocklocal, EventArgs.Empty)
				End If
			Else
				m_pedid_stocklocal = value
				OnPEDID_StockLocalChanged(m_pedid_stocklocal, EventArgs.Empty)
			End If
		End Set
	End Property

	Public Property PEDID_StockPrincipal() As Decimal
		Get
			return m_pedid_stockprincipal
		End Get
		Set(ByVal value As Decimal)
			If Not IsNothing(m_pedid_stockprincipal) Then
				If Not m_pedid_stockprincipal.Equals(value) Then
					m_pedid_stockprincipal = value
					OnPEDID_StockPrincipalChanged(m_pedid_stockprincipal, EventArgs.Empty)
				End If
			Else
				m_pedid_stockprincipal = value
				OnPEDID_StockPrincipalChanged(m_pedid_stockprincipal, EventArgs.Empty)
			End If
		End Set
	End Property

	Public Property PEDID_PromedioVentas() As Decimal
		Get
			return m_pedid_promedioventas
		End Get
		Set(ByVal value As Decimal)
			If Not IsNothing(m_pedid_promedioventas) Then
				If Not m_pedid_promedioventas.Equals(value) Then
					m_pedid_promedioventas = value
					OnPEDID_PromedioVentasChanged(m_pedid_promedioventas, EventArgs.Empty)
				End If
			Else
				m_pedid_promedioventas = value
				OnPEDID_PromedioVentasChanged(m_pedid_promedioventas, EventArgs.Empty)
			End If
		End Set
	End Property







	Public Property PEDID_FechaAnulacion() As Date
		Get
			return m_pedid_fechaanulacion
		End Get
		Set(ByVal value As Date)
			If Not IsNothing(m_pedid_fechaanulacion) Then
				If Not m_pedid_fechaanulacion.Equals(value) Then
					m_pedid_fechaanulacion = value
					OnPEDID_FechaAnulacionChanged(m_pedid_fechaanulacion, EventArgs.Empty)
				End If
			Else
				m_pedid_fechaanulacion = value
				OnPEDID_FechaAnulacionChanged(m_pedid_fechaanulacion, EventArgs.Empty)
			End If
		End Set
	End Property

	Public Property PEDID_MotivoAnulacion() As String
		Get
			return m_pedid_motivoanulacion
		End Get
		Set(ByVal value As String)
			If Not IsNothing(m_pedid_motivoanulacion) Then
				If Not m_pedid_motivoanulacion.Equals(value) Then
					m_pedid_motivoanulacion = value
					OnPEDID_MotivoAnulacionChanged(m_pedid_motivoanulacion, EventArgs.Empty)
				End If
			Else
				m_pedid_motivoanulacion = value
				OnPEDID_MotivoAnulacionChanged(m_pedid_motivoanulacion, EventArgs.Empty)
			End If
		End Set
	End Property

	

	Public Property PEDID_UsrCrea() As String
		Get
			return m_pedid_usrcrea
		End Get
		Set(ByVal value As String)
			m_pedid_usrcrea = value
		End Set
    End Property


    Public Property UsuarioModi() As String
        Get
            Return m_pedid_usrmodificador
        End Get
        Set(ByVal value As String)
            m_pedid_usrmodificador = value
        End Set
    End Property



	Public Property PEDID_FecCrea() As Date
		Get
			return m_pedid_feccrea
		End Get
		Set(ByVal value As Date)
			m_pedid_feccrea = value
		End Set
	End Property

	Public Property PEDID_UsrMod() As String
		Get
			return m_pedid_usrmod
		End Get
		Set(ByVal value As String)
			m_pedid_usrmod = value
		End Set
	End Property

	Public Property PEDID_FecMod() As Date
		Get
			return m_pedid_fecmod
		End Get
		Set(ByVal value As Date)
			m_pedid_fecmod = value
		End Set
    End Property
   

	#Region " Propiedades de Solo Lectura "

	Public ReadOnly Property Nuevo() As Boolean
		Get
			return m_nuevo
		End Get
	End Property

	Public ReadOnly Property Modificado() As Boolean
		Get
			return m_modificado
		End Get
	End Property

	Public ReadOnly Property Eliminado() As Boolean
		Get
			return m_eliminado
		End Get
	End Property

	Public ReadOnly Property Hash() As Hashtable
		Get
			return m_hash
		End Get
	End Property

	Public Shared ReadOnly Property Tabla() As String
		Get
			Return "ABAS_PedidosCompra"
		End Get
	End Property

	Public Shared ReadOnly Property Esquema() As String
		Get
			Return "Logistica"
		End Get
	End Property

	#End Region

#End Region

#Region " Eventos "
	
	Public Event PEDID_CodigoChanged As EventHandler
	Public Event PVENT_IdChanged As EventHandler
	Public Event ZONAS_CodigoChanged As EventHandler
	Public Event SUCUR_IdChanged As EventHandler
    Public Event ALMAc_IdChanged As EventHandler
	Public Event ENTID_CodigoEncargadoChanged As EventHandler
	Public Event TIPOS_CodTipoDocumentoChanged As EventHandler
	Public Event PEDID_IdChanged As EventHandler
	Public Event PEDID_DescripcionEncargadoChanged As EventHandler
	Public Event PEDID_NumeroChanged As EventHandler
	Public Event PEDID_FechaDocumentoChanged As EventHandler
	Public Event PEDID_TotalPesoChanged As EventHandler
	Public Event PEDID_ObservacionesChanged As EventHandler
	Public Event PEDID_EstadoChanged As EventHandler
	Public Event PEDID_StockLocalChanged As EventHandler
	Public Event PEDID_StockPrincipalChanged As EventHandler
	Public Event PEDID_PromedioVentasChanged As EventHandler
	Public Event PEDID_CodRelacionadoChanged As EventHandler
	Public Event PEDID_FechaAnulacionChanged As EventHandler
	Public Event PEDID_MotivoAnulacionChanged As EventHandler
    Public Event PEDID_TipoChanged As EventHandler

	Public Sub OnPEDID_CodigoChanged(ByVal sender As object, ByVal e As EventArgs)
		ActualizarInstancia()
		RaiseEvent PEDID_CodigoChanged(sender, e)
	End Sub

	Public Sub OnPVENT_IdChanged(ByVal sender As object, ByVal e As EventArgs)
		ActualizarInstancia()
		RaiseEvent PVENT_IdChanged(sender, e)
	End Sub

  
	Public Sub OnZONAS_CodigoChanged(ByVal sender As object, ByVal e As EventArgs)
		ActualizarInstancia()
		RaiseEvent ZONAS_CodigoChanged(sender, e)
	End Sub
    Public Sub OnALMAC_IdChanged(ByVal sender As object, ByVal e As EventArgs)
		ActualizarInstancia()
		RaiseEvent ALMAC_IdChanged(sender, e)
	End Sub

	Public Sub OnSUCUR_IdChanged(ByVal sender As object, ByVal e As EventArgs)
		ActualizarInstancia()
		RaiseEvent SUCUR_IdChanged(sender, e)
	End Sub
    Public Sub OnENTID_CodigoEncargadoChanged(ByVal sender As Object, ByVal e As EventArgs)
        ActualizarInstancia()
        RaiseEvent ENTID_CodigoEncargadoChanged(sender,e)
    End Sub

	Public Sub OnTIPOS_CodTipoDocumentoChanged(ByVal sender As object, ByVal e As EventArgs)
		ActualizarInstancia()
		RaiseEvent TIPOS_CodTipoDocumentoChanged(sender, e)
	End Sub



	Public Sub OnPEDID_IdChanged(ByVal sender As object, ByVal e As EventArgs)
		ActualizarInstancia()
		RaiseEvent PEDID_IdChanged(sender, e)
	End Sub
    Public sub OnPEDID_DescripcionEncargadoChanged(ByVal sender As Object, ByVal e As EventArgs)
        ActualizarInstancia()
        RaiseEvent PEDID_DescripcionEncargadoChanged(sender,e)
    End Sub
	

	Public Sub OnPEDID_NumeroChanged(ByVal sender As object, ByVal e As EventArgs)
		ActualizarInstancia()
		RaiseEvent PEDID_NumeroChanged(sender, e)
	End Sub

	Public Sub OnPEDID_FechaDocumentoChanged(ByVal sender As object, ByVal e As EventArgs)
		ActualizarInstancia()
		RaiseEvent PEDID_FechaDocumentoChanged(sender, e)
	End Sub

	Public Sub OnPEDID_TotalPesoChanged(ByVal sender As object, ByVal e As EventArgs)
		ActualizarInstancia()
		RaiseEvent PEDID_TotalPesoChanged(sender, e)
	End Sub



	Public Sub OnPEDID_ObservacionesChanged(ByVal sender As object, ByVal e As EventArgs)
		ActualizarInstancia()
		RaiseEvent PEDID_ObservacionesChanged(sender, e)
	End Sub

	Public Sub OnPEDID_EstadoChanged(ByVal sender As object, ByVal e As EventArgs)
		ActualizarInstancia()
		RaiseEvent PEDID_EstadoChanged(sender, e)
	End Sub

	

	Public Sub OnPEDID_StockLocalChanged(ByVal sender As object, ByVal e As EventArgs)
		ActualizarInstancia()
		RaiseEvent PEDID_StockLocalChanged(sender, e)
	End Sub

	Public Sub OnPEDID_StockPrincipalChanged(ByVal sender As object, ByVal e As EventArgs)
		ActualizarInstancia()
		RaiseEvent PEDID_StockPrincipalChanged(sender, e)
	End Sub

	Public Sub OnPEDID_PromedioVentasChanged(ByVal sender As object, ByVal e As EventArgs)
		ActualizarInstancia()
		RaiseEvent PEDID_PromedioVentasChanged(sender, e)
	End Sub


	Public Sub OnPEDID_CodRelacionadoChanged(ByVal sender As object, ByVal e As EventArgs)
		ActualizarInstancia()
		RaiseEvent PEDID_CodRelacionadoChanged(sender, e)
	End Sub

	
	Public Sub OnPEDID_TipoChanged(ByVal sender As object, ByVal e As EventArgs)
		ActualizarInstancia()
		RaiseEvent PEDID_TipoChanged(sender, e)
	End Sub


	Public Sub OnPEDID_FechaAnulacionChanged(ByVal sender As object, ByVal e As EventArgs)
		ActualizarInstancia()
		RaiseEvent PEDID_FechaAnulacionChanged(sender, e)
	End Sub

	Public Sub OnPEDID_MotivoAnulacionChanged(ByVal sender As object, ByVal e As EventArgs)
		ActualizarInstancia()
		RaiseEvent PEDID_MotivoAnulacionChanged(sender, e)
	End Sub

	
#End Region

#Region " Metodos "

    Public Sub Instanciar(ByVal x_instancia As ACEInstancia)
        Select Case x_instancia
            Case ACEInstancia.Consulta
                m_nuevo = False
                m_modificado = False
                m_eliminado = False
            Case ACEInstancia.Nuevo
                m_nuevo = True
                m_modificado = False
                m_eliminado = False
            Case ACEInstancia.Modificado
                m_nuevo = False
                m_modificado = True
                m_eliminado = False
            Case ACEInstancia.Eliminado
                m_nuevo = False
                m_modificado = False
                m_eliminado = True
        End Select
    End Sub

    Public Sub ActualizarInstancia()
        If Not Nuevo Then
            If Not Eliminado Then
                Instanciar(ACEInstancia.Modificado)
            End If
        End If
    End Sub

#End Region

End Class

