Imports System.Xml
Imports ACFramework

Public Class ECaja
#Region " Campos "
    Private m_tregistro As Long
    Private m_tfectra As Date
    Private m_tdate As Date
    Private m_tprocli As String
    Private m_tctabal As String
    Private m_descri As String
    Private m_idmedio As String
    Private m_nombremedio As String
    Private m_timport As Decimal
    Private m_tuser As String
    Private m_tnumfac_a As String
    Private m_tmon As String
    Private m_treg As Decimal



    Private m_nuevo As Boolean
    Private m_modificado As Boolean
    Private m_eliminado As Boolean


    Private m_hash As Hashtable
#End Region
#Region " Constructores "

    Public Sub New()

        Try
            Dim _obj As Object = My.Resources.xmlCaja
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

#Region " Propiedades "
    Public Property CAJA_Id() As Long
        Get
            Return m_tregistro
        End Get
        Set(ByVal value As Long)
            If Not IsNothing(m_tregistro) Then
                If Not m_tregistro.Equals(value) Then
                    m_tregistro = value
                    OnCAJA_IdChanged(m_tregistro, EventArgs.Empty)
                End If
            Else
                m_tregistro = value
                OnCAJA_IdChanged(m_tregistro, EventArgs.Empty)
            End If
        End Set
    End Property

    Public Property ENTID_Codigo() As String
        Get
            Return m_tprocli
        End Get
        Set(ByVal value As String)
            If Not IsNothing(m_tprocli) Then
                If Not m_tprocli.Equals(value) Then
                    m_tprocli = value
                    OnENTID_CodigoChanged(m_tprocli, EventArgs.Empty)
                End If
            Else
                m_tprocli = value
                OnENTID_CodigoChanged(m_tprocli, EventArgs.Empty)
            End If
        End Set
    End Property

    Public Property DOCCO_Codigo() As String
        Get
            Return m_tnumfac_a
        End Get
        Set(ByVal value As String)
            If Not IsNothing(m_tnumfac_a) Then
                If Not m_tnumfac_a.Equals(value) Then
                    m_tnumfac_a = value
                    OnDOCCO_CodigoChanged(m_tnumfac_a, EventArgs.Empty)
                End If
            Else
                m_tnumfac_a = value
                OnDOCCO_CodigoChanged(m_tnumfac_a, EventArgs.Empty)
            End If
        End Set
    End Property
    Public Property TIPOS_CodTipoMoneda() As String
        Get
            Return m_tmon
        End Get
        Set(ByVal value As String)
            If Not IsNothing(m_tmon) Then
                If Not m_tmon.Equals(value) Then
                    m_tmon = value
                    OnTIPOS_CodTipoMonedaChanged(m_tmon, EventArgs.Empty)
                End If
            Else
                m_tmon = value
                OnTIPOS_CodTipoMonedaChanged(m_tmon, EventArgs.Empty)
            End If
        End Set
    End Property
    Public Property TIPOS_CodTransaccion() As String
        Get
            Return m_idmedio
        End Get
        Set(ByVal value As String)
            If Not IsNothing(m_idmedio) Then
                If Not m_idmedio.Equals(value) Then
                    m_idmedio = value
                    OnTIPOS_CodTransaccionChanged(m_idmedio, EventArgs.Empty)
                End If
            Else
                m_idmedio = value
                OnTIPOS_CodTransaccionChanged(m_idmedio, EventArgs.Empty)
            End If
        End Set
    End Property
    Public Property TIPOS_CodTipoOrigen() As String
        Get
            Return m_tctabal
        End Get
        Set(ByVal value As String)
            If Not IsNothing(m_tctabal) Then
                If Not m_tctabal.Equals(value) Then
                    m_tctabal = value
                    OnTIPOS_CodTipoOrigenChanged(m_tctabal, EventArgs.Empty)
                End If
            Else
                m_tctabal = value
                OnTIPOS_CodTipoOrigenChanged(m_tctabal, EventArgs.Empty)
            End If
        End Set
    End Property
    Public Property CAJA_Codigo() As Decimal
        Get
            Return m_treg
        End Get
        Set(ByVal value As Decimal)
            If Not IsNothing(m_treg) Then
                If Not m_treg.Equals(value) Then
                    m_treg = value
                    OnCAJA_CodigoChanged(m_treg, EventArgs.Empty)
                End If
            Else
                m_treg = value
                OnCAJA_CodigoChanged(m_treg, EventArgs.Empty)
            End If
        End Set
    End Property
    Public Property CAJA_Fecha() As Date
        Get
            Return m_tfectra
        End Get
        Set(ByVal value As Date)
            If Not IsNothing(m_tfectra) Then
                If Not m_tfectra.Equals(value) Then
                    m_tfectra = value
                    OnCAJA_FechaChanged(m_tfectra, EventArgs.Empty)
                End If
            Else
                m_tfectra = value
                OnCAJA_FechaChanged(m_tfectra, EventArgs.Empty)
            End If
        End Set
    End Property
    Public Property CAJA_FechaPago() As Date
        Get
            Return m_tdate
        End Get
        Set(ByVal value As Date)
            If Not IsNothing(m_tdate) Then
                If Not m_tdate.Equals(value) Then
                    m_tdate = value
                    OnCAJA_FechaPagoChanged(m_tdate, EventArgs.Empty)
                End If
            Else
                m_tdate = value
                OnCAJA_FechaPagoChanged(m_tdate, EventArgs.Empty)
            End If
        End Set
    End Property
    Public Property CAJA_Importe() As Decimal
        Get
            Return m_timport
        End Get
        Set(ByVal value As Decimal)
            If Not IsNothing(m_timport) Then
                If Not m_timport.Equals(value) Then
                    m_timport = value
                    OnCAJA_ImporteChanged(m_timport, EventArgs.Empty)
                End If
            Else
                m_timport = value
                OnCAJA_ImporteChanged(m_timport, EventArgs.Empty)
            End If
        End Set
    End Property
    Public Property CAJA_Glosa() As String
        Get
            Return m_descri
        End Get
        Set(ByVal value As String)
            If Not IsNothing(m_descri) Then
                If Not m_descri.Equals(value) Then
                    m_descri = value
                    OnCAJA_GlosaChanged(m_descri, EventArgs.Empty)
                End If
            Else
                m_descri = value
                OnCAJA_GlosaChanged(m_descri, EventArgs.Empty)
            End If
        End Set
    End Property
    Public Property Usuario() As String
        Get
            Return m_tuser
        End Get
        Set(ByVal value As String)
            m_tuser = value
        End Set
    End Property
#End Region

#Region " Eventos "

    Public Event CAJA_IdChanged As EventHandler
    Public Event ENTID_CodigoChanged As EventHandler
    Public Event DOCCO_CodigoChanged As EventHandler
    Public Event TIPOS_CodTipoMonedaChanged As EventHandler
    Public Event TIPOS_CodTransaccionChanged As EventHandler
    Public Event TIPOS_CodTipoOrigenChanged As EventHandler
    Public Event CAJA_CodigoChanged As EventHandler
   
    Public Event CAJA_OrdenDocumentoChanged As EventHandler
    Public Event CAJA_FechaChanged As EventHandler
    Public Event CAJA_FechaPagoChanged As EventHandler

    Public Event CAJA_ImporteChanged As EventHandler
    Public Event CAJA_GlosaChanged As EventHandler

    Public Event CAJA_ReciboChanged As EventHandler
    Public Event CAJA_NroDocumentoChanged As EventHandler
    Public Event CAJA_NumDepositoChanged As EventHandler
   
    Public Event CAJA_ImporteVentaChanged As EventHandler


    Public Event CAJA_TNumFacChanged As EventHandler


    Public Sub OnCAJA_IdChanged(ByVal sender As Object, ByVal e As EventArgs)
        ActualizarInstancia()
        RaiseEvent CAJA_IdChanged(sender, e)
    End Sub



    Public Sub OnENTID_CodigoChanged(ByVal sender As Object, ByVal e As EventArgs)
        ActualizarInstancia()
        RaiseEvent ENTID_CodigoChanged(sender, e)
    End Sub

    Public Sub OnDOCCO_CodigoChanged(ByVal sender As Object, ByVal e As EventArgs)
        ActualizarInstancia()
        RaiseEvent DOCCO_CodigoChanged(sender, e)
    End Sub

    Public Sub OnTIPOS_CodTipoMonedaChanged(ByVal sender As Object, ByVal e As EventArgs)
        ActualizarInstancia()
        RaiseEvent TIPOS_CodTipoMonedaChanged(sender, e)
    End Sub

    Public Sub OnTIPOS_CodTransaccionChanged(ByVal sender As Object, ByVal e As EventArgs)
        ActualizarInstancia()
        RaiseEvent TIPOS_CodTransaccionChanged(sender, e)
    End Sub
    Public Sub OnTIPOS_CodTipoOrigenChanged(ByVal sender As Object, ByVal e As EventArgs)
        ActualizarInstancia()
        RaiseEvent TIPOS_CodTipoOrigenChanged(sender, e)
    End Sub


    Public Sub OnCAJA_CodigoChanged(ByVal sender As Object, ByVal e As EventArgs)
        ActualizarInstancia()
        RaiseEvent CAJA_CodigoChanged(sender, e)
    End Sub



    Public Sub OnCAJA_OrdenDocumentoChanged(ByVal sender As Object, ByVal e As EventArgs)
        ActualizarInstancia()
        RaiseEvent CAJA_OrdenDocumentoChanged(sender, e)
    End Sub

    Public Sub OnCAJA_FechaChanged(ByVal sender As Object, ByVal e As EventArgs)
        ActualizarInstancia()
        RaiseEvent CAJA_FechaChanged(sender, e)
    End Sub
    Public Sub OnCAJA_FechaPagoChanged(ByVal sender As Object, ByVal e As EventArgs)
        ActualizarInstancia()
        RaiseEvent CAJA_FechaPagoChanged(sender, e)
    End Sub


    Public Sub OnCAJA_ImporteChanged(ByVal sender As Object, ByVal e As EventArgs)
        ActualizarInstancia()
        RaiseEvent CAJA_ImporteChanged(sender, e)
    End Sub

    Public Sub OnCAJA_GlosaChanged(ByVal sender As Object, ByVal e As EventArgs)
        ActualizarInstancia()
        RaiseEvent CAJA_GlosaChanged(sender, e)
    End Sub


    Public Sub OnCAJA_ReciboChanged(ByVal sender As Object, ByVal e As EventArgs)
        ActualizarInstancia()
        RaiseEvent CAJA_ReciboChanged(sender, e)
    End Sub

    Public Sub OnCAJA_NroDocumentoChanged(ByVal sender As Object, ByVal e As EventArgs)
        ActualizarInstancia()
        RaiseEvent CAJA_NroDocumentoChanged(sender, e)
    End Sub

    Public Sub OnCAJA_NumDepositoChanged(ByVal sender As Object, ByVal e As EventArgs)
        ActualizarInstancia()
        RaiseEvent CAJA_NumDepositoChanged(sender, e)
    End Sub

   
    

    Public Sub OnCAJA_ImporteVentaChanged(ByVal sender As Object, ByVal e As EventArgs)
        ActualizarInstancia()
        RaiseEvent CAJA_ImporteVentaChanged(sender, e)
    End Sub





#End Region

#Region " Propiedades de Solo Lectura "

    Public ReadOnly Property Nuevo() As Boolean
        Get
            Return m_nuevo
        End Get
    End Property

    Public ReadOnly Property Modificado() As Boolean
        Get
            Return m_modificado
        End Get
    End Property

    Public ReadOnly Property Eliminado() As Boolean
        Get
            Return m_eliminado
        End Get
    End Property

    Public ReadOnly Property Hash() As Hashtable
        Get
            Return m_hash
        End Get
    End Property

    Public Shared ReadOnly Property Tabla() As String
        Get
            Return "Caja"
        End Get
    End Property

    Public Shared ReadOnly Property Esquema() As String
        Get
            Return "dbo"
        End Get
    End Property

#End Region


#Region " Eventos "

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
