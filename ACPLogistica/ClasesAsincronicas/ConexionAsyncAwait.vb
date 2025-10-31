Public Class ConexionAsyncAwait


    Private Property CadenaConexion As String

    Private Property PuntoVenta As String
    Private Property Sucursal As String
    Private Property Usuario As String
    Private Property Password As String



    Sub New()
        Me.PuntoVenta = PuntoVenta
        Me.Sucursal = Sucursal
        Me.Usuario = Usuario
        Me.Password = Password
    End Sub

    Private Async Function ConexionAsync() As Threading.Tasks.Task



    End Function


End Class
