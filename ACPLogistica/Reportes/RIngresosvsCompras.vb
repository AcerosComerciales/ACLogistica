Imports ACBLogistica
Imports ACEVentas
Imports ACBVentas
Imports ACELogistica
Imports DAConexion
Imports ACFramework
Imports ACSeguridad
Imports Microsoft.Practices.Unity
Imports C1.Win.C1FlexGrid



Public Class RIngresosvsCompras
#Region " Variables "

    Private bs_guias As BindingSource
    Private managerEntidades As BEntidades
    Private managerGenerarGuias As BGenerarGuias
    Private m_eentidades As EEntidades
    Dim xlistacompras As List(Of String)

    Private managerGenerarRegMercTransito As BGenerarRegMercTransito
    'prueba
  
    Private bs_reporte As BindingSource
    Private bs_pv as BindingSource
    Private frmCons As CProductos
    Private m_earticulos As EArticulos
    Private m_reporte As ACBLogistica.BReporte

    Private managerConsultaArticulos As BConsultaArticulos
    Private m_entid_codigo As String
    Private m_artic_codigo As String
    Private m_artic_descripion As String
    Private m_cargado As Boolean = False


#End Region

#Region " Constructores "
    Public Sub New(ByVal x_icono As System.Drawing.Bitmap)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Try
            managerGenerarRegMercTransito = New BGenerarRegMercTransito(GApp.Periodo)
           
            managerEntidades = New BEntidades
            managerConsultaArticulos = New BConsultaArticulos(GApp.Periodo)
            m_reporte = New ACBLogistica.BReporte(GApp.Almacen, GApp.Periodo, GApp.Sucursal)


            actxaProRazonSocial.ACActivarAyudaAuto = False
            Dim _filter As New ACFramework.ACFiltrador(Of EAlmacenes)(String.Format("ALMAC_Activo=True"))
             Colecciones.GetAlmacenesAccesoTodos()
            formatearGrilla()
            formatearGrillaPV()
             bs_pv = New BindingSource
             bs_pv.DataSource = _filter.ACFiltrar(Colecciones.AlmacenesAcceso)
             c1grdPuntosVentas.DataSource = bs_pv
            
            If Not IsNothing(x_icono) Then Me.Icon = Icon.FromHandle(x_icono.GetHicon)

        Catch ex As Exception
            ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), Colecciones.getError("00000"), ex)
        End Try
    End Sub
#End Region

#Region "metodos"

     Private Sub formatearGrillaPV()

        Dim index As Integer = 1
        Try

             ACFrameworkC1.ACUtilitarios.ACFormatearGrilla(c1grdPuntosVentas, 1, 1, 3, 1)
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdPuntosVentas, index, "X", "Seleccionar", "Seleccionar", 80, True, True, "System.Boolean") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdPuntosVentas, index, "Almacenes", "ALMAC_Descripcion", "ALMAC_Descripcion", 150, True, False, "System.Decimal", Parametros.GetParametro(EParametros.TipoParametros.pg_FMondo2d)) : index += 1

            c1grdPuntosVentas.AllowEditing = True
            c1grdPuntosVentas.Styles.Alternate.BackColor = Color.LightGray
            c1grdPuntosVentas.Styles.Fixed.TextAlign = TextAlignEnum.CenterCenter
            c1grdPuntosVentas.Styles.Highlight.BackColor = Color.Gray
            c1grdPuntosVentas.SelectionMode = SelectionModeEnum.Row
       Catch ex As Exception
            ACControles.ACDialogos.ACMostrarMensajeError("Error: " + Me.Text, "No se puede dar formato a la grilla", ex)
        End Try
    End Sub
    
    Private Sub formatearGrilla()

        
        Dim index As Integer = 1
        Try
            index = 1
            ACFrameworkC1.ACUtilitarios.ACFormatearGrilla(c1grdBusqueda, 1, 1, 20, 1, 0)
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Fec. Doc", "INGC_fecDocumento", "INGC_fecDocumento", 90, True, False, "System.DateTime", Parametros.GetParametro(EParametros.TipoParametros.pg_FormatoFecha)) : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Doc. Compra", "INGC_docCompra", "INGC_docCompra", 90, True, False, "System.String") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "id_ingreso", "INGCO_Id", "INGCO_Id", 90, False, False, "System.String") : index += 1 ''''Datos para modificar con check
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Proveedor", "ENTID_RazonSocial", "ENTID_RazonSocial", 150, True, False, "System.String") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Cod. Producto", "INGCD_Producto", "INGCD_Producto", 90, True, False, "System.String") : index += 1 ''''Datos para modificar con check
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Item", "INGCD_Item", "INGCD_Item", 90, False, False, "System.String") : index += 1 ''''Datos para modificar con check
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Descripción Producto", "INGCD_Producto_Desc", "INGCD_Producto_Desc", 90, True, False, "System.String") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Cantidad Compra", "DOCCD_Cantidad", "DOCCD_Cantidad", 90, True, False, "System.Double") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Almacen Ref.", "ALMAC_Descripcion", "ALMAC_Descripcion", 90, True, False, "System.String") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Documento Relacion", "DocumentoRelacion", "DocumentoRelacion", 90, True, False, "System.String") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Cant. Doc. Relacion", "CantidadDocRelacion", "CantidadDocRelacion", 90, True, False, "System.String") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Nota de Credito", "NotaCredito", "NotaCredito", 90, True, False, "System.String") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Cant. Nota Credito", "CantNotaCredito", "CantNotaCredito", 90, True, False, "System.String") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Guia Devolucion", "GuiaDevolucion", "GuiaDevolucion", 90, True, False, "System.String") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Cant. Guia Devolucion", "CantGuiaDevolucion", "CantGuiaDevolucion", 90, True, False, "System.String") : index += 1

            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Tipo doc Relacion", "TipoDocRelacion", "TipoDocRelacion", 90, false, False, "System.String") : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Diferencia", "Diferencia", "Diferencia", 90, True, False, "System.Decimal", Parametros.GetParametro(EParametros.TipoParametros.pg_FMondo2d)) : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Revision", "INGCO_Revisado", "INGCO_Revisado", 50, True, True, "System.Boolean", Parametros.GetParametro(EParametros.TipoParametros.pg_FMondo2d)) : index += 1
            ACFrameworkC1.ACUtilitarios.ACAgregarColumna(c1grdBusqueda, index, "Estado", "DOCCO_Estado", "DOCCO_Estado", 90, True, False, "System.String")


            c1grdBusqueda.AllowEditing = True
            c1grdBusqueda.Styles.Alternate.BackColor = Color.LightGray
            c1grdBusqueda.Styles.Fixed.TextAlign = TextAlignEnum.CenterCenter
            c1grdBusqueda.Styles.Highlight.BackColor = Color.Gray
            c1grdBusqueda.SelectionMode = SelectionModeEnum.Row
            c1grdBusqueda.AllowSorting = AllowSortingEnum.SingleColumn
            'c1grdReporte.AllowEditing = False
            'c1grdReporte.Styles.Alternate.BackColor = Color.LightGray
            'c1grdReporte.Styles.Fixed.TextAlign = TextAlignEnum.CenterCenter
            'c1grdReporte.Styles.Highlight.BackColor = Color.Gray
            'c1grdReporte.SelectionMode = SelectionModeEnum.Row
            'c1grdReporte.AllowResizing = AllowResizingEnum.None
            'c1grdReporte.DrawMode = C1.Win.C1FlexGrid.DrawModeEnum.OwnerDraw
            'c1grdReporte.Tree.Column = 1

            Dim s As CellStyle = c1grdBusqueda.Styles(CellStyleEnum.Subtotal0)
            s.BackColor = Color.Black
            s.ForeColor = Color.White
            s.Font = New Font(c1grdBusqueda.Font, FontStyle.Bold)

            s = c1grdBusqueda.Styles(CellStyleEnum.Subtotal1)
            s.BackColor = Color.DarkBlue
            s.ForeColor = Color.White
            s = c1grdBusqueda.Styles(CellStyleEnum.Subtotal2)
            s.BackColor = Color.DarkRed
            s.ForeColor = Color.White

            Dim k1 As C1.Win.C1FlexGrid.CellStyle = c1grdBusqueda.Styles.Add("Anulado")
            k1.BackColor = Color.Red
            k1.ForeColor = Color.White
            k1.Font = New Font(c1grdBusqueda.Font, FontStyle.Bold)

            Dim k3 As C1.Win.C1FlexGrid.CellStyle = c1grdBusqueda.Styles.Add("Confirmado")
            k3.BackColor = Color.Green
            k3.ForeColor = Color.White
            k3.Font = New Font(c1grdBusqueda.Font, FontStyle.Bold)

            Dim j1 As C1.Win.C1FlexGrid.CellStyle = c1grdBusqueda.Styles.Add("ISoles")
            j1.BackColor = Color.DarkBlue
            j1.ForeColor = Color.White
            j1.Font = New Font(c1grdBusqueda.Font, FontStyle.Bold)

            Dim j2 As C1.Win.C1FlexGrid.CellStyle = c1grdBusqueda.Styles.Add("IDolares")
            j2.BackColor = Color.Blue
            j2.ForeColor = Color.White
            j2.Font = New Font(c1grdBusqueda.Font, FontStyle.Bold)

            Dim k2 As C1.Win.C1FlexGrid.CellStyle = c1grdBusqueda.Styles.Add("EDolares")
            k2.BackColor = Color.Red
            k2.ForeColor = Color.White
            k2.Font = New Font(c1grdBusqueda.Font, FontStyle.Bold)

            c1grdBusqueda.DrawMode = C1.Win.C1FlexGrid.DrawModeEnum.OwnerDraw

            c1grdBusqueda.Rows(0).AllowMerging = True
            c1grdBusqueda.Rows(0).AllowMerging = True
            
        Catch ex As Exception
            ACControles.ACDialogos.ACMostrarMensajeError("Error: " + Me.Text, "No se puede dar formato a la grilla", ex)
        End Try
    End Sub
#End Region


    Private Sub btnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click
        Try
            busquedaDatos(actxaProRazonSocial.Text)
        Catch ex As Exception
            ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Convert.ToString(Text)), "No se puede cargar la ayuda de los conductores", ex)
        End Try
    End Sub
    Private Function getCampo() As Short
        Try
            If (rbtnproveedor.Checked) Then
                Return 3
            ElseIf rbtngDevolucion.Checked Then
                Return 2
            ElseIf rbtnDocCompra.Checked Then
                Return 0
            ElseIf rbtnDocIngreso.Checked Then
                Return 1
            Else
                Return 3
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function


    Private Function busquedaDatos(ByVal x_cadena As String) As Boolean
        Try

            formatearGrilla()
         If m_reporte.Repor_ing_vs_compras(x_cadena, getCampo(), chkCTodos.Checked, AcFecha.ACDtpFecha_De.Value.Date, AcFecha.ACDtpFecha_A.Value.Date) Then
               
                
                'c1grdBusqueda.DataSource=m_reporte.DTTablavs
                'bnavCBusqueda.BindingSource = c1grdBusqueda.DataSource

                For Each itemAlmacen As EAlmacenes In CType(bs_pv.DataSource, List(Of EAlmacenes))
                    If itemAlmacen.Seleccionar Then
                        If ACUtilitarios.ACCrearCadena("StrConn", itemAlmacen.PVENT_DireccionIP, itemAlmacen.PVENT_BaseDatos, GApp.Usuario_DB, GApp.Password_DB) Then
                            DAEnterprise.Instanciar("StrConn", True)

                            If m_reporte.Repor_ing_vs_comprasDest(ETipos.getTipoDocumento(ETipos.TipoDocumento.NotaCredito)) Then
                                Dim _i As Integer = 1
                                
                                     For items = 0 To m_reporte.DTTablavsdest.Rows.Count-1
               
                                        If (From p In m_reporte.DTTablavs.AsEnumerable()
                                            Where p.Field(Of String)("INGC_docCompra").Equals(m_reporte.DTTablavsdest.Rows(items)("Factura")) And 
                                            p.Field(Of String)("INGCD_Producto").Equals(m_reporte.DTTablavsdest.Rows(items)("ARTIC_Codigo"))
                                            Select p).Any() Then
                                                    Dim consult =(From p In m_reporte.DTTablavs.AsEnumerable()
                                                                  Where p.Field(Of String)("INGC_docCompra").Equals(m_reporte.DTTablavsdest.Rows(items)("Factura") ) And 
                                                                  p.Field(Of String)("INGCD_Producto").Equals(m_reporte.DTTablavsdest.Rows(items)("ARTIC_Codigo"))
                                                                  Select p).Single()    
                                                    consult.Item("DocumentoRelacion")=m_reporte.DTTablavsdest.Rows(items)("DocumentoRelacion")
                                                    consult.Item("CantidadDocRelacion")=m_reporte.DTTablavsdest.Rows(items)("INGCD_Cantidad")
                                                    consult.Item("ALMAC_Descripcion")=m_reporte.DTTablavsdest.Rows(items)("ALMAC_Descripcion")

                                                    Dim cm as CurrencyManager
                                                    cm=Me.BindingContext(m_reporte.DTTablavs)
                                                    cm.Refresh()
                                        End If
                                     Next
                                     m_reporte.DTTablavsdest.Clear()
                            End If
                            
                            If m_reporte.Repor_ing_vs_comprasDest(ETipos.getTipoDocumento(ETipos.TipoDocumento.GuiaRemisionRem)) Then
                                Dim _i As Integer = 1
                                
                                     For items = 0 To m_reporte.DTTablavsdest.Rows.Count-1
               
                                        If (From p In m_reporte.DTTablavs.AsEnumerable()
                                            Where p.Field(Of String)("INGC_docCompra").Equals(m_reporte.DTTablavsdest.Rows(items)("Factura")) And 
                                            p.Field(Of String)("INGCD_Producto").Equals(m_reporte.DTTablavsdest.Rows(items)("ARTIC_Codigo"))
                                            Select p).Any() Then
                                                    Dim consult =(From p In m_reporte.DTTablavs.AsEnumerable()
                                                                  Where p.Field(Of String)("INGC_docCompra").Equals(m_reporte.DTTablavsdest.Rows(items)("Factura") ) And 
                                                                  p.Field(Of String)("INGCD_Producto").Equals(m_reporte.DTTablavsdest.Rows(items)("ARTIC_Codigo"))
                                                                  Select p).Single()    
                                                    consult.Item("NotaCredito")=m_reporte.DTTablavsdest.Rows(items)("DocumentoRelacion")
                                                    consult.Item("CantNotaCredito")=m_reporte.DTTablavsdest.Rows(items)("INGCD_Cantidad")
                                            
                                                    If not String.IsNullOrEmpty((m_reporte.DTTablavsdest.Rows(items)("GUIADEVOLUCION")).ToString())Then
                                                    consult.Item("GuiaDevolucion")=m_reporte.DTTablavsdest.Rows(items)("GUIADEVOLUCION")     
                                                    consult.Item("CantGuiaDevolucion")=m_reporte.DTTablavsdest.Rows(items)("INGCD_Cantidad")     
                                                    End If

                                            

                                                    Dim cm as CurrencyManager
                                                    cm=Me.BindingContext(m_reporte.DTTablavs)
                                                    cm.Refresh()
                                        End If
                                     Next
                                     m_reporte.DTTablavsdest.Clear()

                            End If



                        End If
                        If ACUtilitarios.ACCrearCadena("StrConn", GApp.Servidor, GApp.BaseDatos, GApp.Usuario_DB, GApp.Password_DB) Then
                            DAEnterprise.Instanciar("StrConn", True)
                        End If
                    End If
             Next

                For items = 0 To m_reporte.DTTablavs.Rows.Count-1
                 
                    m_reporte.DTTablavs.Rows(items)("Diferencia")=  m_reporte.DTTablavs.Rows(items)("DOCCD_Cantidad") -(m_reporte.DTTablavs.Rows(items)("CantidadDocRelacion")+m_reporte.DTTablavs.Rows(items)("CantNotaCredito"))

                Next



                c1grdBusqueda.Rows.Count = m_reporte.DTTablavs.Rows.Count + 1
                c1grdBusqueda.DataSource=m_reporte.DTTablavs



                'bnavCBusqueda.BindingSource = c1grdBusqueda.DataSource
               


                'For Each item As DataRow In m_reporte.DTTablavs.Rows
                '    c1grdBusqueda.Rows(_i)("INGC_fecDocumento") = item("INGC_fecDocumento")
                '    c1grdBusqueda.Rows(_i)("INGC_docCompra") = item("INGC_docCompra")
                '    c1grdBusqueda.Rows(_i)("ENTID_RazonSocial") = item("ENTID_RazonSocial")
                '    ''campos para modificar con check
                '    c1grdBusqueda.Rows(_i)("INGCD_Producto") = item("INGCD_Producto")
                '    c1grdBusqueda.Rows(_i)("INGCO_Id") = item("INGCO_Id")
                '    c1grdBusqueda.Rows(_i)("INGCD_Item") = item("INGCD_Item")
                '    ''campos para modificar con check
                '    c1grdBusqueda.Rows(_i)("INGCD_Producto_Desc") = item("INGCD_Producto_Desc")
                '    c1grdBusqueda.Rows(_i)("INGCD_Cantidad") = item("INGCD_Cantidad")
                '    c1grdBusqueda.Rows(_i)("DOCCO_CODIGO") = item("DOCCO_CODIGO")
                '    c1grdBusqueda.Rows(_i)("DOCCO_Cantidad") = item("DOCCO_Cantidad")
                '    c1grdBusqueda.Rows(_i)("NotaCredito_CODIGO") = item("NotaCredito_CODIGO")
                '    c1grdBusqueda.Rows(_i)("NotaCredito_CANTIDAD") = item("NotaCredito_CANTIDAD")
                '    ''valores a modificar
                '    c1grdBusqueda.Rows(_i)("ALMAC_Id") = item("ALMAC_Id")
                '    c1grdBusqueda.Rows(_i)("TIPOS_CodTipoDestino") = item("TIPOS_CodTipoDestino")
                '    c1grdBusqueda.Rows(_i)("INGCD_CantidadTotal") = item("INGCD_CantidadTotal")
                '    c1grdBusqueda.Rows(_i)("INGCD_PesoUnitario") = item("INGCD_PesoUnitario")
                '    c1grdBusqueda.Rows(_i)("INGCD_UsrCrea") = item("INGCD_UsrCrea")
                '    c1grdBusqueda.Rows(_i)("INGCD_FecCrea") = item("INGCD_FecCrea")
                '    c1grdBusqueda.Rows(_i)("INGCD_UsrMod") = item("INGCD_UsrMod")
                '    c1grdBusqueda.Rows(_i)("INGCD_FecMod") = item("INGCD_FecMod")
                '    c1grdBusqueda.Rows(_i)("INGCO_Codigo") = item("INGCO_Codigo")
                '    c1grdBusqueda.Rows(_i)("INGCO_Revisado") = item("INGCO_Revisado")
                '    c1grdBusqueda.Rows(_i)("INGCO_REVISADO_USER") = item("INGCO_REVISADO_USER")
                '    '''
                '    c1grdBusqueda.Rows(_i)("GUIA_CODIGO") = item("GUIA_CODIGO")
                '    c1grdBusqueda.Rows(_i)("GUIAD_CANTIDAD") = item("GUIAD_CANTIDAD")
                '    c1grdBusqueda.Rows(_i)("GUIAD_CODIGO") = item("GUIAD_CODIGO")
                '    c1grdBusqueda.Rows(_i)("GUIADD_CANTIDAD") = item("GUIADD_CANTIDAD")
                    
                '    Dim a As Decimal
                '    If (c1grdBusqueda.Rows(_i)("GUIADD_CANTIDAD") = c1grdBusqueda.Rows(_i)("NotaCredito_CANTIDAD")) Then
                '        a = c1grdBusqueda.Rows(_i)("GUIADD_CANTIDAD")
                '    ElseIf (c1grdBusqueda.Rows(_i)("GUIADD_CANTIDAD") > c1grdBusqueda.Rows(_i)("NotaCredito_CANTIDAD")) Then
                '        a = c1grdBusqueda.Rows(_i)("GUIADD_CANTIDAD")
                '    ElseIf (c1grdBusqueda.Rows(_i)("GUIADD_CANTIDAD") < c1grdBusqueda.Rows(_i)("NotaCredito_CANTIDAD")) Then
                '        a = c1grdBusqueda.Rows(_i)("NotaCredito_CANTIDAD")
                '    End If
                    
                '    c1grdBusqueda.Rows(_i)("Diferencia") = c1grdBusqueda.Rows(_i)("INGCD_Cantidad") - (c1grdBusqueda.Rows(_i)("DOCCO_Cantidad") + c1grdBusqueda.Rows(_i)("GUIAD_CANTIDAD") + a)
                '    c1grdBusqueda.Rows(_i)("DOCCO_Estado") = item("DOCCO_Estado")
                '    If (c1grdBusqueda.Rows(_i)("INGCO_Revisado") = True Or c1grdBusqueda.Rows(_i)("Diferencia") <> 0) Then
                '        c1grdBusqueda.Rows(_i).AllowEditing = False
                '    End If
                '    _i += 1

                'Next
                c1grdBusqueda.AutoSizeCols()
            End If

            'End If
        Catch ex As Exception
             If ACUtilitarios.ACCrearCadena("StrConn", GApp.Servidor, GApp.BaseDatos, GApp.Usuario_DB, GApp.Password_DB) Then
                            DAEnterprise.Instanciar("StrConn", True)
             End If
            ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Convert.ToString(Text)), "Error al cargar los datos", ex)
        End Try
        Return False
    End Function



    Private Sub actxaProRazonSocial_ACAyudaClick(sender As Object, e As EventArgs) Handles actxaProRazonSocial.ACAyudaClick
        Try
            AyudaEntidad(actxaProRazonSocial.Text, 1, "Razon Social", EEntidades.TipoEntidad.Proveedores)
        Catch ex As Exception
            ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso cargar Cliente", ex)
        End Try
    End Sub

    Private Sub AyudaEntidad(ByVal x_cadenas As String, ByVal x_campo As Short, ByVal x_descripcion As String, ByVal x_opcion As EEntidades.TipoEntidad)
        Try
            Dim _campos() As ACCampos = {New ACCampos("@Opcion", x_campo), _
                                       New ACCampos("@Cadena", x_cadenas), _
                                       New ACCampos("@ROLES_Id", x_opcion.GetHashCode.ToString())}
            Dim _busqueda As New ACCampos("@Cadena", x_descripcion)

            Select Case x_opcion
                Case EEntidades.TipoEntidad.Transportista
                Case EEntidades.TipoEntidad.Conductores
                Case EEntidades.TipoEntidad.Proveedores
                    Dim _where As New Hashtable
                    _where.Add(x_campo, New ACWhere(x_cadenas, ACWhere.TipoWhere._Like))
                    Dim Ayuda As New ACControlesC1.ACAyudaTextFlex("Buscar Entidad", "ENTISS_TodosAyuda", _campos, _busqueda, False)

                    If Ayuda.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                        '' Cargar datos del cliente
                        actxaProRazonSocial.Text = Ayuda.Respuesta.Rows(0)("Razon Social")

                    Else
                        ACControles.ACDialogos.ACMostrarMensajeInformacion(String.Format("Información: {0}", Me.Text), "No se puede Cargar la ayuda por que no se encontro registros")
                    End If
            End Select
        Catch ex As Exception
            Throw ex
        End Try


    End Sub
    Private Sub c1grdBusqueda_OwnerDrawCell(sender As Object, e As OwnerDrawCellEventArgs) Handles c1grdBusqueda.OwnerDrawCell
        Try
            If e.Row < c1grdBusqueda.Rows.Fixed OrElse e.Col < c1grdBusqueda.Cols.Fixed Then Return
            'If c1grdBusqueda.Rows(e.Row)("GUIAR_Estado") = "Confirmado" Then
            '    e.Style = c1grdBusqueda.Styles("Confirmado")
            'End If
            'If c1grdBusqueda.Rows(e.Row)("GUIAR_Estado") = "X" Then
            '    e.Style = c1grdBusqueda.Styles("Anulado")
            'End If


            If c1grdBusqueda.Cols(e.Col).Name = "Diferencia" Then
                If c1grdBusqueda(e.Row, "Diferencia") > 0 Or c1grdBusqueda(e.Row, "Diferencia") < 0 Or c1grdBusqueda(e.Row, "Diferencia") > c1grdBusqueda(e.Row, "DOCCD_Cantidad") Then
                    e.Style = c1grdBusqueda.Styles("Anulado")
                End If
                If c1grdBusqueda(e.Row, "Diferencia") = 0 Then
                    e.Style = c1grdBusqueda.Styles("Confirmado")
                End If

            End If

        Catch ex As Exception
            ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), "Ocurrio un error en el proceso cambia de color", ex)
        End Try
    End Sub

    Private Sub tsbtngrabar_Click(sender As Object, e As EventArgs) Handles tsbtngrabar.Click

        Try
            Dim _articulos As String = ""
            Dim _i As Integer = 1
            For Each item As C1.Win.C1FlexGrid.Row In c1grdBusqueda.Rows
                If _i > 1 Then
                    If CType(item("INGCO_Revisado"), Boolean) And item("INGCO_REVISADO_USER") = "" Then
                        _articulos &= String.Format("{0} - {1}-fac.{2}{3}", item("INGCD_Producto"), item("INGCD_Producto_Desc"), item("INGC_docCompra"), vbNewLine)
                    End If
                End If
                _i += 1
            Next

            If Not _articulos.Length > 0 Then Throw New Exception("No puede grabar los registros, por que no se ha realizado ningun cambio")
            If ACControles.ACDialogos.ACMostrarMensajePregunta(String.Format("Guardar Registro: {0}", Me.Text) _
                                        , "Desea Guardar los registros Revisados: " _
                                        , _articulos _
                                        , ACControles.ACDialogos.LabelBotom.Si_No) = DialogResult.Yes Then
                _i = 1
                Dim managerlprecios As New BABAS_IngresosCompraDetalle
                Dim _detallesIngreos As New EABAS_IngresosCompraDetalle
                managerlprecios.ListABAS_IngresosCompraDetalle = New List(Of EABAS_IngresosCompraDetalle)
                Dim _fecha As DateTime = DateTime.Now()


                For Each item As C1.Win.C1FlexGrid.Row In c1grdBusqueda.Rows
                    If _i > 1 Then
                        If CType(item("INGCO_Revisado"), Boolean) And item("INGCO_REVISADO_USER") = "" Then
                            _detallesIngreos.ARTIC_Codigo = item("INGCD_Producto")
                            _detallesIngreos.INGCD_Item = item("INGCD_Item")
                            _detallesIngreos.INGCO_Id = item("INGCO_Id")
                            _detallesIngreos.INGCO_Revisado = CType(item("INGCO_Revisado"), Boolean)
                            _detallesIngreos.INGCO_REVISADO_USER = GApp.Usuario
                            _detallesIngreos.INGCO_REVISADO_FECHA = _fecha
                            ''datos modificados
                            _detallesIngreos.ALMAC_Id = item("ALMAC_Id")
                            _detallesIngreos.TIPOS_CodTipoDestino = item("TIPOS_CodTipoDestino")
                            _detallesIngreos.INGCD_CantidadTotal = Convert.ToDecimal(item("INGCD_CantidadTotal"))
                            _detallesIngreos.INGCD_Cantidad = Convert.ToDecimal(item("INGCD_Cantidad"))
                            _detallesIngreos.INGCD_PesoUnitario = Convert.ToDecimal(item("INGCD_PesoUnitario"))
                            _detallesIngreos.INGCD_UsrCrea = item("INGCD_UsrCrea")
                            _detallesIngreos.INGCD_FecCrea = item("INGCD_FecCrea")
                            _detallesIngreos.INGCD_UsrMod = GApp.Usuario
                            _detallesIngreos.INGCD_FecMod = _fecha
                            _detallesIngreos.INGCO_Codigo = item("INGCO_Codigo")
                            ''

                            managerlprecios.ListABAS_IngresosCompraDetalle.Add(_detallesIngreos)

                            'manageringresos.ListABAS_IngresosCompradetalle.Add(_detallesIngreos)
                            'managerlprecios.ListVENT_ListaPreciosArticulos.Add(_listaprecart)
                            'End If
                            managerGenerarRegMercTransito.GrabaIngresoCompradetalle(managerlprecios.ListABAS_IngresosCompraDetalle, GApp.Usuario)
                            End If
                    End If
                    _i += 1
                Next
                '_precios.Precios = New EPrecios
                '_precios.Precios = itemPrecios
                '_precios.Precios.Instanciar(ACFramework.ACEInstancia.Modificado)
                ' managerGenerarRegMercTransito.GrabaIngresoCompradetalle(managerlprecios.ListABAS_IngresosCompraDetalle, GApp.Usuario)
                'manageringresos.ListABAS_IngresosCompraDetalle.Clear()
                '                manageringresos.ABAS_IngresosCompradetalle.Instanciar(ACFramework.ACEInstancia.Modificado)
                'If manageringresos.Guardarother(GApp.Usuario) Then
                ACControles.ACDialogos.ACMostrarMensajeSatisfactorio(String.Format("Información: {0}", Me.Text), String.Format(("Grabado Satisfacoriamente")))
                '    _i = 1
                '    For Each item As C1.Win.C1FlexGrid.Row In c1grdBusqueda.Rows
                '        If _i > 2 Then
                '            item("revision") = False
                '        End If
                '        _i += 1
                '    Next
                busquedaDatos("")
                'Else
                '    Throw New Exception("No se puede completar la operación Grabar Rergistro")
                'End If
                End If

        Catch ex As Exception
            ACControles.ACDialogos.ACMostrarMensajeError(String.Format("Error: {0}", Me.Text), String.Format(Colecciones.getError("00101"), "Guardando Cambios"), ex)
        End Try

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        'Asignar Tabla excel Para generar Reporte
        Try
            Utilitarios.ExportarXLS(c1grdBusqueda, "Reporte Entregas")
        Catch ex As Exception
            ACControles.ACDialogos.ACMostrarMensajeInformacion(String.Format("Información: {0}", Me.Text), "No se puede Exportar a Excel")
        End Try
    End Sub
End Class