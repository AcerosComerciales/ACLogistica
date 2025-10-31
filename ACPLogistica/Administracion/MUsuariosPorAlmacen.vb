Imports System
Imports System.Collections.Generic
Imports ACBVentas
Imports ACEVentas
Imports ACFramework

Imports C1.Win.C1FlexGrid

Public Class MUsuarioPorAlmacen
#Region " Variables "
   Private managerVENT_UsuariosPorAlmacen As BUsuariosPorAlmacen
   Private managerEntidades As BEntidades
   Private bs_sucursales As BindingSource
   Private bs_almacen As BindingSource
   Private bs_usuarios As BindingSource
   Private bs_zonas As BindingSource
   Private m_listBindHelper As List(Of ACBindHelper)
   Private m_ealmacen As EAlmacenes

#End Region

#Region " Propiedades "

#End Region

#Region " Constructores "
   Public Sub New()

      ' This call is required by the Windows Form Designer.
      InitializeComponent()
      ' Add any initialization after the InitializeComponent() call.
      Try
         tabMantenimiento.HideTabsMode = Crownwood.DotNetMagic.Controls.HideTabsModes.HideAlways
         tabMantenimiento.SelectedTab = tabBusqueda
         formatearGrilla()
         managerVENT_UsuariosPorAlmacen = New BUsuariosPorAlmacen()
         managerEntidades = New BEntidades()
         cargarCombos()
         m_listBindHelper = New List(Of ACBindHelper)()
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Text), "Ocurrio un error en el proceso Inicio de controles primarios", ex)
      End Try
   End Sub
#End Region

#Region " Metodos "
#Region " Utilitarios "
   ''' <summary>
   ''' Dar Formato a la grilla de busqueda
   ''' </summary>
   ''' <remarks></remarks>
   Private Sub formatearGrilla()
      Dim index As Integer = 1
      Try
         ACFrameworkC1.ACUtilitarios.ACFormatearGrilla(c1grdAlmacen, 1, 1, 4, 1, 0)
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdAlmacen, index, "Codigo", "ALMAC_Id", "ALMAC_Id", 150, True, False, "System.Integer", "") : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdAlmacen, index, "Descripción", "ALMAC_Descripcion", "ALMAC_Descripcion", 150, True, False, "System.String", "") : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdAlmacen, index, "Dirección", "ALMAC_Direccion", "ALMAC_Direccion", 150, True, False, "System.String", "") : index += 1

         c1grdAlmacen.AllowEditing = False
         c1grdAlmacen.Styles.Alternate.BackColor = Color.LightGray
         c1grdAlmacen.Styles.Fixed.TextAlign = TextAlignEnum.CenterCenter
         c1grdAlmacen.Styles.Highlight.BackColor = Color.Gray
         c1grdAlmacen.SelectionMode = SelectionModeEnum.Row

         index = 1
         ACFrameworkC1.ACUtilitarios.ACFormatearGrilla(c1grdUsuarios, 1, 1, 6, 1, 0)
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdUsuarios, index, "Codigo", "ENTID_Codigo", "ENTID_Codigo", 150, True, False, "System.Integer", "") : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdUsuarios, index, "Nombre", "ENTID_Nombres", "ENTID_Nombres", 150, True, False, "System.String", "") : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdUsuarios, index, "D.N.I.", "USUAR_Codigo", "USUAR_Codigo", 150, True, False, "System.String", "") : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdUsuarios, index, "EMail", "ENTID_EMail", "ENTID_EMail", 150, True, False, "System.String", "") : index += 1
         ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdUsuarios, index, "Interno", "ENTID_Id", "ENTID_Id", 150, True, False, "System.String", "") : index += 1

         c1grdUsuarios.AllowEditing = False
         c1grdUsuarios.Styles.Alternate.BackColor = Color.LightGray
         c1grdUsuarios.Styles.Fixed.TextAlign = TextAlignEnum.CenterCenter
         c1grdUsuarios.Styles.Highlight.BackColor = Color.Gray
         c1grdUsuarios.SelectionMode = SelectionModeEnum.Row

      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Text), "No se puede dar formato a la grilla", ex)
      End Try
   End Sub

   Private Sub cargarCombos()
      Try
         bs_zonas = New BindingSource()
         bs_zonas.DataSource = Colecciones.Zonas
         ACUtilitarios.ACCargaCombo(cmbZona, bs_zonas, "ZONAS_Descripcion", "ZONAS_Codigo")
         AddHandler bs_zonas.CurrentChanged, AddressOf bs_zonas_CurrentChanged
         bs_zonas_CurrentChanged(Nothing, Nothing)

         'bs_sucursales = New BindingSource
         'bs_sucursales.DataSource = Colecciones.Sucursales

         'ACFramework.ACUtilitarios.ACCargaCombo(cmbSucursal, bs_sucursales, "SUCUR_Nombre", "SUCUR_Id")
         'AddHandler bs_sucursales.CurrentChanged, AddressOf bs_sucursales_CurrentChanged
         'bs_sucursales_CurrentChanged(Nothing, Nothing)

         Me.Icon = Icon.FromHandle(ACPLogistica.My.Resources.SucursalSeguridad_16x16.GetHicon)
      Catch ex As Exception
         Throw ex
      End Try
   End Sub

   Private Sub bs_zonas_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
      Try
         If Not IsNothing(bs_zonas) Then
            If CType(bs_zonas.DataSource, List(Of EZonas)).Count > 0 Then
               Dim x_zona As String = cmbZona.SelectedValue
               Dim _filter As New ACFiltrador(Of ESucursales)() With {.ACFiltro = String.Format("ZONAS_Codigo={0}", x_zona)}
               bs_sucursales = New BindingSource()
               bs_sucursales.DataSource = _filter.ACFiltrar(Colecciones.Sucursales)
               ACUtilitarios.ACCargaCombo(cmbSucursal, bs_sucursales, "SUCUR_Nombre", "SUCUR_Id")

               AddHandler bs_sucursales.CurrentChanged, AddressOf bs_sucursales_CurrentChanged
               bs_sucursales_CurrentChanged(Nothing, Nothing)
            End If
         End If

      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso Cargar Sucursales", ex)
      End Try
   End Sub

   Private Sub setInstancia(ByVal _opcion As ACFramework.ACUtilitarios.ACSetInstancia)

      Select Case _opcion
         Case ACFramework.ACUtilitarios.ACSetInstancia.Nuevo
            ACFramework.ACUtilitarios.ACSetControl(pnlDatos, True)
            ACFramework.ACUtilitarios.ACLimpiaVar(pnlDatos)
         Case ACFramework.ACUtilitarios.ACSetInstancia.Modificado
            ACFramework.ACUtilitarios.ACSetControl(pnlDatos, True)
         Case ACFramework.ACUtilitarios.ACSetInstancia.Guardar

         Case ACFramework.ACUtilitarios.ACSetInstancia.Deshacer

      End Select

   End Sub

   Private Sub bs_sucursales_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
      Try
         Dim _filter As New ACFiltrador(Of EAlmacenes)
         _filter.ACFiltro = String.Format("ZONAS_Codigo={0} AND SUCUR_Id={1}", cmbZona.SelectedValue, cmbSucursal.SelectedValue)

         bs_almacen = New BindingSource
         bs_almacen.DataSource = _filter.ACFiltrar(Colecciones.Almacenes)
         c1grdAlmacen.DataSource = bs_almacen
         bnavPuntoVenta.BindingSource = bs_almacen
         AddHandler bs_almacen.CurrentChanged, AddressOf bs_almacen_CurrentChanged
         bs_almacen_CurrentChanged(Nothing, Nothing)
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError("Error: " & Me.Text, "Ocurrio un error en el proceso Cambiar Registro", ex)
      End Try
   End Sub

   Private Sub bs_almacen_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
      Try
         If Not IsNothing(bs_almacen.Current) Then
            If Not managerEntidades.getListUsuariosXAlmacen(CType(bs_almacen.Current, EAlmacenes).ALMAC_Id) Then
               managerEntidades.ListEntidades = New List(Of EEntidades)
            End If
         Else
            managerEntidades.ListEntidades = New List(Of EEntidades)
         End If
         bs_usuarios = New BindingSource
         bs_usuarios.DataSource = managerEntidades.ListEntidades
         c1grdUsuarios.DataSource = bs_usuarios
         bnavUsuarios.BindingSource = bs_usuarios
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError("Error: " & Me.Text, "Ocurrio un error en el proceso Cambiar Registro", ex)
      End Try
   End Sub

#End Region

#End Region

#Region "Procesos"

#End Region


#Region " Metodos de Controles"

#End Region

   Private Sub tsbtnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnAgregar.Click
      Try
         Dim m_datos As New DataTable
         If managerEntidades.getUsuarios(GApp.BaseDatosAdmin, m_datos) Then
            Dim frmAyuda As New ACControlesC1.ACAyudaFlex("Usuarios Disponibles", m_datos, False)
            If frmAyuda.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
               managerVENT_UsuariosPorAlmacen.UsuariosPorAlmacen = New EUsuariosPorAlmacen()
               managerVENT_UsuariosPorAlmacen.UsuariosPorAlmacen.ENTID_Codigo = CType(frmAyuda.Respuesta.Rows(0)("Código"), Long)
               managerVENT_UsuariosPorAlmacen.UsuariosPorAlmacen.ALMAC_Id = CType(bs_almacen.Current, EAlmacenes).ALMAC_Id
               managerVENT_UsuariosPorAlmacen.UsuariosPorAlmacen.SUCUR_Id = cmbSucursal.SelectedValue
               managerVENT_UsuariosPorAlmacen.UsuariosPorAlmacen.ZONAS_Codigo = cmbZona.SelectedValue
               managerVENT_UsuariosPorAlmacen.UsuariosPorAlmacen.Instanciar(ACEInstancia.Nuevo)
               managerVENT_UsuariosPorAlmacen.Guardar(GApp.Usuario)
               ACControles.ACDialogos.ACMostrarMensajeSatisfactorio(String.Format("Información: {0}", Me.Text), "Agregado satisfactoriamente")
               bs_almacen_CurrentChanged(Nothing, Nothing)
            End If
         Else
            ACControles.ACDialogos.ACMostrarMensajeInformacion(String.Format("Información: {0}", Me.Text), "No hay usuarios disponibles ")
         End If
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso buscar usuario disponible", ex)
      End Try
   End Sub

   Private Sub tsbtnQuitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnQuitar.Click
      Try
         If Not IsNothing(bs_usuarios.Current) Then
            managerVENT_UsuariosPorAlmacen.UsuariosPorAlmacen = New EUsuariosPorAlmacen()
            managerVENT_UsuariosPorAlmacen.UsuariosPorAlmacen.ENTID_Codigo = CType(bs_usuarios.Current, EEntidades).ENTID_Codigo
            managerVENT_UsuariosPorAlmacen.UsuariosPorAlmacen.ALMAC_Id = CType(bs_almacen.Current, EAlmacenes).ALMAC_Id
            managerVENT_UsuariosPorAlmacen.UsuariosPorAlmacen.SUCUR_Id = CType(bs_almacen.Current, EAlmacenes).SUCUR_Id
            managerVENT_UsuariosPorAlmacen.UsuariosPorAlmacen.ZONAS_Codigo = CType(bs_almacen.Current, EAlmacenes).ZONAS_Codigo
            managerVENT_UsuariosPorAlmacen.UsuariosPorAlmacen.Instanciar(ACEInstancia.Eliminado)
            managerVENT_UsuariosPorAlmacen.Guardar(GApp.Usuario)
            ACControles.ACDialogos.ACMostrarMensajeSatisfactorio(String.Format("Información: {0}", Me.Text), "Eliminado satisfactoriamente")
            bs_almacen_CurrentChanged(Nothing, Nothing)
         End If
      Catch ex As Exception
         ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso quitar usuario", ex)
      End Try
   End Sub

End Class